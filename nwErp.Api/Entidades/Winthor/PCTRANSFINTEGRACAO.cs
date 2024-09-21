

////// namespace nwErp.Entidades.Winthor;

// namespace nwErp.Api.Modelos;

[Serializable]
public class PCTRANSFINTEGRACAO : GerenteDePropriedades, IEntidade
{
    private static readonly string RO_CODPROD = "Codprod";

    private decimal _codprod;

    private static readonly string RO_DATA = "Data";

    private DateTime _data;

    private static readonly string RO_FILIALDESTINO = "Filialdestino";

    private string _filialdestino;

    private static readonly string RO_FILIALORIGEM = "Filialorigem";

    private string _filialorigem;

    private static readonly string RO_NUMTRANSENT = "Numtransent";

    private decimal? _numtransent;

    private static readonly string RO_NUMTRANSF = "Numtransf";

    private decimal _numtransf;

    private static readonly string RO_NUMTRANSVENDA = "Numtransvenda";

    private decimal? _numtransvenda;

    private static readonly string RO_PROCESSADO = "Processado";

    private string _processado;

    private static readonly string RO_QT = "Qt";

    private decimal? _qt;

    private decimal? _numero_pedido;

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRANSFINTEGRACAO", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRANSFINTEGRACAO", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRANSFINTEGRACAO", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Filialdestino
    {
        get
        {
            PropriedadeAcessada(RO_FILIALDESTINO);
            return _filialdestino;
        }
        set
        {
            PropriedadeModificada(RO_FILIALDESTINO, value);
            _filialdestino = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRANSFINTEGRACAO", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Filialorigem
    {
        get
        {
            PropriedadeAcessada(RO_FILIALORIGEM);
            return _filialorigem;
        }
        set
        {
            PropriedadeModificada(RO_FILIALORIGEM, value);
            _filialorigem = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRANSFINTEGRACAO", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRANSFINTEGRACAO", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal Numtransf
    {
        get
        {
            PropriedadeAcessada(RO_NUMTRANSF);
            return _numtransf;
        }
        set
        {
            PropriedadeModificada(RO_NUMTRANSF, value);
            _numtransf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRANSFINTEGRACAO", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRANSFINTEGRACAO", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Processado
    {
        get
        {
            PropriedadeAcessada(RO_PROCESSADO);
            return _processado;
        }
        set
        {
            PropriedadeModificada(RO_PROCESSADO, value);
            _processado = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRANSFINTEGRACAO", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Qt
    {
        get
        {
            PropriedadeAcessada(RO_QT);
            return _qt;
        }
        set
        {
            PropriedadeModificada(RO_QT, value);
            _qt = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCTRANSFINTEGRACAO", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numero_Pedido
    {
        get
        {
            PropriedadeAcessada("Numero_Pedido");
            return _numero_pedido;
        }
        set
        {
            PropriedadeModificada("Numero_Pedido", value);
            _numero_pedido = value;
        }
    }

    public void InicializarAtributos()
    {
    }

    public string ObterNomeTabela()
    {
        return "PCTRANSFINTEGRACAO";
    }

    public IEntidade NovaInstancia()
    {
        return (IEntidade)GetType().GetConstructors()[0].Invoke(null);
    }

    public void CarregarPorDataReader(IDataReader leitor)
    {
        _codprod = AlterarTipo<decimal>(leitor["Codprod"]);
        _data = AlterarTipo<DateTime>(leitor["Data"]);
        _filialdestino = AlterarTipo<string>(leitor["Filialdestino"]);
        _filialorigem = AlterarTipo<string>(leitor["Filialorigem"]);
        _numtransent = AlterarTipo<decimal?>(leitor["Numtransent"]);
        _numtransf = AlterarTipo<decimal>(leitor["Numtransf"]);
        _numtransvenda = AlterarTipo<decimal?>(leitor["Numtransvenda"]);
        _processado = AlterarTipo<string>(leitor["Processado"]);
        _qt = AlterarTipo<decimal?>(leitor["Qt"]);
        _numero_pedido = AlterarTipo<decimal?>(leitor["Numero_pedido"]);
    }

}