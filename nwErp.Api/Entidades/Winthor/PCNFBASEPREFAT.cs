

////// // namespace nwErp.Entidades.Winthor;

// // namespace nwErp.Api.Modelos;

[Serializable]
public class PCNFBASEPREFAT : GerenteDePropriedades, IEntidade
{
    private decimal? _aliqfcp;

    private decimal? _aliqinternadest;

    private decimal? _aliqinterorigpart;

    private decimal _aliquota;

    private decimal _codcont;

    private decimal? _codfiscal;

    private DateTime? _dataconsolidacaoprefat;

    private DateTime? _dtexportacaoservint;

    private DateTime? _dtimportacaoservprinc;

    private string _exportadoservint;

    private string _geraicmslivrofiscal;

    private string _importadoservprinc;

    private decimal? _numtransent;

    private decimal? _numtranspiscofins;

    private decimal? _numtransvenda;

    private decimal? _percbaseredpart;

    private decimal? _perciss;

    private decimal? _percprovpart;

    private decimal? _percredcims;

    private decimal? _percredicmscusto;

    private string _sittribut;

    private string _sittributipi;

    private string _tipo;

    private decimal _vlbase;

    private decimal? _vlbasenf;

    private decimal? _vlbasepartdest;

    private decimal? _vlcontabil;

    private decimal? _vlfcppart;

    private decimal _vlicms;

    private decimal? _vlicmsdifaliqpart;

    private decimal? _vlicmsdiferido;

    private decimal? _vlicmspart;

    private decimal? _vlicmspartdest;

    private decimal? _vlicmspartrem;

    private decimal? _vlisentas;

    private decimal? _vlmexiva;

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFBASEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 2)]
    public decimal? Aliqfcp
    {
        get
        {
            PropriedadeAcessada("Aliqfcp");
            return _aliqfcp;
        }
        set
        {
            PropriedadeModificada("Aliqfcp", value);
            _aliqfcp = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFBASEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 2)]
    public decimal? Aliqinternadest
    {
        get
        {
            PropriedadeAcessada("Aliqinternadest");
            return _aliqinternadest;
        }
        set
        {
            PropriedadeModificada("Aliqinternadest", value);
            _aliqinternadest = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFBASEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Aliqinterorigpart
    {
        get
        {
            PropriedadeAcessada("Aliqinterorigpart");
            return _aliqinterorigpart;
        }
        set
        {
            PropriedadeModificada("Aliqinterorigpart", value);
            _aliqinterorigpart = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFBASEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 2)]
    public decimal Aliquota
    {
        get
        {
            PropriedadeAcessada("Aliquota");
            return _aliquota;
        }
        set
        {
            PropriedadeModificada("Aliquota", value);
            _aliquota = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFBASEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal Codcont
    {
        get
        {
            PropriedadeAcessada("Codcont");
            return _codcont;
        }
        set
        {
            PropriedadeModificada("Codcont", value);
            _codcont = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFBASEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfiscal
    {
        get
        {
            PropriedadeAcessada("Codfiscal");
            return _codfiscal;
        }
        set
        {
            PropriedadeModificada("Codfiscal", value);
            _codfiscal = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFBASEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dataconsolidacaoprefat
    {
        get
        {
            PropriedadeAcessada("Dataconsolidacaoprefat");
            return _dataconsolidacaoprefat;
        }
        set
        {
            PropriedadeModificada("Dataconsolidacaoprefat", value);
            _dataconsolidacaoprefat = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFBASEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtexportacaoservint
    {
        get
        {
            PropriedadeAcessada("Dtexportacaoservint");
            return _dtexportacaoservint;
        }
        set
        {
            PropriedadeModificada("Dtexportacaoservint", value);
            _dtexportacaoservint = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFBASEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtimportacaoservprinc
    {
        get
        {
            PropriedadeAcessada("Dtimportacaoservprinc");
            return _dtimportacaoservprinc;
        }
        set
        {
            PropriedadeModificada("Dtimportacaoservprinc", value);
            _dtimportacaoservprinc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFBASEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Exportadoservint
    {
        get
        {
            PropriedadeAcessada("Exportadoservint");
            return _exportadoservint;
        }
        set
        {
            PropriedadeModificada("Exportadoservint", value);
            _exportadoservint = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFBASEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Geraicmslivrofiscal
    {
        get
        {
            PropriedadeAcessada("Geraicmslivrofiscal");
            return _geraicmslivrofiscal;
        }
        set
        {
            PropriedadeModificada("Geraicmslivrofiscal", value);
            _geraicmslivrofiscal = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFBASEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Importadoservprinc
    {
        get
        {
            PropriedadeAcessada("Importadoservprinc");
            return _importadoservprinc;
        }
        set
        {
            PropriedadeModificada("Importadoservprinc", value);
            _importadoservprinc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFBASEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numtransent
    {
        get
        {
            PropriedadeAcessada("Numtransent");
            return _numtransent;
        }
        set
        {
            PropriedadeModificada("Numtransent", value);
            _numtransent = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFBASEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numtranspiscofins
    {
        get
        {
            PropriedadeAcessada("Numtranspiscofins");
            return _numtranspiscofins;
        }
        set
        {
            PropriedadeModificada("Numtranspiscofins", value);
            _numtranspiscofins = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFBASEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numtransvenda
    {
        get
        {
            PropriedadeAcessada("Numtransvenda");
            return _numtransvenda;
        }
        set
        {
            PropriedadeModificada("Numtransvenda", value);
            _numtransvenda = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFBASEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 2)]
    public decimal? Percbaseredpart
    {
        get
        {
            PropriedadeAcessada("Percbaseredpart");
            return _percbaseredpart;
        }
        set
        {
            PropriedadeModificada("Percbaseredpart", value);
            _percbaseredpart = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFBASEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 2)]
    public decimal? Perciss
    {
        get
        {
            PropriedadeAcessada("Perciss");
            return _perciss;
        }
        set
        {
            PropriedadeModificada("Perciss", value);
            _perciss = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFBASEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 2)]
    public decimal? Percprovpart
    {
        get
        {
            PropriedadeAcessada("Percprovpart");
            return _percprovpart;
        }
        set
        {
            PropriedadeModificada("Percprovpart", value);
            _percprovpart = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFBASEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 2)]
    public decimal? Percredcims
    {
        get
        {
            PropriedadeAcessada("Percredcims");
            return _percredcims;
        }
        set
        {
            PropriedadeModificada("Percredcims", value);
            _percredcims = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFBASEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 2)]
    public decimal? Percredicmscusto
    {
        get
        {
            PropriedadeAcessada("Percredicmscusto");
            return _percredicmscusto;
        }
        set
        {
            PropriedadeModificada("Percredicmscusto", value);
            _percredicmscusto = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFBASEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 3, Precisao = 0)]
    public string Sittribut
    {
        get
        {
            PropriedadeAcessada("Sittribut");
            return _sittribut;
        }
        set
        {
            PropriedadeModificada("Sittribut", value);
            _sittribut = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFBASEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 3, Precisao = 0)]
    public string Sittributipi
    {
        get
        {
            PropriedadeAcessada("Sittributipi");
            return _sittributipi;
        }
        set
        {
            PropriedadeModificada("Sittributipi", value);
            _sittributipi = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFBASEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFBASEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 2)]
    public decimal Vlbase
    {
        get
        {
            PropriedadeAcessada("Vlbase");
            return _vlbase;
        }
        set
        {
            PropriedadeModificada("Vlbase", value);
            _vlbase = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFBASEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 2)]
    public decimal? Vlbasenf
    {
        get
        {
            PropriedadeAcessada("Vlbasenf");
            return _vlbasenf;
        }
        set
        {
            PropriedadeModificada("Vlbasenf", value);
            _vlbasenf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFBASEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlbasepartdest
    {
        get
        {
            PropriedadeAcessada("Vlbasepartdest");
            return _vlbasepartdest;
        }
        set
        {
            PropriedadeModificada("Vlbasepartdest", value);
            _vlbasepartdest = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFBASEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 2)]
    public decimal? Vlcontabil
    {
        get
        {
            PropriedadeAcessada("Vlcontabil");
            return _vlcontabil;
        }
        set
        {
            PropriedadeModificada("Vlcontabil", value);
            _vlcontabil = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFBASEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlfcppart
    {
        get
        {
            PropriedadeAcessada("Vlfcppart");
            return _vlfcppart;
        }
        set
        {
            PropriedadeModificada("Vlfcppart", value);
            _vlfcppart = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFBASEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 2)]
    public decimal Vlicms
    {
        get
        {
            PropriedadeAcessada("Vlicms");
            return _vlicms;
        }
        set
        {
            PropriedadeModificada("Vlicms", value);
            _vlicms = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFBASEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlicmsdifaliqpart
    {
        get
        {
            PropriedadeAcessada("Vlicmsdifaliqpart");
            return _vlicmsdifaliqpart;
        }
        set
        {
            PropriedadeModificada("Vlicmsdifaliqpart", value);
            _vlicmsdifaliqpart = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFBASEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlicmsdiferido
    {
        get
        {
            PropriedadeAcessada("Vlicmsdiferido");
            return _vlicmsdiferido;
        }
        set
        {
            PropriedadeModificada("Vlicmsdiferido", value);
            _vlicmsdiferido = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFBASEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlicmspart
    {
        get
        {
            PropriedadeAcessada("Vlicmspart");
            return _vlicmspart;
        }
        set
        {
            PropriedadeModificada("Vlicmspart", value);
            _vlicmspart = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFBASEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlicmspartdest
    {
        get
        {
            PropriedadeAcessada("Vlicmspartdest");
            return _vlicmspartdest;
        }
        set
        {
            PropriedadeModificada("Vlicmspartdest", value);
            _vlicmspartdest = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFBASEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlicmspartrem
    {
        get
        {
            PropriedadeAcessada("Vlicmspartrem");
            return _vlicmspartrem;
        }
        set
        {
            PropriedadeModificada("Vlicmspartrem", value);
            _vlicmspartrem = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFBASEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 2)]
    public decimal? Vlisentas
    {
        get
        {
            PropriedadeAcessada("Vlisentas");
            return _vlisentas;
        }
        set
        {
            PropriedadeModificada("Vlisentas", value);
            _vlisentas = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNFBASEPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 2)]
    public decimal? Vlmexiva
    {
        get
        {
            PropriedadeAcessada("Vlmexiva");
            return _vlmexiva;
        }
        set
        {
            PropriedadeModificada("Vlmexiva", value);
            _vlmexiva = value;
        }
    }

    public void InicializarAtributos()
    {
    }

    public string ObterNomeTabela()
    {
        return "PCNFBASEPREFAT";
    }

    public IEntidade NovaInstancia()
    {
        return (IEntidade)GetType().GetConstructors()[0].Invoke(null);
    }

    public void CarregarPorDataReader(IDataReader leitor)
    {
        _aliqfcp = AlterarTipo<decimal?>(leitor["Aliqfcp"]);
        _aliqinternadest = AlterarTipo<decimal?>(leitor["Aliqinternadest"]);
        _aliqinterorigpart = AlterarTipo<decimal?>(leitor["Aliqinterorigpart"]);
        _aliquota = AlterarTipo<decimal>(leitor["Aliquota"]);
        _codcont = AlterarTipo<decimal>(leitor["Codcont"]);
        _codfiscal = AlterarTipo<decimal?>(leitor["Codfiscal"]);
        _dataconsolidacaoprefat = AlterarTipo<DateTime?>(leitor["Dataconsolidacaoprefat"]);
        _dtexportacaoservint = AlterarTipo<DateTime?>(leitor["Dtexportacaoservint"]);
        _dtimportacaoservprinc = AlterarTipo<DateTime?>(leitor["Dtimportacaoservprinc"]);
        _exportadoservint = AlterarTipo<string>(leitor["Exportadoservint"]);
        _geraicmslivrofiscal = AlterarTipo<string>(leitor["Geraicmslivrofiscal"]);
        _importadoservprinc = AlterarTipo<string>(leitor["Importadoservprinc"]);
        _numtransent = AlterarTipo<decimal?>(leitor["Numtransent"]);
        _numtranspiscofins = AlterarTipo<decimal?>(leitor["Numtranspiscofins"]);
        _numtransvenda = AlterarTipo<decimal?>(leitor["Numtransvenda"]);
        _percbaseredpart = AlterarTipo<decimal?>(leitor["Percbaseredpart"]);
        _perciss = AlterarTipo<decimal?>(leitor["Perciss"]);
        _percprovpart = AlterarTipo<decimal?>(leitor["Percprovpart"]);
        _percredcims = AlterarTipo<decimal?>(leitor["Percredcims"]);
        _percredicmscusto = AlterarTipo<decimal?>(leitor["Percredicmscusto"]);
        _sittribut = AlterarTipo<string>(leitor["Sittribut"]);
        _sittributipi = AlterarTipo<string>(leitor["Sittributipi"]);
        _tipo = AlterarTipo<string>(leitor["Tipo"]);
        _vlbase = AlterarTipo<decimal>(leitor["Vlbase"]);
        _vlbasenf = AlterarTipo<decimal?>(leitor["Vlbasenf"]);
        _vlbasepartdest = AlterarTipo<decimal?>(leitor["Vlbasepartdest"]);
        _vlcontabil = AlterarTipo<decimal?>(leitor["Vlcontabil"]);
        _vlfcppart = AlterarTipo<decimal?>(leitor["Vlfcppart"]);
        _vlicms = AlterarTipo<decimal>(leitor["Vlicms"]);
        _vlicmsdifaliqpart = AlterarTipo<decimal?>(leitor["Vlicmsdifaliqpart"]);
        _vlicmsdiferido = AlterarTipo<decimal?>(leitor["Vlicmsdiferido"]);
        _vlicmspart = AlterarTipo<decimal?>(leitor["Vlicmspart"]);
        _vlicmspartdest = AlterarTipo<decimal?>(leitor["Vlicmspartdest"]);
        _vlicmspartrem = AlterarTipo<decimal?>(leitor["Vlicmspartrem"]);
        _vlisentas = AlterarTipo<decimal?>(leitor["Vlisentas"]);
        _vlmexiva = AlterarTipo<decimal?>(leitor["Vlmexiva"]);
    }

}