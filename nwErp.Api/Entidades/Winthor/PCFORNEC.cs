[Serializable]
public class PCFORNEC : GerenteDePropriedades, IEntidade
{
    private static readonly string RO_CODFORNEC = "Codfornec";
    private int _codfornec;
    
    private static readonly string RO_FORNECEDOR = "Fornecedor";
    private string _fornecedor;
    
    private static readonly string RO_REPRES = "Repres";
    private string? _repres;
    
    private static readonly string RO_CONTATO = "Contato";
    private string? _contato;
    
    private static readonly string RO_ENDER = "Ender";
    private string? _ender;
    
    private static readonly string RO_CIDADE = "Cidade";
    private string? _cidade;
    
    private static readonly string RO_ESTADO = "Estado";
    private string? _estado;
    
    private static readonly string RO_CEP = "Cep";
    private string? _cep;
    
    private static readonly string RO_TELREP = "Telrep";
    private string? _telrep;
    
    private static readonly string RO_TELFAB = "Telfab";
    private string? _telfab;
    
    private static readonly string RO_TELEXREP = "Telexrep";
    private string? _telexrep;
    
    private static readonly string RO_TELEXFAB = "Telexfab";
    private string? _telexfab;
    
    private static readonly string RO_IE = "Ie";
    private string? _ie;
    
    private static readonly string RO_CGC = "Cgc";
    private string? _cgc;
    
    private static readonly string RO_FAXREP = "Faxrep";
    private string? _faxrep;
    
    private static readonly string RO_FAXFAB = "Faxfab";
    private string? _faxfab;
    
    private static readonly string RO_BAIRRO = "Bairro";
    private string? _bairro;
    
    private static readonly string RO_PRAZOENTREGA = "Prazoentrega";
    private int? _prazoentrega;
    
    private static readonly string RO_BLOQUEIO = "Bloqueio";
    private string? _bloqueio;
    
    private static readonly string RO_DTBLOQUEIO = "Dtbloqueio";
    private DateTime? _dtbloqueio;
    
    private static readonly string RO_OBS = "Obs";
    private string? _obs;
    
    private static readonly string RO_REVENDA = "Revenda";
    private string? _revenda;
    
    private static readonly string RO_CODCLI = "Codcli";
    private int? _codcli;
    
    private static readonly string RO_CODCOMPRADOR = "Codcomprador";
    private int? _codcomprador;
    
    private static readonly string RO_REP_CONTATO = "Rep_contato";
    private string? _rep_contato;
    
    private static readonly string RO_REP_ENDERECO = "Rep_endereco";
    private string? _rep_endereco;
    
    private static readonly string RO_REP_BAIRRO = "Rep_bairro";
    private string? _rep_bairro;
    
    private static readonly string RO_REP_CIDADE = "Rep_cidade";
    private string? _rep_cidade;
    
    private static readonly string RO_REP_UF = "Rep_uf";
    private string? _rep_uf;
    
    private static readonly string RO_REP_CEP = "Rep_cep";
    private int? _rep_cep;
    
    private static readonly string RO_EXCLUIDO = "Excluido";
    private string? _excluido;
    
    private static readonly string RO_LEDTIME = "Ledtime";
    private int? _ledtime;
    
    private static readonly string RO_COBERTURA = "Cobertura";
    private int? _cobertura;
    
    private static readonly string RO_REGIONAL = "Regional";
    private string? _regional;
    
    private static readonly string RO_CENTRALIZACAO = "Centralizacao";
    private string? _centralizacao;
    
    private static readonly string RO_DTCADASTRO = "Dtcadastro";
    private DateTime? _dtcadastro;
    
    private static readonly string RO_DTEXCLUSAO = "Dtexclusao";
    private DateTime? _dtexclusao;
    
    private static readonly string RO_OBS2 = "Obs2";
    private string? _obs2;
    
    private static readonly string RO_PRAZOMIN = "Prazomin";
    private int? _prazomin;
    
    private static readonly string RO_DESCPAGTODUP = "Descpagtodup";
    private string? _descpagtodup;
    
    private static readonly string RO_ENDERCOB = "Endercob";
    private string? _endercob;
    
    private static readonly string RO_BAIRROCOB = "Bairrocob";
    private string? _bairrocob;
    
    private static readonly string RO_MUNICOB = "Municob";
    private string? _municob;
    
    private static readonly string RO_ESTCOB = "Estcob";
    private string? _estcob;
    
    private static readonly string RO_CEPCOB = "Cepcob";
    private string? _cepcob;
    
    private static readonly string RO_TELCOB = "Telcob";
    private string? _telcob;
    
    private static readonly string RO_ESTRATEGICO = "Estrategico";
    private string? _estrategico;
    
    private static readonly string RO_OBSERVACAO = "Observacao";
    private string? _observacao;
    
    private static readonly string RO_CODDEPTO = "Coddepto";
    private int? _coddepto;
    
    private static readonly string RO_CODFORNECPRINC = "Codfornecprinc";
    private int? _codfornecprinc;
    
    private static readonly string RO_CONTATOCOM = "Contatocom";
    private string? _contatocom;
    
    private static readonly string RO_TELEFONECOM = "Telefonecom";
    private string? _telefonecom;
    
    private static readonly string RO_CONTATOADM = "Contatoadm";
    private string? _contatoadm;
    
    private static readonly string RO_TELEFONEADM = "Telefoneadm";
    private string? _telefoneadm;
    
    private static readonly string RO_DIASEMANAATEND = "Diasemanaatend";
    private int? _diasemanaatend;
    
    private static readonly string RO_PERIOCIDADEATEND = "Periocidadeatend";
    private int? _periocidadeatend;
    
    private static readonly string RO_DTPROXATEND = "Dtproxatend";
    private DateTime? _dtproxatend;
    
    private static readonly string RO_CLASSEVENDA = "Classevenda";
    private string? _classevenda;
    
    private static readonly string RO_CLASSEMC = "Classemc";
    private string? _classemc;
    
    private static readonly string RO_CLASSEESTOQUE = "Classeestoque";
    private string? _classeestoque;
    
    private static readonly string RO_CLASSECOMPRA = "Classecompra";
    private string? _classecompra;
    
    private static readonly string RO_EMAIL = "Email";
    private string? _email;
    
    private static readonly string RO_PRAZO1 = "Prazo1";
    private int? _prazo1;
    
    private static readonly string RO_PRAZO2 = "Prazo2";
    private int? _prazo2;
    
    private static readonly string RO_PRAZO3 = "Prazo3";
    private int? _prazo3;
    
    private static readonly string RO_PRAZO4 = "Prazo4";
    private int? _prazo4;
    
    private static readonly string RO_PRAZO5 = "Prazo5";
    private int? _prazo5;
    
    private static readonly string RO_PRAZO6 = "Prazo6";
    private int? _prazo6;
    
    private static readonly string RO_PERCDESPFIN = "Percdespfin";
    private decimal? _percdespfin;
    
    private static readonly string RO_PERCDESCFIN = "Percdescfin";
    private decimal? _percdescfin;
    
    private static readonly string RO_NUMBANCODOC = "Numbancodoc";
    private int? _numbancodoc;
    
    private static readonly string RO_NUMAGENCIADOC = "Numagenciadoc";
    private int? _numagenciadoc;
    
    private static readonly string RO_NUMCCORRENTEDOC = "Numccorrentedoc";
    private string? _numccorrentedoc;
    
    private static readonly string RO_FANTASIA = "Fantasia";
    private string? _fantasia;
    
    private static readonly string RO_NUMDEPIRRF = "Numdepirrf";
    private int? _numdepirrf;
    
    private static readonly string RO_VALORDEDUCAOIRRF = "Valordeducaoirrf";
    private decimal? _valordeducaoirrf;
    
    private static readonly string RO_RG = "Rg";
    private string? _rg;
    
    private static readonly string RO_CODDISTRIB = "Coddistrib";
    private string? _coddistrib;
    
    private static readonly string RO_VLFRETEKG = "Vlfretekg";
    private decimal? _vlfretekg;
    
    private static readonly string RO_PERCOUTROSCUSTOSFRETE = "Percoutroscustosfrete";
    private decimal? _percoutroscustosfrete;
    
    private static readonly string RO_DISTRIB = "Distrib";
    private string? _distrib;
    
    private static readonly string RO_INSCESTRANGEIRA = "Inscestrangeira";
    private int? _inscestrangeira;
    
    private static readonly string RO_INDUSTRIALOCAL = "Industrialocal";
    private string? _industrialocal;
    
    private static readonly string RO_GRUPOCAMPANHA = "Grupocampanha";
    private int? _grupocampanha;
    
    private static readonly string RO_PERCMAXBONIFIC = "Percmaxbonific";
    private decimal? _percmaxbonific;
    
    private static readonly string RO_PERCPISRED = "Percpisred";
    private decimal? _percpisred;
    
    private static readonly string RO_SUFRAMA = "Suframa";
    private string? _suframa;
    
    private static readonly string RO_CODPRODUTORRURAL = "Codprodutorrural";
    private string? _codprodutorrural;
    
    private static readonly string RO_DVAG = "Dvag";
    private string? _dvag;
    
    private static readonly string RO_DVCC = "Dvcc";
    private string? _dvcc;
    
    private static readonly string RO_TIPOEMBALAGEMPEDIDO = "Tipoembalagempedido";
    private string? _tipoembalagempedido;
    
    private static readonly string RO_SUPERVISORVERBA = "Supervisorverba";
    private string? _supervisorverba;
    
    private static readonly string RO_CONTATOVERBA = "Contatoverba";
    private string? _contatoverba;
    
    private static readonly string RO_CPFCONTATOVERBA = "Cpfcontatoverba";
    private string? _cpfcontatoverba;
    
    private static readonly string RO_RGCONTATOVERBA = "Rgcontatoverba";
    private string? _rgcontatoverba;
    
    private static readonly string RO_REP_DTANIVERSARIO = "Rep_dtaniversario";
    private DateTime? _rep_dtaniversario;
    
    private static readonly string RO_ADM_CONTATO = "Adm_contato";
    private string? _adm_contato;
    
    private static readonly string RO_ADM_DTANIVERSARIO = "Adm_dtaniversario";
    private DateTime? _adm_dtaniversario;
    
    private static readonly string RO_ADM_ENDERECO = "Adm_endereco";
    private string? _adm_endereco;
    
    private static readonly string RO_ADM_BAIRRO = "Adm_bairro";
    private string? _adm_bairro;
    
    private static readonly string RO_ADM_CIDADE = "Adm_cidade";
    private string? _adm_cidade;
    
    private static readonly string RO_ADM_UF = "Adm_uf";
    private string? _adm_uf;
    
    private static readonly string RO_ADM_CEP = "Adm_cep";
    private int? _adm_cep;
    
    private static readonly string RO_COM_CONTATO = "Com_contato";
    private string? _com_contato;
    
    private static readonly string RO_COM_DTANIVERSARIO = "Com_dtaniversario";
    private DateTime? _com_dtaniversario;
    
    private static readonly string RO_COM_ENDERECO = "Com_endereco";
    private string? _com_endereco;
    
    private static readonly string RO_COM_BAIRRO = "Com_bairro";
    private string? _com_bairro;
    
    private static readonly string RO_COM_CIDADE = "Com_cidade";
    private string? _com_cidade;
    
    private static readonly string RO_COM_UF = "Com_uf";
    private string? _com_uf;
    
    private static readonly string RO_COM_CEP = "Com_cep";
    private int? _com_cep;
    
    private static readonly string RO_TRANSPORTEPROPRIO = "Transporteproprio";
    private string? _transporteproprio;
    
    private static readonly string RO_VLPEDAGIO = "Vlpedagio";
    private decimal? _vlpedagio;
    
    private static readonly string RO_PERGRIS = "Pergris";
    private decimal? _pergris;
    
    private static readonly string RO_ICMSSOBRETXMINIMA = "Icmssobretxminima";
    private string? _icmssobretxminima;
    
    private static readonly string RO_GATILHO = "Gatilho";
    private decimal? _gatilho;
    
    private static readonly string RO_TIPOCALCFRETE = "Tipocalcfrete";
    private int? _tipocalcfrete;
    
    private static readonly string RO_TAXA0 = "Taxa0";
    private decimal? _taxa0;
    
    private static readonly string RO_TAXA7 = "Taxa7";
    private decimal? _taxa7;
    
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
    
    private static readonly string RO_DTULTCONTATOCOB = "Dtultcontatocob";
    private DateTime? _dtultcontatocob;
    
    private static readonly string RO_CODFUNCULTCONTATOCOB = "Codfuncultcontatocob";
    private int? _codfuncultcontatocob;
    
    private static readonly string RO_DTPROXCONTATOCOB = "Dtproxcontatocob";
    private DateTime? _dtproxcontatocob;
    
    private static readonly string RO_CODMUNICIPIO = "Codmunicipio";
    private int? _codmunicipio;
    
    private static readonly string RO_COM_EMAIL = "Com_email";
    private string? _com_email;
    
    private static readonly string RO_REP_EMAIL = "Rep_email";
    private string? _rep_email;
    
    private static readonly string RO_SUP_EMAIL = "Sup_email";
    private string? _sup_email;
    
    private static readonly string RO_DTVALIDADE = "Dtvalidade";
    private DateTime? _dtvalidade;
    
    private static readonly string RO_TIPOFORNEC = "Tipofornec";
    private string? _tipofornec;
    
    private static readonly string RO_UTILIZADESCCALCIPI = "Utilizadesccalcipi";
    private string? _utilizadesccalcipi;
    
    private static readonly string RO_UTILIZAFRETECALCIPI = "Utilizafretecalcipi";
    private string? _utilizafretecalcipi;
    
    private static readonly string RO_VLMINPEDCOMPRA = "Vlminpedcompra";
    private decimal? _vlminpedcompra;
    
    private static readonly string RO_SUP_CELULAR = "Sup_celular";
    private string? _sup_celular;
    
    private static readonly string RO_COM_CELULAR = "Com_celular";
    private string? _com_celular;
    
    private static readonly string RO_DEDUZIRSUFRAMACALCCREDICM = "Deduzirsuframacalccredicm";
    private string? _deduzirsuframacalccredicm;
    
    private static readonly string RO_DEDUZIRSUFRAMACALCCREDPIS = "Deduzirsuframacalccredpis";
    private string? _deduzirsuframacalccredpis;
    
    private static readonly string RO_UTILIZAOUTRASDESPCALCICMS = "Utilizaoutrasdespcalcicms";
    private string? _utilizaoutrasdespcalcicms;
    
    private static readonly string RO_CALCSUFRAMASOBREPLIQUIDO = "Calcsuframasobrepliquido";
    private string? _calcsuframasobrepliquido;
    
    private static readonly string RO_DEDUZIRSUFRAMABCSTALIQ1 = "Deduzirsuframabcstaliq1";
    private string? _deduzirsuframabcstaliq1;
    
    private static readonly string RO_CALCIPICOMDESC = "Calcipicomdesc";
    private string? _calcipicomdesc;
    
    private static readonly string RO_CALCIPICOMFRETENF = "Calcipicomfretenf";
    private string? _calcipicomfretenf;
    
    private static readonly string RO_SOMAFRETEFOBNOSTFORANF = "Somafretefobnostforanf";
    private string? _somafretefobnostforanf;
    
    private static readonly string RO_LOCALIZACAO = "Localizacao";
    private string? _localizacao;
    
    private static readonly string RO_CALCULAPISCOFINSCOMIPI = "Calculapiscofinscomipi";
    private string? _calculapiscofinscomipi;
    
    private static readonly string RO_ACEITAENTREGAANCECIP = "Aceitaentregaancecip";
    private string? _aceitaentregaancecip;
    
    private static readonly string RO_CODCIDADE = "Codcidade";
    private int? _codcidade;
    
    private static readonly string RO_UTILIZAFRETECALCICMS = "Utilizafretecalcicms";
    private string? _utilizafretecalcicms;
    
    private static readonly string RO_TIPOFRETECIFFOB = "Tipofreteciffob";
    private string? _tipofreteciffob;
    
    private static readonly string RO_DESTACASELONF = "Destacaselonf";
    private string? _destacaselonf;
    
    private static readonly string RO_UTILIZAPERCBON = "Utilizapercbon";
    private string? _utilizapercbon;
    
    private static readonly string RO_PERCBONDIN = "Percbondin";
    private decimal? _percbondin;
    
    private static readonly string RO_PERCBONMERC = "Percbonmerc";
    private decimal? _percbonmerc;
    
    private static readonly string RO_PERCCOMISSAO = "Perccomissao";
    private decimal? _perccomissao;
    
    private static readonly string RO_UTILIZAOUTRASDESPCALCIPI = "Utilizaoutrasdespcalcipi";
    private string? _utilizaoutrasdespcalcipi;
    
    private static readonly string RO_VLLIMITEFRETEMIN = "Vllimitefretemin";
    private decimal? _vllimitefretemin;
    
    private static readonly string RO_PERCFLUVIAL = "Percfluvial";
    private decimal? _percfluvial;
    
    private static readonly string RO_CODCONTALANCFRETE = "Codcontalancfrete";
    private int? _codcontalancfrete;
    
    private static readonly string RO_PERCBONOUTRAS = "Percbonoutras";
    private decimal? _percbonoutras;
    
    private static readonly string RO_UTILIZADESCCALCST = "Utilizadesccalcst";
    private string? _utilizadesccalcst;
    
    private static readonly string RO_UTILIZADESCCALCICMS = "Utilizadesccalcicms";
    private string? _utilizadesccalcicms;
    
    private static readonly string RO_CONSIPICALCBASEST = "Consipicalcbasest";
    private string? _consipicalcbasest;
    
    private static readonly string RO_CONSIPICALCBASECREPRES = "Consipicalcbasecrepres";
    private string? _consipicalcbasecrepres;
    
    private static readonly string RO_CLASSE = "Classe";
    private string? _classe;
    
    private static readonly string RO_EREABASTECIMENTO = "Ereabastecimento";
    private string? _ereabastecimento;
    
    private static readonly string RO_EREDESPACHO = "Eredespacho";
    private string? _eredespacho;
    
    private static readonly string RO_CODPARCELA = "Codparcela";
    private int? _codparcela;
    
    private static readonly string RO_REP_OBS = "Rep_obs";
    private string? _rep_obs;
    
    private static readonly string RO_CALCIPICOMFRETEFOB = "Calcipicomfretefob";
    private string? _calcipicomfretefob;
    
    private static readonly string RO_DTIMPORTINTEGRACAO = "Dtimportintegracao";
    private DateTime? _dtimportintegracao;
    
    private static readonly string RO_DTULTALTER = "Dtultalter";
    private DateTime? _dtultalter;
    
    private static readonly string RO_USAPERCALTERCUSTOENT = "Usapercaltercustoent";
    private string? _usapercaltercustoent;
    
    private static readonly string RO_TIPOPESSOA = "Tipopessoa";
    private string? _tipopessoa;
    
    private static readonly string RO_PERCIRRF = "Percirrf";
    private decimal? _percirrf;
    
    private static readonly string RO_CODCONTAIRRF = "Codcontairrf";
    private int? _codcontairrf;
    
    private static readonly string RO_PERCISS = "Perciss";
    private decimal? _perciss;
    
    private static readonly string RO_CODCONTAISS = "Codcontaiss";
    private int? _codcontaiss;
    
    private static readonly string RO_CODCONTACSRF = "Codcontacsrf";
    private int? _codcontacsrf;
    
    private static readonly string RO_CODCONTAINSS = "Codcontainss";
    private int? _codcontainss;
    
    private static readonly string RO_EXIGEREDESPACHO = "Exigeredespacho";
    private string? _exigeredespacho;
    
    private static readonly string RO_PERFRETEVALOR = "Perfretevalor";
    private decimal? _perfretevalor;
    
    private static readonly string RO_CONSOLIDARDIFPRECOVERBA = "Consolidardifprecoverba";
    private string? _consolidardifprecoverba;
    
    private static readonly string RO_PERCIMPPRODUTORURAL = "Percimpprodutorural";
    private decimal? _percimpprodutorural;
    
    private static readonly string RO_INSCMUNICIP = "Inscmunicip";
    private string? _inscmunicip;
    
    private static readonly string RO_USAPERCICMSNAALIQEXTST = "Usapercicmsnaaliqextst";
    private string? _usapercicmsnaaliqextst;
    
    private static readonly string RO_CONSFRETEFOBCALCICMSANTECIP = "Consfretefobcalcicmsantecip";
    private string? _consfretefobcalcicmsantecip;
    
    private static readonly string RO_IEST = "Iest";
    private string? _iest;
    
    private static readonly string RO_CODFORNECSTGUIA = "Codfornecstguia";
    private int? _codfornecstguia;
    
    private static readonly string RO_USANUMNEGOCIACAO = "Usanumnegociacao";
    private string? _usanumnegociacao;
    
    private static readonly string RO_ISENTOST = "Isentost";
    private string? _isentost;
    
    private static readonly string RO_CODUSUARIOWINTHOR = "Codusuariowinthor";
    private int? _codusuariowinthor;
    
    private static readonly string RO_DTULTALTERSRVPRC = "Dtultaltersrvprc";
    private DateTime? _dtultaltersrvprc;
    
    private static readonly string RO_CALCSTGUIAALIQEXT = "Calcstguiaaliqext";
    private string? _calcstguiaaliqext;
    
    private static readonly string RO_CODFORNECFRETE = "Codfornecfrete";
    private int? _codfornecfrete;
    
    private static readonly string RO_CALCULARIPIPESOLIQ = "Calcularipipesoliq";
    private string? _calcularipipesoliq;
    
    private static readonly string RO_SIMPLESNACIONAL = "Simplesnacional";
    private string? _simplesnacional;
    
    private static readonly string RO_COMPLEMENTOEND = "Complementoend";
    private string? _complementoend;
    
    private static readonly string RO_NUMEROEND = "Numeroend";
    private string? _numeroend;
    
    private static readonly string RO_CODPARCELASTGUIA = "Codparcelastguia";
    private int? _codparcelastguia;
    
    private static readonly string RO_CAE = "Cae";
    private string? _cae;
    
    private static readonly string RO_GERACREDDIFPRECO = "Geracreddifpreco";
    private string? _geracreddifpreco;
    
    private static readonly string RO_UTILIZAOUTDESPCALCSUFRAMA = "Utilizaoutdespcalcsuframa";
    private string? _utilizaoutdespcalcsuframa;
    
    private static readonly string RO_CONSSTNFPISCOFINS = "Consstnfpiscofins";
    private string? _consstnfpiscofins;
    
    private static readonly string RO_CODPAIS = "Codpais";
    private int? _codpais;
    
    private static readonly string RO_CLASSIFICTIPOFORNEC = "Classifictipofornec";
    private string? _classifictipofornec;
    
    private static readonly string RO_TRANSPAUTONOMO = "Transpautonomo";
    private string? _transpautonomo;
    
    private static readonly string RO_REP_NEXTELID = "Rep_nextelid";
    private string? _rep_nextelid;
    
    private static readonly string RO_PERCPISNFSERVICO = "Percpisnfservico";
    private decimal? _percpisnfservico;
    
    private static readonly string RO_PERCCOFINSNFSERVICO = "Perccofinsnfservico";
    private decimal? _perccofinsnfservico;
    
    private static readonly string RO_CODCONTAPIS = "Codcontapis";
    private int? _codcontapis;
    
    private static readonly string RO_CODCONTACOFINS = "Codcontacofins";
    private int? _codcontacofins;
    
    private static readonly string RO_FORNECIMPORTACAO = "Fornecimportacao";
    private int? _fornecimportacao;
    
    private static readonly string RO_PESOMINTRANSP = "Pesomintransp";
    private decimal? _pesomintransp;
    
    private static readonly string RO_TAXAEMISSAOCT = "Taxaemissaoct";
    private decimal? _taxaemissaoct;
    
    private static readonly string RO_INSS = "Inss";
    private int? _inss;
    
    private static readonly string RO_CGCAUX = "Cgcaux";
    private string? _cgcaux;
    
    private static readonly string RO_CODCONTACONTABADIANTFOR = "Codcontacontabadiantfor";
    private int? _codcontacontabadiantfor;
    
    private static readonly string RO_CALCDESPFINPRAZOPGTO = "Calcdespfinprazopgto";
    private string? _calcdespfinprazopgto;
    
    private static readonly string RO_USAOUTRASDESPSEGUROPISCOFINS = "Usaoutrasdespseguropiscofins";
    private string? _usaoutrasdespseguropiscofins;
    
    private static readonly string RO_NUMALVARAANVISA = "Numalvaraanvisa";
    private string? _numalvaraanvisa;
    
    private static readonly string RO_DTVENCALVARAANVISA = "Dtvencalvaraanvisa";
    private DateTime? _dtvencalvaraanvisa;
    
    private static readonly string RO_NUMALVARAFUNC = "Numalvarafunc";
    private string? _numalvarafunc;
    
    private static readonly string RO_DTVENCALVARAFUNC = "Dtvencalvarafunc";
    private DateTime? _dtvencalvarafunc;
    
    private static readonly string RO_NUMALVARAPSICO = "Numalvarapsico";
    private string? _numalvarapsico;
    
    private static readonly string RO_DTVENCALVARAPSICO = "Dtvencalvarapsico";
    private DateTime? _dtvencalvarapsico;
    
    private static readonly string RO_CRF = "Crf";
    private string? _crf;
    
    private static readonly string RO_DTVENCCRF = "Dtvenccrf";
    private DateTime? _dtvenccrf;
    
    private static readonly string RO_PERPIS = "Perpis";
    private decimal? _perpis;
    
    private static readonly string RO_PERCOFINS = "Percofins";
    private decimal? _percofins;
    
    private static readonly string RO_CODSITTRIBPISCOFINSCONHEC = "Codsittribpiscofinsconhec";
    private int? _codsittribpiscofinsconhec;
    
    private static readonly string RO_USACREDPISCOFINSENTBONIFIC = "Usacredpiscofinsentbonific";
    private string? _usacredpiscofinsentbonific;
    
    private static readonly string RO_CONTRIBUINTEICMS = "Contribuinteicms";
    private string? _contribuinteicms;
    
    private static readonly string RO_RECALCTRIBENT = "Recalctribent";
    private string? _recalctribent;
    
    private static readonly string RO_CONSMAIORICMSVLPAUTA = "Consmaioricmsvlpauta";
    private string? _consmaioricmsvlpauta;
    
    private static readonly string RO_BLOQUEIOSEFAZFORNEC = "Bloqueiosefazfornec";
    private string? _bloqueiosefazfornec;
    
    private static readonly string RO_DTBLOQUEIOSEFAZFORNEC = "Dtbloqueiosefazfornec";
    private DateTime? _dtbloqueiosefazfornec;
    
    private static readonly string RO_PERCINSS = "Percinss";
    private decimal? _percinss;
    
    private static readonly string RO_PERCCSRF = "Perccsrf";
    private decimal? _perccsrf;
    
    private static readonly string RO_DEDFRETECIFCREDPRESICMS = "Dedfretecifcredpresicms";
    private string? _dedfretecifcredpresicms;
    
    private static readonly string RO_EMITENFE = "Emitenfe";
    private string? _emitenfe;
    
    private static readonly string RO_ATUALIZASTULTENT = "Atualizastultent";
    private string? _atualizastultent;
    
    private static readonly string RO_CODCONTAB = "Codcontab";
    private string? _codcontab;
    
    private static readonly string RO_NUMCASASDECREDUCAOICMS = "Numcasasdecreducaoicms";
    private int? _numcasasdecreducaoicms;
    
    private static readonly string RO_UTILIZAIPICALCICMS = "Utilizaipicalcicms";
    private string? _utilizaipicalcicms;
    
    private static readonly string RO_AVALIACAOVENDA = "Avaliacaovenda";
    private string? _avaliacaovenda;
    
    private static readonly string RO_DTPROXCOMPRA = "Dtproxcompra";
    private DateTime? _dtproxcompra;
    
    private static readonly string RO_DTULTCOMPRA = "Dtultcompra";
    private DateTime? _dtultcompra;
    
    private static readonly string RO_PERIODICIDADECOMPRA = "Periodicidadecompra";
    private int? _periodicidadecompra;
    
    private static readonly string RO_DIASAVALIACAOVENDA = "Diasavaliacaovenda";
    private int? _diasavaliacaovenda;
    
    private static readonly string RO_CODGLN = "Codgln";
    private int? _codgln;
    
    private static readonly string RO_CODSITTRIBPISCOFINSSERVICO = "Codsittribpiscofinsservico";
    private int? _codsittribpiscofinsservico;
    
    private static readonly string RO_CONSSTGUIAPISCOFINS = "Consstguiapiscofins";
    private string? _consstguiapiscofins;
    
    private static readonly string RO_CONCEDCREDPRES = "Concedcredpres";
    private string? _concedcredpres;
    
    private static readonly string RO_USAFRETEFOBPORFORNEC = "Usafretefobporfornec";
    private string? _usafretefobporfornec;
    
    private static readonly string RO_VLMINPEDREPOSICAO = "Vlminpedreposicao";
    private decimal? _vlminpedreposicao;
    
    private static readonly string RO_GERAPEDBONIFIC = "Gerapedbonific";
    private string? _gerapedbonific;
    
    private static readonly string RO_QTDIASVENCVERBAS = "Qtdiasvencverbas";
    private int? _qtdiasvencverbas;
    
    private static readonly string RO_TIPOFINANCDEVFORNEC = "Tipofinancdevfornec";
    private int? _tipofinancdevfornec;
    
    private static readonly string RO_CFOPENTADJUD = "Cfopentadjud";
    private int? _cfopentadjud;
    
    private static readonly string RO_SITTRIBENTADJUD = "Sittribentadjud";
    private string? _sittribentadjud;
    
    private static readonly string RO_CFOPRESTITUICAO = "Cfoprestituicao";
    private int? _cfoprestituicao;
    
    private static readonly string RO_SITTRIBRESTITUICAO = "Sittribrestituicao";
    private string? _sittribrestituicao;
    
    private static readonly string RO_UTILIZAOUTDESPNFBASEST = "Utilizaoutdespnfbasest";
    private string? _utilizaoutdespnfbasest;
    
    private static readonly string RO_IDINTEGRACAOMYFROTA = "Idintegracaomyfrota";
    private byte[]? _idintegracaomyfrota;
    
    private static readonly string RO_CONSFRETEFOBBASESTNF = "Consfretefobbasestnf";
    private string? _consfretefobbasestnf;
    
    private static readonly string RO_CODPARCELAFRETEFOB = "Codparcelafretefob";
    private int? _codparcelafretefob;
    
    private static readonly string RO_CODPARCELAOUTDESP = "Codparcelaoutdesp";
    private int? _codparcelaoutdesp;
    
    private static readonly string RO_CODPARCICMSANTECIP = "Codparcicmsantecip";
    private int? _codparcicmsantecip;
    
    private static readonly string RO_CODPARCELADIFALIQ = "Codparceladifaliq";
    private int? _codparceladifaliq;
    
    private static readonly string RO_CODCONTAINSSTOMADOR = "Codcontainsstomador";
    private int? _codcontainsstomador;
    
    private static readonly string RO_PERCINSSTOMADOR = "Percinsstomador";
    private decimal? _percinsstomador;
    
    private static readonly string RO_RESSARCIMENTOSTNF = "Ressarcimentostnf";
    private string? _ressarcimentostnf;
    
    private static readonly string RO_RESSARCIMENTOSTGUIA = "Ressarcimentostguia";
    private string? _ressarcimentostguia;
    
    private static readonly string RO_ADJUDICACAO = "Adjudicacao";
    private string? _adjudicacao;
    
    private static readonly string RO_CFOPRESSARCIMENTOSTGUIA = "Cfopressarcimentostguia";
    private int? _cfopressarcimentostguia;
    
    private static readonly string RO_SITTRIBUTRESSARCIMENTOSTGUIA = "Sittributressarcimentostguia";
    private string? _sittributressarcimentostguia;
    
    private static readonly string RO_USADRAWBACK = "Usadrawback";
    private string? _usadrawback;
    
    private static readonly string RO_UTILIZAICMSDIFZERADO = "Utilizaicmsdifzerado";
    private string? _utilizaicmsdifzerado;
    
    private static readonly string RO_CALCPISCOFINSBASERED = "Calcpiscofinsbasered";
    private string? _calcpiscofinsbasered;
    
    private static readonly string RO_PERCSESTSENAT = "Percsestsenat";
    private decimal? _percsestsenat;
    
    private static readonly string RO_CODCONTASESTSENAT = "Codcontasestsenat";
    private int? _codcontasestsenat;
    
    private static readonly string RO_EQUIPINDUSTRIA = "Equipindustria";
    private string? _equipindustria;
    
    private static readonly string RO_CODPARCELAFUNRURAL = "Codparcelafunrural";
    private int? _codparcelafunrural;
    
    private static readonly string RO_CONSCAPATAZIAICMS = "Conscapataziaicms";
    private string? _conscapataziaicms;
    
    private static readonly string RO_CONSUMIDORFINAL = "Consumidorfinal";
    private string? _consumidorfinal;
    
    private static readonly string RO_DEDUZIRSUFRAMAALIQEXT = "Deduzirsuframaaliqext";
    private string? _deduzirsuframaaliqext;
    
    private static readonly string RO_CONSIPICALCICMSANT = "Consipicalcicmsant";
    private string? _consipicalcicmsant;
    
    private static readonly string RO_EMAILNFE = "Emailnfe";
    private string? _emailnfe;
    
    private static readonly string RO_CREDITARSALDOESTVERBA = "Creditarsaldoestverba";
    private string? _creditarsaldoestverba;
    
    private static readonly string RO_TRANSPCREDENCIADOSEFAZ = "Transpcredenciadosefaz";
    private string? _transpcredenciadosefaz;
    
    private static readonly string RO_NUMCREDENCIAMENTOSEFAZ = "Numcredenciamentosefaz";
    private string? _numcredenciamentosefaz;
    
    private static readonly string RO_USAECOMMERCEUNILEVER = "Usaecommerceunilever";
    private string? _usaecommerceunilever;
    
    private static readonly string RO_HORACOLETA = "Horacoleta";
    private int? _horacoleta;
    
    private static readonly string RO_USADEBCREDOPERLOG = "Usadebcredoperlog";
    private string? _usadebcredoperlog;
    
    private static readonly string RO_DIAPGVERBAOPERLOG = "Diapgverbaoperlog";
    private int? _diapgverbaoperlog;
    
    private static readonly string RO_CREDITADESCMENOROPERLOG = "Creditadescmenoroperlog";
    private string? _creditadescmenoroperlog;
    
    private static readonly string RO_CODCOBSEFAZ = "Codcobsefaz";
    private string? _codcobsefaz;
    
    private static readonly string RO_CONTRIBUINTEDOCPRB = "Contribuintedocprb";
    private string? _contribuintedocprb;
    
    private static readonly string RO_URLBASERASTREIO = "Urlbaserastreio";
    private string? _urlbaserastreio;
    
    private static readonly string RO_DEDUZIRSUFRAMADIFALIQ = "Deduzirsuframadifaliq";
    private string? _deduzirsuframadifaliq;
    
    private static readonly string RO_CODLICITGRUPOFORNEC = "Codlicitgrupofornec";
    private int? _codlicitgrupofornec;
    
    private static readonly string RO_FORMAPGTO = "Formapgto";
    private int? _formapgto;
    
    private static readonly string RO_ASSOCIACAODESPORTIVA = "Associacaodesportiva";
    private string? _associacaodesportiva;
    
    private static readonly string RO_CODIGONACIONALOBRAS = "Codigonacionalobras";
    private string? _codigonacionalobras;
    
    private static readonly string RO_CONSIDERARPAUTAZEROSTGUIA = "Considerarpautazerostguia";
    private string? _considerarpautazerostguia;
    
    private static readonly string RO_CALCCREDICMSBASEREDUZIDA = "Calccredicmsbasereduzida";
    private string? _calccredicmsbasereduzida;
    
    private static readonly string RO_CODCENTROCUSTO = "Codcentrocusto";
    private string? _codcentrocusto;
    
    private static readonly string RO_PERCMARGEMGARANTIDA = "Percmargemgarantida";
    private decimal? _percmargemgarantida;
    
    private static readonly string RO_DETENTORREGESPECIAL = "Detentorregespecial";
    private string? _detentorregespecial;
    
    private static readonly string RO_DEDUZIRFCPICMSDOFCPST = "Deduzirfcpicmsdofcpst";
    private string? _deduzirfcpicmsdofcpst;
    
    private static readonly string RO_IDSOFITVIEW = "Idsofitview";
    private string? _idsofitview;
    
    private static readonly string RO_DTULTALTERSOFITVIEW = "Dtultaltersofitview";
    private DateTime? _dtultaltersofitview;
    
    private static readonly string RO_DTEXCLUSAOSOFITVIEW = "Dtexclusaosofitview";
    private DateTime? _dtexclusaosofitview;
    
    private static readonly string RO_GERARRECEITARESTITUICAO = "Gerarreceitarestituicao";
    private string? _gerarreceitarestituicao;
    
    private static readonly string RO_CONDCOMERCAUTORIZMED = "Condcomercautorizmed";
    private string? _condcomercautorizmed;
    
    private static readonly string RO_MANIFESTACAOAUTOMATICA = "Manifestacaoautomatica";
    private string? _manifestacaoautomatica;
    
    private static readonly string RO_GERAPEDIDOCOMPRAXML = "Gerapedidocompraxml";
    private string? _gerapedidocompraxml;
    
    private static readonly string RO_USAREDICMSPARA = "Usaredicmspara";
    private string? _usaredicmspara;
    
    private static readonly string RO_CONSDESONNOVESUFRAMA = "Consdesonnovesuframa";
    private string? _consdesonnovesuframa;
    
    private static readonly string RO_GRAVARCODFAB253 = "Gravarcodfab253";
    private string? _gravarcodfab253;
    
    private static readonly string RO_UTILIZAFATOR253 = "Utilizafator253";
    private string? _utilizafator253;
    
    private static readonly string RO_IMPORTAXMLAUTOMATICO = "Importaxmlautomatico";
    private string? _importaxmlautomatico;
    
    private static readonly string RO_DEDUZIRIPIBASEDIFALIQ = "Deduziripibasedifaliq";
    private string? _deduziripibasedifaliq;
    
    private static readonly string RO_CONSFRETEFOBBASEDIFALIQ = "Consfretefobbasedifaliq";
    private string? _consfretefobbasedifaliq;
    
    private static readonly string RO_ALIMENTAFUNDOMULTIFILIAL = "Alimentafundomultifilial";
    private string? _alimentafundomultifilial;
    
    private static readonly string RO_ORIGEMPARCFINANC = "Origemparcfinanc";
    private string? _origemparcfinanc;
    
    private static readonly string RO_APLICAVERBAREBCUSTO = "Aplicaverbarebcusto";
    private string? _aplicaverbarebcusto;
    
    private static readonly string RO_TIPOFRETEDESPACHO = "Tipofretedespacho";
    private string? _tipofretedespacho;
    
    private static readonly string RO_TIPOVENCIMENTO = "Tipovencimento";
    private string? _tipovencimento;
    
    private static readonly string RO_APLICREBCUSTOMULTIFILIAL = "Aplicrebcustomultifilial";
    private string? _aplicrebcustomultifilial;
    
    private static readonly string RO_FORMATRIBPRODRURAL = "Formatribprodrural";
    private string? _formatribprodrural;
    
    private static readonly string RO_INDAQPRODRURAL = "Indaqprodrural";
    private string? _indaqprodrural;
    
    private static readonly string RO_PRODUTORRURAL = "Produtorrural";
    private string? _produtorrural;
    
    private static readonly string RO_CPFPRODUTORRURAL = "Cpfprodutorrural";
    private string? _cpfprodutorrural;
    
    private static readonly string RO_PERCCONTRIBPREVDESC = "Perccontribprevdesc";
    private decimal? _perccontribprevdesc;
    
    private static readonly string RO_PERCCONTRIBBEMCONC = "Perccontribbemconc";
    private decimal? _perccontribbemconc;
    
    private static readonly string RO_PERCCONTRIBSENAR = "Perccontribsenar";
    private decimal? _perccontribsenar;
    
    private static readonly string RO_CODFORNECBAL = "Codfornecbal";
    private string? _codfornecbal;
    
    private static readonly string RO_UTILIZAPISCOFINSTRIBENT = "Utilizapiscofinstribent";
    private string? _utilizapiscofinstribent;
    
    private static readonly string RO_UTILIZAICMSTRIBENT = "Utilizaicmstribent";
    private string? _utilizaicmstribent;
    

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 6, Precisao = 0)]
    public int Codfornec
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
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
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
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Repres
    {
        get
        {
            PropriedadeAcessada(RO_REPRES);
            return _repres;
        }
        set
        {
            PropriedadeModificada(RO_REPRES, value);
            _repres = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Contato
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
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Ender
    {
        get
        {
            PropriedadeAcessada(RO_ENDER);
            return _ender;
        }
        set
        {
            PropriedadeModificada(RO_ENDER, value);
            _ender = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Cidade
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
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Estado
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
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Cep
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
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Telrep
    {
        get
        {
            PropriedadeAcessada(RO_TELREP);
            return _telrep;
        }
        set
        {
            PropriedadeModificada(RO_TELREP, value);
            _telrep = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Telfab
    {
        get
        {
            PropriedadeAcessada(RO_TELFAB);
            return _telfab;
        }
        set
        {
            PropriedadeModificada(RO_TELFAB, value);
            _telfab = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Telexrep
    {
        get
        {
            PropriedadeAcessada(RO_TELEXREP);
            return _telexrep;
        }
        set
        {
            PropriedadeModificada(RO_TELEXREP, value);
            _telexrep = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Telexfab
    {
        get
        {
            PropriedadeAcessada(RO_TELEXFAB);
            return _telexfab;
        }
        set
        {
            PropriedadeModificada(RO_TELEXFAB, value);
            _telexfab = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Ie
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
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Cgc
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
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Faxrep
    {
        get
        {
            PropriedadeAcessada(RO_FAXREP);
            return _faxrep;
        }
        set
        {
            PropriedadeModificada(RO_FAXREP, value);
            _faxrep = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Faxfab
    {
        get
        {
            PropriedadeAcessada(RO_FAXFAB);
            return _faxfab;
        }
        set
        {
            PropriedadeModificada(RO_FAXFAB, value);
            _faxfab = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Bairro
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
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 4, Precisao = 0)]
    public int? Prazoentrega
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
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Bloqueio
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
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 0, Precisao = 0)]
    public DateTime? Dtbloqueio
    {
        get
        {
            PropriedadeAcessada(RO_DTBLOQUEIO);
            return _dtbloqueio;
        }
        set
        {
            PropriedadeModificada(RO_DTBLOQUEIO, value);
            _dtbloqueio = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Obs
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
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Revenda
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
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 6, Precisao = 0)]
    public int? Codcli
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
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 8, Precisao = 0)]
    public int? Codcomprador
    {
        get
        {
            PropriedadeAcessada(RO_CODCOMPRADOR);
            return _codcomprador;
        }
        set
        {
            PropriedadeModificada(RO_CODCOMPRADOR, value);
            _codcomprador = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Rep_contato
    {
        get
        {
            PropriedadeAcessada(RO_REP_CONTATO);
            return _rep_contato;
        }
        set
        {
            PropriedadeModificada(RO_REP_CONTATO, value);
            _rep_contato = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Rep_endereco
    {
        get
        {
            PropriedadeAcessada(RO_REP_ENDERECO);
            return _rep_endereco;
        }
        set
        {
            PropriedadeModificada(RO_REP_ENDERECO, value);
            _rep_endereco = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Rep_bairro
    {
        get
        {
            PropriedadeAcessada(RO_REP_BAIRRO);
            return _rep_bairro;
        }
        set
        {
            PropriedadeModificada(RO_REP_BAIRRO, value);
            _rep_bairro = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Rep_cidade
    {
        get
        {
            PropriedadeAcessada(RO_REP_CIDADE);
            return _rep_cidade;
        }
        set
        {
            PropriedadeModificada(RO_REP_CIDADE, value);
            _rep_cidade = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Rep_uf
    {
        get
        {
            PropriedadeAcessada(RO_REP_UF);
            return _rep_uf;
        }
        set
        {
            PropriedadeModificada(RO_REP_UF, value);
            _rep_uf = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 8, Precisao = 0)]
    public int? Rep_cep
    {
        get
        {
            PropriedadeAcessada(RO_REP_CEP);
            return _rep_cep;
        }
        set
        {
            PropriedadeModificada(RO_REP_CEP, value);
            _rep_cep = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Excluido
    {
        get
        {
            PropriedadeAcessada(RO_EXCLUIDO);
            return _excluido;
        }
        set
        {
            PropriedadeModificada(RO_EXCLUIDO, value);
            _excluido = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 4, Precisao = 0)]
    public int? Ledtime
    {
        get
        {
            PropriedadeAcessada(RO_LEDTIME);
            return _ledtime;
        }
        set
        {
            PropriedadeModificada(RO_LEDTIME, value);
            _ledtime = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 4, Precisao = 0)]
    public int? Cobertura
    {
        get
        {
            PropriedadeAcessada(RO_COBERTURA);
            return _cobertura;
        }
        set
        {
            PropriedadeModificada(RO_COBERTURA, value);
            _cobertura = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Regional
    {
        get
        {
            PropriedadeAcessada(RO_REGIONAL);
            return _regional;
        }
        set
        {
            PropriedadeModificada(RO_REGIONAL, value);
            _regional = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Centralizacao
    {
        get
        {
            PropriedadeAcessada(RO_CENTRALIZACAO);
            return _centralizacao;
        }
        set
        {
            PropriedadeModificada(RO_CENTRALIZACAO, value);
            _centralizacao = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 0, Precisao = 0)]
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
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 0, Precisao = 0)]
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
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Obs2
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
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 4, Precisao = 0)]
    public int? Prazomin
    {
        get
        {
            PropriedadeAcessada(RO_PRAZOMIN);
            return _prazomin;
        }
        set
        {
            PropriedadeModificada(RO_PRAZOMIN, value);
            _prazomin = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Descpagtodup
    {
        get
        {
            PropriedadeAcessada(RO_DESCPAGTODUP);
            return _descpagtodup;
        }
        set
        {
            PropriedadeModificada(RO_DESCPAGTODUP, value);
            _descpagtodup = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Endercob
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
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Bairrocob
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
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Municob
    {
        get
        {
            PropriedadeAcessada(RO_MUNICOB);
            return _municob;
        }
        set
        {
            PropriedadeModificada(RO_MUNICOB, value);
            _municob = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Estcob
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
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Cepcob
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
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Telcob
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
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Estrategico
    {
        get
        {
            PropriedadeAcessada(RO_ESTRATEGICO);
            return _estrategico;
        }
        set
        {
            PropriedadeModificada(RO_ESTRATEGICO, value);
            _estrategico = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Observacao
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
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 6, Precisao = 0)]
    public int? Coddepto
    {
        get
        {
            PropriedadeAcessada(RO_CODDEPTO);
            return _coddepto;
        }
        set
        {
            PropriedadeModificada(RO_CODDEPTO, value);
            _coddepto = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 6, Precisao = 0)]
    public int? Codfornecprinc
    {
        get
        {
            PropriedadeAcessada(RO_CODFORNECPRINC);
            return _codfornecprinc;
        }
        set
        {
            PropriedadeModificada(RO_CODFORNECPRINC, value);
            _codfornecprinc = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Contatocom
    {
        get
        {
            PropriedadeAcessada(RO_CONTATOCOM);
            return _contatocom;
        }
        set
        {
            PropriedadeModificada(RO_CONTATOCOM, value);
            _contatocom = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Telefonecom
    {
        get
        {
            PropriedadeAcessada(RO_TELEFONECOM);
            return _telefonecom;
        }
        set
        {
            PropriedadeModificada(RO_TELEFONECOM, value);
            _telefonecom = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Contatoadm
    {
        get
        {
            PropriedadeAcessada(RO_CONTATOADM);
            return _contatoadm;
        }
        set
        {
            PropriedadeModificada(RO_CONTATOADM, value);
            _contatoadm = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Telefoneadm
    {
        get
        {
            PropriedadeAcessada(RO_TELEFONEADM);
            return _telefoneadm;
        }
        set
        {
            PropriedadeModificada(RO_TELEFONEADM, value);
            _telefoneadm = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 2, Precisao = 0)]
    public int? Diasemanaatend
    {
        get
        {
            PropriedadeAcessada(RO_DIASEMANAATEND);
            return _diasemanaatend;
        }
        set
        {
            PropriedadeModificada(RO_DIASEMANAATEND, value);
            _diasemanaatend = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 4, Precisao = 0)]
    public int? Periocidadeatend
    {
        get
        {
            PropriedadeAcessada(RO_PERIOCIDADEATEND);
            return _periocidadeatend;
        }
        set
        {
            PropriedadeModificada(RO_PERIOCIDADEATEND, value);
            _periocidadeatend = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 0, Precisao = 0)]
    public DateTime? Dtproxatend
    {
        get
        {
            PropriedadeAcessada(RO_DTPROXATEND);
            return _dtproxatend;
        }
        set
        {
            PropriedadeModificada(RO_DTPROXATEND, value);
            _dtproxatend = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Classevenda
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
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Classemc
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
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Classeestoque
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
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Classecompra
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
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Email
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
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 4, Precisao = 0)]
    public int? Prazo1
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
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 4, Precisao = 0)]
    public int? Prazo2
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
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 4, Precisao = 0)]
    public int? Prazo3
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
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 4, Precisao = 0)]
    public int? Prazo4
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
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 4, Precisao = 0)]
    public int? Prazo5
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
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 4, Precisao = 0)]
    public int? Prazo6
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
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
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
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
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
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 4, Precisao = 0)]
    public int? Numbancodoc
    {
        get
        {
            PropriedadeAcessada(RO_NUMBANCODOC);
            return _numbancodoc;
        }
        set
        {
            PropriedadeModificada(RO_NUMBANCODOC, value);
            _numbancodoc = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 6, Precisao = 0)]
    public int? Numagenciadoc
    {
        get
        {
            PropriedadeAcessada(RO_NUMAGENCIADOC);
            return _numagenciadoc;
        }
        set
        {
            PropriedadeModificada(RO_NUMAGENCIADOC, value);
            _numagenciadoc = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Numccorrentedoc
    {
        get
        {
            PropriedadeAcessada(RO_NUMCCORRENTEDOC);
            return _numccorrentedoc;
        }
        set
        {
            PropriedadeModificada(RO_NUMCCORRENTEDOC, value);
            _numccorrentedoc = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Fantasia
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
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 4, Precisao = 0)]
    public int? Numdepirrf
    {
        get
        {
            PropriedadeAcessada(RO_NUMDEPIRRF);
            return _numdepirrf;
        }
        set
        {
            PropriedadeModificada(RO_NUMDEPIRRF, value);
            _numdepirrf = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 2)]
    public decimal? Valordeducaoirrf
    {
        get
        {
            PropriedadeAcessada(RO_VALORDEDUCAOIRRF);
            return _valordeducaoirrf;
        }
        set
        {
            PropriedadeModificada(RO_VALORDEDUCAOIRRF, value);
            _valordeducaoirrf = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Rg
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
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Coddistrib
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
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Vlfretekg
    {
        get
        {
            PropriedadeAcessada(RO_VLFRETEKG);
            return _vlfretekg;
        }
        set
        {
            PropriedadeModificada(RO_VLFRETEKG, value);
            _vlfretekg = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 2)]
    public decimal? Percoutroscustosfrete
    {
        get
        {
            PropriedadeAcessada(RO_PERCOUTROSCUSTOSFRETE);
            return _percoutroscustosfrete;
        }
        set
        {
            PropriedadeModificada(RO_PERCOUTROSCUSTOSFRETE, value);
            _percoutroscustosfrete = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Distrib
    {
        get
        {
            PropriedadeAcessada(RO_DISTRIB);
            return _distrib;
        }
        set
        {
            PropriedadeModificada(RO_DISTRIB, value);
            _distrib = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 15, Precisao = 0)]
    public int? Inscestrangeira
    {
        get
        {
            PropriedadeAcessada(RO_INSCESTRANGEIRA);
            return _inscestrangeira;
        }
        set
        {
            PropriedadeModificada(RO_INSCESTRANGEIRA, value);
            _inscestrangeira = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Industrialocal
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
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 6, Precisao = 0)]
    public int? Grupocampanha
    {
        get
        {
            PropriedadeAcessada(RO_GRUPOCAMPANHA);
            return _grupocampanha;
        }
        set
        {
            PropriedadeModificada(RO_GRUPOCAMPANHA, value);
            _grupocampanha = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 2)]
    public decimal? Percmaxbonific
    {
        get
        {
            PropriedadeAcessada(RO_PERCMAXBONIFIC);
            return _percmaxbonific;
        }
        set
        {
            PropriedadeModificada(RO_PERCMAXBONIFIC, value);
            _percmaxbonific = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 2)]
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
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Suframa
    {
        get
        {
            PropriedadeAcessada(RO_SUFRAMA);
            return _suframa;
        }
        set
        {
            PropriedadeModificada(RO_SUFRAMA, value);
            _suframa = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Codprodutorrural
    {
        get
        {
            PropriedadeAcessada(RO_CODPRODUTORRURAL);
            return _codprodutorrural;
        }
        set
        {
            PropriedadeModificada(RO_CODPRODUTORRURAL, value);
            _codprodutorrural = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Dvag
    {
        get
        {
            PropriedadeAcessada(RO_DVAG);
            return _dvag;
        }
        set
        {
            PropriedadeModificada(RO_DVAG, value);
            _dvag = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Dvcc
    {
        get
        {
            PropriedadeAcessada(RO_DVCC);
            return _dvcc;
        }
        set
        {
            PropriedadeModificada(RO_DVCC, value);
            _dvcc = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Tipoembalagempedido
    {
        get
        {
            PropriedadeAcessada(RO_TIPOEMBALAGEMPEDIDO);
            return _tipoembalagempedido;
        }
        set
        {
            PropriedadeModificada(RO_TIPOEMBALAGEMPEDIDO, value);
            _tipoembalagempedido = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Supervisorverba
    {
        get
        {
            PropriedadeAcessada(RO_SUPERVISORVERBA);
            return _supervisorverba;
        }
        set
        {
            PropriedadeModificada(RO_SUPERVISORVERBA, value);
            _supervisorverba = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Contatoverba
    {
        get
        {
            PropriedadeAcessada(RO_CONTATOVERBA);
            return _contatoverba;
        }
        set
        {
            PropriedadeModificada(RO_CONTATOVERBA, value);
            _contatoverba = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Cpfcontatoverba
    {
        get
        {
            PropriedadeAcessada(RO_CPFCONTATOVERBA);
            return _cpfcontatoverba;
        }
        set
        {
            PropriedadeModificada(RO_CPFCONTATOVERBA, value);
            _cpfcontatoverba = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Rgcontatoverba
    {
        get
        {
            PropriedadeAcessada(RO_RGCONTATOVERBA);
            return _rgcontatoverba;
        }
        set
        {
            PropriedadeModificada(RO_RGCONTATOVERBA, value);
            _rgcontatoverba = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 0, Precisao = 0)]
    public DateTime? Rep_dtaniversario
    {
        get
        {
            PropriedadeAcessada(RO_REP_DTANIVERSARIO);
            return _rep_dtaniversario;
        }
        set
        {
            PropriedadeModificada(RO_REP_DTANIVERSARIO, value);
            _rep_dtaniversario = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Adm_contato
    {
        get
        {
            PropriedadeAcessada(RO_ADM_CONTATO);
            return _adm_contato;
        }
        set
        {
            PropriedadeModificada(RO_ADM_CONTATO, value);
            _adm_contato = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 0, Precisao = 0)]
    public DateTime? Adm_dtaniversario
    {
        get
        {
            PropriedadeAcessada(RO_ADM_DTANIVERSARIO);
            return _adm_dtaniversario;
        }
        set
        {
            PropriedadeModificada(RO_ADM_DTANIVERSARIO, value);
            _adm_dtaniversario = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Adm_endereco
    {
        get
        {
            PropriedadeAcessada(RO_ADM_ENDERECO);
            return _adm_endereco;
        }
        set
        {
            PropriedadeModificada(RO_ADM_ENDERECO, value);
            _adm_endereco = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Adm_bairro
    {
        get
        {
            PropriedadeAcessada(RO_ADM_BAIRRO);
            return _adm_bairro;
        }
        set
        {
            PropriedadeModificada(RO_ADM_BAIRRO, value);
            _adm_bairro = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Adm_cidade
    {
        get
        {
            PropriedadeAcessada(RO_ADM_CIDADE);
            return _adm_cidade;
        }
        set
        {
            PropriedadeModificada(RO_ADM_CIDADE, value);
            _adm_cidade = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Adm_uf
    {
        get
        {
            PropriedadeAcessada(RO_ADM_UF);
            return _adm_uf;
        }
        set
        {
            PropriedadeModificada(RO_ADM_UF, value);
            _adm_uf = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 8, Precisao = 0)]
    public int? Adm_cep
    {
        get
        {
            PropriedadeAcessada(RO_ADM_CEP);
            return _adm_cep;
        }
        set
        {
            PropriedadeModificada(RO_ADM_CEP, value);
            _adm_cep = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Com_contato
    {
        get
        {
            PropriedadeAcessada(RO_COM_CONTATO);
            return _com_contato;
        }
        set
        {
            PropriedadeModificada(RO_COM_CONTATO, value);
            _com_contato = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 0, Precisao = 0)]
    public DateTime? Com_dtaniversario
    {
        get
        {
            PropriedadeAcessada(RO_COM_DTANIVERSARIO);
            return _com_dtaniversario;
        }
        set
        {
            PropriedadeModificada(RO_COM_DTANIVERSARIO, value);
            _com_dtaniversario = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Com_endereco
    {
        get
        {
            PropriedadeAcessada(RO_COM_ENDERECO);
            return _com_endereco;
        }
        set
        {
            PropriedadeModificada(RO_COM_ENDERECO, value);
            _com_endereco = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Com_bairro
    {
        get
        {
            PropriedadeAcessada(RO_COM_BAIRRO);
            return _com_bairro;
        }
        set
        {
            PropriedadeModificada(RO_COM_BAIRRO, value);
            _com_bairro = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Com_cidade
    {
        get
        {
            PropriedadeAcessada(RO_COM_CIDADE);
            return _com_cidade;
        }
        set
        {
            PropriedadeModificada(RO_COM_CIDADE, value);
            _com_cidade = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Com_uf
    {
        get
        {
            PropriedadeAcessada(RO_COM_UF);
            return _com_uf;
        }
        set
        {
            PropriedadeModificada(RO_COM_UF, value);
            _com_uf = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 8, Precisao = 0)]
    public int? Com_cep
    {
        get
        {
            PropriedadeAcessada(RO_COM_CEP);
            return _com_cep;
        }
        set
        {
            PropriedadeModificada(RO_COM_CEP, value);
            _com_cep = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Transporteproprio
    {
        get
        {
            PropriedadeAcessada(RO_TRANSPORTEPROPRIO);
            return _transporteproprio;
        }
        set
        {
            PropriedadeModificada(RO_TRANSPORTEPROPRIO, value);
            _transporteproprio = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 2)]
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
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Pergris
    {
        get
        {
            PropriedadeAcessada(RO_PERGRIS);
            return _pergris;
        }
        set
        {
            PropriedadeModificada(RO_PERGRIS, value);
            _pergris = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Icmssobretxminima
    {
        get
        {
            PropriedadeAcessada(RO_ICMSSOBRETXMINIMA);
            return _icmssobretxminima;
        }
        set
        {
            PropriedadeModificada(RO_ICMSSOBRETXMINIMA, value);
            _icmssobretxminima = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Gatilho
    {
        get
        {
            PropriedadeAcessada(RO_GATILHO);
            return _gatilho;
        }
        set
        {
            PropriedadeModificada(RO_GATILHO, value);
            _gatilho = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 2, Precisao = 0)]
    public int? Tipocalcfrete
    {
        get
        {
            PropriedadeAcessada(RO_TIPOCALCFRETE);
            return _tipocalcfrete;
        }
        set
        {
            PropriedadeModificada(RO_TIPOCALCFRETE, value);
            _tipocalcfrete = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
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
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
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
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
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
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
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
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
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
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
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
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
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
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 0, Precisao = 0)]
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
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 8, Precisao = 0)]
    public int? Codfuncultcontatocob
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
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 0, Precisao = 0)]
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
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 10, Precisao = 0)]
    public int? Codmunicipio
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
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Com_email
    {
        get
        {
            PropriedadeAcessada(RO_COM_EMAIL);
            return _com_email;
        }
        set
        {
            PropriedadeModificada(RO_COM_EMAIL, value);
            _com_email = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Rep_email
    {
        get
        {
            PropriedadeAcessada(RO_REP_EMAIL);
            return _rep_email;
        }
        set
        {
            PropriedadeModificada(RO_REP_EMAIL, value);
            _rep_email = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Sup_email
    {
        get
        {
            PropriedadeAcessada(RO_SUP_EMAIL);
            return _sup_email;
        }
        set
        {
            PropriedadeModificada(RO_SUP_EMAIL, value);
            _sup_email = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 0, Precisao = 0)]
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
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Tipofornec
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
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Utilizadesccalcipi
    {
        get
        {
            PropriedadeAcessada(RO_UTILIZADESCCALCIPI);
            return _utilizadesccalcipi;
        }
        set
        {
            PropriedadeModificada(RO_UTILIZADESCCALCIPI, value);
            _utilizadesccalcipi = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Utilizafretecalcipi
    {
        get
        {
            PropriedadeAcessada(RO_UTILIZAFRETECALCIPI);
            return _utilizafretecalcipi;
        }
        set
        {
            PropriedadeModificada(RO_UTILIZAFRETECALCIPI, value);
            _utilizafretecalcipi = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 2)]
    public decimal? Vlminpedcompra
    {
        get
        {
            PropriedadeAcessada(RO_VLMINPEDCOMPRA);
            return _vlminpedcompra;
        }
        set
        {
            PropriedadeModificada(RO_VLMINPEDCOMPRA, value);
            _vlminpedcompra = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Sup_celular
    {
        get
        {
            PropriedadeAcessada(RO_SUP_CELULAR);
            return _sup_celular;
        }
        set
        {
            PropriedadeModificada(RO_SUP_CELULAR, value);
            _sup_celular = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Com_celular
    {
        get
        {
            PropriedadeAcessada(RO_COM_CELULAR);
            return _com_celular;
        }
        set
        {
            PropriedadeModificada(RO_COM_CELULAR, value);
            _com_celular = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Deduzirsuframacalccredicm
    {
        get
        {
            PropriedadeAcessada(RO_DEDUZIRSUFRAMACALCCREDICM);
            return _deduzirsuframacalccredicm;
        }
        set
        {
            PropriedadeModificada(RO_DEDUZIRSUFRAMACALCCREDICM, value);
            _deduzirsuframacalccredicm = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Deduzirsuframacalccredpis
    {
        get
        {
            PropriedadeAcessada(RO_DEDUZIRSUFRAMACALCCREDPIS);
            return _deduzirsuframacalccredpis;
        }
        set
        {
            PropriedadeModificada(RO_DEDUZIRSUFRAMACALCCREDPIS, value);
            _deduzirsuframacalccredpis = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Utilizaoutrasdespcalcicms
    {
        get
        {
            PropriedadeAcessada(RO_UTILIZAOUTRASDESPCALCICMS);
            return _utilizaoutrasdespcalcicms;
        }
        set
        {
            PropriedadeModificada(RO_UTILIZAOUTRASDESPCALCICMS, value);
            _utilizaoutrasdespcalcicms = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Calcsuframasobrepliquido
    {
        get
        {
            PropriedadeAcessada(RO_CALCSUFRAMASOBREPLIQUIDO);
            return _calcsuframasobrepliquido;
        }
        set
        {
            PropriedadeModificada(RO_CALCSUFRAMASOBREPLIQUIDO, value);
            _calcsuframasobrepliquido = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Deduzirsuframabcstaliq1
    {
        get
        {
            PropriedadeAcessada(RO_DEDUZIRSUFRAMABCSTALIQ1);
            return _deduzirsuframabcstaliq1;
        }
        set
        {
            PropriedadeModificada(RO_DEDUZIRSUFRAMABCSTALIQ1, value);
            _deduzirsuframabcstaliq1 = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Calcipicomdesc
    {
        get
        {
            PropriedadeAcessada(RO_CALCIPICOMDESC);
            return _calcipicomdesc;
        }
        set
        {
            PropriedadeModificada(RO_CALCIPICOMDESC, value);
            _calcipicomdesc = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Calcipicomfretenf
    {
        get
        {
            PropriedadeAcessada(RO_CALCIPICOMFRETENF);
            return _calcipicomfretenf;
        }
        set
        {
            PropriedadeModificada(RO_CALCIPICOMFRETENF, value);
            _calcipicomfretenf = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Somafretefobnostforanf
    {
        get
        {
            PropriedadeAcessada(RO_SOMAFRETEFOBNOSTFORANF);
            return _somafretefobnostforanf;
        }
        set
        {
            PropriedadeModificada(RO_SOMAFRETEFOBNOSTFORANF, value);
            _somafretefobnostforanf = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Localizacao
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
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Calculapiscofinscomipi
    {
        get
        {
            PropriedadeAcessada(RO_CALCULAPISCOFINSCOMIPI);
            return _calculapiscofinscomipi;
        }
        set
        {
            PropriedadeModificada(RO_CALCULAPISCOFINSCOMIPI, value);
            _calculapiscofinscomipi = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Aceitaentregaancecip
    {
        get
        {
            PropriedadeAcessada(RO_ACEITAENTREGAANCECIP);
            return _aceitaentregaancecip;
        }
        set
        {
            PropriedadeModificada(RO_ACEITAENTREGAANCECIP, value);
            _aceitaentregaancecip = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 6, Precisao = 0)]
    public int? Codcidade
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
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Utilizafretecalcicms
    {
        get
        {
            PropriedadeAcessada(RO_UTILIZAFRETECALCICMS);
            return _utilizafretecalcicms;
        }
        set
        {
            PropriedadeModificada(RO_UTILIZAFRETECALCICMS, value);
            _utilizafretecalcicms = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Tipofreteciffob
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
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Destacaselonf
    {
        get
        {
            PropriedadeAcessada(RO_DESTACASELONF);
            return _destacaselonf;
        }
        set
        {
            PropriedadeModificada(RO_DESTACASELONF, value);
            _destacaselonf = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Utilizapercbon
    {
        get
        {
            PropriedadeAcessada(RO_UTILIZAPERCBON);
            return _utilizapercbon;
        }
        set
        {
            PropriedadeModificada(RO_UTILIZAPERCBON, value);
            _utilizapercbon = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 2)]
    public decimal? Percbondin
    {
        get
        {
            PropriedadeAcessada(RO_PERCBONDIN);
            return _percbondin;
        }
        set
        {
            PropriedadeModificada(RO_PERCBONDIN, value);
            _percbondin = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 2)]
    public decimal? Percbonmerc
    {
        get
        {
            PropriedadeAcessada(RO_PERCBONMERC);
            return _percbonmerc;
        }
        set
        {
            PropriedadeModificada(RO_PERCBONMERC, value);
            _percbonmerc = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 2)]
    public decimal? Perccomissao
    {
        get
        {
            PropriedadeAcessada(RO_PERCCOMISSAO);
            return _perccomissao;
        }
        set
        {
            PropriedadeModificada(RO_PERCCOMISSAO, value);
            _perccomissao = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Utilizaoutrasdespcalcipi
    {
        get
        {
            PropriedadeAcessada(RO_UTILIZAOUTRASDESPCALCIPI);
            return _utilizaoutrasdespcalcipi;
        }
        set
        {
            PropriedadeModificada(RO_UTILIZAOUTRASDESPCALCIPI, value);
            _utilizaoutrasdespcalcipi = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vllimitefretemin
    {
        get
        {
            PropriedadeAcessada(RO_VLLIMITEFRETEMIN);
            return _vllimitefretemin;
        }
        set
        {
            PropriedadeModificada(RO_VLLIMITEFRETEMIN, value);
            _vllimitefretemin = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 4)]
    public decimal? Percfluvial
    {
        get
        {
            PropriedadeAcessada(RO_PERCFLUVIAL);
            return _percfluvial;
        }
        set
        {
            PropriedadeModificada(RO_PERCFLUVIAL, value);
            _percfluvial = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 6, Precisao = 0)]
    public int? Codcontalancfrete
    {
        get
        {
            PropriedadeAcessada(RO_CODCONTALANCFRETE);
            return _codcontalancfrete;
        }
        set
        {
            PropriedadeModificada(RO_CODCONTALANCFRETE, value);
            _codcontalancfrete = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 2)]
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
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Utilizadesccalcst
    {
        get
        {
            PropriedadeAcessada(RO_UTILIZADESCCALCST);
            return _utilizadesccalcst;
        }
        set
        {
            PropriedadeModificada(RO_UTILIZADESCCALCST, value);
            _utilizadesccalcst = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Utilizadesccalcicms
    {
        get
        {
            PropriedadeAcessada(RO_UTILIZADESCCALCICMS);
            return _utilizadesccalcicms;
        }
        set
        {
            PropriedadeModificada(RO_UTILIZADESCCALCICMS, value);
            _utilizadesccalcicms = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Consipicalcbasest
    {
        get
        {
            PropriedadeAcessada(RO_CONSIPICALCBASEST);
            return _consipicalcbasest;
        }
        set
        {
            PropriedadeModificada(RO_CONSIPICALCBASEST, value);
            _consipicalcbasest = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Consipicalcbasecrepres
    {
        get
        {
            PropriedadeAcessada(RO_CONSIPICALCBASECREPRES);
            return _consipicalcbasecrepres;
        }
        set
        {
            PropriedadeModificada(RO_CONSIPICALCBASECREPRES, value);
            _consipicalcbasecrepres = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Classe
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
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Ereabastecimento
    {
        get
        {
            PropriedadeAcessada(RO_EREABASTECIMENTO);
            return _ereabastecimento;
        }
        set
        {
            PropriedadeModificada(RO_EREABASTECIMENTO, value);
            _ereabastecimento = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Eredespacho
    {
        get
        {
            PropriedadeAcessada(RO_EREDESPACHO);
            return _eredespacho;
        }
        set
        {
            PropriedadeModificada(RO_EREDESPACHO, value);
            _eredespacho = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 6, Precisao = 0)]
    public int? Codparcela
    {
        get
        {
            PropriedadeAcessada(RO_CODPARCELA);
            return _codparcela;
        }
        set
        {
            PropriedadeModificada(RO_CODPARCELA, value);
            _codparcela = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Rep_obs
    {
        get
        {
            PropriedadeAcessada(RO_REP_OBS);
            return _rep_obs;
        }
        set
        {
            PropriedadeModificada(RO_REP_OBS, value);
            _rep_obs = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Calcipicomfretefob
    {
        get
        {
            PropriedadeAcessada(RO_CALCIPICOMFRETEFOB);
            return _calcipicomfretefob;
        }
        set
        {
            PropriedadeModificada(RO_CALCIPICOMFRETEFOB, value);
            _calcipicomfretefob = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 0, Precisao = 0)]
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
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 0, Precisao = 0)]
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
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Usapercaltercustoent
    {
        get
        {
            PropriedadeAcessada(RO_USAPERCALTERCUSTOENT);
            return _usapercaltercustoent;
        }
        set
        {
            PropriedadeModificada(RO_USAPERCALTERCUSTOENT, value);
            _usapercaltercustoent = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Tipopessoa
    {
        get
        {
            PropriedadeAcessada(RO_TIPOPESSOA);
            return _tipopessoa;
        }
        set
        {
            PropriedadeModificada(RO_TIPOPESSOA, value);
            _tipopessoa = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 2)]
    public decimal? Percirrf
    {
        get
        {
            PropriedadeAcessada(RO_PERCIRRF);
            return _percirrf;
        }
        set
        {
            PropriedadeModificada(RO_PERCIRRF, value);
            _percirrf = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 10, Precisao = 0)]
    public int? Codcontairrf
    {
        get
        {
            PropriedadeAcessada(RO_CODCONTAIRRF);
            return _codcontairrf;
        }
        set
        {
            PropriedadeModificada(RO_CODCONTAIRRF, value);
            _codcontairrf = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 2)]
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
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 10, Precisao = 0)]
    public int? Codcontaiss
    {
        get
        {
            PropriedadeAcessada(RO_CODCONTAISS);
            return _codcontaiss;
        }
        set
        {
            PropriedadeModificada(RO_CODCONTAISS, value);
            _codcontaiss = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 10, Precisao = 0)]
    public int? Codcontacsrf
    {
        get
        {
            PropriedadeAcessada(RO_CODCONTACSRF);
            return _codcontacsrf;
        }
        set
        {
            PropriedadeModificada(RO_CODCONTACSRF, value);
            _codcontacsrf = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 10, Precisao = 0)]
    public int? Codcontainss
    {
        get
        {
            PropriedadeAcessada(RO_CODCONTAINSS);
            return _codcontainss;
        }
        set
        {
            PropriedadeModificada(RO_CODCONTAINSS, value);
            _codcontainss = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Exigeredespacho
    {
        get
        {
            PropriedadeAcessada(RO_EXIGEREDESPACHO);
            return _exigeredespacho;
        }
        set
        {
            PropriedadeModificada(RO_EXIGEREDESPACHO, value);
            _exigeredespacho = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Perfretevalor
    {
        get
        {
            PropriedadeAcessada(RO_PERFRETEVALOR);
            return _perfretevalor;
        }
        set
        {
            PropriedadeModificada(RO_PERFRETEVALOR, value);
            _perfretevalor = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Consolidardifprecoverba
    {
        get
        {
            PropriedadeAcessada(RO_CONSOLIDARDIFPRECOVERBA);
            return _consolidardifprecoverba;
        }
        set
        {
            PropriedadeModificada(RO_CONSOLIDARDIFPRECOVERBA, value);
            _consolidardifprecoverba = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
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
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Inscmunicip
    {
        get
        {
            PropriedadeAcessada(RO_INSCMUNICIP);
            return _inscmunicip;
        }
        set
        {
            PropriedadeModificada(RO_INSCMUNICIP, value);
            _inscmunicip = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Usapercicmsnaaliqextst
    {
        get
        {
            PropriedadeAcessada(RO_USAPERCICMSNAALIQEXTST);
            return _usapercicmsnaaliqextst;
        }
        set
        {
            PropriedadeModificada(RO_USAPERCICMSNAALIQEXTST, value);
            _usapercicmsnaaliqextst = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Consfretefobcalcicmsantecip
    {
        get
        {
            PropriedadeAcessada(RO_CONSFRETEFOBCALCICMSANTECIP);
            return _consfretefobcalcicmsantecip;
        }
        set
        {
            PropriedadeModificada(RO_CONSFRETEFOBCALCICMSANTECIP, value);
            _consfretefobcalcicmsantecip = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Iest
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
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 6, Precisao = 0)]
    public int? Codfornecstguia
    {
        get
        {
            PropriedadeAcessada(RO_CODFORNECSTGUIA);
            return _codfornecstguia;
        }
        set
        {
            PropriedadeModificada(RO_CODFORNECSTGUIA, value);
            _codfornecstguia = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Usanumnegociacao
    {
        get
        {
            PropriedadeAcessada(RO_USANUMNEGOCIACAO);
            return _usanumnegociacao;
        }
        set
        {
            PropriedadeModificada(RO_USANUMNEGOCIACAO, value);
            _usanumnegociacao = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Isentost
    {
        get
        {
            PropriedadeAcessada(RO_ISENTOST);
            return _isentost;
        }
        set
        {
            PropriedadeModificada(RO_ISENTOST, value);
            _isentost = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 8, Precisao = 0)]
    public int? Codusuariowinthor
    {
        get
        {
            PropriedadeAcessada(RO_CODUSUARIOWINTHOR);
            return _codusuariowinthor;
        }
        set
        {
            PropriedadeModificada(RO_CODUSUARIOWINTHOR, value);
            _codusuariowinthor = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 0, Precisao = 0)]
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
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Calcstguiaaliqext
    {
        get
        {
            PropriedadeAcessada(RO_CALCSTGUIAALIQEXT);
            return _calcstguiaaliqext;
        }
        set
        {
            PropriedadeModificada(RO_CALCSTGUIAALIQEXT, value);
            _calcstguiaaliqext = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 8, Precisao = 0)]
    public int? Codfornecfrete
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
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Calcularipipesoliq
    {
        get
        {
            PropriedadeAcessada(RO_CALCULARIPIPESOLIQ);
            return _calcularipipesoliq;
        }
        set
        {
            PropriedadeModificada(RO_CALCULARIPIPESOLIQ, value);
            _calcularipipesoliq = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Simplesnacional
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
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Complementoend
    {
        get
        {
            PropriedadeAcessada(RO_COMPLEMENTOEND);
            return _complementoend;
        }
        set
        {
            PropriedadeModificada(RO_COMPLEMENTOEND, value);
            _complementoend = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Numeroend
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
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 6, Precisao = 0)]
    public int? Codparcelastguia
    {
        get
        {
            PropriedadeAcessada(RO_CODPARCELASTGUIA);
            return _codparcelastguia;
        }
        set
        {
            PropriedadeModificada(RO_CODPARCELASTGUIA, value);
            _codparcelastguia = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Cae
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
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Geracreddifpreco
    {
        get
        {
            PropriedadeAcessada(RO_GERACREDDIFPRECO);
            return _geracreddifpreco;
        }
        set
        {
            PropriedadeModificada(RO_GERACREDDIFPRECO, value);
            _geracreddifpreco = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Utilizaoutdespcalcsuframa
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
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Consstnfpiscofins
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
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 6, Precisao = 0)]
    public int? Codpais
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
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Classifictipofornec
    {
        get
        {
            PropriedadeAcessada(RO_CLASSIFICTIPOFORNEC);
            return _classifictipofornec;
        }
        set
        {
            PropriedadeModificada(RO_CLASSIFICTIPOFORNEC, value);
            _classifictipofornec = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Transpautonomo
    {
        get
        {
            PropriedadeAcessada(RO_TRANSPAUTONOMO);
            return _transpautonomo;
        }
        set
        {
            PropriedadeModificada(RO_TRANSPAUTONOMO, value);
            _transpautonomo = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Rep_nextelid
    {
        get
        {
            PropriedadeAcessada(RO_REP_NEXTELID);
            return _rep_nextelid;
        }
        set
        {
            PropriedadeModificada(RO_REP_NEXTELID, value);
            _rep_nextelid = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 2)]
    public decimal? Percpisnfservico
    {
        get
        {
            PropriedadeAcessada(RO_PERCPISNFSERVICO);
            return _percpisnfservico;
        }
        set
        {
            PropriedadeModificada(RO_PERCPISNFSERVICO, value);
            _percpisnfservico = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 2)]
    public decimal? Perccofinsnfservico
    {
        get
        {
            PropriedadeAcessada(RO_PERCCOFINSNFSERVICO);
            return _perccofinsnfservico;
        }
        set
        {
            PropriedadeModificada(RO_PERCCOFINSNFSERVICO, value);
            _perccofinsnfservico = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 10, Precisao = 0)]
    public int? Codcontapis
    {
        get
        {
            PropriedadeAcessada(RO_CODCONTAPIS);
            return _codcontapis;
        }
        set
        {
            PropriedadeModificada(RO_CODCONTAPIS, value);
            _codcontapis = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 10, Precisao = 0)]
    public int? Codcontacofins
    {
        get
        {
            PropriedadeAcessada(RO_CODCONTACOFINS);
            return _codcontacofins;
        }
        set
        {
            PropriedadeModificada(RO_CODCONTACOFINS, value);
            _codcontacofins = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 3, Precisao = 0)]
    public int? Fornecimportacao
    {
        get
        {
            PropriedadeAcessada(RO_FORNECIMPORTACAO);
            return _fornecimportacao;
        }
        set
        {
            PropriedadeModificada(RO_FORNECIMPORTACAO, value);
            _fornecimportacao = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Pesomintransp
    {
        get
        {
            PropriedadeAcessada(RO_PESOMINTRANSP);
            return _pesomintransp;
        }
        set
        {
            PropriedadeModificada(RO_PESOMINTRANSP, value);
            _pesomintransp = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Taxaemissaoct
    {
        get
        {
            PropriedadeAcessada(RO_TAXAEMISSAOCT);
            return _taxaemissaoct;
        }
        set
        {
            PropriedadeModificada(RO_TAXAEMISSAOCT, value);
            _taxaemissaoct = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 12, Precisao = 0)]
    public int? Inss
    {
        get
        {
            PropriedadeAcessada(RO_INSS);
            return _inss;
        }
        set
        {
            PropriedadeModificada(RO_INSS, value);
            _inss = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Cgcaux
    {
        get
        {
            PropriedadeAcessada(RO_CGCAUX);
            return _cgcaux;
        }
        set
        {
            PropriedadeModificada(RO_CGCAUX, value);
            _cgcaux = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 10, Precisao = 0)]
    public int? Codcontacontabadiantfor
    {
        get
        {
            PropriedadeAcessada(RO_CODCONTACONTABADIANTFOR);
            return _codcontacontabadiantfor;
        }
        set
        {
            PropriedadeModificada(RO_CODCONTACONTABADIANTFOR, value);
            _codcontacontabadiantfor = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Calcdespfinprazopgto
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
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Usaoutrasdespseguropiscofins
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
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Numalvaraanvisa
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
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 0, Precisao = 0)]
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
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Numalvarafunc
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
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 0, Precisao = 0)]
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
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Numalvarapsico
    {
        get
        {
            PropriedadeAcessada(RO_NUMALVARAPSICO);
            return _numalvarapsico;
        }
        set
        {
            PropriedadeModificada(RO_NUMALVARAPSICO, value);
            _numalvarapsico = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 0, Precisao = 0)]
    public DateTime? Dtvencalvarapsico
    {
        get
        {
            PropriedadeAcessada(RO_DTVENCALVARAPSICO);
            return _dtvencalvarapsico;
        }
        set
        {
            PropriedadeModificada(RO_DTVENCALVARAPSICO, value);
            _dtvencalvarapsico = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Crf
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
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 0, Precisao = 0)]
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
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 2)]
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
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 2)]
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
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 3, Precisao = 0)]
    public int? Codsittribpiscofinsconhec
    {
        get
        {
            PropriedadeAcessada(RO_CODSITTRIBPISCOFINSCONHEC);
            return _codsittribpiscofinsconhec;
        }
        set
        {
            PropriedadeModificada(RO_CODSITTRIBPISCOFINSCONHEC, value);
            _codsittribpiscofinsconhec = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Usacredpiscofinsentbonific
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
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Contribuinteicms
    {
        get
        {
            PropriedadeAcessada(RO_CONTRIBUINTEICMS);
            return _contribuinteicms;
        }
        set
        {
            PropriedadeModificada(RO_CONTRIBUINTEICMS, value);
            _contribuinteicms = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Recalctribent
    {
        get
        {
            PropriedadeAcessada(RO_RECALCTRIBENT);
            return _recalctribent;
        }
        set
        {
            PropriedadeModificada(RO_RECALCTRIBENT, value);
            _recalctribent = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Consmaioricmsvlpauta
    {
        get
        {
            PropriedadeAcessada(RO_CONSMAIORICMSVLPAUTA);
            return _consmaioricmsvlpauta;
        }
        set
        {
            PropriedadeModificada(RO_CONSMAIORICMSVLPAUTA, value);
            _consmaioricmsvlpauta = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Bloqueiosefazfornec
    {
        get
        {
            PropriedadeAcessada(RO_BLOQUEIOSEFAZFORNEC);
            return _bloqueiosefazfornec;
        }
        set
        {
            PropriedadeModificada(RO_BLOQUEIOSEFAZFORNEC, value);
            _bloqueiosefazfornec = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 0, Precisao = 0)]
    public DateTime? Dtbloqueiosefazfornec
    {
        get
        {
            PropriedadeAcessada(RO_DTBLOQUEIOSEFAZFORNEC);
            return _dtbloqueiosefazfornec;
        }
        set
        {
            PropriedadeModificada(RO_DTBLOQUEIOSEFAZFORNEC, value);
            _dtbloqueiosefazfornec = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 2)]
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
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 2)]
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
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Dedfretecifcredpresicms
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
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Emitenfe
    {
        get
        {
            PropriedadeAcessada(RO_EMITENFE);
            return _emitenfe;
        }
        set
        {
            PropriedadeModificada(RO_EMITENFE, value);
            _emitenfe = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Atualizastultent
    {
        get
        {
            PropriedadeAcessada(RO_ATUALIZASTULTENT);
            return _atualizastultent;
        }
        set
        {
            PropriedadeModificada(RO_ATUALIZASTULTENT, value);
            _atualizastultent = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Codcontab
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
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 2, Precisao = 0)]
    public int? Numcasasdecreducaoicms
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
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Utilizaipicalcicms
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
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Avaliacaovenda
    {
        get
        {
            PropriedadeAcessada(RO_AVALIACAOVENDA);
            return _avaliacaovenda;
        }
        set
        {
            PropriedadeModificada(RO_AVALIACAOVENDA, value);
            _avaliacaovenda = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 0, Precisao = 0)]
    public DateTime? Dtproxcompra
    {
        get
        {
            PropriedadeAcessada(RO_DTPROXCOMPRA);
            return _dtproxcompra;
        }
        set
        {
            PropriedadeModificada(RO_DTPROXCOMPRA, value);
            _dtproxcompra = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 0, Precisao = 0)]
    public DateTime? Dtultcompra
    {
        get
        {
            PropriedadeAcessada(RO_DTULTCOMPRA);
            return _dtultcompra;
        }
        set
        {
            PropriedadeModificada(RO_DTULTCOMPRA, value);
            _dtultcompra = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 4, Precisao = 0)]
    public int? Periodicidadecompra
    {
        get
        {
            PropriedadeAcessada(RO_PERIODICIDADECOMPRA);
            return _periodicidadecompra;
        }
        set
        {
            PropriedadeModificada(RO_PERIODICIDADECOMPRA, value);
            _periodicidadecompra = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 4, Precisao = 0)]
    public int? Diasavaliacaovenda
    {
        get
        {
            PropriedadeAcessada(RO_DIASAVALIACAOVENDA);
            return _diasavaliacaovenda;
        }
        set
        {
            PropriedadeModificada(RO_DIASAVALIACAOVENDA, value);
            _diasavaliacaovenda = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 13, Precisao = 0)]
    public int? Codgln
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
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 3, Precisao = 0)]
    public int? Codsittribpiscofinsservico
    {
        get
        {
            PropriedadeAcessada(RO_CODSITTRIBPISCOFINSSERVICO);
            return _codsittribpiscofinsservico;
        }
        set
        {
            PropriedadeModificada(RO_CODSITTRIBPISCOFINSSERVICO, value);
            _codsittribpiscofinsservico = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Consstguiapiscofins
    {
        get
        {
            PropriedadeAcessada(RO_CONSSTGUIAPISCOFINS);
            return _consstguiapiscofins;
        }
        set
        {
            PropriedadeModificada(RO_CONSSTGUIAPISCOFINS, value);
            _consstguiapiscofins = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Concedcredpres
    {
        get
        {
            PropriedadeAcessada(RO_CONCEDCREDPRES);
            return _concedcredpres;
        }
        set
        {
            PropriedadeModificada(RO_CONCEDCREDPRES, value);
            _concedcredpres = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Usafretefobporfornec
    {
        get
        {
            PropriedadeAcessada(RO_USAFRETEFOBPORFORNEC);
            return _usafretefobporfornec;
        }
        set
        {
            PropriedadeModificada(RO_USAFRETEFOBPORFORNEC, value);
            _usafretefobporfornec = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 15, Precisao = 2)]
    public decimal? Vlminpedreposicao
    {
        get
        {
            PropriedadeAcessada(RO_VLMINPEDREPOSICAO);
            return _vlminpedreposicao;
        }
        set
        {
            PropriedadeModificada(RO_VLMINPEDREPOSICAO, value);
            _vlminpedreposicao = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Gerapedbonific
    {
        get
        {
            PropriedadeAcessada(RO_GERAPEDBONIFIC);
            return _gerapedbonific;
        }
        set
        {
            PropriedadeModificada(RO_GERAPEDBONIFIC, value);
            _gerapedbonific = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 4, Precisao = 0)]
    public int? Qtdiasvencverbas
    {
        get
        {
            PropriedadeAcessada(RO_QTDIASVENCVERBAS);
            return _qtdiasvencverbas;
        }
        set
        {
            PropriedadeModificada(RO_QTDIASVENCVERBAS, value);
            _qtdiasvencverbas = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 2, Precisao = 0)]
    public int? Tipofinancdevfornec
    {
        get
        {
            PropriedadeAcessada(RO_TIPOFINANCDEVFORNEC);
            return _tipofinancdevfornec;
        }
        set
        {
            PropriedadeModificada(RO_TIPOFINANCDEVFORNEC, value);
            _tipofinancdevfornec = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 8, Precisao = 0)]
    public int? Cfopentadjud
    {
        get
        {
            PropriedadeAcessada(RO_CFOPENTADJUD);
            return _cfopentadjud;
        }
        set
        {
            PropriedadeModificada(RO_CFOPENTADJUD, value);
            _cfopentadjud = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Sittribentadjud
    {
        get
        {
            PropriedadeAcessada(RO_SITTRIBENTADJUD);
            return _sittribentadjud;
        }
        set
        {
            PropriedadeModificada(RO_SITTRIBENTADJUD, value);
            _sittribentadjud = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 8, Precisao = 0)]
    public int? Cfoprestituicao
    {
        get
        {
            PropriedadeAcessada(RO_CFOPRESTITUICAO);
            return _cfoprestituicao;
        }
        set
        {
            PropriedadeModificada(RO_CFOPRESTITUICAO, value);
            _cfoprestituicao = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Sittribrestituicao
    {
        get
        {
            PropriedadeAcessada(RO_SITTRIBRESTITUICAO);
            return _sittribrestituicao;
        }
        set
        {
            PropriedadeModificada(RO_SITTRIBRESTITUICAO, value);
            _sittribrestituicao = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Utilizaoutdespnfbasest
    {
        get
        {
            PropriedadeAcessada(RO_UTILIZAOUTDESPNFBASEST);
            return _utilizaoutdespnfbasest;
        }
        set
        {
            PropriedadeModificada(RO_UTILIZAOUTDESPNFBASEST, value);
            _utilizaoutdespnfbasest = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Binario, Tamanho = 0, Precisao = 0)]
    public byte[]? Idintegracaomyfrota
    {
        get
        {
            PropriedadeAcessada(RO_IDINTEGRACAOMYFROTA);
            return _idintegracaomyfrota;
        }
        set
        {
            PropriedadeModificada(RO_IDINTEGRACAOMYFROTA, value);
            _idintegracaomyfrota = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Consfretefobbasestnf
    {
        get
        {
            PropriedadeAcessada(RO_CONSFRETEFOBBASESTNF);
            return _consfretefobbasestnf;
        }
        set
        {
            PropriedadeModificada(RO_CONSFRETEFOBBASESTNF, value);
            _consfretefobbasestnf = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 6, Precisao = 0)]
    public int? Codparcelafretefob
    {
        get
        {
            PropriedadeAcessada(RO_CODPARCELAFRETEFOB);
            return _codparcelafretefob;
        }
        set
        {
            PropriedadeModificada(RO_CODPARCELAFRETEFOB, value);
            _codparcelafretefob = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 6, Precisao = 0)]
    public int? Codparcelaoutdesp
    {
        get
        {
            PropriedadeAcessada(RO_CODPARCELAOUTDESP);
            return _codparcelaoutdesp;
        }
        set
        {
            PropriedadeModificada(RO_CODPARCELAOUTDESP, value);
            _codparcelaoutdesp = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 6, Precisao = 0)]
    public int? Codparcicmsantecip
    {
        get
        {
            PropriedadeAcessada(RO_CODPARCICMSANTECIP);
            return _codparcicmsantecip;
        }
        set
        {
            PropriedadeModificada(RO_CODPARCICMSANTECIP, value);
            _codparcicmsantecip = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 6, Precisao = 0)]
    public int? Codparceladifaliq
    {
        get
        {
            PropriedadeAcessada(RO_CODPARCELADIFALIQ);
            return _codparceladifaliq;
        }
        set
        {
            PropriedadeModificada(RO_CODPARCELADIFALIQ, value);
            _codparceladifaliq = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 10, Precisao = 0)]
    public int? Codcontainsstomador
    {
        get
        {
            PropriedadeAcessada(RO_CODCONTAINSSTOMADOR);
            return _codcontainsstomador;
        }
        set
        {
            PropriedadeModificada(RO_CODCONTAINSSTOMADOR, value);
            _codcontainsstomador = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 2)]
    public decimal? Percinsstomador
    {
        get
        {
            PropriedadeAcessada(RO_PERCINSSTOMADOR);
            return _percinsstomador;
        }
        set
        {
            PropriedadeModificada(RO_PERCINSSTOMADOR, value);
            _percinsstomador = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Ressarcimentostnf
    {
        get
        {
            PropriedadeAcessada(RO_RESSARCIMENTOSTNF);
            return _ressarcimentostnf;
        }
        set
        {
            PropriedadeModificada(RO_RESSARCIMENTOSTNF, value);
            _ressarcimentostnf = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Ressarcimentostguia
    {
        get
        {
            PropriedadeAcessada(RO_RESSARCIMENTOSTGUIA);
            return _ressarcimentostguia;
        }
        set
        {
            PropriedadeModificada(RO_RESSARCIMENTOSTGUIA, value);
            _ressarcimentostguia = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Adjudicacao
    {
        get
        {
            PropriedadeAcessada(RO_ADJUDICACAO);
            return _adjudicacao;
        }
        set
        {
            PropriedadeModificada(RO_ADJUDICACAO, value);
            _adjudicacao = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 8, Precisao = 0)]
    public int? Cfopressarcimentostguia
    {
        get
        {
            PropriedadeAcessada(RO_CFOPRESSARCIMENTOSTGUIA);
            return _cfopressarcimentostguia;
        }
        set
        {
            PropriedadeModificada(RO_CFOPRESSARCIMENTOSTGUIA, value);
            _cfopressarcimentostguia = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Sittributressarcimentostguia
    {
        get
        {
            PropriedadeAcessada(RO_SITTRIBUTRESSARCIMENTOSTGUIA);
            return _sittributressarcimentostguia;
        }
        set
        {
            PropriedadeModificada(RO_SITTRIBUTRESSARCIMENTOSTGUIA, value);
            _sittributressarcimentostguia = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Usadrawback
    {
        get
        {
            PropriedadeAcessada(RO_USADRAWBACK);
            return _usadrawback;
        }
        set
        {
            PropriedadeModificada(RO_USADRAWBACK, value);
            _usadrawback = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Utilizaicmsdifzerado
    {
        get
        {
            PropriedadeAcessada(RO_UTILIZAICMSDIFZERADO);
            return _utilizaicmsdifzerado;
        }
        set
        {
            PropriedadeModificada(RO_UTILIZAICMSDIFZERADO, value);
            _utilizaicmsdifzerado = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Calcpiscofinsbasered
    {
        get
        {
            PropriedadeAcessada(RO_CALCPISCOFINSBASERED);
            return _calcpiscofinsbasered;
        }
        set
        {
            PropriedadeModificada(RO_CALCPISCOFINSBASERED, value);
            _calcpiscofinsbasered = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 2)]
    public decimal? Percsestsenat
    {
        get
        {
            PropriedadeAcessada(RO_PERCSESTSENAT);
            return _percsestsenat;
        }
        set
        {
            PropriedadeModificada(RO_PERCSESTSENAT, value);
            _percsestsenat = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 10, Precisao = 0)]
    public int? Codcontasestsenat
    {
        get
        {
            PropriedadeAcessada(RO_CODCONTASESTSENAT);
            return _codcontasestsenat;
        }
        set
        {
            PropriedadeModificada(RO_CODCONTASESTSENAT, value);
            _codcontasestsenat = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Equipindustria
    {
        get
        {
            PropriedadeAcessada(RO_EQUIPINDUSTRIA);
            return _equipindustria;
        }
        set
        {
            PropriedadeModificada(RO_EQUIPINDUSTRIA, value);
            _equipindustria = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 6, Precisao = 0)]
    public int? Codparcelafunrural
    {
        get
        {
            PropriedadeAcessada(RO_CODPARCELAFUNRURAL);
            return _codparcelafunrural;
        }
        set
        {
            PropriedadeModificada(RO_CODPARCELAFUNRURAL, value);
            _codparcelafunrural = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Conscapataziaicms
    {
        get
        {
            PropriedadeAcessada(RO_CONSCAPATAZIAICMS);
            return _conscapataziaicms;
        }
        set
        {
            PropriedadeModificada(RO_CONSCAPATAZIAICMS, value);
            _conscapataziaicms = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Consumidorfinal
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
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Deduzirsuframaaliqext
    {
        get
        {
            PropriedadeAcessada(RO_DEDUZIRSUFRAMAALIQEXT);
            return _deduzirsuframaaliqext;
        }
        set
        {
            PropriedadeModificada(RO_DEDUZIRSUFRAMAALIQEXT, value);
            _deduzirsuframaaliqext = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Consipicalcicmsant
    {
        get
        {
            PropriedadeAcessada(RO_CONSIPICALCICMSANT);
            return _consipicalcicmsant;
        }
        set
        {
            PropriedadeModificada(RO_CONSIPICALCICMSANT, value);
            _consipicalcicmsant = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Emailnfe
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
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Creditarsaldoestverba
    {
        get
        {
            PropriedadeAcessada(RO_CREDITARSALDOESTVERBA);
            return _creditarsaldoestverba;
        }
        set
        {
            PropriedadeModificada(RO_CREDITARSALDOESTVERBA, value);
            _creditarsaldoestverba = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Transpcredenciadosefaz
    {
        get
        {
            PropriedadeAcessada(RO_TRANSPCREDENCIADOSEFAZ);
            return _transpcredenciadosefaz;
        }
        set
        {
            PropriedadeModificada(RO_TRANSPCREDENCIADOSEFAZ, value);
            _transpcredenciadosefaz = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Numcredenciamentosefaz
    {
        get
        {
            PropriedadeAcessada(RO_NUMCREDENCIAMENTOSEFAZ);
            return _numcredenciamentosefaz;
        }
        set
        {
            PropriedadeModificada(RO_NUMCREDENCIAMENTOSEFAZ, value);
            _numcredenciamentosefaz = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Usaecommerceunilever
    {
        get
        {
            PropriedadeAcessada(RO_USAECOMMERCEUNILEVER);
            return _usaecommerceunilever;
        }
        set
        {
            PropriedadeModificada(RO_USAECOMMERCEUNILEVER, value);
            _usaecommerceunilever = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 2, Precisao = 0)]
    public int? Horacoleta
    {
        get
        {
            PropriedadeAcessada(RO_HORACOLETA);
            return _horacoleta;
        }
        set
        {
            PropriedadeModificada(RO_HORACOLETA, value);
            _horacoleta = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Usadebcredoperlog
    {
        get
        {
            PropriedadeAcessada(RO_USADEBCREDOPERLOG);
            return _usadebcredoperlog;
        }
        set
        {
            PropriedadeModificada(RO_USADEBCREDOPERLOG, value);
            _usadebcredoperlog = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 2, Precisao = 0)]
    public int? Diapgverbaoperlog
    {
        get
        {
            PropriedadeAcessada(RO_DIAPGVERBAOPERLOG);
            return _diapgverbaoperlog;
        }
        set
        {
            PropriedadeModificada(RO_DIAPGVERBAOPERLOG, value);
            _diapgverbaoperlog = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Creditadescmenoroperlog
    {
        get
        {
            PropriedadeAcessada(RO_CREDITADESCMENOROPERLOG);
            return _creditadescmenoroperlog;
        }
        set
        {
            PropriedadeModificada(RO_CREDITADESCMENOROPERLOG, value);
            _creditadescmenoroperlog = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Codcobsefaz
    {
        get
        {
            PropriedadeAcessada(RO_CODCOBSEFAZ);
            return _codcobsefaz;
        }
        set
        {
            PropriedadeModificada(RO_CODCOBSEFAZ, value);
            _codcobsefaz = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Contribuintedocprb
    {
        get
        {
            PropriedadeAcessada(RO_CONTRIBUINTEDOCPRB);
            return _contribuintedocprb;
        }
        set
        {
            PropriedadeModificada(RO_CONTRIBUINTEDOCPRB, value);
            _contribuintedocprb = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Urlbaserastreio
    {
        get
        {
            PropriedadeAcessada(RO_URLBASERASTREIO);
            return _urlbaserastreio;
        }
        set
        {
            PropriedadeModificada(RO_URLBASERASTREIO, value);
            _urlbaserastreio = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Deduzirsuframadifaliq
    {
        get
        {
            PropriedadeAcessada(RO_DEDUZIRSUFRAMADIFALIQ);
            return _deduzirsuframadifaliq;
        }
        set
        {
            PropriedadeModificada(RO_DEDUZIRSUFRAMADIFALIQ, value);
            _deduzirsuframadifaliq = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 3, Precisao = 0)]
    public int? Codlicitgrupofornec
    {
        get
        {
            PropriedadeAcessada(RO_CODLICITGRUPOFORNEC);
            return _codlicitgrupofornec;
        }
        set
        {
            PropriedadeModificada(RO_CODLICITGRUPOFORNEC, value);
            _codlicitgrupofornec = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 0, Precisao = 0)]
    public int? Formapgto
    {
        get
        {
            PropriedadeAcessada(RO_FORMAPGTO);
            return _formapgto;
        }
        set
        {
            PropriedadeModificada(RO_FORMAPGTO, value);
            _formapgto = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Associacaodesportiva
    {
        get
        {
            PropriedadeAcessada(RO_ASSOCIACAODESPORTIVA);
            return _associacaodesportiva;
        }
        set
        {
            PropriedadeModificada(RO_ASSOCIACAODESPORTIVA, value);
            _associacaodesportiva = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Codigonacionalobras
    {
        get
        {
            PropriedadeAcessada(RO_CODIGONACIONALOBRAS);
            return _codigonacionalobras;
        }
        set
        {
            PropriedadeModificada(RO_CODIGONACIONALOBRAS, value);
            _codigonacionalobras = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Considerarpautazerostguia
    {
        get
        {
            PropriedadeAcessada(RO_CONSIDERARPAUTAZEROSTGUIA);
            return _considerarpautazerostguia;
        }
        set
        {
            PropriedadeModificada(RO_CONSIDERARPAUTAZEROSTGUIA, value);
            _considerarpautazerostguia = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Calccredicmsbasereduzida
    {
        get
        {
            PropriedadeAcessada(RO_CALCCREDICMSBASEREDUZIDA);
            return _calccredicmsbasereduzida;
        }
        set
        {
            PropriedadeModificada(RO_CALCCREDICMSBASEREDUZIDA, value);
            _calccredicmsbasereduzida = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Codcentrocusto
    {
        get
        {
            PropriedadeAcessada(RO_CODCENTROCUSTO);
            return _codcentrocusto;
        }
        set
        {
            PropriedadeModificada(RO_CODCENTROCUSTO, value);
            _codcentrocusto = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Percmargemgarantida
    {
        get
        {
            PropriedadeAcessada(RO_PERCMARGEMGARANTIDA);
            return _percmargemgarantida;
        }
        set
        {
            PropriedadeModificada(RO_PERCMARGEMGARANTIDA, value);
            _percmargemgarantida = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Detentorregespecial
    {
        get
        {
            PropriedadeAcessada(RO_DETENTORREGESPECIAL);
            return _detentorregespecial;
        }
        set
        {
            PropriedadeModificada(RO_DETENTORREGESPECIAL, value);
            _detentorregespecial = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Deduzirfcpicmsdofcpst
    {
        get
        {
            PropriedadeAcessada(RO_DEDUZIRFCPICMSDOFCPST);
            return _deduzirfcpicmsdofcpst;
        }
        set
        {
            PropriedadeModificada(RO_DEDUZIRFCPICMSDOFCPST, value);
            _deduzirfcpicmsdofcpst = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Idsofitview
    {
        get
        {
            PropriedadeAcessada(RO_IDSOFITVIEW);
            return _idsofitview;
        }
        set
        {
            PropriedadeModificada(RO_IDSOFITVIEW, value);
            _idsofitview = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 0, Precisao = 0)]
    public DateTime? Dtultaltersofitview
    {
        get
        {
            PropriedadeAcessada(RO_DTULTALTERSOFITVIEW);
            return _dtultaltersofitview;
        }
        set
        {
            PropriedadeModificada(RO_DTULTALTERSOFITVIEW, value);
            _dtultaltersofitview = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 0, Precisao = 0)]
    public DateTime? Dtexclusaosofitview
    {
        get
        {
            PropriedadeAcessada(RO_DTEXCLUSAOSOFITVIEW);
            return _dtexclusaosofitview;
        }
        set
        {
            PropriedadeModificada(RO_DTEXCLUSAOSOFITVIEW, value);
            _dtexclusaosofitview = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Gerarreceitarestituicao
    {
        get
        {
            PropriedadeAcessada(RO_GERARRECEITARESTITUICAO);
            return _gerarreceitarestituicao;
        }
        set
        {
            PropriedadeModificada(RO_GERARRECEITARESTITUICAO, value);
            _gerarreceitarestituicao = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Condcomercautorizmed
    {
        get
        {
            PropriedadeAcessada(RO_CONDCOMERCAUTORIZMED);
            return _condcomercautorizmed;
        }
        set
        {
            PropriedadeModificada(RO_CONDCOMERCAUTORIZMED, value);
            _condcomercautorizmed = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Manifestacaoautomatica
    {
        get
        {
            PropriedadeAcessada(RO_MANIFESTACAOAUTOMATICA);
            return _manifestacaoautomatica;
        }
        set
        {
            PropriedadeModificada(RO_MANIFESTACAOAUTOMATICA, value);
            _manifestacaoautomatica = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Gerapedidocompraxml
    {
        get
        {
            PropriedadeAcessada(RO_GERAPEDIDOCOMPRAXML);
            return _gerapedidocompraxml;
        }
        set
        {
            PropriedadeModificada(RO_GERAPEDIDOCOMPRAXML, value);
            _gerapedidocompraxml = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Usaredicmspara
    {
        get
        {
            PropriedadeAcessada(RO_USAREDICMSPARA);
            return _usaredicmspara;
        }
        set
        {
            PropriedadeModificada(RO_USAREDICMSPARA, value);
            _usaredicmspara = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Consdesonnovesuframa
    {
        get
        {
            PropriedadeAcessada(RO_CONSDESONNOVESUFRAMA);
            return _consdesonnovesuframa;
        }
        set
        {
            PropriedadeModificada(RO_CONSDESONNOVESUFRAMA, value);
            _consdesonnovesuframa = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Gravarcodfab253
    {
        get
        {
            PropriedadeAcessada(RO_GRAVARCODFAB253);
            return _gravarcodfab253;
        }
        set
        {
            PropriedadeModificada(RO_GRAVARCODFAB253, value);
            _gravarcodfab253 = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Utilizafator253
    {
        get
        {
            PropriedadeAcessada(RO_UTILIZAFATOR253);
            return _utilizafator253;
        }
        set
        {
            PropriedadeModificada(RO_UTILIZAFATOR253, value);
            _utilizafator253 = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Importaxmlautomatico
    {
        get
        {
            PropriedadeAcessada(RO_IMPORTAXMLAUTOMATICO);
            return _importaxmlautomatico;
        }
        set
        {
            PropriedadeModificada(RO_IMPORTAXMLAUTOMATICO, value);
            _importaxmlautomatico = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Deduziripibasedifaliq
    {
        get
        {
            PropriedadeAcessada(RO_DEDUZIRIPIBASEDIFALIQ);
            return _deduziripibasedifaliq;
        }
        set
        {
            PropriedadeModificada(RO_DEDUZIRIPIBASEDIFALIQ, value);
            _deduziripibasedifaliq = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Consfretefobbasedifaliq
    {
        get
        {
            PropriedadeAcessada(RO_CONSFRETEFOBBASEDIFALIQ);
            return _consfretefobbasedifaliq;
        }
        set
        {
            PropriedadeModificada(RO_CONSFRETEFOBBASEDIFALIQ, value);
            _consfretefobbasedifaliq = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Alimentafundomultifilial
    {
        get
        {
            PropriedadeAcessada(RO_ALIMENTAFUNDOMULTIFILIAL);
            return _alimentafundomultifilial;
        }
        set
        {
            PropriedadeModificada(RO_ALIMENTAFUNDOMULTIFILIAL, value);
            _alimentafundomultifilial = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Origemparcfinanc
    {
        get
        {
            PropriedadeAcessada(RO_ORIGEMPARCFINANC);
            return _origemparcfinanc;
        }
        set
        {
            PropriedadeModificada(RO_ORIGEMPARCFINANC, value);
            _origemparcfinanc = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Aplicaverbarebcusto
    {
        get
        {
            PropriedadeAcessada(RO_APLICAVERBAREBCUSTO);
            return _aplicaverbarebcusto;
        }
        set
        {
            PropriedadeModificada(RO_APLICAVERBAREBCUSTO, value);
            _aplicaverbarebcusto = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Tipofretedespacho
    {
        get
        {
            PropriedadeAcessada(RO_TIPOFRETEDESPACHO);
            return _tipofretedespacho;
        }
        set
        {
            PropriedadeModificada(RO_TIPOFRETEDESPACHO, value);
            _tipofretedespacho = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Tipovencimento
    {
        get
        {
            PropriedadeAcessada(RO_TIPOVENCIMENTO);
            return _tipovencimento;
        }
        set
        {
            PropriedadeModificada(RO_TIPOVENCIMENTO, value);
            _tipovencimento = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Aplicrebcustomultifilial
    {
        get
        {
            PropriedadeAcessada(RO_APLICREBCUSTOMULTIFILIAL);
            return _aplicrebcustomultifilial;
        }
        set
        {
            PropriedadeModificada(RO_APLICREBCUSTOMULTIFILIAL, value);
            _aplicrebcustomultifilial = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Formatribprodrural
    {
        get
        {
            PropriedadeAcessada(RO_FORMATRIBPRODRURAL);
            return _formatribprodrural;
        }
        set
        {
            PropriedadeModificada(RO_FORMATRIBPRODRURAL, value);
            _formatribprodrural = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Indaqprodrural
    {
        get
        {
            PropriedadeAcessada(RO_INDAQPRODRURAL);
            return _indaqprodrural;
        }
        set
        {
            PropriedadeModificada(RO_INDAQPRODRURAL, value);
            _indaqprodrural = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Produtorrural
    {
        get
        {
            PropriedadeAcessada(RO_PRODUTORRURAL);
            return _produtorrural;
        }
        set
        {
            PropriedadeModificada(RO_PRODUTORRURAL, value);
            _produtorrural = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Cpfprodutorrural
    {
        get
        {
            PropriedadeAcessada(RO_CPFPRODUTORRURAL);
            return _cpfprodutorrural;
        }
        set
        {
            PropriedadeModificada(RO_CPFPRODUTORRURAL, value);
            _cpfprodutorrural = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Perccontribprevdesc
    {
        get
        {
            PropriedadeAcessada(RO_PERCCONTRIBPREVDESC);
            return _perccontribprevdesc;
        }
        set
        {
            PropriedadeModificada(RO_PERCCONTRIBPREVDESC, value);
            _perccontribprevdesc = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Perccontribbemconc
    {
        get
        {
            PropriedadeAcessada(RO_PERCCONTRIBBEMCONC);
            return _perccontribbemconc;
        }
        set
        {
            PropriedadeModificada(RO_PERCCONTRIBBEMCONC, value);
            _perccontribbemconc = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Perccontribsenar
    {
        get
        {
            PropriedadeAcessada(RO_PERCCONTRIBSENAR);
            return _perccontribsenar;
        }
        set
        {
            PropriedadeModificada(RO_PERCCONTRIBSENAR, value);
            _perccontribsenar = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Codfornecbal
    {
        get
        {
            PropriedadeAcessada(RO_CODFORNECBAL);
            return _codfornecbal;
        }
        set
        {
            PropriedadeModificada(RO_CODFORNECBAL, value);
            _codfornecbal = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Utilizapiscofinstribent
    {
        get
        {
            PropriedadeAcessada(RO_UTILIZAPISCOFINSTRIBENT);
            return _utilizapiscofinstribent;
        }
        set
        {
            PropriedadeModificada(RO_UTILIZAPISCOFINSTRIBENT, value);
            _utilizapiscofinstribent = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORNEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Utilizaicmstribent
    {
        get
        {
            PropriedadeAcessada(RO_UTILIZAICMSTRIBENT);
            return _utilizaicmstribent;
        }
        set
        {
            PropriedadeModificada(RO_UTILIZAICMSTRIBENT, value);
            _utilizaicmstribent = value;
        }
    }

    public void InicializarAtributos() { }

    public string ObterNomeTabela() => "PCFORNEC";

    public IEntidade NovaInstancia() => (IEntidade)GetType().GetConstructors()[0].Invoke(null);

    public void CarregarPorDataReader(IDataReader leitor)
    {
        _codfornec = AlterarTipo<int>(leitor["Codfornec"]);
        _fornecedor = AlterarTipo<string>(leitor["Fornecedor"]);
        _repres = AlterarTipo<string?>(leitor["Repres"]);
        _contato = AlterarTipo<string?>(leitor["Contato"]);
        _ender = AlterarTipo<string?>(leitor["Ender"]);
        _cidade = AlterarTipo<string?>(leitor["Cidade"]);
        _estado = AlterarTipo<string?>(leitor["Estado"]);
        _cep = AlterarTipo<string?>(leitor["Cep"]);
        _telrep = AlterarTipo<string?>(leitor["Telrep"]);
        _telfab = AlterarTipo<string?>(leitor["Telfab"]);
        _telexrep = AlterarTipo<string?>(leitor["Telexrep"]);
        _telexfab = AlterarTipo<string?>(leitor["Telexfab"]);
        _ie = AlterarTipo<string?>(leitor["Ie"]);
        _cgc = AlterarTipo<string?>(leitor["Cgc"]);
        _faxrep = AlterarTipo<string?>(leitor["Faxrep"]);
        _faxfab = AlterarTipo<string?>(leitor["Faxfab"]);
        _bairro = AlterarTipo<string?>(leitor["Bairro"]);
        _prazoentrega = AlterarTipo<int?>(leitor["Prazoentrega"]);
        _bloqueio = AlterarTipo<string?>(leitor["Bloqueio"]);
        _dtbloqueio = AlterarTipo<DateTime?>(leitor["Dtbloqueio"]);
        _obs = AlterarTipo<string?>(leitor["Obs"]);
        _revenda = AlterarTipo<string?>(leitor["Revenda"]);
        _codcli = AlterarTipo<int?>(leitor["Codcli"]);
        _codcomprador = AlterarTipo<int?>(leitor["Codcomprador"]);
        _rep_contato = AlterarTipo<string?>(leitor["Rep_contato"]);
        _rep_endereco = AlterarTipo<string?>(leitor["Rep_endereco"]);
        _rep_bairro = AlterarTipo<string?>(leitor["Rep_bairro"]);
        _rep_cidade = AlterarTipo<string?>(leitor["Rep_cidade"]);
        _rep_uf = AlterarTipo<string?>(leitor["Rep_uf"]);
        _rep_cep = AlterarTipo<int?>(leitor["Rep_cep"]);
        _excluido = AlterarTipo<string?>(leitor["Excluido"]);
        _ledtime = AlterarTipo<int?>(leitor["Ledtime"]);
        _cobertura = AlterarTipo<int?>(leitor["Cobertura"]);
        _regional = AlterarTipo<string?>(leitor["Regional"]);
        _centralizacao = AlterarTipo<string?>(leitor["Centralizacao"]);
        _dtcadastro = AlterarTipo<DateTime?>(leitor["Dtcadastro"]);
        _dtexclusao = AlterarTipo<DateTime?>(leitor["Dtexclusao"]);
        _obs2 = AlterarTipo<string?>(leitor["Obs2"]);
        _prazomin = AlterarTipo<int?>(leitor["Prazomin"]);
        _descpagtodup = AlterarTipo<string?>(leitor["Descpagtodup"]);
        _endercob = AlterarTipo<string?>(leitor["Endercob"]);
        _bairrocob = AlterarTipo<string?>(leitor["Bairrocob"]);
        _municob = AlterarTipo<string?>(leitor["Municob"]);
        _estcob = AlterarTipo<string?>(leitor["Estcob"]);
        _cepcob = AlterarTipo<string?>(leitor["Cepcob"]);
        _telcob = AlterarTipo<string?>(leitor["Telcob"]);
        _estrategico = AlterarTipo<string?>(leitor["Estrategico"]);
        _observacao = AlterarTipo<string?>(leitor["Observacao"]);
        _coddepto = AlterarTipo<int?>(leitor["Coddepto"]);
        _codfornecprinc = AlterarTipo<int?>(leitor["Codfornecprinc"]);
        _contatocom = AlterarTipo<string?>(leitor["Contatocom"]);
        _telefonecom = AlterarTipo<string?>(leitor["Telefonecom"]);
        _contatoadm = AlterarTipo<string?>(leitor["Contatoadm"]);
        _telefoneadm = AlterarTipo<string?>(leitor["Telefoneadm"]);
        _diasemanaatend = AlterarTipo<int?>(leitor["Diasemanaatend"]);
        _periocidadeatend = AlterarTipo<int?>(leitor["Periocidadeatend"]);
        _dtproxatend = AlterarTipo<DateTime?>(leitor["Dtproxatend"]);
        _classevenda = AlterarTipo<string?>(leitor["Classevenda"]);
        _classemc = AlterarTipo<string?>(leitor["Classemc"]);
        _classeestoque = AlterarTipo<string?>(leitor["Classeestoque"]);
        _classecompra = AlterarTipo<string?>(leitor["Classecompra"]);
        _email = AlterarTipo<string?>(leitor["Email"]);
        _prazo1 = AlterarTipo<int?>(leitor["Prazo1"]);
        _prazo2 = AlterarTipo<int?>(leitor["Prazo2"]);
        _prazo3 = AlterarTipo<int?>(leitor["Prazo3"]);
        _prazo4 = AlterarTipo<int?>(leitor["Prazo4"]);
        _prazo5 = AlterarTipo<int?>(leitor["Prazo5"]);
        _prazo6 = AlterarTipo<int?>(leitor["Prazo6"]);
        _percdespfin = AlterarTipo<decimal?>(leitor["Percdespfin"]);
        _percdescfin = AlterarTipo<decimal?>(leitor["Percdescfin"]);
        _numbancodoc = AlterarTipo<int?>(leitor["Numbancodoc"]);
        _numagenciadoc = AlterarTipo<int?>(leitor["Numagenciadoc"]);
        _numccorrentedoc = AlterarTipo<string?>(leitor["Numccorrentedoc"]);
        _fantasia = AlterarTipo<string?>(leitor["Fantasia"]);
        _numdepirrf = AlterarTipo<int?>(leitor["Numdepirrf"]);
        _valordeducaoirrf = AlterarTipo<decimal?>(leitor["Valordeducaoirrf"]);
        _rg = AlterarTipo<string?>(leitor["Rg"]);
        _coddistrib = AlterarTipo<string?>(leitor["Coddistrib"]);
        _vlfretekg = AlterarTipo<decimal?>(leitor["Vlfretekg"]);
        _percoutroscustosfrete = AlterarTipo<decimal?>(leitor["Percoutroscustosfrete"]);
        _distrib = AlterarTipo<string?>(leitor["Distrib"]);
        _inscestrangeira = AlterarTipo<int?>(leitor["Inscestrangeira"]);
        _industrialocal = AlterarTipo<string?>(leitor["Industrialocal"]);
        _grupocampanha = AlterarTipo<int?>(leitor["Grupocampanha"]);
        _percmaxbonific = AlterarTipo<decimal?>(leitor["Percmaxbonific"]);
        _percpisred = AlterarTipo<decimal?>(leitor["Percpisred"]);
        _suframa = AlterarTipo<string?>(leitor["Suframa"]);
        _codprodutorrural = AlterarTipo<string?>(leitor["Codprodutorrural"]);
        _dvag = AlterarTipo<string?>(leitor["Dvag"]);
        _dvcc = AlterarTipo<string?>(leitor["Dvcc"]);
        _tipoembalagempedido = AlterarTipo<string?>(leitor["Tipoembalagempedido"]);
        _supervisorverba = AlterarTipo<string?>(leitor["Supervisorverba"]);
        _contatoverba = AlterarTipo<string?>(leitor["Contatoverba"]);
        _cpfcontatoverba = AlterarTipo<string?>(leitor["Cpfcontatoverba"]);
        _rgcontatoverba = AlterarTipo<string?>(leitor["Rgcontatoverba"]);
        _rep_dtaniversario = AlterarTipo<DateTime?>(leitor["Rep_dtaniversario"]);
        _adm_contato = AlterarTipo<string?>(leitor["Adm_contato"]);
        _adm_dtaniversario = AlterarTipo<DateTime?>(leitor["Adm_dtaniversario"]);
        _adm_endereco = AlterarTipo<string?>(leitor["Adm_endereco"]);
        _adm_bairro = AlterarTipo<string?>(leitor["Adm_bairro"]);
        _adm_cidade = AlterarTipo<string?>(leitor["Adm_cidade"]);
        _adm_uf = AlterarTipo<string?>(leitor["Adm_uf"]);
        _adm_cep = AlterarTipo<int?>(leitor["Adm_cep"]);
        _com_contato = AlterarTipo<string?>(leitor["Com_contato"]);
        _com_dtaniversario = AlterarTipo<DateTime?>(leitor["Com_dtaniversario"]);
        _com_endereco = AlterarTipo<string?>(leitor["Com_endereco"]);
        _com_bairro = AlterarTipo<string?>(leitor["Com_bairro"]);
        _com_cidade = AlterarTipo<string?>(leitor["Com_cidade"]);
        _com_uf = AlterarTipo<string?>(leitor["Com_uf"]);
        _com_cep = AlterarTipo<int?>(leitor["Com_cep"]);
        _transporteproprio = AlterarTipo<string?>(leitor["Transporteproprio"]);
        _vlpedagio = AlterarTipo<decimal?>(leitor["Vlpedagio"]);
        _pergris = AlterarTipo<decimal?>(leitor["Pergris"]);
        _icmssobretxminima = AlterarTipo<string?>(leitor["Icmssobretxminima"]);
        _gatilho = AlterarTipo<decimal?>(leitor["Gatilho"]);
        _tipocalcfrete = AlterarTipo<int?>(leitor["Tipocalcfrete"]);
        _taxa0 = AlterarTipo<decimal?>(leitor["Taxa0"]);
        _taxa7 = AlterarTipo<decimal?>(leitor["Taxa7"]);
        _taxa14 = AlterarTipo<decimal?>(leitor["Taxa14"]);
        _taxa21 = AlterarTipo<decimal?>(leitor["Taxa21"]);
        _taxa28 = AlterarTipo<decimal?>(leitor["Taxa28"]);
        _taxa35 = AlterarTipo<decimal?>(leitor["Taxa35"]);
        _taxa42 = AlterarTipo<decimal?>(leitor["Taxa42"]);
        _dtultcontatocob = AlterarTipo<DateTime?>(leitor["Dtultcontatocob"]);
        _codfuncultcontatocob = AlterarTipo<int?>(leitor["Codfuncultcontatocob"]);
        _dtproxcontatocob = AlterarTipo<DateTime?>(leitor["Dtproxcontatocob"]);
        _codmunicipio = AlterarTipo<int?>(leitor["Codmunicipio"]);
        _com_email = AlterarTipo<string?>(leitor["Com_email"]);
        _rep_email = AlterarTipo<string?>(leitor["Rep_email"]);
        _sup_email = AlterarTipo<string?>(leitor["Sup_email"]);
        _dtvalidade = AlterarTipo<DateTime?>(leitor["Dtvalidade"]);
        _tipofornec = AlterarTipo<string?>(leitor["Tipofornec"]);
        _utilizadesccalcipi = AlterarTipo<string?>(leitor["Utilizadesccalcipi"]);
        _utilizafretecalcipi = AlterarTipo<string?>(leitor["Utilizafretecalcipi"]);
        _vlminpedcompra = AlterarTipo<decimal?>(leitor["Vlminpedcompra"]);
        _sup_celular = AlterarTipo<string?>(leitor["Sup_celular"]);
        _com_celular = AlterarTipo<string?>(leitor["Com_celular"]);
        _deduzirsuframacalccredicm = AlterarTipo<string?>(leitor["Deduzirsuframacalccredicm"]);
        _deduzirsuframacalccredpis = AlterarTipo<string?>(leitor["Deduzirsuframacalccredpis"]);
        _utilizaoutrasdespcalcicms = AlterarTipo<string?>(leitor["Utilizaoutrasdespcalcicms"]);
        _calcsuframasobrepliquido = AlterarTipo<string?>(leitor["Calcsuframasobrepliquido"]);
        _deduzirsuframabcstaliq1 = AlterarTipo<string?>(leitor["Deduzirsuframabcstaliq1"]);
        _calcipicomdesc = AlterarTipo<string?>(leitor["Calcipicomdesc"]);
        _calcipicomfretenf = AlterarTipo<string?>(leitor["Calcipicomfretenf"]);
        _somafretefobnostforanf = AlterarTipo<string?>(leitor["Somafretefobnostforanf"]);
        _localizacao = AlterarTipo<string?>(leitor["Localizacao"]);
        _calculapiscofinscomipi = AlterarTipo<string?>(leitor["Calculapiscofinscomipi"]);
        _aceitaentregaancecip = AlterarTipo<string?>(leitor["Aceitaentregaancecip"]);
        _codcidade = AlterarTipo<int?>(leitor["Codcidade"]);
        _utilizafretecalcicms = AlterarTipo<string?>(leitor["Utilizafretecalcicms"]);
        _tipofreteciffob = AlterarTipo<string?>(leitor["Tipofreteciffob"]);
        _destacaselonf = AlterarTipo<string?>(leitor["Destacaselonf"]);
        _utilizapercbon = AlterarTipo<string?>(leitor["Utilizapercbon"]);
        _percbondin = AlterarTipo<decimal?>(leitor["Percbondin"]);
        _percbonmerc = AlterarTipo<decimal?>(leitor["Percbonmerc"]);
        _perccomissao = AlterarTipo<decimal?>(leitor["Perccomissao"]);
        _utilizaoutrasdespcalcipi = AlterarTipo<string?>(leitor["Utilizaoutrasdespcalcipi"]);
        _vllimitefretemin = AlterarTipo<decimal?>(leitor["Vllimitefretemin"]);
        _percfluvial = AlterarTipo<decimal?>(leitor["Percfluvial"]);
        _codcontalancfrete = AlterarTipo<int?>(leitor["Codcontalancfrete"]);
        _percbonoutras = AlterarTipo<decimal?>(leitor["Percbonoutras"]);
        _utilizadesccalcst = AlterarTipo<string?>(leitor["Utilizadesccalcst"]);
        _utilizadesccalcicms = AlterarTipo<string?>(leitor["Utilizadesccalcicms"]);
        _consipicalcbasest = AlterarTipo<string?>(leitor["Consipicalcbasest"]);
        _consipicalcbasecrepres = AlterarTipo<string?>(leitor["Consipicalcbasecrepres"]);
        _classe = AlterarTipo<string?>(leitor["Classe"]);
        _ereabastecimento = AlterarTipo<string?>(leitor["Ereabastecimento"]);
        _eredespacho = AlterarTipo<string?>(leitor["Eredespacho"]);
        _codparcela = AlterarTipo<int?>(leitor["Codparcela"]);
        _rep_obs = AlterarTipo<string?>(leitor["Rep_obs"]);
        _calcipicomfretefob = AlterarTipo<string?>(leitor["Calcipicomfretefob"]);
        _dtimportintegracao = AlterarTipo<DateTime?>(leitor["Dtimportintegracao"]);
        _dtultalter = AlterarTipo<DateTime?>(leitor["Dtultalter"]);
        _usapercaltercustoent = AlterarTipo<string?>(leitor["Usapercaltercustoent"]);
        _tipopessoa = AlterarTipo<string?>(leitor["Tipopessoa"]);
        _percirrf = AlterarTipo<decimal?>(leitor["Percirrf"]);
        _codcontairrf = AlterarTipo<int?>(leitor["Codcontairrf"]);
        _perciss = AlterarTipo<decimal?>(leitor["Perciss"]);
        _codcontaiss = AlterarTipo<int?>(leitor["Codcontaiss"]);
        _codcontacsrf = AlterarTipo<int?>(leitor["Codcontacsrf"]);
        _codcontainss = AlterarTipo<int?>(leitor["Codcontainss"]);
        _exigeredespacho = AlterarTipo<string?>(leitor["Exigeredespacho"]);
        _perfretevalor = AlterarTipo<decimal?>(leitor["Perfretevalor"]);
        _consolidardifprecoverba = AlterarTipo<string?>(leitor["Consolidardifprecoverba"]);
        _percimpprodutorural = AlterarTipo<decimal?>(leitor["Percimpprodutorural"]);
        _inscmunicip = AlterarTipo<string?>(leitor["Inscmunicip"]);
        _usapercicmsnaaliqextst = AlterarTipo<string?>(leitor["Usapercicmsnaaliqextst"]);
        _consfretefobcalcicmsantecip = AlterarTipo<string?>(leitor["Consfretefobcalcicmsantecip"]);
        _iest = AlterarTipo<string?>(leitor["Iest"]);
        _codfornecstguia = AlterarTipo<int?>(leitor["Codfornecstguia"]);
        _usanumnegociacao = AlterarTipo<string?>(leitor["Usanumnegociacao"]);
        _isentost = AlterarTipo<string?>(leitor["Isentost"]);
        _codusuariowinthor = AlterarTipo<int?>(leitor["Codusuariowinthor"]);
        _dtultaltersrvprc = AlterarTipo<DateTime?>(leitor["Dtultaltersrvprc"]);
        _calcstguiaaliqext = AlterarTipo<string?>(leitor["Calcstguiaaliqext"]);
        _codfornecfrete = AlterarTipo<int?>(leitor["Codfornecfrete"]);
        _calcularipipesoliq = AlterarTipo<string?>(leitor["Calcularipipesoliq"]);
        _simplesnacional = AlterarTipo<string?>(leitor["Simplesnacional"]);
        _complementoend = AlterarTipo<string?>(leitor["Complementoend"]);
        _numeroend = AlterarTipo<string?>(leitor["Numeroend"]);
        _codparcelastguia = AlterarTipo<int?>(leitor["Codparcelastguia"]);
        _cae = AlterarTipo<string?>(leitor["Cae"]);
        _geracreddifpreco = AlterarTipo<string?>(leitor["Geracreddifpreco"]);
        _utilizaoutdespcalcsuframa = AlterarTipo<string?>(leitor["Utilizaoutdespcalcsuframa"]);
        _consstnfpiscofins = AlterarTipo<string?>(leitor["Consstnfpiscofins"]);
        _codpais = AlterarTipo<int?>(leitor["Codpais"]);
        _classifictipofornec = AlterarTipo<string?>(leitor["Classifictipofornec"]);
        _transpautonomo = AlterarTipo<string?>(leitor["Transpautonomo"]);
        _rep_nextelid = AlterarTipo<string?>(leitor["Rep_nextelid"]);
        _percpisnfservico = AlterarTipo<decimal?>(leitor["Percpisnfservico"]);
        _perccofinsnfservico = AlterarTipo<decimal?>(leitor["Perccofinsnfservico"]);
        _codcontapis = AlterarTipo<int?>(leitor["Codcontapis"]);
        _codcontacofins = AlterarTipo<int?>(leitor["Codcontacofins"]);
        _fornecimportacao = AlterarTipo<int?>(leitor["Fornecimportacao"]);
        _pesomintransp = AlterarTipo<decimal?>(leitor["Pesomintransp"]);
        _taxaemissaoct = AlterarTipo<decimal?>(leitor["Taxaemissaoct"]);
        _inss = AlterarTipo<int?>(leitor["Inss"]);
        _cgcaux = AlterarTipo<string?>(leitor["Cgcaux"]);
        _codcontacontabadiantfor = AlterarTipo<int?>(leitor["Codcontacontabadiantfor"]);
        _calcdespfinprazopgto = AlterarTipo<string?>(leitor["Calcdespfinprazopgto"]);
        _usaoutrasdespseguropiscofins = AlterarTipo<string?>(leitor["Usaoutrasdespseguropiscofins"]);
        _numalvaraanvisa = AlterarTipo<string?>(leitor["Numalvaraanvisa"]);
        _dtvencalvaraanvisa = AlterarTipo<DateTime?>(leitor["Dtvencalvaraanvisa"]);
        _numalvarafunc = AlterarTipo<string?>(leitor["Numalvarafunc"]);
        _dtvencalvarafunc = AlterarTipo<DateTime?>(leitor["Dtvencalvarafunc"]);
        _numalvarapsico = AlterarTipo<string?>(leitor["Numalvarapsico"]);
        _dtvencalvarapsico = AlterarTipo<DateTime?>(leitor["Dtvencalvarapsico"]);
        _crf = AlterarTipo<string?>(leitor["Crf"]);
        _dtvenccrf = AlterarTipo<DateTime?>(leitor["Dtvenccrf"]);
        _perpis = AlterarTipo<decimal?>(leitor["Perpis"]);
        _percofins = AlterarTipo<decimal?>(leitor["Percofins"]);
        _codsittribpiscofinsconhec = AlterarTipo<int?>(leitor["Codsittribpiscofinsconhec"]);
        _usacredpiscofinsentbonific = AlterarTipo<string?>(leitor["Usacredpiscofinsentbonific"]);
        _contribuinteicms = AlterarTipo<string?>(leitor["Contribuinteicms"]);
        _recalctribent = AlterarTipo<string?>(leitor["Recalctribent"]);
        _consmaioricmsvlpauta = AlterarTipo<string?>(leitor["Consmaioricmsvlpauta"]);
        _bloqueiosefazfornec = AlterarTipo<string?>(leitor["Bloqueiosefazfornec"]);
        _dtbloqueiosefazfornec = AlterarTipo<DateTime?>(leitor["Dtbloqueiosefazfornec"]);
        _percinss = AlterarTipo<decimal?>(leitor["Percinss"]);
        _perccsrf = AlterarTipo<decimal?>(leitor["Perccsrf"]);
        _dedfretecifcredpresicms = AlterarTipo<string?>(leitor["Dedfretecifcredpresicms"]);
        _emitenfe = AlterarTipo<string?>(leitor["Emitenfe"]);
        _atualizastultent = AlterarTipo<string?>(leitor["Atualizastultent"]);
        _codcontab = AlterarTipo<string?>(leitor["Codcontab"]);
        _numcasasdecreducaoicms = AlterarTipo<int?>(leitor["Numcasasdecreducaoicms"]);
        _utilizaipicalcicms = AlterarTipo<string?>(leitor["Utilizaipicalcicms"]);
        _avaliacaovenda = AlterarTipo<string?>(leitor["Avaliacaovenda"]);
        _dtproxcompra = AlterarTipo<DateTime?>(leitor["Dtproxcompra"]);
        _dtultcompra = AlterarTipo<DateTime?>(leitor["Dtultcompra"]);
        _periodicidadecompra = AlterarTipo<int?>(leitor["Periodicidadecompra"]);
        _diasavaliacaovenda = AlterarTipo<int?>(leitor["Diasavaliacaovenda"]);
        _codgln = AlterarTipo<int?>(leitor["Codgln"]);
        _codsittribpiscofinsservico = AlterarTipo<int?>(leitor["Codsittribpiscofinsservico"]);
        _consstguiapiscofins = AlterarTipo<string?>(leitor["Consstguiapiscofins"]);
        _concedcredpres = AlterarTipo<string?>(leitor["Concedcredpres"]);
        _usafretefobporfornec = AlterarTipo<string?>(leitor["Usafretefobporfornec"]);
        _vlminpedreposicao = AlterarTipo<decimal?>(leitor["Vlminpedreposicao"]);
        _gerapedbonific = AlterarTipo<string?>(leitor["Gerapedbonific"]);
        _qtdiasvencverbas = AlterarTipo<int?>(leitor["Qtdiasvencverbas"]);
        _tipofinancdevfornec = AlterarTipo<int?>(leitor["Tipofinancdevfornec"]);
        _cfopentadjud = AlterarTipo<int?>(leitor["Cfopentadjud"]);
        _sittribentadjud = AlterarTipo<string?>(leitor["Sittribentadjud"]);
        _cfoprestituicao = AlterarTipo<int?>(leitor["Cfoprestituicao"]);
        _sittribrestituicao = AlterarTipo<string?>(leitor["Sittribrestituicao"]);
        _utilizaoutdespnfbasest = AlterarTipo<string?>(leitor["Utilizaoutdespnfbasest"]);
        _idintegracaomyfrota = AlterarTipo<byte[]?>(leitor["Idintegracaomyfrota"]);
        _consfretefobbasestnf = AlterarTipo<string?>(leitor["Consfretefobbasestnf"]);
        _codparcelafretefob = AlterarTipo<int?>(leitor["Codparcelafretefob"]);
        _codparcelaoutdesp = AlterarTipo<int?>(leitor["Codparcelaoutdesp"]);
        _codparcicmsantecip = AlterarTipo<int?>(leitor["Codparcicmsantecip"]);
        _codparceladifaliq = AlterarTipo<int?>(leitor["Codparceladifaliq"]);
        _codcontainsstomador = AlterarTipo<int?>(leitor["Codcontainsstomador"]);
        _percinsstomador = AlterarTipo<decimal?>(leitor["Percinsstomador"]);
        _ressarcimentostnf = AlterarTipo<string?>(leitor["Ressarcimentostnf"]);
        _ressarcimentostguia = AlterarTipo<string?>(leitor["Ressarcimentostguia"]);
        _adjudicacao = AlterarTipo<string?>(leitor["Adjudicacao"]);
        _cfopressarcimentostguia = AlterarTipo<int?>(leitor["Cfopressarcimentostguia"]);
        _sittributressarcimentostguia = AlterarTipo<string?>(leitor["Sittributressarcimentostguia"]);
        _usadrawback = AlterarTipo<string?>(leitor["Usadrawback"]);
        _utilizaicmsdifzerado = AlterarTipo<string?>(leitor["Utilizaicmsdifzerado"]);
        _calcpiscofinsbasered = AlterarTipo<string?>(leitor["Calcpiscofinsbasered"]);
        _percsestsenat = AlterarTipo<decimal?>(leitor["Percsestsenat"]);
        _codcontasestsenat = AlterarTipo<int?>(leitor["Codcontasestsenat"]);
        _equipindustria = AlterarTipo<string?>(leitor["Equipindustria"]);
        _codparcelafunrural = AlterarTipo<int?>(leitor["Codparcelafunrural"]);
        _conscapataziaicms = AlterarTipo<string?>(leitor["Conscapataziaicms"]);
        _consumidorfinal = AlterarTipo<string?>(leitor["Consumidorfinal"]);
        _deduzirsuframaaliqext = AlterarTipo<string?>(leitor["Deduzirsuframaaliqext"]);
        _consipicalcicmsant = AlterarTipo<string?>(leitor["Consipicalcicmsant"]);
        _emailnfe = AlterarTipo<string?>(leitor["Emailnfe"]);
        _creditarsaldoestverba = AlterarTipo<string?>(leitor["Creditarsaldoestverba"]);
        _transpcredenciadosefaz = AlterarTipo<string?>(leitor["Transpcredenciadosefaz"]);
        _numcredenciamentosefaz = AlterarTipo<string?>(leitor["Numcredenciamentosefaz"]);
        _usaecommerceunilever = AlterarTipo<string?>(leitor["Usaecommerceunilever"]);
        _horacoleta = AlterarTipo<int?>(leitor["Horacoleta"]);
        _usadebcredoperlog = AlterarTipo<string?>(leitor["Usadebcredoperlog"]);
        _diapgverbaoperlog = AlterarTipo<int?>(leitor["Diapgverbaoperlog"]);
        _creditadescmenoroperlog = AlterarTipo<string?>(leitor["Creditadescmenoroperlog"]);
        _codcobsefaz = AlterarTipo<string?>(leitor["Codcobsefaz"]);
        _contribuintedocprb = AlterarTipo<string?>(leitor["Contribuintedocprb"]);
        _urlbaserastreio = AlterarTipo<string?>(leitor["Urlbaserastreio"]);
        _deduzirsuframadifaliq = AlterarTipo<string?>(leitor["Deduzirsuframadifaliq"]);
        _codlicitgrupofornec = AlterarTipo<int?>(leitor["Codlicitgrupofornec"]);
        _formapgto = AlterarTipo<int?>(leitor["Formapgto"]);
        _associacaodesportiva = AlterarTipo<string?>(leitor["Associacaodesportiva"]);
        _codigonacionalobras = AlterarTipo<string?>(leitor["Codigonacionalobras"]);
        _considerarpautazerostguia = AlterarTipo<string?>(leitor["Considerarpautazerostguia"]);
        _calccredicmsbasereduzida = AlterarTipo<string?>(leitor["Calccredicmsbasereduzida"]);
        _codcentrocusto = AlterarTipo<string?>(leitor["Codcentrocusto"]);
        _percmargemgarantida = AlterarTipo<decimal?>(leitor["Percmargemgarantida"]);
        _detentorregespecial = AlterarTipo<string?>(leitor["Detentorregespecial"]);
        _deduzirfcpicmsdofcpst = AlterarTipo<string?>(leitor["Deduzirfcpicmsdofcpst"]);
        _idsofitview = AlterarTipo<string?>(leitor["Idsofitview"]);
        _dtultaltersofitview = AlterarTipo<DateTime?>(leitor["Dtultaltersofitview"]);
        _dtexclusaosofitview = AlterarTipo<DateTime?>(leitor["Dtexclusaosofitview"]);
        _gerarreceitarestituicao = AlterarTipo<string?>(leitor["Gerarreceitarestituicao"]);
        _condcomercautorizmed = AlterarTipo<string?>(leitor["Condcomercautorizmed"]);
        _manifestacaoautomatica = AlterarTipo<string?>(leitor["Manifestacaoautomatica"]);
        _gerapedidocompraxml = AlterarTipo<string?>(leitor["Gerapedidocompraxml"]);
        _usaredicmspara = AlterarTipo<string?>(leitor["Usaredicmspara"]);
        _consdesonnovesuframa = AlterarTipo<string?>(leitor["Consdesonnovesuframa"]);
        _gravarcodfab253 = AlterarTipo<string?>(leitor["Gravarcodfab253"]);
        _utilizafator253 = AlterarTipo<string?>(leitor["Utilizafator253"]);
        _importaxmlautomatico = AlterarTipo<string?>(leitor["Importaxmlautomatico"]);
        _deduziripibasedifaliq = AlterarTipo<string?>(leitor["Deduziripibasedifaliq"]);
        _consfretefobbasedifaliq = AlterarTipo<string?>(leitor["Consfretefobbasedifaliq"]);
        _alimentafundomultifilial = AlterarTipo<string?>(leitor["Alimentafundomultifilial"]);
        _origemparcfinanc = AlterarTipo<string?>(leitor["Origemparcfinanc"]);
        _aplicaverbarebcusto = AlterarTipo<string?>(leitor["Aplicaverbarebcusto"]);
        _tipofretedespacho = AlterarTipo<string?>(leitor["Tipofretedespacho"]);
        _tipovencimento = AlterarTipo<string?>(leitor["Tipovencimento"]);
        _aplicrebcustomultifilial = AlterarTipo<string?>(leitor["Aplicrebcustomultifilial"]);
        _formatribprodrural = AlterarTipo<string?>(leitor["Formatribprodrural"]);
        _indaqprodrural = AlterarTipo<string?>(leitor["Indaqprodrural"]);
        _produtorrural = AlterarTipo<string?>(leitor["Produtorrural"]);
        _cpfprodutorrural = AlterarTipo<string?>(leitor["Cpfprodutorrural"]);
        _perccontribprevdesc = AlterarTipo<decimal?>(leitor["Perccontribprevdesc"]);
        _perccontribbemconc = AlterarTipo<decimal?>(leitor["Perccontribbemconc"]);
        _perccontribsenar = AlterarTipo<decimal?>(leitor["Perccontribsenar"]);
        _codfornecbal = AlterarTipo<string?>(leitor["Codfornecbal"]);
        _utilizapiscofinstribent = AlterarTipo<string?>(leitor["Utilizapiscofinstribent"]);
        _utilizaicmstribent = AlterarTipo<string?>(leitor["Utilizaicmstribent"]);
    }
}