

////// namespace nwErp.Entidades.Caixa;

// namespace nwErp.Api.Modelos;

[Serializable]
public class PCLOGABERTURACX : GerenteDePropriedades, IEntidade
{
    private static readonly string RO_CODFUNCCXANT = "Codfunccxant";

    private decimal? _codfunccxant;

    private static readonly string RO_CODFUNCCXATUAL = "Codfunccxatual";

    private decimal? _codfunccxatual;

    private static readonly string RO_CODFUNCFISCALCX = "Codfuncfiscalcx";

    private decimal? _codfuncfiscalcx;

    private static readonly string RO_DTABERTURA = "Dtabertura";

    private DateTime? _dtabertura;

    private static readonly string RO_DTEXPORTACAO = "Dtexportacao";

    private DateTime? _dtexportacao;

    private static readonly string RO_EXPORTADO = "Exportado";

    private string _exportado;

    private static readonly string RO_NUMCAIXA = "Numcaixa";

    private decimal? _numcaixa;

    private static readonly string RO_POSICAOANT = "Posicaoant";

    private string _posicaoant;

    private static readonly string RO_POSICAOATUAL = "Posicaoatual";

    private string _posicaoatual;

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOGABERTURACX", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfunccxant
    {
        get
        {
            PropriedadeAcessada(RO_CODFUNCCXANT);
            return _codfunccxant;
        }
        set
        {
            PropriedadeModificada(RO_CODFUNCCXANT, value);
            _codfunccxant = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOGABERTURACX", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfunccxatual
    {
        get
        {
            PropriedadeAcessada(RO_CODFUNCCXATUAL);
            return _codfunccxatual;
        }
        set
        {
            PropriedadeModificada(RO_CODFUNCCXATUAL, value);
            _codfunccxatual = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOGABERTURACX", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfuncfiscalcx
    {
        get
        {
            PropriedadeAcessada(RO_CODFUNCFISCALCX);
            return _codfuncfiscalcx;
        }
        set
        {
            PropriedadeModificada(RO_CODFUNCFISCALCX, value);
            _codfuncfiscalcx = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOGABERTURACX", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtabertura
    {
        get
        {
            PropriedadeAcessada(RO_DTABERTURA);
            return _dtabertura;
        }
        set
        {
            PropriedadeModificada(RO_DTABERTURA, value);
            _dtabertura = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOGABERTURACX", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOGABERTURACX", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOGABERTURACX", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Numcaixa
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOGABERTURACX", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Posicaoant
    {
        get
        {
            PropriedadeAcessada(RO_POSICAOANT);
            return _posicaoant;
        }
        set
        {
            PropriedadeModificada(RO_POSICAOANT, value);
            _posicaoant = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOGABERTURACX", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Posicaoatual
    {
        get
        {
            PropriedadeAcessada(RO_POSICAOATUAL);
            return _posicaoatual;
        }
        set
        {
            PropriedadeModificada(RO_POSICAOATUAL, value);
            _posicaoatual = value;
        }
    }

    public void InicializarAtributos()
    {
    }

    public string ObterNomeTabela()
    {
        return "PCLOGABERTURACX";
    }

    public IEntidade NovaInstancia()
    {
        return (IEntidade)GetType().GetConstructors()[0].Invoke(null);
    }

    public void CarregarPorDataReader(IDataReader leitor)
    {
        _codfunccxant = AlterarTipo<decimal?>(leitor["Codfunccxant"]);
        _codfunccxatual = AlterarTipo<decimal?>(leitor["Codfunccxatual"]);
        _codfuncfiscalcx = AlterarTipo<decimal?>(leitor["Codfuncfiscalcx"]);
        _dtabertura = AlterarTipo<DateTime?>(leitor["Dtabertura"]);
        _dtexportacao = AlterarTipo<DateTime?>(leitor["Dtexportacao"]);
        _exportado = AlterarTipo<string>(leitor["Exportado"]);
        _numcaixa = AlterarTipo<decimal?>(leitor["Numcaixa"]);
        _posicaoant = AlterarTipo<string>(leitor["Posicaoant"]);
        _posicaoatual = AlterarTipo<string>(leitor["Posicaoatual"]);
    }

}