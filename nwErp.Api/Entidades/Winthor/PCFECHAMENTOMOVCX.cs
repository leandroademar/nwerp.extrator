

////// namespace nwErp.Entidades.Caixa;

// namespace nwErp.Api.Modelos;

[Serializable]
public class PCFECHAMENTOMOVCX : GerenteDePropriedades, IEntidade
{
    private string _codfilial;

    private static readonly string RO_EXPORTADO = "Exportado";

    private string _exportado;

    private decimal? _codfunccx;

    private DateTime? _dtabertura;

    private DateTime? _dtfechamento;

    private DateTime? _dtmovimentocx;

    private decimal? _horaabertura;

    private decimal? _horafechamento;

    private decimal? _minutoabertura;

    private decimal? _minutofechamento;

    private decimal? _numcaixa;

    private decimal? _numfechamentomovcx;

    private decimal? _nummovimentopdv;

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCFECHAMENTOMOVCX", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFECHAMENTOMOVCX", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Exportado
    {
        get
        {
            PropriedadeAcessada(RO_EXPORTADO);
            return _exportado;
        }
        set
        {
            PropriedadeModificada(RO_EXPORTADO, value);
            _exportado = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCFECHAMENTOMOVCX", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFECHAMENTOMOVCX", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtabertura
    {
        get
        {
            PropriedadeAcessada("Dtabertura");
            return _dtabertura;
        }
        set
        {
            PropriedadeModificada("Dtabertura", value);
            _dtabertura = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFECHAMENTOMOVCX", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtfechamento
    {
        get
        {
            PropriedadeAcessada("Dtfechamento");
            return _dtfechamento;
        }
        set
        {
            PropriedadeModificada("Dtfechamento", value);
            _dtfechamento = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFECHAMENTOMOVCX", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtmovimentocx
    {
        get
        {
            PropriedadeAcessada("Dtmovimentocx");
            return _dtmovimentocx;
        }
        set
        {
            PropriedadeModificada("Dtmovimentocx", value);
            _dtmovimentocx = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFECHAMENTOMOVCX", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 2, Precisao = 0)]
    public decimal? Horaabertura
    {
        get
        {
            PropriedadeAcessada("Horaabertura");
            return _horaabertura;
        }
        set
        {
            PropriedadeModificada("Horaabertura", value);
            _horaabertura = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFECHAMENTOMOVCX", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 2, Precisao = 0)]
    public decimal? Horafechamento
    {
        get
        {
            PropriedadeAcessada("Horafechamento");
            return _horafechamento;
        }
        set
        {
            PropriedadeModificada("Horafechamento", value);
            _horafechamento = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFECHAMENTOMOVCX", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 2, Precisao = 0)]
    public decimal? Minutoabertura
    {
        get
        {
            PropriedadeAcessada("Minutoabertura");
            return _minutoabertura;
        }
        set
        {
            PropriedadeModificada("Minutoabertura", value);
            _minutoabertura = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFECHAMENTOMOVCX", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 2, Precisao = 0)]
    public decimal? Minutofechamento
    {
        get
        {
            PropriedadeAcessada("Minutofechamento");
            return _minutofechamento;
        }
        set
        {
            PropriedadeModificada("Minutofechamento", value);
            _minutofechamento = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCFECHAMENTOMOVCX", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCFECHAMENTOMOVCX", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numfechamentomovcx
    {
        get
        {
            PropriedadeAcessada("Numfechamentomovcx");
            return _numfechamentomovcx;
        }
        set
        {
            PropriedadeModificada("Numfechamentomovcx", value);
            _numfechamentomovcx = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCFECHAMENTOMOVCX", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Nummovimentopdv
    {
        get
        {
            PropriedadeAcessada("Nummovimentopdv");
            return _nummovimentopdv;
        }
        set
        {
            PropriedadeModificada("Nummovimentopdv", value);
            _nummovimentopdv = value;
        }
    }

    public void InicializarAtributos()
    {
    }

    public string ObterNomeTabela()
    {
        return "PCFECHAMENTOMOVCX";
    }

    public IEntidade NovaInstancia()
    {
        return (IEntidade)GetType().GetConstructors()[0].Invoke(null);
    }

    public void CarregarPorDataReader(IDataReader leitor)
    {
        _codfilial = AlterarTipo<string>(leitor["Codfilial"]);
        _exportado = AlterarTipo<string>(leitor["Exportado"]);
        _codfunccx = AlterarTipo<decimal?>(leitor["Codfunccx"]);
        _dtabertura = AlterarTipo<DateTime?>(leitor["Dtabertura"]);
        _dtfechamento = AlterarTipo<DateTime?>(leitor["Dtfechamento"]);
        _dtmovimentocx = AlterarTipo<DateTime?>(leitor["Dtmovimentocx"]);
        _horaabertura = AlterarTipo<decimal?>(leitor["Horaabertura"]);
        _horafechamento = AlterarTipo<decimal?>(leitor["Horafechamento"]);
        _minutoabertura = AlterarTipo<decimal?>(leitor["Minutoabertura"]);
        _minutofechamento = AlterarTipo<decimal?>(leitor["Minutofechamento"]);
        _numcaixa = AlterarTipo<decimal?>(leitor["Numcaixa"]);
        _numfechamentomovcx = AlterarTipo<decimal?>(leitor["Numfechamentomovcx"]);
        _nummovimentopdv = AlterarTipo<decimal?>(leitor["Nummovimentopdv"]);
    }

}