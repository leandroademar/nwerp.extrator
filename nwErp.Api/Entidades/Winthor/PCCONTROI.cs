[Serializable]
public class PCCONTROI : GerenteDePropriedades, IEntidade
{
    private static readonly string RO_CODROTINA = "Codrotina";
    private int _codrotina;
    
    private static readonly string RO_CODCONTROLE = "Codcontrole";
    private int _codcontrole;
    
    private static readonly string RO_CODUSUARIO = "Codusuario";
    private int _codusuario;
    
    private static readonly string RO_ACESSO = "Acesso";
    private string? _acesso;
    

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCCONTROI", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 6, Precisao = 0)]
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
    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCCONTROI", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 6, Precisao = 0)]
    public int Codcontrole
    {
        get
        {
            PropriedadeAcessada(RO_CODCONTROLE);
            return _codcontrole;
        }
        set
        {
            PropriedadeModificada(RO_CODCONTROLE, value);
            _codcontrole = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCCONTROI", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 8, Precisao = 0)]
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
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONTROI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Acesso
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

    public void InicializarAtributos() { }

    public string ObterNomeTabela() => "PCCONTROI";

    public IEntidade NovaInstancia() => (IEntidade)GetType().GetConstructors()[0].Invoke(null);

    public void CarregarPorDataReader(IDataReader leitor)
    {
        _codrotina = AlterarTipo<int>(leitor["Codrotina"]);
        _codcontrole = AlterarTipo<int>(leitor["Codcontrole"]);
        _codusuario = AlterarTipo<int>(leitor["Codusuario"]);
        _acesso = AlterarTipo<string?>(leitor["Acesso"]);
    }
}