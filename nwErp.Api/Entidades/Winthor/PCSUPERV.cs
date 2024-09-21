

////// namespace nwErp.Entidades.Winthor;

// namespace nwErp.Api.Modelos;

[Serializable]
public class PCSUPERV : GerenteDePropriedades, IEntidade
{
    private static readonly string RO_COD_CADRCA = "Cod_Cadrca";

    private decimal _cod_cadrca;

    private static readonly string RO_CODCOORDENADOR = "Codcoordenador";

    private decimal? _codcoordenador;

    private static readonly string RO_CODGERENTE = "Codgerente";

    private decimal? _codgerente;

    private static readonly string RO_CODSUPERVISOR = "Codsupervisor";

    private decimal _codsupervisor;

    private static readonly string RO_CPF = "Cpf";

    private string _cpf;

    private static readonly string RO_DTADMISSAO = "Dtadmissao";

    private DateTime? _dtadmissao;

    private static readonly string RO_DTDEMISSAO = "Dtdemissao";

    private DateTime? _dtdemissao;

    private static readonly string RO_NOME = "Nome";

    private string _nome;

    private static readonly string RO_PERCMARGEMPREV = "Percmargemprev";

    private decimal? _percmargemprev;

    private static readonly string RO_PERCOMISSAO = "Percomissao";

    private decimal? _percomissao;

    private static readonly string RO_PERCPARTVENDAPREV = "Percpartvendaprev";

    private decimal? _percpartvendaprev;

    private static readonly string RO_POSICAO = "Posicao";

    private string _posicao;

    private static readonly string RO_REGIONAL = "Regional";

    private decimal _regional;

    private static readonly string RO_TIPOSUPERVISOR = "Tiposupervisor";

    private string _tiposupervisor;

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCSUPERV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal Cod_Cadrca
    {
        get
        {
            PropriedadeAcessada(RO_COD_CADRCA);
            return _cod_cadrca;
        }
        set
        {
            PropriedadeModificada(RO_COD_CADRCA, value);
            _cod_cadrca = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCSUPERV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Codcoordenador
    {
        get
        {
            PropriedadeAcessada(RO_CODCOORDENADOR);
            return _codcoordenador;
        }
        set
        {
            PropriedadeModificada(RO_CODCOORDENADOR, value);
            _codcoordenador = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCSUPERV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Codgerente
    {
        get
        {
            PropriedadeAcessada(RO_CODGERENTE);
            return _codgerente;
        }
        set
        {
            PropriedadeModificada(RO_CODGERENTE, value);
            _codgerente = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCSUPERV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal Codsupervisor
    {
        get
        {
            PropriedadeAcessada(RO_CODSUPERVISOR);
            return _codsupervisor;
        }
        set
        {
            PropriedadeModificada(RO_CODSUPERVISOR, value);
            _codsupervisor = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCSUPERV", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
    public string Cpf
    {
        get
        {
            PropriedadeAcessada(RO_CPF);
            return _cpf;
        }
        set
        {
            PropriedadeModificada(RO_CPF, value);
            _cpf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCSUPERV", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtadmissao
    {
        get
        {
            PropriedadeAcessada(RO_DTADMISSAO);
            return _dtadmissao;
        }
        set
        {
            PropriedadeModificada(RO_DTADMISSAO, value);
            _dtadmissao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCSUPERV", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtdemissao
    {
        get
        {
            PropriedadeAcessada(RO_DTDEMISSAO);
            return _dtdemissao;
        }
        set
        {
            PropriedadeModificada(RO_DTDEMISSAO, value);
            _dtdemissao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCSUPERV", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
    public string Nome
    {
        get
        {
            PropriedadeAcessada(RO_NOME);
            return _nome;
        }
        set
        {
            PropriedadeModificada(RO_NOME, value);
            _nome = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCSUPERV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Percmargemprev
    {
        get
        {
            PropriedadeAcessada(RO_PERCMARGEMPREV);
            return _percmargemprev;
        }
        set
        {
            PropriedadeModificada(RO_PERCMARGEMPREV, value);
            _percmargemprev = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCSUPERV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 2)]
    public decimal? Percomissao
    {
        get
        {
            PropriedadeAcessada(RO_PERCOMISSAO);
            return _percomissao;
        }
        set
        {
            PropriedadeModificada(RO_PERCOMISSAO, value);
            _percomissao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCSUPERV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Percpartvendaprev
    {
        get
        {
            PropriedadeAcessada(RO_PERCPARTVENDAPREV);
            return _percpartvendaprev;
        }
        set
        {
            PropriedadeModificada(RO_PERCPARTVENDAPREV, value);
            _percpartvendaprev = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCSUPERV", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Posicao
    {
        get
        {
            PropriedadeAcessada(RO_POSICAO);
            return _posicao;
        }
        set
        {
            PropriedadeModificada(RO_POSICAO, value);
            _posicao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCSUPERV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 2, Precisao = 0)]
    public decimal Regional
    {
        get
        {
            PropriedadeAcessada(RO_REGIONAL);
            return _regional;
        }
        set
        {
            PropriedadeModificada(RO_REGIONAL, value);
            _regional = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCSUPERV", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Tiposupervisor
    {
        get
        {
            PropriedadeAcessada(RO_TIPOSUPERVISOR);
            return _tiposupervisor;
        }
        set
        {
            PropriedadeModificada(RO_TIPOSUPERVISOR, value);
            _tiposupervisor = value;
        }
    }

    public void InicializarAtributos()
    {
    }

    public string ObterNomeTabela()
    {
        return "PCSUPERV";
    }

    public IEntidade NovaInstancia()
    {
        return (IEntidade)GetType().GetConstructors()[0].Invoke(null);
    }

    public void CarregarPorDataReader(IDataReader leitor)
    {
        _cod_cadrca = AlterarTipo<decimal>(leitor["Cod_Cadrca"]);
        _codcoordenador = AlterarTipo<decimal?>(leitor["Codcoordenador"]);
        _codgerente = AlterarTipo<decimal?>(leitor["Codgerente"]);
        _codsupervisor = AlterarTipo<decimal>(leitor["Codsupervisor"]);
        _cpf = AlterarTipo<string>(leitor["Cpf"]);
        _dtadmissao = AlterarTipo<DateTime?>(leitor["Dtadmissao"]);
        _dtdemissao = AlterarTipo<DateTime?>(leitor["Dtdemissao"]);
        _nome = AlterarTipo<string>(leitor["Nome"]);
        _percmargemprev = AlterarTipo<decimal?>(leitor["Percmargemprev"]);
        _percomissao = AlterarTipo<decimal?>(leitor["Percomissao"]);
        _percpartvendaprev = AlterarTipo<decimal?>(leitor["Percpartvendaprev"]);
        _posicao = AlterarTipo<string>(leitor["Posicao"]);
        _regional = AlterarTipo<decimal>(leitor["Regional"]);
        _tiposupervisor = AlterarTipo<string>(leitor["Tiposupervisor"]);
    }

}