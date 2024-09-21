

////// // namespace nwErp.Entidades.Winthor;

// // namespace nwErp.Api.Modelos;

[Serializable]
public class PCOPERADORACEL : GerenteDePropriedades, IEntidade
{
    private static readonly string RO_CODCONTA = "Codconta";

    private decimal? _codconta;

    private static readonly string RO_CODFORNEC = "Codfornec";

    private decimal? _codfornec;

    private static readonly string RO_CODHIST = "Codhist";

    private decimal? _codhist;

    private static readonly string RO_CODOPERRECARGACEL = "Codoperrecargacel";

    private decimal _codoperrecargacel;

    private static readonly string RO_HISTCOMPL = "Histcompl";

    private string _histcompl;

    private static readonly string RO_OPERADORA = "Operadora";

    private string _operadora;

    private static readonly string RO_PERCDESC = "Percdesc";

    private decimal? _percdesc;

    private static readonly string RO_PRAZO = "Prazo";

    private decimal? _prazo;

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCOPERADORACEL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Codconta
    {
        get
        {
            PropriedadeAcessada(RO_CODCONTA);
            return _codconta;
        }
        set
        {
            PropriedadeModificada(RO_CODCONTA, value);
            _codconta = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCOPERADORACEL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codfornec
    {
        get
        {
            PropriedadeAcessada(RO_CODFORNEC);
            return _codfornec;
        }
        set
        {
            PropriedadeModificada(RO_CODFORNEC, value);
            _codfornec = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCOPERADORACEL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Codhist
    {
        get
        {
            PropriedadeAcessada(RO_CODHIST);
            return _codhist;
        }
        set
        {
            PropriedadeModificada(RO_CODHIST, value);
            _codhist = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCOPERADORACEL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 0)]
    public decimal Codoperrecargacel
    {
        get
        {
            PropriedadeAcessada(RO_CODOPERRECARGACEL);
            return _codoperrecargacel;
        }
        set
        {
            PropriedadeModificada(RO_CODOPERRECARGACEL, value);
            _codoperrecargacel = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCOPERADORACEL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 200, Precisao = 0)]
    public string Histcompl
    {
        get
        {
            PropriedadeAcessada(RO_HISTCOMPL);
            return _histcompl;
        }
        set
        {
            PropriedadeModificada(RO_HISTCOMPL, value);
            _histcompl = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCOPERADORACEL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 100, Precisao = 0)]
    public string Operadora
    {
        get
        {
            PropriedadeAcessada(RO_OPERADORA);
            return _operadora;
        }
        set
        {
            PropriedadeModificada(RO_OPERADORA, value);
            _operadora = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCOPERADORACEL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 2)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCOPERADORACEL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Prazo
    {
        get
        {
            PropriedadeAcessada(RO_PRAZO);
            return _prazo;
        }
        set
        {
            PropriedadeModificada(RO_PRAZO, value);
            _prazo = value;
        }
    }

    public void InicializarAtributos()
    {
    }

    public string ObterNomeTabela()
    {
        return "PCOPERADORACEL";
    }

    public IEntidade NovaInstancia()
    {
        return (IEntidade)GetType().GetConstructors()[0].Invoke(null);
    }

    public void CarregarPorDataReader(IDataReader leitor)
    {
        _codconta = AlterarTipo<decimal?>(leitor["Codconta"]);
        _codfornec = AlterarTipo<decimal?>(leitor["Codfornec"]);
        _codhist = AlterarTipo<decimal?>(leitor["Codhist"]);
        _codoperrecargacel = AlterarTipo<decimal>(leitor["Codoperrecargacel"]);
        _histcompl = AlterarTipo<string>(leitor["Histcompl"]);
        _operadora = AlterarTipo<string>(leitor["Operadora"]);
        _percdesc = AlterarTipo<decimal?>(leitor["Percdesc"]);
        _prazo = AlterarTipo<decimal?>(leitor["Prazo"]);
    }

}