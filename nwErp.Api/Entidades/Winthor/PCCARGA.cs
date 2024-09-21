[Serializable]
public class PCCARGA : GerenteDePropriedades, IEntidade
{
    private static readonly string RO_TABELAORIGEM = "Tabelaorigem";
    private string? _tabelaorigem;
    
    private static readonly string RO_TABELADESTINO = "Tabeladestino";
    private string? _tabeladestino;
    
    private static readonly string RO_DTULTALTER = "Dtultalter";
    private DateTime? _dtultalter;
    

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCARGA", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Tabelaorigem
    {
        get
        {
            PropriedadeAcessada(RO_TABELAORIGEM);
            return _tabelaorigem;
        }
        set
        {
            PropriedadeModificada(RO_TABELAORIGEM, value);
            _tabelaorigem = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCARGA", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Tabeladestino
    {
        get
        {
            PropriedadeAcessada(RO_TABELADESTINO);
            return _tabeladestino;
        }
        set
        {
            PropriedadeModificada(RO_TABELADESTINO, value);
            _tabeladestino = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCARGA", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 0, Precisao = 0)]
    public DateTime? Dtultalter
    {
        get
        {
            PropriedadeAcessada(RO_DTULTALTER);
            return _dtultalter;
        }
        set
        {
            PropriedadeModificada(RO_DTULTALTER, value);
            _dtultalter = value;
        }
    }

    public void InicializarAtributos() { }

    public string ObterNomeTabela() => "PCCARGA";

    public IEntidade NovaInstancia() => (IEntidade)GetType().GetConstructors()[0].Invoke(null);

    public void CarregarPorDataReader(IDataReader leitor)
    {
        _tabelaorigem = AlterarTipo<string?>(leitor["Tabelaorigem"]);
        _tabeladestino = AlterarTipo<string?>(leitor["Tabeladestino"]);
        _dtultalter = AlterarTipo<DateTime?>(leitor["Dtultalter"]);
    }
}