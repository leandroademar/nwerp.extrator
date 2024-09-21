

////// // namespace nwErp.Entidades.Winthor;

// // namespace nwErp.Api.Modelos;

[Serializable]
public class PCARQUIVOSFISCO : GerenteDePropriedades, IEntidade
{
    private string _arquivorespostaxml;

    private string _arquivoxml;

    private DateTime? _data;

    private DateTime? _dtfinal;

    private DateTime? _dtinicial;

    private decimal? _numcaixa;

    private string _numserieequip;

    private string _numserieplacamae;

    private string _pendente;

    private string _recibo;

    private string _tipoarquivo;

    private static readonly string RO_CODFILIAL = "Codfilial";

    private string _codfilial;

    private static readonly string TO_STATUSTRANSMISSAO = "Statustransmissao";

    private string _statustransmissao;

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCARQUIVOSFISCO", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 4000, Precisao = 0)]
    public string Arquivorespostaxml
    {
        get
        {
            PropriedadeAcessada("Arquivorespostaxml");
            return _arquivorespostaxml;
        }
        set
        {
            PropriedadeModificada("Arquivorespostaxml", value);
            _arquivorespostaxml = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCARQUIVOSFISCO", Tipo = TipoDoCampoNoBancoDeDados.Binario, Tamanho = 4000, Precisao = 0)]
    public string Arquivoxml
    {
        get
        {
            PropriedadeAcessada("Arquivoxml");
            return _arquivoxml;
        }
        set
        {
            PropriedadeModificada("Arquivoxml", value);
            _arquivoxml = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCARQUIVOSFISCO", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCARQUIVOSFISCO", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtfinal
    {
        get
        {
            PropriedadeAcessada("Dtfinal");
            return _dtfinal;
        }
        set
        {
            PropriedadeModificada("Dtfinal", value);
            _dtfinal = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCARQUIVOSFISCO", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtinicial
    {
        get
        {
            PropriedadeAcessada("Dtinicial");
            return _dtinicial;
        }
        set
        {
            PropriedadeModificada("Dtinicial", value);
            _dtinicial = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCARQUIVOSFISCO", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCARQUIVOSFISCO", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 30, Precisao = 0)]
    public string Numserieequip
    {
        get
        {
            PropriedadeAcessada("Numserieequip");
            return _numserieequip;
        }
        set
        {
            PropriedadeModificada("Numserieequip", value);
            _numserieequip = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCARQUIVOSFISCO", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 50, Precisao = 0)]
    public string Numserieplacamae
    {
        get
        {
            PropriedadeAcessada("Numserieplacamae");
            return _numserieplacamae;
        }
        set
        {
            PropriedadeModificada("Numserieplacamae", value);
            _numserieplacamae = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCARQUIVOSFISCO", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Pendente
    {
        get
        {
            PropriedadeAcessada("Pendente");
            return _pendente;
        }
        set
        {
            PropriedadeModificada("Pendente", value);
            _pendente = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCARQUIVOSFISCO", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 200, Precisao = 0)]
    public string Recibo
    {
        get
        {
            PropriedadeAcessada("Recibo");
            return _recibo;
        }
        set
        {
            PropriedadeModificada("Recibo", value);
            _recibo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCARQUIVOSFISCO", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Tipoarquivo
    {
        get
        {
            PropriedadeAcessada("Tipoarquivo");
            return _tipoarquivo;
        }
        set
        {
            PropriedadeModificada("Tipoarquivo", value);
            _tipoarquivo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCARQUIVOSFISCO", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCARQUIVOSFISCO", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Statustransmissao
    {
        get
        {
            PropriedadeAcessada(TO_STATUSTRANSMISSAO);
            return _statustransmissao;
        }
        set
        {
            PropriedadeModificada(TO_STATUSTRANSMISSAO, value);
            _statustransmissao = value;
        }
    }

    public void InicializarAtributos()
    {
    }

    public string ObterNomeTabela()
    {
        return "PCARQUIVOSFISCO";
    }

    public IEntidade NovaInstancia()
    {
        return (IEntidade)GetType().GetConstructors()[0].Invoke(null);
    }

    public void CarregarPorDataReader(IDataReader leitor)
    {
        _arquivorespostaxml = AlterarTipo<string>(leitor["Arquivorespostaxml"]);
        _arquivoxml = AlterarTipo<string>(leitor["Arquivoxml"]);
        _data = AlterarTipo<DateTime?>(leitor["Data"]);
        _dtfinal = AlterarTipo<DateTime?>(leitor["Dtfinal"]);
        _dtinicial = AlterarTipo<DateTime?>(leitor["Dtinicial"]);
        _numcaixa = AlterarTipo<decimal?>(leitor["Numcaixa"]);
        _numserieequip = AlterarTipo<string>(leitor["Numserieequip"]);
        _numserieplacamae = AlterarTipo<string>(leitor["Numserieplacamae"]);
        _pendente = AlterarTipo<string>(leitor["Pendente"]);
        _recibo = AlterarTipo<string>(leitor["Recibo"]);
        _tipoarquivo = AlterarTipo<string>(leitor["Tipoarquivo"]);
        _codfilial = AlterarTipo<string>(leitor["Codfilial"]);
        _statustransmissao = AlterarTipo<string>(leitor["Statustransmissao"]);
    }

}