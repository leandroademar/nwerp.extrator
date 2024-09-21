[Serializable]
public class PCCNAE : GerenteDePropriedades, IEntidade
{
    private static readonly string RO_CODCNAE = "Codcnae";
    private string _codcnae;
    
    private static readonly string RO_DESCCNAE = "Desccnae";
    private string _desccnae;
    
    private static readonly string RO_CODATIV1 = "Codativ1";
    private int? _codativ1;
    
    private static readonly string RO_PERCARGATRIBMEDIA = "Percargatribmedia";
    private decimal? _percargatribmedia;
    
    private static readonly string RO_MARGEMMVA = "Margemmva";
    private decimal? _margemmva;
    
    private static readonly string RO_PERLIMVENDACNAE = "Perlimvendacnae";
    private decimal? _perlimvendacnae;
    
    private static readonly string RO_PERCFATMES = "Percfatmes";
    private decimal? _percfatmes;
    
    private static readonly string RO_FATMEDIOMENSAL = "Fatmediomensal";
    private decimal? _fatmediomensal;
    

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCCNAE", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string Codcnae
    {
        get
        {
            PropriedadeAcessada(RO_CODCNAE);
            return _codcnae;
        }
        set
        {
            PropriedadeModificada(RO_CODCNAE, value);
            _codcnae = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCNAE", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string Desccnae
    {
        get
        {
            PropriedadeAcessada(RO_DESCCNAE);
            return _desccnae;
        }
        set
        {
            PropriedadeModificada(RO_DESCCNAE, value);
            _desccnae = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCNAE", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 6, Precisao = 0)]
    public int? Codativ1
    {
        get
        {
            PropriedadeAcessada(RO_CODATIV1);
            return _codativ1;
        }
        set
        {
            PropriedadeModificada(RO_CODATIV1, value);
            _codativ1 = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCNAE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Percargatribmedia
    {
        get
        {
            PropriedadeAcessada(RO_PERCARGATRIBMEDIA);
            return _percargatribmedia;
        }
        set
        {
            PropriedadeModificada(RO_PERCARGATRIBMEDIA, value);
            _percargatribmedia = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCNAE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Margemmva
    {
        get
        {
            PropriedadeAcessada(RO_MARGEMMVA);
            return _margemmva;
        }
        set
        {
            PropriedadeModificada(RO_MARGEMMVA, value);
            _margemmva = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCNAE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Perlimvendacnae
    {
        get
        {
            PropriedadeAcessada(RO_PERLIMVENDACNAE);
            return _perlimvendacnae;
        }
        set
        {
            PropriedadeModificada(RO_PERLIMVENDACNAE, value);
            _perlimvendacnae = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCNAE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 2)]
    public decimal? Percfatmes
    {
        get
        {
            PropriedadeAcessada(RO_PERCFATMES);
            return _percfatmes;
        }
        set
        {
            PropriedadeModificada(RO_PERCFATMES, value);
            _percfatmes = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCNAE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 2)]
    public decimal? Fatmediomensal
    {
        get
        {
            PropriedadeAcessada(RO_FATMEDIOMENSAL);
            return _fatmediomensal;
        }
        set
        {
            PropriedadeModificada(RO_FATMEDIOMENSAL, value);
            _fatmediomensal = value;
        }
    }

    public void InicializarAtributos() { }

    public string ObterNomeTabela() => "PCCNAE";

    public IEntidade NovaInstancia() => (IEntidade)GetType().GetConstructors()[0].Invoke(null);

    public void CarregarPorDataReader(IDataReader leitor)
    {
        _codcnae = AlterarTipo<string>(leitor["Codcnae"]);
        _desccnae = AlterarTipo<string>(leitor["Desccnae"]);
        _codativ1 = AlterarTipo<int?>(leitor["Codativ1"]);
        _percargatribmedia = AlterarTipo<decimal?>(leitor["Percargatribmedia"]);
        _margemmva = AlterarTipo<decimal?>(leitor["Margemmva"]);
        _perlimvendacnae = AlterarTipo<decimal?>(leitor["Perlimvendacnae"]);
        _percfatmes = AlterarTipo<decimal?>(leitor["Percfatmes"]);
        _fatmediomensal = AlterarTipo<decimal?>(leitor["Fatmediomensal"]);
    }
}