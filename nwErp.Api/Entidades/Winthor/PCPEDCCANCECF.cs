

////// namespace nwErp.Entidades.Caixa;

// namespace nwErp.Api.Modelos;

[Serializable]
public class PCPEDCCANCECF : GerenteDePropriedades, IEntidade
{
    private static readonly string RO_CODCLI = "Codcli";

    private decimal _codcli;

    private static readonly string RO_CODCOB = "Codcob";

    private string _codcob;

    private static readonly string RO_CODEMITENTE = "Codemitente";

    private decimal? _codemitente;

    private static readonly string RO_CODFILIAL = "Codfilial";

    private string _codfilial;

    private static readonly string RO_CODFUNCCANCEL = "Codfunccancel";

    private decimal? _codfunccancel;

    private static readonly string RO_CODFUNCCANCELECF = "Codfunccancelecf";

    private decimal _codfunccancelecf;

    private static readonly string RO_CODFUNCCX = "Codfunccx";

    private decimal _codfunccx;

    private static readonly string RO_CODPLPAG = "Codplpag";

    private decimal _codplpag;

    private static readonly string RO_CODPRACA = "Codpraca";

    private decimal _codpraca;

    private static readonly string RO_CODSUPERVISOR = "Codsupervisor";

    private decimal _codsupervisor;

    private static readonly string RO_CODUSUR = "Codusur";

    private decimal _codusur;

    private static readonly string RO_CONDVENDA = "Condvenda";

    private decimal? _condvenda;

    private static readonly string RO_CUPOMFECHADO = "Cupomfechado";

    private string _cupomfechado;

    private static readonly string RO_DATA = "Data";

    private DateTime _data;

    private static readonly string RO_DTCANCEL = "Dtcancel";

    private DateTime? _dtcancel;

    private static readonly string RO_DTCANCELECF = "Dtcancelecf";

    private DateTime _dtcancelecf;

    private static readonly string RO_DTENTREGA = "Dtentrega";

    private DateTime? _dtentrega;

    private static readonly string RO_DTEXPORTACAO = "Dtexportacao";

    private DateTime? _dtexportacao;

    private static readonly string RO_DTEXPORTACAOSERVINT = "Dtexportacaoservint";

    private DateTime? _dtexportacaoservint;

    private static readonly string RO_DTFAT = "Dtfat";

    private DateTime? _dtfat;

    private static readonly string RO_DTIMPORTACAOSERVPRINC = "Dtimportacaoservprinc";

    private DateTime? _dtimportacaoservprinc;

    private static readonly string RO_EXPORTADO = "Exportado";

    private string _exportado;

    private static readonly string RO_EXPORTADOSERVINT = "Exportadoservint";

    private string _exportadoservint;

    private static readonly string RO_HORA = "Hora";

    private decimal? _hora;

    private static readonly string RO_HORAFAT = "Horafat";

    private decimal? _horafat;

    private static readonly string RO_IMPORTADO = "Importado";

    private string _importado;

    private static readonly string RO_IMPORTADOSERVPRINC = "Importadoservprinc";

    private string _importadoservprinc;

    private static readonly string RO_MINUTO = "Minuto";

    private decimal? _minuto;

    private static readonly string RO_MINUTOFAT = "Minutofat";

    private decimal? _minutofat;

    private static readonly string RO_NUMCAIXA = "Numcaixa";

    private decimal _numcaixa;

    private static readonly string RO_NUMCAR = "Numcar";

    private decimal? _numcar;

    private static readonly string RO_NUMCCF = "Numccf";

    private decimal? _numccf;

    private static readonly string RO_NUMCUPOM = "Numcupom";

    private decimal? _numcupom;

    private static readonly string RO_NUMECF = "Numecf";

    private decimal? _numecf;

    private static readonly string RO_NUMITENS = "Numitens";

    private decimal? _numitens;

    private static readonly string RO_NUMPED = "Numped";

    private decimal? _numped;

    private static readonly string RO_NUMPEDECF = "Numpedecf";

    private decimal _numpedecf;

    private static readonly string RO_NUMSERIEEQUIP = "Numserieequip";

    private string _numserieequip;

    private static readonly string RO_NUMTRANSVENDA = "Numtransvenda";

    private decimal? _numtransvenda;

    private static readonly string RO_NUMVIASMAPASEP = "Numviasmapasep";

    private decimal? _numviasmapasep;

    private static readonly string RO_OBSERVACAO = "Observacao";

    private string _observacao;

    private static readonly string RO_OPERACAO = "Operacao";

    private string _operacao;

    private static readonly string RO_PERCVENDA = "Percvenda";

    private decimal? _percvenda;

    private static readonly string RO_POSICAOPEDIDO = "Posicaopedido";

    private string _posicaopedido;

    private static readonly string RO_POSICAORETORNO = "Posicaoretorno";

    private string _posicaoretorno;

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

    private static readonly string RO_ROTINALANC = "Rotinalanc";

    private string _rotinalanc;

    private static readonly string RO_SERIEECF = "Serieecf";

    private string _serieecf;

    private static readonly string RO_TIPOCANCEL = "Tipocancel";

    private string _tipocancel;

    private static readonly string RO_TIPOVENDA = "Tipovenda";

    private string _tipovenda;

    private static readonly string RO_TOTPESO = "Totpeso";

    private decimal? _totpeso;

    private static readonly string RO_TOTVOLUME = "Totvolume";

    private decimal? _totvolume;

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

    private static readonly string RO_VLOUTRASDESP = "Vloutrasdesp";

    private decimal? _vloutrasdesp;

    private static readonly string RO_VLTABELA = "Vltabela";

    private decimal? _vltabela;

    private static readonly string RO_VLTOTAL = "Vltotal";

    private decimal? _vltotal;

    private static readonly string RO_DOCEMISSAO = "Docemissao";

    private string _docemissao;

    private static readonly string RO_NUMFECHAMENTOMOVCX = "Numfechamentomovcx";

    private decimal? _numfechamentomovcx;

    private static readonly string RO_DTMOVIMENTOCX = "Dtmovimentocx";

    private DateTime? _dtmovimentocx;

    private static readonly string RO_ASSINATURA = "Assinatura";

    private string _assinatura;

    private static readonly string RO_MOTIVOCANCELAMENTO = "Motivocancelamento";

    private string _motivocancelamento;

    private static readonly string RO_CARTAOCRM = "Cartaocrm";

    private string _cartaocrm;

    private static readonly string RO_NOTADUPLIQUESVC = "Notadupliquesvc";

    private string _notadupliquesvc;

    private string _md5paf;

    private decimal? _vlacresrodape;

    private static readonly string RO_AMBIENTENFCE = "Ambientenfce";

    private string _ambientenfce;

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCCANCECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCCANCECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCCANCECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCCANCECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCCANCECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCCANCECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal Codfunccancelecf
    {
        get
        {
            PropriedadeAcessada(RO_CODFUNCCANCELECF);
            return _codfunccancelecf;
        }
        set
        {
            PropriedadeModificada(RO_CODFUNCCANCELECF, value);
            _codfunccancelecf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCCANCECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal Codfunccx
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCCANCECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCCANCECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCCANCECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCCANCECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCCANCECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCCANCECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Cupomfechado
    {
        get
        {
            PropriedadeAcessada(RO_CUPOMFECHADO);
            return _cupomfechado;
        }
        set
        {
            PropriedadeModificada(RO_CUPOMFECHADO, value);
            _cupomfechado = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCCANCECF", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCCANCECF", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCCANCECF", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime Dtcancelecf
    {
        get
        {
            PropriedadeAcessada(RO_DTCANCELECF);
            return _dtcancelecf;
        }
        set
        {
            PropriedadeModificada(RO_DTCANCELECF, value);
            _dtcancelecf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCCANCECF", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCCANCECF", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCCANCECF", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCCANCECF", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCCANCECF", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCCANCECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCCANCECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCCANCECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 2, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCCANCECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 2, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCCANCECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCCANCECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCCANCECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 2, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCCANCECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 2, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCCANCECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal Numcaixa
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCCANCECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Numcar
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCCANCECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCCANCECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCCANCECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCCANCECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCCANCECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCCANCECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal Numpedecf
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCCANCECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 30, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCCANCECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCCANCECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 2, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCCANCECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 255, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCCANCECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCCANCECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 2)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCCANCECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Posicaopedido
    {
        get
        {
            PropriedadeAcessada(RO_POSICAOPEDIDO);
            return _posicaopedido;
        }
        set
        {
            PropriedadeModificada(RO_POSICAOPEDIDO, value);
            _posicaopedido = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCCANCECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Posicaoretorno
    {
        get
        {
            PropriedadeAcessada(RO_POSICAORETORNO);
            return _posicaoretorno;
        }
        set
        {
            PropriedadeModificada(RO_POSICAORETORNO, value);
            _posicaoretorno = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCCANCECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCCANCECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCCANCECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCCANCECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCCANCECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCCANCECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCCANCECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCCANCECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCCANCECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCCANCECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCCANCECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCCANCECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCCANCECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCCANCECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 48, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCCANCECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCCANCECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Tipocancel
    {
        get
        {
            PropriedadeAcessada(RO_TIPOCANCEL);
            return _tipocancel;
        }
        set
        {
            PropriedadeModificada(RO_TIPOCANCEL, value);
            _tipocancel = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCCANCECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCCANCECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 2)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCCANCECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCCANCECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 16, Precisao = 3)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCCANCECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 2)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCCANCECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 2)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCCANCECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 2)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCCANCECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 2)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCCANCECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 16, Precisao = 3)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCCANCECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 16, Precisao = 3)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCCANCECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 16, Precisao = 3)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCCANCECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 16, Precisao = 3)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCCANCECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCCANCECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCCANCECF", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCCANCECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 256, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCCANCECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 150, Precisao = 0)]
    public string Motivocancelamento
    {
        get
        {
            PropriedadeAcessada(RO_MOTIVOCANCELAMENTO);
            return _motivocancelamento;
        }
        set
        {
            PropriedadeModificada(RO_MOTIVOCANCELAMENTO, value);
            _motivocancelamento = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCCANCECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 19, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCCANCECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Notadupliquesvc
    {
        get
        {
            PropriedadeAcessada(RO_NOTADUPLIQUESVC);
            return _notadupliquesvc;
        }
        set
        {
            PropriedadeModificada(RO_NOTADUPLIQUESVC, value);
            _notadupliquesvc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCCANCECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 200, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCCANCECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlacresrodape
    {
        get
        {
            PropriedadeAcessada("Vlacresrodape");
            return _vlacresrodape;
        }
        set
        {
            PropriedadeModificada("Vlacresrodape", value);
            _vlacresrodape = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDCCANCECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Ambientenfce
    {
        get
        {
            PropriedadeAcessada(RO_AMBIENTENFCE);
            return _ambientenfce;
        }
        set
        {
            PropriedadeModificada(RO_AMBIENTENFCE, value);
            _ambientenfce = value;
        }
    }

    public void InicializarAtributos()
    {
    }

    public string ObterNomeTabela()
    {
        return "PCPEDCCANCECF";
    }

    public IEntidade NovaInstancia()
    {
        return (IEntidade)GetType().GetConstructors()[0].Invoke(null);
    }

    public void CarregarPorDataReader(IDataReader leitor)
    {
        _codcli = AlterarTipo<decimal>(leitor["Codcli"]);
        _codcob = AlterarTipo<string>(leitor["Codcob"]);
        _codemitente = AlterarTipo<decimal?>(leitor["Codemitente"]);
        _codfilial = AlterarTipo<string>(leitor["Codfilial"]);
        _codfunccancel = AlterarTipo<decimal?>(leitor["Codfunccancel"]);
        _codfunccancelecf = AlterarTipo<decimal>(leitor["Codfunccancelecf"]);
        _codfunccx = AlterarTipo<decimal>(leitor["Codfunccx"]);
        _codplpag = AlterarTipo<decimal>(leitor["Codplpag"]);
        _codpraca = AlterarTipo<decimal>(leitor["Codpraca"]);
        _codsupervisor = AlterarTipo<decimal>(leitor["Codsupervisor"]);
        _codusur = AlterarTipo<decimal>(leitor["Codusur"]);
        _condvenda = AlterarTipo<decimal?>(leitor["Condvenda"]);
        _cupomfechado = AlterarTipo<string>(leitor["Cupomfechado"]);
        _data = AlterarTipo<DateTime>(leitor["Data"]);
        _dtcancel = AlterarTipo<DateTime?>(leitor["Dtcancel"]);
        _dtcancelecf = AlterarTipo<DateTime>(leitor["Dtcancelecf"]);
        _dtentrega = AlterarTipo<DateTime?>(leitor["Dtentrega"]);
        _dtexportacao = AlterarTipo<DateTime?>(leitor["Dtexportacao"]);
        _dtexportacaoservint = AlterarTipo<DateTime?>(leitor["Dtexportacaoservint"]);
        _dtfat = AlterarTipo<DateTime?>(leitor["Dtfat"]);
        _dtimportacaoservprinc = AlterarTipo<DateTime?>(leitor["Dtimportacaoservprinc"]);
        _exportado = AlterarTipo<string>(leitor["Exportado"]);
        _exportadoservint = AlterarTipo<string>(leitor["Exportadoservint"]);
        _hora = AlterarTipo<decimal?>(leitor["Hora"]);
        _horafat = AlterarTipo<decimal?>(leitor["Horafat"]);
        _importado = AlterarTipo<string>(leitor["Importado"]);
        _importadoservprinc = AlterarTipo<string>(leitor["Importadoservprinc"]);
        _minuto = AlterarTipo<decimal?>(leitor["Minuto"]);
        _minutofat = AlterarTipo<decimal?>(leitor["Minutofat"]);
        _numcaixa = AlterarTipo<decimal>(leitor["Numcaixa"]);
        _numcar = AlterarTipo<decimal?>(leitor["Numcar"]);
        _numccf = AlterarTipo<decimal?>(leitor["Numccf"]);
        _numcupom = AlterarTipo<decimal?>(leitor["Numcupom"]);
        _numecf = AlterarTipo<decimal?>(leitor["Numecf"]);
        _numitens = AlterarTipo<decimal?>(leitor["Numitens"]);
        _numped = AlterarTipo<decimal?>(leitor["Numped"]);
        _numpedecf = AlterarTipo<decimal>(leitor["Numpedecf"]);
        _numserieequip = AlterarTipo<string>(leitor["Numserieequip"]);
        _numtransvenda = AlterarTipo<decimal?>(leitor["Numtransvenda"]);
        _numviasmapasep = AlterarTipo<decimal?>(leitor["Numviasmapasep"]);
        _observacao = AlterarTipo<string>(leitor["Observacao"]);
        _operacao = AlterarTipo<string>(leitor["Operacao"]);
        _percvenda = AlterarTipo<decimal?>(leitor["Percvenda"]);
        _posicaopedido = AlterarTipo<string>(leitor["Posicaopedido"]);
        _posicaoretorno = AlterarTipo<string>(leitor["Posicaoretorno"]);
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
        _rotinalanc = AlterarTipo<string>(leitor["Rotinalanc"]);
        _serieecf = AlterarTipo<string>(leitor["Serieecf"]);
        _tipocancel = AlterarTipo<string>(leitor["Tipocancel"]);
        _tipovenda = AlterarTipo<string>(leitor["Tipovenda"]);
        _totpeso = AlterarTipo<decimal?>(leitor["Totpeso"]);
        _totvolume = AlterarTipo<decimal?>(leitor["Totvolume"]);
        _vlatend = AlterarTipo<decimal?>(leitor["Vlatend"]);
        _vlcustocont = AlterarTipo<decimal?>(leitor["Vlcustocont"]);
        _vlcustofin = AlterarTipo<decimal?>(leitor["Vlcustofin"]);
        _vlcustoreal = AlterarTipo<decimal?>(leitor["Vlcustoreal"]);
        _vlcustorep = AlterarTipo<decimal?>(leitor["Vlcustorep"]);
        _vldesconto = AlterarTipo<decimal?>(leitor["Vldesconto"]);
        _vloutrasdesp = AlterarTipo<decimal?>(leitor["Vloutrasdesp"]);
        _vltabela = AlterarTipo<decimal?>(leitor["Vltabela"]);
        _vltotal = AlterarTipo<decimal?>(leitor["Vltotal"]);
        _docemissao = AlterarTipo<string>(leitor["Docemissao"]);
        _numfechamentomovcx = AlterarTipo<decimal?>(leitor["Numfechamentomovcx"]);
        _dtmovimentocx = AlterarTipo<DateTime?>(leitor["Dtmovimentocx"]);
        _assinatura = AlterarTipo<string>(leitor["Assinatura"]);
        _motivocancelamento = AlterarTipo<string>(leitor["Motivocancelamento"]);
        _cartaocrm = AlterarTipo<string>(leitor["Cartaocrm"]);
        _notadupliquesvc = AlterarTipo<string>(leitor["Notadupliquesvc"]);
        _md5paf = AlterarTipo<string>(leitor["Md5paf"]);
        _vlacresrodape = AlterarTipo<decimal?>(leitor["Vlacresrodape"]);
        _ambientenfce = AlterarTipo<string>(leitor["Ambientenfce"]);
    }

}