

////// namespace nwErp.Entidades.Winthor;

// namespace nwErp.Api.Modelos;

[Serializable]
public class PCCONVLISTAPRESENTE : GerenteDePropriedades, IEntidade
{
    private static readonly string RO_BAIXAMANUAL = "Baixamanual";

    private string _baixamanual;

    private static readonly string RO_CODAUXILIAR = "Codauxiliar";

    private decimal? _codauxiliar;

    private static readonly string RO_CODCLI = "Codcli";

    private decimal? _codcli;

    private static readonly string RO_DATACOMPRA = "Datacompra";

    private DateTime? _datacompra;

    private static readonly string RO_NOMECONVIDADO = "Nomeconvidado";

    private string _nomeconvidado;

    private static readonly string RO_NUMLISTA = "Numlista";

    private decimal _numlista;

    private static readonly string RO_QTDE = "Qtde";

    private decimal? _qtde;

    private static readonly string RO_NUMTRANSVENDA = "Numtransvenda";

    private decimal? _numtransvenda;

    private static readonly string RO_NUMORCA = "Numorca";

    private decimal? _numorca;

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONVLISTAPRESENTE", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Baixamanual
    {
        get
        {
            PropriedadeAcessada(RO_BAIXAMANUAL);
            return _baixamanual;
        }
        set
        {
            PropriedadeModificada(RO_BAIXAMANUAL, value);
            _baixamanual = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONVLISTAPRESENTE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 16, Precisao = 0)]
    public decimal? Codauxiliar
    {
        get
        {
            PropriedadeAcessada(RO_CODAUXILIAR);
            return _codauxiliar;
        }
        set
        {
            PropriedadeModificada(RO_CODAUXILIAR, value);
            _codauxiliar = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONVLISTAPRESENTE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codcli
    {
        get
        {
            PropriedadeAcessada(RO_CODCLI);
            return _codcli;
        }
        set
        {
            PropriedadeModificada(RO_CODCLI, value);
            _codcli = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONVLISTAPRESENTE", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Datacompra
    {
        get
        {
            PropriedadeAcessada(RO_DATACOMPRA);
            return _datacompra;
        }
        set
        {
            PropriedadeModificada(RO_DATACOMPRA, value);
            _datacompra = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONVLISTAPRESENTE", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 100, Precisao = 0)]
    public string Nomeconvidado
    {
        get
        {
            PropriedadeAcessada(RO_NOMECONVIDADO);
            return _nomeconvidado;
        }
        set
        {
            PropriedadeModificada(RO_NOMECONVIDADO, value);
            _nomeconvidado = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCCONVLISTAPRESENTE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal Numlista
    {
        get
        {
            PropriedadeAcessada(RO_NUMLISTA);
            return _numlista;
        }
        set
        {
            PropriedadeModificada(RO_NUMLISTA, value);
            _numlista = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONVLISTAPRESENTE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 2)]
    public decimal? Qtde
    {
        get
        {
            PropriedadeAcessada(RO_QTDE);
            return _qtde;
        }
        set
        {
            PropriedadeModificada(RO_QTDE, value);
            _qtde = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONVLISTAPRESENTE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numtransvenda
    {
        get
        {
            PropriedadeAcessada(RO_NUMTRANSVENDA);
            return _numtransvenda;
        }
        set
        {
            PropriedadeModificada(RO_NUMTRANSVENDA, value);
            _numtransvenda = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONVLISTAPRESENTE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numorca
    {
        get
        {
            PropriedadeAcessada(RO_NUMORCA);
            return _numorca;
        }
        set
        {
            PropriedadeModificada(RO_NUMORCA, value);
            _numorca = value;
        }
    }

    public void InicializarAtributos()
    {
    }

    public string ObterNomeTabela()
    {
        return "PCCONVLISTAPRESENTE";
    }

    public IEntidade NovaInstancia()
    {
        return (IEntidade)GetType().GetConstructors()[0].Invoke(null);
    }

    public void CarregarPorDataReader(IDataReader leitor)
    {
        _baixamanual = AlterarTipo<string>(leitor["Baixamanual"]);
        _codauxiliar = AlterarTipo<decimal?>(leitor["Codauxiliar"]);
        _codcli = AlterarTipo<decimal?>(leitor["Codcli"]);
        _datacompra = AlterarTipo<DateTime?>(leitor["Datacompra"]);
        _nomeconvidado = AlterarTipo<string>(leitor["Nomeconvidado"]);
        _numlista = AlterarTipo<decimal>(leitor["Numlista"]);
        _qtde = AlterarTipo<decimal?>(leitor["Qtde"]);
        _numtransvenda = AlterarTipo<decimal?>(leitor["Numtransvenda"]);
        _numorca = AlterarTipo<decimal?>(leitor["Numorca"]);
    }

}