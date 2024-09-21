

////// // namespace nwErp.Entidades.Winthor;

// // namespace nwErp.Api.Modelos;

[Serializable]
public class PCMOVCOMPLE : GerenteDePropriedades, IEntidade
{
    private decimal? _aliqfcp;

    private decimal? _aliqicms1ultentant;

    private decimal? _aliqicms1ret;

    private decimal? _aliqicms2ultentant;

    private decimal? _aliqinternadest;

    private decimal? _aliqinterorigpart;

    private decimal? _aliqreducaocofins;

    private decimal? _aliqreducaopis;

    private decimal? _anp;

    private string _aplicpercivapautaicmsantecip;

    private string _aplicredbaseivapliq;

    private string _aplicredbaseivapliqbcr;

    private string _aproveitacredicmscont;

    private string _aproveitacredpiscofinscont;

    private decimal? _basebcrant;

    private decimal? _basecredpresumido;

    private decimal? _baseicmsantecipado;

    private decimal? _baseipioutras;

    private decimal? _basestoutras;

    private string _bnfnaocalculaicms;

    private string _bonific;

    private string _calccredipicont;

    private string _calctribmanual;

    private string _cnaedesoneracao;

    private string _codcest;

    private decimal? _codcnaeserv;

    private decimal? _codemitenteitempedido;

    private string _codenqipi;

    private decimal? _codfiguradesonicms;

    private string _codfilialdest;

    private decimal? _codfornec;

    private decimal? _codlinhaprazo;

    private string _codmotivoicmsdesonerado;

    private decimal? _codprodacabcesta;

    private decimal? _codprodgnre;

    private string _codsittribicmsfretefob;

    private decimal? _codsittribipi;

    private decimal? _codsittribpiscofinsfretefob;

    private string _codsittribst;

    private string _codtiposervico;

    private decimal? _codtribpiscofins;

    private decimal? _cofinsretido;

    private string _concedermaiorcomissreg;

    private string _considerastguiacusto;

    private string _considerastguiacustocont;

    private string _considerastnfcusto;

    private string _considerastnfcustocont;

    private string _consiisuspensobaseicms;

    private string _consipisuspensobaseicms;

    private string _controlarfci;

    private decimal? _csllretido;

    private decimal? _custofinsemst;

    private decimal? _custofinsemstant;

    private decimal? _custonfsemstguiaultent;

    private decimal? _custonfsemstguiaultentant;

    private decimal? _custoultentcont;

    private decimal? _custoultentcontant;

    private decimal? _custoultentfinsemst;

    private decimal? _custoultentfinsemstant;

    private decimal? _custoultentsemst;

    private decimal? _custoultentsemstant;

    private string _deduziricmsimportacao;

    private decimal? _descprecofab;

    private string _descricaonfcomp;

    private DateTime? _dtestorno;

    private DateTime? _dtregistro;

    private decimal? _eancodprod;

    private string _enderecado;

    private string _enviaraliqreducaopiscofins;

    private string _extipi;

    private decimal? _fatorconvcom;

    private decimal? _fatorconvtrib;

    private string _gerabasepiscofinssemaliq;

    private string _ibanc;

    private string _icmspauta;

    private decimal? _idvenda;

    private string _ipiporvalor;

    private decimal? _irretido;

    private decimal? _ivaultentant;

    private string _numdrawback;

    private string _numeroprocessoserv;

    private string _numerorecopi;

    private string _numfci;

    private decimal? _numinvent;

    private decimal? _numlista;

    private string _numpedcli;

    private decimal? _numrecopi;

    private decimal? _numseqitemcontrato;

    private string _numseriesat;

    private decimal _numtransitem;

    private decimal? _numtransitemdev;

    private decimal? _numtransnumeroserie;

    private decimal? _numtranstransforig;

    private string _origmerctrib;

    private string _participagiro;

    private decimal? _percaduaneira;

    private decimal? _percaduaneiracusto;

    private decimal? _percafrmm;

    private decimal? _percafrmmcusto;

    private decimal? _percaliqextguiaultentant;

    private decimal? _percaltercustoent;

    private decimal? _percantidumping;

    private decimal? _percantidumpingcusto;

    private decimal? _percbaseredpart;

    private decimal? _percbonific;

    private decimal? _perccapatazia;

    private decimal? _perccapataziacusto;

    private decimal? _perccargatribmedia;

    private decimal? _perccargatribmediaicmsantecip;

    private decimal? _perccargefetiv;

    private decimal? _percconteudoimpfci;

    private decimal? _percdescabatimento;

    private decimal? _percdescindustria;

    private decimal? _percdesoneracao;

    private decimal? _percdespdentronfcusto;

    private decimal? _percfretenfcusto;

    private decimal? _percicms;

    private decimal? _percicmsbaseicmsantecipado;

    private decimal? _percicmscustofretefob;

    private decimal? _percicmsfretefob;

    private decimal? _percicmsfretefobicmsantecip;

    private decimal? _percicmsfretefobstultentant;

    private decimal? _percicmsredfretefob;

    private decimal? _percicmssimplesnac;

    private decimal? _percipioutras;

    private decimal? _percipisuspenso;

    private decimal? _percmvaorig;

    private decimal? _percmvaorigicmsantecip;

    private decimal? _percofinsbkp;

    private decimal? _percofinscalcdi;

    private decimal? _percofinsfretefob;

    private decimal? _percoutrasdespimp;

    private decimal? _percoutrasdespimpcusto;

    private decimal? _percoutroscustoscusto;

    private decimal? _percpedagio;

    private decimal? _percprovpart;

    private decimal? _percredaliqipi;

    private decimal? _percredpmc;

    private decimal? _percretcprbserv;

    private decimal? _percretincidenciaserv;

    private decimal? _percretsobrevltotalcprbserv;

    private decimal? _percretsobrevltotalinciserv;

    private decimal? _percsegurocusto;

    private decimal? _percsiscomex;

    private decimal? _percsiscomexcusto;

    private decimal? _percstoutras;

    private decimal? _perdescfimcomiss;

    private decimal? _perdescinicomiss;

    private decimal? _perdifereimentoicms;

    private decimal? _perpisbkp;

    private decimal? _perpiscalcdi;

    private decimal? _perpisfretefob;

    private decimal? _pesoliqdi;

    private string _piscofinsdeduzido;

    private decimal? _pisretido;

    private decimal? _poriginal;

    private string _praca;

    private decimal? _precomaxconsum;

    private string _precoutilizadonfe;

    private string _proddescricaodanfe;

    private decimal? _ptabelacusto;

    private decimal? _qtdigitada;

    private decimal? _qtlitragem;

    private decimal? _qtperda;

    private decimal? _qtun;

    private decimal? _qtunitlicit;

    private decimal? _qt_entradamanif;

    private decimal? _redbasealiqexticmsantecip;

    private decimal? _redbaseivaicmsantecip;

    private decimal? _redbaseivaultentant;

    private string _regimeespecial;

    private string _reterinsscprbserv;

    private string _retervalorincser;

    private decimal? _stbcrant;

    private string _substancia;

    private string _sujdesoneracao;

    private decimal? _termposervico;

    private string _tipocalcst;

    private string _tipoprocessoserv;

    private string _unidadelicit;

    private string _unidadetrib;

    private string _usapiscofinslit;

    private string _usapmcbasest;

    private string _usaunidademaster;

    private string _utilizabasepiscofinssusp;

    private string _utilizacredredpiscofins;

    private string _versaoregistro;

    private decimal? _vladicionalbcicmsantecip;

    private decimal? _vladuaneiracusto;

    private decimal? _vlafrmm;

    private decimal? _vlafrmmcusto;

    private decimal? _vlaltercustoent;

    private decimal? _vlantidumping;

    private decimal? _vlantidumpingcusto;

    private decimal? _vlbasefrete;

    private decimal? _vlbaseicmsfretefob;

    private decimal? _vlbaseipisuspenso;

    private decimal? _vlbaseoutros;

    private decimal? _vlbasepartdest;

    private decimal? _vlbasepiscofinsbkp;

    private decimal? _vlbasepiscofinsfretefob;

    private decimal? _vlbasestdevfornec;

    private decimal? _vlcapatazia;

    private decimal? _vlcapataziacusto;

    private decimal? _vlcofinscalcdi;

    private decimal? _vlcofinsretido;

    private decimal? _vlcofinsretorgpub;

    private decimal? _vlcredcofinsbkp;

    private decimal? _vlcredcofinsfretefob;

    private decimal? _vlcredpisbkp;

    private decimal? _vlcredpisfretefob;

    private decimal? _vlcsllretido;

    private decimal? _vlcsllretorgpub;

    private decimal? _vldescabatimento;

    private decimal? _vldescontocusto;

    private decimal? _vldescorgaopub;

    private decimal? _vldescsociotorcedor;

    private decimal? _vldespdentronfcusto;

    private decimal? _vlfcppart;

    private decimal? _vlfreteconhecultentant;

    private decimal? _vlfretenfcusto;

    private decimal? _vlicms;

    private decimal? _vlicmsantecipado;

    private decimal? _vlicmscheio;

    private decimal? _vlicmscustofretefob;

    private decimal? _vlicmsdesoneracao;

    private decimal? _vlicmsdifaliqpart;

    private decimal? _vlicmsdiferido;

    private decimal? _vlicmsfretefob;

    private decimal? _vlicmspart;

    private decimal? _vlicmspartdest;

    private decimal? _vlicmspartrem;

    private decimal? _vliisuspenso;

    private decimal? _vlimportacaofci;

    private decimal? _vlipioutras;

    private decimal? _vlipisuspenso;

    private decimal? _vlirpjretorgpub;

    private decimal? _vlirretido;

    private decimal? _vlitemtributos;

    private decimal? _vlitemtributosest;

    private decimal? _vlitemtributosmunic;

    private decimal? _vloutrasdespimpcusto;

    private decimal? _vloutroscustos;

    private decimal? _vloutroscustoscusto;

    private decimal? _vlparcelaimpfci;

    private decimal? _vlpautaipi;

    private decimal? _vlpautapiscofins;

    private decimal? _vlpedagio;

    private decimal? _vlpiscalcdi;

    private decimal? _vlpisretido;

    private decimal? _vlpisretorgpub;

    private decimal? _vlredcmvsimplesnac;

    private decimal? _vlredpvendasimplesna;

    private decimal? _vlricmssimplesnac;

    private decimal? _vlsegurocusto;

    private decimal? _vlsiscomexcusto;

    private decimal? _vlstdevfornec;

    private decimal? _vlstguiaultentant;

    private decimal? _vlstoutras;

    private decimal? _vlstultentant;

    private decimal? _vlsubtotdesconto;

    private decimal? _vlsubtotitem;

    private static readonly string RO_NUMSEQORIG = "Numseqorig";

    private decimal? _numseqorig;

    private string _versaoservicopartilha;

    private decimal? _qtminatacvenda;

    private string _tipodescatacvenda;

    private decimal? _codoferta;

    private decimal? _peracrescimofuncep;

    private decimal? _vlbasefcpicms;

    private decimal? _vlacrescimofuncep;

    private decimal? _aliqicmsfecp;

    private decimal? _vlbasefcpst;

    private decimal? _vlfecp;

    private decimal? _vlbcfcpstret;

    private decimal? _perfcpstret;

    private decimal? _vlfcpstret;

    private string _codbeneficiofiscal;

    private decimal? _codagregacao;

    private string _cnpjfabricante;

    private string _fabricante;

    private string _indescalarelevante;

    private decimal? _perfcpsn;

    private decimal? _vlcredfcpicmssn;

    private string _descanp;

    private decimal? _pglp;

    private decimal? _pgni;

    private decimal? _pgnn;

    private decimal? _vpart;

    private decimal? _vlbaseipiecf;

    private decimal? _percipiecf;

    private decimal? _vlipiecf;

    private string _utilizoumotorcalculo;

    private decimal? _percredbaseefet;

    private decimal? _vlbaseefet;

    private decimal? _percicmsefet;

    private decimal? _vlicmsefet;

    private decimal? _numtransultentstant;

    private static readonly string RO_EXCLUIRICMSBASEPISCOFINS = "Excluiricmsbasepiscofins";

    private string _excluiricmsbasepiscofins;

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Aliqicms1ultentant
    {
        get
        {
            PropriedadeAcessada("Aliqicms1ultentant");
            return _aliqicms1ultentant;
        }
        set
        {
            PropriedadeModificada("Aliqicms1ultentant", value);
            _aliqicms1ultentant = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Aliqicms1ret
    {
        get
        {
            PropriedadeAcessada("Aliqicms1ret");
            return _aliqicms1ret;
        }
        set
        {
            PropriedadeModificada("Aliqicms1ret", value);
            _aliqicms1ret = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Aliqicms2ultentant
    {
        get
        {
            PropriedadeAcessada("Aliqicms2ultentant");
            return _aliqicms2ultentant;
        }
        set
        {
            PropriedadeModificada("Aliqicms2ultentant", value);
            _aliqicms2ultentant = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 9, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Aplicpercivapautaicmsantecip
    {
        get
        {
            PropriedadeAcessada("Aplicpercivapautaicmsantecip");
            return _aplicpercivapautaicmsantecip;
        }
        set
        {
            PropriedadeModificada("Aplicpercivapautaicmsantecip", value);
            _aplicpercivapautaicmsantecip = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Aplicredbaseivapliq
    {
        get
        {
            PropriedadeAcessada("Aplicredbaseivapliq");
            return _aplicredbaseivapliq;
        }
        set
        {
            PropriedadeModificada("Aplicredbaseivapliq", value);
            _aplicredbaseivapliq = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Aplicredbaseivapliqbcr
    {
        get
        {
            PropriedadeAcessada("Aplicredbaseivapliqbcr");
            return _aplicredbaseivapliqbcr;
        }
        set
        {
            PropriedadeModificada("Aplicredbaseivapliqbcr", value);
            _aplicredbaseivapliqbcr = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Aproveitacredicmscont
    {
        get
        {
            PropriedadeAcessada("Aproveitacredicmscont");
            return _aproveitacredicmscont;
        }
        set
        {
            PropriedadeModificada("Aproveitacredicmscont", value);
            _aproveitacredicmscont = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Aproveitacredpiscofinscont
    {
        get
        {
            PropriedadeAcessada("Aproveitacredpiscofinscont");
            return _aproveitacredpiscofinscont;
        }
        set
        {
            PropriedadeModificada("Aproveitacredpiscofinscont", value);
            _aproveitacredpiscofinscont = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Basebcrant
    {
        get
        {
            PropriedadeAcessada("Basebcrant");
            return _basebcrant;
        }
        set
        {
            PropriedadeModificada("Basebcrant", value);
            _basebcrant = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Basecredpresumido
    {
        get
        {
            PropriedadeAcessada("Basecredpresumido");
            return _basecredpresumido;
        }
        set
        {
            PropriedadeModificada("Basecredpresumido", value);
            _basecredpresumido = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Baseicmsantecipado
    {
        get
        {
            PropriedadeAcessada("Baseicmsantecipado");
            return _baseicmsantecipado;
        }
        set
        {
            PropriedadeModificada("Baseicmsantecipado", value);
            _baseicmsantecipado = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Baseipioutras
    {
        get
        {
            PropriedadeAcessada("Baseipioutras");
            return _baseipioutras;
        }
        set
        {
            PropriedadeModificada("Baseipioutras", value);
            _baseipioutras = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Basestoutras
    {
        get
        {
            PropriedadeAcessada("Basestoutras");
            return _basestoutras;
        }
        set
        {
            PropriedadeModificada("Basestoutras", value);
            _basestoutras = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Bnfnaocalculaicms
    {
        get
        {
            PropriedadeAcessada("Bnfnaocalculaicms");
            return _bnfnaocalculaicms;
        }
        set
        {
            PropriedadeModificada("Bnfnaocalculaicms", value);
            _bnfnaocalculaicms = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Calccredipicont
    {
        get
        {
            PropriedadeAcessada("Calccredipicont");
            return _calccredipicont;
        }
        set
        {
            PropriedadeModificada("Calccredipicont", value);
            _calccredipicont = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Calctribmanual
    {
        get
        {
            PropriedadeAcessada("Calctribmanual");
            return _calctribmanual;
        }
        set
        {
            PropriedadeModificada("Calctribmanual", value);
            _calctribmanual = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 60, Precisao = 0)]
    public string Cnaedesoneracao
    {
        get
        {
            PropriedadeAcessada("Cnaedesoneracao");
            return _cnaedesoneracao;
        }
        set
        {
            PropriedadeModificada("Cnaedesoneracao", value);
            _cnaedesoneracao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 7, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 20, Precisao = 0)]
    public decimal? Codcnaeserv
    {
        get
        {
            PropriedadeAcessada("Codcnaeserv");
            return _codcnaeserv;
        }
        set
        {
            PropriedadeModificada("Codcnaeserv", value);
            _codcnaeserv = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 3, Precisao = 0)]
    public string Codenqipi
    {
        get
        {
            PropriedadeAcessada("Codenqipi");
            return _codenqipi;
        }
        set
        {
            PropriedadeModificada("Codenqipi", value);
            _codenqipi = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfiguradesonicms
    {
        get
        {
            PropriedadeAcessada("Codfiguradesonicms");
            return _codfiguradesonicms;
        }
        set
        {
            PropriedadeModificada("Codfiguradesonicms", value);
            _codfiguradesonicms = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Codfilialdest
    {
        get
        {
            PropriedadeAcessada("Codfilialdest");
            return _codfilialdest;
        }
        set
        {
            PropriedadeModificada("Codfilialdest", value);
            _codfilialdest = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codfornec
    {
        get
        {
            PropriedadeAcessada("Codfornec");
            return _codfornec;
        }
        set
        {
            PropriedadeModificada("Codfornec", value);
            _codfornec = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codprodacabcesta
    {
        get
        {
            PropriedadeAcessada("Codprodacabcesta");
            return _codprodacabcesta;
        }
        set
        {
            PropriedadeModificada("Codprodacabcesta", value);
            _codprodacabcesta = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codprodgnre
    {
        get
        {
            PropriedadeAcessada("Codprodgnre");
            return _codprodgnre;
        }
        set
        {
            PropriedadeModificada("Codprodgnre", value);
            _codprodgnre = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 3, Precisao = 0)]
    public string Codsittribicmsfretefob
    {
        get
        {
            PropriedadeAcessada("Codsittribicmsfretefob");
            return _codsittribicmsfretefob;
        }
        set
        {
            PropriedadeModificada("Codsittribicmsfretefob", value);
            _codsittribicmsfretefob = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 3, Precisao = 0)]
    public decimal? Codsittribipi
    {
        get
        {
            PropriedadeAcessada("Codsittribipi");
            return _codsittribipi;
        }
        set
        {
            PropriedadeModificada("Codsittribipi", value);
            _codsittribipi = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 3, Precisao = 0)]
    public decimal? Codsittribpiscofinsfretefob
    {
        get
        {
            PropriedadeAcessada("Codsittribpiscofinsfretefob");
            return _codsittribpiscofinsfretefob;
        }
        set
        {
            PropriedadeModificada("Codsittribpiscofinsfretefob", value);
            _codsittribpiscofinsfretefob = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Codsittribst
    {
        get
        {
            PropriedadeAcessada("Codsittribst");
            return _codsittribst;
        }
        set
        {
            PropriedadeModificada("Codsittribst", value);
            _codsittribst = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 8, Precisao = 0)]
    public string Codtiposervico
    {
        get
        {
            PropriedadeAcessada("Codtiposervico");
            return _codtiposervico;
        }
        set
        {
            PropriedadeModificada("Codtiposervico", value);
            _codtiposervico = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 2)]
    public decimal? Cofinsretido
    {
        get
        {
            PropriedadeAcessada("Cofinsretido");
            return _cofinsretido;
        }
        set
        {
            PropriedadeModificada("Cofinsretido", value);
            _cofinsretido = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Considerastguiacusto
    {
        get
        {
            PropriedadeAcessada("Considerastguiacusto");
            return _considerastguiacusto;
        }
        set
        {
            PropriedadeModificada("Considerastguiacusto", value);
            _considerastguiacusto = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Considerastguiacustocont
    {
        get
        {
            PropriedadeAcessada("Considerastguiacustocont");
            return _considerastguiacustocont;
        }
        set
        {
            PropriedadeModificada("Considerastguiacustocont", value);
            _considerastguiacustocont = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Considerastnfcusto
    {
        get
        {
            PropriedadeAcessada("Considerastnfcusto");
            return _considerastnfcusto;
        }
        set
        {
            PropriedadeModificada("Considerastnfcusto", value);
            _considerastnfcusto = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Considerastnfcustocont
    {
        get
        {
            PropriedadeAcessada("Considerastnfcustocont");
            return _considerastnfcustocont;
        }
        set
        {
            PropriedadeModificada("Considerastnfcustocont", value);
            _considerastnfcustocont = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Consiisuspensobaseicms
    {
        get
        {
            PropriedadeAcessada("Consiisuspensobaseicms");
            return _consiisuspensobaseicms;
        }
        set
        {
            PropriedadeModificada("Consiisuspensobaseicms", value);
            _consiisuspensobaseicms = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Consipisuspensobaseicms
    {
        get
        {
            PropriedadeAcessada("Consipisuspensobaseicms");
            return _consipisuspensobaseicms;
        }
        set
        {
            PropriedadeModificada("Consipisuspensobaseicms", value);
            _consipisuspensobaseicms = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Controlarfci
    {
        get
        {
            PropriedadeAcessada("Controlarfci");
            return _controlarfci;
        }
        set
        {
            PropriedadeModificada("Controlarfci", value);
            _controlarfci = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 2)]
    public decimal? Csllretido
    {
        get
        {
            PropriedadeAcessada("Csllretido");
            return _csllretido;
        }
        set
        {
            PropriedadeModificada("Csllretido", value);
            _csllretido = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Custofinsemst
    {
        get
        {
            PropriedadeAcessada("Custofinsemst");
            return _custofinsemst;
        }
        set
        {
            PropriedadeModificada("Custofinsemst", value);
            _custofinsemst = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Custofinsemstant
    {
        get
        {
            PropriedadeAcessada("Custofinsemstant");
            return _custofinsemstant;
        }
        set
        {
            PropriedadeModificada("Custofinsemstant", value);
            _custofinsemstant = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Custonfsemstguiaultent
    {
        get
        {
            PropriedadeAcessada("Custonfsemstguiaultent");
            return _custonfsemstguiaultent;
        }
        set
        {
            PropriedadeModificada("Custonfsemstguiaultent", value);
            _custonfsemstguiaultent = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Custonfsemstguiaultentant
    {
        get
        {
            PropriedadeAcessada("Custonfsemstguiaultentant");
            return _custonfsemstguiaultentant;
        }
        set
        {
            PropriedadeModificada("Custonfsemstguiaultentant", value);
            _custonfsemstguiaultentant = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 22, Precisao = 6)]
    public decimal? Custoultentcont
    {
        get
        {
            PropriedadeAcessada("Custoultentcont");
            return _custoultentcont;
        }
        set
        {
            PropriedadeModificada("Custoultentcont", value);
            _custoultentcont = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 22, Precisao = 6)]
    public decimal? Custoultentcontant
    {
        get
        {
            PropriedadeAcessada("Custoultentcontant");
            return _custoultentcontant;
        }
        set
        {
            PropriedadeModificada("Custoultentcontant", value);
            _custoultentcontant = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Custoultentfinsemst
    {
        get
        {
            PropriedadeAcessada("Custoultentfinsemst");
            return _custoultentfinsemst;
        }
        set
        {
            PropriedadeModificada("Custoultentfinsemst", value);
            _custoultentfinsemst = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Custoultentfinsemstant
    {
        get
        {
            PropriedadeAcessada("Custoultentfinsemstant");
            return _custoultentfinsemstant;
        }
        set
        {
            PropriedadeModificada("Custoultentfinsemstant", value);
            _custoultentfinsemstant = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Custoultentsemst
    {
        get
        {
            PropriedadeAcessada("Custoultentsemst");
            return _custoultentsemst;
        }
        set
        {
            PropriedadeModificada("Custoultentsemst", value);
            _custoultentsemst = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Custoultentsemstant
    {
        get
        {
            PropriedadeAcessada("Custoultentsemstant");
            return _custoultentsemstant;
        }
        set
        {
            PropriedadeModificada("Custoultentsemstant", value);
            _custoultentsemstant = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Deduziricmsimportacao
    {
        get
        {
            PropriedadeAcessada("Deduziricmsimportacao");
            return _deduziricmsimportacao;
        }
        set
        {
            PropriedadeModificada("Deduziricmsimportacao", value);
            _deduziricmsimportacao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 120, Precisao = 0)]
    public string Descricaonfcomp
    {
        get
        {
            PropriedadeAcessada("Descricaonfcomp");
            return _descricaonfcomp;
        }
        set
        {
            PropriedadeModificada("Descricaonfcomp", value);
            _descricaonfcomp = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtestorno
    {
        get
        {
            PropriedadeAcessada("Dtestorno");
            return _dtestorno;
        }
        set
        {
            PropriedadeModificada("Dtestorno", value);
            _dtestorno = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtregistro
    {
        get
        {
            PropriedadeAcessada("Dtregistro");
            return _dtregistro;
        }
        set
        {
            PropriedadeModificada("Dtregistro", value);
            _dtregistro = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Enderecado
    {
        get
        {
            PropriedadeAcessada("Enderecado");
            return _enderecado;
        }
        set
        {
            PropriedadeModificada("Enderecado", value);
            _enderecado = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 3, Precisao = 0)]
    public string Extipi
    {
        get
        {
            PropriedadeAcessada("Extipi");
            return _extipi;
        }
        set
        {
            PropriedadeModificada("Extipi", value);
            _extipi = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 6)]
    public decimal? Fatorconvcom
    {
        get
        {
            PropriedadeAcessada("Fatorconvcom");
            return _fatorconvcom;
        }
        set
        {
            PropriedadeModificada("Fatorconvcom", value);
            _fatorconvcom = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 6)]
    public decimal? Fatorconvtrib
    {
        get
        {
            PropriedadeAcessada("Fatorconvtrib");
            return _fatorconvtrib;
        }
        set
        {
            PropriedadeModificada("Fatorconvtrib", value);
            _fatorconvtrib = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Gerabasepiscofinssemaliq
    {
        get
        {
            PropriedadeAcessada("Gerabasepiscofinssemaliq");
            return _gerabasepiscofinssemaliq;
        }
        set
        {
            PropriedadeModificada("Gerabasepiscofinssemaliq", value);
            _gerabasepiscofinssemaliq = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
    public string Ibanc
    {
        get
        {
            PropriedadeAcessada("Ibanc");
            return _ibanc;
        }
        set
        {
            PropriedadeModificada("Ibanc", value);
            _ibanc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Icmspauta
    {
        get
        {
            PropriedadeAcessada("Icmspauta");
            return _icmspauta;
        }
        set
        {
            PropriedadeModificada("Icmspauta", value);
            _icmspauta = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Ipiporvalor
    {
        get
        {
            PropriedadeAcessada("Ipiporvalor");
            return _ipiporvalor;
        }
        set
        {
            PropriedadeModificada("Ipiporvalor", value);
            _ipiporvalor = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 2)]
    public decimal? Irretido
    {
        get
        {
            PropriedadeAcessada("Irretido");
            return _irretido;
        }
        set
        {
            PropriedadeModificada("Irretido", value);
            _irretido = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Ivaultentant
    {
        get
        {
            PropriedadeAcessada("Ivaultentant");
            return _ivaultentant;
        }
        set
        {
            PropriedadeModificada("Ivaultentant", value);
            _ivaultentant = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
    public string Numdrawback
    {
        get
        {
            PropriedadeAcessada("Numdrawback");
            return _numdrawback;
        }
        set
        {
            PropriedadeModificada("Numdrawback", value);
            _numdrawback = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 100, Precisao = 0)]
    public string Numeroprocessoserv
    {
        get
        {
            PropriedadeAcessada("Numeroprocessoserv");
            return _numeroprocessoserv;
        }
        set
        {
            PropriedadeModificada("Numeroprocessoserv", value);
            _numeroprocessoserv = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 36, Precisao = 0)]
    public string Numfci
    {
        get
        {
            PropriedadeAcessada("Numfci");
            return _numfci;
        }
        set
        {
            PropriedadeModificada("Numfci", value);
            _numfci = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Numinvent
    {
        get
        {
            PropriedadeAcessada("Numinvent");
            return _numinvent;
        }
        set
        {
            PropriedadeModificada("Numinvent", value);
            _numinvent = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 15, Precisao = 0)]
    public string Numpedcli
    {
        get
        {
            PropriedadeAcessada("Numpedcli");
            return _numpedcli;
        }
        set
        {
            PropriedadeModificada("Numpedcli", value);
            _numpedcli = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 20, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 13, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 0)]
    public decimal Numtransitem
    {
        get
        {
            PropriedadeAcessada("Numtransitem");
            return _numtransitem;
        }
        set
        {
            PropriedadeModificada("Numtransitem", value);
            _numtransitem = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numtransitemdev
    {
        get
        {
            PropriedadeAcessada("Numtransitemdev");
            return _numtransitemdev;
        }
        set
        {
            PropriedadeModificada("Numtransitemdev", value);
            _numtransitemdev = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numtransnumeroserie
    {
        get
        {
            PropriedadeAcessada("Numtransnumeroserie");
            return _numtransnumeroserie;
        }
        set
        {
            PropriedadeModificada("Numtransnumeroserie", value);
            _numtransnumeroserie = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numtranstransforig
    {
        get
        {
            PropriedadeAcessada("Numtranstransforig");
            return _numtranstransforig;
        }
        set
        {
            PropriedadeModificada("Numtranstransforig", value);
            _numtranstransforig = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Percaduaneira
    {
        get
        {
            PropriedadeAcessada("Percaduaneira");
            return _percaduaneira;
        }
        set
        {
            PropriedadeModificada("Percaduaneira", value);
            _percaduaneira = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Percaduaneiracusto
    {
        get
        {
            PropriedadeAcessada("Percaduaneiracusto");
            return _percaduaneiracusto;
        }
        set
        {
            PropriedadeModificada("Percaduaneiracusto", value);
            _percaduaneiracusto = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Percafrmm
    {
        get
        {
            PropriedadeAcessada("Percafrmm");
            return _percafrmm;
        }
        set
        {
            PropriedadeModificada("Percafrmm", value);
            _percafrmm = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Percafrmmcusto
    {
        get
        {
            PropriedadeAcessada("Percafrmmcusto");
            return _percafrmmcusto;
        }
        set
        {
            PropriedadeModificada("Percafrmmcusto", value);
            _percafrmmcusto = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Percaliqextguiaultentant
    {
        get
        {
            PropriedadeAcessada("Percaliqextguiaultentant");
            return _percaliqextguiaultentant;
        }
        set
        {
            PropriedadeModificada("Percaliqextguiaultentant", value);
            _percaliqextguiaultentant = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 2)]
    public decimal? Percaltercustoent
    {
        get
        {
            PropriedadeAcessada("Percaltercustoent");
            return _percaltercustoent;
        }
        set
        {
            PropriedadeModificada("Percaltercustoent", value);
            _percaltercustoent = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Percantidumping
    {
        get
        {
            PropriedadeAcessada("Percantidumping");
            return _percantidumping;
        }
        set
        {
            PropriedadeModificada("Percantidumping", value);
            _percantidumping = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Percantidumpingcusto
    {
        get
        {
            PropriedadeAcessada("Percantidumpingcusto");
            return _percantidumpingcusto;
        }
        set
        {
            PropriedadeModificada("Percantidumpingcusto", value);
            _percantidumpingcusto = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 2)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Percbonific
    {
        get
        {
            PropriedadeAcessada("Percbonific");
            return _percbonific;
        }
        set
        {
            PropriedadeModificada("Percbonific", value);
            _percbonific = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Perccapatazia
    {
        get
        {
            PropriedadeAcessada("Perccapatazia");
            return _perccapatazia;
        }
        set
        {
            PropriedadeModificada("Perccapatazia", value);
            _perccapatazia = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Perccapataziacusto
    {
        get
        {
            PropriedadeAcessada("Perccapataziacusto");
            return _perccapataziacusto;
        }
        set
        {
            PropriedadeModificada("Perccapataziacusto", value);
            _perccapataziacusto = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Perccargatribmedia
    {
        get
        {
            PropriedadeAcessada("Perccargatribmedia");
            return _perccargatribmedia;
        }
        set
        {
            PropriedadeModificada("Perccargatribmedia", value);
            _perccargatribmedia = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Perccargatribmediaicmsantecip
    {
        get
        {
            PropriedadeAcessada("Perccargatribmediaicmsantecip");
            return _perccargatribmediaicmsantecip;
        }
        set
        {
            PropriedadeModificada("Perccargatribmediaicmsantecip", value);
            _perccargatribmediaicmsantecip = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 2)]
    public decimal? Perccargefetiv
    {
        get
        {
            PropriedadeAcessada("Perccargefetiv");
            return _perccargefetiv;
        }
        set
        {
            PropriedadeModificada("Perccargefetiv", value);
            _perccargefetiv = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 2)]
    public decimal? Percconteudoimpfci
    {
        get
        {
            PropriedadeAcessada("Percconteudoimpfci");
            return _percconteudoimpfci;
        }
        set
        {
            PropriedadeModificada("Percconteudoimpfci", value);
            _percconteudoimpfci = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 2)]
    public decimal? Percdesoneracao
    {
        get
        {
            PropriedadeAcessada("Percdesoneracao");
            return _percdesoneracao;
        }
        set
        {
            PropriedadeModificada("Percdesoneracao", value);
            _percdesoneracao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Percdespdentronfcusto
    {
        get
        {
            PropriedadeAcessada("Percdespdentronfcusto");
            return _percdespdentronfcusto;
        }
        set
        {
            PropriedadeModificada("Percdespdentronfcusto", value);
            _percdespdentronfcusto = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Percfretenfcusto
    {
        get
        {
            PropriedadeAcessada("Percfretenfcusto");
            return _percfretenfcusto;
        }
        set
        {
            PropriedadeModificada("Percfretenfcusto", value);
            _percfretenfcusto = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Percicmsbaseicmsantecipado
    {
        get
        {
            PropriedadeAcessada("Percicmsbaseicmsantecipado");
            return _percicmsbaseicmsantecipado;
        }
        set
        {
            PropriedadeModificada("Percicmsbaseicmsantecipado", value);
            _percicmsbaseicmsantecipado = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Percicmscustofretefob
    {
        get
        {
            PropriedadeAcessada("Percicmscustofretefob");
            return _percicmscustofretefob;
        }
        set
        {
            PropriedadeModificada("Percicmscustofretefob", value);
            _percicmscustofretefob = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Percicmsfretefob
    {
        get
        {
            PropriedadeAcessada("Percicmsfretefob");
            return _percicmsfretefob;
        }
        set
        {
            PropriedadeModificada("Percicmsfretefob", value);
            _percicmsfretefob = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Percicmsfretefobicmsantecip
    {
        get
        {
            PropriedadeAcessada("Percicmsfretefobicmsantecip");
            return _percicmsfretefobicmsantecip;
        }
        set
        {
            PropriedadeModificada("Percicmsfretefobicmsantecip", value);
            _percicmsfretefobicmsantecip = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Percicmsfretefobstultentant
    {
        get
        {
            PropriedadeAcessada("Percicmsfretefobstultentant");
            return _percicmsfretefobstultentant;
        }
        set
        {
            PropriedadeModificada("Percicmsfretefobstultentant", value);
            _percicmsfretefobstultentant = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Percicmsredfretefob
    {
        get
        {
            PropriedadeAcessada("Percicmsredfretefob");
            return _percicmsredfretefob;
        }
        set
        {
            PropriedadeModificada("Percicmsredfretefob", value);
            _percicmsredfretefob = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Percipisuspenso
    {
        get
        {
            PropriedadeAcessada("Percipisuspenso");
            return _percipisuspenso;
        }
        set
        {
            PropriedadeModificada("Percipisuspenso", value);
            _percipisuspenso = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Percmvaorig
    {
        get
        {
            PropriedadeAcessada("Percmvaorig");
            return _percmvaorig;
        }
        set
        {
            PropriedadeModificada("Percmvaorig", value);
            _percmvaorig = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Percmvaorigicmsantecip
    {
        get
        {
            PropriedadeAcessada("Percmvaorigicmsantecip");
            return _percmvaorigicmsantecip;
        }
        set
        {
            PropriedadeModificada("Percmvaorigicmsantecip", value);
            _percmvaorigicmsantecip = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Percofinsbkp
    {
        get
        {
            PropriedadeAcessada("Percofinsbkp");
            return _percofinsbkp;
        }
        set
        {
            PropriedadeModificada("Percofinsbkp", value);
            _percofinsbkp = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Percofinscalcdi
    {
        get
        {
            PropriedadeAcessada("Percofinscalcdi");
            return _percofinscalcdi;
        }
        set
        {
            PropriedadeModificada("Percofinscalcdi", value);
            _percofinscalcdi = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Percofinsfretefob
    {
        get
        {
            PropriedadeAcessada("Percofinsfretefob");
            return _percofinsfretefob;
        }
        set
        {
            PropriedadeModificada("Percofinsfretefob", value);
            _percofinsfretefob = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Percoutrasdespimp
    {
        get
        {
            PropriedadeAcessada("Percoutrasdespimp");
            return _percoutrasdespimp;
        }
        set
        {
            PropriedadeModificada("Percoutrasdespimp", value);
            _percoutrasdespimp = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Percoutrasdespimpcusto
    {
        get
        {
            PropriedadeAcessada("Percoutrasdespimpcusto");
            return _percoutrasdespimpcusto;
        }
        set
        {
            PropriedadeModificada("Percoutrasdespimpcusto", value);
            _percoutrasdespimpcusto = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Percoutroscustoscusto
    {
        get
        {
            PropriedadeAcessada("Percoutroscustoscusto");
            return _percoutroscustoscusto;
        }
        set
        {
            PropriedadeModificada("Percoutroscustoscusto", value);
            _percoutroscustoscusto = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Percpedagio
    {
        get
        {
            PropriedadeAcessada("Percpedagio");
            return _percpedagio;
        }
        set
        {
            PropriedadeModificada("Percpedagio", value);
            _percpedagio = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 2)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Percredpmc
    {
        get
        {
            PropriedadeAcessada("Percredpmc");
            return _percredpmc;
        }
        set
        {
            PropriedadeModificada("Percredpmc", value);
            _percredpmc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Percretcprbserv
    {
        get
        {
            PropriedadeAcessada("Percretcprbserv");
            return _percretcprbserv;
        }
        set
        {
            PropriedadeModificada("Percretcprbserv", value);
            _percretcprbserv = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Percretincidenciaserv
    {
        get
        {
            PropriedadeAcessada("Percretincidenciaserv");
            return _percretincidenciaserv;
        }
        set
        {
            PropriedadeModificada("Percretincidenciaserv", value);
            _percretincidenciaserv = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Percretsobrevltotalcprbserv
    {
        get
        {
            PropriedadeAcessada("Percretsobrevltotalcprbserv");
            return _percretsobrevltotalcprbserv;
        }
        set
        {
            PropriedadeModificada("Percretsobrevltotalcprbserv", value);
            _percretsobrevltotalcprbserv = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Percretsobrevltotalinciserv
    {
        get
        {
            PropriedadeAcessada("Percretsobrevltotalinciserv");
            return _percretsobrevltotalinciserv;
        }
        set
        {
            PropriedadeModificada("Percretsobrevltotalinciserv", value);
            _percretsobrevltotalinciserv = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Percsegurocusto
    {
        get
        {
            PropriedadeAcessada("Percsegurocusto");
            return _percsegurocusto;
        }
        set
        {
            PropriedadeModificada("Percsegurocusto", value);
            _percsegurocusto = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Percsiscomex
    {
        get
        {
            PropriedadeAcessada("Percsiscomex");
            return _percsiscomex;
        }
        set
        {
            PropriedadeModificada("Percsiscomex", value);
            _percsiscomex = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Percsiscomexcusto
    {
        get
        {
            PropriedadeAcessada("Percsiscomexcusto");
            return _percsiscomexcusto;
        }
        set
        {
            PropriedadeModificada("Percsiscomexcusto", value);
            _percsiscomexcusto = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Percstoutras
    {
        get
        {
            PropriedadeAcessada("Percstoutras");
            return _percstoutras;
        }
        set
        {
            PropriedadeModificada("Percstoutras", value);
            _percstoutras = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Perpisbkp
    {
        get
        {
            PropriedadeAcessada("Perpisbkp");
            return _perpisbkp;
        }
        set
        {
            PropriedadeModificada("Perpisbkp", value);
            _perpisbkp = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Perpiscalcdi
    {
        get
        {
            PropriedadeAcessada("Perpiscalcdi");
            return _perpiscalcdi;
        }
        set
        {
            PropriedadeModificada("Perpiscalcdi", value);
            _perpiscalcdi = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Perpisfretefob
    {
        get
        {
            PropriedadeAcessada("Perpisfretefob");
            return _perpisfretefob;
        }
        set
        {
            PropriedadeModificada("Perpisfretefob", value);
            _perpisfretefob = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 6)]
    public decimal? Pesoliqdi
    {
        get
        {
            PropriedadeAcessada("Pesoliqdi");
            return _pesoliqdi;
        }
        set
        {
            PropriedadeModificada("Pesoliqdi", value);
            _pesoliqdi = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 2)]
    public decimal? Pisretido
    {
        get
        {
            PropriedadeAcessada("Pisretido");
            return _pisretido;
        }
        set
        {
            PropriedadeModificada("Pisretido", value);
            _pisretido = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
    public string Praca
    {
        get
        {
            PropriedadeAcessada("Praca");
            return _praca;
        }
        set
        {
            PropriedadeModificada("Praca", value);
            _praca = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Precoutilizadonfe
    {
        get
        {
            PropriedadeAcessada("Precoutilizadonfe");
            return _precoutilizadonfe;
        }
        set
        {
            PropriedadeModificada("Precoutilizadonfe", value);
            _precoutilizadonfe = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 500, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Ptabelacusto
    {
        get
        {
            PropriedadeAcessada("Ptabelacusto");
            return _ptabelacusto;
        }
        set
        {
            PropriedadeModificada("Ptabelacusto", value);
            _ptabelacusto = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Qtdigitada
    {
        get
        {
            PropriedadeAcessada("Qtdigitada");
            return _qtdigitada;
        }
        set
        {
            PropriedadeModificada("Qtdigitada", value);
            _qtdigitada = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 8)]
    public decimal? Qtperda
    {
        get
        {
            PropriedadeAcessada("Qtperda");
            return _qtperda;
        }
        set
        {
            PropriedadeModificada("Qtperda", value);
            _qtperda = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 16, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 22, Precisao = 8)]
    public decimal? Qtunitlicit
    {
        get
        {
            PropriedadeAcessada("Qtunitlicit");
            return _qtunitlicit;
        }
        set
        {
            PropriedadeModificada("Qtunitlicit", value);
            _qtunitlicit = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 20, Precisao = 8)]
    public decimal? Qt_Entradamanif
    {
        get
        {
            PropriedadeAcessada("Qt_Entradamanif");
            return _qt_entradamanif;
        }
        set
        {
            PropriedadeModificada("Qt_Entradamanif", value);
            _qt_entradamanif = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Redbasealiqexticmsantecip
    {
        get
        {
            PropriedadeAcessada("Redbasealiqexticmsantecip");
            return _redbasealiqexticmsantecip;
        }
        set
        {
            PropriedadeModificada("Redbasealiqexticmsantecip", value);
            _redbasealiqexticmsantecip = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Redbaseivaicmsantecip
    {
        get
        {
            PropriedadeAcessada("Redbaseivaicmsantecip");
            return _redbaseivaicmsantecip;
        }
        set
        {
            PropriedadeModificada("Redbaseivaicmsantecip", value);
            _redbaseivaicmsantecip = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Redbaseivaultentant
    {
        get
        {
            PropriedadeAcessada("Redbaseivaultentant");
            return _redbaseivaultentant;
        }
        set
        {
            PropriedadeModificada("Redbaseivaultentant", value);
            _redbaseivaultentant = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Regimeespecial
    {
        get
        {
            PropriedadeAcessada("Regimeespecial");
            return _regimeespecial;
        }
        set
        {
            PropriedadeModificada("Regimeespecial", value);
            _regimeespecial = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Reterinsscprbserv
    {
        get
        {
            PropriedadeAcessada("Reterinsscprbserv");
            return _reterinsscprbserv;
        }
        set
        {
            PropriedadeModificada("Reterinsscprbserv", value);
            _reterinsscprbserv = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Retervalorincser
    {
        get
        {
            PropriedadeAcessada("Retervalorincser");
            return _retervalorincser;
        }
        set
        {
            PropriedadeModificada("Retervalorincser", value);
            _retervalorincser = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Stbcrant
    {
        get
        {
            PropriedadeAcessada("Stbcrant");
            return _stbcrant;
        }
        set
        {
            PropriedadeModificada("Stbcrant", value);
            _stbcrant = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 10, Precisao = 0)]
    public string Substancia
    {
        get
        {
            PropriedadeAcessada("Substancia");
            return _substancia;
        }
        set
        {
            PropriedadeModificada("Substancia", value);
            _substancia = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Sujdesoneracao
    {
        get
        {
            PropriedadeAcessada("Sujdesoneracao");
            return _sujdesoneracao;
        }
        set
        {
            PropriedadeModificada("Sujdesoneracao", value);
            _sujdesoneracao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Termposervico
    {
        get
        {
            PropriedadeAcessada("Termposervico");
            return _termposervico;
        }
        set
        {
            PropriedadeModificada("Termposervico", value);
            _termposervico = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Tipocalcst
    {
        get
        {
            PropriedadeAcessada("Tipocalcst");
            return _tipocalcst;
        }
        set
        {
            PropriedadeModificada("Tipocalcst", value);
            _tipocalcst = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Tipoprocessoserv
    {
        get
        {
            PropriedadeAcessada("Tipoprocessoserv");
            return _tipoprocessoserv;
        }
        set
        {
            PropriedadeModificada("Tipoprocessoserv", value);
            _tipoprocessoserv = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Unidadelicit
    {
        get
        {
            PropriedadeAcessada("Unidadelicit");
            return _unidadelicit;
        }
        set
        {
            PropriedadeModificada("Unidadelicit", value);
            _unidadelicit = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 6, Precisao = 0)]
    public string Unidadetrib
    {
        get
        {
            PropriedadeAcessada("Unidadetrib");
            return _unidadetrib;
        }
        set
        {
            PropriedadeModificada("Unidadetrib", value);
            _unidadetrib = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Usapmcbasest
    {
        get
        {
            PropriedadeAcessada("Usapmcbasest");
            return _usapmcbasest;
        }
        set
        {
            PropriedadeModificada("Usapmcbasest", value);
            _usapmcbasest = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Utilizabasepiscofinssusp
    {
        get
        {
            PropriedadeAcessada("Utilizabasepiscofinssusp");
            return _utilizabasepiscofinssusp;
        }
        set
        {
            PropriedadeModificada("Utilizabasepiscofinssusp", value);
            _utilizabasepiscofinssusp = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Utilizacredredpiscofins
    {
        get
        {
            PropriedadeAcessada("Utilizacredredpiscofins");
            return _utilizacredredpiscofins;
        }
        set
        {
            PropriedadeModificada("Utilizacredredpiscofins", value);
            _utilizacredredpiscofins = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 10, Precisao = 0)]
    public string Versaoregistro
    {
        get
        {
            PropriedadeAcessada("Versaoregistro");
            return _versaoregistro;
        }
        set
        {
            PropriedadeModificada("Versaoregistro", value);
            _versaoregistro = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vladicionalbcicmsantecip
    {
        get
        {
            PropriedadeAcessada("Vladicionalbcicmsantecip");
            return _vladicionalbcicmsantecip;
        }
        set
        {
            PropriedadeModificada("Vladicionalbcicmsantecip", value);
            _vladicionalbcicmsantecip = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vladuaneiracusto
    {
        get
        {
            PropriedadeAcessada("Vladuaneiracusto");
            return _vladuaneiracusto;
        }
        set
        {
            PropriedadeModificada("Vladuaneiracusto", value);
            _vladuaneiracusto = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlafrmm
    {
        get
        {
            PropriedadeAcessada("Vlafrmm");
            return _vlafrmm;
        }
        set
        {
            PropriedadeModificada("Vlafrmm", value);
            _vlafrmm = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlafrmmcusto
    {
        get
        {
            PropriedadeAcessada("Vlafrmmcusto");
            return _vlafrmmcusto;
        }
        set
        {
            PropriedadeModificada("Vlafrmmcusto", value);
            _vlafrmmcusto = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlaltercustoent
    {
        get
        {
            PropriedadeAcessada("Vlaltercustoent");
            return _vlaltercustoent;
        }
        set
        {
            PropriedadeModificada("Vlaltercustoent", value);
            _vlaltercustoent = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlantidumping
    {
        get
        {
            PropriedadeAcessada("Vlantidumping");
            return _vlantidumping;
        }
        set
        {
            PropriedadeModificada("Vlantidumping", value);
            _vlantidumping = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlantidumpingcusto
    {
        get
        {
            PropriedadeAcessada("Vlantidumpingcusto");
            return _vlantidumpingcusto;
        }
        set
        {
            PropriedadeModificada("Vlantidumpingcusto", value);
            _vlantidumpingcusto = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlbasefrete
    {
        get
        {
            PropriedadeAcessada("Vlbasefrete");
            return _vlbasefrete;
        }
        set
        {
            PropriedadeModificada("Vlbasefrete", value);
            _vlbasefrete = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlbaseicmsfretefob
    {
        get
        {
            PropriedadeAcessada("Vlbaseicmsfretefob");
            return _vlbaseicmsfretefob;
        }
        set
        {
            PropriedadeModificada("Vlbaseicmsfretefob", value);
            _vlbaseicmsfretefob = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlbaseipisuspenso
    {
        get
        {
            PropriedadeAcessada("Vlbaseipisuspenso");
            return _vlbaseipisuspenso;
        }
        set
        {
            PropriedadeModificada("Vlbaseipisuspenso", value);
            _vlbaseipisuspenso = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlbaseoutros
    {
        get
        {
            PropriedadeAcessada("Vlbaseoutros");
            return _vlbaseoutros;
        }
        set
        {
            PropriedadeModificada("Vlbaseoutros", value);
            _vlbaseoutros = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlbasepiscofinsbkp
    {
        get
        {
            PropriedadeAcessada("Vlbasepiscofinsbkp");
            return _vlbasepiscofinsbkp;
        }
        set
        {
            PropriedadeModificada("Vlbasepiscofinsbkp", value);
            _vlbasepiscofinsbkp = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlbasepiscofinsfretefob
    {
        get
        {
            PropriedadeAcessada("Vlbasepiscofinsfretefob");
            return _vlbasepiscofinsfretefob;
        }
        set
        {
            PropriedadeModificada("Vlbasepiscofinsfretefob", value);
            _vlbasepiscofinsfretefob = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlbasestdevfornec
    {
        get
        {
            PropriedadeAcessada("Vlbasestdevfornec");
            return _vlbasestdevfornec;
        }
        set
        {
            PropriedadeModificada("Vlbasestdevfornec", value);
            _vlbasestdevfornec = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlcapatazia
    {
        get
        {
            PropriedadeAcessada("Vlcapatazia");
            return _vlcapatazia;
        }
        set
        {
            PropriedadeModificada("Vlcapatazia", value);
            _vlcapatazia = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlcapataziacusto
    {
        get
        {
            PropriedadeAcessada("Vlcapataziacusto");
            return _vlcapataziacusto;
        }
        set
        {
            PropriedadeModificada("Vlcapataziacusto", value);
            _vlcapataziacusto = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlcofinscalcdi
    {
        get
        {
            PropriedadeAcessada("Vlcofinscalcdi");
            return _vlcofinscalcdi;
        }
        set
        {
            PropriedadeModificada("Vlcofinscalcdi", value);
            _vlcofinscalcdi = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlcofinsretido
    {
        get
        {
            PropriedadeAcessada("Vlcofinsretido");
            return _vlcofinsretido;
        }
        set
        {
            PropriedadeModificada("Vlcofinsretido", value);
            _vlcofinsretido = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlcofinsretorgpub
    {
        get
        {
            PropriedadeAcessada("Vlcofinsretorgpub");
            return _vlcofinsretorgpub;
        }
        set
        {
            PropriedadeModificada("Vlcofinsretorgpub", value);
            _vlcofinsretorgpub = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlcredcofinsbkp
    {
        get
        {
            PropriedadeAcessada("Vlcredcofinsbkp");
            return _vlcredcofinsbkp;
        }
        set
        {
            PropriedadeModificada("Vlcredcofinsbkp", value);
            _vlcredcofinsbkp = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlcredcofinsfretefob
    {
        get
        {
            PropriedadeAcessada("Vlcredcofinsfretefob");
            return _vlcredcofinsfretefob;
        }
        set
        {
            PropriedadeModificada("Vlcredcofinsfretefob", value);
            _vlcredcofinsfretefob = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlcredpisbkp
    {
        get
        {
            PropriedadeAcessada("Vlcredpisbkp");
            return _vlcredpisbkp;
        }
        set
        {
            PropriedadeModificada("Vlcredpisbkp", value);
            _vlcredpisbkp = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlcredpisfretefob
    {
        get
        {
            PropriedadeAcessada("Vlcredpisfretefob");
            return _vlcredpisfretefob;
        }
        set
        {
            PropriedadeModificada("Vlcredpisfretefob", value);
            _vlcredpisfretefob = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlcsllretido
    {
        get
        {
            PropriedadeAcessada("Vlcsllretido");
            return _vlcsllretido;
        }
        set
        {
            PropriedadeModificada("Vlcsllretido", value);
            _vlcsllretido = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlcsllretorgpub
    {
        get
        {
            PropriedadeAcessada("Vlcsllretorgpub");
            return _vlcsllretorgpub;
        }
        set
        {
            PropriedadeModificada("Vlcsllretorgpub", value);
            _vlcsllretorgpub = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vldescontocusto
    {
        get
        {
            PropriedadeAcessada("Vldescontocusto");
            return _vldescontocusto;
        }
        set
        {
            PropriedadeModificada("Vldescontocusto", value);
            _vldescontocusto = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 2)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 2)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vldespdentronfcusto
    {
        get
        {
            PropriedadeAcessada("Vldespdentronfcusto");
            return _vldespdentronfcusto;
        }
        set
        {
            PropriedadeModificada("Vldespdentronfcusto", value);
            _vldespdentronfcusto = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlfreteconhecultentant
    {
        get
        {
            PropriedadeAcessada("Vlfreteconhecultentant");
            return _vlfreteconhecultentant;
        }
        set
        {
            PropriedadeModificada("Vlfreteconhecultentant", value);
            _vlfreteconhecultentant = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlfretenfcusto
    {
        get
        {
            PropriedadeAcessada("Vlfretenfcusto");
            return _vlfretenfcusto;
        }
        set
        {
            PropriedadeModificada("Vlfretenfcusto", value);
            _vlfretenfcusto = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlicms
    {
        get
        {
            PropriedadeAcessada("Vlicms");
            return _vlicms;
        }
        set
        {
            PropriedadeModificada("Vlicms", value);
            _vlicms = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlicmsantecipado
    {
        get
        {
            PropriedadeAcessada("Vlicmsantecipado");
            return _vlicmsantecipado;
        }
        set
        {
            PropriedadeModificada("Vlicmsantecipado", value);
            _vlicmsantecipado = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlicmscheio
    {
        get
        {
            PropriedadeAcessada("Vlicmscheio");
            return _vlicmscheio;
        }
        set
        {
            PropriedadeModificada("Vlicmscheio", value);
            _vlicmscheio = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlicmscustofretefob
    {
        get
        {
            PropriedadeAcessada("Vlicmscustofretefob");
            return _vlicmscustofretefob;
        }
        set
        {
            PropriedadeModificada("Vlicmscustofretefob", value);
            _vlicmscustofretefob = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 22, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlicmsdiferido
    {
        get
        {
            PropriedadeAcessada("Vlicmsdiferido");
            return _vlicmsdiferido;
        }
        set
        {
            PropriedadeModificada("Vlicmsdiferido", value);
            _vlicmsdiferido = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlicmsfretefob
    {
        get
        {
            PropriedadeAcessada("Vlicmsfretefob");
            return _vlicmsfretefob;
        }
        set
        {
            PropriedadeModificada("Vlicmsfretefob", value);
            _vlicmsfretefob = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vliisuspenso
    {
        get
        {
            PropriedadeAcessada("Vliisuspenso");
            return _vliisuspenso;
        }
        set
        {
            PropriedadeModificada("Vliisuspenso", value);
            _vliisuspenso = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlimportacaofci
    {
        get
        {
            PropriedadeAcessada("Vlimportacaofci");
            return _vlimportacaofci;
        }
        set
        {
            PropriedadeModificada("Vlimportacaofci", value);
            _vlimportacaofci = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlipisuspenso
    {
        get
        {
            PropriedadeAcessada("Vlipisuspenso");
            return _vlipisuspenso;
        }
        set
        {
            PropriedadeModificada("Vlipisuspenso", value);
            _vlipisuspenso = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlirpjretorgpub
    {
        get
        {
            PropriedadeAcessada("Vlirpjretorgpub");
            return _vlirpjretorgpub;
        }
        set
        {
            PropriedadeModificada("Vlirpjretorgpub", value);
            _vlirpjretorgpub = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlirretido
    {
        get
        {
            PropriedadeAcessada("Vlirretido");
            return _vlirretido;
        }
        set
        {
            PropriedadeModificada("Vlirretido", value);
            _vlirretido = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlitemtributosest
    {
        get
        {
            PropriedadeAcessada("Vlitemtributosest");
            return _vlitemtributosest;
        }
        set
        {
            PropriedadeModificada("Vlitemtributosest", value);
            _vlitemtributosest = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlitemtributosmunic
    {
        get
        {
            PropriedadeAcessada("Vlitemtributosmunic");
            return _vlitemtributosmunic;
        }
        set
        {
            PropriedadeModificada("Vlitemtributosmunic", value);
            _vlitemtributosmunic = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vloutrasdespimpcusto
    {
        get
        {
            PropriedadeAcessada("Vloutrasdespimpcusto");
            return _vloutrasdespimpcusto;
        }
        set
        {
            PropriedadeModificada("Vloutrasdespimpcusto", value);
            _vloutrasdespimpcusto = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vloutroscustos
    {
        get
        {
            PropriedadeAcessada("Vloutroscustos");
            return _vloutroscustos;
        }
        set
        {
            PropriedadeModificada("Vloutroscustos", value);
            _vloutroscustos = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vloutroscustoscusto
    {
        get
        {
            PropriedadeAcessada("Vloutroscustoscusto");
            return _vloutroscustoscusto;
        }
        set
        {
            PropriedadeModificada("Vloutroscustoscusto", value);
            _vloutroscustoscusto = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlparcelaimpfci
    {
        get
        {
            PropriedadeAcessada("Vlparcelaimpfci");
            return _vlparcelaimpfci;
        }
        set
        {
            PropriedadeModificada("Vlparcelaimpfci", value);
            _vlparcelaimpfci = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlpautaipi
    {
        get
        {
            PropriedadeAcessada("Vlpautaipi");
            return _vlpautaipi;
        }
        set
        {
            PropriedadeModificada("Vlpautaipi", value);
            _vlpautaipi = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlpautapiscofins
    {
        get
        {
            PropriedadeAcessada("Vlpautapiscofins");
            return _vlpautapiscofins;
        }
        set
        {
            PropriedadeModificada("Vlpautapiscofins", value);
            _vlpautapiscofins = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlpedagio
    {
        get
        {
            PropriedadeAcessada("Vlpedagio");
            return _vlpedagio;
        }
        set
        {
            PropriedadeModificada("Vlpedagio", value);
            _vlpedagio = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlpiscalcdi
    {
        get
        {
            PropriedadeAcessada("Vlpiscalcdi");
            return _vlpiscalcdi;
        }
        set
        {
            PropriedadeModificada("Vlpiscalcdi", value);
            _vlpiscalcdi = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlpisretido
    {
        get
        {
            PropriedadeAcessada("Vlpisretido");
            return _vlpisretido;
        }
        set
        {
            PropriedadeModificada("Vlpisretido", value);
            _vlpisretido = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlpisretorgpub
    {
        get
        {
            PropriedadeAcessada("Vlpisretorgpub");
            return _vlpisretorgpub;
        }
        set
        {
            PropriedadeModificada("Vlpisretorgpub", value);
            _vlpisretorgpub = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlsegurocusto
    {
        get
        {
            PropriedadeAcessada("Vlsegurocusto");
            return _vlsegurocusto;
        }
        set
        {
            PropriedadeModificada("Vlsegurocusto", value);
            _vlsegurocusto = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlsiscomexcusto
    {
        get
        {
            PropriedadeAcessada("Vlsiscomexcusto");
            return _vlsiscomexcusto;
        }
        set
        {
            PropriedadeModificada("Vlsiscomexcusto", value);
            _vlsiscomexcusto = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlstdevfornec
    {
        get
        {
            PropriedadeAcessada("Vlstdevfornec");
            return _vlstdevfornec;
        }
        set
        {
            PropriedadeModificada("Vlstdevfornec", value);
            _vlstdevfornec = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlstguiaultentant
    {
        get
        {
            PropriedadeAcessada("Vlstguiaultentant");
            return _vlstguiaultentant;
        }
        set
        {
            PropriedadeModificada("Vlstguiaultentant", value);
            _vlstguiaultentant = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlstoutras
    {
        get
        {
            PropriedadeAcessada("Vlstoutras");
            return _vlstoutras;
        }
        set
        {
            PropriedadeModificada("Vlstoutras", value);
            _vlstoutras = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlstultentant
    {
        get
        {
            PropriedadeAcessada("Vlstultentant");
            return _vlstultentant;
        }
        set
        {
            PropriedadeModificada("Vlstultentant", value);
            _vlstultentant = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 2)]
    public decimal? Vlsubtotdesconto
    {
        get
        {
            PropriedadeAcessada("Vlsubtotdesconto");
            return _vlsubtotdesconto;
        }
        set
        {
            PropriedadeModificada("Vlsubtotdesconto", value);
            _vlsubtotdesconto = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 20, Precisao = 0)]
    public decimal? Numseqorig
    {
        get
        {
            PropriedadeAcessada(RO_NUMSEQORIG);
            return _numseqorig;
        }
        set
        {
            PropriedadeModificada(RO_NUMSEQORIG, value);
            _numseqorig = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 10, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 10, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 20, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 18, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 60, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 95, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 7, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 7, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 7, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 23, Precisao = 10)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlbaseipiecf
    {
        get
        {
            PropriedadeAcessada("Vlbaseipiecf");
            return _vlbaseipiecf;
        }
        set
        {
            PropriedadeModificada("Vlbaseipiecf", value);
            _vlbaseipiecf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 16, Precisao = 0)]
    public decimal? Numtransultentstant
    {
        get
        {
            PropriedadeAcessada("Numtransultentstant");
            return _numtransultentstant;
        }
        set
        {
            PropriedadeModificada("Numtransultentstant", value);
            _numtransultentstant = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLE", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    public void InicializarAtributos()
    {
    }

    public string ObterNomeTabela()
    {
        return "PCMOVCOMPLE";
    }

    public IEntidade NovaInstancia()
    {
        return (IEntidade)GetType().GetConstructors()[0].Invoke(null);
    }

    public void CarregarPorDataReader(IDataReader leitor)
    {
        _aliqfcp = AlterarTipo<decimal?>(leitor["Aliqfcp"]);
        _aliqicms1ultentant = AlterarTipo<decimal?>(leitor["Aliqicms1ultentant"]);
        _aliqicms1ret = AlterarTipo<decimal?>(leitor["Aliqicms1ret"]);
        _aliqicms2ultentant = AlterarTipo<decimal?>(leitor["Aliqicms2ultentant"]);
        _aliqinternadest = AlterarTipo<decimal?>(leitor["Aliqinternadest"]);
        _aliqinterorigpart = AlterarTipo<decimal?>(leitor["Aliqinterorigpart"]);
        _aliqreducaocofins = AlterarTipo<decimal?>(leitor["Aliqreducaocofins"]);
        _aliqreducaopis = AlterarTipo<decimal?>(leitor["Aliqreducaopis"]);
        _anp = AlterarTipo<decimal?>(leitor["Anp"]);
        _aplicpercivapautaicmsantecip = AlterarTipo<string>(leitor["Aplicpercivapautaicmsantecip"]);
        _aplicredbaseivapliq = AlterarTipo<string>(leitor["Aplicredbaseivapliq"]);
        _aplicredbaseivapliqbcr = AlterarTipo<string>(leitor["Aplicredbaseivapliqbcr"]);
        _aproveitacredicmscont = AlterarTipo<string>(leitor["Aproveitacredicmscont"]);
        _aproveitacredpiscofinscont = AlterarTipo<string>(leitor["Aproveitacredpiscofinscont"]);
        _basebcrant = AlterarTipo<decimal?>(leitor["Basebcrant"]);
        _basecredpresumido = AlterarTipo<decimal?>(leitor["Basecredpresumido"]);
        _baseicmsantecipado = AlterarTipo<decimal?>(leitor["Baseicmsantecipado"]);
        _baseipioutras = AlterarTipo<decimal?>(leitor["Baseipioutras"]);
        _basestoutras = AlterarTipo<decimal?>(leitor["Basestoutras"]);
        _bnfnaocalculaicms = AlterarTipo<string>(leitor["Bnfnaocalculaicms"]);
        _bonific = AlterarTipo<string>(leitor["Bonific"]);
        _calccredipicont = AlterarTipo<string>(leitor["Calccredipicont"]);
        _calctribmanual = AlterarTipo<string>(leitor["Calctribmanual"]);
        _cnaedesoneracao = AlterarTipo<string>(leitor["Cnaedesoneracao"]);
        _codcest = AlterarTipo<string>(leitor["Codcest"]);
        _codcnaeserv = AlterarTipo<decimal?>(leitor["Codcnaeserv"]);
        _codemitenteitempedido = AlterarTipo<decimal?>(leitor["Codemitenteitempedido"]);
        _codenqipi = AlterarTipo<string>(leitor["Codenqipi"]);
        _codfiguradesonicms = AlterarTipo<decimal?>(leitor["Codfiguradesonicms"]);
        _codfilialdest = AlterarTipo<string>(leitor["Codfilialdest"]);
        _codfornec = AlterarTipo<decimal?>(leitor["Codfornec"]);
        _codlinhaprazo = AlterarTipo<decimal?>(leitor["Codlinhaprazo"]);
        _codmotivoicmsdesonerado = AlterarTipo<string>(leitor["Codmotivoicmsdesonerado"]);
        _codprodacabcesta = AlterarTipo<decimal?>(leitor["Codprodacabcesta"]);
        _codprodgnre = AlterarTipo<decimal?>(leitor["Codprodgnre"]);
        _codsittribicmsfretefob = AlterarTipo<string>(leitor["Codsittribicmsfretefob"]);
        _codsittribipi = AlterarTipo<decimal?>(leitor["Codsittribipi"]);
        _codsittribpiscofinsfretefob = AlterarTipo<decimal?>(leitor["Codsittribpiscofinsfretefob"]);
        _codsittribst = AlterarTipo<string>(leitor["Codsittribst"]);
        _codtiposervico = AlterarTipo<string>(leitor["Codtiposervico"]);
        _codtribpiscofins = AlterarTipo<decimal?>(leitor["Codtribpiscofins"]);
        _cofinsretido = AlterarTipo<decimal?>(leitor["Cofinsretido"]);
        _concedermaiorcomissreg = AlterarTipo<string>(leitor["Concedermaiorcomissreg"]);
        _considerastguiacusto = AlterarTipo<string>(leitor["Considerastguiacusto"]);
        _considerastguiacustocont = AlterarTipo<string>(leitor["Considerastguiacustocont"]);
        _considerastnfcusto = AlterarTipo<string>(leitor["Considerastnfcusto"]);
        _considerastnfcustocont = AlterarTipo<string>(leitor["Considerastnfcustocont"]);
        _consiisuspensobaseicms = AlterarTipo<string>(leitor["Consiisuspensobaseicms"]);
        _consipisuspensobaseicms = AlterarTipo<string>(leitor["Consipisuspensobaseicms"]);
        _controlarfci = AlterarTipo<string>(leitor["Controlarfci"]);
        _csllretido = AlterarTipo<decimal?>(leitor["Csllretido"]);
        _custofinsemst = AlterarTipo<decimal?>(leitor["Custofinsemst"]);
        _custofinsemstant = AlterarTipo<decimal?>(leitor["Custofinsemstant"]);
        _custonfsemstguiaultent = AlterarTipo<decimal?>(leitor["Custonfsemstguiaultent"]);
        _custonfsemstguiaultentant = AlterarTipo<decimal?>(leitor["Custonfsemstguiaultentant"]);
        _custoultentcont = AlterarTipo<decimal?>(leitor["Custoultentcont"]);
        _custoultentcontant = AlterarTipo<decimal?>(leitor["Custoultentcontant"]);
        _custoultentfinsemst = AlterarTipo<decimal?>(leitor["Custoultentfinsemst"]);
        _custoultentfinsemstant = AlterarTipo<decimal?>(leitor["Custoultentfinsemstant"]);
        _custoultentsemst = AlterarTipo<decimal?>(leitor["Custoultentsemst"]);
        _custoultentsemstant = AlterarTipo<decimal?>(leitor["Custoultentsemstant"]);
        _deduziricmsimportacao = AlterarTipo<string>(leitor["Deduziricmsimportacao"]);
        _descprecofab = AlterarTipo<decimal?>(leitor["Descprecofab"]);
        _descricaonfcomp = AlterarTipo<string>(leitor["Descricaonfcomp"]);
        _dtestorno = AlterarTipo<DateTime?>(leitor["Dtestorno"]);
        _dtregistro = AlterarTipo<DateTime?>(leitor["Dtregistro"]);
        _eancodprod = AlterarTipo<decimal?>(leitor["Eancodprod"]);
        _enderecado = AlterarTipo<string>(leitor["Enderecado"]);
        _enviaraliqreducaopiscofins = AlterarTipo<string>(leitor["Enviaraliqreducaopiscofins"]);
        _extipi = AlterarTipo<string>(leitor["Extipi"]);
        _fatorconvcom = AlterarTipo<decimal?>(leitor["Fatorconvcom"]);
        _fatorconvtrib = AlterarTipo<decimal?>(leitor["Fatorconvtrib"]);
        _gerabasepiscofinssemaliq = AlterarTipo<string>(leitor["Gerabasepiscofinssemaliq"]);
        _ibanc = AlterarTipo<string>(leitor["Ibanc"]);
        _icmspauta = AlterarTipo<string>(leitor["Icmspauta"]);
        _idvenda = AlterarTipo<decimal?>(leitor["Idvenda"]);
        _ipiporvalor = AlterarTipo<string>(leitor["Ipiporvalor"]);
        _irretido = AlterarTipo<decimal?>(leitor["Irretido"]);
        _ivaultentant = AlterarTipo<decimal?>(leitor["Ivaultentant"]);
        _numdrawback = AlterarTipo<string>(leitor["Numdrawback"]);
        _numeroprocessoserv = AlterarTipo<string>(leitor["Numeroprocessoserv"]);
        _numerorecopi = AlterarTipo<string>(leitor["Numerorecopi"]);
        _numfci = AlterarTipo<string>(leitor["Numfci"]);
        _numinvent = AlterarTipo<decimal?>(leitor["Numinvent"]);
        _numlista = AlterarTipo<decimal?>(leitor["Numlista"]);
        _numpedcli = AlterarTipo<string>(leitor["Numpedcli"]);
        _numrecopi = AlterarTipo<decimal?>(leitor["Numrecopi"]);
        _numseqitemcontrato = AlterarTipo<decimal?>(leitor["Numseqitemcontrato"]);
        _numseriesat = AlterarTipo<string>(leitor["Numseriesat"]);
        _numtransitem = AlterarTipo<decimal>(leitor["Numtransitem"]);
        _numtransitemdev = AlterarTipo<decimal?>(leitor["Numtransitemdev"]);
        _numtransnumeroserie = AlterarTipo<decimal?>(leitor["Numtransnumeroserie"]);
        _numtranstransforig = AlterarTipo<decimal?>(leitor["Numtranstransforig"]);
        _origmerctrib = AlterarTipo<string>(leitor["Origmerctrib"]);
        _participagiro = AlterarTipo<string>(leitor["Participagiro"]);
        _percaduaneira = AlterarTipo<decimal?>(leitor["Percaduaneira"]);
        _percaduaneiracusto = AlterarTipo<decimal?>(leitor["Percaduaneiracusto"]);
        _percafrmm = AlterarTipo<decimal?>(leitor["Percafrmm"]);
        _percafrmmcusto = AlterarTipo<decimal?>(leitor["Percafrmmcusto"]);
        _percaliqextguiaultentant = AlterarTipo<decimal?>(leitor["Percaliqextguiaultentant"]);
        _percaltercustoent = AlterarTipo<decimal?>(leitor["Percaltercustoent"]);
        _percantidumping = AlterarTipo<decimal?>(leitor["Percantidumping"]);
        _percantidumpingcusto = AlterarTipo<decimal?>(leitor["Percantidumpingcusto"]);
        _percbaseredpart = AlterarTipo<decimal?>(leitor["Percbaseredpart"]);
        _percbonific = AlterarTipo<decimal?>(leitor["Percbonific"]);
        _perccapatazia = AlterarTipo<decimal?>(leitor["Perccapatazia"]);
        _perccapataziacusto = AlterarTipo<decimal?>(leitor["Perccapataziacusto"]);
        _perccargatribmedia = AlterarTipo<decimal?>(leitor["Perccargatribmedia"]);
        _perccargatribmediaicmsantecip = AlterarTipo<decimal?>(leitor["Perccargatribmediaicmsantecip"]);
        _perccargefetiv = AlterarTipo<decimal?>(leitor["Perccargefetiv"]);
        _percconteudoimpfci = AlterarTipo<decimal?>(leitor["Percconteudoimpfci"]);
        _percdescabatimento = AlterarTipo<decimal?>(leitor["Percdescabatimento"]);
        _percdescindustria = AlterarTipo<decimal?>(leitor["Percdescindustria"]);
        _percdesoneracao = AlterarTipo<decimal?>(leitor["Percdesoneracao"]);
        _percdespdentronfcusto = AlterarTipo<decimal?>(leitor["Percdespdentronfcusto"]);
        _percfretenfcusto = AlterarTipo<decimal?>(leitor["Percfretenfcusto"]);
        _percicms = AlterarTipo<decimal?>(leitor["Percicms"]);
        _percicmsbaseicmsantecipado = AlterarTipo<decimal?>(leitor["Percicmsbaseicmsantecipado"]);
        _percicmscustofretefob = AlterarTipo<decimal?>(leitor["Percicmscustofretefob"]);
        _percicmsfretefob = AlterarTipo<decimal?>(leitor["Percicmsfretefob"]);
        _percicmsfretefobicmsantecip = AlterarTipo<decimal?>(leitor["Percicmsfretefobicmsantecip"]);
        _percicmsfretefobstultentant = AlterarTipo<decimal?>(leitor["Percicmsfretefobstultentant"]);
        _percicmsredfretefob = AlterarTipo<decimal?>(leitor["Percicmsredfretefob"]);
        _percicmssimplesnac = AlterarTipo<decimal?>(leitor["Percicmssimplesnac"]);
        _percipioutras = AlterarTipo<decimal?>(leitor["Percipioutras"]);
        _percipisuspenso = AlterarTipo<decimal?>(leitor["Percipisuspenso"]);
        _percmvaorig = AlterarTipo<decimal?>(leitor["Percmvaorig"]);
        _percmvaorigicmsantecip = AlterarTipo<decimal?>(leitor["Percmvaorigicmsantecip"]);
        _percofinsbkp = AlterarTipo<decimal?>(leitor["Percofinsbkp"]);
        _percofinscalcdi = AlterarTipo<decimal?>(leitor["Percofinscalcdi"]);
        _percofinsfretefob = AlterarTipo<decimal?>(leitor["Percofinsfretefob"]);
        _percoutrasdespimp = AlterarTipo<decimal?>(leitor["Percoutrasdespimp"]);
        _percoutrasdespimpcusto = AlterarTipo<decimal?>(leitor["Percoutrasdespimpcusto"]);
        _percoutroscustoscusto = AlterarTipo<decimal?>(leitor["Percoutroscustoscusto"]);
        _percpedagio = AlterarTipo<decimal?>(leitor["Percpedagio"]);
        _percprovpart = AlterarTipo<decimal?>(leitor["Percprovpart"]);
        _percredaliqipi = AlterarTipo<decimal?>(leitor["Percredaliqipi"]);
        _percredpmc = AlterarTipo<decimal?>(leitor["Percredpmc"]);
        _percretcprbserv = AlterarTipo<decimal?>(leitor["Percretcprbserv"]);
        _percretincidenciaserv = AlterarTipo<decimal?>(leitor["Percretincidenciaserv"]);
        _percretsobrevltotalcprbserv = AlterarTipo<decimal?>(leitor["Percretsobrevltotalcprbserv"]);
        _percretsobrevltotalinciserv = AlterarTipo<decimal?>(leitor["Percretsobrevltotalinciserv"]);
        _percsegurocusto = AlterarTipo<decimal?>(leitor["Percsegurocusto"]);
        _percsiscomex = AlterarTipo<decimal?>(leitor["Percsiscomex"]);
        _percsiscomexcusto = AlterarTipo<decimal?>(leitor["Percsiscomexcusto"]);
        _percstoutras = AlterarTipo<decimal?>(leitor["Percstoutras"]);
        _perdescfimcomiss = AlterarTipo<decimal?>(leitor["Perdescfimcomiss"]);
        _perdescinicomiss = AlterarTipo<decimal?>(leitor["Perdescinicomiss"]);
        _perdifereimentoicms = AlterarTipo<decimal?>(leitor["Perdifereimentoicms"]);
        _perpisbkp = AlterarTipo<decimal?>(leitor["Perpisbkp"]);
        _perpiscalcdi = AlterarTipo<decimal?>(leitor["Perpiscalcdi"]);
        _perpisfretefob = AlterarTipo<decimal?>(leitor["Perpisfretefob"]);
        _pesoliqdi = AlterarTipo<decimal?>(leitor["Pesoliqdi"]);
        _piscofinsdeduzido = AlterarTipo<string>(leitor["Piscofinsdeduzido"]);
        _pisretido = AlterarTipo<decimal?>(leitor["Pisretido"]);
        _poriginal = AlterarTipo<decimal?>(leitor["Poriginal"]);
        _praca = AlterarTipo<string>(leitor["Praca"]);
        _precomaxconsum = AlterarTipo<decimal?>(leitor["Precomaxconsum"]);
        _precoutilizadonfe = AlterarTipo<string>(leitor["Precoutilizadonfe"]);
        _proddescricaodanfe = AlterarTipo<string>(leitor["Proddescricaodanfe"]);
        _ptabelacusto = AlterarTipo<decimal?>(leitor["Ptabelacusto"]);
        _qtdigitada = AlterarTipo<decimal?>(leitor["Qtdigitada"]);
        _qtlitragem = AlterarTipo<decimal?>(leitor["Qtlitragem"]);
        _qtperda = AlterarTipo<decimal?>(leitor["Qtperda"]);
        _qtun = AlterarTipo<decimal?>(leitor["Qtun"]);
        _qtunitlicit = AlterarTipo<decimal?>(leitor["Qtunitlicit"]);
        _qt_entradamanif = AlterarTipo<decimal?>(leitor["Qt_Entradamanif"]);
        _redbasealiqexticmsantecip = AlterarTipo<decimal?>(leitor["Redbasealiqexticmsantecip"]);
        _redbaseivaicmsantecip = AlterarTipo<decimal?>(leitor["Redbaseivaicmsantecip"]);
        _redbaseivaultentant = AlterarTipo<decimal?>(leitor["Redbaseivaultentant"]);
        _regimeespecial = AlterarTipo<string>(leitor["Regimeespecial"]);
        _reterinsscprbserv = AlterarTipo<string>(leitor["Reterinsscprbserv"]);
        _retervalorincser = AlterarTipo<string>(leitor["Retervalorincser"]);
        _stbcrant = AlterarTipo<decimal?>(leitor["Stbcrant"]);
        _substancia = AlterarTipo<string>(leitor["Substancia"]);
        _sujdesoneracao = AlterarTipo<string>(leitor["Sujdesoneracao"]);
        _termposervico = AlterarTipo<decimal?>(leitor["Termposervico"]);
        _tipocalcst = AlterarTipo<string>(leitor["Tipocalcst"]);
        _tipoprocessoserv = AlterarTipo<string>(leitor["Tipoprocessoserv"]);
        _unidadelicit = AlterarTipo<string>(leitor["Unidadelicit"]);
        _unidadetrib = AlterarTipo<string>(leitor["Unidadetrib"]);
        _usapiscofinslit = AlterarTipo<string>(leitor["Usapiscofinslit"]);
        _usapmcbasest = AlterarTipo<string>(leitor["Usapmcbasest"]);
        _usaunidademaster = AlterarTipo<string>(leitor["Usaunidademaster"]);
        _utilizabasepiscofinssusp = AlterarTipo<string>(leitor["Utilizabasepiscofinssusp"]);
        _utilizacredredpiscofins = AlterarTipo<string>(leitor["Utilizacredredpiscofins"]);
        _versaoregistro = AlterarTipo<string>(leitor["Versaoregistro"]);
        _vladicionalbcicmsantecip = AlterarTipo<decimal?>(leitor["Vladicionalbcicmsantecip"]);
        _vladuaneiracusto = AlterarTipo<decimal?>(leitor["Vladuaneiracusto"]);
        _vlafrmm = AlterarTipo<decimal?>(leitor["Vlafrmm"]);
        _vlafrmmcusto = AlterarTipo<decimal?>(leitor["Vlafrmmcusto"]);
        _vlaltercustoent = AlterarTipo<decimal?>(leitor["Vlaltercustoent"]);
        _vlantidumping = AlterarTipo<decimal?>(leitor["Vlantidumping"]);
        _vlantidumpingcusto = AlterarTipo<decimal?>(leitor["Vlantidumpingcusto"]);
        _vlbasefrete = AlterarTipo<decimal?>(leitor["Vlbasefrete"]);
        _vlbaseicmsfretefob = AlterarTipo<decimal?>(leitor["Vlbaseicmsfretefob"]);
        _vlbaseipisuspenso = AlterarTipo<decimal?>(leitor["Vlbaseipisuspenso"]);
        _vlbaseoutros = AlterarTipo<decimal?>(leitor["Vlbaseoutros"]);
        _vlbasepartdest = AlterarTipo<decimal?>(leitor["Vlbasepartdest"]);
        _vlbasepiscofinsbkp = AlterarTipo<decimal?>(leitor["Vlbasepiscofinsbkp"]);
        _vlbasepiscofinsfretefob = AlterarTipo<decimal?>(leitor["Vlbasepiscofinsfretefob"]);
        _vlbasestdevfornec = AlterarTipo<decimal?>(leitor["Vlbasestdevfornec"]);
        _vlcapatazia = AlterarTipo<decimal?>(leitor["Vlcapatazia"]);
        _vlcapataziacusto = AlterarTipo<decimal?>(leitor["Vlcapataziacusto"]);
        _vlcofinscalcdi = AlterarTipo<decimal?>(leitor["Vlcofinscalcdi"]);
        _vlcofinsretido = AlterarTipo<decimal?>(leitor["Vlcofinsretido"]);
        _vlcofinsretorgpub = AlterarTipo<decimal?>(leitor["Vlcofinsretorgpub"]);
        _vlcredcofinsbkp = AlterarTipo<decimal?>(leitor["Vlcredcofinsbkp"]);
        _vlcredcofinsfretefob = AlterarTipo<decimal?>(leitor["Vlcredcofinsfretefob"]);
        _vlcredpisbkp = AlterarTipo<decimal?>(leitor["Vlcredpisbkp"]);
        _vlcredpisfretefob = AlterarTipo<decimal?>(leitor["Vlcredpisfretefob"]);
        _vlcsllretido = AlterarTipo<decimal?>(leitor["Vlcsllretido"]);
        _vlcsllretorgpub = AlterarTipo<decimal?>(leitor["Vlcsllretorgpub"]);
        _vldescabatimento = AlterarTipo<decimal?>(leitor["Vldescabatimento"]);
        _vldescontocusto = AlterarTipo<decimal?>(leitor["Vldescontocusto"]);
        _vldescorgaopub = AlterarTipo<decimal?>(leitor["Vldescorgaopub"]);
        _vldescsociotorcedor = AlterarTipo<decimal?>(leitor["Vldescsociotorcedor"]);
        _vldespdentronfcusto = AlterarTipo<decimal?>(leitor["Vldespdentronfcusto"]);
        _vlfcppart = AlterarTipo<decimal?>(leitor["Vlfcppart"]);
        _vlfreteconhecultentant = AlterarTipo<decimal?>(leitor["Vlfreteconhecultentant"]);
        _vlfretenfcusto = AlterarTipo<decimal?>(leitor["Vlfretenfcusto"]);
        _vlicms = AlterarTipo<decimal?>(leitor["Vlicms"]);
        _vlicmsantecipado = AlterarTipo<decimal?>(leitor["Vlicmsantecipado"]);
        _vlicmscheio = AlterarTipo<decimal?>(leitor["Vlicmscheio"]);
        _vlicmscustofretefob = AlterarTipo<decimal?>(leitor["Vlicmscustofretefob"]);
        _vlicmsdesoneracao = AlterarTipo<decimal?>(leitor["Vlicmsdesoneracao"]);
        _vlicmsdifaliqpart = AlterarTipo<decimal?>(leitor["Vlicmsdifaliqpart"]);
        _vlicmsdiferido = AlterarTipo<decimal?>(leitor["Vlicmsdiferido"]);
        _vlicmsfretefob = AlterarTipo<decimal?>(leitor["Vlicmsfretefob"]);
        _vlicmspart = AlterarTipo<decimal?>(leitor["Vlicmspart"]);
        _vlicmspartdest = AlterarTipo<decimal?>(leitor["Vlicmspartdest"]);
        _vlicmspartrem = AlterarTipo<decimal?>(leitor["Vlicmspartrem"]);
        _vliisuspenso = AlterarTipo<decimal?>(leitor["Vliisuspenso"]);
        _vlimportacaofci = AlterarTipo<decimal?>(leitor["Vlimportacaofci"]);
        _vlipioutras = AlterarTipo<decimal?>(leitor["Vlipioutras"]);
        _vlipisuspenso = AlterarTipo<decimal?>(leitor["Vlipisuspenso"]);
        _vlirpjretorgpub = AlterarTipo<decimal?>(leitor["Vlirpjretorgpub"]);
        _vlirretido = AlterarTipo<decimal?>(leitor["Vlirretido"]);
        _vlitemtributos = AlterarTipo<decimal?>(leitor["Vlitemtributos"]);
        _vlitemtributosest = AlterarTipo<decimal?>(leitor["Vlitemtributosest"]);
        _vlitemtributosmunic = AlterarTipo<decimal?>(leitor["Vlitemtributosmunic"]);
        _vloutrasdespimpcusto = AlterarTipo<decimal?>(leitor["Vloutrasdespimpcusto"]);
        _vloutroscustos = AlterarTipo<decimal?>(leitor["Vloutroscustos"]);
        _vloutroscustoscusto = AlterarTipo<decimal?>(leitor["Vloutroscustoscusto"]);
        _vlparcelaimpfci = AlterarTipo<decimal?>(leitor["Vlparcelaimpfci"]);
        _vlpautaipi = AlterarTipo<decimal?>(leitor["Vlpautaipi"]);
        _vlpautapiscofins = AlterarTipo<decimal?>(leitor["Vlpautapiscofins"]);
        _vlpedagio = AlterarTipo<decimal?>(leitor["Vlpedagio"]);
        _vlpiscalcdi = AlterarTipo<decimal?>(leitor["Vlpiscalcdi"]);
        _vlpisretido = AlterarTipo<decimal?>(leitor["Vlpisretido"]);
        _vlpisretorgpub = AlterarTipo<decimal?>(leitor["Vlpisretorgpub"]);
        _vlredcmvsimplesnac = AlterarTipo<decimal?>(leitor["Vlredcmvsimplesnac"]);
        _vlredpvendasimplesna = AlterarTipo<decimal?>(leitor["Vlredpvendasimplesna"]);
        _vlricmssimplesnac = AlterarTipo<decimal?>(leitor["Vlricmssimplesnac"]);
        _vlsegurocusto = AlterarTipo<decimal?>(leitor["Vlsegurocusto"]);
        _vlsiscomexcusto = AlterarTipo<decimal?>(leitor["Vlsiscomexcusto"]);
        _vlstdevfornec = AlterarTipo<decimal?>(leitor["Vlstdevfornec"]);
        _vlstguiaultentant = AlterarTipo<decimal?>(leitor["Vlstguiaultentant"]);
        _vlstoutras = AlterarTipo<decimal?>(leitor["Vlstoutras"]);
        _vlstultentant = AlterarTipo<decimal?>(leitor["Vlstultentant"]);
        _vlsubtotdesconto = AlterarTipo<decimal?>(leitor["Vlsubtotdesconto"]);
        _vlsubtotitem = AlterarTipo<decimal?>(leitor["Vlsubtotitem"]);
        _numseqorig = AlterarTipo<decimal?>(leitor["Numseqorig"]);
        _versaoservicopartilha = AlterarTipo<string>(leitor["Versaoservicopartilha"]);
        _qtminatacvenda = AlterarTipo<decimal?>(leitor["Qtminatacvenda"]);
        _tipodescatacvenda = AlterarTipo<string>(leitor["Tipodescatacvenda"]);
        _codoferta = AlterarTipo<decimal?>(leitor["Codoferta"]);
        _peracrescimofuncep = AlterarTipo<decimal?>(leitor["Peracrescimofuncep"]);
        _vlbasefcpicms = AlterarTipo<decimal?>(leitor["Vlbasefcpicms"]);
        _vlacrescimofuncep = AlterarTipo<decimal?>(leitor["Vlacrescimofuncep"]);
        _aliqicmsfecp = AlterarTipo<decimal?>(leitor["Aliqicmsfecp"]);
        _vlbasefcpst = AlterarTipo<decimal?>(leitor["Vlbasefcpst"]);
        _vlfecp = AlterarTipo<decimal?>(leitor["Vlfecp"]);
        _vlbcfcpstret = AlterarTipo<decimal?>(leitor["Vlbcfcpstret"]);
        _perfcpstret = AlterarTipo<decimal?>(leitor["Perfcpstret"]);
        _vlfcpstret = AlterarTipo<decimal?>(leitor["Vlfcpstret"]);
        _codbeneficiofiscal = AlterarTipo<string>(leitor["Codbeneficiofiscal"]);
        _codagregacao = AlterarTipo<decimal?>(leitor["Codagregacao"]);
        _cnpjfabricante = AlterarTipo<string>(leitor["Cnpjfabricante"]);
        _indescalarelevante = AlterarTipo<string>(leitor["Indescalarelevante"]);
        _fabricante = AlterarTipo<string>(leitor["Fabricante"]);
        _perfcpsn = AlterarTipo<decimal?>(leitor["Perfcpsn"]);
        _vlcredfcpicmssn = AlterarTipo<decimal?>(leitor["Vlcredfcpicmssn"]);
        _descanp = AlterarTipo<string>(leitor["Descanp"]);
        _pglp = AlterarTipo<decimal?>(leitor["Pglp"]);
        _pgni = AlterarTipo<decimal?>(leitor["Pgni"]);
        _pgnn = AlterarTipo<decimal?>(leitor["Pgnn"]);
        _vpart = AlterarTipo<decimal?>(leitor["Vpart"]);
        _vlbaseipiecf = AlterarTipo<decimal?>(leitor["Vlbaseipiecf"]);
        _percipiecf = AlterarTipo<decimal?>(leitor["Percipiecf"]);
        _vlipiecf = AlterarTipo<decimal?>(leitor["Vlipiecf"]);
        _utilizoumotorcalculo = AlterarTipo<string>(leitor["Utilizoumotorcalculo"]);
        _percredbaseefet = AlterarTipo<decimal?>(leitor["Percredbaseefet"]);
        _vlbaseefet = AlterarTipo<decimal?>(leitor["Vlbaseefet"]);
        _percicmsefet = AlterarTipo<decimal?>(leitor["Percicmsefet"]);
        _vlicmsefet = AlterarTipo<decimal?>(leitor["Vlicmsefet"]);
        _numtransultentstant = AlterarTipo<decimal?>(leitor["Numtransultentstant"]);
        _excluiricmsbasepiscofins = AlterarTipo<string>(leitor[RO_EXCLUIRICMSBASEPISCOFINS]);
    }

}