

////// namespace nwErp.Entidades.Winthor;

// namespace nwErp.Api.Modelos;

[Serializable]
public class PCTELAECF : GerenteDePropriedades, IEntidade
{
    private static readonly string RO_CODIGOTELA = "Codigotela";

    private decimal _codigotela;

    private static readonly string RO_DESCRICAO = "Descricao";

    private string _descricao;

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCTELAECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 2, Precisao = 0)]
    public decimal Codigotela
    {
        get
        {
            PropriedadeAcessada(RO_CODIGOTELA);
            return _codigotela;
        }
        set
        {
            PropriedadeModificada(RO_CODIGOTELA, value);
            _codigotela = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTELAECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
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

    public void InicializarAtributos()
    {
    }

    public string ObterNomeTabela()
    {
        return "PCTELAECF";
    }

    public IEntidade NovaInstancia()
    {
        return (IEntidade)GetType().GetConstructors()[0].Invoke(null);
    }

    public void CarregarPorDataReader(IDataReader leitor)
    {
        _codigotela = AlterarTipo<decimal>(leitor["Codigotela"]);
        _descricao = AlterarTipo<string>(leitor["Descricao"]);
    }

}