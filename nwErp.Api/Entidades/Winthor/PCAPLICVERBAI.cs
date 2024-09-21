

////// // namespace nwErp.Entidades.Winthor;

// // namespace nwErp.Api.Modelos;

[Serializable]
public class PCAPLICVERBAI : GerenteDePropriedades, IEntidade
{
    private static readonly string RO_CODCONTA = "Codconta";

    private decimal? _codconta;

    private static readonly string RO_CODFILIAL = "Codfilial";

    private string _codfilial;

    private static readonly string RO_CODPROD = "Codprod";

    private decimal _codprod;

    private static readonly string RO_CUSTOFINANT = "Custofinant";

    private decimal? _custofinant;

    private static readonly string RO_CUSTOFINATUAL = "Custofinatual";

    private decimal? _custofinatual;

    private static readonly string RO_CUSTOFORNECANT = "Custofornecant";

    private decimal? _custofornecant;

    private static readonly string RO_CUSTOFORNECATUAL = "Custofornecatual";

    private decimal? _custofornecatual;

    private static readonly string RO_CUSTOPROXIMACOMPRAANT = "Custoproximacompraant";

    private decimal? _custoproximacompraant;

    private static readonly string RO_CUSTOPROXIMACOMPRAATUAL = "Custoproximacompraatual";

    private decimal? _custoproximacompraatual;

    private static readonly string RO_CUSTOREALANT = "Custorealant";

    private decimal? _custorealant;

    private static readonly string RO_CUSTOREALATUAL = "Custorealatual";

    private decimal? _custorealatual;

    private static readonly string RO_CUSTOREALSEMSTANT = "Custorealsemstant";

    private decimal? _custorealsemstant;

    private static readonly string RO_CUSTOREALSEMSTATUAL = "Custorealsemstatual";

    private decimal? _custorealsemstatual;

    private static readonly string RO_CUSTOREPANT = "Custorepant";

    private decimal? _custorepant;

    private static readonly string RO_CUSTOREPATUAL = "Custorepatual";

    private decimal? _custorepatual;

    private static readonly string RO_CUSTOULTENTANT = "Custoultentant";

    private decimal? _custoultentant;

    private static readonly string RO_CUSTOULTENTATUAL = "Custoultentatual";

    private decimal? _custoultentatual;

    private static readonly string RO_DTAPLIC = "Dtaplic";

    private DateTime? _dtaplic;

    private static readonly string RO_DTFIMVIGENCIA = "Dtfimvigencia";

    private DateTime? _dtfimvigencia;

    private static readonly string RO_DTINICIOVIGENCIA = "Dtiniciovigencia";

    private DateTime? _dtiniciovigencia;

    private static readonly string RO_NUMAPLIC = "Numaplic";

    private decimal _numaplic;

    private static readonly string RO_NUMVERBA = "Numverba";

    private decimal? _numverba;

    private static readonly string RO_PERCAPLIC = "Percaplic";

    private decimal? _percaplic;

    private static readonly string RO_QTESTGER = "Qtestger";

    private decimal? _qtestger;

    private static readonly string RO_QTVENDA = "Qtvenda";

    private decimal? _qtvenda;

    private static readonly string RO_VLAPLIC = "Vlaplic";

    private decimal? _vlaplic;

    private static readonly string RO_VLAPLICUNITARIO = "Vlaplicunitario";

    private decimal? _vlaplicunitario;

    private static readonly string RO_VLCUSTOFIN = "Vlcustofin";

    private decimal? _vlcustofin;

    private static readonly string RO_VLCUSTOFINANT = "Vlcustofinant";

    private decimal? _vlcustofinant;

    private static readonly string RO_VLCUSTOREAL = "Vlcustoreal";

    private decimal? _vlcustoreal;

    private static readonly string RO_VLCUSTOREALANT = "Vlcustorealant";

    private decimal? _vlcustorealant;

    private static readonly string RO_VLVENDA = "Vlvenda";

    private decimal? _vlvenda;

    private static readonly string RO_CONDVENDA = "Condvenda";

    private decimal? _condvenda;

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCAPLICVERBAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Codconta
    {
        get
        {
            PropriedadeAcessada(RO_CODCONTA);
            return _codconta;
        }
        set
        {
            PropriedadeModificada(RO_CODCONTA, value);
            _codconta = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCAPLICVERBAI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Codfilial
    {
        get
        {
            PropriedadeAcessada(RO_CODFILIAL);
            return _codfilial;
        }
        set
        {
            PropriedadeModificada(RO_CODFILIAL, value);
            _codfilial = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCAPLICVERBAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal Codprod
    {
        get
        {
            PropriedadeAcessada(RO_CODPROD);
            return _codprod;
        }
        set
        {
            PropriedadeModificada(RO_CODPROD, value);
            _codprod = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCAPLICVERBAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Custofinant
    {
        get
        {
            PropriedadeAcessada(RO_CUSTOFINANT);
            return _custofinant;
        }
        set
        {
            PropriedadeModificada(RO_CUSTOFINANT, value);
            _custofinant = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCAPLICVERBAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Custofinatual
    {
        get
        {
            PropriedadeAcessada(RO_CUSTOFINATUAL);
            return _custofinatual;
        }
        set
        {
            PropriedadeModificada(RO_CUSTOFINATUAL, value);
            _custofinatual = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCAPLICVERBAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Custofornecant
    {
        get
        {
            PropriedadeAcessada(RO_CUSTOFORNECANT);
            return _custofornecant;
        }
        set
        {
            PropriedadeModificada(RO_CUSTOFORNECANT, value);
            _custofornecant = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCAPLICVERBAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Custofornecatual
    {
        get
        {
            PropriedadeAcessada(RO_CUSTOFORNECATUAL);
            return _custofornecatual;
        }
        set
        {
            PropriedadeModificada(RO_CUSTOFORNECATUAL, value);
            _custofornecatual = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCAPLICVERBAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Custoproximacompraant
    {
        get
        {
            PropriedadeAcessada(RO_CUSTOPROXIMACOMPRAANT);
            return _custoproximacompraant;
        }
        set
        {
            PropriedadeModificada(RO_CUSTOPROXIMACOMPRAANT, value);
            _custoproximacompraant = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCAPLICVERBAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Custoproximacompraatual
    {
        get
        {
            PropriedadeAcessada(RO_CUSTOPROXIMACOMPRAATUAL);
            return _custoproximacompraatual;
        }
        set
        {
            PropriedadeModificada(RO_CUSTOPROXIMACOMPRAATUAL, value);
            _custoproximacompraatual = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCAPLICVERBAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Custorealant
    {
        get
        {
            PropriedadeAcessada(RO_CUSTOREALANT);
            return _custorealant;
        }
        set
        {
            PropriedadeModificada(RO_CUSTOREALANT, value);
            _custorealant = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCAPLICVERBAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Custorealatual
    {
        get
        {
            PropriedadeAcessada(RO_CUSTOREALATUAL);
            return _custorealatual;
        }
        set
        {
            PropriedadeModificada(RO_CUSTOREALATUAL, value);
            _custorealatual = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCAPLICVERBAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Custorealsemstant
    {
        get
        {
            PropriedadeAcessada(RO_CUSTOREALSEMSTANT);
            return _custorealsemstant;
        }
        set
        {
            PropriedadeModificada(RO_CUSTOREALSEMSTANT, value);
            _custorealsemstant = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCAPLICVERBAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Custorealsemstatual
    {
        get
        {
            PropriedadeAcessada(RO_CUSTOREALSEMSTATUAL);
            return _custorealsemstatual;
        }
        set
        {
            PropriedadeModificada(RO_CUSTOREALSEMSTATUAL, value);
            _custorealsemstatual = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCAPLICVERBAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Custorepant
    {
        get
        {
            PropriedadeAcessada(RO_CUSTOREPANT);
            return _custorepant;
        }
        set
        {
            PropriedadeModificada(RO_CUSTOREPANT, value);
            _custorepant = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCAPLICVERBAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Custorepatual
    {
        get
        {
            PropriedadeAcessada(RO_CUSTOREPATUAL);
            return _custorepatual;
        }
        set
        {
            PropriedadeModificada(RO_CUSTOREPATUAL, value);
            _custorepatual = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCAPLICVERBAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Custoultentant
    {
        get
        {
            PropriedadeAcessada(RO_CUSTOULTENTANT);
            return _custoultentant;
        }
        set
        {
            PropriedadeModificada(RO_CUSTOULTENTANT, value);
            _custoultentant = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCAPLICVERBAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Custoultentatual
    {
        get
        {
            PropriedadeAcessada(RO_CUSTOULTENTATUAL);
            return _custoultentatual;
        }
        set
        {
            PropriedadeModificada(RO_CUSTOULTENTATUAL, value);
            _custoultentatual = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCAPLICVERBAI", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtaplic
    {
        get
        {
            PropriedadeAcessada(RO_DTAPLIC);
            return _dtaplic;
        }
        set
        {
            PropriedadeModificada(RO_DTAPLIC, value);
            _dtaplic = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCAPLICVERBAI", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtfimvigencia
    {
        get
        {
            PropriedadeAcessada(RO_DTFIMVIGENCIA);
            return _dtfimvigencia;
        }
        set
        {
            PropriedadeModificada(RO_DTFIMVIGENCIA, value);
            _dtfimvigencia = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCAPLICVERBAI", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtiniciovigencia
    {
        get
        {
            PropriedadeAcessada(RO_DTINICIOVIGENCIA);
            return _dtiniciovigencia;
        }
        set
        {
            PropriedadeModificada(RO_DTINICIOVIGENCIA, value);
            _dtiniciovigencia = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCAPLICVERBAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal Numaplic
    {
        get
        {
            PropriedadeAcessada(RO_NUMAPLIC);
            return _numaplic;
        }
        set
        {
            PropriedadeModificada(RO_NUMAPLIC, value);
            _numaplic = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCAPLICVERBAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Numverba
    {
        get
        {
            PropriedadeAcessada(RO_NUMVERBA);
            return _numverba;
        }
        set
        {
            PropriedadeModificada(RO_NUMVERBA, value);
            _numverba = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCAPLICVERBAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Percaplic
    {
        get
        {
            PropriedadeAcessada(RO_PERCAPLIC);
            return _percaplic;
        }
        set
        {
            PropriedadeModificada(RO_PERCAPLIC, value);
            _percaplic = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCAPLICVERBAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 16, Precisao = 3)]
    public decimal? Qtestger
    {
        get
        {
            PropriedadeAcessada(RO_QTESTGER);
            return _qtestger;
        }
        set
        {
            PropriedadeModificada(RO_QTESTGER, value);
            _qtestger = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCAPLICVERBAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 20, Precisao = 6)]
    public decimal? Qtvenda
    {
        get
        {
            PropriedadeAcessada(RO_QTVENDA);
            return _qtvenda;
        }
        set
        {
            PropriedadeModificada(RO_QTVENDA, value);
            _qtvenda = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCAPLICVERBAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlaplic
    {
        get
        {
            PropriedadeAcessada(RO_VLAPLIC);
            return _vlaplic;
        }
        set
        {
            PropriedadeModificada(RO_VLAPLIC, value);
            _vlaplic = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCAPLICVERBAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlaplicunitario
    {
        get
        {
            PropriedadeAcessada(RO_VLAPLICUNITARIO);
            return _vlaplicunitario;
        }
        set
        {
            PropriedadeModificada(RO_VLAPLICUNITARIO, value);
            _vlaplicunitario = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCAPLICVERBAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlcustofin
    {
        get
        {
            PropriedadeAcessada(RO_VLCUSTOFIN);
            return _vlcustofin;
        }
        set
        {
            PropriedadeModificada(RO_VLCUSTOFIN, value);
            _vlcustofin = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCAPLICVERBAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlcustofinant
    {
        get
        {
            PropriedadeAcessada(RO_VLCUSTOFINANT);
            return _vlcustofinant;
        }
        set
        {
            PropriedadeModificada(RO_VLCUSTOFINANT, value);
            _vlcustofinant = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCAPLICVERBAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlcustoreal
    {
        get
        {
            PropriedadeAcessada(RO_VLCUSTOREAL);
            return _vlcustoreal;
        }
        set
        {
            PropriedadeModificada(RO_VLCUSTOREAL, value);
            _vlcustoreal = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCAPLICVERBAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlcustorealant
    {
        get
        {
            PropriedadeAcessada(RO_VLCUSTOREALANT);
            return _vlcustorealant;
        }
        set
        {
            PropriedadeModificada(RO_VLCUSTOREALANT, value);
            _vlcustorealant = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCAPLICVERBAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlvenda
    {
        get
        {
            PropriedadeAcessada(RO_VLVENDA);
            return _vlvenda;
        }
        set
        {
            PropriedadeModificada(RO_VLVENDA, value);
            _vlvenda = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCAPLICVERBAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 0)]
    public decimal? Condvenda
    {
        get
        {
            PropriedadeAcessada(RO_CONDVENDA);
            return _condvenda;
        }
        set
        {
            PropriedadeModificada(RO_CONDVENDA, value);
            _condvenda = value;
        }
    }

    public void InicializarAtributos()
    {
    }

    public string ObterNomeTabela()
    {
        return "PCAPLICVERBAI";
    }

    public IEntidade NovaInstancia()
    {
        return (IEntidade)GetType().GetConstructors()[0].Invoke(null);
    }

    public void CarregarPorDataReader(IDataReader leitor)
    {
        _codconta = AlterarTipo<decimal?>(leitor["Codconta"]);
        _codfilial = AlterarTipo<string>(leitor["Codfilial"]);
        _codprod = AlterarTipo<decimal>(leitor["Codprod"]);
        _custofinant = AlterarTipo<decimal?>(leitor["Custofinant"]);
        _custofinatual = AlterarTipo<decimal?>(leitor["Custofinatual"]);
        _custofornecant = AlterarTipo<decimal?>(leitor["Custofornecant"]);
        _custofornecatual = AlterarTipo<decimal?>(leitor["Custofornecatual"]);
        _custoproximacompraant = AlterarTipo<decimal?>(leitor["Custoproximacompraant"]);
        _custoproximacompraatual = AlterarTipo<decimal?>(leitor["Custoproximacompraatual"]);
        _custorealant = AlterarTipo<decimal?>(leitor["Custorealant"]);
        _custorealatual = AlterarTipo<decimal?>(leitor["Custorealatual"]);
        _custorealsemstant = AlterarTipo<decimal?>(leitor["Custorealsemstant"]);
        _custorealsemstatual = AlterarTipo<decimal?>(leitor["Custorealsemstatual"]);
        _custorepant = AlterarTipo<decimal?>(leitor["Custorepant"]);
        _custorepatual = AlterarTipo<decimal?>(leitor["Custorepatual"]);
        _custoultentant = AlterarTipo<decimal?>(leitor["Custoultentant"]);
        _custoultentatual = AlterarTipo<decimal?>(leitor["Custoultentatual"]);
        _dtaplic = AlterarTipo<DateTime?>(leitor["Dtaplic"]);
        _dtfimvigencia = AlterarTipo<DateTime?>(leitor["Dtfimvigencia"]);
        _dtiniciovigencia = AlterarTipo<DateTime?>(leitor["Dtiniciovigencia"]);
        _numaplic = AlterarTipo<decimal>(leitor["Numaplic"]);
        _numverba = AlterarTipo<decimal?>(leitor["Numverba"]);
        _percaplic = AlterarTipo<decimal?>(leitor["Percaplic"]);
        _qtestger = AlterarTipo<decimal?>(leitor["Qtestger"]);
        _qtvenda = AlterarTipo<decimal?>(leitor["Qtvenda"]);
        _vlaplic = AlterarTipo<decimal?>(leitor["Vlaplic"]);
        _vlaplicunitario = AlterarTipo<decimal?>(leitor["Vlaplicunitario"]);
        _vlcustofin = AlterarTipo<decimal?>(leitor["Vlcustofin"]);
        _vlcustofinant = AlterarTipo<decimal?>(leitor["Vlcustofinant"]);
        _vlcustoreal = AlterarTipo<decimal?>(leitor["Vlcustoreal"]);
        _vlcustorealant = AlterarTipo<decimal?>(leitor["Vlcustorealant"]);
        _vlvenda = AlterarTipo<decimal?>(leitor["Vlvenda"]);
        _condvenda = AlterarTipo<decimal?>(leitor["Condvenda"]);
    }

}