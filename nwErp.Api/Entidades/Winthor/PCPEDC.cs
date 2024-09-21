

////// namespace nwErp.Entidades.Winthor;

// namespace nwErp.Api.Modelos;

[Serializable]
public class PCPEDC : GerenteDePropriedades, IEntidade
{
    private static readonly string RO_AGRUPAMENTO = "Agrupamento";

    private string _agrupamento;

    private static readonly string RO_ALIQICMSFRETENF = "Aliqicmsfretenf";

    private decimal? _aliqicmsfretenf;

    private static readonly string RO_ALTAPOSMAPASEP = "Altaposmapasep";

    private string _altaposmapasep;

    private static readonly string RO_BAIXAESTCLI = "Baixaestcli";

    private string _baixaestcli;

    private static readonly string RO_BASEICMSFRETENF = "Baseicmsfretenf";

    private decimal? _baseicmsfretenf;

    private static readonly string RO_BLOQCOMERCIAL = "Bloqcomercial";

    private string _bloqcomercial;

    private static readonly string RO_BLOQFINANCEIRO = "Bloqfinanceiro";

    private string _bloqfinanceiro;

    private static readonly string RO_BLOQUEIOEDICAO = "Bloqueioedicao";

    private string _bloqueioedicao;

    private static readonly string RO_BLOQUEIOSALDOCCDESCFIN = "Bloqueiosaldoccdescfin";

    private string _bloqueiosaldoccdescfin;

    private static readonly string RO_BONIFICALTDEBCREDRCA = "Bonificaltdebcredrca";

    private string _bonificaltdebcredrca;

    private static readonly string RO_BRINDE = "Brinde";

    private string _brinde;

    private static readonly string RO_BROKER = "Broker";

    private string _broker;

    private static readonly string RO_BROKERALTDEBCREDRCA = "Brokeraltdebcredrca";

    private string _brokeraltdebcredrca;

    private static readonly string RO_CAMPANHA = "Campanha";

    private string _campanha;

    private static readonly string RO_CFOPBNFDEGUSTA = "Cfopbnfdegusta";

    private decimal? _cfopbnfdegusta;

    private static readonly string RO_CODADMCARTAO = "Codadmcartao";

    private string _codadmcartao;

    private static readonly string RO_CODATENDIMENTO = "Codatendimento";

    private decimal? _codatendimento;

    private static readonly string RO_CODAUTORIZACAOTEF = "Codautorizacaotef";

    private decimal? _codautorizacaotef;

    private static readonly string RO_CODAUTORIZACAOTEFWEB = "Codautorizacaotefweb";

    private string _codautorizacaotefweb;

    private static readonly string RO_CODBNF = "Codbnf";

    private decimal? _codbnf;

    private static readonly string RO_CODCLI = "Codcli";

    private decimal _codcli;

    private static readonly string RO_CODCLICONSIGNACAO = "Codcliconsignacao";

    private decimal? _codcliconsignacao;

    private static readonly string RO_CODCLINF = "Codclinf";

    private decimal? _codclinf;

    private static readonly string RO_CODCLIRECEBEDOR = "Codclirecebedor";

    private decimal? _codclirecebedor;

    private static readonly string RO_CODCLITV8 = "Codclitv8";

    private decimal? _codclitv8;

    private static readonly string RO_CODCOB = "Codcob";

    private string _codcob;

    private static readonly string RO_CODCONDICAOVENDA = "Codcondicaovenda";

    private decimal? _codcondicaovenda;

    private static readonly string RO_CODCONTRATO = "Codcontrato";

    private decimal? _codcontrato;

    private static readonly string RO_CODDISTRIB = "Coddistrib";

    private string _coddistrib;

    private static readonly string RO_CODEMITENTE = "Codemitente";

    private decimal? _codemitente;

    private static readonly string RO_CODENDENT = "Codendent";

    private decimal? _codendent;

    private static readonly string RO_CODEPTO = "Codepto";

    private decimal? _codepto;

    private static readonly string RO_CODESTABELECIMENTO = "Codestabelecimento";

    private string _codestabelecimento;

    private static readonly string RO_CODFILIAL = "Codfilial";

    private string _codfilial;

    private static readonly string RO_CODFILIALNF = "Codfilialnf";

    private string _codfilialnf;

    private static readonly string RO_CODFORNECBONIFIC = "Codfornecbonific";

    private decimal? _codfornecbonific;

    private static readonly string RO_CODFORNECFRETE = "Codfornecfrete";

    private decimal? _codfornecfrete;

    private static readonly string RO_CODFORNECREDESPACHO = "Codfornecredespacho";

    private decimal? _codfornecredespacho;

    private static readonly string RO_CODFORNECVDIRETO = "Codfornecvdireto";

    private decimal? _codfornecvdireto;

    private static readonly string RO_CODFUNCCALCFRETE = "Codfunccalcfrete";

    private decimal? _codfunccalcfrete;

    private static readonly string RO_CODFUNCCANCEL = "Codfunccancel";

    private decimal? _codfunccancel;

    private static readonly string RO_CODFUNCCONF = "Codfuncconf";

    private decimal? _codfuncconf;

    private static readonly string RO_CODFUNCCONFGARANTIA = "Codfuncconfgarantia";

    private decimal? _codfuncconfgarantia;

    private static readonly string RO_CODFUNCCX = "Codfunccx";

    private decimal? _codfunccx;

    private static readonly string RO_CODFUNCEMBALADOR = "Codfuncembalador";

    private decimal? _codfuncembalador;

    private static readonly string RO_CODFUNCEMISSAOMAPA = "Codfuncemissaomapa";

    private decimal? _codfuncemissaomapa;

    private static readonly string RO_CODFUNCEXPARQOL = "Codfuncexparqol";

    private decimal? _codfuncexparqol;

    private static readonly string RO_CODFUNCEXPINTWMS = "Codfuncexpintwms";

    private decimal? _codfuncexpintwms;

    private static readonly string RO_CODFUNCIMPINTWMS = "Codfuncimpintwms";

    private decimal? _codfuncimpintwms;

    private static readonly string RO_CODFUNCLIBDESC = "Codfunclibdesc";

    private decimal? _codfunclibdesc;

    private static readonly string RO_CODFUNCLIBERA = "Codfunclibera";

    private decimal? _codfunclibera;

    private static readonly string RO_CODFUNCLIBERA2 = "Codfunclibera2";

    private decimal? _codfunclibera2;

    private static readonly string RO_CODFUNCPROTOCOLO = "Codfuncprotocolo";

    private decimal? _codfuncprotocolo;

    private static readonly string RO_CODFUNCSEP = "Codfuncsep";

    private decimal? _codfuncsep;

    private static readonly string RO_CODIGOSAZONALIDADE = "Codigosazonalidade";

    private decimal? _codigosazonalidade;

    private static readonly string RO_CODMOTBLOQUEIO = "Codmotbloqueio";

    private decimal? _codmotbloqueio;

    private static readonly string RO_CODMOTCANCEL = "Codmotcancel";

    private decimal? _codmotcancel;

    private static readonly string RO_CODMOTIVO = "Codmotivo";

    private decimal? _codmotivo;

    private static readonly string RO_CODMOTIVO2 = "Codmotivo2";

    private decimal? _codmotivo2;

    private static readonly string RO_CODMOTORISTA = "Codmotorista";

    private decimal? _codmotorista;

    private static readonly string RO_CODPLPAG = "Codplpag";

    private decimal _codplpag;

    private static readonly string RO_CODPLPAGETICO = "Codplpagetico";

    private decimal? _codplpagetico;

    private static readonly string RO_CODPLPAGGENERICO = "Codplpaggenerico";

    private decimal? _codplpaggenerico;

    private static readonly string RO_CODPOSTAGEM = "Codpostagem";

    private string _codpostagem;

    private static readonly string RO_CODPRACA = "Codpraca";

    private decimal _codpraca;

    private static readonly string RO_CODPRACADESTINO = "Codpracadestino";

    private decimal? _codpracadestino;

    private static readonly string RO_CODPROFISSIONAL = "Codprofissional";

    private decimal? _codprofissional;

    private static readonly string RO_CODSUPERVISOR = "Codsupervisor";

    private decimal _codsupervisor;

    private static readonly string RO_CODSUPERVISOR2 = "Codsupervisor2";

    private decimal? _codsupervisor2;

    private static readonly string RO_CODSUPERVISOR3 = "Codsupervisor3";

    private decimal? _codsupervisor3;

    private static readonly string RO_CODTRANSP = "Codtransp";

    private decimal? _codtransp;

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

    private string _codveiculo;

    private static readonly string RO_CODVISITA = "Codvisita";

    private decimal? _codvisita;

    private static readonly string RO_CONCILIAIMPORTACAO = "Conciliaimportacao";

    private string _conciliaimportacao;

    private static readonly string RO_CONDVENDA = "Condvenda";

    private decimal? _condvenda;

    private static readonly string RO_CONFERINDOPEDIDO = "Conferindopedido";

    private string _conferindopedido;

    private static readonly string RO_CONTAORDEM = "Contaordem";

    private string _contaordem;

    private static readonly string RO_CRMALTDEBCREDRCA = "Crmaltdebcredrca";

    private string _crmaltdebcredrca;

    private static readonly string RO_CUSTOBONIFICACAO = "Custobonificacao";

    private string _custobonificacao;

    private static readonly string RO_CUSTOENTREGA = "Custoentrega";

    private decimal? _custoentrega;

    private static readonly string RO_DATA = "Data";

    private DateTime _data;

    private static readonly string RO_DATAEMPENHO = "Dataempenho";

    private DateTime? _dataempenho;

    private static readonly string RO_DATAEXPARQOL = "Dataexparqol";

    private DateTime? _dataexparqol;

    private static readonly string RO_DATAPEDCLI = "Datapedcli";

    private DateTime? _datapedcli;

    private static readonly string RO_DATAPROTOCOLO = "Dataprotocolo";

    private DateTime? _dataprotocolo;

    private static readonly string RO_DTABERTURAPEDPALM = "Dtaberturapedpalm";

    private DateTime? _dtaberturapedpalm;

    private static readonly string RO_DTAGENDAENTREGA = "Dtagendaentrega";

    private DateTime? _dtagendaentrega;

    private static readonly string RO_DTCALCFRETE = "Dtcalcfrete";

    private DateTime? _dtcalcfrete;

    private static readonly string RO_DTCANCEL = "Dtcancel";

    private DateTime? _dtcancel;

    private static readonly string RO_DTCHEGADACLIENTE = "Dtchegadacliente";

    private DateTime? _dtchegadacliente;

    private static readonly string RO_DTCONFGARANTIA = "Dtconfgarantia";

    private DateTime? _dtconfgarantia;

    private static readonly string RO_DTEMISSAOMAPA = "Dtemissaomapa";

    private DateTime? _dtemissaomapa;

    private static readonly string RO_DTENTREGA = "Dtentrega";

    private DateTime? _dtentrega;

    private static readonly string RO_DTEXPORTACAO = "Dtexportacao";

    private DateTime? _dtexportacao;

    private static readonly string RO_DTEXPORTACAOSERVINT = "Dtexportacaoservint";

    private DateTime? _dtexportacaoservint;

    private static readonly string RO_DTEXPORTACAOWMS = "Dtexportacaowms";

    private DateTime? _dtexportacaowms;

    private static readonly string RO_DTEXPORTADO = "Dtexportado";

    private DateTime? _dtexportado;

    private static readonly string RO_DTFAT = "Dtfat";

    private DateTime? _dtfat;

    private static readonly string RO_DTFECHAMENTOPEDPALM = "Dtfechamentopedpalm";

    private DateTime? _dtfechamentopedpalm;

    private static readonly string RO_DTFIMDIGITACAOPEDIDO = "Dtfimdigitacaopedido";

    private DateTime? _dtfimdigitacaopedido;

    private static readonly string RO_DTFINALCHECKOUT = "Dtfinalcheckout";

    private DateTime? _dtfinalcheckout;

    private static readonly string RO_DTFINALPEND = "Dtfinalpend";

    private DateTime? _dtfinalpend;

    private static readonly string RO_DTFINALSEP = "Dtfinalsep";

    private DateTime? _dtfinalsep;

    private static readonly string RO_DTIMPORTACAO = "Dtimportacao";

    private DateTime? _dtimportacao;

    private static readonly string RO_DTIMPORTACAOSERVPRINC = "Dtimportacaoservprinc";

    private DateTime? _dtimportacaoservprinc;

    private static readonly string RO_DTIMPORTACAOWMS = "Dtimportacaowms";

    private DateTime? _dtimportacaowms;

    private static readonly string RO_DTIMPORTADO = "Dtimportado";

    private DateTime? _dtimportado;

    private static readonly string RO_DTINICIALCHECKOUT = "Dtinicialcheckout";

    private DateTime? _dtinicialcheckout;

    private static readonly string RO_DTINICIALPEND = "Dtinicialpend";

    private DateTime? _dtinicialpend;

    private static readonly string RO_DTINICIALSEP = "Dtinicialsep";

    private DateTime? _dtinicialsep;

    private static readonly string RO_DTINICIODIGITACAOPEDIDO = "Dtiniciodigitacaopedido";

    private DateTime? _dtiniciodigitacaopedido;

    private static readonly string RO_DTLIBERA = "Dtlibera";

    private DateTime? _dtlibera;

    private static readonly string RO_DTLIBERA2 = "Dtlibera2";

    private DateTime? _dtlibera2;

    private static readonly string RO_DTLIMITEFAT = "Dtlimitefat";

    private DateTime? _dtlimitefat;

    private static readonly string RO_DTNFTRANSF = "Dtnftransf";

    private DateTime? _dtnftransf;

    private static readonly string RO_DTVALIDADE = "Dtvalidade";

    private DateTime? _dtvalidade;

    private static readonly string RO_DTVENC1 = "Dtvenc1";

    private DateTime? _dtvenc1;

    private static readonly string RO_DTVENC2 = "Dtvenc2";

    private DateTime? _dtvenc2;

    private static readonly string RO_DTVENC3 = "Dtvenc3";

    private DateTime? _dtvenc3;

    private static readonly string RO_DTWMS = "Dtwms";

    private DateTime? _dtwms;

    private static readonly string RO_EANCOBRANCA = "Eancobranca";

    private decimal? _eancobranca;

    private static readonly string RO_EANCOMPRADOR = "Eancomprador";

    private decimal? _eancomprador;

    private static readonly string RO_EANENTREGA = "Eanentrega";

    private decimal? _eanentrega;

    private static readonly string RO_EANLOCALENTREGA = "Eanlocalentrega";

    private decimal? _eanlocalentrega;

    private static readonly string RO_ESPECIEMANIF = "Especiemanif";

    private string _especiemanif;

    private static readonly string RO_ESPECIEVOLUME = "Especievolume";

    private string _especievolume;

    private static readonly string RO_EXPORTADO = "Exportado";

    private string _exportado;

    private static readonly string RO_EXPORTADOSERVINT = "Exportadoservint";

    private string _exportadoservint;

    private static readonly string RO_FORNECENTREGA = "Fornecentrega";

    private string _fornecentrega;

    private static readonly string RO_FRETEREDESPACHO = "Freteredespacho";

    private string _freteredespacho;

    private static readonly string RO_GERACP = "Geracp";

    private string _geracp;

    private static readonly string RO_GERARCONTROLEDEENTREGA = "Gerarcontroledeentrega";

    private string _gerarcontroledeentrega;

    private static readonly string RO_GERARDADOSNFPAULISTA = "Gerardadosnfpaulista";

    private string _gerardadosnfpaulista;

    private static readonly string RO_HORA = "Hora";

    private decimal? _hora;

    private static readonly string RO_HORAEMISSAOMAPA = "Horaemissaomapa";

    private decimal? _horaemissaomapa;

    private static readonly string RO_HORAFAT = "Horafat";

    private decimal? _horafat;

    private static readonly string RO_HORAFINALSEP = "Horafinalsep";

    private decimal? _horafinalsep;

    private static readonly string RO_HORAINICIALSEP = "Horainicialsep";

    private decimal? _horainicialsep;

    private static readonly string RO_HORALIBERA = "Horalibera";

    private decimal? _horalibera;

    private static readonly string RO_HORAPROTOCOLO = "Horaprotocolo";

    private decimal? _horaprotocolo;

    private static readonly string RO_IMPORTACUPOM = "Importacupom";

    private decimal? _importacupom;

    private static readonly string RO_IMPORTADO = "Importado";

    private string _importado;

    private static readonly string RO_IMPORTADOSERVPRINC = "Importadoservprinc";

    private string _importadoservprinc;

    private static readonly string RO_INTEGRADORA = "Integradora";

    private decimal? _integradora;

    private static readonly string RO_LOCALDESEMBARACO = "Localdesembaraco";

    private string _localdesembaraco;

    private static readonly string RO_LOCALIZACAOPEDIDO = "Localizacaopedido";

    private string _localizacaopedido;

    private static readonly string RO_LOG = "Log";

    private string _log;

    private static readonly string RO_LOG1 = "Log1";

    private string _log1;

    private static readonly string RO_LOG2 = "Log2";

    private string _log2;

    private static readonly string RO_LOG3 = "Log3";

    private string _log3;

    private static readonly string RO_LOG4 = "Log4";

    private string _log4;

    private static readonly string RO_MARCAVOLUME = "Marcavolume";

    private string _marcavolume;

    private static readonly string RO_MINUTO = "Minuto";

    private decimal? _minuto;

    private static readonly string RO_MINUTOEMISSAOMAPA = "Minutoemissaomapa";

    private decimal? _minutoemissaomapa;

    private static readonly string RO_MINUTOFAT = "Minutofat";

    private decimal? _minutofat;

    private static readonly string RO_MINUTOFINALSEP = "Minutofinalsep";

    private decimal? _minutofinalsep;

    private static readonly string RO_MINUTOINICIALSEP = "Minutoinicialsep";

    private decimal? _minutoinicialsep;

    private static readonly string RO_MINUTOLIBERA = "Minutolibera";

    private decimal? _minutolibera;

    private static readonly string RO_MINUTOPROTOCOLO = "Minutoprotocolo";

    private decimal? _minutoprotocolo;

    private static readonly string RO_MONTANDO = "Montando";

    private string _montando;

    private static readonly string RO_MOTIVOPOSICAO = "Motivoposicao";

    private string _motivoposicao;

    private static readonly string RO_MOTORISTAVEICULO = "Motoristaveiculo";

    private string _motoristaveiculo;

    private static readonly string RO_NEGOCIADO = "Negociado";

    private string _negociado;

    private static readonly string RO_NOMEARQUIVOFV = "Nomearquivofv";

    private string _nomearquivofv;

    private static readonly string RO_NSUTEF = "Nsutef";

    private string _nsutef;

    private static readonly string RO_NUMCAIXA = "Numcaixa";

    private decimal? _numcaixa;

    private static readonly string RO_NUMCAIXAFISCAL = "Numcaixafiscal";

    private decimal? _numcaixafiscal;

    private static readonly string RO_NUMCAR = "Numcar";

    private decimal _numcar;

    private static readonly string RO_NUMCARANTERIOR = "Numcaranterior";

    private decimal? _numcaranterior;

    private static readonly string RO_NUMCARAUX = "Numcaraux";

    private decimal? _numcaraux;

    private static readonly string RO_NUMCARFAB = "Numcarfab";

    private decimal? _numcarfab;

    private static readonly string RO_NUMCARMANIF = "Numcarmanif";

    private decimal? _numcarmanif;

    private static readonly string RO_NUMCCF = "Numccf";

    private decimal? _numccf;

    private static readonly string RO_NUMCOLETA = "Numcoleta";

    private string _numcoleta;

    private static readonly string RO_NUMCONTRATOCORREIO = "Numcontratocorreio";

    private decimal? _numcontratocorreio;

    private static readonly string RO_NUMCUPOM = "Numcupom";

    private decimal? _numcupom;

    private static readonly string RO_NUMECF = "Numecf";

    private decimal? _numecf;

    private static readonly string RO_NUMEMPENHO = "Numempenho";

    private string _numempenho;

    private static readonly string RO_NUMFONTERECURSO = "Numfonterecurso";

    private string _numfonterecurso;

    private static readonly string RO_NUMITENS = "Numitens";

    private decimal? _numitens;

    private static readonly string RO_NUMLISTA = "Numlista";

    private decimal? _numlista;

    private static readonly string RO_NUMLOTEINTWMS = "Numloteintwms";

    private decimal? _numloteintwms;

    private static readonly string RO_NUMNFTRANSF = "Numnftransf";

    private decimal? _numnftransf;

    private static readonly string RO_NUMNOTA = "Numnota";

    private decimal? _numnota;

    private static readonly string RO_NUMNOTACONSIG = "Numnotaconsig";

    private decimal? _numnotaconsig;

    private static readonly string RO_NUMNOTAMANIF = "Numnotamanif";

    private decimal? _numnotamanif;

    private static readonly string RO_NUMNOTATRANSFDEP = "Numnotatransfdep";

    private decimal? _numnotatransfdep;

    private static readonly string RO_NUMORCA = "Numorca";

    private decimal? _numorca;

    private static readonly string RO_NUMORCAFILIAL = "Numorcafilial";

    private decimal? _numorcafilial;

    private static readonly string RO_NUMORCAPRINC = "Numorcaprinc";

    private decimal? _numorcaprinc;

    private static readonly string RO_NUMORDEMCARGA = "Numordemcarga";

    private decimal? _numordemcarga;

    private static readonly string RO_NUMPED = "Numped";

    private decimal _numped;

    private static readonly string RO_NUMPEDBNF = "Numpedbnf";

    private decimal? _numpedbnf;

    private static readonly string RO_NUMPEDCLI = "Numpedcli";

    private string _numpedcli;

    private static readonly string RO_NUMPEDECF = "Numpedecf";

    private decimal? _numpedecf;

    private static readonly string RO_NUMPEDENTFUT = "Numpedentfut";

    private decimal? _numpedentfut;

    private static readonly string RO_NUMPEDORIGEM = "Numpedorigem";

    private decimal? _numpedorigem;

    private static readonly string RO_NUMPEDORIGEMFRETE = "Numpedorigemfrete";

    private decimal? _numpedorigemfrete;

    private static readonly string RO_NUMPEDRCA = "Numpedrca";

    private decimal? _numpedrca;

    private static readonly string RO_NUMPEDTV1 = "Numpedtv1";

    private decimal? _numpedtv1;

    private static readonly string RO_NUMPEDTV3 = "Numpedtv3";

    private decimal? _numpedtv3;

    private static readonly string RO_NUMPEDVALE = "Numpedvale";

    private decimal? _numpedvale;

    private static readonly string RO_NUMPEDWEB = "Numpedweb";

    private decimal? _numpedweb;

    private static readonly string RO_NUMPESO = "Numpeso";

    private decimal? _numpeso;

    private static readonly string RO_NUMPREVENDA = "Numprevenda";

    private decimal? _numprevenda;

    private static readonly string RO_NUMPROCESSO = "Numprocesso";

    private string _numprocesso;

    private static readonly string RO_NUMREGIAO = "Numregiao";

    private decimal? _numregiao;

    private static readonly string RO_NUMSEQCORREIO = "Numseqcorreio";

    private decimal? _numseqcorreio;

    private static readonly string RO_NUMSEQENTR = "Numseqentr";

    private decimal? _numseqentr;

    private static readonly string RO_NUMSEQENTREGA = "Numseqentrega";

    private decimal? _numseqentrega;

    private static readonly string RO_NUMSEQENVIO = "Numseqenvio";

    private decimal? _numseqenvio;

    private static readonly string RO_NUMSEQMONTAGEM = "Numseqmontagem";

    private decimal? _numseqmontagem;

    private static readonly string RO_NUMSEQRETORNO1 = "Numseqretorno1";

    private decimal? _numseqretorno1;

    private static readonly string RO_NUMSEQRETORNO2 = "Numseqretorno2";

    private decimal? _numseqretorno2;

    private static readonly string RO_NUMSEQROTA = "Numseqrota";

    private decimal? _numseqrota;

    private static readonly string RO_NUMSERIEEQUIP = "Numserieequip";

    private string _numserieequip;

    private static readonly string RO_NUMTABELA = "Numtabela";

    private string _numtabela;

    private static readonly string RO_NUMTRANSACAOTRANSF = "Numtransacaotransf";

    private decimal? _numtransacaotransf;

    private static readonly string RO_NUMTRANSVENDA = "Numtransvenda";

    private decimal? _numtransvenda;

    private static readonly string RO_NUMTRANSWMS = "Numtranswms";

    private decimal? _numtranswms;

    private static readonly string RO_NUMVIASETIQUETA = "Numviasetiqueta";

    private decimal? _numviasetiqueta;

    private static readonly string RO_NUMVIASMAPASEP = "Numviasmapasep";

    private decimal? _numviasmapasep;

    private static readonly string RO_NUMVIASPEDIDO = "Numviaspedido";

    private decimal? _numviaspedido;

    private static readonly string RO_NUMVOLUME = "Numvolume";

    private decimal? _numvolume;

    private static readonly string RO_NUMVOLUMEAGRUPADO = "Numvolumeagrupado";

    private decimal? _numvolumeagrupado;

    private static readonly string RO_OBS = "Obs";

    private string _obs;

    private static readonly string RO_OBSENTREGA1 = "Obsentrega1";

    private string _obsentrega1;

    private static readonly string RO_OBSENTREGA2 = "Obsentrega2";

    private string _obsentrega2;

    private static readonly string RO_OBSENTREGA3 = "Obsentrega3";

    private string _obsentrega3;

    private static readonly string RO_OBSENTREGA4 = "Obsentrega4";

    private string _obsentrega4;

    private static readonly string RO_OBSFRETENF1 = "Obsfretenf1";

    private string _obsfretenf1;

    private static readonly string RO_OBSFRETENF2 = "Obsfretenf2";

    private string _obsfretenf2;

    private static readonly string RO_OBSFRETENF3 = "Obsfretenf3";

    private string _obsfretenf3;

    private static readonly string RO_OBS1 = "Obs1";

    private string _obs1;

    private static readonly string RO_OBS2 = "Obs2";

    private string _obs2;

    private static readonly string RO_OPERACAO = "Operacao";

    private string _operacao;

    private static readonly string RO_ORIGEMPED = "Origemped";

    private string _origemped;

    private static readonly string RO_PAGTOANTECIPADO = "Pagtoantecipado";

    private string _pagtoantecipado;

    private static readonly string RO_PEDDUPLICADO = "Pedduplicado";

    private string _pedduplicado;

    private static readonly string RO_PEDIDOEMBALADO = "Pedidoembalado";

    private string _pedidoembalado;

    private static readonly string RO_PERCCOMPROFISSIONAL = "Perccomprofissional";

    private decimal? _perccomprofissional;

    private static readonly string RO_PERCDESCABC = "Percdescabc";

    private decimal? _percdescabc;

    private static readonly string RO_PERCDESCCANAL = "Percdesccanal";

    private decimal? _percdesccanal;

    private static readonly string RO_PERCDESCCLI = "Percdesccli";

    private decimal? _percdesccli;

    private static readonly string RO_PERCDESCNEG = "Percdescneg";

    private decimal? _percdescneg;

    private static readonly string RO_PERCFRETE = "Percfrete";

    private decimal? _percfrete;

    private static readonly string RO_PERCFRETERETIDO = "Percfreteretido";

    private decimal? _percfreteretido;

    private static readonly string RO_PERCSALDORESERVARCA = "Percsaldoreservarca";

    private decimal? _percsaldoreservarca;

    private static readonly string RO_PERCSTFRETERETIDO = "Percstfreteretido";

    private decimal? _percstfreteretido;

    private static readonly string RO_PERCVENDA = "Percvenda";

    private decimal? _percvenda;

    private static readonly string RO_PERDESC = "Perdesc";

    private decimal? _perdesc;

    private static readonly string RO_PERDESCFIN = "Perdescfin";

    private decimal? _perdescfin;

    private static readonly string RO_PERDESCLIB = "Perdesclib";

    private decimal? _perdesclib;

    private static readonly string RO_PLACAVEICULO = "Placaveiculo";

    private string _placaveiculo;

    private static readonly string RO_POSICAO = "Posicao";

    private string _posicao;

    private static readonly string RO_PRAZOADICIONAL = "Prazoadicional";

    private decimal? _prazoadicional;

    private static readonly string RO_PRAZOMEDIO = "Prazomedio";

    private decimal? _prazomedio;

    private static readonly string RO_PRAZOMEDIOPLPAG = "Prazomedioplpag";

    private decimal? _prazomedioplpag;

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

    private static readonly string RO_PRONTAENTREGA = "Prontaentrega";

    private string _prontaentrega;

    private static readonly string RO_PROTOCOLONFP = "Protocolonfp";

    private string _protocolonfp;

    private static readonly string RO_RECARGA = "Recarga";

    private string _recarga;

    private static readonly string RO_RESERVAESTOQUETV7 = "Reservaestoquetv7";

    private string _reservaestoquetv7;

    private static readonly string RO_RESERVARITENSTV7 = "Reservaritenstv7";

    private string _reservaritenstv7;

    private static readonly string RO_RESTRICAOTRANSP = "Restricaotransp";

    private string _restricaotransp;

    private static readonly string RO_RESTRICAOTRANSPORTE = "Restricaotransporte";

    private string _restricaotransporte;

    private static readonly string RO_ROTINA = "Rotina";

    private string _rotina;

    private static readonly string RO_ROTINALANC = "Rotinalanc";

    private string _rotinalanc;

    private static readonly string RO_ROTINALANCULTALT = "Rotinalancultalt";

    private string _rotinalancultalt;

    private static readonly string RO_SERIEECF = "Serieecf";

    private string _serieecf;

    private static readonly string RO_SERIEMANIF = "Seriemanif";

    private string _seriemanif;

    private static readonly string RO_SOFTNUMLANC = "Softnumlanc";

    private string _softnumlanc;

    private static readonly string RO_SUBSERIE = "Subserie";

    private string _subserie;

    private static readonly string RO_TIPOCARGA = "Tipocarga";

    private string _tipocarga;

    private static readonly string RO_TIPOCFOPTV4 = "Tipocfoptv4";

    private string _tipocfoptv4;

    private static readonly string RO_TIPODOCUMENTO = "Tipodocumento";

    private string _tipodocumento;

    private static readonly string RO_TIPOEMBALAGEM = "Tipoembalagem";

    private string _tipoembalagem;

    private static readonly string RO_TIPOFORMULARIONF = "Tipoformularionf";

    private string _tipoformularionf;

    private static readonly string RO_TIPOFV = "Tipofv";

    private string _tipofv;

    private static readonly string RO_TIPOMOVCCRCA = "Tipomovccrca";

    private string _tipomovccrca;

    private static readonly string RO_TIPOOPER = "Tipooper";

    private string _tipooper;

    private static readonly string RO_TIPOPRIORIDADEENTREGA = "Tipoprioridadeentrega";

    private string _tipoprioridadeentrega;

    private static readonly string RO_TIPORETIRADA = "Tiporetirada";

    private string _tiporetirada;

    private static readonly string RO_TIPOVENDA = "Tipovenda";

    private string _tipovenda;

    private static readonly string RO_TOTPESO = "Totpeso";

    private decimal? _totpeso;

    private static readonly string RO_TOTPESOAGRUPADO = "Totpesoagrupado";

    private decimal? _totpesoagrupado;

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

    private static readonly string RO_TRIBUTAPORREGIAOFILIAL = "Tributaporregiaofilial";

    private string _tributaporregiaofilial;

    private static readonly string RO_TROCAALTDEBCREDRCA = "Trocaaltdebcredrca";

    private string _trocaaltdebcredrca;

    private static readonly string RO_UFDESEMBARACO = "Ufdesembaraco";

    private string _ufdesembaraco;

    private static readonly string RO_UFVEICULO = "Ufveiculo";

    private string _ufveiculo;

    private static readonly string RO_USACFOPVENDANATV10 = "Usacfopvendanatv10";

    private string _usacfopvendanatv10;

    private static readonly string RO_USACREDRCA = "Usacredrca";

    private string _usacredrca;

    private static readonly string RO_USADEBCREDRCA = "Usadebcredrca";

    private string _usadebcredrca;

    private static readonly string RO_USAINTEGRACAOWMS = "Usaintegracaowms";

    private string _usaintegracaowms;

    private static readonly string RO_USASALDOCONTACORRENTEDESCFIN = "Usasaldocontacorrentedescfin";

    private string _usasaldocontacorrentedescfin;

    private static readonly string RO_VALORDESCFIN = "Valordescfin";

    private decimal? _valordescfin;

    private static readonly string RO_VENDAASSISTIDA = "Vendaassistida";

    private string _vendaassistida;

    private static readonly string RO_VENDAASSISTIVA = "Vendaassistiva";

    private string _vendaassistiva;

    private static readonly string RO_VENDATRIANGULAR = "Vendatriangular";

    private string _vendatriangular;

    private static readonly string RO_VERSAOROTINA = "Versaorotina";

    private string _versaorotina;

    private static readonly string RO_VERSAOFATURAMENTO = "Versaofaturamento";

    private string _versaofaturamento;

    private static readonly string RO_VLATEND = "Vlatend";

    private decimal? _vlatend;

    private static readonly string RO_VLBONIFIC = "Vlbonific";

    private decimal? _vlbonific;

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

    private static readonly string RO_VLDESCNEG = "Vldescneg";

    private decimal? _vldescneg;

    private static readonly string RO_VLDESCONTO = "Vldesconto";

    private decimal? _vldesconto;

    private static readonly string RO_VLENTRADA = "Vlentrada";

    private decimal? _vlentrada;

    private static readonly string RO_VLFRETE = "Vlfrete";

    private decimal? _vlfrete;

    private static readonly string RO_VLFRETENF = "Vlfretenf";

    private decimal? _vlfretenf;

    private static readonly string RO_VLFRETERETIDO = "Vlfreteretido";

    private decimal? _vlfreteretido;

    private static readonly string RO_VLICMSFRETENF = "Vlicmsfretenf";

    private decimal? _vlicmsfretenf;

    private static readonly string RO_VLOUTRASDESP = "Vloutrasdesp";

    private decimal? _vloutrasdesp;

    private static readonly string RO_VLSTFRETERETIDO = "Vlstfreteretido";

    private decimal? _vlstfreteretido;

    private static readonly string RO_VLTABELA = "Vltabela";

    private decimal? _vltabela;

    private static readonly string RO_VLTOTAL = "Vltotal";

    private decimal? _vltotal;

    private static readonly string RO_NSUSOCIOTORCEDOR = "Nsusociotorcedor";

    private string _nsusociotorcedor;

    private static readonly string RO_VLDESCSOCIOTORCEDOR = "Vldescsociotorcedor";

    private decimal? _vldescsociotorcedor;

    private static readonly string RO_VLSUBTOTAL = "Vlsubtotal";

    private decimal? _vlsubtotal;

    private static readonly string RO_DOCEMISSAO = "Docemissao";

    private string _docemissao;

    private static readonly string RO_CHAVENFCE = "Chavenfce";

    private string _chavenfce;

    private static readonly string RO_NUMFECHAMENTOMOVCX = "Numfechamentomovcx";

    private decimal? _numfechamentomovcx;

    private static readonly string RO_DTMOVIMENTOCX = "Dtmovimentocx";

    private DateTime? _dtmovimentocx;

    private static readonly string RO_VENDANFSERIED = "Vendanfseried";

    private string _vendanfseried;

    private static readonly string RO_PROTOCOLONFCE = "Protocolonfce";

    private string _protocolonfce;

    private string _fretedespacho;

    private decimal? _uidregistro;

    private string _idparceiro;

    private string _assinatura;

    private string _iefrete;

    private string _uffrete;

    private string _cgcfrete;

    private static readonly string RO_TRANSPORTADORA = "Transportadora";

    private string _transportadora;

    private static readonly string RO_VLJUROSPARCELAMENTO = "Vljurosparcelamento";

    private decimal? _vljurosparcelamento;

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Agrupamento
    {
        get
        {
            PropriedadeAcessada(RO_AGRUPAMENTO);
            return _agrupamento;
        }
        set
        {
            PropriedadeModificada(RO_AGRUPAMENTO, value);
            _agrupamento = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 2)]
    public decimal? Aliqicmsfretenf
    {
        get
        {
            PropriedadeAcessada(RO_ALIQICMSFRETENF);
            return _aliqicmsfretenf;
        }
        set
        {
            PropriedadeModificada(RO_ALIQICMSFRETENF, value);
            _aliqicmsfretenf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Altaposmapasep
    {
        get
        {
            PropriedadeAcessada(RO_ALTAPOSMAPASEP);
            return _altaposmapasep;
        }
        set
        {
            PropriedadeModificada(RO_ALTAPOSMAPASEP, value);
            _altaposmapasep = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Baixaestcli
    {
        get
        {
            PropriedadeAcessada(RO_BAIXAESTCLI);
            return _baixaestcli;
        }
        set
        {
            PropriedadeModificada(RO_BAIXAESTCLI, value);
            _baixaestcli = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 2)]
    public decimal? Baseicmsfretenf
    {
        get
        {
            PropriedadeAcessada(RO_BASEICMSFRETENF);
            return _baseicmsfretenf;
        }
        set
        {
            PropriedadeModificada(RO_BASEICMSFRETENF, value);
            _baseicmsfretenf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Bloqcomercial
    {
        get
        {
            PropriedadeAcessada(RO_BLOQCOMERCIAL);
            return _bloqcomercial;
        }
        set
        {
            PropriedadeModificada(RO_BLOQCOMERCIAL, value);
            _bloqcomercial = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Bloqfinanceiro
    {
        get
        {
            PropriedadeAcessada(RO_BLOQFINANCEIRO);
            return _bloqfinanceiro;
        }
        set
        {
            PropriedadeModificada(RO_BLOQFINANCEIRO, value);
            _bloqfinanceiro = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Bloqueioedicao
    {
        get
        {
            PropriedadeAcessada(RO_BLOQUEIOEDICAO);
            return _bloqueioedicao;
        }
        set
        {
            PropriedadeModificada(RO_BLOQUEIOEDICAO, value);
            _bloqueioedicao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Bloqueiosaldoccdescfin
    {
        get
        {
            PropriedadeAcessada(RO_BLOQUEIOSALDOCCDESCFIN);
            return _bloqueiosaldoccdescfin;
        }
        set
        {
            PropriedadeModificada(RO_BLOQUEIOSALDOCCDESCFIN, value);
            _bloqueiosaldoccdescfin = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Bonificaltdebcredrca
    {
        get
        {
            PropriedadeAcessada(RO_BONIFICALTDEBCREDRCA);
            return _bonificaltdebcredrca;
        }
        set
        {
            PropriedadeModificada(RO_BONIFICALTDEBCREDRCA, value);
            _bonificaltdebcredrca = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Brokeraltdebcredrca
    {
        get
        {
            PropriedadeAcessada(RO_BROKERALTDEBCREDRCA);
            return _brokeraltdebcredrca;
        }
        set
        {
            PropriedadeModificada(RO_BROKERALTDEBCREDRCA, value);
            _brokeraltdebcredrca = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Campanha
    {
        get
        {
            PropriedadeAcessada(RO_CAMPANHA);
            return _campanha;
        }
        set
        {
            PropriedadeModificada(RO_CAMPANHA, value);
            _campanha = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Cfopbnfdegusta
    {
        get
        {
            PropriedadeAcessada(RO_CFOPBNFDEGUSTA);
            return _cfopbnfdegusta;
        }
        set
        {
            PropriedadeModificada(RO_CFOPBNFDEGUSTA, value);
            _cfopbnfdegusta = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 6, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codatendimento
    {
        get
        {
            PropriedadeAcessada(RO_CODATENDIMENTO);
            return _codatendimento;
        }
        set
        {
            PropriedadeModificada(RO_CODATENDIMENTO, value);
            _codatendimento = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codautorizacaotef
    {
        get
        {
            PropriedadeAcessada(RO_CODAUTORIZACAOTEF);
            return _codautorizacaotef;
        }
        set
        {
            PropriedadeModificada(RO_CODAUTORIZACAOTEF, value);
            _codautorizacaotef = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 128, Precisao = 0)]
    public string Codautorizacaotefweb
    {
        get
        {
            PropriedadeAcessada(RO_CODAUTORIZACAOTEFWEB);
            return _codautorizacaotefweb;
        }
        set
        {
            PropriedadeModificada(RO_CODAUTORIZACAOTEFWEB, value);
            _codautorizacaotefweb = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codcliconsignacao
    {
        get
        {
            PropriedadeAcessada(RO_CODCLICONSIGNACAO);
            return _codcliconsignacao;
        }
        set
        {
            PropriedadeModificada(RO_CODCLICONSIGNACAO, value);
            _codcliconsignacao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codclitv8
    {
        get
        {
            PropriedadeAcessada(RO_CODCLITV8);
            return _codclitv8;
        }
        set
        {
            PropriedadeModificada(RO_CODCLITV8, value);
            _codclitv8 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 4, Precisao = 0)]
    public string Coddistrib
    {
        get
        {
            PropriedadeAcessada(RO_CODDISTRIB);
            return _coddistrib;
        }
        set
        {
            PropriedadeModificada(RO_CODDISTRIB, value);
            _coddistrib = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codendent
    {
        get
        {
            PropriedadeAcessada(RO_CODENDENT);
            return _codendent;
        }
        set
        {
            PropriedadeModificada(RO_CODENDENT, value);
            _codendent = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 3, Precisao = 0)]
    public string Codestabelecimento
    {
        get
        {
            PropriedadeAcessada(RO_CODESTABELECIMENTO);
            return _codestabelecimento;
        }
        set
        {
            PropriedadeModificada(RO_CODESTABELECIMENTO, value);
            _codestabelecimento = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codfornecvdireto
    {
        get
        {
            PropriedadeAcessada(RO_CODFORNECVDIRETO);
            return _codfornecvdireto;
        }
        set
        {
            PropriedadeModificada(RO_CODFORNECVDIRETO, value);
            _codfornecvdireto = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfunccalcfrete
    {
        get
        {
            PropriedadeAcessada(RO_CODFUNCCALCFRETE);
            return _codfunccalcfrete;
        }
        set
        {
            PropriedadeModificada(RO_CODFUNCCALCFRETE, value);
            _codfunccalcfrete = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfuncconfgarantia
    {
        get
        {
            PropriedadeAcessada(RO_CODFUNCCONFGARANTIA);
            return _codfuncconfgarantia;
        }
        set
        {
            PropriedadeModificada(RO_CODFUNCCONFGARANTIA, value);
            _codfuncconfgarantia = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfuncembalador
    {
        get
        {
            PropriedadeAcessada(RO_CODFUNCEMBALADOR);
            return _codfuncembalador;
        }
        set
        {
            PropriedadeModificada(RO_CODFUNCEMBALADOR, value);
            _codfuncembalador = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfuncemissaomapa
    {
        get
        {
            PropriedadeAcessada(RO_CODFUNCEMISSAOMAPA);
            return _codfuncemissaomapa;
        }
        set
        {
            PropriedadeModificada(RO_CODFUNCEMISSAOMAPA, value);
            _codfuncemissaomapa = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfuncexparqol
    {
        get
        {
            PropriedadeAcessada(RO_CODFUNCEXPARQOL);
            return _codfuncexparqol;
        }
        set
        {
            PropriedadeModificada(RO_CODFUNCEXPARQOL, value);
            _codfuncexparqol = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfuncexpintwms
    {
        get
        {
            PropriedadeAcessada(RO_CODFUNCEXPINTWMS);
            return _codfuncexpintwms;
        }
        set
        {
            PropriedadeModificada(RO_CODFUNCEXPINTWMS, value);
            _codfuncexpintwms = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfuncimpintwms
    {
        get
        {
            PropriedadeAcessada(RO_CODFUNCIMPINTWMS);
            return _codfuncimpintwms;
        }
        set
        {
            PropriedadeModificada(RO_CODFUNCIMPINTWMS, value);
            _codfuncimpintwms = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfunclibdesc
    {
        get
        {
            PropriedadeAcessada(RO_CODFUNCLIBDESC);
            return _codfunclibdesc;
        }
        set
        {
            PropriedadeModificada(RO_CODFUNCLIBDESC, value);
            _codfunclibdesc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfunclibera
    {
        get
        {
            PropriedadeAcessada(RO_CODFUNCLIBERA);
            return _codfunclibera;
        }
        set
        {
            PropriedadeModificada(RO_CODFUNCLIBERA, value);
            _codfunclibera = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfunclibera2
    {
        get
        {
            PropriedadeAcessada(RO_CODFUNCLIBERA2);
            return _codfunclibera2;
        }
        set
        {
            PropriedadeModificada(RO_CODFUNCLIBERA2, value);
            _codfunclibera2 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfuncprotocolo
    {
        get
        {
            PropriedadeAcessada(RO_CODFUNCPROTOCOLO);
            return _codfuncprotocolo;
        }
        set
        {
            PropriedadeModificada(RO_CODFUNCPROTOCOLO, value);
            _codfuncprotocolo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfuncsep
    {
        get
        {
            PropriedadeAcessada(RO_CODFUNCSEP);
            return _codfuncsep;
        }
        set
        {
            PropriedadeModificada(RO_CODFUNCSEP, value);
            _codfuncsep = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codigosazonalidade
    {
        get
        {
            PropriedadeAcessada(RO_CODIGOSAZONALIDADE);
            return _codigosazonalidade;
        }
        set
        {
            PropriedadeModificada(RO_CODIGOSAZONALIDADE, value);
            _codigosazonalidade = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codmotbloqueio
    {
        get
        {
            PropriedadeAcessada(RO_CODMOTBLOQUEIO);
            return _codmotbloqueio;
        }
        set
        {
            PropriedadeModificada(RO_CODMOTBLOQUEIO, value);
            _codmotbloqueio = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codmotcancel
    {
        get
        {
            PropriedadeAcessada(RO_CODMOTCANCEL);
            return _codmotcancel;
        }
        set
        {
            PropriedadeModificada(RO_CODMOTCANCEL, value);
            _codmotcancel = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codmotivo
    {
        get
        {
            PropriedadeAcessada(RO_CODMOTIVO);
            return _codmotivo;
        }
        set
        {
            PropriedadeModificada(RO_CODMOTIVO, value);
            _codmotivo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codmotivo2
    {
        get
        {
            PropriedadeAcessada(RO_CODMOTIVO2);
            return _codmotivo2;
        }
        set
        {
            PropriedadeModificada(RO_CODMOTIVO2, value);
            _codmotivo2 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal Codplpag
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Codplpagetico
    {
        get
        {
            PropriedadeAcessada(RO_CODPLPAGETICO);
            return _codplpagetico;
        }
        set
        {
            PropriedadeModificada(RO_CODPLPAGETICO, value);
            _codplpagetico = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Codplpaggenerico
    {
        get
        {
            PropriedadeAcessada(RO_CODPLPAGGENERICO);
            return _codplpaggenerico;
        }
        set
        {
            PropriedadeModificada(RO_CODPLPAGGENERICO, value);
            _codplpaggenerico = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 15, Precisao = 0)]
    public string Codpostagem
    {
        get
        {
            PropriedadeAcessada(RO_CODPOSTAGEM);
            return _codpostagem;
        }
        set
        {
            PropriedadeModificada(RO_CODPOSTAGEM, value);
            _codpostagem = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Codpracadestino
    {
        get
        {
            PropriedadeAcessada(RO_CODPRACADESTINO);
            return _codpracadestino;
        }
        set
        {
            PropriedadeModificada(RO_CODPRACADESTINO, value);
            _codpracadestino = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codprofissional
    {
        get
        {
            PropriedadeAcessada(RO_CODPROFISSIONAL);
            return _codprofissional;
        }
        set
        {
            PropriedadeModificada(RO_CODPROFISSIONAL, value);
            _codprofissional = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal Codsupervisor
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codtransp
    {
        get
        {
            PropriedadeAcessada(RO_CODTRANSP);
            return _codtransp;
        }
        set
        {
            PropriedadeModificada(RO_CODTRANSP, value);
            _codtransp = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 12, Precisao = 0)]
    public string Codveiculo
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Codvisita
    {
        get
        {
            PropriedadeAcessada(RO_CODVISITA);
            return _codvisita;
        }
        set
        {
            PropriedadeModificada(RO_CODVISITA, value);
            _codvisita = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Conciliaimportacao
    {
        get
        {
            PropriedadeAcessada(RO_CONCILIAIMPORTACAO);
            return _conciliaimportacao;
        }
        set
        {
            PropriedadeModificada(RO_CONCILIAIMPORTACAO, value);
            _conciliaimportacao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Conferindopedido
    {
        get
        {
            PropriedadeAcessada(RO_CONFERINDOPEDIDO);
            return _conferindopedido;
        }
        set
        {
            PropriedadeModificada(RO_CONFERINDOPEDIDO, value);
            _conferindopedido = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Crmaltdebcredrca
    {
        get
        {
            PropriedadeAcessada(RO_CRMALTDEBCREDRCA);
            return _crmaltdebcredrca;
        }
        set
        {
            PropriedadeModificada(RO_CRMALTDEBCREDRCA, value);
            _crmaltdebcredrca = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 2)]
    public decimal? Custoentrega
    {
        get
        {
            PropriedadeAcessada(RO_CUSTOENTREGA);
            return _custoentrega;
        }
        set
        {
            PropriedadeModificada(RO_CUSTOENTREGA, value);
            _custoentrega = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime Data
    {
        get
        {
            PropriedadeAcessada(RO_DATA);
            return _data;
        }
        set
        {
            PropriedadeModificada(RO_DATA, value);
            _data = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dataexparqol
    {
        get
        {
            PropriedadeAcessada(RO_DATAEXPARQOL);
            return _dataexparqol;
        }
        set
        {
            PropriedadeModificada(RO_DATAEXPARQOL, value);
            _dataexparqol = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Datapedcli
    {
        get
        {
            PropriedadeAcessada(RO_DATAPEDCLI);
            return _datapedcli;
        }
        set
        {
            PropriedadeModificada(RO_DATAPEDCLI, value);
            _datapedcli = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dataprotocolo
    {
        get
        {
            PropriedadeAcessada(RO_DATAPROTOCOLO);
            return _dataprotocolo;
        }
        set
        {
            PropriedadeModificada(RO_DATAPROTOCOLO, value);
            _dataprotocolo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtaberturapedpalm
    {
        get
        {
            PropriedadeAcessada(RO_DTABERTURAPEDPALM);
            return _dtaberturapedpalm;
        }
        set
        {
            PropriedadeModificada(RO_DTABERTURAPEDPALM, value);
            _dtaberturapedpalm = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtagendaentrega
    {
        get
        {
            PropriedadeAcessada(RO_DTAGENDAENTREGA);
            return _dtagendaentrega;
        }
        set
        {
            PropriedadeModificada(RO_DTAGENDAENTREGA, value);
            _dtagendaentrega = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtcalcfrete
    {
        get
        {
            PropriedadeAcessada(RO_DTCALCFRETE);
            return _dtcalcfrete;
        }
        set
        {
            PropriedadeModificada(RO_DTCALCFRETE, value);
            _dtcalcfrete = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtchegadacliente
    {
        get
        {
            PropriedadeAcessada(RO_DTCHEGADACLIENTE);
            return _dtchegadacliente;
        }
        set
        {
            PropriedadeModificada(RO_DTCHEGADACLIENTE, value);
            _dtchegadacliente = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtconfgarantia
    {
        get
        {
            PropriedadeAcessada(RO_DTCONFGARANTIA);
            return _dtconfgarantia;
        }
        set
        {
            PropriedadeModificada(RO_DTCONFGARANTIA, value);
            _dtconfgarantia = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtemissaomapa
    {
        get
        {
            PropriedadeAcessada(RO_DTEMISSAOMAPA);
            return _dtemissaomapa;
        }
        set
        {
            PropriedadeModificada(RO_DTEMISSAOMAPA, value);
            _dtemissaomapa = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtexportacao
    {
        get
        {
            PropriedadeAcessada(RO_DTEXPORTACAO);
            return _dtexportacao;
        }
        set
        {
            PropriedadeModificada(RO_DTEXPORTACAO, value);
            _dtexportacao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtexportado
    {
        get
        {
            PropriedadeAcessada(RO_DTEXPORTADO);
            return _dtexportado;
        }
        set
        {
            PropriedadeModificada(RO_DTEXPORTADO, value);
            _dtexportado = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtfechamentopedpalm
    {
        get
        {
            PropriedadeAcessada(RO_DTFECHAMENTOPEDPALM);
            return _dtfechamentopedpalm;
        }
        set
        {
            PropriedadeModificada(RO_DTFECHAMENTOPEDPALM, value);
            _dtfechamentopedpalm = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtfimdigitacaopedido
    {
        get
        {
            PropriedadeAcessada(RO_DTFIMDIGITACAOPEDIDO);
            return _dtfimdigitacaopedido;
        }
        set
        {
            PropriedadeModificada(RO_DTFIMDIGITACAOPEDIDO, value);
            _dtfimdigitacaopedido = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtfinalcheckout
    {
        get
        {
            PropriedadeAcessada(RO_DTFINALCHECKOUT);
            return _dtfinalcheckout;
        }
        set
        {
            PropriedadeModificada(RO_DTFINALCHECKOUT, value);
            _dtfinalcheckout = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtfinalpend
    {
        get
        {
            PropriedadeAcessada(RO_DTFINALPEND);
            return _dtfinalpend;
        }
        set
        {
            PropriedadeModificada(RO_DTFINALPEND, value);
            _dtfinalpend = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtfinalsep
    {
        get
        {
            PropriedadeAcessada(RO_DTFINALSEP);
            return _dtfinalsep;
        }
        set
        {
            PropriedadeModificada(RO_DTFINALSEP, value);
            _dtfinalsep = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtimportacao
    {
        get
        {
            PropriedadeAcessada(RO_DTIMPORTACAO);
            return _dtimportacao;
        }
        set
        {
            PropriedadeModificada(RO_DTIMPORTACAO, value);
            _dtimportacao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtimportado
    {
        get
        {
            PropriedadeAcessada(RO_DTIMPORTADO);
            return _dtimportado;
        }
        set
        {
            PropriedadeModificada(RO_DTIMPORTADO, value);
            _dtimportado = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtinicialcheckout
    {
        get
        {
            PropriedadeAcessada(RO_DTINICIALCHECKOUT);
            return _dtinicialcheckout;
        }
        set
        {
            PropriedadeModificada(RO_DTINICIALCHECKOUT, value);
            _dtinicialcheckout = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtinicialpend
    {
        get
        {
            PropriedadeAcessada(RO_DTINICIALPEND);
            return _dtinicialpend;
        }
        set
        {
            PropriedadeModificada(RO_DTINICIALPEND, value);
            _dtinicialpend = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtinicialsep
    {
        get
        {
            PropriedadeAcessada(RO_DTINICIALSEP);
            return _dtinicialsep;
        }
        set
        {
            PropriedadeModificada(RO_DTINICIALSEP, value);
            _dtinicialsep = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtiniciodigitacaopedido
    {
        get
        {
            PropriedadeAcessada(RO_DTINICIODIGITACAOPEDIDO);
            return _dtiniciodigitacaopedido;
        }
        set
        {
            PropriedadeModificada(RO_DTINICIODIGITACAOPEDIDO, value);
            _dtiniciodigitacaopedido = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtlibera
    {
        get
        {
            PropriedadeAcessada(RO_DTLIBERA);
            return _dtlibera;
        }
        set
        {
            PropriedadeModificada(RO_DTLIBERA, value);
            _dtlibera = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtlibera2
    {
        get
        {
            PropriedadeAcessada(RO_DTLIBERA2);
            return _dtlibera2;
        }
        set
        {
            PropriedadeModificada(RO_DTLIBERA2, value);
            _dtlibera2 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtlimitefat
    {
        get
        {
            PropriedadeAcessada(RO_DTLIMITEFAT);
            return _dtlimitefat;
        }
        set
        {
            PropriedadeModificada(RO_DTLIMITEFAT, value);
            _dtlimitefat = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtnftransf
    {
        get
        {
            PropriedadeAcessada(RO_DTNFTRANSF);
            return _dtnftransf;
        }
        set
        {
            PropriedadeModificada(RO_DTNFTRANSF, value);
            _dtnftransf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtvalidade
    {
        get
        {
            PropriedadeAcessada(RO_DTVALIDADE);
            return _dtvalidade;
        }
        set
        {
            PropriedadeModificada(RO_DTVALIDADE, value);
            _dtvalidade = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtvenc1
    {
        get
        {
            PropriedadeAcessada(RO_DTVENC1);
            return _dtvenc1;
        }
        set
        {
            PropriedadeModificada(RO_DTVENC1, value);
            _dtvenc1 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtvenc2
    {
        get
        {
            PropriedadeAcessada(RO_DTVENC2);
            return _dtvenc2;
        }
        set
        {
            PropriedadeModificada(RO_DTVENC2, value);
            _dtvenc2 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtvenc3
    {
        get
        {
            PropriedadeAcessada(RO_DTVENC3);
            return _dtvenc3;
        }
        set
        {
            PropriedadeModificada(RO_DTVENC3, value);
            _dtvenc3 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 0)]
    public decimal? Eancobranca
    {
        get
        {
            PropriedadeAcessada(RO_EANCOBRANCA);
            return _eancobranca;
        }
        set
        {
            PropriedadeModificada(RO_EANCOBRANCA, value);
            _eancobranca = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 0)]
    public decimal? Eancomprador
    {
        get
        {
            PropriedadeAcessada(RO_EANCOMPRADOR);
            return _eancomprador;
        }
        set
        {
            PropriedadeModificada(RO_EANCOMPRADOR, value);
            _eancomprador = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 0)]
    public decimal? Eanentrega
    {
        get
        {
            PropriedadeAcessada(RO_EANENTREGA);
            return _eanentrega;
        }
        set
        {
            PropriedadeModificada(RO_EANENTREGA, value);
            _eanentrega = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 0)]
    public decimal? Eanlocalentrega
    {
        get
        {
            PropriedadeAcessada(RO_EANLOCALENTREGA);
            return _eanlocalentrega;
        }
        set
        {
            PropriedadeModificada(RO_EANLOCALENTREGA, value);
            _eanlocalentrega = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Especiemanif
    {
        get
        {
            PropriedadeAcessada(RO_ESPECIEMANIF);
            return _especiemanif;
        }
        set
        {
            PropriedadeModificada(RO_ESPECIEMANIF, value);
            _especiemanif = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 100, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Exportado
    {
        get
        {
            PropriedadeAcessada(RO_EXPORTADO);
            return _exportado;
        }
        set
        {
            PropriedadeModificada(RO_EXPORTADO, value);
            _exportado = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Gerarcontroledeentrega
    {
        get
        {
            PropriedadeAcessada(RO_GERARCONTROLEDEENTREGA);
            return _gerarcontroledeentrega;
        }
        set
        {
            PropriedadeModificada(RO_GERARCONTROLEDEENTREGA, value);
            _gerarcontroledeentrega = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Gerardadosnfpaulista
    {
        get
        {
            PropriedadeAcessada(RO_GERARDADOSNFPAULISTA);
            return _gerardadosnfpaulista;
        }
        set
        {
            PropriedadeModificada(RO_GERARDADOSNFPAULISTA, value);
            _gerardadosnfpaulista = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 2, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 2, Precisao = 0)]
    public decimal? Horaemissaomapa
    {
        get
        {
            PropriedadeAcessada(RO_HORAEMISSAOMAPA);
            return _horaemissaomapa;
        }
        set
        {
            PropriedadeModificada(RO_HORAEMISSAOMAPA, value);
            _horaemissaomapa = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 2, Precisao = 0)]
    public decimal? Horafat
    {
        get
        {
            PropriedadeAcessada(RO_HORAFAT);
            return _horafat;
        }
        set
        {
            PropriedadeModificada(RO_HORAFAT, value);
            _horafat = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 2, Precisao = 0)]
    public decimal? Horafinalsep
    {
        get
        {
            PropriedadeAcessada(RO_HORAFINALSEP);
            return _horafinalsep;
        }
        set
        {
            PropriedadeModificada(RO_HORAFINALSEP, value);
            _horafinalsep = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 2, Precisao = 0)]
    public decimal? Horainicialsep
    {
        get
        {
            PropriedadeAcessada(RO_HORAINICIALSEP);
            return _horainicialsep;
        }
        set
        {
            PropriedadeModificada(RO_HORAINICIALSEP, value);
            _horainicialsep = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 2, Precisao = 0)]
    public decimal? Horalibera
    {
        get
        {
            PropriedadeAcessada(RO_HORALIBERA);
            return _horalibera;
        }
        set
        {
            PropriedadeModificada(RO_HORALIBERA, value);
            _horalibera = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 2, Precisao = 0)]
    public decimal? Horaprotocolo
    {
        get
        {
            PropriedadeAcessada(RO_HORAPROTOCOLO);
            return _horaprotocolo;
        }
        set
        {
            PropriedadeModificada(RO_HORAPROTOCOLO, value);
            _horaprotocolo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 1, Precisao = 0)]
    public decimal? Importacupom
    {
        get
        {
            PropriedadeAcessada(RO_IMPORTACUPOM);
            return _importacupom;
        }
        set
        {
            PropriedadeModificada(RO_IMPORTACUPOM, value);
            _importacupom = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Integradora
    {
        get
        {
            PropriedadeAcessada(RO_INTEGRADORA);
            return _integradora;
        }
        set
        {
            PropriedadeModificada(RO_INTEGRADORA, value);
            _integradora = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 30, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 100, Precisao = 0)]
    public string Localizacaopedido
    {
        get
        {
            PropriedadeAcessada(RO_LOCALIZACAOPEDIDO);
            return _localizacaopedido;
        }
        set
        {
            PropriedadeModificada(RO_LOCALIZACAOPEDIDO, value);
            _localizacaopedido = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 4000, Precisao = 0)]
    public string Log
    {
        get
        {
            PropriedadeAcessada(RO_LOG);
            return _log;
        }
        set
        {
            PropriedadeModificada(RO_LOG, value);
            _log = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 4000, Precisao = 0)]
    public string Log1
    {
        get
        {
            PropriedadeAcessada(RO_LOG1);
            return _log1;
        }
        set
        {
            PropriedadeModificada(RO_LOG1, value);
            _log1 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 4000, Precisao = 0)]
    public string Log2
    {
        get
        {
            PropriedadeAcessada(RO_LOG2);
            return _log2;
        }
        set
        {
            PropriedadeModificada(RO_LOG2, value);
            _log2 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 4000, Precisao = 0)]
    public string Log3
    {
        get
        {
            PropriedadeAcessada(RO_LOG3);
            return _log3;
        }
        set
        {
            PropriedadeModificada(RO_LOG3, value);
            _log3 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 4000, Precisao = 0)]
    public string Log4
    {
        get
        {
            PropriedadeAcessada(RO_LOG4);
            return _log4;
        }
        set
        {
            PropriedadeModificada(RO_LOG4, value);
            _log4 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 100, Precisao = 0)]
    public string Marcavolume
    {
        get
        {
            PropriedadeAcessada(RO_MARCAVOLUME);
            return _marcavolume;
        }
        set
        {
            PropriedadeModificada(RO_MARCAVOLUME, value);
            _marcavolume = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 2, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 2, Precisao = 0)]
    public decimal? Minutoemissaomapa
    {
        get
        {
            PropriedadeAcessada(RO_MINUTOEMISSAOMAPA);
            return _minutoemissaomapa;
        }
        set
        {
            PropriedadeModificada(RO_MINUTOEMISSAOMAPA, value);
            _minutoemissaomapa = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 2, Precisao = 0)]
    public decimal? Minutofat
    {
        get
        {
            PropriedadeAcessada(RO_MINUTOFAT);
            return _minutofat;
        }
        set
        {
            PropriedadeModificada(RO_MINUTOFAT, value);
            _minutofat = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 2, Precisao = 0)]
    public decimal? Minutofinalsep
    {
        get
        {
            PropriedadeAcessada(RO_MINUTOFINALSEP);
            return _minutofinalsep;
        }
        set
        {
            PropriedadeModificada(RO_MINUTOFINALSEP, value);
            _minutofinalsep = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 2, Precisao = 0)]
    public decimal? Minutoinicialsep
    {
        get
        {
            PropriedadeAcessada(RO_MINUTOINICIALSEP);
            return _minutoinicialsep;
        }
        set
        {
            PropriedadeModificada(RO_MINUTOINICIALSEP, value);
            _minutoinicialsep = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 2, Precisao = 0)]
    public decimal? Minutolibera
    {
        get
        {
            PropriedadeAcessada(RO_MINUTOLIBERA);
            return _minutolibera;
        }
        set
        {
            PropriedadeModificada(RO_MINUTOLIBERA, value);
            _minutolibera = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 2, Precisao = 0)]
    public decimal? Minutoprotocolo
    {
        get
        {
            PropriedadeAcessada(RO_MINUTOPROTOCOLO);
            return _minutoprotocolo;
        }
        set
        {
            PropriedadeModificada(RO_MINUTOPROTOCOLO, value);
            _minutoprotocolo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Montando
    {
        get
        {
            PropriedadeAcessada(RO_MONTANDO);
            return _montando;
        }
        set
        {
            PropriedadeModificada(RO_MONTANDO, value);
            _montando = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 60, Precisao = 0)]
    public string Motivoposicao
    {
        get
        {
            PropriedadeAcessada(RO_MOTIVOPOSICAO);
            return _motivoposicao;
        }
        set
        {
            PropriedadeModificada(RO_MOTIVOPOSICAO, value);
            _motivoposicao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Negociado
    {
        get
        {
            PropriedadeAcessada(RO_NEGOCIADO);
            return _negociado;
        }
        set
        {
            PropriedadeModificada(RO_NEGOCIADO, value);
            _negociado = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 100, Precisao = 0)]
    public string Nomearquivofv
    {
        get
        {
            PropriedadeAcessada(RO_NOMEARQUIVOFV);
            return _nomearquivofv;
        }
        set
        {
            PropriedadeModificada(RO_NOMEARQUIVOFV, value);
            _nomearquivofv = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 15, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal Numcar
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Numcaraux
    {
        get
        {
            PropriedadeAcessada(RO_NUMCARAUX);
            return _numcaraux;
        }
        set
        {
            PropriedadeModificada(RO_NUMCARAUX, value);
            _numcaraux = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Numcarfab
    {
        get
        {
            PropriedadeAcessada(RO_NUMCARFAB);
            return _numcarfab;
        }
        set
        {
            PropriedadeModificada(RO_NUMCARFAB, value);
            _numcarfab = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Numcarmanif
    {
        get
        {
            PropriedadeAcessada(RO_NUMCARMANIF);
            return _numcarmanif;
        }
        set
        {
            PropriedadeModificada(RO_NUMCARMANIF, value);
            _numcarmanif = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Numccf
    {
        get
        {
            PropriedadeAcessada(RO_NUMCCF);
            return _numccf;
        }
        set
        {
            PropriedadeModificada(RO_NUMCCF, value);
            _numccf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 10, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Numcontratocorreio
    {
        get
        {
            PropriedadeAcessada(RO_NUMCONTRATOCORREIO);
            return _numcontratocorreio;
        }
        set
        {
            PropriedadeModificada(RO_NUMCONTRATOCORREIO, value);
            _numcontratocorreio = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 10, Precisao = 0)]
    public string Numfonterecurso
    {
        get
        {
            PropriedadeAcessada(RO_NUMFONTERECURSO);
            return _numfonterecurso;
        }
        set
        {
            PropriedadeModificada(RO_NUMFONTERECURSO, value);
            _numfonterecurso = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 9, Precisao = 0)]
    public decimal? Numloteintwms
    {
        get
        {
            PropriedadeAcessada(RO_NUMLOTEINTWMS);
            return _numloteintwms;
        }
        set
        {
            PropriedadeModificada(RO_NUMLOTEINTWMS, value);
            _numloteintwms = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numnotaconsig
    {
        get
        {
            PropriedadeAcessada(RO_NUMNOTACONSIG);
            return _numnotaconsig;
        }
        set
        {
            PropriedadeModificada(RO_NUMNOTACONSIG, value);
            _numnotaconsig = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numnotamanif
    {
        get
        {
            PropriedadeAcessada(RO_NUMNOTAMANIF);
            return _numnotamanif;
        }
        set
        {
            PropriedadeModificada(RO_NUMNOTAMANIF, value);
            _numnotamanif = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numnotatransfdep
    {
        get
        {
            PropriedadeAcessada(RO_NUMNOTATRANSFDEP);
            return _numnotatransfdep;
        }
        set
        {
            PropriedadeModificada(RO_NUMNOTATRANSFDEP, value);
            _numnotatransfdep = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numorcaprinc
    {
        get
        {
            PropriedadeAcessada(RO_NUMORCAPRINC);
            return _numorcaprinc;
        }
        set
        {
            PropriedadeModificada(RO_NUMORCAPRINC, value);
            _numorcaprinc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Numordemcarga
    {
        get
        {
            PropriedadeAcessada(RO_NUMORDEMCARGA);
            return _numordemcarga;
        }
        set
        {
            PropriedadeModificada(RO_NUMORDEMCARGA, value);
            _numordemcarga = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal Numped
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numpedbnf
    {
        get
        {
            PropriedadeAcessada(RO_NUMPEDBNF);
            return _numpedbnf;
        }
        set
        {
            PropriedadeModificada(RO_NUMPEDBNF, value);
            _numpedbnf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 15, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numpedentfut
    {
        get
        {
            PropriedadeAcessada(RO_NUMPEDENTFUT);
            return _numpedentfut;
        }
        set
        {
            PropriedadeModificada(RO_NUMPEDENTFUT, value);
            _numpedentfut = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numpedorigem
    {
        get
        {
            PropriedadeAcessada(RO_NUMPEDORIGEM);
            return _numpedorigem;
        }
        set
        {
            PropriedadeModificada(RO_NUMPEDORIGEM, value);
            _numpedorigem = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numpedorigemfrete
    {
        get
        {
            PropriedadeAcessada(RO_NUMPEDORIGEMFRETE);
            return _numpedorigemfrete;
        }
        set
        {
            PropriedadeModificada(RO_NUMPEDORIGEMFRETE, value);
            _numpedorigemfrete = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numpedrca
    {
        get
        {
            PropriedadeAcessada(RO_NUMPEDRCA);
            return _numpedrca;
        }
        set
        {
            PropriedadeModificada(RO_NUMPEDRCA, value);
            _numpedrca = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numpedtv1
    {
        get
        {
            PropriedadeAcessada(RO_NUMPEDTV1);
            return _numpedtv1;
        }
        set
        {
            PropriedadeModificada(RO_NUMPEDTV1, value);
            _numpedtv1 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numpedtv3
    {
        get
        {
            PropriedadeAcessada(RO_NUMPEDTV3);
            return _numpedtv3;
        }
        set
        {
            PropriedadeModificada(RO_NUMPEDTV3, value);
            _numpedtv3 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numpedvale
    {
        get
        {
            PropriedadeAcessada(RO_NUMPEDVALE);
            return _numpedvale;
        }
        set
        {
            PropriedadeModificada(RO_NUMPEDVALE, value);
            _numpedvale = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 15, Precisao = 0)]
    public decimal? Numpedweb
    {
        get
        {
            PropriedadeAcessada(RO_NUMPEDWEB);
            return _numpedweb;
        }
        set
        {
            PropriedadeModificada(RO_NUMPEDWEB, value);
            _numpedweb = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Numpeso
    {
        get
        {
            PropriedadeAcessada(RO_NUMPESO);
            return _numpeso;
        }
        set
        {
            PropriedadeModificada(RO_NUMPESO, value);
            _numpeso = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
    public string Numprocesso
    {
        get
        {
            PropriedadeAcessada(RO_NUMPROCESSO);
            return _numprocesso;
        }
        set
        {
            PropriedadeModificada(RO_NUMPROCESSO, value);
            _numprocesso = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Numseqcorreio
    {
        get
        {
            PropriedadeAcessada(RO_NUMSEQCORREIO);
            return _numseqcorreio;
        }
        set
        {
            PropriedadeModificada(RO_NUMSEQCORREIO, value);
            _numseqcorreio = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Numseqentr
    {
        get
        {
            PropriedadeAcessada(RO_NUMSEQENTR);
            return _numseqentr;
        }
        set
        {
            PropriedadeModificada(RO_NUMSEQENTR, value);
            _numseqentr = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 20, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Numseqenvio
    {
        get
        {
            PropriedadeAcessada(RO_NUMSEQENVIO);
            return _numseqenvio;
        }
        set
        {
            PropriedadeModificada(RO_NUMSEQENVIO, value);
            _numseqenvio = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Numseqretorno1
    {
        get
        {
            PropriedadeAcessada(RO_NUMSEQRETORNO1);
            return _numseqretorno1;
        }
        set
        {
            PropriedadeModificada(RO_NUMSEQRETORNO1, value);
            _numseqretorno1 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Numseqretorno2
    {
        get
        {
            PropriedadeAcessada(RO_NUMSEQRETORNO2);
            return _numseqretorno2;
        }
        set
        {
            PropriedadeModificada(RO_NUMSEQRETORNO2, value);
            _numseqretorno2 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 2)]
    public decimal? Numseqrota
    {
        get
        {
            PropriedadeAcessada(RO_NUMSEQROTA);
            return _numseqrota;
        }
        set
        {
            PropriedadeModificada(RO_NUMSEQROTA, value);
            _numseqrota = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 30, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
    public string Numtabela
    {
        get
        {
            PropriedadeAcessada(RO_NUMTABELA);
            return _numtabela;
        }
        set
        {
            PropriedadeModificada(RO_NUMTABELA, value);
            _numtabela = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numtransacaotransf
    {
        get
        {
            PropriedadeAcessada(RO_NUMTRANSACAOTRANSF);
            return _numtransacaotransf;
        }
        set
        {
            PropriedadeModificada(RO_NUMTRANSACAOTRANSF, value);
            _numtransacaotransf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numtranswms
    {
        get
        {
            PropriedadeAcessada(RO_NUMTRANSWMS);
            return _numtranswms;
        }
        set
        {
            PropriedadeModificada(RO_NUMTRANSWMS, value);
            _numtranswms = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 2, Precisao = 0)]
    public decimal? Numviasetiqueta
    {
        get
        {
            PropriedadeAcessada(RO_NUMVIASETIQUETA);
            return _numviasetiqueta;
        }
        set
        {
            PropriedadeModificada(RO_NUMVIASETIQUETA, value);
            _numviasetiqueta = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 2, Precisao = 0)]
    public decimal? Numviasmapasep
    {
        get
        {
            PropriedadeAcessada(RO_NUMVIASMAPASEP);
            return _numviasmapasep;
        }
        set
        {
            PropriedadeModificada(RO_NUMVIASMAPASEP, value);
            _numviasmapasep = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 2, Precisao = 0)]
    public decimal? Numviaspedido
    {
        get
        {
            PropriedadeAcessada(RO_NUMVIASPEDIDO);
            return _numviaspedido;
        }
        set
        {
            PropriedadeModificada(RO_NUMVIASPEDIDO, value);
            _numviaspedido = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Numvolumeagrupado
    {
        get
        {
            PropriedadeAcessada(RO_NUMVOLUMEAGRUPADO);
            return _numvolumeagrupado;
        }
        set
        {
            PropriedadeModificada(RO_NUMVOLUMEAGRUPADO, value);
            _numvolumeagrupado = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 25, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 75, Precisao = 0)]
    public string Obsentrega1
    {
        get
        {
            PropriedadeAcessada(RO_OBSENTREGA1);
            return _obsentrega1;
        }
        set
        {
            PropriedadeModificada(RO_OBSENTREGA1, value);
            _obsentrega1 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 75, Precisao = 0)]
    public string Obsentrega2
    {
        get
        {
            PropriedadeAcessada(RO_OBSENTREGA2);
            return _obsentrega2;
        }
        set
        {
            PropriedadeModificada(RO_OBSENTREGA2, value);
            _obsentrega2 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 75, Precisao = 0)]
    public string Obsentrega3
    {
        get
        {
            PropriedadeAcessada(RO_OBSENTREGA3);
            return _obsentrega3;
        }
        set
        {
            PropriedadeModificada(RO_OBSENTREGA3, value);
            _obsentrega3 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 75, Precisao = 0)]
    public string Obsentrega4
    {
        get
        {
            PropriedadeAcessada(RO_OBSENTREGA4);
            return _obsentrega4;
        }
        set
        {
            PropriedadeModificada(RO_OBSENTREGA4, value);
            _obsentrega4 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 75, Precisao = 0)]
    public string Obsfretenf1
    {
        get
        {
            PropriedadeAcessada(RO_OBSFRETENF1);
            return _obsfretenf1;
        }
        set
        {
            PropriedadeModificada(RO_OBSFRETENF1, value);
            _obsfretenf1 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 75, Precisao = 0)]
    public string Obsfretenf2
    {
        get
        {
            PropriedadeAcessada(RO_OBSFRETENF2);
            return _obsfretenf2;
        }
        set
        {
            PropriedadeModificada(RO_OBSFRETENF2, value);
            _obsfretenf2 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 75, Precisao = 0)]
    public string Obsfretenf3
    {
        get
        {
            PropriedadeAcessada(RO_OBSFRETENF3);
            return _obsfretenf3;
        }
        set
        {
            PropriedadeModificada(RO_OBSFRETENF3, value);
            _obsfretenf3 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 50, Precisao = 0)]
    public string Obs1
    {
        get
        {
            PropriedadeAcessada(RO_OBS1);
            return _obs1;
        }
        set
        {
            PropriedadeModificada(RO_OBS1, value);
            _obs1 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 50, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Operacao
    {
        get
        {
            PropriedadeAcessada(RO_OPERACAO);
            return _operacao;
        }
        set
        {
            PropriedadeModificada(RO_OPERACAO, value);
            _operacao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Origemped
    {
        get
        {
            PropriedadeAcessada(RO_ORIGEMPED);
            return _origemped;
        }
        set
        {
            PropriedadeModificada(RO_ORIGEMPED, value);
            _origemped = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Pagtoantecipado
    {
        get
        {
            PropriedadeAcessada(RO_PAGTOANTECIPADO);
            return _pagtoantecipado;
        }
        set
        {
            PropriedadeModificada(RO_PAGTOANTECIPADO, value);
            _pagtoantecipado = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Pedduplicado
    {
        get
        {
            PropriedadeAcessada(RO_PEDDUPLICADO);
            return _pedduplicado;
        }
        set
        {
            PropriedadeModificada(RO_PEDDUPLICADO, value);
            _pedduplicado = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 8, Precisao = 0)]
    public string Pedidoembalado
    {
        get
        {
            PropriedadeAcessada(RO_PEDIDOEMBALADO);
            return _pedidoembalado;
        }
        set
        {
            PropriedadeModificada(RO_PEDIDOEMBALADO, value);
            _pedidoembalado = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 2)]
    public decimal? Percdescabc
    {
        get
        {
            PropriedadeAcessada(RO_PERCDESCABC);
            return _percdescabc;
        }
        set
        {
            PropriedadeModificada(RO_PERCDESCABC, value);
            _percdescabc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 2)]
    public decimal? Percdesccanal
    {
        get
        {
            PropriedadeAcessada(RO_PERCDESCCANAL);
            return _percdesccanal;
        }
        set
        {
            PropriedadeModificada(RO_PERCDESCCANAL, value);
            _percdesccanal = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 2)]
    public decimal? Percdesccli
    {
        get
        {
            PropriedadeAcessada(RO_PERCDESCCLI);
            return _percdesccli;
        }
        set
        {
            PropriedadeModificada(RO_PERCDESCCLI, value);
            _percdesccli = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 2)]
    public decimal? Percdescneg
    {
        get
        {
            PropriedadeAcessada(RO_PERCDESCNEG);
            return _percdescneg;
        }
        set
        {
            PropriedadeModificada(RO_PERCDESCNEG, value);
            _percdescneg = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 2)]
    public decimal? Percsaldoreservarca
    {
        get
        {
            PropriedadeAcessada(RO_PERCSALDORESERVARCA);
            return _percsaldoreservarca;
        }
        set
        {
            PropriedadeModificada(RO_PERCSALDORESERVARCA, value);
            _percsaldoreservarca = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 2)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Perdesc
    {
        get
        {
            PropriedadeAcessada(RO_PERDESC);
            return _perdesc;
        }
        set
        {
            PropriedadeModificada(RO_PERDESC, value);
            _perdesc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Perdesclib
    {
        get
        {
            PropriedadeAcessada(RO_PERDESCLIB);
            return _perdesclib;
        }
        set
        {
            PropriedadeModificada(RO_PERDESCLIB, value);
            _perdesclib = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 10, Precisao = 0)]
    public string Placaveiculo
    {
        get
        {
            PropriedadeAcessada(RO_PLACAVEICULO);
            return _placaveiculo;
        }
        set
        {
            PropriedadeModificada(RO_PLACAVEICULO, value);
            _placaveiculo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Posicao
    {
        get
        {
            PropriedadeAcessada(RO_POSICAO);
            return _posicao;
        }
        set
        {
            PropriedadeModificada(RO_POSICAO, value);
            _posicao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Prazomedioplpag
    {
        get
        {
            PropriedadeAcessada(RO_PRAZOMEDIOPLPAG);
            return _prazomedioplpag;
        }
        set
        {
            PropriedadeModificada(RO_PRAZOMEDIOPLPAG, value);
            _prazomedioplpag = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Prontaentrega
    {
        get
        {
            PropriedadeAcessada(RO_PRONTAENTREGA);
            return _prontaentrega;
        }
        set
        {
            PropriedadeModificada(RO_PRONTAENTREGA, value);
            _prontaentrega = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
    public string Protocolonfp
    {
        get
        {
            PropriedadeAcessada(RO_PROTOCOLONFP);
            return _protocolonfp;
        }
        set
        {
            PropriedadeModificada(RO_PROTOCOLONFP, value);
            _protocolonfp = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Reservaestoquetv7
    {
        get
        {
            PropriedadeAcessada(RO_RESERVAESTOQUETV7);
            return _reservaestoquetv7;
        }
        set
        {
            PropriedadeModificada(RO_RESERVAESTOQUETV7, value);
            _reservaestoquetv7 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Restricaotransp
    {
        get
        {
            PropriedadeAcessada(RO_RESTRICAOTRANSP);
            return _restricaotransp;
        }
        set
        {
            PropriedadeModificada(RO_RESTRICAOTRANSP, value);
            _restricaotransp = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Restricaotransporte
    {
        get
        {
            PropriedadeAcessada(RO_RESTRICAOTRANSPORTE);
            return _restricaotransporte;
        }
        set
        {
            PropriedadeModificada(RO_RESTRICAOTRANSPORTE, value);
            _restricaotransporte = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
    public string Rotina
    {
        get
        {
            PropriedadeAcessada(RO_ROTINA);
            return _rotina;
        }
        set
        {
            PropriedadeModificada(RO_ROTINA, value);
            _rotina = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 48, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 48, Precisao = 0)]
    public string Rotinalancultalt
    {
        get
        {
            PropriedadeAcessada(RO_ROTINALANCULTALT);
            return _rotinalancultalt;
        }
        set
        {
            PropriedadeModificada(RO_ROTINALANCULTALT, value);
            _rotinalancultalt = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 3, Precisao = 0)]
    public string Seriemanif
    {
        get
        {
            PropriedadeAcessada(RO_SERIEMANIF);
            return _seriemanif;
        }
        set
        {
            PropriedadeModificada(RO_SERIEMANIF, value);
            _seriemanif = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
    public string Softnumlanc
    {
        get
        {
            PropriedadeAcessada(RO_SOFTNUMLANC);
            return _softnumlanc;
        }
        set
        {
            PropriedadeModificada(RO_SOFTNUMLANC, value);
            _softnumlanc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Tipocarga
    {
        get
        {
            PropriedadeAcessada(RO_TIPOCARGA);
            return _tipocarga;
        }
        set
        {
            PropriedadeModificada(RO_TIPOCARGA, value);
            _tipocarga = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Tipocfoptv4
    {
        get
        {
            PropriedadeAcessada(RO_TIPOCFOPTV4);
            return _tipocfoptv4;
        }
        set
        {
            PropriedadeModificada(RO_TIPOCFOPTV4, value);
            _tipocfoptv4 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Tipodocumento
    {
        get
        {
            PropriedadeAcessada(RO_TIPODOCUMENTO);
            return _tipodocumento;
        }
        set
        {
            PropriedadeModificada(RO_TIPODOCUMENTO, value);
            _tipodocumento = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Tipoembalagem
    {
        get
        {
            PropriedadeAcessada(RO_TIPOEMBALAGEM);
            return _tipoembalagem;
        }
        set
        {
            PropriedadeModificada(RO_TIPOEMBALAGEM, value);
            _tipoembalagem = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Tipoformularionf
    {
        get
        {
            PropriedadeAcessada(RO_TIPOFORMULARIONF);
            return _tipoformularionf;
        }
        set
        {
            PropriedadeModificada(RO_TIPOFORMULARIONF, value);
            _tipoformularionf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Tipofv
    {
        get
        {
            PropriedadeAcessada(RO_TIPOFV);
            return _tipofv;
        }
        set
        {
            PropriedadeModificada(RO_TIPOFV, value);
            _tipofv = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Tipomovccrca
    {
        get
        {
            PropriedadeAcessada(RO_TIPOMOVCCRCA);
            return _tipomovccrca;
        }
        set
        {
            PropriedadeModificada(RO_TIPOMOVCCRCA, value);
            _tipomovccrca = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Tipooper
    {
        get
        {
            PropriedadeAcessada(RO_TIPOOPER);
            return _tipooper;
        }
        set
        {
            PropriedadeModificada(RO_TIPOOPER, value);
            _tipooper = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Tipoprioridadeentrega
    {
        get
        {
            PropriedadeAcessada(RO_TIPOPRIORIDADEENTREGA);
            return _tipoprioridadeentrega;
        }
        set
        {
            PropriedadeModificada(RO_TIPOPRIORIDADEENTREGA, value);
            _tipoprioridadeentrega = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Tiporetirada
    {
        get
        {
            PropriedadeAcessada(RO_TIPORETIRADA);
            return _tiporetirada;
        }
        set
        {
            PropriedadeModificada(RO_TIPORETIRADA, value);
            _tiporetirada = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Tributaporregiaofilial
    {
        get
        {
            PropriedadeAcessada(RO_TRIBUTAPORREGIAOFILIAL);
            return _tributaporregiaofilial;
        }
        set
        {
            PropriedadeModificada(RO_TRIBUTAPORREGIAOFILIAL, value);
            _tributaporregiaofilial = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Trocaaltdebcredrca
    {
        get
        {
            PropriedadeAcessada(RO_TROCAALTDEBCREDRCA);
            return _trocaaltdebcredrca;
        }
        set
        {
            PropriedadeModificada(RO_TROCAALTDEBCREDRCA, value);
            _trocaaltdebcredrca = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Ufveiculo
    {
        get
        {
            PropriedadeAcessada(RO_UFVEICULO);
            return _ufveiculo;
        }
        set
        {
            PropriedadeModificada(RO_UFVEICULO, value);
            _ufveiculo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Usacfopvendanatv10
    {
        get
        {
            PropriedadeAcessada(RO_USACFOPVENDANATV10);
            return _usacfopvendanatv10;
        }
        set
        {
            PropriedadeModificada(RO_USACFOPVENDANATV10, value);
            _usacfopvendanatv10 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Usacredrca
    {
        get
        {
            PropriedadeAcessada(RO_USACREDRCA);
            return _usacredrca;
        }
        set
        {
            PropriedadeModificada(RO_USACREDRCA, value);
            _usacredrca = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Usadebcredrca
    {
        get
        {
            PropriedadeAcessada(RO_USADEBCREDRCA);
            return _usadebcredrca;
        }
        set
        {
            PropriedadeModificada(RO_USADEBCREDRCA, value);
            _usadebcredrca = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Usasaldocontacorrentedescfin
    {
        get
        {
            PropriedadeAcessada(RO_USASALDOCONTACORRENTEDESCFIN);
            return _usasaldocontacorrentedescfin;
        }
        set
        {
            PropriedadeModificada(RO_USASALDOCONTACORRENTEDESCFIN, value);
            _usasaldocontacorrentedescfin = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 3)]
    public decimal? Valordescfin
    {
        get
        {
            PropriedadeAcessada(RO_VALORDESCFIN);
            return _valordescfin;
        }
        set
        {
            PropriedadeModificada(RO_VALORDESCFIN, value);
            _valordescfin = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Vendaassistiva
    {
        get
        {
            PropriedadeAcessada(RO_VENDAASSISTIVA);
            return _vendaassistiva;
        }
        set
        {
            PropriedadeModificada(RO_VENDAASSISTIVA, value);
            _vendaassistiva = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
    public string Versaorotina
    {
        get
        {
            PropriedadeAcessada(RO_VERSAOROTINA);
            return _versaorotina;
        }
        set
        {
            PropriedadeModificada(RO_VERSAOROTINA, value);
            _versaorotina = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
    public string Versaofaturamento
    {
        get
        {
            PropriedadeAcessada(RO_VERSAOFATURAMENTO);
            return _versaofaturamento;
        }
        set
        {
            PropriedadeModificada(RO_VERSAOFATURAMENTO, value);
            _versaofaturamento = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 16, Precisao = 3)]
    public decimal? Vlatend
    {
        get
        {
            PropriedadeAcessada(RO_VLATEND);
            return _vlatend;
        }
        set
        {
            PropriedadeModificada(RO_VLATEND, value);
            _vlatend = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 16, Precisao = 3)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 2)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 2)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 2)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 2)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 2)]
    public decimal? Vldescneg
    {
        get
        {
            PropriedadeAcessada(RO_VLDESCNEG);
            return _vldescneg;
        }
        set
        {
            PropriedadeModificada(RO_VLDESCNEG, value);
            _vldescneg = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 16, Precisao = 3)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 16, Precisao = 3)]
    public decimal? Vlentrada
    {
        get
        {
            PropriedadeAcessada(RO_VLENTRADA);
            return _vlentrada;
        }
        set
        {
            PropriedadeModificada(RO_VLENTRADA, value);
            _vlentrada = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 16, Precisao = 3)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 2)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 2)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 2)]
    public decimal? Vlicmsfretenf
    {
        get
        {
            PropriedadeAcessada(RO_VLICMSFRETENF);
            return _vlicmsfretenf;
        }
        set
        {
            PropriedadeModificada(RO_VLICMSFRETENF, value);
            _vlicmsfretenf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 16, Precisao = 3)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 2)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 16, Precisao = 3)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 16, Precisao = 3)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 15, Precisao = 0)]
    public string Nsusociotorcedor
    {
        get
        {
            PropriedadeAcessada(RO_NSUSOCIOTORCEDOR);
            return _nsusociotorcedor;
        }
        set
        {
            PropriedadeModificada(RO_NSUSOCIOTORCEDOR, value);
            _nsusociotorcedor = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 2)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 2)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 400, Precisao = 0)]
    public string Chavenfce
    {
        get
        {
            PropriedadeAcessada(RO_CHAVENFCE);
            return _chavenfce;
        }
        set
        {
            PropriedadeModificada(RO_CHAVENFCE, value);
            _chavenfce = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 16, Precisao = 0)]
    public string Protocolonfce
    {
        get
        {
            PropriedadeAcessada(RO_PROTOCOLONFCE);
            return _protocolonfce;
        }
        set
        {
            PropriedadeModificada(RO_PROTOCOLONFCE, value);
            _protocolonfce = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Fretedespacho
    {
        get
        {
            PropriedadeAcessada("Fretedespacho");
            return _fretedespacho;
        }
        set
        {
            PropriedadeModificada("Fretedespacho", value);
            _fretedespacho = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 15, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 100, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 15, Precisao = 0)]
    public string Iefrete
    {
        get
        {
            PropriedadeAcessada("Iefrete");
            return _iefrete;
        }
        set
        {
            PropriedadeModificada("Iefrete", value);
            _iefrete = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Uffrete
    {
        get
        {
            PropriedadeAcessada("Uffrete");
            return _uffrete;
        }
        set
        {
            PropriedadeModificada("Uffrete", value);
            _uffrete = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 18, Precisao = 0)]
    public string Cgcfrete
    {
        get
        {
            PropriedadeAcessada("Cgcfrete");
            return _cgcfrete;
        }
        set
        {
            PropriedadeModificada("Cgcfrete", value);
            _cgcfrete = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 16, Precisao = 3)]
    public decimal? Vljurosparcelamento
    {
        get
        {
            PropriedadeAcessada(RO_VLJUROSPARCELAMENTO);
            return _vljurosparcelamento;
        }
        set
        {
            PropriedadeModificada(RO_VLJUROSPARCELAMENTO, value);
            _vljurosparcelamento = value;
        }
    }

    public void InicializarAtributos()
    {
    }

    public string ObterNomeTabela()
    {
        return "PCPEDC";
    }

    public IEntidade NovaInstancia()
    {
        return (IEntidade)GetType().GetConstructors()[0].Invoke(null);
    }

    public void CarregarPorDataReader(IDataReader leitor)
    {
        _agrupamento = AlterarTipo<string>(leitor["Agrupamento"]);
        _aliqicmsfretenf = AlterarTipo<decimal?>(leitor["Aliqicmsfretenf"]);
        _altaposmapasep = AlterarTipo<string>(leitor["Altaposmapasep"]);
        _baixaestcli = AlterarTipo<string>(leitor["Baixaestcli"]);
        _baseicmsfretenf = AlterarTipo<decimal?>(leitor["Baseicmsfretenf"]);
        _bloqcomercial = AlterarTipo<string>(leitor["Bloqcomercial"]);
        _bloqfinanceiro = AlterarTipo<string>(leitor["Bloqfinanceiro"]);
        _bloqueioedicao = AlterarTipo<string>(leitor["Bloqueioedicao"]);
        _bloqueiosaldoccdescfin = AlterarTipo<string>(leitor["Bloqueiosaldoccdescfin"]);
        _bonificaltdebcredrca = AlterarTipo<string>(leitor["Bonificaltdebcredrca"]);
        _brinde = AlterarTipo<string>(leitor["Brinde"]);
        _broker = AlterarTipo<string>(leitor["Broker"]);
        _brokeraltdebcredrca = AlterarTipo<string>(leitor["Brokeraltdebcredrca"]);
        _campanha = AlterarTipo<string>(leitor["Campanha"]);
        _cfopbnfdegusta = AlterarTipo<decimal?>(leitor["Cfopbnfdegusta"]);
        _codadmcartao = AlterarTipo<string>(leitor["Codadmcartao"]);
        _codatendimento = AlterarTipo<decimal?>(leitor["Codatendimento"]);
        _codautorizacaotef = AlterarTipo<decimal?>(leitor["Codautorizacaotef"]);
        _codautorizacaotefweb = AlterarTipo<string>(leitor["Codautorizacaotefweb"]);
        _codbnf = AlterarTipo<decimal?>(leitor["Codbnf"]);
        _codcli = AlterarTipo<decimal>(leitor["Codcli"]);
        _codcliconsignacao = AlterarTipo<decimal?>(leitor["Codcliconsignacao"]);
        _codclinf = AlterarTipo<decimal?>(leitor["Codclinf"]);
        _codclirecebedor = AlterarTipo<decimal?>(leitor["Codclirecebedor"]);
        _codclitv8 = AlterarTipo<decimal?>(leitor["Codclitv8"]);
        _codcob = AlterarTipo<string>(leitor["Codcob"]);
        _codcondicaovenda = AlterarTipo<decimal?>(leitor["Codcondicaovenda"]);
        _codcontrato = AlterarTipo<decimal?>(leitor["Codcontrato"]);
        _coddistrib = AlterarTipo<string>(leitor["Coddistrib"]);
        _codemitente = AlterarTipo<decimal?>(leitor["Codemitente"]);
        _codendent = AlterarTipo<decimal?>(leitor["Codendent"]);
        _codepto = AlterarTipo<decimal?>(leitor["Codepto"]);
        _codestabelecimento = AlterarTipo<string>(leitor["Codestabelecimento"]);
        _codfilial = AlterarTipo<string>(leitor["Codfilial"]);
        _codfilialnf = AlterarTipo<string>(leitor["Codfilialnf"]);
        _codfornecbonific = AlterarTipo<decimal?>(leitor["Codfornecbonific"]);
        _codfornecfrete = AlterarTipo<decimal?>(leitor["Codfornecfrete"]);
        _codfornecredespacho = AlterarTipo<decimal?>(leitor["Codfornecredespacho"]);
        _codfornecvdireto = AlterarTipo<decimal?>(leitor["Codfornecvdireto"]);
        _codfunccalcfrete = AlterarTipo<decimal?>(leitor["Codfunccalcfrete"]);
        _codfunccancel = AlterarTipo<decimal?>(leitor["Codfunccancel"]);
        _codfuncconf = AlterarTipo<decimal?>(leitor["Codfuncconf"]);
        _codfuncconfgarantia = AlterarTipo<decimal?>(leitor["Codfuncconfgarantia"]);
        _codfunccx = AlterarTipo<decimal?>(leitor["Codfunccx"]);
        _codfuncembalador = AlterarTipo<decimal?>(leitor["Codfuncembalador"]);
        _codfuncemissaomapa = AlterarTipo<decimal?>(leitor["Codfuncemissaomapa"]);
        _codfuncexparqol = AlterarTipo<decimal?>(leitor["Codfuncexparqol"]);
        _codfuncexpintwms = AlterarTipo<decimal?>(leitor["Codfuncexpintwms"]);
        _codfuncimpintwms = AlterarTipo<decimal?>(leitor["Codfuncimpintwms"]);
        _codfunclibdesc = AlterarTipo<decimal?>(leitor["Codfunclibdesc"]);
        _codfunclibera = AlterarTipo<decimal?>(leitor["Codfunclibera"]);
        _codfunclibera2 = AlterarTipo<decimal?>(leitor["Codfunclibera2"]);
        _codfuncprotocolo = AlterarTipo<decimal?>(leitor["Codfuncprotocolo"]);
        _codfuncsep = AlterarTipo<decimal?>(leitor["Codfuncsep"]);
        _codigosazonalidade = AlterarTipo<decimal?>(leitor["Codigosazonalidade"]);
        _codmotbloqueio = AlterarTipo<decimal?>(leitor["Codmotbloqueio"]);
        _codmotcancel = AlterarTipo<decimal?>(leitor["Codmotcancel"]);
        _codmotivo = AlterarTipo<decimal?>(leitor["Codmotivo"]);
        _codmotivo2 = AlterarTipo<decimal?>(leitor["Codmotivo2"]);
        _codmotorista = AlterarTipo<decimal?>(leitor["Codmotorista"]);
        _codplpag = AlterarTipo<decimal>(leitor["Codplpag"]);
        _codplpagetico = AlterarTipo<decimal?>(leitor["Codplpagetico"]);
        _codplpaggenerico = AlterarTipo<decimal?>(leitor["Codplpaggenerico"]);
        _codpostagem = AlterarTipo<string>(leitor["Codpostagem"]);
        _codpraca = AlterarTipo<decimal>(leitor["Codpraca"]);
        _codpracadestino = AlterarTipo<decimal?>(leitor["Codpracadestino"]);
        _codprofissional = AlterarTipo<decimal?>(leitor["Codprofissional"]);
        _codsupervisor = AlterarTipo<decimal>(leitor["Codsupervisor"]);
        _codsupervisor2 = AlterarTipo<decimal?>(leitor["Codsupervisor2"]);
        _codsupervisor3 = AlterarTipo<decimal?>(leitor["Codsupervisor3"]);
        _codtransp = AlterarTipo<decimal?>(leitor["Codtransp"]);
        _codunidadeexecutora = AlterarTipo<string>(leitor["Codunidadeexecutora"]);
        _codusur = AlterarTipo<decimal>(leitor["Codusur"]);
        _codusur2 = AlterarTipo<decimal?>(leitor["Codusur2"]);
        _codusur3 = AlterarTipo<decimal?>(leitor["Codusur3"]);
        _codusur4 = AlterarTipo<decimal?>(leitor["Codusur4"]);
        _codveiculo = AlterarTipo<string>(leitor["Codveiculo"]);
        _codvisita = AlterarTipo<decimal?>(leitor["Codvisita"]);
        _conciliaimportacao = AlterarTipo<string>(leitor["Conciliaimportacao"]);
        _condvenda = AlterarTipo<decimal?>(leitor["Condvenda"]);
        _conferindopedido = AlterarTipo<string>(leitor["Conferindopedido"]);
        _contaordem = AlterarTipo<string>(leitor["Contaordem"]);
        _crmaltdebcredrca = AlterarTipo<string>(leitor["Crmaltdebcredrca"]);
        _custobonificacao = AlterarTipo<string>(leitor["Custobonificacao"]);
        _custoentrega = AlterarTipo<decimal?>(leitor["Custoentrega"]);
        _data = AlterarTipo<DateTime>(leitor["Data"]);
        _dataempenho = AlterarTipo<DateTime?>(leitor["Dataempenho"]);
        _dataexparqol = AlterarTipo<DateTime?>(leitor["Dataexparqol"]);
        _datapedcli = AlterarTipo<DateTime?>(leitor["Datapedcli"]);
        _dataprotocolo = AlterarTipo<DateTime?>(leitor["Dataprotocolo"]);
        _dtaberturapedpalm = AlterarTipo<DateTime?>(leitor["Dtaberturapedpalm"]);
        _dtagendaentrega = AlterarTipo<DateTime?>(leitor["Dtagendaentrega"]);
        _dtcalcfrete = AlterarTipo<DateTime?>(leitor["Dtcalcfrete"]);
        _dtcancel = AlterarTipo<DateTime?>(leitor["Dtcancel"]);
        _dtchegadacliente = AlterarTipo<DateTime?>(leitor["Dtchegadacliente"]);
        _dtconfgarantia = AlterarTipo<DateTime?>(leitor["Dtconfgarantia"]);
        _dtemissaomapa = AlterarTipo<DateTime?>(leitor["Dtemissaomapa"]);
        _dtentrega = AlterarTipo<DateTime?>(leitor["Dtentrega"]);
        _dtexportacao = AlterarTipo<DateTime?>(leitor["Dtexportacao"]);
        _dtexportacaoservint = AlterarTipo<DateTime?>(leitor["Dtexportacaoservint"]);
        _dtexportacaowms = AlterarTipo<DateTime?>(leitor["Dtexportacaowms"]);
        _dtexportado = AlterarTipo<DateTime?>(leitor["Dtexportado"]);
        _dtfat = AlterarTipo<DateTime?>(leitor["Dtfat"]);
        _dtfechamentopedpalm = AlterarTipo<DateTime?>(leitor["Dtfechamentopedpalm"]);
        _dtfimdigitacaopedido = AlterarTipo<DateTime?>(leitor["Dtfimdigitacaopedido"]);
        _dtfinalcheckout = AlterarTipo<DateTime?>(leitor["Dtfinalcheckout"]);
        _dtfinalpend = AlterarTipo<DateTime?>(leitor["Dtfinalpend"]);
        _dtfinalsep = AlterarTipo<DateTime?>(leitor["Dtfinalsep"]);
        _dtimportacao = AlterarTipo<DateTime?>(leitor["Dtimportacao"]);
        _dtimportacaoservprinc = AlterarTipo<DateTime?>(leitor["Dtimportacaoservprinc"]);
        _dtimportacaowms = AlterarTipo<DateTime?>(leitor["Dtimportacaowms"]);
        _dtimportado = AlterarTipo<DateTime?>(leitor["Dtimportado"]);
        _dtinicialcheckout = AlterarTipo<DateTime?>(leitor["Dtinicialcheckout"]);
        _dtinicialpend = AlterarTipo<DateTime?>(leitor["Dtinicialpend"]);
        _dtinicialsep = AlterarTipo<DateTime?>(leitor["Dtinicialsep"]);
        _dtiniciodigitacaopedido = AlterarTipo<DateTime?>(leitor["Dtiniciodigitacaopedido"]);
        _dtlibera = AlterarTipo<DateTime?>(leitor["Dtlibera"]);
        _dtlibera2 = AlterarTipo<DateTime?>(leitor["Dtlibera2"]);
        _dtlimitefat = AlterarTipo<DateTime?>(leitor["Dtlimitefat"]);
        _dtnftransf = AlterarTipo<DateTime?>(leitor["Dtnftransf"]);
        _dtvalidade = AlterarTipo<DateTime?>(leitor["Dtvalidade"]);
        _dtvenc1 = AlterarTipo<DateTime?>(leitor["Dtvenc1"]);
        _dtvenc2 = AlterarTipo<DateTime?>(leitor["Dtvenc2"]);
        _dtvenc3 = AlterarTipo<DateTime?>(leitor["Dtvenc3"]);
        _dtwms = AlterarTipo<DateTime?>(leitor["Dtwms"]);
        _eancobranca = AlterarTipo<decimal?>(leitor["Eancobranca"]);
        _eancomprador = AlterarTipo<decimal?>(leitor["Eancomprador"]);
        _eanentrega = AlterarTipo<decimal?>(leitor["Eanentrega"]);
        _eanlocalentrega = AlterarTipo<decimal?>(leitor["Eanlocalentrega"]);
        _especiemanif = AlterarTipo<string>(leitor["Especiemanif"]);
        _especievolume = AlterarTipo<string>(leitor["Especievolume"]);
        _exportado = AlterarTipo<string>(leitor["Exportado"]);
        _exportadoservint = AlterarTipo<string>(leitor["Exportadoservint"]);
        _fornecentrega = AlterarTipo<string>(leitor["Fornecentrega"]);
        _fretedespacho = AlterarTipo<string>(leitor["Fretedespacho"]);
        _freteredespacho = AlterarTipo<string>(leitor["Freteredespacho"]);
        _geracp = AlterarTipo<string>(leitor["Geracp"]);
        _gerarcontroledeentrega = AlterarTipo<string>(leitor["Gerarcontroledeentrega"]);
        _gerardadosnfpaulista = AlterarTipo<string>(leitor["Gerardadosnfpaulista"]);
        _hora = AlterarTipo<decimal?>(leitor["Hora"]);
        _horaemissaomapa = AlterarTipo<decimal?>(leitor["Horaemissaomapa"]);
        _horafat = AlterarTipo<decimal?>(leitor["Horafat"]);
        _horafinalsep = AlterarTipo<decimal?>(leitor["Horafinalsep"]);
        _horainicialsep = AlterarTipo<decimal?>(leitor["Horainicialsep"]);
        _horalibera = AlterarTipo<decimal?>(leitor["Horalibera"]);
        _horaprotocolo = AlterarTipo<decimal?>(leitor["Horaprotocolo"]);
        _importacupom = AlterarTipo<decimal?>(leitor["Importacupom"]);
        _importado = AlterarTipo<string>(leitor["Importado"]);
        _importadoservprinc = AlterarTipo<string>(leitor["Importadoservprinc"]);
        _integradora = AlterarTipo<decimal?>(leitor["Integradora"]);
        _localdesembaraco = AlterarTipo<string>(leitor["Localdesembaraco"]);
        _localizacaopedido = AlterarTipo<string>(leitor["Localizacaopedido"]);
        _log = AlterarTipo<string>(leitor["Log"]);
        _log1 = AlterarTipo<string>(leitor["Log1"]);
        _log2 = AlterarTipo<string>(leitor["Log2"]);
        _log3 = AlterarTipo<string>(leitor["Log3"]);
        _log4 = AlterarTipo<string>(leitor["Log4"]);
        _marcavolume = AlterarTipo<string>(leitor["Marcavolume"]);
        _minuto = AlterarTipo<decimal?>(leitor["Minuto"]);
        _minutoemissaomapa = AlterarTipo<decimal?>(leitor["Minutoemissaomapa"]);
        _minutofat = AlterarTipo<decimal?>(leitor["Minutofat"]);
        _minutofinalsep = AlterarTipo<decimal?>(leitor["Minutofinalsep"]);
        _minutoinicialsep = AlterarTipo<decimal?>(leitor["Minutoinicialsep"]);
        _minutolibera = AlterarTipo<decimal?>(leitor["Minutolibera"]);
        _minutoprotocolo = AlterarTipo<decimal?>(leitor["Minutoprotocolo"]);
        _montando = AlterarTipo<string>(leitor["Montando"]);
        _motivoposicao = AlterarTipo<string>(leitor["Motivoposicao"]);
        _motoristaveiculo = AlterarTipo<string>(leitor["Motoristaveiculo"]);
        _negociado = AlterarTipo<string>(leitor["Negociado"]);
        _nomearquivofv = AlterarTipo<string>(leitor["Nomearquivofv"]);
        _nsutef = AlterarTipo<string>(leitor["Nsutef"]);
        _numcaixa = AlterarTipo<decimal?>(leitor["Numcaixa"]);
        _numcaixafiscal = AlterarTipo<decimal?>(leitor["Numcaixafiscal"]);
        _numcar = AlterarTipo<decimal>(leitor["Numcar"]);
        _numcaranterior = AlterarTipo<decimal?>(leitor["Numcaranterior"]);
        _numcaraux = AlterarTipo<decimal?>(leitor["Numcaraux"]);
        _numcarfab = AlterarTipo<decimal?>(leitor["Numcarfab"]);
        _numcarmanif = AlterarTipo<decimal?>(leitor["Numcarmanif"]);
        _numccf = AlterarTipo<decimal?>(leitor["Numccf"]);
        _numcoleta = AlterarTipo<string>(leitor["Numcoleta"]);
        _numcontratocorreio = AlterarTipo<decimal?>(leitor["Numcontratocorreio"]);
        _numcupom = AlterarTipo<decimal?>(leitor["Numcupom"]);
        _numecf = AlterarTipo<decimal?>(leitor["Numecf"]);
        _numempenho = AlterarTipo<string>(leitor["Numempenho"]);
        _numfonterecurso = AlterarTipo<string>(leitor["Numfonterecurso"]);
        _numitens = AlterarTipo<decimal?>(leitor["Numitens"]);
        _numlista = AlterarTipo<decimal?>(leitor["Numlista"]);
        _numloteintwms = AlterarTipo<decimal?>(leitor["Numloteintwms"]);
        _numnftransf = AlterarTipo<decimal?>(leitor["Numnftransf"]);
        _numnota = AlterarTipo<decimal?>(leitor["Numnota"]);
        _numnotaconsig = AlterarTipo<decimal?>(leitor["Numnotaconsig"]);
        _numnotamanif = AlterarTipo<decimal?>(leitor["Numnotamanif"]);
        _numnotatransfdep = AlterarTipo<decimal?>(leitor["Numnotatransfdep"]);
        _numorca = AlterarTipo<decimal?>(leitor["Numorca"]);
        _numorcafilial = AlterarTipo<decimal?>(leitor["Numorcafilial"]);
        _numorcaprinc = AlterarTipo<decimal?>(leitor["Numorcaprinc"]);
        _numordemcarga = AlterarTipo<decimal?>(leitor["Numordemcarga"]);
        _numped = AlterarTipo<decimal>(leitor["Numped"]);
        _numpedbnf = AlterarTipo<decimal?>(leitor["Numpedbnf"]);
        _numpedcli = AlterarTipo<string>(leitor["Numpedcli"]);
        _numpedecf = AlterarTipo<decimal?>(leitor["Numpedecf"]);
        _numpedentfut = AlterarTipo<decimal?>(leitor["Numpedentfut"]);
        _numpedorigem = AlterarTipo<decimal?>(leitor["Numpedorigem"]);
        _numpedorigemfrete = AlterarTipo<decimal?>(leitor["Numpedorigemfrete"]);
        _numpedrca = AlterarTipo<decimal?>(leitor["Numpedrca"]);
        _numpedtv1 = AlterarTipo<decimal?>(leitor["Numpedtv1"]);
        _numpedtv3 = AlterarTipo<decimal?>(leitor["Numpedtv3"]);
        _numpedvale = AlterarTipo<decimal?>(leitor["Numpedvale"]);
        _numpedweb = AlterarTipo<decimal?>(leitor["Numpedweb"]);
        _numpeso = AlterarTipo<decimal?>(leitor["Numpeso"]);
        _numprevenda = AlterarTipo<decimal?>(leitor["Numprevenda"]);
        _numprocesso = AlterarTipo<string>(leitor["Numprocesso"]);
        _numregiao = AlterarTipo<decimal?>(leitor["Numregiao"]);
        _numseqcorreio = AlterarTipo<decimal?>(leitor["Numseqcorreio"]);
        _numseqentr = AlterarTipo<decimal?>(leitor["Numseqentr"]);
        _numseqentrega = AlterarTipo<decimal?>(leitor["Numseqentrega"]);
        _numseqenvio = AlterarTipo<decimal?>(leitor["Numseqenvio"]);
        _numseqmontagem = AlterarTipo<decimal?>(leitor["Numseqmontagem"]);
        _numseqretorno1 = AlterarTipo<decimal?>(leitor["Numseqretorno1"]);
        _numseqretorno2 = AlterarTipo<decimal?>(leitor["Numseqretorno2"]);
        _numseqrota = AlterarTipo<decimal?>(leitor["Numseqrota"]);
        _numserieequip = AlterarTipo<string>(leitor["Numserieequip"]);
        _numtabela = AlterarTipo<string>(leitor["Numtabela"]);
        _numtransacaotransf = AlterarTipo<decimal?>(leitor["Numtransacaotransf"]);
        _numtransvenda = AlterarTipo<decimal?>(leitor["Numtransvenda"]);
        _numtranswms = AlterarTipo<decimal?>(leitor["Numtranswms"]);
        _numviasetiqueta = AlterarTipo<decimal?>(leitor["Numviasetiqueta"]);
        _numviasmapasep = AlterarTipo<decimal?>(leitor["Numviasmapasep"]);
        _numviaspedido = AlterarTipo<decimal?>(leitor["Numviaspedido"]);
        _numvolume = AlterarTipo<decimal?>(leitor["Numvolume"]);
        _numvolumeagrupado = AlterarTipo<decimal?>(leitor["Numvolumeagrupado"]);
        _obs = AlterarTipo<string>(leitor["Obs"]);
        _obsentrega1 = AlterarTipo<string>(leitor["Obsentrega1"]);
        _obsentrega2 = AlterarTipo<string>(leitor["Obsentrega2"]);
        _obsentrega3 = AlterarTipo<string>(leitor["Obsentrega3"]);
        _obsentrega4 = AlterarTipo<string>(leitor["Obsentrega4"]);
        _obsfretenf1 = AlterarTipo<string>(leitor["Obsfretenf1"]);
        _obsfretenf2 = AlterarTipo<string>(leitor["Obsfretenf2"]);
        _obsfretenf3 = AlterarTipo<string>(leitor["Obsfretenf3"]);
        _obs1 = AlterarTipo<string>(leitor["Obs1"]);
        _obs2 = AlterarTipo<string>(leitor["Obs2"]);
        _operacao = AlterarTipo<string>(leitor["Operacao"]);
        _origemped = AlterarTipo<string>(leitor["Origemped"]);
        _pagtoantecipado = AlterarTipo<string>(leitor["Pagtoantecipado"]);
        _pedduplicado = AlterarTipo<string>(leitor["Pedduplicado"]);
        _pedidoembalado = AlterarTipo<string>(leitor["Pedidoembalado"]);
        _perccomprofissional = AlterarTipo<decimal?>(leitor["Perccomprofissional"]);
        _percdescabc = AlterarTipo<decimal?>(leitor["Percdescabc"]);
        _percdesccanal = AlterarTipo<decimal?>(leitor["Percdesccanal"]);
        _percdesccli = AlterarTipo<decimal?>(leitor["Percdesccli"]);
        _percdescneg = AlterarTipo<decimal?>(leitor["Percdescneg"]);
        _percfrete = AlterarTipo<decimal?>(leitor["Percfrete"]);
        _percfreteretido = AlterarTipo<decimal?>(leitor["Percfreteretido"]);
        _percsaldoreservarca = AlterarTipo<decimal?>(leitor["Percsaldoreservarca"]);
        _percstfreteretido = AlterarTipo<decimal?>(leitor["Percstfreteretido"]);
        _percvenda = AlterarTipo<decimal?>(leitor["Percvenda"]);
        _perdesc = AlterarTipo<decimal?>(leitor["Perdesc"]);
        _perdescfin = AlterarTipo<decimal?>(leitor["Perdescfin"]);
        _perdesclib = AlterarTipo<decimal?>(leitor["Perdesclib"]);
        _placaveiculo = AlterarTipo<string>(leitor["Placaveiculo"]);
        _posicao = AlterarTipo<string>(leitor["Posicao"]);
        _prazoadicional = AlterarTipo<decimal?>(leitor["Prazoadicional"]);
        _prazomedio = AlterarTipo<decimal?>(leitor["Prazomedio"]);
        _prazomedioplpag = AlterarTipo<decimal?>(leitor["Prazomedioplpag"]);
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
        _prontaentrega = AlterarTipo<string>(leitor["Prontaentrega"]);
        _protocolonfp = AlterarTipo<string>(leitor["Protocolonfp"]);
        _recarga = AlterarTipo<string>(leitor["Recarga"]);
        _reservaestoquetv7 = AlterarTipo<string>(leitor["Reservaestoquetv7"]);
        _reservaritenstv7 = AlterarTipo<string>(leitor["Reservaritenstv7"]);
        _restricaotransp = AlterarTipo<string>(leitor["Restricaotransp"]);
        _restricaotransporte = AlterarTipo<string>(leitor["Restricaotransporte"]);
        _rotina = AlterarTipo<string>(leitor["Rotina"]);
        _rotinalanc = AlterarTipo<string>(leitor["Rotinalanc"]);
        _rotinalancultalt = AlterarTipo<string>(leitor["Rotinalancultalt"]);
        _serieecf = AlterarTipo<string>(leitor["Serieecf"]);
        _seriemanif = AlterarTipo<string>(leitor["Seriemanif"]);
        _softnumlanc = AlterarTipo<string>(leitor["Softnumlanc"]);
        _subserie = AlterarTipo<string>(leitor["Subserie"]);
        _tipocarga = AlterarTipo<string>(leitor["Tipocarga"]);
        _tipocfoptv4 = AlterarTipo<string>(leitor["Tipocfoptv4"]);
        _tipodocumento = AlterarTipo<string>(leitor["Tipodocumento"]);
        _tipoembalagem = AlterarTipo<string>(leitor["Tipoembalagem"]);
        _tipoformularionf = AlterarTipo<string>(leitor["Tipoformularionf"]);
        _tipofv = AlterarTipo<string>(leitor["Tipofv"]);
        _tipomovccrca = AlterarTipo<string>(leitor["Tipomovccrca"]);
        _tipooper = AlterarTipo<string>(leitor["Tipooper"]);
        _tipoprioridadeentrega = AlterarTipo<string>(leitor["Tipoprioridadeentrega"]);
        _tiporetirada = AlterarTipo<string>(leitor["Tiporetirada"]);
        _tipovenda = AlterarTipo<string>(leitor["Tipovenda"]);
        _totpeso = AlterarTipo<decimal?>(leitor["Totpeso"]);
        _totpesoagrupado = AlterarTipo<decimal?>(leitor["Totpesoagrupado"]);
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
        _tributaporregiaofilial = AlterarTipo<string>(leitor["Tributaporregiaofilial"]);
        _trocaaltdebcredrca = AlterarTipo<string>(leitor["Trocaaltdebcredrca"]);
        _ufdesembaraco = AlterarTipo<string>(leitor["Ufdesembaraco"]);
        _ufveiculo = AlterarTipo<string>(leitor["Ufveiculo"]);
        _usacfopvendanatv10 = AlterarTipo<string>(leitor["Usacfopvendanatv10"]);
        _usacredrca = AlterarTipo<string>(leitor["Usacredrca"]);
        _usadebcredrca = AlterarTipo<string>(leitor["Usadebcredrca"]);
        _usaintegracaowms = AlterarTipo<string>(leitor["Usaintegracaowms"]);
        _usasaldocontacorrentedescfin = AlterarTipo<string>(leitor["Usasaldocontacorrentedescfin"]);
        _valordescfin = AlterarTipo<decimal?>(leitor["Valordescfin"]);
        _vendaassistida = AlterarTipo<string>(leitor["Vendaassistida"]);
        _vendaassistiva = AlterarTipo<string>(leitor["Vendaassistiva"]);
        _vendatriangular = AlterarTipo<string>(leitor["Vendatriangular"]);
        _versaorotina = AlterarTipo<string>(leitor["Versaorotina"]);
        _versaofaturamento = AlterarTipo<string>(leitor["Versaofaturamento"]);
        _vlatend = AlterarTipo<decimal?>(leitor["Vlatend"]);
        _vlbonific = AlterarTipo<decimal?>(leitor["Vlbonific"]);
        _vlcustocont = AlterarTipo<decimal?>(leitor["Vlcustocont"]);
        _vlcustofin = AlterarTipo<decimal?>(leitor["Vlcustofin"]);
        _vlcustoreal = AlterarTipo<decimal?>(leitor["Vlcustoreal"]);
        _vlcustorep = AlterarTipo<decimal?>(leitor["Vlcustorep"]);
        _vldescabatimento = AlterarTipo<decimal?>(leitor["Vldescabatimento"]);
        _vldescneg = AlterarTipo<decimal?>(leitor["Vldescneg"]);
        _vldesconto = AlterarTipo<decimal?>(leitor["Vldesconto"]);
        _vlentrada = AlterarTipo<decimal?>(leitor["Vlentrada"]);
        _vlfrete = AlterarTipo<decimal?>(leitor["Vlfrete"]);
        _vlfretenf = AlterarTipo<decimal?>(leitor["Vlfretenf"]);
        _vlfreteretido = AlterarTipo<decimal?>(leitor["Vlfreteretido"]);
        _vlicmsfretenf = AlterarTipo<decimal?>(leitor["Vlicmsfretenf"]);
        _vloutrasdesp = AlterarTipo<decimal?>(leitor["Vloutrasdesp"]);
        _vlstfreteretido = AlterarTipo<decimal?>(leitor["Vlstfreteretido"]);
        _vltabela = AlterarTipo<decimal?>(leitor["Vltabela"]);
        _vltotal = AlterarTipo<decimal?>(leitor["Vltotal"]);
        _nsusociotorcedor = AlterarTipo<string>(leitor["Nsusociotorcedor"]);
        _vldescsociotorcedor = AlterarTipo<decimal?>(leitor["Vldescsociotorcedor"]);
        _vlsubtotal = AlterarTipo<decimal?>(leitor["Vlsubtotal"]);
        _docemissao = AlterarTipo<string>(leitor["Docemissao"]);
        _chavenfce = AlterarTipo<string>(leitor["Chavenfce"]);
        _numfechamentomovcx = AlterarTipo<decimal?>(leitor["Numfechamentomovcx"]);
        _dtmovimentocx = AlterarTipo<DateTime?>(leitor["Dtmovimentocx"]);
        _vendanfseried = AlterarTipo<string>(leitor["Vendanfseried"]);
        _protocolonfce = AlterarTipo<string>(leitor["Protocolonfce"]);
        _idparceiro = AlterarTipo<string>(leitor["Idparceiro"]);
        _uidregistro = AlterarTipo<decimal?>(leitor["Uidregistro"]);
        _assinatura = AlterarTipo<string>(leitor["Assinatura"]);
        _iefrete = AlterarTipo<string>(leitor["Iefrete"]);
        _uffrete = AlterarTipo<string>(leitor["Uffrete"]);
        _cgcfrete = AlterarTipo<string>(leitor["Cgcfrete"]);
        _transportadora = AlterarTipo<string>(leitor["Transportadora"]);
        _vljurosparcelamento = AlterarTipo<decimal?>(leitor["Vljurosparcelamento"]);
    }

}