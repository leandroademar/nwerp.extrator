

////// namespace nwErp.Entidades.Winthor;

// namespace nwErp.Api.Modelos;

[Serializable]
public class PCORCAVENDAC : GerenteDePropriedades, IEntidade
{
    private static readonly string RO_ASSINATURA = "Assinatura";

    private string _assinatura;

    private static readonly string RO_BAIRRO = "Bairro";

    private string _bairro;

    private static readonly string RO_BROKER = "Broker";

    private string _broker;

    private static readonly string RO_CAMPANHA = "Campanha";

    private string _campanha;

    private static readonly string RO_CARTAOFIDELIDADE = "Cartaofidelidade";

    private string _cartaofidelidade;

    private static readonly string RO_CIDADE = "Cidade";

    private string _cidade;

    private static readonly string RO_CLIENTE = "Cliente";

    private string _cliente;

    private static readonly string RO_CNPJ = "Cnpj";

    private string _cnpj;

    private static readonly string RO_CODATV1 = "Codatv1";

    private decimal? _codatv1;

    private static readonly string RO_CODCLI = "Codcli";

    private decimal _codcli;

    private static readonly string RO_CODCLINF = "Codclinf";

    private decimal? _codclinf;

    private static readonly string RO_CODCLIRECEBEDOR = "Codclirecebedor";

    private decimal? _codclirecebedor;

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

    private static readonly string RO_CODFILIALRETIRA1 = "Codfilialretira1";

    private string _codfilialretira1;

    private static readonly string RO_CODFILIALRETIRA2 = "Codfilialretira2";

    private string _codfilialretira2;

    private static readonly string RO_CODFILIALRETIRA3 = "Codfilialretira3";

    private string _codfilialretira3;

    private static readonly string RO_CODFORNECFRETE = "Codfornecfrete";

    private decimal? _codfornecfrete;

    private static readonly string RO_CODFORNECREDESPACHO = "Codfornecredespacho";

    private decimal? _codfornecredespacho;

    private static readonly string RO_CODFUNCCALCFRETE = "Codfunccalcfrete";

    private decimal? _codfunccalcfrete;

    private static readonly string RO_CODFUNCCANCEL = "Codfunccancel";

    private decimal? _codfunccancel;

    private static readonly string RO_CODMOTBLOQUEIO = "Codmotbloqueio";

    private decimal? _codmotbloqueio;

    private static readonly string RO_CODMOTIVO = "Codmotivo";

    private decimal? _codmotivo;

    private static readonly string RO_CODPLPAG = "Codplpag";

    private decimal _codplpag;

    private static readonly string RO_CODPRACA = "Codpraca";

    private decimal _codpraca;

    private static readonly string RO_CODPRACADESTINO = "Codpracadestino";

    private decimal? _codpracadestino;

    private static readonly string RO_CODPROFISSIONAL = "Codprofissional";

    private decimal? _codprofissional;

    private static readonly string RO_CODSUPERVISOR = "Codsupervisor";

    private decimal _codsupervisor;

    private static readonly string RO_CODTRANSP = "Codtransp";

    private decimal? _codtransp;

    private static readonly string RO_CODUSUR = "Codusur";

    private decimal _codusur;

    private static readonly string RO_CODUSUR2 = "Codusur2";

    private decimal? _codusur2;

    private static readonly string RO_CODUSUR3 = "Codusur3";

    private decimal? _codusur3;

    private static readonly string RO_CODUSUR4 = "Codusur4";

    private decimal? _codusur4;

    private static readonly string RO_CODVISITA = "Codvisita";

    private decimal? _codvisita;

    private static readonly string RO_CONCILIAIMPORTACAO = "Conciliaimportacao";

    private string _conciliaimportacao;

    private static readonly string RO_CONDVENDA = "Condvenda";

    private decimal? _condvenda;

    private static readonly string RO_CONDVENDADESTINO = "Condvendadestino";

    private decimal? _condvendadestino;

    private static readonly string RO_CONVERTIDOPEDIDO = "Convertidopedido";

    private string _convertidopedido;

    private static readonly string RO_CUSTOENTREGA = "Custoentrega";

    private decimal? _custoentrega;

    private static readonly string RO_DATA = "Data";

    private DateTime _data;

    private static readonly string RO_DATAHORA_PRIMEIRODOCUMENTO_ECF = "Datahora_Primeirodocumento_Ecf";

    private string _datahora_primeirodocumento_ecf;

    private static readonly string RO_DATAPEDCLI = "Datapedcli";

    private DateTime? _datapedcli;

    private static readonly string RO_DTAGENDAENTREGA = "Dtagendaentrega";

    private DateTime? _dtagendaentrega;

    private static readonly string RO_DTCALCFRETE = "Dtcalcfrete";

    private DateTime? _dtcalcfrete;

    private static readonly string RO_DTCANCEL = "Dtcancel";

    private DateTime? _dtcancel;

    private static readonly string RO_DTENTREGA = "Dtentrega";

    private DateTime? _dtentrega;

    private static readonly string RO_DTEXPORTACAO = "Dtexportacao";

    private DateTime? _dtexportacao;

    private static readonly string RO_DTIMPORTACAO = "Dtimportacao";

    private DateTime? _dtimportacao;

    private static readonly string RO_DTLIBERA = "Dtlibera";

    private DateTime? _dtlibera;

    private static readonly string RO_DTVALIDADE = "Dtvalidade";

    private DateTime? _dtvalidade;

    private static readonly string RO_DTVENC1 = "Dtvenc1";

    private DateTime? _dtvenc1;

    private static readonly string RO_DTVENC2 = "Dtvenc2";

    private DateTime? _dtvenc2;

    private static readonly string RO_DTVENC3 = "Dtvenc3";

    private DateTime? _dtvenc3;

    private static readonly string RO_DUPLICADO = "Duplicado";

    private string _duplicado;

    private static readonly string RO_EANCOBRANCA = "Eancobranca";

    private decimal? _eancobranca;

    private static readonly string RO_EANENTREGA = "Eanentrega";

    private decimal? _eanentrega;

    private static readonly string RO_ENDERECO = "Endereco";

    private string _endereco;

    private static readonly string RO_ESPECIEMANIF = "Especiemanif";

    private string _especiemanif;

    private static readonly string RO_ESTOQUEVENDAVALERESERVADO = "Estoquevendavalereservado";

    private string _estoquevendavalereservado;

    private static readonly string RO_EXPORTADO = "Exportado";

    private string _exportado;

    private static readonly string RO_FRETEDESPACHO = "Fretedespacho";

    private string _fretedespacho;

    private static readonly string RO_FRETEREDESPACHO = "Freteredespacho";

    private string _freteredespacho;

    private static readonly string RO_GERACP = "Geracp";

    private string _geracp;

    private static readonly string RO_GERARCONTROLEDEENTREGA = "Gerarcontroledeentrega";

    private string _gerarcontroledeentrega;

    private static readonly string RO_HORA = "Hora";

    private decimal? _hora;

    private static readonly string RO_IE = "Ie";

    private string _ie;

    private static readonly string RO_LISTA_MD5_2030MG = "Lista_Md5_2030mg";

    private string _lista_md5_2030mg;

    private static readonly string RO_LOCALDESEMBARACO = "Localdesembaraco";

    private string _localdesembaraco;

    private static readonly string RO_LOG = "Log";

    private string _log;

    private static readonly string RO_MARGEM = "Margem";

    private decimal? _margem;

    private static readonly string RO_MINUTO = "Minuto";

    private decimal? _minuto;

    private static readonly string RO_MONTANDO = "Montando";

    private string _montando;

    private static readonly string RO_MOTIVOPOSICAO = "Motivoposicao";

    private string _motivoposicao;

    private static readonly string RO_NEGOCIADO = "Negociado";

    private string _negociado;

    private static readonly string RO_NUMCAIXA = "Numcaixa";

    private decimal? _numcaixa;

    private static readonly string RO_NUMCAR = "Numcar";

    private decimal _numcar;

    private static readonly string RO_NUMCARMANIF = "Numcarmanif";

    private decimal? _numcarmanif;

    private static readonly string RO_NUMCCF = "Numccf";

    private decimal? _numccf;

    private static readonly string RO_NUMCUPOM = "Numcupom";

    private decimal? _numcupom;

    private static readonly string RO_NUMDAV = "Numdav";

    private decimal? _numdav;

    private static readonly string RO_NUMEROORCAMENTO = "Numeroorcamento";

    private decimal? _numeroorcamento;

    private static readonly string RO_NUMFICHA = "Numficha";

    private decimal? _numficha;

    private static readonly string RO_NUMITENS = "Numitens";

    private decimal? _numitens;

    private static readonly string RO_NUMNOTA = "Numnota";

    private decimal? _numnota;

    private static readonly string RO_NUMNOTAMANIF = "Numnotamanif";

    private decimal? _numnotamanif;

    private static readonly string RO_NUMORCA = "Numorca";

    private decimal _numorca;

    private static readonly string RO_NUMORCAENTFUT = "Numorcaentfut";

    private decimal? _numorcaentfut;

    private static readonly string RO_NUMORCAFILIAL = "Numorcafilial";

    private decimal? _numorcafilial;

    private static readonly string RO_NUMORCAORIGEM = "Numorcaorigem";

    private decimal? _numorcaorigem;

    private static readonly string RO_NUMORCAPRINC = "Numorcaprinc";

    private decimal? _numorcaprinc;

    private static readonly string RO_NUMPED = "Numped";

    private decimal? _numped;

    private static readonly string RO_NUMPEDBNF = "Numpedbnf";

    private decimal? _numpedbnf;

    private static readonly string RO_NUMPEDCLI = "Numpedcli";

    private string _numpedcli;

    private static readonly string RO_NUMPEDECF = "Numpedecf";

    private decimal? _numpedecf;

    private static readonly string RO_NUMPEDENTFUT = "Numpedentfut";

    private decimal? _numpedentfut;

    private static readonly string RO_NUMPEDRCA = "Numpedrca";

    private decimal? _numpedrca;

    private static readonly string RO_NUMPREVENDA = "Numprevenda";

    private decimal? _numprevenda;

    private static readonly string RO_NUMREGIAO = "Numregiao";

    private decimal? _numregiao;

    private static readonly string RO_NUMREGIAOAVULSA = "Numregiaoavulsa";

    private decimal? _numregiaoavulsa;

    private static readonly string RO_NUMSEQENTREGA = "Numseqentrega";

    private decimal? _numseqentrega;

    private static readonly string RO_NUMSERIEEQUIP = "Numserieequip";

    private string _numserieequip;

    private static readonly string RO_NUMTABELA = "Numtabela";

    private string _numtabela;

    private static readonly string RO_NUMTRANSVENDA = "Numtransvenda";

    private decimal? _numtransvenda;

    private static readonly string RO_OBS = "Obs";

    private string _obs;

    private static readonly string RO_OBSENTREGA1 = "Obsentrega1";

    private string _obsentrega1;

    private static readonly string RO_OBSENTREGA2 = "Obsentrega2";

    private string _obsentrega2;

    private static readonly string RO_OBSENTREGA3 = "Obsentrega3";

    private string _obsentrega3;

    private static readonly string RO_OBS1 = "Obs1";

    private string _obs1;

    private static readonly string RO_OBS2 = "Obs2";

    private string _obs2;

    private static readonly string RO_OPERACAO = "Operacao";

    private string _operacao;

    private static readonly string RO_ORCADOPOR = "Orcadopor";

    private string _orcadopor;

    private static readonly string RO_ORCAGERADODEVALES = "Orcageradodevales";

    private string _orcageradodevales;

    private static readonly string RO_ORCAMENTOUTILIZADO = "Orcamentoutilizado";

    private string _orcamentoutilizado;

    private static readonly string RO_ORCASALVO = "Orcasalvo";

    private string _orcasalvo;

    private static readonly string RO_ORIGEMPED = "Origemped";

    private string _origemped;

    private static readonly string RO_PERCCOMPROFISSIONAL = "Perccomprofissional";

    private decimal? _perccomprofissional;

    private static readonly string RO_PERCDESCATIV = "Percdescativ";

    private decimal? _percdescativ;

    private static readonly string RO_PERCVENDA = "Percvenda";

    private decimal? _percvenda;

    private static readonly string RO_PERDESC = "Perdesc";

    private decimal? _perdesc;

    private static readonly string RO_PERDESCFIN = "Perdescfin";

    private decimal? _perdescfin;

    private static readonly string RO_PERDESCTOTAL = "Perdesctotal";

    private decimal? _perdesctotal;

    private static readonly string RO_PLACAVEICULO = "Placaveiculo";

    private string _placaveiculo;

    private static readonly string RO_POSICAO = "Posicao";

    private string _posicao;

    private static readonly string RO_PRAZOMEDIO = "Prazomedio";

    private decimal? _prazomedio;

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

    private static readonly string RO_RESERVARITENSTV7 = "Reservaritenstv7";

    private string _reservaritenstv7;

    private static readonly string RO_RESTRICAOTRANSP = "Restricaotransp";

    private string _restricaotransp;

    private static readonly string RO_ROTINALANC = "Rotinalanc";

    private string _rotinalanc;

    private static readonly string RO_SELECIONAREGIAOAVULSA = "Selecionaregiaoavulsa";

    private string _selecionaregiaoavulsa;

    private static readonly string RO_SERIEECF = "Serieecf";

    private string _serieecf;

    private static readonly string RO_SERIEMANIF = "Seriemanif";

    private string _seriemanif;

    private static readonly string RO_TELEFONE = "Telefone";

    private string _telefone;

    private static readonly string RO_TIPOCARGA = "Tipocarga";

    private string _tipocarga;

    private static readonly string RO_TIPODOC = "Tipodoc";

    private string _tipodoc;

    private static readonly string RO_TIPODOCUMENTO = "Tipodocumento";

    private string _tipodocumento;

    private static readonly string RO_TIPOEMBALAGEM = "Tipoembalagem";

    private string _tipoembalagem;

    private static readonly string RO_TIPONFDESTINO = "Tiponfdestino";

    private string _tiponfdestino;

    private static readonly string RO_TIPOOPER = "Tipooper";

    private string _tipooper;

    private static readonly string RO_TIPOORCAMENTO = "Tipoorcamento";

    private string _tipoorcamento;

    private static readonly string RO_TIPOPRIORIDADEENTREGA = "Tipoprioridadeentrega";

    private string _tipoprioridadeentrega;

    private static readonly string RO_TIPORETIRADA = "Tiporetirada";

    private string _tiporetirada;

    private static readonly string RO_TIPOVENDA = "Tipovenda";

    private string _tipovenda;

    private static readonly string RO_TOTPESO = "Totpeso";

    private decimal? _totpeso;

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

    private static readonly string RO_TRIBUTAPORREGIAOFILIAL = "Tributaporregiaofilial";

    private string _tributaporregiaofilial;

    private static readonly string RO_UF = "Uf";

    private string _uf;

    private static readonly string RO_UFDESEMBARACO = "Ufdesembaraco";

    private string _ufdesembaraco;

    private static readonly string RO_USACFOPVENDANATV10 = "Usacfopvendanatv10";

    private string _usacfopvendanatv10;

    private static readonly string RO_USAINTEGRACAOWMS = "Usaintegracaowms";

    private string _usaintegracaowms;

    private static readonly string RO_VALORDESCFIN = "Valordescfin";

    private decimal? _valordescfin;

    private static readonly string RO_VENDAASSISTIDA = "Vendaassistida";

    private string _vendaassistida;

    private static readonly string RO_VENDATRIANGULAR = "Vendatriangular";

    private string _vendatriangular;

    private static readonly string RO_VLATEND = "Vlatend";

    private decimal? _vlatend;

    private static readonly string RO_VLCUSTOCONT = "Vlcustocont";

    private decimal? _vlcustocont;

    private static readonly string RO_VLCUSTOFIN = "Vlcustofin";

    private decimal? _vlcustofin;

    private static readonly string RO_VLCUSTOREAL = "Vlcustoreal";

    private decimal? _vlcustoreal;

    private static readonly string RO_VLCUSTOREP = "Vlcustorep";

    private decimal? _vlcustorep;

    private static readonly string RO_VLDESCONTO = "Vldesconto";

    private decimal? _vldesconto;

    private static readonly string RO_VLDESCONTOTOTAL = "Vldescontototal";

    private decimal? _vldescontototal;

    private static readonly string RO_VLENTRADA = "Vlentrada";

    private decimal? _vlentrada;

    private static readonly string RO_VLFRETE = "Vlfrete";

    private decimal? _vlfrete;

    private static readonly string RO_VLOUTRASDESP = "Vloutrasdesp";

    private decimal? _vloutrasdesp;

    private static readonly string RO_VLTABELA = "Vltabela";

    private decimal? _vltabela;

    private static readonly string RO_VLTOTAL = "Vltotal";

    private decimal? _vltotal;

    private static readonly string RO_TIPOIMPR = "Tipoimpr";

    private string _tipoimpr;

    private static readonly string RO_CARTAOCRM = "Cartaocrm";

    private string _cartaocrm;

    private static readonly string RO_NFCE = "Nfce";

    private string _nfce;

    private static readonly string RO_COOCONF = "Cooconf";

    private string _cooconf;

    private string _md5paf;

    private string _bloqueio_paf;

    private string _indicadordesconto;

    private string _indicadoracrescimo;

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 255, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Cartaofidelidade
    {
        get
        {
            PropriedadeAcessada(RO_CARTAOFIDELIDADE);
            return _cartaofidelidade;
        }
        set
        {
            PropriedadeModificada(RO_CARTAOFIDELIDADE, value);
            _cartaofidelidade = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 80, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 18, Precisao = 0)]
    public string Cnpj
    {
        get
        {
            PropriedadeAcessada(RO_CNPJ);
            return _cnpj;
        }
        set
        {
            PropriedadeModificada(RO_CNPJ, value);
            _cnpj = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 3, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Codfilialretira1
    {
        get
        {
            PropriedadeAcessada(RO_CODFILIALRETIRA1);
            return _codfilialretira1;
        }
        set
        {
            PropriedadeModificada(RO_CODFILIALRETIRA1, value);
            _codfilialretira1 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Codfilialretira2
    {
        get
        {
            PropriedadeAcessada(RO_CODFILIALRETIRA2);
            return _codfilialretira2;
        }
        set
        {
            PropriedadeModificada(RO_CODFILIALRETIRA2, value);
            _codfilialretira2 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Codfilialretira3
    {
        get
        {
            PropriedadeAcessada(RO_CODFILIALRETIRA3);
            return _codfilialretira3;
        }
        set
        {
            PropriedadeModificada(RO_CODFILIALRETIRA3, value);
            _codfilialretira3 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 0)]
    public decimal? Condvendadestino
    {
        get
        {
            PropriedadeAcessada(RO_CONDVENDADESTINO);
            return _condvendadestino;
        }
        set
        {
            PropriedadeModificada(RO_CONDVENDADESTINO, value);
            _condvendadestino = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Convertidopedido
    {
        get
        {
            PropriedadeAcessada(RO_CONVERTIDOPEDIDO);
            return _convertidopedido;
        }
        set
        {
            PropriedadeModificada(RO_CONVERTIDOPEDIDO, value);
            _convertidopedido = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 2)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 19, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Duplicado
    {
        get
        {
            PropriedadeAcessada(RO_DUPLICADO);
            return _duplicado;
        }
        set
        {
            PropriedadeModificada(RO_DUPLICADO, value);
            _duplicado = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Estoquevendavalereservado
    {
        get
        {
            PropriedadeAcessada(RO_ESTOQUEVENDAVALERESERVADO);
            return _estoquevendavalereservado;
        }
        set
        {
            PropriedadeModificada(RO_ESTOQUEVENDAVALERESERVADO, value);
            _estoquevendavalereservado = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 2, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 18, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
    public string Lista_Md5_2030mg
    {
        get
        {
            PropriedadeAcessada(RO_LISTA_MD5_2030MG);
            return _lista_md5_2030mg;
        }
        set
        {
            PropriedadeModificada(RO_LISTA_MD5_2030MG, value);
            _lista_md5_2030mg = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 30, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Binario, Tamanho = 4000, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 2)]
    public decimal? Margem
    {
        get
        {
            PropriedadeAcessada(RO_MARGEM);
            return _margem;
        }
        set
        {
            PropriedadeModificada(RO_MARGEM, value);
            _margem = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 2, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 50, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 13, Precisao = 0)]
    public decimal? Numdav
    {
        get
        {
            PropriedadeAcessada(RO_NUMDAV);
            return _numdav;
        }
        set
        {
            PropriedadeModificada(RO_NUMDAV, value);
            _numdav = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Numeroorcamento
    {
        get
        {
            PropriedadeAcessada(RO_NUMEROORCAMENTO);
            return _numeroorcamento;
        }
        set
        {
            PropriedadeModificada(RO_NUMEROORCAMENTO, value);
            _numeroorcamento = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Numficha
    {
        get
        {
            PropriedadeAcessada(RO_NUMFICHA);
            return _numficha;
        }
        set
        {
            PropriedadeModificada(RO_NUMFICHA, value);
            _numficha = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal Numorca
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numorcaentfut
    {
        get
        {
            PropriedadeAcessada(RO_NUMORCAENTFUT);
            return _numorcaentfut;
        }
        set
        {
            PropriedadeModificada(RO_NUMORCAENTFUT, value);
            _numorcaentfut = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numorcaorigem
    {
        get
        {
            PropriedadeAcessada(RO_NUMORCAORIGEM);
            return _numorcaorigem;
        }
        set
        {
            PropriedadeModificada(RO_NUMORCAORIGEM, value);
            _numorcaorigem = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 15, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Numregiaoavulsa
    {
        get
        {
            PropriedadeAcessada(RO_NUMREGIAOAVULSA);
            return _numregiaoavulsa;
        }
        set
        {
            PropriedadeModificada(RO_NUMREGIAOAVULSA, value);
            _numregiaoavulsa = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 20, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 30, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 25, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 75, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 75, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 75, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 50, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 50, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 60, Precisao = 0)]
    public string Orcadopor
    {
        get
        {
            PropriedadeAcessada(RO_ORCADOPOR);
            return _orcadopor;
        }
        set
        {
            PropriedadeModificada(RO_ORCADOPOR, value);
            _orcadopor = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Orcageradodevales
    {
        get
        {
            PropriedadeAcessada(RO_ORCAGERADODEVALES);
            return _orcageradodevales;
        }
        set
        {
            PropriedadeModificada(RO_ORCAGERADODEVALES, value);
            _orcageradodevales = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Orcamentoutilizado
    {
        get
        {
            PropriedadeAcessada(RO_ORCAMENTOUTILIZADO);
            return _orcamentoutilizado;
        }
        set
        {
            PropriedadeModificada(RO_ORCAMENTOUTILIZADO, value);
            _orcamentoutilizado = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Orcasalvo
    {
        get
        {
            PropriedadeAcessada(RO_ORCASALVO);
            return _orcasalvo;
        }
        set
        {
            PropriedadeModificada(RO_ORCASALVO, value);
            _orcasalvo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 2)]
    public decimal? Percdescativ
    {
        get
        {
            PropriedadeAcessada(RO_PERCDESCATIV);
            return _percdescativ;
        }
        set
        {
            PropriedadeModificada(RO_PERCDESCATIV, value);
            _percdescativ = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 2)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Perdesctotal
    {
        get
        {
            PropriedadeAcessada(RO_PERDESCTOTAL);
            return _perdesctotal;
        }
        set
        {
            PropriedadeModificada(RO_PERDESCTOTAL, value);
            _perdesctotal = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 10, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 48, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Selecionaregiaoavulsa
    {
        get
        {
            PropriedadeAcessada(RO_SELECIONAREGIAOAVULSA);
            return _selecionaregiaoavulsa;
        }
        set
        {
            PropriedadeModificada(RO_SELECIONAREGIAOAVULSA, value);
            _selecionaregiaoavulsa = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 13, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Tipodoc
    {
        get
        {
            PropriedadeAcessada(RO_TIPODOC);
            return _tipodoc;
        }
        set
        {
            PropriedadeModificada(RO_TIPODOC, value);
            _tipodoc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Tiponfdestino
    {
        get
        {
            PropriedadeAcessada(RO_TIPONFDESTINO);
            return _tiponfdestino;
        }
        set
        {
            PropriedadeModificada(RO_TIPONFDESTINO, value);
            _tiponfdestino = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Tipoorcamento
    {
        get
        {
            PropriedadeAcessada(RO_TIPOORCAMENTO);
            return _tipoorcamento;
        }
        set
        {
            PropriedadeModificada(RO_TIPOORCAMENTO, value);
            _tipoorcamento = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 2)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 3)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 16, Precisao = 3)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 2)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 2)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 2)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 2)]
    public decimal? Vldescontototal
    {
        get
        {
            PropriedadeAcessada(RO_VLDESCONTOTOTAL);
            return _vldescontototal;
        }
        set
        {
            PropriedadeModificada(RO_VLDESCONTOTOTAL, value);
            _vldescontototal = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 16, Precisao = 3)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 2)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 2)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 19, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 19, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Tipoimpr
    {
        get
        {
            PropriedadeAcessada(RO_TIPOIMPR);
            return _tipoimpr;
        }
        set
        {
            PropriedadeModificada(RO_TIPOIMPR, value);
            _tipoimpr = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 19, Precisao = 0)]
    public string Cartaocrm
    {
        get
        {
            PropriedadeAcessada(RO_CARTAOCRM);
            return _cartaocrm;
        }
        set
        {
            PropriedadeModificada(RO_CARTAOCRM, value);
            _cartaocrm = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Nfce
    {
        get
        {
            PropriedadeAcessada(RO_NFCE);
            return _nfce;
        }
        set
        {
            PropriedadeModificada(RO_NFCE, value);
            _nfce = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 6, Precisao = 0)]
    public string Cooconf
    {
        get
        {
            PropriedadeAcessada(RO_COOCONF);
            return _cooconf;
        }
        set
        {
            PropriedadeModificada(RO_COOCONF, value);
            _cooconf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 200, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Bloqueio_Paf
    {
        get
        {
            PropriedadeAcessada("Bloqueio_Paf");
            return _bloqueio_paf;
        }
        set
        {
            PropriedadeModificada("Bloqueio_Paf", value);
            _bloqueio_paf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    public void InicializarAtributos()
    {
    }

    public string ObterNomeTabela()
    {
        return "PCORCAVENDAC";
    }

    public IEntidade NovaInstancia()
    {
        return (IEntidade)GetType().GetConstructors()[0].Invoke(null);
    }

    public void CarregarPorDataReader(IDataReader leitor)
    {
        _assinatura = AlterarTipo<string>(leitor["Assinatura"]);
        _bairro = AlterarTipo<string>(leitor["Bairro"]);
        _broker = AlterarTipo<string>(leitor["Broker"]);
        _campanha = AlterarTipo<string>(leitor["Campanha"]);
        _cartaofidelidade = AlterarTipo<string>(leitor["Cartaofidelidade"]);
        _cidade = AlterarTipo<string>(leitor["Cidade"]);
        _cliente = AlterarTipo<string>(leitor["Cliente"]);
        _cnpj = AlterarTipo<string>(leitor["Cnpj"]);
        _codatv1 = AlterarTipo<decimal?>(leitor["Codatv1"]);
        _codcli = AlterarTipo<decimal>(leitor["Codcli"]);
        _codclinf = AlterarTipo<decimal?>(leitor["Codclinf"]);
        _codclirecebedor = AlterarTipo<decimal?>(leitor["Codclirecebedor"]);
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
        _codfilialretira1 = AlterarTipo<string>(leitor["Codfilialretira1"]);
        _codfilialretira2 = AlterarTipo<string>(leitor["Codfilialretira2"]);
        _codfilialretira3 = AlterarTipo<string>(leitor["Codfilialretira3"]);
        _codfornecfrete = AlterarTipo<decimal?>(leitor["Codfornecfrete"]);
        _codfornecredespacho = AlterarTipo<decimal?>(leitor["Codfornecredespacho"]);
        _codfunccalcfrete = AlterarTipo<decimal?>(leitor["Codfunccalcfrete"]);
        _codfunccancel = AlterarTipo<decimal?>(leitor["Codfunccancel"]);
        _codmotbloqueio = AlterarTipo<decimal?>(leitor["Codmotbloqueio"]);
        _codmotivo = AlterarTipo<decimal?>(leitor["Codmotivo"]);
        _codplpag = AlterarTipo<decimal>(leitor["Codplpag"]);
        _codpraca = AlterarTipo<decimal>(leitor["Codpraca"]);
        _codpracadestino = AlterarTipo<decimal?>(leitor["Codpracadestino"]);
        _codprofissional = AlterarTipo<decimal?>(leitor["Codprofissional"]);
        _codsupervisor = AlterarTipo<decimal>(leitor["Codsupervisor"]);
        _codtransp = AlterarTipo<decimal?>(leitor["Codtransp"]);
        _codusur = AlterarTipo<decimal>(leitor["Codusur"]);
        _codusur2 = AlterarTipo<decimal?>(leitor["Codusur2"]);
        _codusur3 = AlterarTipo<decimal?>(leitor["Codusur3"]);
        _codusur4 = AlterarTipo<decimal?>(leitor["Codusur4"]);
        _codvisita = AlterarTipo<decimal?>(leitor["Codvisita"]);
        _conciliaimportacao = AlterarTipo<string>(leitor["Conciliaimportacao"]);
        _condvenda = AlterarTipo<decimal?>(leitor["Condvenda"]);
        _condvendadestino = AlterarTipo<decimal?>(leitor["Condvendadestino"]);
        _convertidopedido = AlterarTipo<string>(leitor["Convertidopedido"]);
        _custoentrega = AlterarTipo<decimal?>(leitor["Custoentrega"]);
        _data = AlterarTipo<DateTime>(leitor["Data"]);
        _datahora_primeirodocumento_ecf = AlterarTipo<string>(leitor["Datahora_Primeirodocumento_Ecf"]);
        _datapedcli = AlterarTipo<DateTime?>(leitor["Datapedcli"]);
        _dtagendaentrega = AlterarTipo<DateTime?>(leitor["Dtagendaentrega"]);
        _dtcalcfrete = AlterarTipo<DateTime?>(leitor["Dtcalcfrete"]);
        _dtcancel = AlterarTipo<DateTime?>(leitor["Dtcancel"]);
        _dtentrega = AlterarTipo<DateTime?>(leitor["Dtentrega"]);
        _dtexportacao = AlterarTipo<DateTime?>(leitor["Dtexportacao"]);
        _dtimportacao = AlterarTipo<DateTime?>(leitor["Dtimportacao"]);
        _dtlibera = AlterarTipo<DateTime?>(leitor["Dtlibera"]);
        _dtvalidade = AlterarTipo<DateTime?>(leitor["Dtvalidade"]);
        _dtvenc1 = AlterarTipo<DateTime?>(leitor["Dtvenc1"]);
        _dtvenc2 = AlterarTipo<DateTime?>(leitor["Dtvenc2"]);
        _dtvenc3 = AlterarTipo<DateTime?>(leitor["Dtvenc3"]);
        _duplicado = AlterarTipo<string>(leitor["Duplicado"]);
        _eancobranca = AlterarTipo<decimal?>(leitor["Eancobranca"]);
        _eanentrega = AlterarTipo<decimal?>(leitor["Eanentrega"]);
        _endereco = AlterarTipo<string>(leitor["Endereco"]);
        _especiemanif = AlterarTipo<string>(leitor["Especiemanif"]);
        _estoquevendavalereservado = AlterarTipo<string>(leitor["Estoquevendavalereservado"]);
        _exportado = AlterarTipo<string>(leitor["Exportado"]);
        _fretedespacho = AlterarTipo<string>(leitor["Fretedespacho"]);
        _freteredespacho = AlterarTipo<string>(leitor["Freteredespacho"]);
        _geracp = AlterarTipo<string>(leitor["Geracp"]);
        _gerarcontroledeentrega = AlterarTipo<string>(leitor["Gerarcontroledeentrega"]);
        _hora = AlterarTipo<decimal?>(leitor["Hora"]);
        _ie = AlterarTipo<string>(leitor["Ie"]);
        _lista_md5_2030mg = AlterarTipo<string>(leitor["Lista_Md5_2030mg"]);
        _localdesembaraco = AlterarTipo<string>(leitor["Localdesembaraco"]);
        _log = AlterarTipo<string>(leitor["Log"]);
        _margem = AlterarTipo<decimal?>(leitor["Margem"]);
        _minuto = AlterarTipo<decimal?>(leitor["Minuto"]);
        _montando = AlterarTipo<string>(leitor["Montando"]);
        _motivoposicao = AlterarTipo<string>(leitor["Motivoposicao"]);
        _negociado = AlterarTipo<string>(leitor["Negociado"]);
        _numcaixa = AlterarTipo<decimal?>(leitor["Numcaixa"]);
        _numcar = AlterarTipo<decimal>(leitor["Numcar"]);
        _numcarmanif = AlterarTipo<decimal?>(leitor["Numcarmanif"]);
        _numccf = AlterarTipo<decimal?>(leitor["Numccf"]);
        _numcupom = AlterarTipo<decimal?>(leitor["Numcupom"]);
        _numdav = AlterarTipo<decimal?>(leitor["Numdav"]);
        _numeroorcamento = AlterarTipo<decimal?>(leitor["Numeroorcamento"]);
        _numficha = AlterarTipo<decimal?>(leitor["Numficha"]);
        _numitens = AlterarTipo<decimal?>(leitor["Numitens"]);
        _numnota = AlterarTipo<decimal?>(leitor["Numnota"]);
        _numnotamanif = AlterarTipo<decimal?>(leitor["Numnotamanif"]);
        _numorca = AlterarTipo<decimal>(leitor["Numorca"]);
        _numorcaentfut = AlterarTipo<decimal?>(leitor["Numorcaentfut"]);
        _numorcafilial = AlterarTipo<decimal?>(leitor["Numorcafilial"]);
        _numorcaorigem = AlterarTipo<decimal?>(leitor["Numorcaorigem"]);
        _numorcaprinc = AlterarTipo<decimal?>(leitor["Numorcaprinc"]);
        _numped = AlterarTipo<decimal?>(leitor["Numped"]);
        _numpedbnf = AlterarTipo<decimal?>(leitor["Numpedbnf"]);
        _numpedcli = AlterarTipo<string>(leitor["Numpedcli"]);
        _numpedecf = AlterarTipo<decimal?>(leitor["Numpedecf"]);
        _numpedentfut = AlterarTipo<decimal?>(leitor["Numpedentfut"]);
        _numpedrca = AlterarTipo<decimal?>(leitor["Numpedrca"]);
        _numprevenda = AlterarTipo<decimal?>(leitor["Numprevenda"]);
        _numregiao = AlterarTipo<decimal?>(leitor["Numregiao"]);
        _numregiaoavulsa = AlterarTipo<decimal?>(leitor["Numregiaoavulsa"]);
        _numseqentrega = AlterarTipo<decimal?>(leitor["Numseqentrega"]);
        _numserieequip = AlterarTipo<string>(leitor["Numserieequip"]);
        _numtabela = AlterarTipo<string>(leitor["Numtabela"]);
        _numtransvenda = AlterarTipo<decimal?>(leitor["Numtransvenda"]);
        _obs = AlterarTipo<string>(leitor["Obs"]);
        _obsentrega1 = AlterarTipo<string>(leitor["Obsentrega1"]);
        _obsentrega2 = AlterarTipo<string>(leitor["Obsentrega2"]);
        _obsentrega3 = AlterarTipo<string>(leitor["Obsentrega3"]);
        _obs1 = AlterarTipo<string>(leitor["Obs1"]);
        _obs2 = AlterarTipo<string>(leitor["Obs2"]);
        _operacao = AlterarTipo<string>(leitor["Operacao"]);
        _orcadopor = AlterarTipo<string>(leitor["Orcadopor"]);
        _orcageradodevales = AlterarTipo<string>(leitor["Orcageradodevales"]);
        _orcamentoutilizado = AlterarTipo<string>(leitor["Orcamentoutilizado"]);
        _orcasalvo = AlterarTipo<string>(leitor["Orcasalvo"]);
        _origemped = AlterarTipo<string>(leitor["Origemped"]);
        _perccomprofissional = AlterarTipo<decimal?>(leitor["Perccomprofissional"]);
        _percdescativ = AlterarTipo<decimal?>(leitor["Percdescativ"]);
        _percvenda = AlterarTipo<decimal?>(leitor["Percvenda"]);
        _perdesc = AlterarTipo<decimal?>(leitor["Perdesc"]);
        _perdescfin = AlterarTipo<decimal?>(leitor["Perdescfin"]);
        _perdesctotal = AlterarTipo<decimal?>(leitor["Perdesctotal"]);
        _placaveiculo = AlterarTipo<string>(leitor["Placaveiculo"]);
        _posicao = AlterarTipo<string>(leitor["Posicao"]);
        _prazomedio = AlterarTipo<decimal?>(leitor["Prazomedio"]);
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
        _reservaritenstv7 = AlterarTipo<string>(leitor["Reservaritenstv7"]);
        _restricaotransp = AlterarTipo<string>(leitor["Restricaotransp"]);
        _rotinalanc = AlterarTipo<string>(leitor["Rotinalanc"]);
        _selecionaregiaoavulsa = AlterarTipo<string>(leitor["Selecionaregiaoavulsa"]);
        _serieecf = AlterarTipo<string>(leitor["Serieecf"]);
        _seriemanif = AlterarTipo<string>(leitor["Seriemanif"]);
        _telefone = AlterarTipo<string>(leitor["Telefone"]);
        _tipocarga = AlterarTipo<string>(leitor["Tipocarga"]);
        _tipodoc = AlterarTipo<string>(leitor["Tipodoc"]);
        _tipodocumento = AlterarTipo<string>(leitor["Tipodocumento"]);
        _tipoembalagem = AlterarTipo<string>(leitor["Tipoembalagem"]);
        _tiponfdestino = AlterarTipo<string>(leitor["Tiponfdestino"]);
        _tipooper = AlterarTipo<string>(leitor["Tipooper"]);
        _tipoorcamento = AlterarTipo<string>(leitor["Tipoorcamento"]);
        _tipoprioridadeentrega = AlterarTipo<string>(leitor["Tipoprioridadeentrega"]);
        _tiporetirada = AlterarTipo<string>(leitor["Tiporetirada"]);
        _tipovenda = AlterarTipo<string>(leitor["Tipovenda"]);
        _totpeso = AlterarTipo<decimal?>(leitor["Totpeso"]);
        _totvlbonific = AlterarTipo<decimal?>(leitor["Totvlbonific"]);
        _totvldesccom = AlterarTipo<decimal?>(leitor["Totvldesccom"]);
        _totvldescfin = AlterarTipo<decimal?>(leitor["Totvldescfin"]);
        _totvldescflex = AlterarTipo<decimal?>(leitor["Totvldescflex"]);
        _totvlredcomiss = AlterarTipo<decimal?>(leitor["Totvlredcomiss"]);
        _totvlredcomisssup = AlterarTipo<decimal?>(leitor["Totvlredcomisssup"]);
        _totvolume = AlterarTipo<decimal?>(leitor["Totvolume"]);
        _tributaporregiaofilial = AlterarTipo<string>(leitor["Tributaporregiaofilial"]);
        _uf = AlterarTipo<string>(leitor["Uf"]);
        _ufdesembaraco = AlterarTipo<string>(leitor["Ufdesembaraco"]);
        _usacfopvendanatv10 = AlterarTipo<string>(leitor["Usacfopvendanatv10"]);
        _usaintegracaowms = AlterarTipo<string>(leitor["Usaintegracaowms"]);
        _valordescfin = AlterarTipo<decimal?>(leitor["Valordescfin"]);
        _vendaassistida = AlterarTipo<string>(leitor["Vendaassistida"]);
        _vendatriangular = AlterarTipo<string>(leitor["Vendatriangular"]);
        _vlatend = AlterarTipo<decimal?>(leitor["Vlatend"]);
        _vlcustocont = AlterarTipo<decimal?>(leitor["Vlcustocont"]);
        _vlcustofin = AlterarTipo<decimal?>(leitor["Vlcustofin"]);
        _vlcustoreal = AlterarTipo<decimal?>(leitor["Vlcustoreal"]);
        _vlcustorep = AlterarTipo<decimal?>(leitor["Vlcustorep"]);
        _vldesconto = AlterarTipo<decimal?>(leitor["Vldesconto"]);
        _vldescontototal = AlterarTipo<decimal?>(leitor["Vldescontototal"]);
        _vlentrada = AlterarTipo<decimal?>(leitor["Vlentrada"]);
        _vlfrete = AlterarTipo<decimal?>(leitor["Vlfrete"]);
        _vloutrasdesp = AlterarTipo<decimal?>(leitor["Vloutrasdesp"]);
        _vltabela = AlterarTipo<decimal?>(leitor["Vltabela"]);
        _vltotal = AlterarTipo<decimal?>(leitor["Vltotal"]);
        _tipoimpr = AlterarTipo<string>(leitor["Tipoimpr"]);
        _cartaocrm = AlterarTipo<string>(leitor["Cartaocrm"]);
        _nfce = AlterarTipo<string>(leitor["Nfce"]);
        _cooconf = AlterarTipo<string>(leitor["Cooconf"]);
        _bloqueio_paf = AlterarTipo<string>(leitor["Bloqueio_Paf"]);
        _md5paf = AlterarTipo<string>(leitor["Md5paf"]);
        _indicadordesconto = AlterarTipo<string>(leitor["Indicadordesconto"]);
        _indicadoracrescimo = AlterarTipo<string>(leitor["Indicadoracrescimo"]);
    }

}