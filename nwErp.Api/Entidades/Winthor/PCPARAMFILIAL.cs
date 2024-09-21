

////// namespace nwErp.Entidades.Winthor;

// namespace nwErp.Api.Modelos;

[Serializable]
public class PCPARAMFILIAL : GerenteDePropriedades, IEntidade
{
    private static readonly string RO_CODFILIAL = "Codfilial";

    private string _codfilial;

    private static readonly string RO_NOME = "Nome";

    private string _nome;

    private static readonly string RO_VALOR = "Valor";

    private string _valor;

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCPARAMFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCPARAMFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 34, Precisao = 0)]
    public string Nome
    {
        get
        {
            PropriedadeAcessada(RO_NOME);
            return _nome;
        }
        set
        {
            PropriedadeModificada(RO_NOME, value);
            _nome = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPARAMFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1000, Precisao = 0)]
    public string Valor
    {
        get
        {
            PropriedadeAcessada(RO_VALOR);
            return _valor;
        }
        set
        {
            PropriedadeModificada(RO_VALOR, value);
            _valor = value;
        }
    }

    public void InicializarAtributos()
    {
    }

    public string ObterNomeTabela()
    {
        return "PCPARAMFILIAL";
    }

    public IEntidade NovaInstancia()
    {
        return (IEntidade)GetType().GetConstructors()[0].Invoke(null);
    }

    public void CarregarPorDataReader(IDataReader leitor)
    {
        _codfilial = AlterarTipo<string>(leitor["Codfilial"]);
        _nome = AlterarTipo<string>(leitor["Nome"]);
        _valor = AlterarTipo<string>(leitor["Valor"]);
    }

}