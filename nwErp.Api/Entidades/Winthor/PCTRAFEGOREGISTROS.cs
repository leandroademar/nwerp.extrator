

////// namespace nwErp.Entidades.Winthor;

// namespace nwErp.Api.Modelos;

[Serializable]
public class PCTRAFEGOREGISTROS : GerenteDePropriedades, IEntidade
{
    private static readonly string RO_DATA = "Data";

    private DateTime _data;

    private static readonly string RO_OBS = "Obs";

    private string _obs;

    private static readonly string RO_TABELA = "Tabela";

    private string _tabela;

    private static readonly string RO_TAG = "Tag";

    private string _tag;

    private static readonly string RO_VALORROWID = "Valorrowid";

    private string _valorrowid;

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRAFEGOREGISTROS", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime Data
    {
        get
        {
            PropriedadeAcessada(RO_DATA);
            return _data;
        }
        set
        {
            PropriedadeModificada(RO_DATA, value);
            _data = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRAFEGOREGISTROS", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 200, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRAFEGOREGISTROS", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 30, Precisao = 0)]
    public string Tabela
    {
        get
        {
            PropriedadeAcessada(RO_TABELA);
            return _tabela;
        }
        set
        {
            PropriedadeModificada(RO_TABELA, value);
            _tabela = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRAFEGOREGISTROS", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 3, Precisao = 0)]
    public string Tag
    {
        get
        {
            PropriedadeAcessada(RO_TAG);
            return _tag;
        }
        set
        {
            PropriedadeModificada(RO_TAG, value);
            _tag = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRAFEGOREGISTROS", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
    public string Valorrowid
    {
        get
        {
            PropriedadeAcessada(RO_VALORROWID);
            return _valorrowid;
        }
        set
        {
            PropriedadeModificada(RO_VALORROWID, value);
            _valorrowid = value;
        }
    }

    public void InicializarAtributos()
    {
    }

    public string ObterNomeTabela()
    {
        return "PCTRAFEGOREGISTROS";
    }

    public IEntidade NovaInstancia()
    {
        return (IEntidade)GetType().GetConstructors()[0].Invoke(null);
    }

    public void CarregarPorDataReader(IDataReader leitor)
    {
        _data = AlterarTipo<DateTime>(leitor["Data"]);
        _obs = AlterarTipo<string>(leitor["Obs"]);
        _tabela = AlterarTipo<string>(leitor["Tabela"]);
        _tag = AlterarTipo<string>(leitor["Tag"]);
        _valorrowid = AlterarTipo<string>(leitor["Valorrowid"]);
    }

	
}