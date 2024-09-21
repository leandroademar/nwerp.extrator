[Serializable]
public class PCCONTA : GerenteDePropriedades, IEntidade
{
    private static readonly string RO_CODCONTA = "Codconta";
    private int _codconta;
    
    private static readonly string RO_CONTA = "Conta";
    private string _conta;
    
    private static readonly string RO_GRUPOCONTA = "Grupoconta";
    private int _grupoconta;
    
    private static readonly string RO_CODCONTAMASTER = "Codcontamaster";
    private int? _codcontamaster;
    
    private static readonly string RO_TIPO = "Tipo";
    private string? _tipo;
    
    private static readonly string RO_INVESTIMENTO = "Investimento";
    private string _investimento;
    
    private static readonly string RO_BONIFIC = "Bonific";
    private string? _bonific;
    
    private static readonly string RO_VLORCAMES = "Vlorcames";
    private decimal? _vlorcames;
    
    private static readonly string RO_FIXAVARIAVEL = "Fixavariavel";
    private string? _fixavariavel;
    
    private static readonly string RO_GERAPROVLANCCONTAB = "Geraprovlanccontab";
    private string? _geraprovlanccontab;
    
    private static readonly string RO_CODCONTACONTRAPARTIDA = "Codcontacontrapartida";
    private int? _codcontacontrapartida;
    
    private static readonly string RO_USARATEIOCENTROCUSTO = "Usarateiocentrocusto";
    private string _usarateiocentrocusto;
    
    private static readonly string RO_CODCENTROCUSTOPADRAO = "Codcentrocustopadrao";
    private int? _codcentrocustopadrao;
    
    private static readonly string RO_VERBA = "Verba";
    private string? _verba;
    
    private static readonly string RO_CONTACONTABIL = "Contacontabil";
    private string? _contacontabil;
    
    private static readonly string RO_CODEVENTOINTFOLHA = "Codeventointfolha";
    private string? _codeventointfolha;
    
    private static readonly string RO_CODSECAOINTFOLHA = "Codsecaointfolha";
    private string? _codsecaointfolha;
    
    private static readonly string RO_RESTRINGIRNOBALANCETE = "Restringirnobalancete";
    private string? _restringirnobalancete;
    
    private static readonly string RO_UTILIZACENTROCUSTORESTRITO = "Utilizacentrocustorestrito";
    private string? _utilizacentrocustorestrito;
    
    private static readonly string RO_PRESTACAODECONTAS = "Prestacaodecontas";
    private string? _prestacaodecontas;
    

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCCONTA", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 10, Precisao = 0)]
    public int Codconta
    {
        get
        {
            PropriedadeAcessada(RO_CODCONTA);
            return _codconta;
        }
        set
        {
            PropriedadeModificada(RO_CODCONTA, value);
            _codconta = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONTA", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string Conta
    {
        get
        {
            PropriedadeAcessada(RO_CONTA);
            return _conta;
        }
        set
        {
            PropriedadeModificada(RO_CONTA, value);
            _conta = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONTA", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 4, Precisao = 0)]
    public int Grupoconta
    {
        get
        {
            PropriedadeAcessada(RO_GRUPOCONTA);
            return _grupoconta;
        }
        set
        {
            PropriedadeModificada(RO_GRUPOCONTA, value);
            _grupoconta = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONTA", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 10, Precisao = 0)]
    public int? Codcontamaster
    {
        get
        {
            PropriedadeAcessada(RO_CODCONTAMASTER);
            return _codcontamaster;
        }
        set
        {
            PropriedadeModificada(RO_CODCONTAMASTER, value);
            _codcontamaster = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONTA", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Tipo
    {
        get
        {
            PropriedadeAcessada(RO_TIPO);
            return _tipo;
        }
        set
        {
            PropriedadeModificada(RO_TIPO, value);
            _tipo = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONTA", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string Investimento
    {
        get
        {
            PropriedadeAcessada(RO_INVESTIMENTO);
            return _investimento;
        }
        set
        {
            PropriedadeModificada(RO_INVESTIMENTO, value);
            _investimento = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONTA", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Bonific
    {
        get
        {
            PropriedadeAcessada(RO_BONIFIC);
            return _bonific;
        }
        set
        {
            PropriedadeModificada(RO_BONIFIC, value);
            _bonific = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 2)]
    public decimal? Vlorcames
    {
        get
        {
            PropriedadeAcessada(RO_VLORCAMES);
            return _vlorcames;
        }
        set
        {
            PropriedadeModificada(RO_VLORCAMES, value);
            _vlorcames = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONTA", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Fixavariavel
    {
        get
        {
            PropriedadeAcessada(RO_FIXAVARIAVEL);
            return _fixavariavel;
        }
        set
        {
            PropriedadeModificada(RO_FIXAVARIAVEL, value);
            _fixavariavel = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONTA", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Geraprovlanccontab
    {
        get
        {
            PropriedadeAcessada(RO_GERAPROVLANCCONTAB);
            return _geraprovlanccontab;
        }
        set
        {
            PropriedadeModificada(RO_GERAPROVLANCCONTAB, value);
            _geraprovlanccontab = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONTA", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 10, Precisao = 0)]
    public int? Codcontacontrapartida
    {
        get
        {
            PropriedadeAcessada(RO_CODCONTACONTRAPARTIDA);
            return _codcontacontrapartida;
        }
        set
        {
            PropriedadeModificada(RO_CODCONTACONTRAPARTIDA, value);
            _codcontacontrapartida = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONTA", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string Usarateiocentrocusto
    {
        get
        {
            PropriedadeAcessada(RO_USARATEIOCENTROCUSTO);
            return _usarateiocentrocusto;
        }
        set
        {
            PropriedadeModificada(RO_USARATEIOCENTROCUSTO, value);
            _usarateiocentrocusto = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONTA", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 10, Precisao = 0)]
    public int? Codcentrocustopadrao
    {
        get
        {
            PropriedadeAcessada(RO_CODCENTROCUSTOPADRAO);
            return _codcentrocustopadrao;
        }
        set
        {
            PropriedadeModificada(RO_CODCENTROCUSTOPADRAO, value);
            _codcentrocustopadrao = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONTA", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Verba
    {
        get
        {
            PropriedadeAcessada(RO_VERBA);
            return _verba;
        }
        set
        {
            PropriedadeModificada(RO_VERBA, value);
            _verba = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONTA", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Contacontabil
    {
        get
        {
            PropriedadeAcessada(RO_CONTACONTABIL);
            return _contacontabil;
        }
        set
        {
            PropriedadeModificada(RO_CONTACONTABIL, value);
            _contacontabil = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONTA", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Codeventointfolha
    {
        get
        {
            PropriedadeAcessada(RO_CODEVENTOINTFOLHA);
            return _codeventointfolha;
        }
        set
        {
            PropriedadeModificada(RO_CODEVENTOINTFOLHA, value);
            _codeventointfolha = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONTA", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Codsecaointfolha
    {
        get
        {
            PropriedadeAcessada(RO_CODSECAOINTFOLHA);
            return _codsecaointfolha;
        }
        set
        {
            PropriedadeModificada(RO_CODSECAOINTFOLHA, value);
            _codsecaointfolha = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONTA", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Restringirnobalancete
    {
        get
        {
            PropriedadeAcessada(RO_RESTRINGIRNOBALANCETE);
            return _restringirnobalancete;
        }
        set
        {
            PropriedadeModificada(RO_RESTRINGIRNOBALANCETE, value);
            _restringirnobalancete = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONTA", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Utilizacentrocustorestrito
    {
        get
        {
            PropriedadeAcessada(RO_UTILIZACENTROCUSTORESTRITO);
            return _utilizacentrocustorestrito;
        }
        set
        {
            PropriedadeModificada(RO_UTILIZACENTROCUSTORESTRITO, value);
            _utilizacentrocustorestrito = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCONTA", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Prestacaodecontas
    {
        get
        {
            PropriedadeAcessada(RO_PRESTACAODECONTAS);
            return _prestacaodecontas;
        }
        set
        {
            PropriedadeModificada(RO_PRESTACAODECONTAS, value);
            _prestacaodecontas = value;
        }
    }

    public void InicializarAtributos() { }

    public string ObterNomeTabela() => "PCCONTA";

    public IEntidade NovaInstancia() => (IEntidade)GetType().GetConstructors()[0].Invoke(null);

    public void CarregarPorDataReader(IDataReader leitor)
    {
        _codconta = AlterarTipo<int>(leitor["Codconta"]);
        _conta = AlterarTipo<string>(leitor["Conta"]);
        _grupoconta = AlterarTipo<int>(leitor["Grupoconta"]);
        _codcontamaster = AlterarTipo<int?>(leitor["Codcontamaster"]);
        _tipo = AlterarTipo<string?>(leitor["Tipo"]);
        _investimento = AlterarTipo<string>(leitor["Investimento"]);
        _bonific = AlterarTipo<string?>(leitor["Bonific"]);
        _vlorcames = AlterarTipo<decimal?>(leitor["Vlorcames"]);
        _fixavariavel = AlterarTipo<string?>(leitor["Fixavariavel"]);
        _geraprovlanccontab = AlterarTipo<string?>(leitor["Geraprovlanccontab"]);
        _codcontacontrapartida = AlterarTipo<int?>(leitor["Codcontacontrapartida"]);
        _usarateiocentrocusto = AlterarTipo<string>(leitor["Usarateiocentrocusto"]);
        _codcentrocustopadrao = AlterarTipo<int?>(leitor["Codcentrocustopadrao"]);
        _verba = AlterarTipo<string?>(leitor["Verba"]);
        _contacontabil = AlterarTipo<string?>(leitor["Contacontabil"]);
        _codeventointfolha = AlterarTipo<string?>(leitor["Codeventointfolha"]);
        _codsecaointfolha = AlterarTipo<string?>(leitor["Codsecaointfolha"]);
        _restringirnobalancete = AlterarTipo<string?>(leitor["Restringirnobalancete"]);
        _utilizacentrocustorestrito = AlterarTipo<string?>(leitor["Utilizacentrocustorestrito"]);
        _prestacaodecontas = AlterarTipo<string?>(leitor["Prestacaodecontas"]);
    }
}