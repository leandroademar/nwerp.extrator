[Serializable]
public class PCSECAO : GerenteDePropriedades, IEntidade
{
    private static readonly string RO_CODSEC = "Codsec";
    private int _codsec;
    
    private static readonly string RO_DESCRICAO = "Descricao";
    private string _descricao;
    
    private static readonly string RO_CODEPTO = "Codepto";
    private int _codepto;
    
    private static readonly string RO_QTMAX = "Qtmax";
    private decimal? _qtmax;
    
    private static readonly string RO_TIPO = "Tipo";
    private string? _tipo;
    
    private static readonly string RO_CODSECNESTLE = "Codsecnestle";
    private int? _codsecnestle;
    
    private static readonly string RO_LINHA = "Linha";
    private string? _linha;
    
    private static readonly string RO_DTEXCLUSAO = "Dtexclusao";
    private DateTime? _dtexclusao;
    
    private static readonly string RO_IDINTEGRACAOCIASHOP = "Idintegracaociashop";
    private string? _idintegracaociashop;
    
    private static readonly string RO_ENVIAECOMMERCE = "Enviaecommerce";
    private string? _enviaecommerce;
    
    private static readonly string RO_DTULTALTER = "Dtultalter";
    private DateTime? _dtultalter;
    
    private static readonly string RO_DTCADASTRO = "Dtcadastro";
    private DateTime? _dtcadastro;
    

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCSECAO", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 6, Precisao = 0)]
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
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCSECAO", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string Descricao
    {
        get
        {
            PropriedadeAcessada(RO_DESCRICAO);
            return _descricao;
        }
        set
        {
            PropriedadeModificada(RO_DESCRICAO, value);
            _descricao = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCSECAO", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 6, Precisao = 0)]
    public int Codepto
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
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCSECAO", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 3)]
    public decimal? Qtmax
    {
        get
        {
            PropriedadeAcessada(RO_QTMAX);
            return _qtmax;
        }
        set
        {
            PropriedadeModificada(RO_QTMAX, value);
            _qtmax = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCSECAO", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Tipo
    {
        get
        {
            PropriedadeAcessada(RO_TIPO);
            return _tipo;
        }
        set
        {
            PropriedadeModificada(RO_TIPO, value);
            _tipo = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCSECAO", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 6, Precisao = 0)]
    public int? Codsecnestle
    {
        get
        {
            PropriedadeAcessada(RO_CODSECNESTLE);
            return _codsecnestle;
        }
        set
        {
            PropriedadeModificada(RO_CODSECNESTLE, value);
            _codsecnestle = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCSECAO", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Linha
    {
        get
        {
            PropriedadeAcessada(RO_LINHA);
            return _linha;
        }
        set
        {
            PropriedadeModificada(RO_LINHA, value);
            _linha = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCSECAO", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 0, Precisao = 0)]
    public DateTime? Dtexclusao
    {
        get
        {
            PropriedadeAcessada(RO_DTEXCLUSAO);
            return _dtexclusao;
        }
        set
        {
            PropriedadeModificada(RO_DTEXCLUSAO, value);
            _dtexclusao = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCSECAO", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
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
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCSECAO", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
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
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCSECAO", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 0, Precisao = 0)]
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
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCSECAO", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 0, Precisao = 0)]
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

    public string ObterNomeTabela() => "PCSECAO";

    public IEntidade NovaInstancia() => (IEntidade)GetType().GetConstructors()[0].Invoke(null);

    public void CarregarPorDataReader(IDataReader leitor)
    {
        _codsec = AlterarTipo<int>(leitor["Codsec"]);
        _descricao = AlterarTipo<string>(leitor["Descricao"]);
        _codepto = AlterarTipo<int>(leitor["Codepto"]);
        _qtmax = AlterarTipo<decimal?>(leitor["Qtmax"]);
        _tipo = AlterarTipo<string?>(leitor["Tipo"]);
        _codsecnestle = AlterarTipo<int?>(leitor["Codsecnestle"]);
        _linha = AlterarTipo<string?>(leitor["Linha"]);
        _dtexclusao = AlterarTipo<DateTime?>(leitor["Dtexclusao"]);
        _idintegracaociashop = AlterarTipo<string?>(leitor["Idintegracaociashop"]);
        _enviaecommerce = AlterarTipo<string?>(leitor["Enviaecommerce"]);
        _dtultalter = AlterarTipo<DateTime?>(leitor["Dtultalter"]);
        _dtcadastro = AlterarTipo<DateTime?>(leitor["Dtcadastro"]);
    }
}