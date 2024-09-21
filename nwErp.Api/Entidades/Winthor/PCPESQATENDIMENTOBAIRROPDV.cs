

////// namespace nwErp.Entidades.Caixa;

// namespace nwErp.Api.Modelos;

[Serializable]
public class PCPESQATENDIMENTOBAIRROPDV : GerenteDePropriedades, IEntidade
{
    private string _exportado;

    private string _bairro;

    private decimal? _codbairro;

    private string _codfilial;

    private decimal? _codopercx;

    private DateTime? _data;

    private decimal? _numpedecf;

    private decimal? _numcaixa;

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPESQATENDIMENTOBAIRROPDV", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Exportado
    {
        get
        {
            PropriedadeAcessada("Exportado");
            return _exportado;
        }
        set
        {
            PropriedadeModificada("Exportado", value);
            _exportado = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPESQATENDIMENTOBAIRROPDV", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 150, Precisao = 0)]
    public string Bairro
    {
        get
        {
            PropriedadeAcessada("Bairro");
            return _bairro;
        }
        set
        {
            PropriedadeModificada("Bairro", value);
            _bairro = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPESQATENDIMENTOBAIRROPDV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codbairro
    {
        get
        {
            PropriedadeAcessada("Codbairro");
            return _codbairro;
        }
        set
        {
            PropriedadeModificada("Codbairro", value);
            _codbairro = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPESQATENDIMENTOBAIRROPDV", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPESQATENDIMENTOBAIRROPDV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codopercx
    {
        get
        {
            PropriedadeAcessada("Codopercx");
            return _codopercx;
        }
        set
        {
            PropriedadeModificada("Codopercx", value);
            _codopercx = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPESQATENDIMENTOBAIRROPDV", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Data
    {
        get
        {
            PropriedadeAcessada("Data");
            return _data;
        }
        set
        {
            PropriedadeModificada("Data", value);
            _data = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPESQATENDIMENTOBAIRROPDV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numpedecf
    {
        get
        {
            PropriedadeAcessada("Numpedecf");
            return _numpedecf;
        }
        set
        {
            PropriedadeModificada("Numpedecf", value);
            _numpedecf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCPESQATENDIMENTOBAIRROPDV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
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

    public void InicializarAtributos()
    {
    }

    public string ObterNomeTabela()
    {
        return "PCPESQATENDIMENTOBAIRROPDV";
    }

    public IEntidade NovaInstancia()
    {
        return (IEntidade)GetType().GetConstructors()[0].Invoke(null);
    }

    public void CarregarPorDataReader(IDataReader leitor)
    {
        _exportado = AlterarTipo<string>(leitor["Exportado"]);
        _bairro = AlterarTipo<string>(leitor["Bairro"]);
        _codbairro = AlterarTipo<decimal?>(leitor["Codbairro"]);
        _codfilial = AlterarTipo<string>(leitor["Codfilial"]);
        _codopercx = AlterarTipo<decimal?>(leitor["Codopercx"]);
        _data = AlterarTipo<DateTime?>(leitor["Data"]);
        _numpedecf = AlterarTipo<decimal?>(leitor["Numpedecf"]);
        _numcaixa = AlterarTipo<decimal?>(leitor["Numcaixa"]);
    }

}