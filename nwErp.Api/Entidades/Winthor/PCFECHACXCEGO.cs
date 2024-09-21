

////// namespace nwErp.Entidades.Caixa;

// namespace nwErp.Api.Modelos;

[Serializable]
public class PCFECHACXCEGO : GerenteDePropriedades, IEntidade
{
    private static readonly string RO_CODCOB = "Codcob";

    private string _codcob;

    private static readonly string RO_CODFUNCCX = "Codfunccx";

    private decimal _codfunccx;

    private static readonly string RO_DATA = "Data";

    private DateTime _data;

    private static readonly string RO_DTEXPORTACAO = "Dtexportacao";

    private DateTime? _dtexportacao;

    private static readonly string RO_EXPORTADO = "Exportado";

    private string _exportado;

    private static readonly string RO_NUMCAIXA = "Numcaixa";

    private decimal _numcaixa;

    private static readonly string RO_VALOR = "Valor";

    private decimal? _valor;

    private static readonly string RO_NUMFECHAMENTOMOVCX = "Numfechamentomovcx";

    private decimal? _numfechamentomovcx;

    private static readonly string RO_DTMOVIMENTOCX = "Dtmovimentocx";

    private DateTime? _dtmovimentocx;

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCFECHACXCEGO", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 4, Precisao = 0)]
    public string Codcob
    {
        get
        {
            PropriedadeAcessada(RO_CODCOB);
            return _codcob;
        }
        set
        {
            PropriedadeModificada(RO_CODCOB, value);
            _codcob = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCFECHACXCEGO", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal Codfunccx
    {
        get
        {
            PropriedadeAcessada(RO_CODFUNCCX);
            return _codfunccx;
        }
        set
        {
            PropriedadeModificada(RO_CODFUNCCX, value);
            _codfunccx = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCFECHACXCEGO", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFECHACXCEGO", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtexportacao
    {
        get
        {
            PropriedadeAcessada(RO_DTEXPORTACAO);
            return _dtexportacao;
        }
        set
        {
            PropriedadeModificada(RO_DTEXPORTACAO, value);
            _dtexportacao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFECHACXCEGO", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCFECHACXCEGO", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal Numcaixa
    {
        get
        {
            PropriedadeAcessada(RO_NUMCAIXA);
            return _numcaixa;
        }
        set
        {
            PropriedadeModificada(RO_NUMCAIXA, value);
            _numcaixa = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFECHACXCEGO", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 16, Precisao = 3)]
    public decimal? Valor
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFECHACXCEGO", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCFECHACXCEGO", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
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

    public void InicializarAtributos()
    {
    }

    public string ObterNomeTabela()
    {
        return "PCFECHACXCEGO";
    }

    public IEntidade NovaInstancia()
    {
        return (IEntidade)GetType().GetConstructors()[0].Invoke(null);
    }

    public void CarregarPorDataReader(IDataReader leitor)
    {
        _codcob = AlterarTipo<string>(leitor["Codcob"]);
        _codfunccx = AlterarTipo<decimal>(leitor["Codfunccx"]);
        _data = AlterarTipo<DateTime>(leitor["Data"]);
        _dtexportacao = AlterarTipo<DateTime?>(leitor["Dtexportacao"]);
        _exportado = AlterarTipo<string>(leitor["Exportado"]);
        _numcaixa = AlterarTipo<decimal>(leitor["Numcaixa"]);
        _valor = AlterarTipo<decimal?>(leitor["Valor"]);
        _numfechamentomovcx = AlterarTipo<decimal?>(leitor["Numfechamentomovcx"]);
        _dtmovimentocx = AlterarTipo<DateTime?>(leitor["Dtmovimentocx"]);
    }

}