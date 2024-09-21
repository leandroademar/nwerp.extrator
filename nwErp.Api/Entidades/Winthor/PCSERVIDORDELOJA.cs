

////// namespace nwErp.Entidades.Winthor;

// namespace nwErp.Api.Modelos;

[Serializable]
public class PCSERVIDORDELOJA : GerenteDePropriedades, IEntidade
{
    private static readonly string RO_CODFILIAL = "Codfilial";

    private string _codfilial;

    private static readonly string RO_ENDERECO = "Endereco";

    private string _endereco;

    private static readonly string RO_EXIBIRCAIXASBLOQUEADOS = "Exibircaixasbloqueados";

    private string _exibircaixasbloqueados;

    private static readonly string RO_EXIBIRCAIXASMONITORAMENTO = "Exibircaixasmonitoramento";

    private string _exibircaixasmonitoramento;

    private static readonly string RO_NOMEDOSERVICO = "Nomedoservico";

    private string _nomedoservico;

    private static readonly string RO_PERCENTUALCRITICO = "Percentualcritico";

    private decimal? _percentualcritico;

    private static readonly string RO_SENHABANCO = "Senhabanco";

    private string _senhabanco;

    private static readonly string RO_TIPODESERVIDOR = "Tipodeservidor";

    private string _tipodeservidor;

    private static readonly string RO_USUARIOBANCO = "Usuariobanco";

    private string _usuariobanco;

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCSERVIDORDELOJA", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCSERVIDORDELOJA", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 100, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCSERVIDORDELOJA", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Exibircaixasbloqueados
    {
        get
        {
            PropriedadeAcessada(RO_EXIBIRCAIXASBLOQUEADOS);
            return _exibircaixasbloqueados;
        }
        set
        {
            PropriedadeModificada(RO_EXIBIRCAIXASBLOQUEADOS, value);
            _exibircaixasbloqueados = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCSERVIDORDELOJA", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Exibircaixasmonitoramento
    {
        get
        {
            PropriedadeAcessada(RO_EXIBIRCAIXASMONITORAMENTO);
            return _exibircaixasmonitoramento;
        }
        set
        {
            PropriedadeModificada(RO_EXIBIRCAIXASMONITORAMENTO, value);
            _exibircaixasmonitoramento = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCSERVIDORDELOJA", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
    public string Nomedoservico
    {
        get
        {
            PropriedadeAcessada(RO_NOMEDOSERVICO);
            return _nomedoservico;
        }
        set
        {
            PropriedadeModificada(RO_NOMEDOSERVICO, value);
            _nomedoservico = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCSERVIDORDELOJA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 3, Precisao = 0)]
    public decimal? Percentualcritico
    {
        get
        {
            PropriedadeAcessada(RO_PERCENTUALCRITICO);
            return _percentualcritico;
        }
        set
        {
            PropriedadeModificada(RO_PERCENTUALCRITICO, value);
            _percentualcritico = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCSERVIDORDELOJA", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCSERVIDORDELOJA", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Tipodeservidor
    {
        get
        {
            PropriedadeAcessada(RO_TIPODESERVIDOR);
            return _tipodeservidor;
        }
        set
        {
            PropriedadeModificada(RO_TIPODESERVIDOR, value);
            _tipodeservidor = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCSERVIDORDELOJA", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
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
        return "PCSERVIDORDELOJA";
    }

    public IEntidade NovaInstancia()
    {
        return (IEntidade)GetType().GetConstructors()[0].Invoke(null);
    }

    public void CarregarPorDataReader(IDataReader leitor)
    {
        _codfilial = AlterarTipo<string>(leitor["Codfilial"]);
        _endereco = AlterarTipo<string>(leitor["Endereco"]);
        _exibircaixasbloqueados = AlterarTipo<string>(leitor["Exibircaixasbloqueados"]);
        _exibircaixasmonitoramento = AlterarTipo<string>(leitor["Exibircaixasmonitoramento"]);
        _nomedoservico = AlterarTipo<string>(leitor["Nomedoservico"]);
        _percentualcritico = AlterarTipo<decimal?>(leitor["Percentualcritico"]);
        _senhabanco = AlterarTipo<string>(leitor["Senhabanco"]);
        _tipodeservidor = AlterarTipo<string>(leitor["Tipodeservidor"]);
        _usuariobanco = AlterarTipo<string>(leitor["Usuariobanco"]);
    }

}