

////// namespace nwErp.Entidades.Winthor;

// namespace nwErp.Api.Modelos;

[Serializable]
public class PCORCAVENDAITRANSF : GerenteDePropriedades, IEntidade
{
    private decimal _codauxiliar;

    private string _codfilial;

    private decimal _codfunctransf;

    private decimal? _codgarcomtransf;

    private decimal? _codimp;

    private decimal _codprod;

    private decimal? _codst;

    private decimal _codsupervlibtransf;

    private DateTime? _datatransf;

    private DateTime? _dtabertura;

    private string _impressorestaurante;

    private string _imprimerestaurante;

    private string _motivotransf;

    private decimal? _numfichadest;

    private decimal? _numfichaorig;

    private decimal _numorca;

    private decimal _numorcadest;

    private decimal _numseq;

    private decimal? _numseqimpressao;

    private decimal? _ptabela;

    private decimal? _pvenda;

    private decimal _qt;

    private string _rotinatransf;

    private string _tipotransf;

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAITRANSF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 16, Precisao = 0)]
    public decimal Codauxiliar
    {
        get
        {
            PropriedadeAcessada("Codauxiliar");
            return _codauxiliar;
        }
        set
        {
            PropriedadeModificada("Codauxiliar", value);
            _codauxiliar = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAITRANSF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAITRANSF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal Codfunctransf
    {
        get
        {
            PropriedadeAcessada("Codfunctransf");
            return _codfunctransf;
        }
        set
        {
            PropriedadeModificada("Codfunctransf", value);
            _codfunctransf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAITRANSF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codgarcomtransf
    {
        get
        {
            PropriedadeAcessada("Codgarcomtransf");
            return _codgarcomtransf;
        }
        set
        {
            PropriedadeModificada("Codgarcomtransf", value);
            _codgarcomtransf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAITRANSF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codimp
    {
        get
        {
            PropriedadeAcessada("Codimp");
            return _codimp;
        }
        set
        {
            PropriedadeModificada("Codimp", value);
            _codimp = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAITRANSF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal Codprod
    {
        get
        {
            PropriedadeAcessada("Codprod");
            return _codprod;
        }
        set
        {
            PropriedadeModificada("Codprod", value);
            _codprod = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAITRANSF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Codst
    {
        get
        {
            PropriedadeAcessada("Codst");
            return _codst;
        }
        set
        {
            PropriedadeModificada("Codst", value);
            _codst = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAITRANSF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal Codsupervlibtransf
    {
        get
        {
            PropriedadeAcessada("Codsupervlibtransf");
            return _codsupervlibtransf;
        }
        set
        {
            PropriedadeModificada("Codsupervlibtransf", value);
            _codsupervlibtransf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAITRANSF", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Datatransf
    {
        get
        {
            PropriedadeAcessada("Datatransf");
            return _datatransf;
        }
        set
        {
            PropriedadeModificada("Datatransf", value);
            _datatransf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAITRANSF", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAITRANSF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Impressorestaurante
    {
        get
        {
            PropriedadeAcessada("Impressorestaurante");
            return _impressorestaurante;
        }
        set
        {
            PropriedadeModificada("Impressorestaurante", value);
            _impressorestaurante = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAITRANSF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Imprimerestaurante
    {
        get
        {
            PropriedadeAcessada("Imprimerestaurante");
            return _imprimerestaurante;
        }
        set
        {
            PropriedadeModificada("Imprimerestaurante", value);
            _imprimerestaurante = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAITRANSF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 120, Precisao = 0)]
    public string Motivotransf
    {
        get
        {
            PropriedadeAcessada("Motivotransf");
            return _motivotransf;
        }
        set
        {
            PropriedadeModificada("Motivotransf", value);
            _motivotransf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAITRANSF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Numfichadest
    {
        get
        {
            PropriedadeAcessada("Numfichadest");
            return _numfichadest;
        }
        set
        {
            PropriedadeModificada("Numfichadest", value);
            _numfichadest = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAITRANSF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Numfichaorig
    {
        get
        {
            PropriedadeAcessada("Numfichaorig");
            return _numfichaorig;
        }
        set
        {
            PropriedadeModificada("Numfichaorig", value);
            _numfichaorig = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAITRANSF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal Numorca
    {
        get
        {
            PropriedadeAcessada("Numorca");
            return _numorca;
        }
        set
        {
            PropriedadeModificada("Numorca", value);
            _numorca = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAITRANSF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal Numorcadest
    {
        get
        {
            PropriedadeAcessada("Numorcadest");
            return _numorcadest;
        }
        set
        {
            PropriedadeModificada("Numorcadest", value);
            _numorcadest = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAITRANSF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 20, Precisao = 0)]
    public decimal Numseq
    {
        get
        {
            PropriedadeAcessada("Numseq");
            return _numseq;
        }
        set
        {
            PropriedadeModificada("Numseq", value);
            _numseq = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAITRANSF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Numseqimpressao
    {
        get
        {
            PropriedadeAcessada("Numseqimpressao");
            return _numseqimpressao;
        }
        set
        {
            PropriedadeModificada("Numseqimpressao", value);
            _numseqimpressao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAITRANSF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 19, Precisao = 6)]
    public decimal? Ptabela
    {
        get
        {
            PropriedadeAcessada("Ptabela");
            return _ptabela;
        }
        set
        {
            PropriedadeModificada("Ptabela", value);
            _ptabela = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAITRANSF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 19, Precisao = 6)]
    public decimal? Pvenda
    {
        get
        {
            PropriedadeAcessada("Pvenda");
            return _pvenda;
        }
        set
        {
            PropriedadeModificada("Pvenda", value);
            _pvenda = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAITRANSF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 20, Precisao = 0)]
    public decimal Qt
    {
        get
        {
            PropriedadeAcessada("Qt");
            return _qt;
        }
        set
        {
            PropriedadeModificada("Qt", value);
            _qt = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAITRANSF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 48, Precisao = 0)]
    public string Rotinatransf
    {
        get
        {
            PropriedadeAcessada("Rotinatransf");
            return _rotinatransf;
        }
        set
        {
            PropriedadeModificada("Rotinatransf", value);
            _rotinatransf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAITRANSF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Tipotransf
    {
        get
        {
            PropriedadeAcessada("Tipotransf");
            return _tipotransf;
        }
        set
        {
            PropriedadeModificada("Tipotransf", value);
            _tipotransf = value;
        }
    }

    public void InicializarAtributos()
    {
    }

    public string ObterNomeTabela()
    {
        return "PCORCAVENDAITRANSF";
    }

    public IEntidade NovaInstancia()
    {
        return (IEntidade)GetType().GetConstructors()[0].Invoke(null);
    }

    public void CarregarPorDataReader(IDataReader leitor)
    {
        _codauxiliar = AlterarTipo<decimal>(leitor["Codauxiliar"]);
        _codfilial = AlterarTipo<string>(leitor["Codfilial"]);
        _codfunctransf = AlterarTipo<decimal>(leitor["Codfunctransf"]);
        _codgarcomtransf = AlterarTipo<decimal?>(leitor["Codgarcomtransf"]);
        _codimp = AlterarTipo<decimal?>(leitor["Codimp"]);
        _codprod = AlterarTipo<decimal>(leitor["Codprod"]);
        _codst = AlterarTipo<decimal?>(leitor["Codst"]);
        _codsupervlibtransf = AlterarTipo<decimal>(leitor["Codsupervlibtransf"]);
        _datatransf = AlterarTipo<DateTime?>(leitor["Datatransf"]);
        _dtabertura = AlterarTipo<DateTime?>(leitor["Dtabertura"]);
        _impressorestaurante = AlterarTipo<string>(leitor["Impressorestaurante"]);
        _imprimerestaurante = AlterarTipo<string>(leitor["Imprimerestaurante"]);
        _motivotransf = AlterarTipo<string>(leitor["Motivotransf"]);
        _numfichadest = AlterarTipo<decimal?>(leitor["Numfichadest"]);
        _numfichaorig = AlterarTipo<decimal?>(leitor["Numfichaorig"]);
        _numorca = AlterarTipo<decimal>(leitor["Numorca"]);
        _numorcadest = AlterarTipo<decimal>(leitor["Numorcadest"]);
        _numseq = AlterarTipo<decimal>(leitor["Numseq"]);
        _numseqimpressao = AlterarTipo<decimal?>(leitor["Numseqimpressao"]);
        _ptabela = AlterarTipo<decimal?>(leitor["Ptabela"]);
        _pvenda = AlterarTipo<decimal?>(leitor["Pvenda"]);
        _qt = AlterarTipo<decimal>(leitor["Qt"]);
        _rotinatransf = AlterarTipo<string>(leitor["Rotinatransf"]);
        _tipotransf = AlterarTipo<string>(leitor["Tipotransf"]);
    }

}