

////// namespace nwErp.Entidades.Winthor;

// namespace nwErp.Api.Modelos;

[Serializable]
public class PCNFENT : GerenteDePropriedades, IEntidade
{
    private static readonly string RO_AGREGARSTPRODSINTEGRA = "Agregarstprodsintegra";

    private string _agregarstprodsintegra;

    private static readonly string RO_ALIQICMOUTRASDESP = "Aliqicmoutrasdesp";

    private decimal? _aliqicmoutrasdesp;

    private static readonly string RO_ALIQUOTA = "Aliquota";

    private decimal? _aliquota;

    private static readonly string RO_AMBIENTE = "Ambiente";

    private string _ambiente;

    private static readonly string RO_AMBIENTENFE = "Ambientenfe";

    private string _ambientenfe;

    private static readonly string RO_ATACADISTA = "Atacadista";

    private string _atacadista;

    private static readonly string RO_BAIRRO = "Bairro";

    private string _bairro;

    private static readonly string RO_BASEICST = "Baseicst";

    private decimal? _baseicst;

    private static readonly string RO_BLOQUEIOEDICAO = "Bloqueioedicao";

    private string _bloqueioedicao;

    private static readonly string RO_CALCBASEICMSALIQREDENTIMP = "Calcbaseicmsaliqredentimp";

    private string _calcbaseicmsaliqredentimp;

    private static readonly string RO_CALCCREDICMCUSTOCONT = "Calccredicmcustocont";

    private string _calccredicmcustocont;

    private static readonly string RO_CALCCREDICMS = "Calccredicms";

    private string _calccredicms;

    private static readonly string RO_CALCCREDPISCOFINS = "Calccredpiscofins";

    private string _calccredpiscofins;

    private static readonly string RO_CALCCREDPISCUSTOCONT = "Calccredpiscustocont";

    private string _calccredpiscustocont;

    private static readonly string RO_CALCDESCARGA = "Calcdescarga";

    private string _calcdescarga;

    private static readonly string RO_CALCDESPFINPRAZOPGTO = "Calcdespfinprazopgto";

    private string _calcdespfinprazopgto;

    private static readonly string RO_CEP = "Cep";

    private string _cep;

    private static readonly string RO_CGC = "Cgc";

    private string _cgc;

    private static readonly string RO_CGCFILIAL = "Cgcfilial";

    private string _cgcfilial;

    private static readonly string RO_CHAVECTE = "Chavecte";

    private string _chavecte;

    private static readonly string RO_CHAVENFE = "Chavenfe";

    private string _chavenfe;

    private static readonly string RO_CHAVENFEPRODRURAL = "Chavenfeprodrural";

    private string _chavenfeprodrural;

    private static readonly string RO_CODCONT = "Codcont";

    private decimal _codcont;

    private static readonly string RO_CODCONTABFORNEC = "Codcontabfornec";

    private decimal? _codcontabfornec;

    private static readonly string RO_CODCONTFOR = "Codcontfor";

    private decimal? _codcontfor;

    private static readonly string RO_CODCONTFRE = "Codcontfre";

    private decimal? _codcontfre;

    private static readonly string RO_CODDEVOL = "Coddevol";

    private decimal? _coddevol;

    private static readonly string RO_CODENTVEICULO = "Codentveiculo";

    private decimal? _codentveiculo;

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

    private static readonly string RO_CODFISCALOUTRASDESP = "Codfiscaloutrasdesp";

    private decimal? _codfiscaloutrasdesp;

    private static readonly string RO_CODFORFILIAL = "Codforfilial";

    private decimal? _codforfilial;

    private static readonly string RO_CODFORNEC = "Codfornec";

    private decimal _codfornec;

    private static readonly string RO_CODFORNECFRETE = "Codfornecfrete";

    private decimal? _codfornecfrete;

    private static readonly string RO_CODFORNECNF = "Codfornecnf";

    private decimal? _codfornecnf;

    private static readonly string RO_CODFUNCENVIO = "Codfuncenvio";

    private decimal? _codfuncenvio;

    private static readonly string RO_CODFUNCENVIOWMS = "Codfuncenviowms";

    private decimal? _codfuncenviowms;

    private static readonly string RO_CODFUNCEXPARQOL = "Codfuncexparqol";

    private decimal? _codfuncexparqol;

    private static readonly string RO_CODFUNCEXPINTWMS = "Codfuncexpintwms";

    private decimal? _codfuncexpintwms;

    private static readonly string RO_CODFUNCLANC = "Codfunclanc";

    private decimal? _codfunclanc;

    private static readonly string RO_CODIBGE = "Codibge";

    private decimal? _codibge;

    private static readonly string RO_CODIGOCLASSECONSUMOENERGIA = "Codigoclasseconsumoenergia";

    private string _codigoclasseconsumoenergia;

    private static readonly string RO_CODIGOGRUPOTENSAOENERGIA = "Codigogrupotensaoenergia";

    private string _codigogrupotensaoenergia;

    private static readonly string RO_CODMOTORISTADEVOL = "Codmotoristadevol";

    private decimal? _codmotoristadevol;

    private static readonly string RO_CODMUNICIPIO = "Codmunicipio";

    private decimal? _codmunicipio;

    private static readonly string RO_CODPAIS = "Codpais";

    private decimal? _codpais;

    private static readonly string RO_CODPROFISSIONAL = "Codprofissional";

    private decimal? _codprofissional;

    private static readonly string RO_CODRECEITARECOLHIM = "Codreceitarecolhim";

    private string _codreceitarecolhim;

    private static readonly string RO_CODROTINADESBLOQUEIO = "Codrotinadesbloqueio";

    private decimal? _codrotinadesbloqueio;

    private static readonly string RO_CODTRIBPISCOFINS = "Codtribpiscofins";

    private decimal? _codtribpiscofins;

    private static readonly string RO_CODUSURDEVOL = "Codusurdevol";

    private decimal? _codusurdevol;

    private static readonly string RO_CONCILIACAO = "Conciliacao";

    private string _conciliacao;

    private static readonly string RO_CONFERIDO = "Conferido";

    private string _conferido;

    private static readonly string RO_CONSIDERAIPINOFRETEFOB = "Consideraipinofretefob";

    private string _consideraipinofretefob;

    private static readonly string RO_CONSIDERARIIPUNIT = "Considerariipunit";

    private string _considerariipunit;

    private static readonly string RO_CONSSTNFPISCOFINS = "Consstnfpiscofins";

    private string _consstnfpiscofins;

    private static readonly string RO_CONSUMIDORFINAL = "Consumidorfinal";

    private string _consumidorfinal;

    private static readonly string RO_CONSUMIUNUMNFE = "Consumiunumnfe";

    private string _consumiunumnfe;

    private static readonly string RO_DATADIIMPORTACAO = "Datadiimportacao";

    private DateTime? _datadiimportacao;

    private static readonly string RO_DATAEXPARQOL = "Dataexparqol";

    private DateTime? _dataexparqol;

    private static readonly string RO_DEDFRETECIFCREDPRESICMS = "Dedfretecifcredpresicms";

    private string _dedfretecifcredpresicms;

    private static readonly string RO_DESCPAIS = "Descpais";

    private string _descpais;

    private static readonly string RO_DESPESASRATEADA = "Despesasrateada";

    private string _despesasrateada;

    private static readonly string RO_DEVSIMBOLICA = "Devsimbolica";

    private string _devsimbolica;

    private static readonly string RO_DTAHORAENTRADACONTIGENCIA = "Dtahoraentradacontigencia";

    private DateTime? _dtahoraentradacontigencia;

    private static readonly string RO_DTA_HORAENVIOSEFAZ = "Dta_Horaenviosefaz";

    private DateTime? _dta_horaenviosefaz;

    private static readonly string RO_DTCONCIL = "Dtconcil";

    private DateTime? _dtconcil;

    private static readonly string RO_DTDESCARGA = "Dtdescarga";

    private DateTime? _dtdescarga;

    private static readonly string RO_DTEMISSAO = "Dtemissao";

    private DateTime _dtemissao;

    private static readonly string RO_DTEMISSAODECLARACAO = "Dtemissaodeclaracao";

    private DateTime? _dtemissaodeclaracao;

    private static readonly string RO_DTEMISSAONFVENDA = "Dtemissaonfvenda";

    private DateTime? _dtemissaonfvenda;

    private static readonly string RO_DTEMISSAOPRODRURAL = "Dtemissaoprodrural";

    private DateTime? _dtemissaoprodrural;

    private static readonly string RO_DTENT = "Dtent";

    private DateTime _dtent;

    private static readonly string RO_DTENVIOWMS = "Dtenviowms";

    private DateTime? _dtenviowms;

    private static readonly string RO_DTEXPORTACAOWMS = "Dtexportacaowms";

    private DateTime? _dtexportacaowms;

    private static readonly string RO_DTHORAAUTORIZACAOSEFAZ = "Dthoraautorizacaosefaz";

    private DateTime? _dthoraautorizacaosefaz;

    private static readonly string RO_DTHORACANCELAMENTOSEFAZ = "Dthoracancelamentosefaz";

    private DateTime? _dthoracancelamentosefaz;

    private static readonly string RO_DTHORANFE = "Dthoranfe";

    private DateTime? _dthoranfe;

    private static readonly string RO_DTHORARECIBODPEC = "Dthorarecibodpec";

    private DateTime? _dthorarecibodpec;

    private static readonly string RO_DTIMPORTACAOWMS = "Dtimportacaowms";

    private DateTime? _dtimportacaowms;

    private static readonly string RO_DTLANCTO = "Dtlancto";

    private DateTime? _dtlancto;

    private static readonly string RO_DTNSU = "Dtnsu";

    private DateTime? _dtnsu;

    private static readonly string RO_DTPROXATU = "Dtproxatu";

    private DateTime? _dtproxatu;

    private static readonly string RO_DTSAIDA = "Dtsaida";

    private DateTime? _dtsaida;

    private static readonly string RO_DTSELOFISCAL = "Dtselofiscal";

    private DateTime? _dtselofiscal;

    private static readonly string RO_DTTERMINOCIAP = "Dtterminociap";

    private DateTime? _dtterminociap;

    private static readonly string RO_DTVENCSTFORANF = "Dtvencstforanf";

    private DateTime? _dtvencstforanf;

    private static readonly string RO_DTWMS = "Dtwms";

    private DateTime? _dtwms;

    private static readonly string RO_EMAILDEST = "Emaildest";

    private string _emaildest;

    private static readonly string RO_EMISSAOPROPRIA = "Emissaopropria";

    private string _emissaopropria;

    private static readonly string RO_ENDERECO = "Endereco";

    private string _endereco;

    private static readonly string RO_ENTRADATIPOI = "Entradatipoi";

    private string _entradatipoi;

    private static readonly string RO_ENVIADA = "Enviada";

    private string _enviada;

    private static readonly string RO_ENVIADANFE = "Enviadanfe";

    private string _enviadanfe;

    private static readonly string RO_ENVIADOEMAILCANCELADO = "Enviadoemailcancelado";

    private string _enviadoemailcancelado;

    private static readonly string RO_EQUIPLANC = "Equiplanc";

    private string _equiplanc;

    private static readonly string RO_ESPECIE = "Especie";

    private string _especie;

    private static readonly string RO_ESPECIEVOLUME = "Especievolume";

    private string _especievolume;

    private static readonly string RO_ESTCOMISSAORCA = "Estcomissaorca";

    private string _estcomissaorca;

    private static readonly string RO_EXPORTADO = "Exportado";

    private string _exportado;

    private static readonly string RO_FECHAMENTOCEAUTOMATICO = "Fechamentoceautomatico";

    private string _fechamentoceautomatico;

    private static readonly string RO_FINALIDADENFE = "Finalidadenfe";

    private string _finalidadenfe;

    private static readonly string RO_FOLHALIVRO_ENTRADA = "Folhalivro_Entrada";

    private decimal? _folhalivro_entrada;

    private static readonly string RO_FORNECEDOR = "Fornecedor";

    private string _fornecedor;

    private static readonly string RO_FUNCLANC = "Funclanc";

    private string _funclanc;

    private static readonly string RO_GERANFDEVCLI = "Geranfdevcli";

    private string _geranfdevcli;

    private static readonly string RO_GERANFVENDA = "Geranfvenda";

    private string _geranfvenda;

    private static readonly string RO_HISTORICO = "Historico";

    private string _historico;

    private static readonly string RO_HORALANC = "Horalanc";

    private string _horalanc;

    private static readonly string RO_IE = "Ie";

    private string _ie;

    private static readonly string RO_IEFILIAL = "Iefilial";

    private string _iefilial;

    private static readonly string RO_IESUBSTTRIBUT = "Iesubsttribut";

    private string _iesubsttribut;

    private static readonly string RO_INCLUIRIMPOSTOSNFTRANSPIMP = "Incluirimpostosnftranspimp";

    private string _incluirimpostosnftranspimp;

    private static readonly string RO_INDUSTRIALOCAL = "Industrialocal";

    private string _industrialocal;

    private static readonly string RO_JUSTIFICATIVACONTIGENCIA = "Justificativacontigencia";

    private string _justificativacontigencia;

    private static readonly string RO_LOCALDESEMBARACO = "Localdesembaraco";

    private string _localdesembaraco;

    private static readonly string RO_LOTEDIGITADO = "Lotedigitado";

    private string _lotedigitado;

    private static readonly string RO_LOTEDPEC = "Lotedpec";

    private string _lotedpec;

    private static readonly string RO_MARCAVOLUME = "Marcavolume";

    private string _marcavolume;

    private static readonly string RO_MINUTOLANC = "Minutolanc";

    private string _minutolanc;

    private static readonly string RO_MODELO = "Modelo";

    private string _modelo;

    private static readonly string RO_MODELOPRODRURAL = "Modeloprodrural";

    private string _modeloprodrural;

    private static readonly string RO_MOTESTORNONFE = "Motestornonfe";

    private string _motestornonfe;

    private static readonly string RO_MOVESTOQUEIMPORT = "Movestoqueimport";

    private string _movestoqueimport;

    private static readonly string RO_MUNICIPIO = "Municipio";

    private string _municipio;

    private static readonly string RO_NATOPERNFE = "Natopernfe";

    private string _natopernfe;

    private static readonly string RO_NFENTREGAFUTURA = "Nfentregafutura";

    private string _nfentregafutura;

    private static readonly string RO_NFEXTEMPORANEA = "Nfextemporanea";

    private string _nfextemporanea;

    private static readonly string RO_NORMAREGESPECIAL = "Normaregespecial";

    private string _normaregespecial;

    private static readonly string RO_NSU = "Nsu";

    private decimal? _nsu;

    private static readonly string RO_NUMAPLIC = "Numaplic";

    private decimal? _numaplic;

    private static readonly string RO_NUMBONUS = "Numbonus";

    private decimal? _numbonus;

    private static readonly string RO_NUMCONTRATO = "Numcontrato";

    private decimal? _numcontrato;

    private static readonly string RO_NUMDIIMPORTACAO = "Numdiimportacao";

    private string _numdiimportacao;

    private static readonly string RO_NUMENTMEX = "Numentmex";

    private decimal? _numentmex;

    private static readonly string RO_NUMEROEND = "Numeroend";

    private string _numeroend;

    private static readonly string RO_NUMFORMULARIO = "Numformulario";

    private decimal? _numformulario;

    private static readonly string RO_NUMIDF = "Numidf";

    private string _numidf;

    private static readonly string RO_NUMLIVRO_ENTRADA = "Numlivro_Entrada";

    private string _numlivro_entrada;

    private static readonly string RO_NUMLOTENFE = "Numlotenfe";

    private string _numlotenfe;

    private static readonly string RO_NUMNEGOCIACAO = "Numnegociacao";

    private decimal? _numnegociacao;

    private static readonly string RO_NUMNOTA = "Numnota";

    private decimal _numnota;

    private static readonly string RO_NUMNOTAENTFUTURA = "Numnotaentfutura";

    private decimal? _numnotaentfutura;

    private static readonly string RO_NUMNOTAPRODRURAL = "Numnotaprodrural";

    private decimal? _numnotaprodrural;

    private static readonly string RO_NUMNOTAVENDA = "Numnotavenda";

    private decimal? _numnotavenda;

    private static readonly string RO_NUMOP = "Numop";

    private decimal? _numop;

    private static readonly string RO_NUMOS = "Numos";

    private decimal? _numos;

    private static readonly string RO_NUMPARCDEVOL = "Numparcdevol";

    private decimal? _numparcdevol;

    private static readonly string RO_NUMSELONF = "Numselonf";

    private decimal? _numselonf;

    private static readonly string RO_NUMSEQENVIO = "Numseqenvio";

    private decimal? _numseqenvio;

    private static readonly string RO_NUMTAB = "Numtab";

    private decimal? _numtab;

    private static readonly string RO_NUMTRANSBENEFIC = "Numtransbenefic";

    private decimal? _numtransbenefic;

    private static readonly string RO_NUMTRANSENT = "Numtransent";

    private decimal _numtransent;

    private static readonly string RO_NUMTRANSORIGEM = "Numtransorigem";

    private decimal? _numtransorigem;

    private static readonly string RO_NUMTRANSVENDAORIG = "Numtransvendaorig";

    private decimal? _numtransvendaorig;

    private static readonly string RO_NUMTRANSVENDATROCA = "Numtransvendatroca";

    private decimal? _numtransvendatroca;

    private static readonly string RO_NUMVIAS = "Numvias";

    private decimal? _numvias;

    private static readonly string RO_NUMVOL = "Numvol";

    private decimal? _numvol;

    private static readonly string RO_NUMVOLUME = "Numvolume";

    private string _numvolume;

    private static readonly string RO_OBS = "Obs";

    private string _obs;

    private static readonly string RO_OBSLIVROFISCAL = "Obslivrofiscal";

    private string _obslivrofiscal;

    private static readonly string RO_OBSNFE = "Obsnfe";

    private string _obsnfe;

    private static readonly string RO_OBSPISCOFINS = "Obspiscofins";

    private string _obspiscofins;

    private static readonly string RO_OBS1 = "Obs1";

    private string _obs1;

    private static readonly string RO_OBS2 = "Obs2";

    private string _obs2;

    private static readonly string RO_PERBASEREDOUTRASDESP = "Perbaseredoutrasdesp";

    private decimal? _perbaseredoutrasdesp;

    private static readonly string RO_PERCALTERCUSTOENT = "Percaltercustoent";

    private decimal? _percaltercustoent;

    private static readonly string RO_PERCICMFRETE = "Percicmfrete";

    private decimal? _percicmfrete;

    private static readonly string RO_PERCICMSFRETEFOBST = "Percicmsfretefobst";

    private decimal? _percicmsfretefobst;

    private static readonly string RO_PERCOFINS = "Percofins";

    private decimal? _percofins;

    private static readonly string RO_PERCPISRED = "Percpisred";

    private decimal? _percpisred;

    private static readonly string RO_PERDESCFIN = "Perdescfin";

    private decimal? _perdescfin;

    private static readonly string RO_PERPIS = "Perpis";

    private decimal? _perpis;

    private static readonly string RO_PESOFRETEFOB = "Pesofretefob";

    private decimal? _pesofretefob;

    private static readonly string RO_PLACAVEICULO = "Placaveiculo";

    private string _placaveiculo;

    private static readonly string RO_POSSECODFORNEC = "Possecodfornec";

    private decimal? _possecodfornec;

    private static readonly string RO_PRAZO = "Prazo";

    private decimal? _prazo;

    private static readonly string RO_PROTOCOLOCANCELAMENTO = "Protocolocancelamento";

    private string _protocolocancelamento;

    private static readonly string RO_PROTOCOLONFE = "Protocolonfe";

    private string _protocolonfe;

    private static readonly string RO_PROTOCOLONFEAUTO = "Protocolonfeauto";

    private string _protocolonfeauto;

    private static readonly string RO_PROTOCOLONFECAN = "Protocolonfecan";

    private string _protocolonfecan;

    private static readonly string RO_RATEIOPESOLIQ = "Rateiopesoliq";

    private string _rateiopesoliq;

    private static readonly string RO_REBAIXACUSTOCOMDESCFIN = "Rebaixacustocomdescfin";

    private string _rebaixacustocomdescfin;

    private static readonly string RO_RECIBODPEC = "Recibodpec";

    private string _recibodpec;

    private static readonly string RO_RECIBONFE = "Recibonfe";

    private string _recibonfe;

    private static readonly string RO_REMESSAUNICA = "Remessaunica";

    private string _remessaunica;

    private static readonly string RO_REVENDA = "Revenda";

    private string _revenda;

    private static readonly string RO_ROTINALANC = "Rotinalanc";

    private string _rotinalanc;

    private static readonly string RO_SERIE = "Serie";

    private string _serie;

    private static readonly string RO_SERIENFVENDA = "Serienfvenda";

    private string _serienfvenda;

    private static readonly string RO_SERIEORIGINAL = "Serieoriginal";

    private string _serieoriginal;

    private static readonly string RO_SERIEPRODRURAL = "Serieprodrural";

    private string _serieprodrural;

    private static readonly string RO_SIMPLESNACIONAL = "Simplesnacional";

    private string _simplesnacional;

    private static readonly string RO_SITDOCPISCOFINS = "Sitdocpiscofins";

    private string _sitdocpiscofins;

    private static readonly string RO_SITUACAONFE = "Situacaonfe";

    private decimal? _situacaonfe;

    private static readonly string RO_SOMARPISCOFINSVLOUTRASDESPIMP = "Somarpiscofinsvloutrasdespimp";

    private string _somarpiscofinsvloutrasdespimp;

    private static readonly string RO_SOMARVLOUTRASDESPADUANEIRAS = "Somarvloutrasdespaduaneiras";

    private string _somarvloutrasdespaduaneiras;

    private static readonly string RO_TELEFONE = "Telefone";

    private string _telefone;

    private static readonly string RO_TEMPOAPRO = "Tempoapro";

    private decimal? _tempoapro;

    private static readonly string RO_TEMPODESCARGA = "Tempodescarga";

    private decimal? _tempodescarga;

    private static readonly string RO_TENTATIVAENVIONFE = "Tentativaenvionfe";

    private decimal? _tentativaenvionfe;

    private static readonly string RO_TIPOALIQOUTRASDESP = "Tipoaliqoutrasdesp";

    private string _tipoaliqoutrasdesp;

    private static readonly string RO_TIPODESCARGA = "Tipodescarga";

    private string _tipodescarga;

    private static readonly string RO_TIPOEMISSAO = "Tipoemissao";

    private string _tipoemissao;

    private static readonly string RO_TIPOEMISSAOCTE = "Tipoemissaocte";

    private string _tipoemissaocte;

    private static readonly string RO_TIPOFJ = "Tipofj";

    private string _tipofj;

    private static readonly string RO_TIPOFORNEC = "Tipofornec";

    private string _tipofornec;

    private static readonly string RO_TIPOFRETECIFFOB = "Tipofreteciffob";

    private string _tipofreteciffob;

    private static readonly string RO_TIPOLIGACAOENERGIA = "Tipoligacaoenergia";

    private string _tipoligacaoenergia;

    private static readonly string RO_TIPONOTAFISCALBRINDE = "Tiponotafiscalbrinde";

    private string _tiponotafiscalbrinde;

    private static readonly string RO_TIPOTRIBENTIMP = "Tipotribentimp";

    private string _tipotribentimp;

    private static readonly string RO_TOTALPESOLIQDI = "Totalpesoliqdi";

    private decimal? _totalpesoliqdi;

    private static readonly string RO_TOTDIFALIQUOTAS = "Totdifaliquotas";

    private decimal? _totdifaliquotas;

    private static readonly string RO_TOTPESO = "Totpeso";

    private decimal? _totpeso;

    private static readonly string RO_TOTPESOLIQ = "Totpesoliq";

    private decimal? _totpesoliq;

    private static readonly string RO_UF = "Uf";

    private string _uf;

    private static readonly string RO_UFCODIGO = "Ufcodigo";

    private string _ufcodigo;

    private static readonly string RO_UFDESEMBARACO = "Ufdesembaraco";

    private string _ufdesembaraco;

    private static readonly string RO_UFFILIAL = "Uffilial";

    private string _uffilial;

    private static readonly string RO_UFVEICULO = "Ufveiculo";

    private string _ufveiculo;

    private static readonly string RO_USACREDPISCOFINSENTBONIFIC = "Usacredpiscofinsentbonific";

    private string _usacredpiscofinsentbonific;

    private static readonly string RO_USAINTEGRACAOWMS = "Usaintegracaowms";

    private string _usaintegracaowms;

    private static readonly string RO_USAOUTRASDESPSEGUROPISCOFINS = "Usaoutrasdespseguropiscofins";

    private string _usaoutrasdespseguropiscofins;

    private static readonly string RO_UTILIZAIPICALCICMS = "Utilizaipicalcicms";

    private string _utilizaipicalcicms;

    private static readonly string RO_UTILIZAOUTDESPCALCSUFRAMA = "Utilizaoutdespcalcsuframa";

    private string _utilizaoutdespcalcsuframa;

    private static readonly string RO_VLADUANEIRA = "Vladuaneira";

    private decimal? _vladuaneira;

    private static readonly string RO_VLBASE = "Vlbase";

    private decimal? _vlbase;

    private static readonly string RO_VLBASECOFINS = "Vlbasecofins";

    private decimal? _vlbasecofins;

    private static readonly string RO_VLBASEIPI = "Vlbaseipi";

    private decimal? _vlbaseipi;

    private static readonly string RO_VLBASEPIS = "Vlbasepis";

    private decimal? _vlbasepis;

    private static readonly string RO_VLBONIFIC = "Vlbonific";

    private decimal? _vlbonific;

    private static readonly string RO_VLCOFINS = "Vlcofins";

    private decimal? _vlcofins;

    private static readonly string RO_VLCREDCOFINS = "Vlcredcofins";

    private decimal? _vlcredcofins;

    private static readonly string RO_VLCREDPIS = "Vlcredpis";

    private decimal? _vlcredpis;

    private static readonly string RO_VLCSRF = "Vlcsrf";

    private decimal? _vlcsrf;

    private static readonly string RO_VLDESCFIN = "Vldescfin";

    private decimal? _vldescfin;

    private static readonly string RO_VLDESCONTO = "Vldesconto";

    private decimal? _vldesconto;

    private static readonly string RO_VLDESPDENTRONF = "Vldespdentronf";

    private decimal? _vldespdentronf;

    private static readonly string RO_VLFRETE = "Vlfrete";

    private decimal? _vlfrete;

    private static readonly string RO_VLICMS = "Vlicms";

    private decimal? _vlicms;

    private static readonly string RO_VLINSS = "Vlinss";

    private decimal? _vlinss;

    private static readonly string RO_VLIPI = "Vlipi";

    private decimal? _vlipi;

    private static readonly string RO_VLIRRF = "Vlirrf";

    private decimal? _vlirrf;

    private static readonly string RO_VLISENTAS = "Vlisentas";

    private decimal? _vlisentas;

    private static readonly string RO_VLISS = "Vliss";

    private decimal? _vliss;

    private static readonly string RO_VLOUTRAS = "Vloutras";

    private decimal? _vloutras;

    private static readonly string RO_VLOUTRASDESPIMP = "Vloutrasdespimp";

    private decimal? _vloutrasdespimp;

    private static readonly string RO_VLPEDAGIO = "Vlpedagio";

    private decimal? _vlpedagio;

    private static readonly string RO_VLPIS = "Vlpis";

    private decimal? _vlpis;

    private static readonly string RO_VLSEGURO = "Vlseguro";

    private decimal? _vlseguro;

    private static readonly string RO_VLSESTSENAT = "Vlsestsenat";

    private decimal? _vlsestsenat;

    private static readonly string RO_VLSISCOMEX = "Vlsiscomex";

    private decimal? _vlsiscomex;

    private static readonly string RO_VLST = "Vlst";

    private decimal? _vlst;

    private static readonly string RO_VLTOTAL = "Vltotal";

    private decimal? _vltotal;

    private static readonly string RO_VLTOTALFRETEFOB = "Vltotalfretefob";

    private decimal? _vltotalfretefob;

    private static readonly string RO_VLTOTALIPI = "Vltotalipi";

    private decimal? _vltotalipi;

    private static readonly string RO_VLTOTGER = "Vltotger";

    private decimal? _vltotger;

    private static readonly string RO_VLVERBACMV = "Vlverbacmv";

    private decimal? _vlverbacmv;

    private static readonly string RO_VLVERBACMVCLI = "Vlverbacmvcli";

    private decimal? _vlverbacmvcli;

    private static readonly string RO_WMSCODFUNCIGNORA = "Wmscodfuncignora";

    private decimal? _wmscodfuncignora;

    private static readonly string RO_WMSIGNORADO = "Wmsignorado";

    private string _wmsignorado;

    private static readonly string RO_NUMTRANSINTEGRACAO = "Numtransintegracao";

    private string _numtransintegracao;

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 2)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 2)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Calcbaseicmsaliqredentimp
    {
        get
        {
            PropriedadeAcessada(RO_CALCBASEICMSALIQREDENTIMP);
            return _calcbaseicmsaliqredentimp;
        }
        set
        {
            PropriedadeModificada(RO_CALCBASEICMSALIQREDENTIMP, value);
            _calcbaseicmsaliqredentimp = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Calccredicmcustocont
    {
        get
        {
            PropriedadeAcessada(RO_CALCCREDICMCUSTOCONT);
            return _calccredicmcustocont;
        }
        set
        {
            PropriedadeModificada(RO_CALCCREDICMCUSTOCONT, value);
            _calccredicmcustocont = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Calccredicms
    {
        get
        {
            PropriedadeAcessada(RO_CALCCREDICMS);
            return _calccredicms;
        }
        set
        {
            PropriedadeModificada(RO_CALCCREDICMS, value);
            _calccredicms = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Calccredpiscofins
    {
        get
        {
            PropriedadeAcessada(RO_CALCCREDPISCOFINS);
            return _calccredpiscofins;
        }
        set
        {
            PropriedadeModificada(RO_CALCCREDPISCOFINS, value);
            _calccredpiscofins = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Calccredpiscustocont
    {
        get
        {
            PropriedadeAcessada(RO_CALCCREDPISCUSTOCONT);
            return _calccredpiscustocont;
        }
        set
        {
            PropriedadeModificada(RO_CALCCREDPISCUSTOCONT, value);
            _calccredpiscustocont = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Calcdescarga
    {
        get
        {
            PropriedadeAcessada(RO_CALCDESCARGA);
            return _calcdescarga;
        }
        set
        {
            PropriedadeModificada(RO_CALCDESCARGA, value);
            _calcdescarga = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Calcdespfinprazopgto
    {
        get
        {
            PropriedadeAcessada(RO_CALCDESPFINPRAZOPGTO);
            return _calcdespfinprazopgto;
        }
        set
        {
            PropriedadeModificada(RO_CALCDESPFINPRAZOPGTO, value);
            _calcdespfinprazopgto = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 9, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 18, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 14, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 44, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 45, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 45, Precisao = 0)]
    public string Chavenfeprodrural
    {
        get
        {
            PropriedadeAcessada(RO_CHAVENFEPRODRURAL);
            return _chavenfeprodrural;
        }
        set
        {
            PropriedadeModificada(RO_CHAVENFEPRODRURAL, value);
            _chavenfeprodrural = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal Codcont
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 0)]
    public decimal? Codcontabfornec
    {
        get
        {
            PropriedadeAcessada(RO_CODCONTABFORNEC);
            return _codcontabfornec;
        }
        set
        {
            PropriedadeModificada(RO_CODCONTABFORNEC, value);
            _codcontabfornec = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Codcontfor
    {
        get
        {
            PropriedadeAcessada(RO_CODCONTFOR);
            return _codcontfor;
        }
        set
        {
            PropriedadeModificada(RO_CODCONTFOR, value);
            _codcontfor = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Codcontfre
    {
        get
        {
            PropriedadeAcessada(RO_CODCONTFRE);
            return _codcontfre;
        }
        set
        {
            PropriedadeModificada(RO_CODCONTFRE, value);
            _codcontfre = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Codentveiculo
    {
        get
        {
            PropriedadeAcessada(RO_CODENTVEICULO);
            return _codentveiculo;
        }
        set
        {
            PropriedadeModificada(RO_CODENTVEICULO, value);
            _codentveiculo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codforfilial
    {
        get
        {
            PropriedadeAcessada(RO_CODFORFILIAL);
            return _codforfilial;
        }
        set
        {
            PropriedadeModificada(RO_CODFORFILIAL, value);
            _codforfilial = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal Codfornec
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codfornecnf
    {
        get
        {
            PropriedadeAcessada(RO_CODFORNECNF);
            return _codfornecnf;
        }
        set
        {
            PropriedadeModificada(RO_CODFORNECNF, value);
            _codfornecnf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfuncenvio
    {
        get
        {
            PropriedadeAcessada(RO_CODFUNCENVIO);
            return _codfuncenvio;
        }
        set
        {
            PropriedadeModificada(RO_CODFUNCENVIO, value);
            _codfuncenvio = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfuncenviowms
    {
        get
        {
            PropriedadeAcessada(RO_CODFUNCENVIOWMS);
            return _codfuncenviowms;
        }
        set
        {
            PropriedadeModificada(RO_CODFUNCENVIOWMS, value);
            _codfuncenviowms = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Codigoclasseconsumoenergia
    {
        get
        {
            PropriedadeAcessada(RO_CODIGOCLASSECONSUMOENERGIA);
            return _codigoclasseconsumoenergia;
        }
        set
        {
            PropriedadeModificada(RO_CODIGOCLASSECONSUMOENERGIA, value);
            _codigoclasseconsumoenergia = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Codigogrupotensaoenergia
    {
        get
        {
            PropriedadeAcessada(RO_CODIGOGRUPOTENSAOENERGIA);
            return _codigogrupotensaoenergia;
        }
        set
        {
            PropriedadeModificada(RO_CODIGOGRUPOTENSAOENERGIA, value);
            _codigogrupotensaoenergia = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codmotoristadevol
    {
        get
        {
            PropriedadeAcessada(RO_CODMOTORISTADEVOL);
            return _codmotoristadevol;
        }
        set
        {
            PropriedadeModificada(RO_CODMOTORISTADEVOL, value);
            _codmotoristadevol = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 10, Precisao = 0)]
    public string Codreceitarecolhim
    {
        get
        {
            PropriedadeAcessada(RO_CODRECEITARECOLHIM);
            return _codreceitarecolhim;
        }
        set
        {
            PropriedadeModificada(RO_CODRECEITARECOLHIM, value);
            _codreceitarecolhim = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codrotinadesbloqueio
    {
        get
        {
            PropriedadeAcessada(RO_CODROTINADESBLOQUEIO);
            return _codrotinadesbloqueio;
        }
        set
        {
            PropriedadeModificada(RO_CODROTINADESBLOQUEIO, value);
            _codrotinadesbloqueio = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Codtribpiscofins
    {
        get
        {
            PropriedadeAcessada(RO_CODTRIBPISCOFINS);
            return _codtribpiscofins;
        }
        set
        {
            PropriedadeModificada(RO_CODTRIBPISCOFINS, value);
            _codtribpiscofins = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Codusurdevol
    {
        get
        {
            PropriedadeAcessada(RO_CODUSURDEVOL);
            return _codusurdevol;
        }
        set
        {
            PropriedadeModificada(RO_CODUSURDEVOL, value);
            _codusurdevol = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Conciliacao
    {
        get
        {
            PropriedadeAcessada(RO_CONCILIACAO);
            return _conciliacao;
        }
        set
        {
            PropriedadeModificada(RO_CONCILIACAO, value);
            _conciliacao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Consideraipinofretefob
    {
        get
        {
            PropriedadeAcessada(RO_CONSIDERAIPINOFRETEFOB);
            return _consideraipinofretefob;
        }
        set
        {
            PropriedadeModificada(RO_CONSIDERAIPINOFRETEFOB, value);
            _consideraipinofretefob = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Considerariipunit
    {
        get
        {
            PropriedadeAcessada(RO_CONSIDERARIIPUNIT);
            return _considerariipunit;
        }
        set
        {
            PropriedadeModificada(RO_CONSIDERARIIPUNIT, value);
            _considerariipunit = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Consstnfpiscofins
    {
        get
        {
            PropriedadeAcessada(RO_CONSSTNFPISCOFINS);
            return _consstnfpiscofins;
        }
        set
        {
            PropriedadeModificada(RO_CONSSTNFPISCOFINS, value);
            _consstnfpiscofins = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Datadiimportacao
    {
        get
        {
            PropriedadeAcessada(RO_DATADIIMPORTACAO);
            return _datadiimportacao;
        }
        set
        {
            PropriedadeModificada(RO_DATADIIMPORTACAO, value);
            _datadiimportacao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Dedfretecifcredpresicms
    {
        get
        {
            PropriedadeAcessada(RO_DEDFRETECIFCREDPRESICMS);
            return _dedfretecifcredpresicms;
        }
        set
        {
            PropriedadeModificada(RO_DEDFRETECIFCREDPRESICMS, value);
            _dedfretecifcredpresicms = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 60, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Devsimbolica
    {
        get
        {
            PropriedadeAcessada(RO_DEVSIMBOLICA);
            return _devsimbolica;
        }
        set
        {
            PropriedadeModificada(RO_DEVSIMBOLICA, value);
            _devsimbolica = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtconcil
    {
        get
        {
            PropriedadeAcessada(RO_DTCONCIL);
            return _dtconcil;
        }
        set
        {
            PropriedadeModificada(RO_DTCONCIL, value);
            _dtconcil = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtdescarga
    {
        get
        {
            PropriedadeAcessada(RO_DTDESCARGA);
            return _dtdescarga;
        }
        set
        {
            PropriedadeModificada(RO_DTDESCARGA, value);
            _dtdescarga = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime Dtemissao
    {
        get
        {
            PropriedadeAcessada(RO_DTEMISSAO);
            return _dtemissao;
        }
        set
        {
            PropriedadeModificada(RO_DTEMISSAO, value);
            _dtemissao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtemissaonfvenda
    {
        get
        {
            PropriedadeAcessada(RO_DTEMISSAONFVENDA);
            return _dtemissaonfvenda;
        }
        set
        {
            PropriedadeModificada(RO_DTEMISSAONFVENDA, value);
            _dtemissaonfvenda = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtemissaoprodrural
    {
        get
        {
            PropriedadeAcessada(RO_DTEMISSAOPRODRURAL);
            return _dtemissaoprodrural;
        }
        set
        {
            PropriedadeModificada(RO_DTEMISSAOPRODRURAL, value);
            _dtemissaoprodrural = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime Dtent
    {
        get
        {
            PropriedadeAcessada(RO_DTENT);
            return _dtent;
        }
        set
        {
            PropriedadeModificada(RO_DTENT, value);
            _dtent = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtenviowms
    {
        get
        {
            PropriedadeAcessada(RO_DTENVIOWMS);
            return _dtenviowms;
        }
        set
        {
            PropriedadeModificada(RO_DTENVIOWMS, value);
            _dtenviowms = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtproxatu
    {
        get
        {
            PropriedadeAcessada(RO_DTPROXATU);
            return _dtproxatu;
        }
        set
        {
            PropriedadeModificada(RO_DTPROXATU, value);
            _dtproxatu = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtsaida
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtselofiscal
    {
        get
        {
            PropriedadeAcessada(RO_DTSELOFISCAL);
            return _dtselofiscal;
        }
        set
        {
            PropriedadeModificada(RO_DTSELOFISCAL, value);
            _dtselofiscal = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtterminociap
    {
        get
        {
            PropriedadeAcessada(RO_DTTERMINOCIAP);
            return _dtterminociap;
        }
        set
        {
            PropriedadeModificada(RO_DTTERMINOCIAP, value);
            _dtterminociap = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtvencstforanf
    {
        get
        {
            PropriedadeAcessada(RO_DTVENCSTFORANF);
            return _dtvencstforanf;
        }
        set
        {
            PropriedadeModificada(RO_DTVENCSTFORANF, value);
            _dtvencstforanf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 100, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Emissaopropria
    {
        get
        {
            PropriedadeAcessada(RO_EMISSAOPROPRIA);
            return _emissaopropria;
        }
        set
        {
            PropriedadeModificada(RO_EMISSAOPROPRIA, value);
            _emissaopropria = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Entradatipoi
    {
        get
        {
            PropriedadeAcessada(RO_ENTRADATIPOI);
            return _entradatipoi;
        }
        set
        {
            PropriedadeModificada(RO_ENTRADATIPOI, value);
            _entradatipoi = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Enviadoemailcancelado
    {
        get
        {
            PropriedadeAcessada(RO_ENVIADOEMAILCANCELADO);
            return _enviadoemailcancelado;
        }
        set
        {
            PropriedadeModificada(RO_ENVIADOEMAILCANCELADO, value);
            _enviadoemailcancelado = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 64, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 100, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Estcomissaorca
    {
        get
        {
            PropriedadeAcessada(RO_ESTCOMISSAORCA);
            return _estcomissaorca;
        }
        set
        {
            PropriedadeModificada(RO_ESTCOMISSAORCA, value);
            _estcomissaorca = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Fechamentoceautomatico
    {
        get
        {
            PropriedadeAcessada(RO_FECHAMENTOCEAUTOMATICO);
            return _fechamentoceautomatico;
        }
        set
        {
            PropriedadeModificada(RO_FECHAMENTOCEAUTOMATICO, value);
            _fechamentoceautomatico = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 0)]
    public decimal? Folhalivro_Entrada
    {
        get
        {
            PropriedadeAcessada(RO_FOLHALIVRO_ENTRADA);
            return _folhalivro_entrada;
        }
        set
        {
            PropriedadeModificada(RO_FOLHALIVRO_ENTRADA, value);
            _folhalivro_entrada = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
    public string Fornecedor
    {
        get
        {
            PropriedadeAcessada(RO_FORNECEDOR);
            return _fornecedor;
        }
        set
        {
            PropriedadeModificada(RO_FORNECEDOR, value);
            _fornecedor = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 30, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Geranfdevcli
    {
        get
        {
            PropriedadeAcessada(RO_GERANFDEVCLI);
            return _geranfdevcli;
        }
        set
        {
            PropriedadeModificada(RO_GERANFDEVCLI, value);
            _geranfdevcli = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Geranfvenda
    {
        get
        {
            PropriedadeAcessada(RO_GERANFVENDA);
            return _geranfvenda;
        }
        set
        {
            PropriedadeModificada(RO_GERANFVENDA, value);
            _geranfvenda = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 15, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Incluirimpostosnftranspimp
    {
        get
        {
            PropriedadeAcessada(RO_INCLUIRIMPOSTOSNFTRANSPIMP);
            return _incluirimpostosnftranspimp;
        }
        set
        {
            PropriedadeModificada(RO_INCLUIRIMPOSTOSNFTRANSPIMP, value);
            _incluirimpostosnftranspimp = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Industrialocal
    {
        get
        {
            PropriedadeAcessada(RO_INDUSTRIALOCAL);
            return _industrialocal;
        }
        set
        {
            PropriedadeModificada(RO_INDUSTRIALOCAL, value);
            _industrialocal = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 256, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 30, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Lotedigitado
    {
        get
        {
            PropriedadeAcessada(RO_LOTEDIGITADO);
            return _lotedigitado;
        }
        set
        {
            PropriedadeModificada(RO_LOTEDIGITADO, value);
            _lotedigitado = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Modelo
    {
        get
        {
            PropriedadeAcessada(RO_MODELO);
            return _modelo;
        }
        set
        {
            PropriedadeModificada(RO_MODELO, value);
            _modelo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Modeloprodrural
    {
        get
        {
            PropriedadeAcessada(RO_MODELOPRODRURAL);
            return _modeloprodrural;
        }
        set
        {
            PropriedadeModificada(RO_MODELOPRODRURAL, value);
            _modeloprodrural = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 250, Precisao = 0)]
    public string Motestornonfe
    {
        get
        {
            PropriedadeAcessada(RO_MOTESTORNONFE);
            return _motestornonfe;
        }
        set
        {
            PropriedadeModificada(RO_MOTESTORNONFE, value);
            _motestornonfe = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Movestoqueimport
    {
        get
        {
            PropriedadeAcessada(RO_MOVESTOQUEIMPORT);
            return _movestoqueimport;
        }
        set
        {
            PropriedadeModificada(RO_MOVESTOQUEIMPORT, value);
            _movestoqueimport = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 30, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 60, Precisao = 0)]
    public string Natopernfe
    {
        get
        {
            PropriedadeAcessada(RO_NATOPERNFE);
            return _natopernfe;
        }
        set
        {
            PropriedadeModificada(RO_NATOPERNFE, value);
            _natopernfe = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Nfentregafutura
    {
        get
        {
            PropriedadeAcessada(RO_NFENTREGAFUTURA);
            return _nfentregafutura;
        }
        set
        {
            PropriedadeModificada(RO_NFENTREGAFUTURA, value);
            _nfentregafutura = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Nfextemporanea
    {
        get
        {
            PropriedadeAcessada(RO_NFEXTEMPORANEA);
            return _nfextemporanea;
        }
        set
        {
            PropriedadeModificada(RO_NFEXTEMPORANEA, value);
            _nfextemporanea = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 250, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Numaplic
    {
        get
        {
            PropriedadeAcessada(RO_NUMAPLIC);
            return _numaplic;
        }
        set
        {
            PropriedadeModificada(RO_NUMAPLIC, value);
            _numaplic = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
    public string Numdiimportacao
    {
        get
        {
            PropriedadeAcessada(RO_NUMDIIMPORTACAO);
            return _numdiimportacao;
        }
        set
        {
            PropriedadeModificada(RO_NUMDIIMPORTACAO, value);
            _numdiimportacao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numentmex
    {
        get
        {
            PropriedadeAcessada(RO_NUMENTMEX);
            return _numentmex;
        }
        set
        {
            PropriedadeModificada(RO_NUMENTMEX, value);
            _numentmex = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 6, Precisao = 0)]
    public string Numeroend
    {
        get
        {
            PropriedadeAcessada(RO_NUMEROEND);
            return _numeroend;
        }
        set
        {
            PropriedadeModificada(RO_NUMEROEND, value);
            _numeroend = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 30, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 10, Precisao = 0)]
    public string Numlivro_Entrada
    {
        get
        {
            PropriedadeAcessada(RO_NUMLIVRO_ENTRADA);
            return _numlivro_entrada;
        }
        set
        {
            PropriedadeModificada(RO_NUMLIVRO_ENTRADA, value);
            _numlivro_entrada = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 15, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numnotaentfutura
    {
        get
        {
            PropriedadeAcessada(RO_NUMNOTAENTFUTURA);
            return _numnotaentfutura;
        }
        set
        {
            PropriedadeModificada(RO_NUMNOTAENTFUTURA, value);
            _numnotaentfutura = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numnotaprodrural
    {
        get
        {
            PropriedadeAcessada(RO_NUMNOTAPRODRURAL);
            return _numnotaprodrural;
        }
        set
        {
            PropriedadeModificada(RO_NUMNOTAPRODRURAL, value);
            _numnotaprodrural = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numnotavenda
    {
        get
        {
            PropriedadeAcessada(RO_NUMNOTAVENDA);
            return _numnotavenda;
        }
        set
        {
            PropriedadeModificada(RO_NUMNOTAVENDA, value);
            _numnotavenda = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Numparcdevol
    {
        get
        {
            PropriedadeAcessada(RO_NUMPARCDEVOL);
            return _numparcdevol;
        }
        set
        {
            PropriedadeModificada(RO_NUMPARCDEVOL, value);
            _numparcdevol = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numtransbenefic
    {
        get
        {
            PropriedadeAcessada(RO_NUMTRANSBENEFIC);
            return _numtransbenefic;
        }
        set
        {
            PropriedadeModificada(RO_NUMTRANSBENEFIC, value);
            _numtransbenefic = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal Numtransent
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numtransorigem
    {
        get
        {
            PropriedadeAcessada(RO_NUMTRANSORIGEM);
            return _numtransorigem;
        }
        set
        {
            PropriedadeModificada(RO_NUMTRANSORIGEM, value);
            _numtransorigem = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numtransvendaorig
    {
        get
        {
            PropriedadeAcessada(RO_NUMTRANSVENDAORIG);
            return _numtransvendaorig;
        }
        set
        {
            PropriedadeModificada(RO_NUMTRANSVENDAORIG, value);
            _numtransvendaorig = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numtransvendatroca
    {
        get
        {
            PropriedadeAcessada(RO_NUMTRANSVENDATROCA);
            return _numtransvendatroca;
        }
        set
        {
            PropriedadeModificada(RO_NUMTRANSVENDATROCA, value);
            _numtransvendatroca = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 0)]
    public decimal? Numvol
    {
        get
        {
            PropriedadeAcessada(RO_NUMVOL);
            return _numvol;
        }
        set
        {
            PropriedadeModificada(RO_NUMVOL, value);
            _numvol = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
    public string Numvolume
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 60, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 500, Precisao = 0)]
    public string Obslivrofiscal
    {
        get
        {
            PropriedadeAcessada(RO_OBSLIVROFISCAL);
            return _obslivrofiscal;
        }
        set
        {
            PropriedadeModificada(RO_OBSLIVROFISCAL, value);
            _obslivrofiscal = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Binario, Tamanho = 4000, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 500, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 120, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 120, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 2)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Percaltercustoent
    {
        get
        {
            PropriedadeAcessada(RO_PERCALTERCUSTOENT);
            return _percaltercustoent;
        }
        set
        {
            PropriedadeModificada(RO_PERCALTERCUSTOENT, value);
            _percaltercustoent = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 2)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 2)]
    public decimal? Percpisred
    {
        get
        {
            PropriedadeAcessada(RO_PERCPISRED);
            return _percpisred;
        }
        set
        {
            PropriedadeModificada(RO_PERCPISRED, value);
            _percpisred = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Pesofretefob
    {
        get
        {
            PropriedadeAcessada(RO_PESOFRETEFOB);
            return _pesofretefob;
        }
        set
        {
            PropriedadeModificada(RO_PESOFRETEFOB, value);
            _pesofretefob = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 10, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Possecodfornec
    {
        get
        {
            PropriedadeAcessada(RO_POSSECODFORNEC);
            return _possecodfornec;
        }
        set
        {
            PropriedadeModificada(RO_POSSECODFORNEC, value);
            _possecodfornec = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Prazo
    {
        get
        {
            PropriedadeAcessada(RO_PRAZO);
            return _prazo;
        }
        set
        {
            PropriedadeModificada(RO_PRAZO, value);
            _prazo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 16, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 16, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 16, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Rateiopesoliq
    {
        get
        {
            PropriedadeAcessada(RO_RATEIOPESOLIQ);
            return _rateiopesoliq;
        }
        set
        {
            PropriedadeModificada(RO_RATEIOPESOLIQ, value);
            _rateiopesoliq = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Rebaixacustocomdescfin
    {
        get
        {
            PropriedadeAcessada(RO_REBAIXACUSTOCOMDESCFIN);
            return _rebaixacustocomdescfin;
        }
        set
        {
            PropriedadeModificada(RO_REBAIXACUSTOCOMDESCFIN, value);
            _rebaixacustocomdescfin = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Remessaunica
    {
        get
        {
            PropriedadeAcessada(RO_REMESSAUNICA);
            return _remessaunica;
        }
        set
        {
            PropriedadeModificada(RO_REMESSAUNICA, value);
            _remessaunica = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Revenda
    {
        get
        {
            PropriedadeAcessada(RO_REVENDA);
            return _revenda;
        }
        set
        {
            PropriedadeModificada(RO_REVENDA, value);
            _revenda = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 48, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 3, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 3, Precisao = 0)]
    public string Serienfvenda
    {
        get
        {
            PropriedadeAcessada(RO_SERIENFVENDA);
            return _serienfvenda;
        }
        set
        {
            PropriedadeModificada(RO_SERIENFVENDA, value);
            _serienfvenda = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 3, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 3, Precisao = 0)]
    public string Serieprodrural
    {
        get
        {
            PropriedadeAcessada(RO_SERIEPRODRURAL);
            return _serieprodrural;
        }
        set
        {
            PropriedadeModificada(RO_SERIEPRODRURAL, value);
            _serieprodrural = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Simplesnacional
    {
        get
        {
            PropriedadeAcessada(RO_SIMPLESNACIONAL);
            return _simplesnacional;
        }
        set
        {
            PropriedadeModificada(RO_SIMPLESNACIONAL, value);
            _simplesnacional = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Sitdocpiscofins
    {
        get
        {
            PropriedadeAcessada(RO_SITDOCPISCOFINS);
            return _sitdocpiscofins;
        }
        set
        {
            PropriedadeModificada(RO_SITDOCPISCOFINS, value);
            _sitdocpiscofins = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Somarpiscofinsvloutrasdespimp
    {
        get
        {
            PropriedadeAcessada(RO_SOMARPISCOFINSVLOUTRASDESPIMP);
            return _somarpiscofinsvloutrasdespimp;
        }
        set
        {
            PropriedadeModificada(RO_SOMARPISCOFINSVLOUTRASDESPIMP, value);
            _somarpiscofinsvloutrasdespimp = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Somarvloutrasdespaduaneiras
    {
        get
        {
            PropriedadeAcessada(RO_SOMARVLOUTRASDESPADUANEIRAS);
            return _somarvloutrasdespaduaneiras;
        }
        set
        {
            PropriedadeModificada(RO_SOMARVLOUTRASDESPADUANEIRAS, value);
            _somarvloutrasdespaduaneiras = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 2)]
    public decimal? Tempoapro
    {
        get
        {
            PropriedadeAcessada(RO_TEMPOAPRO);
            return _tempoapro;
        }
        set
        {
            PropriedadeModificada(RO_TEMPOAPRO, value);
            _tempoapro = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 2)]
    public decimal? Tempodescarga
    {
        get
        {
            PropriedadeAcessada(RO_TEMPODESCARGA);
            return _tempodescarga;
        }
        set
        {
            PropriedadeModificada(RO_TEMPODESCARGA, value);
            _tempodescarga = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Tipodescarga
    {
        get
        {
            PropriedadeAcessada(RO_TIPODESCARGA);
            return _tipodescarga;
        }
        set
        {
            PropriedadeModificada(RO_TIPODESCARGA, value);
            _tipodescarga = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Tipofreteciffob
    {
        get
        {
            PropriedadeAcessada(RO_TIPOFRETECIFFOB);
            return _tipofreteciffob;
        }
        set
        {
            PropriedadeModificada(RO_TIPOFRETECIFFOB, value);
            _tipofreteciffob = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Tipoligacaoenergia
    {
        get
        {
            PropriedadeAcessada(RO_TIPOLIGACAOENERGIA);
            return _tipoligacaoenergia;
        }
        set
        {
            PropriedadeModificada(RO_TIPOLIGACAOENERGIA, value);
            _tipoligacaoenergia = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Tiponotafiscalbrinde
    {
        get
        {
            PropriedadeAcessada(RO_TIPONOTAFISCALBRINDE);
            return _tiponotafiscalbrinde;
        }
        set
        {
            PropriedadeModificada(RO_TIPONOTAFISCALBRINDE, value);
            _tiponotafiscalbrinde = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Tipotribentimp
    {
        get
        {
            PropriedadeAcessada(RO_TIPOTRIBENTIMP);
            return _tipotribentimp;
        }
        set
        {
            PropriedadeModificada(RO_TIPOTRIBENTIMP, value);
            _tipotribentimp = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Totalpesoliqdi
    {
        get
        {
            PropriedadeAcessada(RO_TOTALPESOLIQDI);
            return _totalpesoliqdi;
        }
        set
        {
            PropriedadeModificada(RO_TOTALPESOLIQDI, value);
            _totalpesoliqdi = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 2)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Usacredpiscofinsentbonific
    {
        get
        {
            PropriedadeAcessada(RO_USACREDPISCOFINSENTBONIFIC);
            return _usacredpiscofinsentbonific;
        }
        set
        {
            PropriedadeModificada(RO_USACREDPISCOFINSENTBONIFIC, value);
            _usacredpiscofinsentbonific = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Usaoutrasdespseguropiscofins
    {
        get
        {
            PropriedadeAcessada(RO_USAOUTRASDESPSEGUROPISCOFINS);
            return _usaoutrasdespseguropiscofins;
        }
        set
        {
            PropriedadeModificada(RO_USAOUTRASDESPSEGUROPISCOFINS, value);
            _usaoutrasdespseguropiscofins = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Utilizaoutdespcalcsuframa
    {
        get
        {
            PropriedadeAcessada(RO_UTILIZAOUTDESPCALCSUFRAMA);
            return _utilizaoutdespcalcsuframa;
        }
        set
        {
            PropriedadeModificada(RO_UTILIZAOUTDESPCALCSUFRAMA, value);
            _utilizaoutdespcalcsuframa = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 2)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlbasecofins
    {
        get
        {
            PropriedadeAcessada(RO_VLBASECOFINS);
            return _vlbasecofins;
        }
        set
        {
            PropriedadeModificada(RO_VLBASECOFINS, value);
            _vlbasecofins = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 2)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlbasepis
    {
        get
        {
            PropriedadeAcessada(RO_VLBASEPIS);
            return _vlbasepis;
        }
        set
        {
            PropriedadeModificada(RO_VLBASEPIS, value);
            _vlbasepis = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 2)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 2)]
    public decimal? Vlcsrf
    {
        get
        {
            PropriedadeAcessada(RO_VLCSRF);
            return _vlcsrf;
        }
        set
        {
            PropriedadeModificada(RO_VLCSRF, value);
            _vlcsrf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 2)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 2)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 2)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 2)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 2)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 2)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 2)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 2)]
    public decimal? Vlirrf
    {
        get
        {
            PropriedadeAcessada(RO_VLIRRF);
            return _vlirrf;
        }
        set
        {
            PropriedadeModificada(RO_VLIRRF, value);
            _vlirrf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 2)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 2)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 2)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 2)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 2)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 2)]
    public decimal? Vlsestsenat
    {
        get
        {
            PropriedadeAcessada(RO_VLSESTSENAT);
            return _vlsestsenat;
        }
        set
        {
            PropriedadeModificada(RO_VLSESTSENAT, value);
            _vlsestsenat = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 2)]
    public decimal? Vlst
    {
        get
        {
            PropriedadeAcessada(RO_VLST);
            return _vlst;
        }
        set
        {
            PropriedadeModificada(RO_VLST, value);
            _vlst = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 2)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 2)]
    public decimal? Vltotalfretefob
    {
        get
        {
            PropriedadeAcessada(RO_VLTOTALFRETEFOB);
            return _vltotalfretefob;
        }
        set
        {
            PropriedadeModificada(RO_VLTOTALFRETEFOB, value);
            _vltotalfretefob = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 2)]
    public decimal? Vltotalipi
    {
        get
        {
            PropriedadeAcessada(RO_VLTOTALIPI);
            return _vltotalipi;
        }
        set
        {
            PropriedadeModificada(RO_VLTOTALIPI, value);
            _vltotalipi = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 2)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
    public string Numtransintegracao
    {
        get
        {
            PropriedadeAcessada(RO_NUMTRANSINTEGRACAO);
            return _numtransintegracao;
        }
        set
        {
            PropriedadeModificada(RO_NUMTRANSINTEGRACAO, value);
            _numtransintegracao = value;
        }
    }

    public void InicializarAtributos()
    {
    }

    public string ObterNomeTabela()
    {
        return "PCNFENT";
    }

    public IEntidade NovaInstancia()
    {
        return (IEntidade)GetType().GetConstructors()[0].Invoke(null);
    }

    public void CarregarPorDataReader(IDataReader leitor)
    {
        _agregarstprodsintegra = AlterarTipo<string>(leitor["Agregarstprodsintegra"]);
        _aliqicmoutrasdesp = AlterarTipo<decimal?>(leitor["Aliqicmoutrasdesp"]);
        _aliquota = AlterarTipo<decimal?>(leitor["Aliquota"]);
        _ambiente = AlterarTipo<string>(leitor["Ambiente"]);
        _ambientenfe = AlterarTipo<string>(leitor["Ambientenfe"]);
        _atacadista = AlterarTipo<string>(leitor["Atacadista"]);
        _bairro = AlterarTipo<string>(leitor["Bairro"]);
        _baseicst = AlterarTipo<decimal?>(leitor["Baseicst"]);
        _bloqueioedicao = AlterarTipo<string>(leitor["Bloqueioedicao"]);
        _calcbaseicmsaliqredentimp = AlterarTipo<string>(leitor["Calcbaseicmsaliqredentimp"]);
        _calccredicmcustocont = AlterarTipo<string>(leitor["Calccredicmcustocont"]);
        _calccredicms = AlterarTipo<string>(leitor["Calccredicms"]);
        _calccredpiscofins = AlterarTipo<string>(leitor["Calccredpiscofins"]);
        _calccredpiscustocont = AlterarTipo<string>(leitor["Calccredpiscustocont"]);
        _calcdescarga = AlterarTipo<string>(leitor["Calcdescarga"]);
        _calcdespfinprazopgto = AlterarTipo<string>(leitor["Calcdespfinprazopgto"]);
        _cep = AlterarTipo<string>(leitor["Cep"]);
        _cgc = AlterarTipo<string>(leitor["Cgc"]);
        _cgcfilial = AlterarTipo<string>(leitor["Cgcfilial"]);
        _chavecte = AlterarTipo<string>(leitor["Chavecte"]);
        _chavenfe = AlterarTipo<string>(leitor["Chavenfe"]);
        _chavenfeprodrural = AlterarTipo<string>(leitor["Chavenfeprodrural"]);
        _codcont = AlterarTipo<decimal>(leitor["Codcont"]);
        _codcontabfornec = AlterarTipo<decimal?>(leitor["Codcontabfornec"]);
        _codcontfor = AlterarTipo<decimal?>(leitor["Codcontfor"]);
        _codcontfre = AlterarTipo<decimal?>(leitor["Codcontfre"]);
        _coddevol = AlterarTipo<decimal?>(leitor["Coddevol"]);
        _codentveiculo = AlterarTipo<decimal?>(leitor["Codentveiculo"]);
        _codexportador = AlterarTipo<decimal?>(leitor["Codexportador"]);
        _codfilial = AlterarTipo<string>(leitor["Codfilial"]);
        _codfilialnf = AlterarTipo<string>(leitor["Codfilialnf"]);
        _codfiscal = AlterarTipo<decimal>(leitor["Codfiscal"]);
        _codfiscalfrete = AlterarTipo<decimal?>(leitor["Codfiscalfrete"]);
        _codfiscaloutrasdesp = AlterarTipo<decimal?>(leitor["Codfiscaloutrasdesp"]);
        _codforfilial = AlterarTipo<decimal?>(leitor["Codforfilial"]);
        _codfornec = AlterarTipo<decimal>(leitor["Codfornec"]);
        _codfornecfrete = AlterarTipo<decimal?>(leitor["Codfornecfrete"]);
        _codfornecnf = AlterarTipo<decimal?>(leitor["Codfornecnf"]);
        _codfuncenvio = AlterarTipo<decimal?>(leitor["Codfuncenvio"]);
        _codfuncenviowms = AlterarTipo<decimal?>(leitor["Codfuncenviowms"]);
        _codfuncexparqol = AlterarTipo<decimal?>(leitor["Codfuncexparqol"]);
        _codfuncexpintwms = AlterarTipo<decimal?>(leitor["Codfuncexpintwms"]);
        _codfunclanc = AlterarTipo<decimal?>(leitor["Codfunclanc"]);
        _codibge = AlterarTipo<decimal?>(leitor["Codibge"]);
        _codigoclasseconsumoenergia = AlterarTipo<string>(leitor["Codigoclasseconsumoenergia"]);
        _codigogrupotensaoenergia = AlterarTipo<string>(leitor["Codigogrupotensaoenergia"]);
        _codmotoristadevol = AlterarTipo<decimal?>(leitor["Codmotoristadevol"]);
        _codmunicipio = AlterarTipo<decimal?>(leitor["Codmunicipio"]);
        _codpais = AlterarTipo<decimal?>(leitor["Codpais"]);
        _codprofissional = AlterarTipo<decimal?>(leitor["Codprofissional"]);
        _codreceitarecolhim = AlterarTipo<string>(leitor["Codreceitarecolhim"]);
        _codrotinadesbloqueio = AlterarTipo<decimal?>(leitor["Codrotinadesbloqueio"]);
        _codtribpiscofins = AlterarTipo<decimal?>(leitor["Codtribpiscofins"]);
        _codusurdevol = AlterarTipo<decimal?>(leitor["Codusurdevol"]);
        _conciliacao = AlterarTipo<string>(leitor["Conciliacao"]);
        _conferido = AlterarTipo<string>(leitor["Conferido"]);
        _consideraipinofretefob = AlterarTipo<string>(leitor["Consideraipinofretefob"]);
        _considerariipunit = AlterarTipo<string>(leitor["Considerariipunit"]);
        _consstnfpiscofins = AlterarTipo<string>(leitor["Consstnfpiscofins"]);
        _consumidorfinal = AlterarTipo<string>(leitor["Consumidorfinal"]);
        _consumiunumnfe = AlterarTipo<string>(leitor["Consumiunumnfe"]);
        _datadiimportacao = AlterarTipo<DateTime?>(leitor["Datadiimportacao"]);
        _dataexparqol = AlterarTipo<DateTime?>(leitor["Dataexparqol"]);
        _dedfretecifcredpresicms = AlterarTipo<string>(leitor["Dedfretecifcredpresicms"]);
        _descpais = AlterarTipo<string>(leitor["Descpais"]);
        _despesasrateada = AlterarTipo<string>(leitor["Despesasrateada"]);
        _devsimbolica = AlterarTipo<string>(leitor["Devsimbolica"]);
        _dtahoraentradacontigencia = AlterarTipo<DateTime?>(leitor["Dtahoraentradacontigencia"]);
        _dta_horaenviosefaz = AlterarTipo<DateTime?>(leitor["Dta_Horaenviosefaz"]);
        _dtconcil = AlterarTipo<DateTime?>(leitor["Dtconcil"]);
        _dtdescarga = AlterarTipo<DateTime?>(leitor["Dtdescarga"]);
        _dtemissao = AlterarTipo<DateTime>(leitor["Dtemissao"]);
        _dtemissaodeclaracao = AlterarTipo<DateTime?>(leitor["Dtemissaodeclaracao"]);
        _dtemissaonfvenda = AlterarTipo<DateTime?>(leitor["Dtemissaonfvenda"]);
        _dtemissaoprodrural = AlterarTipo<DateTime?>(leitor["Dtemissaoprodrural"]);
        _dtent = AlterarTipo<DateTime>(leitor["Dtent"]);
        _dtenviowms = AlterarTipo<DateTime?>(leitor["Dtenviowms"]);
        _dtexportacaowms = AlterarTipo<DateTime?>(leitor["Dtexportacaowms"]);
        _dthoraautorizacaosefaz = AlterarTipo<DateTime?>(leitor["Dthoraautorizacaosefaz"]);
        _dthoracancelamentosefaz = AlterarTipo<DateTime?>(leitor["Dthoracancelamentosefaz"]);
        _dthoranfe = AlterarTipo<DateTime?>(leitor["Dthoranfe"]);
        _dthorarecibodpec = AlterarTipo<DateTime?>(leitor["Dthorarecibodpec"]);
        _dtimportacaowms = AlterarTipo<DateTime?>(leitor["Dtimportacaowms"]);
        _dtlancto = AlterarTipo<DateTime?>(leitor["Dtlancto"]);
        _dtnsu = AlterarTipo<DateTime?>(leitor["Dtnsu"]);
        _dtproxatu = AlterarTipo<DateTime?>(leitor["Dtproxatu"]);
        _dtsaida = AlterarTipo<DateTime?>(leitor["Dtsaida"]);
        _dtselofiscal = AlterarTipo<DateTime?>(leitor["Dtselofiscal"]);
        _dtterminociap = AlterarTipo<DateTime?>(leitor["Dtterminociap"]);
        _dtvencstforanf = AlterarTipo<DateTime?>(leitor["Dtvencstforanf"]);
        _dtwms = AlterarTipo<DateTime?>(leitor["Dtwms"]);
        _emaildest = AlterarTipo<string>(leitor["Emaildest"]);
        _emissaopropria = AlterarTipo<string>(leitor["Emissaopropria"]);
        _endereco = AlterarTipo<string>(leitor["Endereco"]);
        _entradatipoi = AlterarTipo<string>(leitor["Entradatipoi"]);
        _enviada = AlterarTipo<string>(leitor["Enviada"]);
        _enviadanfe = AlterarTipo<string>(leitor["Enviadanfe"]);
        _enviadoemailcancelado = AlterarTipo<string>(leitor["Enviadoemailcancelado"]);
        _equiplanc = AlterarTipo<string>(leitor["Equiplanc"]);
        _especie = AlterarTipo<string>(leitor["Especie"]);
        _especievolume = AlterarTipo<string>(leitor["Especievolume"]);
        _estcomissaorca = AlterarTipo<string>(leitor["Estcomissaorca"]);
        _exportado = AlterarTipo<string>(leitor["Exportado"]);
        _fechamentoceautomatico = AlterarTipo<string>(leitor["Fechamentoceautomatico"]);
        _finalidadenfe = AlterarTipo<string>(leitor["Finalidadenfe"]);
        _folhalivro_entrada = AlterarTipo<decimal?>(leitor["Folhalivro_Entrada"]);
        _fornecedor = AlterarTipo<string>(leitor["Fornecedor"]);
        _funclanc = AlterarTipo<string>(leitor["Funclanc"]);
        _geranfdevcli = AlterarTipo<string>(leitor["Geranfdevcli"]);
        _geranfvenda = AlterarTipo<string>(leitor["Geranfvenda"]);
        _historico = AlterarTipo<string>(leitor["Historico"]);
        _horalanc = AlterarTipo<string>(leitor["Horalanc"]);
        _ie = AlterarTipo<string>(leitor["Ie"]);
        _iefilial = AlterarTipo<string>(leitor["Iefilial"]);
        _iesubsttribut = AlterarTipo<string>(leitor["Iesubsttribut"]);
        _incluirimpostosnftranspimp = AlterarTipo<string>(leitor["Incluirimpostosnftranspimp"]);
        _industrialocal = AlterarTipo<string>(leitor["Industrialocal"]);
        _justificativacontigencia = AlterarTipo<string>(leitor["Justificativacontigencia"]);
        _localdesembaraco = AlterarTipo<string>(leitor["Localdesembaraco"]);
        _lotedigitado = AlterarTipo<string>(leitor["Lotedigitado"]);
        _lotedpec = AlterarTipo<string>(leitor["Lotedpec"]);
        _marcavolume = AlterarTipo<string>(leitor["Marcavolume"]);
        _minutolanc = AlterarTipo<string>(leitor["Minutolanc"]);
        _modelo = AlterarTipo<string>(leitor["Modelo"]);
        _modeloprodrural = AlterarTipo<string>(leitor["Modeloprodrural"]);
        _motestornonfe = AlterarTipo<string>(leitor["Motestornonfe"]);
        _movestoqueimport = AlterarTipo<string>(leitor["Movestoqueimport"]);
        _municipio = AlterarTipo<string>(leitor["Municipio"]);
        _natopernfe = AlterarTipo<string>(leitor["Natopernfe"]);
        _nfentregafutura = AlterarTipo<string>(leitor["Nfentregafutura"]);
        _nfextemporanea = AlterarTipo<string>(leitor["Nfextemporanea"]);
        _normaregespecial = AlterarTipo<string>(leitor["Normaregespecial"]);
        _nsu = AlterarTipo<decimal?>(leitor["Nsu"]);
        _numaplic = AlterarTipo<decimal?>(leitor["Numaplic"]);
        _numbonus = AlterarTipo<decimal?>(leitor["Numbonus"]);
        _numcontrato = AlterarTipo<decimal?>(leitor["Numcontrato"]);
        _numdiimportacao = AlterarTipo<string>(leitor["Numdiimportacao"]);
        _numentmex = AlterarTipo<decimal?>(leitor["Numentmex"]);
        _numeroend = AlterarTipo<string>(leitor["Numeroend"]);
        _numformulario = AlterarTipo<decimal?>(leitor["Numformulario"]);
        _numidf = AlterarTipo<string>(leitor["Numidf"]);
        _numlivro_entrada = AlterarTipo<string>(leitor["Numlivro_Entrada"]);
        _numlotenfe = AlterarTipo<string>(leitor["Numlotenfe"]);
        _numnegociacao = AlterarTipo<decimal?>(leitor["Numnegociacao"]);
        _numnota = AlterarTipo<decimal>(leitor["Numnota"]);
        _numnotaentfutura = AlterarTipo<decimal?>(leitor["Numnotaentfutura"]);
        _numnotaprodrural = AlterarTipo<decimal?>(leitor["Numnotaprodrural"]);
        _numnotavenda = AlterarTipo<decimal?>(leitor["Numnotavenda"]);
        _numop = AlterarTipo<decimal?>(leitor["Numop"]);
        _numos = AlterarTipo<decimal?>(leitor["Numos"]);
        _numparcdevol = AlterarTipo<decimal?>(leitor["Numparcdevol"]);
        _numselonf = AlterarTipo<decimal?>(leitor["Numselonf"]);
        _numseqenvio = AlterarTipo<decimal?>(leitor["Numseqenvio"]);
        _numtab = AlterarTipo<decimal?>(leitor["Numtab"]);
        _numtransbenefic = AlterarTipo<decimal?>(leitor["Numtransbenefic"]);
        _numtransent = AlterarTipo<decimal>(leitor["Numtransent"]);
        _numtransorigem = AlterarTipo<decimal?>(leitor["Numtransorigem"]);
        _numtransvendaorig = AlterarTipo<decimal?>(leitor["Numtransvendaorig"]);
        _numtransvendatroca = AlterarTipo<decimal?>(leitor["Numtransvendatroca"]);
        _numvias = AlterarTipo<decimal?>(leitor["Numvias"]);
        _numvol = AlterarTipo<decimal?>(leitor["Numvol"]);
        _numvolume = AlterarTipo<string>(leitor["Numvolume"]);
        _obs = AlterarTipo<string>(leitor["Obs"]);
        _obslivrofiscal = AlterarTipo<string>(leitor["Obslivrofiscal"]);
        _obsnfe = AlterarTipo<string>(leitor["Obsnfe"]);
        _obspiscofins = AlterarTipo<string>(leitor["Obspiscofins"]);
        _obs1 = AlterarTipo<string>(leitor["Obs1"]);
        _obs2 = AlterarTipo<string>(leitor["Obs2"]);
        _perbaseredoutrasdesp = AlterarTipo<decimal?>(leitor["Perbaseredoutrasdesp"]);
        _percaltercustoent = AlterarTipo<decimal?>(leitor["Percaltercustoent"]);
        _percicmfrete = AlterarTipo<decimal?>(leitor["Percicmfrete"]);
        _percicmsfretefobst = AlterarTipo<decimal?>(leitor["Percicmsfretefobst"]);
        _percofins = AlterarTipo<decimal?>(leitor["Percofins"]);
        _percpisred = AlterarTipo<decimal?>(leitor["Percpisred"]);
        _perdescfin = AlterarTipo<decimal?>(leitor["Perdescfin"]);
        _perpis = AlterarTipo<decimal?>(leitor["Perpis"]);
        _pesofretefob = AlterarTipo<decimal?>(leitor["Pesofretefob"]);
        _placaveiculo = AlterarTipo<string>(leitor["Placaveiculo"]);
        _possecodfornec = AlterarTipo<decimal?>(leitor["Possecodfornec"]);
        _prazo = AlterarTipo<decimal?>(leitor["Prazo"]);
        _protocolocancelamento = AlterarTipo<string>(leitor["Protocolocancelamento"]);
        _protocolonfe = AlterarTipo<string>(leitor["Protocolonfe"]);
        _protocolonfeauto = AlterarTipo<string>(leitor["Protocolonfeauto"]);
        _protocolonfecan = AlterarTipo<string>(leitor["Protocolonfecan"]);
        _rateiopesoliq = AlterarTipo<string>(leitor["Rateiopesoliq"]);
        _rebaixacustocomdescfin = AlterarTipo<string>(leitor["Rebaixacustocomdescfin"]);
        _recibodpec = AlterarTipo<string>(leitor["Recibodpec"]);
        _recibonfe = AlterarTipo<string>(leitor["Recibonfe"]);
        _remessaunica = AlterarTipo<string>(leitor["Remessaunica"]);
        _revenda = AlterarTipo<string>(leitor["Revenda"]);
        _rotinalanc = AlterarTipo<string>(leitor["Rotinalanc"]);
        _serie = AlterarTipo<string>(leitor["Serie"]);
        _serienfvenda = AlterarTipo<string>(leitor["Serienfvenda"]);
        _serieoriginal = AlterarTipo<string>(leitor["Serieoriginal"]);
        _serieprodrural = AlterarTipo<string>(leitor["Serieprodrural"]);
        _simplesnacional = AlterarTipo<string>(leitor["Simplesnacional"]);
        _sitdocpiscofins = AlterarTipo<string>(leitor["Sitdocpiscofins"]);
        _situacaonfe = AlterarTipo<decimal?>(leitor["Situacaonfe"]);
        _somarpiscofinsvloutrasdespimp = AlterarTipo<string>(leitor["Somarpiscofinsvloutrasdespimp"]);
        _somarvloutrasdespaduaneiras = AlterarTipo<string>(leitor["Somarvloutrasdespaduaneiras"]);
        _telefone = AlterarTipo<string>(leitor["Telefone"]);
        _tempoapro = AlterarTipo<decimal?>(leitor["Tempoapro"]);
        _tempodescarga = AlterarTipo<decimal?>(leitor["Tempodescarga"]);
        _tentativaenvionfe = AlterarTipo<decimal?>(leitor["Tentativaenvionfe"]);
        _tipoaliqoutrasdesp = AlterarTipo<string>(leitor["Tipoaliqoutrasdesp"]);
        _tipodescarga = AlterarTipo<string>(leitor["Tipodescarga"]);
        _tipoemissao = AlterarTipo<string>(leitor["Tipoemissao"]);
        _tipoemissaocte = AlterarTipo<string>(leitor["Tipoemissaocte"]);
        _tipofj = AlterarTipo<string>(leitor["Tipofj"]);
        _tipofornec = AlterarTipo<string>(leitor["Tipofornec"]);
        _tipofreteciffob = AlterarTipo<string>(leitor["Tipofreteciffob"]);
        _tipoligacaoenergia = AlterarTipo<string>(leitor["Tipoligacaoenergia"]);
        _tiponotafiscalbrinde = AlterarTipo<string>(leitor["Tiponotafiscalbrinde"]);
        _tipotribentimp = AlterarTipo<string>(leitor["Tipotribentimp"]);
        _totalpesoliqdi = AlterarTipo<decimal?>(leitor["Totalpesoliqdi"]);
        _totdifaliquotas = AlterarTipo<decimal?>(leitor["Totdifaliquotas"]);
        _totpeso = AlterarTipo<decimal?>(leitor["Totpeso"]);
        _totpesoliq = AlterarTipo<decimal?>(leitor["Totpesoliq"]);
        _uf = AlterarTipo<string>(leitor["Uf"]);
        _ufcodigo = AlterarTipo<string>(leitor["Ufcodigo"]);
        _ufdesembaraco = AlterarTipo<string>(leitor["Ufdesembaraco"]);
        _uffilial = AlterarTipo<string>(leitor["Uffilial"]);
        _ufveiculo = AlterarTipo<string>(leitor["Ufveiculo"]);
        _usacredpiscofinsentbonific = AlterarTipo<string>(leitor["Usacredpiscofinsentbonific"]);
        _usaintegracaowms = AlterarTipo<string>(leitor["Usaintegracaowms"]);
        _usaoutrasdespseguropiscofins = AlterarTipo<string>(leitor["Usaoutrasdespseguropiscofins"]);
        _utilizaipicalcicms = AlterarTipo<string>(leitor["Utilizaipicalcicms"]);
        _utilizaoutdespcalcsuframa = AlterarTipo<string>(leitor["Utilizaoutdespcalcsuframa"]);
        _vladuaneira = AlterarTipo<decimal?>(leitor["Vladuaneira"]);
        _vlbase = AlterarTipo<decimal?>(leitor["Vlbase"]);
        _vlbasecofins = AlterarTipo<decimal?>(leitor["Vlbasecofins"]);
        _vlbaseipi = AlterarTipo<decimal?>(leitor["Vlbaseipi"]);
        _vlbasepis = AlterarTipo<decimal?>(leitor["Vlbasepis"]);
        _vlbonific = AlterarTipo<decimal?>(leitor["Vlbonific"]);
        _vlcofins = AlterarTipo<decimal?>(leitor["Vlcofins"]);
        _vlcredcofins = AlterarTipo<decimal?>(leitor["Vlcredcofins"]);
        _vlcredpis = AlterarTipo<decimal?>(leitor["Vlcredpis"]);
        _vlcsrf = AlterarTipo<decimal?>(leitor["Vlcsrf"]);
        _vldescfin = AlterarTipo<decimal?>(leitor["Vldescfin"]);
        _vldesconto = AlterarTipo<decimal?>(leitor["Vldesconto"]);
        _vldespdentronf = AlterarTipo<decimal?>(leitor["Vldespdentronf"]);
        _vlfrete = AlterarTipo<decimal?>(leitor["Vlfrete"]);
        _vlicms = AlterarTipo<decimal?>(leitor["Vlicms"]);
        _vlinss = AlterarTipo<decimal?>(leitor["Vlinss"]);
        _vlipi = AlterarTipo<decimal?>(leitor["Vlipi"]);
        _vlirrf = AlterarTipo<decimal?>(leitor["Vlirrf"]);
        _vlisentas = AlterarTipo<decimal?>(leitor["Vlisentas"]);
        _vliss = AlterarTipo<decimal?>(leitor["Vliss"]);
        _vloutras = AlterarTipo<decimal?>(leitor["Vloutras"]);
        _vloutrasdespimp = AlterarTipo<decimal?>(leitor["Vloutrasdespimp"]);
        _vlpedagio = AlterarTipo<decimal?>(leitor["Vlpedagio"]);
        _vlpis = AlterarTipo<decimal?>(leitor["Vlpis"]);
        _vlseguro = AlterarTipo<decimal?>(leitor["Vlseguro"]);
        _vlsestsenat = AlterarTipo<decimal?>(leitor["Vlsestsenat"]);
        _vlsiscomex = AlterarTipo<decimal?>(leitor["Vlsiscomex"]);
        _vlst = AlterarTipo<decimal?>(leitor["Vlst"]);
        _vltotal = AlterarTipo<decimal?>(leitor["Vltotal"]);
        _vltotalfretefob = AlterarTipo<decimal?>(leitor["Vltotalfretefob"]);
        _vltotalipi = AlterarTipo<decimal?>(leitor["Vltotalipi"]);
        _vltotger = AlterarTipo<decimal?>(leitor["Vltotger"]);
        _vlverbacmv = AlterarTipo<decimal?>(leitor["Vlverbacmv"]);
        _vlverbacmvcli = AlterarTipo<decimal?>(leitor["Vlverbacmvcli"]);
        _wmscodfuncignora = AlterarTipo<decimal?>(leitor["Wmscodfuncignora"]);
        _wmsignorado = AlterarTipo<string>(leitor["Wmsignorado"]);
        _numtransintegracao = AlterarTipo<string>(leitor["Numtransintegracao"]);
    }

}