[Serializable]
public class PCCORTEFV : GerenteDePropriedades, IEntidade
{
    private static readonly string RO_NUMPEDRCA = "Numpedrca";
    private int? _numpedrca;
    
    private static readonly string RO_NUMPED = "Numped";
    private int? _numped;
    
    private static readonly string RO_CODUSUR = "Codusur";
    private int? _codusur;
    
    private static readonly string RO_CODCLI = "Codcli";
    private int? _codcli;
    
    private static readonly string RO_DTABERTURAPEDPALM = "Dtaberturapedpalm";
    private DateTime? _dtaberturapedpalm;
    
    private static readonly string RO_CODPROD = "Codprod";
    private int? _codprod;
    
    private static readonly string RO_CODAUXILIAR = "Codauxiliar";
    private int? _codauxiliar;
    
    private static readonly string RO_NUMSEQ = "Numseq";
    private int? _numseq;
    
    private static readonly string RO_QTANT = "Qtant";
    private decimal? _qtant;
    
    private static readonly string RO_QTCORTE = "Qtcorte";
    private decimal? _qtcorte;
    
    private static readonly string RO_DTCORTE = "Dtcorte";
    private DateTime? _dtcorte;
    
    private static readonly string RO_CODFUNCCORTE = "Codfunccorte";
    private string? _codfunccorte;
    
    private static readonly string RO_PROGRAMA = "Programa";
    private string? _programa;
    
    private static readonly string RO_MAQUINA = "Maquina";
    private string? _maquina;
    
    private static readonly string RO_CODFILIAL = "Codfilial";
    private string? _codfilial;
    
    private static readonly string RO_CODFILIALRETIRA = "Codfilialretira";
    private string? _codfilialretira;
    

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCORTEFV", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 10, Precisao = 0)]
    public int? Numpedrca
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
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCORTEFV", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 10, Precisao = 0)]
    public int? Numped
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
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCORTEFV", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 4, Precisao = 0)]
    public int? Codusur
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
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCORTEFV", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 6, Precisao = 0)]
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
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCORTEFV", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 0, Precisao = 0)]
    public DateTime? Dtaberturapedpalm
    {
        get
        {
            PropriedadeAcessada(RO_DTABERTURAPEDPALM);
            return _dtaberturapedpalm;
        }
        set
        {
            PropriedadeModificada(RO_DTABERTURAPEDPALM, value);
            _dtaberturapedpalm = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCORTEFV", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 6, Precisao = 0)]
    public int? Codprod
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
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCORTEFV", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 20, Precisao = 0)]
    public int? Codauxiliar
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
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCORTEFV", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 20, Precisao = 0)]
    public int? Numseq
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
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCORTEFV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 20, Precisao = 6)]
    public decimal? Qtant
    {
        get
        {
            PropriedadeAcessada(RO_QTANT);
            return _qtant;
        }
        set
        {
            PropriedadeModificada(RO_QTANT, value);
            _qtant = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCORTEFV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 20, Precisao = 6)]
    public decimal? Qtcorte
    {
        get
        {
            PropriedadeAcessada(RO_QTCORTE);
            return _qtcorte;
        }
        set
        {
            PropriedadeModificada(RO_QTCORTE, value);
            _qtcorte = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCORTEFV", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 0, Precisao = 0)]
    public DateTime? Dtcorte
    {
        get
        {
            PropriedadeAcessada(RO_DTCORTE);
            return _dtcorte;
        }
        set
        {
            PropriedadeModificada(RO_DTCORTE, value);
            _dtcorte = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCORTEFV", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Codfunccorte
    {
        get
        {
            PropriedadeAcessada(RO_CODFUNCCORTE);
            return _codfunccorte;
        }
        set
        {
            PropriedadeModificada(RO_CODFUNCCORTE, value);
            _codfunccorte = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCORTEFV", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Programa
    {
        get
        {
            PropriedadeAcessada(RO_PROGRAMA);
            return _programa;
        }
        set
        {
            PropriedadeModificada(RO_PROGRAMA, value);
            _programa = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCORTEFV", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Maquina
    {
        get
        {
            PropriedadeAcessada(RO_MAQUINA);
            return _maquina;
        }
        set
        {
            PropriedadeModificada(RO_MAQUINA, value);
            _maquina = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCORTEFV", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Codfilial
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
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCORTEFV", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Codfilialretira
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

    public void InicializarAtributos() { }

    public string ObterNomeTabela() => "PCCORTEFV";

    public IEntidade NovaInstancia() => (IEntidade)GetType().GetConstructors()[0].Invoke(null);

    public void CarregarPorDataReader(IDataReader leitor)
    {
        _numpedrca = AlterarTipo<int?>(leitor["Numpedrca"]);
        _numped = AlterarTipo<int?>(leitor["Numped"]);
        _codusur = AlterarTipo<int?>(leitor["Codusur"]);
        _codcli = AlterarTipo<int?>(leitor["Codcli"]);
        _dtaberturapedpalm = AlterarTipo<DateTime?>(leitor["Dtaberturapedpalm"]);
        _codprod = AlterarTipo<int?>(leitor["Codprod"]);
        _codauxiliar = AlterarTipo<int?>(leitor["Codauxiliar"]);
        _numseq = AlterarTipo<int?>(leitor["Numseq"]);
        _qtant = AlterarTipo<decimal?>(leitor["Qtant"]);
        _qtcorte = AlterarTipo<decimal?>(leitor["Qtcorte"]);
        _dtcorte = AlterarTipo<DateTime?>(leitor["Dtcorte"]);
        _codfunccorte = AlterarTipo<string?>(leitor["Codfunccorte"]);
        _programa = AlterarTipo<string?>(leitor["Programa"]);
        _maquina = AlterarTipo<string?>(leitor["Maquina"]);
        _codfilial = AlterarTipo<string?>(leitor["Codfilial"]);
        _codfilialretira = AlterarTipo<string?>(leitor["Codfilialretira"]);
    }
}