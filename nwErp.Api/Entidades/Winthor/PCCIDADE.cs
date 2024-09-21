[Serializable]
public class PCCIDADE : GerenteDePropriedades, IEntidade
{
    private static readonly string RO_CODCIDADE = "Codcidade";
    private int _codcidade;
    
    private static readonly string RO_NOMECIDADE = "Nomecidade";
    private string? _nomecidade;
    
    private static readonly string RO_CODIBGE = "Codibge";
    private int? _codibge;
    
    private static readonly string RO_UF = "Uf";
    private string? _uf;
    
    private static readonly string RO_POPULACAO = "Populacao";
    private int? _populacao;
    
    private static readonly string RO_CODMUNESTADUAL = "Codmunestadual";
    private int? _codmunestadual;
    
    private static readonly string RO_UTILIZAFRETETRANSP = "Utilizafretetransp";
    private string? _utilizafretetransp;
    
    private static readonly string RO_CODMUNSIAFI = "Codmunsiafi";
    private int? _codmunsiafi;
    
    private static readonly string RO_LATITUDE = "Latitude";
    private string? _latitude;
    
    private static readonly string RO_LONGITUDE = "Longitude";
    private string? _longitude;
    

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCCIDADE", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 6, Precisao = 0)]
    public int Codcidade
    {
        get
        {
            PropriedadeAcessada(RO_CODCIDADE);
            return _codcidade;
        }
        set
        {
            PropriedadeModificada(RO_CODCIDADE, value);
            _codcidade = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCIDADE", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Nomecidade
    {
        get
        {
            PropriedadeAcessada(RO_NOMECIDADE);
            return _nomecidade;
        }
        set
        {
            PropriedadeModificada(RO_NOMECIDADE, value);
            _nomecidade = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCIDADE", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 10, Precisao = 0)]
    public int? Codibge
    {
        get
        {
            PropriedadeAcessada(RO_CODIBGE);
            return _codibge;
        }
        set
        {
            PropriedadeModificada(RO_CODIBGE, value);
            _codibge = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCIDADE", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Uf
    {
        get
        {
            PropriedadeAcessada(RO_UF);
            return _uf;
        }
        set
        {
            PropriedadeModificada(RO_UF, value);
            _uf = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCIDADE", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 8, Precisao = 0)]
    public int? Populacao
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
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCIDADE", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 8, Precisao = 0)]
    public int? Codmunestadual
    {
        get
        {
            PropriedadeAcessada(RO_CODMUNESTADUAL);
            return _codmunestadual;
        }
        set
        {
            PropriedadeModificada(RO_CODMUNESTADUAL, value);
            _codmunestadual = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCIDADE", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Utilizafretetransp
    {
        get
        {
            PropriedadeAcessada(RO_UTILIZAFRETETRANSP);
            return _utilizafretetransp;
        }
        set
        {
            PropriedadeModificada(RO_UTILIZAFRETETRANSP, value);
            _utilizafretetransp = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCIDADE", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 10, Precisao = 0)]
    public int? Codmunsiafi
    {
        get
        {
            PropriedadeAcessada(RO_CODMUNSIAFI);
            return _codmunsiafi;
        }
        set
        {
            PropriedadeModificada(RO_CODMUNSIAFI, value);
            _codmunsiafi = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCIDADE", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Latitude
    {
        get
        {
            PropriedadeAcessada(RO_LATITUDE);
            return _latitude;
        }
        set
        {
            PropriedadeModificada(RO_LATITUDE, value);
            _latitude = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCIDADE", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Longitude
    {
        get
        {
            PropriedadeAcessada(RO_LONGITUDE);
            return _longitude;
        }
        set
        {
            PropriedadeModificada(RO_LONGITUDE, value);
            _longitude = value;
        }
    }

    public void InicializarAtributos() { }

    public string ObterNomeTabela() => "PCCIDADE";

    public IEntidade NovaInstancia() => (IEntidade)GetType().GetConstructors()[0].Invoke(null);

    public void CarregarPorDataReader(IDataReader leitor)
    {
        _codcidade = AlterarTipo<int>(leitor["Codcidade"]);
        _nomecidade = AlterarTipo<string?>(leitor["Nomecidade"]);
        _codibge = AlterarTipo<int?>(leitor["Codibge"]);
        _uf = AlterarTipo<string?>(leitor["Uf"]);
        _populacao = AlterarTipo<int?>(leitor["Populacao"]);
        _codmunestadual = AlterarTipo<int?>(leitor["Codmunestadual"]);
        _utilizafretetransp = AlterarTipo<string?>(leitor["Utilizafretetransp"]);
        _codmunsiafi = AlterarTipo<int?>(leitor["Codmunsiafi"]);
        _latitude = AlterarTipo<string?>(leitor["Latitude"]);
        _longitude = AlterarTipo<string?>(leitor["Longitude"]);
    }
}