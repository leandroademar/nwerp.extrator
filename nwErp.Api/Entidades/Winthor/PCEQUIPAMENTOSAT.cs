

////// // namespace nwErp.Entidades.Winthor;

// // namespace nwErp.Api.Modelos;

[Serializable]
public class PCEQUIPAMENTOSAT : GerenteDePropriedades, IEntidade
{
    private string _codativacao;

    private string _marca;

    private string _modelo;

    private decimal? _numsat;

    private string _numserie;

    private string _versao;

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEQUIPAMENTOSAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
    public string Codativacao
    {
        get
        {
            PropriedadeAcessada("Codativacao");
            return _codativacao;
        }
        set
        {
            PropriedadeModificada("Codativacao", value);
            _codativacao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCEQUIPAMENTOSAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
    public string Marca
    {
        get
        {
            PropriedadeAcessada("Marca");
            return _marca;
        }
        set
        {
            PropriedadeModificada("Marca", value);
            _marca = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEQUIPAMENTOSAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
    public string Modelo
    {
        get
        {
            PropriedadeAcessada("Modelo");
            return _modelo;
        }
        set
        {
            PropriedadeModificada("Modelo", value);
            _modelo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEQUIPAMENTOSAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Numsat
    {
        get
        {
            PropriedadeAcessada("Numsat");
            return _numsat;
        }
        set
        {
            PropriedadeModificada("Numsat", value);
            _numsat = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCEQUIPAMENTOSAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 13, Precisao = 0)]
    public string Numserie
    {
        get
        {
            PropriedadeAcessada("Numserie");
            return _numserie;
        }
        set
        {
            PropriedadeModificada("Numserie", value);
            _numserie = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEQUIPAMENTOSAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
    public string Versao
    {
        get
        {
            PropriedadeAcessada("Versao");
            return _versao;
        }
        set
        {
            PropriedadeModificada("Versao", value);
            _versao = value;
        }
    }

    public void InicializarAtributos()
    {
    }

    public string ObterNomeTabela()
    {
        return "PCEQUIPAMENTOSAT";
    }

    public IEntidade NovaInstancia()
    {
        return (IEntidade)GetType().GetConstructors()[0].Invoke(null);
    }

    public void CarregarPorDataReader(IDataReader leitor)
    {
        _codativacao = AlterarTipo<string>(leitor["Codativacao"]);
        _marca = AlterarTipo<string>(leitor["Marca"]);
        _modelo = AlterarTipo<string>(leitor["Modelo"]);
        _numsat = AlterarTipo<decimal?>(leitor["Numsat"]);
        _numserie = AlterarTipo<string>(leitor["Numserie"]);
        _versao = AlterarTipo<string>(leitor["Versao"]);
    }

}