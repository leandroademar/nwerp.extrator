

////// namespace nwErp.Entidades.Caixa;

// namespace nwErp.Api.Modelos;

[Serializable]
public class PCDOCELETRONICOECF : GerenteDePropriedades, IEntidade
{
    private string _codfilial;

    private decimal? _codfunccx;

    private DateTime? _data;

    private string _exportado;

    private decimal? _numcaixa;

    private decimal? _numpedecf;

    private string _numserieequip;

    private string _xmlnfce;

    private static readonly string RO_NUMTRANSVENDA = "Numtransvenda";

    private decimal? _numtransvenda;

    private string _xmlnfcecancelamento;

    private DateTime? _dtexportacao;

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCDOCELETRONICOECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Codfilial
    {
        get
        {
            PropriedadeAcessada("Codfilial");
            return _codfilial;
        }
        set
        {
            PropriedadeModificada("Codfilial", value);
            _codfilial = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCDOCELETRONICOECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfunccx
    {
        get
        {
            PropriedadeAcessada("Codfunccx");
            return _codfunccx;
        }
        set
        {
            PropriedadeModificada("Codfunccx", value);
            _codfunccx = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCDOCELETRONICOECF", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCDOCELETRONICOECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Exportado
    {
        get
        {
            PropriedadeAcessada("Exportado");
            return _exportado;
        }
        set
        {
            PropriedadeModificada("Exportado", value);
            _exportado = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCDOCELETRONICOECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCDOCELETRONICOECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCDOCELETRONICOECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 30, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCDOCELETRONICOECF", Tipo = TipoDoCampoNoBancoDeDados.Binario, Tamanho = 8000, Precisao = 0)]
    public string Xmlnfce
    {
        get
        {
            PropriedadeAcessada("Xmlnfce");
            return _xmlnfce;
        }
        set
        {
            PropriedadeModificada("Xmlnfce", value);
            _xmlnfce = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCDOCELETRONICOECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCDOCELETRONICOECF", Tipo = TipoDoCampoNoBancoDeDados.Binario, Tamanho = 8000, Precisao = 0)]
    public string Xmlnfcecancelamento
    {
        get
        {
            PropriedadeAcessada("Xmlnfcecancelamento");
            return _xmlnfcecancelamento;
        }
        set
        {
            PropriedadeModificada("Xmlnfcecancelamento", value);
            _xmlnfcecancelamento = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCDOCELETRONICOECF", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtexportacao
    {
        get
        {
            PropriedadeAcessada("Dtexportacao");
            return _dtexportacao;
        }
        set
        {
            PropriedadeModificada("Dtexportacao", value);
            _dtexportacao = value;
        }
    }

    public void InicializarAtributos()
    {
    }

    public string ObterNomeTabela()
    {
        return "PCDOCELETRONICOECF";
    }

    public IEntidade NovaInstancia()
    {
        return (IEntidade)GetType().GetConstructors()[0].Invoke(null);
    }

    public void CarregarPorDataReader(IDataReader leitor)
    {
        _codfilial = AlterarTipo<string>(leitor["Codfilial"]);
        _codfunccx = AlterarTipo<decimal?>(leitor["Codfunccx"]);
        _data = AlterarTipo<DateTime?>(leitor["Data"]);
        _exportado = AlterarTipo<string>(leitor["Exportado"]);
        _numcaixa = AlterarTipo<decimal?>(leitor["Numcaixa"]);
        _numpedecf = AlterarTipo<decimal?>(leitor["Numpedecf"]);
        _numserieequip = AlterarTipo<string>(leitor["Numserieequip"]);
        _xmlnfce = AlterarTipo<string>(leitor["Xmlnfce"]);
        _numtransvenda = AlterarTipo<decimal?>(leitor["Numtransvenda"]);
        _xmlnfcecancelamento = AlterarTipo<string>(leitor["Xmlnfcecancelamento"]);
        _dtexportacao = AlterarTipo<DateTime?>(leitor["Dtexportacao"]);
    }

}