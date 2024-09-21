

////// namespace nwErp.Entidades.Winthor;

// namespace nwErp.Api.Modelos;

[Serializable]
public class PCNEWTOOL : GerenteDePropriedades, IEntidade
{
    private string _chavenfe;

    private string _codfilial;

    private DateTime? _datainserido;

    private DateTime? _dtsaida;

    private string _maquina;

    private decimal? _numnota;

    private decimal? _numped;

    private decimal? _numtransvenda;

    private string _serie;

    private string _docemissao;

    private string _usuario;

    private static readonly string RO_CHAVENEWTOOL = "Chavenewtool";

    private string _chavenewtool;

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNEWTOOL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 50, Precisao = 0)]
    public string Chavenfe
    {
        get
        {
            PropriedadeAcessada("Chavenfe");
            return _chavenfe;
        }
        set
        {
            PropriedadeModificada("Chavenfe", value);
            _chavenfe = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNEWTOOL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNEWTOOL", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Datainserido
    {
        get
        {
            PropriedadeAcessada("Datainserido");
            return _datainserido;
        }
        set
        {
            PropriedadeModificada("Datainserido", value);
            _datainserido = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNEWTOOL", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtsaida
    {
        get
        {
            PropriedadeAcessada("Dtsaida");
            return _dtsaida;
        }
        set
        {
            PropriedadeModificada("Dtsaida", value);
            _dtsaida = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNEWTOOL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 50, Precisao = 0)]
    public string Maquina
    {
        get
        {
            PropriedadeAcessada("Maquina");
            return _maquina;
        }
        set
        {
            PropriedadeModificada("Maquina", value);
            _maquina = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNEWTOOL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Numnota
    {
        get
        {
            PropriedadeAcessada("Numnota");
            return _numnota;
        }
        set
        {
            PropriedadeModificada("Numnota", value);
            _numnota = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNEWTOOL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNEWTOOL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNEWTOOL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 3, Precisao = 0)]
    public string Serie
    {
        get
        {
            PropriedadeAcessada("Serie");
            return _serie;
        }
        set
        {
            PropriedadeModificada("Serie", value);
            _serie = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNEWTOOL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Docemissao
    {
        get
        {
            PropriedadeAcessada("Docemissao");
            return _docemissao;
        }
        set
        {
            PropriedadeModificada("Docemissao", value);
            _docemissao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNEWTOOL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 50, Precisao = 0)]
    public string Usuario
    {
        get
        {
            PropriedadeAcessada("Usuario");
            return _usuario;
        }
        set
        {
            PropriedadeModificada("Usuario", value);
            _usuario = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCNEWTOOL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 4000, Precisao = 0)]
    public string Chavenewtool
    {
        get
        {
            PropriedadeAcessada(RO_CHAVENEWTOOL);
            return _chavenewtool;
        }
        set
        {
            PropriedadeModificada(RO_CHAVENEWTOOL, value);
            _chavenewtool = value;
        }
    }

    public void InicializarAtributos()
    {
    }

    public string ObterNomeTabela()
    {
        return "PCNEWTOOL";
    }

    public IEntidade NovaInstancia()
    {
        return (IEntidade)GetType().GetConstructors()[0].Invoke(null);
    }

    public void CarregarPorDataReader(IDataReader leitor)
    {
        _chavenfe = AlterarTipo<string>(leitor["Chavenfe"]);
        _codfilial = AlterarTipo<string>(leitor["Codfilial"]);
        _datainserido = AlterarTipo<DateTime?>(leitor["Datainserido"]);
        _dtsaida = AlterarTipo<DateTime?>(leitor["Dtsaida"]);
        _maquina = AlterarTipo<string>(leitor["Maquina"]);
        _numnota = AlterarTipo<decimal?>(leitor["Numnota"]);
        _numped = AlterarTipo<decimal?>(leitor["Numped"]);
        _numtransvenda = AlterarTipo<decimal?>(leitor["Numtransvenda"]);
        _serie = AlterarTipo<string>(leitor["Serie"]);
        _docemissao = AlterarTipo<string>(leitor["Docemissao"]);
        _usuario = AlterarTipo<string>(leitor["Usuario"]);
        _chavenewtool = AlterarTipo<string>(leitor["Chavenewtool"]);
    }

}