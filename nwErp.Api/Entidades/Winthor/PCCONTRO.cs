[Serializable]
public class PCCONTRO : GerenteDePropriedades, IEntidade
{
    private static readonly string RO_CODUSUARIO = "Codusuario";
    private int _codusuario;
    
    private static readonly string RO_CODROTINA = "Codrotina";
    private int _codrotina;
    
    private static readonly string RO_ACESSO = "Acesso";
    private string _acesso;
    
    private static readonly string RO_CODBANCO = "Codbanco";
    private int? _codbanco;
    
    private static readonly string RO_CODMOEDA = "Codmoeda";
    private string? _codmoeda;
    
    private static readonly string RO_CODEPTO = "Codepto";
    private int? _codepto;
    

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCCONTRO", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 8, Precisao = 0)]
    public int Codusuario
    {
        get
        {
            PropriedadeAcessada(RO_CODUSUARIO);
            return _codusuario;
        }
        set
        {
            PropriedadeModificada(RO_CODUSUARIO, value);
            _codusuario = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCCONTRO", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 6, Precisao = 0)]
    public int Codrotina
    {
        get
        {
            PropriedadeAcessada(RO_CODROTINA);
            return _codrotina;
        }
        set
        {
            PropriedadeModificada(RO_CODROTINA, value);
            _codrotina = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONTRO", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string Acesso
    {
        get
        {
            PropriedadeAcessada(RO_ACESSO);
            return _acesso;
        }
        set
        {
            PropriedadeModificada(RO_ACESSO, value);
            _acesso = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONTRO", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 4, Precisao = 0)]
    public int? Codbanco
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
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONTRO", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Codmoeda
    {
        get
        {
            PropriedadeAcessada(RO_CODMOEDA);
            return _codmoeda;
        }
        set
        {
            PropriedadeModificada(RO_CODMOEDA, value);
            _codmoeda = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONTRO", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 6, Precisao = 0)]
    public int? Codepto
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

    public void InicializarAtributos() { }

    public string ObterNomeTabela() => "PCCONTRO";

    public IEntidade NovaInstancia() => (IEntidade)GetType().GetConstructors()[0].Invoke(null);

    public void CarregarPorDataReader(IDataReader leitor)
    {
        _codusuario = AlterarTipo<int>(leitor["Codusuario"]);
        _codrotina = AlterarTipo<int>(leitor["Codrotina"]);
        _acesso = AlterarTipo<string>(leitor["Acesso"]);
        _codbanco = AlterarTipo<int?>(leitor["Codbanco"]);
        _codmoeda = AlterarTipo<string?>(leitor["Codmoeda"]);
        _codepto = AlterarTipo<int?>(leitor["Codepto"]);
    }
}