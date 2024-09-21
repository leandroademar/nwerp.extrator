

////// namespace nwErp.Entidades.Winthor;

// namespace nwErp.Api.Modelos;

[Serializable]
public class PCLAYOUTATALHOSECF : GerenteDePropriedades, IEntidade
{
    private static readonly string RO_CODFILIAL = "Codfilial";

    private string _codfilial;

    private static readonly string RO_CODIGOLAYOUT = "Codigolayout";

    private decimal _codigolayout;

    private static readonly string RO_NUMCAIXA = "Numcaixa";

    private decimal? _numcaixa;

    private static readonly string RO_TIPO = "Tipo";

    private string _tipo;

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLAYOUTATALHOSECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 3, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCLAYOUTATALHOSECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 0)]
    public decimal Codigolayout
    {
        get
        {
            PropriedadeAcessada(RO_CODIGOLAYOUT);
            return _codigolayout;
        }
        set
        {
            PropriedadeModificada(RO_CODIGOLAYOUT, value);
            _codigolayout = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLAYOUTATALHOSECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Numcaixa
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLAYOUTATALHOSECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Tipo
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

    public void InicializarAtributos()
    {
    }

    public string ObterNomeTabela()
    {
        return "PCLAYOUTATALHOSECF";
    }

    public IEntidade NovaInstancia()
    {
        return (IEntidade)GetType().GetConstructors()[0].Invoke(null);
    }

    public void CarregarPorDataReader(IDataReader leitor)
    {
        _codfilial = AlterarTipo<string>(leitor["Codfilial"]);
        _codigolayout = AlterarTipo<decimal>(leitor["Codigolayout"]);
        _numcaixa = AlterarTipo<decimal?>(leitor["Numcaixa"]);
        _tipo = AlterarTipo<string>(leitor["Tipo"]);
    }

}