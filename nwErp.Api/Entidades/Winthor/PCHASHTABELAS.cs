

////// // namespace nwErp.Entidades.Winthor;

// // namespace nwErp.Api.Modelos;

[Serializable]
public class PCHASHTABELAS : GerenteDePropriedades, IEntidade
{
    private string _hashmd5;

    private string _script;

    private string _tabela;

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCHASHTABELAS", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 255, Precisao = 0)]
    public string Hashmd5
    {
        get
        {
            PropriedadeAcessada("Hashmd5");
            return _hashmd5;
        }
        set
        {
            PropriedadeModificada("Hashmd5", value);
            _hashmd5 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCHASHTABELAS", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 4000, Precisao = 0)]
    public string Script
    {
        get
        {
            PropriedadeAcessada("Script");
            return _script;
        }
        set
        {
            PropriedadeModificada("Script", value);
            _script = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCHASHTABELAS", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 50, Precisao = 0)]
    public string Tabela
    {
        get
        {
            PropriedadeAcessada("Tabela");
            return _tabela;
        }
        set
        {
            PropriedadeModificada("Tabela", value);
            _tabela = value;
        }
    }

    public void InicializarAtributos()
    {
    }

    public string ObterNomeTabela()
    {
        return "PCHASHTABELAS";
    }

    public IEntidade NovaInstancia()
    {
        return (IEntidade)GetType().GetConstructors()[0].Invoke(null);
    }

    public void CarregarPorDataReader(IDataReader leitor)
    {
        _hashmd5 = AlterarTipo<string>(leitor["Hashmd5"]);
        _script = AlterarTipo<string>(leitor["Script"]);
        _tabela = AlterarTipo<string>(leitor["Tabela"]);
    }

}