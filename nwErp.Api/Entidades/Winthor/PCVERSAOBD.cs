

////// namespace nwErp.Entidades.Winthor;

// namespace nwErp.Api.Modelos;

[Serializable]
public class PCVERSAOBD : GerenteDePropriedades, IEntidade
{
    private static readonly string RO_ROTINA = "Rotina";

    private string _rotina;

    private static readonly string RO_OPCAO = "Opcao";

    private decimal? _opcao;

    private static readonly string RO_VERSAO = "Versao";

    private string _versao;

    private static readonly string RO_DESCRICAO = "Descricao";

    private string _descricao;

    private static readonly string RO_DTSINCRONIZACAO = "Dtsincronizacao";

    private DateTime? _dtsincronizacao;

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCVERSAOBD", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
    public string Rotina
    {
        get
        {
            PropriedadeAcessada(RO_ROTINA);
            return _rotina;
        }
        set
        {
            PropriedadeModificada(RO_ROTINA, value);
            _rotina = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCVERSAOBD", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Opcao
    {
        get
        {
            PropriedadeAcessada(RO_OPCAO);
            return _opcao;
        }
        set
        {
            PropriedadeModificada(RO_OPCAO, value);
            _opcao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCVERSAOBD", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 15, Precisao = 0)]
    public string Versao
    {
        get
        {
            PropriedadeAcessada(RO_VERSAO);
            return _versao;
        }
        set
        {
            PropriedadeModificada(RO_VERSAO, value);
            _versao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCVERSAOBD", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 150, Precisao = 0)]
    public string Descricao
    {
        get
        {
            PropriedadeAcessada(RO_DESCRICAO);
            return _descricao;
        }
        set
        {
            PropriedadeModificada(RO_DESCRICAO, value);
            _descricao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCVERSAOBD", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtsincronizacao
    {
        get
        {
            PropriedadeAcessada(RO_DTSINCRONIZACAO);
            return _dtsincronizacao;
        }
        set
        {
            PropriedadeModificada(RO_DTSINCRONIZACAO, value);
            _dtsincronizacao = value;
        }
    }

    public void InicializarAtributos()
    {
    }

    public string ObterNomeTabela()
    {
        return "PCVERSAOBD";
    }

    public IEntidade NovaInstancia()
    {
        return (IEntidade)GetType().GetConstructors()[0].Invoke(null);
    }

    public void CarregarPorDataReader(IDataReader leitor)
    {
        _rotina = AlterarTipo<string>(leitor["Rotina"]);
        _opcao = AlterarTipo<decimal?>(leitor["Opcao"]);
        _versao = AlterarTipo<string>(leitor["Versao"]);
        _descricao = AlterarTipo<string>(leitor["Descricao"]);
        _dtsincronizacao = AlterarTipo<DateTime?>(leitor["Dtsincronizacao"]);
    }

}