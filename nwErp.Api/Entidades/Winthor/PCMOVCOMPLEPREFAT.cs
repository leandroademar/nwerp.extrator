

////// namespace nwErp.Entidades.Winthor;

// namespace nwErp.Api.Modelos;

[Serializable]
public class PCMOVCOMPLEPREFAT : GerenteDePropriedades, IEntidade
{
    private decimal? _aliq1;

    private decimal? _aliqfcp;

    private decimal? _aliqfcppart;

    private decimal? _aliqfcppart_desativado;

    private decimal? _aliqicms1ultentant;

    private decimal? _aliqicms1ret;

    private decimal? _aliqicms2ultentant;

    private decimal? _aliqicmsfecp;

    private decimal? _aliqicmspart;

    private decimal? _aliqicmspart_desativado;

    private decimal? _aliqinternadest;

    private decimal? _aliqinterorigpart;

    private decimal? _aliqreducaocofins;

    private decimal? _aliqreducaopis;

    private decimal? _anp;

    private string _anvisanumregmed;

    private string _aplicamvabaseicms;

    private string _aplicpercivapautaicmsantecip;

    private string _aplicredbaseivapliq;

    private string _aplicredbaseivapliqbcr;

    private string _aproveitacredicmscont;

    private string _aproveitacredpiscofinscont;

    private decimal? _basebcrant;

    private decimal? _basecredpresumido;

    private decimal? _baseicmsantecipado;

    private decimal? _baseicmsimporig;

    private decimal? _baseicms_manif;

    private decimal? _baseimportacao;

    private decimal? _baseipioutras;

    private decimal? _basestoutras;

    private string _bnfnaocalculaicms;

    private string _bonific;

    private string _cagreg;

    private string _calccredipicont;

    private string _calctribmanual;

    private decimal? _cfoporig;

    private string _classevenda;

    private string _cnaedesoneracao;

    private string _cnpjfabricante;

    private decimal? _cnpjsubcontratada;

    private string _codagregacao;

    private string _codbeneficiofiscal;

    private string _codbeneficionota;

    private string _codcest;

    private decimal? _codcnaeserv;

    private decimal? _codcomprador;

    private decimal? _codconfigfuncepmed;

    private decimal? _codedital;

    private decimal? _codemitenteitempedido;

    private string _codenqipi;

    private decimal? _codfiguradesonicms;

    private string _codfilialdest;

    private decimal? _codlinhaprazo;

    private string _codmotivoicmsdesonerado;

    private decimal? _codmovinservivel;

    private decimal? _codoferta;

    private decimal? _codpoliticadesc;

    private decimal? _codprodacabcesta;

    private decimal? _codprodgnre;

    private decimal? _codpromocaomed;

    private string _codsittribicmsfretefob;

    private decimal? _codsittribipi;

    private decimal? _codsittribpiscofinsfretefob;

    private decimal? _codsittribpiscofinsnfservico;

    private string _codsittribst;

    private decimal? _codsupervisor;

    private string _codtiposervico;

    private decimal? _codtribpiscofins;

    private decimal? _codusur2;

    private decimal? _codusurpgcomissao;

    private decimal? _codusurpgcomissaoop;

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

    private DateTime? _dataconsolidacaoprefat;

    private string _deduziricmsimportacao;

    private string _descanp;

    private decimal? _descprecofab;

    private string _descricaonfcomp;

    private DateTime? _dtestorno;

    private DateTime? _dtpagcomissao;

    private DateTime? _dtpagcomissaoop;

    private DateTime? _dtregistro;

    private decimal? _eancodprod;

    private string _enderecado;

    private string _enviaraliqreducaopiscofins;

    private string _esferapublica;

    private string _estcomissaorca;

    private string _extipi;

    private string _fabricante;

    private decimal? _fatorconvcom;

    private decimal? _fatorconvemb;

    private decimal? _fatorconversaopedlicit;

    private decimal? _fatorconvtrib;

    private decimal? _fatorconvtribex;

    private decimal? _fatorent;

    private string _gerabasepiscofinssemaliq;

    private string _icmspauta;

    private decimal? _idvenda;

    private string _indescalarelevante;

    private decimal? _iniciointervalodescquant;

    private string _ipiporvalor;

    private decimal? _irretido;

    private decimal? _iva;

    private decimal? _ivaultentant;

    private string _lotecontrato;

    private string _mixacordoparceria;

    private decimal? _modalidadebasestfonte;

    private decimal? _modbcst;

    private decimal? _modbcstguia;

    private string _mostraritensnaembmaster;

    private string _movest;

    private string _multimplounidademaster;

    private decimal? _notasubcontratada;

    private string _numchaveexp;

    private string _numdrawback;

    private string _numempenho;

    private string _numeroprocessoserv;

    private string _numerorecopi;

    private string _numfci;

    private decimal? _numinvent;

    private decimal? _numitemped;

    private decimal? _numlista;

    private string _numpedcli;

    private decimal? _numrecopi;

    private decimal? _numregexp;

    private decimal? _numseqent;

    private decimal? _numseqitemcontrato;

    private decimal? _numseqorig;

    private string _numseqpedagrupado;

    private string _numseriesat;

    private decimal? _numtransentpeps;

    private decimal _numtransitem;

    private decimal? _numtransitemdev;

    private decimal? _numtransnumeroserie;

    private decimal? _numtranspeps;

    private decimal? _numtranstransforig;

    private string _observacaocomercialmed;

    private string _origmerctrib;

    private string _participacomissgarantida;

    private string _participagiro;

    private decimal? _patchservicopartilha;

    private decimal? _peracrescimofuncep;

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

    private decimal? _percicmsdesoneracao;

    private decimal? _percicmsfretefob;

    private decimal? _percicmsfretefobicmsantecip;

    private decimal? _percicmsfretefobstultentant;

    private decimal? _percicmsimporig;

    private decimal? _percicmsredfretefob;

    private decimal? _percicmssimplesnac;

    private decimal? _percicm_manif;

    private decimal? _percipidevfornec;

    private decimal? _percipioutras;

    private decimal? _percipisuspenso;

    private decimal? _perciva2;

    private decimal? _percmvaorig;

    private decimal? _percmvaorigicmsantecip;

    private decimal? _percnfservico;

    private decimal? _percofinsbkp;

    private decimal? _percofinscalcdi;

    private decimal? _percofinsfretefob;

    private decimal? _percofinsnfservico;

    private decimal? _percomregiaomed;

    private decimal? _percomregiaomed2;

    private decimal? _percoutrasdespimp;

    private decimal? _percoutrasdespimpcusto;

    private decimal? _percoutroscustoscont;

    private decimal? _percoutroscustoscusto;

    private decimal? _percoutroscustoscustocont;

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

    private decimal? _perctaxaprazomedcmv;

    private decimal? _perdesccusto;

    private decimal? _perdescfimcomiss;

    private decimal? _perdescinicomiss;

    private decimal? _perdifereimentoicms;

    private decimal? _perfcpsn;

    private decimal? _perfcpstret;

    private decimal? _perpisbkp;

    private decimal? _perpiscalcdi;

    private decimal? _perpisfretefob;

    private decimal? _perpisnfservico;

    private decimal? _pesobrutofrete;

    private decimal? _pesoliqdi;

    private decimal? _pglp;

    private decimal? _pgni;

    private decimal? _pgnn;

    private string _piscofinsdeduzido;

    private decimal? _pisretido;

    private decimal? _poriginal;

    private decimal? _precofab;

    private decimal? _precomaxconsum;

    private decimal? _precomaxconsumlicittab;

    private string _precoutilizadonfe;

    private string _proddescricaodanfe;

    private string _prodimportadopeps;

    private decimal? _ptabelacusto;

    private decimal? _qtdedoacaopedlicit;

    private decimal? _qtderrubadaparcial;

    private decimal? _qtdigitada;

    private decimal? _qtlitragem;

    private decimal? _qtminatacvenda;

    private decimal? _qtpedlicit;

    private decimal? _qtperda;

    private decimal? _qtretornotv13;

    private decimal? _qtsobra;

    private decimal? _qtun;

    private decimal? _qtunitlicit;

    private decimal? _qt_entradamanif;

    private decimal? _redbasealiqexticmsantecip;

    private decimal? _redbaseivaicmsantecip;

    private decimal? _redbaseivaultentant;

    private string _regimeespecial;

    private string _regimeespisenstfonte;

    private string _reterinsscprbserv;

    private string _retervalorincser;

    private decimal? _serienotasubcontratada;

    private string _statuspredevolucao;

    private decimal? _stbcrant;

    private decimal? _stpbaserca;

    private decimal? _stptabela;

    private decimal? _strepassebcrmed;

    private string _substancia;

    private string _sujdesoneracao;

    private decimal? _temposervico;

    private decimal? _termposervico;

    private string _tipocalcst;

    private decimal? _tipoconversaopedlicit;

    private string _tipodescatacvenda;

    private string _tipoentrega;

    private string _tipomedicamento;

    private string _tipoprocessoserv;

    private string _unidadeconversaopedlicit;

    private string _unidadeemb;

    private string _unidadelicit;

    private string _unidadetrib;

    private string _unidadetribex;

    private string _usapiscofinslit;

    private string _usapmcbasest;

    private string _usaunidademaster;

    private string _utilizabasepiscofinssusp;

    private string _utilizacredredpiscofins;

    private string _utilizoumotorcalculo;

    private string _versaoregistro;

    private string _versaoservicopartilha;

    private decimal? _vlacrescimofuncep;

    private decimal? _vlacrespart;

    private decimal? _vlacrespart_desativado;

    private decimal? _vladicionalbcicmsantecip;

    private decimal? _vladuaneiracusto;

    private decimal? _vlafrmm;

    private decimal? _vlafrmmcusto;

    private decimal? _vlaltercustoent;

    private decimal? _vlantidumping;

    private decimal? _vlantidumpingcusto;

    private decimal? _vlbasefcpicms;

    private decimal? _vlbasefcpst;

    private decimal? _vlbasefrete;

    private decimal? _vlbaseicmsfretefob;

    private decimal? _vlbaseipidevfornec;

    private decimal? _vlbaseipisuspenso;

    private decimal? _vlbaseoutros;

    private decimal? _vlbasepart;

    private decimal? _vlbasepartdest;

    private decimal? _vlbasepart_desativado;

    private decimal? _vlbasepiscofinsbkp;

    private decimal? _vlbasepiscofinsfretefob;

    private decimal? _vlbasepiscofinsnfservico;

    private decimal? _vlbasest;

    private decimal? _vlbasestdevfornec;

    private decimal? _vlbcfcpstret;

    private decimal? _vlcapatazia;

    private decimal? _vlcapataziacusto;

    private decimal? _vlcofinscalcdi;

    private decimal? _vlcofinsretido;

    private decimal? _vlcofinsretorgpub;

    private decimal? _vlcredcofinsbkp;

    private decimal? _vlcredcofinsfretefob;

    private decimal? _vlcredcofinsnfservico;

    private decimal? _vlcredfcpicmssn;

    private decimal? _vlcredpisbkp;

    private decimal? _vlcredpisfretefob;

    private decimal? _vlcredpisnfservico;

    private decimal? _vlcsllretido;

    private decimal? _vlcsllretorgpub;

    private decimal? _vldescabatimento;

    private decimal? _vldescboletocmv;

    private decimal? _vldescontocusto;

    private decimal? _vldescontonf;

    private decimal? _vldescorgaopub;

    private decimal? _vldescsociotorcedor;

    private decimal? _vldespdentronfcusto;

    private decimal? _vlfcppart;

    private decimal? _vlfcpstret;

    private decimal? _vlfecp;

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

    private decimal? _vlicmsmporig;

    private decimal? _vlicmspart;

    private decimal? _vlicmspartdest;

    private decimal? _vlicmspartpbaserca;

    private decimal? _vlicmspartptabela;

    private decimal? _vlicmspartrem;

    private decimal? _vlicms_manif;

    private decimal? _vlicms_manual;

    private decimal? _vliisuspenso;

    private decimal? _vlimportacaofci;

    private decimal? _vlimpprodutorural;

    private decimal? _vlipidevfornec;

    private decimal? _vlipioutras;

    private decimal? _vlipipbaserca;

    private decimal? _vlipiptabela;

    private decimal? _vlipisuspenso;

    private decimal? _vlirpjretorgpub;

    private decimal? _vlirretido;

    private decimal? _vlitemtributos;

    private decimal? _vlitemtributosest;

    private decimal? _vlitemtributosmunic;

    private decimal? _vlmateriaprima;

    private decimal? _vlnfservico;

    private decimal? _vlnfservicoporkg;

    private decimal? _vloutrasdespimpcusto;

    private decimal? _vloutroscustos;

    private decimal? _vloutroscustoscont;

    private decimal? _vloutroscustoscusto;

    private decimal? _vloutroscustoscustocont;

    private decimal? _vlparcelaimpfci;

    private decimal? _vlpautaipi;

    private decimal? _vlpautapiscofins;

    private decimal? _vlpedagio;

    private decimal? _vlpiscalcdi;

    private decimal? _vlpisretido;

    private decimal? _vlpisretorgpub;

    private decimal? _vlredcmvsimplesnac;

    private decimal? _vlredpvendasimplesna;

    private decimal? _vlretencao;

    private decimal? _vlretencaosubcontratada;

    private decimal? _vlricmssimplesnac;

    private decimal? _vlsegurocusto;

    private decimal? _vlsiscomexcusto;

    private decimal? _vlst;

    private decimal? _vlstdevfornec;

    private decimal? _vlstguiaultentant;

    private decimal? _vlstoutorgado;

    private decimal? _vlstoutras;

    private decimal? _vlstoutrasdesp;

    private decimal? _vlstultentant;

    private decimal? _vlsubtotdesconto;

    private decimal? _vlsubtotitem;

    private decimal? _vltaxaprazomedcmv;

    private decimal? _vpart;

    private decimal? _vlbaseipiecf;

    private decimal? _percipiecf;

    private decimal? _vlipiecf;

    private decimal? _percredbaseefet;

    private decimal? _vlbaseefet;

    private decimal? _percicmsefet;

    private decimal? _vlicmsefet;

    private decimal? _numtransultentstant;

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Aliq1
    {
        get
        {
            PropriedadeAcessada("Aliq1");
            return _aliq1;
        }
        set
        {
            PropriedadeModificada("Aliq1", value);
            _aliq1 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Aliqfcppart
    {
        get
        {
            PropriedadeAcessada("Aliqfcppart");
            return _aliqfcppart;
        }
        set
        {
            PropriedadeModificada("Aliqfcppart", value);
            _aliqfcppart = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Aliqfcppart_Desativado
    {
        get
        {
            PropriedadeAcessada("Aliqfcppart_Desativado");
            return _aliqfcppart_desativado;
        }
        set
        {
            PropriedadeModificada("Aliqfcppart_Desativado", value);
            _aliqfcppart_desativado = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Aliqicmspart
    {
        get
        {
            PropriedadeAcessada("Aliqicmspart");
            return _aliqicmspart;
        }
        set
        {
            PropriedadeModificada("Aliqicmspart", value);
            _aliqicmspart = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Aliqicmspart_Desativado
    {
        get
        {
            PropriedadeAcessada("Aliqicmspart_Desativado");
            return _aliqicmspart_desativado;
        }
        set
        {
            PropriedadeModificada("Aliqicmspart_Desativado", value);
            _aliqicmspart_desativado = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 9, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
    public string Anvisanumregmed
    {
        get
        {
            PropriedadeAcessada("Anvisanumregmed");
            return _anvisanumregmed;
        }
        set
        {
            PropriedadeModificada("Anvisanumregmed", value);
            _anvisanumregmed = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Aplicamvabaseicms
    {
        get
        {
            PropriedadeAcessada("Aplicamvabaseicms");
            return _aplicamvabaseicms;
        }
        set
        {
            PropriedadeModificada("Aplicamvabaseicms", value);
            _aplicamvabaseicms = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Baseicmsimporig
    {
        get
        {
            PropriedadeAcessada("Baseicmsimporig");
            return _baseicmsimporig;
        }
        set
        {
            PropriedadeModificada("Baseicmsimporig", value);
            _baseicmsimporig = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Baseicms_Manif
    {
        get
        {
            PropriedadeAcessada("Baseicms_Manif");
            return _baseicms_manif;
        }
        set
        {
            PropriedadeModificada("Baseicms_Manif", value);
            _baseicms_manif = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Baseimportacao
    {
        get
        {
            PropriedadeAcessada("Baseimportacao");
            return _baseimportacao;
        }
        set
        {
            PropriedadeModificada("Baseimportacao", value);
            _baseimportacao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
    public string Cagreg
    {
        get
        {
            PropriedadeAcessada("Cagreg");
            return _cagreg;
        }
        set
        {
            PropriedadeModificada("Cagreg", value);
            _cagreg = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Cfoporig
    {
        get
        {
            PropriedadeAcessada("Cfoporig");
            return _cfoporig;
        }
        set
        {
            PropriedadeModificada("Cfoporig", value);
            _cfoporig = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Classevenda
    {
        get
        {
            PropriedadeAcessada("Classevenda");
            return _classevenda;
        }
        set
        {
            PropriedadeModificada("Classevenda", value);
            _classevenda = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 60, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 18, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 0)]
    public decimal? Cnpjsubcontratada
    {
        get
        {
            PropriedadeAcessada("Cnpjsubcontratada");
            return _cnpjsubcontratada;
        }
        set
        {
            PropriedadeModificada("Cnpjsubcontratada", value);
            _cnpjsubcontratada = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
    public string Codagregacao
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 10, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 10, Precisao = 0)]
    public string Codbeneficionota
    {
        get
        {
            PropriedadeAcessada("Codbeneficionota");
            return _codbeneficionota;
        }
        set
        {
            PropriedadeModificada("Codbeneficionota", value);
            _codbeneficionota = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 7, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 20, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codcomprador
    {
        get
        {
            PropriedadeAcessada("Codcomprador");
            return _codcomprador;
        }
        set
        {
            PropriedadeModificada("Codcomprador", value);
            _codcomprador = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Codconfigfuncepmed
    {
        get
        {
            PropriedadeAcessada("Codconfigfuncepmed");
            return _codconfigfuncepmed;
        }
        set
        {
            PropriedadeModificada("Codconfigfuncepmed", value);
            _codconfigfuncepmed = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 9, Precisao = 0)]
    public decimal? Codedital
    {
        get
        {
            PropriedadeAcessada("Codedital");
            return _codedital;
        }
        set
        {
            PropriedadeModificada("Codedital", value);
            _codedital = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 3, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codmovinservivel
    {
        get
        {
            PropriedadeAcessada("Codmovinservivel");
            return _codmovinservivel;
        }
        set
        {
            PropriedadeModificada("Codmovinservivel", value);
            _codmovinservivel = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Codpoliticadesc
    {
        get
        {
            PropriedadeAcessada("Codpoliticadesc");
            return _codpoliticadesc;
        }
        set
        {
            PropriedadeModificada("Codpoliticadesc", value);
            _codpoliticadesc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 9, Precisao = 0)]
    public decimal? Codpromocaomed
    {
        get
        {
            PropriedadeAcessada("Codpromocaomed");
            return _codpromocaomed;
        }
        set
        {
            PropriedadeModificada("Codpromocaomed", value);
            _codpromocaomed = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 3, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 3, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 3, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 3, Precisao = 0)]
    public decimal? Codsittribpiscofinsnfservico
    {
        get
        {
            PropriedadeAcessada("Codsittribpiscofinsnfservico");
            return _codsittribpiscofinsnfservico;
        }
        set
        {
            PropriedadeModificada("Codsittribpiscofinsnfservico", value);
            _codsittribpiscofinsnfservico = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Codsupervisor
    {
        get
        {
            PropriedadeAcessada("Codsupervisor");
            return _codsupervisor;
        }
        set
        {
            PropriedadeModificada("Codsupervisor", value);
            _codsupervisor = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 9, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Codusur2
    {
        get
        {
            PropriedadeAcessada("Codusur2");
            return _codusur2;
        }
        set
        {
            PropriedadeModificada("Codusur2", value);
            _codusur2 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codusurpgcomissao
    {
        get
        {
            PropriedadeAcessada("Codusurpgcomissao");
            return _codusurpgcomissao;
        }
        set
        {
            PropriedadeModificada("Codusurpgcomissao", value);
            _codusurpgcomissao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codusurpgcomissaoop
    {
        get
        {
            PropriedadeAcessada("Codusurpgcomissaoop");
            return _codusurpgcomissaoop;
        }
        set
        {
            PropriedadeModificada("Codusurpgcomissaoop", value);
            _codusurpgcomissaoop = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 2)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 2)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 22, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 22, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dataconsolidacaoprefat
    {
        get
        {
            PropriedadeAcessada("Dataconsolidacaoprefat");
            return _dataconsolidacaoprefat;
        }
        set
        {
            PropriedadeModificada("Dataconsolidacaoprefat", value);
            _dataconsolidacaoprefat = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 95, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 120, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtpagcomissao
    {
        get
        {
            PropriedadeAcessada("Dtpagcomissao");
            return _dtpagcomissao;
        }
        set
        {
            PropriedadeModificada("Dtpagcomissao", value);
            _dtpagcomissao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtpagcomissaoop
    {
        get
        {
            PropriedadeAcessada("Dtpagcomissaoop");
            return _dtpagcomissaoop;
        }
        set
        {
            PropriedadeModificada("Dtpagcomissaoop", value);
            _dtpagcomissaoop = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Esferapublica
    {
        get
        {
            PropriedadeAcessada("Esferapublica");
            return _esferapublica;
        }
        set
        {
            PropriedadeModificada("Esferapublica", value);
            _esferapublica = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Estcomissaorca
    {
        get
        {
            PropriedadeAcessada("Estcomissaorca");
            return _estcomissaorca;
        }
        set
        {
            PropriedadeModificada("Estcomissaorca", value);
            _estcomissaorca = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 3, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 60, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Fatorconvemb
    {
        get
        {
            PropriedadeAcessada("Fatorconvemb");
            return _fatorconvemb;
        }
        set
        {
            PropriedadeModificada("Fatorconvemb", value);
            _fatorconvemb = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 30, Precisao = 16)]
    public decimal? Fatorconversaopedlicit
    {
        get
        {
            PropriedadeAcessada("Fatorconversaopedlicit");
            return _fatorconversaopedlicit;
        }
        set
        {
            PropriedadeModificada("Fatorconversaopedlicit", value);
            _fatorconversaopedlicit = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 6)]
    public decimal? Fatorconvtribex
    {
        get
        {
            PropriedadeAcessada("Fatorconvtribex");
            return _fatorconvtribex;
        }
        set
        {
            PropriedadeModificada("Fatorconvtribex", value);
            _fatorconvtribex = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Fatorent
    {
        get
        {
            PropriedadeAcessada("Fatorent");
            return _fatorent;
        }
        set
        {
            PropriedadeModificada("Fatorent", value);
            _fatorent = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 4)]
    public decimal? Iniciointervalodescquant
    {
        get
        {
            PropriedadeAcessada("Iniciointervalodescquant");
            return _iniciointervalodescquant;
        }
        set
        {
            PropriedadeModificada("Iniciointervalodescquant", value);
            _iniciointervalodescquant = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 2)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 10, Precisao = 0)]
    public string Lotecontrato
    {
        get
        {
            PropriedadeAcessada("Lotecontrato");
            return _lotecontrato;
        }
        set
        {
            PropriedadeModificada("Lotecontrato", value);
            _lotecontrato = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Mixacordoparceria
    {
        get
        {
            PropriedadeAcessada("Mixacordoparceria");
            return _mixacordoparceria;
        }
        set
        {
            PropriedadeModificada("Mixacordoparceria", value);
            _mixacordoparceria = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Modalidadebasestfonte
    {
        get
        {
            PropriedadeAcessada("Modalidadebasestfonte");
            return _modalidadebasestfonte;
        }
        set
        {
            PropriedadeModificada("Modalidadebasestfonte", value);
            _modalidadebasestfonte = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 1, Precisao = 0)]
    public decimal? Modbcst
    {
        get
        {
            PropriedadeAcessada("Modbcst");
            return _modbcst;
        }
        set
        {
            PropriedadeModificada("Modbcst", value);
            _modbcst = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 1, Precisao = 0)]
    public decimal? Modbcstguia
    {
        get
        {
            PropriedadeAcessada("Modbcstguia");
            return _modbcstguia;
        }
        set
        {
            PropriedadeModificada("Modbcstguia", value);
            _modbcstguia = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Mostraritensnaembmaster
    {
        get
        {
            PropriedadeAcessada("Mostraritensnaembmaster");
            return _mostraritensnaembmaster;
        }
        set
        {
            PropriedadeModificada("Mostraritensnaembmaster", value);
            _mostraritensnaembmaster = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Movest
    {
        get
        {
            PropriedadeAcessada("Movest");
            return _movest;
        }
        set
        {
            PropriedadeModificada("Movest", value);
            _movest = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Multimplounidademaster
    {
        get
        {
            PropriedadeAcessada("Multimplounidademaster");
            return _multimplounidademaster;
        }
        set
        {
            PropriedadeModificada("Multimplounidademaster", value);
            _multimplounidademaster = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 0)]
    public decimal? Notasubcontratada
    {
        get
        {
            PropriedadeAcessada("Notasubcontratada");
            return _notasubcontratada;
        }
        set
        {
            PropriedadeModificada("Notasubcontratada", value);
            _notasubcontratada = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 44, Precisao = 0)]
    public string Numchaveexp
    {
        get
        {
            PropriedadeAcessada("Numchaveexp");
            return _numchaveexp;
        }
        set
        {
            PropriedadeModificada("Numchaveexp", value);
            _numchaveexp = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
    public string Numempenho
    {
        get
        {
            PropriedadeAcessada("Numempenho");
            return _numempenho;
        }
        set
        {
            PropriedadeModificada("Numempenho", value);
            _numempenho = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 100, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 36, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 15, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 20, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 0)]
    public decimal? Numregexp
    {
        get
        {
            PropriedadeAcessada("Numregexp");
            return _numregexp;
        }
        set
        {
            PropriedadeModificada("Numregexp", value);
            _numregexp = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 0)]
    public decimal? Numseqent
    {
        get
        {
            PropriedadeAcessada("Numseqent");
            return _numseqent;
        }
        set
        {
            PropriedadeModificada("Numseqent", value);
            _numseqent = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 20, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 50, Precisao = 0)]
    public string Numseqpedagrupado
    {
        get
        {
            PropriedadeAcessada("Numseqpedagrupado");
            return _numseqpedagrupado;
        }
        set
        {
            PropriedadeModificada("Numseqpedagrupado", value);
            _numseqpedagrupado = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 13, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numtransentpeps
    {
        get
        {
            PropriedadeAcessada("Numtransentpeps");
            return _numtransentpeps;
        }
        set
        {
            PropriedadeModificada("Numtransentpeps", value);
            _numtransentpeps = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numtranspeps
    {
        get
        {
            PropriedadeAcessada("Numtranspeps");
            return _numtranspeps;
        }
        set
        {
            PropriedadeModificada("Numtranspeps", value);
            _numtranspeps = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
    public string Observacaocomercialmed
    {
        get
        {
            PropriedadeAcessada("Observacaocomercialmed");
            return _observacaocomercialmed;
        }
        set
        {
            PropriedadeModificada("Observacaocomercialmed", value);
            _observacaocomercialmed = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Participacomissgarantida
    {
        get
        {
            PropriedadeAcessada("Participacomissgarantida");
            return _participacomissgarantida;
        }
        set
        {
            PropriedadeModificada("Participacomissgarantida", value);
            _participacomissgarantida = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Patchservicopartilha
    {
        get
        {
            PropriedadeAcessada("Patchservicopartilha");
            return _patchservicopartilha;
        }
        set
        {
            PropriedadeModificada("Patchservicopartilha", value);
            _patchservicopartilha = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 2)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 2)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 2)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 2)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 2)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Percicmsdesoneracao
    {
        get
        {
            PropriedadeAcessada("Percicmsdesoneracao");
            return _percicmsdesoneracao;
        }
        set
        {
            PropriedadeModificada("Percicmsdesoneracao", value);
            _percicmsdesoneracao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Percicmsimporig
    {
        get
        {
            PropriedadeAcessada("Percicmsimporig");
            return _percicmsimporig;
        }
        set
        {
            PropriedadeModificada("Percicmsimporig", value);
            _percicmsimporig = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Percicm_Manif
    {
        get
        {
            PropriedadeAcessada("Percicm_Manif");
            return _percicm_manif;
        }
        set
        {
            PropriedadeModificada("Percicm_Manif", value);
            _percicm_manif = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Percipidevfornec
    {
        get
        {
            PropriedadeAcessada("Percipidevfornec");
            return _percipidevfornec;
        }
        set
        {
            PropriedadeModificada("Percipidevfornec", value);
            _percipidevfornec = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Perciva2
    {
        get
        {
            PropriedadeAcessada("Perciva2");
            return _perciva2;
        }
        set
        {
            PropriedadeModificada("Perciva2", value);
            _perciva2 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Percnfservico
    {
        get
        {
            PropriedadeAcessada("Percnfservico");
            return _percnfservico;
        }
        set
        {
            PropriedadeModificada("Percnfservico", value);
            _percnfservico = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Percofinsnfservico
    {
        get
        {
            PropriedadeAcessada("Percofinsnfservico");
            return _percofinsnfservico;
        }
        set
        {
            PropriedadeModificada("Percofinsnfservico", value);
            _percofinsnfservico = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Percomregiaomed
    {
        get
        {
            PropriedadeAcessada("Percomregiaomed");
            return _percomregiaomed;
        }
        set
        {
            PropriedadeModificada("Percomregiaomed", value);
            _percomregiaomed = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Percomregiaomed2
    {
        get
        {
            PropriedadeAcessada("Percomregiaomed2");
            return _percomregiaomed2;
        }
        set
        {
            PropriedadeModificada("Percomregiaomed2", value);
            _percomregiaomed2 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Percoutroscustoscont
    {
        get
        {
            PropriedadeAcessada("Percoutroscustoscont");
            return _percoutroscustoscont;
        }
        set
        {
            PropriedadeModificada("Percoutroscustoscont", value);
            _percoutroscustoscont = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Percoutroscustoscustocont
    {
        get
        {
            PropriedadeAcessada("Percoutroscustoscustocont");
            return _percoutroscustoscustocont;
        }
        set
        {
            PropriedadeModificada("Percoutroscustoscustocont", value);
            _percoutroscustoscustocont = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 2)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Perctaxaprazomedcmv
    {
        get
        {
            PropriedadeAcessada("Perctaxaprazomedcmv");
            return _perctaxaprazomedcmv;
        }
        set
        {
            PropriedadeModificada("Perctaxaprazomedcmv", value);
            _perctaxaprazomedcmv = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Perpisnfservico
    {
        get
        {
            PropriedadeAcessada("Perpisnfservico");
            return _perpisnfservico;
        }
        set
        {
            PropriedadeModificada("Perpisnfservico", value);
            _perpisnfservico = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Pesobrutofrete
    {
        get
        {
            PropriedadeAcessada("Pesobrutofrete");
            return _pesobrutofrete;
        }
        set
        {
            PropriedadeModificada("Pesobrutofrete", value);
            _pesobrutofrete = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 7, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 7, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 7, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 2)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Precofab
    {
        get
        {
            PropriedadeAcessada("Precofab");
            return _precofab;
        }
        set
        {
            PropriedadeModificada("Precofab", value);
            _precofab = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Precomaxconsumlicittab
    {
        get
        {
            PropriedadeAcessada("Precomaxconsumlicittab");
            return _precomaxconsumlicittab;
        }
        set
        {
            PropriedadeModificada("Precomaxconsumlicittab", value);
            _precomaxconsumlicittab = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 500, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Prodimportadopeps
    {
        get
        {
            PropriedadeAcessada("Prodimportadopeps");
            return _prodimportadopeps;
        }
        set
        {
            PropriedadeModificada("Prodimportadopeps", value);
            _prodimportadopeps = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 20, Precisao = 6)]
    public decimal? Qtdedoacaopedlicit
    {
        get
        {
            PropriedadeAcessada("Qtdedoacaopedlicit");
            return _qtdedoacaopedlicit;
        }
        set
        {
            PropriedadeModificada("Qtdedoacaopedlicit", value);
            _qtdedoacaopedlicit = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 20, Precisao = 6)]
    public decimal? Qtderrubadaparcial
    {
        get
        {
            PropriedadeAcessada("Qtderrubadaparcial");
            return _qtderrubadaparcial;
        }
        set
        {
            PropriedadeModificada("Qtderrubadaparcial", value);
            _qtderrubadaparcial = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 20, Precisao = 6)]
    public decimal? Qtpedlicit
    {
        get
        {
            PropriedadeAcessada("Qtpedlicit");
            return _qtpedlicit;
        }
        set
        {
            PropriedadeModificada("Qtpedlicit", value);
            _qtpedlicit = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 8)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 20, Precisao = 6)]
    public decimal? Qtretornotv13
    {
        get
        {
            PropriedadeAcessada("Qtretornotv13");
            return _qtretornotv13;
        }
        set
        {
            PropriedadeModificada("Qtretornotv13", value);
            _qtretornotv13 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Qtsobra
    {
        get
        {
            PropriedadeAcessada("Qtsobra");
            return _qtsobra;
        }
        set
        {
            PropriedadeModificada("Qtsobra", value);
            _qtsobra = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 16, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 22, Precisao = 8)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 20, Precisao = 8)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Regimeespisenstfonte
    {
        get
        {
            PropriedadeAcessada("Regimeespisenstfonte");
            return _regimeespisenstfonte;
        }
        set
        {
            PropriedadeModificada("Regimeespisenstfonte", value);
            _regimeespisenstfonte = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 0)]
    public decimal? Serienotasubcontratada
    {
        get
        {
            PropriedadeAcessada("Serienotasubcontratada");
            return _serienotasubcontratada;
        }
        set
        {
            PropriedadeModificada("Serienotasubcontratada", value);
            _serienotasubcontratada = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Statuspredevolucao
    {
        get
        {
            PropriedadeAcessada("Statuspredevolucao");
            return _statuspredevolucao;
        }
        set
        {
            PropriedadeModificada("Statuspredevolucao", value);
            _statuspredevolucao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Strepassebcrmed
    {
        get
        {
            PropriedadeAcessada("Strepassebcrmed");
            return _strepassebcrmed;
        }
        set
        {
            PropriedadeModificada("Strepassebcrmed", value);
            _strepassebcrmed = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 10, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 0)]
    public decimal? Temposervico
    {
        get
        {
            PropriedadeAcessada("Temposervico");
            return _temposervico;
        }
        set
        {
            PropriedadeModificada("Temposervico", value);
            _temposervico = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 2, Precisao = 0)]
    public decimal? Tipoconversaopedlicit
    {
        get
        {
            PropriedadeAcessada("Tipoconversaopedlicit");
            return _tipoconversaopedlicit;
        }
        set
        {
            PropriedadeModificada("Tipoconversaopedlicit", value);
            _tipoconversaopedlicit = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Tipomedicamento
    {
        get
        {
            PropriedadeAcessada("Tipomedicamento");
            return _tipomedicamento;
        }
        set
        {
            PropriedadeModificada("Tipomedicamento", value);
            _tipomedicamento = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Unidadeconversaopedlicit
    {
        get
        {
            PropriedadeAcessada("Unidadeconversaopedlicit");
            return _unidadeconversaopedlicit;
        }
        set
        {
            PropriedadeModificada("Unidadeconversaopedlicit", value);
            _unidadeconversaopedlicit = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Unidadeemb
    {
        get
        {
            PropriedadeAcessada("Unidadeemb");
            return _unidadeemb;
        }
        set
        {
            PropriedadeModificada("Unidadeemb", value);
            _unidadeemb = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 6, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 6, Precisao = 0)]
    public string Unidadetribex
    {
        get
        {
            PropriedadeAcessada("Unidadetribex");
            return _unidadetribex;
        }
        set
        {
            PropriedadeModificada("Unidadetribex", value);
            _unidadetribex = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 10, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 10, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlacrespart
    {
        get
        {
            PropriedadeAcessada("Vlacrespart");
            return _vlacrespart;
        }
        set
        {
            PropriedadeModificada("Vlacrespart", value);
            _vlacrespart = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlacrespart_Desativado
    {
        get
        {
            PropriedadeAcessada("Vlacrespart_Desativado");
            return _vlacrespart_desativado;
        }
        set
        {
            PropriedadeModificada("Vlacrespart_Desativado", value);
            _vlacrespart_desativado = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlbaseipidevfornec
    {
        get
        {
            PropriedadeAcessada("Vlbaseipidevfornec");
            return _vlbaseipidevfornec;
        }
        set
        {
            PropriedadeModificada("Vlbaseipidevfornec", value);
            _vlbaseipidevfornec = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlbasepart_Desativado
    {
        get
        {
            PropriedadeAcessada("Vlbasepart_Desativado");
            return _vlbasepart_desativado;
        }
        set
        {
            PropriedadeModificada("Vlbasepart_Desativado", value);
            _vlbasepart_desativado = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlbasepiscofinsnfservico
    {
        get
        {
            PropriedadeAcessada("Vlbasepiscofinsnfservico");
            return _vlbasepiscofinsnfservico;
        }
        set
        {
            PropriedadeModificada("Vlbasepiscofinsnfservico", value);
            _vlbasepiscofinsnfservico = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlbasest
    {
        get
        {
            PropriedadeAcessada("Vlbasest");
            return _vlbasest;
        }
        set
        {
            PropriedadeModificada("Vlbasest", value);
            _vlbasest = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlcredcofinsnfservico
    {
        get
        {
            PropriedadeAcessada("Vlcredcofinsnfservico");
            return _vlcredcofinsnfservico;
        }
        set
        {
            PropriedadeModificada("Vlcredcofinsnfservico", value);
            _vlcredcofinsnfservico = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlcredpisnfservico
    {
        get
        {
            PropriedadeAcessada("Vlcredpisnfservico");
            return _vlcredpisnfservico;
        }
        set
        {
            PropriedadeModificada("Vlcredpisnfservico", value);
            _vlcredpisnfservico = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vldescboletocmv
    {
        get
        {
            PropriedadeAcessada("Vldescboletocmv");
            return _vldescboletocmv;
        }
        set
        {
            PropriedadeModificada("Vldescboletocmv", value);
            _vldescboletocmv = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vldescontonf
    {
        get
        {
            PropriedadeAcessada("Vldescontonf");
            return _vldescontonf;
        }
        set
        {
            PropriedadeModificada("Vldescontonf", value);
            _vldescontonf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 2)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 2)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 22, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlicmsmporig
    {
        get
        {
            PropriedadeAcessada("Vlicmsmporig");
            return _vlicmsmporig;
        }
        set
        {
            PropriedadeModificada("Vlicmsmporig", value);
            _vlicmsmporig = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlicmspartpbaserca
    {
        get
        {
            PropriedadeAcessada("Vlicmspartpbaserca");
            return _vlicmspartpbaserca;
        }
        set
        {
            PropriedadeModificada("Vlicmspartpbaserca", value);
            _vlicmspartpbaserca = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlicmspartptabela
    {
        get
        {
            PropriedadeAcessada("Vlicmspartptabela");
            return _vlicmspartptabela;
        }
        set
        {
            PropriedadeModificada("Vlicmspartptabela", value);
            _vlicmspartptabela = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlicms_Manif
    {
        get
        {
            PropriedadeAcessada("Vlicms_Manif");
            return _vlicms_manif;
        }
        set
        {
            PropriedadeModificada("Vlicms_Manif", value);
            _vlicms_manif = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlicms_Manual
    {
        get
        {
            PropriedadeAcessada("Vlicms_Manual");
            return _vlicms_manual;
        }
        set
        {
            PropriedadeModificada("Vlicms_Manual", value);
            _vlicms_manual = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlimpprodutorural
    {
        get
        {
            PropriedadeAcessada("Vlimpprodutorural");
            return _vlimpprodutorural;
        }
        set
        {
            PropriedadeModificada("Vlimpprodutorural", value);
            _vlimpprodutorural = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlipidevfornec
    {
        get
        {
            PropriedadeAcessada("Vlipidevfornec");
            return _vlipidevfornec;
        }
        set
        {
            PropriedadeModificada("Vlipidevfornec", value);
            _vlipidevfornec = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlipipbaserca
    {
        get
        {
            PropriedadeAcessada("Vlipipbaserca");
            return _vlipipbaserca;
        }
        set
        {
            PropriedadeModificada("Vlipipbaserca", value);
            _vlipipbaserca = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlipiptabela
    {
        get
        {
            PropriedadeAcessada("Vlipiptabela");
            return _vlipiptabela;
        }
        set
        {
            PropriedadeModificada("Vlipiptabela", value);
            _vlipiptabela = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlmateriaprima
    {
        get
        {
            PropriedadeAcessada("Vlmateriaprima");
            return _vlmateriaprima;
        }
        set
        {
            PropriedadeModificada("Vlmateriaprima", value);
            _vlmateriaprima = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlnfservico
    {
        get
        {
            PropriedadeAcessada("Vlnfservico");
            return _vlnfservico;
        }
        set
        {
            PropriedadeModificada("Vlnfservico", value);
            _vlnfservico = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlnfservicoporkg
    {
        get
        {
            PropriedadeAcessada("Vlnfservicoporkg");
            return _vlnfservicoporkg;
        }
        set
        {
            PropriedadeModificada("Vlnfservicoporkg", value);
            _vlnfservicoporkg = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vloutroscustoscont
    {
        get
        {
            PropriedadeAcessada("Vloutroscustoscont");
            return _vloutroscustoscont;
        }
        set
        {
            PropriedadeModificada("Vloutroscustoscont", value);
            _vloutroscustoscont = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vloutroscustoscustocont
    {
        get
        {
            PropriedadeAcessada("Vloutroscustoscustocont");
            return _vloutroscustoscustocont;
        }
        set
        {
            PropriedadeModificada("Vloutroscustoscustocont", value);
            _vloutroscustoscustocont = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlretencao
    {
        get
        {
            PropriedadeAcessada("Vlretencao");
            return _vlretencao;
        }
        set
        {
            PropriedadeModificada("Vlretencao", value);
            _vlretencao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlretencaosubcontratada
    {
        get
        {
            PropriedadeAcessada("Vlretencaosubcontratada");
            return _vlretencaosubcontratada;
        }
        set
        {
            PropriedadeModificada("Vlretencaosubcontratada", value);
            _vlretencaosubcontratada = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlst
    {
        get
        {
            PropriedadeAcessada("Vlst");
            return _vlst;
        }
        set
        {
            PropriedadeModificada("Vlst", value);
            _vlst = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlstoutorgado
    {
        get
        {
            PropriedadeAcessada("Vlstoutorgado");
            return _vlstoutorgado;
        }
        set
        {
            PropriedadeModificada("Vlstoutorgado", value);
            _vlstoutorgado = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlstoutrasdesp
    {
        get
        {
            PropriedadeAcessada("Vlstoutrasdesp");
            return _vlstoutrasdesp;
        }
        set
        {
            PropriedadeModificada("Vlstoutrasdesp", value);
            _vlstoutrasdesp = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 2)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vltaxaprazomedcmv
    {
        get
        {
            PropriedadeAcessada("Vltaxaprazomedcmv");
            return _vltaxaprazomedcmv;
        }
        set
        {
            PropriedadeModificada("Vltaxaprazomedcmv", value);
            _vltaxaprazomedcmv = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 23, Precisao = 10)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCOMPLEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 16, Precisao = 6)]
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

    public void InicializarAtributos()
    {
    }

    public string ObterNomeTabela()
    {
        return "PCMOVCOMPLEPREFAT";
    }

    public IEntidade NovaInstancia()
    {
        return (IEntidade)GetType().GetConstructors()[0].Invoke(null);
    }

    public void CarregarPorDataReader(IDataReader leitor)
    {
        _aliq1 = AlterarTipo<decimal?>(leitor["Aliq1"]);
        _aliqfcp = AlterarTipo<decimal?>(leitor["Aliqfcp"]);
        _aliqfcppart = AlterarTipo<decimal?>(leitor["Aliqfcppart"]);
        _aliqfcppart_desativado = AlterarTipo<decimal?>(leitor["Aliqfcppart_Desativado"]);
        _aliqicms1ultentant = AlterarTipo<decimal?>(leitor["Aliqicms1ultentant"]);
        _aliqicms1ret = AlterarTipo<decimal?>(leitor["Aliqicms1ret"]);
        _aliqicms2ultentant = AlterarTipo<decimal?>(leitor["Aliqicms2ultentant"]);
        _aliqicmsfecp = AlterarTipo<decimal?>(leitor["Aliqicmsfecp"]);
        _aliqicmspart = AlterarTipo<decimal?>(leitor["Aliqicmspart"]);
        _aliqicmspart_desativado = AlterarTipo<decimal?>(leitor["Aliqicmspart_Desativado"]);
        _aliqinternadest = AlterarTipo<decimal?>(leitor["Aliqinternadest"]);
        _aliqinterorigpart = AlterarTipo<decimal?>(leitor["Aliqinterorigpart"]);
        _aliqreducaocofins = AlterarTipo<decimal?>(leitor["Aliqreducaocofins"]);
        _aliqreducaopis = AlterarTipo<decimal?>(leitor["Aliqreducaopis"]);
        _anp = AlterarTipo<decimal?>(leitor["Anp"]);
        _anvisanumregmed = AlterarTipo<string>(leitor["Anvisanumregmed"]);
        _aplicamvabaseicms = AlterarTipo<string>(leitor["Aplicamvabaseicms"]);
        _aplicpercivapautaicmsantecip = AlterarTipo<string>(leitor["Aplicpercivapautaicmsantecip"]);
        _aplicredbaseivapliq = AlterarTipo<string>(leitor["Aplicredbaseivapliq"]);
        _aplicredbaseivapliqbcr = AlterarTipo<string>(leitor["Aplicredbaseivapliqbcr"]);
        _aproveitacredicmscont = AlterarTipo<string>(leitor["Aproveitacredicmscont"]);
        _aproveitacredpiscofinscont = AlterarTipo<string>(leitor["Aproveitacredpiscofinscont"]);
        _basebcrant = AlterarTipo<decimal?>(leitor["Basebcrant"]);
        _basecredpresumido = AlterarTipo<decimal?>(leitor["Basecredpresumido"]);
        _baseicmsantecipado = AlterarTipo<decimal?>(leitor["Baseicmsantecipado"]);
        _baseicmsimporig = AlterarTipo<decimal?>(leitor["Baseicmsimporig"]);
        _baseicms_manif = AlterarTipo<decimal?>(leitor["Baseicms_Manif"]);
        _baseimportacao = AlterarTipo<decimal?>(leitor["Baseimportacao"]);
        _baseipioutras = AlterarTipo<decimal?>(leitor["Baseipioutras"]);
        _basestoutras = AlterarTipo<decimal?>(leitor["Basestoutras"]);
        _bnfnaocalculaicms = AlterarTipo<string>(leitor["Bnfnaocalculaicms"]);
        _bonific = AlterarTipo<string>(leitor["Bonific"]);
        _cagreg = AlterarTipo<string>(leitor["Cagreg"]);
        _calccredipicont = AlterarTipo<string>(leitor["Calccredipicont"]);
        _calctribmanual = AlterarTipo<string>(leitor["Calctribmanual"]);
        _cfoporig = AlterarTipo<decimal?>(leitor["Cfoporig"]);
        _classevenda = AlterarTipo<string>(leitor["Classevenda"]);
        _cnaedesoneracao = AlterarTipo<string>(leitor["Cnaedesoneracao"]);
        _cnpjfabricante = AlterarTipo<string>(leitor["Cnpjfabricante"]);
        _cnpjsubcontratada = AlterarTipo<decimal?>(leitor["Cnpjsubcontratada"]);
        _codagregacao = AlterarTipo<string>(leitor["Codagregacao"]);
        _codbeneficiofiscal = AlterarTipo<string>(leitor["Codbeneficiofiscal"]);
        _codbeneficionota = AlterarTipo<string>(leitor["Codbeneficionota"]);
        _codcest = AlterarTipo<string>(leitor["Codcest"]);
        _codcnaeserv = AlterarTipo<decimal?>(leitor["Codcnaeserv"]);
        _codcomprador = AlterarTipo<decimal?>(leitor["Codcomprador"]);
        _codconfigfuncepmed = AlterarTipo<decimal?>(leitor["Codconfigfuncepmed"]);
        _codedital = AlterarTipo<decimal?>(leitor["Codedital"]);
        _codemitenteitempedido = AlterarTipo<decimal?>(leitor["Codemitenteitempedido"]);
        _codenqipi = AlterarTipo<string>(leitor["Codenqipi"]);
        _codfiguradesonicms = AlterarTipo<decimal?>(leitor["Codfiguradesonicms"]);
        _codfilialdest = AlterarTipo<string>(leitor["Codfilialdest"]);
        _codlinhaprazo = AlterarTipo<decimal?>(leitor["Codlinhaprazo"]);
        _codmotivoicmsdesonerado = AlterarTipo<string>(leitor["Codmotivoicmsdesonerado"]);
        _codmovinservivel = AlterarTipo<decimal?>(leitor["Codmovinservivel"]);
        _codoferta = AlterarTipo<decimal?>(leitor["Codoferta"]);
        _codpoliticadesc = AlterarTipo<decimal?>(leitor["Codpoliticadesc"]);
        _codprodacabcesta = AlterarTipo<decimal?>(leitor["Codprodacabcesta"]);
        _codprodgnre = AlterarTipo<decimal?>(leitor["Codprodgnre"]);
        _codpromocaomed = AlterarTipo<decimal?>(leitor["Codpromocaomed"]);
        _codsittribicmsfretefob = AlterarTipo<string>(leitor["Codsittribicmsfretefob"]);
        _codsittribipi = AlterarTipo<decimal?>(leitor["Codsittribipi"]);
        _codsittribpiscofinsfretefob = AlterarTipo<decimal?>(leitor["Codsittribpiscofinsfretefob"]);
        _codsittribpiscofinsnfservico = AlterarTipo<decimal?>(leitor["Codsittribpiscofinsnfservico"]);
        _codsittribst = AlterarTipo<string>(leitor["Codsittribst"]);
        _codsupervisor = AlterarTipo<decimal?>(leitor["Codsupervisor"]);
        _codtiposervico = AlterarTipo<string>(leitor["Codtiposervico"]);
        _codtribpiscofins = AlterarTipo<decimal?>(leitor["Codtribpiscofins"]);
        _codusur2 = AlterarTipo<decimal?>(leitor["Codusur2"]);
        _codusurpgcomissao = AlterarTipo<decimal?>(leitor["Codusurpgcomissao"]);
        _codusurpgcomissaoop = AlterarTipo<decimal?>(leitor["Codusurpgcomissaoop"]);
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
        _dataconsolidacaoprefat = AlterarTipo<DateTime?>(leitor["Dataconsolidacaoprefat"]);
        _deduziricmsimportacao = AlterarTipo<string>(leitor["Deduziricmsimportacao"]);
        _descanp = AlterarTipo<string>(leitor["Descanp"]);
        _descprecofab = AlterarTipo<decimal?>(leitor["Descprecofab"]);
        _descricaonfcomp = AlterarTipo<string>(leitor["Descricaonfcomp"]);
        _dtestorno = AlterarTipo<DateTime?>(leitor["Dtestorno"]);
        _dtpagcomissao = AlterarTipo<DateTime?>(leitor["Dtpagcomissao"]);
        _dtpagcomissaoop = AlterarTipo<DateTime?>(leitor["Dtpagcomissaoop"]);
        _dtregistro = AlterarTipo<DateTime?>(leitor["Dtregistro"]);
        _eancodprod = AlterarTipo<decimal?>(leitor["Eancodprod"]);
        _enderecado = AlterarTipo<string>(leitor["Enderecado"]);
        _enviaraliqreducaopiscofins = AlterarTipo<string>(leitor["Enviaraliqreducaopiscofins"]);
        _esferapublica = AlterarTipo<string>(leitor["Esferapublica"]);
        _estcomissaorca = AlterarTipo<string>(leitor["Estcomissaorca"]);
        _extipi = AlterarTipo<string>(leitor["Extipi"]);
        _fabricante = AlterarTipo<string>(leitor["Fabricante"]);
        _fatorconvcom = AlterarTipo<decimal?>(leitor["Fatorconvcom"]);
        _fatorconvemb = AlterarTipo<decimal?>(leitor["Fatorconvemb"]);
        _fatorconversaopedlicit = AlterarTipo<decimal?>(leitor["Fatorconversaopedlicit"]);
        _fatorconvtrib = AlterarTipo<decimal?>(leitor["Fatorconvtrib"]);
        _fatorconvtribex = AlterarTipo<decimal?>(leitor["Fatorconvtribex"]);
        _fatorent = AlterarTipo<decimal?>(leitor["Fatorent"]);
        _gerabasepiscofinssemaliq = AlterarTipo<string>(leitor["Gerabasepiscofinssemaliq"]);
        _icmspauta = AlterarTipo<string>(leitor["Icmspauta"]);
        _idvenda = AlterarTipo<decimal?>(leitor["Idvenda"]);
        _indescalarelevante = AlterarTipo<string>(leitor["Indescalarelevante"]);
        _iniciointervalodescquant = AlterarTipo<decimal?>(leitor["Iniciointervalodescquant"]);
        _ipiporvalor = AlterarTipo<string>(leitor["Ipiporvalor"]);
        _irretido = AlterarTipo<decimal?>(leitor["Irretido"]);
        _iva = AlterarTipo<decimal?>(leitor["Iva"]);
        _ivaultentant = AlterarTipo<decimal?>(leitor["Ivaultentant"]);
        _lotecontrato = AlterarTipo<string>(leitor["Lotecontrato"]);
        _mixacordoparceria = AlterarTipo<string>(leitor["Mixacordoparceria"]);
        _modalidadebasestfonte = AlterarTipo<decimal?>(leitor["Modalidadebasestfonte"]);
        _modbcst = AlterarTipo<decimal?>(leitor["Modbcst"]);
        _modbcstguia = AlterarTipo<decimal?>(leitor["Modbcstguia"]);
        _mostraritensnaembmaster = AlterarTipo<string>(leitor["Mostraritensnaembmaster"]);
        _movest = AlterarTipo<string>(leitor["Movest"]);
        _multimplounidademaster = AlterarTipo<string>(leitor["Multimplounidademaster"]);
        _notasubcontratada = AlterarTipo<decimal?>(leitor["Notasubcontratada"]);
        _numchaveexp = AlterarTipo<string>(leitor["Numchaveexp"]);
        _numdrawback = AlterarTipo<string>(leitor["Numdrawback"]);
        _numempenho = AlterarTipo<string>(leitor["Numempenho"]);
        _numeroprocessoserv = AlterarTipo<string>(leitor["Numeroprocessoserv"]);
        _numerorecopi = AlterarTipo<string>(leitor["Numerorecopi"]);
        _numfci = AlterarTipo<string>(leitor["Numfci"]);
        _numinvent = AlterarTipo<decimal?>(leitor["Numinvent"]);
        _numitemped = AlterarTipo<decimal?>(leitor["Numitemped"]);
        _numlista = AlterarTipo<decimal?>(leitor["Numlista"]);
        _numpedcli = AlterarTipo<string>(leitor["Numpedcli"]);
        _numrecopi = AlterarTipo<decimal?>(leitor["Numrecopi"]);
        _numregexp = AlterarTipo<decimal?>(leitor["Numregexp"]);
        _numseqent = AlterarTipo<decimal?>(leitor["Numseqent"]);
        _numseqitemcontrato = AlterarTipo<decimal?>(leitor["Numseqitemcontrato"]);
        _numseqorig = AlterarTipo<decimal?>(leitor["Numseqorig"]);
        _numseqpedagrupado = AlterarTipo<string>(leitor["Numseqpedagrupado"]);
        _numseriesat = AlterarTipo<string>(leitor["Numseriesat"]);
        _numtransentpeps = AlterarTipo<decimal?>(leitor["Numtransentpeps"]);
        _numtransitem = AlterarTipo<decimal>(leitor["Numtransitem"]);
        _numtransitemdev = AlterarTipo<decimal?>(leitor["Numtransitemdev"]);
        _numtransnumeroserie = AlterarTipo<decimal?>(leitor["Numtransnumeroserie"]);
        _numtranspeps = AlterarTipo<decimal?>(leitor["Numtranspeps"]);
        _numtranstransforig = AlterarTipo<decimal?>(leitor["Numtranstransforig"]);
        _observacaocomercialmed = AlterarTipo<string>(leitor["Observacaocomercialmed"]);
        _origmerctrib = AlterarTipo<string>(leitor["Origmerctrib"]);
        _participacomissgarantida = AlterarTipo<string>(leitor["Participacomissgarantida"]);
        _participagiro = AlterarTipo<string>(leitor["Participagiro"]);
        _patchservicopartilha = AlterarTipo<decimal?>(leitor["Patchservicopartilha"]);
        _peracrescimofuncep = AlterarTipo<decimal?>(leitor["Peracrescimofuncep"]);
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
        _percicmsdesoneracao = AlterarTipo<decimal?>(leitor["Percicmsdesoneracao"]);
        _percicmsfretefob = AlterarTipo<decimal?>(leitor["Percicmsfretefob"]);
        _percicmsfretefobicmsantecip = AlterarTipo<decimal?>(leitor["Percicmsfretefobicmsantecip"]);
        _percicmsfretefobstultentant = AlterarTipo<decimal?>(leitor["Percicmsfretefobstultentant"]);
        _percicmsimporig = AlterarTipo<decimal?>(leitor["Percicmsimporig"]);
        _percicmsredfretefob = AlterarTipo<decimal?>(leitor["Percicmsredfretefob"]);
        _percicmssimplesnac = AlterarTipo<decimal?>(leitor["Percicmssimplesnac"]);
        _percicm_manif = AlterarTipo<decimal?>(leitor["Percicm_Manif"]);
        _percipidevfornec = AlterarTipo<decimal?>(leitor["Percipidevfornec"]);
        _percipioutras = AlterarTipo<decimal?>(leitor["Percipioutras"]);
        _percipisuspenso = AlterarTipo<decimal?>(leitor["Percipisuspenso"]);
        _perciva2 = AlterarTipo<decimal?>(leitor["Perciva2"]);
        _percmvaorig = AlterarTipo<decimal?>(leitor["Percmvaorig"]);
        _percmvaorigicmsantecip = AlterarTipo<decimal?>(leitor["Percmvaorigicmsantecip"]);
        _percnfservico = AlterarTipo<decimal?>(leitor["Percnfservico"]);
        _percofinsbkp = AlterarTipo<decimal?>(leitor["Percofinsbkp"]);
        _percofinscalcdi = AlterarTipo<decimal?>(leitor["Percofinscalcdi"]);
        _percofinsfretefob = AlterarTipo<decimal?>(leitor["Percofinsfretefob"]);
        _percofinsnfservico = AlterarTipo<decimal?>(leitor["Percofinsnfservico"]);
        _percomregiaomed = AlterarTipo<decimal?>(leitor["Percomregiaomed"]);
        _percomregiaomed2 = AlterarTipo<decimal?>(leitor["Percomregiaomed2"]);
        _percoutrasdespimp = AlterarTipo<decimal?>(leitor["Percoutrasdespimp"]);
        _percoutrasdespimpcusto = AlterarTipo<decimal?>(leitor["Percoutrasdespimpcusto"]);
        _percoutroscustoscont = AlterarTipo<decimal?>(leitor["Percoutroscustoscont"]);
        _percoutroscustoscusto = AlterarTipo<decimal?>(leitor["Percoutroscustoscusto"]);
        _percoutroscustoscustocont = AlterarTipo<decimal?>(leitor["Percoutroscustoscustocont"]);
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
        _perctaxaprazomedcmv = AlterarTipo<decimal?>(leitor["Perctaxaprazomedcmv"]);
        _perdesccusto = AlterarTipo<decimal?>(leitor["Perdesccusto"]);
        _perdescfimcomiss = AlterarTipo<decimal?>(leitor["Perdescfimcomiss"]);
        _perdescinicomiss = AlterarTipo<decimal?>(leitor["Perdescinicomiss"]);
        _perdifereimentoicms = AlterarTipo<decimal?>(leitor["Perdifereimentoicms"]);
        _perfcpsn = AlterarTipo<decimal?>(leitor["Perfcpsn"]);
        _perfcpstret = AlterarTipo<decimal?>(leitor["Perfcpstret"]);
        _perpisbkp = AlterarTipo<decimal?>(leitor["Perpisbkp"]);
        _perpiscalcdi = AlterarTipo<decimal?>(leitor["Perpiscalcdi"]);
        _perpisfretefob = AlterarTipo<decimal?>(leitor["Perpisfretefob"]);
        _perpisnfservico = AlterarTipo<decimal?>(leitor["Perpisnfservico"]);
        _pesobrutofrete = AlterarTipo<decimal?>(leitor["Pesobrutofrete"]);
        _pesoliqdi = AlterarTipo<decimal?>(leitor["Pesoliqdi"]);
        _pglp = AlterarTipo<decimal?>(leitor["Pglp"]);
        _pgni = AlterarTipo<decimal?>(leitor["Pgni"]);
        _pgnn = AlterarTipo<decimal?>(leitor["Pgnn"]);
        _piscofinsdeduzido = AlterarTipo<string>(leitor["Piscofinsdeduzido"]);
        _pisretido = AlterarTipo<decimal?>(leitor["Pisretido"]);
        _poriginal = AlterarTipo<decimal?>(leitor["Poriginal"]);
        _precofab = AlterarTipo<decimal?>(leitor["Precofab"]);
        _precomaxconsum = AlterarTipo<decimal?>(leitor["Precomaxconsum"]);
        _precomaxconsumlicittab = AlterarTipo<decimal?>(leitor["Precomaxconsumlicittab"]);
        _precoutilizadonfe = AlterarTipo<string>(leitor["Precoutilizadonfe"]);
        _proddescricaodanfe = AlterarTipo<string>(leitor["Proddescricaodanfe"]);
        _prodimportadopeps = AlterarTipo<string>(leitor["Prodimportadopeps"]);
        _ptabelacusto = AlterarTipo<decimal?>(leitor["Ptabelacusto"]);
        _qtdedoacaopedlicit = AlterarTipo<decimal?>(leitor["Qtdedoacaopedlicit"]);
        _qtderrubadaparcial = AlterarTipo<decimal?>(leitor["Qtderrubadaparcial"]);
        _qtdigitada = AlterarTipo<decimal?>(leitor["Qtdigitada"]);
        _qtlitragem = AlterarTipo<decimal?>(leitor["Qtlitragem"]);
        _qtminatacvenda = AlterarTipo<decimal?>(leitor["Qtminatacvenda"]);
        _qtpedlicit = AlterarTipo<decimal?>(leitor["Qtpedlicit"]);
        _qtperda = AlterarTipo<decimal?>(leitor["Qtperda"]);
        _qtretornotv13 = AlterarTipo<decimal?>(leitor["Qtretornotv13"]);
        _qtsobra = AlterarTipo<decimal?>(leitor["Qtsobra"]);
        _qtun = AlterarTipo<decimal?>(leitor["Qtun"]);
        _qtunitlicit = AlterarTipo<decimal?>(leitor["Qtunitlicit"]);
        _qt_entradamanif = AlterarTipo<decimal?>(leitor["Qt_Entradamanif"]);
        _redbasealiqexticmsantecip = AlterarTipo<decimal?>(leitor["Redbasealiqexticmsantecip"]);
        _redbaseivaicmsantecip = AlterarTipo<decimal?>(leitor["Redbaseivaicmsantecip"]);
        _redbaseivaultentant = AlterarTipo<decimal?>(leitor["Redbaseivaultentant"]);
        _regimeespecial = AlterarTipo<string>(leitor["Regimeespecial"]);
        _regimeespisenstfonte = AlterarTipo<string>(leitor["Regimeespisenstfonte"]);
        _reterinsscprbserv = AlterarTipo<string>(leitor["Reterinsscprbserv"]);
        _retervalorincser = AlterarTipo<string>(leitor["Retervalorincser"]);
        _serienotasubcontratada = AlterarTipo<decimal?>(leitor["Serienotasubcontratada"]);
        _statuspredevolucao = AlterarTipo<string>(leitor["Statuspredevolucao"]);
        _stbcrant = AlterarTipo<decimal?>(leitor["Stbcrant"]);
        _stpbaserca = AlterarTipo<decimal?>(leitor["Stpbaserca"]);
        _stptabela = AlterarTipo<decimal?>(leitor["Stptabela"]);
        _strepassebcrmed = AlterarTipo<decimal?>(leitor["Strepassebcrmed"]);
        _substancia = AlterarTipo<string>(leitor["Substancia"]);
        _sujdesoneracao = AlterarTipo<string>(leitor["Sujdesoneracao"]);
        _temposervico = AlterarTipo<decimal?>(leitor["Temposervico"]);
        _termposervico = AlterarTipo<decimal?>(leitor["Termposervico"]);
        _tipocalcst = AlterarTipo<string>(leitor["Tipocalcst"]);
        _tipoconversaopedlicit = AlterarTipo<decimal?>(leitor["Tipoconversaopedlicit"]);
        _tipodescatacvenda = AlterarTipo<string>(leitor["Tipodescatacvenda"]);
        _tipoentrega = AlterarTipo<string>(leitor["Tipoentrega"]);
        _tipomedicamento = AlterarTipo<string>(leitor["Tipomedicamento"]);
        _tipoprocessoserv = AlterarTipo<string>(leitor["Tipoprocessoserv"]);
        _unidadeconversaopedlicit = AlterarTipo<string>(leitor["Unidadeconversaopedlicit"]);
        _unidadeemb = AlterarTipo<string>(leitor["Unidadeemb"]);
        _unidadelicit = AlterarTipo<string>(leitor["Unidadelicit"]);
        _unidadetrib = AlterarTipo<string>(leitor["Unidadetrib"]);
        _unidadetribex = AlterarTipo<string>(leitor["Unidadetribex"]);
        _usapiscofinslit = AlterarTipo<string>(leitor["Usapiscofinslit"]);
        _usapmcbasest = AlterarTipo<string>(leitor["Usapmcbasest"]);
        _usaunidademaster = AlterarTipo<string>(leitor["Usaunidademaster"]);
        _utilizabasepiscofinssusp = AlterarTipo<string>(leitor["Utilizabasepiscofinssusp"]);
        _utilizacredredpiscofins = AlterarTipo<string>(leitor["Utilizacredredpiscofins"]);
        _utilizoumotorcalculo = AlterarTipo<string>(leitor["Utilizoumotorcalculo"]);
        _versaoregistro = AlterarTipo<string>(leitor["Versaoregistro"]);
        _versaoservicopartilha = AlterarTipo<string>(leitor["Versaoservicopartilha"]);
        _vlacrescimofuncep = AlterarTipo<decimal?>(leitor["Vlacrescimofuncep"]);
        _vlacrespart = AlterarTipo<decimal?>(leitor["Vlacrespart"]);
        _vlacrespart_desativado = AlterarTipo<decimal?>(leitor["Vlacrespart_Desativado"]);
        _vladicionalbcicmsantecip = AlterarTipo<decimal?>(leitor["Vladicionalbcicmsantecip"]);
        _vladuaneiracusto = AlterarTipo<decimal?>(leitor["Vladuaneiracusto"]);
        _vlafrmm = AlterarTipo<decimal?>(leitor["Vlafrmm"]);
        _vlafrmmcusto = AlterarTipo<decimal?>(leitor["Vlafrmmcusto"]);
        _vlaltercustoent = AlterarTipo<decimal?>(leitor["Vlaltercustoent"]);
        _vlantidumping = AlterarTipo<decimal?>(leitor["Vlantidumping"]);
        _vlantidumpingcusto = AlterarTipo<decimal?>(leitor["Vlantidumpingcusto"]);
        _vlbasefcpicms = AlterarTipo<decimal?>(leitor["Vlbasefcpicms"]);
        _vlbasefcpst = AlterarTipo<decimal?>(leitor["Vlbasefcpst"]);
        _vlbasefrete = AlterarTipo<decimal?>(leitor["Vlbasefrete"]);
        _vlbaseicmsfretefob = AlterarTipo<decimal?>(leitor["Vlbaseicmsfretefob"]);
        _vlbaseipidevfornec = AlterarTipo<decimal?>(leitor["Vlbaseipidevfornec"]);
        _vlbaseipisuspenso = AlterarTipo<decimal?>(leitor["Vlbaseipisuspenso"]);
        _vlbaseoutros = AlterarTipo<decimal?>(leitor["Vlbaseoutros"]);
        _vlbasepart = AlterarTipo<decimal?>(leitor["Vlbasepart"]);
        _vlbasepartdest = AlterarTipo<decimal?>(leitor["Vlbasepartdest"]);
        _vlbasepart_desativado = AlterarTipo<decimal?>(leitor["Vlbasepart_Desativado"]);
        _vlbasepiscofinsbkp = AlterarTipo<decimal?>(leitor["Vlbasepiscofinsbkp"]);
        _vlbasepiscofinsfretefob = AlterarTipo<decimal?>(leitor["Vlbasepiscofinsfretefob"]);
        _vlbasepiscofinsnfservico = AlterarTipo<decimal?>(leitor["Vlbasepiscofinsnfservico"]);
        _vlbasest = AlterarTipo<decimal?>(leitor["Vlbasest"]);
        _vlbasestdevfornec = AlterarTipo<decimal?>(leitor["Vlbasestdevfornec"]);
        _vlbcfcpstret = AlterarTipo<decimal?>(leitor["Vlbcfcpstret"]);
        _vlcapatazia = AlterarTipo<decimal?>(leitor["Vlcapatazia"]);
        _vlcapataziacusto = AlterarTipo<decimal?>(leitor["Vlcapataziacusto"]);
        _vlcofinscalcdi = AlterarTipo<decimal?>(leitor["Vlcofinscalcdi"]);
        _vlcofinsretido = AlterarTipo<decimal?>(leitor["Vlcofinsretido"]);
        _vlcofinsretorgpub = AlterarTipo<decimal?>(leitor["Vlcofinsretorgpub"]);
        _vlcredcofinsbkp = AlterarTipo<decimal?>(leitor["Vlcredcofinsbkp"]);
        _vlcredcofinsfretefob = AlterarTipo<decimal?>(leitor["Vlcredcofinsfretefob"]);
        _vlcredcofinsnfservico = AlterarTipo<decimal?>(leitor["Vlcredcofinsnfservico"]);
        _vlcredfcpicmssn = AlterarTipo<decimal?>(leitor["Vlcredfcpicmssn"]);
        _vlcredpisbkp = AlterarTipo<decimal?>(leitor["Vlcredpisbkp"]);
        _vlcredpisfretefob = AlterarTipo<decimal?>(leitor["Vlcredpisfretefob"]);
        _vlcredpisnfservico = AlterarTipo<decimal?>(leitor["Vlcredpisnfservico"]);
        _vlcsllretido = AlterarTipo<decimal?>(leitor["Vlcsllretido"]);
        _vlcsllretorgpub = AlterarTipo<decimal?>(leitor["Vlcsllretorgpub"]);
        _vldescabatimento = AlterarTipo<decimal?>(leitor["Vldescabatimento"]);
        _vldescboletocmv = AlterarTipo<decimal?>(leitor["Vldescboletocmv"]);
        _vldescontocusto = AlterarTipo<decimal?>(leitor["Vldescontocusto"]);
        _vldescontonf = AlterarTipo<decimal?>(leitor["Vldescontonf"]);
        _vldescorgaopub = AlterarTipo<decimal?>(leitor["Vldescorgaopub"]);
        _vldescsociotorcedor = AlterarTipo<decimal?>(leitor["Vldescsociotorcedor"]);
        _vldespdentronfcusto = AlterarTipo<decimal?>(leitor["Vldespdentronfcusto"]);
        _vlfcppart = AlterarTipo<decimal?>(leitor["Vlfcppart"]);
        _vlfcpstret = AlterarTipo<decimal?>(leitor["Vlfcpstret"]);
        _vlfecp = AlterarTipo<decimal?>(leitor["Vlfecp"]);
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
        _vlicmsmporig = AlterarTipo<decimal?>(leitor["Vlicmsmporig"]);
        _vlicmspart = AlterarTipo<decimal?>(leitor["Vlicmspart"]);
        _vlicmspartdest = AlterarTipo<decimal?>(leitor["Vlicmspartdest"]);
        _vlicmspartpbaserca = AlterarTipo<decimal?>(leitor["Vlicmspartpbaserca"]);
        _vlicmspartptabela = AlterarTipo<decimal?>(leitor["Vlicmspartptabela"]);
        _vlicmspartrem = AlterarTipo<decimal?>(leitor["Vlicmspartrem"]);
        _vlicms_manif = AlterarTipo<decimal?>(leitor["Vlicms_Manif"]);
        _vlicms_manual = AlterarTipo<decimal?>(leitor["Vlicms_Manual"]);
        _vliisuspenso = AlterarTipo<decimal?>(leitor["Vliisuspenso"]);
        _vlimportacaofci = AlterarTipo<decimal?>(leitor["Vlimportacaofci"]);
        _vlimpprodutorural = AlterarTipo<decimal?>(leitor["Vlimpprodutorural"]);
        _vlipidevfornec = AlterarTipo<decimal?>(leitor["Vlipidevfornec"]);
        _vlipioutras = AlterarTipo<decimal?>(leitor["Vlipioutras"]);
        _vlipipbaserca = AlterarTipo<decimal?>(leitor["Vlipipbaserca"]);
        _vlipiptabela = AlterarTipo<decimal?>(leitor["Vlipiptabela"]);
        _vlipisuspenso = AlterarTipo<decimal?>(leitor["Vlipisuspenso"]);
        _vlirpjretorgpub = AlterarTipo<decimal?>(leitor["Vlirpjretorgpub"]);
        _vlirretido = AlterarTipo<decimal?>(leitor["Vlirretido"]);
        _vlitemtributos = AlterarTipo<decimal?>(leitor["Vlitemtributos"]);
        _vlitemtributosest = AlterarTipo<decimal?>(leitor["Vlitemtributosest"]);
        _vlitemtributosmunic = AlterarTipo<decimal?>(leitor["Vlitemtributosmunic"]);
        _vlmateriaprima = AlterarTipo<decimal?>(leitor["Vlmateriaprima"]);
        _vlnfservico = AlterarTipo<decimal?>(leitor["Vlnfservico"]);
        _vlnfservicoporkg = AlterarTipo<decimal?>(leitor["Vlnfservicoporkg"]);
        _vloutrasdespimpcusto = AlterarTipo<decimal?>(leitor["Vloutrasdespimpcusto"]);
        _vloutroscustos = AlterarTipo<decimal?>(leitor["Vloutroscustos"]);
        _vloutroscustoscont = AlterarTipo<decimal?>(leitor["Vloutroscustoscont"]);
        _vloutroscustoscusto = AlterarTipo<decimal?>(leitor["Vloutroscustoscusto"]);
        _vloutroscustoscustocont = AlterarTipo<decimal?>(leitor["Vloutroscustoscustocont"]);
        _vlparcelaimpfci = AlterarTipo<decimal?>(leitor["Vlparcelaimpfci"]);
        _vlpautaipi = AlterarTipo<decimal?>(leitor["Vlpautaipi"]);
        _vlpautapiscofins = AlterarTipo<decimal?>(leitor["Vlpautapiscofins"]);
        _vlpedagio = AlterarTipo<decimal?>(leitor["Vlpedagio"]);
        _vlpiscalcdi = AlterarTipo<decimal?>(leitor["Vlpiscalcdi"]);
        _vlpisretido = AlterarTipo<decimal?>(leitor["Vlpisretido"]);
        _vlpisretorgpub = AlterarTipo<decimal?>(leitor["Vlpisretorgpub"]);
        _vlredcmvsimplesnac = AlterarTipo<decimal?>(leitor["Vlredcmvsimplesnac"]);
        _vlredpvendasimplesna = AlterarTipo<decimal?>(leitor["Vlredpvendasimplesna"]);
        _vlretencao = AlterarTipo<decimal?>(leitor["Vlretencao"]);
        _vlretencaosubcontratada = AlterarTipo<decimal?>(leitor["Vlretencaosubcontratada"]);
        _vlricmssimplesnac = AlterarTipo<decimal?>(leitor["Vlricmssimplesnac"]);
        _vlsegurocusto = AlterarTipo<decimal?>(leitor["Vlsegurocusto"]);
        _vlsiscomexcusto = AlterarTipo<decimal?>(leitor["Vlsiscomexcusto"]);
        _vlst = AlterarTipo<decimal?>(leitor["Vlst"]);
        _vlstdevfornec = AlterarTipo<decimal?>(leitor["Vlstdevfornec"]);
        _vlstguiaultentant = AlterarTipo<decimal?>(leitor["Vlstguiaultentant"]);
        _vlstoutorgado = AlterarTipo<decimal?>(leitor["Vlstoutorgado"]);
        _vlstoutras = AlterarTipo<decimal?>(leitor["Vlstoutras"]);
        _vlstoutrasdesp = AlterarTipo<decimal?>(leitor["Vlstoutrasdesp"]);
        _vlstultentant = AlterarTipo<decimal?>(leitor["Vlstultentant"]);
        _vlsubtotdesconto = AlterarTipo<decimal?>(leitor["Vlsubtotdesconto"]);
        _vlsubtotitem = AlterarTipo<decimal?>(leitor["Vlsubtotitem"]);
        _vltaxaprazomedcmv = AlterarTipo<decimal?>(leitor["Vltaxaprazomedcmv"]);
        _vpart = AlterarTipo<decimal?>(leitor["Vpart"]);
        _vlbaseipiecf = AlterarTipo<decimal?>(leitor["Vlbaseipiecf"]);
        _percipiecf = AlterarTipo<decimal?>(leitor["Percipiecf"]);
        _vlipiecf = AlterarTipo<decimal?>(leitor["Vlipiecf"]);
        _percredbaseefet = AlterarTipo<decimal?>(leitor["Percredbaseefet"]);
        _vlbaseefet = AlterarTipo<decimal?>(leitor["Vlbaseefet"]);
        _percicmsefet = AlterarTipo<decimal?>(leitor["Percicmsefet"]);
        _vlicmsefet = AlterarTipo<decimal?>(leitor["Vlicmsefet"]);
        _vlicmsefet = AlterarTipo<decimal?>(leitor["Numtransultentstant"]);
    }

}