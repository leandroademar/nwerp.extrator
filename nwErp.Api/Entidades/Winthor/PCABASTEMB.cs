

////// namespace nwErp.Entidades.Winthor;

// namespace nwErp.Api.Modelos;

[Serializable]
public class PCABASTEMB : GerenteDePropriedades, IEntidade
{
    private static readonly string RO_CODAUXILIAR = "Codauxiliar";

    private decimal _codauxiliar;

    private static readonly string RO_CODFILIAL = "Codfilial";

    private string _codfilial;

    private static readonly string RO_QTVENDA = "Qtvenda";

    private decimal? _qtvenda;

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCABASTEMB", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 20, Precisao = 0)]
    public decimal Codauxiliar
    {
        get
        {
            PropriedadeAcessada(RO_CODAUXILIAR);
            return _codauxiliar;
        }
        set
        {
            PropriedadeModificada(RO_CODAUXILIAR, value);
            _codauxiliar = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCABASTEMB", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCABASTEMB", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 20, Precisao = 6)]
    public decimal? Qtvenda
    {
        get
        {
            PropriedadeAcessada(RO_QTVENDA);
            return _qtvenda;
        }
        set
        {
            PropriedadeModificada(RO_QTVENDA, value);
            _qtvenda = value;
        }
    }

    public void InicializarAtributos()
    {
    }

    public string ObterNomeTabela()
    {
        return "PCABASTEMB";
    }

    public IEntidade NovaInstancia()
    {
        return (IEntidade)GetType().GetConstructors()[0].Invoke(null);
    }

    public void CarregarPorDataReader(IDataReader leitor)
    {
        _codauxiliar = AlterarTipo<decimal>(leitor["Codauxiliar"]);
        _codfilial = AlterarTipo<string>(leitor["Codfilial"]);
        _qtvenda = AlterarTipo<decimal?>(leitor["Qtvenda"]);
    }


}