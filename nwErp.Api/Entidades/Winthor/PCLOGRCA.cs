

////// // namespace nwErp.Entidades.Winthor;

// // namespace nwErp.Api.Modelos;

[Serializable]
public class PCLOGRCA : GerenteDePropriedades, IEntidade
{
    private string _codfilial;

    private decimal _codfunc;

    private decimal? _codprod;

    private decimal _codusur;

    private DateTime _data;

    private DateTime? _dtbloqcomis;

    private DateTime? _dtbloqueio;

    private string _historico;

    private string _historico2;

    private decimal? _numped;

    private decimal? _numseq;

    private decimal? _numtransent;

    private decimal? _numtransvenda;

    private decimal? _percsaldoreserva;

    private string _posicao;

    private decimal _rotina;

    private decimal? _vlcorrente;

    private decimal? _vlcorrenteant;

    private decimal? _vldiferenca;

    private decimal? _vllimcred;

    private decimal? _vllimcredant;

    private decimal? _vlreserva;

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOGRCA", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOGRCA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal Codfunc
    {
        get
        {
            PropriedadeAcessada("Codfunc");
            return _codfunc;
        }
        set
        {
            PropriedadeModificada("Codfunc", value);
            _codfunc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOGRCA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Codprod
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOGRCA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal Codusur
    {
        get
        {
            PropriedadeAcessada("Codusur");
            return _codusur;
        }
        set
        {
            PropriedadeModificada("Codusur", value);
            _codusur = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOGRCA", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime Data
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOGRCA", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtbloqcomis
    {
        get
        {
            PropriedadeAcessada("Dtbloqcomis");
            return _dtbloqcomis;
        }
        set
        {
            PropriedadeModificada("Dtbloqcomis", value);
            _dtbloqcomis = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOGRCA", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtbloqueio
    {
        get
        {
            PropriedadeAcessada("Dtbloqueio");
            return _dtbloqueio;
        }
        set
        {
            PropriedadeModificada("Dtbloqueio", value);
            _dtbloqueio = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOGRCA", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 60, Precisao = 0)]
    public string Historico
    {
        get
        {
            PropriedadeAcessada("Historico");
            return _historico;
        }
        set
        {
            PropriedadeModificada("Historico", value);
            _historico = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOGRCA", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 300, Precisao = 0)]
    public string Historico2
    {
        get
        {
            PropriedadeAcessada("Historico2");
            return _historico2;
        }
        set
        {
            PropriedadeModificada("Historico2", value);
            _historico2 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOGRCA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numped
    {
        get
        {
            PropriedadeAcessada("Numped");
            return _numped;
        }
        set
        {
            PropriedadeModificada("Numped", value);
            _numped = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOGRCA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 20, Precisao = 0)]
    public decimal? Numseq
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOGRCA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOGRCA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOGRCA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 2)]
    public decimal? Percsaldoreserva
    {
        get
        {
            PropriedadeAcessada("Percsaldoreserva");
            return _percsaldoreserva;
        }
        set
        {
            PropriedadeModificada("Percsaldoreserva", value);
            _percsaldoreserva = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOGRCA", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Posicao
    {
        get
        {
            PropriedadeAcessada("Posicao");
            return _posicao;
        }
        set
        {
            PropriedadeModificada("Posicao", value);
            _posicao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOGRCA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal Rotina
    {
        get
        {
            PropriedadeAcessada("Rotina");
            return _rotina;
        }
        set
        {
            PropriedadeModificada("Rotina", value);
            _rotina = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOGRCA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 2)]
    public decimal? Vlcorrente
    {
        get
        {
            PropriedadeAcessada("Vlcorrente");
            return _vlcorrente;
        }
        set
        {
            PropriedadeModificada("Vlcorrente", value);
            _vlcorrente = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOGRCA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 2)]
    public decimal? Vlcorrenteant
    {
        get
        {
            PropriedadeAcessada("Vlcorrenteant");
            return _vlcorrenteant;
        }
        set
        {
            PropriedadeModificada("Vlcorrenteant", value);
            _vlcorrenteant = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOGRCA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 6)]
    public decimal? Vldiferenca
    {
        get
        {
            PropriedadeAcessada("Vldiferenca");
            return _vldiferenca;
        }
        set
        {
            PropriedadeModificada("Vldiferenca", value);
            _vldiferenca = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOGRCA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 2)]
    public decimal? Vllimcred
    {
        get
        {
            PropriedadeAcessada("Vllimcred");
            return _vllimcred;
        }
        set
        {
            PropriedadeModificada("Vllimcred", value);
            _vllimcred = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOGRCA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 2)]
    public decimal? Vllimcredant
    {
        get
        {
            PropriedadeAcessada("Vllimcredant");
            return _vllimcredant;
        }
        set
        {
            PropriedadeModificada("Vllimcredant", value);
            _vllimcredant = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOGRCA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlreserva
    {
        get
        {
            PropriedadeAcessada("Vlreserva");
            return _vlreserva;
        }
        set
        {
            PropriedadeModificada("Vlreserva", value);
            _vlreserva = value;
        }
    }

    public void InicializarAtributos()
    {
    }

    public string ObterNomeTabela()
    {
        return "PCLOGRCA";
    }

    public IEntidade NovaInstancia()
    {
        return (IEntidade)GetType().GetConstructors()[0].Invoke(null);
    }

    public void CarregarPorDataReader(IDataReader leitor)
    {
        _codfilial = AlterarTipo<string>(leitor["Codfilial"]);
        _codfunc = AlterarTipo<decimal>(leitor["Codfunc"]);
        _codprod = AlterarTipo<decimal?>(leitor["Codprod"]);
        _codusur = AlterarTipo<decimal>(leitor["Codusur"]);
        _data = AlterarTipo<DateTime>(leitor["Data"]);
        _dtbloqcomis = AlterarTipo<DateTime?>(leitor["Dtbloqcomis"]);
        _dtbloqueio = AlterarTipo<DateTime?>(leitor["Dtbloqueio"]);
        _historico = AlterarTipo<string>(leitor["Historico"]);
        _historico2 = AlterarTipo<string>(leitor["Historico2"]);
        _numped = AlterarTipo<decimal?>(leitor["Numped"]);
        _numseq = AlterarTipo<decimal?>(leitor["Numseq"]);
        _numtransent = AlterarTipo<decimal?>(leitor["Numtransent"]);
        _numtransvenda = AlterarTipo<decimal?>(leitor["Numtransvenda"]);
        _percsaldoreserva = AlterarTipo<decimal?>(leitor["Percsaldoreserva"]);
        _posicao = AlterarTipo<string>(leitor["Posicao"]);
        _rotina = AlterarTipo<decimal>(leitor["Rotina"]);
        _vlcorrente = AlterarTipo<decimal?>(leitor["Vlcorrente"]);
        _vlcorrenteant = AlterarTipo<decimal?>(leitor["Vlcorrenteant"]);
        _vldiferenca = AlterarTipo<decimal?>(leitor["Vldiferenca"]);
        _vllimcred = AlterarTipo<decimal?>(leitor["Vllimcred"]);
        _vllimcredant = AlterarTipo<decimal?>(leitor["Vllimcredant"]);
        _vlreserva = AlterarTipo<decimal?>(leitor["Vlreserva"]);
    }

}