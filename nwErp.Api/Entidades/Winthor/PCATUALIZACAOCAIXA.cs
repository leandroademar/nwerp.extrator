

////// namespace nwErp.Entidades.Caixa;

// namespace nwErp.Api.Modelos;

[Serializable]
public class PCATUALIZACAOCAIXA : GerenteDePropriedades, IEntidade
{
    private decimal? _numcaixa;

    private string _atualizacaoespecifica;

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCATUALIZACAOCAIXA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Numcaixa
    {
        get
        {
            PropriedadeAcessada("Numcaixa");
            return _numcaixa;
        }
        set
        {
            PropriedadeModificada("Numcaixa", value);
            _numcaixa = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCATUALIZACAOCAIXA", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Atualizacaoespecifica
    {
        get
        {
            PropriedadeAcessada("Atualizacaoespecifica");
            return _atualizacaoespecifica;
        }
        set
        {
            PropriedadeModificada("Atualizacaoespecifica", value);
            _atualizacaoespecifica = value;
        }
    }

    public void InicializarAtributos()
    {
    }

    public string ObterNomeTabela()
    {
        return "PCATUALIZACAOCAIXA";
    }

    public IEntidade NovaInstancia()
    {
        return (IEntidade)GetType().GetConstructors()[0].Invoke(null);
    }

    public void CarregarPorDataReader(IDataReader leitor)
    {
        _numcaixa = AlterarTipo<decimal?>(leitor["Numcaixa"]);
        _atualizacaoespecifica = AlterarTipo<string>(leitor["Atualizacaoespecifica"]);
    }

}