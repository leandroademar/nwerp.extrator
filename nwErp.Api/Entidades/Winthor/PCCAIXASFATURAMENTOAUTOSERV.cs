

////// namespace nwErp.Entidades.Winthor;

// namespace nwErp.Api.Modelos;

[Serializable]
public class PCCAIXASFATURAMENTOAUTOSERV : GerenteDePropriedades, IEntidade
{
    private static readonly string RO_ATIVO = "Ativo";

    private string _ativo;

    private static readonly string RO_DESCRICAO = "Descricao";

    private string _descricao;

    private static readonly string RO_ENDERECO = "Endereco";

    private string _endereco;

    private static readonly string RO_NOMESERVICOBANCO = "Nomeservicobanco";

    private string _nomeservicobanco;

    private static readonly string RO_NUMCAIXA = "Numcaixa";

    private decimal _numcaixa;

    private static readonly string RO_SENHA = "Senha";

    private string _senha;

    private static readonly string RO_SENHABANCO = "Senhabanco";

    private string _senhabanco;

    private static readonly string RO_SENHAVNC = "Senhavnc";

    private string _senhavnc;

    private static readonly string RO_USUARIO = "Usuario";

    private string _usuario;

    private static readonly string RO_USUARIOBANCO = "Usuariobanco";

    private string _usuariobanco;

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCAIXASFATURAMENTOAUTOSERV", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Ativo
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCAIXASFATURAMENTOAUTOSERV", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCAIXASFATURAMENTOAUTOSERV", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 15, Precisao = 0)]
    public string Endereco
    {
        get
        {
            PropriedadeAcessada(RO_ENDERECO);
            return _endereco;
        }
        set
        {
            PropriedadeModificada(RO_ENDERECO, value);
            _endereco = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCAIXASFATURAMENTOAUTOSERV", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
    public string Nomeservicobanco
    {
        get
        {
            PropriedadeAcessada(RO_NOMESERVICOBANCO);
            return _nomeservicobanco;
        }
        set
        {
            PropriedadeModificada(RO_NOMESERVICOBANCO, value);
            _nomeservicobanco = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCCAIXASFATURAMENTOAUTOSERV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal Numcaixa
    {
        get
        {
            PropriedadeAcessada(RO_NUMCAIXA);
            return _numcaixa;
        }
        set
        {
            PropriedadeModificada(RO_NUMCAIXA, value);
            _numcaixa = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCAIXASFATURAMENTOAUTOSERV", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 8, Precisao = 0)]
    public string Senha
    {
        get
        {
            PropriedadeAcessada(RO_SENHA);
            return _senha;
        }
        set
        {
            PropriedadeModificada(RO_SENHA, value);
            _senha = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCAIXASFATURAMENTOAUTOSERV", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 30, Precisao = 0)]
    public string Senhabanco
    {
        get
        {
            PropriedadeAcessada(RO_SENHABANCO);
            return _senhabanco;
        }
        set
        {
            PropriedadeModificada(RO_SENHABANCO, value);
            _senhabanco = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCAIXASFATURAMENTOAUTOSERV", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
    public string Senhavnc
    {
        get
        {
            PropriedadeAcessada(RO_SENHAVNC);
            return _senhavnc;
        }
        set
        {
            PropriedadeModificada(RO_SENHAVNC, value);
            _senhavnc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCAIXASFATURAMENTOAUTOSERV", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 10, Precisao = 0)]
    public string Usuario
    {
        get
        {
            PropriedadeAcessada(RO_USUARIO);
            return _usuario;
        }
        set
        {
            PropriedadeModificada(RO_USUARIO, value);
            _usuario = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCAIXASFATURAMENTOAUTOSERV", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 30, Precisao = 0)]
    public string Usuariobanco
    {
        get
        {
            PropriedadeAcessada(RO_USUARIOBANCO);
            return _usuariobanco;
        }
        set
        {
            PropriedadeModificada(RO_USUARIOBANCO, value);
            _usuariobanco = value;
        }
    }

    public void InicializarAtributos()
    {
    }

    public string ObterNomeTabela()
    {
        return "PCCAIXASFATURAMENTOAUTOSERV";
    }

    public IEntidade NovaInstancia()
    {
        return (IEntidade)GetType().GetConstructors()[0].Invoke(null);
    }

    public void CarregarPorDataReader(IDataReader leitor)
    {
        _ativo = AlterarTipo<string>(leitor["Ativo"]);
        _descricao = AlterarTipo<string>(leitor["Descricao"]);
        _endereco = AlterarTipo<string>(leitor["Endereco"]);
        _nomeservicobanco = AlterarTipo<string>(leitor["Nomeservicobanco"]);
        _numcaixa = AlterarTipo<decimal>(leitor["Numcaixa"]);
        _senha = AlterarTipo<string>(leitor["Senha"]);
        _senhabanco = AlterarTipo<string>(leitor["Senhabanco"]);
        _senhavnc = AlterarTipo<string>(leitor["Senhavnc"]);
        _usuario = AlterarTipo<string>(leitor["Usuario"]);
        _usuariobanco = AlterarTipo<string>(leitor["Usuariobanco"]);
    }

}