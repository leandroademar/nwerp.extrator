[Serializable]
public class PCBANCOFILIAIS : GerenteDePropriedades, IEntidade
{
    private static readonly string RO_CODBANCO = "Codbanco";
    private int _codbanco;
    
    private static readonly string RO_CODFILIAL = "Codfilial";
    private string _codfilial;
    

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCBANCOFILIAIS", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 4, Precisao = 0)]
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
    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCBANCOFILIAIS", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
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

    public void InicializarAtributos() { }

    public string ObterNomeTabela() => "PCBANCOFILIAIS";

    public IEntidade NovaInstancia() => (IEntidade)GetType().GetConstructors()[0].Invoke(null);

    public void CarregarPorDataReader(IDataReader leitor)
    {
        _codbanco = AlterarTipo<int>(leitor["Codbanco"]);
        _codfilial = AlterarTipo<string>(leitor["Codfilial"]);
    }
}