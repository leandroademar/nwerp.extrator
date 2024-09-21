

////// namespace nwErp.Entidades.Caixa;

// namespace nwErp.Api.Modelos;

[Serializable]
public class PCMOVIMENTOPDV : GerenteDePropriedades, IEntidade
{
    private decimal? _codfuncabertura;

    private decimal? _codfuncfechamento;

    private DateTime? _dtabertura;

    private DateTime? _dtfechamento;

    private DateTime? _dtmovimento;

    private string _exportado;

    private decimal _numcaixa;

    private decimal _nummovimentopdv;

    private decimal? _qtvendas;

    private decimal? _qtcancelamento;

    private decimal? _vltotalvendas;

    private string _movimentoconsistente;

    private string _codfilial;

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVIMENTOPDV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfuncabertura
    {
        get
        {
            PropriedadeAcessada("Codfuncabertura");
            return _codfuncabertura;
        }
        set
        {
            PropriedadeModificada("Codfuncabertura", value);
            _codfuncabertura = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVIMENTOPDV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfuncfechamento
    {
        get
        {
            PropriedadeAcessada("Codfuncfechamento");
            return _codfuncfechamento;
        }
        set
        {
            PropriedadeModificada("Codfuncfechamento", value);
            _codfuncfechamento = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVIMENTOPDV", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVIMENTOPDV", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVIMENTOPDV", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtmovimento
    {
        get
        {
            PropriedadeAcessada("Dtmovimento");
            return _dtmovimento;
        }
        set
        {
            PropriedadeModificada("Dtmovimento", value);
            _dtmovimento = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVIMENTOPDV", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCMOVIMENTOPDV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal Numcaixa
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

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCMOVIMENTOPDV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal Nummovimentopdv
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVIMENTOPDV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Qtvendas
    {
        get
        {
            PropriedadeAcessada("Qtvendas");
            return _qtvendas;
        }
        set
        {
            PropriedadeModificada("Qtvendas", value);
            _qtvendas = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVIMENTOPDV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Qtcancelamento
    {
        get
        {
            PropriedadeAcessada("Qtcancelamento");
            return _qtcancelamento;
        }
        set
        {
            PropriedadeModificada("Qtcancelamento", value);
            _qtcancelamento = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVIMENTOPDV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 2)]
    public decimal? Vltotalvendas
    {
        get
        {
            PropriedadeAcessada("Vltotalvendas");
            return _vltotalvendas;
        }
        set
        {
            PropriedadeModificada("Vltotalvendas", value);
            _vltotalvendas = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVIMENTOPDV", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Movimentoconsistente
    {
        get
        {
            PropriedadeAcessada("Movimentoconsistente");
            return _movimentoconsistente;
        }
        set
        {
            PropriedadeModificada("Movimentoconsistente", value);
            _movimentoconsistente = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVIMENTOPDV", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 3, Precisao = 0)]
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

    public void InicializarAtributos()
    {
    }

    public string ObterNomeTabela()
    {
        return "PCMOVIMENTOPDV";
    }

    public IEntidade NovaInstancia()
    {
        return (IEntidade)GetType().GetConstructors()[0].Invoke(null);
    }

    public void CarregarPorDataReader(IDataReader leitor)
    {
        _codfuncabertura = AlterarTipo<decimal?>(leitor["Codfuncabertura"]);
        _codfuncfechamento = AlterarTipo<decimal?>(leitor["Codfuncfechamento"]);
        _dtabertura = AlterarTipo<DateTime?>(leitor["Dtabertura"]);
        _dtfechamento = AlterarTipo<DateTime?>(leitor["Dtfechamento"]);
        _dtmovimento = AlterarTipo<DateTime?>(leitor["Dtmovimento"]);
        _exportado = AlterarTipo<string>(leitor["Exportado"]);
        _numcaixa = AlterarTipo<decimal>(leitor["Numcaixa"]);
        _nummovimentopdv = AlterarTipo<decimal>(leitor["Nummovimentopdv"]);
        _qtvendas = AlterarTipo<decimal?>(leitor["Qtvendas"]);
        _qtcancelamento = AlterarTipo<decimal?>(leitor["Qtcancelamento"]);
        _vltotalvendas = AlterarTipo<decimal?>(leitor["Vltotalvendas"]);
        _movimentoconsistente = AlterarTipo<string>(leitor["Movimentoconsistente"]);
        _codfilial = AlterarTipo<string>(leitor["Codfilial"]);
    }

}