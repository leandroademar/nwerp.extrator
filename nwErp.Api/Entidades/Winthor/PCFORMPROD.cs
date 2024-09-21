

////// // namespace nwErp.Entidades.Winthor;

// // namespace nwErp.Api.Modelos;

[Serializable]
public class PCFORMPROD : GerenteDePropriedades, IEntidade
{
    private static readonly string RO_ACEITAFRACAO = "Aceitafracao";

    private string _aceitafracao;

    private static readonly string RO_BAIXAESTOQUE = "Baixaestoque";

    private string _baixaestoque;

    private static readonly string RO_CODAUXILIARMP = "Codauxiliarmp";

    private decimal? _codauxiliarmp;

    private static readonly string RO_CODFILIAL = "Codfilial";

    private string _codfilial;

    private static readonly string RO_CODOPER = "Codoper";

    private string _codoper;

    private static readonly string RO_CODPRODACAB = "Codprodacab";

    private decimal _codprodacab;

    private static readonly string RO_CODPRODMP = "Codprodmp";

    private decimal _codprodmp;

    private static readonly string RO_CUSTOKG = "Custokg";

    private decimal? _custokg;

    private static readonly string RO_CUSTOMP = "Customp";

    private decimal? _customp;

    private static readonly string RO_CUSTOPORKG = "Custoporkg";

    private decimal? _custoporkg;

    private static readonly string RO_CUSTOPRODUTO = "Custoproduto";

    private decimal? _custoproduto;

    private static readonly string RO_GERAETIQUETA = "Geraetiqueta";

    private string _geraetiqueta;

    private static readonly string RO_PERCPRODACABADO = "Percprodacabado";

    private decimal? _percprodacabado;

    private static readonly string RO_PERCVALORPRODACABADO = "Percvalorprodacabado";

    private decimal? _percvalorprodacabado;

    private static readonly string RO_QTDEMPPORKG = "Qtdempporkg";

    private decimal? _qtdempporkg;

    private static readonly string RO_QTMPBAIXAR = "Qtmpbaixar";

    private decimal? _qtmpbaixar;

    private static readonly string RO_QTPRODACAB = "Qtprodacab";

    private decimal _qtprodacab;

    private static readonly string RO_QTPRODMP = "Qtprodmp";

    private decimal _qtprodmp;

    private static readonly string RO_QTPRODUCAO = "Qtproducao";

    private decimal? _qtproducao;

    private static readonly string RO_QTRENDA = "Qtrenda";

    private decimal? _qtrenda;

    private static readonly string RO_VLCUSTOMONTAGEM = "Vlcustomontagem";

    private decimal? _vlcustomontagem;

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORMPROD", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Aceitafracao
    {
        get
        {
            PropriedadeAcessada(RO_ACEITAFRACAO);
            return _aceitafracao;
        }
        set
        {
            PropriedadeModificada(RO_ACEITAFRACAO, value);
            _aceitafracao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORMPROD", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Baixaestoque
    {
        get
        {
            PropriedadeAcessada(RO_BAIXAESTOQUE);
            return _baixaestoque;
        }
        set
        {
            PropriedadeModificada(RO_BAIXAESTOQUE, value);
            _baixaestoque = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORMPROD", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 16, Precisao = 0)]
    public decimal? Codauxiliarmp
    {
        get
        {
            PropriedadeAcessada(RO_CODAUXILIARMP);
            return _codauxiliarmp;
        }
        set
        {
            PropriedadeModificada(RO_CODAUXILIARMP, value);
            _codauxiliarmp = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORMPROD", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Codfilial
    {
        get
        {
            PropriedadeAcessada(RO_CODFILIAL);
            return _codfilial;
        }
        set
        {
            PropriedadeModificada(RO_CODFILIAL, value);
            _codfilial = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORMPROD", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Codoper
    {
        get
        {
            PropriedadeAcessada(RO_CODOPER);
            return _codoper;
        }
        set
        {
            PropriedadeModificada(RO_CODOPER, value);
            _codoper = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCFORMPROD", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal Codprodacab
    {
        get
        {
            PropriedadeAcessada(RO_CODPRODACAB);
            return _codprodacab;
        }
        set
        {
            PropriedadeModificada(RO_CODPRODACAB, value);
            _codprodacab = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCFORMPROD", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal Codprodmp
    {
        get
        {
            PropriedadeAcessada(RO_CODPRODMP);
            return _codprodmp;
        }
        set
        {
            PropriedadeModificada(RO_CODPRODMP, value);
            _codprodmp = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORMPROD", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 6)]
    public decimal? Custokg
    {
        get
        {
            PropriedadeAcessada(RO_CUSTOKG);
            return _custokg;
        }
        set
        {
            PropriedadeModificada(RO_CUSTOKG, value);
            _custokg = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORMPROD", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 6)]
    public decimal? Customp
    {
        get
        {
            PropriedadeAcessada(RO_CUSTOMP);
            return _customp;
        }
        set
        {
            PropriedadeModificada(RO_CUSTOMP, value);
            _customp = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORMPROD", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 6)]
    public decimal? Custoporkg
    {
        get
        {
            PropriedadeAcessada(RO_CUSTOPORKG);
            return _custoporkg;
        }
        set
        {
            PropriedadeModificada(RO_CUSTOPORKG, value);
            _custoporkg = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORMPROD", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 6)]
    public decimal? Custoproduto
    {
        get
        {
            PropriedadeAcessada(RO_CUSTOPRODUTO);
            return _custoproduto;
        }
        set
        {
            PropriedadeModificada(RO_CUSTOPRODUTO, value);
            _custoproduto = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORMPROD", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Geraetiqueta
    {
        get
        {
            PropriedadeAcessada(RO_GERAETIQUETA);
            return _geraetiqueta;
        }
        set
        {
            PropriedadeModificada(RO_GERAETIQUETA, value);
            _geraetiqueta = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORMPROD", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Percprodacabado
    {
        get
        {
            PropriedadeAcessada(RO_PERCPRODACABADO);
            return _percprodacabado;
        }
        set
        {
            PropriedadeModificada(RO_PERCPRODACABADO, value);
            _percprodacabado = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORMPROD", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Percvalorprodacabado
    {
        get
        {
            PropriedadeAcessada(RO_PERCVALORPRODACABADO);
            return _percvalorprodacabado;
        }
        set
        {
            PropriedadeModificada(RO_PERCVALORPRODACABADO, value);
            _percvalorprodacabado = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORMPROD", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 6)]
    public decimal? Qtdempporkg
    {
        get
        {
            PropriedadeAcessada(RO_QTDEMPPORKG);
            return _qtdempporkg;
        }
        set
        {
            PropriedadeModificada(RO_QTDEMPPORKG, value);
            _qtdempporkg = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORMPROD", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 6)]
    public decimal? Qtmpbaixar
    {
        get
        {
            PropriedadeAcessada(RO_QTMPBAIXAR);
            return _qtmpbaixar;
        }
        set
        {
            PropriedadeModificada(RO_QTMPBAIXAR, value);
            _qtmpbaixar = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORMPROD", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 6)]
    public decimal Qtprodacab
    {
        get
        {
            PropriedadeAcessada(RO_QTPRODACAB);
            return _qtprodacab;
        }
        set
        {
            PropriedadeModificada(RO_QTPRODACAB, value);
            _qtprodacab = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORMPROD", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 6)]
    public decimal Qtprodmp
    {
        get
        {
            PropriedadeAcessada(RO_QTPRODMP);
            return _qtprodmp;
        }
        set
        {
            PropriedadeModificada(RO_QTPRODMP, value);
            _qtprodmp = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORMPROD", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 6)]
    public decimal? Qtproducao
    {
        get
        {
            PropriedadeAcessada(RO_QTPRODUCAO);
            return _qtproducao;
        }
        set
        {
            PropriedadeModificada(RO_QTPRODUCAO, value);
            _qtproducao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORMPROD", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 6)]
    public decimal? Qtrenda
    {
        get
        {
            PropriedadeAcessada(RO_QTRENDA);
            return _qtrenda;
        }
        set
        {
            PropriedadeModificada(RO_QTRENDA, value);
            _qtrenda = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFORMPROD", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 6)]
    public decimal? Vlcustomontagem
    {
        get
        {
            PropriedadeAcessada(RO_VLCUSTOMONTAGEM);
            return _vlcustomontagem;
        }
        set
        {
            PropriedadeModificada(RO_VLCUSTOMONTAGEM, value);
            _vlcustomontagem = value;
        }
    }

    public void InicializarAtributos()
    {
    }

    public string ObterNomeTabela()
    {
        return "PCFORMPROD";
    }

    public IEntidade NovaInstancia()
    {
        return (IEntidade)GetType().GetConstructors()[0].Invoke(null);
    }

    public void CarregarPorDataReader(IDataReader leitor)
    {
        _aceitafracao = AlterarTipo<string>(leitor["Aceitafracao"]);
        _baixaestoque = AlterarTipo<string>(leitor["Baixaestoque"]);
        _codauxiliarmp = AlterarTipo<decimal?>(leitor["Codauxiliarmp"]);
        _codfilial = AlterarTipo<string>(leitor["Codfilial"]);
        _codoper = AlterarTipo<string>(leitor["Codoper"]);
        _codprodacab = AlterarTipo<decimal>(leitor["Codprodacab"]);
        _codprodmp = AlterarTipo<decimal>(leitor["Codprodmp"]);
        _custokg = AlterarTipo<decimal?>(leitor["Custokg"]);
        _customp = AlterarTipo<decimal?>(leitor["Customp"]);
        _custoporkg = AlterarTipo<decimal?>(leitor["Custoporkg"]);
        _custoproduto = AlterarTipo<decimal?>(leitor["Custoproduto"]);
        _geraetiqueta = AlterarTipo<string>(leitor["Geraetiqueta"]);
        _percprodacabado = AlterarTipo<decimal?>(leitor["Percprodacabado"]);
        _percvalorprodacabado = AlterarTipo<decimal?>(leitor["Percvalorprodacabado"]);
        _qtdempporkg = AlterarTipo<decimal?>(leitor["Qtdempporkg"]);
        _qtmpbaixar = AlterarTipo<decimal?>(leitor["Qtmpbaixar"]);
        _qtprodacab = AlterarTipo<decimal>(leitor["Qtprodacab"]);
        _qtprodmp = AlterarTipo<decimal>(leitor["Qtprodmp"]);
        _qtproducao = AlterarTipo<decimal?>(leitor["Qtproducao"]);
        _qtrenda = AlterarTipo<decimal?>(leitor["Qtrenda"]);
        _vlcustomontagem = AlterarTipo<decimal?>(leitor["Vlcustomontagem"]);
    }

}