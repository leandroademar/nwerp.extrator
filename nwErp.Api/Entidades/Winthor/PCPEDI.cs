

////// namespace nwErp.Entidades.Winthor;

// namespace nwErp.Api.Modelos;

[Serializable]
public class PCPEDI : GerenteDePropriedades, IEntidade
{
    private string _abastecido;

    private decimal? _aliqfcp;

    private decimal? _aliqicms1;

    private decimal? _aliqicms2;

    private decimal? _aliqinternadest;

    private string _alternativo;

    private string _ambiente;

    private decimal? _basedifaliquotas;

    private decimal? _baseicst;

    private decimal? _baseicst_ant_rateio;

    private decimal? _baseipiecf;

    private string _bonific;

    private string _brinde;

    private decimal? _codauxiliar;

    private string _codbase;

    private decimal? _codcertific;

    private decimal _codcli;

    private decimal? _codcombo;

    private decimal? _codcontrato;

    private decimal? _codcontrolevasilhame;

    private decimal? _coddegustacao;

    private decimal? _coddesconto;

    private decimal? _coddescontobaserca;

    private string _codecf;

    private decimal? _codemitenteitempedido;

    private string _codfilialretira;

    private string _codformula;

    private decimal? _codfuncajusteos;

    private decimal? _codfuncalteracaoos;

    private decimal? _codfuncaltlote;

    private decimal? _codfuncconf;

    private decimal? _codfuncconf2;

    private decimal? _codfunclanc;

    private decimal? _codfunclibos;

    private decimal? _codfuncpend;

    private decimal? _codfuncsep;

    private decimal? _codfuncultalter;

    private decimal? _codicmtab;

    private decimal? _codigobrinde;

    private decimal? _codindicemultiplicador;

    private decimal? _codlinhaprazo;

    private decimal? _codmoedaestrageira;

    private decimal? _codmotnaocompra;

    private decimal? _codplpag;

    private decimal? _codprecofixo;

    private decimal _codprod;

    private decimal? _codprodcesta;

    private string _codpromocao;

    private decimal? _codst;

    private decimal _codusur;

    private decimal? _codvasilhame;

    private decimal? _codvasilhameecf;

    private string _complemento;

    private string _concedermaiorcomissreg;

    private decimal? _condvenda;

    private string _corte;

    private decimal? _custofinest;

    private DateTime _data;

    private DateTime? _dataconf;

    private DateTime? _dataconffim;

    private decimal? _descprecofab;

    private DateTime? _dtajusteos;

    private DateTime? _dtalteracaoos;

    private DateTime? _dtentrega;

    private DateTime? _dtexportacaoservint;

    private DateTime? _dtfimpromolote;

    private DateTime? _dtfinalpend;

    private DateTime? _dtfinalsep;

    private DateTime? _dtgeracaoos;

    private DateTime? _dtimportacaoservprinc;

    private DateTime? _dtinicialpend;

    private DateTime? _dtinicialsep;

    private DateTime? _dtiniciopromolote;

    private DateTime? _dtlanc;

    private DateTime? _dtlibos;

    private DateTime? _dtultlalter;

    private decimal? _eancodprod;

    private string _exportadoservint;

    private string _formanegociacao;

    private string _geragnre_cnpjcliente;

    private decimal? _grpregrabrinde;

    private string _grupofaturamento;

    private string _idpatrimonio;

    private decimal? _idvenda;

    private string _importadoservprinc;

    private string _imprime;

    private decimal? _iva;

    private string _letracomiss;

    private string _localizacao;

    private string _localizacaoos;

    private string _movimentacontacorrenterca;

    private string _negociacaoposterior;

    private string _nomeconcorrente;

    private decimal? _numaplic;

    private string _numcaixa;

    private decimal? _numcar;

    private decimal? _numcaraux;

    private decimal? _numconferencia;

    private string _numerorecopi;

    private decimal? _numetiqueta;

    private decimal? _numitemped;

    private decimal? _numlista;

    private string _numlote;

    private decimal? _numop;

    private decimal? _numos;

    private decimal? _numosorigem;

    private decimal _numped;

    private decimal? _numrecopi;

    private decimal _numseq;

    private decimal? _numseqcestabasica;

    private decimal? _numseqitemcontrato;

    private string _numseriesat;

    private decimal? _numtira;

    private decimal? _numtranswms;

    private decimal? _numverbarebcmv;

    private decimal? _numviasos;

    private decimal? _numvolumesconferencia;

    private string _origemdepreco;

    private string _origemst;

    private string _participagiro;

    private decimal? _pauta;

    private decimal? _pbaserca;

    private decimal? _pbonific;

    private decimal? _perbonific;

    private decimal? _percagregadorst;

    private decimal? _percbasered;

    private decimal? _percbaseredpart;

    private decimal? _percbaseredst;

    private decimal? _percbaseredstfonte;

    private decimal? _percdescabatimento;

    private decimal? _percdesccofins;

    private decimal? _percdescindustria;

    private decimal? _percdescpis;

    private decimal? _percdifaliquotas;

    private decimal? _percicm;

    private decimal? _percipi;

    private decimal? _percipiecf;

    private decimal? _percipioutras;

    private decimal? _perciss;

    private decimal _percom;

    private decimal? _percom2;

    private decimal? _percom3;

    private decimal? _percom4;

    private decimal? _percomprof;

    private decimal? _percomsup;

    private decimal? _percomtab;

    private decimal? _percprovpart;

    private decimal? _percredaliqipi;

    private decimal? _perctributos;

    private decimal? _percvenda;

    private decimal _perdesc;

    private decimal? _perdescavista;

    private decimal? _perdescboleto;

    private decimal? _perdesccom;

    private decimal? _perdesccusto;

    private decimal? _perdescfimcomiss;

    private decimal? _perdescfin;

    private decimal? _perdescflex;

    private decimal? _perdescfob;

    private decimal? _perdescinicomiss;

    private decimal? _perdescisentoicms;

    private decimal? _perdescnegociado;

    private decimal? _perdescpauta;

    private decimal? _perdescpolitica;

    private decimal? _perdesctab;

    private decimal? _perfretecmv;

    private decimal? _perredcomiss;

    private decimal? _perredcomisssup;

    private decimal? _pesobruto;

    private string _politicaprioritaria;

    private decimal? _poriginal;

    private string _posicao;

    private string _prazo;

    private decimal? _prazomedio;

    private decimal? _preco;

    private decimal? _precofvbruto;

    private decimal? _precomaxconsum;

    private string _proddescricaocontrato;

    private string _proddescricaodanfe;

    private decimal _ptabela;

    private decimal? _ptabelaautpecas;

    private decimal _pvenda;

    private decimal? _pvenda1;

    private decimal? _pvendaanterior;

    private decimal? _pvendabase;

    private decimal? _pvendaemb;

    private decimal? _pvendaembalagem;

    private decimal? _pvendaliq;

    private decimal? _pvendavasilhame;

    private decimal _qt;

    private decimal? _qtapanha;

    private decimal? _qtcx;

    private decimal? _qtdiasentregaitem;

    private decimal? _qtembalagem;

    private decimal? _qtfalta;

    private decimal? _qtimediata;

    private decimal? _qtlitragem;

    private decimal? _qtlocalizada;

    private decimal? _qtnaocompra;

    private decimal? _qtorig;

    private decimal? _qtoriginal;

    private decimal? _qtpecas;

    private decimal? _qtpendos;

    private decimal? _qtreservant;

    private decimal? _qtsaidavasilhame;

    private decimal? _qtseparada;

    private decimal? _qtsepararcx;

    private decimal? _qtsepararun;

    private decimal? _qtun;

    private decimal? _qtunitcx;

    private decimal? _qtunitemb;

    private decimal? _qtvendaemb;

    private decimal? _qtvendidavasilhame;

    private decimal? _qt_separadamanif;

    private string _refcor;

    private string _rotina;

    private decimal? _rotinalanc;

    private decimal? _rotinalancbrinde;

    private string _rotinalancultalt;

    private decimal? _rotinaultlalter;

    private string _rp_imediata;

    private string _siglaqualidade;

    private decimal? _situacaoos;

    private decimal _st;

    private decimal? _statussucata;

    private decimal? _stclientegnre;

    private decimal? _stpbaserca;

    private decimal? _stptabela;

    private decimal? _st_ant_rateio;

    private decimal? _st_dif_rateio;

    private string _sugestao;

    private decimal? _taxacasomoedareal;

    private string _tipocalculost;

    private string _tipodescaplicado;

    private string _tipoentrega;

    private string _tipopeso;

    private string _tiposeparacao;

    private string _totalizadoraliquota;

    private string _truncaritem;

    private decimal? _tvbonif;

    private decimal? _txvenda;

    private string _unidade;

    private string _usadebcredrcabrind;

    private string _usaunidademaster;

    private string _vendapbm;

    private decimal? _vlacrescrodape;

    private decimal? _vlacrescvasilhame;

    private decimal? _vlacresfretekg;

    private decimal? _vlbasepartdest;

    private decimal? _vlbonific;

    private decimal? _vlcustocont;

    private decimal _vlcustofin;

    private decimal _vlcustoreal;

    private decimal? _vlcustorep;

    private decimal? _vldescabatimento;

    private decimal? _vldescboleto;

    private decimal? _vldesccom;

    private decimal? _vldesccustocmv;

    private decimal? _vldescfin;

    private decimal? _vldescflex;

    private decimal? _vldescfornec;

    private decimal? _vldescicmisencao;

    private decimal? _vldescpissuframa;

    private decimal? _vldescreducaocofins;

    private decimal? _vldescreducaopis;

    private decimal? _vldescrepasse;

    private decimal? _vldescrodape;

    private decimal? _vldescsociotorcedor;

    private decimal? _vldescsuframa;

    private decimal? _vldifaliquotas;

    private decimal? _vlfcppart;

    private decimal? _vlfrete;

    private decimal? _vlfrete_rateio;

    private decimal? _vlicmsdifaliqpart;

    private decimal? _vlicmspart;

    private decimal? _vlicmspartdest;

    private decimal? _vlicmspartrem;

    private decimal? _vlipi;

    private decimal? _vlipiecf;

    private decimal? _vlipioutras;

    private decimal? _vliss;

    private decimal? _vlitemtributos;

    private decimal? _vloutrasdesp;

    private decimal? _vloutras_rateio;

    private decimal? _vloutros;

    private decimal? _vlrebaixacmv;

    private decimal? _vlredcmvsimplesnac;

    private decimal? _vlredcomiss;

    private decimal? _vlredcomisssup;

    private decimal? _vlredpvendasimplesna;

    private decimal? _vlrepasse;

    private decimal? _vlrmoedaestrageira;

    private decimal? _vlsubtotitem;

    private decimal? _vlverbacmv;

    private decimal? _vlverbacmvcli;

    private decimal? _volumedesejado;

    private string _codcest;

    private string _codbarrabalanca;

    private decimal? _qtminatacvenda;

    private string _tipodescatacvenda;

    private decimal? _codoferta;

    private decimal? _pglp;

    private decimal? _pgni;

    private decimal? _pgnn;

    private decimal? _vpart;

    private decimal? _vlbasefcpst;

    private decimal? _aliqicmsfecp;

    private decimal? _vlfecp;

    private string _utilizoumotorcalculo;

    private string _cupomdesconto;

    private string _codcupomdesconto;

    private static readonly string RO_QBCMONORET = "Qbcmonoret";

    private decimal? _qbcmonoret;

    private static readonly string RO_ADREMICMSRET = "Adremicmsret";

    private decimal? _adremicmsret;

    private static readonly string RO_VICMSMONORET = "Vicmsmonoret";

    private decimal? _vicmsmonoret;

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Abastecido
    {
        get
        {
            PropriedadeAcessada("Abastecido");
            return _abastecido;
        }
        set
        {
            PropriedadeModificada("Abastecido", value);
            _abastecido = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Aliqfcp
    {
        get
        {
            PropriedadeAcessada("Aliqfcp");
            return _aliqfcp;
        }
        set
        {
            PropriedadeModificada("Aliqfcp", value);
            _aliqfcp = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Aliqicms1
    {
        get
        {
            PropriedadeAcessada("Aliqicms1");
            return _aliqicms1;
        }
        set
        {
            PropriedadeModificada("Aliqicms1", value);
            _aliqicms1 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Aliqicms2
    {
        get
        {
            PropriedadeAcessada("Aliqicms2");
            return _aliqicms2;
        }
        set
        {
            PropriedadeModificada("Aliqicms2", value);
            _aliqicms2 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Aliqinternadest
    {
        get
        {
            PropriedadeAcessada("Aliqinternadest");
            return _aliqinternadest;
        }
        set
        {
            PropriedadeModificada("Aliqinternadest", value);
            _aliqinternadest = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 10, Precisao = 0)]
    public string Alternativo
    {
        get
        {
            PropriedadeAcessada("Alternativo");
            return _alternativo;
        }
        set
        {
            PropriedadeModificada("Alternativo", value);
            _alternativo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 50, Precisao = 0)]
    public string Ambiente
    {
        get
        {
            PropriedadeAcessada("Ambiente");
            return _ambiente;
        }
        set
        {
            PropriedadeModificada("Ambiente", value);
            _ambiente = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Basedifaliquotas
    {
        get
        {
            PropriedadeAcessada("Basedifaliquotas");
            return _basedifaliquotas;
        }
        set
        {
            PropriedadeModificada("Basedifaliquotas", value);
            _basedifaliquotas = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Baseicst
    {
        get
        {
            PropriedadeAcessada("Baseicst");
            return _baseicst;
        }
        set
        {
            PropriedadeModificada("Baseicst", value);
            _baseicst = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Baseicst_Ant_Rateio
    {
        get
        {
            PropriedadeAcessada("Baseicst_Ant_Rateio");
            return _baseicst_ant_rateio;
        }
        set
        {
            PropriedadeModificada("Baseicst_Ant_Rateio", value);
            _baseicst_ant_rateio = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Baseipiecf
    {
        get
        {
            PropriedadeAcessada("Baseipiecf");
            return _baseipiecf;
        }
        set
        {
            PropriedadeModificada("Baseipiecf", value);
            _baseipiecf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Bonific
    {
        get
        {
            PropriedadeAcessada("Bonific");
            return _bonific;
        }
        set
        {
            PropriedadeModificada("Bonific", value);
            _bonific = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Brinde
    {
        get
        {
            PropriedadeAcessada("Brinde");
            return _brinde;
        }
        set
        {
            PropriedadeModificada("Brinde", value);
            _brinde = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 20, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
    public string Codbase
    {
        get
        {
            PropriedadeAcessada("Codbase");
            return _codbase;
        }
        set
        {
            PropriedadeModificada("Codbase", value);
            _codbase = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codcertific
    {
        get
        {
            PropriedadeAcessada("Codcertific");
            return _codcertific;
        }
        set
        {
            PropriedadeModificada("Codcertific", value);
            _codcertific = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal Codcli
    {
        get
        {
            PropriedadeAcessada("Codcli");
            return _codcli;
        }
        set
        {
            PropriedadeModificada("Codcli", value);
            _codcli = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codcombo
    {
        get
        {
            PropriedadeAcessada("Codcombo");
            return _codcombo;
        }
        set
        {
            PropriedadeModificada("Codcombo", value);
            _codcombo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codcontrato
    {
        get
        {
            PropriedadeAcessada("Codcontrato");
            return _codcontrato;
        }
        set
        {
            PropriedadeModificada("Codcontrato", value);
            _codcontrato = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codcontrolevasilhame
    {
        get
        {
            PropriedadeAcessada("Codcontrolevasilhame");
            return _codcontrolevasilhame;
        }
        set
        {
            PropriedadeModificada("Codcontrolevasilhame", value);
            _codcontrolevasilhame = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Coddegustacao
    {
        get
        {
            PropriedadeAcessada("Coddegustacao");
            return _coddegustacao;
        }
        set
        {
            PropriedadeModificada("Coddegustacao", value);
            _coddegustacao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Coddesconto
    {
        get
        {
            PropriedadeAcessada("Coddesconto");
            return _coddesconto;
        }
        set
        {
            PropriedadeModificada("Coddesconto", value);
            _coddesconto = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Coddescontobaserca
    {
        get
        {
            PropriedadeAcessada("Coddescontobaserca");
            return _coddescontobaserca;
        }
        set
        {
            PropriedadeModificada("Coddescontobaserca", value);
            _coddescontobaserca = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 4, Precisao = 0)]
    public string Codecf
    {
        get
        {
            PropriedadeAcessada("Codecf");
            return _codecf;
        }
        set
        {
            PropriedadeModificada("Codecf", value);
            _codecf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codemitenteitempedido
    {
        get
        {
            PropriedadeAcessada("Codemitenteitempedido");
            return _codemitenteitempedido;
        }
        set
        {
            PropriedadeModificada("Codemitenteitempedido", value);
            _codemitenteitempedido = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Codfilialretira
    {
        get
        {
            PropriedadeAcessada("Codfilialretira");
            return _codfilialretira;
        }
        set
        {
            PropriedadeModificada("Codfilialretira", value);
            _codfilialretira = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
    public string Codformula
    {
        get
        {
            PropriedadeAcessada("Codformula");
            return _codformula;
        }
        set
        {
            PropriedadeModificada("Codformula", value);
            _codformula = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfuncajusteos
    {
        get
        {
            PropriedadeAcessada("Codfuncajusteos");
            return _codfuncajusteos;
        }
        set
        {
            PropriedadeModificada("Codfuncajusteos", value);
            _codfuncajusteos = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfuncalteracaoos
    {
        get
        {
            PropriedadeAcessada("Codfuncalteracaoos");
            return _codfuncalteracaoos;
        }
        set
        {
            PropriedadeModificada("Codfuncalteracaoos", value);
            _codfuncalteracaoos = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfuncaltlote
    {
        get
        {
            PropriedadeAcessada("Codfuncaltlote");
            return _codfuncaltlote;
        }
        set
        {
            PropriedadeModificada("Codfuncaltlote", value);
            _codfuncaltlote = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfuncconf
    {
        get
        {
            PropriedadeAcessada("Codfuncconf");
            return _codfuncconf;
        }
        set
        {
            PropriedadeModificada("Codfuncconf", value);
            _codfuncconf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfuncconf2
    {
        get
        {
            PropriedadeAcessada("Codfuncconf2");
            return _codfuncconf2;
        }
        set
        {
            PropriedadeModificada("Codfuncconf2", value);
            _codfuncconf2 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfunclanc
    {
        get
        {
            PropriedadeAcessada("Codfunclanc");
            return _codfunclanc;
        }
        set
        {
            PropriedadeModificada("Codfunclanc", value);
            _codfunclanc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfunclibos
    {
        get
        {
            PropriedadeAcessada("Codfunclibos");
            return _codfunclibos;
        }
        set
        {
            PropriedadeModificada("Codfunclibos", value);
            _codfunclibos = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfuncpend
    {
        get
        {
            PropriedadeAcessada("Codfuncpend");
            return _codfuncpend;
        }
        set
        {
            PropriedadeModificada("Codfuncpend", value);
            _codfuncpend = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfuncsep
    {
        get
        {
            PropriedadeAcessada("Codfuncsep");
            return _codfuncsep;
        }
        set
        {
            PropriedadeModificada("Codfuncsep", value);
            _codfuncsep = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfuncultalter
    {
        get
        {
            PropriedadeAcessada("Codfuncultalter");
            return _codfuncultalter;
        }
        set
        {
            PropriedadeModificada("Codfuncultalter", value);
            _codfuncultalter = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Codicmtab
    {
        get
        {
            PropriedadeAcessada("Codicmtab");
            return _codicmtab;
        }
        set
        {
            PropriedadeModificada("Codicmtab", value);
            _codicmtab = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Codigobrinde
    {
        get
        {
            PropriedadeAcessada("Codigobrinde");
            return _codigobrinde;
        }
        set
        {
            PropriedadeModificada("Codigobrinde", value);
            _codigobrinde = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codindicemultiplicador
    {
        get
        {
            PropriedadeAcessada("Codindicemultiplicador");
            return _codindicemultiplicador;
        }
        set
        {
            PropriedadeModificada("Codindicemultiplicador", value);
            _codindicemultiplicador = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codlinhaprazo
    {
        get
        {
            PropriedadeAcessada("Codlinhaprazo");
            return _codlinhaprazo;
        }
        set
        {
            PropriedadeModificada("Codlinhaprazo", value);
            _codlinhaprazo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codmoedaestrageira
    {
        get
        {
            PropriedadeAcessada("Codmoedaestrageira");
            return _codmoedaestrageira;
        }
        set
        {
            PropriedadeModificada("Codmoedaestrageira", value);
            _codmoedaestrageira = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codmotnaocompra
    {
        get
        {
            PropriedadeAcessada("Codmotnaocompra");
            return _codmotnaocompra;
        }
        set
        {
            PropriedadeModificada("Codmotnaocompra", value);
            _codmotnaocompra = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Codplpag
    {
        get
        {
            PropriedadeAcessada("Codplpag");
            return _codplpag;
        }
        set
        {
            PropriedadeModificada("Codplpag", value);
            _codplpag = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Codprecofixo
    {
        get
        {
            PropriedadeAcessada("Codprecofixo");
            return _codprecofixo;
        }
        set
        {
            PropriedadeModificada("Codprecofixo", value);
            _codprecofixo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal Codprod
    {
        get
        {
            PropriedadeAcessada("Codprod");
            return _codprod;
        }
        set
        {
            PropriedadeModificada("Codprod", value);
            _codprod = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codprodcesta
    {
        get
        {
            PropriedadeAcessada("Codprodcesta");
            return _codprodcesta;
        }
        set
        {
            PropriedadeModificada("Codprodcesta", value);
            _codprodcesta = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 10, Precisao = 0)]
    public string Codpromocao
    {
        get
        {
            PropriedadeAcessada("Codpromocao");
            return _codpromocao;
        }
        set
        {
            PropriedadeModificada("Codpromocao", value);
            _codpromocao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Codst
    {
        get
        {
            PropriedadeAcessada("Codst");
            return _codst;
        }
        set
        {
            PropriedadeModificada("Codst", value);
            _codst = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal Codusur
    {
        get
        {
            PropriedadeAcessada("Codusur");
            return _codusur;
        }
        set
        {
            PropriedadeModificada("Codusur", value);
            _codusur = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codvasilhameecf
    {
        get
        {
            PropriedadeAcessada("Codvasilhameecf");
            return _codvasilhameecf;
        }
        set
        {
            PropriedadeModificada("Codvasilhameecf", value);
            _codvasilhameecf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
    public string Complemento
    {
        get
        {
            PropriedadeAcessada("Complemento");
            return _complemento;
        }
        set
        {
            PropriedadeModificada("Complemento", value);
            _complemento = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Concedermaiorcomissreg
    {
        get
        {
            PropriedadeAcessada("Concedermaiorcomissreg");
            return _concedermaiorcomissreg;
        }
        set
        {
            PropriedadeModificada("Concedermaiorcomissreg", value);
            _concedermaiorcomissreg = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 0)]
    public decimal? Condvenda
    {
        get
        {
            PropriedadeAcessada("Condvenda");
            return _condvenda;
        }
        set
        {
            PropriedadeModificada("Condvenda", value);
            _condvenda = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Corte
    {
        get
        {
            PropriedadeAcessada("Corte");
            return _corte;
        }
        set
        {
            PropriedadeModificada("Corte", value);
            _corte = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Custofinest
    {
        get
        {
            PropriedadeAcessada("Custofinest");
            return _custofinest;
        }
        set
        {
            PropriedadeModificada("Custofinest", value);
            _custofinest = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime Data
    {
        get
        {
            PropriedadeAcessada("Data");
            return _data;
        }
        set
        {
            PropriedadeModificada("Data", value);
            _data = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dataconf
    {
        get
        {
            PropriedadeAcessada("Dataconf");
            return _dataconf;
        }
        set
        {
            PropriedadeModificada("Dataconf", value);
            _dataconf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dataconffim
    {
        get
        {
            PropriedadeAcessada("Dataconffim");
            return _dataconffim;
        }
        set
        {
            PropriedadeModificada("Dataconffim", value);
            _dataconffim = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Descprecofab
    {
        get
        {
            PropriedadeAcessada("Descprecofab");
            return _descprecofab;
        }
        set
        {
            PropriedadeModificada("Descprecofab", value);
            _descprecofab = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtajusteos
    {
        get
        {
            PropriedadeAcessada("Dtajusteos");
            return _dtajusteos;
        }
        set
        {
            PropriedadeModificada("Dtajusteos", value);
            _dtajusteos = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtalteracaoos
    {
        get
        {
            PropriedadeAcessada("Dtalteracaoos");
            return _dtalteracaoos;
        }
        set
        {
            PropriedadeModificada("Dtalteracaoos", value);
            _dtalteracaoos = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtentrega
    {
        get
        {
            PropriedadeAcessada("Dtentrega");
            return _dtentrega;
        }
        set
        {
            PropriedadeModificada("Dtentrega", value);
            _dtentrega = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtexportacaoservint
    {
        get
        {
            PropriedadeAcessada("Dtexportacaoservint");
            return _dtexportacaoservint;
        }
        set
        {
            PropriedadeModificada("Dtexportacaoservint", value);
            _dtexportacaoservint = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtfimpromolote
    {
        get
        {
            PropriedadeAcessada("Dtfimpromolote");
            return _dtfimpromolote;
        }
        set
        {
            PropriedadeModificada("Dtfimpromolote", value);
            _dtfimpromolote = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtfinalpend
    {
        get
        {
            PropriedadeAcessada("Dtfinalpend");
            return _dtfinalpend;
        }
        set
        {
            PropriedadeModificada("Dtfinalpend", value);
            _dtfinalpend = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtfinalsep
    {
        get
        {
            PropriedadeAcessada("Dtfinalsep");
            return _dtfinalsep;
        }
        set
        {
            PropriedadeModificada("Dtfinalsep", value);
            _dtfinalsep = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtgeracaoos
    {
        get
        {
            PropriedadeAcessada("Dtgeracaoos");
            return _dtgeracaoos;
        }
        set
        {
            PropriedadeModificada("Dtgeracaoos", value);
            _dtgeracaoos = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtimportacaoservprinc
    {
        get
        {
            PropriedadeAcessada("Dtimportacaoservprinc");
            return _dtimportacaoservprinc;
        }
        set
        {
            PropriedadeModificada("Dtimportacaoservprinc", value);
            _dtimportacaoservprinc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtinicialpend
    {
        get
        {
            PropriedadeAcessada("Dtinicialpend");
            return _dtinicialpend;
        }
        set
        {
            PropriedadeModificada("Dtinicialpend", value);
            _dtinicialpend = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtinicialsep
    {
        get
        {
            PropriedadeAcessada("Dtinicialsep");
            return _dtinicialsep;
        }
        set
        {
            PropriedadeModificada("Dtinicialsep", value);
            _dtinicialsep = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtiniciopromolote
    {
        get
        {
            PropriedadeAcessada("Dtiniciopromolote");
            return _dtiniciopromolote;
        }
        set
        {
            PropriedadeModificada("Dtiniciopromolote", value);
            _dtiniciopromolote = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtlanc
    {
        get
        {
            PropriedadeAcessada("Dtlanc");
            return _dtlanc;
        }
        set
        {
            PropriedadeModificada("Dtlanc", value);
            _dtlanc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtlibos
    {
        get
        {
            PropriedadeAcessada("Dtlibos");
            return _dtlibos;
        }
        set
        {
            PropriedadeModificada("Dtlibos", value);
            _dtlibos = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtultlalter
    {
        get
        {
            PropriedadeAcessada("Dtultlalter");
            return _dtultlalter;
        }
        set
        {
            PropriedadeModificada("Dtultlalter", value);
            _dtultlalter = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 0)]
    public decimal? Eancodprod
    {
        get
        {
            PropriedadeAcessada("Eancodprod");
            return _eancodprod;
        }
        set
        {
            PropriedadeModificada("Eancodprod", value);
            _eancodprod = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Exportadoservint
    {
        get
        {
            PropriedadeAcessada("Exportadoservint");
            return _exportadoservint;
        }
        set
        {
            PropriedadeModificada("Exportadoservint", value);
            _exportadoservint = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Formanegociacao
    {
        get
        {
            PropriedadeAcessada("Formanegociacao");
            return _formanegociacao;
        }
        set
        {
            PropriedadeModificada("Formanegociacao", value);
            _formanegociacao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Geragnre_Cnpjcliente
    {
        get
        {
            PropriedadeAcessada("Geragnre_Cnpjcliente");
            return _geragnre_cnpjcliente;
        }
        set
        {
            PropriedadeModificada("Geragnre_Cnpjcliente", value);
            _geragnre_cnpjcliente = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Grpregrabrinde
    {
        get
        {
            PropriedadeAcessada("Grpregrabrinde");
            return _grpregrabrinde;
        }
        set
        {
            PropriedadeModificada("Grpregrabrinde", value);
            _grpregrabrinde = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Grupofaturamento
    {
        get
        {
            PropriedadeAcessada("Grupofaturamento");
            return _grupofaturamento;
        }
        set
        {
            PropriedadeModificada("Grupofaturamento", value);
            _grupofaturamento = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 75, Precisao = 0)]
    public string Idpatrimonio
    {
        get
        {
            PropriedadeAcessada("Idpatrimonio");
            return _idpatrimonio;
        }
        set
        {
            PropriedadeModificada("Idpatrimonio", value);
            _idpatrimonio = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Idvenda
    {
        get
        {
            PropriedadeAcessada("Idvenda");
            return _idvenda;
        }
        set
        {
            PropriedadeModificada("Idvenda", value);
            _idvenda = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Importadoservprinc
    {
        get
        {
            PropriedadeAcessada("Importadoservprinc");
            return _importadoservprinc;
        }
        set
        {
            PropriedadeModificada("Importadoservprinc", value);
            _importadoservprinc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Imprime
    {
        get
        {
            PropriedadeAcessada("Imprime");
            return _imprime;
        }
        set
        {
            PropriedadeModificada("Imprime", value);
            _imprime = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Iva
    {
        get
        {
            PropriedadeAcessada("Iva");
            return _iva;
        }
        set
        {
            PropriedadeModificada("Iva", value);
            _iva = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Letracomiss
    {
        get
        {
            PropriedadeAcessada("Letracomiss");
            return _letracomiss;
        }
        set
        {
            PropriedadeModificada("Letracomiss", value);
            _letracomiss = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
    public string Localizacao
    {
        get
        {
            PropriedadeAcessada("Localizacao");
            return _localizacao;
        }
        set
        {
            PropriedadeModificada("Localizacao", value);
            _localizacao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 60, Precisao = 0)]
    public string Localizacaoos
    {
        get
        {
            PropriedadeAcessada("Localizacaoos");
            return _localizacaoos;
        }
        set
        {
            PropriedadeModificada("Localizacaoos", value);
            _localizacaoos = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Movimentacontacorrenterca
    {
        get
        {
            PropriedadeAcessada("Movimentacontacorrenterca");
            return _movimentacontacorrenterca;
        }
        set
        {
            PropriedadeModificada("Movimentacontacorrenterca", value);
            _movimentacontacorrenterca = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Negociacaoposterior
    {
        get
        {
            PropriedadeAcessada("Negociacaoposterior");
            return _negociacaoposterior;
        }
        set
        {
            PropriedadeModificada("Negociacaoposterior", value);
            _negociacaoposterior = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 60, Precisao = 0)]
    public string Nomeconcorrente
    {
        get
        {
            PropriedadeAcessada("Nomeconcorrente");
            return _nomeconcorrente;
        }
        set
        {
            PropriedadeModificada("Nomeconcorrente", value);
            _nomeconcorrente = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Numaplic
    {
        get
        {
            PropriedadeAcessada("Numaplic");
            return _numaplic;
        }
        set
        {
            PropriedadeModificada("Numaplic", value);
            _numaplic = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 10, Precisao = 0)]
    public string Numcaixa
    {
        get
        {
            PropriedadeAcessada("Numcaixa");
            return _numcaixa;
        }
        set
        {
            PropriedadeModificada("Numcaixa", value);
            _numcaixa = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Numcar
    {
        get
        {
            PropriedadeAcessada("Numcar");
            return _numcar;
        }
        set
        {
            PropriedadeModificada("Numcar", value);
            _numcar = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Numcaraux
    {
        get
        {
            PropriedadeAcessada("Numcaraux");
            return _numcaraux;
        }
        set
        {
            PropriedadeModificada("Numcaraux", value);
            _numcaraux = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 2, Precisao = 0)]
    public decimal? Numconferencia
    {
        get
        {
            PropriedadeAcessada("Numconferencia");
            return _numconferencia;
        }
        set
        {
            PropriedadeModificada("Numconferencia", value);
            _numconferencia = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
    public string Numerorecopi
    {
        get
        {
            PropriedadeAcessada("Numerorecopi");
            return _numerorecopi;
        }
        set
        {
            PropriedadeModificada("Numerorecopi", value);
            _numerorecopi = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Numetiqueta
    {
        get
        {
            PropriedadeAcessada("Numetiqueta");
            return _numetiqueta;
        }
        set
        {
            PropriedadeModificada("Numetiqueta", value);
            _numetiqueta = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Numitemped
    {
        get
        {
            PropriedadeAcessada("Numitemped");
            return _numitemped;
        }
        set
        {
            PropriedadeModificada("Numitemped", value);
            _numitemped = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Numlista
    {
        get
        {
            PropriedadeAcessada("Numlista");
            return _numlista;
        }
        set
        {
            PropriedadeModificada("Numlista", value);
            _numlista = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 15, Precisao = 0)]
    public string Numlote
    {
        get
        {
            PropriedadeAcessada("Numlote");
            return _numlote;
        }
        set
        {
            PropriedadeModificada("Numlote", value);
            _numlote = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Numop
    {
        get
        {
            PropriedadeAcessada("Numop");
            return _numop;
        }
        set
        {
            PropriedadeModificada("Numop", value);
            _numop = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 15, Precisao = 0)]
    public decimal? Numos
    {
        get
        {
            PropriedadeAcessada("Numos");
            return _numos;
        }
        set
        {
            PropriedadeModificada("Numos", value);
            _numos = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 15, Precisao = 0)]
    public decimal? Numosorigem
    {
        get
        {
            PropriedadeAcessada("Numosorigem");
            return _numosorigem;
        }
        set
        {
            PropriedadeModificada("Numosorigem", value);
            _numosorigem = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal Numped
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 20, Precisao = 0)]
    public decimal? Numrecopi
    {
        get
        {
            PropriedadeAcessada("Numrecopi");
            return _numrecopi;
        }
        set
        {
            PropriedadeModificada("Numrecopi", value);
            _numrecopi = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 20, Precisao = 0)]
    public decimal Numseq
    {
        get
        {
            PropriedadeAcessada("Numseq");
            return _numseq;
        }
        set
        {
            PropriedadeModificada("Numseq", value);
            _numseq = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Numseqcestabasica
    {
        get
        {
            PropriedadeAcessada("Numseqcestabasica");
            return _numseqcestabasica;
        }
        set
        {
            PropriedadeModificada("Numseqcestabasica", value);
            _numseqcestabasica = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Numseqitemcontrato
    {
        get
        {
            PropriedadeAcessada("Numseqitemcontrato");
            return _numseqitemcontrato;
        }
        set
        {
            PropriedadeModificada("Numseqitemcontrato", value);
            _numseqitemcontrato = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 13, Precisao = 0)]
    public string Numseriesat
    {
        get
        {
            PropriedadeAcessada("Numseriesat");
            return _numseriesat;
        }
        set
        {
            PropriedadeModificada("Numseriesat", value);
            _numseriesat = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numtira
    {
        get
        {
            PropriedadeAcessada("Numtira");
            return _numtira;
        }
        set
        {
            PropriedadeModificada("Numtira", value);
            _numtira = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numtranswms
    {
        get
        {
            PropriedadeAcessada("Numtranswms");
            return _numtranswms;
        }
        set
        {
            PropriedadeModificada("Numtranswms", value);
            _numtranswms = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Numverbarebcmv
    {
        get
        {
            PropriedadeAcessada("Numverbarebcmv");
            return _numverbarebcmv;
        }
        set
        {
            PropriedadeModificada("Numverbarebcmv", value);
            _numverbarebcmv = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 3, Precisao = 0)]
    public decimal? Numviasos
    {
        get
        {
            PropriedadeAcessada("Numviasos");
            return _numviasos;
        }
        set
        {
            PropriedadeModificada("Numviasos", value);
            _numviasos = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Numvolumesconferencia
    {
        get
        {
            PropriedadeAcessada("Numvolumesconferencia");
            return _numvolumesconferencia;
        }
        set
        {
            PropriedadeModificada("Numvolumesconferencia", value);
            _numvolumesconferencia = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Binario, Tamanho = 4000, Precisao = 0)]
    public string Origemdepreco
    {
        get
        {
            PropriedadeAcessada("Origemdepreco");
            return _origemdepreco;
        }
        set
        {
            PropriedadeModificada("Origemdepreco", value);
            _origemdepreco = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Origemst
    {
        get
        {
            PropriedadeAcessada("Origemst");
            return _origemst;
        }
        set
        {
            PropriedadeModificada("Origemst", value);
            _origemst = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Participagiro
    {
        get
        {
            PropriedadeAcessada("Participagiro");
            return _participagiro;
        }
        set
        {
            PropriedadeModificada("Participagiro", value);
            _participagiro = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Pauta
    {
        get
        {
            PropriedadeAcessada("Pauta");
            return _pauta;
        }
        set
        {
            PropriedadeModificada("Pauta", value);
            _pauta = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Pbaserca
    {
        get
        {
            PropriedadeAcessada("Pbaserca");
            return _pbaserca;
        }
        set
        {
            PropriedadeModificada("Pbaserca", value);
            _pbaserca = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Pbonific
    {
        get
        {
            PropriedadeAcessada("Pbonific");
            return _pbonific;
        }
        set
        {
            PropriedadeModificada("Pbonific", value);
            _pbonific = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Perbonific
    {
        get
        {
            PropriedadeAcessada("Perbonific");
            return _perbonific;
        }
        set
        {
            PropriedadeModificada("Perbonific", value);
            _perbonific = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Percagregadorst
    {
        get
        {
            PropriedadeAcessada("Percagregadorst");
            return _percagregadorst;
        }
        set
        {
            PropriedadeModificada("Percagregadorst", value);
            _percagregadorst = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Percbasered
    {
        get
        {
            PropriedadeAcessada("Percbasered");
            return _percbasered;
        }
        set
        {
            PropriedadeModificada("Percbasered", value);
            _percbasered = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 2)]
    public decimal? Percbaseredpart
    {
        get
        {
            PropriedadeAcessada("Percbaseredpart");
            return _percbaseredpart;
        }
        set
        {
            PropriedadeModificada("Percbaseredpart", value);
            _percbaseredpart = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Percbaseredst
    {
        get
        {
            PropriedadeAcessada("Percbaseredst");
            return _percbaseredst;
        }
        set
        {
            PropriedadeModificada("Percbaseredst", value);
            _percbaseredst = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Percbaseredstfonte
    {
        get
        {
            PropriedadeAcessada("Percbaseredstfonte");
            return _percbaseredstfonte;
        }
        set
        {
            PropriedadeModificada("Percbaseredstfonte", value);
            _percbaseredstfonte = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Percdescabatimento
    {
        get
        {
            PropriedadeAcessada("Percdescabatimento");
            return _percdescabatimento;
        }
        set
        {
            PropriedadeModificada("Percdescabatimento", value);
            _percdescabatimento = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Percdesccofins
    {
        get
        {
            PropriedadeAcessada("Percdesccofins");
            return _percdesccofins;
        }
        set
        {
            PropriedadeModificada("Percdesccofins", value);
            _percdesccofins = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Percdescindustria
    {
        get
        {
            PropriedadeAcessada("Percdescindustria");
            return _percdescindustria;
        }
        set
        {
            PropriedadeModificada("Percdescindustria", value);
            _percdescindustria = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Percdescpis
    {
        get
        {
            PropriedadeAcessada("Percdescpis");
            return _percdescpis;
        }
        set
        {
            PropriedadeModificada("Percdescpis", value);
            _percdescpis = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Percdifaliquotas
    {
        get
        {
            PropriedadeAcessada("Percdifaliquotas");
            return _percdifaliquotas;
        }
        set
        {
            PropriedadeModificada("Percdifaliquotas", value);
            _percdifaliquotas = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Percicm
    {
        get
        {
            PropriedadeAcessada("Percicm");
            return _percicm;
        }
        set
        {
            PropriedadeModificada("Percicm", value);
            _percicm = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Percipi
    {
        get
        {
            PropriedadeAcessada("Percipi");
            return _percipi;
        }
        set
        {
            PropriedadeModificada("Percipi", value);
            _percipi = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Percipiecf
    {
        get
        {
            PropriedadeAcessada("Percipiecf");
            return _percipiecf;
        }
        set
        {
            PropriedadeModificada("Percipiecf", value);
            _percipiecf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Percipioutras
    {
        get
        {
            PropriedadeAcessada("Percipioutras");
            return _percipioutras;
        }
        set
        {
            PropriedadeModificada("Percipioutras", value);
            _percipioutras = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Perciss
    {
        get
        {
            PropriedadeAcessada("Perciss");
            return _perciss;
        }
        set
        {
            PropriedadeModificada("Perciss", value);
            _perciss = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal Percom
    {
        get
        {
            PropriedadeAcessada("Percom");
            return _percom;
        }
        set
        {
            PropriedadeModificada("Percom", value);
            _percom = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Percom2
    {
        get
        {
            PropriedadeAcessada("Percom2");
            return _percom2;
        }
        set
        {
            PropriedadeModificada("Percom2", value);
            _percom2 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Percom3
    {
        get
        {
            PropriedadeAcessada("Percom3");
            return _percom3;
        }
        set
        {
            PropriedadeModificada("Percom3", value);
            _percom3 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Percom4
    {
        get
        {
            PropriedadeAcessada("Percom4");
            return _percom4;
        }
        set
        {
            PropriedadeModificada("Percom4", value);
            _percom4 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 2)]
    public decimal? Percomprof
    {
        get
        {
            PropriedadeAcessada("Percomprof");
            return _percomprof;
        }
        set
        {
            PropriedadeModificada("Percomprof", value);
            _percomprof = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Percomsup
    {
        get
        {
            PropriedadeAcessada("Percomsup");
            return _percomsup;
        }
        set
        {
            PropriedadeModificada("Percomsup", value);
            _percomsup = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Percomtab
    {
        get
        {
            PropriedadeAcessada("Percomtab");
            return _percomtab;
        }
        set
        {
            PropriedadeModificada("Percomtab", value);
            _percomtab = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 2)]
    public decimal? Percprovpart
    {
        get
        {
            PropriedadeAcessada("Percprovpart");
            return _percprovpart;
        }
        set
        {
            PropriedadeModificada("Percprovpart", value);
            _percprovpart = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Percredaliqipi
    {
        get
        {
            PropriedadeAcessada("Percredaliqipi");
            return _percredaliqipi;
        }
        set
        {
            PropriedadeModificada("Percredaliqipi", value);
            _percredaliqipi = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 2)]
    public decimal? Perctributos
    {
        get
        {
            PropriedadeAcessada("Perctributos");
            return _perctributos;
        }
        set
        {
            PropriedadeModificada("Perctributos", value);
            _perctributos = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 2)]
    public decimal? Percvenda
    {
        get
        {
            PropriedadeAcessada("Percvenda");
            return _percvenda;
        }
        set
        {
            PropriedadeModificada("Percvenda", value);
            _percvenda = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal Perdesc
    {
        get
        {
            PropriedadeAcessada("Perdesc");
            return _perdesc;
        }
        set
        {
            PropriedadeModificada("Perdesc", value);
            _perdesc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Perdescavista
    {
        get
        {
            PropriedadeAcessada("Perdescavista");
            return _perdescavista;
        }
        set
        {
            PropriedadeModificada("Perdescavista", value);
            _perdescavista = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Perdescboleto
    {
        get
        {
            PropriedadeAcessada("Perdescboleto");
            return _perdescboleto;
        }
        set
        {
            PropriedadeModificada("Perdescboleto", value);
            _perdescboleto = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Perdesccom
    {
        get
        {
            PropriedadeAcessada("Perdesccom");
            return _perdesccom;
        }
        set
        {
            PropriedadeModificada("Perdesccom", value);
            _perdesccom = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Perdesccusto
    {
        get
        {
            PropriedadeAcessada("Perdesccusto");
            return _perdesccusto;
        }
        set
        {
            PropriedadeModificada("Perdesccusto", value);
            _perdesccusto = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 6)]
    public decimal? Perdescfimcomiss
    {
        get
        {
            PropriedadeAcessada("Perdescfimcomiss");
            return _perdescfimcomiss;
        }
        set
        {
            PropriedadeModificada("Perdescfimcomiss", value);
            _perdescfimcomiss = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Perdescfin
    {
        get
        {
            PropriedadeAcessada("Perdescfin");
            return _perdescfin;
        }
        set
        {
            PropriedadeModificada("Perdescfin", value);
            _perdescfin = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Perdescflex
    {
        get
        {
            PropriedadeAcessada("Perdescflex");
            return _perdescflex;
        }
        set
        {
            PropriedadeModificada("Perdescflex", value);
            _perdescflex = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 2)]
    public decimal? Perdescfob
    {
        get
        {
            PropriedadeAcessada("Perdescfob");
            return _perdescfob;
        }
        set
        {
            PropriedadeModificada("Perdescfob", value);
            _perdescfob = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 6)]
    public decimal? Perdescinicomiss
    {
        get
        {
            PropriedadeAcessada("Perdescinicomiss");
            return _perdescinicomiss;
        }
        set
        {
            PropriedadeModificada("Perdescinicomiss", value);
            _perdescinicomiss = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 2)]
    public decimal? Perdescisentoicms
    {
        get
        {
            PropriedadeAcessada("Perdescisentoicms");
            return _perdescisentoicms;
        }
        set
        {
            PropriedadeModificada("Perdescisentoicms", value);
            _perdescisentoicms = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Perdescnegociado
    {
        get
        {
            PropriedadeAcessada("Perdescnegociado");
            return _perdescnegociado;
        }
        set
        {
            PropriedadeModificada("Perdescnegociado", value);
            _perdescnegociado = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Perdescpauta
    {
        get
        {
            PropriedadeAcessada("Perdescpauta");
            return _perdescpauta;
        }
        set
        {
            PropriedadeModificada("Perdescpauta", value);
            _perdescpauta = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 2)]
    public decimal? Perdescpolitica
    {
        get
        {
            PropriedadeAcessada("Perdescpolitica");
            return _perdescpolitica;
        }
        set
        {
            PropriedadeModificada("Perdescpolitica", value);
            _perdescpolitica = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Perdesctab
    {
        get
        {
            PropriedadeAcessada("Perdesctab");
            return _perdesctab;
        }
        set
        {
            PropriedadeModificada("Perdesctab", value);
            _perdesctab = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Perfretecmv
    {
        get
        {
            PropriedadeAcessada("Perfretecmv");
            return _perfretecmv;
        }
        set
        {
            PropriedadeModificada("Perfretecmv", value);
            _perfretecmv = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Perredcomiss
    {
        get
        {
            PropriedadeAcessada("Perredcomiss");
            return _perredcomiss;
        }
        set
        {
            PropriedadeModificada("Perredcomiss", value);
            _perredcomiss = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Perredcomisssup
    {
        get
        {
            PropriedadeAcessada("Perredcomisssup");
            return _perredcomisssup;
        }
        set
        {
            PropriedadeModificada("Perredcomisssup", value);
            _perredcomisssup = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 7, Precisao = 3)]
    public decimal? Pesobruto
    {
        get
        {
            PropriedadeAcessada("Pesobruto");
            return _pesobruto;
        }
        set
        {
            PropriedadeModificada("Pesobruto", value);
            _pesobruto = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Politicaprioritaria
    {
        get
        {
            PropriedadeAcessada("Politicaprioritaria");
            return _politicaprioritaria;
        }
        set
        {
            PropriedadeModificada("Politicaprioritaria", value);
            _politicaprioritaria = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Poriginal
    {
        get
        {
            PropriedadeAcessada("Poriginal");
            return _poriginal;
        }
        set
        {
            PropriedadeModificada("Poriginal", value);
            _poriginal = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Posicao
    {
        get
        {
            PropriedadeAcessada("Posicao");
            return _posicao;
        }
        set
        {
            PropriedadeModificada("Posicao", value);
            _posicao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
    public string Prazo
    {
        get
        {
            PropriedadeAcessada("Prazo");
            return _prazo;
        }
        set
        {
            PropriedadeModificada("Prazo", value);
            _prazo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Prazomedio
    {
        get
        {
            PropriedadeAcessada("Prazomedio");
            return _prazomedio;
        }
        set
        {
            PropriedadeModificada("Prazomedio", value);
            _prazomedio = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 2)]
    public decimal? Preco
    {
        get
        {
            PropriedadeAcessada("Preco");
            return _preco;
        }
        set
        {
            PropriedadeModificada("Preco", value);
            _preco = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Precofvbruto
    {
        get
        {
            PropriedadeAcessada("Precofvbruto");
            return _precofvbruto;
        }
        set
        {
            PropriedadeModificada("Precofvbruto", value);
            _precofvbruto = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Precomaxconsum
    {
        get
        {
            PropriedadeAcessada("Precomaxconsum");
            return _precomaxconsum;
        }
        set
        {
            PropriedadeModificada("Precomaxconsum", value);
            _precomaxconsum = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 300, Precisao = 0)]
    public string Proddescricaocontrato
    {
        get
        {
            PropriedadeAcessada("Proddescricaocontrato");
            return _proddescricaocontrato;
        }
        set
        {
            PropriedadeModificada("Proddescricaocontrato", value);
            _proddescricaocontrato = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 500, Precisao = 0)]
    public string Proddescricaodanfe
    {
        get
        {
            PropriedadeAcessada("Proddescricaodanfe");
            return _proddescricaodanfe;
        }
        set
        {
            PropriedadeModificada("Proddescricaodanfe", value);
            _proddescricaodanfe = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal Ptabela
    {
        get
        {
            PropriedadeAcessada("Ptabela");
            return _ptabela;
        }
        set
        {
            PropriedadeModificada("Ptabela", value);
            _ptabela = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Ptabelaautpecas
    {
        get
        {
            PropriedadeAcessada("Ptabelaautpecas");
            return _ptabelaautpecas;
        }
        set
        {
            PropriedadeModificada("Ptabelaautpecas", value);
            _ptabelaautpecas = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal Pvenda
    {
        get
        {
            PropriedadeAcessada("Pvenda");
            return _pvenda;
        }
        set
        {
            PropriedadeModificada("Pvenda", value);
            _pvenda = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Pvenda1
    {
        get
        {
            PropriedadeAcessada("Pvenda1");
            return _pvenda1;
        }
        set
        {
            PropriedadeModificada("Pvenda1", value);
            _pvenda1 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Pvendaanterior
    {
        get
        {
            PropriedadeAcessada("Pvendaanterior");
            return _pvendaanterior;
        }
        set
        {
            PropriedadeModificada("Pvendaanterior", value);
            _pvendaanterior = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Pvendabase
    {
        get
        {
            PropriedadeAcessada("Pvendabase");
            return _pvendabase;
        }
        set
        {
            PropriedadeModificada("Pvendabase", value);
            _pvendabase = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 3)]
    public decimal? Pvendaemb
    {
        get
        {
            PropriedadeAcessada("Pvendaemb");
            return _pvendaemb;
        }
        set
        {
            PropriedadeModificada("Pvendaemb", value);
            _pvendaemb = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Pvendaembalagem
    {
        get
        {
            PropriedadeAcessada("Pvendaembalagem");
            return _pvendaembalagem;
        }
        set
        {
            PropriedadeModificada("Pvendaembalagem", value);
            _pvendaembalagem = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Pvendaliq
    {
        get
        {
            PropriedadeAcessada("Pvendaliq");
            return _pvendaliq;
        }
        set
        {
            PropriedadeModificada("Pvendaliq", value);
            _pvendaliq = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Pvendavasilhame
    {
        get
        {
            PropriedadeAcessada("Pvendavasilhame");
            return _pvendavasilhame;
        }
        set
        {
            PropriedadeModificada("Pvendavasilhame", value);
            _pvendavasilhame = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 20, Precisao = 6)]
    public decimal Qt
    {
        get
        {
            PropriedadeAcessada("Qt");
            return _qt;
        }
        set
        {
            PropriedadeModificada("Qt", value);
            _qt = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 20, Precisao = 6)]
    public decimal? Qtapanha
    {
        get
        {
            PropriedadeAcessada("Qtapanha");
            return _qtapanha;
        }
        set
        {
            PropriedadeModificada("Qtapanha", value);
            _qtapanha = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 6)]
    public decimal? Qtcx
    {
        get
        {
            PropriedadeAcessada("Qtcx");
            return _qtcx;
        }
        set
        {
            PropriedadeModificada("Qtcx", value);
            _qtcx = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Qtdiasentregaitem
    {
        get
        {
            PropriedadeAcessada("Qtdiasentregaitem");
            return _qtdiasentregaitem;
        }
        set
        {
            PropriedadeModificada("Qtdiasentregaitem", value);
            _qtdiasentregaitem = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 3)]
    public decimal? Qtembalagem
    {
        get
        {
            PropriedadeAcessada("Qtembalagem");
            return _qtembalagem;
        }
        set
        {
            PropriedadeModificada("Qtembalagem", value);
            _qtembalagem = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 20, Precisao = 6)]
    public decimal? Qtfalta
    {
        get
        {
            PropriedadeAcessada("Qtfalta");
            return _qtfalta;
        }
        set
        {
            PropriedadeModificada("Qtfalta", value);
            _qtfalta = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 16, Precisao = 3)]
    public decimal? Qtimediata
    {
        get
        {
            PropriedadeAcessada("Qtimediata");
            return _qtimediata;
        }
        set
        {
            PropriedadeModificada("Qtimediata", value);
            _qtimediata = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Qtlitragem
    {
        get
        {
            PropriedadeAcessada("Qtlitragem");
            return _qtlitragem;
        }
        set
        {
            PropriedadeModificada("Qtlitragem", value);
            _qtlitragem = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 2)]
    public decimal? Qtlocalizada
    {
        get
        {
            PropriedadeAcessada("Qtlocalizada");
            return _qtlocalizada;
        }
        set
        {
            PropriedadeModificada("Qtlocalizada", value);
            _qtlocalizada = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Qtnaocompra
    {
        get
        {
            PropriedadeAcessada("Qtnaocompra");
            return _qtnaocompra;
        }
        set
        {
            PropriedadeModificada("Qtnaocompra", value);
            _qtnaocompra = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 20, Precisao = 6)]
    public decimal? Qtorig
    {
        get
        {
            PropriedadeAcessada("Qtorig");
            return _qtorig;
        }
        set
        {
            PropriedadeModificada("Qtorig", value);
            _qtorig = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 20, Precisao = 6)]
    public decimal? Qtoriginal
    {
        get
        {
            PropriedadeAcessada("Qtoriginal");
            return _qtoriginal;
        }
        set
        {
            PropriedadeModificada("Qtoriginal", value);
            _qtoriginal = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 6)]
    public decimal? Qtpecas
    {
        get
        {
            PropriedadeAcessada("Qtpecas");
            return _qtpecas;
        }
        set
        {
            PropriedadeModificada("Qtpecas", value);
            _qtpecas = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 4)]
    public decimal? Qtpendos
    {
        get
        {
            PropriedadeAcessada("Qtpendos");
            return _qtpendos;
        }
        set
        {
            PropriedadeModificada("Qtpendos", value);
            _qtpendos = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 20, Precisao = 6)]
    public decimal? Qtreservant
    {
        get
        {
            PropriedadeAcessada("Qtreservant");
            return _qtreservant;
        }
        set
        {
            PropriedadeModificada("Qtreservant", value);
            _qtreservant = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Qtsaidavasilhame
    {
        get
        {
            PropriedadeAcessada("Qtsaidavasilhame");
            return _qtsaidavasilhame;
        }
        set
        {
            PropriedadeModificada("Qtsaidavasilhame", value);
            _qtsaidavasilhame = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 20, Precisao = 6)]
    public decimal? Qtseparada
    {
        get
        {
            PropriedadeAcessada("Qtseparada");
            return _qtseparada;
        }
        set
        {
            PropriedadeModificada("Qtseparada", value);
            _qtseparada = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Qtsepararcx
    {
        get
        {
            PropriedadeAcessada("Qtsepararcx");
            return _qtsepararcx;
        }
        set
        {
            PropriedadeModificada("Qtsepararcx", value);
            _qtsepararcx = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Qtsepararun
    {
        get
        {
            PropriedadeAcessada("Qtsepararun");
            return _qtsepararun;
        }
        set
        {
            PropriedadeModificada("Qtsepararun", value);
            _qtsepararun = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 16, Precisao = 0)]
    public decimal? Qtun
    {
        get
        {
            PropriedadeAcessada("Qtun");
            return _qtun;
        }
        set
        {
            PropriedadeModificada("Qtun", value);
            _qtun = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 2)]
    public decimal? Qtunitcx
    {
        get
        {
            PropriedadeAcessada("Qtunitcx");
            return _qtunitcx;
        }
        set
        {
            PropriedadeModificada("Qtunitcx", value);
            _qtunitcx = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Qtunitemb
    {
        get
        {
            PropriedadeAcessada("Qtunitemb");
            return _qtunitemb;
        }
        set
        {
            PropriedadeModificada("Qtunitemb", value);
            _qtunitemb = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 3)]
    public decimal? Qtvendaemb
    {
        get
        {
            PropriedadeAcessada("Qtvendaemb");
            return _qtvendaemb;
        }
        set
        {
            PropriedadeModificada("Qtvendaemb", value);
            _qtvendaemb = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Qtvendidavasilhame
    {
        get
        {
            PropriedadeAcessada("Qtvendidavasilhame");
            return _qtvendidavasilhame;
        }
        set
        {
            PropriedadeModificada("Qtvendidavasilhame", value);
            _qtvendidavasilhame = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 20, Precisao = 6)]
    public decimal? Qt_Separadamanif
    {
        get
        {
            PropriedadeAcessada("Qt_Separadamanif");
            return _qt_separadamanif;
        }
        set
        {
            PropriedadeModificada("Qt_Separadamanif", value);
            _qt_separadamanif = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
    public string Refcor
    {
        get
        {
            PropriedadeAcessada("Refcor");
            return _refcor;
        }
        set
        {
            PropriedadeModificada("Refcor", value);
            _refcor = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
    public string Rotina
    {
        get
        {
            PropriedadeAcessada("Rotina");
            return _rotina;
        }
        set
        {
            PropriedadeModificada("Rotina", value);
            _rotina = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Rotinalanc
    {
        get
        {
            PropriedadeAcessada("Rotinalanc");
            return _rotinalanc;
        }
        set
        {
            PropriedadeModificada("Rotinalanc", value);
            _rotinalanc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Rotinalancbrinde
    {
        get
        {
            PropriedadeAcessada("Rotinalancbrinde");
            return _rotinalancbrinde;
        }
        set
        {
            PropriedadeModificada("Rotinalancbrinde", value);
            _rotinalancbrinde = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 48, Precisao = 0)]
    public string Rotinalancultalt
    {
        get
        {
            PropriedadeAcessada("Rotinalancultalt");
            return _rotinalancultalt;
        }
        set
        {
            PropriedadeModificada("Rotinalancultalt", value);
            _rotinalancultalt = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Rotinaultlalter
    {
        get
        {
            PropriedadeAcessada("Rotinaultlalter");
            return _rotinaultlalter;
        }
        set
        {
            PropriedadeModificada("Rotinaultlalter", value);
            _rotinaultlalter = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Rp_Imediata
    {
        get
        {
            PropriedadeAcessada("Rp_Imediata");
            return _rp_imediata;
        }
        set
        {
            PropriedadeModificada("Rp_Imediata", value);
            _rp_imediata = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 10, Precisao = 0)]
    public string Siglaqualidade
    {
        get
        {
            PropriedadeAcessada("Siglaqualidade");
            return _siglaqualidade;
        }
        set
        {
            PropriedadeModificada("Siglaqualidade", value);
            _siglaqualidade = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 2, Precisao = 0)]
    public decimal? Situacaoos
    {
        get
        {
            PropriedadeAcessada("Situacaoos");
            return _situacaoos;
        }
        set
        {
            PropriedadeModificada("Situacaoos", value);
            _situacaoos = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal St
    {
        get
        {
            PropriedadeAcessada("St");
            return _st;
        }
        set
        {
            PropriedadeModificada("St", value);
            _st = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 1, Precisao = 0)]
    public decimal? Statussucata
    {
        get
        {
            PropriedadeAcessada("Statussucata");
            return _statussucata;
        }
        set
        {
            PropriedadeModificada("Statussucata", value);
            _statussucata = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Stclientegnre
    {
        get
        {
            PropriedadeAcessada("Stclientegnre");
            return _stclientegnre;
        }
        set
        {
            PropriedadeModificada("Stclientegnre", value);
            _stclientegnre = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Stpbaserca
    {
        get
        {
            PropriedadeAcessada("Stpbaserca");
            return _stpbaserca;
        }
        set
        {
            PropriedadeModificada("Stpbaserca", value);
            _stpbaserca = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Stptabela
    {
        get
        {
            PropriedadeAcessada("Stptabela");
            return _stptabela;
        }
        set
        {
            PropriedadeModificada("Stptabela", value);
            _stptabela = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? St_Ant_Rateio
    {
        get
        {
            PropriedadeAcessada("St_Ant_Rateio");
            return _st_ant_rateio;
        }
        set
        {
            PropriedadeModificada("St_Ant_Rateio", value);
            _st_ant_rateio = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? St_Dif_Rateio
    {
        get
        {
            PropriedadeAcessada("St_Dif_Rateio");
            return _st_dif_rateio;
        }
        set
        {
            PropriedadeModificada("St_Dif_Rateio", value);
            _st_dif_rateio = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Sugestao
    {
        get
        {
            PropriedadeAcessada("Sugestao");
            return _sugestao;
        }
        set
        {
            PropriedadeModificada("Sugestao", value);
            _sugestao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 6)]
    public decimal? Taxacasomoedareal
    {
        get
        {
            PropriedadeAcessada("Taxacasomoedareal");
            return _taxacasomoedareal;
        }
        set
        {
            PropriedadeModificada("Taxacasomoedareal", value);
            _taxacasomoedareal = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Tipocalculost
    {
        get
        {
            PropriedadeAcessada("Tipocalculost");
            return _tipocalculost;
        }
        set
        {
            PropriedadeModificada("Tipocalculost", value);
            _tipocalculost = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Tipodescaplicado
    {
        get
        {
            PropriedadeAcessada("Tipodescaplicado");
            return _tipodescaplicado;
        }
        set
        {
            PropriedadeModificada("Tipodescaplicado", value);
            _tipodescaplicado = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Tipoentrega
    {
        get
        {
            PropriedadeAcessada("Tipoentrega");
            return _tipoentrega;
        }
        set
        {
            PropriedadeModificada("Tipoentrega", value);
            _tipoentrega = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Tipopeso
    {
        get
        {
            PropriedadeAcessada("Tipopeso");
            return _tipopeso;
        }
        set
        {
            PropriedadeModificada("Tipopeso", value);
            _tipopeso = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Tiposeparacao
    {
        get
        {
            PropriedadeAcessada("Tiposeparacao");
            return _tiposeparacao;
        }
        set
        {
            PropriedadeModificada("Tiposeparacao", value);
            _tiposeparacao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 10, Precisao = 0)]
    public string Totalizadoraliquota
    {
        get
        {
            PropriedadeAcessada("Totalizadoraliquota");
            return _totalizadoraliquota;
        }
        set
        {
            PropriedadeModificada("Totalizadoraliquota", value);
            _totalizadoraliquota = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Truncaritem
    {
        get
        {
            PropriedadeAcessada("Truncaritem");
            return _truncaritem;
        }
        set
        {
            PropriedadeModificada("Truncaritem", value);
            _truncaritem = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 2, Precisao = 0)]
    public decimal? Tvbonif
    {
        get
        {
            PropriedadeAcessada("Tvbonif");
            return _tvbonif;
        }
        set
        {
            PropriedadeModificada("Tvbonif", value);
            _tvbonif = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 6)]
    public decimal? Txvenda
    {
        get
        {
            PropriedadeAcessada("Txvenda");
            return _txvenda;
        }
        set
        {
            PropriedadeModificada("Txvenda", value);
            _txvenda = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Unidade
    {
        get
        {
            PropriedadeAcessada("Unidade");
            return _unidade;
        }
        set
        {
            PropriedadeModificada("Unidade", value);
            _unidade = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Usadebcredrcabrind
    {
        get
        {
            PropriedadeAcessada("Usadebcredrcabrind");
            return _usadebcredrcabrind;
        }
        set
        {
            PropriedadeModificada("Usadebcredrcabrind", value);
            _usadebcredrcabrind = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Usaunidademaster
    {
        get
        {
            PropriedadeAcessada("Usaunidademaster");
            return _usaunidademaster;
        }
        set
        {
            PropriedadeModificada("Usaunidademaster", value);
            _usaunidademaster = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Vendapbm
    {
        get
        {
            PropriedadeAcessada("Vendapbm");
            return _vendapbm;
        }
        set
        {
            PropriedadeModificada("Vendapbm", value);
            _vendapbm = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlacrescrodape
    {
        get
        {
            PropriedadeAcessada("Vlacrescrodape");
            return _vlacrescrodape;
        }
        set
        {
            PropriedadeModificada("Vlacrescrodape", value);
            _vlacrescrodape = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlacrescvasilhame
    {
        get
        {
            PropriedadeAcessada("Vlacrescvasilhame");
            return _vlacrescvasilhame;
        }
        set
        {
            PropriedadeModificada("Vlacrescvasilhame", value);
            _vlacrescvasilhame = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 6)]
    public decimal? Vlacresfretekg
    {
        get
        {
            PropriedadeAcessada("Vlacresfretekg");
            return _vlacresfretekg;
        }
        set
        {
            PropriedadeModificada("Vlacresfretekg", value);
            _vlacresfretekg = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlbasepartdest
    {
        get
        {
            PropriedadeAcessada("Vlbasepartdest");
            return _vlbasepartdest;
        }
        set
        {
            PropriedadeModificada("Vlbasepartdest", value);
            _vlbasepartdest = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlbonific
    {
        get
        {
            PropriedadeAcessada("Vlbonific");
            return _vlbonific;
        }
        set
        {
            PropriedadeModificada("Vlbonific", value);
            _vlbonific = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlcustocont
    {
        get
        {
            PropriedadeAcessada("Vlcustocont");
            return _vlcustocont;
        }
        set
        {
            PropriedadeModificada("Vlcustocont", value);
            _vlcustocont = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal Vlcustofin
    {
        get
        {
            PropriedadeAcessada("Vlcustofin");
            return _vlcustofin;
        }
        set
        {
            PropriedadeModificada("Vlcustofin", value);
            _vlcustofin = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal Vlcustoreal
    {
        get
        {
            PropriedadeAcessada("Vlcustoreal");
            return _vlcustoreal;
        }
        set
        {
            PropriedadeModificada("Vlcustoreal", value);
            _vlcustoreal = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlcustorep
    {
        get
        {
            PropriedadeAcessada("Vlcustorep");
            return _vlcustorep;
        }
        set
        {
            PropriedadeModificada("Vlcustorep", value);
            _vlcustorep = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vldescabatimento
    {
        get
        {
            PropriedadeAcessada("Vldescabatimento");
            return _vldescabatimento;
        }
        set
        {
            PropriedadeModificada("Vldescabatimento", value);
            _vldescabatimento = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vldescboleto
    {
        get
        {
            PropriedadeAcessada("Vldescboleto");
            return _vldescboleto;
        }
        set
        {
            PropriedadeModificada("Vldescboleto", value);
            _vldescboleto = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vldesccom
    {
        get
        {
            PropriedadeAcessada("Vldesccom");
            return _vldesccom;
        }
        set
        {
            PropriedadeModificada("Vldesccom", value);
            _vldesccom = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Vldesccustocmv
    {
        get
        {
            PropriedadeAcessada("Vldesccustocmv");
            return _vldesccustocmv;
        }
        set
        {
            PropriedadeModificada("Vldesccustocmv", value);
            _vldesccustocmv = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vldescfin
    {
        get
        {
            PropriedadeAcessada("Vldescfin");
            return _vldescfin;
        }
        set
        {
            PropriedadeModificada("Vldescfin", value);
            _vldescfin = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vldescflex
    {
        get
        {
            PropriedadeAcessada("Vldescflex");
            return _vldescflex;
        }
        set
        {
            PropriedadeModificada("Vldescflex", value);
            _vldescflex = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vldescfornec
    {
        get
        {
            PropriedadeAcessada("Vldescfornec");
            return _vldescfornec;
        }
        set
        {
            PropriedadeModificada("Vldescfornec", value);
            _vldescfornec = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vldescicmisencao
    {
        get
        {
            PropriedadeAcessada("Vldescicmisencao");
            return _vldescicmisencao;
        }
        set
        {
            PropriedadeModificada("Vldescicmisencao", value);
            _vldescicmisencao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vldescpissuframa
    {
        get
        {
            PropriedadeAcessada("Vldescpissuframa");
            return _vldescpissuframa;
        }
        set
        {
            PropriedadeModificada("Vldescpissuframa", value);
            _vldescpissuframa = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 24, Precisao = 6)]
    public decimal? Vldescreducaocofins
    {
        get
        {
            PropriedadeAcessada("Vldescreducaocofins");
            return _vldescreducaocofins;
        }
        set
        {
            PropriedadeModificada("Vldescreducaocofins", value);
            _vldescreducaocofins = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 24, Precisao = 6)]
    public decimal? Vldescreducaopis
    {
        get
        {
            PropriedadeAcessada("Vldescreducaopis");
            return _vldescreducaopis;
        }
        set
        {
            PropriedadeModificada("Vldescreducaopis", value);
            _vldescreducaopis = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 12)]
    public decimal? Vldescrepasse
    {
        get
        {
            PropriedadeAcessada("Vldescrepasse");
            return _vldescrepasse;
        }
        set
        {
            PropriedadeModificada("Vldescrepasse", value);
            _vldescrepasse = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vldescrodape
    {
        get
        {
            PropriedadeAcessada("Vldescrodape");
            return _vldescrodape;
        }
        set
        {
            PropriedadeModificada("Vldescrodape", value);
            _vldescrodape = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 2)]
    public decimal? Vldescsociotorcedor
    {
        get
        {
            PropriedadeAcessada("Vldescsociotorcedor");
            return _vldescsociotorcedor;
        }
        set
        {
            PropriedadeModificada("Vldescsociotorcedor", value);
            _vldescsociotorcedor = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vldescsuframa
    {
        get
        {
            PropriedadeAcessada("Vldescsuframa");
            return _vldescsuframa;
        }
        set
        {
            PropriedadeModificada("Vldescsuframa", value);
            _vldescsuframa = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vldifaliquotas
    {
        get
        {
            PropriedadeAcessada("Vldifaliquotas");
            return _vldifaliquotas;
        }
        set
        {
            PropriedadeModificada("Vldifaliquotas", value);
            _vldifaliquotas = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlfcppart
    {
        get
        {
            PropriedadeAcessada("Vlfcppart");
            return _vlfcppart;
        }
        set
        {
            PropriedadeModificada("Vlfcppart", value);
            _vlfcppart = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlfrete
    {
        get
        {
            PropriedadeAcessada("Vlfrete");
            return _vlfrete;
        }
        set
        {
            PropriedadeModificada("Vlfrete", value);
            _vlfrete = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlfrete_Rateio
    {
        get
        {
            PropriedadeAcessada("Vlfrete_Rateio");
            return _vlfrete_rateio;
        }
        set
        {
            PropriedadeModificada("Vlfrete_Rateio", value);
            _vlfrete_rateio = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 22, Precisao = 6)]
    public decimal? Vlicmsdifaliqpart
    {
        get
        {
            PropriedadeAcessada("Vlicmsdifaliqpart");
            return _vlicmsdifaliqpart;
        }
        set
        {
            PropriedadeModificada("Vlicmsdifaliqpart", value);
            _vlicmsdifaliqpart = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlicmspart
    {
        get
        {
            PropriedadeAcessada("Vlicmspart");
            return _vlicmspart;
        }
        set
        {
            PropriedadeModificada("Vlicmspart", value);
            _vlicmspart = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlicmspartdest
    {
        get
        {
            PropriedadeAcessada("Vlicmspartdest");
            return _vlicmspartdest;
        }
        set
        {
            PropriedadeModificada("Vlicmspartdest", value);
            _vlicmspartdest = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlicmspartrem
    {
        get
        {
            PropriedadeAcessada("Vlicmspartrem");
            return _vlicmspartrem;
        }
        set
        {
            PropriedadeModificada("Vlicmspartrem", value);
            _vlicmspartrem = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlipi
    {
        get
        {
            PropriedadeAcessada("Vlipi");
            return _vlipi;
        }
        set
        {
            PropriedadeModificada("Vlipi", value);
            _vlipi = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlipiecf
    {
        get
        {
            PropriedadeAcessada("Vlipiecf");
            return _vlipiecf;
        }
        set
        {
            PropriedadeModificada("Vlipiecf", value);
            _vlipiecf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlipioutras
    {
        get
        {
            PropriedadeAcessada("Vlipioutras");
            return _vlipioutras;
        }
        set
        {
            PropriedadeModificada("Vlipioutras", value);
            _vlipioutras = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vliss
    {
        get
        {
            PropriedadeAcessada("Vliss");
            return _vliss;
        }
        set
        {
            PropriedadeModificada("Vliss", value);
            _vliss = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlitemtributos
    {
        get
        {
            PropriedadeAcessada("Vlitemtributos");
            return _vlitemtributos;
        }
        set
        {
            PropriedadeModificada("Vlitemtributos", value);
            _vlitemtributos = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vloutrasdesp
    {
        get
        {
            PropriedadeAcessada("Vloutrasdesp");
            return _vloutrasdesp;
        }
        set
        {
            PropriedadeModificada("Vloutrasdesp", value);
            _vloutrasdesp = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vloutras_Rateio
    {
        get
        {
            PropriedadeAcessada("Vloutras_Rateio");
            return _vloutras_rateio;
        }
        set
        {
            PropriedadeModificada("Vloutras_Rateio", value);
            _vloutras_rateio = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 16, Precisao = 3)]
    public decimal? Vloutros
    {
        get
        {
            PropriedadeAcessada("Vloutros");
            return _vloutros;
        }
        set
        {
            PropriedadeModificada("Vloutros", value);
            _vloutros = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlrebaixacmv
    {
        get
        {
            PropriedadeAcessada("Vlrebaixacmv");
            return _vlrebaixacmv;
        }
        set
        {
            PropriedadeModificada("Vlrebaixacmv", value);
            _vlrebaixacmv = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlredcmvsimplesnac
    {
        get
        {
            PropriedadeAcessada("Vlredcmvsimplesnac");
            return _vlredcmvsimplesnac;
        }
        set
        {
            PropriedadeModificada("Vlredcmvsimplesnac", value);
            _vlredcmvsimplesnac = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlredcomiss
    {
        get
        {
            PropriedadeAcessada("Vlredcomiss");
            return _vlredcomiss;
        }
        set
        {
            PropriedadeModificada("Vlredcomiss", value);
            _vlredcomiss = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlredcomisssup
    {
        get
        {
            PropriedadeAcessada("Vlredcomisssup");
            return _vlredcomisssup;
        }
        set
        {
            PropriedadeModificada("Vlredcomisssup", value);
            _vlredcomisssup = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlredpvendasimplesna
    {
        get
        {
            PropriedadeAcessada("Vlredpvendasimplesna");
            return _vlredpvendasimplesna;
        }
        set
        {
            PropriedadeModificada("Vlredpvendasimplesna", value);
            _vlredpvendasimplesna = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlrepasse
    {
        get
        {
            PropriedadeAcessada("Vlrepasse");
            return _vlrepasse;
        }
        set
        {
            PropriedadeModificada("Vlrepasse", value);
            _vlrepasse = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlrmoedaestrageira
    {
        get
        {
            PropriedadeAcessada("Vlrmoedaestrageira");
            return _vlrmoedaestrageira;
        }
        set
        {
            PropriedadeModificada("Vlrmoedaestrageira", value);
            _vlrmoedaestrageira = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 2)]
    public decimal? Vlsubtotitem
    {
        get
        {
            PropriedadeAcessada("Vlsubtotitem");
            return _vlsubtotitem;
        }
        set
        {
            PropriedadeModificada("Vlsubtotitem", value);
            _vlsubtotitem = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlverbacmv
    {
        get
        {
            PropriedadeAcessada("Vlverbacmv");
            return _vlverbacmv;
        }
        set
        {
            PropriedadeModificada("Vlverbacmv", value);
            _vlverbacmv = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlverbacmvcli
    {
        get
        {
            PropriedadeAcessada("Vlverbacmvcli");
            return _vlverbacmvcli;
        }
        set
        {
            PropriedadeModificada("Vlverbacmvcli", value);
            _vlverbacmvcli = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Volumedesejado
    {
        get
        {
            PropriedadeAcessada("Volumedesejado");
            return _volumedesejado;
        }
        set
        {
            PropriedadeModificada("Volumedesejado", value);
            _volumedesejado = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 7, Precisao = 0)]
    public string Codcest
    {
        get
        {
            PropriedadeAcessada("Codcest");
            return _codcest;
        }
        set
        {
            PropriedadeModificada("Codcest", value);
            _codcest = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 100, Precisao = 0)]
    public string Codbarrabalanca
    {
        get
        {
            PropriedadeAcessada("Codbarrabalanca");
            return _codbarrabalanca;
        }
        set
        {
            PropriedadeModificada("Codbarrabalanca", value);
            _codbarrabalanca = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Qtminatacvenda
    {
        get
        {
            PropriedadeAcessada("Qtminatacvenda");
            return _qtminatacvenda;
        }
        set
        {
            PropriedadeModificada("Qtminatacvenda", value);
            _qtminatacvenda = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Tipodescatacvenda
    {
        get
        {
            PropriedadeAcessada("Tipodescatacvenda");
            return _tipodescatacvenda;
        }
        set
        {
            PropriedadeModificada("Tipodescatacvenda", value);
            _tipodescatacvenda = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codoferta
    {
        get
        {
            PropriedadeAcessada("Codoferta");
            return _codoferta;
        }
        set
        {
            PropriedadeModificada("Codoferta", value);
            _codoferta = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 7, Precisao = 4)]
    public decimal? Pglp
    {
        get
        {
            PropriedadeAcessada("Pglp");
            return _pglp;
        }
        set
        {
            PropriedadeModificada("Pglp", value);
            _pglp = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 7, Precisao = 4)]
    public decimal? Pgni
    {
        get
        {
            PropriedadeAcessada("Pgni");
            return _pgni;
        }
        set
        {
            PropriedadeModificada("Pgni", value);
            _pgni = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 7, Precisao = 4)]
    public decimal? Pgnn
    {
        get
        {
            PropriedadeAcessada("Pgnn");
            return _pgnn;
        }
        set
        {
            PropriedadeModificada("Pgnn", value);
            _pgnn = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 23, Precisao = 10)]
    public decimal? Vpart
    {
        get
        {
            PropriedadeAcessada("Vpart");
            return _vpart;
        }
        set
        {
            PropriedadeModificada("Vpart", value);
            _vpart = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlbasefcpst
    {
        get
        {
            PropriedadeAcessada("Vlbasefcpst");
            return _vlbasefcpst;
        }
        set
        {
            PropriedadeModificada("Vlbasefcpst", value);
            _vlbasefcpst = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Aliqicmsfecp
    {
        get
        {
            PropriedadeAcessada("Aliqicmsfecp");
            return _aliqicmsfecp;
        }
        set
        {
            PropriedadeModificada("Aliqicmsfecp", value);
            _aliqicmsfecp = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlfecp
    {
        get
        {
            PropriedadeAcessada("Vlfecp");
            return _vlfecp;
        }
        set
        {
            PropriedadeModificada("Vlfecp", value);
            _vlfecp = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Utilizoumotorcalculo
    {
        get
        {
            PropriedadeAcessada("Utilizoumotorcalculo");
            return _utilizoumotorcalculo;
        }
        set
        {
            PropriedadeModificada("Utilizoumotorcalculo", value);
            _utilizoumotorcalculo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 50, Precisao = 0)]
    public string Cupomdesconto
    {
        get
        {
            PropriedadeAcessada("Cupomdesconto");
            return _cupomdesconto;
        }
        set
        {
            PropriedadeModificada("Cupomdesconto", value);
            _cupomdesconto = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 15, Precisao = 0)]
    public string Codcupomdesconto
    {
        get
        {
            PropriedadeAcessada("Codcupomdesconto");
            return _codcupomdesconto;
        }
        set
        {
            PropriedadeModificada("Codcupomdesconto", value);
            _codcupomdesconto = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 21, Precisao = 10)]
    public decimal? Qbcmonoret
    {
        get
        {
            PropriedadeAcessada(RO_QBCMONORET);
            return _qbcmonoret;
        }
        set
        {
            PropriedadeModificada(RO_QBCMONORET, value);
            _qbcmonoret = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 7, Precisao = 4)]
    public decimal? Adremicmsret
    {
        get
        {
            PropriedadeAcessada(RO_ADREMICMSRET);
            return _adremicmsret;
        }
        set
        {
            PropriedadeModificada(RO_ADREMICMSRET, value);
            _adremicmsret = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 23, Precisao = 10)]
    public decimal? Vicmsmonoret
    {
        get
        {
            PropriedadeAcessada(RO_VICMSMONORET);
            return _vicmsmonoret;
        }
        set
        {
            PropriedadeModificada(RO_VICMSMONORET, value);
            _vicmsmonoret = value;
        }
    }

    public void InicializarAtributos()
    {
    }

    public string ObterNomeTabela()
    {
        return "PCPEDI";
    }

    public IEntidade NovaInstancia()
    {
        return (IEntidade)GetType().GetConstructors()[0].Invoke(null);
    }

    public void CarregarPorDataReader(IDataReader leitor)
    {
        _abastecido = AlterarTipo<string>(leitor["Abastecido"]);
        _aliqfcp = AlterarTipo<decimal?>(leitor["Aliqfcp"]);
        _aliqicms1 = AlterarTipo<decimal?>(leitor["Aliqicms1"]);
        _aliqicms2 = AlterarTipo<decimal?>(leitor["Aliqicms2"]);
        _aliqinternadest = AlterarTipo<decimal?>(leitor["Aliqinternadest"]);
        _alternativo = AlterarTipo<string>(leitor["Alternativo"]);
        _ambiente = AlterarTipo<string>(leitor["Ambiente"]);
        _basedifaliquotas = AlterarTipo<decimal?>(leitor["Basedifaliquotas"]);
        _baseicst = AlterarTipo<decimal?>(leitor["Baseicst"]);
        _baseicst_ant_rateio = AlterarTipo<decimal?>(leitor["Baseicst_Ant_Rateio"]);
        _baseipiecf = AlterarTipo<decimal?>(leitor["Baseipiecf"]);
        _bonific = AlterarTipo<string>(leitor["Bonific"]);
        _brinde = AlterarTipo<string>(leitor["Brinde"]);
        _codauxiliar = AlterarTipo<decimal?>(leitor["Codauxiliar"]);
        _codbase = AlterarTipo<string>(leitor["Codbase"]);
        _codcertific = AlterarTipo<decimal?>(leitor["Codcertific"]);
        _codcli = AlterarTipo<decimal>(leitor["Codcli"]);
        _codcombo = AlterarTipo<decimal?>(leitor["Codcombo"]);
        _codcontrato = AlterarTipo<decimal?>(leitor["Codcontrato"]);
        _codcontrolevasilhame = AlterarTipo<decimal?>(leitor["Codcontrolevasilhame"]);
        _coddegustacao = AlterarTipo<decimal?>(leitor["Coddegustacao"]);
        _coddesconto = AlterarTipo<decimal?>(leitor["Coddesconto"]);
        _coddescontobaserca = AlterarTipo<decimal?>(leitor["Coddescontobaserca"]);
        _codecf = AlterarTipo<string>(leitor["Codecf"]);
        _codemitenteitempedido = AlterarTipo<decimal?>(leitor["Codemitenteitempedido"]);
        _codfilialretira = AlterarTipo<string>(leitor["Codfilialretira"]);
        _codformula = AlterarTipo<string>(leitor["Codformula"]);
        _codfuncajusteos = AlterarTipo<decimal?>(leitor["Codfuncajusteos"]);
        _codfuncalteracaoos = AlterarTipo<decimal?>(leitor["Codfuncalteracaoos"]);
        _codfuncaltlote = AlterarTipo<decimal?>(leitor["Codfuncaltlote"]);
        _codfuncconf = AlterarTipo<decimal?>(leitor["Codfuncconf"]);
        _codfuncconf2 = AlterarTipo<decimal?>(leitor["Codfuncconf2"]);
        _codfunclanc = AlterarTipo<decimal?>(leitor["Codfunclanc"]);
        _codfunclibos = AlterarTipo<decimal?>(leitor["Codfunclibos"]);
        _codfuncpend = AlterarTipo<decimal?>(leitor["Codfuncpend"]);
        _codfuncsep = AlterarTipo<decimal?>(leitor["Codfuncsep"]);
        _codfuncultalter = AlterarTipo<decimal?>(leitor["Codfuncultalter"]);
        _codicmtab = AlterarTipo<decimal?>(leitor["Codicmtab"]);
        _codigobrinde = AlterarTipo<decimal?>(leitor["Codigobrinde"]);
        _codindicemultiplicador = AlterarTipo<decimal?>(leitor["Codindicemultiplicador"]);
        _codlinhaprazo = AlterarTipo<decimal?>(leitor["Codlinhaprazo"]);
        _codmoedaestrageira = AlterarTipo<decimal?>(leitor["Codmoedaestrageira"]);
        _codmotnaocompra = AlterarTipo<decimal?>(leitor["Codmotnaocompra"]);
        _codplpag = AlterarTipo<decimal?>(leitor["Codplpag"]);
        _codprecofixo = AlterarTipo<decimal?>(leitor["Codprecofixo"]);
        _codprod = AlterarTipo<decimal>(leitor["Codprod"]);
        _codprodcesta = AlterarTipo<decimal?>(leitor["Codprodcesta"]);
        _codpromocao = AlterarTipo<string>(leitor["Codpromocao"]);
        _codst = AlterarTipo<decimal?>(leitor["Codst"]);
        _codusur = AlterarTipo<decimal>(leitor["Codusur"]);
        _codvasilhame = AlterarTipo<decimal?>(leitor["Codvasilhame"]);
        _codvasilhameecf = AlterarTipo<decimal?>(leitor["Codvasilhameecf"]);
        _complemento = AlterarTipo<string>(leitor["Complemento"]);
        _concedermaiorcomissreg = AlterarTipo<string>(leitor["Concedermaiorcomissreg"]);
        _condvenda = AlterarTipo<decimal?>(leitor["Condvenda"]);
        _corte = AlterarTipo<string>(leitor["Corte"]);
        _custofinest = AlterarTipo<decimal?>(leitor["Custofinest"]);
        _data = AlterarTipo<DateTime>(leitor["Data"]);
        _dataconf = AlterarTipo<DateTime?>(leitor["Dataconf"]);
        _dataconffim = AlterarTipo<DateTime?>(leitor["Dataconffim"]);
        _descprecofab = AlterarTipo<decimal?>(leitor["Descprecofab"]);
        _dtajusteos = AlterarTipo<DateTime?>(leitor["Dtajusteos"]);
        _dtalteracaoos = AlterarTipo<DateTime?>(leitor["Dtalteracaoos"]);
        _dtentrega = AlterarTipo<DateTime?>(leitor["Dtentrega"]);
        _dtexportacaoservint = AlterarTipo<DateTime?>(leitor["Dtexportacaoservint"]);
        _dtfimpromolote = AlterarTipo<DateTime?>(leitor["Dtfimpromolote"]);
        _dtfinalpend = AlterarTipo<DateTime?>(leitor["Dtfinalpend"]);
        _dtfinalsep = AlterarTipo<DateTime?>(leitor["Dtfinalsep"]);
        _dtgeracaoos = AlterarTipo<DateTime?>(leitor["Dtgeracaoos"]);
        _dtimportacaoservprinc = AlterarTipo<DateTime?>(leitor["Dtimportacaoservprinc"]);
        _dtinicialpend = AlterarTipo<DateTime?>(leitor["Dtinicialpend"]);
        _dtinicialsep = AlterarTipo<DateTime?>(leitor["Dtinicialsep"]);
        _dtiniciopromolote = AlterarTipo<DateTime?>(leitor["Dtiniciopromolote"]);
        _dtlanc = AlterarTipo<DateTime?>(leitor["Dtlanc"]);
        _dtlibos = AlterarTipo<DateTime?>(leitor["Dtlibos"]);
        _dtultlalter = AlterarTipo<DateTime?>(leitor["Dtultlalter"]);
        _eancodprod = AlterarTipo<decimal?>(leitor["Eancodprod"]);
        _exportadoservint = AlterarTipo<string>(leitor["Exportadoservint"]);
        _formanegociacao = AlterarTipo<string>(leitor["Formanegociacao"]);
        _geragnre_cnpjcliente = AlterarTipo<string>(leitor["Geragnre_Cnpjcliente"]);
        _grpregrabrinde = AlterarTipo<decimal?>(leitor["Grpregrabrinde"]);
        _grupofaturamento = AlterarTipo<string>(leitor["Grupofaturamento"]);
        _idpatrimonio = AlterarTipo<string>(leitor["Idpatrimonio"]);
        _idvenda = AlterarTipo<decimal?>(leitor["Idvenda"]);
        _importadoservprinc = AlterarTipo<string>(leitor["Importadoservprinc"]);
        _imprime = AlterarTipo<string>(leitor["Imprime"]);
        _iva = AlterarTipo<decimal?>(leitor["Iva"]);
        _letracomiss = AlterarTipo<string>(leitor["Letracomiss"]);
        _localizacao = AlterarTipo<string>(leitor["Localizacao"]);
        _localizacaoos = AlterarTipo<string>(leitor["Localizacaoos"]);
        _movimentacontacorrenterca = AlterarTipo<string>(leitor["Movimentacontacorrenterca"]);
        _negociacaoposterior = AlterarTipo<string>(leitor["Negociacaoposterior"]);
        _nomeconcorrente = AlterarTipo<string>(leitor["Nomeconcorrente"]);
        _numaplic = AlterarTipo<decimal?>(leitor["Numaplic"]);
        _numcaixa = AlterarTipo<string>(leitor["Numcaixa"]);
        _numcar = AlterarTipo<decimal?>(leitor["Numcar"]);
        _numcaraux = AlterarTipo<decimal?>(leitor["Numcaraux"]);
        _numconferencia = AlterarTipo<decimal?>(leitor["Numconferencia"]);
        _numerorecopi = AlterarTipo<string>(leitor["Numerorecopi"]);
        _numetiqueta = AlterarTipo<decimal?>(leitor["Numetiqueta"]);
        _numitemped = AlterarTipo<decimal?>(leitor["Numitemped"]);
        _numlista = AlterarTipo<decimal?>(leitor["Numlista"]);
        _numlote = AlterarTipo<string>(leitor["Numlote"]);
        _numop = AlterarTipo<decimal?>(leitor["Numop"]);
        _numos = AlterarTipo<decimal?>(leitor["Numos"]);
        _numosorigem = AlterarTipo<decimal?>(leitor["Numosorigem"]);
        _numped = AlterarTipo<decimal>(leitor["Numped"]);
        _numrecopi = AlterarTipo<decimal?>(leitor["Numrecopi"]);
        _numseq = AlterarTipo<decimal>(leitor["Numseq"]);
        _numseqcestabasica = AlterarTipo<decimal?>(leitor["Numseqcestabasica"]);
        _numseqitemcontrato = AlterarTipo<decimal?>(leitor["Numseqitemcontrato"]);
        _numseriesat = AlterarTipo<string>(leitor["Numseriesat"]);
        _numtira = AlterarTipo<decimal?>(leitor["Numtira"]);
        _numtranswms = AlterarTipo<decimal?>(leitor["Numtranswms"]);
        _numverbarebcmv = AlterarTipo<decimal?>(leitor["Numverbarebcmv"]);
        _numviasos = AlterarTipo<decimal?>(leitor["Numviasos"]);
        _numvolumesconferencia = AlterarTipo<decimal?>(leitor["Numvolumesconferencia"]);
        _origemdepreco = AlterarTipo<string>(leitor["Origemdepreco"]);
        _origemst = AlterarTipo<string>(leitor["Origemst"]);
        _participagiro = AlterarTipo<string>(leitor["Participagiro"]);
        _pauta = AlterarTipo<decimal?>(leitor["Pauta"]);
        _pbaserca = AlterarTipo<decimal?>(leitor["Pbaserca"]);
        _pbonific = AlterarTipo<decimal?>(leitor["Pbonific"]);
        _perbonific = AlterarTipo<decimal?>(leitor["Perbonific"]);
        _percagregadorst = AlterarTipo<decimal?>(leitor["Percagregadorst"]);
        _percbasered = AlterarTipo<decimal?>(leitor["Percbasered"]);
        _percbaseredpart = AlterarTipo<decimal?>(leitor["Percbaseredpart"]);
        _percbaseredst = AlterarTipo<decimal?>(leitor["Percbaseredst"]);
        _percbaseredstfonte = AlterarTipo<decimal?>(leitor["Percbaseredstfonte"]);
        _percdescabatimento = AlterarTipo<decimal?>(leitor["Percdescabatimento"]);
        _percdesccofins = AlterarTipo<decimal?>(leitor["Percdesccofins"]);
        _percdescindustria = AlterarTipo<decimal?>(leitor["Percdescindustria"]);
        _percdescpis = AlterarTipo<decimal?>(leitor["Percdescpis"]);
        _percdifaliquotas = AlterarTipo<decimal?>(leitor["Percdifaliquotas"]);
        _percicm = AlterarTipo<decimal?>(leitor["Percicm"]);
        _percipi = AlterarTipo<decimal?>(leitor["Percipi"]);
        _percipiecf = AlterarTipo<decimal?>(leitor["Percipiecf"]);
        _percipioutras = AlterarTipo<decimal?>(leitor["Percipioutras"]);
        _perciss = AlterarTipo<decimal?>(leitor["Perciss"]);
        _percom = AlterarTipo<decimal>(leitor["Percom"]);
        _percom2 = AlterarTipo<decimal?>(leitor["Percom2"]);
        _percom3 = AlterarTipo<decimal?>(leitor["Percom3"]);
        _percom4 = AlterarTipo<decimal?>(leitor["Percom4"]);
        _percomprof = AlterarTipo<decimal?>(leitor["Percomprof"]);
        _percomsup = AlterarTipo<decimal?>(leitor["Percomsup"]);
        _percomtab = AlterarTipo<decimal?>(leitor["Percomtab"]);
        _percprovpart = AlterarTipo<decimal?>(leitor["Percprovpart"]);
        _percredaliqipi = AlterarTipo<decimal?>(leitor["Percredaliqipi"]);
        _perctributos = AlterarTipo<decimal?>(leitor["Perctributos"]);
        _percvenda = AlterarTipo<decimal?>(leitor["Percvenda"]);
        _perdesc = AlterarTipo<decimal>(leitor["Perdesc"]);
        _perdescavista = AlterarTipo<decimal?>(leitor["Perdescavista"]);
        _perdescboleto = AlterarTipo<decimal?>(leitor["Perdescboleto"]);
        _perdesccom = AlterarTipo<decimal?>(leitor["Perdesccom"]);
        _perdesccusto = AlterarTipo<decimal?>(leitor["Perdesccusto"]);
        _perdescfimcomiss = AlterarTipo<decimal?>(leitor["Perdescfimcomiss"]);
        _perdescfin = AlterarTipo<decimal?>(leitor["Perdescfin"]);
        _perdescflex = AlterarTipo<decimal?>(leitor["Perdescflex"]);
        _perdescfob = AlterarTipo<decimal?>(leitor["Perdescfob"]);
        _perdescinicomiss = AlterarTipo<decimal?>(leitor["Perdescinicomiss"]);
        _perdescisentoicms = AlterarTipo<decimal?>(leitor["Perdescisentoicms"]);
        _perdescnegociado = AlterarTipo<decimal?>(leitor["Perdescnegociado"]);
        _perdescpauta = AlterarTipo<decimal?>(leitor["Perdescpauta"]);
        _perdescpolitica = AlterarTipo<decimal?>(leitor["Perdescpolitica"]);
        _perdesctab = AlterarTipo<decimal?>(leitor["Perdesctab"]);
        _perfretecmv = AlterarTipo<decimal?>(leitor["Perfretecmv"]);
        _perredcomiss = AlterarTipo<decimal?>(leitor["Perredcomiss"]);
        _perredcomisssup = AlterarTipo<decimal?>(leitor["Perredcomisssup"]);
        _pesobruto = AlterarTipo<decimal?>(leitor["Pesobruto"]);
        _politicaprioritaria = AlterarTipo<string>(leitor["Politicaprioritaria"]);
        _poriginal = AlterarTipo<decimal?>(leitor["Poriginal"]);
        _posicao = AlterarTipo<string>(leitor["Posicao"]);
        _prazo = AlterarTipo<string>(leitor["Prazo"]);
        _prazomedio = AlterarTipo<decimal?>(leitor["Prazomedio"]);
        _preco = AlterarTipo<decimal?>(leitor["Preco"]);
        _precofvbruto = AlterarTipo<decimal?>(leitor["Precofvbruto"]);
        _precomaxconsum = AlterarTipo<decimal?>(leitor["Precomaxconsum"]);
        _proddescricaocontrato = AlterarTipo<string>(leitor["Proddescricaocontrato"]);
        _proddescricaodanfe = AlterarTipo<string>(leitor["Proddescricaodanfe"]);
        _ptabela = AlterarTipo<decimal>(leitor["Ptabela"]);
        _ptabelaautpecas = AlterarTipo<decimal?>(leitor["Ptabelaautpecas"]);
        _pvenda = AlterarTipo<decimal>(leitor["Pvenda"]);
        _pvenda1 = AlterarTipo<decimal?>(leitor["Pvenda1"]);
        _pvendaanterior = AlterarTipo<decimal?>(leitor["Pvendaanterior"]);
        _pvendabase = AlterarTipo<decimal?>(leitor["Pvendabase"]);
        _pvendaemb = AlterarTipo<decimal?>(leitor["Pvendaemb"]);
        _pvendaembalagem = AlterarTipo<decimal?>(leitor["Pvendaembalagem"]);
        _pvendaliq = AlterarTipo<decimal?>(leitor["Pvendaliq"]);
        _pvendavasilhame = AlterarTipo<decimal?>(leitor["Pvendavasilhame"]);
        _qt = AlterarTipo<decimal>(leitor["Qt"]);
        _qtapanha = AlterarTipo<decimal?>(leitor["Qtapanha"]);
        _qtcx = AlterarTipo<decimal?>(leitor["Qtcx"]);
        _qtdiasentregaitem = AlterarTipo<decimal?>(leitor["Qtdiasentregaitem"]);
        _qtembalagem = AlterarTipo<decimal?>(leitor["Qtembalagem"]);
        _qtfalta = AlterarTipo<decimal?>(leitor["Qtfalta"]);
        _qtimediata = AlterarTipo<decimal?>(leitor["Qtimediata"]);
        _qtlitragem = AlterarTipo<decimal?>(leitor["Qtlitragem"]);
        _qtlocalizada = AlterarTipo<decimal?>(leitor["Qtlocalizada"]);
        _qtnaocompra = AlterarTipo<decimal?>(leitor["Qtnaocompra"]);
        _qtorig = AlterarTipo<decimal?>(leitor["Qtorig"]);
        _qtoriginal = AlterarTipo<decimal?>(leitor["Qtoriginal"]);
        _qtpecas = AlterarTipo<decimal?>(leitor["Qtpecas"]);
        _qtpendos = AlterarTipo<decimal?>(leitor["Qtpendos"]);
        _qtreservant = AlterarTipo<decimal?>(leitor["Qtreservant"]);
        _qtsaidavasilhame = AlterarTipo<decimal?>(leitor["Qtsaidavasilhame"]);
        _qtseparada = AlterarTipo<decimal?>(leitor["Qtseparada"]);
        _qtsepararcx = AlterarTipo<decimal?>(leitor["Qtsepararcx"]);
        _qtsepararun = AlterarTipo<decimal?>(leitor["Qtsepararun"]);
        _qtun = AlterarTipo<decimal?>(leitor["Qtun"]);
        _qtunitcx = AlterarTipo<decimal?>(leitor["Qtunitcx"]);
        _qtunitemb = AlterarTipo<decimal?>(leitor["Qtunitemb"]);
        _qtvendaemb = AlterarTipo<decimal?>(leitor["Qtvendaemb"]);
        _qtvendidavasilhame = AlterarTipo<decimal?>(leitor["Qtvendidavasilhame"]);
        _qt_separadamanif = AlterarTipo<decimal?>(leitor["Qt_Separadamanif"]);
        _refcor = AlterarTipo<string>(leitor["Refcor"]);
        _rotina = AlterarTipo<string>(leitor["Rotina"]);
        _rotinalanc = AlterarTipo<decimal?>(leitor["Rotinalanc"]);
        _rotinalancbrinde = AlterarTipo<decimal?>(leitor["Rotinalancbrinde"]);
        _rotinalancultalt = AlterarTipo<string>(leitor["Rotinalancultalt"]);
        _rotinaultlalter = AlterarTipo<decimal?>(leitor["Rotinaultlalter"]);
        _rp_imediata = AlterarTipo<string>(leitor["Rp_Imediata"]);
        _siglaqualidade = AlterarTipo<string>(leitor["Siglaqualidade"]);
        _situacaoos = AlterarTipo<decimal?>(leitor["Situacaoos"]);
        _st = AlterarTipo<decimal>(leitor["St"]);
        _statussucata = AlterarTipo<decimal?>(leitor["Statussucata"]);
        _stclientegnre = AlterarTipo<decimal?>(leitor["Stclientegnre"]);
        _stpbaserca = AlterarTipo<decimal?>(leitor["Stpbaserca"]);
        _stptabela = AlterarTipo<decimal?>(leitor["Stptabela"]);
        _st_ant_rateio = AlterarTipo<decimal?>(leitor["St_Ant_Rateio"]);
        _st_dif_rateio = AlterarTipo<decimal?>(leitor["St_Dif_Rateio"]);
        _sugestao = AlterarTipo<string>(leitor["Sugestao"]);
        _taxacasomoedareal = AlterarTipo<decimal?>(leitor["Taxacasomoedareal"]);
        _tipocalculost = AlterarTipo<string>(leitor["Tipocalculost"]);
        _tipodescaplicado = AlterarTipo<string>(leitor["Tipodescaplicado"]);
        _tipoentrega = AlterarTipo<string>(leitor["Tipoentrega"]);
        _tipopeso = AlterarTipo<string>(leitor["Tipopeso"]);
        _tiposeparacao = AlterarTipo<string>(leitor["Tiposeparacao"]);
        _totalizadoraliquota = AlterarTipo<string>(leitor["Totalizadoraliquota"]);
        _truncaritem = AlterarTipo<string>(leitor["Truncaritem"]);
        _tvbonif = AlterarTipo<decimal?>(leitor["Tvbonif"]);
        _txvenda = AlterarTipo<decimal?>(leitor["Txvenda"]);
        _unidade = AlterarTipo<string>(leitor["Unidade"]);
        _usadebcredrcabrind = AlterarTipo<string>(leitor["Usadebcredrcabrind"]);
        _usaunidademaster = AlterarTipo<string>(leitor["Usaunidademaster"]);
        _vendapbm = AlterarTipo<string>(leitor["Vendapbm"]);
        _vlacrescrodape = AlterarTipo<decimal?>(leitor["Vlacrescrodape"]);
        _vlacrescvasilhame = AlterarTipo<decimal?>(leitor["Vlacrescvasilhame"]);
        _vlacresfretekg = AlterarTipo<decimal?>(leitor["Vlacresfretekg"]);
        _vlbasepartdest = AlterarTipo<decimal?>(leitor["Vlbasepartdest"]);
        _vlbonific = AlterarTipo<decimal?>(leitor["Vlbonific"]);
        _vlcustocont = AlterarTipo<decimal?>(leitor["Vlcustocont"]);
        _vlcustofin = AlterarTipo<decimal>(leitor["Vlcustofin"]);
        _vlcustoreal = AlterarTipo<decimal>(leitor["Vlcustoreal"]);
        _vlcustorep = AlterarTipo<decimal?>(leitor["Vlcustorep"]);
        _vldescabatimento = AlterarTipo<decimal?>(leitor["Vldescabatimento"]);
        _vldescboleto = AlterarTipo<decimal?>(leitor["Vldescboleto"]);
        _vldesccom = AlterarTipo<decimal?>(leitor["Vldesccom"]);
        _vldesccustocmv = AlterarTipo<decimal?>(leitor["Vldesccustocmv"]);
        _vldescfin = AlterarTipo<decimal?>(leitor["Vldescfin"]);
        _vldescflex = AlterarTipo<decimal?>(leitor["Vldescflex"]);
        _vldescfornec = AlterarTipo<decimal?>(leitor["Vldescfornec"]);
        _vldescicmisencao = AlterarTipo<decimal?>(leitor["Vldescicmisencao"]);
        _vldescpissuframa = AlterarTipo<decimal?>(leitor["Vldescpissuframa"]);
        _vldescreducaocofins = AlterarTipo<decimal?>(leitor["Vldescreducaocofins"]);
        _vldescreducaopis = AlterarTipo<decimal?>(leitor["Vldescreducaopis"]);
        _vldescrepasse = AlterarTipo<decimal?>(leitor["Vldescrepasse"]);
        _vldescrodape = AlterarTipo<decimal?>(leitor["Vldescrodape"]);
        _vldescsociotorcedor = AlterarTipo<decimal?>(leitor["Vldescsociotorcedor"]);
        _vldescsuframa = AlterarTipo<decimal?>(leitor["Vldescsuframa"]);
        _vldifaliquotas = AlterarTipo<decimal?>(leitor["Vldifaliquotas"]);
        _vlfcppart = AlterarTipo<decimal?>(leitor["Vlfcppart"]);
        _vlfrete = AlterarTipo<decimal?>(leitor["Vlfrete"]);
        _vlfrete_rateio = AlterarTipo<decimal?>(leitor["Vlfrete_Rateio"]);
        _vlicmsdifaliqpart = AlterarTipo<decimal?>(leitor["Vlicmsdifaliqpart"]);
        _vlicmspart = AlterarTipo<decimal?>(leitor["Vlicmspart"]);
        _vlicmspartdest = AlterarTipo<decimal?>(leitor["Vlicmspartdest"]);
        _vlicmspartrem = AlterarTipo<decimal?>(leitor["Vlicmspartrem"]);
        _vlipi = AlterarTipo<decimal?>(leitor["Vlipi"]);
        _vlipiecf = AlterarTipo<decimal?>(leitor["Vlipiecf"]);
        _vlipioutras = AlterarTipo<decimal?>(leitor["Vlipioutras"]);
        _vliss = AlterarTipo<decimal?>(leitor["Vliss"]);
        _vlitemtributos = AlterarTipo<decimal?>(leitor["Vlitemtributos"]);
        _vloutrasdesp = AlterarTipo<decimal?>(leitor["Vloutrasdesp"]);
        _vloutras_rateio = AlterarTipo<decimal?>(leitor["Vloutras_Rateio"]);
        _vloutros = AlterarTipo<decimal?>(leitor["Vloutros"]);
        _vlrebaixacmv = AlterarTipo<decimal?>(leitor["Vlrebaixacmv"]);
        _vlredcmvsimplesnac = AlterarTipo<decimal?>(leitor["Vlredcmvsimplesnac"]);
        _vlredcomiss = AlterarTipo<decimal?>(leitor["Vlredcomiss"]);
        _vlredcomisssup = AlterarTipo<decimal?>(leitor["Vlredcomisssup"]);
        _vlredpvendasimplesna = AlterarTipo<decimal?>(leitor["Vlredpvendasimplesna"]);
        _vlrepasse = AlterarTipo<decimal?>(leitor["Vlrepasse"]);
        _vlrmoedaestrageira = AlterarTipo<decimal?>(leitor["Vlrmoedaestrageira"]);
        _vlsubtotitem = AlterarTipo<decimal?>(leitor["Vlsubtotitem"]);
        _vlverbacmv = AlterarTipo<decimal?>(leitor["Vlverbacmv"]);
        _vlverbacmvcli = AlterarTipo<decimal?>(leitor["Vlverbacmvcli"]);
        _volumedesejado = AlterarTipo<decimal?>(leitor["Volumedesejado"]);
        _codbarrabalanca = AlterarTipo<string>(leitor["Codbarrabalanca"]);
        _qtminatacvenda = AlterarTipo<decimal?>(leitor["Qtminatacvenda"]);
        _tipodescatacvenda = AlterarTipo<string>(leitor["Tipodescatacvenda"]);
        _codoferta = AlterarTipo<decimal?>(leitor["Codoferta"]);
        _pglp = AlterarTipo<decimal?>(leitor["Pglp"]);
        _pgni = AlterarTipo<decimal?>(leitor["Pgni"]);
        _pgnn = AlterarTipo<decimal?>(leitor["Pgnn"]);
        _vpart = AlterarTipo<decimal?>(leitor["Vpart"]);
        _vlbasefcpst = AlterarTipo<decimal?>(leitor["Vlbasefcpst"]);
        _aliqicmsfecp = AlterarTipo<decimal?>(leitor["Aliqicmsfecp"]);
        _vlfecp = AlterarTipo<decimal?>(leitor["Vlfecp"]);
        _utilizoumotorcalculo = AlterarTipo<string>(leitor["Utilizoumotorcalculo"]);
        _cupomdesconto = AlterarTipo<string>(leitor["Cupomdesconto"]);
        _codcupomdesconto = AlterarTipo<string>(leitor["Codcupomdesconto"]);
        Qbcmonoret = AlterarTipo<decimal?>(leitor[RO_QBCMONORET]);
        Adremicmsret = AlterarTipo<decimal?>(leitor[RO_ADREMICMSRET]);
        Vicmsmonoret = AlterarTipo<decimal?>(leitor[RO_VICMSMONORET]);
    }

}