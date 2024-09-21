[Serializable]
public class PCCENTROCUSTO : GerenteDePropriedades, IEntidade
{
    private static readonly string RO_DESCRICAO = "Descricao";
    private string? _descricao;
    
    private static readonly string RO_CODCENTROCUSTO = "Codcentrocusto";
    private string? _codcentrocusto;
    
    private static readonly string RO_RECEBE_LANCTO = "Recebe_lancto";
    private string? _recebe_lancto;
    
    private static readonly string RO_ATIVO = "Ativo";
    private string? _ativo;
    
    private static readonly string RO_CODIGOCENTROCUSTO = "Codigocentrocusto";
    private string _codigocentrocusto;
    
    private static readonly string RO_CODIGOCENTROCUSTOINTFOLHA = "Codigocentrocustointfolha";
    private string? _codigocentrocustointfolha;
    
    private static readonly string RO_DTINCLUSAO = "Dtinclusao";
    private DateTime? _dtinclusao;
    
    private static readonly string RO_DTALTERACAO = "Dtalteracao";
    private DateTime? _dtalteracao;
    

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCENTROCUSTO", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Descricao
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
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCENTROCUSTO", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Codcentrocusto
    {
        get
        {
            PropriedadeAcessada(RO_CODCENTROCUSTO);
            return _codcentrocusto;
        }
        set
        {
            PropriedadeModificada(RO_CODCENTROCUSTO, value);
            _codcentrocusto = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCENTROCUSTO", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Recebe_lancto
    {
        get
        {
            PropriedadeAcessada(RO_RECEBE_LANCTO);
            return _recebe_lancto;
        }
        set
        {
            PropriedadeModificada(RO_RECEBE_LANCTO, value);
            _recebe_lancto = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCENTROCUSTO", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
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
    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCCENTROCUSTO", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string Codigocentrocusto
    {
        get
        {
            PropriedadeAcessada(RO_CODIGOCENTROCUSTO);
            return _codigocentrocusto;
        }
        set
        {
            PropriedadeModificada(RO_CODIGOCENTROCUSTO, value);
            _codigocentrocusto = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCENTROCUSTO", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Codigocentrocustointfolha
    {
        get
        {
            PropriedadeAcessada(RO_CODIGOCENTROCUSTOINTFOLHA);
            return _codigocentrocustointfolha;
        }
        set
        {
            PropriedadeModificada(RO_CODIGOCENTROCUSTOINTFOLHA, value);
            _codigocentrocustointfolha = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCENTROCUSTO", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 0, Precisao = 0)]
    public DateTime? Dtinclusao
    {
        get
        {
            PropriedadeAcessada(RO_DTINCLUSAO);
            return _dtinclusao;
        }
        set
        {
            PropriedadeModificada(RO_DTINCLUSAO, value);
            _dtinclusao = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCENTROCUSTO", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 0, Precisao = 0)]
    public DateTime? Dtalteracao
    {
        get
        {
            PropriedadeAcessada(RO_DTALTERACAO);
            return _dtalteracao;
        }
        set
        {
            PropriedadeModificada(RO_DTALTERACAO, value);
            _dtalteracao = value;
        }
    }

    public void InicializarAtributos() { }

    public string ObterNomeTabela() => "PCCENTROCUSTO";

    public IEntidade NovaInstancia() => (IEntidade)GetType().GetConstructors()[0].Invoke(null);

    public void CarregarPorDataReader(IDataReader leitor)
    {
        _descricao = AlterarTipo<string?>(leitor["Descricao"]);
        _codcentrocusto = AlterarTipo<string?>(leitor["Codcentrocusto"]);
        _recebe_lancto = AlterarTipo<string?>(leitor["Recebe_lancto"]);
        _ativo = AlterarTipo<string?>(leitor["Ativo"]);
        _codigocentrocusto = AlterarTipo<string>(leitor["Codigocentrocusto"]);
        _codigocentrocustointfolha = AlterarTipo<string?>(leitor["Codigocentrocustointfolha"]);
        _dtinclusao = AlterarTipo<DateTime?>(leitor["Dtinclusao"]);
        _dtalteracao = AlterarTipo<DateTime?>(leitor["Dtalteracao"]);
    }
}