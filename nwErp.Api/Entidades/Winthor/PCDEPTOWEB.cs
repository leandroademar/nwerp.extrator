[Serializable]
public class PCDEPTOWEB : GerenteDePropriedades, IEntidade
{
    private static readonly string RO_CODDEPTO = "Coddepto";
    private int _coddepto;
    
    private static readonly string RO_DESCRICAO = "Descricao";
    private string _descricao;
    
    private static readonly string RO_QTDIASESTSEGURANCA = "Qtdiasestseguranca";
    private decimal? _qtdiasestseguranca;
    
    private static readonly string RO_SITUACAOWEB = "Situacaoweb";
    private string? _situacaoweb;
    
    private static readonly string RO_DTCADASTRO = "Dtcadastro";
    private DateTime? _dtcadastro;
    
    private static readonly string RO_DTULTALTER = "Dtultalter";
    private DateTime? _dtultalter;
    

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCDEPTOWEB", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 10, Precisao = 0)]
    public int Coddepto
    {
        get
        {
            PropriedadeAcessada(RO_CODDEPTO);
            return _coddepto;
        }
        set
        {
            PropriedadeModificada(RO_CODDEPTO, value);
            _coddepto = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCDEPTOWEB", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
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
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCDEPTOWEB", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 2)]
    public decimal? Qtdiasestseguranca
    {
        get
        {
            PropriedadeAcessada(RO_QTDIASESTSEGURANCA);
            return _qtdiasestseguranca;
        }
        set
        {
            PropriedadeModificada(RO_QTDIASESTSEGURANCA, value);
            _qtdiasestseguranca = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCDEPTOWEB", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Situacaoweb
    {
        get
        {
            PropriedadeAcessada(RO_SITUACAOWEB);
            return _situacaoweb;
        }
        set
        {
            PropriedadeModificada(RO_SITUACAOWEB, value);
            _situacaoweb = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCDEPTOWEB", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 0, Precisao = 0)]
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
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCDEPTOWEB", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 0, Precisao = 0)]
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

    public string ObterNomeTabela() => "PCDEPTOWEB";

    public IEntidade NovaInstancia() => (IEntidade)GetType().GetConstructors()[0].Invoke(null);

    public void CarregarPorDataReader(IDataReader leitor)
    {
        _coddepto = AlterarTipo<int>(leitor["Coddepto"]);
        _descricao = AlterarTipo<string>(leitor["Descricao"]);
        _qtdiasestseguranca = AlterarTipo<decimal?>(leitor["Qtdiasestseguranca"]);
        _situacaoweb = AlterarTipo<string?>(leitor["Situacaoweb"]);
        _dtcadastro = AlterarTipo<DateTime?>(leitor["Dtcadastro"]);
        _dtultalter = AlterarTipo<DateTime?>(leitor["Dtultalter"]);
    }
}