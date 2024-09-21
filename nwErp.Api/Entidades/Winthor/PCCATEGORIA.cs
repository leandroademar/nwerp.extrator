[Serializable]
public class PCCATEGORIA : GerenteDePropriedades, IEntidade
{
    private static readonly string RO_CODSEC = "Codsec";
    private int _codsec;
    
    private static readonly string RO_CODCATEGORIA = "Codcategoria";
    private int _codcategoria;
    
    private static readonly string RO_CATEGORIA = "Categoria";
    private string? _categoria;
    
    private static readonly string RO_IDINTEGRACAOCIASHOP = "Idintegracaociashop";
    private string? _idintegracaociashop;
    
    private static readonly string RO_ENVIAECOMMERCE = "Enviaecommerce";
    private string? _enviaecommerce;
    
    private static readonly string RO_DTULTALTER = "Dtultalter";
    private DateTime? _dtultalter;
    
    private static readonly string RO_DTCADASTRO = "Dtcadastro";
    private DateTime? _dtcadastro;
    

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCCATEGORIA", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 6, Precisao = 0)]
    public int Codsec
    {
        get
        {
            PropriedadeAcessada(RO_CODSEC);
            return _codsec;
        }
        set
        {
            PropriedadeModificada(RO_CODSEC, value);
            _codsec = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCCATEGORIA", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 6, Precisao = 0)]
    public int Codcategoria
    {
        get
        {
            PropriedadeAcessada(RO_CODCATEGORIA);
            return _codcategoria;
        }
        set
        {
            PropriedadeModificada(RO_CODCATEGORIA, value);
            _codcategoria = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCATEGORIA", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Categoria
    {
        get
        {
            PropriedadeAcessada(RO_CATEGORIA);
            return _categoria;
        }
        set
        {
            PropriedadeModificada(RO_CATEGORIA, value);
            _categoria = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCATEGORIA", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Idintegracaociashop
    {
        get
        {
            PropriedadeAcessada(RO_IDINTEGRACAOCIASHOP);
            return _idintegracaociashop;
        }
        set
        {
            PropriedadeModificada(RO_IDINTEGRACAOCIASHOP, value);
            _idintegracaociashop = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCATEGORIA", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Enviaecommerce
    {
        get
        {
            PropriedadeAcessada(RO_ENVIAECOMMERCE);
            return _enviaecommerce;
        }
        set
        {
            PropriedadeModificada(RO_ENVIAECOMMERCE, value);
            _enviaecommerce = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCATEGORIA", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 0, Precisao = 0)]
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
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCATEGORIA", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 0, Precisao = 0)]
    public DateTime? Dtcadastro
    {
        get
        {
            PropriedadeAcessada(RO_DTCADASTRO);
            return _dtcadastro;
        }
        set
        {
            PropriedadeModificada(RO_DTCADASTRO, value);
            _dtcadastro = value;
        }
    }

    public void InicializarAtributos() { }

    public string ObterNomeTabela() => "PCCATEGORIA";

    public IEntidade NovaInstancia() => (IEntidade)GetType().GetConstructors()[0].Invoke(null);

    public void CarregarPorDataReader(IDataReader leitor)
    {
        _codsec = AlterarTipo<int>(leitor["Codsec"]);
        _codcategoria = AlterarTipo<int>(leitor["Codcategoria"]);
        _categoria = AlterarTipo<string?>(leitor["Categoria"]);
        _idintegracaociashop = AlterarTipo<string?>(leitor["Idintegracaociashop"]);
        _enviaecommerce = AlterarTipo<string?>(leitor["Enviaecommerce"]);
        _dtultalter = AlterarTipo<DateTime?>(leitor["Dtultalter"]);
        _dtcadastro = AlterarTipo<DateTime?>(leitor["Dtcadastro"]);
    }
}