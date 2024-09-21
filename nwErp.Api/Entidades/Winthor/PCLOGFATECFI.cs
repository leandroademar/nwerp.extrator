

////// // namespace nwErp.Entidades.Winthor;

// // namespace nwErp.Api.Modelos;

[Serializable]
public class PCLOGFATECFI : GerenteDePropriedades, IEntidade
{
    private static readonly string RO_CODIGOLOG = "Codigolog";

    private decimal _codigolog;

    private static readonly string RO_ORDEM = "Ordem";

    private decimal _ordem;

    private static readonly string RO_TEXTO = "Texto";

    private string _texto;

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOGFATECFI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal Codigolog
    {
        get
        {
            PropriedadeAcessada(RO_CODIGOLOG);
            return _codigolog;
        }
        set
        {
            PropriedadeModificada(RO_CODIGOLOG, value);
            _codigolog = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOGFATECFI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 0)]
    public decimal Ordem
    {
        get
        {
            PropriedadeAcessada(RO_ORDEM);
            return _ordem;
        }
        set
        {
            PropriedadeModificada(RO_ORDEM, value);
            _ordem = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOGFATECFI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 500, Precisao = 0)]
    public string Texto
    {
        get
        {
            PropriedadeAcessada(RO_TEXTO);
            return _texto;
        }
        set
        {
            PropriedadeModificada(RO_TEXTO, value);
            _texto = value;
        }
    }

    public void InicializarAtributos()
    {
    }

    public string ObterNomeTabela()
    {
        return "PCLOGFATECFI";
    }

    public IEntidade NovaInstancia()
    {
        return (IEntidade)GetType().GetConstructors()[0].Invoke(null);
    }

    public void CarregarPorDataReader(IDataReader leitor)
    {
        _codigolog = AlterarTipo<decimal>(leitor["Codigolog"]);
        _ordem = AlterarTipo<decimal>(leitor["Ordem"]);
        _texto = AlterarTipo<string>(leitor["Texto"]);
    }

}