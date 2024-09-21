[Serializable]
public class PCCONTROLECX : GerenteDePropriedades, IEntidade
{
    private static readonly string RO_CODBANCO = "Codbanco";
    private int _codbanco;
    
    private static readonly string RO_CODFUNCCAIXA = "Codfunccaixa";
    private int _codfunccaixa;
    
    private static readonly string RO_DTABERTURA = "Dtabertura";
    private DateTime _dtabertura;
    
    private static readonly string RO_DTFECHAMENTO = "Dtfechamento";
    private DateTime? _dtfechamento;
    
    private static readonly string RO_DTLIMITEFECHAMENTO = "Dtlimitefechamento";
    private DateTime? _dtlimitefechamento;
    

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCCONTROLECX", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 4, Precisao = 0)]
    public int Codbanco
    {
        get
        {
            PropriedadeAcessada(RO_CODBANCO);
            return _codbanco;
        }
        set
        {
            PropriedadeModificada(RO_CODBANCO, value);
            _codbanco = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCCONTROLECX", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 8, Precisao = 0)]
    public int Codfunccaixa
    {
        get
        {
            PropriedadeAcessada(RO_CODFUNCCAIXA);
            return _codfunccaixa;
        }
        set
        {
            PropriedadeModificada(RO_CODFUNCCAIXA, value);
            _codfunccaixa = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCCONTROLECX", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 0, Precisao = 0)]
    public DateTime Dtabertura
    {
        get
        {
            PropriedadeAcessada(RO_DTABERTURA);
            return _dtabertura;
        }
        set
        {
            PropriedadeModificada(RO_DTABERTURA, value);
            _dtabertura = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONTROLECX", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 0, Precisao = 0)]
    public DateTime? Dtfechamento
    {
        get
        {
            PropriedadeAcessada(RO_DTFECHAMENTO);
            return _dtfechamento;
        }
        set
        {
            PropriedadeModificada(RO_DTFECHAMENTO, value);
            _dtfechamento = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONTROLECX", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 0, Precisao = 0)]
    public DateTime? Dtlimitefechamento
    {
        get
        {
            PropriedadeAcessada(RO_DTLIMITEFECHAMENTO);
            return _dtlimitefechamento;
        }
        set
        {
            PropriedadeModificada(RO_DTLIMITEFECHAMENTO, value);
            _dtlimitefechamento = value;
        }
    }

    public void InicializarAtributos() { }

    public string ObterNomeTabela() => "PCCONTROLECX";

    public IEntidade NovaInstancia() => (IEntidade)GetType().GetConstructors()[0].Invoke(null);

    public void CarregarPorDataReader(IDataReader leitor)
    {
        _codbanco = AlterarTipo<int>(leitor["Codbanco"]);
        _codfunccaixa = AlterarTipo<int>(leitor["Codfunccaixa"]);
        _dtabertura = AlterarTipo<DateTime>(leitor["Dtabertura"]);
        _dtfechamento = AlterarTipo<DateTime?>(leitor["Dtfechamento"]);
        _dtlimitefechamento = AlterarTipo<DateTime?>(leitor["Dtlimitefechamento"]);
    }
}