

////// namespace nwErp.Entidades.Winthor;

// namespace nwErp.Api.Modelos;

[Serializable]
public class PCLISTAPRESENTEI : GerenteDePropriedades, IEntidade
{
    private static readonly string RO_CODAUXILIAR = "Codauxiliar";

    private decimal _codauxiliar;

    private static readonly string RO_NUMLISTA = "Numlista";

    private decimal _numlista;

    private static readonly string RO_NUMSEQ = "Numseq";

    private decimal? _numseq;

    private static readonly string RO_OBS = "Obs";

    private string _obs;

    private static readonly string RO_QTITENS = "Qtitens";

    private decimal? _qtitens;

    private static readonly string RO_QTITENSVENDIDOS = "Qtitensvendidos";

    private decimal? _qtitensvendidos;

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCLISTAPRESENTEI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 16, Precisao = 0)]
    public decimal Codauxiliar
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

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCLISTAPRESENTEI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLISTAPRESENTEI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 0)]
    public decimal? Numseq
    {
        get
        {
            PropriedadeAcessada(RO_NUMSEQ);
            return _numseq;
        }
        set
        {
            PropriedadeModificada(RO_NUMSEQ, value);
            _numseq = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLISTAPRESENTEI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 4000, Precisao = 0)]
    public string Obs
    {
        get
        {
            PropriedadeAcessada(RO_OBS);
            return _obs;
        }
        set
        {
            PropriedadeModificada(RO_OBS, value);
            _obs = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLISTAPRESENTEI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 2)]
    public decimal? Qtitens
    {
        get
        {
            PropriedadeAcessada(RO_QTITENS);
            return _qtitens;
        }
        set
        {
            PropriedadeModificada(RO_QTITENS, value);
            _qtitens = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLISTAPRESENTEI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 2)]
    public decimal? Qtitensvendidos
    {
        get
        {
            PropriedadeAcessada(RO_QTITENSVENDIDOS);
            return _qtitensvendidos;
        }
        set
        {
            PropriedadeModificada(RO_QTITENSVENDIDOS, value);
            _qtitensvendidos = value;
        }
    }

    public void InicializarAtributos()
    {
    }

    public string ObterNomeTabela()
    {
        return "PCLISTAPRESENTEI";
    }

    public IEntidade NovaInstancia()
    {
        return (IEntidade)GetType().GetConstructors()[0].Invoke(null);
    }

    public void CarregarPorDataReader(IDataReader leitor)
    {
        _codauxiliar = AlterarTipo<decimal>(leitor["Codauxiliar"]);
        _numlista = AlterarTipo<decimal>(leitor["Numlista"]);
        _numseq = AlterarTipo<decimal?>(leitor["Numseq"]);
        _obs = AlterarTipo<string>(leitor["Obs"]);
        _qtitens = AlterarTipo<decimal?>(leitor["Qtitens"]);
        _qtitensvendidos = AlterarTipo<decimal?>(leitor["Qtitensvendidos"]);
    }

}