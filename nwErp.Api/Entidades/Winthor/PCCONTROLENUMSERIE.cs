

////// namespace nwErp.Entidades.Winthor;

// namespace nwErp.Api.Modelos;

[Serializable]
public class PCCONTROLENUMSERIE : GerenteDePropriedades, IEntidade
{
    private static readonly string RO_CODPROD = "Codprod";

    private decimal _codprod;

    private static readonly string RO_DTDEVOL = "Dtdevol";

    private DateTime? _dtdevol;

    private static readonly string RO_DTSAIDA = "Dtsaida";

    private DateTime? _dtsaida;

    private static readonly string RO_DTTERMINOGARANTIA = "Dtterminogarantia";

    private DateTime? _dtterminogarantia;

    private static readonly string RO_NUMNOTA = "Numnota";

    private decimal? _numnota;

    private static readonly string RO_NUMPED = "Numped";

    private decimal? _numped;

    private static readonly string RO_NUMSERIE = "Numserie";

    private string _numserie;

    private static readonly string RO_NUMTRANSENT = "Numtransent";

    private decimal? _numtransent;

    private static readonly string RO_NUMTRANSVENDA = "Numtransvenda";

    private decimal _numtransvenda;

    private static readonly string RO_PRAZOGARANTIA = "Prazogarantia";

    private decimal? _prazogarantia;

    private static readonly string RO_NUMSEQ = "Numseq";

    private decimal? _numseq;

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCCONTROLENUMSERIE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONTROLENUMSERIE", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtdevol
    {
        get
        {
            PropriedadeAcessada(RO_DTDEVOL);
            return _dtdevol;
        }
        set
        {
            PropriedadeModificada(RO_DTDEVOL, value);
            _dtdevol = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONTROLENUMSERIE", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtsaida
    {
        get
        {
            PropriedadeAcessada(RO_DTSAIDA);
            return _dtsaida;
        }
        set
        {
            PropriedadeModificada(RO_DTSAIDA, value);
            _dtsaida = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONTROLENUMSERIE", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtterminogarantia
    {
        get
        {
            PropriedadeAcessada(RO_DTTERMINOGARANTIA);
            return _dtterminogarantia;
        }
        set
        {
            PropriedadeModificada(RO_DTTERMINOGARANTIA, value);
            _dtterminogarantia = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONTROLENUMSERIE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numnota
    {
        get
        {
            PropriedadeAcessada(RO_NUMNOTA);
            return _numnota;
        }
        set
        {
            PropriedadeModificada(RO_NUMNOTA, value);
            _numnota = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONTROLENUMSERIE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numped
    {
        get
        {
            PropriedadeAcessada(RO_NUMPED);
            return _numped;
        }
        set
        {
            PropriedadeModificada(RO_NUMPED, value);
            _numped = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCCONTROLENUMSERIE", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 30, Precisao = 0)]
    public string Numserie
    {
        get
        {
            PropriedadeAcessada(RO_NUMSERIE);
            return _numserie;
        }
        set
        {
            PropriedadeModificada(RO_NUMSERIE, value);
            _numserie = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONTROLENUMSERIE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONTROLENUMSERIE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal Numtransvenda
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONTROLENUMSERIE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 0)]
    public decimal? Prazogarantia
    {
        get
        {
            PropriedadeAcessada(RO_PRAZOGARANTIA);
            return _prazogarantia;
        }
        set
        {
            PropriedadeModificada(RO_PRAZOGARANTIA, value);
            _prazogarantia = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCCONTROLENUMSERIE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 20, Precisao = 0)]
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

    public void InicializarAtributos()
    {
    }

    public string ObterNomeTabela()
    {
        return "PCCONTROLENUMSERIE";
    }

    public IEntidade NovaInstancia()
    {
        return (IEntidade)GetType().GetConstructors()[0].Invoke(null);
    }

    public void CarregarPorDataReader(IDataReader leitor)
    {
        _codprod = AlterarTipo<decimal>(leitor["Codprod"]);
        _dtdevol = AlterarTipo<DateTime?>(leitor["Dtdevol"]);
        _dtsaida = AlterarTipo<DateTime?>(leitor["Dtsaida"]);
        _dtterminogarantia = AlterarTipo<DateTime?>(leitor["Dtterminogarantia"]);
        _numnota = AlterarTipo<decimal?>(leitor["Numnota"]);
        _numped = AlterarTipo<decimal?>(leitor["Numped"]);
        _numserie = AlterarTipo<string>(leitor["Numserie"]);
        _numtransent = AlterarTipo<decimal?>(leitor["Numtransent"]);
        _numtransvenda = AlterarTipo<decimal>(leitor["Numtransvenda"]);
        _prazogarantia = AlterarTipo<decimal?>(leitor["Prazogarantia"]);
        _numseq = AlterarTipo<decimal?>(leitor["Numseq"]);
    }

}