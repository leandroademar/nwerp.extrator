

////// // namespace nwErp.Entidades.Winthor;

// // namespace nwErp.Api.Modelos;

[Serializable]
public class PCDEVCONSUM : GerenteDePropriedades, IEntidade
{
    private static readonly string RO_BAIRRO = "Bairro";

    private string _bairro;

    private static readonly string RO_CEP = "Cep";

    private string _cep;

    private static readonly string RO_CGC = "Cgc";

    private string _cgc;

    private static readonly string RO_CIDADE = "Cidade";

    private string _cidade;

    private static readonly string RO_CLIENTE = "Cliente";

    private string _cliente;

    private static readonly string RO_CODCIDADE = "Codcidade";

    private decimal? _codcidade;

    private static readonly string RO_EMAIL = "Email";

    private string _email;

    private static readonly string RO_ENDERECO = "Endereco";

    private string _endereco;

    private static readonly string RO_IE = "Ie";

    private string _ie;

    private static readonly string RO_NUMERO = "Numero";

    private string _numero;

    private static readonly string RO_NUMTRANSENT = "Numtransent";

    private decimal _numtransent;

    private static readonly string RO_OBS = "Obs";

    private string _obs;

    private static readonly string RO_TELEFONE = "Telefone";

    private string _telefone;

    private static readonly string RO_UF = "Uf";

    private string _uf;

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCDEVCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
    public string Bairro
    {
        get
        {
            PropriedadeAcessada(RO_BAIRRO);
            return _bairro;
        }
        set
        {
            PropriedadeModificada(RO_BAIRRO, value);
            _bairro = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCDEVCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 9, Precisao = 0)]
    public string Cep
    {
        get
        {
            PropriedadeAcessada(RO_CEP);
            return _cep;
        }
        set
        {
            PropriedadeModificada(RO_CEP, value);
            _cep = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCDEVCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 18, Precisao = 0)]
    public string Cgc
    {
        get
        {
            PropriedadeAcessada(RO_CGC);
            return _cgc;
        }
        set
        {
            PropriedadeModificada(RO_CGC, value);
            _cgc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCDEVCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 15, Precisao = 0)]
    public string Cidade
    {
        get
        {
            PropriedadeAcessada(RO_CIDADE);
            return _cidade;
        }
        set
        {
            PropriedadeModificada(RO_CIDADE, value);
            _cidade = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCDEVCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
    public string Cliente
    {
        get
        {
            PropriedadeAcessada(RO_CLIENTE);
            return _cliente;
        }
        set
        {
            PropriedadeModificada(RO_CLIENTE, value);
            _cliente = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCDEVCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codcidade
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCDEVCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 100, Precisao = 0)]
    public string Email
    {
        get
        {
            PropriedadeAcessada(RO_EMAIL);
            return _email;
        }
        set
        {
            PropriedadeModificada(RO_EMAIL, value);
            _email = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCDEVCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
    public string Endereco
    {
        get
        {
            PropriedadeAcessada(RO_ENDERECO);
            return _endereco;
        }
        set
        {
            PropriedadeModificada(RO_ENDERECO, value);
            _endereco = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCDEVCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 15, Precisao = 0)]
    public string Ie
    {
        get
        {
            PropriedadeAcessada(RO_IE);
            return _ie;
        }
        set
        {
            PropriedadeModificada(RO_IE, value);
            _ie = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCDEVCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 6, Precisao = 0)]
    public string Numero
    {
        get
        {
            PropriedadeAcessada(RO_NUMERO);
            return _numero;
        }
        set
        {
            PropriedadeModificada(RO_NUMERO, value);
            _numero = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCDEVCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal Numtransent
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCDEVCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 100, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCDEVCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 13, Precisao = 0)]
    public string Telefone
    {
        get
        {
            PropriedadeAcessada(RO_TELEFONE);
            return _telefone;
        }
        set
        {
            PropriedadeModificada(RO_TELEFONE, value);
            _telefone = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCDEVCONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Uf
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

    public void InicializarAtributos()
    {
    }

    public string ObterNomeTabela()
    {
        return "PCDEVCONSUM";
    }

    public IEntidade NovaInstancia()
    {
        return (IEntidade)GetType().GetConstructors()[0].Invoke(null);
    }

    public void CarregarPorDataReader(IDataReader leitor)
    {
        _bairro = AlterarTipo<string>(leitor["Bairro"]);
        _cep = AlterarTipo<string>(leitor["Cep"]);
        _cgc = AlterarTipo<string>(leitor["Cgc"]);
        _cidade = AlterarTipo<string>(leitor["Cidade"]);
        _cliente = AlterarTipo<string>(leitor["Cliente"]);
        _codcidade = AlterarTipo<decimal?>(leitor["Codcidade"]);
        _email = AlterarTipo<string>(leitor["Email"]);
        _endereco = AlterarTipo<string>(leitor["Endereco"]);
        _ie = AlterarTipo<string>(leitor["Ie"]);
        _numero = AlterarTipo<string>(leitor["Numero"]);
        _numtransent = AlterarTipo<decimal>(leitor["Numtransent"]);
        _obs = AlterarTipo<string>(leitor["Obs"]);
        _telefone = AlterarTipo<string>(leitor["Telefone"]);
        _uf = AlterarTipo<string>(leitor["Uf"]);
    }

}