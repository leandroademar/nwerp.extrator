

////// namespace nwErp.Entidades.Winthor;

// namespace nwErp.Api.Modelos;

[Serializable]
public class PCLOGDADOSPESSOAS : GerenteDePropriedades, IEntidade
{
    private static readonly string RO_DATA_REGISTRO = "Data_registro";

    private DateTime? _data_registro;

    private static readonly string RO_DATA_REQUISICAO = "Data_requisicao";

    private DateTime? _data_requisicao;

    private static readonly string RO_DESCRICAO = "Descricao";

    private string _descricao;

    private static readonly string RO_DADOS_ANTERIOR = "Dados_anterior";

    private string _dados_anterior;

    private static readonly string RO_DADOS_ATUAL = "Dados_atual";

    private string _dados_atual;

    private static readonly string RO_CODIGO_CADASTRO = "Codigo_cadastro";

    private string _codigo_cadastro;

    private static readonly string RO_TABELA = "Tabela";

    private string _tabela;

    private static readonly string RO_MATRICULA = "Matricula";

    private decimal? _matricula;

    private static readonly string RO_ROTINA = "Rotina";

    private string _rotina;

    private static readonly string RO_HASH = "Hash";

    private string _hash;

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOGDADOSPESSOAS", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Data_registro
    {
        get
        {
            PropriedadeAcessada(RO_DATA_REGISTRO);
            return _data_registro;
        }
        set
        {
            PropriedadeModificada(RO_DATA_REGISTRO, value);
            _data_registro = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOGDADOSPESSOAS", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Data_requisicao
    {
        get
        {
            PropriedadeAcessada(RO_DATA_REQUISICAO);
            return _data_requisicao;
        }
        set
        {
            PropriedadeModificada(RO_DATA_REQUISICAO, value);
            _data_requisicao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOGDADOSPESSOAS", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1500, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOGDADOSPESSOAS", Tipo = TipoDoCampoNoBancoDeDados.Binario, Tamanho = 8000, Precisao = 0)]
    public string Dados_Anterior
    {
        get
        {
            PropriedadeAcessada(RO_DADOS_ANTERIOR);
            return _dados_anterior;
        }
        set
        {
            PropriedadeModificada(RO_DADOS_ANTERIOR, value);
            _dados_anterior = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOGDADOSPESSOAS", Tipo = TipoDoCampoNoBancoDeDados.Binario, Tamanho = 8000, Precisao = 0)]
    public string Dados_atual
    {
        get
        {
            PropriedadeAcessada(RO_DADOS_ATUAL);
            return _dados_atual;
        }
        set
        {
            PropriedadeModificada(RO_DADOS_ATUAL, value);
            _dados_atual = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOGDADOSPESSOAS", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 50, Precisao = 0)]
    public string Codigo_cadastro
    {
        get
        {
            PropriedadeAcessada(RO_CODIGO_CADASTRO);
            return _codigo_cadastro;
        }
        set
        {
            PropriedadeModificada(RO_CODIGO_CADASTRO, value);
            _codigo_cadastro = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOGDADOSPESSOAS", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 60, Precisao = 0)]
    public string Tabela
    {
        get
        {
            PropriedadeAcessada(RO_TABELA);
            return _tabela;
        }
        set
        {
            PropriedadeModificada(RO_TABELA, value);
            _tabela = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOGDADOSPESSOAS", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Matricula
    {
        get
        {
            PropriedadeAcessada(RO_MATRICULA);
            return _matricula;
        }
        set
        {
            PropriedadeModificada(RO_MATRICULA, value);
            _matricula = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOGDADOSPESSOAS", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 10, Precisao = 0)]
    public string Rotina
    {
        get
        {
            PropriedadeAcessada(RO_ROTINA);
            return _rotina;
        }
        set
        {
            PropriedadeModificada(RO_ROTINA, value);
            _rotina = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOGDADOSPESSOAS", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 64, Precisao = 0)]
    public string Hash
    {
        get
        {
            PropriedadeAcessada(RO_HASH);
            return _hash;
        }
        set
        {
            PropriedadeModificada(RO_HASH, value);
            _hash = value;
        }
    }

    public void InicializarAtributos()
    {
    }

    public string ObterNomeTabela()
    {
        return "PCLOGDADOSPESSOAS";
    }

    public IEntidade NovaInstancia()
    {
        return (IEntidade)GetType().GetConstructors()[0].Invoke(null);
    }

    public void CarregarPorDataReader(IDataReader leitor)
    {
        _data_registro = AlterarTipo<DateTime?>(leitor["Data_registro"]);
        _data_requisicao = AlterarTipo<DateTime?>(leitor["Data_requisicao"]);
        _descricao = AlterarTipo<string>(leitor["Descricao"]);
        _dados_anterior = AlterarTipo<string>(leitor["Dados_anterior"]);
        _dados_atual = AlterarTipo<string>(leitor["Dados_atual"]);
        _codigo_cadastro = AlterarTipo<string>(leitor["Codigo_cadastro"]);
        _tabela = AlterarTipo<string>(leitor["Tabela"]);
        _matricula = AlterarTipo<decimal?>(leitor["Matricula"]);
        _rotina = AlterarTipo<string>(leitor["Rotina"]);
        _hash = AlterarTipo<string>(leitor["Hash"]);
    }

}