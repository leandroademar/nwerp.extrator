

//// // namespace ExportadorNFCe;

// // namespace nwErp.Api.Modelos;

[Serializable]
public class PCATIVI : GerenteDePropriedades, IEntidade
{
    private static readonly string RO_ATACADISTA = "Atacadista";

    private string _atacadista;

    private static readonly string RO_CODATIV = "Codativ";

    private decimal _codativ;

    private static readonly string RO_CODATIVPRINC = "Codativprinc";

    private decimal? _codativprinc;

    private static readonly string RO_CODCATEGORIABAUDU = "Codcategoriabaudu";

    private string _codcategoriabaudu;

    private static readonly string RO_CODCATEGORIAKRAFT = "Codcategoriakraft";

    private decimal? _codcategoriakraft;

    private static readonly string RO_CODCP = "Codcp";

    private string _codcp;

    private static readonly string RO_CODRAMONESTLE = "Codramonestle";

    private decimal? _codramonestle;

    private static readonly string RO_COR = "Cor";

    private string _cor;

    private static readonly string RO_PERCDESC = "Percdesc";

    private decimal? _percdesc;

    private static readonly string RO_RAMO = "Ramo";

    private string _ramo;

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCATIVI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Atacadista
    {
        get
        {
            PropriedadeAcessada(RO_ATACADISTA);
            return _atacadista;
        }
        set
        {
            PropriedadeModificada(RO_ATACADISTA, value);
            _atacadista = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCATIVI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal Codativ
    {
        get
        {
            PropriedadeAcessada(RO_CODATIV);
            return _codativ;
        }
        set
        {
            PropriedadeModificada(RO_CODATIV, value);
            _codativ = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCATIVI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codativprinc
    {
        get
        {
            PropriedadeAcessada(RO_CODATIVPRINC);
            return _codativprinc;
        }
        set
        {
            PropriedadeModificada(RO_CODATIVPRINC, value);
            _codativprinc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCATIVI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 10, Precisao = 0)]
    public string Codcategoriabaudu
    {
        get
        {
            PropriedadeAcessada(RO_CODCATEGORIABAUDU);
            return _codcategoriabaudu;
        }
        set
        {
            PropriedadeModificada(RO_CODCATEGORIABAUDU, value);
            _codcategoriabaudu = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCATIVI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 2, Precisao = 0)]
    public decimal? Codcategoriakraft
    {
        get
        {
            PropriedadeAcessada(RO_CODCATEGORIAKRAFT);
            return _codcategoriakraft;
        }
        set
        {
            PropriedadeModificada(RO_CODCATEGORIAKRAFT, value);
            _codcategoriakraft = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCATIVI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 6, Precisao = 0)]
    public string Codcp
    {
        get
        {
            PropriedadeAcessada(RO_CODCP);
            return _codcp;
        }
        set
        {
            PropriedadeModificada(RO_CODCP, value);
            _codcp = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCATIVI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codramonestle
    {
        get
        {
            PropriedadeAcessada(RO_CODRAMONESTLE);
            return _codramonestle;
        }
        set
        {
            PropriedadeModificada(RO_CODRAMONESTLE, value);
            _codramonestle = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCATIVI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 30, Precisao = 0)]
    public string Cor
    {
        get
        {
            PropriedadeAcessada(RO_COR);
            return _cor;
        }
        set
        {
            PropriedadeModificada(RO_COR, value);
            _cor = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCATIVI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 2)]
    public decimal? Percdesc
    {
        get
        {
            PropriedadeAcessada(RO_PERCDESC);
            return _percdesc;
        }
        set
        {
            PropriedadeModificada(RO_PERCDESC, value);
            _percdesc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCATIVI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
    public string Ramo
    {
        get
        {
            PropriedadeAcessada(RO_RAMO);
            return _ramo;
        }
        set
        {
            PropriedadeModificada(RO_RAMO, value);
            _ramo = value;
        }
    }

    public void InicializarAtributos()
    {
    }

    public string ObterNomeTabela()
    {
        return "PCATIVI";
    }

    public IEntidade NovaInstancia()
    {
        return (IEntidade)GetType().GetConstructors()[0].Invoke(null);
    }

    public void CarregarPorDataReader(IDataReader leitor)
    {
        _atacadista = AlterarTipo<string>(leitor["Atacadista"]);
        _codativ = AlterarTipo<decimal>(leitor["Codativ"]);
        _codativprinc = AlterarTipo<decimal?>(leitor["Codativprinc"]);
        _codcategoriabaudu = AlterarTipo<string>(leitor["Codcategoriabaudu"]);
        _codcategoriakraft = AlterarTipo<decimal?>(leitor["Codcategoriakraft"]);
        _codcp = AlterarTipo<string>(leitor["Codcp"]);
        _codramonestle = AlterarTipo<decimal?>(leitor["Codramonestle"]);
        _cor = AlterarTipo<string>(leitor["Cor"]);
        _percdesc = AlterarTipo<decimal?>(leitor["Percdesc"]);
        _ramo = AlterarTipo<string>(leitor["Ramo"]);
    }

}