

////// namespace nwErp.Entidades.Winthor;

// namespace nwErp.Api.Modelos;

[Serializable]
public class PCTABTRIB : GerenteDePropriedades, IEntidade
{
    private static readonly string RO_CODFILIALNF = "Codfilialnf";

    private string _codfilialnf;

    private static readonly string RO_CODPROD = "Codprod";

    private decimal _codprod;

    private static readonly string RO_CODST = "Codst";

    private decimal _codst;

    private static readonly string RO_CODTRIBPISCOFINS = "Codtribpiscofins";

    private decimal? _codtribpiscofins;

    private static readonly string RO_DTULTALTER = "Dtultalter";

    private DateTime? _dtultalter;

    private static readonly string RO_UFDESTINO = "Ufdestino";

    private string _ufdestino;

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCTABTRIB", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Codfilialnf
    {
        get
        {
            PropriedadeAcessada(RO_CODFILIALNF);
            return _codfilialnf;
        }
        set
        {
            PropriedadeModificada(RO_CODFILIALNF, value);
            _codfilialnf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCTABTRIB", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTABTRIB", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal Codst
    {
        get
        {
            PropriedadeAcessada(RO_CODST);
            return _codst;
        }
        set
        {
            PropriedadeModificada(RO_CODST, value);
            _codst = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTABTRIB", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Codtribpiscofins
    {
        get
        {
            PropriedadeAcessada(RO_CODTRIBPISCOFINS);
            return _codtribpiscofins;
        }
        set
        {
            PropriedadeModificada(RO_CODTRIBPISCOFINS, value);
            _codtribpiscofins = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTABTRIB", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtultalter
    {
        get
        {
            PropriedadeAcessada(RO_DTULTALTER);
            return _dtultalter;
        }
        set
        {
            PropriedadeModificada(RO_DTULTALTER, value);
            _dtultalter = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCTABTRIB", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Ufdestino
    {
        get
        {
            PropriedadeAcessada(RO_UFDESTINO);
            return _ufdestino;
        }
        set
        {
            PropriedadeModificada(RO_UFDESTINO, value);
            _ufdestino = value;
        }
    }

    public void InicializarAtributos()
    {
    }

    public string ObterNomeTabela()
    {
        return "PCTABTRIB";
    }

    public IEntidade NovaInstancia()
    {
        return (IEntidade)GetType().GetConstructors()[0].Invoke(null);
    }

    public void CarregarPorDataReader(IDataReader leitor)
    {
        _codfilialnf = AlterarTipo<string>(leitor["Codfilialnf"]);
        _codprod = AlterarTipo<decimal>(leitor["Codprod"]);
        _codst = AlterarTipo<decimal>(leitor["Codst"]);
        _codtribpiscofins = AlterarTipo<decimal?>(leitor["Codtribpiscofins"]);
        _dtultalter = AlterarTipo<DateTime?>(leitor["Dtultalter"]);
        _ufdestino = AlterarTipo<string>(leitor["Ufdestino"]);
    }

}