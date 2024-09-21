

////// namespace nwErp.Entidades.Winthor;

// namespace nwErp.Api.Modelos;

[Serializable]
public class PCMOV : GerenteDePropriedades, IEntidade
{
    private static readonly string RO_ALIQAVULSADARE = "Aliqavulsadare";

    private decimal? _aliqavulsadare;

    private static readonly string RO_ALIQICMFRETEENT = "Aliqicmfreteent";

    private decimal? _aliqicmfreteent;

    private static readonly string RO_ALIQICMOUTRASDESPENT = "Aliqicmoutrasdespent";

    private decimal? _aliqicmoutrasdespent;

    private static readonly string RO_ALIQICMSVIGENTE = "Aliqicmsvigente";

    private decimal? _aliqicmsvigente;

    private static readonly string RO_ALIQICMS1 = "Aliqicms1";

    private decimal? _aliqicms1;

    private static readonly string RO_ALIQICMS2 = "Aliqicms2";

    private decimal? _aliqicms2;

    private static readonly string RO_ALIQICST = "Aliqicst";

    private decimal? _aliqicst;

    private static readonly string RO_ALIQSTSAIDA = "Aliqstsaida";

    private decimal? _aliqstsaida;

    private static readonly string RO_ALIQUOTATIS = "Aliquotatis";

    private decimal? _aliquotatis;

    private static readonly string RO_ALTERNATIVO = "Alternativo";

    private string _alternativo;

    private static readonly string RO_APLICPERCIVAPAUTA = "Aplicpercivapauta";

    private string _aplicpercivapauta;

    private static readonly string RO_APROVEITACREDICMS = "Aproveitacredicms";

    private string _aproveitacredicms;

    private static readonly string RO_APROVEITACREDPISCOFINS = "Aproveitacredpiscofins";

    private string _aproveitacredpiscofins;

    private static readonly string RO_BASEACRESCIMOPF = "Baseacrescimopf";

    private decimal? _baseacrescimopf;

    private static readonly string RO_BASEBCR = "Basebcr";

    private decimal? _basebcr;

    private static readonly string RO_BASEDIFALIQUOTAS = "Basedifaliquotas";

    private decimal? _basedifaliquotas;

    private static readonly string RO_BASEICMS = "Baseicms";

    private decimal? _baseicms;

    private static readonly string RO_BASEICMSADICIONAL = "Baseicmsadicional";

    private decimal? _baseicmsadicional;

    private static readonly string RO_BASEICMSBCR = "Baseicmsbcr";

    private decimal? _baseicmsbcr;

    private static readonly string RO_BASEICMSULTENT = "Baseicmsultent";

    private decimal? _baseicmsultent;

    private static readonly string RO_BASEICMSULTENTANT = "Baseicmsultentant";

    private decimal? _baseicmsultentant;

    private static readonly string RO_BASEICMS2 = "Baseicms2";

    private decimal? _baseicms2;

    private static readonly string RO_BASEICST = "Baseicst";

    private decimal? _baseicst;

    private static readonly string RO_BASEIVAMEX = "Baseivamex";

    private decimal? _baseivamex;

    private static readonly string RO_BASESTSAIDA = "Basestsaida";

    private decimal? _basestsaida;

    private static readonly string RO_BCISS = "Bciss";

    private decimal? _bciss;

    private static readonly string RO_BRINDE = "Brinde";

    private string _brinde;

    private static readonly string RO_CALCCREDIPI = "Calccredipi";

    private string _calccredipi;

    private static readonly string RO_CAPVOLDNF = "Capvoldnf";

    private decimal? _capvoldnf;

    private static readonly string RO_CLASSIFICFISCAL = "Classificfiscal";

    private string _classificfiscal;

    private static readonly string RO_CODAUXILIAR = "Codauxiliar";

    private decimal? _codauxiliar;

    private static readonly string RO_CODBASE = "Codbase";

    private string _codbase;

    private static readonly string RO_CODCERTIFIC = "Codcertific";

    private decimal? _codcertific;

    private static readonly string RO_CODCLI = "Codcli";

    private decimal _codcli;

    private static readonly string RO_CODDESCONTO = "Coddesconto";

    private decimal? _coddesconto;

    private static readonly string RO_CODDEVOL = "Coddevol";

    private decimal? _coddevol;

    private static readonly string RO_CODECF = "Codecf";

    private string _codecf;

    private static readonly string RO_CODEPTO = "Codepto";

    private decimal? _codepto;

    private static readonly string RO_CODEQUIPAMENTO = "Codequipamento";

    private decimal? _codequipamento;

    private static readonly string RO_CODFILIAL = "Codfilial";

    private string _codfilial;

    private static readonly string RO_CODFILIALNF = "Codfilialnf";

    private string _codfilialnf;

    private static readonly string RO_CODFILIALRETIRA = "Codfilialretira";

    private string _codfilialretira;

    private static readonly string RO_CODFISCAL = "Codfiscal";

    private decimal? _codfiscal;

    private static readonly string RO_CODFISCALFRETEENT = "Codfiscalfreteent";

    private decimal? _codfiscalfreteent;

    private static readonly string RO_CODFISCALOUTRASDESPENT = "Codfiscaloutrasdespent";

    private decimal? _codfiscaloutrasdespent;

    private static readonly string RO_CODFORMULA = "Codformula";

    private string _codformula;

    private static readonly string RO_CODFORNEC = "Codfornec";

    private decimal? _codfornec;

    private static readonly string RO_CODFORNECPROD = "Codfornecprod";

    private decimal? _codfornecprod;

    private static readonly string RO_CODFUNCCONF = "Codfuncconf";

    private decimal? _codfuncconf;

    private static readonly string RO_CODFUNCEMBAL = "Codfuncembal";

    private decimal? _codfuncembal;

    private static readonly string RO_CODFUNCEXPORTACAOWMS = "Codfuncexportacaowms";

    private decimal? _codfuncexportacaowms;

    private static readonly string RO_CODFUNCIMPORTACAOWMS = "Codfuncimportacaowms";

    private decimal? _codfuncimportacaowms;

    private static readonly string RO_CODFUNCLANC = "Codfunclanc";

    private decimal? _codfunclanc;

    private static readonly string RO_CODFUNCQUARENTENA = "Codfuncquarentena";

    private decimal? _codfuncquarentena;

    private static readonly string RO_CODFUNCREQ = "Codfuncreq";

    private decimal? _codfuncreq;

    private static readonly string RO_CODGENEROFISCAL = "Codgenerofiscal";

    private decimal? _codgenerofiscal;

    private static readonly string RO_CODICMTAB = "Codicmtab";

    private decimal? _codicmtab;

    private static readonly string RO_CODMOTORISTA = "Codmotorista";

    private decimal? _codmotorista;

    private static readonly string RO_CODOPER = "Codoper";

    private string _codoper;

    private static readonly string RO_CODPASSEFISCAL = "Codpassefiscal";

    private decimal? _codpassefiscal;

    private static readonly string RO_CODPLPAG = "Codplpag";

    private decimal? _codplpag;

    private static readonly string RO_CODPROD = "Codprod";

    private decimal _codprod;

    private static readonly string RO_CODPRODDNF = "Codproddnf";

    private decimal? _codproddnf;

    private static readonly string RO_CODPRODPRINC = "Codprodprinc";

    private decimal? _codprodprinc;

    private static readonly string RO_CODPRODRELEV = "Codprodrelev";

    private decimal? _codprodrelev;

    private static readonly string RO_CODPRODSINTEGRA = "Codprodsintegra";

    private string _codprodsintegra;

    private static readonly string RO_CODPROMOCAO = "Codpromocao";

    private string _codpromocao;

    private static readonly string RO_CODSEC = "Codsec";

    private decimal? _codsec;

    private static readonly string RO_CODSITTRIBPISCOFINS = "Codsittribpiscofins";

    private decimal? _codsittribpiscofins;

    private static readonly string RO_CODST = "Codst";

    private decimal? _codst;

    private static readonly string RO_CODUSUR = "Codusur";

    private decimal _codusur;

    private static readonly string RO_CODVASILHAME = "Codvasilhame";

    private decimal? _codvasilhame;

    private static readonly string RO_COMPLEMENTO = "Complemento";

    private string _complemento;

    private static readonly string RO_COMPRACONSIGNADO = "Compraconsignado";

    private string _compraconsignado;

    private static readonly string RO_CONTROLANUMSERIE = "Controlanumserie";

    private string _controlanumserie;

    private static readonly string RO_CUSTOCONT = "Custocont";

    private decimal? _custocont;

    private static readonly string RO_CUSTOCONTANT = "Custocontant";

    private decimal? _custocontant;

    private static readonly string RO_CUSTOFIN = "Custofin";

    private decimal? _custofin;

    private static readonly string RO_CUSTOFINANT = "Custofinant";

    private decimal? _custofinant;

    private static readonly string RO_CUSTOFINEST = "Custofinest";

    private decimal? _custofinest;

    private static readonly string RO_CUSTOFORNEC = "Custofornec";

    private decimal? _custofornec;

    private static readonly string RO_CUSTONFSEMST = "Custonfsemst";

    private decimal? _custonfsemst;

    private static readonly string RO_CUSTONFSEMSTANT = "Custonfsemstant";

    private decimal? _custonfsemstant;

    private static readonly string RO_CUSTOREAL = "Custoreal";

    private decimal? _custoreal;

    private static readonly string RO_CUSTOREALANT = "Custorealant";

    private decimal? _custorealant;

    private static readonly string RO_CUSTOREALSEMST = "Custorealsemst";

    private decimal? _custorealsemst;

    private static readonly string RO_CUSTOREALSEMSTANT = "Custorealsemstant";

    private decimal? _custorealsemstant;

    private static readonly string RO_CUSTOREP = "Custorep";

    private decimal? _custorep;

    private static readonly string RO_CUSTOREPANT = "Custorepant";

    private decimal? _custorepant;

    private static readonly string RO_CUSTOULTENT = "Custoultent";

    private decimal? _custoultent;

    private static readonly string RO_CUSTOULTENTANT = "Custoultentant";

    private decimal? _custoultentant;

    private static readonly string RO_CUSTOULTENTANT2 = "Custoultentant2";

    private decimal? _custoultentant2;

    private static readonly string RO_CUSTOULTENTFIN = "Custoultentfin";

    private decimal? _custoultentfin;

    private static readonly string RO_CUSTOULTENTFINANT = "Custoultentfinant";

    private decimal? _custoultentfinant;

    private static readonly string RO_CUSTOULTENTMED = "Custoultentmed";

    private decimal? _custoultentmed;

    private static readonly string RO_CUSTOULTENTMEDANT = "Custoultentmedant";

    private decimal? _custoultentmedant;

    private static readonly string RO_DATAFABRICACAO = "Datafabricacao";

    private DateTime? _datafabricacao;

    private static readonly string RO_DATALIBQUARENTENA = "Datalibquarentena";

    private DateTime? _datalibquarentena;

    private static readonly string RO_DATAVALIDADE = "Datavalidade";

    private DateTime? _datavalidade;

    private static readonly string RO_DESCRICAO = "Descricao";

    private string _descricao;

    private static readonly string RO_DESCRICAO1 = "Descricao1";

    private string _descricao1;

    private static readonly string RO_DTAPURACAO = "Dtapuracao";

    private DateTime? _dtapuracao;

    private static readonly string RO_DTCANCEL = "Dtcancel";

    private DateTime? _dtcancel;

    private static readonly string RO_DTDENEGADA = "Dtdenegada";

    private DateTime? _dtdenegada;

    private static readonly string RO_DTEXPORTACAOSERVINT = "Dtexportacaoservint";

    private DateTime? _dtexportacaoservint;

    private static readonly string RO_DTEXPORTACAOWMS = "Dtexportacaowms";

    private DateTime? _dtexportacaowms;

    private static readonly string RO_DTFIMCONF = "Dtfimconf";

    private DateTime? _dtfimconf;

    private static readonly string RO_DTIMPORTACAOSERVPRINC = "Dtimportacaoservprinc";

    private DateTime? _dtimportacaoservprinc;

    private static readonly string RO_DTIMPORTACAOWMS = "Dtimportacaowms";

    private DateTime? _dtimportacaowms;

    private static readonly string RO_DTINICIOCONF = "Dtinicioconf";

    private DateTime? _dtinicioconf;

    private static readonly string RO_DTMOV = "Dtmov";

    private DateTime _dtmov;

    private static readonly string RO_DTMOVLOG = "Dtmovlog";

    private DateTime? _dtmovlog;

    private static readonly string RO_DTULTENTANT = "Dtultentant";

    private DateTime? _dtultentant;

    private static readonly string RO_DTWMS = "Dtwms";

    private DateTime? _dtwms;

    private static readonly string RO_DV = "Dv";

    private decimal? _dv;

    private static readonly string RO_EMBALAGEM = "Embalagem";

    private string _embalagem;

    private static readonly string RO_EQUIPLANC = "Equiplanc";

    private string _equiplanc;

    private static readonly string RO_ESTOQUEDESBLOQUEADO = "Estoquedesbloqueado";

    private string _estoquedesbloqueado;

    private static readonly string RO_EXPORTADOSERVINT = "Exportadoservint";

    private string _exportadoservint;

    private static readonly string RO_FATORCONVDNF = "Fatorconvdnf";

    private decimal? _fatorconvdnf;

    private static readonly string RO_FATORCUSTONATRANSF = "Fatorcustonatransf";

    private decimal? _fatorcustonatransf;

    private static readonly string RO_FUNCLANC = "Funclanc";

    private string _funclanc;

    private static readonly string RO_FUNDAPIANO = "Fundapiano";

    private string _fundapiano;

    private static readonly string RO_GERAGNRE_CNPJCLIENTE = "Geragnre_Cnpjcliente";

    private string _geragnre_cnpjcliente;

    private static readonly string RO_GERAICMSLIVROFISCAL = "Geraicmslivrofiscal";

    private string _geraicmslivrofiscal;

    private static readonly string RO_HISTORICO = "Historico";

    private string _historico;

    private static readonly string RO_HORALANC = "Horalanc";

    private string _horalanc;

    private static readonly string RO_HORAPRODUCAO = "Horaproducao";

    private DateTime? _horaproducao;

    private static readonly string RO_ICMSRESSARC = "Icmsressarc";

    private decimal? _icmsressarc;

    private static readonly string RO_IMPORTADO = "Importado";

    private string _importado;

    private static readonly string RO_IMPORTADOSERVPRINC = "Importadoservprinc";

    private string _importadoservprinc;

    private static readonly string RO_INDLOCAL = "Indlocal";

    private string _indlocal;

    private static readonly string RO_ISSRETIDO = "Issretido";

    private string _issretido;

    private static readonly string RO_ITEMDIVERGENTE = "Itemdivergente";

    private string _itemdivergente;

    private static readonly string RO_IVA = "Iva";

    private decimal? _iva;

    private static readonly string RO_IVARESSARC = "Ivaressarc";

    private decimal? _ivaressarc;

    private static readonly string RO_IVATRIBUT = "Ivatribut";

    private decimal? _ivatribut;

    private static readonly string RO_LOCALIZACAO = "Localizacao";

    private string _localizacao;

    private static readonly string RO_MINUTOLANC = "Minutolanc";

    private string _minutolanc;

    private static readonly string RO_MOVIMENTACONTACORRENTERCA = "Movimentacontacorrenterca";

    private string _movimentacontacorrenterca;

    private static readonly string RO_NBM = "Nbm";

    private string _nbm;

    private static readonly string RO_NUMADICAO = "Numadicao";

    private decimal? _numadicao;

    private static readonly string RO_NUMBONO = "Numbono";

    private decimal? _numbono;

    private static readonly string RO_NUMBONUS = "Numbonus";

    private decimal? _numbonus;

    private static readonly string RO_NUMCAR = "Numcar";

    private decimal? _numcar;

    private static readonly string RO_NUMCARANTERIOR = "Numcaranterior";

    private decimal? _numcaranterior;

    private static readonly string RO_NUMFORMULARIO = "Numformulario";

    private decimal? _numformulario;

    private static readonly string RO_NUMFORMULARIO2 = "Numformulario2";

    private decimal? _numformulario2;

    private static readonly string RO_NUMIDF = "Numidf";

    private string _numidf;

    private static readonly string RO_NUMLANCCP = "Numlanccp";

    private decimal? _numlanccp;

    private static readonly string RO_NUMLISTA = "Numlista";

    private decimal? _numlista;

    private static readonly string RO_NUMLOTE = "Numlote";

    private string _numlote;

    private static readonly string RO_NUMLOTEFAB = "Numlotefab";

    private string _numlotefab;

    private static readonly string RO_NUMNEGOCIACAO = "Numnegociacao";

    private decimal? _numnegociacao;

    private static readonly string RO_NUMNOTA = "Numnota";

    private decimal _numnota;

    private static readonly string RO_NUMNOTADEV = "Numnotadev";

    private decimal? _numnotadev;

    private static readonly string RO_NUMOP = "Numop";

    private decimal? _numop;

    private static readonly string RO_NUMPED = "Numped";

    private decimal? _numped;

    private static readonly string RO_NUMREGIAO = "Numregiao";

    private decimal? _numregiao;

    private static readonly string RO_NUMSEQ = "Numseq";

    private decimal? _numseq;

    private static readonly string RO_NUMSEQADICAO = "Numseqadicao";

    private decimal? _numseqadicao;

    private static readonly string RO_NUMSEQPED = "Numseqped";

    private decimal? _numseqped;

    private static readonly string RO_NUMTRANSAVULSA = "Numtransavulsa";

    private decimal? _numtransavulsa;

    private static readonly string RO_NUMTRANSDEV = "Numtransdev";

    private decimal? _numtransdev;

    private static readonly string RO_NUMTRANSDEVFOR = "Numtransdevfor";

    private decimal? _numtransdevfor;

    private static readonly string RO_NUMTRANSENT = "Numtransent";

    private decimal? _numtransent;

    private static readonly string RO_NUMTRANSENTULTENT = "Numtransentultent";

    private decimal? _numtransentultent;

    private static readonly string RO_NUMTRANSENTULTENTANT = "Numtransentultentant";

    private decimal? _numtransentultentant;

    private static readonly string RO_NUMTRANSITEM = "Numtransitem";

    private decimal? _numtransitem;

    private static readonly string RO_NUMTRANSOP = "Numtransop";

    private decimal? _numtransop;

    private static readonly string RO_NUMTRANSVENDA = "Numtransvenda";

    private decimal? _numtransvenda;

    private static readonly string RO_NUMVERBAOUTRAS = "Numverbaoutras";

    private decimal? _numverbaoutras;

    private static readonly string RO_NUMVERBAREBCMV = "Numverbarebcmv";

    private decimal? _numverbarebcmv;

    private static readonly string RO_NUMVOLUMESCONFERENCIA = "Numvolumesconferencia";

    private decimal? _numvolumesconferencia;

    private static readonly string RO_PAGTOGNRENOMEDOREMETENTE = "Pagtognrenomedoremetente";

    private string _pagtognrenomedoremetente;

    private static readonly string RO_PASSELIVRE = "Passelivre";

    private string _passelivre;

    private static readonly string RO_PAUTA = "Pauta";

    private decimal? _pauta;

    private static readonly string RO_PBASERCA = "Pbaserca";

    private decimal? _pbaserca;

    private static readonly string RO_PBONIFIC = "Pbonific";

    private decimal? _pbonific;

    private static readonly string RO_PERACRESCIMOCUSTO = "Peracrescimocusto";

    private decimal? _peracrescimocusto;

    private static readonly string RO_PERACRESCIMOPF = "Peracrescimopf";

    private decimal? _peracrescimopf;

    private static readonly string RO_PERBONIFIC = "Perbonific";

    private decimal? _perbonific;

    private static readonly string RO_PERCAGREGADORST = "Percagregadorst";

    private decimal? _percagregadorst;

    private static readonly string RO_PERCALIQEXTGUIA = "Percaliqextguia";

    private decimal? _percaliqextguia;

    private static readonly string RO_PERCALIQEXTICMANTECIP = "Percaliqexticmantecip";

    private decimal? _percaliqexticmantecip;

    private static readonly string RO_PERCALIQEXT2 = "Percaliqext2";

    private decimal? _percaliqext2;

    private static readonly string RO_PERCALIQINTICMANTECIP = "Percaliqinticmantecip";

    private decimal? _percaliqinticmantecip;

    private static readonly string RO_PERCALIQINT2 = "Percaliqint2";

    private decimal? _percaliqint2;

    private static readonly string RO_PERCBASERED = "Percbasered";

    private decimal? _percbasered;

    private static readonly string RO_PERCBASEREDADICIONAL = "Percbaseredadicional";

    private decimal? _percbaseredadicional;

    private static readonly string RO_PERCBASEREDST = "Percbaseredst";

    private decimal? _percbaseredst;

    private static readonly string RO_PERCBASEREDSTFONTE = "Percbaseredstfonte";

    private decimal? _percbaseredstfonte;

    private static readonly string RO_PERCBON = "Percbon";

    private decimal? _percbon;

    private static readonly string RO_PERCBONOUTRAS = "Percbonoutras";

    private decimal? _percbonoutras;

    private static readonly string RO_PERCCREDICMPRESUMIDO = "Perccredicmpresumido";

    private decimal? _perccredicmpresumido;

    private static readonly string RO_PERCDESC = "Percdesc";

    private decimal? _percdesc;

    private static readonly string RO_PERCDESCCOFINS = "Percdesccofins";

    private decimal? _percdesccofins;

    private static readonly string RO_PERCDESCFIN = "Percdescfin";

    private decimal? _percdescfin;

    private static readonly string RO_PERCDESCICMSDIF = "Percdescicmsdif";

    private decimal? _percdescicmsdif;

    private static readonly string RO_PERCDESCPIS = "Percdescpis";

    private decimal? _percdescpis;

    private static readonly string RO_PERCDESPADICIONAL = "Percdespadicional";

    private decimal? _percdespadicional;

    private static readonly string RO_PERCDESPDENTRONF = "Percdespdentronf";

    private decimal? _percdespdentronf;

    private static readonly string RO_PERCDESPFIN = "Percdespfin";

    private decimal? _percdespfin;

    private static readonly string RO_PERCDESPFORANF = "Percdespforanf";

    private decimal? _percdespforanf;

    private static readonly string RO_PERCDIFALIQUOTAS = "Percdifaliquotas";

    private decimal? _percdifaliquotas;

    private static readonly string RO_PERCDIREITOSADUANEIROS = "Percdireitosaduaneiros";

    private decimal? _percdireitosaduaneiros;

    private static readonly string RO_PERCFRETE = "Percfrete";

    private decimal? _percfrete;

    private static readonly string RO_PERCFRETEFOB = "Percfretefob";

    private decimal? _percfretefob;

    private static readonly string RO_PERCICM = "Percicm";

    private decimal? _percicm;

    private static readonly string RO_PERCICMCP = "Percicmcp";

    private decimal? _percicmcp;

    private static readonly string RO_PERCICMOP = "Percicmop";

    private decimal? _percicmop;

    private static readonly string RO_PERCICMORIGINAL = "Percicmoriginal";

    private decimal? _percicmoriginal;

    private static readonly string RO_PERCICMRED = "Percicmred";

    private decimal? _percicmred;

    private static readonly string RO_PERCICMSDIFERIDO = "Percicmsdiferido";

    private decimal? _percicmsdiferido;

    private static readonly string RO_PERCICMSFRETEFOBST = "Percicmsfretefobst";

    private decimal? _percicmsfretefobst;

    private static readonly string RO_PERCICM2 = "Percicm2";

    private decimal? _percicm2;

    private static readonly string RO_PERCIISUSPENSO = "Perciisuspenso";

    private decimal? _perciisuspenso;

    private static readonly string RO_PERCIMPORTACAO = "Percimportacao";

    private decimal? _percimportacao;

    private static readonly string RO_PERCIMPOSTOCONSUMO = "Percimpostoconsumo";

    private decimal? _percimpostoconsumo;

    private static readonly string RO_PERCIMPOSTOSELO = "Percimpostoselo";

    private decimal? _percimpostoselo;

    private static readonly string RO_PERCIMPPRODUTORURAL = "Percimpprodutorural";

    private decimal? _percimpprodutorural;

    private static readonly string RO_PERCIMPUREZA = "Percimpureza";

    private decimal? _percimpureza;

    private static readonly string RO_PERCINSS = "Percinss";

    private decimal? _percinss;

    private static readonly string RO_PERCINTEIRO = "Percinteiro";

    private decimal? _percinteiro;

    private static readonly string RO_PERCIPI = "Percipi";

    private decimal? _percipi;

    private static readonly string RO_PERCISS = "Perciss";

    private decimal? _perciss;

    private static readonly string RO_PERCIVA = "Perciva";

    private decimal? _perciva;

    private static readonly string RO_PERCIVAICMANTECIP = "Percivaicmantecip";

    private decimal? _percivaicmantecip;

    private static readonly string RO_PERCIVAMEX = "Percivamex";

    private decimal? _percivamex;

    private static readonly string RO_PERCIVA2 = "Perciva2";

    private decimal? _perciva2;

    private static readonly string RO_PERCMEXFPGC = "Percmexfpgc";

    private decimal? _percmexfpgc;

    private static readonly string RO_PERCMEXIEPS = "Percmexieps";

    private decimal? _percmexieps;

    private static readonly string RO_PERCMEXIVA = "Percmexiva";

    private decimal? _percmexiva;

    private static readonly string RO_PERCOFINS = "Percofins";

    private decimal? _percofins;

    private static readonly string RO_PERCOM = "Percom";

    private decimal? _percom;

    private static readonly string RO_PERCOMFILIALBROKER = "Percomfilialbroker";

    private decimal? _percomfilialbroker;

    private static readonly string RO_PERCOMMOT = "Percommot";

    private decimal? _percommot;

    private static readonly string RO_PERCOMSUP = "Percomsup";

    private decimal? _percomsup;

    private static readonly string RO_PERCOM2 = "Percom2";

    private decimal? _percom2;

    private static readonly string RO_PERCOM3 = "Percom3";

    private decimal? _percom3;

    private static readonly string RO_PERCOM4 = "Percom4";

    private decimal? _percom4;

    private static readonly string RO_PERCOUTRASDESP = "Percoutrasdesp";

    private decimal? _percoutrasdesp;

    private static readonly string RO_PERCOUTROSCUSTOS = "Percoutroscustos";

    private decimal? _percoutroscustos;

    private static readonly string RO_PERCQUEBRADO = "Percquebrado";

    private decimal? _percquebrado;

    private static readonly string RO_PERCREDICMS = "Percredicms";

    private decimal? _percredicms;

    private static readonly string RO_PERCSEGURO = "Percseguro";

    private decimal? _percseguro;

    private static readonly string RO_PERCST = "Percst";

    private decimal? _percst;

    private static readonly string RO_PERCSUFRAMA = "Percsuframa";

    private decimal? _percsuframa;

    private static readonly string RO_PERCUMIDADE = "Percumidade";

    private decimal? _percumidade;

    private static readonly string RO_PERCVENDA = "Percvenda";

    private decimal? _percvenda;

    private static readonly string RO_PERCVERMELHO = "Percvermelho";

    private decimal? _percvermelho;

    private static readonly string RO_PERCVLBONIFIC = "Percvlbonific";

    private decimal? _percvlbonific;

    private static readonly string RO_PERDESCCOM = "Perdesccom";

    private decimal? _perdesccom;

    private static readonly string RO_PERDESCCUSTO = "Perdesccusto";

    private decimal? _perdesccusto;

    private static readonly string RO_PERDESCFIN = "Perdescfin";

    private decimal? _perdescfin;

    private static readonly string RO_PERDESCFLEX = "Perdescflex";

    private decimal? _perdescflex;

    private static readonly string RO_PERDESCISENTOICMS = "Perdescisentoicms";

    private decimal? _perdescisentoicms;

    private static readonly string RO_PERFRETECMV = "Perfretecmv";

    private decimal? _perfretecmv;

    private static readonly string RO_PERICM = "Pericm";

    private decimal? _pericm;

    private static readonly string RO_PERICMFRETE = "Pericmfrete";

    private decimal? _pericmfrete;

    private static readonly string RO_PERICMGUIAPROPRIA = "Pericmguiapropria";

    private decimal? _pericmguiapropria;

    private static readonly string RO_PERICMSANTECIPADO = "Pericmsantecipado";

    private decimal? _pericmsantecipado;

    private static readonly string RO_PERPIS = "Perpis";

    private decimal? _perpis;

    private static readonly string RO_PERREDCOMISS = "Perredcomiss";

    private decimal? _perredcomiss;

    private static readonly string RO_PERREDCOMISSSUP = "Perredcomisssup";

    private decimal? _perredcomisssup;

    private static readonly string RO_PESOBRUTO = "Pesobruto";

    private decimal? _pesobruto;

    private static readonly string RO_PESOLIQ = "Pesoliq";

    private decimal? _pesoliq;

    private static readonly string RO_PISCOFINSRETIDO = "Piscofinsretido";

    private string _piscofinsretido;

    private static readonly string RO_PLIQPED = "Pliqped";

    private decimal? _pliqped;

    private static readonly string RO_PRAZOMEDIO = "Prazomedio";

    private decimal? _prazomedio;

    private static readonly string RO_PRECOPAUTA = "Precopauta";

    private decimal? _precopauta;

    private static readonly string RO_PRODBONIFICADO = "Prodbonificado";

    private string _prodbonificado;

    private static readonly string RO_PRODDESCRICAOCONTRATO = "Proddescricaocontrato";

    private string _proddescricaocontrato;

    private static readonly string RO_PROMOCAOBIRO = "Promocaobiro";

    private string _promocaobiro;

    private static readonly string RO_PTABELA = "Ptabela";

    private decimal? _ptabela;

    private static readonly string RO_PTABELA2 = "Ptabela2";

    private decimal? _ptabela2;

    private static readonly string RO_PUNIT = "Punit";

    private decimal? _punit;

    private static readonly string RO_PUNITCONT = "Punitcont";

    private decimal? _punitcont;

    private static readonly string RO_PUNITNF = "Punitnf";

    private decimal? _punitnf;

    private static readonly string RO_PVENDABASE = "Pvendabase";

    private decimal? _pvendabase;

    private static readonly string RO_PVENDAEMB = "Pvendaemb";

    private decimal? _pvendaemb;

    private static readonly string RO_PVENDAEMBALAGEM = "Pvendaembalagem";

    private decimal? _pvendaembalagem;

    private static readonly string RO_PVENDA1 = "Pvenda1";

    private decimal? _pvenda1;

    private static readonly string RO_QT = "Qt";

    private decimal? _qt;

    private static readonly string RO_QTAVARIA = "Qtavaria";

    private decimal? _qtavaria;

    private static readonly string RO_QTBLOQUEADA = "Qtbloqueada";

    private decimal? _qtbloqueada;

    private static readonly string RO_QTCONF = "Qtconf";

    private decimal? _qtconf;

    private static readonly string RO_QTCONT = "Qtcont";

    private decimal? _qtcont;

    private static readonly string RO_QTCX = "Qtcx";

    private decimal? _qtcx;

    private static readonly string RO_QTDEVOL = "Qtdevol";

    private decimal? _qtdevol;

    private static readonly string RO_QTEMBALAGEM = "Qtembalagem";

    private decimal? _qtembalagem;

    private static readonly string RO_QTESTANT = "Qtestant";

    private decimal? _qtestant;

    private static readonly string RO_QTESTGERANT = "Qtestgerant";

    private decimal? _qtestgerant;

    private static readonly string RO_QTHORAS = "Qthoras";

    private decimal? _qthoras;

    private static readonly string RO_QTPECAS = "Qtpecas";

    private decimal? _qtpecas;

    private static readonly string RO_QTSALDOEST = "Qtsaldoest";

    private decimal? _qtsaldoest;

    private static readonly string RO_QTSALDOESTGER = "Qtsaldoestger";

    private decimal? _qtsaldoestger;

    private static readonly string RO_QTULTENTANT = "Qtultentant";

    private decimal? _qtultentant;

    private static readonly string RO_QTUNIT = "Qtunit";

    private decimal? _qtunit;

    private static readonly string RO_QTUNITCX = "Qtunitcx";

    private decimal? _qtunitcx;

    private static readonly string RO_QTUNITEMB = "Qtunitemb";

    private decimal? _qtunitemb;

    private static readonly string RO_QTVENDAEMB = "Qtvendaemb";

    private decimal? _qtvendaemb;

    private static readonly string RO_QUALDIVERGENCIA = "Qualdivergencia";

    private string _qualdivergencia;

    private static readonly string RO_REDBASEALIQEXT = "Redbasealiqext";

    private decimal? _redbasealiqext;

    private static readonly string RO_REDBASEIVA = "Redbaseiva";

    private decimal? _redbaseiva;

    private static readonly string RO_REFCOR = "Refcor";

    private string _refcor;

    private static readonly string RO_ROTINACAD = "Rotinacad";

    private string _rotinacad;

    private static readonly string RO_ROTINALANC = "Rotinalanc";

    private string _rotinalanc;

    private static readonly string RO_RUA = "Rua";

    private decimal? _rua;

    private static readonly string RO_SEQMOV = "Seqmov";

    private decimal? _seqmov;

    private static readonly string RO_SIGLAQUALIDADE = "Siglaqualidade";

    private string _siglaqualidade;

    private static readonly string RO_SITTRIBUT = "Sittribut";

    private string _sittribut;

    private static readonly string RO_ST = "St";

    private decimal? _st;

    private static readonly string RO_STATUS = "Status";

    private string _status;

    private static readonly string RO_STBCR = "Stbcr";

    private decimal? _stbcr;

    private static readonly string RO_STCLIENTEGNRE = "Stclientegnre";

    private decimal? _stclientegnre;

    private static readonly string RO_STSAIDA = "Stsaida";

    private decimal? _stsaida;

    private static readonly string RO_TIPODESCAPLICADO = "Tipodescaplicado";

    private string _tipodescaplicado;

    private static readonly string RO_TIPOFORNEC = "Tipofornec";

    private string _tipofornec;

    private static readonly string RO_TIPOITEM = "Tipoitem";

    private string _tipoitem;

    private static readonly string RO_TIPOMERC = "Tipomerc";

    private string _tipomerc;

    private static readonly string RO_TIPOMERCDEPTO = "Tipomercdepto";

    private string _tipomercdepto;

    private static readonly string RO_TIPOSEPARACAO = "Tiposeparacao";

    private string _tiposeparacao;

    private static readonly string RO_TIPOTIS = "Tipotis";

    private string _tipotis;

    private static readonly string RO_TIPOTRIBUTMEDIC = "Tipotributmedic";

    private string _tipotributmedic;

    private static readonly string RO_TRANSACAOTRANSFERIDA = "Transacaotransferida";

    private string _transacaotransferida;

    private static readonly string RO_TRGPCLOTE = "Trgpclote";

    private string _trgpclote;

    private static readonly string RO_TRIBFEDERAL = "Tribfederal";

    private string _tribfederal;

    private static readonly string RO_TRUNCARITEM = "Truncaritem";

    private string _truncaritem;

    private static readonly string RO_TXVENDA = "Txvenda";

    private decimal? _txvenda;

    private static readonly string RO_UFFORNEC = "Uffornec";

    private string _uffornec;

    private static readonly string RO_UNIDADE = "Unidade";

    private string _unidade;

    private static readonly string RO_USADEBCREDRCABRIND = "Usadebcredrcabrind";

    private string _usadebcredrcabrind;

    private static readonly string RO_VALORDIREITOSADUANEIROS = "Valordireitosaduaneiros";

    private decimal? _valordireitosaduaneiros;

    private static readonly string RO_VALORIMPOSTOCONSUMO = "Valorimpostoconsumo";

    private decimal? _valorimpostoconsumo;

    private static readonly string RO_VALORIMPOSTOSELO = "Valorimpostoselo";

    private decimal? _valorimpostoselo;

    private static readonly string RO_VALORULTENTANT = "Valorultentant";

    private decimal? _valorultentant;

    private static readonly string RO_VALORULTENTMED = "Valorultentmed";

    private decimal? _valorultentmed;

    private static readonly string RO_VALORULTENTMEDANT = "Valorultentmedant";

    private decimal? _valorultentmedant;

    private static readonly string RO_VLACRESCIMOPF = "Vlacrescimopf";

    private decimal? _vlacrescimopf;

    private static readonly string RO_VLACRESCRODAPE = "Vlacrescrodape";

    private decimal? _vlacrescrodape;

    private static readonly string RO_VLADICIONALBCST = "Vladicionalbcst";

    private decimal? _vladicionalbcst;

    private static readonly string RO_VLADUANEIRA = "Vladuaneira";

    private decimal? _vladuaneira;

    private static readonly string RO_VLBASEGNRE = "Vlbasegnre";

    private decimal? _vlbasegnre;

    private static readonly string RO_VLBASEIPI = "Vlbaseipi";

    private decimal? _vlbaseipi;

    private static readonly string RO_VLBASEPISCOFINS = "Vlbasepiscofins";

    private decimal? _vlbasepiscofins;

    private static readonly string RO_VLBASESTFORANF = "Vlbasestforanf";

    private decimal? _vlbasestforanf;

    private static readonly string RO_VLBONIFIC = "Vlbonific";

    private decimal? _vlbonific;

    private static readonly string RO_VLBONIFICOUTRAS = "Vlbonificoutras";

    private decimal? _vlbonificoutras;

    private static readonly string RO_VLCOFINS = "Vlcofins";

    private decimal? _vlcofins;

    private static readonly string RO_VLCREDCOFINS = "Vlcredcofins";

    private decimal? _vlcredcofins;

    private static readonly string RO_VLCREDICMS = "Vlcredicms";

    private decimal? _vlcredicms;

    private static readonly string RO_VLCREDICMSFRETE = "Vlcredicmsfrete";

    private decimal? _vlcredicmsfrete;

    private static readonly string RO_VLCREDPIS = "Vlcredpis";

    private decimal? _vlcredpis;

    private static readonly string RO_VLCREDPRESUMIDO = "Vlcredpresumido";

    private decimal? _vlcredpresumido;

    private static readonly string RO_VLDESCCOM = "Vldesccom";

    private decimal? _vldesccom;

    private static readonly string RO_VLDESCCUSTOCMV = "Vldesccustocmv";

    private decimal? _vldesccustocmv;

    private static readonly string RO_VLDESCFIN = "Vldescfin";

    private decimal? _vldescfin;

    private static readonly string RO_VLDESCFLEX = "Vldescflex";

    private decimal? _vldescflex;

    private static readonly string RO_VLDESCICMISENCAO = "Vldescicmisencao";

    private decimal? _vldescicmisencao;

    private static readonly string RO_VLDESCICMSDIF = "Vldescicmsdif";

    private decimal? _vldescicmsdif;

    private static readonly string RO_VLDESCONTO = "Vldesconto";

    private decimal? _vldesconto;

    private static readonly string RO_VLDESCPISSUFRAMA = "Vldescpissuframa";

    private decimal? _vldescpissuframa;

    private static readonly string RO_VLDESCREDUCAOCOFINS = "Vldescreducaocofins";

    private decimal? _vldescreducaocofins;

    private static readonly string RO_VLDESCREDUCAOPIS = "Vldescreducaopis";

    private decimal? _vldescreducaopis;

    private static readonly string RO_VLDESCRODAPE = "Vldescrodape";

    private decimal? _vldescrodape;

    private static readonly string RO_VLDESCSUFRAMA = "Vldescsuframa";

    private decimal? _vldescsuframa;

    private static readonly string RO_VLDESPADICIONAL = "Vldespadicional";

    private decimal? _vldespadicional;

    private static readonly string RO_VLDESPDENTRONF = "Vldespdentronf";

    private decimal? _vldespdentronf;

    private static readonly string RO_VLDESPFORANF = "Vldespforanf";

    private decimal? _vldespforanf;

    private static readonly string RO_VLDIFALIQUOTAS = "Vldifaliquotas";

    private decimal? _vldifaliquotas;

    private static readonly string RO_VLDIFPUNITCONT = "Vldifpunitcont";

    private decimal? _vldifpunitcont;

    private static readonly string RO_VLFRETE = "Vlfrete";

    private decimal? _vlfrete;

    private static readonly string RO_VLFRETECONHEC = "Vlfreteconhec";

    private decimal? _vlfreteconhec;

    private static readonly string RO_VLFRETEPORKG = "Vlfreteporkg";

    private decimal? _vlfreteporkg;

    private static readonly string RO_VLFRETE_RATEIO = "Vlfrete_Rateio";

    private decimal? _vlfrete_rateio;

    private static readonly string RO_VLICMSBCR = "Vlicmsbcr";

    private decimal? _vlicmsbcr;

    private static readonly string RO_VLICMSDIFERIDO = "Vlicmsdiferido";

    private decimal? _vlicmsdiferido;

    private static readonly string RO_VLIMPORTACAO = "Vlimportacao";

    private decimal? _vlimportacao;

    private static readonly string RO_VLINDENIZ = "Vlindeniz";

    private decimal? _vlindeniz;

    private static readonly string RO_VLINSS = "Vlinss";

    private decimal? _vlinss;

    private static readonly string RO_VLIPI = "Vlipi";

    private decimal? _vlipi;

    private static readonly string RO_VLIPIPORKG = "Vlipiporkg";

    private decimal? _vlipiporkg;

    private static readonly string RO_VLISS = "Vliss";

    private decimal? _vliss;

    private static readonly string RO_VLIVAMEX = "Vlivamex";

    private decimal? _vlivamex;

    private static readonly string RO_VLMEXFPGC = "Vlmexfpgc";

    private decimal? _vlmexfpgc;

    private static readonly string RO_VLMEXIEPS = "Vlmexieps";

    private decimal? _vlmexieps;

    private static readonly string RO_VLMEXIVA = "Vlmexiva";

    private decimal? _vlmexiva;

    private static readonly string RO_VLOUTRASDESP = "Vloutrasdesp";

    private decimal? _vloutrasdesp;

    private static readonly string RO_VLOUTRASDESPIMP = "Vloutrasdespimp";

    private decimal? _vloutrasdespimp;

    private static readonly string RO_VLOUTRAS_RATEIO = "Vloutras_Rateio";

    private decimal? _vloutras_rateio;

    private static readonly string RO_VLOUTROS = "Vloutros";

    private decimal? _vloutros;

    private static readonly string RO_VLPAUTAICMS = "Vlpautaicms";

    private decimal? _vlpautaicms;

    private static readonly string RO_VLPAUTAICMSANTEC = "Vlpautaicmsantec";

    private decimal? _vlpautaicmsantec;

    private static readonly string RO_VLPAUTA2 = "Vlpauta2";

    private decimal? _vlpauta2;

    private static readonly string RO_VLPERCBON = "Vlpercbon";

    private decimal? _vlpercbon;

    private static readonly string RO_VLPIS = "Vlpis";

    private decimal? _vlpis;

    private static readonly string RO_VLREDCOMISS = "Vlredcomiss";

    private decimal? _vlredcomiss;

    private static readonly string RO_VLREDCOMISSSUP = "Vlredcomisssup";

    private decimal? _vlredcomisssup;

    private static readonly string RO_VLREPASSE = "Vlrepasse";

    private decimal? _vlrepasse;

    private static readonly string RO_VLSEGURO = "Vlseguro";

    private decimal? _vlseguro;

    private static readonly string RO_VLSISCOMEX = "Vlsiscomex";

    private decimal? _vlsiscomex;

    private static readonly string RO_VLSUFRAMA = "Vlsuframa";

    private decimal? _vlsuframa;

    private static readonly string RO_VLULTENTCONTSEMST = "Vlultentcontsemst";

    private decimal? _vlultentcontsemst;

    private static readonly string RO_VLULTENTCONTSEMSTANT = "Vlultentcontsemstant";

    private decimal? _vlultentcontsemstant;

    private static readonly string RO_VLVERBACMV = "Vlverbacmv";

    private decimal? _vlverbacmv;

    private static readonly string RO_VLVERBACMVCLI = "Vlverbacmvcli";

    private decimal? _vlverbacmvcli;

    private static readonly string RO_VOLUME = "Volume";

    private decimal? _volume;

    private static readonly string RO_VOLUMEDESEJADO = "Volumedesejado";

    private decimal? _volumedesejado;

    private string _movestoquecontabil;

    private string _movestoquegerencial;

    private decimal? _valorultent;

    private static readonly string RO_QBCMONORET = "Qbcmonoret";

    private decimal? _qbcmonoret;

    private static readonly string RO_ADREMICMSRET = "Adremicmsret";

    private decimal? _adremicmsret;

    private static readonly string RO_VICMSMONORET = "Vicmsmonoret";

    private decimal? _vicmsmonoret;

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 2)]
    public decimal? Aliqavulsadare
    {
        get
        {
            PropriedadeAcessada(RO_ALIQAVULSADARE);
            return _aliqavulsadare;
        }
        set
        {
            PropriedadeModificada(RO_ALIQAVULSADARE, value);
            _aliqavulsadare = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 2)]
    public decimal? Aliqicmfreteent
    {
        get
        {
            PropriedadeAcessada(RO_ALIQICMFRETEENT);
            return _aliqicmfreteent;
        }
        set
        {
            PropriedadeModificada(RO_ALIQICMFRETEENT, value);
            _aliqicmfreteent = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 2)]
    public decimal? Aliqicmoutrasdespent
    {
        get
        {
            PropriedadeAcessada(RO_ALIQICMOUTRASDESPENT);
            return _aliqicmoutrasdespent;
        }
        set
        {
            PropriedadeModificada(RO_ALIQICMOUTRASDESPENT, value);
            _aliqicmoutrasdespent = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 2)]
    public decimal? Aliqicmsvigente
    {
        get
        {
            PropriedadeAcessada(RO_ALIQICMSVIGENTE);
            return _aliqicmsvigente;
        }
        set
        {
            PropriedadeModificada(RO_ALIQICMSVIGENTE, value);
            _aliqicmsvigente = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Aliqicms1
    {
        get
        {
            PropriedadeAcessada(RO_ALIQICMS1);
            return _aliqicms1;
        }
        set
        {
            PropriedadeModificada(RO_ALIQICMS1, value);
            _aliqicms1 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Aliqicms2
    {
        get
        {
            PropriedadeAcessada(RO_ALIQICMS2);
            return _aliqicms2;
        }
        set
        {
            PropriedadeModificada(RO_ALIQICMS2, value);
            _aliqicms2 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 2)]
    public decimal? Aliqicst
    {
        get
        {
            PropriedadeAcessada(RO_ALIQICST);
            return _aliqicst;
        }
        set
        {
            PropriedadeModificada(RO_ALIQICST, value);
            _aliqicst = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Aliqstsaida
    {
        get
        {
            PropriedadeAcessada(RO_ALIQSTSAIDA);
            return _aliqstsaida;
        }
        set
        {
            PropriedadeModificada(RO_ALIQSTSAIDA, value);
            _aliqstsaida = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 2)]
    public decimal? Aliquotatis
    {
        get
        {
            PropriedadeAcessada(RO_ALIQUOTATIS);
            return _aliquotatis;
        }
        set
        {
            PropriedadeModificada(RO_ALIQUOTATIS, value);
            _aliquotatis = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 10, Precisao = 0)]
    public string Alternativo
    {
        get
        {
            PropriedadeAcessada(RO_ALTERNATIVO);
            return _alternativo;
        }
        set
        {
            PropriedadeModificada(RO_ALTERNATIVO, value);
            _alternativo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Aplicpercivapauta
    {
        get
        {
            PropriedadeAcessada(RO_APLICPERCIVAPAUTA);
            return _aplicpercivapauta;
        }
        set
        {
            PropriedadeModificada(RO_APLICPERCIVAPAUTA, value);
            _aplicpercivapauta = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Aproveitacredicms
    {
        get
        {
            PropriedadeAcessada(RO_APROVEITACREDICMS);
            return _aproveitacredicms;
        }
        set
        {
            PropriedadeModificada(RO_APROVEITACREDICMS, value);
            _aproveitacredicms = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Aproveitacredpiscofins
    {
        get
        {
            PropriedadeAcessada(RO_APROVEITACREDPISCOFINS);
            return _aproveitacredpiscofins;
        }
        set
        {
            PropriedadeModificada(RO_APROVEITACREDPISCOFINS, value);
            _aproveitacredpiscofins = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Baseacrescimopf
    {
        get
        {
            PropriedadeAcessada(RO_BASEACRESCIMOPF);
            return _baseacrescimopf;
        }
        set
        {
            PropriedadeModificada(RO_BASEACRESCIMOPF, value);
            _baseacrescimopf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Basedifaliquotas
    {
        get
        {
            PropriedadeAcessada(RO_BASEDIFALIQUOTAS);
            return _basedifaliquotas;
        }
        set
        {
            PropriedadeModificada(RO_BASEDIFALIQUOTAS, value);
            _basedifaliquotas = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Baseicms
    {
        get
        {
            PropriedadeAcessada(RO_BASEICMS);
            return _baseicms;
        }
        set
        {
            PropriedadeModificada(RO_BASEICMS, value);
            _baseicms = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Baseicmsadicional
    {
        get
        {
            PropriedadeAcessada(RO_BASEICMSADICIONAL);
            return _baseicmsadicional;
        }
        set
        {
            PropriedadeModificada(RO_BASEICMSADICIONAL, value);
            _baseicmsadicional = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Baseicmsultent
    {
        get
        {
            PropriedadeAcessada(RO_BASEICMSULTENT);
            return _baseicmsultent;
        }
        set
        {
            PropriedadeModificada(RO_BASEICMSULTENT, value);
            _baseicmsultent = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Baseicmsultentant
    {
        get
        {
            PropriedadeAcessada(RO_BASEICMSULTENTANT);
            return _baseicmsultentant;
        }
        set
        {
            PropriedadeModificada(RO_BASEICMSULTENTANT, value);
            _baseicmsultentant = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Baseicms2
    {
        get
        {
            PropriedadeAcessada(RO_BASEICMS2);
            return _baseicms2;
        }
        set
        {
            PropriedadeModificada(RO_BASEICMS2, value);
            _baseicms2 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Baseicst
    {
        get
        {
            PropriedadeAcessada(RO_BASEICST);
            return _baseicst;
        }
        set
        {
            PropriedadeModificada(RO_BASEICST, value);
            _baseicst = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Baseivamex
    {
        get
        {
            PropriedadeAcessada(RO_BASEIVAMEX);
            return _baseivamex;
        }
        set
        {
            PropriedadeModificada(RO_BASEIVAMEX, value);
            _baseivamex = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Basestsaida
    {
        get
        {
            PropriedadeAcessada(RO_BASESTSAIDA);
            return _basestsaida;
        }
        set
        {
            PropriedadeModificada(RO_BASESTSAIDA, value);
            _basestsaida = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Bciss
    {
        get
        {
            PropriedadeAcessada(RO_BCISS);
            return _bciss;
        }
        set
        {
            PropriedadeModificada(RO_BCISS, value);
            _bciss = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Brinde
    {
        get
        {
            PropriedadeAcessada(RO_BRINDE);
            return _brinde;
        }
        set
        {
            PropriedadeModificada(RO_BRINDE, value);
            _brinde = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Calccredipi
    {
        get
        {
            PropriedadeAcessada(RO_CALCCREDIPI);
            return _calccredipi;
        }
        set
        {
            PropriedadeModificada(RO_CALCCREDIPI, value);
            _calccredipi = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 0)]
    public decimal? Capvoldnf
    {
        get
        {
            PropriedadeAcessada(RO_CAPVOLDNF);
            return _capvoldnf;
        }
        set
        {
            PropriedadeModificada(RO_CAPVOLDNF, value);
            _capvoldnf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
    public string Classificfiscal
    {
        get
        {
            PropriedadeAcessada(RO_CLASSIFICFISCAL);
            return _classificfiscal;
        }
        set
        {
            PropriedadeModificada(RO_CLASSIFICFISCAL, value);
            _classificfiscal = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 20, Precisao = 0)]
    public decimal? Codauxiliar
    {
        get
        {
            PropriedadeAcessada(RO_CODAUXILIAR);
            return _codauxiliar;
        }
        set
        {
            PropriedadeModificada(RO_CODAUXILIAR, value);
            _codauxiliar = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
    public string Codbase
    {
        get
        {
            PropriedadeAcessada(RO_CODBASE);
            return _codbase;
        }
        set
        {
            PropriedadeModificada(RO_CODBASE, value);
            _codbase = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codcertific
    {
        get
        {
            PropriedadeAcessada(RO_CODCERTIFIC);
            return _codcertific;
        }
        set
        {
            PropriedadeModificada(RO_CODCERTIFIC, value);
            _codcertific = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Coddesconto
    {
        get
        {
            PropriedadeAcessada(RO_CODDESCONTO);
            return _coddesconto;
        }
        set
        {
            PropriedadeModificada(RO_CODDESCONTO, value);
            _coddesconto = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Coddevol
    {
        get
        {
            PropriedadeAcessada(RO_CODDEVOL);
            return _coddevol;
        }
        set
        {
            PropriedadeModificada(RO_CODDEVOL, value);
            _coddevol = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 4, Precisao = 0)]
    public string Codecf
    {
        get
        {
            PropriedadeAcessada(RO_CODECF);
            return _codecf;
        }
        set
        {
            PropriedadeModificada(RO_CODECF, value);
            _codecf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codepto
    {
        get
        {
            PropriedadeAcessada(RO_CODEPTO);
            return _codepto;
        }
        set
        {
            PropriedadeModificada(RO_CODEPTO, value);
            _codepto = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Codequipamento
    {
        get
        {
            PropriedadeAcessada(RO_CODEQUIPAMENTO);
            return _codequipamento;
        }
        set
        {
            PropriedadeModificada(RO_CODEQUIPAMENTO, value);
            _codequipamento = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Codfilialnf
    {
        get
        {
            PropriedadeAcessada(RO_CODFILIALNF);
            return _codfilialnf;
        }
        set
        {
            PropriedadeModificada(RO_CODFILIALNF, value);
            _codfilialnf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Codfilialretira
    {
        get
        {
            PropriedadeAcessada(RO_CODFILIALRETIRA);
            return _codfilialretira;
        }
        set
        {
            PropriedadeModificada(RO_CODFILIALRETIRA, value);
            _codfilialretira = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfiscal
    {
        get
        {
            PropriedadeAcessada(RO_CODFISCAL);
            return _codfiscal;
        }
        set
        {
            PropriedadeModificada(RO_CODFISCAL, value);
            _codfiscal = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Codfiscalfreteent
    {
        get
        {
            PropriedadeAcessada(RO_CODFISCALFRETEENT);
            return _codfiscalfreteent;
        }
        set
        {
            PropriedadeModificada(RO_CODFISCALFRETEENT, value);
            _codfiscalfreteent = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Codfiscaloutrasdespent
    {
        get
        {
            PropriedadeAcessada(RO_CODFISCALOUTRASDESPENT);
            return _codfiscaloutrasdespent;
        }
        set
        {
            PropriedadeModificada(RO_CODFISCALOUTRASDESPENT, value);
            _codfiscaloutrasdespent = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
    public string Codformula
    {
        get
        {
            PropriedadeAcessada(RO_CODFORMULA);
            return _codformula;
        }
        set
        {
            PropriedadeModificada(RO_CODFORMULA, value);
            _codformula = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codfornecprod
    {
        get
        {
            PropriedadeAcessada(RO_CODFORNECPROD);
            return _codfornecprod;
        }
        set
        {
            PropriedadeModificada(RO_CODFORNECPROD, value);
            _codfornecprod = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfuncconf
    {
        get
        {
            PropriedadeAcessada(RO_CODFUNCCONF);
            return _codfuncconf;
        }
        set
        {
            PropriedadeModificada(RO_CODFUNCCONF, value);
            _codfuncconf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfuncembal
    {
        get
        {
            PropriedadeAcessada(RO_CODFUNCEMBAL);
            return _codfuncembal;
        }
        set
        {
            PropriedadeModificada(RO_CODFUNCEMBAL, value);
            _codfuncembal = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfuncexportacaowms
    {
        get
        {
            PropriedadeAcessada(RO_CODFUNCEXPORTACAOWMS);
            return _codfuncexportacaowms;
        }
        set
        {
            PropriedadeModificada(RO_CODFUNCEXPORTACAOWMS, value);
            _codfuncexportacaowms = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfuncimportacaowms
    {
        get
        {
            PropriedadeAcessada(RO_CODFUNCIMPORTACAOWMS);
            return _codfuncimportacaowms;
        }
        set
        {
            PropriedadeModificada(RO_CODFUNCIMPORTACAOWMS, value);
            _codfuncimportacaowms = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfuncquarentena
    {
        get
        {
            PropriedadeAcessada(RO_CODFUNCQUARENTENA);
            return _codfuncquarentena;
        }
        set
        {
            PropriedadeModificada(RO_CODFUNCQUARENTENA, value);
            _codfuncquarentena = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfuncreq
    {
        get
        {
            PropriedadeAcessada(RO_CODFUNCREQ);
            return _codfuncreq;
        }
        set
        {
            PropriedadeModificada(RO_CODFUNCREQ, value);
            _codfuncreq = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codgenerofiscal
    {
        get
        {
            PropriedadeAcessada(RO_CODGENEROFISCAL);
            return _codgenerofiscal;
        }
        set
        {
            PropriedadeModificada(RO_CODGENEROFISCAL, value);
            _codgenerofiscal = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Codicmtab
    {
        get
        {
            PropriedadeAcessada(RO_CODICMTAB);
            return _codicmtab;
        }
        set
        {
            PropriedadeModificada(RO_CODICMTAB, value);
            _codicmtab = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codmotorista
    {
        get
        {
            PropriedadeAcessada(RO_CODMOTORISTA);
            return _codmotorista;
        }
        set
        {
            PropriedadeModificada(RO_CODMOTORISTA, value);
            _codmotorista = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Codoper
    {
        get
        {
            PropriedadeAcessada(RO_CODOPER);
            return _codoper;
        }
        set
        {
            PropriedadeModificada(RO_CODOPER, value);
            _codoper = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codpassefiscal
    {
        get
        {
            PropriedadeAcessada(RO_CODPASSEFISCAL);
            return _codpassefiscal;
        }
        set
        {
            PropriedadeModificada(RO_CODPASSEFISCAL, value);
            _codpassefiscal = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Codplpag
    {
        get
        {
            PropriedadeAcessada(RO_CODPLPAG);
            return _codplpag;
        }
        set
        {
            PropriedadeModificada(RO_CODPLPAG, value);
            _codplpag = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 3, Precisao = 0)]
    public decimal? Codproddnf
    {
        get
        {
            PropriedadeAcessada(RO_CODPRODDNF);
            return _codproddnf;
        }
        set
        {
            PropriedadeModificada(RO_CODPRODDNF, value);
            _codproddnf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codprodprinc
    {
        get
        {
            PropriedadeAcessada(RO_CODPRODPRINC);
            return _codprodprinc;
        }
        set
        {
            PropriedadeModificada(RO_CODPRODPRINC, value);
            _codprodprinc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Codprodrelev
    {
        get
        {
            PropriedadeAcessada(RO_CODPRODRELEV);
            return _codprodrelev;
        }
        set
        {
            PropriedadeModificada(RO_CODPRODRELEV, value);
            _codprodrelev = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
    public string Codprodsintegra
    {
        get
        {
            PropriedadeAcessada(RO_CODPRODSINTEGRA);
            return _codprodsintegra;
        }
        set
        {
            PropriedadeModificada(RO_CODPRODSINTEGRA, value);
            _codprodsintegra = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 10, Precisao = 0)]
    public string Codpromocao
    {
        get
        {
            PropriedadeAcessada(RO_CODPROMOCAO);
            return _codpromocao;
        }
        set
        {
            PropriedadeModificada(RO_CODPROMOCAO, value);
            _codpromocao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codsec
    {
        get
        {
            PropriedadeAcessada(RO_CODSEC);
            return _codsec;
        }
        set
        {
            PropriedadeModificada(RO_CODSEC, value);
            _codsec = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 3, Precisao = 0)]
    public decimal? Codsittribpiscofins
    {
        get
        {
            PropriedadeAcessada(RO_CODSITTRIBPISCOFINS);
            return _codsittribpiscofins;
        }
        set
        {
            PropriedadeModificada(RO_CODSITTRIBPISCOFINS, value);
            _codsittribpiscofins = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Codst
    {
        get
        {
            PropriedadeAcessada(RO_CODST);
            return _codst;
        }
        set
        {
            PropriedadeModificada(RO_CODST, value);
            _codst = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal Codusur
    {
        get
        {
            PropriedadeAcessada(RO_CODUSUR);
            return _codusur;
        }
        set
        {
            PropriedadeModificada(RO_CODUSUR, value);
            _codusur = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codvasilhame
    {
        get
        {
            PropriedadeAcessada(RO_CODVASILHAME);
            return _codvasilhame;
        }
        set
        {
            PropriedadeModificada(RO_CODVASILHAME, value);
            _codvasilhame = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
    public string Complemento
    {
        get
        {
            PropriedadeAcessada(RO_COMPLEMENTO);
            return _complemento;
        }
        set
        {
            PropriedadeModificada(RO_COMPLEMENTO, value);
            _complemento = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Compraconsignado
    {
        get
        {
            PropriedadeAcessada(RO_COMPRACONSIGNADO);
            return _compraconsignado;
        }
        set
        {
            PropriedadeModificada(RO_COMPRACONSIGNADO, value);
            _compraconsignado = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Controlanumserie
    {
        get
        {
            PropriedadeAcessada(RO_CONTROLANUMSERIE);
            return _controlanumserie;
        }
        set
        {
            PropriedadeModificada(RO_CONTROLANUMSERIE, value);
            _controlanumserie = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Custocont
    {
        get
        {
            PropriedadeAcessada(RO_CUSTOCONT);
            return _custocont;
        }
        set
        {
            PropriedadeModificada(RO_CUSTOCONT, value);
            _custocont = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Custocontant
    {
        get
        {
            PropriedadeAcessada(RO_CUSTOCONTANT);
            return _custocontant;
        }
        set
        {
            PropriedadeModificada(RO_CUSTOCONTANT, value);
            _custocontant = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Custofin
    {
        get
        {
            PropriedadeAcessada(RO_CUSTOFIN);
            return _custofin;
        }
        set
        {
            PropriedadeModificada(RO_CUSTOFIN, value);
            _custofin = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Custofinest
    {
        get
        {
            PropriedadeAcessada(RO_CUSTOFINEST);
            return _custofinest;
        }
        set
        {
            PropriedadeModificada(RO_CUSTOFINEST, value);
            _custofinest = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Custofornec
    {
        get
        {
            PropriedadeAcessada(RO_CUSTOFORNEC);
            return _custofornec;
        }
        set
        {
            PropriedadeModificada(RO_CUSTOFORNEC, value);
            _custofornec = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Custonfsemst
    {
        get
        {
            PropriedadeAcessada(RO_CUSTONFSEMST);
            return _custonfsemst;
        }
        set
        {
            PropriedadeModificada(RO_CUSTONFSEMST, value);
            _custonfsemst = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Custonfsemstant
    {
        get
        {
            PropriedadeAcessada(RO_CUSTONFSEMSTANT);
            return _custonfsemstant;
        }
        set
        {
            PropriedadeModificada(RO_CUSTONFSEMSTANT, value);
            _custonfsemstant = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Custoreal
    {
        get
        {
            PropriedadeAcessada(RO_CUSTOREAL);
            return _custoreal;
        }
        set
        {
            PropriedadeModificada(RO_CUSTOREAL, value);
            _custoreal = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Custorealsemst
    {
        get
        {
            PropriedadeAcessada(RO_CUSTOREALSEMST);
            return _custorealsemst;
        }
        set
        {
            PropriedadeModificada(RO_CUSTOREALSEMST, value);
            _custorealsemst = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Custorep
    {
        get
        {
            PropriedadeAcessada(RO_CUSTOREP);
            return _custorep;
        }
        set
        {
            PropriedadeModificada(RO_CUSTOREP, value);
            _custorep = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Custoultentant2
    {
        get
        {
            PropriedadeAcessada(RO_CUSTOULTENTANT2);
            return _custoultentant2;
        }
        set
        {
            PropriedadeModificada(RO_CUSTOULTENTANT2, value);
            _custoultentant2 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Custoultentfin
    {
        get
        {
            PropriedadeAcessada(RO_CUSTOULTENTFIN);
            return _custoultentfin;
        }
        set
        {
            PropriedadeModificada(RO_CUSTOULTENTFIN, value);
            _custoultentfin = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Custoultentfinant
    {
        get
        {
            PropriedadeAcessada(RO_CUSTOULTENTFINANT);
            return _custoultentfinant;
        }
        set
        {
            PropriedadeModificada(RO_CUSTOULTENTFINANT, value);
            _custoultentfinant = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Custoultentmed
    {
        get
        {
            PropriedadeAcessada(RO_CUSTOULTENTMED);
            return _custoultentmed;
        }
        set
        {
            PropriedadeModificada(RO_CUSTOULTENTMED, value);
            _custoultentmed = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Custoultentmedant
    {
        get
        {
            PropriedadeAcessada(RO_CUSTOULTENTMEDANT);
            return _custoultentmedant;
        }
        set
        {
            PropriedadeModificada(RO_CUSTOULTENTMEDANT, value);
            _custoultentmedant = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Datafabricacao
    {
        get
        {
            PropriedadeAcessada(RO_DATAFABRICACAO);
            return _datafabricacao;
        }
        set
        {
            PropriedadeModificada(RO_DATAFABRICACAO, value);
            _datafabricacao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Datalibquarentena
    {
        get
        {
            PropriedadeAcessada(RO_DATALIBQUARENTENA);
            return _datalibquarentena;
        }
        set
        {
            PropriedadeModificada(RO_DATALIBQUARENTENA, value);
            _datalibquarentena = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Datavalidade
    {
        get
        {
            PropriedadeAcessada(RO_DATAVALIDADE);
            return _datavalidade;
        }
        set
        {
            PropriedadeModificada(RO_DATAVALIDADE, value);
            _datavalidade = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
    public string Descricao
    {
        get
        {
            PropriedadeAcessada(RO_DESCRICAO);
            return _descricao;
        }
        set
        {
            PropriedadeModificada(RO_DESCRICAO, value);
            _descricao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 45, Precisao = 0)]
    public string Descricao1
    {
        get
        {
            PropriedadeAcessada(RO_DESCRICAO1);
            return _descricao1;
        }
        set
        {
            PropriedadeModificada(RO_DESCRICAO1, value);
            _descricao1 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtapuracao
    {
        get
        {
            PropriedadeAcessada(RO_DTAPURACAO);
            return _dtapuracao;
        }
        set
        {
            PropriedadeModificada(RO_DTAPURACAO, value);
            _dtapuracao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtcancel
    {
        get
        {
            PropriedadeAcessada(RO_DTCANCEL);
            return _dtcancel;
        }
        set
        {
            PropriedadeModificada(RO_DTCANCEL, value);
            _dtcancel = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtdenegada
    {
        get
        {
            PropriedadeAcessada(RO_DTDENEGADA);
            return _dtdenegada;
        }
        set
        {
            PropriedadeModificada(RO_DTDENEGADA, value);
            _dtdenegada = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtexportacaoservint
    {
        get
        {
            PropriedadeAcessada(RO_DTEXPORTACAOSERVINT);
            return _dtexportacaoservint;
        }
        set
        {
            PropriedadeModificada(RO_DTEXPORTACAOSERVINT, value);
            _dtexportacaoservint = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtexportacaowms
    {
        get
        {
            PropriedadeAcessada(RO_DTEXPORTACAOWMS);
            return _dtexportacaowms;
        }
        set
        {
            PropriedadeModificada(RO_DTEXPORTACAOWMS, value);
            _dtexportacaowms = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtfimconf
    {
        get
        {
            PropriedadeAcessada(RO_DTFIMCONF);
            return _dtfimconf;
        }
        set
        {
            PropriedadeModificada(RO_DTFIMCONF, value);
            _dtfimconf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtimportacaoservprinc
    {
        get
        {
            PropriedadeAcessada(RO_DTIMPORTACAOSERVPRINC);
            return _dtimportacaoservprinc;
        }
        set
        {
            PropriedadeModificada(RO_DTIMPORTACAOSERVPRINC, value);
            _dtimportacaoservprinc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtimportacaowms
    {
        get
        {
            PropriedadeAcessada(RO_DTIMPORTACAOWMS);
            return _dtimportacaowms;
        }
        set
        {
            PropriedadeModificada(RO_DTIMPORTACAOWMS, value);
            _dtimportacaowms = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtinicioconf
    {
        get
        {
            PropriedadeAcessada(RO_DTINICIOCONF);
            return _dtinicioconf;
        }
        set
        {
            PropriedadeModificada(RO_DTINICIOCONF, value);
            _dtinicioconf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime Dtmov
    {
        get
        {
            PropriedadeAcessada(RO_DTMOV);
            return _dtmov;
        }
        set
        {
            PropriedadeModificada(RO_DTMOV, value);
            _dtmov = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtmovlog
    {
        get
        {
            PropriedadeAcessada(RO_DTMOVLOG);
            return _dtmovlog;
        }
        set
        {
            PropriedadeModificada(RO_DTMOVLOG, value);
            _dtmovlog = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtultentant
    {
        get
        {
            PropriedadeAcessada(RO_DTULTENTANT);
            return _dtultentant;
        }
        set
        {
            PropriedadeModificada(RO_DTULTENTANT, value);
            _dtultentant = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtwms
    {
        get
        {
            PropriedadeAcessada(RO_DTWMS);
            return _dtwms;
        }
        set
        {
            PropriedadeModificada(RO_DTWMS, value);
            _dtwms = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 1, Precisao = 0)]
    public decimal? Dv
    {
        get
        {
            PropriedadeAcessada(RO_DV);
            return _dv;
        }
        set
        {
            PropriedadeModificada(RO_DV, value);
            _dv = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 12, Precisao = 0)]
    public string Embalagem
    {
        get
        {
            PropriedadeAcessada(RO_EMBALAGEM);
            return _embalagem;
        }
        set
        {
            PropriedadeModificada(RO_EMBALAGEM, value);
            _embalagem = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 64, Precisao = 0)]
    public string Equiplanc
    {
        get
        {
            PropriedadeAcessada(RO_EQUIPLANC);
            return _equiplanc;
        }
        set
        {
            PropriedadeModificada(RO_EQUIPLANC, value);
            _equiplanc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Estoquedesbloqueado
    {
        get
        {
            PropriedadeAcessada(RO_ESTOQUEDESBLOQUEADO);
            return _estoquedesbloqueado;
        }
        set
        {
            PropriedadeModificada(RO_ESTOQUEDESBLOQUEADO, value);
            _estoquedesbloqueado = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Exportadoservint
    {
        get
        {
            PropriedadeAcessada(RO_EXPORTADOSERVINT);
            return _exportadoservint;
        }
        set
        {
            PropriedadeModificada(RO_EXPORTADOSERVINT, value);
            _exportadoservint = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Fatorconvdnf
    {
        get
        {
            PropriedadeAcessada(RO_FATORCONVDNF);
            return _fatorconvdnf;
        }
        set
        {
            PropriedadeModificada(RO_FATORCONVDNF, value);
            _fatorconvdnf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Fatorcustonatransf
    {
        get
        {
            PropriedadeAcessada(RO_FATORCUSTONATRANSF);
            return _fatorcustonatransf;
        }
        set
        {
            PropriedadeModificada(RO_FATORCUSTONATRANSF, value);
            _fatorcustonatransf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 30, Precisao = 0)]
    public string Funclanc
    {
        get
        {
            PropriedadeAcessada(RO_FUNCLANC);
            return _funclanc;
        }
        set
        {
            PropriedadeModificada(RO_FUNCLANC, value);
            _funclanc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Fundapiano
    {
        get
        {
            PropriedadeAcessada(RO_FUNDAPIANO);
            return _fundapiano;
        }
        set
        {
            PropriedadeModificada(RO_FUNDAPIANO, value);
            _fundapiano = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Geragnre_Cnpjcliente
    {
        get
        {
            PropriedadeAcessada(RO_GERAGNRE_CNPJCLIENTE);
            return _geragnre_cnpjcliente;
        }
        set
        {
            PropriedadeModificada(RO_GERAGNRE_CNPJCLIENTE, value);
            _geragnre_cnpjcliente = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Geraicmslivrofiscal
    {
        get
        {
            PropriedadeAcessada(RO_GERAICMSLIVROFISCAL);
            return _geraicmslivrofiscal;
        }
        set
        {
            PropriedadeModificada(RO_GERAICMSLIVROFISCAL, value);
            _geraicmslivrofiscal = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Horalanc
    {
        get
        {
            PropriedadeAcessada(RO_HORALANC);
            return _horalanc;
        }
        set
        {
            PropriedadeModificada(RO_HORALANC, value);
            _horalanc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Horaproducao
    {
        get
        {
            PropriedadeAcessada(RO_HORAPRODUCAO);
            return _horaproducao;
        }
        set
        {
            PropriedadeModificada(RO_HORAPRODUCAO, value);
            _horaproducao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 2)]
    public decimal? Icmsressarc
    {
        get
        {
            PropriedadeAcessada(RO_ICMSRESSARC);
            return _icmsressarc;
        }
        set
        {
            PropriedadeModificada(RO_ICMSRESSARC, value);
            _icmsressarc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Importado
    {
        get
        {
            PropriedadeAcessada(RO_IMPORTADO);
            return _importado;
        }
        set
        {
            PropriedadeModificada(RO_IMPORTADO, value);
            _importado = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Importadoservprinc
    {
        get
        {
            PropriedadeAcessada(RO_IMPORTADOSERVPRINC);
            return _importadoservprinc;
        }
        set
        {
            PropriedadeModificada(RO_IMPORTADOSERVPRINC, value);
            _importadoservprinc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Indlocal
    {
        get
        {
            PropriedadeAcessada(RO_INDLOCAL);
            return _indlocal;
        }
        set
        {
            PropriedadeModificada(RO_INDLOCAL, value);
            _indlocal = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Issretido
    {
        get
        {
            PropriedadeAcessada(RO_ISSRETIDO);
            return _issretido;
        }
        set
        {
            PropriedadeModificada(RO_ISSRETIDO, value);
            _issretido = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Itemdivergente
    {
        get
        {
            PropriedadeAcessada(RO_ITEMDIVERGENTE);
            return _itemdivergente;
        }
        set
        {
            PropriedadeModificada(RO_ITEMDIVERGENTE, value);
            _itemdivergente = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Iva
    {
        get
        {
            PropriedadeAcessada(RO_IVA);
            return _iva;
        }
        set
        {
            PropriedadeModificada(RO_IVA, value);
            _iva = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 2)]
    public decimal? Ivaressarc
    {
        get
        {
            PropriedadeAcessada(RO_IVARESSARC);
            return _ivaressarc;
        }
        set
        {
            PropriedadeModificada(RO_IVARESSARC, value);
            _ivaressarc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Ivatribut
    {
        get
        {
            PropriedadeAcessada(RO_IVATRIBUT);
            return _ivatribut;
        }
        set
        {
            PropriedadeModificada(RO_IVATRIBUT, value);
            _ivatribut = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
    public string Localizacao
    {
        get
        {
            PropriedadeAcessada(RO_LOCALIZACAO);
            return _localizacao;
        }
        set
        {
            PropriedadeModificada(RO_LOCALIZACAO, value);
            _localizacao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Minutolanc
    {
        get
        {
            PropriedadeAcessada(RO_MINUTOLANC);
            return _minutolanc;
        }
        set
        {
            PropriedadeModificada(RO_MINUTOLANC, value);
            _minutolanc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Movimentacontacorrenterca
    {
        get
        {
            PropriedadeAcessada(RO_MOVIMENTACONTACORRENTERCA);
            return _movimentacontacorrenterca;
        }
        set
        {
            PropriedadeModificada(RO_MOVIMENTACONTACORRENTERCA, value);
            _movimentacontacorrenterca = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 15, Precisao = 0)]
    public string Nbm
    {
        get
        {
            PropriedadeAcessada(RO_NBM);
            return _nbm;
        }
        set
        {
            PropriedadeModificada(RO_NBM, value);
            _nbm = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 3, Precisao = 0)]
    public decimal? Numadicao
    {
        get
        {
            PropriedadeAcessada(RO_NUMADICAO);
            return _numadicao;
        }
        set
        {
            PropriedadeModificada(RO_NUMADICAO, value);
            _numadicao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Numbono
    {
        get
        {
            PropriedadeAcessada(RO_NUMBONO);
            return _numbono;
        }
        set
        {
            PropriedadeModificada(RO_NUMBONO, value);
            _numbono = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numbonus
    {
        get
        {
            PropriedadeAcessada(RO_NUMBONUS);
            return _numbonus;
        }
        set
        {
            PropriedadeModificada(RO_NUMBONUS, value);
            _numbonus = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Numcar
    {
        get
        {
            PropriedadeAcessada(RO_NUMCAR);
            return _numcar;
        }
        set
        {
            PropriedadeModificada(RO_NUMCAR, value);
            _numcar = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Numcaranterior
    {
        get
        {
            PropriedadeAcessada(RO_NUMCARANTERIOR);
            return _numcaranterior;
        }
        set
        {
            PropriedadeModificada(RO_NUMCARANTERIOR, value);
            _numcaranterior = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numformulario
    {
        get
        {
            PropriedadeAcessada(RO_NUMFORMULARIO);
            return _numformulario;
        }
        set
        {
            PropriedadeModificada(RO_NUMFORMULARIO, value);
            _numformulario = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numformulario2
    {
        get
        {
            PropriedadeAcessada(RO_NUMFORMULARIO2);
            return _numformulario2;
        }
        set
        {
            PropriedadeModificada(RO_NUMFORMULARIO2, value);
            _numformulario2 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 30, Precisao = 0)]
    public string Numidf
    {
        get
        {
            PropriedadeAcessada(RO_NUMIDF);
            return _numidf;
        }
        set
        {
            PropriedadeModificada(RO_NUMIDF, value);
            _numidf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Numlanccp
    {
        get
        {
            PropriedadeAcessada(RO_NUMLANCCP);
            return _numlanccp;
        }
        set
        {
            PropriedadeModificada(RO_NUMLANCCP, value);
            _numlanccp = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Numlista
    {
        get
        {
            PropriedadeAcessada(RO_NUMLISTA);
            return _numlista;
        }
        set
        {
            PropriedadeModificada(RO_NUMLISTA, value);
            _numlista = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 15, Precisao = 0)]
    public string Numlote
    {
        get
        {
            PropriedadeAcessada(RO_NUMLOTE);
            return _numlote;
        }
        set
        {
            PropriedadeModificada(RO_NUMLOTE, value);
            _numlote = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
    public string Numlotefab
    {
        get
        {
            PropriedadeAcessada(RO_NUMLOTEFAB);
            return _numlotefab;
        }
        set
        {
            PropriedadeModificada(RO_NUMLOTEFAB, value);
            _numlotefab = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Numnegociacao
    {
        get
        {
            PropriedadeAcessada(RO_NUMNEGOCIACAO);
            return _numnegociacao;
        }
        set
        {
            PropriedadeModificada(RO_NUMNEGOCIACAO, value);
            _numnegociacao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal Numnota
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numnotadev
    {
        get
        {
            PropriedadeAcessada(RO_NUMNOTADEV);
            return _numnotadev;
        }
        set
        {
            PropriedadeModificada(RO_NUMNOTADEV, value);
            _numnotadev = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Numop
    {
        get
        {
            PropriedadeAcessada(RO_NUMOP);
            return _numop;
        }
        set
        {
            PropriedadeModificada(RO_NUMOP, value);
            _numop = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Numregiao
    {
        get
        {
            PropriedadeAcessada(RO_NUMREGIAO);
            return _numregiao;
        }
        set
        {
            PropriedadeModificada(RO_NUMREGIAO, value);
            _numregiao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 20, Precisao = 0)]
    public decimal? Numseq
    {
        get
        {
            PropriedadeAcessada(RO_NUMSEQ);
            return _numseq;
        }
        set
        {
            PropriedadeModificada(RO_NUMSEQ, value);
            _numseq = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 3, Precisao = 0)]
    public decimal? Numseqadicao
    {
        get
        {
            PropriedadeAcessada(RO_NUMSEQADICAO);
            return _numseqadicao;
        }
        set
        {
            PropriedadeModificada(RO_NUMSEQADICAO, value);
            _numseqadicao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Numseqped
    {
        get
        {
            PropriedadeAcessada(RO_NUMSEQPED);
            return _numseqped;
        }
        set
        {
            PropriedadeModificada(RO_NUMSEQPED, value);
            _numseqped = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numtransavulsa
    {
        get
        {
            PropriedadeAcessada(RO_NUMTRANSAVULSA);
            return _numtransavulsa;
        }
        set
        {
            PropriedadeModificada(RO_NUMTRANSAVULSA, value);
            _numtransavulsa = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numtransdev
    {
        get
        {
            PropriedadeAcessada(RO_NUMTRANSDEV);
            return _numtransdev;
        }
        set
        {
            PropriedadeModificada(RO_NUMTRANSDEV, value);
            _numtransdev = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numtransdevfor
    {
        get
        {
            PropriedadeAcessada(RO_NUMTRANSDEVFOR);
            return _numtransdevfor;
        }
        set
        {
            PropriedadeModificada(RO_NUMTRANSDEVFOR, value);
            _numtransdevfor = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numtransent
    {
        get
        {
            PropriedadeAcessada(RO_NUMTRANSENT);
            return _numtransent;
        }
        set
        {
            PropriedadeModificada(RO_NUMTRANSENT, value);
            _numtransent = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numtransentultent
    {
        get
        {
            PropriedadeAcessada(RO_NUMTRANSENTULTENT);
            return _numtransentultent;
        }
        set
        {
            PropriedadeModificada(RO_NUMTRANSENTULTENT, value);
            _numtransentultent = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numtransentultentant
    {
        get
        {
            PropriedadeAcessada(RO_NUMTRANSENTULTENTANT);
            return _numtransentultentant;
        }
        set
        {
            PropriedadeModificada(RO_NUMTRANSENTULTENTANT, value);
            _numtransentultentant = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 0)]
    public decimal? Numtransitem
    {
        get
        {
            PropriedadeAcessada(RO_NUMTRANSITEM);
            return _numtransitem;
        }
        set
        {
            PropriedadeModificada(RO_NUMTRANSITEM, value);
            _numtransitem = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numtransop
    {
        get
        {
            PropriedadeAcessada(RO_NUMTRANSOP);
            return _numtransop;
        }
        set
        {
            PropriedadeModificada(RO_NUMTRANSOP, value);
            _numtransop = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Numverbaoutras
    {
        get
        {
            PropriedadeAcessada(RO_NUMVERBAOUTRAS);
            return _numverbaoutras;
        }
        set
        {
            PropriedadeModificada(RO_NUMVERBAOUTRAS, value);
            _numverbaoutras = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Numverbarebcmv
    {
        get
        {
            PropriedadeAcessada(RO_NUMVERBAREBCMV);
            return _numverbarebcmv;
        }
        set
        {
            PropriedadeModificada(RO_NUMVERBAREBCMV, value);
            _numverbarebcmv = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Numvolumesconferencia
    {
        get
        {
            PropriedadeAcessada(RO_NUMVOLUMESCONFERENCIA);
            return _numvolumesconferencia;
        }
        set
        {
            PropriedadeModificada(RO_NUMVOLUMESCONFERENCIA, value);
            _numvolumesconferencia = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Pagtognrenomedoremetente
    {
        get
        {
            PropriedadeAcessada(RO_PAGTOGNRENOMEDOREMETENTE);
            return _pagtognrenomedoremetente;
        }
        set
        {
            PropriedadeModificada(RO_PAGTOGNRENOMEDOREMETENTE, value);
            _pagtognrenomedoremetente = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Passelivre
    {
        get
        {
            PropriedadeAcessada(RO_PASSELIVRE);
            return _passelivre;
        }
        set
        {
            PropriedadeModificada(RO_PASSELIVRE, value);
            _passelivre = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Pauta
    {
        get
        {
            PropriedadeAcessada(RO_PAUTA);
            return _pauta;
        }
        set
        {
            PropriedadeModificada(RO_PAUTA, value);
            _pauta = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Pbaserca
    {
        get
        {
            PropriedadeAcessada(RO_PBASERCA);
            return _pbaserca;
        }
        set
        {
            PropriedadeModificada(RO_PBASERCA, value);
            _pbaserca = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Pbonific
    {
        get
        {
            PropriedadeAcessada(RO_PBONIFIC);
            return _pbonific;
        }
        set
        {
            PropriedadeModificada(RO_PBONIFIC, value);
            _pbonific = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Peracrescimocusto
    {
        get
        {
            PropriedadeAcessada(RO_PERACRESCIMOCUSTO);
            return _peracrescimocusto;
        }
        set
        {
            PropriedadeModificada(RO_PERACRESCIMOCUSTO, value);
            _peracrescimocusto = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Peracrescimopf
    {
        get
        {
            PropriedadeAcessada(RO_PERACRESCIMOPF);
            return _peracrescimopf;
        }
        set
        {
            PropriedadeModificada(RO_PERACRESCIMOPF, value);
            _peracrescimopf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Perbonific
    {
        get
        {
            PropriedadeAcessada(RO_PERBONIFIC);
            return _perbonific;
        }
        set
        {
            PropriedadeModificada(RO_PERBONIFIC, value);
            _perbonific = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Percagregadorst
    {
        get
        {
            PropriedadeAcessada(RO_PERCAGREGADORST);
            return _percagregadorst;
        }
        set
        {
            PropriedadeModificada(RO_PERCAGREGADORST, value);
            _percagregadorst = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Percaliqextguia
    {
        get
        {
            PropriedadeAcessada(RO_PERCALIQEXTGUIA);
            return _percaliqextguia;
        }
        set
        {
            PropriedadeModificada(RO_PERCALIQEXTGUIA, value);
            _percaliqextguia = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Percaliqexticmantecip
    {
        get
        {
            PropriedadeAcessada(RO_PERCALIQEXTICMANTECIP);
            return _percaliqexticmantecip;
        }
        set
        {
            PropriedadeModificada(RO_PERCALIQEXTICMANTECIP, value);
            _percaliqexticmantecip = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Percaliqext2
    {
        get
        {
            PropriedadeAcessada(RO_PERCALIQEXT2);
            return _percaliqext2;
        }
        set
        {
            PropriedadeModificada(RO_PERCALIQEXT2, value);
            _percaliqext2 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Percaliqinticmantecip
    {
        get
        {
            PropriedadeAcessada(RO_PERCALIQINTICMANTECIP);
            return _percaliqinticmantecip;
        }
        set
        {
            PropriedadeModificada(RO_PERCALIQINTICMANTECIP, value);
            _percaliqinticmantecip = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Percaliqint2
    {
        get
        {
            PropriedadeAcessada(RO_PERCALIQINT2);
            return _percaliqint2;
        }
        set
        {
            PropriedadeModificada(RO_PERCALIQINT2, value);
            _percaliqint2 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Percbasered
    {
        get
        {
            PropriedadeAcessada(RO_PERCBASERED);
            return _percbasered;
        }
        set
        {
            PropriedadeModificada(RO_PERCBASERED, value);
            _percbasered = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Percbaseredadicional
    {
        get
        {
            PropriedadeAcessada(RO_PERCBASEREDADICIONAL);
            return _percbaseredadicional;
        }
        set
        {
            PropriedadeModificada(RO_PERCBASEREDADICIONAL, value);
            _percbaseredadicional = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Percbaseredst
    {
        get
        {
            PropriedadeAcessada(RO_PERCBASEREDST);
            return _percbaseredst;
        }
        set
        {
            PropriedadeModificada(RO_PERCBASEREDST, value);
            _percbaseredst = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Percbaseredstfonte
    {
        get
        {
            PropriedadeAcessada(RO_PERCBASEREDSTFONTE);
            return _percbaseredstfonte;
        }
        set
        {
            PropriedadeModificada(RO_PERCBASEREDSTFONTE, value);
            _percbaseredstfonte = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Percbon
    {
        get
        {
            PropriedadeAcessada(RO_PERCBON);
            return _percbon;
        }
        set
        {
            PropriedadeModificada(RO_PERCBON, value);
            _percbon = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 2)]
    public decimal? Percbonoutras
    {
        get
        {
            PropriedadeAcessada(RO_PERCBONOUTRAS);
            return _percbonoutras;
        }
        set
        {
            PropriedadeModificada(RO_PERCBONOUTRAS, value);
            _percbonoutras = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Perccredicmpresumido
    {
        get
        {
            PropriedadeAcessada(RO_PERCCREDICMPRESUMIDO);
            return _perccredicmpresumido;
        }
        set
        {
            PropriedadeModificada(RO_PERCCREDICMPRESUMIDO, value);
            _perccredicmpresumido = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Percdesc
    {
        get
        {
            PropriedadeAcessada(RO_PERCDESC);
            return _percdesc;
        }
        set
        {
            PropriedadeModificada(RO_PERCDESC, value);
            _percdesc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Percdesccofins
    {
        get
        {
            PropriedadeAcessada(RO_PERCDESCCOFINS);
            return _percdesccofins;
        }
        set
        {
            PropriedadeModificada(RO_PERCDESCCOFINS, value);
            _percdesccofins = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Percdescfin
    {
        get
        {
            PropriedadeAcessada(RO_PERCDESCFIN);
            return _percdescfin;
        }
        set
        {
            PropriedadeModificada(RO_PERCDESCFIN, value);
            _percdescfin = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Percdescicmsdif
    {
        get
        {
            PropriedadeAcessada(RO_PERCDESCICMSDIF);
            return _percdescicmsdif;
        }
        set
        {
            PropriedadeModificada(RO_PERCDESCICMSDIF, value);
            _percdescicmsdif = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Percdescpis
    {
        get
        {
            PropriedadeAcessada(RO_PERCDESCPIS);
            return _percdescpis;
        }
        set
        {
            PropriedadeModificada(RO_PERCDESCPIS, value);
            _percdescpis = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Percdespadicional
    {
        get
        {
            PropriedadeAcessada(RO_PERCDESPADICIONAL);
            return _percdespadicional;
        }
        set
        {
            PropriedadeModificada(RO_PERCDESPADICIONAL, value);
            _percdespadicional = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Percdespdentronf
    {
        get
        {
            PropriedadeAcessada(RO_PERCDESPDENTRONF);
            return _percdespdentronf;
        }
        set
        {
            PropriedadeModificada(RO_PERCDESPDENTRONF, value);
            _percdespdentronf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Percdespfin
    {
        get
        {
            PropriedadeAcessada(RO_PERCDESPFIN);
            return _percdespfin;
        }
        set
        {
            PropriedadeModificada(RO_PERCDESPFIN, value);
            _percdespfin = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Percdespforanf
    {
        get
        {
            PropriedadeAcessada(RO_PERCDESPFORANF);
            return _percdespforanf;
        }
        set
        {
            PropriedadeModificada(RO_PERCDESPFORANF, value);
            _percdespforanf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Percdifaliquotas
    {
        get
        {
            PropriedadeAcessada(RO_PERCDIFALIQUOTAS);
            return _percdifaliquotas;
        }
        set
        {
            PropriedadeModificada(RO_PERCDIFALIQUOTAS, value);
            _percdifaliquotas = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Percdireitosaduaneiros
    {
        get
        {
            PropriedadeAcessada(RO_PERCDIREITOSADUANEIROS);
            return _percdireitosaduaneiros;
        }
        set
        {
            PropriedadeModificada(RO_PERCDIREITOSADUANEIROS, value);
            _percdireitosaduaneiros = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Percfrete
    {
        get
        {
            PropriedadeAcessada(RO_PERCFRETE);
            return _percfrete;
        }
        set
        {
            PropriedadeModificada(RO_PERCFRETE, value);
            _percfrete = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Percfretefob
    {
        get
        {
            PropriedadeAcessada(RO_PERCFRETEFOB);
            return _percfretefob;
        }
        set
        {
            PropriedadeModificada(RO_PERCFRETEFOB, value);
            _percfretefob = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 2)]
    public decimal? Percicm
    {
        get
        {
            PropriedadeAcessada(RO_PERCICM);
            return _percicm;
        }
        set
        {
            PropriedadeModificada(RO_PERCICM, value);
            _percicm = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 2)]
    public decimal? Percicmcp
    {
        get
        {
            PropriedadeAcessada(RO_PERCICMCP);
            return _percicmcp;
        }
        set
        {
            PropriedadeModificada(RO_PERCICMCP, value);
            _percicmcp = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 2)]
    public decimal? Percicmop
    {
        get
        {
            PropriedadeAcessada(RO_PERCICMOP);
            return _percicmop;
        }
        set
        {
            PropriedadeModificada(RO_PERCICMOP, value);
            _percicmop = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 2)]
    public decimal? Percicmoriginal
    {
        get
        {
            PropriedadeAcessada(RO_PERCICMORIGINAL);
            return _percicmoriginal;
        }
        set
        {
            PropriedadeModificada(RO_PERCICMORIGINAL, value);
            _percicmoriginal = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Percicmred
    {
        get
        {
            PropriedadeAcessada(RO_PERCICMRED);
            return _percicmred;
        }
        set
        {
            PropriedadeModificada(RO_PERCICMRED, value);
            _percicmred = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Percicmsdiferido
    {
        get
        {
            PropriedadeAcessada(RO_PERCICMSDIFERIDO);
            return _percicmsdiferido;
        }
        set
        {
            PropriedadeModificada(RO_PERCICMSDIFERIDO, value);
            _percicmsdiferido = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Percicmsfretefobst
    {
        get
        {
            PropriedadeAcessada(RO_PERCICMSFRETEFOBST);
            return _percicmsfretefobst;
        }
        set
        {
            PropriedadeModificada(RO_PERCICMSFRETEFOBST, value);
            _percicmsfretefobst = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 2)]
    public decimal? Percicm2
    {
        get
        {
            PropriedadeAcessada(RO_PERCICM2);
            return _percicm2;
        }
        set
        {
            PropriedadeModificada(RO_PERCICM2, value);
            _percicm2 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Perciisuspenso
    {
        get
        {
            PropriedadeAcessada(RO_PERCIISUSPENSO);
            return _perciisuspenso;
        }
        set
        {
            PropriedadeModificada(RO_PERCIISUSPENSO, value);
            _perciisuspenso = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 2)]
    public decimal? Percimportacao
    {
        get
        {
            PropriedadeAcessada(RO_PERCIMPORTACAO);
            return _percimportacao;
        }
        set
        {
            PropriedadeModificada(RO_PERCIMPORTACAO, value);
            _percimportacao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Percimpostoconsumo
    {
        get
        {
            PropriedadeAcessada(RO_PERCIMPOSTOCONSUMO);
            return _percimpostoconsumo;
        }
        set
        {
            PropriedadeModificada(RO_PERCIMPOSTOCONSUMO, value);
            _percimpostoconsumo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Percimpostoselo
    {
        get
        {
            PropriedadeAcessada(RO_PERCIMPOSTOSELO);
            return _percimpostoselo;
        }
        set
        {
            PropriedadeModificada(RO_PERCIMPOSTOSELO, value);
            _percimpostoselo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 2)]
    public decimal? Percimpprodutorural
    {
        get
        {
            PropriedadeAcessada(RO_PERCIMPPRODUTORURAL);
            return _percimpprodutorural;
        }
        set
        {
            PropriedadeModificada(RO_PERCIMPPRODUTORURAL, value);
            _percimpprodutorural = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 3)]
    public decimal? Percimpureza
    {
        get
        {
            PropriedadeAcessada(RO_PERCIMPUREZA);
            return _percimpureza;
        }
        set
        {
            PropriedadeModificada(RO_PERCIMPUREZA, value);
            _percimpureza = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Percinss
    {
        get
        {
            PropriedadeAcessada(RO_PERCINSS);
            return _percinss;
        }
        set
        {
            PropriedadeModificada(RO_PERCINSS, value);
            _percinss = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 3)]
    public decimal? Percinteiro
    {
        get
        {
            PropriedadeAcessada(RO_PERCINTEIRO);
            return _percinteiro;
        }
        set
        {
            PropriedadeModificada(RO_PERCINTEIRO, value);
            _percinteiro = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Percipi
    {
        get
        {
            PropriedadeAcessada(RO_PERCIPI);
            return _percipi;
        }
        set
        {
            PropriedadeModificada(RO_PERCIPI, value);
            _percipi = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Perciss
    {
        get
        {
            PropriedadeAcessada(RO_PERCISS);
            return _perciss;
        }
        set
        {
            PropriedadeModificada(RO_PERCISS, value);
            _perciss = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Perciva
    {
        get
        {
            PropriedadeAcessada(RO_PERCIVA);
            return _perciva;
        }
        set
        {
            PropriedadeModificada(RO_PERCIVA, value);
            _perciva = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Percivaicmantecip
    {
        get
        {
            PropriedadeAcessada(RO_PERCIVAICMANTECIP);
            return _percivaicmantecip;
        }
        set
        {
            PropriedadeModificada(RO_PERCIVAICMANTECIP, value);
            _percivaicmantecip = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Percivamex
    {
        get
        {
            PropriedadeAcessada(RO_PERCIVAMEX);
            return _percivamex;
        }
        set
        {
            PropriedadeModificada(RO_PERCIVAMEX, value);
            _percivamex = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Perciva2
    {
        get
        {
            PropriedadeAcessada(RO_PERCIVA2);
            return _perciva2;
        }
        set
        {
            PropriedadeModificada(RO_PERCIVA2, value);
            _perciva2 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 6)]
    public decimal? Percmexfpgc
    {
        get
        {
            PropriedadeAcessada(RO_PERCMEXFPGC);
            return _percmexfpgc;
        }
        set
        {
            PropriedadeModificada(RO_PERCMEXFPGC, value);
            _percmexfpgc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 6)]
    public decimal? Percmexieps
    {
        get
        {
            PropriedadeAcessada(RO_PERCMEXIEPS);
            return _percmexieps;
        }
        set
        {
            PropriedadeModificada(RO_PERCMEXIEPS, value);
            _percmexieps = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 6)]
    public decimal? Percmexiva
    {
        get
        {
            PropriedadeAcessada(RO_PERCMEXIVA);
            return _percmexiva;
        }
        set
        {
            PropriedadeModificada(RO_PERCMEXIVA, value);
            _percmexiva = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Percofins
    {
        get
        {
            PropriedadeAcessada(RO_PERCOFINS);
            return _percofins;
        }
        set
        {
            PropriedadeModificada(RO_PERCOFINS, value);
            _percofins = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Percom
    {
        get
        {
            PropriedadeAcessada(RO_PERCOM);
            return _percom;
        }
        set
        {
            PropriedadeModificada(RO_PERCOM, value);
            _percom = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Percomfilialbroker
    {
        get
        {
            PropriedadeAcessada(RO_PERCOMFILIALBROKER);
            return _percomfilialbroker;
        }
        set
        {
            PropriedadeModificada(RO_PERCOMFILIALBROKER, value);
            _percomfilialbroker = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Percommot
    {
        get
        {
            PropriedadeAcessada(RO_PERCOMMOT);
            return _percommot;
        }
        set
        {
            PropriedadeModificada(RO_PERCOMMOT, value);
            _percommot = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Percomsup
    {
        get
        {
            PropriedadeAcessada(RO_PERCOMSUP);
            return _percomsup;
        }
        set
        {
            PropriedadeModificada(RO_PERCOMSUP, value);
            _percomsup = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Percom2
    {
        get
        {
            PropriedadeAcessada(RO_PERCOM2);
            return _percom2;
        }
        set
        {
            PropriedadeModificada(RO_PERCOM2, value);
            _percom2 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Percom3
    {
        get
        {
            PropriedadeAcessada(RO_PERCOM3);
            return _percom3;
        }
        set
        {
            PropriedadeModificada(RO_PERCOM3, value);
            _percom3 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Percom4
    {
        get
        {
            PropriedadeAcessada(RO_PERCOM4);
            return _percom4;
        }
        set
        {
            PropriedadeModificada(RO_PERCOM4, value);
            _percom4 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Percoutrasdesp
    {
        get
        {
            PropriedadeAcessada(RO_PERCOUTRASDESP);
            return _percoutrasdesp;
        }
        set
        {
            PropriedadeModificada(RO_PERCOUTRASDESP, value);
            _percoutrasdesp = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Percoutroscustos
    {
        get
        {
            PropriedadeAcessada(RO_PERCOUTROSCUSTOS);
            return _percoutroscustos;
        }
        set
        {
            PropriedadeModificada(RO_PERCOUTROSCUSTOS, value);
            _percoutroscustos = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 3)]
    public decimal? Percquebrado
    {
        get
        {
            PropriedadeAcessada(RO_PERCQUEBRADO);
            return _percquebrado;
        }
        set
        {
            PropriedadeModificada(RO_PERCQUEBRADO, value);
            _percquebrado = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 2)]
    public decimal? Percredicms
    {
        get
        {
            PropriedadeAcessada(RO_PERCREDICMS);
            return _percredicms;
        }
        set
        {
            PropriedadeModificada(RO_PERCREDICMS, value);
            _percredicms = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Percseguro
    {
        get
        {
            PropriedadeAcessada(RO_PERCSEGURO);
            return _percseguro;
        }
        set
        {
            PropriedadeModificada(RO_PERCSEGURO, value);
            _percseguro = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Percst
    {
        get
        {
            PropriedadeAcessada(RO_PERCST);
            return _percst;
        }
        set
        {
            PropriedadeModificada(RO_PERCST, value);
            _percst = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Percsuframa
    {
        get
        {
            PropriedadeAcessada(RO_PERCSUFRAMA);
            return _percsuframa;
        }
        set
        {
            PropriedadeModificada(RO_PERCSUFRAMA, value);
            _percsuframa = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 3)]
    public decimal? Percumidade
    {
        get
        {
            PropriedadeAcessada(RO_PERCUMIDADE);
            return _percumidade;
        }
        set
        {
            PropriedadeModificada(RO_PERCUMIDADE, value);
            _percumidade = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 2)]
    public decimal? Percvenda
    {
        get
        {
            PropriedadeAcessada(RO_PERCVENDA);
            return _percvenda;
        }
        set
        {
            PropriedadeModificada(RO_PERCVENDA, value);
            _percvenda = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 3)]
    public decimal? Percvermelho
    {
        get
        {
            PropriedadeAcessada(RO_PERCVERMELHO);
            return _percvermelho;
        }
        set
        {
            PropriedadeModificada(RO_PERCVERMELHO, value);
            _percvermelho = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Percvlbonific
    {
        get
        {
            PropriedadeAcessada(RO_PERCVLBONIFIC);
            return _percvlbonific;
        }
        set
        {
            PropriedadeModificada(RO_PERCVLBONIFIC, value);
            _percvlbonific = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Perdesccom
    {
        get
        {
            PropriedadeAcessada(RO_PERDESCCOM);
            return _perdesccom;
        }
        set
        {
            PropriedadeModificada(RO_PERDESCCOM, value);
            _perdesccom = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Perdesccusto
    {
        get
        {
            PropriedadeAcessada(RO_PERDESCCUSTO);
            return _perdesccusto;
        }
        set
        {
            PropriedadeModificada(RO_PERDESCCUSTO, value);
            _perdesccusto = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Perdescfin
    {
        get
        {
            PropriedadeAcessada(RO_PERDESCFIN);
            return _perdescfin;
        }
        set
        {
            PropriedadeModificada(RO_PERDESCFIN, value);
            _perdescfin = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Perdescflex
    {
        get
        {
            PropriedadeAcessada(RO_PERDESCFLEX);
            return _perdescflex;
        }
        set
        {
            PropriedadeModificada(RO_PERDESCFLEX, value);
            _perdescflex = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 2)]
    public decimal? Perdescisentoicms
    {
        get
        {
            PropriedadeAcessada(RO_PERDESCISENTOICMS);
            return _perdescisentoicms;
        }
        set
        {
            PropriedadeModificada(RO_PERDESCISENTOICMS, value);
            _perdescisentoicms = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Perfretecmv
    {
        get
        {
            PropriedadeAcessada(RO_PERFRETECMV);
            return _perfretecmv;
        }
        set
        {
            PropriedadeModificada(RO_PERFRETECMV, value);
            _perfretecmv = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 2)]
    public decimal? Pericm
    {
        get
        {
            PropriedadeAcessada(RO_PERICM);
            return _pericm;
        }
        set
        {
            PropriedadeModificada(RO_PERICM, value);
            _pericm = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 2)]
    public decimal? Pericmfrete
    {
        get
        {
            PropriedadeAcessada(RO_PERICMFRETE);
            return _pericmfrete;
        }
        set
        {
            PropriedadeModificada(RO_PERICMFRETE, value);
            _pericmfrete = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 2)]
    public decimal? Pericmguiapropria
    {
        get
        {
            PropriedadeAcessada(RO_PERICMGUIAPROPRIA);
            return _pericmguiapropria;
        }
        set
        {
            PropriedadeModificada(RO_PERICMGUIAPROPRIA, value);
            _pericmguiapropria = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Pericmsantecipado
    {
        get
        {
            PropriedadeAcessada(RO_PERICMSANTECIPADO);
            return _pericmsantecipado;
        }
        set
        {
            PropriedadeModificada(RO_PERICMSANTECIPADO, value);
            _pericmsantecipado = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Perpis
    {
        get
        {
            PropriedadeAcessada(RO_PERPIS);
            return _perpis;
        }
        set
        {
            PropriedadeModificada(RO_PERPIS, value);
            _perpis = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Perredcomiss
    {
        get
        {
            PropriedadeAcessada(RO_PERREDCOMISS);
            return _perredcomiss;
        }
        set
        {
            PropriedadeModificada(RO_PERREDCOMISS, value);
            _perredcomiss = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Perredcomisssup
    {
        get
        {
            PropriedadeAcessada(RO_PERREDCOMISSSUP);
            return _perredcomisssup;
        }
        set
        {
            PropriedadeModificada(RO_PERREDCOMISSSUP, value);
            _perredcomisssup = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Pesobruto
    {
        get
        {
            PropriedadeAcessada(RO_PESOBRUTO);
            return _pesobruto;
        }
        set
        {
            PropriedadeModificada(RO_PESOBRUTO, value);
            _pesobruto = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 6)]
    public decimal? Pesoliq
    {
        get
        {
            PropriedadeAcessada(RO_PESOLIQ);
            return _pesoliq;
        }
        set
        {
            PropriedadeModificada(RO_PESOLIQ, value);
            _pesoliq = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Piscofinsretido
    {
        get
        {
            PropriedadeAcessada(RO_PISCOFINSRETIDO);
            return _piscofinsretido;
        }
        set
        {
            PropriedadeModificada(RO_PISCOFINSRETIDO, value);
            _piscofinsretido = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Pliqped
    {
        get
        {
            PropriedadeAcessada(RO_PLIQPED);
            return _pliqped;
        }
        set
        {
            PropriedadeModificada(RO_PLIQPED, value);
            _pliqped = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Prazomedio
    {
        get
        {
            PropriedadeAcessada(RO_PRAZOMEDIO);
            return _prazomedio;
        }
        set
        {
            PropriedadeModificada(RO_PRAZOMEDIO, value);
            _prazomedio = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Precopauta
    {
        get
        {
            PropriedadeAcessada(RO_PRECOPAUTA);
            return _precopauta;
        }
        set
        {
            PropriedadeModificada(RO_PRECOPAUTA, value);
            _precopauta = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Prodbonificado
    {
        get
        {
            PropriedadeAcessada(RO_PRODBONIFICADO);
            return _prodbonificado;
        }
        set
        {
            PropriedadeModificada(RO_PRODBONIFICADO, value);
            _prodbonificado = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 300, Precisao = 0)]
    public string Proddescricaocontrato
    {
        get
        {
            PropriedadeAcessada(RO_PRODDESCRICAOCONTRATO);
            return _proddescricaocontrato;
        }
        set
        {
            PropriedadeModificada(RO_PRODDESCRICAOCONTRATO, value);
            _proddescricaocontrato = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Promocaobiro
    {
        get
        {
            PropriedadeAcessada(RO_PROMOCAOBIRO);
            return _promocaobiro;
        }
        set
        {
            PropriedadeModificada(RO_PROMOCAOBIRO, value);
            _promocaobiro = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Ptabela
    {
        get
        {
            PropriedadeAcessada(RO_PTABELA);
            return _ptabela;
        }
        set
        {
            PropriedadeModificada(RO_PTABELA, value);
            _ptabela = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Ptabela2
    {
        get
        {
            PropriedadeAcessada(RO_PTABELA2);
            return _ptabela2;
        }
        set
        {
            PropriedadeModificada(RO_PTABELA2, value);
            _ptabela2 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Punit
    {
        get
        {
            PropriedadeAcessada(RO_PUNIT);
            return _punit;
        }
        set
        {
            PropriedadeModificada(RO_PUNIT, value);
            _punit = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Punitcont
    {
        get
        {
            PropriedadeAcessada(RO_PUNITCONT);
            return _punitcont;
        }
        set
        {
            PropriedadeModificada(RO_PUNITCONT, value);
            _punitcont = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Punitnf
    {
        get
        {
            PropriedadeAcessada(RO_PUNITNF);
            return _punitnf;
        }
        set
        {
            PropriedadeModificada(RO_PUNITNF, value);
            _punitnf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Pvendabase
    {
        get
        {
            PropriedadeAcessada(RO_PVENDABASE);
            return _pvendabase;
        }
        set
        {
            PropriedadeModificada(RO_PVENDABASE, value);
            _pvendabase = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 3)]
    public decimal? Pvendaemb
    {
        get
        {
            PropriedadeAcessada(RO_PVENDAEMB);
            return _pvendaemb;
        }
        set
        {
            PropriedadeModificada(RO_PVENDAEMB, value);
            _pvendaemb = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Pvendaembalagem
    {
        get
        {
            PropriedadeAcessada(RO_PVENDAEMBALAGEM);
            return _pvendaembalagem;
        }
        set
        {
            PropriedadeModificada(RO_PVENDAEMBALAGEM, value);
            _pvendaembalagem = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Pvenda1
    {
        get
        {
            PropriedadeAcessada(RO_PVENDA1);
            return _pvenda1;
        }
        set
        {
            PropriedadeModificada(RO_PVENDA1, value);
            _pvenda1 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 20, Precisao = 6)]
    public decimal? Qt
    {
        get
        {
            PropriedadeAcessada(RO_QT);
            return _qt;
        }
        set
        {
            PropriedadeModificada(RO_QT, value);
            _qt = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 20, Precisao = 6)]
    public decimal? Qtavaria
    {
        get
        {
            PropriedadeAcessada(RO_QTAVARIA);
            return _qtavaria;
        }
        set
        {
            PropriedadeModificada(RO_QTAVARIA, value);
            _qtavaria = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 20, Precisao = 6)]
    public decimal? Qtbloqueada
    {
        get
        {
            PropriedadeAcessada(RO_QTBLOQUEADA);
            return _qtbloqueada;
        }
        set
        {
            PropriedadeModificada(RO_QTBLOQUEADA, value);
            _qtbloqueada = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 2)]
    public decimal? Qtconf
    {
        get
        {
            PropriedadeAcessada(RO_QTCONF);
            return _qtconf;
        }
        set
        {
            PropriedadeModificada(RO_QTCONF, value);
            _qtconf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 20, Precisao = 6)]
    public decimal? Qtcont
    {
        get
        {
            PropriedadeAcessada(RO_QTCONT);
            return _qtcont;
        }
        set
        {
            PropriedadeModificada(RO_QTCONT, value);
            _qtcont = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 6)]
    public decimal? Qtcx
    {
        get
        {
            PropriedadeAcessada(RO_QTCX);
            return _qtcx;
        }
        set
        {
            PropriedadeModificada(RO_QTCX, value);
            _qtcx = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 20, Precisao = 6)]
    public decimal? Qtdevol
    {
        get
        {
            PropriedadeAcessada(RO_QTDEVOL);
            return _qtdevol;
        }
        set
        {
            PropriedadeModificada(RO_QTDEVOL, value);
            _qtdevol = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 3)]
    public decimal? Qtembalagem
    {
        get
        {
            PropriedadeAcessada(RO_QTEMBALAGEM);
            return _qtembalagem;
        }
        set
        {
            PropriedadeModificada(RO_QTEMBALAGEM, value);
            _qtembalagem = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 16, Precisao = 3)]
    public decimal? Qtestant
    {
        get
        {
            PropriedadeAcessada(RO_QTESTANT);
            return _qtestant;
        }
        set
        {
            PropriedadeModificada(RO_QTESTANT, value);
            _qtestant = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 16, Precisao = 3)]
    public decimal? Qtestgerant
    {
        get
        {
            PropriedadeAcessada(RO_QTESTGERANT);
            return _qtestgerant;
        }
        set
        {
            PropriedadeModificada(RO_QTESTGERANT, value);
            _qtestgerant = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 2)]
    public decimal? Qthoras
    {
        get
        {
            PropriedadeAcessada(RO_QTHORAS);
            return _qthoras;
        }
        set
        {
            PropriedadeModificada(RO_QTHORAS, value);
            _qthoras = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 6)]
    public decimal? Qtpecas
    {
        get
        {
            PropriedadeAcessada(RO_QTPECAS);
            return _qtpecas;
        }
        set
        {
            PropriedadeModificada(RO_QTPECAS, value);
            _qtpecas = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 16, Precisao = 3)]
    public decimal? Qtsaldoest
    {
        get
        {
            PropriedadeAcessada(RO_QTSALDOEST);
            return _qtsaldoest;
        }
        set
        {
            PropriedadeModificada(RO_QTSALDOEST, value);
            _qtsaldoest = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 16, Precisao = 3)]
    public decimal? Qtsaldoestger
    {
        get
        {
            PropriedadeAcessada(RO_QTSALDOESTGER);
            return _qtsaldoestger;
        }
        set
        {
            PropriedadeModificada(RO_QTSALDOESTGER, value);
            _qtsaldoestger = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 16, Precisao = 3)]
    public decimal? Qtultentant
    {
        get
        {
            PropriedadeAcessada(RO_QTULTENTANT);
            return _qtultentant;
        }
        set
        {
            PropriedadeModificada(RO_QTULTENTANT, value);
            _qtultentant = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 2)]
    public decimal? Qtunit
    {
        get
        {
            PropriedadeAcessada(RO_QTUNIT);
            return _qtunit;
        }
        set
        {
            PropriedadeModificada(RO_QTUNIT, value);
            _qtunit = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 2)]
    public decimal? Qtunitcx
    {
        get
        {
            PropriedadeAcessada(RO_QTUNITCX);
            return _qtunitcx;
        }
        set
        {
            PropriedadeModificada(RO_QTUNITCX, value);
            _qtunitcx = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Qtunitemb
    {
        get
        {
            PropriedadeAcessada(RO_QTUNITEMB);
            return _qtunitemb;
        }
        set
        {
            PropriedadeModificada(RO_QTUNITEMB, value);
            _qtunitemb = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 3)]
    public decimal? Qtvendaemb
    {
        get
        {
            PropriedadeAcessada(RO_QTVENDAEMB);
            return _qtvendaemb;
        }
        set
        {
            PropriedadeModificada(RO_QTVENDAEMB, value);
            _qtvendaemb = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 6, Precisao = 0)]
    public string Qualdivergencia
    {
        get
        {
            PropriedadeAcessada(RO_QUALDIVERGENCIA);
            return _qualdivergencia;
        }
        set
        {
            PropriedadeModificada(RO_QUALDIVERGENCIA, value);
            _qualdivergencia = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Redbasealiqext
    {
        get
        {
            PropriedadeAcessada(RO_REDBASEALIQEXT);
            return _redbasealiqext;
        }
        set
        {
            PropriedadeModificada(RO_REDBASEALIQEXT, value);
            _redbasealiqext = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Redbaseiva
    {
        get
        {
            PropriedadeAcessada(RO_REDBASEIVA);
            return _redbaseiva;
        }
        set
        {
            PropriedadeModificada(RO_REDBASEIVA, value);
            _redbaseiva = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
    public string Refcor
    {
        get
        {
            PropriedadeAcessada(RO_REFCOR);
            return _refcor;
        }
        set
        {
            PropriedadeModificada(RO_REFCOR, value);
            _refcor = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 48, Precisao = 0)]
    public string Rotinacad
    {
        get
        {
            PropriedadeAcessada(RO_ROTINACAD);
            return _rotinacad;
        }
        set
        {
            PropriedadeModificada(RO_ROTINACAD, value);
            _rotinacad = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 48, Precisao = 0)]
    public string Rotinalanc
    {
        get
        {
            PropriedadeAcessada(RO_ROTINALANC);
            return _rotinalanc;
        }
        set
        {
            PropriedadeModificada(RO_ROTINALANC, value);
            _rotinalanc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Rua
    {
        get
        {
            PropriedadeAcessada(RO_RUA);
            return _rua;
        }
        set
        {
            PropriedadeModificada(RO_RUA, value);
            _rua = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 0)]
    public decimal? Seqmov
    {
        get
        {
            PropriedadeAcessada(RO_SEQMOV);
            return _seqmov;
        }
        set
        {
            PropriedadeModificada(RO_SEQMOV, value);
            _seqmov = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 10, Precisao = 0)]
    public string Siglaqualidade
    {
        get
        {
            PropriedadeAcessada(RO_SIGLAQUALIDADE);
            return _siglaqualidade;
        }
        set
        {
            PropriedadeModificada(RO_SIGLAQUALIDADE, value);
            _siglaqualidade = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 3, Precisao = 0)]
    public string Sittribut
    {
        get
        {
            PropriedadeAcessada(RO_SITTRIBUT);
            return _sittribut;
        }
        set
        {
            PropriedadeModificada(RO_SITTRIBUT, value);
            _sittribut = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? St
    {
        get
        {
            PropriedadeAcessada(RO_ST);
            return _st;
        }
        set
        {
            PropriedadeModificada(RO_ST, value);
            _st = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Status
    {
        get
        {
            PropriedadeAcessada(RO_STATUS);
            return _status;
        }
        set
        {
            PropriedadeModificada(RO_STATUS, value);
            _status = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Stclientegnre
    {
        get
        {
            PropriedadeAcessada(RO_STCLIENTEGNRE);
            return _stclientegnre;
        }
        set
        {
            PropriedadeModificada(RO_STCLIENTEGNRE, value);
            _stclientegnre = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Stsaida
    {
        get
        {
            PropriedadeAcessada(RO_STSAIDA);
            return _stsaida;
        }
        set
        {
            PropriedadeModificada(RO_STSAIDA, value);
            _stsaida = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Tipodescaplicado
    {
        get
        {
            PropriedadeAcessada(RO_TIPODESCAPLICADO);
            return _tipodescaplicado;
        }
        set
        {
            PropriedadeModificada(RO_TIPODESCAPLICADO, value);
            _tipodescaplicado = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Tipofornec
    {
        get
        {
            PropriedadeAcessada(RO_TIPOFORNEC);
            return _tipofornec;
        }
        set
        {
            PropriedadeModificada(RO_TIPOFORNEC, value);
            _tipofornec = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Tipoitem
    {
        get
        {
            PropriedadeAcessada(RO_TIPOITEM);
            return _tipoitem;
        }
        set
        {
            PropriedadeModificada(RO_TIPOITEM, value);
            _tipoitem = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Tipomerc
    {
        get
        {
            PropriedadeAcessada(RO_TIPOMERC);
            return _tipomerc;
        }
        set
        {
            PropriedadeModificada(RO_TIPOMERC, value);
            _tipomerc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Tipomercdepto
    {
        get
        {
            PropriedadeAcessada(RO_TIPOMERCDEPTO);
            return _tipomercdepto;
        }
        set
        {
            PropriedadeModificada(RO_TIPOMERCDEPTO, value);
            _tipomercdepto = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Tiposeparacao
    {
        get
        {
            PropriedadeAcessada(RO_TIPOSEPARACAO);
            return _tiposeparacao;
        }
        set
        {
            PropriedadeModificada(RO_TIPOSEPARACAO, value);
            _tiposeparacao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Tipotis
    {
        get
        {
            PropriedadeAcessada(RO_TIPOTIS);
            return _tipotis;
        }
        set
        {
            PropriedadeModificada(RO_TIPOTIS, value);
            _tipotis = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Tipotributmedic
    {
        get
        {
            PropriedadeAcessada(RO_TIPOTRIBUTMEDIC);
            return _tipotributmedic;
        }
        set
        {
            PropriedadeModificada(RO_TIPOTRIBUTMEDIC, value);
            _tipotributmedic = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Transacaotransferida
    {
        get
        {
            PropriedadeAcessada(RO_TRANSACAOTRANSFERIDA);
            return _transacaotransferida;
        }
        set
        {
            PropriedadeModificada(RO_TRANSACAOTRANSFERIDA, value);
            _transacaotransferida = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Trgpclote
    {
        get
        {
            PropriedadeAcessada(RO_TRGPCLOTE);
            return _trgpclote;
        }
        set
        {
            PropriedadeModificada(RO_TRGPCLOTE, value);
            _trgpclote = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 15, Precisao = 0)]
    public string Tribfederal
    {
        get
        {
            PropriedadeAcessada(RO_TRIBFEDERAL);
            return _tribfederal;
        }
        set
        {
            PropriedadeModificada(RO_TRIBFEDERAL, value);
            _tribfederal = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Truncaritem
    {
        get
        {
            PropriedadeAcessada(RO_TRUNCARITEM);
            return _truncaritem;
        }
        set
        {
            PropriedadeModificada(RO_TRUNCARITEM, value);
            _truncaritem = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 6)]
    public decimal? Txvenda
    {
        get
        {
            PropriedadeAcessada(RO_TXVENDA);
            return _txvenda;
        }
        set
        {
            PropriedadeModificada(RO_TXVENDA, value);
            _txvenda = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Uffornec
    {
        get
        {
            PropriedadeAcessada(RO_UFFORNEC);
            return _uffornec;
        }
        set
        {
            PropriedadeModificada(RO_UFFORNEC, value);
            _uffornec = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Unidade
    {
        get
        {
            PropriedadeAcessada(RO_UNIDADE);
            return _unidade;
        }
        set
        {
            PropriedadeModificada(RO_UNIDADE, value);
            _unidade = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Usadebcredrcabrind
    {
        get
        {
            PropriedadeAcessada(RO_USADEBCREDRCABRIND);
            return _usadebcredrcabrind;
        }
        set
        {
            PropriedadeModificada(RO_USADEBCREDRCABRIND, value);
            _usadebcredrcabrind = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Valordireitosaduaneiros
    {
        get
        {
            PropriedadeAcessada(RO_VALORDIREITOSADUANEIROS);
            return _valordireitosaduaneiros;
        }
        set
        {
            PropriedadeModificada(RO_VALORDIREITOSADUANEIROS, value);
            _valordireitosaduaneiros = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Valorimpostoconsumo
    {
        get
        {
            PropriedadeAcessada(RO_VALORIMPOSTOCONSUMO);
            return _valorimpostoconsumo;
        }
        set
        {
            PropriedadeModificada(RO_VALORIMPOSTOCONSUMO, value);
            _valorimpostoconsumo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Valorimpostoselo
    {
        get
        {
            PropriedadeAcessada(RO_VALORIMPOSTOSELO);
            return _valorimpostoselo;
        }
        set
        {
            PropriedadeModificada(RO_VALORIMPOSTOSELO, value);
            _valorimpostoselo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Valorultentant
    {
        get
        {
            PropriedadeAcessada(RO_VALORULTENTANT);
            return _valorultentant;
        }
        set
        {
            PropriedadeModificada(RO_VALORULTENTANT, value);
            _valorultentant = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Valorultentmed
    {
        get
        {
            PropriedadeAcessada(RO_VALORULTENTMED);
            return _valorultentmed;
        }
        set
        {
            PropriedadeModificada(RO_VALORULTENTMED, value);
            _valorultentmed = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Valorultentmedant
    {
        get
        {
            PropriedadeAcessada(RO_VALORULTENTMEDANT);
            return _valorultentmedant;
        }
        set
        {
            PropriedadeModificada(RO_VALORULTENTMEDANT, value);
            _valorultentmedant = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlacrescimopf
    {
        get
        {
            PropriedadeAcessada(RO_VLACRESCIMOPF);
            return _vlacrescimopf;
        }
        set
        {
            PropriedadeModificada(RO_VLACRESCIMOPF, value);
            _vlacrescimopf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlacrescrodape
    {
        get
        {
            PropriedadeAcessada(RO_VLACRESCRODAPE);
            return _vlacrescrodape;
        }
        set
        {
            PropriedadeModificada(RO_VLACRESCRODAPE, value);
            _vlacrescrodape = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vladicionalbcst
    {
        get
        {
            PropriedadeAcessada(RO_VLADICIONALBCST);
            return _vladicionalbcst;
        }
        set
        {
            PropriedadeModificada(RO_VLADICIONALBCST, value);
            _vladicionalbcst = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vladuaneira
    {
        get
        {
            PropriedadeAcessada(RO_VLADUANEIRA);
            return _vladuaneira;
        }
        set
        {
            PropriedadeModificada(RO_VLADUANEIRA, value);
            _vladuaneira = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlbasegnre
    {
        get
        {
            PropriedadeAcessada(RO_VLBASEGNRE);
            return _vlbasegnre;
        }
        set
        {
            PropriedadeModificada(RO_VLBASEGNRE, value);
            _vlbasegnre = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlbaseipi
    {
        get
        {
            PropriedadeAcessada(RO_VLBASEIPI);
            return _vlbaseipi;
        }
        set
        {
            PropriedadeModificada(RO_VLBASEIPI, value);
            _vlbaseipi = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 20, Precisao = 6)]
    public decimal? Vlbasepiscofins
    {
        get
        {
            PropriedadeAcessada(RO_VLBASEPISCOFINS);
            return _vlbasepiscofins;
        }
        set
        {
            PropriedadeModificada(RO_VLBASEPISCOFINS, value);
            _vlbasepiscofins = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlbasestforanf
    {
        get
        {
            PropriedadeAcessada(RO_VLBASESTFORANF);
            return _vlbasestforanf;
        }
        set
        {
            PropriedadeModificada(RO_VLBASESTFORANF, value);
            _vlbasestforanf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlbonific
    {
        get
        {
            PropriedadeAcessada(RO_VLBONIFIC);
            return _vlbonific;
        }
        set
        {
            PropriedadeModificada(RO_VLBONIFIC, value);
            _vlbonific = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlbonificoutras
    {
        get
        {
            PropriedadeAcessada(RO_VLBONIFICOUTRAS);
            return _vlbonificoutras;
        }
        set
        {
            PropriedadeModificada(RO_VLBONIFICOUTRAS, value);
            _vlbonificoutras = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 24, Precisao = 6)]
    public decimal? Vlcofins
    {
        get
        {
            PropriedadeAcessada(RO_VLCOFINS);
            return _vlcofins;
        }
        set
        {
            PropriedadeModificada(RO_VLCOFINS, value);
            _vlcofins = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlcredcofins
    {
        get
        {
            PropriedadeAcessada(RO_VLCREDCOFINS);
            return _vlcredcofins;
        }
        set
        {
            PropriedadeModificada(RO_VLCREDCOFINS, value);
            _vlcredcofins = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlcredicms
    {
        get
        {
            PropriedadeAcessada(RO_VLCREDICMS);
            return _vlcredicms;
        }
        set
        {
            PropriedadeModificada(RO_VLCREDICMS, value);
            _vlcredicms = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlcredicmsfrete
    {
        get
        {
            PropriedadeAcessada(RO_VLCREDICMSFRETE);
            return _vlcredicmsfrete;
        }
        set
        {
            PropriedadeModificada(RO_VLCREDICMSFRETE, value);
            _vlcredicmsfrete = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlcredpis
    {
        get
        {
            PropriedadeAcessada(RO_VLCREDPIS);
            return _vlcredpis;
        }
        set
        {
            PropriedadeModificada(RO_VLCREDPIS, value);
            _vlcredpis = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlcredpresumido
    {
        get
        {
            PropriedadeAcessada(RO_VLCREDPRESUMIDO);
            return _vlcredpresumido;
        }
        set
        {
            PropriedadeModificada(RO_VLCREDPRESUMIDO, value);
            _vlcredpresumido = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vldesccom
    {
        get
        {
            PropriedadeAcessada(RO_VLDESCCOM);
            return _vldesccom;
        }
        set
        {
            PropriedadeModificada(RO_VLDESCCOM, value);
            _vldesccom = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Vldesccustocmv
    {
        get
        {
            PropriedadeAcessada(RO_VLDESCCUSTOCMV);
            return _vldesccustocmv;
        }
        set
        {
            PropriedadeModificada(RO_VLDESCCUSTOCMV, value);
            _vldesccustocmv = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vldescfin
    {
        get
        {
            PropriedadeAcessada(RO_VLDESCFIN);
            return _vldescfin;
        }
        set
        {
            PropriedadeModificada(RO_VLDESCFIN, value);
            _vldescfin = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vldescflex
    {
        get
        {
            PropriedadeAcessada(RO_VLDESCFLEX);
            return _vldescflex;
        }
        set
        {
            PropriedadeModificada(RO_VLDESCFLEX, value);
            _vldescflex = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vldescicmisencao
    {
        get
        {
            PropriedadeAcessada(RO_VLDESCICMISENCAO);
            return _vldescicmisencao;
        }
        set
        {
            PropriedadeModificada(RO_VLDESCICMISENCAO, value);
            _vldescicmisencao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vldescicmsdif
    {
        get
        {
            PropriedadeAcessada(RO_VLDESCICMSDIF);
            return _vldescicmsdif;
        }
        set
        {
            PropriedadeModificada(RO_VLDESCICMSDIF, value);
            _vldescicmsdif = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vldesconto
    {
        get
        {
            PropriedadeAcessada(RO_VLDESCONTO);
            return _vldesconto;
        }
        set
        {
            PropriedadeModificada(RO_VLDESCONTO, value);
            _vldesconto = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vldescpissuframa
    {
        get
        {
            PropriedadeAcessada(RO_VLDESCPISSUFRAMA);
            return _vldescpissuframa;
        }
        set
        {
            PropriedadeModificada(RO_VLDESCPISSUFRAMA, value);
            _vldescpissuframa = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 24, Precisao = 6)]
    public decimal? Vldescreducaocofins
    {
        get
        {
            PropriedadeAcessada(RO_VLDESCREDUCAOCOFINS);
            return _vldescreducaocofins;
        }
        set
        {
            PropriedadeModificada(RO_VLDESCREDUCAOCOFINS, value);
            _vldescreducaocofins = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 24, Precisao = 6)]
    public decimal? Vldescreducaopis
    {
        get
        {
            PropriedadeAcessada(RO_VLDESCREDUCAOPIS);
            return _vldescreducaopis;
        }
        set
        {
            PropriedadeModificada(RO_VLDESCREDUCAOPIS, value);
            _vldescreducaopis = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vldescrodape
    {
        get
        {
            PropriedadeAcessada(RO_VLDESCRODAPE);
            return _vldescrodape;
        }
        set
        {
            PropriedadeModificada(RO_VLDESCRODAPE, value);
            _vldescrodape = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vldespadicional
    {
        get
        {
            PropriedadeAcessada(RO_VLDESPADICIONAL);
            return _vldespadicional;
        }
        set
        {
            PropriedadeModificada(RO_VLDESPADICIONAL, value);
            _vldespadicional = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vldespdentronf
    {
        get
        {
            PropriedadeAcessada(RO_VLDESPDENTRONF);
            return _vldespdentronf;
        }
        set
        {
            PropriedadeModificada(RO_VLDESPDENTRONF, value);
            _vldespdentronf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vldespforanf
    {
        get
        {
            PropriedadeAcessada(RO_VLDESPFORANF);
            return _vldespforanf;
        }
        set
        {
            PropriedadeModificada(RO_VLDESPFORANF, value);
            _vldespforanf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vldifaliquotas
    {
        get
        {
            PropriedadeAcessada(RO_VLDIFALIQUOTAS);
            return _vldifaliquotas;
        }
        set
        {
            PropriedadeModificada(RO_VLDIFALIQUOTAS, value);
            _vldifaliquotas = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vldifpunitcont
    {
        get
        {
            PropriedadeAcessada(RO_VLDIFPUNITCONT);
            return _vldifpunitcont;
        }
        set
        {
            PropriedadeModificada(RO_VLDIFPUNITCONT, value);
            _vldifpunitcont = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlfrete
    {
        get
        {
            PropriedadeAcessada(RO_VLFRETE);
            return _vlfrete;
        }
        set
        {
            PropriedadeModificada(RO_VLFRETE, value);
            _vlfrete = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlfreteconhec
    {
        get
        {
            PropriedadeAcessada(RO_VLFRETECONHEC);
            return _vlfreteconhec;
        }
        set
        {
            PropriedadeModificada(RO_VLFRETECONHEC, value);
            _vlfreteconhec = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlfreteporkg
    {
        get
        {
            PropriedadeAcessada(RO_VLFRETEPORKG);
            return _vlfreteporkg;
        }
        set
        {
            PropriedadeModificada(RO_VLFRETEPORKG, value);
            _vlfreteporkg = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlfrete_Rateio
    {
        get
        {
            PropriedadeAcessada(RO_VLFRETE_RATEIO);
            return _vlfrete_rateio;
        }
        set
        {
            PropriedadeModificada(RO_VLFRETE_RATEIO, value);
            _vlfrete_rateio = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 2)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 4)]
    public decimal? Vlicmsdiferido
    {
        get
        {
            PropriedadeAcessada(RO_VLICMSDIFERIDO);
            return _vlicmsdiferido;
        }
        set
        {
            PropriedadeModificada(RO_VLICMSDIFERIDO, value);
            _vlicmsdiferido = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlimportacao
    {
        get
        {
            PropriedadeAcessada(RO_VLIMPORTACAO);
            return _vlimportacao;
        }
        set
        {
            PropriedadeModificada(RO_VLIMPORTACAO, value);
            _vlimportacao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlindeniz
    {
        get
        {
            PropriedadeAcessada(RO_VLINDENIZ);
            return _vlindeniz;
        }
        set
        {
            PropriedadeModificada(RO_VLINDENIZ, value);
            _vlindeniz = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlinss
    {
        get
        {
            PropriedadeAcessada(RO_VLINSS);
            return _vlinss;
        }
        set
        {
            PropriedadeModificada(RO_VLINSS, value);
            _vlinss = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlipi
    {
        get
        {
            PropriedadeAcessada(RO_VLIPI);
            return _vlipi;
        }
        set
        {
            PropriedadeModificada(RO_VLIPI, value);
            _vlipi = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlipiporkg
    {
        get
        {
            PropriedadeAcessada(RO_VLIPIPORKG);
            return _vlipiporkg;
        }
        set
        {
            PropriedadeModificada(RO_VLIPIPORKG, value);
            _vlipiporkg = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vliss
    {
        get
        {
            PropriedadeAcessada(RO_VLISS);
            return _vliss;
        }
        set
        {
            PropriedadeModificada(RO_VLISS, value);
            _vliss = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlivamex
    {
        get
        {
            PropriedadeAcessada(RO_VLIVAMEX);
            return _vlivamex;
        }
        set
        {
            PropriedadeModificada(RO_VLIVAMEX, value);
            _vlivamex = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 6)]
    public decimal? Vlmexfpgc
    {
        get
        {
            PropriedadeAcessada(RO_VLMEXFPGC);
            return _vlmexfpgc;
        }
        set
        {
            PropriedadeModificada(RO_VLMEXFPGC, value);
            _vlmexfpgc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 6)]
    public decimal? Vlmexieps
    {
        get
        {
            PropriedadeAcessada(RO_VLMEXIEPS);
            return _vlmexieps;
        }
        set
        {
            PropriedadeModificada(RO_VLMEXIEPS, value);
            _vlmexieps = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 6)]
    public decimal? Vlmexiva
    {
        get
        {
            PropriedadeAcessada(RO_VLMEXIVA);
            return _vlmexiva;
        }
        set
        {
            PropriedadeModificada(RO_VLMEXIVA, value);
            _vlmexiva = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vloutrasdesp
    {
        get
        {
            PropriedadeAcessada(RO_VLOUTRASDESP);
            return _vloutrasdesp;
        }
        set
        {
            PropriedadeModificada(RO_VLOUTRASDESP, value);
            _vloutrasdesp = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vloutrasdespimp
    {
        get
        {
            PropriedadeAcessada(RO_VLOUTRASDESPIMP);
            return _vloutrasdespimp;
        }
        set
        {
            PropriedadeModificada(RO_VLOUTRASDESPIMP, value);
            _vloutrasdespimp = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vloutras_Rateio
    {
        get
        {
            PropriedadeAcessada(RO_VLOUTRAS_RATEIO);
            return _vloutras_rateio;
        }
        set
        {
            PropriedadeModificada(RO_VLOUTRAS_RATEIO, value);
            _vloutras_rateio = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vloutros
    {
        get
        {
            PropriedadeAcessada(RO_VLOUTROS);
            return _vloutros;
        }
        set
        {
            PropriedadeModificada(RO_VLOUTROS, value);
            _vloutros = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlpautaicms
    {
        get
        {
            PropriedadeAcessada(RO_VLPAUTAICMS);
            return _vlpautaicms;
        }
        set
        {
            PropriedadeModificada(RO_VLPAUTAICMS, value);
            _vlpautaicms = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlpautaicmsantec
    {
        get
        {
            PropriedadeAcessada(RO_VLPAUTAICMSANTEC);
            return _vlpautaicmsantec;
        }
        set
        {
            PropriedadeModificada(RO_VLPAUTAICMSANTEC, value);
            _vlpautaicmsantec = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Vlpauta2
    {
        get
        {
            PropriedadeAcessada(RO_VLPAUTA2);
            return _vlpauta2;
        }
        set
        {
            PropriedadeModificada(RO_VLPAUTA2, value);
            _vlpauta2 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlpercbon
    {
        get
        {
            PropriedadeAcessada(RO_VLPERCBON);
            return _vlpercbon;
        }
        set
        {
            PropriedadeModificada(RO_VLPERCBON, value);
            _vlpercbon = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlpis
    {
        get
        {
            PropriedadeAcessada(RO_VLPIS);
            return _vlpis;
        }
        set
        {
            PropriedadeModificada(RO_VLPIS, value);
            _vlpis = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlredcomiss
    {
        get
        {
            PropriedadeAcessada(RO_VLREDCOMISS);
            return _vlredcomiss;
        }
        set
        {
            PropriedadeModificada(RO_VLREDCOMISS, value);
            _vlredcomiss = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlredcomisssup
    {
        get
        {
            PropriedadeAcessada(RO_VLREDCOMISSSUP);
            return _vlredcomisssup;
        }
        set
        {
            PropriedadeModificada(RO_VLREDCOMISSSUP, value);
            _vlredcomisssup = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlrepasse
    {
        get
        {
            PropriedadeAcessada(RO_VLREPASSE);
            return _vlrepasse;
        }
        set
        {
            PropriedadeModificada(RO_VLREPASSE, value);
            _vlrepasse = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlseguro
    {
        get
        {
            PropriedadeAcessada(RO_VLSEGURO);
            return _vlseguro;
        }
        set
        {
            PropriedadeModificada(RO_VLSEGURO, value);
            _vlseguro = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlsiscomex
    {
        get
        {
            PropriedadeAcessada(RO_VLSISCOMEX);
            return _vlsiscomex;
        }
        set
        {
            PropriedadeModificada(RO_VLSISCOMEX, value);
            _vlsiscomex = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlsuframa
    {
        get
        {
            PropriedadeAcessada(RO_VLSUFRAMA);
            return _vlsuframa;
        }
        set
        {
            PropriedadeModificada(RO_VLSUFRAMA, value);
            _vlsuframa = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlultentcontsemst
    {
        get
        {
            PropriedadeAcessada(RO_VLULTENTCONTSEMST);
            return _vlultentcontsemst;
        }
        set
        {
            PropriedadeModificada(RO_VLULTENTCONTSEMST, value);
            _vlultentcontsemst = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlultentcontsemstant
    {
        get
        {
            PropriedadeAcessada(RO_VLULTENTCONTSEMSTANT);
            return _vlultentcontsemstant;
        }
        set
        {
            PropriedadeModificada(RO_VLULTENTCONTSEMSTANT, value);
            _vlultentcontsemstant = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlverbacmv
    {
        get
        {
            PropriedadeAcessada(RO_VLVERBACMV);
            return _vlverbacmv;
        }
        set
        {
            PropriedadeModificada(RO_VLVERBACMV, value);
            _vlverbacmv = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlverbacmvcli
    {
        get
        {
            PropriedadeAcessada(RO_VLVERBACMVCLI);
            return _vlverbacmvcli;
        }
        set
        {
            PropriedadeModificada(RO_VLVERBACMVCLI, value);
            _vlverbacmvcli = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 20, Precisao = 8)]
    public decimal? Volume
    {
        get
        {
            PropriedadeAcessada(RO_VOLUME);
            return _volume;
        }
        set
        {
            PropriedadeModificada(RO_VOLUME, value);
            _volume = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Volumedesejado
    {
        get
        {
            PropriedadeAcessada(RO_VOLUMEDESEJADO);
            return _volumedesejado;
        }
        set
        {
            PropriedadeModificada(RO_VOLUMEDESEJADO, value);
            _volumedesejado = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 21, Precisao = 10)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 7, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 23, Precisao = 10)]
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
        return "PCMOV";
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
        _aliqicmsvigente = AlterarTipo<decimal?>(leitor["Aliqicmsvigente"]);
        _aliqicms1 = AlterarTipo<decimal?>(leitor["Aliqicms1"]);
        _aliqicms2 = AlterarTipo<decimal?>(leitor["Aliqicms2"]);
        _aliqicst = AlterarTipo<decimal?>(leitor["Aliqicst"]);
        _aliqstsaida = AlterarTipo<decimal?>(leitor["Aliqstsaida"]);
        _aliquotatis = AlterarTipo<decimal?>(leitor["Aliquotatis"]);
        _alternativo = AlterarTipo<string>(leitor["Alternativo"]);
        _aplicpercivapauta = AlterarTipo<string>(leitor["Aplicpercivapauta"]);
        _aproveitacredicms = AlterarTipo<string>(leitor["Aproveitacredicms"]);
        _aproveitacredpiscofins = AlterarTipo<string>(leitor["Aproveitacredpiscofins"]);
        _baseacrescimopf = AlterarTipo<decimal?>(leitor["Baseacrescimopf"]);
        _basebcr = AlterarTipo<decimal?>(leitor["Basebcr"]);
        _basedifaliquotas = AlterarTipo<decimal?>(leitor["Basedifaliquotas"]);
        _baseicms = AlterarTipo<decimal?>(leitor["Baseicms"]);
        _baseicmsadicional = AlterarTipo<decimal?>(leitor["Baseicmsadicional"]);
        _baseicmsbcr = AlterarTipo<decimal?>(leitor["Baseicmsbcr"]);
        _baseicmsultent = AlterarTipo<decimal?>(leitor["Baseicmsultent"]);
        _baseicmsultentant = AlterarTipo<decimal?>(leitor["Baseicmsultentant"]);
        _baseicms2 = AlterarTipo<decimal?>(leitor["Baseicms2"]);
        _baseicst = AlterarTipo<decimal?>(leitor["Baseicst"]);
        _baseivamex = AlterarTipo<decimal?>(leitor["Baseivamex"]);
        _basestsaida = AlterarTipo<decimal?>(leitor["Basestsaida"]);
        _bciss = AlterarTipo<decimal?>(leitor["Bciss"]);
        _brinde = AlterarTipo<string>(leitor["Brinde"]);
        _calccredipi = AlterarTipo<string>(leitor["Calccredipi"]);
        _capvoldnf = AlterarTipo<decimal?>(leitor["Capvoldnf"]);
        _classificfiscal = AlterarTipo<string>(leitor["Classificfiscal"]);
        _codauxiliar = AlterarTipo<decimal?>(leitor["Codauxiliar"]);
        _codbase = AlterarTipo<string>(leitor["Codbase"]);
        _codcertific = AlterarTipo<decimal?>(leitor["Codcertific"]);
        _codcli = AlterarTipo<decimal>(leitor["Codcli"]);
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
        _codusur = AlterarTipo<decimal>(leitor["Codusur"]);
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
        _numlista = AlterarTipo<decimal?>(leitor["Numlista"]);
        _numlote = AlterarTipo<string>(leitor["Numlote"]);
        _numlotefab = AlterarTipo<string>(leitor["Numlotefab"]);
        _numnegociacao = AlterarTipo<decimal?>(leitor["Numnegociacao"]);
        _numnota = AlterarTipo<decimal>(leitor["Numnota"]);
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
        _numtransentultent = AlterarTipo<decimal?>(leitor["Numtransentultent"]);
        _numtransentultentant = AlterarTipo<decimal?>(leitor["Numtransentultentant"]);
        _numtransitem = AlterarTipo<decimal?>(leitor["Numtransitem"]);
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
        _percaliqextguia = AlterarTipo<decimal?>(leitor["Percaliqextguia"]);
        _percaliqexticmantecip = AlterarTipo<decimal?>(leitor["Percaliqexticmantecip"]);
        _percaliqext2 = AlterarTipo<decimal?>(leitor["Percaliqext2"]);
        _percaliqinticmantecip = AlterarTipo<decimal?>(leitor["Percaliqinticmantecip"]);
        _percaliqint2 = AlterarTipo<decimal?>(leitor["Percaliqint2"]);
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
        _percicmcp = AlterarTipo<decimal?>(leitor["Percicmcp"]);
        _percicmop = AlterarTipo<decimal?>(leitor["Percicmop"]);
        _percicmoriginal = AlterarTipo<decimal?>(leitor["Percicmoriginal"]);
        _percicmred = AlterarTipo<decimal?>(leitor["Percicmred"]);
        _percicmsdiferido = AlterarTipo<decimal?>(leitor["Percicmsdiferido"]);
        _percicmsfretefobst = AlterarTipo<decimal?>(leitor["Percicmsfretefobst"]);
        _percicm2 = AlterarTipo<decimal?>(leitor["Percicm2"]);
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
        _percivaicmantecip = AlterarTipo<decimal?>(leitor["Percivaicmantecip"]);
        _percivamex = AlterarTipo<decimal?>(leitor["Percivamex"]);
        _perciva2 = AlterarTipo<decimal?>(leitor["Perciva2"]);
        _percmexfpgc = AlterarTipo<decimal?>(leitor["Percmexfpgc"]);
        _percmexieps = AlterarTipo<decimal?>(leitor["Percmexieps"]);
        _percmexiva = AlterarTipo<decimal?>(leitor["Percmexiva"]);
        _percofins = AlterarTipo<decimal?>(leitor["Percofins"]);
        _percom = AlterarTipo<decimal?>(leitor["Percom"]);
        _percomfilialbroker = AlterarTipo<decimal?>(leitor["Percomfilialbroker"]);
        _percommot = AlterarTipo<decimal?>(leitor["Percommot"]);
        _percomsup = AlterarTipo<decimal?>(leitor["Percomsup"]);
        _percom2 = AlterarTipo<decimal?>(leitor["Percom2"]);
        _percom3 = AlterarTipo<decimal?>(leitor["Percom3"]);
        _percom4 = AlterarTipo<decimal?>(leitor["Percom4"]);
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
        _pvendabase = AlterarTipo<decimal?>(leitor["Pvendabase"]);
        _pvendaemb = AlterarTipo<decimal?>(leitor["Pvendaemb"]);
        _pvendaembalagem = AlterarTipo<decimal?>(leitor["Pvendaembalagem"]);
        _pvenda1 = AlterarTipo<decimal?>(leitor["Pvenda1"]);
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
        _vlpautaicms = AlterarTipo<decimal?>(leitor["Vlpautaicms"]);
        _vlpautaicmsantec = AlterarTipo<decimal?>(leitor["Vlpautaicmsantec"]);
        _vlpauta2 = AlterarTipo<decimal?>(leitor["Vlpauta2"]);
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
        _movestoquecontabil = AlterarTipo<string>(leitor["Movestoquecontabil"]);
        _movestoquegerencial = AlterarTipo<string>(leitor["Movestoquegerencial"]);
        Qbcmonoret = AlterarTipo<decimal?>(leitor[RO_QBCMONORET]);
        Adremicmsret = AlterarTipo<decimal?>(leitor[RO_ADREMICMSRET]);
        Vicmsmonoret = AlterarTipo<decimal?>(leitor[RO_VICMSMONORET]);
    }

}