

////// namespace nwErp.Entidades.Winthor;

// namespace nwErp.Api.Modelos;

[Serializable]
public class PCPRACA : GerenteDePropriedades, IEntidade
{
    private static readonly string RO_CEPFINAL = "Cepfinal";

    private string _cepfinal;

    private static readonly string RO_CEPINICIAL = "Cepinicial";

    private string _cepinicial;

    private static readonly string RO_CODMUNIC = "Codmunic";

    private decimal? _codmunic;

    private static readonly string RO_CODPRACA = "Codpraca";

    private decimal _codpraca;

    private static readonly string RO_CODPRACAORIG = "Codpracaorig";

    private decimal? _codpracaorig;

    private static readonly string RO_CODPRACAORIG2 = "Codpracaorig2";

    private decimal? _codpracaorig2;

    private static readonly string RO_CODPRACAORIG3 = "Codpracaorig3";

    private decimal? _codpracaorig3;

    private static readonly string RO_CODPRACAORIG4 = "Codpracaorig4";

    private decimal? _codpracaorig4;

    private static readonly string RO_CODPRACAPRINCIPAL = "Codpracaprincipal";

    private decimal? _codpracaprincipal;

    private static readonly string RO_DISTANCIA = "Distancia";

    private decimal? _distancia;

    private static readonly string RO_DTCADASTRO = "Dtcadastro";

    private DateTime? _dtcadastro;

    private static readonly string RO_NUMREGIAO = "Numregiao";

    private decimal _numregiao;

    private static readonly string RO_NUMREGIAO2 = "Numregiao2";

    private decimal? _numregiao2;

    private static readonly string RO_OBS = "Obs";

    private string _obs;

    private static readonly string RO_PERCMINCARREG = "Percmincarreg";

    private decimal? _percmincarreg;

    private static readonly string RO_PERFRETEPROGRESS = "Perfreteprogress";

    private decimal? _perfreteprogress;

    private static readonly string RO_POPULACAO = "Populacao";

    private decimal? _populacao;

    private static readonly string RO_PRACA = "Praca";

    private string _praca;

    private static readonly string RO_PRIORIDADEENTREGA = "Prioridadeentrega";

    private string _prioridadeentrega;

    private static readonly string RO_ROTA = "Rota";

    private decimal _rota;

    private static readonly string RO_SEQROTA = "Seqrota";

    private decimal _seqrota;

    private static readonly string RO_SITUACAO = "Situacao";

    private string _situacao;

    private static readonly string RO_TIPOPRACA = "Tipopraca";

    private string _tipopraca;

    private static readonly string RO_VLMINCARREG = "Vlmincarreg";

    private decimal? _vlmincarreg;

    private static readonly string RO_VLPAUTAFRETE = "Vlpautafrete";

    private decimal? _vlpautafrete;

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRACA", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 9, Precisao = 0)]
    public string Cepfinal
    {
        get
        {
            PropriedadeAcessada(RO_CEPFINAL);
            return _cepfinal;
        }
        set
        {
            PropriedadeModificada(RO_CEPFINAL, value);
            _cepfinal = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRACA", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 9, Precisao = 0)]
    public string Cepinicial
    {
        get
        {
            PropriedadeAcessada(RO_CEPINICIAL);
            return _cepinicial;
        }
        set
        {
            PropriedadeModificada(RO_CEPINICIAL, value);
            _cepinicial = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRACA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codmunic
    {
        get
        {
            PropriedadeAcessada(RO_CODMUNIC);
            return _codmunic;
        }
        set
        {
            PropriedadeModificada(RO_CODMUNIC, value);
            _codmunic = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCPRACA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal Codpraca
    {
        get
        {
            PropriedadeAcessada(RO_CODPRACA);
            return _codpraca;
        }
        set
        {
            PropriedadeModificada(RO_CODPRACA, value);
            _codpraca = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRACA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codpracaorig
    {
        get
        {
            PropriedadeAcessada(RO_CODPRACAORIG);
            return _codpracaorig;
        }
        set
        {
            PropriedadeModificada(RO_CODPRACAORIG, value);
            _codpracaorig = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRACA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codpracaorig2
    {
        get
        {
            PropriedadeAcessada(RO_CODPRACAORIG2);
            return _codpracaorig2;
        }
        set
        {
            PropriedadeModificada(RO_CODPRACAORIG2, value);
            _codpracaorig2 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRACA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codpracaorig3
    {
        get
        {
            PropriedadeAcessada(RO_CODPRACAORIG3);
            return _codpracaorig3;
        }
        set
        {
            PropriedadeModificada(RO_CODPRACAORIG3, value);
            _codpracaorig3 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRACA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codpracaorig4
    {
        get
        {
            PropriedadeAcessada(RO_CODPRACAORIG4);
            return _codpracaorig4;
        }
        set
        {
            PropriedadeModificada(RO_CODPRACAORIG4, value);
            _codpracaorig4 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRACA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Codpracaprincipal
    {
        get
        {
            PropriedadeAcessada(RO_CODPRACAPRINCIPAL);
            return _codpracaprincipal;
        }
        set
        {
            PropriedadeModificada(RO_CODPRACAPRINCIPAL, value);
            _codpracaprincipal = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRACA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 2)]
    public decimal? Distancia
    {
        get
        {
            PropriedadeAcessada(RO_DISTANCIA);
            return _distancia;
        }
        set
        {
            PropriedadeModificada(RO_DISTANCIA, value);
            _distancia = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRACA", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtcadastro
    {
        get
        {
            PropriedadeAcessada(RO_DTCADASTRO);
            return _dtcadastro;
        }
        set
        {
            PropriedadeModificada(RO_DTCADASTRO, value);
            _dtcadastro = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRACA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal Numregiao
    {
        get
        {
            PropriedadeAcessada(RO_NUMREGIAO);
            return _numregiao;
        }
        set
        {
            PropriedadeModificada(RO_NUMREGIAO, value);
            _numregiao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRACA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Numregiao2
    {
        get
        {
            PropriedadeAcessada(RO_NUMREGIAO2);
            return _numregiao2;
        }
        set
        {
            PropriedadeModificada(RO_NUMREGIAO2, value);
            _numregiao2 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRACA", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 300, Precisao = 0)]
    public string Obs
    {
        get
        {
            PropriedadeAcessada(RO_OBS);
            return _obs;
        }
        set
        {
            PropriedadeModificada(RO_OBS, value);
            _obs = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRACA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 2)]
    public decimal? Percmincarreg
    {
        get
        {
            PropriedadeAcessada(RO_PERCMINCARREG);
            return _percmincarreg;
        }
        set
        {
            PropriedadeModificada(RO_PERCMINCARREG, value);
            _percmincarreg = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRACA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Perfreteprogress
    {
        get
        {
            PropriedadeAcessada(RO_PERFRETEPROGRESS);
            return _perfreteprogress;
        }
        set
        {
            PropriedadeModificada(RO_PERFRETEPROGRESS, value);
            _perfreteprogress = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRACA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 0)]
    public decimal? Populacao
    {
        get
        {
            PropriedadeAcessada(RO_POPULACAO);
            return _populacao;
        }
        set
        {
            PropriedadeModificada(RO_POPULACAO, value);
            _populacao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRACA", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 25, Precisao = 0)]
    public string Praca
    {
        get
        {
            PropriedadeAcessada(RO_PRACA);
            return _praca;
        }
        set
        {
            PropriedadeModificada(RO_PRACA, value);
            _praca = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRACA", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Prioridadeentrega
    {
        get
        {
            PropriedadeAcessada(RO_PRIORIDADEENTREGA);
            return _prioridadeentrega;
        }
        set
        {
            PropriedadeModificada(RO_PRIORIDADEENTREGA, value);
            _prioridadeentrega = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRACA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal Rota
    {
        get
        {
            PropriedadeAcessada(RO_ROTA);
            return _rota;
        }
        set
        {
            PropriedadeModificada(RO_ROTA, value);
            _rota = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRACA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal Seqrota
    {
        get
        {
            PropriedadeAcessada(RO_SEQROTA);
            return _seqrota;
        }
        set
        {
            PropriedadeModificada(RO_SEQROTA, value);
            _seqrota = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRACA", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Situacao
    {
        get
        {
            PropriedadeAcessada(RO_SITUACAO);
            return _situacao;
        }
        set
        {
            PropriedadeModificada(RO_SITUACAO, value);
            _situacao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRACA", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Tipopraca
    {
        get
        {
            PropriedadeAcessada(RO_TIPOPRACA);
            return _tipopraca;
        }
        set
        {
            PropriedadeModificada(RO_TIPOPRACA, value);
            _tipopraca = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRACA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 2)]
    public decimal? Vlmincarreg
    {
        get
        {
            PropriedadeAcessada(RO_VLMINCARREG);
            return _vlmincarreg;
        }
        set
        {
            PropriedadeModificada(RO_VLMINCARREG, value);
            _vlmincarreg = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRACA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 2)]
    public decimal? Vlpautafrete
    {
        get
        {
            PropriedadeAcessada(RO_VLPAUTAFRETE);
            return _vlpautafrete;
        }
        set
        {
            PropriedadeModificada(RO_VLPAUTAFRETE, value);
            _vlpautafrete = value;
        }
    }

    public void InicializarAtributos()
    {
    }

    public string ObterNomeTabela()
    {
        return "PCPRACA";
    }

    public IEntidade NovaInstancia()
    {
        return (IEntidade)GetType().GetConstructors()[0].Invoke(null);
    }

    public void CarregarPorDataReader(IDataReader leitor)
    {
        _cepfinal = AlterarTipo<string>(leitor["Cepfinal"]);
        _cepinicial = AlterarTipo<string>(leitor["Cepinicial"]);
        _codmunic = AlterarTipo<decimal?>(leitor["Codmunic"]);
        _codpraca = AlterarTipo<decimal>(leitor["Codpraca"]);
        _codpracaorig = AlterarTipo<decimal?>(leitor["Codpracaorig"]);
        _codpracaorig2 = AlterarTipo<decimal?>(leitor["Codpracaorig2"]);
        _codpracaorig3 = AlterarTipo<decimal?>(leitor["Codpracaorig3"]);
        _codpracaorig4 = AlterarTipo<decimal?>(leitor["Codpracaorig4"]);
        _codpracaprincipal = AlterarTipo<decimal?>(leitor["Codpracaprincipal"]);
        _distancia = AlterarTipo<decimal?>(leitor["Distancia"]);
        _dtcadastro = AlterarTipo<DateTime?>(leitor["Dtcadastro"]);
        _numregiao = AlterarTipo<decimal>(leitor["Numregiao"]);
        _numregiao2 = AlterarTipo<decimal?>(leitor["Numregiao2"]);
        _obs = AlterarTipo<string>(leitor["Obs"]);
        _percmincarreg = AlterarTipo<decimal?>(leitor["Percmincarreg"]);
        _perfreteprogress = AlterarTipo<decimal?>(leitor["Perfreteprogress"]);
        _populacao = AlterarTipo<decimal?>(leitor["Populacao"]);
        _praca = AlterarTipo<string>(leitor["Praca"]);
        _prioridadeentrega = AlterarTipo<string>(leitor["Prioridadeentrega"]);
        _rota = AlterarTipo<decimal>(leitor["Rota"]);
        _seqrota = AlterarTipo<decimal>(leitor["Seqrota"]);
        _situacao = AlterarTipo<string>(leitor["Situacao"]);
        _tipopraca = AlterarTipo<string>(leitor["Tipopraca"]);
        _vlmincarreg = AlterarTipo<decimal?>(leitor["Vlmincarreg"]);
        _vlpautafrete = AlterarTipo<decimal?>(leitor["Vlpautafrete"]);
    }

}