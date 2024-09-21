

////// namespace nwErp.Entidades.Winthor;

// namespace nwErp.Api.Modelos;

[Serializable]
public class PCNFSAID : GerenteDePropriedades, IEntidade
{
    private static readonly string RO_AGENCIAPGTOGNRE = "Agenciapgtognre";

    private string _agenciapgtognre;

    private static readonly string RO_AGREGARSTPRODSINTEGRA = "Agregarstprodsintegra";

    private string _agregarstprodsintegra;

    private static readonly string RO_ALIQICMOUTRASDESP = "Aliqicmoutrasdesp";

    private decimal? _aliqicmoutrasdesp;

    private static readonly string RO_ALIQUOTA = "Aliquota";

    private decimal? _aliquota;

    private static readonly string RO_AMBIENTE = "Ambiente";

    private string _ambiente;

    private static readonly string RO_AMBIENTECTE = "Ambientecte";

    private string _ambientecte;

    private static readonly string RO_AMBIENTENFE = "Ambientenfe";

    private string _ambientenfe;

    private static readonly string RO_APRESENTOUCUPOMPROMOCAO = "Apresentoucupompromocao";

    private string _apresentoucupompromocao;

    private static readonly string RO_ATACADISTA = "Atacadista";

    private string _atacadista;

    private static readonly string RO_AUTENTPGTOGNRE = "Autentpgtognre";

    private string _autentpgtognre;

    private static readonly string RO_BAIRRO = "Bairro";

    private string _bairro;

    private static readonly string RO_BANCOPGTOGNRE = "Bancopgtognre";

    private string _bancopgtognre;

    private static readonly string RO_BCST = "Bcst";

    private decimal? _bcst;

    private static readonly string RO_BCSTGNRE = "Bcstgnre";

    private decimal? _bcstgnre;

    private static readonly string RO_BROKER = "Broker";

    private string _broker;

    private static readonly string RO_CAIXA = "Caixa";

    private decimal _caixa;

    private static readonly string RO_CEP = "Cep";

    private string _cep;

    private static readonly string RO_CGC = "Cgc";

    private string _cgc;

    private static readonly string RO_CGCFILIAL = "Cgcfilial";

    private string _cgcfilial;

    private static readonly string RO_CGCFRETE = "Cgcfrete";

    private string _cgcfrete;

    private static readonly string RO_CHAVECTE = "Chavecte";

    private string _chavecte;

    private static readonly string RO_CHAVENFE = "Chavenfe";

    private string _chavenfe;

    private static readonly string RO_CLIENTE = "Cliente";

    private string _cliente;

    private static readonly string RO_CLIENTEFONTEST = "Clientefontest";

    private string _clientefontest;

    private static readonly string RO_CNPJCISP = "Cnpjcisp";

    private string _cnpjcisp;

    private static readonly string RO_COBRANCA = "Cobranca";

    private string _cobranca;

    private static readonly string RO_CODATV1 = "Codatv1";

    private decimal? _codatv1;

    private static readonly string RO_CODBNF = "Codbnf";

    private decimal? _codbnf;

    private static readonly string RO_CODCLI = "Codcli";

    private decimal _codcli;

    private static readonly string RO_CODCLIFILIAL = "Codclifilial";

    private decimal? _codclifilial;

    private static readonly string RO_CODCLINF = "Codclinf";

    private decimal? _codclinf;

    private static readonly string RO_CODCLIRECEBEDOR = "Codclirecebedor";

    private decimal? _codclirecebedor;

    private static readonly string RO_CODCOB = "Codcob";

    private string _codcob;

    private static readonly string RO_CODCONDICAOVENDA = "Codcondicaovenda";

    private decimal? _codcondicaovenda;

    private static readonly string RO_CODCONSIGNATARIOFRETE = "Codconsignatariofrete";

    private decimal? _codconsignatariofrete;

    private static readonly string RO_CODCONT = "Codcont";

    private string _codcont;

    private static readonly string RO_CODCONTCLI = "Codcontcli";

    private decimal? _codcontcli;

    private static readonly string RO_CODCONTRATO = "Codcontrato";

    private decimal? _codcontrato;

    private static readonly string RO_CODDESTINATARIOFRETE = "Coddestinatariofrete";

    private decimal? _coddestinatariofrete;

    private static readonly string RO_CODDEVOL = "Coddevol";

    private decimal? _coddevol;

    private static readonly string RO_CODDOC = "Coddoc";

    private string _coddoc;

    private static readonly string RO_CODEMITENTE = "Codemitente";

    private decimal? _codemitente;

    private static readonly string RO_CODEMITENTEPEDIDO = "Codemitentepedido";

    private decimal? _codemitentepedido;

    private static readonly string RO_CODEPTO = "Codepto";

    private decimal? _codepto;

    private static readonly string RO_CODEXPORTADOR = "Codexportador";

    private decimal? _codexportador;

    private static readonly string RO_CODFILIAL = "Codfilial";

    private string _codfilial;

    private static readonly string RO_CODFILIALNF = "Codfilialnf";

    private string _codfilialnf;

    private static readonly string RO_CODFISCAL = "Codfiscal";

    private decimal _codfiscal;

    private static readonly string RO_CODFISCALFRETE = "Codfiscalfrete";

    private decimal? _codfiscalfrete;

    private static readonly string RO_CODFISCALNF = "Codfiscalnf";

    private decimal? _codfiscalnf;

    private static readonly string RO_CODFISCALOUTRASDESP = "Codfiscaloutrasdesp";

    private decimal? _codfiscaloutrasdesp;

    private static readonly string RO_CODFORNEC = "Codfornec";

    private decimal? _codfornec;

    private static readonly string RO_CODFORNECBONIFIC = "Codfornecbonific";

    private decimal? _codfornecbonific;

    private static readonly string RO_CODFORNECFRETE = "Codfornecfrete";

    private decimal? _codfornecfrete;

    private static readonly string RO_CODFORNECREDESPACHO = "Codfornecredespacho";

    private decimal? _codfornecredespacho;

    private static readonly string RO_CODFUNCCANCEL = "Codfunccancel";

    private decimal? _codfunccancel;

    private static readonly string RO_CODFUNCLANC = "Codfunclanc";

    private decimal? _codfunclanc;

    private static readonly string RO_CODFUNCLIBENT = "Codfunclibent";

    private decimal? _codfunclibent;

    private static readonly string RO_CODFUNCLIBERACAOENTREGA = "Codfuncliberacaoentrega";

    private decimal? _codfuncliberacaoentrega;

    private static readonly string RO_CODGERENTE = "Codgerente";

    private decimal? _codgerente;

    private static readonly string RO_CODIBGE = "Codibge";

    private decimal? _codibge;

    private static readonly string RO_CODMOTORISTA = "Codmotorista";

    private decimal? _codmotorista;

    private static readonly string RO_CODMUNICIPIO = "Codmunicipio";

    private decimal? _codmunicipio;

    private static readonly string RO_CODPAIS = "Codpais";

    private decimal? _codpais;

    private static readonly string RO_CODPLPAG = "Codplpag";

    private decimal? _codplpag;

    private static readonly string RO_CODPRACA = "Codpraca";

    private decimal _codpraca;

    private static readonly string RO_CODPRACADESTFRETE = "Codpracadestfrete";

    private decimal? _codpracadestfrete;

    private static readonly string RO_CODPRODPREDOMINANTE = "Codprodpredominante";

    private decimal? _codprodpredominante;

    private static readonly string RO_CODREMETENTEFRETE = "Codremetentefrete";

    private decimal? _codremetentefrete;

    private static readonly string RO_CODSITTRIBPISCOFINS = "Codsittribpiscofins";

    private decimal? _codsittribpiscofins;

    private static readonly string RO_CODSUPERVISOR = "Codsupervisor";

    private decimal? _codsupervisor;

    private static readonly string RO_CODSUPERVISOR2 = "Codsupervisor2";

    private decimal? _codsupervisor2;

    private static readonly string RO_CODSUPERVISOR3 = "Codsupervisor3";

    private decimal? _codsupervisor3;

    private static readonly string RO_CODUNIDADEEXECUTORA = "Codunidadeexecutora";

    private string _codunidadeexecutora;

    private static readonly string RO_CODUSUR = "Codusur";

    private decimal _codusur;

    private static readonly string RO_CODUSUR2 = "Codusur2";

    private decimal? _codusur2;

    private static readonly string RO_CODUSUR3 = "Codusur3";

    private decimal? _codusur3;

    private static readonly string RO_CODUSUR4 = "Codusur4";

    private decimal? _codusur4;

    private static readonly string RO_CODVEICULO = "Codveiculo";

    private decimal? _codveiculo;

    private static readonly string RO_CODVEICULO1 = "Codveiculo1";

    private decimal? _codveiculo1;

    private static readonly string RO_CODVEICULO2 = "Codveiculo2";

    private decimal? _codveiculo2;

    private static readonly string RO_COFINSRETIDO = "Cofinsretido";

    private string _cofinsretido;

    private static readonly string RO_COMISSAO = "Comissao";

    private decimal? _comissao;

    private static readonly string RO_COMISSAOMOT = "Comissaomot";

    private decimal? _comissaomot;

    private static readonly string RO_COMISSAOSUP = "Comissaosup";

    private decimal? _comissaosup;

    private static readonly string RO_COMISSAO2 = "Comissao2";

    private decimal? _comissao2;

    private static readonly string RO_COMISSAO3 = "Comissao3";

    private decimal? _comissao3;

    private static readonly string RO_COMISSAO4 = "Comissao4";

    private decimal? _comissao4;

    private static readonly string RO_CONDVENDA = "Condvenda";

    private decimal? _condvenda;

    private static readonly string RO_CONFERIDO = "Conferido";

    private string _conferido;

    private static readonly string RO_CONSUMIDORFINAL = "Consumidorfinal";

    private string _consumidorfinal;

    private static readonly string RO_CONSUMIUNUMCTE = "Consumiunumcte";

    private string _consumiunumcte;

    private static readonly string RO_CONSUMIUNUMNFE = "Consumiunumnfe";

    private string _consumiunumnfe;

    private static readonly string RO_CONTADORCUPOMFISCAL = "Contadorcupomfiscal";

    private decimal? _contadorcupomfiscal;

    private static readonly string RO_CONTAORDEM = "Contaordem";

    private string _contaordem;

    private static readonly string RO_CONTRIBUINTE = "Contribuinte";

    private string _contribuinte;

    private static readonly string RO_CSLLRETIDO = "Csllretido";

    private string _csllretido;

    private static readonly string RO_CUSTOBONIFICACAO = "Custobonificacao";

    private string _custobonificacao;

    private static readonly string RO_DATAEMPENHO = "Dataempenho";

    private DateTime? _dataempenho;

    private static readonly string RO_DEPOSITOFECHADO = "Depositofechado";

    private string _depositofechado;

    private static readonly string RO_DESCPAIS = "Descpais";

    private string _descpais;

    private static readonly string RO_DESPESASRATEADA = "Despesasrateada";

    private string _despesasrateada;

    private static readonly string RO_DTAHORAENTRADACONTIGENCIA = "Dtahoraentradacontigencia";

    private DateTime? _dtahoraentradacontigencia;

    private static readonly string RO_DTA_HORAENVIOSEFAZ = "Dta_Horaenviosefaz";

    private DateTime? _dta_horaenviosefaz;

    private static readonly string RO_DTCANCEL = "Dtcancel";

    private DateTime? _dtcancel;

    private static readonly string RO_DTCANCELWMS = "Dtcancelwms";

    private DateTime? _dtcancelwms;

    private static readonly string RO_DTCANHOTO = "Dtcanhoto";

    private DateTime? _dtcanhoto;

    private static readonly string RO_DTDENEGADA = "Dtdenegada";

    private DateTime? _dtdenegada;

    private static readonly string RO_DTDEVOL = "Dtdevol";

    private DateTime? _dtdevol;

    private static readonly string RO_DTEMISSAODECLARACAO = "Dtemissaodeclaracao";

    private DateTime? _dtemissaodeclaracao;

    private static readonly string RO_DTEMISSAONFFORNEC = "Dtemissaonffornec";

    private DateTime? _dtemissaonffornec;

    private static readonly string RO_DTENTREGA = "Dtentrega";

    private DateTime? _dtentrega;

    private static readonly string RO_DTEXPORTACAOSERVINT = "Dtexportacaoservint";

    private DateTime? _dtexportacaoservint;

    private static readonly string RO_DTEXPORTACAOWMS = "Dtexportacaowms";

    private DateTime? _dtexportacaowms;

    private static readonly string RO_DTFAT = "Dtfat";

    private DateTime? _dtfat;

    private static readonly string RO_DTFECHA = "Dtfecha";

    private DateTime? _dtfecha;

    private static readonly string RO_DTFECHACCRCA = "Dtfechaccrca";

    private DateTime? _dtfechaccrca;

    private static readonly string RO_DTHORAAUTORIZACAOSEFAZ = "Dthoraautorizacaosefaz";

    private DateTime? _dthoraautorizacaosefaz;

    private static readonly string RO_DTHORACANCELAMENTOSEFAZ = "Dthoracancelamentosefaz";

    private DateTime? _dthoracancelamentosefaz;

    private static readonly string RO_DTHORACHEGADA = "Dthorachegada";

    private DateTime? _dthorachegada;

    private static readonly string RO_DTHORACTE = "Dthoracte";

    private DateTime? _dthoracte;

    private static readonly string RO_DTHORANFE = "Dthoranfe";

    private DateTime? _dthoranfe;

    private static readonly string RO_DTHORARECIBODPEC = "Dthorarecibodpec";

    private DateTime? _dthorarecibodpec;

    private static readonly string RO_DTHORASAIDA = "Dthorasaida";

    private DateTime? _dthorasaida;

    private static readonly string RO_DTIMPORTACAOSERVPRINC = "Dtimportacaoservprinc";

    private DateTime? _dtimportacaoservprinc;

    private static readonly string RO_DTIMPORTACAOWMS = "Dtimportacaowms";

    private DateTime? _dtimportacaowms;

    private static readonly string RO_DTLANCTO = "Dtlancto";

    private DateTime? _dtlancto;

    private static readonly string RO_DTLIBENT = "Dtlibent";

    private DateTime? _dtlibent;

    private static readonly string RO_DTLIBERACAOENTREGA = "Dtliberacaoentrega";

    private DateTime? _dtliberacaoentrega;

    private static readonly string RO_DTNSU = "Dtnsu";

    private DateTime? _dtnsu;

    private static readonly string RO_DTPAGCOMISSAOPROF = "Dtpagcomissaoprof";

    private DateTime? _dtpagcomissaoprof;

    private static readonly string RO_DTPGTOCAMPANHA = "Dtpgtocampanha";

    private DateTime? _dtpgtocampanha;

    private static readonly string RO_DTSAIDA = "Dtsaida";

    private DateTime _dtsaida;

    private static readonly string RO_DTSAIDANF = "Dtsaidanf";

    private DateTime? _dtsaidanf;

    private static readonly string RO_DTWMS = "Dtwms";

    private DateTime? _dtwms;

    private static readonly string RO_EMAILDEST = "Emaildest";

    private string _emaildest;

    private static readonly string RO_EMAILFRETE = "Emailfrete";

    private string _emailfrete;

    private static readonly string RO_EMAILFRETEREDESPACHO = "Emailfreteredespacho";

    private string _emailfreteredespacho;

    private static readonly string RO_ENDERECO = "Endereco";

    private string _endereco;

    private static readonly string RO_ENTREGA = "Entrega";

    private string _entrega;

    private static readonly string RO_ENVIADA = "Enviada";

    private string _enviada;

    private static readonly string RO_ENVIADANFE = "Enviadanfe";

    private string _enviadanfe;

    private static readonly string RO_EQUIPLANC = "Equiplanc";

    private string _equiplanc;

    private static readonly string RO_ESPECIE = "Especie";

    private string _especie;

    private static readonly string RO_ESPECIEVOLUME = "Especievolume";

    private string _especievolume;

    private static readonly string RO_EXPORTADOSERVINT = "Exportadoservint";

    private string _exportadoservint;

    private static readonly string RO_FINALIDADENFE = "Finalidadenfe";

    private string _finalidadenfe;

    private static readonly string RO_FORNECENTREGA = "Fornecentrega";

    private string _fornecentrega;

    private static readonly string RO_FRETEDESPACHO = "Fretedespacho";

    private string _fretedespacho;

    private static readonly string RO_FRETEREDESPACHO = "Freteredespacho";

    private string _freteredespacho;

    private static readonly string RO_FUNCLANC = "Funclanc";

    private string _funclanc;

    private static readonly string RO_GERACAORAZAOAUXILIAR = "Geracaorazaoauxiliar";

    private string _geracaorazaoauxiliar;

    private static readonly string RO_GERACP = "Geracp";

    private string _geracp;

    private static readonly string RO_GERARBCRNFE = "Gerarbcrnfe";

    private string _gerarbcrnfe;

    private static readonly string RO_HISTORICO = "Historico";

    private string _historico;

    private static readonly string RO_HORAEMISSAO = "Horaemissao";

    private string _horaemissao;

    private static readonly string RO_HORALANC = "Horalanc";

    private string _horalanc;

    private static readonly string RO_ICMSRETIDO = "Icmsretido";

    private decimal? _icmsretido;

    private static readonly string RO_ICMSRETIDOGNRE = "Icmsretidognre";

    private decimal? _icmsretidognre;

    private static readonly string RO_IE = "Ie";

    private string _ie;

    private static readonly string RO_IEENT = "Ieent";

    private string _ieent;

    private static readonly string RO_IEFILIAL = "Iefilial";

    private string _iefilial;

    private static readonly string RO_IEFRETE = "Iefrete";

    private string _iefrete;

    private static readonly string RO_IESUBSTTRIBUT = "Iesubsttribut";

    private string _iesubsttribut;

    private static readonly string RO_IMPORTADOSERVPRINC = "Importadoservprinc";

    private string _importadoservprinc;

    private static readonly string RO_INSSRETIDO = "Inssretido";

    private string _inssretido;

    private static readonly string RO_IRRRETIDO = "Irrretido";

    private string _irrretido;

    private static readonly string RO_JUSTIFICATIVACONTIGENCIA = "Justificativacontigencia";

    private string _justificativacontigencia;

    private static readonly string RO_KMFINALENTREGA = "Kmfinalentrega";

    private decimal? _kmfinalentrega;

    private static readonly string RO_LOCALDESEMBARACO = "Localdesembaraco";

    private string _localdesembaraco;

    private static readonly string RO_LOTEDPEC = "Lotedpec";

    private string _lotedpec;

    private static readonly string RO_MARCARVOLUME = "Marcarvolume";

    private string _marcarvolume;

    private static readonly string RO_MENSAGEMPISCOFINS = "Mensagempiscofins";

    private string _mensagempiscofins;

    private static readonly string RO_MINUTOLANC = "Minutolanc";

    private string _minutolanc;

    private static readonly string RO_MOTORISTAVEICULO = "Motoristaveiculo";

    private string _motoristaveiculo;

    private static readonly string RO_MUNICIPIO = "Municipio";

    private string _municipio;

    private static readonly string RO_NFATUALWMS = "Nfatualwms";

    private string _nfatualwms;

    private static readonly string RO_NFFORNEC = "Nffornec";

    private decimal? _nffornec;

    private static readonly string RO_NORMAREGESPECIAL = "Normaregespecial";

    private string _normaregespecial;

    private static readonly string RO_NSU = "Nsu";

    private decimal? _nsu;

    private static readonly string RO_NUMCAIXAFISCAL = "Numcaixafiscal";

    private decimal? _numcaixafiscal;

    private static readonly string RO_NUMCAR = "Numcar";

    private decimal? _numcar;

    private static readonly string RO_NUMCARANTERIOR = "Numcaranterior";

    private decimal? _numcaranterior;

    private static readonly string RO_NUMCARGAEDI = "Numcargaedi";

    private decimal? _numcargaedi;

    private static readonly string RO_NUMCOLETA = "Numcoleta";

    private string _numcoleta;

    private static readonly string RO_NUMCONTRATO = "Numcontrato";

    private decimal? _numcontrato;

    private static readonly string RO_NUMCUPOM = "Numcupom";

    private decimal? _numcupom;

    private static readonly string RO_NUMECF = "Numecf";

    private decimal? _numecf;

    private static readonly string RO_NUMEMPENHO = "Numempenho";

    private string _numempenho;

    private static readonly string RO_NUMENDERECO = "Numendereco";

    private string _numendereco;

    private static readonly string RO_NUMFORMULARIO = "Numformulario";

    private decimal? _numformulario;

    private static readonly string RO_NUMIDF = "Numidf";

    private string _numidf;

    private static readonly string RO_NUMITENS = "Numitens";

    private decimal? _numitens;

    private static readonly string RO_NUMLANCCP = "Numlanccp";

    private decimal? _numlanccp;

    private static readonly string RO_NUMLISTA = "Numlista";

    private decimal? _numlista;

    private static readonly string RO_NUMLOTECTE = "Numlotecte";

    private string _numlotecte;

    private static readonly string RO_NUMLOTENFE = "Numlotenfe";

    private string _numlotenfe;

    private static readonly string RO_NUMNFTRANSF = "Numnftransf";

    private decimal? _numnftransf;

    private static readonly string RO_NUMNOTA = "Numnota";

    private decimal _numnota;

    private static readonly string RO_NUMOP = "Numop";

    private decimal? _numop;

    private static readonly string RO_NUMORCA = "Numorca";

    private decimal? _numorca;

    private static readonly string RO_NUMORCAFILIAL = "Numorcafilial";

    private decimal? _numorcafilial;

    private static readonly string RO_NUMOS = "Numos";

    private decimal? _numos;

    private static readonly string RO_NUMPED = "Numped";

    private decimal? _numped;

    private static readonly string RO_NUMPEDCLI = "Numpedcli";

    private string _numpedcli;

    private static readonly string RO_NUMPREVENDA = "Numprevenda";

    private decimal? _numprevenda;

    private static readonly string RO_NUMREGIAO = "Numregiao";

    private decimal? _numregiao;

    private static readonly string RO_NUMREGIAOFRETE = "Numregiaofrete";

    private decimal? _numregiaofrete;

    private static readonly string RO_NUMSELONF = "Numselonf";

    private decimal? _numselonf;

    private static readonly string RO_NUMSEQ = "Numseq";

    private decimal? _numseq;

    private static readonly string RO_NUMSEQENTREGA = "Numseqentrega";

    private decimal? _numseqentrega;

    private static readonly string RO_NUMSEQMONTAGEM = "Numseqmontagem";

    private decimal? _numseqmontagem;

    private static readonly string RO_NUMSERIEEQUIP = "Numserieequip";

    private string _numserieequip;

    private static readonly string RO_NUMTAB = "Numtab";

    private decimal? _numtab;

    private static readonly string RO_NUMTRANSENTDEST = "Numtransentdest";

    private decimal? _numtransentdest;

    private static readonly string RO_NUMTRANSENTORIGEM = "Numtransentorigem";

    private decimal? _numtransentorigem;

    private static readonly string RO_NUMTRANSVENDA = "Numtransvenda";

    private decimal _numtransvenda;

    private static readonly string RO_NUMTRANSVENDACONHEC = "Numtransvendaconhec";

    private decimal? _numtransvendaconhec;

    private static readonly string RO_NUMTRANSVENDADESTINO = "Numtransvendadestino";

    private decimal? _numtransvendadestino;

    private static readonly string RO_NUMTRANSVENDAECF = "Numtransvendaecf";

    private decimal? _numtransvendaecf;

    private static readonly string RO_NUMTRANSVENDAORIGEM = "Numtransvendaorigem";

    private decimal? _numtransvendaorigem;

    private static readonly string RO_NUMVIAS = "Numvias";

    private decimal? _numvias;

    private static readonly string RO_NUMVIASPU = "Numviaspu";

    private decimal? _numviaspu;

    private static readonly string RO_NUMVOLUME = "Numvolume";

    private decimal? _numvolume;

    private static readonly string RO_OBS = "Obs";

    private string _obs;

    private static readonly string RO_OBSCONHECFRETE = "Obsconhecfrete";

    private string _obsconhecfrete;

    private static readonly string RO_OBSEXP = "Obsexp";

    private string _obsexp;

    private static readonly string RO_OBSNFCARREG = "Obsnfcarreg";

    private string _obsnfcarreg;

    private static readonly string RO_OBSNFE = "Obsnfe";

    private string _obsnfe;

    private static readonly string RO_OBSPISCOFINS = "Obspiscofins";

    private string _obspiscofins;

    private static readonly string RO_ORGAOPUB = "Orgaopub";

    private string _orgaopub;

    private static readonly string RO_PERBASEREDOUTRASDESP = "Perbaseredoutrasdesp";

    private decimal? _perbaseredoutrasdesp;

    private static readonly string RO_PERCCOMPROFISSIONAL = "Perccomprofissional";

    private decimal? _perccomprofissional;

    private static readonly string RO_PERCFRETE = "Percfrete";

    private decimal? _percfrete;

    private static readonly string RO_PERCFRETERETIDO = "Percfreteretido";

    private decimal? _percfreteretido;

    private static readonly string RO_PERCICMFRETE = "Percicmfrete";

    private decimal? _percicmfrete;

    private static readonly string RO_PERCOFINS = "Percofins";

    private decimal? _percofins;

    private static readonly string RO_PERCSTFRETERETIDO = "Percstfreteretido";

    private decimal? _percstfreteretido;

    private static readonly string RO_PERDESCFIN = "Perdescfin";

    private decimal? _perdescfin;

    private static readonly string RO_PERPIS = "Perpis";

    private decimal? _perpis;

    private static readonly string RO_PISRETIDO = "Pisretido";

    private string _pisretido;

    private static readonly string RO_PLACAVEIC = "Placaveic";

    private string _placaveic;

    private static readonly string RO_PRAZOADICIONAL = "Prazoadicional";

    private decimal? _prazoadicional;

    private static readonly string RO_PRAZOMEDIO = "Prazomedio";

    private decimal? _prazomedio;

    private static readonly string RO_PRAZOPONDERADO = "Prazoponderado";

    private string _prazoponderado;

    private static readonly string RO_PRAZO1 = "Prazo1";

    private decimal? _prazo1;

    private static readonly string RO_PRAZO10 = "Prazo10";

    private decimal? _prazo10;

    private static readonly string RO_PRAZO11 = "Prazo11";

    private decimal? _prazo11;

    private static readonly string RO_PRAZO12 = "Prazo12";

    private decimal? _prazo12;

    private static readonly string RO_PRAZO2 = "Prazo2";

    private decimal? _prazo2;

    private static readonly string RO_PRAZO3 = "Prazo3";

    private decimal? _prazo3;

    private static readonly string RO_PRAZO4 = "Prazo4";

    private decimal? _prazo4;

    private static readonly string RO_PRAZO5 = "Prazo5";

    private decimal? _prazo5;

    private static readonly string RO_PRAZO6 = "Prazo6";

    private decimal? _prazo6;

    private static readonly string RO_PRAZO7 = "Prazo7";

    private decimal? _prazo7;

    private static readonly string RO_PRAZO8 = "Prazo8";

    private decimal? _prazo8;

    private static readonly string RO_PRAZO9 = "Prazo9";

    private decimal? _prazo9;

    private static readonly string RO_PROTOCOLO = "Protocolo";

    private string _protocolo;

    private static readonly string RO_PROTOCOLOCANCELAMENTO = "Protocolocancelamento";

    private string _protocolocancelamento;

    private static readonly string RO_PROTOCOLOCANCELAMENTOCTE = "Protocolocancelamentocte";

    private string _protocolocancelamentocte;

    private static readonly string RO_PROTOCOLOCTE = "Protocolocte";

    private string _protocolocte;

    private static readonly string RO_PROTOCOLONFE = "Protocolonfe";

    private string _protocolonfe;

    private static readonly string RO_PROTOCOLONFEAUTO = "Protocolonfeauto";

    private string _protocolonfeauto;

    private static readonly string RO_PROTOCOLONFECAN = "Protocolonfecan";

    private string _protocolonfecan;

    private static readonly string RO_RECARGA = "Recarga";

    private string _recarga;

    private static readonly string RO_RECIBOCTE = "Recibocte";

    private string _recibocte;

    private static readonly string RO_RECIBODPEC = "Recibodpec";

    private string _recibodpec;

    private static readonly string RO_RECIBONFE = "Recibonfe";

    private string _recibonfe;

    private static readonly string RO_RESERVARITENSTV7 = "Reservaritenstv7";

    private string _reservaritenstv7;

    private static readonly string RO_ROTINALANC = "Rotinalanc";

    private string _rotinalanc;

    private static readonly string RO_SERIE = "Serie";

    private string _serie;

    private static readonly string RO_SERIEECF = "Serieecf";

    private string _serieecf;

    private static readonly string RO_SERIEORIGINAL = "Serieoriginal";

    private string _serieoriginal;

    private static readonly string RO_SITDOC = "Sitdoc";

    private string _sitdoc;

    private static readonly string RO_SITUACAOCTE = "Situacaocte";

    private decimal? _situacaocte;

    private static readonly string RO_SITUACAONFE = "Situacaonfe";

    private decimal? _situacaonfe;

    private static readonly string RO_STRIBUT = "Stribut";

    private decimal? _stribut;

    private static readonly string RO_SUBSERIE = "Subserie";

    private string _subserie;

    private static readonly string RO_SULFRAMA = "Sulframa";

    private string _sulframa;

    private static readonly string RO_TAXAENTREGA = "Taxaentrega";

    private decimal? _taxaentrega;

    private static readonly string RO_TELEFONE = "Telefone";

    private string _telefone;

    private static readonly string RO_TENTATIVAENVIOCTE = "Tentativaenviocte";

    private decimal? _tentativaenviocte;

    private static readonly string RO_TENTATIVAENVIONFE = "Tentativaenvionfe";

    private decimal? _tentativaenvionfe;

    private static readonly string RO_TIPOALIQOUTRASDESP = "Tipoaliqoutrasdesp";

    private string _tipoaliqoutrasdesp;

    private static readonly string RO_TIPODEVOL = "Tipodevol";

    private string _tipodevol;

    private static readonly string RO_TIPOEMISSAO = "Tipoemissao";

    private string _tipoemissao;

    private static readonly string RO_TIPOEMISSAOCTE = "Tipoemissaocte";

    private string _tipoemissaocte;

    private static readonly string RO_TIPOEMPRESA = "Tipoempresa";

    private string _tipoempresa;

    private static readonly string RO_TIPOFJ = "Tipofj";

    private string _tipofj;

    private static readonly string RO_TIPOFRETE = "Tipofrete";

    private string _tipofrete;

    private static readonly string RO_TIPOVENDA = "Tipovenda";

    private string _tipovenda;

    private static readonly string RO_TOTDIFALIQUOTAS = "Totdifaliquotas";

    private decimal? _totdifaliquotas;

    private static readonly string RO_TOTPESO = "Totpeso";

    private decimal? _totpeso;

    private static readonly string RO_TOTPESOAGRUPADO = "Totpesoagrupado";

    private decimal? _totpesoagrupado;

    private static readonly string RO_TOTPESOBRUTO = "Totpesobruto";

    private decimal? _totpesobruto;

    private static readonly string RO_TOTPESOLIQ = "Totpesoliq";

    private decimal? _totpesoliq;

    private static readonly string RO_TOTPESOLIQAGRUPADO = "Totpesoliqagrupado";

    private decimal? _totpesoliqagrupado;

    private static readonly string RO_TOTVLBONIFIC = "Totvlbonific";

    private decimal? _totvlbonific;

    private static readonly string RO_TOTVLDESCCOM = "Totvldesccom";

    private decimal? _totvldesccom;

    private static readonly string RO_TOTVLDESCFIN = "Totvldescfin";

    private decimal? _totvldescfin;

    private static readonly string RO_TOTVLDESCFLEX = "Totvldescflex";

    private decimal? _totvldescflex;

    private static readonly string RO_TOTVLREDCOMISS = "Totvlredcomiss";

    private decimal? _totvlredcomiss;

    private static readonly string RO_TOTVLREDCOMISSSUP = "Totvlredcomisssup";

    private decimal? _totvlredcomisssup;

    private static readonly string RO_TOTVOLUME = "Totvolume";

    private decimal? _totvolume;

    private static readonly string RO_TOTVOLUMEAGRUPADO = "Totvolumeagrupado";

    private decimal? _totvolumeagrupado;

    private static readonly string RO_TRANSPORTADORA = "Transportadora";

    private string _transportadora;

    private static readonly string RO_UF = "Uf";

    private string _uf;

    private static readonly string RO_UFCODIGO = "Ufcodigo";

    private string _ufcodigo;

    private static readonly string RO_UFDESEMBARACO = "Ufdesembaraco";

    private string _ufdesembaraco;

    private static readonly string RO_UFFILIAL = "Uffilial";

    private string _uffilial;

    private static readonly string RO_UFFRETE = "Uffrete";

    private string _uffrete;

    private static readonly string RO_UFPLACAVEI = "Ufplacavei";

    private string _ufplacavei;

    private static readonly string RO_UFPLACAVEIC = "Ufplacaveic";

    private string _ufplacaveic;

    private static readonly string RO_USAINTEGRACAOWMS = "Usaintegracaowms";

    private string _usaintegracaowms;

    private static readonly string RO_UTILIZAIPICALCICMS = "Utilizaipicalcicms";

    private string _utilizaipicalcicms;

    private static readonly string RO_VALORST = "Valorst";

    private decimal? _valorst;

    private static readonly string RO_VENDAASSISTIDA = "Vendaassistida";

    private string _vendaassistida;

    private static readonly string RO_VENDATRIANGULAR = "Vendatriangular";

    private string _vendatriangular;

    private static readonly string RO_VLBASE = "Vlbase";

    private decimal? _vlbase;

    private static readonly string RO_VLBASEIPI = "Vlbaseipi";

    private decimal? _vlbaseipi;

    private static readonly string RO_VLBASEPISCOFINS = "Vlbasepiscofins";

    private decimal? _vlbasepiscofins;

    private static readonly string RO_VLBONIFIC = "Vlbonific";

    private decimal? _vlbonific;

    private static readonly string RO_VLCOFINS = "Vlcofins";

    private decimal? _vlcofins;

    private static readonly string RO_VLCUSTOCONT = "Vlcustocont";

    private decimal? _vlcustocont;

    private static readonly string RO_VLCUSTOFIN = "Vlcustofin";

    private decimal? _vlcustofin;

    private static readonly string RO_VLCUSTOREAL = "Vlcustoreal";

    private decimal? _vlcustoreal;

    private static readonly string RO_VLCUSTOREP = "Vlcustorep";

    private decimal? _vlcustorep;

    private static readonly string RO_VLDESCABATIMENTO = "Vldescabatimento";

    private decimal? _vldescabatimento;

    private static readonly string RO_VLDESCICMS = "Vldescicms";

    private decimal? _vldescicms;

    private static readonly string RO_VLDESCONTO = "Vldesconto";

    private decimal? _vldesconto;

    private static readonly string RO_VLDESCPROM = "Vldescprom";

    private decimal? _vldescprom;

    private static readonly string RO_VLDESPACHO = "Vldespacho";

    private decimal? _vldespacho;

    private static readonly string RO_VLDESPDENTRONF = "Vldespdentronf";

    private decimal? _vldespdentronf;

    private static readonly string RO_VLDEVOLUCAO = "Vldevolucao";

    private decimal? _vldevolucao;

    private static readonly string RO_VLFRETE = "Vlfrete";

    private decimal? _vlfrete;

    private static readonly string RO_VLFRETENF = "Vlfretenf";

    private decimal? _vlfretenf;

    private static readonly string RO_VLFRETERETIDO = "Vlfreteretido";

    private decimal? _vlfreteretido;

    private static readonly string RO_VLICMS = "Vlicms";

    private decimal? _vlicms;

    private static readonly string RO_VLICMSANTECIPADO = "Vlicmsantecipado";

    private decimal? _vlicmsantecipado;

    private static readonly string RO_VLINSS = "Vlinss";

    private decimal? _vlinss;

    private static readonly string RO_VLIPI = "Vlipi";

    private decimal? _vlipi;

    private static readonly string RO_VLIR = "Vlir";

    private decimal? _vlir;

    private static readonly string RO_VLISENTAS = "Vlisentas";

    private decimal? _vlisentas;

    private static readonly string RO_VLISS = "Vliss";

    private decimal? _vliss;

    private static readonly string RO_VLLTR = "Vlltr";

    private decimal? _vlltr;

    private static readonly string RO_VLOUTRAS = "Vloutras";

    private decimal? _vloutras;

    private static readonly string RO_VLOUTRASDESP = "Vloutrasdesp";

    private decimal? _vloutrasdesp;

    private static readonly string RO_VLPAUTAFRETE = "Vlpautafrete";

    private decimal? _vlpautafrete;

    private static readonly string RO_VLPEDAGIO = "Vlpedagio";

    private decimal? _vlpedagio;

    private static readonly string RO_VLPIS = "Vlpis";

    private decimal? _vlpis;

    private static readonly string RO_VLRECEBIDOBOLETO = "Vlrecebidoboleto";

    private decimal? _vlrecebidoboleto;

    private static readonly string RO_VLRECEBIDOCARTAO = "Vlrecebidocartao";

    private decimal? _vlrecebidocartao;

    private static readonly string RO_VLRECEBIDOCH = "Vlrecebidoch";

    private decimal? _vlrecebidoch;

    private static readonly string RO_VLRECEBIDODIN = "Vlrecebidodin";

    private decimal? _vlrecebidodin;

    private static readonly string RO_VLSECCAT = "Vlseccat";

    private decimal? _vlseccat;

    private static readonly string RO_VLSEGURO = "Vlseguro";

    private decimal? _vlseguro;

    private static readonly string RO_VLSTFRETERETIDO = "Vlstfreteretido";

    private decimal? _vlstfreteretido;

    private static readonly string RO_VLTABELA = "Vltabela";

    private decimal? _vltabela;

    private static readonly string RO_VLTOTAL = "Vltotal";

    private decimal? _vltotal;

    private static readonly string RO_VLTOTALNF = "Vltotalnf";

    private decimal? _vltotalnf;

    private static readonly string RO_VLTOTALSEMDESCICMS = "Vltotalsemdescicms";

    private decimal? _vltotalsemdescicms;

    private static readonly string RO_VLTOTGER = "Vltotger";

    private decimal? _vltotger;

    private static readonly string RO_VLTROCO = "Vltroco";

    private decimal? _vltroco;

    private static readonly string RO_VLVERBACMVCLI = "Vlverbacmvcli";

    private decimal? _vlverbacmvcli;

    private static readonly string RO_WMSCODFUNCIGNORA = "Wmscodfuncignora";

    private decimal? _wmscodfuncignora;

    private static readonly string RO_WMSIGNORADO = "Wmsignorado";

    private string _wmsignorado;

    private static readonly string RO_VLTRIBUTOS = "Vltributos";

    private decimal? _vltributos;

    private static readonly string RO_VLDESCSOCIOTORCEDOR = "Vldescsociotorcedor";

    private decimal? _vldescsociotorcedor;

    private static readonly string RO_IDTIPOPRESENCA = "Idtipopresenca";

    private string _idtipopresenca;

    private static readonly string RO_VLSUBTOTAL = "Vlsubtotal";

    private decimal? _vlsubtotal;

    private static readonly string RO_DOCEMISSAO = "Docemissao";

    private string _docemissao;

    private static readonly string RO_NUMFECHAMENTOMOVCX = "Numfechamentomovcx";

    private decimal? _numfechamentomovcx;

    private static readonly string RO_DTMOVIMENTOCX = "Dtmovimentocx";

    private DateTime? _dtmovimentocx;

    private static readonly string RO_IDENTIFICARCLIENTENFCE = "Identificarclientenfce";

    private string _identificarclientenfce;

    private static readonly string RO_MD5LISTAARQ = "Md5listaarq";

    private string _md5listaarq;

    private static readonly string RO_VENDANFSERIED = "Vendanfseried";

    private string _vendanfseried;

    private DateTime? _datahoraemissaosat;

    private string _chavesat;

    private string _qrcodesat;

    private string _qrcodenfce;

    private string _situacaosat;

    private decimal? _numsessaosat;

    private decimal? _codsefazsat;

    private decimal? _codstatussat;

    private string _numseriesat;

    private static readonly string RO_NOTADUPLIQUESVC = "Notadupliquesvc";

    private string _notadupliquesvc;

    private decimal? _uidregistro;

    private string _idparceiro;

    private string _assinatura;

    private string _indicadordesconto;

    private string _indicadoracrescimo;

    private string _descintermediador;

    private string _cnpjintermediador;

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 30, Precisao = 0)]
    public string Agenciapgtognre
    {
        get
        {
            PropriedadeAcessada(RO_AGENCIAPGTOGNRE);
            return _agenciapgtognre;
        }
        set
        {
            PropriedadeModificada(RO_AGENCIAPGTOGNRE, value);
            _agenciapgtognre = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Agregarstprodsintegra
    {
        get
        {
            PropriedadeAcessada(RO_AGREGARSTPRODSINTEGRA);
            return _agregarstprodsintegra;
        }
        set
        {
            PropriedadeModificada(RO_AGREGARSTPRODSINTEGRA, value);
            _agregarstprodsintegra = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 2)]
    public decimal? Aliqicmoutrasdesp
    {
        get
        {
            PropriedadeAcessada(RO_ALIQICMOUTRASDESP);
            return _aliqicmoutrasdesp;
        }
        set
        {
            PropriedadeModificada(RO_ALIQICMOUTRASDESP, value);
            _aliqicmoutrasdesp = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 7, Precisao = 2)]
    public decimal? Aliquota
    {
        get
        {
            PropriedadeAcessada(RO_ALIQUOTA);
            return _aliquota;
        }
        set
        {
            PropriedadeModificada(RO_ALIQUOTA, value);
            _aliquota = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Ambiente
    {
        get
        {
            PropriedadeAcessada(RO_AMBIENTE);
            return _ambiente;
        }
        set
        {
            PropriedadeModificada(RO_AMBIENTE, value);
            _ambiente = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Ambientecte
    {
        get
        {
            PropriedadeAcessada(RO_AMBIENTECTE);
            return _ambientecte;
        }
        set
        {
            PropriedadeModificada(RO_AMBIENTECTE, value);
            _ambientecte = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Ambientenfe
    {
        get
        {
            PropriedadeAcessada(RO_AMBIENTENFE);
            return _ambientenfe;
        }
        set
        {
            PropriedadeModificada(RO_AMBIENTENFE, value);
            _ambientenfe = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Apresentoucupompromocao
    {
        get
        {
            PropriedadeAcessada(RO_APRESENTOUCUPOMPROMOCAO);
            return _apresentoucupompromocao;
        }
        set
        {
            PropriedadeModificada(RO_APRESENTOUCUPOMPROMOCAO, value);
            _apresentoucupompromocao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Atacadista
    {
        get
        {
            PropriedadeAcessada(RO_ATACADISTA);
            return _atacadista;
        }
        set
        {
            PropriedadeModificada(RO_ATACADISTA, value);
            _atacadista = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 200, Precisao = 0)]
    public string Autentpgtognre
    {
        get
        {
            PropriedadeAcessada(RO_AUTENTPGTOGNRE);
            return _autentpgtognre;
        }
        set
        {
            PropriedadeModificada(RO_AUTENTPGTOGNRE, value);
            _autentpgtognre = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
    public string Bairro
    {
        get
        {
            PropriedadeAcessada(RO_BAIRRO);
            return _bairro;
        }
        set
        {
            PropriedadeModificada(RO_BAIRRO, value);
            _bairro = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 50, Precisao = 0)]
    public string Bancopgtognre
    {
        get
        {
            PropriedadeAcessada(RO_BANCOPGTOGNRE);
            return _bancopgtognre;
        }
        set
        {
            PropriedadeModificada(RO_BANCOPGTOGNRE, value);
            _bancopgtognre = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 2)]
    public decimal? Bcst
    {
        get
        {
            PropriedadeAcessada(RO_BCST);
            return _bcst;
        }
        set
        {
            PropriedadeModificada(RO_BCST, value);
            _bcst = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 2)]
    public decimal? Bcstgnre
    {
        get
        {
            PropriedadeAcessada(RO_BCSTGNRE);
            return _bcstgnre;
        }
        set
        {
            PropriedadeModificada(RO_BCSTGNRE, value);
            _bcstgnre = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Broker
    {
        get
        {
            PropriedadeAcessada(RO_BROKER);
            return _broker;
        }
        set
        {
            PropriedadeModificada(RO_BROKER, value);
            _broker = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal Caixa
    {
        get
        {
            PropriedadeAcessada(RO_CAIXA);
            return _caixa;
        }
        set
        {
            PropriedadeModificada(RO_CAIXA, value);
            _caixa = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 10, Precisao = 0)]
    public string Cep
    {
        get
        {
            PropriedadeAcessada(RO_CEP);
            return _cep;
        }
        set
        {
            PropriedadeModificada(RO_CEP, value);
            _cep = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 18, Precisao = 0)]
    public string Cgc
    {
        get
        {
            PropriedadeAcessada(RO_CGC);
            return _cgc;
        }
        set
        {
            PropriedadeModificada(RO_CGC, value);
            _cgc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 14, Precisao = 0)]
    public string Cgcfilial
    {
        get
        {
            PropriedadeAcessada(RO_CGCFILIAL);
            return _cgcfilial;
        }
        set
        {
            PropriedadeModificada(RO_CGCFILIAL, value);
            _cgcfilial = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 18, Precisao = 0)]
    public string Cgcfrete
    {
        get
        {
            PropriedadeAcessada(RO_CGCFRETE);
            return _cgcfrete;
        }
        set
        {
            PropriedadeModificada(RO_CGCFRETE, value);
            _cgcfrete = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 44, Precisao = 0)]
    public string Chavecte
    {
        get
        {
            PropriedadeAcessada(RO_CHAVECTE);
            return _chavecte;
        }
        set
        {
            PropriedadeModificada(RO_CHAVECTE, value);
            _chavecte = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 45, Precisao = 0)]
    public string Chavenfe
    {
        get
        {
            PropriedadeAcessada(RO_CHAVENFE);
            return _chavenfe;
        }
        set
        {
            PropriedadeModificada(RO_CHAVENFE, value);
            _chavenfe = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
    public string Cliente
    {
        get
        {
            PropriedadeAcessada(RO_CLIENTE);
            return _cliente;
        }
        set
        {
            PropriedadeModificada(RO_CLIENTE, value);
            _cliente = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Clientefontest
    {
        get
        {
            PropriedadeAcessada(RO_CLIENTEFONTEST);
            return _clientefontest;
        }
        set
        {
            PropriedadeModificada(RO_CLIENTEFONTEST, value);
            _clientefontest = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 8, Precisao = 0)]
    public string Cnpjcisp
    {
        get
        {
            PropriedadeAcessada(RO_CNPJCISP);
            return _cnpjcisp;
        }
        set
        {
            PropriedadeModificada(RO_CNPJCISP, value);
            _cnpjcisp = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 30, Precisao = 0)]
    public string Cobranca
    {
        get
        {
            PropriedadeAcessada(RO_COBRANCA);
            return _cobranca;
        }
        set
        {
            PropriedadeModificada(RO_COBRANCA, value);
            _cobranca = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codatv1
    {
        get
        {
            PropriedadeAcessada(RO_CODATV1);
            return _codatv1;
        }
        set
        {
            PropriedadeModificada(RO_CODATV1, value);
            _codatv1 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Codbnf
    {
        get
        {
            PropriedadeAcessada(RO_CODBNF);
            return _codbnf;
        }
        set
        {
            PropriedadeModificada(RO_CODBNF, value);
            _codbnf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codclifilial
    {
        get
        {
            PropriedadeAcessada(RO_CODCLIFILIAL);
            return _codclifilial;
        }
        set
        {
            PropriedadeModificada(RO_CODCLIFILIAL, value);
            _codclifilial = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codclinf
    {
        get
        {
            PropriedadeAcessada(RO_CODCLINF);
            return _codclinf;
        }
        set
        {
            PropriedadeModificada(RO_CODCLINF, value);
            _codclinf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codclirecebedor
    {
        get
        {
            PropriedadeAcessada(RO_CODCLIRECEBEDOR);
            return _codclirecebedor;
        }
        set
        {
            PropriedadeModificada(RO_CODCLIRECEBEDOR, value);
            _codclirecebedor = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 4, Precisao = 0)]
    public string Codcob
    {
        get
        {
            PropriedadeAcessada(RO_CODCOB);
            return _codcob;
        }
        set
        {
            PropriedadeModificada(RO_CODCOB, value);
            _codcob = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codcondicaovenda
    {
        get
        {
            PropriedadeAcessada(RO_CODCONDICAOVENDA);
            return _codcondicaovenda;
        }
        set
        {
            PropriedadeModificada(RO_CODCONDICAOVENDA, value);
            _codcondicaovenda = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codconsignatariofrete
    {
        get
        {
            PropriedadeAcessada(RO_CODCONSIGNATARIOFRETE);
            return _codconsignatariofrete;
        }
        set
        {
            PropriedadeModificada(RO_CODCONSIGNATARIOFRETE, value);
            _codconsignatariofrete = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 8, Precisao = 0)]
    public string Codcont
    {
        get
        {
            PropriedadeAcessada(RO_CODCONT);
            return _codcont;
        }
        set
        {
            PropriedadeModificada(RO_CODCONT, value);
            _codcont = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Codcontcli
    {
        get
        {
            PropriedadeAcessada(RO_CODCONTCLI);
            return _codcontcli;
        }
        set
        {
            PropriedadeModificada(RO_CODCONTCLI, value);
            _codcontcli = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codcontrato
    {
        get
        {
            PropriedadeAcessada(RO_CODCONTRATO);
            return _codcontrato;
        }
        set
        {
            PropriedadeModificada(RO_CODCONTRATO, value);
            _codcontrato = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Coddestinatariofrete
    {
        get
        {
            PropriedadeAcessada(RO_CODDESTINATARIOFRETE);
            return _coddestinatariofrete;
        }
        set
        {
            PropriedadeModificada(RO_CODDESTINATARIOFRETE, value);
            _coddestinatariofrete = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 4, Precisao = 0)]
    public string Coddoc
    {
        get
        {
            PropriedadeAcessada(RO_CODDOC);
            return _coddoc;
        }
        set
        {
            PropriedadeModificada(RO_CODDOC, value);
            _coddoc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codemitente
    {
        get
        {
            PropriedadeAcessada(RO_CODEMITENTE);
            return _codemitente;
        }
        set
        {
            PropriedadeModificada(RO_CODEMITENTE, value);
            _codemitente = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codemitentepedido
    {
        get
        {
            PropriedadeAcessada(RO_CODEMITENTEPEDIDO);
            return _codemitentepedido;
        }
        set
        {
            PropriedadeModificada(RO_CODEMITENTEPEDIDO, value);
            _codemitentepedido = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codexportador
    {
        get
        {
            PropriedadeAcessada(RO_CODEXPORTADOR);
            return _codexportador;
        }
        set
        {
            PropriedadeModificada(RO_CODEXPORTADOR, value);
            _codexportador = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal Codfiscal
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Codfiscalfrete
    {
        get
        {
            PropriedadeAcessada(RO_CODFISCALFRETE);
            return _codfiscalfrete;
        }
        set
        {
            PropriedadeModificada(RO_CODFISCALFRETE, value);
            _codfiscalfrete = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfiscalnf
    {
        get
        {
            PropriedadeAcessada(RO_CODFISCALNF);
            return _codfiscalnf;
        }
        set
        {
            PropriedadeModificada(RO_CODFISCALNF, value);
            _codfiscalnf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Codfiscaloutrasdesp
    {
        get
        {
            PropriedadeAcessada(RO_CODFISCALOUTRASDESP);
            return _codfiscaloutrasdesp;
        }
        set
        {
            PropriedadeModificada(RO_CODFISCALOUTRASDESP, value);
            _codfiscaloutrasdesp = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codfornecbonific
    {
        get
        {
            PropriedadeAcessada(RO_CODFORNECBONIFIC);
            return _codfornecbonific;
        }
        set
        {
            PropriedadeModificada(RO_CODFORNECBONIFIC, value);
            _codfornecbonific = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codfornecfrete
    {
        get
        {
            PropriedadeAcessada(RO_CODFORNECFRETE);
            return _codfornecfrete;
        }
        set
        {
            PropriedadeModificada(RO_CODFORNECFRETE, value);
            _codfornecfrete = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codfornecredespacho
    {
        get
        {
            PropriedadeAcessada(RO_CODFORNECREDESPACHO);
            return _codfornecredespacho;
        }
        set
        {
            PropriedadeModificada(RO_CODFORNECREDESPACHO, value);
            _codfornecredespacho = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfunccancel
    {
        get
        {
            PropriedadeAcessada(RO_CODFUNCCANCEL);
            return _codfunccancel;
        }
        set
        {
            PropriedadeModificada(RO_CODFUNCCANCEL, value);
            _codfunccancel = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfunclibent
    {
        get
        {
            PropriedadeAcessada(RO_CODFUNCLIBENT);
            return _codfunclibent;
        }
        set
        {
            PropriedadeModificada(RO_CODFUNCLIBENT, value);
            _codfunclibent = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfuncliberacaoentrega
    {
        get
        {
            PropriedadeAcessada(RO_CODFUNCLIBERACAOENTREGA);
            return _codfuncliberacaoentrega;
        }
        set
        {
            PropriedadeModificada(RO_CODFUNCLIBERACAOENTREGA, value);
            _codfuncliberacaoentrega = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Codgerente
    {
        get
        {
            PropriedadeAcessada(RO_CODGERENTE);
            return _codgerente;
        }
        set
        {
            PropriedadeModificada(RO_CODGERENTE, value);
            _codgerente = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Codibge
    {
        get
        {
            PropriedadeAcessada(RO_CODIBGE);
            return _codibge;
        }
        set
        {
            PropriedadeModificada(RO_CODIBGE, value);
            _codibge = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Codmunicipio
    {
        get
        {
            PropriedadeAcessada(RO_CODMUNICIPIO);
            return _codmunicipio;
        }
        set
        {
            PropriedadeModificada(RO_CODMUNICIPIO, value);
            _codmunicipio = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codpais
    {
        get
        {
            PropriedadeAcessada(RO_CODPAIS);
            return _codpais;
        }
        set
        {
            PropriedadeModificada(RO_CODPAIS, value);
            _codpais = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal Codpraca
    {
        get
        {
            PropriedadeAcessada(RO_CODPRACA);
            return _codpraca;
        }
        set
        {
            PropriedadeModificada(RO_CODPRACA, value);
            _codpraca = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codpracadestfrete
    {
        get
        {
            PropriedadeAcessada(RO_CODPRACADESTFRETE);
            return _codpracadestfrete;
        }
        set
        {
            PropriedadeModificada(RO_CODPRACADESTFRETE, value);
            _codpracadestfrete = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codprodpredominante
    {
        get
        {
            PropriedadeAcessada(RO_CODPRODPREDOMINANTE);
            return _codprodpredominante;
        }
        set
        {
            PropriedadeModificada(RO_CODPRODPREDOMINANTE, value);
            _codprodpredominante = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codremetentefrete
    {
        get
        {
            PropriedadeAcessada(RO_CODREMETENTEFRETE);
            return _codremetentefrete;
        }
        set
        {
            PropriedadeModificada(RO_CODREMETENTEFRETE, value);
            _codremetentefrete = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 3, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Codsupervisor
    {
        get
        {
            PropriedadeAcessada(RO_CODSUPERVISOR);
            return _codsupervisor;
        }
        set
        {
            PropriedadeModificada(RO_CODSUPERVISOR, value);
            _codsupervisor = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Codsupervisor2
    {
        get
        {
            PropriedadeAcessada(RO_CODSUPERVISOR2);
            return _codsupervisor2;
        }
        set
        {
            PropriedadeModificada(RO_CODSUPERVISOR2, value);
            _codsupervisor2 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Codsupervisor3
    {
        get
        {
            PropriedadeAcessada(RO_CODSUPERVISOR3);
            return _codsupervisor3;
        }
        set
        {
            PropriedadeModificada(RO_CODSUPERVISOR3, value);
            _codsupervisor3 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
    public string Codunidadeexecutora
    {
        get
        {
            PropriedadeAcessada(RO_CODUNIDADEEXECUTORA);
            return _codunidadeexecutora;
        }
        set
        {
            PropriedadeModificada(RO_CODUNIDADEEXECUTORA, value);
            _codunidadeexecutora = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Codusur2
    {
        get
        {
            PropriedadeAcessada(RO_CODUSUR2);
            return _codusur2;
        }
        set
        {
            PropriedadeModificada(RO_CODUSUR2, value);
            _codusur2 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Codusur3
    {
        get
        {
            PropriedadeAcessada(RO_CODUSUR3);
            return _codusur3;
        }
        set
        {
            PropriedadeModificada(RO_CODUSUR3, value);
            _codusur3 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codusur4
    {
        get
        {
            PropriedadeAcessada(RO_CODUSUR4);
            return _codusur4;
        }
        set
        {
            PropriedadeModificada(RO_CODUSUR4, value);
            _codusur4 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Codveiculo
    {
        get
        {
            PropriedadeAcessada(RO_CODVEICULO);
            return _codveiculo;
        }
        set
        {
            PropriedadeModificada(RO_CODVEICULO, value);
            _codveiculo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Codveiculo1
    {
        get
        {
            PropriedadeAcessada(RO_CODVEICULO1);
            return _codveiculo1;
        }
        set
        {
            PropriedadeModificada(RO_CODVEICULO1, value);
            _codveiculo1 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Codveiculo2
    {
        get
        {
            PropriedadeAcessada(RO_CODVEICULO2);
            return _codveiculo2;
        }
        set
        {
            PropriedadeModificada(RO_CODVEICULO2, value);
            _codveiculo2 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Cofinsretido
    {
        get
        {
            PropriedadeAcessada(RO_COFINSRETIDO);
            return _cofinsretido;
        }
        set
        {
            PropriedadeModificada(RO_COFINSRETIDO, value);
            _cofinsretido = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 2)]
    public decimal? Comissao
    {
        get
        {
            PropriedadeAcessada(RO_COMISSAO);
            return _comissao;
        }
        set
        {
            PropriedadeModificada(RO_COMISSAO, value);
            _comissao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 2)]
    public decimal? Comissaomot
    {
        get
        {
            PropriedadeAcessada(RO_COMISSAOMOT);
            return _comissaomot;
        }
        set
        {
            PropriedadeModificada(RO_COMISSAOMOT, value);
            _comissaomot = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Comissaosup
    {
        get
        {
            PropriedadeAcessada(RO_COMISSAOSUP);
            return _comissaosup;
        }
        set
        {
            PropriedadeModificada(RO_COMISSAOSUP, value);
            _comissaosup = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 2)]
    public decimal? Comissao2
    {
        get
        {
            PropriedadeAcessada(RO_COMISSAO2);
            return _comissao2;
        }
        set
        {
            PropriedadeModificada(RO_COMISSAO2, value);
            _comissao2 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 2)]
    public decimal? Comissao3
    {
        get
        {
            PropriedadeAcessada(RO_COMISSAO3);
            return _comissao3;
        }
        set
        {
            PropriedadeModificada(RO_COMISSAO3, value);
            _comissao3 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 2)]
    public decimal? Comissao4
    {
        get
        {
            PropriedadeAcessada(RO_COMISSAO4);
            return _comissao4;
        }
        set
        {
            PropriedadeModificada(RO_COMISSAO4, value);
            _comissao4 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Conferido
    {
        get
        {
            PropriedadeAcessada(RO_CONFERIDO);
            return _conferido;
        }
        set
        {
            PropriedadeModificada(RO_CONFERIDO, value);
            _conferido = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Consumidorfinal
    {
        get
        {
            PropriedadeAcessada(RO_CONSUMIDORFINAL);
            return _consumidorfinal;
        }
        set
        {
            PropriedadeModificada(RO_CONSUMIDORFINAL, value);
            _consumidorfinal = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Consumiunumcte
    {
        get
        {
            PropriedadeAcessada(RO_CONSUMIUNUMCTE);
            return _consumiunumcte;
        }
        set
        {
            PropriedadeModificada(RO_CONSUMIUNUMCTE, value);
            _consumiunumcte = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Consumiunumnfe
    {
        get
        {
            PropriedadeAcessada(RO_CONSUMIUNUMNFE);
            return _consumiunumnfe;
        }
        set
        {
            PropriedadeModificada(RO_CONSUMIUNUMNFE, value);
            _consumiunumnfe = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Contadorcupomfiscal
    {
        get
        {
            PropriedadeAcessada(RO_CONTADORCUPOMFISCAL);
            return _contadorcupomfiscal;
        }
        set
        {
            PropriedadeModificada(RO_CONTADORCUPOMFISCAL, value);
            _contadorcupomfiscal = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Contaordem
    {
        get
        {
            PropriedadeAcessada(RO_CONTAORDEM);
            return _contaordem;
        }
        set
        {
            PropriedadeModificada(RO_CONTAORDEM, value);
            _contaordem = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Contribuinte
    {
        get
        {
            PropriedadeAcessada(RO_CONTRIBUINTE);
            return _contribuinte;
        }
        set
        {
            PropriedadeModificada(RO_CONTRIBUINTE, value);
            _contribuinte = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Csllretido
    {
        get
        {
            PropriedadeAcessada(RO_CSLLRETIDO);
            return _csllretido;
        }
        set
        {
            PropriedadeModificada(RO_CSLLRETIDO, value);
            _csllretido = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Custobonificacao
    {
        get
        {
            PropriedadeAcessada(RO_CUSTOBONIFICACAO);
            return _custobonificacao;
        }
        set
        {
            PropriedadeModificada(RO_CUSTOBONIFICACAO, value);
            _custobonificacao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dataempenho
    {
        get
        {
            PropriedadeAcessada(RO_DATAEMPENHO);
            return _dataempenho;
        }
        set
        {
            PropriedadeModificada(RO_DATAEMPENHO, value);
            _dataempenho = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Depositofechado
    {
        get
        {
            PropriedadeAcessada(RO_DEPOSITOFECHADO);
            return _depositofechado;
        }
        set
        {
            PropriedadeModificada(RO_DEPOSITOFECHADO, value);
            _depositofechado = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 60, Precisao = 0)]
    public string Descpais
    {
        get
        {
            PropriedadeAcessada(RO_DESCPAIS);
            return _descpais;
        }
        set
        {
            PropriedadeModificada(RO_DESCPAIS, value);
            _descpais = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Despesasrateada
    {
        get
        {
            PropriedadeAcessada(RO_DESPESASRATEADA);
            return _despesasrateada;
        }
        set
        {
            PropriedadeModificada(RO_DESPESASRATEADA, value);
            _despesasrateada = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtahoraentradacontigencia
    {
        get
        {
            PropriedadeAcessada(RO_DTAHORAENTRADACONTIGENCIA);
            return _dtahoraentradacontigencia;
        }
        set
        {
            PropriedadeModificada(RO_DTAHORAENTRADACONTIGENCIA, value);
            _dtahoraentradacontigencia = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dta_Horaenviosefaz
    {
        get
        {
            PropriedadeAcessada(RO_DTA_HORAENVIOSEFAZ);
            return _dta_horaenviosefaz;
        }
        set
        {
            PropriedadeModificada(RO_DTA_HORAENVIOSEFAZ, value);
            _dta_horaenviosefaz = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtcancelwms
    {
        get
        {
            PropriedadeAcessada(RO_DTCANCELWMS);
            return _dtcancelwms;
        }
        set
        {
            PropriedadeModificada(RO_DTCANCELWMS, value);
            _dtcancelwms = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtcanhoto
    {
        get
        {
            PropriedadeAcessada(RO_DTCANHOTO);
            return _dtcanhoto;
        }
        set
        {
            PropriedadeModificada(RO_DTCANHOTO, value);
            _dtcanhoto = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtdevol
    {
        get
        {
            PropriedadeAcessada(RO_DTDEVOL);
            return _dtdevol;
        }
        set
        {
            PropriedadeModificada(RO_DTDEVOL, value);
            _dtdevol = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtemissaodeclaracao
    {
        get
        {
            PropriedadeAcessada(RO_DTEMISSAODECLARACAO);
            return _dtemissaodeclaracao;
        }
        set
        {
            PropriedadeModificada(RO_DTEMISSAODECLARACAO, value);
            _dtemissaodeclaracao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtemissaonffornec
    {
        get
        {
            PropriedadeAcessada(RO_DTEMISSAONFFORNEC);
            return _dtemissaonffornec;
        }
        set
        {
            PropriedadeModificada(RO_DTEMISSAONFFORNEC, value);
            _dtemissaonffornec = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtentrega
    {
        get
        {
            PropriedadeAcessada(RO_DTENTREGA);
            return _dtentrega;
        }
        set
        {
            PropriedadeModificada(RO_DTENTREGA, value);
            _dtentrega = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtfat
    {
        get
        {
            PropriedadeAcessada(RO_DTFAT);
            return _dtfat;
        }
        set
        {
            PropriedadeModificada(RO_DTFAT, value);
            _dtfat = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtfecha
    {
        get
        {
            PropriedadeAcessada(RO_DTFECHA);
            return _dtfecha;
        }
        set
        {
            PropriedadeModificada(RO_DTFECHA, value);
            _dtfecha = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtfechaccrca
    {
        get
        {
            PropriedadeAcessada(RO_DTFECHACCRCA);
            return _dtfechaccrca;
        }
        set
        {
            PropriedadeModificada(RO_DTFECHACCRCA, value);
            _dtfechaccrca = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dthoraautorizacaosefaz
    {
        get
        {
            PropriedadeAcessada(RO_DTHORAAUTORIZACAOSEFAZ);
            return _dthoraautorizacaosefaz;
        }
        set
        {
            PropriedadeModificada(RO_DTHORAAUTORIZACAOSEFAZ, value);
            _dthoraautorizacaosefaz = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dthoracancelamentosefaz
    {
        get
        {
            PropriedadeAcessada(RO_DTHORACANCELAMENTOSEFAZ);
            return _dthoracancelamentosefaz;
        }
        set
        {
            PropriedadeModificada(RO_DTHORACANCELAMENTOSEFAZ, value);
            _dthoracancelamentosefaz = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dthorachegada
    {
        get
        {
            PropriedadeAcessada(RO_DTHORACHEGADA);
            return _dthorachegada;
        }
        set
        {
            PropriedadeModificada(RO_DTHORACHEGADA, value);
            _dthorachegada = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dthoracte
    {
        get
        {
            PropriedadeAcessada(RO_DTHORACTE);
            return _dthoracte;
        }
        set
        {
            PropriedadeModificada(RO_DTHORACTE, value);
            _dthoracte = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dthoranfe
    {
        get
        {
            PropriedadeAcessada(RO_DTHORANFE);
            return _dthoranfe;
        }
        set
        {
            PropriedadeModificada(RO_DTHORANFE, value);
            _dthoranfe = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dthorarecibodpec
    {
        get
        {
            PropriedadeAcessada(RO_DTHORARECIBODPEC);
            return _dthorarecibodpec;
        }
        set
        {
            PropriedadeModificada(RO_DTHORARECIBODPEC, value);
            _dthorarecibodpec = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dthorasaida
    {
        get
        {
            PropriedadeAcessada(RO_DTHORASAIDA);
            return _dthorasaida;
        }
        set
        {
            PropriedadeModificada(RO_DTHORASAIDA, value);
            _dthorasaida = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtlancto
    {
        get
        {
            PropriedadeAcessada(RO_DTLANCTO);
            return _dtlancto;
        }
        set
        {
            PropriedadeModificada(RO_DTLANCTO, value);
            _dtlancto = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtlibent
    {
        get
        {
            PropriedadeAcessada(RO_DTLIBENT);
            return _dtlibent;
        }
        set
        {
            PropriedadeModificada(RO_DTLIBENT, value);
            _dtlibent = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtliberacaoentrega
    {
        get
        {
            PropriedadeAcessada(RO_DTLIBERACAOENTREGA);
            return _dtliberacaoentrega;
        }
        set
        {
            PropriedadeModificada(RO_DTLIBERACAOENTREGA, value);
            _dtliberacaoentrega = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtnsu
    {
        get
        {
            PropriedadeAcessada(RO_DTNSU);
            return _dtnsu;
        }
        set
        {
            PropriedadeModificada(RO_DTNSU, value);
            _dtnsu = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtpagcomissaoprof
    {
        get
        {
            PropriedadeAcessada(RO_DTPAGCOMISSAOPROF);
            return _dtpagcomissaoprof;
        }
        set
        {
            PropriedadeModificada(RO_DTPAGCOMISSAOPROF, value);
            _dtpagcomissaoprof = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtpgtocampanha
    {
        get
        {
            PropriedadeAcessada(RO_DTPGTOCAMPANHA);
            return _dtpgtocampanha;
        }
        set
        {
            PropriedadeModificada(RO_DTPGTOCAMPANHA, value);
            _dtpgtocampanha = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime Dtsaida
    {
        get
        {
            PropriedadeAcessada(RO_DTSAIDA);
            return _dtsaida;
        }
        set
        {
            PropriedadeModificada(RO_DTSAIDA, value);
            _dtsaida = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtsaidanf
    {
        get
        {
            PropriedadeAcessada(RO_DTSAIDANF);
            return _dtsaidanf;
        }
        set
        {
            PropriedadeModificada(RO_DTSAIDANF, value);
            _dtsaidanf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 100, Precisao = 0)]
    public string Emaildest
    {
        get
        {
            PropriedadeAcessada(RO_EMAILDEST);
            return _emaildest;
        }
        set
        {
            PropriedadeModificada(RO_EMAILDEST, value);
            _emaildest = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 100, Precisao = 0)]
    public string Emailfrete
    {
        get
        {
            PropriedadeAcessada(RO_EMAILFRETE);
            return _emailfrete;
        }
        set
        {
            PropriedadeModificada(RO_EMAILFRETE, value);
            _emailfrete = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 100, Precisao = 0)]
    public string Emailfreteredespacho
    {
        get
        {
            PropriedadeAcessada(RO_EMAILFRETEREDESPACHO);
            return _emailfreteredespacho;
        }
        set
        {
            PropriedadeModificada(RO_EMAILFRETEREDESPACHO, value);
            _emailfreteredespacho = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
    public string Endereco
    {
        get
        {
            PropriedadeAcessada(RO_ENDERECO);
            return _endereco;
        }
        set
        {
            PropriedadeModificada(RO_ENDERECO, value);
            _endereco = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Entrega
    {
        get
        {
            PropriedadeAcessada(RO_ENTREGA);
            return _entrega;
        }
        set
        {
            PropriedadeModificada(RO_ENTREGA, value);
            _entrega = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Enviada
    {
        get
        {
            PropriedadeAcessada(RO_ENVIADA);
            return _enviada;
        }
        set
        {
            PropriedadeModificada(RO_ENVIADA, value);
            _enviada = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Enviadanfe
    {
        get
        {
            PropriedadeAcessada(RO_ENVIADANFE);
            return _enviadanfe;
        }
        set
        {
            PropriedadeModificada(RO_ENVIADANFE, value);
            _enviadanfe = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 64, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Especie
    {
        get
        {
            PropriedadeAcessada(RO_ESPECIE);
            return _especie;
        }
        set
        {
            PropriedadeModificada(RO_ESPECIE, value);
            _especie = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 100, Precisao = 0)]
    public string Especievolume
    {
        get
        {
            PropriedadeAcessada(RO_ESPECIEVOLUME);
            return _especievolume;
        }
        set
        {
            PropriedadeModificada(RO_ESPECIEVOLUME, value);
            _especievolume = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Finalidadenfe
    {
        get
        {
            PropriedadeAcessada(RO_FINALIDADENFE);
            return _finalidadenfe;
        }
        set
        {
            PropriedadeModificada(RO_FINALIDADENFE, value);
            _finalidadenfe = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Fornecentrega
    {
        get
        {
            PropriedadeAcessada(RO_FORNECENTREGA);
            return _fornecentrega;
        }
        set
        {
            PropriedadeModificada(RO_FORNECENTREGA, value);
            _fornecentrega = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Fretedespacho
    {
        get
        {
            PropriedadeAcessada(RO_FRETEDESPACHO);
            return _fretedespacho;
        }
        set
        {
            PropriedadeModificada(RO_FRETEDESPACHO, value);
            _fretedespacho = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Freteredespacho
    {
        get
        {
            PropriedadeAcessada(RO_FRETEREDESPACHO);
            return _freteredespacho;
        }
        set
        {
            PropriedadeModificada(RO_FRETEREDESPACHO, value);
            _freteredespacho = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 30, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Geracaorazaoauxiliar
    {
        get
        {
            PropriedadeAcessada(RO_GERACAORAZAOAUXILIAR);
            return _geracaorazaoauxiliar;
        }
        set
        {
            PropriedadeModificada(RO_GERACAORAZAOAUXILIAR, value);
            _geracaorazaoauxiliar = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Geracp
    {
        get
        {
            PropriedadeAcessada(RO_GERACP);
            return _geracp;
        }
        set
        {
            PropriedadeModificada(RO_GERACP, value);
            _geracp = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Gerarbcrnfe
    {
        get
        {
            PropriedadeAcessada(RO_GERARBCRNFE);
            return _gerarbcrnfe;
        }
        set
        {
            PropriedadeModificada(RO_GERARBCRNFE, value);
            _gerarbcrnfe = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 8, Precisao = 0)]
    public string Horaemissao
    {
        get
        {
            PropriedadeAcessada(RO_HORAEMISSAO);
            return _horaemissao;
        }
        set
        {
            PropriedadeModificada(RO_HORAEMISSAO, value);
            _horaemissao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 2)]
    public decimal? Icmsretido
    {
        get
        {
            PropriedadeAcessada(RO_ICMSRETIDO);
            return _icmsretido;
        }
        set
        {
            PropriedadeModificada(RO_ICMSRETIDO, value);
            _icmsretido = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 2)]
    public decimal? Icmsretidognre
    {
        get
        {
            PropriedadeAcessada(RO_ICMSRETIDOGNRE);
            return _icmsretidognre;
        }
        set
        {
            PropriedadeModificada(RO_ICMSRETIDOGNRE, value);
            _icmsretidognre = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 15, Precisao = 0)]
    public string Ie
    {
        get
        {
            PropriedadeAcessada(RO_IE);
            return _ie;
        }
        set
        {
            PropriedadeModificada(RO_IE, value);
            _ie = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 15, Precisao = 0)]
    public string Ieent
    {
        get
        {
            PropriedadeAcessada(RO_IEENT);
            return _ieent;
        }
        set
        {
            PropriedadeModificada(RO_IEENT, value);
            _ieent = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
    public string Iefilial
    {
        get
        {
            PropriedadeAcessada(RO_IEFILIAL);
            return _iefilial;
        }
        set
        {
            PropriedadeModificada(RO_IEFILIAL, value);
            _iefilial = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 15, Precisao = 0)]
    public string Iefrete
    {
        get
        {
            PropriedadeAcessada(RO_IEFRETE);
            return _iefrete;
        }
        set
        {
            PropriedadeModificada(RO_IEFRETE, value);
            _iefrete = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
    public string Iesubsttribut
    {
        get
        {
            PropriedadeAcessada(RO_IESUBSTTRIBUT);
            return _iesubsttribut;
        }
        set
        {
            PropriedadeModificada(RO_IESUBSTTRIBUT, value);
            _iesubsttribut = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Inssretido
    {
        get
        {
            PropriedadeAcessada(RO_INSSRETIDO);
            return _inssretido;
        }
        set
        {
            PropriedadeModificada(RO_INSSRETIDO, value);
            _inssretido = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Irrretido
    {
        get
        {
            PropriedadeAcessada(RO_IRRRETIDO);
            return _irrretido;
        }
        set
        {
            PropriedadeModificada(RO_IRRRETIDO, value);
            _irrretido = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 256, Precisao = 0)]
    public string Justificativacontigencia
    {
        get
        {
            PropriedadeAcessada(RO_JUSTIFICATIVACONTIGENCIA);
            return _justificativacontigencia;
        }
        set
        {
            PropriedadeModificada(RO_JUSTIFICATIVACONTIGENCIA, value);
            _justificativacontigencia = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 2)]
    public decimal? Kmfinalentrega
    {
        get
        {
            PropriedadeAcessada(RO_KMFINALENTREGA);
            return _kmfinalentrega;
        }
        set
        {
            PropriedadeModificada(RO_KMFINALENTREGA, value);
            _kmfinalentrega = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 30, Precisao = 0)]
    public string Localdesembaraco
    {
        get
        {
            PropriedadeAcessada(RO_LOCALDESEMBARACO);
            return _localdesembaraco;
        }
        set
        {
            PropriedadeModificada(RO_LOCALDESEMBARACO, value);
            _localdesembaraco = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
    public string Lotedpec
    {
        get
        {
            PropriedadeAcessada(RO_LOTEDPEC);
            return _lotedpec;
        }
        set
        {
            PropriedadeModificada(RO_LOTEDPEC, value);
            _lotedpec = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 100, Precisao = 0)]
    public string Marcarvolume
    {
        get
        {
            PropriedadeAcessada(RO_MARCARVOLUME);
            return _marcarvolume;
        }
        set
        {
            PropriedadeModificada(RO_MARCARVOLUME, value);
            _marcarvolume = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 4000, Precisao = 0)]
    public string Mensagempiscofins
    {
        get
        {
            PropriedadeAcessada(RO_MENSAGEMPISCOFINS);
            return _mensagempiscofins;
        }
        set
        {
            PropriedadeModificada(RO_MENSAGEMPISCOFINS, value);
            _mensagempiscofins = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
    public string Motoristaveiculo
    {
        get
        {
            PropriedadeAcessada(RO_MOTORISTAVEICULO);
            return _motoristaveiculo;
        }
        set
        {
            PropriedadeModificada(RO_MOTORISTAVEICULO, value);
            _motoristaveiculo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 30, Precisao = 0)]
    public string Municipio
    {
        get
        {
            PropriedadeAcessada(RO_MUNICIPIO);
            return _municipio;
        }
        set
        {
            PropriedadeModificada(RO_MUNICIPIO, value);
            _municipio = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Nfatualwms
    {
        get
        {
            PropriedadeAcessada(RO_NFATUALWMS);
            return _nfatualwms;
        }
        set
        {
            PropriedadeModificada(RO_NFATUALWMS, value);
            _nfatualwms = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Nffornec
    {
        get
        {
            PropriedadeAcessada(RO_NFFORNEC);
            return _nffornec;
        }
        set
        {
            PropriedadeModificada(RO_NFFORNEC, value);
            _nffornec = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 250, Precisao = 0)]
    public string Normaregespecial
    {
        get
        {
            PropriedadeAcessada(RO_NORMAREGESPECIAL);
            return _normaregespecial;
        }
        set
        {
            PropriedadeModificada(RO_NORMAREGESPECIAL, value);
            _normaregespecial = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Nsu
    {
        get
        {
            PropriedadeAcessada(RO_NSU);
            return _nsu;
        }
        set
        {
            PropriedadeModificada(RO_NSU, value);
            _nsu = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Numcaixafiscal
    {
        get
        {
            PropriedadeAcessada(RO_NUMCAIXAFISCAL);
            return _numcaixafiscal;
        }
        set
        {
            PropriedadeModificada(RO_NUMCAIXAFISCAL, value);
            _numcaixafiscal = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Numcargaedi
    {
        get
        {
            PropriedadeAcessada(RO_NUMCARGAEDI);
            return _numcargaedi;
        }
        set
        {
            PropriedadeModificada(RO_NUMCARGAEDI, value);
            _numcargaedi = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 10, Precisao = 0)]
    public string Numcoleta
    {
        get
        {
            PropriedadeAcessada(RO_NUMCOLETA);
            return _numcoleta;
        }
        set
        {
            PropriedadeModificada(RO_NUMCOLETA, value);
            _numcoleta = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Numcontrato
    {
        get
        {
            PropriedadeAcessada(RO_NUMCONTRATO);
            return _numcontrato;
        }
        set
        {
            PropriedadeModificada(RO_NUMCONTRATO, value);
            _numcontrato = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numecf
    {
        get
        {
            PropriedadeAcessada(RO_NUMECF);
            return _numecf;
        }
        set
        {
            PropriedadeModificada(RO_NUMECF, value);
            _numecf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
    public string Numempenho
    {
        get
        {
            PropriedadeAcessada(RO_NUMEMPENHO);
            return _numempenho;
        }
        set
        {
            PropriedadeModificada(RO_NUMEMPENHO, value);
            _numempenho = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 6, Precisao = 0)]
    public string Numendereco
    {
        get
        {
            PropriedadeAcessada(RO_NUMENDERECO);
            return _numendereco;
        }
        set
        {
            PropriedadeModificada(RO_NUMENDERECO, value);
            _numendereco = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 30, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Numitens
    {
        get
        {
            PropriedadeAcessada(RO_NUMITENS);
            return _numitens;
        }
        set
        {
            PropriedadeModificada(RO_NUMITENS, value);
            _numitens = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 15, Precisao = 0)]
    public string Numlotecte
    {
        get
        {
            PropriedadeAcessada(RO_NUMLOTECTE);
            return _numlotecte;
        }
        set
        {
            PropriedadeModificada(RO_NUMLOTECTE, value);
            _numlotecte = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 15, Precisao = 0)]
    public string Numlotenfe
    {
        get
        {
            PropriedadeAcessada(RO_NUMLOTENFE);
            return _numlotenfe;
        }
        set
        {
            PropriedadeModificada(RO_NUMLOTENFE, value);
            _numlotenfe = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numnftransf
    {
        get
        {
            PropriedadeAcessada(RO_NUMNFTRANSF);
            return _numnftransf;
        }
        set
        {
            PropriedadeModificada(RO_NUMNFTRANSF, value);
            _numnftransf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numorca
    {
        get
        {
            PropriedadeAcessada(RO_NUMORCA);
            return _numorca;
        }
        set
        {
            PropriedadeModificada(RO_NUMORCA, value);
            _numorca = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numorcafilial
    {
        get
        {
            PropriedadeAcessada(RO_NUMORCAFILIAL);
            return _numorcafilial;
        }
        set
        {
            PropriedadeModificada(RO_NUMORCAFILIAL, value);
            _numorcafilial = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Numos
    {
        get
        {
            PropriedadeAcessada(RO_NUMOS);
            return _numos;
        }
        set
        {
            PropriedadeModificada(RO_NUMOS, value);
            _numos = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 15, Precisao = 0)]
    public string Numpedcli
    {
        get
        {
            PropriedadeAcessada(RO_NUMPEDCLI);
            return _numpedcli;
        }
        set
        {
            PropriedadeModificada(RO_NUMPEDCLI, value);
            _numpedcli = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numprevenda
    {
        get
        {
            PropriedadeAcessada(RO_NUMPREVENDA);
            return _numprevenda;
        }
        set
        {
            PropriedadeModificada(RO_NUMPREVENDA, value);
            _numprevenda = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Numregiaofrete
    {
        get
        {
            PropriedadeAcessada(RO_NUMREGIAOFRETE);
            return _numregiaofrete;
        }
        set
        {
            PropriedadeModificada(RO_NUMREGIAOFRETE, value);
            _numregiaofrete = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numselonf
    {
        get
        {
            PropriedadeAcessada(RO_NUMSELONF);
            return _numselonf;
        }
        set
        {
            PropriedadeModificada(RO_NUMSELONF, value);
            _numselonf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 20, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 20, Precisao = 0)]
    public decimal? Numseqentrega
    {
        get
        {
            PropriedadeAcessada(RO_NUMSEQENTREGA);
            return _numseqentrega;
        }
        set
        {
            PropriedadeModificada(RO_NUMSEQENTREGA, value);
            _numseqentrega = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Numseqmontagem
    {
        get
        {
            PropriedadeAcessada(RO_NUMSEQMONTAGEM);
            return _numseqmontagem;
        }
        set
        {
            PropriedadeModificada(RO_NUMSEQMONTAGEM, value);
            _numseqmontagem = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 30, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Numtab
    {
        get
        {
            PropriedadeAcessada(RO_NUMTAB);
            return _numtab;
        }
        set
        {
            PropriedadeModificada(RO_NUMTAB, value);
            _numtab = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numtransentdest
    {
        get
        {
            PropriedadeAcessada(RO_NUMTRANSENTDEST);
            return _numtransentdest;
        }
        set
        {
            PropriedadeModificada(RO_NUMTRANSENTDEST, value);
            _numtransentdest = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numtransentorigem
    {
        get
        {
            PropriedadeAcessada(RO_NUMTRANSENTORIGEM);
            return _numtransentorigem;
        }
        set
        {
            PropriedadeModificada(RO_NUMTRANSENTORIGEM, value);
            _numtransentorigem = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal Numtransvenda
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 2)]
    public decimal? Numtransvendaconhec
    {
        get
        {
            PropriedadeAcessada(RO_NUMTRANSVENDACONHEC);
            return _numtransvendaconhec;
        }
        set
        {
            PropriedadeModificada(RO_NUMTRANSVENDACONHEC, value);
            _numtransvendaconhec = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numtransvendadestino
    {
        get
        {
            PropriedadeAcessada(RO_NUMTRANSVENDADESTINO);
            return _numtransvendadestino;
        }
        set
        {
            PropriedadeModificada(RO_NUMTRANSVENDADESTINO, value);
            _numtransvendadestino = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numtransvendaecf
    {
        get
        {
            PropriedadeAcessada(RO_NUMTRANSVENDAECF);
            return _numtransvendaecf;
        }
        set
        {
            PropriedadeModificada(RO_NUMTRANSVENDAECF, value);
            _numtransvendaecf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numtransvendaorigem
    {
        get
        {
            PropriedadeAcessada(RO_NUMTRANSVENDAORIGEM);
            return _numtransvendaorigem;
        }
        set
        {
            PropriedadeModificada(RO_NUMTRANSVENDAORIGEM, value);
            _numtransvendaorigem = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Numvias
    {
        get
        {
            PropriedadeAcessada(RO_NUMVIAS);
            return _numvias;
        }
        set
        {
            PropriedadeModificada(RO_NUMVIAS, value);
            _numvias = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Numviaspu
    {
        get
        {
            PropriedadeAcessada(RO_NUMVIASPU);
            return _numviaspu;
        }
        set
        {
            PropriedadeModificada(RO_NUMVIASPU, value);
            _numviaspu = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Numvolume
    {
        get
        {
            PropriedadeAcessada(RO_NUMVOLUME);
            return _numvolume;
        }
        set
        {
            PropriedadeModificada(RO_NUMVOLUME, value);
            _numvolume = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 120, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 100, Precisao = 0)]
    public string Obsconhecfrete
    {
        get
        {
            PropriedadeAcessada(RO_OBSCONHECFRETE);
            return _obsconhecfrete;
        }
        set
        {
            PropriedadeModificada(RO_OBSCONHECFRETE, value);
            _obsconhecfrete = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 200, Precisao = 0)]
    public string Obsexp
    {
        get
        {
            PropriedadeAcessada(RO_OBSEXP);
            return _obsexp;
        }
        set
        {
            PropriedadeModificada(RO_OBSEXP, value);
            _obsexp = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 255, Precisao = 0)]
    public string Obsnfcarreg
    {
        get
        {
            PropriedadeAcessada(RO_OBSNFCARREG);
            return _obsnfcarreg;
        }
        set
        {
            PropriedadeModificada(RO_OBSNFCARREG, value);
            _obsnfcarreg = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Binario, Tamanho = 4000, Precisao = 0)]
    public string Obsnfe
    {
        get
        {
            PropriedadeAcessada(RO_OBSNFE);
            return _obsnfe;
        }
        set
        {
            PropriedadeModificada(RO_OBSNFE, value);
            _obsnfe = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 500, Precisao = 0)]
    public string Obspiscofins
    {
        get
        {
            PropriedadeAcessada(RO_OBSPISCOFINS);
            return _obspiscofins;
        }
        set
        {
            PropriedadeModificada(RO_OBSPISCOFINS, value);
            _obspiscofins = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Orgaopub
    {
        get
        {
            PropriedadeAcessada(RO_ORGAOPUB);
            return _orgaopub;
        }
        set
        {
            PropriedadeModificada(RO_ORGAOPUB, value);
            _orgaopub = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 2)]
    public decimal? Perbaseredoutrasdesp
    {
        get
        {
            PropriedadeAcessada(RO_PERBASEREDOUTRASDESP);
            return _perbaseredoutrasdesp;
        }
        set
        {
            PropriedadeModificada(RO_PERBASEREDOUTRASDESP, value);
            _perbaseredoutrasdesp = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Perccomprofissional
    {
        get
        {
            PropriedadeAcessada(RO_PERCCOMPROFISSIONAL);
            return _perccomprofissional;
        }
        set
        {
            PropriedadeModificada(RO_PERCCOMPROFISSIONAL, value);
            _perccomprofissional = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Percfreteretido
    {
        get
        {
            PropriedadeAcessada(RO_PERCFRETERETIDO);
            return _percfreteretido;
        }
        set
        {
            PropriedadeModificada(RO_PERCFRETERETIDO, value);
            _percfreteretido = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 2)]
    public decimal? Percicmfrete
    {
        get
        {
            PropriedadeAcessada(RO_PERCICMFRETE);
            return _percicmfrete;
        }
        set
        {
            PropriedadeModificada(RO_PERCICMFRETE, value);
            _percicmfrete = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Percstfreteretido
    {
        get
        {
            PropriedadeAcessada(RO_PERCSTFRETERETIDO);
            return _percstfreteretido;
        }
        set
        {
            PropriedadeModificada(RO_PERCSTFRETERETIDO, value);
            _percstfreteretido = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Pisretido
    {
        get
        {
            PropriedadeAcessada(RO_PISRETIDO);
            return _pisretido;
        }
        set
        {
            PropriedadeModificada(RO_PISRETIDO, value);
            _pisretido = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 10, Precisao = 0)]
    public string Placaveic
    {
        get
        {
            PropriedadeAcessada(RO_PLACAVEIC);
            return _placaveic;
        }
        set
        {
            PropriedadeModificada(RO_PLACAVEIC, value);
            _placaveic = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Prazoadicional
    {
        get
        {
            PropriedadeAcessada(RO_PRAZOADICIONAL);
            return _prazoadicional;
        }
        set
        {
            PropriedadeModificada(RO_PRAZOADICIONAL, value);
            _prazoadicional = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Prazoponderado
    {
        get
        {
            PropriedadeAcessada(RO_PRAZOPONDERADO);
            return _prazoponderado;
        }
        set
        {
            PropriedadeModificada(RO_PRAZOPONDERADO, value);
            _prazoponderado = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Prazo1
    {
        get
        {
            PropriedadeAcessada(RO_PRAZO1);
            return _prazo1;
        }
        set
        {
            PropriedadeModificada(RO_PRAZO1, value);
            _prazo1 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Prazo10
    {
        get
        {
            PropriedadeAcessada(RO_PRAZO10);
            return _prazo10;
        }
        set
        {
            PropriedadeModificada(RO_PRAZO10, value);
            _prazo10 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Prazo11
    {
        get
        {
            PropriedadeAcessada(RO_PRAZO11);
            return _prazo11;
        }
        set
        {
            PropriedadeModificada(RO_PRAZO11, value);
            _prazo11 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Prazo12
    {
        get
        {
            PropriedadeAcessada(RO_PRAZO12);
            return _prazo12;
        }
        set
        {
            PropriedadeModificada(RO_PRAZO12, value);
            _prazo12 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Prazo2
    {
        get
        {
            PropriedadeAcessada(RO_PRAZO2);
            return _prazo2;
        }
        set
        {
            PropriedadeModificada(RO_PRAZO2, value);
            _prazo2 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Prazo3
    {
        get
        {
            PropriedadeAcessada(RO_PRAZO3);
            return _prazo3;
        }
        set
        {
            PropriedadeModificada(RO_PRAZO3, value);
            _prazo3 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Prazo4
    {
        get
        {
            PropriedadeAcessada(RO_PRAZO4);
            return _prazo4;
        }
        set
        {
            PropriedadeModificada(RO_PRAZO4, value);
            _prazo4 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Prazo5
    {
        get
        {
            PropriedadeAcessada(RO_PRAZO5);
            return _prazo5;
        }
        set
        {
            PropriedadeModificada(RO_PRAZO5, value);
            _prazo5 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Prazo6
    {
        get
        {
            PropriedadeAcessada(RO_PRAZO6);
            return _prazo6;
        }
        set
        {
            PropriedadeModificada(RO_PRAZO6, value);
            _prazo6 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Prazo7
    {
        get
        {
            PropriedadeAcessada(RO_PRAZO7);
            return _prazo7;
        }
        set
        {
            PropriedadeModificada(RO_PRAZO7, value);
            _prazo7 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Prazo8
    {
        get
        {
            PropriedadeAcessada(RO_PRAZO8);
            return _prazo8;
        }
        set
        {
            PropriedadeModificada(RO_PRAZO8, value);
            _prazo8 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Prazo9
    {
        get
        {
            PropriedadeAcessada(RO_PRAZO9);
            return _prazo9;
        }
        set
        {
            PropriedadeModificada(RO_PRAZO9, value);
            _prazo9 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 50, Precisao = 0)]
    public string Protocolo
    {
        get
        {
            PropriedadeAcessada(RO_PROTOCOLO);
            return _protocolo;
        }
        set
        {
            PropriedadeModificada(RO_PROTOCOLO, value);
            _protocolo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
    public string Protocolocancelamento
    {
        get
        {
            PropriedadeAcessada(RO_PROTOCOLOCANCELAMENTO);
            return _protocolocancelamento;
        }
        set
        {
            PropriedadeModificada(RO_PROTOCOLOCANCELAMENTO, value);
            _protocolocancelamento = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
    public string Protocolocancelamentocte
    {
        get
        {
            PropriedadeAcessada(RO_PROTOCOLOCANCELAMENTOCTE);
            return _protocolocancelamentocte;
        }
        set
        {
            PropriedadeModificada(RO_PROTOCOLOCANCELAMENTOCTE, value);
            _protocolocancelamentocte = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 16, Precisao = 0)]
    public string Protocolocte
    {
        get
        {
            PropriedadeAcessada(RO_PROTOCOLOCTE);
            return _protocolocte;
        }
        set
        {
            PropriedadeModificada(RO_PROTOCOLOCTE, value);
            _protocolocte = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 16, Precisao = 0)]
    public string Protocolonfe
    {
        get
        {
            PropriedadeAcessada(RO_PROTOCOLONFE);
            return _protocolonfe;
        }
        set
        {
            PropriedadeModificada(RO_PROTOCOLONFE, value);
            _protocolonfe = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 16, Precisao = 0)]
    public string Protocolonfeauto
    {
        get
        {
            PropriedadeAcessada(RO_PROTOCOLONFEAUTO);
            return _protocolonfeauto;
        }
        set
        {
            PropriedadeModificada(RO_PROTOCOLONFEAUTO, value);
            _protocolonfeauto = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 16, Precisao = 0)]
    public string Protocolonfecan
    {
        get
        {
            PropriedadeAcessada(RO_PROTOCOLONFECAN);
            return _protocolonfecan;
        }
        set
        {
            PropriedadeModificada(RO_PROTOCOLONFECAN, value);
            _protocolonfecan = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Recarga
    {
        get
        {
            PropriedadeAcessada(RO_RECARGA);
            return _recarga;
        }
        set
        {
            PropriedadeModificada(RO_RECARGA, value);
            _recarga = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
    public string Recibocte
    {
        get
        {
            PropriedadeAcessada(RO_RECIBOCTE);
            return _recibocte;
        }
        set
        {
            PropriedadeModificada(RO_RECIBOCTE, value);
            _recibocte = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
    public string Recibodpec
    {
        get
        {
            PropriedadeAcessada(RO_RECIBODPEC);
            return _recibodpec;
        }
        set
        {
            PropriedadeModificada(RO_RECIBODPEC, value);
            _recibodpec = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
    public string Recibonfe
    {
        get
        {
            PropriedadeAcessada(RO_RECIBONFE);
            return _recibonfe;
        }
        set
        {
            PropriedadeModificada(RO_RECIBONFE, value);
            _recibonfe = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Reservaritenstv7
    {
        get
        {
            PropriedadeAcessada(RO_RESERVARITENSTV7);
            return _reservaritenstv7;
        }
        set
        {
            PropriedadeModificada(RO_RESERVARITENSTV7, value);
            _reservaritenstv7 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 48, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 3, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Serieecf
    {
        get
        {
            PropriedadeAcessada(RO_SERIEECF);
            return _serieecf;
        }
        set
        {
            PropriedadeModificada(RO_SERIEECF, value);
            _serieecf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 3, Precisao = 0)]
    public string Serieoriginal
    {
        get
        {
            PropriedadeAcessada(RO_SERIEORIGINAL);
            return _serieoriginal;
        }
        set
        {
            PropriedadeModificada(RO_SERIEORIGINAL, value);
            _serieoriginal = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Sitdoc
    {
        get
        {
            PropriedadeAcessada(RO_SITDOC);
            return _sitdoc;
        }
        set
        {
            PropriedadeModificada(RO_SITDOC, value);
            _sitdoc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Situacaocte
    {
        get
        {
            PropriedadeAcessada(RO_SITUACAOCTE);
            return _situacaocte;
        }
        set
        {
            PropriedadeModificada(RO_SITUACAOCTE, value);
            _situacaocte = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Situacaonfe
    {
        get
        {
            PropriedadeAcessada(RO_SITUACAONFE);
            return _situacaonfe;
        }
        set
        {
            PropriedadeModificada(RO_SITUACAONFE, value);
            _situacaonfe = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 2)]
    public decimal? Stribut
    {
        get
        {
            PropriedadeAcessada(RO_STRIBUT);
            return _stribut;
        }
        set
        {
            PropriedadeModificada(RO_STRIBUT, value);
            _stribut = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Subserie
    {
        get
        {
            PropriedadeAcessada(RO_SUBSERIE);
            return _subserie;
        }
        set
        {
            PropriedadeModificada(RO_SUBSERIE, value);
            _subserie = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 15, Precisao = 0)]
    public string Sulframa
    {
        get
        {
            PropriedadeAcessada(RO_SULFRAMA);
            return _sulframa;
        }
        set
        {
            PropriedadeModificada(RO_SULFRAMA, value);
            _sulframa = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 2)]
    public decimal? Taxaentrega
    {
        get
        {
            PropriedadeAcessada(RO_TAXAENTREGA);
            return _taxaentrega;
        }
        set
        {
            PropriedadeModificada(RO_TAXAENTREGA, value);
            _taxaentrega = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
    public string Telefone
    {
        get
        {
            PropriedadeAcessada(RO_TELEFONE);
            return _telefone;
        }
        set
        {
            PropriedadeModificada(RO_TELEFONE, value);
            _telefone = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Tentativaenviocte
    {
        get
        {
            PropriedadeAcessada(RO_TENTATIVAENVIOCTE);
            return _tentativaenviocte;
        }
        set
        {
            PropriedadeModificada(RO_TENTATIVAENVIOCTE, value);
            _tentativaenviocte = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Tentativaenvionfe
    {
        get
        {
            PropriedadeAcessada(RO_TENTATIVAENVIONFE);
            return _tentativaenvionfe;
        }
        set
        {
            PropriedadeModificada(RO_TENTATIVAENVIONFE, value);
            _tentativaenvionfe = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Tipoaliqoutrasdesp
    {
        get
        {
            PropriedadeAcessada(RO_TIPOALIQOUTRASDESP);
            return _tipoaliqoutrasdesp;
        }
        set
        {
            PropriedadeModificada(RO_TIPOALIQOUTRASDESP, value);
            _tipoaliqoutrasdesp = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Tipodevol
    {
        get
        {
            PropriedadeAcessada(RO_TIPODEVOL);
            return _tipodevol;
        }
        set
        {
            PropriedadeModificada(RO_TIPODEVOL, value);
            _tipodevol = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Tipoemissao
    {
        get
        {
            PropriedadeAcessada(RO_TIPOEMISSAO);
            return _tipoemissao;
        }
        set
        {
            PropriedadeModificada(RO_TIPOEMISSAO, value);
            _tipoemissao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Tipoemissaocte
    {
        get
        {
            PropriedadeAcessada(RO_TIPOEMISSAOCTE);
            return _tipoemissaocte;
        }
        set
        {
            PropriedadeModificada(RO_TIPOEMISSAOCTE, value);
            _tipoemissaocte = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 4, Precisao = 0)]
    public string Tipoempresa
    {
        get
        {
            PropriedadeAcessada(RO_TIPOEMPRESA);
            return _tipoempresa;
        }
        set
        {
            PropriedadeModificada(RO_TIPOEMPRESA, value);
            _tipoempresa = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Tipofj
    {
        get
        {
            PropriedadeAcessada(RO_TIPOFJ);
            return _tipofj;
        }
        set
        {
            PropriedadeModificada(RO_TIPOFJ, value);
            _tipofj = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Tipofrete
    {
        get
        {
            PropriedadeAcessada(RO_TIPOFRETE);
            return _tipofrete;
        }
        set
        {
            PropriedadeModificada(RO_TIPOFRETE, value);
            _tipofrete = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Tipovenda
    {
        get
        {
            PropriedadeAcessada(RO_TIPOVENDA);
            return _tipovenda;
        }
        set
        {
            PropriedadeModificada(RO_TIPOVENDA, value);
            _tipovenda = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 2)]
    public decimal? Totdifaliquotas
    {
        get
        {
            PropriedadeAcessada(RO_TOTDIFALIQUOTAS);
            return _totdifaliquotas;
        }
        set
        {
            PropriedadeModificada(RO_TOTDIFALIQUOTAS, value);
            _totdifaliquotas = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Totpeso
    {
        get
        {
            PropriedadeAcessada(RO_TOTPESO);
            return _totpeso;
        }
        set
        {
            PropriedadeModificada(RO_TOTPESO, value);
            _totpeso = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Totpesoagrupado
    {
        get
        {
            PropriedadeAcessada(RO_TOTPESOAGRUPADO);
            return _totpesoagrupado;
        }
        set
        {
            PropriedadeModificada(RO_TOTPESOAGRUPADO, value);
            _totpesoagrupado = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Totpesobruto
    {
        get
        {
            PropriedadeAcessada(RO_TOTPESOBRUTO);
            return _totpesobruto;
        }
        set
        {
            PropriedadeModificada(RO_TOTPESOBRUTO, value);
            _totpesobruto = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Totpesoliq
    {
        get
        {
            PropriedadeAcessada(RO_TOTPESOLIQ);
            return _totpesoliq;
        }
        set
        {
            PropriedadeModificada(RO_TOTPESOLIQ, value);
            _totpesoliq = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Totpesoliqagrupado
    {
        get
        {
            PropriedadeAcessada(RO_TOTPESOLIQAGRUPADO);
            return _totpesoliqagrupado;
        }
        set
        {
            PropriedadeModificada(RO_TOTPESOLIQAGRUPADO, value);
            _totpesoliqagrupado = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Totvlbonific
    {
        get
        {
            PropriedadeAcessada(RO_TOTVLBONIFIC);
            return _totvlbonific;
        }
        set
        {
            PropriedadeModificada(RO_TOTVLBONIFIC, value);
            _totvlbonific = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Totvldesccom
    {
        get
        {
            PropriedadeAcessada(RO_TOTVLDESCCOM);
            return _totvldesccom;
        }
        set
        {
            PropriedadeModificada(RO_TOTVLDESCCOM, value);
            _totvldesccom = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Totvldescfin
    {
        get
        {
            PropriedadeAcessada(RO_TOTVLDESCFIN);
            return _totvldescfin;
        }
        set
        {
            PropriedadeModificada(RO_TOTVLDESCFIN, value);
            _totvldescfin = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Totvldescflex
    {
        get
        {
            PropriedadeAcessada(RO_TOTVLDESCFLEX);
            return _totvldescflex;
        }
        set
        {
            PropriedadeModificada(RO_TOTVLDESCFLEX, value);
            _totvldescflex = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Totvlredcomiss
    {
        get
        {
            PropriedadeAcessada(RO_TOTVLREDCOMISS);
            return _totvlredcomiss;
        }
        set
        {
            PropriedadeModificada(RO_TOTVLREDCOMISS, value);
            _totvlredcomiss = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Totvlredcomisssup
    {
        get
        {
            PropriedadeAcessada(RO_TOTVLREDCOMISSSUP);
            return _totvlredcomisssup;
        }
        set
        {
            PropriedadeModificada(RO_TOTVLREDCOMISSSUP, value);
            _totvlredcomisssup = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Totvolume
    {
        get
        {
            PropriedadeAcessada(RO_TOTVOLUME);
            return _totvolume;
        }
        set
        {
            PropriedadeModificada(RO_TOTVOLUME, value);
            _totvolume = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Totvolumeagrupado
    {
        get
        {
            PropriedadeAcessada(RO_TOTVOLUMEAGRUPADO);
            return _totvolumeagrupado;
        }
        set
        {
            PropriedadeModificada(RO_TOTVOLUMEAGRUPADO, value);
            _totvolumeagrupado = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
    public string Transportadora
    {
        get
        {
            PropriedadeAcessada(RO_TRANSPORTADORA);
            return _transportadora;
        }
        set
        {
            PropriedadeModificada(RO_TRANSPORTADORA, value);
            _transportadora = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Uf
    {
        get
        {
            PropriedadeAcessada(RO_UF);
            return _uf;
        }
        set
        {
            PropriedadeModificada(RO_UF, value);
            _uf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Ufcodigo
    {
        get
        {
            PropriedadeAcessada(RO_UFCODIGO);
            return _ufcodigo;
        }
        set
        {
            PropriedadeModificada(RO_UFCODIGO, value);
            _ufcodigo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Ufdesembaraco
    {
        get
        {
            PropriedadeAcessada(RO_UFDESEMBARACO);
            return _ufdesembaraco;
        }
        set
        {
            PropriedadeModificada(RO_UFDESEMBARACO, value);
            _ufdesembaraco = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Uffilial
    {
        get
        {
            PropriedadeAcessada(RO_UFFILIAL);
            return _uffilial;
        }
        set
        {
            PropriedadeModificada(RO_UFFILIAL, value);
            _uffilial = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Uffrete
    {
        get
        {
            PropriedadeAcessada(RO_UFFRETE);
            return _uffrete;
        }
        set
        {
            PropriedadeModificada(RO_UFFRETE, value);
            _uffrete = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Ufplacavei
    {
        get
        {
            PropriedadeAcessada(RO_UFPLACAVEI);
            return _ufplacavei;
        }
        set
        {
            PropriedadeModificada(RO_UFPLACAVEI, value);
            _ufplacavei = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Ufplacaveic
    {
        get
        {
            PropriedadeAcessada(RO_UFPLACAVEIC);
            return _ufplacaveic;
        }
        set
        {
            PropriedadeModificada(RO_UFPLACAVEIC, value);
            _ufplacaveic = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Usaintegracaowms
    {
        get
        {
            PropriedadeAcessada(RO_USAINTEGRACAOWMS);
            return _usaintegracaowms;
        }
        set
        {
            PropriedadeModificada(RO_USAINTEGRACAOWMS, value);
            _usaintegracaowms = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Utilizaipicalcicms
    {
        get
        {
            PropriedadeAcessada(RO_UTILIZAIPICALCICMS);
            return _utilizaipicalcicms;
        }
        set
        {
            PropriedadeModificada(RO_UTILIZAIPICALCICMS, value);
            _utilizaipicalcicms = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 2)]
    public decimal? Valorst
    {
        get
        {
            PropriedadeAcessada(RO_VALORST);
            return _valorst;
        }
        set
        {
            PropriedadeModificada(RO_VALORST, value);
            _valorst = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Vendaassistida
    {
        get
        {
            PropriedadeAcessada(RO_VENDAASSISTIDA);
            return _vendaassistida;
        }
        set
        {
            PropriedadeModificada(RO_VENDAASSISTIDA, value);
            _vendaassistida = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Vendatriangular
    {
        get
        {
            PropriedadeAcessada(RO_VENDATRIANGULAR);
            return _vendatriangular;
        }
        set
        {
            PropriedadeModificada(RO_VENDATRIANGULAR, value);
            _vendatriangular = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 2)]
    public decimal? Vlbase
    {
        get
        {
            PropriedadeAcessada(RO_VLBASE);
            return _vlbase;
        }
        set
        {
            PropriedadeModificada(RO_VLBASE, value);
            _vlbase = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 2)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 2)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 16, Precisao = 3)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 2)]
    public decimal? Vlcustocont
    {
        get
        {
            PropriedadeAcessada(RO_VLCUSTOCONT);
            return _vlcustocont;
        }
        set
        {
            PropriedadeModificada(RO_VLCUSTOCONT, value);
            _vlcustocont = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 2)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 2)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 2)]
    public decimal? Vlcustorep
    {
        get
        {
            PropriedadeAcessada(RO_VLCUSTOREP);
            return _vlcustorep;
        }
        set
        {
            PropriedadeModificada(RO_VLCUSTOREP, value);
            _vlcustorep = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vldescabatimento
    {
        get
        {
            PropriedadeAcessada(RO_VLDESCABATIMENTO);
            return _vldescabatimento;
        }
        set
        {
            PropriedadeModificada(RO_VLDESCABATIMENTO, value);
            _vldescabatimento = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 2)]
    public decimal? Vldescicms
    {
        get
        {
            PropriedadeAcessada(RO_VLDESCICMS);
            return _vldescicms;
        }
        set
        {
            PropriedadeModificada(RO_VLDESCICMS, value);
            _vldescicms = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 2)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 2)]
    public decimal? Vldescprom
    {
        get
        {
            PropriedadeAcessada(RO_VLDESCPROM);
            return _vldescprom;
        }
        set
        {
            PropriedadeModificada(RO_VLDESCPROM, value);
            _vldescprom = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vldespacho
    {
        get
        {
            PropriedadeAcessada(RO_VLDESPACHO);
            return _vldespacho;
        }
        set
        {
            PropriedadeModificada(RO_VLDESPACHO, value);
            _vldespacho = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 2)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 2)]
    public decimal? Vldevolucao
    {
        get
        {
            PropriedadeAcessada(RO_VLDEVOLUCAO);
            return _vldevolucao;
        }
        set
        {
            PropriedadeModificada(RO_VLDEVOLUCAO, value);
            _vldevolucao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 2)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 2)]
    public decimal? Vlfretenf
    {
        get
        {
            PropriedadeAcessada(RO_VLFRETENF);
            return _vlfretenf;
        }
        set
        {
            PropriedadeModificada(RO_VLFRETENF, value);
            _vlfretenf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 2)]
    public decimal? Vlfreteretido
    {
        get
        {
            PropriedadeAcessada(RO_VLFRETERETIDO);
            return _vlfreteretido;
        }
        set
        {
            PropriedadeModificada(RO_VLFRETERETIDO, value);
            _vlfreteretido = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 2)]
    public decimal? Vlicms
    {
        get
        {
            PropriedadeAcessada(RO_VLICMS);
            return _vlicms;
        }
        set
        {
            PropriedadeModificada(RO_VLICMS, value);
            _vlicms = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 2)]
    public decimal? Vlicmsantecipado
    {
        get
        {
            PropriedadeAcessada(RO_VLICMSANTECIPADO);
            return _vlicmsantecipado;
        }
        set
        {
            PropriedadeModificada(RO_VLICMSANTECIPADO, value);
            _vlicmsantecipado = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 2)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlir
    {
        get
        {
            PropriedadeAcessada(RO_VLIR);
            return _vlir;
        }
        set
        {
            PropriedadeModificada(RO_VLIR, value);
            _vlir = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 2)]
    public decimal? Vlisentas
    {
        get
        {
            PropriedadeAcessada(RO_VLISENTAS);
            return _vlisentas;
        }
        set
        {
            PropriedadeModificada(RO_VLISENTAS, value);
            _vlisentas = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlltr
    {
        get
        {
            PropriedadeAcessada(RO_VLLTR);
            return _vlltr;
        }
        set
        {
            PropriedadeModificada(RO_VLLTR, value);
            _vlltr = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 2)]
    public decimal? Vloutras
    {
        get
        {
            PropriedadeAcessada(RO_VLOUTRAS);
            return _vloutras;
        }
        set
        {
            PropriedadeModificada(RO_VLOUTRAS, value);
            _vloutras = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 2)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 2)]
    public decimal? Vlpautafrete
    {
        get
        {
            PropriedadeAcessada(RO_VLPAUTAFRETE);
            return _vlpautafrete;
        }
        set
        {
            PropriedadeModificada(RO_VLPAUTAFRETE, value);
            _vlpautafrete = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlpedagio
    {
        get
        {
            PropriedadeAcessada(RO_VLPEDAGIO);
            return _vlpedagio;
        }
        set
        {
            PropriedadeModificada(RO_VLPEDAGIO, value);
            _vlpedagio = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 2)]
    public decimal? Vlrecebidoboleto
    {
        get
        {
            PropriedadeAcessada(RO_VLRECEBIDOBOLETO);
            return _vlrecebidoboleto;
        }
        set
        {
            PropriedadeModificada(RO_VLRECEBIDOBOLETO, value);
            _vlrecebidoboleto = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 2)]
    public decimal? Vlrecebidocartao
    {
        get
        {
            PropriedadeAcessada(RO_VLRECEBIDOCARTAO);
            return _vlrecebidocartao;
        }
        set
        {
            PropriedadeModificada(RO_VLRECEBIDOCARTAO, value);
            _vlrecebidocartao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 2)]
    public decimal? Vlrecebidoch
    {
        get
        {
            PropriedadeAcessada(RO_VLRECEBIDOCH);
            return _vlrecebidoch;
        }
        set
        {
            PropriedadeModificada(RO_VLRECEBIDOCH, value);
            _vlrecebidoch = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 2)]
    public decimal? Vlrecebidodin
    {
        get
        {
            PropriedadeAcessada(RO_VLRECEBIDODIN);
            return _vlrecebidodin;
        }
        set
        {
            PropriedadeModificada(RO_VLRECEBIDODIN, value);
            _vlrecebidodin = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlseccat
    {
        get
        {
            PropriedadeAcessada(RO_VLSECCAT);
            return _vlseccat;
        }
        set
        {
            PropriedadeModificada(RO_VLSECCAT, value);
            _vlseccat = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 2)]
    public decimal? Vlstfreteretido
    {
        get
        {
            PropriedadeAcessada(RO_VLSTFRETERETIDO);
            return _vlstfreteretido;
        }
        set
        {
            PropriedadeModificada(RO_VLSTFRETERETIDO, value);
            _vlstfreteretido = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 2)]
    public decimal? Vltabela
    {
        get
        {
            PropriedadeAcessada(RO_VLTABELA);
            return _vltabela;
        }
        set
        {
            PropriedadeModificada(RO_VLTABELA, value);
            _vltabela = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 2)]
    public decimal? Vltotal
    {
        get
        {
            PropriedadeAcessada(RO_VLTOTAL);
            return _vltotal;
        }
        set
        {
            PropriedadeModificada(RO_VLTOTAL, value);
            _vltotal = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 2)]
    public decimal? Vltotalnf
    {
        get
        {
            PropriedadeAcessada(RO_VLTOTALNF);
            return _vltotalnf;
        }
        set
        {
            PropriedadeModificada(RO_VLTOTALNF, value);
            _vltotalnf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 2)]
    public decimal? Vltotalsemdescicms
    {
        get
        {
            PropriedadeAcessada(RO_VLTOTALSEMDESCICMS);
            return _vltotalsemdescicms;
        }
        set
        {
            PropriedadeModificada(RO_VLTOTALSEMDESCICMS, value);
            _vltotalsemdescicms = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 2)]
    public decimal? Vltotger
    {
        get
        {
            PropriedadeAcessada(RO_VLTOTGER);
            return _vltotger;
        }
        set
        {
            PropriedadeModificada(RO_VLTOTGER, value);
            _vltotger = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 2)]
    public decimal? Vltroco
    {
        get
        {
            PropriedadeAcessada(RO_VLTROCO);
            return _vltroco;
        }
        set
        {
            PropriedadeModificada(RO_VLTROCO, value);
            _vltroco = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Wmscodfuncignora
    {
        get
        {
            PropriedadeAcessada(RO_WMSCODFUNCIGNORA);
            return _wmscodfuncignora;
        }
        set
        {
            PropriedadeModificada(RO_WMSCODFUNCIGNORA, value);
            _wmscodfuncignora = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Wmsignorado
    {
        get
        {
            PropriedadeAcessada(RO_WMSIGNORADO);
            return _wmsignorado;
        }
        set
        {
            PropriedadeModificada(RO_WMSIGNORADO, value);
            _wmsignorado = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 2)]
    public decimal? Vltributos
    {
        get
        {
            PropriedadeAcessada(RO_VLTRIBUTOS);
            return _vltributos;
        }
        set
        {
            PropriedadeModificada(RO_VLTRIBUTOS, value);
            _vltributos = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 2)]
    public decimal? Vldescsociotorcedor
    {
        get
        {
            PropriedadeAcessada(RO_VLDESCSOCIOTORCEDOR);
            return _vldescsociotorcedor;
        }
        set
        {
            PropriedadeModificada(RO_VLDESCSOCIOTORCEDOR, value);
            _vldescsociotorcedor = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Idtipopresenca
    {
        get
        {
            PropriedadeAcessada(RO_IDTIPOPRESENCA);
            return _idtipopresenca;
        }
        set
        {
            PropriedadeModificada(RO_IDTIPOPRESENCA, value);
            _idtipopresenca = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 2)]
    public decimal? Vlsubtotal
    {
        get
        {
            PropriedadeAcessada(RO_VLSUBTOTAL);
            return _vlsubtotal;
        }
        set
        {
            PropriedadeModificada(RO_VLSUBTOTAL, value);
            _vlsubtotal = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Docemissao
    {
        get
        {
            PropriedadeAcessada(RO_DOCEMISSAO);
            return _docemissao;
        }
        set
        {
            PropriedadeModificada(RO_DOCEMISSAO, value);
            _docemissao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numfechamentomovcx
    {
        get
        {
            PropriedadeAcessada("Numfechamentomovcx");
            return _numfechamentomovcx;
        }
        set
        {
            PropriedadeModificada("Numfechamentomovcx", value);
            _numfechamentomovcx = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtmovimentocx
    {
        get
        {
            PropriedadeAcessada("Dtmovimentocx");
            return _dtmovimentocx;
        }
        set
        {
            PropriedadeModificada("Dtmovimentocx", value);
            _dtmovimentocx = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Identificarclientenfce
    {
        get
        {
            PropriedadeAcessada(RO_IDENTIFICARCLIENTENFCE);
            return _identificarclientenfce;
        }
        set
        {
            PropriedadeModificada(RO_IDENTIFICARCLIENTENFCE, value);
            _identificarclientenfce = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 300, Precisao = 0)]
    public string Md5listaarq
    {
        get
        {
            PropriedadeAcessada(RO_MD5LISTAARQ);
            return _md5listaarq;
        }
        set
        {
            PropriedadeModificada(RO_MD5LISTAARQ, value);
            _md5listaarq = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Vendanfseried
    {
        get
        {
            PropriedadeAcessada(RO_VENDANFSERIED);
            return _vendanfseried;
        }
        set
        {
            PropriedadeModificada(RO_VENDANFSERIED, value);
            _vendanfseried = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Datahoraemissaosat
    {
        get
        {
            PropriedadeAcessada("Datahoraemissaosat");
            return _datahoraemissaosat;
        }
        set
        {
            PropriedadeModificada("Datahoraemissaosat", value);
            _datahoraemissaosat = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 44, Precisao = 0)]
    public string Chavesat
    {
        get
        {
            PropriedadeAcessada("Chavesat");
            return _chavesat;
        }
        set
        {
            PropriedadeModificada("Chavesat", value);
            _chavesat = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 4000, Precisao = 0)]
    public string Qrcodesat
    {
        get
        {
            PropriedadeAcessada("Qrcodesat");
            return _qrcodesat;
        }
        set
        {
            PropriedadeModificada("Qrcodesat", value);
            _qrcodesat = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 500, Precisao = 0)]
    public string Qrcodenfce
    {
        get
        {
            PropriedadeAcessada("Qrcodenfce");
            return _qrcodenfce;
        }
        set
        {
            PropriedadeModificada("Qrcodenfce", value);
            _qrcodenfce = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Situacaosat
    {
        get
        {
            PropriedadeAcessada("Situacaosat");
            return _situacaosat;
        }
        set
        {
            PropriedadeModificada("Situacaosat", value);
            _situacaosat = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numsessaosat
    {
        get
        {
            PropriedadeAcessada("Numsessaosat");
            return _numsessaosat;
        }
        set
        {
            PropriedadeModificada("Numsessaosat", value);
            _numsessaosat = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Codsefazsat
    {
        get
        {
            PropriedadeAcessada("Codsefazsat");
            return _codsefazsat;
        }
        set
        {
            PropriedadeModificada("Codsefazsat", value);
            _codsefazsat = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Codstatussat
    {
        get
        {
            PropriedadeAcessada("Codstatussat");
            return _codstatussat;
        }
        set
        {
            PropriedadeModificada("Codstatussat", value);
            _codstatussat = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 9, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Notadupliquesvc
    {
        get
        {
            PropriedadeAcessada(RO_NOTADUPLIQUESVC);
            return _notadupliquesvc;
        }
        set
        {
            PropriedadeModificada(RO_NOTADUPLIQUESVC, value);
            _notadupliquesvc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Uidregistro
    {
        get
        {
            PropriedadeAcessada("Uidregistro");
            return _uidregistro;
        }
        set
        {
            PropriedadeModificada("Uidregistro", value);
            _uidregistro = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 15, Precisao = 0)]
    public string Idparceiro
    {
        get
        {
            PropriedadeAcessada("Idparceiro");
            return _idparceiro;
        }
        set
        {
            PropriedadeModificada("Idparceiro", value);
            _idparceiro = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 100, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Indicadordesconto
    {
        get
        {
            PropriedadeAcessada("Indicadordesconto");
            return _indicadordesconto;
        }
        set
        {
            PropriedadeModificada("Indicadordesconto", value);
            _indicadordesconto = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Indicadoracrescimo
    {
        get
        {
            PropriedadeAcessada("Indicadoracrescimo");
            return _indicadoracrescimo;
        }
        set
        {
            PropriedadeModificada("Indicadoracrescimo", value);
            _indicadoracrescimo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 60, Precisao = 0)]
    public string Descintermediador
    {
        get
        {
            PropriedadeAcessada("Descintermediador");
            return _descintermediador;
        }
        set
        {
            PropriedadeModificada("Descintermediador", value);
            _descintermediador = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAID", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
    public string Cnpjintermediador
    {
        get
        {
            PropriedadeAcessada("Cnpjintermediador");
            return _cnpjintermediador;
        }
        set
        {
            PropriedadeModificada("Cnpjintermediador", value);
            _cnpjintermediador = value;
        }
    }

    public void InicializarAtributos()
    {
    }

    public string ObterNomeTabela()
    {
        return "PCNFSAID";
    }

    public IEntidade NovaInstancia()
    {
        return (IEntidade)GetType().GetConstructors()[0].Invoke(null);
    }

    public void CarregarPorDataReader(IDataReader leitor)
    {
        _agenciapgtognre = AlterarTipo<string>(leitor["Agenciapgtognre"]);
        _agregarstprodsintegra = AlterarTipo<string>(leitor["Agregarstprodsintegra"]);
        _aliqicmoutrasdesp = AlterarTipo<decimal?>(leitor["Aliqicmoutrasdesp"]);
        _aliquota = AlterarTipo<decimal?>(leitor["Aliquota"]);
        _ambiente = AlterarTipo<string>(leitor["Ambiente"]);
        _ambientecte = AlterarTipo<string>(leitor["Ambientecte"]);
        _ambientenfe = AlterarTipo<string>(leitor["Ambientenfe"]);
        _apresentoucupompromocao = AlterarTipo<string>(leitor["Apresentoucupompromocao"]);
        _atacadista = AlterarTipo<string>(leitor["Atacadista"]);
        _autentpgtognre = AlterarTipo<string>(leitor["Autentpgtognre"]);
        _bairro = AlterarTipo<string>(leitor["Bairro"]);
        _bancopgtognre = AlterarTipo<string>(leitor["Bancopgtognre"]);
        _bcst = AlterarTipo<decimal?>(leitor["Bcst"]);
        _bcstgnre = AlterarTipo<decimal?>(leitor["Bcstgnre"]);
        _broker = AlterarTipo<string>(leitor["Broker"]);
        _caixa = AlterarTipo<decimal>(leitor["Caixa"]);
        _cep = AlterarTipo<string>(leitor["Cep"]);
        _cgc = AlterarTipo<string>(leitor["Cgc"]);
        _cgcfilial = AlterarTipo<string>(leitor["Cgcfilial"]);
        _cgcfrete = AlterarTipo<string>(leitor["Cgcfrete"]);
        _chavecte = AlterarTipo<string>(leitor["Chavecte"]);
        _chavenfe = AlterarTipo<string>(leitor["Chavenfe"]);
        _cliente = AlterarTipo<string>(leitor["Cliente"]);
        _clientefontest = AlterarTipo<string>(leitor["Clientefontest"]);
        _cnpjcisp = AlterarTipo<string>(leitor["Cnpjcisp"]);
        _cobranca = AlterarTipo<string>(leitor["Cobranca"]);
        _codatv1 = AlterarTipo<decimal?>(leitor["Codatv1"]);
        _codbnf = AlterarTipo<decimal?>(leitor["Codbnf"]);
        _codcli = AlterarTipo<decimal>(leitor["Codcli"]);
        _codclifilial = AlterarTipo<decimal?>(leitor["Codclifilial"]);
        _codclinf = AlterarTipo<decimal?>(leitor["Codclinf"]);
        _codclirecebedor = AlterarTipo<decimal?>(leitor["Codclirecebedor"]);
        _codcob = AlterarTipo<string>(leitor["Codcob"]);
        _codcondicaovenda = AlterarTipo<decimal?>(leitor["Codcondicaovenda"]);
        _codconsignatariofrete = AlterarTipo<decimal?>(leitor["Codconsignatariofrete"]);
        _codcont = AlterarTipo<string>(leitor["Codcont"]);
        _codcontcli = AlterarTipo<decimal?>(leitor["Codcontcli"]);
        _codcontrato = AlterarTipo<decimal?>(leitor["Codcontrato"]);
        _coddestinatariofrete = AlterarTipo<decimal?>(leitor["Coddestinatariofrete"]);
        _coddevol = AlterarTipo<decimal?>(leitor["Coddevol"]);
        _coddoc = AlterarTipo<string>(leitor["Coddoc"]);
        _codemitente = AlterarTipo<decimal?>(leitor["Codemitente"]);
        _codemitentepedido = AlterarTipo<decimal?>(leitor["Codemitentepedido"]);
        _codepto = AlterarTipo<decimal?>(leitor["Codepto"]);
        _codexportador = AlterarTipo<decimal?>(leitor["Codexportador"]);
        _codfilial = AlterarTipo<string>(leitor["Codfilial"]);
        _codfilialnf = AlterarTipo<string>(leitor["Codfilialnf"]);
        _codfiscal = AlterarTipo<decimal>(leitor["Codfiscal"]);
        _codfiscalfrete = AlterarTipo<decimal?>(leitor["Codfiscalfrete"]);
        _codfiscalnf = AlterarTipo<decimal?>(leitor["Codfiscalnf"]);
        _codfiscaloutrasdesp = AlterarTipo<decimal?>(leitor["Codfiscaloutrasdesp"]);
        _codfornec = AlterarTipo<decimal?>(leitor["Codfornec"]);
        _codfornecbonific = AlterarTipo<decimal?>(leitor["Codfornecbonific"]);
        _codfornecfrete = AlterarTipo<decimal?>(leitor["Codfornecfrete"]);
        _codfornecredespacho = AlterarTipo<decimal?>(leitor["Codfornecredespacho"]);
        _codfunccancel = AlterarTipo<decimal?>(leitor["Codfunccancel"]);
        _codfunclanc = AlterarTipo<decimal?>(leitor["Codfunclanc"]);
        _codfunclibent = AlterarTipo<decimal?>(leitor["Codfunclibent"]);
        _codfuncliberacaoentrega = AlterarTipo<decimal?>(leitor["Codfuncliberacaoentrega"]);
        _codgerente = AlterarTipo<decimal?>(leitor["Codgerente"]);
        _codibge = AlterarTipo<decimal?>(leitor["Codibge"]);
        _codmotorista = AlterarTipo<decimal?>(leitor["Codmotorista"]);
        _codmunicipio = AlterarTipo<decimal?>(leitor["Codmunicipio"]);
        _codpais = AlterarTipo<decimal?>(leitor["Codpais"]);
        _codplpag = AlterarTipo<decimal?>(leitor["Codplpag"]);
        _codpraca = AlterarTipo<decimal>(leitor["Codpraca"]);
        _codpracadestfrete = AlterarTipo<decimal?>(leitor["Codpracadestfrete"]);
        _codprodpredominante = AlterarTipo<decimal?>(leitor["Codprodpredominante"]);
        _codremetentefrete = AlterarTipo<decimal?>(leitor["Codremetentefrete"]);
        _codsittribpiscofins = AlterarTipo<decimal?>(leitor["Codsittribpiscofins"]);
        _codsupervisor = AlterarTipo<decimal?>(leitor["Codsupervisor"]);
        _codsupervisor2 = AlterarTipo<decimal?>(leitor["Codsupervisor2"]);
        _codsupervisor3 = AlterarTipo<decimal?>(leitor["Codsupervisor3"]);
        _codunidadeexecutora = AlterarTipo<string>(leitor["Codunidadeexecutora"]);
        _codusur = AlterarTipo<decimal>(leitor["Codusur"]);
        _codusur2 = AlterarTipo<decimal?>(leitor["Codusur2"]);
        _codusur3 = AlterarTipo<decimal?>(leitor["Codusur3"]);
        _codusur4 = AlterarTipo<decimal?>(leitor["Codusur4"]);
        _codveiculo = AlterarTipo<decimal?>(leitor["Codveiculo"]);
        _codveiculo1 = AlterarTipo<decimal?>(leitor["Codveiculo1"]);
        _codveiculo2 = AlterarTipo<decimal?>(leitor["Codveiculo2"]);
        _cofinsretido = AlterarTipo<string>(leitor["Cofinsretido"]);
        _comissao = AlterarTipo<decimal?>(leitor["Comissao"]);
        _comissaomot = AlterarTipo<decimal?>(leitor["Comissaomot"]);
        _comissaosup = AlterarTipo<decimal?>(leitor["Comissaosup"]);
        _comissao2 = AlterarTipo<decimal?>(leitor["Comissao2"]);
        _comissao3 = AlterarTipo<decimal?>(leitor["Comissao3"]);
        _comissao4 = AlterarTipo<decimal?>(leitor["Comissao4"]);
        _condvenda = AlterarTipo<decimal?>(leitor["Condvenda"]);
        _conferido = AlterarTipo<string>(leitor["Conferido"]);
        _consumidorfinal = AlterarTipo<string>(leitor["Consumidorfinal"]);
        _consumiunumcte = AlterarTipo<string>(leitor["Consumiunumcte"]);
        _consumiunumnfe = AlterarTipo<string>(leitor["Consumiunumnfe"]);
        _contadorcupomfiscal = AlterarTipo<decimal?>(leitor["Contadorcupomfiscal"]);
        _contaordem = AlterarTipo<string>(leitor["Contaordem"]);
        _contribuinte = AlterarTipo<string>(leitor["Contribuinte"]);
        _csllretido = AlterarTipo<string>(leitor["Csllretido"]);
        _custobonificacao = AlterarTipo<string>(leitor["Custobonificacao"]);
        _dataempenho = AlterarTipo<DateTime?>(leitor["Dataempenho"]);
        _depositofechado = AlterarTipo<string>(leitor["Depositofechado"]);
        _descpais = AlterarTipo<string>(leitor["Descpais"]);
        _despesasrateada = AlterarTipo<string>(leitor["Despesasrateada"]);
        _dtahoraentradacontigencia = AlterarTipo<DateTime?>(leitor["Dtahoraentradacontigencia"]);
        _dta_horaenviosefaz = AlterarTipo<DateTime?>(leitor["Dta_Horaenviosefaz"]);
        _dtcancel = AlterarTipo<DateTime?>(leitor["Dtcancel"]);
        _dtcancelwms = AlterarTipo<DateTime?>(leitor["Dtcancelwms"]);
        _dtcanhoto = AlterarTipo<DateTime?>(leitor["Dtcanhoto"]);
        _dtdenegada = AlterarTipo<DateTime?>(leitor["Dtdenegada"]);
        _dtdevol = AlterarTipo<DateTime?>(leitor["Dtdevol"]);
        _dtemissaodeclaracao = AlterarTipo<DateTime?>(leitor["Dtemissaodeclaracao"]);
        _dtemissaonffornec = AlterarTipo<DateTime?>(leitor["Dtemissaonffornec"]);
        _dtentrega = AlterarTipo<DateTime?>(leitor["Dtentrega"]);
        _dtexportacaoservint = AlterarTipo<DateTime?>(leitor["Dtexportacaoservint"]);
        _dtexportacaowms = AlterarTipo<DateTime?>(leitor["Dtexportacaowms"]);
        _dtfat = AlterarTipo<DateTime?>(leitor["Dtfat"]);
        _dtfecha = AlterarTipo<DateTime?>(leitor["Dtfecha"]);
        _dtfechaccrca = AlterarTipo<DateTime?>(leitor["Dtfechaccrca"]);
        _dthoraautorizacaosefaz = AlterarTipo<DateTime?>(leitor["Dthoraautorizacaosefaz"]);
        _dthoracancelamentosefaz = AlterarTipo<DateTime?>(leitor["Dthoracancelamentosefaz"]);
        _dthorachegada = AlterarTipo<DateTime?>(leitor["Dthorachegada"]);
        _dthoracte = AlterarTipo<DateTime?>(leitor["Dthoracte"]);
        _dthoranfe = AlterarTipo<DateTime?>(leitor["Dthoranfe"]);
        _dthorarecibodpec = AlterarTipo<DateTime?>(leitor["Dthorarecibodpec"]);
        _dthorasaida = AlterarTipo<DateTime?>(leitor["Dthorasaida"]);
        _dtimportacaoservprinc = AlterarTipo<DateTime?>(leitor["Dtimportacaoservprinc"]);
        _dtimportacaowms = AlterarTipo<DateTime?>(leitor["Dtimportacaowms"]);
        _dtlancto = AlterarTipo<DateTime?>(leitor["Dtlancto"]);
        _dtlibent = AlterarTipo<DateTime?>(leitor["Dtlibent"]);
        _dtliberacaoentrega = AlterarTipo<DateTime?>(leitor["Dtliberacaoentrega"]);
        _dtnsu = AlterarTipo<DateTime?>(leitor["Dtnsu"]);
        _dtpagcomissaoprof = AlterarTipo<DateTime?>(leitor["Dtpagcomissaoprof"]);
        _dtpgtocampanha = AlterarTipo<DateTime?>(leitor["Dtpgtocampanha"]);
        _dtsaida = AlterarTipo<DateTime>(leitor["Dtsaida"]);
        _dtsaidanf = AlterarTipo<DateTime?>(leitor["Dtsaidanf"]);
        _dtwms = AlterarTipo<DateTime?>(leitor["Dtwms"]);
        _emaildest = AlterarTipo<string>(leitor["Emaildest"]);
        _emailfrete = AlterarTipo<string>(leitor["Emailfrete"]);
        _emailfreteredespacho = AlterarTipo<string>(leitor["Emailfreteredespacho"]);
        _endereco = AlterarTipo<string>(leitor["Endereco"]);
        _entrega = AlterarTipo<string>(leitor["Entrega"]);
        _enviada = AlterarTipo<string>(leitor["Enviada"]);
        _enviadanfe = AlterarTipo<string>(leitor["Enviadanfe"]);
        _equiplanc = AlterarTipo<string>(leitor["Equiplanc"]);
        _especie = AlterarTipo<string>(leitor["Especie"]);
        _especievolume = AlterarTipo<string>(leitor["Especievolume"]);
        _exportadoservint = AlterarTipo<string>(leitor["Exportadoservint"]);
        _finalidadenfe = AlterarTipo<string>(leitor["Finalidadenfe"]);
        _fornecentrega = AlterarTipo<string>(leitor["Fornecentrega"]);
        _fretedespacho = AlterarTipo<string>(leitor["Fretedespacho"]);
        _freteredespacho = AlterarTipo<string>(leitor["Freteredespacho"]);
        _funclanc = AlterarTipo<string>(leitor["Funclanc"]);
        _geracaorazaoauxiliar = AlterarTipo<string>(leitor["Geracaorazaoauxiliar"]);
        _geracp = AlterarTipo<string>(leitor["Geracp"]);
        _gerarbcrnfe = AlterarTipo<string>(leitor["Gerarbcrnfe"]);
        _historico = AlterarTipo<string>(leitor["Historico"]);
        _horaemissao = AlterarTipo<string>(leitor["Horaemissao"]);
        _horalanc = AlterarTipo<string>(leitor["Horalanc"]);
        _icmsretido = AlterarTipo<decimal?>(leitor["Icmsretido"]);
        _icmsretidognre = AlterarTipo<decimal?>(leitor["Icmsretidognre"]);
        _ie = AlterarTipo<string>(leitor["Ie"]);
        _ieent = AlterarTipo<string>(leitor["Ieent"]);
        _iefilial = AlterarTipo<string>(leitor["Iefilial"]);
        _iefrete = AlterarTipo<string>(leitor["Iefrete"]);
        _iesubsttribut = AlterarTipo<string>(leitor["Iesubsttribut"]);
        _importadoservprinc = AlterarTipo<string>(leitor["Importadoservprinc"]);
        _inssretido = AlterarTipo<string>(leitor["Inssretido"]);
        _irrretido = AlterarTipo<string>(leitor["Irrretido"]);
        _justificativacontigencia = AlterarTipo<string>(leitor["Justificativacontigencia"]);
        _kmfinalentrega = AlterarTipo<decimal?>(leitor["Kmfinalentrega"]);
        _localdesembaraco = AlterarTipo<string>(leitor["Localdesembaraco"]);
        _lotedpec = AlterarTipo<string>(leitor["Lotedpec"]);
        _marcarvolume = AlterarTipo<string>(leitor["Marcarvolume"]);
        _mensagempiscofins = AlterarTipo<string>(leitor["Mensagempiscofins"]);
        _minutolanc = AlterarTipo<string>(leitor["Minutolanc"]);
        _motoristaveiculo = AlterarTipo<string>(leitor["Motoristaveiculo"]);
        _municipio = AlterarTipo<string>(leitor["Municipio"]);
        _nfatualwms = AlterarTipo<string>(leitor["Nfatualwms"]);
        _nffornec = AlterarTipo<decimal?>(leitor["Nffornec"]);
        _normaregespecial = AlterarTipo<string>(leitor["Normaregespecial"]);
        _nsu = AlterarTipo<decimal?>(leitor["Nsu"]);
        _numcaixafiscal = AlterarTipo<decimal?>(leitor["Numcaixafiscal"]);
        _numcar = AlterarTipo<decimal?>(leitor["Numcar"]);
        _numcaranterior = AlterarTipo<decimal?>(leitor["Numcaranterior"]);
        _numcargaedi = AlterarTipo<decimal?>(leitor["Numcargaedi"]);
        _numcoleta = AlterarTipo<string>(leitor["Numcoleta"]);
        _numcontrato = AlterarTipo<decimal?>(leitor["Numcontrato"]);
        _numcupom = AlterarTipo<decimal?>(leitor["Numcupom"]);
        _numecf = AlterarTipo<decimal?>(leitor["Numecf"]);
        _numempenho = AlterarTipo<string>(leitor["Numempenho"]);
        _numendereco = AlterarTipo<string>(leitor["Numendereco"]);
        _numformulario = AlterarTipo<decimal?>(leitor["Numformulario"]);
        _numidf = AlterarTipo<string>(leitor["Numidf"]);
        _numitens = AlterarTipo<decimal?>(leitor["Numitens"]);
        _numlanccp = AlterarTipo<decimal?>(leitor["Numlanccp"]);
        _numlista = AlterarTipo<decimal?>(leitor["Numlista"]);
        _numlotecte = AlterarTipo<string>(leitor["Numlotecte"]);
        _numlotenfe = AlterarTipo<string>(leitor["Numlotenfe"]);
        _numnftransf = AlterarTipo<decimal?>(leitor["Numnftransf"]);
        _numnota = AlterarTipo<decimal>(leitor["Numnota"]);
        _numop = AlterarTipo<decimal?>(leitor["Numop"]);
        _numorca = AlterarTipo<decimal?>(leitor["Numorca"]);
        _numorcafilial = AlterarTipo<decimal?>(leitor["Numorcafilial"]);
        _numos = AlterarTipo<decimal?>(leitor["Numos"]);
        _numped = AlterarTipo<decimal?>(leitor["Numped"]);
        _numpedcli = AlterarTipo<string>(leitor["Numpedcli"]);
        _numprevenda = AlterarTipo<decimal?>(leitor["Numprevenda"]);
        _numregiao = AlterarTipo<decimal?>(leitor["Numregiao"]);
        _numregiaofrete = AlterarTipo<decimal?>(leitor["Numregiaofrete"]);
        _numselonf = AlterarTipo<decimal?>(leitor["Numselonf"]);
        _numseq = AlterarTipo<decimal?>(leitor["Numseq"]);
        _numseqentrega = AlterarTipo<decimal?>(leitor["Numseqentrega"]);
        _numseqmontagem = AlterarTipo<decimal?>(leitor["Numseqmontagem"]);
        _numserieequip = AlterarTipo<string>(leitor["Numserieequip"]);
        _numtab = AlterarTipo<decimal?>(leitor["Numtab"]);
        _numtransentdest = AlterarTipo<decimal?>(leitor["Numtransentdest"]);
        _numtransentorigem = AlterarTipo<decimal?>(leitor["Numtransentorigem"]);
        _numtransvenda = AlterarTipo<decimal>(leitor["Numtransvenda"]);
        _numtransvendaconhec = AlterarTipo<decimal?>(leitor["Numtransvendaconhec"]);
        _numtransvendadestino = AlterarTipo<decimal?>(leitor["Numtransvendadestino"]);
        _numtransvendaecf = AlterarTipo<decimal?>(leitor["Numtransvendaecf"]);
        _numtransvendaorigem = AlterarTipo<decimal?>(leitor["Numtransvendaorigem"]);
        _numvias = AlterarTipo<decimal?>(leitor["Numvias"]);
        _numviaspu = AlterarTipo<decimal?>(leitor["Numviaspu"]);
        _numvolume = AlterarTipo<decimal?>(leitor["Numvolume"]);
        _obs = AlterarTipo<string>(leitor["Obs"]);
        _obsconhecfrete = AlterarTipo<string>(leitor["Obsconhecfrete"]);
        _obsexp = AlterarTipo<string>(leitor["Obsexp"]);
        _obsnfcarreg = AlterarTipo<string>(leitor["Obsnfcarreg"]);
        _obsnfe = AlterarTipo<string>(leitor["Obsnfe"]);
        _obspiscofins = AlterarTipo<string>(leitor["Obspiscofins"]);
        _orgaopub = AlterarTipo<string>(leitor["Orgaopub"]);
        _perbaseredoutrasdesp = AlterarTipo<decimal?>(leitor["Perbaseredoutrasdesp"]);
        _perccomprofissional = AlterarTipo<decimal?>(leitor["Perccomprofissional"]);
        _percfrete = AlterarTipo<decimal?>(leitor["Percfrete"]);
        _percfreteretido = AlterarTipo<decimal?>(leitor["Percfreteretido"]);
        _percicmfrete = AlterarTipo<decimal?>(leitor["Percicmfrete"]);
        _percofins = AlterarTipo<decimal?>(leitor["Percofins"]);
        _percstfreteretido = AlterarTipo<decimal?>(leitor["Percstfreteretido"]);
        _perdescfin = AlterarTipo<decimal?>(leitor["Perdescfin"]);
        _perpis = AlterarTipo<decimal?>(leitor["Perpis"]);
        _pisretido = AlterarTipo<string>(leitor["Pisretido"]);
        _placaveic = AlterarTipo<string>(leitor["Placaveic"]);
        _prazoadicional = AlterarTipo<decimal?>(leitor["Prazoadicional"]);
        _prazomedio = AlterarTipo<decimal?>(leitor["Prazomedio"]);
        _prazoponderado = AlterarTipo<string>(leitor["Prazoponderado"]);
        _prazo1 = AlterarTipo<decimal?>(leitor["Prazo1"]);
        _prazo10 = AlterarTipo<decimal?>(leitor["Prazo10"]);
        _prazo11 = AlterarTipo<decimal?>(leitor["Prazo11"]);
        _prazo12 = AlterarTipo<decimal?>(leitor["Prazo12"]);
        _prazo2 = AlterarTipo<decimal?>(leitor["Prazo2"]);
        _prazo3 = AlterarTipo<decimal?>(leitor["Prazo3"]);
        _prazo4 = AlterarTipo<decimal?>(leitor["Prazo4"]);
        _prazo5 = AlterarTipo<decimal?>(leitor["Prazo5"]);
        _prazo6 = AlterarTipo<decimal?>(leitor["Prazo6"]);
        _prazo7 = AlterarTipo<decimal?>(leitor["Prazo7"]);
        _prazo8 = AlterarTipo<decimal?>(leitor["Prazo8"]);
        _prazo9 = AlterarTipo<decimal?>(leitor["Prazo9"]);
        _protocolo = AlterarTipo<string>(leitor["Protocolo"]);
        _protocolocancelamento = AlterarTipo<string>(leitor["Protocolocancelamento"]);
        _protocolocancelamentocte = AlterarTipo<string>(leitor["Protocolocancelamentocte"]);
        _protocolocte = AlterarTipo<string>(leitor["Protocolocte"]);
        _protocolonfe = AlterarTipo<string>(leitor["Protocolonfe"]);
        _protocolonfeauto = AlterarTipo<string>(leitor["Protocolonfeauto"]);
        _protocolonfecan = AlterarTipo<string>(leitor["Protocolonfecan"]);
        _recarga = AlterarTipo<string>(leitor["Recarga"]);
        _recibocte = AlterarTipo<string>(leitor["Recibocte"]);
        _recibodpec = AlterarTipo<string>(leitor["Recibodpec"]);
        _recibonfe = AlterarTipo<string>(leitor["Recibonfe"]);
        _reservaritenstv7 = AlterarTipo<string>(leitor["Reservaritenstv7"]);
        _rotinalanc = AlterarTipo<string>(leitor["Rotinalanc"]);
        _serie = AlterarTipo<string>(leitor["Serie"]);
        _serieecf = AlterarTipo<string>(leitor["Serieecf"]);
        _serieoriginal = AlterarTipo<string>(leitor["Serieoriginal"]);
        _sitdoc = AlterarTipo<string>(leitor["Sitdoc"]);
        _situacaocte = AlterarTipo<decimal?>(leitor["Situacaocte"]);
        _situacaonfe = AlterarTipo<decimal?>(leitor["Situacaonfe"]);
        _stribut = AlterarTipo<decimal?>(leitor["Stribut"]);
        _subserie = AlterarTipo<string>(leitor["Subserie"]);
        _sulframa = AlterarTipo<string>(leitor["Sulframa"]);
        _taxaentrega = AlterarTipo<decimal?>(leitor["Taxaentrega"]);
        _telefone = AlterarTipo<string>(leitor["Telefone"]);
        _tentativaenviocte = AlterarTipo<decimal?>(leitor["Tentativaenviocte"]);
        _tentativaenvionfe = AlterarTipo<decimal?>(leitor["Tentativaenvionfe"]);
        _tipoaliqoutrasdesp = AlterarTipo<string>(leitor["Tipoaliqoutrasdesp"]);
        _tipodevol = AlterarTipo<string>(leitor["Tipodevol"]);
        _tipoemissao = AlterarTipo<string>(leitor["Tipoemissao"]);
        _tipoemissaocte = AlterarTipo<string>(leitor["Tipoemissaocte"]);
        _tipoempresa = AlterarTipo<string>(leitor["Tipoempresa"]);
        _tipofj = AlterarTipo<string>(leitor["Tipofj"]);
        _tipofrete = AlterarTipo<string>(leitor["Tipofrete"]);
        _tipovenda = AlterarTipo<string>(leitor["Tipovenda"]);
        _totdifaliquotas = AlterarTipo<decimal?>(leitor["Totdifaliquotas"]);
        _totpeso = AlterarTipo<decimal?>(leitor["Totpeso"]);
        _totpesoagrupado = AlterarTipo<decimal?>(leitor["Totpesoagrupado"]);
        _totpesobruto = AlterarTipo<decimal?>(leitor["Totpesobruto"]);
        _totpesoliq = AlterarTipo<decimal?>(leitor["Totpesoliq"]);
        _totpesoliqagrupado = AlterarTipo<decimal?>(leitor["Totpesoliqagrupado"]);
        _totvlbonific = AlterarTipo<decimal?>(leitor["Totvlbonific"]);
        _totvldesccom = AlterarTipo<decimal?>(leitor["Totvldesccom"]);
        _totvldescfin = AlterarTipo<decimal?>(leitor["Totvldescfin"]);
        _totvldescflex = AlterarTipo<decimal?>(leitor["Totvldescflex"]);
        _totvlredcomiss = AlterarTipo<decimal?>(leitor["Totvlredcomiss"]);
        _totvlredcomisssup = AlterarTipo<decimal?>(leitor["Totvlredcomisssup"]);
        _totvolume = AlterarTipo<decimal?>(leitor["Totvolume"]);
        _totvolumeagrupado = AlterarTipo<decimal?>(leitor["Totvolumeagrupado"]);
        _transportadora = AlterarTipo<string>(leitor["Transportadora"]);
        _uf = AlterarTipo<string>(leitor["Uf"]);
        _ufcodigo = AlterarTipo<string>(leitor["Ufcodigo"]);
        _ufdesembaraco = AlterarTipo<string>(leitor["Ufdesembaraco"]);
        _uffilial = AlterarTipo<string>(leitor["Uffilial"]);
        _uffrete = AlterarTipo<string>(leitor["Uffrete"]);
        _ufplacavei = AlterarTipo<string>(leitor["Ufplacavei"]);
        _ufplacaveic = AlterarTipo<string>(leitor["Ufplacaveic"]);
        _usaintegracaowms = AlterarTipo<string>(leitor["Usaintegracaowms"]);
        _utilizaipicalcicms = AlterarTipo<string>(leitor["Utilizaipicalcicms"]);
        _valorst = AlterarTipo<decimal?>(leitor["Valorst"]);
        _vendaassistida = AlterarTipo<string>(leitor["Vendaassistida"]);
        _vendatriangular = AlterarTipo<string>(leitor["Vendatriangular"]);
        _vlbase = AlterarTipo<decimal?>(leitor["Vlbase"]);
        _vlbaseipi = AlterarTipo<decimal?>(leitor["Vlbaseipi"]);
        _vlbasepiscofins = AlterarTipo<decimal?>(leitor["Vlbasepiscofins"]);
        _vlbonific = AlterarTipo<decimal?>(leitor["Vlbonific"]);
        _vlcofins = AlterarTipo<decimal?>(leitor["Vlcofins"]);
        _vlcustocont = AlterarTipo<decimal?>(leitor["Vlcustocont"]);
        _vlcustofin = AlterarTipo<decimal?>(leitor["Vlcustofin"]);
        _vlcustoreal = AlterarTipo<decimal?>(leitor["Vlcustoreal"]);
        _vlcustorep = AlterarTipo<decimal?>(leitor["Vlcustorep"]);
        _vldescabatimento = AlterarTipo<decimal?>(leitor["Vldescabatimento"]);
        _vldescicms = AlterarTipo<decimal?>(leitor["Vldescicms"]);
        _vldesconto = AlterarTipo<decimal?>(leitor["Vldesconto"]);
        _vldescprom = AlterarTipo<decimal?>(leitor["Vldescprom"]);
        _vldespacho = AlterarTipo<decimal?>(leitor["Vldespacho"]);
        _vldespdentronf = AlterarTipo<decimal?>(leitor["Vldespdentronf"]);
        _vldevolucao = AlterarTipo<decimal?>(leitor["Vldevolucao"]);
        _vlfrete = AlterarTipo<decimal?>(leitor["Vlfrete"]);
        _vlfretenf = AlterarTipo<decimal?>(leitor["Vlfretenf"]);
        _vlfreteretido = AlterarTipo<decimal?>(leitor["Vlfreteretido"]);
        _vlicms = AlterarTipo<decimal?>(leitor["Vlicms"]);
        _vlicmsantecipado = AlterarTipo<decimal?>(leitor["Vlicmsantecipado"]);
        _vlinss = AlterarTipo<decimal?>(leitor["Vlinss"]);
        _vlipi = AlterarTipo<decimal?>(leitor["Vlipi"]);
        _vlir = AlterarTipo<decimal?>(leitor["Vlir"]);
        _vlisentas = AlterarTipo<decimal?>(leitor["Vlisentas"]);
        _vliss = AlterarTipo<decimal?>(leitor["Vliss"]);
        _vlltr = AlterarTipo<decimal?>(leitor["Vlltr"]);
        _vloutras = AlterarTipo<decimal?>(leitor["Vloutras"]);
        _vloutrasdesp = AlterarTipo<decimal?>(leitor["Vloutrasdesp"]);
        _vlpautafrete = AlterarTipo<decimal?>(leitor["Vlpautafrete"]);
        _vlpedagio = AlterarTipo<decimal?>(leitor["Vlpedagio"]);
        _vlpis = AlterarTipo<decimal?>(leitor["Vlpis"]);
        _vlrecebidoboleto = AlterarTipo<decimal?>(leitor["Vlrecebidoboleto"]);
        _vlrecebidocartao = AlterarTipo<decimal?>(leitor["Vlrecebidocartao"]);
        _vlrecebidoch = AlterarTipo<decimal?>(leitor["Vlrecebidoch"]);
        _vlrecebidodin = AlterarTipo<decimal?>(leitor["Vlrecebidodin"]);
        _vlseccat = AlterarTipo<decimal?>(leitor["Vlseccat"]);
        _vlseguro = AlterarTipo<decimal?>(leitor["Vlseguro"]);
        _vlstfreteretido = AlterarTipo<decimal?>(leitor["Vlstfreteretido"]);
        _vltabela = AlterarTipo<decimal?>(leitor["Vltabela"]);
        _vltotal = AlterarTipo<decimal?>(leitor["Vltotal"]);
        _vltotalnf = AlterarTipo<decimal?>(leitor["Vltotalnf"]);
        _vltotalsemdescicms = AlterarTipo<decimal?>(leitor["Vltotalsemdescicms"]);
        _vltotger = AlterarTipo<decimal?>(leitor["Vltotger"]);
        _vltroco = AlterarTipo<decimal?>(leitor["Vltroco"]);
        _vlverbacmvcli = AlterarTipo<decimal?>(leitor["Vlverbacmvcli"]);
        _wmscodfuncignora = AlterarTipo<decimal?>(leitor["Wmscodfuncignora"]);
        _wmsignorado = AlterarTipo<string>(leitor["Wmsignorado"]);
        _vltributos = AlterarTipo<decimal?>(leitor["Vltributos"]);
        _vldescsociotorcedor = AlterarTipo<decimal?>(leitor["Vldescsociotorcedor"]);
        _idtipopresenca = AlterarTipo<string>(leitor["Idtipopresenca"]);
        _vlsubtotal = AlterarTipo<decimal?>(leitor["Vlsubtotal"]);
        _docemissao = AlterarTipo<string>(leitor["Docemissao"]);
        _numfechamentomovcx = AlterarTipo<decimal?>(leitor["Numfechamentomovcx"]);
        _dtmovimentocx = AlterarTipo<DateTime?>(leitor["Dtmovimentocx"]);
        _identificarclientenfce = AlterarTipo<string>(leitor["Identificarclientenfce"]);
        _md5listaarq = AlterarTipo<string>(leitor["Md5listaarq"]);
        _vendanfseried = AlterarTipo<string>(leitor["Vendanfseried"]);
        _qrcodenfce = AlterarTipo<string>(leitor["Qrcodenfce"]);
        _notadupliquesvc = AlterarTipo<string>(leitor["Notadupliquesvc"]);
        _assinatura = AlterarTipo<string>(leitor["Assinatura"]);
        _uidregistro = AlterarTipo<decimal?>(leitor["Uidregistro"]);
        _idparceiro = AlterarTipo<string>(leitor["Idparceiro"]);
        _cnpjintermediador = AlterarTipo<string>(leitor["Cnpjintermediador"]);
        _descintermediador = AlterarTipo<string>(leitor["Descintermediador"]);
        _datahoraemissaosat = AlterarTipo<DateTime?>(leitor["Datahoraemissaosat"]);
        _chavesat = AlterarTipo<string>(leitor["Chavesat"]);
        _qrcodesat = AlterarTipo<string>(leitor["Qrcodesat"]);
        _situacaosat = AlterarTipo<string>(leitor["Situacaosat"]);
        _numsessaosat = AlterarTipo<decimal?>(leitor["Numsessaosat"]);
        _codsefazsat = AlterarTipo<decimal?>(leitor["Codsefazsat"]);
        _codstatussat = AlterarTipo<decimal?>(leitor["Codstatussat"]);
        _numseriesat = AlterarTipo<string>(leitor["Numseriesat"]);
        _indicadordesconto = AlterarTipo<string>(leitor["Indicadordesconto"]);
        _indicadoracrescimo = AlterarTipo<string>(leitor["Indicadoracrescimo"]);
    }

}