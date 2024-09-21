

////// // namespace nwErp.Entidades.Winthor;

// // namespace nwErp.Api.Modelos;

[Serializable]
public class PCCADGIFTCARD : GerenteDePropriedades, IEntidade
{
    private static readonly string RO_CODCLI = "Codcli";

    private decimal? _codcli;

    private static readonly string RO_CODFUNCATIVO = "Codfuncativo";

    private decimal? _codfuncativo;

    private static readonly string RO_CONSUMIDORFINAL = "Consumidorfinal";

    private string _consumidorfinal;

    private static readonly string RO_DTCADASTRO = "Dtcadastro";

    private DateTime? _dtcadastro;

    private static readonly string RO_DTINATIVO = "Dtinativo";

    private DateTime? _dtinativo;

    private static readonly string RO_DTVALIDADE = "Dtvalidade";

    private DateTime? _dtvalidade;

    private static readonly string RO_FIXO = "Fixo";

    private string _fixo;

    private static readonly string RO_MOTIVOINATIVO = "Motivoinativo";

    private string _motivoinativo;

    private static readonly string RO_NUMGIFTCARD = "Numgiftcard";

    private string _numgiftcard;

    private static readonly string RO_STATUS = "Status";

    private string _status;

    private static readonly string RO_VALOR = "Valor";

    private decimal? _valor;

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCADGIFTCARD", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codcli
    {
        get
        {
            PropriedadeAcessada(RO_CODCLI);
            return _codcli;
        }
        set
        {
            PropriedadeModificada(RO_CODCLI, value);
            _codcli = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCADGIFTCARD", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfuncativo
    {
        get
        {
            PropriedadeAcessada(RO_CODFUNCATIVO);
            return _codfuncativo;
        }
        set
        {
            PropriedadeModificada(RO_CODFUNCATIVO, value);
            _codfuncativo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCADGIFTCARD", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Consumidorfinal
    {
        get
        {
            PropriedadeAcessada(RO_CONSUMIDORFINAL);
            return _consumidorfinal;
        }
        set
        {
            PropriedadeModificada(RO_CONSUMIDORFINAL, value);
            _consumidorfinal = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCADGIFTCARD", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCADGIFTCARD", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtinativo
    {
        get
        {
            PropriedadeAcessada(RO_DTINATIVO);
            return _dtinativo;
        }
        set
        {
            PropriedadeModificada(RO_DTINATIVO, value);
            _dtinativo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCADGIFTCARD", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtvalidade
    {
        get
        {
            PropriedadeAcessada(RO_DTVALIDADE);
            return _dtvalidade;
        }
        set
        {
            PropriedadeModificada(RO_DTVALIDADE, value);
            _dtvalidade = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCADGIFTCARD", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Fixo
    {
        get
        {
            PropriedadeAcessada(RO_FIXO);
            return _fixo;
        }
        set
        {
            PropriedadeModificada(RO_FIXO, value);
            _fixo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCADGIFTCARD", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 100, Precisao = 0)]
    public string Motivoinativo
    {
        get
        {
            PropriedadeAcessada(RO_MOTIVOINATIVO);
            return _motivoinativo;
        }
        set
        {
            PropriedadeModificada(RO_MOTIVOINATIVO, value);
            _motivoinativo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCCADGIFTCARD", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 25, Precisao = 0)]
    public string Numgiftcard
    {
        get
        {
            PropriedadeAcessada(RO_NUMGIFTCARD);
            return _numgiftcard;
        }
        set
        {
            PropriedadeModificada(RO_NUMGIFTCARD, value);
            _numgiftcard = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCADGIFTCARD", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Status
    {
        get
        {
            PropriedadeAcessada(RO_STATUS);
            return _status;
        }
        set
        {
            PropriedadeModificada(RO_STATUS, value);
            _status = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCADGIFTCARD", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 2)]
    public decimal? Valor
    {
        get
        {
            PropriedadeAcessada(RO_VALOR);
            return _valor;
        }
        set
        {
            PropriedadeModificada(RO_VALOR, value);
            _valor = value;
        }
    }

    public void InicializarAtributos()
    {
    }

    public string ObterNomeTabela()
    {
        return "PCCADGIFTCARD";
    }

    public IEntidade NovaInstancia()
    {
        return (IEntidade)GetType().GetConstructors()[0].Invoke(null);
    }

    public void CarregarPorDataReader(IDataReader leitor)
    {
        _codcli = AlterarTipo<decimal?>(leitor["Codcli"]);
        _codfuncativo = AlterarTipo<decimal?>(leitor["Codfuncativo"]);
        _consumidorfinal = AlterarTipo<string>(leitor["Consumidorfinal"]);
        _dtcadastro = AlterarTipo<DateTime?>(leitor["Dtcadastro"]);
        _dtinativo = AlterarTipo<DateTime?>(leitor["Dtinativo"]);
        _dtvalidade = AlterarTipo<DateTime?>(leitor["Dtvalidade"]);
        _fixo = AlterarTipo<string>(leitor["Fixo"]);
        _motivoinativo = AlterarTipo<string>(leitor["Motivoinativo"]);
        _numgiftcard = AlterarTipo<string>(leitor["Numgiftcard"]);
        _status = AlterarTipo<string>(leitor["Status"]);
        _valor = AlterarTipo<decimal?>(leitor["Valor"]);
    }

}