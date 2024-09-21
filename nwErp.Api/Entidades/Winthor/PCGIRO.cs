

////// namespace nwErp.Entidades.Winthor;

// namespace nwErp.Api.Modelos;

[Serializable]
public class PCGIRO : GerenteDePropriedades, IEntidade
{
    private static readonly string RO_CODFILIAL = "Codfilial";

    private string _codfilial;

    private static readonly string RO_CODPROD = "Codprod";

    private decimal _codprod;

    private static readonly string RO_GIRO = "Giro";

    private decimal? _giro;

    private static readonly string RO_GIROMESANT = "Giromesant";

    private decimal? _giromesant;

    private static readonly string RO_NUMREGIAO = "Numregiao";

    private decimal _numregiao;

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCGIRO", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCGIRO", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal Codprod
    {
        get
        {
            PropriedadeAcessada(RO_CODPROD);
            return _codprod;
        }
        set
        {
            PropriedadeModificada(RO_CODPROD, value);
            _codprod = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCGIRO", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 2)]
    public decimal? Giro
    {
        get
        {
            PropriedadeAcessada(RO_GIRO);
            return _giro;
        }
        set
        {
            PropriedadeModificada(RO_GIRO, value);
            _giro = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCGIRO", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 2)]
    public decimal? Giromesant
    {
        get
        {
            PropriedadeAcessada(RO_GIROMESANT);
            return _giromesant;
        }
        set
        {
            PropriedadeModificada(RO_GIROMESANT, value);
            _giromesant = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCGIRO", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal Numregiao
    {
        get
        {
            PropriedadeAcessada(RO_NUMREGIAO);
            return _numregiao;
        }
        set
        {
            PropriedadeModificada(RO_NUMREGIAO, value);
            _numregiao = value;
        }
    }

    public void InicializarAtributos()
    {
    }

    public string ObterNomeTabela()
    {
        return "PCGIRO";
    }

    public IEntidade NovaInstancia()
    {
        return (IEntidade)GetType().GetConstructors()[0].Invoke(null);
    }

    public void CarregarPorDataReader(IDataReader leitor)
    {
        _codfilial = AlterarTipo<string>(leitor["Codfilial"]);
        _codprod = AlterarTipo<decimal>(leitor["Codprod"]);
        _giro = AlterarTipo<decimal?>(leitor["Giro"]);
        _giromesant = AlterarTipo<decimal?>(leitor["Giromesant"]);
        _numregiao = AlterarTipo<decimal>(leitor["Numregiao"]);
    }

}