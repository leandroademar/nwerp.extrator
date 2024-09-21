

////// namespace nwErp.Entidades.Winthor;

// namespace nwErp.Api.Modelos;

[Serializable]
public class PCPRODUT : GerenteDePropriedades, IEntidade
{
    private static readonly string RO_ABASTEPALETE = "Abastepalete";

    private string _abastepalete;

    private static readonly string RO_ABASTEPALETECX = "Abastepaletecx";

    private string _abastepaletecx;

    private static readonly string RO_ACEITAVENDAFRACAO = "Aceitavendafracao";

    private string _aceitavendafracao;

    private static readonly string RO_ALIQAVULSADARE = "Aliqavulsadare";

    private decimal? _aliqavulsadare;

    private static readonly string RO_ALTURAARM = "Alturaarm";

    private decimal? _alturaarm;

    private static readonly string RO_ALTURAM3 = "Alturam3";

    private decimal? _alturam3;

    private static readonly string RO_ALTURAPAL = "Alturapal";

    private decimal? _alturapal;

    private static readonly string RO_ANALISEDESC = "Analisedesc";

    private string _analisedesc;

    private static readonly string RO_ANVISA = "Anvisa";

    private string _anvisa;

    private static readonly string RO_ANVISACAPINSTAL = "Anvisacapinstal";

    private decimal? _anvisacapinstal;

    private static readonly string RO_ANVISACLASTERAPEUTICA = "Anvisaclasterapeutica";

    private string _anvisaclasterapeutica;

    private static readonly string RO_ANVISACOEFTEC = "Anvisacoeftec";

    private string _anvisacoeftec;

    private static readonly string RO_ANVISACONCEN = "Anvisaconcen";

    private decimal? _anvisaconcen;

    private static readonly string RO_ANVISADESCPRINCAT1 = "Anvisadescprincat1";

    private string _anvisadescprincat1;

    private static readonly string RO_ANVISADESCPRINCAT2 = "Anvisadescprincat2";

    private string _anvisadescprincat2;

    private static readonly string RO_ANVISADESCPRINCAT3 = "Anvisadescprincat3";

    private string _anvisadescprincat3;

    private static readonly string RO_ANVISADESCPRINCAT4 = "Anvisadescprincat4";

    private string _anvisadescprincat4;

    private static readonly string RO_ANVISAFORMAFARM = "Anvisaformafarm";

    private string _anvisaformafarm;

    private static readonly string RO_ANVISANUMPRINCAT = "Anvisanumprincat";

    private decimal? _anvisanumprincat;

    private static readonly string RO_ANVISANUMREGMED = "Anvisanumregmed";

    private string _anvisanumregmed;

    private static readonly string RO_ANVISAQTEMBALAGEM = "Anvisaqtembalagem";

    private decimal? _anvisaqtembalagem;

    private static readonly string RO_ANVISAUNCOEFTEC = "Anvisauncoeftec";

    private string _anvisauncoeftec;

    private static readonly string RO_ANVISAUNDOSAG = "Anvisaundosag";

    private string _anvisaundosag;

    private static readonly string RO_ANVISAUSOCONTINUO = "Anvisausocontinuo";

    private string _anvisausocontinuo;

    private static readonly string RO_ANVISAVIAADM = "Anvisaviaadm";

    private string _anvisaviaadm;

    private static readonly string RO_APLICACOES = "Aplicacoes";

    private string _aplicacoes;

    private static readonly string RO_APLICPERCIVAPAUTA = "Aplicpercivapauta";

    private string _aplicpercivapauta;

    private static readonly string RO_APLICREDBASEIVAPLIQ = "Aplicredbaseivapliq";

    private string _aplicredbaseivapliq;

    private static readonly string RO_APLICREDBASEIVAPLIQBCR = "Aplicredbaseivapliqbcr";

    private string _aplicredbaseivapliqbcr;

    private static readonly string RO_APROVEITACREDICMS = "Aproveitacredicms";

    private string _aproveitacredicms;

    private static readonly string RO_APROVEITACREDPISCOFINS = "Aproveitacredpiscofins";

    private string _aproveitacredpiscofins;

    private static readonly string RO_APTO = "Apto";

    private decimal? _apto;

    private static readonly string RO_APTOCT = "Aptoct";

    private decimal? _aptoct;

    private static readonly string RO_APTOCX = "Aptocx";

    private decimal? _aptocx;

    private static readonly string RO_APTO2 = "Apto2";

    private decimal? _apto2;

    private static readonly string RO_ASSINATURA = "Assinatura";

    private string _assinatura;

    private static readonly string RO_ATUPESOMASTERENT = "Atupesomasterent";

    private string _atupesomasterent;

    private static readonly string RO_AUTORIZATIPO4 = "Autorizatipo4";

    private string _autorizatipo4;

    private static readonly string RO_BASEPISCOFINSLIT = "Basepiscofinslit";

    private decimal? _basepiscofinslit;

    private static readonly string RO_BASEPISCOFINSLITIMP = "Basepiscofinslitimp";

    private decimal? _basepiscofinslitimp;

    private static readonly string RO_BASEPISCOFINSLITRAGEM = "Basepiscofinslitragem";

    private decimal? _basepiscofinslitragem;

    private static readonly string RO_BOLORESLEVEDURAS = "Boloresleveduras";

    private string _boloresleveduras;

    private static readonly string RO_CALCCREDIPI = "Calccredipi";

    private string _calccredipi;

    private static readonly string RO_CAMAPAPAL = "Camapapal";

    private decimal? _camapapal;

    private static readonly string RO_CAMPANHA = "Campanha";

    private string _campanha;

    private static readonly string RO_CAPACIDADEPA = "Capacidadepa";

    private decimal? _capacidadepa;

    private static readonly string RO_CAPACIDADEPICKING = "Capacidadepicking";

    private decimal? _capacidadepicking;

    private static readonly string RO_CAPACIDADEPICKINGAL = "Capacidadepickingal";

    private decimal? _capacidadepickingal;

    private static readonly string RO_CAPACIDADEPICKINGCX = "Capacidadepickingcx";

    private decimal? _capacidadepickingcx;

    private static readonly string RO_CAPVOLDNF = "Capvoldnf";

    private decimal? _capvoldnf;

    private static readonly string RO_CATERGORIA = "Catergoria";

    private string _catergoria;

    private static readonly string RO_CESTABASICALEGIS = "Cestabasicalegis";

    private string _cestabasicalegis;

    private static readonly string RO_CHECARMULTIPLOVENDABNF = "Checarmultiplovendabnf";

    private string _checarmultiplovendabnf;

    private static readonly string RO_CLASSE = "Classe";

    private string _classe;

    private static readonly string RO_CLASSECOMISSAO = "Classecomissao";

    private string _classecomissao;

    private static readonly string RO_CLASSECOMPRA = "Classecompra";

    private string _classecompra;

    private static readonly string RO_CLASSEESTOQUE = "Classeestoque";

    private string _classeestoque;

    private static readonly string RO_CLASSEFLOW = "Classeflow";

    private string _classeflow;

    private static readonly string RO_CLASSEMC = "Classemc";

    private string _classemc;

    private static readonly string RO_CLASSEVENDA = "Classevenda";

    private string _classevenda;

    private static readonly string RO_CLASSIFICFISCAL = "Classificfiscal";

    private string _classificfiscal;

    private static readonly string RO_CODACONDICIONAMENTO = "Codacondicionamento";

    private string _codacondicionamento;

    private static readonly string RO_CODAGRUPMAPASEP = "Codagrupmapasep";

    private string _codagrupmapasep;

    private static readonly string RO_CODAUXILIAR = "Codauxiliar";

    private decimal? _codauxiliar;

    private static readonly string RO_CODAUXILIAR2 = "Codauxiliar2";

    private decimal? _codauxiliar2;

    private static readonly string RO_CODCARACPROD = "Codcaracprod";

    private decimal? _codcaracprod;

    private static readonly string RO_CODCATEGORIA = "Codcategoria";

    private decimal? _codcategoria;

    private static readonly string RO_CODCATEGORIAWEB = "Codcategoriaweb";

    private decimal? _codcategoriaweb;

    private static readonly string RO_CODCOR = "Codcor";

    private decimal? _codcor;

    private static readonly string RO_CODDEPTOWEB = "Coddeptoweb";

    private decimal? _coddeptoweb;

    private static readonly string RO_CODDISTRIB = "Coddistrib";

    private string _coddistrib;

    private static readonly string RO_CODENDERECOAL = "Codenderecoal";

    private decimal? _codenderecoal;

    private static readonly string RO_CODENDERECOAP = "Codenderecoap";

    private decimal? _codenderecoap;

    private static readonly string RO_CODENDERECOCX = "Codenderecocx";

    private decimal? _codenderecocx;

    private static readonly string RO_CODENDERECOPA = "Codenderecopa";

    private decimal? _codenderecopa;

    private static readonly string RO_CODEPTO = "Codepto";

    private decimal _codepto;

    private static readonly string RO_CODEQUIPE = "Codequipe";

    private decimal? _codequipe;

    private static readonly string RO_CODEXCECAOPISCOFINS = "Codexcecaopiscofins";

    private decimal? _codexcecaopiscofins;

    private static readonly string RO_CODFAB = "Codfab";

    private string _codfab;

    private static readonly string RO_CODFILIAL = "Codfilial";

    private string _codfilial;

    private static readonly string RO_CODFILIALPRODUTORA = "Codfilialprodutora";

    private string _codfilialprodutora;

    private static readonly string RO_CODFILIALRETIRA = "Codfilialretira";

    private string _codfilialretira;

    private static readonly string RO_CODFISCAL = "Codfiscal";

    private decimal? _codfiscal;

    private static readonly string RO_CODFISCALBONIFIC = "Codfiscalbonific";

    private decimal? _codfiscalbonific;

    private static readonly string RO_CODFISCALCONSIG = "Codfiscalconsig";

    private decimal? _codfiscalconsig;

    private static readonly string RO_CODFISCALCONSIGFAT = "Codfiscalconsigfat";

    private decimal? _codfiscalconsigfat;

    private static readonly string RO_CODFISCALDEVFORNEC = "Codfiscaldevfornec";

    private decimal? _codfiscaldevfornec;

    private static readonly string RO_CODFISCALENTTRANSF = "Codfiscalenttransf";

    private decimal? _codfiscalenttransf;

    private static readonly string RO_CODFISCALENTTV9 = "Codfiscalenttv9";

    private decimal? _codfiscalenttv9;

    private static readonly string RO_CODFISCALSR = "Codfiscalsr";

    private decimal? _codfiscalsr;

    private static readonly string RO_CODFORMATOPAPEL = "Codformatopapel";

    private decimal? _codformatopapel;

    private static readonly string RO_CODFORNEC = "Codfornec";

    private decimal _codfornec;

    private static readonly string RO_CODFUNCCADASTRO = "Codfunccadastro";

    private decimal? _codfunccadastro;

    private static readonly string RO_CODFUNCULTALTER = "Codfuncultalter";

    private decimal? _codfuncultalter;

    private static readonly string RO_CODGENEROFISCAL = "Codgenerofiscal";

    private decimal? _codgenerofiscal;

    private static readonly string RO_CODGRADE = "Codgrade";

    private decimal? _codgrade;

    private static readonly string RO_CODGRULIT = "Codgrulit";

    private string _codgrulit;

    private static readonly string RO_CODINFNUTRI = "Codinfnutri";

    private decimal? _codinfnutri;

    private static readonly string RO_CODINTERNO = "Codinterno";

    private string _codinterno;

    private static readonly string RO_CODLINHA = "Codlinha";

    private decimal? _codlinha;

    private static readonly string RO_CODLINHANESTLE = "Codlinhanestle";

    private decimal? _codlinhanestle;

    private static readonly string RO_CODLINHAPRAZO = "Codlinhaprazo";

    private decimal? _codlinhaprazo;

    private static readonly string RO_CODLINHAPROD = "Codlinhaprod";

    private decimal? _codlinhaprod;

    private static readonly string RO_CODMARCA = "Codmarca";

    private decimal? _codmarca;

    private static readonly string RO_CODNCMEX = "Codncmex";

    private string _codncmex;

    private static readonly string RO_CODNESTLETERCEIROS = "Codnestleterceiros";

    private string _codnestleterceiros;

    private static readonly string RO_CODONU = "Codonu";

    private string _codonu;

    private static readonly string RO_CODPASSEFISCAL = "Codpassefiscal";

    private decimal? _codpassefiscal;

    private static readonly string RO_CODPRAZOENT = "Codprazoent";

    private string _codprazoent;

    private static readonly string RO_CODPRINCIPATIVO = "Codprincipativo";

    private decimal? _codprincipativo;

    private static readonly string RO_CODPROD = "Codprod";

    private decimal _codprod;

    private static readonly string RO_CODPRODDNF = "Codproddnf";

    private decimal? _codproddnf;

    private static readonly string RO_CODPRODEMBALAGEM = "Codprodembalagem";

    private decimal? _codprodembalagem;

    private static readonly string RO_CODPRODMASTER = "Codprodmaster";

    private decimal? _codprodmaster;

    private static readonly string RO_CODPRODPRINC = "Codprodprinc";

    private decimal? _codprodprinc;

    private static readonly string RO_CODPRODRELEV = "Codprodrelev";

    private decimal? _codprodrelev;

    private static readonly string RO_CODPRODSIMILAR = "Codprodsimilar";

    private decimal? _codprodsimilar;

    private static readonly string RO_CODPRODSINTEGRA = "Codprodsintegra";

    private string _codprodsintegra;

    private static readonly string RO_CODRISCO = "Codrisco";

    private string _codrisco;

    private static readonly string RO_CODROTINAULTALTER = "Codrotinaultalter";

    private decimal? _codrotinaultalter;

    private static readonly string RO_CODSEC = "Codsec";

    private decimal _codsec;

    private static readonly string RO_CODSECAOWEB = "Codsecaoweb";

    private decimal? _codsecaoweb;

    private static readonly string RO_CODSITTRIBPISCOFINS = "Codsittribpiscofins";

    private decimal? _codsittribpiscofins;

    private static readonly string RO_CODSITTRIBPISCOFINSDEV = "Codsittribpiscofinsdev";

    private decimal? _codsittribpiscofinsdev;

    private static readonly string RO_CODSUBCATEGORIA = "Codsubcategoria";

    private decimal? _codsubcategoria;

    private static readonly string RO_CODSUBCATEGORIAWEB = "Codsubcategoriaweb";

    private decimal? _codsubcategoriaweb;

    private static readonly string RO_CODTABLIT = "Codtablit";

    private string _codtablit;

    private static readonly string RO_CODTIPOESTRUTURA = "Codtipoestrutura";

    private decimal? _codtipoestrutura;

    private static readonly string RO_CODTIPOESTRUTURAPUL = "Codtipoestruturapul";

    private decimal? _codtipoestruturapul;

    private static readonly string RO_CODTRIBPISCOFINS = "Codtribpiscofins";

    private decimal? _codtribpiscofins;

    private static readonly string RO_CODUNIDMEDIDANF = "Codunidmedidanf";

    private decimal? _codunidmedidanf;

    private static readonly string RO_CODUSUULTALTCOM = "Codusuultaltcom";

    private decimal? _codusuultaltcom;

    private static readonly string RO_CODVASILHAME = "Codvasilhame";

    private decimal? _codvasilhame;

    private static readonly string RO_COFINSRETIDO = "Cofinsretido";

    private decimal? _cofinsretido;

    private static readonly string RO_COLUNAGRADE = "Colunagrade";

    private decimal? _colunagrade;

    private static readonly string RO_COL95 = "Col95";

    private string _col95;

    private static readonly string RO_COMISSAOFIXA = "Comissaofixa";

    private string _comissaofixa;

    private static readonly string RO_COMISSAOPORLUCRATIVIDADE = "Comissaoporlucratividade";

    private string _comissaoporlucratividade;

    private static readonly string RO_COMPRACONSIGNADO = "Compraconsignado";

    private string _compraconsignado;

    private static readonly string RO_COMPRIMENTOARM = "Comprimentoarm";

    private decimal? _comprimentoarm;

    private static readonly string RO_COMPRIMENTOM3 = "Comprimentom3";

    private decimal? _comprimentom3;

    private static readonly string RO_CONCENTRACAO = "Concentracao";

    private decimal? _concentracao;

    private static readonly string RO_CONCILIAIMPORTACAO = "Conciliaimportacao";

    private string _conciliaimportacao;

    private static readonly string RO_CONFAZ = "Confaz";

    private string _confaz;

    private static readonly string RO_CONFERENOCHECKOUT = "Conferenocheckout";

    private string _conferenocheckout;

    private static readonly string RO_CONSIDERARICMSANTECIPCUSTO = "Consideraricmsantecipcusto";

    private string _consideraricmsantecipcusto;

    private static readonly string RO_CONTLOGANALISE = "Contloganalise";

    private decimal? _contloganalise;

    private static readonly string RO_CONTMICROBIANA = "Contmicrobiana";

    private string _contmicrobiana;

    private static readonly string RO_CONTROLADOIBAMA = "Controladoibama";

    private string _controladoibama;

    private static readonly string RO_CONTROLANUMSERIA = "Controlanumseria";

    private string _controlanumseria;

    private static readonly string RO_CONTROLANUMSERIE = "Controlanumserie";

    private string _controlanumserie;

    private static readonly string RO_CONTROLAPATRIMONIO = "Controlapatrimonio";

    private string _controlapatrimonio;

    private static readonly string RO_CONTROLAVALIDADEDOLOTE = "Controlavalidadedolote";

    private string _controlavalidadedolote;

    private static readonly string RO_CORREDOR = "Corredor";

    private string _corredor;

    private static readonly string RO_CSLLRETIDO = "Csllretido";

    private decimal? _csllretido;

    private static readonly string RO_CUSTOFORNEC = "Custofornec";

    private decimal? _custofornec;

    private static readonly string RO_CUSTOPROXIMACOMPRA = "Custoproximacompra";

    private decimal? _custoproximacompra;

    private static readonly string RO_CUSTOREP = "Custorep";

    private decimal? _custorep;

    private static readonly string RO_CUSTOREPANT = "Custorepant";

    private decimal? _custorepant;

    private static readonly string RO_CUSTOREPMC = "Custorepmc";

    private decimal? _custorepmc;

    private static readonly string RO_CUSTOREPTAB = "Custoreptab";

    private decimal? _custoreptab;

    private static readonly string RO_CUSTOREPTABANT = "Custoreptabant";

    private decimal? _custoreptabant;

    private static readonly string RO_CUSTOREPZFM = "Custorepzfm";

    private decimal? _custorepzfm;

    private static readonly string RO_CUSTOREPZFMANT = "Custorepzfmant";

    private decimal? _custorepzfmant;

    private static readonly string RO_CUSTOREPZFMTAB = "Custorepzfmtab";

    private decimal? _custorepzfmtab;

    private static readonly string RO_DADOSTECNICOS = "Dadostecnicos";

    private string _dadostecnicos;

    private static readonly string RO_DATAVOCOLLECT = "Datavocollect";

    private DateTime? _datavocollect;

    private static readonly string RO_DENOMINACAOCOMUNBRASILEIRA = "Denominacaocomunbrasileira";

    private string _denominacaocomunbrasileira;

    private static readonly string RO_DENSIDADE = "Densidade";

    private string _densidade;

    private static readonly string RO_DEPOSITO = "Deposito";

    private decimal? _deposito;

    private static readonly string RO_DEPOSITOCX = "Depositocx";

    private decimal? _depositocx;

    private static readonly string RO_DESCPAPEL = "Descpapel";

    private string _descpapel;

    private static readonly string RO_DESCRICAO = "Descricao";

    private string _descricao;

    private static readonly string RO_DESCRICAO1 = "Descricao1";

    private string _descricao1;

    private static readonly string RO_DESCRICAO2 = "Descricao2";

    private string _descricao2;

    private static readonly string RO_DESCRICAO3 = "Descricao3";

    private string _descricao3;

    private static readonly string RO_DESCRICAO4 = "Descricao4";

    private string _descricao4;

    private static readonly string RO_DESCRICAO5 = "Descricao5";

    private string _descricao5;

    private static readonly string RO_DESCRICAO6 = "Descricao6";

    private string _descricao6;

    private static readonly string RO_DESCRICAO7 = "Descricao7";

    private string _descricao7;

    private static readonly string RO_DESINTEGRACAO = "Desintegracao";

    private string _desintegracao;

    private static readonly string RO_DESTAQUEFICHATECNICA = "Destaquefichatecnica";

    private string _destaquefichatecnica;

    private static readonly string RO_DIRASSINATURA = "Dirassinatura";

    private string _dirassinatura;

    private static readonly string RO_DIRETORIOFOTOS = "Diretoriofotos";

    private string _diretoriofotos;

    private static readonly string RO_DIRFOTOPROD = "Dirfotoprod";

    private string _dirfotoprod;

    private static readonly string RO_DISSOLUCAO = "Dissolucao";

    private string _dissolucao;

    private static readonly string RO_DOSEAMENTO = "Doseamento";

    private string _doseamento;

    private static readonly string RO_DTALTCUSTOFORNEC = "Dtaltcustofornec";

    private DateTime? _dtaltcustofornec;

    private static readonly string RO_DTCADASTRO = "Dtcadastro";

    private DateTime? _dtcadastro;

    private static readonly string RO_DTDOLAR = "Dtdolar";

    private string _dtdolar;

    private static readonly string RO_DTEXCLUSAO = "Dtexclusao";

    private DateTime? _dtexclusao;

    private static readonly string RO_DTEXPORTACAOWMS = "Dtexportacaowms";

    private DateTime? _dtexportacaowms;

    private static readonly string RO_DTIMPORTACAOWMS = "Dtimportacaowms";

    private DateTime? _dtimportacaowms;

    private static readonly string RO_DTIMPORTINTEGRACAO = "Dtimportintegracao";

    private DateTime? _dtimportintegracao;

    private static readonly string RO_DTINICONTLOTE = "Dtinicontlote";

    private DateTime? _dtinicontlote;

    private static readonly string RO_DTPROXEXPURGO = "Dtproxexpurgo";

    private DateTime? _dtproxexpurgo;

    private static readonly string RO_DTULTALTCOM = "Dtultaltcom";

    private DateTime? _dtultaltcom;

    private static readonly string RO_DTULTALTCUSTOREP = "Dtultaltcustorep";

    private DateTime? _dtultaltcustorep;

    private static readonly string RO_DTULTALTER = "Dtultalter";

    private DateTime? _dtultalter;

    private static readonly string RO_DTULTALTERSRVPRC = "Dtultaltersrvprc";

    private DateTime? _dtultaltersrvprc;

    private static readonly string RO_DTULTEXPURGO = "Dtultexpurgo";

    private DateTime? _dtultexpurgo;

    private static readonly string RO_DTVENC = "Dtvenc";

    private DateTime? _dtvenc;

    private static readonly string RO_DV = "Dv";

    private decimal? _dv;

    private static readonly string RO_EFICIENCIAOPERACIONAL = "Eficienciaoperacional";

    private decimal? _eficienciaoperacional;

    private static readonly string RO_EMBALAGEM = "Embalagem";

    private string _embalagem;

    private static readonly string RO_EMBALAGEMCT = "Embalagemct";

    private string _embalagemct;

    private static readonly string RO_EMBALAGEMMASTER = "Embalagemmaster";

    private string _embalagemmaster;

    private static readonly string RO_ENVIAINFTECNICANFE = "Enviainftecnicanfe";

    private string _enviainftecnicanfe;

    private static readonly string RO_ENVIARFORCAVENDAS = "Enviarforcavendas";

    private string _enviarforcavendas;

    private static readonly string RO_ENVIASNGPC = "Enviasngpc";

    private string _enviasngpc;

    private static readonly string RO_ESPECIFICOATIVIDADEPR = "Especificoatividadepr";

    private string _especificoatividadepr;

    private static readonly string RO_ESTFAUREAUS = "Estfaureaus";

    private string _estfaureaus;

    private static readonly string RO_ESTOQUEPORLOTE = "Estoqueporlote";

    private string _estoqueporlote;

    private static readonly string RO_EX_ANALISEDESC = "Ex_Analisedesc";

    private string _ex_analisedesc;

    private static readonly string RO_EX_BOLORESLEVEDURAS = "Ex_Boloresleveduras";

    private string _ex_boloresleveduras;

    private static readonly string RO_EX_COL95 = "Ex_Col95";

    private string _ex_col95;

    private static readonly string RO_EX_CONTMICROBIANA = "Ex_Contmicrobiana";

    private string _ex_contmicrobiana;

    private static readonly string RO_EX_DENSIDADE = "Ex_Densidade";

    private string _ex_densidade;

    private static readonly string RO_EX_DESINTEGRACAO = "Ex_Desintegracao";

    private string _ex_desintegracao;

    private static readonly string RO_EX_DISSOLUCAO = "Ex_Dissolucao";

    private string _ex_dissolucao;

    private static readonly string RO_EX_DOSEAMENTO = "Ex_Doseamento";

    private string _ex_doseamento;

    private static readonly string RO_EX_ESTFAUREAUS = "Ex_Estfaureaus";

    private string _ex_estfaureaus;

    private static readonly string RO_EX_FRIABILIDADE = "Ex_Friabilidade";

    private string _ex_friabilidade;

    private static readonly string RO_EX_IDENTIFICACAO = "Ex_Identificacao";

    private string _ex_identificacao;

    private static readonly string RO_EX_IMPUREZA = "Ex_Impureza";

    private string _ex_impureza;

    private static readonly string RO_EX_LIPIDEO = "Ex_Lipideo";

    private string _ex_lipideo;

    private static readonly string RO_EX_MOFADO = "Ex_Mofado";

    private string _ex_mofado;

    private static readonly string RO_EX_PESQPATOGENOS = "Ex_Pesqpatogenos";

    private string _ex_pesqpatogenos;

    private static readonly string RO_EX_PH = "Ex_Ph";

    private string _ex_ph;

    private static readonly string RO_EXPORTABALANCA = "Exportabalanca";

    private string _exportabalanca;

    private static readonly string RO_EX_PROTEINA = "Ex_Proteina";

    private string _ex_proteina;

    private static readonly string RO_EX_SALMONELA = "Ex_Salmonela";

    private string _ex_salmonela;

    private static readonly string RO_EXTIPI = "Extipi";

    private string _extipi;

    private static readonly string RO_EX_TOTDEFEITO = "Ex_Totdefeito";

    private string _ex_totdefeito;

    private static readonly string RO_EX_UMIDADE = "Ex_Umidade";

    private string _ex_umidade;

    private static readonly string RO_EX_UNIFORMIDADE = "Ex_Uniformidade";

    private string _ex_uniformidade;

    private static readonly string RO_EX_VLCALORICO = "Ex_Vlcalorico";

    private string _ex_vlcalorico;

    private static readonly string RO_EX_VOLPESMED = "Ex_Volpesmed";

    private string _ex_volpesmed;

    private static readonly string RO_FATORCONVDNF = "Fatorconvdnf";

    private decimal? _fatorconvdnf;

    private static readonly string RO_FATORCONVERSAOKG = "Fatorconversaokg";

    private decimal? _fatorconversaokg;

    private static readonly string RO_FATORCONVERSAONESTLE = "Fatorconversaonestle";

    private decimal? _fatorconversaonestle;

    private static readonly string RO_FATORTRANSF = "Fatortransf";

    private decimal? _fatortransf;

    private static readonly string RO_FATORUNFARM = "Fatorunfarm";

    private decimal? _fatorunfarm;

    private static readonly string RO_FLAGS = "Flags";

    private string _flags;

    private static readonly string RO_FLAG0 = "Flag0";

    private string _flag0;

    private static readonly string RO_FLAG1 = "Flag1";

    private string _flag1;

    private static readonly string RO_FLAG2 = "Flag2";

    private string _flag2;

    private static readonly string RO_FOLHAROSTO = "Folharosto";

    private string _folharosto;

    private static readonly string RO_FRACAOCIPA = "Fracaocipa";

    private decimal? _fracaocipa;

    private static readonly string RO_FRACAOSEPARACAO = "Fracaoseparacao";

    private decimal? _fracaoseparacao;

    private static readonly string RO_FRACIONADO = "Fracionado";

    private string _fracionado;

    private static readonly string RO_FRETEESPECIAL = "Freteespecial";

    private string _freteespecial;

    private static readonly string RO_FRIABILIDADE = "Friabilidade";

    private string _friabilidade;

    private static readonly string RO_FUNDAPIANO = "Fundapiano";

    private string _fundapiano;

    private static readonly string RO_GERAICMSLIVROFISCALDEVFORNEC = "Geraicmslivrofiscaldevfornec";

    private string _geraicmslivrofiscaldevfornec;

    private static readonly string RO_GERAOSAUTOMATIC = "Geraosautomatic";

    private string _geraosautomatic;

    private static readonly string RO_GRAMATURA = "Gramatura";

    private decimal? _gramatura;

    private static readonly string RO_GRUPOFATURAMENTO = "Grupofaturamento";

    private string _grupofaturamento;

    private static readonly string RO_GTINCODAUXILIAR = "Gtincodauxiliar";

    private decimal? _gtincodauxiliar;

    private static readonly string RO_GTINCODAUXILIAR2 = "Gtincodauxiliar2";

    private decimal? _gtincodauxiliar2;

    private static readonly string RO_ICMSRESSARC = "Icmsressarc";

    private decimal? _icmsressarc;

    private static readonly string RO_IDENTIFICACAO = "Identificacao";

    private string _identificacao;

    private static readonly string RO_IMPORTADO = "Importado";

    private string _importado;

    private static readonly string RO_IMPUREZA = "Impureza";

    private string _impureza;

    private static readonly string RO_IMUNETRIB = "Imunetrib";

    private string _imunetrib;

    private static readonly string RO_INFORMACOESTECNICAS = "Informacoestecnicas";

    private string _informacoestecnicas;

    private static readonly string RO_INVENTARIOPARCIAL = "Inventarioparcial";

    private string _inventarioparcial;

    private static readonly string RO_IPIPORVALOR = "Ipiporvalor";

    private string _ipiporvalor;

    private static readonly string RO_IRRETIDO = "Irretido";

    private decimal? _irretido;

    private static readonly string RO_ISENTOREGMS = "Isentoregms";

    private string _isentoregms;

    private static readonly string RO_IVARESSARC = "Ivaressarc";

    private decimal? _ivaressarc;

    private static readonly string RO_LARGURAARM = "Larguraarm";

    private decimal? _larguraarm;

    private static readonly string RO_LARGURAM3 = "Larguram3";

    private decimal? _larguram3;

    private static readonly string RO_LASTROPAL = "Lastropal";

    private decimal? _lastropal;

    private static readonly string RO_LETRAPAGINA = "Letrapagina";

    private string _letrapagina;

    private static readonly string RO_LINHAPROD = "Linhaprod";

    private decimal? _linhaprod;

    private static readonly string RO_LIPIDEO = "Lipideo";

    private string _lipideo;

    private static readonly string RO_LITRAGEM = "Litragem";

    private decimal? _litragem;

    private static readonly string RO_LOTEINCCOMPRA = "Loteinccompra";

    private decimal? _loteinccompra;

    private static readonly string RO_LOTEMINCOMPRA = "Lotemincompra";

    private decimal? _lotemincompra;

    private static readonly string RO_LOTEPRODUCAO = "Loteproducao";

    private decimal? _loteproducao;

    private static readonly string RO_MARCA = "Marca";

    private string _marca;

    private static readonly string RO_MARGEMMIN = "Margemmin";

    private decimal? _margemmin;

    private static readonly string RO_MEDCODFUNCLIBVENDA = "Medcodfunclibvenda";

    private decimal? _medcodfunclibvenda;

    private static readonly string RO_MEDDTLIBVENDA = "Meddtlibvenda";

    private DateTime? _meddtlibvenda;

    private static readonly string RO_MEDICAMENTOHOSPITALAR = "Medicamentohospitalar";

    private string _medicamentohospitalar;

    private static readonly string RO_MEXFPGC = "Mexfpgc";

    private decimal? _mexfpgc;

    private static readonly string RO_MEXIEPS = "Mexieps";

    private decimal? _mexieps;

    private static readonly string RO_MEXIVA = "Mexiva";

    private decimal? _mexiva;

    private static readonly string RO_MODULO = "Modulo";

    private decimal? _modulo;

    private static readonly string RO_MODULOCT = "Moduloct";

    private decimal? _moduloct;

    private static readonly string RO_MODULOCX = "Modulocx";

    private decimal? _modulocx;

    private static readonly string RO_MODULO2 = "Modulo2";

    private decimal? _modulo2;

    private static readonly string RO_MOEDA = "Moeda";

    private string _moeda;

    private static readonly string RO_MOFADO = "Mofado";

    private string _mofado;

    private static readonly string RO_MULTIPLO = "Multiplo";

    private decimal? _multiplo;

    private static readonly string RO_MULTIPLO2 = "Multiplo2";

    private decimal? _multiplo2;

    private static readonly string RO_NATUREZAPRODUTO = "Naturezaproduto";

    private string _naturezaproduto;

    private static readonly string RO_NBM = "Nbm";

    private string _nbm;

    private static readonly string RO_NIVEL = "Nivel";

    private decimal? _nivel;

    private static readonly string RO_NIVELCX = "Nivelcx";

    private decimal? _nivelcx;

    private static readonly string RO_NOMECOMERCIAL = "Nomecomercial";

    private string _nomecomercial;

    private static readonly string RO_NOMEECOMMERCE = "Nomeecommerce";

    private string _nomeecommerce;

    private static readonly string RO_NORMAFORNECEDOR = "Normafornecedor";

    private string _normafornecedor;

    private static readonly string RO_NORMAPALETE = "Normapalete";

    private decimal? _normapalete;

    private static readonly string RO_NUMCASASDECREDUCAOICMS = "Numcasasdecreducaoicms";

    private decimal? _numcasasdecreducaoicms;

    private static readonly string RO_NUMDIASMAXVENDA = "Numdiasmaxvenda";

    private decimal? _numdiasmaxvenda;

    private static readonly string RO_NUMDIASVALIDADEMIN = "Numdiasvalidademin";

    private decimal? _numdiasvalidademin;

    private static readonly string RO_NUMERO = "Numero";

    private decimal? _numero;

    private static readonly string RO_NUMEROCT = "Numeroct";

    private decimal? _numeroct;

    private static readonly string RO_NUMEROCX = "Numerocx";

    private decimal? _numerocx;

    private static readonly string RO_NUMERO2 = "Numero2";

    private decimal? _numero2;

    private static readonly string RO_NUMLISTAINVENTROT = "Numlistainventrot";

    private decimal? _numlistainventrot;

    private static readonly string RO_NUMLOTE = "Numlote";

    private string _numlote;

    private static readonly string RO_NUMORIGINAL = "Numoriginal";

    private string _numoriginal;

    private static readonly string RO_NUMPAG = "Numpag";

    private decimal? _numpag;

    private static readonly string RO_NUMSEQATU = "Numseqatu";

    private decimal? _numseqatu;

    private static readonly string RO_NUMSEQINVENTROT = "Numseqinventrot";

    private decimal? _numseqinventrot;

    private static readonly string RO_NUMSERVICO = "Numservico";

    private decimal? _numservico;

    private static readonly string RO_NUMULTEXPURGO = "Numultexpurgo";

    private decimal? _numultexpurgo;

    private static readonly string RO_OBRIGAPREENCCONTRATO = "Obrigapreenccontrato";

    private string _obrigapreenccontrato;

    private static readonly string RO_OBS = "Obs";

    private string _obs;

    private static readonly string RO_OBS2 = "Obs2";

    private string _obs2;

    private static readonly string RO_OSCOMODATO = "Oscomodato";

    private string _oscomodato;

    private static readonly string RO_PAISORIGEM = "Paisorigem";

    private string _paisorigem;

    private static readonly string RO_PASSELIVRE = "Passelivre";

    private string _passelivre;

    private static readonly string RO_PCKROTATIVO = "Pckrotativo";

    private string _pckrotativo;

    private static readonly string RO_PCOMEXT1 = "Pcomext1";

    private decimal? _pcomext1;

    private static readonly string RO_PCOMINT1 = "Pcomint1";

    private decimal? _pcomint1;

    private static readonly string RO_PCOMPROF1 = "Pcomprof1";

    private decimal? _pcomprof1;

    private static readonly string RO_PCOMREP1 = "Pcomrep1";

    private decimal? _pcomrep1;

    private static readonly string RO_PCOMTLMKT = "Pcomtlmkt";

    private decimal? _pcomtlmkt;

    private static readonly string RO_PERCACRES = "Percacres";

    private decimal? _percacres;

    private static readonly string RO_PERCALIQCREDICMSDIFEREST = "Percaliqcredicmsdiferest";

    private decimal? _percaliqcredicmsdiferest;

    private static readonly string RO_PERCALIQCREDICMSDIFERINTER = "Percaliqcredicmsdiferinter";

    private decimal? _percaliqcredicmsdiferinter;

    private static readonly string RO_PERCALIQEXT = "Percaliqext";

    private decimal? _percaliqext;

    private static readonly string RO_PERCALIQEXTBCR = "Percaliqextbcr";

    private decimal? _percaliqextbcr;

    private static readonly string RO_PERCALIQEXTGUIA = "Percaliqextguia";

    private decimal? _percaliqextguia;

    private static readonly string RO_PERCALIQEXTICMANTECIP = "Percaliqexticmantecip";

    private decimal? _percaliqexticmantecip;

    private static readonly string RO_PERCALIQINT = "Percaliqint";

    private decimal? _percaliqint;

    private static readonly string RO_PERCALIQINTBCR = "Percaliqintbcr";

    private decimal? _percaliqintbcr;

    private static readonly string RO_PERCALIQINTICMANTECIP = "Percaliqinticmantecip";

    private decimal? _percaliqinticmantecip;

    private static readonly string RO_PERCBASEREDENT = "Percbaseredent";

    private decimal? _percbaseredent;

    private static readonly string RO_PERCBON = "Percbon";

    private decimal? _percbon;

    private static readonly string RO_PERCBONIFICVENDA = "Percbonificvenda";

    private decimal? _percbonificvenda;

    private static readonly string RO_PERCBONOUTRAS = "Percbonoutras";

    private decimal? _percbonoutras;

    private static readonly string RO_PERCCARGATRIBMEDIA = "Perccargatribmedia";

    private decimal? _perccargatribmedia;

    private static readonly string RO_PERCCOMMOT = "Perccommot";

    private decimal? _perccommot;

    private static readonly string RO_PERCCREDICMPRESUMIDO = "Perccredicmpresumido";

    private decimal? _perccredicmpresumido;

    private static readonly string RO_PERCDESC = "Percdesc";

    private decimal? _percdesc;

    private static readonly string RO_PERCDESCICMS = "Percdescicms";

    private decimal? _percdescicms;

    private static readonly string RO_PERCDESCICMSDIF = "Percdescicmsdif";

    private decimal? _percdescicmsdif;

    private static readonly string RO_PERCDESC1 = "Percdesc1";

    private decimal? _percdesc1;

    private static readonly string RO_PERCDESC10 = "Percdesc10";

    private decimal? _percdesc10;

    private static readonly string RO_PERCDESC2 = "Percdesc2";

    private decimal? _percdesc2;

    private static readonly string RO_PERCDESC3 = "Percdesc3";

    private decimal? _percdesc3;

    private static readonly string RO_PERCDESC4 = "Percdesc4";

    private decimal? _percdesc4;

    private static readonly string RO_PERCDESC5 = "Percdesc5";

    private decimal? _percdesc5;

    private static readonly string RO_PERCDESC6 = "Percdesc6";

    private decimal? _percdesc6;

    private static readonly string RO_PERCDESC7 = "Percdesc7";

    private decimal? _percdesc7;

    private static readonly string RO_PERCDESC8 = "Percdesc8";

    private decimal? _percdesc8;

    private static readonly string RO_PERCDESC9 = "Percdesc9";

    private decimal? _percdesc9;

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

    private static readonly string RO_PERCDIFERENCAKGFRIO = "Percdiferencakgfrio";

    private decimal? _percdiferencakgfrio;

    private static readonly string RO_PERCFRETE = "Percfrete";

    private decimal? _percfrete;

    private static readonly string RO_PERCFRETEFOB = "Percfretefob";

    private decimal? _percfretefob;

    private static readonly string RO_PERCICMRED = "Percicmred";

    private decimal? _percicmred;

    private static readonly string RO_PERCICMSDIFERIDO = "Percicmsdiferido";

    private decimal? _percicmsdiferido;

    private static readonly string RO_PERCICMSFRETEFOBST = "Percicmsfretefobst";

    private decimal? _percicmsfretefobst;

    private static readonly string RO_PERCICMSFRETEFOBSTBCR = "Percicmsfretefobstbcr";

    private decimal? _percicmsfretefobstbcr;

    private static readonly string RO_PERCIMPORTACAO = "Percimportacao";

    private decimal? _percimportacao;

    private static readonly string RO_PERCIMPPRODUTORURAL = "Percimpprodutorural";

    private decimal? _percimpprodutorural;

    private static readonly string RO_PERCIPI = "Percipi";

    private decimal? _percipi;

    private static readonly string RO_PERCIPIVENDA = "Percipivenda";

    private decimal? _percipivenda;

    private static readonly string RO_PERCIPIVENDATAB = "Percipivendatab";

    private decimal? _percipivendatab;

    private static readonly string RO_PERCIVA = "Perciva";

    private decimal? _perciva;

    private static readonly string RO_PERCIVABCR = "Percivabcr";

    private decimal? _percivabcr;

    private static readonly string RO_PERCIVAICMANTECIP = "Percivaicmantecip";

    private decimal? _percivaicmantecip;

    private static readonly string RO_PERCMVAORIG = "Percmvaorig";

    private decimal? _percmvaorig;

    private static readonly string RO_PERCOFINS = "Percofins";

    private decimal? _percofins;

    private static readonly string RO_PERCOFINSIMP = "Percofinsimp";

    private decimal? _percofinsimp;

    private static readonly string RO_PERCOUTRASDESP = "Percoutrasdesp";

    private decimal? _percoutrasdesp;

    private static readonly string RO_PERCPERDAKG = "Percperdakg";

    private decimal? _percperdakg;

    private static readonly string RO_PERCQUEBRAPRODUCAO = "Percquebraproducao";

    private decimal? _percquebraproducao;

    private static readonly string RO_PERCREDICMS = "Percredicms";

    private decimal? _percredicms;

    private static readonly string RO_PERCREDPMC = "Percredpmc";

    private decimal? _percredpmc;

    private static readonly string RO_PERCSEGURO = "Percseguro";

    private decimal? _percseguro;

    private static readonly string RO_PERCST = "Percst";

    private decimal? _percst;

    private static readonly string RO_PERCSUFRAMA = "Percsuframa";

    private decimal? _percsuframa;

    private static readonly string RO_PERCTOLERANCIAVAL = "Perctoleranciaval";

    private decimal? _perctoleranciaval;

    private static readonly string RO_PERCVENDA = "Percvenda";

    private decimal? _percvenda;

    private static readonly string RO_PERICM = "Pericm";

    private decimal? _pericm;

    private static readonly string RO_PERICMFRETE = "Pericmfrete";

    private decimal? _pericmfrete;

    private static readonly string RO_PERICMSANTECIPADO = "Pericmsantecipado";

    private decimal? _pericmsantecipado;

    private static readonly string RO_PERINDENIZ = "Perindeniz";

    private decimal? _perindeniz;

    private static readonly string RO_PERMITEPRODUCAO = "Permiteproducao";

    private string _permiteproducao;

    private static readonly string RO_PERPIS = "Perpis";

    private decimal? _perpis;

    private static readonly string RO_PERPISIMP = "Perpisimp";

    private decimal? _perpisimp;

    private static readonly string RO_PESOBRUTO = "Pesobruto";

    private decimal? _pesobruto;

    private static readonly string RO_PESOBRUTOMASTER = "Pesobrutomaster";

    private decimal? _pesobrutomaster;

    private static readonly string RO_PESOEMBALAGEM = "Pesoembalagem";

    private decimal? _pesoembalagem;

    private static readonly string RO_PESOLIQ = "Pesoliq";

    private decimal? _pesoliq;

    private static readonly string RO_PESOLIQMASTER = "Pesoliqmaster";

    private decimal? _pesoliqmaster;

    private static readonly string RO_PESOPALETE = "Pesopalete";

    private decimal? _pesopalete;

    private static readonly string RO_PESOPECA = "Pesopeca";

    private decimal? _pesopeca;

    private static readonly string RO_PESOVARIAVEL = "Pesovariavel";

    private string _pesovariavel;

    private static readonly string RO_PESQPATOGENOS = "Pesqpatogenos";

    private string _pesqpatogenos;

    private static readonly string RO_PH = "Ph";

    private string _ph;

    private static readonly string RO_PISCOFINSRETIDO = "Piscofinsretido";

    private string _piscofinsretido;

    private static readonly string RO_PISRETIDO = "Pisretido";

    private decimal? _pisretido;

    private static readonly string RO_PONTOREPOSICAO = "Pontoreposicao";

    private decimal? _pontoreposicao;

    private static readonly string RO_PONTOREPOSICAOAL = "Pontoreposicaoal";

    private decimal? _pontoreposicaoal;

    private static readonly string RO_PONTOREPOSICAOCX = "Pontoreposicaocx";

    private decimal? _pontoreposicaocx;

    private static readonly string RO_PONTOREPOSICAOPA = "Pontoreposicaopa";

    private decimal? _pontoreposicaopa;

    private static readonly string RO_PRAZO = "Prazo";

    private decimal? _prazo;

    private static readonly string RO_PRAZOENTR = "Prazoentr";

    private decimal? _prazoentr;

    private static readonly string RO_PRAZOEXPURGO = "Prazoexpurgo";

    private decimal? _prazoexpurgo;

    private static readonly string RO_PRAZOGARANTIA = "Prazogarantia";

    private decimal? _prazogarantia;

    private static readonly string RO_PRAZOMAXINDENIZACAO = "Prazomaxindenizacao";

    private decimal? _prazomaxindenizacao;

    private static readonly string RO_PRAZOMAXVALIDADE = "Prazomaxvalidade";

    private decimal? _prazomaxvalidade;

    private static readonly string RO_PRAZOMAXVENDA = "Prazomaxvenda";

    private decimal? _prazomaxvenda;

    private static readonly string RO_PRAZOMEDIOPRODUCAO = "Prazomedioproducao";

    private decimal? _prazomedioproducao;

    private static readonly string RO_PRAZOMEDIOVENDA = "Prazomediovenda";

    private decimal? _prazomediovenda;

    private static readonly string RO_PRAZOMINVALIDADE = "Prazominvalidade";

    private decimal? _prazominvalidade;

    private static readonly string RO_PRAZOVAL = "Prazoval";

    private decimal? _prazoval;

    private static readonly string RO_PRECIFICESTRANGEIRA = "Precificestrangeira";

    private string _precificestrangeira;

    private static readonly string RO_PRECOFIXO = "Precofixo";

    private string _precofixo;

    private static readonly string RO_PRECOMAXCONSUM = "Precomaxconsum";

    private decimal? _precomaxconsum;

    private static readonly string RO_PRECOMAXCONSUMTAB = "Precomaxconsumtab";

    private decimal? _precomaxconsumtab;

    private static readonly string RO_PRECOMAXCONSUMTABANT = "Precomaxconsumtabant";

    private decimal? _precomaxconsumtabant;

    private static readonly string RO_PRECOMAXCONSUMZFM = "Precomaxconsumzfm";

    private decimal? _precomaxconsumzfm;

    private static readonly string RO_PRECOMAXCONSUMZFMANT = "Precomaxconsumzfmant";

    private decimal? _precomaxconsumzfmant;

    private static readonly string RO_PRECOMAXCONSUMZFMTAB = "Precomaxconsumzfmtab";

    private decimal? _precomaxconsumzfmtab;

    private static readonly string RO_PREDIO = "Predio";

    private decimal? _predio;

    private static readonly string RO_PREDIOCX = "Prediocx";

    private decimal? _prediocx;

    private static readonly string RO_PREFIXOLOTE = "Prefixolote";

    private string _prefixolote;

    private static readonly string RO_PRINCIPIOATIVO = "Principioativo";

    private string _principioativo;

    private static readonly string RO_PROTEINA = "Proteina";

    private string _proteina;

    private static readonly string RO_PROXNUMLOTE = "Proxnumlote";

    private decimal? _proxnumlote;

    private static readonly string RO_PSICOTROPICO = "Psicotropico";

    private string _psicotropico;

    private static readonly string RO_PTABELAFORNEC = "Ptabelafornec";

    private decimal? _ptabelafornec;

    private static readonly string RO_PVENDA = "Pvenda";

    private decimal? _pvenda;

    private static readonly string RO_QTDEMAXSEPARPEDIDO = "Qtdemaxseparpedido";

    private decimal? _qtdemaxseparpedido;

    private static readonly string RO_QTDMAXSEPARARPEDIDO = "Qtdmaxsepararpedido";

    private decimal? _qtdmaxsepararpedido;

    private static readonly string RO_QTMAXGONDULA = "Qtmaxgondula";

    private decimal? _qtmaxgondula;

    private static readonly string RO_QTMETROS = "Qtmetros";

    private decimal? _qtmetros;

    private static readonly string RO_QTMINGONDULA = "Qtmingondula";

    private decimal? _qtmingondula;

    private static readonly string RO_QTMINIMAATACADO = "Qtminimaatacado";

    private decimal? _qtminimaatacado;

    private static readonly string RO_QTMINIMAATACADOF = "Qtminimaatacadof";

    private decimal? _qtminimaatacadof;

    private static readonly string RO_QTMINPRODUZIR = "Qtminproduzir";

    private decimal? _qtminproduzir;

    private static readonly string RO_QTMINSUGCOMPRA = "Qtminsugcompra";

    private decimal? _qtminsugcompra;

    private static readonly string RO_QTPONTOPEDIDO = "Qtpontopedido";

    private decimal? _qtpontopedido;

    private static readonly string RO_QTPRODUZIR = "Qtproduzir";

    private decimal? _qtproduzir;

    private static readonly string RO_QTPULMAOREGULADOR = "Qtpulmaoregulador";

    private decimal? _qtpulmaoregulador;

    private static readonly string RO_QTTOTPAL = "Qttotpal";

    private decimal? _qttotpal;

    private static readonly string RO_QTTOTPALFRAC = "Qttotpalfrac";

    private decimal? _qttotpalfrac;

    private static readonly string RO_QTUNIT = "Qtunit";

    private decimal? _qtunit;

    private static readonly string RO_QTUNITCT = "Qtunitct";

    private decimal? _qtunitct;

    private static readonly string RO_QTUNITCX = "Qtunitcx";

    private decimal? _qtunitcx;

    private static readonly string RO_RECMINARM = "Recminarm";

    private decimal? _recminarm;

    private static readonly string RO_REDBASEALIQEXT = "Redbasealiqext";

    private decimal? _redbasealiqext;

    private static readonly string RO_REDBASEALIQEXTBCR = "Redbasealiqextbcr";

    private decimal? _redbasealiqextbcr;

    private static readonly string RO_REDBASEIVA = "Redbaseiva";

    private decimal? _redbaseiva;

    private static readonly string RO_REDBASEIVABCR = "Redbaseivabcr";

    private decimal? _redbaseivabcr;

    private static readonly string RO_REGISTROMSMED = "Registromsmed";

    private string _registromsmed;

    private static readonly string RO_REGMS = "Regms";

    private string _regms;

    private static readonly string RO_RESTRICAOBLOCADO = "Restricaoblocado";

    private decimal? _restricaoblocado;

    private static readonly string RO_RESTRICAOTRANSP = "Restricaotransp";

    private string _restricaotransp;

    private static readonly string RO_RESTRINGECOTACAO = "Restringecotacao";

    private string _restringecotacao;

    private static readonly string RO_REVENDA = "Revenda";

    private string _revenda;

    private static readonly string RO_ROTINALANC = "Rotinalanc";

    private string _rotinalanc;

    private static readonly string RO_RUA = "Rua";

    private decimal? _rua;

    private static readonly string RO_RUACT = "Ruact";

    private decimal? _ruact;

    private static readonly string RO_RUACX = "Ruacx";

    private decimal? _ruacx;

    private static readonly string RO_RUA2 = "Rua2";

    private decimal? _rua2;

    private static readonly string RO_SALMONELA = "Salmonela";

    private string _salmonela;

    private static readonly string RO_SEQPAGINA = "Seqpagina";

    private decimal? _seqpagina;

    private static readonly string RO_SEQTABPRECO = "Seqtabpreco";

    private decimal? _seqtabpreco;

    private static readonly string RO_SIMPRO = "Simpro";

    private string _simpro;

    private static readonly string RO_SITTRIBUT = "Sittribut";

    private string _sittribut;

    private static readonly string RO_SITTRIBUTDEV = "Sittributdev";

    private string _sittributdev;

    private static readonly string RO_SITTRIBUTDEVFORNEC = "Sittributdevfornec";

    private string _sittributdevfornec;

    private static readonly string RO_SITTRIBUTENT = "Sittributent";

    private string _sittributent;

    private static readonly string RO_SOMENTETV3 = "Somentetv3";

    private string _somentetv3;

    private static readonly string RO_STATUS = "Status";

    private string _status;

    private static readonly string RO_SUBSTANCIA = "Substancia";

    private string _substancia;

    private static readonly string RO_SUBTITULOECOMMERCE = "Subtituloecommerce";

    private string _subtituloecommerce;

    private static readonly string RO_SUGVENDA = "Sugvenda";

    private decimal? _sugvenda;

    private static readonly string RO_TAMANHOLOTEFAB = "Tamanholotefab";

    private decimal? _tamanholotefab;

    private static readonly string RO_TEMREPOS = "Temrepos";

    private decimal? _temrepos;

    private static readonly string RO_TIPOALTURAPALETE = "Tipoalturapalete";

    private decimal? _tipoalturapalete;

    private static readonly string RO_TIPOARM = "Tipoarm";

    private decimal? _tipoarm;

    private static readonly string RO_TIPOCALCST = "Tipocalcst";

    private string _tipocalcst;

    private static readonly string RO_TIPOCARGA = "Tipocarga";

    private decimal? _tipocarga;

    private static readonly string RO_TIPOCOMISSAO = "Tipocomissao";

    private string _tipocomissao;

    private static readonly string RO_TIPODESCARGA = "Tipodescarga";

    private string _tipodescarga;

    private static readonly string RO_TIPOEMBALAGE = "Tipoembalage";

    private string _tipoembalage;

    private static readonly string RO_TIPOEMBALAGEMNESTLE = "Tipoembalagemnestle";

    private decimal? _tipoembalagemnestle;

    private static readonly string RO_TIPOESTOQUE = "Tipoestoque";

    private string _tipoestoque;

    private static readonly string RO_TIPOMEDICAMENTO = "Tipomedicamento";

    private string _tipomedicamento;

    private static readonly string RO_TIPOMERC = "Tipomerc";

    private string _tipomerc;

    private static readonly string RO_TIPOMP = "Tipomp";

    private string _tipomp;

    private static readonly string RO_TIPONORMA = "Tiponorma";

    private string _tiponorma;

    private static readonly string RO_TIPOPAL = "Tipopal";

    private decimal? _tipopal;

    private static readonly string RO_TIPOPALPUL = "Tipopalpul";

    private decimal? _tipopalpul;

    private static readonly string RO_TIPOPISCOFINSRETIDO = "Tipopiscofinsretido";

    private decimal? _tipopiscofinsretido;

    private static readonly string RO_TIPOPROD = "Tipoprod";

    private decimal? _tipoprod;

    private static readonly string RO_TIPORESTRICAO = "Tiporestricao";

    private string _tiporestricao;

    private static readonly string RO_TIPORESTRICAOMED = "Tiporestricaomed";

    private string _tiporestricaomed;

    private static readonly string RO_TIPOSUGCOMPRA = "Tiposugcompra";

    private string _tiposugcompra;

    private static readonly string RO_TIPOTRIBUTMEDIC = "Tipotributmedic";

    private string _tipotributmedic;

    private static readonly string RO_TIPOVOLUMEDESCARGA = "Tipovolumedescarga";

    private string _tipovolumedescarga;

    private static readonly string RO_TITULOECOMMERCE = "Tituloecommerce";

    private string _tituloecommerce;

    private static readonly string RO_TOTDEFEITO = "Totdefeito";

    private string _totdefeito;

    private static readonly string RO_TRIBFEDERAL = "Tribfederal";

    private string _tribfederal;

    private static readonly string RO_UMIDADE = "Umidade";

    private string _umidade;

    private static readonly string RO_UMIDADEANALISE = "Umidadeanalise";

    private string _umidadeanalise;

    private static readonly string RO_UNDPOREMBALAGEM = "Undporembalagem";

    private decimal? _undporembalagem;

    private static readonly string RO_UNIDADE = "Unidade";

    private string _unidade;

    private static readonly string RO_UNIDADECT = "Unidadect";

    private string _unidadect;

    private static readonly string RO_UNIDADEMASTER = "Unidademaster";

    private string _unidademaster;

    private static readonly string RO_UNIFORMIDADE = "Uniformidade";

    private string _uniformidade;

    private static readonly string RO_USAALIQCREDICMSDIFER = "Usaaliqcredicmsdifer";

    private string _usaaliqcredicmsdifer;

    private static readonly string RO_USACLASSIFICACAO = "Usaclassificacao";

    private string _usaclassificacao;

    private static readonly string RO_USACROSS = "Usacross";

    private string _usacross;

    private static readonly string RO_USAPISCOFINSLIT = "Usapiscofinslit";

    private string _usapiscofinslit;

    private static readonly string RO_USAPISCOFINSLITIMP = "Usapiscofinslitimp";

    private string _usapiscofinslitimp;

    private static readonly string RO_USAPMCBASEST = "Usapmcbasest";

    private string _usapmcbasest;

    private static readonly string RO_USAPULMAOREGULADOR = "Usapulmaoregulador";

    private string _usapulmaoregulador;

    private static readonly string RO_USAWMS = "Usawms";

    private string _usawms;

    private static readonly string RO_UTILIZAPRECOMAXCONSUMIDOR = "Utilizaprecomaxconsumidor";

    private string _utilizaprecomaxconsumidor;

    private static readonly string RO_UTILIZARVASILHAME = "Utilizarvasilhame";

    private string _utilizarvasilhame;

    private static readonly string RO_UTILIZASELO = "Utilizaselo";

    private string _utilizaselo;

    private static readonly string RO_VALIDARLOTE = "Validarlote";

    private string _validarlote;

    private static readonly string RO_VALORCOFINSLITRAGEM = "Valorcofinslitragem";

    private decimal? _valorcofinslitragem;

    private static readonly string RO_VALORPISLITRAGEM = "Valorpislitragem";

    private decimal? _valorpislitragem;

    private static readonly string RO_VELOCIDADEESP = "Velocidadeesp";

    private decimal? _velocidadeesp;

    private static readonly string RO_VELOCIDADEOPERACIONAL = "Velocidadeoperacional";

    private decimal? _velocidadeoperacional;

    private static readonly string RO_VENDADIRETA = "Vendadireta";

    private string _vendadireta;

    private static readonly string RO_VERSANALISE = "Versanalise";

    private decimal? _versanalise;

    private static readonly string RO_VLADICIONALBCST = "Vladicionalbcst";

    private decimal? _vladicionalbcst;

    private static readonly string RO_VLADICIONALBCSTBCR = "Vladicionalbcstbcr";

    private decimal? _vladicionalbcstbcr;

    private static readonly string RO_VLBONIFIC = "Vlbonific";

    private decimal? _vlbonific;

    private static readonly string RO_VLCALORICO = "Vlcalorico";

    private string _vlcalorico;

    private static readonly string RO_VLCOFINSLIT = "Vlcofinslit";

    private decimal? _vlcofinslit;

    private static readonly string RO_VLCOFINSLITIMP = "Vlcofinslitimp";

    private decimal? _vlcofinslitimp;

    private static readonly string RO_VLDIFALIQUOTAS = "Vldifaliquotas";

    private decimal? _vldifaliquotas;

    private static readonly string RO_VLFRETEPORKG = "Vlfreteporkg";

    private decimal? _vlfreteporkg;

    private static readonly string RO_VLICMSANTECIPADO = "Vlicmsantecipado";

    private decimal? _vlicmsantecipado;

    private static readonly string RO_VLIPI = "Vlipi";

    private decimal? _vlipi;

    private static readonly string RO_VLIPIPESO = "Vlipipeso";

    private decimal? _vlipipeso;

    private static readonly string RO_VLIPIPORKG = "Vlipiporkg";

    private decimal? _vlipiporkg;

    private static readonly string RO_VLIPIPORKGVENDA = "Vlipiporkgvenda";

    private decimal? _vlipiporkgvenda;

    private static readonly string RO_VLIPIPORKGVENDATAB = "Vlipiporkgvendatab";

    private decimal? _vlipiporkgvendatab;

    private static readonly string RO_VLMAODEOBRA = "Vlmaodeobra";

    private decimal? _vlmaodeobra;

    private static readonly string RO_VLPAUTA = "Vlpauta";

    private decimal? _vlpauta;

    private static readonly string RO_VLPAUTABCR = "Vlpautabcr";

    private decimal? _vlpautabcr;

    private static readonly string RO_VLPAUTAICMS = "Vlpautaicms";

    private decimal? _vlpautaicms;

    private static readonly string RO_VLPAUTAICMSANTEC = "Vlpautaicmsantec";

    private decimal? _vlpautaicmsantec;

    private static readonly string RO_VLPAUTAIPI = "Vlpautaipi";

    private decimal? _vlpautaipi;

    private static readonly string RO_VLPAUTAIPIVENDA = "Vlpautaipivenda";

    private decimal? _vlpautaipivenda;

    private static readonly string RO_VLPAUTAIPIVENDATAB = "Vlpautaipivendatab";

    private decimal? _vlpautaipivendatab;

    private static readonly string RO_VLPAUTAPISCOFINS = "Vlpautapiscofins";

    private decimal? _vlpautapiscofins;

    private static readonly string RO_VLPAUTAPISCOFINSIMP = "Vlpautapiscofinsimp";

    private decimal? _vlpautapiscofinsimp;

    private static readonly string RO_VLPISLIT = "Vlpislit";

    private decimal? _vlpislit;

    private static readonly string RO_VLPISLITIMP = "Vlpislitimp";

    private decimal? _vlpislitimp;

    private static readonly string RO_VLRAPLICINT = "Vlraplicint";

    private decimal? _vlraplicint;

    private static readonly string RO_VLVENDATEMP = "Vlvendatemp";

    private decimal? _vlvendatemp;

    private static readonly string RO_VOLPESMED = "Volpesmed";

    private string _volpesmed;

    private static readonly string RO_VOLUME = "Volume";

    private decimal? _volume;

    private static readonly string RO_VOLUMEARM = "Volumearm";

    private decimal? _volumearm;

    private static readonly string RO_VOLUMEREC = "Volumerec";

    private decimal? _volumerec;

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Abastepalete
    {
        get
        {
            PropriedadeAcessada(RO_ABASTEPALETE);
            return _abastepalete;
        }
        set
        {
            PropriedadeModificada(RO_ABASTEPALETE, value);
            _abastepalete = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Abastepaletecx
    {
        get
        {
            PropriedadeAcessada(RO_ABASTEPALETECX);
            return _abastepaletecx;
        }
        set
        {
            PropriedadeModificada(RO_ABASTEPALETECX, value);
            _abastepaletecx = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 2)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 6)]
    public decimal? Alturaarm
    {
        get
        {
            PropriedadeAcessada(RO_ALTURAARM);
            return _alturaarm;
        }
        set
        {
            PropriedadeModificada(RO_ALTURAARM, value);
            _alturaarm = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 6)]
    public decimal? Alturam3
    {
        get
        {
            PropriedadeAcessada(RO_ALTURAM3);
            return _alturam3;
        }
        set
        {
            PropriedadeModificada(RO_ALTURAM3, value);
            _alturam3 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 4)]
    public decimal? Alturapal
    {
        get
        {
            PropriedadeAcessada(RO_ALTURAPAL);
            return _alturapal;
        }
        set
        {
            PropriedadeModificada(RO_ALTURAPAL, value);
            _alturapal = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 100, Precisao = 0)]
    public string Analisedesc
    {
        get
        {
            PropriedadeAcessada(RO_ANALISEDESC);
            return _analisedesc;
        }
        set
        {
            PropriedadeModificada(RO_ANALISEDESC, value);
            _analisedesc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 11, Precisao = 0)]
    public decimal? Anvisacapinstal
    {
        get
        {
            PropriedadeAcessada(RO_ANVISACAPINSTAL);
            return _anvisacapinstal;
        }
        set
        {
            PropriedadeModificada(RO_ANVISACAPINSTAL, value);
            _anvisacapinstal = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
    public string Anvisaclasterapeutica
    {
        get
        {
            PropriedadeAcessada(RO_ANVISACLASTERAPEUTICA);
            return _anvisaclasterapeutica;
        }
        set
        {
            PropriedadeModificada(RO_ANVISACLASTERAPEUTICA, value);
            _anvisaclasterapeutica = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
    public string Anvisacoeftec
    {
        get
        {
            PropriedadeAcessada(RO_ANVISACOEFTEC);
            return _anvisacoeftec;
        }
        set
        {
            PropriedadeModificada(RO_ANVISACOEFTEC, value);
            _anvisacoeftec = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 2)]
    public decimal? Anvisaconcen
    {
        get
        {
            PropriedadeAcessada(RO_ANVISACONCEN);
            return _anvisaconcen;
        }
        set
        {
            PropriedadeModificada(RO_ANVISACONCEN, value);
            _anvisaconcen = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 100, Precisao = 0)]
    public string Anvisadescprincat1
    {
        get
        {
            PropriedadeAcessada(RO_ANVISADESCPRINCAT1);
            return _anvisadescprincat1;
        }
        set
        {
            PropriedadeModificada(RO_ANVISADESCPRINCAT1, value);
            _anvisadescprincat1 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 100, Precisao = 0)]
    public string Anvisadescprincat2
    {
        get
        {
            PropriedadeAcessada(RO_ANVISADESCPRINCAT2);
            return _anvisadescprincat2;
        }
        set
        {
            PropriedadeModificada(RO_ANVISADESCPRINCAT2, value);
            _anvisadescprincat2 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 100, Precisao = 0)]
    public string Anvisadescprincat3
    {
        get
        {
            PropriedadeAcessada(RO_ANVISADESCPRINCAT3);
            return _anvisadescprincat3;
        }
        set
        {
            PropriedadeModificada(RO_ANVISADESCPRINCAT3, value);
            _anvisadescprincat3 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 100, Precisao = 0)]
    public string Anvisadescprincat4
    {
        get
        {
            PropriedadeAcessada(RO_ANVISADESCPRINCAT4);
            return _anvisadescprincat4;
        }
        set
        {
            PropriedadeModificada(RO_ANVISADESCPRINCAT4, value);
            _anvisadescprincat4 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
    public string Anvisaformafarm
    {
        get
        {
            PropriedadeAcessada(RO_ANVISAFORMAFARM);
            return _anvisaformafarm;
        }
        set
        {
            PropriedadeModificada(RO_ANVISAFORMAFARM, value);
            _anvisaformafarm = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Anvisanumprincat
    {
        get
        {
            PropriedadeAcessada(RO_ANVISANUMPRINCAT);
            return _anvisanumprincat;
        }
        set
        {
            PropriedadeModificada(RO_ANVISANUMPRINCAT, value);
            _anvisanumprincat = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
    public string Anvisanumregmed
    {
        get
        {
            PropriedadeAcessada(RO_ANVISANUMREGMED);
            return _anvisanumregmed;
        }
        set
        {
            PropriedadeModificada(RO_ANVISANUMREGMED, value);
            _anvisanumregmed = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 0)]
    public decimal? Anvisaqtembalagem
    {
        get
        {
            PropriedadeAcessada(RO_ANVISAQTEMBALAGEM);
            return _anvisaqtembalagem;
        }
        set
        {
            PropriedadeModificada(RO_ANVISAQTEMBALAGEM, value);
            _anvisaqtembalagem = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 3, Precisao = 0)]
    public string Anvisauncoeftec
    {
        get
        {
            PropriedadeAcessada(RO_ANVISAUNCOEFTEC);
            return _anvisauncoeftec;
        }
        set
        {
            PropriedadeModificada(RO_ANVISAUNCOEFTEC, value);
            _anvisauncoeftec = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 3, Precisao = 0)]
    public string Anvisaundosag
    {
        get
        {
            PropriedadeAcessada(RO_ANVISAUNDOSAG);
            return _anvisaundosag;
        }
        set
        {
            PropriedadeModificada(RO_ANVISAUNDOSAG, value);
            _anvisaundosag = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Anvisausocontinuo
    {
        get
        {
            PropriedadeAcessada(RO_ANVISAUSOCONTINUO);
            return _anvisausocontinuo;
        }
        set
        {
            PropriedadeModificada(RO_ANVISAUSOCONTINUO, value);
            _anvisausocontinuo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
    public string Anvisaviaadm
    {
        get
        {
            PropriedadeAcessada(RO_ANVISAVIAADM);
            return _anvisaviaadm;
        }
        set
        {
            PropriedadeModificada(RO_ANVISAVIAADM, value);
            _anvisaviaadm = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 500, Precisao = 0)]
    public string Aplicacoes
    {
        get
        {
            PropriedadeAcessada(RO_APLICACOES);
            return _aplicacoes;
        }
        set
        {
            PropriedadeModificada(RO_APLICACOES, value);
            _aplicacoes = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Aplicredbaseivapliq
    {
        get
        {
            PropriedadeAcessada(RO_APLICREDBASEIVAPLIQ);
            return _aplicredbaseivapliq;
        }
        set
        {
            PropriedadeModificada(RO_APLICREDBASEIVAPLIQ, value);
            _aplicredbaseivapliq = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Aplicredbaseivapliqbcr
    {
        get
        {
            PropriedadeAcessada(RO_APLICREDBASEIVAPLIQBCR);
            return _aplicredbaseivapliqbcr;
        }
        set
        {
            PropriedadeModificada(RO_APLICREDBASEIVAPLIQBCR, value);
            _aplicredbaseivapliqbcr = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Apto
    {
        get
        {
            PropriedadeAcessada(RO_APTO);
            return _apto;
        }
        set
        {
            PropriedadeModificada(RO_APTO, value);
            _apto = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 2, Precisao = 0)]
    public decimal? Aptoct
    {
        get
        {
            PropriedadeAcessada(RO_APTOCT);
            return _aptoct;
        }
        set
        {
            PropriedadeModificada(RO_APTOCT, value);
            _aptoct = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 2, Precisao = 0)]
    public decimal? Aptocx
    {
        get
        {
            PropriedadeAcessada(RO_APTOCX);
            return _aptocx;
        }
        set
        {
            PropriedadeModificada(RO_APTOCX, value);
            _aptocx = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 2, Precisao = 0)]
    public decimal? Apto2
    {
        get
        {
            PropriedadeAcessada(RO_APTO2);
            return _apto2;
        }
        set
        {
            PropriedadeModificada(RO_APTO2, value);
            _apto2 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 255, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Atupesomasterent
    {
        get
        {
            PropriedadeAcessada(RO_ATUPESOMASTERENT);
            return _atupesomasterent;
        }
        set
        {
            PropriedadeModificada(RO_ATUPESOMASTERENT, value);
            _atupesomasterent = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Autorizatipo4
    {
        get
        {
            PropriedadeAcessada(RO_AUTORIZATIPO4);
            return _autorizatipo4;
        }
        set
        {
            PropriedadeModificada(RO_AUTORIZATIPO4, value);
            _autorizatipo4 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Basepiscofinslit
    {
        get
        {
            PropriedadeAcessada(RO_BASEPISCOFINSLIT);
            return _basepiscofinslit;
        }
        set
        {
            PropriedadeModificada(RO_BASEPISCOFINSLIT, value);
            _basepiscofinslit = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Basepiscofinslitimp
    {
        get
        {
            PropriedadeAcessada(RO_BASEPISCOFINSLITIMP);
            return _basepiscofinslitimp;
        }
        set
        {
            PropriedadeModificada(RO_BASEPISCOFINSLITIMP, value);
            _basepiscofinslitimp = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Basepiscofinslitragem
    {
        get
        {
            PropriedadeAcessada(RO_BASEPISCOFINSLITRAGEM);
            return _basepiscofinslitragem;
        }
        set
        {
            PropriedadeModificada(RO_BASEPISCOFINSLITRAGEM, value);
            _basepiscofinslitragem = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 100, Precisao = 0)]
    public string Boloresleveduras
    {
        get
        {
            PropriedadeAcessada(RO_BOLORESLEVEDURAS);
            return _boloresleveduras;
        }
        set
        {
            PropriedadeModificada(RO_BOLORESLEVEDURAS, value);
            _boloresleveduras = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 4)]
    public decimal? Camapapal
    {
        get
        {
            PropriedadeAcessada(RO_CAMAPAPAL);
            return _camapapal;
        }
        set
        {
            PropriedadeModificada(RO_CAMAPAPAL, value);
            _camapapal = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 2)]
    public decimal? Capacidadepa
    {
        get
        {
            PropriedadeAcessada(RO_CAPACIDADEPA);
            return _capacidadepa;
        }
        set
        {
            PropriedadeModificada(RO_CAPACIDADEPA, value);
            _capacidadepa = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 2)]
    public decimal? Capacidadepicking
    {
        get
        {
            PropriedadeAcessada(RO_CAPACIDADEPICKING);
            return _capacidadepicking;
        }
        set
        {
            PropriedadeModificada(RO_CAPACIDADEPICKING, value);
            _capacidadepicking = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 2)]
    public decimal? Capacidadepickingal
    {
        get
        {
            PropriedadeAcessada(RO_CAPACIDADEPICKINGAL);
            return _capacidadepickingal;
        }
        set
        {
            PropriedadeModificada(RO_CAPACIDADEPICKINGAL, value);
            _capacidadepickingal = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 2)]
    public decimal? Capacidadepickingcx
    {
        get
        {
            PropriedadeAcessada(RO_CAPACIDADEPICKINGCX);
            return _capacidadepickingcx;
        }
        set
        {
            PropriedadeModificada(RO_CAPACIDADEPICKINGCX, value);
            _capacidadepickingcx = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Catergoria
    {
        get
        {
            PropriedadeAcessada(RO_CATERGORIA);
            return _catergoria;
        }
        set
        {
            PropriedadeModificada(RO_CATERGORIA, value);
            _catergoria = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Cestabasicalegis
    {
        get
        {
            PropriedadeAcessada(RO_CESTABASICALEGIS);
            return _cestabasicalegis;
        }
        set
        {
            PropriedadeModificada(RO_CESTABASICALEGIS, value);
            _cestabasicalegis = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Checarmultiplovendabnf
    {
        get
        {
            PropriedadeAcessada(RO_CHECARMULTIPLOVENDABNF);
            return _checarmultiplovendabnf;
        }
        set
        {
            PropriedadeModificada(RO_CHECARMULTIPLOVENDABNF, value);
            _checarmultiplovendabnf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Classe
    {
        get
        {
            PropriedadeAcessada(RO_CLASSE);
            return _classe;
        }
        set
        {
            PropriedadeModificada(RO_CLASSE, value);
            _classe = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Classecomissao
    {
        get
        {
            PropriedadeAcessada(RO_CLASSECOMISSAO);
            return _classecomissao;
        }
        set
        {
            PropriedadeModificada(RO_CLASSECOMISSAO, value);
            _classecomissao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Classecompra
    {
        get
        {
            PropriedadeAcessada(RO_CLASSECOMPRA);
            return _classecompra;
        }
        set
        {
            PropriedadeModificada(RO_CLASSECOMPRA, value);
            _classecompra = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Classeestoque
    {
        get
        {
            PropriedadeAcessada(RO_CLASSEESTOQUE);
            return _classeestoque;
        }
        set
        {
            PropriedadeModificada(RO_CLASSEESTOQUE, value);
            _classeestoque = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 6, Precisao = 0)]
    public string Classeflow
    {
        get
        {
            PropriedadeAcessada(RO_CLASSEFLOW);
            return _classeflow;
        }
        set
        {
            PropriedadeModificada(RO_CLASSEFLOW, value);
            _classeflow = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 4, Precisao = 0)]
    public string Codacondicionamento
    {
        get
        {
            PropriedadeAcessada(RO_CODACONDICIONAMENTO);
            return _codacondicionamento;
        }
        set
        {
            PropriedadeModificada(RO_CODACONDICIONAMENTO, value);
            _codacondicionamento = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Codagrupmapasep
    {
        get
        {
            PropriedadeAcessada(RO_CODAGRUPMAPASEP);
            return _codagrupmapasep;
        }
        set
        {
            PropriedadeModificada(RO_CODAGRUPMAPASEP, value);
            _codagrupmapasep = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 20, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 0)]
    public decimal? Codauxiliar2
    {
        get
        {
            PropriedadeAcessada(RO_CODAUXILIAR2);
            return _codauxiliar2;
        }
        set
        {
            PropriedadeModificada(RO_CODAUXILIAR2, value);
            _codauxiliar2 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 3, Precisao = 0)]
    public decimal? Codcaracprod
    {
        get
        {
            PropriedadeAcessada(RO_CODCARACPROD);
            return _codcaracprod;
        }
        set
        {
            PropriedadeModificada(RO_CODCARACPROD, value);
            _codcaracprod = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codcategoria
    {
        get
        {
            PropriedadeAcessada(RO_CODCATEGORIA);
            return _codcategoria;
        }
        set
        {
            PropriedadeModificada(RO_CODCATEGORIA, value);
            _codcategoria = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Codcategoriaweb
    {
        get
        {
            PropriedadeAcessada(RO_CODCATEGORIAWEB);
            return _codcategoriaweb;
        }
        set
        {
            PropriedadeModificada(RO_CODCATEGORIAWEB, value);
            _codcategoriaweb = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Codcor
    {
        get
        {
            PropriedadeAcessada(RO_CODCOR);
            return _codcor;
        }
        set
        {
            PropriedadeModificada(RO_CODCOR, value);
            _codcor = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Coddeptoweb
    {
        get
        {
            PropriedadeAcessada(RO_CODDEPTOWEB);
            return _coddeptoweb;
        }
        set
        {
            PropriedadeModificada(RO_CODDEPTOWEB, value);
            _coddeptoweb = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Codenderecoal
    {
        get
        {
            PropriedadeAcessada(RO_CODENDERECOAL);
            return _codenderecoal;
        }
        set
        {
            PropriedadeModificada(RO_CODENDERECOAL, value);
            _codenderecoal = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Codenderecoap
    {
        get
        {
            PropriedadeAcessada(RO_CODENDERECOAP);
            return _codenderecoap;
        }
        set
        {
            PropriedadeModificada(RO_CODENDERECOAP, value);
            _codenderecoap = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Codenderecocx
    {
        get
        {
            PropriedadeAcessada(RO_CODENDERECOCX);
            return _codenderecocx;
        }
        set
        {
            PropriedadeModificada(RO_CODENDERECOCX, value);
            _codenderecocx = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Codenderecopa
    {
        get
        {
            PropriedadeAcessada(RO_CODENDERECOPA);
            return _codenderecopa;
        }
        set
        {
            PropriedadeModificada(RO_CODENDERECOPA, value);
            _codenderecopa = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal Codepto
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Codequipe
    {
        get
        {
            PropriedadeAcessada(RO_CODEQUIPE);
            return _codequipe;
        }
        set
        {
            PropriedadeModificada(RO_CODEQUIPE, value);
            _codequipe = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codexcecaopiscofins
    {
        get
        {
            PropriedadeAcessada(RO_CODEXCECAOPISCOFINS);
            return _codexcecaopiscofins;
        }
        set
        {
            PropriedadeModificada(RO_CODEXCECAOPISCOFINS, value);
            _codexcecaopiscofins = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 30, Precisao = 0)]
    public string Codfab
    {
        get
        {
            PropriedadeAcessada(RO_CODFAB);
            return _codfab;
        }
        set
        {
            PropriedadeModificada(RO_CODFAB, value);
            _codfab = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Codfilialprodutora
    {
        get
        {
            PropriedadeAcessada(RO_CODFILIALPRODUTORA);
            return _codfilialprodutora;
        }
        set
        {
            PropriedadeModificada(RO_CODFILIALPRODUTORA, value);
            _codfilialprodutora = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Codfiscalconsigfat
    {
        get
        {
            PropriedadeAcessada(RO_CODFISCALCONSIGFAT);
            return _codfiscalconsigfat;
        }
        set
        {
            PropriedadeModificada(RO_CODFISCALCONSIGFAT, value);
            _codfiscalconsigfat = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfiscaldevfornec
    {
        get
        {
            PropriedadeAcessada(RO_CODFISCALDEVFORNEC);
            return _codfiscaldevfornec;
        }
        set
        {
            PropriedadeModificada(RO_CODFISCALDEVFORNEC, value);
            _codfiscaldevfornec = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Codfiscalenttransf
    {
        get
        {
            PropriedadeAcessada(RO_CODFISCALENTTRANSF);
            return _codfiscalenttransf;
        }
        set
        {
            PropriedadeModificada(RO_CODFISCALENTTRANSF, value);
            _codfiscalenttransf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfiscalenttv9
    {
        get
        {
            PropriedadeAcessada(RO_CODFISCALENTTV9);
            return _codfiscalenttv9;
        }
        set
        {
            PropriedadeModificada(RO_CODFISCALENTTV9, value);
            _codfiscalenttv9 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Codfiscalsr
    {
        get
        {
            PropriedadeAcessada(RO_CODFISCALSR);
            return _codfiscalsr;
        }
        set
        {
            PropriedadeModificada(RO_CODFISCALSR, value);
            _codfiscalsr = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codformatopapel
    {
        get
        {
            PropriedadeAcessada(RO_CODFORMATOPAPEL);
            return _codformatopapel;
        }
        set
        {
            PropriedadeModificada(RO_CODFORMATOPAPEL, value);
            _codformatopapel = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Codgrade
    {
        get
        {
            PropriedadeAcessada(RO_CODGRADE);
            return _codgrade;
        }
        set
        {
            PropriedadeModificada(RO_CODGRADE, value);
            _codgrade = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Codgrulit
    {
        get
        {
            PropriedadeAcessada(RO_CODGRULIT);
            return _codgrulit;
        }
        set
        {
            PropriedadeModificada(RO_CODGRULIT, value);
            _codgrulit = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 0)]
    public decimal? Codinfnutri
    {
        get
        {
            PropriedadeAcessada(RO_CODINFNUTRI);
            return _codinfnutri;
        }
        set
        {
            PropriedadeModificada(RO_CODINFNUTRI, value);
            _codinfnutri = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
    public string Codinterno
    {
        get
        {
            PropriedadeAcessada(RO_CODINTERNO);
            return _codinterno;
        }
        set
        {
            PropriedadeModificada(RO_CODINTERNO, value);
            _codinterno = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codlinha
    {
        get
        {
            PropriedadeAcessada(RO_CODLINHA);
            return _codlinha;
        }
        set
        {
            PropriedadeModificada(RO_CODLINHA, value);
            _codlinha = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Codlinhanestle
    {
        get
        {
            PropriedadeAcessada(RO_CODLINHANESTLE);
            return _codlinhanestle;
        }
        set
        {
            PropriedadeModificada(RO_CODLINHANESTLE, value);
            _codlinhanestle = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codlinhaprazo
    {
        get
        {
            PropriedadeAcessada(RO_CODLINHAPRAZO);
            return _codlinhaprazo;
        }
        set
        {
            PropriedadeModificada(RO_CODLINHAPRAZO, value);
            _codlinhaprazo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codlinhaprod
    {
        get
        {
            PropriedadeAcessada(RO_CODLINHAPROD);
            return _codlinhaprod;
        }
        set
        {
            PropriedadeModificada(RO_CODLINHAPROD, value);
            _codlinhaprod = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codmarca
    {
        get
        {
            PropriedadeAcessada(RO_CODMARCA);
            return _codmarca;
        }
        set
        {
            PropriedadeModificada(RO_CODMARCA, value);
            _codmarca = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
    public string Codncmex
    {
        get
        {
            PropriedadeAcessada(RO_CODNCMEX);
            return _codncmex;
        }
        set
        {
            PropriedadeModificada(RO_CODNCMEX, value);
            _codncmex = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 15, Precisao = 0)]
    public string Codnestleterceiros
    {
        get
        {
            PropriedadeAcessada(RO_CODNESTLETERCEIROS);
            return _codnestleterceiros;
        }
        set
        {
            PropriedadeModificada(RO_CODNESTLETERCEIROS, value);
            _codnestleterceiros = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 4, Precisao = 0)]
    public string Codonu
    {
        get
        {
            PropriedadeAcessada(RO_CODONU);
            return _codonu;
        }
        set
        {
            PropriedadeModificada(RO_CODONU, value);
            _codonu = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 4, Precisao = 0)]
    public string Codprazoent
    {
        get
        {
            PropriedadeAcessada(RO_CODPRAZOENT);
            return _codprazoent;
        }
        set
        {
            PropriedadeModificada(RO_CODPRAZOENT, value);
            _codprazoent = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Codprincipativo
    {
        get
        {
            PropriedadeAcessada(RO_CODPRINCIPATIVO);
            return _codprincipativo;
        }
        set
        {
            PropriedadeModificada(RO_CODPRINCIPATIVO, value);
            _codprincipativo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 3, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codprodembalagem
    {
        get
        {
            PropriedadeAcessada(RO_CODPRODEMBALAGEM);
            return _codprodembalagem;
        }
        set
        {
            PropriedadeModificada(RO_CODPRODEMBALAGEM, value);
            _codprodembalagem = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codprodmaster
    {
        get
        {
            PropriedadeAcessada(RO_CODPRODMASTER);
            return _codprodmaster;
        }
        set
        {
            PropriedadeModificada(RO_CODPRODMASTER, value);
            _codprodmaster = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codprodsimilar
    {
        get
        {
            PropriedadeAcessada(RO_CODPRODSIMILAR);
            return _codprodsimilar;
        }
        set
        {
            PropriedadeModificada(RO_CODPRODSIMILAR, value);
            _codprodsimilar = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 4, Precisao = 0)]
    public string Codrisco
    {
        get
        {
            PropriedadeAcessada(RO_CODRISCO);
            return _codrisco;
        }
        set
        {
            PropriedadeModificada(RO_CODRISCO, value);
            _codrisco = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codrotinaultalter
    {
        get
        {
            PropriedadeAcessada(RO_CODROTINAULTALTER);
            return _codrotinaultalter;
        }
        set
        {
            PropriedadeModificada(RO_CODROTINAULTALTER, value);
            _codrotinaultalter = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal Codsec
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Codsecaoweb
    {
        get
        {
            PropriedadeAcessada(RO_CODSECAOWEB);
            return _codsecaoweb;
        }
        set
        {
            PropriedadeModificada(RO_CODSECAOWEB, value);
            _codsecaoweb = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 3, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 3, Precisao = 0)]
    public decimal? Codsittribpiscofinsdev
    {
        get
        {
            PropriedadeAcessada(RO_CODSITTRIBPISCOFINSDEV);
            return _codsittribpiscofinsdev;
        }
        set
        {
            PropriedadeModificada(RO_CODSITTRIBPISCOFINSDEV, value);
            _codsittribpiscofinsdev = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codsubcategoria
    {
        get
        {
            PropriedadeAcessada(RO_CODSUBCATEGORIA);
            return _codsubcategoria;
        }
        set
        {
            PropriedadeModificada(RO_CODSUBCATEGORIA, value);
            _codsubcategoria = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Codsubcategoriaweb
    {
        get
        {
            PropriedadeAcessada(RO_CODSUBCATEGORIAWEB);
            return _codsubcategoriaweb;
        }
        set
        {
            PropriedadeModificada(RO_CODSUBCATEGORIAWEB, value);
            _codsubcategoriaweb = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Codtablit
    {
        get
        {
            PropriedadeAcessada(RO_CODTABLIT);
            return _codtablit;
        }
        set
        {
            PropriedadeModificada(RO_CODTABLIT, value);
            _codtablit = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 3, Precisao = 0)]
    public decimal? Codtipoestrutura
    {
        get
        {
            PropriedadeAcessada(RO_CODTIPOESTRUTURA);
            return _codtipoestrutura;
        }
        set
        {
            PropriedadeModificada(RO_CODTIPOESTRUTURA, value);
            _codtipoestrutura = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 3, Precisao = 0)]
    public decimal? Codtipoestruturapul
    {
        get
        {
            PropriedadeAcessada(RO_CODTIPOESTRUTURAPUL);
            return _codtipoestruturapul;
        }
        set
        {
            PropriedadeModificada(RO_CODTIPOESTRUTURAPUL, value);
            _codtipoestruturapul = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 2, Precisao = 0)]
    public decimal? Codunidmedidanf
    {
        get
        {
            PropriedadeAcessada(RO_CODUNIDMEDIDANF);
            return _codunidmedidanf;
        }
        set
        {
            PropriedadeModificada(RO_CODUNIDMEDIDANF, value);
            _codunidmedidanf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codusuultaltcom
    {
        get
        {
            PropriedadeAcessada(RO_CODUSUULTALTCOM);
            return _codusuultaltcom;
        }
        set
        {
            PropriedadeModificada(RO_CODUSUULTALTCOM, value);
            _codusuultaltcom = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 2)]
    public decimal? Cofinsretido
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 2, Precisao = 0)]
    public decimal? Colunagrade
    {
        get
        {
            PropriedadeAcessada(RO_COLUNAGRADE);
            return _colunagrade;
        }
        set
        {
            PropriedadeModificada(RO_COLUNAGRADE, value);
            _colunagrade = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 100, Precisao = 0)]
    public string Col95
    {
        get
        {
            PropriedadeAcessada(RO_COL95);
            return _col95;
        }
        set
        {
            PropriedadeModificada(RO_COL95, value);
            _col95 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Comissaofixa
    {
        get
        {
            PropriedadeAcessada(RO_COMISSAOFIXA);
            return _comissaofixa;
        }
        set
        {
            PropriedadeModificada(RO_COMISSAOFIXA, value);
            _comissaofixa = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Comissaoporlucratividade
    {
        get
        {
            PropriedadeAcessada(RO_COMISSAOPORLUCRATIVIDADE);
            return _comissaoporlucratividade;
        }
        set
        {
            PropriedadeModificada(RO_COMISSAOPORLUCRATIVIDADE, value);
            _comissaoporlucratividade = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 6)]
    public decimal? Comprimentoarm
    {
        get
        {
            PropriedadeAcessada(RO_COMPRIMENTOARM);
            return _comprimentoarm;
        }
        set
        {
            PropriedadeModificada(RO_COMPRIMENTOARM, value);
            _comprimentoarm = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 6)]
    public decimal? Comprimentom3
    {
        get
        {
            PropriedadeAcessada(RO_COMPRIMENTOM3);
            return _comprimentom3;
        }
        set
        {
            PropriedadeModificada(RO_COMPRIMENTOM3, value);
            _comprimentom3 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Concentracao
    {
        get
        {
            PropriedadeAcessada(RO_CONCENTRACAO);
            return _concentracao;
        }
        set
        {
            PropriedadeModificada(RO_CONCENTRACAO, value);
            _concentracao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Confaz
    {
        get
        {
            PropriedadeAcessada(RO_CONFAZ);
            return _confaz;
        }
        set
        {
            PropriedadeModificada(RO_CONFAZ, value);
            _confaz = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Conferenocheckout
    {
        get
        {
            PropriedadeAcessada(RO_CONFERENOCHECKOUT);
            return _conferenocheckout;
        }
        set
        {
            PropriedadeModificada(RO_CONFERENOCHECKOUT, value);
            _conferenocheckout = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Contloganalise
    {
        get
        {
            PropriedadeAcessada(RO_CONTLOGANALISE);
            return _contloganalise;
        }
        set
        {
            PropriedadeModificada(RO_CONTLOGANALISE, value);
            _contloganalise = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 100, Precisao = 0)]
    public string Contmicrobiana
    {
        get
        {
            PropriedadeAcessada(RO_CONTMICROBIANA);
            return _contmicrobiana;
        }
        set
        {
            PropriedadeModificada(RO_CONTMICROBIANA, value);
            _contmicrobiana = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Controladoibama
    {
        get
        {
            PropriedadeAcessada(RO_CONTROLADOIBAMA);
            return _controladoibama;
        }
        set
        {
            PropriedadeModificada(RO_CONTROLADOIBAMA, value);
            _controladoibama = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Controlanumseria
    {
        get
        {
            PropriedadeAcessada(RO_CONTROLANUMSERIA);
            return _controlanumseria;
        }
        set
        {
            PropriedadeModificada(RO_CONTROLANUMSERIA, value);
            _controlanumseria = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Controlapatrimonio
    {
        get
        {
            PropriedadeAcessada(RO_CONTROLAPATRIMONIO);
            return _controlapatrimonio;
        }
        set
        {
            PropriedadeModificada(RO_CONTROLAPATRIMONIO, value);
            _controlapatrimonio = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Controlavalidadedolote
    {
        get
        {
            PropriedadeAcessada(RO_CONTROLAVALIDADEDOLOTE);
            return _controlavalidadedolote;
        }
        set
        {
            PropriedadeModificada(RO_CONTROLAVALIDADEDOLOTE, value);
            _controlavalidadedolote = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 4, Precisao = 0)]
    public string Corredor
    {
        get
        {
            PropriedadeAcessada(RO_CORREDOR);
            return _corredor;
        }
        set
        {
            PropriedadeModificada(RO_CORREDOR, value);
            _corredor = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 2)]
    public decimal? Csllretido
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Custoproximacompra
    {
        get
        {
            PropriedadeAcessada(RO_CUSTOPROXIMACOMPRA);
            return _custoproximacompra;
        }
        set
        {
            PropriedadeModificada(RO_CUSTOPROXIMACOMPRA, value);
            _custoproximacompra = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Custorepmc
    {
        get
        {
            PropriedadeAcessada(RO_CUSTOREPMC);
            return _custorepmc;
        }
        set
        {
            PropriedadeModificada(RO_CUSTOREPMC, value);
            _custorepmc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Custoreptab
    {
        get
        {
            PropriedadeAcessada(RO_CUSTOREPTAB);
            return _custoreptab;
        }
        set
        {
            PropriedadeModificada(RO_CUSTOREPTAB, value);
            _custoreptab = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Custoreptabant
    {
        get
        {
            PropriedadeAcessada(RO_CUSTOREPTABANT);
            return _custoreptabant;
        }
        set
        {
            PropriedadeModificada(RO_CUSTOREPTABANT, value);
            _custoreptabant = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Custorepzfm
    {
        get
        {
            PropriedadeAcessada(RO_CUSTOREPZFM);
            return _custorepzfm;
        }
        set
        {
            PropriedadeModificada(RO_CUSTOREPZFM, value);
            _custorepzfm = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Custorepzfmant
    {
        get
        {
            PropriedadeAcessada(RO_CUSTOREPZFMANT);
            return _custorepzfmant;
        }
        set
        {
            PropriedadeModificada(RO_CUSTOREPZFMANT, value);
            _custorepzfmant = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Custorepzfmtab
    {
        get
        {
            PropriedadeAcessada(RO_CUSTOREPZFMTAB);
            return _custorepzfmtab;
        }
        set
        {
            PropriedadeModificada(RO_CUSTOREPZFMTAB, value);
            _custorepzfmtab = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Binario, Tamanho = 4000, Precisao = 0)]
    public string Dadostecnicos
    {
        get
        {
            PropriedadeAcessada(RO_DADOSTECNICOS);
            return _dadostecnicos;
        }
        set
        {
            PropriedadeModificada(RO_DADOSTECNICOS, value);
            _dadostecnicos = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Datavocollect
    {
        get
        {
            PropriedadeAcessada(RO_DATAVOCOLLECT);
            return _datavocollect;
        }
        set
        {
            PropriedadeModificada(RO_DATAVOCOLLECT, value);
            _datavocollect = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 10, Precisao = 0)]
    public string Denominacaocomunbrasileira
    {
        get
        {
            PropriedadeAcessada(RO_DENOMINACAOCOMUNBRASILEIRA);
            return _denominacaocomunbrasileira;
        }
        set
        {
            PropriedadeModificada(RO_DENOMINACAOCOMUNBRASILEIRA, value);
            _denominacaocomunbrasileira = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 100, Precisao = 0)]
    public string Densidade
    {
        get
        {
            PropriedadeAcessada(RO_DENSIDADE);
            return _densidade;
        }
        set
        {
            PropriedadeModificada(RO_DENSIDADE, value);
            _densidade = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 3, Precisao = 0)]
    public decimal? Deposito
    {
        get
        {
            PropriedadeAcessada(RO_DEPOSITO);
            return _deposito;
        }
        set
        {
            PropriedadeModificada(RO_DEPOSITO, value);
            _deposito = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 3, Precisao = 0)]
    public decimal? Depositocx
    {
        get
        {
            PropriedadeAcessada(RO_DEPOSITOCX);
            return _depositocx;
        }
        set
        {
            PropriedadeModificada(RO_DEPOSITOCX, value);
            _depositocx = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 60, Precisao = 0)]
    public string Descpapel
    {
        get
        {
            PropriedadeAcessada(RO_DESCPAPEL);
            return _descpapel;
        }
        set
        {
            PropriedadeModificada(RO_DESCPAPEL, value);
            _descpapel = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 45, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 45, Precisao = 0)]
    public string Descricao2
    {
        get
        {
            PropriedadeAcessada(RO_DESCRICAO2);
            return _descricao2;
        }
        set
        {
            PropriedadeModificada(RO_DESCRICAO2, value);
            _descricao2 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 45, Precisao = 0)]
    public string Descricao3
    {
        get
        {
            PropriedadeAcessada(RO_DESCRICAO3);
            return _descricao3;
        }
        set
        {
            PropriedadeModificada(RO_DESCRICAO3, value);
            _descricao3 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 45, Precisao = 0)]
    public string Descricao4
    {
        get
        {
            PropriedadeAcessada(RO_DESCRICAO4);
            return _descricao4;
        }
        set
        {
            PropriedadeModificada(RO_DESCRICAO4, value);
            _descricao4 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 45, Precisao = 0)]
    public string Descricao5
    {
        get
        {
            PropriedadeAcessada(RO_DESCRICAO5);
            return _descricao5;
        }
        set
        {
            PropriedadeModificada(RO_DESCRICAO5, value);
            _descricao5 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 45, Precisao = 0)]
    public string Descricao6
    {
        get
        {
            PropriedadeAcessada(RO_DESCRICAO6);
            return _descricao6;
        }
        set
        {
            PropriedadeModificada(RO_DESCRICAO6, value);
            _descricao6 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 45, Precisao = 0)]
    public string Descricao7
    {
        get
        {
            PropriedadeAcessada(RO_DESCRICAO7);
            return _descricao7;
        }
        set
        {
            PropriedadeModificada(RO_DESCRICAO7, value);
            _descricao7 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 100, Precisao = 0)]
    public string Desintegracao
    {
        get
        {
            PropriedadeAcessada(RO_DESINTEGRACAO);
            return _desintegracao;
        }
        set
        {
            PropriedadeModificada(RO_DESINTEGRACAO, value);
            _desintegracao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Destaquefichatecnica
    {
        get
        {
            PropriedadeAcessada(RO_DESTAQUEFICHATECNICA);
            return _destaquefichatecnica;
        }
        set
        {
            PropriedadeModificada(RO_DESTAQUEFICHATECNICA, value);
            _destaquefichatecnica = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 140, Precisao = 0)]
    public string Dirassinatura
    {
        get
        {
            PropriedadeAcessada(RO_DIRASSINATURA);
            return _dirassinatura;
        }
        set
        {
            PropriedadeModificada(RO_DIRASSINATURA, value);
            _dirassinatura = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 200, Precisao = 0)]
    public string Diretoriofotos
    {
        get
        {
            PropriedadeAcessada(RO_DIRETORIOFOTOS);
            return _diretoriofotos;
        }
        set
        {
            PropriedadeModificada(RO_DIRETORIOFOTOS, value);
            _diretoriofotos = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 100, Precisao = 0)]
    public string Dirfotoprod
    {
        get
        {
            PropriedadeAcessada(RO_DIRFOTOPROD);
            return _dirfotoprod;
        }
        set
        {
            PropriedadeModificada(RO_DIRFOTOPROD, value);
            _dirfotoprod = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 100, Precisao = 0)]
    public string Dissolucao
    {
        get
        {
            PropriedadeAcessada(RO_DISSOLUCAO);
            return _dissolucao;
        }
        set
        {
            PropriedadeModificada(RO_DISSOLUCAO, value);
            _dissolucao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 100, Precisao = 0)]
    public string Doseamento
    {
        get
        {
            PropriedadeAcessada(RO_DOSEAMENTO);
            return _doseamento;
        }
        set
        {
            PropriedadeModificada(RO_DOSEAMENTO, value);
            _doseamento = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtaltcustofornec
    {
        get
        {
            PropriedadeAcessada(RO_DTALTCUSTOFORNEC);
            return _dtaltcustofornec;
        }
        set
        {
            PropriedadeModificada(RO_DTALTCUSTOFORNEC, value);
            _dtaltcustofornec = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtcadastro
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Dtdolar
    {
        get
        {
            PropriedadeAcessada(RO_DTDOLAR);
            return _dtdolar;
        }
        set
        {
            PropriedadeModificada(RO_DTDOLAR, value);
            _dtdolar = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtinicontlote
    {
        get
        {
            PropriedadeAcessada(RO_DTINICONTLOTE);
            return _dtinicontlote;
        }
        set
        {
            PropriedadeModificada(RO_DTINICONTLOTE, value);
            _dtinicontlote = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtproxexpurgo
    {
        get
        {
            PropriedadeAcessada(RO_DTPROXEXPURGO);
            return _dtproxexpurgo;
        }
        set
        {
            PropriedadeModificada(RO_DTPROXEXPURGO, value);
            _dtproxexpurgo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtultaltcom
    {
        get
        {
            PropriedadeAcessada(RO_DTULTALTCOM);
            return _dtultaltcom;
        }
        set
        {
            PropriedadeModificada(RO_DTULTALTCOM, value);
            _dtultaltcom = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtultaltcustorep
    {
        get
        {
            PropriedadeAcessada(RO_DTULTALTCUSTOREP);
            return _dtultaltcustorep;
        }
        set
        {
            PropriedadeModificada(RO_DTULTALTCUSTOREP, value);
            _dtultaltcustorep = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtultexpurgo
    {
        get
        {
            PropriedadeAcessada(RO_DTULTEXPURGO);
            return _dtultexpurgo;
        }
        set
        {
            PropriedadeModificada(RO_DTULTEXPURGO, value);
            _dtultexpurgo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtvenc
    {
        get
        {
            PropriedadeAcessada(RO_DTVENC);
            return _dtvenc;
        }
        set
        {
            PropriedadeModificada(RO_DTVENC, value);
            _dtvenc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 2)]
    public decimal? Eficienciaoperacional
    {
        get
        {
            PropriedadeAcessada(RO_EFICIENCIAOPERACIONAL);
            return _eficienciaoperacional;
        }
        set
        {
            PropriedadeModificada(RO_EFICIENCIAOPERACIONAL, value);
            _eficienciaoperacional = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 12, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 12, Precisao = 0)]
    public string Embalagemct
    {
        get
        {
            PropriedadeAcessada(RO_EMBALAGEMCT);
            return _embalagemct;
        }
        set
        {
            PropriedadeModificada(RO_EMBALAGEMCT, value);
            _embalagemct = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 12, Precisao = 0)]
    public string Embalagemmaster
    {
        get
        {
            PropriedadeAcessada(RO_EMBALAGEMMASTER);
            return _embalagemmaster;
        }
        set
        {
            PropriedadeModificada(RO_EMBALAGEMMASTER, value);
            _embalagemmaster = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Enviainftecnicanfe
    {
        get
        {
            PropriedadeAcessada(RO_ENVIAINFTECNICANFE);
            return _enviainftecnicanfe;
        }
        set
        {
            PropriedadeModificada(RO_ENVIAINFTECNICANFE, value);
            _enviainftecnicanfe = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Enviarforcavendas
    {
        get
        {
            PropriedadeAcessada(RO_ENVIARFORCAVENDAS);
            return _enviarforcavendas;
        }
        set
        {
            PropriedadeModificada(RO_ENVIARFORCAVENDAS, value);
            _enviarforcavendas = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Enviasngpc
    {
        get
        {
            PropriedadeAcessada(RO_ENVIASNGPC);
            return _enviasngpc;
        }
        set
        {
            PropriedadeModificada(RO_ENVIASNGPC, value);
            _enviasngpc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Especificoatividadepr
    {
        get
        {
            PropriedadeAcessada(RO_ESPECIFICOATIVIDADEPR);
            return _especificoatividadepr;
        }
        set
        {
            PropriedadeModificada(RO_ESPECIFICOATIVIDADEPR, value);
            _especificoatividadepr = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 100, Precisao = 0)]
    public string Estfaureaus
    {
        get
        {
            PropriedadeAcessada(RO_ESTFAUREAUS);
            return _estfaureaus;
        }
        set
        {
            PropriedadeModificada(RO_ESTFAUREAUS, value);
            _estfaureaus = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Estoqueporlote
    {
        get
        {
            PropriedadeAcessada(RO_ESTOQUEPORLOTE);
            return _estoqueporlote;
        }
        set
        {
            PropriedadeModificada(RO_ESTOQUEPORLOTE, value);
            _estoqueporlote = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Ex_Analisedesc
    {
        get
        {
            PropriedadeAcessada(RO_EX_ANALISEDESC);
            return _ex_analisedesc;
        }
        set
        {
            PropriedadeModificada(RO_EX_ANALISEDESC, value);
            _ex_analisedesc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Ex_Boloresleveduras
    {
        get
        {
            PropriedadeAcessada(RO_EX_BOLORESLEVEDURAS);
            return _ex_boloresleveduras;
        }
        set
        {
            PropriedadeModificada(RO_EX_BOLORESLEVEDURAS, value);
            _ex_boloresleveduras = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Ex_Col95
    {
        get
        {
            PropriedadeAcessada(RO_EX_COL95);
            return _ex_col95;
        }
        set
        {
            PropriedadeModificada(RO_EX_COL95, value);
            _ex_col95 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Ex_Contmicrobiana
    {
        get
        {
            PropriedadeAcessada(RO_EX_CONTMICROBIANA);
            return _ex_contmicrobiana;
        }
        set
        {
            PropriedadeModificada(RO_EX_CONTMICROBIANA, value);
            _ex_contmicrobiana = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Ex_Densidade
    {
        get
        {
            PropriedadeAcessada(RO_EX_DENSIDADE);
            return _ex_densidade;
        }
        set
        {
            PropriedadeModificada(RO_EX_DENSIDADE, value);
            _ex_densidade = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Ex_Desintegracao
    {
        get
        {
            PropriedadeAcessada(RO_EX_DESINTEGRACAO);
            return _ex_desintegracao;
        }
        set
        {
            PropriedadeModificada(RO_EX_DESINTEGRACAO, value);
            _ex_desintegracao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Ex_Dissolucao
    {
        get
        {
            PropriedadeAcessada(RO_EX_DISSOLUCAO);
            return _ex_dissolucao;
        }
        set
        {
            PropriedadeModificada(RO_EX_DISSOLUCAO, value);
            _ex_dissolucao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Ex_Doseamento
    {
        get
        {
            PropriedadeAcessada(RO_EX_DOSEAMENTO);
            return _ex_doseamento;
        }
        set
        {
            PropriedadeModificada(RO_EX_DOSEAMENTO, value);
            _ex_doseamento = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Ex_Estfaureaus
    {
        get
        {
            PropriedadeAcessada(RO_EX_ESTFAUREAUS);
            return _ex_estfaureaus;
        }
        set
        {
            PropriedadeModificada(RO_EX_ESTFAUREAUS, value);
            _ex_estfaureaus = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Ex_Friabilidade
    {
        get
        {
            PropriedadeAcessada(RO_EX_FRIABILIDADE);
            return _ex_friabilidade;
        }
        set
        {
            PropriedadeModificada(RO_EX_FRIABILIDADE, value);
            _ex_friabilidade = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Ex_Identificacao
    {
        get
        {
            PropriedadeAcessada(RO_EX_IDENTIFICACAO);
            return _ex_identificacao;
        }
        set
        {
            PropriedadeModificada(RO_EX_IDENTIFICACAO, value);
            _ex_identificacao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Ex_Impureza
    {
        get
        {
            PropriedadeAcessada(RO_EX_IMPUREZA);
            return _ex_impureza;
        }
        set
        {
            PropriedadeModificada(RO_EX_IMPUREZA, value);
            _ex_impureza = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Ex_Lipideo
    {
        get
        {
            PropriedadeAcessada(RO_EX_LIPIDEO);
            return _ex_lipideo;
        }
        set
        {
            PropriedadeModificada(RO_EX_LIPIDEO, value);
            _ex_lipideo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Ex_Mofado
    {
        get
        {
            PropriedadeAcessada(RO_EX_MOFADO);
            return _ex_mofado;
        }
        set
        {
            PropriedadeModificada(RO_EX_MOFADO, value);
            _ex_mofado = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Ex_Pesqpatogenos
    {
        get
        {
            PropriedadeAcessada(RO_EX_PESQPATOGENOS);
            return _ex_pesqpatogenos;
        }
        set
        {
            PropriedadeModificada(RO_EX_PESQPATOGENOS, value);
            _ex_pesqpatogenos = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Ex_Ph
    {
        get
        {
            PropriedadeAcessada(RO_EX_PH);
            return _ex_ph;
        }
        set
        {
            PropriedadeModificada(RO_EX_PH, value);
            _ex_ph = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Exportabalanca
    {
        get
        {
            PropriedadeAcessada(RO_EXPORTABALANCA);
            return _exportabalanca;
        }
        set
        {
            PropriedadeModificada(RO_EXPORTABALANCA, value);
            _exportabalanca = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Ex_Proteina
    {
        get
        {
            PropriedadeAcessada(RO_EX_PROTEINA);
            return _ex_proteina;
        }
        set
        {
            PropriedadeModificada(RO_EX_PROTEINA, value);
            _ex_proteina = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Ex_Salmonela
    {
        get
        {
            PropriedadeAcessada(RO_EX_SALMONELA);
            return _ex_salmonela;
        }
        set
        {
            PropriedadeModificada(RO_EX_SALMONELA, value);
            _ex_salmonela = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 3, Precisao = 0)]
    public string Extipi
    {
        get
        {
            PropriedadeAcessada(RO_EXTIPI);
            return _extipi;
        }
        set
        {
            PropriedadeModificada(RO_EXTIPI, value);
            _extipi = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Ex_Totdefeito
    {
        get
        {
            PropriedadeAcessada(RO_EX_TOTDEFEITO);
            return _ex_totdefeito;
        }
        set
        {
            PropriedadeModificada(RO_EX_TOTDEFEITO, value);
            _ex_totdefeito = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Ex_Umidade
    {
        get
        {
            PropriedadeAcessada(RO_EX_UMIDADE);
            return _ex_umidade;
        }
        set
        {
            PropriedadeModificada(RO_EX_UMIDADE, value);
            _ex_umidade = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Ex_Uniformidade
    {
        get
        {
            PropriedadeAcessada(RO_EX_UNIFORMIDADE);
            return _ex_uniformidade;
        }
        set
        {
            PropriedadeModificada(RO_EX_UNIFORMIDADE, value);
            _ex_uniformidade = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Ex_Vlcalorico
    {
        get
        {
            PropriedadeAcessada(RO_EX_VLCALORICO);
            return _ex_vlcalorico;
        }
        set
        {
            PropriedadeModificada(RO_EX_VLCALORICO, value);
            _ex_vlcalorico = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Ex_Volpesmed
    {
        get
        {
            PropriedadeAcessada(RO_EX_VOLPESMED);
            return _ex_volpesmed;
        }
        set
        {
            PropriedadeModificada(RO_EX_VOLPESMED, value);
            _ex_volpesmed = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 3)]
    public decimal? Fatorconversaokg
    {
        get
        {
            PropriedadeAcessada(RO_FATORCONVERSAOKG);
            return _fatorconversaokg;
        }
        set
        {
            PropriedadeModificada(RO_FATORCONVERSAOKG, value);
            _fatorconversaokg = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 6)]
    public decimal? Fatorconversaonestle
    {
        get
        {
            PropriedadeAcessada(RO_FATORCONVERSAONESTLE);
            return _fatorconversaonestle;
        }
        set
        {
            PropriedadeModificada(RO_FATORCONVERSAONESTLE, value);
            _fatorconversaonestle = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Fatortransf
    {
        get
        {
            PropriedadeAcessada(RO_FATORTRANSF);
            return _fatortransf;
        }
        set
        {
            PropriedadeModificada(RO_FATORTRANSF, value);
            _fatortransf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Fatorunfarm
    {
        get
        {
            PropriedadeAcessada(RO_FATORUNFARM);
            return _fatorunfarm;
        }
        set
        {
            PropriedadeModificada(RO_FATORUNFARM, value);
            _fatorunfarm = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Flags
    {
        get
        {
            PropriedadeAcessada(RO_FLAGS);
            return _flags;
        }
        set
        {
            PropriedadeModificada(RO_FLAGS, value);
            _flags = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Flag0
    {
        get
        {
            PropriedadeAcessada(RO_FLAG0);
            return _flag0;
        }
        set
        {
            PropriedadeModificada(RO_FLAG0, value);
            _flag0 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Flag1
    {
        get
        {
            PropriedadeAcessada(RO_FLAG1);
            return _flag1;
        }
        set
        {
            PropriedadeModificada(RO_FLAG1, value);
            _flag1 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Flag2
    {
        get
        {
            PropriedadeAcessada(RO_FLAG2);
            return _flag2;
        }
        set
        {
            PropriedadeModificada(RO_FLAG2, value);
            _flag2 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Folharosto
    {
        get
        {
            PropriedadeAcessada(RO_FOLHAROSTO);
            return _folharosto;
        }
        set
        {
            PropriedadeModificada(RO_FOLHAROSTO, value);
            _folharosto = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Fracaocipa
    {
        get
        {
            PropriedadeAcessada(RO_FRACAOCIPA);
            return _fracaocipa;
        }
        set
        {
            PropriedadeModificada(RO_FRACAOCIPA, value);
            _fracaocipa = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 20, Precisao = 8)]
    public decimal? Fracaoseparacao
    {
        get
        {
            PropriedadeAcessada(RO_FRACAOSEPARACAO);
            return _fracaoseparacao;
        }
        set
        {
            PropriedadeModificada(RO_FRACAOSEPARACAO, value);
            _fracaoseparacao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Fracionado
    {
        get
        {
            PropriedadeAcessada(RO_FRACIONADO);
            return _fracionado;
        }
        set
        {
            PropriedadeModificada(RO_FRACIONADO, value);
            _fracionado = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Freteespecial
    {
        get
        {
            PropriedadeAcessada(RO_FRETEESPECIAL);
            return _freteespecial;
        }
        set
        {
            PropriedadeModificada(RO_FRETEESPECIAL, value);
            _freteespecial = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 100, Precisao = 0)]
    public string Friabilidade
    {
        get
        {
            PropriedadeAcessada(RO_FRIABILIDADE);
            return _friabilidade;
        }
        set
        {
            PropriedadeModificada(RO_FRIABILIDADE, value);
            _friabilidade = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Geraicmslivrofiscaldevfornec
    {
        get
        {
            PropriedadeAcessada(RO_GERAICMSLIVROFISCALDEVFORNEC);
            return _geraicmslivrofiscaldevfornec;
        }
        set
        {
            PropriedadeModificada(RO_GERAICMSLIVROFISCALDEVFORNEC, value);
            _geraicmslivrofiscaldevfornec = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Geraosautomatic
    {
        get
        {
            PropriedadeAcessada(RO_GERAOSAUTOMATIC);
            return _geraosautomatic;
        }
        set
        {
            PropriedadeModificada(RO_GERAOSAUTOMATIC, value);
            _geraosautomatic = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 7, Precisao = 3)]
    public decimal? Gramatura
    {
        get
        {
            PropriedadeAcessada(RO_GRAMATURA);
            return _gramatura;
        }
        set
        {
            PropriedadeModificada(RO_GRAMATURA, value);
            _gramatura = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Grupofaturamento
    {
        get
        {
            PropriedadeAcessada(RO_GRUPOFATURAMENTO);
            return _grupofaturamento;
        }
        set
        {
            PropriedadeModificada(RO_GRUPOFATURAMENTO, value);
            _grupofaturamento = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 2, Precisao = 0)]
    public decimal? Gtincodauxiliar
    {
        get
        {
            PropriedadeAcessada(RO_GTINCODAUXILIAR);
            return _gtincodauxiliar;
        }
        set
        {
            PropriedadeModificada(RO_GTINCODAUXILIAR, value);
            _gtincodauxiliar = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 2, Precisao = 0)]
    public decimal? Gtincodauxiliar2
    {
        get
        {
            PropriedadeAcessada(RO_GTINCODAUXILIAR2);
            return _gtincodauxiliar2;
        }
        set
        {
            PropriedadeModificada(RO_GTINCODAUXILIAR2, value);
            _gtincodauxiliar2 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 2)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 100, Precisao = 0)]
    public string Identificacao
    {
        get
        {
            PropriedadeAcessada(RO_IDENTIFICACAO);
            return _identificacao;
        }
        set
        {
            PropriedadeModificada(RO_IDENTIFICACAO, value);
            _identificacao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 100, Precisao = 0)]
    public string Impureza
    {
        get
        {
            PropriedadeAcessada(RO_IMPUREZA);
            return _impureza;
        }
        set
        {
            PropriedadeModificada(RO_IMPUREZA, value);
            _impureza = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Imunetrib
    {
        get
        {
            PropriedadeAcessada(RO_IMUNETRIB);
            return _imunetrib;
        }
        set
        {
            PropriedadeModificada(RO_IMUNETRIB, value);
            _imunetrib = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 500, Precisao = 0)]
    public string Informacoestecnicas
    {
        get
        {
            PropriedadeAcessada(RO_INFORMACOESTECNICAS);
            return _informacoestecnicas;
        }
        set
        {
            PropriedadeModificada(RO_INFORMACOESTECNICAS, value);
            _informacoestecnicas = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Inventarioparcial
    {
        get
        {
            PropriedadeAcessada(RO_INVENTARIOPARCIAL);
            return _inventarioparcial;
        }
        set
        {
            PropriedadeModificada(RO_INVENTARIOPARCIAL, value);
            _inventarioparcial = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Ipiporvalor
    {
        get
        {
            PropriedadeAcessada(RO_IPIPORVALOR);
            return _ipiporvalor;
        }
        set
        {
            PropriedadeModificada(RO_IPIPORVALOR, value);
            _ipiporvalor = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 2)]
    public decimal? Irretido
    {
        get
        {
            PropriedadeAcessada(RO_IRRETIDO);
            return _irretido;
        }
        set
        {
            PropriedadeModificada(RO_IRRETIDO, value);
            _irretido = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Isentoregms
    {
        get
        {
            PropriedadeAcessada(RO_ISENTOREGMS);
            return _isentoregms;
        }
        set
        {
            PropriedadeModificada(RO_ISENTOREGMS, value);
            _isentoregms = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 2)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 6)]
    public decimal? Larguraarm
    {
        get
        {
            PropriedadeAcessada(RO_LARGURAARM);
            return _larguraarm;
        }
        set
        {
            PropriedadeModificada(RO_LARGURAARM, value);
            _larguraarm = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 6)]
    public decimal? Larguram3
    {
        get
        {
            PropriedadeAcessada(RO_LARGURAM3);
            return _larguram3;
        }
        set
        {
            PropriedadeModificada(RO_LARGURAM3, value);
            _larguram3 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 4)]
    public decimal? Lastropal
    {
        get
        {
            PropriedadeAcessada(RO_LASTROPAL);
            return _lastropal;
        }
        set
        {
            PropriedadeModificada(RO_LASTROPAL, value);
            _lastropal = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Letrapagina
    {
        get
        {
            PropriedadeAcessada(RO_LETRAPAGINA);
            return _letrapagina;
        }
        set
        {
            PropriedadeModificada(RO_LETRAPAGINA, value);
            _letrapagina = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Linhaprod
    {
        get
        {
            PropriedadeAcessada(RO_LINHAPROD);
            return _linhaprod;
        }
        set
        {
            PropriedadeModificada(RO_LINHAPROD, value);
            _linhaprod = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 100, Precisao = 0)]
    public string Lipideo
    {
        get
        {
            PropriedadeAcessada(RO_LIPIDEO);
            return _lipideo;
        }
        set
        {
            PropriedadeModificada(RO_LIPIDEO, value);
            _lipideo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Litragem
    {
        get
        {
            PropriedadeAcessada(RO_LITRAGEM);
            return _litragem;
        }
        set
        {
            PropriedadeModificada(RO_LITRAGEM, value);
            _litragem = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 2)]
    public decimal? Loteinccompra
    {
        get
        {
            PropriedadeAcessada(RO_LOTEINCCOMPRA);
            return _loteinccompra;
        }
        set
        {
            PropriedadeModificada(RO_LOTEINCCOMPRA, value);
            _loteinccompra = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 2)]
    public decimal? Lotemincompra
    {
        get
        {
            PropriedadeAcessada(RO_LOTEMINCOMPRA);
            return _lotemincompra;
        }
        set
        {
            PropriedadeModificada(RO_LOTEMINCOMPRA, value);
            _lotemincompra = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 2)]
    public decimal? Loteproducao
    {
        get
        {
            PropriedadeAcessada(RO_LOTEPRODUCAO);
            return _loteproducao;
        }
        set
        {
            PropriedadeModificada(RO_LOTEPRODUCAO, value);
            _loteproducao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
    public string Marca
    {
        get
        {
            PropriedadeAcessada(RO_MARCA);
            return _marca;
        }
        set
        {
            PropriedadeModificada(RO_MARCA, value);
            _marca = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 2)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Medcodfunclibvenda
    {
        get
        {
            PropriedadeAcessada(RO_MEDCODFUNCLIBVENDA);
            return _medcodfunclibvenda;
        }
        set
        {
            PropriedadeModificada(RO_MEDCODFUNCLIBVENDA, value);
            _medcodfunclibvenda = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Meddtlibvenda
    {
        get
        {
            PropriedadeAcessada(RO_MEDDTLIBVENDA);
            return _meddtlibvenda;
        }
        set
        {
            PropriedadeModificada(RO_MEDDTLIBVENDA, value);
            _meddtlibvenda = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Medicamentohospitalar
    {
        get
        {
            PropriedadeAcessada(RO_MEDICAMENTOHOSPITALAR);
            return _medicamentohospitalar;
        }
        set
        {
            PropriedadeModificada(RO_MEDICAMENTOHOSPITALAR, value);
            _medicamentohospitalar = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 6)]
    public decimal? Mexfpgc
    {
        get
        {
            PropriedadeAcessada(RO_MEXFPGC);
            return _mexfpgc;
        }
        set
        {
            PropriedadeModificada(RO_MEXFPGC, value);
            _mexfpgc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 6)]
    public decimal? Mexieps
    {
        get
        {
            PropriedadeAcessada(RO_MEXIEPS);
            return _mexieps;
        }
        set
        {
            PropriedadeModificada(RO_MEXIEPS, value);
            _mexieps = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 6)]
    public decimal? Mexiva
    {
        get
        {
            PropriedadeAcessada(RO_MEXIVA);
            return _mexiva;
        }
        set
        {
            PropriedadeModificada(RO_MEXIVA, value);
            _mexiva = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 2, Precisao = 0)]
    public decimal? Modulo
    {
        get
        {
            PropriedadeAcessada(RO_MODULO);
            return _modulo;
        }
        set
        {
            PropriedadeModificada(RO_MODULO, value);
            _modulo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 2, Precisao = 0)]
    public decimal? Moduloct
    {
        get
        {
            PropriedadeAcessada(RO_MODULOCT);
            return _moduloct;
        }
        set
        {
            PropriedadeModificada(RO_MODULOCT, value);
            _moduloct = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 2, Precisao = 0)]
    public decimal? Modulocx
    {
        get
        {
            PropriedadeAcessada(RO_MODULOCX);
            return _modulocx;
        }
        set
        {
            PropriedadeModificada(RO_MODULOCX, value);
            _modulocx = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 2, Precisao = 0)]
    public decimal? Modulo2
    {
        get
        {
            PropriedadeAcessada(RO_MODULO2);
            return _modulo2;
        }
        set
        {
            PropriedadeModificada(RO_MODULO2, value);
            _modulo2 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Moeda
    {
        get
        {
            PropriedadeAcessada(RO_MOEDA);
            return _moeda;
        }
        set
        {
            PropriedadeModificada(RO_MOEDA, value);
            _moeda = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 100, Precisao = 0)]
    public string Mofado
    {
        get
        {
            PropriedadeAcessada(RO_MOFADO);
            return _mofado;
        }
        set
        {
            PropriedadeModificada(RO_MOFADO, value);
            _mofado = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Multiplo
    {
        get
        {
            PropriedadeAcessada(RO_MULTIPLO);
            return _multiplo;
        }
        set
        {
            PropriedadeModificada(RO_MULTIPLO, value);
            _multiplo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Multiplo2
    {
        get
        {
            PropriedadeAcessada(RO_MULTIPLO2);
            return _multiplo2;
        }
        set
        {
            PropriedadeModificada(RO_MULTIPLO2, value);
            _multiplo2 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Naturezaproduto
    {
        get
        {
            PropriedadeAcessada(RO_NATUREZAPRODUTO);
            return _naturezaproduto;
        }
        set
        {
            PropriedadeModificada(RO_NATUREZAPRODUTO, value);
            _naturezaproduto = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 15, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 3, Precisao = 0)]
    public decimal? Nivel
    {
        get
        {
            PropriedadeAcessada(RO_NIVEL);
            return _nivel;
        }
        set
        {
            PropriedadeModificada(RO_NIVEL, value);
            _nivel = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 3, Precisao = 0)]
    public decimal? Nivelcx
    {
        get
        {
            PropriedadeAcessada(RO_NIVELCX);
            return _nivelcx;
        }
        set
        {
            PropriedadeModificada(RO_NIVELCX, value);
            _nivelcx = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 100, Precisao = 0)]
    public string Nomecomercial
    {
        get
        {
            PropriedadeAcessada(RO_NOMECOMERCIAL);
            return _nomecomercial;
        }
        set
        {
            PropriedadeModificada(RO_NOMECOMERCIAL, value);
            _nomecomercial = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 200, Precisao = 0)]
    public string Nomeecommerce
    {
        get
        {
            PropriedadeAcessada(RO_NOMEECOMMERCE);
            return _nomeecommerce;
        }
        set
        {
            PropriedadeModificada(RO_NOMEECOMMERCE, value);
            _nomeecommerce = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 10, Precisao = 0)]
    public string Normafornecedor
    {
        get
        {
            PropriedadeAcessada(RO_NORMAFORNECEDOR);
            return _normafornecedor;
        }
        set
        {
            PropriedadeModificada(RO_NORMAFORNECEDOR, value);
            _normafornecedor = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Normapalete
    {
        get
        {
            PropriedadeAcessada(RO_NORMAPALETE);
            return _normapalete;
        }
        set
        {
            PropriedadeModificada(RO_NORMAPALETE, value);
            _normapalete = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 2, Precisao = 0)]
    public decimal? Numcasasdecreducaoicms
    {
        get
        {
            PropriedadeAcessada(RO_NUMCASASDECREDUCAOICMS);
            return _numcasasdecreducaoicms;
        }
        set
        {
            PropriedadeModificada(RO_NUMCASASDECREDUCAOICMS, value);
            _numcasasdecreducaoicms = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 3, Precisao = 0)]
    public decimal? Numdiasmaxvenda
    {
        get
        {
            PropriedadeAcessada(RO_NUMDIASMAXVENDA);
            return _numdiasmaxvenda;
        }
        set
        {
            PropriedadeModificada(RO_NUMDIASMAXVENDA, value);
            _numdiasmaxvenda = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Numdiasvalidademin
    {
        get
        {
            PropriedadeAcessada(RO_NUMDIASVALIDADEMIN);
            return _numdiasvalidademin;
        }
        set
        {
            PropriedadeModificada(RO_NUMDIASVALIDADEMIN, value);
            _numdiasvalidademin = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 2)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 2)]
    public decimal? Numeroct
    {
        get
        {
            PropriedadeAcessada(RO_NUMEROCT);
            return _numeroct;
        }
        set
        {
            PropriedadeModificada(RO_NUMEROCT, value);
            _numeroct = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 2)]
    public decimal? Numerocx
    {
        get
        {
            PropriedadeAcessada(RO_NUMEROCX);
            return _numerocx;
        }
        set
        {
            PropriedadeModificada(RO_NUMEROCX, value);
            _numerocx = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 2)]
    public decimal? Numero2
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Numlistainventrot
    {
        get
        {
            PropriedadeAcessada(RO_NUMLISTAINVENTROT);
            return _numlistainventrot;
        }
        set
        {
            PropriedadeModificada(RO_NUMLISTAINVENTROT, value);
            _numlistainventrot = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
    public string Numoriginal
    {
        get
        {
            PropriedadeAcessada(RO_NUMORIGINAL);
            return _numoriginal;
        }
        set
        {
            PropriedadeModificada(RO_NUMORIGINAL, value);
            _numoriginal = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Numpag
    {
        get
        {
            PropriedadeAcessada(RO_NUMPAG);
            return _numpag;
        }
        set
        {
            PropriedadeModificada(RO_NUMPAG, value);
            _numpag = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 0, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Numseqinventrot
    {
        get
        {
            PropriedadeAcessada(RO_NUMSEQINVENTROT);
            return _numseqinventrot;
        }
        set
        {
            PropriedadeModificada(RO_NUMSEQINVENTROT, value);
            _numseqinventrot = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Numservico
    {
        get
        {
            PropriedadeAcessada(RO_NUMSERVICO);
            return _numservico;
        }
        set
        {
            PropriedadeModificada(RO_NUMSERVICO, value);
            _numservico = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numultexpurgo
    {
        get
        {
            PropriedadeAcessada(RO_NUMULTEXPURGO);
            return _numultexpurgo;
        }
        set
        {
            PropriedadeModificada(RO_NUMULTEXPURGO, value);
            _numultexpurgo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Obrigapreenccontrato
    {
        get
        {
            PropriedadeAcessada(RO_OBRIGAPREENCCONTRATO);
            return _obrigapreenccontrato;
        }
        set
        {
            PropriedadeModificada(RO_OBRIGAPREENCCONTRATO, value);
            _obrigapreenccontrato = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Oscomodato
    {
        get
        {
            PropriedadeAcessada(RO_OSCOMODATO);
            return _oscomodato;
        }
        set
        {
            PropriedadeModificada(RO_OSCOMODATO, value);
            _oscomodato = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
    public string Paisorigem
    {
        get
        {
            PropriedadeAcessada(RO_PAISORIGEM);
            return _paisorigem;
        }
        set
        {
            PropriedadeModificada(RO_PAISORIGEM, value);
            _paisorigem = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Pckrotativo
    {
        get
        {
            PropriedadeAcessada(RO_PCKROTATIVO);
            return _pckrotativo;
        }
        set
        {
            PropriedadeModificada(RO_PCKROTATIVO, value);
            _pckrotativo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 2)]
    public decimal? Pcomext1
    {
        get
        {
            PropriedadeAcessada(RO_PCOMEXT1);
            return _pcomext1;
        }
        set
        {
            PropriedadeModificada(RO_PCOMEXT1, value);
            _pcomext1 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 2)]
    public decimal? Pcomint1
    {
        get
        {
            PropriedadeAcessada(RO_PCOMINT1);
            return _pcomint1;
        }
        set
        {
            PropriedadeModificada(RO_PCOMINT1, value);
            _pcomint1 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 2)]
    public decimal? Pcomprof1
    {
        get
        {
            PropriedadeAcessada(RO_PCOMPROF1);
            return _pcomprof1;
        }
        set
        {
            PropriedadeModificada(RO_PCOMPROF1, value);
            _pcomprof1 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 2)]
    public decimal? Pcomrep1
    {
        get
        {
            PropriedadeAcessada(RO_PCOMREP1);
            return _pcomrep1;
        }
        set
        {
            PropriedadeModificada(RO_PCOMREP1, value);
            _pcomrep1 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 2)]
    public decimal? Pcomtlmkt
    {
        get
        {
            PropriedadeAcessada(RO_PCOMTLMKT);
            return _pcomtlmkt;
        }
        set
        {
            PropriedadeModificada(RO_PCOMTLMKT, value);
            _pcomtlmkt = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 6)]
    public decimal? Percacres
    {
        get
        {
            PropriedadeAcessada(RO_PERCACRES);
            return _percacres;
        }
        set
        {
            PropriedadeModificada(RO_PERCACRES, value);
            _percacres = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 2)]
    public decimal? Percaliqcredicmsdiferest
    {
        get
        {
            PropriedadeAcessada(RO_PERCALIQCREDICMSDIFEREST);
            return _percaliqcredicmsdiferest;
        }
        set
        {
            PropriedadeModificada(RO_PERCALIQCREDICMSDIFEREST, value);
            _percaliqcredicmsdiferest = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 2)]
    public decimal? Percaliqcredicmsdiferinter
    {
        get
        {
            PropriedadeAcessada(RO_PERCALIQCREDICMSDIFERINTER);
            return _percaliqcredicmsdiferinter;
        }
        set
        {
            PropriedadeModificada(RO_PERCALIQCREDICMSDIFERINTER, value);
            _percaliqcredicmsdiferinter = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Percaliqext
    {
        get
        {
            PropriedadeAcessada(RO_PERCALIQEXT);
            return _percaliqext;
        }
        set
        {
            PropriedadeModificada(RO_PERCALIQEXT, value);
            _percaliqext = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 2)]
    public decimal? Percaliqextbcr
    {
        get
        {
            PropriedadeAcessada(RO_PERCALIQEXTBCR);
            return _percaliqextbcr;
        }
        set
        {
            PropriedadeModificada(RO_PERCALIQEXTBCR, value);
            _percaliqextbcr = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Percaliqint
    {
        get
        {
            PropriedadeAcessada(RO_PERCALIQINT);
            return _percaliqint;
        }
        set
        {
            PropriedadeModificada(RO_PERCALIQINT, value);
            _percaliqint = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 2)]
    public decimal? Percaliqintbcr
    {
        get
        {
            PropriedadeAcessada(RO_PERCALIQINTBCR);
            return _percaliqintbcr;
        }
        set
        {
            PropriedadeModificada(RO_PERCALIQINTBCR, value);
            _percaliqintbcr = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 4)]
    public decimal? Percbaseredent
    {
        get
        {
            PropriedadeAcessada(RO_PERCBASEREDENT);
            return _percbaseredent;
        }
        set
        {
            PropriedadeModificada(RO_PERCBASEREDENT, value);
            _percbaseredent = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 2)]
    public decimal? Percbonificvenda
    {
        get
        {
            PropriedadeAcessada(RO_PERCBONIFICVENDA);
            return _percbonificvenda;
        }
        set
        {
            PropriedadeModificada(RO_PERCBONIFICVENDA, value);
            _percbonificvenda = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Perccargatribmedia
    {
        get
        {
            PropriedadeAcessada(RO_PERCCARGATRIBMEDIA);
            return _perccargatribmedia;
        }
        set
        {
            PropriedadeModificada(RO_PERCCARGATRIBMEDIA, value);
            _perccargatribmedia = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 2)]
    public decimal? Perccommot
    {
        get
        {
            PropriedadeAcessada(RO_PERCCOMMOT);
            return _perccommot;
        }
        set
        {
            PropriedadeModificada(RO_PERCCOMMOT, value);
            _perccommot = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 6)]
    public decimal? Percdescicms
    {
        get
        {
            PropriedadeAcessada(RO_PERCDESCICMS);
            return _percdescicms;
        }
        set
        {
            PropriedadeModificada(RO_PERCDESCICMS, value);
            _percdescicms = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Percdesc1
    {
        get
        {
            PropriedadeAcessada(RO_PERCDESC1);
            return _percdesc1;
        }
        set
        {
            PropriedadeModificada(RO_PERCDESC1, value);
            _percdesc1 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Percdesc10
    {
        get
        {
            PropriedadeAcessada(RO_PERCDESC10);
            return _percdesc10;
        }
        set
        {
            PropriedadeModificada(RO_PERCDESC10, value);
            _percdesc10 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Percdesc2
    {
        get
        {
            PropriedadeAcessada(RO_PERCDESC2);
            return _percdesc2;
        }
        set
        {
            PropriedadeModificada(RO_PERCDESC2, value);
            _percdesc2 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Percdesc3
    {
        get
        {
            PropriedadeAcessada(RO_PERCDESC3);
            return _percdesc3;
        }
        set
        {
            PropriedadeModificada(RO_PERCDESC3, value);
            _percdesc3 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Percdesc4
    {
        get
        {
            PropriedadeAcessada(RO_PERCDESC4);
            return _percdesc4;
        }
        set
        {
            PropriedadeModificada(RO_PERCDESC4, value);
            _percdesc4 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Percdesc5
    {
        get
        {
            PropriedadeAcessada(RO_PERCDESC5);
            return _percdesc5;
        }
        set
        {
            PropriedadeModificada(RO_PERCDESC5, value);
            _percdesc5 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Percdesc6
    {
        get
        {
            PropriedadeAcessada(RO_PERCDESC6);
            return _percdesc6;
        }
        set
        {
            PropriedadeModificada(RO_PERCDESC6, value);
            _percdesc6 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Percdesc7
    {
        get
        {
            PropriedadeAcessada(RO_PERCDESC7);
            return _percdesc7;
        }
        set
        {
            PropriedadeModificada(RO_PERCDESC7, value);
            _percdesc7 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Percdesc8
    {
        get
        {
            PropriedadeAcessada(RO_PERCDESC8);
            return _percdesc8;
        }
        set
        {
            PropriedadeModificada(RO_PERCDESC8, value);
            _percdesc8 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Percdesc9
    {
        get
        {
            PropriedadeAcessada(RO_PERCDESC9);
            return _percdesc9;
        }
        set
        {
            PropriedadeModificada(RO_PERCDESC9, value);
            _percdesc9 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Percdiferencakgfrio
    {
        get
        {
            PropriedadeAcessada(RO_PERCDIFERENCAKGFRIO);
            return _percdiferencakgfrio;
        }
        set
        {
            PropriedadeModificada(RO_PERCDIFERENCAKGFRIO, value);
            _percdiferencakgfrio = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Percicmsfretefobstbcr
    {
        get
        {
            PropriedadeAcessada(RO_PERCICMSFRETEFOBSTBCR);
            return _percicmsfretefobstbcr;
        }
        set
        {
            PropriedadeModificada(RO_PERCICMSFRETEFOBSTBCR, value);
            _percicmsfretefobstbcr = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 2)]
    public decimal? Percipivenda
    {
        get
        {
            PropriedadeAcessada(RO_PERCIPIVENDA);
            return _percipivenda;
        }
        set
        {
            PropriedadeModificada(RO_PERCIPIVENDA, value);
            _percipivenda = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 2)]
    public decimal? Percipivendatab
    {
        get
        {
            PropriedadeAcessada(RO_PERCIPIVENDATAB);
            return _percipivendatab;
        }
        set
        {
            PropriedadeModificada(RO_PERCIPIVENDATAB, value);
            _percipivendatab = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 2)]
    public decimal? Percivabcr
    {
        get
        {
            PropriedadeAcessada(RO_PERCIVABCR);
            return _percivabcr;
        }
        set
        {
            PropriedadeModificada(RO_PERCIVABCR, value);
            _percivabcr = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 2)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Percmvaorig
    {
        get
        {
            PropriedadeAcessada(RO_PERCMVAORIG);
            return _percmvaorig;
        }
        set
        {
            PropriedadeModificada(RO_PERCMVAORIG, value);
            _percmvaorig = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 2)]
    public decimal? Percofinsimp
    {
        get
        {
            PropriedadeAcessada(RO_PERCOFINSIMP);
            return _percofinsimp;
        }
        set
        {
            PropriedadeModificada(RO_PERCOFINSIMP, value);
            _percofinsimp = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Percperdakg
    {
        get
        {
            PropriedadeAcessada(RO_PERCPERDAKG);
            return _percperdakg;
        }
        set
        {
            PropriedadeModificada(RO_PERCPERDAKG, value);
            _percperdakg = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Percquebraproducao
    {
        get
        {
            PropriedadeAcessada(RO_PERCQUEBRAPRODUCAO);
            return _percquebraproducao;
        }
        set
        {
            PropriedadeModificada(RO_PERCQUEBRAPRODUCAO, value);
            _percquebraproducao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Percredpmc
    {
        get
        {
            PropriedadeAcessada(RO_PERCREDPMC);
            return _percredpmc;
        }
        set
        {
            PropriedadeModificada(RO_PERCREDPMC, value);
            _percredpmc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 3)]
    public decimal? Perctoleranciaval
    {
        get
        {
            PropriedadeAcessada(RO_PERCTOLERANCIAVAL);
            return _perctoleranciaval;
        }
        set
        {
            PropriedadeModificada(RO_PERCTOLERANCIAVAL, value);
            _perctoleranciaval = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 2)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 2)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 2)]
    public decimal? Perindeniz
    {
        get
        {
            PropriedadeAcessada(RO_PERINDENIZ);
            return _perindeniz;
        }
        set
        {
            PropriedadeModificada(RO_PERINDENIZ, value);
            _perindeniz = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Permiteproducao
    {
        get
        {
            PropriedadeAcessada(RO_PERMITEPRODUCAO);
            return _permiteproducao;
        }
        set
        {
            PropriedadeModificada(RO_PERMITEPRODUCAO, value);
            _permiteproducao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 2)]
    public decimal? Perpisimp
    {
        get
        {
            PropriedadeAcessada(RO_PERPISIMP);
            return _perpisimp;
        }
        set
        {
            PropriedadeModificada(RO_PERPISIMP, value);
            _perpisimp = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 3)]
    public decimal? Pesobrutomaster
    {
        get
        {
            PropriedadeAcessada(RO_PESOBRUTOMASTER);
            return _pesobrutomaster;
        }
        set
        {
            PropriedadeModificada(RO_PESOBRUTOMASTER, value);
            _pesobrutomaster = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 7)]
    public decimal? Pesoembalagem
    {
        get
        {
            PropriedadeAcessada(RO_PESOEMBALAGEM);
            return _pesoembalagem;
        }
        set
        {
            PropriedadeModificada(RO_PESOEMBALAGEM, value);
            _pesoembalagem = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 3)]
    public decimal? Pesoliqmaster
    {
        get
        {
            PropriedadeAcessada(RO_PESOLIQMASTER);
            return _pesoliqmaster;
        }
        set
        {
            PropriedadeModificada(RO_PESOLIQMASTER, value);
            _pesoliqmaster = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 6)]
    public decimal? Pesopalete
    {
        get
        {
            PropriedadeAcessada(RO_PESOPALETE);
            return _pesopalete;
        }
        set
        {
            PropriedadeModificada(RO_PESOPALETE, value);
            _pesopalete = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 20, Precisao = 8)]
    public decimal? Pesopeca
    {
        get
        {
            PropriedadeAcessada(RO_PESOPECA);
            return _pesopeca;
        }
        set
        {
            PropriedadeModificada(RO_PESOPECA, value);
            _pesopeca = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Pesovariavel
    {
        get
        {
            PropriedadeAcessada(RO_PESOVARIAVEL);
            return _pesovariavel;
        }
        set
        {
            PropriedadeModificada(RO_PESOVARIAVEL, value);
            _pesovariavel = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 100, Precisao = 0)]
    public string Pesqpatogenos
    {
        get
        {
            PropriedadeAcessada(RO_PESQPATOGENOS);
            return _pesqpatogenos;
        }
        set
        {
            PropriedadeModificada(RO_PESQPATOGENOS, value);
            _pesqpatogenos = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 100, Precisao = 0)]
    public string Ph
    {
        get
        {
            PropriedadeAcessada(RO_PH);
            return _ph;
        }
        set
        {
            PropriedadeModificada(RO_PH, value);
            _ph = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 2)]
    public decimal? Pisretido
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 2)]
    public decimal? Pontoreposicao
    {
        get
        {
            PropriedadeAcessada(RO_PONTOREPOSICAO);
            return _pontoreposicao;
        }
        set
        {
            PropriedadeModificada(RO_PONTOREPOSICAO, value);
            _pontoreposicao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 2)]
    public decimal? Pontoreposicaoal
    {
        get
        {
            PropriedadeAcessada(RO_PONTOREPOSICAOAL);
            return _pontoreposicaoal;
        }
        set
        {
            PropriedadeModificada(RO_PONTOREPOSICAOAL, value);
            _pontoreposicaoal = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 2)]
    public decimal? Pontoreposicaocx
    {
        get
        {
            PropriedadeAcessada(RO_PONTOREPOSICAOCX);
            return _pontoreposicaocx;
        }
        set
        {
            PropriedadeModificada(RO_PONTOREPOSICAOCX, value);
            _pontoreposicaocx = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 2)]
    public decimal? Pontoreposicaopa
    {
        get
        {
            PropriedadeAcessada(RO_PONTOREPOSICAOPA);
            return _pontoreposicaopa;
        }
        set
        {
            PropriedadeModificada(RO_PONTOREPOSICAOPA, value);
            _pontoreposicaopa = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 3, Precisao = 0)]
    public decimal? Prazoentr
    {
        get
        {
            PropriedadeAcessada(RO_PRAZOENTR);
            return _prazoentr;
        }
        set
        {
            PropriedadeModificada(RO_PRAZOENTR, value);
            _prazoentr = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 3, Precisao = 0)]
    public decimal? Prazoexpurgo
    {
        get
        {
            PropriedadeAcessada(RO_PRAZOEXPURGO);
            return _prazoexpurgo;
        }
        set
        {
            PropriedadeModificada(RO_PRAZOEXPURGO, value);
            _prazoexpurgo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 0)]
    public decimal? Prazogarantia
    {
        get
        {
            PropriedadeAcessada(RO_PRAZOGARANTIA);
            return _prazogarantia;
        }
        set
        {
            PropriedadeModificada(RO_PRAZOGARANTIA, value);
            _prazogarantia = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 3, Precisao = 0)]
    public decimal? Prazomaxindenizacao
    {
        get
        {
            PropriedadeAcessada(RO_PRAZOMAXINDENIZACAO);
            return _prazomaxindenizacao;
        }
        set
        {
            PropriedadeModificada(RO_PRAZOMAXINDENIZACAO, value);
            _prazomaxindenizacao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 2)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 0)]
    public decimal? Prazomaxvenda
    {
        get
        {
            PropriedadeAcessada(RO_PRAZOMAXVENDA);
            return _prazomaxvenda;
        }
        set
        {
            PropriedadeModificada(RO_PRAZOMAXVENDA, value);
            _prazomaxvenda = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 0)]
    public decimal? Prazomedioproducao
    {
        get
        {
            PropriedadeAcessada(RO_PRAZOMEDIOPRODUCAO);
            return _prazomedioproducao;
        }
        set
        {
            PropriedadeModificada(RO_PRAZOMEDIOPRODUCAO, value);
            _prazomedioproducao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 0)]
    public decimal? Prazomediovenda
    {
        get
        {
            PropriedadeAcessada(RO_PRAZOMEDIOVENDA);
            return _prazomediovenda;
        }
        set
        {
            PropriedadeModificada(RO_PRAZOMEDIOVENDA, value);
            _prazomediovenda = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 2)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Prazoval
    {
        get
        {
            PropriedadeAcessada(RO_PRAZOVAL);
            return _prazoval;
        }
        set
        {
            PropriedadeModificada(RO_PRAZOVAL, value);
            _prazoval = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Precificestrangeira
    {
        get
        {
            PropriedadeAcessada(RO_PRECIFICESTRANGEIRA);
            return _precificestrangeira;
        }
        set
        {
            PropriedadeModificada(RO_PRECIFICESTRANGEIRA, value);
            _precificestrangeira = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Precofixo
    {
        get
        {
            PropriedadeAcessada(RO_PRECOFIXO);
            return _precofixo;
        }
        set
        {
            PropriedadeModificada(RO_PRECOFIXO, value);
            _precofixo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Precomaxconsum
    {
        get
        {
            PropriedadeAcessada(RO_PRECOMAXCONSUM);
            return _precomaxconsum;
        }
        set
        {
            PropriedadeModificada(RO_PRECOMAXCONSUM, value);
            _precomaxconsum = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Precomaxconsumtab
    {
        get
        {
            PropriedadeAcessada(RO_PRECOMAXCONSUMTAB);
            return _precomaxconsumtab;
        }
        set
        {
            PropriedadeModificada(RO_PRECOMAXCONSUMTAB, value);
            _precomaxconsumtab = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Precomaxconsumtabant
    {
        get
        {
            PropriedadeAcessada(RO_PRECOMAXCONSUMTABANT);
            return _precomaxconsumtabant;
        }
        set
        {
            PropriedadeModificada(RO_PRECOMAXCONSUMTABANT, value);
            _precomaxconsumtabant = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Precomaxconsumzfm
    {
        get
        {
            PropriedadeAcessada(RO_PRECOMAXCONSUMZFM);
            return _precomaxconsumzfm;
        }
        set
        {
            PropriedadeModificada(RO_PRECOMAXCONSUMZFM, value);
            _precomaxconsumzfm = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Precomaxconsumzfmant
    {
        get
        {
            PropriedadeAcessada(RO_PRECOMAXCONSUMZFMANT);
            return _precomaxconsumzfmant;
        }
        set
        {
            PropriedadeModificada(RO_PRECOMAXCONSUMZFMANT, value);
            _precomaxconsumzfmant = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Precomaxconsumzfmtab
    {
        get
        {
            PropriedadeAcessada(RO_PRECOMAXCONSUMZFMTAB);
            return _precomaxconsumzfmtab;
        }
        set
        {
            PropriedadeModificada(RO_PRECOMAXCONSUMZFMTAB, value);
            _precomaxconsumzfmtab = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 3, Precisao = 0)]
    public decimal? Predio
    {
        get
        {
            PropriedadeAcessada(RO_PREDIO);
            return _predio;
        }
        set
        {
            PropriedadeModificada(RO_PREDIO, value);
            _predio = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 3, Precisao = 0)]
    public decimal? Prediocx
    {
        get
        {
            PropriedadeAcessada(RO_PREDIOCX);
            return _prediocx;
        }
        set
        {
            PropriedadeModificada(RO_PREDIOCX, value);
            _prediocx = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 5, Precisao = 0)]
    public string Prefixolote
    {
        get
        {
            PropriedadeAcessada(RO_PREFIXOLOTE);
            return _prefixolote;
        }
        set
        {
            PropriedadeModificada(RO_PREFIXOLOTE, value);
            _prefixolote = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 100, Precisao = 0)]
    public string Principioativo
    {
        get
        {
            PropriedadeAcessada(RO_PRINCIPIOATIVO);
            return _principioativo;
        }
        set
        {
            PropriedadeModificada(RO_PRINCIPIOATIVO, value);
            _principioativo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 100, Precisao = 0)]
    public string Proteina
    {
        get
        {
            PropriedadeAcessada(RO_PROTEINA);
            return _proteina;
        }
        set
        {
            PropriedadeModificada(RO_PROTEINA, value);
            _proteina = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Psicotropico
    {
        get
        {
            PropriedadeAcessada(RO_PSICOTROPICO);
            return _psicotropico;
        }
        set
        {
            PropriedadeModificada(RO_PSICOTROPICO, value);
            _psicotropico = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 6)]
    public decimal? Ptabelafornec
    {
        get
        {
            PropriedadeAcessada(RO_PTABELAFORNEC);
            return _ptabelafornec;
        }
        set
        {
            PropriedadeModificada(RO_PTABELAFORNEC, value);
            _ptabelafornec = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 24, Precisao = 6)]
    public decimal? Pvenda
    {
        get
        {
            PropriedadeAcessada(RO_PVENDA);
            return _pvenda;
        }
        set
        {
            PropriedadeModificada(RO_PVENDA, value);
            _pvenda = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Qtdemaxseparpedido
    {
        get
        {
            PropriedadeAcessada(RO_QTDEMAXSEPARPEDIDO);
            return _qtdemaxseparpedido;
        }
        set
        {
            PropriedadeModificada(RO_QTDEMAXSEPARPEDIDO, value);
            _qtdemaxseparpedido = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Qtdmaxsepararpedido
    {
        get
        {
            PropriedadeAcessada(RO_QTDMAXSEPARARPEDIDO);
            return _qtdmaxsepararpedido;
        }
        set
        {
            PropriedadeModificada(RO_QTDMAXSEPARARPEDIDO, value);
            _qtdmaxsepararpedido = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Qtmaxgondula
    {
        get
        {
            PropriedadeAcessada(RO_QTMAXGONDULA);
            return _qtmaxgondula;
        }
        set
        {
            PropriedadeModificada(RO_QTMAXGONDULA, value);
            _qtmaxgondula = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Qtmetros
    {
        get
        {
            PropriedadeAcessada(RO_QTMETROS);
            return _qtmetros;
        }
        set
        {
            PropriedadeModificada(RO_QTMETROS, value);
            _qtmetros = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Qtmingondula
    {
        get
        {
            PropriedadeAcessada(RO_QTMINGONDULA);
            return _qtmingondula;
        }
        set
        {
            PropriedadeModificada(RO_QTMINGONDULA, value);
            _qtmingondula = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Qtminimaatacado
    {
        get
        {
            PropriedadeAcessada(RO_QTMINIMAATACADO);
            return _qtminimaatacado;
        }
        set
        {
            PropriedadeModificada(RO_QTMINIMAATACADO, value);
            _qtminimaatacado = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Qtminimaatacadof
    {
        get
        {
            PropriedadeAcessada(RO_QTMINIMAATACADOF);
            return _qtminimaatacadof;
        }
        set
        {
            PropriedadeModificada(RO_QTMINIMAATACADOF, value);
            _qtminimaatacadof = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 20, Precisao = 8)]
    public decimal? Qtminproduzir
    {
        get
        {
            PropriedadeAcessada(RO_QTMINPRODUZIR);
            return _qtminproduzir;
        }
        set
        {
            PropriedadeModificada(RO_QTMINPRODUZIR, value);
            _qtminproduzir = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 22, Precisao = 8)]
    public decimal? Qtminsugcompra
    {
        get
        {
            PropriedadeAcessada(RO_QTMINSUGCOMPRA);
            return _qtminsugcompra;
        }
        set
        {
            PropriedadeModificada(RO_QTMINSUGCOMPRA, value);
            _qtminsugcompra = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 20, Precisao = 8)]
    public decimal? Qtpontopedido
    {
        get
        {
            PropriedadeAcessada(RO_QTPONTOPEDIDO);
            return _qtpontopedido;
        }
        set
        {
            PropriedadeModificada(RO_QTPONTOPEDIDO, value);
            _qtpontopedido = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Qtproduzir
    {
        get
        {
            PropriedadeAcessada(RO_QTPRODUZIR);
            return _qtproduzir;
        }
        set
        {
            PropriedadeModificada(RO_QTPRODUZIR, value);
            _qtproduzir = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Qtpulmaoregulador
    {
        get
        {
            PropriedadeAcessada(RO_QTPULMAOREGULADOR);
            return _qtpulmaoregulador;
        }
        set
        {
            PropriedadeModificada(RO_QTPULMAOREGULADOR, value);
            _qtpulmaoregulador = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 2)]
    public decimal? Qttotpal
    {
        get
        {
            PropriedadeAcessada(RO_QTTOTPAL);
            return _qttotpal;
        }
        set
        {
            PropriedadeModificada(RO_QTTOTPAL, value);
            _qttotpal = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 2)]
    public decimal? Qttotpalfrac
    {
        get
        {
            PropriedadeAcessada(RO_QTTOTPALFRAC);
            return _qttotpalfrac;
        }
        set
        {
            PropriedadeModificada(RO_QTTOTPALFRAC, value);
            _qttotpalfrac = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 2)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 2)]
    public decimal? Qtunitct
    {
        get
        {
            PropriedadeAcessada(RO_QTUNITCT);
            return _qtunitct;
        }
        set
        {
            PropriedadeModificada(RO_QTUNITCT, value);
            _qtunitct = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 2)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Recminarm
    {
        get
        {
            PropriedadeAcessada(RO_RECMINARM);
            return _recminarm;
        }
        set
        {
            PropriedadeModificada(RO_RECMINARM, value);
            _recminarm = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Redbasealiqextbcr
    {
        get
        {
            PropriedadeAcessada(RO_REDBASEALIQEXTBCR);
            return _redbasealiqextbcr;
        }
        set
        {
            PropriedadeModificada(RO_REDBASEALIQEXTBCR, value);
            _redbasealiqextbcr = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Redbaseivabcr
    {
        get
        {
            PropriedadeAcessada(RO_REDBASEIVABCR);
            return _redbaseivabcr;
        }
        set
        {
            PropriedadeModificada(RO_REDBASEIVABCR, value);
            _redbaseivabcr = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 13, Precisao = 0)]
    public string Registromsmed
    {
        get
        {
            PropriedadeAcessada(RO_REGISTROMSMED);
            return _registromsmed;
        }
        set
        {
            PropriedadeModificada(RO_REGISTROMSMED, value);
            _registromsmed = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
    public string Regms
    {
        get
        {
            PropriedadeAcessada(RO_REGMS);
            return _regms;
        }
        set
        {
            PropriedadeModificada(RO_REGMS, value);
            _regms = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 3, Precisao = 0)]
    public decimal? Restricaoblocado
    {
        get
        {
            PropriedadeAcessada(RO_RESTRICAOBLOCADO);
            return _restricaoblocado;
        }
        set
        {
            PropriedadeModificada(RO_RESTRICAOBLOCADO, value);
            _restricaoblocado = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Restringecotacao
    {
        get
        {
            PropriedadeAcessada(RO_RESTRINGECOTACAO);
            return _restringecotacao;
        }
        set
        {
            PropriedadeModificada(RO_RESTRINGECOTACAO, value);
            _restringecotacao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 48, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Ruact
    {
        get
        {
            PropriedadeAcessada(RO_RUACT);
            return _ruact;
        }
        set
        {
            PropriedadeModificada(RO_RUACT, value);
            _ruact = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Ruacx
    {
        get
        {
            PropriedadeAcessada(RO_RUACX);
            return _ruacx;
        }
        set
        {
            PropriedadeModificada(RO_RUACX, value);
            _ruacx = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Rua2
    {
        get
        {
            PropriedadeAcessada(RO_RUA2);
            return _rua2;
        }
        set
        {
            PropriedadeModificada(RO_RUA2, value);
            _rua2 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 100, Precisao = 0)]
    public string Salmonela
    {
        get
        {
            PropriedadeAcessada(RO_SALMONELA);
            return _salmonela;
        }
        set
        {
            PropriedadeModificada(RO_SALMONELA, value);
            _salmonela = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Seqpagina
    {
        get
        {
            PropriedadeAcessada(RO_SEQPAGINA);
            return _seqpagina;
        }
        set
        {
            PropriedadeModificada(RO_SEQPAGINA, value);
            _seqpagina = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Seqtabpreco
    {
        get
        {
            PropriedadeAcessada(RO_SEQTABPRECO);
            return _seqtabpreco;
        }
        set
        {
            PropriedadeModificada(RO_SEQTABPRECO, value);
            _seqtabpreco = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
    public string Simpro
    {
        get
        {
            PropriedadeAcessada(RO_SIMPRO);
            return _simpro;
        }
        set
        {
            PropriedadeModificada(RO_SIMPRO, value);
            _simpro = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 3, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 3, Precisao = 0)]
    public string Sittributdev
    {
        get
        {
            PropriedadeAcessada(RO_SITTRIBUTDEV);
            return _sittributdev;
        }
        set
        {
            PropriedadeModificada(RO_SITTRIBUTDEV, value);
            _sittributdev = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 3, Precisao = 0)]
    public string Sittributdevfornec
    {
        get
        {
            PropriedadeAcessada(RO_SITTRIBUTDEVFORNEC);
            return _sittributdevfornec;
        }
        set
        {
            PropriedadeModificada(RO_SITTRIBUTDEVFORNEC, value);
            _sittributdevfornec = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 3, Precisao = 0)]
    public string Sittributent
    {
        get
        {
            PropriedadeAcessada(RO_SITTRIBUTENT);
            return _sittributent;
        }
        set
        {
            PropriedadeModificada(RO_SITTRIBUTENT, value);
            _sittributent = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Somentetv3
    {
        get
        {
            PropriedadeAcessada(RO_SOMENTETV3);
            return _somentetv3;
        }
        set
        {
            PropriedadeModificada(RO_SOMENTETV3, value);
            _somentetv3 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 10, Precisao = 0)]
    public string Substancia
    {
        get
        {
            PropriedadeAcessada(RO_SUBSTANCIA);
            return _substancia;
        }
        set
        {
            PropriedadeModificada(RO_SUBSTANCIA, value);
            _substancia = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 200, Precisao = 0)]
    public string Subtituloecommerce
    {
        get
        {
            PropriedadeAcessada(RO_SUBTITULOECOMMERCE);
            return _subtituloecommerce;
        }
        set
        {
            PropriedadeModificada(RO_SUBTITULOECOMMERCE, value);
            _subtituloecommerce = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 2, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Tamanholotefab
    {
        get
        {
            PropriedadeAcessada(RO_TAMANHOLOTEFAB);
            return _tamanholotefab;
        }
        set
        {
            PropriedadeModificada(RO_TAMANHOLOTEFAB, value);
            _tamanholotefab = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 2, Precisao = 0)]
    public decimal? Tipoalturapalete
    {
        get
        {
            PropriedadeAcessada(RO_TIPOALTURAPALETE);
            return _tipoalturapalete;
        }
        set
        {
            PropriedadeModificada(RO_TIPOALTURAPALETE, value);
            _tipoalturapalete = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 2, Precisao = 0)]
    public decimal? Tipoarm
    {
        get
        {
            PropriedadeAcessada(RO_TIPOARM);
            return _tipoarm;
        }
        set
        {
            PropriedadeModificada(RO_TIPOARM, value);
            _tipoarm = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Tipocarga
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Tipocomissao
    {
        get
        {
            PropriedadeAcessada(RO_TIPOCOMISSAO);
            return _tipocomissao;
        }
        set
        {
            PropriedadeModificada(RO_TIPOCOMISSAO, value);
            _tipocomissao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Tipoembalage
    {
        get
        {
            PropriedadeAcessada(RO_TIPOEMBALAGE);
            return _tipoembalage;
        }
        set
        {
            PropriedadeModificada(RO_TIPOEMBALAGE, value);
            _tipoembalage = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 2, Precisao = 0)]
    public decimal? Tipoembalagemnestle
    {
        get
        {
            PropriedadeAcessada(RO_TIPOEMBALAGEMNESTLE);
            return _tipoembalagemnestle;
        }
        set
        {
            PropriedadeModificada(RO_TIPOEMBALAGEMNESTLE, value);
            _tipoembalagemnestle = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Tipoestoque
    {
        get
        {
            PropriedadeAcessada(RO_TIPOESTOQUE);
            return _tipoestoque;
        }
        set
        {
            PropriedadeModificada(RO_TIPOESTOQUE, value);
            _tipoestoque = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Tipomedicamento
    {
        get
        {
            PropriedadeAcessada(RO_TIPOMEDICAMENTO);
            return _tipomedicamento;
        }
        set
        {
            PropriedadeModificada(RO_TIPOMEDICAMENTO, value);
            _tipomedicamento = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Tipomp
    {
        get
        {
            PropriedadeAcessada(RO_TIPOMP);
            return _tipomp;
        }
        set
        {
            PropriedadeModificada(RO_TIPOMP, value);
            _tipomp = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Tiponorma
    {
        get
        {
            PropriedadeAcessada(RO_TIPONORMA);
            return _tiponorma;
        }
        set
        {
            PropriedadeModificada(RO_TIPONORMA, value);
            _tiponorma = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 2, Precisao = 0)]
    public decimal? Tipopal
    {
        get
        {
            PropriedadeAcessada(RO_TIPOPAL);
            return _tipopal;
        }
        set
        {
            PropriedadeModificada(RO_TIPOPAL, value);
            _tipopal = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 2, Precisao = 0)]
    public decimal? Tipopalpul
    {
        get
        {
            PropriedadeAcessada(RO_TIPOPALPUL);
            return _tipopalpul;
        }
        set
        {
            PropriedadeModificada(RO_TIPOPALPUL, value);
            _tipopalpul = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 2, Precisao = 0)]
    public decimal? Tipopiscofinsretido
    {
        get
        {
            PropriedadeAcessada(RO_TIPOPISCOFINSRETIDO);
            return _tipopiscofinsretido;
        }
        set
        {
            PropriedadeModificada(RO_TIPOPISCOFINSRETIDO, value);
            _tipopiscofinsretido = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 2, Precisao = 0)]
    public decimal? Tipoprod
    {
        get
        {
            PropriedadeAcessada(RO_TIPOPROD);
            return _tipoprod;
        }
        set
        {
            PropriedadeModificada(RO_TIPOPROD, value);
            _tipoprod = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Tiporestricao
    {
        get
        {
            PropriedadeAcessada(RO_TIPORESTRICAO);
            return _tiporestricao;
        }
        set
        {
            PropriedadeModificada(RO_TIPORESTRICAO, value);
            _tiporestricao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Tiporestricaomed
    {
        get
        {
            PropriedadeAcessada(RO_TIPORESTRICAOMED);
            return _tiporestricaomed;
        }
        set
        {
            PropriedadeModificada(RO_TIPORESTRICAOMED, value);
            _tiporestricaomed = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Tiposugcompra
    {
        get
        {
            PropriedadeAcessada(RO_TIPOSUGCOMPRA);
            return _tiposugcompra;
        }
        set
        {
            PropriedadeModificada(RO_TIPOSUGCOMPRA, value);
            _tiposugcompra = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Tipovolumedescarga
    {
        get
        {
            PropriedadeAcessada(RO_TIPOVOLUMEDESCARGA);
            return _tipovolumedescarga;
        }
        set
        {
            PropriedadeModificada(RO_TIPOVOLUMEDESCARGA, value);
            _tipovolumedescarga = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 200, Precisao = 0)]
    public string Tituloecommerce
    {
        get
        {
            PropriedadeAcessada(RO_TITULOECOMMERCE);
            return _tituloecommerce;
        }
        set
        {
            PropriedadeModificada(RO_TITULOECOMMERCE, value);
            _tituloecommerce = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 100, Precisao = 0)]
    public string Totdefeito
    {
        get
        {
            PropriedadeAcessada(RO_TOTDEFEITO);
            return _totdefeito;
        }
        set
        {
            PropriedadeModificada(RO_TOTDEFEITO, value);
            _totdefeito = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 15, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 100, Precisao = 0)]
    public string Umidade
    {
        get
        {
            PropriedadeAcessada(RO_UMIDADE);
            return _umidade;
        }
        set
        {
            PropriedadeModificada(RO_UMIDADE, value);
            _umidade = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 100, Precisao = 0)]
    public string Umidadeanalise
    {
        get
        {
            PropriedadeAcessada(RO_UMIDADEANALISE);
            return _umidadeanalise;
        }
        set
        {
            PropriedadeModificada(RO_UMIDADEANALISE, value);
            _umidadeanalise = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 2)]
    public decimal? Undporembalagem
    {
        get
        {
            PropriedadeAcessada(RO_UNDPOREMBALAGEM);
            return _undporembalagem;
        }
        set
        {
            PropriedadeModificada(RO_UNDPOREMBALAGEM, value);
            _undporembalagem = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Unidadect
    {
        get
        {
            PropriedadeAcessada(RO_UNIDADECT);
            return _unidadect;
        }
        set
        {
            PropriedadeModificada(RO_UNIDADECT, value);
            _unidadect = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Unidademaster
    {
        get
        {
            PropriedadeAcessada(RO_UNIDADEMASTER);
            return _unidademaster;
        }
        set
        {
            PropriedadeModificada(RO_UNIDADEMASTER, value);
            _unidademaster = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 100, Precisao = 0)]
    public string Uniformidade
    {
        get
        {
            PropriedadeAcessada(RO_UNIFORMIDADE);
            return _uniformidade;
        }
        set
        {
            PropriedadeModificada(RO_UNIFORMIDADE, value);
            _uniformidade = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Usaaliqcredicmsdifer
    {
        get
        {
            PropriedadeAcessada(RO_USAALIQCREDICMSDIFER);
            return _usaaliqcredicmsdifer;
        }
        set
        {
            PropriedadeModificada(RO_USAALIQCREDICMSDIFER, value);
            _usaaliqcredicmsdifer = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Usaclassificacao
    {
        get
        {
            PropriedadeAcessada(RO_USACLASSIFICACAO);
            return _usaclassificacao;
        }
        set
        {
            PropriedadeModificada(RO_USACLASSIFICACAO, value);
            _usaclassificacao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Usapiscofinslit
    {
        get
        {
            PropriedadeAcessada(RO_USAPISCOFINSLIT);
            return _usapiscofinslit;
        }
        set
        {
            PropriedadeModificada(RO_USAPISCOFINSLIT, value);
            _usapiscofinslit = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Usapiscofinslitimp
    {
        get
        {
            PropriedadeAcessada(RO_USAPISCOFINSLITIMP);
            return _usapiscofinslitimp;
        }
        set
        {
            PropriedadeModificada(RO_USAPISCOFINSLITIMP, value);
            _usapiscofinslitimp = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Usapulmaoregulador
    {
        get
        {
            PropriedadeAcessada(RO_USAPULMAOREGULADOR);
            return _usapulmaoregulador;
        }
        set
        {
            PropriedadeModificada(RO_USAPULMAOREGULADOR, value);
            _usapulmaoregulador = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Utilizaprecomaxconsumidor
    {
        get
        {
            PropriedadeAcessada(RO_UTILIZAPRECOMAXCONSUMIDOR);
            return _utilizaprecomaxconsumidor;
        }
        set
        {
            PropriedadeModificada(RO_UTILIZAPRECOMAXCONSUMIDOR, value);
            _utilizaprecomaxconsumidor = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Utilizarvasilhame
    {
        get
        {
            PropriedadeAcessada(RO_UTILIZARVASILHAME);
            return _utilizarvasilhame;
        }
        set
        {
            PropriedadeModificada(RO_UTILIZARVASILHAME, value);
            _utilizarvasilhame = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Utilizaselo
    {
        get
        {
            PropriedadeAcessada(RO_UTILIZASELO);
            return _utilizaselo;
        }
        set
        {
            PropriedadeModificada(RO_UTILIZASELO, value);
            _utilizaselo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Validarlote
    {
        get
        {
            PropriedadeAcessada(RO_VALIDARLOTE);
            return _validarlote;
        }
        set
        {
            PropriedadeModificada(RO_VALIDARLOTE, value);
            _validarlote = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Valorcofinslitragem
    {
        get
        {
            PropriedadeAcessada(RO_VALORCOFINSLITRAGEM);
            return _valorcofinslitragem;
        }
        set
        {
            PropriedadeModificada(RO_VALORCOFINSLITRAGEM, value);
            _valorcofinslitragem = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Valorpislitragem
    {
        get
        {
            PropriedadeAcessada(RO_VALORPISLITRAGEM);
            return _valorpislitragem;
        }
        set
        {
            PropriedadeModificada(RO_VALORPISLITRAGEM, value);
            _valorpislitragem = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Velocidadeesp
    {
        get
        {
            PropriedadeAcessada(RO_VELOCIDADEESP);
            return _velocidadeesp;
        }
        set
        {
            PropriedadeModificada(RO_VELOCIDADEESP, value);
            _velocidadeesp = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Velocidadeoperacional
    {
        get
        {
            PropriedadeAcessada(RO_VELOCIDADEOPERACIONAL);
            return _velocidadeoperacional;
        }
        set
        {
            PropriedadeModificada(RO_VELOCIDADEOPERACIONAL, value);
            _velocidadeoperacional = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Vendadireta
    {
        get
        {
            PropriedadeAcessada(RO_VENDADIRETA);
            return _vendadireta;
        }
        set
        {
            PropriedadeModificada(RO_VENDADIRETA, value);
            _vendadireta = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Versanalise
    {
        get
        {
            PropriedadeAcessada(RO_VERSANALISE);
            return _versanalise;
        }
        set
        {
            PropriedadeModificada(RO_VERSANALISE, value);
            _versanalise = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vladicionalbcstbcr
    {
        get
        {
            PropriedadeAcessada(RO_VLADICIONALBCSTBCR);
            return _vladicionalbcstbcr;
        }
        set
        {
            PropriedadeModificada(RO_VLADICIONALBCSTBCR, value);
            _vladicionalbcstbcr = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 100, Precisao = 0)]
    public string Vlcalorico
    {
        get
        {
            PropriedadeAcessada(RO_VLCALORICO);
            return _vlcalorico;
        }
        set
        {
            PropriedadeModificada(RO_VLCALORICO, value);
            _vlcalorico = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlcofinslit
    {
        get
        {
            PropriedadeAcessada(RO_VLCOFINSLIT);
            return _vlcofinslit;
        }
        set
        {
            PropriedadeModificada(RO_VLCOFINSLIT, value);
            _vlcofinslit = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlcofinslitimp
    {
        get
        {
            PropriedadeAcessada(RO_VLCOFINSLITIMP);
            return _vlcofinslitimp;
        }
        set
        {
            PropriedadeModificada(RO_VLCOFINSLITIMP, value);
            _vlcofinslitimp = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Vlipipeso
    {
        get
        {
            PropriedadeAcessada(RO_VLIPIPESO);
            return _vlipipeso;
        }
        set
        {
            PropriedadeModificada(RO_VLIPIPESO, value);
            _vlipipeso = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlipiporkgvenda
    {
        get
        {
            PropriedadeAcessada(RO_VLIPIPORKGVENDA);
            return _vlipiporkgvenda;
        }
        set
        {
            PropriedadeModificada(RO_VLIPIPORKGVENDA, value);
            _vlipiporkgvenda = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlipiporkgvendatab
    {
        get
        {
            PropriedadeAcessada(RO_VLIPIPORKGVENDATAB);
            return _vlipiporkgvendatab;
        }
        set
        {
            PropriedadeModificada(RO_VLIPIPORKGVENDATAB, value);
            _vlipiporkgvendatab = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 6)]
    public decimal? Vlmaodeobra
    {
        get
        {
            PropriedadeAcessada(RO_VLMAODEOBRA);
            return _vlmaodeobra;
        }
        set
        {
            PropriedadeModificada(RO_VLMAODEOBRA, value);
            _vlmaodeobra = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlpauta
    {
        get
        {
            PropriedadeAcessada(RO_VLPAUTA);
            return _vlpauta;
        }
        set
        {
            PropriedadeModificada(RO_VLPAUTA, value);
            _vlpauta = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlpautabcr
    {
        get
        {
            PropriedadeAcessada(RO_VLPAUTABCR);
            return _vlpautabcr;
        }
        set
        {
            PropriedadeModificada(RO_VLPAUTABCR, value);
            _vlpautabcr = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlpautaipi
    {
        get
        {
            PropriedadeAcessada(RO_VLPAUTAIPI);
            return _vlpautaipi;
        }
        set
        {
            PropriedadeModificada(RO_VLPAUTAIPI, value);
            _vlpautaipi = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlpautaipivenda
    {
        get
        {
            PropriedadeAcessada(RO_VLPAUTAIPIVENDA);
            return _vlpautaipivenda;
        }
        set
        {
            PropriedadeModificada(RO_VLPAUTAIPIVENDA, value);
            _vlpautaipivenda = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlpautaipivendatab
    {
        get
        {
            PropriedadeAcessada(RO_VLPAUTAIPIVENDATAB);
            return _vlpautaipivendatab;
        }
        set
        {
            PropriedadeModificada(RO_VLPAUTAIPIVENDATAB, value);
            _vlpautaipivendatab = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlpautapiscofins
    {
        get
        {
            PropriedadeAcessada(RO_VLPAUTAPISCOFINS);
            return _vlpautapiscofins;
        }
        set
        {
            PropriedadeModificada(RO_VLPAUTAPISCOFINS, value);
            _vlpautapiscofins = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlpautapiscofinsimp
    {
        get
        {
            PropriedadeAcessada(RO_VLPAUTAPISCOFINSIMP);
            return _vlpautapiscofinsimp;
        }
        set
        {
            PropriedadeModificada(RO_VLPAUTAPISCOFINSIMP, value);
            _vlpautapiscofinsimp = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlpislit
    {
        get
        {
            PropriedadeAcessada(RO_VLPISLIT);
            return _vlpislit;
        }
        set
        {
            PropriedadeModificada(RO_VLPISLIT, value);
            _vlpislit = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlpislitimp
    {
        get
        {
            PropriedadeAcessada(RO_VLPISLITIMP);
            return _vlpislitimp;
        }
        set
        {
            PropriedadeModificada(RO_VLPISLITIMP, value);
            _vlpislitimp = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlraplicint
    {
        get
        {
            PropriedadeAcessada(RO_VLRAPLICINT);
            return _vlraplicint;
        }
        set
        {
            PropriedadeModificada(RO_VLRAPLICINT, value);
            _vlraplicint = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 16, Precisao = 2)]
    public decimal? Vlvendatemp
    {
        get
        {
            PropriedadeAcessada(RO_VLVENDATEMP);
            return _vlvendatemp;
        }
        set
        {
            PropriedadeModificada(RO_VLVENDATEMP, value);
            _vlvendatemp = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 100, Precisao = 0)]
    public string Volpesmed
    {
        get
        {
            PropriedadeAcessada(RO_VOLPESMED);
            return _volpesmed;
        }
        set
        {
            PropriedadeModificada(RO_VOLPESMED, value);
            _volpesmed = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 20, Precisao = 8)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 20, Precisao = 8)]
    public decimal? Volumearm
    {
        get
        {
            PropriedadeAcessada(RO_VOLUMEARM);
            return _volumearm;
        }
        set
        {
            PropriedadeModificada(RO_VOLUMEARM, value);
            _volumearm = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODUT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 20, Precisao = 8)]
    public decimal? Volumerec
    {
        get
        {
            PropriedadeAcessada(RO_VOLUMEREC);
            return _volumerec;
        }
        set
        {
            PropriedadeModificada(RO_VOLUMEREC, value);
            _volumerec = value;
        }
    }

    public void InicializarAtributos()
    {
    }

    public string ObterNomeTabela()
    {
        return "PCPRODUT";
    }

    public IEntidade NovaInstancia()
    {
        return (IEntidade)GetType().GetConstructors()[0].Invoke(null);
    }

    public void CarregarPorDataReader(IDataReader leitor)
    {
        _abastepalete = AlterarTipo<string>(leitor["Abastepalete"]);
        _abastepaletecx = AlterarTipo<string>(leitor["Abastepaletecx"]);
        _aceitavendafracao = AlterarTipo<string>(leitor["Aceitavendafracao"]);
        _aliqavulsadare = AlterarTipo<decimal?>(leitor["Aliqavulsadare"]);
        _alturaarm = AlterarTipo<decimal?>(leitor["Alturaarm"]);
        _alturam3 = AlterarTipo<decimal?>(leitor["Alturam3"]);
        _alturapal = AlterarTipo<decimal?>(leitor["Alturapal"]);
        _analisedesc = AlterarTipo<string>(leitor["Analisedesc"]);
        _anvisa = AlterarTipo<string>(leitor["Anvisa"]);
        _anvisacapinstal = AlterarTipo<decimal?>(leitor["Anvisacapinstal"]);
        _anvisaclasterapeutica = AlterarTipo<string>(leitor["Anvisaclasterapeutica"]);
        _anvisacoeftec = AlterarTipo<string>(leitor["Anvisacoeftec"]);
        _anvisaconcen = AlterarTipo<decimal?>(leitor["Anvisaconcen"]);
        _anvisadescprincat1 = AlterarTipo<string>(leitor["Anvisadescprincat1"]);
        _anvisadescprincat2 = AlterarTipo<string>(leitor["Anvisadescprincat2"]);
        _anvisadescprincat3 = AlterarTipo<string>(leitor["Anvisadescprincat3"]);
        _anvisadescprincat4 = AlterarTipo<string>(leitor["Anvisadescprincat4"]);
        _anvisaformafarm = AlterarTipo<string>(leitor["Anvisaformafarm"]);
        _anvisanumprincat = AlterarTipo<decimal?>(leitor["Anvisanumprincat"]);
        _anvisanumregmed = AlterarTipo<string>(leitor["Anvisanumregmed"]);
        _anvisaqtembalagem = AlterarTipo<decimal?>(leitor["Anvisaqtembalagem"]);
        _anvisauncoeftec = AlterarTipo<string>(leitor["Anvisauncoeftec"]);
        _anvisaundosag = AlterarTipo<string>(leitor["Anvisaundosag"]);
        _anvisausocontinuo = AlterarTipo<string>(leitor["Anvisausocontinuo"]);
        _anvisaviaadm = AlterarTipo<string>(leitor["Anvisaviaadm"]);
        _aplicacoes = AlterarTipo<string>(leitor["Aplicacoes"]);
        _aplicpercivapauta = AlterarTipo<string>(leitor["Aplicpercivapauta"]);
        _aplicredbaseivapliq = AlterarTipo<string>(leitor["Aplicredbaseivapliq"]);
        _aplicredbaseivapliqbcr = AlterarTipo<string>(leitor["Aplicredbaseivapliqbcr"]);
        _aproveitacredicms = AlterarTipo<string>(leitor["Aproveitacredicms"]);
        _aproveitacredpiscofins = AlterarTipo<string>(leitor["Aproveitacredpiscofins"]);
        _apto = AlterarTipo<decimal?>(leitor["Apto"]);
        _aptoct = AlterarTipo<decimal?>(leitor["Aptoct"]);
        _aptocx = AlterarTipo<decimal?>(leitor["Aptocx"]);
        _apto2 = AlterarTipo<decimal?>(leitor["Apto2"]);
        _assinatura = AlterarTipo<string>(leitor["Assinatura"]);
        _atupesomasterent = AlterarTipo<string>(leitor["Atupesomasterent"]);
        _autorizatipo4 = AlterarTipo<string>(leitor["Autorizatipo4"]);
        _basepiscofinslit = AlterarTipo<decimal?>(leitor["Basepiscofinslit"]);
        _basepiscofinslitimp = AlterarTipo<decimal?>(leitor["Basepiscofinslitimp"]);
        _basepiscofinslitragem = AlterarTipo<decimal?>(leitor["Basepiscofinslitragem"]);
        _boloresleveduras = AlterarTipo<string>(leitor["Boloresleveduras"]);
        _calccredipi = AlterarTipo<string>(leitor["Calccredipi"]);
        _camapapal = AlterarTipo<decimal?>(leitor["Camapapal"]);
        _campanha = AlterarTipo<string>(leitor["Campanha"]);
        _capacidadepa = AlterarTipo<decimal?>(leitor["Capacidadepa"]);
        _capacidadepicking = AlterarTipo<decimal?>(leitor["Capacidadepicking"]);
        _capacidadepickingal = AlterarTipo<decimal?>(leitor["Capacidadepickingal"]);
        _capacidadepickingcx = AlterarTipo<decimal?>(leitor["Capacidadepickingcx"]);
        _capvoldnf = AlterarTipo<decimal?>(leitor["Capvoldnf"]);
        _catergoria = AlterarTipo<string>(leitor["Catergoria"]);
        _cestabasicalegis = AlterarTipo<string>(leitor["Cestabasicalegis"]);
        _checarmultiplovendabnf = AlterarTipo<string>(leitor["Checarmultiplovendabnf"]);
        _classe = AlterarTipo<string>(leitor["Classe"]);
        _classecomissao = AlterarTipo<string>(leitor["Classecomissao"]);
        _classecompra = AlterarTipo<string>(leitor["Classecompra"]);
        _classeestoque = AlterarTipo<string>(leitor["Classeestoque"]);
        _classeflow = AlterarTipo<string>(leitor["Classeflow"]);
        _classemc = AlterarTipo<string>(leitor["Classemc"]);
        _classevenda = AlterarTipo<string>(leitor["Classevenda"]);
        _classificfiscal = AlterarTipo<string>(leitor["Classificfiscal"]);
        _codacondicionamento = AlterarTipo<string>(leitor["Codacondicionamento"]);
        _codagrupmapasep = AlterarTipo<string>(leitor["Codagrupmapasep"]);
        _codauxiliar = AlterarTipo<decimal?>(leitor["Codauxiliar"]);
        _codauxiliar2 = AlterarTipo<decimal?>(leitor["Codauxiliar2"]);
        _codcaracprod = AlterarTipo<decimal?>(leitor["Codcaracprod"]);
        _codcategoria = AlterarTipo<decimal?>(leitor["Codcategoria"]);
        _codcategoriaweb = AlterarTipo<decimal?>(leitor["Codcategoriaweb"]);
        _codcor = AlterarTipo<decimal?>(leitor["Codcor"]);
        _coddeptoweb = AlterarTipo<decimal?>(leitor["Coddeptoweb"]);
        _coddistrib = AlterarTipo<string>(leitor["Coddistrib"]);
        _codenderecoal = AlterarTipo<decimal?>(leitor["Codenderecoal"]);
        _codenderecoap = AlterarTipo<decimal?>(leitor["Codenderecoap"]);
        _codenderecocx = AlterarTipo<decimal?>(leitor["Codenderecocx"]);
        _codenderecopa = AlterarTipo<decimal?>(leitor["Codenderecopa"]);
        _codepto = AlterarTipo<decimal>(leitor["Codepto"]);
        _codequipe = AlterarTipo<decimal?>(leitor["Codequipe"]);
        _codexcecaopiscofins = AlterarTipo<decimal?>(leitor["Codexcecaopiscofins"]);
        _codfab = AlterarTipo<string>(leitor["Codfab"]);
        _codfilial = AlterarTipo<string>(leitor["Codfilial"]);
        _codfilialprodutora = AlterarTipo<string>(leitor["Codfilialprodutora"]);
        _codfilialretira = AlterarTipo<string>(leitor["Codfilialretira"]);
        _codfiscal = AlterarTipo<decimal?>(leitor["Codfiscal"]);
        _codfiscalbonific = AlterarTipo<decimal?>(leitor["Codfiscalbonific"]);
        _codfiscalconsig = AlterarTipo<decimal?>(leitor["Codfiscalconsig"]);
        _codfiscalconsigfat = AlterarTipo<decimal?>(leitor["Codfiscalconsigfat"]);
        _codfiscaldevfornec = AlterarTipo<decimal?>(leitor["Codfiscaldevfornec"]);
        _codfiscalenttransf = AlterarTipo<decimal?>(leitor["Codfiscalenttransf"]);
        _codfiscalenttv9 = AlterarTipo<decimal?>(leitor["Codfiscalenttv9"]);
        _codfiscalsr = AlterarTipo<decimal?>(leitor["Codfiscalsr"]);
        _codformatopapel = AlterarTipo<decimal?>(leitor["Codformatopapel"]);
        _codfornec = AlterarTipo<decimal>(leitor["Codfornec"]);
        _codfunccadastro = AlterarTipo<decimal?>(leitor["Codfunccadastro"]);
        _codfuncultalter = AlterarTipo<decimal?>(leitor["Codfuncultalter"]);
        _codgenerofiscal = AlterarTipo<decimal?>(leitor["Codgenerofiscal"]);
        _codgrade = AlterarTipo<decimal?>(leitor["Codgrade"]);
        _codgrulit = AlterarTipo<string>(leitor["Codgrulit"]);
        _codinfnutri = AlterarTipo<decimal?>(leitor["Codinfnutri"]);
        _codinterno = AlterarTipo<string>(leitor["Codinterno"]);
        _codlinha = AlterarTipo<decimal?>(leitor["Codlinha"]);
        _codlinhanestle = AlterarTipo<decimal?>(leitor["Codlinhanestle"]);
        _codlinhaprazo = AlterarTipo<decimal?>(leitor["Codlinhaprazo"]);
        _codlinhaprod = AlterarTipo<decimal?>(leitor["Codlinhaprod"]);
        _codmarca = AlterarTipo<decimal?>(leitor["Codmarca"]);
        _codncmex = AlterarTipo<string>(leitor["Codncmex"]);
        _codnestleterceiros = AlterarTipo<string>(leitor["Codnestleterceiros"]);
        _codonu = AlterarTipo<string>(leitor["Codonu"]);
        _codpassefiscal = AlterarTipo<decimal?>(leitor["Codpassefiscal"]);
        _codprazoent = AlterarTipo<string>(leitor["Codprazoent"]);
        _codprincipativo = AlterarTipo<decimal?>(leitor["Codprincipativo"]);
        _codprod = AlterarTipo<decimal>(leitor["Codprod"]);
        _codproddnf = AlterarTipo<decimal?>(leitor["Codproddnf"]);
        _codprodembalagem = AlterarTipo<decimal?>(leitor["Codprodembalagem"]);
        _codprodmaster = AlterarTipo<decimal?>(leitor["Codprodmaster"]);
        _codprodprinc = AlterarTipo<decimal?>(leitor["Codprodprinc"]);
        _codprodrelev = AlterarTipo<decimal?>(leitor["Codprodrelev"]);
        _codprodsimilar = AlterarTipo<decimal?>(leitor["Codprodsimilar"]);
        _codprodsintegra = AlterarTipo<string>(leitor["Codprodsintegra"]);
        _codrisco = AlterarTipo<string>(leitor["Codrisco"]);
        _codrotinaultalter = AlterarTipo<decimal?>(leitor["Codrotinaultalter"]);
        _codsec = AlterarTipo<decimal>(leitor["Codsec"]);
        _codsecaoweb = AlterarTipo<decimal?>(leitor["Codsecaoweb"]);
        _codsittribpiscofins = AlterarTipo<decimal?>(leitor["Codsittribpiscofins"]);
        _codsittribpiscofinsdev = AlterarTipo<decimal?>(leitor["Codsittribpiscofinsdev"]);
        _codsubcategoria = AlterarTipo<decimal?>(leitor["Codsubcategoria"]);
        _codsubcategoriaweb = AlterarTipo<decimal?>(leitor["Codsubcategoriaweb"]);
        _codtablit = AlterarTipo<string>(leitor["Codtablit"]);
        _codtipoestrutura = AlterarTipo<decimal?>(leitor["Codtipoestrutura"]);
        _codtipoestruturapul = AlterarTipo<decimal?>(leitor["Codtipoestruturapul"]);
        _codtribpiscofins = AlterarTipo<decimal?>(leitor["Codtribpiscofins"]);
        _codunidmedidanf = AlterarTipo<decimal?>(leitor["Codunidmedidanf"]);
        _codusuultaltcom = AlterarTipo<decimal?>(leitor["Codusuultaltcom"]);
        _codvasilhame = AlterarTipo<decimal?>(leitor["Codvasilhame"]);
        _cofinsretido = AlterarTipo<decimal?>(leitor["Cofinsretido"]);
        _colunagrade = AlterarTipo<decimal?>(leitor["Colunagrade"]);
        _col95 = AlterarTipo<string>(leitor["Col95"]);
        _comissaofixa = AlterarTipo<string>(leitor["Comissaofixa"]);
        _comissaoporlucratividade = AlterarTipo<string>(leitor["Comissaoporlucratividade"]);
        _compraconsignado = AlterarTipo<string>(leitor["Compraconsignado"]);
        _comprimentoarm = AlterarTipo<decimal?>(leitor["Comprimentoarm"]);
        _comprimentom3 = AlterarTipo<decimal?>(leitor["Comprimentom3"]);
        _concentracao = AlterarTipo<decimal?>(leitor["Concentracao"]);
        _conciliaimportacao = AlterarTipo<string>(leitor["Conciliaimportacao"]);
        _confaz = AlterarTipo<string>(leitor["Confaz"]);
        _conferenocheckout = AlterarTipo<string>(leitor["Conferenocheckout"]);
        _consideraricmsantecipcusto = AlterarTipo<string>(leitor["Consideraricmsantecipcusto"]);
        _contloganalise = AlterarTipo<decimal?>(leitor["Contloganalise"]);
        _contmicrobiana = AlterarTipo<string>(leitor["Contmicrobiana"]);
        _controladoibama = AlterarTipo<string>(leitor["Controladoibama"]);
        _controlanumseria = AlterarTipo<string>(leitor["Controlanumseria"]);
        _controlanumserie = AlterarTipo<string>(leitor["Controlanumserie"]);
        _controlapatrimonio = AlterarTipo<string>(leitor["Controlapatrimonio"]);
        _controlavalidadedolote = AlterarTipo<string>(leitor["Controlavalidadedolote"]);
        _corredor = AlterarTipo<string>(leitor["Corredor"]);
        _csllretido = AlterarTipo<decimal?>(leitor["Csllretido"]);
        _custofornec = AlterarTipo<decimal?>(leitor["Custofornec"]);
        _custoproximacompra = AlterarTipo<decimal?>(leitor["Custoproximacompra"]);
        _custorep = AlterarTipo<decimal?>(leitor["Custorep"]);
        _custorepant = AlterarTipo<decimal?>(leitor["Custorepant"]);
        _custorepmc = AlterarTipo<decimal?>(leitor["Custorepmc"]);
        _custoreptab = AlterarTipo<decimal?>(leitor["Custoreptab"]);
        _custoreptabant = AlterarTipo<decimal?>(leitor["Custoreptabant"]);
        _custorepzfm = AlterarTipo<decimal?>(leitor["Custorepzfm"]);
        _custorepzfmant = AlterarTipo<decimal?>(leitor["Custorepzfmant"]);
        _custorepzfmtab = AlterarTipo<decimal?>(leitor["Custorepzfmtab"]);
        _dadostecnicos = AlterarTipo<string>(leitor["Dadostecnicos"]);
        _datavocollect = AlterarTipo<DateTime?>(leitor["Datavocollect"]);
        _denominacaocomunbrasileira = AlterarTipo<string>(leitor["Denominacaocomunbrasileira"]);
        _densidade = AlterarTipo<string>(leitor["Densidade"]);
        _deposito = AlterarTipo<decimal?>(leitor["Deposito"]);
        _depositocx = AlterarTipo<decimal?>(leitor["Depositocx"]);
        _descpapel = AlterarTipo<string>(leitor["Descpapel"]);
        _descricao = AlterarTipo<string>(leitor["Descricao"]);
        _descricao1 = AlterarTipo<string>(leitor["Descricao1"]);
        _descricao2 = AlterarTipo<string>(leitor["Descricao2"]);
        _descricao3 = AlterarTipo<string>(leitor["Descricao3"]);
        _descricao4 = AlterarTipo<string>(leitor["Descricao4"]);
        _descricao5 = AlterarTipo<string>(leitor["Descricao5"]);
        _descricao6 = AlterarTipo<string>(leitor["Descricao6"]);
        _descricao7 = AlterarTipo<string>(leitor["Descricao7"]);
        _desintegracao = AlterarTipo<string>(leitor["Desintegracao"]);
        _destaquefichatecnica = AlterarTipo<string>(leitor["Destaquefichatecnica"]);
        _dirassinatura = AlterarTipo<string>(leitor["Dirassinatura"]);
        _diretoriofotos = AlterarTipo<string>(leitor["Diretoriofotos"]);
        _dirfotoprod = AlterarTipo<string>(leitor["Dirfotoprod"]);
        _dissolucao = AlterarTipo<string>(leitor["Dissolucao"]);
        _doseamento = AlterarTipo<string>(leitor["Doseamento"]);
        _dtaltcustofornec = AlterarTipo<DateTime?>(leitor["Dtaltcustofornec"]);
        _dtcadastro = AlterarTipo<DateTime?>(leitor["Dtcadastro"]);
        _dtdolar = AlterarTipo<string>(leitor["Dtdolar"]);
        _dtexclusao = AlterarTipo<DateTime?>(leitor["Dtexclusao"]);
        _dtexportacaowms = AlterarTipo<DateTime?>(leitor["Dtexportacaowms"]);
        _dtimportacaowms = AlterarTipo<DateTime?>(leitor["Dtimportacaowms"]);
        _dtimportintegracao = AlterarTipo<DateTime?>(leitor["Dtimportintegracao"]);
        _dtinicontlote = AlterarTipo<DateTime?>(leitor["Dtinicontlote"]);
        _dtproxexpurgo = AlterarTipo<DateTime?>(leitor["Dtproxexpurgo"]);
        _dtultaltcom = AlterarTipo<DateTime?>(leitor["Dtultaltcom"]);
        _dtultaltcustorep = AlterarTipo<DateTime?>(leitor["Dtultaltcustorep"]);
        _dtultalter = AlterarTipo<DateTime?>(leitor["Dtultalter"]);
        _dtultaltersrvprc = AlterarTipo<DateTime?>(leitor["Dtultaltersrvprc"]);
        _dtultexpurgo = AlterarTipo<DateTime?>(leitor["Dtultexpurgo"]);
        _dtvenc = AlterarTipo<DateTime?>(leitor["Dtvenc"]);
        _dv = AlterarTipo<decimal?>(leitor["Dv"]);
        _eficienciaoperacional = AlterarTipo<decimal?>(leitor["Eficienciaoperacional"]);
        _embalagem = AlterarTipo<string>(leitor["Embalagem"]);
        _embalagemct = AlterarTipo<string>(leitor["Embalagemct"]);
        _embalagemmaster = AlterarTipo<string>(leitor["Embalagemmaster"]);
        _enviainftecnicanfe = AlterarTipo<string>(leitor["Enviainftecnicanfe"]);
        _enviarforcavendas = AlterarTipo<string>(leitor["Enviarforcavendas"]);
        _enviasngpc = AlterarTipo<string>(leitor["Enviasngpc"]);
        _especificoatividadepr = AlterarTipo<string>(leitor["Especificoatividadepr"]);
        _estfaureaus = AlterarTipo<string>(leitor["Estfaureaus"]);
        _estoqueporlote = AlterarTipo<string>(leitor["Estoqueporlote"]);
        _ex_analisedesc = AlterarTipo<string>(leitor["Ex_Analisedesc"]);
        _ex_boloresleveduras = AlterarTipo<string>(leitor["Ex_Boloresleveduras"]);
        _ex_col95 = AlterarTipo<string>(leitor["Ex_Col95"]);
        _ex_contmicrobiana = AlterarTipo<string>(leitor["Ex_Contmicrobiana"]);
        _ex_densidade = AlterarTipo<string>(leitor["Ex_Densidade"]);
        _ex_desintegracao = AlterarTipo<string>(leitor["Ex_Desintegracao"]);
        _ex_dissolucao = AlterarTipo<string>(leitor["Ex_Dissolucao"]);
        _ex_doseamento = AlterarTipo<string>(leitor["Ex_Doseamento"]);
        _ex_estfaureaus = AlterarTipo<string>(leitor["Ex_Estfaureaus"]);
        _ex_friabilidade = AlterarTipo<string>(leitor["Ex_Friabilidade"]);
        _ex_identificacao = AlterarTipo<string>(leitor["Ex_Identificacao"]);
        _ex_impureza = AlterarTipo<string>(leitor["Ex_Impureza"]);
        _ex_lipideo = AlterarTipo<string>(leitor["Ex_Lipideo"]);
        _ex_mofado = AlterarTipo<string>(leitor["Ex_Mofado"]);
        _ex_pesqpatogenos = AlterarTipo<string>(leitor["Ex_Pesqpatogenos"]);
        _ex_ph = AlterarTipo<string>(leitor["Ex_Ph"]);
        _exportabalanca = AlterarTipo<string>(leitor["Exportabalanca"]);
        _ex_proteina = AlterarTipo<string>(leitor["Ex_Proteina"]);
        _ex_salmonela = AlterarTipo<string>(leitor["Ex_Salmonela"]);
        _extipi = AlterarTipo<string>(leitor["Extipi"]);
        _ex_totdefeito = AlterarTipo<string>(leitor["Ex_Totdefeito"]);
        _ex_umidade = AlterarTipo<string>(leitor["Ex_Umidade"]);
        _ex_uniformidade = AlterarTipo<string>(leitor["Ex_Uniformidade"]);
        _ex_vlcalorico = AlterarTipo<string>(leitor["Ex_Vlcalorico"]);
        _ex_volpesmed = AlterarTipo<string>(leitor["Ex_Volpesmed"]);
        _fatorconvdnf = AlterarTipo<decimal?>(leitor["Fatorconvdnf"]);
        _fatorconversaokg = AlterarTipo<decimal?>(leitor["Fatorconversaokg"]);
        _fatorconversaonestle = AlterarTipo<decimal?>(leitor["Fatorconversaonestle"]);
        _fatortransf = AlterarTipo<decimal?>(leitor["Fatortransf"]);
        _fatorunfarm = AlterarTipo<decimal?>(leitor["Fatorunfarm"]);
        _flags = AlterarTipo<string>(leitor["Flags"]);
        _flag0 = AlterarTipo<string>(leitor["Flag0"]);
        _flag1 = AlterarTipo<string>(leitor["Flag1"]);
        _flag2 = AlterarTipo<string>(leitor["Flag2"]);
        _folharosto = AlterarTipo<string>(leitor["Folharosto"]);
        _fracaocipa = AlterarTipo<decimal?>(leitor["Fracaocipa"]);
        _fracaoseparacao = AlterarTipo<decimal?>(leitor["Fracaoseparacao"]);
        _fracionado = AlterarTipo<string>(leitor["Fracionado"]);
        _freteespecial = AlterarTipo<string>(leitor["Freteespecial"]);
        _friabilidade = AlterarTipo<string>(leitor["Friabilidade"]);
        _fundapiano = AlterarTipo<string>(leitor["Fundapiano"]);
        _geraicmslivrofiscaldevfornec = AlterarTipo<string>(leitor["Geraicmslivrofiscaldevfornec"]);
        _geraosautomatic = AlterarTipo<string>(leitor["Geraosautomatic"]);
        _gramatura = AlterarTipo<decimal?>(leitor["Gramatura"]);
        _grupofaturamento = AlterarTipo<string>(leitor["Grupofaturamento"]);
        _gtincodauxiliar = AlterarTipo<decimal?>(leitor["Gtincodauxiliar"]);
        _gtincodauxiliar2 = AlterarTipo<decimal?>(leitor["Gtincodauxiliar2"]);
        _icmsressarc = AlterarTipo<decimal?>(leitor["Icmsressarc"]);
        _identificacao = AlterarTipo<string>(leitor["Identificacao"]);
        _importado = AlterarTipo<string>(leitor["Importado"]);
        _impureza = AlterarTipo<string>(leitor["Impureza"]);
        _imunetrib = AlterarTipo<string>(leitor["Imunetrib"]);
        _informacoestecnicas = AlterarTipo<string>(leitor["Informacoestecnicas"]);
        _inventarioparcial = AlterarTipo<string>(leitor["Inventarioparcial"]);
        _ipiporvalor = AlterarTipo<string>(leitor["Ipiporvalor"]);
        _irretido = AlterarTipo<decimal?>(leitor["Irretido"]);
        _isentoregms = AlterarTipo<string>(leitor["Isentoregms"]);
        _ivaressarc = AlterarTipo<decimal?>(leitor["Ivaressarc"]);
        _larguraarm = AlterarTipo<decimal?>(leitor["Larguraarm"]);
        _larguram3 = AlterarTipo<decimal?>(leitor["Larguram3"]);
        _lastropal = AlterarTipo<decimal?>(leitor["Lastropal"]);
        _letrapagina = AlterarTipo<string>(leitor["Letrapagina"]);
        _linhaprod = AlterarTipo<decimal?>(leitor["Linhaprod"]);
        _lipideo = AlterarTipo<string>(leitor["Lipideo"]);
        _litragem = AlterarTipo<decimal?>(leitor["Litragem"]);
        _loteinccompra = AlterarTipo<decimal?>(leitor["Loteinccompra"]);
        _lotemincompra = AlterarTipo<decimal?>(leitor["Lotemincompra"]);
        _loteproducao = AlterarTipo<decimal?>(leitor["Loteproducao"]);
        _marca = AlterarTipo<string>(leitor["Marca"]);
        _margemmin = AlterarTipo<decimal?>(leitor["Margemmin"]);
        _medcodfunclibvenda = AlterarTipo<decimal?>(leitor["Medcodfunclibvenda"]);
        _meddtlibvenda = AlterarTipo<DateTime?>(leitor["Meddtlibvenda"]);
        _medicamentohospitalar = AlterarTipo<string>(leitor["Medicamentohospitalar"]);
        _mexfpgc = AlterarTipo<decimal?>(leitor["Mexfpgc"]);
        _mexieps = AlterarTipo<decimal?>(leitor["Mexieps"]);
        _mexiva = AlterarTipo<decimal?>(leitor["Mexiva"]);
        _modulo = AlterarTipo<decimal?>(leitor["Modulo"]);
        _moduloct = AlterarTipo<decimal?>(leitor["Moduloct"]);
        _modulocx = AlterarTipo<decimal?>(leitor["Modulocx"]);
        _modulo2 = AlterarTipo<decimal?>(leitor["Modulo2"]);
        _moeda = AlterarTipo<string>(leitor["Moeda"]);
        _mofado = AlterarTipo<string>(leitor["Mofado"]);
        _multiplo = AlterarTipo<decimal?>(leitor["Multiplo"]);
        _multiplo2 = AlterarTipo<decimal?>(leitor["Multiplo2"]);
        _naturezaproduto = AlterarTipo<string>(leitor["Naturezaproduto"]);
        _nbm = AlterarTipo<string>(leitor["Nbm"]);
        _nivel = AlterarTipo<decimal?>(leitor["Nivel"]);
        _nivelcx = AlterarTipo<decimal?>(leitor["Nivelcx"]);
        _nomecomercial = AlterarTipo<string>(leitor["Nomecomercial"]);
        _nomeecommerce = AlterarTipo<string>(leitor["Nomeecommerce"]);
        _normafornecedor = AlterarTipo<string>(leitor["Normafornecedor"]);
        _normapalete = AlterarTipo<decimal?>(leitor["Normapalete"]);
        _numcasasdecreducaoicms = AlterarTipo<decimal?>(leitor["Numcasasdecreducaoicms"]);
        _numdiasmaxvenda = AlterarTipo<decimal?>(leitor["Numdiasmaxvenda"]);
        _numdiasvalidademin = AlterarTipo<decimal?>(leitor["Numdiasvalidademin"]);
        _numero = AlterarTipo<decimal?>(leitor["Numero"]);
        _numeroct = AlterarTipo<decimal?>(leitor["Numeroct"]);
        _numerocx = AlterarTipo<decimal?>(leitor["Numerocx"]);
        _numero2 = AlterarTipo<decimal?>(leitor["Numero2"]);
        _numlistainventrot = AlterarTipo<decimal?>(leitor["Numlistainventrot"]);
        _numlote = AlterarTipo<string>(leitor["Numlote"]);
        _numoriginal = AlterarTipo<string>(leitor["Numoriginal"]);
        _numpag = AlterarTipo<decimal?>(leitor["Numpag"]);
        _numseqatu = AlterarTipo<decimal?>(leitor["Numseqatu"]);
        _numseqinventrot = AlterarTipo<decimal?>(leitor["Numseqinventrot"]);
        _numservico = AlterarTipo<decimal?>(leitor["Numservico"]);
        _numultexpurgo = AlterarTipo<decimal?>(leitor["Numultexpurgo"]);
        _obrigapreenccontrato = AlterarTipo<string>(leitor["Obrigapreenccontrato"]);
        _obs = AlterarTipo<string>(leitor["Obs"]);
        _obs2 = AlterarTipo<string>(leitor["Obs2"]);
        _oscomodato = AlterarTipo<string>(leitor["Oscomodato"]);
        _paisorigem = AlterarTipo<string>(leitor["Paisorigem"]);
        _passelivre = AlterarTipo<string>(leitor["Passelivre"]);
        _pckrotativo = AlterarTipo<string>(leitor["Pckrotativo"]);
        _pcomext1 = AlterarTipo<decimal?>(leitor["Pcomext1"]);
        _pcomint1 = AlterarTipo<decimal?>(leitor["Pcomint1"]);
        _pcomprof1 = AlterarTipo<decimal?>(leitor["Pcomprof1"]);
        _pcomrep1 = AlterarTipo<decimal?>(leitor["Pcomrep1"]);
        _pcomtlmkt = AlterarTipo<decimal?>(leitor["Pcomtlmkt"]);
        _percacres = AlterarTipo<decimal?>(leitor["Percacres"]);
        _percaliqcredicmsdiferest = AlterarTipo<decimal?>(leitor["Percaliqcredicmsdiferest"]);
        _percaliqcredicmsdiferinter = AlterarTipo<decimal?>(leitor["Percaliqcredicmsdiferinter"]);
        _percaliqext = AlterarTipo<decimal?>(leitor["Percaliqext"]);
        _percaliqextbcr = AlterarTipo<decimal?>(leitor["Percaliqextbcr"]);
        _percaliqextguia = AlterarTipo<decimal?>(leitor["Percaliqextguia"]);
        _percaliqexticmantecip = AlterarTipo<decimal?>(leitor["Percaliqexticmantecip"]);
        _percaliqint = AlterarTipo<decimal?>(leitor["Percaliqint"]);
        _percaliqintbcr = AlterarTipo<decimal?>(leitor["Percaliqintbcr"]);
        _percaliqinticmantecip = AlterarTipo<decimal?>(leitor["Percaliqinticmantecip"]);
        _percbaseredent = AlterarTipo<decimal?>(leitor["Percbaseredent"]);
        _percbon = AlterarTipo<decimal?>(leitor["Percbon"]);
        _percbonificvenda = AlterarTipo<decimal?>(leitor["Percbonificvenda"]);
        _percbonoutras = AlterarTipo<decimal?>(leitor["Percbonoutras"]);
        _perccargatribmedia = AlterarTipo<decimal?>(leitor["Perccargatribmedia"]);
        _perccommot = AlterarTipo<decimal?>(leitor["Perccommot"]);
        _perccredicmpresumido = AlterarTipo<decimal?>(leitor["Perccredicmpresumido"]);
        _percdesc = AlterarTipo<decimal?>(leitor["Percdesc"]);
        _percdescicms = AlterarTipo<decimal?>(leitor["Percdescicms"]);
        _percdescicmsdif = AlterarTipo<decimal?>(leitor["Percdescicmsdif"]);
        _percdesc1 = AlterarTipo<decimal?>(leitor["Percdesc1"]);
        _percdesc10 = AlterarTipo<decimal?>(leitor["Percdesc10"]);
        _percdesc2 = AlterarTipo<decimal?>(leitor["Percdesc2"]);
        _percdesc3 = AlterarTipo<decimal?>(leitor["Percdesc3"]);
        _percdesc4 = AlterarTipo<decimal?>(leitor["Percdesc4"]);
        _percdesc5 = AlterarTipo<decimal?>(leitor["Percdesc5"]);
        _percdesc6 = AlterarTipo<decimal?>(leitor["Percdesc6"]);
        _percdesc7 = AlterarTipo<decimal?>(leitor["Percdesc7"]);
        _percdesc8 = AlterarTipo<decimal?>(leitor["Percdesc8"]);
        _percdesc9 = AlterarTipo<decimal?>(leitor["Percdesc9"]);
        _percdespadicional = AlterarTipo<decimal?>(leitor["Percdespadicional"]);
        _percdespdentronf = AlterarTipo<decimal?>(leitor["Percdespdentronf"]);
        _percdespfin = AlterarTipo<decimal?>(leitor["Percdespfin"]);
        _percdespforanf = AlterarTipo<decimal?>(leitor["Percdespforanf"]);
        _percdifaliquotas = AlterarTipo<decimal?>(leitor["Percdifaliquotas"]);
        _percdiferencakgfrio = AlterarTipo<decimal?>(leitor["Percdiferencakgfrio"]);
        _percfrete = AlterarTipo<decimal?>(leitor["Percfrete"]);
        _percfretefob = AlterarTipo<decimal?>(leitor["Percfretefob"]);
        _percicmred = AlterarTipo<decimal?>(leitor["Percicmred"]);
        _percicmsdiferido = AlterarTipo<decimal?>(leitor["Percicmsdiferido"]);
        _percicmsfretefobst = AlterarTipo<decimal?>(leitor["Percicmsfretefobst"]);
        _percicmsfretefobstbcr = AlterarTipo<decimal?>(leitor["Percicmsfretefobstbcr"]);
        _percimportacao = AlterarTipo<decimal?>(leitor["Percimportacao"]);
        _percimpprodutorural = AlterarTipo<decimal?>(leitor["Percimpprodutorural"]);
        _percipi = AlterarTipo<decimal?>(leitor["Percipi"]);
        _percipivenda = AlterarTipo<decimal?>(leitor["Percipivenda"]);
        _percipivendatab = AlterarTipo<decimal?>(leitor["Percipivendatab"]);
        _perciva = AlterarTipo<decimal?>(leitor["Perciva"]);
        _percivabcr = AlterarTipo<decimal?>(leitor["Percivabcr"]);
        _percivaicmantecip = AlterarTipo<decimal?>(leitor["Percivaicmantecip"]);
        _percmvaorig = AlterarTipo<decimal?>(leitor["Percmvaorig"]);
        _percofins = AlterarTipo<decimal?>(leitor["Percofins"]);
        _percofinsimp = AlterarTipo<decimal?>(leitor["Percofinsimp"]);
        _percoutrasdesp = AlterarTipo<decimal?>(leitor["Percoutrasdesp"]);
        _percperdakg = AlterarTipo<decimal?>(leitor["Percperdakg"]);
        _percquebraproducao = AlterarTipo<decimal?>(leitor["Percquebraproducao"]);
        _percredicms = AlterarTipo<decimal?>(leitor["Percredicms"]);
        _percredpmc = AlterarTipo<decimal?>(leitor["Percredpmc"]);
        _percseguro = AlterarTipo<decimal?>(leitor["Percseguro"]);
        _percst = AlterarTipo<decimal?>(leitor["Percst"]);
        _percsuframa = AlterarTipo<decimal?>(leitor["Percsuframa"]);
        _perctoleranciaval = AlterarTipo<decimal?>(leitor["Perctoleranciaval"]);
        _percvenda = AlterarTipo<decimal?>(leitor["Percvenda"]);
        _pericm = AlterarTipo<decimal?>(leitor["Pericm"]);
        _pericmfrete = AlterarTipo<decimal?>(leitor["Pericmfrete"]);
        _pericmsantecipado = AlterarTipo<decimal?>(leitor["Pericmsantecipado"]);
        _perindeniz = AlterarTipo<decimal?>(leitor["Perindeniz"]);
        _permiteproducao = AlterarTipo<string>(leitor["Permiteproducao"]);
        _perpis = AlterarTipo<decimal?>(leitor["Perpis"]);
        _perpisimp = AlterarTipo<decimal?>(leitor["Perpisimp"]);
        _pesobruto = AlterarTipo<decimal?>(leitor["Pesobruto"]);
        _pesobrutomaster = AlterarTipo<decimal?>(leitor["Pesobrutomaster"]);
        _pesoembalagem = AlterarTipo<decimal?>(leitor["Pesoembalagem"]);
        _pesoliq = AlterarTipo<decimal?>(leitor["Pesoliq"]);
        _pesoliqmaster = AlterarTipo<decimal?>(leitor["Pesoliqmaster"]);
        _pesopalete = AlterarTipo<decimal?>(leitor["Pesopalete"]);
        _pesopeca = AlterarTipo<decimal?>(leitor["Pesopeca"]);
        _pesovariavel = AlterarTipo<string>(leitor["Pesovariavel"]);
        _pesqpatogenos = AlterarTipo<string>(leitor["Pesqpatogenos"]);
        _ph = AlterarTipo<string>(leitor["Ph"]);
        _piscofinsretido = AlterarTipo<string>(leitor["Piscofinsretido"]);
        _pisretido = AlterarTipo<decimal?>(leitor["Pisretido"]);
        _pontoreposicao = AlterarTipo<decimal?>(leitor["Pontoreposicao"]);
        _pontoreposicaoal = AlterarTipo<decimal?>(leitor["Pontoreposicaoal"]);
        _pontoreposicaocx = AlterarTipo<decimal?>(leitor["Pontoreposicaocx"]);
        _pontoreposicaopa = AlterarTipo<decimal?>(leitor["Pontoreposicaopa"]);
        _prazo = AlterarTipo<decimal?>(leitor["Prazo"]);
        _prazoentr = AlterarTipo<decimal?>(leitor["Prazoentr"]);
        _prazoexpurgo = AlterarTipo<decimal?>(leitor["Prazoexpurgo"]);
        _prazogarantia = AlterarTipo<decimal?>(leitor["Prazogarantia"]);
        _prazomaxindenizacao = AlterarTipo<decimal?>(leitor["Prazomaxindenizacao"]);
        _prazomaxvalidade = AlterarTipo<decimal?>(leitor["Prazomaxvalidade"]);
        _prazomaxvenda = AlterarTipo<decimal?>(leitor["Prazomaxvenda"]);
        _prazomedioproducao = AlterarTipo<decimal?>(leitor["Prazomedioproducao"]);
        _prazomediovenda = AlterarTipo<decimal?>(leitor["Prazomediovenda"]);
        _prazominvalidade = AlterarTipo<decimal?>(leitor["Prazominvalidade"]);
        _prazoval = AlterarTipo<decimal?>(leitor["Prazoval"]);
        _precificestrangeira = AlterarTipo<string>(leitor["Precificestrangeira"]);
        _precofixo = AlterarTipo<string>(leitor["Precofixo"]);
        _precomaxconsum = AlterarTipo<decimal?>(leitor["Precomaxconsum"]);
        _precomaxconsumtab = AlterarTipo<decimal?>(leitor["Precomaxconsumtab"]);
        _precomaxconsumtabant = AlterarTipo<decimal?>(leitor["Precomaxconsumtabant"]);
        _precomaxconsumzfm = AlterarTipo<decimal?>(leitor["Precomaxconsumzfm"]);
        _precomaxconsumzfmant = AlterarTipo<decimal?>(leitor["Precomaxconsumzfmant"]);
        _precomaxconsumzfmtab = AlterarTipo<decimal?>(leitor["Precomaxconsumzfmtab"]);
        _predio = AlterarTipo<decimal?>(leitor["Predio"]);
        _prediocx = AlterarTipo<decimal?>(leitor["Prediocx"]);
        _prefixolote = AlterarTipo<string>(leitor["Prefixolote"]);
        _principioativo = AlterarTipo<string>(leitor["Principioativo"]);
        _proteina = AlterarTipo<string>(leitor["Proteina"]);
        _proxnumlote = AlterarTipo<decimal?>(leitor["Proxnumlote"]);
        _psicotropico = AlterarTipo<string>(leitor["Psicotropico"]);
        _ptabelafornec = AlterarTipo<decimal?>(leitor["Ptabelafornec"]);
        _pvenda = AlterarTipo<decimal?>(leitor["Pvenda"]);
        _qtdemaxseparpedido = AlterarTipo<decimal?>(leitor["Qtdemaxseparpedido"]);
        _qtdmaxsepararpedido = AlterarTipo<decimal?>(leitor["Qtdmaxsepararpedido"]);
        _qtmaxgondula = AlterarTipo<decimal?>(leitor["Qtmaxgondula"]);
        _qtmetros = AlterarTipo<decimal?>(leitor["Qtmetros"]);
        _qtmingondula = AlterarTipo<decimal?>(leitor["Qtmingondula"]);
        _qtminimaatacado = AlterarTipo<decimal?>(leitor["Qtminimaatacado"]);
        _qtminimaatacadof = AlterarTipo<decimal?>(leitor["Qtminimaatacadof"]);
        _qtminproduzir = AlterarTipo<decimal?>(leitor["Qtminproduzir"]);
        _qtminsugcompra = AlterarTipo<decimal?>(leitor["Qtminsugcompra"]);
        _qtpontopedido = AlterarTipo<decimal?>(leitor["Qtpontopedido"]);
        _qtproduzir = AlterarTipo<decimal?>(leitor["Qtproduzir"]);
        _qtpulmaoregulador = AlterarTipo<decimal?>(leitor["Qtpulmaoregulador"]);
        _qttotpal = AlterarTipo<decimal?>(leitor["Qttotpal"]);
        _qttotpalfrac = AlterarTipo<decimal?>(leitor["Qttotpalfrac"]);
        _qtunit = AlterarTipo<decimal?>(leitor["Qtunit"]);
        _qtunitct = AlterarTipo<decimal?>(leitor["Qtunitct"]);
        _qtunitcx = AlterarTipo<decimal?>(leitor["Qtunitcx"]);
        _recminarm = AlterarTipo<decimal?>(leitor["Recminarm"]);
        _redbasealiqext = AlterarTipo<decimal?>(leitor["Redbasealiqext"]);
        _redbasealiqextbcr = AlterarTipo<decimal?>(leitor["Redbasealiqextbcr"]);
        _redbaseiva = AlterarTipo<decimal?>(leitor["Redbaseiva"]);
        _redbaseivabcr = AlterarTipo<decimal?>(leitor["Redbaseivabcr"]);
        _registromsmed = AlterarTipo<string>(leitor["Registromsmed"]);
        _regms = AlterarTipo<string>(leitor["Regms"]);
        _restricaoblocado = AlterarTipo<decimal?>(leitor["Restricaoblocado"]);
        _restricaotransp = AlterarTipo<string>(leitor["Restricaotransp"]);
        _restringecotacao = AlterarTipo<string>(leitor["Restringecotacao"]);
        _revenda = AlterarTipo<string>(leitor["Revenda"]);
        _rotinalanc = AlterarTipo<string>(leitor["Rotinalanc"]);
        _rua = AlterarTipo<decimal?>(leitor["Rua"]);
        _ruact = AlterarTipo<decimal?>(leitor["Ruact"]);
        _ruacx = AlterarTipo<decimal?>(leitor["Ruacx"]);
        _rua2 = AlterarTipo<decimal?>(leitor["Rua2"]);
        _salmonela = AlterarTipo<string>(leitor["Salmonela"]);
        _seqpagina = AlterarTipo<decimal?>(leitor["Seqpagina"]);
        _seqtabpreco = AlterarTipo<decimal?>(leitor["Seqtabpreco"]);
        _simpro = AlterarTipo<string>(leitor["Simpro"]);
        _sittribut = AlterarTipo<string>(leitor["Sittribut"]);
        _sittributdev = AlterarTipo<string>(leitor["Sittributdev"]);
        _sittributdevfornec = AlterarTipo<string>(leitor["Sittributdevfornec"]);
        _sittributent = AlterarTipo<string>(leitor["Sittributent"]);
        _somentetv3 = AlterarTipo<string>(leitor["Somentetv3"]);
        _status = AlterarTipo<string>(leitor["Status"]);
        _substancia = AlterarTipo<string>(leitor["Substancia"]);
        _subtituloecommerce = AlterarTipo<string>(leitor["Subtituloecommerce"]);
        _sugvenda = AlterarTipo<decimal?>(leitor["Sugvenda"]);
        _tamanholotefab = AlterarTipo<decimal?>(leitor["Tamanholotefab"]);
        _temrepos = AlterarTipo<decimal?>(leitor["Temrepos"]);
        _tipoalturapalete = AlterarTipo<decimal?>(leitor["Tipoalturapalete"]);
        _tipoarm = AlterarTipo<decimal?>(leitor["Tipoarm"]);
        _tipocalcst = AlterarTipo<string>(leitor["Tipocalcst"]);
        _tipocarga = AlterarTipo<decimal?>(leitor["Tipocarga"]);
        _tipocomissao = AlterarTipo<string>(leitor["Tipocomissao"]);
        _tipodescarga = AlterarTipo<string>(leitor["Tipodescarga"]);
        _tipoembalage = AlterarTipo<string>(leitor["Tipoembalage"]);
        _tipoembalagemnestle = AlterarTipo<decimal?>(leitor["Tipoembalagemnestle"]);
        _tipoestoque = AlterarTipo<string>(leitor["Tipoestoque"]);
        _tipomedicamento = AlterarTipo<string>(leitor["Tipomedicamento"]);
        _tipomerc = AlterarTipo<string>(leitor["Tipomerc"]);
        _tipomp = AlterarTipo<string>(leitor["Tipomp"]);
        _tiponorma = AlterarTipo<string>(leitor["Tiponorma"]);
        _tipopal = AlterarTipo<decimal?>(leitor["Tipopal"]);
        _tipopalpul = AlterarTipo<decimal?>(leitor["Tipopalpul"]);
        _tipopiscofinsretido = AlterarTipo<decimal?>(leitor["Tipopiscofinsretido"]);
        _tipoprod = AlterarTipo<decimal?>(leitor["Tipoprod"]);
        _tiporestricao = AlterarTipo<string>(leitor["Tiporestricao"]);
        _tiporestricaomed = AlterarTipo<string>(leitor["Tiporestricaomed"]);
        _tiposugcompra = AlterarTipo<string>(leitor["Tiposugcompra"]);
        _tipotributmedic = AlterarTipo<string>(leitor["Tipotributmedic"]);
        _tipovolumedescarga = AlterarTipo<string>(leitor["Tipovolumedescarga"]);
        _tituloecommerce = AlterarTipo<string>(leitor["Tituloecommerce"]);
        _totdefeito = AlterarTipo<string>(leitor["Totdefeito"]);
        _tribfederal = AlterarTipo<string>(leitor["Tribfederal"]);
        _umidade = AlterarTipo<string>(leitor["Umidade"]);
        _umidadeanalise = AlterarTipo<string>(leitor["Umidadeanalise"]);
        _undporembalagem = AlterarTipo<decimal?>(leitor["Undporembalagem"]);
        _unidade = AlterarTipo<string>(leitor["Unidade"]);
        _unidadect = AlterarTipo<string>(leitor["Unidadect"]);
        _unidademaster = AlterarTipo<string>(leitor["Unidademaster"]);
        _uniformidade = AlterarTipo<string>(leitor["Uniformidade"]);
        _usaaliqcredicmsdifer = AlterarTipo<string>(leitor["Usaaliqcredicmsdifer"]);
        _usaclassificacao = AlterarTipo<string>(leitor["Usaclassificacao"]);
        _usacross = AlterarTipo<string>(leitor["Usacross"]);
        _usapiscofinslit = AlterarTipo<string>(leitor["Usapiscofinslit"]);
        _usapiscofinslitimp = AlterarTipo<string>(leitor["Usapiscofinslitimp"]);
        _usapmcbasest = AlterarTipo<string>(leitor["Usapmcbasest"]);
        _usapulmaoregulador = AlterarTipo<string>(leitor["Usapulmaoregulador"]);
        _usawms = AlterarTipo<string>(leitor["Usawms"]);
        _utilizaprecomaxconsumidor = AlterarTipo<string>(leitor["Utilizaprecomaxconsumidor"]);
        _utilizarvasilhame = AlterarTipo<string>(leitor["Utilizarvasilhame"]);
        _utilizaselo = AlterarTipo<string>(leitor["Utilizaselo"]);
        _validarlote = AlterarTipo<string>(leitor["Validarlote"]);
        _valorcofinslitragem = AlterarTipo<decimal?>(leitor["Valorcofinslitragem"]);
        _valorpislitragem = AlterarTipo<decimal?>(leitor["Valorpislitragem"]);
        _velocidadeesp = AlterarTipo<decimal?>(leitor["Velocidadeesp"]);
        _velocidadeoperacional = AlterarTipo<decimal?>(leitor["Velocidadeoperacional"]);
        _vendadireta = AlterarTipo<string>(leitor["Vendadireta"]);
        _versanalise = AlterarTipo<decimal?>(leitor["Versanalise"]);
        _vladicionalbcst = AlterarTipo<decimal?>(leitor["Vladicionalbcst"]);
        _vladicionalbcstbcr = AlterarTipo<decimal?>(leitor["Vladicionalbcstbcr"]);
        _vlbonific = AlterarTipo<decimal?>(leitor["Vlbonific"]);
        _vlcalorico = AlterarTipo<string>(leitor["Vlcalorico"]);
        _vlcofinslit = AlterarTipo<decimal?>(leitor["Vlcofinslit"]);
        _vlcofinslitimp = AlterarTipo<decimal?>(leitor["Vlcofinslitimp"]);
        _vldifaliquotas = AlterarTipo<decimal?>(leitor["Vldifaliquotas"]);
        _vlfreteporkg = AlterarTipo<decimal?>(leitor["Vlfreteporkg"]);
        _vlicmsantecipado = AlterarTipo<decimal?>(leitor["Vlicmsantecipado"]);
        _vlipi = AlterarTipo<decimal?>(leitor["Vlipi"]);
        _vlipipeso = AlterarTipo<decimal?>(leitor["Vlipipeso"]);
        _vlipiporkg = AlterarTipo<decimal?>(leitor["Vlipiporkg"]);
        _vlipiporkgvenda = AlterarTipo<decimal?>(leitor["Vlipiporkgvenda"]);
        _vlipiporkgvendatab = AlterarTipo<decimal?>(leitor["Vlipiporkgvendatab"]);
        _vlmaodeobra = AlterarTipo<decimal?>(leitor["Vlmaodeobra"]);
        _vlpauta = AlterarTipo<decimal?>(leitor["Vlpauta"]);
        _vlpautabcr = AlterarTipo<decimal?>(leitor["Vlpautabcr"]);
        _vlpautaicms = AlterarTipo<decimal?>(leitor["Vlpautaicms"]);
        _vlpautaicmsantec = AlterarTipo<decimal?>(leitor["Vlpautaicmsantec"]);
        _vlpautaipi = AlterarTipo<decimal?>(leitor["Vlpautaipi"]);
        _vlpautaipivenda = AlterarTipo<decimal?>(leitor["Vlpautaipivenda"]);
        _vlpautaipivendatab = AlterarTipo<decimal?>(leitor["Vlpautaipivendatab"]);
        _vlpautapiscofins = AlterarTipo<decimal?>(leitor["Vlpautapiscofins"]);
        _vlpautapiscofinsimp = AlterarTipo<decimal?>(leitor["Vlpautapiscofinsimp"]);
        _vlpislit = AlterarTipo<decimal?>(leitor["Vlpislit"]);
        _vlpislitimp = AlterarTipo<decimal?>(leitor["Vlpislitimp"]);
        _vlraplicint = AlterarTipo<decimal?>(leitor["Vlraplicint"]);
        _vlvendatemp = AlterarTipo<decimal?>(leitor["Vlvendatemp"]);
        _volpesmed = AlterarTipo<string>(leitor["Volpesmed"]);
        _volume = AlterarTipo<decimal?>(leitor["Volume"]);
        _volumearm = AlterarTipo<decimal?>(leitor["Volumearm"]);
        _volumerec = AlterarTipo<decimal?>(leitor["Volumerec"]);
    }

}