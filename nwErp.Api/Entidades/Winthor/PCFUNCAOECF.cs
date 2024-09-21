

////// // namespace nwErp.Entidades.Winthor;

// // namespace nwErp.Api.Modelos;

[Serializable]
public class PCFUNCAOECF : GerenteDePropriedades, IEntidade
{
    private static readonly string RO_ALT = "Alt";

    private string _alt;

    private static readonly string RO_CATEGORIA = "Categoria";

    private string _categoria;

    private static readonly string RO_CODIGOFUNCAO = "Codigofuncao";

    private decimal _codigofuncao;

    private static readonly string RO_CODIGOTELA = "Codigotela";

    private decimal? _codigotela;

    private static readonly string RO_CTRL = "Ctrl";

    private string _ctrl;

    private static readonly string RO_DESCRICAO = "Descricao";

    private string _descricao;

    private static readonly string RO_SHIFT = "Shift";

    private string _shift;

    private static readonly string RO_TECLA = "Tecla";

    private decimal? _tecla;

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFUNCAOECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFUNCAOECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
    public string Categoria
    {
        get
        {
            PropriedadeAcessada(RO_CATEGORIA);
            return _categoria;
        }
        set
        {
            PropriedadeModificada(RO_CATEGORIA, value);
            _categoria = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCFUNCAOECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFUNCAOECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 2, Precisao = 0)]
    public decimal? Codigotela
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFUNCAOECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFUNCAOECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFUNCAOECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFUNCAOECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 3, Precisao = 0)]
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
        return "PCFUNCAOECF";
    }

    public IEntidade NovaInstancia()
    {
        return (IEntidade)GetType().GetConstructors()[0].Invoke(null);
    }

    public void CarregarPorDataReader(IDataReader leitor)
    {
        _alt = AlterarTipo<string>(leitor["Alt"]);
        _categoria = AlterarTipo<string>(leitor["Categoria"]);
        _codigofuncao = AlterarTipo<decimal>(leitor["Codigofuncao"]);
        _codigotela = AlterarTipo<decimal?>(leitor["Codigotela"]);
        _ctrl = AlterarTipo<string>(leitor["Ctrl"]);
        _descricao = AlterarTipo<string>(leitor["Descricao"]);
        _shift = AlterarTipo<string>(leitor["Shift"]);
        _tecla = AlterarTipo<decimal?>(leitor["Tecla"]);
    }

}