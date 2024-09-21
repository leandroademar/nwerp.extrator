

////// namespace nwErp.Entidades.Winthor;

// namespace nwErp.Api.Modelos;

[Serializable]
public class PCGERAICMSLIVROFISCALSAIDA : GerenteDePropriedades, IEntidade
{
    private static readonly string RO_CODPROD = "Codprod";

    private decimal _codprod;

    private static readonly string RO_CODFILIAL = "Codfilial";

    private string _codfilial;

    private static readonly string RO_CONDVENDA = "Condvenda";

    private decimal? _condvenda;

    private static readonly string RO_GERAICMSLIVROFISCAL = "Geraicmslivrofiscal";

    private string _geraicmslivrofiscal;

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCGERAICMSLIVROFISCALSAIDA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCGERAICMSLIVROFISCALSAIDA", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCGERAICMSLIVROFISCALSAIDA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 0)]
    public decimal? Condvenda
    {
        get
        {
            PropriedadeAcessada(RO_CONDVENDA);
            return _condvenda;
        }
        set
        {
            PropriedadeModificada(RO_CONDVENDA, value);
            _condvenda = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCGERAICMSLIVROFISCALSAIDA", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Geraicmslivrofiscal
    {
        get
        {
            PropriedadeAcessada(RO_GERAICMSLIVROFISCAL);
            return _geraicmslivrofiscal;
        }
        set
        {
            PropriedadeModificada(RO_GERAICMSLIVROFISCAL, value);
            _geraicmslivrofiscal = value;
        }
    }

    public void InicializarAtributos()
    {
    }

    public string ObterNomeTabela()
    {
        return "PCGERAICMSLIVROFISCALSAIDA";
    }

    public IEntidade NovaInstancia()
    {
        return (IEntidade)GetType().GetConstructors()[0].Invoke(null);
    }

    public void CarregarPorDataReader(IDataReader leitor)
    {
        _codprod = AlterarTipo<decimal>(leitor["Codprod"]);
        _codfilial = AlterarTipo<string>(leitor["Codfilial"]);
        _condvenda = AlterarTipo<decimal>(leitor["Condvenda"]);
        _geraicmslivrofiscal = AlterarTipo<string>(leitor["Geraicmslivrofiscal"]);
    }

}