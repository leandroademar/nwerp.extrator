

////// namespace nwErp.Entidades.Winthor;

// namespace nwErp.Api.Modelos;

[Serializable]
public class PCTRIBUT : GerenteDePropriedades, IEntidade
{
    private static readonly string RO_ALIQICMSFECP = "Aliqicmsfecp";

    private decimal? _aliqicmsfecp;

    private static readonly string RO_ALIQICMSTV9 = "Aliqicmstv9";

    private decimal? _aliqicmstv9;

    private static readonly string RO_ALIQICMS1 = "Aliqicms1";

    private decimal? _aliqicms1;

    private static readonly string RO_ALIQICMS1FONTE = "Aliqicms1fonte";

    private decimal? _aliqicms1fonte;

    private static readonly string RO_ALIQICMS1TAB = "Aliqicms1tab";

    private decimal? _aliqicms1tab;

    private static readonly string RO_ALIQICMS1TRANSF = "Aliqicms1transf";

    private decimal? _aliqicms1transf;

    private static readonly string RO_ALIQICMS2 = "Aliqicms2";

    private decimal? _aliqicms2;

    private static readonly string RO_ALIQICMS2FONTE = "Aliqicms2fonte";

    private decimal? _aliqicms2fonte;

    private static readonly string RO_ALIQICMS2TAB = "Aliqicms2tab";

    private decimal? _aliqicms2tab;

    private static readonly string RO_ALIQICMS2TRANSF = "Aliqicms2transf";

    private decimal? _aliqicms2transf;

    private static readonly string RO_ALIQISS = "Aliqiss";

    private decimal? _aliqiss;

    private static readonly string RO_ALIQSTSAIDA = "Aliqstsaida";

    private decimal? _aliqstsaida;

    private static readonly string RO_ALIQSTSAIDAPF = "Aliqstsaidapf";

    private decimal? _aliqstsaidapf;

    private static readonly string RO_ALIQUOTAICMSENTTRANSF = "Aliquotaicmsenttransf";

    private decimal? _aliquotaicmsenttransf;

    private static readonly string RO_APLICAACRESCPJISENTA = "Aplicaacrescpjisenta";

    private string _aplicaacrescpjisenta;

    private static readonly string RO_ASSINATURA = "Assinatura";

    private string _assinatura;

    private static readonly string RO_CALCBASEREDICMSTRANSF = "Calcbaseredicmstransf";

    private string _calcbaseredicmstransf;

    private static readonly string RO_CALCBCICMSNF = "Calcbcicmsnf";

    private string _calcbcicmsnf;

    private static readonly string RO_CALCSTTRANSF = "Calcsttransf";

    private string _calcsttransf;

    private static readonly string RO_CALCULARICMSSITTRIBUT060 = "Calcularicmssittribut060";

    private string _calcularicmssittribut060;

    private static readonly string RO_CODECF = "Codecf";

    private string _codecf;

    private static readonly string RO_CODECFFUNCEP = "Codecffuncep";

    private string _codecffuncep;

    private static readonly string RO_CODFISCAL = "Codfiscal";

    private decimal? _codfiscal;

    private static readonly string RO_CODFISCALBONIFIC = "Codfiscalbonific";

    private decimal? _codfiscalbonific;

    private static readonly string RO_CODFISCALBONIFICINTER = "Codfiscalbonificinter";

    private decimal? _codfiscalbonificinter;

    private static readonly string RO_CODFISCALBONIFICINTERNASC = "Codfiscalbonificinternasc";

    private decimal? _codfiscalbonificinternasc;

    private static readonly string RO_CODFISCALBROKERDEVENT = "Codfiscalbrokerdevent";

    private decimal? _codfiscalbrokerdevent;

    private static readonly string RO_CODFISCALBROKERDEVSAID = "Codfiscalbrokerdevsaid";

    private decimal? _codfiscalbrokerdevsaid;

    private static readonly string RO_CODFISCALBROKERENT = "Codfiscalbrokerent";

    private decimal? _codfiscalbrokerent;

    private static readonly string RO_CODFISCALBROKERSAID = "Codfiscalbrokersaid";

    private decimal? _codfiscalbrokersaid;

    private static readonly string RO_CODFISCALCONSIG = "Codfiscalconsig";

    private decimal? _codfiscalconsig;

    private static readonly string RO_CODFISCALCONSIGINTER = "Codfiscalconsiginter";

    private decimal? _codfiscalconsiginter;

    private static readonly string RO_CODFISCALCONSIGINTERNAC = "Codfiscalconsiginternac";

    private decimal? _codfiscalconsiginternac;

    private static readonly string RO_CODFISCALCONTAORDEM = "Codfiscalcontaordem";

    private decimal? _codfiscalcontaordem;

    private static readonly string RO_CODFISCALCONTAORDEMINTER = "Codfiscalcontaordeminter";

    private decimal? _codfiscalcontaordeminter;

    private static readonly string RO_CODFISCALCONTAORDEMSIMPENT = "Codfiscalcontaordemsimpent";

    private decimal? _codfiscalcontaordemsimpent;

    private static readonly string RO_CODFISCALCONTAORDEMSIMPENTINTE = "Codfiscalcontaordemsimpentinte";

    private decimal? _codfiscalcontaordemsimpentinte;

    private static readonly string RO_CODFISCALDEVCLI = "Codfiscaldevcli";

    private decimal? _codfiscaldevcli;

    private static readonly string RO_CODFISCALDEVCLIBONIFIC = "Codfiscaldevclibonific";

    private decimal? _codfiscaldevclibonific;

    private static readonly string RO_CODFISCALDEVCLIBONIFICINTER = "Codfiscaldevclibonificinter";

    private decimal? _codfiscaldevclibonificinter;

    private static readonly string RO_CODFISCALDEVCLIBONINTERNASC = "Codfiscaldevcliboninternasc";

    private decimal? _codfiscaldevcliboninternasc;

    private static readonly string RO_CODFISCALDEVCLIINTER = "Codfiscaldevcliinter";

    private decimal? _codfiscaldevcliinter;

    private static readonly string RO_CODFISCALDEVCLIINTERNASC = "Codfiscaldevcliinternasc";

    private decimal? _codfiscaldevcliinternasc;

    private static readonly string RO_CODFISCALDEVCLIPF = "Codfiscaldevclipf";

    private decimal? _codfiscaldevclipf;

    private static readonly string RO_CODFISCALDEVCLIPFINTER = "Codfiscaldevclipfinter";

    private decimal? _codfiscaldevclipfinter;

    private static readonly string RO_CODFISCALDEVCLIPFINTERNASC = "Codfiscaldevclipfinternasc";

    private decimal? _codfiscaldevclipfinternasc;

    private static readonly string RO_CODFISCALDEVCLIPROENTINTERNASC = "Codfiscaldevcliproentinternasc";

    private decimal? _codfiscaldevcliproentinternasc;

    private static readonly string RO_CODFISCALDEVCLIPRONTAENT = "Codfiscaldevcliprontaent";

    private decimal? _codfiscaldevcliprontaent;

    private static readonly string RO_CODFISCALDEVCLIPRONTAENTINTER = "Codfiscaldevcliprontaentinter";

    private decimal? _codfiscaldevcliprontaentinter;

    private static readonly string RO_CODFISCALDEVCOMODATOEST = "Codfiscaldevcomodatoest";

    private decimal? _codfiscaldevcomodatoest;

    private static readonly string RO_CODFISCALDEVCOMODATOINTER = "Codfiscaldevcomodatointer";

    private decimal? _codfiscaldevcomodatointer;

    private static readonly string RO_CODFISCALDEVISENTOST = "Codfiscaldevisentost";

    private decimal? _codfiscaldevisentost;

    private static readonly string RO_CODFISCALDEVISENTOSTINTER = "Codfiscaldevisentostinter";

    private decimal? _codfiscaldevisentostinter;

    private static readonly string RO_CODFISCALDEVISENTOSTINTERNASC = "Codfiscaldevisentostinternasc";

    private decimal? _codfiscaldevisentostinternasc;

    private static readonly string RO_CODFISCALDEVMERCCONSIG = "Codfiscaldevmercconsig";

    private decimal? _codfiscaldevmercconsig;

    private static readonly string RO_CODFISCALDEVMERCCONSIGINTER = "Codfiscaldevmercconsiginter";

    private decimal? _codfiscaldevmercconsiginter;

    private static readonly string RO_CODFISCALDEVTRANSF = "Codfiscaldevtransf";

    private decimal? _codfiscaldevtransf;

    private static readonly string RO_CODFISCALDEVTRANSFENT = "Codfiscaldevtransfent";

    private decimal? _codfiscaldevtransfent;

    private static readonly string RO_CODFISCALDEVTRANSFENTINTER = "Codfiscaldevtransfentinter";

    private decimal? _codfiscaldevtransfentinter;

    private static readonly string RO_CODFISCALDEVTRANSFINTER = "Codfiscaldevtransfinter";

    private decimal? _codfiscaldevtransfinter;

    private static readonly string RO_CODFISCALENTBENEFICEST = "Codfiscalentbeneficest";

    private decimal? _codfiscalentbeneficest;

    private static readonly string RO_CODFISCALENTBENEFICINTEREST = "Codfiscalentbeneficinterest";

    private decimal? _codfiscalentbeneficinterest;

    private static readonly string RO_CODFISCALENTBENEFINTERNAC = "Codfiscalentbenefinternac";

    private decimal? _codfiscalentbenefinternac;

    private static readonly string RO_CODFISCALENVCOMODATOEST = "Codfiscalenvcomodatoest";

    private decimal? _codfiscalenvcomodatoest;

    private static readonly string RO_CODFISCALENVCOMODATOINTER = "Codfiscalenvcomodatointer";

    private decimal? _codfiscalenvcomodatointer;

    private static readonly string RO_CODFISCALINTER = "Codfiscalinter";

    private decimal? _codfiscalinter;

    private static readonly string RO_CODFISCALINTERNASC = "Codfiscalinternasc";

    private decimal? _codfiscalinternasc;

    private static readonly string RO_CODFISCALINTERNASCPF = "Codfiscalinternascpf";

    private decimal? _codfiscalinternascpf;

    private static readonly string RO_CODFISCALINTERNASCTV9 = "Codfiscalinternasctv9";

    private decimal? _codfiscalinternasctv9;

    private static readonly string RO_CODFISCALINTERPF = "Codfiscalinterpf";

    private decimal? _codfiscalinterpf;

    private static readonly string RO_CODFISCALINTERTV9 = "Codfiscalintertv9";

    private decimal? _codfiscalintertv9;

    private static readonly string RO_CODFISCALISENTOST = "Codfiscalisentost";

    private decimal? _codfiscalisentost;

    private static readonly string RO_CODFISCALISENTOSTINTER = "Codfiscalisentostinter";

    private decimal? _codfiscalisentostinter;

    private static readonly string RO_CODFISCALISENTOSTINTERNASC = "Codfiscalisentostinternasc";

    private decimal? _codfiscalisentostinternasc;

    private static readonly string RO_CODFISCALMERCCONSIG = "Codfiscalmercconsig";

    private decimal? _codfiscalmercconsig;

    private static readonly string RO_CODFISCALMERCCONSIGINTER = "Codfiscalmercconsiginter";

    private decimal? _codfiscalmercconsiginter;

    private static readonly string RO_CODFISCALMERCCONSIGINTERNASC = "Codfiscalmercconsiginternasc";

    private decimal? _codfiscalmercconsiginternasc;

    private static readonly string RO_CODFISCALPF = "Codfiscalpf";

    private decimal? _codfiscalpf;

    private static readonly string RO_CODFISCALPRONTAENT = "Codfiscalprontaent";

    private decimal? _codfiscalprontaent;

    private static readonly string RO_CODFISCALPRONTAENTINTER = "Codfiscalprontaentinter";

    private decimal? _codfiscalprontaentinter;

    private static readonly string RO_CODFISCALPRONTAENTINTERNASC = "Codfiscalprontaentinternasc";

    private decimal? _codfiscalprontaentinternasc;

    private static readonly string RO_CODFISCALSAIDBENEFEST = "Codfiscalsaidbenefest";

    private decimal? _codfiscalsaidbenefest;

    private static readonly string RO_CODFISCALSAIDBENEFINTEREST = "Codfiscalsaidbenefinterest";

    private decimal? _codfiscalsaidbenefinterest;

    private static readonly string RO_CODFISCALSAIDBENEFINTERNAC = "Codfiscalsaidbenefinternac";

    private decimal? _codfiscalsaidbenefinternac;

    private static readonly string RO_CODFISCALSIMPENTFUT = "Codfiscalsimpentfut";

    private decimal? _codfiscalsimpentfut;

    private static readonly string RO_CODFISCALSIMPENTFUTINTER = "Codfiscalsimpentfutinter";

    private decimal? _codfiscalsimpentfutinter;

    private static readonly string RO_CODFISCALSRESTSR = "Codfiscalsrestsr";

    private decimal? _codfiscalsrestsr;

    private static readonly string RO_CODFISCALSREXT = "Codfiscalsrext";

    private decimal? _codfiscalsrext;

    private static readonly string RO_CODFISCALSRINTE = "Codfiscalsrinte";

    private decimal? _codfiscalsrinte;

    private static readonly string RO_CODFISCALSUFRAMA = "Codfiscalsuframa";

    private decimal? _codfiscalsuframa;

    private static readonly string RO_CODFISCALSUFRAMAINTER = "Codfiscalsuframainter";

    private decimal? _codfiscalsuframainter;

    private static readonly string RO_CODFISCALTRANSF = "Codfiscaltransf";

    private decimal? _codfiscaltransf;

    private static readonly string RO_CODFISCALTRANSFENT = "Codfiscaltransfent";

    private decimal? _codfiscaltransfent;

    private static readonly string RO_CODFISCALTRANSFENTINTER = "Codfiscaltransfentinter";

    private decimal? _codfiscaltransfentinter;

    private static readonly string RO_CODFISCALTRANSFF = "Codfiscaltransff";

    private decimal? _codfiscaltransff;

    private static readonly string RO_CODFISCALTRANSFFINTER = "Codfiscaltransffinter";

    private decimal? _codfiscaltransffinter;

    private static readonly string RO_CODFISCALTRANSFFINTERNASC = "Codfiscaltransffinternasc";

    private decimal? _codfiscaltransffinternasc;

    private static readonly string RO_CODFISCALTRANSFINTER = "Codfiscaltransfinter";

    private decimal? _codfiscaltransfinter;

    private static readonly string RO_CODFISCALTRANSFINTERNASC = "Codfiscaltransfinternasc";

    private decimal? _codfiscaltransfinternasc;

    private static readonly string RO_CODFISCALTRANSFSAIDAEST = "Codfiscaltransfsaidaest";

    private decimal? _codfiscaltransfsaidaest;

    private static readonly string RO_CODFISCALTRANSFSAIDAINT = "Codfiscaltransfsaidaint";

    private decimal? _codfiscaltransfsaidaint;

    private static readonly string RO_CODFISCALTRIANGULAR = "Codfiscaltriangular";

    private decimal? _codfiscaltriangular;

    private static readonly string RO_CODFISCALTRIANGULARINTER = "Codfiscaltriangularinter";

    private decimal? _codfiscaltriangularinter;

    private static readonly string RO_CODFISCALTRIANGULARINTERNASC = "Codfiscaltriangularinternasc";

    private decimal? _codfiscaltriangularinternasc;

    private static readonly string RO_CODFISCALTRIANGULARINTERNASCPF = "Codfiscaltriangularinternascpf";

    private decimal? _codfiscaltriangularinternascpf;

    private static readonly string RO_CODFISCALTRIANGULARINTERPF = "Codfiscaltriangularinterpf";

    private decimal? _codfiscaltriangularinterpf;

    private static readonly string RO_CODFISCALTRIANGULARPF = "Codfiscaltriangularpf";

    private decimal? _codfiscaltriangularpf;

    private static readonly string RO_CODFISCALTROCA = "Codfiscaltroca";

    private decimal? _codfiscaltroca;

    private static readonly string RO_CODFISCALTROCAINTER = "Codfiscaltrocainter";

    private decimal? _codfiscaltrocainter;

    private static readonly string RO_CODFISCALTROCAINTERNASC = "Codfiscaltrocainternasc";

    private decimal? _codfiscaltrocainternasc;

    private static readonly string RO_CODFISCALTV9 = "Codfiscaltv9";

    private decimal? _codfiscaltv9;

    private static readonly string RO_CODFISCALVENDACONSIG = "Codfiscalvendaconsig";

    private decimal? _codfiscalvendaconsig;

    private static readonly string RO_CODFISCALVENDACONSIGINTER = "Codfiscalvendaconsiginter";

    private decimal? _codfiscalvendaconsiginter;

    private static readonly string RO_CODFISCALVENDACONSIGINTERNASC = "Codfiscalvendaconsiginternasc";

    private decimal? _codfiscalvendaconsiginternasc;

    private static readonly string RO_CODFISCALVENDAENTFUT = "Codfiscalvendaentfut";

    private decimal? _codfiscalvendaentfut;

    private static readonly string RO_CODFISCALVENDAENTFUTINTER = "Codfiscalvendaentfutinter";

    private decimal? _codfiscalvendaentfutinter;

    private static readonly string RO_CODFISCALVENDAPRONTAENT = "Codfiscalvendaprontaent";

    private decimal? _codfiscalvendaprontaent;

    private static readonly string RO_CODFISCALVENDAPRONTAENTINTER = "Codfiscalvendaprontaentinter";

    private decimal? _codfiscalvendaprontaentinter;

    private static readonly string RO_CODFUNCULTALTER = "Codfuncultalter";

    private decimal? _codfuncultalter;

    private static readonly string RO_CODICM = "Codicm";

    private decimal? _codicm;

    private static readonly string RO_CODICMANTECIPADO = "Codicmantecipado";

    private decimal? _codicmantecipado;

    private static readonly string RO_CODICMCONSUMIDOR = "Codicmconsumidor";

    private decimal? _codicmconsumidor;

    private static readonly string RO_CODICMNRPA = "Codicmnrpa";

    private decimal? _codicmnrpa;

    private static readonly string RO_CODICMPF = "Codicmpf";

    private decimal? _codicmpf;

    private static readonly string RO_CODICMPRODRURAL = "Codicmprodrural";

    private decimal? _codicmprodrural;

    private static readonly string RO_CODICMTAB = "Codicmtab";

    private decimal? _codicmtab;

    private static readonly string RO_CODICMTABNRPA = "Codicmtabnrpa";

    private decimal? _codicmtabnrpa;

    private static readonly string RO_CODICMTABPF = "Codicmtabpf";

    private decimal? _codicmtabpf;

    private static readonly string RO_CODICMTABTRANSF = "Codicmtabtransf";

    private decimal? _codicmtabtransf;

    private static readonly string RO_CODICMTRANSF = "Codicmtransf";

    private decimal? _codicmtransf;

    private static readonly string RO_CODST = "Codst";

    private decimal _codst;

    private static readonly string RO_DESCICMSREDUZBASEICMS = "Descicmsreduzbaseicms";

    private string _descicmsreduzbaseicms;

    private static readonly string RO_DTULTALTER = "Dtultalter";

    private DateTime? _dtultalter;

    private static readonly string RO_INDICEST = "Indicest";

    private decimal? _indicest;

    private static readonly string RO_ISENTAICMSBONIFIC = "Isentaicmsbonific";

    private string _isentaicmsbonific;

    private static readonly string RO_IVA = "Iva";

    private decimal? _iva;

    private static readonly string RO_IVAFONTE = "Ivafonte";

    private decimal? _ivafonte;

    private static readonly string RO_IVATAB = "Ivatab";

    private decimal? _ivatab;

    private static readonly string RO_IVATRANSF = "Ivatransf";

    private decimal? _ivatransf;

    private static readonly string RO_MENSAGEM = "Mensagem";

    private string _mensagem;

    private static readonly string RO_MENSAGEMNRPA = "Mensagemnrpa";

    private string _mensagemnrpa;

    private static readonly string RO_MENSAGEM2 = "Mensagem2";

    private string _mensagem2;

    private static readonly string RO_MOSTRARPVENDASEMST = "Mostrarpvendasemst";

    private string _mostrarpvendasemst;

    private static readonly string RO_NUMSEQATU = "Numseqatu";

    private decimal? _numseqatu;

    private static readonly string RO_OBS = "Obs";

    private string _obs;

    private static readonly string RO_OBS_INFORMATIVO = "Obs_Informativo";

    private string _obs_informativo;

    private static readonly string RO_OBSPF = "Obspf";

    private string _obspf;

    private static readonly string RO_OBSPF2 = "Obspf2";

    private string _obspf2;

    private static readonly string RO_OBSSIMPLES = "Obssimples";

    private string _obssimples;

    private static readonly string RO_OBSSUFRAMA = "Obssuframa";

    private string _obssuframa;

    private static readonly string RO_OBSTRANSF = "Obstransf";

    private string _obstransf;

    private static readonly string RO_OBSTRIBUT_GNRE = "Obstribut_Gnre";

    private string _obstribut_gnre;

    private static readonly string RO_OBS2 = "Obs2";

    private string _obs2;

    private static readonly string RO_PAGTONOMEDESTTRANSF = "Pagtonomedesttransf";

    private string _pagtonomedesttransf;

    private static readonly string RO_PAGTONOMEDESTTRANSFTAB = "Pagtonomedesttransftab";

    private string _pagtonomedesttransftab;

    private static readonly string RO_PAGTONOMEDOCLIENTE = "Pagtonomedocliente";

    private string _pagtonomedocliente;

    private static readonly string RO_PAGTONOMEDOREMETENTE = "Pagtonomedoremetente";

    private string _pagtonomedoremetente;

    private static readonly string RO_PAGTONOMEREMETTRANSF = "Pagtonomeremettransf";

    private string _pagtonomeremettransf;

    private static readonly string RO_PAGTONOMEREMETTRANSFTAB = "Pagtonomeremettransftab";

    private string _pagtonomeremettransftab;

    private static readonly string RO_PAUTA = "Pauta";

    private decimal? _pauta;

    private static readonly string RO_PAUTATAB = "Pautatab";

    private decimal? _pautatab;

    private static readonly string RO_PAUTATRANSF = "Pautatransf";

    private decimal? _pautatransf;

    private static readonly string RO_PERACRESCIMOCUSTO = "Peracrescimocusto";

    private decimal? _peracrescimocusto;

    private static readonly string RO_PERACRESCIMOFUNCEP = "Peracrescimofuncep";

    private decimal? _peracrescimofuncep;

    private static readonly string RO_PERACRESCIMONRPA = "Peracrescimonrpa";

    private decimal? _peracrescimonrpa;

    private static readonly string RO_PERACRESCIMOPF = "Peracrescimopf";

    private decimal? _peracrescimopf;

    private static readonly string RO_PERACRESCISMOPF = "Peracrescismopf";

    private decimal? _peracrescismopf;

    private static readonly string RO_PERBASEREDNRPA = "Perbaserednrpa";

    private decimal? _perbaserednrpa;

    private static readonly string RO_PERBASEREDTRANSFENT = "Perbaseredtransfent";

    private decimal? _perbaseredtransfent;

    private static readonly string RO_PERCACREPFVLACIMAPERMITIDO = "Percacrepfvlacimapermitido";

    private decimal? _percacrepfvlacimapermitido;

    private static readonly string RO_PERCACRESCBASEPFEST = "Percacrescbasepfest";

    private decimal? _percacrescbasepfest;

    private static readonly string RO_PERCACRESCBASEPFINT = "Percacrescbasepfint";

    private decimal? _percacrescbasepfint;

    private static readonly string RO_PERCAGREGADORST = "Percagregadorst";

    private decimal? _percagregadorst;

    private static readonly string RO_PERCBASECALCREPASSE = "Percbasecalcrepasse";

    private decimal? _percbasecalcrepasse;

    private static readonly string RO_PERCBASERED = "Percbasered";

    private decimal? _percbasered;

    private static readonly string RO_PERCBASEREDADICIONAL = "Percbaseredadicional";

    private decimal? _percbaseredadicional;

    private static readonly string RO_PERCBASEREDADICIONALINTER = "Percbaseredadicionalinter";

    private decimal? _percbaseredadicionalinter;

    private static readonly string RO_PERCBASEREDCONSUMIDOR = "Percbaseredconsumidor";

    private decimal? _percbaseredconsumidor;

    private static readonly string RO_PERCBASEREDST = "Percbaseredst";

    private decimal? _percbaseredst;

    private static readonly string RO_PERCBASEREDSTFONTE = "Percbaseredstfonte";

    private decimal? _percbaseredstfonte;

    private static readonly string RO_PERCBASEREDSTTRANSF = "Percbaseredsttransf";

    private decimal? _percbaseredsttransf;

    private static readonly string RO_PERCBASEREDTRANFSAID = "Percbaseredtranfsaid";

    private decimal? _percbaseredtranfsaid;

    private static readonly string RO_PERCDESCCOFINS = "Percdesccofins";

    private decimal? _percdesccofins;

    private static readonly string RO_PERCDESCPIS = "Percdescpis";

    private decimal? _percdescpis;

    private static readonly string RO_PERCDIFALIQUOTAS = "Percdifaliquotas";

    private decimal? _percdifaliquotas;

    private static readonly string RO_PERCDIFALIQUOTASTAB = "Percdifaliquotastab";

    private decimal? _percdifaliquotastab;

    private static readonly string RO_PERCICMSCOMPLEMENTAR = "Percicmscomplementar";

    private decimal? _percicmscomplementar;

    private static readonly string RO_PERCIVAMEX = "Percivamex";

    private decimal? _percivamex;

    private static readonly string RO_PERCIVAPAUTA = "Percivapauta";

    private decimal? _percivapauta;

    private static readonly string RO_PERCREDPVENDASIMPLESNAC = "Percredpvendasimplesnac";

    private decimal? _percredpvendasimplesnac;

    private static readonly string RO_PERDESCCUSTO = "Perdesccusto";

    private decimal? _perdesccusto;

    private static readonly string RO_PERDESCCUSTOTRANSF = "Perdesccustotransf";

    private decimal? _perdesccustotransf;

    private static readonly string RO_PERDESCICMISENCAO = "Perdescicmisencao";

    private decimal? _perdescicmisencao;

    private static readonly string RO_PERDESCPISSUFRAMA = "Perdescpissuframa";

    private decimal? _perdescpissuframa;

    private static readonly string RO_PERDESCREPASSE = "Perdescrepasse";

    private decimal? _perdescrepasse;

    private static readonly string RO_PERDESCSUFRAMA = "Perdescsuframa";

    private decimal? _perdescsuframa;

    private static readonly string RO_PERDESTAB = "Perdestab";

    private decimal? _perdestab;

    private static readonly string RO_PERDIFEREIMENTOICMS = "Perdifereimentoicms";

    private decimal? _perdifereimentoicms;

    private static readonly string RO_PERPAUTAICMS = "Perpautaicms";

    private decimal? _perpautaicms;

    private static readonly string RO_PERPAUTAICMSINTER = "Perpautaicmsinter";

    private decimal? _perpautaicmsinter;

    private static readonly string RO_REDUZBASEICMDECRETOMARANHAO = "Reduzbaseicmdecretomaranhao";

    private string _reduzbaseicmdecretomaranhao;

    private static readonly string RO_SITTRIBUT = "Sittribut";

    private string _sittribut;

    private static readonly string RO_SITTRIBUTBONIFIC = "Sittributbonific";

    private string _sittributbonific;

    private static readonly string RO_SITTRIBUTECF = "Sittributecf";

    private string _sittributecf;

    private static readonly string RO_SITTRIBUTISENTOST = "Sittributisentost";

    private string _sittributisentost;

    private static readonly string RO_SITTRIBUTNRPA = "Sittributnrpa";

    private string _sittributnrpa;

    private static readonly string RO_SITTRIBUTPF = "Sittributpf";

    private string _sittributpf;

    private static readonly string RO_SITTRIBUTSUFRAMA = "Sittributsuframa";

    private string _sittributsuframa;

    private static readonly string RO_SITTRIBUTTRANSF = "Sittributtransf";

    private string _sittributtransf;

    private static readonly string RO_SITTRIBUTTRANSFENT = "Sittributtransfent";

    private string _sittributtransfent;

    private static readonly string RO_SITTRIBUTTV7 = "Sittributtv7";

    private string _sittributtv7;

    private static readonly string RO_SITTRIBUTTV8 = "Sittributtv8";

    private string _sittributtv8;

    private static readonly string RO_TIPOCALCULOGNRE = "Tipocalculognre";

    private string _tipocalculognre;

    private static readonly string RO_TIPOCALCULOGNRETAB = "Tipocalculognretab";

    private string _tipocalculognretab;

    private static readonly string RO_TIPOCALCULOGNRETRANSF = "Tipocalculognretransf";

    private string _tipocalculognretransf;

    private static readonly string RO_TIPOCALCULOGNRETRANSFTAB = "Tipocalculognretransftab";

    private string _tipocalculognretransftab;

    private static readonly string RO_USABASEICMSREDUZIDA = "Usabaseicmsreduzida";

    private string _usabaseicmsreduzida;

    private static readonly string RO_USACFOPBNFPARABRINDE = "Usacfopbnfparabrinde";

    private string _usacfopbnfparabrinde;

    private static readonly string RO_USAISENCAOICMSVP = "Usaisencaoicmsvp";

    private string _usaisencaoicmsvp;

    private static readonly string RO_USAPAUTASEMIVA = "Usapautasemiva";

    private string _usapautasemiva;

    private static readonly string RO_USAPERCBASEREDASSOC = "Usapercbaseredassoc";

    private string _usapercbaseredassoc;

    private static readonly string RO_USAPERCBASEREDDIST = "Usapercbasereddist";

    private string _usapercbasereddist;

    private static readonly string RO_USAPERCBASEREDFARMA = "Usapercbaseredfarma";

    private string _usapercbaseredfarma;

    private static readonly string RO_USAPERCBASEREDHOSP = "Usapercbaseredhosp";

    private string _usapercbaseredhosp;

    private static readonly string RO_USAPERCBASEREDMEDICO = "Usapercbaseredmedico";

    private string _usapercbaseredmedico;

    private static readonly string RO_USAPERCBASEREDOPE = "Usapercbaseredope";

    private string _usapercbaseredope;

    private static readonly string RO_USAPERCBASEREDOPF = "Usapercbaseredopf";

    private string _usapercbaseredopf;

    private static readonly string RO_USAPERCBASEREDOPM = "Usapercbaseredopm";

    private string _usapercbaseredopm;

    private static readonly string RO_USAPMCBASEST = "Usapmcbasest";

    private string _usapmcbasest;

    private static readonly string RO_USAREDBASEICMSFONTEST = "Usaredbaseicmsfontest";

    private string _usaredbaseicmsfontest;

    private static readonly string RO_USAVALORULTENTBASEST = "Usavalorultentbasest";

    private string _usavalorultentbasest;

    private static readonly string RO_USAVALORULTENTBASEST2 = "Usavalorultentbasest2";

    private string _usavalorultentbasest2;

    private static readonly string RO_UTILIZAPARCADICFECP = "Utilizaparcadicfecp";

    private string _utilizaparcadicfecp;

    private static readonly string RO_UTILIZAPERCBASEREDPF = "Utilizapercbaseredpf";

    private string _utilizapercbaseredpf;

    private static readonly string RO_VLPAUTASEMIVA = "Vlpautasemiva";

    private decimal? _vlpautasemiva;

    private static readonly string RO_ZERARBASEICMSORGPUBSUFRAMA = "Zerarbaseicmsorgpubsuframa";

    private string _zerarbaseicmsorgpubsuframa;

    private static readonly string RO_PERCTRIBUTOS = "Perctributos";

    private decimal? _perctributos;

    private static readonly string RO_GERARICMSLIVROFISCAL = "Geraricmslivrofiscal";

    private string _geraricmslivrofiscal;

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Aliqicmsfecp
    {
        get
        {
            PropriedadeAcessada(RO_ALIQICMSFECP);
            return _aliqicmsfecp;
        }
        set
        {
            PropriedadeModificada(RO_ALIQICMSFECP, value);
            _aliqicmsfecp = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Aliqicmstv9
    {
        get
        {
            PropriedadeAcessada(RO_ALIQICMSTV9);
            return _aliqicmstv9;
        }
        set
        {
            PropriedadeModificada(RO_ALIQICMSTV9, value);
            _aliqicmstv9 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Aliqicms1fonte
    {
        get
        {
            PropriedadeAcessada(RO_ALIQICMS1FONTE);
            return _aliqicms1fonte;
        }
        set
        {
            PropriedadeModificada(RO_ALIQICMS1FONTE, value);
            _aliqicms1fonte = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Aliqicms1tab
    {
        get
        {
            PropriedadeAcessada(RO_ALIQICMS1TAB);
            return _aliqicms1tab;
        }
        set
        {
            PropriedadeModificada(RO_ALIQICMS1TAB, value);
            _aliqicms1tab = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Aliqicms1transf
    {
        get
        {
            PropriedadeAcessada(RO_ALIQICMS1TRANSF);
            return _aliqicms1transf;
        }
        set
        {
            PropriedadeModificada(RO_ALIQICMS1TRANSF, value);
            _aliqicms1transf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Aliqicms2fonte
    {
        get
        {
            PropriedadeAcessada(RO_ALIQICMS2FONTE);
            return _aliqicms2fonte;
        }
        set
        {
            PropriedadeModificada(RO_ALIQICMS2FONTE, value);
            _aliqicms2fonte = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Aliqicms2tab
    {
        get
        {
            PropriedadeAcessada(RO_ALIQICMS2TAB);
            return _aliqicms2tab;
        }
        set
        {
            PropriedadeModificada(RO_ALIQICMS2TAB, value);
            _aliqicms2tab = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Aliqicms2transf
    {
        get
        {
            PropriedadeAcessada(RO_ALIQICMS2TRANSF);
            return _aliqicms2transf;
        }
        set
        {
            PropriedadeModificada(RO_ALIQICMS2TRANSF, value);
            _aliqicms2transf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Aliqiss
    {
        get
        {
            PropriedadeAcessada(RO_ALIQISS);
            return _aliqiss;
        }
        set
        {
            PropriedadeModificada(RO_ALIQISS, value);
            _aliqiss = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Aliqstsaidapf
    {
        get
        {
            PropriedadeAcessada(RO_ALIQSTSAIDAPF);
            return _aliqstsaidapf;
        }
        set
        {
            PropriedadeModificada(RO_ALIQSTSAIDAPF, value);
            _aliqstsaidapf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Aliquotaicmsenttransf
    {
        get
        {
            PropriedadeAcessada(RO_ALIQUOTAICMSENTTRANSF);
            return _aliquotaicmsenttransf;
        }
        set
        {
            PropriedadeModificada(RO_ALIQUOTAICMSENTTRANSF, value);
            _aliquotaicmsenttransf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Aplicaacrescpjisenta
    {
        get
        {
            PropriedadeAcessada(RO_APLICAACRESCPJISENTA);
            return _aplicaacrescpjisenta;
        }
        set
        {
            PropriedadeModificada(RO_APLICAACRESCPJISENTA, value);
            _aplicaacrescpjisenta = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 255, Precisao = 0)]
    public string Assinatura
    {
        get
        {
            PropriedadeAcessada(RO_ASSINATURA);
            return _assinatura;
        }
        set
        {
            PropriedadeModificada(RO_ASSINATURA, value);
            _assinatura = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Calcbaseredicmstransf
    {
        get
        {
            PropriedadeAcessada(RO_CALCBASEREDICMSTRANSF);
            return _calcbaseredicmstransf;
        }
        set
        {
            PropriedadeModificada(RO_CALCBASEREDICMSTRANSF, value);
            _calcbaseredicmstransf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Calcbcicmsnf
    {
        get
        {
            PropriedadeAcessada(RO_CALCBCICMSNF);
            return _calcbcicmsnf;
        }
        set
        {
            PropriedadeModificada(RO_CALCBCICMSNF, value);
            _calcbcicmsnf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Calcsttransf
    {
        get
        {
            PropriedadeAcessada(RO_CALCSTTRANSF);
            return _calcsttransf;
        }
        set
        {
            PropriedadeModificada(RO_CALCSTTRANSF, value);
            _calcsttransf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Calcularicmssittribut060
    {
        get
        {
            PropriedadeAcessada(RO_CALCULARICMSSITTRIBUT060);
            return _calcularicmssittribut060;
        }
        set
        {
            PropriedadeModificada(RO_CALCULARICMSSITTRIBUT060, value);
            _calcularicmssittribut060 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 4, Precisao = 0)]
    public string Codecffuncep
    {
        get
        {
            PropriedadeAcessada(RO_CODECFFUNCEP);
            return _codecffuncep;
        }
        set
        {
            PropriedadeModificada(RO_CODECFFUNCEP, value);
            _codecffuncep = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfiscalbonific
    {
        get
        {
            PropriedadeAcessada(RO_CODFISCALBONIFIC);
            return _codfiscalbonific;
        }
        set
        {
            PropriedadeModificada(RO_CODFISCALBONIFIC, value);
            _codfiscalbonific = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfiscalbonificinter
    {
        get
        {
            PropriedadeAcessada(RO_CODFISCALBONIFICINTER);
            return _codfiscalbonificinter;
        }
        set
        {
            PropriedadeModificada(RO_CODFISCALBONIFICINTER, value);
            _codfiscalbonificinter = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfiscalbonificinternasc
    {
        get
        {
            PropriedadeAcessada(RO_CODFISCALBONIFICINTERNASC);
            return _codfiscalbonificinternasc;
        }
        set
        {
            PropriedadeModificada(RO_CODFISCALBONIFICINTERNASC, value);
            _codfiscalbonificinternasc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfiscalbrokerdevent
    {
        get
        {
            PropriedadeAcessada(RO_CODFISCALBROKERDEVENT);
            return _codfiscalbrokerdevent;
        }
        set
        {
            PropriedadeModificada(RO_CODFISCALBROKERDEVENT, value);
            _codfiscalbrokerdevent = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfiscalbrokerdevsaid
    {
        get
        {
            PropriedadeAcessada(RO_CODFISCALBROKERDEVSAID);
            return _codfiscalbrokerdevsaid;
        }
        set
        {
            PropriedadeModificada(RO_CODFISCALBROKERDEVSAID, value);
            _codfiscalbrokerdevsaid = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfiscalbrokerent
    {
        get
        {
            PropriedadeAcessada(RO_CODFISCALBROKERENT);
            return _codfiscalbrokerent;
        }
        set
        {
            PropriedadeModificada(RO_CODFISCALBROKERENT, value);
            _codfiscalbrokerent = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfiscalbrokersaid
    {
        get
        {
            PropriedadeAcessada(RO_CODFISCALBROKERSAID);
            return _codfiscalbrokersaid;
        }
        set
        {
            PropriedadeModificada(RO_CODFISCALBROKERSAID, value);
            _codfiscalbrokersaid = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfiscalconsig
    {
        get
        {
            PropriedadeAcessada(RO_CODFISCALCONSIG);
            return _codfiscalconsig;
        }
        set
        {
            PropriedadeModificada(RO_CODFISCALCONSIG, value);
            _codfiscalconsig = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfiscalconsiginter
    {
        get
        {
            PropriedadeAcessada(RO_CODFISCALCONSIGINTER);
            return _codfiscalconsiginter;
        }
        set
        {
            PropriedadeModificada(RO_CODFISCALCONSIGINTER, value);
            _codfiscalconsiginter = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfiscalconsiginternac
    {
        get
        {
            PropriedadeAcessada(RO_CODFISCALCONSIGINTERNAC);
            return _codfiscalconsiginternac;
        }
        set
        {
            PropriedadeModificada(RO_CODFISCALCONSIGINTERNAC, value);
            _codfiscalconsiginternac = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfiscalcontaordem
    {
        get
        {
            PropriedadeAcessada(RO_CODFISCALCONTAORDEM);
            return _codfiscalcontaordem;
        }
        set
        {
            PropriedadeModificada(RO_CODFISCALCONTAORDEM, value);
            _codfiscalcontaordem = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfiscalcontaordeminter
    {
        get
        {
            PropriedadeAcessada(RO_CODFISCALCONTAORDEMINTER);
            return _codfiscalcontaordeminter;
        }
        set
        {
            PropriedadeModificada(RO_CODFISCALCONTAORDEMINTER, value);
            _codfiscalcontaordeminter = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfiscalcontaordemsimpent
    {
        get
        {
            PropriedadeAcessada(RO_CODFISCALCONTAORDEMSIMPENT);
            return _codfiscalcontaordemsimpent;
        }
        set
        {
            PropriedadeModificada(RO_CODFISCALCONTAORDEMSIMPENT, value);
            _codfiscalcontaordemsimpent = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfiscalcontaordemsimpentinte
    {
        get
        {
            PropriedadeAcessada(RO_CODFISCALCONTAORDEMSIMPENTINTE);
            return _codfiscalcontaordemsimpentinte;
        }
        set
        {
            PropriedadeModificada(RO_CODFISCALCONTAORDEMSIMPENTINTE, value);
            _codfiscalcontaordemsimpentinte = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfiscaldevcli
    {
        get
        {
            PropriedadeAcessada(RO_CODFISCALDEVCLI);
            return _codfiscaldevcli;
        }
        set
        {
            PropriedadeModificada(RO_CODFISCALDEVCLI, value);
            _codfiscaldevcli = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfiscaldevclibonific
    {
        get
        {
            PropriedadeAcessada(RO_CODFISCALDEVCLIBONIFIC);
            return _codfiscaldevclibonific;
        }
        set
        {
            PropriedadeModificada(RO_CODFISCALDEVCLIBONIFIC, value);
            _codfiscaldevclibonific = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfiscaldevclibonificinter
    {
        get
        {
            PropriedadeAcessada(RO_CODFISCALDEVCLIBONIFICINTER);
            return _codfiscaldevclibonificinter;
        }
        set
        {
            PropriedadeModificada(RO_CODFISCALDEVCLIBONIFICINTER, value);
            _codfiscaldevclibonificinter = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfiscaldevcliboninternasc
    {
        get
        {
            PropriedadeAcessada(RO_CODFISCALDEVCLIBONINTERNASC);
            return _codfiscaldevcliboninternasc;
        }
        set
        {
            PropriedadeModificada(RO_CODFISCALDEVCLIBONINTERNASC, value);
            _codfiscaldevcliboninternasc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfiscaldevcliinter
    {
        get
        {
            PropriedadeAcessada(RO_CODFISCALDEVCLIINTER);
            return _codfiscaldevcliinter;
        }
        set
        {
            PropriedadeModificada(RO_CODFISCALDEVCLIINTER, value);
            _codfiscaldevcliinter = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfiscaldevcliinternasc
    {
        get
        {
            PropriedadeAcessada(RO_CODFISCALDEVCLIINTERNASC);
            return _codfiscaldevcliinternasc;
        }
        set
        {
            PropriedadeModificada(RO_CODFISCALDEVCLIINTERNASC, value);
            _codfiscaldevcliinternasc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfiscaldevclipf
    {
        get
        {
            PropriedadeAcessada(RO_CODFISCALDEVCLIPF);
            return _codfiscaldevclipf;
        }
        set
        {
            PropriedadeModificada(RO_CODFISCALDEVCLIPF, value);
            _codfiscaldevclipf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfiscaldevclipfinter
    {
        get
        {
            PropriedadeAcessada(RO_CODFISCALDEVCLIPFINTER);
            return _codfiscaldevclipfinter;
        }
        set
        {
            PropriedadeModificada(RO_CODFISCALDEVCLIPFINTER, value);
            _codfiscaldevclipfinter = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfiscaldevclipfinternasc
    {
        get
        {
            PropriedadeAcessada(RO_CODFISCALDEVCLIPFINTERNASC);
            return _codfiscaldevclipfinternasc;
        }
        set
        {
            PropriedadeModificada(RO_CODFISCALDEVCLIPFINTERNASC, value);
            _codfiscaldevclipfinternasc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfiscaldevcliproentinternasc
    {
        get
        {
            PropriedadeAcessada(RO_CODFISCALDEVCLIPROENTINTERNASC);
            return _codfiscaldevcliproentinternasc;
        }
        set
        {
            PropriedadeModificada(RO_CODFISCALDEVCLIPROENTINTERNASC, value);
            _codfiscaldevcliproentinternasc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfiscaldevcliprontaent
    {
        get
        {
            PropriedadeAcessada(RO_CODFISCALDEVCLIPRONTAENT);
            return _codfiscaldevcliprontaent;
        }
        set
        {
            PropriedadeModificada(RO_CODFISCALDEVCLIPRONTAENT, value);
            _codfiscaldevcliprontaent = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfiscaldevcliprontaentinter
    {
        get
        {
            PropriedadeAcessada(RO_CODFISCALDEVCLIPRONTAENTINTER);
            return _codfiscaldevcliprontaentinter;
        }
        set
        {
            PropriedadeModificada(RO_CODFISCALDEVCLIPRONTAENTINTER, value);
            _codfiscaldevcliprontaentinter = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfiscaldevcomodatoest
    {
        get
        {
            PropriedadeAcessada(RO_CODFISCALDEVCOMODATOEST);
            return _codfiscaldevcomodatoest;
        }
        set
        {
            PropriedadeModificada(RO_CODFISCALDEVCOMODATOEST, value);
            _codfiscaldevcomodatoest = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfiscaldevcomodatointer
    {
        get
        {
            PropriedadeAcessada(RO_CODFISCALDEVCOMODATOINTER);
            return _codfiscaldevcomodatointer;
        }
        set
        {
            PropriedadeModificada(RO_CODFISCALDEVCOMODATOINTER, value);
            _codfiscaldevcomodatointer = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfiscaldevisentost
    {
        get
        {
            PropriedadeAcessada(RO_CODFISCALDEVISENTOST);
            return _codfiscaldevisentost;
        }
        set
        {
            PropriedadeModificada(RO_CODFISCALDEVISENTOST, value);
            _codfiscaldevisentost = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfiscaldevisentostinter
    {
        get
        {
            PropriedadeAcessada(RO_CODFISCALDEVISENTOSTINTER);
            return _codfiscaldevisentostinter;
        }
        set
        {
            PropriedadeModificada(RO_CODFISCALDEVISENTOSTINTER, value);
            _codfiscaldevisentostinter = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfiscaldevisentostinternasc
    {
        get
        {
            PropriedadeAcessada(RO_CODFISCALDEVISENTOSTINTERNASC);
            return _codfiscaldevisentostinternasc;
        }
        set
        {
            PropriedadeModificada(RO_CODFISCALDEVISENTOSTINTERNASC, value);
            _codfiscaldevisentostinternasc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfiscaldevmercconsig
    {
        get
        {
            PropriedadeAcessada(RO_CODFISCALDEVMERCCONSIG);
            return _codfiscaldevmercconsig;
        }
        set
        {
            PropriedadeModificada(RO_CODFISCALDEVMERCCONSIG, value);
            _codfiscaldevmercconsig = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfiscaldevmercconsiginter
    {
        get
        {
            PropriedadeAcessada(RO_CODFISCALDEVMERCCONSIGINTER);
            return _codfiscaldevmercconsiginter;
        }
        set
        {
            PropriedadeModificada(RO_CODFISCALDEVMERCCONSIGINTER, value);
            _codfiscaldevmercconsiginter = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfiscaldevtransf
    {
        get
        {
            PropriedadeAcessada(RO_CODFISCALDEVTRANSF);
            return _codfiscaldevtransf;
        }
        set
        {
            PropriedadeModificada(RO_CODFISCALDEVTRANSF, value);
            _codfiscaldevtransf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfiscaldevtransfent
    {
        get
        {
            PropriedadeAcessada(RO_CODFISCALDEVTRANSFENT);
            return _codfiscaldevtransfent;
        }
        set
        {
            PropriedadeModificada(RO_CODFISCALDEVTRANSFENT, value);
            _codfiscaldevtransfent = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfiscaldevtransfentinter
    {
        get
        {
            PropriedadeAcessada(RO_CODFISCALDEVTRANSFENTINTER);
            return _codfiscaldevtransfentinter;
        }
        set
        {
            PropriedadeModificada(RO_CODFISCALDEVTRANSFENTINTER, value);
            _codfiscaldevtransfentinter = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfiscaldevtransfinter
    {
        get
        {
            PropriedadeAcessada(RO_CODFISCALDEVTRANSFINTER);
            return _codfiscaldevtransfinter;
        }
        set
        {
            PropriedadeModificada(RO_CODFISCALDEVTRANSFINTER, value);
            _codfiscaldevtransfinter = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfiscalentbeneficest
    {
        get
        {
            PropriedadeAcessada(RO_CODFISCALENTBENEFICEST);
            return _codfiscalentbeneficest;
        }
        set
        {
            PropriedadeModificada(RO_CODFISCALENTBENEFICEST, value);
            _codfiscalentbeneficest = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfiscalentbeneficinterest
    {
        get
        {
            PropriedadeAcessada(RO_CODFISCALENTBENEFICINTEREST);
            return _codfiscalentbeneficinterest;
        }
        set
        {
            PropriedadeModificada(RO_CODFISCALENTBENEFICINTEREST, value);
            _codfiscalentbeneficinterest = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfiscalentbenefinternac
    {
        get
        {
            PropriedadeAcessada(RO_CODFISCALENTBENEFINTERNAC);
            return _codfiscalentbenefinternac;
        }
        set
        {
            PropriedadeModificada(RO_CODFISCALENTBENEFINTERNAC, value);
            _codfiscalentbenefinternac = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfiscalenvcomodatoest
    {
        get
        {
            PropriedadeAcessada(RO_CODFISCALENVCOMODATOEST);
            return _codfiscalenvcomodatoest;
        }
        set
        {
            PropriedadeModificada(RO_CODFISCALENVCOMODATOEST, value);
            _codfiscalenvcomodatoest = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfiscalenvcomodatointer
    {
        get
        {
            PropriedadeAcessada(RO_CODFISCALENVCOMODATOINTER);
            return _codfiscalenvcomodatointer;
        }
        set
        {
            PropriedadeModificada(RO_CODFISCALENVCOMODATOINTER, value);
            _codfiscalenvcomodatointer = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfiscalinter
    {
        get
        {
            PropriedadeAcessada(RO_CODFISCALINTER);
            return _codfiscalinter;
        }
        set
        {
            PropriedadeModificada(RO_CODFISCALINTER, value);
            _codfiscalinter = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfiscalinternasc
    {
        get
        {
            PropriedadeAcessada(RO_CODFISCALINTERNASC);
            return _codfiscalinternasc;
        }
        set
        {
            PropriedadeModificada(RO_CODFISCALINTERNASC, value);
            _codfiscalinternasc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfiscalinternascpf
    {
        get
        {
            PropriedadeAcessada(RO_CODFISCALINTERNASCPF);
            return _codfiscalinternascpf;
        }
        set
        {
            PropriedadeModificada(RO_CODFISCALINTERNASCPF, value);
            _codfiscalinternascpf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfiscalinternasctv9
    {
        get
        {
            PropriedadeAcessada(RO_CODFISCALINTERNASCTV9);
            return _codfiscalinternasctv9;
        }
        set
        {
            PropriedadeModificada(RO_CODFISCALINTERNASCTV9, value);
            _codfiscalinternasctv9 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfiscalinterpf
    {
        get
        {
            PropriedadeAcessada(RO_CODFISCALINTERPF);
            return _codfiscalinterpf;
        }
        set
        {
            PropriedadeModificada(RO_CODFISCALINTERPF, value);
            _codfiscalinterpf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfiscalintertv9
    {
        get
        {
            PropriedadeAcessada(RO_CODFISCALINTERTV9);
            return _codfiscalintertv9;
        }
        set
        {
            PropriedadeModificada(RO_CODFISCALINTERTV9, value);
            _codfiscalintertv9 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfiscalisentost
    {
        get
        {
            PropriedadeAcessada(RO_CODFISCALISENTOST);
            return _codfiscalisentost;
        }
        set
        {
            PropriedadeModificada(RO_CODFISCALISENTOST, value);
            _codfiscalisentost = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfiscalisentostinter
    {
        get
        {
            PropriedadeAcessada(RO_CODFISCALISENTOSTINTER);
            return _codfiscalisentostinter;
        }
        set
        {
            PropriedadeModificada(RO_CODFISCALISENTOSTINTER, value);
            _codfiscalisentostinter = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfiscalisentostinternasc
    {
        get
        {
            PropriedadeAcessada(RO_CODFISCALISENTOSTINTERNASC);
            return _codfiscalisentostinternasc;
        }
        set
        {
            PropriedadeModificada(RO_CODFISCALISENTOSTINTERNASC, value);
            _codfiscalisentostinternasc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfiscalmercconsig
    {
        get
        {
            PropriedadeAcessada(RO_CODFISCALMERCCONSIG);
            return _codfiscalmercconsig;
        }
        set
        {
            PropriedadeModificada(RO_CODFISCALMERCCONSIG, value);
            _codfiscalmercconsig = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfiscalmercconsiginter
    {
        get
        {
            PropriedadeAcessada(RO_CODFISCALMERCCONSIGINTER);
            return _codfiscalmercconsiginter;
        }
        set
        {
            PropriedadeModificada(RO_CODFISCALMERCCONSIGINTER, value);
            _codfiscalmercconsiginter = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfiscalmercconsiginternasc
    {
        get
        {
            PropriedadeAcessada(RO_CODFISCALMERCCONSIGINTERNASC);
            return _codfiscalmercconsiginternasc;
        }
        set
        {
            PropriedadeModificada(RO_CODFISCALMERCCONSIGINTERNASC, value);
            _codfiscalmercconsiginternasc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfiscalpf
    {
        get
        {
            PropriedadeAcessada(RO_CODFISCALPF);
            return _codfiscalpf;
        }
        set
        {
            PropriedadeModificada(RO_CODFISCALPF, value);
            _codfiscalpf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfiscalprontaent
    {
        get
        {
            PropriedadeAcessada(RO_CODFISCALPRONTAENT);
            return _codfiscalprontaent;
        }
        set
        {
            PropriedadeModificada(RO_CODFISCALPRONTAENT, value);
            _codfiscalprontaent = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfiscalprontaentinter
    {
        get
        {
            PropriedadeAcessada(RO_CODFISCALPRONTAENTINTER);
            return _codfiscalprontaentinter;
        }
        set
        {
            PropriedadeModificada(RO_CODFISCALPRONTAENTINTER, value);
            _codfiscalprontaentinter = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfiscalprontaentinternasc
    {
        get
        {
            PropriedadeAcessada(RO_CODFISCALPRONTAENTINTERNASC);
            return _codfiscalprontaentinternasc;
        }
        set
        {
            PropriedadeModificada(RO_CODFISCALPRONTAENTINTERNASC, value);
            _codfiscalprontaentinternasc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfiscalsaidbenefest
    {
        get
        {
            PropriedadeAcessada(RO_CODFISCALSAIDBENEFEST);
            return _codfiscalsaidbenefest;
        }
        set
        {
            PropriedadeModificada(RO_CODFISCALSAIDBENEFEST, value);
            _codfiscalsaidbenefest = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfiscalsaidbenefinterest
    {
        get
        {
            PropriedadeAcessada(RO_CODFISCALSAIDBENEFINTEREST);
            return _codfiscalsaidbenefinterest;
        }
        set
        {
            PropriedadeModificada(RO_CODFISCALSAIDBENEFINTEREST, value);
            _codfiscalsaidbenefinterest = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfiscalsaidbenefinternac
    {
        get
        {
            PropriedadeAcessada(RO_CODFISCALSAIDBENEFINTERNAC);
            return _codfiscalsaidbenefinternac;
        }
        set
        {
            PropriedadeModificada(RO_CODFISCALSAIDBENEFINTERNAC, value);
            _codfiscalsaidbenefinternac = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfiscalsimpentfut
    {
        get
        {
            PropriedadeAcessada(RO_CODFISCALSIMPENTFUT);
            return _codfiscalsimpentfut;
        }
        set
        {
            PropriedadeModificada(RO_CODFISCALSIMPENTFUT, value);
            _codfiscalsimpentfut = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfiscalsimpentfutinter
    {
        get
        {
            PropriedadeAcessada(RO_CODFISCALSIMPENTFUTINTER);
            return _codfiscalsimpentfutinter;
        }
        set
        {
            PropriedadeModificada(RO_CODFISCALSIMPENTFUTINTER, value);
            _codfiscalsimpentfutinter = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfiscalsrestsr
    {
        get
        {
            PropriedadeAcessada(RO_CODFISCALSRESTSR);
            return _codfiscalsrestsr;
        }
        set
        {
            PropriedadeModificada(RO_CODFISCALSRESTSR, value);
            _codfiscalsrestsr = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfiscalsrext
    {
        get
        {
            PropriedadeAcessada(RO_CODFISCALSREXT);
            return _codfiscalsrext;
        }
        set
        {
            PropriedadeModificada(RO_CODFISCALSREXT, value);
            _codfiscalsrext = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfiscalsrinte
    {
        get
        {
            PropriedadeAcessada(RO_CODFISCALSRINTE);
            return _codfiscalsrinte;
        }
        set
        {
            PropriedadeModificada(RO_CODFISCALSRINTE, value);
            _codfiscalsrinte = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codfiscalsuframa
    {
        get
        {
            PropriedadeAcessada(RO_CODFISCALSUFRAMA);
            return _codfiscalsuframa;
        }
        set
        {
            PropriedadeModificada(RO_CODFISCALSUFRAMA, value);
            _codfiscalsuframa = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfiscalsuframainter
    {
        get
        {
            PropriedadeAcessada(RO_CODFISCALSUFRAMAINTER);
            return _codfiscalsuframainter;
        }
        set
        {
            PropriedadeModificada(RO_CODFISCALSUFRAMAINTER, value);
            _codfiscalsuframainter = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfiscaltransf
    {
        get
        {
            PropriedadeAcessada(RO_CODFISCALTRANSF);
            return _codfiscaltransf;
        }
        set
        {
            PropriedadeModificada(RO_CODFISCALTRANSF, value);
            _codfiscaltransf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfiscaltransfent
    {
        get
        {
            PropriedadeAcessada(RO_CODFISCALTRANSFENT);
            return _codfiscaltransfent;
        }
        set
        {
            PropriedadeModificada(RO_CODFISCALTRANSFENT, value);
            _codfiscaltransfent = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfiscaltransfentinter
    {
        get
        {
            PropriedadeAcessada(RO_CODFISCALTRANSFENTINTER);
            return _codfiscaltransfentinter;
        }
        set
        {
            PropriedadeModificada(RO_CODFISCALTRANSFENTINTER, value);
            _codfiscaltransfentinter = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfiscaltransff
    {
        get
        {
            PropriedadeAcessada(RO_CODFISCALTRANSFF);
            return _codfiscaltransff;
        }
        set
        {
            PropriedadeModificada(RO_CODFISCALTRANSFF, value);
            _codfiscaltransff = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfiscaltransffinter
    {
        get
        {
            PropriedadeAcessada(RO_CODFISCALTRANSFFINTER);
            return _codfiscaltransffinter;
        }
        set
        {
            PropriedadeModificada(RO_CODFISCALTRANSFFINTER, value);
            _codfiscaltransffinter = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfiscaltransffinternasc
    {
        get
        {
            PropriedadeAcessada(RO_CODFISCALTRANSFFINTERNASC);
            return _codfiscaltransffinternasc;
        }
        set
        {
            PropriedadeModificada(RO_CODFISCALTRANSFFINTERNASC, value);
            _codfiscaltransffinternasc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfiscaltransfinter
    {
        get
        {
            PropriedadeAcessada(RO_CODFISCALTRANSFINTER);
            return _codfiscaltransfinter;
        }
        set
        {
            PropriedadeModificada(RO_CODFISCALTRANSFINTER, value);
            _codfiscaltransfinter = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfiscaltransfinternasc
    {
        get
        {
            PropriedadeAcessada(RO_CODFISCALTRANSFINTERNASC);
            return _codfiscaltransfinternasc;
        }
        set
        {
            PropriedadeModificada(RO_CODFISCALTRANSFINTERNASC, value);
            _codfiscaltransfinternasc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfiscaltransfsaidaest
    {
        get
        {
            PropriedadeAcessada(RO_CODFISCALTRANSFSAIDAEST);
            return _codfiscaltransfsaidaest;
        }
        set
        {
            PropriedadeModificada(RO_CODFISCALTRANSFSAIDAEST, value);
            _codfiscaltransfsaidaest = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfiscaltransfsaidaint
    {
        get
        {
            PropriedadeAcessada(RO_CODFISCALTRANSFSAIDAINT);
            return _codfiscaltransfsaidaint;
        }
        set
        {
            PropriedadeModificada(RO_CODFISCALTRANSFSAIDAINT, value);
            _codfiscaltransfsaidaint = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfiscaltriangular
    {
        get
        {
            PropriedadeAcessada(RO_CODFISCALTRIANGULAR);
            return _codfiscaltriangular;
        }
        set
        {
            PropriedadeModificada(RO_CODFISCALTRIANGULAR, value);
            _codfiscaltriangular = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfiscaltriangularinter
    {
        get
        {
            PropriedadeAcessada(RO_CODFISCALTRIANGULARINTER);
            return _codfiscaltriangularinter;
        }
        set
        {
            PropriedadeModificada(RO_CODFISCALTRIANGULARINTER, value);
            _codfiscaltriangularinter = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfiscaltriangularinternasc
    {
        get
        {
            PropriedadeAcessada(RO_CODFISCALTRIANGULARINTERNASC);
            return _codfiscaltriangularinternasc;
        }
        set
        {
            PropriedadeModificada(RO_CODFISCALTRIANGULARINTERNASC, value);
            _codfiscaltriangularinternasc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfiscaltriangularinternascpf
    {
        get
        {
            PropriedadeAcessada(RO_CODFISCALTRIANGULARINTERNASCPF);
            return _codfiscaltriangularinternascpf;
        }
        set
        {
            PropriedadeModificada(RO_CODFISCALTRIANGULARINTERNASCPF, value);
            _codfiscaltriangularinternascpf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfiscaltriangularinterpf
    {
        get
        {
            PropriedadeAcessada(RO_CODFISCALTRIANGULARINTERPF);
            return _codfiscaltriangularinterpf;
        }
        set
        {
            PropriedadeModificada(RO_CODFISCALTRIANGULARINTERPF, value);
            _codfiscaltriangularinterpf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfiscaltriangularpf
    {
        get
        {
            PropriedadeAcessada(RO_CODFISCALTRIANGULARPF);
            return _codfiscaltriangularpf;
        }
        set
        {
            PropriedadeModificada(RO_CODFISCALTRIANGULARPF, value);
            _codfiscaltriangularpf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfiscaltroca
    {
        get
        {
            PropriedadeAcessada(RO_CODFISCALTROCA);
            return _codfiscaltroca;
        }
        set
        {
            PropriedadeModificada(RO_CODFISCALTROCA, value);
            _codfiscaltroca = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfiscaltrocainter
    {
        get
        {
            PropriedadeAcessada(RO_CODFISCALTROCAINTER);
            return _codfiscaltrocainter;
        }
        set
        {
            PropriedadeModificada(RO_CODFISCALTROCAINTER, value);
            _codfiscaltrocainter = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfiscaltrocainternasc
    {
        get
        {
            PropriedadeAcessada(RO_CODFISCALTROCAINTERNASC);
            return _codfiscaltrocainternasc;
        }
        set
        {
            PropriedadeModificada(RO_CODFISCALTROCAINTERNASC, value);
            _codfiscaltrocainternasc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfiscaltv9
    {
        get
        {
            PropriedadeAcessada(RO_CODFISCALTV9);
            return _codfiscaltv9;
        }
        set
        {
            PropriedadeModificada(RO_CODFISCALTV9, value);
            _codfiscaltv9 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Codfiscalvendaconsig
    {
        get
        {
            PropriedadeAcessada(RO_CODFISCALVENDACONSIG);
            return _codfiscalvendaconsig;
        }
        set
        {
            PropriedadeModificada(RO_CODFISCALVENDACONSIG, value);
            _codfiscalvendaconsig = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Codfiscalvendaconsiginter
    {
        get
        {
            PropriedadeAcessada(RO_CODFISCALVENDACONSIGINTER);
            return _codfiscalvendaconsiginter;
        }
        set
        {
            PropriedadeModificada(RO_CODFISCALVENDACONSIGINTER, value);
            _codfiscalvendaconsiginter = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Codfiscalvendaconsiginternasc
    {
        get
        {
            PropriedadeAcessada(RO_CODFISCALVENDACONSIGINTERNASC);
            return _codfiscalvendaconsiginternasc;
        }
        set
        {
            PropriedadeModificada(RO_CODFISCALVENDACONSIGINTERNASC, value);
            _codfiscalvendaconsiginternasc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfiscalvendaentfut
    {
        get
        {
            PropriedadeAcessada(RO_CODFISCALVENDAENTFUT);
            return _codfiscalvendaentfut;
        }
        set
        {
            PropriedadeModificada(RO_CODFISCALVENDAENTFUT, value);
            _codfiscalvendaentfut = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfiscalvendaentfutinter
    {
        get
        {
            PropriedadeAcessada(RO_CODFISCALVENDAENTFUTINTER);
            return _codfiscalvendaentfutinter;
        }
        set
        {
            PropriedadeModificada(RO_CODFISCALVENDAENTFUTINTER, value);
            _codfiscalvendaentfutinter = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfiscalvendaprontaent
    {
        get
        {
            PropriedadeAcessada(RO_CODFISCALVENDAPRONTAENT);
            return _codfiscalvendaprontaent;
        }
        set
        {
            PropriedadeModificada(RO_CODFISCALVENDAPRONTAENT, value);
            _codfiscalvendaprontaent = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfiscalvendaprontaentinter
    {
        get
        {
            PropriedadeAcessada(RO_CODFISCALVENDAPRONTAENTINTER);
            return _codfiscalvendaprontaentinter;
        }
        set
        {
            PropriedadeModificada(RO_CODFISCALVENDAPRONTAENTINTER, value);
            _codfiscalvendaprontaentinter = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfuncultalter
    {
        get
        {
            PropriedadeAcessada(RO_CODFUNCULTALTER);
            return _codfuncultalter;
        }
        set
        {
            PropriedadeModificada(RO_CODFUNCULTALTER, value);
            _codfuncultalter = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Codicm
    {
        get
        {
            PropriedadeAcessada(RO_CODICM);
            return _codicm;
        }
        set
        {
            PropriedadeModificada(RO_CODICM, value);
            _codicm = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Codicmantecipado
    {
        get
        {
            PropriedadeAcessada(RO_CODICMANTECIPADO);
            return _codicmantecipado;
        }
        set
        {
            PropriedadeModificada(RO_CODICMANTECIPADO, value);
            _codicmantecipado = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 2)]
    public decimal? Codicmconsumidor
    {
        get
        {
            PropriedadeAcessada(RO_CODICMCONSUMIDOR);
            return _codicmconsumidor;
        }
        set
        {
            PropriedadeModificada(RO_CODICMCONSUMIDOR, value);
            _codicmconsumidor = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Codicmnrpa
    {
        get
        {
            PropriedadeAcessada(RO_CODICMNRPA);
            return _codicmnrpa;
        }
        set
        {
            PropriedadeModificada(RO_CODICMNRPA, value);
            _codicmnrpa = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Codicmpf
    {
        get
        {
            PropriedadeAcessada(RO_CODICMPF);
            return _codicmpf;
        }
        set
        {
            PropriedadeModificada(RO_CODICMPF, value);
            _codicmpf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 4)]
    public decimal? Codicmprodrural
    {
        get
        {
            PropriedadeAcessada(RO_CODICMPRODRURAL);
            return _codicmprodrural;
        }
        set
        {
            PropriedadeModificada(RO_CODICMPRODRURAL, value);
            _codicmprodrural = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Codicmtabnrpa
    {
        get
        {
            PropriedadeAcessada(RO_CODICMTABNRPA);
            return _codicmtabnrpa;
        }
        set
        {
            PropriedadeModificada(RO_CODICMTABNRPA, value);
            _codicmtabnrpa = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Codicmtabpf
    {
        get
        {
            PropriedadeAcessada(RO_CODICMTABPF);
            return _codicmtabpf;
        }
        set
        {
            PropriedadeModificada(RO_CODICMTABPF, value);
            _codicmtabpf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Codicmtabtransf
    {
        get
        {
            PropriedadeAcessada(RO_CODICMTABTRANSF);
            return _codicmtabtransf;
        }
        set
        {
            PropriedadeModificada(RO_CODICMTABTRANSF, value);
            _codicmtabtransf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Codicmtransf
    {
        get
        {
            PropriedadeAcessada(RO_CODICMTRANSF);
            return _codicmtransf;
        }
        set
        {
            PropriedadeModificada(RO_CODICMTRANSF, value);
            _codicmtransf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal Codst
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Descicmsreduzbaseicms
    {
        get
        {
            PropriedadeAcessada(RO_DESCICMSREDUZBASEICMS);
            return _descicmsreduzbaseicms;
        }
        set
        {
            PropriedadeModificada(RO_DESCICMSREDUZBASEICMS, value);
            _descicmsreduzbaseicms = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtultalter
    {
        get
        {
            PropriedadeAcessada(RO_DTULTALTER);
            return _dtultalter;
        }
        set
        {
            PropriedadeModificada(RO_DTULTALTER, value);
            _dtultalter = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Indicest
    {
        get
        {
            PropriedadeAcessada(RO_INDICEST);
            return _indicest;
        }
        set
        {
            PropriedadeModificada(RO_INDICEST, value);
            _indicest = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Isentaicmsbonific
    {
        get
        {
            PropriedadeAcessada(RO_ISENTAICMSBONIFIC);
            return _isentaicmsbonific;
        }
        set
        {
            PropriedadeModificada(RO_ISENTAICMSBONIFIC, value);
            _isentaicmsbonific = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Ivafonte
    {
        get
        {
            PropriedadeAcessada(RO_IVAFONTE);
            return _ivafonte;
        }
        set
        {
            PropriedadeModificada(RO_IVAFONTE, value);
            _ivafonte = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Ivatab
    {
        get
        {
            PropriedadeAcessada(RO_IVATAB);
            return _ivatab;
        }
        set
        {
            PropriedadeModificada(RO_IVATAB, value);
            _ivatab = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Ivatransf
    {
        get
        {
            PropriedadeAcessada(RO_IVATRANSF);
            return _ivatransf;
        }
        set
        {
            PropriedadeModificada(RO_IVATRANSF, value);
            _ivatransf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
    public string Mensagem
    {
        get
        {
            PropriedadeAcessada(RO_MENSAGEM);
            return _mensagem;
        }
        set
        {
            PropriedadeModificada(RO_MENSAGEM, value);
            _mensagem = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 100, Precisao = 0)]
    public string Mensagemnrpa
    {
        get
        {
            PropriedadeAcessada(RO_MENSAGEMNRPA);
            return _mensagemnrpa;
        }
        set
        {
            PropriedadeModificada(RO_MENSAGEMNRPA, value);
            _mensagemnrpa = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 200, Precisao = 0)]
    public string Mensagem2
    {
        get
        {
            PropriedadeAcessada(RO_MENSAGEM2);
            return _mensagem2;
        }
        set
        {
            PropriedadeModificada(RO_MENSAGEM2, value);
            _mensagem2 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Mostrarpvendasemst
    {
        get
        {
            PropriedadeAcessada(RO_MOSTRARPVENDASEMST);
            return _mostrarpvendasemst;
        }
        set
        {
            PropriedadeModificada(RO_MOSTRARPVENDASEMST, value);
            _mostrarpvendasemst = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 0, Precisao = 0)]
    public decimal? Numseqatu
    {
        get
        {
            PropriedadeAcessada(RO_NUMSEQATU);
            return _numseqatu;
        }
        set
        {
            PropriedadeModificada(RO_NUMSEQATU, value);
            _numseqatu = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 100, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2000, Precisao = 0)]
    public string Obs_Informativo
    {
        get
        {
            PropriedadeAcessada(RO_OBS_INFORMATIVO);
            return _obs_informativo;
        }
        set
        {
            PropriedadeModificada(RO_OBS_INFORMATIVO, value);
            _obs_informativo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 100, Precisao = 0)]
    public string Obspf
    {
        get
        {
            PropriedadeAcessada(RO_OBSPF);
            return _obspf;
        }
        set
        {
            PropriedadeModificada(RO_OBSPF, value);
            _obspf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 100, Precisao = 0)]
    public string Obspf2
    {
        get
        {
            PropriedadeAcessada(RO_OBSPF2);
            return _obspf2;
        }
        set
        {
            PropriedadeModificada(RO_OBSPF2, value);
            _obspf2 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 100, Precisao = 0)]
    public string Obssimples
    {
        get
        {
            PropriedadeAcessada(RO_OBSSIMPLES);
            return _obssimples;
        }
        set
        {
            PropriedadeModificada(RO_OBSSIMPLES, value);
            _obssimples = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 80, Precisao = 0)]
    public string Obssuframa
    {
        get
        {
            PropriedadeAcessada(RO_OBSSUFRAMA);
            return _obssuframa;
        }
        set
        {
            PropriedadeModificada(RO_OBSSUFRAMA, value);
            _obssuframa = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 100, Precisao = 0)]
    public string Obstransf
    {
        get
        {
            PropriedadeAcessada(RO_OBSTRANSF);
            return _obstransf;
        }
        set
        {
            PropriedadeModificada(RO_OBSTRANSF, value);
            _obstransf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 80, Precisao = 0)]
    public string Obstribut_Gnre
    {
        get
        {
            PropriedadeAcessada(RO_OBSTRIBUT_GNRE);
            return _obstribut_gnre;
        }
        set
        {
            PropriedadeModificada(RO_OBSTRIBUT_GNRE, value);
            _obstribut_gnre = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 100, Precisao = 0)]
    public string Obs2
    {
        get
        {
            PropriedadeAcessada(RO_OBS2);
            return _obs2;
        }
        set
        {
            PropriedadeModificada(RO_OBS2, value);
            _obs2 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Pagtonomedesttransf
    {
        get
        {
            PropriedadeAcessada(RO_PAGTONOMEDESTTRANSF);
            return _pagtonomedesttransf;
        }
        set
        {
            PropriedadeModificada(RO_PAGTONOMEDESTTRANSF, value);
            _pagtonomedesttransf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Pagtonomedesttransftab
    {
        get
        {
            PropriedadeAcessada(RO_PAGTONOMEDESTTRANSFTAB);
            return _pagtonomedesttransftab;
        }
        set
        {
            PropriedadeModificada(RO_PAGTONOMEDESTTRANSFTAB, value);
            _pagtonomedesttransftab = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Pagtonomedocliente
    {
        get
        {
            PropriedadeAcessada(RO_PAGTONOMEDOCLIENTE);
            return _pagtonomedocliente;
        }
        set
        {
            PropriedadeModificada(RO_PAGTONOMEDOCLIENTE, value);
            _pagtonomedocliente = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Pagtonomedoremetente
    {
        get
        {
            PropriedadeAcessada(RO_PAGTONOMEDOREMETENTE);
            return _pagtonomedoremetente;
        }
        set
        {
            PropriedadeModificada(RO_PAGTONOMEDOREMETENTE, value);
            _pagtonomedoremetente = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Pagtonomeremettransf
    {
        get
        {
            PropriedadeAcessada(RO_PAGTONOMEREMETTRANSF);
            return _pagtonomeremettransf;
        }
        set
        {
            PropriedadeModificada(RO_PAGTONOMEREMETTRANSF, value);
            _pagtonomeremettransf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Pagtonomeremettransftab
    {
        get
        {
            PropriedadeAcessada(RO_PAGTONOMEREMETTRANSFTAB);
            return _pagtonomeremettransftab;
        }
        set
        {
            PropriedadeModificada(RO_PAGTONOMEREMETTRANSFTAB, value);
            _pagtonomeremettransftab = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Pautatab
    {
        get
        {
            PropriedadeAcessada(RO_PAUTATAB);
            return _pautatab;
        }
        set
        {
            PropriedadeModificada(RO_PAUTATAB, value);
            _pautatab = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Pautatransf
    {
        get
        {
            PropriedadeAcessada(RO_PAUTATRANSF);
            return _pautatransf;
        }
        set
        {
            PropriedadeModificada(RO_PAUTATRANSF, value);
            _pautatransf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Peracrescimofuncep
    {
        get
        {
            PropriedadeAcessada(RO_PERACRESCIMOFUNCEP);
            return _peracrescimofuncep;
        }
        set
        {
            PropriedadeModificada(RO_PERACRESCIMOFUNCEP, value);
            _peracrescimofuncep = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Peracrescimonrpa
    {
        get
        {
            PropriedadeAcessada(RO_PERACRESCIMONRPA);
            return _peracrescimonrpa;
        }
        set
        {
            PropriedadeModificada(RO_PERACRESCIMONRPA, value);
            _peracrescimonrpa = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 2)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Peracrescismopf
    {
        get
        {
            PropriedadeAcessada(RO_PERACRESCISMOPF);
            return _peracrescismopf;
        }
        set
        {
            PropriedadeModificada(RO_PERACRESCISMOPF, value);
            _peracrescismopf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Perbaserednrpa
    {
        get
        {
            PropriedadeAcessada(RO_PERBASEREDNRPA);
            return _perbaserednrpa;
        }
        set
        {
            PropriedadeModificada(RO_PERBASEREDNRPA, value);
            _perbaserednrpa = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Perbaseredtransfent
    {
        get
        {
            PropriedadeAcessada(RO_PERBASEREDTRANSFENT);
            return _perbaseredtransfent;
        }
        set
        {
            PropriedadeModificada(RO_PERBASEREDTRANSFENT, value);
            _perbaseredtransfent = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 2)]
    public decimal? Percacrepfvlacimapermitido
    {
        get
        {
            PropriedadeAcessada(RO_PERCACREPFVLACIMAPERMITIDO);
            return _percacrepfvlacimapermitido;
        }
        set
        {
            PropriedadeModificada(RO_PERCACREPFVLACIMAPERMITIDO, value);
            _percacrepfvlacimapermitido = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Percacrescbasepfest
    {
        get
        {
            PropriedadeAcessada(RO_PERCACRESCBASEPFEST);
            return _percacrescbasepfest;
        }
        set
        {
            PropriedadeModificada(RO_PERCACRESCBASEPFEST, value);
            _percacrescbasepfest = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Percacrescbasepfint
    {
        get
        {
            PropriedadeAcessada(RO_PERCACRESCBASEPFINT);
            return _percacrescbasepfint;
        }
        set
        {
            PropriedadeModificada(RO_PERCACRESCBASEPFINT, value);
            _percacrescbasepfint = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Percbasecalcrepasse
    {
        get
        {
            PropriedadeAcessada(RO_PERCBASECALCREPASSE);
            return _percbasecalcrepasse;
        }
        set
        {
            PropriedadeModificada(RO_PERCBASECALCREPASSE, value);
            _percbasecalcrepasse = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Percbaseredadicionalinter
    {
        get
        {
            PropriedadeAcessada(RO_PERCBASEREDADICIONALINTER);
            return _percbaseredadicionalinter;
        }
        set
        {
            PropriedadeModificada(RO_PERCBASEREDADICIONALINTER, value);
            _percbaseredadicionalinter = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Percbaseredconsumidor
    {
        get
        {
            PropriedadeAcessada(RO_PERCBASEREDCONSUMIDOR);
            return _percbaseredconsumidor;
        }
        set
        {
            PropriedadeModificada(RO_PERCBASEREDCONSUMIDOR, value);
            _percbaseredconsumidor = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Percbaseredsttransf
    {
        get
        {
            PropriedadeAcessada(RO_PERCBASEREDSTTRANSF);
            return _percbaseredsttransf;
        }
        set
        {
            PropriedadeModificada(RO_PERCBASEREDSTTRANSF, value);
            _percbaseredsttransf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Percbaseredtranfsaid
    {
        get
        {
            PropriedadeAcessada(RO_PERCBASEREDTRANFSAID);
            return _percbaseredtranfsaid;
        }
        set
        {
            PropriedadeModificada(RO_PERCBASEREDTRANFSAID, value);
            _percbaseredtranfsaid = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Percdifaliquotastab
    {
        get
        {
            PropriedadeAcessada(RO_PERCDIFALIQUOTASTAB);
            return _percdifaliquotastab;
        }
        set
        {
            PropriedadeModificada(RO_PERCDIFALIQUOTASTAB, value);
            _percdifaliquotastab = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Percicmscomplementar
    {
        get
        {
            PropriedadeAcessada(RO_PERCICMSCOMPLEMENTAR);
            return _percicmscomplementar;
        }
        set
        {
            PropriedadeModificada(RO_PERCICMSCOMPLEMENTAR, value);
            _percicmscomplementar = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Percivapauta
    {
        get
        {
            PropriedadeAcessada(RO_PERCIVAPAUTA);
            return _percivapauta;
        }
        set
        {
            PropriedadeModificada(RO_PERCIVAPAUTA, value);
            _percivapauta = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Percredpvendasimplesnac
    {
        get
        {
            PropriedadeAcessada(RO_PERCREDPVENDASIMPLESNAC);
            return _percredpvendasimplesnac;
        }
        set
        {
            PropriedadeModificada(RO_PERCREDPVENDASIMPLESNAC, value);
            _percredpvendasimplesnac = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Perdesccustotransf
    {
        get
        {
            PropriedadeAcessada(RO_PERDESCCUSTOTRANSF);
            return _perdesccustotransf;
        }
        set
        {
            PropriedadeModificada(RO_PERDESCCUSTOTRANSF, value);
            _perdesccustotransf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Perdescicmisencao
    {
        get
        {
            PropriedadeAcessada(RO_PERDESCICMISENCAO);
            return _perdescicmisencao;
        }
        set
        {
            PropriedadeModificada(RO_PERDESCICMISENCAO, value);
            _perdescicmisencao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Perdescpissuframa
    {
        get
        {
            PropriedadeAcessada(RO_PERDESCPISSUFRAMA);
            return _perdescpissuframa;
        }
        set
        {
            PropriedadeModificada(RO_PERDESCPISSUFRAMA, value);
            _perdescpissuframa = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Perdescrepasse
    {
        get
        {
            PropriedadeAcessada(RO_PERDESCREPASSE);
            return _perdescrepasse;
        }
        set
        {
            PropriedadeModificada(RO_PERDESCREPASSE, value);
            _perdescrepasse = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Perdescsuframa
    {
        get
        {
            PropriedadeAcessada(RO_PERDESCSUFRAMA);
            return _perdescsuframa;
        }
        set
        {
            PropriedadeModificada(RO_PERDESCSUFRAMA, value);
            _perdescsuframa = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Perdestab
    {
        get
        {
            PropriedadeAcessada(RO_PERDESTAB);
            return _perdestab;
        }
        set
        {
            PropriedadeModificada(RO_PERDESTAB, value);
            _perdestab = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Perdifereimentoicms
    {
        get
        {
            PropriedadeAcessada(RO_PERDIFEREIMENTOICMS);
            return _perdifereimentoicms;
        }
        set
        {
            PropriedadeModificada(RO_PERDIFEREIMENTOICMS, value);
            _perdifereimentoicms = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Perpautaicms
    {
        get
        {
            PropriedadeAcessada(RO_PERPAUTAICMS);
            return _perpautaicms;
        }
        set
        {
            PropriedadeModificada(RO_PERPAUTAICMS, value);
            _perpautaicms = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Perpautaicmsinter
    {
        get
        {
            PropriedadeAcessada(RO_PERPAUTAICMSINTER);
            return _perpautaicmsinter;
        }
        set
        {
            PropriedadeModificada(RO_PERPAUTAICMSINTER, value);
            _perpautaicmsinter = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Reduzbaseicmdecretomaranhao
    {
        get
        {
            PropriedadeAcessada(RO_REDUZBASEICMDECRETOMARANHAO);
            return _reduzbaseicmdecretomaranhao;
        }
        set
        {
            PropriedadeModificada(RO_REDUZBASEICMDECRETOMARANHAO, value);
            _reduzbaseicmdecretomaranhao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 3, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 3, Precisao = 0)]
    public string Sittributbonific
    {
        get
        {
            PropriedadeAcessada(RO_SITTRIBUTBONIFIC);
            return _sittributbonific;
        }
        set
        {
            PropriedadeModificada(RO_SITTRIBUTBONIFIC, value);
            _sittributbonific = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 3, Precisao = 0)]
    public string Sittributecf
    {
        get
        {
            PropriedadeAcessada(RO_SITTRIBUTECF);
            return _sittributecf;
        }
        set
        {
            PropriedadeModificada(RO_SITTRIBUTECF, value);
            _sittributecf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 3, Precisao = 0)]
    public string Sittributisentost
    {
        get
        {
            PropriedadeAcessada(RO_SITTRIBUTISENTOST);
            return _sittributisentost;
        }
        set
        {
            PropriedadeModificada(RO_SITTRIBUTISENTOST, value);
            _sittributisentost = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 3, Precisao = 0)]
    public string Sittributnrpa
    {
        get
        {
            PropriedadeAcessada(RO_SITTRIBUTNRPA);
            return _sittributnrpa;
        }
        set
        {
            PropriedadeModificada(RO_SITTRIBUTNRPA, value);
            _sittributnrpa = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 3, Precisao = 0)]
    public string Sittributpf
    {
        get
        {
            PropriedadeAcessada(RO_SITTRIBUTPF);
            return _sittributpf;
        }
        set
        {
            PropriedadeModificada(RO_SITTRIBUTPF, value);
            _sittributpf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 3, Precisao = 0)]
    public string Sittributsuframa
    {
        get
        {
            PropriedadeAcessada(RO_SITTRIBUTSUFRAMA);
            return _sittributsuframa;
        }
        set
        {
            PropriedadeModificada(RO_SITTRIBUTSUFRAMA, value);
            _sittributsuframa = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 3, Precisao = 0)]
    public string Sittributtransf
    {
        get
        {
            PropriedadeAcessada(RO_SITTRIBUTTRANSF);
            return _sittributtransf;
        }
        set
        {
            PropriedadeModificada(RO_SITTRIBUTTRANSF, value);
            _sittributtransf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Sittributtransfent
    {
        get
        {
            PropriedadeAcessada(RO_SITTRIBUTTRANSFENT);
            return _sittributtransfent;
        }
        set
        {
            PropriedadeModificada(RO_SITTRIBUTTRANSFENT, value);
            _sittributtransfent = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 3, Precisao = 0)]
    public string Sittributtv7
    {
        get
        {
            PropriedadeAcessada(RO_SITTRIBUTTV7);
            return _sittributtv7;
        }
        set
        {
            PropriedadeModificada(RO_SITTRIBUTTV7, value);
            _sittributtv7 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 3, Precisao = 0)]
    public string Sittributtv8
    {
        get
        {
            PropriedadeAcessada(RO_SITTRIBUTTV8);
            return _sittributtv8;
        }
        set
        {
            PropriedadeModificada(RO_SITTRIBUTTV8, value);
            _sittributtv8 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Tipocalculognre
    {
        get
        {
            PropriedadeAcessada(RO_TIPOCALCULOGNRE);
            return _tipocalculognre;
        }
        set
        {
            PropriedadeModificada(RO_TIPOCALCULOGNRE, value);
            _tipocalculognre = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Tipocalculognretab
    {
        get
        {
            PropriedadeAcessada(RO_TIPOCALCULOGNRETAB);
            return _tipocalculognretab;
        }
        set
        {
            PropriedadeModificada(RO_TIPOCALCULOGNRETAB, value);
            _tipocalculognretab = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Tipocalculognretransf
    {
        get
        {
            PropriedadeAcessada(RO_TIPOCALCULOGNRETRANSF);
            return _tipocalculognretransf;
        }
        set
        {
            PropriedadeModificada(RO_TIPOCALCULOGNRETRANSF, value);
            _tipocalculognretransf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Tipocalculognretransftab
    {
        get
        {
            PropriedadeAcessada(RO_TIPOCALCULOGNRETRANSFTAB);
            return _tipocalculognretransftab;
        }
        set
        {
            PropriedadeModificada(RO_TIPOCALCULOGNRETRANSFTAB, value);
            _tipocalculognretransftab = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Usabaseicmsreduzida
    {
        get
        {
            PropriedadeAcessada(RO_USABASEICMSREDUZIDA);
            return _usabaseicmsreduzida;
        }
        set
        {
            PropriedadeModificada(RO_USABASEICMSREDUZIDA, value);
            _usabaseicmsreduzida = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Usacfopbnfparabrinde
    {
        get
        {
            PropriedadeAcessada(RO_USACFOPBNFPARABRINDE);
            return _usacfopbnfparabrinde;
        }
        set
        {
            PropriedadeModificada(RO_USACFOPBNFPARABRINDE, value);
            _usacfopbnfparabrinde = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Usaisencaoicmsvp
    {
        get
        {
            PropriedadeAcessada(RO_USAISENCAOICMSVP);
            return _usaisencaoicmsvp;
        }
        set
        {
            PropriedadeModificada(RO_USAISENCAOICMSVP, value);
            _usaisencaoicmsvp = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Usapautasemiva
    {
        get
        {
            PropriedadeAcessada(RO_USAPAUTASEMIVA);
            return _usapautasemiva;
        }
        set
        {
            PropriedadeModificada(RO_USAPAUTASEMIVA, value);
            _usapautasemiva = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Usapercbaseredassoc
    {
        get
        {
            PropriedadeAcessada(RO_USAPERCBASEREDASSOC);
            return _usapercbaseredassoc;
        }
        set
        {
            PropriedadeModificada(RO_USAPERCBASEREDASSOC, value);
            _usapercbaseredassoc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Usapercbasereddist
    {
        get
        {
            PropriedadeAcessada(RO_USAPERCBASEREDDIST);
            return _usapercbasereddist;
        }
        set
        {
            PropriedadeModificada(RO_USAPERCBASEREDDIST, value);
            _usapercbasereddist = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Usapercbaseredfarma
    {
        get
        {
            PropriedadeAcessada(RO_USAPERCBASEREDFARMA);
            return _usapercbaseredfarma;
        }
        set
        {
            PropriedadeModificada(RO_USAPERCBASEREDFARMA, value);
            _usapercbaseredfarma = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Usapercbaseredhosp
    {
        get
        {
            PropriedadeAcessada(RO_USAPERCBASEREDHOSP);
            return _usapercbaseredhosp;
        }
        set
        {
            PropriedadeModificada(RO_USAPERCBASEREDHOSP, value);
            _usapercbaseredhosp = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Usapercbaseredmedico
    {
        get
        {
            PropriedadeAcessada(RO_USAPERCBASEREDMEDICO);
            return _usapercbaseredmedico;
        }
        set
        {
            PropriedadeModificada(RO_USAPERCBASEREDMEDICO, value);
            _usapercbaseredmedico = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Usapercbaseredope
    {
        get
        {
            PropriedadeAcessada(RO_USAPERCBASEREDOPE);
            return _usapercbaseredope;
        }
        set
        {
            PropriedadeModificada(RO_USAPERCBASEREDOPE, value);
            _usapercbaseredope = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Usapercbaseredopf
    {
        get
        {
            PropriedadeAcessada(RO_USAPERCBASEREDOPF);
            return _usapercbaseredopf;
        }
        set
        {
            PropriedadeModificada(RO_USAPERCBASEREDOPF, value);
            _usapercbaseredopf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Usapercbaseredopm
    {
        get
        {
            PropriedadeAcessada(RO_USAPERCBASEREDOPM);
            return _usapercbaseredopm;
        }
        set
        {
            PropriedadeModificada(RO_USAPERCBASEREDOPM, value);
            _usapercbaseredopm = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Usapmcbasest
    {
        get
        {
            PropriedadeAcessada(RO_USAPMCBASEST);
            return _usapmcbasest;
        }
        set
        {
            PropriedadeModificada(RO_USAPMCBASEST, value);
            _usapmcbasest = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Usaredbaseicmsfontest
    {
        get
        {
            PropriedadeAcessada(RO_USAREDBASEICMSFONTEST);
            return _usaredbaseicmsfontest;
        }
        set
        {
            PropriedadeModificada(RO_USAREDBASEICMSFONTEST, value);
            _usaredbaseicmsfontest = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Usavalorultentbasest
    {
        get
        {
            PropriedadeAcessada(RO_USAVALORULTENTBASEST);
            return _usavalorultentbasest;
        }
        set
        {
            PropriedadeModificada(RO_USAVALORULTENTBASEST, value);
            _usavalorultentbasest = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Usavalorultentbasest2
    {
        get
        {
            PropriedadeAcessada(RO_USAVALORULTENTBASEST2);
            return _usavalorultentbasest2;
        }
        set
        {
            PropriedadeModificada(RO_USAVALORULTENTBASEST2, value);
            _usavalorultentbasest2 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Utilizaparcadicfecp
    {
        get
        {
            PropriedadeAcessada(RO_UTILIZAPARCADICFECP);
            return _utilizaparcadicfecp;
        }
        set
        {
            PropriedadeModificada(RO_UTILIZAPARCADICFECP, value);
            _utilizaparcadicfecp = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Utilizapercbaseredpf
    {
        get
        {
            PropriedadeAcessada(RO_UTILIZAPERCBASEREDPF);
            return _utilizapercbaseredpf;
        }
        set
        {
            PropriedadeModificada(RO_UTILIZAPERCBASEREDPF, value);
            _utilizapercbaseredpf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Vlpautasemiva
    {
        get
        {
            PropriedadeAcessada(RO_VLPAUTASEMIVA);
            return _vlpautasemiva;
        }
        set
        {
            PropriedadeModificada(RO_VLPAUTASEMIVA, value);
            _vlpautasemiva = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Zerarbaseicmsorgpubsuframa
    {
        get
        {
            PropriedadeAcessada(RO_ZERARBASEICMSORGPUBSUFRAMA);
            return _zerarbaseicmsorgpubsuframa;
        }
        set
        {
            PropriedadeModificada(RO_ZERARBASEICMSORGPUBSUFRAMA, value);
            _zerarbaseicmsorgpubsuframa = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 2)]
    public decimal? Perctributos
    {
        get
        {
            PropriedadeAcessada(RO_PERCTRIBUTOS);
            return _perctributos;
        }
        set
        {
            PropriedadeModificada(RO_PERCTRIBUTOS, value);
            _perctributos = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Geraricmslivrofiscal
    {
        get
        {
            PropriedadeAcessada(RO_GERARICMSLIVROFISCAL);
            return _geraricmslivrofiscal;
        }
        set
        {
            PropriedadeModificada(RO_GERARICMSLIVROFISCAL, value);
            _geraricmslivrofiscal = value;
        }
    }

    public void InicializarAtributos()
    {
    }

    public string ObterNomeTabela()
    {
        return "PCTRIBUT";
    }

    public IEntidade NovaInstancia()
    {
        return (IEntidade)GetType().GetConstructors()[0].Invoke(null);
    }

    public void CarregarPorDataReader(IDataReader leitor)
    {
        _aliqicmsfecp = AlterarTipo<decimal?>(leitor["Aliqicmsfecp"]);
        _aliqicmstv9 = AlterarTipo<decimal?>(leitor["Aliqicmstv9"]);
        _aliqicms1 = AlterarTipo<decimal?>(leitor["Aliqicms1"]);
        _aliqicms1fonte = AlterarTipo<decimal?>(leitor["Aliqicms1fonte"]);
        _aliqicms1tab = AlterarTipo<decimal?>(leitor["Aliqicms1tab"]);
        _aliqicms1transf = AlterarTipo<decimal?>(leitor["Aliqicms1transf"]);
        _aliqicms2 = AlterarTipo<decimal?>(leitor["Aliqicms2"]);
        _aliqicms2fonte = AlterarTipo<decimal?>(leitor["Aliqicms2fonte"]);
        _aliqicms2tab = AlterarTipo<decimal?>(leitor["Aliqicms2tab"]);
        _aliqicms2transf = AlterarTipo<decimal?>(leitor["Aliqicms2transf"]);
        _aliqiss = AlterarTipo<decimal?>(leitor["Aliqiss"]);
        _aliqstsaida = AlterarTipo<decimal?>(leitor["Aliqstsaida"]);
        _aliqstsaidapf = AlterarTipo<decimal?>(leitor["Aliqstsaidapf"]);
        _aliquotaicmsenttransf = AlterarTipo<decimal?>(leitor["Aliquotaicmsenttransf"]);
        _aplicaacrescpjisenta = AlterarTipo<string>(leitor["Aplicaacrescpjisenta"]);
        _assinatura = AlterarTipo<string>(leitor["Assinatura"]);
        _calcbaseredicmstransf = AlterarTipo<string>(leitor["Calcbaseredicmstransf"]);
        _calcbcicmsnf = AlterarTipo<string>(leitor["Calcbcicmsnf"]);
        _calcsttransf = AlterarTipo<string>(leitor["Calcsttransf"]);
        _calcularicmssittribut060 = AlterarTipo<string>(leitor["Calcularicmssittribut060"]);
        _codecf = AlterarTipo<string>(leitor["Codecf"]);
        _codecffuncep = AlterarTipo<string>(leitor["Codecffuncep"]);
        _codfiscal = AlterarTipo<decimal?>(leitor["Codfiscal"]);
        _codfiscalbonific = AlterarTipo<decimal?>(leitor["Codfiscalbonific"]);
        _codfiscalbonificinter = AlterarTipo<decimal?>(leitor["Codfiscalbonificinter"]);
        _codfiscalbonificinternasc = AlterarTipo<decimal?>(leitor["Codfiscalbonificinternasc"]);
        _codfiscalbrokerdevent = AlterarTipo<decimal?>(leitor["Codfiscalbrokerdevent"]);
        _codfiscalbrokerdevsaid = AlterarTipo<decimal?>(leitor["Codfiscalbrokerdevsaid"]);
        _codfiscalbrokerent = AlterarTipo<decimal?>(leitor["Codfiscalbrokerent"]);
        _codfiscalbrokersaid = AlterarTipo<decimal?>(leitor["Codfiscalbrokersaid"]);
        _codfiscalconsig = AlterarTipo<decimal?>(leitor["Codfiscalconsig"]);
        _codfiscalconsiginter = AlterarTipo<decimal?>(leitor["Codfiscalconsiginter"]);
        _codfiscalconsiginternac = AlterarTipo<decimal?>(leitor["Codfiscalconsiginternac"]);
        _codfiscalcontaordem = AlterarTipo<decimal?>(leitor["Codfiscalcontaordem"]);
        _codfiscalcontaordeminter = AlterarTipo<decimal?>(leitor["Codfiscalcontaordeminter"]);
        _codfiscalcontaordemsimpent = AlterarTipo<decimal?>(leitor["Codfiscalcontaordemsimpent"]);
        _codfiscalcontaordemsimpentinte = AlterarTipo<decimal?>(leitor["Codfiscalcontaordemsimpentinte"]);
        _codfiscaldevcli = AlterarTipo<decimal?>(leitor["Codfiscaldevcli"]);
        _codfiscaldevclibonific = AlterarTipo<decimal?>(leitor["Codfiscaldevclibonific"]);
        _codfiscaldevclibonificinter = AlterarTipo<decimal?>(leitor["Codfiscaldevclibonificinter"]);
        _codfiscaldevcliboninternasc = AlterarTipo<decimal?>(leitor["Codfiscaldevcliboninternasc"]);
        _codfiscaldevcliinter = AlterarTipo<decimal?>(leitor["Codfiscaldevcliinter"]);
        _codfiscaldevcliinternasc = AlterarTipo<decimal?>(leitor["Codfiscaldevcliinternasc"]);
        _codfiscaldevclipf = AlterarTipo<decimal?>(leitor["Codfiscaldevclipf"]);
        _codfiscaldevclipfinter = AlterarTipo<decimal?>(leitor["Codfiscaldevclipfinter"]);
        _codfiscaldevclipfinternasc = AlterarTipo<decimal?>(leitor["Codfiscaldevclipfinternasc"]);
        _codfiscaldevcliproentinternasc = AlterarTipo<decimal?>(leitor["Codfiscaldevcliproentinternasc"]);
        _codfiscaldevcliprontaent = AlterarTipo<decimal?>(leitor["Codfiscaldevcliprontaent"]);
        _codfiscaldevcliprontaentinter = AlterarTipo<decimal?>(leitor["Codfiscaldevcliprontaentinter"]);
        _codfiscaldevcomodatoest = AlterarTipo<decimal?>(leitor["Codfiscaldevcomodatoest"]);
        _codfiscaldevcomodatointer = AlterarTipo<decimal?>(leitor["Codfiscaldevcomodatointer"]);
        _codfiscaldevisentost = AlterarTipo<decimal?>(leitor["Codfiscaldevisentost"]);
        _codfiscaldevisentostinter = AlterarTipo<decimal?>(leitor["Codfiscaldevisentostinter"]);
        _codfiscaldevisentostinternasc = AlterarTipo<decimal?>(leitor["Codfiscaldevisentostinternasc"]);
        _codfiscaldevmercconsig = AlterarTipo<decimal?>(leitor["Codfiscaldevmercconsig"]);
        _codfiscaldevmercconsiginter = AlterarTipo<decimal?>(leitor["Codfiscaldevmercconsiginter"]);
        _codfiscaldevtransf = AlterarTipo<decimal?>(leitor["Codfiscaldevtransf"]);
        _codfiscaldevtransfent = AlterarTipo<decimal?>(leitor["Codfiscaldevtransfent"]);
        _codfiscaldevtransfentinter = AlterarTipo<decimal?>(leitor["Codfiscaldevtransfentinter"]);
        _codfiscaldevtransfinter = AlterarTipo<decimal?>(leitor["Codfiscaldevtransfinter"]);
        _codfiscalentbeneficest = AlterarTipo<decimal?>(leitor["Codfiscalentbeneficest"]);
        _codfiscalentbeneficinterest = AlterarTipo<decimal?>(leitor["Codfiscalentbeneficinterest"]);
        _codfiscalentbenefinternac = AlterarTipo<decimal?>(leitor["Codfiscalentbenefinternac"]);
        _codfiscalenvcomodatoest = AlterarTipo<decimal?>(leitor["Codfiscalenvcomodatoest"]);
        _codfiscalenvcomodatointer = AlterarTipo<decimal?>(leitor["Codfiscalenvcomodatointer"]);
        _codfiscalinter = AlterarTipo<decimal?>(leitor["Codfiscalinter"]);
        _codfiscalinternasc = AlterarTipo<decimal?>(leitor["Codfiscalinternasc"]);
        _codfiscalinternascpf = AlterarTipo<decimal?>(leitor["Codfiscalinternascpf"]);
        _codfiscalinternasctv9 = AlterarTipo<decimal?>(leitor["Codfiscalinternasctv9"]);
        _codfiscalinterpf = AlterarTipo<decimal?>(leitor["Codfiscalinterpf"]);
        _codfiscalintertv9 = AlterarTipo<decimal?>(leitor["Codfiscalintertv9"]);
        _codfiscalisentost = AlterarTipo<decimal?>(leitor["Codfiscalisentost"]);
        _codfiscalisentostinter = AlterarTipo<decimal?>(leitor["Codfiscalisentostinter"]);
        _codfiscalisentostinternasc = AlterarTipo<decimal?>(leitor["Codfiscalisentostinternasc"]);
        _codfiscalmercconsig = AlterarTipo<decimal?>(leitor["Codfiscalmercconsig"]);
        _codfiscalmercconsiginter = AlterarTipo<decimal?>(leitor["Codfiscalmercconsiginter"]);
        _codfiscalmercconsiginternasc = AlterarTipo<decimal?>(leitor["Codfiscalmercconsiginternasc"]);
        _codfiscalpf = AlterarTipo<decimal?>(leitor["Codfiscalpf"]);
        _codfiscalprontaent = AlterarTipo<decimal?>(leitor["Codfiscalprontaent"]);
        _codfiscalprontaentinter = AlterarTipo<decimal?>(leitor["Codfiscalprontaentinter"]);
        _codfiscalprontaentinternasc = AlterarTipo<decimal?>(leitor["Codfiscalprontaentinternasc"]);
        _codfiscalsaidbenefest = AlterarTipo<decimal?>(leitor["Codfiscalsaidbenefest"]);
        _codfiscalsaidbenefinterest = AlterarTipo<decimal?>(leitor["Codfiscalsaidbenefinterest"]);
        _codfiscalsaidbenefinternac = AlterarTipo<decimal?>(leitor["Codfiscalsaidbenefinternac"]);
        _codfiscalsimpentfut = AlterarTipo<decimal?>(leitor["Codfiscalsimpentfut"]);
        _codfiscalsimpentfutinter = AlterarTipo<decimal?>(leitor["Codfiscalsimpentfutinter"]);
        _codfiscalsrestsr = AlterarTipo<decimal?>(leitor["Codfiscalsrestsr"]);
        _codfiscalsrext = AlterarTipo<decimal?>(leitor["Codfiscalsrext"]);
        _codfiscalsrinte = AlterarTipo<decimal?>(leitor["Codfiscalsrinte"]);
        _codfiscalsuframa = AlterarTipo<decimal?>(leitor["Codfiscalsuframa"]);
        _codfiscalsuframainter = AlterarTipo<decimal?>(leitor["Codfiscalsuframainter"]);
        _codfiscaltransf = AlterarTipo<decimal?>(leitor["Codfiscaltransf"]);
        _codfiscaltransfent = AlterarTipo<decimal?>(leitor["Codfiscaltransfent"]);
        _codfiscaltransfentinter = AlterarTipo<decimal?>(leitor["Codfiscaltransfentinter"]);
        _codfiscaltransff = AlterarTipo<decimal?>(leitor["Codfiscaltransff"]);
        _codfiscaltransffinter = AlterarTipo<decimal?>(leitor["Codfiscaltransffinter"]);
        _codfiscaltransffinternasc = AlterarTipo<decimal?>(leitor["Codfiscaltransffinternasc"]);
        _codfiscaltransfinter = AlterarTipo<decimal?>(leitor["Codfiscaltransfinter"]);
        _codfiscaltransfinternasc = AlterarTipo<decimal?>(leitor["Codfiscaltransfinternasc"]);
        _codfiscaltransfsaidaest = AlterarTipo<decimal?>(leitor["Codfiscaltransfsaidaest"]);
        _codfiscaltransfsaidaint = AlterarTipo<decimal?>(leitor["Codfiscaltransfsaidaint"]);
        _codfiscaltriangular = AlterarTipo<decimal?>(leitor["Codfiscaltriangular"]);
        _codfiscaltriangularinter = AlterarTipo<decimal?>(leitor["Codfiscaltriangularinter"]);
        _codfiscaltriangularinternasc = AlterarTipo<decimal?>(leitor["Codfiscaltriangularinternasc"]);
        _codfiscaltriangularinternascpf = AlterarTipo<decimal?>(leitor["Codfiscaltriangularinternascpf"]);
        _codfiscaltriangularinterpf = AlterarTipo<decimal?>(leitor["Codfiscaltriangularinterpf"]);
        _codfiscaltriangularpf = AlterarTipo<decimal?>(leitor["Codfiscaltriangularpf"]);
        _codfiscaltroca = AlterarTipo<decimal?>(leitor["Codfiscaltroca"]);
        _codfiscaltrocainter = AlterarTipo<decimal?>(leitor["Codfiscaltrocainter"]);
        _codfiscaltrocainternasc = AlterarTipo<decimal?>(leitor["Codfiscaltrocainternasc"]);
        _codfiscaltv9 = AlterarTipo<decimal?>(leitor["Codfiscaltv9"]);
        _codfiscalvendaconsig = AlterarTipo<decimal?>(leitor["Codfiscalvendaconsig"]);
        _codfiscalvendaconsiginter = AlterarTipo<decimal?>(leitor["Codfiscalvendaconsiginter"]);
        _codfiscalvendaconsiginternasc = AlterarTipo<decimal?>(leitor["Codfiscalvendaconsiginternasc"]);
        _codfiscalvendaentfut = AlterarTipo<decimal?>(leitor["Codfiscalvendaentfut"]);
        _codfiscalvendaentfutinter = AlterarTipo<decimal?>(leitor["Codfiscalvendaentfutinter"]);
        _codfiscalvendaprontaent = AlterarTipo<decimal?>(leitor["Codfiscalvendaprontaent"]);
        _codfiscalvendaprontaentinter = AlterarTipo<decimal?>(leitor["Codfiscalvendaprontaentinter"]);
        _codfuncultalter = AlterarTipo<decimal?>(leitor["Codfuncultalter"]);
        _codicm = AlterarTipo<decimal?>(leitor["Codicm"]);
        _codicmantecipado = AlterarTipo<decimal?>(leitor["Codicmantecipado"]);
        _codicmconsumidor = AlterarTipo<decimal?>(leitor["Codicmconsumidor"]);
        _codicmnrpa = AlterarTipo<decimal?>(leitor["Codicmnrpa"]);
        _codicmpf = AlterarTipo<decimal?>(leitor["Codicmpf"]);
        _codicmprodrural = AlterarTipo<decimal?>(leitor["Codicmprodrural"]);
        _codicmtab = AlterarTipo<decimal?>(leitor["Codicmtab"]);
        _codicmtabnrpa = AlterarTipo<decimal?>(leitor["Codicmtabnrpa"]);
        _codicmtabpf = AlterarTipo<decimal?>(leitor["Codicmtabpf"]);
        _codicmtabtransf = AlterarTipo<decimal?>(leitor["Codicmtabtransf"]);
        _codicmtransf = AlterarTipo<decimal?>(leitor["Codicmtransf"]);
        _codst = AlterarTipo<decimal>(leitor["Codst"]);
        _descicmsreduzbaseicms = AlterarTipo<string>(leitor["Descicmsreduzbaseicms"]);
        _dtultalter = AlterarTipo<DateTime?>(leitor["Dtultalter"]);
        _indicest = AlterarTipo<decimal?>(leitor["Indicest"]);
        _isentaicmsbonific = AlterarTipo<string>(leitor["Isentaicmsbonific"]);
        _iva = AlterarTipo<decimal?>(leitor["Iva"]);
        _ivafonte = AlterarTipo<decimal?>(leitor["Ivafonte"]);
        _ivatab = AlterarTipo<decimal?>(leitor["Ivatab"]);
        _ivatransf = AlterarTipo<decimal?>(leitor["Ivatransf"]);
        _mensagem = AlterarTipo<string>(leitor["Mensagem"]);
        _mensagemnrpa = AlterarTipo<string>(leitor["Mensagemnrpa"]);
        _mensagem2 = AlterarTipo<string>(leitor["Mensagem2"]);
        _mostrarpvendasemst = AlterarTipo<string>(leitor["Mostrarpvendasemst"]);
        _numseqatu = AlterarTipo<decimal?>(leitor["Numseqatu"]);
        _obs = AlterarTipo<string>(leitor["Obs"]);
        _obs_informativo = AlterarTipo<string>(leitor["Obs_Informativo"]);
        _obspf = AlterarTipo<string>(leitor["Obspf"]);
        _obspf2 = AlterarTipo<string>(leitor["Obspf2"]);
        _obssimples = AlterarTipo<string>(leitor["Obssimples"]);
        _obssuframa = AlterarTipo<string>(leitor["Obssuframa"]);
        _obstransf = AlterarTipo<string>(leitor["Obstransf"]);
        _obstribut_gnre = AlterarTipo<string>(leitor["Obstribut_Gnre"]);
        _obs2 = AlterarTipo<string>(leitor["Obs2"]);
        _pagtonomedesttransf = AlterarTipo<string>(leitor["Pagtonomedesttransf"]);
        _pagtonomedesttransftab = AlterarTipo<string>(leitor["Pagtonomedesttransftab"]);
        _pagtonomedocliente = AlterarTipo<string>(leitor["Pagtonomedocliente"]);
        _pagtonomedoremetente = AlterarTipo<string>(leitor["Pagtonomedoremetente"]);
        _pagtonomeremettransf = AlterarTipo<string>(leitor["Pagtonomeremettransf"]);
        _pagtonomeremettransftab = AlterarTipo<string>(leitor["Pagtonomeremettransftab"]);
        _pauta = AlterarTipo<decimal?>(leitor["Pauta"]);
        _pautatab = AlterarTipo<decimal?>(leitor["Pautatab"]);
        _pautatransf = AlterarTipo<decimal?>(leitor["Pautatransf"]);
        _peracrescimocusto = AlterarTipo<decimal?>(leitor["Peracrescimocusto"]);
        _peracrescimofuncep = AlterarTipo<decimal?>(leitor["Peracrescimofuncep"]);
        _peracrescimonrpa = AlterarTipo<decimal?>(leitor["Peracrescimonrpa"]);
        _peracrescimopf = AlterarTipo<decimal?>(leitor["Peracrescimopf"]);
        _peracrescismopf = AlterarTipo<decimal?>(leitor["Peracrescismopf"]);
        _perbaserednrpa = AlterarTipo<decimal?>(leitor["Perbaserednrpa"]);
        _perbaseredtransfent = AlterarTipo<decimal?>(leitor["Perbaseredtransfent"]);
        _percacrepfvlacimapermitido = AlterarTipo<decimal?>(leitor["Percacrepfvlacimapermitido"]);
        _percacrescbasepfest = AlterarTipo<decimal?>(leitor["Percacrescbasepfest"]);
        _percacrescbasepfint = AlterarTipo<decimal?>(leitor["Percacrescbasepfint"]);
        _percagregadorst = AlterarTipo<decimal?>(leitor["Percagregadorst"]);
        _percbasecalcrepasse = AlterarTipo<decimal?>(leitor["Percbasecalcrepasse"]);
        _percbasered = AlterarTipo<decimal?>(leitor["Percbasered"]);
        _percbaseredadicional = AlterarTipo<decimal?>(leitor["Percbaseredadicional"]);
        _percbaseredadicionalinter = AlterarTipo<decimal?>(leitor["Percbaseredadicionalinter"]);
        _percbaseredconsumidor = AlterarTipo<decimal?>(leitor["Percbaseredconsumidor"]);
        _percbaseredst = AlterarTipo<decimal?>(leitor["Percbaseredst"]);
        _percbaseredstfonte = AlterarTipo<decimal?>(leitor["Percbaseredstfonte"]);
        _percbaseredsttransf = AlterarTipo<decimal?>(leitor["Percbaseredsttransf"]);
        _percbaseredtranfsaid = AlterarTipo<decimal?>(leitor["Percbaseredtranfsaid"]);
        _percdesccofins = AlterarTipo<decimal?>(leitor["Percdesccofins"]);
        _percdescpis = AlterarTipo<decimal?>(leitor["Percdescpis"]);
        _percdifaliquotas = AlterarTipo<decimal?>(leitor["Percdifaliquotas"]);
        _percdifaliquotastab = AlterarTipo<decimal?>(leitor["Percdifaliquotastab"]);
        _percicmscomplementar = AlterarTipo<decimal?>(leitor["Percicmscomplementar"]);
        _percivamex = AlterarTipo<decimal?>(leitor["Percivamex"]);
        _percivapauta = AlterarTipo<decimal?>(leitor["Percivapauta"]);
        _percredpvendasimplesnac = AlterarTipo<decimal?>(leitor["Percredpvendasimplesnac"]);
        _perdesccusto = AlterarTipo<decimal?>(leitor["Perdesccusto"]);
        _perdesccustotransf = AlterarTipo<decimal?>(leitor["Perdesccustotransf"]);
        _perdescicmisencao = AlterarTipo<decimal?>(leitor["Perdescicmisencao"]);
        _perdescpissuframa = AlterarTipo<decimal?>(leitor["Perdescpissuframa"]);
        _perdescrepasse = AlterarTipo<decimal?>(leitor["Perdescrepasse"]);
        _perdescsuframa = AlterarTipo<decimal?>(leitor["Perdescsuframa"]);
        _perdestab = AlterarTipo<decimal?>(leitor["Perdestab"]);
        _perdifereimentoicms = AlterarTipo<decimal?>(leitor["Perdifereimentoicms"]);
        _perpautaicms = AlterarTipo<decimal?>(leitor["Perpautaicms"]);
        _perpautaicmsinter = AlterarTipo<decimal?>(leitor["Perpautaicmsinter"]);
        _reduzbaseicmdecretomaranhao = AlterarTipo<string>(leitor["Reduzbaseicmdecretomaranhao"]);
        _sittribut = AlterarTipo<string>(leitor["Sittribut"]);
        _sittributbonific = AlterarTipo<string>(leitor["Sittributbonific"]);
        _sittributecf = AlterarTipo<string>(leitor["Sittributecf"]);
        _sittributisentost = AlterarTipo<string>(leitor["Sittributisentost"]);
        _sittributnrpa = AlterarTipo<string>(leitor["Sittributnrpa"]);
        _sittributpf = AlterarTipo<string>(leitor["Sittributpf"]);
        _sittributsuframa = AlterarTipo<string>(leitor["Sittributsuframa"]);
        _sittributtransf = AlterarTipo<string>(leitor["Sittributtransf"]);
        _sittributtransfent = AlterarTipo<string>(leitor["Sittributtransfent"]);
        _sittributtv7 = AlterarTipo<string>(leitor["Sittributtv7"]);
        _sittributtv8 = AlterarTipo<string>(leitor["Sittributtv8"]);
        _tipocalculognre = AlterarTipo<string>(leitor["Tipocalculognre"]);
        _tipocalculognretab = AlterarTipo<string>(leitor["Tipocalculognretab"]);
        _tipocalculognretransf = AlterarTipo<string>(leitor["Tipocalculognretransf"]);
        _tipocalculognretransftab = AlterarTipo<string>(leitor["Tipocalculognretransftab"]);
        _usabaseicmsreduzida = AlterarTipo<string>(leitor["Usabaseicmsreduzida"]);
        _usacfopbnfparabrinde = AlterarTipo<string>(leitor["Usacfopbnfparabrinde"]);
        _usaisencaoicmsvp = AlterarTipo<string>(leitor["Usaisencaoicmsvp"]);
        _usapautasemiva = AlterarTipo<string>(leitor["Usapautasemiva"]);
        _usapercbaseredassoc = AlterarTipo<string>(leitor["Usapercbaseredassoc"]);
        _usapercbasereddist = AlterarTipo<string>(leitor["Usapercbasereddist"]);
        _usapercbaseredfarma = AlterarTipo<string>(leitor["Usapercbaseredfarma"]);
        _usapercbaseredhosp = AlterarTipo<string>(leitor["Usapercbaseredhosp"]);
        _usapercbaseredmedico = AlterarTipo<string>(leitor["Usapercbaseredmedico"]);
        _usapercbaseredope = AlterarTipo<string>(leitor["Usapercbaseredope"]);
        _usapercbaseredopf = AlterarTipo<string>(leitor["Usapercbaseredopf"]);
        _usapercbaseredopm = AlterarTipo<string>(leitor["Usapercbaseredopm"]);
        _usapmcbasest = AlterarTipo<string>(leitor["Usapmcbasest"]);
        _usaredbaseicmsfontest = AlterarTipo<string>(leitor["Usaredbaseicmsfontest"]);
        _usavalorultentbasest = AlterarTipo<string>(leitor["Usavalorultentbasest"]);
        _usavalorultentbasest2 = AlterarTipo<string>(leitor["Usavalorultentbasest2"]);
        _utilizaparcadicfecp = AlterarTipo<string>(leitor["Utilizaparcadicfecp"]);
        _utilizapercbaseredpf = AlterarTipo<string>(leitor["Utilizapercbaseredpf"]);
        _vlpautasemiva = AlterarTipo<decimal?>(leitor["Vlpautasemiva"]);
        _zerarbaseicmsorgpubsuframa = AlterarTipo<string>(leitor["Zerarbaseicmsorgpubsuframa"]);
        _perctributos = AlterarTipo<decimal?>(leitor["Perctributos"]);
        _geraricmslivrofiscal = AlterarTipo<string>(leitor["Geraricmslivrofiscal"]);
    }

}