

////// // namespace nwErp.Entidades.Caixa;

// // namespace nwErp.Api.Modelos;

[Serializable]
public class PCINDICEECF : GerenteDePropriedades, IEntidade
{
    private static readonly string RO_CODECF = "Codecf";

    private string _codecf;

    private static readonly string RO_INDICE = "Indice";

    private string _indice;

    private static readonly string RO_NUMCAIXA = "Numcaixa";

    private decimal _numcaixa;

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCINDICEECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 4, Precisao = 0)]
    public string Codecf
    {
        get
        {
            PropriedadeAcessada(RO_CODECF);
            return _codecf;
        }
        set
        {
            PropriedadeModificada(RO_CODECF, value);
            _codecf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCINDICEECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 4, Precisao = 0)]
    public string Indice
    {
        get
        {
            PropriedadeAcessada(RO_INDICE);
            return _indice;
        }
        set
        {
            PropriedadeModificada(RO_INDICE, value);
            _indice = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCINDICEECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal Numcaixa
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

    public void InicializarAtributos()
    {
    }

    public string ObterNomeTabela()
    {
        return "PCINDICEECF";
    }

    public IEntidade NovaInstancia()
    {
        return (IEntidade)GetType().GetConstructors()[0].Invoke(null);
    }

    public void CarregarPorDataReader(IDataReader leitor)
    {
        _codecf = AlterarTipo<string>(leitor["Codecf"]);
        _indice = AlterarTipo<string>(leitor["Indice"]);
        _numcaixa = AlterarTipo<decimal>(leitor["Numcaixa"]);
    }

}