

////// namespace nwErp.Entidades.Winthor;

// namespace nwErp.Api.Modelos;

[Serializable]
public class PCCLIENT : GerenteDePropriedades, IEntidade
{
    private static readonly string RO_ACEITACHTERCEIROS = "Aceitachterceiros";

    private string _aceitachterceiros;

    private static readonly string RO_ACEITASIMILAR = "Aceitasimilar";

    private string _aceitasimilar;

    private static readonly string RO_ACEITATROCANEGATIVA = "Aceitatrocanegativa";

    private string _aceitatrocanegativa;

    private static readonly string RO_ACEITAVENDAFRACAO = "Aceitavendafracao";

    private string _aceitavendafracao;

    private static readonly string RO_AGREGARVALORSTDESCFIN = "Agregarvalorstdescfin";

    private string _agregarvalorstdescfin;

    private static readonly string RO_ALIQICMS1 = "Aliqicms1";

    private decimal? _aliqicms1;

    private static readonly string RO_ANALISECRED = "Analisecred";

    private string _analisecred;

    private static readonly string RO_ANVISA = "Anvisa";

    private string _anvisa;

    private static readonly string RO_APLICADESCNF = "Aplicadescnf";

    private string _aplicadescnf;

    private static readonly string RO_AREALOJAM2 = "Arealojam2";

    private decimal? _arealojam2;

    private static readonly string RO_ATENDEDOMINGO = "Atendedomingo";

    private string _atendedomingo;

    private static readonly string RO_ATENDEQUARTA = "Atendequarta";

    private string _atendequarta;

    private static readonly string RO_ATENDEQUINTA = "Atendequinta";

    private string _atendequinta;

    private static readonly string RO_ATENDESABADO = "Atendesabado";

    private string _atendesabado;

    private static readonly string RO_ATENDESEGUNDA = "Atendesegunda";

    private string _atendesegunda;

    private static readonly string RO_ATENDESEXTA = "Atendesexta";

    private string _atendesexta;

    private static readonly string RO_ATENDETERCA = "Atendeterca";

    private string _atendeterca;

    private static readonly string RO_ATUALIZASALDOCCDESCFIN = "Atualizasaldoccdescfin";

    private string _atualizasaldoccdescfin;

    private static readonly string RO_BAIRROCOB = "Bairrocob";

    private string _bairrocob;

    private static readonly string RO_BAIRROCOM = "Bairrocom";

    private string _bairrocom;

    private static readonly string RO_BAIRROENT = "Bairroent";

    private string _bairroent;

    private static readonly string RO_BLOQUEIO = "Bloqueio";

    private string _bloqueio;

    private static readonly string RO_BLOQUEIODATACHEQ = "Bloqueiodatacheq";

    private string _bloqueiodatacheq;

    private static readonly string RO_BLOQUEIODEFINITIVO = "Bloqueiodefinitivo";

    private string _bloqueiodefinitivo;

    private static readonly string RO_BLOQUEIOSEFAZ = "Bloqueiosefaz";

    private string _bloqueiosefaz;

    private static readonly string RO_BLOQUEIOSEFAZPED = "Bloqueiosefazped";

    private string _bloqueiosefazped;

    private static readonly string RO_BLOQVENDAPF = "Bloqvendapf";

    private string _bloqvendapf;

    private static readonly string RO_CACEX = "Cacex";

    private string _cacex;

    private static readonly string RO_CAIXAPOSTAL = "Caixapostal";

    private decimal? _caixapostal;

    private static readonly string RO_CALCULAST = "Calculast";

    private string _calculast;

    private static readonly string RO_CAPITALSOCIAL = "Capitalsocial";

    private decimal? _capitalsocial;

    private static readonly string RO_CARGO = "Cargo";

    private string _cargo;

    private static readonly string RO_CARGOCONJUGE = "Cargoconjuge";

    private string _cargoconjuge;

    private static readonly string RO_CEPCOB = "Cepcob";

    private string _cepcob;

    private static readonly string RO_CEPCOM = "Cepcom";

    private string _cepcom;

    private static readonly string RO_CEPCXPOSTAL = "Cepcxpostal";

    private decimal? _cepcxpostal;

    private static readonly string RO_CEPENT = "Cepent";

    private string _cepent;

    private static readonly string RO_CGCENT = "Cgcent";

    private string _cgcent;

    private static readonly string RO_CGCENTREGA = "Cgcentrega";

    private string _cgcentrega;

    private static readonly string RO_CGEENTAUX = "Cgeentaux";

    private string _cgeentaux;

    private static readonly string RO_CLASSECOMERCIAL = "Classecomercial";

    private string _classecomercial;

    private static readonly string RO_CLASSEMC = "Classemc";

    private string _classemc;

    private static readonly string RO_CLASSEVENDA = "Classevenda";

    private string _classevenda;

    private static readonly string RO_CLIENTE = "Cliente";

    private string _cliente;

    private static readonly string RO_CLIENTEDAN = "Clientedan";

    private string _clientedan;

    private static readonly string RO_CLIENTEELETRO = "Clienteeletro";

    private string _clienteeletro;

    private static readonly string RO_CLIENTEFONTEST = "Clientefontest";

    private string _clientefontest;

    private static readonly string RO_CLIENTEMONITORADO = "Clientemonitorado";

    private string _clientemonitorado;

    private static readonly string RO_CLIENTE2 = "Cliente2";

    private string _cliente2;

    private static readonly string RO_CLIENTPROTESTO = "Clientprotesto";

    private string _clientprotesto;

    private static readonly string RO_CNPJCISP = "Cnpjcisp";

    private string _cnpjcisp;

    private static readonly string RO_CODATV1 = "Codatv1";

    private decimal? _codatv1;

    private static readonly string RO_CODBAIRROCOB = "Codbairrocob";

    private decimal? _codbairrocob;

    private static readonly string RO_CODBAIRROCOM = "Codbairrocom";

    private decimal? _codbairrocom;

    private static readonly string RO_CODBAIRROENT = "Codbairroent";

    private decimal? _codbairroent;

    private static readonly string RO_CODBARRA = "Codbarra";

    private decimal? _codbarra;

    private static readonly string RO_CODBARRACOB = "Codbarracob";

    private decimal? _codbarracob;

    private static readonly string RO_CODBARRAENT = "Codbarraent";

    private decimal? _codbarraent;

    private static readonly string RO_CODCANAL = "Codcanal";

    private decimal? _codcanal;

    private static readonly string RO_CODCIDADE = "Codcidade";

    private decimal? _codcidade;

    private static readonly string RO_CODCLI = "Codcli";

    private decimal _codcli;

    private static readonly string RO_CODCLIINT = "Codcliint";

    private decimal? _codcliint;

    private static readonly string RO_CODCLIPALM = "Codclipalm";

    private decimal? _codclipalm;

    private static readonly string RO_CODCLIPRINC = "Codcliprinc";

    private decimal? _codcliprinc;

    private static readonly string RO_CODCLIWEB = "Codcliweb";

    private decimal? _codcliweb;

    private static readonly string RO_CODCNAE = "Codcnae";

    private string _codcnae;

    private static readonly string RO_CODCOB = "Codcob";

    private string _codcob;

    private static readonly string RO_CODCOBTV1 = "Codcobtv1";

    private string _codcobtv1;

    private static readonly string RO_CODCOBTV3 = "Codcobtv3";

    private string _codcobtv3;

    private static readonly string RO_CODCONDICAOVENDA = "Codcondicaovenda";

    private decimal? _codcondicaovenda;

    private static readonly string RO_CODCONTAB = "Codcontab";

    private string _codcontab;

    private static readonly string RO_CODFILIALESTOQUE = "Codfilialestoque";

    private string _codfilialestoque;

    private static readonly string RO_CODFILIALNF = "Codfilialnf";

    private string _codfilialnf;

    private static readonly string RO_CODFORNECFRETE = "Codfornecfrete";

    private decimal? _codfornecfrete;

    private static readonly string RO_CODFUNCCAD = "Codfunccad";

    private decimal? _codfunccad;

    private static readonly string RO_CODFUNCCADASTRO = "Codfunccadastro";

    private decimal? _codfunccadastro;

    private static readonly string RO_CODFUNCLANCPOTENCIALLIMCRED = "Codfunclancpotenciallimcred";

    private decimal? _codfunclancpotenciallimcred;

    private static readonly string RO_CODFUNCULTALTER = "Codfuncultalter";

    private decimal? _codfuncultalter;

    private static readonly string RO_CODFUNCULTALTERCLIESP = "Codfuncultaltercliesp";

    private decimal? _codfuncultaltercliesp;

    private static readonly string RO_CODFUNCULTCONTATOCOB = "Codfuncultcontatocob";

    private decimal? _codfuncultcontatocob;

    private static readonly string RO_CODGLN = "Codgln";

    private decimal? _codgln;

    private static readonly string RO_CODHIST = "Codhist";

    private decimal? _codhist;

    private static readonly string RO_CODMUNICIPIO = "Codmunicipio";

    private decimal? _codmunicipio;

    private static readonly string RO_CODNILSEN = "Codnilsen";

    private string _codnilsen;

    private static readonly string RO_CODPAIS = "Codpais";

    private decimal? _codpais;

    private static readonly string RO_CODPLPAG = "Codplpag";

    private decimal? _codplpag;

    private static readonly string RO_CODPLPAGETICO = "Codplpagetico";

    private decimal? _codplpagetico;

    private static readonly string RO_CODPLPAGGENERICO = "Codplpaggenerico";

    private decimal? _codplpaggenerico;

    private static readonly string RO_CODPLPAGPADRAO = "Codplpagpadrao";

    private decimal? _codplpagpadrao;

    private static readonly string RO_CODPLPAG2 = "Codplpag2";

    private decimal? _codplpag2;

    private static readonly string RO_CODPRACA = "Codpraca";

    private decimal _codpraca;

    private static readonly string RO_CODPRACACOB = "Codpracacob";

    private decimal? _codpracacob;

    private static readonly string RO_CODPROFISSIONAL = "Codprofissional";

    private decimal? _codprofissional;

    private static readonly string RO_CODREDE = "Codrede";

    private decimal? _codrede;

    private static readonly string RO_CODSTATUSCOB = "Codstatuscob";

    private decimal? _codstatuscob;

    private static readonly string RO_CODSUFRAMA = "Codsuframa";

    private string _codsuframa;

    private static readonly string RO_CODUSUR1 = "Codusur1";

    private decimal? _codusur1;

    private static readonly string RO_CODUSUR2 = "Codusur2";

    private decimal? _codusur2;

    private static readonly string RO_CODUSUR3 = "Codusur3";

    private decimal? _codusur3;

    private static readonly string RO_COMPLEMENTOCOB = "Complementocob";

    private string _complementocob;

    private static readonly string RO_COMPLEMENTOCOM = "Complementocom";

    private string _complementocom;

    private static readonly string RO_COMPLEMENTOENT = "Complementoent";

    private string _complementoent;

    private static readonly string RO_CONDVENDA1 = "Condvenda1";

    private string _condvenda1;

    private static readonly string RO_CONDVENDA10 = "Condvenda10";

    private string _condvenda10;

    private static readonly string RO_CONDVENDA11 = "Condvenda11";

    private string _condvenda11;

    private static readonly string RO_CONDVENDA12 = "Condvenda12";

    private string _condvenda12;

    private static readonly string RO_CONDVENDA13 = "Condvenda13";

    private string _condvenda13;

    private static readonly string RO_CONDVENDA14 = "Condvenda14";

    private string _condvenda14;

    private static readonly string RO_CONDVENDA2 = "Condvenda2";

    private string _condvenda2;

    private static readonly string RO_CONDVENDA20 = "Condvenda20";

    private string _condvenda20;

    private static readonly string RO_CONDVENDA3 = "Condvenda3";

    private string _condvenda3;

    private static readonly string RO_CONDVENDA4 = "Condvenda4";

    private string _condvenda4;

    private static readonly string RO_CONDVENDA5 = "Condvenda5";

    private string _condvenda5;

    private static readonly string RO_CONDVENDA6 = "Condvenda6";

    private string _condvenda6;

    private static readonly string RO_CONDVENDA7 = "Condvenda7";

    private string _condvenda7;

    private static readonly string RO_CONDVENDA8 = "Condvenda8";

    private string _condvenda8;

    private static readonly string RO_CONDVENDA9 = "Condvenda9";

    private string _condvenda9;

    private static readonly string RO_CONDVENDA98 = "Condvenda98";

    private string _condvenda98;

    private static readonly string RO_CONDVENDA99 = "Condvenda99";

    private string _condvenda99;

    private static readonly string RO_CONSUMIDORFINAL = "Consumidorfinal";

    private string _consumidorfinal;

    private static readonly string RO_CONTAGEMESTOQUE = "Contagemestoque";

    private string _contagemestoque;

    private static readonly string RO_CONTRIBUINTE = "Contribuinte";

    private string _contribuinte;

    private static readonly string RO_CPFCONJUGE = "Cpfconjuge";

    private string _cpfconjuge;

    private static readonly string RO_CRF = "Crf";

    private string _crf;

    private static readonly string RO_DATACOLETA = "Datacoleta";

    private DateTime? _datacoleta;

    private static readonly string RO_DATACONSULTASINTEGRA = "Dataconsultasintegra";

    private DateTime? _dataconsultasintegra;

    private static readonly string RO_DDDINTERNACIONAL = "Dddinternacional";

    private decimal? _dddinternacional;

    private static readonly string RO_DESCPRODUTO = "Descproduto";

    private string _descproduto;

    private static readonly string RO_DESTACAFRETE = "Destacafrete";

    private string _destacafrete;

    private static readonly string RO_DIASEMANA = "Diasemana";

    private string _diasemana;

    private static readonly string RO_DIGAGENCIA1 = "Digagencia1";

    private string _digagencia1;

    private static readonly string RO_DIGAGENCIA2 = "Digagencia2";

    private string _digagencia2;

    private static readonly string RO_DIRETORIOCLIENTE = "Diretoriocliente";

    private string _diretoriocliente;

    private static readonly string RO_DIRETORIOCONTRATO = "Diretoriocontrato";

    private string _diretoriocontrato;

    private static readonly string RO_DTABERTCC1 = "Dtabertcc1";

    private DateTime? _dtabertcc1;

    private static readonly string RO_DTABERTCC2 = "Dtabertcc2";

    private DateTime? _dtabertcc2;

    private static readonly string RO_DTADMISSAO = "Dtadmissao";

    private DateTime? _dtadmissao;

    private static readonly string RO_DTADMISSAOCONJUGE = "Dtadmissaoconjuge";

    private DateTime? _dtadmissaoconjuge;

    private static readonly string RO_DTBLOQ = "Dtbloq";

    private DateTime? _dtbloq;

    private static readonly string RO_DTCADASTRO = "Dtcadastro";

    private DateTime _dtcadastro;

    private static readonly string RO_DTCAPITALSOCIAL = "Dtcapitalsocial";

    private DateTime? _dtcapitalsocial;

    private static readonly string RO_DTCLASSIFICAESTRELA = "Dtclassificaestrela";

    private DateTime? _dtclassificaestrela;

    private static readonly string RO_DTCLASSIFICAGRUPO = "Dtclassificagrupo";

    private DateTime? _dtclassificagrupo;

    private static readonly string RO_DTDESBLOQUEIO = "Dtdesbloqueio";

    private DateTime? _dtdesbloqueio;

    private static readonly string RO_DTENQUADRAMENTOMICROEMPRESA = "Dtenquadramentomicroempresa";

    private DateTime? _dtenquadramentomicroempresa;

    private static readonly string RO_DTEXCLUSAO = "Dtexclusao";

    private DateTime? _dtexclusao;

    private static readonly string RO_DTIMPORTINTEGRACAO = "Dtimportintegracao";

    private DateTime? _dtimportintegracao;

    private static readonly string RO_DTINIVISTORIA = "Dtinivistoria";

    private DateTime? _dtinivistoria;

    private static readonly string RO_DTLANCPOTENCIALLIMCRED = "Dtlancpotenciallimcred";

    private DateTime? _dtlancpotenciallimcred;

    private static readonly string RO_DTNASC = "Dtnasc";

    private DateTime? _dtnasc;

    private static readonly string RO_DTNASCCONJ = "Dtnascconj";

    private DateTime? _dtnascconj;

    private static readonly string RO_DTPRIMCOMPRA = "Dtprimcompra";

    private DateTime? _dtprimcompra;

    private static readonly string RO_DTPROXCONTATOCOB = "Dtproxcontatocob";

    private DateTime? _dtproxcontatocob;

    private static readonly string RO_DTPROXVISTORIA = "Dtproxvistoria";

    private DateTime? _dtproxvistoria;

    private static readonly string RO_DTREGLIM = "Dtreglim";

    private DateTime? _dtreglim;

    private static readonly string RO_DTULTALTER = "Dtultalter";

    private DateTime? _dtultalter;

    private static readonly string RO_DTULTALTERCLIESP = "Dtultaltercliesp";

    private DateTime? _dtultaltercliesp;

    private static readonly string RO_DTULTALTERSRVPRC = "Dtultaltersrvprc";

    private DateTime? _dtultaltersrvprc;

    private static readonly string RO_DTULTCOMP = "Dtultcomp";

    private DateTime? _dtultcomp;

    private static readonly string RO_DTULTCOMPNESTLE = "Dtultcompnestle";

    private DateTime? _dtultcompnestle;

    private static readonly string RO_DTULTCONSULTASCI = "Dtultconsultasci";

    private DateTime? _dtultconsultasci;

    private static readonly string RO_DTULTCONSULTASERASA = "Dtultconsultaserasa";

    private DateTime? _dtultconsultaserasa;

    private static readonly string RO_DTULTCONSULTASINTEGRA = "Dtultconsultasintegra";

    private DateTime? _dtultconsultasintegra;

    private static readonly string RO_DTULTCONTATOCOB = "Dtultcontatocob";

    private DateTime? _dtultcontatocob;

    private static readonly string RO_DTULTVISITA = "Dtultvisita";

    private DateTime? _dtultvisita;

    private static readonly string RO_DTVALIDADECONV = "Dtvalidadeconv";

    private DateTime? _dtvalidadeconv;

    private static readonly string RO_DTVALIDADEIBAMA = "Dtvalidadeibama";

    private DateTime? _dtvalidadeibama;

    private static readonly string RO_DTVALIDASEFAZ = "Dtvalidasefaz";

    private DateTime? _dtvalidasefaz;

    private static readonly string RO_DTVENCALVARA = "Dtvencalvara";

    private DateTime? _dtvencalvara;

    private static readonly string RO_DTVENCALVARAANVISA = "Dtvencalvaraanvisa";

    private DateTime? _dtvencalvaraanvisa;

    private static readonly string RO_DTVENCALVARAFUNC = "Dtvencalvarafunc";

    private DateTime? _dtvencalvarafunc;

    private static readonly string RO_DTVENCALVARASUS = "Dtvencalvarasus";

    private DateTime? _dtvencalvarasus;

    private static readonly string RO_DTVENCCRF = "Dtvenccrf";

    private DateTime? _dtvenccrf;

    private static readonly string RO_DTVENCLIMCRED = "Dtvenclimcred";

    private DateTime? _dtvenclimcred;

    private static readonly string RO_DTVENCPRAZOADICIONAL = "Dtvencprazoadicional";

    private DateTime? _dtvencprazoadicional;

    private static readonly string RO_DTVENCSUFRAMA = "Dtvencsuframa";

    private DateTime? _dtvencsuframa;

    private static readonly string RO_EANCOBRANCA = "Eancobranca";

    private decimal? _eancobranca;

    private static readonly string RO_EANENTREGA = "Eanentrega";

    private decimal? _eanentrega;

    private static readonly string RO_EDOCOB = "Edocob";

    private string _edocob;

    private static readonly string RO_EDOCOM = "Edocom";

    private string _edocom;

    private static readonly string RO_EDOENT = "Edoent";

    private string _edoent;

    private static readonly string RO_EMAIL = "Email";

    private string _email;

    private static readonly string RO_EMAILNFE = "Emailnfe";

    private string _emailnfe;

    private static readonly string RO_EMITEDAE = "Emitedae";

    private string _emitedae;

    private static readonly string RO_EMITEDUP = "Emitedup";

    private string _emitedup;

    private static readonly string RO_EMITENTECH = "Emitentech";

    private string _emitentech;

    private static readonly string RO_EMITENTECH2 = "Emitentech2";

    private string _emitentech2;

    private static readonly string RO_EMITEPVENDANFSEMDESC = "Emitepvendanfsemdesc";

    private string _emitepvendanfsemdesc;

    private static readonly string RO_EMPFIXA = "Empfixa";

    private string _empfixa;

    private static readonly string RO_EMPRESA = "Empresa";

    private string _empresa;

    private static readonly string RO_EMPRESACONJUGE = "Empresaconjuge";

    private string _empresaconjuge;

    private static readonly string RO_ENDERCOB = "Endercob";

    private string _endercob;

    private static readonly string RO_ENDERCOM = "Endercom";

    private string _endercom;

    private static readonly string RO_ENDERCONJUGE = "Enderconjuge";

    private string _enderconjuge;

    private static readonly string RO_ENDEREMPR = "Enderempr";

    private string _enderempr;

    private static readonly string RO_ENDERENT = "Enderent";

    private string _enderent;

    private static readonly string RO_ENVIADADOSSERASA = "Enviadadosserasa";

    private string _enviadadosserasa;

    private static readonly string RO_ENVIONFEEMAILCOM = "Envionfeemailcom";

    private string _envionfeemailcom;

    private static readonly string RO_ENVIOPDFNFE = "Enviopdfnfe";

    private string _enviopdfnfe;

    private static readonly string RO_ESTCOB = "Estcob";

    private string _estcob;

    private static readonly string RO_ESTCOM = "Estcom";

    private string _estcom;

    private static readonly string RO_ESTCONJUGE = "Estconjuge";

    private string _estconjuge;

    private static readonly string RO_ESTEMPR = "Estempr";

    private string _estempr;

    private static readonly string RO_ESTENT = "Estent";

    private string _estent;

    private static readonly string RO_EXPORTARDADOSIMS = "Exportardadosims";

    private string _exportardadosims;

    private static readonly string RO_FANTASIA = "Fantasia";

    private string _fantasia;

    private static readonly string RO_FAXCLI = "Faxcli";

    private string _faxcli;

    private static readonly string RO_FAXCOM = "Faxcom";

    private string _faxcom;

    private static readonly string RO_FILIACAOMAE = "Filiacaomae";

    private string _filiacaomae;

    private static readonly string RO_FILIACAOMAECONJ = "Filiacaomaeconj";

    private string _filiacaomaeconj;

    private static readonly string RO_FILIACAOPAI = "Filiacaopai";

    private string _filiacaopai;

    private static readonly string RO_FILIACAOPAICONJ = "Filiacaopaiconj";

    private string _filiacaopaiconj;

    private static readonly string RO_FOCO = "Foco";

    private string _foco;

    private static readonly string RO_FOTOGRAFIASUCESSO = "Fotografiasucesso";

    private string _fotografiasucesso;

    private static readonly string RO_FREQDIAVISITA = "Freqdiavisita";

    private decimal? _freqdiavisita;

    private static readonly string RO_FREQVISITA = "Freqvisita";

    private decimal? _freqvisita;

    private static readonly string RO_FRETEDESPACHO = "Fretedespacho";

    private string _fretedespacho;

    private static readonly string RO_GERARCREDITODEVCLI = "Gerarcreditodevcli";

    private string _gerarcreditodevcli;

    private static readonly string RO_GERATITULOST = "Geratitulost";

    private string _geratitulost;

    private static readonly string RO_GERENCIAMENTO = "Gerenciamento";

    private string _gerenciamento;

    private static readonly string RO_GRUPORAMOATIVI = "Gruporamoativi";

    private string _gruporamoativi;

    private static readonly string RO_HORACADASTRO = "Horacadastro";

    private DateTime? _horacadastro;

    private static readonly string RO_HORAPROXCONTATO = "Horaproxcontato";

    private decimal? _horaproxcontato;

    private static readonly string RO_HORARIORECEB = "Horarioreceb";

    private string _horarioreceb;

    private static readonly string RO_ICMSANTECIP = "Icmsantecip";

    private string _icmsantecip;

    private static readonly string RO_IEENT = "Ieent";

    private string _ieent;

    private static readonly string RO_IEPS = "Ieps";

    private decimal? _ieps;

    private static readonly string RO_IEST = "Iest";

    private string _iest;

    private static readonly string RO_IMENT = "Iment";

    private string _iment;

    private static readonly string RO_IMPORTADOCRM = "Importadocrm";

    private string _importadocrm;

    private static readonly string RO_INCLUINOARQSCI = "Incluinoarqsci";

    private string _incluinoarqsci;

    private static readonly string RO_INICIOATIV = "Inicioativ";

    private DateTime? _inicioativ;

    private static readonly string RO_INSCESTADUAL = "Inscestadual";

    private string _inscestadual;

    private static readonly string RO_INVESTIMENTO = "Investimento";

    private string _investimento;

    private static readonly string RO_ISENCAOSUFRAMA = "Isencaosuframa";

    private string _isencaosuframa;

    private static readonly string RO_ISENTAJUROS = "Isentajuros";

    private string _isentajuros;

    private static readonly string RO_ISENTODIFALIQUOTAS = "Isentodifaliquotas";

    private string _isentodifaliquotas;

    private static readonly string RO_ISENTOICMS = "Isentoicms";

    private string _isentoicms;

    private static readonly string RO_ISENTOIPI = "Isentoipi";

    private string _isentoipi;

    private static readonly string RO_ISENTOTXBOLETO = "Isentotxboleto";

    private string _isentotxboleto;

    private static readonly string RO_IVA = "Iva";

    private decimal? _iva;

    private static readonly string RO_IVAFONTE = "Ivafonte";

    private decimal? _ivafonte;

    private static readonly string RO_LATITUDE = "Latitude";

    private string _latitude;

    private static readonly string RO_LIMCRED = "Limcred";

    private decimal? _limcred;

    private static readonly string RO_LIMCREDCPF = "Limcredcpf";

    private decimal? _limcredcpf;

    private static readonly string RO_LIMITEAUTORI = "Limiteautori";

    private string _limiteautori;

    private static readonly string RO_LISTAPLPAG = "Listaplpag";

    private string _listaplpag;

    private static readonly string RO_LONGITUDE = "Longitude";

    private string _longitude;

    private static readonly string RO_MEDCODFUNCLIBTRIBUT = "Medcodfunclibtribut";

    private decimal? _medcodfunclibtribut;

    private static readonly string RO_MEDDTLIBTRIBUT = "Meddtlibtribut";

    private DateTime? _meddtlibtribut;

    private static readonly string RO_MICROEMPRESA = "Microempresa";

    private string _microempresa;

    private static readonly string RO_MINUTOPROXCONTATO = "Minutoproxcontato";

    private decimal? _minutoproxcontato;

    private static readonly string RO_MOTIVOEXCLUSAO = "Motivoexclusao";

    private string _motivoexclusao;

    private static readonly string RO_MUNICCOB = "Municcob";

    private string _municcob;

    private static readonly string RO_MUNICCOB2 = "Municcob2";

    private string _municcob2;

    private static readonly string RO_MUNICCOM = "Municcom";

    private string _municcom;

    private static readonly string RO_MUNICCOM2 = "Municcom2";

    private string _municcom2;

    private static readonly string RO_MUNICCONJUGE = "Municconjuge";

    private string _municconjuge;

    private static readonly string RO_MUNICEMPR = "Municempr";

    private string _municempr;

    private static readonly string RO_MUNICENT = "Municent";

    private string _municent;

    private static readonly string RO_MUNICENT2 = "Municent2";

    private string _municent2;

    private static readonly string RO_NOMECONJUGE = "Nomeconjuge";

    private string _nomeconjuge;

    private static readonly string RO_NUMAGENCIA1 = "Numagencia1";

    private decimal? _numagencia1;

    private static readonly string RO_NUMAGENCIA2 = "Numagencia2";

    private decimal? _numagencia2;

    private static readonly string RO_NUMALVARA = "Numalvara";

    private string _numalvara;

    private static readonly string RO_NUMALVARAANVISA = "Numalvaraanvisa";

    private string _numalvaraanvisa;

    private static readonly string RO_NUMALVARAFUNC = "Numalvarafunc";

    private string _numalvarafunc;

    private static readonly string RO_NUMALVARASUS = "Numalvarasus";

    private string _numalvarasus;

    private static readonly string RO_NUMBANCO1 = "Numbanco1";

    private decimal? _numbanco1;

    private static readonly string RO_NUMBANCO2 = "Numbanco2";

    private decimal? _numbanco2;

    private static readonly string RO_NUMCARTAOFIDELIDADE = "Numcartaofidelidade";

    private string _numcartaofidelidade;

    private static readonly string RO_NUMCCORRENTE1 = "Numccorrente1";

    private string _numccorrente1;

    private static readonly string RO_NUMCCORRENTE2 = "Numccorrente2";

    private string _numccorrente2;

    private static readonly string RO_NUMCONCESSAO = "Numconcessao";

    private string _numconcessao;

    private static readonly string RO_NUMCRF = "Numcrf";

    private string _numcrf;

    private static readonly string RO_NUMCRM = "Numcrm";

    private string _numcrm;

    private static readonly string RO_NUMEROCOB = "Numerocob";

    private string _numerocob;

    private static readonly string RO_NUMEROCOM = "Numerocom";

    private string _numerocom;

    private static readonly string RO_NUMEROENT = "Numeroent";

    private string _numeroent;

    private static readonly string RO_NUMREGIAOCLI = "Numregiaocli";

    private decimal? _numregiaocli;

    private static readonly string RO_NUMREGISTROIMUNE = "Numregistroimune";

    private string _numregistroimune;

    private static readonly string RO_NUMSEQ = "Numseq";

    private decimal? _numseq;

    private static readonly string RO_NUMSEQATU = "Numseqatu";

    private decimal? _numseqatu;

    private static readonly string RO_NUMSEQROTARCA = "Numseqrotarca";

    private decimal? _numseqrotarca;

    private static readonly string RO_NUMTARE = "Numtare";

    private string _numtare;

    private static readonly string RO_NUMTRANSVENDADESC = "Numtransvendadesc";

    private decimal? _numtransvendadesc;

    private static readonly string RO_OBS = "Obs";

    private string _obs;

    private static readonly string RO_OBS_ADIC = "Obs_Adic";

    private string _obs_adic;

    private static readonly string RO_OBSCALLCENTER = "Obscallcenter";

    private string _obscallcenter;

    private static readonly string RO_OBSCREDITO = "Obscredito";

    private string _obscredito;

    private static readonly string RO_OBSENTREGA1 = "Obsentrega1";

    private string _obsentrega1;

    private static readonly string RO_OBSENTREGA2 = "Obsentrega2";

    private string _obsentrega2;

    private static readonly string RO_OBSENTREGA3 = "Obsentrega3";

    private string _obsentrega3;

    private static readonly string RO_OBSENTREGA4 = "Obsentrega4";

    private string _obsentrega4;

    private static readonly string RO_OBSERVACAO = "Observacao";

    private string _observacao;

    private static readonly string RO_OBSGERENCIAL1 = "Obsgerencial1";

    private string _obsgerencial1;

    private static readonly string RO_OBSGERENCIAL2 = "Obsgerencial2";

    private string _obsgerencial2;

    private static readonly string RO_OBSGERENCIAL3 = "Obsgerencial3";

    private string _obsgerencial3;

    private static readonly string RO_OBSRECEPCAO = "Obsrecepcao";

    private string _obsrecepcao;

    private static readonly string RO_OBSSUFRAMA = "Obssuframa";

    private string _obssuframa;

    private static readonly string RO_OBSTESOURARIA = "Obstesouraria";

    private string _obstesouraria;

    private static readonly string RO_OBS2 = "Obs2";

    private string _obs2;

    private static readonly string RO_OBS3 = "Obs3";

    private string _obs3;

    private static readonly string RO_OBS4 = "Obs4";

    private string _obs4;

    private static readonly string RO_OBS5 = "Obs5";

    private string _obs5;

    private static readonly string RO_ORGAOPUB = "Orgaopub";

    private string _orgaopub;

    private static readonly string RO_ORGAOPUBFEDERAL = "Orgaopubfederal";

    private string _orgaopubfederal;

    private static readonly string RO_ORGAORG = "Orgaorg";

    private string _orgaorg;

    private static readonly string RO_ORGAORGCONJ = "Orgaorgconj";

    private string _orgaorgconj;

    private static readonly string RO_ORIGEMPRECO = "Origempreco";

    private string _origempreco;

    private static readonly string RO_PAISENT = "Paisent";

    private string _paisent;

    private static readonly string RO_PARAIBASIM = "Paraibasim";

    private string _paraibasim;

    private static readonly string RO_PARTICIPAFUNCEP = "Participafuncep";

    private string _participafuncep;

    private static readonly string RO_PDVINVESTIMENTO = "Pdvinvestimento";

    private string _pdvinvestimento;

    private static readonly string RO_PERACRESTRANSF = "Peracrestransf";

    private decimal? _peracrestransf;

    private static readonly string RO_PERBASEVEND = "Perbasevend";

    private decimal? _perbasevend;

    private static readonly string RO_PERCBASEVENDQT = "Percbasevendqt";

    private decimal? _percbasevendqt;

    private static readonly string RO_PERCBONIFIC = "Percbonific";

    private decimal? _percbonific;

    private static readonly string RO_PERCOMCLI = "Percomcli";

    private decimal? _percomcli;

    private static readonly string RO_PERCOMFILIALBROKER = "Percomfilialbroker";

    private decimal? _percomfilialbroker;

    private static readonly string RO_PERCTOLVALIDADEPRODWMS = "Perctolvalidadeprodwms";

    private decimal? _perctolvalidadeprodwms;

    private static readonly string RO_PERDESC = "Perdesc";

    private decimal? _perdesc;

    private static readonly string RO_PERDESCFIN = "Perdescfin";

    private decimal? _perdescfin;

    private static readonly string RO_PERDESCISENTOICMS = "Perdescisentoicms";

    private decimal? _perdescisentoicms;

    private static readonly string RO_PERDESC2 = "Perdesc2";

    private decimal? _perdesc2;

    private static readonly string RO_PERDESC3 = "Perdesc3";

    private decimal? _perdesc3;

    private static readonly string RO_PERDESC4 = "Perdesc4";

    private decimal? _perdesc4;

    private static readonly string RO_PERDESC5 = "Perdesc5";

    private decimal? _perdesc5;

    private static readonly string RO_PERFRETEBROKER = "Perfretebroker";

    private decimal? _perfretebroker;

    private static readonly string RO_PERIODVISTORIA = "Periodvistoria";

    private decimal? _periodvistoria;

    private static readonly string RO_PERMINVALIDADE = "Perminvalidade";

    private decimal? _perminvalidade;

    private static readonly string RO_PERMITEALTERCOBRANCACR = "Permitealtercobrancacr";

    private string _permitealtercobrancacr;

    private static readonly string RO_PISCOFINSCUMULATIVO = "Piscofinscumulativo";

    private string _piscofinscumulativo;

    private static readonly string RO_PLPAGNEG = "Plpagneg";

    private string _plpagneg;

    private static readonly string RO_PLPAGNEG2 = "Plpagneg2";

    private string _plpagneg2;

    private static readonly string RO_PONTOREFER = "Pontorefer";

    private string _pontorefer;

    private static readonly string RO_PRAZOADICIONAL = "Prazoadicional";

    private decimal? _prazoadicional;

    private static readonly string RO_PRAZOADICIONAL2 = "Prazoadicional2";

    private decimal? _prazoadicional2;

    private static readonly string RO_PRAZOADICIONAL3 = "Prazoadicional3";

    private decimal? _prazoadicional3;

    private static readonly string RO_PRAZOADICIONAL4 = "Prazoadicional4";

    private decimal? _prazoadicional4;

    private static readonly string RO_PRAZOADICIONAL5 = "Prazoadicional5";

    private decimal? _prazoadicional5;

    private static readonly string RO_PRAZOADICIONAL6 = "Prazoadicional6";

    private decimal? _prazoadicional6;

    private static readonly string RO_PRAZOADICIONAL7 = "Prazoadicional7";

    private decimal? _prazoadicional7;

    private static readonly string RO_PRAZOMAXVALIDADE = "Prazomaxvalidade";

    private decimal? _prazomaxvalidade;

    private static readonly string RO_PRAZOMEDIOPLPAG = "Prazomedioplpag";

    private decimal? _prazomedioplpag;

    private static readonly string RO_PRAZOVALIDADE = "Prazovalidade";

    private decimal? _prazovalidade;

    private static readonly string RO_PRAZOVENCST = "Prazovencst";

    private decimal? _prazovencst;

    private static readonly string RO_PRAZOVENDA = "Prazovenda";

    private decimal? _prazovenda;

    private static readonly string RO_PRECOUTILIZADONFE = "Precoutilizadonfe";

    private string _precoutilizadonfe;

    private static readonly string RO_PREDIOPROPRIO = "Predioproprio";

    private string _predioproprio;

    private static readonly string RO_QTCHECKOUT = "Qtcheckout";

    private decimal? _qtcheckout;

    private static readonly string RO_QTDDIASAPLICDESCFIN = "Qtddiasaplicdescfin";

    private decimal? _qtddiasaplicdescfin;

    private static readonly string RO_QTESTRELA = "Qtestrela";

    private decimal? _qtestrela;

    private static readonly string RO_RATINGSCI = "Ratingsci";

    private string _ratingsci;

    private static readonly string RO_RATINGSCI1 = "Ratingsci1";

    private string _ratingsci1;

    private static readonly string RO_RATINGSCI2 = "Ratingsci2";

    private string _ratingsci2;

    private static readonly string RO_REGISTROIBAMA = "Registroibama";

    private string _registroibama;

    private static readonly string RO_REGJUNTACOMERCIAL = "Regjuntacomercial";

    private string _regjuntacomercial;

    private static readonly string RO_RENDAMENSAL = "Rendamensal";

    private decimal? _rendamensal;

    private static readonly string RO_RENDAMENSALCONJUGE = "Rendamensalconjuge";

    private decimal? _rendamensalconjuge;

    private static readonly string RO_REPASSE = "Repasse";

    private string _repasse;

    private static readonly string RO_RESSARCIMENTOST = "Ressarcimentost";

    private string _ressarcimentost;

    private static readonly string RO_RETENCAOISS = "Retencaoiss";

    private string _retencaoiss;

    private static readonly string RO_RFC = "Rfc";

    private string _rfc;

    private static readonly string RO_RG = "Rg";

    private string _rg;

    private static readonly string RO_RGCONJ = "Rgconj";

    private string _rgconj;

    private static readonly string RO_ROTEIROMASTERFOODS = "Roteiromasterfoods";

    private string _roteiromasterfoods;

    private static readonly string RO_SACADOELETRONICO = "Sacadoeletronico";

    private string _sacadoeletronico;

    private static readonly string RO_SENHA_WEB = "Senha_Web";

    private string _senha_web;

    private static readonly string RO_SEXO = "Sexo";

    private string _sexo;

    private static readonly string RO_SIGLADEC = "Sigladec";

    private string _sigladec;

    private static readonly string RO_SIMPLESNACIONAL = "Simplesnacional";

    private string _simplesnacional;

    private static readonly string RO_SITE = "Site";

    private string _site;

    private static readonly string RO_STATUSCONSULTASINTEGRA = "Statusconsultasintegra";

    private string _statusconsultasintegra;

    private static readonly string RO_SULFRAMA = "Sulframa";

    private string _sulframa;

    private static readonly string RO_SUPRIMIDO = "Suprimido";

    private string _suprimido;

    private static readonly string RO_SUS = "Sus";

    private string _sus;

    private static readonly string RO_TELCELENT = "Telcelent";

    private string _telcelent;

    private static readonly string RO_TELCOB = "Telcob";

    private string _telcob;

    private static readonly string RO_TELCOM = "Telcom";

    private string _telcom;

    private static readonly string RO_TELCONJUGE = "Telconjuge";

    private string _telconjuge;

    private static readonly string RO_TELEMPR = "Telempr";

    private string _telempr;

    private static readonly string RO_TELENT = "Telent";

    private string _telent;

    private static readonly string RO_TELENT1 = "Telent1";

    private string _telent1;

    private static readonly string RO_TIPOATIVCLI = "Tipoativcli";

    private string _tipoativcli;

    private static readonly string RO_TIPOCLIMED = "Tipoclimed";

    private string _tipoclimed;

    private static readonly string RO_TIPOCONVERSAOTV4 = "Tipoconversaotv4";

    private string _tipoconversaotv4;

    private static readonly string RO_TIPOCUSTOTRANSF = "Tipocustotransf";

    private string _tipocustotransf;

    private static readonly string RO_TIPOCUSTOTRANSF_FILIAIS = "Tipocustotransf_Filiais";

    private string _tipocustotransf_filiais;

    private static readonly string RO_TIPOCUSTOTRANSF_FILIALVIRTUAL = "Tipocustotransf_Filialvirtual";

    private string _tipocustotransf_filialvirtual;

    private static readonly string RO_TIPODESCISENCAO = "Tipodescisencao";

    private string _tipodescisencao;

    private static readonly string RO_TIPODOCUMENTO = "Tipodocumento";

    private string _tipodocumento;

    private static readonly string RO_TIPOEMPRESA = "Tipoempresa";

    private string _tipoempresa;

    private static readonly string RO_TIPOFJ = "Tipofj";

    private string _tipofj;

    private static readonly string RO_TIPOTRATAMENTODESCFIN = "Tipotratamentodescfin";

    private string _tipotratamentodescfin;

    private static readonly string RO_TIPOULTALTER = "Tipoultalter";

    private string _tipoultalter;

    private static readonly string RO_UFRG = "Ufrg";

    private string _ufrg;

    private static readonly string RO_ULTCODPLPAG = "Ultcodplpag";

    private decimal? _ultcodplpag;

    private static readonly string RO_USABKCNPJCODCLIPRINC = "Usabkcnpjcodcliprinc";

    private string _usabkcnpjcodcliprinc;

    private static readonly string RO_USACRECLIFAT = "Usacreclifat";

    private string _usacreclifat;

    private static readonly string RO_USACROSS = "Usacross";

    private string _usacross;

    private static readonly string RO_USADESCFINSEPARADODESCCOM = "Usadescfinseparadodesccom";

    private string _usadescfinseparadodesccom;

    private static readonly string RO_USADESCONTOICMS = "Usadescontoicms";

    private string _usadescontoicms;

    private static readonly string RO_USAIVAFONTEDIFERENCIADO = "Usaivafontediferenciado";

    private string _usaivafontediferenciado;

    private static readonly string RO_USAVLMINVENDABK = "Usavlminvendabk";

    private string _usavlminvendabk;

    private static readonly string RO_UTILIZAIESIMPLIFICADA = "Utilizaiesimplificada";

    private string _utilizaiesimplificada;

    private static readonly string RO_UTILIZAPEDCLINFE = "Utilizapedclinfe";

    private string _utilizapedclinfe;

    private static readonly string RO_UTILIZAPLPAGMEDICAMENTO = "Utilizaplpagmedicamento";

    private string _utilizaplpagmedicamento;

    private static readonly string RO_UTILIZAPRAZOMEDIOPLPAG = "Utilizaprazomedioplpag";

    private string _utilizaprazomedioplpag;

    private static readonly string RO_VALIDAMAXVENDAPF = "Validamaxvendapf";

    private string _validamaxvendapf;

    private static readonly string RO_VALIDARCAMPANHABRINDE = "Validarcampanhabrinde";

    private string _validarcampanhabrinde;

    private static readonly string RO_VALIDARMULTIPLOVENDA = "Validarmultiplovenda";

    private string _validarmultiplovenda;

    private static readonly string RO_VALORALUGUEL = "Valoraluguel";

    private decimal? _valoraluguel;

    private static readonly string RO_VIP = "Vip";

    private string _vip;

    private static readonly string RO_VLESTOQUE = "Vlestoque";

    private decimal? _vlestoque;

    private static readonly string RO_VLFRETE = "Vlfrete";

    private decimal? _vlfrete;

    private static readonly string RO_VLMAXCOBFRETE = "Vlmaxcobfrete";

    private decimal? _vlmaxcobfrete;

    private static readonly string RO_VLMEDIACOMPRAMESFORNEC = "Vlmediacompramesfornec";

    private decimal? _vlmediacompramesfornec;

    private static readonly string RO_VLMINIMOST = "Vlminimost";

    private decimal? _vlminimost;

    private static readonly string RO_VLOUTRASRENDAS = "Vloutrasrendas";

    private decimal? _vloutrasrendas;

    private static readonly string RO_VLPOTENCIALLIMCRED = "Vlpotenciallimcred";

    private decimal? _vlpotenciallimcred;

    private static readonly string RO_ZONA = "Zona";

    private decimal? _zona;

    private static readonly string RO_SENHACONVECF = "SENHACONVECF";

    private string _senhaconvecf;

    private static readonly string RO_CLIATACADO = "Cliatacado";

    private string _cliatacado;

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Aceitachterceiros
    {
        get
        {
            PropriedadeAcessada(RO_ACEITACHTERCEIROS);
            return _aceitachterceiros;
        }
        set
        {
            PropriedadeModificada(RO_ACEITACHTERCEIROS, value);
            _aceitachterceiros = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Aceitasimilar
    {
        get
        {
            PropriedadeAcessada(RO_ACEITASIMILAR);
            return _aceitasimilar;
        }
        set
        {
            PropriedadeModificada(RO_ACEITASIMILAR, value);
            _aceitasimilar = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Aceitatrocanegativa
    {
        get
        {
            PropriedadeAcessada(RO_ACEITATROCANEGATIVA);
            return _aceitatrocanegativa;
        }
        set
        {
            PropriedadeModificada(RO_ACEITATROCANEGATIVA, value);
            _aceitatrocanegativa = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Aceitavendafracao
    {
        get
        {
            PropriedadeAcessada(RO_ACEITAVENDAFRACAO);
            return _aceitavendafracao;
        }
        set
        {
            PropriedadeModificada(RO_ACEITAVENDAFRACAO, value);
            _aceitavendafracao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Agregarvalorstdescfin
    {
        get
        {
            PropriedadeAcessada(RO_AGREGARVALORSTDESCFIN);
            return _agregarvalorstdescfin;
        }
        set
        {
            PropriedadeModificada(RO_AGREGARVALORSTDESCFIN, value);
            _agregarvalorstdescfin = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Analisecred
    {
        get
        {
            PropriedadeAcessada(RO_ANALISECRED);
            return _analisecred;
        }
        set
        {
            PropriedadeModificada(RO_ANALISECRED, value);
            _analisecred = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Anvisa
    {
        get
        {
            PropriedadeAcessada(RO_ANVISA);
            return _anvisa;
        }
        set
        {
            PropriedadeModificada(RO_ANVISA, value);
            _anvisa = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Aplicadescnf
    {
        get
        {
            PropriedadeAcessada(RO_APLICADESCNF);
            return _aplicadescnf;
        }
        set
        {
            PropriedadeModificada(RO_APLICADESCNF, value);
            _aplicadescnf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Arealojam2
    {
        get
        {
            PropriedadeAcessada(RO_AREALOJAM2);
            return _arealojam2;
        }
        set
        {
            PropriedadeModificada(RO_AREALOJAM2, value);
            _arealojam2 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Atendedomingo
    {
        get
        {
            PropriedadeAcessada(RO_ATENDEDOMINGO);
            return _atendedomingo;
        }
        set
        {
            PropriedadeModificada(RO_ATENDEDOMINGO, value);
            _atendedomingo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Atendequarta
    {
        get
        {
            PropriedadeAcessada(RO_ATENDEQUARTA);
            return _atendequarta;
        }
        set
        {
            PropriedadeModificada(RO_ATENDEQUARTA, value);
            _atendequarta = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Atendequinta
    {
        get
        {
            PropriedadeAcessada(RO_ATENDEQUINTA);
            return _atendequinta;
        }
        set
        {
            PropriedadeModificada(RO_ATENDEQUINTA, value);
            _atendequinta = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Atendesabado
    {
        get
        {
            PropriedadeAcessada(RO_ATENDESABADO);
            return _atendesabado;
        }
        set
        {
            PropriedadeModificada(RO_ATENDESABADO, value);
            _atendesabado = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Atendesegunda
    {
        get
        {
            PropriedadeAcessada(RO_ATENDESEGUNDA);
            return _atendesegunda;
        }
        set
        {
            PropriedadeModificada(RO_ATENDESEGUNDA, value);
            _atendesegunda = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Atendesexta
    {
        get
        {
            PropriedadeAcessada(RO_ATENDESEXTA);
            return _atendesexta;
        }
        set
        {
            PropriedadeModificada(RO_ATENDESEXTA, value);
            _atendesexta = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Atendeterca
    {
        get
        {
            PropriedadeAcessada(RO_ATENDETERCA);
            return _atendeterca;
        }
        set
        {
            PropriedadeModificada(RO_ATENDETERCA, value);
            _atendeterca = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Atualizasaldoccdescfin
    {
        get
        {
            PropriedadeAcessada(RO_ATUALIZASALDOCCDESCFIN);
            return _atualizasaldoccdescfin;
        }
        set
        {
            PropriedadeModificada(RO_ATUALIZASALDOCCDESCFIN, value);
            _atualizasaldoccdescfin = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
    public string Bairrocob
    {
        get
        {
            PropriedadeAcessada(RO_BAIRROCOB);
            return _bairrocob;
        }
        set
        {
            PropriedadeModificada(RO_BAIRROCOB, value);
            _bairrocob = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
    public string Bairrocom
    {
        get
        {
            PropriedadeAcessada(RO_BAIRROCOM);
            return _bairrocom;
        }
        set
        {
            PropriedadeModificada(RO_BAIRROCOM, value);
            _bairrocom = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
    public string Bairroent
    {
        get
        {
            PropriedadeAcessada(RO_BAIRROENT);
            return _bairroent;
        }
        set
        {
            PropriedadeModificada(RO_BAIRROENT, value);
            _bairroent = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Bloqueio
    {
        get
        {
            PropriedadeAcessada(RO_BLOQUEIO);
            return _bloqueio;
        }
        set
        {
            PropriedadeModificada(RO_BLOQUEIO, value);
            _bloqueio = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Bloqueiodatacheq
    {
        get
        {
            PropriedadeAcessada(RO_BLOQUEIODATACHEQ);
            return _bloqueiodatacheq;
        }
        set
        {
            PropriedadeModificada(RO_BLOQUEIODATACHEQ, value);
            _bloqueiodatacheq = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Bloqueiodefinitivo
    {
        get
        {
            PropriedadeAcessada(RO_BLOQUEIODEFINITIVO);
            return _bloqueiodefinitivo;
        }
        set
        {
            PropriedadeModificada(RO_BLOQUEIODEFINITIVO, value);
            _bloqueiodefinitivo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Bloqueiosefaz
    {
        get
        {
            PropriedadeAcessada(RO_BLOQUEIOSEFAZ);
            return _bloqueiosefaz;
        }
        set
        {
            PropriedadeModificada(RO_BLOQUEIOSEFAZ, value);
            _bloqueiosefaz = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Bloqueiosefazped
    {
        get
        {
            PropriedadeAcessada(RO_BLOQUEIOSEFAZPED);
            return _bloqueiosefazped;
        }
        set
        {
            PropriedadeModificada(RO_BLOQUEIOSEFAZPED, value);
            _bloqueiosefazped = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Bloqvendapf
    {
        get
        {
            PropriedadeAcessada(RO_BLOQVENDAPF);
            return _bloqvendapf;
        }
        set
        {
            PropriedadeModificada(RO_BLOQVENDAPF, value);
            _bloqvendapf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 15, Precisao = 0)]
    public string Cacex
    {
        get
        {
            PropriedadeAcessada(RO_CACEX);
            return _cacex;
        }
        set
        {
            PropriedadeModificada(RO_CACEX, value);
            _cacex = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 0)]
    public decimal? Caixapostal
    {
        get
        {
            PropriedadeAcessada(RO_CAIXAPOSTAL);
            return _caixapostal;
        }
        set
        {
            PropriedadeModificada(RO_CAIXAPOSTAL, value);
            _caixapostal = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Calculast
    {
        get
        {
            PropriedadeAcessada(RO_CALCULAST);
            return _calculast;
        }
        set
        {
            PropriedadeModificada(RO_CALCULAST, value);
            _calculast = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 2)]
    public decimal? Capitalsocial
    {
        get
        {
            PropriedadeAcessada(RO_CAPITALSOCIAL);
            return _capitalsocial;
        }
        set
        {
            PropriedadeModificada(RO_CAPITALSOCIAL, value);
            _capitalsocial = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 30, Precisao = 0)]
    public string Cargo
    {
        get
        {
            PropriedadeAcessada(RO_CARGO);
            return _cargo;
        }
        set
        {
            PropriedadeModificada(RO_CARGO, value);
            _cargo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 30, Precisao = 0)]
    public string Cargoconjuge
    {
        get
        {
            PropriedadeAcessada(RO_CARGOCONJUGE);
            return _cargoconjuge;
        }
        set
        {
            PropriedadeModificada(RO_CARGOCONJUGE, value);
            _cargoconjuge = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 9, Precisao = 0)]
    public string Cepcob
    {
        get
        {
            PropriedadeAcessada(RO_CEPCOB);
            return _cepcob;
        }
        set
        {
            PropriedadeModificada(RO_CEPCOB, value);
            _cepcob = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 9, Precisao = 0)]
    public string Cepcom
    {
        get
        {
            PropriedadeAcessada(RO_CEPCOM);
            return _cepcom;
        }
        set
        {
            PropriedadeModificada(RO_CEPCOM, value);
            _cepcom = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Cepcxpostal
    {
        get
        {
            PropriedadeAcessada(RO_CEPCXPOSTAL);
            return _cepcxpostal;
        }
        set
        {
            PropriedadeModificada(RO_CEPCXPOSTAL, value);
            _cepcxpostal = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 9, Precisao = 0)]
    public string Cepent
    {
        get
        {
            PropriedadeAcessada(RO_CEPENT);
            return _cepent;
        }
        set
        {
            PropriedadeModificada(RO_CEPENT, value);
            _cepent = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 18, Precisao = 0)]
    public string Cgcent
    {
        get
        {
            PropriedadeAcessada(RO_CGCENT);
            return _cgcent;
        }
        set
        {
            PropriedadeModificada(RO_CGCENT, value);
            _cgcent = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 18, Precisao = 0)]
    public string Cgcentrega
    {
        get
        {
            PropriedadeAcessada(RO_CGCENTREGA);
            return _cgcentrega;
        }
        set
        {
            PropriedadeModificada(RO_CGCENTREGA, value);
            _cgcentrega = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 18, Precisao = 0)]
    public string Cgeentaux
    {
        get
        {
            PropriedadeAcessada(RO_CGEENTAUX);
            return _cgeentaux;
        }
        set
        {
            PropriedadeModificada(RO_CGEENTAUX, value);
            _cgeentaux = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Classecomercial
    {
        get
        {
            PropriedadeAcessada(RO_CLASSECOMERCIAL);
            return _classecomercial;
        }
        set
        {
            PropriedadeModificada(RO_CLASSECOMERCIAL, value);
            _classecomercial = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Classemc
    {
        get
        {
            PropriedadeAcessada(RO_CLASSEMC);
            return _classemc;
        }
        set
        {
            PropriedadeModificada(RO_CLASSEMC, value);
            _classemc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Classevenda
    {
        get
        {
            PropriedadeAcessada(RO_CLASSEVENDA);
            return _classevenda;
        }
        set
        {
            PropriedadeModificada(RO_CLASSEVENDA, value);
            _classevenda = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Clientedan
    {
        get
        {
            PropriedadeAcessada(RO_CLIENTEDAN);
            return _clientedan;
        }
        set
        {
            PropriedadeModificada(RO_CLIENTEDAN, value);
            _clientedan = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Clienteeletro
    {
        get
        {
            PropriedadeAcessada(RO_CLIENTEELETRO);
            return _clienteeletro;
        }
        set
        {
            PropriedadeModificada(RO_CLIENTEELETRO, value);
            _clienteeletro = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Clientemonitorado
    {
        get
        {
            PropriedadeAcessada(RO_CLIENTEMONITORADO);
            return _clientemonitorado;
        }
        set
        {
            PropriedadeModificada(RO_CLIENTEMONITORADO, value);
            _clientemonitorado = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 100, Precisao = 0)]
    public string Cliente2
    {
        get
        {
            PropriedadeAcessada(RO_CLIENTE2);
            return _cliente2;
        }
        set
        {
            PropriedadeModificada(RO_CLIENTE2, value);
            _cliente2 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Clientprotesto
    {
        get
        {
            PropriedadeAcessada(RO_CLIENTPROTESTO);
            return _clientprotesto;
        }
        set
        {
            PropriedadeModificada(RO_CLIENTPROTESTO, value);
            _clientprotesto = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 8, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codbairrocob
    {
        get
        {
            PropriedadeAcessada(RO_CODBAIRROCOB);
            return _codbairrocob;
        }
        set
        {
            PropriedadeModificada(RO_CODBAIRROCOB, value);
            _codbairrocob = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codbairrocom
    {
        get
        {
            PropriedadeAcessada(RO_CODBAIRROCOM);
            return _codbairrocom;
        }
        set
        {
            PropriedadeModificada(RO_CODBAIRROCOM, value);
            _codbairrocom = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codbairroent
    {
        get
        {
            PropriedadeAcessada(RO_CODBAIRROENT);
            return _codbairroent;
        }
        set
        {
            PropriedadeModificada(RO_CODBAIRROENT, value);
            _codbairroent = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 0)]
    public decimal? Codbarra
    {
        get
        {
            PropriedadeAcessada(RO_CODBARRA);
            return _codbarra;
        }
        set
        {
            PropriedadeModificada(RO_CODBARRA, value);
            _codbarra = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 0)]
    public decimal? Codbarracob
    {
        get
        {
            PropriedadeAcessada(RO_CODBARRACOB);
            return _codbarracob;
        }
        set
        {
            PropriedadeModificada(RO_CODBARRACOB, value);
            _codbarracob = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 0)]
    public decimal? Codbarraent
    {
        get
        {
            PropriedadeAcessada(RO_CODBARRAENT);
            return _codbarraent;
        }
        set
        {
            PropriedadeModificada(RO_CODBARRAENT, value);
            _codbarraent = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codcanal
    {
        get
        {
            PropriedadeAcessada(RO_CODCANAL);
            return _codcanal;
        }
        set
        {
            PropriedadeModificada(RO_CODCANAL, value);
            _codcanal = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codcidade
    {
        get
        {
            PropriedadeAcessada(RO_CODCIDADE);
            return _codcidade;
        }
        set
        {
            PropriedadeModificada(RO_CODCIDADE, value);
            _codcidade = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Codcliint
    {
        get
        {
            PropriedadeAcessada(RO_CODCLIINT);
            return _codcliint;
        }
        set
        {
            PropriedadeModificada(RO_CODCLIINT, value);
            _codcliint = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codclipalm
    {
        get
        {
            PropriedadeAcessada(RO_CODCLIPALM);
            return _codclipalm;
        }
        set
        {
            PropriedadeModificada(RO_CODCLIPALM, value);
            _codclipalm = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codcliprinc
    {
        get
        {
            PropriedadeAcessada(RO_CODCLIPRINC);
            return _codcliprinc;
        }
        set
        {
            PropriedadeModificada(RO_CODCLIPRINC, value);
            _codcliprinc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Codcliweb
    {
        get
        {
            PropriedadeAcessada(RO_CODCLIWEB);
            return _codcliweb;
        }
        set
        {
            PropriedadeModificada(RO_CODCLIWEB, value);
            _codcliweb = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 60, Precisao = 0)]
    public string Codcnae
    {
        get
        {
            PropriedadeAcessada(RO_CODCNAE);
            return _codcnae;
        }
        set
        {
            PropriedadeModificada(RO_CODCNAE, value);
            _codcnae = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 4, Precisao = 0)]
    public string Codcobtv1
    {
        get
        {
            PropriedadeAcessada(RO_CODCOBTV1);
            return _codcobtv1;
        }
        set
        {
            PropriedadeModificada(RO_CODCOBTV1, value);
            _codcobtv1 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 4, Precisao = 0)]
    public string Codcobtv3
    {
        get
        {
            PropriedadeAcessada(RO_CODCOBTV3);
            return _codcobtv3;
        }
        set
        {
            PropriedadeModificada(RO_CODCOBTV3, value);
            _codcobtv3 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 12, Precisao = 0)]
    public string Codcontab
    {
        get
        {
            PropriedadeAcessada(RO_CODCONTAB);
            return _codcontab;
        }
        set
        {
            PropriedadeModificada(RO_CODCONTAB, value);
            _codcontab = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Codfilialestoque
    {
        get
        {
            PropriedadeAcessada(RO_CODFILIALESTOQUE);
            return _codfilialestoque;
        }
        set
        {
            PropriedadeModificada(RO_CODFILIALESTOQUE, value);
            _codfilialestoque = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfunccad
    {
        get
        {
            PropriedadeAcessada(RO_CODFUNCCAD);
            return _codfunccad;
        }
        set
        {
            PropriedadeModificada(RO_CODFUNCCAD, value);
            _codfunccad = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfunccadastro
    {
        get
        {
            PropriedadeAcessada(RO_CODFUNCCADASTRO);
            return _codfunccadastro;
        }
        set
        {
            PropriedadeModificada(RO_CODFUNCCADASTRO, value);
            _codfunccadastro = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfunclancpotenciallimcred
    {
        get
        {
            PropriedadeAcessada(RO_CODFUNCLANCPOTENCIALLIMCRED);
            return _codfunclancpotenciallimcred;
        }
        set
        {
            PropriedadeModificada(RO_CODFUNCLANCPOTENCIALLIMCRED, value);
            _codfunclancpotenciallimcred = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfuncultaltercliesp
    {
        get
        {
            PropriedadeAcessada(RO_CODFUNCULTALTERCLIESP);
            return _codfuncultaltercliesp;
        }
        set
        {
            PropriedadeModificada(RO_CODFUNCULTALTERCLIESP, value);
            _codfuncultaltercliesp = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfuncultcontatocob
    {
        get
        {
            PropriedadeAcessada(RO_CODFUNCULTCONTATOCOB);
            return _codfuncultcontatocob;
        }
        set
        {
            PropriedadeModificada(RO_CODFUNCULTCONTATOCOB, value);
            _codfuncultcontatocob = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 13, Precisao = 0)]
    public decimal? Codgln
    {
        get
        {
            PropriedadeAcessada(RO_CODGLN);
            return _codgln;
        }
        set
        {
            PropriedadeModificada(RO_CODGLN, value);
            _codgln = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codhist
    {
        get
        {
            PropriedadeAcessada(RO_CODHIST);
            return _codhist;
        }
        set
        {
            PropriedadeModificada(RO_CODHIST, value);
            _codhist = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 4, Precisao = 0)]
    public string Codnilsen
    {
        get
        {
            PropriedadeAcessada(RO_CODNILSEN);
            return _codnilsen;
        }
        set
        {
            PropriedadeModificada(RO_CODNILSEN, value);
            _codnilsen = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Codplpagpadrao
    {
        get
        {
            PropriedadeAcessada(RO_CODPLPAGPADRAO);
            return _codplpagpadrao;
        }
        set
        {
            PropriedadeModificada(RO_CODPLPAGPADRAO, value);
            _codplpagpadrao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Codplpag2
    {
        get
        {
            PropriedadeAcessada(RO_CODPLPAG2);
            return _codplpag2;
        }
        set
        {
            PropriedadeModificada(RO_CODPLPAG2, value);
            _codplpag2 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codpracacob
    {
        get
        {
            PropriedadeAcessada(RO_CODPRACACOB);
            return _codpracacob;
        }
        set
        {
            PropriedadeModificada(RO_CODPRACACOB, value);
            _codpracacob = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Codrede
    {
        get
        {
            PropriedadeAcessada(RO_CODREDE);
            return _codrede;
        }
        set
        {
            PropriedadeModificada(RO_CODREDE, value);
            _codrede = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Codstatuscob
    {
        get
        {
            PropriedadeAcessada(RO_CODSTATUSCOB);
            return _codstatuscob;
        }
        set
        {
            PropriedadeModificada(RO_CODSTATUSCOB, value);
            _codstatuscob = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 30, Precisao = 0)]
    public string Codsuframa
    {
        get
        {
            PropriedadeAcessada(RO_CODSUFRAMA);
            return _codsuframa;
        }
        set
        {
            PropriedadeModificada(RO_CODSUFRAMA, value);
            _codsuframa = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Codusur1
    {
        get
        {
            PropriedadeAcessada(RO_CODUSUR1);
            return _codusur1;
        }
        set
        {
            PropriedadeModificada(RO_CODUSUR1, value);
            _codusur1 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 80, Precisao = 0)]
    public string Complementocob
    {
        get
        {
            PropriedadeAcessada(RO_COMPLEMENTOCOB);
            return _complementocob;
        }
        set
        {
            PropriedadeModificada(RO_COMPLEMENTOCOB, value);
            _complementocob = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 80, Precisao = 0)]
    public string Complementocom
    {
        get
        {
            PropriedadeAcessada(RO_COMPLEMENTOCOM);
            return _complementocom;
        }
        set
        {
            PropriedadeModificada(RO_COMPLEMENTOCOM, value);
            _complementocom = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 80, Precisao = 0)]
    public string Complementoent
    {
        get
        {
            PropriedadeAcessada(RO_COMPLEMENTOENT);
            return _complementoent;
        }
        set
        {
            PropriedadeModificada(RO_COMPLEMENTOENT, value);
            _complementoent = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Condvenda1
    {
        get
        {
            PropriedadeAcessada(RO_CONDVENDA1);
            return _condvenda1;
        }
        set
        {
            PropriedadeModificada(RO_CONDVENDA1, value);
            _condvenda1 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Condvenda10
    {
        get
        {
            PropriedadeAcessada(RO_CONDVENDA10);
            return _condvenda10;
        }
        set
        {
            PropriedadeModificada(RO_CONDVENDA10, value);
            _condvenda10 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Condvenda11
    {
        get
        {
            PropriedadeAcessada(RO_CONDVENDA11);
            return _condvenda11;
        }
        set
        {
            PropriedadeModificada(RO_CONDVENDA11, value);
            _condvenda11 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Condvenda12
    {
        get
        {
            PropriedadeAcessada(RO_CONDVENDA12);
            return _condvenda12;
        }
        set
        {
            PropriedadeModificada(RO_CONDVENDA12, value);
            _condvenda12 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Condvenda13
    {
        get
        {
            PropriedadeAcessada(RO_CONDVENDA13);
            return _condvenda13;
        }
        set
        {
            PropriedadeModificada(RO_CONDVENDA13, value);
            _condvenda13 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Condvenda14
    {
        get
        {
            PropriedadeAcessada(RO_CONDVENDA14);
            return _condvenda14;
        }
        set
        {
            PropriedadeModificada(RO_CONDVENDA14, value);
            _condvenda14 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Condvenda2
    {
        get
        {
            PropriedadeAcessada(RO_CONDVENDA2);
            return _condvenda2;
        }
        set
        {
            PropriedadeModificada(RO_CONDVENDA2, value);
            _condvenda2 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Condvenda20
    {
        get
        {
            PropriedadeAcessada(RO_CONDVENDA20);
            return _condvenda20;
        }
        set
        {
            PropriedadeModificada(RO_CONDVENDA20, value);
            _condvenda20 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Condvenda3
    {
        get
        {
            PropriedadeAcessada(RO_CONDVENDA3);
            return _condvenda3;
        }
        set
        {
            PropriedadeModificada(RO_CONDVENDA3, value);
            _condvenda3 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Condvenda4
    {
        get
        {
            PropriedadeAcessada(RO_CONDVENDA4);
            return _condvenda4;
        }
        set
        {
            PropriedadeModificada(RO_CONDVENDA4, value);
            _condvenda4 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Condvenda5
    {
        get
        {
            PropriedadeAcessada(RO_CONDVENDA5);
            return _condvenda5;
        }
        set
        {
            PropriedadeModificada(RO_CONDVENDA5, value);
            _condvenda5 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Condvenda6
    {
        get
        {
            PropriedadeAcessada(RO_CONDVENDA6);
            return _condvenda6;
        }
        set
        {
            PropriedadeModificada(RO_CONDVENDA6, value);
            _condvenda6 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Condvenda7
    {
        get
        {
            PropriedadeAcessada(RO_CONDVENDA7);
            return _condvenda7;
        }
        set
        {
            PropriedadeModificada(RO_CONDVENDA7, value);
            _condvenda7 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Condvenda8
    {
        get
        {
            PropriedadeAcessada(RO_CONDVENDA8);
            return _condvenda8;
        }
        set
        {
            PropriedadeModificada(RO_CONDVENDA8, value);
            _condvenda8 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Condvenda9
    {
        get
        {
            PropriedadeAcessada(RO_CONDVENDA9);
            return _condvenda9;
        }
        set
        {
            PropriedadeModificada(RO_CONDVENDA9, value);
            _condvenda9 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Condvenda98
    {
        get
        {
            PropriedadeAcessada(RO_CONDVENDA98);
            return _condvenda98;
        }
        set
        {
            PropriedadeModificada(RO_CONDVENDA98, value);
            _condvenda98 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Condvenda99
    {
        get
        {
            PropriedadeAcessada(RO_CONDVENDA99);
            return _condvenda99;
        }
        set
        {
            PropriedadeModificada(RO_CONDVENDA99, value);
            _condvenda99 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Contagemestoque
    {
        get
        {
            PropriedadeAcessada(RO_CONTAGEMESTOQUE);
            return _contagemestoque;
        }
        set
        {
            PropriedadeModificada(RO_CONTAGEMESTOQUE, value);
            _contagemestoque = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 15, Precisao = 0)]
    public string Cpfconjuge
    {
        get
        {
            PropriedadeAcessada(RO_CPFCONJUGE);
            return _cpfconjuge;
        }
        set
        {
            PropriedadeModificada(RO_CPFCONJUGE, value);
            _cpfconjuge = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Crf
    {
        get
        {
            PropriedadeAcessada(RO_CRF);
            return _crf;
        }
        set
        {
            PropriedadeModificada(RO_CRF, value);
            _crf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Datacoleta
    {
        get
        {
            PropriedadeAcessada(RO_DATACOLETA);
            return _datacoleta;
        }
        set
        {
            PropriedadeModificada(RO_DATACOLETA, value);
            _datacoleta = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dataconsultasintegra
    {
        get
        {
            PropriedadeAcessada(RO_DATACONSULTASINTEGRA);
            return _dataconsultasintegra;
        }
        set
        {
            PropriedadeModificada(RO_DATACONSULTASINTEGRA, value);
            _dataconsultasintegra = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 3, Precisao = 0)]
    public decimal? Dddinternacional
    {
        get
        {
            PropriedadeAcessada(RO_DDDINTERNACIONAL);
            return _dddinternacional;
        }
        set
        {
            PropriedadeModificada(RO_DDDINTERNACIONAL, value);
            _dddinternacional = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Descproduto
    {
        get
        {
            PropriedadeAcessada(RO_DESCPRODUTO);
            return _descproduto;
        }
        set
        {
            PropriedadeModificada(RO_DESCPRODUTO, value);
            _descproduto = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Destacafrete
    {
        get
        {
            PropriedadeAcessada(RO_DESTACAFRETE);
            return _destacafrete;
        }
        set
        {
            PropriedadeModificada(RO_DESTACAFRETE, value);
            _destacafrete = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 10, Precisao = 0)]
    public string Diasemana
    {
        get
        {
            PropriedadeAcessada(RO_DIASEMANA);
            return _diasemana;
        }
        set
        {
            PropriedadeModificada(RO_DIASEMANA, value);
            _diasemana = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Digagencia1
    {
        get
        {
            PropriedadeAcessada(RO_DIGAGENCIA1);
            return _digagencia1;
        }
        set
        {
            PropriedadeModificada(RO_DIGAGENCIA1, value);
            _digagencia1 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Digagencia2
    {
        get
        {
            PropriedadeAcessada(RO_DIGAGENCIA2);
            return _digagencia2;
        }
        set
        {
            PropriedadeModificada(RO_DIGAGENCIA2, value);
            _digagencia2 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 100, Precisao = 0)]
    public string Diretoriocliente
    {
        get
        {
            PropriedadeAcessada(RO_DIRETORIOCLIENTE);
            return _diretoriocliente;
        }
        set
        {
            PropriedadeModificada(RO_DIRETORIOCLIENTE, value);
            _diretoriocliente = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 100, Precisao = 0)]
    public string Diretoriocontrato
    {
        get
        {
            PropriedadeAcessada(RO_DIRETORIOCONTRATO);
            return _diretoriocontrato;
        }
        set
        {
            PropriedadeModificada(RO_DIRETORIOCONTRATO, value);
            _diretoriocontrato = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtabertcc1
    {
        get
        {
            PropriedadeAcessada(RO_DTABERTCC1);
            return _dtabertcc1;
        }
        set
        {
            PropriedadeModificada(RO_DTABERTCC1, value);
            _dtabertcc1 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtabertcc2
    {
        get
        {
            PropriedadeAcessada(RO_DTABERTCC2);
            return _dtabertcc2;
        }
        set
        {
            PropriedadeModificada(RO_DTABERTCC2, value);
            _dtabertcc2 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtadmissao
    {
        get
        {
            PropriedadeAcessada(RO_DTADMISSAO);
            return _dtadmissao;
        }
        set
        {
            PropriedadeModificada(RO_DTADMISSAO, value);
            _dtadmissao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtadmissaoconjuge
    {
        get
        {
            PropriedadeAcessada(RO_DTADMISSAOCONJUGE);
            return _dtadmissaoconjuge;
        }
        set
        {
            PropriedadeModificada(RO_DTADMISSAOCONJUGE, value);
            _dtadmissaoconjuge = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtbloq
    {
        get
        {
            PropriedadeAcessada(RO_DTBLOQ);
            return _dtbloq;
        }
        set
        {
            PropriedadeModificada(RO_DTBLOQ, value);
            _dtbloq = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime Dtcadastro
    {
        get
        {
            PropriedadeAcessada(RO_DTCADASTRO);
            return _dtcadastro;
        }
        set
        {
            PropriedadeModificada(RO_DTCADASTRO, value);
            _dtcadastro = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtcapitalsocial
    {
        get
        {
            PropriedadeAcessada(RO_DTCAPITALSOCIAL);
            return _dtcapitalsocial;
        }
        set
        {
            PropriedadeModificada(RO_DTCAPITALSOCIAL, value);
            _dtcapitalsocial = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtclassificaestrela
    {
        get
        {
            PropriedadeAcessada(RO_DTCLASSIFICAESTRELA);
            return _dtclassificaestrela;
        }
        set
        {
            PropriedadeModificada(RO_DTCLASSIFICAESTRELA, value);
            _dtclassificaestrela = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtclassificagrupo
    {
        get
        {
            PropriedadeAcessada(RO_DTCLASSIFICAGRUPO);
            return _dtclassificagrupo;
        }
        set
        {
            PropriedadeModificada(RO_DTCLASSIFICAGRUPO, value);
            _dtclassificagrupo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtdesbloqueio
    {
        get
        {
            PropriedadeAcessada(RO_DTDESBLOQUEIO);
            return _dtdesbloqueio;
        }
        set
        {
            PropriedadeModificada(RO_DTDESBLOQUEIO, value);
            _dtdesbloqueio = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtenquadramentomicroempresa
    {
        get
        {
            PropriedadeAcessada(RO_DTENQUADRAMENTOMICROEMPRESA);
            return _dtenquadramentomicroempresa;
        }
        set
        {
            PropriedadeModificada(RO_DTENQUADRAMENTOMICROEMPRESA, value);
            _dtenquadramentomicroempresa = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtexclusao
    {
        get
        {
            PropriedadeAcessada(RO_DTEXCLUSAO);
            return _dtexclusao;
        }
        set
        {
            PropriedadeModificada(RO_DTEXCLUSAO, value);
            _dtexclusao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtimportintegracao
    {
        get
        {
            PropriedadeAcessada(RO_DTIMPORTINTEGRACAO);
            return _dtimportintegracao;
        }
        set
        {
            PropriedadeModificada(RO_DTIMPORTINTEGRACAO, value);
            _dtimportintegracao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtinivistoria
    {
        get
        {
            PropriedadeAcessada(RO_DTINIVISTORIA);
            return _dtinivistoria;
        }
        set
        {
            PropriedadeModificada(RO_DTINIVISTORIA, value);
            _dtinivistoria = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtlancpotenciallimcred
    {
        get
        {
            PropriedadeAcessada(RO_DTLANCPOTENCIALLIMCRED);
            return _dtlancpotenciallimcred;
        }
        set
        {
            PropriedadeModificada(RO_DTLANCPOTENCIALLIMCRED, value);
            _dtlancpotenciallimcred = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtnasc
    {
        get
        {
            PropriedadeAcessada(RO_DTNASC);
            return _dtnasc;
        }
        set
        {
            PropriedadeModificada(RO_DTNASC, value);
            _dtnasc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtnascconj
    {
        get
        {
            PropriedadeAcessada(RO_DTNASCCONJ);
            return _dtnascconj;
        }
        set
        {
            PropriedadeModificada(RO_DTNASCCONJ, value);
            _dtnascconj = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtprimcompra
    {
        get
        {
            PropriedadeAcessada(RO_DTPRIMCOMPRA);
            return _dtprimcompra;
        }
        set
        {
            PropriedadeModificada(RO_DTPRIMCOMPRA, value);
            _dtprimcompra = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtproxcontatocob
    {
        get
        {
            PropriedadeAcessada(RO_DTPROXCONTATOCOB);
            return _dtproxcontatocob;
        }
        set
        {
            PropriedadeModificada(RO_DTPROXCONTATOCOB, value);
            _dtproxcontatocob = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtproxvistoria
    {
        get
        {
            PropriedadeAcessada(RO_DTPROXVISTORIA);
            return _dtproxvistoria;
        }
        set
        {
            PropriedadeModificada(RO_DTPROXVISTORIA, value);
            _dtproxvistoria = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtreglim
    {
        get
        {
            PropriedadeAcessada(RO_DTREGLIM);
            return _dtreglim;
        }
        set
        {
            PropriedadeModificada(RO_DTREGLIM, value);
            _dtreglim = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtultaltercliesp
    {
        get
        {
            PropriedadeAcessada(RO_DTULTALTERCLIESP);
            return _dtultaltercliesp;
        }
        set
        {
            PropriedadeModificada(RO_DTULTALTERCLIESP, value);
            _dtultaltercliesp = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtultaltersrvprc
    {
        get
        {
            PropriedadeAcessada(RO_DTULTALTERSRVPRC);
            return _dtultaltersrvprc;
        }
        set
        {
            PropriedadeModificada(RO_DTULTALTERSRVPRC, value);
            _dtultaltersrvprc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtultcomp
    {
        get
        {
            PropriedadeAcessada(RO_DTULTCOMP);
            return _dtultcomp;
        }
        set
        {
            PropriedadeModificada(RO_DTULTCOMP, value);
            _dtultcomp = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtultcompnestle
    {
        get
        {
            PropriedadeAcessada(RO_DTULTCOMPNESTLE);
            return _dtultcompnestle;
        }
        set
        {
            PropriedadeModificada(RO_DTULTCOMPNESTLE, value);
            _dtultcompnestle = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtultconsultasci
    {
        get
        {
            PropriedadeAcessada(RO_DTULTCONSULTASCI);
            return _dtultconsultasci;
        }
        set
        {
            PropriedadeModificada(RO_DTULTCONSULTASCI, value);
            _dtultconsultasci = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtultconsultaserasa
    {
        get
        {
            PropriedadeAcessada(RO_DTULTCONSULTASERASA);
            return _dtultconsultaserasa;
        }
        set
        {
            PropriedadeModificada(RO_DTULTCONSULTASERASA, value);
            _dtultconsultaserasa = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtultconsultasintegra
    {
        get
        {
            PropriedadeAcessada(RO_DTULTCONSULTASINTEGRA);
            return _dtultconsultasintegra;
        }
        set
        {
            PropriedadeModificada(RO_DTULTCONSULTASINTEGRA, value);
            _dtultconsultasintegra = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtultcontatocob
    {
        get
        {
            PropriedadeAcessada(RO_DTULTCONTATOCOB);
            return _dtultcontatocob;
        }
        set
        {
            PropriedadeModificada(RO_DTULTCONTATOCOB, value);
            _dtultcontatocob = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtultvisita
    {
        get
        {
            PropriedadeAcessada(RO_DTULTVISITA);
            return _dtultvisita;
        }
        set
        {
            PropriedadeModificada(RO_DTULTVISITA, value);
            _dtultvisita = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtvalidadeconv
    {
        get
        {
            PropriedadeAcessada(RO_DTVALIDADECONV);
            return _dtvalidadeconv;
        }
        set
        {
            PropriedadeModificada(RO_DTVALIDADECONV, value);
            _dtvalidadeconv = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtvalidadeibama
    {
        get
        {
            PropriedadeAcessada(RO_DTVALIDADEIBAMA);
            return _dtvalidadeibama;
        }
        set
        {
            PropriedadeModificada(RO_DTVALIDADEIBAMA, value);
            _dtvalidadeibama = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtvalidasefaz
    {
        get
        {
            PropriedadeAcessada(RO_DTVALIDASEFAZ);
            return _dtvalidasefaz;
        }
        set
        {
            PropriedadeModificada(RO_DTVALIDASEFAZ, value);
            _dtvalidasefaz = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtvencalvara
    {
        get
        {
            PropriedadeAcessada(RO_DTVENCALVARA);
            return _dtvencalvara;
        }
        set
        {
            PropriedadeModificada(RO_DTVENCALVARA, value);
            _dtvencalvara = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtvencalvaraanvisa
    {
        get
        {
            PropriedadeAcessada(RO_DTVENCALVARAANVISA);
            return _dtvencalvaraanvisa;
        }
        set
        {
            PropriedadeModificada(RO_DTVENCALVARAANVISA, value);
            _dtvencalvaraanvisa = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtvencalvarafunc
    {
        get
        {
            PropriedadeAcessada(RO_DTVENCALVARAFUNC);
            return _dtvencalvarafunc;
        }
        set
        {
            PropriedadeModificada(RO_DTVENCALVARAFUNC, value);
            _dtvencalvarafunc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtvencalvarasus
    {
        get
        {
            PropriedadeAcessada(RO_DTVENCALVARASUS);
            return _dtvencalvarasus;
        }
        set
        {
            PropriedadeModificada(RO_DTVENCALVARASUS, value);
            _dtvencalvarasus = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtvenccrf
    {
        get
        {
            PropriedadeAcessada(RO_DTVENCCRF);
            return _dtvenccrf;
        }
        set
        {
            PropriedadeModificada(RO_DTVENCCRF, value);
            _dtvenccrf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtvenclimcred
    {
        get
        {
            PropriedadeAcessada(RO_DTVENCLIMCRED);
            return _dtvenclimcred;
        }
        set
        {
            PropriedadeModificada(RO_DTVENCLIMCRED, value);
            _dtvenclimcred = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtvencprazoadicional
    {
        get
        {
            PropriedadeAcessada(RO_DTVENCPRAZOADICIONAL);
            return _dtvencprazoadicional;
        }
        set
        {
            PropriedadeModificada(RO_DTVENCPRAZOADICIONAL, value);
            _dtvencprazoadicional = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtvencsuframa
    {
        get
        {
            PropriedadeAcessada(RO_DTVENCSUFRAMA);
            return _dtvencsuframa;
        }
        set
        {
            PropriedadeModificada(RO_DTVENCSUFRAMA, value);
            _dtvencsuframa = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 3, Precisao = 0)]
    public string Edocob
    {
        get
        {
            PropriedadeAcessada(RO_EDOCOB);
            return _edocob;
        }
        set
        {
            PropriedadeModificada(RO_EDOCOB, value);
            _edocob = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 3, Precisao = 0)]
    public string Edocom
    {
        get
        {
            PropriedadeAcessada(RO_EDOCOM);
            return _edocom;
        }
        set
        {
            PropriedadeModificada(RO_EDOCOM, value);
            _edocom = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 3, Precisao = 0)]
    public string Edoent
    {
        get
        {
            PropriedadeAcessada(RO_EDOENT);
            return _edoent;
        }
        set
        {
            PropriedadeModificada(RO_EDOENT, value);
            _edoent = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 100, Precisao = 0)]
    public string Email
    {
        get
        {
            PropriedadeAcessada(RO_EMAIL);
            return _email;
        }
        set
        {
            PropriedadeModificada(RO_EMAIL, value);
            _email = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 100, Precisao = 0)]
    public string Emailnfe
    {
        get
        {
            PropriedadeAcessada(RO_EMAILNFE);
            return _emailnfe;
        }
        set
        {
            PropriedadeModificada(RO_EMAILNFE, value);
            _emailnfe = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Emitedae
    {
        get
        {
            PropriedadeAcessada(RO_EMITEDAE);
            return _emitedae;
        }
        set
        {
            PropriedadeModificada(RO_EMITEDAE, value);
            _emitedae = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Emitedup
    {
        get
        {
            PropriedadeAcessada(RO_EMITEDUP);
            return _emitedup;
        }
        set
        {
            PropriedadeModificada(RO_EMITEDUP, value);
            _emitedup = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
    public string Emitentech
    {
        get
        {
            PropriedadeAcessada(RO_EMITENTECH);
            return _emitentech;
        }
        set
        {
            PropriedadeModificada(RO_EMITENTECH, value);
            _emitentech = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
    public string Emitentech2
    {
        get
        {
            PropriedadeAcessada(RO_EMITENTECH2);
            return _emitentech2;
        }
        set
        {
            PropriedadeModificada(RO_EMITENTECH2, value);
            _emitentech2 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Emitepvendanfsemdesc
    {
        get
        {
            PropriedadeAcessada(RO_EMITEPVENDANFSEMDESC);
            return _emitepvendanfsemdesc;
        }
        set
        {
            PropriedadeModificada(RO_EMITEPVENDANFSEMDESC, value);
            _emitepvendanfsemdesc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Empfixa
    {
        get
        {
            PropriedadeAcessada(RO_EMPFIXA);
            return _empfixa;
        }
        set
        {
            PropriedadeModificada(RO_EMPFIXA, value);
            _empfixa = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
    public string Empresa
    {
        get
        {
            PropriedadeAcessada(RO_EMPRESA);
            return _empresa;
        }
        set
        {
            PropriedadeModificada(RO_EMPRESA, value);
            _empresa = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
    public string Empresaconjuge
    {
        get
        {
            PropriedadeAcessada(RO_EMPRESACONJUGE);
            return _empresaconjuge;
        }
        set
        {
            PropriedadeModificada(RO_EMPRESACONJUGE, value);
            _empresaconjuge = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
    public string Endercob
    {
        get
        {
            PropriedadeAcessada(RO_ENDERCOB);
            return _endercob;
        }
        set
        {
            PropriedadeModificada(RO_ENDERCOB, value);
            _endercob = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
    public string Endercom
    {
        get
        {
            PropriedadeAcessada(RO_ENDERCOM);
            return _endercom;
        }
        set
        {
            PropriedadeModificada(RO_ENDERCOM, value);
            _endercom = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
    public string Enderconjuge
    {
        get
        {
            PropriedadeAcessada(RO_ENDERCONJUGE);
            return _enderconjuge;
        }
        set
        {
            PropriedadeModificada(RO_ENDERCONJUGE, value);
            _enderconjuge = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
    public string Enderempr
    {
        get
        {
            PropriedadeAcessada(RO_ENDEREMPR);
            return _enderempr;
        }
        set
        {
            PropriedadeModificada(RO_ENDEREMPR, value);
            _enderempr = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
    public string Enderent
    {
        get
        {
            PropriedadeAcessada(RO_ENDERENT);
            return _enderent;
        }
        set
        {
            PropriedadeModificada(RO_ENDERENT, value);
            _enderent = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Enviadadosserasa
    {
        get
        {
            PropriedadeAcessada(RO_ENVIADADOSSERASA);
            return _enviadadosserasa;
        }
        set
        {
            PropriedadeModificada(RO_ENVIADADOSSERASA, value);
            _enviadadosserasa = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Envionfeemailcom
    {
        get
        {
            PropriedadeAcessada(RO_ENVIONFEEMAILCOM);
            return _envionfeemailcom;
        }
        set
        {
            PropriedadeModificada(RO_ENVIONFEEMAILCOM, value);
            _envionfeemailcom = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Enviopdfnfe
    {
        get
        {
            PropriedadeAcessada(RO_ENVIOPDFNFE);
            return _enviopdfnfe;
        }
        set
        {
            PropriedadeModificada(RO_ENVIOPDFNFE, value);
            _enviopdfnfe = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Estcob
    {
        get
        {
            PropriedadeAcessada(RO_ESTCOB);
            return _estcob;
        }
        set
        {
            PropriedadeModificada(RO_ESTCOB, value);
            _estcob = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Estcom
    {
        get
        {
            PropriedadeAcessada(RO_ESTCOM);
            return _estcom;
        }
        set
        {
            PropriedadeModificada(RO_ESTCOM, value);
            _estcom = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Estconjuge
    {
        get
        {
            PropriedadeAcessada(RO_ESTCONJUGE);
            return _estconjuge;
        }
        set
        {
            PropriedadeModificada(RO_ESTCONJUGE, value);
            _estconjuge = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Estempr
    {
        get
        {
            PropriedadeAcessada(RO_ESTEMPR);
            return _estempr;
        }
        set
        {
            PropriedadeModificada(RO_ESTEMPR, value);
            _estempr = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Estent
    {
        get
        {
            PropriedadeAcessada(RO_ESTENT);
            return _estent;
        }
        set
        {
            PropriedadeModificada(RO_ESTENT, value);
            _estent = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Exportardadosims
    {
        get
        {
            PropriedadeAcessada(RO_EXPORTARDADOSIMS);
            return _exportardadosims;
        }
        set
        {
            PropriedadeModificada(RO_EXPORTARDADOSIMS, value);
            _exportardadosims = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
    public string Fantasia
    {
        get
        {
            PropriedadeAcessada(RO_FANTASIA);
            return _fantasia;
        }
        set
        {
            PropriedadeModificada(RO_FANTASIA, value);
            _fantasia = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 15, Precisao = 0)]
    public string Faxcli
    {
        get
        {
            PropriedadeAcessada(RO_FAXCLI);
            return _faxcli;
        }
        set
        {
            PropriedadeModificada(RO_FAXCLI, value);
            _faxcli = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 15, Precisao = 0)]
    public string Faxcom
    {
        get
        {
            PropriedadeAcessada(RO_FAXCOM);
            return _faxcom;
        }
        set
        {
            PropriedadeModificada(RO_FAXCOM, value);
            _faxcom = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
    public string Filiacaomae
    {
        get
        {
            PropriedadeAcessada(RO_FILIACAOMAE);
            return _filiacaomae;
        }
        set
        {
            PropriedadeModificada(RO_FILIACAOMAE, value);
            _filiacaomae = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
    public string Filiacaomaeconj
    {
        get
        {
            PropriedadeAcessada(RO_FILIACAOMAECONJ);
            return _filiacaomaeconj;
        }
        set
        {
            PropriedadeModificada(RO_FILIACAOMAECONJ, value);
            _filiacaomaeconj = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
    public string Filiacaopai
    {
        get
        {
            PropriedadeAcessada(RO_FILIACAOPAI);
            return _filiacaopai;
        }
        set
        {
            PropriedadeModificada(RO_FILIACAOPAI, value);
            _filiacaopai = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
    public string Filiacaopaiconj
    {
        get
        {
            PropriedadeAcessada(RO_FILIACAOPAICONJ);
            return _filiacaopaiconj;
        }
        set
        {
            PropriedadeModificada(RO_FILIACAOPAICONJ, value);
            _filiacaopaiconj = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Foco
    {
        get
        {
            PropriedadeAcessada(RO_FOCO);
            return _foco;
        }
        set
        {
            PropriedadeModificada(RO_FOCO, value);
            _foco = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Fotografiasucesso
    {
        get
        {
            PropriedadeAcessada(RO_FOTOGRAFIASUCESSO);
            return _fotografiasucesso;
        }
        set
        {
            PropriedadeModificada(RO_FOTOGRAFIASUCESSO, value);
            _fotografiasucesso = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Freqdiavisita
    {
        get
        {
            PropriedadeAcessada(RO_FREQDIAVISITA);
            return _freqdiavisita;
        }
        set
        {
            PropriedadeModificada(RO_FREQDIAVISITA, value);
            _freqdiavisita = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 1, Precisao = 0)]
    public decimal? Freqvisita
    {
        get
        {
            PropriedadeAcessada(RO_FREQVISITA);
            return _freqvisita;
        }
        set
        {
            PropriedadeModificada(RO_FREQVISITA, value);
            _freqvisita = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Gerarcreditodevcli
    {
        get
        {
            PropriedadeAcessada(RO_GERARCREDITODEVCLI);
            return _gerarcreditodevcli;
        }
        set
        {
            PropriedadeModificada(RO_GERARCREDITODEVCLI, value);
            _gerarcreditodevcli = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Geratitulost
    {
        get
        {
            PropriedadeAcessada(RO_GERATITULOST);
            return _geratitulost;
        }
        set
        {
            PropriedadeModificada(RO_GERATITULOST, value);
            _geratitulost = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Gerenciamento
    {
        get
        {
            PropriedadeAcessada(RO_GERENCIAMENTO);
            return _gerenciamento;
        }
        set
        {
            PropriedadeModificada(RO_GERENCIAMENTO, value);
            _gerenciamento = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Gruporamoativi
    {
        get
        {
            PropriedadeAcessada(RO_GRUPORAMOATIVI);
            return _gruporamoativi;
        }
        set
        {
            PropriedadeModificada(RO_GRUPORAMOATIVI, value);
            _gruporamoativi = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Horacadastro
    {
        get
        {
            PropriedadeAcessada(RO_HORACADASTRO);
            return _horacadastro;
        }
        set
        {
            PropriedadeModificada(RO_HORACADASTRO, value);
            _horacadastro = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 2, Precisao = 0)]
    public decimal? Horaproxcontato
    {
        get
        {
            PropriedadeAcessada(RO_HORAPROXCONTATO);
            return _horaproxcontato;
        }
        set
        {
            PropriedadeModificada(RO_HORAPROXCONTATO, value);
            _horaproxcontato = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 5, Precisao = 0)]
    public string Horarioreceb
    {
        get
        {
            PropriedadeAcessada(RO_HORARIORECEB);
            return _horarioreceb;
        }
        set
        {
            PropriedadeModificada(RO_HORARIORECEB, value);
            _horarioreceb = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Icmsantecip
    {
        get
        {
            PropriedadeAcessada(RO_ICMSANTECIP);
            return _icmsantecip;
        }
        set
        {
            PropriedadeModificada(RO_ICMSANTECIP, value);
            _icmsantecip = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 15, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Ieps
    {
        get
        {
            PropriedadeAcessada(RO_IEPS);
            return _ieps;
        }
        set
        {
            PropriedadeModificada(RO_IEPS, value);
            _ieps = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 15, Precisao = 0)]
    public string Iest
    {
        get
        {
            PropriedadeAcessada(RO_IEST);
            return _iest;
        }
        set
        {
            PropriedadeModificada(RO_IEST, value);
            _iest = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 15, Precisao = 0)]
    public string Iment
    {
        get
        {
            PropriedadeAcessada(RO_IMENT);
            return _iment;
        }
        set
        {
            PropriedadeModificada(RO_IMENT, value);
            _iment = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Importadocrm
    {
        get
        {
            PropriedadeAcessada(RO_IMPORTADOCRM);
            return _importadocrm;
        }
        set
        {
            PropriedadeModificada(RO_IMPORTADOCRM, value);
            _importadocrm = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Incluinoarqsci
    {
        get
        {
            PropriedadeAcessada(RO_INCLUINOARQSCI);
            return _incluinoarqsci;
        }
        set
        {
            PropriedadeModificada(RO_INCLUINOARQSCI, value);
            _incluinoarqsci = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Inicioativ
    {
        get
        {
            PropriedadeAcessada(RO_INICIOATIV);
            return _inicioativ;
        }
        set
        {
            PropriedadeModificada(RO_INICIOATIV, value);
            _inicioativ = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
    public string Inscestadual
    {
        get
        {
            PropriedadeAcessada(RO_INSCESTADUAL);
            return _inscestadual;
        }
        set
        {
            PropriedadeModificada(RO_INSCESTADUAL, value);
            _inscestadual = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Investimento
    {
        get
        {
            PropriedadeAcessada(RO_INVESTIMENTO);
            return _investimento;
        }
        set
        {
            PropriedadeModificada(RO_INVESTIMENTO, value);
            _investimento = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Isencaosuframa
    {
        get
        {
            PropriedadeAcessada(RO_ISENCAOSUFRAMA);
            return _isencaosuframa;
        }
        set
        {
            PropriedadeModificada(RO_ISENCAOSUFRAMA, value);
            _isencaosuframa = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Isentajuros
    {
        get
        {
            PropriedadeAcessada(RO_ISENTAJUROS);
            return _isentajuros;
        }
        set
        {
            PropriedadeModificada(RO_ISENTAJUROS, value);
            _isentajuros = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Isentodifaliquotas
    {
        get
        {
            PropriedadeAcessada(RO_ISENTODIFALIQUOTAS);
            return _isentodifaliquotas;
        }
        set
        {
            PropriedadeModificada(RO_ISENTODIFALIQUOTAS, value);
            _isentodifaliquotas = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Isentoicms
    {
        get
        {
            PropriedadeAcessada(RO_ISENTOICMS);
            return _isentoicms;
        }
        set
        {
            PropriedadeModificada(RO_ISENTOICMS, value);
            _isentoicms = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Isentoipi
    {
        get
        {
            PropriedadeAcessada(RO_ISENTOIPI);
            return _isentoipi;
        }
        set
        {
            PropriedadeModificada(RO_ISENTOIPI, value);
            _isentoipi = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Isentotxboleto
    {
        get
        {
            PropriedadeAcessada(RO_ISENTOTXBOLETO);
            return _isentotxboleto;
        }
        set
        {
            PropriedadeModificada(RO_ISENTOTXBOLETO, value);
            _isentotxboleto = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
    public string Latitude
    {
        get
        {
            PropriedadeAcessada(RO_LATITUDE);
            return _latitude;
        }
        set
        {
            PropriedadeModificada(RO_LATITUDE, value);
            _latitude = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 2)]
    public decimal? Limcred
    {
        get
        {
            PropriedadeAcessada(RO_LIMCRED);
            return _limcred;
        }
        set
        {
            PropriedadeModificada(RO_LIMCRED, value);
            _limcred = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 2)]
    public decimal? Limcredcpf
    {
        get
        {
            PropriedadeAcessada(RO_LIMCREDCPF);
            return _limcredcpf;
        }
        set
        {
            PropriedadeModificada(RO_LIMCREDCPF, value);
            _limcredcpf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
    public string Limiteautori
    {
        get
        {
            PropriedadeAcessada(RO_LIMITEAUTORI);
            return _limiteautori;
        }
        set
        {
            PropriedadeModificada(RO_LIMITEAUTORI, value);
            _limiteautori = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
    public string Listaplpag
    {
        get
        {
            PropriedadeAcessada(RO_LISTAPLPAG);
            return _listaplpag;
        }
        set
        {
            PropriedadeModificada(RO_LISTAPLPAG, value);
            _listaplpag = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
    public string Longitude
    {
        get
        {
            PropriedadeAcessada(RO_LONGITUDE);
            return _longitude;
        }
        set
        {
            PropriedadeModificada(RO_LONGITUDE, value);
            _longitude = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Medcodfunclibtribut
    {
        get
        {
            PropriedadeAcessada(RO_MEDCODFUNCLIBTRIBUT);
            return _medcodfunclibtribut;
        }
        set
        {
            PropriedadeModificada(RO_MEDCODFUNCLIBTRIBUT, value);
            _medcodfunclibtribut = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Meddtlibtribut
    {
        get
        {
            PropriedadeAcessada(RO_MEDDTLIBTRIBUT);
            return _meddtlibtribut;
        }
        set
        {
            PropriedadeModificada(RO_MEDDTLIBTRIBUT, value);
            _meddtlibtribut = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Microempresa
    {
        get
        {
            PropriedadeAcessada(RO_MICROEMPRESA);
            return _microempresa;
        }
        set
        {
            PropriedadeModificada(RO_MICROEMPRESA, value);
            _microempresa = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 2, Precisao = 0)]
    public decimal? Minutoproxcontato
    {
        get
        {
            PropriedadeAcessada(RO_MINUTOPROXCONTATO);
            return _minutoproxcontato;
        }
        set
        {
            PropriedadeModificada(RO_MINUTOPROXCONTATO, value);
            _minutoproxcontato = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
    public string Motivoexclusao
    {
        get
        {
            PropriedadeAcessada(RO_MOTIVOEXCLUSAO);
            return _motivoexclusao;
        }
        set
        {
            PropriedadeModificada(RO_MOTIVOEXCLUSAO, value);
            _motivoexclusao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 15, Precisao = 0)]
    public string Municcob
    {
        get
        {
            PropriedadeAcessada(RO_MUNICCOB);
            return _municcob;
        }
        set
        {
            PropriedadeModificada(RO_MUNICCOB, value);
            _municcob = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 100, Precisao = 0)]
    public string Municcob2
    {
        get
        {
            PropriedadeAcessada(RO_MUNICCOB2);
            return _municcob2;
        }
        set
        {
            PropriedadeModificada(RO_MUNICCOB2, value);
            _municcob2 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 15, Precisao = 0)]
    public string Municcom
    {
        get
        {
            PropriedadeAcessada(RO_MUNICCOM);
            return _municcom;
        }
        set
        {
            PropriedadeModificada(RO_MUNICCOM, value);
            _municcom = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 100, Precisao = 0)]
    public string Municcom2
    {
        get
        {
            PropriedadeAcessada(RO_MUNICCOM2);
            return _municcom2;
        }
        set
        {
            PropriedadeModificada(RO_MUNICCOM2, value);
            _municcom2 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 15, Precisao = 0)]
    public string Municconjuge
    {
        get
        {
            PropriedadeAcessada(RO_MUNICCONJUGE);
            return _municconjuge;
        }
        set
        {
            PropriedadeModificada(RO_MUNICCONJUGE, value);
            _municconjuge = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 15, Precisao = 0)]
    public string Municempr
    {
        get
        {
            PropriedadeAcessada(RO_MUNICEMPR);
            return _municempr;
        }
        set
        {
            PropriedadeModificada(RO_MUNICEMPR, value);
            _municempr = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 15, Precisao = 0)]
    public string Municent
    {
        get
        {
            PropriedadeAcessada(RO_MUNICENT);
            return _municent;
        }
        set
        {
            PropriedadeModificada(RO_MUNICENT, value);
            _municent = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 100, Precisao = 0)]
    public string Municent2
    {
        get
        {
            PropriedadeAcessada(RO_MUNICENT2);
            return _municent2;
        }
        set
        {
            PropriedadeModificada(RO_MUNICENT2, value);
            _municent2 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
    public string Nomeconjuge
    {
        get
        {
            PropriedadeAcessada(RO_NOMECONJUGE);
            return _nomeconjuge;
        }
        set
        {
            PropriedadeModificada(RO_NOMECONJUGE, value);
            _nomeconjuge = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Numagencia1
    {
        get
        {
            PropriedadeAcessada(RO_NUMAGENCIA1);
            return _numagencia1;
        }
        set
        {
            PropriedadeModificada(RO_NUMAGENCIA1, value);
            _numagencia1 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Numagencia2
    {
        get
        {
            PropriedadeAcessada(RO_NUMAGENCIA2);
            return _numagencia2;
        }
        set
        {
            PropriedadeModificada(RO_NUMAGENCIA2, value);
            _numagencia2 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 30, Precisao = 0)]
    public string Numalvara
    {
        get
        {
            PropriedadeAcessada(RO_NUMALVARA);
            return _numalvara;
        }
        set
        {
            PropriedadeModificada(RO_NUMALVARA, value);
            _numalvara = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
    public string Numalvaraanvisa
    {
        get
        {
            PropriedadeAcessada(RO_NUMALVARAANVISA);
            return _numalvaraanvisa;
        }
        set
        {
            PropriedadeModificada(RO_NUMALVARAANVISA, value);
            _numalvaraanvisa = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 30, Precisao = 0)]
    public string Numalvarafunc
    {
        get
        {
            PropriedadeAcessada(RO_NUMALVARAFUNC);
            return _numalvarafunc;
        }
        set
        {
            PropriedadeModificada(RO_NUMALVARAFUNC, value);
            _numalvarafunc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 30, Precisao = 0)]
    public string Numalvarasus
    {
        get
        {
            PropriedadeAcessada(RO_NUMALVARASUS);
            return _numalvarasus;
        }
        set
        {
            PropriedadeModificada(RO_NUMALVARASUS, value);
            _numalvarasus = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 3, Precisao = 0)]
    public decimal? Numbanco1
    {
        get
        {
            PropriedadeAcessada(RO_NUMBANCO1);
            return _numbanco1;
        }
        set
        {
            PropriedadeModificada(RO_NUMBANCO1, value);
            _numbanco1 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 3, Precisao = 0)]
    public decimal? Numbanco2
    {
        get
        {
            PropriedadeAcessada(RO_NUMBANCO2);
            return _numbanco2;
        }
        set
        {
            PropriedadeModificada(RO_NUMBANCO2, value);
            _numbanco2 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
    public string Numcartaofidelidade
    {
        get
        {
            PropriedadeAcessada(RO_NUMCARTAOFIDELIDADE);
            return _numcartaofidelidade;
        }
        set
        {
            PropriedadeModificada(RO_NUMCARTAOFIDELIDADE, value);
            _numcartaofidelidade = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 15, Precisao = 0)]
    public string Numccorrente1
    {
        get
        {
            PropriedadeAcessada(RO_NUMCCORRENTE1);
            return _numccorrente1;
        }
        set
        {
            PropriedadeModificada(RO_NUMCCORRENTE1, value);
            _numccorrente1 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 15, Precisao = 0)]
    public string Numccorrente2
    {
        get
        {
            PropriedadeAcessada(RO_NUMCCORRENTE2);
            return _numccorrente2;
        }
        set
        {
            PropriedadeModificada(RO_NUMCCORRENTE2, value);
            _numccorrente2 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 12, Precisao = 0)]
    public string Numconcessao
    {
        get
        {
            PropriedadeAcessada(RO_NUMCONCESSAO);
            return _numconcessao;
        }
        set
        {
            PropriedadeModificada(RO_NUMCONCESSAO, value);
            _numconcessao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
    public string Numcrf
    {
        get
        {
            PropriedadeAcessada(RO_NUMCRF);
            return _numcrf;
        }
        set
        {
            PropriedadeModificada(RO_NUMCRF, value);
            _numcrf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 10, Precisao = 0)]
    public string Numcrm
    {
        get
        {
            PropriedadeAcessada(RO_NUMCRM);
            return _numcrm;
        }
        set
        {
            PropriedadeModificada(RO_NUMCRM, value);
            _numcrm = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 6, Precisao = 0)]
    public string Numerocob
    {
        get
        {
            PropriedadeAcessada(RO_NUMEROCOB);
            return _numerocob;
        }
        set
        {
            PropriedadeModificada(RO_NUMEROCOB, value);
            _numerocob = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 6, Precisao = 0)]
    public string Numerocom
    {
        get
        {
            PropriedadeAcessada(RO_NUMEROCOM);
            return _numerocom;
        }
        set
        {
            PropriedadeModificada(RO_NUMEROCOM, value);
            _numerocom = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 6, Precisao = 0)]
    public string Numeroent
    {
        get
        {
            PropriedadeAcessada(RO_NUMEROENT);
            return _numeroent;
        }
        set
        {
            PropriedadeModificada(RO_NUMEROENT, value);
            _numeroent = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Numregiaocli
    {
        get
        {
            PropriedadeAcessada(RO_NUMREGIAOCLI);
            return _numregiaocli;
        }
        set
        {
            PropriedadeModificada(RO_NUMREGIAOCLI, value);
            _numregiaocli = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
    public string Numregistroimune
    {
        get
        {
            PropriedadeAcessada(RO_NUMREGISTROIMUNE);
            return _numregistroimune;
        }
        set
        {
            PropriedadeModificada(RO_NUMREGISTROIMUNE, value);
            _numregistroimune = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 0, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Numseqrotarca
    {
        get
        {
            PropriedadeAcessada(RO_NUMSEQROTARCA);
            return _numseqrotarca;
        }
        set
        {
            PropriedadeModificada(RO_NUMSEQROTARCA, value);
            _numseqrotarca = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
    public string Numtare
    {
        get
        {
            PropriedadeAcessada(RO_NUMTARE);
            return _numtare;
        }
        set
        {
            PropriedadeModificada(RO_NUMTARE, value);
            _numtare = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 0)]
    public decimal? Numtransvendadesc
    {
        get
        {
            PropriedadeAcessada(RO_NUMTRANSVENDADESC);
            return _numtransvendadesc;
        }
        set
        {
            PropriedadeModificada(RO_NUMTRANSVENDADESC, value);
            _numtransvendadesc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Binario, Tamanho = 4000, Precisao = 0)]
    public string Obs_Adic
    {
        get
        {
            PropriedadeAcessada(RO_OBS_ADIC);
            return _obs_adic;
        }
        set
        {
            PropriedadeModificada(RO_OBS_ADIC, value);
            _obs_adic = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 4000, Precisao = 0)]
    public string Obscallcenter
    {
        get
        {
            PropriedadeAcessada(RO_OBSCALLCENTER);
            return _obscallcenter;
        }
        set
        {
            PropriedadeModificada(RO_OBSCALLCENTER, value);
            _obscallcenter = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 30, Precisao = 0)]
    public string Obscredito
    {
        get
        {
            PropriedadeAcessada(RO_OBSCREDITO);
            return _obscredito;
        }
        set
        {
            PropriedadeModificada(RO_OBSCREDITO, value);
            _obscredito = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 75, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 75, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 75, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 75, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2000, Precisao = 0)]
    public string Observacao
    {
        get
        {
            PropriedadeAcessada(RO_OBSERVACAO);
            return _observacao;
        }
        set
        {
            PropriedadeModificada(RO_OBSERVACAO, value);
            _observacao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 80, Precisao = 0)]
    public string Obsgerencial1
    {
        get
        {
            PropriedadeAcessada(RO_OBSGERENCIAL1);
            return _obsgerencial1;
        }
        set
        {
            PropriedadeModificada(RO_OBSGERENCIAL1, value);
            _obsgerencial1 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 80, Precisao = 0)]
    public string Obsgerencial2
    {
        get
        {
            PropriedadeAcessada(RO_OBSGERENCIAL2);
            return _obsgerencial2;
        }
        set
        {
            PropriedadeModificada(RO_OBSGERENCIAL2, value);
            _obsgerencial2 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 80, Precisao = 0)]
    public string Obsgerencial3
    {
        get
        {
            PropriedadeAcessada(RO_OBSGERENCIAL3);
            return _obsgerencial3;
        }
        set
        {
            PropriedadeModificada(RO_OBSGERENCIAL3, value);
            _obsgerencial3 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 4000, Precisao = 0)]
    public string Obsrecepcao
    {
        get
        {
            PropriedadeAcessada(RO_OBSRECEPCAO);
            return _obsrecepcao;
        }
        set
        {
            PropriedadeModificada(RO_OBSRECEPCAO, value);
            _obsrecepcao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 80, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 4000, Precisao = 0)]
    public string Obstesouraria
    {
        get
        {
            PropriedadeAcessada(RO_OBSTESOURARIA);
            return _obstesouraria;
        }
        set
        {
            PropriedadeModificada(RO_OBSTESOURARIA, value);
            _obstesouraria = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 60, Precisao = 0)]
    public string Obs3
    {
        get
        {
            PropriedadeAcessada(RO_OBS3);
            return _obs3;
        }
        set
        {
            PropriedadeModificada(RO_OBS3, value);
            _obs3 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 60, Precisao = 0)]
    public string Obs4
    {
        get
        {
            PropriedadeAcessada(RO_OBS4);
            return _obs4;
        }
        set
        {
            PropriedadeModificada(RO_OBS4, value);
            _obs4 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 60, Precisao = 0)]
    public string Obs5
    {
        get
        {
            PropriedadeAcessada(RO_OBS5);
            return _obs5;
        }
        set
        {
            PropriedadeModificada(RO_OBS5, value);
            _obs5 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Orgaopubfederal
    {
        get
        {
            PropriedadeAcessada(RO_ORGAOPUBFEDERAL);
            return _orgaopubfederal;
        }
        set
        {
            PropriedadeModificada(RO_ORGAOPUBFEDERAL, value);
            _orgaopubfederal = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 4, Precisao = 0)]
    public string Orgaorg
    {
        get
        {
            PropriedadeAcessada(RO_ORGAORG);
            return _orgaorg;
        }
        set
        {
            PropriedadeModificada(RO_ORGAORG, value);
            _orgaorg = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 4, Precisao = 0)]
    public string Orgaorgconj
    {
        get
        {
            PropriedadeAcessada(RO_ORGAORGCONJ);
            return _orgaorgconj;
        }
        set
        {
            PropriedadeModificada(RO_ORGAORGCONJ, value);
            _orgaorgconj = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Origempreco
    {
        get
        {
            PropriedadeAcessada(RO_ORIGEMPRECO);
            return _origempreco;
        }
        set
        {
            PropriedadeModificada(RO_ORIGEMPRECO, value);
            _origempreco = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 18, Precisao = 0)]
    public string Paisent
    {
        get
        {
            PropriedadeAcessada(RO_PAISENT);
            return _paisent;
        }
        set
        {
            PropriedadeModificada(RO_PAISENT, value);
            _paisent = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Paraibasim
    {
        get
        {
            PropriedadeAcessada(RO_PARAIBASIM);
            return _paraibasim;
        }
        set
        {
            PropriedadeModificada(RO_PARAIBASIM, value);
            _paraibasim = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Participafuncep
    {
        get
        {
            PropriedadeAcessada(RO_PARTICIPAFUNCEP);
            return _participafuncep;
        }
        set
        {
            PropriedadeModificada(RO_PARTICIPAFUNCEP, value);
            _participafuncep = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Pdvinvestimento
    {
        get
        {
            PropriedadeAcessada(RO_PDVINVESTIMENTO);
            return _pdvinvestimento;
        }
        set
        {
            PropriedadeModificada(RO_PDVINVESTIMENTO, value);
            _pdvinvestimento = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 2)]
    public decimal? Peracrestransf
    {
        get
        {
            PropriedadeAcessada(RO_PERACRESTRANSF);
            return _peracrestransf;
        }
        set
        {
            PropriedadeModificada(RO_PERACRESTRANSF, value);
            _peracrestransf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 2)]
    public decimal? Perbasevend
    {
        get
        {
            PropriedadeAcessada(RO_PERBASEVEND);
            return _perbasevend;
        }
        set
        {
            PropriedadeModificada(RO_PERBASEVEND, value);
            _perbasevend = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 2)]
    public decimal? Percbasevendqt
    {
        get
        {
            PropriedadeAcessada(RO_PERCBASEVENDQT);
            return _percbasevendqt;
        }
        set
        {
            PropriedadeModificada(RO_PERCBASEVENDQT, value);
            _percbasevendqt = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 2)]
    public decimal? Percbonific
    {
        get
        {
            PropriedadeAcessada(RO_PERCBONIFIC);
            return _percbonific;
        }
        set
        {
            PropriedadeModificada(RO_PERCBONIFIC, value);
            _percbonific = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 2)]
    public decimal? Percomcli
    {
        get
        {
            PropriedadeAcessada(RO_PERCOMCLI);
            return _percomcli;
        }
        set
        {
            PropriedadeModificada(RO_PERCOMCLI, value);
            _percomcli = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 4)]
    public decimal? Perctolvalidadeprodwms
    {
        get
        {
            PropriedadeAcessada(RO_PERCTOLVALIDADEPRODWMS);
            return _perctolvalidadeprodwms;
        }
        set
        {
            PropriedadeModificada(RO_PERCTOLVALIDADEPRODWMS, value);
            _perctolvalidadeprodwms = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 2)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 2)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 2)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 2)]
    public decimal? Perdesc2
    {
        get
        {
            PropriedadeAcessada(RO_PERDESC2);
            return _perdesc2;
        }
        set
        {
            PropriedadeModificada(RO_PERDESC2, value);
            _perdesc2 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 2)]
    public decimal? Perdesc3
    {
        get
        {
            PropriedadeAcessada(RO_PERDESC3);
            return _perdesc3;
        }
        set
        {
            PropriedadeModificada(RO_PERDESC3, value);
            _perdesc3 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 2)]
    public decimal? Perdesc4
    {
        get
        {
            PropriedadeAcessada(RO_PERDESC4);
            return _perdesc4;
        }
        set
        {
            PropriedadeModificada(RO_PERDESC4, value);
            _perdesc4 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 2)]
    public decimal? Perdesc5
    {
        get
        {
            PropriedadeAcessada(RO_PERDESC5);
            return _perdesc5;
        }
        set
        {
            PropriedadeModificada(RO_PERDESC5, value);
            _perdesc5 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Perfretebroker
    {
        get
        {
            PropriedadeAcessada(RO_PERFRETEBROKER);
            return _perfretebroker;
        }
        set
        {
            PropriedadeModificada(RO_PERFRETEBROKER, value);
            _perfretebroker = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 9, Precisao = 0)]
    public decimal? Periodvistoria
    {
        get
        {
            PropriedadeAcessada(RO_PERIODVISTORIA);
            return _periodvistoria;
        }
        set
        {
            PropriedadeModificada(RO_PERIODVISTORIA, value);
            _periodvistoria = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 7, Precisao = 4)]
    public decimal? Perminvalidade
    {
        get
        {
            PropriedadeAcessada(RO_PERMINVALIDADE);
            return _perminvalidade;
        }
        set
        {
            PropriedadeModificada(RO_PERMINVALIDADE, value);
            _perminvalidade = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Permitealtercobrancacr
    {
        get
        {
            PropriedadeAcessada(RO_PERMITEALTERCOBRANCACR);
            return _permitealtercobrancacr;
        }
        set
        {
            PropriedadeModificada(RO_PERMITEALTERCOBRANCACR, value);
            _permitealtercobrancacr = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Piscofinscumulativo
    {
        get
        {
            PropriedadeAcessada(RO_PISCOFINSCUMULATIVO);
            return _piscofinscumulativo;
        }
        set
        {
            PropriedadeModificada(RO_PISCOFINSCUMULATIVO, value);
            _piscofinscumulativo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Plpagneg
    {
        get
        {
            PropriedadeAcessada(RO_PLPAGNEG);
            return _plpagneg;
        }
        set
        {
            PropriedadeModificada(RO_PLPAGNEG, value);
            _plpagneg = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Plpagneg2
    {
        get
        {
            PropriedadeAcessada(RO_PLPAGNEG2);
            return _plpagneg2;
        }
        set
        {
            PropriedadeModificada(RO_PLPAGNEG2, value);
            _plpagneg2 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
    public string Pontorefer
    {
        get
        {
            PropriedadeAcessada(RO_PONTOREFER);
            return _pontorefer;
        }
        set
        {
            PropriedadeModificada(RO_PONTOREFER, value);
            _pontorefer = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Prazoadicional2
    {
        get
        {
            PropriedadeAcessada(RO_PRAZOADICIONAL2);
            return _prazoadicional2;
        }
        set
        {
            PropriedadeModificada(RO_PRAZOADICIONAL2, value);
            _prazoadicional2 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Prazoadicional3
    {
        get
        {
            PropriedadeAcessada(RO_PRAZOADICIONAL3);
            return _prazoadicional3;
        }
        set
        {
            PropriedadeModificada(RO_PRAZOADICIONAL3, value);
            _prazoadicional3 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Prazoadicional4
    {
        get
        {
            PropriedadeAcessada(RO_PRAZOADICIONAL4);
            return _prazoadicional4;
        }
        set
        {
            PropriedadeModificada(RO_PRAZOADICIONAL4, value);
            _prazoadicional4 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Prazoadicional5
    {
        get
        {
            PropriedadeAcessada(RO_PRAZOADICIONAL5);
            return _prazoadicional5;
        }
        set
        {
            PropriedadeModificada(RO_PRAZOADICIONAL5, value);
            _prazoadicional5 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Prazoadicional6
    {
        get
        {
            PropriedadeAcessada(RO_PRAZOADICIONAL6);
            return _prazoadicional6;
        }
        set
        {
            PropriedadeModificada(RO_PRAZOADICIONAL6, value);
            _prazoadicional6 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Prazoadicional7
    {
        get
        {
            PropriedadeAcessada(RO_PRAZOADICIONAL7);
            return _prazoadicional7;
        }
        set
        {
            PropriedadeModificada(RO_PRAZOADICIONAL7, value);
            _prazoadicional7 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Prazomaxvalidade
    {
        get
        {
            PropriedadeAcessada(RO_PRAZOMAXVALIDADE);
            return _prazomaxvalidade;
        }
        set
        {
            PropriedadeModificada(RO_PRAZOMAXVALIDADE, value);
            _prazomaxvalidade = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Prazovalidade
    {
        get
        {
            PropriedadeAcessada(RO_PRAZOVALIDADE);
            return _prazovalidade;
        }
        set
        {
            PropriedadeModificada(RO_PRAZOVALIDADE, value);
            _prazovalidade = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 3, Precisao = 0)]
    public decimal? Prazovencst
    {
        get
        {
            PropriedadeAcessada(RO_PRAZOVENCST);
            return _prazovencst;
        }
        set
        {
            PropriedadeModificada(RO_PRAZOVENCST, value);
            _prazovencst = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Prazovenda
    {
        get
        {
            PropriedadeAcessada(RO_PRAZOVENDA);
            return _prazovenda;
        }
        set
        {
            PropriedadeModificada(RO_PRAZOVENDA, value);
            _prazovenda = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Precoutilizadonfe
    {
        get
        {
            PropriedadeAcessada(RO_PRECOUTILIZADONFE);
            return _precoutilizadonfe;
        }
        set
        {
            PropriedadeModificada(RO_PRECOUTILIZADONFE, value);
            _precoutilizadonfe = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Predioproprio
    {
        get
        {
            PropriedadeAcessada(RO_PREDIOPROPRIO);
            return _predioproprio;
        }
        set
        {
            PropriedadeModificada(RO_PREDIOPROPRIO, value);
            _predioproprio = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Qtcheckout
    {
        get
        {
            PropriedadeAcessada(RO_QTCHECKOUT);
            return _qtcheckout;
        }
        set
        {
            PropriedadeModificada(RO_QTCHECKOUT, value);
            _qtcheckout = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Qtddiasaplicdescfin
    {
        get
        {
            PropriedadeAcessada(RO_QTDDIASAPLICDESCFIN);
            return _qtddiasaplicdescfin;
        }
        set
        {
            PropriedadeModificada(RO_QTDDIASAPLICDESCFIN, value);
            _qtddiasaplicdescfin = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 2, Precisao = 0)]
    public decimal? Qtestrela
    {
        get
        {
            PropriedadeAcessada(RO_QTESTRELA);
            return _qtestrela;
        }
        set
        {
            PropriedadeModificada(RO_QTESTRELA, value);
            _qtestrela = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Ratingsci
    {
        get
        {
            PropriedadeAcessada(RO_RATINGSCI);
            return _ratingsci;
        }
        set
        {
            PropriedadeModificada(RO_RATINGSCI, value);
            _ratingsci = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Ratingsci1
    {
        get
        {
            PropriedadeAcessada(RO_RATINGSCI1);
            return _ratingsci1;
        }
        set
        {
            PropriedadeModificada(RO_RATINGSCI1, value);
            _ratingsci1 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Ratingsci2
    {
        get
        {
            PropriedadeAcessada(RO_RATINGSCI2);
            return _ratingsci2;
        }
        set
        {
            PropriedadeModificada(RO_RATINGSCI2, value);
            _ratingsci2 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 30, Precisao = 0)]
    public string Registroibama
    {
        get
        {
            PropriedadeAcessada(RO_REGISTROIBAMA);
            return _registroibama;
        }
        set
        {
            PropriedadeModificada(RO_REGISTROIBAMA, value);
            _registroibama = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 15, Precisao = 0)]
    public string Regjuntacomercial
    {
        get
        {
            PropriedadeAcessada(RO_REGJUNTACOMERCIAL);
            return _regjuntacomercial;
        }
        set
        {
            PropriedadeModificada(RO_REGJUNTACOMERCIAL, value);
            _regjuntacomercial = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 2)]
    public decimal? Rendamensal
    {
        get
        {
            PropriedadeAcessada(RO_RENDAMENSAL);
            return _rendamensal;
        }
        set
        {
            PropriedadeModificada(RO_RENDAMENSAL, value);
            _rendamensal = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 2)]
    public decimal? Rendamensalconjuge
    {
        get
        {
            PropriedadeAcessada(RO_RENDAMENSALCONJUGE);
            return _rendamensalconjuge;
        }
        set
        {
            PropriedadeModificada(RO_RENDAMENSALCONJUGE, value);
            _rendamensalconjuge = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Repasse
    {
        get
        {
            PropriedadeAcessada(RO_REPASSE);
            return _repasse;
        }
        set
        {
            PropriedadeModificada(RO_REPASSE, value);
            _repasse = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Ressarcimentost
    {
        get
        {
            PropriedadeAcessada(RO_RESSARCIMENTOST);
            return _ressarcimentost;
        }
        set
        {
            PropriedadeModificada(RO_RESSARCIMENTOST, value);
            _ressarcimentost = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Retencaoiss
    {
        get
        {
            PropriedadeAcessada(RO_RETENCAOISS);
            return _retencaoiss;
        }
        set
        {
            PropriedadeModificada(RO_RETENCAOISS, value);
            _retencaoiss = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
    public string Rfc
    {
        get
        {
            PropriedadeAcessada(RO_RFC);
            return _rfc;
        }
        set
        {
            PropriedadeModificada(RO_RFC, value);
            _rfc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
    public string Rg
    {
        get
        {
            PropriedadeAcessada(RO_RG);
            return _rg;
        }
        set
        {
            PropriedadeModificada(RO_RG, value);
            _rg = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
    public string Rgconj
    {
        get
        {
            PropriedadeAcessada(RO_RGCONJ);
            return _rgconj;
        }
        set
        {
            PropriedadeModificada(RO_RGCONJ, value);
            _rgconj = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
    public string Roteiromasterfoods
    {
        get
        {
            PropriedadeAcessada(RO_ROTEIROMASTERFOODS);
            return _roteiromasterfoods;
        }
        set
        {
            PropriedadeModificada(RO_ROTEIROMASTERFOODS, value);
            _roteiromasterfoods = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Sacadoeletronico
    {
        get
        {
            PropriedadeAcessada(RO_SACADOELETRONICO);
            return _sacadoeletronico;
        }
        set
        {
            PropriedadeModificada(RO_SACADOELETRONICO, value);
            _sacadoeletronico = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 18, Precisao = 0)]
    public string Senha_Web
    {
        get
        {
            PropriedadeAcessada(RO_SENHA_WEB);
            return _senha_web;
        }
        set
        {
            PropriedadeModificada(RO_SENHA_WEB, value);
            _senha_web = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Sexo
    {
        get
        {
            PropriedadeAcessada(RO_SEXO);
            return _sexo;
        }
        set
        {
            PropriedadeModificada(RO_SEXO, value);
            _sexo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 5, Precisao = 0)]
    public string Sigladec
    {
        get
        {
            PropriedadeAcessada(RO_SIGLADEC);
            return _sigladec;
        }
        set
        {
            PropriedadeModificada(RO_SIGLADEC, value);
            _sigladec = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 80, Precisao = 0)]
    public string Site
    {
        get
        {
            PropriedadeAcessada(RO_SITE);
            return _site;
        }
        set
        {
            PropriedadeModificada(RO_SITE, value);
            _site = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Statusconsultasintegra
    {
        get
        {
            PropriedadeAcessada(RO_STATUSCONSULTASINTEGRA);
            return _statusconsultasintegra;
        }
        set
        {
            PropriedadeModificada(RO_STATUSCONSULTASINTEGRA, value);
            _statusconsultasintegra = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 15, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Suprimido
    {
        get
        {
            PropriedadeAcessada(RO_SUPRIMIDO);
            return _suprimido;
        }
        set
        {
            PropriedadeModificada(RO_SUPRIMIDO, value);
            _suprimido = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Sus
    {
        get
        {
            PropriedadeAcessada(RO_SUS);
            return _sus;
        }
        set
        {
            PropriedadeModificada(RO_SUS, value);
            _sus = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 13, Precisao = 0)]
    public string Telcelent
    {
        get
        {
            PropriedadeAcessada(RO_TELCELENT);
            return _telcelent;
        }
        set
        {
            PropriedadeModificada(RO_TELCELENT, value);
            _telcelent = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 13, Precisao = 0)]
    public string Telcob
    {
        get
        {
            PropriedadeAcessada(RO_TELCOB);
            return _telcob;
        }
        set
        {
            PropriedadeModificada(RO_TELCOB, value);
            _telcob = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 13, Precisao = 0)]
    public string Telcom
    {
        get
        {
            PropriedadeAcessada(RO_TELCOM);
            return _telcom;
        }
        set
        {
            PropriedadeModificada(RO_TELCOM, value);
            _telcom = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 13, Precisao = 0)]
    public string Telconjuge
    {
        get
        {
            PropriedadeAcessada(RO_TELCONJUGE);
            return _telconjuge;
        }
        set
        {
            PropriedadeModificada(RO_TELCONJUGE, value);
            _telconjuge = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 13, Precisao = 0)]
    public string Telempr
    {
        get
        {
            PropriedadeAcessada(RO_TELEMPR);
            return _telempr;
        }
        set
        {
            PropriedadeModificada(RO_TELEMPR, value);
            _telempr = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 13, Precisao = 0)]
    public string Telent
    {
        get
        {
            PropriedadeAcessada(RO_TELENT);
            return _telent;
        }
        set
        {
            PropriedadeModificada(RO_TELENT, value);
            _telent = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 13, Precisao = 0)]
    public string Telent1
    {
        get
        {
            PropriedadeAcessada(RO_TELENT1);
            return _telent1;
        }
        set
        {
            PropriedadeModificada(RO_TELENT1, value);
            _telent1 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Tipoativcli
    {
        get
        {
            PropriedadeAcessada(RO_TIPOATIVCLI);
            return _tipoativcli;
        }
        set
        {
            PropriedadeModificada(RO_TIPOATIVCLI, value);
            _tipoativcli = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Tipoclimed
    {
        get
        {
            PropriedadeAcessada(RO_TIPOCLIMED);
            return _tipoclimed;
        }
        set
        {
            PropriedadeModificada(RO_TIPOCLIMED, value);
            _tipoclimed = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Tipoconversaotv4
    {
        get
        {
            PropriedadeAcessada(RO_TIPOCONVERSAOTV4);
            return _tipoconversaotv4;
        }
        set
        {
            PropriedadeModificada(RO_TIPOCONVERSAOTV4, value);
            _tipoconversaotv4 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Tipocustotransf
    {
        get
        {
            PropriedadeAcessada(RO_TIPOCUSTOTRANSF);
            return _tipocustotransf;
        }
        set
        {
            PropriedadeModificada(RO_TIPOCUSTOTRANSF, value);
            _tipocustotransf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Tipocustotransf_Filiais
    {
        get
        {
            PropriedadeAcessada(RO_TIPOCUSTOTRANSF_FILIAIS);
            return _tipocustotransf_filiais;
        }
        set
        {
            PropriedadeModificada(RO_TIPOCUSTOTRANSF_FILIAIS, value);
            _tipocustotransf_filiais = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Tipocustotransf_Filialvirtual
    {
        get
        {
            PropriedadeAcessada(RO_TIPOCUSTOTRANSF_FILIALVIRTUAL);
            return _tipocustotransf_filialvirtual;
        }
        set
        {
            PropriedadeModificada(RO_TIPOCUSTOTRANSF_FILIALVIRTUAL, value);
            _tipocustotransf_filialvirtual = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Tipodescisencao
    {
        get
        {
            PropriedadeAcessada(RO_TIPODESCISENCAO);
            return _tipodescisencao;
        }
        set
        {
            PropriedadeModificada(RO_TIPODESCISENCAO, value);
            _tipodescisencao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Tipotratamentodescfin
    {
        get
        {
            PropriedadeAcessada(RO_TIPOTRATAMENTODESCFIN);
            return _tipotratamentodescfin;
        }
        set
        {
            PropriedadeModificada(RO_TIPOTRATAMENTODESCFIN, value);
            _tipotratamentodescfin = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Tipoultalter
    {
        get
        {
            PropriedadeAcessada(RO_TIPOULTALTER);
            return _tipoultalter;
        }
        set
        {
            PropriedadeModificada(RO_TIPOULTALTER, value);
            _tipoultalter = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Ufrg
    {
        get
        {
            PropriedadeAcessada(RO_UFRG);
            return _ufrg;
        }
        set
        {
            PropriedadeModificada(RO_UFRG, value);
            _ufrg = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Ultcodplpag
    {
        get
        {
            PropriedadeAcessada(RO_ULTCODPLPAG);
            return _ultcodplpag;
        }
        set
        {
            PropriedadeModificada(RO_ULTCODPLPAG, value);
            _ultcodplpag = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Usabkcnpjcodcliprinc
    {
        get
        {
            PropriedadeAcessada(RO_USABKCNPJCODCLIPRINC);
            return _usabkcnpjcodcliprinc;
        }
        set
        {
            PropriedadeModificada(RO_USABKCNPJCODCLIPRINC, value);
            _usabkcnpjcodcliprinc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Usacreclifat
    {
        get
        {
            PropriedadeAcessada(RO_USACRECLIFAT);
            return _usacreclifat;
        }
        set
        {
            PropriedadeModificada(RO_USACRECLIFAT, value);
            _usacreclifat = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Usacross
    {
        get
        {
            PropriedadeAcessada(RO_USACROSS);
            return _usacross;
        }
        set
        {
            PropriedadeModificada(RO_USACROSS, value);
            _usacross = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Usadescfinseparadodesccom
    {
        get
        {
            PropriedadeAcessada(RO_USADESCFINSEPARADODESCCOM);
            return _usadescfinseparadodesccom;
        }
        set
        {
            PropriedadeModificada(RO_USADESCFINSEPARADODESCCOM, value);
            _usadescfinseparadodesccom = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Usadescontoicms
    {
        get
        {
            PropriedadeAcessada(RO_USADESCONTOICMS);
            return _usadescontoicms;
        }
        set
        {
            PropriedadeModificada(RO_USADESCONTOICMS, value);
            _usadescontoicms = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Usaivafontediferenciado
    {
        get
        {
            PropriedadeAcessada(RO_USAIVAFONTEDIFERENCIADO);
            return _usaivafontediferenciado;
        }
        set
        {
            PropriedadeModificada(RO_USAIVAFONTEDIFERENCIADO, value);
            _usaivafontediferenciado = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Usavlminvendabk
    {
        get
        {
            PropriedadeAcessada(RO_USAVLMINVENDABK);
            return _usavlminvendabk;
        }
        set
        {
            PropriedadeModificada(RO_USAVLMINVENDABK, value);
            _usavlminvendabk = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Utilizaiesimplificada
    {
        get
        {
            PropriedadeAcessada(RO_UTILIZAIESIMPLIFICADA);
            return _utilizaiesimplificada;
        }
        set
        {
            PropriedadeModificada(RO_UTILIZAIESIMPLIFICADA, value);
            _utilizaiesimplificada = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Utilizapedclinfe
    {
        get
        {
            PropriedadeAcessada(RO_UTILIZAPEDCLINFE);
            return _utilizapedclinfe;
        }
        set
        {
            PropriedadeModificada(RO_UTILIZAPEDCLINFE, value);
            _utilizapedclinfe = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Utilizaplpagmedicamento
    {
        get
        {
            PropriedadeAcessada(RO_UTILIZAPLPAGMEDICAMENTO);
            return _utilizaplpagmedicamento;
        }
        set
        {
            PropriedadeModificada(RO_UTILIZAPLPAGMEDICAMENTO, value);
            _utilizaplpagmedicamento = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Utilizaprazomedioplpag
    {
        get
        {
            PropriedadeAcessada(RO_UTILIZAPRAZOMEDIOPLPAG);
            return _utilizaprazomedioplpag;
        }
        set
        {
            PropriedadeModificada(RO_UTILIZAPRAZOMEDIOPLPAG, value);
            _utilizaprazomedioplpag = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Validamaxvendapf
    {
        get
        {
            PropriedadeAcessada(RO_VALIDAMAXVENDAPF);
            return _validamaxvendapf;
        }
        set
        {
            PropriedadeModificada(RO_VALIDAMAXVENDAPF, value);
            _validamaxvendapf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Validarcampanhabrinde
    {
        get
        {
            PropriedadeAcessada(RO_VALIDARCAMPANHABRINDE);
            return _validarcampanhabrinde;
        }
        set
        {
            PropriedadeModificada(RO_VALIDARCAMPANHABRINDE, value);
            _validarcampanhabrinde = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Validarmultiplovenda
    {
        get
        {
            PropriedadeAcessada(RO_VALIDARMULTIPLOVENDA);
            return _validarmultiplovenda;
        }
        set
        {
            PropriedadeModificada(RO_VALIDARMULTIPLOVENDA, value);
            _validarmultiplovenda = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 2)]
    public decimal? Valoraluguel
    {
        get
        {
            PropriedadeAcessada(RO_VALORALUGUEL);
            return _valoraluguel;
        }
        set
        {
            PropriedadeModificada(RO_VALORALUGUEL, value);
            _valoraluguel = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Vip
    {
        get
        {
            PropriedadeAcessada(RO_VIP);
            return _vip;
        }
        set
        {
            PropriedadeModificada(RO_VIP, value);
            _vip = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 2)]
    public decimal? Vlestoque
    {
        get
        {
            PropriedadeAcessada(RO_VLESTOQUE);
            return _vlestoque;
        }
        set
        {
            PropriedadeModificada(RO_VLESTOQUE, value);
            _vlestoque = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 16, Precisao = 3)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 2)]
    public decimal? Vlmaxcobfrete
    {
        get
        {
            PropriedadeAcessada(RO_VLMAXCOBFRETE);
            return _vlmaxcobfrete;
        }
        set
        {
            PropriedadeModificada(RO_VLMAXCOBFRETE, value);
            _vlmaxcobfrete = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 2)]
    public decimal? Vlmediacompramesfornec
    {
        get
        {
            PropriedadeAcessada(RO_VLMEDIACOMPRAMESFORNEC);
            return _vlmediacompramesfornec;
        }
        set
        {
            PropriedadeModificada(RO_VLMEDIACOMPRAMESFORNEC, value);
            _vlmediacompramesfornec = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlminimost
    {
        get
        {
            PropriedadeAcessada(RO_VLMINIMOST);
            return _vlminimost;
        }
        set
        {
            PropriedadeModificada(RO_VLMINIMOST, value);
            _vlminimost = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 2)]
    public decimal? Vloutrasrendas
    {
        get
        {
            PropriedadeAcessada(RO_VLOUTRASRENDAS);
            return _vloutrasrendas;
        }
        set
        {
            PropriedadeModificada(RO_VLOUTRASRENDAS, value);
            _vloutrasrendas = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 2)]
    public decimal? Vlpotenciallimcred
    {
        get
        {
            PropriedadeAcessada(RO_VLPOTENCIALLIMCRED);
            return _vlpotenciallimcred;
        }
        set
        {
            PropriedadeModificada(RO_VLPOTENCIALLIMCRED, value);
            _vlpotenciallimcred = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Zona
    {
        get
        {
            PropriedadeAcessada(RO_ZONA);
            return _zona;
        }
        set
        {
            PropriedadeModificada(RO_ZONA, value);
            _zona = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 25, Precisao = 0)]
    public string SenhaConvECF
    {
        get
        {
            PropriedadeAcessada(RO_SENHACONVECF);
            return _senhaconvecf;
        }
        set
        {
            PropriedadeModificada(RO_SENHACONVECF, value);
            _senhaconvecf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCLIENT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Cliatacado
    {
        get
        {
            PropriedadeAcessada(RO_CLIATACADO);
            return _cliatacado;
        }
        set
        {
            PropriedadeModificada(RO_CLIATACADO, value);
            _cliatacado = value;
        }
    }

    public void InicializarAtributos()
    {
    }

    public string ObterNomeTabela()
    {
        return "PCCLIENT";
    }

    public IEntidade NovaInstancia()
    {
        return (IEntidade)GetType().GetConstructors()[0].Invoke(null);
    }

    public void CarregarPorDataReader(IDataReader leitor)
    {
        _aceitachterceiros = AlterarTipo<string>(leitor["Aceitachterceiros"]);
        _aceitasimilar = AlterarTipo<string>(leitor["Aceitasimilar"]);
        _cliatacado = AlterarTipo<string>(leitor["Cliatacado"]);
        _aceitatrocanegativa = AlterarTipo<string>(leitor["Aceitatrocanegativa"]);
        _aceitavendafracao = AlterarTipo<string>(leitor["Aceitavendafracao"]);
        _agregarvalorstdescfin = AlterarTipo<string>(leitor["Agregarvalorstdescfin"]);
        _aliqicms1 = AlterarTipo<decimal?>(leitor["Aliqicms1"]);
        _analisecred = AlterarTipo<string>(leitor["Analisecred"]);
        _anvisa = AlterarTipo<string>(leitor["Anvisa"]);
        _aplicadescnf = AlterarTipo<string>(leitor["Aplicadescnf"]);
        _arealojam2 = AlterarTipo<decimal?>(leitor["Arealojam2"]);
        _atendedomingo = AlterarTipo<string>(leitor["Atendedomingo"]);
        _atendequarta = AlterarTipo<string>(leitor["Atendequarta"]);
        _atendequinta = AlterarTipo<string>(leitor["Atendequinta"]);
        _atendesabado = AlterarTipo<string>(leitor["Atendesabado"]);
        _atendesegunda = AlterarTipo<string>(leitor["Atendesegunda"]);
        _atendesexta = AlterarTipo<string>(leitor["Atendesexta"]);
        _atendeterca = AlterarTipo<string>(leitor["Atendeterca"]);
        _atualizasaldoccdescfin = AlterarTipo<string>(leitor["Atualizasaldoccdescfin"]);
        _bairrocob = AlterarTipo<string>(leitor["Bairrocob"]);
        _bairrocom = AlterarTipo<string>(leitor["Bairrocom"]);
        _bairroent = AlterarTipo<string>(leitor["Bairroent"]);
        _bloqueio = AlterarTipo<string>(leitor["Bloqueio"]);
        _bloqueiodatacheq = AlterarTipo<string>(leitor["Bloqueiodatacheq"]);
        _bloqueiodefinitivo = AlterarTipo<string>(leitor["Bloqueiodefinitivo"]);
        _bloqueiosefaz = AlterarTipo<string>(leitor["Bloqueiosefaz"]);
        _bloqueiosefazped = AlterarTipo<string>(leitor["Bloqueiosefazped"]);
        _bloqvendapf = AlterarTipo<string>(leitor["Bloqvendapf"]);
        _cacex = AlterarTipo<string>(leitor["Cacex"]);
        _caixapostal = AlterarTipo<decimal?>(leitor["Caixapostal"]);
        _calculast = AlterarTipo<string>(leitor["Calculast"]);
        _capitalsocial = AlterarTipo<decimal?>(leitor["Capitalsocial"]);
        _cargo = AlterarTipo<string>(leitor["Cargo"]);
        _cargoconjuge = AlterarTipo<string>(leitor["Cargoconjuge"]);
        _cepcob = AlterarTipo<string>(leitor["Cepcob"]);
        _cepcom = AlterarTipo<string>(leitor["Cepcom"]);
        _cepcxpostal = AlterarTipo<decimal?>(leitor["Cepcxpostal"]);
        _cepent = AlterarTipo<string>(leitor["Cepent"]);
        _cgcent = AlterarTipo<string>(leitor["Cgcent"]);
        _cgcentrega = AlterarTipo<string>(leitor["Cgcentrega"]);
        _cgeentaux = AlterarTipo<string>(leitor["Cgeentaux"]);
        _classecomercial = AlterarTipo<string>(leitor["Classecomercial"]);
        _classemc = AlterarTipo<string>(leitor["Classemc"]);
        _classevenda = AlterarTipo<string>(leitor["Classevenda"]);
        _cliente = AlterarTipo<string>(leitor["Cliente"]);
        _clientedan = AlterarTipo<string>(leitor["Clientedan"]);
        _clienteeletro = AlterarTipo<string>(leitor["Clienteeletro"]);
        _clientefontest = AlterarTipo<string>(leitor["Clientefontest"]);
        _clientemonitorado = AlterarTipo<string>(leitor["Clientemonitorado"]);
        _cliente2 = AlterarTipo<string>(leitor["Cliente2"]);
        _clientprotesto = AlterarTipo<string>(leitor["Clientprotesto"]);
        _cnpjcisp = AlterarTipo<string>(leitor["Cnpjcisp"]);
        _codatv1 = AlterarTipo<decimal?>(leitor["Codatv1"]);
        _codbairrocob = AlterarTipo<decimal?>(leitor["Codbairrocob"]);
        _codbairrocom = AlterarTipo<decimal?>(leitor["Codbairrocom"]);
        _codbairroent = AlterarTipo<decimal?>(leitor["Codbairroent"]);
        _codbarra = AlterarTipo<decimal?>(leitor["Codbarra"]);
        _codbarracob = AlterarTipo<decimal?>(leitor["Codbarracob"]);
        _codbarraent = AlterarTipo<decimal?>(leitor["Codbarraent"]);
        _codcanal = AlterarTipo<decimal?>(leitor["Codcanal"]);
        _codcidade = AlterarTipo<decimal?>(leitor["Codcidade"]);
        _codcli = AlterarTipo<decimal>(leitor["Codcli"]);
        _codcliint = AlterarTipo<decimal?>(leitor["Codcliint"]);
        _codclipalm = AlterarTipo<decimal?>(leitor["Codclipalm"]);
        _codcliprinc = AlterarTipo<decimal?>(leitor["Codcliprinc"]);
        _codcliweb = AlterarTipo<decimal?>(leitor["Codcliweb"]);
        _codcnae = AlterarTipo<string>(leitor["Codcnae"]);
        _codcob = AlterarTipo<string>(leitor["Codcob"]);
        _codcobtv1 = AlterarTipo<string>(leitor["Codcobtv1"]);
        _codcobtv3 = AlterarTipo<string>(leitor["Codcobtv3"]);
        _codcondicaovenda = AlterarTipo<decimal?>(leitor["Codcondicaovenda"]);
        _codcontab = AlterarTipo<string>(leitor["Codcontab"]);
        _codfilialestoque = AlterarTipo<string>(leitor["Codfilialestoque"]);
        _codfilialnf = AlterarTipo<string>(leitor["Codfilialnf"]);
        _codfornecfrete = AlterarTipo<decimal?>(leitor["Codfornecfrete"]);
        _codfunccad = AlterarTipo<decimal?>(leitor["Codfunccad"]);
        _codfunccadastro = AlterarTipo<decimal?>(leitor["Codfunccadastro"]);
        _codfunclancpotenciallimcred = AlterarTipo<decimal?>(leitor["Codfunclancpotenciallimcred"]);
        _codfuncultalter = AlterarTipo<decimal?>(leitor["Codfuncultalter"]);
        _codfuncultaltercliesp = AlterarTipo<decimal?>(leitor["Codfuncultaltercliesp"]);
        _codfuncultcontatocob = AlterarTipo<decimal?>(leitor["Codfuncultcontatocob"]);
        _codgln = AlterarTipo<decimal?>(leitor["Codgln"]);
        _codhist = AlterarTipo<decimal?>(leitor["Codhist"]);
        _codmunicipio = AlterarTipo<decimal?>(leitor["Codmunicipio"]);
        _codnilsen = AlterarTipo<string>(leitor["Codnilsen"]);
        _codpais = AlterarTipo<decimal?>(leitor["Codpais"]);
        _codplpag = AlterarTipo<decimal?>(leitor["Codplpag"]);
        _codplpagetico = AlterarTipo<decimal?>(leitor["Codplpagetico"]);
        _codplpaggenerico = AlterarTipo<decimal?>(leitor["Codplpaggenerico"]);
        _codplpagpadrao = AlterarTipo<decimal?>(leitor["Codplpagpadrao"]);
        _codplpag2 = AlterarTipo<decimal?>(leitor["Codplpag2"]);
        _codpraca = AlterarTipo<decimal>(leitor["Codpraca"]);
        _codpracacob = AlterarTipo<decimal?>(leitor["Codpracacob"]);
        _codprofissional = AlterarTipo<decimal?>(leitor["Codprofissional"]);
        _codrede = AlterarTipo<decimal?>(leitor["Codrede"]);
        _codstatuscob = AlterarTipo<decimal?>(leitor["Codstatuscob"]);
        _codsuframa = AlterarTipo<string>(leitor["Codsuframa"]);
        _codusur1 = AlterarTipo<decimal?>(leitor["Codusur1"]);
        _codusur2 = AlterarTipo<decimal?>(leitor["Codusur2"]);
        _codusur3 = AlterarTipo<decimal?>(leitor["Codusur3"]);
        _complementocob = AlterarTipo<string>(leitor["Complementocob"]);
        _complementocom = AlterarTipo<string>(leitor["Complementocom"]);
        _complementoent = AlterarTipo<string>(leitor["Complementoent"]);
        _condvenda1 = AlterarTipo<string>(leitor["Condvenda1"]);
        _condvenda10 = AlterarTipo<string>(leitor["Condvenda10"]);
        _condvenda11 = AlterarTipo<string>(leitor["Condvenda11"]);
        _condvenda12 = AlterarTipo<string>(leitor["Condvenda12"]);
        _condvenda13 = AlterarTipo<string>(leitor["Condvenda13"]);
        _condvenda14 = AlterarTipo<string>(leitor["Condvenda14"]);
        _condvenda2 = AlterarTipo<string>(leitor["Condvenda2"]);
        _condvenda20 = AlterarTipo<string>(leitor["Condvenda20"]);
        _condvenda3 = AlterarTipo<string>(leitor["Condvenda3"]);
        _condvenda4 = AlterarTipo<string>(leitor["Condvenda4"]);
        _condvenda5 = AlterarTipo<string>(leitor["Condvenda5"]);
        _condvenda6 = AlterarTipo<string>(leitor["Condvenda6"]);
        _condvenda7 = AlterarTipo<string>(leitor["Condvenda7"]);
        _condvenda8 = AlterarTipo<string>(leitor["Condvenda8"]);
        _condvenda9 = AlterarTipo<string>(leitor["Condvenda9"]);
        _condvenda98 = AlterarTipo<string>(leitor["Condvenda98"]);
        _condvenda99 = AlterarTipo<string>(leitor["Condvenda99"]);
        _consumidorfinal = AlterarTipo<string>(leitor["Consumidorfinal"]);
        _contagemestoque = AlterarTipo<string>(leitor["Contagemestoque"]);
        _contribuinte = AlterarTipo<string>(leitor["Contribuinte"]);
        _cpfconjuge = AlterarTipo<string>(leitor["Cpfconjuge"]);
        _crf = AlterarTipo<string>(leitor["Crf"]);
        _datacoleta = AlterarTipo<DateTime?>(leitor["Datacoleta"]);
        _dataconsultasintegra = AlterarTipo<DateTime?>(leitor["Dataconsultasintegra"]);
        _dddinternacional = AlterarTipo<decimal?>(leitor["Dddinternacional"]);
        _descproduto = AlterarTipo<string>(leitor["Descproduto"]);
        _destacafrete = AlterarTipo<string>(leitor["Destacafrete"]);
        _diasemana = AlterarTipo<string>(leitor["Diasemana"]);
        _digagencia1 = AlterarTipo<string>(leitor["Digagencia1"]);
        _digagencia2 = AlterarTipo<string>(leitor["Digagencia2"]);
        _diretoriocliente = AlterarTipo<string>(leitor["Diretoriocliente"]);
        _diretoriocontrato = AlterarTipo<string>(leitor["Diretoriocontrato"]);
        _dtabertcc1 = AlterarTipo<DateTime?>(leitor["Dtabertcc1"]);
        _dtabertcc2 = AlterarTipo<DateTime?>(leitor["Dtabertcc2"]);
        _dtadmissao = AlterarTipo<DateTime?>(leitor["Dtadmissao"]);
        _dtadmissaoconjuge = AlterarTipo<DateTime?>(leitor["Dtadmissaoconjuge"]);
        _dtbloq = AlterarTipo<DateTime?>(leitor["Dtbloq"]);
        _dtcadastro = AlterarTipo<DateTime>(leitor["Dtcadastro"]);
        _dtcapitalsocial = AlterarTipo<DateTime?>(leitor["Dtcapitalsocial"]);
        _dtclassificaestrela = AlterarTipo<DateTime?>(leitor["Dtclassificaestrela"]);
        _dtclassificagrupo = AlterarTipo<DateTime?>(leitor["Dtclassificagrupo"]);
        _dtdesbloqueio = AlterarTipo<DateTime?>(leitor["Dtdesbloqueio"]);
        _dtenquadramentomicroempresa = AlterarTipo<DateTime?>(leitor["Dtenquadramentomicroempresa"]);
        _dtexclusao = AlterarTipo<DateTime?>(leitor["Dtexclusao"]);
        _dtimportintegracao = AlterarTipo<DateTime?>(leitor["Dtimportintegracao"]);
        _dtinivistoria = AlterarTipo<DateTime?>(leitor["Dtinivistoria"]);
        _dtlancpotenciallimcred = AlterarTipo<DateTime?>(leitor["Dtlancpotenciallimcred"]);
        _dtnasc = AlterarTipo<DateTime?>(leitor["Dtnasc"]);
        _dtnascconj = AlterarTipo<DateTime?>(leitor["Dtnascconj"]);
        _dtprimcompra = AlterarTipo<DateTime?>(leitor["Dtprimcompra"]);
        _dtproxcontatocob = AlterarTipo<DateTime?>(leitor["Dtproxcontatocob"]);
        _dtproxvistoria = AlterarTipo<DateTime?>(leitor["Dtproxvistoria"]);
        _dtreglim = AlterarTipo<DateTime?>(leitor["Dtreglim"]);
        _dtultalter = AlterarTipo<DateTime?>(leitor["Dtultalter"]);
        _dtultaltercliesp = AlterarTipo<DateTime?>(leitor["Dtultaltercliesp"]);
        _dtultaltersrvprc = AlterarTipo<DateTime?>(leitor["Dtultaltersrvprc"]);
        _dtultcomp = AlterarTipo<DateTime?>(leitor["Dtultcomp"]);
        _dtultcompnestle = AlterarTipo<DateTime?>(leitor["Dtultcompnestle"]);
        _dtultconsultasci = AlterarTipo<DateTime?>(leitor["Dtultconsultasci"]);
        _dtultconsultaserasa = AlterarTipo<DateTime?>(leitor["Dtultconsultaserasa"]);
        _dtultconsultasintegra = AlterarTipo<DateTime?>(leitor["Dtultconsultasintegra"]);
        _dtultcontatocob = AlterarTipo<DateTime?>(leitor["Dtultcontatocob"]);
        _dtultvisita = AlterarTipo<DateTime?>(leitor["Dtultvisita"]);
        _dtvalidadeconv = AlterarTipo<DateTime?>(leitor["Dtvalidadeconv"]);
        _dtvalidadeibama = AlterarTipo<DateTime?>(leitor["Dtvalidadeibama"]);
        _dtvalidasefaz = AlterarTipo<DateTime?>(leitor["Dtvalidasefaz"]);
        _dtvencalvara = AlterarTipo<DateTime?>(leitor["Dtvencalvara"]);
        _dtvencalvaraanvisa = AlterarTipo<DateTime?>(leitor["Dtvencalvaraanvisa"]);
        _dtvencalvarafunc = AlterarTipo<DateTime?>(leitor["Dtvencalvarafunc"]);
        _dtvencalvarasus = AlterarTipo<DateTime?>(leitor["Dtvencalvarasus"]);
        _dtvenccrf = AlterarTipo<DateTime?>(leitor["Dtvenccrf"]);
        _dtvenclimcred = AlterarTipo<DateTime?>(leitor["Dtvenclimcred"]);
        _dtvencprazoadicional = AlterarTipo<DateTime?>(leitor["Dtvencprazoadicional"]);
        _dtvencsuframa = AlterarTipo<DateTime?>(leitor["Dtvencsuframa"]);
        _eancobranca = AlterarTipo<decimal?>(leitor["Eancobranca"]);
        _eanentrega = AlterarTipo<decimal?>(leitor["Eanentrega"]);
        _edocob = AlterarTipo<string>(leitor["Edocob"]);
        _edocom = AlterarTipo<string>(leitor["Edocom"]);
        _edoent = AlterarTipo<string>(leitor["Edoent"]);
        _email = AlterarTipo<string>(leitor["Email"]);
        _emailnfe = AlterarTipo<string>(leitor["Emailnfe"]);
        _emitedae = AlterarTipo<string>(leitor["Emitedae"]);
        _emitedup = AlterarTipo<string>(leitor["Emitedup"]);
        _emitentech = AlterarTipo<string>(leitor["Emitentech"]);
        _emitentech2 = AlterarTipo<string>(leitor["Emitentech2"]);
        _emitepvendanfsemdesc = AlterarTipo<string>(leitor["Emitepvendanfsemdesc"]);
        _empfixa = AlterarTipo<string>(leitor["Empfixa"]);
        _empresa = AlterarTipo<string>(leitor["Empresa"]);
        _empresaconjuge = AlterarTipo<string>(leitor["Empresaconjuge"]);
        _endercob = AlterarTipo<string>(leitor["Endercob"]);
        _endercom = AlterarTipo<string>(leitor["Endercom"]);
        _enderconjuge = AlterarTipo<string>(leitor["Enderconjuge"]);
        _enderempr = AlterarTipo<string>(leitor["Enderempr"]);
        _enderent = AlterarTipo<string>(leitor["Enderent"]);
        _enviadadosserasa = AlterarTipo<string>(leitor["Enviadadosserasa"]);
        _envionfeemailcom = AlterarTipo<string>(leitor["Envionfeemailcom"]);
        _enviopdfnfe = AlterarTipo<string>(leitor["Enviopdfnfe"]);
        _estcob = AlterarTipo<string>(leitor["Estcob"]);
        _estcom = AlterarTipo<string>(leitor["Estcom"]);
        _estconjuge = AlterarTipo<string>(leitor["Estconjuge"]);
        _estempr = AlterarTipo<string>(leitor["Estempr"]);
        _estent = AlterarTipo<string>(leitor["Estent"]);
        _exportardadosims = AlterarTipo<string>(leitor["Exportardadosims"]);
        _fantasia = AlterarTipo<string>(leitor["Fantasia"]);
        _faxcli = AlterarTipo<string>(leitor["Faxcli"]);
        _faxcom = AlterarTipo<string>(leitor["Faxcom"]);
        _filiacaomae = AlterarTipo<string>(leitor["Filiacaomae"]);
        _filiacaomaeconj = AlterarTipo<string>(leitor["Filiacaomaeconj"]);
        _filiacaopai = AlterarTipo<string>(leitor["Filiacaopai"]);
        _filiacaopaiconj = AlterarTipo<string>(leitor["Filiacaopaiconj"]);
        _foco = AlterarTipo<string>(leitor["Foco"]);
        _fotografiasucesso = AlterarTipo<string>(leitor["Fotografiasucesso"]);
        _freqdiavisita = AlterarTipo<decimal?>(leitor["Freqdiavisita"]);
        _freqvisita = AlterarTipo<decimal?>(leitor["Freqvisita"]);
        _fretedespacho = AlterarTipo<string>(leitor["Fretedespacho"]);
        _gerarcreditodevcli = AlterarTipo<string>(leitor["Gerarcreditodevcli"]);
        _geratitulost = AlterarTipo<string>(leitor["Geratitulost"]);
        _gerenciamento = AlterarTipo<string>(leitor["Gerenciamento"]);
        _gruporamoativi = AlterarTipo<string>(leitor["Gruporamoativi"]);
        _horacadastro = AlterarTipo<DateTime?>(leitor["Horacadastro"]);
        _horaproxcontato = AlterarTipo<decimal?>(leitor["Horaproxcontato"]);
        _horarioreceb = AlterarTipo<string>(leitor["Horarioreceb"]);
        _icmsantecip = AlterarTipo<string>(leitor["Icmsantecip"]);
        _ieent = AlterarTipo<string>(leitor["Ieent"]);
        _ieps = AlterarTipo<decimal?>(leitor["Ieps"]);
        _iest = AlterarTipo<string>(leitor["Iest"]);
        _iment = AlterarTipo<string>(leitor["Iment"]);
        _importadocrm = AlterarTipo<string>(leitor["Importadocrm"]);
        _incluinoarqsci = AlterarTipo<string>(leitor["Incluinoarqsci"]);
        _inicioativ = AlterarTipo<DateTime?>(leitor["Inicioativ"]);
        _inscestadual = AlterarTipo<string>(leitor["Inscestadual"]);
        _investimento = AlterarTipo<string>(leitor["Investimento"]);
        _isencaosuframa = AlterarTipo<string>(leitor["Isencaosuframa"]);
        _isentajuros = AlterarTipo<string>(leitor["Isentajuros"]);
        _isentodifaliquotas = AlterarTipo<string>(leitor["Isentodifaliquotas"]);
        _isentoicms = AlterarTipo<string>(leitor["Isentoicms"]);
        _isentoipi = AlterarTipo<string>(leitor["Isentoipi"]);
        _isentotxboleto = AlterarTipo<string>(leitor["Isentotxboleto"]);
        _iva = AlterarTipo<decimal?>(leitor["Iva"]);
        _ivafonte = AlterarTipo<decimal?>(leitor["Ivafonte"]);
        _latitude = AlterarTipo<string>(leitor["Latitude"]);
        _limcred = AlterarTipo<decimal?>(leitor["Limcred"]);
        _limcredcpf = AlterarTipo<decimal?>(leitor["Limcredcpf"]);
        _limiteautori = AlterarTipo<string>(leitor["Limiteautori"]);
        _listaplpag = AlterarTipo<string>(leitor["Listaplpag"]);
        _longitude = AlterarTipo<string>(leitor["Longitude"]);
        _medcodfunclibtribut = AlterarTipo<decimal?>(leitor["Medcodfunclibtribut"]);
        _meddtlibtribut = AlterarTipo<DateTime?>(leitor["Meddtlibtribut"]);
        _microempresa = AlterarTipo<string>(leitor["Microempresa"]);
        _minutoproxcontato = AlterarTipo<decimal?>(leitor["Minutoproxcontato"]);
        _motivoexclusao = AlterarTipo<string>(leitor["Motivoexclusao"]);
        _municcob = AlterarTipo<string>(leitor["Municcob"]);
        _municcob2 = AlterarTipo<string>(leitor["Municcob2"]);
        _municcom = AlterarTipo<string>(leitor["Municcom"]);
        _municcom2 = AlterarTipo<string>(leitor["Municcom2"]);
        _municconjuge = AlterarTipo<string>(leitor["Municconjuge"]);
        _municempr = AlterarTipo<string>(leitor["Municempr"]);
        _municent = AlterarTipo<string>(leitor["Municent"]);
        _municent2 = AlterarTipo<string>(leitor["Municent2"]);
        _nomeconjuge = AlterarTipo<string>(leitor["Nomeconjuge"]);
        _numagencia1 = AlterarTipo<decimal?>(leitor["Numagencia1"]);
        _numagencia2 = AlterarTipo<decimal?>(leitor["Numagencia2"]);
        _numalvara = AlterarTipo<string>(leitor["Numalvara"]);
        _numalvaraanvisa = AlterarTipo<string>(leitor["Numalvaraanvisa"]);
        _numalvarafunc = AlterarTipo<string>(leitor["Numalvarafunc"]);
        _numalvarasus = AlterarTipo<string>(leitor["Numalvarasus"]);
        _numbanco1 = AlterarTipo<decimal?>(leitor["Numbanco1"]);
        _numbanco2 = AlterarTipo<decimal?>(leitor["Numbanco2"]);
        _numcartaofidelidade = AlterarTipo<string>(leitor["Numcartaofidelidade"]);
        _numccorrente1 = AlterarTipo<string>(leitor["Numccorrente1"]);
        _numccorrente2 = AlterarTipo<string>(leitor["Numccorrente2"]);
        _numconcessao = AlterarTipo<string>(leitor["Numconcessao"]);
        _numcrf = AlterarTipo<string>(leitor["Numcrf"]);
        _numcrm = AlterarTipo<string>(leitor["Numcrm"]);
        _numerocob = AlterarTipo<string>(leitor["Numerocob"]);
        _numerocom = AlterarTipo<string>(leitor["Numerocom"]);
        _numeroent = AlterarTipo<string>(leitor["Numeroent"]);
        _numregiaocli = AlterarTipo<decimal?>(leitor["Numregiaocli"]);
        _numregistroimune = AlterarTipo<string>(leitor["Numregistroimune"]);
        _numseq = AlterarTipo<decimal?>(leitor["Numseq"]);
        _numseqatu = AlterarTipo<decimal?>(leitor["Numseqatu"]);
        _numseqrotarca = AlterarTipo<decimal?>(leitor["Numseqrotarca"]);
        _numtare = AlterarTipo<string>(leitor["Numtare"]);
        _numtransvendadesc = AlterarTipo<decimal?>(leitor["Numtransvendadesc"]);
        _obs = AlterarTipo<string>(leitor["Obs"]);
        _obs_adic = AlterarTipo<string>(leitor["Obs_Adic"]);
        _obscallcenter = AlterarTipo<string>(leitor["Obscallcenter"]);
        _obscredito = AlterarTipo<string>(leitor["Obscredito"]);
        _obsentrega1 = AlterarTipo<string>(leitor["Obsentrega1"]);
        _obsentrega2 = AlterarTipo<string>(leitor["Obsentrega2"]);
        _obsentrega3 = AlterarTipo<string>(leitor["Obsentrega3"]);
        _obsentrega4 = AlterarTipo<string>(leitor["Obsentrega4"]);
        _observacao = AlterarTipo<string>(leitor["Observacao"]);
        _obsgerencial1 = AlterarTipo<string>(leitor["Obsgerencial1"]);
        _obsgerencial2 = AlterarTipo<string>(leitor["Obsgerencial2"]);
        _obsgerencial3 = AlterarTipo<string>(leitor["Obsgerencial3"]);
        _obsrecepcao = AlterarTipo<string>(leitor["Obsrecepcao"]);
        _obssuframa = AlterarTipo<string>(leitor["Obssuframa"]);
        _obstesouraria = AlterarTipo<string>(leitor["Obstesouraria"]);
        _obs2 = AlterarTipo<string>(leitor["Obs2"]);
        _obs3 = AlterarTipo<string>(leitor["Obs3"]);
        _obs4 = AlterarTipo<string>(leitor["Obs4"]);
        _obs5 = AlterarTipo<string>(leitor["Obs5"]);
        _orgaopub = AlterarTipo<string>(leitor["Orgaopub"]);
        _orgaopubfederal = AlterarTipo<string>(leitor["Orgaopubfederal"]);
        _orgaorg = AlterarTipo<string>(leitor["Orgaorg"]);
        _orgaorgconj = AlterarTipo<string>(leitor["Orgaorgconj"]);
        _origempreco = AlterarTipo<string>(leitor["Origempreco"]);
        _paisent = AlterarTipo<string>(leitor["Paisent"]);
        _paraibasim = AlterarTipo<string>(leitor["Paraibasim"]);
        _participafuncep = AlterarTipo<string>(leitor["Participafuncep"]);
        _pdvinvestimento = AlterarTipo<string>(leitor["Pdvinvestimento"]);
        _peracrestransf = AlterarTipo<decimal?>(leitor["Peracrestransf"]);
        _perbasevend = AlterarTipo<decimal?>(leitor["Perbasevend"]);
        _percbasevendqt = AlterarTipo<decimal?>(leitor["Percbasevendqt"]);
        _percbonific = AlterarTipo<decimal?>(leitor["Percbonific"]);
        _percomcli = AlterarTipo<decimal?>(leitor["Percomcli"]);
        _percomfilialbroker = AlterarTipo<decimal?>(leitor["Percomfilialbroker"]);
        _perctolvalidadeprodwms = AlterarTipo<decimal?>(leitor["Perctolvalidadeprodwms"]);
        _perdesc = AlterarTipo<decimal?>(leitor["Perdesc"]);
        _perdescfin = AlterarTipo<decimal?>(leitor["Perdescfin"]);
        _perdescisentoicms = AlterarTipo<decimal?>(leitor["Perdescisentoicms"]);
        _perdesc2 = AlterarTipo<decimal?>(leitor["Perdesc2"]);
        _perdesc3 = AlterarTipo<decimal?>(leitor["Perdesc3"]);
        _perdesc4 = AlterarTipo<decimal?>(leitor["Perdesc4"]);
        _perdesc5 = AlterarTipo<decimal?>(leitor["Perdesc5"]);
        _perfretebroker = AlterarTipo<decimal?>(leitor["Perfretebroker"]);
        _periodvistoria = AlterarTipo<decimal?>(leitor["Periodvistoria"]);
        _perminvalidade = AlterarTipo<decimal?>(leitor["Perminvalidade"]);
        _permitealtercobrancacr = AlterarTipo<string>(leitor["Permitealtercobrancacr"]);
        _piscofinscumulativo = AlterarTipo<string>(leitor["Piscofinscumulativo"]);
        _plpagneg = AlterarTipo<string>(leitor["Plpagneg"]);
        _plpagneg2 = AlterarTipo<string>(leitor["Plpagneg2"]);
        _pontorefer = AlterarTipo<string>(leitor["Pontorefer"]);
        _prazoadicional = AlterarTipo<decimal?>(leitor["Prazoadicional"]);
        _prazoadicional2 = AlterarTipo<decimal?>(leitor["Prazoadicional2"]);
        _prazoadicional3 = AlterarTipo<decimal?>(leitor["Prazoadicional3"]);
        _prazoadicional4 = AlterarTipo<decimal?>(leitor["Prazoadicional4"]);
        _prazoadicional5 = AlterarTipo<decimal?>(leitor["Prazoadicional5"]);
        _prazoadicional6 = AlterarTipo<decimal?>(leitor["Prazoadicional6"]);
        _prazoadicional7 = AlterarTipo<decimal?>(leitor["Prazoadicional7"]);
        _prazomaxvalidade = AlterarTipo<decimal?>(leitor["Prazomaxvalidade"]);
        _prazomedioplpag = AlterarTipo<decimal?>(leitor["Prazomedioplpag"]);
        _prazovalidade = AlterarTipo<decimal?>(leitor["Prazovalidade"]);
        _prazovencst = AlterarTipo<decimal?>(leitor["Prazovencst"]);
        _prazovenda = AlterarTipo<decimal?>(leitor["Prazovenda"]);
        _precoutilizadonfe = AlterarTipo<string>(leitor["Precoutilizadonfe"]);
        _predioproprio = AlterarTipo<string>(leitor["Predioproprio"]);
        _qtcheckout = AlterarTipo<decimal?>(leitor["Qtcheckout"]);
        _qtddiasaplicdescfin = AlterarTipo<decimal?>(leitor["Qtddiasaplicdescfin"]);
        _qtestrela = AlterarTipo<decimal?>(leitor["Qtestrela"]);
        _ratingsci = AlterarTipo<string>(leitor["Ratingsci"]);
        _ratingsci1 = AlterarTipo<string>(leitor["Ratingsci1"]);
        _ratingsci2 = AlterarTipo<string>(leitor["Ratingsci2"]);
        _registroibama = AlterarTipo<string>(leitor["Registroibama"]);
        _regjuntacomercial = AlterarTipo<string>(leitor["Regjuntacomercial"]);
        _rendamensal = AlterarTipo<decimal?>(leitor["Rendamensal"]);
        _rendamensalconjuge = AlterarTipo<decimal?>(leitor["Rendamensalconjuge"]);
        _repasse = AlterarTipo<string>(leitor["Repasse"]);
        _ressarcimentost = AlterarTipo<string>(leitor["Ressarcimentost"]);
        _retencaoiss = AlterarTipo<string>(leitor["Retencaoiss"]);
        _rfc = AlterarTipo<string>(leitor["Rfc"]);
        _rg = AlterarTipo<string>(leitor["Rg"]);
        _rgconj = AlterarTipo<string>(leitor["Rgconj"]);
        _roteiromasterfoods = AlterarTipo<string>(leitor["Roteiromasterfoods"]);
        _sacadoeletronico = AlterarTipo<string>(leitor["Sacadoeletronico"]);
        _senha_web = AlterarTipo<string>(leitor["Senha_Web"]);
        _sexo = AlterarTipo<string>(leitor["Sexo"]);
        _sigladec = AlterarTipo<string>(leitor["Sigladec"]);
        _simplesnacional = AlterarTipo<string>(leitor["Simplesnacional"]);
        _site = AlterarTipo<string>(leitor["Site"]);
        _statusconsultasintegra = AlterarTipo<string>(leitor["Statusconsultasintegra"]);
        _sulframa = AlterarTipo<string>(leitor["Sulframa"]);
        _suprimido = AlterarTipo<string>(leitor["Suprimido"]);
        _sus = AlterarTipo<string>(leitor["Sus"]);
        _telcelent = AlterarTipo<string>(leitor["Telcelent"]);
        _telcob = AlterarTipo<string>(leitor["Telcob"]);
        _telcom = AlterarTipo<string>(leitor["Telcom"]);
        _telconjuge = AlterarTipo<string>(leitor["Telconjuge"]);
        _telempr = AlterarTipo<string>(leitor["Telempr"]);
        _telent = AlterarTipo<string>(leitor["Telent"]);
        _telent1 = AlterarTipo<string>(leitor["Telent1"]);
        _tipoativcli = AlterarTipo<string>(leitor["Tipoativcli"]);
        _tipoclimed = AlterarTipo<string>(leitor["Tipoclimed"]);
        _tipoconversaotv4 = AlterarTipo<string>(leitor["Tipoconversaotv4"]);
        _tipocustotransf = AlterarTipo<string>(leitor["Tipocustotransf"]);
        _tipocustotransf_filiais = AlterarTipo<string>(leitor["Tipocustotransf_Filiais"]);
        _tipocustotransf_filialvirtual = AlterarTipo<string>(leitor["Tipocustotransf_Filialvirtual"]);
        _tipodescisencao = AlterarTipo<string>(leitor["Tipodescisencao"]);
        _tipodocumento = AlterarTipo<string>(leitor["Tipodocumento"]);
        _tipoempresa = AlterarTipo<string>(leitor["Tipoempresa"]);
        _tipofj = AlterarTipo<string>(leitor["Tipofj"]);
        _tipotratamentodescfin = AlterarTipo<string>(leitor["Tipotratamentodescfin"]);
        _tipoultalter = AlterarTipo<string>(leitor["Tipoultalter"]);
        _ufrg = AlterarTipo<string>(leitor["Ufrg"]);
        _ultcodplpag = AlterarTipo<decimal?>(leitor["Ultcodplpag"]);
        _usabkcnpjcodcliprinc = AlterarTipo<string>(leitor["Usabkcnpjcodcliprinc"]);
        _usacreclifat = AlterarTipo<string>(leitor["Usacreclifat"]);
        _usacross = AlterarTipo<string>(leitor["Usacross"]);
        _usadescfinseparadodesccom = AlterarTipo<string>(leitor["Usadescfinseparadodesccom"]);
        _usadescontoicms = AlterarTipo<string>(leitor["Usadescontoicms"]);
        _usaivafontediferenciado = AlterarTipo<string>(leitor["Usaivafontediferenciado"]);
        _usavlminvendabk = AlterarTipo<string>(leitor["Usavlminvendabk"]);
        _utilizaiesimplificada = AlterarTipo<string>(leitor["Utilizaiesimplificada"]);
        _utilizapedclinfe = AlterarTipo<string>(leitor["Utilizapedclinfe"]);
        _utilizaplpagmedicamento = AlterarTipo<string>(leitor["Utilizaplpagmedicamento"]);
        _utilizaprazomedioplpag = AlterarTipo<string>(leitor["Utilizaprazomedioplpag"]);
        _validamaxvendapf = AlterarTipo<string>(leitor["Validamaxvendapf"]);
        _validarcampanhabrinde = AlterarTipo<string>(leitor["Validarcampanhabrinde"]);
        _validarmultiplovenda = AlterarTipo<string>(leitor["Validarmultiplovenda"]);
        _valoraluguel = AlterarTipo<decimal?>(leitor["Valoraluguel"]);
        _vip = AlterarTipo<string>(leitor["Vip"]);
        _vlestoque = AlterarTipo<decimal?>(leitor["Vlestoque"]);
        _vlfrete = AlterarTipo<decimal?>(leitor["Vlfrete"]);
        _vlmaxcobfrete = AlterarTipo<decimal?>(leitor["Vlmaxcobfrete"]);
        _vlmediacompramesfornec = AlterarTipo<decimal?>(leitor["Vlmediacompramesfornec"]);
        _vlminimost = AlterarTipo<decimal?>(leitor["Vlminimost"]);
        _vloutrasrendas = AlterarTipo<decimal?>(leitor["Vloutrasrendas"]);
        _vlpotenciallimcred = AlterarTipo<decimal?>(leitor["Vlpotenciallimcred"]);
        _zona = AlterarTipo<decimal?>(leitor["Zona"]);
        _senhaconvecf = AlterarTipo<string>(leitor["SenhaConvECF"]);
    }

}