

////// namespace nwErp.Entidades.Caixa;

// namespace nwErp.Api.Modelos;

[Serializable]
public class PCPEDIECFCESTA : GerenteDePropriedades, IEntidade
{
    private decimal? _aliqfcp;

    private decimal? _aliqicms1;

    private decimal? _aliqicms2;

    private decimal? _aliqinternadest;

    private decimal? _aliqinterorigpart;

    private decimal? _basedifaliquotas;

    private decimal? _baseicms;

    private decimal? _baseicst;

    private decimal? _baseidfaliquotas;

    private decimal? _bciss;

    private decimal? _bcss;

    private decimal? _codauxiliar;

    private string _codecf;

    private string _codfilial;

    private decimal? _codfiscal;

    private decimal _codfunccx;

    private decimal? _codicmtab;

    private decimal _codprod;

    private decimal _codprodmp;

    private decimal? _codst;

    private decimal? _custofinest;

    private DateTime? _data;

    private DateTime? _dtexportacao;

    private string _exportado;

    private string _importado;

    private decimal? _iva;

    private decimal _numcaixa;

    private decimal? _numcaixafiscal;

    private decimal? _numped;

    private decimal _numpedecf;

    private decimal _numseq;

    private string _numserie;

    private string _numserieequip;

    private string _numseriesat;

    private decimal? _pauta;

    private decimal? _pbaserca;

    private decimal? _percbasered;

    private decimal? _percbaseredpart;

    private decimal? _percbaseredst;

    private decimal? _percbaseredstfonte;

    private decimal? _percdesccofins;

    private decimal? _percdescpis;

    private decimal? _percdifaliquotas;

    private decimal? _percicm;

    private decimal? _percicms;

    private decimal? _percipi;

    private decimal? _perciss;

    private decimal? _percofins;

    private decimal _percom;

    private decimal? _percpis;

    private decimal? _percprovpart;

    private decimal? _perctributos;

    private decimal? _perdesccusto;

    private decimal? _perdesctab;

    private decimal? _perdifereimentoicms;

    private decimal? _perfretecmv;

    private decimal? _perpis;

    private string _posicaoretorno;

    private decimal _ptabela;

    private decimal _pvenda;

    private decimal? _qtmp;

    private string _sittribut;

    private decimal _st;

    private decimal? _stclientegnre;

    private decimal? _txvenda;

    private decimal? _vlacrescrodape;

    private decimal? _vlbaseipi;

    private decimal? _vlbasepart;

    private decimal? _vlbasepartdest;

    private decimal? _vlcofins;

    private decimal? _vlcustocont;

    private decimal _vlcustofin;

    private decimal _vlcustoreal;

    private decimal? _vlcustorep;

    private decimal? _vldesccustocmv;

    private decimal? _vldescreducaocofins;

    private decimal? _vldescreducaopis;

    private decimal? _vldescrodape;

    private decimal? _vldescsuframa;

    private decimal? _vldifaliquotas;

    private decimal? _vlfcppart;

    private decimal? _vlicmsdifaliqpart;

    private decimal? _vlicmspart;

    private decimal? _vlicmspartdest;

    private decimal? _vlicmspartrem;

    private decimal? _vlipi;

    private decimal? _vliss;

    private decimal? _vlitemtributos;

    private decimal? _vlitemtributosestadual;

    private decimal? _vlpis;

    private decimal? _vlsubtotitem;

    private string _codcest;

    private string _versaoservicopartilha;

    private string _descricaopaf;

    private decimal? _qtminatacvenda;

    private string _tipodescatacvenda;

    private decimal? _codoferta;

    private string _codbeneficiofiscal;

    private decimal? _peracrescimofuncep;

    private decimal? _vlbasefcpicms;

    private decimal? _vlacrescimofuncep;

    private decimal? _aliqicmsfecp;

    private decimal? _vlbasefcpst;

    private decimal? _vlbcfcpstret;

    private decimal? _perfcpstret;

    private decimal? _vlfcpstret;

    private decimal? _vlfecp;

    private decimal? _codagregacao;

    private string _cnpjfabricante;

    private string _fabricante;

    private string _indescalarelevante;

    private decimal? _perfcpsn;

    private decimal? _vlcredfcpicmssn;

    private string _numlote;

    private static readonly string RO_CUSTOULTENT = "Custoultent";

    private decimal? _custoultent;

    private decimal? _valorultent;

    private decimal? _baseipiecf;

    private decimal? _percipiecf;

    private decimal? _vlipiecf;

    private decimal? _percredbaseefet;

    private decimal? _vlbaseefet;

    private decimal? _percicmsefet;

    private decimal? _vlicmsefet;

    private decimal? _vldescontomotoroferta;

    private decimal? _numccf;

    private string _totalizador;

    private string _md5paf;

    private decimal? _numseqitem;

    private decimal? _poriginal;

    private static readonly string RO_BASEBCR = "Basebcr";

    private decimal? _basebcr;

    private static readonly string RO_STBCR = "Stbcr";

    private decimal? _stbcr;

    private decimal? _codsittribpiscofins;

    private decimal? _vldescicmisencao;

    private decimal? _perdescisentoicms;

    private decimal? _vlicmsdesoneracao;

    private string _codmotivoicmsdesonerado;

    private static readonly string RO_BASEICMSBCR = "Baseicmsbcr";

    private decimal? _baseicmsbcr;

    private static readonly string RO_VLICMSBCR = "Vlicmsbcr";

    private decimal? _vlicmsbcr;

    private static readonly string RO_CODFORNEC = "Codfornec";

    private decimal? _codfornec;

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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECFCESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 2)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECFCESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECFCESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECFCESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 2)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECFCESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECFCESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECFCESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECFCESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECFCESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Baseidfaliquotas
    {
        get
        {
            PropriedadeAcessada("Baseidfaliquotas");
            return _baseidfaliquotas;
        }
        set
        {
            PropriedadeModificada("Baseidfaliquotas", value);
            _baseidfaliquotas = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECFCESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECFCESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 6)]
    public decimal? Bcss
    {
        get
        {
            PropriedadeAcessada("Bcss");
            return _bcss;
        }
        set
        {
            PropriedadeModificada("Bcss", value);
            _bcss = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECFCESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 16, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECFCESTA", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECFCESTA", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECFCESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCPEDIECFCESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECFCESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCPEDIECFCESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCPEDIECFCESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal Codprodmp
    {
        get
        {
            PropriedadeAcessada("Codprodmp");
            return _codprodmp;
        }
        set
        {
            PropriedadeModificada("Codprodmp", value);
            _codprodmp = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECFCESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECFCESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECFCESTA", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Data
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECFCESTA", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECFCESTA", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECFCESTA", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECFCESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCPEDIECFCESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECFCESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECFCESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCPEDIECFCESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCPEDIECFCESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 20, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECFCESTA", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 30, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCPEDIECFCESTA", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 30, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECFCESTA", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 13, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECFCESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECFCESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECFCESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECFCESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 2)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECFCESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECFCESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECFCESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECFCESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECFCESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECFCESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 2)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECFCESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 2)]
    public decimal? Percicms
    {
        get
        {
            PropriedadeAcessada("Percicms");
            return _percicms;
        }
        set
        {
            PropriedadeModificada("Percicms", value);
            _percicms = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECFCESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECFCESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECFCESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 2)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECFCESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECFCESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 2)]
    public decimal? Percpis
    {
        get
        {
            PropriedadeAcessada("Percpis");
            return _percpis;
        }
        set
        {
            PropriedadeModificada("Percpis", value);
            _percpis = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECFCESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 2)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECFCESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 2)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECFCESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECFCESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECFCESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECFCESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECFCESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 2)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECFCESTA", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECFCESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECFCESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECFCESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 20, Precisao = 6)]
    public decimal? Qtmp
    {
        get
        {
            PropriedadeAcessada("Qtmp");
            return _qtmp;
        }
        set
        {
            PropriedadeModificada("Qtmp", value);
            _qtmp = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECFCESTA", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 3, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECFCESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECFCESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECFCESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECFCESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECFCESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECFCESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECFCESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECFCESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECFCESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECFCESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECFCESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECFCESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECFCESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECFCESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 24, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECFCESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 24, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECFCESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECFCESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECFCESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECFCESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECFCESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 22, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECFCESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECFCESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECFCESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECFCESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECFCESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECFCESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECFCESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECFCESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECFCESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECFCESTA", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 7, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECFCESTA", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 10, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECFCESTA", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 200, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECFCESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECFCESTA", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECFCESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECFCESTA", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 10, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECFCESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECFCESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECFCESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECFCESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECFCESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECFCESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECFCESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECFCESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECFCESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECFCESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 20, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECFCESTA", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 18, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECFCESTA", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 60, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECFCESTA", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECFCESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECFCESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECFCESTA", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 15, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECFCESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECFCESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECFCESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECFCESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECFCESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECFCESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECFCESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECFCESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECFCESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECFCESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECFCESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECFCESTA", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 7, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECFCESTA", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 200, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECFCESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 20, Precisao = 0)]
    public decimal? Numseqitem
    {
        get
        {
            PropriedadeAcessada("Numseqitem");
            return _numseqitem;
        }
        set
        {
            PropriedadeModificada("Numseqitem", value);
            _numseqitem = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECFCESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECFCESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECFCESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECFCESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 3, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECFCESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECFCESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 2)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECFCESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECFCESTA", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECFCESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECFCESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 2)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECFCESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECFCESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECFCESTA", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECFCESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 21, Precisao = 10)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECFCESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 7, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDIECFCESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 23, Precisao = 10)]
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
        return "PCPEDIECFCESTA";
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
        _basedifaliquotas = AlterarTipo<decimal?>(leitor["Basedifaliquotas"]);
        _baseicms = AlterarTipo<decimal?>(leitor["Baseicms"]);
        _baseicst = AlterarTipo<decimal?>(leitor["Baseicst"]);
        _baseidfaliquotas = AlterarTipo<decimal?>(leitor["Baseidfaliquotas"]);
        _bciss = AlterarTipo<decimal?>(leitor["Bciss"]);
        _bcss = AlterarTipo<decimal?>(leitor["Bcss"]);
        _codauxiliar = AlterarTipo<decimal?>(leitor["Codauxiliar"]);
        _codecf = AlterarTipo<string>(leitor["Codecf"]);
        _codfilial = AlterarTipo<string>(leitor["Codfilial"]);
        _codfiscal = AlterarTipo<decimal?>(leitor["Codfiscal"]);
        _codfunccx = AlterarTipo<decimal>(leitor["Codfunccx"]);
        _codicmtab = AlterarTipo<decimal?>(leitor["Codicmtab"]);
        _codprod = AlterarTipo<decimal>(leitor["Codprod"]);
        _codprodmp = AlterarTipo<decimal>(leitor["Codprodmp"]);
        _codst = AlterarTipo<decimal?>(leitor["Codst"]);
        _custofinest = AlterarTipo<decimal?>(leitor["Custofinest"]);
        _dtexportacao = AlterarTipo<DateTime?>(leitor["Dtexportacao"]);
        _exportado = AlterarTipo<string>(leitor["Exportado"]);
        _importado = AlterarTipo<string>(leitor["Importado"]);
        _iva = AlterarTipo<decimal?>(leitor["Iva"]);
        _numcaixa = AlterarTipo<decimal>(leitor["Numcaixa"]);
        _numcaixafiscal = AlterarTipo<decimal?>(leitor["Numcaixafiscal"]);
        _numped = AlterarTipo<decimal?>(leitor["Numped"]);
        _numpedecf = AlterarTipo<decimal>(leitor["Numpedecf"]);
        _numseq = AlterarTipo<decimal>(leitor["Numseq"]);
        _numserie = AlterarTipo<string>(leitor["Numserie"]);
        _numserieequip = AlterarTipo<string>(leitor["Numserieequip"]);
        _numseriesat = AlterarTipo<string>(leitor["Numseriesat"]);
        _pauta = AlterarTipo<decimal?>(leitor["Pauta"]);
        _pbaserca = AlterarTipo<decimal?>(leitor["Pbaserca"]);
        _percbasered = AlterarTipo<decimal?>(leitor["Percbasered"]);
        _percbaseredpart = AlterarTipo<decimal?>(leitor["Percbaseredpart"]);
        _percbaseredst = AlterarTipo<decimal?>(leitor["Percbaseredst"]);
        _percbaseredstfonte = AlterarTipo<decimal?>(leitor["Percbaseredstfonte"]);
        _percdesccofins = AlterarTipo<decimal?>(leitor["Percdesccofins"]);
        _percdescpis = AlterarTipo<decimal?>(leitor["Percdescpis"]);
        _percdifaliquotas = AlterarTipo<decimal?>(leitor["Percdifaliquotas"]);
        _percicm = AlterarTipo<decimal?>(leitor["Percicm"]);
        _percicms = AlterarTipo<decimal?>(leitor["Percicms"]);
        _percipi = AlterarTipo<decimal?>(leitor["Percipi"]);
        _perciss = AlterarTipo<decimal?>(leitor["Perciss"]);
        _percofins = AlterarTipo<decimal?>(leitor["Percofins"]);
        _percom = AlterarTipo<decimal>(leitor["Percom"]);
        _percpis = AlterarTipo<decimal?>(leitor["Percpis"]);
        _percprovpart = AlterarTipo<decimal?>(leitor["Percprovpart"]);
        _perctributos = AlterarTipo<decimal?>(leitor["Perctributos"]);
        _perdesccusto = AlterarTipo<decimal?>(leitor["Perdesccusto"]);
        _perdesctab = AlterarTipo<decimal?>(leitor["Perdesctab"]);
        _perdifereimentoicms = AlterarTipo<decimal?>(leitor["Perdifereimentoicms"]);
        _perfretecmv = AlterarTipo<decimal?>(leitor["Perfretecmv"]);
        _perpis = AlterarTipo<decimal?>(leitor["Perpis"]);
        _posicaoretorno = AlterarTipo<string>(leitor["Posicaoretorno"]);
        _ptabela = AlterarTipo<decimal>(leitor["Ptabela"]);
        _pvenda = AlterarTipo<decimal>(leitor["Pvenda"]);
        _qtmp = AlterarTipo<decimal?>(leitor["Qtmp"]);
        _sittribut = AlterarTipo<string>(leitor["Sittribut"]);
        _st = AlterarTipo<decimal>(leitor["St"]);
        _stclientegnre = AlterarTipo<decimal?>(leitor["Stclientegnre"]);
        _txvenda = AlterarTipo<decimal?>(leitor["Txvenda"]);
        _vlacrescrodape = AlterarTipo<decimal?>(leitor["Vlacrescrodape"]);
        _vlbaseipi = AlterarTipo<decimal?>(leitor["Vlbaseipi"]);
        _vlbasepart = AlterarTipo<decimal?>(leitor["Vlbasepart"]);
        _vlbasepartdest = AlterarTipo<decimal?>(leitor["Vlbasepartdest"]);
        _vlcofins = AlterarTipo<decimal?>(leitor["Vlcofins"]);
        _vlcustocont = AlterarTipo<decimal?>(leitor["Vlcustocont"]);
        _vlcustofin = AlterarTipo<decimal>(leitor["Vlcustofin"]);
        _vlcustoreal = AlterarTipo<decimal>(leitor["Vlcustoreal"]);
        _vlcustorep = AlterarTipo<decimal?>(leitor["Vlcustorep"]);
        _vldesccustocmv = AlterarTipo<decimal?>(leitor["Vldesccustocmv"]);
        _vldescreducaocofins = AlterarTipo<decimal?>(leitor["Vldescreducaocofins"]);
        _vldescreducaopis = AlterarTipo<decimal?>(leitor["Vldescreducaopis"]);
        _vldescrodape = AlterarTipo<decimal?>(leitor["Vldescrodape"]);
        _vldescsuframa = AlterarTipo<decimal?>(leitor["Vldescsuframa"]);
        _vldifaliquotas = AlterarTipo<decimal?>(leitor["Vldifaliquotas"]);
        _vlfcppart = AlterarTipo<decimal?>(leitor["Vlfcppart"]);
        _vlicmsdifaliqpart = AlterarTipo<decimal?>(leitor["Vlicmsdifaliqpart"]);
        _vlicmspart = AlterarTipo<decimal?>(leitor["Vlicmspart"]);
        _vlicmspartdest = AlterarTipo<decimal?>(leitor["Vlicmspartdest"]);
        _vlicmspartrem = AlterarTipo<decimal?>(leitor["Vlicmspartrem"]);
        _vlipi = AlterarTipo<decimal?>(leitor["Vlipi"]);
        _vliss = AlterarTipo<decimal?>(leitor["Vliss"]);
        _vlitemtributos = AlterarTipo<decimal?>(leitor["Vlitemtributos"]);
        _vlitemtributosestadual = AlterarTipo<decimal?>(leitor["Vlitemtributosestadual"]);
        _vlpis = AlterarTipo<decimal?>(leitor["Vlpis"]);
        _vlsubtotitem = AlterarTipo<decimal?>(leitor["Vlsubtotitem"]);
        _versaoservicopartilha = AlterarTipo<string>(leitor["Versaoservicopartilha"]);
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
        _codagregacao = AlterarTipo<decimal?>(leitor["Codagregacao"]);
        _cnpjfabricante = AlterarTipo<string>(leitor["Cnpjfabricante"]);
        _indescalarelevante = AlterarTipo<string>(leitor["Indescalarelevante"]);
        _fabricante = AlterarTipo<string>(leitor["Fabricante"]);
        _perfcpsn = AlterarTipo<decimal?>(leitor["Perfcpsn"]);
        _vlcredfcpicmssn = AlterarTipo<decimal?>(leitor["Vlcredfcpicmssn"]);
        _numlote = AlterarTipo<string>(leitor["Numlote"]);
        _custoultent = AlterarTipo<decimal?>(leitor["Custoultent"]);
        _valorultent = AlterarTipo<decimal?>(leitor["Valorultent"]);
        _baseipiecf = AlterarTipo<decimal?>(leitor["Baseipiecf"]);
        _percipiecf = AlterarTipo<decimal?>(leitor["Percipiecf"]);
        _vlipiecf = AlterarTipo<decimal?>(leitor["Vlipiecf"]);
        _percredbaseefet = AlterarTipo<decimal?>(leitor["Percredbaseefet"]);
        _vlbaseefet = AlterarTipo<decimal?>(leitor["Vlbaseefet"]);
        _percicmsefet = AlterarTipo<decimal?>(leitor["Percicmsefet"]);
        _vlicmsefet = AlterarTipo<decimal?>(leitor["Vlicmsefet"]);
        _vldescontomotoroferta = AlterarTipo<decimal?>(leitor["Vldescontomotoroferta"]);
        _numccf = AlterarTipo<decimal?>(leitor["Numccf"]);
        _totalizador = AlterarTipo<string>(leitor["Totalizador"]);
        _md5paf = AlterarTipo<string>(leitor["Md5paf"]);
        _numseqitem = AlterarTipo<decimal?>(leitor["Numseq"]);
        _poriginal = AlterarTipo<decimal?>(leitor["Poriginal"]);
        _data = AlterarTipo<DateTime?>(leitor["Data"]);
        _basebcr = AlterarTipo<decimal?>(leitor["Basebcr"]);
        _stbcr = AlterarTipo<decimal?>(leitor["Stbcr"]);
        _codsittribpiscofins = AlterarTipo<decimal?>(leitor["Codsittribpiscofins"]);
        _vldescicmisencao = AlterarTipo<decimal?>(leitor["Vldescicmisencao"]);
        _perdescisentoicms = AlterarTipo<decimal?>(leitor["Perdescisentoicms"]);
        _vlicmsdesoneracao = AlterarTipo<decimal?>(leitor["Vlicmsdesoneracao"]);
        _codmotivoicmsdesonerado = AlterarTipo<string>(leitor["Codmotivoicmsdesonerado"]);
        _baseicmsbcr = AlterarTipo<decimal?>(leitor["Baseicmsbcr"]);
        _vlicmsbcr = AlterarTipo<decimal?>(leitor["Vlicmsbcr"]);
        _codfornec = AlterarTipo<decimal>(leitor["Codfornec"]);
        _vldescitem = AlterarTipo<decimal?>(leitor["Vldescitem"]);
        _excluiricmsbasepiscofins = AlterarTipo<string>(leitor[RO_EXCLUIRICMSBASEPISCOFINS]);
        Qbcmonoret = AlterarTipo<decimal?>(leitor[RO_QBCMONORET]);
        Adremicmsret = AlterarTipo<decimal?>(leitor[RO_ADREMICMSRET]);
        Vicmsmonoret = AlterarTipo<decimal?>(leitor[RO_VICMSMONORET]);
    }

}