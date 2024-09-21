

////// namespace nwErp.Entidades.Winthor;

// namespace nwErp.Api.Modelos;

[Serializable]
public class PCNFBASE : GerenteDePropriedades, IEntidade
{
    private static readonly string RO_ALIQUOTA = "Aliquota";

    private decimal _aliquota;

    private static readonly string RO_CODCONT = "Codcont";

    private decimal _codcont;

    private static readonly string RO_CODFISCAL = "Codfiscal";

    private decimal? _codfiscal;

    private static readonly string RO_DTEXPORTACAOSERVINT = "Dtexportacaoservint";

    private DateTime? _dtexportacaoservint;

    private static readonly string RO_DTIMPORTACAOSERVPRINC = "Dtimportacaoservprinc";

    private DateTime? _dtimportacaoservprinc;

    private static readonly string RO_EXPORTADOSERVINT = "Exportadoservint";

    private string _exportadoservint;

    private static readonly string RO_GERAICMSLIVROFISCAL = "Geraicmslivrofiscal";

    private string _geraicmslivrofiscal;

    private static readonly string RO_IMPORTADOSERVPRINC = "Importadoservprinc";

    private string _importadoservprinc;

    private static readonly string RO_NUMTRANSENT = "Numtransent";

    private decimal? _numtransent;

    private static readonly string RO_NUMTRANSVENDA = "Numtransvenda";

    private decimal? _numtransvenda;

    private static readonly string RO_PERCREDICMSCUSTO = "Percredicmscusto";

    private decimal? _percredicmscusto;

    private static readonly string RO_SITTRIBUT = "Sittribut";

    private string _sittribut;

    private static readonly string RO_TIPO = "Tipo";

    private string _tipo;

    private static readonly string RO_VLBASE = "Vlbase";

    private decimal _vlbase;

    private static readonly string RO_VLBASENF = "Vlbasenf";

    private decimal? _vlbasenf;

    private static readonly string RO_VLCONTABIL = "Vlcontabil";

    private decimal? _vlcontabil;

    private static readonly string RO_VLICMS = "Vlicms";

    private decimal _vlicms;

    private static readonly string RO_VLICMSDIFERIDO = "Vlicmsdiferido";

    private decimal? _vlicmsdiferido;

    private static readonly string RO_VLISENTAS = "Vlisentas";

    private decimal? _vlisentas;

    private static readonly string RO_VLMEXIVA = "Vlmexiva";

    private decimal? _vlmexiva;

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFBASE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 2)]
    public decimal Aliquota
    {
        get
        {
            PropriedadeAcessada(RO_ALIQUOTA);
            return _aliquota;
        }
        set
        {
            PropriedadeModificada(RO_ALIQUOTA, value);
            _aliquota = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFBASE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal Codcont
    {
        get
        {
            PropriedadeAcessada(RO_CODCONT);
            return _codcont;
        }
        set
        {
            PropriedadeModificada(RO_CODCONT, value);
            _codcont = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFBASE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfiscal
    {
        get
        {
            PropriedadeAcessada(RO_CODFISCAL);
            return _codfiscal;
        }
        set
        {
            PropriedadeModificada(RO_CODFISCAL, value);
            _codfiscal = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFBASE", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFBASE", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFBASE", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFBASE", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Geraicmslivrofiscal
    {
        get
        {
            PropriedadeAcessada(RO_GERAICMSLIVROFISCAL);
            return _geraicmslivrofiscal;
        }
        set
        {
            PropriedadeModificada(RO_GERAICMSLIVROFISCAL, value);
            _geraicmslivrofiscal = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFBASE", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFBASE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numtransent
    {
        get
        {
            PropriedadeAcessada(RO_NUMTRANSENT);
            return _numtransent;
        }
        set
        {
            PropriedadeModificada(RO_NUMTRANSENT, value);
            _numtransent = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFBASE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFBASE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 2)]
    public decimal? Percredicmscusto
    {
        get
        {
            PropriedadeAcessada(RO_PERCREDICMSCUSTO);
            return _percredicmscusto;
        }
        set
        {
            PropriedadeModificada(RO_PERCREDICMSCUSTO, value);
            _percredicmscusto = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFBASE", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 3, Precisao = 0)]
    public string Sittribut
    {
        get
        {
            PropriedadeAcessada(RO_SITTRIBUT);
            return _sittribut;
        }
        set
        {
            PropriedadeModificada(RO_SITTRIBUT, value);
            _sittribut = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFBASE", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFBASE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 2)]
    public decimal Vlbase
    {
        get
        {
            PropriedadeAcessada(RO_VLBASE);
            return _vlbase;
        }
        set
        {
            PropriedadeModificada(RO_VLBASE, value);
            _vlbase = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFBASE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 2)]
    public decimal? Vlbasenf
    {
        get
        {
            PropriedadeAcessada(RO_VLBASENF);
            return _vlbasenf;
        }
        set
        {
            PropriedadeModificada(RO_VLBASENF, value);
            _vlbasenf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFBASE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 2)]
    public decimal? Vlcontabil
    {
        get
        {
            PropriedadeAcessada(RO_VLCONTABIL);
            return _vlcontabil;
        }
        set
        {
            PropriedadeModificada(RO_VLCONTABIL, value);
            _vlcontabil = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFBASE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 2)]
    public decimal Vlicms
    {
        get
        {
            PropriedadeAcessada(RO_VLICMS);
            return _vlicms;
        }
        set
        {
            PropriedadeModificada(RO_VLICMS, value);
            _vlicms = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFBASE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlicmsdiferido
    {
        get
        {
            PropriedadeAcessada(RO_VLICMSDIFERIDO);
            return _vlicmsdiferido;
        }
        set
        {
            PropriedadeModificada(RO_VLICMSDIFERIDO, value);
            _vlicmsdiferido = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFBASE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 2)]
    public decimal? Vlisentas
    {
        get
        {
            PropriedadeAcessada(RO_VLISENTAS);
            return _vlisentas;
        }
        set
        {
            PropriedadeModificada(RO_VLISENTAS, value);
            _vlisentas = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFBASE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 2)]
    public decimal? Vlmexiva
    {
        get
        {
            PropriedadeAcessada(RO_VLMEXIVA);
            return _vlmexiva;
        }
        set
        {
            PropriedadeModificada(RO_VLMEXIVA, value);
            _vlmexiva = value;
        }
    }

    public void InicializarAtributos()
    {
    }

    public string ObterNomeTabela()
    {
        return "PCNFBASE";
    }

    public IEntidade NovaInstancia()
    {
        return (IEntidade)GetType().GetConstructors()[0].Invoke(null);
    }

    public void CarregarPorDataReader(IDataReader leitor)
    {
        _aliquota = AlterarTipo<decimal>(leitor["Aliquota"]);
        _codcont = AlterarTipo<decimal>(leitor["Codcont"]);
        _codfiscal = AlterarTipo<decimal?>(leitor["Codfiscal"]);
        _dtexportacaoservint = AlterarTipo<DateTime?>(leitor["Dtexportacaoservint"]);
        _dtimportacaoservprinc = AlterarTipo<DateTime?>(leitor["Dtimportacaoservprinc"]);
        _exportadoservint = AlterarTipo<string>(leitor["Exportadoservint"]);
        _geraicmslivrofiscal = AlterarTipo<string>(leitor["Geraicmslivrofiscal"]);
        _importadoservprinc = AlterarTipo<string>(leitor["Importadoservprinc"]);
        _numtransent = AlterarTipo<decimal?>(leitor["Numtransent"]);
        _numtransvenda = AlterarTipo<decimal?>(leitor["Numtransvenda"]);
        _percredicmscusto = AlterarTipo<decimal?>(leitor["Percredicmscusto"]);
        _sittribut = AlterarTipo<string>(leitor["Sittribut"]);
        _tipo = AlterarTipo<string>(leitor["Tipo"]);
        _vlbase = AlterarTipo<decimal>(leitor["Vlbase"]);
        _vlbasenf = AlterarTipo<decimal?>(leitor["Vlbasenf"]);
        _vlcontabil = AlterarTipo<decimal?>(leitor["Vlcontabil"]);
        _vlicms = AlterarTipo<decimal>(leitor["Vlicms"]);
        _vlicmsdiferido = AlterarTipo<decimal?>(leitor["Vlicmsdiferido"]);
        _vlisentas = AlterarTipo<decimal?>(leitor["Vlisentas"]);
        _vlmexiva = AlterarTipo<decimal?>(leitor["Vlmexiva"]);
    }

}