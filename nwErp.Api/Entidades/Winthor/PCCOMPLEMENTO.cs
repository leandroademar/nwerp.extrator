

////// // namespace nwErp.Entidades.Winthor;

// // namespace nwErp.Api.Modelos;

[Serializable]
public class PCCOMPLEMENTO : GerenteDePropriedades, IEntidade
{
    private string _complemento1;

    private string _complemento2;

    private string _complemento3;

    private string _nometabela;

    private decimal? _numped;

    private decimal? _numtrans;

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCOMPLEMENTO", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 80, Precisao = 0)]
    public string Complemento1
    {
        get
        {
            PropriedadeAcessada("Complemento1");
            return _complemento1;
        }
        set
        {
            PropriedadeModificada("Complemento1", value);
            _complemento1 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCOMPLEMENTO", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 300, Precisao = 0)]
    public string Complemento2
    {
        get
        {
            PropriedadeAcessada("Complemento2");
            return _complemento2;
        }
        set
        {
            PropriedadeModificada("Complemento2", value);
            _complemento2 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCOMPLEMENTO", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 80, Precisao = 0)]
    public string Complemento3
    {
        get
        {
            PropriedadeAcessada("Complemento3");
            return _complemento3;
        }
        set
        {
            PropriedadeModificada("Complemento3", value);
            _complemento3 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCOMPLEMENTO", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 80, Precisao = 0)]
    public string Nometabela
    {
        get
        {
            PropriedadeAcessada("Nometabela");
            return _nometabela;
        }
        set
        {
            PropriedadeModificada("Nometabela", value);
            _nometabela = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCOMPLEMENTO", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numped
    {
        get
        {
            PropriedadeAcessada("Numped");
            return _numped;
        }
        set
        {
            PropriedadeModificada("Numped", value);
            _numped = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCOMPLEMENTO", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 0)]
    public decimal? Numtrans
    {
        get
        {
            PropriedadeAcessada("Numtrans");
            return _numtrans;
        }
        set
        {
            PropriedadeModificada("Numtrans", value);
            _numtrans = value;
        }
    }

    public void InicializarAtributos()
    {
    }

    public string ObterNomeTabela()
    {
        return "PCCOMPLEMENTO";
    }

    public IEntidade NovaInstancia()
    {
        return (IEntidade)GetType().GetConstructors()[0].Invoke(null);
    }

    public void CarregarPorDataReader(IDataReader leitor)
    {
        _complemento1 = AlterarTipo<string>(leitor["Complemento1"]);
        _complemento2 = AlterarTipo<string>(leitor["Complemento2"]);
        _complemento3 = AlterarTipo<string>(leitor["Complemento3"]);
        _nometabela = AlterarTipo<string>(leitor["Nometabela"]);
        _numped = AlterarTipo<decimal?>(leitor["Numped"]);
        _numtrans = AlterarTipo<decimal?>(leitor["Numtrans"]);
    }

}