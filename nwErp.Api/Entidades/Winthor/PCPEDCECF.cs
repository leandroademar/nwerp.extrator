

////// namespace nwErp.Entidades.Caixa;
// namespace nwErp.Api.Modelos;

[Serializable]
public class PCPEDCECF : GerenteDePropriedades, IEntidade
{
    public string Naturezanfce { get; set; }
    private static readonly string RO_ASSINATURA = nameof(Assinatura);
    private string _assinatura;
    private static readonly string RO_CODCLI = nameof(Codcli);
    private Decimal _codcli;
    private static readonly string RO_CODCOB = nameof(Codcob);
    private string _codcob;
    private static readonly string RO_CODEMITENTE = nameof(Codemitente);
    private Decimal? _codemitente;
    private static readonly string RO_CODFILIAL = nameof(Codfilial);
    private string _codfilial;
    private static readonly string RO_CODFUNCCX = nameof(Codfunccx);
    private Decimal _codfunccx;
    private static readonly string RO_CODPLPAG = nameof(Codplpag);
    private Decimal _codplpag;
    private static readonly string RO_CODPRACA = nameof(Codpraca);
    private Decimal _codpraca;
    private static readonly string RO_CODPROFISSIONAL = nameof(Codprofissional);
    private Decimal? _codprofissional;
    private static readonly string RO_CODSUPERVISOR = nameof(Codsupervisor);
    private Decimal _codsupervisor;
    private static readonly string RO_CODUSUR = nameof(Codusur);
    private Decimal _codusur;
    private static readonly string RO_CONDVENDA = nameof(Condvenda);
    private Decimal? _condvenda;
    private static readonly string RO_CUSTOFINEST = nameof(Custofinest);
    private Decimal? _custofinest;
    private static readonly string RO_DATA = nameof(Data);
    private DateTime _data;
    private static readonly string RO_DTCANCEL = nameof(Dtcancel);
    private DateTime? _dtcancel;
    private static readonly string RO_DTENTREGA = nameof(Dtentrega);
    private DateTime? _dtentrega;
    private static readonly string RO_DTEXPORTACAO = nameof(Dtexportacao);
    private DateTime? _dtexportacao;
    private static readonly string RO_DTFAT = nameof(Dtfat);
    private DateTime? _dtfat;
    private static readonly string RO_ENTREGA = nameof(Entrega);
    private string _entrega;
    private static readonly string RO_EXPORTADO = nameof(Exportado);
    private string _exportado;
    private static readonly string RO_GERARDADOSNFPAULISTA = nameof(Gerardadosnfpaulista);
    private string _gerardadosnfpaulista;
    private static readonly string RO_HORA = nameof(Hora);
    private Decimal? _hora;
    private static readonly string RO_HORACUPOM = nameof(Horacupom);
    private string _horacupom;
    private static readonly string RO_HORAFAT = nameof(Horafat);
    private Decimal? _horafat;
    private static readonly string RO_IMPORTADO = nameof(Importado);
    private string _importado;
    private static readonly string RO_LOGERRO = nameof(Logerro);
    private string _logerro;
    private static readonly string RO_MINUTO = nameof(Minuto);
    private Decimal? _minuto;
    private static readonly string RO_MINUTOFAT = nameof(Minutofat);
    private Decimal? _minutofat;
    private static readonly string RO_NUMCAIXA = nameof(Numcaixa);
    private Decimal _numcaixa;
    private static readonly string RO_NUMCAIXAFISCAL = nameof(Numcaixafiscal);
    private Decimal? _numcaixafiscal;
    private static readonly string RO_NUMCAR = nameof(Numcar);
    private Decimal? _numcar;
    private static readonly string RO_NUMCCF = nameof(Numccf);
    private Decimal? _numccf;
    private static readonly string RO_NUMCUPOM = nameof(Numcupom);
    private Decimal? _numcupom;
    private static readonly string RO_NUMECF = nameof(Numecf);
    private Decimal? _numecf;
    private static readonly string RO_NUMEXECUCAO = nameof(Numexecucao);
    private Decimal? _numexecucao;
    private static readonly string RO_NUMITENS = nameof(Numitens);
    private Decimal? _numitens;
    private static readonly string RO_NUMLISTA = nameof(Numlista);
    private Decimal? _numlista;
    private static readonly string RO_NUMORCA = nameof(Numorca);
    private Decimal? _numorca;
    private static readonly string RO_NUMPED = nameof(Numped);
    private Decimal? _numped;
    private static readonly string RO_NUMPEDCANC = nameof(Numpedcanc);
    private Decimal? _numpedcanc;
    private static readonly string RO_NUMPEDECF = nameof(Numpedecf);
    private Decimal _numpedecf;
    private static readonly string RO_NUMREGIAO = nameof(Numregiao);
    private Decimal? _numregiao;
    private static readonly string RO_NUMSERIEEQUIP = nameof(Numserieequip);
    private string _numserieequip;
    private static readonly string RO_NUMTRANSVENDA = nameof(Numtransvenda);
    private Decimal? _numtransvenda;
    private static readonly string RO_NUMVIASMAPASEP = nameof(Numviasmapasep);
    private Decimal? _numviasmapasep;
    private static readonly string RO_OPERACAO = nameof(Operacao);
    private string _operacao;
    private static readonly string RO_PERCICM = nameof(Percicm);
    private Decimal? _percicm;
    private static readonly string RO_PERCVENDA = nameof(Percvenda);
    private Decimal? _percvenda;
    private static readonly string RO_POSICAO = nameof(Posicao);
    private string _posicao;
    private static readonly string RO_POSICAORETORNO = nameof(Posicaoretorno);
    private string _posicaoretorno;
    private static readonly string RO_PRAZOMEDIO = nameof(Prazomedio);
    private Decimal? _prazomedio;
    private static readonly string RO_PRAZO1 = nameof(Prazo1);
    private Decimal? _prazo1;
    private static readonly string RO_PRAZO10 = nameof(Prazo10);
    private Decimal? _prazo10;
    private static readonly string RO_PRAZO11 = nameof(Prazo11);
    private Decimal? _prazo11;
    private static readonly string RO_PRAZO12 = nameof(Prazo12);
    private Decimal? _prazo12;
    private static readonly string RO_PRAZO2 = nameof(Prazo2);
    private Decimal? _prazo2;
    private static readonly string RO_PRAZO3 = nameof(Prazo3);
    private Decimal? _prazo3;
    private static readonly string RO_PRAZO4 = nameof(Prazo4);
    private Decimal? _prazo4;
    private static readonly string RO_PRAZO5 = nameof(Prazo5);
    private Decimal? _prazo5;
    private static readonly string RO_PRAZO6 = nameof(Prazo6);
    private Decimal? _prazo6;
    private static readonly string RO_PRAZO7 = nameof(Prazo7);
    private Decimal? _prazo7;
    private static readonly string RO_PRAZO8 = nameof(Prazo8);
    private Decimal? _prazo8;
    private static readonly string RO_PRAZO9 = nameof(Prazo9);
    private Decimal? _prazo9;
    private static readonly string RO_SERIEECF = nameof(Serieecf);
    private string _serieecf;
    private static readonly string RO_TAXAENTREGA = nameof(Taxaentrega);
    private Decimal? _taxaentrega;
    private static readonly string RO_TIPOMOVCCRCA = nameof(Tipomovccrca);
    private string _tipomovccrca;
    private static readonly string RO_TIPOVENDA = nameof(Tipovenda);
    private string _tipovenda;
    private static readonly string RO_TOPPESO = nameof(Toppeso);
    private Decimal? _toppeso;
    private static readonly string RO_TOTPESO = nameof(Totpeso);
    private Decimal? _totpeso;
    private static readonly string RO_TOTVOLUME = nameof(Totvolume);
    private Decimal? _totvolume;
    private static readonly string RO_USACREDRCA = nameof(Usacredrca);
    private string _usacredrca;
    private static readonly string RO_USADEBCREDRCA = nameof(Usadebcredrca);
    private string _usadebcredrca;
    private static readonly string RO_VENDAASSISTIDA = nameof(Vendaassistida);
    private string _vendaassistida;
    private static readonly string RO_VERSAOROTINA = nameof(Versaorotina);
    private string _versaorotina;
    private static readonly string RO_VERSAOFATURAMENTO = nameof(Versaofaturamento);
    private string _versaofaturamento;
    private static readonly string RO_VLATEND = nameof(Vlatend);
    private Decimal? _vlatend;
    private static readonly string RO_VLCUSTOCONT = nameof(Vlcustocont);
    private Decimal? _vlcustocont;
    private static readonly string RO_VLCUSTOFIN = nameof(Vlcustofin);
    private Decimal? _vlcustofin;
    private static readonly string RO_VLCUSTOREAL = nameof(Vlcustoreal);
    private Decimal? _vlcustoreal;
    private static readonly string RO_VLCUSTOREP = nameof(Vlcustorep);
    private Decimal? _vlcustorep;
    private static readonly string RO_VLDESCONTO = nameof(Vldesconto);
    private Decimal? _vldesconto;
    private static readonly string RO_VLOUTRASDESP = nameof(Vloutrasdesp);
    private Decimal? _vloutrasdesp;
    private static readonly string RO_VLTABELA = nameof(Vltabela);
    private Decimal? _vltabela;
    private static readonly string RO_VLTOTAL = nameof(Vltotal);
    private Decimal? _vltotal;
    private static readonly string RO_FATURANOTA = nameof(Faturanotaservfat);
    private string _faturanotaservfat;
    private static readonly string RO_DTHORAAUTORIZACAOSEFAZ = nameof(Dthoraautorizacaosefaz);
    private DateTime? _dthoraautorizacaosefaz;
    private static readonly string RO_QRCODENFCE = nameof(Qrcodenfce);
    private string _qrcodenfce;
    private static readonly string RO_PROTOCOLONFCE = nameof(Protocolonfce);
    private string _protocolonfce;
    private static readonly string RO_JUSTIFICATIVACONTIGENCIA = nameof(Justificativacontigencia);
    private string _justificativacontigencia;
    private static readonly string RO_DTAHORAENTRADACONTIGENCIA = nameof(Dtahoraentradacontigencia);
    private DateTime? _dtahoraentradacontigencia;
    private static readonly string RO_TIPOEMISSAO = nameof(Tipoemissao);
    private string _tipoemissao;
    private static readonly string RO_CHAVENFCE = nameof(Chavenfce);
    private string _chavenfce;
    private static readonly string RO_SITUACAONFCE = nameof(Situacaonfce);
    private Decimal? _situacaonfce;
    private static readonly string RO_VLTRIBUTOS = nameof(Vltributos);
    private Decimal? _vltributos;
    private static readonly string RO_PERDESC = nameof(Perdesc);
    private Decimal? _perdesc;
    private static readonly string RO_CARTAOCRM = nameof(Cartaocrm);
    private string _cartaocrm;
    private static readonly string RO_NSUSOCIOTORCEDOR = nameof(Nsusociotorcedor);
    private string _nsusociotorcedor;
    private static readonly string RO_VLDESCSOCIOTORCEDOR = nameof(Vldescsociotorcedor);
    private Decimal? _vldescsociotorcedor;
    private static readonly string RO_IDTIPOPRESENCA = nameof(Idtipopresenca);
    private string _idtipopresenca;
    private static readonly string RO_VLSUBTOTAL = nameof(Vlsubtotal);
    private Decimal? _vlsubtotal;
    private static readonly string RO_NUMVOLUME = nameof(Numvolume);
    private Decimal? _numvolume;
    private static readonly string RO_DOCEMISSAO = nameof(Docemissao);
    private string _docemissao;
    private static readonly string RO_AMBIENTENFCE = nameof(Ambientenfce);
    private string _ambientenfce;
    private static readonly string RO_CONTINGENCIASERVIDOR = nameof(Contingenciaservidor);
    private string _contingenciaservidor;
    private static readonly string RO_NUMFECHAMENTOMOVCX = nameof(Numfechamentomovcx);
    private Decimal? _numfechamentomovcx;
    private static readonly string RO_DTMOVIMENTOCX = nameof(Dtmovimentocx);
    private DateTime? _dtmovimentocx;
    private static readonly string RO_IDENTIFICARCLIENTENFCE = nameof(Identificarclientenfce);
    private string _identificarclientenfce;
    private static readonly string RO_MD5LISTAARQ = nameof(Md5listaarq);
    private string _md5listaarq;
    private static readonly string RO_VENDANFSERIED = nameof(Vendanfseried);
    private string _vendanfseried;
    private static readonly string RO_OBSNF1 = nameof(Obsnf1);
    private string _obsnf1;
    private static readonly string RO_OBSNF2 = nameof(Obsnf2);
    private string _obsnf2;
    private static readonly string RO_OBSNF3 = nameof(Obsnf3);
    private string _obsnf3;
    private static readonly string RO_FICHASIMPORTADAS = nameof(Fichasimportadas);
    private string _fichasimportadas;
    private DateTime? _datahoraemissaosat;
    private string _chavesat;
    private string _qrcodesat;
    private string _situacaosat;
    private Decimal? _numsessaosat;
    private Decimal? _codsefazsat;
    private Decimal? _codstatussat;
    private string _numseriesat;
    private Decimal? _vlfrete;
    private static readonly string RO_EXISTESEFAZ = nameof(Existesefaz);
    private string _existesefaz;
    private Decimal? _uidregistro;
    private string _idparceiro;
    private static readonly string RO_VERSAOMINFATURAMENTO = nameof(Versaominfaturamento);
    private string _versaominfaturamento;
    private static readonly string RO_NOTADUPLIQUESVC = nameof(Notadupliquesvc);
    private string _notadupliquesvc;
    private static readonly string RO_OBSNFCE = nameof(Obsnfce);
    private string _obsnfce;
    private string _md5paf;
    private Decimal? _vlacresrodape;
    private static readonly string RO_TIPODOCUMENTO = nameof(Tipodocumento);
    private string _tipodocumento;
    private static readonly string RO_FRETEDESPACHO = nameof(Fretedespacho);
    private string _fretedespacho;
    private static readonly string RO_CODFORNECFRETE = nameof(Codfornecfrete);
    private Decimal? _codfornecfrete;
    private static readonly string RO_MOTORISTAVEICULO = nameof(Motoristaveiculo);
    private string _motoristaveiculo;
    private static readonly string RO_UFVEICULO = nameof(Ufveiculo);
    private string _ufveiculo;
    private static readonly string RO_PLACAVEICULO = nameof(Placaveiculo);
    private string _placaveiculo;
    private string _iefrete;
    private string _uffrete;
    private string _cgcfrete;
    private static readonly string RO_TRANSPORTADORA = nameof(Transportadora);
    private string _transportadora;
    private static readonly string RO_EMAILDEST = nameof(Emaildest);
    private string _emaildest;
    private string _indicadordesconto;
    private string _indicadoracrescimo;
    private Decimal? _vljurosparcelamento;
    private string _descintermediador;
    private string _cnpjintermediador;
    private const string RO_VLTOTALCOMTROCO = "Vltotalcomtroco";
    private Decimal? _vltotalcomtroco;

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 255, Precisao = 0)]
    public string Assinatura
    {
        get
        {
            this.PropriedadeAcessada(PCPEDCECF.RO_ASSINATURA);
            return this._assinatura;
        }
        set
        {
            this.PropriedadeModificada(PCPEDCECF.RO_ASSINATURA, (object)value);
            this._assinatura = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public Decimal Codcli
    {
        get
        {
            this.PropriedadeAcessada(PCPEDCECF.RO_CODCLI);
            return this._codcli;
        }
        set
        {
            this.PropriedadeModificada(PCPEDCECF.RO_CODCLI, (object)value);
            this._codcli = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 4, Precisao = 0)]
    public string Codcob
    {
        get
        {
            this.PropriedadeAcessada(PCPEDCECF.RO_CODCOB);
            return this._codcob;
        }
        set
        {
            this.PropriedadeModificada(PCPEDCECF.RO_CODCOB, (object)value);
            this._codcob = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public Decimal? Codemitente
    {
        get
        {
            this.PropriedadeAcessada(PCPEDCECF.RO_CODEMITENTE);
            return this._codemitente;
        }
        set
        {
            this.PropriedadeModificada(PCPEDCECF.RO_CODEMITENTE, (object)value);
            this._codemitente = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Codfilial
    {
        get
        {
            this.PropriedadeAcessada(PCPEDCECF.RO_CODFILIAL);
            return this._codfilial;
        }
        set
        {
            this.PropriedadeModificada(PCPEDCECF.RO_CODFILIAL, (object)value);
            this._codfilial = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCPEDCECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public Decimal Codfunccx
    {
        get
        {
            this.PropriedadeAcessada(PCPEDCECF.RO_CODFUNCCX);
            return this._codfunccx;
        }
        set
        {
            this.PropriedadeModificada(PCPEDCECF.RO_CODFUNCCX, (object)value);
            this._codfunccx = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public Decimal Codplpag
    {
        get
        {
            this.PropriedadeAcessada(PCPEDCECF.RO_CODPLPAG);
            return this._codplpag;
        }
        set
        {
            this.PropriedadeModificada(PCPEDCECF.RO_CODPLPAG, (object)value);
            this._codplpag = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public Decimal Codpraca
    {
        get
        {
            this.PropriedadeAcessada(PCPEDCECF.RO_CODPRACA);
            return this._codpraca;
        }
        set
        {
            this.PropriedadeModificada(PCPEDCECF.RO_CODPRACA, (object)value);
            this._codpraca = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public Decimal? Codprofissional
    {
        get
        {
            this.PropriedadeAcessada(PCPEDCECF.RO_CODPROFISSIONAL);
            return this._codprofissional;
        }
        set
        {
            this.PropriedadeModificada(PCPEDCECF.RO_CODPROFISSIONAL, (object)value);
            this._codprofissional = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public Decimal Codsupervisor
    {
        get
        {
            this.PropriedadeAcessada(PCPEDCECF.RO_CODSUPERVISOR);
            return this._codsupervisor;
        }
        set
        {
            this.PropriedadeModificada(PCPEDCECF.RO_CODSUPERVISOR, (object)value);
            this._codsupervisor = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public Decimal Codusur
    {
        get
        {
            this.PropriedadeAcessada(PCPEDCECF.RO_CODUSUR);
            return this._codusur;
        }
        set
        {
            this.PropriedadeModificada(PCPEDCECF.RO_CODUSUR, (object)value);
            this._codusur = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 0)]
    public Decimal? Condvenda
    {
        get
        {
            this.PropriedadeAcessada(PCPEDCECF.RO_CONDVENDA);
            return this._condvenda;
        }
        set
        {
            this.PropriedadeModificada(PCPEDCECF.RO_CONDVENDA, (object)value);
            this._condvenda = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public Decimal? Custofinest
    {
        get
        {
            this.PropriedadeAcessada(PCPEDCECF.RO_CUSTOFINEST);
            return this._custofinest;
        }
        set
        {
            this.PropriedadeModificada(PCPEDCECF.RO_CUSTOFINEST, (object)value);
            this._custofinest = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCECF", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime Data
    {
        get
        {
            this.PropriedadeAcessada(PCPEDCECF.RO_DATA);
            return this._data;
        }
        set
        {
            this.PropriedadeModificada(PCPEDCECF.RO_DATA, (object)value);
            this._data = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCECF", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtcancel
    {
        get
        {
            this.PropriedadeAcessada(PCPEDCECF.RO_DTCANCEL);
            return this._dtcancel;
        }
        set
        {
            this.PropriedadeModificada(PCPEDCECF.RO_DTCANCEL, (object)value);
            this._dtcancel = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCECF", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtentrega
    {
        get
        {
            this.PropriedadeAcessada(PCPEDCECF.RO_DTENTREGA);
            return this._dtentrega;
        }
        set
        {
            this.PropriedadeModificada(PCPEDCECF.RO_DTENTREGA, (object)value);
            this._dtentrega = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCECF", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtexportacao
    {
        get
        {
            this.PropriedadeAcessada(PCPEDCECF.RO_DTEXPORTACAO);
            return this._dtexportacao;
        }
        set
        {
            this.PropriedadeModificada(PCPEDCECF.RO_DTEXPORTACAO, (object)value);
            this._dtexportacao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCECF", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtfat
    {
        get
        {
            this.PropriedadeAcessada(PCPEDCECF.RO_DTFAT);
            return this._dtfat;
        }
        set
        {
            this.PropriedadeModificada(PCPEDCECF.RO_DTFAT, (object)value);
            this._dtfat = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Entrega
    {
        get
        {
            this.PropriedadeAcessada(PCPEDCECF.RO_ENTREGA);
            return this._entrega;
        }
        set
        {
            this.PropriedadeModificada(PCPEDCECF.RO_ENTREGA, (object)value);
            this._entrega = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Exportado
    {
        get
        {
            this.PropriedadeAcessada(PCPEDCECF.RO_EXPORTADO);
            return this._exportado;
        }
        set
        {
            this.PropriedadeModificada(PCPEDCECF.RO_EXPORTADO, (object)value);
            this._exportado = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Gerardadosnfpaulista
    {
        get
        {
            this.PropriedadeAcessada(PCPEDCECF.RO_GERARDADOSNFPAULISTA);
            return this._gerardadosnfpaulista;
        }
        set
        {
            this.PropriedadeModificada(PCPEDCECF.RO_GERARDADOSNFPAULISTA, (object)value);
            this._gerardadosnfpaulista = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 2, Precisao = 0)]
    public Decimal? Hora
    {
        get
        {
            this.PropriedadeAcessada(PCPEDCECF.RO_HORA);
            return this._hora;
        }
        set
        {
            this.PropriedadeModificada(PCPEDCECF.RO_HORA, (object)value);
            this._hora = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 8, Precisao = 0)]
    public string Horacupom
    {
        get
        {
            this.PropriedadeAcessada(PCPEDCECF.RO_HORACUPOM);
            return this._horacupom;
        }
        set
        {
            this.PropriedadeModificada(PCPEDCECF.RO_HORACUPOM, (object)value);
            this._horacupom = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 2, Precisao = 0)]
    public Decimal? Horafat
    {
        get
        {
            this.PropriedadeAcessada(PCPEDCECF.RO_HORAFAT);
            return this._horafat;
        }
        set
        {
            this.PropriedadeModificada(PCPEDCECF.RO_HORAFAT, (object)value);
            this._horafat = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Importado
    {
        get
        {
            this.PropriedadeAcessada(PCPEDCECF.RO_IMPORTADO);
            return this._importado;
        }
        set
        {
            this.PropriedadeModificada(PCPEDCECF.RO_IMPORTADO, (object)value);
            this._importado = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2000, Precisao = 0)]
    public string Logerro
    {
        get
        {
            this.PropriedadeAcessada(PCPEDCECF.RO_LOGERRO);
            return this._logerro;
        }
        set
        {
            this.PropriedadeModificada(PCPEDCECF.RO_LOGERRO, (object)value);
            this._logerro = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 2, Precisao = 0)]
    public Decimal? Minuto
    {
        get
        {
            this.PropriedadeAcessada(PCPEDCECF.RO_MINUTO);
            return this._minuto;
        }
        set
        {
            this.PropriedadeModificada(PCPEDCECF.RO_MINUTO, (object)value);
            this._minuto = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 2, Precisao = 0)]
    public Decimal? Minutofat
    {
        get
        {
            this.PropriedadeAcessada(PCPEDCECF.RO_MINUTOFAT);
            return this._minutofat;
        }
        set
        {
            this.PropriedadeModificada(PCPEDCECF.RO_MINUTOFAT, (object)value);
            this._minutofat = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCPEDCECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public Decimal Numcaixa
    {
        get
        {
            this.PropriedadeAcessada(PCPEDCECF.RO_NUMCAIXA);
            return this._numcaixa;
        }
        set
        {
            this.PropriedadeModificada(PCPEDCECF.RO_NUMCAIXA, (object)value);
            this._numcaixa = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public Decimal? Numcaixafiscal
    {
        get
        {
            this.PropriedadeAcessada(PCPEDCECF.RO_NUMCAIXAFISCAL);
            return this._numcaixafiscal;
        }
        set
        {
            this.PropriedadeModificada(PCPEDCECF.RO_NUMCAIXAFISCAL, (object)value);
            this._numcaixafiscal = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public Decimal? Numcar
    {
        get
        {
            this.PropriedadeAcessada(PCPEDCECF.RO_NUMCAR);
            return this._numcar;
        }
        set
        {
            this.PropriedadeModificada(PCPEDCECF.RO_NUMCAR, (object)value);
            this._numcar = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public Decimal? Numccf
    {
        get
        {
            this.PropriedadeAcessada(PCPEDCECF.RO_NUMCCF);
            return this._numccf;
        }
        set
        {
            this.PropriedadeModificada(PCPEDCECF.RO_NUMCCF, (object)value);
            this._numccf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public Decimal? Numcupom
    {
        get
        {
            this.PropriedadeAcessada(PCPEDCECF.RO_NUMCUPOM);
            return this._numcupom;
        }
        set
        {
            this.PropriedadeModificada(PCPEDCECF.RO_NUMCUPOM, (object)value);
            this._numcupom = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public Decimal? Numecf
    {
        get
        {
            this.PropriedadeAcessada(PCPEDCECF.RO_NUMECF);
            return this._numecf;
        }
        set
        {
            this.PropriedadeModificada(PCPEDCECF.RO_NUMECF, (object)value);
            this._numecf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 20, Precisao = 0)]
    public Decimal? Numexecucao
    {
        get
        {
            this.PropriedadeAcessada(PCPEDCECF.RO_NUMEXECUCAO);
            return this._numexecucao;
        }
        set
        {
            this.PropriedadeModificada(PCPEDCECF.RO_NUMEXECUCAO, (object)value);
            this._numexecucao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public Decimal? Numitens
    {
        get
        {
            this.PropriedadeAcessada(PCPEDCECF.RO_NUMITENS);
            return this._numitens;
        }
        set
        {
            this.PropriedadeModificada(PCPEDCECF.RO_NUMITENS, (object)value);
            this._numitens = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public Decimal? Numlista
    {
        get
        {
            this.PropriedadeAcessada(PCPEDCECF.RO_NUMLISTA);
            return this._numlista;
        }
        set
        {
            this.PropriedadeModificada(PCPEDCECF.RO_NUMLISTA, (object)value);
            this._numlista = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public Decimal? Numorca
    {
        get
        {
            this.PropriedadeAcessada(PCPEDCECF.RO_NUMORCA);
            return this._numorca;
        }
        set
        {
            this.PropriedadeModificada(PCPEDCECF.RO_NUMORCA, (object)value);
            this._numorca = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public Decimal? Numped
    {
        get
        {
            this.PropriedadeAcessada(PCPEDCECF.RO_NUMPED);
            return this._numped;
        }
        set
        {
            this.PropriedadeModificada(PCPEDCECF.RO_NUMPED, (object)value);
            this._numped = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public Decimal? Numpedcanc
    {
        get
        {
            this.PropriedadeAcessada(PCPEDCECF.RO_NUMPEDCANC);
            return this._numpedcanc;
        }
        set
        {
            this.PropriedadeModificada(PCPEDCECF.RO_NUMPEDCANC, (object)value);
            this._numpedcanc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCPEDCECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public Decimal Numpedecf
    {
        get
        {
            this.PropriedadeAcessada(PCPEDCECF.RO_NUMPEDECF);
            return this._numpedecf;
        }
        set
        {
            this.PropriedadeModificada(PCPEDCECF.RO_NUMPEDECF, (object)value);
            this._numpedecf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public Decimal? Numregiao
    {
        get
        {
            this.PropriedadeAcessada(PCPEDCECF.RO_NUMREGIAO);
            return this._numregiao;
        }
        set
        {
            this.PropriedadeModificada(PCPEDCECF.RO_NUMREGIAO, (object)value);
            this._numregiao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCPEDCECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 30, Precisao = 0)]
    public string Numserieequip
    {
        get
        {
            this.PropriedadeAcessada(PCPEDCECF.RO_NUMSERIEEQUIP);
            return this._numserieequip;
        }
        set
        {
            this.PropriedadeModificada(PCPEDCECF.RO_NUMSERIEEQUIP, (object)value);
            this._numserieequip = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public Decimal? Numtransvenda
    {
        get
        {
            this.PropriedadeAcessada(PCPEDCECF.RO_NUMTRANSVENDA);
            return this._numtransvenda;
        }
        set
        {
            this.PropriedadeModificada(PCPEDCECF.RO_NUMTRANSVENDA, (object)value);
            this._numtransvenda = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 2, Precisao = 0)]
    public Decimal? Numviasmapasep
    {
        get
        {
            this.PropriedadeAcessada(PCPEDCECF.RO_NUMVIASMAPASEP);
            return this._numviasmapasep;
        }
        set
        {
            this.PropriedadeModificada(PCPEDCECF.RO_NUMVIASMAPASEP, (object)value);
            this._numviasmapasep = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Operacao
    {
        get
        {
            this.PropriedadeAcessada(PCPEDCECF.RO_OPERACAO);
            return this._operacao;
        }
        set
        {
            this.PropriedadeModificada(PCPEDCECF.RO_OPERACAO, (object)value);
            this._operacao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 2)]
    public Decimal? Percicm
    {
        get
        {
            this.PropriedadeAcessada(PCPEDCECF.RO_PERCICM);
            return this._percicm;
        }
        set
        {
            this.PropriedadeModificada(PCPEDCECF.RO_PERCICM, (object)value);
            this._percicm = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 2)]
    public Decimal? Percvenda
    {
        get
        {
            this.PropriedadeAcessada(PCPEDCECF.RO_PERCVENDA);
            return this._percvenda;
        }
        set
        {
            this.PropriedadeModificada(PCPEDCECF.RO_PERCVENDA, (object)value);
            this._percvenda = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Posicao
    {
        get
        {
            this.PropriedadeAcessada(PCPEDCECF.RO_POSICAO);
            return this._posicao;
        }
        set
        {
            this.PropriedadeModificada(PCPEDCECF.RO_POSICAO, (object)value);
            this._posicao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Posicaoretorno
    {
        get
        {
            this.PropriedadeAcessada(PCPEDCECF.RO_POSICAORETORNO);
            return this._posicaoretorno;
        }
        set
        {
            this.PropriedadeModificada(PCPEDCECF.RO_POSICAORETORNO, (object)value);
            this._posicaoretorno = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public Decimal? Prazomedio
    {
        get
        {
            this.PropriedadeAcessada(PCPEDCECF.RO_PRAZOMEDIO);
            return this._prazomedio;
        }
        set
        {
            this.PropriedadeModificada(PCPEDCECF.RO_PRAZOMEDIO, (object)value);
            this._prazomedio = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public Decimal? Prazo1
    {
        get
        {
            this.PropriedadeAcessada(PCPEDCECF.RO_PRAZO1);
            return this._prazo1;
        }
        set
        {
            this.PropriedadeModificada(PCPEDCECF.RO_PRAZO1, (object)value);
            this._prazo1 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public Decimal? Prazo10
    {
        get
        {
            this.PropriedadeAcessada(PCPEDCECF.RO_PRAZO10);
            return this._prazo10;
        }
        set
        {
            this.PropriedadeModificada(PCPEDCECF.RO_PRAZO10, (object)value);
            this._prazo10 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public Decimal? Prazo11
    {
        get
        {
            this.PropriedadeAcessada(PCPEDCECF.RO_PRAZO11);
            return this._prazo11;
        }
        set
        {
            this.PropriedadeModificada(PCPEDCECF.RO_PRAZO11, (object)value);
            this._prazo11 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public Decimal? Prazo12
    {
        get
        {
            this.PropriedadeAcessada(PCPEDCECF.RO_PRAZO12);
            return this._prazo12;
        }
        set
        {
            this.PropriedadeModificada(PCPEDCECF.RO_PRAZO12, (object)value);
            this._prazo12 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public Decimal? Prazo2
    {
        get
        {
            this.PropriedadeAcessada(PCPEDCECF.RO_PRAZO2);
            return this._prazo2;
        }
        set
        {
            this.PropriedadeModificada(PCPEDCECF.RO_PRAZO2, (object)value);
            this._prazo2 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public Decimal? Prazo3
    {
        get
        {
            this.PropriedadeAcessada(PCPEDCECF.RO_PRAZO3);
            return this._prazo3;
        }
        set
        {
            this.PropriedadeModificada(PCPEDCECF.RO_PRAZO3, (object)value);
            this._prazo3 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public Decimal? Prazo4
    {
        get
        {
            this.PropriedadeAcessada(PCPEDCECF.RO_PRAZO4);
            return this._prazo4;
        }
        set
        {
            this.PropriedadeModificada(PCPEDCECF.RO_PRAZO4, (object)value);
            this._prazo4 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public Decimal? Prazo5
    {
        get
        {
            this.PropriedadeAcessada(PCPEDCECF.RO_PRAZO5);
            return this._prazo5;
        }
        set
        {
            this.PropriedadeModificada(PCPEDCECF.RO_PRAZO5, (object)value);
            this._prazo5 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public Decimal? Prazo6
    {
        get
        {
            this.PropriedadeAcessada(PCPEDCECF.RO_PRAZO6);
            return this._prazo6;
        }
        set
        {
            this.PropriedadeModificada(PCPEDCECF.RO_PRAZO6, (object)value);
            this._prazo6 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public Decimal? Prazo7
    {
        get
        {
            this.PropriedadeAcessada(PCPEDCECF.RO_PRAZO7);
            return this._prazo7;
        }
        set
        {
            this.PropriedadeModificada(PCPEDCECF.RO_PRAZO7, (object)value);
            this._prazo7 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public Decimal? Prazo8
    {
        get
        {
            this.PropriedadeAcessada(PCPEDCECF.RO_PRAZO8);
            return this._prazo8;
        }
        set
        {
            this.PropriedadeModificada(PCPEDCECF.RO_PRAZO8, (object)value);
            this._prazo8 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public Decimal? Prazo9
    {
        get
        {
            this.PropriedadeAcessada(PCPEDCECF.RO_PRAZO9);
            return this._prazo9;
        }
        set
        {
            this.PropriedadeModificada(PCPEDCECF.RO_PRAZO9, (object)value);
            this._prazo9 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Serieecf
    {
        get
        {
            this.PropriedadeAcessada(PCPEDCECF.RO_SERIEECF);
            return this._serieecf;
        }
        set
        {
            this.PropriedadeModificada(PCPEDCECF.RO_SERIEECF, (object)value);
            this._serieecf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 2)]
    public Decimal? Taxaentrega
    {
        get
        {
            this.PropriedadeAcessada(PCPEDCECF.RO_TAXAENTREGA);
            return this._taxaentrega;
        }
        set
        {
            this.PropriedadeModificada(PCPEDCECF.RO_TAXAENTREGA, (object)value);
            this._taxaentrega = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Tipomovccrca
    {
        get
        {
            this.PropriedadeAcessada(PCPEDCECF.RO_TIPOMOVCCRCA);
            return this._tipomovccrca;
        }
        set
        {
            this.PropriedadeModificada(PCPEDCECF.RO_TIPOMOVCCRCA, (object)value);
            this._tipomovccrca = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Tipovenda
    {
        get
        {
            this.PropriedadeAcessada(PCPEDCECF.RO_TIPOVENDA);
            return this._tipovenda;
        }
        set
        {
            this.PropriedadeModificada(PCPEDCECF.RO_TIPOVENDA, (object)value);
            this._tipovenda = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public Decimal? Toppeso
    {
        get
        {
            this.PropriedadeAcessada(PCPEDCECF.RO_TOPPESO);
            return this._toppeso;
        }
        set
        {
            this.PropriedadeModificada(PCPEDCECF.RO_TOPPESO, (object)value);
            this._toppeso = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public Decimal? Totpeso
    {
        get
        {
            this.PropriedadeAcessada(PCPEDCECF.RO_TOTPESO);
            return this._totpeso;
        }
        set
        {
            this.PropriedadeModificada(PCPEDCECF.RO_TOTPESO, (object)value);
            this._totpeso = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public Decimal? Totvolume
    {
        get
        {
            this.PropriedadeAcessada(PCPEDCECF.RO_TOTVOLUME);
            return this._totvolume;
        }
        set
        {
            this.PropriedadeModificada(PCPEDCECF.RO_TOTVOLUME, (object)value);
            this._totvolume = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Usacredrca
    {
        get
        {
            this.PropriedadeAcessada(PCPEDCECF.RO_USACREDRCA);
            return this._usacredrca;
        }
        set
        {
            this.PropriedadeModificada(PCPEDCECF.RO_USACREDRCA, (object)value);
            this._usacredrca = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Usadebcredrca
    {
        get
        {
            this.PropriedadeAcessada(PCPEDCECF.RO_USADEBCREDRCA);
            return this._usadebcredrca;
        }
        set
        {
            this.PropriedadeModificada(PCPEDCECF.RO_USADEBCREDRCA, (object)value);
            this._usadebcredrca = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Vendaassistida
    {
        get
        {
            this.PropriedadeAcessada(PCPEDCECF.RO_VENDAASSISTIDA);
            return this._vendaassistida;
        }
        set
        {
            this.PropriedadeModificada(PCPEDCECF.RO_VENDAASSISTIDA, (object)value);
            this._vendaassistida = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
    public string Versaorotina
    {
        get
        {
            this.PropriedadeAcessada(PCPEDCECF.RO_VERSAOROTINA);
            return this._versaorotina;
        }
        set
        {
            this.PropriedadeModificada(PCPEDCECF.RO_VERSAOROTINA, (object)value);
            this._versaorotina = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
    public string Versaofaturamento
    {
        get
        {
            this.PropriedadeAcessada(PCPEDCECF.RO_VERSAOFATURAMENTO);
            return this._versaofaturamento;
        }
        set
        {
            this.PropriedadeModificada(PCPEDCECF.RO_VERSAOFATURAMENTO, (object)value);
            this._versaofaturamento = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 16, Precisao = 3)]
    public Decimal? Vlatend
    {
        get
        {
            this.PropriedadeAcessada(PCPEDCECF.RO_VLATEND);
            return this._vlatend;
        }
        set
        {
            this.PropriedadeModificada(PCPEDCECF.RO_VLATEND, (object)value);
            this._vlatend = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 2)]
    public Decimal? Vlcustocont
    {
        get
        {
            this.PropriedadeAcessada(PCPEDCECF.RO_VLCUSTOCONT);
            return this._vlcustocont;
        }
        set
        {
            this.PropriedadeModificada(PCPEDCECF.RO_VLCUSTOCONT, (object)value);
            this._vlcustocont = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 2)]
    public Decimal? Vlcustofin
    {
        get
        {
            this.PropriedadeAcessada(PCPEDCECF.RO_VLCUSTOFIN);
            return this._vlcustofin;
        }
        set
        {
            this.PropriedadeModificada(PCPEDCECF.RO_VLCUSTOFIN, (object)value);
            this._vlcustofin = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 2)]
    public Decimal? Vlcustoreal
    {
        get
        {
            this.PropriedadeAcessada(PCPEDCECF.RO_VLCUSTOREAL);
            return this._vlcustoreal;
        }
        set
        {
            this.PropriedadeModificada(PCPEDCECF.RO_VLCUSTOREAL, (object)value);
            this._vlcustoreal = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 2)]
    public Decimal? Vlcustorep
    {
        get
        {
            this.PropriedadeAcessada(PCPEDCECF.RO_VLCUSTOREP);
            return this._vlcustorep;
        }
        set
        {
            this.PropriedadeModificada(PCPEDCECF.RO_VLCUSTOREP, (object)value);
            this._vlcustorep = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 16, Precisao = 3)]
    public Decimal? Vldesconto
    {
        get
        {
            this.PropriedadeAcessada(PCPEDCECF.RO_VLDESCONTO);
            return this._vldesconto;
        }
        set
        {
            this.PropriedadeModificada(PCPEDCECF.RO_VLDESCONTO, (object)value);
            this._vldesconto = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 16, Precisao = 3)]
    public Decimal? Vloutrasdesp
    {
        get
        {
            this.PropriedadeAcessada(PCPEDCECF.RO_VLOUTRASDESP);
            return this._vloutrasdesp;
        }
        set
        {
            this.PropriedadeModificada(PCPEDCECF.RO_VLOUTRASDESP, (object)value);
            this._vloutrasdesp = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 16, Precisao = 3)]
    public Decimal? Vltabela
    {
        get
        {
            this.PropriedadeAcessada(PCPEDCECF.RO_VLTABELA);
            return this._vltabela;
        }
        set
        {
            this.PropriedadeModificada(PCPEDCECF.RO_VLTABELA, (object)value);
            this._vltabela = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 16, Precisao = 3)]
    public Decimal? Vltotal
    {
        get
        {
            this.PropriedadeAcessada(PCPEDCECF.RO_VLTOTAL);
            return this._vltotal;
        }
        set
        {
            this.PropriedadeModificada(PCPEDCECF.RO_VLTOTAL, (object)value);
            this._vltotal = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Faturanotaservfat
    {
        get
        {
            this.PropriedadeAcessada(PCPEDCECF.RO_FATURANOTA);
            return this._faturanotaservfat;
        }
        set
        {
            this.PropriedadeModificada(PCPEDCECF.RO_FATURANOTA, (object)value);
            this._faturanotaservfat = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCECF", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dthoraautorizacaosefaz
    {
        get
        {
            this.PropriedadeAcessada(PCPEDCECF.RO_DTHORAAUTORIZACAOSEFAZ);
            return this._dthoraautorizacaosefaz;
        }
        set
        {
            this.PropriedadeModificada(PCPEDCECF.RO_DTHORAAUTORIZACAOSEFAZ, (object)value);
            this._dthoraautorizacaosefaz = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 400, Precisao = 0)]
    public string Qrcodenfce
    {
        get
        {
            this.PropriedadeAcessada(PCPEDCECF.RO_QRCODENFCE);
            return this._qrcodenfce;
        }
        set
        {
            this.PropriedadeModificada(PCPEDCECF.RO_QRCODENFCE, (object)value);
            this._qrcodenfce = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 16, Precisao = 0)]
    public string Protocolonfce
    {
        get
        {
            this.PropriedadeAcessada(PCPEDCECF.RO_PROTOCOLONFCE);
            return this._protocolonfce;
        }
        set
        {
            this.PropriedadeModificada(PCPEDCECF.RO_PROTOCOLONFCE, (object)value);
            this._protocolonfce = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 256, Precisao = 0)]
    public string Justificativacontigencia
    {
        get
        {
            this.PropriedadeAcessada(PCPEDCECF.RO_JUSTIFICATIVACONTIGENCIA);
            return this._justificativacontigencia;
        }
        set
        {
            this.PropriedadeModificada(PCPEDCECF.RO_JUSTIFICATIVACONTIGENCIA, (object)value);
            this._justificativacontigencia = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCECF", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtahoraentradacontigencia
    {
        get
        {
            this.PropriedadeAcessada(PCPEDCECF.RO_DTAHORAENTRADACONTIGENCIA);
            return this._dtahoraentradacontigencia;
        }
        set
        {
            this.PropriedadeModificada(PCPEDCECF.RO_DTAHORAENTRADACONTIGENCIA, (object)value);
            this._dtahoraentradacontigencia = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Tipoemissao
    {
        get
        {
            this.PropriedadeAcessada(PCPEDCECF.RO_TIPOEMISSAO);
            return this._tipoemissao;
        }
        set
        {
            this.PropriedadeModificada(PCPEDCECF.RO_TIPOEMISSAO, (object)value);
            this._tipoemissao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 400, Precisao = 0)]
    public string Chavenfce
    {
        get
        {
            this.PropriedadeAcessada(PCPEDCECF.RO_CHAVENFCE);
            return this._chavenfce;
        }
        set
        {
            this.PropriedadeModificada(PCPEDCECF.RO_CHAVENFCE, (object)value);
            this._chavenfce = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 10, Precisao = 0)]
    public Decimal? Situacaonfce
    {
        get
        {
            this.PropriedadeAcessada(PCPEDCECF.RO_SITUACAONFCE);
            return this._situacaonfce;
        }
        set
        {
            this.PropriedadeModificada(PCPEDCECF.RO_SITUACAONFCE, (object)value);
            this._situacaonfce = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 2)]
    public Decimal? Vltributos
    {
        get
        {
            this.PropriedadeAcessada(PCPEDCECF.RO_VLTRIBUTOS);
            return this._vltributos;
        }
        set
        {
            this.PropriedadeModificada(PCPEDCECF.RO_VLTRIBUTOS, (object)value);
            this._vltributos = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public Decimal? Perdesc
    {
        get
        {
            this.PropriedadeAcessada(PCPEDCECF.RO_PERDESC);
            return this._perdesc;
        }
        set
        {
            this.PropriedadeModificada(PCPEDCECF.RO_PERDESC, (object)value);
            this._perdesc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 19, Precisao = 0)]
    public string Cartaocrm
    {
        get
        {
            this.PropriedadeAcessada(PCPEDCECF.RO_CARTAOCRM);
            return this._cartaocrm;
        }
        set
        {
            this.PropriedadeModificada(PCPEDCECF.RO_CARTAOCRM, (object)value);
            this._cartaocrm = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 15, Precisao = 0)]
    public string Nsusociotorcedor
    {
        get
        {
            this.PropriedadeAcessada(PCPEDCECF.RO_NSUSOCIOTORCEDOR);
            return this._nsusociotorcedor;
        }
        set
        {
            this.PropriedadeModificada(PCPEDCECF.RO_NSUSOCIOTORCEDOR, (object)value);
            this._nsusociotorcedor = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 2)]
    public Decimal? Vldescsociotorcedor
    {
        get
        {
            this.PropriedadeAcessada(PCPEDCECF.RO_VLDESCSOCIOTORCEDOR);
            return this._perdesc;
        }
        set
        {
            this.PropriedadeModificada(PCPEDCECF.RO_VLDESCSOCIOTORCEDOR, (object)value);
            this._perdesc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Idtipopresenca
    {
        get
        {
            this.PropriedadeAcessada(PCPEDCECF.RO_IDTIPOPRESENCA);
            return this._idtipopresenca;
        }
        set
        {
            this.PropriedadeModificada(PCPEDCECF.RO_IDTIPOPRESENCA, (object)value);
            this._idtipopresenca = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 2)]
    public Decimal? Vlsubtotal
    {
        get
        {
            this.PropriedadeAcessada(PCPEDCECF.RO_VLSUBTOTAL);
            return this._vlsubtotal;
        }
        set
        {
            this.PropriedadeModificada(PCPEDCECF.RO_VLSUBTOTAL, (object)value);
            this._vlsubtotal = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public Decimal? Numvolume
    {
        get
        {
            this.PropriedadeAcessada(PCPEDCECF.RO_NUMVOLUME);
            return this._numvolume;
        }
        set
        {
            this.PropriedadeModificada(PCPEDCECF.RO_NUMVOLUME, (object)value);
            this._numvolume = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Docemissao
    {
        get
        {
            this.PropriedadeAcessada(PCPEDCECF.RO_DOCEMISSAO);
            return this._docemissao;
        }
        set
        {
            this.PropriedadeModificada(PCPEDCECF.RO_DOCEMISSAO, (object)value);
            this._docemissao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Ambientenfce
    {
        get
        {
            this.PropriedadeAcessada(PCPEDCECF.RO_AMBIENTENFCE);
            return this._ambientenfce;
        }
        set
        {
            this.PropriedadeModificada(PCPEDCECF.RO_AMBIENTENFCE, (object)value);
            this._ambientenfce = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Contingenciaservidor
    {
        get
        {
            this.PropriedadeAcessada(PCPEDCECF.RO_CONTINGENCIASERVIDOR);
            return this._contingenciaservidor;
        }
        set
        {
            this.PropriedadeModificada(PCPEDCECF.RO_CONTINGENCIASERVIDOR, (object)value);
            this._contingenciaservidor = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public Decimal? Numfechamentomovcx
    {
        get
        {
            this.PropriedadeAcessada(nameof(Numfechamentomovcx));
            return this._numfechamentomovcx;
        }
        set
        {
            this.PropriedadeModificada(nameof(Numfechamentomovcx), (object)value);
            this._numfechamentomovcx = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCECF", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtmovimentocx
    {
        get
        {
            this.PropriedadeAcessada(nameof(Dtmovimentocx));
            return this._dtmovimentocx;
        }
        set
        {
            this.PropriedadeModificada(nameof(Dtmovimentocx), (object)value);
            this._dtmovimentocx = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Identificarclientenfce
    {
        get
        {
            this.PropriedadeAcessada(PCPEDCECF.RO_IDENTIFICARCLIENTENFCE);
            return this._identificarclientenfce;
        }
        set
        {
            this.PropriedadeModificada(PCPEDCECF.RO_IDENTIFICARCLIENTENFCE, (object)value);
            this._identificarclientenfce = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 300, Precisao = 0)]
    public string Md5listaarq
    {
        get
        {
            this.PropriedadeAcessada(PCPEDCECF.RO_MD5LISTAARQ);
            return this._md5listaarq;
        }
        set
        {
            this.PropriedadeModificada(PCPEDCECF.RO_MD5LISTAARQ, (object)value);
            this._md5listaarq = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Vendanfseried
    {
        get
        {
            this.PropriedadeAcessada(PCPEDCECF.RO_VENDANFSERIED);
            return this._vendanfseried;
        }
        set
        {
            this.PropriedadeModificada(PCPEDCECF.RO_VENDANFSERIED, (object)value);
            this._vendanfseried = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 80, Precisao = 0)]
    public string Obsnf1
    {
        get
        {
            this.PropriedadeAcessada(PCPEDCECF.RO_OBSNF1);
            return this._obsnf1;
        }
        set
        {
            this.PropriedadeModificada(PCPEDCECF.RO_OBSNF1, (object)value);
            this._obsnf1 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 80, Precisao = 0)]
    public string Obsnf2
    {
        get
        {
            this.PropriedadeAcessada(PCPEDCECF.RO_OBSNF2);
            return this._obsnf2;
        }
        set
        {
            this.PropriedadeModificada(PCPEDCECF.RO_OBSNF2, (object)value);
            this._obsnf2 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 80, Precisao = 0)]
    public string Obsnf3
    {
        get
        {
            this.PropriedadeAcessada(PCPEDCECF.RO_OBSNF3);
            return this._obsnf3;
        }
        set
        {
            this.PropriedadeModificada(PCPEDCECF.RO_OBSNF3, (object)value);
            this._obsnf3 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 200, Precisao = 0)]
    public string Fichasimportadas
    {
        get
        {
            this.PropriedadeAcessada(PCPEDCECF.RO_FICHASIMPORTADAS);
            return this._fichasimportadas;
        }
        set
        {
            this.PropriedadeModificada(PCPEDCECF.RO_FICHASIMPORTADAS, (object)value);
            this._fichasimportadas = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCECF", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Datahoraemissaosat
    {
        get
        {
            this.PropriedadeAcessada(nameof(Datahoraemissaosat));
            return this._datahoraemissaosat;
        }
        set
        {
            this.PropriedadeModificada(nameof(Datahoraemissaosat), (object)value);
            this._datahoraemissaosat = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 44, Precisao = 0)]
    public string Chavesat
    {
        get
        {
            this.PropriedadeAcessada(nameof(Chavesat));
            return this._chavesat;
        }
        set
        {
            this.PropriedadeModificada(nameof(Chavesat), (object)value);
            this._chavesat = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 4000, Precisao = 0)]
    public string Qrcodesat
    {
        get
        {
            this.PropriedadeAcessada(nameof(Qrcodesat));
            return this._qrcodesat;
        }
        set
        {
            this.PropriedadeModificada(nameof(Qrcodesat), (object)value);
            this._qrcodesat = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Situacaosat
    {
        get
        {
            this.PropriedadeAcessada(nameof(Situacaosat));
            return this._situacaosat;
        }
        set
        {
            this.PropriedadeModificada(nameof(Situacaosat), (object)value);
            this._situacaosat = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public Decimal? Numsessaosat
    {
        get
        {
            this.PropriedadeAcessada(nameof(Numsessaosat));
            return this._numsessaosat;
        }
        set
        {
            this.PropriedadeModificada(nameof(Numsessaosat), (object)value);
            this._numsessaosat = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public Decimal? Codsefazsat
    {
        get
        {
            this.PropriedadeAcessada(nameof(Codsefazsat));
            return this._codsefazsat;
        }
        set
        {
            this.PropriedadeModificada(nameof(Codsefazsat), (object)value);
            this._codsefazsat = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public Decimal? Codstatussat
    {
        get
        {
            this.PropriedadeAcessada(nameof(Codstatussat));
            return this._codstatussat;
        }
        set
        {
            this.PropriedadeModificada(nameof(Codstatussat), (object)value);
            this._codstatussat = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 9, Precisao = 0)]
    public string Numseriesat
    {
        get
        {
            this.PropriedadeAcessada(nameof(Numseriesat));
            return this._numseriesat;
        }
        set
        {
            this.PropriedadeModificada(nameof(Numseriesat), (object)value);
            this._numseriesat = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 16, Precisao = 3)]
    public Decimal? Vlfrete
    {
        get
        {
            this.PropriedadeAcessada(nameof(Vlfrete));
            return this._vlfrete;
        }
        set
        {
            this.PropriedadeModificada(nameof(Vlfrete), (object)value);
            this._vlfrete = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Existesefaz
    {
        get
        {
            this.PropriedadeAcessada(nameof(Existesefaz));
            return this._existesefaz;
        }
        set
        {
            this.PropriedadeModificada(nameof(Existesefaz), (object)value);
            this._existesefaz = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public Decimal? Uidregistro
    {
        get
        {
            this.PropriedadeAcessada(nameof(Uidregistro));
            return this._uidregistro;
        }
        set
        {
            this.PropriedadeModificada(nameof(Uidregistro), (object)value);
            this._uidregistro = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 15, Precisao = 0)]
    public string Idparceiro
    {
        get
        {
            this.PropriedadeAcessada(nameof(Idparceiro));
            return this._idparceiro;
        }
        set
        {
            this.PropriedadeModificada(nameof(Idparceiro), (object)value);
            this._idparceiro = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
    public string Versaominfaturamento
    {
        get
        {
            this.PropriedadeAcessada(PCPEDCECF.RO_VERSAOMINFATURAMENTO);
            return this._versaominfaturamento;
        }
        set
        {
            this.PropriedadeModificada(PCPEDCECF.RO_VERSAOMINFATURAMENTO, (object)value);
            this._versaominfaturamento = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Notadupliquesvc
    {
        get
        {
            this.PropriedadeAcessada(PCPEDCECF.RO_NOTADUPLIQUESVC);
            return this._notadupliquesvc;
        }
        set
        {
            this.PropriedadeModificada(PCPEDCECF.RO_NOTADUPLIQUESVC, (object)value);
            this._notadupliquesvc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCECF", Tipo = TipoDoCampoNoBancoDeDados.Binario, Tamanho = 8000, Precisao = 0)]
    public string Obsnfce
    {
        get
        {
            this.PropriedadeAcessada(PCPEDCECF.RO_OBSNFCE);
            return this._obsnfce;
        }
        set
        {
            this.PropriedadeModificada(PCPEDCECF.RO_OBSNFCE, (object)value);
            this._obsnfce = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 200, Precisao = 0)]
    public string Md5paf
    {
        get
        {
            this.PropriedadeAcessada(nameof(Md5paf));
            return this._md5paf;
        }
        set
        {
            this.PropriedadeModificada(nameof(Md5paf), (object)value);
            this._md5paf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public Decimal? Vlacresrodape
    {
        get
        {
            this.PropriedadeAcessada(nameof(Vlacresrodape));
            return this._vlacresrodape;
        }
        set
        {
            this.PropriedadeModificada(nameof(Vlacresrodape), (object)value);
            this._vlacresrodape = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Tipodocumento
    {
        get
        {
            this.PropriedadeAcessada(PCPEDCECF.RO_TIPODOCUMENTO);
            return this._tipodocumento;
        }
        set
        {
            this.PropriedadeModificada(PCPEDCECF.RO_TIPODOCUMENTO, (object)value);
            this._tipodocumento = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Fretedespacho
    {
        get
        {
            this.PropriedadeAcessada(PCPEDCECF.RO_FRETEDESPACHO);
            return this._fretedespacho;
        }
        set
        {
            this.PropriedadeModificada(PCPEDCECF.RO_FRETEDESPACHO, (object)value);
            this._fretedespacho = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public Decimal? Codfornecfrete
    {
        get
        {
            this.PropriedadeAcessada(PCPEDCECF.RO_CODFORNECFRETE);
            return this._codfornecfrete;
        }
        set
        {
            this.PropriedadeModificada(PCPEDCECF.RO_CODFORNECFRETE, (object)value);
            this._codfornecfrete = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
    public string Motoristaveiculo
    {
        get
        {
            this.PropriedadeAcessada(PCPEDCECF.RO_MOTORISTAVEICULO);
            return this._motoristaveiculo;
        }
        set
        {
            this.PropriedadeModificada(PCPEDCECF.RO_MOTORISTAVEICULO, (object)value);
            this._motoristaveiculo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Ufveiculo
    {
        get
        {
            this.PropriedadeAcessada(PCPEDCECF.RO_UFVEICULO);
            return this._ufveiculo;
        }
        set
        {
            this.PropriedadeModificada(PCPEDCECF.RO_UFVEICULO, (object)value);
            this._ufveiculo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 10, Precisao = 0)]
    public string Placaveiculo
    {
        get
        {
            this.PropriedadeAcessada(PCPEDCECF.RO_PLACAVEICULO);
            return this._placaveiculo;
        }
        set
        {
            this.PropriedadeModificada(PCPEDCECF.RO_PLACAVEICULO, (object)value);
            this._placaveiculo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 15, Precisao = 0)]
    public string Iefrete
    {
        get
        {
            this.PropriedadeAcessada(nameof(Iefrete));
            return this._iefrete;
        }
        set
        {
            this.PropriedadeModificada(nameof(Iefrete), (object)value);
            this._iefrete = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Uffrete
    {
        get
        {
            this.PropriedadeAcessada(nameof(Uffrete));
            return this._uffrete;
        }
        set
        {
            this.PropriedadeModificada(nameof(Uffrete), (object)value);
            this._uffrete = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 18, Precisao = 0)]
    public string Cgcfrete
    {
        get
        {
            this.PropriedadeAcessada(nameof(Cgcfrete));
            return this._cgcfrete;
        }
        set
        {
            this.PropriedadeModificada(nameof(Cgcfrete), (object)value);
            this._cgcfrete = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
    public string Transportadora
    {
        get
        {
            this.PropriedadeAcessada(PCPEDCECF.RO_TRANSPORTADORA);
            return this._transportadora;
        }
        set
        {
            this.PropriedadeModificada(PCPEDCECF.RO_TRANSPORTADORA, (object)value);
            this._transportadora = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 100, Precisao = 0)]
    public string Emaildest
    {
        get
        {
            this.PropriedadeAcessada(PCPEDCECF.RO_EMAILDEST);
            return this._emaildest;
        }
        set
        {
            this.PropriedadeModificada(PCPEDCECF.RO_EMAILDEST, (object)value);
            this._emaildest = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Indicadordesconto
    {
        get
        {
            this.PropriedadeAcessada(nameof(Indicadordesconto));
            return this._indicadordesconto;
        }
        set
        {
            this.PropriedadeModificada(nameof(Indicadordesconto), (object)value);
            this._indicadordesconto = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Indicadoracrescimo
    {
        get
        {
            this.PropriedadeAcessada(nameof(Indicadoracrescimo));
            return this._indicadoracrescimo;
        }
        set
        {
            this.PropriedadeModificada(nameof(Indicadoracrescimo), (object)value);
            this._indicadoracrescimo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 16, Precisao = 3)]
    public Decimal? Vljurosparcelamento
    {
        get
        {
            this.PropriedadeAcessada(nameof(Vljurosparcelamento));
            return this._vljurosparcelamento;
        }
        set
        {
            this.PropriedadeModificada(nameof(Vljurosparcelamento), (object)value);
            this._vljurosparcelamento = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 60, Precisao = 0)]
    public string Descintermediador
    {
        get
        {
            this.PropriedadeAcessada(nameof(Descintermediador));
            return this._descintermediador;
        }
        set
        {
            this.PropriedadeModificada(nameof(Descintermediador), (object)value);
            this._descintermediador = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
    public string Cnpjintermediador
    {
        get
        {
            this.PropriedadeAcessada(nameof(Cnpjintermediador));
            return this._cnpjintermediador;
        }
        set
        {
            this.PropriedadeModificada(nameof(Cnpjintermediador), (object)value);
            this._cnpjintermediador = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 16, Precisao = 3)]
    public Decimal? Vltotalcomtroco
    {
        get
        {
            this.PropriedadeAcessada(nameof(Vltotalcomtroco));
            return this._vltotalcomtroco;
        }
        set
        {
            this.PropriedadeModificada(nameof(Vltotalcomtroco), (object)value);
            this._vltotalcomtroco = value;
        }
    }

    public void InicializarAtributos()
    {
    }

    public string ObterNomeTabela() => nameof(PCPEDCECF);

    public IEntidade NovaInstancia() => (IEntidade)this.GetType().GetConstructors()[0].Invoke((object[])null);

    public void CarregarPorDataReader(IDataReader leitor)
    {
        this._assinatura = this.AlterarTipo<string>(leitor["Assinatura"]);
        this._codcli = this.AlterarTipo<Decimal>(leitor["Codcli"]);
        this._codcob = this.AlterarTipo<string>(leitor["Codcob"]);
        this._codemitente = this.AlterarTipo<Decimal?>(leitor["Codemitente"]);
        this._codfilial = this.AlterarTipo<string>(leitor["Codfilial"]);
        this._codfunccx = this.AlterarTipo<Decimal>(leitor["Codfunccx"]);
        this._codplpag = this.AlterarTipo<Decimal>(leitor["Codplpag"]);
        this._codpraca = this.AlterarTipo<Decimal>(leitor["Codpraca"]);
        this._codprofissional = this.AlterarTipo<Decimal?>(leitor["Codprofissional"]);
        this._codsupervisor = this.AlterarTipo<Decimal>(leitor["Codsupervisor"]);
        this._codusur = this.AlterarTipo<Decimal>(leitor["Codusur"]);
        this._condvenda = this.AlterarTipo<Decimal?>(leitor["Condvenda"]);
        this._custofinest = this.AlterarTipo<Decimal?>(leitor["Custofinest"]);
        this._data = this.AlterarTipo<DateTime>(leitor["Data"]);
        this._dtcancel = this.AlterarTipo<DateTime?>(leitor["Dtcancel"]);
        this._dtentrega = this.AlterarTipo<DateTime?>(leitor["Dtentrega"]);
        this._dtexportacao = this.AlterarTipo<DateTime?>(leitor["Dtexportacao"]);
        this._dtfat = this.AlterarTipo<DateTime?>(leitor["Dtfat"]);
        this._entrega = this.AlterarTipo<string>(leitor["Entrega"]);
        this._exportado = this.AlterarTipo<string>(leitor["Exportado"]);
        this._gerardadosnfpaulista = this.AlterarTipo<string>(leitor["Gerardadosnfpaulista"]);
        this._hora = this.AlterarTipo<Decimal?>(leitor["Hora"]);
        this._horacupom = this.AlterarTipo<string>(leitor["Horacupom"]);
        this._horafat = this.AlterarTipo<Decimal?>(leitor["Horafat"]);
        this._importado = this.AlterarTipo<string>(leitor["Importado"]);
        this._logerro = this.AlterarTipo<string>(leitor["Logerro"]);
        this._minuto = this.AlterarTipo<Decimal?>(leitor["Minuto"]);
        this._minutofat = this.AlterarTipo<Decimal?>(leitor["Minutofat"]);
        this._numcaixa = this.AlterarTipo<Decimal>(leitor["Numcaixa"]);
        this._numcaixafiscal = this.AlterarTipo<Decimal?>(leitor["Numcaixafiscal"]);
        this._numcar = this.AlterarTipo<Decimal?>(leitor["Numcar"]);
        this._numccf = this.AlterarTipo<Decimal?>(leitor["Numccf"]);
        this._numcupom = this.AlterarTipo<Decimal?>(leitor["Numcupom"]);
        this._numecf = this.AlterarTipo<Decimal?>(leitor["Numecf"]);
        this._numexecucao = this.AlterarTipo<Decimal?>(leitor["Numexecucao"]);
        this._numitens = this.AlterarTipo<Decimal?>(leitor["Numitens"]);
        this._numlista = this.AlterarTipo<Decimal?>(leitor["Numlista"]);
        this._numorca = this.AlterarTipo<Decimal?>(leitor["Numorca"]);
        this._numped = this.AlterarTipo<Decimal?>(leitor["Numped"]);
        this._numpedcanc = this.AlterarTipo<Decimal?>(leitor["Numpedcanc"]);
        this._numpedecf = this.AlterarTipo<Decimal>(leitor["Numpedecf"]);
        this._numregiao = this.AlterarTipo<Decimal?>(leitor["Numregiao"]);
        this._numserieequip = this.AlterarTipo<string>(leitor["Numserieequip"]);
        this._numtransvenda = this.AlterarTipo<Decimal?>(leitor["Numtransvenda"]);
        this._numviasmapasep = this.AlterarTipo<Decimal?>(leitor["Numviasmapasep"]);
        this._operacao = this.AlterarTipo<string>(leitor["Operacao"]);
        this._percicm = this.AlterarTipo<Decimal?>(leitor["Percicm"]);
        this._percvenda = this.AlterarTipo<Decimal?>(leitor["Percvenda"]);
        this._posicao = this.AlterarTipo<string>(leitor["Posicao"]);
        this._posicaoretorno = this.AlterarTipo<string>(leitor["Posicaoretorno"]);
        this._prazomedio = this.AlterarTipo<Decimal?>(leitor["Prazomedio"]);
        this._prazo1 = this.AlterarTipo<Decimal?>(leitor["Prazo1"]);
        this._prazo10 = this.AlterarTipo<Decimal?>(leitor["Prazo10"]);
        this._prazo11 = this.AlterarTipo<Decimal?>(leitor["Prazo11"]);
        this._prazo12 = this.AlterarTipo<Decimal?>(leitor["Prazo12"]);
        this._prazo2 = this.AlterarTipo<Decimal?>(leitor["Prazo2"]);
        this._prazo3 = this.AlterarTipo<Decimal?>(leitor["Prazo3"]);
        this._prazo4 = this.AlterarTipo<Decimal?>(leitor["Prazo4"]);
        this._prazo5 = this.AlterarTipo<Decimal?>(leitor["Prazo5"]);
        this._prazo6 = this.AlterarTipo<Decimal?>(leitor["Prazo6"]);
        this._prazo7 = this.AlterarTipo<Decimal?>(leitor["Prazo7"]);
        this._prazo8 = this.AlterarTipo<Decimal?>(leitor["Prazo8"]);
        this._prazo9 = this.AlterarTipo<Decimal?>(leitor["Prazo9"]);
        this._serieecf = this.AlterarTipo<string>(leitor["Serieecf"]);
        this._taxaentrega = this.AlterarTipo<Decimal?>(leitor["Taxaentrega"]);
        this._tipomovccrca = this.AlterarTipo<string>(leitor["Tipomovccrca"]);
        this._tipovenda = this.AlterarTipo<string>(leitor["Tipovenda"]);
        this._toppeso = this.AlterarTipo<Decimal?>(leitor["Toppeso"]);
        this._totpeso = this.AlterarTipo<Decimal?>(leitor["Totpeso"]);
        this._totvolume = this.AlterarTipo<Decimal?>(leitor["Totvolume"]);
        this._usacredrca = this.AlterarTipo<string>(leitor["Usacredrca"]);
        this._usadebcredrca = this.AlterarTipo<string>(leitor["Usadebcredrca"]);
        this._vendaassistida = this.AlterarTipo<string>(leitor["Vendaassistida"]);
        this._versaorotina = this.AlterarTipo<string>(leitor["Versaorotina"]);
        this._versaofaturamento = this.AlterarTipo<string>(leitor["Versaofaturamento"]);
        this._vlatend = this.AlterarTipo<Decimal?>(leitor["Vlatend"]);
        this._vlcustocont = this.AlterarTipo<Decimal?>(leitor["Vlcustocont"]);
        this._vlcustofin = this.AlterarTipo<Decimal?>(leitor["Vlcustofin"]);
        this._vlcustoreal = this.AlterarTipo<Decimal?>(leitor["Vlcustoreal"]);
        this._vlcustorep = this.AlterarTipo<Decimal?>(leitor["Vlcustorep"]);
        this._vldesconto = this.AlterarTipo<Decimal?>(leitor["Vldesconto"]);
        this._vloutrasdesp = this.AlterarTipo<Decimal?>(leitor["Vloutrasdesp"]);
        this._vltabela = this.AlterarTipo<Decimal?>(leitor["Vltabela"]);
        this._vltotal = this.AlterarTipo<Decimal?>(leitor["Vltotal"]);
        this._faturanotaservfat = this.AlterarTipo<string>(leitor["Faturanotaservfat"]);
        this._vltributos = this.AlterarTipo<Decimal?>(leitor["Vltributos"]);
        this._perdesc = this.AlterarTipo<Decimal?>(leitor["Perdesc"]);
        this._cartaocrm = this.AlterarTipo<string>(leitor["Cartaocrm"]);
        this._nsusociotorcedor = this.AlterarTipo<string>(leitor["Nsusociotorcedor"]);
        this._vldescsociotorcedor = this.AlterarTipo<Decimal?>(leitor["Vldescsociotorcedor"]);
        this._idtipopresenca = this.AlterarTipo<string>(leitor["Idtipopresenca"]);
        this._vlsubtotal = this.AlterarTipo<Decimal?>(leitor["Vlsubtotal"]);
        this._numvolume = this.AlterarTipo<Decimal?>(leitor["Numvolume"]);
        this._docemissao = this.AlterarTipo<string>(leitor["Docemissao"]);
        this._numfechamentomovcx = this.AlterarTipo<Decimal?>(leitor["Numfechamentomovcx"]);
        this._dtmovimentocx = this.AlterarTipo<DateTime?>(leitor["Dtmovimentocx"]);
        this._md5listaarq = this.AlterarTipo<string>(leitor["Md5listaarq"]);
        this._vendanfseried = this.AlterarTipo<string>(leitor["Vendanfseried"]);
        this._obsnf1 = this.AlterarTipo<string>(leitor["Obsnf1"]);
        this._obsnf2 = this.AlterarTipo<string>(leitor["Obsnf2"]);
        this._obsnf3 = this.AlterarTipo<string>(leitor["Obsnf3"]);
        this._fichasimportadas = this.AlterarTipo<string>(leitor["Fichasimportadas"]);
        this._idparceiro = this.AlterarTipo<string>(leitor["Idparceiro"]);
        this._uidregistro = this.AlterarTipo<Decimal?>(leitor["Uidregistro"]);
        this._versaominfaturamento = this.AlterarTipo<string>(leitor["Versaominfaturamento"]);
        this._md5paf = this.AlterarTipo<string>(leitor["Md5paf"]);
        this._vlacresrodape = this.AlterarTipo<Decimal?>(leitor["Vlacresrodape"]);
        this._tipodocumento = this.AlterarTipo<string>(leitor["Tipodocumento"]);
        this._fretedespacho = this.AlterarTipo<string>(leitor["Fretedespacho"]);
        this._codfornecfrete = this.AlterarTipo<Decimal?>(leitor["Codfornecfrete"]);
        this._motoristaveiculo = this.AlterarTipo<string>(leitor["Motoristaveiculo"]);
        this._ufveiculo = this.AlterarTipo<string>(leitor["Ufveiculo"]);
        this._placaveiculo = this.AlterarTipo<string>(leitor["Placaveiculo"]);
        this._iefrete = this.AlterarTipo<string>(leitor["Iefrete"]);
        this._uffrete = this.AlterarTipo<string>(leitor["Uffrete"]);
        this._cgcfrete = this.AlterarTipo<string>(leitor["Cgcfrete"]);
        this._transportadora = this.AlterarTipo<string>(leitor["Transportadora"]);
        this._cnpjintermediador = this.AlterarTipo<string>(leitor["Cnpjintermediador"]);
        this._descintermediador = this.AlterarTipo<string>(leitor["Descintermediador"]);
        this._datahoraemissaosat = this.AlterarTipo<DateTime?>(leitor["Datahoraemissaosat"]);
        this._chavesat = this.AlterarTipo<string>(leitor["Chavesat"]);
        this._qrcodesat = this.AlterarTipo<string>(leitor["Qrcodesat"]);
        this._situacaosat = this.AlterarTipo<string>(leitor["Situacaosat"]);
        this._numsessaosat = this.AlterarTipo<Decimal?>(leitor["Numsessaosat"]);
        this._codsefazsat = this.AlterarTipo<Decimal?>(leitor["Codsefazsat"]);
        this._codstatussat = this.AlterarTipo<Decimal?>(leitor["Codstatussat"]);
        this._numseriesat = this.AlterarTipo<string>(leitor["Numseriesat"]);
        this._dthoraautorizacaosefaz = this.AlterarTipo<DateTime?>(leitor["Dthoraautorizacaosefaz"]);
        this._qrcodenfce = this.AlterarTipo<string>(leitor["Qrcodenfce"]);
        this._protocolonfce = this.AlterarTipo<string>(leitor["Protocolonfce"]);
        this._justificativacontigencia = this.AlterarTipo<string>(leitor["Justificativacontigencia"]);
        this._dtahoraentradacontigencia = this.AlterarTipo<DateTime?>(leitor["Dtahoraentradacontigencia"]);
        this._tipoemissao = this.AlterarTipo<string>(leitor["Tipoemissao"]);
        this._chavenfce = this.AlterarTipo<string>(leitor["Chavenfce"]);
        this._situacaonfce = this.AlterarTipo<Decimal?>(leitor["Situacaonfce"]);
        this._contingenciaservidor = this.AlterarTipo<string>(leitor["Contingenciaservidor"]);
        this._ambientenfce = this.AlterarTipo<string>(leitor["Ambientenfce"]);
        this._identificarclientenfce = this.AlterarTipo<string>(leitor["Identificarclientenfce"]);
        this._obsnfce = this.AlterarTipo<string>(leitor["Obsnfce"]);
        this._existesefaz = this.AlterarTipo<string>(leitor["Existesefaz"]);
        this._notadupliquesvc = this.AlterarTipo<string>(leitor["Notadupliquesvc"]);
        this._emaildest = this.AlterarTipo<string>(leitor["Emaildest"]);
        this._indicadordesconto = this.AlterarTipo<string>(leitor["Indicadordesconto"]);
        this._indicadoracrescimo = this.AlterarTipo<string>(leitor["Indicadoracrescimo"]);
        this._vljurosparcelamento = this.AlterarTipo<Decimal?>(leitor["Vljurosparcelamento"]);
        this._vltotalcomtroco = this.AlterarTipo<Decimal?>(leitor["Vltotalcomtroco"]);
    }


}