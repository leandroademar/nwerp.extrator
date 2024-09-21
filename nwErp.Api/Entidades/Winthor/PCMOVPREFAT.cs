

////// // namespace nwErp.Entidades.Winthor;

// // namespace nwErp.Api.Modelos;

[Serializable]
public class PCMOVPREFAT : GerenteDePropriedades, IEntidade
{
    private decimal? _aliqavulsadare;

    private decimal? _aliqicmfreteent;

    private decimal? _aliqicmoutrasdespent;

    private decimal? _aliqicms1;

    private decimal? _aliqicms2;

    private decimal? _aliqicmsvigente;

    private decimal? _aliqicst;

    private decimal? _aliqstsaida;

    private decimal? _aliquotatis;

    private string _alternativo;

    private string _aplicpercivapauta;

    private string _aproveitacredicms;

    private string _aproveitacreditoicms;

    private string _aproveitacredpiscofins;

    private decimal? _baseacrescimopf;

    private decimal? _basebcr;

    private decimal? _basedifaliquotas;

    private decimal? _baseicms;

    private decimal? _baseicms2;

    private decimal? _baseicmsadicional;

    private decimal? _baseicmsbcr;

    private decimal? _baseicmsultent;

    private decimal? _baseicmsultentant;

    private decimal? _baseicst;

    private decimal? _baseivamex;

    private decimal? _basestsaida;

    private decimal? _bciss;

    private string _brinde;

    private string _calcbcrmanual;

    private string _calccredipi;

    private decimal? _capvoldnf;

    private string _classificfiscal;

    private decimal? _codauxiliar;

    private string _codbase;

    private decimal? _codcertific;

    private decimal? _codcli;

    private decimal? _coddesconto;

    private decimal? _coddevol;

    private string _codecf;

    private decimal? _codepto;

    private decimal? _codequipamento;

    private string _codfilial;

    private string _codfilialnf;

    private string _codfilialretira;

    private decimal? _codfiscal;

    private decimal? _codfiscalfreteent;

    private decimal? _codfiscaloutrasdespent;

    private string _codformula;

    private decimal? _codfornec;

    private decimal? _codfornecprod;

    private decimal? _codfuncconf;

    private decimal? _codfuncembal;

    private decimal? _codfuncexportacaowms;

    private decimal? _codfuncimportacaowms;

    private decimal? _codfunclanc;

    private decimal? _codfuncquarentena;

    private decimal? _codfuncreq;

    private decimal? _codgenerofiscal;

    private decimal? _codicmtab;

    private string _codinterno;

    private decimal? _codmotorista;

    private string _codoper;

    private decimal? _codpassefiscal;

    private decimal? _codplpag;

    private decimal _codprod;

    private decimal? _codproddnf;

    private decimal? _codprodprinc;

    private decimal? _codprodrelev;

    private string _codprodsintegra;

    private string _codpromocao;

    private decimal? _codsec;

    private decimal? _codsittribpiscofins;

    private decimal? _codst;

    private decimal? _codusur;

    private decimal? _codvasilhame;

    private string _complemento;

    private string _compraconsignado;

    private string _controlanumserie;

    private decimal? _custocont;

    private decimal? _custocontant;

    private decimal? _custofin;

    private decimal? _custofinant;

    private decimal? _custofinest;

    private decimal? _custofornec;

    private decimal? _custonfsemst;

    private decimal? _custonfsemstant;

    private decimal? _custoreal;

    private decimal? _custorealant;

    private decimal? _custorealsemst;

    private decimal? _custorealsemstant;

    private decimal? _custorep;

    private decimal? _custorepant;

    private decimal? _custoultent;

    private decimal? _custoultentant;

    private decimal? _custoultentant2;

    private decimal? _custoultentfin;

    private decimal? _custoultentfinant;

    private decimal? _custoultentmed;

    private decimal? _custoultentmedant;

    private DateTime? _dataconsolidacaoprefat;

    private DateTime? _datafabricacao;

    private DateTime? _datalibquarentena;

    private DateTime? _datavalidade;

    private string _descricao;

    private string _descricao1;

    private DateTime? _dtapuracao;

    private DateTime? _dtcancel;

    private DateTime? _dtdenegada;

    private DateTime? _dtexportacaoservint;

    private DateTime? _dtexportacaowms;

    private DateTime? _dtfimconf;

    private DateTime? _dtimportacaoservprinc;

    private DateTime? _dtimportacaowms;

    private DateTime? _dtinicioconf;

    private DateTime _dtmov;

    private DateTime? _dtmovlog;

    private DateTime? _dtultentant;

    private DateTime? _dtwms;

    private decimal? _dv;

    private string _embalagem;

    private string _equiplanc;

    private string _estoquedesbloqueado;

    private string _exportadoservint;

    private decimal? _fatorconvdnf;

    private decimal? _fatorcustonatransf;

    private string _funclanc;

    private string _fundapiano;

    private string _geragnre_cnpjcliente;

    private string _geraicmslivrofiscal;

    private string _historico;

    private string _horalanc;

    private DateTime? _horaproducao;

    private decimal? _icmsressarc;

    private string _importado;

    private string _importadoservprinc;

    private string _indlocal;

    private string _issretido;

    private string _itemdivergente;

    private decimal? _iva;

    private decimal? _ivaressarc;

    private decimal? _ivatribut;

    private string _localizacao;

    private string _minutolanc;

    private string _movestoquecontabil;

    private string _movestoquegerencial;

    private string _movimentacontacorrenterca;

    private string _nbm;

    private decimal? _numadicao;

    private decimal? _numbono;

    private decimal? _numbonus;

    private decimal? _numcar;

    private decimal? _numcaranterior;

    private decimal? _numformulario;

    private decimal? _numformulario2;

    private string _numidf;

    private decimal? _numlanccp;

    private string _numlote;

    private string _numlotefab;

    private decimal? _numnegociacao;

    private decimal? _numnota;

    private decimal? _numnotadev;

    private decimal? _numop;

    private decimal? _numped;

    private decimal? _numregiao;

    private decimal? _numseq;

    private decimal? _numseqadicao;

    private decimal? _numseqped;

    private decimal? _numtransavulsa;

    private decimal? _numtransdev;

    private decimal? _numtransdevfor;

    private decimal? _numtransent;

    private decimal? _numtransentorigdesdlote;

    private decimal? _numtransentultent;

    private decimal? _numtransentultentant;

    private decimal? _numtranshistorico;

    private decimal _numtransitem;

    private decimal? _numtransop;

    private decimal? _numtransvenda;

    private decimal? _numverbaoutras;

    private decimal? _numverbarebcmv;

    private decimal? _numvolumesconferencia;

    private string _pagtognrenomedoremetente;

    private string _passelivre;

    private decimal? _pauta;

    private decimal? _pbaserca;

    private decimal? _pbonific;

    private decimal? _peracrescimocusto;

    private decimal? _peracrescimopf;

    private decimal? _perbonific;

    private decimal? _percagregadorst;

    private decimal? _percaliqext2;

    private decimal? _percaliqextguia;

    private decimal? _percaliqexticmantecip;

    private decimal? _percaliqint2;

    private decimal? _percaliqinticmantecip;

    private decimal? _percbasered;

    private decimal? _percbaseredadicional;

    private decimal? _percbaseredst;

    private decimal? _percbaseredstfonte;

    private decimal? _percbon;

    private decimal? _percbonoutras;

    private decimal? _perccredicmpresumido;

    private decimal? _percdesc;

    private decimal? _percdesccofins;

    private decimal? _percdescfin;

    private decimal? _percdescicmsdif;

    private decimal? _percdescpis;

    private decimal? _percdespadicional;

    private decimal? _percdespdentronf;

    private decimal? _percdespfin;

    private decimal? _percdespforanf;

    private decimal? _percdifaliquotas;

    private decimal? _percdireitosaduaneiros;

    private decimal? _percfrete;

    private decimal? _percfretefob;

    private decimal? _percicm;

    private decimal? _percicm2;

    private decimal? _percicmcp;

    private decimal? _percicmop;

    private decimal? _percicmoriginal;

    private decimal? _percicmred;

    private decimal? _percicmsdiferido;

    private decimal? _percicmsfretefobst;

    private decimal? _perciisuspenso;

    private decimal? _percimportacao;

    private decimal? _percimpostoconsumo;

    private decimal? _percimpostoselo;

    private decimal? _percimpprodutorural;

    private decimal? _percimpureza;

    private decimal? _percinss;

    private decimal? _percinteiro;

    private decimal? _percipi;

    private decimal? _perciss;

    private decimal? _perciva;

    private decimal? _perciva2;

    private decimal? _percivaicmantecip;

    private decimal? _percivamex;

    private decimal? _percmexfpgc;

    private decimal? _percmexieps;

    private decimal? _percmexiva;

    private decimal? _percofins;

    private decimal? _percom;

    private decimal? _percom2;

    private decimal? _percom3;

    private decimal? _percom4;

    private decimal? _percomfilialbroker;

    private decimal? _percommot;

    private decimal? _percomsup;

    private decimal? _percoutrasdesp;

    private decimal? _percoutroscustos;

    private decimal? _percquebrado;

    private decimal? _percredicms;

    private decimal? _percseguro;

    private decimal? _percst;

    private decimal? _percsuframa;

    private decimal? _percumidade;

    private decimal? _percvenda;

    private decimal? _percvermelho;

    private decimal? _percvlbonific;

    private decimal? _perdesccom;

    private decimal? _perdesccusto;

    private decimal? _perdescfin;

    private decimal? _perdescflex;

    private decimal? _perdescisentoicms;

    private decimal? _perfretecmv;

    private decimal? _pericm;

    private decimal? _pericmfrete;

    private decimal? _pericmguiapropria;

    private decimal? _pericmsantecipado;

    private decimal? _perpis;

    private decimal? _perredcomiss;

    private decimal? _perredcomisssup;

    private decimal? _pesobruto;

    private decimal? _pesoliq;

    private string _piscofinsretido;

    private decimal? _pliqped;

    private decimal? _prazomedio;

    private decimal? _precopauta;

    private string _prodbonificado;

    private string _proddescricaocontrato;

    private string _promocaobiro;

    private decimal? _ptabela;

    private decimal? _ptabela2;

    private decimal? _punit;

    private decimal? _punitcont;

    private decimal? _punitnf;

    private decimal? _pvenda1;

    private decimal? _pvendabase;

    private decimal? _pvendaemb;

    private decimal? _pvendaembalagem;

    private decimal? _qt;

    private decimal? _qtavaria;

    private decimal? _qtbloqueada;

    private decimal? _qtconf;

    private decimal? _qtcont;

    private decimal? _qtcx;

    private decimal? _qtdevol;

    private decimal? _qtembalagem;

    private decimal? _qtestant;

    private decimal? _qtestgerant;

    private decimal? _qthoras;

    private decimal? _qtpecas;

    private decimal? _qtsaldoest;

    private decimal? _qtsaldoestger;

    private decimal? _qtultentant;

    private decimal? _qtunit;

    private decimal? _qtunitcx;

    private decimal? _qtunitemb;

    private decimal? _qtvendaemb;

    private string _qualdivergencia;

    private decimal? _redbasealiqext;

    private decimal? _redbaseiva;

    private string _refcor;

    private string _rotinacad;

    private string _rotinalanc;

    private decimal? _rua;

    private decimal? _seqmov;

    private string _siglaqualidade;

    private string _sittribut;

    private decimal? _st;

    private string _status;

    private decimal? _stbcr;

    private decimal? _stclientegnre;

    private decimal? _stsaida;

    private string _tipodescaplicado;

    private string _tipoembalagempedido;

    private string _tipofornec;

    private string _tipoitem;

    private string _tipomerc;

    private string _tipomercdepto;

    private string _tiposeparacao;

    private string _tipotis;

    private string _tipotributmedic;

    private string _transacaotransferida;

    private string _trgpclote;

    private string _tribfederal;

    private string _truncaritem;

    private decimal? _txvenda;

    private string _uffornec;

    private string _unidade;

    private string _usadebcredrcabrind;

    private decimal? _valordireitosaduaneiros;

    private decimal? _valorimpostoconsumo;

    private decimal? _valorimpostoselo;

    private decimal? _valorultent;

    private decimal? _valorultentant;

    private decimal? _valorultentmed;

    private decimal? _valorultentmedant;

    private decimal? _vlacrescimopf;

    private decimal? _vlacrescrodape;

    private decimal? _vladicionalbcst;

    private decimal? _vladuaneira;

    private decimal? _vlbasegnre;

    private decimal? _vlbaseipi;

    private decimal? _vlbasepiscofins;

    private decimal? _vlbasestforanf;

    private decimal? _vlbonific;

    private decimal? _vlbonificoutras;

    private decimal? _vlcofins;

    private decimal? _vlcredcofins;

    private decimal? _vlcredicms;

    private decimal? _vlcredicmsfrete;

    private decimal? _vlcredpis;

    private decimal? _vlcredpresumido;

    private decimal? _vldesccom;

    private decimal? _vldesccustocmv;

    private decimal? _vldescfin;

    private decimal? _vldescflex;

    private decimal? _vldescicmisencao;

    private decimal? _vldescicmsdif;

    private decimal? _vldesconto;

    private decimal? _vldescpissuframa;

    private decimal? _vldescreducaocofins;

    private decimal? _vldescreducaopis;

    private decimal? _vldescrodape;

    private decimal? _vldescsuframa;

    private decimal? _vldespadicional;

    private decimal? _vldespdentronf;

    private decimal? _vldespforanf;

    private decimal? _vldifaliquotas;

    private decimal? _vldifpunitcont;

    private decimal? _vlfrete;

    private decimal? _vlfreteconhec;

    private decimal? _vlfreteporkg;

    private decimal? _vlfrete_rateio;

    private decimal? _vlicmsbcr;

    private decimal? _vlicmsdiferido;

    private decimal? _vlimportacao;

    private decimal? _vlindeniz;

    private decimal? _vlinss;

    private decimal? _vlipi;

    private decimal? _vlipiporkg;

    private decimal? _vliss;

    private decimal? _vlivamex;

    private decimal? _vlmexfpgc;

    private decimal? _vlmexieps;

    private decimal? _vlmexiva;

    private decimal? _vloutrasdesp;

    private decimal? _vloutrasdespimp;

    private decimal? _vloutras_rateio;

    private decimal? _vloutros;

    private decimal? _vlpauta2;

    private decimal? _vlpautaicms;

    private decimal? _vlpautaicmsantec;

    private decimal? _vlpercbon;

    private decimal? _vlpis;

    private decimal? _vlredcomiss;

    private decimal? _vlredcomisssup;

    private decimal? _vlrepasse;

    private decimal? _vlseguro;

    private decimal? _vlsiscomex;

    private decimal? _vlsuframa;

    private decimal? _vlultentcontsemst;

    private decimal? _vlultentcontsemstant;

    private decimal? _vlverbacmv;

    private decimal? _vlverbacmvcli;

    private decimal? _volume;

    private decimal? _volumedesejado;

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 2)]
    public decimal? Aliqavulsadare
    {
        get
        {
            PropriedadeAcessada("Aliqavulsadare");
            return _aliqavulsadare;
        }
        set
        {
            PropriedadeModificada("Aliqavulsadare", value);
            _aliqavulsadare = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 2)]
    public decimal? Aliqicmfreteent
    {
        get
        {
            PropriedadeAcessada("Aliqicmfreteent");
            return _aliqicmfreteent;
        }
        set
        {
            PropriedadeModificada("Aliqicmfreteent", value);
            _aliqicmfreteent = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 2)]
    public decimal? Aliqicmoutrasdespent
    {
        get
        {
            PropriedadeAcessada("Aliqicmoutrasdespent");
            return _aliqicmoutrasdespent;
        }
        set
        {
            PropriedadeModificada("Aliqicmoutrasdespent", value);
            _aliqicmoutrasdespent = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 2)]
    public decimal? Aliqicmsvigente
    {
        get
        {
            PropriedadeAcessada("Aliqicmsvigente");
            return _aliqicmsvigente;
        }
        set
        {
            PropriedadeModificada("Aliqicmsvigente", value);
            _aliqicmsvigente = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 2)]
    public decimal? Aliqicst
    {
        get
        {
            PropriedadeAcessada("Aliqicst");
            return _aliqicst;
        }
        set
        {
            PropriedadeModificada("Aliqicst", value);
            _aliqicst = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Aliqstsaida
    {
        get
        {
            PropriedadeAcessada("Aliqstsaida");
            return _aliqstsaida;
        }
        set
        {
            PropriedadeModificada("Aliqstsaida", value);
            _aliqstsaida = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 2)]
    public decimal? Aliquotatis
    {
        get
        {
            PropriedadeAcessada("Aliquotatis");
            return _aliquotatis;
        }
        set
        {
            PropriedadeModificada("Aliquotatis", value);
            _aliquotatis = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 10, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Aplicpercivapauta
    {
        get
        {
            PropriedadeAcessada("Aplicpercivapauta");
            return _aplicpercivapauta;
        }
        set
        {
            PropriedadeModificada("Aplicpercivapauta", value);
            _aplicpercivapauta = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Aproveitacredicms
    {
        get
        {
            PropriedadeAcessada("Aproveitacredicms");
            return _aproveitacredicms;
        }
        set
        {
            PropriedadeModificada("Aproveitacredicms", value);
            _aproveitacredicms = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Aproveitacreditoicms
    {
        get
        {
            PropriedadeAcessada("Aproveitacreditoicms");
            return _aproveitacreditoicms;
        }
        set
        {
            PropriedadeModificada("Aproveitacreditoicms", value);
            _aproveitacreditoicms = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Aproveitacredpiscofins
    {
        get
        {
            PropriedadeAcessada("Aproveitacredpiscofins");
            return _aproveitacredpiscofins;
        }
        set
        {
            PropriedadeModificada("Aproveitacredpiscofins", value);
            _aproveitacredpiscofins = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Baseacrescimopf
    {
        get
        {
            PropriedadeAcessada("Baseacrescimopf");
            return _baseacrescimopf;
        }
        set
        {
            PropriedadeModificada("Baseacrescimopf", value);
            _baseacrescimopf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Basebcr
    {
        get
        {
            PropriedadeAcessada("Basebcr");
            return _basebcr;
        }
        set
        {
            PropriedadeModificada("Basebcr", value);
            _basebcr = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Baseicms2
    {
        get
        {
            PropriedadeAcessada("Baseicms2");
            return _baseicms2;
        }
        set
        {
            PropriedadeModificada("Baseicms2", value);
            _baseicms2 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Baseicmsadicional
    {
        get
        {
            PropriedadeAcessada("Baseicmsadicional");
            return _baseicmsadicional;
        }
        set
        {
            PropriedadeModificada("Baseicmsadicional", value);
            _baseicmsadicional = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Baseicmsbcr
    {
        get
        {
            PropriedadeAcessada("Baseicmsbcr");
            return _baseicmsbcr;
        }
        set
        {
            PropriedadeModificada("Baseicmsbcr", value);
            _baseicmsbcr = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Baseicmsultent
    {
        get
        {
            PropriedadeAcessada("Baseicmsultent");
            return _baseicmsultent;
        }
        set
        {
            PropriedadeModificada("Baseicmsultent", value);
            _baseicmsultent = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Baseicmsultentant
    {
        get
        {
            PropriedadeAcessada("Baseicmsultentant");
            return _baseicmsultentant;
        }
        set
        {
            PropriedadeModificada("Baseicmsultentant", value);
            _baseicmsultentant = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Baseivamex
    {
        get
        {
            PropriedadeAcessada("Baseivamex");
            return _baseivamex;
        }
        set
        {
            PropriedadeModificada("Baseivamex", value);
            _baseivamex = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Basestsaida
    {
        get
        {
            PropriedadeAcessada("Basestsaida");
            return _basestsaida;
        }
        set
        {
            PropriedadeModificada("Basestsaida", value);
            _basestsaida = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Calcbcrmanual
    {
        get
        {
            PropriedadeAcessada("Calcbcrmanual");
            return _calcbcrmanual;
        }
        set
        {
            PropriedadeModificada("Calcbcrmanual", value);
            _calcbcrmanual = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Calccredipi
    {
        get
        {
            PropriedadeAcessada("Calccredipi");
            return _calccredipi;
        }
        set
        {
            PropriedadeModificada("Calccredipi", value);
            _calccredipi = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 0)]
    public decimal? Capvoldnf
    {
        get
        {
            PropriedadeAcessada("Capvoldnf");
            return _capvoldnf;
        }
        set
        {
            PropriedadeModificada("Capvoldnf", value);
            _capvoldnf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
    public string Classificfiscal
    {
        get
        {
            PropriedadeAcessada("Classificfiscal");
            return _classificfiscal;
        }
        set
        {
            PropriedadeModificada("Classificfiscal", value);
            _classificfiscal = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 20, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codcli
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Coddevol
    {
        get
        {
            PropriedadeAcessada("Coddevol");
            return _coddevol;
        }
        set
        {
            PropriedadeModificada("Coddevol", value);
            _coddevol = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codepto
    {
        get
        {
            PropriedadeAcessada("Codepto");
            return _codepto;
        }
        set
        {
            PropriedadeModificada("Codepto", value);
            _codepto = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Codequipamento
    {
        get
        {
            PropriedadeAcessada("Codequipamento");
            return _codequipamento;
        }
        set
        {
            PropriedadeModificada("Codequipamento", value);
            _codequipamento = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Codfilialnf
    {
        get
        {
            PropriedadeAcessada("Codfilialnf");
            return _codfilialnf;
        }
        set
        {
            PropriedadeModificada("Codfilialnf", value);
            _codfilialnf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Codfiscalfreteent
    {
        get
        {
            PropriedadeAcessada("Codfiscalfreteent");
            return _codfiscalfreteent;
        }
        set
        {
            PropriedadeModificada("Codfiscalfreteent", value);
            _codfiscalfreteent = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Codfiscaloutrasdespent
    {
        get
        {
            PropriedadeAcessada("Codfiscaloutrasdespent");
            return _codfiscaloutrasdespent;
        }
        set
        {
            PropriedadeModificada("Codfiscaloutrasdespent", value);
            _codfiscaloutrasdespent = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codfornecprod
    {
        get
        {
            PropriedadeAcessada("Codfornecprod");
            return _codfornecprod;
        }
        set
        {
            PropriedadeModificada("Codfornecprod", value);
            _codfornecprod = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfuncembal
    {
        get
        {
            PropriedadeAcessada("Codfuncembal");
            return _codfuncembal;
        }
        set
        {
            PropriedadeModificada("Codfuncembal", value);
            _codfuncembal = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfuncexportacaowms
    {
        get
        {
            PropriedadeAcessada("Codfuncexportacaowms");
            return _codfuncexportacaowms;
        }
        set
        {
            PropriedadeModificada("Codfuncexportacaowms", value);
            _codfuncexportacaowms = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfuncimportacaowms
    {
        get
        {
            PropriedadeAcessada("Codfuncimportacaowms");
            return _codfuncimportacaowms;
        }
        set
        {
            PropriedadeModificada("Codfuncimportacaowms", value);
            _codfuncimportacaowms = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfuncquarentena
    {
        get
        {
            PropriedadeAcessada("Codfuncquarentena");
            return _codfuncquarentena;
        }
        set
        {
            PropriedadeModificada("Codfuncquarentena", value);
            _codfuncquarentena = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfuncreq
    {
        get
        {
            PropriedadeAcessada("Codfuncreq");
            return _codfuncreq;
        }
        set
        {
            PropriedadeModificada("Codfuncreq", value);
            _codfuncreq = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codgenerofiscal
    {
        get
        {
            PropriedadeAcessada("Codgenerofiscal");
            return _codgenerofiscal;
        }
        set
        {
            PropriedadeModificada("Codgenerofiscal", value);
            _codgenerofiscal = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
    public string Codinterno
    {
        get
        {
            PropriedadeAcessada("Codinterno");
            return _codinterno;
        }
        set
        {
            PropriedadeModificada("Codinterno", value);
            _codinterno = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codmotorista
    {
        get
        {
            PropriedadeAcessada("Codmotorista");
            return _codmotorista;
        }
        set
        {
            PropriedadeModificada("Codmotorista", value);
            _codmotorista = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Codoper
    {
        get
        {
            PropriedadeAcessada("Codoper");
            return _codoper;
        }
        set
        {
            PropriedadeModificada("Codoper", value);
            _codoper = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codpassefiscal
    {
        get
        {
            PropriedadeAcessada("Codpassefiscal");
            return _codpassefiscal;
        }
        set
        {
            PropriedadeModificada("Codpassefiscal", value);
            _codpassefiscal = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 3, Precisao = 0)]
    public decimal? Codproddnf
    {
        get
        {
            PropriedadeAcessada("Codproddnf");
            return _codproddnf;
        }
        set
        {
            PropriedadeModificada("Codproddnf", value);
            _codproddnf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codprodprinc
    {
        get
        {
            PropriedadeAcessada("Codprodprinc");
            return _codprodprinc;
        }
        set
        {
            PropriedadeModificada("Codprodprinc", value);
            _codprodprinc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Codprodrelev
    {
        get
        {
            PropriedadeAcessada("Codprodrelev");
            return _codprodrelev;
        }
        set
        {
            PropriedadeModificada("Codprodrelev", value);
            _codprodrelev = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
    public string Codprodsintegra
    {
        get
        {
            PropriedadeAcessada("Codprodsintegra");
            return _codprodsintegra;
        }
        set
        {
            PropriedadeModificada("Codprodsintegra", value);
            _codprodsintegra = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 10, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codsec
    {
        get
        {
            PropriedadeAcessada("Codsec");
            return _codsec;
        }
        set
        {
            PropriedadeModificada("Codsec", value);
            _codsec = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 3, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codusur
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Compraconsignado
    {
        get
        {
            PropriedadeAcessada("Compraconsignado");
            return _compraconsignado;
        }
        set
        {
            PropriedadeModificada("Compraconsignado", value);
            _compraconsignado = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Controlanumserie
    {
        get
        {
            PropriedadeAcessada("Controlanumserie");
            return _controlanumserie;
        }
        set
        {
            PropriedadeModificada("Controlanumserie", value);
            _controlanumserie = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Custocont
    {
        get
        {
            PropriedadeAcessada("Custocont");
            return _custocont;
        }
        set
        {
            PropriedadeModificada("Custocont", value);
            _custocont = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Custocontant
    {
        get
        {
            PropriedadeAcessada("Custocontant");
            return _custocontant;
        }
        set
        {
            PropriedadeModificada("Custocontant", value);
            _custocontant = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Custofin
    {
        get
        {
            PropriedadeAcessada("Custofin");
            return _custofin;
        }
        set
        {
            PropriedadeModificada("Custofin", value);
            _custofin = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Custofinant
    {
        get
        {
            PropriedadeAcessada("Custofinant");
            return _custofinant;
        }
        set
        {
            PropriedadeModificada("Custofinant", value);
            _custofinant = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Custofornec
    {
        get
        {
            PropriedadeAcessada("Custofornec");
            return _custofornec;
        }
        set
        {
            PropriedadeModificada("Custofornec", value);
            _custofornec = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Custonfsemst
    {
        get
        {
            PropriedadeAcessada("Custonfsemst");
            return _custonfsemst;
        }
        set
        {
            PropriedadeModificada("Custonfsemst", value);
            _custonfsemst = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Custonfsemstant
    {
        get
        {
            PropriedadeAcessada("Custonfsemstant");
            return _custonfsemstant;
        }
        set
        {
            PropriedadeModificada("Custonfsemstant", value);
            _custonfsemstant = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Custoreal
    {
        get
        {
            PropriedadeAcessada("Custoreal");
            return _custoreal;
        }
        set
        {
            PropriedadeModificada("Custoreal", value);
            _custoreal = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Custorealant
    {
        get
        {
            PropriedadeAcessada("Custorealant");
            return _custorealant;
        }
        set
        {
            PropriedadeModificada("Custorealant", value);
            _custorealant = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Custorealsemst
    {
        get
        {
            PropriedadeAcessada("Custorealsemst");
            return _custorealsemst;
        }
        set
        {
            PropriedadeModificada("Custorealsemst", value);
            _custorealsemst = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Custorealsemstant
    {
        get
        {
            PropriedadeAcessada("Custorealsemstant");
            return _custorealsemstant;
        }
        set
        {
            PropriedadeModificada("Custorealsemstant", value);
            _custorealsemstant = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Custorep
    {
        get
        {
            PropriedadeAcessada("Custorep");
            return _custorep;
        }
        set
        {
            PropriedadeModificada("Custorep", value);
            _custorep = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Custorepant
    {
        get
        {
            PropriedadeAcessada("Custorepant");
            return _custorepant;
        }
        set
        {
            PropriedadeModificada("Custorepant", value);
            _custorepant = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Custoultent
    {
        get
        {
            PropriedadeAcessada("Custoultent");
            return _custoultent;
        }
        set
        {
            PropriedadeModificada("Custoultent", value);
            _custoultent = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Custoultentant
    {
        get
        {
            PropriedadeAcessada("Custoultentant");
            return _custoultentant;
        }
        set
        {
            PropriedadeModificada("Custoultentant", value);
            _custoultentant = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Custoultentant2
    {
        get
        {
            PropriedadeAcessada("Custoultentant2");
            return _custoultentant2;
        }
        set
        {
            PropriedadeModificada("Custoultentant2", value);
            _custoultentant2 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Custoultentfin
    {
        get
        {
            PropriedadeAcessada("Custoultentfin");
            return _custoultentfin;
        }
        set
        {
            PropriedadeModificada("Custoultentfin", value);
            _custoultentfin = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Custoultentfinant
    {
        get
        {
            PropriedadeAcessada("Custoultentfinant");
            return _custoultentfinant;
        }
        set
        {
            PropriedadeModificada("Custoultentfinant", value);
            _custoultentfinant = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Custoultentmed
    {
        get
        {
            PropriedadeAcessada("Custoultentmed");
            return _custoultentmed;
        }
        set
        {
            PropriedadeModificada("Custoultentmed", value);
            _custoultentmed = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Custoultentmedant
    {
        get
        {
            PropriedadeAcessada("Custoultentmedant");
            return _custoultentmedant;
        }
        set
        {
            PropriedadeModificada("Custoultentmedant", value);
            _custoultentmedant = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Datafabricacao
    {
        get
        {
            PropriedadeAcessada("Datafabricacao");
            return _datafabricacao;
        }
        set
        {
            PropriedadeModificada("Datafabricacao", value);
            _datafabricacao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Datalibquarentena
    {
        get
        {
            PropriedadeAcessada("Datalibquarentena");
            return _datalibquarentena;
        }
        set
        {
            PropriedadeModificada("Datalibquarentena", value);
            _datalibquarentena = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Datavalidade
    {
        get
        {
            PropriedadeAcessada("Datavalidade");
            return _datavalidade;
        }
        set
        {
            PropriedadeModificada("Datavalidade", value);
            _datavalidade = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
    public string Descricao
    {
        get
        {
            PropriedadeAcessada("Descricao");
            return _descricao;
        }
        set
        {
            PropriedadeModificada("Descricao", value);
            _descricao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 45, Precisao = 0)]
    public string Descricao1
    {
        get
        {
            PropriedadeAcessada("Descricao1");
            return _descricao1;
        }
        set
        {
            PropriedadeModificada("Descricao1", value);
            _descricao1 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtapuracao
    {
        get
        {
            PropriedadeAcessada("Dtapuracao");
            return _dtapuracao;
        }
        set
        {
            PropriedadeModificada("Dtapuracao", value);
            _dtapuracao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtcancel
    {
        get
        {
            PropriedadeAcessada("Dtcancel");
            return _dtcancel;
        }
        set
        {
            PropriedadeModificada("Dtcancel", value);
            _dtcancel = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtdenegada
    {
        get
        {
            PropriedadeAcessada("Dtdenegada");
            return _dtdenegada;
        }
        set
        {
            PropriedadeModificada("Dtdenegada", value);
            _dtdenegada = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtexportacaowms
    {
        get
        {
            PropriedadeAcessada("Dtexportacaowms");
            return _dtexportacaowms;
        }
        set
        {
            PropriedadeModificada("Dtexportacaowms", value);
            _dtexportacaowms = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtfimconf
    {
        get
        {
            PropriedadeAcessada("Dtfimconf");
            return _dtfimconf;
        }
        set
        {
            PropriedadeModificada("Dtfimconf", value);
            _dtfimconf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtimportacaowms
    {
        get
        {
            PropriedadeAcessada("Dtimportacaowms");
            return _dtimportacaowms;
        }
        set
        {
            PropriedadeModificada("Dtimportacaowms", value);
            _dtimportacaowms = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtinicioconf
    {
        get
        {
            PropriedadeAcessada("Dtinicioconf");
            return _dtinicioconf;
        }
        set
        {
            PropriedadeModificada("Dtinicioconf", value);
            _dtinicioconf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime Dtmov
    {
        get
        {
            PropriedadeAcessada("Dtmov");
            return _dtmov;
        }
        set
        {
            PropriedadeModificada("Dtmov", value);
            _dtmov = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtmovlog
    {
        get
        {
            PropriedadeAcessada("Dtmovlog");
            return _dtmovlog;
        }
        set
        {
            PropriedadeModificada("Dtmovlog", value);
            _dtmovlog = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtultentant
    {
        get
        {
            PropriedadeAcessada("Dtultentant");
            return _dtultentant;
        }
        set
        {
            PropriedadeModificada("Dtultentant", value);
            _dtultentant = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtwms
    {
        get
        {
            PropriedadeAcessada("Dtwms");
            return _dtwms;
        }
        set
        {
            PropriedadeModificada("Dtwms", value);
            _dtwms = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 1, Precisao = 0)]
    public decimal? Dv
    {
        get
        {
            PropriedadeAcessada("Dv");
            return _dv;
        }
        set
        {
            PropriedadeModificada("Dv", value);
            _dv = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 12, Precisao = 0)]
    public string Embalagem
    {
        get
        {
            PropriedadeAcessada("Embalagem");
            return _embalagem;
        }
        set
        {
            PropriedadeModificada("Embalagem", value);
            _embalagem = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 64, Precisao = 0)]
    public string Equiplanc
    {
        get
        {
            PropriedadeAcessada("Equiplanc");
            return _equiplanc;
        }
        set
        {
            PropriedadeModificada("Equiplanc", value);
            _equiplanc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Estoquedesbloqueado
    {
        get
        {
            PropriedadeAcessada("Estoquedesbloqueado");
            return _estoquedesbloqueado;
        }
        set
        {
            PropriedadeModificada("Estoquedesbloqueado", value);
            _estoquedesbloqueado = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Fatorconvdnf
    {
        get
        {
            PropriedadeAcessada("Fatorconvdnf");
            return _fatorconvdnf;
        }
        set
        {
            PropriedadeModificada("Fatorconvdnf", value);
            _fatorconvdnf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Fatorcustonatransf
    {
        get
        {
            PropriedadeAcessada("Fatorcustonatransf");
            return _fatorcustonatransf;
        }
        set
        {
            PropriedadeModificada("Fatorcustonatransf", value);
            _fatorcustonatransf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 30, Precisao = 0)]
    public string Funclanc
    {
        get
        {
            PropriedadeAcessada("Funclanc");
            return _funclanc;
        }
        set
        {
            PropriedadeModificada("Funclanc", value);
            _funclanc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Fundapiano
    {
        get
        {
            PropriedadeAcessada("Fundapiano");
            return _fundapiano;
        }
        set
        {
            PropriedadeModificada("Fundapiano", value);
            _fundapiano = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Geraicmslivrofiscal
    {
        get
        {
            PropriedadeAcessada("Geraicmslivrofiscal");
            return _geraicmslivrofiscal;
        }
        set
        {
            PropriedadeModificada("Geraicmslivrofiscal", value);
            _geraicmslivrofiscal = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Historico
    {
        get
        {
            PropriedadeAcessada("Historico");
            return _historico;
        }
        set
        {
            PropriedadeModificada("Historico", value);
            _historico = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Horalanc
    {
        get
        {
            PropriedadeAcessada("Horalanc");
            return _horalanc;
        }
        set
        {
            PropriedadeModificada("Horalanc", value);
            _horalanc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Horaproducao
    {
        get
        {
            PropriedadeAcessada("Horaproducao");
            return _horaproducao;
        }
        set
        {
            PropriedadeModificada("Horaproducao", value);
            _horaproducao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 2)]
    public decimal? Icmsressarc
    {
        get
        {
            PropriedadeAcessada("Icmsressarc");
            return _icmsressarc;
        }
        set
        {
            PropriedadeModificada("Icmsressarc", value);
            _icmsressarc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Indlocal
    {
        get
        {
            PropriedadeAcessada("Indlocal");
            return _indlocal;
        }
        set
        {
            PropriedadeModificada("Indlocal", value);
            _indlocal = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Issretido
    {
        get
        {
            PropriedadeAcessada("Issretido");
            return _issretido;
        }
        set
        {
            PropriedadeModificada("Issretido", value);
            _issretido = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Itemdivergente
    {
        get
        {
            PropriedadeAcessada("Itemdivergente");
            return _itemdivergente;
        }
        set
        {
            PropriedadeModificada("Itemdivergente", value);
            _itemdivergente = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 2)]
    public decimal? Ivaressarc
    {
        get
        {
            PropriedadeAcessada("Ivaressarc");
            return _ivaressarc;
        }
        set
        {
            PropriedadeModificada("Ivaressarc", value);
            _ivaressarc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Ivatribut
    {
        get
        {
            PropriedadeAcessada("Ivatribut");
            return _ivatribut;
        }
        set
        {
            PropriedadeModificada("Ivatribut", value);
            _ivatribut = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Minutolanc
    {
        get
        {
            PropriedadeAcessada("Minutolanc");
            return _minutolanc;
        }
        set
        {
            PropriedadeModificada("Minutolanc", value);
            _minutolanc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Movestoquecontabil
    {
        get
        {
            PropriedadeAcessada("Movestoquecontabil");
            return _movestoquecontabil;
        }
        set
        {
            PropriedadeModificada("Movestoquecontabil", value);
            _movestoquecontabil = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Movestoquegerencial
    {
        get
        {
            PropriedadeAcessada("Movestoquegerencial");
            return _movestoquegerencial;
        }
        set
        {
            PropriedadeModificada("Movestoquegerencial", value);
            _movestoquegerencial = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 15, Precisao = 0)]
    public string Nbm
    {
        get
        {
            PropriedadeAcessada("Nbm");
            return _nbm;
        }
        set
        {
            PropriedadeModificada("Nbm", value);
            _nbm = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 3, Precisao = 0)]
    public decimal? Numadicao
    {
        get
        {
            PropriedadeAcessada("Numadicao");
            return _numadicao;
        }
        set
        {
            PropriedadeModificada("Numadicao", value);
            _numadicao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Numbono
    {
        get
        {
            PropriedadeAcessada("Numbono");
            return _numbono;
        }
        set
        {
            PropriedadeModificada("Numbono", value);
            _numbono = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numbonus
    {
        get
        {
            PropriedadeAcessada("Numbonus");
            return _numbonus;
        }
        set
        {
            PropriedadeModificada("Numbonus", value);
            _numbonus = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Numcaranterior
    {
        get
        {
            PropriedadeAcessada("Numcaranterior");
            return _numcaranterior;
        }
        set
        {
            PropriedadeModificada("Numcaranterior", value);
            _numcaranterior = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numformulario
    {
        get
        {
            PropriedadeAcessada("Numformulario");
            return _numformulario;
        }
        set
        {
            PropriedadeModificada("Numformulario", value);
            _numformulario = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numformulario2
    {
        get
        {
            PropriedadeAcessada("Numformulario2");
            return _numformulario2;
        }
        set
        {
            PropriedadeModificada("Numformulario2", value);
            _numformulario2 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 30, Precisao = 0)]
    public string Numidf
    {
        get
        {
            PropriedadeAcessada("Numidf");
            return _numidf;
        }
        set
        {
            PropriedadeModificada("Numidf", value);
            _numidf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Numlanccp
    {
        get
        {
            PropriedadeAcessada("Numlanccp");
            return _numlanccp;
        }
        set
        {
            PropriedadeModificada("Numlanccp", value);
            _numlanccp = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 15, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
    public string Numlotefab
    {
        get
        {
            PropriedadeAcessada("Numlotefab");
            return _numlotefab;
        }
        set
        {
            PropriedadeModificada("Numlotefab", value);
            _numlotefab = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Numnegociacao
    {
        get
        {
            PropriedadeAcessada("Numnegociacao");
            return _numnegociacao;
        }
        set
        {
            PropriedadeModificada("Numnegociacao", value);
            _numnegociacao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numnota
    {
        get
        {
            PropriedadeAcessada("Numnota");
            return _numnota;
        }
        set
        {
            PropriedadeModificada("Numnota", value);
            _numnota = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numnotadev
    {
        get
        {
            PropriedadeAcessada("Numnotadev");
            return _numnotadev;
        }
        set
        {
            PropriedadeModificada("Numnotadev", value);
            _numnotadev = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Numregiao
    {
        get
        {
            PropriedadeAcessada("Numregiao");
            return _numregiao;
        }
        set
        {
            PropriedadeModificada("Numregiao", value);
            _numregiao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 20, Precisao = 0)]
    public decimal? Numseq
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 3, Precisao = 0)]
    public decimal? Numseqadicao
    {
        get
        {
            PropriedadeAcessada("Numseqadicao");
            return _numseqadicao;
        }
        set
        {
            PropriedadeModificada("Numseqadicao", value);
            _numseqadicao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Numseqped
    {
        get
        {
            PropriedadeAcessada("Numseqped");
            return _numseqped;
        }
        set
        {
            PropriedadeModificada("Numseqped", value);
            _numseqped = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numtransavulsa
    {
        get
        {
            PropriedadeAcessada("Numtransavulsa");
            return _numtransavulsa;
        }
        set
        {
            PropriedadeModificada("Numtransavulsa", value);
            _numtransavulsa = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numtransdev
    {
        get
        {
            PropriedadeAcessada("Numtransdev");
            return _numtransdev;
        }
        set
        {
            PropriedadeModificada("Numtransdev", value);
            _numtransdev = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numtransdevfor
    {
        get
        {
            PropriedadeAcessada("Numtransdevfor");
            return _numtransdevfor;
        }
        set
        {
            PropriedadeModificada("Numtransdevfor", value);
            _numtransdevfor = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numtransent
    {
        get
        {
            PropriedadeAcessada("Numtransent");
            return _numtransent;
        }
        set
        {
            PropriedadeModificada("Numtransent", value);
            _numtransent = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numtransentorigdesdlote
    {
        get
        {
            PropriedadeAcessada("Numtransentorigdesdlote");
            return _numtransentorigdesdlote;
        }
        set
        {
            PropriedadeModificada("Numtransentorigdesdlote", value);
            _numtransentorigdesdlote = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numtransentultent
    {
        get
        {
            PropriedadeAcessada("Numtransentultent");
            return _numtransentultent;
        }
        set
        {
            PropriedadeModificada("Numtransentultent", value);
            _numtransentultent = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numtransentultentant
    {
        get
        {
            PropriedadeAcessada("Numtransentultentant");
            return _numtransentultentant;
        }
        set
        {
            PropriedadeModificada("Numtransentultentant", value);
            _numtransentultentant = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 0)]
    public decimal? Numtranshistorico
    {
        get
        {
            PropriedadeAcessada("Numtranshistorico");
            return _numtranshistorico;
        }
        set
        {
            PropriedadeModificada("Numtranshistorico", value);
            _numtranshistorico = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numtransop
    {
        get
        {
            PropriedadeAcessada("Numtransop");
            return _numtransop;
        }
        set
        {
            PropriedadeModificada("Numtransop", value);
            _numtransop = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numtransvenda
    {
        get
        {
            PropriedadeAcessada("Numtransvenda");
            return _numtransvenda;
        }
        set
        {
            PropriedadeModificada("Numtransvenda", value);
            _numtransvenda = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Numverbaoutras
    {
        get
        {
            PropriedadeAcessada("Numverbaoutras");
            return _numverbaoutras;
        }
        set
        {
            PropriedadeModificada("Numverbaoutras", value);
            _numverbaoutras = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Pagtognrenomedoremetente
    {
        get
        {
            PropriedadeAcessada("Pagtognrenomedoremetente");
            return _pagtognrenomedoremetente;
        }
        set
        {
            PropriedadeModificada("Pagtognrenomedoremetente", value);
            _pagtognrenomedoremetente = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Passelivre
    {
        get
        {
            PropriedadeAcessada("Passelivre");
            return _passelivre;
        }
        set
        {
            PropriedadeModificada("Passelivre", value);
            _passelivre = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Peracrescimopf
    {
        get
        {
            PropriedadeAcessada("Peracrescimopf");
            return _peracrescimopf;
        }
        set
        {
            PropriedadeModificada("Peracrescimopf", value);
            _peracrescimopf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Percaliqext2
    {
        get
        {
            PropriedadeAcessada("Percaliqext2");
            return _percaliqext2;
        }
        set
        {
            PropriedadeModificada("Percaliqext2", value);
            _percaliqext2 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Percaliqextguia
    {
        get
        {
            PropriedadeAcessada("Percaliqextguia");
            return _percaliqextguia;
        }
        set
        {
            PropriedadeModificada("Percaliqextguia", value);
            _percaliqextguia = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Percaliqexticmantecip
    {
        get
        {
            PropriedadeAcessada("Percaliqexticmantecip");
            return _percaliqexticmantecip;
        }
        set
        {
            PropriedadeModificada("Percaliqexticmantecip", value);
            _percaliqexticmantecip = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Percaliqint2
    {
        get
        {
            PropriedadeAcessada("Percaliqint2");
            return _percaliqint2;
        }
        set
        {
            PropriedadeModificada("Percaliqint2", value);
            _percaliqint2 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Percaliqinticmantecip
    {
        get
        {
            PropriedadeAcessada("Percaliqinticmantecip");
            return _percaliqinticmantecip;
        }
        set
        {
            PropriedadeModificada("Percaliqinticmantecip", value);
            _percaliqinticmantecip = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Percbaseredadicional
    {
        get
        {
            PropriedadeAcessada("Percbaseredadicional");
            return _percbaseredadicional;
        }
        set
        {
            PropriedadeModificada("Percbaseredadicional", value);
            _percbaseredadicional = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Percbon
    {
        get
        {
            PropriedadeAcessada("Percbon");
            return _percbon;
        }
        set
        {
            PropriedadeModificada("Percbon", value);
            _percbon = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 2)]
    public decimal? Percbonoutras
    {
        get
        {
            PropriedadeAcessada("Percbonoutras");
            return _percbonoutras;
        }
        set
        {
            PropriedadeModificada("Percbonoutras", value);
            _percbonoutras = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Perccredicmpresumido
    {
        get
        {
            PropriedadeAcessada("Perccredicmpresumido");
            return _perccredicmpresumido;
        }
        set
        {
            PropriedadeModificada("Perccredicmpresumido", value);
            _perccredicmpresumido = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Percdesc
    {
        get
        {
            PropriedadeAcessada("Percdesc");
            return _percdesc;
        }
        set
        {
            PropriedadeModificada("Percdesc", value);
            _percdesc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Percdescfin
    {
        get
        {
            PropriedadeAcessada("Percdescfin");
            return _percdescfin;
        }
        set
        {
            PropriedadeModificada("Percdescfin", value);
            _percdescfin = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Percdescicmsdif
    {
        get
        {
            PropriedadeAcessada("Percdescicmsdif");
            return _percdescicmsdif;
        }
        set
        {
            PropriedadeModificada("Percdescicmsdif", value);
            _percdescicmsdif = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Percdespadicional
    {
        get
        {
            PropriedadeAcessada("Percdespadicional");
            return _percdespadicional;
        }
        set
        {
            PropriedadeModificada("Percdespadicional", value);
            _percdespadicional = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Percdespdentronf
    {
        get
        {
            PropriedadeAcessada("Percdespdentronf");
            return _percdespdentronf;
        }
        set
        {
            PropriedadeModificada("Percdespdentronf", value);
            _percdespdentronf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Percdespfin
    {
        get
        {
            PropriedadeAcessada("Percdespfin");
            return _percdespfin;
        }
        set
        {
            PropriedadeModificada("Percdespfin", value);
            _percdespfin = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Percdespforanf
    {
        get
        {
            PropriedadeAcessada("Percdespforanf");
            return _percdespforanf;
        }
        set
        {
            PropriedadeModificada("Percdespforanf", value);
            _percdespforanf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Percdireitosaduaneiros
    {
        get
        {
            PropriedadeAcessada("Percdireitosaduaneiros");
            return _percdireitosaduaneiros;
        }
        set
        {
            PropriedadeModificada("Percdireitosaduaneiros", value);
            _percdireitosaduaneiros = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Percfrete
    {
        get
        {
            PropriedadeAcessada("Percfrete");
            return _percfrete;
        }
        set
        {
            PropriedadeModificada("Percfrete", value);
            _percfrete = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Percfretefob
    {
        get
        {
            PropriedadeAcessada("Percfretefob");
            return _percfretefob;
        }
        set
        {
            PropriedadeModificada("Percfretefob", value);
            _percfretefob = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 2)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 2)]
    public decimal? Percicm2
    {
        get
        {
            PropriedadeAcessada("Percicm2");
            return _percicm2;
        }
        set
        {
            PropriedadeModificada("Percicm2", value);
            _percicm2 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 2)]
    public decimal? Percicmcp
    {
        get
        {
            PropriedadeAcessada("Percicmcp");
            return _percicmcp;
        }
        set
        {
            PropriedadeModificada("Percicmcp", value);
            _percicmcp = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 2)]
    public decimal? Percicmop
    {
        get
        {
            PropriedadeAcessada("Percicmop");
            return _percicmop;
        }
        set
        {
            PropriedadeModificada("Percicmop", value);
            _percicmop = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 2)]
    public decimal? Percicmoriginal
    {
        get
        {
            PropriedadeAcessada("Percicmoriginal");
            return _percicmoriginal;
        }
        set
        {
            PropriedadeModificada("Percicmoriginal", value);
            _percicmoriginal = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Percicmred
    {
        get
        {
            PropriedadeAcessada("Percicmred");
            return _percicmred;
        }
        set
        {
            PropriedadeModificada("Percicmred", value);
            _percicmred = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Percicmsdiferido
    {
        get
        {
            PropriedadeAcessada("Percicmsdiferido");
            return _percicmsdiferido;
        }
        set
        {
            PropriedadeModificada("Percicmsdiferido", value);
            _percicmsdiferido = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Percicmsfretefobst
    {
        get
        {
            PropriedadeAcessada("Percicmsfretefobst");
            return _percicmsfretefobst;
        }
        set
        {
            PropriedadeModificada("Percicmsfretefobst", value);
            _percicmsfretefobst = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Perciisuspenso
    {
        get
        {
            PropriedadeAcessada("Perciisuspenso");
            return _perciisuspenso;
        }
        set
        {
            PropriedadeModificada("Perciisuspenso", value);
            _perciisuspenso = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 2)]
    public decimal? Percimportacao
    {
        get
        {
            PropriedadeAcessada("Percimportacao");
            return _percimportacao;
        }
        set
        {
            PropriedadeModificada("Percimportacao", value);
            _percimportacao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Percimpostoconsumo
    {
        get
        {
            PropriedadeAcessada("Percimpostoconsumo");
            return _percimpostoconsumo;
        }
        set
        {
            PropriedadeModificada("Percimpostoconsumo", value);
            _percimpostoconsumo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Percimpostoselo
    {
        get
        {
            PropriedadeAcessada("Percimpostoselo");
            return _percimpostoselo;
        }
        set
        {
            PropriedadeModificada("Percimpostoselo", value);
            _percimpostoselo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 2)]
    public decimal? Percimpprodutorural
    {
        get
        {
            PropriedadeAcessada("Percimpprodutorural");
            return _percimpprodutorural;
        }
        set
        {
            PropriedadeModificada("Percimpprodutorural", value);
            _percimpprodutorural = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 3)]
    public decimal? Percimpureza
    {
        get
        {
            PropriedadeAcessada("Percimpureza");
            return _percimpureza;
        }
        set
        {
            PropriedadeModificada("Percimpureza", value);
            _percimpureza = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Percinss
    {
        get
        {
            PropriedadeAcessada("Percinss");
            return _percinss;
        }
        set
        {
            PropriedadeModificada("Percinss", value);
            _percinss = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 3)]
    public decimal? Percinteiro
    {
        get
        {
            PropriedadeAcessada("Percinteiro");
            return _percinteiro;
        }
        set
        {
            PropriedadeModificada("Percinteiro", value);
            _percinteiro = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Perciva
    {
        get
        {
            PropriedadeAcessada("Perciva");
            return _perciva;
        }
        set
        {
            PropriedadeModificada("Perciva", value);
            _perciva = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Percivaicmantecip
    {
        get
        {
            PropriedadeAcessada("Percivaicmantecip");
            return _percivaicmantecip;
        }
        set
        {
            PropriedadeModificada("Percivaicmantecip", value);
            _percivaicmantecip = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Percivamex
    {
        get
        {
            PropriedadeAcessada("Percivamex");
            return _percivamex;
        }
        set
        {
            PropriedadeModificada("Percivamex", value);
            _percivamex = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 6)]
    public decimal? Percmexfpgc
    {
        get
        {
            PropriedadeAcessada("Percmexfpgc");
            return _percmexfpgc;
        }
        set
        {
            PropriedadeModificada("Percmexfpgc", value);
            _percmexfpgc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 6)]
    public decimal? Percmexieps
    {
        get
        {
            PropriedadeAcessada("Percmexieps");
            return _percmexieps;
        }
        set
        {
            PropriedadeModificada("Percmexieps", value);
            _percmexieps = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 6)]
    public decimal? Percmexiva
    {
        get
        {
            PropriedadeAcessada("Percmexiva");
            return _percmexiva;
        }
        set
        {
            PropriedadeModificada("Percmexiva", value);
            _percmexiva = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Percomfilialbroker
    {
        get
        {
            PropriedadeAcessada("Percomfilialbroker");
            return _percomfilialbroker;
        }
        set
        {
            PropriedadeModificada("Percomfilialbroker", value);
            _percomfilialbroker = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Percommot
    {
        get
        {
            PropriedadeAcessada("Percommot");
            return _percommot;
        }
        set
        {
            PropriedadeModificada("Percommot", value);
            _percommot = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Percoutrasdesp
    {
        get
        {
            PropriedadeAcessada("Percoutrasdesp");
            return _percoutrasdesp;
        }
        set
        {
            PropriedadeModificada("Percoutrasdesp", value);
            _percoutrasdesp = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Percoutroscustos
    {
        get
        {
            PropriedadeAcessada("Percoutroscustos");
            return _percoutroscustos;
        }
        set
        {
            PropriedadeModificada("Percoutroscustos", value);
            _percoutroscustos = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 3)]
    public decimal? Percquebrado
    {
        get
        {
            PropriedadeAcessada("Percquebrado");
            return _percquebrado;
        }
        set
        {
            PropriedadeModificada("Percquebrado", value);
            _percquebrado = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 2)]
    public decimal? Percredicms
    {
        get
        {
            PropriedadeAcessada("Percredicms");
            return _percredicms;
        }
        set
        {
            PropriedadeModificada("Percredicms", value);
            _percredicms = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Percseguro
    {
        get
        {
            PropriedadeAcessada("Percseguro");
            return _percseguro;
        }
        set
        {
            PropriedadeModificada("Percseguro", value);
            _percseguro = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Percst
    {
        get
        {
            PropriedadeAcessada("Percst");
            return _percst;
        }
        set
        {
            PropriedadeModificada("Percst", value);
            _percst = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Percsuframa
    {
        get
        {
            PropriedadeAcessada("Percsuframa");
            return _percsuframa;
        }
        set
        {
            PropriedadeModificada("Percsuframa", value);
            _percsuframa = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 3)]
    public decimal? Percumidade
    {
        get
        {
            PropriedadeAcessada("Percumidade");
            return _percumidade;
        }
        set
        {
            PropriedadeModificada("Percumidade", value);
            _percumidade = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 2)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 3)]
    public decimal? Percvermelho
    {
        get
        {
            PropriedadeAcessada("Percvermelho");
            return _percvermelho;
        }
        set
        {
            PropriedadeModificada("Percvermelho", value);
            _percvermelho = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Percvlbonific
    {
        get
        {
            PropriedadeAcessada("Percvlbonific");
            return _percvlbonific;
        }
        set
        {
            PropriedadeModificada("Percvlbonific", value);
            _percvlbonific = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 2)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 2)]
    public decimal? Pericm
    {
        get
        {
            PropriedadeAcessada("Pericm");
            return _pericm;
        }
        set
        {
            PropriedadeModificada("Pericm", value);
            _pericm = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 2)]
    public decimal? Pericmfrete
    {
        get
        {
            PropriedadeAcessada("Pericmfrete");
            return _pericmfrete;
        }
        set
        {
            PropriedadeModificada("Pericmfrete", value);
            _pericmfrete = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 2)]
    public decimal? Pericmguiapropria
    {
        get
        {
            PropriedadeAcessada("Pericmguiapropria");
            return _pericmguiapropria;
        }
        set
        {
            PropriedadeModificada("Pericmguiapropria", value);
            _pericmguiapropria = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Pericmsantecipado
    {
        get
        {
            PropriedadeAcessada("Pericmsantecipado");
            return _pericmsantecipado;
        }
        set
        {
            PropriedadeModificada("Pericmsantecipado", value);
            _pericmsantecipado = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 6)]
    public decimal? Pesoliq
    {
        get
        {
            PropriedadeAcessada("Pesoliq");
            return _pesoliq;
        }
        set
        {
            PropriedadeModificada("Pesoliq", value);
            _pesoliq = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Piscofinsretido
    {
        get
        {
            PropriedadeAcessada("Piscofinsretido");
            return _piscofinsretido;
        }
        set
        {
            PropriedadeModificada("Piscofinsretido", value);
            _piscofinsretido = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Pliqped
    {
        get
        {
            PropriedadeAcessada("Pliqped");
            return _pliqped;
        }
        set
        {
            PropriedadeModificada("Pliqped", value);
            _pliqped = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Precopauta
    {
        get
        {
            PropriedadeAcessada("Precopauta");
            return _precopauta;
        }
        set
        {
            PropriedadeModificada("Precopauta", value);
            _precopauta = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Prodbonificado
    {
        get
        {
            PropriedadeAcessada("Prodbonificado");
            return _prodbonificado;
        }
        set
        {
            PropriedadeModificada("Prodbonificado", value);
            _prodbonificado = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 300, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Promocaobiro
    {
        get
        {
            PropriedadeAcessada("Promocaobiro");
            return _promocaobiro;
        }
        set
        {
            PropriedadeModificada("Promocaobiro", value);
            _promocaobiro = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Ptabela
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Ptabela2
    {
        get
        {
            PropriedadeAcessada("Ptabela2");
            return _ptabela2;
        }
        set
        {
            PropriedadeModificada("Ptabela2", value);
            _ptabela2 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Punit
    {
        get
        {
            PropriedadeAcessada("Punit");
            return _punit;
        }
        set
        {
            PropriedadeModificada("Punit", value);
            _punit = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Punitcont
    {
        get
        {
            PropriedadeAcessada("Punitcont");
            return _punitcont;
        }
        set
        {
            PropriedadeModificada("Punitcont", value);
            _punitcont = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Punitnf
    {
        get
        {
            PropriedadeAcessada("Punitnf");
            return _punitnf;
        }
        set
        {
            PropriedadeModificada("Punitnf", value);
            _punitnf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 3)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 20, Precisao = 6)]
    public decimal? Qt
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 20, Precisao = 6)]
    public decimal? Qtavaria
    {
        get
        {
            PropriedadeAcessada("Qtavaria");
            return _qtavaria;
        }
        set
        {
            PropriedadeModificada("Qtavaria", value);
            _qtavaria = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 20, Precisao = 6)]
    public decimal? Qtbloqueada
    {
        get
        {
            PropriedadeAcessada("Qtbloqueada");
            return _qtbloqueada;
        }
        set
        {
            PropriedadeModificada("Qtbloqueada", value);
            _qtbloqueada = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 20, Precisao = 6)]
    public decimal? Qtconf
    {
        get
        {
            PropriedadeAcessada("Qtconf");
            return _qtconf;
        }
        set
        {
            PropriedadeModificada("Qtconf", value);
            _qtconf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 20, Precisao = 6)]
    public decimal? Qtcont
    {
        get
        {
            PropriedadeAcessada("Qtcont");
            return _qtcont;
        }
        set
        {
            PropriedadeModificada("Qtcont", value);
            _qtcont = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 20, Precisao = 6)]
    public decimal? Qtdevol
    {
        get
        {
            PropriedadeAcessada("Qtdevol");
            return _qtdevol;
        }
        set
        {
            PropriedadeModificada("Qtdevol", value);
            _qtdevol = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 3)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 16, Precisao = 3)]
    public decimal? Qtestant
    {
        get
        {
            PropriedadeAcessada("Qtestant");
            return _qtestant;
        }
        set
        {
            PropriedadeModificada("Qtestant", value);
            _qtestant = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 16, Precisao = 3)]
    public decimal? Qtestgerant
    {
        get
        {
            PropriedadeAcessada("Qtestgerant");
            return _qtestgerant;
        }
        set
        {
            PropriedadeModificada("Qtestgerant", value);
            _qtestgerant = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 2)]
    public decimal? Qthoras
    {
        get
        {
            PropriedadeAcessada("Qthoras");
            return _qthoras;
        }
        set
        {
            PropriedadeModificada("Qthoras", value);
            _qthoras = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 16, Precisao = 3)]
    public decimal? Qtsaldoest
    {
        get
        {
            PropriedadeAcessada("Qtsaldoest");
            return _qtsaldoest;
        }
        set
        {
            PropriedadeModificada("Qtsaldoest", value);
            _qtsaldoest = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 16, Precisao = 3)]
    public decimal? Qtsaldoestger
    {
        get
        {
            PropriedadeAcessada("Qtsaldoestger");
            return _qtsaldoestger;
        }
        set
        {
            PropriedadeModificada("Qtsaldoestger", value);
            _qtsaldoestger = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 16, Precisao = 3)]
    public decimal? Qtultentant
    {
        get
        {
            PropriedadeAcessada("Qtultentant");
            return _qtultentant;
        }
        set
        {
            PropriedadeModificada("Qtultentant", value);
            _qtultentant = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 2)]
    public decimal? Qtunit
    {
        get
        {
            PropriedadeAcessada("Qtunit");
            return _qtunit;
        }
        set
        {
            PropriedadeModificada("Qtunit", value);
            _qtunit = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 2)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 3)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 6, Precisao = 0)]
    public string Qualdivergencia
    {
        get
        {
            PropriedadeAcessada("Qualdivergencia");
            return _qualdivergencia;
        }
        set
        {
            PropriedadeModificada("Qualdivergencia", value);
            _qualdivergencia = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Redbasealiqext
    {
        get
        {
            PropriedadeAcessada("Redbasealiqext");
            return _redbasealiqext;
        }
        set
        {
            PropriedadeModificada("Redbasealiqext", value);
            _redbasealiqext = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Redbaseiva
    {
        get
        {
            PropriedadeAcessada("Redbaseiva");
            return _redbaseiva;
        }
        set
        {
            PropriedadeModificada("Redbaseiva", value);
            _redbaseiva = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 48, Precisao = 0)]
    public string Rotinacad
    {
        get
        {
            PropriedadeAcessada("Rotinacad");
            return _rotinacad;
        }
        set
        {
            PropriedadeModificada("Rotinacad", value);
            _rotinacad = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 48, Precisao = 0)]
    public string Rotinalanc
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Rua
    {
        get
        {
            PropriedadeAcessada("Rua");
            return _rua;
        }
        set
        {
            PropriedadeModificada("Rua", value);
            _rua = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 0)]
    public decimal? Seqmov
    {
        get
        {
            PropriedadeAcessada("Seqmov");
            return _seqmov;
        }
        set
        {
            PropriedadeModificada("Seqmov", value);
            _seqmov = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 10, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 3, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? St
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Status
    {
        get
        {
            PropriedadeAcessada("Status");
            return _status;
        }
        set
        {
            PropriedadeModificada("Status", value);
            _status = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Stbcr
    {
        get
        {
            PropriedadeAcessada("Stbcr");
            return _stbcr;
        }
        set
        {
            PropriedadeModificada("Stbcr", value);
            _stbcr = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Stsaida
    {
        get
        {
            PropriedadeAcessada("Stsaida");
            return _stsaida;
        }
        set
        {
            PropriedadeModificada("Stsaida", value);
            _stsaida = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Tipoembalagempedido
    {
        get
        {
            PropriedadeAcessada("Tipoembalagempedido");
            return _tipoembalagempedido;
        }
        set
        {
            PropriedadeModificada("Tipoembalagempedido", value);
            _tipoembalagempedido = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Tipofornec
    {
        get
        {
            PropriedadeAcessada("Tipofornec");
            return _tipofornec;
        }
        set
        {
            PropriedadeModificada("Tipofornec", value);
            _tipofornec = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Tipoitem
    {
        get
        {
            PropriedadeAcessada("Tipoitem");
            return _tipoitem;
        }
        set
        {
            PropriedadeModificada("Tipoitem", value);
            _tipoitem = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Tipomercdepto
    {
        get
        {
            PropriedadeAcessada("Tipomercdepto");
            return _tipomercdepto;
        }
        set
        {
            PropriedadeModificada("Tipomercdepto", value);
            _tipomercdepto = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Tipotis
    {
        get
        {
            PropriedadeAcessada("Tipotis");
            return _tipotis;
        }
        set
        {
            PropriedadeModificada("Tipotis", value);
            _tipotis = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Tipotributmedic
    {
        get
        {
            PropriedadeAcessada("Tipotributmedic");
            return _tipotributmedic;
        }
        set
        {
            PropriedadeModificada("Tipotributmedic", value);
            _tipotributmedic = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Transacaotransferida
    {
        get
        {
            PropriedadeAcessada("Transacaotransferida");
            return _transacaotransferida;
        }
        set
        {
            PropriedadeModificada("Transacaotransferida", value);
            _transacaotransferida = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Trgpclote
    {
        get
        {
            PropriedadeAcessada("Trgpclote");
            return _trgpclote;
        }
        set
        {
            PropriedadeModificada("Trgpclote", value);
            _trgpclote = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 15, Precisao = 0)]
    public string Tribfederal
    {
        get
        {
            PropriedadeAcessada("Tribfederal");
            return _tribfederal;
        }
        set
        {
            PropriedadeModificada("Tribfederal", value);
            _tribfederal = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Uffornec
    {
        get
        {
            PropriedadeAcessada("Uffornec");
            return _uffornec;
        }
        set
        {
            PropriedadeModificada("Uffornec", value);
            _uffornec = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Valordireitosaduaneiros
    {
        get
        {
            PropriedadeAcessada("Valordireitosaduaneiros");
            return _valordireitosaduaneiros;
        }
        set
        {
            PropriedadeModificada("Valordireitosaduaneiros", value);
            _valordireitosaduaneiros = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Valorimpostoconsumo
    {
        get
        {
            PropriedadeAcessada("Valorimpostoconsumo");
            return _valorimpostoconsumo;
        }
        set
        {
            PropriedadeModificada("Valorimpostoconsumo", value);
            _valorimpostoconsumo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Valorimpostoselo
    {
        get
        {
            PropriedadeAcessada("Valorimpostoselo");
            return _valorimpostoselo;
        }
        set
        {
            PropriedadeModificada("Valorimpostoselo", value);
            _valorimpostoselo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Valorultentant
    {
        get
        {
            PropriedadeAcessada("Valorultentant");
            return _valorultentant;
        }
        set
        {
            PropriedadeModificada("Valorultentant", value);
            _valorultentant = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Valorultentmed
    {
        get
        {
            PropriedadeAcessada("Valorultentmed");
            return _valorultentmed;
        }
        set
        {
            PropriedadeModificada("Valorultentmed", value);
            _valorultentmed = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Valorultentmedant
    {
        get
        {
            PropriedadeAcessada("Valorultentmedant");
            return _valorultentmedant;
        }
        set
        {
            PropriedadeModificada("Valorultentmedant", value);
            _valorultentmedant = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlacrescimopf
    {
        get
        {
            PropriedadeAcessada("Vlacrescimopf");
            return _vlacrescimopf;
        }
        set
        {
            PropriedadeModificada("Vlacrescimopf", value);
            _vlacrescimopf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vladicionalbcst
    {
        get
        {
            PropriedadeAcessada("Vladicionalbcst");
            return _vladicionalbcst;
        }
        set
        {
            PropriedadeModificada("Vladicionalbcst", value);
            _vladicionalbcst = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vladuaneira
    {
        get
        {
            PropriedadeAcessada("Vladuaneira");
            return _vladuaneira;
        }
        set
        {
            PropriedadeModificada("Vladuaneira", value);
            _vladuaneira = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 20, Precisao = 6)]
    public decimal? Vlbasegnre
    {
        get
        {
            PropriedadeAcessada("Vlbasegnre");
            return _vlbasegnre;
        }
        set
        {
            PropriedadeModificada("Vlbasegnre", value);
            _vlbasegnre = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 20, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlbasestforanf
    {
        get
        {
            PropriedadeAcessada("Vlbasestforanf");
            return _vlbasestforanf;
        }
        set
        {
            PropriedadeModificada("Vlbasestforanf", value);
            _vlbasestforanf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlbonificoutras
    {
        get
        {
            PropriedadeAcessada("Vlbonificoutras");
            return _vlbonificoutras;
        }
        set
        {
            PropriedadeModificada("Vlbonificoutras", value);
            _vlbonificoutras = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 24, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlcredicms
    {
        get
        {
            PropriedadeAcessada("Vlcredicms");
            return _vlcredicms;
        }
        set
        {
            PropriedadeModificada("Vlcredicms", value);
            _vlcredicms = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlcredicmsfrete
    {
        get
        {
            PropriedadeAcessada("Vlcredicmsfrete");
            return _vlcredicmsfrete;
        }
        set
        {
            PropriedadeModificada("Vlcredicmsfrete", value);
            _vlcredicmsfrete = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlcredpresumido
    {
        get
        {
            PropriedadeAcessada("Vlcredpresumido");
            return _vlcredpresumido;
        }
        set
        {
            PropriedadeModificada("Vlcredpresumido", value);
            _vlcredpresumido = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vldescicmsdif
    {
        get
        {
            PropriedadeAcessada("Vldescicmsdif");
            return _vldescicmsdif;
        }
        set
        {
            PropriedadeModificada("Vldescicmsdif", value);
            _vldescicmsdif = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vldesconto
    {
        get
        {
            PropriedadeAcessada("Vldesconto");
            return _vldesconto;
        }
        set
        {
            PropriedadeModificada("Vldesconto", value);
            _vldesconto = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 24, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 24, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vldespadicional
    {
        get
        {
            PropriedadeAcessada("Vldespadicional");
            return _vldespadicional;
        }
        set
        {
            PropriedadeModificada("Vldespadicional", value);
            _vldespadicional = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vldespdentronf
    {
        get
        {
            PropriedadeAcessada("Vldespdentronf");
            return _vldespdentronf;
        }
        set
        {
            PropriedadeModificada("Vldespdentronf", value);
            _vldespdentronf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vldespforanf
    {
        get
        {
            PropriedadeAcessada("Vldespforanf");
            return _vldespforanf;
        }
        set
        {
            PropriedadeModificada("Vldespforanf", value);
            _vldespforanf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vldifpunitcont
    {
        get
        {
            PropriedadeAcessada("Vldifpunitcont");
            return _vldifpunitcont;
        }
        set
        {
            PropriedadeModificada("Vldifpunitcont", value);
            _vldifpunitcont = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlfreteconhec
    {
        get
        {
            PropriedadeAcessada("Vlfreteconhec");
            return _vlfreteconhec;
        }
        set
        {
            PropriedadeModificada("Vlfreteconhec", value);
            _vlfreteconhec = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlfreteporkg
    {
        get
        {
            PropriedadeAcessada("Vlfreteporkg");
            return _vlfreteporkg;
        }
        set
        {
            PropriedadeModificada("Vlfreteporkg", value);
            _vlfreteporkg = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 2)]
    public decimal? Vlicmsbcr
    {
        get
        {
            PropriedadeAcessada("Vlicmsbcr");
            return _vlicmsbcr;
        }
        set
        {
            PropriedadeModificada("Vlicmsbcr", value);
            _vlicmsbcr = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlimportacao
    {
        get
        {
            PropriedadeAcessada("Vlimportacao");
            return _vlimportacao;
        }
        set
        {
            PropriedadeModificada("Vlimportacao", value);
            _vlimportacao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlindeniz
    {
        get
        {
            PropriedadeAcessada("Vlindeniz");
            return _vlindeniz;
        }
        set
        {
            PropriedadeModificada("Vlindeniz", value);
            _vlindeniz = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlinss
    {
        get
        {
            PropriedadeAcessada("Vlinss");
            return _vlinss;
        }
        set
        {
            PropriedadeModificada("Vlinss", value);
            _vlinss = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlipiporkg
    {
        get
        {
            PropriedadeAcessada("Vlipiporkg");
            return _vlipiporkg;
        }
        set
        {
            PropriedadeModificada("Vlipiporkg", value);
            _vlipiporkg = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlivamex
    {
        get
        {
            PropriedadeAcessada("Vlivamex");
            return _vlivamex;
        }
        set
        {
            PropriedadeModificada("Vlivamex", value);
            _vlivamex = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 6)]
    public decimal? Vlmexfpgc
    {
        get
        {
            PropriedadeAcessada("Vlmexfpgc");
            return _vlmexfpgc;
        }
        set
        {
            PropriedadeModificada("Vlmexfpgc", value);
            _vlmexfpgc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 6)]
    public decimal? Vlmexieps
    {
        get
        {
            PropriedadeAcessada("Vlmexieps");
            return _vlmexieps;
        }
        set
        {
            PropriedadeModificada("Vlmexieps", value);
            _vlmexieps = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 6)]
    public decimal? Vlmexiva
    {
        get
        {
            PropriedadeAcessada("Vlmexiva");
            return _vlmexiva;
        }
        set
        {
            PropriedadeModificada("Vlmexiva", value);
            _vlmexiva = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vloutrasdespimp
    {
        get
        {
            PropriedadeAcessada("Vloutrasdespimp");
            return _vloutrasdespimp;
        }
        set
        {
            PropriedadeModificada("Vloutrasdespimp", value);
            _vloutrasdespimp = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Vlpauta2
    {
        get
        {
            PropriedadeAcessada("Vlpauta2");
            return _vlpauta2;
        }
        set
        {
            PropriedadeModificada("Vlpauta2", value);
            _vlpauta2 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlpautaicms
    {
        get
        {
            PropriedadeAcessada("Vlpautaicms");
            return _vlpautaicms;
        }
        set
        {
            PropriedadeModificada("Vlpautaicms", value);
            _vlpautaicms = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlpautaicmsantec
    {
        get
        {
            PropriedadeAcessada("Vlpautaicmsantec");
            return _vlpautaicmsantec;
        }
        set
        {
            PropriedadeModificada("Vlpautaicmsantec", value);
            _vlpautaicmsantec = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlpercbon
    {
        get
        {
            PropriedadeAcessada("Vlpercbon");
            return _vlpercbon;
        }
        set
        {
            PropriedadeModificada("Vlpercbon", value);
            _vlpercbon = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlseguro
    {
        get
        {
            PropriedadeAcessada("Vlseguro");
            return _vlseguro;
        }
        set
        {
            PropriedadeModificada("Vlseguro", value);
            _vlseguro = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlsiscomex
    {
        get
        {
            PropriedadeAcessada("Vlsiscomex");
            return _vlsiscomex;
        }
        set
        {
            PropriedadeModificada("Vlsiscomex", value);
            _vlsiscomex = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlsuframa
    {
        get
        {
            PropriedadeAcessada("Vlsuframa");
            return _vlsuframa;
        }
        set
        {
            PropriedadeModificada("Vlsuframa", value);
            _vlsuframa = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlultentcontsemst
    {
        get
        {
            PropriedadeAcessada("Vlultentcontsemst");
            return _vlultentcontsemst;
        }
        set
        {
            PropriedadeModificada("Vlultentcontsemst", value);
            _vlultentcontsemst = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlultentcontsemstant
    {
        get
        {
            PropriedadeAcessada("Vlultentcontsemstant");
            return _vlultentcontsemstant;
        }
        set
        {
            PropriedadeModificada("Vlultentcontsemstant", value);
            _vlultentcontsemstant = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 20, Precisao = 8)]
    public decimal? Volume
    {
        get
        {
            PropriedadeAcessada("Volume");
            return _volume;
        }
        set
        {
            PropriedadeModificada("Volume", value);
            _volume = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
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

    public void InicializarAtributos()
    {
    }

    public string ObterNomeTabela()
    {
        return "PCMOVPREFAT";
    }

    public IEntidade NovaInstancia()
    {
        return (IEntidade)GetType().GetConstructors()[0].Invoke(null);
    }

    public void CarregarPorDataReader(IDataReader leitor)
    {
        _aliqavulsadare = AlterarTipo<decimal?>(leitor["Aliqavulsadare"]);
        _aliqicmfreteent = AlterarTipo<decimal?>(leitor["Aliqicmfreteent"]);
        _aliqicmoutrasdespent = AlterarTipo<decimal?>(leitor["Aliqicmoutrasdespent"]);
        _aliqicms1 = AlterarTipo<decimal?>(leitor["Aliqicms1"]);
        _aliqicms2 = AlterarTipo<decimal?>(leitor["Aliqicms2"]);
        _aliqicmsvigente = AlterarTipo<decimal?>(leitor["Aliqicmsvigente"]);
        _aliqicst = AlterarTipo<decimal?>(leitor["Aliqicst"]);
        _aliqstsaida = AlterarTipo<decimal?>(leitor["Aliqstsaida"]);
        _aliquotatis = AlterarTipo<decimal?>(leitor["Aliquotatis"]);
        _alternativo = AlterarTipo<string>(leitor["Alternativo"]);
        _aplicpercivapauta = AlterarTipo<string>(leitor["Aplicpercivapauta"]);
        _aproveitacredicms = AlterarTipo<string>(leitor["Aproveitacredicms"]);
        _aproveitacreditoicms = AlterarTipo<string>(leitor["Aproveitacreditoicms"]);
        _aproveitacredpiscofins = AlterarTipo<string>(leitor["Aproveitacredpiscofins"]);
        _baseacrescimopf = AlterarTipo<decimal?>(leitor["Baseacrescimopf"]);
        _basebcr = AlterarTipo<decimal?>(leitor["Basebcr"]);
        _basedifaliquotas = AlterarTipo<decimal?>(leitor["Basedifaliquotas"]);
        _baseicms = AlterarTipo<decimal?>(leitor["Baseicms"]);
        _baseicms2 = AlterarTipo<decimal?>(leitor["Baseicms2"]);
        _baseicmsadicional = AlterarTipo<decimal?>(leitor["Baseicmsadicional"]);
        _baseicmsbcr = AlterarTipo<decimal?>(leitor["Baseicmsbcr"]);
        _baseicmsultent = AlterarTipo<decimal?>(leitor["Baseicmsultent"]);
        _baseicmsultentant = AlterarTipo<decimal?>(leitor["Baseicmsultentant"]);
        _baseicst = AlterarTipo<decimal?>(leitor["Baseicst"]);
        _baseivamex = AlterarTipo<decimal?>(leitor["Baseivamex"]);
        _basestsaida = AlterarTipo<decimal?>(leitor["Basestsaida"]);
        _bciss = AlterarTipo<decimal?>(leitor["Bciss"]);
        _brinde = AlterarTipo<string>(leitor["Brinde"]);
        _calcbcrmanual = AlterarTipo<string>(leitor["Calcbcrmanual"]);
        _calccredipi = AlterarTipo<string>(leitor["Calccredipi"]);
        _capvoldnf = AlterarTipo<decimal?>(leitor["Capvoldnf"]);
        _classificfiscal = AlterarTipo<string>(leitor["Classificfiscal"]);
        _codauxiliar = AlterarTipo<decimal?>(leitor["Codauxiliar"]);
        _codbase = AlterarTipo<string>(leitor["Codbase"]);
        _codcertific = AlterarTipo<decimal?>(leitor["Codcertific"]);
        _codcli = AlterarTipo<decimal?>(leitor["Codcli"]);
        _coddesconto = AlterarTipo<decimal?>(leitor["Coddesconto"]);
        _coddevol = AlterarTipo<decimal?>(leitor["Coddevol"]);
        _codecf = AlterarTipo<string>(leitor["Codecf"]);
        _codepto = AlterarTipo<decimal?>(leitor["Codepto"]);
        _codequipamento = AlterarTipo<decimal?>(leitor["Codequipamento"]);
        _codfilial = AlterarTipo<string>(leitor["Codfilial"]);
        _codfilialnf = AlterarTipo<string>(leitor["Codfilialnf"]);
        _codfilialretira = AlterarTipo<string>(leitor["Codfilialretira"]);
        _codfiscal = AlterarTipo<decimal?>(leitor["Codfiscal"]);
        _codfiscalfreteent = AlterarTipo<decimal?>(leitor["Codfiscalfreteent"]);
        _codfiscaloutrasdespent = AlterarTipo<decimal?>(leitor["Codfiscaloutrasdespent"]);
        _codformula = AlterarTipo<string>(leitor["Codformula"]);
        _codfornec = AlterarTipo<decimal?>(leitor["Codfornec"]);
        _codfornecprod = AlterarTipo<decimal?>(leitor["Codfornecprod"]);
        _codfuncconf = AlterarTipo<decimal?>(leitor["Codfuncconf"]);
        _codfuncembal = AlterarTipo<decimal?>(leitor["Codfuncembal"]);
        _codfuncexportacaowms = AlterarTipo<decimal?>(leitor["Codfuncexportacaowms"]);
        _codfuncimportacaowms = AlterarTipo<decimal?>(leitor["Codfuncimportacaowms"]);
        _codfunclanc = AlterarTipo<decimal?>(leitor["Codfunclanc"]);
        _codfuncquarentena = AlterarTipo<decimal?>(leitor["Codfuncquarentena"]);
        _codfuncreq = AlterarTipo<decimal?>(leitor["Codfuncreq"]);
        _codgenerofiscal = AlterarTipo<decimal?>(leitor["Codgenerofiscal"]);
        _codicmtab = AlterarTipo<decimal?>(leitor["Codicmtab"]);
        _codinterno = AlterarTipo<string>(leitor["Codinterno"]);
        _codmotorista = AlterarTipo<decimal?>(leitor["Codmotorista"]);
        _codoper = AlterarTipo<string>(leitor["Codoper"]);
        _codpassefiscal = AlterarTipo<decimal?>(leitor["Codpassefiscal"]);
        _codplpag = AlterarTipo<decimal?>(leitor["Codplpag"]);
        _codprod = AlterarTipo<decimal>(leitor["Codprod"]);
        _codproddnf = AlterarTipo<decimal?>(leitor["Codproddnf"]);
        _codprodprinc = AlterarTipo<decimal?>(leitor["Codprodprinc"]);
        _codprodrelev = AlterarTipo<decimal?>(leitor["Codprodrelev"]);
        _codprodsintegra = AlterarTipo<string>(leitor["Codprodsintegra"]);
        _codpromocao = AlterarTipo<string>(leitor["Codpromocao"]);
        _codsec = AlterarTipo<decimal?>(leitor["Codsec"]);
        _codsittribpiscofins = AlterarTipo<decimal?>(leitor["Codsittribpiscofins"]);
        _codst = AlterarTipo<decimal?>(leitor["Codst"]);
        _codusur = AlterarTipo<decimal?>(leitor["Codusur"]);
        _codvasilhame = AlterarTipo<decimal?>(leitor["Codvasilhame"]);
        _complemento = AlterarTipo<string>(leitor["Complemento"]);
        _compraconsignado = AlterarTipo<string>(leitor["Compraconsignado"]);
        _controlanumserie = AlterarTipo<string>(leitor["Controlanumserie"]);
        _custocont = AlterarTipo<decimal?>(leitor["Custocont"]);
        _custocontant = AlterarTipo<decimal?>(leitor["Custocontant"]);
        _custofin = AlterarTipo<decimal?>(leitor["Custofin"]);
        _custofinant = AlterarTipo<decimal?>(leitor["Custofinant"]);
        _custofinest = AlterarTipo<decimal?>(leitor["Custofinest"]);
        _custofornec = AlterarTipo<decimal?>(leitor["Custofornec"]);
        _custonfsemst = AlterarTipo<decimal?>(leitor["Custonfsemst"]);
        _custonfsemstant = AlterarTipo<decimal?>(leitor["Custonfsemstant"]);
        _custoreal = AlterarTipo<decimal?>(leitor["Custoreal"]);
        _custorealant = AlterarTipo<decimal?>(leitor["Custorealant"]);
        _custorealsemst = AlterarTipo<decimal?>(leitor["Custorealsemst"]);
        _custorealsemstant = AlterarTipo<decimal?>(leitor["Custorealsemstant"]);
        _custorep = AlterarTipo<decimal?>(leitor["Custorep"]);
        _custorepant = AlterarTipo<decimal?>(leitor["Custorepant"]);
        _custoultent = AlterarTipo<decimal?>(leitor["Custoultent"]);
        _custoultentant = AlterarTipo<decimal?>(leitor["Custoultentant"]);
        _custoultentant2 = AlterarTipo<decimal?>(leitor["Custoultentant2"]);
        _custoultentfin = AlterarTipo<decimal?>(leitor["Custoultentfin"]);
        _custoultentfinant = AlterarTipo<decimal?>(leitor["Custoultentfinant"]);
        _custoultentmed = AlterarTipo<decimal?>(leitor["Custoultentmed"]);
        _custoultentmedant = AlterarTipo<decimal?>(leitor["Custoultentmedant"]);
        _dataconsolidacaoprefat = AlterarTipo<DateTime?>(leitor["Dataconsolidacaoprefat"]);
        _datafabricacao = AlterarTipo<DateTime?>(leitor["Datafabricacao"]);
        _datalibquarentena = AlterarTipo<DateTime?>(leitor["Datalibquarentena"]);
        _datavalidade = AlterarTipo<DateTime?>(leitor["Datavalidade"]);
        _descricao = AlterarTipo<string>(leitor["Descricao"]);
        _descricao1 = AlterarTipo<string>(leitor["Descricao1"]);
        _dtapuracao = AlterarTipo<DateTime?>(leitor["Dtapuracao"]);
        _dtcancel = AlterarTipo<DateTime?>(leitor["Dtcancel"]);
        _dtdenegada = AlterarTipo<DateTime?>(leitor["Dtdenegada"]);
        _dtexportacaoservint = AlterarTipo<DateTime?>(leitor["Dtexportacaoservint"]);
        _dtexportacaowms = AlterarTipo<DateTime?>(leitor["Dtexportacaowms"]);
        _dtfimconf = AlterarTipo<DateTime?>(leitor["Dtfimconf"]);
        _dtimportacaoservprinc = AlterarTipo<DateTime?>(leitor["Dtimportacaoservprinc"]);
        _dtimportacaowms = AlterarTipo<DateTime?>(leitor["Dtimportacaowms"]);
        _dtinicioconf = AlterarTipo<DateTime?>(leitor["Dtinicioconf"]);
        _dtmov = AlterarTipo<DateTime>(leitor["Dtmov"]);
        _dtmovlog = AlterarTipo<DateTime?>(leitor["Dtmovlog"]);
        _dtultentant = AlterarTipo<DateTime?>(leitor["Dtultentant"]);
        _dtwms = AlterarTipo<DateTime?>(leitor["Dtwms"]);
        _dv = AlterarTipo<decimal?>(leitor["Dv"]);
        _embalagem = AlterarTipo<string>(leitor["Embalagem"]);
        _equiplanc = AlterarTipo<string>(leitor["Equiplanc"]);
        _estoquedesbloqueado = AlterarTipo<string>(leitor["Estoquedesbloqueado"]);
        _exportadoservint = AlterarTipo<string>(leitor["Exportadoservint"]);
        _fatorconvdnf = AlterarTipo<decimal?>(leitor["Fatorconvdnf"]);
        _fatorcustonatransf = AlterarTipo<decimal?>(leitor["Fatorcustonatransf"]);
        _funclanc = AlterarTipo<string>(leitor["Funclanc"]);
        _fundapiano = AlterarTipo<string>(leitor["Fundapiano"]);
        _geragnre_cnpjcliente = AlterarTipo<string>(leitor["Geragnre_Cnpjcliente"]);
        _geraicmslivrofiscal = AlterarTipo<string>(leitor["Geraicmslivrofiscal"]);
        _historico = AlterarTipo<string>(leitor["Historico"]);
        _horalanc = AlterarTipo<string>(leitor["Horalanc"]);
        _horaproducao = AlterarTipo<DateTime?>(leitor["Horaproducao"]);
        _icmsressarc = AlterarTipo<decimal?>(leitor["Icmsressarc"]);
        _importado = AlterarTipo<string>(leitor["Importado"]);
        _importadoservprinc = AlterarTipo<string>(leitor["Importadoservprinc"]);
        _indlocal = AlterarTipo<string>(leitor["Indlocal"]);
        _issretido = AlterarTipo<string>(leitor["Issretido"]);
        _itemdivergente = AlterarTipo<string>(leitor["Itemdivergente"]);
        _iva = AlterarTipo<decimal?>(leitor["Iva"]);
        _ivaressarc = AlterarTipo<decimal?>(leitor["Ivaressarc"]);
        _ivatribut = AlterarTipo<decimal?>(leitor["Ivatribut"]);
        _localizacao = AlterarTipo<string>(leitor["Localizacao"]);
        _minutolanc = AlterarTipo<string>(leitor["Minutolanc"]);
        _movestoquecontabil = AlterarTipo<string>(leitor["Movestoquecontabil"]);
        _movestoquegerencial = AlterarTipo<string>(leitor["Movestoquegerencial"]);
        _movimentacontacorrenterca = AlterarTipo<string>(leitor["Movimentacontacorrenterca"]);
        _nbm = AlterarTipo<string>(leitor["Nbm"]);
        _numadicao = AlterarTipo<decimal?>(leitor["Numadicao"]);
        _numbono = AlterarTipo<decimal?>(leitor["Numbono"]);
        _numbonus = AlterarTipo<decimal?>(leitor["Numbonus"]);
        _numcar = AlterarTipo<decimal?>(leitor["Numcar"]);
        _numcaranterior = AlterarTipo<decimal?>(leitor["Numcaranterior"]);
        _numformulario = AlterarTipo<decimal?>(leitor["Numformulario"]);
        _numformulario2 = AlterarTipo<decimal?>(leitor["Numformulario2"]);
        _numidf = AlterarTipo<string>(leitor["Numidf"]);
        _numlanccp = AlterarTipo<decimal?>(leitor["Numlanccp"]);
        _numlote = AlterarTipo<string>(leitor["Numlote"]);
        _numlotefab = AlterarTipo<string>(leitor["Numlotefab"]);
        _numnegociacao = AlterarTipo<decimal?>(leitor["Numnegociacao"]);
        _numnota = AlterarTipo<decimal?>(leitor["Numnota"]);
        _numnotadev = AlterarTipo<decimal?>(leitor["Numnotadev"]);
        _numop = AlterarTipo<decimal?>(leitor["Numop"]);
        _numped = AlterarTipo<decimal?>(leitor["Numped"]);
        _numregiao = AlterarTipo<decimal?>(leitor["Numregiao"]);
        _numseq = AlterarTipo<decimal?>(leitor["Numseq"]);
        _numseqadicao = AlterarTipo<decimal?>(leitor["Numseqadicao"]);
        _numseqped = AlterarTipo<decimal?>(leitor["Numseqped"]);
        _numtransavulsa = AlterarTipo<decimal?>(leitor["Numtransavulsa"]);
        _numtransdev = AlterarTipo<decimal?>(leitor["Numtransdev"]);
        _numtransdevfor = AlterarTipo<decimal?>(leitor["Numtransdevfor"]);
        _numtransent = AlterarTipo<decimal?>(leitor["Numtransent"]);
        _numtransentorigdesdlote = AlterarTipo<decimal?>(leitor["Numtransentorigdesdlote"]);
        _numtransentultent = AlterarTipo<decimal?>(leitor["Numtransentultent"]);
        _numtransentultentant = AlterarTipo<decimal?>(leitor["Numtransentultentant"]);
        _numtranshistorico = AlterarTipo<decimal?>(leitor["Numtranshistorico"]);
        _numtransitem = AlterarTipo<decimal>(leitor["Numtransitem"]);
        _numtransop = AlterarTipo<decimal?>(leitor["Numtransop"]);
        _numtransvenda = AlterarTipo<decimal?>(leitor["Numtransvenda"]);
        _numverbaoutras = AlterarTipo<decimal?>(leitor["Numverbaoutras"]);
        _numverbarebcmv = AlterarTipo<decimal?>(leitor["Numverbarebcmv"]);
        _numvolumesconferencia = AlterarTipo<decimal?>(leitor["Numvolumesconferencia"]);
        _pagtognrenomedoremetente = AlterarTipo<string>(leitor["Pagtognrenomedoremetente"]);
        _passelivre = AlterarTipo<string>(leitor["Passelivre"]);
        _pauta = AlterarTipo<decimal?>(leitor["Pauta"]);
        _pbaserca = AlterarTipo<decimal?>(leitor["Pbaserca"]);
        _pbonific = AlterarTipo<decimal?>(leitor["Pbonific"]);
        _peracrescimocusto = AlterarTipo<decimal?>(leitor["Peracrescimocusto"]);
        _peracrescimopf = AlterarTipo<decimal?>(leitor["Peracrescimopf"]);
        _perbonific = AlterarTipo<decimal?>(leitor["Perbonific"]);
        _percagregadorst = AlterarTipo<decimal?>(leitor["Percagregadorst"]);
        _percaliqext2 = AlterarTipo<decimal?>(leitor["Percaliqext2"]);
        _percaliqextguia = AlterarTipo<decimal?>(leitor["Percaliqextguia"]);
        _percaliqexticmantecip = AlterarTipo<decimal?>(leitor["Percaliqexticmantecip"]);
        _percaliqint2 = AlterarTipo<decimal?>(leitor["Percaliqint2"]);
        _percaliqinticmantecip = AlterarTipo<decimal?>(leitor["Percaliqinticmantecip"]);
        _percbasered = AlterarTipo<decimal?>(leitor["Percbasered"]);
        _percbaseredadicional = AlterarTipo<decimal?>(leitor["Percbaseredadicional"]);
        _percbaseredst = AlterarTipo<decimal?>(leitor["Percbaseredst"]);
        _percbaseredstfonte = AlterarTipo<decimal?>(leitor["Percbaseredstfonte"]);
        _percbon = AlterarTipo<decimal?>(leitor["Percbon"]);
        _percbonoutras = AlterarTipo<decimal?>(leitor["Percbonoutras"]);
        _perccredicmpresumido = AlterarTipo<decimal?>(leitor["Perccredicmpresumido"]);
        _percdesc = AlterarTipo<decimal?>(leitor["Percdesc"]);
        _percdesccofins = AlterarTipo<decimal?>(leitor["Percdesccofins"]);
        _percdescfin = AlterarTipo<decimal?>(leitor["Percdescfin"]);
        _percdescicmsdif = AlterarTipo<decimal?>(leitor["Percdescicmsdif"]);
        _percdescpis = AlterarTipo<decimal?>(leitor["Percdescpis"]);
        _percdespadicional = AlterarTipo<decimal?>(leitor["Percdespadicional"]);
        _percdespdentronf = AlterarTipo<decimal?>(leitor["Percdespdentronf"]);
        _percdespfin = AlterarTipo<decimal?>(leitor["Percdespfin"]);
        _percdespforanf = AlterarTipo<decimal?>(leitor["Percdespforanf"]);
        _percdifaliquotas = AlterarTipo<decimal?>(leitor["Percdifaliquotas"]);
        _percdireitosaduaneiros = AlterarTipo<decimal?>(leitor["Percdireitosaduaneiros"]);
        _percfrete = AlterarTipo<decimal?>(leitor["Percfrete"]);
        _percfretefob = AlterarTipo<decimal?>(leitor["Percfretefob"]);
        _percicm = AlterarTipo<decimal?>(leitor["Percicm"]);
        _percicm2 = AlterarTipo<decimal?>(leitor["Percicm2"]);
        _percicmcp = AlterarTipo<decimal?>(leitor["Percicmcp"]);
        _percicmop = AlterarTipo<decimal?>(leitor["Percicmop"]);
        _percicmoriginal = AlterarTipo<decimal?>(leitor["Percicmoriginal"]);
        _percicmred = AlterarTipo<decimal?>(leitor["Percicmred"]);
        _percicmsdiferido = AlterarTipo<decimal?>(leitor["Percicmsdiferido"]);
        _percicmsfretefobst = AlterarTipo<decimal?>(leitor["Percicmsfretefobst"]);
        _perciisuspenso = AlterarTipo<decimal?>(leitor["Perciisuspenso"]);
        _percimportacao = AlterarTipo<decimal?>(leitor["Percimportacao"]);
        _percimpostoconsumo = AlterarTipo<decimal?>(leitor["Percimpostoconsumo"]);
        _percimpostoselo = AlterarTipo<decimal?>(leitor["Percimpostoselo"]);
        _percimpprodutorural = AlterarTipo<decimal?>(leitor["Percimpprodutorural"]);
        _percimpureza = AlterarTipo<decimal?>(leitor["Percimpureza"]);
        _percinss = AlterarTipo<decimal?>(leitor["Percinss"]);
        _percinteiro = AlterarTipo<decimal?>(leitor["Percinteiro"]);
        _percipi = AlterarTipo<decimal?>(leitor["Percipi"]);
        _perciss = AlterarTipo<decimal?>(leitor["Perciss"]);
        _perciva = AlterarTipo<decimal?>(leitor["Perciva"]);
        _perciva2 = AlterarTipo<decimal?>(leitor["Perciva2"]);
        _percivaicmantecip = AlterarTipo<decimal?>(leitor["Percivaicmantecip"]);
        _percivamex = AlterarTipo<decimal?>(leitor["Percivamex"]);
        _percmexfpgc = AlterarTipo<decimal?>(leitor["Percmexfpgc"]);
        _percmexieps = AlterarTipo<decimal?>(leitor["Percmexieps"]);
        _percmexiva = AlterarTipo<decimal?>(leitor["Percmexiva"]);
        _percofins = AlterarTipo<decimal?>(leitor["Percofins"]);
        _percom = AlterarTipo<decimal?>(leitor["Percom"]);
        _percom2 = AlterarTipo<decimal?>(leitor["Percom2"]);
        _percom3 = AlterarTipo<decimal?>(leitor["Percom3"]);
        _percom4 = AlterarTipo<decimal?>(leitor["Percom4"]);
        _percomfilialbroker = AlterarTipo<decimal?>(leitor["Percomfilialbroker"]);
        _percommot = AlterarTipo<decimal?>(leitor["Percommot"]);
        _percomsup = AlterarTipo<decimal?>(leitor["Percomsup"]);
        _percoutrasdesp = AlterarTipo<decimal?>(leitor["Percoutrasdesp"]);
        _percoutroscustos = AlterarTipo<decimal?>(leitor["Percoutroscustos"]);
        _percquebrado = AlterarTipo<decimal?>(leitor["Percquebrado"]);
        _percredicms = AlterarTipo<decimal?>(leitor["Percredicms"]);
        _percseguro = AlterarTipo<decimal?>(leitor["Percseguro"]);
        _percst = AlterarTipo<decimal?>(leitor["Percst"]);
        _percsuframa = AlterarTipo<decimal?>(leitor["Percsuframa"]);
        _percumidade = AlterarTipo<decimal?>(leitor["Percumidade"]);
        _percvenda = AlterarTipo<decimal?>(leitor["Percvenda"]);
        _percvermelho = AlterarTipo<decimal?>(leitor["Percvermelho"]);
        _percvlbonific = AlterarTipo<decimal?>(leitor["Percvlbonific"]);
        _perdesccom = AlterarTipo<decimal?>(leitor["Perdesccom"]);
        _perdesccusto = AlterarTipo<decimal?>(leitor["Perdesccusto"]);
        _perdescfin = AlterarTipo<decimal?>(leitor["Perdescfin"]);
        _perdescflex = AlterarTipo<decimal?>(leitor["Perdescflex"]);
        _perdescisentoicms = AlterarTipo<decimal?>(leitor["Perdescisentoicms"]);
        _perfretecmv = AlterarTipo<decimal?>(leitor["Perfretecmv"]);
        _pericm = AlterarTipo<decimal?>(leitor["Pericm"]);
        _pericmfrete = AlterarTipo<decimal?>(leitor["Pericmfrete"]);
        _pericmguiapropria = AlterarTipo<decimal?>(leitor["Pericmguiapropria"]);
        _pericmsantecipado = AlterarTipo<decimal?>(leitor["Pericmsantecipado"]);
        _perpis = AlterarTipo<decimal?>(leitor["Perpis"]);
        _perredcomiss = AlterarTipo<decimal?>(leitor["Perredcomiss"]);
        _perredcomisssup = AlterarTipo<decimal?>(leitor["Perredcomisssup"]);
        _pesobruto = AlterarTipo<decimal?>(leitor["Pesobruto"]);
        _pesoliq = AlterarTipo<decimal?>(leitor["Pesoliq"]);
        _piscofinsretido = AlterarTipo<string>(leitor["Piscofinsretido"]);
        _pliqped = AlterarTipo<decimal?>(leitor["Pliqped"]);
        _prazomedio = AlterarTipo<decimal?>(leitor["Prazomedio"]);
        _precopauta = AlterarTipo<decimal?>(leitor["Precopauta"]);
        _prodbonificado = AlterarTipo<string>(leitor["Prodbonificado"]);
        _proddescricaocontrato = AlterarTipo<string>(leitor["Proddescricaocontrato"]);
        _promocaobiro = AlterarTipo<string>(leitor["Promocaobiro"]);
        _ptabela = AlterarTipo<decimal?>(leitor["Ptabela"]);
        _ptabela2 = AlterarTipo<decimal?>(leitor["Ptabela2"]);
        _punit = AlterarTipo<decimal?>(leitor["Punit"]);
        _punitcont = AlterarTipo<decimal?>(leitor["Punitcont"]);
        _punitnf = AlterarTipo<decimal?>(leitor["Punitnf"]);
        _pvenda1 = AlterarTipo<decimal?>(leitor["Pvenda1"]);
        _pvendabase = AlterarTipo<decimal?>(leitor["Pvendabase"]);
        _pvendaemb = AlterarTipo<decimal?>(leitor["Pvendaemb"]);
        _pvendaembalagem = AlterarTipo<decimal?>(leitor["Pvendaembalagem"]);
        _qt = AlterarTipo<decimal?>(leitor["Qt"]);
        _qtavaria = AlterarTipo<decimal?>(leitor["Qtavaria"]);
        _qtbloqueada = AlterarTipo<decimal?>(leitor["Qtbloqueada"]);
        _qtconf = AlterarTipo<decimal?>(leitor["Qtconf"]);
        _qtcont = AlterarTipo<decimal?>(leitor["Qtcont"]);
        _qtcx = AlterarTipo<decimal?>(leitor["Qtcx"]);
        _qtdevol = AlterarTipo<decimal?>(leitor["Qtdevol"]);
        _qtembalagem = AlterarTipo<decimal?>(leitor["Qtembalagem"]);
        _qtestant = AlterarTipo<decimal?>(leitor["Qtestant"]);
        _qtestgerant = AlterarTipo<decimal?>(leitor["Qtestgerant"]);
        _qthoras = AlterarTipo<decimal?>(leitor["Qthoras"]);
        _qtpecas = AlterarTipo<decimal?>(leitor["Qtpecas"]);
        _qtsaldoest = AlterarTipo<decimal?>(leitor["Qtsaldoest"]);
        _qtsaldoestger = AlterarTipo<decimal?>(leitor["Qtsaldoestger"]);
        _qtultentant = AlterarTipo<decimal?>(leitor["Qtultentant"]);
        _qtunit = AlterarTipo<decimal?>(leitor["Qtunit"]);
        _qtunitcx = AlterarTipo<decimal?>(leitor["Qtunitcx"]);
        _qtunitemb = AlterarTipo<decimal?>(leitor["Qtunitemb"]);
        _qtvendaemb = AlterarTipo<decimal?>(leitor["Qtvendaemb"]);
        _qualdivergencia = AlterarTipo<string>(leitor["Qualdivergencia"]);
        _redbasealiqext = AlterarTipo<decimal?>(leitor["Redbasealiqext"]);
        _redbaseiva = AlterarTipo<decimal?>(leitor["Redbaseiva"]);
        _refcor = AlterarTipo<string>(leitor["Refcor"]);
        _rotinacad = AlterarTipo<string>(leitor["Rotinacad"]);
        _rotinalanc = AlterarTipo<string>(leitor["Rotinalanc"]);
        _rua = AlterarTipo<decimal?>(leitor["Rua"]);
        _seqmov = AlterarTipo<decimal?>(leitor["Seqmov"]);
        _siglaqualidade = AlterarTipo<string>(leitor["Siglaqualidade"]);
        _sittribut = AlterarTipo<string>(leitor["Sittribut"]);
        _st = AlterarTipo<decimal?>(leitor["St"]);
        _status = AlterarTipo<string>(leitor["Status"]);
        _stbcr = AlterarTipo<decimal?>(leitor["Stbcr"]);
        _stclientegnre = AlterarTipo<decimal?>(leitor["Stclientegnre"]);
        _stsaida = AlterarTipo<decimal?>(leitor["Stsaida"]);
        _tipodescaplicado = AlterarTipo<string>(leitor["Tipodescaplicado"]);
        _tipoembalagempedido = AlterarTipo<string>(leitor["Tipoembalagempedido"]);
        _tipofornec = AlterarTipo<string>(leitor["Tipofornec"]);
        _tipoitem = AlterarTipo<string>(leitor["Tipoitem"]);
        _tipomerc = AlterarTipo<string>(leitor["Tipomerc"]);
        _tipomercdepto = AlterarTipo<string>(leitor["Tipomercdepto"]);
        _tiposeparacao = AlterarTipo<string>(leitor["Tiposeparacao"]);
        _tipotis = AlterarTipo<string>(leitor["Tipotis"]);
        _tipotributmedic = AlterarTipo<string>(leitor["Tipotributmedic"]);
        _transacaotransferida = AlterarTipo<string>(leitor["Transacaotransferida"]);
        _trgpclote = AlterarTipo<string>(leitor["Trgpclote"]);
        _tribfederal = AlterarTipo<string>(leitor["Tribfederal"]);
        _truncaritem = AlterarTipo<string>(leitor["Truncaritem"]);
        _txvenda = AlterarTipo<decimal?>(leitor["Txvenda"]);
        _uffornec = AlterarTipo<string>(leitor["Uffornec"]);
        _unidade = AlterarTipo<string>(leitor["Unidade"]);
        _usadebcredrcabrind = AlterarTipo<string>(leitor["Usadebcredrcabrind"]);
        _valordireitosaduaneiros = AlterarTipo<decimal?>(leitor["Valordireitosaduaneiros"]);
        _valorimpostoconsumo = AlterarTipo<decimal?>(leitor["Valorimpostoconsumo"]);
        _valorimpostoselo = AlterarTipo<decimal?>(leitor["Valorimpostoselo"]);
        _valorultent = AlterarTipo<decimal?>(leitor["Valorultent"]);
        _valorultentant = AlterarTipo<decimal?>(leitor["Valorultentant"]);
        _valorultentmed = AlterarTipo<decimal?>(leitor["Valorultentmed"]);
        _valorultentmedant = AlterarTipo<decimal?>(leitor["Valorultentmedant"]);
        _vlacrescimopf = AlterarTipo<decimal?>(leitor["Vlacrescimopf"]);
        _vlacrescrodape = AlterarTipo<decimal?>(leitor["Vlacrescrodape"]);
        _vladicionalbcst = AlterarTipo<decimal?>(leitor["Vladicionalbcst"]);
        _vladuaneira = AlterarTipo<decimal?>(leitor["Vladuaneira"]);
        _vlbasegnre = AlterarTipo<decimal?>(leitor["Vlbasegnre"]);
        _vlbaseipi = AlterarTipo<decimal?>(leitor["Vlbaseipi"]);
        _vlbasepiscofins = AlterarTipo<decimal?>(leitor["Vlbasepiscofins"]);
        _vlbasestforanf = AlterarTipo<decimal?>(leitor["Vlbasestforanf"]);
        _vlbonific = AlterarTipo<decimal?>(leitor["Vlbonific"]);
        _vlbonificoutras = AlterarTipo<decimal?>(leitor["Vlbonificoutras"]);
        _vlcofins = AlterarTipo<decimal?>(leitor["Vlcofins"]);
        _vlcredcofins = AlterarTipo<decimal?>(leitor["Vlcredcofins"]);
        _vlcredicms = AlterarTipo<decimal?>(leitor["Vlcredicms"]);
        _vlcredicmsfrete = AlterarTipo<decimal?>(leitor["Vlcredicmsfrete"]);
        _vlcredpis = AlterarTipo<decimal?>(leitor["Vlcredpis"]);
        _vlcredpresumido = AlterarTipo<decimal?>(leitor["Vlcredpresumido"]);
        _vldesccom = AlterarTipo<decimal?>(leitor["Vldesccom"]);
        _vldesccustocmv = AlterarTipo<decimal?>(leitor["Vldesccustocmv"]);
        _vldescfin = AlterarTipo<decimal?>(leitor["Vldescfin"]);
        _vldescflex = AlterarTipo<decimal?>(leitor["Vldescflex"]);
        _vldescicmisencao = AlterarTipo<decimal?>(leitor["Vldescicmisencao"]);
        _vldescicmsdif = AlterarTipo<decimal?>(leitor["Vldescicmsdif"]);
        _vldesconto = AlterarTipo<decimal?>(leitor["Vldesconto"]);
        _vldescpissuframa = AlterarTipo<decimal?>(leitor["Vldescpissuframa"]);
        _vldescreducaocofins = AlterarTipo<decimal?>(leitor["Vldescreducaocofins"]);
        _vldescreducaopis = AlterarTipo<decimal?>(leitor["Vldescreducaopis"]);
        _vldescrodape = AlterarTipo<decimal?>(leitor["Vldescrodape"]);
        _vldescsuframa = AlterarTipo<decimal?>(leitor["Vldescsuframa"]);
        _vldespadicional = AlterarTipo<decimal?>(leitor["Vldespadicional"]);
        _vldespdentronf = AlterarTipo<decimal?>(leitor["Vldespdentronf"]);
        _vldespforanf = AlterarTipo<decimal?>(leitor["Vldespforanf"]);
        _vldifaliquotas = AlterarTipo<decimal?>(leitor["Vldifaliquotas"]);
        _vldifpunitcont = AlterarTipo<decimal?>(leitor["Vldifpunitcont"]);
        _vlfrete = AlterarTipo<decimal?>(leitor["Vlfrete"]);
        _vlfreteconhec = AlterarTipo<decimal?>(leitor["Vlfreteconhec"]);
        _vlfreteporkg = AlterarTipo<decimal?>(leitor["Vlfreteporkg"]);
        _vlfrete_rateio = AlterarTipo<decimal?>(leitor["Vlfrete_Rateio"]);
        _vlicmsbcr = AlterarTipo<decimal?>(leitor["Vlicmsbcr"]);
        _vlicmsdiferido = AlterarTipo<decimal?>(leitor["Vlicmsdiferido"]);
        _vlimportacao = AlterarTipo<decimal?>(leitor["Vlimportacao"]);
        _vlindeniz = AlterarTipo<decimal?>(leitor["Vlindeniz"]);
        _vlinss = AlterarTipo<decimal?>(leitor["Vlinss"]);
        _vlipi = AlterarTipo<decimal?>(leitor["Vlipi"]);
        _vlipiporkg = AlterarTipo<decimal?>(leitor["Vlipiporkg"]);
        _vliss = AlterarTipo<decimal?>(leitor["Vliss"]);
        _vlivamex = AlterarTipo<decimal?>(leitor["Vlivamex"]);
        _vlmexfpgc = AlterarTipo<decimal?>(leitor["Vlmexfpgc"]);
        _vlmexieps = AlterarTipo<decimal?>(leitor["Vlmexieps"]);
        _vlmexiva = AlterarTipo<decimal?>(leitor["Vlmexiva"]);
        _vloutrasdesp = AlterarTipo<decimal?>(leitor["Vloutrasdesp"]);
        _vloutrasdespimp = AlterarTipo<decimal?>(leitor["Vloutrasdespimp"]);
        _vloutras_rateio = AlterarTipo<decimal?>(leitor["Vloutras_Rateio"]);
        _vloutros = AlterarTipo<decimal?>(leitor["Vloutros"]);
        _vlpauta2 = AlterarTipo<decimal?>(leitor["Vlpauta2"]);
        _vlpautaicms = AlterarTipo<decimal?>(leitor["Vlpautaicms"]);
        _vlpautaicmsantec = AlterarTipo<decimal?>(leitor["Vlpautaicmsantec"]);
        _vlpercbon = AlterarTipo<decimal?>(leitor["Vlpercbon"]);
        _vlpis = AlterarTipo<decimal?>(leitor["Vlpis"]);
        _vlredcomiss = AlterarTipo<decimal?>(leitor["Vlredcomiss"]);
        _vlredcomisssup = AlterarTipo<decimal?>(leitor["Vlredcomisssup"]);
        _vlrepasse = AlterarTipo<decimal?>(leitor["Vlrepasse"]);
        _vlseguro = AlterarTipo<decimal?>(leitor["Vlseguro"]);
        _vlsiscomex = AlterarTipo<decimal?>(leitor["Vlsiscomex"]);
        _vlsuframa = AlterarTipo<decimal?>(leitor["Vlsuframa"]);
        _vlultentcontsemst = AlterarTipo<decimal?>(leitor["Vlultentcontsemst"]);
        _vlultentcontsemstant = AlterarTipo<decimal?>(leitor["Vlultentcontsemstant"]);
        _vlverbacmv = AlterarTipo<decimal?>(leitor["Vlverbacmv"]);
        _vlverbacmvcli = AlterarTipo<decimal?>(leitor["Vlverbacmvcli"]);
        _volume = AlterarTipo<decimal?>(leitor["Volume"]);
        _volumedesejado = AlterarTipo<decimal?>(leitor["Volumedesejado"]);
    }

}