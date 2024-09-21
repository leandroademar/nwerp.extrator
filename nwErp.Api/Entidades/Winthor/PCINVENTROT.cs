

////// namespace nwErp.Entidades.Winthor;

// namespace nwErp.Api.Modelos;

[Serializable]
public class PCINVENTROT : GerenteDePropriedades, IEntidade
{
    private static readonly string RO_AVARIAATUALIZADA = "Avariaatualizada";

    private string _avariaatualizada;

    private static readonly string RO_CODFILIAL = "Codfilial";

    private string _codfilial;

    private static readonly string RO_CODFUNCATUALIZACAO = "Codfuncatualizacao";

    private decimal? _codfuncatualizacao;

    private static readonly string RO_CODFUNCFEC1 = "Codfuncfec1";

    private decimal? _codfuncfec1;

    private static readonly string RO_CODFUNCFEC2 = "Codfuncfec2";

    private decimal? _codfuncfec2;

    private static readonly string RO_CODFUNCFEC3 = "Codfuncfec3";

    private decimal? _codfuncfec3;

    private static readonly string RO_CODFUNCMONTAGEM = "Codfuncmontagem";

    private decimal? _codfuncmontagem;

    private static readonly string RO_CODLOCAL = "Codlocal";

    private string _codlocal;

    private static readonly string RO_CODPROD = "Codprod";

    private decimal _codprod;

    private static readonly string RO_CUSTO = "Custo";

    private decimal? _custo;

    private static readonly string RO_DATA = "Data";

    private DateTime? _data;

    private static readonly string RO_DATACONT1 = "Datacont1";

    private DateTime? _datacont1;

    private static readonly string RO_DATACONT2 = "Datacont2";

    private DateTime? _datacont2;

    private static readonly string RO_DATACONT3 = "Datacont3";

    private DateTime? _datacont3;

    private static readonly string RO_DATAFECCONT1 = "Datafeccont1";

    private DateTime? _datafeccont1;

    private static readonly string RO_DATAFECCONT2 = "Datafeccont2";

    private DateTime? _datafeccont2;

    private static readonly string RO_DATAFECCONT3 = "Datafeccont3";

    private DateTime? _datafeccont3;

    private static readonly string RO_DTATUALIZACAO = "Dtatualizacao";

    private DateTime? _dtatualizacao;

    private static readonly string RO_INVENTAVARIA = "Inventavaria";

    private string _inventavaria;

    private static readonly string RO_NUMINVENT = "Numinvent";

    private decimal _numinvent;

    private static readonly string RO_NUMSEQ = "Numseq";

    private decimal? _numseq;

    private static readonly string RO_QTAVARIA1 = "Qtavaria1";

    private decimal? _qtavaria1;

    private static readonly string RO_QTAVARIA2 = "Qtavaria2";

    private decimal? _qtavaria2;

    private static readonly string RO_QTAVARIA3 = "Qtavaria3";

    private decimal? _qtavaria3;

    private static readonly string RO_QTCONT = "Qtcont";

    private decimal? _qtcont;

    private static readonly string RO_QTEST = "Qtest";

    private decimal? _qtest;

    private static readonly string RO_QTESTGER = "Qtestger";

    private decimal? _qtestger;

    private static readonly string RO_QTUTILIZAATUALIZACAO = "Qtutilizaatualizacao";

    private decimal? _qtutilizaatualizacao;

    private static readonly string RO_QT1 = "Qt1";

    private decimal? _qt1;

    private static readonly string RO_QT1CT = "Qt1ct";

    private decimal? _qt1ct;

    private static readonly string RO_QT1CX = "Qt1cx";

    private decimal? _qt1cx;

    private static readonly string RO_QT1LJ = "Qt1lj";

    private decimal? _qt1lj;

    private static readonly string RO_QT1UN = "Qt1un";

    private decimal? _qt1un;

    private static readonly string RO_QT2 = "Qt2";

    private decimal? _qt2;

    private static readonly string RO_QT2CT = "Qt2ct";

    private decimal? _qt2ct;

    private static readonly string RO_QT2CX = "Qt2cx";

    private decimal? _qt2cx;

    private static readonly string RO_QT2LJ = "Qt2lj";

    private decimal? _qt2lj;

    private static readonly string RO_QT2UN = "Qt2un";

    private decimal? _qt2un;

    private static readonly string RO_QT3 = "Qt3";

    private decimal? _qt3;

    private static readonly string RO_QT3CT = "Qt3ct";

    private decimal? _qt3ct;

    private static readonly string RO_QT3CX = "Qt3cx";

    private decimal? _qt3cx;

    private static readonly string RO_QT3LJ = "Qt3lj";

    private decimal? _qt3lj;

    private static readonly string RO_QT3UN = "Qt3un";

    private decimal? _qt3un;

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCINVENTROT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Avariaatualizada
    {
        get
        {
            PropriedadeAcessada(RO_AVARIAATUALIZADA);
            return _avariaatualizada;
        }
        set
        {
            PropriedadeModificada(RO_AVARIAATUALIZADA, value);
            _avariaatualizada = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCINVENTROT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCINVENTROT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfuncatualizacao
    {
        get
        {
            PropriedadeAcessada(RO_CODFUNCATUALIZACAO);
            return _codfuncatualizacao;
        }
        set
        {
            PropriedadeModificada(RO_CODFUNCATUALIZACAO, value);
            _codfuncatualizacao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCINVENTROT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfuncfec1
    {
        get
        {
            PropriedadeAcessada(RO_CODFUNCFEC1);
            return _codfuncfec1;
        }
        set
        {
            PropriedadeModificada(RO_CODFUNCFEC1, value);
            _codfuncfec1 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCINVENTROT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfuncfec2
    {
        get
        {
            PropriedadeAcessada(RO_CODFUNCFEC2);
            return _codfuncfec2;
        }
        set
        {
            PropriedadeModificada(RO_CODFUNCFEC2, value);
            _codfuncfec2 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCINVENTROT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfuncfec3
    {
        get
        {
            PropriedadeAcessada(RO_CODFUNCFEC3);
            return _codfuncfec3;
        }
        set
        {
            PropriedadeModificada(RO_CODFUNCFEC3, value);
            _codfuncfec3 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCINVENTROT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfuncmontagem
    {
        get
        {
            PropriedadeAcessada(RO_CODFUNCMONTAGEM);
            return _codfuncmontagem;
        }
        set
        {
            PropriedadeModificada(RO_CODFUNCMONTAGEM, value);
            _codfuncmontagem = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCINVENTROT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
    public string Codlocal
    {
        get
        {
            PropriedadeAcessada(RO_CODLOCAL);
            return _codlocal;
        }
        set
        {
            PropriedadeModificada(RO_CODLOCAL, value);
            _codlocal = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCINVENTROT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal Codprod
    {
        get
        {
            PropriedadeAcessada(RO_CODPROD);
            return _codprod;
        }
        set
        {
            PropriedadeModificada(RO_CODPROD, value);
            _codprod = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCINVENTROT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Custo
    {
        get
        {
            PropriedadeAcessada(RO_CUSTO);
            return _custo;
        }
        set
        {
            PropriedadeModificada(RO_CUSTO, value);
            _custo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCINVENTROT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Data
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCINVENTROT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Datacont1
    {
        get
        {
            PropriedadeAcessada(RO_DATACONT1);
            return _datacont1;
        }
        set
        {
            PropriedadeModificada(RO_DATACONT1, value);
            _datacont1 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCINVENTROT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Datacont2
    {
        get
        {
            PropriedadeAcessada(RO_DATACONT2);
            return _datacont2;
        }
        set
        {
            PropriedadeModificada(RO_DATACONT2, value);
            _datacont2 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCINVENTROT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Datacont3
    {
        get
        {
            PropriedadeAcessada(RO_DATACONT3);
            return _datacont3;
        }
        set
        {
            PropriedadeModificada(RO_DATACONT3, value);
            _datacont3 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCINVENTROT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Datafeccont1
    {
        get
        {
            PropriedadeAcessada(RO_DATAFECCONT1);
            return _datafeccont1;
        }
        set
        {
            PropriedadeModificada(RO_DATAFECCONT1, value);
            _datafeccont1 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCINVENTROT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Datafeccont2
    {
        get
        {
            PropriedadeAcessada(RO_DATAFECCONT2);
            return _datafeccont2;
        }
        set
        {
            PropriedadeModificada(RO_DATAFECCONT2, value);
            _datafeccont2 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCINVENTROT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Datafeccont3
    {
        get
        {
            PropriedadeAcessada(RO_DATAFECCONT3);
            return _datafeccont3;
        }
        set
        {
            PropriedadeModificada(RO_DATAFECCONT3, value);
            _datafeccont3 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCINVENTROT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtatualizacao
    {
        get
        {
            PropriedadeAcessada(RO_DTATUALIZACAO);
            return _dtatualizacao;
        }
        set
        {
            PropriedadeModificada(RO_DTATUALIZACAO, value);
            _dtatualizacao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCINVENTROT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Inventavaria
    {
        get
        {
            PropriedadeAcessada(RO_INVENTAVARIA);
            return _inventavaria;
        }
        set
        {
            PropriedadeModificada(RO_INVENTAVARIA, value);
            _inventavaria = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCINVENTROT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal Numinvent
    {
        get
        {
            PropriedadeAcessada(RO_NUMINVENT);
            return _numinvent;
        }
        set
        {
            PropriedadeModificada(RO_NUMINVENT, value);
            _numinvent = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCINVENTROT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numseq
    {
        get
        {
            PropriedadeAcessada(RO_NUMSEQ);
            return _numseq;
        }
        set
        {
            PropriedadeModificada(RO_NUMSEQ, value);
            _numseq = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCINVENTROT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 4)]
    public decimal? Qtavaria1
    {
        get
        {
            PropriedadeAcessada(RO_QTAVARIA1);
            return _qtavaria1;
        }
        set
        {
            PropriedadeModificada(RO_QTAVARIA1, value);
            _qtavaria1 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCINVENTROT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 4)]
    public decimal? Qtavaria2
    {
        get
        {
            PropriedadeAcessada(RO_QTAVARIA2);
            return _qtavaria2;
        }
        set
        {
            PropriedadeModificada(RO_QTAVARIA2, value);
            _qtavaria2 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCINVENTROT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 4)]
    public decimal? Qtavaria3
    {
        get
        {
            PropriedadeAcessada(RO_QTAVARIA3);
            return _qtavaria3;
        }
        set
        {
            PropriedadeModificada(RO_QTAVARIA3, value);
            _qtavaria3 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCINVENTROT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 22, Precisao = 8)]
    public decimal? Qtcont
    {
        get
        {
            PropriedadeAcessada(RO_QTCONT);
            return _qtcont;
        }
        set
        {
            PropriedadeModificada(RO_QTCONT, value);
            _qtcont = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCINVENTROT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 22, Precisao = 8)]
    public decimal? Qtest
    {
        get
        {
            PropriedadeAcessada(RO_QTEST);
            return _qtest;
        }
        set
        {
            PropriedadeModificada(RO_QTEST, value);
            _qtest = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCINVENTROT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 22, Precisao = 8)]
    public decimal? Qtestger
    {
        get
        {
            PropriedadeAcessada(RO_QTESTGER);
            return _qtestger;
        }
        set
        {
            PropriedadeModificada(RO_QTESTGER, value);
            _qtestger = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCINVENTROT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 22, Precisao = 8)]
    public decimal? Qtutilizaatualizacao
    {
        get
        {
            PropriedadeAcessada(RO_QTUTILIZAATUALIZACAO);
            return _qtutilizaatualizacao;
        }
        set
        {
            PropriedadeModificada(RO_QTUTILIZAATUALIZACAO, value);
            _qtutilizaatualizacao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCINVENTROT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 22, Precisao = 8)]
    public decimal? Qt1
    {
        get
        {
            PropriedadeAcessada(RO_QT1);
            return _qt1;
        }
        set
        {
            PropriedadeModificada(RO_QT1, value);
            _qt1 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCINVENTROT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 16, Precisao = 3)]
    public decimal? Qt1ct
    {
        get
        {
            PropriedadeAcessada(RO_QT1CT);
            return _qt1ct;
        }
        set
        {
            PropriedadeModificada(RO_QT1CT, value);
            _qt1ct = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCINVENTROT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 16, Precisao = 3)]
    public decimal? Qt1cx
    {
        get
        {
            PropriedadeAcessada(RO_QT1CX);
            return _qt1cx;
        }
        set
        {
            PropriedadeModificada(RO_QT1CX, value);
            _qt1cx = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCINVENTROT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 16, Precisao = 3)]
    public decimal? Qt1lj
    {
        get
        {
            PropriedadeAcessada(RO_QT1LJ);
            return _qt1lj;
        }
        set
        {
            PropriedadeModificada(RO_QT1LJ, value);
            _qt1lj = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCINVENTROT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 16, Precisao = 3)]
    public decimal? Qt1un
    {
        get
        {
            PropriedadeAcessada(RO_QT1UN);
            return _qt1un;
        }
        set
        {
            PropriedadeModificada(RO_QT1UN, value);
            _qt1un = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCINVENTROT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 22, Precisao = 8)]
    public decimal? Qt2
    {
        get
        {
            PropriedadeAcessada(RO_QT2);
            return _qt2;
        }
        set
        {
            PropriedadeModificada(RO_QT2, value);
            _qt2 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCINVENTROT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 16, Precisao = 3)]
    public decimal? Qt2ct
    {
        get
        {
            PropriedadeAcessada(RO_QT2CT);
            return _qt2ct;
        }
        set
        {
            PropriedadeModificada(RO_QT2CT, value);
            _qt2ct = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCINVENTROT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 16, Precisao = 3)]
    public decimal? Qt2cx
    {
        get
        {
            PropriedadeAcessada(RO_QT2CX);
            return _qt2cx;
        }
        set
        {
            PropriedadeModificada(RO_QT2CX, value);
            _qt2cx = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCINVENTROT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 16, Precisao = 3)]
    public decimal? Qt2lj
    {
        get
        {
            PropriedadeAcessada(RO_QT2LJ);
            return _qt2lj;
        }
        set
        {
            PropriedadeModificada(RO_QT2LJ, value);
            _qt2lj = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCINVENTROT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 16, Precisao = 3)]
    public decimal? Qt2un
    {
        get
        {
            PropriedadeAcessada(RO_QT2UN);
            return _qt2un;
        }
        set
        {
            PropriedadeModificada(RO_QT2UN, value);
            _qt2un = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCINVENTROT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 22, Precisao = 8)]
    public decimal? Qt3
    {
        get
        {
            PropriedadeAcessada(RO_QT3);
            return _qt3;
        }
        set
        {
            PropriedadeModificada(RO_QT3, value);
            _qt3 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCINVENTROT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 16, Precisao = 3)]
    public decimal? Qt3ct
    {
        get
        {
            PropriedadeAcessada(RO_QT3CT);
            return _qt3ct;
        }
        set
        {
            PropriedadeModificada(RO_QT3CT, value);
            _qt3ct = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCINVENTROT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 16, Precisao = 3)]
    public decimal? Qt3cx
    {
        get
        {
            PropriedadeAcessada(RO_QT3CX);
            return _qt3cx;
        }
        set
        {
            PropriedadeModificada(RO_QT3CX, value);
            _qt3cx = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCINVENTROT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 16, Precisao = 3)]
    public decimal? Qt3lj
    {
        get
        {
            PropriedadeAcessada(RO_QT3LJ);
            return _qt3lj;
        }
        set
        {
            PropriedadeModificada(RO_QT3LJ, value);
            _qt3lj = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCINVENTROT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 16, Precisao = 3)]
    public decimal? Qt3un
    {
        get
        {
            PropriedadeAcessada(RO_QT3UN);
            return _qt3un;
        }
        set
        {
            PropriedadeModificada(RO_QT3UN, value);
            _qt3un = value;
        }
    }

    public void InicializarAtributos()
    {
    }

    public string ObterNomeTabela()
    {
        return "PCINVENTROT";
    }

    public IEntidade NovaInstancia()
    {
        return (IEntidade)GetType().GetConstructors()[0].Invoke(null);
    }

    public void CarregarPorDataReader(IDataReader leitor)
    {
        _avariaatualizada = AlterarTipo<string>(leitor["Avariaatualizada"]);
        _codfilial = AlterarTipo<string>(leitor["Codfilial"]);
        _codfuncatualizacao = AlterarTipo<decimal?>(leitor["Codfuncatualizacao"]);
        _codfuncfec1 = AlterarTipo<decimal?>(leitor["Codfuncfec1"]);
        _codfuncfec2 = AlterarTipo<decimal?>(leitor["Codfuncfec2"]);
        _codfuncfec3 = AlterarTipo<decimal?>(leitor["Codfuncfec3"]);
        _codfuncmontagem = AlterarTipo<decimal?>(leitor["Codfuncmontagem"]);
        _codlocal = AlterarTipo<string>(leitor["Codlocal"]);
        _codprod = AlterarTipo<decimal>(leitor["Codprod"]);
        _custo = AlterarTipo<decimal?>(leitor["Custo"]);
        _data = AlterarTipo<DateTime?>(leitor["Data"]);
        _datacont1 = AlterarTipo<DateTime?>(leitor["Datacont1"]);
        _datacont2 = AlterarTipo<DateTime?>(leitor["Datacont2"]);
        _datacont3 = AlterarTipo<DateTime?>(leitor["Datacont3"]);
        _datafeccont1 = AlterarTipo<DateTime?>(leitor["Datafeccont1"]);
        _datafeccont2 = AlterarTipo<DateTime?>(leitor["Datafeccont2"]);
        _datafeccont3 = AlterarTipo<DateTime?>(leitor["Datafeccont3"]);
        _dtatualizacao = AlterarTipo<DateTime?>(leitor["Dtatualizacao"]);
        _inventavaria = AlterarTipo<string>(leitor["Inventavaria"]);
        _numinvent = AlterarTipo<decimal>(leitor["Numinvent"]);
        _numseq = AlterarTipo<decimal?>(leitor["Numseq"]);
        _qtavaria1 = AlterarTipo<decimal?>(leitor["Qtavaria1"]);
        _qtavaria2 = AlterarTipo<decimal?>(leitor["Qtavaria2"]);
        _qtavaria3 = AlterarTipo<decimal?>(leitor["Qtavaria3"]);
        _qtcont = AlterarTipo<decimal?>(leitor["Qtcont"]);
        _qtest = AlterarTipo<decimal?>(leitor["Qtest"]);
        _qtestger = AlterarTipo<decimal?>(leitor["Qtestger"]);
        _qtutilizaatualizacao = AlterarTipo<decimal?>(leitor["Qtutilizaatualizacao"]);
        _qt1 = AlterarTipo<decimal?>(leitor["Qt1"]);
        _qt1ct = AlterarTipo<decimal?>(leitor["Qt1ct"]);
        _qt1cx = AlterarTipo<decimal?>(leitor["Qt1cx"]);
        _qt1lj = AlterarTipo<decimal?>(leitor["Qt1lj"]);
        _qt1un = AlterarTipo<decimal?>(leitor["Qt1un"]);
        _qt2 = AlterarTipo<decimal?>(leitor["Qt2"]);
        _qt2ct = AlterarTipo<decimal?>(leitor["Qt2ct"]);
        _qt2cx = AlterarTipo<decimal?>(leitor["Qt2cx"]);
        _qt2lj = AlterarTipo<decimal?>(leitor["Qt2lj"]);
        _qt2un = AlterarTipo<decimal?>(leitor["Qt2un"]);
        _qt3 = AlterarTipo<decimal?>(leitor["Qt3"]);
        _qt3ct = AlterarTipo<decimal?>(leitor["Qt3ct"]);
        _qt3cx = AlterarTipo<decimal?>(leitor["Qt3cx"]);
        _qt3lj = AlterarTipo<decimal?>(leitor["Qt3lj"]);
        _qt3un = AlterarTipo<decimal?>(leitor["Qt3un"]);
    }

}