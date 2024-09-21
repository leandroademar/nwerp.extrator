[Serializable]
public class PCMARCA : GerenteDePropriedades, IEntidade
{
    private static readonly string RO_CODMARCA = "Codmarca";
    private int _codmarca;
    
    private static readonly string RO_MARCA = "Marca";
    private string? _marca;
    
    private static readonly string RO_ATIVO = "Ativo";
    private string? _ativo;
    
    private static readonly string RO_CODADWORDS = "Codadwords";
    private string? _codadwords;
    
    private static readonly string RO_DESCRICAOECOMMERCE = "Descricaoecommerce";
    private string? _descricaoecommerce;
    
    private static readonly string RO_CODCAMPLOMADEE = "Codcamplomadee";
    private string? _codcamplomadee;
    
    private static readonly string RO_TITULO = "Titulo";
    private string? _titulo;
    
    private static readonly string RO_DTULTALTER = "Dtultalter";
    private DateTime? _dtultalter;
    
    private static readonly string RO_DTCADASTRO = "Dtcadastro";
    private DateTime? _dtcadastro;
    
    private static readonly string RO_CODCOMPRADOR = "Codcomprador";
    private int? _codcomprador;
    

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCMARCA", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 8, Precisao = 0)]
    public int Codmarca
    {
        get
        {
            PropriedadeAcessada(RO_CODMARCA);
            return _codmarca;
        }
        set
        {
            PropriedadeModificada(RO_CODMARCA, value);
            _codmarca = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMARCA", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Marca
    {
        get
        {
            PropriedadeAcessada(RO_MARCA);
            return _marca;
        }
        set
        {
            PropriedadeModificada(RO_MARCA, value);
            _marca = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMARCA", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Ativo
    {
        get
        {
            PropriedadeAcessada(RO_ATIVO);
            return _ativo;
        }
        set
        {
            PropriedadeModificada(RO_ATIVO, value);
            _ativo = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMARCA", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Codadwords
    {
        get
        {
            PropriedadeAcessada(RO_CODADWORDS);
            return _codadwords;
        }
        set
        {
            PropriedadeModificada(RO_CODADWORDS, value);
            _codadwords = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMARCA", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Descricaoecommerce
    {
        get
        {
            PropriedadeAcessada(RO_DESCRICAOECOMMERCE);
            return _descricaoecommerce;
        }
        set
        {
            PropriedadeModificada(RO_DESCRICAOECOMMERCE, value);
            _descricaoecommerce = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMARCA", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Codcamplomadee
    {
        get
        {
            PropriedadeAcessada(RO_CODCAMPLOMADEE);
            return _codcamplomadee;
        }
        set
        {
            PropriedadeModificada(RO_CODCAMPLOMADEE, value);
            _codcamplomadee = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMARCA", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Titulo
    {
        get
        {
            PropriedadeAcessada(RO_TITULO);
            return _titulo;
        }
        set
        {
            PropriedadeModificada(RO_TITULO, value);
            _titulo = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMARCA", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 0, Precisao = 0)]
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
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMARCA", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 0, Precisao = 0)]
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
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMARCA", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 8, Precisao = 0)]
    public int? Codcomprador
    {
        get
        {
            PropriedadeAcessada(RO_CODCOMPRADOR);
            return _codcomprador;
        }
        set
        {
            PropriedadeModificada(RO_CODCOMPRADOR, value);
            _codcomprador = value;
        }
    }

    public void InicializarAtributos() { }

    public string ObterNomeTabela() => "PCMARCA";

    public IEntidade NovaInstancia() => (IEntidade)GetType().GetConstructors()[0].Invoke(null);

    public void CarregarPorDataReader(IDataReader leitor)
    {
        _codmarca = AlterarTipo<int>(leitor["Codmarca"]);
        _marca = AlterarTipo<string?>(leitor["Marca"]);
        _ativo = AlterarTipo<string?>(leitor["Ativo"]);
        _codadwords = AlterarTipo<string?>(leitor["Codadwords"]);
        _descricaoecommerce = AlterarTipo<string?>(leitor["Descricaoecommerce"]);
        _codcamplomadee = AlterarTipo<string?>(leitor["Codcamplomadee"]);
        _titulo = AlterarTipo<string?>(leitor["Titulo"]);
        _dtultalter = AlterarTipo<DateTime?>(leitor["Dtultalter"]);
        _dtcadastro = AlterarTipo<DateTime?>(leitor["Dtcadastro"]);
        _codcomprador = AlterarTipo<int?>(leitor["Codcomprador"]);
    }
}