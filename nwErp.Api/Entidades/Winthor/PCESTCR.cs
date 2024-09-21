

////// namespace nwErp.Entidades.Winthor;

// namespace nwErp.Api.Modelos;

[Serializable]
public class PCESTCR : GerenteDePropriedades, IEntidade
{
    private static readonly string RO_CODBANCO = "Codbanco";

    private decimal _codbanco;

    private static readonly string RO_CODCOB = "Codcob";

    private string _codcob;

    private static readonly string RO_DTULTCONCILIA = "Dtultconcilia";

    private DateTime? _dtultconcilia;

    private static readonly string RO_VALOR = "Valor";

    private decimal? _valor;

    private static readonly string RO_VALORCONCILIADO = "Valorconciliado";

    private decimal? _valorconciliado;

    private static readonly string RO_VALORSALDOTOTALCONCIL = "Valorsaldototalconcil";

    private decimal? _valorsaldototalconcil;

    private static readonly string RO_VALORSALDOTOTALCOMP = "Valorsaldototalcomp";

    private decimal? _valorsaldototalcomp;

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCESTCR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal Codbanco
    {
        get
        {
            PropriedadeAcessada(RO_CODBANCO);
            return _codbanco;
        }
        set
        {
            PropriedadeModificada(RO_CODBANCO, value);
            _codbanco = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCESTCR", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 4, Precisao = 0)]
    public string Codcob
    {
        get
        {
            PropriedadeAcessada(RO_CODCOB);
            return _codcob;
        }
        set
        {
            PropriedadeModificada(RO_CODCOB, value);
            _codcob = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCESTCR", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtultconcilia
    {
        get
        {
            PropriedadeAcessada(RO_DTULTCONCILIA);
            return _dtultconcilia;
        }
        set
        {
            PropriedadeModificada(RO_DTULTCONCILIA, value);
            _dtultconcilia = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCESTCR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 16, Precisao = 2)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCESTCR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 16, Precisao = 2)]
    public decimal? Valorconciliado
    {
        get
        {
            PropriedadeAcessada(RO_VALORCONCILIADO);
            return _valorconciliado;
        }
        set
        {
            PropriedadeModificada(RO_VALORCONCILIADO, value);
            _valorconciliado = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCESTCR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 16, Precisao = 2)]
    public decimal? Valorsaldototalconcil
    {
        get
        {
            PropriedadeAcessada(RO_VALORSALDOTOTALCONCIL);
            return _valorsaldototalconcil;
        }
        set
        {
            PropriedadeModificada(RO_VALORSALDOTOTALCONCIL, value);
            _valorsaldototalconcil = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCESTCR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 16, Precisao = 2)]
    public decimal? Valorsaldototalcomp
    {
        get
        {
            PropriedadeAcessada(RO_VALORSALDOTOTALCOMP);
            return _valorsaldototalcomp;
        }
        set
        {
            PropriedadeModificada(RO_VALORSALDOTOTALCOMP, value);
            _valorsaldototalcomp = value;
        }
    }

    public void InicializarAtributos()
    {
    }

    public string ObterNomeTabela()
    {
        return "PCESTCR";
    }

    public IEntidade NovaInstancia()
    {
        return (IEntidade)GetType().GetConstructors()[0].Invoke(null);
    }

    public void CarregarPorDataReader(IDataReader leitor)
    {
        _codbanco = AlterarTipo<decimal>(leitor["Codbanco"]);
        _codcob = AlterarTipo<string>(leitor["Codcob"]);
        _dtultconcilia = AlterarTipo<DateTime?>(leitor["Dtultconcilia"]);
        _valor = AlterarTipo<decimal?>(leitor["Valor"]);
        _valorconciliado = AlterarTipo<decimal?>(leitor["Valorconciliado"]);
        _valorsaldototalconcil = AlterarTipo<decimal?>(leitor["Valorsaldototalconcil"]);
        _valorsaldototalcomp = AlterarTipo<decimal?>(leitor["Valorsaldototalcomp"]);
    }

}