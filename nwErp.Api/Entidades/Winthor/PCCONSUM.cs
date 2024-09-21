

////// namespace nwErp.Entidades.Winthor;

// namespace nwErp.Api.Modelos;

[Serializable]
public class PCCONSUM : GerenteDePropriedades, IEntidade
{
    private static readonly string RO_ABASTCORRETIVOAUTOMAT = "Abastcorretivoautomat";

    private string _abastcorretivoautomat;

    private static readonly string RO_ABATEFRETEPRECOMINIMO = "Abatefreteprecominimo";

    private string _abatefreteprecominimo;

    private static readonly string RO_ABATEFRETEVENDABALCAO = "Abatefretevendabalcao";

    private string _abatefretevendabalcao;

    private static readonly string RO_ABATERDESCFINCOMISSAORCA = "Abaterdescfincomissaorca";

    private string _abaterdescfincomissaorca;

    private static readonly string RO_ABATERIMPOSTOSCOMISSAORCA = "Abaterimpostoscomissaorca";

    private string _abaterimpostoscomissaorca;

    private static readonly string RO_ABATERIMPOSTOSDESCFIN = "Abaterimpostosdescfin";

    private string _abaterimpostosdescfin;

    private static readonly string RO_ACEITAACRESCIMOPRECOFIXO = "Aceitaacrescimoprecofixo";

    private string _aceitaacrescimoprecofixo;

    private static readonly string RO_ACEITABKTV3 = "Aceitabktv3";

    private string _aceitabktv3;

    private static readonly string RO_ACEITACNPJEXCLUSIVOFORNEC = "Aceitacnpjexclusivofornec";

    private string _aceitacnpjexclusivofornec;

    private static readonly string RO_ACEITADESCBALCAORESERVA = "Aceitadescbalcaoreserva";

    private string _aceitadescbalcaoreserva;

    private static readonly string RO_ACEITADESCFLEXPRODMONITORADO = "Aceitadescflexprodmonitorado";

    private string _aceitadescflexprodmonitorado;

    private static readonly string RO_ACEITADESCPRECOFIXO = "Aceitadescprecofixo";

    private string _aceitadescprecofixo;

    private static readonly string RO_ACEITADESCPRECOFIXOCESTA = "Aceitadescprecofixocesta";

    private string _aceitadescprecofixocesta;

    private static readonly string RO_ACEITADESCTMK = "Aceitadesctmk";

    private string _aceitadesctmk;

    private static readonly string RO_ACEITADESDCONSUMIDOROUTROSCLI = "Aceitadesdconsumidoroutroscli";

    private string _aceitadesdconsumidoroutroscli;

    private static readonly string RO_ACEITAPFCONTRIBUINTE = "Aceitapfcontribuinte";

    private string _aceitapfcontribuinte;

    private static readonly string RO_ACEITAVENDAALTUSUR = "Aceitavendaaltusur";

    private string _aceitavendaaltusur;

    private static readonly string RO_ACEITAVENDABALCAOESTNEG = "Aceitavendabalcaoestneg";

    private string _aceitavendabalcaoestneg;

    private static readonly string RO_ACEITAVENDABLOQ = "Aceitavendabloq";

    private string _aceitavendabloq;

    private static readonly string RO_ACEITAVENDAPF = "Aceitavendapf";

    private string _aceitavendapf;

    private static readonly string RO_ACEITAVENDASEMEST = "Aceitavendasemest";

    private string _aceitavendasemest;

    private static readonly string RO_ACERTOCARGAFILIALDIFERENTE = "Acertocargafilialdiferente";

    private string _acertocargafilialdiferente;

    private static readonly string RO_ACRESCIMOPFCOMIE = "Acrescimopfcomie";

    private string _acrescimopfcomie;

    private static readonly string RO_AGREGARSTPRODSINTEGRA = "Agregarstprodsintegra";

    private string _agregarstprodsintegra;

    private static readonly string RO_ALIQICMINTEROUTRASDESP = "Aliqicminteroutrasdesp";

    private decimal? _aliqicminteroutrasdesp;

    private static readonly string RO_ALIQICMOUTRASDESP = "Aliqicmoutrasdesp";

    private decimal? _aliqicmoutrasdesp;

    private static readonly string RO_ALTERARCONTAAJUSTEEST = "Alterarcontaajusteest";

    private string _alterarcontaajusteest;

    private static readonly string RO_ALTERARFILIALENTPA = "Alterarfilialentpa";

    private string _alterarfilialentpa;

    private static readonly string RO_ALTERARNUMSEQPEDIDO = "Alterarnumseqpedido";

    private string _alterarnumseqpedido;

    private static readonly string RO_ALTERARPRECOPLPAGAMENTO = "Alterarprecoplpagamento";

    private string _alterarprecoplpagamento;

    private static readonly string RO_APENASMIUDEZACHEKOUTCARREG = "Apenasmiudezachekoutcarreg";

    private string _apenasmiudezachekoutcarreg;

    private static readonly string RO_APLICAACRESCPFTV3 = "Aplicaacrescpftv3";

    private string _aplicaacrescpftv3;

    private static readonly string RO_APLICAREPASSEPERCBONIFIC = "Aplicarepassepercbonific";

    private string _aplicarepassepercbonific;

    private static readonly string RO_APLICARINDICECMV = "Aplicarindicecmv";

    private string _aplicarindicecmv;

    private static readonly string RO_APLICATXFIMAUTORIZACAO = "Aplicatxfimautorizacao";

    private string _aplicatxfimautorizacao;

    private static readonly string RO_AREADEAPANHA = "Areadeapanha";

    private string _areadeapanha;

    private static readonly string RO_ATUALIZACLIULTALTER1203 = "Atualizacliultalter1203";

    private string _atualizacliultalter1203;

    private static readonly string RO_ATUALIZACONDCOMPEDCOMPRA = "Atualizacondcompedcompra";

    private string _atualizacondcompedcompra;

    private static readonly string RO_ATUALIZACUSTOULTENTRANSF = "Atualizacustoultentransf";

    private string _atualizacustoultentransf;

    private static readonly string RO_ATUALIZAENT1122 = "Atualizaent1122";

    private string _atualizaent1122;

    private static readonly string RO_ATUALIZAESTCONTCONVEMBALAGEM = "Atualizaestcontconvembalagem";

    private string _atualizaestcontconvembalagem;

    private static readonly string RO_ATUALIZARPCPRODUTBONIFIC = "Atualizarpcprodutbonific";

    private string _atualizarpcprodutbonific;

    private static readonly string RO_AUTENTICARACERTOCX = "Autenticaracertocx";

    private string _autenticaracertocx;

    private static readonly string RO_AUTENTICARDOC = "Autenticardoc";

    private string _autenticardoc;

    private static readonly string RO_AVISAFALTAEST = "Avisafaltaest";

    private string _avisafaltaest;

    private static readonly string RO_BAIXAMPNAENTPA = "Baixampnaentpa";

    private string _baixampnaentpa;

    private static readonly string RO_BAIXARDNICOMLANCAMENTO = "Baixardnicomlancamento";

    private string _baixardnicomlancamento;

    private static readonly string RO_BASECREDDEBRCAAUTORI = "Basecreddebrcaautori";

    private string _basecreddebrcaautori;

    private static readonly string RO_BIOMETRIAPARTICIPASORTEIOBIRO = "Biometriaparticipasorteiobiro";

    private string _biometriaparticipasorteiobiro;

    private static readonly string RO_BLOQAPLICPERCMANUTINV = "Bloqaplicpercmanutinv";

    private string _bloqaplicpercmanutinv;

    private static readonly string RO_BLOQCLIAUT = "Bloqcliaut";

    private string _bloqcliaut;

    private static readonly string RO_BLOQCLIENTEEXCDEVOL = "Bloqclienteexcdevol";

    private string _bloqclienteexcdevol;

    private static readonly string RO_BLOQCODCLIPRINC = "Bloqcodcliprinc";

    private string _bloqcodcliprinc;

    private static readonly string RO_BLOQCONSISTENUMMAPA = "Bloqconsistenummapa";

    private string _bloqconsistenummapa;

    private static readonly string RO_BLOQDESPVLRORC = "Bloqdespvlrorc";

    private string _bloqdespvlrorc;

    private static readonly string RO_BLOQDEVCLI = "Bloqdevcli";

    private string _bloqdevcli;

    private static readonly string RO_BLOQESTOQUETRANSF = "Bloqestoquetransf";

    private string _bloqestoquetransf;

    private static readonly string RO_BLOQFORNECVERBASVENCIDAS = "Bloqfornecverbasvencidas";

    private string _bloqfornecverbasvencidas;

    private static readonly string RO_BLOQF6PEDVENDABALCAO = "Bloqf6pedvendabalcao";

    private string _bloqf6pedvendabalcao;

    private static readonly string RO_BLOQHISTORICOFIN = "Bloqhistoricofin";

    private string _bloqhistoricofin;

    private static readonly string RO_BLOQITENSCORTE936 = "Bloqitenscorte936";

    private string _bloqitenscorte936;

    private static readonly string RO_BLOQLIBPEDCOMDESCONTO = "Bloqlibpedcomdesconto";

    private string _bloqlibpedcomdesconto;

    private static readonly string RO_BLOQLIBPEDMARGEMNEG = "Bloqlibpedmargemneg";

    private string _bloqlibpedmargemneg;

    private static readonly string RO_BLOQPEDLIMCRED = "Bloqpedlimcred";

    private string _bloqpedlimcred;

    private static readonly string RO_BLOQPRAZOMDVENDA = "Bloqprazomdvenda";

    private string _bloqprazomdvenda;

    private static readonly string RO_BLOQUEAPRODENT = "Bloqueaprodent";

    private string _bloqueaprodent;

    private static readonly string RO_BLOQUEARENDINVENT = "Bloquearendinvent";

    private string _bloquearendinvent;

    private static readonly string RO_BLOQUEARENTPA = "Bloquearentpa";

    private string _bloquearentpa;

    private static readonly string RO_BLOQUEARPEDBONIFIC = "Bloquearpedbonific";

    private string _bloquearpedbonific;

    private static readonly string RO_BLOQUEIAVENDAESTPENDENTE = "Bloqueiavendaestpendente";

    private string _bloqueiavendaestpendente;

    private static readonly string RO_BLOQUEIO = "Bloqueio";

    private string _bloqueio;

    private static readonly string RO_BLOQVENDATP1TPF = "Bloqvendatp1tpf";

    private string _bloqvendatp1tpf;

    private static readonly string RO_BONIFICALTDEBCREDRCA = "Bonificaltdebcredrca";

    private string _bonificaltdebcredrca;

    private static readonly string RO_BROKERALTDEBCREDRCA = "Brokeraltdebcredrca";

    private string _brokeraltdebcredrca;

    private static readonly string RO_CALCCREDICMS = "Calccredicms";

    private string _calccredicms;

    private static readonly string RO_CALCCREDPISCOFINS = "Calccredpiscofins";

    private string _calccredpiscofins;

    private static readonly string RO_CALCFRETEPORITEM = "Calcfreteporitem";

    private string _calcfreteporitem;

    private static readonly string RO_CALCICMSFOMEZERO = "Calcicmsfomezero";

    private string _calcicmsfomezero;

    private static readonly string RO_CALCIOFVENDORCOMPOSTO = "Calciofvendorcomposto";

    private string _calciofvendorcomposto;

    private static readonly string RO_CALCJUROSDESD = "Calcjurosdesd";

    private string _calcjurosdesd;

    private static readonly string RO_CALCSTFONTEPF = "Calcstfontepf";

    private string _calcstfontepf;

    private static readonly string RO_CALCSTPF = "Calcstpf";

    private string _calcstpf;

    private static readonly string RO_CALCULACUSTOENTPA = "Calculacustoentpa";

    private string _calculacustoentpa;

    private static readonly string RO_CALCULAGIROTRANSF = "Calculagirotransf";

    private string _calculagirotransf;

    private static readonly string RO_CALCULARSTCOMIPI = "Calcularstcomipi";

    private string _calcularstcomipi;

    private static readonly string RO_CAMINHODIR = "Caminhodir";

    private string _caminhodir;

    private static readonly string RO_CARTAOPARTICIPASORTEIOBIRO = "Cartaoparticipasorteiobiro";

    private string _cartaoparticipasorteiobiro;

    private static readonly string RO_CEP = "Cep";

    private string _cep;

    private static readonly string RO_CFOP5929ISENTO = "Cfop5929isento";

    private string _cfop5929isento;

    private static readonly string RO_CGC = "Cgc";

    private string _cgc;

    private static readonly string RO_CGCCLIEXCLUSIVO = "Cgccliexclusivo";

    private string _cgccliexclusivo;

    private static readonly string RO_CHECARDIASUTEISTITPGNLIB = "Checardiasuteistitpgnlib";

    private string _checardiasuteistitpgnlib;

    private static readonly string RO_CHECKOUTMAPAEMITIDO = "Checkoutmapaemitido";

    private string _checkoutmapaemitido;

    private static readonly string RO_CIDADE = "Cidade";

    private string _cidade;

    private static readonly string RO_CLASSECOMISPADRAO = "Classecomispadrao";

    private string _classecomispadrao;

    private static readonly string RO_CLIIBGEOBRG = "Cliibgeobrg";

    private string _cliibgeobrg;

    private static readonly string RO_CLIIPIOBRG = "Cliipiobrg";

    private string _cliipiobrg;

    private static readonly string RO_COBRARVLTARIFAPARC1 = "Cobrarvltarifaparc1";

    private string _cobrarvltarifaparc1;

    private static readonly string RO_CODCLICONSUMIDOR = "Codcliconsumidor";

    private decimal? _codcliconsumidor;

    private static readonly string RO_CODCLIPC = "Codclipc";

    private decimal? _codclipc;

    private static readonly string RO_CODCOBINICIAL = "Codcobinicial";

    private string _codcobinicial;

    private static readonly string RO_CODCOBRANCADESCFINANCEIRO = "Codcobrancadescfinanceiro";

    private string _codcobrancadescfinanceiro;

    private static readonly string RO_CODCONTAADIANTFOR = "Codcontaadiantfor";

    private decimal? _codcontaadiantfor;

    private static readonly string RO_CODCONTAADIANTFOROUTROS = "Codcontaadiantforoutros";

    private decimal? _codcontaadiantforoutros;

    private static readonly string RO_CODCONTAAMOSTRAS = "Codcontaamostras";

    private decimal? _codcontaamostras;

    private static readonly string RO_CODCONTABENEFIC = "Codcontabenefic";

    private decimal? _codcontabenefic;

    private static readonly string RO_CODCONTABILCF = "Codcontabilcf";

    private string _codcontabilcf;

    private static readonly string RO_CODCONTACAMBIAL = "Codcontacambial";

    private decimal? _codcontacambial;

    private static readonly string RO_CODCONTACOMISSAO = "Codcontacomissao";

    private decimal? _codcontacomissao;

    private static readonly string RO_CODCONTACOMISSAO3 = "Codcontacomissao3";

    private decimal? _codcontacomissao3;

    private static readonly string RO_CODCONTACUSTOSCARTORIO = "Codcontacustoscartorio";

    private decimal? _codcontacustoscartorio;

    private static readonly string RO_CODCONTADESCCR = "Codcontadesccr";

    private decimal? _codcontadesccr;

    private static readonly string RO_CODCONTADESENVOLVIMENTO = "Codcontadesenvolvimento";

    private decimal? _codcontadesenvolvimento;

    private static readonly string RO_CODCONTADESPESAPRODUCAO = "Codcontadespesaproducao";

    private decimal? _codcontadespesaproducao;

    private static readonly string RO_CODCONTADESPOS = "Codcontadespos";

    private decimal? _codcontadespos;

    private static readonly string RO_CODCONTADEVCLI = "Codcontadevcli";

    private decimal? _codcontadevcli;

    private static readonly string RO_CODCONTAFALTACAIXA = "Codcontafaltacaixa";

    private decimal? _codcontafaltacaixa;

    private static readonly string RO_CODCONTAGNRE = "Codcontagnre";

    private decimal? _codcontagnre;

    private static readonly string RO_CODCONTAGUIAST = "Codcontaguiast";

    private decimal? _codcontaguiast;

    private static readonly string RO_CODCONTAJUSTEEST = "Codcontajusteest";

    private decimal? _codcontajusteest;

    private static readonly string RO_CODCONTALP = "Codcontalp";

    private decimal? _codcontalp;

    private static readonly string RO_CODCONTAMANUTCUSTO = "Codcontamanutcusto";

    private decimal? _codcontamanutcusto;

    private static readonly string RO_CODCONTANTPAG = "Codcontantpag";

    private decimal? _codcontantpag;

    private static readonly string RO_CODCONTAPERDA = "Codcontaperda";

    private decimal? _codcontaperda;

    private static readonly string RO_CODCONTAPERDAESTOQUE = "Codcontaperdaestoque";

    private decimal? _codcontaperdaestoque;

    private static readonly string RO_CODCONTAPRODUCAO = "Codcontaproducao";

    private decimal? _codcontaproducao;

    private static readonly string RO_CODCONTAQUALIDADE = "Codcontaqualidade";

    private decimal? _codcontaqualidade;

    private static readonly string RO_CODCONTAREBAIXACMV = "Codcontarebaixacmv";

    private decimal? _codcontarebaixacmv;

    private static readonly string RO_CODCONTAREBAIXACMVAAPURAR = "Codcontarebaixacmvaapurar";

    private decimal? _codcontarebaixacmvaapurar;

    private static readonly string RO_CODCONTAREBAIXACUSTO = "Codcontarebaixacusto";

    private decimal? _codcontarebaixacusto;

    private static readonly string RO_CODCONTARECDESCARGA = "Codcontarecdescarga";

    private decimal? _codcontarecdescarga;

    private static readonly string RO_CODCONTAREQMP = "Codcontareqmp";

    private decimal? _codcontareqmp;

    private static readonly string RO_CODCONTARESTCLI = "Codcontarestcli";

    private decimal? _codcontarestcli;

    private static readonly string RO_CODCONTARESTRCA = "Codcontarestrca";

    private decimal? _codcontarestrca;

    private static readonly string RO_CODCONTASOBRAACERTO = "Codcontasobraacerto";

    private decimal? _codcontasobraacerto;

    private static readonly string RO_CODCONTASOBRACAIXA = "Codcontasobracaixa";

    private decimal? _codcontasobracaixa;

    private static readonly string RO_CODCONTASOBRAMERC = "Codcontasobramerc";

    private decimal? _codcontasobramerc;

    private static readonly string RO_CODCONTATRANSFTV10 = "Codcontatransftv10";

    private decimal? _codcontatransftv10;

    private static readonly string RO_CODCONTAVERBACMV = "Codcontaverbacmv";

    private decimal? _codcontaverbacmv;

    private static readonly string RO_CODCONTAVERBAFORNEC = "Codcontaverbafornec";

    private decimal? _codcontaverbafornec;

    private static readonly string RO_CODCONTCLI = "Codcontcli";

    private decimal? _codcontcli;

    private static readonly string RO_CODCONTDEBV = "Codcontdebv";

    private decimal? _codcontdebv;

    private static readonly string RO_CODCONTDESCCONC = "Codcontdescconc";

    private decimal? _codcontdescconc;

    private static readonly string RO_CODCONTDESPORDEMSERVICO = "Codcontdespordemservico";

    private decimal? _codcontdespordemservico;

    private static readonly string RO_CODCONTDEVCLI = "Codcontdevcli";

    private decimal? _codcontdevcli;

    private static readonly string RO_CODCONTEMPREST = "Codcontemprest";

    private decimal? _codcontemprest;

    private static readonly string RO_CODCONTFOR = "Codcontfor";

    private decimal? _codcontfor;

    private static readonly string RO_CODCONTFRE = "Codcontfre";

    private decimal? _codcontfre;

    private static readonly string RO_CODCONTICMSANTECIP = "Codconticmsantecip";

    private decimal? _codconticmsantecip;

    private static readonly string RO_CODCONTOUT = "Codcontout";

    private decimal? _codcontout;

    private static readonly string RO_CODCONTPAGDIARIA = "Codcontpagdiaria";

    private decimal? _codcontpagdiaria;

    private static readonly string RO_CODCONTPAGJUR = "Codcontpagjur";

    private decimal? _codcontpagjur;

    private static readonly string RO_CODCONTRECJUR = "Codcontrecjur";

    private decimal? _codcontrecjur;

    private static readonly string RO_CODFILIALCX = "Codfilialcx";

    private string _codfilialcx;

    private static readonly string RO_CODFILIALFV = "Codfilialfv";

    private string _codfilialfv;

    private static readonly string RO_CODFISCALDEVOUTRASDESP = "Codfiscaldevoutrasdesp";

    private decimal? _codfiscaldevoutrasdesp;

    private static readonly string RO_CODFISCALFRETE = "Codfiscalfrete";

    private decimal? _codfiscalfrete;

    private static readonly string RO_CODFISCALFRETEENT = "Codfiscalfreteent";

    private decimal? _codfiscalfreteent;

    private static readonly string RO_CODFISCALINTERDEVOUTRASDESP = "Codfiscalinterdevoutrasdesp";

    private decimal? _codfiscalinterdevoutrasdesp;

    private static readonly string RO_CODFISCALINTERFRETE = "Codfiscalinterfrete";

    private decimal? _codfiscalinterfrete;

    private static readonly string RO_CODFISCALINTERFRETEENT = "Codfiscalinterfreteent";

    private decimal? _codfiscalinterfreteent;

    private static readonly string RO_CODFISCALINTEROUTRASDESP = "Codfiscalinteroutrasdesp";

    private decimal? _codfiscalinteroutrasdesp;

    private static readonly string RO_CODFISCALOUTRASDESP = "Codfiscaloutrasdesp";

    private decimal? _codfiscaloutrasdesp;

    private static readonly string RO_CODHISTADICOMIS = "Codhistadicomis";

    private decimal? _codhistadicomis;

    private static readonly string RO_CODHISTFECHCOMIS = "Codhistfechcomis";

    private decimal? _codhistfechcomis;

    private static readonly string RO_CODHISTFECHCOMISNEG = "Codhistfechcomisneg";

    private decimal? _codhistfechcomisneg;

    private static readonly string RO_CODMOTVISITAPADRAOCALLCENTER = "Codmotvisitapadraocallcenter";

    private decimal? _codmotvisitapadraocallcenter;

    private static readonly string RO_CODPLPAGAUTOMATIC = "Codplpagautomatic";

    private string _codplpagautomatic;

    private static readonly string RO_CODPLPAGINICIAL = "Codplpaginicial";

    private decimal? _codplpaginicial;

    private static readonly string RO_CODPRACAAUTOMATIC = "Codpracaautomatic";

    private string _codpracaautomatic;

    private static readonly string RO_CODSETORCALLCENTER = "Codsetorcallcenter";

    private decimal? _codsetorcallcenter;

    private static readonly string RO_CODSETORCOBRANCA = "Codsetorcobranca";

    private decimal? _codsetorcobranca;

    private static readonly string RO_CODSETORCOMPRADOR = "Codsetorcomprador";

    private decimal? _codsetorcomprador;

    private static readonly string RO_CODSETORDIRETORIA = "Codsetordiretoria";

    private decimal? _codsetordiretoria;

    private static readonly string RO_CODSETORDIRETORIO = "Codsetordiretorio";

    private decimal? _codsetordiretorio;

    private static readonly string RO_CODSETOREMBALADOR = "Codsetorembalador";

    private decimal? _codsetorembalador;

    private static readonly string RO_CODSETOREXPED = "Codsetorexped";

    private decimal? _codsetorexped;

    private static readonly string RO_CODSETORFISCALCX = "Codsetorfiscalcx";

    private decimal? _codsetorfiscalcx;

    private static readonly string RO_CODSETORMOTORISTA = "Codsetormotorista";

    private decimal? _codsetormotorista;

    private static readonly string RO_CODSETOROPERCX = "Codsetoropercx";

    private decimal? _codsetoropercx;

    private static readonly string RO_CODUSURAUTOMATIC = "Codusurautomatic";

    private string _codusurautomatic;

    private static readonly string RO_COLUNAFLUXOCXCR1 = "Colunafluxocxcr1";

    private string _colunafluxocxcr1;

    private static readonly string RO_COLUNAFLUXOCXCR2 = "Colunafluxocxcr2";

    private string _colunafluxocxcr2;

    private static readonly string RO_COLUNAFLUXOCXCR3 = "Colunafluxocxcr3";

    private string _colunafluxocxcr3;

    private static readonly string RO_COLUNAFLUXOCXCR4 = "Colunafluxocxcr4";

    private string _colunafluxocxcr4;

    private static readonly string RO_COLUNAFLUXOCXCR5 = "Colunafluxocxcr5";

    private string _colunafluxocxcr5;

    private static readonly string RO_COMISSAORCATIPOVENDA = "Comissaorcatipovenda";

    private string _comissaorcatipovenda;

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

    private static readonly string RO_CONFERINDOCARGAPEDIDO = "Conferindocargapedido";

    private string _conferindocargapedido;

    private static readonly string RO_CONSEDERACESSOPROPRIO530 = "Consederacessoproprio530";

    private string _consederacessoproprio530;

    private static readonly string RO_CONSIDERACMVDEVOLUCAO = "Consideracmvdevolucao";

    private string _consideracmvdevolucao;

    private static readonly string RO_CONSIDERAISENTOSCOMOPF = "Consideraisentoscomopf";

    private string _consideraisentoscomopf;

    private static readonly string RO_CONSIDERARICMSANTECIPCUSTO = "Consideraricmsantecipcusto";

    private string _consideraricmsantecipcusto;

    private static readonly string RO_CONSISTECNPJFORNEC = "Consistecnpjfornec";

    private string _consistecnpjfornec;

    private static readonly string RO_CONSOLIDANDO = "Consolidando";

    private string _consolidando;

    private static readonly string RO_CONSQTRESERVREBAIXACUSTO = "Consqtreservrebaixacusto";

    private string _consqtreservrebaixacusto;

    private static readonly string RO_CONTALANCPERDA = "Contalancperda";

    private decimal? _contalancperda;

    private static readonly string RO_CONTROLAEDICAOPEDIDOCOMPRA = "Controlaedicaopedidocompra";

    private string _controlaedicaopedidocompra;

    private static readonly string RO_CONTROLAPRODUTIVSEP = "Controlaprodutivsep";

    private string _controlaprodutivsep;

    private static readonly string RO_CREDENCIALPARTICIPASORTEIOBIRO = "Credencialparticipasorteiobiro";

    private string _credencialparticipasorteiobiro;

    private static readonly string RO_CRMALTDEBCREDRCA = "Crmaltdebcredrca";

    private string _crmaltdebcredrca;

    private static readonly string RO_CUSTOINDUSTRIA = "Custoindustria";

    private string _custoindustria;

    private static readonly string RO_DEDUZIRAVARIAESTCOMDEVCLI = "Deduziravariaestcomdevcli";

    private string _deduziravariaestcomdevcli;

    private static readonly string RO_DEFINIRLOTEOP = "Definirloteop";

    private string _definirloteop;

    private static readonly string RO_DEPOSITOVIRTUAL = "Depositovirtual";

    private decimal? _depositovirtual;

    private static readonly string RO_DESBLOQCLIBXTITULO = "Desbloqclibxtitulo";

    private string _desbloqclibxtitulo;

    private static readonly string RO_DESBLOQUEARPRODFIMOS = "Desbloquearprodfimos";

    private string _desbloquearprodfimos;

    private static readonly string RO_DESCVENDA = "Descvenda";

    private string _descvenda;

    private static readonly string RO_DESDCARTAOFECHCARGA = "Desdcartaofechcarga";

    private string _desdcartaofechcarga;

    private static readonly string RO_DESDOBRARCADIFERENTE = "Desdobrarcadiferente";

    private string _desdobrarcadiferente;

    private static readonly string RO_DIASANALISEDEVOL = "Diasanalisedevol";

    private decimal? _diasanalisedevol;

    private static readonly string RO_DIASBLOQFORNECVERBASVENCIDAS = "Diasbloqfornecverbasvencidas";

    private decimal? _diasbloqfornecverbasvencidas;

    private static readonly string RO_DIRARQUIVOINTEGRACAO = "Dirarquivointegracao";

    private string _dirarquivointegracao;

    private static readonly string RO_DIREXPORTACAOFV = "Direxportacaofv";

    private string _direxportacaofv;

    private static readonly string RO_DIRIMPORTACAOFV = "Dirimportacaofv";

    private string _dirimportacaofv;

    private static readonly string RO_DIRIMPORTACAOFV2 = "Dirimportacaofv2";

    private string _dirimportacaofv2;

    private static readonly string RO_DIROP = "Dirop";

    private string _dirop;

    private static readonly string RO_DIRWINTHOR = "Dirwinthor";

    private string _dirwinthor;

    private static readonly string RO_DIRWINTHORREMOTO = "Dirwinthorremoto";

    private string _dirwinthorremoto;

    private static readonly string RO_DIVIDEPRZADICIONALPARCELAS = "Divideprzadicionalparcelas";

    private string _divideprzadicionalparcelas;

    private static readonly string RO_DTATUALIZACAOBD = "Dtatualizacaobd";

    private DateTime? _dtatualizacaobd;

    private static readonly string RO_DTEXPIRACAOWINTHOR = "Dtexpiracaowinthor";

    private DateTime? _dtexpiracaowinthor;

    private static readonly string RO_DTINICIONFP = "Dtinicionfp";

    private DateTime? _dtinicionfp;

    private static readonly string RO_DTPROCESSAMENTO = "Dtprocessamento";

    private DateTime? _dtprocessamento;

    private static readonly string RO_DTPROXATU = "Dtproxatu";

    private DateTime? _dtproxatu;

    private static readonly string RO_DTPROXFECHAMES = "Dtproxfechames";

    private DateTime? _dtproxfechames;

    private static readonly string RO_DTULTIMAGERACAOSERASA = "Dtultimageracaoserasa";

    private DateTime? _dtultimageracaoserasa;

    private static readonly string RO_DTVALIDASEFAZ = "Dtvalidasefaz";

    private DateTime? _dtvalidasefaz;

    private static readonly string RO_DTVENCANTDESD = "Dtvencantdesd";

    private string _dtvencantdesd;

    private static readonly string RO_DTVENCTK = "Dtvenctk";

    private DateTime? _dtvenctk;

    private static readonly string RO_DTVENCTT = "Dtvenctt";

    private DateTime? _dtvenctt;

    private static readonly string RO_DTVIRADAWMS = "Dtviradawms";

    private DateTime? _dtviradawms;

    private static readonly string RO_DVOBRIGATORIO = "Dvobrigatorio";

    private string _dvobrigatorio;

    private static readonly string RO_EMITEPEDIDOVENDA = "Emitepedidovenda";

    private string _emitepedidovenda;

    private static readonly string RO_EMITINDOMAPA = "Emitindomapa";

    private string _emitindomapa;

    private static readonly string RO_EMPRESA = "Empresa";

    private string _empresa;

    private static readonly string RO_ENDERECACOMBONUSABERTO = "Enderecacombonusaberto";

    private string _enderecacombonusaberto;

    private static readonly string RO_ENDERECO = "Endereco";

    private string _endereco;

    private static readonly string RO_ENDERECOAPANHAFILIAL = "Enderecoapanhafilial";

    private string _enderecoapanhafilial;

    private static readonly string RO_ENTREGA_FUTURA = "Entrega_Futura";

    private string _entrega_futura;

    private static readonly string RO_ENVIAMENSRCALIBEST = "Enviamensrcalibest";

    private string _enviamensrcalibest;

    private static readonly string RO_ENVIARMSGRCACORTE = "Enviarmsgrcacorte";

    private string _enviarmsgrcacorte;

    private static readonly string RO_ESTADO = "Estado";

    private string _estado;

    private static readonly string RO_EXIBIRPVENDA = "Exibirpvenda";

    private string _exibirpvenda;

    private static readonly string RO_EXIGEDTVALIDADEBONUSRM = "Exigedtvalidadebonusrm";

    private string _exigedtvalidadebonusrm;

    private static readonly string RO_EXPEDEPALETEFECHADODIRETOBOX = "Expedepaletefechadodiretobox";

    private string _expedepaletefechadodiretobox;

    private static readonly string RO_EXPORTANDODADOS = "Exportandodados";

    private string _exportandodados;

    private static readonly string RO_FAIXAFIMTEOR = "Faixafimteor";

    private decimal? _faixafimteor;

    private static readonly string RO_FAIXAINITEOR = "Faixainiteor";

    private decimal? _faixainiteor;

    private static readonly string RO_FATURAFILIALBROKER = "Faturafilialbroker";

    private string _faturafilialbroker;

    private static readonly string RO_FAX = "Fax";

    private string _fax;

    private static readonly string RO_FAZERINSERTPCEMBALAGEM = "Fazerinsertpcembalagem";

    private string _fazerinsertpcembalagem;

    private static readonly string RO_FECHABONUSEMRECIBODESC = "Fechabonusemrecibodesc";

    private string _fechabonusemrecibodesc;

    private static readonly string RO_FECHACARREGAUTVENDABALCAO = "Fechacarregautvendabalcao";

    private string _fechacarregautvendabalcao;

    private static readonly string RO_FILIALPADRAO = "Filialpadrao";

    private string _filialpadrao;

    private static readonly string RO_FORMMAPA = "Formmapa";

    private decimal? _formmapa;

    private static readonly string RO_FRETENAOTRIBCOMOOUTRAS = "Fretenaotribcomooutras";

    private string _fretenaotribcomooutras;

    private static readonly string RO_FTP_CONEXAOPASSIVA = "Ftp_Conexaopassiva";

    private string _ftp_conexaopassiva;

    private static readonly string RO_FTP_IP = "Ftp_Ip";

    private string _ftp_ip;

    private static readonly string RO_FTP_PORTA = "Ftp_Porta";

    private decimal? _ftp_porta;

    private static readonly string RO_GERACONTASPAGARDEVCLI = "Geracontaspagardevcli";

    private string _geracontaspagardevcli;

    private static readonly string RO_GERANDOMAPA = "Gerandomapa";

    private string _gerandomapa;

    private static readonly string RO_GERANFTIPO8 = "Geranftipo8";

    private string _geranftipo8;

    private static readonly string RO_GERANUMLOTEAUTOMATICO = "Geranumloteautomatico";

    private string _geranumloteautomatico;

    private static readonly string RO_GERAPARCELAMENTOTEF = "Geraparcelamentotef";

    private string _geraparcelamentotef;

    private static readonly string RO_GERARBRINDEPEDBONIFIC = "Gerarbrindepedbonific";

    private string _gerarbrindepedbonific;

    private static readonly string RO_GERARCRECLIDEVCLI = "Gerarcreclidevcli";

    private string _gerarcreclidevcli;

    private static readonly string RO_GERARDADOSREDUCAOZ = "Gerardadosreducaoz";

    private string _gerardadosreducaoz;

    private static readonly string RO_GERARNUMLOTEAUTOMATICPA = "Gerarnumloteautomaticpa";

    private string _gerarnumloteautomaticpa;

    private static readonly string RO_GERARPCAUXLANCONTASORCAM = "Gerarpcauxlancontasorcam";

    private string _gerarpcauxlancontasorcam;

    private static readonly string RO_GERARPCFRETE = "Gerarpcfrete";

    private string _gerarpcfrete;

    private static readonly string RO_GERARPCLANCICMSANTECIP = "Gerarpclancicmsantecip";

    private string _gerarpclancicmsantecip;

    private static readonly string RO_GERARTROCOCOBDIN = "Gerartrococobdin";

    private string _gerartrococobdin;

    private static readonly string RO_GERAVALERCADEVMANIF = "Geravalercadevmanif";

    private string _geravalercadevmanif;

    private static readonly string RO_GRAVAPCMENSALTCADCLI = "Gravapcmensaltcadcli";

    private string _gravapcmensaltcadcli;

    private static readonly string RO_GRAVARCOTACAO = "Gravarcotacao";

    private string _gravarcotacao;

    private static readonly string RO_GRAVAROBSCLIENTENOPEDIDO = "Gravarobsclientenopedido";

    private string _gravarobsclientenopedido;

    private static readonly string RO_HABILITARLANCTODADOSFROTA = "Habilitarlanctodadosfrota";

    private string _habilitarlanctodadosfrota;

    private static readonly string RO_HISTFOR = "Histfor";

    private string _histfor;

    private static readonly string RO_HISTFRE = "Histfre";

    private string _histfre;

    private static readonly string RO_HISTOUT = "Histout";

    private string _histout;

    private static readonly string RO_IE = "Ie";

    private string _ie;

    private static readonly string RO_IECLIEXCLUSIVA = "Iecliexclusiva";

    private string _iecliexclusiva;

    private static readonly string RO_IMPCARTACOBJUROS = "Impcartacobjuros";

    private string _impcartacobjuros;

    private static readonly string RO_IMPORTANDOPEDIDOS = "Importandopedidos";

    private string _importandopedidos;

    private static readonly string RO_IMPQTBONUS = "Impqtbonus";

    private string _impqtbonus;

    private static readonly string RO_IMPRESSAOAUTOMATICA = "Impressaoautomatica";

    private string _impressaoautomatica;

    private static readonly string RO_IMPRIMEDESCONTOCF = "Imprimedescontocf";

    private string _imprimedescontocf;

    private static readonly string RO_IMPRIMIRESPELHOENTMERC = "Imprimirespelhoentmerc";

    private string _imprimirespelhoentmerc;

    private static readonly string RO_INCDUPJUROSDESD = "Incdupjurosdesd";

    private string _incdupjurosdesd;

    private static readonly string RO_INCLUIDESPRODAPENF = "Incluidesprodapenf";

    private string _incluidesprodapenf;

    private static readonly string RO_INCLUIRCOMISSAOCMVVENDA = "Incluircomissaocmvvenda";

    private string _incluircomissaocmvvenda;

    private static readonly string RO_INCLUIRCOMISSAOSUGPVENDACMV = "Incluircomissaosugpvendacmv";

    private string _incluircomissaosugpvendacmv;

    private static readonly string RO_INDESPELHO = "Indespelho";

    private string _indespelho;

    private static readonly string RO_INDICECUSTOTRANSF = "Indicecustotransf";

    private decimal? _indicecustotransf;

    private static readonly string RO_INFNUMVERBAPEDBONIFIC = "Infnumverbapedbonific";

    private string _infnumverbapedbonific;

    private static readonly string RO_INFORMARECEBEDORVENDA = "Informarecebedorvenda";

    private string _informarecebedorvenda;

    private static readonly string RO_INICIAROPSEMEM = "Iniciaropsemem";

    private string _iniciaropsemem;

    private static readonly string RO_INSERIRCUPOM = "Inserircupom";

    private string _inserircupom;

    private static readonly string RO_INSERIRMAPA = "Inserirmapa";

    private string _inserirmapa;

    private static readonly string RO_INSERIRREDUCAOZ = "Inserirreducaoz";

    private string _inserirreducaoz;

    private static readonly string RO_IPNFE = "Ipnfe";

    private string _ipnfe;

    private static readonly string RO_IPTABPRECO = "Iptabpreco";

    private string _iptabpreco;

    private static readonly string RO_LANCARDESPVENDORAUTOMATICO = "Lancardespvendorautomatico";

    private string _lancardespvendorautomatico;

    private static readonly string RO_LANCARFRETEXPARCELAS = "Lancarfretexparcelas";

    private string _lancarfretexparcelas;

    private static readonly string RO_LANCARSTAPENASPARC1 = "Lancarstapenasparc1";

    private string _lancarstapenasparc1;

    private static readonly string RO_LANCARVALECOMODESPESANA1268 = "Lancarvalecomodespesana1268";

    private string _lancarvalecomodespesana1268;

    private static readonly string RO_LEITURACH = "Leiturach";

    private string _leiturach;

    private static readonly string RO_LIBERAESTENTMERC = "Liberaestentmerc";

    private string _liberaestentmerc;

    private static readonly string RO_LIBERAESTFECHBONUS = "Liberaestfechbonus";

    private string _liberaestfechbonus;

    private static readonly string RO_LIBERARPEDIDOPENDENTE = "Liberarpedidopendente";

    private string _liberarpedidopendente;

    private static readonly string RO_LIMCREDINICIAL = "Limcredinicial";

    private decimal? _limcredinicial;

    private static readonly string RO_LIMCREDINICIALPF = "Limcredinicialpf";

    private decimal? _limcredinicialpf;

    private static readonly string RO_LIMITEARREDONDAMENTO = "Limitearredondamento";

    private decimal? _limitearredondamento;

    private static readonly string RO_LIMPARBASECALCENTRADA = "Limparbasecalcentrada";

    private string _limparbasecalcentrada;

    private static readonly string RO_LIMPAROBSNFDEVOL = "Limparobsnfdevol";

    private string _limparobsnfdevol;

    private static readonly string RO_MANTEMNOSSONUMBCO1210 = "Mantemnossonumbco1210";

    private string _mantemnossonumbco1210;

    private static readonly string RO_MANTEMNOSSONUMBCO402 = "Mantemnossonumbco402";

    private string _mantemnossonumbco402;

    private static readonly string RO_MARGEMMIN = "Margemmin";

    private decimal? _margemmin;

    private static readonly string RO_MARGEMPREV = "Margemprev";

    private decimal? _margemprev;

    private static readonly string RO_MAXDIASSEMVENDA = "Maxdiassemvenda";

    private decimal? _maxdiassemvenda;

    private static readonly string RO_MAXPRZMEDIODESDCP = "Maxprzmediodesdcp";

    private decimal? _maxprzmediodesdcp;

    private static readonly string RO_MENSAGEM1NF = "Mensagem1nf";

    private string _mensagem1nf;

    private static readonly string RO_MENSAGEM2NF = "Mensagem2nf";

    private string _mensagem2nf;

    private static readonly string RO_MERCADOALVO = "Mercadoalvo";

    private string _mercadoalvo;

    private static readonly string RO_MONTANDO = "Montando";

    private string _montando;

    private static readonly string RO_MOSTRARPVENDASEMST = "Mostrarpvendasemst";

    private string _mostrarpvendasemst;

    private static readonly string RO_MUDACOBCLIENTE = "Mudacobcliente";

    private string _mudacobcliente;

    private static readonly string RO_MUDACOBCLIENTEDIAS = "Mudacobclientedias";

    private decimal? _mudacobclientedias;

    private static readonly string RO_NAOGRAVARSALDOESTOQUEINVENTROT = "Naogravarsaldoestoqueinventrot";

    private string _naogravarsaldoestoqueinventrot;

    private static readonly string RO_NAOUSAENDERECOMISTO = "Naousaenderecomisto";

    private string _naousaenderecomisto;

    private static readonly string RO_NAOUSARPCCRECLICONSFINAL = "Naousarpccrecliconsfinal";

    private string _naousarpccrecliconsfinal;

    private static readonly string RO_NAOUSARPICKINGCX = "Naousarpickingcx";

    private string _naousarpickingcx;

    private static readonly string RO_NDIASEXPIRASENHA = "Ndiasexpirasenha";

    private decimal? _ndiasexpirasenha;

    private static readonly string RO_NUMAUTOMATICCLI = "Numautomaticcli";

    private string _numautomaticcli;

    private static readonly string RO_NUMAUTOMATICFOR = "Numautomaticfor";

    private string _numautomaticfor;

    private static readonly string RO_NUMAUTOMATICPROD = "Numautomaticprod";

    private string _numautomaticprod;

    private static readonly string RO_NUMCASASDECCUSTO = "Numcasasdeccusto";

    private decimal? _numcasasdeccusto;

    private static readonly string RO_NUMCASASDECESTOQUE = "Numcasasdecestoque";

    private decimal? _numcasasdecestoque;

    private static readonly string RO_NUMCASASDECINVENTARIO = "Numcasasdecinventario";

    private decimal? _numcasasdecinventario;

    private static readonly string RO_NUMCASASDECPRODUCAO = "Numcasasdecproducao";

    private decimal? _numcasasdecproducao;

    private static readonly string RO_NUMCASASDECVENDA = "Numcasasdecvenda";

    private decimal? _numcasasdecvenda;

    private static readonly string RO_NUMCUSTODIAAUTOMATIC = "Numcustodiaautomatic";

    private string _numcustodiaautomatic;

    private static readonly string RO_NUMDIASALTDTENTREGA = "Numdiasaltdtentrega";

    private decimal? _numdiasaltdtentrega;

    private static readonly string RO_NUMDIASALTERALIVRO = "Numdiasalteralivro";

    private decimal? _numdiasalteralivro;

    private static readonly string RO_NUMDIASATU = "Numdiasatu";

    private decimal? _numdiasatu;

    private static readonly string RO_NUMDIASBLOQAUTOMATIC = "Numdiasbloqautomatic";

    private decimal? _numdiasbloqautomatic;

    private static readonly string RO_NUMDIASBLOQCHP = "Numdiasbloqchp";

    private decimal? _numdiasbloqchp;

    private static readonly string RO_NUMDIASCADCLIBLOQCHDV = "Numdiascadclibloqchdv";

    private decimal? _numdiascadclibloqchdv;

    private static readonly string RO_NUMDIASCHDVBLOQCLI = "Numdiaschdvbloqcli";

    private decimal? _numdiaschdvbloqcli;

    private static readonly string RO_NUMDIASCLIINATIV = "Numdiascliinativ";

    private decimal? _numdiascliinativ;

    private static readonly string RO_NUMDIASDESBLOQCHD1 = "Numdiasdesbloqchd1";

    private decimal? _numdiasdesbloqchd1;

    private static readonly string RO_NUMDIASMAXACERTARCARGA = "Numdiasmaxacertarcarga";

    private decimal? _numdiasmaxacertarcarga;

    private static readonly string RO_NUMDIASMAXBAIXARECIBO = "Numdiasmaxbaixarecibo";

    private decimal? _numdiasmaxbaixarecibo;

    private static readonly string RO_NUMDIASMAXCANCBORDERO = "Numdiasmaxcancbordero";

    private decimal? _numdiasmaxcancbordero;

    private static readonly string RO_NUMDIASMAXCANCNFENT = "Numdiasmaxcancnfent";

    private decimal? _numdiasmaxcancnfent;

    private static readonly string RO_NUMDIASMAXCANCNFSAIDA = "Numdiasmaxcancnfsaida";

    private decimal? _numdiasmaxcancnfsaida;

    private static readonly string RO_NUMDIASMAXDESDCPAGAR = "Numdiasmaxdesdcpagar";

    private decimal? _numdiasmaxdesdcpagar;

    private static readonly string RO_NUMDIASMAXDESD1210 = "Numdiasmaxdesd1210";

    private decimal? _numdiasmaxdesd1210;

    private static readonly string RO_NUMDIASMAXDESD402 = "Numdiasmaxdesd402";

    private decimal? _numdiasmaxdesd402;

    private static readonly string RO_NUMDIASMAXEMISSAOCP = "Numdiasmaxemissaocp";

    private decimal? _numdiasmaxemissaocp;

    private static readonly string RO_NUMDIASMAXEMISSAONF = "Numdiasmaxemissaonf";

    private decimal? _numdiasmaxemissaonf;

    private static readonly string RO_NUMDIASMAXFATURA = "Numdiasmaxfatura";

    private decimal? _numdiasmaxfatura;

    private static readonly string RO_NUMDIASMAXPRORROG = "Numdiasmaxprorrog";

    private decimal? _numdiasmaxprorrog;

    private static readonly string RO_NUMDIASMAXVENDACLIINADIMPLENTE = "Numdiasmaxvendacliinadimplente";

    private decimal? _numdiasmaxvendacliinadimplente;

    private static readonly string RO_NUMDIASMINDESPPAG = "Numdiasmindesppag";

    private decimal? _numdiasmindesppag;

    private static readonly string RO_NUMDIASMINVENDABK = "Numdiasminvendabk";

    private decimal? _numdiasminvendabk;

    private static readonly string RO_NUMDIASPAGCHQCANCEL = "Numdiaspagchqcancel";

    private decimal? _numdiaspagchqcancel;

    private static readonly string RO_NUMDIASPAGTORETRO = "Numdiaspagtoretro";

    private decimal? _numdiaspagtoretro;

    private static readonly string RO_NUMDIASUTEISSEMANA = "Numdiasuteissemana";

    private decimal? _numdiasuteissemana;

    private static readonly string RO_NUMDIASUTEISTRIMESTRE = "Numdiasuteistrimestre";

    private decimal? _numdiasuteistrimestre;

    private static readonly string RO_NUMDIASVENCTITULOCOBEXT = "Numdiasvenctitulocobext";

    private decimal? _numdiasvenctitulocobext;

    private static readonly string RO_NUMDIASVENCTITULOCOBINT = "Numdiasvenctitulocobint";

    private decimal? _numdiasvenctitulocobint;

    private static readonly string RO_NUMITENSOS = "Numitensos";

    private decimal? _numitensos;

    private static readonly string RO_NUMMAXNFTRANSF = "Nummaxnftransf";

    private decimal? _nummaxnftransf;

    private static readonly string RO_NUMMAXPARCENT = "Nummaxparcent";

    private decimal? _nummaxparcent;

    private static readonly string RO_NUMMAXTITULOSPORRECIBO = "Nummaxtitulosporrecibo";

    private decimal? _nummaxtitulosporrecibo;

    private static readonly string RO_NUMORDABAS = "Numordabas";

    private decimal? _numordabas;

    private static readonly string RO_NUMREGIAOPADRAO = "Numregiaopadrao";

    private decimal? _numregiaopadrao;

    private static readonly string RO_NUMVIASFICHACP = "Numviasfichacp";

    private decimal? _numviasfichacp;

    private static readonly string RO_NUMVIASMAPASEP = "Numviasmapasep";

    private decimal? _numviasmapasep;

    private static readonly string RO_OBTERPREFERENCIACLIECF = "Obterpreferenciacliecf";

    private string _obterpreferenciacliecf;

    private static readonly string RO_ORDEMAVALIACAOCOMISSAORCA = "Ordemavaliacaocomissaorca";

    private decimal? _ordemavaliacaocomissaorca;

    private static readonly string RO_ORDEMMAPA = "Ordemmapa";

    private decimal? _ordemmapa;

    private static readonly string RO_OSRESERVANAEXECUCAO = "Osreservanaexecucao";

    private string _osreservanaexecucao;

    private static readonly string RO_PADRAOCALLCENTER = "Padraocallcenter";

    private string _padraocallcenter;

    private static readonly string RO_PASTA_RELATORIO = "Pasta_Relatorio";

    private string _pasta_relatorio;

    private static readonly string RO_PCKABASTECIDO = "Pckabastecido";

    private string _pckabastecido;

    private static readonly string RO_PEDIDOCOMPRAPORPALETE = "Pedidocompraporpalete";

    private string _pedidocompraporpalete;

    private static readonly string RO_PEDIDOPORDISTRIB = "Pedidopordistrib";

    private string _pedidopordistrib;

    private static readonly string RO_PEDVENDADEPTO = "Pedvendadepto";

    private string _pedvendadepto;

    private static readonly string RO_PERBASEREDOUTRASDESP = "Perbaseredoutrasdesp";

    private decimal? _perbaseredoutrasdesp;

    private static readonly string RO_PERBASEVEND = "Perbasevend";

    private decimal? _perbasevend;

    private static readonly string RO_PERCACRESCIMOBALCAO = "Percacrescimobalcao";

    private decimal? _percacrescimobalcao;

    private static readonly string RO_PERCACRESCIMOCUSTOFIN = "Percacrescimocustofin";

    private decimal? _percacrescimocustofin;

    private static readonly string RO_PERCACRESCIMOCUSTOREAL = "Percacrescimocustoreal";

    private decimal? _percacrescimocustoreal;

    private static readonly string RO_PERCAPANHA = "Percapanha";

    private decimal? _percapanha;

    private static readonly string RO_PERCCSRF = "Perccsrf";

    private decimal? _perccsrf;

    private static readonly string RO_PERCDIFQTENT = "Percdifqtent";

    private decimal? _percdifqtent;

    private static readonly string RO_PERCEXCESSODEVOL = "Percexcessodevol";

    private decimal? _percexcessodevol;

    private static readonly string RO_PERCICMFRETE = "Percicmfrete";

    private decimal? _percicmfrete;

    private static readonly string RO_PERCICMFRETEENT = "Percicmfreteent";

    private decimal? _percicmfreteent;

    private static readonly string RO_PERCICMINTERFRETE = "Percicminterfrete";

    private decimal? _percicminterfrete;

    private static readonly string RO_PERCICMINTERFRETEENT = "Percicminterfreteent";

    private decimal? _percicminterfreteent;

    private static readonly string RO_PERCINSS = "Percinss";

    private decimal? _percinss;

    private static readonly string RO_PERCJUROSMORA = "Percjurosmora";

    private decimal? _percjurosmora;

    private static readonly string RO_PERCLANCCREDCLI = "Perclanccredcli";

    private decimal? _perclanccredcli;

    private static readonly string RO_PERCMAXDESCCR = "Percmaxdesccr";

    private decimal? _percmaxdesccr;

    private static readonly string RO_PERCMAXDESCDESD = "Percmaxdescdesd";

    private decimal? _percmaxdescdesd;

    private static readonly string RO_PERCMAXJUROSMORA = "Percmaxjurosmora";

    private decimal? _percmaxjurosmora;

    private static readonly string RO_PERCMAXLIBESTOQUE = "Percmaxlibestoque";

    private decimal? _percmaxlibestoque;

    private static readonly string RO_PERCMINJUROSMORA = "Percminjurosmora";

    private decimal? _percminjurosmora;

    private static readonly string RO_PERCTOLERANCIAIMPUREZA = "Perctoleranciaimpureza";

    private decimal? _perctoleranciaimpureza;

    private static readonly string RO_PERCTOLERANCIAINTEIRO = "Perctoleranciainteiro";

    private decimal? _perctoleranciainteiro;

    private static readonly string RO_PERCTOLERANCIAQUEBRADO = "Perctoleranciaquebrado";

    private decimal? _perctoleranciaquebrado;

    private static readonly string RO_PERCTOLERANCIAUMIDADE = "Perctoleranciaumidade";

    private decimal? _perctoleranciaumidade;

    private static readonly string RO_PERCTOLERANCIAVERMELHO = "Perctoleranciavermelho";

    private decimal? _perctoleranciavermelho;

    private static readonly string RO_PERDESCMAXBALCAO = "Perdescmaxbalcao";

    private decimal? _perdescmaxbalcao;

    private static readonly string RO_PERDESCMEDIOVENDA = "Perdescmediovenda";

    private decimal? _perdescmediovenda;

    private static readonly string RO_PERDESCPROM = "Perdescprom";

    private decimal? _perdescprom;

    private static readonly string RO_PEREXCEDELIMCRED = "Perexcedelimcred";

    private decimal? _perexcedelimcred;

    private static readonly string RO_PERGUNTARSOMAQTPEDVENDA = "Perguntarsomaqtpedvenda";

    private string _perguntarsomaqtpedvenda;

    private static readonly string RO_PERLIMVENDAPF = "Perlimvendapf";

    private decimal? _perlimvendapf;

    private static readonly string RO_PERMAXDESCAUTOR = "Permaxdescautor";

    private decimal? _permaxdescautor;

    private static readonly string RO_PERMAXDESCITEMCF = "Permaxdescitemcf";

    private decimal? _permaxdescitemcf;

    private static readonly string RO_PERMAXDESCVENDA = "Permaxdescvenda";

    private decimal? _permaxdescvenda;

    private static readonly string RO_PERMAXDIFENTRADA = "Permaxdifentrada";

    private decimal? _permaxdifentrada;

    private static readonly string RO_PERMAXINDENIZPEDIDO = "Permaxindenizpedido";

    private decimal? _permaxindenizpedido;

    private static readonly string RO_PERMAXPCOMPRA = "Permaxpcompra";

    private decimal? _permaxpcompra;

    private static readonly string RO_PERMAXRODAPE = "Permaxrodape";

    private decimal? _permaxrodape;

    private static readonly string RO_PERMAXRODAPECHECKOUT = "Permaxrodapecheckout";

    private decimal? _permaxrodapecheckout;

    private static readonly string RO_PERMAXVENDA = "Permaxvenda";

    private decimal? _permaxvenda;

    private static readonly string RO_PERMINDIFENTRADA = "Permindifentrada";

    private decimal? _permindifentrada;

    private static readonly string RO_PERMITEALTCODCOBVENDA = "Permitealtcodcobvenda";

    private string _permitealtcodcobvenda;

    private static readonly string RO_PERMITEALTDTVENCENTMERC = "Permitealtdtvencentmerc";

    private string _permitealtdtvencentmerc;

    private static readonly string RO_PERMITEALTPLPAGVENDA = "Permitealtplpagvenda";

    private string _permitealtplpagvenda;

    private static readonly string RO_PERMITECODBARRADUPLICADO = "Permitecodbarraduplicado";

    private string _permitecodbarraduplicado;

    private static readonly string RO_PERMITECOMPRAFORNECBLOQ = "Permitecomprafornecbloq";

    private string _permitecomprafornecbloq;

    private static readonly string RO_PERMITECRDEVFORNEC = "Permitecrdevfornec";

    private string _permitecrdevfornec;

    private static readonly string RO_PERMITEDESCCR = "Permitedesccr";

    private string _permitedesccr;

    private static readonly string RO_PERMITEDEVOLREQNORMAL = "Permitedevolreqnormal";

    private string _permitedevolreqnormal;

    private static readonly string RO_PERMITEINICIAROPSEMMP = "Permiteiniciaropsemmp";

    private string _permiteiniciaropsemmp;

    private static readonly string RO_PERMITEPEDCOMPRAMULTIPLO = "Permitepedcompramultiplo";

    private string _permitepedcompramultiplo;

    private static readonly string RO_PERMITEPEDCOMPRAUNIDMASTER = "Permitepedcompraunidmaster";

    private string _permitepedcompraunidmaster;

    private static readonly string RO_PERMITEPLPAGTOSUPERIOR = "Permiteplpagtosuperior";

    private string _permiteplpagtosuperior;

    private static readonly string RO_PERMITEVARIOSPEDIDOSORCAMENTO = "Permitevariospedidosorcamento";

    private string _permitevariospedidosorcamento;

    private static readonly string RO_PERMITEVENDAECF402 = "Permitevendaecf402";

    private string _permitevendaecf402;

    private static readonly string RO_PERMITEVENDAPRODUTOPV = "Permitevendaprodutopv";

    private string _permitevendaprodutopv;

    private static readonly string RO_PERMITIRDESCRODAPECHECKOUT = "Permitirdescrodapecheckout";

    private string _permitirdescrodapecheckout;

    private static readonly string RO_PERMITIRDESDDEVCLI = "Permitirdesddevcli";

    private string _permitirdesddevcli;

    private static readonly string RO_PERMITIRDESDTITVENCSEMJUROS = "Permitirdesdtitvencsemjuros";

    private string _permitirdesdtitvencsemjuros;

    private static readonly string RO_PERMITIRDIVNFDUPLIC = "Permitirdivnfduplic";

    private string _permitirdivnfduplic;

    private static readonly string RO_PERVENDAPF = "Pervendapf";

    private decimal? _pervendapf;

    private static readonly string RO_PESOMAXPALETE = "Pesomaxpalete";

    private decimal? _pesomaxpalete;

    private static readonly string RO_PESOSUPPALETE = "Pesosuppalete";

    private decimal? _pesosuppalete;

    private static readonly string RO_PESOTRANSF = "Pesotransf";

    private decimal? _pesotransf;

    private static readonly string RO_PORTANFE = "Portanfe";

    private decimal? _portanfe;

    private static readonly string RO_PRAZOADICIONALMAX = "Prazoadicionalmax";

    private decimal? _prazoadicionalmax;

    private static readonly string RO_PRAZOEDICAOPEDIDOCOMPRA = "Prazoedicaopedidocompra";

    private decimal? _prazoedicaopedidocompra;

    private static readonly string RO_PRAZOENTREGA = "Prazoentrega";

    private decimal? _prazoentrega;

    private static readonly string RO_PRAZOFATALMED = "Prazofatalmed";

    private decimal? _prazofatalmed;

    private static readonly string RO_PRAZOMAXDTENTREGA = "Prazomaxdtentrega";

    private decimal? _prazomaxdtentrega;

    private static readonly string RO_PRAZOMAXVALIDADE = "Prazomaxvalidade";

    private decimal? _prazomaxvalidade;

    private static readonly string RO_PRAZOMINVALIDADE = "Prazominvalidade";

    private decimal? _prazominvalidade;

    private static readonly string RO_PRAZOVALIDADEORCAMENTO = "Prazovalidadeorcamento";

    private decimal? _prazovalidadeorcamento;

    private static readonly string RO_PRAZOVALIDADEPEDBALCAO = "Prazovalidadepedbalcao";

    private decimal? _prazovalidadepedbalcao;

    private static readonly string RO_PRECOPOREMBALAGEM = "Precoporembalagem";

    private string _precoporembalagem;

    private static readonly string RO_PROCNUMLISTA = "Procnumlista";

    private decimal? _procnumlista;

    private static readonly string RO_PROXCODPLPAG = "Proxcodplpag";

    private decimal? _proxcodplpag;

    private static readonly string RO_PROXCODPRACA = "Proxcodpraca";

    private decimal? _proxcodpraca;

    private static readonly string RO_PROXCODUSUR = "Proxcodusur";

    private decimal? _proxcodusur;

    private static readonly string RO_PROXNUMAPLIC = "Proxnumaplic";

    private decimal? _proxnumaplic;

    private static readonly string RO_PROXNUMBONUS = "Proxnumbonus";

    private decimal? _proxnumbonus;

    private static readonly string RO_PROXNUMBORDERO = "Proxnumbordero";

    private decimal? _proxnumbordero;

    private static readonly string RO_PROXNUMBORDEROCR = "Proxnumborderocr";

    private decimal? _proxnumborderocr;

    private static readonly string RO_PROXNUMCAR = "Proxnumcar";

    private decimal? _proxnumcar;

    private static readonly string RO_PROXNUMCLI = "Proxnumcli";

    private decimal? _proxnumcli;

    private static readonly string RO_PROXNUMCODBARRALOTE = "Proxnumcodbarralote";

    private decimal? _proxnumcodbarralote;

    private static readonly string RO_PROXNUMCONHEC = "Proxnumconhec";

    private decimal? _proxnumconhec;

    private static readonly string RO_PROXNUMCONTRATO = "Proxnumcontrato";

    private decimal? _proxnumcontrato;

    private static readonly string RO_PROXNUMCUSTODIA = "Proxnumcustodia";

    private decimal? _proxnumcustodia;

    private static readonly string RO_PROXNUMFORNEC = "Proxnumfornec";

    private decimal? _proxnumfornec;

    private static readonly string RO_PROXNUMINDENIZ = "Proxnumindeniz";

    private decimal? _proxnumindeniz;

    private static readonly string RO_PROXNUMINVENTROT = "Proxnuminventrot";

    private decimal? _proxnuminventrot;

    private static readonly string RO_PROXNUMLANC = "Proxnumlanc";

    private decimal? _proxnumlanc;

    private static readonly string RO_PROXNUMLOTE = "Proxnumlote";

    private decimal? _proxnumlote;

    private static readonly string RO_PROXNUMLOTECUSTODIA = "Proxnumlotecustodia";

    private decimal? _proxnumlotecustodia;

    private static readonly string RO_PROXNUMLOTEEM = "Proxnumloteem";

    private decimal? _proxnumloteem;

    private static readonly string RO_PROXNUMLOTEMP = "Proxnumlotemp";

    private decimal? _proxnumlotemp;

    private static readonly string RO_PROXNUMLOTENFE = "Proxnumlotenfe";

    private decimal? _proxnumlotenfe;

    private static readonly string RO_PROXNUMLOTENFEDPEC = "Proxnumlotenfedpec";

    private decimal? _proxnumlotenfedpec;

    private static readonly string RO_PROXNUMLOTEREAGENTE = "Proxnumlotereagente";

    private decimal? _proxnumlotereagente;

    private static readonly string RO_PROXNUMLOTESA = "Proxnumlotesa";

    private decimal? _proxnumlotesa;

    private static readonly string RO_PROXNUMMANIF = "Proxnummanif";

    private decimal? _proxnummanif;

    private static readonly string RO_PROXNUMNEG = "Proxnumneg";

    private decimal? _proxnumneg;

    private static readonly string RO_PROXNUMOP = "Proxnumop";

    private decimal? _proxnumop;

    private static readonly string RO_PROXNUMOPI = "Proxnumopi";

    private decimal? _proxnumopi;

    private static readonly string RO_PROXNUMORC = "Proxnumorc";

    private decimal? _proxnumorc;

    private static readonly string RO_PROXNUMORDEMTRANSF = "Proxnumordemtransf";

    private decimal? _proxnumordemtransf;

    private static readonly string RO_PROXNUMPCP = "Proxnumpcp";

    private decimal? _proxnumpcp;

    private static readonly string RO_PROXNUMPED = "Proxnumped";

    private decimal? _proxnumped;

    private static readonly string RO_PROXNUMPEDTLMK = "Proxnumpedtlmk";

    private decimal? _proxnumpedtlmk;

    private static readonly string RO_PROXNUMPESQUISA = "Proxnumpesquisa";

    private decimal? _proxnumpesquisa;

    private static readonly string RO_PROXNUMPRODUT = "Proxnumprodut";

    private decimal? _proxnumprodut;

    private static readonly string RO_PROXNUMRCA = "Proxnumrca";

    private decimal? _proxnumrca;

    private static readonly string RO_PROXNUMRPA = "Proxnumrpa";

    private decimal? _proxnumrpa;

    private static readonly string RO_PROXNUMSIMULACAOPCP = "Proxnumsimulacaopcp";

    private decimal? _proxnumsimulacaopcp;

    private static readonly string RO_PROXNUMTIRA = "Proxnumtira";

    private decimal? _proxnumtira;

    private static readonly string RO_PROXNUMTRANS = "Proxnumtrans";

    private decimal? _proxnumtrans;

    private static readonly string RO_PROXNUMTRANSAVULSA = "Proxnumtransavulsa";

    private decimal? _proxnumtransavulsa;

    private static readonly string RO_PROXNUMTRANSCRFOR = "Proxnumtranscrfor";

    private decimal? _proxnumtranscrfor;

    private static readonly string RO_PROXNUMTRANSENT = "Proxnumtransent";

    private decimal? _proxnumtransent;

    private static readonly string RO_PROXNUMTRANSOP = "Proxnumtransop";

    private decimal? _proxnumtransop;

    private static readonly string RO_PROXNUMTRANSVENDA = "Proxnumtransvenda";

    private decimal? _proxnumtransvenda;

    private static readonly string RO_PROXNUMTRANSVENDOR = "Proxnumtransvendor";

    private decimal? _proxnumtransvendor;

    private static readonly string RO_PROXNUMTRANSWMS = "Proxnumtranswms";

    private decimal? _proxnumtranswms;

    private static readonly string RO_PROXNUMTROCA = "Proxnumtroca";

    private decimal? _proxnumtroca;

    private static readonly string RO_PROXNUMVALE = "Proxnumvale";

    private decimal? _proxnumvale;

    private static readonly string RO_PROXNUMVERBA = "Proxnumverba";

    private decimal? _proxnumverba;

    private static readonly string RO_QTCHDVBLOQCLI = "Qtchdvbloqcli";

    private decimal? _qtchdvbloqcli;

    private static readonly string RO_QTDEGERLIVRO = "Qtdegerlivro";

    private decimal? _qtdegerlivro;

    private static readonly string RO_QTDEMINIMAUSOASTERISCO936 = "Qtdeminimausoasterisco936";

    private decimal? _qtdeminimausoasterisco936;

    private static readonly string RO_QTDEPARCELASIMPOSTOSFRETE = "Qtdeparcelasimpostosfrete";

    private decimal? _qtdeparcelasimpostosfrete;

    private static readonly string RO_QTMAXUNIDADEPF = "Qtmaxunidadepf";

    private decimal? _qtmaxunidadepf;

    private static readonly string RO_QTMESESCLASSESTRELAS = "Qtmesesclassestrelas";

    private decimal? _qtmesesclassestrelas;

    private static readonly string RO_QTMESESCLASSGRUPOCARTAO = "Qtmesesclassgrupocartao";

    private decimal? _qtmesesclassgrupocartao;

    private static readonly string RO_QTMESESCREDCIAP = "Qtmesescredciap";

    private decimal? _qtmesescredciap;

    private static readonly string RO_QTMESESGRUPOS = "Qtmesesgrupos";

    private decimal? _qtmesesgrupos;

    private static readonly string RO_RATEIODESCBAIXACR = "Rateiodescbaixacr";

    private string _rateiodescbaixacr;

    private static readonly string RO_REBAIXACUSTOCOMDESCFIN = "Rebaixacustocomdescfin";

    private string _rebaixacustocomdescfin;

    private static readonly string RO_REBAIXACUSTOULTENT = "Rebaixacustoultent";

    private string _rebaixacustoultent;

    private static readonly string RO_REDUCAOBCISENTA = "Reducaobcisenta";

    private string _reducaobcisenta;

    private static readonly string RO_REPLICARPRECOPOREMBALAGEM = "Replicarprecoporembalagem";

    private string _replicarprecoporembalagem;

    private static readonly string RO_RESTRINGENUMITENSNF = "Restringenumitensnf";

    private string _restringenumitensnf;

    private static readonly string RO_RESTRINGENUMVIASNF = "Restringenumviasnf";

    private string _restringenumviasnf;

    private static readonly string RO_RESTRINGENUMVIASPU = "Restringenumviaspu";

    private string _restringenumviaspu;

    private static readonly string RO_RESTRINGIRCONFERENCIALOTE = "Restringirconferencialote";

    private string _restringirconferencialote;

    private static readonly string RO_ROTINA2562EMUSO = "Rotina2562emuso";

    private decimal? _rotina2562emuso;

    private static readonly string RO_SALTARPAGINARUA = "Saltarpaginarua";

    private string _saltarpaginarua;

    private static readonly string RO_SEGMENTOSERASA = "Segmentoserasa";

    private decimal? _segmentoserasa;

    private static readonly string RO_SEMPREATUALIZAQTESTCONVEMB = "Sempreatualizaqtestconvemb";

    private string _sempreatualizaqtestconvemb;

    private static readonly string RO_SENHALOGON = "Senhalogon";

    private string _senhalogon;

    private static readonly string RO_SEPARACAOFLOWRACK = "Separacaoflowrack";

    private string _separacaoflowrack;

    private static readonly string RO_SEPARARPRODCOMRESTRICAOTRANSP = "Separarprodcomrestricaotransp";

    private string _separarprodcomrestricaotransp;

    private static readonly string RO_SIGLAESPECIE = "Siglaespecie";

    private string _siglaespecie;

    private static readonly string RO_SIGLASERIE = "Siglaserie";

    private string _siglaserie;

    private static readonly string RO_SITUACAOINICIALBLOQUEIO = "Situacaoinicialbloqueio";

    private string _situacaoinicialbloqueio;

    private static readonly string RO_SOMACOMISSAOCMV = "Somacomissaocmv";

    private string _somacomissaocmv;

    private static readonly string RO_SOMACOMPRAPREVFLUXOCX = "Somacompraprevfluxocx";

    private string _somacompraprevfluxocx;

    private static readonly string RO_SOMADESCCLIDESCPROD = "Somadescclidescprod";

    private string _somadescclidescprod;

    private static readonly string RO_SOMADESPFINITEMCF = "Somadespfinitemcf";

    private string _somadespfinitemcf;

    private static readonly string RO_SOMAICMSANTECIPDUPLIC = "Somaicmsantecipduplic";

    private string _somaicmsantecipduplic;

    private static readonly string RO_SOMAIMPOSTOSTRANSF = "Somaimpostostransf";

    private string _somaimpostostransf;

    private static readonly string RO_SOMAQTPEDVENDA = "Somaqtpedvenda";

    private string _somaqtpedvenda;

    private static readonly string RO_SOMATARIFABANCDUPLIC = "Somatarifabancduplic";

    private string _somatarifabancduplic;

    private static readonly string RO_SOMATARIFABANCNF = "Somatarifabancnf";

    private string _somatarifabancnf;

    private static readonly string RO_SOMATXBOLETO = "Somatxboleto";

    private string _somatxboleto;

    private static readonly string RO_SOMAVLTARIFAITENSNF = "Somavltarifaitensnf";

    private string _somavltarifaitensnf;

    private static readonly string RO_SOMENTECODBARRASBONUS = "Somentecodbarrasbonus";

    private string _somentecodbarrasbonus;

    private static readonly string RO_SOMENTECODBARRASCONFPED = "Somentecodbarrasconfped";

    private string _somentecodbarrasconfped;

    private static readonly string RO_SUGVENDA = "Sugvenda";

    private decimal? _sugvenda;

    private static readonly string RO_TARJAMAGNETICAOBRIGATORIA = "Tarjamagneticaobrigatoria";

    private string _tarjamagneticaobrigatoria;

    private static readonly string RO_TAXATABPR = "Taxatabpr";

    private string _taxatabpr;

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

    private static readonly string RO_TEMPMENFLOW = "Tempmenflow";

    private decimal? _tempmenflow;

    private static readonly string RO_TEMPOMAXCANCEL = "Tempomaxcancel";

    private string _tempomaxcancel;

    private static readonly string RO_TEMREPOS = "Temrepos";

    private decimal? _temrepos;

    private static readonly string RO_TIMERMSGAGENDA = "Timermsgagenda";

    private decimal? _timermsgagenda;

    private static readonly string RO_TIPOABASPREV = "Tipoabasprev";

    private string _tipoabasprev;

    private static readonly string RO_TIPOALIQOUTRASDESP = "Tipoaliqoutrasdesp";

    private string _tipoaliqoutrasdesp;

    private static readonly string RO_TIPOAPLICINDICE = "Tipoaplicindice";

    private string _tipoaplicindice;

    private static readonly string RO_TIPOAPLICREPASSE = "Tipoaplicrepasse";

    private string _tipoaplicrepasse;

    private static readonly string RO_TIPOBAIXACOBMAG = "Tipobaixacobmag";

    private decimal? _tipobaixacobmag;

    private static readonly string RO_TIPOCALCDESCARGAPAL = "Tipocalcdescargapal";

    private string _tipocalcdescargapal;

    private static readonly string RO_TIPOCALCGIRODIA = "Tipocalcgirodia";

    private string _tipocalcgirodia;

    private static readonly string RO_TIPOCALCIPI = "Tipocalcipi";

    private string _tipocalcipi;

    private static readonly string RO_TIPOCALCST = "Tipocalcst";

    private string _tipocalcst;

    private static readonly string RO_TIPOCALCSULFRAMA = "Tipocalcsulframa";

    private string _tipocalcsulframa;

    private static readonly string RO_TIPOCUSTOAJUSTE = "Tipocustoajuste";

    private string _tipocustoajuste;

    private static readonly string RO_TIPOCUSTOTRANSF = "Tipocustotransf";

    private string _tipocustotransf;

    private static readonly string RO_TIPOCUSTO1322 = "Tipocusto1322";

    private string _tipocusto1322;

    private static readonly string RO_TIPOEMBALAGEM = "Tipoembalagem";

    private string _tipoembalagem;

    private static readonly string RO_TIPOENDERECAMENTO = "Tipoenderecamento";

    private string _tipoenderecamento;

    private static readonly string RO_TIPOENTREGAPADRAOCALLCENTER = "Tipoentregapadraocallcenter";

    private string _tipoentregapadraocallcenter;

    private static readonly string RO_TIPOGERACAODADOSPCAUXPRO = "Tipogeracaodadospcauxpro";

    private string _tipogeracaodadospcauxpro;

    private static readonly string RO_TIPOINTEGRACAO = "Tipointegracao";

    private string _tipointegracao;

    private static readonly string RO_TIPOMAPAWMSVENDABALCAO = "Tipomapawmsvendabalcao";

    private string _tipomapawmsvendabalcao;

    private static readonly string RO_TIPOMASCARAENDERWMS = "Tipomascaraenderwms";

    private decimal? _tipomascaraenderwms;

    private static readonly string RO_TIPOMOVCCRCA = "Tipomovccrca";

    private string _tipomovccrca;

    private static readonly string RO_TIPONUMNFENTRADA = "Tiponumnfentrada";

    private string _tiponumnfentrada;

    private static readonly string RO_TIPOORDENACAONFSAIDA = "Tipoordenacaonfsaida";

    private string _tipoordenacaonfsaida;

    private static readonly string RO_TIPOPERIODOGIRODIA = "Tipoperiodogirodia";

    private string _tipoperiodogirodia;

    private static readonly string RO_TIPORELMAPA = "Tiporelmapa";

    private string _tiporelmapa;

    private static readonly string RO_TIPOTAXAVENDOR = "Tipotaxavendor";

    private string _tipotaxavendor;

    private static readonly string RO_TIPOTITULOSECF402 = "Tipotitulosecf402";

    private string _tipotitulosecf402;

    private static readonly string RO_TIPOTITULOSECF409 = "Tipotitulosecf409";

    private string _tipotitulosecf409;

    private static readonly string RO_TIPOTXBOLETO = "Tipotxboleto";

    private string _tipotxboleto;

    private static readonly string RO_TIPOVALORGIRODIA = "Tipovalorgirodia";

    private string _tipovalorgirodia;

    private static readonly string RO_TIPOVLMINVENDABK = "Tipovlminvendabk";

    private string _tipovlminvendabk;

    private static readonly string RO_TRATARRESTRICAOACRESCIMO = "Tratarrestricaoacrescimo";

    private string _tratarrestricaoacrescimo;

    private static readonly string RO_TRAVAVENDAPF = "Travavendapf";

    private string _travavendapf;

    private static readonly string RO_TRIBUTAFRETERATEADO = "Tributafreterateado";

    private string _tributafreterateado;

    private static readonly string RO_TROCAALTDEBCREDRCA = "Trocaaltdebcredrca";

    private string _trocaaltdebcredrca;

    private static readonly string RO_TX = "Tx";

    private decimal? _tx;

    private static readonly string RO_TXIOF = "Txiof";

    private decimal? _txiof;

    private static readonly string RO_TXVENDA = "Txvenda";

    private decimal? _txvenda;

    private static readonly string RO_TXVENDORCLI = "Txvendorcli";

    private decimal? _txvendorcli;

    private static readonly string RO_ULTNUMDATACHEQ = "Ultnumdatacheq";

    private DateTime? _ultnumdatacheq;

    private static readonly string RO_UPDATEAUTMENU = "Updateautmenu";

    private string _updateautmenu;

    private static readonly string RO_USABCRENT = "Usabcrent";

    private string _usabcrent;

    private static readonly string RO_USACANCELAMENTOAUTOMATICOECF = "Usacancelamentoautomaticoecf";

    private string _usacancelamentoautomaticoecf;

    private static readonly string RO_USACATEGORIA = "Usacategoria";

    private string _usacategoria;

    private static readonly string RO_USACESTABASICACF = "Usacestabasicacf";

    private string _usacestabasicacf;

    private static readonly string RO_USACHAVETRIPLAPCPEDI = "Usachavetriplapcpedi";

    private string _usachavetriplapcpedi;

    private static readonly string RO_USACOMISSAOECF = "Usacomissaoecf";

    private string _usacomissaoecf;

    private static readonly string RO_USACOMISSAOPORCLASSE = "Usacomissaoporclasse";

    private string _usacomissaoporclasse;

    private static readonly string RO_USACOMISSAOPORCLIENTE = "Usacomissaoporcliente";

    private string _usacomissaoporcliente;

    private static readonly string RO_USACOMISSAOPORLINHAPROD = "Usacomissaoporlinhaprod";

    private string _usacomissaoporlinhaprod;

    private static readonly string RO_USACOMISSAOPORRCA = "Usacomissaoporrca";

    private string _usacomissaoporrca;

    private static readonly string RO_USACONTROLEDERECIBOS = "Usacontrolederecibos";

    private string _usacontrolederecibos;

    private static readonly string RO_USACONTROLEEMISSAONF = "Usacontroleemissaonf";

    private string _usacontroleemissaonf;

    private static readonly string RO_USACONTROLEFORNECPEDCOMPRA = "Usacontrolefornecpedcompra";

    private string _usacontrolefornecpedcompra;

    private static readonly string RO_USACONTROLETIPOVERBA = "Usacontroletipoverba";

    private string _usacontroletipoverba;

    private static readonly string RO_USACONVERSAOEMBALAGEM = "Usaconversaoembalagem";

    private string _usaconversaoembalagem;

    private static readonly string RO_USACRECLIVENDABALCAO = "Usacreclivendabalcao";

    private string _usacreclivendabalcao;

    private static readonly string RO_USACRECLIVENDATLMKT = "Usacreclivendatlmkt";

    private string _usacreclivendatlmkt;

    private static readonly string RO_USACREDCLITODASFILIAIS = "Usacredclitodasfiliais";

    private string _usacredclitodasfiliais;

    private static readonly string RO_USACREDRCA = "Usacredrca";

    private string _usacredrca;

    private static readonly string RO_USADESCPORLINHAPROD = "Usadescporlinhaprod";

    private string _usadescporlinhaprod;

    private static readonly string RO_USADESCPORQUANT = "Usadescporquant";

    private string _usadescporquant;

    private static readonly string RO_USADTDESBLOQUEIOBLOQCLIINATIV = "Usadtdesbloqueiobloqcliinativ";

    private string _usadtdesbloqueiobloqcliinativ;

    private static readonly string RO_USADVPRODUTO = "Usadvproduto";

    private string _usadvproduto;

    private static readonly string RO_USAESTOQUEDEPFECHADO = "Usaestoquedepfechado";

    private string _usaestoquedepfechado;

    private static readonly string RO_USAFECHAMENTOCXCEGO = "Usafechamentocxcego";

    private string _usafechamentocxcego;

    private static readonly string RO_USAICMSANTECIPPVENDA = "Usaicmsantecippvenda";

    private string _usaicmsantecippvenda;

    private static readonly string RO_USALIMCREDCPF = "Usalimcredcpf";

    private string _usalimcredcpf;

    private static readonly string RO_USAMAPSEPRUA = "Usamapseprua";

    private string _usamapseprua;

    private static readonly string RO_USAMARCAPRODUTOS = "Usamarcaprodutos";

    private string _usamarcaprodutos;

    private static readonly string RO_USANEGFORNEC = "Usanegfornec";

    private string _usanegfornec;

    private static readonly string RO_USANFCOMPLEMENTARBK = "Usanfcomplementarbk";

    private string _usanfcomplementarbk;

    private static readonly string RO_USANUMCARVENDABALCAO = "Usanumcarvendabalcao";

    private string _usanumcarvendabalcao;

    private static readonly string RO_USANUMNFDEVCLI = "Usanumnfdevcli";

    private string _usanumnfdevcli;

    private static readonly string RO_USAOUTRASMOEDAS = "Usaoutrasmoedas";

    private string _usaoutrasmoedas;

    private static readonly string RO_USAPERCDIFQTENT = "Usapercdifqtent";

    private string _usapercdifqtent;

    private static readonly string RO_USAPISCOFINSPORFILIAL = "Usapiscofinsporfilial";

    private string _usapiscofinsporfilial;

    private static readonly string RO_USAPOLITICADESENHA = "Usapoliticadesenha";

    private string _usapoliticadesenha;

    private static readonly string RO_USAPOSICAOCPAGAR = "Usaposicaocpagar";

    private string _usaposicaocpagar;

    private static readonly string RO_USAPRECIFMENORMARGEMM = "Usaprecifmenormargemm";

    private string _usaprecifmenormargemm;

    private static readonly string RO_USAPRODFRACUNITARIO = "Usaprodfracunitario";

    private string _usaprodfracunitario;

    private static readonly string RO_USAPRZADICIONALVENDA = "Usaprzadicionalvenda";

    private string _usaprzadicionalvenda;

    private static readonly string RO_USAPTABELACOMOBASE = "Usaptabelacomobase";

    private string _usaptabelacomobase;

    private static readonly string RO_USARDESCONTOVENDACODBARRA = "Usardescontovendacodbarra";

    private string _usardescontovendacodbarra;

    private static readonly string RO_USAREDUCAOCOMISSAORCA = "Usareducaocomissaorca";

    private string _usareducaocomissaorca;

    private static readonly string RO_USARENDERFORNEC = "Usarenderfornec";

    private string _usarenderfornec;

    private static readonly string RO_USARMOVIMENTAHORIZONTAL = "Usarmovimentahorizontal";

    private string _usarmovimentahorizontal;

    private static readonly string RO_USARREDUCAOICMSABATRANSF = "Usarreducaoicmsabatransf";

    private string _usarreducaoicmsabatransf;

    private static readonly string RO_USARSENHAEXPIRADA = "Usarsenhaexpirada";

    private string _usarsenhaexpirada;

    private static readonly string RO_USARTRIBUTACAOTRANSFTV10 = "Usartributacaotransftv10";

    private string _usartributacaotransftv10;

    private static readonly string RO_USASALDOCONTACORRENTEDESCFIN = "Usasaldocontacorrentedescfin";

    private string _usasaldocontacorrentedescfin;

    private static readonly string RO_USASEPARACAOCXFECHADA = "Usaseparacaocxfechada";

    private string _usaseparacaocxfechada;

    private static readonly string RO_USATECLADOGERTEC = "Usatecladogertec";

    private string _usatecladogertec;

    private static readonly string RO_USATRIBENTPORUF = "Usatribentporuf";

    private string _usatribentporuf;

    private static readonly string RO_USATRIBUTACAOPORUF = "Usatributacaoporuf";

    private string _usatributacaoporuf;

    private static readonly string RO_USATROCACOMPRECOVENDA = "Usatrocacomprecovenda";

    private string _usatrocacomprecovenda;

    private static readonly string RO_USAVALORMEDIOENTRADA = "Usavalormedioentrada";

    private string _usavalormedioentrada;

    private static readonly string RO_USAVENDABALCAOCLIFILIALVIRTUAL = "Usavendabalcaoclifilialvirtual";

    private string _usavendabalcaoclifilialvirtual;

    private static readonly string RO_USAVENDEDORNATROCA = "Usavendedornatroca";

    private string _usavendedornatroca;

    private static readonly string RO_USAWMS = "Usawms";

    private string _usawms;

    private static readonly string RO_USUARIOLOGON = "Usuariologon";

    private string _usuariologon;

    private static readonly string RO_UTILIZAAUTORCPAGAR = "Utilizaautorcpagar";

    private string _utilizaautorcpagar;

    private static readonly string RO_UTILIZABOLETOPREIMPR = "Utilizaboletopreimpr";

    private string _utilizaboletopreimpr;

    private static readonly string RO_UTILIZACHECKOUT936 = "Utilizacheckout936";

    private string _utilizacheckout936;

    private static readonly string RO_UTILIZACONTROLECAIXA = "Utilizacontrolecaixa";

    private string _utilizacontrolecaixa;

    private static readonly string RO_UTILIZACONTROLELOTE = "Utilizacontrolelote";

    private string _utilizacontrolelote;

    private static readonly string RO_UTILIZACONTROLEMEDICAMENTOS = "Utilizacontrolemedicamentos";

    private string _utilizacontrolemedicamentos;

    private static readonly string RO_UTILIZAEMBMASTER = "Utilizaembmaster";

    private string _utilizaembmaster;

    private static readonly string RO_UTILIZAENDPORFILIAL = "Utilizaendporfilial";

    private string _utilizaendporfilial;

    private static readonly string RO_UTILIZAFILIALREGIAOCX = "Utilizafilialregiaocx";

    private string _utilizafilialregiaocx;

    private static readonly string RO_UTILIZAGUIAPROPRIANFENT = "Utilizaguiaproprianfent";

    private string _utilizaguiaproprianfent;

    private static readonly string RO_UTILIZALIBERACAOPEDCOMPRA = "Utilizaliberacaopedcompra";

    private string _utilizaliberacaopedcompra;

    private static readonly string RO_UTILIZAORCVENDA = "Utilizaorcvenda";

    private string _utilizaorcvenda;

    private static readonly string RO_UTILIZAPCUSURFORNEC = "Utilizapcusurfornec";

    private string _utilizapcusurfornec;

    private static readonly string RO_UTILIZAPERCBASEREDPF = "Utilizapercbaseredpf";

    private string _utilizapercbaseredpf;

    private static readonly string RO_UTILIZAPERCFINPRECOPROM = "Utilizapercfinprecoprom";

    private string _utilizapercfinprecoprom;

    private static readonly string RO_UTILIZAQTFRACIONADACONF = "Utilizaqtfracionadaconf";

    private string _utilizaqtfracionadaconf;

    private static readonly string RO_UTILIZARATEIODESPESAS = "Utilizarateiodespesas";

    private string _utilizarateiodespesas;

    private static readonly string RO_UTILIZAREMBUNITSINTEGRA = "Utilizarembunitsintegra";

    private string _utilizarembunitsintegra;

    private static readonly string RO_UTILIZAVENDAPOREMBALAGEM = "Utilizavendaporembalagem";

    private string _utilizavendaporembalagem;

    private static readonly string RO_VALIDADVCODBARRA = "Validadvcodbarra";

    private string _validadvcodbarra;

    private static readonly string RO_VALIDAESTOQUEMAPASEP = "Validaestoquemapasep";

    private string _validaestoquemapasep;

    private static readonly string RO_VALIDANUMSERIEEQUIPECF = "Validanumserieequipecf";

    private string _validanumserieequipecf;

    private static readonly string RO_VALIDAPRECOMINIMO = "Validaprecominimo";

    private string _validaprecominimo;

    private static readonly string RO_VALIDAPVENDABONIFIC = "Validapvendabonific";

    private string _validapvendabonific;

    private static readonly string RO_VALIDARESTOQUEAUTOSERVICO = "Validarestoqueautoservico";

    private string _validarestoqueautoservico;

    private static readonly string RO_VALIDARESTRICOESVENDAPORRCA = "Validarestricoesvendaporrca";

    private string _validarestricoesvendaporrca;

    private static readonly string RO_VALIDARIECONSUMIDORFINAL = "Validarieconsumidorfinal";

    private string _validarieconsumidorfinal;

    private static readonly string RO_VALIDARUFFILIAL = "Validaruffilial";

    private string _validaruffilial;

    private static readonly string RO_VALIDARVLMINVENDAAPOSCORTE = "Validarvlminvendaaposcorte";

    private string _validarvlminvendaaposcorte;

    private static readonly string RO_VALIDAVLMINVENDABALCAO = "Validavlminvendabalcao";

    private string _validavlminvendabalcao;

    private static readonly string RO_VALOR_FRETE_PADRAO = "Valor_Frete_Padrao";

    private decimal? _valor_frete_padrao;

    private static readonly string RO_VALORMAXFALTACAIXA = "Valormaxfaltacaixa";

    private decimal? _valormaxfaltacaixa;

    private static readonly string RO_VALORMINIMOCSRF = "Valorminimocsrf";

    private decimal? _valorminimocsrf;

    private static readonly string RO_VALORMINIMOINSS = "Valorminimoinss";

    private decimal? _valorminimoinss;

    private static readonly string RO_VALORMINIMOIRRF = "Valorminimoirrf";

    private decimal? _valorminimoirrf;

    private static readonly string RO_VALORSANGRIA1 = "Valorsangria1";

    private decimal? _valorsangria1;

    private static readonly string RO_VALORSANGRIA2 = "Valorsangria2";

    private decimal? _valorsangria2;

    private static readonly string RO_VERCOBRANCABLOQCLI504_16_17 = "Vercobrancabloqcli504_16_17";

    private string _vercobrancabloqcli504_16_17;

    private static readonly string RO_VERIFICADATAHORAECF = "Verificadatahoraecf";

    private string _verificadatahoraecf;

    private static readonly string RO_VERIFICADESCFINBAIXACM = "Verificadescfinbaixacm";

    private string _verificadescfinbaixacm;

    private static readonly string RO_VERIFICAESTOQUECONT = "Verificaestoquecont";

    private string _verificaestoquecont;

    private static readonly string RO_VERIFICALIMCREDCODCOBD = "Verificalimcredcodcobd";

    private string _verificalimcredcodcobd;

    private static readonly string RO_VERIFICAMARGEMLIBPEDIDO = "Verificamargemlibpedido";

    private string _verificamargemlibpedido;

    private static readonly string RO_VERIFICANIVELVENDA402 = "Verificanivelvenda402";

    private string _verificanivelvenda402;

    private static readonly string RO_VERIFICAPEDBONIFICENTNORMAL = "Verificapedbonificentnormal";

    private string _verificapedbonificentnormal;

    private static readonly string RO_VERIFICAPESOMAXPALETE = "Verificapesomaxpalete";

    private string _verificapesomaxpalete;

    private static readonly string RO_VERIFICAPICKINGARM = "Verificapickingarm";

    private string _verificapickingarm;

    private static readonly string RO_VERIFICARCLIENTESREDE = "Verificarclientesrede";

    private string _verificarclientesrede;

    private static readonly string RO_VERIFICARENDEROCUPADO = "Verificarenderocupado";

    private string _verificarenderocupado;

    private static readonly string RO_VERIFICARLIMVENDAPF = "Verificarlimvendapf";

    private string _verificarlimvendapf;

    private static readonly string RO_VERIFPERMISSAOCOBRNODESDOBR402 = "Verifpermissaocobrnodesdobr402";

    private string _verifpermissaocobrnodesdobr402;

    private static readonly string RO_VERLANCTOBCOCHQ = "Verlanctobcochq";

    private string _verlanctobcochq;

    private static readonly string RO_VIASDANFE = "Viasdanfe";

    private decimal? _viasdanfe;

    private static readonly string RO_VLBLOQCHD3 = "Vlbloqchd3";

    private decimal? _vlbloqchd3;

    private static readonly string RO_VLDIFERENCA = "Vldiferenca";

    private decimal? _vldiferenca;

    private static readonly string RO_VLMAXPEDIDOPF = "Vlmaxpedidopf";

    private decimal? _vlmaxpedidopf;

    private static readonly string RO_VLMAXTARIFABANC = "Vlmaxtarifabanc";

    private decimal? _vlmaxtarifabanc;

    private static readonly string RO_VLMAXVENDA = "Vlmaxvenda";

    private decimal? _vlmaxvenda;

    private static readonly string RO_VLMAXVENDABNF = "Vlmaxvendabnf";

    private decimal? _vlmaxvendabnf;

    private static readonly string RO_VLMAXVENDAPF = "Vlmaxvendapf";

    private decimal? _vlmaxvendapf;

    private static readonly string RO_VLMAXVENDATLMKCODCOBD = "Vlmaxvendatlmkcodcobd";

    private decimal? _vlmaxvendatlmkcodcobd;

    private static readonly string RO_VLMINCANCCUPOM = "Vlmincanccupom";

    private decimal? _vlmincanccupom;

    private static readonly string RO_VLMINCANCITEMCUPOM = "Vlmincancitemcupom";

    private decimal? _vlmincancitemcupom;

    private static readonly string RO_VLMINTARIFABANC = "Vlmintarifabanc";

    private decimal? _vlmintarifabanc;

    private static readonly string RO_VLMINVENDA = "Vlminvenda";

    private decimal? _vlminvenda;

    private static readonly string RO_VLMINVENDABK = "Vlminvendabk";

    private decimal? _vlminvendabk;

    private static readonly string RO_VLMINVENDABNF = "Vlminvendabnf";

    private decimal? _vlminvendabnf;

    private static readonly string RO_VLMINVENDATV3 = "Vlminvendatv3";

    private decimal? _vlminvendatv3;

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

    private static readonly string RO_VOLUMEPALETE = "Volumepalete";

    private decimal? _volumepalete;

    private static readonly string RO_VOLUMETRANSF = "Volumetransf";

    private decimal? _volumetransf;

    private static readonly string RO_ZERALIMCREDBLOQAUTOMATIC = "Zeralimcredbloqautomatic";

    private string _zeralimcredbloqautomatic;

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Abastcorretivoautomat
    {
        get
        {
            PropriedadeAcessada(RO_ABASTCORRETIVOAUTOMAT);
            return _abastcorretivoautomat;
        }
        set
        {
            PropriedadeModificada(RO_ABASTCORRETIVOAUTOMAT, value);
            _abastcorretivoautomat = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Abatefreteprecominimo
    {
        get
        {
            PropriedadeAcessada(RO_ABATEFRETEPRECOMINIMO);
            return _abatefreteprecominimo;
        }
        set
        {
            PropriedadeModificada(RO_ABATEFRETEPRECOMINIMO, value);
            _abatefreteprecominimo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Abatefretevendabalcao
    {
        get
        {
            PropriedadeAcessada(RO_ABATEFRETEVENDABALCAO);
            return _abatefretevendabalcao;
        }
        set
        {
            PropriedadeModificada(RO_ABATEFRETEVENDABALCAO, value);
            _abatefretevendabalcao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Abaterdescfincomissaorca
    {
        get
        {
            PropriedadeAcessada(RO_ABATERDESCFINCOMISSAORCA);
            return _abaterdescfincomissaorca;
        }
        set
        {
            PropriedadeModificada(RO_ABATERDESCFINCOMISSAORCA, value);
            _abaterdescfincomissaorca = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Abaterimpostoscomissaorca
    {
        get
        {
            PropriedadeAcessada(RO_ABATERIMPOSTOSCOMISSAORCA);
            return _abaterimpostoscomissaorca;
        }
        set
        {
            PropriedadeModificada(RO_ABATERIMPOSTOSCOMISSAORCA, value);
            _abaterimpostoscomissaorca = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Abaterimpostosdescfin
    {
        get
        {
            PropriedadeAcessada(RO_ABATERIMPOSTOSDESCFIN);
            return _abaterimpostosdescfin;
        }
        set
        {
            PropriedadeModificada(RO_ABATERIMPOSTOSDESCFIN, value);
            _abaterimpostosdescfin = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Aceitaacrescimoprecofixo
    {
        get
        {
            PropriedadeAcessada(RO_ACEITAACRESCIMOPRECOFIXO);
            return _aceitaacrescimoprecofixo;
        }
        set
        {
            PropriedadeModificada(RO_ACEITAACRESCIMOPRECOFIXO, value);
            _aceitaacrescimoprecofixo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Aceitabktv3
    {
        get
        {
            PropriedadeAcessada(RO_ACEITABKTV3);
            return _aceitabktv3;
        }
        set
        {
            PropriedadeModificada(RO_ACEITABKTV3, value);
            _aceitabktv3 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Aceitacnpjexclusivofornec
    {
        get
        {
            PropriedadeAcessada(RO_ACEITACNPJEXCLUSIVOFORNEC);
            return _aceitacnpjexclusivofornec;
        }
        set
        {
            PropriedadeModificada(RO_ACEITACNPJEXCLUSIVOFORNEC, value);
            _aceitacnpjexclusivofornec = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Aceitadescbalcaoreserva
    {
        get
        {
            PropriedadeAcessada(RO_ACEITADESCBALCAORESERVA);
            return _aceitadescbalcaoreserva;
        }
        set
        {
            PropriedadeModificada(RO_ACEITADESCBALCAORESERVA, value);
            _aceitadescbalcaoreserva = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Aceitadescflexprodmonitorado
    {
        get
        {
            PropriedadeAcessada(RO_ACEITADESCFLEXPRODMONITORADO);
            return _aceitadescflexprodmonitorado;
        }
        set
        {
            PropriedadeModificada(RO_ACEITADESCFLEXPRODMONITORADO, value);
            _aceitadescflexprodmonitorado = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Aceitadescprecofixo
    {
        get
        {
            PropriedadeAcessada(RO_ACEITADESCPRECOFIXO);
            return _aceitadescprecofixo;
        }
        set
        {
            PropriedadeModificada(RO_ACEITADESCPRECOFIXO, value);
            _aceitadescprecofixo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Aceitadescprecofixocesta
    {
        get
        {
            PropriedadeAcessada(RO_ACEITADESCPRECOFIXOCESTA);
            return _aceitadescprecofixocesta;
        }
        set
        {
            PropriedadeModificada(RO_ACEITADESCPRECOFIXOCESTA, value);
            _aceitadescprecofixocesta = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Aceitadesctmk
    {
        get
        {
            PropriedadeAcessada(RO_ACEITADESCTMK);
            return _aceitadesctmk;
        }
        set
        {
            PropriedadeModificada(RO_ACEITADESCTMK, value);
            _aceitadesctmk = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Aceitadesdconsumidoroutroscli
    {
        get
        {
            PropriedadeAcessada(RO_ACEITADESDCONSUMIDOROUTROSCLI);
            return _aceitadesdconsumidoroutroscli;
        }
        set
        {
            PropriedadeModificada(RO_ACEITADESDCONSUMIDOROUTROSCLI, value);
            _aceitadesdconsumidoroutroscli = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Aceitapfcontribuinte
    {
        get
        {
            PropriedadeAcessada(RO_ACEITAPFCONTRIBUINTE);
            return _aceitapfcontribuinte;
        }
        set
        {
            PropriedadeModificada(RO_ACEITAPFCONTRIBUINTE, value);
            _aceitapfcontribuinte = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Aceitavendaaltusur
    {
        get
        {
            PropriedadeAcessada(RO_ACEITAVENDAALTUSUR);
            return _aceitavendaaltusur;
        }
        set
        {
            PropriedadeModificada(RO_ACEITAVENDAALTUSUR, value);
            _aceitavendaaltusur = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Aceitavendabalcaoestneg
    {
        get
        {
            PropriedadeAcessada(RO_ACEITAVENDABALCAOESTNEG);
            return _aceitavendabalcaoestneg;
        }
        set
        {
            PropriedadeModificada(RO_ACEITAVENDABALCAOESTNEG, value);
            _aceitavendabalcaoestneg = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Aceitavendabloq
    {
        get
        {
            PropriedadeAcessada(RO_ACEITAVENDABLOQ);
            return _aceitavendabloq;
        }
        set
        {
            PropriedadeModificada(RO_ACEITAVENDABLOQ, value);
            _aceitavendabloq = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Aceitavendapf
    {
        get
        {
            PropriedadeAcessada(RO_ACEITAVENDAPF);
            return _aceitavendapf;
        }
        set
        {
            PropriedadeModificada(RO_ACEITAVENDAPF, value);
            _aceitavendapf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Acertocargafilialdiferente
    {
        get
        {
            PropriedadeAcessada(RO_ACERTOCARGAFILIALDIFERENTE);
            return _acertocargafilialdiferente;
        }
        set
        {
            PropriedadeModificada(RO_ACERTOCARGAFILIALDIFERENTE, value);
            _acertocargafilialdiferente = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Acrescimopfcomie
    {
        get
        {
            PropriedadeAcessada(RO_ACRESCIMOPFCOMIE);
            return _acrescimopfcomie;
        }
        set
        {
            PropriedadeModificada(RO_ACRESCIMOPFCOMIE, value);
            _acrescimopfcomie = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 2)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 2)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Alterarcontaajusteest
    {
        get
        {
            PropriedadeAcessada(RO_ALTERARCONTAAJUSTEEST);
            return _alterarcontaajusteest;
        }
        set
        {
            PropriedadeModificada(RO_ALTERARCONTAAJUSTEEST, value);
            _alterarcontaajusteest = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Alterarfilialentpa
    {
        get
        {
            PropriedadeAcessada(RO_ALTERARFILIALENTPA);
            return _alterarfilialentpa;
        }
        set
        {
            PropriedadeModificada(RO_ALTERARFILIALENTPA, value);
            _alterarfilialentpa = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Alterarnumseqpedido
    {
        get
        {
            PropriedadeAcessada(RO_ALTERARNUMSEQPEDIDO);
            return _alterarnumseqpedido;
        }
        set
        {
            PropriedadeModificada(RO_ALTERARNUMSEQPEDIDO, value);
            _alterarnumseqpedido = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Alterarprecoplpagamento
    {
        get
        {
            PropriedadeAcessada(RO_ALTERARPRECOPLPAGAMENTO);
            return _alterarprecoplpagamento;
        }
        set
        {
            PropriedadeModificada(RO_ALTERARPRECOPLPAGAMENTO, value);
            _alterarprecoplpagamento = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Apenasmiudezachekoutcarreg
    {
        get
        {
            PropriedadeAcessada(RO_APENASMIUDEZACHEKOUTCARREG);
            return _apenasmiudezachekoutcarreg;
        }
        set
        {
            PropriedadeModificada(RO_APENASMIUDEZACHEKOUTCARREG, value);
            _apenasmiudezachekoutcarreg = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Aplicaacrescpftv3
    {
        get
        {
            PropriedadeAcessada(RO_APLICAACRESCPFTV3);
            return _aplicaacrescpftv3;
        }
        set
        {
            PropriedadeModificada(RO_APLICAACRESCPFTV3, value);
            _aplicaacrescpftv3 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Aplicarepassepercbonific
    {
        get
        {
            PropriedadeAcessada(RO_APLICAREPASSEPERCBONIFIC);
            return _aplicarepassepercbonific;
        }
        set
        {
            PropriedadeModificada(RO_APLICAREPASSEPERCBONIFIC, value);
            _aplicarepassepercbonific = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Aplicarindicecmv
    {
        get
        {
            PropriedadeAcessada(RO_APLICARINDICECMV);
            return _aplicarindicecmv;
        }
        set
        {
            PropriedadeModificada(RO_APLICARINDICECMV, value);
            _aplicarindicecmv = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Aplicatxfimautorizacao
    {
        get
        {
            PropriedadeAcessada(RO_APLICATXFIMAUTORIZACAO);
            return _aplicatxfimautorizacao;
        }
        set
        {
            PropriedadeModificada(RO_APLICATXFIMAUTORIZACAO, value);
            _aplicatxfimautorizacao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Areadeapanha
    {
        get
        {
            PropriedadeAcessada(RO_AREADEAPANHA);
            return _areadeapanha;
        }
        set
        {
            PropriedadeModificada(RO_AREADEAPANHA, value);
            _areadeapanha = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Atualizacliultalter1203
    {
        get
        {
            PropriedadeAcessada(RO_ATUALIZACLIULTALTER1203);
            return _atualizacliultalter1203;
        }
        set
        {
            PropriedadeModificada(RO_ATUALIZACLIULTALTER1203, value);
            _atualizacliultalter1203 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Atualizacondcompedcompra
    {
        get
        {
            PropriedadeAcessada(RO_ATUALIZACONDCOMPEDCOMPRA);
            return _atualizacondcompedcompra;
        }
        set
        {
            PropriedadeModificada(RO_ATUALIZACONDCOMPEDCOMPRA, value);
            _atualizacondcompedcompra = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Atualizaent1122
    {
        get
        {
            PropriedadeAcessada(RO_ATUALIZAENT1122);
            return _atualizaent1122;
        }
        set
        {
            PropriedadeModificada(RO_ATUALIZAENT1122, value);
            _atualizaent1122 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Atualizaestcontconvembalagem
    {
        get
        {
            PropriedadeAcessada(RO_ATUALIZAESTCONTCONVEMBALAGEM);
            return _atualizaestcontconvembalagem;
        }
        set
        {
            PropriedadeModificada(RO_ATUALIZAESTCONTCONVEMBALAGEM, value);
            _atualizaestcontconvembalagem = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Atualizarpcprodutbonific
    {
        get
        {
            PropriedadeAcessada(RO_ATUALIZARPCPRODUTBONIFIC);
            return _atualizarpcprodutbonific;
        }
        set
        {
            PropriedadeModificada(RO_ATUALIZARPCPRODUTBONIFIC, value);
            _atualizarpcprodutbonific = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Autenticaracertocx
    {
        get
        {
            PropriedadeAcessada(RO_AUTENTICARACERTOCX);
            return _autenticaracertocx;
        }
        set
        {
            PropriedadeModificada(RO_AUTENTICARACERTOCX, value);
            _autenticaracertocx = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Autenticardoc
    {
        get
        {
            PropriedadeAcessada(RO_AUTENTICARDOC);
            return _autenticardoc;
        }
        set
        {
            PropriedadeModificada(RO_AUTENTICARDOC, value);
            _autenticardoc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Avisafaltaest
    {
        get
        {
            PropriedadeAcessada(RO_AVISAFALTAEST);
            return _avisafaltaest;
        }
        set
        {
            PropriedadeModificada(RO_AVISAFALTAEST, value);
            _avisafaltaest = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Baixampnaentpa
    {
        get
        {
            PropriedadeAcessada(RO_BAIXAMPNAENTPA);
            return _baixampnaentpa;
        }
        set
        {
            PropriedadeModificada(RO_BAIXAMPNAENTPA, value);
            _baixampnaentpa = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Baixardnicomlancamento
    {
        get
        {
            PropriedadeAcessada(RO_BAIXARDNICOMLANCAMENTO);
            return _baixardnicomlancamento;
        }
        set
        {
            PropriedadeModificada(RO_BAIXARDNICOMLANCAMENTO, value);
            _baixardnicomlancamento = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Basecreddebrcaautori
    {
        get
        {
            PropriedadeAcessada(RO_BASECREDDEBRCAAUTORI);
            return _basecreddebrcaautori;
        }
        set
        {
            PropriedadeModificada(RO_BASECREDDEBRCAAUTORI, value);
            _basecreddebrcaautori = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Biometriaparticipasorteiobiro
    {
        get
        {
            PropriedadeAcessada(RO_BIOMETRIAPARTICIPASORTEIOBIRO);
            return _biometriaparticipasorteiobiro;
        }
        set
        {
            PropriedadeModificada(RO_BIOMETRIAPARTICIPASORTEIOBIRO, value);
            _biometriaparticipasorteiobiro = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Bloqaplicpercmanutinv
    {
        get
        {
            PropriedadeAcessada(RO_BLOQAPLICPERCMANUTINV);
            return _bloqaplicpercmanutinv;
        }
        set
        {
            PropriedadeModificada(RO_BLOQAPLICPERCMANUTINV, value);
            _bloqaplicpercmanutinv = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Bloqcliaut
    {
        get
        {
            PropriedadeAcessada(RO_BLOQCLIAUT);
            return _bloqcliaut;
        }
        set
        {
            PropriedadeModificada(RO_BLOQCLIAUT, value);
            _bloqcliaut = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Bloqclienteexcdevol
    {
        get
        {
            PropriedadeAcessada(RO_BLOQCLIENTEEXCDEVOL);
            return _bloqclienteexcdevol;
        }
        set
        {
            PropriedadeModificada(RO_BLOQCLIENTEEXCDEVOL, value);
            _bloqclienteexcdevol = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Bloqcodcliprinc
    {
        get
        {
            PropriedadeAcessada(RO_BLOQCODCLIPRINC);
            return _bloqcodcliprinc;
        }
        set
        {
            PropriedadeModificada(RO_BLOQCODCLIPRINC, value);
            _bloqcodcliprinc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Bloqconsistenummapa
    {
        get
        {
            PropriedadeAcessada(RO_BLOQCONSISTENUMMAPA);
            return _bloqconsistenummapa;
        }
        set
        {
            PropriedadeModificada(RO_BLOQCONSISTENUMMAPA, value);
            _bloqconsistenummapa = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Bloqdespvlrorc
    {
        get
        {
            PropriedadeAcessada(RO_BLOQDESPVLRORC);
            return _bloqdespvlrorc;
        }
        set
        {
            PropriedadeModificada(RO_BLOQDESPVLRORC, value);
            _bloqdespvlrorc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Bloqfornecverbasvencidas
    {
        get
        {
            PropriedadeAcessada(RO_BLOQFORNECVERBASVENCIDAS);
            return _bloqfornecverbasvencidas;
        }
        set
        {
            PropriedadeModificada(RO_BLOQFORNECVERBASVENCIDAS, value);
            _bloqfornecverbasvencidas = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Bloqf6pedvendabalcao
    {
        get
        {
            PropriedadeAcessada(RO_BLOQF6PEDVENDABALCAO);
            return _bloqf6pedvendabalcao;
        }
        set
        {
            PropriedadeModificada(RO_BLOQF6PEDVENDABALCAO, value);
            _bloqf6pedvendabalcao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Bloqhistoricofin
    {
        get
        {
            PropriedadeAcessada(RO_BLOQHISTORICOFIN);
            return _bloqhistoricofin;
        }
        set
        {
            PropriedadeModificada(RO_BLOQHISTORICOFIN, value);
            _bloqhistoricofin = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Bloqitenscorte936
    {
        get
        {
            PropriedadeAcessada(RO_BLOQITENSCORTE936);
            return _bloqitenscorte936;
        }
        set
        {
            PropriedadeModificada(RO_BLOQITENSCORTE936, value);
            _bloqitenscorte936 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Bloqlibpedcomdesconto
    {
        get
        {
            PropriedadeAcessada(RO_BLOQLIBPEDCOMDESCONTO);
            return _bloqlibpedcomdesconto;
        }
        set
        {
            PropriedadeModificada(RO_BLOQLIBPEDCOMDESCONTO, value);
            _bloqlibpedcomdesconto = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Bloqlibpedmargemneg
    {
        get
        {
            PropriedadeAcessada(RO_BLOQLIBPEDMARGEMNEG);
            return _bloqlibpedmargemneg;
        }
        set
        {
            PropriedadeModificada(RO_BLOQLIBPEDMARGEMNEG, value);
            _bloqlibpedmargemneg = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Bloqpedlimcred
    {
        get
        {
            PropriedadeAcessada(RO_BLOQPEDLIMCRED);
            return _bloqpedlimcred;
        }
        set
        {
            PropriedadeModificada(RO_BLOQPEDLIMCRED, value);
            _bloqpedlimcred = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Bloqprazomdvenda
    {
        get
        {
            PropriedadeAcessada(RO_BLOQPRAZOMDVENDA);
            return _bloqprazomdvenda;
        }
        set
        {
            PropriedadeModificada(RO_BLOQPRAZOMDVENDA, value);
            _bloqprazomdvenda = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Bloqueaprodent
    {
        get
        {
            PropriedadeAcessada(RO_BLOQUEAPRODENT);
            return _bloqueaprodent;
        }
        set
        {
            PropriedadeModificada(RO_BLOQUEAPRODENT, value);
            _bloqueaprodent = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Bloquearendinvent
    {
        get
        {
            PropriedadeAcessada(RO_BLOQUEARENDINVENT);
            return _bloquearendinvent;
        }
        set
        {
            PropriedadeModificada(RO_BLOQUEARENDINVENT, value);
            _bloquearendinvent = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Bloquearentpa
    {
        get
        {
            PropriedadeAcessada(RO_BLOQUEARENTPA);
            return _bloquearentpa;
        }
        set
        {
            PropriedadeModificada(RO_BLOQUEARENTPA, value);
            _bloquearentpa = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Bloquearpedbonific
    {
        get
        {
            PropriedadeAcessada(RO_BLOQUEARPEDBONIFIC);
            return _bloquearpedbonific;
        }
        set
        {
            PropriedadeModificada(RO_BLOQUEARPEDBONIFIC, value);
            _bloquearpedbonific = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Bloqueiavendaestpendente
    {
        get
        {
            PropriedadeAcessada(RO_BLOQUEIAVENDAESTPENDENTE);
            return _bloqueiavendaestpendente;
        }
        set
        {
            PropriedadeModificada(RO_BLOQUEIAVENDAESTPENDENTE, value);
            _bloqueiavendaestpendente = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Bloqvendatp1tpf
    {
        get
        {
            PropriedadeAcessada(RO_BLOQVENDATP1TPF);
            return _bloqvendatp1tpf;
        }
        set
        {
            PropriedadeModificada(RO_BLOQVENDATP1TPF, value);
            _bloqvendatp1tpf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Calcfreteporitem
    {
        get
        {
            PropriedadeAcessada(RO_CALCFRETEPORITEM);
            return _calcfreteporitem;
        }
        set
        {
            PropriedadeModificada(RO_CALCFRETEPORITEM, value);
            _calcfreteporitem = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Calcicmsfomezero
    {
        get
        {
            PropriedadeAcessada(RO_CALCICMSFOMEZERO);
            return _calcicmsfomezero;
        }
        set
        {
            PropriedadeModificada(RO_CALCICMSFOMEZERO, value);
            _calcicmsfomezero = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Calciofvendorcomposto
    {
        get
        {
            PropriedadeAcessada(RO_CALCIOFVENDORCOMPOSTO);
            return _calciofvendorcomposto;
        }
        set
        {
            PropriedadeModificada(RO_CALCIOFVENDORCOMPOSTO, value);
            _calciofvendorcomposto = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Calcjurosdesd
    {
        get
        {
            PropriedadeAcessada(RO_CALCJUROSDESD);
            return _calcjurosdesd;
        }
        set
        {
            PropriedadeModificada(RO_CALCJUROSDESD, value);
            _calcjurosdesd = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Calcstfontepf
    {
        get
        {
            PropriedadeAcessada(RO_CALCSTFONTEPF);
            return _calcstfontepf;
        }
        set
        {
            PropriedadeModificada(RO_CALCSTFONTEPF, value);
            _calcstfontepf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Calcstpf
    {
        get
        {
            PropriedadeAcessada(RO_CALCSTPF);
            return _calcstpf;
        }
        set
        {
            PropriedadeModificada(RO_CALCSTPF, value);
            _calcstpf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Calculacustoentpa
    {
        get
        {
            PropriedadeAcessada(RO_CALCULACUSTOENTPA);
            return _calculacustoentpa;
        }
        set
        {
            PropriedadeModificada(RO_CALCULACUSTOENTPA, value);
            _calculacustoentpa = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Calculagirotransf
    {
        get
        {
            PropriedadeAcessada(RO_CALCULAGIROTRANSF);
            return _calculagirotransf;
        }
        set
        {
            PropriedadeModificada(RO_CALCULAGIROTRANSF, value);
            _calculagirotransf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Calcularstcomipi
    {
        get
        {
            PropriedadeAcessada(RO_CALCULARSTCOMIPI);
            return _calcularstcomipi;
        }
        set
        {
            PropriedadeModificada(RO_CALCULARSTCOMIPI, value);
            _calcularstcomipi = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 30, Precisao = 0)]
    public string Caminhodir
    {
        get
        {
            PropriedadeAcessada(RO_CAMINHODIR);
            return _caminhodir;
        }
        set
        {
            PropriedadeModificada(RO_CAMINHODIR, value);
            _caminhodir = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Cartaoparticipasorteiobiro
    {
        get
        {
            PropriedadeAcessada(RO_CARTAOPARTICIPASORTEIOBIRO);
            return _cartaoparticipasorteiobiro;
        }
        set
        {
            PropriedadeModificada(RO_CARTAOPARTICIPASORTEIOBIRO, value);
            _cartaoparticipasorteiobiro = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 9, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Cfop5929isento
    {
        get
        {
            PropriedadeAcessada(RO_CFOP5929ISENTO);
            return _cfop5929isento;
        }
        set
        {
            PropriedadeModificada(RO_CFOP5929ISENTO, value);
            _cfop5929isento = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Cgccliexclusivo
    {
        get
        {
            PropriedadeAcessada(RO_CGCCLIEXCLUSIVO);
            return _cgccliexclusivo;
        }
        set
        {
            PropriedadeModificada(RO_CGCCLIEXCLUSIVO, value);
            _cgccliexclusivo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Checardiasuteistitpgnlib
    {
        get
        {
            PropriedadeAcessada(RO_CHECARDIASUTEISTITPGNLIB);
            return _checardiasuteistitpgnlib;
        }
        set
        {
            PropriedadeModificada(RO_CHECARDIASUTEISTITPGNLIB, value);
            _checardiasuteistitpgnlib = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Checkoutmapaemitido
    {
        get
        {
            PropriedadeAcessada(RO_CHECKOUTMAPAEMITIDO);
            return _checkoutmapaemitido;
        }
        set
        {
            PropriedadeModificada(RO_CHECKOUTMAPAEMITIDO, value);
            _checkoutmapaemitido = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 15, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Classecomispadrao
    {
        get
        {
            PropriedadeAcessada(RO_CLASSECOMISPADRAO);
            return _classecomispadrao;
        }
        set
        {
            PropriedadeModificada(RO_CLASSECOMISPADRAO, value);
            _classecomispadrao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Cliibgeobrg
    {
        get
        {
            PropriedadeAcessada(RO_CLIIBGEOBRG);
            return _cliibgeobrg;
        }
        set
        {
            PropriedadeModificada(RO_CLIIBGEOBRG, value);
            _cliibgeobrg = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Cliipiobrg
    {
        get
        {
            PropriedadeAcessada(RO_CLIIPIOBRG);
            return _cliipiobrg;
        }
        set
        {
            PropriedadeModificada(RO_CLIIPIOBRG, value);
            _cliipiobrg = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Cobrarvltarifaparc1
    {
        get
        {
            PropriedadeAcessada(RO_COBRARVLTARIFAPARC1);
            return _cobrarvltarifaparc1;
        }
        set
        {
            PropriedadeModificada(RO_COBRARVLTARIFAPARC1, value);
            _cobrarvltarifaparc1 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codclipc
    {
        get
        {
            PropriedadeAcessada(RO_CODCLIPC);
            return _codclipc;
        }
        set
        {
            PropriedadeModificada(RO_CODCLIPC, value);
            _codclipc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 4, Precisao = 0)]
    public string Codcobinicial
    {
        get
        {
            PropriedadeAcessada(RO_CODCOBINICIAL);
            return _codcobinicial;
        }
        set
        {
            PropriedadeModificada(RO_CODCOBINICIAL, value);
            _codcobinicial = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 4, Precisao = 0)]
    public string Codcobrancadescfinanceiro
    {
        get
        {
            PropriedadeAcessada(RO_CODCOBRANCADESCFINANCEIRO);
            return _codcobrancadescfinanceiro;
        }
        set
        {
            PropriedadeModificada(RO_CODCOBRANCADESCFINANCEIRO, value);
            _codcobrancadescfinanceiro = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Codcontaadiantfor
    {
        get
        {
            PropriedadeAcessada(RO_CODCONTAADIANTFOR);
            return _codcontaadiantfor;
        }
        set
        {
            PropriedadeModificada(RO_CODCONTAADIANTFOR, value);
            _codcontaadiantfor = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Codcontaadiantforoutros
    {
        get
        {
            PropriedadeAcessada(RO_CODCONTAADIANTFOROUTROS);
            return _codcontaadiantforoutros;
        }
        set
        {
            PropriedadeModificada(RO_CODCONTAADIANTFOROUTROS, value);
            _codcontaadiantforoutros = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Codcontaamostras
    {
        get
        {
            PropriedadeAcessada(RO_CODCONTAAMOSTRAS);
            return _codcontaamostras;
        }
        set
        {
            PropriedadeModificada(RO_CODCONTAAMOSTRAS, value);
            _codcontaamostras = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Codcontabenefic
    {
        get
        {
            PropriedadeAcessada(RO_CODCONTABENEFIC);
            return _codcontabenefic;
        }
        set
        {
            PropriedadeModificada(RO_CODCONTABENEFIC, value);
            _codcontabenefic = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 10, Precisao = 0)]
    public string Codcontabilcf
    {
        get
        {
            PropriedadeAcessada(RO_CODCONTABILCF);
            return _codcontabilcf;
        }
        set
        {
            PropriedadeModificada(RO_CODCONTABILCF, value);
            _codcontabilcf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Codcontacambial
    {
        get
        {
            PropriedadeAcessada(RO_CODCONTACAMBIAL);
            return _codcontacambial;
        }
        set
        {
            PropriedadeModificada(RO_CODCONTACAMBIAL, value);
            _codcontacambial = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Codcontacomissao
    {
        get
        {
            PropriedadeAcessada(RO_CODCONTACOMISSAO);
            return _codcontacomissao;
        }
        set
        {
            PropriedadeModificada(RO_CODCONTACOMISSAO, value);
            _codcontacomissao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Codcontacomissao3
    {
        get
        {
            PropriedadeAcessada(RO_CODCONTACOMISSAO3);
            return _codcontacomissao3;
        }
        set
        {
            PropriedadeModificada(RO_CODCONTACOMISSAO3, value);
            _codcontacomissao3 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Codcontacustoscartorio
    {
        get
        {
            PropriedadeAcessada(RO_CODCONTACUSTOSCARTORIO);
            return _codcontacustoscartorio;
        }
        set
        {
            PropriedadeModificada(RO_CODCONTACUSTOSCARTORIO, value);
            _codcontacustoscartorio = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Codcontadesccr
    {
        get
        {
            PropriedadeAcessada(RO_CODCONTADESCCR);
            return _codcontadesccr;
        }
        set
        {
            PropriedadeModificada(RO_CODCONTADESCCR, value);
            _codcontadesccr = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Codcontadesenvolvimento
    {
        get
        {
            PropriedadeAcessada(RO_CODCONTADESENVOLVIMENTO);
            return _codcontadesenvolvimento;
        }
        set
        {
            PropriedadeModificada(RO_CODCONTADESENVOLVIMENTO, value);
            _codcontadesenvolvimento = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Codcontadespesaproducao
    {
        get
        {
            PropriedadeAcessada(RO_CODCONTADESPESAPRODUCAO);
            return _codcontadespesaproducao;
        }
        set
        {
            PropriedadeModificada(RO_CODCONTADESPESAPRODUCAO, value);
            _codcontadespesaproducao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Codcontadespos
    {
        get
        {
            PropriedadeAcessada(RO_CODCONTADESPOS);
            return _codcontadespos;
        }
        set
        {
            PropriedadeModificada(RO_CODCONTADESPOS, value);
            _codcontadespos = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Codcontadevcli
    {
        get
        {
            PropriedadeAcessada(RO_CODCONTADEVCLI);
            return _codcontadevcli;
        }
        set
        {
            PropriedadeModificada(RO_CODCONTADEVCLI, value);
            _codcontadevcli = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Codcontafaltacaixa
    {
        get
        {
            PropriedadeAcessada(RO_CODCONTAFALTACAIXA);
            return _codcontafaltacaixa;
        }
        set
        {
            PropriedadeModificada(RO_CODCONTAFALTACAIXA, value);
            _codcontafaltacaixa = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Codcontagnre
    {
        get
        {
            PropriedadeAcessada(RO_CODCONTAGNRE);
            return _codcontagnre;
        }
        set
        {
            PropriedadeModificada(RO_CODCONTAGNRE, value);
            _codcontagnre = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Codcontaguiast
    {
        get
        {
            PropriedadeAcessada(RO_CODCONTAGUIAST);
            return _codcontaguiast;
        }
        set
        {
            PropriedadeModificada(RO_CODCONTAGUIAST, value);
            _codcontaguiast = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Codcontajusteest
    {
        get
        {
            PropriedadeAcessada(RO_CODCONTAJUSTEEST);
            return _codcontajusteest;
        }
        set
        {
            PropriedadeModificada(RO_CODCONTAJUSTEEST, value);
            _codcontajusteest = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Codcontalp
    {
        get
        {
            PropriedadeAcessada(RO_CODCONTALP);
            return _codcontalp;
        }
        set
        {
            PropriedadeModificada(RO_CODCONTALP, value);
            _codcontalp = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Codcontamanutcusto
    {
        get
        {
            PropriedadeAcessada(RO_CODCONTAMANUTCUSTO);
            return _codcontamanutcusto;
        }
        set
        {
            PropriedadeModificada(RO_CODCONTAMANUTCUSTO, value);
            _codcontamanutcusto = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Codcontantpag
    {
        get
        {
            PropriedadeAcessada(RO_CODCONTANTPAG);
            return _codcontantpag;
        }
        set
        {
            PropriedadeModificada(RO_CODCONTANTPAG, value);
            _codcontantpag = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Codcontaperda
    {
        get
        {
            PropriedadeAcessada(RO_CODCONTAPERDA);
            return _codcontaperda;
        }
        set
        {
            PropriedadeModificada(RO_CODCONTAPERDA, value);
            _codcontaperda = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Codcontaperdaestoque
    {
        get
        {
            PropriedadeAcessada(RO_CODCONTAPERDAESTOQUE);
            return _codcontaperdaestoque;
        }
        set
        {
            PropriedadeModificada(RO_CODCONTAPERDAESTOQUE, value);
            _codcontaperdaestoque = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Codcontaproducao
    {
        get
        {
            PropriedadeAcessada(RO_CODCONTAPRODUCAO);
            return _codcontaproducao;
        }
        set
        {
            PropriedadeModificada(RO_CODCONTAPRODUCAO, value);
            _codcontaproducao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Codcontaqualidade
    {
        get
        {
            PropriedadeAcessada(RO_CODCONTAQUALIDADE);
            return _codcontaqualidade;
        }
        set
        {
            PropriedadeModificada(RO_CODCONTAQUALIDADE, value);
            _codcontaqualidade = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Codcontarebaixacmv
    {
        get
        {
            PropriedadeAcessada(RO_CODCONTAREBAIXACMV);
            return _codcontarebaixacmv;
        }
        set
        {
            PropriedadeModificada(RO_CODCONTAREBAIXACMV, value);
            _codcontarebaixacmv = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Codcontarebaixacmvaapurar
    {
        get
        {
            PropriedadeAcessada(RO_CODCONTAREBAIXACMVAAPURAR);
            return _codcontarebaixacmvaapurar;
        }
        set
        {
            PropriedadeModificada(RO_CODCONTAREBAIXACMVAAPURAR, value);
            _codcontarebaixacmvaapurar = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Codcontarebaixacusto
    {
        get
        {
            PropriedadeAcessada(RO_CODCONTAREBAIXACUSTO);
            return _codcontarebaixacusto;
        }
        set
        {
            PropriedadeModificada(RO_CODCONTAREBAIXACUSTO, value);
            _codcontarebaixacusto = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Codcontarecdescarga
    {
        get
        {
            PropriedadeAcessada(RO_CODCONTARECDESCARGA);
            return _codcontarecdescarga;
        }
        set
        {
            PropriedadeModificada(RO_CODCONTARECDESCARGA, value);
            _codcontarecdescarga = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Codcontareqmp
    {
        get
        {
            PropriedadeAcessada(RO_CODCONTAREQMP);
            return _codcontareqmp;
        }
        set
        {
            PropriedadeModificada(RO_CODCONTAREQMP, value);
            _codcontareqmp = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Codcontarestcli
    {
        get
        {
            PropriedadeAcessada(RO_CODCONTARESTCLI);
            return _codcontarestcli;
        }
        set
        {
            PropriedadeModificada(RO_CODCONTARESTCLI, value);
            _codcontarestcli = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Codcontarestrca
    {
        get
        {
            PropriedadeAcessada(RO_CODCONTARESTRCA);
            return _codcontarestrca;
        }
        set
        {
            PropriedadeModificada(RO_CODCONTARESTRCA, value);
            _codcontarestrca = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Codcontasobraacerto
    {
        get
        {
            PropriedadeAcessada(RO_CODCONTASOBRAACERTO);
            return _codcontasobraacerto;
        }
        set
        {
            PropriedadeModificada(RO_CODCONTASOBRAACERTO, value);
            _codcontasobraacerto = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Codcontasobracaixa
    {
        get
        {
            PropriedadeAcessada(RO_CODCONTASOBRACAIXA);
            return _codcontasobracaixa;
        }
        set
        {
            PropriedadeModificada(RO_CODCONTASOBRACAIXA, value);
            _codcontasobracaixa = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Codcontasobramerc
    {
        get
        {
            PropriedadeAcessada(RO_CODCONTASOBRAMERC);
            return _codcontasobramerc;
        }
        set
        {
            PropriedadeModificada(RO_CODCONTASOBRAMERC, value);
            _codcontasobramerc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Codcontatransftv10
    {
        get
        {
            PropriedadeAcessada(RO_CODCONTATRANSFTV10);
            return _codcontatransftv10;
        }
        set
        {
            PropriedadeModificada(RO_CODCONTATRANSFTV10, value);
            _codcontatransftv10 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Codcontaverbacmv
    {
        get
        {
            PropriedadeAcessada(RO_CODCONTAVERBACMV);
            return _codcontaverbacmv;
        }
        set
        {
            PropriedadeModificada(RO_CODCONTAVERBACMV, value);
            _codcontaverbacmv = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Codcontaverbafornec
    {
        get
        {
            PropriedadeAcessada(RO_CODCONTAVERBAFORNEC);
            return _codcontaverbafornec;
        }
        set
        {
            PropriedadeModificada(RO_CODCONTAVERBAFORNEC, value);
            _codcontaverbafornec = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Codcontdebv
    {
        get
        {
            PropriedadeAcessada(RO_CODCONTDEBV);
            return _codcontdebv;
        }
        set
        {
            PropriedadeModificada(RO_CODCONTDEBV, value);
            _codcontdebv = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Codcontdescconc
    {
        get
        {
            PropriedadeAcessada(RO_CODCONTDESCCONC);
            return _codcontdescconc;
        }
        set
        {
            PropriedadeModificada(RO_CODCONTDESCCONC, value);
            _codcontdescconc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Codcontdespordemservico
    {
        get
        {
            PropriedadeAcessada(RO_CODCONTDESPORDEMSERVICO);
            return _codcontdespordemservico;
        }
        set
        {
            PropriedadeModificada(RO_CODCONTDESPORDEMSERVICO, value);
            _codcontdespordemservico = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Codcontdevcli
    {
        get
        {
            PropriedadeAcessada(RO_CODCONTDEVCLI);
            return _codcontdevcli;
        }
        set
        {
            PropriedadeModificada(RO_CODCONTDEVCLI, value);
            _codcontdevcli = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Codcontemprest
    {
        get
        {
            PropriedadeAcessada(RO_CODCONTEMPREST);
            return _codcontemprest;
        }
        set
        {
            PropriedadeModificada(RO_CODCONTEMPREST, value);
            _codcontemprest = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Codconticmsantecip
    {
        get
        {
            PropriedadeAcessada(RO_CODCONTICMSANTECIP);
            return _codconticmsantecip;
        }
        set
        {
            PropriedadeModificada(RO_CODCONTICMSANTECIP, value);
            _codconticmsantecip = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Codcontout
    {
        get
        {
            PropriedadeAcessada(RO_CODCONTOUT);
            return _codcontout;
        }
        set
        {
            PropriedadeModificada(RO_CODCONTOUT, value);
            _codcontout = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Codcontpagdiaria
    {
        get
        {
            PropriedadeAcessada(RO_CODCONTPAGDIARIA);
            return _codcontpagdiaria;
        }
        set
        {
            PropriedadeModificada(RO_CODCONTPAGDIARIA, value);
            _codcontpagdiaria = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Codcontpagjur
    {
        get
        {
            PropriedadeAcessada(RO_CODCONTPAGJUR);
            return _codcontpagjur;
        }
        set
        {
            PropriedadeModificada(RO_CODCONTPAGJUR, value);
            _codcontpagjur = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Codcontrecjur
    {
        get
        {
            PropriedadeAcessada(RO_CODCONTRECJUR);
            return _codcontrecjur;
        }
        set
        {
            PropriedadeModificada(RO_CODCONTRECJUR, value);
            _codcontrecjur = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Codfilialcx
    {
        get
        {
            PropriedadeAcessada(RO_CODFILIALCX);
            return _codfilialcx;
        }
        set
        {
            PropriedadeModificada(RO_CODFILIALCX, value);
            _codfilialcx = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Codfilialfv
    {
        get
        {
            PropriedadeAcessada(RO_CODFILIALFV);
            return _codfilialfv;
        }
        set
        {
            PropriedadeModificada(RO_CODFILIALFV, value);
            _codfilialfv = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codfiscalinterfrete
    {
        get
        {
            PropriedadeAcessada(RO_CODFISCALINTERFRETE);
            return _codfiscalinterfrete;
        }
        set
        {
            PropriedadeModificada(RO_CODFISCALINTERFRETE, value);
            _codfiscalinterfrete = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codfiscalinterfreteent
    {
        get
        {
            PropriedadeAcessada(RO_CODFISCALINTERFRETEENT);
            return _codfiscalinterfreteent;
        }
        set
        {
            PropriedadeModificada(RO_CODFISCALINTERFRETEENT, value);
            _codfiscalinterfreteent = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Codhistadicomis
    {
        get
        {
            PropriedadeAcessada(RO_CODHISTADICOMIS);
            return _codhistadicomis;
        }
        set
        {
            PropriedadeModificada(RO_CODHISTADICOMIS, value);
            _codhistadicomis = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Codhistfechcomis
    {
        get
        {
            PropriedadeAcessada(RO_CODHISTFECHCOMIS);
            return _codhistfechcomis;
        }
        set
        {
            PropriedadeModificada(RO_CODHISTFECHCOMIS, value);
            _codhistfechcomis = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Codhistfechcomisneg
    {
        get
        {
            PropriedadeAcessada(RO_CODHISTFECHCOMISNEG);
            return _codhistfechcomisneg;
        }
        set
        {
            PropriedadeModificada(RO_CODHISTFECHCOMISNEG, value);
            _codhistfechcomisneg = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codmotvisitapadraocallcenter
    {
        get
        {
            PropriedadeAcessada(RO_CODMOTVISITAPADRAOCALLCENTER);
            return _codmotvisitapadraocallcenter;
        }
        set
        {
            PropriedadeModificada(RO_CODMOTVISITAPADRAOCALLCENTER, value);
            _codmotvisitapadraocallcenter = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Codplpagautomatic
    {
        get
        {
            PropriedadeAcessada(RO_CODPLPAGAUTOMATIC);
            return _codplpagautomatic;
        }
        set
        {
            PropriedadeModificada(RO_CODPLPAGAUTOMATIC, value);
            _codplpagautomatic = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Codplpaginicial
    {
        get
        {
            PropriedadeAcessada(RO_CODPLPAGINICIAL);
            return _codplpaginicial;
        }
        set
        {
            PropriedadeModificada(RO_CODPLPAGINICIAL, value);
            _codplpaginicial = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Codpracaautomatic
    {
        get
        {
            PropriedadeAcessada(RO_CODPRACAAUTOMATIC);
            return _codpracaautomatic;
        }
        set
        {
            PropriedadeModificada(RO_CODPRACAAUTOMATIC, value);
            _codpracaautomatic = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codsetorcallcenter
    {
        get
        {
            PropriedadeAcessada(RO_CODSETORCALLCENTER);
            return _codsetorcallcenter;
        }
        set
        {
            PropriedadeModificada(RO_CODSETORCALLCENTER, value);
            _codsetorcallcenter = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codsetorcobranca
    {
        get
        {
            PropriedadeAcessada(RO_CODSETORCOBRANCA);
            return _codsetorcobranca;
        }
        set
        {
            PropriedadeModificada(RO_CODSETORCOBRANCA, value);
            _codsetorcobranca = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codsetorcomprador
    {
        get
        {
            PropriedadeAcessada(RO_CODSETORCOMPRADOR);
            return _codsetorcomprador;
        }
        set
        {
            PropriedadeModificada(RO_CODSETORCOMPRADOR, value);
            _codsetorcomprador = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 2)]
    public decimal? Codsetordiretoria
    {
        get
        {
            PropriedadeAcessada(RO_CODSETORDIRETORIA);
            return _codsetordiretoria;
        }
        set
        {
            PropriedadeModificada(RO_CODSETORDIRETORIA, value);
            _codsetordiretoria = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codsetordiretorio
    {
        get
        {
            PropriedadeAcessada(RO_CODSETORDIRETORIO);
            return _codsetordiretorio;
        }
        set
        {
            PropriedadeModificada(RO_CODSETORDIRETORIO, value);
            _codsetordiretorio = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codsetorembalador
    {
        get
        {
            PropriedadeAcessada(RO_CODSETOREMBALADOR);
            return _codsetorembalador;
        }
        set
        {
            PropriedadeModificada(RO_CODSETOREMBALADOR, value);
            _codsetorembalador = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codsetorexped
    {
        get
        {
            PropriedadeAcessada(RO_CODSETOREXPED);
            return _codsetorexped;
        }
        set
        {
            PropriedadeModificada(RO_CODSETOREXPED, value);
            _codsetorexped = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codsetorfiscalcx
    {
        get
        {
            PropriedadeAcessada(RO_CODSETORFISCALCX);
            return _codsetorfiscalcx;
        }
        set
        {
            PropriedadeModificada(RO_CODSETORFISCALCX, value);
            _codsetorfiscalcx = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codsetormotorista
    {
        get
        {
            PropriedadeAcessada(RO_CODSETORMOTORISTA);
            return _codsetormotorista;
        }
        set
        {
            PropriedadeModificada(RO_CODSETORMOTORISTA, value);
            _codsetormotorista = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codsetoropercx
    {
        get
        {
            PropriedadeAcessada(RO_CODSETOROPERCX);
            return _codsetoropercx;
        }
        set
        {
            PropriedadeModificada(RO_CODSETOROPERCX, value);
            _codsetoropercx = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Codusurautomatic
    {
        get
        {
            PropriedadeAcessada(RO_CODUSURAUTOMATIC);
            return _codusurautomatic;
        }
        set
        {
            PropriedadeModificada(RO_CODUSURAUTOMATIC, value);
            _codusurautomatic = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 8, Precisao = 0)]
    public string Colunafluxocxcr1
    {
        get
        {
            PropriedadeAcessada(RO_COLUNAFLUXOCXCR1);
            return _colunafluxocxcr1;
        }
        set
        {
            PropriedadeModificada(RO_COLUNAFLUXOCXCR1, value);
            _colunafluxocxcr1 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 8, Precisao = 0)]
    public string Colunafluxocxcr2
    {
        get
        {
            PropriedadeAcessada(RO_COLUNAFLUXOCXCR2);
            return _colunafluxocxcr2;
        }
        set
        {
            PropriedadeModificada(RO_COLUNAFLUXOCXCR2, value);
            _colunafluxocxcr2 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 8, Precisao = 0)]
    public string Colunafluxocxcr3
    {
        get
        {
            PropriedadeAcessada(RO_COLUNAFLUXOCXCR3);
            return _colunafluxocxcr3;
        }
        set
        {
            PropriedadeModificada(RO_COLUNAFLUXOCXCR3, value);
            _colunafluxocxcr3 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 8, Precisao = 0)]
    public string Colunafluxocxcr4
    {
        get
        {
            PropriedadeAcessada(RO_COLUNAFLUXOCXCR4);
            return _colunafluxocxcr4;
        }
        set
        {
            PropriedadeModificada(RO_COLUNAFLUXOCXCR4, value);
            _colunafluxocxcr4 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 8, Precisao = 0)]
    public string Colunafluxocxcr5
    {
        get
        {
            PropriedadeAcessada(RO_COLUNAFLUXOCXCR5);
            return _colunafluxocxcr5;
        }
        set
        {
            PropriedadeModificada(RO_COLUNAFLUXOCXCR5, value);
            _colunafluxocxcr5 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Comissaorcatipovenda
    {
        get
        {
            PropriedadeAcessada(RO_COMISSAORCATIPOVENDA);
            return _comissaorcatipovenda;
        }
        set
        {
            PropriedadeModificada(RO_COMISSAORCATIPOVENDA, value);
            _comissaorcatipovenda = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Conferindocargapedido
    {
        get
        {
            PropriedadeAcessada(RO_CONFERINDOCARGAPEDIDO);
            return _conferindocargapedido;
        }
        set
        {
            PropriedadeModificada(RO_CONFERINDOCARGAPEDIDO, value);
            _conferindocargapedido = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Consederacessoproprio530
    {
        get
        {
            PropriedadeAcessada(RO_CONSEDERACESSOPROPRIO530);
            return _consederacessoproprio530;
        }
        set
        {
            PropriedadeModificada(RO_CONSEDERACESSOPROPRIO530, value);
            _consederacessoproprio530 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Consideracmvdevolucao
    {
        get
        {
            PropriedadeAcessada(RO_CONSIDERACMVDEVOLUCAO);
            return _consideracmvdevolucao;
        }
        set
        {
            PropriedadeModificada(RO_CONSIDERACMVDEVOLUCAO, value);
            _consideracmvdevolucao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Consideraisentoscomopf
    {
        get
        {
            PropriedadeAcessada(RO_CONSIDERAISENTOSCOMOPF);
            return _consideraisentoscomopf;
        }
        set
        {
            PropriedadeModificada(RO_CONSIDERAISENTOSCOMOPF, value);
            _consideraisentoscomopf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Consistecnpjfornec
    {
        get
        {
            PropriedadeAcessada(RO_CONSISTECNPJFORNEC);
            return _consistecnpjfornec;
        }
        set
        {
            PropriedadeModificada(RO_CONSISTECNPJFORNEC, value);
            _consistecnpjfornec = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Consolidando
    {
        get
        {
            PropriedadeAcessada(RO_CONSOLIDANDO);
            return _consolidando;
        }
        set
        {
            PropriedadeModificada(RO_CONSOLIDANDO, value);
            _consolidando = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Consqtreservrebaixacusto
    {
        get
        {
            PropriedadeAcessada(RO_CONSQTRESERVREBAIXACUSTO);
            return _consqtreservrebaixacusto;
        }
        set
        {
            PropriedadeModificada(RO_CONSQTRESERVREBAIXACUSTO, value);
            _consqtreservrebaixacusto = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Contalancperda
    {
        get
        {
            PropriedadeAcessada(RO_CONTALANCPERDA);
            return _contalancperda;
        }
        set
        {
            PropriedadeModificada(RO_CONTALANCPERDA, value);
            _contalancperda = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Controlaedicaopedidocompra
    {
        get
        {
            PropriedadeAcessada(RO_CONTROLAEDICAOPEDIDOCOMPRA);
            return _controlaedicaopedidocompra;
        }
        set
        {
            PropriedadeModificada(RO_CONTROLAEDICAOPEDIDOCOMPRA, value);
            _controlaedicaopedidocompra = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Controlaprodutivsep
    {
        get
        {
            PropriedadeAcessada(RO_CONTROLAPRODUTIVSEP);
            return _controlaprodutivsep;
        }
        set
        {
            PropriedadeModificada(RO_CONTROLAPRODUTIVSEP, value);
            _controlaprodutivsep = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Credencialparticipasorteiobiro
    {
        get
        {
            PropriedadeAcessada(RO_CREDENCIALPARTICIPASORTEIOBIRO);
            return _credencialparticipasorteiobiro;
        }
        set
        {
            PropriedadeModificada(RO_CREDENCIALPARTICIPASORTEIOBIRO, value);
            _credencialparticipasorteiobiro = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Custoindustria
    {
        get
        {
            PropriedadeAcessada(RO_CUSTOINDUSTRIA);
            return _custoindustria;
        }
        set
        {
            PropriedadeModificada(RO_CUSTOINDUSTRIA, value);
            _custoindustria = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Deduziravariaestcomdevcli
    {
        get
        {
            PropriedadeAcessada(RO_DEDUZIRAVARIAESTCOMDEVCLI);
            return _deduziravariaestcomdevcli;
        }
        set
        {
            PropriedadeModificada(RO_DEDUZIRAVARIAESTCOMDEVCLI, value);
            _deduziravariaestcomdevcli = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Definirloteop
    {
        get
        {
            PropriedadeAcessada(RO_DEFINIRLOTEOP);
            return _definirloteop;
        }
        set
        {
            PropriedadeModificada(RO_DEFINIRLOTEOP, value);
            _definirloteop = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 3, Precisao = 0)]
    public decimal? Depositovirtual
    {
        get
        {
            PropriedadeAcessada(RO_DEPOSITOVIRTUAL);
            return _depositovirtual;
        }
        set
        {
            PropriedadeModificada(RO_DEPOSITOVIRTUAL, value);
            _depositovirtual = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Desbloqclibxtitulo
    {
        get
        {
            PropriedadeAcessada(RO_DESBLOQCLIBXTITULO);
            return _desbloqclibxtitulo;
        }
        set
        {
            PropriedadeModificada(RO_DESBLOQCLIBXTITULO, value);
            _desbloqclibxtitulo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Desbloquearprodfimos
    {
        get
        {
            PropriedadeAcessada(RO_DESBLOQUEARPRODFIMOS);
            return _desbloquearprodfimos;
        }
        set
        {
            PropriedadeModificada(RO_DESBLOQUEARPRODFIMOS, value);
            _desbloquearprodfimos = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Descvenda
    {
        get
        {
            PropriedadeAcessada(RO_DESCVENDA);
            return _descvenda;
        }
        set
        {
            PropriedadeModificada(RO_DESCVENDA, value);
            _descvenda = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Desdcartaofechcarga
    {
        get
        {
            PropriedadeAcessada(RO_DESDCARTAOFECHCARGA);
            return _desdcartaofechcarga;
        }
        set
        {
            PropriedadeModificada(RO_DESDCARTAOFECHCARGA, value);
            _desdcartaofechcarga = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Desdobrarcadiferente
    {
        get
        {
            PropriedadeAcessada(RO_DESDOBRARCADIFERENTE);
            return _desdobrarcadiferente;
        }
        set
        {
            PropriedadeModificada(RO_DESDOBRARCADIFERENTE, value);
            _desdobrarcadiferente = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Diasanalisedevol
    {
        get
        {
            PropriedadeAcessada(RO_DIASANALISEDEVOL);
            return _diasanalisedevol;
        }
        set
        {
            PropriedadeModificada(RO_DIASANALISEDEVOL, value);
            _diasanalisedevol = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Diasbloqfornecverbasvencidas
    {
        get
        {
            PropriedadeAcessada(RO_DIASBLOQFORNECVERBASVENCIDAS);
            return _diasbloqfornecverbasvencidas;
        }
        set
        {
            PropriedadeModificada(RO_DIASBLOQFORNECVERBASVENCIDAS, value);
            _diasbloqfornecverbasvencidas = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 80, Precisao = 0)]
    public string Dirarquivointegracao
    {
        get
        {
            PropriedadeAcessada(RO_DIRARQUIVOINTEGRACAO);
            return _dirarquivointegracao;
        }
        set
        {
            PropriedadeModificada(RO_DIRARQUIVOINTEGRACAO, value);
            _dirarquivointegracao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 100, Precisao = 0)]
    public string Direxportacaofv
    {
        get
        {
            PropriedadeAcessada(RO_DIREXPORTACAOFV);
            return _direxportacaofv;
        }
        set
        {
            PropriedadeModificada(RO_DIREXPORTACAOFV, value);
            _direxportacaofv = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 100, Precisao = 0)]
    public string Dirimportacaofv
    {
        get
        {
            PropriedadeAcessada(RO_DIRIMPORTACAOFV);
            return _dirimportacaofv;
        }
        set
        {
            PropriedadeModificada(RO_DIRIMPORTACAOFV, value);
            _dirimportacaofv = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 100, Precisao = 0)]
    public string Dirimportacaofv2
    {
        get
        {
            PropriedadeAcessada(RO_DIRIMPORTACAOFV2);
            return _dirimportacaofv2;
        }
        set
        {
            PropriedadeModificada(RO_DIRIMPORTACAOFV2, value);
            _dirimportacaofv2 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 3, Precisao = 0)]
    public string Dirop
    {
        get
        {
            PropriedadeAcessada(RO_DIROP);
            return _dirop;
        }
        set
        {
            PropriedadeModificada(RO_DIROP, value);
            _dirop = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
    public string Dirwinthor
    {
        get
        {
            PropriedadeAcessada(RO_DIRWINTHOR);
            return _dirwinthor;
        }
        set
        {
            PropriedadeModificada(RO_DIRWINTHOR, value);
            _dirwinthor = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
    public string Dirwinthorremoto
    {
        get
        {
            PropriedadeAcessada(RO_DIRWINTHORREMOTO);
            return _dirwinthorremoto;
        }
        set
        {
            PropriedadeModificada(RO_DIRWINTHORREMOTO, value);
            _dirwinthorremoto = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Divideprzadicionalparcelas
    {
        get
        {
            PropriedadeAcessada(RO_DIVIDEPRZADICIONALPARCELAS);
            return _divideprzadicionalparcelas;
        }
        set
        {
            PropriedadeModificada(RO_DIVIDEPRZADICIONALPARCELAS, value);
            _divideprzadicionalparcelas = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtatualizacaobd
    {
        get
        {
            PropriedadeAcessada(RO_DTATUALIZACAOBD);
            return _dtatualizacaobd;
        }
        set
        {
            PropriedadeModificada(RO_DTATUALIZACAOBD, value);
            _dtatualizacaobd = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtexpiracaowinthor
    {
        get
        {
            PropriedadeAcessada(RO_DTEXPIRACAOWINTHOR);
            return _dtexpiracaowinthor;
        }
        set
        {
            PropriedadeModificada(RO_DTEXPIRACAOWINTHOR, value);
            _dtexpiracaowinthor = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtinicionfp
    {
        get
        {
            PropriedadeAcessada(RO_DTINICIONFP);
            return _dtinicionfp;
        }
        set
        {
            PropriedadeModificada(RO_DTINICIONFP, value);
            _dtinicionfp = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtprocessamento
    {
        get
        {
            PropriedadeAcessada(RO_DTPROCESSAMENTO);
            return _dtprocessamento;
        }
        set
        {
            PropriedadeModificada(RO_DTPROCESSAMENTO, value);
            _dtprocessamento = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtproxfechames
    {
        get
        {
            PropriedadeAcessada(RO_DTPROXFECHAMES);
            return _dtproxfechames;
        }
        set
        {
            PropriedadeModificada(RO_DTPROXFECHAMES, value);
            _dtproxfechames = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtultimageracaoserasa
    {
        get
        {
            PropriedadeAcessada(RO_DTULTIMAGERACAOSERASA);
            return _dtultimageracaoserasa;
        }
        set
        {
            PropriedadeModificada(RO_DTULTIMAGERACAOSERASA, value);
            _dtultimageracaoserasa = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Dtvencantdesd
    {
        get
        {
            PropriedadeAcessada(RO_DTVENCANTDESD);
            return _dtvencantdesd;
        }
        set
        {
            PropriedadeModificada(RO_DTVENCANTDESD, value);
            _dtvencantdesd = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtvenctk
    {
        get
        {
            PropriedadeAcessada(RO_DTVENCTK);
            return _dtvenctk;
        }
        set
        {
            PropriedadeModificada(RO_DTVENCTK, value);
            _dtvenctk = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtvenctt
    {
        get
        {
            PropriedadeAcessada(RO_DTVENCTT);
            return _dtvenctt;
        }
        set
        {
            PropriedadeModificada(RO_DTVENCTT, value);
            _dtvenctt = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtviradawms
    {
        get
        {
            PropriedadeAcessada(RO_DTVIRADAWMS);
            return _dtviradawms;
        }
        set
        {
            PropriedadeModificada(RO_DTVIRADAWMS, value);
            _dtviradawms = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Dvobrigatorio
    {
        get
        {
            PropriedadeAcessada(RO_DVOBRIGATORIO);
            return _dvobrigatorio;
        }
        set
        {
            PropriedadeModificada(RO_DVOBRIGATORIO, value);
            _dvobrigatorio = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Emitepedidovenda
    {
        get
        {
            PropriedadeAcessada(RO_EMITEPEDIDOVENDA);
            return _emitepedidovenda;
        }
        set
        {
            PropriedadeModificada(RO_EMITEPEDIDOVENDA, value);
            _emitepedidovenda = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Emitindomapa
    {
        get
        {
            PropriedadeAcessada(RO_EMITINDOMAPA);
            return _emitindomapa;
        }
        set
        {
            PropriedadeModificada(RO_EMITINDOMAPA, value);
            _emitindomapa = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Enderecacombonusaberto
    {
        get
        {
            PropriedadeAcessada(RO_ENDERECACOMBONUSABERTO);
            return _enderecacombonusaberto;
        }
        set
        {
            PropriedadeModificada(RO_ENDERECACOMBONUSABERTO, value);
            _enderecacombonusaberto = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Enderecoapanhafilial
    {
        get
        {
            PropriedadeAcessada(RO_ENDERECOAPANHAFILIAL);
            return _enderecoapanhafilial;
        }
        set
        {
            PropriedadeModificada(RO_ENDERECOAPANHAFILIAL, value);
            _enderecoapanhafilial = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Entrega_Futura
    {
        get
        {
            PropriedadeAcessada(RO_ENTREGA_FUTURA);
            return _entrega_futura;
        }
        set
        {
            PropriedadeModificada(RO_ENTREGA_FUTURA, value);
            _entrega_futura = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Enviamensrcalibest
    {
        get
        {
            PropriedadeAcessada(RO_ENVIAMENSRCALIBEST);
            return _enviamensrcalibest;
        }
        set
        {
            PropriedadeModificada(RO_ENVIAMENSRCALIBEST, value);
            _enviamensrcalibest = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Enviarmsgrcacorte
    {
        get
        {
            PropriedadeAcessada(RO_ENVIARMSGRCACORTE);
            return _enviarmsgrcacorte;
        }
        set
        {
            PropriedadeModificada(RO_ENVIARMSGRCACORTE, value);
            _enviarmsgrcacorte = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Estado
    {
        get
        {
            PropriedadeAcessada(RO_ESTADO);
            return _estado;
        }
        set
        {
            PropriedadeModificada(RO_ESTADO, value);
            _estado = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Exibirpvenda
    {
        get
        {
            PropriedadeAcessada(RO_EXIBIRPVENDA);
            return _exibirpvenda;
        }
        set
        {
            PropriedadeModificada(RO_EXIBIRPVENDA, value);
            _exibirpvenda = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Exigedtvalidadebonusrm
    {
        get
        {
            PropriedadeAcessada(RO_EXIGEDTVALIDADEBONUSRM);
            return _exigedtvalidadebonusrm;
        }
        set
        {
            PropriedadeModificada(RO_EXIGEDTVALIDADEBONUSRM, value);
            _exigedtvalidadebonusrm = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Expedepaletefechadodiretobox
    {
        get
        {
            PropriedadeAcessada(RO_EXPEDEPALETEFECHADODIRETOBOX);
            return _expedepaletefechadodiretobox;
        }
        set
        {
            PropriedadeModificada(RO_EXPEDEPALETEFECHADODIRETOBOX, value);
            _expedepaletefechadodiretobox = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Exportandodados
    {
        get
        {
            PropriedadeAcessada(RO_EXPORTANDODADOS);
            return _exportandodados;
        }
        set
        {
            PropriedadeModificada(RO_EXPORTANDODADOS, value);
            _exportandodados = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 2)]
    public decimal? Faixafimteor
    {
        get
        {
            PropriedadeAcessada(RO_FAIXAFIMTEOR);
            return _faixafimteor;
        }
        set
        {
            PropriedadeModificada(RO_FAIXAFIMTEOR, value);
            _faixafimteor = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 2)]
    public decimal? Faixainiteor
    {
        get
        {
            PropriedadeAcessada(RO_FAIXAINITEOR);
            return _faixainiteor;
        }
        set
        {
            PropriedadeModificada(RO_FAIXAINITEOR, value);
            _faixainiteor = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Faturafilialbroker
    {
        get
        {
            PropriedadeAcessada(RO_FATURAFILIALBROKER);
            return _faturafilialbroker;
        }
        set
        {
            PropriedadeModificada(RO_FATURAFILIALBROKER, value);
            _faturafilialbroker = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 13, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Fazerinsertpcembalagem
    {
        get
        {
            PropriedadeAcessada(RO_FAZERINSERTPCEMBALAGEM);
            return _fazerinsertpcembalagem;
        }
        set
        {
            PropriedadeModificada(RO_FAZERINSERTPCEMBALAGEM, value);
            _fazerinsertpcembalagem = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Fechabonusemrecibodesc
    {
        get
        {
            PropriedadeAcessada(RO_FECHABONUSEMRECIBODESC);
            return _fechabonusemrecibodesc;
        }
        set
        {
            PropriedadeModificada(RO_FECHABONUSEMRECIBODESC, value);
            _fechabonusemrecibodesc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Fechacarregautvendabalcao
    {
        get
        {
            PropriedadeAcessada(RO_FECHACARREGAUTVENDABALCAO);
            return _fechacarregautvendabalcao;
        }
        set
        {
            PropriedadeModificada(RO_FECHACARREGAUTVENDABALCAO, value);
            _fechacarregautvendabalcao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Filialpadrao
    {
        get
        {
            PropriedadeAcessada(RO_FILIALPADRAO);
            return _filialpadrao;
        }
        set
        {
            PropriedadeModificada(RO_FILIALPADRAO, value);
            _filialpadrao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 2, Precisao = 0)]
    public decimal? Formmapa
    {
        get
        {
            PropriedadeAcessada(RO_FORMMAPA);
            return _formmapa;
        }
        set
        {
            PropriedadeModificada(RO_FORMMAPA, value);
            _formmapa = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Fretenaotribcomooutras
    {
        get
        {
            PropriedadeAcessada(RO_FRETENAOTRIBCOMOOUTRAS);
            return _fretenaotribcomooutras;
        }
        set
        {
            PropriedadeModificada(RO_FRETENAOTRIBCOMOOUTRAS, value);
            _fretenaotribcomooutras = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Ftp_Conexaopassiva
    {
        get
        {
            PropriedadeAcessada(RO_FTP_CONEXAOPASSIVA);
            return _ftp_conexaopassiva;
        }
        set
        {
            PropriedadeModificada(RO_FTP_CONEXAOPASSIVA, value);
            _ftp_conexaopassiva = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
    public string Ftp_Ip
    {
        get
        {
            PropriedadeAcessada(RO_FTP_IP);
            return _ftp_ip;
        }
        set
        {
            PropriedadeModificada(RO_FTP_IP, value);
            _ftp_ip = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Ftp_Porta
    {
        get
        {
            PropriedadeAcessada(RO_FTP_PORTA);
            return _ftp_porta;
        }
        set
        {
            PropriedadeModificada(RO_FTP_PORTA, value);
            _ftp_porta = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Geracontaspagardevcli
    {
        get
        {
            PropriedadeAcessada(RO_GERACONTASPAGARDEVCLI);
            return _geracontaspagardevcli;
        }
        set
        {
            PropriedadeModificada(RO_GERACONTASPAGARDEVCLI, value);
            _geracontaspagardevcli = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Gerandomapa
    {
        get
        {
            PropriedadeAcessada(RO_GERANDOMAPA);
            return _gerandomapa;
        }
        set
        {
            PropriedadeModificada(RO_GERANDOMAPA, value);
            _gerandomapa = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Geranftipo8
    {
        get
        {
            PropriedadeAcessada(RO_GERANFTIPO8);
            return _geranftipo8;
        }
        set
        {
            PropriedadeModificada(RO_GERANFTIPO8, value);
            _geranftipo8 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Geranumloteautomatico
    {
        get
        {
            PropriedadeAcessada(RO_GERANUMLOTEAUTOMATICO);
            return _geranumloteautomatico;
        }
        set
        {
            PropriedadeModificada(RO_GERANUMLOTEAUTOMATICO, value);
            _geranumloteautomatico = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Geraparcelamentotef
    {
        get
        {
            PropriedadeAcessada(RO_GERAPARCELAMENTOTEF);
            return _geraparcelamentotef;
        }
        set
        {
            PropriedadeModificada(RO_GERAPARCELAMENTOTEF, value);
            _geraparcelamentotef = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Gerarbrindepedbonific
    {
        get
        {
            PropriedadeAcessada(RO_GERARBRINDEPEDBONIFIC);
            return _gerarbrindepedbonific;
        }
        set
        {
            PropriedadeModificada(RO_GERARBRINDEPEDBONIFIC, value);
            _gerarbrindepedbonific = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Gerarcreclidevcli
    {
        get
        {
            PropriedadeAcessada(RO_GERARCRECLIDEVCLI);
            return _gerarcreclidevcli;
        }
        set
        {
            PropriedadeModificada(RO_GERARCRECLIDEVCLI, value);
            _gerarcreclidevcli = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Gerardadosreducaoz
    {
        get
        {
            PropriedadeAcessada(RO_GERARDADOSREDUCAOZ);
            return _gerardadosreducaoz;
        }
        set
        {
            PropriedadeModificada(RO_GERARDADOSREDUCAOZ, value);
            _gerardadosreducaoz = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Gerarpcauxlancontasorcam
    {
        get
        {
            PropriedadeAcessada(RO_GERARPCAUXLANCONTASORCAM);
            return _gerarpcauxlancontasorcam;
        }
        set
        {
            PropriedadeModificada(RO_GERARPCAUXLANCONTASORCAM, value);
            _gerarpcauxlancontasorcam = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Gerarpcfrete
    {
        get
        {
            PropriedadeAcessada(RO_GERARPCFRETE);
            return _gerarpcfrete;
        }
        set
        {
            PropriedadeModificada(RO_GERARPCFRETE, value);
            _gerarpcfrete = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Gerarpclancicmsantecip
    {
        get
        {
            PropriedadeAcessada(RO_GERARPCLANCICMSANTECIP);
            return _gerarpclancicmsantecip;
        }
        set
        {
            PropriedadeModificada(RO_GERARPCLANCICMSANTECIP, value);
            _gerarpclancicmsantecip = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Gerartrococobdin
    {
        get
        {
            PropriedadeAcessada(RO_GERARTROCOCOBDIN);
            return _gerartrococobdin;
        }
        set
        {
            PropriedadeModificada(RO_GERARTROCOCOBDIN, value);
            _gerartrococobdin = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Geravalercadevmanif
    {
        get
        {
            PropriedadeAcessada(RO_GERAVALERCADEVMANIF);
            return _geravalercadevmanif;
        }
        set
        {
            PropriedadeModificada(RO_GERAVALERCADEVMANIF, value);
            _geravalercadevmanif = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Gravapcmensaltcadcli
    {
        get
        {
            PropriedadeAcessada(RO_GRAVAPCMENSALTCADCLI);
            return _gravapcmensaltcadcli;
        }
        set
        {
            PropriedadeModificada(RO_GRAVAPCMENSALTCADCLI, value);
            _gravapcmensaltcadcli = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Gravarcotacao
    {
        get
        {
            PropriedadeAcessada(RO_GRAVARCOTACAO);
            return _gravarcotacao;
        }
        set
        {
            PropriedadeModificada(RO_GRAVARCOTACAO, value);
            _gravarcotacao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Gravarobsclientenopedido
    {
        get
        {
            PropriedadeAcessada(RO_GRAVAROBSCLIENTENOPEDIDO);
            return _gravarobsclientenopedido;
        }
        set
        {
            PropriedadeModificada(RO_GRAVAROBSCLIENTENOPEDIDO, value);
            _gravarobsclientenopedido = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Habilitarlanctodadosfrota
    {
        get
        {
            PropriedadeAcessada(RO_HABILITARLANCTODADOSFROTA);
            return _habilitarlanctodadosfrota;
        }
        set
        {
            PropriedadeModificada(RO_HABILITARLANCTODADOSFROTA, value);
            _habilitarlanctodadosfrota = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
    public string Histfor
    {
        get
        {
            PropriedadeAcessada(RO_HISTFOR);
            return _histfor;
        }
        set
        {
            PropriedadeModificada(RO_HISTFOR, value);
            _histfor = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
    public string Histfre
    {
        get
        {
            PropriedadeAcessada(RO_HISTFRE);
            return _histfre;
        }
        set
        {
            PropriedadeModificada(RO_HISTFRE, value);
            _histfre = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
    public string Histout
    {
        get
        {
            PropriedadeAcessada(RO_HISTOUT);
            return _histout;
        }
        set
        {
            PropriedadeModificada(RO_HISTOUT, value);
            _histout = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Iecliexclusiva
    {
        get
        {
            PropriedadeAcessada(RO_IECLIEXCLUSIVA);
            return _iecliexclusiva;
        }
        set
        {
            PropriedadeModificada(RO_IECLIEXCLUSIVA, value);
            _iecliexclusiva = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Impcartacobjuros
    {
        get
        {
            PropriedadeAcessada(RO_IMPCARTACOBJUROS);
            return _impcartacobjuros;
        }
        set
        {
            PropriedadeModificada(RO_IMPCARTACOBJUROS, value);
            _impcartacobjuros = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Importandopedidos
    {
        get
        {
            PropriedadeAcessada(RO_IMPORTANDOPEDIDOS);
            return _importandopedidos;
        }
        set
        {
            PropriedadeModificada(RO_IMPORTANDOPEDIDOS, value);
            _importandopedidos = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Impqtbonus
    {
        get
        {
            PropriedadeAcessada(RO_IMPQTBONUS);
            return _impqtbonus;
        }
        set
        {
            PropriedadeModificada(RO_IMPQTBONUS, value);
            _impqtbonus = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Impressaoautomatica
    {
        get
        {
            PropriedadeAcessada(RO_IMPRESSAOAUTOMATICA);
            return _impressaoautomatica;
        }
        set
        {
            PropriedadeModificada(RO_IMPRESSAOAUTOMATICA, value);
            _impressaoautomatica = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Imprimedescontocf
    {
        get
        {
            PropriedadeAcessada(RO_IMPRIMEDESCONTOCF);
            return _imprimedescontocf;
        }
        set
        {
            PropriedadeModificada(RO_IMPRIMEDESCONTOCF, value);
            _imprimedescontocf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Imprimirespelhoentmerc
    {
        get
        {
            PropriedadeAcessada(RO_IMPRIMIRESPELHOENTMERC);
            return _imprimirespelhoentmerc;
        }
        set
        {
            PropriedadeModificada(RO_IMPRIMIRESPELHOENTMERC, value);
            _imprimirespelhoentmerc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Incdupjurosdesd
    {
        get
        {
            PropriedadeAcessada(RO_INCDUPJUROSDESD);
            return _incdupjurosdesd;
        }
        set
        {
            PropriedadeModificada(RO_INCDUPJUROSDESD, value);
            _incdupjurosdesd = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Incluidesprodapenf
    {
        get
        {
            PropriedadeAcessada(RO_INCLUIDESPRODAPENF);
            return _incluidesprodapenf;
        }
        set
        {
            PropriedadeModificada(RO_INCLUIDESPRODAPENF, value);
            _incluidesprodapenf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Incluircomissaocmvvenda
    {
        get
        {
            PropriedadeAcessada(RO_INCLUIRCOMISSAOCMVVENDA);
            return _incluircomissaocmvvenda;
        }
        set
        {
            PropriedadeModificada(RO_INCLUIRCOMISSAOCMVVENDA, value);
            _incluircomissaocmvvenda = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Incluircomissaosugpvendacmv
    {
        get
        {
            PropriedadeAcessada(RO_INCLUIRCOMISSAOSUGPVENDACMV);
            return _incluircomissaosugpvendacmv;
        }
        set
        {
            PropriedadeModificada(RO_INCLUIRCOMISSAOSUGPVENDACMV, value);
            _incluircomissaosugpvendacmv = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Indespelho
    {
        get
        {
            PropriedadeAcessada(RO_INDESPELHO);
            return _indespelho;
        }
        set
        {
            PropriedadeModificada(RO_INDESPELHO, value);
            _indespelho = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Infnumverbapedbonific
    {
        get
        {
            PropriedadeAcessada(RO_INFNUMVERBAPEDBONIFIC);
            return _infnumverbapedbonific;
        }
        set
        {
            PropriedadeModificada(RO_INFNUMVERBAPEDBONIFIC, value);
            _infnumverbapedbonific = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Informarecebedorvenda
    {
        get
        {
            PropriedadeAcessada(RO_INFORMARECEBEDORVENDA);
            return _informarecebedorvenda;
        }
        set
        {
            PropriedadeModificada(RO_INFORMARECEBEDORVENDA, value);
            _informarecebedorvenda = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Iniciaropsemem
    {
        get
        {
            PropriedadeAcessada(RO_INICIAROPSEMEM);
            return _iniciaropsemem;
        }
        set
        {
            PropriedadeModificada(RO_INICIAROPSEMEM, value);
            _iniciaropsemem = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Inserircupom
    {
        get
        {
            PropriedadeAcessada(RO_INSERIRCUPOM);
            return _inserircupom;
        }
        set
        {
            PropriedadeModificada(RO_INSERIRCUPOM, value);
            _inserircupom = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Inserirmapa
    {
        get
        {
            PropriedadeAcessada(RO_INSERIRMAPA);
            return _inserirmapa;
        }
        set
        {
            PropriedadeModificada(RO_INSERIRMAPA, value);
            _inserirmapa = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Inserirreducaoz
    {
        get
        {
            PropriedadeAcessada(RO_INSERIRREDUCAOZ);
            return _inserirreducaoz;
        }
        set
        {
            PropriedadeModificada(RO_INSERIRREDUCAOZ, value);
            _inserirreducaoz = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 15, Precisao = 0)]
    public string Ipnfe
    {
        get
        {
            PropriedadeAcessada(RO_IPNFE);
            return _ipnfe;
        }
        set
        {
            PropriedadeModificada(RO_IPNFE, value);
            _ipnfe = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 15, Precisao = 0)]
    public string Iptabpreco
    {
        get
        {
            PropriedadeAcessada(RO_IPTABPRECO);
            return _iptabpreco;
        }
        set
        {
            PropriedadeModificada(RO_IPTABPRECO, value);
            _iptabpreco = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Lancardespvendorautomatico
    {
        get
        {
            PropriedadeAcessada(RO_LANCARDESPVENDORAUTOMATICO);
            return _lancardespvendorautomatico;
        }
        set
        {
            PropriedadeModificada(RO_LANCARDESPVENDORAUTOMATICO, value);
            _lancardespvendorautomatico = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Lancarfretexparcelas
    {
        get
        {
            PropriedadeAcessada(RO_LANCARFRETEXPARCELAS);
            return _lancarfretexparcelas;
        }
        set
        {
            PropriedadeModificada(RO_LANCARFRETEXPARCELAS, value);
            _lancarfretexparcelas = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Lancarstapenasparc1
    {
        get
        {
            PropriedadeAcessada(RO_LANCARSTAPENASPARC1);
            return _lancarstapenasparc1;
        }
        set
        {
            PropriedadeModificada(RO_LANCARSTAPENASPARC1, value);
            _lancarstapenasparc1 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Lancarvalecomodespesana1268
    {
        get
        {
            PropriedadeAcessada(RO_LANCARVALECOMODESPESANA1268);
            return _lancarvalecomodespesana1268;
        }
        set
        {
            PropriedadeModificada(RO_LANCARVALECOMODESPESANA1268, value);
            _lancarvalecomodespesana1268 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Leiturach
    {
        get
        {
            PropriedadeAcessada(RO_LEITURACH);
            return _leiturach;
        }
        set
        {
            PropriedadeModificada(RO_LEITURACH, value);
            _leiturach = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Liberaestentmerc
    {
        get
        {
            PropriedadeAcessada(RO_LIBERAESTENTMERC);
            return _liberaestentmerc;
        }
        set
        {
            PropriedadeModificada(RO_LIBERAESTENTMERC, value);
            _liberaestentmerc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Liberaestfechbonus
    {
        get
        {
            PropriedadeAcessada(RO_LIBERAESTFECHBONUS);
            return _liberaestfechbonus;
        }
        set
        {
            PropriedadeModificada(RO_LIBERAESTFECHBONUS, value);
            _liberaestfechbonus = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Liberarpedidopendente
    {
        get
        {
            PropriedadeAcessada(RO_LIBERARPEDIDOPENDENTE);
            return _liberarpedidopendente;
        }
        set
        {
            PropriedadeModificada(RO_LIBERARPEDIDOPENDENTE, value);
            _liberarpedidopendente = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 15, Precisao = 2)]
    public decimal? Limcredinicial
    {
        get
        {
            PropriedadeAcessada(RO_LIMCREDINICIAL);
            return _limcredinicial;
        }
        set
        {
            PropriedadeModificada(RO_LIMCREDINICIAL, value);
            _limcredinicial = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 15, Precisao = 2)]
    public decimal? Limcredinicialpf
    {
        get
        {
            PropriedadeAcessada(RO_LIMCREDINICIALPF);
            return _limcredinicialpf;
        }
        set
        {
            PropriedadeModificada(RO_LIMCREDINICIALPF, value);
            _limcredinicialpf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 2)]
    public decimal? Limitearredondamento
    {
        get
        {
            PropriedadeAcessada(RO_LIMITEARREDONDAMENTO);
            return _limitearredondamento;
        }
        set
        {
            PropriedadeModificada(RO_LIMITEARREDONDAMENTO, value);
            _limitearredondamento = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Limparobsnfdevol
    {
        get
        {
            PropriedadeAcessada(RO_LIMPAROBSNFDEVOL);
            return _limparobsnfdevol;
        }
        set
        {
            PropriedadeModificada(RO_LIMPAROBSNFDEVOL, value);
            _limparobsnfdevol = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Mantemnossonumbco1210
    {
        get
        {
            PropriedadeAcessada(RO_MANTEMNOSSONUMBCO1210);
            return _mantemnossonumbco1210;
        }
        set
        {
            PropriedadeModificada(RO_MANTEMNOSSONUMBCO1210, value);
            _mantemnossonumbco1210 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Mantemnossonumbco402
    {
        get
        {
            PropriedadeAcessada(RO_MANTEMNOSSONUMBCO402);
            return _mantemnossonumbco402;
        }
        set
        {
            PropriedadeModificada(RO_MANTEMNOSSONUMBCO402, value);
            _mantemnossonumbco402 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 2)]
    public decimal? Margemmin
    {
        get
        {
            PropriedadeAcessada(RO_MARGEMMIN);
            return _margemmin;
        }
        set
        {
            PropriedadeModificada(RO_MARGEMMIN, value);
            _margemmin = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 2)]
    public decimal? Margemprev
    {
        get
        {
            PropriedadeAcessada(RO_MARGEMPREV);
            return _margemprev;
        }
        set
        {
            PropriedadeModificada(RO_MARGEMPREV, value);
            _margemprev = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Maxdiassemvenda
    {
        get
        {
            PropriedadeAcessada(RO_MAXDIASSEMVENDA);
            return _maxdiassemvenda;
        }
        set
        {
            PropriedadeModificada(RO_MAXDIASSEMVENDA, value);
            _maxdiassemvenda = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 3, Precisao = 0)]
    public decimal? Maxprzmediodesdcp
    {
        get
        {
            PropriedadeAcessada(RO_MAXPRZMEDIODESDCP);
            return _maxprzmediodesdcp;
        }
        set
        {
            PropriedadeModificada(RO_MAXPRZMEDIODESDCP, value);
            _maxprzmediodesdcp = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 80, Precisao = 0)]
    public string Mensagem1nf
    {
        get
        {
            PropriedadeAcessada(RO_MENSAGEM1NF);
            return _mensagem1nf;
        }
        set
        {
            PropriedadeModificada(RO_MENSAGEM1NF, value);
            _mensagem1nf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 80, Precisao = 0)]
    public string Mensagem2nf
    {
        get
        {
            PropriedadeAcessada(RO_MENSAGEM2NF);
            return _mensagem2nf;
        }
        set
        {
            PropriedadeModificada(RO_MENSAGEM2NF, value);
            _mensagem2nf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 6, Precisao = 0)]
    public string Mercadoalvo
    {
        get
        {
            PropriedadeAcessada(RO_MERCADOALVO);
            return _mercadoalvo;
        }
        set
        {
            PropriedadeModificada(RO_MERCADOALVO, value);
            _mercadoalvo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Mudacobcliente
    {
        get
        {
            PropriedadeAcessada(RO_MUDACOBCLIENTE);
            return _mudacobcliente;
        }
        set
        {
            PropriedadeModificada(RO_MUDACOBCLIENTE, value);
            _mudacobcliente = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Mudacobclientedias
    {
        get
        {
            PropriedadeAcessada(RO_MUDACOBCLIENTEDIAS);
            return _mudacobclientedias;
        }
        set
        {
            PropriedadeModificada(RO_MUDACOBCLIENTEDIAS, value);
            _mudacobclientedias = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Naogravarsaldoestoqueinventrot
    {
        get
        {
            PropriedadeAcessada(RO_NAOGRAVARSALDOESTOQUEINVENTROT);
            return _naogravarsaldoestoqueinventrot;
        }
        set
        {
            PropriedadeModificada(RO_NAOGRAVARSALDOESTOQUEINVENTROT, value);
            _naogravarsaldoestoqueinventrot = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Naousaenderecomisto
    {
        get
        {
            PropriedadeAcessada(RO_NAOUSAENDERECOMISTO);
            return _naousaenderecomisto;
        }
        set
        {
            PropriedadeModificada(RO_NAOUSAENDERECOMISTO, value);
            _naousaenderecomisto = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Naousarpccrecliconsfinal
    {
        get
        {
            PropriedadeAcessada(RO_NAOUSARPCCRECLICONSFINAL);
            return _naousarpccrecliconsfinal;
        }
        set
        {
            PropriedadeModificada(RO_NAOUSARPCCRECLICONSFINAL, value);
            _naousarpccrecliconsfinal = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Naousarpickingcx
    {
        get
        {
            PropriedadeAcessada(RO_NAOUSARPICKINGCX);
            return _naousarpickingcx;
        }
        set
        {
            PropriedadeModificada(RO_NAOUSARPICKINGCX, value);
            _naousarpickingcx = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Ndiasexpirasenha
    {
        get
        {
            PropriedadeAcessada(RO_NDIASEXPIRASENHA);
            return _ndiasexpirasenha;
        }
        set
        {
            PropriedadeModificada(RO_NDIASEXPIRASENHA, value);
            _ndiasexpirasenha = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Numautomaticcli
    {
        get
        {
            PropriedadeAcessada(RO_NUMAUTOMATICCLI);
            return _numautomaticcli;
        }
        set
        {
            PropriedadeModificada(RO_NUMAUTOMATICCLI, value);
            _numautomaticcli = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Numautomaticfor
    {
        get
        {
            PropriedadeAcessada(RO_NUMAUTOMATICFOR);
            return _numautomaticfor;
        }
        set
        {
            PropriedadeModificada(RO_NUMAUTOMATICFOR, value);
            _numautomaticfor = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Numautomaticprod
    {
        get
        {
            PropriedadeAcessada(RO_NUMAUTOMATICPROD);
            return _numautomaticprod;
        }
        set
        {
            PropriedadeModificada(RO_NUMAUTOMATICPROD, value);
            _numautomaticprod = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 2, Precisao = 0)]
    public decimal? Numcasasdeccusto
    {
        get
        {
            PropriedadeAcessada(RO_NUMCASASDECCUSTO);
            return _numcasasdeccusto;
        }
        set
        {
            PropriedadeModificada(RO_NUMCASASDECCUSTO, value);
            _numcasasdeccusto = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 2, Precisao = 0)]
    public decimal? Numcasasdecestoque
    {
        get
        {
            PropriedadeAcessada(RO_NUMCASASDECESTOQUE);
            return _numcasasdecestoque;
        }
        set
        {
            PropriedadeModificada(RO_NUMCASASDECESTOQUE, value);
            _numcasasdecestoque = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 2, Precisao = 0)]
    public decimal? Numcasasdecinventario
    {
        get
        {
            PropriedadeAcessada(RO_NUMCASASDECINVENTARIO);
            return _numcasasdecinventario;
        }
        set
        {
            PropriedadeModificada(RO_NUMCASASDECINVENTARIO, value);
            _numcasasdecinventario = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 2, Precisao = 0)]
    public decimal? Numcasasdecproducao
    {
        get
        {
            PropriedadeAcessada(RO_NUMCASASDECPRODUCAO);
            return _numcasasdecproducao;
        }
        set
        {
            PropriedadeModificada(RO_NUMCASASDECPRODUCAO, value);
            _numcasasdecproducao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 2, Precisao = 0)]
    public decimal? Numcasasdecvenda
    {
        get
        {
            PropriedadeAcessada(RO_NUMCASASDECVENDA);
            return _numcasasdecvenda;
        }
        set
        {
            PropriedadeModificada(RO_NUMCASASDECVENDA, value);
            _numcasasdecvenda = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Numcustodiaautomatic
    {
        get
        {
            PropriedadeAcessada(RO_NUMCUSTODIAAUTOMATIC);
            return _numcustodiaautomatic;
        }
        set
        {
            PropriedadeModificada(RO_NUMCUSTODIAAUTOMATIC, value);
            _numcustodiaautomatic = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Numdiasaltdtentrega
    {
        get
        {
            PropriedadeAcessada(RO_NUMDIASALTDTENTREGA);
            return _numdiasaltdtentrega;
        }
        set
        {
            PropriedadeModificada(RO_NUMDIASALTDTENTREGA, value);
            _numdiasaltdtentrega = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 3, Precisao = 0)]
    public decimal? Numdiasalteralivro
    {
        get
        {
            PropriedadeAcessada(RO_NUMDIASALTERALIVRO);
            return _numdiasalteralivro;
        }
        set
        {
            PropriedadeModificada(RO_NUMDIASALTERALIVRO, value);
            _numdiasalteralivro = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 2, Precisao = 0)]
    public decimal? Numdiasatu
    {
        get
        {
            PropriedadeAcessada(RO_NUMDIASATU);
            return _numdiasatu;
        }
        set
        {
            PropriedadeModificada(RO_NUMDIASATU, value);
            _numdiasatu = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Numdiasbloqautomatic
    {
        get
        {
            PropriedadeAcessada(RO_NUMDIASBLOQAUTOMATIC);
            return _numdiasbloqautomatic;
        }
        set
        {
            PropriedadeModificada(RO_NUMDIASBLOQAUTOMATIC, value);
            _numdiasbloqautomatic = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 2, Precisao = 0)]
    public decimal? Numdiasbloqchp
    {
        get
        {
            PropriedadeAcessada(RO_NUMDIASBLOQCHP);
            return _numdiasbloqchp;
        }
        set
        {
            PropriedadeModificada(RO_NUMDIASBLOQCHP, value);
            _numdiasbloqchp = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Numdiascadclibloqchdv
    {
        get
        {
            PropriedadeAcessada(RO_NUMDIASCADCLIBLOQCHDV);
            return _numdiascadclibloqchdv;
        }
        set
        {
            PropriedadeModificada(RO_NUMDIASCADCLIBLOQCHDV, value);
            _numdiascadclibloqchdv = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Numdiaschdvbloqcli
    {
        get
        {
            PropriedadeAcessada(RO_NUMDIASCHDVBLOQCLI);
            return _numdiaschdvbloqcli;
        }
        set
        {
            PropriedadeModificada(RO_NUMDIASCHDVBLOQCLI, value);
            _numdiaschdvbloqcli = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Numdiascliinativ
    {
        get
        {
            PropriedadeAcessada(RO_NUMDIASCLIINATIV);
            return _numdiascliinativ;
        }
        set
        {
            PropriedadeModificada(RO_NUMDIASCLIINATIV, value);
            _numdiascliinativ = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Numdiasdesbloqchd1
    {
        get
        {
            PropriedadeAcessada(RO_NUMDIASDESBLOQCHD1);
            return _numdiasdesbloqchd1;
        }
        set
        {
            PropriedadeModificada(RO_NUMDIASDESBLOQCHD1, value);
            _numdiasdesbloqchd1 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Numdiasmaxacertarcarga
    {
        get
        {
            PropriedadeAcessada(RO_NUMDIASMAXACERTARCARGA);
            return _numdiasmaxacertarcarga;
        }
        set
        {
            PropriedadeModificada(RO_NUMDIASMAXACERTARCARGA, value);
            _numdiasmaxacertarcarga = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 3, Precisao = 0)]
    public decimal? Numdiasmaxbaixarecibo
    {
        get
        {
            PropriedadeAcessada(RO_NUMDIASMAXBAIXARECIBO);
            return _numdiasmaxbaixarecibo;
        }
        set
        {
            PropriedadeModificada(RO_NUMDIASMAXBAIXARECIBO, value);
            _numdiasmaxbaixarecibo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 3, Precisao = 0)]
    public decimal? Numdiasmaxcancbordero
    {
        get
        {
            PropriedadeAcessada(RO_NUMDIASMAXCANCBORDERO);
            return _numdiasmaxcancbordero;
        }
        set
        {
            PropriedadeModificada(RO_NUMDIASMAXCANCBORDERO, value);
            _numdiasmaxcancbordero = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 2, Precisao = 0)]
    public decimal? Numdiasmaxcancnfent
    {
        get
        {
            PropriedadeAcessada(RO_NUMDIASMAXCANCNFENT);
            return _numdiasmaxcancnfent;
        }
        set
        {
            PropriedadeModificada(RO_NUMDIASMAXCANCNFENT, value);
            _numdiasmaxcancnfent = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 2, Precisao = 0)]
    public decimal? Numdiasmaxcancnfsaida
    {
        get
        {
            PropriedadeAcessada(RO_NUMDIASMAXCANCNFSAIDA);
            return _numdiasmaxcancnfsaida;
        }
        set
        {
            PropriedadeModificada(RO_NUMDIASMAXCANCNFSAIDA, value);
            _numdiasmaxcancnfsaida = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Numdiasmaxdesdcpagar
    {
        get
        {
            PropriedadeAcessada(RO_NUMDIASMAXDESDCPAGAR);
            return _numdiasmaxdesdcpagar;
        }
        set
        {
            PropriedadeModificada(RO_NUMDIASMAXDESDCPAGAR, value);
            _numdiasmaxdesdcpagar = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Numdiasmaxdesd1210
    {
        get
        {
            PropriedadeAcessada(RO_NUMDIASMAXDESD1210);
            return _numdiasmaxdesd1210;
        }
        set
        {
            PropriedadeModificada(RO_NUMDIASMAXDESD1210, value);
            _numdiasmaxdesd1210 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Numdiasmaxdesd402
    {
        get
        {
            PropriedadeAcessada(RO_NUMDIASMAXDESD402);
            return _numdiasmaxdesd402;
        }
        set
        {
            PropriedadeModificada(RO_NUMDIASMAXDESD402, value);
            _numdiasmaxdesd402 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Numdiasmaxemissaocp
    {
        get
        {
            PropriedadeAcessada(RO_NUMDIASMAXEMISSAOCP);
            return _numdiasmaxemissaocp;
        }
        set
        {
            PropriedadeModificada(RO_NUMDIASMAXEMISSAOCP, value);
            _numdiasmaxemissaocp = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 3, Precisao = 0)]
    public decimal? Numdiasmaxemissaonf
    {
        get
        {
            PropriedadeAcessada(RO_NUMDIASMAXEMISSAONF);
            return _numdiasmaxemissaonf;
        }
        set
        {
            PropriedadeModificada(RO_NUMDIASMAXEMISSAONF, value);
            _numdiasmaxemissaonf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Numdiasmaxfatura
    {
        get
        {
            PropriedadeAcessada(RO_NUMDIASMAXFATURA);
            return _numdiasmaxfatura;
        }
        set
        {
            PropriedadeModificada(RO_NUMDIASMAXFATURA, value);
            _numdiasmaxfatura = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Numdiasmaxprorrog
    {
        get
        {
            PropriedadeAcessada(RO_NUMDIASMAXPRORROG);
            return _numdiasmaxprorrog;
        }
        set
        {
            PropriedadeModificada(RO_NUMDIASMAXPRORROG, value);
            _numdiasmaxprorrog = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Numdiasmaxvendacliinadimplente
    {
        get
        {
            PropriedadeAcessada(RO_NUMDIASMAXVENDACLIINADIMPLENTE);
            return _numdiasmaxvendacliinadimplente;
        }
        set
        {
            PropriedadeModificada(RO_NUMDIASMAXVENDACLIINADIMPLENTE, value);
            _numdiasmaxvendacliinadimplente = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Numdiasmindesppag
    {
        get
        {
            PropriedadeAcessada(RO_NUMDIASMINDESPPAG);
            return _numdiasmindesppag;
        }
        set
        {
            PropriedadeModificada(RO_NUMDIASMINDESPPAG, value);
            _numdiasmindesppag = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 2, Precisao = 0)]
    public decimal? Numdiasminvendabk
    {
        get
        {
            PropriedadeAcessada(RO_NUMDIASMINVENDABK);
            return _numdiasminvendabk;
        }
        set
        {
            PropriedadeModificada(RO_NUMDIASMINVENDABK, value);
            _numdiasminvendabk = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 3, Precisao = 0)]
    public decimal? Numdiaspagchqcancel
    {
        get
        {
            PropriedadeAcessada(RO_NUMDIASPAGCHQCANCEL);
            return _numdiaspagchqcancel;
        }
        set
        {
            PropriedadeModificada(RO_NUMDIASPAGCHQCANCEL, value);
            _numdiaspagchqcancel = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 3, Precisao = 0)]
    public decimal? Numdiaspagtoretro
    {
        get
        {
            PropriedadeAcessada(RO_NUMDIASPAGTORETRO);
            return _numdiaspagtoretro;
        }
        set
        {
            PropriedadeModificada(RO_NUMDIASPAGTORETRO, value);
            _numdiaspagtoretro = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Numdiasuteissemana
    {
        get
        {
            PropriedadeAcessada(RO_NUMDIASUTEISSEMANA);
            return _numdiasuteissemana;
        }
        set
        {
            PropriedadeModificada(RO_NUMDIASUTEISSEMANA, value);
            _numdiasuteissemana = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Numdiasuteistrimestre
    {
        get
        {
            PropriedadeAcessada(RO_NUMDIASUTEISTRIMESTRE);
            return _numdiasuteistrimestre;
        }
        set
        {
            PropriedadeModificada(RO_NUMDIASUTEISTRIMESTRE, value);
            _numdiasuteistrimestre = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Numdiasvenctitulocobext
    {
        get
        {
            PropriedadeAcessada(RO_NUMDIASVENCTITULOCOBEXT);
            return _numdiasvenctitulocobext;
        }
        set
        {
            PropriedadeModificada(RO_NUMDIASVENCTITULOCOBEXT, value);
            _numdiasvenctitulocobext = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Numdiasvenctitulocobint
    {
        get
        {
            PropriedadeAcessada(RO_NUMDIASVENCTITULOCOBINT);
            return _numdiasvenctitulocobint;
        }
        set
        {
            PropriedadeModificada(RO_NUMDIASVENCTITULOCOBINT, value);
            _numdiasvenctitulocobint = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Numitensos
    {
        get
        {
            PropriedadeAcessada(RO_NUMITENSOS);
            return _numitensos;
        }
        set
        {
            PropriedadeModificada(RO_NUMITENSOS, value);
            _numitensos = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 3, Precisao = 0)]
    public decimal? Nummaxnftransf
    {
        get
        {
            PropriedadeAcessada(RO_NUMMAXNFTRANSF);
            return _nummaxnftransf;
        }
        set
        {
            PropriedadeModificada(RO_NUMMAXNFTRANSF, value);
            _nummaxnftransf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Nummaxparcent
    {
        get
        {
            PropriedadeAcessada(RO_NUMMAXPARCENT);
            return _nummaxparcent;
        }
        set
        {
            PropriedadeModificada(RO_NUMMAXPARCENT, value);
            _nummaxparcent = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 3, Precisao = 0)]
    public decimal? Nummaxtitulosporrecibo
    {
        get
        {
            PropriedadeAcessada(RO_NUMMAXTITULOSPORRECIBO);
            return _nummaxtitulosporrecibo;
        }
        set
        {
            PropriedadeModificada(RO_NUMMAXTITULOSPORRECIBO, value);
            _nummaxtitulosporrecibo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numordabas
    {
        get
        {
            PropriedadeAcessada(RO_NUMORDABAS);
            return _numordabas;
        }
        set
        {
            PropriedadeModificada(RO_NUMORDABAS, value);
            _numordabas = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Numviasfichacp
    {
        get
        {
            PropriedadeAcessada(RO_NUMVIASFICHACP);
            return _numviasfichacp;
        }
        set
        {
            PropriedadeModificada(RO_NUMVIASFICHACP, value);
            _numviasfichacp = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 2, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Obterpreferenciacliecf
    {
        get
        {
            PropriedadeAcessada(RO_OBTERPREFERENCIACLIECF);
            return _obterpreferenciacliecf;
        }
        set
        {
            PropriedadeModificada(RO_OBTERPREFERENCIACLIECF, value);
            _obterpreferenciacliecf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 2, Precisao = 0)]
    public decimal? Ordemavaliacaocomissaorca
    {
        get
        {
            PropriedadeAcessada(RO_ORDEMAVALIACAOCOMISSAORCA);
            return _ordemavaliacaocomissaorca;
        }
        set
        {
            PropriedadeModificada(RO_ORDEMAVALIACAOCOMISSAORCA, value);
            _ordemavaliacaocomissaorca = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 2, Precisao = 0)]
    public decimal? Ordemmapa
    {
        get
        {
            PropriedadeAcessada(RO_ORDEMMAPA);
            return _ordemmapa;
        }
        set
        {
            PropriedadeModificada(RO_ORDEMMAPA, value);
            _ordemmapa = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Osreservanaexecucao
    {
        get
        {
            PropriedadeAcessada(RO_OSRESERVANAEXECUCAO);
            return _osreservanaexecucao;
        }
        set
        {
            PropriedadeModificada(RO_OSRESERVANAEXECUCAO, value);
            _osreservanaexecucao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Padraocallcenter
    {
        get
        {
            PropriedadeAcessada(RO_PADRAOCALLCENTER);
            return _padraocallcenter;
        }
        set
        {
            PropriedadeModificada(RO_PADRAOCALLCENTER, value);
            _padraocallcenter = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 60, Precisao = 0)]
    public string Pasta_Relatorio
    {
        get
        {
            PropriedadeAcessada(RO_PASTA_RELATORIO);
            return _pasta_relatorio;
        }
        set
        {
            PropriedadeModificada(RO_PASTA_RELATORIO, value);
            _pasta_relatorio = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Pckabastecido
    {
        get
        {
            PropriedadeAcessada(RO_PCKABASTECIDO);
            return _pckabastecido;
        }
        set
        {
            PropriedadeModificada(RO_PCKABASTECIDO, value);
            _pckabastecido = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Pedidocompraporpalete
    {
        get
        {
            PropriedadeAcessada(RO_PEDIDOCOMPRAPORPALETE);
            return _pedidocompraporpalete;
        }
        set
        {
            PropriedadeModificada(RO_PEDIDOCOMPRAPORPALETE, value);
            _pedidocompraporpalete = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Pedidopordistrib
    {
        get
        {
            PropriedadeAcessada(RO_PEDIDOPORDISTRIB);
            return _pedidopordistrib;
        }
        set
        {
            PropriedadeModificada(RO_PEDIDOPORDISTRIB, value);
            _pedidopordistrib = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Pedvendadepto
    {
        get
        {
            PropriedadeAcessada(RO_PEDVENDADEPTO);
            return _pedvendadepto;
        }
        set
        {
            PropriedadeModificada(RO_PEDVENDADEPTO, value);
            _pedvendadepto = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 2)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 6)]
    public decimal? Percacrescimocustofin
    {
        get
        {
            PropriedadeAcessada(RO_PERCACRESCIMOCUSTOFIN);
            return _percacrescimocustofin;
        }
        set
        {
            PropriedadeModificada(RO_PERCACRESCIMOCUSTOFIN, value);
            _percacrescimocustofin = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 6)]
    public decimal? Percacrescimocustoreal
    {
        get
        {
            PropriedadeAcessada(RO_PERCACRESCIMOCUSTOREAL);
            return _percacrescimocustoreal;
        }
        set
        {
            PropriedadeModificada(RO_PERCACRESCIMOCUSTOREAL, value);
            _percacrescimocustoreal = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 2)]
    public decimal? Percapanha
    {
        get
        {
            PropriedadeAcessada(RO_PERCAPANHA);
            return _percapanha;
        }
        set
        {
            PropriedadeModificada(RO_PERCAPANHA, value);
            _percapanha = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 2)]
    public decimal? Perccsrf
    {
        get
        {
            PropriedadeAcessada(RO_PERCCSRF);
            return _perccsrf;
        }
        set
        {
            PropriedadeModificada(RO_PERCCSRF, value);
            _perccsrf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 3, Precisao = 0)]
    public decimal? Percdifqtent
    {
        get
        {
            PropriedadeAcessada(RO_PERCDIFQTENT);
            return _percdifqtent;
        }
        set
        {
            PropriedadeModificada(RO_PERCDIFQTENT, value);
            _percdifqtent = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 7, Precisao = 4)]
    public decimal? Percexcessodevol
    {
        get
        {
            PropriedadeAcessada(RO_PERCEXCESSODEVOL);
            return _percexcessodevol;
        }
        set
        {
            PropriedadeModificada(RO_PERCEXCESSODEVOL, value);
            _percexcessodevol = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 2)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 2)]
    public decimal? Percicmfreteent
    {
        get
        {
            PropriedadeAcessada(RO_PERCICMFRETEENT);
            return _percicmfreteent;
        }
        set
        {
            PropriedadeModificada(RO_PERCICMFRETEENT, value);
            _percicmfreteent = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 2)]
    public decimal? Percicminterfrete
    {
        get
        {
            PropriedadeAcessada(RO_PERCICMINTERFRETE);
            return _percicminterfrete;
        }
        set
        {
            PropriedadeModificada(RO_PERCICMINTERFRETE, value);
            _percicminterfrete = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 2)]
    public decimal? Percicminterfreteent
    {
        get
        {
            PropriedadeAcessada(RO_PERCICMINTERFRETEENT);
            return _percicminterfreteent;
        }
        set
        {
            PropriedadeModificada(RO_PERCICMINTERFRETEENT, value);
            _percicminterfreteent = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 2)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Percjurosmora
    {
        get
        {
            PropriedadeAcessada(RO_PERCJUROSMORA);
            return _percjurosmora;
        }
        set
        {
            PropriedadeModificada(RO_PERCJUROSMORA, value);
            _percjurosmora = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Perclanccredcli
    {
        get
        {
            PropriedadeAcessada(RO_PERCLANCCREDCLI);
            return _perclanccredcli;
        }
        set
        {
            PropriedadeModificada(RO_PERCLANCCREDCLI, value);
            _perclanccredcli = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 2)]
    public decimal? Percmaxdesccr
    {
        get
        {
            PropriedadeAcessada(RO_PERCMAXDESCCR);
            return _percmaxdesccr;
        }
        set
        {
            PropriedadeModificada(RO_PERCMAXDESCCR, value);
            _percmaxdesccr = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 2)]
    public decimal? Percmaxdescdesd
    {
        get
        {
            PropriedadeAcessada(RO_PERCMAXDESCDESD);
            return _percmaxdescdesd;
        }
        set
        {
            PropriedadeModificada(RO_PERCMAXDESCDESD, value);
            _percmaxdescdesd = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Percmaxjurosmora
    {
        get
        {
            PropriedadeAcessada(RO_PERCMAXJUROSMORA);
            return _percmaxjurosmora;
        }
        set
        {
            PropriedadeModificada(RO_PERCMAXJUROSMORA, value);
            _percmaxjurosmora = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Percmaxlibestoque
    {
        get
        {
            PropriedadeAcessada(RO_PERCMAXLIBESTOQUE);
            return _percmaxlibestoque;
        }
        set
        {
            PropriedadeModificada(RO_PERCMAXLIBESTOQUE, value);
            _percmaxlibestoque = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Percminjurosmora
    {
        get
        {
            PropriedadeAcessada(RO_PERCMINJUROSMORA);
            return _percminjurosmora;
        }
        set
        {
            PropriedadeModificada(RO_PERCMINJUROSMORA, value);
            _percminjurosmora = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 3)]
    public decimal? Perctoleranciaimpureza
    {
        get
        {
            PropriedadeAcessada(RO_PERCTOLERANCIAIMPUREZA);
            return _perctoleranciaimpureza;
        }
        set
        {
            PropriedadeModificada(RO_PERCTOLERANCIAIMPUREZA, value);
            _perctoleranciaimpureza = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 3)]
    public decimal? Perctoleranciainteiro
    {
        get
        {
            PropriedadeAcessada(RO_PERCTOLERANCIAINTEIRO);
            return _perctoleranciainteiro;
        }
        set
        {
            PropriedadeModificada(RO_PERCTOLERANCIAINTEIRO, value);
            _perctoleranciainteiro = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 3)]
    public decimal? Perctoleranciaquebrado
    {
        get
        {
            PropriedadeAcessada(RO_PERCTOLERANCIAQUEBRADO);
            return _perctoleranciaquebrado;
        }
        set
        {
            PropriedadeModificada(RO_PERCTOLERANCIAQUEBRADO, value);
            _perctoleranciaquebrado = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 3)]
    public decimal? Perctoleranciaumidade
    {
        get
        {
            PropriedadeAcessada(RO_PERCTOLERANCIAUMIDADE);
            return _perctoleranciaumidade;
        }
        set
        {
            PropriedadeModificada(RO_PERCTOLERANCIAUMIDADE, value);
            _perctoleranciaumidade = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 3)]
    public decimal? Perctoleranciavermelho
    {
        get
        {
            PropriedadeAcessada(RO_PERCTOLERANCIAVERMELHO);
            return _perctoleranciavermelho;
        }
        set
        {
            PropriedadeModificada(RO_PERCTOLERANCIAVERMELHO, value);
            _perctoleranciavermelho = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 2)]
    public decimal? Perdescmaxbalcao
    {
        get
        {
            PropriedadeAcessada(RO_PERDESCMAXBALCAO);
            return _perdescmaxbalcao;
        }
        set
        {
            PropriedadeModificada(RO_PERDESCMAXBALCAO, value);
            _perdescmaxbalcao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 2)]
    public decimal? Perdescmediovenda
    {
        get
        {
            PropriedadeAcessada(RO_PERDESCMEDIOVENDA);
            return _perdescmediovenda;
        }
        set
        {
            PropriedadeModificada(RO_PERDESCMEDIOVENDA, value);
            _perdescmediovenda = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 2)]
    public decimal? Perdescprom
    {
        get
        {
            PropriedadeAcessada(RO_PERDESCPROM);
            return _perdescprom;
        }
        set
        {
            PropriedadeModificada(RO_PERDESCPROM, value);
            _perdescprom = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 2)]
    public decimal? Perexcedelimcred
    {
        get
        {
            PropriedadeAcessada(RO_PEREXCEDELIMCRED);
            return _perexcedelimcred;
        }
        set
        {
            PropriedadeModificada(RO_PEREXCEDELIMCRED, value);
            _perexcedelimcred = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Perguntarsomaqtpedvenda
    {
        get
        {
            PropriedadeAcessada(RO_PERGUNTARSOMAQTPEDVENDA);
            return _perguntarsomaqtpedvenda;
        }
        set
        {
            PropriedadeModificada(RO_PERGUNTARSOMAQTPEDVENDA, value);
            _perguntarsomaqtpedvenda = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Permaxdescautor
    {
        get
        {
            PropriedadeAcessada(RO_PERMAXDESCAUTOR);
            return _permaxdescautor;
        }
        set
        {
            PropriedadeModificada(RO_PERMAXDESCAUTOR, value);
            _permaxdescautor = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 2)]
    public decimal? Permaxdescitemcf
    {
        get
        {
            PropriedadeAcessada(RO_PERMAXDESCITEMCF);
            return _permaxdescitemcf;
        }
        set
        {
            PropriedadeModificada(RO_PERMAXDESCITEMCF, value);
            _permaxdescitemcf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 2)]
    public decimal? Permaxdescvenda
    {
        get
        {
            PropriedadeAcessada(RO_PERMAXDESCVENDA);
            return _permaxdescvenda;
        }
        set
        {
            PropriedadeModificada(RO_PERMAXDESCVENDA, value);
            _permaxdescvenda = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 2)]
    public decimal? Permaxdifentrada
    {
        get
        {
            PropriedadeAcessada(RO_PERMAXDIFENTRADA);
            return _permaxdifentrada;
        }
        set
        {
            PropriedadeModificada(RO_PERMAXDIFENTRADA, value);
            _permaxdifentrada = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Permaxindenizpedido
    {
        get
        {
            PropriedadeAcessada(RO_PERMAXINDENIZPEDIDO);
            return _permaxindenizpedido;
        }
        set
        {
            PropriedadeModificada(RO_PERMAXINDENIZPEDIDO, value);
            _permaxindenizpedido = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 2)]
    public decimal? Permaxpcompra
    {
        get
        {
            PropriedadeAcessada(RO_PERMAXPCOMPRA);
            return _permaxpcompra;
        }
        set
        {
            PropriedadeModificada(RO_PERMAXPCOMPRA, value);
            _permaxpcompra = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 2)]
    public decimal? Permaxrodape
    {
        get
        {
            PropriedadeAcessada(RO_PERMAXRODAPE);
            return _permaxrodape;
        }
        set
        {
            PropriedadeModificada(RO_PERMAXRODAPE, value);
            _permaxrodape = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Permaxrodapecheckout
    {
        get
        {
            PropriedadeAcessada(RO_PERMAXRODAPECHECKOUT);
            return _permaxrodapecheckout;
        }
        set
        {
            PropriedadeModificada(RO_PERMAXRODAPECHECKOUT, value);
            _permaxrodapecheckout = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Permaxvenda
    {
        get
        {
            PropriedadeAcessada(RO_PERMAXVENDA);
            return _permaxvenda;
        }
        set
        {
            PropriedadeModificada(RO_PERMAXVENDA, value);
            _permaxvenda = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 2)]
    public decimal? Permindifentrada
    {
        get
        {
            PropriedadeAcessada(RO_PERMINDIFENTRADA);
            return _permindifentrada;
        }
        set
        {
            PropriedadeModificada(RO_PERMINDIFENTRADA, value);
            _permindifentrada = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Permitealtcodcobvenda
    {
        get
        {
            PropriedadeAcessada(RO_PERMITEALTCODCOBVENDA);
            return _permitealtcodcobvenda;
        }
        set
        {
            PropriedadeModificada(RO_PERMITEALTCODCOBVENDA, value);
            _permitealtcodcobvenda = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Permitealtdtvencentmerc
    {
        get
        {
            PropriedadeAcessada(RO_PERMITEALTDTVENCENTMERC);
            return _permitealtdtvencentmerc;
        }
        set
        {
            PropriedadeModificada(RO_PERMITEALTDTVENCENTMERC, value);
            _permitealtdtvencentmerc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Permitealtplpagvenda
    {
        get
        {
            PropriedadeAcessada(RO_PERMITEALTPLPAGVENDA);
            return _permitealtplpagvenda;
        }
        set
        {
            PropriedadeModificada(RO_PERMITEALTPLPAGVENDA, value);
            _permitealtplpagvenda = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Permitecodbarraduplicado
    {
        get
        {
            PropriedadeAcessada(RO_PERMITECODBARRADUPLICADO);
            return _permitecodbarraduplicado;
        }
        set
        {
            PropriedadeModificada(RO_PERMITECODBARRADUPLICADO, value);
            _permitecodbarraduplicado = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Permitecomprafornecbloq
    {
        get
        {
            PropriedadeAcessada(RO_PERMITECOMPRAFORNECBLOQ);
            return _permitecomprafornecbloq;
        }
        set
        {
            PropriedadeModificada(RO_PERMITECOMPRAFORNECBLOQ, value);
            _permitecomprafornecbloq = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Permitecrdevfornec
    {
        get
        {
            PropriedadeAcessada(RO_PERMITECRDEVFORNEC);
            return _permitecrdevfornec;
        }
        set
        {
            PropriedadeModificada(RO_PERMITECRDEVFORNEC, value);
            _permitecrdevfornec = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Permitedesccr
    {
        get
        {
            PropriedadeAcessada(RO_PERMITEDESCCR);
            return _permitedesccr;
        }
        set
        {
            PropriedadeModificada(RO_PERMITEDESCCR, value);
            _permitedesccr = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Permitedevolreqnormal
    {
        get
        {
            PropriedadeAcessada(RO_PERMITEDEVOLREQNORMAL);
            return _permitedevolreqnormal;
        }
        set
        {
            PropriedadeModificada(RO_PERMITEDEVOLREQNORMAL, value);
            _permitedevolreqnormal = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Permiteiniciaropsemmp
    {
        get
        {
            PropriedadeAcessada(RO_PERMITEINICIAROPSEMMP);
            return _permiteiniciaropsemmp;
        }
        set
        {
            PropriedadeModificada(RO_PERMITEINICIAROPSEMMP, value);
            _permiteiniciaropsemmp = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Permitepedcompramultiplo
    {
        get
        {
            PropriedadeAcessada(RO_PERMITEPEDCOMPRAMULTIPLO);
            return _permitepedcompramultiplo;
        }
        set
        {
            PropriedadeModificada(RO_PERMITEPEDCOMPRAMULTIPLO, value);
            _permitepedcompramultiplo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Permitepedcompraunidmaster
    {
        get
        {
            PropriedadeAcessada(RO_PERMITEPEDCOMPRAUNIDMASTER);
            return _permitepedcompraunidmaster;
        }
        set
        {
            PropriedadeModificada(RO_PERMITEPEDCOMPRAUNIDMASTER, value);
            _permitepedcompraunidmaster = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Permiteplpagtosuperior
    {
        get
        {
            PropriedadeAcessada(RO_PERMITEPLPAGTOSUPERIOR);
            return _permiteplpagtosuperior;
        }
        set
        {
            PropriedadeModificada(RO_PERMITEPLPAGTOSUPERIOR, value);
            _permiteplpagtosuperior = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Permitevariospedidosorcamento
    {
        get
        {
            PropriedadeAcessada(RO_PERMITEVARIOSPEDIDOSORCAMENTO);
            return _permitevariospedidosorcamento;
        }
        set
        {
            PropriedadeModificada(RO_PERMITEVARIOSPEDIDOSORCAMENTO, value);
            _permitevariospedidosorcamento = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Permitevendaecf402
    {
        get
        {
            PropriedadeAcessada(RO_PERMITEVENDAECF402);
            return _permitevendaecf402;
        }
        set
        {
            PropriedadeModificada(RO_PERMITEVENDAECF402, value);
            _permitevendaecf402 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Permitevendaprodutopv
    {
        get
        {
            PropriedadeAcessada(RO_PERMITEVENDAPRODUTOPV);
            return _permitevendaprodutopv;
        }
        set
        {
            PropriedadeModificada(RO_PERMITEVENDAPRODUTOPV, value);
            _permitevendaprodutopv = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Permitirdescrodapecheckout
    {
        get
        {
            PropriedadeAcessada(RO_PERMITIRDESCRODAPECHECKOUT);
            return _permitirdescrodapecheckout;
        }
        set
        {
            PropriedadeModificada(RO_PERMITIRDESCRODAPECHECKOUT, value);
            _permitirdescrodapecheckout = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Permitirdesddevcli
    {
        get
        {
            PropriedadeAcessada(RO_PERMITIRDESDDEVCLI);
            return _permitirdesddevcli;
        }
        set
        {
            PropriedadeModificada(RO_PERMITIRDESDDEVCLI, value);
            _permitirdesddevcli = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Permitirdesdtitvencsemjuros
    {
        get
        {
            PropriedadeAcessada(RO_PERMITIRDESDTITVENCSEMJUROS);
            return _permitirdesdtitvencsemjuros;
        }
        set
        {
            PropriedadeModificada(RO_PERMITIRDESDTITVENCSEMJUROS, value);
            _permitirdesdtitvencsemjuros = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Permitirdivnfduplic
    {
        get
        {
            PropriedadeAcessada(RO_PERMITIRDIVNFDUPLIC);
            return _permitirdivnfduplic;
        }
        set
        {
            PropriedadeModificada(RO_PERMITIRDIVNFDUPLIC, value);
            _permitirdivnfduplic = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 2)]
    public decimal? Pesomaxpalete
    {
        get
        {
            PropriedadeAcessada(RO_PESOMAXPALETE);
            return _pesomaxpalete;
        }
        set
        {
            PropriedadeModificada(RO_PESOMAXPALETE, value);
            _pesomaxpalete = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Pesosuppalete
    {
        get
        {
            PropriedadeAcessada(RO_PESOSUPPALETE);
            return _pesosuppalete;
        }
        set
        {
            PropriedadeModificada(RO_PESOSUPPALETE, value);
            _pesosuppalete = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 2)]
    public decimal? Pesotransf
    {
        get
        {
            PropriedadeAcessada(RO_PESOTRANSF);
            return _pesotransf;
        }
        set
        {
            PropriedadeModificada(RO_PESOTRANSF, value);
            _pesotransf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Portanfe
    {
        get
        {
            PropriedadeAcessada(RO_PORTANFE);
            return _portanfe;
        }
        set
        {
            PropriedadeModificada(RO_PORTANFE, value);
            _portanfe = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 0)]
    public decimal? Prazoadicionalmax
    {
        get
        {
            PropriedadeAcessada(RO_PRAZOADICIONALMAX);
            return _prazoadicionalmax;
        }
        set
        {
            PropriedadeModificada(RO_PRAZOADICIONALMAX, value);
            _prazoadicionalmax = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 3, Precisao = 0)]
    public decimal? Prazoedicaopedidocompra
    {
        get
        {
            PropriedadeAcessada(RO_PRAZOEDICAOPEDIDOCOMPRA);
            return _prazoedicaopedidocompra;
        }
        set
        {
            PropriedadeModificada(RO_PRAZOEDICAOPEDIDOCOMPRA, value);
            _prazoedicaopedidocompra = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Prazoentrega
    {
        get
        {
            PropriedadeAcessada(RO_PRAZOENTREGA);
            return _prazoentrega;
        }
        set
        {
            PropriedadeModificada(RO_PRAZOENTREGA, value);
            _prazoentrega = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Prazofatalmed
    {
        get
        {
            PropriedadeAcessada(RO_PRAZOFATALMED);
            return _prazofatalmed;
        }
        set
        {
            PropriedadeModificada(RO_PRAZOFATALMED, value);
            _prazofatalmed = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 3, Precisao = 0)]
    public decimal? Prazomaxdtentrega
    {
        get
        {
            PropriedadeAcessada(RO_PRAZOMAXDTENTREGA);
            return _prazomaxdtentrega;
        }
        set
        {
            PropriedadeModificada(RO_PRAZOMAXDTENTREGA, value);
            _prazomaxdtentrega = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 2)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 2)]
    public decimal? Prazominvalidade
    {
        get
        {
            PropriedadeAcessada(RO_PRAZOMINVALIDADE);
            return _prazominvalidade;
        }
        set
        {
            PropriedadeModificada(RO_PRAZOMINVALIDADE, value);
            _prazominvalidade = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Prazovalidadeorcamento
    {
        get
        {
            PropriedadeAcessada(RO_PRAZOVALIDADEORCAMENTO);
            return _prazovalidadeorcamento;
        }
        set
        {
            PropriedadeModificada(RO_PRAZOVALIDADEORCAMENTO, value);
            _prazovalidadeorcamento = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Prazovalidadepedbalcao
    {
        get
        {
            PropriedadeAcessada(RO_PRAZOVALIDADEPEDBALCAO);
            return _prazovalidadepedbalcao;
        }
        set
        {
            PropriedadeModificada(RO_PRAZOVALIDADEPEDBALCAO, value);
            _prazovalidadepedbalcao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Procnumlista
    {
        get
        {
            PropriedadeAcessada(RO_PROCNUMLISTA);
            return _procnumlista;
        }
        set
        {
            PropriedadeModificada(RO_PROCNUMLISTA, value);
            _procnumlista = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Proxcodplpag
    {
        get
        {
            PropriedadeAcessada(RO_PROXCODPLPAG);
            return _proxcodplpag;
        }
        set
        {
            PropriedadeModificada(RO_PROXCODPLPAG, value);
            _proxcodplpag = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Proxcodpraca
    {
        get
        {
            PropriedadeAcessada(RO_PROXCODPRACA);
            return _proxcodpraca;
        }
        set
        {
            PropriedadeModificada(RO_PROXCODPRACA, value);
            _proxcodpraca = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Proxcodusur
    {
        get
        {
            PropriedadeAcessada(RO_PROXCODUSUR);
            return _proxcodusur;
        }
        set
        {
            PropriedadeModificada(RO_PROXCODUSUR, value);
            _proxcodusur = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Proxnumaplic
    {
        get
        {
            PropriedadeAcessada(RO_PROXNUMAPLIC);
            return _proxnumaplic;
        }
        set
        {
            PropriedadeModificada(RO_PROXNUMAPLIC, value);
            _proxnumaplic = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Proxnumbonus
    {
        get
        {
            PropriedadeAcessada(RO_PROXNUMBONUS);
            return _proxnumbonus;
        }
        set
        {
            PropriedadeModificada(RO_PROXNUMBONUS, value);
            _proxnumbonus = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Proxnumbordero
    {
        get
        {
            PropriedadeAcessada(RO_PROXNUMBORDERO);
            return _proxnumbordero;
        }
        set
        {
            PropriedadeModificada(RO_PROXNUMBORDERO, value);
            _proxnumbordero = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Proxnumborderocr
    {
        get
        {
            PropriedadeAcessada(RO_PROXNUMBORDEROCR);
            return _proxnumborderocr;
        }
        set
        {
            PropriedadeModificada(RO_PROXNUMBORDEROCR, value);
            _proxnumborderocr = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Proxnumcar
    {
        get
        {
            PropriedadeAcessada(RO_PROXNUMCAR);
            return _proxnumcar;
        }
        set
        {
            PropriedadeModificada(RO_PROXNUMCAR, value);
            _proxnumcar = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Proxnumcli
    {
        get
        {
            PropriedadeAcessada(RO_PROXNUMCLI);
            return _proxnumcli;
        }
        set
        {
            PropriedadeModificada(RO_PROXNUMCLI, value);
            _proxnumcli = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Proxnumcodbarralote
    {
        get
        {
            PropriedadeAcessada(RO_PROXNUMCODBARRALOTE);
            return _proxnumcodbarralote;
        }
        set
        {
            PropriedadeModificada(RO_PROXNUMCODBARRALOTE, value);
            _proxnumcodbarralote = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Proxnumcontrato
    {
        get
        {
            PropriedadeAcessada(RO_PROXNUMCONTRATO);
            return _proxnumcontrato;
        }
        set
        {
            PropriedadeModificada(RO_PROXNUMCONTRATO, value);
            _proxnumcontrato = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Proxnumcustodia
    {
        get
        {
            PropriedadeAcessada(RO_PROXNUMCUSTODIA);
            return _proxnumcustodia;
        }
        set
        {
            PropriedadeModificada(RO_PROXNUMCUSTODIA, value);
            _proxnumcustodia = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Proxnumfornec
    {
        get
        {
            PropriedadeAcessada(RO_PROXNUMFORNEC);
            return _proxnumfornec;
        }
        set
        {
            PropriedadeModificada(RO_PROXNUMFORNEC, value);
            _proxnumfornec = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Proxnumindeniz
    {
        get
        {
            PropriedadeAcessada(RO_PROXNUMINDENIZ);
            return _proxnumindeniz;
        }
        set
        {
            PropriedadeModificada(RO_PROXNUMINDENIZ, value);
            _proxnumindeniz = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Proxnuminventrot
    {
        get
        {
            PropriedadeAcessada(RO_PROXNUMINVENTROT);
            return _proxnuminventrot;
        }
        set
        {
            PropriedadeModificada(RO_PROXNUMINVENTROT, value);
            _proxnuminventrot = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Proxnumlanc
    {
        get
        {
            PropriedadeAcessada(RO_PROXNUMLANC);
            return _proxnumlanc;
        }
        set
        {
            PropriedadeModificada(RO_PROXNUMLANC, value);
            _proxnumlanc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Proxnumlotecustodia
    {
        get
        {
            PropriedadeAcessada(RO_PROXNUMLOTECUSTODIA);
            return _proxnumlotecustodia;
        }
        set
        {
            PropriedadeModificada(RO_PROXNUMLOTECUSTODIA, value);
            _proxnumlotecustodia = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Proxnumloteem
    {
        get
        {
            PropriedadeAcessada(RO_PROXNUMLOTEEM);
            return _proxnumloteem;
        }
        set
        {
            PropriedadeModificada(RO_PROXNUMLOTEEM, value);
            _proxnumloteem = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Proxnumlotemp
    {
        get
        {
            PropriedadeAcessada(RO_PROXNUMLOTEMP);
            return _proxnumlotemp;
        }
        set
        {
            PropriedadeModificada(RO_PROXNUMLOTEMP, value);
            _proxnumlotemp = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Proxnumlotenfe
    {
        get
        {
            PropriedadeAcessada(RO_PROXNUMLOTENFE);
            return _proxnumlotenfe;
        }
        set
        {
            PropriedadeModificada(RO_PROXNUMLOTENFE, value);
            _proxnumlotenfe = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Proxnumlotenfedpec
    {
        get
        {
            PropriedadeAcessada(RO_PROXNUMLOTENFEDPEC);
            return _proxnumlotenfedpec;
        }
        set
        {
            PropriedadeModificada(RO_PROXNUMLOTENFEDPEC, value);
            _proxnumlotenfedpec = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Proxnumlotereagente
    {
        get
        {
            PropriedadeAcessada(RO_PROXNUMLOTEREAGENTE);
            return _proxnumlotereagente;
        }
        set
        {
            PropriedadeModificada(RO_PROXNUMLOTEREAGENTE, value);
            _proxnumlotereagente = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Proxnumlotesa
    {
        get
        {
            PropriedadeAcessada(RO_PROXNUMLOTESA);
            return _proxnumlotesa;
        }
        set
        {
            PropriedadeModificada(RO_PROXNUMLOTESA, value);
            _proxnumlotesa = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Proxnummanif
    {
        get
        {
            PropriedadeAcessada(RO_PROXNUMMANIF);
            return _proxnummanif;
        }
        set
        {
            PropriedadeModificada(RO_PROXNUMMANIF, value);
            _proxnummanif = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Proxnumneg
    {
        get
        {
            PropriedadeAcessada(RO_PROXNUMNEG);
            return _proxnumneg;
        }
        set
        {
            PropriedadeModificada(RO_PROXNUMNEG, value);
            _proxnumneg = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Proxnumop
    {
        get
        {
            PropriedadeAcessada(RO_PROXNUMOP);
            return _proxnumop;
        }
        set
        {
            PropriedadeModificada(RO_PROXNUMOP, value);
            _proxnumop = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Proxnumopi
    {
        get
        {
            PropriedadeAcessada(RO_PROXNUMOPI);
            return _proxnumopi;
        }
        set
        {
            PropriedadeModificada(RO_PROXNUMOPI, value);
            _proxnumopi = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Proxnumordemtransf
    {
        get
        {
            PropriedadeAcessada(RO_PROXNUMORDEMTRANSF);
            return _proxnumordemtransf;
        }
        set
        {
            PropriedadeModificada(RO_PROXNUMORDEMTRANSF, value);
            _proxnumordemtransf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Proxnumpcp
    {
        get
        {
            PropriedadeAcessada(RO_PROXNUMPCP);
            return _proxnumpcp;
        }
        set
        {
            PropriedadeModificada(RO_PROXNUMPCP, value);
            _proxnumpcp = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Proxnumped
    {
        get
        {
            PropriedadeAcessada(RO_PROXNUMPED);
            return _proxnumped;
        }
        set
        {
            PropriedadeModificada(RO_PROXNUMPED, value);
            _proxnumped = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Proxnumpedtlmk
    {
        get
        {
            PropriedadeAcessada(RO_PROXNUMPEDTLMK);
            return _proxnumpedtlmk;
        }
        set
        {
            PropriedadeModificada(RO_PROXNUMPEDTLMK, value);
            _proxnumpedtlmk = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Proxnumpesquisa
    {
        get
        {
            PropriedadeAcessada(RO_PROXNUMPESQUISA);
            return _proxnumpesquisa;
        }
        set
        {
            PropriedadeModificada(RO_PROXNUMPESQUISA, value);
            _proxnumpesquisa = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Proxnumprodut
    {
        get
        {
            PropriedadeAcessada(RO_PROXNUMPRODUT);
            return _proxnumprodut;
        }
        set
        {
            PropriedadeModificada(RO_PROXNUMPRODUT, value);
            _proxnumprodut = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Proxnumrca
    {
        get
        {
            PropriedadeAcessada(RO_PROXNUMRCA);
            return _proxnumrca;
        }
        set
        {
            PropriedadeModificada(RO_PROXNUMRCA, value);
            _proxnumrca = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Proxnumrpa
    {
        get
        {
            PropriedadeAcessada(RO_PROXNUMRPA);
            return _proxnumrpa;
        }
        set
        {
            PropriedadeModificada(RO_PROXNUMRPA, value);
            _proxnumrpa = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Proxnumsimulacaopcp
    {
        get
        {
            PropriedadeAcessada(RO_PROXNUMSIMULACAOPCP);
            return _proxnumsimulacaopcp;
        }
        set
        {
            PropriedadeModificada(RO_PROXNUMSIMULACAOPCP, value);
            _proxnumsimulacaopcp = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Proxnumtira
    {
        get
        {
            PropriedadeAcessada(RO_PROXNUMTIRA);
            return _proxnumtira;
        }
        set
        {
            PropriedadeModificada(RO_PROXNUMTIRA, value);
            _proxnumtira = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Proxnumtrans
    {
        get
        {
            PropriedadeAcessada(RO_PROXNUMTRANS);
            return _proxnumtrans;
        }
        set
        {
            PropriedadeModificada(RO_PROXNUMTRANS, value);
            _proxnumtrans = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Proxnumtransavulsa
    {
        get
        {
            PropriedadeAcessada(RO_PROXNUMTRANSAVULSA);
            return _proxnumtransavulsa;
        }
        set
        {
            PropriedadeModificada(RO_PROXNUMTRANSAVULSA, value);
            _proxnumtransavulsa = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Proxnumtranscrfor
    {
        get
        {
            PropriedadeAcessada(RO_PROXNUMTRANSCRFOR);
            return _proxnumtranscrfor;
        }
        set
        {
            PropriedadeModificada(RO_PROXNUMTRANSCRFOR, value);
            _proxnumtranscrfor = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Proxnumtransent
    {
        get
        {
            PropriedadeAcessada(RO_PROXNUMTRANSENT);
            return _proxnumtransent;
        }
        set
        {
            PropriedadeModificada(RO_PROXNUMTRANSENT, value);
            _proxnumtransent = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Proxnumtransop
    {
        get
        {
            PropriedadeAcessada(RO_PROXNUMTRANSOP);
            return _proxnumtransop;
        }
        set
        {
            PropriedadeModificada(RO_PROXNUMTRANSOP, value);
            _proxnumtransop = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Proxnumtransvenda
    {
        get
        {
            PropriedadeAcessada(RO_PROXNUMTRANSVENDA);
            return _proxnumtransvenda;
        }
        set
        {
            PropriedadeModificada(RO_PROXNUMTRANSVENDA, value);
            _proxnumtransvenda = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Proxnumtransvendor
    {
        get
        {
            PropriedadeAcessada(RO_PROXNUMTRANSVENDOR);
            return _proxnumtransvendor;
        }
        set
        {
            PropriedadeModificada(RO_PROXNUMTRANSVENDOR, value);
            _proxnumtransvendor = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Proxnumtranswms
    {
        get
        {
            PropriedadeAcessada(RO_PROXNUMTRANSWMS);
            return _proxnumtranswms;
        }
        set
        {
            PropriedadeModificada(RO_PROXNUMTRANSWMS, value);
            _proxnumtranswms = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Proxnumtroca
    {
        get
        {
            PropriedadeAcessada(RO_PROXNUMTROCA);
            return _proxnumtroca;
        }
        set
        {
            PropriedadeModificada(RO_PROXNUMTROCA, value);
            _proxnumtroca = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Proxnumvale
    {
        get
        {
            PropriedadeAcessada(RO_PROXNUMVALE);
            return _proxnumvale;
        }
        set
        {
            PropriedadeModificada(RO_PROXNUMVALE, value);
            _proxnumvale = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Proxnumverba
    {
        get
        {
            PropriedadeAcessada(RO_PROXNUMVERBA);
            return _proxnumverba;
        }
        set
        {
            PropriedadeModificada(RO_PROXNUMVERBA, value);
            _proxnumverba = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Qtchdvbloqcli
    {
        get
        {
            PropriedadeAcessada(RO_QTCHDVBLOQCLI);
            return _qtchdvbloqcli;
        }
        set
        {
            PropriedadeModificada(RO_QTCHDVBLOQCLI, value);
            _qtchdvbloqcli = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 2, Precisao = 0)]
    public decimal? Qtdegerlivro
    {
        get
        {
            PropriedadeAcessada(RO_QTDEGERLIVRO);
            return _qtdegerlivro;
        }
        set
        {
            PropriedadeModificada(RO_QTDEGERLIVRO, value);
            _qtdegerlivro = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Qtdeminimausoasterisco936
    {
        get
        {
            PropriedadeAcessada(RO_QTDEMINIMAUSOASTERISCO936);
            return _qtdeminimausoasterisco936;
        }
        set
        {
            PropriedadeModificada(RO_QTDEMINIMAUSOASTERISCO936, value);
            _qtdeminimausoasterisco936 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 2, Precisao = 0)]
    public decimal? Qtdeparcelasimpostosfrete
    {
        get
        {
            PropriedadeAcessada(RO_QTDEPARCELASIMPOSTOSFRETE);
            return _qtdeparcelasimpostosfrete;
        }
        set
        {
            PropriedadeModificada(RO_QTDEPARCELASIMPOSTOSFRETE, value);
            _qtdeparcelasimpostosfrete = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Qtmaxunidadepf
    {
        get
        {
            PropriedadeAcessada(RO_QTMAXUNIDADEPF);
            return _qtmaxunidadepf;
        }
        set
        {
            PropriedadeModificada(RO_QTMAXUNIDADEPF, value);
            _qtmaxunidadepf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 2, Precisao = 0)]
    public decimal? Qtmesesclassestrelas
    {
        get
        {
            PropriedadeAcessada(RO_QTMESESCLASSESTRELAS);
            return _qtmesesclassestrelas;
        }
        set
        {
            PropriedadeModificada(RO_QTMESESCLASSESTRELAS, value);
            _qtmesesclassestrelas = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 2, Precisao = 0)]
    public decimal? Qtmesesclassgrupocartao
    {
        get
        {
            PropriedadeAcessada(RO_QTMESESCLASSGRUPOCARTAO);
            return _qtmesesclassgrupocartao;
        }
        set
        {
            PropriedadeModificada(RO_QTMESESCLASSGRUPOCARTAO, value);
            _qtmesesclassgrupocartao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Qtmesescredciap
    {
        get
        {
            PropriedadeAcessada(RO_QTMESESCREDCIAP);
            return _qtmesescredciap;
        }
        set
        {
            PropriedadeModificada(RO_QTMESESCREDCIAP, value);
            _qtmesescredciap = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 2, Precisao = 0)]
    public decimal? Qtmesesgrupos
    {
        get
        {
            PropriedadeAcessada(RO_QTMESESGRUPOS);
            return _qtmesesgrupos;
        }
        set
        {
            PropriedadeModificada(RO_QTMESESGRUPOS, value);
            _qtmesesgrupos = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Rateiodescbaixacr
    {
        get
        {
            PropriedadeAcessada(RO_RATEIODESCBAIXACR);
            return _rateiodescbaixacr;
        }
        set
        {
            PropriedadeModificada(RO_RATEIODESCBAIXACR, value);
            _rateiodescbaixacr = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Rebaixacustoultent
    {
        get
        {
            PropriedadeAcessada(RO_REBAIXACUSTOULTENT);
            return _rebaixacustoultent;
        }
        set
        {
            PropriedadeModificada(RO_REBAIXACUSTOULTENT, value);
            _rebaixacustoultent = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Reducaobcisenta
    {
        get
        {
            PropriedadeAcessada(RO_REDUCAOBCISENTA);
            return _reducaobcisenta;
        }
        set
        {
            PropriedadeModificada(RO_REDUCAOBCISENTA, value);
            _reducaobcisenta = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Replicarprecoporembalagem
    {
        get
        {
            PropriedadeAcessada(RO_REPLICARPRECOPOREMBALAGEM);
            return _replicarprecoporembalagem;
        }
        set
        {
            PropriedadeModificada(RO_REPLICARPRECOPOREMBALAGEM, value);
            _replicarprecoporembalagem = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Restringenumitensnf
    {
        get
        {
            PropriedadeAcessada(RO_RESTRINGENUMITENSNF);
            return _restringenumitensnf;
        }
        set
        {
            PropriedadeModificada(RO_RESTRINGENUMITENSNF, value);
            _restringenumitensnf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Restringenumviasnf
    {
        get
        {
            PropriedadeAcessada(RO_RESTRINGENUMVIASNF);
            return _restringenumviasnf;
        }
        set
        {
            PropriedadeModificada(RO_RESTRINGENUMVIASNF, value);
            _restringenumviasnf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Restringenumviaspu
    {
        get
        {
            PropriedadeAcessada(RO_RESTRINGENUMVIASPU);
            return _restringenumviaspu;
        }
        set
        {
            PropriedadeModificada(RO_RESTRINGENUMVIASPU, value);
            _restringenumviaspu = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Restringirconferencialote
    {
        get
        {
            PropriedadeAcessada(RO_RESTRINGIRCONFERENCIALOTE);
            return _restringirconferencialote;
        }
        set
        {
            PropriedadeModificada(RO_RESTRINGIRCONFERENCIALOTE, value);
            _restringirconferencialote = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 1, Precisao = 0)]
    public decimal? Rotina2562emuso
    {
        get
        {
            PropriedadeAcessada(RO_ROTINA2562EMUSO);
            return _rotina2562emuso;
        }
        set
        {
            PropriedadeModificada(RO_ROTINA2562EMUSO, value);
            _rotina2562emuso = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Saltarpaginarua
    {
        get
        {
            PropriedadeAcessada(RO_SALTARPAGINARUA);
            return _saltarpaginarua;
        }
        set
        {
            PropriedadeModificada(RO_SALTARPAGINARUA, value);
            _saltarpaginarua = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 3, Precisao = 0)]
    public decimal? Segmentoserasa
    {
        get
        {
            PropriedadeAcessada(RO_SEGMENTOSERASA);
            return _segmentoserasa;
        }
        set
        {
            PropriedadeModificada(RO_SEGMENTOSERASA, value);
            _segmentoserasa = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Sempreatualizaqtestconvemb
    {
        get
        {
            PropriedadeAcessada(RO_SEMPREATUALIZAQTESTCONVEMB);
            return _sempreatualizaqtestconvemb;
        }
        set
        {
            PropriedadeModificada(RO_SEMPREATUALIZAQTESTCONVEMB, value);
            _sempreatualizaqtestconvemb = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 32, Precisao = 0)]
    public string Senhalogon
    {
        get
        {
            PropriedadeAcessada(RO_SENHALOGON);
            return _senhalogon;
        }
        set
        {
            PropriedadeModificada(RO_SENHALOGON, value);
            _senhalogon = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Separacaoflowrack
    {
        get
        {
            PropriedadeAcessada(RO_SEPARACAOFLOWRACK);
            return _separacaoflowrack;
        }
        set
        {
            PropriedadeModificada(RO_SEPARACAOFLOWRACK, value);
            _separacaoflowrack = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Separarprodcomrestricaotransp
    {
        get
        {
            PropriedadeAcessada(RO_SEPARARPRODCOMRESTRICAOTRANSP);
            return _separarprodcomrestricaotransp;
        }
        set
        {
            PropriedadeModificada(RO_SEPARARPRODCOMRESTRICAOTRANSP, value);
            _separarprodcomrestricaotransp = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 3, Precisao = 0)]
    public string Siglaespecie
    {
        get
        {
            PropriedadeAcessada(RO_SIGLAESPECIE);
            return _siglaespecie;
        }
        set
        {
            PropriedadeModificada(RO_SIGLAESPECIE, value);
            _siglaespecie = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 3, Precisao = 0)]
    public string Siglaserie
    {
        get
        {
            PropriedadeAcessada(RO_SIGLASERIE);
            return _siglaserie;
        }
        set
        {
            PropriedadeModificada(RO_SIGLASERIE, value);
            _siglaserie = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Situacaoinicialbloqueio
    {
        get
        {
            PropriedadeAcessada(RO_SITUACAOINICIALBLOQUEIO);
            return _situacaoinicialbloqueio;
        }
        set
        {
            PropriedadeModificada(RO_SITUACAOINICIALBLOQUEIO, value);
            _situacaoinicialbloqueio = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Somacomissaocmv
    {
        get
        {
            PropriedadeAcessada(RO_SOMACOMISSAOCMV);
            return _somacomissaocmv;
        }
        set
        {
            PropriedadeModificada(RO_SOMACOMISSAOCMV, value);
            _somacomissaocmv = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Somacompraprevfluxocx
    {
        get
        {
            PropriedadeAcessada(RO_SOMACOMPRAPREVFLUXOCX);
            return _somacompraprevfluxocx;
        }
        set
        {
            PropriedadeModificada(RO_SOMACOMPRAPREVFLUXOCX, value);
            _somacompraprevfluxocx = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Somadescclidescprod
    {
        get
        {
            PropriedadeAcessada(RO_SOMADESCCLIDESCPROD);
            return _somadescclidescprod;
        }
        set
        {
            PropriedadeModificada(RO_SOMADESCCLIDESCPROD, value);
            _somadescclidescprod = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Somadespfinitemcf
    {
        get
        {
            PropriedadeAcessada(RO_SOMADESPFINITEMCF);
            return _somadespfinitemcf;
        }
        set
        {
            PropriedadeModificada(RO_SOMADESPFINITEMCF, value);
            _somadespfinitemcf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Somaicmsantecipduplic
    {
        get
        {
            PropriedadeAcessada(RO_SOMAICMSANTECIPDUPLIC);
            return _somaicmsantecipduplic;
        }
        set
        {
            PropriedadeModificada(RO_SOMAICMSANTECIPDUPLIC, value);
            _somaicmsantecipduplic = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Somaimpostostransf
    {
        get
        {
            PropriedadeAcessada(RO_SOMAIMPOSTOSTRANSF);
            return _somaimpostostransf;
        }
        set
        {
            PropriedadeModificada(RO_SOMAIMPOSTOSTRANSF, value);
            _somaimpostostransf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Somaqtpedvenda
    {
        get
        {
            PropriedadeAcessada(RO_SOMAQTPEDVENDA);
            return _somaqtpedvenda;
        }
        set
        {
            PropriedadeModificada(RO_SOMAQTPEDVENDA, value);
            _somaqtpedvenda = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Somatarifabancnf
    {
        get
        {
            PropriedadeAcessada(RO_SOMATARIFABANCNF);
            return _somatarifabancnf;
        }
        set
        {
            PropriedadeModificada(RO_SOMATARIFABANCNF, value);
            _somatarifabancnf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Somatxboleto
    {
        get
        {
            PropriedadeAcessada(RO_SOMATXBOLETO);
            return _somatxboleto;
        }
        set
        {
            PropriedadeModificada(RO_SOMATXBOLETO, value);
            _somatxboleto = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Somavltarifaitensnf
    {
        get
        {
            PropriedadeAcessada(RO_SOMAVLTARIFAITENSNF);
            return _somavltarifaitensnf;
        }
        set
        {
            PropriedadeModificada(RO_SOMAVLTARIFAITENSNF, value);
            _somavltarifaitensnf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Somentecodbarrasbonus
    {
        get
        {
            PropriedadeAcessada(RO_SOMENTECODBARRASBONUS);
            return _somentecodbarrasbonus;
        }
        set
        {
            PropriedadeModificada(RO_SOMENTECODBARRASBONUS, value);
            _somentecodbarrasbonus = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Somentecodbarrasconfped
    {
        get
        {
            PropriedadeAcessada(RO_SOMENTECODBARRASCONFPED);
            return _somentecodbarrasconfped;
        }
        set
        {
            PropriedadeModificada(RO_SOMENTECODBARRASCONFPED, value);
            _somentecodbarrasconfped = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 2, Precisao = 0)]
    public decimal? Sugvenda
    {
        get
        {
            PropriedadeAcessada(RO_SUGVENDA);
            return _sugvenda;
        }
        set
        {
            PropriedadeModificada(RO_SUGVENDA, value);
            _sugvenda = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Tarjamagneticaobrigatoria
    {
        get
        {
            PropriedadeAcessada(RO_TARJAMAGNETICAOBRIGATORIA);
            return _tarjamagneticaobrigatoria;
        }
        set
        {
            PropriedadeModificada(RO_TARJAMAGNETICAOBRIGATORIA, value);
            _tarjamagneticaobrigatoria = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Taxatabpr
    {
        get
        {
            PropriedadeAcessada(RO_TAXATABPR);
            return _taxatabpr;
        }
        set
        {
            PropriedadeModificada(RO_TAXATABPR, value);
            _taxatabpr = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 13, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Tempmenflow
    {
        get
        {
            PropriedadeAcessada(RO_TEMPMENFLOW);
            return _tempmenflow;
        }
        set
        {
            PropriedadeModificada(RO_TEMPMENFLOW, value);
            _tempmenflow = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 5, Precisao = 0)]
    public string Tempomaxcancel
    {
        get
        {
            PropriedadeAcessada(RO_TEMPOMAXCANCEL);
            return _tempomaxcancel;
        }
        set
        {
            PropriedadeModificada(RO_TEMPOMAXCANCEL, value);
            _tempomaxcancel = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Temrepos
    {
        get
        {
            PropriedadeAcessada(RO_TEMREPOS);
            return _temrepos;
        }
        set
        {
            PropriedadeModificada(RO_TEMREPOS, value);
            _temrepos = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 3, Precisao = 0)]
    public decimal? Timermsgagenda
    {
        get
        {
            PropriedadeAcessada(RO_TIMERMSGAGENDA);
            return _timermsgagenda;
        }
        set
        {
            PropriedadeModificada(RO_TIMERMSGAGENDA, value);
            _timermsgagenda = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Tipoabasprev
    {
        get
        {
            PropriedadeAcessada(RO_TIPOABASPREV);
            return _tipoabasprev;
        }
        set
        {
            PropriedadeModificada(RO_TIPOABASPREV, value);
            _tipoabasprev = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Tipoaplicindice
    {
        get
        {
            PropriedadeAcessada(RO_TIPOAPLICINDICE);
            return _tipoaplicindice;
        }
        set
        {
            PropriedadeModificada(RO_TIPOAPLICINDICE, value);
            _tipoaplicindice = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Tipoaplicrepasse
    {
        get
        {
            PropriedadeAcessada(RO_TIPOAPLICREPASSE);
            return _tipoaplicrepasse;
        }
        set
        {
            PropriedadeModificada(RO_TIPOAPLICREPASSE, value);
            _tipoaplicrepasse = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 2, Precisao = 0)]
    public decimal? Tipobaixacobmag
    {
        get
        {
            PropriedadeAcessada(RO_TIPOBAIXACOBMAG);
            return _tipobaixacobmag;
        }
        set
        {
            PropriedadeModificada(RO_TIPOBAIXACOBMAG, value);
            _tipobaixacobmag = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Tipocalcdescargapal
    {
        get
        {
            PropriedadeAcessada(RO_TIPOCALCDESCARGAPAL);
            return _tipocalcdescargapal;
        }
        set
        {
            PropriedadeModificada(RO_TIPOCALCDESCARGAPAL, value);
            _tipocalcdescargapal = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Tipocalcgirodia
    {
        get
        {
            PropriedadeAcessada(RO_TIPOCALCGIRODIA);
            return _tipocalcgirodia;
        }
        set
        {
            PropriedadeModificada(RO_TIPOCALCGIRODIA, value);
            _tipocalcgirodia = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Tipocalcipi
    {
        get
        {
            PropriedadeAcessada(RO_TIPOCALCIPI);
            return _tipocalcipi;
        }
        set
        {
            PropriedadeModificada(RO_TIPOCALCIPI, value);
            _tipocalcipi = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Tipocalcst
    {
        get
        {
            PropriedadeAcessada(RO_TIPOCALCST);
            return _tipocalcst;
        }
        set
        {
            PropriedadeModificada(RO_TIPOCALCST, value);
            _tipocalcst = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Tipocalcsulframa
    {
        get
        {
            PropriedadeAcessada(RO_TIPOCALCSULFRAMA);
            return _tipocalcsulframa;
        }
        set
        {
            PropriedadeModificada(RO_TIPOCALCSULFRAMA, value);
            _tipocalcsulframa = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Tipocustoajuste
    {
        get
        {
            PropriedadeAcessada(RO_TIPOCUSTOAJUSTE);
            return _tipocustoajuste;
        }
        set
        {
            PropriedadeModificada(RO_TIPOCUSTOAJUSTE, value);
            _tipocustoajuste = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Tipocusto1322
    {
        get
        {
            PropriedadeAcessada(RO_TIPOCUSTO1322);
            return _tipocusto1322;
        }
        set
        {
            PropriedadeModificada(RO_TIPOCUSTO1322, value);
            _tipocusto1322 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Tipoenderecamento
    {
        get
        {
            PropriedadeAcessada(RO_TIPOENDERECAMENTO);
            return _tipoenderecamento;
        }
        set
        {
            PropriedadeModificada(RO_TIPOENDERECAMENTO, value);
            _tipoenderecamento = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Tipoentregapadraocallcenter
    {
        get
        {
            PropriedadeAcessada(RO_TIPOENTREGAPADRAOCALLCENTER);
            return _tipoentregapadraocallcenter;
        }
        set
        {
            PropriedadeModificada(RO_TIPOENTREGAPADRAOCALLCENTER, value);
            _tipoentregapadraocallcenter = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Tipogeracaodadospcauxpro
    {
        get
        {
            PropriedadeAcessada(RO_TIPOGERACAODADOSPCAUXPRO);
            return _tipogeracaodadospcauxpro;
        }
        set
        {
            PropriedadeModificada(RO_TIPOGERACAODADOSPCAUXPRO, value);
            _tipogeracaodadospcauxpro = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Tipointegracao
    {
        get
        {
            PropriedadeAcessada(RO_TIPOINTEGRACAO);
            return _tipointegracao;
        }
        set
        {
            PropriedadeModificada(RO_TIPOINTEGRACAO, value);
            _tipointegracao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Tipomapawmsvendabalcao
    {
        get
        {
            PropriedadeAcessada(RO_TIPOMAPAWMSVENDABALCAO);
            return _tipomapawmsvendabalcao;
        }
        set
        {
            PropriedadeModificada(RO_TIPOMAPAWMSVENDABALCAO, value);
            _tipomapawmsvendabalcao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 2, Precisao = 0)]
    public decimal? Tipomascaraenderwms
    {
        get
        {
            PropriedadeAcessada(RO_TIPOMASCARAENDERWMS);
            return _tipomascaraenderwms;
        }
        set
        {
            PropriedadeModificada(RO_TIPOMASCARAENDERWMS, value);
            _tipomascaraenderwms = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Tipoordenacaonfsaida
    {
        get
        {
            PropriedadeAcessada(RO_TIPOORDENACAONFSAIDA);
            return _tipoordenacaonfsaida;
        }
        set
        {
            PropriedadeModificada(RO_TIPOORDENACAONFSAIDA, value);
            _tipoordenacaonfsaida = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Tipoperiodogirodia
    {
        get
        {
            PropriedadeAcessada(RO_TIPOPERIODOGIRODIA);
            return _tipoperiodogirodia;
        }
        set
        {
            PropriedadeModificada(RO_TIPOPERIODOGIRODIA, value);
            _tipoperiodogirodia = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Tiporelmapa
    {
        get
        {
            PropriedadeAcessada(RO_TIPORELMAPA);
            return _tiporelmapa;
        }
        set
        {
            PropriedadeModificada(RO_TIPORELMAPA, value);
            _tiporelmapa = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Tipotaxavendor
    {
        get
        {
            PropriedadeAcessada(RO_TIPOTAXAVENDOR);
            return _tipotaxavendor;
        }
        set
        {
            PropriedadeModificada(RO_TIPOTAXAVENDOR, value);
            _tipotaxavendor = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Tipotitulosecf402
    {
        get
        {
            PropriedadeAcessada(RO_TIPOTITULOSECF402);
            return _tipotitulosecf402;
        }
        set
        {
            PropriedadeModificada(RO_TIPOTITULOSECF402, value);
            _tipotitulosecf402 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Tipotitulosecf409
    {
        get
        {
            PropriedadeAcessada(RO_TIPOTITULOSECF409);
            return _tipotitulosecf409;
        }
        set
        {
            PropriedadeModificada(RO_TIPOTITULOSECF409, value);
            _tipotitulosecf409 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Tipotxboleto
    {
        get
        {
            PropriedadeAcessada(RO_TIPOTXBOLETO);
            return _tipotxboleto;
        }
        set
        {
            PropriedadeModificada(RO_TIPOTXBOLETO, value);
            _tipotxboleto = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Tipovalorgirodia
    {
        get
        {
            PropriedadeAcessada(RO_TIPOVALORGIRODIA);
            return _tipovalorgirodia;
        }
        set
        {
            PropriedadeModificada(RO_TIPOVALORGIRODIA, value);
            _tipovalorgirodia = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Tipovlminvendabk
    {
        get
        {
            PropriedadeAcessada(RO_TIPOVLMINVENDABK);
            return _tipovlminvendabk;
        }
        set
        {
            PropriedadeModificada(RO_TIPOVLMINVENDABK, value);
            _tipovlminvendabk = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Tratarrestricaoacrescimo
    {
        get
        {
            PropriedadeAcessada(RO_TRATARRESTRICAOACRESCIMO);
            return _tratarrestricaoacrescimo;
        }
        set
        {
            PropriedadeModificada(RO_TRATARRESTRICAOACRESCIMO, value);
            _tratarrestricaoacrescimo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Travavendapf
    {
        get
        {
            PropriedadeAcessada(RO_TRAVAVENDAPF);
            return _travavendapf;
        }
        set
        {
            PropriedadeModificada(RO_TRAVAVENDAPF, value);
            _travavendapf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Tributafreterateado
    {
        get
        {
            PropriedadeAcessada(RO_TRIBUTAFRETERATEADO);
            return _tributafreterateado;
        }
        set
        {
            PropriedadeModificada(RO_TRIBUTAFRETERATEADO, value);
            _tributafreterateado = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 6)]
    public decimal? Tx
    {
        get
        {
            PropriedadeAcessada(RO_TX);
            return _tx;
        }
        set
        {
            PropriedadeModificada(RO_TX, value);
            _tx = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Txiof
    {
        get
        {
            PropriedadeAcessada(RO_TXIOF);
            return _txiof;
        }
        set
        {
            PropriedadeModificada(RO_TXIOF, value);
            _txiof = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 6)]
    public decimal? Txvendorcli
    {
        get
        {
            PropriedadeAcessada(RO_TXVENDORCLI);
            return _txvendorcli;
        }
        set
        {
            PropriedadeModificada(RO_TXVENDORCLI, value);
            _txvendorcli = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Ultnumdatacheq
    {
        get
        {
            PropriedadeAcessada(RO_ULTNUMDATACHEQ);
            return _ultnumdatacheq;
        }
        set
        {
            PropriedadeModificada(RO_ULTNUMDATACHEQ, value);
            _ultnumdatacheq = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 31, Precisao = 0)]
    public string Updateautmenu
    {
        get
        {
            PropriedadeAcessada(RO_UPDATEAUTMENU);
            return _updateautmenu;
        }
        set
        {
            PropriedadeModificada(RO_UPDATEAUTMENU, value);
            _updateautmenu = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Usabcrent
    {
        get
        {
            PropriedadeAcessada(RO_USABCRENT);
            return _usabcrent;
        }
        set
        {
            PropriedadeModificada(RO_USABCRENT, value);
            _usabcrent = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Usacancelamentoautomaticoecf
    {
        get
        {
            PropriedadeAcessada(RO_USACANCELAMENTOAUTOMATICOECF);
            return _usacancelamentoautomaticoecf;
        }
        set
        {
            PropriedadeModificada(RO_USACANCELAMENTOAUTOMATICOECF, value);
            _usacancelamentoautomaticoecf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Usacategoria
    {
        get
        {
            PropriedadeAcessada(RO_USACATEGORIA);
            return _usacategoria;
        }
        set
        {
            PropriedadeModificada(RO_USACATEGORIA, value);
            _usacategoria = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Usacestabasicacf
    {
        get
        {
            PropriedadeAcessada(RO_USACESTABASICACF);
            return _usacestabasicacf;
        }
        set
        {
            PropriedadeModificada(RO_USACESTABASICACF, value);
            _usacestabasicacf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Usachavetriplapcpedi
    {
        get
        {
            PropriedadeAcessada(RO_USACHAVETRIPLAPCPEDI);
            return _usachavetriplapcpedi;
        }
        set
        {
            PropriedadeModificada(RO_USACHAVETRIPLAPCPEDI, value);
            _usachavetriplapcpedi = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Usacomissaoecf
    {
        get
        {
            PropriedadeAcessada(RO_USACOMISSAOECF);
            return _usacomissaoecf;
        }
        set
        {
            PropriedadeModificada(RO_USACOMISSAOECF, value);
            _usacomissaoecf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Usacomissaoporclasse
    {
        get
        {
            PropriedadeAcessada(RO_USACOMISSAOPORCLASSE);
            return _usacomissaoporclasse;
        }
        set
        {
            PropriedadeModificada(RO_USACOMISSAOPORCLASSE, value);
            _usacomissaoporclasse = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Usacomissaoporcliente
    {
        get
        {
            PropriedadeAcessada(RO_USACOMISSAOPORCLIENTE);
            return _usacomissaoporcliente;
        }
        set
        {
            PropriedadeModificada(RO_USACOMISSAOPORCLIENTE, value);
            _usacomissaoporcliente = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Usacomissaoporlinhaprod
    {
        get
        {
            PropriedadeAcessada(RO_USACOMISSAOPORLINHAPROD);
            return _usacomissaoporlinhaprod;
        }
        set
        {
            PropriedadeModificada(RO_USACOMISSAOPORLINHAPROD, value);
            _usacomissaoporlinhaprod = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Usacomissaoporrca
    {
        get
        {
            PropriedadeAcessada(RO_USACOMISSAOPORRCA);
            return _usacomissaoporrca;
        }
        set
        {
            PropriedadeModificada(RO_USACOMISSAOPORRCA, value);
            _usacomissaoporrca = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Usacontrolederecibos
    {
        get
        {
            PropriedadeAcessada(RO_USACONTROLEDERECIBOS);
            return _usacontrolederecibos;
        }
        set
        {
            PropriedadeModificada(RO_USACONTROLEDERECIBOS, value);
            _usacontrolederecibos = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Usacontroleemissaonf
    {
        get
        {
            PropriedadeAcessada(RO_USACONTROLEEMISSAONF);
            return _usacontroleemissaonf;
        }
        set
        {
            PropriedadeModificada(RO_USACONTROLEEMISSAONF, value);
            _usacontroleemissaonf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Usacontrolefornecpedcompra
    {
        get
        {
            PropriedadeAcessada(RO_USACONTROLEFORNECPEDCOMPRA);
            return _usacontrolefornecpedcompra;
        }
        set
        {
            PropriedadeModificada(RO_USACONTROLEFORNECPEDCOMPRA, value);
            _usacontrolefornecpedcompra = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Usacontroletipoverba
    {
        get
        {
            PropriedadeAcessada(RO_USACONTROLETIPOVERBA);
            return _usacontroletipoverba;
        }
        set
        {
            PropriedadeModificada(RO_USACONTROLETIPOVERBA, value);
            _usacontroletipoverba = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Usaconversaoembalagem
    {
        get
        {
            PropriedadeAcessada(RO_USACONVERSAOEMBALAGEM);
            return _usaconversaoembalagem;
        }
        set
        {
            PropriedadeModificada(RO_USACONVERSAOEMBALAGEM, value);
            _usaconversaoembalagem = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Usacreclivendabalcao
    {
        get
        {
            PropriedadeAcessada(RO_USACRECLIVENDABALCAO);
            return _usacreclivendabalcao;
        }
        set
        {
            PropriedadeModificada(RO_USACRECLIVENDABALCAO, value);
            _usacreclivendabalcao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Usacreclivendatlmkt
    {
        get
        {
            PropriedadeAcessada(RO_USACRECLIVENDATLMKT);
            return _usacreclivendatlmkt;
        }
        set
        {
            PropriedadeModificada(RO_USACRECLIVENDATLMKT, value);
            _usacreclivendatlmkt = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Usacredclitodasfiliais
    {
        get
        {
            PropriedadeAcessada(RO_USACREDCLITODASFILIAIS);
            return _usacredclitodasfiliais;
        }
        set
        {
            PropriedadeModificada(RO_USACREDCLITODASFILIAIS, value);
            _usacredclitodasfiliais = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Usadescporlinhaprod
    {
        get
        {
            PropriedadeAcessada(RO_USADESCPORLINHAPROD);
            return _usadescporlinhaprod;
        }
        set
        {
            PropriedadeModificada(RO_USADESCPORLINHAPROD, value);
            _usadescporlinhaprod = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Usadescporquant
    {
        get
        {
            PropriedadeAcessada(RO_USADESCPORQUANT);
            return _usadescporquant;
        }
        set
        {
            PropriedadeModificada(RO_USADESCPORQUANT, value);
            _usadescporquant = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Usadtdesbloqueiobloqcliinativ
    {
        get
        {
            PropriedadeAcessada(RO_USADTDESBLOQUEIOBLOQCLIINATIV);
            return _usadtdesbloqueiobloqcliinativ;
        }
        set
        {
            PropriedadeModificada(RO_USADTDESBLOQUEIOBLOQCLIINATIV, value);
            _usadtdesbloqueiobloqcliinativ = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Usadvproduto
    {
        get
        {
            PropriedadeAcessada(RO_USADVPRODUTO);
            return _usadvproduto;
        }
        set
        {
            PropriedadeModificada(RO_USADVPRODUTO, value);
            _usadvproduto = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Usafechamentocxcego
    {
        get
        {
            PropriedadeAcessada(RO_USAFECHAMENTOCXCEGO);
            return _usafechamentocxcego;
        }
        set
        {
            PropriedadeModificada(RO_USAFECHAMENTOCXCEGO, value);
            _usafechamentocxcego = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Usaicmsantecippvenda
    {
        get
        {
            PropriedadeAcessada(RO_USAICMSANTECIPPVENDA);
            return _usaicmsantecippvenda;
        }
        set
        {
            PropriedadeModificada(RO_USAICMSANTECIPPVENDA, value);
            _usaicmsantecippvenda = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Usalimcredcpf
    {
        get
        {
            PropriedadeAcessada(RO_USALIMCREDCPF);
            return _usalimcredcpf;
        }
        set
        {
            PropriedadeModificada(RO_USALIMCREDCPF, value);
            _usalimcredcpf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Usamapseprua
    {
        get
        {
            PropriedadeAcessada(RO_USAMAPSEPRUA);
            return _usamapseprua;
        }
        set
        {
            PropriedadeModificada(RO_USAMAPSEPRUA, value);
            _usamapseprua = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Usamarcaprodutos
    {
        get
        {
            PropriedadeAcessada(RO_USAMARCAPRODUTOS);
            return _usamarcaprodutos;
        }
        set
        {
            PropriedadeModificada(RO_USAMARCAPRODUTOS, value);
            _usamarcaprodutos = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Usanegfornec
    {
        get
        {
            PropriedadeAcessada(RO_USANEGFORNEC);
            return _usanegfornec;
        }
        set
        {
            PropriedadeModificada(RO_USANEGFORNEC, value);
            _usanegfornec = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Usanfcomplementarbk
    {
        get
        {
            PropriedadeAcessada(RO_USANFCOMPLEMENTARBK);
            return _usanfcomplementarbk;
        }
        set
        {
            PropriedadeModificada(RO_USANFCOMPLEMENTARBK, value);
            _usanfcomplementarbk = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Usanumcarvendabalcao
    {
        get
        {
            PropriedadeAcessada(RO_USANUMCARVENDABALCAO);
            return _usanumcarvendabalcao;
        }
        set
        {
            PropriedadeModificada(RO_USANUMCARVENDABALCAO, value);
            _usanumcarvendabalcao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Usaoutrasmoedas
    {
        get
        {
            PropriedadeAcessada(RO_USAOUTRASMOEDAS);
            return _usaoutrasmoedas;
        }
        set
        {
            PropriedadeModificada(RO_USAOUTRASMOEDAS, value);
            _usaoutrasmoedas = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Usapercdifqtent
    {
        get
        {
            PropriedadeAcessada(RO_USAPERCDIFQTENT);
            return _usapercdifqtent;
        }
        set
        {
            PropriedadeModificada(RO_USAPERCDIFQTENT, value);
            _usapercdifqtent = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Usapiscofinsporfilial
    {
        get
        {
            PropriedadeAcessada(RO_USAPISCOFINSPORFILIAL);
            return _usapiscofinsporfilial;
        }
        set
        {
            PropriedadeModificada(RO_USAPISCOFINSPORFILIAL, value);
            _usapiscofinsporfilial = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Usapoliticadesenha
    {
        get
        {
            PropriedadeAcessada(RO_USAPOLITICADESENHA);
            return _usapoliticadesenha;
        }
        set
        {
            PropriedadeModificada(RO_USAPOLITICADESENHA, value);
            _usapoliticadesenha = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Usaposicaocpagar
    {
        get
        {
            PropriedadeAcessada(RO_USAPOSICAOCPAGAR);
            return _usaposicaocpagar;
        }
        set
        {
            PropriedadeModificada(RO_USAPOSICAOCPAGAR, value);
            _usaposicaocpagar = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Usaprecifmenormargemm
    {
        get
        {
            PropriedadeAcessada(RO_USAPRECIFMENORMARGEMM);
            return _usaprecifmenormargemm;
        }
        set
        {
            PropriedadeModificada(RO_USAPRECIFMENORMARGEMM, value);
            _usaprecifmenormargemm = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Usaprodfracunitario
    {
        get
        {
            PropriedadeAcessada(RO_USAPRODFRACUNITARIO);
            return _usaprodfracunitario;
        }
        set
        {
            PropriedadeModificada(RO_USAPRODFRACUNITARIO, value);
            _usaprodfracunitario = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Usaprzadicionalvenda
    {
        get
        {
            PropriedadeAcessada(RO_USAPRZADICIONALVENDA);
            return _usaprzadicionalvenda;
        }
        set
        {
            PropriedadeModificada(RO_USAPRZADICIONALVENDA, value);
            _usaprzadicionalvenda = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Usaptabelacomobase
    {
        get
        {
            PropriedadeAcessada(RO_USAPTABELACOMOBASE);
            return _usaptabelacomobase;
        }
        set
        {
            PropriedadeModificada(RO_USAPTABELACOMOBASE, value);
            _usaptabelacomobase = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Usardescontovendacodbarra
    {
        get
        {
            PropriedadeAcessada(RO_USARDESCONTOVENDACODBARRA);
            return _usardescontovendacodbarra;
        }
        set
        {
            PropriedadeModificada(RO_USARDESCONTOVENDACODBARRA, value);
            _usardescontovendacodbarra = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Usareducaocomissaorca
    {
        get
        {
            PropriedadeAcessada(RO_USAREDUCAOCOMISSAORCA);
            return _usareducaocomissaorca;
        }
        set
        {
            PropriedadeModificada(RO_USAREDUCAOCOMISSAORCA, value);
            _usareducaocomissaorca = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Usarenderfornec
    {
        get
        {
            PropriedadeAcessada(RO_USARENDERFORNEC);
            return _usarenderfornec;
        }
        set
        {
            PropriedadeModificada(RO_USARENDERFORNEC, value);
            _usarenderfornec = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Usarmovimentahorizontal
    {
        get
        {
            PropriedadeAcessada(RO_USARMOVIMENTAHORIZONTAL);
            return _usarmovimentahorizontal;
        }
        set
        {
            PropriedadeModificada(RO_USARMOVIMENTAHORIZONTAL, value);
            _usarmovimentahorizontal = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Usarreducaoicmsabatransf
    {
        get
        {
            PropriedadeAcessada(RO_USARREDUCAOICMSABATRANSF);
            return _usarreducaoicmsabatransf;
        }
        set
        {
            PropriedadeModificada(RO_USARREDUCAOICMSABATRANSF, value);
            _usarreducaoicmsabatransf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Usarsenhaexpirada
    {
        get
        {
            PropriedadeAcessada(RO_USARSENHAEXPIRADA);
            return _usarsenhaexpirada;
        }
        set
        {
            PropriedadeModificada(RO_USARSENHAEXPIRADA, value);
            _usarsenhaexpirada = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Usartributacaotransftv10
    {
        get
        {
            PropriedadeAcessada(RO_USARTRIBUTACAOTRANSFTV10);
            return _usartributacaotransftv10;
        }
        set
        {
            PropriedadeModificada(RO_USARTRIBUTACAOTRANSFTV10, value);
            _usartributacaotransftv10 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Usaseparacaocxfechada
    {
        get
        {
            PropriedadeAcessada(RO_USASEPARACAOCXFECHADA);
            return _usaseparacaocxfechada;
        }
        set
        {
            PropriedadeModificada(RO_USASEPARACAOCXFECHADA, value);
            _usaseparacaocxfechada = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Usatecladogertec
    {
        get
        {
            PropriedadeAcessada(RO_USATECLADOGERTEC);
            return _usatecladogertec;
        }
        set
        {
            PropriedadeModificada(RO_USATECLADOGERTEC, value);
            _usatecladogertec = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Usatribentporuf
    {
        get
        {
            PropriedadeAcessada(RO_USATRIBENTPORUF);
            return _usatribentporuf;
        }
        set
        {
            PropriedadeModificada(RO_USATRIBENTPORUF, value);
            _usatribentporuf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Usatributacaoporuf
    {
        get
        {
            PropriedadeAcessada(RO_USATRIBUTACAOPORUF);
            return _usatributacaoporuf;
        }
        set
        {
            PropriedadeModificada(RO_USATRIBUTACAOPORUF, value);
            _usatributacaoporuf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Usatrocacomprecovenda
    {
        get
        {
            PropriedadeAcessada(RO_USATROCACOMPRECOVENDA);
            return _usatrocacomprecovenda;
        }
        set
        {
            PropriedadeModificada(RO_USATROCACOMPRECOVENDA, value);
            _usatrocacomprecovenda = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Usavalormedioentrada
    {
        get
        {
            PropriedadeAcessada(RO_USAVALORMEDIOENTRADA);
            return _usavalormedioentrada;
        }
        set
        {
            PropriedadeModificada(RO_USAVALORMEDIOENTRADA, value);
            _usavalormedioentrada = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Usavendabalcaoclifilialvirtual
    {
        get
        {
            PropriedadeAcessada(RO_USAVENDABALCAOCLIFILIALVIRTUAL);
            return _usavendabalcaoclifilialvirtual;
        }
        set
        {
            PropriedadeModificada(RO_USAVENDABALCAOCLIFILIALVIRTUAL, value);
            _usavendabalcaoclifilialvirtual = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Usavendedornatroca
    {
        get
        {
            PropriedadeAcessada(RO_USAVENDEDORNATROCA);
            return _usavendedornatroca;
        }
        set
        {
            PropriedadeModificada(RO_USAVENDEDORNATROCA, value);
            _usavendedornatroca = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 10, Precisao = 0)]
    public string Usuariologon
    {
        get
        {
            PropriedadeAcessada(RO_USUARIOLOGON);
            return _usuariologon;
        }
        set
        {
            PropriedadeModificada(RO_USUARIOLOGON, value);
            _usuariologon = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Utilizaautorcpagar
    {
        get
        {
            PropriedadeAcessada(RO_UTILIZAAUTORCPAGAR);
            return _utilizaautorcpagar;
        }
        set
        {
            PropriedadeModificada(RO_UTILIZAAUTORCPAGAR, value);
            _utilizaautorcpagar = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Utilizaboletopreimpr
    {
        get
        {
            PropriedadeAcessada(RO_UTILIZABOLETOPREIMPR);
            return _utilizaboletopreimpr;
        }
        set
        {
            PropriedadeModificada(RO_UTILIZABOLETOPREIMPR, value);
            _utilizaboletopreimpr = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Utilizacheckout936
    {
        get
        {
            PropriedadeAcessada(RO_UTILIZACHECKOUT936);
            return _utilizacheckout936;
        }
        set
        {
            PropriedadeModificada(RO_UTILIZACHECKOUT936, value);
            _utilizacheckout936 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Utilizacontrolecaixa
    {
        get
        {
            PropriedadeAcessada(RO_UTILIZACONTROLECAIXA);
            return _utilizacontrolecaixa;
        }
        set
        {
            PropriedadeModificada(RO_UTILIZACONTROLECAIXA, value);
            _utilizacontrolecaixa = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Utilizacontrolelote
    {
        get
        {
            PropriedadeAcessada(RO_UTILIZACONTROLELOTE);
            return _utilizacontrolelote;
        }
        set
        {
            PropriedadeModificada(RO_UTILIZACONTROLELOTE, value);
            _utilizacontrolelote = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Utilizacontrolemedicamentos
    {
        get
        {
            PropriedadeAcessada(RO_UTILIZACONTROLEMEDICAMENTOS);
            return _utilizacontrolemedicamentos;
        }
        set
        {
            PropriedadeModificada(RO_UTILIZACONTROLEMEDICAMENTOS, value);
            _utilizacontrolemedicamentos = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Utilizaembmaster
    {
        get
        {
            PropriedadeAcessada(RO_UTILIZAEMBMASTER);
            return _utilizaembmaster;
        }
        set
        {
            PropriedadeModificada(RO_UTILIZAEMBMASTER, value);
            _utilizaembmaster = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Utilizaendporfilial
    {
        get
        {
            PropriedadeAcessada(RO_UTILIZAENDPORFILIAL);
            return _utilizaendporfilial;
        }
        set
        {
            PropriedadeModificada(RO_UTILIZAENDPORFILIAL, value);
            _utilizaendporfilial = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Utilizafilialregiaocx
    {
        get
        {
            PropriedadeAcessada(RO_UTILIZAFILIALREGIAOCX);
            return _utilizafilialregiaocx;
        }
        set
        {
            PropriedadeModificada(RO_UTILIZAFILIALREGIAOCX, value);
            _utilizafilialregiaocx = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Utilizaguiaproprianfent
    {
        get
        {
            PropriedadeAcessada(RO_UTILIZAGUIAPROPRIANFENT);
            return _utilizaguiaproprianfent;
        }
        set
        {
            PropriedadeModificada(RO_UTILIZAGUIAPROPRIANFENT, value);
            _utilizaguiaproprianfent = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Utilizaliberacaopedcompra
    {
        get
        {
            PropriedadeAcessada(RO_UTILIZALIBERACAOPEDCOMPRA);
            return _utilizaliberacaopedcompra;
        }
        set
        {
            PropriedadeModificada(RO_UTILIZALIBERACAOPEDCOMPRA, value);
            _utilizaliberacaopedcompra = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Utilizaorcvenda
    {
        get
        {
            PropriedadeAcessada(RO_UTILIZAORCVENDA);
            return _utilizaorcvenda;
        }
        set
        {
            PropriedadeModificada(RO_UTILIZAORCVENDA, value);
            _utilizaorcvenda = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Utilizapcusurfornec
    {
        get
        {
            PropriedadeAcessada(RO_UTILIZAPCUSURFORNEC);
            return _utilizapcusurfornec;
        }
        set
        {
            PropriedadeModificada(RO_UTILIZAPCUSURFORNEC, value);
            _utilizapcusurfornec = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Utilizapercfinprecoprom
    {
        get
        {
            PropriedadeAcessada(RO_UTILIZAPERCFINPRECOPROM);
            return _utilizapercfinprecoprom;
        }
        set
        {
            PropriedadeModificada(RO_UTILIZAPERCFINPRECOPROM, value);
            _utilizapercfinprecoprom = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Utilizaqtfracionadaconf
    {
        get
        {
            PropriedadeAcessada(RO_UTILIZAQTFRACIONADACONF);
            return _utilizaqtfracionadaconf;
        }
        set
        {
            PropriedadeModificada(RO_UTILIZAQTFRACIONADACONF, value);
            _utilizaqtfracionadaconf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Utilizarateiodespesas
    {
        get
        {
            PropriedadeAcessada(RO_UTILIZARATEIODESPESAS);
            return _utilizarateiodespesas;
        }
        set
        {
            PropriedadeModificada(RO_UTILIZARATEIODESPESAS, value);
            _utilizarateiodespesas = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Utilizarembunitsintegra
    {
        get
        {
            PropriedadeAcessada(RO_UTILIZAREMBUNITSINTEGRA);
            return _utilizarembunitsintegra;
        }
        set
        {
            PropriedadeModificada(RO_UTILIZAREMBUNITSINTEGRA, value);
            _utilizarembunitsintegra = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Validadvcodbarra
    {
        get
        {
            PropriedadeAcessada(RO_VALIDADVCODBARRA);
            return _validadvcodbarra;
        }
        set
        {
            PropriedadeModificada(RO_VALIDADVCODBARRA, value);
            _validadvcodbarra = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Validaestoquemapasep
    {
        get
        {
            PropriedadeAcessada(RO_VALIDAESTOQUEMAPASEP);
            return _validaestoquemapasep;
        }
        set
        {
            PropriedadeModificada(RO_VALIDAESTOQUEMAPASEP, value);
            _validaestoquemapasep = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Validanumserieequipecf
    {
        get
        {
            PropriedadeAcessada(RO_VALIDANUMSERIEEQUIPECF);
            return _validanumserieequipecf;
        }
        set
        {
            PropriedadeModificada(RO_VALIDANUMSERIEEQUIPECF, value);
            _validanumserieequipecf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Validaprecominimo
    {
        get
        {
            PropriedadeAcessada(RO_VALIDAPRECOMINIMO);
            return _validaprecominimo;
        }
        set
        {
            PropriedadeModificada(RO_VALIDAPRECOMINIMO, value);
            _validaprecominimo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Validapvendabonific
    {
        get
        {
            PropriedadeAcessada(RO_VALIDAPVENDABONIFIC);
            return _validapvendabonific;
        }
        set
        {
            PropriedadeModificada(RO_VALIDAPVENDABONIFIC, value);
            _validapvendabonific = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Validarestoqueautoservico
    {
        get
        {
            PropriedadeAcessada(RO_VALIDARESTOQUEAUTOSERVICO);
            return _validarestoqueautoservico;
        }
        set
        {
            PropriedadeModificada(RO_VALIDARESTOQUEAUTOSERVICO, value);
            _validarestoqueautoservico = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Validarestricoesvendaporrca
    {
        get
        {
            PropriedadeAcessada(RO_VALIDARESTRICOESVENDAPORRCA);
            return _validarestricoesvendaporrca;
        }
        set
        {
            PropriedadeModificada(RO_VALIDARESTRICOESVENDAPORRCA, value);
            _validarestricoesvendaporrca = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Validarieconsumidorfinal
    {
        get
        {
            PropriedadeAcessada(RO_VALIDARIECONSUMIDORFINAL);
            return _validarieconsumidorfinal;
        }
        set
        {
            PropriedadeModificada(RO_VALIDARIECONSUMIDORFINAL, value);
            _validarieconsumidorfinal = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Validaruffilial
    {
        get
        {
            PropriedadeAcessada(RO_VALIDARUFFILIAL);
            return _validaruffilial;
        }
        set
        {
            PropriedadeModificada(RO_VALIDARUFFILIAL, value);
            _validaruffilial = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Validarvlminvendaaposcorte
    {
        get
        {
            PropriedadeAcessada(RO_VALIDARVLMINVENDAAPOSCORTE);
            return _validarvlminvendaaposcorte;
        }
        set
        {
            PropriedadeModificada(RO_VALIDARVLMINVENDAAPOSCORTE, value);
            _validarvlminvendaaposcorte = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Validavlminvendabalcao
    {
        get
        {
            PropriedadeAcessada(RO_VALIDAVLMINVENDABALCAO);
            return _validavlminvendabalcao;
        }
        set
        {
            PropriedadeModificada(RO_VALIDAVLMINVENDABALCAO, value);
            _validavlminvendabalcao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 2)]
    public decimal? Valor_Frete_Padrao
    {
        get
        {
            PropriedadeAcessada(RO_VALOR_FRETE_PADRAO);
            return _valor_frete_padrao;
        }
        set
        {
            PropriedadeModificada(RO_VALOR_FRETE_PADRAO, value);
            _valor_frete_padrao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 2)]
    public decimal? Valormaxfaltacaixa
    {
        get
        {
            PropriedadeAcessada(RO_VALORMAXFALTACAIXA);
            return _valormaxfaltacaixa;
        }
        set
        {
            PropriedadeModificada(RO_VALORMAXFALTACAIXA, value);
            _valormaxfaltacaixa = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 16, Precisao = 4)]
    public decimal? Valorminimocsrf
    {
        get
        {
            PropriedadeAcessada(RO_VALORMINIMOCSRF);
            return _valorminimocsrf;
        }
        set
        {
            PropriedadeModificada(RO_VALORMINIMOCSRF, value);
            _valorminimocsrf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 16, Precisao = 4)]
    public decimal? Valorminimoinss
    {
        get
        {
            PropriedadeAcessada(RO_VALORMINIMOINSS);
            return _valorminimoinss;
        }
        set
        {
            PropriedadeModificada(RO_VALORMINIMOINSS, value);
            _valorminimoinss = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 16, Precisao = 4)]
    public decimal? Valorminimoirrf
    {
        get
        {
            PropriedadeAcessada(RO_VALORMINIMOIRRF);
            return _valorminimoirrf;
        }
        set
        {
            PropriedadeModificada(RO_VALORMINIMOIRRF, value);
            _valorminimoirrf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 2)]
    public decimal? Valorsangria1
    {
        get
        {
            PropriedadeAcessada(RO_VALORSANGRIA1);
            return _valorsangria1;
        }
        set
        {
            PropriedadeModificada(RO_VALORSANGRIA1, value);
            _valorsangria1 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 2)]
    public decimal? Valorsangria2
    {
        get
        {
            PropriedadeAcessada(RO_VALORSANGRIA2);
            return _valorsangria2;
        }
        set
        {
            PropriedadeModificada(RO_VALORSANGRIA2, value);
            _valorsangria2 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Vercobrancabloqcli504_16_17
    {
        get
        {
            PropriedadeAcessada(RO_VERCOBRANCABLOQCLI504_16_17);
            return _vercobrancabloqcli504_16_17;
        }
        set
        {
            PropriedadeModificada(RO_VERCOBRANCABLOQCLI504_16_17, value);
            _vercobrancabloqcli504_16_17 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Verificadatahoraecf
    {
        get
        {
            PropriedadeAcessada(RO_VERIFICADATAHORAECF);
            return _verificadatahoraecf;
        }
        set
        {
            PropriedadeModificada(RO_VERIFICADATAHORAECF, value);
            _verificadatahoraecf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Verificadescfinbaixacm
    {
        get
        {
            PropriedadeAcessada(RO_VERIFICADESCFINBAIXACM);
            return _verificadescfinbaixacm;
        }
        set
        {
            PropriedadeModificada(RO_VERIFICADESCFINBAIXACM, value);
            _verificadescfinbaixacm = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Verificaestoquecont
    {
        get
        {
            PropriedadeAcessada(RO_VERIFICAESTOQUECONT);
            return _verificaestoquecont;
        }
        set
        {
            PropriedadeModificada(RO_VERIFICAESTOQUECONT, value);
            _verificaestoquecont = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Verificalimcredcodcobd
    {
        get
        {
            PropriedadeAcessada(RO_VERIFICALIMCREDCODCOBD);
            return _verificalimcredcodcobd;
        }
        set
        {
            PropriedadeModificada(RO_VERIFICALIMCREDCODCOBD, value);
            _verificalimcredcodcobd = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Verificamargemlibpedido
    {
        get
        {
            PropriedadeAcessada(RO_VERIFICAMARGEMLIBPEDIDO);
            return _verificamargemlibpedido;
        }
        set
        {
            PropriedadeModificada(RO_VERIFICAMARGEMLIBPEDIDO, value);
            _verificamargemlibpedido = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Verificanivelvenda402
    {
        get
        {
            PropriedadeAcessada(RO_VERIFICANIVELVENDA402);
            return _verificanivelvenda402;
        }
        set
        {
            PropriedadeModificada(RO_VERIFICANIVELVENDA402, value);
            _verificanivelvenda402 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Verificapedbonificentnormal
    {
        get
        {
            PropriedadeAcessada(RO_VERIFICAPEDBONIFICENTNORMAL);
            return _verificapedbonificentnormal;
        }
        set
        {
            PropriedadeModificada(RO_VERIFICAPEDBONIFICENTNORMAL, value);
            _verificapedbonificentnormal = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Verificapesomaxpalete
    {
        get
        {
            PropriedadeAcessada(RO_VERIFICAPESOMAXPALETE);
            return _verificapesomaxpalete;
        }
        set
        {
            PropriedadeModificada(RO_VERIFICAPESOMAXPALETE, value);
            _verificapesomaxpalete = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Verificapickingarm
    {
        get
        {
            PropriedadeAcessada(RO_VERIFICAPICKINGARM);
            return _verificapickingarm;
        }
        set
        {
            PropriedadeModificada(RO_VERIFICAPICKINGARM, value);
            _verificapickingarm = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Verificarclientesrede
    {
        get
        {
            PropriedadeAcessada(RO_VERIFICARCLIENTESREDE);
            return _verificarclientesrede;
        }
        set
        {
            PropriedadeModificada(RO_VERIFICARCLIENTESREDE, value);
            _verificarclientesrede = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Verificarenderocupado
    {
        get
        {
            PropriedadeAcessada(RO_VERIFICARENDEROCUPADO);
            return _verificarenderocupado;
        }
        set
        {
            PropriedadeModificada(RO_VERIFICARENDEROCUPADO, value);
            _verificarenderocupado = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Verificarlimvendapf
    {
        get
        {
            PropriedadeAcessada(RO_VERIFICARLIMVENDAPF);
            return _verificarlimvendapf;
        }
        set
        {
            PropriedadeModificada(RO_VERIFICARLIMVENDAPF, value);
            _verificarlimvendapf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Verifpermissaocobrnodesdobr402
    {
        get
        {
            PropriedadeAcessada(RO_VERIFPERMISSAOCOBRNODESDOBR402);
            return _verifpermissaocobrnodesdobr402;
        }
        set
        {
            PropriedadeModificada(RO_VERIFPERMISSAOCOBRNODESDOBR402, value);
            _verifpermissaocobrnodesdobr402 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Verlanctobcochq
    {
        get
        {
            PropriedadeAcessada(RO_VERLANCTOBCOCHQ);
            return _verlanctobcochq;
        }
        set
        {
            PropriedadeModificada(RO_VERLANCTOBCOCHQ, value);
            _verlanctobcochq = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 2, Precisao = 0)]
    public decimal? Viasdanfe
    {
        get
        {
            PropriedadeAcessada(RO_VIASDANFE);
            return _viasdanfe;
        }
        set
        {
            PropriedadeModificada(RO_VIASDANFE, value);
            _viasdanfe = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 2)]
    public decimal? Vlbloqchd3
    {
        get
        {
            PropriedadeAcessada(RO_VLBLOQCHD3);
            return _vlbloqchd3;
        }
        set
        {
            PropriedadeModificada(RO_VLBLOQCHD3, value);
            _vlbloqchd3 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 2)]
    public decimal? Vldiferenca
    {
        get
        {
            PropriedadeAcessada(RO_VLDIFERENCA);
            return _vldiferenca;
        }
        set
        {
            PropriedadeModificada(RO_VLDIFERENCA, value);
            _vldiferenca = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 2)]
    public decimal? Vlmaxpedidopf
    {
        get
        {
            PropriedadeAcessada(RO_VLMAXPEDIDOPF);
            return _vlmaxpedidopf;
        }
        set
        {
            PropriedadeModificada(RO_VLMAXPEDIDOPF, value);
            _vlmaxpedidopf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 2)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 16, Precisao = 3)]
    public decimal? Vlmaxvenda
    {
        get
        {
            PropriedadeAcessada(RO_VLMAXVENDA);
            return _vlmaxvenda;
        }
        set
        {
            PropriedadeModificada(RO_VLMAXVENDA, value);
            _vlmaxvenda = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 2)]
    public decimal? Vlmaxvendabnf
    {
        get
        {
            PropriedadeAcessada(RO_VLMAXVENDABNF);
            return _vlmaxvendabnf;
        }
        set
        {
            PropriedadeModificada(RO_VLMAXVENDABNF, value);
            _vlmaxvendabnf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 16, Precisao = 3)]
    public decimal? Vlmaxvendapf
    {
        get
        {
            PropriedadeAcessada(RO_VLMAXVENDAPF);
            return _vlmaxvendapf;
        }
        set
        {
            PropriedadeModificada(RO_VLMAXVENDAPF, value);
            _vlmaxvendapf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 2)]
    public decimal? Vlmaxvendatlmkcodcobd
    {
        get
        {
            PropriedadeAcessada(RO_VLMAXVENDATLMKCODCOBD);
            return _vlmaxvendatlmkcodcobd;
        }
        set
        {
            PropriedadeModificada(RO_VLMAXVENDATLMKCODCOBD, value);
            _vlmaxvendatlmkcodcobd = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlmincanccupom
    {
        get
        {
            PropriedadeAcessada(RO_VLMINCANCCUPOM);
            return _vlmincanccupom;
        }
        set
        {
            PropriedadeModificada(RO_VLMINCANCCUPOM, value);
            _vlmincanccupom = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlmincancitemcupom
    {
        get
        {
            PropriedadeAcessada(RO_VLMINCANCITEMCUPOM);
            return _vlmincancitemcupom;
        }
        set
        {
            PropriedadeModificada(RO_VLMINCANCITEMCUPOM, value);
            _vlmincancitemcupom = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 2)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 2)]
    public decimal? Vlminvenda
    {
        get
        {
            PropriedadeAcessada(RO_VLMINVENDA);
            return _vlminvenda;
        }
        set
        {
            PropriedadeModificada(RO_VLMINVENDA, value);
            _vlminvenda = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 2)]
    public decimal? Vlminvendabk
    {
        get
        {
            PropriedadeAcessada(RO_VLMINVENDABK);
            return _vlminvendabk;
        }
        set
        {
            PropriedadeModificada(RO_VLMINVENDABK, value);
            _vlminvendabk = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 2)]
    public decimal? Vlminvendabnf
    {
        get
        {
            PropriedadeAcessada(RO_VLMINVENDABNF);
            return _vlminvendabnf;
        }
        set
        {
            PropriedadeModificada(RO_VLMINVENDABNF, value);
            _vlminvendabnf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlminvendatv3
    {
        get
        {
            PropriedadeAcessada(RO_VLMINVENDATV3);
            return _vlminvendatv3;
        }
        set
        {
            PropriedadeModificada(RO_VLMINVENDATV3, value);
            _vlminvendatv3 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 2)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 2)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 2)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 2)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 2)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 2)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 16, Precisao = 6)]
    public decimal? Volumepalete
    {
        get
        {
            PropriedadeAcessada(RO_VOLUMEPALETE);
            return _volumepalete;
        }
        set
        {
            PropriedadeModificada(RO_VOLUMEPALETE, value);
            _volumepalete = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 2)]
    public decimal? Volumetransf
    {
        get
        {
            PropriedadeAcessada(RO_VOLUMETRANSF);
            return _volumetransf;
        }
        set
        {
            PropriedadeModificada(RO_VOLUMETRANSF, value);
            _volumetransf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Zeralimcredbloqautomatic
    {
        get
        {
            PropriedadeAcessada(RO_ZERALIMCREDBLOQAUTOMATIC);
            return _zeralimcredbloqautomatic;
        }
        set
        {
            PropriedadeModificada(RO_ZERALIMCREDBLOQAUTOMATIC, value);
            _zeralimcredbloqautomatic = value;
        }
    }

    public void InicializarAtributos()
    {
    }

    public string ObterNomeTabela()
    {
        return "PCCONSUM";
    }

    public IEntidade NovaInstancia()
    {
        return (IEntidade)GetType().GetConstructors()[0].Invoke(null);
    }

    public void CarregarPorDataReader(IDataReader leitor)
    {
        _abastcorretivoautomat = AlterarTipo<string>(leitor["Abastcorretivoautomat"]);
        _abatefreteprecominimo = AlterarTipo<string>(leitor["Abatefreteprecominimo"]);
        _abatefretevendabalcao = AlterarTipo<string>(leitor["Abatefretevendabalcao"]);
        _abaterdescfincomissaorca = AlterarTipo<string>(leitor["Abaterdescfincomissaorca"]);
        _abaterimpostoscomissaorca = AlterarTipo<string>(leitor["Abaterimpostoscomissaorca"]);
        _abaterimpostosdescfin = AlterarTipo<string>(leitor["Abaterimpostosdescfin"]);
        _aceitaacrescimoprecofixo = AlterarTipo<string>(leitor["Aceitaacrescimoprecofixo"]);
        _aceitabktv3 = AlterarTipo<string>(leitor["Aceitabktv3"]);
        _aceitacnpjexclusivofornec = AlterarTipo<string>(leitor["Aceitacnpjexclusivofornec"]);
        _aceitadescbalcaoreserva = AlterarTipo<string>(leitor["Aceitadescbalcaoreserva"]);
        _aceitadescflexprodmonitorado = AlterarTipo<string>(leitor["Aceitadescflexprodmonitorado"]);
        _aceitadescprecofixo = AlterarTipo<string>(leitor["Aceitadescprecofixo"]);
        _aceitadescprecofixocesta = AlterarTipo<string>(leitor["Aceitadescprecofixocesta"]);
        _aceitadesctmk = AlterarTipo<string>(leitor["Aceitadesctmk"]);
        _aceitadesdconsumidoroutroscli = AlterarTipo<string>(leitor["Aceitadesdconsumidoroutroscli"]);
        _aceitapfcontribuinte = AlterarTipo<string>(leitor["Aceitapfcontribuinte"]);
        _aceitavendaaltusur = AlterarTipo<string>(leitor["Aceitavendaaltusur"]);
        _aceitavendabalcaoestneg = AlterarTipo<string>(leitor["Aceitavendabalcaoestneg"]);
        _aceitavendabloq = AlterarTipo<string>(leitor["Aceitavendabloq"]);
        _aceitavendapf = AlterarTipo<string>(leitor["Aceitavendapf"]);
        _aceitavendasemest = AlterarTipo<string>(leitor["Aceitavendasemest"]);
        _acertocargafilialdiferente = AlterarTipo<string>(leitor["Acertocargafilialdiferente"]);
        _acrescimopfcomie = AlterarTipo<string>(leitor["Acrescimopfcomie"]);
        _agregarstprodsintegra = AlterarTipo<string>(leitor["Agregarstprodsintegra"]);
        _aliqicminteroutrasdesp = AlterarTipo<decimal?>(leitor["Aliqicminteroutrasdesp"]);
        _aliqicmoutrasdesp = AlterarTipo<decimal?>(leitor["Aliqicmoutrasdesp"]);
        _alterarcontaajusteest = AlterarTipo<string>(leitor["Alterarcontaajusteest"]);
        _alterarfilialentpa = AlterarTipo<string>(leitor["Alterarfilialentpa"]);
        _alterarnumseqpedido = AlterarTipo<string>(leitor["Alterarnumseqpedido"]);
        _alterarprecoplpagamento = AlterarTipo<string>(leitor["Alterarprecoplpagamento"]);
        _apenasmiudezachekoutcarreg = AlterarTipo<string>(leitor["Apenasmiudezachekoutcarreg"]);
        _aplicaacrescpftv3 = AlterarTipo<string>(leitor["Aplicaacrescpftv3"]);
        _aplicarepassepercbonific = AlterarTipo<string>(leitor["Aplicarepassepercbonific"]);
        _aplicarindicecmv = AlterarTipo<string>(leitor["Aplicarindicecmv"]);
        _aplicatxfimautorizacao = AlterarTipo<string>(leitor["Aplicatxfimautorizacao"]);
        _areadeapanha = AlterarTipo<string>(leitor["Areadeapanha"]);
        _atualizacliultalter1203 = AlterarTipo<string>(leitor["Atualizacliultalter1203"]);
        _atualizacondcompedcompra = AlterarTipo<string>(leitor["Atualizacondcompedcompra"]);
        _atualizacustoultentransf = AlterarTipo<string>(leitor["Atualizacustoultentransf"]);
        _atualizaent1122 = AlterarTipo<string>(leitor["Atualizaent1122"]);
        _atualizaestcontconvembalagem = AlterarTipo<string>(leitor["Atualizaestcontconvembalagem"]);
        _atualizarpcprodutbonific = AlterarTipo<string>(leitor["Atualizarpcprodutbonific"]);
        _autenticaracertocx = AlterarTipo<string>(leitor["Autenticaracertocx"]);
        _autenticardoc = AlterarTipo<string>(leitor["Autenticardoc"]);
        _avisafaltaest = AlterarTipo<string>(leitor["Avisafaltaest"]);
        _baixampnaentpa = AlterarTipo<string>(leitor["Baixampnaentpa"]);
        _baixardnicomlancamento = AlterarTipo<string>(leitor["Baixardnicomlancamento"]);
        _basecreddebrcaautori = AlterarTipo<string>(leitor["Basecreddebrcaautori"]);
        _biometriaparticipasorteiobiro = AlterarTipo<string>(leitor["Biometriaparticipasorteiobiro"]);
        _bloqaplicpercmanutinv = AlterarTipo<string>(leitor["Bloqaplicpercmanutinv"]);
        _bloqcliaut = AlterarTipo<string>(leitor["Bloqcliaut"]);
        _bloqclienteexcdevol = AlterarTipo<string>(leitor["Bloqclienteexcdevol"]);
        _bloqcodcliprinc = AlterarTipo<string>(leitor["Bloqcodcliprinc"]);
        _bloqconsistenummapa = AlterarTipo<string>(leitor["Bloqconsistenummapa"]);
        _bloqdespvlrorc = AlterarTipo<string>(leitor["Bloqdespvlrorc"]);
        _bloqdevcli = AlterarTipo<string>(leitor["Bloqdevcli"]);
        _bloqestoquetransf = AlterarTipo<string>(leitor["Bloqestoquetransf"]);
        _bloqfornecverbasvencidas = AlterarTipo<string>(leitor["Bloqfornecverbasvencidas"]);
        _bloqf6pedvendabalcao = AlterarTipo<string>(leitor["Bloqf6pedvendabalcao"]);
        _bloqhistoricofin = AlterarTipo<string>(leitor["Bloqhistoricofin"]);
        _bloqitenscorte936 = AlterarTipo<string>(leitor["Bloqitenscorte936"]);
        _bloqlibpedcomdesconto = AlterarTipo<string>(leitor["Bloqlibpedcomdesconto"]);
        _bloqlibpedmargemneg = AlterarTipo<string>(leitor["Bloqlibpedmargemneg"]);
        _bloqpedlimcred = AlterarTipo<string>(leitor["Bloqpedlimcred"]);
        _bloqprazomdvenda = AlterarTipo<string>(leitor["Bloqprazomdvenda"]);
        _bloqueaprodent = AlterarTipo<string>(leitor["Bloqueaprodent"]);
        _bloquearendinvent = AlterarTipo<string>(leitor["Bloquearendinvent"]);
        _bloquearentpa = AlterarTipo<string>(leitor["Bloquearentpa"]);
        _bloquearpedbonific = AlterarTipo<string>(leitor["Bloquearpedbonific"]);
        _bloqueiavendaestpendente = AlterarTipo<string>(leitor["Bloqueiavendaestpendente"]);
        _bloqueio = AlterarTipo<string>(leitor["Bloqueio"]);
        _bloqvendatp1tpf = AlterarTipo<string>(leitor["Bloqvendatp1tpf"]);
        _bonificaltdebcredrca = AlterarTipo<string>(leitor["Bonificaltdebcredrca"]);
        _brokeraltdebcredrca = AlterarTipo<string>(leitor["Brokeraltdebcredrca"]);
        _calccredicms = AlterarTipo<string>(leitor["Calccredicms"]);
        _calccredpiscofins = AlterarTipo<string>(leitor["Calccredpiscofins"]);
        _calcfreteporitem = AlterarTipo<string>(leitor["Calcfreteporitem"]);
        _calcicmsfomezero = AlterarTipo<string>(leitor["Calcicmsfomezero"]);
        _calciofvendorcomposto = AlterarTipo<string>(leitor["Calciofvendorcomposto"]);
        _calcjurosdesd = AlterarTipo<string>(leitor["Calcjurosdesd"]);
        _calcstfontepf = AlterarTipo<string>(leitor["Calcstfontepf"]);
        _calcstpf = AlterarTipo<string>(leitor["Calcstpf"]);
        _calculacustoentpa = AlterarTipo<string>(leitor["Calculacustoentpa"]);
        _calculagirotransf = AlterarTipo<string>(leitor["Calculagirotransf"]);
        _calcularstcomipi = AlterarTipo<string>(leitor["Calcularstcomipi"]);
        _caminhodir = AlterarTipo<string>(leitor["Caminhodir"]);
        _cartaoparticipasorteiobiro = AlterarTipo<string>(leitor["Cartaoparticipasorteiobiro"]);
        _cep = AlterarTipo<string>(leitor["Cep"]);
        _cfop5929isento = AlterarTipo<string>(leitor["Cfop5929isento"]);
        _cgc = AlterarTipo<string>(leitor["Cgc"]);
        _cgccliexclusivo = AlterarTipo<string>(leitor["Cgccliexclusivo"]);
        _checardiasuteistitpgnlib = AlterarTipo<string>(leitor["Checardiasuteistitpgnlib"]);
        _checkoutmapaemitido = AlterarTipo<string>(leitor["Checkoutmapaemitido"]);
        _cidade = AlterarTipo<string>(leitor["Cidade"]);
        _classecomispadrao = AlterarTipo<string>(leitor["Classecomispadrao"]);
        _cliibgeobrg = AlterarTipo<string>(leitor["Cliibgeobrg"]);
        _cliipiobrg = AlterarTipo<string>(leitor["Cliipiobrg"]);
        _cobrarvltarifaparc1 = AlterarTipo<string>(leitor["Cobrarvltarifaparc1"]);
        _codcliconsumidor = AlterarTipo<decimal?>(leitor["Codcliconsumidor"]);
        _codclipc = AlterarTipo<decimal?>(leitor["Codclipc"]);
        _codcobinicial = AlterarTipo<string>(leitor["Codcobinicial"]);
        _codcobrancadescfinanceiro = AlterarTipo<string>(leitor["Codcobrancadescfinanceiro"]);
        _codcontaadiantfor = AlterarTipo<decimal?>(leitor["Codcontaadiantfor"]);
        _codcontaadiantforoutros = AlterarTipo<decimal?>(leitor["Codcontaadiantforoutros"]);
        _codcontaamostras = AlterarTipo<decimal?>(leitor["Codcontaamostras"]);
        _codcontabenefic = AlterarTipo<decimal?>(leitor["Codcontabenefic"]);
        _codcontabilcf = AlterarTipo<string>(leitor["Codcontabilcf"]);
        _codcontacambial = AlterarTipo<decimal?>(leitor["Codcontacambial"]);
        _codcontacomissao = AlterarTipo<decimal?>(leitor["Codcontacomissao"]);
        _codcontacomissao3 = AlterarTipo<decimal?>(leitor["Codcontacomissao3"]);
        _codcontacustoscartorio = AlterarTipo<decimal?>(leitor["Codcontacustoscartorio"]);
        _codcontadesccr = AlterarTipo<decimal?>(leitor["Codcontadesccr"]);
        _codcontadesenvolvimento = AlterarTipo<decimal?>(leitor["Codcontadesenvolvimento"]);
        _codcontadespesaproducao = AlterarTipo<decimal?>(leitor["Codcontadespesaproducao"]);
        _codcontadespos = AlterarTipo<decimal?>(leitor["Codcontadespos"]);
        _codcontadevcli = AlterarTipo<decimal?>(leitor["Codcontadevcli"]);
        _codcontafaltacaixa = AlterarTipo<decimal?>(leitor["Codcontafaltacaixa"]);
        _codcontagnre = AlterarTipo<decimal?>(leitor["Codcontagnre"]);
        _codcontaguiast = AlterarTipo<decimal?>(leitor["Codcontaguiast"]);
        _codcontajusteest = AlterarTipo<decimal?>(leitor["Codcontajusteest"]);
        _codcontalp = AlterarTipo<decimal?>(leitor["Codcontalp"]);
        _codcontamanutcusto = AlterarTipo<decimal?>(leitor["Codcontamanutcusto"]);
        _codcontantpag = AlterarTipo<decimal?>(leitor["Codcontantpag"]);
        _codcontaperda = AlterarTipo<decimal?>(leitor["Codcontaperda"]);
        _codcontaperdaestoque = AlterarTipo<decimal?>(leitor["Codcontaperdaestoque"]);
        _codcontaproducao = AlterarTipo<decimal?>(leitor["Codcontaproducao"]);
        _codcontaqualidade = AlterarTipo<decimal?>(leitor["Codcontaqualidade"]);
        _codcontarebaixacmv = AlterarTipo<decimal?>(leitor["Codcontarebaixacmv"]);
        _codcontarebaixacmvaapurar = AlterarTipo<decimal?>(leitor["Codcontarebaixacmvaapurar"]);
        _codcontarebaixacusto = AlterarTipo<decimal?>(leitor["Codcontarebaixacusto"]);
        _codcontarecdescarga = AlterarTipo<decimal?>(leitor["Codcontarecdescarga"]);
        _codcontareqmp = AlterarTipo<decimal?>(leitor["Codcontareqmp"]);
        _codcontarestcli = AlterarTipo<decimal?>(leitor["Codcontarestcli"]);
        _codcontarestrca = AlterarTipo<decimal?>(leitor["Codcontarestrca"]);
        _codcontasobraacerto = AlterarTipo<decimal?>(leitor["Codcontasobraacerto"]);
        _codcontasobracaixa = AlterarTipo<decimal?>(leitor["Codcontasobracaixa"]);
        _codcontasobramerc = AlterarTipo<decimal?>(leitor["Codcontasobramerc"]);
        _codcontatransftv10 = AlterarTipo<decimal?>(leitor["Codcontatransftv10"]);
        _codcontaverbacmv = AlterarTipo<decimal?>(leitor["Codcontaverbacmv"]);
        _codcontaverbafornec = AlterarTipo<decimal?>(leitor["Codcontaverbafornec"]);
        _codcontcli = AlterarTipo<decimal?>(leitor["Codcontcli"]);
        _codcontdebv = AlterarTipo<decimal?>(leitor["Codcontdebv"]);
        _codcontdescconc = AlterarTipo<decimal?>(leitor["Codcontdescconc"]);
        _codcontdespordemservico = AlterarTipo<decimal?>(leitor["Codcontdespordemservico"]);
        _codcontdevcli = AlterarTipo<decimal?>(leitor["Codcontdevcli"]);
        _codcontemprest = AlterarTipo<decimal?>(leitor["Codcontemprest"]);
        _codcontfor = AlterarTipo<decimal?>(leitor["Codcontfor"]);
        _codcontfre = AlterarTipo<decimal?>(leitor["Codcontfre"]);
        _codconticmsantecip = AlterarTipo<decimal?>(leitor["Codconticmsantecip"]);
        _codcontout = AlterarTipo<decimal?>(leitor["Codcontout"]);
        _codcontpagdiaria = AlterarTipo<decimal?>(leitor["Codcontpagdiaria"]);
        _codcontpagjur = AlterarTipo<decimal?>(leitor["Codcontpagjur"]);
        _codcontrecjur = AlterarTipo<decimal?>(leitor["Codcontrecjur"]);
        _codfilialcx = AlterarTipo<string>(leitor["Codfilialcx"]);
        _codfilialfv = AlterarTipo<string>(leitor["Codfilialfv"]);
        _codfiscaldevoutrasdesp = AlterarTipo<decimal?>(leitor["Codfiscaldevoutrasdesp"]);
        _codfiscalfrete = AlterarTipo<decimal?>(leitor["Codfiscalfrete"]);
        _codfiscalfreteent = AlterarTipo<decimal?>(leitor["Codfiscalfreteent"]);
        _codfiscalinterdevoutrasdesp = AlterarTipo<decimal?>(leitor["Codfiscalinterdevoutrasdesp"]);
        _codfiscalinterfrete = AlterarTipo<decimal?>(leitor["Codfiscalinterfrete"]);
        _codfiscalinterfreteent = AlterarTipo<decimal?>(leitor["Codfiscalinterfreteent"]);
        _codfiscalinteroutrasdesp = AlterarTipo<decimal?>(leitor["Codfiscalinteroutrasdesp"]);
        _codfiscaloutrasdesp = AlterarTipo<decimal?>(leitor["Codfiscaloutrasdesp"]);
        _codhistadicomis = AlterarTipo<decimal?>(leitor["Codhistadicomis"]);
        _codhistfechcomis = AlterarTipo<decimal?>(leitor["Codhistfechcomis"]);
        _codhistfechcomisneg = AlterarTipo<decimal?>(leitor["Codhistfechcomisneg"]);
        _codmotvisitapadraocallcenter = AlterarTipo<decimal?>(leitor["Codmotvisitapadraocallcenter"]);
        _codplpagautomatic = AlterarTipo<string>(leitor["Codplpagautomatic"]);
        _codplpaginicial = AlterarTipo<decimal?>(leitor["Codplpaginicial"]);
        _codpracaautomatic = AlterarTipo<string>(leitor["Codpracaautomatic"]);
        _codsetorcallcenter = AlterarTipo<decimal?>(leitor["Codsetorcallcenter"]);
        _codsetorcobranca = AlterarTipo<decimal?>(leitor["Codsetorcobranca"]);
        _codsetorcomprador = AlterarTipo<decimal?>(leitor["Codsetorcomprador"]);
        _codsetordiretoria = AlterarTipo<decimal?>(leitor["Codsetordiretoria"]);
        _codsetordiretorio = AlterarTipo<decimal?>(leitor["Codsetordiretorio"]);
        _codsetorembalador = AlterarTipo<decimal?>(leitor["Codsetorembalador"]);
        _codsetorexped = AlterarTipo<decimal?>(leitor["Codsetorexped"]);
        _codsetorfiscalcx = AlterarTipo<decimal?>(leitor["Codsetorfiscalcx"]);
        _codsetormotorista = AlterarTipo<decimal?>(leitor["Codsetormotorista"]);
        _codsetoropercx = AlterarTipo<decimal?>(leitor["Codsetoropercx"]);
        _codusurautomatic = AlterarTipo<string>(leitor["Codusurautomatic"]);
        _colunafluxocxcr1 = AlterarTipo<string>(leitor["Colunafluxocxcr1"]);
        _colunafluxocxcr2 = AlterarTipo<string>(leitor["Colunafluxocxcr2"]);
        _colunafluxocxcr3 = AlterarTipo<string>(leitor["Colunafluxocxcr3"]);
        _colunafluxocxcr4 = AlterarTipo<string>(leitor["Colunafluxocxcr4"]);
        _colunafluxocxcr5 = AlterarTipo<string>(leitor["Colunafluxocxcr5"]);
        _comissaorcatipovenda = AlterarTipo<string>(leitor["Comissaorcatipovenda"]);
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
        _conferindocargapedido = AlterarTipo<string>(leitor["Conferindocargapedido"]);
        _consederacessoproprio530 = AlterarTipo<string>(leitor["Consederacessoproprio530"]);
        _consideracmvdevolucao = AlterarTipo<string>(leitor["Consideracmvdevolucao"]);
        _consideraisentoscomopf = AlterarTipo<string>(leitor["Consideraisentoscomopf"]);
        _consideraricmsantecipcusto = AlterarTipo<string>(leitor["Consideraricmsantecipcusto"]);
        _consistecnpjfornec = AlterarTipo<string>(leitor["Consistecnpjfornec"]);
        _consolidando = AlterarTipo<string>(leitor["Consolidando"]);
        _consqtreservrebaixacusto = AlterarTipo<string>(leitor["Consqtreservrebaixacusto"]);
        _contalancperda = AlterarTipo<decimal?>(leitor["Contalancperda"]);
        _controlaedicaopedidocompra = AlterarTipo<string>(leitor["Controlaedicaopedidocompra"]);
        _controlaprodutivsep = AlterarTipo<string>(leitor["Controlaprodutivsep"]);
        _credencialparticipasorteiobiro = AlterarTipo<string>(leitor["Credencialparticipasorteiobiro"]);
        _crmaltdebcredrca = AlterarTipo<string>(leitor["Crmaltdebcredrca"]);
        _custoindustria = AlterarTipo<string>(leitor["Custoindustria"]);
        _deduziravariaestcomdevcli = AlterarTipo<string>(leitor["Deduziravariaestcomdevcli"]);
        _definirloteop = AlterarTipo<string>(leitor["Definirloteop"]);
        _depositovirtual = AlterarTipo<decimal?>(leitor["Depositovirtual"]);
        _desbloqclibxtitulo = AlterarTipo<string>(leitor["Desbloqclibxtitulo"]);
        _desbloquearprodfimos = AlterarTipo<string>(leitor["Desbloquearprodfimos"]);
        _descvenda = AlterarTipo<string>(leitor["Descvenda"]);
        _desdcartaofechcarga = AlterarTipo<string>(leitor["Desdcartaofechcarga"]);
        _desdobrarcadiferente = AlterarTipo<string>(leitor["Desdobrarcadiferente"]);
        _diasanalisedevol = AlterarTipo<decimal?>(leitor["Diasanalisedevol"]);
        _diasbloqfornecverbasvencidas = AlterarTipo<decimal?>(leitor["Diasbloqfornecverbasvencidas"]);
        _dirarquivointegracao = AlterarTipo<string>(leitor["Dirarquivointegracao"]);
        _direxportacaofv = AlterarTipo<string>(leitor["Direxportacaofv"]);
        _dirimportacaofv = AlterarTipo<string>(leitor["Dirimportacaofv"]);
        _dirimportacaofv2 = AlterarTipo<string>(leitor["Dirimportacaofv2"]);
        _dirop = AlterarTipo<string>(leitor["Dirop"]);
        _dirwinthor = AlterarTipo<string>(leitor["Dirwinthor"]);
        _dirwinthorremoto = AlterarTipo<string>(leitor["Dirwinthorremoto"]);
        _divideprzadicionalparcelas = AlterarTipo<string>(leitor["Divideprzadicionalparcelas"]);
        _dtatualizacaobd = AlterarTipo<DateTime?>(leitor["Dtatualizacaobd"]);
        _dtexpiracaowinthor = AlterarTipo<DateTime?>(leitor["Dtexpiracaowinthor"]);
        _dtinicionfp = AlterarTipo<DateTime?>(leitor["Dtinicionfp"]);
        _dtprocessamento = AlterarTipo<DateTime?>(leitor["Dtprocessamento"]);
        _dtproxatu = AlterarTipo<DateTime?>(leitor["Dtproxatu"]);
        _dtproxfechames = AlterarTipo<DateTime?>(leitor["Dtproxfechames"]);
        _dtultimageracaoserasa = AlterarTipo<DateTime?>(leitor["Dtultimageracaoserasa"]);
        _dtvalidasefaz = AlterarTipo<DateTime?>(leitor["Dtvalidasefaz"]);
        _dtvencantdesd = AlterarTipo<string>(leitor["Dtvencantdesd"]);
        _dtvenctk = AlterarTipo<DateTime?>(leitor["Dtvenctk"]);
        _dtvenctt = AlterarTipo<DateTime?>(leitor["Dtvenctt"]);
        _dtviradawms = AlterarTipo<DateTime?>(leitor["Dtviradawms"]);
        _dvobrigatorio = AlterarTipo<string>(leitor["Dvobrigatorio"]);
        _emitepedidovenda = AlterarTipo<string>(leitor["Emitepedidovenda"]);
        _emitindomapa = AlterarTipo<string>(leitor["Emitindomapa"]);
        _empresa = AlterarTipo<string>(leitor["Empresa"]);
        _enderecacombonusaberto = AlterarTipo<string>(leitor["Enderecacombonusaberto"]);
        _endereco = AlterarTipo<string>(leitor["Endereco"]);
        _enderecoapanhafilial = AlterarTipo<string>(leitor["Enderecoapanhafilial"]);
        _entrega_futura = AlterarTipo<string>(leitor["Entrega_Futura"]);
        _enviamensrcalibest = AlterarTipo<string>(leitor["Enviamensrcalibest"]);
        _enviarmsgrcacorte = AlterarTipo<string>(leitor["Enviarmsgrcacorte"]);
        _estado = AlterarTipo<string>(leitor["Estado"]);
        _exibirpvenda = AlterarTipo<string>(leitor["Exibirpvenda"]);
        _exigedtvalidadebonusrm = AlterarTipo<string>(leitor["Exigedtvalidadebonusrm"]);
        _expedepaletefechadodiretobox = AlterarTipo<string>(leitor["Expedepaletefechadodiretobox"]);
        _exportandodados = AlterarTipo<string>(leitor["Exportandodados"]);
        _faixafimteor = AlterarTipo<decimal?>(leitor["Faixafimteor"]);
        _faixainiteor = AlterarTipo<decimal?>(leitor["Faixainiteor"]);
        _faturafilialbroker = AlterarTipo<string>(leitor["Faturafilialbroker"]);
        _fax = AlterarTipo<string>(leitor["Fax"]);
        _fazerinsertpcembalagem = AlterarTipo<string>(leitor["Fazerinsertpcembalagem"]);
        _fechabonusemrecibodesc = AlterarTipo<string>(leitor["Fechabonusemrecibodesc"]);
        _fechacarregautvendabalcao = AlterarTipo<string>(leitor["Fechacarregautvendabalcao"]);
        _filialpadrao = AlterarTipo<string>(leitor["Filialpadrao"]);
        _formmapa = AlterarTipo<decimal?>(leitor["Formmapa"]);
        _fretenaotribcomooutras = AlterarTipo<string>(leitor["Fretenaotribcomooutras"]);
        _ftp_conexaopassiva = AlterarTipo<string>(leitor["Ftp_Conexaopassiva"]);
        _ftp_ip = AlterarTipo<string>(leitor["Ftp_Ip"]);
        _ftp_porta = AlterarTipo<decimal?>(leitor["Ftp_Porta"]);
        _geracontaspagardevcli = AlterarTipo<string>(leitor["Geracontaspagardevcli"]);
        _gerandomapa = AlterarTipo<string>(leitor["Gerandomapa"]);
        _geranftipo8 = AlterarTipo<string>(leitor["Geranftipo8"]);
        _geranumloteautomatico = AlterarTipo<string>(leitor["Geranumloteautomatico"]);
        _geraparcelamentotef = AlterarTipo<string>(leitor["Geraparcelamentotef"]);
        _gerarbrindepedbonific = AlterarTipo<string>(leitor["Gerarbrindepedbonific"]);
        _gerarcreclidevcli = AlterarTipo<string>(leitor["Gerarcreclidevcli"]);
        _gerardadosreducaoz = AlterarTipo<string>(leitor["Gerardadosreducaoz"]);
        _gerarnumloteautomaticpa = AlterarTipo<string>(leitor["Gerarnumloteautomaticpa"]);
        _gerarpcauxlancontasorcam = AlterarTipo<string>(leitor["Gerarpcauxlancontasorcam"]);
        _gerarpcfrete = AlterarTipo<string>(leitor["Gerarpcfrete"]);
        _gerarpclancicmsantecip = AlterarTipo<string>(leitor["Gerarpclancicmsantecip"]);
        _gerartrococobdin = AlterarTipo<string>(leitor["Gerartrococobdin"]);
        _geravalercadevmanif = AlterarTipo<string>(leitor["Geravalercadevmanif"]);
        _gravapcmensaltcadcli = AlterarTipo<string>(leitor["Gravapcmensaltcadcli"]);
        _gravarcotacao = AlterarTipo<string>(leitor["Gravarcotacao"]);
        _gravarobsclientenopedido = AlterarTipo<string>(leitor["Gravarobsclientenopedido"]);
        _habilitarlanctodadosfrota = AlterarTipo<string>(leitor["Habilitarlanctodadosfrota"]);
        _histfor = AlterarTipo<string>(leitor["Histfor"]);
        _histfre = AlterarTipo<string>(leitor["Histfre"]);
        _histout = AlterarTipo<string>(leitor["Histout"]);
        _ie = AlterarTipo<string>(leitor["Ie"]);
        _iecliexclusiva = AlterarTipo<string>(leitor["Iecliexclusiva"]);
        _impcartacobjuros = AlterarTipo<string>(leitor["Impcartacobjuros"]);
        _importandopedidos = AlterarTipo<string>(leitor["Importandopedidos"]);
        _impqtbonus = AlterarTipo<string>(leitor["Impqtbonus"]);
        _impressaoautomatica = AlterarTipo<string>(leitor["Impressaoautomatica"]);
        _imprimedescontocf = AlterarTipo<string>(leitor["Imprimedescontocf"]);
        _imprimirespelhoentmerc = AlterarTipo<string>(leitor["Imprimirespelhoentmerc"]);
        _incdupjurosdesd = AlterarTipo<string>(leitor["Incdupjurosdesd"]);
        _incluidesprodapenf = AlterarTipo<string>(leitor["Incluidesprodapenf"]);
        _incluircomissaocmvvenda = AlterarTipo<string>(leitor["Incluircomissaocmvvenda"]);
        _incluircomissaosugpvendacmv = AlterarTipo<string>(leitor["Incluircomissaosugpvendacmv"]);
        _indespelho = AlterarTipo<string>(leitor["Indespelho"]);
        _indicecustotransf = AlterarTipo<decimal?>(leitor["Indicecustotransf"]);
        _infnumverbapedbonific = AlterarTipo<string>(leitor["Infnumverbapedbonific"]);
        _informarecebedorvenda = AlterarTipo<string>(leitor["Informarecebedorvenda"]);
        _iniciaropsemem = AlterarTipo<string>(leitor["Iniciaropsemem"]);
        _inserircupom = AlterarTipo<string>(leitor["Inserircupom"]);
        _inserirmapa = AlterarTipo<string>(leitor["Inserirmapa"]);
        _inserirreducaoz = AlterarTipo<string>(leitor["Inserirreducaoz"]);
        _ipnfe = AlterarTipo<string>(leitor["Ipnfe"]);
        _iptabpreco = AlterarTipo<string>(leitor["Iptabpreco"]);
        _lancardespvendorautomatico = AlterarTipo<string>(leitor["Lancardespvendorautomatico"]);
        _lancarfretexparcelas = AlterarTipo<string>(leitor["Lancarfretexparcelas"]);
        _lancarstapenasparc1 = AlterarTipo<string>(leitor["Lancarstapenasparc1"]);
        _lancarvalecomodespesana1268 = AlterarTipo<string>(leitor["Lancarvalecomodespesana1268"]);
        _leiturach = AlterarTipo<string>(leitor["Leiturach"]);
        _liberaestentmerc = AlterarTipo<string>(leitor["Liberaestentmerc"]);
        _liberaestfechbonus = AlterarTipo<string>(leitor["Liberaestfechbonus"]);
        _liberarpedidopendente = AlterarTipo<string>(leitor["Liberarpedidopendente"]);
        _limcredinicial = AlterarTipo<decimal?>(leitor["Limcredinicial"]);
        _limcredinicialpf = AlterarTipo<decimal?>(leitor["Limcredinicialpf"]);
        _limitearredondamento = AlterarTipo<decimal?>(leitor["Limitearredondamento"]);
        _limparbasecalcentrada = AlterarTipo<string>(leitor["Limparbasecalcentrada"]);
        _limparobsnfdevol = AlterarTipo<string>(leitor["Limparobsnfdevol"]);
        _mantemnossonumbco1210 = AlterarTipo<string>(leitor["Mantemnossonumbco1210"]);
        _mantemnossonumbco402 = AlterarTipo<string>(leitor["Mantemnossonumbco402"]);
        _margemmin = AlterarTipo<decimal?>(leitor["Margemmin"]);
        _margemprev = AlterarTipo<decimal?>(leitor["Margemprev"]);
        _maxdiassemvenda = AlterarTipo<decimal?>(leitor["Maxdiassemvenda"]);
        _maxprzmediodesdcp = AlterarTipo<decimal?>(leitor["Maxprzmediodesdcp"]);
        _mensagem1nf = AlterarTipo<string>(leitor["Mensagem1nf"]);
        _mensagem2nf = AlterarTipo<string>(leitor["Mensagem2nf"]);
        _mercadoalvo = AlterarTipo<string>(leitor["Mercadoalvo"]);
        _montando = AlterarTipo<string>(leitor["Montando"]);
        _mostrarpvendasemst = AlterarTipo<string>(leitor["Mostrarpvendasemst"]);
        _mudacobcliente = AlterarTipo<string>(leitor["Mudacobcliente"]);
        _mudacobclientedias = AlterarTipo<decimal?>(leitor["Mudacobclientedias"]);
        _naogravarsaldoestoqueinventrot = AlterarTipo<string>(leitor["Naogravarsaldoestoqueinventrot"]);
        _naousaenderecomisto = AlterarTipo<string>(leitor["Naousaenderecomisto"]);
        _naousarpccrecliconsfinal = AlterarTipo<string>(leitor["Naousarpccrecliconsfinal"]);
        _naousarpickingcx = AlterarTipo<string>(leitor["Naousarpickingcx"]);
        _ndiasexpirasenha = AlterarTipo<decimal?>(leitor["Ndiasexpirasenha"]);
        _numautomaticcli = AlterarTipo<string>(leitor["Numautomaticcli"]);
        _numautomaticfor = AlterarTipo<string>(leitor["Numautomaticfor"]);
        _numautomaticprod = AlterarTipo<string>(leitor["Numautomaticprod"]);
        _numcasasdeccusto = AlterarTipo<decimal?>(leitor["Numcasasdeccusto"]);
        _numcasasdecestoque = AlterarTipo<decimal?>(leitor["Numcasasdecestoque"]);
        _numcasasdecinventario = AlterarTipo<decimal?>(leitor["Numcasasdecinventario"]);
        _numcasasdecproducao = AlterarTipo<decimal?>(leitor["Numcasasdecproducao"]);
        _numcasasdecvenda = AlterarTipo<decimal?>(leitor["Numcasasdecvenda"]);
        _numcustodiaautomatic = AlterarTipo<string>(leitor["Numcustodiaautomatic"]);
        _numdiasaltdtentrega = AlterarTipo<decimal?>(leitor["Numdiasaltdtentrega"]);
        _numdiasalteralivro = AlterarTipo<decimal?>(leitor["Numdiasalteralivro"]);
        _numdiasatu = AlterarTipo<decimal?>(leitor["Numdiasatu"]);
        _numdiasbloqautomatic = AlterarTipo<decimal?>(leitor["Numdiasbloqautomatic"]);
        _numdiasbloqchp = AlterarTipo<decimal?>(leitor["Numdiasbloqchp"]);
        _numdiascadclibloqchdv = AlterarTipo<decimal?>(leitor["Numdiascadclibloqchdv"]);
        _numdiaschdvbloqcli = AlterarTipo<decimal?>(leitor["Numdiaschdvbloqcli"]);
        _numdiascliinativ = AlterarTipo<decimal?>(leitor["Numdiascliinativ"]);
        _numdiasdesbloqchd1 = AlterarTipo<decimal?>(leitor["Numdiasdesbloqchd1"]);
        _numdiasmaxacertarcarga = AlterarTipo<decimal?>(leitor["Numdiasmaxacertarcarga"]);
        _numdiasmaxbaixarecibo = AlterarTipo<decimal?>(leitor["Numdiasmaxbaixarecibo"]);
        _numdiasmaxcancbordero = AlterarTipo<decimal?>(leitor["Numdiasmaxcancbordero"]);
        _numdiasmaxcancnfent = AlterarTipo<decimal?>(leitor["Numdiasmaxcancnfent"]);
        _numdiasmaxcancnfsaida = AlterarTipo<decimal?>(leitor["Numdiasmaxcancnfsaida"]);
        _numdiasmaxdesdcpagar = AlterarTipo<decimal?>(leitor["Numdiasmaxdesdcpagar"]);
        _numdiasmaxdesd1210 = AlterarTipo<decimal?>(leitor["Numdiasmaxdesd1210"]);
        _numdiasmaxdesd402 = AlterarTipo<decimal?>(leitor["Numdiasmaxdesd402"]);
        _numdiasmaxemissaocp = AlterarTipo<decimal?>(leitor["Numdiasmaxemissaocp"]);
        _numdiasmaxemissaonf = AlterarTipo<decimal?>(leitor["Numdiasmaxemissaonf"]);
        _numdiasmaxfatura = AlterarTipo<decimal?>(leitor["Numdiasmaxfatura"]);
        _numdiasmaxprorrog = AlterarTipo<decimal?>(leitor["Numdiasmaxprorrog"]);
        _numdiasmaxvendacliinadimplente = AlterarTipo<decimal?>(leitor["Numdiasmaxvendacliinadimplente"]);
        _numdiasmindesppag = AlterarTipo<decimal?>(leitor["Numdiasmindesppag"]);
        _numdiasminvendabk = AlterarTipo<decimal?>(leitor["Numdiasminvendabk"]);
        _numdiaspagchqcancel = AlterarTipo<decimal?>(leitor["Numdiaspagchqcancel"]);
        _numdiaspagtoretro = AlterarTipo<decimal?>(leitor["Numdiaspagtoretro"]);
        _numdiasuteissemana = AlterarTipo<decimal?>(leitor["Numdiasuteissemana"]);
        _numdiasuteistrimestre = AlterarTipo<decimal?>(leitor["Numdiasuteistrimestre"]);
        _numdiasvenctitulocobext = AlterarTipo<decimal?>(leitor["Numdiasvenctitulocobext"]);
        _numdiasvenctitulocobint = AlterarTipo<decimal?>(leitor["Numdiasvenctitulocobint"]);
        _numitensos = AlterarTipo<decimal?>(leitor["Numitensos"]);
        _nummaxnftransf = AlterarTipo<decimal?>(leitor["Nummaxnftransf"]);
        _nummaxparcent = AlterarTipo<decimal?>(leitor["Nummaxparcent"]);
        _nummaxtitulosporrecibo = AlterarTipo<decimal?>(leitor["Nummaxtitulosporrecibo"]);
        _numordabas = AlterarTipo<decimal?>(leitor["Numordabas"]);
        _numregiaopadrao = AlterarTipo<decimal?>(leitor["Numregiaopadrao"]);
        _numviasfichacp = AlterarTipo<decimal?>(leitor["Numviasfichacp"]);
        _numviasmapasep = AlterarTipo<decimal?>(leitor["Numviasmapasep"]);
        _obterpreferenciacliecf = AlterarTipo<string>(leitor["Obterpreferenciacliecf"]);
        _ordemavaliacaocomissaorca = AlterarTipo<decimal?>(leitor["Ordemavaliacaocomissaorca"]);
        _ordemmapa = AlterarTipo<decimal?>(leitor["Ordemmapa"]);
        _osreservanaexecucao = AlterarTipo<string>(leitor["Osreservanaexecucao"]);
        _padraocallcenter = AlterarTipo<string>(leitor["Padraocallcenter"]);
        _pasta_relatorio = AlterarTipo<string>(leitor["Pasta_Relatorio"]);
        _pckabastecido = AlterarTipo<string>(leitor["Pckabastecido"]);
        _pedidocompraporpalete = AlterarTipo<string>(leitor["Pedidocompraporpalete"]);
        _pedidopordistrib = AlterarTipo<string>(leitor["Pedidopordistrib"]);
        _pedvendadepto = AlterarTipo<string>(leitor["Pedvendadepto"]);
        _perbaseredoutrasdesp = AlterarTipo<decimal?>(leitor["Perbaseredoutrasdesp"]);
        _perbasevend = AlterarTipo<decimal?>(leitor["Perbasevend"]);
        _percacrescimobalcao = AlterarTipo<decimal?>(leitor["Percacrescimobalcao"]);
        _percacrescimocustofin = AlterarTipo<decimal?>(leitor["Percacrescimocustofin"]);
        _percacrescimocustoreal = AlterarTipo<decimal?>(leitor["Percacrescimocustoreal"]);
        _percapanha = AlterarTipo<decimal?>(leitor["Percapanha"]);
        _perccsrf = AlterarTipo<decimal?>(leitor["Perccsrf"]);
        _percdifqtent = AlterarTipo<decimal?>(leitor["Percdifqtent"]);
        _percexcessodevol = AlterarTipo<decimal?>(leitor["Percexcessodevol"]);
        _percicmfrete = AlterarTipo<decimal?>(leitor["Percicmfrete"]);
        _percicmfreteent = AlterarTipo<decimal?>(leitor["Percicmfreteent"]);
        _percicminterfrete = AlterarTipo<decimal?>(leitor["Percicminterfrete"]);
        _percicminterfreteent = AlterarTipo<decimal?>(leitor["Percicminterfreteent"]);
        _percinss = AlterarTipo<decimal?>(leitor["Percinss"]);
        _percjurosmora = AlterarTipo<decimal?>(leitor["Percjurosmora"]);
        _perclanccredcli = AlterarTipo<decimal?>(leitor["Perclanccredcli"]);
        _percmaxdesccr = AlterarTipo<decimal?>(leitor["Percmaxdesccr"]);
        _percmaxdescdesd = AlterarTipo<decimal?>(leitor["Percmaxdescdesd"]);
        _percmaxjurosmora = AlterarTipo<decimal?>(leitor["Percmaxjurosmora"]);
        _percmaxlibestoque = AlterarTipo<decimal?>(leitor["Percmaxlibestoque"]);
        _percminjurosmora = AlterarTipo<decimal?>(leitor["Percminjurosmora"]);
        _perctoleranciaimpureza = AlterarTipo<decimal?>(leitor["Perctoleranciaimpureza"]);
        _perctoleranciainteiro = AlterarTipo<decimal?>(leitor["Perctoleranciainteiro"]);
        _perctoleranciaquebrado = AlterarTipo<decimal?>(leitor["Perctoleranciaquebrado"]);
        _perctoleranciaumidade = AlterarTipo<decimal?>(leitor["Perctoleranciaumidade"]);
        _perctoleranciavermelho = AlterarTipo<decimal?>(leitor["Perctoleranciavermelho"]);
        _perdescmaxbalcao = AlterarTipo<decimal?>(leitor["Perdescmaxbalcao"]);
        _perdescmediovenda = AlterarTipo<decimal?>(leitor["Perdescmediovenda"]);
        _perdescprom = AlterarTipo<decimal?>(leitor["Perdescprom"]);
        _perexcedelimcred = AlterarTipo<decimal?>(leitor["Perexcedelimcred"]);
        _perguntarsomaqtpedvenda = AlterarTipo<string>(leitor["Perguntarsomaqtpedvenda"]);
        _perlimvendapf = AlterarTipo<decimal?>(leitor["Perlimvendapf"]);
        _permaxdescautor = AlterarTipo<decimal?>(leitor["Permaxdescautor"]);
        _permaxdescitemcf = AlterarTipo<decimal?>(leitor["Permaxdescitemcf"]);
        _permaxdescvenda = AlterarTipo<decimal?>(leitor["Permaxdescvenda"]);
        _permaxdifentrada = AlterarTipo<decimal?>(leitor["Permaxdifentrada"]);
        _permaxindenizpedido = AlterarTipo<decimal?>(leitor["Permaxindenizpedido"]);
        _permaxpcompra = AlterarTipo<decimal?>(leitor["Permaxpcompra"]);
        _permaxrodape = AlterarTipo<decimal?>(leitor["Permaxrodape"]);
        _permaxrodapecheckout = AlterarTipo<decimal?>(leitor["Permaxrodapecheckout"]);
        _permaxvenda = AlterarTipo<decimal?>(leitor["Permaxvenda"]);
        _permindifentrada = AlterarTipo<decimal?>(leitor["Permindifentrada"]);
        _permitealtcodcobvenda = AlterarTipo<string>(leitor["Permitealtcodcobvenda"]);
        _permitealtdtvencentmerc = AlterarTipo<string>(leitor["Permitealtdtvencentmerc"]);
        _permitealtplpagvenda = AlterarTipo<string>(leitor["Permitealtplpagvenda"]);
        _permitecodbarraduplicado = AlterarTipo<string>(leitor["Permitecodbarraduplicado"]);
        _permitecomprafornecbloq = AlterarTipo<string>(leitor["Permitecomprafornecbloq"]);
        _permitecrdevfornec = AlterarTipo<string>(leitor["Permitecrdevfornec"]);
        _permitedesccr = AlterarTipo<string>(leitor["Permitedesccr"]);
        _permitedevolreqnormal = AlterarTipo<string>(leitor["Permitedevolreqnormal"]);
        _permiteiniciaropsemmp = AlterarTipo<string>(leitor["Permiteiniciaropsemmp"]);
        _permitepedcompramultiplo = AlterarTipo<string>(leitor["Permitepedcompramultiplo"]);
        _permitepedcompraunidmaster = AlterarTipo<string>(leitor["Permitepedcompraunidmaster"]);
        _permiteplpagtosuperior = AlterarTipo<string>(leitor["Permiteplpagtosuperior"]);
        _permitevariospedidosorcamento = AlterarTipo<string>(leitor["Permitevariospedidosorcamento"]);
        _permitevendaecf402 = AlterarTipo<string>(leitor["Permitevendaecf402"]);
        _permitevendaprodutopv = AlterarTipo<string>(leitor["Permitevendaprodutopv"]);
        _permitirdescrodapecheckout = AlterarTipo<string>(leitor["Permitirdescrodapecheckout"]);
        _permitirdesddevcli = AlterarTipo<string>(leitor["Permitirdesddevcli"]);
        _permitirdesdtitvencsemjuros = AlterarTipo<string>(leitor["Permitirdesdtitvencsemjuros"]);
        _permitirdivnfduplic = AlterarTipo<string>(leitor["Permitirdivnfduplic"]);
        _pervendapf = AlterarTipo<decimal?>(leitor["Pervendapf"]);
        _pesomaxpalete = AlterarTipo<decimal?>(leitor["Pesomaxpalete"]);
        _pesosuppalete = AlterarTipo<decimal?>(leitor["Pesosuppalete"]);
        _pesotransf = AlterarTipo<decimal?>(leitor["Pesotransf"]);
        _portanfe = AlterarTipo<decimal?>(leitor["Portanfe"]);
        _prazoadicionalmax = AlterarTipo<decimal?>(leitor["Prazoadicionalmax"]);
        _prazoedicaopedidocompra = AlterarTipo<decimal?>(leitor["Prazoedicaopedidocompra"]);
        _prazoentrega = AlterarTipo<decimal?>(leitor["Prazoentrega"]);
        _prazofatalmed = AlterarTipo<decimal?>(leitor["Prazofatalmed"]);
        _prazomaxdtentrega = AlterarTipo<decimal?>(leitor["Prazomaxdtentrega"]);
        _prazomaxvalidade = AlterarTipo<decimal?>(leitor["Prazomaxvalidade"]);
        _prazominvalidade = AlterarTipo<decimal?>(leitor["Prazominvalidade"]);
        _prazovalidadeorcamento = AlterarTipo<decimal?>(leitor["Prazovalidadeorcamento"]);
        _prazovalidadepedbalcao = AlterarTipo<decimal?>(leitor["Prazovalidadepedbalcao"]);
        _precoporembalagem = AlterarTipo<string>(leitor["Precoporembalagem"]);
        _procnumlista = AlterarTipo<decimal?>(leitor["Procnumlista"]);
        _proxcodplpag = AlterarTipo<decimal?>(leitor["Proxcodplpag"]);
        _proxcodpraca = AlterarTipo<decimal?>(leitor["Proxcodpraca"]);
        _proxcodusur = AlterarTipo<decimal?>(leitor["Proxcodusur"]);
        _proxnumaplic = AlterarTipo<decimal?>(leitor["Proxnumaplic"]);
        _proxnumbonus = AlterarTipo<decimal?>(leitor["Proxnumbonus"]);
        _proxnumbordero = AlterarTipo<decimal?>(leitor["Proxnumbordero"]);
        _proxnumborderocr = AlterarTipo<decimal?>(leitor["Proxnumborderocr"]);
        _proxnumcar = AlterarTipo<decimal?>(leitor["Proxnumcar"]);
        _proxnumcli = AlterarTipo<decimal?>(leitor["Proxnumcli"]);
        _proxnumcodbarralote = AlterarTipo<decimal?>(leitor["Proxnumcodbarralote"]);
        _proxnumconhec = AlterarTipo<decimal?>(leitor["Proxnumconhec"]);
        _proxnumcontrato = AlterarTipo<decimal?>(leitor["Proxnumcontrato"]);
        _proxnumcustodia = AlterarTipo<decimal?>(leitor["Proxnumcustodia"]);
        _proxnumfornec = AlterarTipo<decimal?>(leitor["Proxnumfornec"]);
        _proxnumindeniz = AlterarTipo<decimal?>(leitor["Proxnumindeniz"]);
        _proxnuminventrot = AlterarTipo<decimal?>(leitor["Proxnuminventrot"]);
        _proxnumlanc = AlterarTipo<decimal?>(leitor["Proxnumlanc"]);
        _proxnumlote = AlterarTipo<decimal?>(leitor["Proxnumlote"]);
        _proxnumlotecustodia = AlterarTipo<decimal?>(leitor["Proxnumlotecustodia"]);
        _proxnumloteem = AlterarTipo<decimal?>(leitor["Proxnumloteem"]);
        _proxnumlotemp = AlterarTipo<decimal?>(leitor["Proxnumlotemp"]);
        _proxnumlotenfe = AlterarTipo<decimal?>(leitor["Proxnumlotenfe"]);
        _proxnumlotenfedpec = AlterarTipo<decimal?>(leitor["Proxnumlotenfedpec"]);
        _proxnumlotereagente = AlterarTipo<decimal?>(leitor["Proxnumlotereagente"]);
        _proxnumlotesa = AlterarTipo<decimal?>(leitor["Proxnumlotesa"]);
        _proxnummanif = AlterarTipo<decimal?>(leitor["Proxnummanif"]);
        _proxnumneg = AlterarTipo<decimal?>(leitor["Proxnumneg"]);
        _proxnumop = AlterarTipo<decimal?>(leitor["Proxnumop"]);
        _proxnumopi = AlterarTipo<decimal?>(leitor["Proxnumopi"]);
        _proxnumorc = AlterarTipo<decimal?>(leitor["Proxnumorc"]);
        _proxnumordemtransf = AlterarTipo<decimal?>(leitor["Proxnumordemtransf"]);
        _proxnumpcp = AlterarTipo<decimal?>(leitor["Proxnumpcp"]);
        _proxnumped = AlterarTipo<decimal?>(leitor["Proxnumped"]);
        _proxnumpedtlmk = AlterarTipo<decimal?>(leitor["Proxnumpedtlmk"]);
        _proxnumpesquisa = AlterarTipo<decimal?>(leitor["Proxnumpesquisa"]);
        _proxnumprodut = AlterarTipo<decimal?>(leitor["Proxnumprodut"]);
        _proxnumrca = AlterarTipo<decimal?>(leitor["Proxnumrca"]);
        _proxnumrpa = AlterarTipo<decimal?>(leitor["Proxnumrpa"]);
        _proxnumsimulacaopcp = AlterarTipo<decimal?>(leitor["Proxnumsimulacaopcp"]);
        _proxnumtira = AlterarTipo<decimal?>(leitor["Proxnumtira"]);
        _proxnumtrans = AlterarTipo<decimal?>(leitor["Proxnumtrans"]);
        _proxnumtransavulsa = AlterarTipo<decimal?>(leitor["Proxnumtransavulsa"]);
        _proxnumtranscrfor = AlterarTipo<decimal?>(leitor["Proxnumtranscrfor"]);
        _proxnumtransent = AlterarTipo<decimal?>(leitor["Proxnumtransent"]);
        _proxnumtransop = AlterarTipo<decimal?>(leitor["Proxnumtransop"]);
        _proxnumtransvenda = AlterarTipo<decimal?>(leitor["Proxnumtransvenda"]);
        _proxnumtransvendor = AlterarTipo<decimal?>(leitor["Proxnumtransvendor"]);
        _proxnumtranswms = AlterarTipo<decimal?>(leitor["Proxnumtranswms"]);
        _proxnumtroca = AlterarTipo<decimal?>(leitor["Proxnumtroca"]);
        _proxnumvale = AlterarTipo<decimal?>(leitor["Proxnumvale"]);
        _proxnumverba = AlterarTipo<decimal?>(leitor["Proxnumverba"]);
        _qtchdvbloqcli = AlterarTipo<decimal?>(leitor["Qtchdvbloqcli"]);
        _qtdegerlivro = AlterarTipo<decimal?>(leitor["Qtdegerlivro"]);
        _qtdeminimausoasterisco936 = AlterarTipo<decimal?>(leitor["Qtdeminimausoasterisco936"]);
        _qtdeparcelasimpostosfrete = AlterarTipo<decimal?>(leitor["Qtdeparcelasimpostosfrete"]);
        _qtmaxunidadepf = AlterarTipo<decimal?>(leitor["Qtmaxunidadepf"]);
        _qtmesesclassestrelas = AlterarTipo<decimal?>(leitor["Qtmesesclassestrelas"]);
        _qtmesesclassgrupocartao = AlterarTipo<decimal?>(leitor["Qtmesesclassgrupocartao"]);
        _qtmesescredciap = AlterarTipo<decimal?>(leitor["Qtmesescredciap"]);
        _qtmesesgrupos = AlterarTipo<decimal?>(leitor["Qtmesesgrupos"]);
        _rateiodescbaixacr = AlterarTipo<string>(leitor["Rateiodescbaixacr"]);
        _rebaixacustocomdescfin = AlterarTipo<string>(leitor["Rebaixacustocomdescfin"]);
        _rebaixacustoultent = AlterarTipo<string>(leitor["Rebaixacustoultent"]);
        _reducaobcisenta = AlterarTipo<string>(leitor["Reducaobcisenta"]);
        _replicarprecoporembalagem = AlterarTipo<string>(leitor["Replicarprecoporembalagem"]);
        _restringenumitensnf = AlterarTipo<string>(leitor["Restringenumitensnf"]);
        _restringenumviasnf = AlterarTipo<string>(leitor["Restringenumviasnf"]);
        _restringenumviaspu = AlterarTipo<string>(leitor["Restringenumviaspu"]);
        _restringirconferencialote = AlterarTipo<string>(leitor["Restringirconferencialote"]);
        _rotina2562emuso = AlterarTipo<decimal?>(leitor["Rotina2562emuso"]);
        _saltarpaginarua = AlterarTipo<string>(leitor["Saltarpaginarua"]);
        _segmentoserasa = AlterarTipo<decimal?>(leitor["Segmentoserasa"]);
        _sempreatualizaqtestconvemb = AlterarTipo<string>(leitor["Sempreatualizaqtestconvemb"]);
        _senhalogon = AlterarTipo<string>(leitor["Senhalogon"]);
        _separacaoflowrack = AlterarTipo<string>(leitor["Separacaoflowrack"]);
        _separarprodcomrestricaotransp = AlterarTipo<string>(leitor["Separarprodcomrestricaotransp"]);
        _siglaespecie = AlterarTipo<string>(leitor["Siglaespecie"]);
        _siglaserie = AlterarTipo<string>(leitor["Siglaserie"]);
        _situacaoinicialbloqueio = AlterarTipo<string>(leitor["Situacaoinicialbloqueio"]);
        _somacomissaocmv = AlterarTipo<string>(leitor["Somacomissaocmv"]);
        _somacompraprevfluxocx = AlterarTipo<string>(leitor["Somacompraprevfluxocx"]);
        _somadescclidescprod = AlterarTipo<string>(leitor["Somadescclidescprod"]);
        _somadespfinitemcf = AlterarTipo<string>(leitor["Somadespfinitemcf"]);
        _somaicmsantecipduplic = AlterarTipo<string>(leitor["Somaicmsantecipduplic"]);
        _somaimpostostransf = AlterarTipo<string>(leitor["Somaimpostostransf"]);
        _somaqtpedvenda = AlterarTipo<string>(leitor["Somaqtpedvenda"]);
        _somatarifabancduplic = AlterarTipo<string>(leitor["Somatarifabancduplic"]);
        _somatarifabancnf = AlterarTipo<string>(leitor["Somatarifabancnf"]);
        _somatxboleto = AlterarTipo<string>(leitor["Somatxboleto"]);
        _somavltarifaitensnf = AlterarTipo<string>(leitor["Somavltarifaitensnf"]);
        _somentecodbarrasbonus = AlterarTipo<string>(leitor["Somentecodbarrasbonus"]);
        _somentecodbarrasconfped = AlterarTipo<string>(leitor["Somentecodbarrasconfped"]);
        _sugvenda = AlterarTipo<decimal?>(leitor["Sugvenda"]);
        _tarjamagneticaobrigatoria = AlterarTipo<string>(leitor["Tarjamagneticaobrigatoria"]);
        _taxatabpr = AlterarTipo<string>(leitor["Taxatabpr"]);
        _taxa0 = AlterarTipo<decimal?>(leitor["Taxa0"]);
        _taxa14 = AlterarTipo<decimal?>(leitor["Taxa14"]);
        _taxa21 = AlterarTipo<decimal?>(leitor["Taxa21"]);
        _taxa28 = AlterarTipo<decimal?>(leitor["Taxa28"]);
        _taxa35 = AlterarTipo<decimal?>(leitor["Taxa35"]);
        _taxa42 = AlterarTipo<decimal?>(leitor["Taxa42"]);
        _taxa7 = AlterarTipo<decimal?>(leitor["Taxa7"]);
        _telefone = AlterarTipo<string>(leitor["Telefone"]);
        _tempmenflow = AlterarTipo<decimal?>(leitor["Tempmenflow"]);
        _tempomaxcancel = AlterarTipo<string>(leitor["Tempomaxcancel"]);
        _temrepos = AlterarTipo<decimal?>(leitor["Temrepos"]);
        _timermsgagenda = AlterarTipo<decimal?>(leitor["Timermsgagenda"]);
        _tipoabasprev = AlterarTipo<string>(leitor["Tipoabasprev"]);
        _tipoaliqoutrasdesp = AlterarTipo<string>(leitor["Tipoaliqoutrasdesp"]);
        _tipoaplicindice = AlterarTipo<string>(leitor["Tipoaplicindice"]);
        _tipoaplicrepasse = AlterarTipo<string>(leitor["Tipoaplicrepasse"]);
        _tipobaixacobmag = AlterarTipo<decimal?>(leitor["Tipobaixacobmag"]);
        _tipocalcdescargapal = AlterarTipo<string>(leitor["Tipocalcdescargapal"]);
        _tipocalcgirodia = AlterarTipo<string>(leitor["Tipocalcgirodia"]);
        _tipocalcipi = AlterarTipo<string>(leitor["Tipocalcipi"]);
        _tipocalcst = AlterarTipo<string>(leitor["Tipocalcst"]);
        _tipocalcsulframa = AlterarTipo<string>(leitor["Tipocalcsulframa"]);
        _tipocustoajuste = AlterarTipo<string>(leitor["Tipocustoajuste"]);
        _tipocustotransf = AlterarTipo<string>(leitor["Tipocustotransf"]);
        _tipocusto1322 = AlterarTipo<string>(leitor["Tipocusto1322"]);
        _tipoembalagem = AlterarTipo<string>(leitor["Tipoembalagem"]);
        _tipoenderecamento = AlterarTipo<string>(leitor["Tipoenderecamento"]);
        _tipoentregapadraocallcenter = AlterarTipo<string>(leitor["Tipoentregapadraocallcenter"]);
        _tipogeracaodadospcauxpro = AlterarTipo<string>(leitor["Tipogeracaodadospcauxpro"]);
        _tipointegracao = AlterarTipo<string>(leitor["Tipointegracao"]);
        _tipomapawmsvendabalcao = AlterarTipo<string>(leitor["Tipomapawmsvendabalcao"]);
        _tipomascaraenderwms = AlterarTipo<decimal?>(leitor["Tipomascaraenderwms"]);
        _tipomovccrca = AlterarTipo<string>(leitor["Tipomovccrca"]);
        _tiponumnfentrada = AlterarTipo<string>(leitor["Tiponumnfentrada"]);
        _tipoordenacaonfsaida = AlterarTipo<string>(leitor["Tipoordenacaonfsaida"]);
        _tipoperiodogirodia = AlterarTipo<string>(leitor["Tipoperiodogirodia"]);
        _tiporelmapa = AlterarTipo<string>(leitor["Tiporelmapa"]);
        _tipotaxavendor = AlterarTipo<string>(leitor["Tipotaxavendor"]);
        _tipotitulosecf402 = AlterarTipo<string>(leitor["Tipotitulosecf402"]);
        _tipotitulosecf409 = AlterarTipo<string>(leitor["Tipotitulosecf409"]);
        _tipotxboleto = AlterarTipo<string>(leitor["Tipotxboleto"]);
        _tipovalorgirodia = AlterarTipo<string>(leitor["Tipovalorgirodia"]);
        _tipovlminvendabk = AlterarTipo<string>(leitor["Tipovlminvendabk"]);
        _tratarrestricaoacrescimo = AlterarTipo<string>(leitor["Tratarrestricaoacrescimo"]);
        _travavendapf = AlterarTipo<string>(leitor["Travavendapf"]);
        _tributafreterateado = AlterarTipo<string>(leitor["Tributafreterateado"]);
        _trocaaltdebcredrca = AlterarTipo<string>(leitor["Trocaaltdebcredrca"]);
        _tx = AlterarTipo<decimal?>(leitor["Tx"]);
        _txiof = AlterarTipo<decimal?>(leitor["Txiof"]);
        _txvenda = AlterarTipo<decimal?>(leitor["Txvenda"]);
        _txvendorcli = AlterarTipo<decimal?>(leitor["Txvendorcli"]);
        _ultnumdatacheq = AlterarTipo<DateTime?>(leitor["Ultnumdatacheq"]);
        _updateautmenu = AlterarTipo<string>(leitor["Updateautmenu"]);
        _usabcrent = AlterarTipo<string>(leitor["Usabcrent"]);
        _usacancelamentoautomaticoecf = AlterarTipo<string>(leitor["Usacancelamentoautomaticoecf"]);
        _usacategoria = AlterarTipo<string>(leitor["Usacategoria"]);
        _usacestabasicacf = AlterarTipo<string>(leitor["Usacestabasicacf"]);
        _usachavetriplapcpedi = AlterarTipo<string>(leitor["Usachavetriplapcpedi"]);
        _usacomissaoecf = AlterarTipo<string>(leitor["Usacomissaoecf"]);
        _usacomissaoporclasse = AlterarTipo<string>(leitor["Usacomissaoporclasse"]);
        _usacomissaoporcliente = AlterarTipo<string>(leitor["Usacomissaoporcliente"]);
        _usacomissaoporlinhaprod = AlterarTipo<string>(leitor["Usacomissaoporlinhaprod"]);
        _usacomissaoporrca = AlterarTipo<string>(leitor["Usacomissaoporrca"]);
        _usacontrolederecibos = AlterarTipo<string>(leitor["Usacontrolederecibos"]);
        _usacontroleemissaonf = AlterarTipo<string>(leitor["Usacontroleemissaonf"]);
        _usacontrolefornecpedcompra = AlterarTipo<string>(leitor["Usacontrolefornecpedcompra"]);
        _usacontroletipoverba = AlterarTipo<string>(leitor["Usacontroletipoverba"]);
        _usaconversaoembalagem = AlterarTipo<string>(leitor["Usaconversaoembalagem"]);
        _usacreclivendabalcao = AlterarTipo<string>(leitor["Usacreclivendabalcao"]);
        _usacreclivendatlmkt = AlterarTipo<string>(leitor["Usacreclivendatlmkt"]);
        _usacredclitodasfiliais = AlterarTipo<string>(leitor["Usacredclitodasfiliais"]);
        _usacredrca = AlterarTipo<string>(leitor["Usacredrca"]);
        _usadescporlinhaprod = AlterarTipo<string>(leitor["Usadescporlinhaprod"]);
        _usadescporquant = AlterarTipo<string>(leitor["Usadescporquant"]);
        _usadtdesbloqueiobloqcliinativ = AlterarTipo<string>(leitor["Usadtdesbloqueiobloqcliinativ"]);
        _usadvproduto = AlterarTipo<string>(leitor["Usadvproduto"]);
        _usaestoquedepfechado = AlterarTipo<string>(leitor["Usaestoquedepfechado"]);
        _usafechamentocxcego = AlterarTipo<string>(leitor["Usafechamentocxcego"]);
        _usaicmsantecippvenda = AlterarTipo<string>(leitor["Usaicmsantecippvenda"]);
        _usalimcredcpf = AlterarTipo<string>(leitor["Usalimcredcpf"]);
        _usamapseprua = AlterarTipo<string>(leitor["Usamapseprua"]);
        _usamarcaprodutos = AlterarTipo<string>(leitor["Usamarcaprodutos"]);
        _usanegfornec = AlterarTipo<string>(leitor["Usanegfornec"]);
        _usanfcomplementarbk = AlterarTipo<string>(leitor["Usanfcomplementarbk"]);
        _usanumcarvendabalcao = AlterarTipo<string>(leitor["Usanumcarvendabalcao"]);
        _usanumnfdevcli = AlterarTipo<string>(leitor["Usanumnfdevcli"]);
        _usaoutrasmoedas = AlterarTipo<string>(leitor["Usaoutrasmoedas"]);
        _usapercdifqtent = AlterarTipo<string>(leitor["Usapercdifqtent"]);
        _usapiscofinsporfilial = AlterarTipo<string>(leitor["Usapiscofinsporfilial"]);
        _usapoliticadesenha = AlterarTipo<string>(leitor["Usapoliticadesenha"]);
        _usaposicaocpagar = AlterarTipo<string>(leitor["Usaposicaocpagar"]);
        _usaprecifmenormargemm = AlterarTipo<string>(leitor["Usaprecifmenormargemm"]);
        _usaprodfracunitario = AlterarTipo<string>(leitor["Usaprodfracunitario"]);
        _usaprzadicionalvenda = AlterarTipo<string>(leitor["Usaprzadicionalvenda"]);
        _usaptabelacomobase = AlterarTipo<string>(leitor["Usaptabelacomobase"]);
        _usardescontovendacodbarra = AlterarTipo<string>(leitor["Usardescontovendacodbarra"]);
        _usareducaocomissaorca = AlterarTipo<string>(leitor["Usareducaocomissaorca"]);
        _usarenderfornec = AlterarTipo<string>(leitor["Usarenderfornec"]);
        _usarmovimentahorizontal = AlterarTipo<string>(leitor["Usarmovimentahorizontal"]);
        _usarreducaoicmsabatransf = AlterarTipo<string>(leitor["Usarreducaoicmsabatransf"]);
        _usarsenhaexpirada = AlterarTipo<string>(leitor["Usarsenhaexpirada"]);
        _usartributacaotransftv10 = AlterarTipo<string>(leitor["Usartributacaotransftv10"]);
        _usasaldocontacorrentedescfin = AlterarTipo<string>(leitor["Usasaldocontacorrentedescfin"]);
        _usaseparacaocxfechada = AlterarTipo<string>(leitor["Usaseparacaocxfechada"]);
        _usatecladogertec = AlterarTipo<string>(leitor["Usatecladogertec"]);
        _usatribentporuf = AlterarTipo<string>(leitor["Usatribentporuf"]);
        _usatributacaoporuf = AlterarTipo<string>(leitor["Usatributacaoporuf"]);
        _usatrocacomprecovenda = AlterarTipo<string>(leitor["Usatrocacomprecovenda"]);
        _usavalormedioentrada = AlterarTipo<string>(leitor["Usavalormedioentrada"]);
        _usavendabalcaoclifilialvirtual = AlterarTipo<string>(leitor["Usavendabalcaoclifilialvirtual"]);
        _usavendedornatroca = AlterarTipo<string>(leitor["Usavendedornatroca"]);
        _usawms = AlterarTipo<string>(leitor["Usawms"]);
        _usuariologon = AlterarTipo<string>(leitor["Usuariologon"]);
        _utilizaautorcpagar = AlterarTipo<string>(leitor["Utilizaautorcpagar"]);
        _utilizaboletopreimpr = AlterarTipo<string>(leitor["Utilizaboletopreimpr"]);
        _utilizacheckout936 = AlterarTipo<string>(leitor["Utilizacheckout936"]);
        _utilizacontrolecaixa = AlterarTipo<string>(leitor["Utilizacontrolecaixa"]);
        _utilizacontrolelote = AlterarTipo<string>(leitor["Utilizacontrolelote"]);
        _utilizacontrolemedicamentos = AlterarTipo<string>(leitor["Utilizacontrolemedicamentos"]);
        _utilizaembmaster = AlterarTipo<string>(leitor["Utilizaembmaster"]);
        _utilizaendporfilial = AlterarTipo<string>(leitor["Utilizaendporfilial"]);
        _utilizafilialregiaocx = AlterarTipo<string>(leitor["Utilizafilialregiaocx"]);
        _utilizaguiaproprianfent = AlterarTipo<string>(leitor["Utilizaguiaproprianfent"]);
        _utilizaliberacaopedcompra = AlterarTipo<string>(leitor["Utilizaliberacaopedcompra"]);
        _utilizaorcvenda = AlterarTipo<string>(leitor["Utilizaorcvenda"]);
        _utilizapcusurfornec = AlterarTipo<string>(leitor["Utilizapcusurfornec"]);
        _utilizapercbaseredpf = AlterarTipo<string>(leitor["Utilizapercbaseredpf"]);
        _utilizapercfinprecoprom = AlterarTipo<string>(leitor["Utilizapercfinprecoprom"]);
        _utilizaqtfracionadaconf = AlterarTipo<string>(leitor["Utilizaqtfracionadaconf"]);
        _utilizarateiodespesas = AlterarTipo<string>(leitor["Utilizarateiodespesas"]);
        _utilizarembunitsintegra = AlterarTipo<string>(leitor["Utilizarembunitsintegra"]);
        _utilizavendaporembalagem = AlterarTipo<string>(leitor["Utilizavendaporembalagem"]);
        _validadvcodbarra = AlterarTipo<string>(leitor["Validadvcodbarra"]);
        _validaestoquemapasep = AlterarTipo<string>(leitor["Validaestoquemapasep"]);
        _validanumserieequipecf = AlterarTipo<string>(leitor["Validanumserieequipecf"]);
        _validaprecominimo = AlterarTipo<string>(leitor["Validaprecominimo"]);
        _validapvendabonific = AlterarTipo<string>(leitor["Validapvendabonific"]);
        _validarestoqueautoservico = AlterarTipo<string>(leitor["Validarestoqueautoservico"]);
        _validarestricoesvendaporrca = AlterarTipo<string>(leitor["Validarestricoesvendaporrca"]);
        _validarieconsumidorfinal = AlterarTipo<string>(leitor["Validarieconsumidorfinal"]);
        _validaruffilial = AlterarTipo<string>(leitor["Validaruffilial"]);
        _validarvlminvendaaposcorte = AlterarTipo<string>(leitor["Validarvlminvendaaposcorte"]);
        _validavlminvendabalcao = AlterarTipo<string>(leitor["Validavlminvendabalcao"]);
        _valor_frete_padrao = AlterarTipo<decimal?>(leitor["Valor_Frete_Padrao"]);
        _valormaxfaltacaixa = AlterarTipo<decimal?>(leitor["Valormaxfaltacaixa"]);
        _valorminimocsrf = AlterarTipo<decimal?>(leitor["Valorminimocsrf"]);
        _valorminimoinss = AlterarTipo<decimal?>(leitor["Valorminimoinss"]);
        _valorminimoirrf = AlterarTipo<decimal?>(leitor["Valorminimoirrf"]);
        _valorsangria1 = AlterarTipo<decimal?>(leitor["Valorsangria1"]);
        _valorsangria2 = AlterarTipo<decimal?>(leitor["Valorsangria2"]);
        _vercobrancabloqcli504_16_17 = AlterarTipo<string>(leitor["Vercobrancabloqcli504_16_17"]);
        _verificadatahoraecf = AlterarTipo<string>(leitor["Verificadatahoraecf"]);
        _verificadescfinbaixacm = AlterarTipo<string>(leitor["Verificadescfinbaixacm"]);
        _verificaestoquecont = AlterarTipo<string>(leitor["Verificaestoquecont"]);
        _verificalimcredcodcobd = AlterarTipo<string>(leitor["Verificalimcredcodcobd"]);
        _verificamargemlibpedido = AlterarTipo<string>(leitor["Verificamargemlibpedido"]);
        _verificanivelvenda402 = AlterarTipo<string>(leitor["Verificanivelvenda402"]);
        _verificapedbonificentnormal = AlterarTipo<string>(leitor["Verificapedbonificentnormal"]);
        _verificapesomaxpalete = AlterarTipo<string>(leitor["Verificapesomaxpalete"]);
        _verificapickingarm = AlterarTipo<string>(leitor["Verificapickingarm"]);
        _verificarclientesrede = AlterarTipo<string>(leitor["Verificarclientesrede"]);
        _verificarenderocupado = AlterarTipo<string>(leitor["Verificarenderocupado"]);
        _verificarlimvendapf = AlterarTipo<string>(leitor["Verificarlimvendapf"]);
        _verifpermissaocobrnodesdobr402 = AlterarTipo<string>(leitor["Verifpermissaocobrnodesdobr402"]);
        _verlanctobcochq = AlterarTipo<string>(leitor["Verlanctobcochq"]);
        _viasdanfe = AlterarTipo<decimal?>(leitor["Viasdanfe"]);
        _vlbloqchd3 = AlterarTipo<decimal?>(leitor["Vlbloqchd3"]);
        _vldiferenca = AlterarTipo<decimal?>(leitor["Vldiferenca"]);
        _vlmaxpedidopf = AlterarTipo<decimal?>(leitor["Vlmaxpedidopf"]);
        _vlmaxtarifabanc = AlterarTipo<decimal?>(leitor["Vlmaxtarifabanc"]);
        _vlmaxvenda = AlterarTipo<decimal?>(leitor["Vlmaxvenda"]);
        _vlmaxvendabnf = AlterarTipo<decimal?>(leitor["Vlmaxvendabnf"]);
        _vlmaxvendapf = AlterarTipo<decimal?>(leitor["Vlmaxvendapf"]);
        _vlmaxvendatlmkcodcobd = AlterarTipo<decimal?>(leitor["Vlmaxvendatlmkcodcobd"]);
        _vlmincanccupom = AlterarTipo<decimal?>(leitor["Vlmincanccupom"]);
        _vlmincancitemcupom = AlterarTipo<decimal?>(leitor["Vlmincancitemcupom"]);
        _vlmintarifabanc = AlterarTipo<decimal?>(leitor["Vlmintarifabanc"]);
        _vlminvenda = AlterarTipo<decimal?>(leitor["Vlminvenda"]);
        _vlminvendabk = AlterarTipo<decimal?>(leitor["Vlminvendabk"]);
        _vlminvendabnf = AlterarTipo<decimal?>(leitor["Vlminvendabnf"]);
        _vlminvendatv3 = AlterarTipo<decimal?>(leitor["Vlminvendatv3"]);
        _vlpaletedescarg = AlterarTipo<decimal?>(leitor["Vlpaletedescarg"]);
        _vlpesodescarga = AlterarTipo<decimal?>(leitor["Vlpesodescarga"]);
        _vlpesodescargapal = AlterarTipo<decimal?>(leitor["Vlpesodescargapal"]);
        _vlremontedescarga = AlterarTipo<decimal?>(leitor["Vlremontedescarga"]);
        _vltarifa = AlterarTipo<decimal?>(leitor["Vltarifa"]);
        _vlvoldescarga = AlterarTipo<decimal?>(leitor["Vlvoldescarga"]);
        _vlvolumedescargafd = AlterarTipo<decimal?>(leitor["Vlvolumedescargafd"]);
        _volumepalete = AlterarTipo<decimal?>(leitor["Volumepalete"]);
        _volumetransf = AlterarTipo<decimal?>(leitor["Volumetransf"]);
        _zeralimcredbloqautomatic = AlterarTipo<string>(leitor["Zeralimcredbloqautomatic"]);
    }

}