

////// namespace nwErp.Entidades.Winthor;

// namespace nwErp.Api.Modelos;

[Serializable]
public class PCTRANSFDEP : GerenteDePropriedades, IEntidade
{
    private static readonly string RO_CODFILIALDESTINO = "Codfilialdestino";

    private string _codfilialdestino;

    private static readonly string RO_CODFILIALORIGEM = "Codfilialorigem";

    private string _codfilialorigem;

    private static readonly string RO_CODPROD = "Codprod";

    private decimal? _codprod;

    private static readonly string RO_DTTRANSF = "Dttransf";

    private DateTime? _dttransf;

    private static readonly string RO_NUMLOTE = "Numlote";

    private string _numlote;

    private static readonly string RO_NUMTRANSENT = "Numtransent";

    private decimal? _numtransent;

    private static readonly string RO_NUMTRANSTRANSFENT = "Numtranstransfent";

    private decimal? _numtranstransfent;

    private static readonly string RO_NUMTRANSTRANSFSAIDA = "Numtranstransfsaida";

    private decimal? _numtranstransfsaida;

    private static readonly string RO_NUMTRANSVENDA = "Numtransvenda";

    private decimal? _numtransvenda;

    private static readonly string RO_QTTRANSF = "Qttransf";

    private decimal? _qttransf;

    private static readonly string RO_QTTRANSFCONT = "Qttransfcont";

    private decimal? _qttransfcont;

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRANSFDEP", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Codfilialdestino
    {
        get
        {
            PropriedadeAcessada(RO_CODFILIALDESTINO);
            return _codfilialdestino;
        }
        set
        {
            PropriedadeModificada(RO_CODFILIALDESTINO, value);
            _codfilialdestino = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRANSFDEP", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Codfilialorigem
    {
        get
        {
            PropriedadeAcessada(RO_CODFILIALORIGEM);
            return _codfilialorigem;
        }
        set
        {
            PropriedadeModificada(RO_CODFILIALORIGEM, value);
            _codfilialorigem = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRANSFDEP", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Codprod
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRANSFDEP", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dttransf
    {
        get
        {
            PropriedadeAcessada(RO_DTTRANSF);
            return _dttransf;
        }
        set
        {
            PropriedadeModificada(RO_DTTRANSF, value);
            _dttransf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRANSFDEP", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 15, Precisao = 0)]
    public string Numlote
    {
        get
        {
            PropriedadeAcessada(RO_NUMLOTE);
            return _numlote;
        }
        set
        {
            PropriedadeModificada(RO_NUMLOTE, value);
            _numlote = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRANSFDEP", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRANSFDEP", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numtranstransfent
    {
        get
        {
            PropriedadeAcessada(RO_NUMTRANSTRANSFENT);
            return _numtranstransfent;
        }
        set
        {
            PropriedadeModificada(RO_NUMTRANSTRANSFENT, value);
            _numtranstransfent = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRANSFDEP", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numtranstransfsaida
    {
        get
        {
            PropriedadeAcessada(RO_NUMTRANSTRANSFSAIDA);
            return _numtranstransfsaida;
        }
        set
        {
            PropriedadeModificada(RO_NUMTRANSTRANSFSAIDA, value);
            _numtranstransfsaida = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRANSFDEP", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRANSFDEP", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 22, Precisao = 8)]
    public decimal? Qttransf
    {
        get
        {
            PropriedadeAcessada(RO_QTTRANSF);
            return _qttransf;
        }
        set
        {
            PropriedadeModificada(RO_QTTRANSF, value);
            _qttransf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRANSFDEP", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 22, Precisao = 8)]
    public decimal? Qttransfcont
    {
        get
        {
            PropriedadeAcessada(RO_QTTRANSFCONT);
            return _qttransfcont;
        }
        set
        {
            PropriedadeModificada(RO_QTTRANSFCONT, value);
            _qttransfcont = value;
        }
    }

    public void InicializarAtributos()
    {
    }

    public string ObterNomeTabela()
    {
        return "PCTRANSFDEP";
    }

    public IEntidade NovaInstancia()
    {
        return (IEntidade)GetType().GetConstructors()[0].Invoke(null);
    }

    public void CarregarPorDataReader(IDataReader leitor)
    {
        _codfilialdestino = AlterarTipo<string>(leitor["Codfilialdestino"]);
        _codfilialorigem = AlterarTipo<string>(leitor["Codfilialorigem"]);
        _codprod = AlterarTipo<decimal?>(leitor["Codprod"]);
        _dttransf = AlterarTipo<DateTime?>(leitor["Dttransf"]);
        _numlote = AlterarTipo<string>(leitor["Numlote"]);
        _numtransent = AlterarTipo<decimal?>(leitor["Numtransent"]);
        _numtranstransfent = AlterarTipo<decimal?>(leitor["Numtranstransfent"]);
        _numtranstransfsaida = AlterarTipo<decimal?>(leitor["Numtranstransfsaida"]);
        _numtransvenda = AlterarTipo<decimal?>(leitor["Numtransvenda"]);
        _qttransf = AlterarTipo<decimal?>(leitor["Qttransf"]);
        _qttransfcont = AlterarTipo<decimal?>(leitor["Qttransfcont"]);
    }

}