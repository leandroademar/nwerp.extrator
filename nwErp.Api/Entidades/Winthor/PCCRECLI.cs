

////// namespace nwErp.Entidades.Winthor;

// namespace nwErp.Api.Modelos;

[Serializable]
public class PCCRECLI : GerenteDePropriedades, IEntidade
{
    private static readonly string RO_BIN = "Bin";

    private decimal? _bin;

    private static readonly string RO_CODADMCARTAO = "Codadmcartao";

    private string _codadmcartao;

    private static readonly string RO_CODCLI = "Codcli";

    private decimal _codcli;

    private static readonly string RO_CODCLIORIG = "Codcliorig";

    private decimal? _codcliorig;

    private static readonly string RO_CODFILIAL = "Codfilial";

    private string _codfilial;

    private static readonly string RO_CODFILIALDESC = "Codfilialdesc";

    private string _codfilialdesc;

    private static readonly string RO_CODFUNC = "Codfunc";

    private decimal? _codfunc;

    private static readonly string RO_CODFUNCCX = "Codfunccx";

    private decimal? _codfunccx;

    private static readonly string RO_CODFUNCLANC = "Codfunclanc";

    private decimal? _codfunclanc;

    private static readonly string RO_CODIGO = "Codigo";

    private decimal? _codigo;

    private static readonly string RO_CODMOVIMENTO = "Codmovimento";

    private decimal? _codmovimento;

    private static readonly string RO_CODROTINA = "Codrotina";

    private decimal? _codrotina;

    private static readonly string RO_DTDESCONTO = "Dtdesconto";

    private DateTime? _dtdesconto;

    private static readonly string RO_DTLANC = "Dtlanc";

    private DateTime _dtlanc;

    private static readonly string RO_HISTORICO = "Historico";

    private string _historico;

    private static readonly string RO_HORA = "Hora";

    private decimal? _hora;

    private static readonly string RO_MINUTO = "Minuto";

    private decimal? _minuto;

    private static readonly string RO_NSUTEF = "Nsutef";

    private string _nsutef;

    private static readonly string RO_NUMCAIXA = "Numcaixa";

    private decimal? _numcaixa;

    private static readonly string RO_NUMCUPOM = "Numcupom";

    private decimal? _numcupom;

    private static readonly string RO_NUMERARIO = "Numerario";

    private string _numerario;

    private static readonly string RO_NUMINDENIZ = "Numindeniz";

    private decimal? _numindeniz;

    private static readonly string RO_NUMLANC = "Numlanc";

    private decimal? _numlanc;

    private static readonly string RO_NUMLANCBAIXA = "Numlancbaixa";

    private decimal? _numlancbaixa;

    private static readonly string RO_NUMNOTA = "Numnota";

    private decimal? _numnota;

    private static readonly string RO_NUMNOTADESC = "Numnotadesc";

    private decimal? _numnotadesc;

    private static readonly string RO_NUMPED = "Numped";

    private decimal? _numped;

    private static readonly string RO_NUMPEDECF = "Numpedecf";

    private decimal? _numpedecf;

    private static readonly string RO_NUMSERIEEQUIP = "Numserieequip";

    private string _numserieequip;

    private static readonly string RO_NUMTRANS = "Numtrans";

    private decimal? _numtrans;

    private static readonly string RO_NUMTRANSBAIXA = "Numtransbaixa";

    private decimal? _numtransbaixa;

    private static readonly string RO_NUMTRANSENTDEVCLI = "Numtransentdevcli";

    private decimal? _numtransentdevcli;

    private static readonly string RO_NUMTRANSVENDA = "Numtransvenda";

    private decimal? _numtransvenda;

    private static readonly string RO_NUMTRANSVENDADESC = "Numtransvendadesc";

    private decimal? _numtransvendadesc;

    private static readonly string RO_OBS = "Obs";

    private string _obs;

    private static readonly string RO_ORIGEM = "Origem";

    private string _origem;

    private static readonly string RO_PRESTRESTCLI = "Prestrestcli";

    private string _prestrestcli;

    private static readonly string RO_SERIE = "Serie";

    private string _serie;

    private static readonly string RO_SERIEDESC = "Seriedesc";

    private string _seriedesc;

    private static readonly string RO_SITUACAO = "Situacao";

    private string _situacao;

    private static readonly string RO_VALOR = "Valor";

    private decimal? _valor;

    private static readonly string RO_VALORESTORNOLIBERADO = "Valorestornoliberado";

    private decimal? _valorestornoliberado;

    private static readonly string RO_DTESTORNO = "Dtestorno";

    private DateTime? _dtestorno;

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCRECLI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Bin
    {
        get
        {
            PropriedadeAcessada(RO_BIN);
            return _bin;
        }
        set
        {
            PropriedadeModificada(RO_BIN, value);
            _bin = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCRECLI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 6, Precisao = 0)]
    public string Codadmcartao
    {
        get
        {
            PropriedadeAcessada(RO_CODADMCARTAO);
            return _codadmcartao;
        }
        set
        {
            PropriedadeModificada(RO_CODADMCARTAO, value);
            _codadmcartao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCRECLI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal Codcli
    {
        get
        {
            PropriedadeAcessada(RO_CODCLI);
            return _codcli;
        }
        set
        {
            PropriedadeModificada(RO_CODCLI, value);
            _codcli = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCRECLI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codcliorig
    {
        get
        {
            PropriedadeAcessada(RO_CODCLIORIG);
            return _codcliorig;
        }
        set
        {
            PropriedadeModificada(RO_CODCLIORIG, value);
            _codcliorig = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCRECLI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCRECLI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Codfilialdesc
    {
        get
        {
            PropriedadeAcessada(RO_CODFILIALDESC);
            return _codfilialdesc;
        }
        set
        {
            PropriedadeModificada(RO_CODFILIALDESC, value);
            _codfilialdesc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCRECLI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfunc
    {
        get
        {
            PropriedadeAcessada(RO_CODFUNC);
            return _codfunc;
        }
        set
        {
            PropriedadeModificada(RO_CODFUNC, value);
            _codfunc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCRECLI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCRECLI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfunclanc
    {
        get
        {
            PropriedadeAcessada(RO_CODFUNCLANC);
            return _codfunclanc;
        }
        set
        {
            PropriedadeModificada(RO_CODFUNCLANC, value);
            _codfunclanc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCRECLI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codigo
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCRECLI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Codmovimento
    {
        get
        {
            PropriedadeAcessada(RO_CODMOVIMENTO);
            return _codmovimento;
        }
        set
        {
            PropriedadeModificada(RO_CODMOVIMENTO, value);
            _codmovimento = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCRECLI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codrotina
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCRECLI", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtdesconto
    {
        get
        {
            PropriedadeAcessada(RO_DTDESCONTO);
            return _dtdesconto;
        }
        set
        {
            PropriedadeModificada(RO_DTDESCONTO, value);
            _dtdesconto = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCRECLI", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime Dtlanc
    {
        get
        {
            PropriedadeAcessada(RO_DTLANC);
            return _dtlanc;
        }
        set
        {
            PropriedadeModificada(RO_DTLANC, value);
            _dtlanc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCRECLI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 100, Precisao = 0)]
    public string Historico
    {
        get
        {
            PropriedadeAcessada(RO_HISTORICO);
            return _historico;
        }
        set
        {
            PropriedadeModificada(RO_HISTORICO, value);
            _historico = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCRECLI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 2, Precisao = 0)]
    public decimal? Hora
    {
        get
        {
            PropriedadeAcessada(RO_HORA);
            return _hora;
        }
        set
        {
            PropriedadeModificada(RO_HORA, value);
            _hora = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCRECLI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 2, Precisao = 0)]
    public decimal? Minuto
    {
        get
        {
            PropriedadeAcessada(RO_MINUTO);
            return _minuto;
        }
        set
        {
            PropriedadeModificada(RO_MINUTO, value);
            _minuto = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCRECLI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 15, Precisao = 0)]
    public string Nsutef
    {
        get
        {
            PropriedadeAcessada(RO_NSUTEF);
            return _nsutef;
        }
        set
        {
            PropriedadeModificada(RO_NSUTEF, value);
            _nsutef = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCRECLI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCRECLI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numcupom
    {
        get
        {
            PropriedadeAcessada(RO_NUMCUPOM);
            return _numcupom;
        }
        set
        {
            PropriedadeModificada(RO_NUMCUPOM, value);
            _numcupom = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCRECLI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Numerario
    {
        get
        {
            PropriedadeAcessada(RO_NUMERARIO);
            return _numerario;
        }
        set
        {
            PropriedadeModificada(RO_NUMERARIO, value);
            _numerario = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCRECLI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numindeniz
    {
        get
        {
            PropriedadeAcessada(RO_NUMINDENIZ);
            return _numindeniz;
        }
        set
        {
            PropriedadeModificada(RO_NUMINDENIZ, value);
            _numindeniz = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCRECLI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Numlanc
    {
        get
        {
            PropriedadeAcessada(RO_NUMLANC);
            return _numlanc;
        }
        set
        {
            PropriedadeModificada(RO_NUMLANC, value);
            _numlanc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCRECLI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Numlancbaixa
    {
        get
        {
            PropriedadeAcessada(RO_NUMLANCBAIXA);
            return _numlancbaixa;
        }
        set
        {
            PropriedadeModificada(RO_NUMLANCBAIXA, value);
            _numlancbaixa = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCRECLI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numnota
    {
        get
        {
            PropriedadeAcessada(RO_NUMNOTA);
            return _numnota;
        }
        set
        {
            PropriedadeModificada(RO_NUMNOTA, value);
            _numnota = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCRECLI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numnotadesc
    {
        get
        {
            PropriedadeAcessada(RO_NUMNOTADESC);
            return _numnotadesc;
        }
        set
        {
            PropriedadeModificada(RO_NUMNOTADESC, value);
            _numnotadesc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCRECLI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numped
    {
        get
        {
            PropriedadeAcessada(RO_NUMPED);
            return _numped;
        }
        set
        {
            PropriedadeModificada(RO_NUMPED, value);
            _numped = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCRECLI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCRECLI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 30, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCRECLI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numtrans
    {
        get
        {
            PropriedadeAcessada(RO_NUMTRANS);
            return _numtrans;
        }
        set
        {
            PropriedadeModificada(RO_NUMTRANS, value);
            _numtrans = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCRECLI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numtransbaixa
    {
        get
        {
            PropriedadeAcessada(RO_NUMTRANSBAIXA);
            return _numtransbaixa;
        }
        set
        {
            PropriedadeModificada(RO_NUMTRANSBAIXA, value);
            _numtransbaixa = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCRECLI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numtransentdevcli
    {
        get
        {
            PropriedadeAcessada(RO_NUMTRANSENTDEVCLI);
            return _numtransentdevcli;
        }
        set
        {
            PropriedadeModificada(RO_NUMTRANSENTDEVCLI, value);
            _numtransentdevcli = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCRECLI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numtransvenda
    {
        get
        {
            PropriedadeAcessada(RO_NUMTRANSVENDA);
            return _numtransvenda;
        }
        set
        {
            PropriedadeModificada(RO_NUMTRANSVENDA, value);
            _numtransvenda = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCRECLI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 0)]
    public decimal? Numtransvendadesc
    {
        get
        {
            PropriedadeAcessada(RO_NUMTRANSVENDADESC);
            return _numtransvendadesc;
        }
        set
        {
            PropriedadeModificada(RO_NUMTRANSVENDADESC, value);
            _numtransvendadesc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCRECLI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 60, Precisao = 0)]
    public string Obs
    {
        get
        {
            PropriedadeAcessada(RO_OBS);
            return _obs;
        }
        set
        {
            PropriedadeModificada(RO_OBS, value);
            _obs = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCRECLI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Origem
    {
        get
        {
            PropriedadeAcessada(RO_ORIGEM);
            return _origem;
        }
        set
        {
            PropriedadeModificada(RO_ORIGEM, value);
            _origem = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCRECLI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Prestrestcli
    {
        get
        {
            PropriedadeAcessada(RO_PRESTRESTCLI);
            return _prestrestcli;
        }
        set
        {
            PropriedadeModificada(RO_PRESTRESTCLI, value);
            _prestrestcli = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCRECLI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 3, Precisao = 0)]
    public string Serie
    {
        get
        {
            PropriedadeAcessada(RO_SERIE);
            return _serie;
        }
        set
        {
            PropriedadeModificada(RO_SERIE, value);
            _serie = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCRECLI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 3, Precisao = 0)]
    public string Seriedesc
    {
        get
        {
            PropriedadeAcessada(RO_SERIEDESC);
            return _seriedesc;
        }
        set
        {
            PropriedadeModificada(RO_SERIEDESC, value);
            _seriedesc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCRECLI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Situacao
    {
        get
        {
            PropriedadeAcessada(RO_SITUACAO);
            return _situacao;
        }
        set
        {
            PropriedadeModificada(RO_SITUACAO, value);
            _situacao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCRECLI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 2)]
    public decimal? Valor
    {
        get
        {
            PropriedadeAcessada(RO_VALOR);
            return _valor;
        }
        set
        {
            PropriedadeModificada(RO_VALOR, value);
            _valor = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCRECLI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 2)]
    public decimal? Valorestornoliberado
    {
        get
        {
            PropriedadeAcessada(RO_VALORESTORNOLIBERADO);
            return _valorestornoliberado;
        }
        set
        {
            PropriedadeModificada(RO_VALORESTORNOLIBERADO, value);
            _valorestornoliberado = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCRECLI", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtestorno
    {
        get
        {
            PropriedadeAcessada(RO_DTESTORNO);
            return _dtestorno;
        }
        set
        {
            PropriedadeModificada(RO_DTESTORNO, value);
            _dtestorno = value;
        }
    }

    public void InicializarAtributos()
    {
    }

    public string ObterNomeTabela()
    {
        return "PCCRECLI";
    }

    public IEntidade NovaInstancia()
    {
        return (IEntidade)GetType().GetConstructors()[0].Invoke(null);
    }

    public void CarregarPorDataReader(IDataReader leitor)
    {
        _bin = AlterarTipo<decimal?>(leitor["Bin"]);
        _codadmcartao = AlterarTipo<string>(leitor["Codadmcartao"]);
        _codcli = AlterarTipo<decimal>(leitor["Codcli"]);
        _codcliorig = AlterarTipo<decimal?>(leitor["Codcliorig"]);
        _codfilial = AlterarTipo<string>(leitor["Codfilial"]);
        _codfilialdesc = AlterarTipo<string>(leitor["Codfilialdesc"]);
        _codfunc = AlterarTipo<decimal?>(leitor["Codfunc"]);
        _codfunccx = AlterarTipo<decimal?>(leitor["Codfunccx"]);
        _codfunclanc = AlterarTipo<decimal?>(leitor["Codfunclanc"]);
        _codigo = AlterarTipo<decimal?>(leitor["Codigo"]);
        _codmovimento = AlterarTipo<decimal?>(leitor["Codmovimento"]);
        _codrotina = AlterarTipo<decimal?>(leitor["Codrotina"]);
        _dtdesconto = AlterarTipo<DateTime?>(leitor["Dtdesconto"]);
        _dtlanc = AlterarTipo<DateTime>(leitor["Dtlanc"]);
        _historico = AlterarTipo<string>(leitor["Historico"]);
        _hora = AlterarTipo<decimal?>(leitor["Hora"]);
        _minuto = AlterarTipo<decimal?>(leitor["Minuto"]);
        _nsutef = AlterarTipo<string>(leitor["Nsutef"]);
        _numcaixa = AlterarTipo<decimal?>(leitor["Numcaixa"]);
        _numcupom = AlterarTipo<decimal?>(leitor["Numcupom"]);
        _numerario = AlterarTipo<string>(leitor["Numerario"]);
        _numindeniz = AlterarTipo<decimal?>(leitor["Numindeniz"]);
        _numlanc = AlterarTipo<decimal?>(leitor["Numlanc"]);
        _numlancbaixa = AlterarTipo<decimal?>(leitor["Numlancbaixa"]);
        _numnota = AlterarTipo<decimal?>(leitor["Numnota"]);
        _numnotadesc = AlterarTipo<decimal?>(leitor["Numnotadesc"]);
        _numped = AlterarTipo<decimal?>(leitor["Numped"]);
        _numpedecf = AlterarTipo<decimal?>(leitor["Numpedecf"]);
        _numserieequip = AlterarTipo<string>(leitor["Numserieequip"]);
        _numtrans = AlterarTipo<decimal?>(leitor["Numtrans"]);
        _numtransbaixa = AlterarTipo<decimal?>(leitor["Numtransbaixa"]);
        _numtransentdevcli = AlterarTipo<decimal?>(leitor["Numtransentdevcli"]);
        _numtransvenda = AlterarTipo<decimal?>(leitor["Numtransvenda"]);
        _numtransvendadesc = AlterarTipo<decimal?>(leitor["Numtransvendadesc"]);
        _obs = AlterarTipo<string>(leitor["Obs"]);
        _origem = AlterarTipo<string>(leitor["Origem"]);
        _prestrestcli = AlterarTipo<string>(leitor["Prestrestcli"]);
        _serie = AlterarTipo<string>(leitor["Serie"]);
        _seriedesc = AlterarTipo<string>(leitor["Seriedesc"]);
        _situacao = AlterarTipo<string>(leitor["Situacao"]);
        _valor = AlterarTipo<decimal?>(leitor["Valor"]);
        _valorestornoliberado = AlterarTipo<decimal?>(leitor["Valorestornoliberado"]);
        _dtestorno = AlterarTipo<DateTime?>(leitor["Dtestorno"]);
    }

}