

////// namespace nwErp.Entidades.Winthor;

// namespace nwErp.Api.Modelos;

[Serializable]
public class PCTRIBPISCOFINS : GerenteDePropriedades, IEntidade
{
    private static readonly string RO_BASEPISCOFINSLIT = "Basepiscofinslit";

    private decimal? _basepiscofinslit;

    private static readonly string RO_CODTRIBPISCOFINS = "Codtribpiscofins";

    private decimal _codtribpiscofins;

    private static readonly string RO_CONSIDERADIFALIQ = "Consideradifaliq";

    private string _consideradifaliq;

    private static readonly string RO_CONSIDERADIFALIQUOTA = "Consideradifaliquota";

    private string _consideradifaliquota;

    private static readonly string RO_CONSIDERAFRETE = "Considerafrete";

    private string _considerafrete;

    private static readonly string RO_CONSIDERAIPI = "Consideraipi";

    private string _consideraipi;

    private static readonly string RO_CONSIDERAOUTRASDESP = "Consideraoutrasdesp";

    private string _consideraoutrasdesp;

    private static readonly string RO_CONSIDERAPAUTA = "Considerapauta";

    private string _considerapauta;

    private static readonly string RO_CONSIDERAPRECOMERC = "Consideraprecomerc";

    private string _consideraprecomerc;

    private static readonly string RO_CONSIDERAST = "Considerast";

    private string _considerast;

    private static readonly string RO_CONSIDERASUFRAMA = "Considerasuframa";

    private string _considerasuframa;

    private static readonly string RO_CONSIDERAVLFIXOLIT = "Consideravlfixolit";

    private string _consideravlfixolit;

    private static readonly string RO_DESCRICAOTRIBPISCOFINS = "Descricaotribpiscofins";

    private string _descricaotribpiscofins;

    private static readonly string RO_MENSAGEMCONSUMO = "Mensagemconsumo";

    private string _mensagemconsumo;

    private static readonly string RO_MENSAGEMGERAL = "Mensagemgeral";

    private string _mensagemgeral;

    private static readonly string RO_PERCCOFINS = "Perccofins";

    private decimal? _perccofins;

    private static readonly string RO_PERCCOFINSCALCDI = "Perccofinscalcdi";

    private decimal? _perccofinscalcdi;

    private static readonly string RO_PERCCOFINSCONSUMO = "Perccofinsconsumo";

    private decimal? _perccofinsconsumo;

    private static readonly string RO_PERCPIS = "Percpis";

    private decimal? _percpis;

    private static readonly string RO_PERCPISCALCDI = "Percpiscalcdi";

    private decimal? _percpiscalcdi;

    private static readonly string RO_PERCPISCONSUMO = "Percpisconsumo";

    private decimal? _percpisconsumo;

    private static readonly string RO_RETERPISCOFINS = "Reterpiscofins";

    private string _reterpiscofins;

    private static readonly string RO_SITTRIBUT = "Sittribut";

    private decimal? _sittribut;

    private static readonly string RO_SITTRIBUTCONSUMO = "Sittributconsumo";

    private decimal? _sittributconsumo;

    private static readonly string RO_SITTRIBUTCONSUMODEV = "Sittributconsumodev";

    private decimal? _sittributconsumodev;

    private static readonly string RO_SITTRIBUTDEV = "Sittributdev";

    private decimal? _sittributdev;

    private static readonly string RO_UTILIZAPERCPISCOFINSDIFCONS = "Utilizapercpiscofinsdifcons";

    private string _utilizapercpiscofinsdifcons;

    private static readonly string RO_VLCOFINSLIT = "Vlcofinslit";

    private decimal? _vlcofinslit;

    private static readonly string RO_VLPAUTACOFINS = "Vlpautacofins";

    private decimal? _vlpautacofins;

    private static readonly string RO_VLPAUTAPIS = "Vlpautapis";

    private decimal? _vlpautapis;

    private static readonly string RO_VLPISLIT = "Vlpislit";

    private decimal? _vlpislit;

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBPISCOFINS", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Basepiscofinslit
    {
        get
        {
            PropriedadeAcessada(RO_BASEPISCOFINSLIT);
            return _basepiscofinslit;
        }
        set
        {
            PropriedadeModificada(RO_BASEPISCOFINSLIT, value);
            _basepiscofinslit = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCTRIBPISCOFINS", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal Codtribpiscofins
    {
        get
        {
            PropriedadeAcessada(RO_CODTRIBPISCOFINS);
            return _codtribpiscofins;
        }
        set
        {
            PropriedadeModificada(RO_CODTRIBPISCOFINS, value);
            _codtribpiscofins = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBPISCOFINS", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Consideradifaliq
    {
        get
        {
            PropriedadeAcessada(RO_CONSIDERADIFALIQ);
            return _consideradifaliq;
        }
        set
        {
            PropriedadeModificada(RO_CONSIDERADIFALIQ, value);
            _consideradifaliq = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBPISCOFINS", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Consideradifaliquota
    {
        get
        {
            PropriedadeAcessada(RO_CONSIDERADIFALIQUOTA);
            return _consideradifaliquota;
        }
        set
        {
            PropriedadeModificada(RO_CONSIDERADIFALIQUOTA, value);
            _consideradifaliquota = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBPISCOFINS", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Considerafrete
    {
        get
        {
            PropriedadeAcessada(RO_CONSIDERAFRETE);
            return _considerafrete;
        }
        set
        {
            PropriedadeModificada(RO_CONSIDERAFRETE, value);
            _considerafrete = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBPISCOFINS", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Consideraipi
    {
        get
        {
            PropriedadeAcessada(RO_CONSIDERAIPI);
            return _consideraipi;
        }
        set
        {
            PropriedadeModificada(RO_CONSIDERAIPI, value);
            _consideraipi = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBPISCOFINS", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Consideraoutrasdesp
    {
        get
        {
            PropriedadeAcessada(RO_CONSIDERAOUTRASDESP);
            return _consideraoutrasdesp;
        }
        set
        {
            PropriedadeModificada(RO_CONSIDERAOUTRASDESP, value);
            _consideraoutrasdesp = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBPISCOFINS", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Considerapauta
    {
        get
        {
            PropriedadeAcessada(RO_CONSIDERAPAUTA);
            return _considerapauta;
        }
        set
        {
            PropriedadeModificada(RO_CONSIDERAPAUTA, value);
            _considerapauta = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBPISCOFINS", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Consideraprecomerc
    {
        get
        {
            PropriedadeAcessada(RO_CONSIDERAPRECOMERC);
            return _consideraprecomerc;
        }
        set
        {
            PropriedadeModificada(RO_CONSIDERAPRECOMERC, value);
            _consideraprecomerc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBPISCOFINS", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Considerast
    {
        get
        {
            PropriedadeAcessada(RO_CONSIDERAST);
            return _considerast;
        }
        set
        {
            PropriedadeModificada(RO_CONSIDERAST, value);
            _considerast = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBPISCOFINS", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Considerasuframa
    {
        get
        {
            PropriedadeAcessada(RO_CONSIDERASUFRAMA);
            return _considerasuframa;
        }
        set
        {
            PropriedadeModificada(RO_CONSIDERASUFRAMA, value);
            _considerasuframa = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBPISCOFINS", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Consideravlfixolit
    {
        get
        {
            PropriedadeAcessada(RO_CONSIDERAVLFIXOLIT);
            return _consideravlfixolit;
        }
        set
        {
            PropriedadeModificada(RO_CONSIDERAVLFIXOLIT, value);
            _consideravlfixolit = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBPISCOFINS", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
    public string Descricaotribpiscofins
    {
        get
        {
            PropriedadeAcessada(RO_DESCRICAOTRIBPISCOFINS);
            return _descricaotribpiscofins;
        }
        set
        {
            PropriedadeModificada(RO_DESCRICAOTRIBPISCOFINS, value);
            _descricaotribpiscofins = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBPISCOFINS", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 200, Precisao = 0)]
    public string Mensagemconsumo
    {
        get
        {
            PropriedadeAcessada(RO_MENSAGEMCONSUMO);
            return _mensagemconsumo;
        }
        set
        {
            PropriedadeModificada(RO_MENSAGEMCONSUMO, value);
            _mensagemconsumo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBPISCOFINS", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 200, Precisao = 0)]
    public string Mensagemgeral
    {
        get
        {
            PropriedadeAcessada(RO_MENSAGEMGERAL);
            return _mensagemgeral;
        }
        set
        {
            PropriedadeModificada(RO_MENSAGEMGERAL, value);
            _mensagemgeral = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBPISCOFINS", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Perccofins
    {
        get
        {
            PropriedadeAcessada(RO_PERCCOFINS);
            return _perccofins;
        }
        set
        {
            PropriedadeModificada(RO_PERCCOFINS, value);
            _perccofins = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBPISCOFINS", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 2)]
    public decimal? Perccofinscalcdi
    {
        get
        {
            PropriedadeAcessada(RO_PERCCOFINSCALCDI);
            return _perccofinscalcdi;
        }
        set
        {
            PropriedadeModificada(RO_PERCCOFINSCALCDI, value);
            _perccofinscalcdi = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBPISCOFINS", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Perccofinsconsumo
    {
        get
        {
            PropriedadeAcessada(RO_PERCCOFINSCONSUMO);
            return _perccofinsconsumo;
        }
        set
        {
            PropriedadeModificada(RO_PERCCOFINSCONSUMO, value);
            _perccofinsconsumo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBPISCOFINS", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Percpis
    {
        get
        {
            PropriedadeAcessada(RO_PERCPIS);
            return _percpis;
        }
        set
        {
            PropriedadeModificada(RO_PERCPIS, value);
            _percpis = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBPISCOFINS", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Percpiscalcdi
    {
        get
        {
            PropriedadeAcessada(RO_PERCPISCALCDI);
            return _percpiscalcdi;
        }
        set
        {
            PropriedadeModificada(RO_PERCPISCALCDI, value);
            _percpiscalcdi = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBPISCOFINS", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Percpisconsumo
    {
        get
        {
            PropriedadeAcessada(RO_PERCPISCONSUMO);
            return _percpisconsumo;
        }
        set
        {
            PropriedadeModificada(RO_PERCPISCONSUMO, value);
            _percpisconsumo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBPISCOFINS", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Reterpiscofins
    {
        get
        {
            PropriedadeAcessada(RO_RETERPISCOFINS);
            return _reterpiscofins;
        }
        set
        {
            PropriedadeModificada(RO_RETERPISCOFINS, value);
            _reterpiscofins = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBPISCOFINS", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Sittribut
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBPISCOFINS", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Sittributconsumo
    {
        get
        {
            PropriedadeAcessada(RO_SITTRIBUTCONSUMO);
            return _sittributconsumo;
        }
        set
        {
            PropriedadeModificada(RO_SITTRIBUTCONSUMO, value);
            _sittributconsumo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBPISCOFINS", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 3, Precisao = 0)]
    public decimal? Sittributconsumodev
    {
        get
        {
            PropriedadeAcessada(RO_SITTRIBUTCONSUMODEV);
            return _sittributconsumodev;
        }
        set
        {
            PropriedadeModificada(RO_SITTRIBUTCONSUMODEV, value);
            _sittributconsumodev = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBPISCOFINS", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 3, Precisao = 0)]
    public decimal? Sittributdev
    {
        get
        {
            PropriedadeAcessada(RO_SITTRIBUTDEV);
            return _sittributdev;
        }
        set
        {
            PropriedadeModificada(RO_SITTRIBUTDEV, value);
            _sittributdev = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBPISCOFINS", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Utilizapercpiscofinsdifcons
    {
        get
        {
            PropriedadeAcessada(RO_UTILIZAPERCPISCOFINSDIFCONS);
            return _utilizapercpiscofinsdifcons;
        }
        set
        {
            PropriedadeModificada(RO_UTILIZAPERCPISCOFINSDIFCONS, value);
            _utilizapercpiscofinsdifcons = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBPISCOFINS", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlcofinslit
    {
        get
        {
            PropriedadeAcessada(RO_VLCOFINSLIT);
            return _vlcofinslit;
        }
        set
        {
            PropriedadeModificada(RO_VLCOFINSLIT, value);
            _vlcofinslit = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBPISCOFINS", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlpautacofins
    {
        get
        {
            PropriedadeAcessada(RO_VLPAUTACOFINS);
            return _vlpautacofins;
        }
        set
        {
            PropriedadeModificada(RO_VLPAUTACOFINS, value);
            _vlpautacofins = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBPISCOFINS", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlpautapis
    {
        get
        {
            PropriedadeAcessada(RO_VLPAUTAPIS);
            return _vlpautapis;
        }
        set
        {
            PropriedadeModificada(RO_VLPAUTAPIS, value);
            _vlpautapis = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTRIBPISCOFINS", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlpislit
    {
        get
        {
            PropriedadeAcessada(RO_VLPISLIT);
            return _vlpislit;
        }
        set
        {
            PropriedadeModificada(RO_VLPISLIT, value);
            _vlpislit = value;
        }
    }

    public void InicializarAtributos()
    {
    }

    public string ObterNomeTabela()
    {
        return "PCTRIBPISCOFINS";
    }

    public IEntidade NovaInstancia()
    {
        return (IEntidade)GetType().GetConstructors()[0].Invoke(null);
    }

    public void CarregarPorDataReader(IDataReader leitor)
    {
        _basepiscofinslit = AlterarTipo<decimal?>(leitor["Basepiscofinslit"]);
        _codtribpiscofins = AlterarTipo<decimal>(leitor["Codtribpiscofins"]);
        _consideradifaliq = AlterarTipo<string>(leitor["Consideradifaliq"]);
        _consideradifaliquota = AlterarTipo<string>(leitor["Consideradifaliquota"]);
        _considerafrete = AlterarTipo<string>(leitor["Considerafrete"]);
        _consideraipi = AlterarTipo<string>(leitor["Consideraipi"]);
        _consideraoutrasdesp = AlterarTipo<string>(leitor["Consideraoutrasdesp"]);
        _considerapauta = AlterarTipo<string>(leitor["Considerapauta"]);
        _consideraprecomerc = AlterarTipo<string>(leitor["Consideraprecomerc"]);
        _considerast = AlterarTipo<string>(leitor["Considerast"]);
        _considerasuframa = AlterarTipo<string>(leitor["Considerasuframa"]);
        _consideravlfixolit = AlterarTipo<string>(leitor["Consideravlfixolit"]);
        _descricaotribpiscofins = AlterarTipo<string>(leitor["Descricaotribpiscofins"]);
        _mensagemconsumo = AlterarTipo<string>(leitor["Mensagemconsumo"]);
        _mensagemgeral = AlterarTipo<string>(leitor["Mensagemgeral"]);
        _perccofins = AlterarTipo<decimal?>(leitor["Perccofins"]);
        _perccofinscalcdi = AlterarTipo<decimal?>(leitor["Perccofinscalcdi"]);
        _perccofinsconsumo = AlterarTipo<decimal?>(leitor["Perccofinsconsumo"]);
        _percpis = AlterarTipo<decimal?>(leitor["Percpis"]);
        _percpiscalcdi = AlterarTipo<decimal?>(leitor["Percpiscalcdi"]);
        _percpisconsumo = AlterarTipo<decimal?>(leitor["Percpisconsumo"]);
        _reterpiscofins = AlterarTipo<string>(leitor["Reterpiscofins"]);
        _sittribut = AlterarTipo<decimal?>(leitor["Sittribut"]);
        _sittributconsumo = AlterarTipo<decimal?>(leitor["Sittributconsumo"]);
        _sittributconsumodev = AlterarTipo<decimal?>(leitor["Sittributconsumodev"]);
        _sittributdev = AlterarTipo<decimal?>(leitor["Sittributdev"]);
        _utilizapercpiscofinsdifcons = AlterarTipo<string>(leitor["Utilizapercpiscofinsdifcons"]);
        _vlcofinslit = AlterarTipo<decimal?>(leitor["Vlcofinslit"]);
        _vlpautacofins = AlterarTipo<decimal?>(leitor["Vlpautacofins"]);
        _vlpautapis = AlterarTipo<decimal?>(leitor["Vlpautapis"]);
        _vlpislit = AlterarTipo<decimal?>(leitor["Vlpislit"]);
    }

}