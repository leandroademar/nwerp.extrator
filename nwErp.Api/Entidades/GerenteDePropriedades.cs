using System.ComponentModel;
using System.Diagnostics;

////namespace nwErp.Entidades;

public class GerenteDePropriedades
{
	private PosicaoEntidade _posicaoEntidade;

	private List<InformacoesDePropriedade> _propriedades;

	private static bool _registrarInformacao;

    public GerenteDePropriedades()
    {
        _propriedades = new List<InformacoesDePropriedade>();
        PosicaoEntidade = PosicaoEntidade.Nova;
        PropriedadeAcessada($"Criada a entidade {GetType().Name}");
    }

    [XmlIgnore]
	public PosicaoEntidade PosicaoEntidade
	{
		get
		{
			return _posicaoEntidade;
		}
		set
		{
			if (_posicaoEntidade != value)
			{
				if ((value == PosicaoEntidade.Persistindo || value == PosicaoEntidade.Carregada) && _propriedades.Count > 0)
				{
					_propriedades.Clear();
				}
				_posicaoEntidade = value;
			}
		}
	}

	[XmlIgnore]
	public PropertyInfo[] PropriedadesModificadas => (from item in _propriedades
		where item.Modificada
		select item.Propriedade).ToArray();

	public string IdentificacaoDoRegistro { get; set; }

	public event EventHandler PropriedadaModificada;

	

	protected void PropriedadeModificada(string nomePropriedade, object valor)
	{
		if (PosicaoEntidade != 0)
		{
			PropriedadeAcessada(string.Format("Alterado o objeto \"{0}\", propriedade \"{1}\" modificada para: {2}", GetType().Name, nomePropriedade, (valor ?? "vazio").ToString()));
		}
		PosicaoEntidade posicaoEntidade = PosicaoEntidade;
		if (posicaoEntidade != 0 && (uint)(posicaoEntidade - 1) <= 4u)
		{
			PreencherValoresModificados(nomePropriedade, valor);
		}
	}

	[Conditional("DEBUG")]
	public static void AtivarRegistroDeInformacoes(bool registrarInformacao)
	{
		_registrarInformacao = registrarInformacao;
	}

	[Conditional("DEBUG")]
	protected void RegistrarInformacao(string informacao)
	{
		_ = _registrarInformacao;
	}

	protected void PropriedadeAcessada(string nomePropriedade)
	{
		if (this.PropriedadaModificada != null)
		{
			this.PropriedadaModificada(this, new PropriedadeModificada_EventArgs(nomePropriedade));
		}
	}

	private void PreencherValoresModificados(string nomePropriedade, object valor)
	{
		if (PosicaoEntidade != 0)
		{
			InformacoesDePropriedade informacoesDePropriedade = null;
			IEnumerable<InformacoesDePropriedade> source = _propriedades.Where((InformacoesDePropriedade item) => item.Nome == nomePropriedade);
			if (source.Count() > 0)
			{
				informacoesDePropriedade = source.First();
			}
			else
			{
				informacoesDePropriedade = CriarInformacao(nomePropriedade);
				informacoesDePropriedade.ValorOriginal = informacoesDePropriedade.Propriedade.GetValue(this, null);
			}
			informacoesDePropriedade.NovoValor = valor;
			if (PosicaoEntidade == PosicaoEntidade.Carregada || PosicaoEntidade == PosicaoEntidade.CarregadaParcialmente)
			{
				PosicaoEntidade = PosicaoEntidade.Alterada;
			}
		}
	}

	private InformacoesDePropriedade CriarInformacao(string nomePropriedade)
	{
		InformacoesDePropriedade informacoesDePropriedade = new InformacoesDePropriedade(GetType().GetProperty(nomePropriedade));
		_propriedades.Add(informacoesDePropriedade);
		return informacoesDePropriedade;
	}

	public virtual GerenteDePropriedades ClonarGerente()
	{
		GerenteDePropriedades gerenteDePropriedades = (GerenteDePropriedades)MemberwiseClone();
		gerenteDePropriedades._propriedades = new List<InformacoesDePropriedade>();
		gerenteDePropriedades.PosicaoEntidade = PosicaoEntidade.Nova;
		PropertyInfo[] properties = gerenteDePropriedades.GetType().GetProperties();
		foreach (PropertyInfo propriedade in properties)
		{
			IEnumerable<InformacoesDePropriedade> source = _propriedades.Where((InformacoesDePropriedade prop) => prop.Propriedade.Name == propriedade.Name);
			if (source.Count() > 0)
			{
				gerenteDePropriedades._propriedades.Add(source.First());
			}
		}
		return gerenteDePropriedades;
	}

	protected T AlterarTipo<T>(object value)
	{
		Type type = typeof(T);
		if (type == null)
		{
			throw new ArgumentNullException("conversionType");
		}
		if (type.IsGenericType && type.GetGenericTypeDefinition().Equals(typeof(Nullable<>)))
		{
			if (value == null)
			{
				return default(T);
			}
			type = new NullableConverter(type).UnderlyingType;
		}
		if (value is DBNull)
		{
			return default(T);
		}
		try
		{
			return (T)Convert.ChangeType(value, type);
		}
		catch (Exception innerException)
		{
			throw new Exception($"Ocorreu um erro ao converter o valor {value} do tipo {value.GetType().Name} para o tipo {type.Name}", innerException);
		}
	}
}
