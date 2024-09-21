

////// namespace nwErp.Entidades.Caixa;

//// namespace nwErp.Api.Modelos;

[Serializable]
public class PCPEDICANCECF : GerenteDePropriedades, IEntidade
{
    private static readonly string RO_CODAUXILIAR = "Codauxiliar";

    private decimal? _codauxiliar;

    private static readonly string RO_CODCLI = "Codcli";

    private decimal _codcli;

    private static readonly string RO_CODFILIAL = "Codfilial";

    private string _codfilial;

    private static readonly string RO_CODFUNCCANCEL = "Codfunccancel";

    private decimal? _codfunccancel;

    private static readonly string RO_CODFUNCCANCELECF = "Codfunccancelecf";

    private decimal _codfunccancelecf;

    private static readonly string RO_CODFUNCCX = "Codfunccx";

    private decimal _codfunccx;

    private static readonly string RO_CODPROD = "Codprod";

    private decimal _codprod;

    private static readonly string RO_CODST = "Codst";

    private decimal? _codst;

    private static readonly string RO_CODUSUR = "Codusur";

    private decimal _codusur;

    private static readonly string RO_DATA = "Data";

    private DateTime _data;

    private static readonly string RO_DTCANCEL = "Dtcancel";

    private DateTime? _dtcancel;

    private static readonly string RO_DTCANCELECF = "Dtcancelecf";

    private DateTime _dtcancelecf;

    private static readonly string RO_DTEXPORTACAO = "Dtexportacao";

    private DateTime? _dtexportacao;

    private static readonly string RO_DTEXPORTACAOSERVINT = "Dtexportacaoservint";

    private DateTime? _dtexportacaoservint;

    private static readonly string RO_DTIMPORTACAOSERVPRINC = "Dtimportacaoservprinc";

    private DateTime? _dtimportacaoservprinc;

    private static readonly string RO_EXPORTADO = "Exportado";

    private string _exportado;

    private static readonly string RO_EXPORTADOSERVINT = "Exportadoservint";

    private string _exportadoservint;

    private static readonly string RO_IMPORTADO = "Importado";

    private string _importado;

    private static readonly string RO_IMPORTADOSERVPRINC = "Importadoservprinc";

    private string _importadoservprinc;

    private static readonly string RO_NUMCAIXA = "Numcaixa";

    private decimal _numcaixa;

    private static readonly string RO_NUMCAR = "Numcar";

    private decimal? _numcar;

    private static readonly string RO_NUMCCF = "Numccf";

    private decimal? _numccf;

    private static readonly string RO_NUMCUPOM = "Numcupom";

    private decimal? _numcupom;

    private static readonly string RO_NUMPED = "Numped";

    private decimal? _numped;

    private static readonly string RO_NUMPEDECF = "Numpedecf";

    private decimal _numpedecf;

    private static readonly string RO_NUMSEQ = "Numseq";

    private decimal _numseq;

    private static readonly string RO_NUMSERIEEQUIP = "Numserieequip";

    private string _numserieequip;

    private static readonly string RO_PERCBASERED = "Percbasered";

    private decimal? _percbasered;

    private static readonly string RO_PERCBASEREDST = "Percbaseredst";

    private decimal? _percbaseredst;

    private static readonly string RO_PERCBASEREDSTFONTE = "Percbaseredstfonte";

    private decimal? _percbaseredstfonte;

    private static readonly string RO_PERCICM = "Percicm";

    private decimal? _percicm;

    private static readonly string RO_PERCIPI = "Percipi";

    private decimal? _percipi;

    private static readonly string RO_PERCOM = "Percom";

    private decimal _percom;

    private static readonly string RO_PERDESC = "Perdesc";

    private decimal _perdesc;

    private static readonly string RO_PERFRETECMV = "Perfretecmv";

    private decimal? _perfretecmv;

    private static readonly string RO_PORIGINAL = "Poriginal";

    private decimal? _poriginal;

    private static readonly string RO_POSICAORETORNO = "Posicaoretorno";

    private string _posicaoretorno;

    private static readonly string RO_PTABELA = "Ptabela";

    private decimal _ptabela;

    private static readonly string RO_PVENDA = "Pvenda";

    private decimal _pvenda;

    private static readonly string RO_QT = "Qt";

    private decimal _qt;

    private static readonly string RO_QTFALTA = "Qtfalta";

    private decimal? _qtfalta;

    private static readonly string RO_ROTINALANC = "Rotinalanc";

    private string _rotinalanc;

    private static readonly string RO_ST = "St";

    private decimal _st;

    private static readonly string RO_TOTALIZADOR = "Totalizador";

    private string _totalizador;

    private static readonly string RO_VLCUSTOCONT = "Vlcustocont";

    private decimal? _vlcustocont;

    private static readonly string RO_VLCUSTOFIN = "Vlcustofin";

    private decimal _vlcustofin;

    private static readonly string RO_VLCUSTOREAL = "Vlcustoreal";

    private decimal _vlcustoreal;

    private static readonly string RO_VLCUSTOREP = "Vlcustorep";

    private decimal? _vlcustorep;

    private static readonly string RO_VLIPI = "Vlipi";

    private decimal? _vlipi;

    private static readonly string RO_CUPOMFECHADO = "Cupomfechado";

    private string _cupomfechado;

    private static readonly string RO_MOTIVOCANCELAMENTO = "Motivocancelamento";

    private string _motivocancelamento;

    private string _descricaopaf;

    private string _md5paf;

    private string _codcest;

    private static readonly string RO_TIPOCANCEL = "Tipocancel";

    private string _tipocancel;

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDICANCECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 16, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDICANCECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDICANCECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDICANCECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDICANCECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDICANCECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDICANCECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDICANCECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Codst
    {
        get
        {
            PropriedadeAcessada(RO_CODST);
            return _codst;
        }
        set
        {
            PropriedadeModificada(RO_CODST, value);
            _codst = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDICANCECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDICANCECF", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDICANCECF", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDICANCECF", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDICANCECF", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDICANCECF", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDICANCECF", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDICANCECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDICANCECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDICANCECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDICANCECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDICANCECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDICANCECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDICANCECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDICANCECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDICANCECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDICANCECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDICANCECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 20, Precisao = 0)]
    public decimal Numseq
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDICANCECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 30, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDICANCECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Percbasered
    {
        get
        {
            PropriedadeAcessada(RO_PERCBASERED);
            return _percbasered;
        }
        set
        {
            PropriedadeModificada(RO_PERCBASERED, value);
            _percbasered = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDICANCECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Percbaseredst
    {
        get
        {
            PropriedadeAcessada(RO_PERCBASEREDST);
            return _percbaseredst;
        }
        set
        {
            PropriedadeModificada(RO_PERCBASEREDST, value);
            _percbaseredst = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDICANCECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Percbaseredstfonte
    {
        get
        {
            PropriedadeAcessada(RO_PERCBASEREDSTFONTE);
            return _percbaseredstfonte;
        }
        set
        {
            PropriedadeModificada(RO_PERCBASEREDSTFONTE, value);
            _percbaseredstfonte = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDICANCECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Percicm
    {
        get
        {
            PropriedadeAcessada(RO_PERCICM);
            return _percicm;
        }
        set
        {
            PropriedadeModificada(RO_PERCICM, value);
            _percicm = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDICANCECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDICANCECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal Percom
    {
        get
        {
            PropriedadeAcessada(RO_PERCOM);
            return _percom;
        }
        set
        {
            PropriedadeModificada(RO_PERCOM, value);
            _percom = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDICANCECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal Perdesc
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDICANCECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Perfretecmv
    {
        get
        {
            PropriedadeAcessada(RO_PERFRETECMV);
            return _perfretecmv;
        }
        set
        {
            PropriedadeModificada(RO_PERFRETECMV, value);
            _perfretecmv = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDICANCECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Poriginal
    {
        get
        {
            PropriedadeAcessada(RO_PORIGINAL);
            return _poriginal;
        }
        set
        {
            PropriedadeModificada(RO_PORIGINAL, value);
            _poriginal = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDICANCECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDICANCECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal Ptabela
    {
        get
        {
            PropriedadeAcessada(RO_PTABELA);
            return _ptabela;
        }
        set
        {
            PropriedadeModificada(RO_PTABELA, value);
            _ptabela = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDICANCECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal Pvenda
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDICANCECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 20, Precisao = 6)]
    public decimal Qt
    {
        get
        {
            PropriedadeAcessada(RO_QT);
            return _qt;
        }
        set
        {
            PropriedadeModificada(RO_QT, value);
            _qt = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDICANCECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 2)]
    public decimal? Qtfalta
    {
        get
        {
            PropriedadeAcessada(RO_QTFALTA);
            return _qtfalta;
        }
        set
        {
            PropriedadeModificada(RO_QTFALTA, value);
            _qtfalta = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDICANCECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 48, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDICANCECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal St
    {
        get
        {
            PropriedadeAcessada(RO_ST);
            return _st;
        }
        set
        {
            PropriedadeModificada(RO_ST, value);
            _st = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDICANCECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 7, Precisao = 0)]
    public string Totalizador
    {
        get
        {
            PropriedadeAcessada(RO_TOTALIZADOR);
            return _totalizador;
        }
        set
        {
            PropriedadeModificada(RO_TOTALIZADOR, value);
            _totalizador = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDICANCECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDICANCECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal Vlcustofin
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDICANCECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal Vlcustoreal
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDICANCECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDICANCECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDICANCECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDICANCECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 150, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDICANCECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 200, Precisao = 0)]
    public string Descricaopaf
    {
        get
        {
            PropriedadeAcessada("Descricaopaf");
            return _descricaopaf;
        }
        set
        {
            PropriedadeModificada("Descricaopaf", value);
            _descricaopaf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDICANCECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 200, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDICANCECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 7, Precisao = 0)]
    public string Codcest
    {
        get
        {
            PropriedadeAcessada("Codcest");
            return _codcest;
        }
        set
        {
            PropriedadeModificada("Codcest", value);
            _codcest = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDICANCECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    public void InicializarAtributos()
    {
    }

    public string ObterNomeTabela()
    {
        return "PCPEDICANCECF";
    }

    public IEntidade NovaInstancia()
    {
        return (IEntidade)GetType().GetConstructors()[0].Invoke(null);
    }

    public void CarregarPorDataReader(IDataReader leitor)
    {
        _codauxiliar = AlterarTipo<decimal?>(leitor["Codauxiliar"]);
        _codcli = AlterarTipo<decimal>(leitor["Codcli"]);
        _codfilial = AlterarTipo<string>(leitor["Codfilial"]);
        _codfunccancel = AlterarTipo<decimal?>(leitor["Codfunccancel"]);
        _codfunccancelecf = AlterarTipo<decimal>(leitor["Codfunccancelecf"]);
        _codfunccx = AlterarTipo<decimal>(leitor["Codfunccx"]);
        _codprod = AlterarTipo<decimal>(leitor["Codprod"]);
        _codst = AlterarTipo<decimal?>(leitor["Codst"]);
        _codusur = AlterarTipo<decimal>(leitor["Codusur"]);
        _data = AlterarTipo<DateTime>(leitor["Data"]);
        _dtcancel = AlterarTipo<DateTime?>(leitor["Dtcancel"]);
        _dtcancelecf = AlterarTipo<DateTime>(leitor["Dtcancelecf"]);
        _dtexportacao = AlterarTipo<DateTime?>(leitor["Dtexportacao"]);
        _dtexportacaoservint = AlterarTipo<DateTime?>(leitor["Dtexportacaoservint"]);
        _dtimportacaoservprinc = AlterarTipo<DateTime?>(leitor["Dtimportacaoservprinc"]);
        _exportado = AlterarTipo<string>(leitor["Exportado"]);
        _exportadoservint = AlterarTipo<string>(leitor["Exportadoservint"]);
        _importado = AlterarTipo<string>(leitor["Importado"]);
        _importadoservprinc = AlterarTipo<string>(leitor["Importadoservprinc"]);
        _numcaixa = AlterarTipo<decimal>(leitor["Numcaixa"]);
        _numcar = AlterarTipo<decimal?>(leitor["Numcar"]);
        _numccf = AlterarTipo<decimal?>(leitor["Numccf"]);
        _numcupom = AlterarTipo<decimal?>(leitor["Numcupom"]);
        _numped = AlterarTipo<decimal?>(leitor["Numped"]);
        _numpedecf = AlterarTipo<decimal>(leitor["Numpedecf"]);
        _numseq = AlterarTipo<decimal>(leitor["Numseq"]);
        _numserieequip = AlterarTipo<string>(leitor["Numserieequip"]);
        _percbasered = AlterarTipo<decimal?>(leitor["Percbasered"]);
        _percbaseredst = AlterarTipo<decimal?>(leitor["Percbaseredst"]);
        _percbaseredstfonte = AlterarTipo<decimal?>(leitor["Percbaseredstfonte"]);
        _percicm = AlterarTipo<decimal?>(leitor["Percicm"]);
        _percipi = AlterarTipo<decimal?>(leitor["Percipi"]);
        _percom = AlterarTipo<decimal>(leitor["Percom"]);
        _perdesc = AlterarTipo<decimal>(leitor["Perdesc"]);
        _perfretecmv = AlterarTipo<decimal?>(leitor["Perfretecmv"]);
        _poriginal = AlterarTipo<decimal?>(leitor["Poriginal"]);
        _posicaoretorno = AlterarTipo<string>(leitor["Posicaoretorno"]);
        _ptabela = AlterarTipo<decimal>(leitor["Ptabela"]);
        _pvenda = AlterarTipo<decimal>(leitor["Pvenda"]);
        _qt = AlterarTipo<decimal>(leitor["Qt"]);
        _qtfalta = AlterarTipo<decimal?>(leitor["Qtfalta"]);
        _rotinalanc = AlterarTipo<string>(leitor["Rotinalanc"]);
        _st = AlterarTipo<decimal>(leitor["St"]);
        _totalizador = AlterarTipo<string>(leitor["Totalizador"]);
        _vlcustocont = AlterarTipo<decimal?>(leitor["Vlcustocont"]);
        _vlcustofin = AlterarTipo<decimal>(leitor["Vlcustofin"]);
        _vlcustoreal = AlterarTipo<decimal>(leitor["Vlcustoreal"]);
        _vlcustorep = AlterarTipo<decimal?>(leitor["Vlcustorep"]);
        _vlipi = AlterarTipo<decimal?>(leitor["Vlipi"]);
        _cupomfechado = AlterarTipo<string>(leitor["Cupomfechado"]);
        _motivocancelamento = AlterarTipo<string>(leitor["Motivocancelamento"]);
        _descricaopaf = AlterarTipo<string>(leitor["Descricaopaf"]);
        _md5paf = AlterarTipo<string>(leitor["Md5paf"]);
        _codcest = AlterarTipo<string>(leitor["Codcest"]);
        _tipocancel = AlterarTipo<string>(leitor["Tipocancel"]);
    }

}