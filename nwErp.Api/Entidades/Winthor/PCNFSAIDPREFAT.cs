

////// namespace nwErp.Entidades.Winthor;

// namespace nwErp.Api.Modelos;

[Serializable]
public class PCNFSAIDPREFAT : GerenteDePropriedades, IEntidade
{
    private string _agenciapgtognre;

    private string _agregarstprodsintegra;

    private string _agregastvlmerc;

    private decimal? _aliqicmoutrasdesp;

    private decimal? _aliquota;

    private string _ambiente;

    private string _ambientecte;

    private string _ambientenfe;

    private string _apresentoucupompromocao;

    private string _assinatura;

    private string _atacadista;

    private string _autentpgtognre;

    private string _bairro;

    private string _bairrocoleta;

    private string _bancopgtognre;

    private decimal? _bcst;

    private decimal? _bcstgnre;

    private string _broker;

    private decimal _caixa;

    private string _cartaodotz;

    private string _cep;

    private string _cgc;

    private string _cgcfilial;

    private string _cgcfrete;

    private string _chavecte;

    private string _chavecteanulacao;

    private string _chavecteref;

    private string _chavectesubstituicao;

    private string _chavectetomadorsub;

    private string _chavenfe;

    private string _chavenfetomadorsub;

    private string _chavesat;

    private string _cliente;

    private string _clientefontest;

    private string _cnpjcisp;

    private string _cnpjcoleta;

    private string _cnpjcpfcteref;

    private string _cnpjcpfemitentesub;

    private string _cnpjfornec;

    private string _cnpjfornecpedagio;

    private string _cnpjresponsavel;

    private string _cnpjseguradora;

    private string _cobranca;

    private decimal? _codatv1;

    private string _codautenticacao;

    private decimal? _codbnf;

    private decimal? _codcidadecoleta;

    private decimal _codcli;

    private decimal? _codclifilial;

    private decimal? _codclinf;

    private decimal? _codclirecebedor;

    private string _codcob;

    private string _codcobsefaz;

    private decimal? _codcondicaovenda;

    private decimal? _codconsignatariofrete;

    private string _codcont;

    private decimal? _codcontcli;

    private decimal? _codcontrato;

    private decimal? _coddestinatariofrete;

    private decimal? _coddevol;

    private string _coddoc;

    private decimal? _codedital;

    private decimal? _codemitente;

    private decimal? _codemitentepedido;

    private decimal? _codepto;

    private decimal? _codexportador;

    private string _codfilial;

    private string _codfilialnf;

    private decimal _codfiscal;

    private decimal? _codfiscalfrete;

    private decimal? _codfiscalnf;

    private decimal? _codfiscaloutrasdesp;

    private decimal? _codfornec;

    private decimal? _codfornecbonific;

    private decimal? _codfornecfrete;

    private decimal? _codfornecfretecteref;

    private decimal? _codfornecredespacho;

    private decimal? _codfornectranspautonomo;

    private decimal? _codfunccancel;

    private decimal? _codfunclanc;

    private decimal? _codfunclibent;

    private decimal? _codfuncliberacaoentrega;

    private decimal? _codgerente;

    private decimal? _codibge;

    private decimal? _codmedicoprescrit;

    private decimal? _codmotorista;

    private decimal? _codmunfimcte;

    private decimal? _codmunicipio;

    private decimal? _codmuninicte;

    private decimal? _codpais;

    private decimal? _codplpag;

    private decimal? _codplpagetico;

    private decimal? _codplpaggenerico;

    private decimal _codpraca;

    private decimal? _codpracadestfrete;

    private string _codprodnfajuste;

    private decimal? _codprodpredominante;

    private decimal? _codpromocaomed;

    private decimal? _codrecebfretecteref;

    private decimal? _codremetentefrete;

    private decimal? _codretencaocprb;

    private decimal? _codsittribpiscofins;

    private decimal? _codstatussat;

    private decimal? _codsupervisor;

    private decimal? _codsupervisor2;

    private decimal? _codsupervisor3;

    private decimal? _codtranspautonomo;

    private string _codunidadeexecutora;

    private decimal _codusur;

    private decimal? _codusur2;

    private decimal? _codusur3;

    private decimal? _codusur4;

    private decimal? _codveiculo;

    private decimal? _codveiculo1;

    private decimal? _codveiculo2;

    private string _cofinsretido;

    private decimal? _comissao;

    private decimal? _comissao2;

    private decimal? _comissao3;

    private decimal? _comissao4;

    private decimal? _comissaomot;

    private decimal? _comissaosup;

    private string _complementocoleta;

    private string _condfinanc;

    private decimal? _condvenda;

    private string _conferido;

    private string _consumidorfinal;

    private string _consumiunumcte;

    private string _consumiunumnfe;

    private decimal? _contadorcupomfiscal;

    private string _contaordem;

    private string _contribuinte;

    private string _cpnjresponsavelpedagio;

    private string _csllretido;

    private decimal? _ctecodtomadorservico;

    private decimal? _ctecodtranspsubcontratado;

    private decimal? _ctecodtranspsubcontratante;

    private decimal? _ctecodveiculosubcontratante;

    private string _cteglobalizado;

    private string _cteregimeespecial;

    private string _ctesubcontratadochavecteref;

    private string _custobonificacao;

    private DateTime? _dataconsolidacaoprefat;

    private DateTime? _dataempenho;

    private DateTime? _datahoraemissaosat;

    private DateTime? _datahoraregistroepec;

    private string _deduzirdesonerorgaopub;

    private string _depositofechado;

    private string _descpais;

    private string _descricaoprodnfajuste;

    private string _despesasrateada;

    private string _devsimbolica;

    private string _digitoverificadornfse;

    private string _docemissao;

    private DateTime? _dtahoraentradacontigencia;

    private DateTime? _dta_horaenviosefaz;

    private DateTime? _dtcancel;

    private DateTime? _dtcancelwms;

    private DateTime? _dtcanhoto;

    private DateTime? _dtdenegada;

    private DateTime? _dtdevol;

    private DateTime? _dtemissaocteref;

    private DateTime? _dtemissaodeclaracao;

    private DateTime? _dtemissaodocsub;

    private DateTime? _dtemissaonffornec;

    private DateTime? _dtentrega;

    private DateTime? _dtexportacaoservint;

    private DateTime? _dtexportacaowms;

    private DateTime? _dtfat;

    private DateTime? _dtfecha;

    private DateTime? _dtfechaccrca;

    private DateTime? _dthoraautorizacaosefaz;

    private DateTime? _dthoracancelamentosefaz;

    private DateTime? _dthorachegada;

    private DateTime? _dthoracte;

    private DateTime? _dthoranfe;

    private DateTime? _dthorarecibodpec;

    private DateTime? _dthorasaida;

    private DateTime? _dtimportacaoservprinc;

    private DateTime? _dtimportacaowms;

    private DateTime? _dtlancto;

    private DateTime? _dtlibent;

    private DateTime? _dtliberacaoentrega;

    private DateTime? _dtmovimentocx;

    private DateTime? _dtnsu;

    private DateTime? _dtpagarrec;

    private DateTime? _dtpagcomissao;

    private DateTime? _dtpagcomissaoop;

    private DateTime? _dtpagcomissaoprof;

    private DateTime? _dtpagdotz;

    private DateTime? _dtpgtocampanha;

    private DateTime _dtsaida;

    private DateTime? _dtsaidanf;

    private DateTime? _dtvencarrec;

    private DateTime? _dtwms;

    private string _emaildest;

    private string _emailfrete;

    private string _emailfreteredespacho;

    private string _emissnumautomatico;

    private string _endereco;

    private string _entrega;

    private string _enviada;

    private string _enviadanfe;

    private string _enviadoemailcancelado;

    private string _equiplanc;

    private string _especie;

    private string _especievolume;

    private string _exportadoservint;

    private string _fil_montarkitautomaticamente;

    private string _finalidadenfe;

    private decimal? _formulario;

    private string _fornecentrega;

    private string _fretedespacho;

    private string _freteredespacho;

    private string _funclanc;

    private string _geracaorazaoauxiliar;

    private string _geracp;

    private string _geranfvenda;

    private string _gerarbcrnfe;

    private string _gerarcptranspaunotomo;

    private string _historico;

    private string _horaemissao;

    private decimal? _horaentrega;

    private string _horalanc;

    private decimal? _horasaida;

    private decimal? _icmsretido;

    private decimal? _icmsretidognre;

    private string _identificarclientenfce;

    private string _idlocaldestmerc;

    private string _idparceiro;

    private string _idtipopresenca;

    private string _ie;

    private string _iecteref;

    private string _ieent;

    private string _iefilial;

    private string _iefrete;

    private string _iesubsttribut;

    private string _importadoservprinc;

    private string _imprimiudactejuntodanfe;

    private decimal? _indicprestserv;

    private string _infglobalizado;

    private string _inssretido;

    private string _inutilizada;

    private string _irrretido;

    private string _justificativacontigencia;

    private decimal? _kmfinalentrega;

    private string _linknfse;

    private string _localdesembaraco;

    private string _logradourocoleta;

    private string _lotedpec;

    private string _marcarvolume;

    private string _md5listaarq;

    private string _md5paf;

    private string _mensagempiscofins;

    private decimal? _minutoentrega;

    private string _minutolanc;

    private decimal? _minutosaida;

    private string _modelodocsub;

    private string _motestornonfe;

    private string _motoristaveiculo;

    private string _municipio;

    private string _natopernfe;

    private string _ncmnfajuste;

    private string _nfatualwms;

    private string _nfdeventfutura;

    private decimal? _nffornec;

    private string _nomearquivodotz;

    private string _nomearquivodotzestorno;

    private string _nomeseguradora;

    private string _normaregespecial;

    private string _notadupliquesvc;

    private decimal? _nsu;

    private string _nsusociotorcedor;

    private decimal? _numcaixafiscal;

    private decimal? _numcar;

    private decimal? _numcaranterior;

    private decimal? _numcargaedi;

    private string _numchaveexp;

    private decimal? _numcirurgia;

    private string _numcoleta;

    private decimal? _numcomprovante;

    private decimal? _numcontrato;

    private string _numcontratocarreteiro;

    private decimal? _numcupom;

    private string _numdocarrec;

    private string _numdoccteref;

    private decimal? _numdrawback;

    private decimal? _numecf;

    private string _numempenho;

    private string _numendereco;

    private string _numeroapolice;

    private string _numeroaverbacao;

    private string _numerocoleta;

    private decimal? _numerodocsub;

    private decimal? _numerorps;

    private decimal? _numfechamentomovcx;

    private decimal? _numformulario;

    private string _numidf;

    private decimal? _numitens;

    private decimal? _numlanccp;

    private decimal? _numlista;

    private string _numlotecte;

    private string _numlotenfe;

    private decimal? _numnftransf;

    private decimal? _numnota;

    private decimal? _numnotamanif;

    private decimal? _numnotanfse;

    private decimal? _numnotaorigem;

    private decimal? _numnotavinculada;

    private decimal? _numop;

    private decimal? _numorca;

    private decimal? _numorcafilial;

    private decimal? _numos;

    private decimal? _numped;

    private string _numpedcli;

    private string _numpedvanxml;

    private decimal? _numprevenda;

    private decimal? _numregexp;

    private decimal? _numregiao;

    private decimal? _numregiaofrete;

    private decimal? _numremessa;

    private decimal? _numselonf;

    private decimal? _numseq;

    private decimal? _numseqentrega;

    private decimal? _numseqmontagem;

    private string _numserieequip;

    private string _numseriesat;

    private decimal? _numtab;

    private decimal? _numtranscteanul;

    private decimal? _numtransctesubs;

    private decimal? _numtransentdependente;

    private decimal? _numtransentdest;

    private decimal? _numtransentnfestornada;

    private decimal? _numtransentorigconsig;

    private decimal? _numtransentorigem;

    private decimal _numtransvenda;

    private decimal? _numtransvendaconhec;

    private decimal? _numtransvendadependente;

    private decimal? _numtransvendadestino;

    private decimal? _numtransvendaecf;

    private decimal? _numtransvendaorigem;

    private decimal? _numtransvendatv13;

    private string _numvalepedagio;

    private decimal? _numvias;

    private decimal? _numviasgnre;

    private decimal? _numviaspu;

    private decimal? _numvolume;

    private string _obs;

    private string _obsconhecfrete;

    private string _obsexp;

    private string _obsnfajuste;

    private string _obsnfcarreg;

    private string _obsnfe;

    private string _obspiscofins;

    private string _orgaopub;

    private string _orgaopubfederal;

    private string _orgaopubmunicipal;

    private string _origemfrete;

    private string _pagchequemoradia;

    private decimal? _perbaseredoutrasdesp;

    private decimal? _perccomprofissional;

    private decimal? _percentualstfrete;

    private decimal? _percfrete;

    private decimal? _percfreteretido;

    private decimal? _percicmfrete;

    private decimal? _percofins;

    private decimal? _percstfreteretido;

    private decimal? _perdescfin;

    private decimal? _perdescfintot;

    private decimal? _perpis;

    private string _pisretido;

    private string _placaveic;

    private decimal? _planosuppli;

    private decimal? _pontosdotz;

    private decimal? _prazo1;

    private decimal? _prazo10;

    private decimal? _prazo11;

    private decimal? _prazo12;

    private decimal? _prazo2;

    private decimal? _prazo3;

    private decimal? _prazo4;

    private decimal? _prazo5;

    private decimal? _prazo6;

    private decimal? _prazo7;

    private decimal? _prazo8;

    private decimal? _prazo9;

    private decimal? _prazoadicional;

    private decimal? _prazomedio;

    private string _prazoponderado;

    private string _protocolo;

    private string _protocolocancelamento;

    private string _protocolocancelamentocte;

    private string _protocolocte;

    private string _protocolonfe;

    private string _protocolonfeauto;

    private string _protocolonfecan;

    private string _protocolonfeepec;

    private string _protocolonfse;

    private string _qrcodenfce;

    private string _qrcodesat;

    private decimal? _qtdereproccte;

    private decimal? _qtdereprocnfe;

    private string _razaosocialcoleta;

    private string _razaosocialcteref;

    private string _recarga;

    private string _recibocte;

    private string _recibodpec;

    private string _recibonfe;

    private string _reservaritenstv7;

    private decimal? _respseguro;

    private string _rotinacad;

    private string _rotinacadcte;

    private string _rotinalanc;

    private string _selo;

    private string _serie;

    private string _seriedoccteref;

    private string _seriedocsub;

    private string _serieecf;

    private string _serieoriginal;

    private string _serierps;

    private string _simplesnacional;

    private string _sitdoc;

    private decimal? _situacaocte;

    private decimal? _situacaonfe;

    private decimal? _situacaonfeepec;

    private decimal? _situacaonfeorig;

    private decimal? _situacaonfse;

    private string _situacaosat;

    private decimal? _stribut;

    private string _subserie;

    private string _subseriedoccteref;

    private string _subseriedocsub;

    private string _sulframa;

    private decimal? _taxaentrega;

    private string _telefone;

    private decimal? _tentativaenviocte;

    private decimal? _tentativaenvionfe;

    private string _tipoaliqoutrasdesp;

    private string _tipocontacorrente;

    private string _tipodevol;

    private string _tipodocarrecgnre;

    private string _tipodoccteref;

    private string _tipodocumentosub;

    private string _tipoemissao;

    private string _tipoemissaocte;

    private string _tipoempresa;

    private string _tipofj;

    private string _tipofrete;

    private decimal? _tipoinscprestserv;

    private decimal? _tipomovgarantia;

    private string _tipopresencaadquirinte;

    private string _tiporemessa;

    private string _tiposervicocte;

    private string _tiposubcontratacaocte;

    private string _tipotransfentredeposito;

    private string _tipovenda;

    private decimal? _tomadorcte;

    private decimal? _totdifaliquotas;

    private decimal? _totpeso;

    private decimal? _totpesoagrupado;

    private decimal? _totpesobruto;

    private decimal? _totpesoliq;

    private decimal? _totpesoliqagrupado;

    private decimal? _totvlbonific;

    private decimal? _totvldesccom;

    private decimal? _totvldescfin;

    private decimal? _totvldescflex;

    private decimal? _totvlredcomiss;

    private decimal? _totvlredcomisssup;

    private decimal? _totvolume;

    private decimal? _totvolumeagrupado;

    private string _transfdep;

    private string _transpautonomo;

    private string _transportadora;

    private string _uf;

    private string _ufbeneficiaria;

    private string _ufcodigo;

    private string _ufcteref;

    private string _ufdesembaraco;

    private string _uffilial;

    private string _uffrete;

    private string _ufplacavei;

    private string _ufplacaveic;

    private decimal? _uidregistro;

    private string _unidadenfajuste;

    private string _usaintegracaowms;

    private string _usamultuniditem;

    private string _utilizaexpdiversos;

    private string _utilizaipicalcicms;

    private decimal? _valordocsub;

    private decimal? _valorpedagio;

    private decimal? _valorst;

    private string _vendaassistida;

    private string _vendaexportacao;

    private string _vendanfseried;

    private string _vendatriangular;

    private string _versaorotina;

    private decimal? _vlbase;

    private decimal? _vlbaseipi;

    private decimal? _vlbasepiscofins;

    private decimal? _vlbaseretencao;

    private decimal? _vlbasestfrete;

    private decimal? _vlboleto;

    private decimal? _vlbonific;

    private decimal? _vlbonificacerto;

    private decimal? _vlcofins;

    private decimal? _vlcsll;

    private decimal? _vlcustocont;

    private decimal? _vlcustofin;

    private decimal? _vlcustoreal;

    private decimal? _vlcustorep;

    private decimal? _vldescabatimento;

    private decimal? _vldescfin;

    private decimal? _vldescicms;

    private decimal? _vldesconto;

    private decimal? _vldescprom;

    private decimal? _vldescsociotorcedor;

    private decimal? _vldespacho;

    private decimal? _vldespdentronf;

    private decimal? _vldesppedagio;

    private decimal? _vldevolucao;

    private decimal? _vldocarrecadacao;

    private decimal? _vlfrete;

    private decimal? _vlfretenf;

    private decimal? _vlfreteoutrasdesp;

    private decimal? _vlfreteretido;

    private decimal? _vlgris;

    private decimal? _vlicms;

    private decimal? _vlicmsantecipado;

    private decimal? _vlicmsstfrete;

    private decimal? _vlinss;

    private decimal? _vlipi;

    private decimal? _vlipioutras;

    private decimal? _vlir;

    private decimal? _vlisentas;

    private decimal? _vliss;

    private decimal? _vlltr;

    private decimal? _vloperacaofrete;

    private decimal? _vloutras;

    private decimal? _vloutrasdesp;

    private decimal? _vlpautafrete;

    private decimal? _vlpedagio;

    private decimal? _vlpis;

    private decimal? _vlpunitmed;

    private decimal? _vlraverbacao;

    private decimal? _vlrecebidoboleto;

    private decimal? _vlrecebidocartao;

    private decimal? _vlrecebidoch;

    private decimal? _vlrecebidodin;

    private decimal? _vlseccat;

    private decimal? _vlseguro;

    private decimal? _vlstfreteretido;

    private decimal? _vlsubtotal;

    private decimal? _vltabela;

    private decimal? _vltas;

    private decimal? _vltotal;

    private decimal? _vltotalfcpicms;

    private decimal? _vltotalfcpst;

    private decimal? _vltotalnf;

    private decimal? _vltotalnfcompoemcte;

    private decimal? _vltotalsemdescicms;

    private decimal? _vltotbrutoprodajuste;

    private decimal? _vltotger;

    private decimal? _vltranspautonomo;

    private decimal? _vltributos;

    private decimal? _vltroco;

    private decimal? _vlverbacmvcli;

    private decimal? _wmscodfuncignora;

    private string _wmsignorado;

    private string _indicadordesconto;

    private string _indicadoracrescimo;

    private string _descintermediador;

    private string _cnpjintermediador;

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 30, Precisao = 0)]
    public string Agenciapgtognre
    {
        get
        {
            PropriedadeAcessada("Agenciapgtognre");
            return _agenciapgtognre;
        }
        set
        {
            PropriedadeModificada("Agenciapgtognre", value);
            _agenciapgtognre = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Agregarstprodsintegra
    {
        get
        {
            PropriedadeAcessada("Agregarstprodsintegra");
            return _agregarstprodsintegra;
        }
        set
        {
            PropriedadeModificada("Agregarstprodsintegra", value);
            _agregarstprodsintegra = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Agregastvlmerc
    {
        get
        {
            PropriedadeAcessada("Agregastvlmerc");
            return _agregastvlmerc;
        }
        set
        {
            PropriedadeModificada("Agregastvlmerc", value);
            _agregastvlmerc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 2)]
    public decimal? Aliqicmoutrasdesp
    {
        get
        {
            PropriedadeAcessada("Aliqicmoutrasdesp");
            return _aliqicmoutrasdesp;
        }
        set
        {
            PropriedadeModificada("Aliqicmoutrasdesp", value);
            _aliqicmoutrasdesp = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 7, Precisao = 2)]
    public decimal? Aliquota
    {
        get
        {
            PropriedadeAcessada("Aliquota");
            return _aliquota;
        }
        set
        {
            PropriedadeModificada("Aliquota", value);
            _aliquota = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Ambiente
    {
        get
        {
            PropriedadeAcessada("Ambiente");
            return _ambiente;
        }
        set
        {
            PropriedadeModificada("Ambiente", value);
            _ambiente = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Ambientecte
    {
        get
        {
            PropriedadeAcessada("Ambientecte");
            return _ambientecte;
        }
        set
        {
            PropriedadeModificada("Ambientecte", value);
            _ambientecte = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Ambientenfe
    {
        get
        {
            PropriedadeAcessada("Ambientenfe");
            return _ambientenfe;
        }
        set
        {
            PropriedadeModificada("Ambientenfe", value);
            _ambientenfe = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Apresentoucupompromocao
    {
        get
        {
            PropriedadeAcessada("Apresentoucupompromocao");
            return _apresentoucupompromocao;
        }
        set
        {
            PropriedadeModificada("Apresentoucupompromocao", value);
            _apresentoucupompromocao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 100, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Atacadista
    {
        get
        {
            PropriedadeAcessada("Atacadista");
            return _atacadista;
        }
        set
        {
            PropriedadeModificada("Atacadista", value);
            _atacadista = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 200, Precisao = 0)]
    public string Autentpgtognre
    {
        get
        {
            PropriedadeAcessada("Autentpgtognre");
            return _autentpgtognre;
        }
        set
        {
            PropriedadeModificada("Autentpgtognre", value);
            _autentpgtognre = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
    public string Bairro
    {
        get
        {
            PropriedadeAcessada("Bairro");
            return _bairro;
        }
        set
        {
            PropriedadeModificada("Bairro", value);
            _bairro = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 60, Precisao = 0)]
    public string Bairrocoleta
    {
        get
        {
            PropriedadeAcessada("Bairrocoleta");
            return _bairrocoleta;
        }
        set
        {
            PropriedadeModificada("Bairrocoleta", value);
            _bairrocoleta = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 50, Precisao = 0)]
    public string Bancopgtognre
    {
        get
        {
            PropriedadeAcessada("Bancopgtognre");
            return _bancopgtognre;
        }
        set
        {
            PropriedadeModificada("Bancopgtognre", value);
            _bancopgtognre = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 2)]
    public decimal? Bcst
    {
        get
        {
            PropriedadeAcessada("Bcst");
            return _bcst;
        }
        set
        {
            PropriedadeModificada("Bcst", value);
            _bcst = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 2)]
    public decimal? Bcstgnre
    {
        get
        {
            PropriedadeAcessada("Bcstgnre");
            return _bcstgnre;
        }
        set
        {
            PropriedadeModificada("Bcstgnre", value);
            _bcstgnre = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Broker
    {
        get
        {
            PropriedadeAcessada("Broker");
            return _broker;
        }
        set
        {
            PropriedadeModificada("Broker", value);
            _broker = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal Caixa
    {
        get
        {
            PropriedadeAcessada("Caixa");
            return _caixa;
        }
        set
        {
            PropriedadeModificada("Caixa", value);
            _caixa = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 18, Precisao = 0)]
    public string Cartaodotz
    {
        get
        {
            PropriedadeAcessada("Cartaodotz");
            return _cartaodotz;
        }
        set
        {
            PropriedadeModificada("Cartaodotz", value);
            _cartaodotz = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 10, Precisao = 0)]
    public string Cep
    {
        get
        {
            PropriedadeAcessada("Cep");
            return _cep;
        }
        set
        {
            PropriedadeModificada("Cep", value);
            _cep = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 18, Precisao = 0)]
    public string Cgc
    {
        get
        {
            PropriedadeAcessada("Cgc");
            return _cgc;
        }
        set
        {
            PropriedadeModificada("Cgc", value);
            _cgc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 14, Precisao = 0)]
    public string Cgcfilial
    {
        get
        {
            PropriedadeAcessada("Cgcfilial");
            return _cgcfilial;
        }
        set
        {
            PropriedadeModificada("Cgcfilial", value);
            _cgcfilial = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 18, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 44, Precisao = 0)]
    public string Chavecte
    {
        get
        {
            PropriedadeAcessada("Chavecte");
            return _chavecte;
        }
        set
        {
            PropriedadeModificada("Chavecte", value);
            _chavecte = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 45, Precisao = 0)]
    public string Chavecteanulacao
    {
        get
        {
            PropriedadeAcessada("Chavecteanulacao");
            return _chavecteanulacao;
        }
        set
        {
            PropriedadeModificada("Chavecteanulacao", value);
            _chavecteanulacao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 45, Precisao = 0)]
    public string Chavecteref
    {
        get
        {
            PropriedadeAcessada("Chavecteref");
            return _chavecteref;
        }
        set
        {
            PropriedadeModificada("Chavecteref", value);
            _chavecteref = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 45, Precisao = 0)]
    public string Chavectesubstituicao
    {
        get
        {
            PropriedadeAcessada("Chavectesubstituicao");
            return _chavectesubstituicao;
        }
        set
        {
            PropriedadeModificada("Chavectesubstituicao", value);
            _chavectesubstituicao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 45, Precisao = 0)]
    public string Chavectetomadorsub
    {
        get
        {
            PropriedadeAcessada("Chavectetomadorsub");
            return _chavectetomadorsub;
        }
        set
        {
            PropriedadeModificada("Chavectetomadorsub", value);
            _chavectetomadorsub = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 45, Precisao = 0)]
    public string Chavenfe
    {
        get
        {
            PropriedadeAcessada("Chavenfe");
            return _chavenfe;
        }
        set
        {
            PropriedadeModificada("Chavenfe", value);
            _chavenfe = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 45, Precisao = 0)]
    public string Chavenfetomadorsub
    {
        get
        {
            PropriedadeAcessada("Chavenfetomadorsub");
            return _chavenfetomadorsub;
        }
        set
        {
            PropriedadeModificada("Chavenfetomadorsub", value);
            _chavenfetomadorsub = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 400, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 60, Precisao = 0)]
    public string Cliente
    {
        get
        {
            PropriedadeAcessada("Cliente");
            return _cliente;
        }
        set
        {
            PropriedadeModificada("Cliente", value);
            _cliente = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Clientefontest
    {
        get
        {
            PropriedadeAcessada("Clientefontest");
            return _clientefontest;
        }
        set
        {
            PropriedadeModificada("Clientefontest", value);
            _clientefontest = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 8, Precisao = 0)]
    public string Cnpjcisp
    {
        get
        {
            PropriedadeAcessada("Cnpjcisp");
            return _cnpjcisp;
        }
        set
        {
            PropriedadeModificada("Cnpjcisp", value);
            _cnpjcisp = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 18, Precisao = 0)]
    public string Cnpjcoleta
    {
        get
        {
            PropriedadeAcessada("Cnpjcoleta");
            return _cnpjcoleta;
        }
        set
        {
            PropriedadeModificada("Cnpjcoleta", value);
            _cnpjcoleta = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 18, Precisao = 0)]
    public string Cnpjcpfcteref
    {
        get
        {
            PropriedadeAcessada("Cnpjcpfcteref");
            return _cnpjcpfcteref;
        }
        set
        {
            PropriedadeModificada("Cnpjcpfcteref", value);
            _cnpjcpfcteref = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 14, Precisao = 0)]
    public string Cnpjcpfemitentesub
    {
        get
        {
            PropriedadeAcessada("Cnpjcpfemitentesub");
            return _cnpjcpfemitentesub;
        }
        set
        {
            PropriedadeModificada("Cnpjcpfemitentesub", value);
            _cnpjcpfemitentesub = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 18, Precisao = 0)]
    public string Cnpjfornec
    {
        get
        {
            PropriedadeAcessada("Cnpjfornec");
            return _cnpjfornec;
        }
        set
        {
            PropriedadeModificada("Cnpjfornec", value);
            _cnpjfornec = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 18, Precisao = 0)]
    public string Cnpjfornecpedagio
    {
        get
        {
            PropriedadeAcessada("Cnpjfornecpedagio");
            return _cnpjfornecpedagio;
        }
        set
        {
            PropriedadeModificada("Cnpjfornecpedagio", value);
            _cnpjfornecpedagio = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 18, Precisao = 0)]
    public string Cnpjresponsavel
    {
        get
        {
            PropriedadeAcessada("Cnpjresponsavel");
            return _cnpjresponsavel;
        }
        set
        {
            PropriedadeModificada("Cnpjresponsavel", value);
            _cnpjresponsavel = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 14, Precisao = 0)]
    public string Cnpjseguradora
    {
        get
        {
            PropriedadeAcessada("Cnpjseguradora");
            return _cnpjseguradora;
        }
        set
        {
            PropriedadeModificada("Cnpjseguradora", value);
            _cnpjseguradora = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 30, Precisao = 0)]
    public string Cobranca
    {
        get
        {
            PropriedadeAcessada("Cobranca");
            return _cobranca;
        }
        set
        {
            PropriedadeModificada("Cobranca", value);
            _cobranca = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codatv1
    {
        get
        {
            PropriedadeAcessada("Codatv1");
            return _codatv1;
        }
        set
        {
            PropriedadeModificada("Codatv1", value);
            _codatv1 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 255, Precisao = 0)]
    public string Codautenticacao
    {
        get
        {
            PropriedadeAcessada("Codautenticacao");
            return _codautenticacao;
        }
        set
        {
            PropriedadeModificada("Codautenticacao", value);
            _codautenticacao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Codbnf
    {
        get
        {
            PropriedadeAcessada("Codbnf");
            return _codbnf;
        }
        set
        {
            PropriedadeModificada("Codbnf", value);
            _codbnf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codcidadecoleta
    {
        get
        {
            PropriedadeAcessada("Codcidadecoleta");
            return _codcidadecoleta;
        }
        set
        {
            PropriedadeModificada("Codcidadecoleta", value);
            _codcidadecoleta = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal Codcli
    {
        get
        {
            PropriedadeAcessada("Codcli");
            return _codcli;
        }
        set
        {
            PropriedadeModificada("Codcli", value);
            _codcli = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codclifilial
    {
        get
        {
            PropriedadeAcessada("Codclifilial");
            return _codclifilial;
        }
        set
        {
            PropriedadeModificada("Codclifilial", value);
            _codclifilial = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codclinf
    {
        get
        {
            PropriedadeAcessada("Codclinf");
            return _codclinf;
        }
        set
        {
            PropriedadeModificada("Codclinf", value);
            _codclinf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codclirecebedor
    {
        get
        {
            PropriedadeAcessada("Codclirecebedor");
            return _codclirecebedor;
        }
        set
        {
            PropriedadeModificada("Codclirecebedor", value);
            _codclirecebedor = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 4, Precisao = 0)]
    public string Codcob
    {
        get
        {
            PropriedadeAcessada("Codcob");
            return _codcob;
        }
        set
        {
            PropriedadeModificada("Codcob", value);
            _codcob = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 4, Precisao = 0)]
    public string Codcobsefaz
    {
        get
        {
            PropriedadeAcessada("Codcobsefaz");
            return _codcobsefaz;
        }
        set
        {
            PropriedadeModificada("Codcobsefaz", value);
            _codcobsefaz = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codcondicaovenda
    {
        get
        {
            PropriedadeAcessada("Codcondicaovenda");
            return _codcondicaovenda;
        }
        set
        {
            PropriedadeModificada("Codcondicaovenda", value);
            _codcondicaovenda = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codconsignatariofrete
    {
        get
        {
            PropriedadeAcessada("Codconsignatariofrete");
            return _codconsignatariofrete;
        }
        set
        {
            PropriedadeModificada("Codconsignatariofrete", value);
            _codconsignatariofrete = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 8, Precisao = 0)]
    public string Codcont
    {
        get
        {
            PropriedadeAcessada("Codcont");
            return _codcont;
        }
        set
        {
            PropriedadeModificada("Codcont", value);
            _codcont = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Codcontcli
    {
        get
        {
            PropriedadeAcessada("Codcontcli");
            return _codcontcli;
        }
        set
        {
            PropriedadeModificada("Codcontcli", value);
            _codcontcli = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codcontrato
    {
        get
        {
            PropriedadeAcessada("Codcontrato");
            return _codcontrato;
        }
        set
        {
            PropriedadeModificada("Codcontrato", value);
            _codcontrato = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Coddestinatariofrete
    {
        get
        {
            PropriedadeAcessada("Coddestinatariofrete");
            return _coddestinatariofrete;
        }
        set
        {
            PropriedadeModificada("Coddestinatariofrete", value);
            _coddestinatariofrete = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Coddevol
    {
        get
        {
            PropriedadeAcessada("Coddevol");
            return _coddevol;
        }
        set
        {
            PropriedadeModificada("Coddevol", value);
            _coddevol = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 4, Precisao = 0)]
    public string Coddoc
    {
        get
        {
            PropriedadeAcessada("Coddoc");
            return _coddoc;
        }
        set
        {
            PropriedadeModificada("Coddoc", value);
            _coddoc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 9, Precisao = 0)]
    public decimal? Codedital
    {
        get
        {
            PropriedadeAcessada("Codedital");
            return _codedital;
        }
        set
        {
            PropriedadeModificada("Codedital", value);
            _codedital = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codemitente
    {
        get
        {
            PropriedadeAcessada("Codemitente");
            return _codemitente;
        }
        set
        {
            PropriedadeModificada("Codemitente", value);
            _codemitente = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codemitentepedido
    {
        get
        {
            PropriedadeAcessada("Codemitentepedido");
            return _codemitentepedido;
        }
        set
        {
            PropriedadeModificada("Codemitentepedido", value);
            _codemitentepedido = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codepto
    {
        get
        {
            PropriedadeAcessada("Codepto");
            return _codepto;
        }
        set
        {
            PropriedadeModificada("Codepto", value);
            _codepto = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codexportador
    {
        get
        {
            PropriedadeAcessada("Codexportador");
            return _codexportador;
        }
        set
        {
            PropriedadeModificada("Codexportador", value);
            _codexportador = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Codfilial
    {
        get
        {
            PropriedadeAcessada("Codfilial");
            return _codfilial;
        }
        set
        {
            PropriedadeModificada("Codfilial", value);
            _codfilial = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Codfilialnf
    {
        get
        {
            PropriedadeAcessada("Codfilialnf");
            return _codfilialnf;
        }
        set
        {
            PropriedadeModificada("Codfilialnf", value);
            _codfilialnf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal Codfiscal
    {
        get
        {
            PropriedadeAcessada("Codfiscal");
            return _codfiscal;
        }
        set
        {
            PropriedadeModificada("Codfiscal", value);
            _codfiscal = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Codfiscalfrete
    {
        get
        {
            PropriedadeAcessada("Codfiscalfrete");
            return _codfiscalfrete;
        }
        set
        {
            PropriedadeModificada("Codfiscalfrete", value);
            _codfiscalfrete = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfiscalnf
    {
        get
        {
            PropriedadeAcessada("Codfiscalnf");
            return _codfiscalnf;
        }
        set
        {
            PropriedadeModificada("Codfiscalnf", value);
            _codfiscalnf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Codfiscaloutrasdesp
    {
        get
        {
            PropriedadeAcessada("Codfiscaloutrasdesp");
            return _codfiscaloutrasdesp;
        }
        set
        {
            PropriedadeModificada("Codfiscaloutrasdesp", value);
            _codfiscaloutrasdesp = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codfornec
    {
        get
        {
            PropriedadeAcessada("Codfornec");
            return _codfornec;
        }
        set
        {
            PropriedadeModificada("Codfornec", value);
            _codfornec = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codfornecbonific
    {
        get
        {
            PropriedadeAcessada("Codfornecbonific");
            return _codfornecbonific;
        }
        set
        {
            PropriedadeModificada("Codfornecbonific", value);
            _codfornecbonific = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codfornecfrete
    {
        get
        {
            PropriedadeAcessada("Codfornecfrete");
            return _codfornecfrete;
        }
        set
        {
            PropriedadeModificada("Codfornecfrete", value);
            _codfornecfrete = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codfornecfretecteref
    {
        get
        {
            PropriedadeAcessada("Codfornecfretecteref");
            return _codfornecfretecteref;
        }
        set
        {
            PropriedadeModificada("Codfornecfretecteref", value);
            _codfornecfretecteref = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codfornecredespacho
    {
        get
        {
            PropriedadeAcessada("Codfornecredespacho");
            return _codfornecredespacho;
        }
        set
        {
            PropriedadeModificada("Codfornecredespacho", value);
            _codfornecredespacho = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Codfornectranspautonomo
    {
        get
        {
            PropriedadeAcessada("Codfornectranspautonomo");
            return _codfornectranspautonomo;
        }
        set
        {
            PropriedadeModificada("Codfornectranspautonomo", value);
            _codfornectranspautonomo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfunccancel
    {
        get
        {
            PropriedadeAcessada("Codfunccancel");
            return _codfunccancel;
        }
        set
        {
            PropriedadeModificada("Codfunccancel", value);
            _codfunccancel = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfunclanc
    {
        get
        {
            PropriedadeAcessada("Codfunclanc");
            return _codfunclanc;
        }
        set
        {
            PropriedadeModificada("Codfunclanc", value);
            _codfunclanc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfunclibent
    {
        get
        {
            PropriedadeAcessada("Codfunclibent");
            return _codfunclibent;
        }
        set
        {
            PropriedadeModificada("Codfunclibent", value);
            _codfunclibent = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfuncliberacaoentrega
    {
        get
        {
            PropriedadeAcessada("Codfuncliberacaoentrega");
            return _codfuncliberacaoentrega;
        }
        set
        {
            PropriedadeModificada("Codfuncliberacaoentrega", value);
            _codfuncliberacaoentrega = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Codgerente
    {
        get
        {
            PropriedadeAcessada("Codgerente");
            return _codgerente;
        }
        set
        {
            PropriedadeModificada("Codgerente", value);
            _codgerente = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Codibge
    {
        get
        {
            PropriedadeAcessada("Codibge");
            return _codibge;
        }
        set
        {
            PropriedadeModificada("Codibge", value);
            _codibge = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codmedicoprescrit
    {
        get
        {
            PropriedadeAcessada("Codmedicoprescrit");
            return _codmedicoprescrit;
        }
        set
        {
            PropriedadeModificada("Codmedicoprescrit", value);
            _codmedicoprescrit = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codmotorista
    {
        get
        {
            PropriedadeAcessada("Codmotorista");
            return _codmotorista;
        }
        set
        {
            PropriedadeModificada("Codmotorista", value);
            _codmotorista = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 7, Precisao = 0)]
    public decimal? Codmunfimcte
    {
        get
        {
            PropriedadeAcessada("Codmunfimcte");
            return _codmunfimcte;
        }
        set
        {
            PropriedadeModificada("Codmunfimcte", value);
            _codmunfimcte = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Codmunicipio
    {
        get
        {
            PropriedadeAcessada("Codmunicipio");
            return _codmunicipio;
        }
        set
        {
            PropriedadeModificada("Codmunicipio", value);
            _codmunicipio = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 7, Precisao = 0)]
    public decimal? Codmuninicte
    {
        get
        {
            PropriedadeAcessada("Codmuninicte");
            return _codmuninicte;
        }
        set
        {
            PropriedadeModificada("Codmuninicte", value);
            _codmuninicte = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codpais
    {
        get
        {
            PropriedadeAcessada("Codpais");
            return _codpais;
        }
        set
        {
            PropriedadeModificada("Codpais", value);
            _codpais = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Codplpag
    {
        get
        {
            PropriedadeAcessada("Codplpag");
            return _codplpag;
        }
        set
        {
            PropriedadeModificada("Codplpag", value);
            _codplpag = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Codplpagetico
    {
        get
        {
            PropriedadeAcessada("Codplpagetico");
            return _codplpagetico;
        }
        set
        {
            PropriedadeModificada("Codplpagetico", value);
            _codplpagetico = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Codplpaggenerico
    {
        get
        {
            PropriedadeAcessada("Codplpaggenerico");
            return _codplpaggenerico;
        }
        set
        {
            PropriedadeModificada("Codplpaggenerico", value);
            _codplpaggenerico = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal Codpraca
    {
        get
        {
            PropriedadeAcessada("Codpraca");
            return _codpraca;
        }
        set
        {
            PropriedadeModificada("Codpraca", value);
            _codpraca = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codpracadestfrete
    {
        get
        {
            PropriedadeAcessada("Codpracadestfrete");
            return _codpracadestfrete;
        }
        set
        {
            PropriedadeModificada("Codpracadestfrete", value);
            _codpracadestfrete = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 60, Precisao = 0)]
    public string Codprodnfajuste
    {
        get
        {
            PropriedadeAcessada("Codprodnfajuste");
            return _codprodnfajuste;
        }
        set
        {
            PropriedadeModificada("Codprodnfajuste", value);
            _codprodnfajuste = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codprodpredominante
    {
        get
        {
            PropriedadeAcessada("Codprodpredominante");
            return _codprodpredominante;
        }
        set
        {
            PropriedadeModificada("Codprodpredominante", value);
            _codprodpredominante = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 9, Precisao = 0)]
    public decimal? Codpromocaomed
    {
        get
        {
            PropriedadeAcessada("Codpromocaomed");
            return _codpromocaomed;
        }
        set
        {
            PropriedadeModificada("Codpromocaomed", value);
            _codpromocaomed = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codrecebfretecteref
    {
        get
        {
            PropriedadeAcessada("Codrecebfretecteref");
            return _codrecebfretecteref;
        }
        set
        {
            PropriedadeModificada("Codrecebfretecteref", value);
            _codrecebfretecteref = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codremetentefrete
    {
        get
        {
            PropriedadeAcessada("Codremetentefrete");
            return _codremetentefrete;
        }
        set
        {
            PropriedadeModificada("Codremetentefrete", value);
            _codremetentefrete = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 1, Precisao = 0)]
    public decimal? Codretencaocprb
    {
        get
        {
            PropriedadeAcessada("Codretencaocprb");
            return _codretencaocprb;
        }
        set
        {
            PropriedadeModificada("Codretencaocprb", value);
            _codretencaocprb = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 3, Precisao = 0)]
    public decimal? Codsittribpiscofins
    {
        get
        {
            PropriedadeAcessada("Codsittribpiscofins");
            return _codsittribpiscofins;
        }
        set
        {
            PropriedadeModificada("Codsittribpiscofins", value);
            _codsittribpiscofins = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Codsupervisor
    {
        get
        {
            PropriedadeAcessada("Codsupervisor");
            return _codsupervisor;
        }
        set
        {
            PropriedadeModificada("Codsupervisor", value);
            _codsupervisor = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Codsupervisor2
    {
        get
        {
            PropriedadeAcessada("Codsupervisor2");
            return _codsupervisor2;
        }
        set
        {
            PropriedadeModificada("Codsupervisor2", value);
            _codsupervisor2 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Codsupervisor3
    {
        get
        {
            PropriedadeAcessada("Codsupervisor3");
            return _codsupervisor3;
        }
        set
        {
            PropriedadeModificada("Codsupervisor3", value);
            _codsupervisor3 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Codtranspautonomo
    {
        get
        {
            PropriedadeAcessada("Codtranspautonomo");
            return _codtranspautonomo;
        }
        set
        {
            PropriedadeModificada("Codtranspautonomo", value);
            _codtranspautonomo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
    public string Codunidadeexecutora
    {
        get
        {
            PropriedadeAcessada("Codunidadeexecutora");
            return _codunidadeexecutora;
        }
        set
        {
            PropriedadeModificada("Codunidadeexecutora", value);
            _codunidadeexecutora = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal Codusur
    {
        get
        {
            PropriedadeAcessada("Codusur");
            return _codusur;
        }
        set
        {
            PropriedadeModificada("Codusur", value);
            _codusur = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Codusur2
    {
        get
        {
            PropriedadeAcessada("Codusur2");
            return _codusur2;
        }
        set
        {
            PropriedadeModificada("Codusur2", value);
            _codusur2 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Codusur3
    {
        get
        {
            PropriedadeAcessada("Codusur3");
            return _codusur3;
        }
        set
        {
            PropriedadeModificada("Codusur3", value);
            _codusur3 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codusur4
    {
        get
        {
            PropriedadeAcessada("Codusur4");
            return _codusur4;
        }
        set
        {
            PropriedadeModificada("Codusur4", value);
            _codusur4 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Codveiculo
    {
        get
        {
            PropriedadeAcessada("Codveiculo");
            return _codveiculo;
        }
        set
        {
            PropriedadeModificada("Codveiculo", value);
            _codveiculo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Codveiculo1
    {
        get
        {
            PropriedadeAcessada("Codveiculo1");
            return _codveiculo1;
        }
        set
        {
            PropriedadeModificada("Codveiculo1", value);
            _codveiculo1 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Codveiculo2
    {
        get
        {
            PropriedadeAcessada("Codveiculo2");
            return _codveiculo2;
        }
        set
        {
            PropriedadeModificada("Codveiculo2", value);
            _codveiculo2 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Cofinsretido
    {
        get
        {
            PropriedadeAcessada("Cofinsretido");
            return _cofinsretido;
        }
        set
        {
            PropriedadeModificada("Cofinsretido", value);
            _cofinsretido = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 2)]
    public decimal? Comissao
    {
        get
        {
            PropriedadeAcessada("Comissao");
            return _comissao;
        }
        set
        {
            PropriedadeModificada("Comissao", value);
            _comissao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 2)]
    public decimal? Comissao2
    {
        get
        {
            PropriedadeAcessada("Comissao2");
            return _comissao2;
        }
        set
        {
            PropriedadeModificada("Comissao2", value);
            _comissao2 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 2)]
    public decimal? Comissao3
    {
        get
        {
            PropriedadeAcessada("Comissao3");
            return _comissao3;
        }
        set
        {
            PropriedadeModificada("Comissao3", value);
            _comissao3 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 2)]
    public decimal? Comissao4
    {
        get
        {
            PropriedadeAcessada("Comissao4");
            return _comissao4;
        }
        set
        {
            PropriedadeModificada("Comissao4", value);
            _comissao4 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 2)]
    public decimal? Comissaomot
    {
        get
        {
            PropriedadeAcessada("Comissaomot");
            return _comissaomot;
        }
        set
        {
            PropriedadeModificada("Comissaomot", value);
            _comissaomot = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Comissaosup
    {
        get
        {
            PropriedadeAcessada("Comissaosup");
            return _comissaosup;
        }
        set
        {
            PropriedadeModificada("Comissaosup", value);
            _comissaosup = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 60, Precisao = 0)]
    public string Complementocoleta
    {
        get
        {
            PropriedadeAcessada("Complementocoleta");
            return _complementocoleta;
        }
        set
        {
            PropriedadeModificada("Complementocoleta", value);
            _complementocoleta = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 9, Precisao = 0)]
    public string Condfinanc
    {
        get
        {
            PropriedadeAcessada("Condfinanc");
            return _condfinanc;
        }
        set
        {
            PropriedadeModificada("Condfinanc", value);
            _condfinanc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 0)]
    public decimal? Condvenda
    {
        get
        {
            PropriedadeAcessada("Condvenda");
            return _condvenda;
        }
        set
        {
            PropriedadeModificada("Condvenda", value);
            _condvenda = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Conferido
    {
        get
        {
            PropriedadeAcessada("Conferido");
            return _conferido;
        }
        set
        {
            PropriedadeModificada("Conferido", value);
            _conferido = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Consumidorfinal
    {
        get
        {
            PropriedadeAcessada("Consumidorfinal");
            return _consumidorfinal;
        }
        set
        {
            PropriedadeModificada("Consumidorfinal", value);
            _consumidorfinal = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Consumiunumcte
    {
        get
        {
            PropriedadeAcessada("Consumiunumcte");
            return _consumiunumcte;
        }
        set
        {
            PropriedadeModificada("Consumiunumcte", value);
            _consumiunumcte = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Consumiunumnfe
    {
        get
        {
            PropriedadeAcessada("Consumiunumnfe");
            return _consumiunumnfe;
        }
        set
        {
            PropriedadeModificada("Consumiunumnfe", value);
            _consumiunumnfe = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Contadorcupomfiscal
    {
        get
        {
            PropriedadeAcessada("Contadorcupomfiscal");
            return _contadorcupomfiscal;
        }
        set
        {
            PropriedadeModificada("Contadorcupomfiscal", value);
            _contadorcupomfiscal = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Contaordem
    {
        get
        {
            PropriedadeAcessada("Contaordem");
            return _contaordem;
        }
        set
        {
            PropriedadeModificada("Contaordem", value);
            _contaordem = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Contribuinte
    {
        get
        {
            PropriedadeAcessada("Contribuinte");
            return _contribuinte;
        }
        set
        {
            PropriedadeModificada("Contribuinte", value);
            _contribuinte = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 18, Precisao = 0)]
    public string Cpnjresponsavelpedagio
    {
        get
        {
            PropriedadeAcessada("Cpnjresponsavelpedagio");
            return _cpnjresponsavelpedagio;
        }
        set
        {
            PropriedadeModificada("Cpnjresponsavelpedagio", value);
            _cpnjresponsavelpedagio = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Csllretido
    {
        get
        {
            PropriedadeAcessada("Csllretido");
            return _csllretido;
        }
        set
        {
            PropriedadeModificada("Csllretido", value);
            _csllretido = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Ctecodtomadorservico
    {
        get
        {
            PropriedadeAcessada("Ctecodtomadorservico");
            return _ctecodtomadorservico;
        }
        set
        {
            PropriedadeModificada("Ctecodtomadorservico", value);
            _ctecodtomadorservico = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Ctecodtranspsubcontratado
    {
        get
        {
            PropriedadeAcessada("Ctecodtranspsubcontratado");
            return _ctecodtranspsubcontratado;
        }
        set
        {
            PropriedadeModificada("Ctecodtranspsubcontratado", value);
            _ctecodtranspsubcontratado = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Ctecodtranspsubcontratante
    {
        get
        {
            PropriedadeAcessada("Ctecodtranspsubcontratante");
            return _ctecodtranspsubcontratante;
        }
        set
        {
            PropriedadeModificada("Ctecodtranspsubcontratante", value);
            _ctecodtranspsubcontratante = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Ctecodveiculosubcontratante
    {
        get
        {
            PropriedadeAcessada("Ctecodveiculosubcontratante");
            return _ctecodveiculosubcontratante;
        }
        set
        {
            PropriedadeModificada("Ctecodveiculosubcontratante", value);
            _ctecodveiculosubcontratante = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Cteglobalizado
    {
        get
        {
            PropriedadeAcessada("Cteglobalizado");
            return _cteglobalizado;
        }
        set
        {
            PropriedadeModificada("Cteglobalizado", value);
            _cteglobalizado = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Cteregimeespecial
    {
        get
        {
            PropriedadeAcessada("Cteregimeespecial");
            return _cteregimeespecial;
        }
        set
        {
            PropriedadeModificada("Cteregimeespecial", value);
            _cteregimeespecial = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 45, Precisao = 0)]
    public string Ctesubcontratadochavecteref
    {
        get
        {
            PropriedadeAcessada("Ctesubcontratadochavecteref");
            return _ctesubcontratadochavecteref;
        }
        set
        {
            PropriedadeModificada("Ctesubcontratadochavecteref", value);
            _ctesubcontratadochavecteref = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Custobonificacao
    {
        get
        {
            PropriedadeAcessada("Custobonificacao");
            return _custobonificacao;
        }
        set
        {
            PropriedadeModificada("Custobonificacao", value);
            _custobonificacao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dataconsolidacaoprefat
    {
        get
        {
            PropriedadeAcessada("Dataconsolidacaoprefat");
            return _dataconsolidacaoprefat;
        }
        set
        {
            PropriedadeModificada("Dataconsolidacaoprefat", value);
            _dataconsolidacaoprefat = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dataempenho
    {
        get
        {
            PropriedadeAcessada("Dataempenho");
            return _dataempenho;
        }
        set
        {
            PropriedadeModificada("Dataempenho", value);
            _dataempenho = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Datahoraregistroepec
    {
        get
        {
            PropriedadeAcessada("Datahoraregistroepec");
            return _datahoraregistroepec;
        }
        set
        {
            PropriedadeModificada("Datahoraregistroepec", value);
            _datahoraregistroepec = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Deduzirdesonerorgaopub
    {
        get
        {
            PropriedadeAcessada("Deduzirdesonerorgaopub");
            return _deduzirdesonerorgaopub;
        }
        set
        {
            PropriedadeModificada("Deduzirdesonerorgaopub", value);
            _deduzirdesonerorgaopub = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Depositofechado
    {
        get
        {
            PropriedadeAcessada("Depositofechado");
            return _depositofechado;
        }
        set
        {
            PropriedadeModificada("Depositofechado", value);
            _depositofechado = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 60, Precisao = 0)]
    public string Descpais
    {
        get
        {
            PropriedadeAcessada("Descpais");
            return _descpais;
        }
        set
        {
            PropriedadeModificada("Descpais", value);
            _descpais = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 120, Precisao = 0)]
    public string Descricaoprodnfajuste
    {
        get
        {
            PropriedadeAcessada("Descricaoprodnfajuste");
            return _descricaoprodnfajuste;
        }
        set
        {
            PropriedadeModificada("Descricaoprodnfajuste", value);
            _descricaoprodnfajuste = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Despesasrateada
    {
        get
        {
            PropriedadeAcessada("Despesasrateada");
            return _despesasrateada;
        }
        set
        {
            PropriedadeModificada("Despesasrateada", value);
            _despesasrateada = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Devsimbolica
    {
        get
        {
            PropriedadeAcessada("Devsimbolica");
            return _devsimbolica;
        }
        set
        {
            PropriedadeModificada("Devsimbolica", value);
            _devsimbolica = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 100, Precisao = 0)]
    public string Digitoverificadornfse
    {
        get
        {
            PropriedadeAcessada("Digitoverificadornfse");
            return _digitoverificadornfse;
        }
        set
        {
            PropriedadeModificada("Digitoverificadornfse", value);
            _digitoverificadornfse = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Docemissao
    {
        get
        {
            PropriedadeAcessada("Docemissao");
            return _docemissao;
        }
        set
        {
            PropriedadeModificada("Docemissao", value);
            _docemissao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtahoraentradacontigencia
    {
        get
        {
            PropriedadeAcessada("Dtahoraentradacontigencia");
            return _dtahoraentradacontigencia;
        }
        set
        {
            PropriedadeModificada("Dtahoraentradacontigencia", value);
            _dtahoraentradacontigencia = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dta_Horaenviosefaz
    {
        get
        {
            PropriedadeAcessada("Dta_Horaenviosefaz");
            return _dta_horaenviosefaz;
        }
        set
        {
            PropriedadeModificada("Dta_Horaenviosefaz", value);
            _dta_horaenviosefaz = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtcancel
    {
        get
        {
            PropriedadeAcessada("Dtcancel");
            return _dtcancel;
        }
        set
        {
            PropriedadeModificada("Dtcancel", value);
            _dtcancel = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtcancelwms
    {
        get
        {
            PropriedadeAcessada("Dtcancelwms");
            return _dtcancelwms;
        }
        set
        {
            PropriedadeModificada("Dtcancelwms", value);
            _dtcancelwms = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtcanhoto
    {
        get
        {
            PropriedadeAcessada("Dtcanhoto");
            return _dtcanhoto;
        }
        set
        {
            PropriedadeModificada("Dtcanhoto", value);
            _dtcanhoto = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtdenegada
    {
        get
        {
            PropriedadeAcessada("Dtdenegada");
            return _dtdenegada;
        }
        set
        {
            PropriedadeModificada("Dtdenegada", value);
            _dtdenegada = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtdevol
    {
        get
        {
            PropriedadeAcessada("Dtdevol");
            return _dtdevol;
        }
        set
        {
            PropriedadeModificada("Dtdevol", value);
            _dtdevol = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtemissaocteref
    {
        get
        {
            PropriedadeAcessada("Dtemissaocteref");
            return _dtemissaocteref;
        }
        set
        {
            PropriedadeModificada("Dtemissaocteref", value);
            _dtemissaocteref = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtemissaodeclaracao
    {
        get
        {
            PropriedadeAcessada("Dtemissaodeclaracao");
            return _dtemissaodeclaracao;
        }
        set
        {
            PropriedadeModificada("Dtemissaodeclaracao", value);
            _dtemissaodeclaracao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtemissaodocsub
    {
        get
        {
            PropriedadeAcessada("Dtemissaodocsub");
            return _dtemissaodocsub;
        }
        set
        {
            PropriedadeModificada("Dtemissaodocsub", value);
            _dtemissaodocsub = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtemissaonffornec
    {
        get
        {
            PropriedadeAcessada("Dtemissaonffornec");
            return _dtemissaonffornec;
        }
        set
        {
            PropriedadeModificada("Dtemissaonffornec", value);
            _dtemissaonffornec = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtentrega
    {
        get
        {
            PropriedadeAcessada("Dtentrega");
            return _dtentrega;
        }
        set
        {
            PropriedadeModificada("Dtentrega", value);
            _dtentrega = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtexportacaoservint
    {
        get
        {
            PropriedadeAcessada("Dtexportacaoservint");
            return _dtexportacaoservint;
        }
        set
        {
            PropriedadeModificada("Dtexportacaoservint", value);
            _dtexportacaoservint = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtexportacaowms
    {
        get
        {
            PropriedadeAcessada("Dtexportacaowms");
            return _dtexportacaowms;
        }
        set
        {
            PropriedadeModificada("Dtexportacaowms", value);
            _dtexportacaowms = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtfat
    {
        get
        {
            PropriedadeAcessada("Dtfat");
            return _dtfat;
        }
        set
        {
            PropriedadeModificada("Dtfat", value);
            _dtfat = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtfecha
    {
        get
        {
            PropriedadeAcessada("Dtfecha");
            return _dtfecha;
        }
        set
        {
            PropriedadeModificada("Dtfecha", value);
            _dtfecha = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtfechaccrca
    {
        get
        {
            PropriedadeAcessada("Dtfechaccrca");
            return _dtfechaccrca;
        }
        set
        {
            PropriedadeModificada("Dtfechaccrca", value);
            _dtfechaccrca = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dthoraautorizacaosefaz
    {
        get
        {
            PropriedadeAcessada("Dthoraautorizacaosefaz");
            return _dthoraautorizacaosefaz;
        }
        set
        {
            PropriedadeModificada("Dthoraautorizacaosefaz", value);
            _dthoraautorizacaosefaz = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dthoracancelamentosefaz
    {
        get
        {
            PropriedadeAcessada("Dthoracancelamentosefaz");
            return _dthoracancelamentosefaz;
        }
        set
        {
            PropriedadeModificada("Dthoracancelamentosefaz", value);
            _dthoracancelamentosefaz = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dthorachegada
    {
        get
        {
            PropriedadeAcessada("Dthorachegada");
            return _dthorachegada;
        }
        set
        {
            PropriedadeModificada("Dthorachegada", value);
            _dthorachegada = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dthoracte
    {
        get
        {
            PropriedadeAcessada("Dthoracte");
            return _dthoracte;
        }
        set
        {
            PropriedadeModificada("Dthoracte", value);
            _dthoracte = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dthoranfe
    {
        get
        {
            PropriedadeAcessada("Dthoranfe");
            return _dthoranfe;
        }
        set
        {
            PropriedadeModificada("Dthoranfe", value);
            _dthoranfe = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dthorarecibodpec
    {
        get
        {
            PropriedadeAcessada("Dthorarecibodpec");
            return _dthorarecibodpec;
        }
        set
        {
            PropriedadeModificada("Dthorarecibodpec", value);
            _dthorarecibodpec = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dthorasaida
    {
        get
        {
            PropriedadeAcessada("Dthorasaida");
            return _dthorasaida;
        }
        set
        {
            PropriedadeModificada("Dthorasaida", value);
            _dthorasaida = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtimportacaoservprinc
    {
        get
        {
            PropriedadeAcessada("Dtimportacaoservprinc");
            return _dtimportacaoservprinc;
        }
        set
        {
            PropriedadeModificada("Dtimportacaoservprinc", value);
            _dtimportacaoservprinc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtimportacaowms
    {
        get
        {
            PropriedadeAcessada("Dtimportacaowms");
            return _dtimportacaowms;
        }
        set
        {
            PropriedadeModificada("Dtimportacaowms", value);
            _dtimportacaowms = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtlancto
    {
        get
        {
            PropriedadeAcessada("Dtlancto");
            return _dtlancto;
        }
        set
        {
            PropriedadeModificada("Dtlancto", value);
            _dtlancto = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtlibent
    {
        get
        {
            PropriedadeAcessada("Dtlibent");
            return _dtlibent;
        }
        set
        {
            PropriedadeModificada("Dtlibent", value);
            _dtlibent = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtliberacaoentrega
    {
        get
        {
            PropriedadeAcessada("Dtliberacaoentrega");
            return _dtliberacaoentrega;
        }
        set
        {
            PropriedadeModificada("Dtliberacaoentrega", value);
            _dtliberacaoentrega = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtnsu
    {
        get
        {
            PropriedadeAcessada("Dtnsu");
            return _dtnsu;
        }
        set
        {
            PropriedadeModificada("Dtnsu", value);
            _dtnsu = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtpagarrec
    {
        get
        {
            PropriedadeAcessada("Dtpagarrec");
            return _dtpagarrec;
        }
        set
        {
            PropriedadeModificada("Dtpagarrec", value);
            _dtpagarrec = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtpagcomissao
    {
        get
        {
            PropriedadeAcessada("Dtpagcomissao");
            return _dtpagcomissao;
        }
        set
        {
            PropriedadeModificada("Dtpagcomissao", value);
            _dtpagcomissao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtpagcomissaoop
    {
        get
        {
            PropriedadeAcessada("Dtpagcomissaoop");
            return _dtpagcomissaoop;
        }
        set
        {
            PropriedadeModificada("Dtpagcomissaoop", value);
            _dtpagcomissaoop = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtpagcomissaoprof
    {
        get
        {
            PropriedadeAcessada("Dtpagcomissaoprof");
            return _dtpagcomissaoprof;
        }
        set
        {
            PropriedadeModificada("Dtpagcomissaoprof", value);
            _dtpagcomissaoprof = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtpagdotz
    {
        get
        {
            PropriedadeAcessada("Dtpagdotz");
            return _dtpagdotz;
        }
        set
        {
            PropriedadeModificada("Dtpagdotz", value);
            _dtpagdotz = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtpgtocampanha
    {
        get
        {
            PropriedadeAcessada("Dtpgtocampanha");
            return _dtpgtocampanha;
        }
        set
        {
            PropriedadeModificada("Dtpgtocampanha", value);
            _dtpgtocampanha = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime Dtsaida
    {
        get
        {
            PropriedadeAcessada("Dtsaida");
            return _dtsaida;
        }
        set
        {
            PropriedadeModificada("Dtsaida", value);
            _dtsaida = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtsaidanf
    {
        get
        {
            PropriedadeAcessada("Dtsaidanf");
            return _dtsaidanf;
        }
        set
        {
            PropriedadeModificada("Dtsaidanf", value);
            _dtsaidanf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtvencarrec
    {
        get
        {
            PropriedadeAcessada("Dtvencarrec");
            return _dtvencarrec;
        }
        set
        {
            PropriedadeModificada("Dtvencarrec", value);
            _dtvencarrec = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtwms
    {
        get
        {
            PropriedadeAcessada("Dtwms");
            return _dtwms;
        }
        set
        {
            PropriedadeModificada("Dtwms", value);
            _dtwms = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 100, Precisao = 0)]
    public string Emaildest
    {
        get
        {
            PropriedadeAcessada("Emaildest");
            return _emaildest;
        }
        set
        {
            PropriedadeModificada("Emaildest", value);
            _emaildest = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 100, Precisao = 0)]
    public string Emailfrete
    {
        get
        {
            PropriedadeAcessada("Emailfrete");
            return _emailfrete;
        }
        set
        {
            PropriedadeModificada("Emailfrete", value);
            _emailfrete = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 100, Precisao = 0)]
    public string Emailfreteredespacho
    {
        get
        {
            PropriedadeAcessada("Emailfreteredespacho");
            return _emailfreteredespacho;
        }
        set
        {
            PropriedadeModificada("Emailfreteredespacho", value);
            _emailfreteredespacho = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Emissnumautomatico
    {
        get
        {
            PropriedadeAcessada("Emissnumautomatico");
            return _emissnumautomatico;
        }
        set
        {
            PropriedadeModificada("Emissnumautomatico", value);
            _emissnumautomatico = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
    public string Endereco
    {
        get
        {
            PropriedadeAcessada("Endereco");
            return _endereco;
        }
        set
        {
            PropriedadeModificada("Endereco", value);
            _endereco = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Entrega
    {
        get
        {
            PropriedadeAcessada("Entrega");
            return _entrega;
        }
        set
        {
            PropriedadeModificada("Entrega", value);
            _entrega = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Enviada
    {
        get
        {
            PropriedadeAcessada("Enviada");
            return _enviada;
        }
        set
        {
            PropriedadeModificada("Enviada", value);
            _enviada = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Enviadanfe
    {
        get
        {
            PropriedadeAcessada("Enviadanfe");
            return _enviadanfe;
        }
        set
        {
            PropriedadeModificada("Enviadanfe", value);
            _enviadanfe = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Enviadoemailcancelado
    {
        get
        {
            PropriedadeAcessada("Enviadoemailcancelado");
            return _enviadoemailcancelado;
        }
        set
        {
            PropriedadeModificada("Enviadoemailcancelado", value);
            _enviadoemailcancelado = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 64, Precisao = 0)]
    public string Equiplanc
    {
        get
        {
            PropriedadeAcessada("Equiplanc");
            return _equiplanc;
        }
        set
        {
            PropriedadeModificada("Equiplanc", value);
            _equiplanc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Especie
    {
        get
        {
            PropriedadeAcessada("Especie");
            return _especie;
        }
        set
        {
            PropriedadeModificada("Especie", value);
            _especie = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 100, Precisao = 0)]
    public string Especievolume
    {
        get
        {
            PropriedadeAcessada("Especievolume");
            return _especievolume;
        }
        set
        {
            PropriedadeModificada("Especievolume", value);
            _especievolume = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Exportadoservint
    {
        get
        {
            PropriedadeAcessada("Exportadoservint");
            return _exportadoservint;
        }
        set
        {
            PropriedadeModificada("Exportadoservint", value);
            _exportadoservint = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Fil_Montarkitautomaticamente
    {
        get
        {
            PropriedadeAcessada("Fil_Montarkitautomaticamente");
            return _fil_montarkitautomaticamente;
        }
        set
        {
            PropriedadeModificada("Fil_Montarkitautomaticamente", value);
            _fil_montarkitautomaticamente = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Finalidadenfe
    {
        get
        {
            PropriedadeAcessada("Finalidadenfe");
            return _finalidadenfe;
        }
        set
        {
            PropriedadeModificada("Finalidadenfe", value);
            _finalidadenfe = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Formulario
    {
        get
        {
            PropriedadeAcessada("Formulario");
            return _formulario;
        }
        set
        {
            PropriedadeModificada("Formulario", value);
            _formulario = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Fornecentrega
    {
        get
        {
            PropriedadeAcessada("Fornecentrega");
            return _fornecentrega;
        }
        set
        {
            PropriedadeModificada("Fornecentrega", value);
            _fornecentrega = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Freteredespacho
    {
        get
        {
            PropriedadeAcessada("Freteredespacho");
            return _freteredespacho;
        }
        set
        {
            PropriedadeModificada("Freteredespacho", value);
            _freteredespacho = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 30, Precisao = 0)]
    public string Funclanc
    {
        get
        {
            PropriedadeAcessada("Funclanc");
            return _funclanc;
        }
        set
        {
            PropriedadeModificada("Funclanc", value);
            _funclanc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Geracaorazaoauxiliar
    {
        get
        {
            PropriedadeAcessada("Geracaorazaoauxiliar");
            return _geracaorazaoauxiliar;
        }
        set
        {
            PropriedadeModificada("Geracaorazaoauxiliar", value);
            _geracaorazaoauxiliar = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Geracp
    {
        get
        {
            PropriedadeAcessada("Geracp");
            return _geracp;
        }
        set
        {
            PropriedadeModificada("Geracp", value);
            _geracp = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Geranfvenda
    {
        get
        {
            PropriedadeAcessada("Geranfvenda");
            return _geranfvenda;
        }
        set
        {
            PropriedadeModificada("Geranfvenda", value);
            _geranfvenda = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Gerarbcrnfe
    {
        get
        {
            PropriedadeAcessada("Gerarbcrnfe");
            return _gerarbcrnfe;
        }
        set
        {
            PropriedadeModificada("Gerarbcrnfe", value);
            _gerarbcrnfe = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Gerarcptranspaunotomo
    {
        get
        {
            PropriedadeAcessada("Gerarcptranspaunotomo");
            return _gerarcptranspaunotomo;
        }
        set
        {
            PropriedadeModificada("Gerarcptranspaunotomo", value);
            _gerarcptranspaunotomo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Historico
    {
        get
        {
            PropriedadeAcessada("Historico");
            return _historico;
        }
        set
        {
            PropriedadeModificada("Historico", value);
            _historico = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 8, Precisao = 0)]
    public string Horaemissao
    {
        get
        {
            PropriedadeAcessada("Horaemissao");
            return _horaemissao;
        }
        set
        {
            PropriedadeModificada("Horaemissao", value);
            _horaemissao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 2, Precisao = 0)]
    public decimal? Horaentrega
    {
        get
        {
            PropriedadeAcessada("Horaentrega");
            return _horaentrega;
        }
        set
        {
            PropriedadeModificada("Horaentrega", value);
            _horaentrega = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Horalanc
    {
        get
        {
            PropriedadeAcessada("Horalanc");
            return _horalanc;
        }
        set
        {
            PropriedadeModificada("Horalanc", value);
            _horalanc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 2, Precisao = 0)]
    public decimal? Horasaida
    {
        get
        {
            PropriedadeAcessada("Horasaida");
            return _horasaida;
        }
        set
        {
            PropriedadeModificada("Horasaida", value);
            _horasaida = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 2)]
    public decimal? Icmsretido
    {
        get
        {
            PropriedadeAcessada("Icmsretido");
            return _icmsretido;
        }
        set
        {
            PropriedadeModificada("Icmsretido", value);
            _icmsretido = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 2)]
    public decimal? Icmsretidognre
    {
        get
        {
            PropriedadeAcessada("Icmsretidognre");
            return _icmsretidognre;
        }
        set
        {
            PropriedadeModificada("Icmsretidognre", value);
            _icmsretidognre = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Identificarclientenfce
    {
        get
        {
            PropriedadeAcessada("Identificarclientenfce");
            return _identificarclientenfce;
        }
        set
        {
            PropriedadeModificada("Identificarclientenfce", value);
            _identificarclientenfce = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Idlocaldestmerc
    {
        get
        {
            PropriedadeAcessada("Idlocaldestmerc");
            return _idlocaldestmerc;
        }
        set
        {
            PropriedadeModificada("Idlocaldestmerc", value);
            _idlocaldestmerc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 15, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Idtipopresenca
    {
        get
        {
            PropriedadeAcessada("Idtipopresenca");
            return _idtipopresenca;
        }
        set
        {
            PropriedadeModificada("Idtipopresenca", value);
            _idtipopresenca = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 15, Precisao = 0)]
    public string Ie
    {
        get
        {
            PropriedadeAcessada("Ie");
            return _ie;
        }
        set
        {
            PropriedadeModificada("Ie", value);
            _ie = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
    public string Iecteref
    {
        get
        {
            PropriedadeAcessada("Iecteref");
            return _iecteref;
        }
        set
        {
            PropriedadeModificada("Iecteref", value);
            _iecteref = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 15, Precisao = 0)]
    public string Ieent
    {
        get
        {
            PropriedadeAcessada("Ieent");
            return _ieent;
        }
        set
        {
            PropriedadeModificada("Ieent", value);
            _ieent = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
    public string Iefilial
    {
        get
        {
            PropriedadeAcessada("Iefilial");
            return _iefilial;
        }
        set
        {
            PropriedadeModificada("Iefilial", value);
            _iefilial = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 15, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
    public string Iesubsttribut
    {
        get
        {
            PropriedadeAcessada("Iesubsttribut");
            return _iesubsttribut;
        }
        set
        {
            PropriedadeModificada("Iesubsttribut", value);
            _iesubsttribut = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Importadoservprinc
    {
        get
        {
            PropriedadeAcessada("Importadoservprinc");
            return _importadoservprinc;
        }
        set
        {
            PropriedadeModificada("Importadoservprinc", value);
            _importadoservprinc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Imprimiudactejuntodanfe
    {
        get
        {
            PropriedadeAcessada("Imprimiudactejuntodanfe");
            return _imprimiudactejuntodanfe;
        }
        set
        {
            PropriedadeModificada("Imprimiudactejuntodanfe", value);
            _imprimiudactejuntodanfe = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 1, Precisao = 0)]
    public decimal? Indicprestserv
    {
        get
        {
            PropriedadeAcessada("Indicprestserv");
            return _indicprestserv;
        }
        set
        {
            PropriedadeModificada("Indicprestserv", value);
            _indicprestserv = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 256, Precisao = 0)]
    public string Infglobalizado
    {
        get
        {
            PropriedadeAcessada("Infglobalizado");
            return _infglobalizado;
        }
        set
        {
            PropriedadeModificada("Infglobalizado", value);
            _infglobalizado = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Inssretido
    {
        get
        {
            PropriedadeAcessada("Inssretido");
            return _inssretido;
        }
        set
        {
            PropriedadeModificada("Inssretido", value);
            _inssretido = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Inutilizada
    {
        get
        {
            PropriedadeAcessada("Inutilizada");
            return _inutilizada;
        }
        set
        {
            PropriedadeModificada("Inutilizada", value);
            _inutilizada = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Irrretido
    {
        get
        {
            PropriedadeAcessada("Irrretido");
            return _irrretido;
        }
        set
        {
            PropriedadeModificada("Irrretido", value);
            _irrretido = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 256, Precisao = 0)]
    public string Justificativacontigencia
    {
        get
        {
            PropriedadeAcessada("Justificativacontigencia");
            return _justificativacontigencia;
        }
        set
        {
            PropriedadeModificada("Justificativacontigencia", value);
            _justificativacontigencia = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 2)]
    public decimal? Kmfinalentrega
    {
        get
        {
            PropriedadeAcessada("Kmfinalentrega");
            return _kmfinalentrega;
        }
        set
        {
            PropriedadeModificada("Kmfinalentrega", value);
            _kmfinalentrega = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 100, Precisao = 0)]
    public string Linknfse
    {
        get
        {
            PropriedadeAcessada("Linknfse");
            return _linknfse;
        }
        set
        {
            PropriedadeModificada("Linknfse", value);
            _linknfse = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 30, Precisao = 0)]
    public string Localdesembaraco
    {
        get
        {
            PropriedadeAcessada("Localdesembaraco");
            return _localdesembaraco;
        }
        set
        {
            PropriedadeModificada("Localdesembaraco", value);
            _localdesembaraco = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 60, Precisao = 0)]
    public string Logradourocoleta
    {
        get
        {
            PropriedadeAcessada("Logradourocoleta");
            return _logradourocoleta;
        }
        set
        {
            PropriedadeModificada("Logradourocoleta", value);
            _logradourocoleta = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
    public string Lotedpec
    {
        get
        {
            PropriedadeAcessada("Lotedpec");
            return _lotedpec;
        }
        set
        {
            PropriedadeModificada("Lotedpec", value);
            _lotedpec = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 100, Precisao = 0)]
    public string Marcarvolume
    {
        get
        {
            PropriedadeAcessada("Marcarvolume");
            return _marcarvolume;
        }
        set
        {
            PropriedadeModificada("Marcarvolume", value);
            _marcarvolume = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 300, Precisao = 0)]
    public string Md5listaarq
    {
        get
        {
            PropriedadeAcessada("Md5listaarq");
            return _md5listaarq;
        }
        set
        {
            PropriedadeModificada("Md5listaarq", value);
            _md5listaarq = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 200, Precisao = 0)]
    public string Md5paf
    {
        get
        {
            PropriedadeAcessada("Md5paf");
            return _md5paf;
        }
        set
        {
            PropriedadeModificada("Md5paf", value);
            _md5paf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 4000, Precisao = 0)]
    public string Mensagempiscofins
    {
        get
        {
            PropriedadeAcessada("Mensagempiscofins");
            return _mensagempiscofins;
        }
        set
        {
            PropriedadeModificada("Mensagempiscofins", value);
            _mensagempiscofins = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 2, Precisao = 0)]
    public decimal? Minutoentrega
    {
        get
        {
            PropriedadeAcessada("Minutoentrega");
            return _minutoentrega;
        }
        set
        {
            PropriedadeModificada("Minutoentrega", value);
            _minutoentrega = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Minutolanc
    {
        get
        {
            PropriedadeAcessada("Minutolanc");
            return _minutolanc;
        }
        set
        {
            PropriedadeModificada("Minutolanc", value);
            _minutolanc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 2, Precisao = 0)]
    public decimal? Minutosaida
    {
        get
        {
            PropriedadeAcessada("Minutosaida");
            return _minutosaida;
        }
        set
        {
            PropriedadeModificada("Minutosaida", value);
            _minutosaida = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Modelodocsub
    {
        get
        {
            PropriedadeAcessada("Modelodocsub");
            return _modelodocsub;
        }
        set
        {
            PropriedadeModificada("Modelodocsub", value);
            _modelodocsub = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 250, Precisao = 0)]
    public string Motestornonfe
    {
        get
        {
            PropriedadeAcessada("Motestornonfe");
            return _motestornonfe;
        }
        set
        {
            PropriedadeModificada("Motestornonfe", value);
            _motestornonfe = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
    public string Motoristaveiculo
    {
        get
        {
            PropriedadeAcessada("Motoristaveiculo");
            return _motoristaveiculo;
        }
        set
        {
            PropriedadeModificada("Motoristaveiculo", value);
            _motoristaveiculo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 30, Precisao = 0)]
    public string Municipio
    {
        get
        {
            PropriedadeAcessada("Municipio");
            return _municipio;
        }
        set
        {
            PropriedadeModificada("Municipio", value);
            _municipio = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 60, Precisao = 0)]
    public string Natopernfe
    {
        get
        {
            PropriedadeAcessada("Natopernfe");
            return _natopernfe;
        }
        set
        {
            PropriedadeModificada("Natopernfe", value);
            _natopernfe = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 8, Precisao = 0)]
    public string Ncmnfajuste
    {
        get
        {
            PropriedadeAcessada("Ncmnfajuste");
            return _ncmnfajuste;
        }
        set
        {
            PropriedadeModificada("Ncmnfajuste", value);
            _ncmnfajuste = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Nfatualwms
    {
        get
        {
            PropriedadeAcessada("Nfatualwms");
            return _nfatualwms;
        }
        set
        {
            PropriedadeModificada("Nfatualwms", value);
            _nfatualwms = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Nfdeventfutura
    {
        get
        {
            PropriedadeAcessada("Nfdeventfutura");
            return _nfdeventfutura;
        }
        set
        {
            PropriedadeModificada("Nfdeventfutura", value);
            _nfdeventfutura = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Nffornec
    {
        get
        {
            PropriedadeAcessada("Nffornec");
            return _nffornec;
        }
        set
        {
            PropriedadeModificada("Nffornec", value);
            _nffornec = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 100, Precisao = 0)]
    public string Nomearquivodotz
    {
        get
        {
            PropriedadeAcessada("Nomearquivodotz");
            return _nomearquivodotz;
        }
        set
        {
            PropriedadeModificada("Nomearquivodotz", value);
            _nomearquivodotz = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 100, Precisao = 0)]
    public string Nomearquivodotzestorno
    {
        get
        {
            PropriedadeAcessada("Nomearquivodotzestorno");
            return _nomearquivodotzestorno;
        }
        set
        {
            PropriedadeModificada("Nomearquivodotzestorno", value);
            _nomearquivodotzestorno = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 30, Precisao = 0)]
    public string Nomeseguradora
    {
        get
        {
            PropriedadeAcessada("Nomeseguradora");
            return _nomeseguradora;
        }
        set
        {
            PropriedadeModificada("Nomeseguradora", value);
            _nomeseguradora = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 250, Precisao = 0)]
    public string Normaregespecial
    {
        get
        {
            PropriedadeAcessada("Normaregespecial");
            return _normaregespecial;
        }
        set
        {
            PropriedadeModificada("Normaregespecial", value);
            _normaregespecial = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Notadupliquesvc
    {
        get
        {
            PropriedadeAcessada("Notadupliquesvc");
            return _notadupliquesvc;
        }
        set
        {
            PropriedadeModificada("Notadupliquesvc", value);
            _notadupliquesvc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Nsu
    {
        get
        {
            PropriedadeAcessada("Nsu");
            return _nsu;
        }
        set
        {
            PropriedadeModificada("Nsu", value);
            _nsu = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 15, Precisao = 0)]
    public string Nsusociotorcedor
    {
        get
        {
            PropriedadeAcessada("Nsusociotorcedor");
            return _nsusociotorcedor;
        }
        set
        {
            PropriedadeModificada("Nsusociotorcedor", value);
            _nsusociotorcedor = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Numcaixafiscal
    {
        get
        {
            PropriedadeAcessada("Numcaixafiscal");
            return _numcaixafiscal;
        }
        set
        {
            PropriedadeModificada("Numcaixafiscal", value);
            _numcaixafiscal = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Numcar
    {
        get
        {
            PropriedadeAcessada("Numcar");
            return _numcar;
        }
        set
        {
            PropriedadeModificada("Numcar", value);
            _numcar = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Numcaranterior
    {
        get
        {
            PropriedadeAcessada("Numcaranterior");
            return _numcaranterior;
        }
        set
        {
            PropriedadeModificada("Numcaranterior", value);
            _numcaranterior = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Numcargaedi
    {
        get
        {
            PropriedadeAcessada("Numcargaedi");
            return _numcargaedi;
        }
        set
        {
            PropriedadeModificada("Numcargaedi", value);
            _numcargaedi = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 44, Precisao = 0)]
    public string Numchaveexp
    {
        get
        {
            PropriedadeAcessada("Numchaveexp");
            return _numchaveexp;
        }
        set
        {
            PropriedadeModificada("Numchaveexp", value);
            _numchaveexp = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numcirurgia
    {
        get
        {
            PropriedadeAcessada("Numcirurgia");
            return _numcirurgia;
        }
        set
        {
            PropriedadeModificada("Numcirurgia", value);
            _numcirurgia = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
    public string Numcoleta
    {
        get
        {
            PropriedadeAcessada("Numcoleta");
            return _numcoleta;
        }
        set
        {
            PropriedadeModificada("Numcoleta", value);
            _numcoleta = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 20, Precisao = 0)]
    public decimal? Numcomprovante
    {
        get
        {
            PropriedadeAcessada("Numcomprovante");
            return _numcomprovante;
        }
        set
        {
            PropriedadeModificada("Numcomprovante", value);
            _numcomprovante = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Numcontrato
    {
        get
        {
            PropriedadeAcessada("Numcontrato");
            return _numcontrato;
        }
        set
        {
            PropriedadeModificada("Numcontrato", value);
            _numcontrato = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
    public string Numcontratocarreteiro
    {
        get
        {
            PropriedadeAcessada("Numcontratocarreteiro");
            return _numcontratocarreteiro;
        }
        set
        {
            PropriedadeModificada("Numcontratocarreteiro", value);
            _numcontratocarreteiro = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numcupom
    {
        get
        {
            PropriedadeAcessada("Numcupom");
            return _numcupom;
        }
        set
        {
            PropriedadeModificada("Numcupom", value);
            _numcupom = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 255, Precisao = 0)]
    public string Numdocarrec
    {
        get
        {
            PropriedadeAcessada("Numdocarrec");
            return _numdocarrec;
        }
        set
        {
            PropriedadeModificada("Numdocarrec", value);
            _numdocarrec = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
    public string Numdoccteref
    {
        get
        {
            PropriedadeAcessada("Numdoccteref");
            return _numdoccteref;
        }
        set
        {
            PropriedadeModificada("Numdoccteref", value);
            _numdoccteref = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 11, Precisao = 0)]
    public decimal? Numdrawback
    {
        get
        {
            PropriedadeAcessada("Numdrawback");
            return _numdrawback;
        }
        set
        {
            PropriedadeModificada("Numdrawback", value);
            _numdrawback = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numecf
    {
        get
        {
            PropriedadeAcessada("Numecf");
            return _numecf;
        }
        set
        {
            PropriedadeModificada("Numecf", value);
            _numecf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
    public string Numempenho
    {
        get
        {
            PropriedadeAcessada("Numempenho");
            return _numempenho;
        }
        set
        {
            PropriedadeModificada("Numempenho", value);
            _numempenho = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 6, Precisao = 0)]
    public string Numendereco
    {
        get
        {
            PropriedadeAcessada("Numendereco");
            return _numendereco;
        }
        set
        {
            PropriedadeModificada("Numendereco", value);
            _numendereco = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
    public string Numeroapolice
    {
        get
        {
            PropriedadeAcessada("Numeroapolice");
            return _numeroapolice;
        }
        set
        {
            PropriedadeModificada("Numeroapolice", value);
            _numeroapolice = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
    public string Numeroaverbacao
    {
        get
        {
            PropriedadeAcessada("Numeroaverbacao");
            return _numeroaverbacao;
        }
        set
        {
            PropriedadeModificada("Numeroaverbacao", value);
            _numeroaverbacao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 60, Precisao = 0)]
    public string Numerocoleta
    {
        get
        {
            PropriedadeAcessada("Numerocoleta");
            return _numerocoleta;
        }
        set
        {
            PropriedadeModificada("Numerocoleta", value);
            _numerocoleta = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numerodocsub
    {
        get
        {
            PropriedadeAcessada("Numerodocsub");
            return _numerodocsub;
        }
        set
        {
            PropriedadeModificada("Numerodocsub", value);
            _numerodocsub = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numerorps
    {
        get
        {
            PropriedadeAcessada("Numerorps");
            return _numerorps;
        }
        set
        {
            PropriedadeModificada("Numerorps", value);
            _numerorps = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numformulario
    {
        get
        {
            PropriedadeAcessada("Numformulario");
            return _numformulario;
        }
        set
        {
            PropriedadeModificada("Numformulario", value);
            _numformulario = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 30, Precisao = 0)]
    public string Numidf
    {
        get
        {
            PropriedadeAcessada("Numidf");
            return _numidf;
        }
        set
        {
            PropriedadeModificada("Numidf", value);
            _numidf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Numitens
    {
        get
        {
            PropriedadeAcessada("Numitens");
            return _numitens;
        }
        set
        {
            PropriedadeModificada("Numitens", value);
            _numitens = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Numlanccp
    {
        get
        {
            PropriedadeAcessada("Numlanccp");
            return _numlanccp;
        }
        set
        {
            PropriedadeModificada("Numlanccp", value);
            _numlanccp = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Numlista
    {
        get
        {
            PropriedadeAcessada("Numlista");
            return _numlista;
        }
        set
        {
            PropriedadeModificada("Numlista", value);
            _numlista = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 15, Precisao = 0)]
    public string Numlotecte
    {
        get
        {
            PropriedadeAcessada("Numlotecte");
            return _numlotecte;
        }
        set
        {
            PropriedadeModificada("Numlotecte", value);
            _numlotecte = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 15, Precisao = 0)]
    public string Numlotenfe
    {
        get
        {
            PropriedadeAcessada("Numlotenfe");
            return _numlotenfe;
        }
        set
        {
            PropriedadeModificada("Numlotenfe", value);
            _numlotenfe = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numnftransf
    {
        get
        {
            PropriedadeAcessada("Numnftransf");
            return _numnftransf;
        }
        set
        {
            PropriedadeModificada("Numnftransf", value);
            _numnftransf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numnota
    {
        get
        {
            PropriedadeAcessada("Numnota");
            return _numnota;
        }
        set
        {
            PropriedadeModificada("Numnota", value);
            _numnota = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numnotamanif
    {
        get
        {
            PropriedadeAcessada("Numnotamanif");
            return _numnotamanif;
        }
        set
        {
            PropriedadeModificada("Numnotamanif", value);
            _numnotamanif = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 0)]
    public decimal? Numnotanfse
    {
        get
        {
            PropriedadeAcessada("Numnotanfse");
            return _numnotanfse;
        }
        set
        {
            PropriedadeModificada("Numnotanfse", value);
            _numnotanfse = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numnotaorigem
    {
        get
        {
            PropriedadeAcessada("Numnotaorigem");
            return _numnotaorigem;
        }
        set
        {
            PropriedadeModificada("Numnotaorigem", value);
            _numnotaorigem = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numnotavinculada
    {
        get
        {
            PropriedadeAcessada("Numnotavinculada");
            return _numnotavinculada;
        }
        set
        {
            PropriedadeModificada("Numnotavinculada", value);
            _numnotavinculada = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Numop
    {
        get
        {
            PropriedadeAcessada("Numop");
            return _numop;
        }
        set
        {
            PropriedadeModificada("Numop", value);
            _numop = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numorca
    {
        get
        {
            PropriedadeAcessada("Numorca");
            return _numorca;
        }
        set
        {
            PropriedadeModificada("Numorca", value);
            _numorca = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numorcafilial
    {
        get
        {
            PropriedadeAcessada("Numorcafilial");
            return _numorcafilial;
        }
        set
        {
            PropriedadeModificada("Numorcafilial", value);
            _numorcafilial = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Numos
    {
        get
        {
            PropriedadeAcessada("Numos");
            return _numos;
        }
        set
        {
            PropriedadeModificada("Numos", value);
            _numos = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numped
    {
        get
        {
            PropriedadeAcessada("Numped");
            return _numped;
        }
        set
        {
            PropriedadeModificada("Numped", value);
            _numped = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 15, Precisao = 0)]
    public string Numpedcli
    {
        get
        {
            PropriedadeAcessada("Numpedcli");
            return _numpedcli;
        }
        set
        {
            PropriedadeModificada("Numpedcli", value);
            _numpedcli = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
    public string Numpedvanxml
    {
        get
        {
            PropriedadeAcessada("Numpedvanxml");
            return _numpedvanxml;
        }
        set
        {
            PropriedadeModificada("Numpedvanxml", value);
            _numpedvanxml = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numprevenda
    {
        get
        {
            PropriedadeAcessada("Numprevenda");
            return _numprevenda;
        }
        set
        {
            PropriedadeModificada("Numprevenda", value);
            _numprevenda = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 0)]
    public decimal? Numregexp
    {
        get
        {
            PropriedadeAcessada("Numregexp");
            return _numregexp;
        }
        set
        {
            PropriedadeModificada("Numregexp", value);
            _numregexp = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Numregiao
    {
        get
        {
            PropriedadeAcessada("Numregiao");
            return _numregiao;
        }
        set
        {
            PropriedadeModificada("Numregiao", value);
            _numregiao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Numregiaofrete
    {
        get
        {
            PropriedadeAcessada("Numregiaofrete");
            return _numregiaofrete;
        }
        set
        {
            PropriedadeModificada("Numregiaofrete", value);
            _numregiaofrete = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numremessa
    {
        get
        {
            PropriedadeAcessada("Numremessa");
            return _numremessa;
        }
        set
        {
            PropriedadeModificada("Numremessa", value);
            _numremessa = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numselonf
    {
        get
        {
            PropriedadeAcessada("Numselonf");
            return _numselonf;
        }
        set
        {
            PropriedadeModificada("Numselonf", value);
            _numselonf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 20, Precisao = 0)]
    public decimal? Numseq
    {
        get
        {
            PropriedadeAcessada("Numseq");
            return _numseq;
        }
        set
        {
            PropriedadeModificada("Numseq", value);
            _numseq = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 20, Precisao = 0)]
    public decimal? Numseqentrega
    {
        get
        {
            PropriedadeAcessada("Numseqentrega");
            return _numseqentrega;
        }
        set
        {
            PropriedadeModificada("Numseqentrega", value);
            _numseqentrega = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Numseqmontagem
    {
        get
        {
            PropriedadeAcessada("Numseqmontagem");
            return _numseqmontagem;
        }
        set
        {
            PropriedadeModificada("Numseqmontagem", value);
            _numseqmontagem = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 30, Precisao = 0)]
    public string Numserieequip
    {
        get
        {
            PropriedadeAcessada("Numserieequip");
            return _numserieequip;
        }
        set
        {
            PropriedadeModificada("Numserieequip", value);
            _numserieequip = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 13, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Numtab
    {
        get
        {
            PropriedadeAcessada("Numtab");
            return _numtab;
        }
        set
        {
            PropriedadeModificada("Numtab", value);
            _numtab = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numtranscteanul
    {
        get
        {
            PropriedadeAcessada("Numtranscteanul");
            return _numtranscteanul;
        }
        set
        {
            PropriedadeModificada("Numtranscteanul", value);
            _numtranscteanul = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numtransctesubs
    {
        get
        {
            PropriedadeAcessada("Numtransctesubs");
            return _numtransctesubs;
        }
        set
        {
            PropriedadeModificada("Numtransctesubs", value);
            _numtransctesubs = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numtransentdependente
    {
        get
        {
            PropriedadeAcessada("Numtransentdependente");
            return _numtransentdependente;
        }
        set
        {
            PropriedadeModificada("Numtransentdependente", value);
            _numtransentdependente = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numtransentdest
    {
        get
        {
            PropriedadeAcessada("Numtransentdest");
            return _numtransentdest;
        }
        set
        {
            PropriedadeModificada("Numtransentdest", value);
            _numtransentdest = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numtransentnfestornada
    {
        get
        {
            PropriedadeAcessada("Numtransentnfestornada");
            return _numtransentnfestornada;
        }
        set
        {
            PropriedadeModificada("Numtransentnfestornada", value);
            _numtransentnfestornada = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numtransentorigconsig
    {
        get
        {
            PropriedadeAcessada("Numtransentorigconsig");
            return _numtransentorigconsig;
        }
        set
        {
            PropriedadeModificada("Numtransentorigconsig", value);
            _numtransentorigconsig = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numtransentorigem
    {
        get
        {
            PropriedadeAcessada("Numtransentorigem");
            return _numtransentorigem;
        }
        set
        {
            PropriedadeModificada("Numtransentorigem", value);
            _numtransentorigem = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal Numtransvenda
    {
        get
        {
            PropriedadeAcessada("Numtransvenda");
            return _numtransvenda;
        }
        set
        {
            PropriedadeModificada("Numtransvenda", value);
            _numtransvenda = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 2)]
    public decimal? Numtransvendaconhec
    {
        get
        {
            PropriedadeAcessada("Numtransvendaconhec");
            return _numtransvendaconhec;
        }
        set
        {
            PropriedadeModificada("Numtransvendaconhec", value);
            _numtransvendaconhec = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numtransvendadependente
    {
        get
        {
            PropriedadeAcessada("Numtransvendadependente");
            return _numtransvendadependente;
        }
        set
        {
            PropriedadeModificada("Numtransvendadependente", value);
            _numtransvendadependente = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numtransvendadestino
    {
        get
        {
            PropriedadeAcessada("Numtransvendadestino");
            return _numtransvendadestino;
        }
        set
        {
            PropriedadeModificada("Numtransvendadestino", value);
            _numtransvendadestino = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numtransvendaecf
    {
        get
        {
            PropriedadeAcessada("Numtransvendaecf");
            return _numtransvendaecf;
        }
        set
        {
            PropriedadeModificada("Numtransvendaecf", value);
            _numtransvendaecf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numtransvendaorigem
    {
        get
        {
            PropriedadeAcessada("Numtransvendaorigem");
            return _numtransvendaorigem;
        }
        set
        {
            PropriedadeModificada("Numtransvendaorigem", value);
            _numtransvendaorigem = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numtransvendatv13
    {
        get
        {
            PropriedadeAcessada("Numtransvendatv13");
            return _numtransvendatv13;
        }
        set
        {
            PropriedadeModificada("Numtransvendatv13", value);
            _numtransvendatv13 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
    public string Numvalepedagio
    {
        get
        {
            PropriedadeAcessada("Numvalepedagio");
            return _numvalepedagio;
        }
        set
        {
            PropriedadeModificada("Numvalepedagio", value);
            _numvalepedagio = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Numvias
    {
        get
        {
            PropriedadeAcessada("Numvias");
            return _numvias;
        }
        set
        {
            PropriedadeModificada("Numvias", value);
            _numvias = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Numviasgnre
    {
        get
        {
            PropriedadeAcessada("Numviasgnre");
            return _numviasgnre;
        }
        set
        {
            PropriedadeModificada("Numviasgnre", value);
            _numviasgnre = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Numviaspu
    {
        get
        {
            PropriedadeAcessada("Numviaspu");
            return _numviaspu;
        }
        set
        {
            PropriedadeModificada("Numviaspu", value);
            _numviaspu = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Numvolume
    {
        get
        {
            PropriedadeAcessada("Numvolume");
            return _numvolume;
        }
        set
        {
            PropriedadeModificada("Numvolume", value);
            _numvolume = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 120, Precisao = 0)]
    public string Obs
    {
        get
        {
            PropriedadeAcessada("Obs");
            return _obs;
        }
        set
        {
            PropriedadeModificada("Obs", value);
            _obs = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 400, Precisao = 0)]
    public string Obsconhecfrete
    {
        get
        {
            PropriedadeAcessada("Obsconhecfrete");
            return _obsconhecfrete;
        }
        set
        {
            PropriedadeModificada("Obsconhecfrete", value);
            _obsconhecfrete = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 200, Precisao = 0)]
    public string Obsexp
    {
        get
        {
            PropriedadeAcessada("Obsexp");
            return _obsexp;
        }
        set
        {
            PropriedadeModificada("Obsexp", value);
            _obsexp = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1000, Precisao = 0)]
    public string Obsnfajuste
    {
        get
        {
            PropriedadeAcessada("Obsnfajuste");
            return _obsnfajuste;
        }
        set
        {
            PropriedadeModificada("Obsnfajuste", value);
            _obsnfajuste = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 255, Precisao = 0)]
    public string Obsnfcarreg
    {
        get
        {
            PropriedadeAcessada("Obsnfcarreg");
            return _obsnfcarreg;
        }
        set
        {
            PropriedadeModificada("Obsnfcarreg", value);
            _obsnfcarreg = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Binario, Tamanho = 4000, Precisao = 0)]
    public string Obsnfe
    {
        get
        {
            PropriedadeAcessada("Obsnfe");
            return _obsnfe;
        }
        set
        {
            PropriedadeModificada("Obsnfe", value);
            _obsnfe = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 500, Precisao = 0)]
    public string Obspiscofins
    {
        get
        {
            PropriedadeAcessada("Obspiscofins");
            return _obspiscofins;
        }
        set
        {
            PropriedadeModificada("Obspiscofins", value);
            _obspiscofins = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Orgaopub
    {
        get
        {
            PropriedadeAcessada("Orgaopub");
            return _orgaopub;
        }
        set
        {
            PropriedadeModificada("Orgaopub", value);
            _orgaopub = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Orgaopubfederal
    {
        get
        {
            PropriedadeAcessada("Orgaopubfederal");
            return _orgaopubfederal;
        }
        set
        {
            PropriedadeModificada("Orgaopubfederal", value);
            _orgaopubfederal = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Orgaopubmunicipal
    {
        get
        {
            PropriedadeAcessada("Orgaopubmunicipal");
            return _orgaopubmunicipal;
        }
        set
        {
            PropriedadeModificada("Orgaopubmunicipal", value);
            _orgaopubmunicipal = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Origemfrete
    {
        get
        {
            PropriedadeAcessada("Origemfrete");
            return _origemfrete;
        }
        set
        {
            PropriedadeModificada("Origemfrete", value);
            _origemfrete = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Pagchequemoradia
    {
        get
        {
            PropriedadeAcessada("Pagchequemoradia");
            return _pagchequemoradia;
        }
        set
        {
            PropriedadeModificada("Pagchequemoradia", value);
            _pagchequemoradia = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 2)]
    public decimal? Perbaseredoutrasdesp
    {
        get
        {
            PropriedadeAcessada("Perbaseredoutrasdesp");
            return _perbaseredoutrasdesp;
        }
        set
        {
            PropriedadeModificada("Perbaseredoutrasdesp", value);
            _perbaseredoutrasdesp = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Perccomprofissional
    {
        get
        {
            PropriedadeAcessada("Perccomprofissional");
            return _perccomprofissional;
        }
        set
        {
            PropriedadeModificada("Perccomprofissional", value);
            _perccomprofissional = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 2)]
    public decimal? Percentualstfrete
    {
        get
        {
            PropriedadeAcessada("Percentualstfrete");
            return _percentualstfrete;
        }
        set
        {
            PropriedadeModificada("Percentualstfrete", value);
            _percentualstfrete = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Percfrete
    {
        get
        {
            PropriedadeAcessada("Percfrete");
            return _percfrete;
        }
        set
        {
            PropriedadeModificada("Percfrete", value);
            _percfrete = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Percfreteretido
    {
        get
        {
            PropriedadeAcessada("Percfreteretido");
            return _percfreteretido;
        }
        set
        {
            PropriedadeModificada("Percfreteretido", value);
            _percfreteretido = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 2)]
    public decimal? Percicmfrete
    {
        get
        {
            PropriedadeAcessada("Percicmfrete");
            return _percicmfrete;
        }
        set
        {
            PropriedadeModificada("Percicmfrete", value);
            _percicmfrete = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Percofins
    {
        get
        {
            PropriedadeAcessada("Percofins");
            return _percofins;
        }
        set
        {
            PropriedadeModificada("Percofins", value);
            _percofins = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Percstfreteretido
    {
        get
        {
            PropriedadeAcessada("Percstfreteretido");
            return _percstfreteretido;
        }
        set
        {
            PropriedadeModificada("Percstfreteretido", value);
            _percstfreteretido = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 6)]
    public decimal? Perdescfin
    {
        get
        {
            PropriedadeAcessada("Perdescfin");
            return _perdescfin;
        }
        set
        {
            PropriedadeModificada("Perdescfin", value);
            _perdescfin = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Perdescfintot
    {
        get
        {
            PropriedadeAcessada("Perdescfintot");
            return _perdescfintot;
        }
        set
        {
            PropriedadeModificada("Perdescfintot", value);
            _perdescfintot = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Perpis
    {
        get
        {
            PropriedadeAcessada("Perpis");
            return _perpis;
        }
        set
        {
            PropriedadeModificada("Perpis", value);
            _perpis = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Pisretido
    {
        get
        {
            PropriedadeAcessada("Pisretido");
            return _pisretido;
        }
        set
        {
            PropriedadeModificada("Pisretido", value);
            _pisretido = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 10, Precisao = 0)]
    public string Placaveic
    {
        get
        {
            PropriedadeAcessada("Placaveic");
            return _placaveic;
        }
        set
        {
            PropriedadeModificada("Placaveic", value);
            _placaveic = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 2, Precisao = 0)]
    public decimal? Planosuppli
    {
        get
        {
            PropriedadeAcessada("Planosuppli");
            return _planosuppli;
        }
        set
        {
            PropriedadeModificada("Planosuppli", value);
            _planosuppli = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Pontosdotz
    {
        get
        {
            PropriedadeAcessada("Pontosdotz");
            return _pontosdotz;
        }
        set
        {
            PropriedadeModificada("Pontosdotz", value);
            _pontosdotz = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Prazo1
    {
        get
        {
            PropriedadeAcessada("Prazo1");
            return _prazo1;
        }
        set
        {
            PropriedadeModificada("Prazo1", value);
            _prazo1 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Prazo10
    {
        get
        {
            PropriedadeAcessada("Prazo10");
            return _prazo10;
        }
        set
        {
            PropriedadeModificada("Prazo10", value);
            _prazo10 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Prazo11
    {
        get
        {
            PropriedadeAcessada("Prazo11");
            return _prazo11;
        }
        set
        {
            PropriedadeModificada("Prazo11", value);
            _prazo11 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Prazo12
    {
        get
        {
            PropriedadeAcessada("Prazo12");
            return _prazo12;
        }
        set
        {
            PropriedadeModificada("Prazo12", value);
            _prazo12 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Prazo2
    {
        get
        {
            PropriedadeAcessada("Prazo2");
            return _prazo2;
        }
        set
        {
            PropriedadeModificada("Prazo2", value);
            _prazo2 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Prazo3
    {
        get
        {
            PropriedadeAcessada("Prazo3");
            return _prazo3;
        }
        set
        {
            PropriedadeModificada("Prazo3", value);
            _prazo3 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Prazo4
    {
        get
        {
            PropriedadeAcessada("Prazo4");
            return _prazo4;
        }
        set
        {
            PropriedadeModificada("Prazo4", value);
            _prazo4 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Prazo5
    {
        get
        {
            PropriedadeAcessada("Prazo5");
            return _prazo5;
        }
        set
        {
            PropriedadeModificada("Prazo5", value);
            _prazo5 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Prazo6
    {
        get
        {
            PropriedadeAcessada("Prazo6");
            return _prazo6;
        }
        set
        {
            PropriedadeModificada("Prazo6", value);
            _prazo6 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Prazo7
    {
        get
        {
            PropriedadeAcessada("Prazo7");
            return _prazo7;
        }
        set
        {
            PropriedadeModificada("Prazo7", value);
            _prazo7 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Prazo8
    {
        get
        {
            PropriedadeAcessada("Prazo8");
            return _prazo8;
        }
        set
        {
            PropriedadeModificada("Prazo8", value);
            _prazo8 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Prazo9
    {
        get
        {
            PropriedadeAcessada("Prazo9");
            return _prazo9;
        }
        set
        {
            PropriedadeModificada("Prazo9", value);
            _prazo9 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Prazoadicional
    {
        get
        {
            PropriedadeAcessada("Prazoadicional");
            return _prazoadicional;
        }
        set
        {
            PropriedadeModificada("Prazoadicional", value);
            _prazoadicional = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Prazomedio
    {
        get
        {
            PropriedadeAcessada("Prazomedio");
            return _prazomedio;
        }
        set
        {
            PropriedadeModificada("Prazomedio", value);
            _prazomedio = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Prazoponderado
    {
        get
        {
            PropriedadeAcessada("Prazoponderado");
            return _prazoponderado;
        }
        set
        {
            PropriedadeModificada("Prazoponderado", value);
            _prazoponderado = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 50, Precisao = 0)]
    public string Protocolo
    {
        get
        {
            PropriedadeAcessada("Protocolo");
            return _protocolo;
        }
        set
        {
            PropriedadeModificada("Protocolo", value);
            _protocolo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
    public string Protocolocancelamento
    {
        get
        {
            PropriedadeAcessada("Protocolocancelamento");
            return _protocolocancelamento;
        }
        set
        {
            PropriedadeModificada("Protocolocancelamento", value);
            _protocolocancelamento = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
    public string Protocolocancelamentocte
    {
        get
        {
            PropriedadeAcessada("Protocolocancelamentocte");
            return _protocolocancelamentocte;
        }
        set
        {
            PropriedadeModificada("Protocolocancelamentocte", value);
            _protocolocancelamentocte = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 16, Precisao = 0)]
    public string Protocolocte
    {
        get
        {
            PropriedadeAcessada("Protocolocte");
            return _protocolocte;
        }
        set
        {
            PropriedadeModificada("Protocolocte", value);
            _protocolocte = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 16, Precisao = 0)]
    public string Protocolonfe
    {
        get
        {
            PropriedadeAcessada("Protocolonfe");
            return _protocolonfe;
        }
        set
        {
            PropriedadeModificada("Protocolonfe", value);
            _protocolonfe = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 16, Precisao = 0)]
    public string Protocolonfeauto
    {
        get
        {
            PropriedadeAcessada("Protocolonfeauto");
            return _protocolonfeauto;
        }
        set
        {
            PropriedadeModificada("Protocolonfeauto", value);
            _protocolonfeauto = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 16, Precisao = 0)]
    public string Protocolonfecan
    {
        get
        {
            PropriedadeAcessada("Protocolonfecan");
            return _protocolonfecan;
        }
        set
        {
            PropriedadeModificada("Protocolonfecan", value);
            _protocolonfecan = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 15, Precisao = 0)]
    public string Protocolonfeepec
    {
        get
        {
            PropriedadeAcessada("Protocolonfeepec");
            return _protocolonfeepec;
        }
        set
        {
            PropriedadeModificada("Protocolonfeepec", value);
            _protocolonfeepec = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 16, Precisao = 0)]
    public string Protocolonfse
    {
        get
        {
            PropriedadeAcessada("Protocolonfse");
            return _protocolonfse;
        }
        set
        {
            PropriedadeModificada("Protocolonfse", value);
            _protocolonfse = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 500, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 4000, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Qtdereproccte
    {
        get
        {
            PropriedadeAcessada("Qtdereproccte");
            return _qtdereproccte;
        }
        set
        {
            PropriedadeModificada("Qtdereproccte", value);
            _qtdereproccte = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Qtdereprocnfe
    {
        get
        {
            PropriedadeAcessada("Qtdereprocnfe");
            return _qtdereprocnfe;
        }
        set
        {
            PropriedadeModificada("Qtdereprocnfe", value);
            _qtdereprocnfe = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 60, Precisao = 0)]
    public string Razaosocialcoleta
    {
        get
        {
            PropriedadeAcessada("Razaosocialcoleta");
            return _razaosocialcoleta;
        }
        set
        {
            PropriedadeModificada("Razaosocialcoleta", value);
            _razaosocialcoleta = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 60, Precisao = 0)]
    public string Razaosocialcteref
    {
        get
        {
            PropriedadeAcessada("Razaosocialcteref");
            return _razaosocialcteref;
        }
        set
        {
            PropriedadeModificada("Razaosocialcteref", value);
            _razaosocialcteref = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Recarga
    {
        get
        {
            PropriedadeAcessada("Recarga");
            return _recarga;
        }
        set
        {
            PropriedadeModificada("Recarga", value);
            _recarga = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
    public string Recibocte
    {
        get
        {
            PropriedadeAcessada("Recibocte");
            return _recibocte;
        }
        set
        {
            PropriedadeModificada("Recibocte", value);
            _recibocte = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
    public string Recibodpec
    {
        get
        {
            PropriedadeAcessada("Recibodpec");
            return _recibodpec;
        }
        set
        {
            PropriedadeModificada("Recibodpec", value);
            _recibodpec = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
    public string Recibonfe
    {
        get
        {
            PropriedadeAcessada("Recibonfe");
            return _recibonfe;
        }
        set
        {
            PropriedadeModificada("Recibonfe", value);
            _recibonfe = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Reservaritenstv7
    {
        get
        {
            PropriedadeAcessada("Reservaritenstv7");
            return _reservaritenstv7;
        }
        set
        {
            PropriedadeModificada("Reservaritenstv7", value);
            _reservaritenstv7 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 1, Precisao = 0)]
    public decimal? Respseguro
    {
        get
        {
            PropriedadeAcessada("Respseguro");
            return _respseguro;
        }
        set
        {
            PropriedadeModificada("Respseguro", value);
            _respseguro = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 48, Precisao = 0)]
    public string Rotinacad
    {
        get
        {
            PropriedadeAcessada("Rotinacad");
            return _rotinacad;
        }
        set
        {
            PropriedadeModificada("Rotinacad", value);
            _rotinacad = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 48, Precisao = 0)]
    public string Rotinacadcte
    {
        get
        {
            PropriedadeAcessada("Rotinacadcte");
            return _rotinacadcte;
        }
        set
        {
            PropriedadeModificada("Rotinacadcte", value);
            _rotinacadcte = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 48, Precisao = 0)]
    public string Rotinalanc
    {
        get
        {
            PropriedadeAcessada("Rotinalanc");
            return _rotinalanc;
        }
        set
        {
            PropriedadeModificada("Rotinalanc", value);
            _rotinalanc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
    public string Selo
    {
        get
        {
            PropriedadeAcessada("Selo");
            return _selo;
        }
        set
        {
            PropriedadeModificada("Selo", value);
            _selo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 5, Precisao = 0)]
    public string Serie
    {
        get
        {
            PropriedadeAcessada("Serie");
            return _serie;
        }
        set
        {
            PropriedadeModificada("Serie", value);
            _serie = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 3, Precisao = 0)]
    public string Seriedoccteref
    {
        get
        {
            PropriedadeAcessada("Seriedoccteref");
            return _seriedoccteref;
        }
        set
        {
            PropriedadeModificada("Seriedoccteref", value);
            _seriedoccteref = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 3, Precisao = 0)]
    public string Seriedocsub
    {
        get
        {
            PropriedadeAcessada("Seriedocsub");
            return _seriedocsub;
        }
        set
        {
            PropriedadeModificada("Seriedocsub", value);
            _seriedocsub = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Serieecf
    {
        get
        {
            PropriedadeAcessada("Serieecf");
            return _serieecf;
        }
        set
        {
            PropriedadeModificada("Serieecf", value);
            _serieecf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 3, Precisao = 0)]
    public string Serieoriginal
    {
        get
        {
            PropriedadeAcessada("Serieoriginal");
            return _serieoriginal;
        }
        set
        {
            PropriedadeModificada("Serieoriginal", value);
            _serieoriginal = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 3, Precisao = 0)]
    public string Serierps
    {
        get
        {
            PropriedadeAcessada("Serierps");
            return _serierps;
        }
        set
        {
            PropriedadeModificada("Serierps", value);
            _serierps = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Simplesnacional
    {
        get
        {
            PropriedadeAcessada("Simplesnacional");
            return _simplesnacional;
        }
        set
        {
            PropriedadeModificada("Simplesnacional", value);
            _simplesnacional = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Sitdoc
    {
        get
        {
            PropriedadeAcessada("Sitdoc");
            return _sitdoc;
        }
        set
        {
            PropriedadeModificada("Sitdoc", value);
            _sitdoc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Situacaocte
    {
        get
        {
            PropriedadeAcessada("Situacaocte");
            return _situacaocte;
        }
        set
        {
            PropriedadeModificada("Situacaocte", value);
            _situacaocte = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Situacaonfe
    {
        get
        {
            PropriedadeAcessada("Situacaonfe");
            return _situacaonfe;
        }
        set
        {
            PropriedadeModificada("Situacaonfe", value);
            _situacaonfe = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 3, Precisao = 0)]
    public decimal? Situacaonfeepec
    {
        get
        {
            PropriedadeAcessada("Situacaonfeepec");
            return _situacaonfeepec;
        }
        set
        {
            PropriedadeModificada("Situacaonfeepec", value);
            _situacaonfeepec = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Situacaonfeorig
    {
        get
        {
            PropriedadeAcessada("Situacaonfeorig");
            return _situacaonfeorig;
        }
        set
        {
            PropriedadeModificada("Situacaonfeorig", value);
            _situacaonfeorig = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Situacaonfse
    {
        get
        {
            PropriedadeAcessada("Situacaonfse");
            return _situacaonfse;
        }
        set
        {
            PropriedadeModificada("Situacaonfse", value);
            _situacaonfse = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 2)]
    public decimal? Stribut
    {
        get
        {
            PropriedadeAcessada("Stribut");
            return _stribut;
        }
        set
        {
            PropriedadeModificada("Stribut", value);
            _stribut = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Subserie
    {
        get
        {
            PropriedadeAcessada("Subserie");
            return _subserie;
        }
        set
        {
            PropriedadeModificada("Subserie", value);
            _subserie = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Subseriedoccteref
    {
        get
        {
            PropriedadeAcessada("Subseriedoccteref");
            return _subseriedoccteref;
        }
        set
        {
            PropriedadeModificada("Subseriedoccteref", value);
            _subseriedoccteref = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 3, Precisao = 0)]
    public string Subseriedocsub
    {
        get
        {
            PropriedadeAcessada("Subseriedocsub");
            return _subseriedocsub;
        }
        set
        {
            PropriedadeModificada("Subseriedocsub", value);
            _subseriedocsub = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 15, Precisao = 0)]
    public string Sulframa
    {
        get
        {
            PropriedadeAcessada("Sulframa");
            return _sulframa;
        }
        set
        {
            PropriedadeModificada("Sulframa", value);
            _sulframa = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 2)]
    public decimal? Taxaentrega
    {
        get
        {
            PropriedadeAcessada("Taxaentrega");
            return _taxaentrega;
        }
        set
        {
            PropriedadeModificada("Taxaentrega", value);
            _taxaentrega = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
    public string Telefone
    {
        get
        {
            PropriedadeAcessada("Telefone");
            return _telefone;
        }
        set
        {
            PropriedadeModificada("Telefone", value);
            _telefone = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Tentativaenviocte
    {
        get
        {
            PropriedadeAcessada("Tentativaenviocte");
            return _tentativaenviocte;
        }
        set
        {
            PropriedadeModificada("Tentativaenviocte", value);
            _tentativaenviocte = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Tentativaenvionfe
    {
        get
        {
            PropriedadeAcessada("Tentativaenvionfe");
            return _tentativaenvionfe;
        }
        set
        {
            PropriedadeModificada("Tentativaenvionfe", value);
            _tentativaenvionfe = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Tipoaliqoutrasdesp
    {
        get
        {
            PropriedadeAcessada("Tipoaliqoutrasdesp");
            return _tipoaliqoutrasdesp;
        }
        set
        {
            PropriedadeModificada("Tipoaliqoutrasdesp", value);
            _tipoaliqoutrasdesp = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Tipocontacorrente
    {
        get
        {
            PropriedadeAcessada("Tipocontacorrente");
            return _tipocontacorrente;
        }
        set
        {
            PropriedadeModificada("Tipocontacorrente", value);
            _tipocontacorrente = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Tipodevol
    {
        get
        {
            PropriedadeAcessada("Tipodevol");
            return _tipodevol;
        }
        set
        {
            PropriedadeModificada("Tipodevol", value);
            _tipodevol = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Tipodocarrecgnre
    {
        get
        {
            PropriedadeAcessada("Tipodocarrecgnre");
            return _tipodocarrecgnre;
        }
        set
        {
            PropriedadeModificada("Tipodocarrecgnre", value);
            _tipodocarrecgnre = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Tipodoccteref
    {
        get
        {
            PropriedadeAcessada("Tipodoccteref");
            return _tipodoccteref;
        }
        set
        {
            PropriedadeModificada("Tipodoccteref", value);
            _tipodoccteref = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 3, Precisao = 0)]
    public string Tipodocumentosub
    {
        get
        {
            PropriedadeAcessada("Tipodocumentosub");
            return _tipodocumentosub;
        }
        set
        {
            PropriedadeModificada("Tipodocumentosub", value);
            _tipodocumentosub = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Tipoemissao
    {
        get
        {
            PropriedadeAcessada("Tipoemissao");
            return _tipoemissao;
        }
        set
        {
            PropriedadeModificada("Tipoemissao", value);
            _tipoemissao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Tipoemissaocte
    {
        get
        {
            PropriedadeAcessada("Tipoemissaocte");
            return _tipoemissaocte;
        }
        set
        {
            PropriedadeModificada("Tipoemissaocte", value);
            _tipoemissaocte = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 4, Precisao = 0)]
    public string Tipoempresa
    {
        get
        {
            PropriedadeAcessada("Tipoempresa");
            return _tipoempresa;
        }
        set
        {
            PropriedadeModificada("Tipoempresa", value);
            _tipoempresa = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Tipofj
    {
        get
        {
            PropriedadeAcessada("Tipofj");
            return _tipofj;
        }
        set
        {
            PropriedadeModificada("Tipofj", value);
            _tipofj = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Tipofrete
    {
        get
        {
            PropriedadeAcessada("Tipofrete");
            return _tipofrete;
        }
        set
        {
            PropriedadeModificada("Tipofrete", value);
            _tipofrete = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 1, Precisao = 0)]
    public decimal? Tipoinscprestserv
    {
        get
        {
            PropriedadeAcessada("Tipoinscprestserv");
            return _tipoinscprestserv;
        }
        set
        {
            PropriedadeModificada("Tipoinscprestserv", value);
            _tipoinscprestserv = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 3, Precisao = 0)]
    public decimal? Tipomovgarantia
    {
        get
        {
            PropriedadeAcessada("Tipomovgarantia");
            return _tipomovgarantia;
        }
        set
        {
            PropriedadeModificada("Tipomovgarantia", value);
            _tipomovgarantia = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Tipopresencaadquirinte
    {
        get
        {
            PropriedadeAcessada("Tipopresencaadquirinte");
            return _tipopresencaadquirinte;
        }
        set
        {
            PropriedadeModificada("Tipopresencaadquirinte", value);
            _tipopresencaadquirinte = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Tiporemessa
    {
        get
        {
            PropriedadeAcessada("Tiporemessa");
            return _tiporemessa;
        }
        set
        {
            PropriedadeModificada("Tiporemessa", value);
            _tiporemessa = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Tiposervicocte
    {
        get
        {
            PropriedadeAcessada("Tiposervicocte");
            return _tiposervicocte;
        }
        set
        {
            PropriedadeModificada("Tiposervicocte", value);
            _tiposervicocte = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Tiposubcontratacaocte
    {
        get
        {
            PropriedadeAcessada("Tiposubcontratacaocte");
            return _tiposubcontratacaocte;
        }
        set
        {
            PropriedadeModificada("Tiposubcontratacaocte", value);
            _tiposubcontratacaocte = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Tipotransfentredeposito
    {
        get
        {
            PropriedadeAcessada("Tipotransfentredeposito");
            return _tipotransfentredeposito;
        }
        set
        {
            PropriedadeModificada("Tipotransfentredeposito", value);
            _tipotransfentredeposito = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Tipovenda
    {
        get
        {
            PropriedadeAcessada("Tipovenda");
            return _tipovenda;
        }
        set
        {
            PropriedadeModificada("Tipovenda", value);
            _tipovenda = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 1, Precisao = 0)]
    public decimal? Tomadorcte
    {
        get
        {
            PropriedadeAcessada("Tomadorcte");
            return _tomadorcte;
        }
        set
        {
            PropriedadeModificada("Tomadorcte", value);
            _tomadorcte = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 2)]
    public decimal? Totdifaliquotas
    {
        get
        {
            PropriedadeAcessada("Totdifaliquotas");
            return _totdifaliquotas;
        }
        set
        {
            PropriedadeModificada("Totdifaliquotas", value);
            _totdifaliquotas = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Totpeso
    {
        get
        {
            PropriedadeAcessada("Totpeso");
            return _totpeso;
        }
        set
        {
            PropriedadeModificada("Totpeso", value);
            _totpeso = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Totpesoagrupado
    {
        get
        {
            PropriedadeAcessada("Totpesoagrupado");
            return _totpesoagrupado;
        }
        set
        {
            PropriedadeModificada("Totpesoagrupado", value);
            _totpesoagrupado = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Totpesobruto
    {
        get
        {
            PropriedadeAcessada("Totpesobruto");
            return _totpesobruto;
        }
        set
        {
            PropriedadeModificada("Totpesobruto", value);
            _totpesobruto = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Totpesoliq
    {
        get
        {
            PropriedadeAcessada("Totpesoliq");
            return _totpesoliq;
        }
        set
        {
            PropriedadeModificada("Totpesoliq", value);
            _totpesoliq = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Totpesoliqagrupado
    {
        get
        {
            PropriedadeAcessada("Totpesoliqagrupado");
            return _totpesoliqagrupado;
        }
        set
        {
            PropriedadeModificada("Totpesoliqagrupado", value);
            _totpesoliqagrupado = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Totvlbonific
    {
        get
        {
            PropriedadeAcessada("Totvlbonific");
            return _totvlbonific;
        }
        set
        {
            PropriedadeModificada("Totvlbonific", value);
            _totvlbonific = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Totvldesccom
    {
        get
        {
            PropriedadeAcessada("Totvldesccom");
            return _totvldesccom;
        }
        set
        {
            PropriedadeModificada("Totvldesccom", value);
            _totvldesccom = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Totvldescfin
    {
        get
        {
            PropriedadeAcessada("Totvldescfin");
            return _totvldescfin;
        }
        set
        {
            PropriedadeModificada("Totvldescfin", value);
            _totvldescfin = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Totvldescflex
    {
        get
        {
            PropriedadeAcessada("Totvldescflex");
            return _totvldescflex;
        }
        set
        {
            PropriedadeModificada("Totvldescflex", value);
            _totvldescflex = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Totvlredcomiss
    {
        get
        {
            PropriedadeAcessada("Totvlredcomiss");
            return _totvlredcomiss;
        }
        set
        {
            PropriedadeModificada("Totvlredcomiss", value);
            _totvlredcomiss = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Totvlredcomisssup
    {
        get
        {
            PropriedadeAcessada("Totvlredcomisssup");
            return _totvlredcomisssup;
        }
        set
        {
            PropriedadeModificada("Totvlredcomisssup", value);
            _totvlredcomisssup = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Totvolume
    {
        get
        {
            PropriedadeAcessada("Totvolume");
            return _totvolume;
        }
        set
        {
            PropriedadeModificada("Totvolume", value);
            _totvolume = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Totvolumeagrupado
    {
        get
        {
            PropriedadeAcessada("Totvolumeagrupado");
            return _totvolumeagrupado;
        }
        set
        {
            PropriedadeModificada("Totvolumeagrupado", value);
            _totvolumeagrupado = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Transfdep
    {
        get
        {
            PropriedadeAcessada("Transfdep");
            return _transfdep;
        }
        set
        {
            PropriedadeModificada("Transfdep", value);
            _transfdep = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Transpautonomo
    {
        get
        {
            PropriedadeAcessada("Transpautonomo");
            return _transpautonomo;
        }
        set
        {
            PropriedadeModificada("Transpautonomo", value);
            _transpautonomo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 60, Precisao = 0)]
    public string Transportadora
    {
        get
        {
            PropriedadeAcessada("Transportadora");
            return _transportadora;
        }
        set
        {
            PropriedadeModificada("Transportadora", value);
            _transportadora = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Uf
    {
        get
        {
            PropriedadeAcessada("Uf");
            return _uf;
        }
        set
        {
            PropriedadeModificada("Uf", value);
            _uf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Ufbeneficiaria
    {
        get
        {
            PropriedadeAcessada("Ufbeneficiaria");
            return _ufbeneficiaria;
        }
        set
        {
            PropriedadeModificada("Ufbeneficiaria", value);
            _ufbeneficiaria = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Ufcodigo
    {
        get
        {
            PropriedadeAcessada("Ufcodigo");
            return _ufcodigo;
        }
        set
        {
            PropriedadeModificada("Ufcodigo", value);
            _ufcodigo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Ufcteref
    {
        get
        {
            PropriedadeAcessada("Ufcteref");
            return _ufcteref;
        }
        set
        {
            PropriedadeModificada("Ufcteref", value);
            _ufcteref = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Ufdesembaraco
    {
        get
        {
            PropriedadeAcessada("Ufdesembaraco");
            return _ufdesembaraco;
        }
        set
        {
            PropriedadeModificada("Ufdesembaraco", value);
            _ufdesembaraco = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Uffilial
    {
        get
        {
            PropriedadeAcessada("Uffilial");
            return _uffilial;
        }
        set
        {
            PropriedadeModificada("Uffilial", value);
            _uffilial = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Ufplacavei
    {
        get
        {
            PropriedadeAcessada("Ufplacavei");
            return _ufplacavei;
        }
        set
        {
            PropriedadeModificada("Ufplacavei", value);
            _ufplacavei = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Ufplacaveic
    {
        get
        {
            PropriedadeAcessada("Ufplacaveic");
            return _ufplacaveic;
        }
        set
        {
            PropriedadeModificada("Ufplacaveic", value);
            _ufplacaveic = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 6, Precisao = 0)]
    public string Unidadenfajuste
    {
        get
        {
            PropriedadeAcessada("Unidadenfajuste");
            return _unidadenfajuste;
        }
        set
        {
            PropriedadeModificada("Unidadenfajuste", value);
            _unidadenfajuste = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Usaintegracaowms
    {
        get
        {
            PropriedadeAcessada("Usaintegracaowms");
            return _usaintegracaowms;
        }
        set
        {
            PropriedadeModificada("Usaintegracaowms", value);
            _usaintegracaowms = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Usamultuniditem
    {
        get
        {
            PropriedadeAcessada("Usamultuniditem");
            return _usamultuniditem;
        }
        set
        {
            PropriedadeModificada("Usamultuniditem", value);
            _usamultuniditem = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Utilizaexpdiversos
    {
        get
        {
            PropriedadeAcessada("Utilizaexpdiversos");
            return _utilizaexpdiversos;
        }
        set
        {
            PropriedadeModificada("Utilizaexpdiversos", value);
            _utilizaexpdiversos = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Utilizaipicalcicms
    {
        get
        {
            PropriedadeAcessada("Utilizaipicalcicms");
            return _utilizaipicalcicms;
        }
        set
        {
            PropriedadeModificada("Utilizaipicalcicms", value);
            _utilizaipicalcicms = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 13, Precisao = 2)]
    public decimal? Valordocsub
    {
        get
        {
            PropriedadeAcessada("Valordocsub");
            return _valordocsub;
        }
        set
        {
            PropriedadeModificada("Valordocsub", value);
            _valordocsub = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 13, Precisao = 2)]
    public decimal? Valorpedagio
    {
        get
        {
            PropriedadeAcessada("Valorpedagio");
            return _valorpedagio;
        }
        set
        {
            PropriedadeModificada("Valorpedagio", value);
            _valorpedagio = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 2)]
    public decimal? Valorst
    {
        get
        {
            PropriedadeAcessada("Valorst");
            return _valorst;
        }
        set
        {
            PropriedadeModificada("Valorst", value);
            _valorst = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Vendaassistida
    {
        get
        {
            PropriedadeAcessada("Vendaassistida");
            return _vendaassistida;
        }
        set
        {
            PropriedadeModificada("Vendaassistida", value);
            _vendaassistida = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Vendaexportacao
    {
        get
        {
            PropriedadeAcessada("Vendaexportacao");
            return _vendaexportacao;
        }
        set
        {
            PropriedadeModificada("Vendaexportacao", value);
            _vendaexportacao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Vendanfseried
    {
        get
        {
            PropriedadeAcessada("Vendanfseried");
            return _vendanfseried;
        }
        set
        {
            PropriedadeModificada("Vendanfseried", value);
            _vendanfseried = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Vendatriangular
    {
        get
        {
            PropriedadeAcessada("Vendatriangular");
            return _vendatriangular;
        }
        set
        {
            PropriedadeModificada("Vendatriangular", value);
            _vendatriangular = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
    public string Versaorotina
    {
        get
        {
            PropriedadeAcessada("Versaorotina");
            return _versaorotina;
        }
        set
        {
            PropriedadeModificada("Versaorotina", value);
            _versaorotina = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 2)]
    public decimal? Vlbase
    {
        get
        {
            PropriedadeAcessada("Vlbase");
            return _vlbase;
        }
        set
        {
            PropriedadeModificada("Vlbase", value);
            _vlbase = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 2)]
    public decimal? Vlbaseipi
    {
        get
        {
            PropriedadeAcessada("Vlbaseipi");
            return _vlbaseipi;
        }
        set
        {
            PropriedadeModificada("Vlbaseipi", value);
            _vlbaseipi = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 2)]
    public decimal? Vlbasepiscofins
    {
        get
        {
            PropriedadeAcessada("Vlbasepiscofins");
            return _vlbasepiscofins;
        }
        set
        {
            PropriedadeModificada("Vlbasepiscofins", value);
            _vlbasepiscofins = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlbaseretencao
    {
        get
        {
            PropriedadeAcessada("Vlbaseretencao");
            return _vlbaseretencao;
        }
        set
        {
            PropriedadeModificada("Vlbaseretencao", value);
            _vlbaseretencao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 2)]
    public decimal? Vlbasestfrete
    {
        get
        {
            PropriedadeAcessada("Vlbasestfrete");
            return _vlbasestfrete;
        }
        set
        {
            PropriedadeModificada("Vlbasestfrete", value);
            _vlbasestfrete = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 2)]
    public decimal? Vlboleto
    {
        get
        {
            PropriedadeAcessada("Vlboleto");
            return _vlboleto;
        }
        set
        {
            PropriedadeModificada("Vlboleto", value);
            _vlboleto = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 16, Precisao = 3)]
    public decimal? Vlbonific
    {
        get
        {
            PropriedadeAcessada("Vlbonific");
            return _vlbonific;
        }
        set
        {
            PropriedadeModificada("Vlbonific", value);
            _vlbonific = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 2)]
    public decimal? Vlbonificacerto
    {
        get
        {
            PropriedadeAcessada("Vlbonificacerto");
            return _vlbonificacerto;
        }
        set
        {
            PropriedadeModificada("Vlbonificacerto", value);
            _vlbonificacerto = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlcofins
    {
        get
        {
            PropriedadeAcessada("Vlcofins");
            return _vlcofins;
        }
        set
        {
            PropriedadeModificada("Vlcofins", value);
            _vlcofins = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlcsll
    {
        get
        {
            PropriedadeAcessada("Vlcsll");
            return _vlcsll;
        }
        set
        {
            PropriedadeModificada("Vlcsll", value);
            _vlcsll = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 2)]
    public decimal? Vlcustocont
    {
        get
        {
            PropriedadeAcessada("Vlcustocont");
            return _vlcustocont;
        }
        set
        {
            PropriedadeModificada("Vlcustocont", value);
            _vlcustocont = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 2)]
    public decimal? Vlcustofin
    {
        get
        {
            PropriedadeAcessada("Vlcustofin");
            return _vlcustofin;
        }
        set
        {
            PropriedadeModificada("Vlcustofin", value);
            _vlcustofin = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 2)]
    public decimal? Vlcustoreal
    {
        get
        {
            PropriedadeAcessada("Vlcustoreal");
            return _vlcustoreal;
        }
        set
        {
            PropriedadeModificada("Vlcustoreal", value);
            _vlcustoreal = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 2)]
    public decimal? Vlcustorep
    {
        get
        {
            PropriedadeAcessada("Vlcustorep");
            return _vlcustorep;
        }
        set
        {
            PropriedadeModificada("Vlcustorep", value);
            _vlcustorep = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vldescabatimento
    {
        get
        {
            PropriedadeAcessada("Vldescabatimento");
            return _vldescabatimento;
        }
        set
        {
            PropriedadeModificada("Vldescabatimento", value);
            _vldescabatimento = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vldescfin
    {
        get
        {
            PropriedadeAcessada("Vldescfin");
            return _vldescfin;
        }
        set
        {
            PropriedadeModificada("Vldescfin", value);
            _vldescfin = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 2)]
    public decimal? Vldescicms
    {
        get
        {
            PropriedadeAcessada("Vldescicms");
            return _vldescicms;
        }
        set
        {
            PropriedadeModificada("Vldescicms", value);
            _vldescicms = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 2)]
    public decimal? Vldesconto
    {
        get
        {
            PropriedadeAcessada("Vldesconto");
            return _vldesconto;
        }
        set
        {
            PropriedadeModificada("Vldesconto", value);
            _vldesconto = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 2)]
    public decimal? Vldescprom
    {
        get
        {
            PropriedadeAcessada("Vldescprom");
            return _vldescprom;
        }
        set
        {
            PropriedadeModificada("Vldescprom", value);
            _vldescprom = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 2)]
    public decimal? Vldescsociotorcedor
    {
        get
        {
            PropriedadeAcessada("Vldescsociotorcedor");
            return _vldescsociotorcedor;
        }
        set
        {
            PropriedadeModificada("Vldescsociotorcedor", value);
            _vldescsociotorcedor = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vldespacho
    {
        get
        {
            PropriedadeAcessada("Vldespacho");
            return _vldespacho;
        }
        set
        {
            PropriedadeModificada("Vldespacho", value);
            _vldespacho = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 2)]
    public decimal? Vldespdentronf
    {
        get
        {
            PropriedadeAcessada("Vldespdentronf");
            return _vldespdentronf;
        }
        set
        {
            PropriedadeModificada("Vldespdentronf", value);
            _vldespdentronf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 2)]
    public decimal? Vldesppedagio
    {
        get
        {
            PropriedadeAcessada("Vldesppedagio");
            return _vldesppedagio;
        }
        set
        {
            PropriedadeModificada("Vldesppedagio", value);
            _vldesppedagio = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 2)]
    public decimal? Vldevolucao
    {
        get
        {
            PropriedadeAcessada("Vldevolucao");
            return _vldevolucao;
        }
        set
        {
            PropriedadeModificada("Vldevolucao", value);
            _vldevolucao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 20, Precisao = 6)]
    public decimal? Vldocarrecadacao
    {
        get
        {
            PropriedadeAcessada("Vldocarrecadacao");
            return _vldocarrecadacao;
        }
        set
        {
            PropriedadeModificada("Vldocarrecadacao", value);
            _vldocarrecadacao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 2)]
    public decimal? Vlfrete
    {
        get
        {
            PropriedadeAcessada("Vlfrete");
            return _vlfrete;
        }
        set
        {
            PropriedadeModificada("Vlfrete", value);
            _vlfrete = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 2)]
    public decimal? Vlfretenf
    {
        get
        {
            PropriedadeAcessada("Vlfretenf");
            return _vlfretenf;
        }
        set
        {
            PropriedadeModificada("Vlfretenf", value);
            _vlfretenf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 2)]
    public decimal? Vlfreteoutrasdesp
    {
        get
        {
            PropriedadeAcessada("Vlfreteoutrasdesp");
            return _vlfreteoutrasdesp;
        }
        set
        {
            PropriedadeModificada("Vlfreteoutrasdesp", value);
            _vlfreteoutrasdesp = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 2)]
    public decimal? Vlfreteretido
    {
        get
        {
            PropriedadeAcessada("Vlfreteretido");
            return _vlfreteretido;
        }
        set
        {
            PropriedadeModificada("Vlfreteretido", value);
            _vlfreteretido = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 2)]
    public decimal? Vlgris
    {
        get
        {
            PropriedadeAcessada("Vlgris");
            return _vlgris;
        }
        set
        {
            PropriedadeModificada("Vlgris", value);
            _vlgris = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 2)]
    public decimal? Vlicms
    {
        get
        {
            PropriedadeAcessada("Vlicms");
            return _vlicms;
        }
        set
        {
            PropriedadeModificada("Vlicms", value);
            _vlicms = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 2)]
    public decimal? Vlicmsantecipado
    {
        get
        {
            PropriedadeAcessada("Vlicmsantecipado");
            return _vlicmsantecipado;
        }
        set
        {
            PropriedadeModificada("Vlicmsantecipado", value);
            _vlicmsantecipado = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 2)]
    public decimal? Vlicmsstfrete
    {
        get
        {
            PropriedadeAcessada("Vlicmsstfrete");
            return _vlicmsstfrete;
        }
        set
        {
            PropriedadeModificada("Vlicmsstfrete", value);
            _vlicmsstfrete = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlinss
    {
        get
        {
            PropriedadeAcessada("Vlinss");
            return _vlinss;
        }
        set
        {
            PropriedadeModificada("Vlinss", value);
            _vlinss = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 2)]
    public decimal? Vlipi
    {
        get
        {
            PropriedadeAcessada("Vlipi");
            return _vlipi;
        }
        set
        {
            PropriedadeModificada("Vlipi", value);
            _vlipi = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlipioutras
    {
        get
        {
            PropriedadeAcessada("Vlipioutras");
            return _vlipioutras;
        }
        set
        {
            PropriedadeModificada("Vlipioutras", value);
            _vlipioutras = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlir
    {
        get
        {
            PropriedadeAcessada("Vlir");
            return _vlir;
        }
        set
        {
            PropriedadeModificada("Vlir", value);
            _vlir = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 2)]
    public decimal? Vlisentas
    {
        get
        {
            PropriedadeAcessada("Vlisentas");
            return _vlisentas;
        }
        set
        {
            PropriedadeModificada("Vlisentas", value);
            _vlisentas = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vliss
    {
        get
        {
            PropriedadeAcessada("Vliss");
            return _vliss;
        }
        set
        {
            PropriedadeModificada("Vliss", value);
            _vliss = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlltr
    {
        get
        {
            PropriedadeAcessada("Vlltr");
            return _vlltr;
        }
        set
        {
            PropriedadeModificada("Vlltr", value);
            _vlltr = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 2)]
    public decimal? Vloperacaofrete
    {
        get
        {
            PropriedadeAcessada("Vloperacaofrete");
            return _vloperacaofrete;
        }
        set
        {
            PropriedadeModificada("Vloperacaofrete", value);
            _vloperacaofrete = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 2)]
    public decimal? Vloutras
    {
        get
        {
            PropriedadeAcessada("Vloutras");
            return _vloutras;
        }
        set
        {
            PropriedadeModificada("Vloutras", value);
            _vloutras = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 2)]
    public decimal? Vloutrasdesp
    {
        get
        {
            PropriedadeAcessada("Vloutrasdesp");
            return _vloutrasdesp;
        }
        set
        {
            PropriedadeModificada("Vloutrasdesp", value);
            _vloutrasdesp = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 2)]
    public decimal? Vlpautafrete
    {
        get
        {
            PropriedadeAcessada("Vlpautafrete");
            return _vlpautafrete;
        }
        set
        {
            PropriedadeModificada("Vlpautafrete", value);
            _vlpautafrete = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlpedagio
    {
        get
        {
            PropriedadeAcessada("Vlpedagio");
            return _vlpedagio;
        }
        set
        {
            PropriedadeModificada("Vlpedagio", value);
            _vlpedagio = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlpis
    {
        get
        {
            PropriedadeAcessada("Vlpis");
            return _vlpis;
        }
        set
        {
            PropriedadeModificada("Vlpis", value);
            _vlpis = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 2)]
    public decimal? Vlpunitmed
    {
        get
        {
            PropriedadeAcessada("Vlpunitmed");
            return _vlpunitmed;
        }
        set
        {
            PropriedadeModificada("Vlpunitmed", value);
            _vlpunitmed = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 13, Precisao = 2)]
    public decimal? Vlraverbacao
    {
        get
        {
            PropriedadeAcessada("Vlraverbacao");
            return _vlraverbacao;
        }
        set
        {
            PropriedadeModificada("Vlraverbacao", value);
            _vlraverbacao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 2)]
    public decimal? Vlrecebidoboleto
    {
        get
        {
            PropriedadeAcessada("Vlrecebidoboleto");
            return _vlrecebidoboleto;
        }
        set
        {
            PropriedadeModificada("Vlrecebidoboleto", value);
            _vlrecebidoboleto = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 2)]
    public decimal? Vlrecebidocartao
    {
        get
        {
            PropriedadeAcessada("Vlrecebidocartao");
            return _vlrecebidocartao;
        }
        set
        {
            PropriedadeModificada("Vlrecebidocartao", value);
            _vlrecebidocartao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 2)]
    public decimal? Vlrecebidoch
    {
        get
        {
            PropriedadeAcessada("Vlrecebidoch");
            return _vlrecebidoch;
        }
        set
        {
            PropriedadeModificada("Vlrecebidoch", value);
            _vlrecebidoch = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 2)]
    public decimal? Vlrecebidodin
    {
        get
        {
            PropriedadeAcessada("Vlrecebidodin");
            return _vlrecebidodin;
        }
        set
        {
            PropriedadeModificada("Vlrecebidodin", value);
            _vlrecebidodin = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlseccat
    {
        get
        {
            PropriedadeAcessada("Vlseccat");
            return _vlseccat;
        }
        set
        {
            PropriedadeModificada("Vlseccat", value);
            _vlseccat = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 2)]
    public decimal? Vlseguro
    {
        get
        {
            PropriedadeAcessada("Vlseguro");
            return _vlseguro;
        }
        set
        {
            PropriedadeModificada("Vlseguro", value);
            _vlseguro = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 2)]
    public decimal? Vlstfreteretido
    {
        get
        {
            PropriedadeAcessada("Vlstfreteretido");
            return _vlstfreteretido;
        }
        set
        {
            PropriedadeModificada("Vlstfreteretido", value);
            _vlstfreteretido = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 2)]
    public decimal? Vlsubtotal
    {
        get
        {
            PropriedadeAcessada("Vlsubtotal");
            return _vlsubtotal;
        }
        set
        {
            PropriedadeModificada("Vlsubtotal", value);
            _vlsubtotal = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 2)]
    public decimal? Vltabela
    {
        get
        {
            PropriedadeAcessada("Vltabela");
            return _vltabela;
        }
        set
        {
            PropriedadeModificada("Vltabela", value);
            _vltabela = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 2)]
    public decimal? Vltas
    {
        get
        {
            PropriedadeAcessada("Vltas");
            return _vltas;
        }
        set
        {
            PropriedadeModificada("Vltas", value);
            _vltas = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 2)]
    public decimal? Vltotal
    {
        get
        {
            PropriedadeAcessada("Vltotal");
            return _vltotal;
        }
        set
        {
            PropriedadeModificada("Vltotal", value);
            _vltotal = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vltotalfcpicms
    {
        get
        {
            PropriedadeAcessada("Vltotalfcpicms");
            return _vltotalfcpicms;
        }
        set
        {
            PropriedadeModificada("Vltotalfcpicms", value);
            _vltotalfcpicms = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vltotalfcpst
    {
        get
        {
            PropriedadeAcessada("Vltotalfcpst");
            return _vltotalfcpst;
        }
        set
        {
            PropriedadeModificada("Vltotalfcpst", value);
            _vltotalfcpst = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 2)]
    public decimal? Vltotalnf
    {
        get
        {
            PropriedadeAcessada("Vltotalnf");
            return _vltotalnf;
        }
        set
        {
            PropriedadeModificada("Vltotalnf", value);
            _vltotalnf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 22, Precisao = 6)]
    public decimal? Vltotalnfcompoemcte
    {
        get
        {
            PropriedadeAcessada("Vltotalnfcompoemcte");
            return _vltotalnfcompoemcte;
        }
        set
        {
            PropriedadeModificada("Vltotalnfcompoemcte", value);
            _vltotalnfcompoemcte = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 2)]
    public decimal? Vltotalsemdescicms
    {
        get
        {
            PropriedadeAcessada("Vltotalsemdescicms");
            return _vltotalsemdescicms;
        }
        set
        {
            PropriedadeModificada("Vltotalsemdescicms", value);
            _vltotalsemdescicms = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 2)]
    public decimal? Vltotbrutoprodajuste
    {
        get
        {
            PropriedadeAcessada("Vltotbrutoprodajuste");
            return _vltotbrutoprodajuste;
        }
        set
        {
            PropriedadeModificada("Vltotbrutoprodajuste", value);
            _vltotbrutoprodajuste = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 2)]
    public decimal? Vltotger
    {
        get
        {
            PropriedadeAcessada("Vltotger");
            return _vltotger;
        }
        set
        {
            PropriedadeModificada("Vltotger", value);
            _vltotger = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vltranspautonomo
    {
        get
        {
            PropriedadeAcessada("Vltranspautonomo");
            return _vltranspautonomo;
        }
        set
        {
            PropriedadeModificada("Vltranspautonomo", value);
            _vltranspautonomo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 2)]
    public decimal? Vltributos
    {
        get
        {
            PropriedadeAcessada("Vltributos");
            return _vltributos;
        }
        set
        {
            PropriedadeModificada("Vltributos", value);
            _vltributos = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 2)]
    public decimal? Vltroco
    {
        get
        {
            PropriedadeAcessada("Vltroco");
            return _vltroco;
        }
        set
        {
            PropriedadeModificada("Vltroco", value);
            _vltroco = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlverbacmvcli
    {
        get
        {
            PropriedadeAcessada("Vlverbacmvcli");
            return _vlverbacmvcli;
        }
        set
        {
            PropriedadeModificada("Vlverbacmvcli", value);
            _vlverbacmvcli = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Wmscodfuncignora
    {
        get
        {
            PropriedadeAcessada("Wmscodfuncignora");
            return _wmscodfuncignora;
        }
        set
        {
            PropriedadeModificada("Wmscodfuncignora", value);
            _wmscodfuncignora = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Wmsignorado
    {
        get
        {
            PropriedadeAcessada("Wmsignorado");
            return _wmsignorado;
        }
        set
        {
            PropriedadeModificada("Wmsignorado", value);
            _wmsignorado = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 60, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFSAIDPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
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
        return "PCNFSAIDPREFAT";
    }

    public IEntidade NovaInstancia()
    {
        return (IEntidade)GetType().GetConstructors()[0].Invoke(null);
    }

    public void CarregarPorDataReader(IDataReader leitor)
    {
        _agenciapgtognre = AlterarTipo<string>(leitor["Agenciapgtognre"]);
        _agregarstprodsintegra = AlterarTipo<string>(leitor["Agregarstprodsintegra"]);
        _agregastvlmerc = AlterarTipo<string>(leitor["Agregastvlmerc"]);
        _aliqicmoutrasdesp = AlterarTipo<decimal?>(leitor["Aliqicmoutrasdesp"]);
        _aliquota = AlterarTipo<decimal?>(leitor["Aliquota"]);
        _ambiente = AlterarTipo<string>(leitor["Ambiente"]);
        _ambientecte = AlterarTipo<string>(leitor["Ambientecte"]);
        _ambientenfe = AlterarTipo<string>(leitor["Ambientenfe"]);
        _apresentoucupompromocao = AlterarTipo<string>(leitor["Apresentoucupompromocao"]);
        _assinatura = AlterarTipo<string>(leitor["Assinatura"]);
        _atacadista = AlterarTipo<string>(leitor["Atacadista"]);
        _autentpgtognre = AlterarTipo<string>(leitor["Autentpgtognre"]);
        _bairro = AlterarTipo<string>(leitor["Bairro"]);
        _bairrocoleta = AlterarTipo<string>(leitor["Bairrocoleta"]);
        _bancopgtognre = AlterarTipo<string>(leitor["Bancopgtognre"]);
        _bcst = AlterarTipo<decimal?>(leitor["Bcst"]);
        _bcstgnre = AlterarTipo<decimal?>(leitor["Bcstgnre"]);
        _broker = AlterarTipo<string>(leitor["Broker"]);
        _caixa = AlterarTipo<decimal>(leitor["Caixa"]);
        _cartaodotz = AlterarTipo<string>(leitor["Cartaodotz"]);
        _cep = AlterarTipo<string>(leitor["Cep"]);
        _cgc = AlterarTipo<string>(leitor["Cgc"]);
        _cgcfilial = AlterarTipo<string>(leitor["Cgcfilial"]);
        _cgcfrete = AlterarTipo<string>(leitor["Cgcfrete"]);
        _chavecte = AlterarTipo<string>(leitor["Chavecte"]);
        _chavecteanulacao = AlterarTipo<string>(leitor["Chavecteanulacao"]);
        _chavecteref = AlterarTipo<string>(leitor["Chavecteref"]);
        _chavectesubstituicao = AlterarTipo<string>(leitor["Chavectesubstituicao"]);
        _chavectetomadorsub = AlterarTipo<string>(leitor["Chavectetomadorsub"]);
        _chavenfe = AlterarTipo<string>(leitor["Chavenfe"]);
        _chavenfetomadorsub = AlterarTipo<string>(leitor["Chavenfetomadorsub"]);
        _chavesat = AlterarTipo<string>(leitor["Chavesat"]);
        _cliente = AlterarTipo<string>(leitor["Cliente"]);
        _clientefontest = AlterarTipo<string>(leitor["Clientefontest"]);
        _cnpjcisp = AlterarTipo<string>(leitor["Cnpjcisp"]);
        _cnpjcoleta = AlterarTipo<string>(leitor["Cnpjcoleta"]);
        _cnpjcpfcteref = AlterarTipo<string>(leitor["Cnpjcpfcteref"]);
        _cnpjcpfemitentesub = AlterarTipo<string>(leitor["Cnpjcpfemitentesub"]);
        _cnpjfornec = AlterarTipo<string>(leitor["Cnpjfornec"]);
        _cnpjfornecpedagio = AlterarTipo<string>(leitor["Cnpjfornecpedagio"]);
        _cnpjresponsavel = AlterarTipo<string>(leitor["Cnpjresponsavel"]);
        _cnpjseguradora = AlterarTipo<string>(leitor["Cnpjseguradora"]);
        _cobranca = AlterarTipo<string>(leitor["Cobranca"]);
        _codatv1 = AlterarTipo<decimal?>(leitor["Codatv1"]);
        _codautenticacao = AlterarTipo<string>(leitor["Codautenticacao"]);
        _codbnf = AlterarTipo<decimal?>(leitor["Codbnf"]);
        _codcidadecoleta = AlterarTipo<decimal?>(leitor["Codcidadecoleta"]);
        _codcli = AlterarTipo<decimal>(leitor["Codcli"]);
        _codclifilial = AlterarTipo<decimal?>(leitor["Codclifilial"]);
        _codclinf = AlterarTipo<decimal?>(leitor["Codclinf"]);
        _codclirecebedor = AlterarTipo<decimal?>(leitor["Codclirecebedor"]);
        _codcob = AlterarTipo<string>(leitor["Codcob"]);
        _codcobsefaz = AlterarTipo<string>(leitor["Codcobsefaz"]);
        _codcondicaovenda = AlterarTipo<decimal?>(leitor["Codcondicaovenda"]);
        _codconsignatariofrete = AlterarTipo<decimal?>(leitor["Codconsignatariofrete"]);
        _codcont = AlterarTipo<string>(leitor["Codcont"]);
        _codcontcli = AlterarTipo<decimal?>(leitor["Codcontcli"]);
        _codcontrato = AlterarTipo<decimal?>(leitor["Codcontrato"]);
        _coddestinatariofrete = AlterarTipo<decimal?>(leitor["Coddestinatariofrete"]);
        _coddevol = AlterarTipo<decimal?>(leitor["Coddevol"]);
        _coddoc = AlterarTipo<string>(leitor["Coddoc"]);
        _codedital = AlterarTipo<decimal?>(leitor["Codedital"]);
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
        _codfornecfretecteref = AlterarTipo<decimal?>(leitor["Codfornecfretecteref"]);
        _codfornecredespacho = AlterarTipo<decimal?>(leitor["Codfornecredespacho"]);
        _codfornectranspautonomo = AlterarTipo<decimal?>(leitor["Codfornectranspautonomo"]);
        _codfunccancel = AlterarTipo<decimal?>(leitor["Codfunccancel"]);
        _codfunclanc = AlterarTipo<decimal?>(leitor["Codfunclanc"]);
        _codfunclibent = AlterarTipo<decimal?>(leitor["Codfunclibent"]);
        _codfuncliberacaoentrega = AlterarTipo<decimal?>(leitor["Codfuncliberacaoentrega"]);
        _codgerente = AlterarTipo<decimal?>(leitor["Codgerente"]);
        _codibge = AlterarTipo<decimal?>(leitor["Codibge"]);
        _codmedicoprescrit = AlterarTipo<decimal?>(leitor["Codmedicoprescrit"]);
        _codmotorista = AlterarTipo<decimal?>(leitor["Codmotorista"]);
        _codmunfimcte = AlterarTipo<decimal?>(leitor["Codmunfimcte"]);
        _codmunicipio = AlterarTipo<decimal?>(leitor["Codmunicipio"]);
        _codmuninicte = AlterarTipo<decimal?>(leitor["Codmuninicte"]);
        _codpais = AlterarTipo<decimal?>(leitor["Codpais"]);
        _codplpag = AlterarTipo<decimal?>(leitor["Codplpag"]);
        _codplpagetico = AlterarTipo<decimal?>(leitor["Codplpagetico"]);
        _codplpaggenerico = AlterarTipo<decimal?>(leitor["Codplpaggenerico"]);
        _codpraca = AlterarTipo<decimal>(leitor["Codpraca"]);
        _codpracadestfrete = AlterarTipo<decimal?>(leitor["Codpracadestfrete"]);
        _codprodnfajuste = AlterarTipo<string>(leitor["Codprodnfajuste"]);
        _codprodpredominante = AlterarTipo<decimal?>(leitor["Codprodpredominante"]);
        _codpromocaomed = AlterarTipo<decimal?>(leitor["Codpromocaomed"]);
        _codrecebfretecteref = AlterarTipo<decimal?>(leitor["Codrecebfretecteref"]);
        _codremetentefrete = AlterarTipo<decimal?>(leitor["Codremetentefrete"]);
        _codretencaocprb = AlterarTipo<decimal?>(leitor["Codretencaocprb"]);
        _codsittribpiscofins = AlterarTipo<decimal?>(leitor["Codsittribpiscofins"]);
        _codstatussat = AlterarTipo<decimal?>(leitor["Codstatussat"]);
        _codsupervisor = AlterarTipo<decimal?>(leitor["Codsupervisor"]);
        _codsupervisor2 = AlterarTipo<decimal?>(leitor["Codsupervisor2"]);
        _codsupervisor3 = AlterarTipo<decimal?>(leitor["Codsupervisor3"]);
        _codtranspautonomo = AlterarTipo<decimal?>(leitor["Codtranspautonomo"]);
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
        _comissao2 = AlterarTipo<decimal?>(leitor["Comissao2"]);
        _comissao3 = AlterarTipo<decimal?>(leitor["Comissao3"]);
        _comissao4 = AlterarTipo<decimal?>(leitor["Comissao4"]);
        _comissaomot = AlterarTipo<decimal?>(leitor["Comissaomot"]);
        _comissaosup = AlterarTipo<decimal?>(leitor["Comissaosup"]);
        _complementocoleta = AlterarTipo<string>(leitor["Complementocoleta"]);
        _condfinanc = AlterarTipo<string>(leitor["Condfinanc"]);
        _condvenda = AlterarTipo<decimal?>(leitor["Condvenda"]);
        _conferido = AlterarTipo<string>(leitor["Conferido"]);
        _consumidorfinal = AlterarTipo<string>(leitor["Consumidorfinal"]);
        _consumiunumcte = AlterarTipo<string>(leitor["Consumiunumcte"]);
        _consumiunumnfe = AlterarTipo<string>(leitor["Consumiunumnfe"]);
        _contadorcupomfiscal = AlterarTipo<decimal?>(leitor["Contadorcupomfiscal"]);
        _contaordem = AlterarTipo<string>(leitor["Contaordem"]);
        _contribuinte = AlterarTipo<string>(leitor["Contribuinte"]);
        _cpnjresponsavelpedagio = AlterarTipo<string>(leitor["Cpnjresponsavelpedagio"]);
        _csllretido = AlterarTipo<string>(leitor["Csllretido"]);
        _ctecodtomadorservico = AlterarTipo<decimal?>(leitor["Ctecodtomadorservico"]);
        _ctecodtranspsubcontratado = AlterarTipo<decimal?>(leitor["Ctecodtranspsubcontratado"]);
        _ctecodtranspsubcontratante = AlterarTipo<decimal?>(leitor["Ctecodtranspsubcontratante"]);
        _ctecodveiculosubcontratante = AlterarTipo<decimal?>(leitor["Ctecodveiculosubcontratante"]);
        _cteglobalizado = AlterarTipo<string>(leitor["Cteglobalizado"]);
        _cteregimeespecial = AlterarTipo<string>(leitor["Cteregimeespecial"]);
        _ctesubcontratadochavecteref = AlterarTipo<string>(leitor["Ctesubcontratadochavecteref"]);
        _custobonificacao = AlterarTipo<string>(leitor["Custobonificacao"]);
        _dataconsolidacaoprefat = AlterarTipo<DateTime?>(leitor["Dataconsolidacaoprefat"]);
        _dataempenho = AlterarTipo<DateTime?>(leitor["Dataempenho"]);
        _datahoraemissaosat = AlterarTipo<DateTime?>(leitor["Datahoraemissaosat"]);
        _datahoraregistroepec = AlterarTipo<DateTime?>(leitor["Datahoraregistroepec"]);
        _deduzirdesonerorgaopub = AlterarTipo<string>(leitor["Deduzirdesonerorgaopub"]);
        _depositofechado = AlterarTipo<string>(leitor["Depositofechado"]);
        _descpais = AlterarTipo<string>(leitor["Descpais"]);
        _descricaoprodnfajuste = AlterarTipo<string>(leitor["Descricaoprodnfajuste"]);
        _despesasrateada = AlterarTipo<string>(leitor["Despesasrateada"]);
        _devsimbolica = AlterarTipo<string>(leitor["Devsimbolica"]);
        _digitoverificadornfse = AlterarTipo<string>(leitor["Digitoverificadornfse"]);
        _docemissao = AlterarTipo<string>(leitor["Docemissao"]);
        _dtahoraentradacontigencia = AlterarTipo<DateTime?>(leitor["Dtahoraentradacontigencia"]);
        _dta_horaenviosefaz = AlterarTipo<DateTime?>(leitor["Dta_Horaenviosefaz"]);
        _dtcancel = AlterarTipo<DateTime?>(leitor["Dtcancel"]);
        _dtcancelwms = AlterarTipo<DateTime?>(leitor["Dtcancelwms"]);
        _dtcanhoto = AlterarTipo<DateTime?>(leitor["Dtcanhoto"]);
        _dtdenegada = AlterarTipo<DateTime?>(leitor["Dtdenegada"]);
        _dtdevol = AlterarTipo<DateTime?>(leitor["Dtdevol"]);
        _dtemissaocteref = AlterarTipo<DateTime?>(leitor["Dtemissaocteref"]);
        _dtemissaodeclaracao = AlterarTipo<DateTime?>(leitor["Dtemissaodeclaracao"]);
        _dtemissaodocsub = AlterarTipo<DateTime?>(leitor["Dtemissaodocsub"]);
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
        _dtmovimentocx = AlterarTipo<DateTime?>(leitor["Dtmovimentocx"]);
        _dtnsu = AlterarTipo<DateTime?>(leitor["Dtnsu"]);
        _dtpagarrec = AlterarTipo<DateTime?>(leitor["Dtpagarrec"]);
        _dtpagcomissao = AlterarTipo<DateTime?>(leitor["Dtpagcomissao"]);
        _dtpagcomissaoop = AlterarTipo<DateTime?>(leitor["Dtpagcomissaoop"]);
        _dtpagcomissaoprof = AlterarTipo<DateTime?>(leitor["Dtpagcomissaoprof"]);
        _dtpagdotz = AlterarTipo<DateTime?>(leitor["Dtpagdotz"]);
        _dtpgtocampanha = AlterarTipo<DateTime?>(leitor["Dtpgtocampanha"]);
        _dtsaida = AlterarTipo<DateTime>(leitor["Dtsaida"]);
        _dtsaidanf = AlterarTipo<DateTime?>(leitor["Dtsaidanf"]);
        _dtvencarrec = AlterarTipo<DateTime?>(leitor["Dtvencarrec"]);
        _dtwms = AlterarTipo<DateTime?>(leitor["Dtwms"]);
        _emaildest = AlterarTipo<string>(leitor["Emaildest"]);
        _emailfrete = AlterarTipo<string>(leitor["Emailfrete"]);
        _emailfreteredespacho = AlterarTipo<string>(leitor["Emailfreteredespacho"]);
        _emissnumautomatico = AlterarTipo<string>(leitor["Emissnumautomatico"]);
        _endereco = AlterarTipo<string>(leitor["Endereco"]);
        _entrega = AlterarTipo<string>(leitor["Entrega"]);
        _enviada = AlterarTipo<string>(leitor["Enviada"]);
        _enviadanfe = AlterarTipo<string>(leitor["Enviadanfe"]);
        _enviadoemailcancelado = AlterarTipo<string>(leitor["Enviadoemailcancelado"]);
        _equiplanc = AlterarTipo<string>(leitor["Equiplanc"]);
        _especie = AlterarTipo<string>(leitor["Especie"]);
        _especievolume = AlterarTipo<string>(leitor["Especievolume"]);
        _exportadoservint = AlterarTipo<string>(leitor["Exportadoservint"]);
        _fil_montarkitautomaticamente = AlterarTipo<string>(leitor["Fil_Montarkitautomaticamente"]);
        _finalidadenfe = AlterarTipo<string>(leitor["Finalidadenfe"]);
        _formulario = AlterarTipo<decimal?>(leitor["Formulario"]);
        _fornecentrega = AlterarTipo<string>(leitor["Fornecentrega"]);
        _fretedespacho = AlterarTipo<string>(leitor["Fretedespacho"]);
        _freteredespacho = AlterarTipo<string>(leitor["Freteredespacho"]);
        _funclanc = AlterarTipo<string>(leitor["Funclanc"]);
        _geracaorazaoauxiliar = AlterarTipo<string>(leitor["Geracaorazaoauxiliar"]);
        _geracp = AlterarTipo<string>(leitor["Geracp"]);
        _geranfvenda = AlterarTipo<string>(leitor["Geranfvenda"]);
        _gerarbcrnfe = AlterarTipo<string>(leitor["Gerarbcrnfe"]);
        _gerarcptranspaunotomo = AlterarTipo<string>(leitor["Gerarcptranspaunotomo"]);
        _historico = AlterarTipo<string>(leitor["Historico"]);
        _horaemissao = AlterarTipo<string>(leitor["Horaemissao"]);
        _horaentrega = AlterarTipo<decimal?>(leitor["Horaentrega"]);
        _horalanc = AlterarTipo<string>(leitor["Horalanc"]);
        _horasaida = AlterarTipo<decimal?>(leitor["Horasaida"]);
        _icmsretido = AlterarTipo<decimal?>(leitor["Icmsretido"]);
        _icmsretidognre = AlterarTipo<decimal?>(leitor["Icmsretidognre"]);
        _identificarclientenfce = AlterarTipo<string>(leitor["Identificarclientenfce"]);
        _idlocaldestmerc = AlterarTipo<string>(leitor["Idlocaldestmerc"]);
        _idparceiro = AlterarTipo<string>(leitor["Idparceiro"]);
        _idtipopresenca = AlterarTipo<string>(leitor["Idtipopresenca"]);
        _ie = AlterarTipo<string>(leitor["Ie"]);
        _iecteref = AlterarTipo<string>(leitor["Iecteref"]);
        _ieent = AlterarTipo<string>(leitor["Ieent"]);
        _iefilial = AlterarTipo<string>(leitor["Iefilial"]);
        _iefrete = AlterarTipo<string>(leitor["Iefrete"]);
        _iesubsttribut = AlterarTipo<string>(leitor["Iesubsttribut"]);
        _importadoservprinc = AlterarTipo<string>(leitor["Importadoservprinc"]);
        _imprimiudactejuntodanfe = AlterarTipo<string>(leitor["Imprimiudactejuntodanfe"]);
        _indicprestserv = AlterarTipo<decimal?>(leitor["Indicprestserv"]);
        _infglobalizado = AlterarTipo<string>(leitor["Infglobalizado"]);
        _inssretido = AlterarTipo<string>(leitor["Inssretido"]);
        _inutilizada = AlterarTipo<string>(leitor["Inutilizada"]);
        _irrretido = AlterarTipo<string>(leitor["Irrretido"]);
        _justificativacontigencia = AlterarTipo<string>(leitor["Justificativacontigencia"]);
        _kmfinalentrega = AlterarTipo<decimal?>(leitor["Kmfinalentrega"]);
        _linknfse = AlterarTipo<string>(leitor["Linknfse"]);
        _localdesembaraco = AlterarTipo<string>(leitor["Localdesembaraco"]);
        _logradourocoleta = AlterarTipo<string>(leitor["Logradourocoleta"]);
        _lotedpec = AlterarTipo<string>(leitor["Lotedpec"]);
        _marcarvolume = AlterarTipo<string>(leitor["Marcarvolume"]);
        _md5listaarq = AlterarTipo<string>(leitor["Md5listaarq"]);
        _md5paf = AlterarTipo<string>(leitor["Md5paf"]);
        _mensagempiscofins = AlterarTipo<string>(leitor["Mensagempiscofins"]);
        _minutoentrega = AlterarTipo<decimal?>(leitor["Minutoentrega"]);
        _minutolanc = AlterarTipo<string>(leitor["Minutolanc"]);
        _minutosaida = AlterarTipo<decimal?>(leitor["Minutosaida"]);
        _modelodocsub = AlterarTipo<string>(leitor["Modelodocsub"]);
        _motestornonfe = AlterarTipo<string>(leitor["Motestornonfe"]);
        _motoristaveiculo = AlterarTipo<string>(leitor["Motoristaveiculo"]);
        _municipio = AlterarTipo<string>(leitor["Municipio"]);
        _natopernfe = AlterarTipo<string>(leitor["Natopernfe"]);
        _ncmnfajuste = AlterarTipo<string>(leitor["Ncmnfajuste"]);
        _nfatualwms = AlterarTipo<string>(leitor["Nfatualwms"]);
        _nfdeventfutura = AlterarTipo<string>(leitor["Nfdeventfutura"]);
        _nffornec = AlterarTipo<decimal?>(leitor["Nffornec"]);
        _nomearquivodotz = AlterarTipo<string>(leitor["Nomearquivodotz"]);
        _nomearquivodotzestorno = AlterarTipo<string>(leitor["Nomearquivodotzestorno"]);
        _nomeseguradora = AlterarTipo<string>(leitor["Nomeseguradora"]);
        _normaregespecial = AlterarTipo<string>(leitor["Normaregespecial"]);
        _notadupliquesvc = AlterarTipo<string>(leitor["Notadupliquesvc"]);
        _nsu = AlterarTipo<decimal?>(leitor["Nsu"]);
        _nsusociotorcedor = AlterarTipo<string>(leitor["Nsusociotorcedor"]);
        _numcaixafiscal = AlterarTipo<decimal?>(leitor["Numcaixafiscal"]);
        _numcar = AlterarTipo<decimal?>(leitor["Numcar"]);
        _numcaranterior = AlterarTipo<decimal?>(leitor["Numcaranterior"]);
        _numcargaedi = AlterarTipo<decimal?>(leitor["Numcargaedi"]);
        _numchaveexp = AlterarTipo<string>(leitor["Numchaveexp"]);
        _numcirurgia = AlterarTipo<decimal?>(leitor["Numcirurgia"]);
        _numcoleta = AlterarTipo<string>(leitor["Numcoleta"]);
        _numcomprovante = AlterarTipo<decimal?>(leitor["Numcomprovante"]);
        _numcontrato = AlterarTipo<decimal?>(leitor["Numcontrato"]);
        _numcontratocarreteiro = AlterarTipo<string>(leitor["Numcontratocarreteiro"]);
        _numcupom = AlterarTipo<decimal?>(leitor["Numcupom"]);
        _numdocarrec = AlterarTipo<string>(leitor["Numdocarrec"]);
        _numdoccteref = AlterarTipo<string>(leitor["Numdoccteref"]);
        _numdrawback = AlterarTipo<decimal?>(leitor["Numdrawback"]);
        _numecf = AlterarTipo<decimal?>(leitor["Numecf"]);
        _numempenho = AlterarTipo<string>(leitor["Numempenho"]);
        _numendereco = AlterarTipo<string>(leitor["Numendereco"]);
        _numeroapolice = AlterarTipo<string>(leitor["Numeroapolice"]);
        _numeroaverbacao = AlterarTipo<string>(leitor["Numeroaverbacao"]);
        _numerocoleta = AlterarTipo<string>(leitor["Numerocoleta"]);
        _numerodocsub = AlterarTipo<decimal?>(leitor["Numerodocsub"]);
        _numerorps = AlterarTipo<decimal?>(leitor["Numerorps"]);
        _numfechamentomovcx = AlterarTipo<decimal?>(leitor["Numfechamentomovcx"]);
        _numformulario = AlterarTipo<decimal?>(leitor["Numformulario"]);
        _numidf = AlterarTipo<string>(leitor["Numidf"]);
        _numitens = AlterarTipo<decimal?>(leitor["Numitens"]);
        _numlanccp = AlterarTipo<decimal?>(leitor["Numlanccp"]);
        _numlista = AlterarTipo<decimal?>(leitor["Numlista"]);
        _numlotecte = AlterarTipo<string>(leitor["Numlotecte"]);
        _numlotenfe = AlterarTipo<string>(leitor["Numlotenfe"]);
        _numnftransf = AlterarTipo<decimal?>(leitor["Numnftransf"]);
        _numnota = AlterarTipo<decimal?>(leitor["Numnota"]);
        _numnotamanif = AlterarTipo<decimal?>(leitor["Numnotamanif"]);
        _numnotanfse = AlterarTipo<decimal?>(leitor["Numnotanfse"]);
        _numnotaorigem = AlterarTipo<decimal?>(leitor["Numnotaorigem"]);
        _numnotavinculada = AlterarTipo<decimal?>(leitor["Numnotavinculada"]);
        _numop = AlterarTipo<decimal?>(leitor["Numop"]);
        _numorca = AlterarTipo<decimal?>(leitor["Numorca"]);
        _numorcafilial = AlterarTipo<decimal?>(leitor["Numorcafilial"]);
        _numos = AlterarTipo<decimal?>(leitor["Numos"]);
        _numped = AlterarTipo<decimal?>(leitor["Numped"]);
        _numpedcli = AlterarTipo<string>(leitor["Numpedcli"]);
        _numpedvanxml = AlterarTipo<string>(leitor["Numpedvanxml"]);
        _numprevenda = AlterarTipo<decimal?>(leitor["Numprevenda"]);
        _numregexp = AlterarTipo<decimal?>(leitor["Numregexp"]);
        _numregiao = AlterarTipo<decimal?>(leitor["Numregiao"]);
        _numregiaofrete = AlterarTipo<decimal?>(leitor["Numregiaofrete"]);
        _numremessa = AlterarTipo<decimal?>(leitor["Numremessa"]);
        _numselonf = AlterarTipo<decimal?>(leitor["Numselonf"]);
        _numseq = AlterarTipo<decimal?>(leitor["Numseq"]);
        _numseqentrega = AlterarTipo<decimal?>(leitor["Numseqentrega"]);
        _numseqmontagem = AlterarTipo<decimal?>(leitor["Numseqmontagem"]);
        _numserieequip = AlterarTipo<string>(leitor["Numserieequip"]);
        _numseriesat = AlterarTipo<string>(leitor["Numseriesat"]);
        _numtab = AlterarTipo<decimal?>(leitor["Numtab"]);
        _numtranscteanul = AlterarTipo<decimal?>(leitor["Numtranscteanul"]);
        _numtransctesubs = AlterarTipo<decimal?>(leitor["Numtransctesubs"]);
        _numtransentdependente = AlterarTipo<decimal?>(leitor["Numtransentdependente"]);
        _numtransentdest = AlterarTipo<decimal?>(leitor["Numtransentdest"]);
        _numtransentnfestornada = AlterarTipo<decimal?>(leitor["Numtransentnfestornada"]);
        _numtransentorigconsig = AlterarTipo<decimal?>(leitor["Numtransentorigconsig"]);
        _numtransentorigem = AlterarTipo<decimal?>(leitor["Numtransentorigem"]);
        _numtransvenda = AlterarTipo<decimal>(leitor["Numtransvenda"]);
        _numtransvendaconhec = AlterarTipo<decimal?>(leitor["Numtransvendaconhec"]);
        _numtransvendadependente = AlterarTipo<decimal?>(leitor["Numtransvendadependente"]);
        _numtransvendadestino = AlterarTipo<decimal?>(leitor["Numtransvendadestino"]);
        _numtransvendaecf = AlterarTipo<decimal?>(leitor["Numtransvendaecf"]);
        _numtransvendaorigem = AlterarTipo<decimal?>(leitor["Numtransvendaorigem"]);
        _numtransvendatv13 = AlterarTipo<decimal?>(leitor["Numtransvendatv13"]);
        _numvalepedagio = AlterarTipo<string>(leitor["Numvalepedagio"]);
        _numvias = AlterarTipo<decimal?>(leitor["Numvias"]);
        _numviasgnre = AlterarTipo<decimal?>(leitor["Numviasgnre"]);
        _numviaspu = AlterarTipo<decimal?>(leitor["Numviaspu"]);
        _numvolume = AlterarTipo<decimal?>(leitor["Numvolume"]);
        _obs = AlterarTipo<string>(leitor["Obs"]);
        _obsconhecfrete = AlterarTipo<string>(leitor["Obsconhecfrete"]);
        _obsexp = AlterarTipo<string>(leitor["Obsexp"]);
        _obsnfajuste = AlterarTipo<string>(leitor["Obsnfajuste"]);
        _obsnfcarreg = AlterarTipo<string>(leitor["Obsnfcarreg"]);
        _obsnfe = AlterarTipo<string>(leitor["Obsnfe"]);
        _obspiscofins = AlterarTipo<string>(leitor["Obspiscofins"]);
        _orgaopub = AlterarTipo<string>(leitor["Orgaopub"]);
        _orgaopubfederal = AlterarTipo<string>(leitor["Orgaopubfederal"]);
        _orgaopubmunicipal = AlterarTipo<string>(leitor["Orgaopubmunicipal"]);
        _origemfrete = AlterarTipo<string>(leitor["Origemfrete"]);
        _pagchequemoradia = AlterarTipo<string>(leitor["Pagchequemoradia"]);
        _perbaseredoutrasdesp = AlterarTipo<decimal?>(leitor["Perbaseredoutrasdesp"]);
        _perccomprofissional = AlterarTipo<decimal?>(leitor["Perccomprofissional"]);
        _percentualstfrete = AlterarTipo<decimal?>(leitor["Percentualstfrete"]);
        _percfrete = AlterarTipo<decimal?>(leitor["Percfrete"]);
        _percfreteretido = AlterarTipo<decimal?>(leitor["Percfreteretido"]);
        _percicmfrete = AlterarTipo<decimal?>(leitor["Percicmfrete"]);
        _percofins = AlterarTipo<decimal?>(leitor["Percofins"]);
        _percstfreteretido = AlterarTipo<decimal?>(leitor["Percstfreteretido"]);
        _perdescfin = AlterarTipo<decimal?>(leitor["Perdescfin"]);
        _perdescfintot = AlterarTipo<decimal?>(leitor["Perdescfintot"]);
        _perpis = AlterarTipo<decimal?>(leitor["Perpis"]);
        _pisretido = AlterarTipo<string>(leitor["Pisretido"]);
        _placaveic = AlterarTipo<string>(leitor["Placaveic"]);
        _planosuppli = AlterarTipo<decimal?>(leitor["Planosuppli"]);
        _pontosdotz = AlterarTipo<decimal?>(leitor["Pontosdotz"]);
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
        _prazoadicional = AlterarTipo<decimal?>(leitor["Prazoadicional"]);
        _prazomedio = AlterarTipo<decimal?>(leitor["Prazomedio"]);
        _prazoponderado = AlterarTipo<string>(leitor["Prazoponderado"]);
        _protocolo = AlterarTipo<string>(leitor["Protocolo"]);
        _protocolocancelamento = AlterarTipo<string>(leitor["Protocolocancelamento"]);
        _protocolocancelamentocte = AlterarTipo<string>(leitor["Protocolocancelamentocte"]);
        _protocolocte = AlterarTipo<string>(leitor["Protocolocte"]);
        _protocolonfe = AlterarTipo<string>(leitor["Protocolonfe"]);
        _protocolonfeauto = AlterarTipo<string>(leitor["Protocolonfeauto"]);
        _protocolonfecan = AlterarTipo<string>(leitor["Protocolonfecan"]);
        _protocolonfeepec = AlterarTipo<string>(leitor["Protocolonfeepec"]);
        _protocolonfse = AlterarTipo<string>(leitor["Protocolonfse"]);
        _qrcodenfce = AlterarTipo<string>(leitor["Qrcodenfce"]);
        _qrcodesat = AlterarTipo<string>(leitor["Qrcodesat"]);
        _qtdereproccte = AlterarTipo<decimal?>(leitor["Qtdereproccte"]);
        _qtdereprocnfe = AlterarTipo<decimal?>(leitor["Qtdereprocnfe"]);
        _razaosocialcoleta = AlterarTipo<string>(leitor["Razaosocialcoleta"]);
        _razaosocialcteref = AlterarTipo<string>(leitor["Razaosocialcteref"]);
        _recarga = AlterarTipo<string>(leitor["Recarga"]);
        _recibocte = AlterarTipo<string>(leitor["Recibocte"]);
        _recibodpec = AlterarTipo<string>(leitor["Recibodpec"]);
        _recibonfe = AlterarTipo<string>(leitor["Recibonfe"]);
        _reservaritenstv7 = AlterarTipo<string>(leitor["Reservaritenstv7"]);
        _respseguro = AlterarTipo<decimal?>(leitor["Respseguro"]);
        _rotinacad = AlterarTipo<string>(leitor["Rotinacad"]);
        _rotinacadcte = AlterarTipo<string>(leitor["Rotinacadcte"]);
        _rotinalanc = AlterarTipo<string>(leitor["Rotinalanc"]);
        _selo = AlterarTipo<string>(leitor["Selo"]);
        _serie = AlterarTipo<string>(leitor["Serie"]);
        _seriedoccteref = AlterarTipo<string>(leitor["Seriedoccteref"]);
        _seriedocsub = AlterarTipo<string>(leitor["Seriedocsub"]);
        _serieecf = AlterarTipo<string>(leitor["Serieecf"]);
        _serieoriginal = AlterarTipo<string>(leitor["Serieoriginal"]);
        _serierps = AlterarTipo<string>(leitor["Serierps"]);
        _simplesnacional = AlterarTipo<string>(leitor["Simplesnacional"]);
        _sitdoc = AlterarTipo<string>(leitor["Sitdoc"]);
        _situacaocte = AlterarTipo<decimal?>(leitor["Situacaocte"]);
        _situacaonfe = AlterarTipo<decimal?>(leitor["Situacaonfe"]);
        _situacaonfeepec = AlterarTipo<decimal?>(leitor["Situacaonfeepec"]);
        _situacaonfeorig = AlterarTipo<decimal?>(leitor["Situacaonfeorig"]);
        _situacaonfse = AlterarTipo<decimal?>(leitor["Situacaonfse"]);
        _situacaosat = AlterarTipo<string>(leitor["Situacaosat"]);
        _stribut = AlterarTipo<decimal?>(leitor["Stribut"]);
        _subserie = AlterarTipo<string>(leitor["Subserie"]);
        _subseriedoccteref = AlterarTipo<string>(leitor["Subseriedoccteref"]);
        _subseriedocsub = AlterarTipo<string>(leitor["Subseriedocsub"]);
        _sulframa = AlterarTipo<string>(leitor["Sulframa"]);
        _taxaentrega = AlterarTipo<decimal?>(leitor["Taxaentrega"]);
        _telefone = AlterarTipo<string>(leitor["Telefone"]);
        _tentativaenviocte = AlterarTipo<decimal?>(leitor["Tentativaenviocte"]);
        _tentativaenvionfe = AlterarTipo<decimal?>(leitor["Tentativaenvionfe"]);
        _tipoaliqoutrasdesp = AlterarTipo<string>(leitor["Tipoaliqoutrasdesp"]);
        _tipocontacorrente = AlterarTipo<string>(leitor["Tipocontacorrente"]);
        _tipodevol = AlterarTipo<string>(leitor["Tipodevol"]);
        _tipodocarrecgnre = AlterarTipo<string>(leitor["Tipodocarrecgnre"]);
        _tipodoccteref = AlterarTipo<string>(leitor["Tipodoccteref"]);
        _tipodocumentosub = AlterarTipo<string>(leitor["Tipodocumentosub"]);
        _tipoemissao = AlterarTipo<string>(leitor["Tipoemissao"]);
        _tipoemissaocte = AlterarTipo<string>(leitor["Tipoemissaocte"]);
        _tipoempresa = AlterarTipo<string>(leitor["Tipoempresa"]);
        _tipofj = AlterarTipo<string>(leitor["Tipofj"]);
        _tipofrete = AlterarTipo<string>(leitor["Tipofrete"]);
        _tipoinscprestserv = AlterarTipo<decimal?>(leitor["Tipoinscprestserv"]);
        _tipomovgarantia = AlterarTipo<decimal?>(leitor["Tipomovgarantia"]);
        _tipopresencaadquirinte = AlterarTipo<string>(leitor["Tipopresencaadquirinte"]);
        _tiporemessa = AlterarTipo<string>(leitor["Tiporemessa"]);
        _tiposervicocte = AlterarTipo<string>(leitor["Tiposervicocte"]);
        _tiposubcontratacaocte = AlterarTipo<string>(leitor["Tiposubcontratacaocte"]);
        _tipotransfentredeposito = AlterarTipo<string>(leitor["Tipotransfentredeposito"]);
        _tipovenda = AlterarTipo<string>(leitor["Tipovenda"]);
        _tomadorcte = AlterarTipo<decimal?>(leitor["Tomadorcte"]);
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
        _transfdep = AlterarTipo<string>(leitor["Transfdep"]);
        _transpautonomo = AlterarTipo<string>(leitor["Transpautonomo"]);
        _transportadora = AlterarTipo<string>(leitor["Transportadora"]);
        _uf = AlterarTipo<string>(leitor["Uf"]);
        _ufbeneficiaria = AlterarTipo<string>(leitor["Ufbeneficiaria"]);
        _ufcodigo = AlterarTipo<string>(leitor["Ufcodigo"]);
        _ufcteref = AlterarTipo<string>(leitor["Ufcteref"]);
        _ufdesembaraco = AlterarTipo<string>(leitor["Ufdesembaraco"]);
        _uffilial = AlterarTipo<string>(leitor["Uffilial"]);
        _uffrete = AlterarTipo<string>(leitor["Uffrete"]);
        _ufplacavei = AlterarTipo<string>(leitor["Ufplacavei"]);
        _ufplacaveic = AlterarTipo<string>(leitor["Ufplacaveic"]);
        _uidregistro = AlterarTipo<decimal?>(leitor["Uidregistro"]);
        _unidadenfajuste = AlterarTipo<string>(leitor["Unidadenfajuste"]);
        _usaintegracaowms = AlterarTipo<string>(leitor["Usaintegracaowms"]);
        _usamultuniditem = AlterarTipo<string>(leitor["Usamultuniditem"]);
        _utilizaexpdiversos = AlterarTipo<string>(leitor["Utilizaexpdiversos"]);
        _utilizaipicalcicms = AlterarTipo<string>(leitor["Utilizaipicalcicms"]);
        _valordocsub = AlterarTipo<decimal?>(leitor["Valordocsub"]);
        _valorpedagio = AlterarTipo<decimal?>(leitor["Valorpedagio"]);
        _valorst = AlterarTipo<decimal?>(leitor["Valorst"]);
        _vendaassistida = AlterarTipo<string>(leitor["Vendaassistida"]);
        _vendaexportacao = AlterarTipo<string>(leitor["Vendaexportacao"]);
        _vendanfseried = AlterarTipo<string>(leitor["Vendanfseried"]);
        _vendatriangular = AlterarTipo<string>(leitor["Vendatriangular"]);
        _versaorotina = AlterarTipo<string>(leitor["Versaorotina"]);
        _vlbase = AlterarTipo<decimal?>(leitor["Vlbase"]);
        _vlbaseipi = AlterarTipo<decimal?>(leitor["Vlbaseipi"]);
        _vlbasepiscofins = AlterarTipo<decimal?>(leitor["Vlbasepiscofins"]);
        _vlbaseretencao = AlterarTipo<decimal?>(leitor["Vlbaseretencao"]);
        _vlbasestfrete = AlterarTipo<decimal?>(leitor["Vlbasestfrete"]);
        _vlboleto = AlterarTipo<decimal?>(leitor["Vlboleto"]);
        _vlbonific = AlterarTipo<decimal?>(leitor["Vlbonific"]);
        _vlbonificacerto = AlterarTipo<decimal?>(leitor["Vlbonificacerto"]);
        _vlcofins = AlterarTipo<decimal?>(leitor["Vlcofins"]);
        _vlcsll = AlterarTipo<decimal?>(leitor["Vlcsll"]);
        _vlcustocont = AlterarTipo<decimal?>(leitor["Vlcustocont"]);
        _vlcustofin = AlterarTipo<decimal?>(leitor["Vlcustofin"]);
        _vlcustoreal = AlterarTipo<decimal?>(leitor["Vlcustoreal"]);
        _vlcustorep = AlterarTipo<decimal?>(leitor["Vlcustorep"]);
        _vldescabatimento = AlterarTipo<decimal?>(leitor["Vldescabatimento"]);
        _vldescfin = AlterarTipo<decimal?>(leitor["Vldescfin"]);
        _vldescicms = AlterarTipo<decimal?>(leitor["Vldescicms"]);
        _vldesconto = AlterarTipo<decimal?>(leitor["Vldesconto"]);
        _vldescprom = AlterarTipo<decimal?>(leitor["Vldescprom"]);
        _vldescsociotorcedor = AlterarTipo<decimal?>(leitor["Vldescsociotorcedor"]);
        _vldespacho = AlterarTipo<decimal?>(leitor["Vldespacho"]);
        _vldespdentronf = AlterarTipo<decimal?>(leitor["Vldespdentronf"]);
        _vldesppedagio = AlterarTipo<decimal?>(leitor["Vldesppedagio"]);
        _vldevolucao = AlterarTipo<decimal?>(leitor["Vldevolucao"]);
        _vldocarrecadacao = AlterarTipo<decimal?>(leitor["Vldocarrecadacao"]);
        _vlfrete = AlterarTipo<decimal?>(leitor["Vlfrete"]);
        _vlfretenf = AlterarTipo<decimal?>(leitor["Vlfretenf"]);
        _vlfreteoutrasdesp = AlterarTipo<decimal?>(leitor["Vlfreteoutrasdesp"]);
        _vlfreteretido = AlterarTipo<decimal?>(leitor["Vlfreteretido"]);
        _vlgris = AlterarTipo<decimal?>(leitor["Vlgris"]);
        _vlicms = AlterarTipo<decimal?>(leitor["Vlicms"]);
        _vlicmsantecipado = AlterarTipo<decimal?>(leitor["Vlicmsantecipado"]);
        _vlicmsstfrete = AlterarTipo<decimal?>(leitor["Vlicmsstfrete"]);
        _vlinss = AlterarTipo<decimal?>(leitor["Vlinss"]);
        _vlipi = AlterarTipo<decimal?>(leitor["Vlipi"]);
        _vlipioutras = AlterarTipo<decimal?>(leitor["Vlipioutras"]);
        _vlir = AlterarTipo<decimal?>(leitor["Vlir"]);
        _vlisentas = AlterarTipo<decimal?>(leitor["Vlisentas"]);
        _vliss = AlterarTipo<decimal?>(leitor["Vliss"]);
        _vlltr = AlterarTipo<decimal?>(leitor["Vlltr"]);
        _vloperacaofrete = AlterarTipo<decimal?>(leitor["Vloperacaofrete"]);
        _vloutras = AlterarTipo<decimal?>(leitor["Vloutras"]);
        _vloutrasdesp = AlterarTipo<decimal?>(leitor["Vloutrasdesp"]);
        _vlpautafrete = AlterarTipo<decimal?>(leitor["Vlpautafrete"]);
        _vlpedagio = AlterarTipo<decimal?>(leitor["Vlpedagio"]);
        _vlpis = AlterarTipo<decimal?>(leitor["Vlpis"]);
        _vlpunitmed = AlterarTipo<decimal?>(leitor["Vlpunitmed"]);
        _vlraverbacao = AlterarTipo<decimal?>(leitor["Vlraverbacao"]);
        _vlrecebidoboleto = AlterarTipo<decimal?>(leitor["Vlrecebidoboleto"]);
        _vlrecebidocartao = AlterarTipo<decimal?>(leitor["Vlrecebidocartao"]);
        _vlrecebidoch = AlterarTipo<decimal?>(leitor["Vlrecebidoch"]);
        _vlrecebidodin = AlterarTipo<decimal?>(leitor["Vlrecebidodin"]);
        _vlseccat = AlterarTipo<decimal?>(leitor["Vlseccat"]);
        _vlseguro = AlterarTipo<decimal?>(leitor["Vlseguro"]);
        _vlstfreteretido = AlterarTipo<decimal?>(leitor["Vlstfreteretido"]);
        _vlsubtotal = AlterarTipo<decimal?>(leitor["Vlsubtotal"]);
        _vltabela = AlterarTipo<decimal?>(leitor["Vltabela"]);
        _vltas = AlterarTipo<decimal?>(leitor["Vltas"]);
        _vltotal = AlterarTipo<decimal?>(leitor["Vltotal"]);
        _vltotalfcpicms = AlterarTipo<decimal?>(leitor["Vltotalfcpicms"]);
        _vltotalfcpst = AlterarTipo<decimal?>(leitor["Vltotalfcpst"]);
        _vltotalnf = AlterarTipo<decimal?>(leitor["Vltotalnf"]);
        _vltotalnfcompoemcte = AlterarTipo<decimal?>(leitor["Vltotalnfcompoemcte"]);
        _vltotalsemdescicms = AlterarTipo<decimal?>(leitor["Vltotalsemdescicms"]);
        _vltotbrutoprodajuste = AlterarTipo<decimal?>(leitor["Vltotbrutoprodajuste"]);
        _vltotger = AlterarTipo<decimal?>(leitor["Vltotger"]);
        _vltranspautonomo = AlterarTipo<decimal?>(leitor["Vltranspautonomo"]);
        _vltributos = AlterarTipo<decimal?>(leitor["Vltributos"]);
        _vltroco = AlterarTipo<decimal?>(leitor["Vltroco"]);
        _vlverbacmvcli = AlterarTipo<decimal?>(leitor["Vlverbacmvcli"]);
        _wmscodfuncignora = AlterarTipo<decimal?>(leitor["Wmscodfuncignora"]);
        _wmsignorado = AlterarTipo<string>(leitor["Wmsignorado"]);
        _indicadordesconto = AlterarTipo<string>(leitor["Indicadordesconto"]);
        _indicadoracrescimo = AlterarTipo<string>(leitor["Indicadoracrescimo"]);
        _cnpjintermediador = AlterarTipo<string>(leitor["Cnpjintermediador"]);
        _descintermediador = AlterarTipo<string>(leitor["Descintermediador"]);
    }

}