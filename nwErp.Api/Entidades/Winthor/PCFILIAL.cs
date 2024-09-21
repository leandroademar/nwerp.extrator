

////// namespace nwErp.Entidades.Winthor;

// namespace nwErp.Api.Modelos;

[Serializable]
public class PCFILIAL : GerenteDePropriedades, IEntidade
{
    private static readonly string RO_ACEITAVENDAAVISTACLIBLOQ = "Aceitavendaavistaclibloq";

    private string _aceitavendaavistaclibloq;

    private static readonly string RO_ACEITAVENDASEMEST = "Aceitavendasemest";

    private string _aceitavendasemest;

    private static readonly string RO_ALIQICMINTEROUTRASDESP = "Aliqicminteroutrasdesp";

    private decimal? _aliqicminteroutrasdesp;

    private static readonly string RO_ALIQICMOUTRASDESP = "Aliqicmoutrasdesp";

    private decimal? _aliqicmoutrasdesp;

    private static readonly string RO_ALIQUOTAFRETEEST = "Aliquotafreteest";

    private decimal? _aliquotafreteest;

    private static readonly string RO_ALTERAPEDIDORETORNADOWMS = "Alterapedidoretornadowms";

    private string _alterapedidoretornadowms;

    private static readonly string RO_ALTERARCOBBKCHAUTOMATICO = "Alterarcobbkchautomatico";

    private string _alterarcobbkchautomatico;

    private static readonly string RO_AMBIENTE = "Ambiente";

    private string _ambiente;

    private static readonly string RO_APLICAPERCATACNAOCONTRIB = "Aplicapercatacnaocontrib";

    private string _aplicapercatacnaocontrib;

    private static readonly string RO_APLICAPERCVARNAOCONTRIB = "Aplicapercvarnaocontrib";

    private string _aplicapercvarnaocontrib;

    private static readonly string RO_APROVEITADESP_PISCOFINS = "Aproveitadesp_Piscofins";

    private string _aproveitadesp_piscofins;

    private static readonly string RO_APROVEITAFRETE_PISCOFINS = "Aproveitafrete_Piscofins";

    private string _aproveitafrete_piscofins;

    private static readonly string RO_APROVEITAIPI_PISCOFINS = "Aproveitaipi_Piscofins";

    private string _aproveitaipi_piscofins;

    private static readonly string RO_AREAVENDA = "Areavenda";

    private decimal? _areavenda;

    private static readonly string RO_ARREDONDAQTGIRODIA = "Arredondaqtgirodia";

    private string _arredondaqtgirodia;

    private static readonly string RO_ARREDVLITENSNFSAIDA = "Arredvlitensnfsaida";

    private string _arredvlitensnfsaida;

    private static readonly string RO_ATACADISTA = "Atacadista";

    private string _atacadista;

    private static readonly string RO_ATIVIDADE = "Atividade";

    private string _atividade;

    private static readonly string RO_ATUALIZACUSTOULTENTRANSF = "Atualizacustoultentransf";

    private string _atualizacustoultentransf;

    private static readonly string RO_AUTOSERVICO = "Autoservico";

    private string _autoservico;

    private static readonly string RO_BAIRRO = "Bairro";

    private string _bairro;

    private static readonly string RO_BLOQDESDEMITENTEDIF = "Bloqdesdemitentedif";

    private string _bloqdesdemitentedif;

    private static readonly string RO_BLOQDEVCLI = "Bloqdevcli";

    private string _bloqdevcli;

    private static readonly string RO_BLOQESTOQUETRANSF = "Bloqestoquetransf";

    private string _bloqestoquetransf;

    private static readonly string RO_BLOQUEARPEDIDOSABAIXOVLMINIMO = "Bloquearpedidosabaixovlminimo";

    private string _bloquearpedidosabaixovlminimo;

    private static readonly string RO_BLOQUEIARISKSCORING = "Bloqueiariskscoring";

    private string _bloqueiariskscoring;

    private static readonly string RO_BLOQVENDAPF = "Bloqvendapf";

    private string _bloqvendapf;

    private static readonly string RO_BROKER = "Broker";

    private string _broker;

    private static readonly string RO_CAE = "Cae";

    private string _cae;

    private static readonly string RO_CALCCREDICMCUSTOCONT = "Calccredicmcustocont";

    private string _calccredicmcustocont;

    private static readonly string RO_CALCCREDICMS = "Calccredicms";

    private string _calccredicms;

    private static readonly string RO_CALCCREDIPI = "Calccredipi";

    private string _calccredipi;

    private static readonly string RO_CALCCREDPISCOFINS = "Calccredpiscofins";

    private string _calccredpiscofins;

    private static readonly string RO_CALCCREDPISCUSTOCONT = "Calccredpiscustocont";

    private string _calccredpiscustocont;

    private static readonly string RO_CALCESTDISPCOMQTMINAUTOSERV = "Calcestdispcomqtminautoserv";

    private string _calcestdispcomqtminautoserv;

    private static readonly string RO_CALCREDPISFRETE = "Calcredpisfrete";

    private string _calcredpisfrete;

    private static readonly string RO_CALCREDPISFRETECONT = "Calcredpisfretecont";

    private string _calcredpisfretecont;

    private static readonly string RO_CALCULARCOMISSAOPVENDA1 = "Calcularcomissaopvenda1";

    private string _calcularcomissaopvenda1;

    private static readonly string RO_CALCULARIPIVENDA = "Calcularipivenda";

    private string _calcularipivenda;

    private static readonly string RO_CANCELANFDEVCLICOMWMS = "Cancelanfdevclicomwms";

    private string _cancelanfdevclicomwms;

    private static readonly string RO_CANCELANFENTRADACOMWMS = "Cancelanfentradacomwms";

    private string _cancelanfentradacomwms;

    private static readonly string RO_CANCELANFVENDACOMWMS = "Cancelanfvendacomwms";

    private string _cancelanfvendacomwms;

    private static readonly string RO_CANCELAPEDIDORETORNADOWMS = "Cancelapedidoretornadowms";

    private string _cancelapedidoretornadowms;

    private static readonly string RO_CEP = "Cep";

    private string _cep;

    private static readonly string RO_CGC = "Cgc";

    private string _cgc;

    private static readonly string RO_CGC_OPERADORLOGISTICO = "Cgc_Operadorlogistico";

    private string _cgc_operadorlogistico;

    private static readonly string RO_CGCTRANSP = "Cgctransp";

    private string _cgctransp;

    private static readonly string RO_CIDADE = "Cidade";

    private string _cidade;

    private static readonly string RO_CIDADETRANSP = "Cidadetransp";

    private string _cidadetransp;

    private static readonly string RO_CLICREPENDENTE = "Clicrependente";

    private string _clicrependente;

    private static readonly string RO_CNPJ_PAF = "Cnpj_Paf";

    private string _cnpj_paf;

    private static readonly string RO_CODCLI = "Codcli";

    private decimal? _codcli;

    private static readonly string RO_CODCLICONSUMIDOR = "Codcliconsumidor";

    private decimal? _codcliconsumidor;

    private static readonly string RO_CODCONTACREDFORNEC = "Codcontacredfornec";

    private decimal? _codcontacredfornec;

    private static readonly string RO_CODCONTADOR = "Codcontador";

    private decimal? _codcontador;

    private static readonly string RO_CODCONTAENTIMPORTACAO = "Codcontaentimportacao";

    private decimal? _codcontaentimportacao;

    private static readonly string RO_CODCONTAPERCACRESCENT = "Codcontapercacrescent";

    private decimal? _codcontapercacrescent;

    private static readonly string RO_CODCONTARECARGA = "Codcontarecarga";

    private decimal? _codcontarecarga;

    private static readonly string RO_CODCONTAVENDAENTREGAFUT = "Codcontavendaentregafut";

    private decimal? _codcontavendaentregafut;

    private static readonly string RO_CODDOCDEVFORNEC = "Coddocdevfornec";

    private decimal? _coddocdevfornec;

    private static readonly string RO_CODDOCDEVOL = "Coddocdevol";

    private decimal? _coddocdevol;

    private static readonly string RO_CODDOCENTRADAMERC = "Coddocentradamerc";

    private decimal? _coddocentradamerc;

    private static readonly string RO_CODDOCNF = "Coddocnf";

    private decimal? _coddocnf;

    private static readonly string RO_CODDOCNFC = "Coddocnfc";

    private decimal? _coddocnfc;

    private static readonly string RO_CODDOCNOTACOBRANCA = "Coddocnotacobranca";

    private decimal? _coddocnotacobranca;

    private static readonly string RO_CODDOCORIGEMNF = "Coddocorigemnf";

    private decimal? _coddocorigemnf;

    private static readonly string RO_CODDOCSE = "Coddocse";

    private decimal? _coddocse;

    private static readonly string RO_CODDOCSR = "Coddocsr";

    private decimal? _coddocsr;

    private static readonly string RO_CODDOCSRAUTO = "Coddocsrauto";

    private decimal? _coddocsrauto;

    private static readonly string RO_CODDOCSS = "Coddocss";

    private decimal? _coddocss;

    private static readonly string RO_CODDOCTRANSF = "Coddoctransf";

    private decimal? _coddoctransf;

    private static readonly string RO_CODESTADO = "Codestado";

    private decimal? _codestado;

    private static readonly string RO_CODFILIALPREFESTBALCAO = "Codfilialprefestbalcao";

    private string _codfilialprefestbalcao;

    private static readonly string RO_CODFILIALPREFESTTLMK = "Codfilialprefesttlmk";

    private string _codfilialprefesttlmk;

    private static readonly string RO_CODFILIALPRODUCAO = "Codfilialproducao";

    private string _codfilialproducao;

    private static readonly string RO_CODFISCALDEVOUTRASDESP = "Codfiscaldevoutrasdesp";

    private decimal? _codfiscaldevoutrasdesp;

    private static readonly string RO_CODFISCALINTERDEVOUTRASDESP = "Codfiscalinterdevoutrasdesp";

    private decimal? _codfiscalinterdevoutrasdesp;

    private static readonly string RO_CODFISCALINTEROUTRASDESP = "Codfiscalinteroutrasdesp";

    private decimal? _codfiscalinteroutrasdesp;

    private static readonly string RO_CODFISCALOPCIONALNFIMPORTACAO = "Codfiscalopcionalnfimportacao";

    private string _codfiscalopcionalnfimportacao;

    private static readonly string RO_CODFISCALOUTRASDESP = "Codfiscaloutrasdesp";

    private decimal? _codfiscaloutrasdesp;

    private static readonly string RO_CODFORNEC = "Codfornec";

    private decimal? _codfornec;

    private static readonly string RO_CODGLN = "Codgln";

    private decimal? _codgln;

    private static readonly string RO_CODGRUPO = "Codgrupo";

    private string _codgrupo;

    private static readonly string RO_CODGRUPOFILIAL = "Codgrupofilial";

    private decimal? _codgrupofilial;

    private static readonly string RO_CODGRUPOLOJA = "Codgrupoloja";

    private decimal? _codgrupoloja;

    private static readonly string RO_CODIGO = "Codigo";

    private string _codigo;

    private static readonly string RO_CODMD5_PAF = "Codmd5_Paf";

    private string _codmd5_paf;

    private static readonly string RO_CODMUN = "Codmun";

    private decimal? _codmun;

    private static readonly string RO_CODPAIS = "Codpais";

    private decimal? _codpais;

    private static readonly string RO_CODREGISTRO = "Codregistro";

    private string _codregistro;

    private static readonly string RO_CODSOCIO = "Codsocio";

    private decimal? _codsocio;

    private static readonly string RO_CONCEDERDESCISENCAOSTPF = "Concederdescisencaostpf";

    private string _concederdescisencaostpf;

    private static readonly string RO_CONFERIRSOMENTEPEDACERTADOCX = "Conferirsomentepedacertadocx";

    private string _conferirsomentepedacertadocx;

    private static readonly string RO_CONSIDERAESTPENDSUGCOMPRA = "Consideraestpendsugcompra";

    private string _consideraestpendsugcompra;

    private static readonly string RO_CONSIDERAMONTAGEMGIROMERC = "Consideramontagemgiromerc";

    private string _consideramontagemgiromerc;

    private static readonly string RO_CONSIDERARCOMISSAOZERO = "Considerarcomissaozero";

    private string _considerarcomissaozero;

    private static readonly string RO_CONSIDERARICMSANTECIPCUSTO = "Consideraricmsantecipcusto";

    private string _consideraricmsantecipcusto;

    private static readonly string RO_CONSOLIDADADOS504 = "Consolidadados504";

    private string _consolidadados504;

    private static readonly string RO_CONTATO = "Contato";

    private string _contato;

    private static readonly string RO_CONTROLAGARANTIASERVICO = "Controlagarantiaservico";

    private string _controlagarantiaservico;

    private static readonly string RO_CONTROLENFEPORSERIE = "Controlenfeporserie";

    private string _controlenfeporserie;

    private static readonly string RO_CORTEAUTOMATICOPEDVENDAWMS = "Corteautomaticopedvendawms";

    private string _corteautomaticopedvendawms;

    private static readonly string RO_DATAHORA_PRIMEIRODOCUMENTO_ECF = "Datahora_Primeirodocumento_Ecf";

    private string _datahora_primeirodocumento_ecf;

    private static readonly string RO_DEPFECHADO = "Depfechado";

    private string _depfechado;

    private static readonly string RO_DESTACARIMPOSTOSVENDATV13 = "Destacarimpostosvendatv13";

    private string _destacarimpostosvendatv13;

    private static readonly string RO_DESTACARIMPOSTOSVENDATV14 = "Destacarimpostosvendatv14";

    private string _destacarimpostosvendatv14;

    private static readonly string RO_DEVFORNECESTOQUEAVARIA = "Devfornecestoqueavaria";

    private string _devfornecestoqueavaria;

    private static readonly string RO_DIASCURVATURA = "Diascurvatura";

    private decimal? _diascurvatura;

    private static readonly string RO_DIASPRAZOTRANSF = "Diasprazotransf";

    private decimal? _diasprazotransf;

    private static readonly string RO_DIAVENCICMSANTECIP = "Diavencicmsantecip";

    private decimal? _diavencicmsantecip;

    private static readonly string RO_DIREXPXMLSNGPC = "Direxpxmlsngpc";

    private string _direxpxmlsngpc;

    private static readonly string RO_DOMINIOSERV = "Dominioserv";

    private string _dominioserv;

    private static readonly string RO_DTALTMATRICSNGPC = "Dtaltmatricsngpc";

    private DateTime? _dtaltmatricsngpc;

    private static readonly string RO_DTEXCLUSAO = "Dtexclusao";

    private DateTime? _dtexclusao;

    private static readonly string RO_DTFIMATIVIDADE = "Dtfimatividade";

    private DateTime? _dtfimatividade;

    private static readonly string RO_DTINIATIVIDADE = "Dtiniatividade";

    private DateTime? _dtiniatividade;

    private static readonly string RO_DTREGISTRO = "Dtregistro";

    private DateTime? _dtregistro;

    private static readonly string RO_DTULTATUALIZACAODRVINTER = "Dtultatualizacaodrvinter";

    private DateTime? _dtultatualizacaodrvinter;

    private static readonly string RO_DTUTILIZACTE = "Dtutilizacte";

    private DateTime? _dtutilizacte;

    private static readonly string RO_DTUTILIZANFE = "Dtutilizanfe";

    private DateTime? _dtutilizanfe;

    private static readonly string RO_EANEMISSOR = "Eanemissor";

    private decimal? _eanemissor;

    private static readonly string RO_EMAIL = "Email";

    private string _email;

    private static readonly string RO_EMAILCOPIARESPOSTA = "Emailcopiaresposta";

    private string _emailcopiaresposta;

    private static readonly string RO_EMAILREMETENTE = "Emailremetente";

    private string _emailremetente;

    private static readonly string RO_EMAILRESPOSTA = "Emailresposta";

    private string _emailresposta;

    private static readonly string RO_ENDERECO = "Endereco";

    private string _endereco;

    private static readonly string RO_ENDERECOPROXY = "Enderecoproxy";

    private string _enderecoproxy;

    private static readonly string RO_ENDTRANSP = "Endtransp";

    private string _endtransp;

    private static readonly string RO_ENVIACONTASPAGARNFE = "Enviacontaspagarnfe";

    private string _enviacontaspagarnfe;

    private static readonly string RO_ENVIACONTASRECEBERNFE = "Enviacontasrecebernfe";

    private string _enviacontasrecebernfe;

    private static readonly string RO_ESTORNACUSTODEVFORNEC = "Estornacustodevfornec";

    private string _estornacustodevfornec;

    private static readonly string RO_EXIBIRIMPOSTOSFORANFIMPORTACAO = "Exibirimpostosforanfimportacao";

    private string _exibirimpostosforanfimportacao;

    private static readonly string RO_EXIGIREMISSAOMAPABALCAO = "Exigiremissaomapabalcao";

    private string _exigiremissaomapabalcao;

    private static readonly string RO_FANTASIA = "Fantasia";

    private string _fantasia;

    private static readonly string RO_FAX = "Fax";

    private string _fax;

    private static readonly string RO_GERABASENORMALQUANDOST = "Gerabasenormalquandost";

    private string _gerabasenormalquandost;

    private static readonly string RO_GERAPEDIDOCOMITENSSEMEST = "Gerapedidocomitenssemest";

    private string _gerapedidocomitenssemest;

    private static readonly string RO_GERARNSU = "Gerarnsu";

    private string _gerarnsu;

    private static readonly string RO_GERARNUMLOTEAUTOMATICPA = "Gerarnumloteautomaticpa";

    private string _gerarnumloteautomaticpa;

    private static readonly string RO_GERARPCHISTEST = "Gerarpchistest";

    private string _gerarpchistest;

    private static readonly string RO_GERARPEDCONSIGNACAOVASILHAME = "Gerarpedconsignacaovasilhame";

    private string _gerarpedconsignacaovasilhame;

    private static readonly string RO_GRAVARVALORDESCFIN = "Gravarvalordescfin";

    private string _gravarvalordescfin;

    private static readonly string RO_HORAFINALDIGITACAOPED = "Horafinaldigitacaoped";

    private DateTime? _horafinaldigitacaoped;

    private static readonly string RO_HORAFINALIMPORTACAOPED = "Horafinalimportacaoped";

    private DateTime? _horafinalimportacaoped;

    private static readonly string RO_HORAINICIALDIGITACAOPED = "Horainicialdigitacaoped";

    private DateTime? _horainicialdigitacaoped;

    private static readonly string RO_HORAINICIALIMPORTACAOPED = "Horainicialimportacaoped";

    private DateTime? _horainicialimportacaoped;

    private static readonly string RO_HRFIMALMOCO = "Hrfimalmoco";

    private DateTime? _hrfimalmoco;

    private static readonly string RO_HRFIMEXPEDIENTE = "Hrfimexpediente";

    private DateTime? _hrfimexpediente;

    private static readonly string RO_HRINICIOALMOCO = "Hrinicioalmoco";

    private DateTime? _hrinicioalmoco;

    private static readonly string RO_HRINICIOEXPEDIENTE = "Hrinicioexpediente";

    private DateTime? _hrinicioexpediente;

    private static readonly string RO_IE = "Ie";

    private string _ie;

    private static readonly string RO_IESUBSTTRIB = "Iesubsttrib";

    private string _iesubsttrib;

    private static readonly string RO_IETRANSP = "Ietransp";

    private string _ietransp;

    private static readonly string RO_IM = "Im";

    private string _im;

    private static readonly string RO_IMPEDETIPO14_LIVROFISCAL = "Impedetipo14_Livrofiscal";

    private string _impedetipo14_livrofiscal;

    private static readonly string RO_INCLUIFRETEOUTRASDESPBASEST = "Incluifreteoutrasdespbasest";

    private string _incluifreteoutrasdespbasest;

    private static readonly string RO_INCLUIRITEMPCEMBALAGEM = "Incluiritempcembalagem";

    private string _incluiritempcembalagem;

    private static readonly string RO_INDICECUSTOTRANSF = "Indicecustotransf";

    private decimal? _indicecustotransf;

    private static readonly string RO_INDUSTRIA = "Industria";

    private string _industria;

    private static readonly string RO_INFORMARPROFISSIONALVENDA = "Informarprofissionalvenda";

    private string _informarprofissionalvenda;

    private static readonly string RO_INTEGRADORAWMS = "Integradorawms";

    private decimal? _integradorawms;

    private static readonly string RO_IPISOMENTEVLCONT = "Ipisomentevlcont";

    private string _ipisomentevlcont;

    private static readonly string RO_LANCARFRETEPESOAUTFAT = "Lancarfretepesoautfat";

    private string _lancarfretepesoautfat;

    private static readonly string RO_LIBPEDCOMPRASEMDIVERG = "Libpedcomprasemdiverg";

    private string _libpedcomprasemdiverg;

    private static readonly string RO_LIMPARBASECALCENTRADA = "Limparbasecalcentrada";

    private string _limparbasecalcentrada;

    private static readonly string RO_LIMRISKSCORING = "Limriskscoring";

    private decimal? _limriskscoring;

    private static readonly string RO_MATRICULASNGPC = "Matriculasngpc";

    private decimal? _matriculasngpc;

    private static readonly string RO_MATRICULASNGPCANT = "Matriculasngpcant";

    private decimal? _matriculasngpcant;

    private static readonly string RO_MENSNF = "Mensnf";

    private string _mensnf;

    private static readonly string RO_MENSNFIMUNIDADETRIB = "Mensnfimunidadetrib";

    private string _mensnfimunidadetrib;

    private static readonly string RO_MIXMAXIMO = "Mixmaximo";

    private decimal? _mixmaximo;

    private static readonly string RO_MIXMINIMO = "Mixminimo";

    private decimal? _mixminimo;

    private static readonly string RO_MONTACARGAWINTHOR = "Montacargawinthor";

    private string _montacargawinthor;

    private static readonly string RO_MONTANDO = "Montando";

    private string _montando;

    private static readonly string RO_MONTARKITAUTOMATICAMENTE = "Montarkitautomaticamente";

    private string _montarkitautomaticamente;

    private static readonly string RO_NAOGERARCREDITOENTRADATRANSF = "Naogerarcreditoentradatransf";

    private string _naogerarcreditoentradatransf;

    private static readonly string RO_NOMEBANCODADOSWMS = "Nomebancodadoswms";

    private string _nomebancodadoswms;

    private static readonly string RO_NOME_PAF = "Nome_Paf";

    private string _nome_paf;

    private static readonly string RO_NOMEPAIS = "Nomepais";

    private string _nomepais;

    private static readonly string RO_NOMEREMETENTE = "Nomeremetente";

    private string _nomeremetente;

    private static readonly string RO_NUMCONTRATOCORREIO = "Numcontratocorreio";

    private decimal? _numcontratocorreio;

    private static readonly string RO_NUMDIASMAXIMOLIBERARPEDIDO = "Numdiasmaximoliberarpedido";

    private decimal? _numdiasmaximoliberarpedido;

    private static readonly string RO_NUMDIASVENCFRETE = "Numdiasvencfrete";

    private decimal? _numdiasvencfrete;

    private static readonly string RO_NUMERO = "Numero";

    private decimal? _numero;

    private static readonly string RO_NUMERO2 = "Numero2";

    private string _numero2;

    private static readonly string RO_NUMIDF = "Numidf";

    private string _numidf;

    private static readonly string RO_NUMIDFDEVCLI = "Numidfdevcli";

    private string _numidfdevcli;

    private static readonly string RO_NUMMAXDIASRETRODTCOMPENSACAO = "Nummaxdiasretrodtcompensacao";

    private decimal? _nummaxdiasretrodtcompensacao;

    private static readonly string RO_NUMMAXITENSNFE = "Nummaxitensnfe";

    private decimal? _nummaxitensnfe;

    private static readonly string RO_NUMPROXVEND = "Numproxvend";

    private decimal? _numproxvend;

    private static readonly string RO_NUMREGIAO = "Numregiao";

    private decimal? _numregiao;

    private static readonly string RO_NUMREGIAOBALCAOINTER = "Numregiaobalcaointer";

    private decimal? _numregiaobalcaointer;

    private static readonly string RO_NUMREGIAOPADRAO = "Numregiaopadrao";

    private decimal? _numregiaopadrao;

    private static readonly string RO_NUMSEQENTR = "Numseqentr";

    private decimal? _numseqentr;

    private static readonly string RO_OBRIGACONSFINALDEV = "Obrigaconsfinaldev";

    private string _obrigaconsfinaldev;

    private static readonly string RO_OPERADORLOGISTICO = "Operadorlogistico";

    private string _operadorlogistico;

    private static readonly string RO_OPISENTOSICMSALTOCUSTO = "Opisentosicmsaltocusto";

    private string _opisentosicmsaltocusto;

    private static readonly string RO_OPTANTESIMPLESNAC = "Optantesimplesnac";

    private string _optantesimplesnac;

    private static readonly string RO_ORDEMAGRUPDESD = "Ordemagrupdesd";

    private string _ordemagrupdesd;

    private static readonly string RO_ORGAO = "Orgao";

    private string _orgao;

    private static readonly string RO_ORIGEMCUSTOFILIALRETIRA = "Origemcustofilialretira";

    private string _origemcustofilialretira;

    private static readonly string RO_ORIGEMVENDANF = "Origemvendanf";

    private string _origemvendanf;

    private static readonly string RO_OSPRODMANUTOBRIG = "Osprodmanutobrig";

    private string _osprodmanutobrig;

    private static readonly string RO_PERBASEREDOUTRASDESP = "Perbaseredoutrasdesp";

    private decimal? _perbaseredoutrasdesp;

    private static readonly string RO_PERBASEREDOUTRASDESPPF = "Perbaseredoutrasdesppf";

    private decimal? _perbaseredoutrasdesppf;

    private static readonly string RO_PERCACRESCIMOBALCAO = "Percacrescimobalcao";

    private decimal? _percacrescimobalcao;

    private static readonly string RO_PERCALTERCUSTOENT = "Percaltercustoent";

    private decimal? _percaltercustoent;

    private static readonly string RO_PERCDECLINIOABC = "Percdeclinioabc";

    private decimal? _percdeclinioabc;

    private static readonly string RO_PERCDESPADM = "Percdespadm";

    private decimal? _percdespadm;

    private static readonly string RO_PERCEVOLUCAOABC = "Percevolucaoabc";

    private decimal? _percevolucaoabc;

    private static readonly string RO_PERCICMSSIMPLESNAC = "Percicmssimplesnac";

    private decimal? _percicmssimplesnac;

    private static readonly string RO_PERCMAXDIFPRODSIMIL = "Percmaxdifprodsimil";

    private decimal? _percmaxdifprodsimil;

    private static readonly string RO_PERCOMFILIALBROKER = "Percomfilialbroker";

    private decimal? _percomfilialbroker;

    private static readonly string RO_PERCOMMOTBROKER = "Percommotbroker";

    private decimal? _percommotbroker;

    private static readonly string RO_PERCOMRCABROKER = "Percomrcabroker";

    private decimal? _percomrcabroker;

    private static readonly string RO_PERCPARTICIPACLASSEA = "Percparticipaclassea";

    private decimal? _percparticipaclassea;

    private static readonly string RO_PERCPARTICIPACLASSEB = "Percparticipaclasseb";

    private decimal? _percparticipaclasseb;

    private static readonly string RO_PERCPARTICIPASUBCLASSEA1 = "Percparticipasubclassea1";

    private decimal? _percparticipasubclassea1;

    private static readonly string RO_PERCPARTICIPASUBCLASSEA2 = "Percparticipasubclassea2";

    private decimal? _percparticipasubclassea2;

    private static readonly string RO_PERCPARTICIPASUBCLASSEA3 = "Percparticipasubclassea3";

    private decimal? _percparticipasubclassea3;

    private static readonly string RO_PERCPARTICIPASUBCLASSEB1 = "Percparticipasubclasseb1";

    private decimal? _percparticipasubclasseb1;

    private static readonly string RO_PERCPARTICIPASUBCLASSEB2 = "Percparticipasubclasseb2";

    private decimal? _percparticipasubclasseb2;

    private static readonly string RO_PERCPARTICIPASUBCLASSEB3 = "Percparticipasubclasseb3";

    private decimal? _percparticipasubclasseb3;

    private static readonly string RO_PERCPARTICIPASUBCLASSEC1 = "Percparticipasubclassec1";

    private decimal? _percparticipasubclassec1;

    private static readonly string RO_PERCPARTICIPASUBCLASSEC2 = "Percparticipasubclassec2";

    private decimal? _percparticipasubclassec2;

    private static readonly string RO_PERFRETEBROKER = "Perfretebroker";

    private decimal? _perfretebroker;

    private static readonly string RO_PERFRETECONHEC = "Perfreteconhec";

    private decimal? _perfreteconhec;

    private static readonly string RO_PERLIMVENDAPF = "Perlimvendapf";

    private decimal? _perlimvendapf;

    private static readonly string RO_PERMITEAGRUPARBOLETOS = "Permiteagruparboletos";

    private string _permiteagruparboletos;

    private static readonly string RO_PERMITECANCELARNFENTWMS = "Permitecancelarnfentwms";

    private string _permitecancelarnfentwms;

    private static readonly string RO_PERMITECREDICMCOMST = "Permitecredicmcomst";

    private string _permitecredicmcomst;

    private static readonly string RO_PERMITEFATURAR = "Permitefaturar";

    private string _permitefaturar;

    private static readonly string RO_PERMITIRDESDDIFPROF = "Permitirdesddifprof";

    private string _permitirdesddifprof;

    private static readonly string RO_PERMITIRVENDAESTADUALPFCOMIE = "Permitirvendaestadualpfcomie";

    private string _permitirvendaestadualpfcomie;

    private static readonly string RO_PERMITIRVENDAESTADUALPFSEMIE = "Permitirvendaestadualpfsemie";

    private string _permitirvendaestadualpfsemie;

    private static readonly string RO_PERMITIRVENDAINTERESTADUALPF = "Permitirvendainterestadualpf";

    private string _permitirvendainterestadualpf;

    private static readonly string RO_PERVENDAPF = "Pervendapf";

    private decimal? _pervendapf;

    private static readonly string RO_PESOLIMITEOS = "Pesolimiteos";

    private decimal? _pesolimiteos;

    private static readonly string RO_PONDCUSNOTATRANSF = "Pondcusnotatransf";

    private string _pondcusnotatransf;

    private static readonly string RO_PORTAPROXY = "Portaproxy";

    private decimal? _portaproxy;

    private static readonly string RO_PORTASERV = "Portaserv";

    private decimal? _portaserv;

    private static readonly string RO_PRAZOMAXIMPPEDPENDECF = "Prazomaximppedpendecf";

    private decimal? _prazomaximppedpendecf;

    private static readonly string RO_PRECIFICAAUTOMATICO = "Precificaautomatico";

    private string _precificaautomatico;

    private static readonly string RO_PRECOPOREMBALAGEM = "Precoporembalagem";

    private string _precoporembalagem;

    private static readonly string RO_PRODPORETAPA = "Prodporetapa";

    private string _prodporetapa;

    private static readonly string RO_PROXNSU = "Proxnsu";

    private decimal? _proxnsu;

    private static readonly string RO_PROXNUMAVERBACAO = "Proxnumaverbacao";

    private decimal? _proxnumaverbacao;

    private static readonly string RO_PROXNUMCARECF = "Proxnumcarecf";

    private decimal? _proxnumcarecf;

    private static readonly string RO_PROXNUMCONHEC = "Proxnumconhec";

    private decimal? _proxnumconhec;

    private static readonly string RO_PROXNUMCTE = "Proxnumcte";

    private decimal? _proxnumcte;

    private static readonly string RO_PROXNUMENTMEX = "Proxnumentmex";

    private decimal? _proxnumentmex;

    private static readonly string RO_PROXNUMEROORCAMENTO = "Proxnumeroorcamento";

    private decimal? _proxnumeroorcamento;

    private static readonly string RO_PROXNUMETAPA = "Proxnumetapa";

    private decimal? _proxnumetapa;

    private static readonly string RO_PROXNUMLOTE = "Proxnumlote";

    private decimal? _proxnumlote;

    private static readonly string RO_PROXNUMNFDEVCLI = "Proxnumnfdevcli";

    private decimal? _proxnumnfdevcli;

    private static readonly string RO_PROXNUMNFE = "Proxnumnfe";

    private decimal? _proxnumnfe;

    private static readonly string RO_PROXNUMNFEDEVMANISFESTO = "Proxnumnfedevmanisfesto";

    private decimal? _proxnumnfedevmanisfesto;

    private static readonly string RO_PROXNUMNFEDEVMANISFESTOSCAN = "Proxnumnfedevmanisfestoscan";

    private decimal? _proxnumnfedevmanisfestoscan;

    private static readonly string RO_PROXNUMNFEENTRADA = "Proxnumnfeentrada";

    private decimal? _proxnumnfeentrada;

    private static readonly string RO_PROXNUMNFEIMPORTACAO = "Proxnumnfeimportacao";

    private decimal? _proxnumnfeimportacao;

    private static readonly string RO_PROXNUMNFEREMMANISFESTO = "Proxnumnferemmanisfesto";

    private decimal? _proxnumnferemmanisfesto;

    private static readonly string RO_PROXNUMNFEREMMANISFESTOSCAN = "Proxnumnferemmanisfestoscan";

    private decimal? _proxnumnferemmanisfestoscan;

    private static readonly string RO_PROXNUMNFESCAN = "Proxnumnfescan";

    private decimal? _proxnumnfescan;

    private static readonly string RO_PROXNUMNFESCANENTRADA = "Proxnumnfescanentrada";

    private decimal? _proxnumnfescanentrada;

    private static readonly string RO_PROXNUMNFESCANIMPORTACAO = "Proxnumnfescanimportacao";

    private decimal? _proxnumnfescanimportacao;

    private static readonly string RO_PROXNUMNFS = "Proxnumnfs";

    private decimal? _proxnumnfs;

    private static readonly string RO_PROXNUMNOTA = "Proxnumnota";

    private decimal? _proxnumnota;

    private static readonly string RO_PROXNUMNOTACOBRANCA = "Proxnumnotacobranca";

    private decimal? _proxnumnotacobranca;

    private static readonly string RO_PROXNUMNOTAD = "Proxnumnotad";

    private decimal? _proxnumnotad;

    private static readonly string RO_PROXNUMNOTAECF = "Proxnumnotaecf";

    private decimal? _proxnumnotaecf;

    private static readonly string RO_PROXNUMNOTAORIGVENDA = "Proxnumnotaorigvenda";

    private decimal? _proxnumnotaorigvenda;

    private static readonly string RO_PROXNUMNOTATRANSF = "Proxnumnotatransf";

    private decimal? _proxnumnotatransf;

    private static readonly string RO_PROXNUMORC = "Proxnumorc";

    private decimal? _proxnumorc;

    private static readonly string RO_PROXNUMORCAFILIAL = "Proxnumorcafilial";

    private decimal? _proxnumorcafilial;

    private static readonly string RO_PROXNUMOS = "Proxnumos";

    private decimal? _proxnumos;

    private static readonly string RO_PROXNUMPREVENDA = "Proxnumprevenda";

    private decimal? _proxnumprevenda;

    private static readonly string RO_PROXNUMTRANSCONHEC = "Proxnumtransconhec";

    private decimal? _proxnumtransconhec;

    private static readonly string RO_PROXNUMTRANSECF = "Proxnumtransecf";

    private decimal? _proxnumtransecf;

    private static readonly string RO_PROXNUMTRANSVENDAECF = "Proxnumtransvendaecf";

    private decimal? _proxnumtransvendaecf;

    private static readonly string RO_QTDEMAXDIASVENCVERBAS = "Qtdemaxdiasvencverbas";

    private decimal? _qtdemaxdiasvencverbas;

    private static readonly string RO_QTDMAXITENSOS = "Qtdmaxitensos";

    private decimal? _qtdmaxitensos;

    private static readonly string RO_QTDMINITENSMODULOOS = "Qtdminitensmoduloos";

    private decimal? _qtdminitensmoduloos;

    private static readonly string RO_QTMAXPEDIDO = "Qtmaxpedido";

    private decimal? _qtmaxpedido;

    private static readonly string RO_QTMULTIPLAINICIALECF = "Qtmultiplainicialecf";

    private decimal? _qtmultiplainicialecf;

    private static readonly string RO_RAZAOSOCIAL = "Razaosocial";

    private string _razaosocial;

    private static readonly string RO_RAZAOTRANSP = "Razaotransp";

    private string _razaotransp;

    private static readonly string RO_RECALCDVPRODUTO = "Recalcdvproduto";

    private string _recalcdvproduto;

    private static readonly string RO_REDUZIRICMSPROPRIOTRANSF = "Reduziricmspropriotransf";

    private string _reduziricmspropriotransf;

    private static readonly string RO_REGRAARREDONDAMENTOECF = "Regraarredondamentoecf";

    private string _regraarredondamentoecf;

    private static readonly string RO_RETIRARDESCNABAIXA = "Retirardescnabaixa";

    private string _retirardescnabaixa;

    private static readonly string RO_ROTINALANC = "Rotinalanc";

    private string _rotinalanc;

    private static readonly string RO_SENHABANCODADOSWMS = "Senhabancodadoswms";

    private string _senhabancodadoswms;

    private static readonly string RO_SENHAPROXY = "Senhaproxy";

    private string _senhaproxy;

    private static readonly string RO_SENHASERV = "Senhaserv";

    private string _senhaserv;

    private static readonly string RO_SERIECTE = "Seriecte";

    private string _seriecte;

    private static readonly string RO_SERIENFE = "Serienfe";

    private string _serienfe;

    private static readonly string RO_SERIENFEDEVMANIFESTO = "Serienfedevmanifesto";

    private string _serienfedevmanifesto;

    private static readonly string RO_SERIENFEDEVMANIFESTOSCAN = "Serienfedevmanifestoscan";

    private string _serienfedevmanifestoscan;

    private static readonly string RO_SERIENFEENTRADA = "Serienfeentrada";

    private string _serienfeentrada;

    private static readonly string RO_SERIENFEIMPORTACAO = "Serienfeimportacao";

    private string _serienfeimportacao;

    private static readonly string RO_SERIENFEREMMANISFESTO = "Serienferemmanisfesto";

    private string _serienferemmanisfesto;

    private static readonly string RO_SERIENFEREMMANISFESTOSCAN = "Serienferemmanisfestoscan";

    private string _serienferemmanisfestoscan;

    private static readonly string RO_SERIENFESCAN = "Serienfescan";

    private string _serienfescan;

    private static readonly string RO_SERIENFESCANENTRADA = "Serienfescanentrada";

    private string _serienfescanentrada;

    private static readonly string RO_SERIENFESCANIMPORTACAO = "Serienfescanimportacao";

    private string _serienfescanimportacao;

    private static readonly string RO_SERIENFS = "Serienfs";

    private string _serienfs;

    private static readonly string RO_SERVIDORSMTP = "Servidorsmtp";

    private string _servidorsmtp;

    private static readonly string RO_SITTRIBUTOPCIONALNFIMPORTACAO = "Sittributopcionalnfimportacao";

    private string _sittributopcionalnfimportacao;

    private static readonly string RO_SOMAICMSTRANSF = "Somaicmstransf";

    private string _somaicmstransf;

    private static readonly string RO_SOMATARIFABANCDUPLIC = "Somatarifabancduplic";

    private string _somatarifabancduplic;

    private static readonly string RO_STSOMENTEVLCONT = "Stsomentevlcont";

    private string _stsomentevlcont;

    private static readonly string RO_TAXA0 = "Taxa0";

    private decimal? _taxa0;

    private static readonly string RO_TAXA14 = "Taxa14";

    private decimal? _taxa14;

    private static readonly string RO_TAXA21 = "Taxa21";

    private decimal? _taxa21;

    private static readonly string RO_TAXA28 = "Taxa28";

    private decimal? _taxa28;

    private static readonly string RO_TAXA35 = "Taxa35";

    private decimal? _taxa35;

    private static readonly string RO_TAXA42 = "Taxa42";

    private decimal? _taxa42;

    private static readonly string RO_TAXA7 = "Taxa7";

    private decimal? _taxa7;

    private static readonly string RO_TELEFONE = "Telefone";

    private string _telefone;

    private static readonly string RO_TEMPOSEPCAIXAOS = "Temposepcaixaos";

    private decimal? _temposepcaixaos;

    private static readonly string RO_TEMPOSEPINICIALOS = "Temposepinicialos";

    private decimal? _temposepinicialos;

    private static readonly string RO_TEMPOSEPPRODOS = "Temposepprodos";

    private decimal? _temposepprodos;

    private static readonly string RO_TIPOAVALIACAOCOMISSAO = "Tipoavaliacaocomissao";

    private decimal? _tipoavaliacaocomissao;

    private static readonly string RO_TIPOBROKER = "Tipobroker";

    private string _tipobroker;

    private static readonly string RO_TIPOCNPJ = "Tipocnpj";

    private string _tipocnpj;

    private static readonly string RO_TIPODANFE = "Tipodanfe";

    private string _tipodanfe;

    private static readonly string RO_TIPOEXPORTACAO = "Tipoexportacao";

    private string _tipoexportacao;

    private static readonly string RO_TIPOFILIAL = "Tipofilial";

    private string _tipofilial;

    private static readonly string RO_TIPOFRETEAUTO = "Tipofreteauto";

    private string _tipofreteauto;

    private static readonly string RO_TIPOIDENTIFICACAOECF = "Tipoidentificacaoecf";

    private string _tipoidentificacaoecf;

    private static readonly string RO_TIPOMONTAGEM = "Tipomontagem";

    private string _tipomontagem;

    private static readonly string RO_TIPONUMMAPA = "Tiponummapa";

    private string _tiponummapa;

    private static readonly string RO_TIPONUMNFENTRADA = "Tiponumnfentrada";

    private string _tiponumnfentrada;

    private static readonly string RO_TIPOPRECIFICACAO = "Tipoprecificacao";

    private string _tipoprecificacao;

    private static readonly string RO_TRANSFEREVLSTBASESTNATRANSF = "Transferevlstbasestnatransf";

    private string _transferevlstbasestnatransf;

    private static readonly string RO_UF = "Uf";

    private string _uf;

    private static readonly string RO_UFTRANSP = "Uftransp";

    private string _uftransp;

    private static readonly string RO_USABRINDEECF = "Usabrindeecf";

    private string _usabrindeecf;

    private static readonly string RO_USACODBARRAEMBALAGEM = "Usacodbarraembalagem";

    private string _usacodbarraembalagem;

    private static readonly string RO_USACODCLIVENDA = "Usacodclivenda";

    private string _usacodclivenda;

    private static readonly string RO_USACONSULTACHEQUE = "Usaconsultacheque";

    private string _usaconsultacheque;

    private static readonly string RO_USACONTABIL = "Usacontabil";

    private string _usacontabil;

    private static readonly string RO_USACONTROLELOCALIZACAOVEICULO = "Usacontrolelocalizacaoveiculo";

    private string _usacontrolelocalizacaoveiculo;

    private static readonly string RO_USADADOSEMBALAGEMNFE = "Usadadosembalagemnfe";

    private string _usadadosembalagemnfe;

    private static readonly string RO_USADIAUTILFILIAL = "Usadiautilfilial";

    private string _usadiautilfilial;

    private static readonly string RO_USADISTRIB = "Usadistrib";

    private string _usadistrib;

    private static readonly string RO_USAENDERECOFILIAL = "Usaenderecofilial";

    private string _usaenderecofilial;

    private static readonly string RO_USAESTOQUEDEPFECHADO = "Usaestoquedepfechado";

    private string _usaestoquedepfechado;

    private static readonly string RO_USAINTEGRACAOOPERLOG = "Usaintegracaooperlog";

    private string _usaintegracaooperlog;

    private static readonly string RO_USAINTEGRACAOWMS = "Usaintegracaowms";

    private string _usaintegracaowms;

    private static readonly string RO_USAINVENTLOCAL = "Usainventlocal";

    private string _usainventlocal;

    private static readonly string RO_USAMULTIPLOPORDESCONTO = "Usamultiplopordesconto";

    private string _usamultiplopordesconto;

    private static readonly string RO_USANUMNFDEVCLI = "Usanumnfdevcli";

    private string _usanumnfdevcli;

    private static readonly string RO_USANUMNOTAECF = "Usanumnotaecf";

    private string _usanumnotaecf;

    private static readonly string RO_USAORCAMENTOECF = "Usaorcamentoecf";

    private string _usaorcamentoecf;

    private static readonly string RO_USAPOLITICADESCVALOR = "Usapoliticadescvalor";

    private string _usapoliticadescvalor;

    private static readonly string RO_USAPRECOETIQPRODPESADO = "Usaprecoetiqprodpesado";

    private string _usaprecoetiqprodpesado;

    private static readonly string RO_USAPVENDAATACCONFQTMULTIPLA = "Usapvendaatacconfqtmultipla";

    private string _usapvendaatacconfqtmultipla;

    private static readonly string RO_USAPVENDATRANSF = "Usapvendatransf";

    private string _usapvendatransf;

    private static readonly string RO_USAREGIAOFILIALVENDAESTADUAL = "Usaregiaofilialvendaestadual";

    private string _usaregiaofilialvendaestadual;

    private static readonly string RO_USAREGIAOFILIALVENDAINTEREST = "Usaregiaofilialvendainterest";

    private string _usaregiaofilialvendainterest;

    private static readonly string RO_USASERVINTERMEDIARIO = "Usaservintermediario";

    private string _usaservintermediario;

    private static readonly string RO_USATRANSPORTADOPADRAONFE = "Usatransportadopadraonfe";

    private string _usatransportadopadraonfe;

    private static readonly string RO_USAWMS = "Usawms";

    private string _usawms;

    private static readonly string RO_USUARIOBANCODADOSWMS = "Usuariobancodadoswms";

    private string _usuariobancodadoswms;

    private static readonly string RO_USUARIOPROXY = "Usuarioproxy";

    private string _usuarioproxy;

    private static readonly string RO_USUARIOSERV = "Usuarioserv";

    private string _usuarioserv;

    private static readonly string RO_UTILIZACONTROLEBIOMETRICO = "Utilizacontrolebiometrico";

    private string _utilizacontrolebiometrico;

    private static readonly string RO_UTILIZACREDICMSESTCUSTOCONT = "Utilizacredicmsestcustocont";

    private string _utilizacredicmsestcustocont;

    private static readonly string RO_UTILIZACTE = "Utilizacte";

    private string _utilizacte;

    private static readonly string RO_UTILIZANFE = "Utilizanfe";

    private string _utilizanfe;

    private static readonly string RO_UTILIZAORIGEMVENDANF = "Utilizaorigemvendanf";

    private string _utilizaorigemvendanf;

    private static readonly string RO_UTILIZAPERCBASEREDOUTRASDESPPF = "Utilizapercbaseredoutrasdesppf";

    private string _utilizapercbaseredoutrasdesppf;

    private static readonly string RO_UTILIZASEQNFENT = "Utilizaseqnfent";

    private string _utilizaseqnfent;

    private static readonly string RO_UTILIZAVENDAASSISTIDA = "Utilizavendaassistida";

    private string _utilizavendaassistida;

    private static readonly string RO_UTILIZAVENDAPOREMBALAGEM = "Utilizavendaporembalagem";

    private string _utilizavendaporembalagem;

    private static readonly string RO_VALIDAENDPICKINGPEDCOMPRA = "Validaendpickingpedcompra";

    private string _validaendpickingpedcompra;

    private static readonly string RO_VALIDARDESCFLEXAUTOSERV = "Validardescflexautoserv";

    private string _validardescflexautoserv;

    private static readonly string RO_VALIDARENDAPANHAAUTOSERVICO = "Validarendapanhaautoservico";

    private string _validarendapanhaautoservico;

    private static readonly string RO_VALIDARPRECOVENDATV20 = "Validarprecovendatv20";

    private string _validarprecovendatv20;

    private static readonly string RO_VALIDARPRECOVENDATV8 = "Validarprecovendatv8";

    private string _validarprecovendatv8;

    private static readonly string RO_VALIDAVLMAXISENCAOSTPF = "Validavlmaxisencaostpf";

    private string _validavlmaxisencaostpf;

    private static readonly string RO_VALORCAPITAL = "Valorcapital";

    private decimal? _valorcapital;

    private static readonly string RO_VERSAOWMS = "Versaowms";

    private decimal? _versaowms;

    private static readonly string RO_VLMAXISENCAOSTPF = "Vlmaxisencaostpf";

    private decimal? _vlmaxisencaostpf;

    private static readonly string RO_VLMAXTARIFABANC = "Vlmaxtarifabanc";

    private decimal? _vlmaxtarifabanc;

    private static readonly string RO_VLMINTARIFABANC = "Vlmintarifabanc";

    private decimal? _vlmintarifabanc;

    private static readonly string RO_VLPALETEDESCARG = "Vlpaletedescarg";

    private decimal? _vlpaletedescarg;

    private static readonly string RO_VLPESODESCARGA = "Vlpesodescarga";

    private decimal? _vlpesodescarga;

    private static readonly string RO_VLPESODESCARGAPAL = "Vlpesodescargapal";

    private decimal? _vlpesodescargapal;

    private static readonly string RO_VLREMONTEDESCARGA = "Vlremontedescarga";

    private decimal? _vlremontedescarga;

    private static readonly string RO_VLTARIFA = "Vltarifa";

    private decimal? _vltarifa;

    private static readonly string RO_VLVOLDESCARGA = "Vlvoldescarga";

    private decimal? _vlvoldescarga;

    private static readonly string RO_VLVOLUMEDESCARGAFD = "Vlvolumedescargafd";

    private decimal? _vlvolumedescargafd;

    private static readonly string RO_UTILIZARECALCULOSTCHECKOUT = "Utilizarecalculostcheckout";

    private string _utilizarecalculostcheckout;

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Aceitavendaavistaclibloq
    {
        get
        {
            PropriedadeAcessada(RO_ACEITAVENDAAVISTACLIBLOQ);
            return _aceitavendaavistaclibloq;
        }
        set
        {
            PropriedadeModificada(RO_ACEITAVENDAAVISTACLIBLOQ, value);
            _aceitavendaavistaclibloq = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Aceitavendasemest
    {
        get
        {
            PropriedadeAcessada(RO_ACEITAVENDASEMEST);
            return _aceitavendasemest;
        }
        set
        {
            PropriedadeModificada(RO_ACEITAVENDASEMEST, value);
            _aceitavendasemest = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 2)]
    public decimal? Aliqicminteroutrasdesp
    {
        get
        {
            PropriedadeAcessada(RO_ALIQICMINTEROUTRASDESP);
            return _aliqicminteroutrasdesp;
        }
        set
        {
            PropriedadeModificada(RO_ALIQICMINTEROUTRASDESP, value);
            _aliqicminteroutrasdesp = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 2)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 2, Precisao = 0)]
    public decimal? Aliquotafreteest
    {
        get
        {
            PropriedadeAcessada(RO_ALIQUOTAFRETEEST);
            return _aliquotafreteest;
        }
        set
        {
            PropriedadeModificada(RO_ALIQUOTAFRETEEST, value);
            _aliquotafreteest = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Alterapedidoretornadowms
    {
        get
        {
            PropriedadeAcessada(RO_ALTERAPEDIDORETORNADOWMS);
            return _alterapedidoretornadowms;
        }
        set
        {
            PropriedadeModificada(RO_ALTERAPEDIDORETORNADOWMS, value);
            _alterapedidoretornadowms = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Alterarcobbkchautomatico
    {
        get
        {
            PropriedadeAcessada(RO_ALTERARCOBBKCHAUTOMATICO);
            return _alterarcobbkchautomatico;
        }
        set
        {
            PropriedadeModificada(RO_ALTERARCOBBKCHAUTOMATICO, value);
            _alterarcobbkchautomatico = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Aplicapercatacnaocontrib
    {
        get
        {
            PropriedadeAcessada(RO_APLICAPERCATACNAOCONTRIB);
            return _aplicapercatacnaocontrib;
        }
        set
        {
            PropriedadeModificada(RO_APLICAPERCATACNAOCONTRIB, value);
            _aplicapercatacnaocontrib = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Aplicapercvarnaocontrib
    {
        get
        {
            PropriedadeAcessada(RO_APLICAPERCVARNAOCONTRIB);
            return _aplicapercvarnaocontrib;
        }
        set
        {
            PropriedadeModificada(RO_APLICAPERCVARNAOCONTRIB, value);
            _aplicapercvarnaocontrib = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Aproveitadesp_Piscofins
    {
        get
        {
            PropriedadeAcessada(RO_APROVEITADESP_PISCOFINS);
            return _aproveitadesp_piscofins;
        }
        set
        {
            PropriedadeModificada(RO_APROVEITADESP_PISCOFINS, value);
            _aproveitadesp_piscofins = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Aproveitafrete_Piscofins
    {
        get
        {
            PropriedadeAcessada(RO_APROVEITAFRETE_PISCOFINS);
            return _aproveitafrete_piscofins;
        }
        set
        {
            PropriedadeModificada(RO_APROVEITAFRETE_PISCOFINS, value);
            _aproveitafrete_piscofins = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Aproveitaipi_Piscofins
    {
        get
        {
            PropriedadeAcessada(RO_APROVEITAIPI_PISCOFINS);
            return _aproveitaipi_piscofins;
        }
        set
        {
            PropriedadeModificada(RO_APROVEITAIPI_PISCOFINS, value);
            _aproveitaipi_piscofins = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 4)]
    public decimal? Areavenda
    {
        get
        {
            PropriedadeAcessada(RO_AREAVENDA);
            return _areavenda;
        }
        set
        {
            PropriedadeModificada(RO_AREAVENDA, value);
            _areavenda = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Arredondaqtgirodia
    {
        get
        {
            PropriedadeAcessada(RO_ARREDONDAQTGIRODIA);
            return _arredondaqtgirodia;
        }
        set
        {
            PropriedadeModificada(RO_ARREDONDAQTGIRODIA, value);
            _arredondaqtgirodia = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Arredvlitensnfsaida
    {
        get
        {
            PropriedadeAcessada(RO_ARREDVLITENSNFSAIDA);
            return _arredvlitensnfsaida;
        }
        set
        {
            PropriedadeModificada(RO_ARREDVLITENSNFSAIDA, value);
            _arredvlitensnfsaida = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 50, Precisao = 0)]
    public string Atividade
    {
        get
        {
            PropriedadeAcessada(RO_ATIVIDADE);
            return _atividade;
        }
        set
        {
            PropriedadeModificada(RO_ATIVIDADE, value);
            _atividade = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Atualizacustoultentransf
    {
        get
        {
            PropriedadeAcessada(RO_ATUALIZACUSTOULTENTRANSF);
            return _atualizacustoultentransf;
        }
        set
        {
            PropriedadeModificada(RO_ATUALIZACUSTOULTENTRANSF, value);
            _atualizacustoultentransf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Autoservico
    {
        get
        {
            PropriedadeAcessada(RO_AUTOSERVICO);
            return _autoservico;
        }
        set
        {
            PropriedadeModificada(RO_AUTOSERVICO, value);
            _autoservico = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Bloqdesdemitentedif
    {
        get
        {
            PropriedadeAcessada(RO_BLOQDESDEMITENTEDIF);
            return _bloqdesdemitentedif;
        }
        set
        {
            PropriedadeModificada(RO_BLOQDESDEMITENTEDIF, value);
            _bloqdesdemitentedif = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Bloqdevcli
    {
        get
        {
            PropriedadeAcessada(RO_BLOQDEVCLI);
            return _bloqdevcli;
        }
        set
        {
            PropriedadeModificada(RO_BLOQDEVCLI, value);
            _bloqdevcli = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Bloqestoquetransf
    {
        get
        {
            PropriedadeAcessada(RO_BLOQESTOQUETRANSF);
            return _bloqestoquetransf;
        }
        set
        {
            PropriedadeModificada(RO_BLOQESTOQUETRANSF, value);
            _bloqestoquetransf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Bloquearpedidosabaixovlminimo
    {
        get
        {
            PropriedadeAcessada(RO_BLOQUEARPEDIDOSABAIXOVLMINIMO);
            return _bloquearpedidosabaixovlminimo;
        }
        set
        {
            PropriedadeModificada(RO_BLOQUEARPEDIDOSABAIXOVLMINIMO, value);
            _bloquearpedidosabaixovlminimo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Bloqueiariskscoring
    {
        get
        {
            PropriedadeAcessada(RO_BLOQUEIARISKSCORING);
            return _bloqueiariskscoring;
        }
        set
        {
            PropriedadeModificada(RO_BLOQUEIARISKSCORING, value);
            _bloqueiariskscoring = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 30, Precisao = 0)]
    public string Cae
    {
        get
        {
            PropriedadeAcessada(RO_CAE);
            return _cae;
        }
        set
        {
            PropriedadeModificada(RO_CAE, value);
            _cae = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Calcestdispcomqtminautoserv
    {
        get
        {
            PropriedadeAcessada(RO_CALCESTDISPCOMQTMINAUTOSERV);
            return _calcestdispcomqtminautoserv;
        }
        set
        {
            PropriedadeModificada(RO_CALCESTDISPCOMQTMINAUTOSERV, value);
            _calcestdispcomqtminautoserv = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Calcredpisfrete
    {
        get
        {
            PropriedadeAcessada(RO_CALCREDPISFRETE);
            return _calcredpisfrete;
        }
        set
        {
            PropriedadeModificada(RO_CALCREDPISFRETE, value);
            _calcredpisfrete = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Calcredpisfretecont
    {
        get
        {
            PropriedadeAcessada(RO_CALCREDPISFRETECONT);
            return _calcredpisfretecont;
        }
        set
        {
            PropriedadeModificada(RO_CALCREDPISFRETECONT, value);
            _calcredpisfretecont = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Calcularcomissaopvenda1
    {
        get
        {
            PropriedadeAcessada(RO_CALCULARCOMISSAOPVENDA1);
            return _calcularcomissaopvenda1;
        }
        set
        {
            PropriedadeModificada(RO_CALCULARCOMISSAOPVENDA1, value);
            _calcularcomissaopvenda1 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Calcularipivenda
    {
        get
        {
            PropriedadeAcessada(RO_CALCULARIPIVENDA);
            return _calcularipivenda;
        }
        set
        {
            PropriedadeModificada(RO_CALCULARIPIVENDA, value);
            _calcularipivenda = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Cancelanfdevclicomwms
    {
        get
        {
            PropriedadeAcessada(RO_CANCELANFDEVCLICOMWMS);
            return _cancelanfdevclicomwms;
        }
        set
        {
            PropriedadeModificada(RO_CANCELANFDEVCLICOMWMS, value);
            _cancelanfdevclicomwms = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Cancelanfentradacomwms
    {
        get
        {
            PropriedadeAcessada(RO_CANCELANFENTRADACOMWMS);
            return _cancelanfentradacomwms;
        }
        set
        {
            PropriedadeModificada(RO_CANCELANFENTRADACOMWMS, value);
            _cancelanfentradacomwms = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Cancelanfvendacomwms
    {
        get
        {
            PropriedadeAcessada(RO_CANCELANFVENDACOMWMS);
            return _cancelanfvendacomwms;
        }
        set
        {
            PropriedadeModificada(RO_CANCELANFVENDACOMWMS, value);
            _cancelanfvendacomwms = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Cancelapedidoretornadowms
    {
        get
        {
            PropriedadeAcessada(RO_CANCELAPEDIDORETORNADOWMS);
            return _cancelapedidoretornadowms;
        }
        set
        {
            PropriedadeModificada(RO_CANCELAPEDIDORETORNADOWMS, value);
            _cancelapedidoretornadowms = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 11, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 14, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 14, Precisao = 0)]
    public string Cgc_Operadorlogistico
    {
        get
        {
            PropriedadeAcessada(RO_CGC_OPERADORLOGISTICO);
            return _cgc_operadorlogistico;
        }
        set
        {
            PropriedadeModificada(RO_CGC_OPERADORLOGISTICO, value);
            _cgc_operadorlogistico = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
    public string Cgctransp
    {
        get
        {
            PropriedadeAcessada(RO_CGCTRANSP);
            return _cgctransp;
        }
        set
        {
            PropriedadeModificada(RO_CGCTRANSP, value);
            _cgctransp = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 30, Precisao = 0)]
    public string Cidade
    {
        get
        {
            PropriedadeAcessada(RO_CIDADE);
            return _cidade;
        }
        set
        {
            PropriedadeModificada(RO_CIDADE, value);
            _cidade = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
    public string Cidadetransp
    {
        get
        {
            PropriedadeAcessada(RO_CIDADETRANSP);
            return _cidadetransp;
        }
        set
        {
            PropriedadeModificada(RO_CIDADETRANSP, value);
            _cidadetransp = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Clicrependente
    {
        get
        {
            PropriedadeAcessada(RO_CLICREPENDENTE);
            return _clicrependente;
        }
        set
        {
            PropriedadeModificada(RO_CLICREPENDENTE, value);
            _clicrependente = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 14, Precisao = 0)]
    public string Cnpj_Paf
    {
        get
        {
            PropriedadeAcessada(RO_CNPJ_PAF);
            return _cnpj_paf;
        }
        set
        {
            PropriedadeModificada(RO_CNPJ_PAF, value);
            _cnpj_paf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codcli
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codcliconsumidor
    {
        get
        {
            PropriedadeAcessada(RO_CODCLICONSUMIDOR);
            return _codcliconsumidor;
        }
        set
        {
            PropriedadeModificada(RO_CODCLICONSUMIDOR, value);
            _codcliconsumidor = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Codcontacredfornec
    {
        get
        {
            PropriedadeAcessada(RO_CODCONTACREDFORNEC);
            return _codcontacredfornec;
        }
        set
        {
            PropriedadeModificada(RO_CODCONTACREDFORNEC, value);
            _codcontacredfornec = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 0)]
    public decimal? Codcontador
    {
        get
        {
            PropriedadeAcessada(RO_CODCONTADOR);
            return _codcontador;
        }
        set
        {
            PropriedadeModificada(RO_CODCONTADOR, value);
            _codcontador = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Codcontaentimportacao
    {
        get
        {
            PropriedadeAcessada(RO_CODCONTAENTIMPORTACAO);
            return _codcontaentimportacao;
        }
        set
        {
            PropriedadeModificada(RO_CODCONTAENTIMPORTACAO, value);
            _codcontaentimportacao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Codcontapercacrescent
    {
        get
        {
            PropriedadeAcessada(RO_CODCONTAPERCACRESCENT);
            return _codcontapercacrescent;
        }
        set
        {
            PropriedadeModificada(RO_CODCONTAPERCACRESCENT, value);
            _codcontapercacrescent = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Codcontarecarga
    {
        get
        {
            PropriedadeAcessada(RO_CODCONTARECARGA);
            return _codcontarecarga;
        }
        set
        {
            PropriedadeModificada(RO_CODCONTARECARGA, value);
            _codcontarecarga = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Codcontavendaentregafut
    {
        get
        {
            PropriedadeAcessada(RO_CODCONTAVENDAENTREGAFUT);
            return _codcontavendaentregafut;
        }
        set
        {
            PropriedadeModificada(RO_CODCONTAVENDAENTREGAFUT, value);
            _codcontavendaentregafut = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Coddocdevfornec
    {
        get
        {
            PropriedadeAcessada(RO_CODDOCDEVFORNEC);
            return _coddocdevfornec;
        }
        set
        {
            PropriedadeModificada(RO_CODDOCDEVFORNEC, value);
            _coddocdevfornec = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Coddocdevol
    {
        get
        {
            PropriedadeAcessada(RO_CODDOCDEVOL);
            return _coddocdevol;
        }
        set
        {
            PropriedadeModificada(RO_CODDOCDEVOL, value);
            _coddocdevol = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Coddocentradamerc
    {
        get
        {
            PropriedadeAcessada(RO_CODDOCENTRADAMERC);
            return _coddocentradamerc;
        }
        set
        {
            PropriedadeModificada(RO_CODDOCENTRADAMERC, value);
            _coddocentradamerc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Coddocnf
    {
        get
        {
            PropriedadeAcessada(RO_CODDOCNF);
            return _coddocnf;
        }
        set
        {
            PropriedadeModificada(RO_CODDOCNF, value);
            _coddocnf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Coddocnfc
    {
        get
        {
            PropriedadeAcessada(RO_CODDOCNFC);
            return _coddocnfc;
        }
        set
        {
            PropriedadeModificada(RO_CODDOCNFC, value);
            _coddocnfc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Coddocnotacobranca
    {
        get
        {
            PropriedadeAcessada(RO_CODDOCNOTACOBRANCA);
            return _coddocnotacobranca;
        }
        set
        {
            PropriedadeModificada(RO_CODDOCNOTACOBRANCA, value);
            _coddocnotacobranca = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Coddocorigemnf
    {
        get
        {
            PropriedadeAcessada(RO_CODDOCORIGEMNF);
            return _coddocorigemnf;
        }
        set
        {
            PropriedadeModificada(RO_CODDOCORIGEMNF, value);
            _coddocorigemnf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Coddocse
    {
        get
        {
            PropriedadeAcessada(RO_CODDOCSE);
            return _coddocse;
        }
        set
        {
            PropriedadeModificada(RO_CODDOCSE, value);
            _coddocse = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Coddocsr
    {
        get
        {
            PropriedadeAcessada(RO_CODDOCSR);
            return _coddocsr;
        }
        set
        {
            PropriedadeModificada(RO_CODDOCSR, value);
            _coddocsr = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Coddocsrauto
    {
        get
        {
            PropriedadeAcessada(RO_CODDOCSRAUTO);
            return _coddocsrauto;
        }
        set
        {
            PropriedadeModificada(RO_CODDOCSRAUTO, value);
            _coddocsrauto = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Coddocss
    {
        get
        {
            PropriedadeAcessada(RO_CODDOCSS);
            return _coddocss;
        }
        set
        {
            PropriedadeModificada(RO_CODDOCSS, value);
            _coddocss = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Coddoctransf
    {
        get
        {
            PropriedadeAcessada(RO_CODDOCTRANSF);
            return _coddoctransf;
        }
        set
        {
            PropriedadeModificada(RO_CODDOCTRANSF, value);
            _coddoctransf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Codestado
    {
        get
        {
            PropriedadeAcessada(RO_CODESTADO);
            return _codestado;
        }
        set
        {
            PropriedadeModificada(RO_CODESTADO, value);
            _codestado = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Codfilialprefestbalcao
    {
        get
        {
            PropriedadeAcessada(RO_CODFILIALPREFESTBALCAO);
            return _codfilialprefestbalcao;
        }
        set
        {
            PropriedadeModificada(RO_CODFILIALPREFESTBALCAO, value);
            _codfilialprefestbalcao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Codfilialprefesttlmk
    {
        get
        {
            PropriedadeAcessada(RO_CODFILIALPREFESTTLMK);
            return _codfilialprefesttlmk;
        }
        set
        {
            PropriedadeModificada(RO_CODFILIALPREFESTTLMK, value);
            _codfilialprefesttlmk = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Codfilialproducao
    {
        get
        {
            PropriedadeAcessada(RO_CODFILIALPRODUCAO);
            return _codfilialproducao;
        }
        set
        {
            PropriedadeModificada(RO_CODFILIALPRODUCAO, value);
            _codfilialproducao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Codfiscaldevoutrasdesp
    {
        get
        {
            PropriedadeAcessada(RO_CODFISCALDEVOUTRASDESP);
            return _codfiscaldevoutrasdesp;
        }
        set
        {
            PropriedadeModificada(RO_CODFISCALDEVOUTRASDESP, value);
            _codfiscaldevoutrasdesp = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Codfiscalinterdevoutrasdesp
    {
        get
        {
            PropriedadeAcessada(RO_CODFISCALINTERDEVOUTRASDESP);
            return _codfiscalinterdevoutrasdesp;
        }
        set
        {
            PropriedadeModificada(RO_CODFISCALINTERDEVOUTRASDESP, value);
            _codfiscalinterdevoutrasdesp = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Codfiscalinteroutrasdesp
    {
        get
        {
            PropriedadeAcessada(RO_CODFISCALINTEROUTRASDESP);
            return _codfiscalinteroutrasdesp;
        }
        set
        {
            PropriedadeModificada(RO_CODFISCALINTEROUTRASDESP, value);
            _codfiscalinteroutrasdesp = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Codfiscalopcionalnfimportacao
    {
        get
        {
            PropriedadeAcessada(RO_CODFISCALOPCIONALNFIMPORTACAO);
            return _codfiscalopcionalnfimportacao;
        }
        set
        {
            PropriedadeModificada(RO_CODFISCALOPCIONALNFIMPORTACAO, value);
            _codfiscalopcionalnfimportacao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 13, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Codgrupo
    {
        get
        {
            PropriedadeAcessada(RO_CODGRUPO);
            return _codgrupo;
        }
        set
        {
            PropriedadeModificada(RO_CODGRUPO, value);
            _codgrupo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 0)]
    public decimal? Codgrupofilial
    {
        get
        {
            PropriedadeAcessada(RO_CODGRUPOFILIAL);
            return _codgrupofilial;
        }
        set
        {
            PropriedadeModificada(RO_CODGRUPOFILIAL, value);
            _codgrupofilial = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codgrupoloja
    {
        get
        {
            PropriedadeAcessada(RO_CODGRUPOLOJA);
            return _codgrupoloja;
        }
        set
        {
            PropriedadeModificada(RO_CODGRUPOLOJA, value);
            _codgrupoloja = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Codigo
    {
        get
        {
            PropriedadeAcessada(RO_CODIGO);
            return _codigo;
        }
        set
        {
            PropriedadeModificada(RO_CODIGO, value);
            _codigo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
    public string Codmd5_Paf
    {
        get
        {
            PropriedadeAcessada(RO_CODMD5_PAF);
            return _codmd5_paf;
        }
        set
        {
            PropriedadeModificada(RO_CODMD5_PAF, value);
            _codmd5_paf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Codmun
    {
        get
        {
            PropriedadeAcessada(RO_CODMUN);
            return _codmun;
        }
        set
        {
            PropriedadeModificada(RO_CODMUN, value);
            _codmun = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
    public string Codregistro
    {
        get
        {
            PropriedadeAcessada(RO_CODREGISTRO);
            return _codregistro;
        }
        set
        {
            PropriedadeModificada(RO_CODREGISTRO, value);
            _codregistro = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 0)]
    public decimal? Codsocio
    {
        get
        {
            PropriedadeAcessada(RO_CODSOCIO);
            return _codsocio;
        }
        set
        {
            PropriedadeModificada(RO_CODSOCIO, value);
            _codsocio = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Concederdescisencaostpf
    {
        get
        {
            PropriedadeAcessada(RO_CONCEDERDESCISENCAOSTPF);
            return _concederdescisencaostpf;
        }
        set
        {
            PropriedadeModificada(RO_CONCEDERDESCISENCAOSTPF, value);
            _concederdescisencaostpf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Conferirsomentepedacertadocx
    {
        get
        {
            PropriedadeAcessada(RO_CONFERIRSOMENTEPEDACERTADOCX);
            return _conferirsomentepedacertadocx;
        }
        set
        {
            PropriedadeModificada(RO_CONFERIRSOMENTEPEDACERTADOCX, value);
            _conferirsomentepedacertadocx = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Consideraestpendsugcompra
    {
        get
        {
            PropriedadeAcessada(RO_CONSIDERAESTPENDSUGCOMPRA);
            return _consideraestpendsugcompra;
        }
        set
        {
            PropriedadeModificada(RO_CONSIDERAESTPENDSUGCOMPRA, value);
            _consideraestpendsugcompra = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Consideramontagemgiromerc
    {
        get
        {
            PropriedadeAcessada(RO_CONSIDERAMONTAGEMGIROMERC);
            return _consideramontagemgiromerc;
        }
        set
        {
            PropriedadeModificada(RO_CONSIDERAMONTAGEMGIROMERC, value);
            _consideramontagemgiromerc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Considerarcomissaozero
    {
        get
        {
            PropriedadeAcessada(RO_CONSIDERARCOMISSAOZERO);
            return _considerarcomissaozero;
        }
        set
        {
            PropriedadeModificada(RO_CONSIDERARCOMISSAOZERO, value);
            _considerarcomissaozero = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Consideraricmsantecipcusto
    {
        get
        {
            PropriedadeAcessada(RO_CONSIDERARICMSANTECIPCUSTO);
            return _consideraricmsantecipcusto;
        }
        set
        {
            PropriedadeModificada(RO_CONSIDERARICMSANTECIPCUSTO, value);
            _consideraricmsantecipcusto = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Consolidadados504
    {
        get
        {
            PropriedadeAcessada(RO_CONSOLIDADADOS504);
            return _consolidadados504;
        }
        set
        {
            PropriedadeModificada(RO_CONSOLIDADADOS504, value);
            _consolidadados504 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 30, Precisao = 0)]
    public string Contato
    {
        get
        {
            PropriedadeAcessada(RO_CONTATO);
            return _contato;
        }
        set
        {
            PropriedadeModificada(RO_CONTATO, value);
            _contato = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Controlagarantiaservico
    {
        get
        {
            PropriedadeAcessada(RO_CONTROLAGARANTIASERVICO);
            return _controlagarantiaservico;
        }
        set
        {
            PropriedadeModificada(RO_CONTROLAGARANTIASERVICO, value);
            _controlagarantiaservico = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Controlenfeporserie
    {
        get
        {
            PropriedadeAcessada(RO_CONTROLENFEPORSERIE);
            return _controlenfeporserie;
        }
        set
        {
            PropriedadeModificada(RO_CONTROLENFEPORSERIE, value);
            _controlenfeporserie = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Corteautomaticopedvendawms
    {
        get
        {
            PropriedadeAcessada(RO_CORTEAUTOMATICOPEDVENDAWMS);
            return _corteautomaticopedvendawms;
        }
        set
        {
            PropriedadeModificada(RO_CORTEAUTOMATICOPEDVENDAWMS, value);
            _corteautomaticopedvendawms = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 19, Precisao = 0)]
    public string Datahora_Primeirodocumento_Ecf
    {
        get
        {
            PropriedadeAcessada(RO_DATAHORA_PRIMEIRODOCUMENTO_ECF);
            return _datahora_primeirodocumento_ecf;
        }
        set
        {
            PropriedadeModificada(RO_DATAHORA_PRIMEIRODOCUMENTO_ECF, value);
            _datahora_primeirodocumento_ecf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Depfechado
    {
        get
        {
            PropriedadeAcessada(RO_DEPFECHADO);
            return _depfechado;
        }
        set
        {
            PropriedadeModificada(RO_DEPFECHADO, value);
            _depfechado = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Destacarimpostosvendatv13
    {
        get
        {
            PropriedadeAcessada(RO_DESTACARIMPOSTOSVENDATV13);
            return _destacarimpostosvendatv13;
        }
        set
        {
            PropriedadeModificada(RO_DESTACARIMPOSTOSVENDATV13, value);
            _destacarimpostosvendatv13 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Destacarimpostosvendatv14
    {
        get
        {
            PropriedadeAcessada(RO_DESTACARIMPOSTOSVENDATV14);
            return _destacarimpostosvendatv14;
        }
        set
        {
            PropriedadeModificada(RO_DESTACARIMPOSTOSVENDATV14, value);
            _destacarimpostosvendatv14 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Devfornecestoqueavaria
    {
        get
        {
            PropriedadeAcessada(RO_DEVFORNECESTOQUEAVARIA);
            return _devfornecestoqueavaria;
        }
        set
        {
            PropriedadeModificada(RO_DEVFORNECESTOQUEAVARIA, value);
            _devfornecestoqueavaria = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Diascurvatura
    {
        get
        {
            PropriedadeAcessada(RO_DIASCURVATURA);
            return _diascurvatura;
        }
        set
        {
            PropriedadeModificada(RO_DIASCURVATURA, value);
            _diascurvatura = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Diasprazotransf
    {
        get
        {
            PropriedadeAcessada(RO_DIASPRAZOTRANSF);
            return _diasprazotransf;
        }
        set
        {
            PropriedadeModificada(RO_DIASPRAZOTRANSF, value);
            _diasprazotransf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 2, Precisao = 0)]
    public decimal? Diavencicmsantecip
    {
        get
        {
            PropriedadeAcessada(RO_DIAVENCICMSANTECIP);
            return _diavencicmsantecip;
        }
        set
        {
            PropriedadeModificada(RO_DIAVENCICMSANTECIP, value);
            _diavencicmsantecip = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 200, Precisao = 0)]
    public string Direxpxmlsngpc
    {
        get
        {
            PropriedadeAcessada(RO_DIREXPXMLSNGPC);
            return _direxpxmlsngpc;
        }
        set
        {
            PropriedadeModificada(RO_DIREXPXMLSNGPC, value);
            _direxpxmlsngpc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 150, Precisao = 0)]
    public string Dominioserv
    {
        get
        {
            PropriedadeAcessada(RO_DOMINIOSERV);
            return _dominioserv;
        }
        set
        {
            PropriedadeModificada(RO_DOMINIOSERV, value);
            _dominioserv = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtaltmatricsngpc
    {
        get
        {
            PropriedadeAcessada(RO_DTALTMATRICSNGPC);
            return _dtaltmatricsngpc;
        }
        set
        {
            PropriedadeModificada(RO_DTALTMATRICSNGPC, value);
            _dtaltmatricsngpc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtfimatividade
    {
        get
        {
            PropriedadeAcessada(RO_DTFIMATIVIDADE);
            return _dtfimatividade;
        }
        set
        {
            PropriedadeModificada(RO_DTFIMATIVIDADE, value);
            _dtfimatividade = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtiniatividade
    {
        get
        {
            PropriedadeAcessada(RO_DTINIATIVIDADE);
            return _dtiniatividade;
        }
        set
        {
            PropriedadeModificada(RO_DTINIATIVIDADE, value);
            _dtiniatividade = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtregistro
    {
        get
        {
            PropriedadeAcessada(RO_DTREGISTRO);
            return _dtregistro;
        }
        set
        {
            PropriedadeModificada(RO_DTREGISTRO, value);
            _dtregistro = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtultatualizacaodrvinter
    {
        get
        {
            PropriedadeAcessada(RO_DTULTATUALIZACAODRVINTER);
            return _dtultatualizacaodrvinter;
        }
        set
        {
            PropriedadeModificada(RO_DTULTATUALIZACAODRVINTER, value);
            _dtultatualizacaodrvinter = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtutilizacte
    {
        get
        {
            PropriedadeAcessada(RO_DTUTILIZACTE);
            return _dtutilizacte;
        }
        set
        {
            PropriedadeModificada(RO_DTUTILIZACTE, value);
            _dtutilizacte = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtutilizanfe
    {
        get
        {
            PropriedadeAcessada(RO_DTUTILIZANFE);
            return _dtutilizanfe;
        }
        set
        {
            PropriedadeModificada(RO_DTUTILIZANFE, value);
            _dtutilizanfe = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 0)]
    public decimal? Eanemissor
    {
        get
        {
            PropriedadeAcessada(RO_EANEMISSOR);
            return _eanemissor;
        }
        set
        {
            PropriedadeModificada(RO_EANEMISSOR, value);
            _eanemissor = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 100, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 150, Precisao = 0)]
    public string Emailcopiaresposta
    {
        get
        {
            PropriedadeAcessada(RO_EMAILCOPIARESPOSTA);
            return _emailcopiaresposta;
        }
        set
        {
            PropriedadeModificada(RO_EMAILCOPIARESPOSTA, value);
            _emailcopiaresposta = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 150, Precisao = 0)]
    public string Emailremetente
    {
        get
        {
            PropriedadeAcessada(RO_EMAILREMETENTE);
            return _emailremetente;
        }
        set
        {
            PropriedadeModificada(RO_EMAILREMETENTE, value);
            _emailremetente = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 150, Precisao = 0)]
    public string Emailresposta
    {
        get
        {
            PropriedadeAcessada(RO_EMAILRESPOSTA);
            return _emailresposta;
        }
        set
        {
            PropriedadeModificada(RO_EMAILRESPOSTA, value);
            _emailresposta = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 150, Precisao = 0)]
    public string Enderecoproxy
    {
        get
        {
            PropriedadeAcessada(RO_ENDERECOPROXY);
            return _enderecoproxy;
        }
        set
        {
            PropriedadeModificada(RO_ENDERECOPROXY, value);
            _enderecoproxy = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
    public string Endtransp
    {
        get
        {
            PropriedadeAcessada(RO_ENDTRANSP);
            return _endtransp;
        }
        set
        {
            PropriedadeModificada(RO_ENDTRANSP, value);
            _endtransp = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Enviacontaspagarnfe
    {
        get
        {
            PropriedadeAcessada(RO_ENVIACONTASPAGARNFE);
            return _enviacontaspagarnfe;
        }
        set
        {
            PropriedadeModificada(RO_ENVIACONTASPAGARNFE, value);
            _enviacontaspagarnfe = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Enviacontasrecebernfe
    {
        get
        {
            PropriedadeAcessada(RO_ENVIACONTASRECEBERNFE);
            return _enviacontasrecebernfe;
        }
        set
        {
            PropriedadeModificada(RO_ENVIACONTASRECEBERNFE, value);
            _enviacontasrecebernfe = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Estornacustodevfornec
    {
        get
        {
            PropriedadeAcessada(RO_ESTORNACUSTODEVFORNEC);
            return _estornacustodevfornec;
        }
        set
        {
            PropriedadeModificada(RO_ESTORNACUSTODEVFORNEC, value);
            _estornacustodevfornec = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Exibirimpostosforanfimportacao
    {
        get
        {
            PropriedadeAcessada(RO_EXIBIRIMPOSTOSFORANFIMPORTACAO);
            return _exibirimpostosforanfimportacao;
        }
        set
        {
            PropriedadeModificada(RO_EXIBIRIMPOSTOSFORANFIMPORTACAO, value);
            _exibirimpostosforanfimportacao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Exigiremissaomapabalcao
    {
        get
        {
            PropriedadeAcessada(RO_EXIGIREMISSAOMAPABALCAO);
            return _exigiremissaomapabalcao;
        }
        set
        {
            PropriedadeModificada(RO_EXIGIREMISSAOMAPABALCAO, value);
            _exigiremissaomapabalcao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 25, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 18, Precisao = 0)]
    public string Fax
    {
        get
        {
            PropriedadeAcessada(RO_FAX);
            return _fax;
        }
        set
        {
            PropriedadeModificada(RO_FAX, value);
            _fax = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Gerabasenormalquandost
    {
        get
        {
            PropriedadeAcessada(RO_GERABASENORMALQUANDOST);
            return _gerabasenormalquandost;
        }
        set
        {
            PropriedadeModificada(RO_GERABASENORMALQUANDOST, value);
            _gerabasenormalquandost = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Gerapedidocomitenssemest
    {
        get
        {
            PropriedadeAcessada(RO_GERAPEDIDOCOMITENSSEMEST);
            return _gerapedidocomitenssemest;
        }
        set
        {
            PropriedadeModificada(RO_GERAPEDIDOCOMITENSSEMEST, value);
            _gerapedidocomitenssemest = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Gerarnsu
    {
        get
        {
            PropriedadeAcessada(RO_GERARNSU);
            return _gerarnsu;
        }
        set
        {
            PropriedadeModificada(RO_GERARNSU, value);
            _gerarnsu = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Gerarnumloteautomaticpa
    {
        get
        {
            PropriedadeAcessada(RO_GERARNUMLOTEAUTOMATICPA);
            return _gerarnumloteautomaticpa;
        }
        set
        {
            PropriedadeModificada(RO_GERARNUMLOTEAUTOMATICPA, value);
            _gerarnumloteautomaticpa = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Gerarpchistest
    {
        get
        {
            PropriedadeAcessada(RO_GERARPCHISTEST);
            return _gerarpchistest;
        }
        set
        {
            PropriedadeModificada(RO_GERARPCHISTEST, value);
            _gerarpchistest = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Gerarpedconsignacaovasilhame
    {
        get
        {
            PropriedadeAcessada(RO_GERARPEDCONSIGNACAOVASILHAME);
            return _gerarpedconsignacaovasilhame;
        }
        set
        {
            PropriedadeModificada(RO_GERARPEDCONSIGNACAOVASILHAME, value);
            _gerarpedconsignacaovasilhame = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Gravarvalordescfin
    {
        get
        {
            PropriedadeAcessada(RO_GRAVARVALORDESCFIN);
            return _gravarvalordescfin;
        }
        set
        {
            PropriedadeModificada(RO_GRAVARVALORDESCFIN, value);
            _gravarvalordescfin = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Horafinaldigitacaoped
    {
        get
        {
            PropriedadeAcessada(RO_HORAFINALDIGITACAOPED);
            return _horafinaldigitacaoped;
        }
        set
        {
            PropriedadeModificada(RO_HORAFINALDIGITACAOPED, value);
            _horafinaldigitacaoped = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Horafinalimportacaoped
    {
        get
        {
            PropriedadeAcessada(RO_HORAFINALIMPORTACAOPED);
            return _horafinalimportacaoped;
        }
        set
        {
            PropriedadeModificada(RO_HORAFINALIMPORTACAOPED, value);
            _horafinalimportacaoped = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Horainicialdigitacaoped
    {
        get
        {
            PropriedadeAcessada(RO_HORAINICIALDIGITACAOPED);
            return _horainicialdigitacaoped;
        }
        set
        {
            PropriedadeModificada(RO_HORAINICIALDIGITACAOPED, value);
            _horainicialdigitacaoped = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Horainicialimportacaoped
    {
        get
        {
            PropriedadeAcessada(RO_HORAINICIALIMPORTACAOPED);
            return _horainicialimportacaoped;
        }
        set
        {
            PropriedadeModificada(RO_HORAINICIALIMPORTACAOPED, value);
            _horainicialimportacaoped = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Hrfimalmoco
    {
        get
        {
            PropriedadeAcessada(RO_HRFIMALMOCO);
            return _hrfimalmoco;
        }
        set
        {
            PropriedadeModificada(RO_HRFIMALMOCO, value);
            _hrfimalmoco = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Hrfimexpediente
    {
        get
        {
            PropriedadeAcessada(RO_HRFIMEXPEDIENTE);
            return _hrfimexpediente;
        }
        set
        {
            PropriedadeModificada(RO_HRFIMEXPEDIENTE, value);
            _hrfimexpediente = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Hrinicioalmoco
    {
        get
        {
            PropriedadeAcessada(RO_HRINICIOALMOCO);
            return _hrinicioalmoco;
        }
        set
        {
            PropriedadeModificada(RO_HRINICIOALMOCO, value);
            _hrinicioalmoco = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Hrinicioexpediente
    {
        get
        {
            PropriedadeAcessada(RO_HRINICIOEXPEDIENTE);
            return _hrinicioexpediente;
        }
        set
        {
            PropriedadeModificada(RO_HRINICIOEXPEDIENTE, value);
            _hrinicioexpediente = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 15, Precisao = 0)]
    public string Iesubsttrib
    {
        get
        {
            PropriedadeAcessada(RO_IESUBSTTRIB);
            return _iesubsttrib;
        }
        set
        {
            PropriedadeModificada(RO_IESUBSTTRIB, value);
            _iesubsttrib = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
    public string Ietransp
    {
        get
        {
            PropriedadeAcessada(RO_IETRANSP);
            return _ietransp;
        }
        set
        {
            PropriedadeModificada(RO_IETRANSP, value);
            _ietransp = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
    public string Im
    {
        get
        {
            PropriedadeAcessada(RO_IM);
            return _im;
        }
        set
        {
            PropriedadeModificada(RO_IM, value);
            _im = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Impedetipo14_Livrofiscal
    {
        get
        {
            PropriedadeAcessada(RO_IMPEDETIPO14_LIVROFISCAL);
            return _impedetipo14_livrofiscal;
        }
        set
        {
            PropriedadeModificada(RO_IMPEDETIPO14_LIVROFISCAL, value);
            _impedetipo14_livrofiscal = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Incluifreteoutrasdespbasest
    {
        get
        {
            PropriedadeAcessada(RO_INCLUIFRETEOUTRASDESPBASEST);
            return _incluifreteoutrasdespbasest;
        }
        set
        {
            PropriedadeModificada(RO_INCLUIFRETEOUTRASDESPBASEST, value);
            _incluifreteoutrasdespbasest = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Incluiritempcembalagem
    {
        get
        {
            PropriedadeAcessada(RO_INCLUIRITEMPCEMBALAGEM);
            return _incluiritempcembalagem;
        }
        set
        {
            PropriedadeModificada(RO_INCLUIRITEMPCEMBALAGEM, value);
            _incluiritempcembalagem = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Indicecustotransf
    {
        get
        {
            PropriedadeAcessada(RO_INDICECUSTOTRANSF);
            return _indicecustotransf;
        }
        set
        {
            PropriedadeModificada(RO_INDICECUSTOTRANSF, value);
            _indicecustotransf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Industria
    {
        get
        {
            PropriedadeAcessada(RO_INDUSTRIA);
            return _industria;
        }
        set
        {
            PropriedadeModificada(RO_INDUSTRIA, value);
            _industria = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Informarprofissionalvenda
    {
        get
        {
            PropriedadeAcessada(RO_INFORMARPROFISSIONALVENDA);
            return _informarprofissionalvenda;
        }
        set
        {
            PropriedadeModificada(RO_INFORMARPROFISSIONALVENDA, value);
            _informarprofissionalvenda = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 3, Precisao = 0)]
    public decimal? Integradorawms
    {
        get
        {
            PropriedadeAcessada(RO_INTEGRADORAWMS);
            return _integradorawms;
        }
        set
        {
            PropriedadeModificada(RO_INTEGRADORAWMS, value);
            _integradorawms = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Ipisomentevlcont
    {
        get
        {
            PropriedadeAcessada(RO_IPISOMENTEVLCONT);
            return _ipisomentevlcont;
        }
        set
        {
            PropriedadeModificada(RO_IPISOMENTEVLCONT, value);
            _ipisomentevlcont = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Lancarfretepesoautfat
    {
        get
        {
            PropriedadeAcessada(RO_LANCARFRETEPESOAUTFAT);
            return _lancarfretepesoautfat;
        }
        set
        {
            PropriedadeModificada(RO_LANCARFRETEPESOAUTFAT, value);
            _lancarfretepesoautfat = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Libpedcomprasemdiverg
    {
        get
        {
            PropriedadeAcessada(RO_LIBPEDCOMPRASEMDIVERG);
            return _libpedcomprasemdiverg;
        }
        set
        {
            PropriedadeModificada(RO_LIBPEDCOMPRASEMDIVERG, value);
            _libpedcomprasemdiverg = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Limparbasecalcentrada
    {
        get
        {
            PropriedadeAcessada(RO_LIMPARBASECALCENTRADA);
            return _limparbasecalcentrada;
        }
        set
        {
            PropriedadeModificada(RO_LIMPARBASECALCENTRADA, value);
            _limparbasecalcentrada = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Limriskscoring
    {
        get
        {
            PropriedadeAcessada(RO_LIMRISKSCORING);
            return _limriskscoring;
        }
        set
        {
            PropriedadeModificada(RO_LIMRISKSCORING, value);
            _limriskscoring = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Matriculasngpc
    {
        get
        {
            PropriedadeAcessada(RO_MATRICULASNGPC);
            return _matriculasngpc;
        }
        set
        {
            PropriedadeModificada(RO_MATRICULASNGPC, value);
            _matriculasngpc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Matriculasngpcant
    {
        get
        {
            PropriedadeAcessada(RO_MATRICULASNGPCANT);
            return _matriculasngpcant;
        }
        set
        {
            PropriedadeModificada(RO_MATRICULASNGPCANT, value);
            _matriculasngpcant = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 60, Precisao = 0)]
    public string Mensnf
    {
        get
        {
            PropriedadeAcessada(RO_MENSNF);
            return _mensnf;
        }
        set
        {
            PropriedadeModificada(RO_MENSNF, value);
            _mensnf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 300, Precisao = 0)]
    public string Mensnfimunidadetrib
    {
        get
        {
            PropriedadeAcessada(RO_MENSNFIMUNIDADETRIB);
            return _mensnfimunidadetrib;
        }
        set
        {
            PropriedadeModificada(RO_MENSNFIMUNIDADETRIB, value);
            _mensnfimunidadetrib = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Mixmaximo
    {
        get
        {
            PropriedadeAcessada(RO_MIXMAXIMO);
            return _mixmaximo;
        }
        set
        {
            PropriedadeModificada(RO_MIXMAXIMO, value);
            _mixmaximo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Mixminimo
    {
        get
        {
            PropriedadeAcessada(RO_MIXMINIMO);
            return _mixminimo;
        }
        set
        {
            PropriedadeModificada(RO_MIXMINIMO, value);
            _mixminimo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Montacargawinthor
    {
        get
        {
            PropriedadeAcessada(RO_MONTACARGAWINTHOR);
            return _montacargawinthor;
        }
        set
        {
            PropriedadeModificada(RO_MONTACARGAWINTHOR, value);
            _montacargawinthor = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Montarkitautomaticamente
    {
        get
        {
            PropriedadeAcessada(RO_MONTARKITAUTOMATICAMENTE);
            return _montarkitautomaticamente;
        }
        set
        {
            PropriedadeModificada(RO_MONTARKITAUTOMATICAMENTE, value);
            _montarkitautomaticamente = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Naogerarcreditoentradatransf
    {
        get
        {
            PropriedadeAcessada(RO_NAOGERARCREDITOENTRADATRANSF);
            return _naogerarcreditoentradatransf;
        }
        set
        {
            PropriedadeModificada(RO_NAOGERARCREDITOENTRADATRANSF, value);
            _naogerarcreditoentradatransf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
    public string Nomebancodadoswms
    {
        get
        {
            PropriedadeAcessada(RO_NOMEBANCODADOSWMS);
            return _nomebancodadoswms;
        }
        set
        {
            PropriedadeModificada(RO_NOMEBANCODADOSWMS, value);
            _nomebancodadoswms = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
    public string Nome_Paf
    {
        get
        {
            PropriedadeAcessada(RO_NOME_PAF);
            return _nome_paf;
        }
        set
        {
            PropriedadeModificada(RO_NOME_PAF, value);
            _nome_paf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
    public string Nomepais
    {
        get
        {
            PropriedadeAcessada(RO_NOMEPAIS);
            return _nomepais;
        }
        set
        {
            PropriedadeModificada(RO_NOMEPAIS, value);
            _nomepais = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 150, Precisao = 0)]
    public string Nomeremetente
    {
        get
        {
            PropriedadeAcessada(RO_NOMEREMETENTE);
            return _nomeremetente;
        }
        set
        {
            PropriedadeModificada(RO_NOMEREMETENTE, value);
            _nomeremetente = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 3, Precisao = 0)]
    public decimal? Numdiasmaximoliberarpedido
    {
        get
        {
            PropriedadeAcessada(RO_NUMDIASMAXIMOLIBERARPEDIDO);
            return _numdiasmaximoliberarpedido;
        }
        set
        {
            PropriedadeModificada(RO_NUMDIASMAXIMOLIBERARPEDIDO, value);
            _numdiasmaximoliberarpedido = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Numdiasvencfrete
    {
        get
        {
            PropriedadeAcessada(RO_NUMDIASVENCFRETE);
            return _numdiasvencfrete;
        }
        set
        {
            PropriedadeModificada(RO_NUMDIASVENCFRETE, value);
            _numdiasvencfrete = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Numero
    {
        get
        {
            PropriedadeAcessada(RO_NUMERO);
            return _numero;
        }
        set
        {
            PropriedadeModificada(RO_NUMERO, value);
            _numero = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 6, Precisao = 0)]
    public string Numero2
    {
        get
        {
            PropriedadeAcessada(RO_NUMERO2);
            return _numero2;
        }
        set
        {
            PropriedadeModificada(RO_NUMERO2, value);
            _numero2 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 30, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 30, Precisao = 0)]
    public string Numidfdevcli
    {
        get
        {
            PropriedadeAcessada(RO_NUMIDFDEVCLI);
            return _numidfdevcli;
        }
        set
        {
            PropriedadeModificada(RO_NUMIDFDEVCLI, value);
            _numidfdevcli = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 3, Precisao = 0)]
    public decimal? Nummaxdiasretrodtcompensacao
    {
        get
        {
            PropriedadeAcessada(RO_NUMMAXDIASRETRODTCOMPENSACAO);
            return _nummaxdiasretrodtcompensacao;
        }
        set
        {
            PropriedadeModificada(RO_NUMMAXDIASRETRODTCOMPENSACAO, value);
            _nummaxdiasretrodtcompensacao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Nummaxitensnfe
    {
        get
        {
            PropriedadeAcessada(RO_NUMMAXITENSNFE);
            return _nummaxitensnfe;
        }
        set
        {
            PropriedadeModificada(RO_NUMMAXITENSNFE, value);
            _nummaxitensnfe = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numproxvend
    {
        get
        {
            PropriedadeAcessada(RO_NUMPROXVEND);
            return _numproxvend;
        }
        set
        {
            PropriedadeModificada(RO_NUMPROXVEND, value);
            _numproxvend = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Numregiaobalcaointer
    {
        get
        {
            PropriedadeAcessada(RO_NUMREGIAOBALCAOINTER);
            return _numregiaobalcaointer;
        }
        set
        {
            PropriedadeModificada(RO_NUMREGIAOBALCAOINTER, value);
            _numregiaobalcaointer = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Numregiaopadrao
    {
        get
        {
            PropriedadeAcessada(RO_NUMREGIAOPADRAO);
            return _numregiaopadrao;
        }
        set
        {
            PropriedadeModificada(RO_NUMREGIAOPADRAO, value);
            _numregiaopadrao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Obrigaconsfinaldev
    {
        get
        {
            PropriedadeAcessada(RO_OBRIGACONSFINALDEV);
            return _obrigaconsfinaldev;
        }
        set
        {
            PropriedadeModificada(RO_OBRIGACONSFINALDEV, value);
            _obrigaconsfinaldev = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Operadorlogistico
    {
        get
        {
            PropriedadeAcessada(RO_OPERADORLOGISTICO);
            return _operadorlogistico;
        }
        set
        {
            PropriedadeModificada(RO_OPERADORLOGISTICO, value);
            _operadorlogistico = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Opisentosicmsaltocusto
    {
        get
        {
            PropriedadeAcessada(RO_OPISENTOSICMSALTOCUSTO);
            return _opisentosicmsaltocusto;
        }
        set
        {
            PropriedadeModificada(RO_OPISENTOSICMSALTOCUSTO, value);
            _opisentosicmsaltocusto = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Optantesimplesnac
    {
        get
        {
            PropriedadeAcessada(RO_OPTANTESIMPLESNAC);
            return _optantesimplesnac;
        }
        set
        {
            PropriedadeModificada(RO_OPTANTESIMPLESNAC, value);
            _optantesimplesnac = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 900, Precisao = 0)]
    public string Ordemagrupdesd
    {
        get
        {
            PropriedadeAcessada(RO_ORDEMAGRUPDESD);
            return _ordemagrupdesd;
        }
        set
        {
            PropriedadeModificada(RO_ORDEMAGRUPDESD, value);
            _ordemagrupdesd = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
    public string Orgao
    {
        get
        {
            PropriedadeAcessada(RO_ORGAO);
            return _orgao;
        }
        set
        {
            PropriedadeModificada(RO_ORGAO, value);
            _orgao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Origemcustofilialretira
    {
        get
        {
            PropriedadeAcessada(RO_ORIGEMCUSTOFILIALRETIRA);
            return _origemcustofilialretira;
        }
        set
        {
            PropriedadeModificada(RO_ORIGEMCUSTOFILIALRETIRA, value);
            _origemcustofilialretira = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Origemvendanf
    {
        get
        {
            PropriedadeAcessada(RO_ORIGEMVENDANF);
            return _origemvendanf;
        }
        set
        {
            PropriedadeModificada(RO_ORIGEMVENDANF, value);
            _origemvendanf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Osprodmanutobrig
    {
        get
        {
            PropriedadeAcessada(RO_OSPRODMANUTOBRIG);
            return _osprodmanutobrig;
        }
        set
        {
            PropriedadeModificada(RO_OSPRODMANUTOBRIG, value);
            _osprodmanutobrig = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Perbaseredoutrasdesppf
    {
        get
        {
            PropriedadeAcessada(RO_PERBASEREDOUTRASDESPPF);
            return _perbaseredoutrasdesppf;
        }
        set
        {
            PropriedadeModificada(RO_PERBASEREDOUTRASDESPPF, value);
            _perbaseredoutrasdesppf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 6)]
    public decimal? Percacrescimobalcao
    {
        get
        {
            PropriedadeAcessada(RO_PERCACRESCIMOBALCAO);
            return _percacrescimobalcao;
        }
        set
        {
            PropriedadeModificada(RO_PERCACRESCIMOBALCAO, value);
            _percacrescimobalcao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Percdeclinioabc
    {
        get
        {
            PropriedadeAcessada(RO_PERCDECLINIOABC);
            return _percdeclinioabc;
        }
        set
        {
            PropriedadeModificada(RO_PERCDECLINIOABC, value);
            _percdeclinioabc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 4)]
    public decimal? Percdespadm
    {
        get
        {
            PropriedadeAcessada(RO_PERCDESPADM);
            return _percdespadm;
        }
        set
        {
            PropriedadeModificada(RO_PERCDESPADM, value);
            _percdespadm = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Percevolucaoabc
    {
        get
        {
            PropriedadeAcessada(RO_PERCEVOLUCAOABC);
            return _percevolucaoabc;
        }
        set
        {
            PropriedadeModificada(RO_PERCEVOLUCAOABC, value);
            _percevolucaoabc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 2)]
    public decimal? Percicmssimplesnac
    {
        get
        {
            PropriedadeAcessada(RO_PERCICMSSIMPLESNAC);
            return _percicmssimplesnac;
        }
        set
        {
            PropriedadeModificada(RO_PERCICMSSIMPLESNAC, value);
            _percicmssimplesnac = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Percmaxdifprodsimil
    {
        get
        {
            PropriedadeAcessada(RO_PERCMAXDIFPRODSIMIL);
            return _percmaxdifprodsimil;
        }
        set
        {
            PropriedadeModificada(RO_PERCMAXDIFPRODSIMIL, value);
            _percmaxdifprodsimil = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 2)]
    public decimal? Percommotbroker
    {
        get
        {
            PropriedadeAcessada(RO_PERCOMMOTBROKER);
            return _percommotbroker;
        }
        set
        {
            PropriedadeModificada(RO_PERCOMMOTBROKER, value);
            _percommotbroker = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 2)]
    public decimal? Percomrcabroker
    {
        get
        {
            PropriedadeAcessada(RO_PERCOMRCABROKER);
            return _percomrcabroker;
        }
        set
        {
            PropriedadeModificada(RO_PERCOMRCABROKER, value);
            _percomrcabroker = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 2)]
    public decimal? Percparticipaclassea
    {
        get
        {
            PropriedadeAcessada(RO_PERCPARTICIPACLASSEA);
            return _percparticipaclassea;
        }
        set
        {
            PropriedadeModificada(RO_PERCPARTICIPACLASSEA, value);
            _percparticipaclassea = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 2)]
    public decimal? Percparticipaclasseb
    {
        get
        {
            PropriedadeAcessada(RO_PERCPARTICIPACLASSEB);
            return _percparticipaclasseb;
        }
        set
        {
            PropriedadeModificada(RO_PERCPARTICIPACLASSEB, value);
            _percparticipaclasseb = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 2)]
    public decimal? Percparticipasubclassea1
    {
        get
        {
            PropriedadeAcessada(RO_PERCPARTICIPASUBCLASSEA1);
            return _percparticipasubclassea1;
        }
        set
        {
            PropriedadeModificada(RO_PERCPARTICIPASUBCLASSEA1, value);
            _percparticipasubclassea1 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 2)]
    public decimal? Percparticipasubclassea2
    {
        get
        {
            PropriedadeAcessada(RO_PERCPARTICIPASUBCLASSEA2);
            return _percparticipasubclassea2;
        }
        set
        {
            PropriedadeModificada(RO_PERCPARTICIPASUBCLASSEA2, value);
            _percparticipasubclassea2 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 2)]
    public decimal? Percparticipasubclassea3
    {
        get
        {
            PropriedadeAcessada(RO_PERCPARTICIPASUBCLASSEA3);
            return _percparticipasubclassea3;
        }
        set
        {
            PropriedadeModificada(RO_PERCPARTICIPASUBCLASSEA3, value);
            _percparticipasubclassea3 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 2)]
    public decimal? Percparticipasubclasseb1
    {
        get
        {
            PropriedadeAcessada(RO_PERCPARTICIPASUBCLASSEB1);
            return _percparticipasubclasseb1;
        }
        set
        {
            PropriedadeModificada(RO_PERCPARTICIPASUBCLASSEB1, value);
            _percparticipasubclasseb1 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 2)]
    public decimal? Percparticipasubclasseb2
    {
        get
        {
            PropriedadeAcessada(RO_PERCPARTICIPASUBCLASSEB2);
            return _percparticipasubclasseb2;
        }
        set
        {
            PropriedadeModificada(RO_PERCPARTICIPASUBCLASSEB2, value);
            _percparticipasubclasseb2 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 2)]
    public decimal? Percparticipasubclasseb3
    {
        get
        {
            PropriedadeAcessada(RO_PERCPARTICIPASUBCLASSEB3);
            return _percparticipasubclasseb3;
        }
        set
        {
            PropriedadeModificada(RO_PERCPARTICIPASUBCLASSEB3, value);
            _percparticipasubclasseb3 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 2)]
    public decimal? Percparticipasubclassec1
    {
        get
        {
            PropriedadeAcessada(RO_PERCPARTICIPASUBCLASSEC1);
            return _percparticipasubclassec1;
        }
        set
        {
            PropriedadeModificada(RO_PERCPARTICIPASUBCLASSEC1, value);
            _percparticipasubclassec1 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 2)]
    public decimal? Percparticipasubclassec2
    {
        get
        {
            PropriedadeAcessada(RO_PERCPARTICIPASUBCLASSEC2);
            return _percparticipasubclassec2;
        }
        set
        {
            PropriedadeModificada(RO_PERCPARTICIPASUBCLASSEC2, value);
            _percparticipasubclassec2 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Perfreteconhec
    {
        get
        {
            PropriedadeAcessada(RO_PERFRETECONHEC);
            return _perfreteconhec;
        }
        set
        {
            PropriedadeModificada(RO_PERFRETECONHEC, value);
            _perfreteconhec = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Perlimvendapf
    {
        get
        {
            PropriedadeAcessada(RO_PERLIMVENDAPF);
            return _perlimvendapf;
        }
        set
        {
            PropriedadeModificada(RO_PERLIMVENDAPF, value);
            _perlimvendapf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Permiteagruparboletos
    {
        get
        {
            PropriedadeAcessada(RO_PERMITEAGRUPARBOLETOS);
            return _permiteagruparboletos;
        }
        set
        {
            PropriedadeModificada(RO_PERMITEAGRUPARBOLETOS, value);
            _permiteagruparboletos = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Permitecancelarnfentwms
    {
        get
        {
            PropriedadeAcessada(RO_PERMITECANCELARNFENTWMS);
            return _permitecancelarnfentwms;
        }
        set
        {
            PropriedadeModificada(RO_PERMITECANCELARNFENTWMS, value);
            _permitecancelarnfentwms = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Permitecredicmcomst
    {
        get
        {
            PropriedadeAcessada(RO_PERMITECREDICMCOMST);
            return _permitecredicmcomst;
        }
        set
        {
            PropriedadeModificada(RO_PERMITECREDICMCOMST, value);
            _permitecredicmcomst = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Permitefaturar
    {
        get
        {
            PropriedadeAcessada(RO_PERMITEFATURAR);
            return _permitefaturar;
        }
        set
        {
            PropriedadeModificada(RO_PERMITEFATURAR, value);
            _permitefaturar = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Permitirdesddifprof
    {
        get
        {
            PropriedadeAcessada(RO_PERMITIRDESDDIFPROF);
            return _permitirdesddifprof;
        }
        set
        {
            PropriedadeModificada(RO_PERMITIRDESDDIFPROF, value);
            _permitirdesddifprof = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Permitirvendaestadualpfcomie
    {
        get
        {
            PropriedadeAcessada(RO_PERMITIRVENDAESTADUALPFCOMIE);
            return _permitirvendaestadualpfcomie;
        }
        set
        {
            PropriedadeModificada(RO_PERMITIRVENDAESTADUALPFCOMIE, value);
            _permitirvendaestadualpfcomie = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Permitirvendaestadualpfsemie
    {
        get
        {
            PropriedadeAcessada(RO_PERMITIRVENDAESTADUALPFSEMIE);
            return _permitirvendaestadualpfsemie;
        }
        set
        {
            PropriedadeModificada(RO_PERMITIRVENDAESTADUALPFSEMIE, value);
            _permitirvendaestadualpfsemie = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Permitirvendainterestadualpf
    {
        get
        {
            PropriedadeAcessada(RO_PERMITIRVENDAINTERESTADUALPF);
            return _permitirvendainterestadualpf;
        }
        set
        {
            PropriedadeModificada(RO_PERMITIRVENDAINTERESTADUALPF, value);
            _permitirvendainterestadualpf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Pervendapf
    {
        get
        {
            PropriedadeAcessada(RO_PERVENDAPF);
            return _pervendapf;
        }
        set
        {
            PropriedadeModificada(RO_PERVENDAPF, value);
            _pervendapf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 2)]
    public decimal? Pesolimiteos
    {
        get
        {
            PropriedadeAcessada(RO_PESOLIMITEOS);
            return _pesolimiteos;
        }
        set
        {
            PropriedadeModificada(RO_PESOLIMITEOS, value);
            _pesolimiteos = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Pondcusnotatransf
    {
        get
        {
            PropriedadeAcessada(RO_PONDCUSNOTATRANSF);
            return _pondcusnotatransf;
        }
        set
        {
            PropriedadeModificada(RO_PONDCUSNOTATRANSF, value);
            _pondcusnotatransf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 0)]
    public decimal? Portaproxy
    {
        get
        {
            PropriedadeAcessada(RO_PORTAPROXY);
            return _portaproxy;
        }
        set
        {
            PropriedadeModificada(RO_PORTAPROXY, value);
            _portaproxy = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 0)]
    public decimal? Portaserv
    {
        get
        {
            PropriedadeAcessada(RO_PORTASERV);
            return _portaserv;
        }
        set
        {
            PropriedadeModificada(RO_PORTASERV, value);
            _portaserv = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Prazomaximppedpendecf
    {
        get
        {
            PropriedadeAcessada(RO_PRAZOMAXIMPPEDPENDECF);
            return _prazomaximppedpendecf;
        }
        set
        {
            PropriedadeModificada(RO_PRAZOMAXIMPPEDPENDECF, value);
            _prazomaximppedpendecf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Precificaautomatico
    {
        get
        {
            PropriedadeAcessada(RO_PRECIFICAAUTOMATICO);
            return _precificaautomatico;
        }
        set
        {
            PropriedadeModificada(RO_PRECIFICAAUTOMATICO, value);
            _precificaautomatico = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Precoporembalagem
    {
        get
        {
            PropriedadeAcessada(RO_PRECOPOREMBALAGEM);
            return _precoporembalagem;
        }
        set
        {
            PropriedadeModificada(RO_PRECOPOREMBALAGEM, value);
            _precoporembalagem = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Prodporetapa
    {
        get
        {
            PropriedadeAcessada(RO_PRODPORETAPA);
            return _prodporetapa;
        }
        set
        {
            PropriedadeModificada(RO_PRODPORETAPA, value);
            _prodporetapa = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Proxnsu
    {
        get
        {
            PropriedadeAcessada(RO_PROXNSU);
            return _proxnsu;
        }
        set
        {
            PropriedadeModificada(RO_PROXNSU, value);
            _proxnsu = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Proxnumaverbacao
    {
        get
        {
            PropriedadeAcessada(RO_PROXNUMAVERBACAO);
            return _proxnumaverbacao;
        }
        set
        {
            PropriedadeModificada(RO_PROXNUMAVERBACAO, value);
            _proxnumaverbacao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Proxnumcarecf
    {
        get
        {
            PropriedadeAcessada(RO_PROXNUMCARECF);
            return _proxnumcarecf;
        }
        set
        {
            PropriedadeModificada(RO_PROXNUMCARECF, value);
            _proxnumcarecf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Proxnumconhec
    {
        get
        {
            PropriedadeAcessada(RO_PROXNUMCONHEC);
            return _proxnumconhec;
        }
        set
        {
            PropriedadeModificada(RO_PROXNUMCONHEC, value);
            _proxnumconhec = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Proxnumcte
    {
        get
        {
            PropriedadeAcessada(RO_PROXNUMCTE);
            return _proxnumcte;
        }
        set
        {
            PropriedadeModificada(RO_PROXNUMCTE, value);
            _proxnumcte = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Proxnumentmex
    {
        get
        {
            PropriedadeAcessada(RO_PROXNUMENTMEX);
            return _proxnumentmex;
        }
        set
        {
            PropriedadeModificada(RO_PROXNUMENTMEX, value);
            _proxnumentmex = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Proxnumeroorcamento
    {
        get
        {
            PropriedadeAcessada(RO_PROXNUMEROORCAMENTO);
            return _proxnumeroorcamento;
        }
        set
        {
            PropriedadeModificada(RO_PROXNUMEROORCAMENTO, value);
            _proxnumeroorcamento = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Proxnumetapa
    {
        get
        {
            PropriedadeAcessada(RO_PROXNUMETAPA);
            return _proxnumetapa;
        }
        set
        {
            PropriedadeModificada(RO_PROXNUMETAPA, value);
            _proxnumetapa = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Proxnumlote
    {
        get
        {
            PropriedadeAcessada(RO_PROXNUMLOTE);
            return _proxnumlote;
        }
        set
        {
            PropriedadeModificada(RO_PROXNUMLOTE, value);
            _proxnumlote = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Proxnumnfdevcli
    {
        get
        {
            PropriedadeAcessada(RO_PROXNUMNFDEVCLI);
            return _proxnumnfdevcli;
        }
        set
        {
            PropriedadeModificada(RO_PROXNUMNFDEVCLI, value);
            _proxnumnfdevcli = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Proxnumnfe
    {
        get
        {
            PropriedadeAcessada(RO_PROXNUMNFE);
            return _proxnumnfe;
        }
        set
        {
            PropriedadeModificada(RO_PROXNUMNFE, value);
            _proxnumnfe = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 9, Precisao = 0)]
    public decimal? Proxnumnfedevmanisfesto
    {
        get
        {
            PropriedadeAcessada(RO_PROXNUMNFEDEVMANISFESTO);
            return _proxnumnfedevmanisfesto;
        }
        set
        {
            PropriedadeModificada(RO_PROXNUMNFEDEVMANISFESTO, value);
            _proxnumnfedevmanisfesto = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 9, Precisao = 0)]
    public decimal? Proxnumnfedevmanisfestoscan
    {
        get
        {
            PropriedadeAcessada(RO_PROXNUMNFEDEVMANISFESTOSCAN);
            return _proxnumnfedevmanisfestoscan;
        }
        set
        {
            PropriedadeModificada(RO_PROXNUMNFEDEVMANISFESTOSCAN, value);
            _proxnumnfedevmanisfestoscan = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 9, Precisao = 0)]
    public decimal? Proxnumnfeentrada
    {
        get
        {
            PropriedadeAcessada(RO_PROXNUMNFEENTRADA);
            return _proxnumnfeentrada;
        }
        set
        {
            PropriedadeModificada(RO_PROXNUMNFEENTRADA, value);
            _proxnumnfeentrada = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 9, Precisao = 0)]
    public decimal? Proxnumnfeimportacao
    {
        get
        {
            PropriedadeAcessada(RO_PROXNUMNFEIMPORTACAO);
            return _proxnumnfeimportacao;
        }
        set
        {
            PropriedadeModificada(RO_PROXNUMNFEIMPORTACAO, value);
            _proxnumnfeimportacao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 9, Precisao = 0)]
    public decimal? Proxnumnferemmanisfesto
    {
        get
        {
            PropriedadeAcessada(RO_PROXNUMNFEREMMANISFESTO);
            return _proxnumnferemmanisfesto;
        }
        set
        {
            PropriedadeModificada(RO_PROXNUMNFEREMMANISFESTO, value);
            _proxnumnferemmanisfesto = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 9, Precisao = 0)]
    public decimal? Proxnumnferemmanisfestoscan
    {
        get
        {
            PropriedadeAcessada(RO_PROXNUMNFEREMMANISFESTOSCAN);
            return _proxnumnferemmanisfestoscan;
        }
        set
        {
            PropriedadeModificada(RO_PROXNUMNFEREMMANISFESTOSCAN, value);
            _proxnumnferemmanisfestoscan = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 9, Precisao = 0)]
    public decimal? Proxnumnfescan
    {
        get
        {
            PropriedadeAcessada(RO_PROXNUMNFESCAN);
            return _proxnumnfescan;
        }
        set
        {
            PropriedadeModificada(RO_PROXNUMNFESCAN, value);
            _proxnumnfescan = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 9, Precisao = 0)]
    public decimal? Proxnumnfescanentrada
    {
        get
        {
            PropriedadeAcessada(RO_PROXNUMNFESCANENTRADA);
            return _proxnumnfescanentrada;
        }
        set
        {
            PropriedadeModificada(RO_PROXNUMNFESCANENTRADA, value);
            _proxnumnfescanentrada = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 9, Precisao = 0)]
    public decimal? Proxnumnfescanimportacao
    {
        get
        {
            PropriedadeAcessada(RO_PROXNUMNFESCANIMPORTACAO);
            return _proxnumnfescanimportacao;
        }
        set
        {
            PropriedadeModificada(RO_PROXNUMNFESCANIMPORTACAO, value);
            _proxnumnfescanimportacao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Proxnumnfs
    {
        get
        {
            PropriedadeAcessada(RO_PROXNUMNFS);
            return _proxnumnfs;
        }
        set
        {
            PropriedadeModificada(RO_PROXNUMNFS, value);
            _proxnumnfs = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Proxnumnota
    {
        get
        {
            PropriedadeAcessada(RO_PROXNUMNOTA);
            return _proxnumnota;
        }
        set
        {
            PropriedadeModificada(RO_PROXNUMNOTA, value);
            _proxnumnota = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Proxnumnotacobranca
    {
        get
        {
            PropriedadeAcessada(RO_PROXNUMNOTACOBRANCA);
            return _proxnumnotacobranca;
        }
        set
        {
            PropriedadeModificada(RO_PROXNUMNOTACOBRANCA, value);
            _proxnumnotacobranca = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Proxnumnotad
    {
        get
        {
            PropriedadeAcessada(RO_PROXNUMNOTAD);
            return _proxnumnotad;
        }
        set
        {
            PropriedadeModificada(RO_PROXNUMNOTAD, value);
            _proxnumnotad = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Proxnumnotaecf
    {
        get
        {
            PropriedadeAcessada(RO_PROXNUMNOTAECF);
            return _proxnumnotaecf;
        }
        set
        {
            PropriedadeModificada(RO_PROXNUMNOTAECF, value);
            _proxnumnotaecf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Proxnumnotaorigvenda
    {
        get
        {
            PropriedadeAcessada(RO_PROXNUMNOTAORIGVENDA);
            return _proxnumnotaorigvenda;
        }
        set
        {
            PropriedadeModificada(RO_PROXNUMNOTAORIGVENDA, value);
            _proxnumnotaorigvenda = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Proxnumnotatransf
    {
        get
        {
            PropriedadeAcessada(RO_PROXNUMNOTATRANSF);
            return _proxnumnotatransf;
        }
        set
        {
            PropriedadeModificada(RO_PROXNUMNOTATRANSF, value);
            _proxnumnotatransf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Proxnumorc
    {
        get
        {
            PropriedadeAcessada(RO_PROXNUMORC);
            return _proxnumorc;
        }
        set
        {
            PropriedadeModificada(RO_PROXNUMORC, value);
            _proxnumorc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Proxnumorcafilial
    {
        get
        {
            PropriedadeAcessada(RO_PROXNUMORCAFILIAL);
            return _proxnumorcafilial;
        }
        set
        {
            PropriedadeModificada(RO_PROXNUMORCAFILIAL, value);
            _proxnumorcafilial = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 15, Precisao = 0)]
    public decimal? Proxnumos
    {
        get
        {
            PropriedadeAcessada(RO_PROXNUMOS);
            return _proxnumos;
        }
        set
        {
            PropriedadeModificada(RO_PROXNUMOS, value);
            _proxnumos = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Proxnumprevenda
    {
        get
        {
            PropriedadeAcessada(RO_PROXNUMPREVENDA);
            return _proxnumprevenda;
        }
        set
        {
            PropriedadeModificada(RO_PROXNUMPREVENDA, value);
            _proxnumprevenda = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Proxnumtransconhec
    {
        get
        {
            PropriedadeAcessada(RO_PROXNUMTRANSCONHEC);
            return _proxnumtransconhec;
        }
        set
        {
            PropriedadeModificada(RO_PROXNUMTRANSCONHEC, value);
            _proxnumtransconhec = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Proxnumtransecf
    {
        get
        {
            PropriedadeAcessada(RO_PROXNUMTRANSECF);
            return _proxnumtransecf;
        }
        set
        {
            PropriedadeModificada(RO_PROXNUMTRANSECF, value);
            _proxnumtransecf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Proxnumtransvendaecf
    {
        get
        {
            PropriedadeAcessada(RO_PROXNUMTRANSVENDAECF);
            return _proxnumtransvendaecf;
        }
        set
        {
            PropriedadeModificada(RO_PROXNUMTRANSVENDAECF, value);
            _proxnumtransvendaecf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Qtdemaxdiasvencverbas
    {
        get
        {
            PropriedadeAcessada(RO_QTDEMAXDIASVENCVERBAS);
            return _qtdemaxdiasvencverbas;
        }
        set
        {
            PropriedadeModificada(RO_QTDEMAXDIASVENCVERBAS, value);
            _qtdemaxdiasvencverbas = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Qtdmaxitensos
    {
        get
        {
            PropriedadeAcessada(RO_QTDMAXITENSOS);
            return _qtdmaxitensos;
        }
        set
        {
            PropriedadeModificada(RO_QTDMAXITENSOS, value);
            _qtdmaxitensos = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 2)]
    public decimal? Qtdminitensmoduloos
    {
        get
        {
            PropriedadeAcessada(RO_QTDMINITENSMODULOOS);
            return _qtdminitensmoduloos;
        }
        set
        {
            PropriedadeModificada(RO_QTDMINITENSMODULOOS, value);
            _qtdminitensmoduloos = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Qtmaxpedido
    {
        get
        {
            PropriedadeAcessada(RO_QTMAXPEDIDO);
            return _qtmaxpedido;
        }
        set
        {
            PropriedadeModificada(RO_QTMAXPEDIDO, value);
            _qtmaxpedido = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 2, Precisao = 0)]
    public decimal? Qtmultiplainicialecf
    {
        get
        {
            PropriedadeAcessada(RO_QTMULTIPLAINICIALECF);
            return _qtmultiplainicialecf;
        }
        set
        {
            PropriedadeModificada(RO_QTMULTIPLAINICIALECF, value);
            _qtmultiplainicialecf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
    public string Razaosocial
    {
        get
        {
            PropriedadeAcessada(RO_RAZAOSOCIAL);
            return _razaosocial;
        }
        set
        {
            PropriedadeModificada(RO_RAZAOSOCIAL, value);
            _razaosocial = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
    public string Razaotransp
    {
        get
        {
            PropriedadeAcessada(RO_RAZAOTRANSP);
            return _razaotransp;
        }
        set
        {
            PropriedadeModificada(RO_RAZAOTRANSP, value);
            _razaotransp = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Recalcdvproduto
    {
        get
        {
            PropriedadeAcessada(RO_RECALCDVPRODUTO);
            return _recalcdvproduto;
        }
        set
        {
            PropriedadeModificada(RO_RECALCDVPRODUTO, value);
            _recalcdvproduto = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Reduziricmspropriotransf
    {
        get
        {
            PropriedadeAcessada(RO_REDUZIRICMSPROPRIOTRANSF);
            return _reduziricmspropriotransf;
        }
        set
        {
            PropriedadeModificada(RO_REDUZIRICMSPROPRIOTRANSF, value);
            _reduziricmspropriotransf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Regraarredondamentoecf
    {
        get
        {
            PropriedadeAcessada(RO_REGRAARREDONDAMENTOECF);
            return _regraarredondamentoecf;
        }
        set
        {
            PropriedadeModificada(RO_REGRAARREDONDAMENTOECF, value);
            _regraarredondamentoecf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Retirardescnabaixa
    {
        get
        {
            PropriedadeAcessada(RO_RETIRARDESCNABAIXA);
            return _retirardescnabaixa;
        }
        set
        {
            PropriedadeModificada(RO_RETIRARDESCNABAIXA, value);
            _retirardescnabaixa = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 48, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
    public string Senhabancodadoswms
    {
        get
        {
            PropriedadeAcessada(RO_SENHABANCODADOSWMS);
            return _senhabancodadoswms;
        }
        set
        {
            PropriedadeModificada(RO_SENHABANCODADOSWMS, value);
            _senhabancodadoswms = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 10, Precisao = 0)]
    public string Senhaproxy
    {
        get
        {
            PropriedadeAcessada(RO_SENHAPROXY);
            return _senhaproxy;
        }
        set
        {
            PropriedadeModificada(RO_SENHAPROXY, value);
            _senhaproxy = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 10, Precisao = 0)]
    public string Senhaserv
    {
        get
        {
            PropriedadeAcessada(RO_SENHASERV);
            return _senhaserv;
        }
        set
        {
            PropriedadeModificada(RO_SENHASERV, value);
            _senhaserv = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 3, Precisao = 0)]
    public string Seriecte
    {
        get
        {
            PropriedadeAcessada(RO_SERIECTE);
            return _seriecte;
        }
        set
        {
            PropriedadeModificada(RO_SERIECTE, value);
            _seriecte = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 3, Precisao = 0)]
    public string Serienfe
    {
        get
        {
            PropriedadeAcessada(RO_SERIENFE);
            return _serienfe;
        }
        set
        {
            PropriedadeModificada(RO_SERIENFE, value);
            _serienfe = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 3, Precisao = 0)]
    public string Serienfedevmanifesto
    {
        get
        {
            PropriedadeAcessada(RO_SERIENFEDEVMANIFESTO);
            return _serienfedevmanifesto;
        }
        set
        {
            PropriedadeModificada(RO_SERIENFEDEVMANIFESTO, value);
            _serienfedevmanifesto = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 3, Precisao = 0)]
    public string Serienfedevmanifestoscan
    {
        get
        {
            PropriedadeAcessada(RO_SERIENFEDEVMANIFESTOSCAN);
            return _serienfedevmanifestoscan;
        }
        set
        {
            PropriedadeModificada(RO_SERIENFEDEVMANIFESTOSCAN, value);
            _serienfedevmanifestoscan = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 3, Precisao = 0)]
    public string Serienfeentrada
    {
        get
        {
            PropriedadeAcessada(RO_SERIENFEENTRADA);
            return _serienfeentrada;
        }
        set
        {
            PropriedadeModificada(RO_SERIENFEENTRADA, value);
            _serienfeentrada = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 3, Precisao = 0)]
    public string Serienfeimportacao
    {
        get
        {
            PropriedadeAcessada(RO_SERIENFEIMPORTACAO);
            return _serienfeimportacao;
        }
        set
        {
            PropriedadeModificada(RO_SERIENFEIMPORTACAO, value);
            _serienfeimportacao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 3, Precisao = 0)]
    public string Serienferemmanisfesto
    {
        get
        {
            PropriedadeAcessada(RO_SERIENFEREMMANISFESTO);
            return _serienferemmanisfesto;
        }
        set
        {
            PropriedadeModificada(RO_SERIENFEREMMANISFESTO, value);
            _serienferemmanisfesto = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 3, Precisao = 0)]
    public string Serienferemmanisfestoscan
    {
        get
        {
            PropriedadeAcessada(RO_SERIENFEREMMANISFESTOSCAN);
            return _serienferemmanisfestoscan;
        }
        set
        {
            PropriedadeModificada(RO_SERIENFEREMMANISFESTOSCAN, value);
            _serienferemmanisfestoscan = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 3, Precisao = 0)]
    public string Serienfescan
    {
        get
        {
            PropriedadeAcessada(RO_SERIENFESCAN);
            return _serienfescan;
        }
        set
        {
            PropriedadeModificada(RO_SERIENFESCAN, value);
            _serienfescan = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 3, Precisao = 0)]
    public string Serienfescanentrada
    {
        get
        {
            PropriedadeAcessada(RO_SERIENFESCANENTRADA);
            return _serienfescanentrada;
        }
        set
        {
            PropriedadeModificada(RO_SERIENFESCANENTRADA, value);
            _serienfescanentrada = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 3, Precisao = 0)]
    public string Serienfescanimportacao
    {
        get
        {
            PropriedadeAcessada(RO_SERIENFESCANIMPORTACAO);
            return _serienfescanimportacao;
        }
        set
        {
            PropriedadeModificada(RO_SERIENFESCANIMPORTACAO, value);
            _serienfescanimportacao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 3, Precisao = 0)]
    public string Serienfs
    {
        get
        {
            PropriedadeAcessada(RO_SERIENFS);
            return _serienfs;
        }
        set
        {
            PropriedadeModificada(RO_SERIENFS, value);
            _serienfs = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 150, Precisao = 0)]
    public string Servidorsmtp
    {
        get
        {
            PropriedadeAcessada(RO_SERVIDORSMTP);
            return _servidorsmtp;
        }
        set
        {
            PropriedadeModificada(RO_SERVIDORSMTP, value);
            _servidorsmtp = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Sittributopcionalnfimportacao
    {
        get
        {
            PropriedadeAcessada(RO_SITTRIBUTOPCIONALNFIMPORTACAO);
            return _sittributopcionalnfimportacao;
        }
        set
        {
            PropriedadeModificada(RO_SITTRIBUTOPCIONALNFIMPORTACAO, value);
            _sittributopcionalnfimportacao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Somaicmstransf
    {
        get
        {
            PropriedadeAcessada(RO_SOMAICMSTRANSF);
            return _somaicmstransf;
        }
        set
        {
            PropriedadeModificada(RO_SOMAICMSTRANSF, value);
            _somaicmstransf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Somatarifabancduplic
    {
        get
        {
            PropriedadeAcessada(RO_SOMATARIFABANCDUPLIC);
            return _somatarifabancduplic;
        }
        set
        {
            PropriedadeModificada(RO_SOMATARIFABANCDUPLIC, value);
            _somatarifabancduplic = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Stsomentevlcont
    {
        get
        {
            PropriedadeAcessada(RO_STSOMENTEVLCONT);
            return _stsomentevlcont;
        }
        set
        {
            PropriedadeModificada(RO_STSOMENTEVLCONT, value);
            _stsomentevlcont = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Taxa0
    {
        get
        {
            PropriedadeAcessada(RO_TAXA0);
            return _taxa0;
        }
        set
        {
            PropriedadeModificada(RO_TAXA0, value);
            _taxa0 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Taxa14
    {
        get
        {
            PropriedadeAcessada(RO_TAXA14);
            return _taxa14;
        }
        set
        {
            PropriedadeModificada(RO_TAXA14, value);
            _taxa14 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Taxa21
    {
        get
        {
            PropriedadeAcessada(RO_TAXA21);
            return _taxa21;
        }
        set
        {
            PropriedadeModificada(RO_TAXA21, value);
            _taxa21 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Taxa28
    {
        get
        {
            PropriedadeAcessada(RO_TAXA28);
            return _taxa28;
        }
        set
        {
            PropriedadeModificada(RO_TAXA28, value);
            _taxa28 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Taxa35
    {
        get
        {
            PropriedadeAcessada(RO_TAXA35);
            return _taxa35;
        }
        set
        {
            PropriedadeModificada(RO_TAXA35, value);
            _taxa35 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Taxa42
    {
        get
        {
            PropriedadeAcessada(RO_TAXA42);
            return _taxa42;
        }
        set
        {
            PropriedadeModificada(RO_TAXA42, value);
            _taxa42 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Taxa7
    {
        get
        {
            PropriedadeAcessada(RO_TAXA7);
            return _taxa7;
        }
        set
        {
            PropriedadeModificada(RO_TAXA7, value);
            _taxa7 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 18, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Temposepcaixaos
    {
        get
        {
            PropriedadeAcessada(RO_TEMPOSEPCAIXAOS);
            return _temposepcaixaos;
        }
        set
        {
            PropriedadeModificada(RO_TEMPOSEPCAIXAOS, value);
            _temposepcaixaos = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Temposepinicialos
    {
        get
        {
            PropriedadeAcessada(RO_TEMPOSEPINICIALOS);
            return _temposepinicialos;
        }
        set
        {
            PropriedadeModificada(RO_TEMPOSEPINICIALOS, value);
            _temposepinicialos = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Temposepprodos
    {
        get
        {
            PropriedadeAcessada(RO_TEMPOSEPPRODOS);
            return _temposepprodos;
        }
        set
        {
            PropriedadeModificada(RO_TEMPOSEPPRODOS, value);
            _temposepprodos = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 2, Precisao = 0)]
    public decimal? Tipoavaliacaocomissao
    {
        get
        {
            PropriedadeAcessada(RO_TIPOAVALIACAOCOMISSAO);
            return _tipoavaliacaocomissao;
        }
        set
        {
            PropriedadeModificada(RO_TIPOAVALIACAOCOMISSAO, value);
            _tipoavaliacaocomissao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 3, Precisao = 0)]
    public string Tipobroker
    {
        get
        {
            PropriedadeAcessada(RO_TIPOBROKER);
            return _tipobroker;
        }
        set
        {
            PropriedadeModificada(RO_TIPOBROKER, value);
            _tipobroker = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Tipocnpj
    {
        get
        {
            PropriedadeAcessada(RO_TIPOCNPJ);
            return _tipocnpj;
        }
        set
        {
            PropriedadeModificada(RO_TIPOCNPJ, value);
            _tipocnpj = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Tipodanfe
    {
        get
        {
            PropriedadeAcessada(RO_TIPODANFE);
            return _tipodanfe;
        }
        set
        {
            PropriedadeModificada(RO_TIPODANFE, value);
            _tipodanfe = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Tipoexportacao
    {
        get
        {
            PropriedadeAcessada(RO_TIPOEXPORTACAO);
            return _tipoexportacao;
        }
        set
        {
            PropriedadeModificada(RO_TIPOEXPORTACAO, value);
            _tipoexportacao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Tipofilial
    {
        get
        {
            PropriedadeAcessada(RO_TIPOFILIAL);
            return _tipofilial;
        }
        set
        {
            PropriedadeModificada(RO_TIPOFILIAL, value);
            _tipofilial = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Tipofreteauto
    {
        get
        {
            PropriedadeAcessada(RO_TIPOFRETEAUTO);
            return _tipofreteauto;
        }
        set
        {
            PropriedadeModificada(RO_TIPOFRETEAUTO, value);
            _tipofreteauto = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Tipoidentificacaoecf
    {
        get
        {
            PropriedadeAcessada(RO_TIPOIDENTIFICACAOECF);
            return _tipoidentificacaoecf;
        }
        set
        {
            PropriedadeModificada(RO_TIPOIDENTIFICACAOECF, value);
            _tipoidentificacaoecf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Tipomontagem
    {
        get
        {
            PropriedadeAcessada(RO_TIPOMONTAGEM);
            return _tipomontagem;
        }
        set
        {
            PropriedadeModificada(RO_TIPOMONTAGEM, value);
            _tipomontagem = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Tiponummapa
    {
        get
        {
            PropriedadeAcessada(RO_TIPONUMMAPA);
            return _tiponummapa;
        }
        set
        {
            PropriedadeModificada(RO_TIPONUMMAPA, value);
            _tiponummapa = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Tiponumnfentrada
    {
        get
        {
            PropriedadeAcessada(RO_TIPONUMNFENTRADA);
            return _tiponumnfentrada;
        }
        set
        {
            PropriedadeModificada(RO_TIPONUMNFENTRADA, value);
            _tiponumnfentrada = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Tipoprecificacao
    {
        get
        {
            PropriedadeAcessada(RO_TIPOPRECIFICACAO);
            return _tipoprecificacao;
        }
        set
        {
            PropriedadeModificada(RO_TIPOPRECIFICACAO, value);
            _tipoprecificacao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Transferevlstbasestnatransf
    {
        get
        {
            PropriedadeAcessada(RO_TRANSFEREVLSTBASESTNATRANSF);
            return _transferevlstbasestnatransf;
        }
        set
        {
            PropriedadeModificada(RO_TRANSFEREVLSTBASESTNATRANSF, value);
            _transferevlstbasestnatransf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Uftransp
    {
        get
        {
            PropriedadeAcessada(RO_UFTRANSP);
            return _uftransp;
        }
        set
        {
            PropriedadeModificada(RO_UFTRANSP, value);
            _uftransp = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Usabrindeecf
    {
        get
        {
            PropriedadeAcessada(RO_USABRINDEECF);
            return _usabrindeecf;
        }
        set
        {
            PropriedadeModificada(RO_USABRINDEECF, value);
            _usabrindeecf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Usacodbarraembalagem
    {
        get
        {
            PropriedadeAcessada(RO_USACODBARRAEMBALAGEM);
            return _usacodbarraembalagem;
        }
        set
        {
            PropriedadeModificada(RO_USACODBARRAEMBALAGEM, value);
            _usacodbarraembalagem = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Usacodclivenda
    {
        get
        {
            PropriedadeAcessada(RO_USACODCLIVENDA);
            return _usacodclivenda;
        }
        set
        {
            PropriedadeModificada(RO_USACODCLIVENDA, value);
            _usacodclivenda = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Usaconsultacheque
    {
        get
        {
            PropriedadeAcessada(RO_USACONSULTACHEQUE);
            return _usaconsultacheque;
        }
        set
        {
            PropriedadeModificada(RO_USACONSULTACHEQUE, value);
            _usaconsultacheque = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Usacontabil
    {
        get
        {
            PropriedadeAcessada(RO_USACONTABIL);
            return _usacontabil;
        }
        set
        {
            PropriedadeModificada(RO_USACONTABIL, value);
            _usacontabil = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Usacontrolelocalizacaoveiculo
    {
        get
        {
            PropriedadeAcessada(RO_USACONTROLELOCALIZACAOVEICULO);
            return _usacontrolelocalizacaoveiculo;
        }
        set
        {
            PropriedadeModificada(RO_USACONTROLELOCALIZACAOVEICULO, value);
            _usacontrolelocalizacaoveiculo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Usadadosembalagemnfe
    {
        get
        {
            PropriedadeAcessada(RO_USADADOSEMBALAGEMNFE);
            return _usadadosembalagemnfe;
        }
        set
        {
            PropriedadeModificada(RO_USADADOSEMBALAGEMNFE, value);
            _usadadosembalagemnfe = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Usadiautilfilial
    {
        get
        {
            PropriedadeAcessada(RO_USADIAUTILFILIAL);
            return _usadiautilfilial;
        }
        set
        {
            PropriedadeModificada(RO_USADIAUTILFILIAL, value);
            _usadiautilfilial = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Usadistrib
    {
        get
        {
            PropriedadeAcessada(RO_USADISTRIB);
            return _usadistrib;
        }
        set
        {
            PropriedadeModificada(RO_USADISTRIB, value);
            _usadistrib = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Usaenderecofilial
    {
        get
        {
            PropriedadeAcessada(RO_USAENDERECOFILIAL);
            return _usaenderecofilial;
        }
        set
        {
            PropriedadeModificada(RO_USAENDERECOFILIAL, value);
            _usaenderecofilial = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Usaestoquedepfechado
    {
        get
        {
            PropriedadeAcessada(RO_USAESTOQUEDEPFECHADO);
            return _usaestoquedepfechado;
        }
        set
        {
            PropriedadeModificada(RO_USAESTOQUEDEPFECHADO, value);
            _usaestoquedepfechado = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Usaintegracaooperlog
    {
        get
        {
            PropriedadeAcessada(RO_USAINTEGRACAOOPERLOG);
            return _usaintegracaooperlog;
        }
        set
        {
            PropriedadeModificada(RO_USAINTEGRACAOOPERLOG, value);
            _usaintegracaooperlog = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Usainventlocal
    {
        get
        {
            PropriedadeAcessada(RO_USAINVENTLOCAL);
            return _usainventlocal;
        }
        set
        {
            PropriedadeModificada(RO_USAINVENTLOCAL, value);
            _usainventlocal = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Usamultiplopordesconto
    {
        get
        {
            PropriedadeAcessada(RO_USAMULTIPLOPORDESCONTO);
            return _usamultiplopordesconto;
        }
        set
        {
            PropriedadeModificada(RO_USAMULTIPLOPORDESCONTO, value);
            _usamultiplopordesconto = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Usanumnfdevcli
    {
        get
        {
            PropriedadeAcessada(RO_USANUMNFDEVCLI);
            return _usanumnfdevcli;
        }
        set
        {
            PropriedadeModificada(RO_USANUMNFDEVCLI, value);
            _usanumnfdevcli = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Usanumnotaecf
    {
        get
        {
            PropriedadeAcessada(RO_USANUMNOTAECF);
            return _usanumnotaecf;
        }
        set
        {
            PropriedadeModificada(RO_USANUMNOTAECF, value);
            _usanumnotaecf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Usaorcamentoecf
    {
        get
        {
            PropriedadeAcessada(RO_USAORCAMENTOECF);
            return _usaorcamentoecf;
        }
        set
        {
            PropriedadeModificada(RO_USAORCAMENTOECF, value);
            _usaorcamentoecf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Usapoliticadescvalor
    {
        get
        {
            PropriedadeAcessada(RO_USAPOLITICADESCVALOR);
            return _usapoliticadescvalor;
        }
        set
        {
            PropriedadeModificada(RO_USAPOLITICADESCVALOR, value);
            _usapoliticadescvalor = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Usaprecoetiqprodpesado
    {
        get
        {
            PropriedadeAcessada(RO_USAPRECOETIQPRODPESADO);
            return _usaprecoetiqprodpesado;
        }
        set
        {
            PropriedadeModificada(RO_USAPRECOETIQPRODPESADO, value);
            _usaprecoetiqprodpesado = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Usapvendaatacconfqtmultipla
    {
        get
        {
            PropriedadeAcessada(RO_USAPVENDAATACCONFQTMULTIPLA);
            return _usapvendaatacconfqtmultipla;
        }
        set
        {
            PropriedadeModificada(RO_USAPVENDAATACCONFQTMULTIPLA, value);
            _usapvendaatacconfqtmultipla = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Usapvendatransf
    {
        get
        {
            PropriedadeAcessada(RO_USAPVENDATRANSF);
            return _usapvendatransf;
        }
        set
        {
            PropriedadeModificada(RO_USAPVENDATRANSF, value);
            _usapvendatransf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Usaregiaofilialvendaestadual
    {
        get
        {
            PropriedadeAcessada(RO_USAREGIAOFILIALVENDAESTADUAL);
            return _usaregiaofilialvendaestadual;
        }
        set
        {
            PropriedadeModificada(RO_USAREGIAOFILIALVENDAESTADUAL, value);
            _usaregiaofilialvendaestadual = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Usaregiaofilialvendainterest
    {
        get
        {
            PropriedadeAcessada(RO_USAREGIAOFILIALVENDAINTEREST);
            return _usaregiaofilialvendainterest;
        }
        set
        {
            PropriedadeModificada(RO_USAREGIAOFILIALVENDAINTEREST, value);
            _usaregiaofilialvendainterest = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Usaservintermediario
    {
        get
        {
            PropriedadeAcessada(RO_USASERVINTERMEDIARIO);
            return _usaservintermediario;
        }
        set
        {
            PropriedadeModificada(RO_USASERVINTERMEDIARIO, value);
            _usaservintermediario = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Usatransportadopadraonfe
    {
        get
        {
            PropriedadeAcessada(RO_USATRANSPORTADOPADRAONFE);
            return _usatransportadopadraonfe;
        }
        set
        {
            PropriedadeModificada(RO_USATRANSPORTADOPADRAONFE, value);
            _usatransportadopadraonfe = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Usawms
    {
        get
        {
            PropriedadeAcessada(RO_USAWMS);
            return _usawms;
        }
        set
        {
            PropriedadeModificada(RO_USAWMS, value);
            _usawms = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
    public string Usuariobancodadoswms
    {
        get
        {
            PropriedadeAcessada(RO_USUARIOBANCODADOSWMS);
            return _usuariobancodadoswms;
        }
        set
        {
            PropriedadeModificada(RO_USUARIOBANCODADOSWMS, value);
            _usuariobancodadoswms = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
    public string Usuarioproxy
    {
        get
        {
            PropriedadeAcessada(RO_USUARIOPROXY);
            return _usuarioproxy;
        }
        set
        {
            PropriedadeModificada(RO_USUARIOPROXY, value);
            _usuarioproxy = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
    public string Usuarioserv
    {
        get
        {
            PropriedadeAcessada(RO_USUARIOSERV);
            return _usuarioserv;
        }
        set
        {
            PropriedadeModificada(RO_USUARIOSERV, value);
            _usuarioserv = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Utilizacontrolebiometrico
    {
        get
        {
            PropriedadeAcessada(RO_UTILIZACONTROLEBIOMETRICO);
            return _utilizacontrolebiometrico;
        }
        set
        {
            PropriedadeModificada(RO_UTILIZACONTROLEBIOMETRICO, value);
            _utilizacontrolebiometrico = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Utilizacredicmsestcustocont
    {
        get
        {
            PropriedadeAcessada(RO_UTILIZACREDICMSESTCUSTOCONT);
            return _utilizacredicmsestcustocont;
        }
        set
        {
            PropriedadeModificada(RO_UTILIZACREDICMSESTCUSTOCONT, value);
            _utilizacredicmsestcustocont = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Utilizacte
    {
        get
        {
            PropriedadeAcessada(RO_UTILIZACTE);
            return _utilizacte;
        }
        set
        {
            PropriedadeModificada(RO_UTILIZACTE, value);
            _utilizacte = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Utilizanfe
    {
        get
        {
            PropriedadeAcessada(RO_UTILIZANFE);
            return _utilizanfe;
        }
        set
        {
            PropriedadeModificada(RO_UTILIZANFE, value);
            _utilizanfe = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Utilizaorigemvendanf
    {
        get
        {
            PropriedadeAcessada(RO_UTILIZAORIGEMVENDANF);
            return _utilizaorigemvendanf;
        }
        set
        {
            PropriedadeModificada(RO_UTILIZAORIGEMVENDANF, value);
            _utilizaorigemvendanf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Utilizapercbaseredoutrasdesppf
    {
        get
        {
            PropriedadeAcessada(RO_UTILIZAPERCBASEREDOUTRASDESPPF);
            return _utilizapercbaseredoutrasdesppf;
        }
        set
        {
            PropriedadeModificada(RO_UTILIZAPERCBASEREDOUTRASDESPPF, value);
            _utilizapercbaseredoutrasdesppf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Utilizaseqnfent
    {
        get
        {
            PropriedadeAcessada(RO_UTILIZASEQNFENT);
            return _utilizaseqnfent;
        }
        set
        {
            PropriedadeModificada(RO_UTILIZASEQNFENT, value);
            _utilizaseqnfent = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Utilizavendaassistida
    {
        get
        {
            PropriedadeAcessada(RO_UTILIZAVENDAASSISTIDA);
            return _utilizavendaassistida;
        }
        set
        {
            PropriedadeModificada(RO_UTILIZAVENDAASSISTIDA, value);
            _utilizavendaassistida = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Utilizavendaporembalagem
    {
        get
        {
            PropriedadeAcessada(RO_UTILIZAVENDAPOREMBALAGEM);
            return _utilizavendaporembalagem;
        }
        set
        {
            PropriedadeModificada(RO_UTILIZAVENDAPOREMBALAGEM, value);
            _utilizavendaporembalagem = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Validaendpickingpedcompra
    {
        get
        {
            PropriedadeAcessada(RO_VALIDAENDPICKINGPEDCOMPRA);
            return _validaendpickingpedcompra;
        }
        set
        {
            PropriedadeModificada(RO_VALIDAENDPICKINGPEDCOMPRA, value);
            _validaendpickingpedcompra = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Validardescflexautoserv
    {
        get
        {
            PropriedadeAcessada(RO_VALIDARDESCFLEXAUTOSERV);
            return _validardescflexautoserv;
        }
        set
        {
            PropriedadeModificada(RO_VALIDARDESCFLEXAUTOSERV, value);
            _validardescflexautoserv = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Validarendapanhaautoservico
    {
        get
        {
            PropriedadeAcessada(RO_VALIDARENDAPANHAAUTOSERVICO);
            return _validarendapanhaautoservico;
        }
        set
        {
            PropriedadeModificada(RO_VALIDARENDAPANHAAUTOSERVICO, value);
            _validarendapanhaautoservico = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Validarprecovendatv20
    {
        get
        {
            PropriedadeAcessada(RO_VALIDARPRECOVENDATV20);
            return _validarprecovendatv20;
        }
        set
        {
            PropriedadeModificada(RO_VALIDARPRECOVENDATV20, value);
            _validarprecovendatv20 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Validarprecovendatv8
    {
        get
        {
            PropriedadeAcessada(RO_VALIDARPRECOVENDATV8);
            return _validarprecovendatv8;
        }
        set
        {
            PropriedadeModificada(RO_VALIDARPRECOVENDATV8, value);
            _validarprecovendatv8 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Validavlmaxisencaostpf
    {
        get
        {
            PropriedadeAcessada(RO_VALIDAVLMAXISENCAOSTPF);
            return _validavlmaxisencaostpf;
        }
        set
        {
            PropriedadeModificada(RO_VALIDAVLMAXISENCAOSTPF, value);
            _validavlmaxisencaostpf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 2)]
    public decimal? Valorcapital
    {
        get
        {
            PropriedadeAcessada(RO_VALORCAPITAL);
            return _valorcapital;
        }
        set
        {
            PropriedadeModificada(RO_VALORCAPITAL, value);
            _valorcapital = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 3, Precisao = 0)]
    public decimal? Versaowms
    {
        get
        {
            PropriedadeAcessada(RO_VERSAOWMS);
            return _versaowms;
        }
        set
        {
            PropriedadeModificada(RO_VERSAOWMS, value);
            _versaowms = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 2)]
    public decimal? Vlmaxisencaostpf
    {
        get
        {
            PropriedadeAcessada(RO_VLMAXISENCAOSTPF);
            return _vlmaxisencaostpf;
        }
        set
        {
            PropriedadeModificada(RO_VLMAXISENCAOSTPF, value);
            _vlmaxisencaostpf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 2)]
    public decimal? Vlmaxtarifabanc
    {
        get
        {
            PropriedadeAcessada(RO_VLMAXTARIFABANC);
            return _vlmaxtarifabanc;
        }
        set
        {
            PropriedadeModificada(RO_VLMAXTARIFABANC, value);
            _vlmaxtarifabanc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 2)]
    public decimal? Vlmintarifabanc
    {
        get
        {
            PropriedadeAcessada(RO_VLMINTARIFABANC);
            return _vlmintarifabanc;
        }
        set
        {
            PropriedadeModificada(RO_VLMINTARIFABANC, value);
            _vlmintarifabanc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 2)]
    public decimal? Vlpaletedescarg
    {
        get
        {
            PropriedadeAcessada(RO_VLPALETEDESCARG);
            return _vlpaletedescarg;
        }
        set
        {
            PropriedadeModificada(RO_VLPALETEDESCARG, value);
            _vlpaletedescarg = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 2)]
    public decimal? Vlpesodescarga
    {
        get
        {
            PropriedadeAcessada(RO_VLPESODESCARGA);
            return _vlpesodescarga;
        }
        set
        {
            PropriedadeModificada(RO_VLPESODESCARGA, value);
            _vlpesodescarga = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 2)]
    public decimal? Vlpesodescargapal
    {
        get
        {
            PropriedadeAcessada(RO_VLPESODESCARGAPAL);
            return _vlpesodescargapal;
        }
        set
        {
            PropriedadeModificada(RO_VLPESODESCARGAPAL, value);
            _vlpesodescargapal = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 6)]
    public decimal? Vlremontedescarga
    {
        get
        {
            PropriedadeAcessada(RO_VLREMONTEDESCARGA);
            return _vlremontedescarga;
        }
        set
        {
            PropriedadeModificada(RO_VLREMONTEDESCARGA, value);
            _vlremontedescarga = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 2)]
    public decimal? Vltarifa
    {
        get
        {
            PropriedadeAcessada(RO_VLTARIFA);
            return _vltarifa;
        }
        set
        {
            PropriedadeModificada(RO_VLTARIFA, value);
            _vltarifa = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 2)]
    public decimal? Vlvoldescarga
    {
        get
        {
            PropriedadeAcessada(RO_VLVOLDESCARGA);
            return _vlvoldescarga;
        }
        set
        {
            PropriedadeModificada(RO_VLVOLDESCARGA, value);
            _vlvoldescarga = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 2)]
    public decimal? Vlvolumedescargafd
    {
        get
        {
            PropriedadeAcessada(RO_VLVOLUMEDESCARGAFD);
            return _vlvolumedescargafd;
        }
        set
        {
            PropriedadeModificada(RO_VLVOLUMEDESCARGAFD, value);
            _vlvolumedescargafd = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Utilizarecalculostcheckout
    {
        get
        {
            PropriedadeAcessada(RO_UTILIZARECALCULOSTCHECKOUT);
            return _utilizarecalculostcheckout;
        }
        set
        {
            PropriedadeModificada(RO_UTILIZARECALCULOSTCHECKOUT, value);
            _utilizarecalculostcheckout = value;
        }
    }

    public void InicializarAtributos()
    {
    }

    public string ObterNomeTabela()
    {
        return "PCFILIAL";
    }

    public IEntidade NovaInstancia()
    {
        return (IEntidade)GetType().GetConstructors()[0].Invoke(null);
    }

    public void CarregarPorDataReader(IDataReader leitor)
    {
        _aceitavendaavistaclibloq = AlterarTipo<string>(leitor["Aceitavendaavistaclibloq"]);
        _aceitavendasemest = AlterarTipo<string>(leitor["Aceitavendasemest"]);
        _aliqicminteroutrasdesp = AlterarTipo<decimal?>(leitor["Aliqicminteroutrasdesp"]);
        _aliqicmoutrasdesp = AlterarTipo<decimal?>(leitor["Aliqicmoutrasdesp"]);
        _aliquotafreteest = AlterarTipo<decimal?>(leitor["Aliquotafreteest"]);
        _alterapedidoretornadowms = AlterarTipo<string>(leitor["Alterapedidoretornadowms"]);
        _alterarcobbkchautomatico = AlterarTipo<string>(leitor["Alterarcobbkchautomatico"]);
        _ambiente = AlterarTipo<string>(leitor["Ambiente"]);
        _aplicapercatacnaocontrib = AlterarTipo<string>(leitor["Aplicapercatacnaocontrib"]);
        _aplicapercvarnaocontrib = AlterarTipo<string>(leitor["Aplicapercvarnaocontrib"]);
        _aproveitadesp_piscofins = AlterarTipo<string>(leitor["Aproveitadesp_Piscofins"]);
        _aproveitafrete_piscofins = AlterarTipo<string>(leitor["Aproveitafrete_Piscofins"]);
        _aproveitaipi_piscofins = AlterarTipo<string>(leitor["Aproveitaipi_Piscofins"]);
        _areavenda = AlterarTipo<decimal?>(leitor["Areavenda"]);
        _arredondaqtgirodia = AlterarTipo<string>(leitor["Arredondaqtgirodia"]);
        _arredvlitensnfsaida = AlterarTipo<string>(leitor["Arredvlitensnfsaida"]);
        _atacadista = AlterarTipo<string>(leitor["Atacadista"]);
        _atividade = AlterarTipo<string>(leitor["Atividade"]);
        _atualizacustoultentransf = AlterarTipo<string>(leitor["Atualizacustoultentransf"]);
        _autoservico = AlterarTipo<string>(leitor["Autoservico"]);
        _bairro = AlterarTipo<string>(leitor["Bairro"]);
        _bloqdesdemitentedif = AlterarTipo<string>(leitor["Bloqdesdemitentedif"]);
        _bloqdevcli = AlterarTipo<string>(leitor["Bloqdevcli"]);
        _bloqestoquetransf = AlterarTipo<string>(leitor["Bloqestoquetransf"]);
        _bloquearpedidosabaixovlminimo = AlterarTipo<string>(leitor["Bloquearpedidosabaixovlminimo"]);
        _bloqueiariskscoring = AlterarTipo<string>(leitor["Bloqueiariskscoring"]);
        _bloqvendapf = AlterarTipo<string>(leitor["Bloqvendapf"]);
        _broker = AlterarTipo<string>(leitor["Broker"]);
        _cae = AlterarTipo<string>(leitor["Cae"]);
        _calccredicmcustocont = AlterarTipo<string>(leitor["Calccredicmcustocont"]);
        _calccredicms = AlterarTipo<string>(leitor["Calccredicms"]);
        _calccredipi = AlterarTipo<string>(leitor["Calccredipi"]);
        _calccredpiscofins = AlterarTipo<string>(leitor["Calccredpiscofins"]);
        _calccredpiscustocont = AlterarTipo<string>(leitor["Calccredpiscustocont"]);
        _calcestdispcomqtminautoserv = AlterarTipo<string>(leitor["Calcestdispcomqtminautoserv"]);
        _calcredpisfrete = AlterarTipo<string>(leitor["Calcredpisfrete"]);
        _calcredpisfretecont = AlterarTipo<string>(leitor["Calcredpisfretecont"]);
        _calcularcomissaopvenda1 = AlterarTipo<string>(leitor["Calcularcomissaopvenda1"]);
        _calcularipivenda = AlterarTipo<string>(leitor["Calcularipivenda"]);
        _cancelanfdevclicomwms = AlterarTipo<string>(leitor["Cancelanfdevclicomwms"]);
        _cancelanfentradacomwms = AlterarTipo<string>(leitor["Cancelanfentradacomwms"]);
        _cancelanfvendacomwms = AlterarTipo<string>(leitor["Cancelanfvendacomwms"]);
        _cancelapedidoretornadowms = AlterarTipo<string>(leitor["Cancelapedidoretornadowms"]);
        _cep = AlterarTipo<string>(leitor["Cep"]);
        _cgc = AlterarTipo<string>(leitor["Cgc"]);
        _cgc_operadorlogistico = AlterarTipo<string>(leitor["Cgc_Operadorlogistico"]);
        _cgctransp = AlterarTipo<string>(leitor["Cgctransp"]);
        _cidade = AlterarTipo<string>(leitor["Cidade"]);
        _cidadetransp = AlterarTipo<string>(leitor["Cidadetransp"]);
        _clicrependente = AlterarTipo<string>(leitor["Clicrependente"]);
        _cnpj_paf = AlterarTipo<string>(leitor["Cnpj_Paf"]);
        _codcli = AlterarTipo<decimal?>(leitor["Codcli"]);
        _codcliconsumidor = AlterarTipo<decimal?>(leitor["Codcliconsumidor"]);
        _codcontacredfornec = AlterarTipo<decimal?>(leitor["Codcontacredfornec"]);
        _codcontador = AlterarTipo<decimal?>(leitor["Codcontador"]);
        _codcontaentimportacao = AlterarTipo<decimal?>(leitor["Codcontaentimportacao"]);
        _codcontapercacrescent = AlterarTipo<decimal?>(leitor["Codcontapercacrescent"]);
        _codcontarecarga = AlterarTipo<decimal?>(leitor["Codcontarecarga"]);
        _codcontavendaentregafut = AlterarTipo<decimal?>(leitor["Codcontavendaentregafut"]);
        _coddocdevfornec = AlterarTipo<decimal?>(leitor["Coddocdevfornec"]);
        _coddocdevol = AlterarTipo<decimal?>(leitor["Coddocdevol"]);
        _coddocentradamerc = AlterarTipo<decimal?>(leitor["Coddocentradamerc"]);
        _coddocnf = AlterarTipo<decimal?>(leitor["Coddocnf"]);
        _coddocnfc = AlterarTipo<decimal?>(leitor["Coddocnfc"]);
        _coddocnotacobranca = AlterarTipo<decimal?>(leitor["Coddocnotacobranca"]);
        _coddocorigemnf = AlterarTipo<decimal?>(leitor["Coddocorigemnf"]);
        _coddocse = AlterarTipo<decimal?>(leitor["Coddocse"]);
        _coddocsr = AlterarTipo<decimal?>(leitor["Coddocsr"]);
        _coddocsrauto = AlterarTipo<decimal?>(leitor["Coddocsrauto"]);
        _coddocss = AlterarTipo<decimal?>(leitor["Coddocss"]);
        _coddoctransf = AlterarTipo<decimal?>(leitor["Coddoctransf"]);
        _codestado = AlterarTipo<decimal?>(leitor["Codestado"]);
        _codfilialprefestbalcao = AlterarTipo<string>(leitor["Codfilialprefestbalcao"]);
        _codfilialprefesttlmk = AlterarTipo<string>(leitor["Codfilialprefesttlmk"]);
        _codfilialproducao = AlterarTipo<string>(leitor["Codfilialproducao"]);
        _codfiscaldevoutrasdesp = AlterarTipo<decimal?>(leitor["Codfiscaldevoutrasdesp"]);
        _codfiscalinterdevoutrasdesp = AlterarTipo<decimal?>(leitor["Codfiscalinterdevoutrasdesp"]);
        _codfiscalinteroutrasdesp = AlterarTipo<decimal?>(leitor["Codfiscalinteroutrasdesp"]);
        _codfiscalopcionalnfimportacao = AlterarTipo<string>(leitor["Codfiscalopcionalnfimportacao"]);
        _codfiscaloutrasdesp = AlterarTipo<decimal?>(leitor["Codfiscaloutrasdesp"]);
        _codfornec = AlterarTipo<decimal?>(leitor["Codfornec"]);
        _codgln = AlterarTipo<decimal?>(leitor["Codgln"]);
        _codgrupo = AlterarTipo<string>(leitor["Codgrupo"]);
        _codgrupofilial = AlterarTipo<decimal?>(leitor["Codgrupofilial"]);
        _codgrupoloja = AlterarTipo<decimal?>(leitor["Codgrupoloja"]);
        _codigo = AlterarTipo<string>(leitor["Codigo"]);
        _codmd5_paf = AlterarTipo<string>(leitor["Codmd5_Paf"]);
        _codmun = AlterarTipo<decimal?>(leitor["Codmun"]);
        _codpais = AlterarTipo<decimal?>(leitor["Codpais"]);
        _codregistro = AlterarTipo<string>(leitor["Codregistro"]);
        _codsocio = AlterarTipo<decimal?>(leitor["Codsocio"]);
        _concederdescisencaostpf = AlterarTipo<string>(leitor["Concederdescisencaostpf"]);
        _conferirsomentepedacertadocx = AlterarTipo<string>(leitor["Conferirsomentepedacertadocx"]);
        _consideraestpendsugcompra = AlterarTipo<string>(leitor["Consideraestpendsugcompra"]);
        _consideramontagemgiromerc = AlterarTipo<string>(leitor["Consideramontagemgiromerc"]);
        _considerarcomissaozero = AlterarTipo<string>(leitor["Considerarcomissaozero"]);
        _consideraricmsantecipcusto = AlterarTipo<string>(leitor["Consideraricmsantecipcusto"]);
        _consolidadados504 = AlterarTipo<string>(leitor["Consolidadados504"]);
        _contato = AlterarTipo<string>(leitor["Contato"]);
        _controlagarantiaservico = AlterarTipo<string>(leitor["Controlagarantiaservico"]);
        _controlenfeporserie = AlterarTipo<string>(leitor["Controlenfeporserie"]);
        _corteautomaticopedvendawms = AlterarTipo<string>(leitor["Corteautomaticopedvendawms"]);
        _datahora_primeirodocumento_ecf = AlterarTipo<string>(leitor["Datahora_Primeirodocumento_Ecf"]);
        _depfechado = AlterarTipo<string>(leitor["Depfechado"]);
        _destacarimpostosvendatv13 = AlterarTipo<string>(leitor["Destacarimpostosvendatv13"]);
        _destacarimpostosvendatv14 = AlterarTipo<string>(leitor["Destacarimpostosvendatv14"]);
        _devfornecestoqueavaria = AlterarTipo<string>(leitor["Devfornecestoqueavaria"]);
        _diascurvatura = AlterarTipo<decimal?>(leitor["Diascurvatura"]);
        _diasprazotransf = AlterarTipo<decimal?>(leitor["Diasprazotransf"]);
        _diavencicmsantecip = AlterarTipo<decimal?>(leitor["Diavencicmsantecip"]);
        _direxpxmlsngpc = AlterarTipo<string>(leitor["Direxpxmlsngpc"]);
        _dominioserv = AlterarTipo<string>(leitor["Dominioserv"]);
        _dtaltmatricsngpc = AlterarTipo<DateTime?>(leitor["Dtaltmatricsngpc"]);
        _dtexclusao = AlterarTipo<DateTime?>(leitor["Dtexclusao"]);
        _dtfimatividade = AlterarTipo<DateTime?>(leitor["Dtfimatividade"]);
        _dtiniatividade = AlterarTipo<DateTime?>(leitor["Dtiniatividade"]);
        _dtregistro = AlterarTipo<DateTime?>(leitor["Dtregistro"]);
        _dtultatualizacaodrvinter = AlterarTipo<DateTime?>(leitor["Dtultatualizacaodrvinter"]);
        _dtutilizacte = AlterarTipo<DateTime?>(leitor["Dtutilizacte"]);
        _dtutilizanfe = AlterarTipo<DateTime?>(leitor["Dtutilizanfe"]);
        _eanemissor = AlterarTipo<decimal?>(leitor["Eanemissor"]);
        _email = AlterarTipo<string>(leitor["Email"]);
        _emailcopiaresposta = AlterarTipo<string>(leitor["Emailcopiaresposta"]);
        _emailremetente = AlterarTipo<string>(leitor["Emailremetente"]);
        _emailresposta = AlterarTipo<string>(leitor["Emailresposta"]);
        _endereco = AlterarTipo<string>(leitor["Endereco"]);
        _enderecoproxy = AlterarTipo<string>(leitor["Enderecoproxy"]);
        _endtransp = AlterarTipo<string>(leitor["Endtransp"]);
        _enviacontaspagarnfe = AlterarTipo<string>(leitor["Enviacontaspagarnfe"]);
        _enviacontasrecebernfe = AlterarTipo<string>(leitor["Enviacontasrecebernfe"]);
        _estornacustodevfornec = AlterarTipo<string>(leitor["Estornacustodevfornec"]);
        _exibirimpostosforanfimportacao = AlterarTipo<string>(leitor["Exibirimpostosforanfimportacao"]);
        _exigiremissaomapabalcao = AlterarTipo<string>(leitor["Exigiremissaomapabalcao"]);
        _fantasia = AlterarTipo<string>(leitor["Fantasia"]);
        _fax = AlterarTipo<string>(leitor["Fax"]);
        _gerabasenormalquandost = AlterarTipo<string>(leitor["Gerabasenormalquandost"]);
        _gerapedidocomitenssemest = AlterarTipo<string>(leitor["Gerapedidocomitenssemest"]);
        _gerarnsu = AlterarTipo<string>(leitor["Gerarnsu"]);
        _gerarnumloteautomaticpa = AlterarTipo<string>(leitor["Gerarnumloteautomaticpa"]);
        _gerarpchistest = AlterarTipo<string>(leitor["Gerarpchistest"]);
        _gerarpedconsignacaovasilhame = AlterarTipo<string>(leitor["Gerarpedconsignacaovasilhame"]);
        _gravarvalordescfin = AlterarTipo<string>(leitor["Gravarvalordescfin"]);
        _horafinaldigitacaoped = AlterarTipo<DateTime?>(leitor["Horafinaldigitacaoped"]);
        _horafinalimportacaoped = AlterarTipo<DateTime?>(leitor["Horafinalimportacaoped"]);
        _horainicialdigitacaoped = AlterarTipo<DateTime?>(leitor["Horainicialdigitacaoped"]);
        _horainicialimportacaoped = AlterarTipo<DateTime?>(leitor["Horainicialimportacaoped"]);
        _hrfimalmoco = AlterarTipo<DateTime?>(leitor["Hrfimalmoco"]);
        _hrfimexpediente = AlterarTipo<DateTime?>(leitor["Hrfimexpediente"]);
        _hrinicioalmoco = AlterarTipo<DateTime?>(leitor["Hrinicioalmoco"]);
        _hrinicioexpediente = AlterarTipo<DateTime?>(leitor["Hrinicioexpediente"]);
        _ie = AlterarTipo<string>(leitor["Ie"]);
        _iesubsttrib = AlterarTipo<string>(leitor["Iesubsttrib"]);
        _ietransp = AlterarTipo<string>(leitor["Ietransp"]);
        _im = AlterarTipo<string>(leitor["Im"]);
        _impedetipo14_livrofiscal = AlterarTipo<string>(leitor["Impedetipo14_Livrofiscal"]);
        _incluifreteoutrasdespbasest = AlterarTipo<string>(leitor["Incluifreteoutrasdespbasest"]);
        _incluiritempcembalagem = AlterarTipo<string>(leitor["Incluiritempcembalagem"]);
        _indicecustotransf = AlterarTipo<decimal?>(leitor["Indicecustotransf"]);
        _industria = AlterarTipo<string>(leitor["Industria"]);
        _informarprofissionalvenda = AlterarTipo<string>(leitor["Informarprofissionalvenda"]);
        _integradorawms = AlterarTipo<decimal?>(leitor["Integradorawms"]);
        _ipisomentevlcont = AlterarTipo<string>(leitor["Ipisomentevlcont"]);
        _lancarfretepesoautfat = AlterarTipo<string>(leitor["Lancarfretepesoautfat"]);
        _libpedcomprasemdiverg = AlterarTipo<string>(leitor["Libpedcomprasemdiverg"]);
        _limparbasecalcentrada = AlterarTipo<string>(leitor["Limparbasecalcentrada"]);
        _limriskscoring = AlterarTipo<decimal?>(leitor["Limriskscoring"]);
        _matriculasngpc = AlterarTipo<decimal?>(leitor["Matriculasngpc"]);
        _matriculasngpcant = AlterarTipo<decimal?>(leitor["Matriculasngpcant"]);
        _mensnf = AlterarTipo<string>(leitor["Mensnf"]);
        _mensnfimunidadetrib = AlterarTipo<string>(leitor["Mensnfimunidadetrib"]);
        _mixmaximo = AlterarTipo<decimal?>(leitor["Mixmaximo"]);
        _mixminimo = AlterarTipo<decimal?>(leitor["Mixminimo"]);
        _montacargawinthor = AlterarTipo<string>(leitor["Montacargawinthor"]);
        _montando = AlterarTipo<string>(leitor["Montando"]);
        _montarkitautomaticamente = AlterarTipo<string>(leitor["Montarkitautomaticamente"]);
        _naogerarcreditoentradatransf = AlterarTipo<string>(leitor["Naogerarcreditoentradatransf"]);
        _nomebancodadoswms = AlterarTipo<string>(leitor["Nomebancodadoswms"]);
        _nome_paf = AlterarTipo<string>(leitor["Nome_Paf"]);
        _nomepais = AlterarTipo<string>(leitor["Nomepais"]);
        _nomeremetente = AlterarTipo<string>(leitor["Nomeremetente"]);
        _numcontratocorreio = AlterarTipo<decimal?>(leitor["Numcontratocorreio"]);
        _numdiasmaximoliberarpedido = AlterarTipo<decimal?>(leitor["Numdiasmaximoliberarpedido"]);
        _numdiasvencfrete = AlterarTipo<decimal?>(leitor["Numdiasvencfrete"]);
        _numero = AlterarTipo<decimal?>(leitor["Numero"]);
        _numero2 = AlterarTipo<string>(leitor["Numero2"]);
        _numidf = AlterarTipo<string>(leitor["Numidf"]);
        _numidfdevcli = AlterarTipo<string>(leitor["Numidfdevcli"]);
        _nummaxdiasretrodtcompensacao = AlterarTipo<decimal?>(leitor["Nummaxdiasretrodtcompensacao"]);
        _nummaxitensnfe = AlterarTipo<decimal?>(leitor["Nummaxitensnfe"]);
        _numproxvend = AlterarTipo<decimal?>(leitor["Numproxvend"]);
        _numregiao = AlterarTipo<decimal?>(leitor["Numregiao"]);
        _numregiaobalcaointer = AlterarTipo<decimal?>(leitor["Numregiaobalcaointer"]);
        _numregiaopadrao = AlterarTipo<decimal?>(leitor["Numregiaopadrao"]);
        _numseqentr = AlterarTipo<decimal?>(leitor["Numseqentr"]);
        _obrigaconsfinaldev = AlterarTipo<string>(leitor["Obrigaconsfinaldev"]);
        _operadorlogistico = AlterarTipo<string>(leitor["Operadorlogistico"]);
        _opisentosicmsaltocusto = AlterarTipo<string>(leitor["Opisentosicmsaltocusto"]);
        _optantesimplesnac = AlterarTipo<string>(leitor["Optantesimplesnac"]);
        _ordemagrupdesd = AlterarTipo<string>(leitor["Ordemagrupdesd"]);
        _orgao = AlterarTipo<string>(leitor["Orgao"]);
        _origemcustofilialretira = AlterarTipo<string>(leitor["Origemcustofilialretira"]);
        _origemvendanf = AlterarTipo<string>(leitor["Origemvendanf"]);
        _osprodmanutobrig = AlterarTipo<string>(leitor["Osprodmanutobrig"]);
        _perbaseredoutrasdesp = AlterarTipo<decimal?>(leitor["Perbaseredoutrasdesp"]);
        _perbaseredoutrasdesppf = AlterarTipo<decimal?>(leitor["Perbaseredoutrasdesppf"]);
        _percacrescimobalcao = AlterarTipo<decimal?>(leitor["Percacrescimobalcao"]);
        _percaltercustoent = AlterarTipo<decimal?>(leitor["Percaltercustoent"]);
        _percdeclinioabc = AlterarTipo<decimal?>(leitor["Percdeclinioabc"]);
        _percdespadm = AlterarTipo<decimal?>(leitor["Percdespadm"]);
        _percevolucaoabc = AlterarTipo<decimal?>(leitor["Percevolucaoabc"]);
        _percicmssimplesnac = AlterarTipo<decimal?>(leitor["Percicmssimplesnac"]);
        _percmaxdifprodsimil = AlterarTipo<decimal?>(leitor["Percmaxdifprodsimil"]);
        _percomfilialbroker = AlterarTipo<decimal?>(leitor["Percomfilialbroker"]);
        _percommotbroker = AlterarTipo<decimal?>(leitor["Percommotbroker"]);
        _percomrcabroker = AlterarTipo<decimal?>(leitor["Percomrcabroker"]);
        _percparticipaclassea = AlterarTipo<decimal?>(leitor["Percparticipaclassea"]);
        _percparticipaclasseb = AlterarTipo<decimal?>(leitor["Percparticipaclasseb"]);
        _percparticipasubclassea1 = AlterarTipo<decimal?>(leitor["Percparticipasubclassea1"]);
        _percparticipasubclassea2 = AlterarTipo<decimal?>(leitor["Percparticipasubclassea2"]);
        _percparticipasubclassea3 = AlterarTipo<decimal?>(leitor["Percparticipasubclassea3"]);
        _percparticipasubclasseb1 = AlterarTipo<decimal?>(leitor["Percparticipasubclasseb1"]);
        _percparticipasubclasseb2 = AlterarTipo<decimal?>(leitor["Percparticipasubclasseb2"]);
        _percparticipasubclasseb3 = AlterarTipo<decimal?>(leitor["Percparticipasubclasseb3"]);
        _percparticipasubclassec1 = AlterarTipo<decimal?>(leitor["Percparticipasubclassec1"]);
        _percparticipasubclassec2 = AlterarTipo<decimal?>(leitor["Percparticipasubclassec2"]);
        _perfretebroker = AlterarTipo<decimal?>(leitor["Perfretebroker"]);
        _perfreteconhec = AlterarTipo<decimal?>(leitor["Perfreteconhec"]);
        _perlimvendapf = AlterarTipo<decimal?>(leitor["Perlimvendapf"]);
        _permiteagruparboletos = AlterarTipo<string>(leitor["Permiteagruparboletos"]);
        _permitecancelarnfentwms = AlterarTipo<string>(leitor["Permitecancelarnfentwms"]);
        _permitecredicmcomst = AlterarTipo<string>(leitor["Permitecredicmcomst"]);
        _permitefaturar = AlterarTipo<string>(leitor["Permitefaturar"]);
        _permitirdesddifprof = AlterarTipo<string>(leitor["Permitirdesddifprof"]);
        _permitirvendaestadualpfcomie = AlterarTipo<string>(leitor["Permitirvendaestadualpfcomie"]);
        _permitirvendaestadualpfsemie = AlterarTipo<string>(leitor["Permitirvendaestadualpfsemie"]);
        _permitirvendainterestadualpf = AlterarTipo<string>(leitor["Permitirvendainterestadualpf"]);
        _pervendapf = AlterarTipo<decimal?>(leitor["Pervendapf"]);
        _pesolimiteos = AlterarTipo<decimal?>(leitor["Pesolimiteos"]);
        _pondcusnotatransf = AlterarTipo<string>(leitor["Pondcusnotatransf"]);
        _portaproxy = AlterarTipo<decimal?>(leitor["Portaproxy"]);
        _portaserv = AlterarTipo<decimal?>(leitor["Portaserv"]);
        _prazomaximppedpendecf = AlterarTipo<decimal?>(leitor["Prazomaximppedpendecf"]);
        _precificaautomatico = AlterarTipo<string>(leitor["Precificaautomatico"]);
        _precoporembalagem = AlterarTipo<string>(leitor["Precoporembalagem"]);
        _prodporetapa = AlterarTipo<string>(leitor["Prodporetapa"]);
        _proxnsu = AlterarTipo<decimal?>(leitor["Proxnsu"]);
        _proxnumaverbacao = AlterarTipo<decimal?>(leitor["Proxnumaverbacao"]);
        _proxnumcarecf = AlterarTipo<decimal?>(leitor["Proxnumcarecf"]);
        _proxnumconhec = AlterarTipo<decimal?>(leitor["Proxnumconhec"]);
        _proxnumcte = AlterarTipo<decimal?>(leitor["Proxnumcte"]);
        _proxnumentmex = AlterarTipo<decimal?>(leitor["Proxnumentmex"]);
        _proxnumeroorcamento = AlterarTipo<decimal?>(leitor["Proxnumeroorcamento"]);
        _proxnumetapa = AlterarTipo<decimal?>(leitor["Proxnumetapa"]);
        _proxnumlote = AlterarTipo<decimal?>(leitor["Proxnumlote"]);
        _proxnumnfdevcli = AlterarTipo<decimal?>(leitor["Proxnumnfdevcli"]);
        _proxnumnfe = AlterarTipo<decimal?>(leitor["Proxnumnfe"]);
        _proxnumnfedevmanisfesto = AlterarTipo<decimal?>(leitor["Proxnumnfedevmanisfesto"]);
        _proxnumnfedevmanisfestoscan = AlterarTipo<decimal?>(leitor["Proxnumnfedevmanisfestoscan"]);
        _proxnumnfeentrada = AlterarTipo<decimal?>(leitor["Proxnumnfeentrada"]);
        _proxnumnfeimportacao = AlterarTipo<decimal?>(leitor["Proxnumnfeimportacao"]);
        _proxnumnferemmanisfesto = AlterarTipo<decimal?>(leitor["Proxnumnferemmanisfesto"]);
        _proxnumnferemmanisfestoscan = AlterarTipo<decimal?>(leitor["Proxnumnferemmanisfestoscan"]);
        _proxnumnfescan = AlterarTipo<decimal?>(leitor["Proxnumnfescan"]);
        _proxnumnfescanentrada = AlterarTipo<decimal?>(leitor["Proxnumnfescanentrada"]);
        _proxnumnfescanimportacao = AlterarTipo<decimal?>(leitor["Proxnumnfescanimportacao"]);
        _proxnumnfs = AlterarTipo<decimal?>(leitor["Proxnumnfs"]);
        _proxnumnota = AlterarTipo<decimal?>(leitor["Proxnumnota"]);
        _proxnumnotacobranca = AlterarTipo<decimal?>(leitor["Proxnumnotacobranca"]);
        _proxnumnotad = AlterarTipo<decimal?>(leitor["Proxnumnotad"]);
        _proxnumnotaecf = AlterarTipo<decimal?>(leitor["Proxnumnotaecf"]);
        _proxnumnotaorigvenda = AlterarTipo<decimal?>(leitor["Proxnumnotaorigvenda"]);
        _proxnumnotatransf = AlterarTipo<decimal?>(leitor["Proxnumnotatransf"]);
        _proxnumorc = AlterarTipo<decimal?>(leitor["Proxnumorc"]);
        _proxnumorcafilial = AlterarTipo<decimal?>(leitor["Proxnumorcafilial"]);
        _proxnumos = AlterarTipo<decimal?>(leitor["Proxnumos"]);
        _proxnumprevenda = AlterarTipo<decimal?>(leitor["Proxnumprevenda"]);
        _proxnumtransconhec = AlterarTipo<decimal?>(leitor["Proxnumtransconhec"]);
        _proxnumtransecf = AlterarTipo<decimal?>(leitor["Proxnumtransecf"]);
        _proxnumtransvendaecf = AlterarTipo<decimal?>(leitor["Proxnumtransvendaecf"]);
        _qtdemaxdiasvencverbas = AlterarTipo<decimal?>(leitor["Qtdemaxdiasvencverbas"]);
        _qtdmaxitensos = AlterarTipo<decimal?>(leitor["Qtdmaxitensos"]);
        _qtdminitensmoduloos = AlterarTipo<decimal?>(leitor["Qtdminitensmoduloos"]);
        _qtmaxpedido = AlterarTipo<decimal?>(leitor["Qtmaxpedido"]);
        _qtmultiplainicialecf = AlterarTipo<decimal?>(leitor["Qtmultiplainicialecf"]);
        _razaosocial = AlterarTipo<string>(leitor["Razaosocial"]);
        _razaotransp = AlterarTipo<string>(leitor["Razaotransp"]);
        _recalcdvproduto = AlterarTipo<string>(leitor["Recalcdvproduto"]);
        _reduziricmspropriotransf = AlterarTipo<string>(leitor["Reduziricmspropriotransf"]);
        _regraarredondamentoecf = AlterarTipo<string>(leitor["Regraarredondamentoecf"]);
        _retirardescnabaixa = AlterarTipo<string>(leitor["Retirardescnabaixa"]);
        _rotinalanc = AlterarTipo<string>(leitor["Rotinalanc"]);
        _senhabancodadoswms = AlterarTipo<string>(leitor["Senhabancodadoswms"]);
        _senhaproxy = AlterarTipo<string>(leitor["Senhaproxy"]);
        _senhaserv = AlterarTipo<string>(leitor["Senhaserv"]);
        _seriecte = AlterarTipo<string>(leitor["Seriecte"]);
        _serienfe = AlterarTipo<string>(leitor["Serienfe"]);
        _serienfedevmanifesto = AlterarTipo<string>(leitor["Serienfedevmanifesto"]);
        _serienfedevmanifestoscan = AlterarTipo<string>(leitor["Serienfedevmanifestoscan"]);
        _serienfeentrada = AlterarTipo<string>(leitor["Serienfeentrada"]);
        _serienfeimportacao = AlterarTipo<string>(leitor["Serienfeimportacao"]);
        _serienferemmanisfesto = AlterarTipo<string>(leitor["Serienferemmanisfesto"]);
        _serienferemmanisfestoscan = AlterarTipo<string>(leitor["Serienferemmanisfestoscan"]);
        _serienfescan = AlterarTipo<string>(leitor["Serienfescan"]);
        _serienfescanentrada = AlterarTipo<string>(leitor["Serienfescanentrada"]);
        _serienfescanimportacao = AlterarTipo<string>(leitor["Serienfescanimportacao"]);
        _serienfs = AlterarTipo<string>(leitor["Serienfs"]);
        _servidorsmtp = AlterarTipo<string>(leitor["Servidorsmtp"]);
        _sittributopcionalnfimportacao = AlterarTipo<string>(leitor["Sittributopcionalnfimportacao"]);
        _somaicmstransf = AlterarTipo<string>(leitor["Somaicmstransf"]);
        _somatarifabancduplic = AlterarTipo<string>(leitor["Somatarifabancduplic"]);
        _stsomentevlcont = AlterarTipo<string>(leitor["Stsomentevlcont"]);
        _taxa0 = AlterarTipo<decimal?>(leitor["Taxa0"]);
        _taxa14 = AlterarTipo<decimal?>(leitor["Taxa14"]);
        _taxa21 = AlterarTipo<decimal?>(leitor["Taxa21"]);
        _taxa28 = AlterarTipo<decimal?>(leitor["Taxa28"]);
        _taxa35 = AlterarTipo<decimal?>(leitor["Taxa35"]);
        _taxa42 = AlterarTipo<decimal?>(leitor["Taxa42"]);
        _taxa7 = AlterarTipo<decimal?>(leitor["Taxa7"]);
        _telefone = AlterarTipo<string>(leitor["Telefone"]);
        _temposepcaixaos = AlterarTipo<decimal?>(leitor["Temposepcaixaos"]);
        _temposepinicialos = AlterarTipo<decimal?>(leitor["Temposepinicialos"]);
        _temposepprodos = AlterarTipo<decimal?>(leitor["Temposepprodos"]);
        _tipoavaliacaocomissao = AlterarTipo<decimal?>(leitor["Tipoavaliacaocomissao"]);
        _tipobroker = AlterarTipo<string>(leitor["Tipobroker"]);
        _tipocnpj = AlterarTipo<string>(leitor["Tipocnpj"]);
        _tipodanfe = AlterarTipo<string>(leitor["Tipodanfe"]);
        _tipoexportacao = AlterarTipo<string>(leitor["Tipoexportacao"]);
        _tipofilial = AlterarTipo<string>(leitor["Tipofilial"]);
        _tipofreteauto = AlterarTipo<string>(leitor["Tipofreteauto"]);
        _tipoidentificacaoecf = AlterarTipo<string>(leitor["Tipoidentificacaoecf"]);
        _tipomontagem = AlterarTipo<string>(leitor["Tipomontagem"]);
        _tiponummapa = AlterarTipo<string>(leitor["Tiponummapa"]);
        _tiponumnfentrada = AlterarTipo<string>(leitor["Tiponumnfentrada"]);
        _tipoprecificacao = AlterarTipo<string>(leitor["Tipoprecificacao"]);
        _transferevlstbasestnatransf = AlterarTipo<string>(leitor["Transferevlstbasestnatransf"]);
        _uf = AlterarTipo<string>(leitor["Uf"]);
        _uftransp = AlterarTipo<string>(leitor["Uftransp"]);
        _usabrindeecf = AlterarTipo<string>(leitor["Usabrindeecf"]);
        _usacodbarraembalagem = AlterarTipo<string>(leitor["Usacodbarraembalagem"]);
        _usacodclivenda = AlterarTipo<string>(leitor["Usacodclivenda"]);
        _usaconsultacheque = AlterarTipo<string>(leitor["Usaconsultacheque"]);
        _usacontabil = AlterarTipo<string>(leitor["Usacontabil"]);
        _usacontrolelocalizacaoveiculo = AlterarTipo<string>(leitor["Usacontrolelocalizacaoveiculo"]);
        _usadadosembalagemnfe = AlterarTipo<string>(leitor["Usadadosembalagemnfe"]);
        _usadiautilfilial = AlterarTipo<string>(leitor["Usadiautilfilial"]);
        _usadistrib = AlterarTipo<string>(leitor["Usadistrib"]);
        _usaenderecofilial = AlterarTipo<string>(leitor["Usaenderecofilial"]);
        _usaestoquedepfechado = AlterarTipo<string>(leitor["Usaestoquedepfechado"]);
        _usaintegracaooperlog = AlterarTipo<string>(leitor["Usaintegracaooperlog"]);
        _usaintegracaowms = AlterarTipo<string>(leitor["Usaintegracaowms"]);
        _usainventlocal = AlterarTipo<string>(leitor["Usainventlocal"]);
        _usamultiplopordesconto = AlterarTipo<string>(leitor["Usamultiplopordesconto"]);
        _usanumnfdevcli = AlterarTipo<string>(leitor["Usanumnfdevcli"]);
        _usanumnotaecf = AlterarTipo<string>(leitor["Usanumnotaecf"]);
        _usaorcamentoecf = AlterarTipo<string>(leitor["Usaorcamentoecf"]);
        _usapoliticadescvalor = AlterarTipo<string>(leitor["Usapoliticadescvalor"]);
        _usaprecoetiqprodpesado = AlterarTipo<string>(leitor["Usaprecoetiqprodpesado"]);
        _usapvendaatacconfqtmultipla = AlterarTipo<string>(leitor["Usapvendaatacconfqtmultipla"]);
        _usapvendatransf = AlterarTipo<string>(leitor["Usapvendatransf"]);
        _usaregiaofilialvendaestadual = AlterarTipo<string>(leitor["Usaregiaofilialvendaestadual"]);
        _usaregiaofilialvendainterest = AlterarTipo<string>(leitor["Usaregiaofilialvendainterest"]);
        _usaservintermediario = AlterarTipo<string>(leitor["Usaservintermediario"]);
        _usatransportadopadraonfe = AlterarTipo<string>(leitor["Usatransportadopadraonfe"]);
        _usawms = AlterarTipo<string>(leitor["Usawms"]);
        _usuariobancodadoswms = AlterarTipo<string>(leitor["Usuariobancodadoswms"]);
        _usuarioproxy = AlterarTipo<string>(leitor["Usuarioproxy"]);
        _usuarioserv = AlterarTipo<string>(leitor["Usuarioserv"]);
        _utilizacontrolebiometrico = AlterarTipo<string>(leitor["Utilizacontrolebiometrico"]);
        _utilizacredicmsestcustocont = AlterarTipo<string>(leitor["Utilizacredicmsestcustocont"]);
        _utilizacte = AlterarTipo<string>(leitor["Utilizacte"]);
        _utilizanfe = AlterarTipo<string>(leitor["Utilizanfe"]);
        _utilizaorigemvendanf = AlterarTipo<string>(leitor["Utilizaorigemvendanf"]);
        _utilizapercbaseredoutrasdesppf = AlterarTipo<string>(leitor["Utilizapercbaseredoutrasdesppf"]);
        _utilizaseqnfent = AlterarTipo<string>(leitor["Utilizaseqnfent"]);
        _utilizavendaassistida = AlterarTipo<string>(leitor["Utilizavendaassistida"]);
        _utilizavendaporembalagem = AlterarTipo<string>(leitor["Utilizavendaporembalagem"]);
        _validaendpickingpedcompra = AlterarTipo<string>(leitor["Validaendpickingpedcompra"]);
        _validardescflexautoserv = AlterarTipo<string>(leitor["Validardescflexautoserv"]);
        _validarendapanhaautoservico = AlterarTipo<string>(leitor["Validarendapanhaautoservico"]);
        _validarprecovendatv20 = AlterarTipo<string>(leitor["Validarprecovendatv20"]);
        _validarprecovendatv8 = AlterarTipo<string>(leitor["Validarprecovendatv8"]);
        _validavlmaxisencaostpf = AlterarTipo<string>(leitor["Validavlmaxisencaostpf"]);
        _valorcapital = AlterarTipo<decimal?>(leitor["Valorcapital"]);
        _versaowms = AlterarTipo<decimal?>(leitor["Versaowms"]);
        _vlmaxisencaostpf = AlterarTipo<decimal?>(leitor["Vlmaxisencaostpf"]);
        _vlmaxtarifabanc = AlterarTipo<decimal?>(leitor["Vlmaxtarifabanc"]);
        _vlmintarifabanc = AlterarTipo<decimal?>(leitor["Vlmintarifabanc"]);
        _vlpaletedescarg = AlterarTipo<decimal?>(leitor["Vlpaletedescarg"]);
        _vlpesodescarga = AlterarTipo<decimal?>(leitor["Vlpesodescarga"]);
        _vlpesodescargapal = AlterarTipo<decimal?>(leitor["Vlpesodescargapal"]);
        _vlremontedescarga = AlterarTipo<decimal?>(leitor["Vlremontedescarga"]);
        _vltarifa = AlterarTipo<decimal?>(leitor["Vltarifa"]);
        _vlvoldescarga = AlterarTipo<decimal?>(leitor["Vlvoldescarga"]);
        _vlvolumedescargafd = AlterarTipo<decimal?>(leitor["Vlvolumedescargafd"]);
        _utilizarecalculostcheckout = AlterarTipo<string>(leitor["Utilizarecalculostcheckout"]);
    }

}