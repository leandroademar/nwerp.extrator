

////// namespace nwErp.Entidades.Caixa;

// namespace nwErp.Api.Modelos;

[Serializable]
public class PCPEDIECF : GerenteDePropriedades, IEntidade
{
    private decimal? _aliqfcp;

    private decimal? _aliqicms1;

    private decimal? _aliqicms2;

    private decimal? _aliqinternadest;

    private decimal? _aliqinterorigpart;

    private decimal? _aliqreducaocofins;

    private decimal? _aliqreducaopis;

    private string _assinatura;

    private decimal? _basedifaliquotas;

    private decimal? _baseicms;

    private decimal? _baseicst;

    private decimal? _baseipiecf;

    private decimal? _bciss;

    private string _brinde;

    private decimal? _codauxiliar;

    private decimal? _codcampanha;

    private decimal _codcli;

    private decimal? _codcontrolevasilhame;

    private string _codecf;

    private string _codfilial;

    private string _codfilialretira;

    private decimal? _codfiscal;

    private decimal _codfunccx;

    private decimal? _codicmtab;

    private decimal? _codigobrinde;

    private decimal _codprod;

    private decimal? _codsittribpiscofins;

    private decimal? _codst;

    private decimal? _codtribpiscofins;

    private decimal _codusur;

    private decimal? _codvasilhameecf;

    private decimal? _custofinest;

    private DateTime _data;

    private DateTime? _dtexportacao;

    private string _enviaraliqreducaopiscofins;

    private string _exportado;

    private string _idcancel;

    private string _importado;

    private decimal? _iva;

    private string _logerro;

    private decimal _numcaixa;

    private decimal? _numcaixafiscal;

    private decimal? _numcar;

    private decimal? _numccf;

    private decimal? _numcoo;

    private decimal? _numlista;

    private string _numlote;

    private decimal? _numped;

    private decimal _numpedecf;

    private decimal? _numreposicao;

    private decimal _numseq;

    private decimal? _numseqorig;

    private string _numserie;

    private string _numserieequip;

    private string _numseriesat;

    private string _origmerctrib;

    private decimal? _pauta;

    private decimal? _pbaserca;

    private decimal? _peracrescimocusto;

    private decimal? _percabaseredpart;

    private decimal? _percbasered;

    private decimal? _percbaseredpart;

    private decimal? _percbaseredst;

    private decimal? _percbaseredstfonte;

    private decimal? _percdesccofins;

    private decimal? _percdescpis;

    private decimal? _percdifaliquotas;

    private decimal? _percicm;

    private decimal? _percicmssimplesnac;

    private decimal? _percipi;

    private decimal? _percipiecf;

    private decimal? _perciss;

    private decimal? _percofins;

    private decimal? _percom;

    private decimal? _percprovpart;

    private decimal? _perctributos;

    private decimal _perdesc;

    private decimal? _perdifereimentoicms;

    private decimal? _perdiferimentoicms;

    private decimal? _perfretecmv;

    private decimal? _perpis;

    private string _piscofinsdeduzido;

    private decimal? _poriginal;

    private string _posicao;

    private string _posicaoretorno;

    private string _possuicomplemento;

    private decimal _ptabela;

    private decimal _pvenda;

    private decimal? _pvendavasilhame;

    private decimal _qt;

    private decimal? _qtfalta;

    private decimal? _qtlitragem;

    private decimal? _qtsaidavasilhame;

    private decimal? _qtunitemb;

    private decimal? _qtvendidavasilhame;

    private decimal? _rotinalanc;

    private string _sittribut;

    private decimal _st;

    private string _tipoentrega;

    private string _tipomerc;

    private string _totalizador;

    private string _truncaritem;

    private decimal? _txvenda;

    private string _usapiscofinslit;

    private string _vendapbm;

    private decimal? _vlacrescrodape;

    private decimal? _vldescfin;

    private decimal? _vloutrasdesp;

    private decimal? _vlacrescvasilhame;

    private decimal? _vlbaseipi;

    private decimal? _vlbasepart;

    private decimal? _vlbasepartdest;

    private decimal? _vlbasepiscofins;

    private decimal? _vlcofins;

    private decimal? _vlcredcofins;

    private decimal? _vlcredpis;

    private decimal? _vlcustocont;

    private decimal? _vlcustofin;

    private decimal? _vlcustoreal;

    private decimal? _vlcustorep;

    private decimal? _vldescorgaopub;

    private decimal? _vldescreducaocofins;

    private decimal? _vldescreducaopis;

    private decimal? _vldescrodape;

    private decimal? _vldescsociotorcedor;

    private decimal? _vldifaliquotas;

    private decimal? _vlfcppart;

    private decimal? _vlicmsdifaliqpart;

    private decimal? _vlicmspart;

    private decimal? _vlicmspartdest;

    private decimal? _vlicmspartrem;

    private decimal? _vlipi;

    private decimal? _vlipiecf;

    private decimal? _vliss;

    private decimal? _vlitemtributos;

    private decimal? _vlitemtributosestadual;

    private decimal? _vlpis;

    private decimal? _vlricmssimplesnac;

    private string _codcest;

    private decimal? _vlsubtotitem;

    private decimal? _perdesccusto;

    private string _versaoservicopartilha;

    private string _codbarrabalanca;

    private string _descricaopaf;

    private decimal? _qtminatacvenda;

    private string _tipodescatacvenda;

    private decimal? _codoferta;

    private decimal? _peracrescimofuncep;

    private decimal? _vlbasefcpicms;

    private decimal? _vlacrescimofuncep;

    private decimal? _aliqicmsfecp;

    private decimal? _vlbasefcpst;

    private decimal? _vlbcfcpstret;

    private decimal? _perfcpstret;

    private decimal? _vlfcpstret;

    private string _codbeneficiofiscal;

    private decimal? _vlfecp;

    private string _md5paf;

    private decimal? _codagregacao;

    private string _cnpjfabricante;

    private string _fabricante;

    private string _indescalarelevante;

    private decimal? _perfcpsn;

    private decimal? _vlcredfcpicmssn;

    private decimal? _anp;

    private string _descanp;

    private decimal? _pglp;

    private decimal? _pgni;

    private decimal? _pgnn;

    private decimal? _vpart;

    private decimal? _vldescicmisencao;

    private decimal? _perdescisentoicms;

    private string _codmotivoicmsdesonerado;

    private decimal? _vlicmsdesoneracao;

    private decimal? _vlfrete;

    private static readonly string RO_CUSTOULTENT = "Custoultent";

    private decimal? _custoultent;

    private decimal? _valorultent;

    private string _utilizoumotorcalculo;

    private decimal? _percredbaseefet;

    private decimal? _vlbaseefet;

    private decimal? _percicmsefet;

    private decimal? _vlicmsefet;

    private string _cupomdesconto;

    private string _codcupomdesconto;

    private decimal? _vldescontomotoroferta;

    private static readonly string RO_BASEBCR = "Basebcr";

    private decimal? _basebcr;

    private static readonly string RO_STBCR = "Stbcr";

    private decimal? _stbcr;

    private static readonly string RO_BASEICMSBCR = "Baseicmsbcr";

    private decimal? _baseicmsbcr;

    private static readonly string RO_VLICMSBCR = "Vlicmsbcr";

    private decimal? _vlicmsbcr;

    private static readonly string RO_ORIGEMITEM = "Origemitem";

    private string _origemitem;

    private static readonly string RO_CODFORNEC = "Codfornec";

    private decimal? _codfornec;

    private static readonly string RO_VLDESCSUFRAMA = "Vldescsuframa";

    private decimal? _vldescsuframa;

    private static readonly string RO_VLDESCITEM = "Vldescitem";

    private decimal? _vldescitem;

    private static readonly string RO_EXCLUIRICMSBASEPISCOFINS = "Excluiricmsbasepiscofins";

    private string _excluiricmsbasepiscofins;

    private static readonly string RO_QBCMONORET = "Qbcmonoret";

    private decimal? _qbcmonoret;

    private static readonly string RO_ADREMICMSRET = "Adremicmsret";

    private decimal? _adremicmsret;

    private static readonly string RO_VICMSMONORET = "Vicmsmonoret";

    private decimal? _vicmsmonoret;

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Aliqinterorigpart
    {
        get
        {
            PropriedadeAcessada("Aliqinterorigpart");
            return _aliqinterorigpart;
        }
        set
        {
            PropriedadeModificada("Aliqinterorigpart", value);
            _aliqinterorigpart = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Aliqreducaocofins
    {
        get
        {
            PropriedadeAcessada("Aliqreducaocofins");
            return _aliqreducaocofins;
        }
        set
        {
            PropriedadeModificada("Aliqreducaocofins", value);
            _aliqreducaocofins = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Aliqreducaopis
    {
        get
        {
            PropriedadeAcessada("Aliqreducaopis");
            return _aliqreducaopis;
        }
        set
        {
            PropriedadeModificada("Aliqreducaopis", value);
            _aliqreducaopis = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 255, Precisao = 0)]
    public string Assinatura
    {
        get
        {
            PropriedadeAcessada("Assinatura");
            return _assinatura;
        }
        set
        {
            PropriedadeModificada("Assinatura", value);
            _assinatura = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 24, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Baseicms
    {
        get
        {
            PropriedadeAcessada("Baseicms");
            return _baseicms;
        }
        set
        {
            PropriedadeModificada("Baseicms", value);
            _baseicms = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Bciss
    {
        get
        {
            PropriedadeAcessada("Bciss");
            return _bciss;
        }
        set
        {
            PropriedadeModificada("Bciss", value);
            _bciss = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 16, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codcampanha
    {
        get
        {
            PropriedadeAcessada("Codcampanha");
            return _codcampanha;
        }
        set
        {
            PropriedadeModificada("Codcampanha", value);
            _codcampanha = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfiscal
    {
        get
        {
            PropriedadeAcessada("Codfiscal");
            return _codfiscal;
        }
        set
        {
            PropriedadeModificada("Codfiscal", value);
            _codfiscal = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal Codfunccx
    {
        get
        {
            PropriedadeAcessada("Codfunccx");
            return _codfunccx;
        }
        set
        {
            PropriedadeModificada("Codfunccx", value);
            _codfunccx = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 3, Precisao = 0)]
    public decimal? Codsittribpiscofins
    {
        get
        {
            PropriedadeAcessada("Codsittribpiscofins");
            return _codsittribpiscofins;
        }
        set
        {
            PropriedadeModificada("Codsittribpiscofins", value);
            _codsittribpiscofins = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Codtribpiscofins
    {
        get
        {
            PropriedadeAcessada("Codtribpiscofins");
            return _codtribpiscofins;
        }
        set
        {
            PropriedadeModificada("Codtribpiscofins", value);
            _codtribpiscofins = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtexportacao
    {
        get
        {
            PropriedadeAcessada("Dtexportacao");
            return _dtexportacao;
        }
        set
        {
            PropriedadeModificada("Dtexportacao", value);
            _dtexportacao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Enviaraliqreducaopiscofins
    {
        get
        {
            PropriedadeAcessada("Enviaraliqreducaopiscofins");
            return _enviaraliqreducaopiscofins;
        }
        set
        {
            PropriedadeModificada("Enviaraliqreducaopiscofins", value);
            _enviaraliqreducaopiscofins = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Exportado
    {
        get
        {
            PropriedadeAcessada("Exportado");
            return _exportado;
        }
        set
        {
            PropriedadeModificada("Exportado", value);
            _exportado = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Idcancel
    {
        get
        {
            PropriedadeAcessada("Idcancel");
            return _idcancel;
        }
        set
        {
            PropriedadeModificada("Idcancel", value);
            _idcancel = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Importado
    {
        get
        {
            PropriedadeAcessada("Importado");
            return _importado;
        }
        set
        {
            PropriedadeModificada("Importado", value);
            _importado = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2000, Precisao = 0)]
    public string Logerro
    {
        get
        {
            PropriedadeAcessada("Logerro");
            return _logerro;
        }
        set
        {
            PropriedadeModificada("Logerro", value);
            _logerro = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal Numcaixa
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Numcaixafiscal
    {
        get
        {
            PropriedadeAcessada("Numcaixafiscal");
            return _numcaixafiscal;
        }
        set
        {
            PropriedadeModificada("Numcaixafiscal", value);
            _numcaixafiscal = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Numccf
    {
        get
        {
            PropriedadeAcessada("Numccf");
            return _numccf;
        }
        set
        {
            PropriedadeModificada("Numccf", value);
            _numccf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Numcoo
    {
        get
        {
            PropriedadeAcessada("Numcoo");
            return _numcoo;
        }
        set
        {
            PropriedadeModificada("Numcoo", value);
            _numcoo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 15, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal Numpedecf
    {
        get
        {
            PropriedadeAcessada("Numpedecf");
            return _numpedecf;
        }
        set
        {
            PropriedadeModificada("Numpedecf", value);
            _numpedecf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numreposicao
    {
        get
        {
            PropriedadeAcessada("Numreposicao");
            return _numreposicao;
        }
        set
        {
            PropriedadeModificada("Numreposicao", value);
            _numreposicao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 20, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 20, Precisao = 0)]
    public decimal? Numseqorig
    {
        get
        {
            PropriedadeAcessada("Numseqorig");
            return _numseqorig;
        }
        set
        {
            PropriedadeModificada("Numseqorig", value);
            _numseqorig = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 30, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 30, Precisao = 0)]
    public string Numserieequip
    {
        get
        {
            PropriedadeAcessada("Numserieequip");
            return _numserieequip;
        }
        set
        {
            PropriedadeModificada("Numserieequip", value);
            _numserieequip = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 13, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Origmerctrib
    {
        get
        {
            PropriedadeAcessada("Origmerctrib");
            return _origmerctrib;
        }
        set
        {
            PropriedadeModificada("Origmerctrib", value);
            _origmerctrib = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Peracrescimocusto
    {
        get
        {
            PropriedadeAcessada("Peracrescimocusto");
            return _peracrescimocusto;
        }
        set
        {
            PropriedadeModificada("Peracrescimocusto", value);
            _peracrescimocusto = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 2)]
    public decimal? Percabaseredpart
    {
        get
        {
            PropriedadeAcessada("Percabaseredpart");
            return _percabaseredpart;
        }
        set
        {
            PropriedadeModificada("Percabaseredpart", value);
            _percabaseredpart = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 2)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 16, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 2)]
    public decimal? Percicmssimplesnac
    {
        get
        {
            PropriedadeAcessada("Percicmssimplesnac");
            return _percicmssimplesnac;
        }
        set
        {
            PropriedadeModificada("Percicmssimplesnac", value);
            _percicmssimplesnac = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 2)]
    public decimal? Percofins
    {
        get
        {
            PropriedadeAcessada("Percofins");
            return _percofins;
        }
        set
        {
            PropriedadeModificada("Percofins", value);
            _percofins = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Percom
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 2)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 2)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Perdifereimentoicms
    {
        get
        {
            PropriedadeAcessada("Perdifereimentoicms");
            return _perdifereimentoicms;
        }
        set
        {
            PropriedadeModificada("Perdifereimentoicms", value);
            _perdifereimentoicms = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Perdiferimentoicms
    {
        get
        {
            PropriedadeAcessada("Perdiferimentoicms");
            return _perdiferimentoicms;
        }
        set
        {
            PropriedadeModificada("Perdiferimentoicms", value);
            _perdiferimentoicms = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 2)]
    public decimal? Perpis
    {
        get
        {
            PropriedadeAcessada("Perpis");
            return _perpis;
        }
        set
        {
            PropriedadeModificada("Perpis", value);
            _perpis = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Piscofinsdeduzido
    {
        get
        {
            PropriedadeAcessada("Piscofinsdeduzido");
            return _piscofinsdeduzido;
        }
        set
        {
            PropriedadeModificada("Piscofinsdeduzido", value);
            _piscofinsdeduzido = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Posicaoretorno
    {
        get
        {
            PropriedadeAcessada("Posicaoretorno");
            return _posicaoretorno;
        }
        set
        {
            PropriedadeModificada("Posicaoretorno", value);
            _posicaoretorno = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Possuicomplemento
    {
        get
        {
            PropriedadeAcessada("Possuicomplemento");
            return _possuicomplemento;
        }
        set
        {
            PropriedadeModificada("Possuicomplemento", value);
            _possuicomplemento = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 20, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 2)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 2)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 3, Precisao = 0)]
    public string Sittribut
    {
        get
        {
            PropriedadeAcessada("Sittribut");
            return _sittribut;
        }
        set
        {
            PropriedadeModificada("Sittribut", value);
            _sittribut = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Tipomerc
    {
        get
        {
            PropriedadeAcessada("Tipomerc");
            return _tipomerc;
        }
        set
        {
            PropriedadeModificada("Tipomerc", value);
            _tipomerc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 7, Precisao = 0)]
    public string Totalizador
    {
        get
        {
            PropriedadeAcessada("Totalizador");
            return _totalizador;
        }
        set
        {
            PropriedadeModificada("Totalizador", value);
            _totalizador = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Usapiscofinslit
    {
        get
        {
            PropriedadeAcessada("Usapiscofinslit");
            return _usapiscofinslit;
        }
        set
        {
            PropriedadeModificada("Usapiscofinslit", value);
            _usapiscofinslit = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlbaseipi
    {
        get
        {
            PropriedadeAcessada("Vlbaseipi");
            return _vlbaseipi;
        }
        set
        {
            PropriedadeModificada("Vlbaseipi", value);
            _vlbaseipi = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlbasepart
    {
        get
        {
            PropriedadeAcessada("Vlbasepart");
            return _vlbasepart;
        }
        set
        {
            PropriedadeModificada("Vlbasepart", value);
            _vlbasepart = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 20, Precisao = 6)]
    public decimal? Vlbasepiscofins
    {
        get
        {
            PropriedadeAcessada("Vlbasepiscofins");
            return _vlbasepiscofins;
        }
        set
        {
            PropriedadeModificada("Vlbasepiscofins", value);
            _vlbasepiscofins = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlcofins
    {
        get
        {
            PropriedadeAcessada("Vlcofins");
            return _vlcofins;
        }
        set
        {
            PropriedadeModificada("Vlcofins", value);
            _vlcofins = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlcredcofins
    {
        get
        {
            PropriedadeAcessada("Vlcredcofins");
            return _vlcredcofins;
        }
        set
        {
            PropriedadeModificada("Vlcredcofins", value);
            _vlcredcofins = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlcredpis
    {
        get
        {
            PropriedadeAcessada("Vlcredpis");
            return _vlcredpis;
        }
        set
        {
            PropriedadeModificada("Vlcredpis", value);
            _vlcredpis = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlcustofin
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlcustoreal
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 2)]
    public decimal? Vldescorgaopub
    {
        get
        {
            PropriedadeAcessada("Vldescorgaopub");
            return _vldescorgaopub;
        }
        set
        {
            PropriedadeModificada("Vldescorgaopub", value);
            _vldescorgaopub = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 24, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 24, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 2)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 22, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlitemtributosestadual
    {
        get
        {
            PropriedadeAcessada("Vlitemtributosestadual");
            return _vlitemtributosestadual;
        }
        set
        {
            PropriedadeModificada("Vlitemtributosestadual", value);
            _vlitemtributosestadual = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlpis
    {
        get
        {
            PropriedadeAcessada("Vlpis");
            return _vlpis;
        }
        set
        {
            PropriedadeModificada("Vlpis", value);
            _vlpis = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 2)]
    public decimal? Vlricmssimplesnac
    {
        get
        {
            PropriedadeAcessada("Vlricmssimplesnac");
            return _vlricmssimplesnac;
        }
        set
        {
            PropriedadeModificada("Vlricmssimplesnac", value);
            _vlricmssimplesnac = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 7, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 2)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 10, Precisao = 0)]
    public string Versaoservicopartilha
    {
        get
        {
            PropriedadeAcessada("Versaoservicopartilha");
            return _versaoservicopartilha;
        }
        set
        {
            PropriedadeModificada("Versaoservicopartilha", value);
            _versaoservicopartilha = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 100, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 200, Precisao = 0)]
    public string Descricaopaf
    {
        get
        {
            PropriedadeAcessada("Descricaopaf");
            return _descricaopaf;
        }
        set
        {
            PropriedadeModificada("Descricaopaf", value);
            _descricaopaf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Peracrescimofuncep
    {
        get
        {
            PropriedadeAcessada("Peracrescimofuncep");
            return _peracrescimofuncep;
        }
        set
        {
            PropriedadeModificada("Peracrescimofuncep", value);
            _peracrescimofuncep = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlbasefcpicms
    {
        get
        {
            PropriedadeAcessada("Vlbasefcpicms");
            return _vlbasefcpicms;
        }
        set
        {
            PropriedadeModificada("Vlbasefcpicms", value);
            _vlbasefcpicms = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlacrescimofuncep
    {
        get
        {
            PropriedadeAcessada("Vlacrescimofuncep");
            return _vlacrescimofuncep;
        }
        set
        {
            PropriedadeModificada("Vlacrescimofuncep", value);
            _vlacrescimofuncep = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlbcfcpstret
    {
        get
        {
            PropriedadeAcessada("Vlbcfcpstret");
            return _vlbcfcpstret;
        }
        set
        {
            PropriedadeModificada("Vlbcfcpstret", value);
            _vlbcfcpstret = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Perfcpstret
    {
        get
        {
            PropriedadeAcessada("Perfcpstret");
            return _perfcpstret;
        }
        set
        {
            PropriedadeModificada("Perfcpstret", value);
            _perfcpstret = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlfcpstret
    {
        get
        {
            PropriedadeAcessada("Vlfcpstret");
            return _vlfcpstret;
        }
        set
        {
            PropriedadeModificada("Vlfcpstret", value);
            _vlfcpstret = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 10, Precisao = 0)]
    public string Codbeneficiofiscal
    {
        get
        {
            PropriedadeAcessada("Codbeneficiofiscal");
            return _codbeneficiofiscal;
        }
        set
        {
            PropriedadeModificada("Codbeneficiofiscal", value);
            _codbeneficiofiscal = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 200, Precisao = 0)]
    public string Md5paf
    {
        get
        {
            PropriedadeAcessada("Md5paf");
            return _md5paf;
        }
        set
        {
            PropriedadeModificada("Md5paf", value);
            _md5paf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 20, Precisao = 0)]
    public decimal? Codagregacao
    {
        get
        {
            PropriedadeAcessada("Codagregacao");
            return _codagregacao;
        }
        set
        {
            PropriedadeModificada("Codagregacao", value);
            _codagregacao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 18, Precisao = 0)]
    public string Cnpjfabricante
    {
        get
        {
            PropriedadeAcessada("Cnpjfabricante");
            return _cnpjfabricante;
        }
        set
        {
            PropriedadeModificada("Cnpjfabricante", value);
            _cnpjfabricante = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 60, Precisao = 0)]
    public string Fabricante
    {
        get
        {
            PropriedadeAcessada("Fabricante");
            return _fabricante;
        }
        set
        {
            PropriedadeModificada("Fabricante", value);
            _fabricante = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Indescalarelevante
    {
        get
        {
            PropriedadeAcessada("Indescalarelevante");
            return _indescalarelevante;
        }
        set
        {
            PropriedadeModificada("Indescalarelevante", value);
            _indescalarelevante = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Perfcpsn
    {
        get
        {
            PropriedadeAcessada("Perfcpsn");
            return _perfcpsn;
        }
        set
        {
            PropriedadeModificada("Perfcpsn", value);
            _perfcpsn = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlcredfcpicmssn
    {
        get
        {
            PropriedadeAcessada("Vlcredfcpicmssn");
            return _vlcredfcpicmssn;
        }
        set
        {
            PropriedadeModificada("Vlcredfcpicmssn", value);
            _vlcredfcpicmssn = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 9, Precisao = 0)]
    public decimal? Anp
    {
        get
        {
            PropriedadeAcessada("Anp");
            return _anp;
        }
        set
        {
            PropriedadeModificada("Anp", value);
            _anp = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 95, Precisao = 0)]
    public string Descanp
    {
        get
        {
            PropriedadeAcessada("Descanp");
            return _descanp;
        }
        set
        {
            PropriedadeModificada("Descanp", value);
            _descanp = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 7, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 7, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 7, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 23, Precisao = 10)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 2)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Codmotivoicmsdesonerado
    {
        get
        {
            PropriedadeAcessada("Codmotivoicmsdesonerado");
            return _codmotivoicmsdesonerado;
        }
        set
        {
            PropriedadeModificada("Codmotivoicmsdesonerado", value);
            _codmotivoicmsdesonerado = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlicmsdesoneracao
    {
        get
        {
            PropriedadeAcessada("Vlicmsdesoneracao");
            return _vlicmsdesoneracao;
        }
        set
        {
            PropriedadeModificada("Vlicmsdesoneracao", value);
            _vlicmsdesoneracao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Custoultent
    {
        get
        {
            PropriedadeAcessada(RO_CUSTOULTENT);
            return _custoultent;
        }
        set
        {
            PropriedadeModificada(RO_CUSTOULTENT, value);
            _custoultent = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Valorultent
    {
        get
        {
            PropriedadeAcessada("Valorultent");
            return _valorultent;
        }
        set
        {
            PropriedadeModificada("Valorultent", value);
            _valorultent = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Percredbaseefet
    {
        get
        {
            PropriedadeAcessada("Percredbaseefet");
            return _percredbaseefet;
        }
        set
        {
            PropriedadeModificada("Percredbaseefet", value);
            _percredbaseefet = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlbaseefet
    {
        get
        {
            PropriedadeAcessada("Vlbaseefet");
            return _vlbaseefet;
        }
        set
        {
            PropriedadeModificada("Vlbaseefet", value);
            _vlbaseefet = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Percicmsefet
    {
        get
        {
            PropriedadeAcessada("Percicmsefet");
            return _percicmsefet;
        }
        set
        {
            PropriedadeModificada("Percicmsefet", value);
            _percicmsefet = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlicmsefet
    {
        get
        {
            PropriedadeAcessada("Vlicmsefet");
            return _vlicmsefet;
        }
        set
        {
            PropriedadeModificada("Vlicmsefet", value);
            _vlicmsefet = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 50, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 50, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vldescontomotoroferta
    {
        get
        {
            PropriedadeAcessada("Vldescontomotoroferta");
            return _vldescontomotoroferta;
        }
        set
        {
            PropriedadeModificada("Vldescontomotoroferta", value);
            _vldescontomotoroferta = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Basebcr
    {
        get
        {
            PropriedadeAcessada(RO_BASEBCR);
            return _basebcr;
        }
        set
        {
            PropriedadeModificada(RO_BASEBCR, value);
            _basebcr = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Stbcr
    {
        get
        {
            PropriedadeAcessada(RO_STBCR);
            return _stbcr;
        }
        set
        {
            PropriedadeModificada(RO_STBCR, value);
            _stbcr = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Baseicmsbcr
    {
        get
        {
            PropriedadeAcessada(RO_BASEICMSBCR);
            return _baseicmsbcr;
        }
        set
        {
            PropriedadeModificada(RO_BASEICMSBCR, value);
            _baseicmsbcr = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 2)]
    public decimal? Vlicmsbcr
    {
        get
        {
            PropriedadeAcessada(RO_VLICMSBCR);
            return _vlicmsbcr;
        }
        set
        {
            PropriedadeModificada(RO_VLICMSBCR, value);
            _vlicmsbcr = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Origemitem
    {
        get
        {
            PropriedadeAcessada(RO_ORIGEMITEM);
            return _origemitem;
        }
        set
        {
            PropriedadeModificada(RO_ORIGEMITEM, value);
            _origemitem = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codfornec
    {
        get
        {
            PropriedadeAcessada(RO_CODFORNEC);
            return _codfornec;
        }
        set
        {
            PropriedadeModificada(RO_CODFORNEC, value);
            _codfornec = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vldescsuframa
    {
        get
        {
            PropriedadeAcessada(RO_VLDESCSUFRAMA);
            return _vldescsuframa;
        }
        set
        {
            PropriedadeModificada(RO_VLDESCSUFRAMA, value);
            _vldescsuframa = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vldescitem
    {
        get
        {
            PropriedadeAcessada(RO_VLDESCITEM);
            return _vldescitem;
        }
        set
        {
            PropriedadeModificada(RO_VLDESCITEM, value);
            _vldescitem = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Excluiricmsbasepiscofins
    {
        get
        {
            PropriedadeAcessada(RO_EXCLUIRICMSBASEPISCOFINS);
            return _excluiricmsbasepiscofins;
        }
        set
        {
            PropriedadeModificada(RO_EXCLUIRICMSBASEPISCOFINS, value);
            _excluiricmsbasepiscofins = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 21, Precisao = 10)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 7, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 23, Precisao = 10)]
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
        return "PCPEDIECF";
    }

    public IEntidade NovaInstancia()
    {
        return (IEntidade)GetType().GetConstructors()[0].Invoke(null);
    }

    public void CarregarPorDataReader(IDataReader leitor)
    {
        _aliqfcp = AlterarTipo<decimal?>(leitor["Aliqfcp"]);
        _aliqicms1 = AlterarTipo<decimal?>(leitor["Aliqicms1"]);
        _aliqicms2 = AlterarTipo<decimal?>(leitor["Aliqicms2"]);
        _aliqinternadest = AlterarTipo<decimal?>(leitor["Aliqinternadest"]);
        _aliqinterorigpart = AlterarTipo<decimal?>(leitor["Aliqinterorigpart"]);
        _aliqreducaocofins = AlterarTipo<decimal?>(leitor["Aliqreducaocofins"]);
        _aliqreducaopis = AlterarTipo<decimal?>(leitor["Aliqreducaopis"]);
        _assinatura = AlterarTipo<string>(leitor["Assinatura"]);
        _basedifaliquotas = AlterarTipo<decimal?>(leitor["Basedifaliquotas"]);
        _baseicms = AlterarTipo<decimal?>(leitor["Baseicms"]);
        _baseicst = AlterarTipo<decimal?>(leitor["Baseicst"]);
        _baseipiecf = AlterarTipo<decimal?>(leitor["Baseipiecf"]);
        _bciss = AlterarTipo<decimal?>(leitor["Bciss"]);
        _brinde = AlterarTipo<string>(leitor["Brinde"]);
        _codauxiliar = AlterarTipo<decimal?>(leitor["Codauxiliar"]);
        _codcampanha = AlterarTipo<decimal?>(leitor["Codcampanha"]);
        _codcli = AlterarTipo<decimal>(leitor["Codcli"]);
        _codcontrolevasilhame = AlterarTipo<decimal?>(leitor["Codcontrolevasilhame"]);
        _codecf = AlterarTipo<string>(leitor["Codecf"]);
        _codfilial = AlterarTipo<string>(leitor["Codfilial"]);
        _codfilialretira = AlterarTipo<string>(leitor["Codfilialretira"]);
        _codfiscal = AlterarTipo<decimal?>(leitor["Codfiscal"]);
        _codfunccx = AlterarTipo<decimal>(leitor["Codfunccx"]);
        _codicmtab = AlterarTipo<decimal?>(leitor["Codicmtab"]);
        _codigobrinde = AlterarTipo<decimal?>(leitor["Codigobrinde"]);
        _codprod = AlterarTipo<decimal>(leitor["Codprod"]);
        _codsittribpiscofins = AlterarTipo<decimal?>(leitor["Codsittribpiscofins"]);
        _codst = AlterarTipo<decimal?>(leitor["Codst"]);
        _codtribpiscofins = AlterarTipo<decimal?>(leitor["Codtribpiscofins"]);
        _codusur = AlterarTipo<decimal>(leitor["Codusur"]);
        _codvasilhameecf = AlterarTipo<decimal?>(leitor["Codvasilhameecf"]);
        _custofinest = AlterarTipo<decimal?>(leitor["Custofinest"]);
        _data = AlterarTipo<DateTime>(leitor["Data"]);
        _dtexportacao = AlterarTipo<DateTime?>(leitor["Dtexportacao"]);
        _enviaraliqreducaopiscofins = AlterarTipo<string>(leitor["Enviaraliqreducaopiscofins"]);
        _exportado = AlterarTipo<string>(leitor["Exportado"]);
        _idcancel = AlterarTipo<string>(leitor["Idcancel"]);
        _importado = AlterarTipo<string>(leitor["Importado"]);
        _iva = AlterarTipo<decimal?>(leitor["Iva"]);
        _logerro = AlterarTipo<string>(leitor["Logerro"]);
        _numcaixa = AlterarTipo<decimal>(leitor["Numcaixa"]);
        _numcaixafiscal = AlterarTipo<decimal?>(leitor["Numcaixafiscal"]);
        _numcar = AlterarTipo<decimal?>(leitor["Numcar"]);
        _numccf = AlterarTipo<decimal?>(leitor["Numccf"]);
        _numcoo = AlterarTipo<decimal?>(leitor["Numcoo"]);
        _numlista = AlterarTipo<decimal?>(leitor["Numlista"]);
        _numlote = AlterarTipo<string>(leitor["Numlote"]);
        _numped = AlterarTipo<decimal?>(leitor["Numped"]);
        _numpedecf = AlterarTipo<decimal>(leitor["Numpedecf"]);
        _numreposicao = AlterarTipo<decimal?>(leitor["Numreposicao"]);
        _numseq = AlterarTipo<decimal>(leitor["Numseq"]);
        _numseqorig = AlterarTipo<decimal?>(leitor["Numseqorig"]);
        _numserie = AlterarTipo<string>(leitor["Numserie"]);
        _numserieequip = AlterarTipo<string>(leitor["Numserieequip"]);
        _numseriesat = AlterarTipo<string>(leitor["Numseriesat"]);
        _origmerctrib = AlterarTipo<string>(leitor["Origmerctrib"]);
        _pauta = AlterarTipo<decimal?>(leitor["Pauta"]);
        _pbaserca = AlterarTipo<decimal?>(leitor["Pbaserca"]);
        _peracrescimocusto = AlterarTipo<decimal?>(leitor["Peracrescimocusto"]);
        _percabaseredpart = AlterarTipo<decimal?>(leitor["Percabaseredpart"]);
        _percbasered = AlterarTipo<decimal?>(leitor["Percbasered"]);
        _percbaseredpart = AlterarTipo<decimal?>(leitor["Percbaseredpart"]);
        _percbaseredst = AlterarTipo<decimal?>(leitor["Percbaseredst"]);
        _percbaseredstfonte = AlterarTipo<decimal?>(leitor["Percbaseredstfonte"]);
        _percdesccofins = AlterarTipo<decimal?>(leitor["Percdesccofins"]);
        _percdescpis = AlterarTipo<decimal?>(leitor["Percdescpis"]);
        _percdifaliquotas = AlterarTipo<decimal?>(leitor["Percdifaliquotas"]);
        _percicm = AlterarTipo<decimal?>(leitor["Percicm"]);
        _percicmssimplesnac = AlterarTipo<decimal?>(leitor["Percicmssimplesnac"]);
        _percipi = AlterarTipo<decimal?>(leitor["Percipi"]);
        _percipiecf = AlterarTipo<decimal?>(leitor["Percipiecf"]);
        _perciss = AlterarTipo<decimal?>(leitor["Perciss"]);
        _percofins = AlterarTipo<decimal?>(leitor["Percofins"]);
        _percom = AlterarTipo<decimal?>(leitor["Percom"]);
        _percprovpart = AlterarTipo<decimal?>(leitor["Percprovpart"]);
        _perctributos = AlterarTipo<decimal?>(leitor["Perctributos"]);
        _perdesc = AlterarTipo<decimal>(leitor["Perdesc"]);
        _perdifereimentoicms = AlterarTipo<decimal?>(leitor["Perdifereimentoicms"]);
        _perdiferimentoicms = AlterarTipo<decimal?>(leitor["Perdiferimentoicms"]);
        _perfretecmv = AlterarTipo<decimal?>(leitor["Perfretecmv"]);
        _perpis = AlterarTipo<decimal?>(leitor["Perpis"]);
        _piscofinsdeduzido = AlterarTipo<string>(leitor["Piscofinsdeduzido"]);
        _poriginal = AlterarTipo<decimal?>(leitor["Poriginal"]);
        _posicao = AlterarTipo<string>(leitor["Posicao"]);
        _posicaoretorno = AlterarTipo<string>(leitor["Posicaoretorno"]);
        _possuicomplemento = AlterarTipo<string>(leitor["Possuicomplemento"]);
        _ptabela = AlterarTipo<decimal>(leitor["Ptabela"]);
        _pvenda = AlterarTipo<decimal>(leitor["Pvenda"]);
        _pvendavasilhame = AlterarTipo<decimal?>(leitor["Pvendavasilhame"]);
        _qt = AlterarTipo<decimal>(leitor["Qt"]);
        _qtfalta = AlterarTipo<decimal?>(leitor["Qtfalta"]);
        _qtlitragem = AlterarTipo<decimal?>(leitor["Qtlitragem"]);
        _qtsaidavasilhame = AlterarTipo<decimal?>(leitor["Qtsaidavasilhame"]);
        _qtunitemb = AlterarTipo<decimal?>(leitor["Qtunitemb"]);
        _qtvendidavasilhame = AlterarTipo<decimal?>(leitor["Qtvendidavasilhame"]);
        _rotinalanc = AlterarTipo<decimal?>(leitor["Rotinalanc"]);
        _sittribut = AlterarTipo<string>(leitor["Sittribut"]);
        _st = AlterarTipo<decimal>(leitor["St"]);
        _tipoentrega = AlterarTipo<string>(leitor["Tipoentrega"]);
        _tipomerc = AlterarTipo<string>(leitor["Tipomerc"]);
        _totalizador = AlterarTipo<string>(leitor["Totalizador"]);
        _truncaritem = AlterarTipo<string>(leitor["Truncaritem"]);
        _txvenda = AlterarTipo<decimal?>(leitor["Txvenda"]);
        _usapiscofinslit = AlterarTipo<string>(leitor["Usapiscofinslit"]);
        _vendapbm = AlterarTipo<string>(leitor["Vendapbm"]);
        _vlacrescrodape = AlterarTipo<decimal?>(leitor["Vlacrescrodape"]);
        _vldescfin = AlterarTipo<decimal?>(leitor["Vldescfin"]);
        _vloutrasdesp = AlterarTipo<decimal?>(leitor["Vloutrasdesp"]);
        _vlacrescvasilhame = AlterarTipo<decimal?>(leitor["Vlacrescvasilhame"]);
        _vlbaseipi = AlterarTipo<decimal?>(leitor["Vlbaseipi"]);
        _vlbasepart = AlterarTipo<decimal?>(leitor["Vlbasepart"]);
        _vlbasepartdest = AlterarTipo<decimal?>(leitor["Vlbasepartdest"]);
        _vlbasepiscofins = AlterarTipo<decimal?>(leitor["Vlbasepiscofins"]);
        _vlcofins = AlterarTipo<decimal?>(leitor["Vlcofins"]);
        _vlcredcofins = AlterarTipo<decimal?>(leitor["Vlcredcofins"]);
        _vlcredpis = AlterarTipo<decimal?>(leitor["Vlcredpis"]);
        _vlcustocont = AlterarTipo<decimal?>(leitor["Vlcustocont"]);
        _vlcustofin = AlterarTipo<decimal?>(leitor["Vlcustofin"]);
        _vlcustoreal = AlterarTipo<decimal?>(leitor["Vlcustoreal"]);
        _vlcustorep = AlterarTipo<decimal?>(leitor["Vlcustorep"]);
        _vldescorgaopub = AlterarTipo<decimal?>(leitor["Vldescorgaopub"]);
        _vldescreducaocofins = AlterarTipo<decimal?>(leitor["Vldescreducaocofins"]);
        _vldescreducaopis = AlterarTipo<decimal?>(leitor["Vldescreducaopis"]);
        _vldescrodape = AlterarTipo<decimal?>(leitor["Vldescrodape"]);
        _vldescsociotorcedor = AlterarTipo<decimal?>(leitor["Vldescsociotorcedor"]);
        _vldifaliquotas = AlterarTipo<decimal?>(leitor["Vldifaliquotas"]);
        _vlfcppart = AlterarTipo<decimal?>(leitor["Vlfcppart"]);
        _vlicmsdifaliqpart = AlterarTipo<decimal?>(leitor["Vlicmsdifaliqpart"]);
        _vlicmspart = AlterarTipo<decimal?>(leitor["Vlicmspart"]);
        _vlicmspartdest = AlterarTipo<decimal?>(leitor["Vlicmspartdest"]);
        _vlicmspartrem = AlterarTipo<decimal?>(leitor["Vlicmspartrem"]);
        _vlipi = AlterarTipo<decimal?>(leitor["Vlipi"]);
        _vlipiecf = AlterarTipo<decimal?>(leitor["Vlipiecf"]);
        _vliss = AlterarTipo<decimal?>(leitor["Vliss"]);
        _vlitemtributos = AlterarTipo<decimal?>(leitor["Vlitemtributos"]);
        _vlitemtributosestadual = AlterarTipo<decimal?>(leitor["Vlitemtributosestadual"]);
        _vlpis = AlterarTipo<decimal?>(leitor["Vlpis"]);
        _vlricmssimplesnac = AlterarTipo<decimal?>(leitor["Vlricmssimplesnac"]);
        _vlsubtotitem = AlterarTipo<decimal?>(leitor["Vlsubtotitem"]);
        _perdesccusto = AlterarTipo<decimal?>(leitor["Perdesccusto"]);
        _versaoservicopartilha = AlterarTipo<string>(leitor["Versaoservicopartilha"]);
        _codbarrabalanca = AlterarTipo<string>(leitor["Codbarrabalanca"]);
        _descricaopaf = AlterarTipo<string>(leitor["Descricaopaf"]);
        _qtminatacvenda = AlterarTipo<decimal?>(leitor["Qtminatacvenda"]);
        _tipodescatacvenda = AlterarTipo<string>(leitor["Tipodescatacvenda"]);
        _codoferta = AlterarTipo<decimal?>(leitor["Codoferta"]);
        _peracrescimofuncep = AlterarTipo<decimal?>(leitor["Peracrescimofuncep"]);
        _vlbasefcpicms = AlterarTipo<decimal?>(leitor["Vlbasefcpicms"]);
        _vlacrescimofuncep = AlterarTipo<decimal?>(leitor["Vlacrescimofuncep"]);
        _aliqicmsfecp = AlterarTipo<decimal?>(leitor["Aliqicmsfecp"]);
        _vlbasefcpst = AlterarTipo<decimal?>(leitor["Vlbasefcpst"]);
        _vlbcfcpstret = AlterarTipo<decimal?>(leitor["Vlbcfcpstret"]);
        _perfcpstret = AlterarTipo<decimal?>(leitor["Perfcpstret"]);
        _vlfcpstret = AlterarTipo<decimal?>(leitor["Vlfcpstret"]);
        _codbeneficiofiscal = AlterarTipo<string>(leitor["Codbeneficiofiscal"]);
        _vlfecp = AlterarTipo<decimal?>(leitor["Vlfecp"]);
        _md5paf = AlterarTipo<string>(leitor["Md5paf"]);
        _codagregacao = AlterarTipo<decimal?>(leitor["Codagregacao"]);
        _cnpjfabricante = AlterarTipo<string>(leitor["Cnpjfabricante"]);
        _indescalarelevante = AlterarTipo<string>(leitor["Indescalarelevante"]);
        _fabricante = AlterarTipo<string>(leitor["Fabricante"]);
        _perfcpsn = AlterarTipo<decimal?>(leitor["Perfcpsn"]);
        _vlcredfcpicmssn = AlterarTipo<decimal?>(leitor["Vlcredfcpicmssn"]);
        _anp = AlterarTipo<decimal?>(leitor["Anp"]);
        _descanp = AlterarTipo<string>(leitor["Descanp"]);
        _pglp = AlterarTipo<decimal?>(leitor["Pglp"]);
        _pgni = AlterarTipo<decimal?>(leitor["Pgni"]);
        _pgnn = AlterarTipo<decimal?>(leitor["Pgnn"]);
        _vpart = AlterarTipo<decimal?>(leitor["Vpart"]);
        _vldescicmisencao = AlterarTipo<decimal?>(leitor["Vldescicmisencao"]);
        _perdescisentoicms = AlterarTipo<decimal?>(leitor["Perdescisentoicms"]);
        _codmotivoicmsdesonerado = AlterarTipo<string>(leitor["Codmotivoicmsdesonerado"]);
        _vlicmsdesoneracao = AlterarTipo<decimal?>(leitor["Vlicmsdesoneracao"]);
        _vlfrete = AlterarTipo<decimal?>(leitor["Vlfrete"]);
        _valorultent = AlterarTipo<decimal?>(leitor["Valorultent"]);
        _custoultent = AlterarTipo<decimal?>(leitor["Custoultent"]);
        _utilizoumotorcalculo = AlterarTipo<string>(leitor["Utilizoumotorcalculo"]);
        _percredbaseefet = AlterarTipo<decimal?>(leitor["Percredbaseefet"]);
        _vlbaseefet = AlterarTipo<decimal?>(leitor["Vlbaseefet"]);
        _percicmsefet = AlterarTipo<decimal?>(leitor["Percicmsefet"]);
        _vlicmsefet = AlterarTipo<decimal?>(leitor["Vlicmsefet"]);
        _cupomdesconto = AlterarTipo<string>(leitor["Cupomdesconto"]);
        _codcupomdesconto = AlterarTipo<string>(leitor["Codcupomdesconto"]);
        _vldescontomotoroferta = AlterarTipo<decimal?>(leitor["Vldescontomotoroferta"]);
        _codcest = AlterarTipo<string>(leitor["Codcest"]);
        _basebcr = AlterarTipo<decimal?>(leitor["Basebcr"]);
        _stbcr = AlterarTipo<decimal?>(leitor["Stbcr"]);
        _baseicmsbcr = AlterarTipo<decimal?>(leitor["Baseicmsbcr"]);
        _vlicmsbcr = AlterarTipo<decimal?>(leitor["Vlicmsbcr"]);
        _origemitem = AlterarTipo<string>(leitor["Origemitem"]);
        _codfornec = AlterarTipo<decimal>(leitor["Codfornec"]);
        _vldescsuframa = AlterarTipo<decimal?>(leitor["Vldescsuframa"]);
        _vldescitem = AlterarTipo<decimal?>(leitor["Vldescitem"]);
        _excluiricmsbasepiscofins = AlterarTipo<string>(leitor[RO_EXCLUIRICMSBASEPISCOFINS]);
        Qbcmonoret = AlterarTipo<decimal?>(leitor[RO_QBCMONORET]);
        Adremicmsret = AlterarTipo<decimal?>(leitor[RO_ADREMICMSRET]);
        Vicmsmonoret = AlterarTipo<decimal?>(leitor[RO_VICMSMONORET]);
    }

}