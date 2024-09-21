

////// namespace nwErp.Entidades.Winthor;

// namespace nwErp.Api.Modelos;

[Serializable]
public class PCVALECX : GerenteDePropriedades, IEntidade
{
    private static readonly string RO_CODBANCO = "Codbanco";

    private decimal? _codbanco;

    private static readonly string RO_CODCOB = "Codcob";

    private string _codcob;

    private static readonly string RO_CODCRECLI = "Codcrecli";

    private decimal? _codcrecli;

    private static readonly string RO_CODFUNC = "Codfunc";

    private decimal? _codfunc;

    private static readonly string RO_CODFUNCFECHA = "Codfuncfecha";

    private decimal? _codfuncfecha;

    private static readonly string RO_DTEXPORTACAOSERVINT = "Dtexportacaoservint";

    private DateTime? _dtexportacaoservint;

    private static readonly string RO_DTFECHA = "Dtfecha";

    private DateTime? _dtfecha;

    private static readonly string RO_DTIMPORTACAOSERVPRINC = "Dtimportacaoservprinc";

    private DateTime? _dtimportacaoservprinc;

    private static readonly string RO_DTLANC = "Dtlanc";

    private DateTime? _dtlanc;

    private static readonly string RO_EXPORTADOSERVINT = "Exportadoservint";

    private string _exportadoservint;

    private static readonly string RO_HISTORICO = "Historico";

    private string _historico;

    private static readonly string RO_HORALANC = "Horalanc";

    private decimal? _horalanc;

    private static readonly string RO_IMPORTADOSERVPRINC = "Importadoservprinc";

    private string _importadoservprinc;

    private static readonly string RO_MINUTOLANC = "Minutolanc";

    private decimal? _minutolanc;

    private static readonly string RO_NUMCX = "Numcx";

    private decimal? _numcx;

    private static readonly string RO_NUMSERIEEQUIP = "Numserieequip";

    private string _numserieequip;

    private static readonly string RO_NUMVALE = "Numvale";

    private decimal _numvale;

    private static readonly string RO_NUMVALEECF = "Numvaleecf";

    private decimal? _numvaleecf;

    private static readonly string RO_NUMVALEINTERMEDIARIO = "Numvaleintermediario";

    private decimal? _numvaleintermediario;

    private static readonly string RO_TIPO = "Tipo";

    private string _tipo;

    private static readonly string RO_TIPOSANGRIA = "Tiposangria";

    private string _tiposangria;

    private static readonly string RO_VALOR = "Valor";

    private decimal? _valor;

    private static readonly string RO_NUMFECHAMENTOMOVCX = "Numfechamentomovcx";

    private decimal? _numfechamentomovcx;

    private static readonly string RO_DTMOVIMENTOCX = "Dtmovimentocx";

    private DateTime? _dtmovimentocx;

    private static readonly string RO_CODUSURAUTORI = "Codusurautori";

    private decimal? _codusurautori;

    private static readonly string RO_NUMMALOTE = "Nummalote";

    private string _nummalote;

    private static readonly string RO_NUMLACRE = "Numlacre";

    private string _numlacre;

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCVALECX", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Codbanco
    {
        get
        {
            PropriedadeAcessada(RO_CODBANCO);
            return _codbanco;
        }
        set
        {
            PropriedadeModificada(RO_CODBANCO, value);
            _codbanco = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCVALECX", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCVALECX", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codcrecli
    {
        get
        {
            PropriedadeAcessada(RO_CODCRECLI);
            return _codcrecli;
        }
        set
        {
            PropriedadeModificada(RO_CODCRECLI, value);
            _codcrecli = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCVALECX", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfunc
    {
        get
        {
            PropriedadeAcessada(RO_CODFUNC);
            return _codfunc;
        }
        set
        {
            PropriedadeModificada(RO_CODFUNC, value);
            _codfunc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCVALECX", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfuncfecha
    {
        get
        {
            PropriedadeAcessada(RO_CODFUNCFECHA);
            return _codfuncfecha;
        }
        set
        {
            PropriedadeModificada(RO_CODFUNCFECHA, value);
            _codfuncfecha = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCVALECX", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtexportacaoservint
    {
        get
        {
            PropriedadeAcessada(RO_DTEXPORTACAOSERVINT);
            return _dtexportacaoservint;
        }
        set
        {
            PropriedadeModificada(RO_DTEXPORTACAOSERVINT, value);
            _dtexportacaoservint = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCVALECX", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtfecha
    {
        get
        {
            PropriedadeAcessada(RO_DTFECHA);
            return _dtfecha;
        }
        set
        {
            PropriedadeModificada(RO_DTFECHA, value);
            _dtfecha = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCVALECX", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtimportacaoservprinc
    {
        get
        {
            PropriedadeAcessada(RO_DTIMPORTACAOSERVPRINC);
            return _dtimportacaoservprinc;
        }
        set
        {
            PropriedadeModificada(RO_DTIMPORTACAOSERVPRINC, value);
            _dtimportacaoservprinc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCVALECX", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtlanc
    {
        get
        {
            PropriedadeAcessada(RO_DTLANC);
            return _dtlanc;
        }
        set
        {
            PropriedadeModificada(RO_DTLANC, value);
            _dtlanc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCVALECX", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Exportadoservint
    {
        get
        {
            PropriedadeAcessada(RO_EXPORTADOSERVINT);
            return _exportadoservint;
        }
        set
        {
            PropriedadeModificada(RO_EXPORTADOSERVINT, value);
            _exportadoservint = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCVALECX", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 200, Precisao = 0)]
    public string Historico
    {
        get
        {
            PropriedadeAcessada(RO_HISTORICO);
            return _historico;
        }
        set
        {
            PropriedadeModificada(RO_HISTORICO, value);
            _historico = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCVALECX", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 2, Precisao = 0)]
    public decimal? Horalanc
    {
        get
        {
            PropriedadeAcessada(RO_HORALANC);
            return _horalanc;
        }
        set
        {
            PropriedadeModificada(RO_HORALANC, value);
            _horalanc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCVALECX", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Importadoservprinc
    {
        get
        {
            PropriedadeAcessada(RO_IMPORTADOSERVPRINC);
            return _importadoservprinc;
        }
        set
        {
            PropriedadeModificada(RO_IMPORTADOSERVPRINC, value);
            _importadoservprinc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCVALECX", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 2, Precisao = 0)]
    public decimal? Minutolanc
    {
        get
        {
            PropriedadeAcessada(RO_MINUTOLANC);
            return _minutolanc;
        }
        set
        {
            PropriedadeModificada(RO_MINUTOLANC, value);
            _minutolanc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCVALECX", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Numcx
    {
        get
        {
            PropriedadeAcessada(RO_NUMCX);
            return _numcx;
        }
        set
        {
            PropriedadeModificada(RO_NUMCX, value);
            _numcx = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCVALECX", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 30, Precisao = 0)]
    public string Numserieequip
    {
        get
        {
            PropriedadeAcessada(RO_NUMSERIEEQUIP);
            return _numserieequip;
        }
        set
        {
            PropriedadeModificada(RO_NUMSERIEEQUIP, value);
            _numserieequip = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCVALECX", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal Numvale
    {
        get
        {
            PropriedadeAcessada(RO_NUMVALE);
            return _numvale;
        }
        set
        {
            PropriedadeModificada(RO_NUMVALE, value);
            _numvale = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCVALECX", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numvaleecf
    {
        get
        {
            PropriedadeAcessada(RO_NUMVALEECF);
            return _numvaleecf;
        }
        set
        {
            PropriedadeModificada(RO_NUMVALEECF, value);
            _numvaleecf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCVALECX", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numvaleintermediario
    {
        get
        {
            PropriedadeAcessada(RO_NUMVALEINTERMEDIARIO);
            return _numvaleintermediario;
        }
        set
        {
            PropriedadeModificada(RO_NUMVALEINTERMEDIARIO, value);
            _numvaleintermediario = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCVALECX", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Tipo
    {
        get
        {
            PropriedadeAcessada(RO_TIPO);
            return _tipo;
        }
        set
        {
            PropriedadeModificada(RO_TIPO, value);
            _tipo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCVALECX", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Tiposangria
    {
        get
        {
            PropriedadeAcessada(RO_TIPOSANGRIA);
            return _tiposangria;
        }
        set
        {
            PropriedadeModificada(RO_TIPOSANGRIA, value);
            _tiposangria = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCVALECX", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 2)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCVALECX", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCVALECX", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCVALECX", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 13, Precisao = 0)]
    public decimal? Codusurautori
    {
        get
        {
            PropriedadeAcessada("Codusurautori");
            return _codusurautori;
        }
        set
        {
            PropriedadeModificada("Codusurautori", value);
            _codusurautori = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCVALECX", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
    public string Nummalote
    {
        get
        {
            PropriedadeAcessada(RO_NUMMALOTE);
            return _nummalote;
        }
        set
        {
            PropriedadeModificada(RO_NUMMALOTE, value);
            _nummalote = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCVALECX", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
    public string Numlacre
    {
        get
        {
            PropriedadeAcessada(RO_NUMLACRE);
            return _numlacre;
        }
        set
        {
            PropriedadeModificada(RO_NUMLACRE, value);
            _numlacre = value;
        }
    }

    public void InicializarAtributos()
    {
    }

    public string ObterNomeTabela()
    {
        return "PCVALECX";
    }

    public IEntidade NovaInstancia()
    {
        return (IEntidade)GetType().GetConstructors()[0].Invoke(null);
    }

    public void CarregarPorDataReader(IDataReader leitor)
    {
        _codbanco = AlterarTipo<decimal?>(leitor["Codbanco"]);
        _codcob = AlterarTipo<string>(leitor["Codcob"]);
        _codcrecli = AlterarTipo<decimal?>(leitor["Codcrecli"]);
        _codfunc = AlterarTipo<decimal?>(leitor["Codfunc"]);
        _codfuncfecha = AlterarTipo<decimal?>(leitor["Codfuncfecha"]);
        _dtexportacaoservint = AlterarTipo<DateTime?>(leitor["Dtexportacaoservint"]);
        _dtfecha = AlterarTipo<DateTime?>(leitor["Dtfecha"]);
        _dtimportacaoservprinc = AlterarTipo<DateTime?>(leitor["Dtimportacaoservprinc"]);
        _dtlanc = AlterarTipo<DateTime?>(leitor["Dtlanc"]);
        _exportadoservint = AlterarTipo<string>(leitor["Exportadoservint"]);
        _historico = AlterarTipo<string>(leitor["Historico"]);
        _horalanc = AlterarTipo<decimal?>(leitor["Horalanc"]);
        _importadoservprinc = AlterarTipo<string>(leitor["Importadoservprinc"]);
        _minutolanc = AlterarTipo<decimal?>(leitor["Minutolanc"]);
        _numcx = AlterarTipo<decimal?>(leitor["Numcx"]);
        _numserieequip = AlterarTipo<string>(leitor["Numserieequip"]);
        _numvale = AlterarTipo<decimal>(leitor["Numvale"]);
        _numvaleecf = AlterarTipo<decimal?>(leitor["Numvaleecf"]);
        _numvaleintermediario = AlterarTipo<decimal?>(leitor["Numvaleintermediario"]);
        _tipo = AlterarTipo<string>(leitor["Tipo"]);
        _tiposangria = AlterarTipo<string>(leitor["Tiposangria"]);
        _valor = AlterarTipo<decimal?>(leitor["Valor"]);
        _numfechamentomovcx = AlterarTipo<decimal?>(leitor["Numfechamentomovcx"]);
        _dtmovimentocx = AlterarTipo<DateTime?>(leitor["Dtmovimentocx"]);
        _codusurautori = AlterarTipo<decimal?>(leitor["Codusurautori"]);
        _nummalote = AlterarTipo<string>(leitor["Nummalote"]);
        _numlacre = AlterarTipo<string>(leitor["Numlacre"]);
    }

}