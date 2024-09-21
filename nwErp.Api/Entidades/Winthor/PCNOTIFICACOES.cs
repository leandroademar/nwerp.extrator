

////// namespace nwErp.Entidades.Winthor;

// namespace nwErp.Api.Modelos;

[Serializable]
public class PCNOTIFICACOES : GerenteDePropriedades, IEntidade
{
    private decimal _bloquearexecucaoemdias;

    private string _bloqueiaaberturarotina;

    private decimal _codigorotina;

    private DateTime _datahoracadastro;

    private DateTime? _datahoraprimeiraexecucao;

    private decimal _sequencia;

    private decimal? _sequenciaanulada;

    private string _status;

    private string _tipo;

    private string _versaoerro;

    private decimal? _versaoerronumerico;

    private string _versaosolucao;

    private decimal? _versaosolucaonumerico;

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNOTIFICACOES", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 3, Precisao = 0)]
    public decimal Bloquearexecucaoemdias
    {
        get
        {
            PropriedadeAcessada("Bloquearexecucaoemdias");
            return _bloquearexecucaoemdias;
        }
        set
        {
            PropriedadeModificada("Bloquearexecucaoemdias", value);
            _bloquearexecucaoemdias = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNOTIFICACOES", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Bloqueiaaberturarotina
    {
        get
        {
            PropriedadeAcessada("Bloqueiaaberturarotina");
            return _bloqueiaaberturarotina;
        }
        set
        {
            PropriedadeModificada("Bloqueiaaberturarotina", value);
            _bloqueiaaberturarotina = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNOTIFICACOES", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal Codigorotina
    {
        get
        {
            PropriedadeAcessada("Codigorotina");
            return _codigorotina;
        }
        set
        {
            PropriedadeModificada("Codigorotina", value);
            _codigorotina = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNOTIFICACOES", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime Datahoracadastro
    {
        get
        {
            PropriedadeAcessada("Datahoracadastro");
            return _datahoracadastro;
        }
        set
        {
            PropriedadeModificada("Datahoracadastro", value);
            _datahoracadastro = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNOTIFICACOES", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Datahoraprimeiraexecucao
    {
        get
        {
            PropriedadeAcessada("Datahoraprimeiraexecucao");
            return _datahoraprimeiraexecucao;
        }
        set
        {
            PropriedadeModificada("Datahoraprimeiraexecucao", value);
            _datahoraprimeiraexecucao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCNOTIFICACOES", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal Sequencia
    {
        get
        {
            PropriedadeAcessada("Sequencia");
            return _sequencia;
        }
        set
        {
            PropriedadeModificada("Sequencia", value);
            _sequencia = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNOTIFICACOES", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Sequenciaanulada
    {
        get
        {
            PropriedadeAcessada("Sequenciaanulada");
            return _sequenciaanulada;
        }
        set
        {
            PropriedadeModificada("Sequenciaanulada", value);
            _sequenciaanulada = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNOTIFICACOES", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Status
    {
        get
        {
            PropriedadeAcessada("Status");
            return _status;
        }
        set
        {
            PropriedadeModificada("Status", value);
            _status = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNOTIFICACOES", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Tipo
    {
        get
        {
            PropriedadeAcessada("Tipo");
            return _tipo;
        }
        set
        {
            PropriedadeModificada("Tipo", value);
            _tipo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNOTIFICACOES", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 15, Precisao = 0)]
    public string Versaoerro
    {
        get
        {
            PropriedadeAcessada("Versaoerro");
            return _versaoerro;
        }
        set
        {
            PropriedadeModificada("Versaoerro", value);
            _versaoerro = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNOTIFICACOES", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 0)]
    public decimal? Versaoerronumerico
    {
        get
        {
            PropriedadeAcessada("Versaoerronumerico");
            return _versaoerronumerico;
        }
        set
        {
            PropriedadeModificada("Versaoerronumerico", value);
            _versaoerronumerico = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNOTIFICACOES", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 15, Precisao = 0)]
    public string Versaosolucao
    {
        get
        {
            PropriedadeAcessada("Versaosolucao");
            return _versaosolucao;
        }
        set
        {
            PropriedadeModificada("Versaosolucao", value);
            _versaosolucao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNOTIFICACOES", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 0)]
    public decimal? Versaosolucaonumerico
    {
        get
        {
            PropriedadeAcessada("Versaosolucaonumerico");
            return _versaosolucaonumerico;
        }
        set
        {
            PropriedadeModificada("Versaosolucaonumerico", value);
            _versaosolucaonumerico = value;
        }
    }

    public void InicializarAtributos()
    {
    }

    public string ObterNomeTabela()
    {
        return "PCNOTIFICACOES";
    }

    public IEntidade NovaInstancia()
    {
        return (IEntidade)GetType().GetConstructors()[0].Invoke(null);
    }

    public void CarregarPorDataReader(IDataReader leitor)
    {
        _bloquearexecucaoemdias = AlterarTipo<decimal>(leitor["Bloquearexecucaoemdias"]);
        _bloqueiaaberturarotina = AlterarTipo<string>(leitor["Bloqueiaaberturarotina"]);
        _codigorotina = AlterarTipo<decimal>(leitor["Codigorotina"]);
        _datahoracadastro = AlterarTipo<DateTime>(leitor["Datahoracadastro"]);
        _datahoraprimeiraexecucao = AlterarTipo<DateTime?>(leitor["Datahoraprimeiraexecucao"]);
        _sequencia = AlterarTipo<decimal>(leitor["Sequencia"]);
        _sequenciaanulada = AlterarTipo<decimal?>(leitor["Sequenciaanulada"]);
        _status = AlterarTipo<string>(leitor["Status"]);
        _tipo = AlterarTipo<string>(leitor["Tipo"]);
        _versaoerro = AlterarTipo<string>(leitor["Versaoerro"]);
        _versaoerronumerico = AlterarTipo<decimal?>(leitor["Versaoerronumerico"]);
        _versaosolucao = AlterarTipo<string>(leitor["Versaosolucao"]);
        _versaosolucaonumerico = AlterarTipo<decimal?>(leitor["Versaosolucaonumerico"]);
    }

}