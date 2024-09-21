

////// // namespace nwErp.Entidades.Winthor;

// // namespace nwErp.Api.Modelos;

[Serializable]
public class PCATALHOSFUNCAOECF : GerenteDePropriedades, IEntidade
{
    private static readonly string RO_ALT = "Alt";

    private string _alt;

    private static readonly string RO_CODIGOFUNCAO = "Codigofuncao";

    private decimal _codigofuncao;

    private static readonly string RO_CODIGOLAYOUT = "Codigolayout";

    private decimal _codigolayout;

    private static readonly string RO_CTRL = "Ctrl";

    private string _ctrl;

    private static readonly string RO_SHIFT = "Shift";

    private string _shift;

    private static readonly string RO_TECLA = "Tecla";

    private decimal? _tecla;

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCATALHOSFUNCAOECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Alt
    {
        get
        {
            PropriedadeAcessada(RO_ALT);
            return _alt;
        }
        set
        {
            PropriedadeModificada(RO_ALT, value);
            _alt = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCATALHOSFUNCAOECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 0)]
    public decimal Codigofuncao
    {
        get
        {
            PropriedadeAcessada(RO_CODIGOFUNCAO);
            return _codigofuncao;
        }
        set
        {
            PropriedadeModificada(RO_CODIGOFUNCAO, value);
            _codigofuncao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCATALHOSFUNCAOECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCATALHOSFUNCAOECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Ctrl
    {
        get
        {
            PropriedadeAcessada(RO_CTRL);
            return _ctrl;
        }
        set
        {
            PropriedadeModificada(RO_CTRL, value);
            _ctrl = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCATALHOSFUNCAOECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Shift
    {
        get
        {
            PropriedadeAcessada(RO_SHIFT);
            return _shift;
        }
        set
        {
            PropriedadeModificada(RO_SHIFT, value);
            _shift = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCATALHOSFUNCAOECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 3, Precisao = 0)]
    public decimal? Tecla
    {
        get
        {
            PropriedadeAcessada(RO_TECLA);
            return _tecla;
        }
        set
        {
            PropriedadeModificada(RO_TECLA, value);
            _tecla = value;
        }
    }

    public void InicializarAtributos()
    {
    }

    public string ObterNomeTabela()
    {
        return "PCATALHOSFUNCAOECF";
    }

    public IEntidade NovaInstancia()
    {
        return (IEntidade)GetType().GetConstructors()[0].Invoke(null);
    }

    public void CarregarPorDataReader(IDataReader leitor)
    {
        _alt = AlterarTipo<string>(leitor["Alt"]);
        _codigofuncao = AlterarTipo<decimal>(leitor["Codigofuncao"]);
        _codigolayout = AlterarTipo<decimal>(leitor["Codigolayout"]);
        _ctrl = AlterarTipo<string>(leitor["Ctrl"]);
        _shift = AlterarTipo<string>(leitor["Shift"]);
        _tecla = AlterarTipo<decimal?>(leitor["Tecla"]);
    }

}