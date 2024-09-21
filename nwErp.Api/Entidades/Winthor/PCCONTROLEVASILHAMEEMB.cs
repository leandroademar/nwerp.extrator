

////// // namespace nwErp.Entidades.Winthor;

// // namespace nwErp.Api.Modelos;

[Serializable]
public class PCCONTROLEVASILHAMEEMB : GerenteDePropriedades, IEntidade
{
    private decimal? _codauxiliar;

    private decimal? _codcontrole;

    private string _codfilial;

    private decimal? _codvasilhame;

    private DateTime? _dtentrada;

    private decimal? _matricula;

    private decimal? _qtentrada;

    private decimal? _qtsaida;

    private string _vendido;

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONTROLEVASILHAMEEMB", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 20, Precisao = 0)]
    public decimal? Codauxiliar
    {
        get
        {
            PropriedadeAcessada("Codauxiliar");
            return _codauxiliar;
        }
        set
        {
            PropriedadeModificada("Codauxiliar", value);
            _codauxiliar = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONTROLEVASILHAMEEMB", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Codcontrole
    {
        get
        {
            PropriedadeAcessada("Codcontrole");
            return _codcontrole;
        }
        set
        {
            PropriedadeModificada("Codcontrole", value);
            _codcontrole = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONTROLEVASILHAMEEMB", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Codfilial
    {
        get
        {
            PropriedadeAcessada("Codfilial");
            return _codfilial;
        }
        set
        {
            PropriedadeModificada("Codfilial", value);
            _codfilial = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONTROLEVASILHAMEEMB", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codvasilhame
    {
        get
        {
            PropriedadeAcessada("Codvasilhame");
            return _codvasilhame;
        }
        set
        {
            PropriedadeModificada("Codvasilhame", value);
            _codvasilhame = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONTROLEVASILHAMEEMB", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtentrada
    {
        get
        {
            PropriedadeAcessada("Dtentrada");
            return _dtentrada;
        }
        set
        {
            PropriedadeModificada("Dtentrada", value);
            _dtentrada = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONTROLEVASILHAMEEMB", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Matricula
    {
        get
        {
            PropriedadeAcessada("Matricula");
            return _matricula;
        }
        set
        {
            PropriedadeModificada("Matricula", value);
            _matricula = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONTROLEVASILHAMEEMB", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 3)]
    public decimal? Qtentrada
    {
        get
        {
            PropriedadeAcessada("Qtentrada");
            return _qtentrada;
        }
        set
        {
            PropriedadeModificada("Qtentrada", value);
            _qtentrada = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONTROLEVASILHAMEEMB", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 3)]
    public decimal? Qtsaida
    {
        get
        {
            PropriedadeAcessada("Qtsaida");
            return _qtsaida;
        }
        set
        {
            PropriedadeModificada("Qtsaida", value);
            _qtsaida = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONTROLEVASILHAMEEMB", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Vendido
    {
        get
        {
            PropriedadeAcessada("Vendido");
            return _vendido;
        }
        set
        {
            PropriedadeModificada("Vendido", value);
            _vendido = value;
        }
    }

    public void InicializarAtributos()
    {
    }

    public string ObterNomeTabela()
    {
        return "PCCONTROLEVASILHAMEEMB";
    }

    public IEntidade NovaInstancia()
    {
        return (IEntidade)GetType().GetConstructors()[0].Invoke(null);
    }

    public void CarregarPorDataReader(IDataReader leitor)
    {
        _codauxiliar = AlterarTipo<decimal?>(leitor["Codauxiliar"]);
        _codcontrole = AlterarTipo<decimal?>(leitor["Codcontrole"]);
        _codfilial = AlterarTipo<string>(leitor["Codfilial"]);
        _codvasilhame = AlterarTipo<decimal?>(leitor["Codvasilhame"]);
        _dtentrada = AlterarTipo<DateTime?>(leitor["Dtentrada"]);
        _matricula = AlterarTipo<decimal?>(leitor["Matricula"]);
        _qtentrada = AlterarTipo<decimal?>(leitor["Qtentrada"]);
        _qtsaida = AlterarTipo<decimal?>(leitor["Qtsaida"]);
        _vendido = AlterarTipo<string>(leitor["Vendido"]);
    }

}