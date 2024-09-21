

////// namespace nwErp.Entidades.Winthor;

// namespace nwErp.Api.Modelos;

[Serializable]
public class PCRECALCULOPROD : GerenteDePropriedades, IEntidade
{
    private string _codfilial;

    private decimal _codprod;

    private DateTime? _dtinclusao;

    private DateTime? _dtrecalculo;

    private decimal? _numtransvenda;

    private decimal? _qt;

    private string _tiporegistro;

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCRECALCULOPROD", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Codfilial
    {
        get
        {
            PropriedadeAcessada("Codfilial");
            return _codfilial;
        }
        set
        {
            PropriedadeModificada("Codfilial", value);
            _codfilial = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCRECALCULOPROD", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal Codprod
    {
        get
        {
            PropriedadeAcessada("Codprod");
            return _codprod;
        }
        set
        {
            PropriedadeModificada("Codprod", value);
            _codprod = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCRECALCULOPROD", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtinclusao
    {
        get
        {
            PropriedadeAcessada("Dtinclusao");
            return _dtinclusao;
        }
        set
        {
            PropriedadeModificada("Dtinclusao", value);
            _dtinclusao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCRECALCULOPROD", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtrecalculo
    {
        get
        {
            PropriedadeAcessada("Dtrecalculo");
            return _dtrecalculo;
        }
        set
        {
            PropriedadeModificada("Dtrecalculo", value);
            _dtrecalculo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCRECALCULOPROD", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numtransvenda
    {
        get
        {
            PropriedadeAcessada("Numtransvenda");
            return _numtransvenda;
        }
        set
        {
            PropriedadeModificada("Numtransvenda", value);
            _numtransvenda = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCRECALCULOPROD", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 20, Precisao = 6)]
    public decimal? Qt
    {
        get
        {
            PropriedadeAcessada("Qt");
            return _qt;
        }
        set
        {
            PropriedadeModificada("Qt", value);
            _qt = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCRECALCULOPROD", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Tiporegistro
    {
        get
        {
            PropriedadeAcessada("Tiporegistro");
            return _tiporegistro;
        }
        set
        {
            PropriedadeModificada("Tiporegistro", value);
            _tiporegistro = value;
        }
    }

    public void InicializarAtributos()
    {
    }

    public string ObterNomeTabela()
    {
        return "PCRECALCULOPROD";
    }

    public IEntidade NovaInstancia()
    {
        return (IEntidade)GetType().GetConstructors()[0].Invoke(null);
    }

    public void CarregarPorDataReader(IDataReader leitor)
    {
        _codfilial = AlterarTipo<string>(leitor["Codfilial"]);
        _codprod = AlterarTipo<decimal>(leitor["Codprod"]);
        _dtinclusao = AlterarTipo<DateTime?>(leitor["Dtinclusao"]);
        _dtrecalculo = AlterarTipo<DateTime?>(leitor["Dtrecalculo"]);
        _numtransvenda = AlterarTipo<decimal?>(leitor["Numtransvenda"]);
        _qt = AlterarTipo<decimal?>(leitor["Qt"]);
        _tiporegistro = AlterarTipo<string>(leitor["Tiporegistro"]);
    }

}