

////// namespace nwErp.Entidades.Winthor;

// namespace nwErp.Api.Modelos;

[Serializable]
public class PCLOGMESA : GerenteDePropriedades, IEntidade
{
    private string _acao;

    private decimal? _codcli;

    private decimal? _codprod;

    private DateTime? _dtlog;

    private decimal? _matricula;

    private decimal? _numficha;

    private decimal? _numorca;

    private string _programa;

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOGMESA", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 500, Precisao = 0)]
    public string Acao
    {
        get
        {
            PropriedadeAcessada("Acao");
            return _acao;
        }
        set
        {
            PropriedadeModificada("Acao", value);
            _acao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOGMESA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codcli
    {
        get
        {
            PropriedadeAcessada("Codcli");
            return _codcli;
        }
        set
        {
            PropriedadeModificada("Codcli", value);
            _codcli = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOGMESA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Codprod
    {
        get
        {
            PropriedadeAcessada("Codprod");
            return _codprod;
        }
        set
        {
            PropriedadeModificada("Codprod", value);
            _codprod = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOGMESA", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtlog
    {
        get
        {
            PropriedadeAcessada("Dtlog");
            return _dtlog;
        }
        set
        {
            PropriedadeModificada("Dtlog", value);
            _dtlog = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOGMESA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Matricula
    {
        get
        {
            PropriedadeAcessada("Matricula");
            return _matricula;
        }
        set
        {
            PropriedadeModificada("Matricula", value);
            _matricula = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOGMESA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numficha
    {
        get
        {
            PropriedadeAcessada("Numficha");
            return _numficha;
        }
        set
        {
            PropriedadeModificada("Numficha", value);
            _numficha = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOGMESA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numorca
    {
        get
        {
            PropriedadeAcessada("Numorca");
            return _numorca;
        }
        set
        {
            PropriedadeModificada("Numorca", value);
            _numorca = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOGMESA", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 30, Precisao = 0)]
    public string Programa
    {
        get
        {
            PropriedadeAcessada("Programa");
            return _programa;
        }
        set
        {
            PropriedadeModificada("Programa", value);
            _programa = value;
        }
    }

    public void InicializarAtributos()
    {
    }

    public string ObterNomeTabela()
    {
        return "PCLOGMESA";
    }

    public IEntidade NovaInstancia()
    {
        return (IEntidade)GetType().GetConstructors()[0].Invoke(null);
    }

    public void CarregarPorDataReader(IDataReader leitor)
    {
        _acao = AlterarTipo<string>(leitor["Acao"]);
        _codcli = AlterarTipo<decimal?>(leitor["Codcli"]);
        _codprod = AlterarTipo<decimal?>(leitor["Codprod"]);
        _dtlog = AlterarTipo<DateTime?>(leitor["Dtlog"]);
        _matricula = AlterarTipo<decimal?>(leitor["Matricula"]);
        _numficha = AlterarTipo<decimal?>(leitor["Numficha"]);
        _numorca = AlterarTipo<decimal?>(leitor["Numorca"]);
        _programa = AlterarTipo<string>(leitor["Programa"]);
    }

}