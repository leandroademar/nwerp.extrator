

////// namespace nwErp.Entidades.Winthor;

// namespace nwErp.Api.Modelos;

[Serializable]
public class PCLOGFATECF : GerenteDePropriedades, IEntidade
{
    private static readonly string RO_CODFUNCCX = "Codfunccx";

    private decimal? _codfunccx;

    private static readonly string RO_CODIGO = "Codigo";

    private decimal _codigo;

    private static readonly string RO_CODROTINA = "Codrotina";

    private decimal _codrotina;

    private static readonly string RO_DATA = "Data";

    private DateTime? _data;

    private static readonly string RO_FINALIZADOCOMSUCESSO = "Finalizadocomsucesso";

    private string _finalizadocomsucesso;

    private static readonly string RO_NUMCAIXA = "Numcaixa";

    private decimal? _numcaixa;

    private static readonly string RO_NUMORCA = "Numorca";

    private decimal? _numorca;

    private static readonly string RO_NUMPEDECF = "Numpedecf";

    private decimal? _numpedecf;

    private static readonly string RO_NUMSERIEEQUIP = "Numserieequip";

    private string _numserieequip;

    private static readonly string RO_NUMVALE = "Numvale";

    private decimal? _numvale;

    private static readonly string RO_TABELA = "Tabela";

    private string _tabela;

    private static readonly string RO_VERSAO = "Versao";

    private string _versao;

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOGFATECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfunccx
    {
        get
        {
            PropriedadeAcessada(RO_CODFUNCCX);
            return _codfunccx;
        }
        set
        {
            PropriedadeModificada(RO_CODFUNCCX, value);
            _codfunccx = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOGFATECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal Codigo
    {
        get
        {
            PropriedadeAcessada(RO_CODIGO);
            return _codigo;
        }
        set
        {
            PropriedadeModificada(RO_CODIGO, value);
            _codigo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOGFATECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 0)]
    public decimal Codrotina
    {
        get
        {
            PropriedadeAcessada(RO_CODROTINA);
            return _codrotina;
        }
        set
        {
            PropriedadeModificada(RO_CODROTINA, value);
            _codrotina = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOGFATECF", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Data
    {
        get
        {
            PropriedadeAcessada(RO_DATA);
            return _data;
        }
        set
        {
            PropriedadeModificada(RO_DATA, value);
            _data = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOGFATECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Finalizadocomsucesso
    {
        get
        {
            PropriedadeAcessada(RO_FINALIZADOCOMSUCESSO);
            return _finalizadocomsucesso;
        }
        set
        {
            PropriedadeModificada(RO_FINALIZADOCOMSUCESSO, value);
            _finalizadocomsucesso = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOGFATECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Numcaixa
    {
        get
        {
            PropriedadeAcessada(RO_NUMCAIXA);
            return _numcaixa;
        }
        set
        {
            PropriedadeModificada(RO_NUMCAIXA, value);
            _numcaixa = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOGFATECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numorca
    {
        get
        {
            PropriedadeAcessada(RO_NUMORCA);
            return _numorca;
        }
        set
        {
            PropriedadeModificada(RO_NUMORCA, value);
            _numorca = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOGFATECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numpedecf
    {
        get
        {
            PropriedadeAcessada(RO_NUMPEDECF);
            return _numpedecf;
        }
        set
        {
            PropriedadeModificada(RO_NUMPEDECF, value);
            _numpedecf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOGFATECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 30, Precisao = 0)]
    public string Numserieequip
    {
        get
        {
            PropriedadeAcessada(RO_NUMSERIEEQUIP);
            return _numserieequip;
        }
        set
        {
            PropriedadeModificada(RO_NUMSERIEEQUIP, value);
            _numserieequip = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOGFATECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numvale
    {
        get
        {
            PropriedadeAcessada(RO_NUMVALE);
            return _numvale;
        }
        set
        {
            PropriedadeModificada(RO_NUMVALE, value);
            _numvale = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOGFATECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 30, Precisao = 0)]
    public string Tabela
    {
        get
        {
            PropriedadeAcessada(RO_TABELA);
            return _tabela;
        }
        set
        {
            PropriedadeModificada(RO_TABELA, value);
            _tabela = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOGFATECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
    public string Versao
    {
        get
        {
            PropriedadeAcessada(RO_VERSAO);
            return _versao;
        }
        set
        {
            PropriedadeModificada(RO_VERSAO, value);
            _versao = value;
        }
    }

    public void InicializarAtributos()
    {
    }

    public string ObterNomeTabela()
    {
        return "PCLOGFATECF";
    }

    public IEntidade NovaInstancia()
    {
        return (IEntidade)GetType().GetConstructors()[0].Invoke(null);
    }

    public void CarregarPorDataReader(IDataReader leitor)
    {
        _codfunccx = AlterarTipo<decimal?>(leitor["Codfunccx"]);
        _codigo = AlterarTipo<decimal>(leitor["Codigo"]);
        _codrotina = AlterarTipo<decimal>(leitor["Codrotina"]);
        _data = AlterarTipo<DateTime?>(leitor["Data"]);
        _finalizadocomsucesso = AlterarTipo<string>(leitor["Finalizadocomsucesso"]);
        _numcaixa = AlterarTipo<decimal?>(leitor["Numcaixa"]);
        _numorca = AlterarTipo<decimal?>(leitor["Numorca"]);
        _numpedecf = AlterarTipo<decimal?>(leitor["Numpedecf"]);
        _numserieequip = AlterarTipo<string>(leitor["Numserieequip"]);
        _numvale = AlterarTipo<decimal?>(leitor["Numvale"]);
        _tabela = AlterarTipo<string>(leitor["Tabela"]);
        _versao = AlterarTipo<string>(leitor["Versao"]);
    }

}