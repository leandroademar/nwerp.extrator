

////// namespace nwErp.Entidades.Winthor;

// namespace nwErp.Api.Modelos;

[Serializable]
public class PCLOGFATVAREJO : GerenteDePropriedades, IEntidade
{
    private string _arquivo;

    private DateTime? _data;

    private string _detalhes;

    private DateTime? _dtexclusao;

    private decimal? _numcaixa;

    private decimal? _numpedecf;

    private decimal _numlog;

    private string _tipo;

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOGFATVAREJO", Tipo = TipoDoCampoNoBancoDeDados.Binario, Tamanho = 4000, Precisao = 0)]
    public string Arquivo
    {
        get
        {
            PropriedadeAcessada("Arquivo");
            return _arquivo;
        }
        set
        {
            PropriedadeModificada("Arquivo", value);
            _arquivo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOGFATVAREJO", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0, TruncarData = true)]
    public DateTime? Data
    {
        get
        {
            PropriedadeAcessada("Data");
            return _data;
        }
        set
        {
            PropriedadeModificada("Data", value);
            _data = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOGFATVAREJO", Tipo = TipoDoCampoNoBancoDeDados.Binario, Tamanho = 4000, Precisao = 0)]
    public string Detalhes
    {
        get
        {
            PropriedadeAcessada("Detalhes");
            return _detalhes;
        }
        set
        {
            PropriedadeModificada("Detalhes", value);
            _detalhes = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOGFATVAREJO", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtexclusao
    {
        get
        {
            PropriedadeAcessada("Dtexclusao");
            return _dtexclusao;
        }
        set
        {
            PropriedadeModificada("Dtexclusao", value);
            _dtexclusao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOGFATVAREJO", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Numcaixa
    {
        get
        {
            PropriedadeAcessada("Numcaixa");
            return _numcaixa;
        }
        set
        {
            PropriedadeModificada("Numcaixa", value);
            _numcaixa = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOGFATVAREJO", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numpedecf
    {
        get
        {
            PropriedadeAcessada("Numpedecf");
            return _numpedecf;
        }
        set
        {
            PropriedadeModificada("Numpedecf", value);
            _numpedecf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCLOGFATVAREJO", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal Numlog
    {
        get
        {
            PropriedadeAcessada("Numlog");
            return _numlog;
        }
        set
        {
            PropriedadeModificada("Numlog", value);
            _numlog = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOGFATVAREJO", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
    public string Tipo
    {
        get
        {
            PropriedadeAcessada("Tipo");
            return _tipo;
        }
        set
        {
            PropriedadeModificada("Tipo", value);
            _tipo = value;
        }
    }

    public void InicializarAtributos()
    {
    }

    public string ObterNomeTabela()
    {
        return "PCLOGFATVAREJO";
    }

    public IEntidade NovaInstancia()
    {
        return (IEntidade)GetType().GetConstructors()[0].Invoke(null);
    }

    public void CarregarPorDataReader(IDataReader leitor)
    {
        _arquivo = AlterarTipo<string>(leitor["Arquivo"]);
        _data = AlterarTipo<DateTime?>(leitor["Data"]);
        _detalhes = AlterarTipo<string>(leitor["Detalhes"]);
        _dtexclusao = AlterarTipo<DateTime?>(leitor["Dtexclusao"]);
        _numcaixa = AlterarTipo<decimal?>(leitor["Numcaixa"]);
        _numpedecf = AlterarTipo<decimal?>(leitor["Numpedecf"]);
        _numlog = AlterarTipo<decimal>(leitor["Numlog"]);
        _tipo = AlterarTipo<string>(leitor["Tipo"]);
    }

}