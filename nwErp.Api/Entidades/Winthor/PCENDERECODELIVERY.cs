

////// // namespace nwErp.Entidades.Caixa;

// // namespace nwErp.Api.Modelos;

[Serializable]
public class PCENDERECODELIVERY : GerenteDePropriedades, IEntidade
{
    private static readonly string RO_BAIRRO = "Bairro";

    private string _bairro;

    private static readonly string RO_CEP = "Cep";

    private string _cep;

    private static readonly string RO_CIDADE = "Cidade";

    private string _cidade;

    private static readonly string RO_CODBAIRRODELIV = "Codbairrodeliv";

    private decimal? _codbairrodeliv;

    private static readonly string RO_CODFUNCCX = "Codfunccx";

    private decimal _codfunccx;

    private static readonly string RO_CODVEICULO = "Codveiculo";

    private decimal? _codveiculo;

    private static readonly string RO_COMPLEMENTO = "Complemento";

    private string _complemento;

    private static readonly string RO_CPFCNPJ = "Cpfcnpj";

    private string _cpfcnpj;

    private static readonly string RO_EMBALADOR = "Embalador";

    private string _embalador;

    private static readonly string RO_ESTADO = "Estado";

    private string _estado;

    private static readonly string RO_HORATENTATIVA = "Horatentativa";

    private string _horatentativa;

    private static readonly string RO_LOGRADOURO = "Logradouro";

    private string _logradouro;

    private static readonly string RO_MATRICULAMOTORISTA = "Matriculamotorista";

    private decimal? _matriculamotorista;

    private static readonly string RO_NOMECLIENTE = "Nomecliente";

    private string _nomecliente;

    private static readonly string RO_NUMCAIXA = "Numcaixa";

    private decimal _numcaixa;

    private static readonly string RO_NUMCAIXAS = "Numcaixas";

    private string _numcaixas;

    private static readonly string RO_NUMCAR = "Numcar";

    private decimal? _numcar;

    private static readonly string RO_NUMERO = "Numero";

    private string _numero;

    private static readonly string RO_NUMPEDECF = "Numpedecf";

    private decimal _numpedecf;

    private static readonly string RO_OBS = "Obs";

    private string _obs;

    private static readonly string RO_QTCAIXAS = "Qtcaixas";

    private decimal? _qtcaixas;

    private static readonly string RO_QTVOLCONG = "Qtvolcong";

    private decimal? _qtvolcong;

    private static readonly string RO_QTVOLRESF = "Qtvolresf";

    private decimal? _qtvolresf;

    private static readonly string RO_REFERENCIA = "Referencia";

    private string _referencia;

    private static readonly string RO_SITUACAO = "Situacao";

    private string _situacao;

    private static readonly string RO_TELEFONE = "Telefone";

    private string _telefone;

    private static readonly string RO_EXPORTADO = "Exportado";

    private string _exportado;

    private static readonly string RO_PERIODODIAENTREGA = "Periododiaentrega";

    private string _periododiaentrega;

    private static readonly string RO_DATAENTREGA = "Dataentrega";

    private DateTime? _dataentrega;

    private static readonly string RO_CODCIDADE = "Codcidade";

    private decimal? _codcidade;

    private static readonly string RO_EMAIL = "Email";

    private string _email;

    private static readonly string RO_IE = "Ie";

    private string _ie;

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCENDERECODELIVERY", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCENDERECODELIVERY", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 9, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCENDERECODELIVERY", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCENDERECODELIVERY", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codbairrodeliv
    {
        get
        {
            PropriedadeAcessada(RO_CODBAIRRODELIV);
            return _codbairrodeliv;
        }
        set
        {
            PropriedadeModificada(RO_CODBAIRRODELIV, value);
            _codbairrodeliv = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCENDERECODELIVERY", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal Codfunccx
    {
        get
        {
            PropriedadeAcessada(RO_CODFUNCCX);
            return _codfunccx;
        }
        set
        {
            PropriedadeModificada(RO_CODFUNCCX, value);
            _codfunccx = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCENDERECODELIVERY", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Codveiculo
    {
        get
        {
            PropriedadeAcessada(RO_CODVEICULO);
            return _codveiculo;
        }
        set
        {
            PropriedadeModificada(RO_CODVEICULO, value);
            _codveiculo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCENDERECODELIVERY", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
    public string Complemento
    {
        get
        {
            PropriedadeAcessada(RO_COMPLEMENTO);
            return _complemento;
        }
        set
        {
            PropriedadeModificada(RO_COMPLEMENTO, value);
            _complemento = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCENDERECODELIVERY", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 18, Precisao = 0)]
    public string Cpfcnpj
    {
        get
        {
            PropriedadeAcessada(RO_CPFCNPJ);
            return _cpfcnpj;
        }
        set
        {
            PropriedadeModificada(RO_CPFCNPJ, value);
            _cpfcnpj = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCENDERECODELIVERY", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 30, Precisao = 0)]
    public string Embalador
    {
        get
        {
            PropriedadeAcessada(RO_EMBALADOR);
            return _embalador;
        }
        set
        {
            PropriedadeModificada(RO_EMBALADOR, value);
            _embalador = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCENDERECODELIVERY", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Estado
    {
        get
        {
            PropriedadeAcessada(RO_ESTADO);
            return _estado;
        }
        set
        {
            PropriedadeModificada(RO_ESTADO, value);
            _estado = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCENDERECODELIVERY", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 5, Precisao = 0)]
    public string Horatentativa
    {
        get
        {
            PropriedadeAcessada(RO_HORATENTATIVA);
            return _horatentativa;
        }
        set
        {
            PropriedadeModificada(RO_HORATENTATIVA, value);
            _horatentativa = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCENDERECODELIVERY", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
    public string Logradouro
    {
        get
        {
            PropriedadeAcessada(RO_LOGRADOURO);
            return _logradouro;
        }
        set
        {
            PropriedadeModificada(RO_LOGRADOURO, value);
            _logradouro = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCENDERECODELIVERY", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Matriculamotorista
    {
        get
        {
            PropriedadeAcessada(RO_MATRICULAMOTORISTA);
            return _matriculamotorista;
        }
        set
        {
            PropriedadeModificada(RO_MATRICULAMOTORISTA, value);
            _matriculamotorista = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCENDERECODELIVERY", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 60, Precisao = 0)]
    public string Nomecliente
    {
        get
        {
            PropriedadeAcessada(RO_NOMECLIENTE);
            return _nomecliente;
        }
        set
        {
            PropriedadeModificada(RO_NOMECLIENTE, value);
            _nomecliente = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCENDERECODELIVERY", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal Numcaixa
    {
        get
        {
            PropriedadeAcessada(RO_NUMCAIXA);
            return _numcaixa;
        }
        set
        {
            PropriedadeModificada(RO_NUMCAIXA, value);
            _numcaixa = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCENDERECODELIVERY", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 200, Precisao = 0)]
    public string Numcaixas
    {
        get
        {
            PropriedadeAcessada(RO_NUMCAIXAS);
            return _numcaixas;
        }
        set
        {
            PropriedadeModificada(RO_NUMCAIXAS, value);
            _numcaixas = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCENDERECODELIVERY", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Numcar
    {
        get
        {
            PropriedadeAcessada(RO_NUMCAR);
            return _numcar;
        }
        set
        {
            PropriedadeModificada(RO_NUMCAR, value);
            _numcar = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCENDERECODELIVERY", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 6, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCENDERECODELIVERY", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal Numpedecf
    {
        get
        {
            PropriedadeAcessada(RO_NUMPEDECF);
            return _numpedecf;
        }
        set
        {
            PropriedadeModificada(RO_NUMPEDECF, value);
            _numpedecf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCENDERECODELIVERY", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 400, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCENDERECODELIVERY", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 3, Precisao = 0)]
    public decimal? Qtcaixas
    {
        get
        {
            PropriedadeAcessada(RO_QTCAIXAS);
            return _qtcaixas;
        }
        set
        {
            PropriedadeModificada(RO_QTCAIXAS, value);
            _qtcaixas = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCENDERECODELIVERY", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 3, Precisao = 0)]
    public decimal? Qtvolcong
    {
        get
        {
            PropriedadeAcessada(RO_QTVOLCONG);
            return _qtvolcong;
        }
        set
        {
            PropriedadeModificada(RO_QTVOLCONG, value);
            _qtvolcong = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCENDERECODELIVERY", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 3, Precisao = 0)]
    public decimal? Qtvolresf
    {
        get
        {
            PropriedadeAcessada(RO_QTVOLRESF);
            return _qtvolresf;
        }
        set
        {
            PropriedadeModificada(RO_QTVOLRESF, value);
            _qtvolresf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCENDERECODELIVERY", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 100, Precisao = 0)]
    public string Referencia
    {
        get
        {
            PropriedadeAcessada(RO_REFERENCIA);
            return _referencia;
        }
        set
        {
            PropriedadeModificada(RO_REFERENCIA, value);
            _referencia = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCENDERECODELIVERY", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCENDERECODELIVERY", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCENDERECODELIVERY", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Exportado
    {
        get
        {
            PropriedadeAcessada(RO_EXPORTADO);
            return _exportado;
        }
        set
        {
            PropriedadeModificada(RO_EXPORTADO, value);
            _exportado = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCENDERECODELIVERY", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Periododiaentrega
    {
        get
        {
            PropriedadeAcessada(RO_PERIODODIAENTREGA);
            return _periododiaentrega;
        }
        set
        {
            PropriedadeModificada(RO_PERIODODIAENTREGA, value);
            _periododiaentrega = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCENDERECODELIVERY", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dataentrega
    {
        get
        {
            PropriedadeAcessada(RO_DATAENTREGA);
            return _dataentrega;
        }
        set
        {
            PropriedadeModificada(RO_DATAENTREGA, value);
            _dataentrega = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCENDERECODELIVERY", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCENDERECODELIVERY", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 60, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCENDERECODELIVERY", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 15, Precisao = 0)]
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

    public void InicializarAtributos()
    {
    }

    public string ObterNomeTabela()
    {
        return "PCENDERECODELIVERY";
    }

    public IEntidade NovaInstancia()
    {
        return (IEntidade)GetType().GetConstructors()[0].Invoke(null);
    }

    public void CarregarPorDataReader(IDataReader leitor)
    {
        _bairro = AlterarTipo<string>(leitor["Bairro"]);
        _cep = AlterarTipo<string>(leitor["Cep"]);
        _cidade = AlterarTipo<string>(leitor["Cidade"]);
        _codbairrodeliv = AlterarTipo<decimal?>(leitor["Codbairrodeliv"]);
        _codfunccx = AlterarTipo<decimal>(leitor["Codfunccx"]);
        _codveiculo = AlterarTipo<decimal?>(leitor["Codveiculo"]);
        _complemento = AlterarTipo<string>(leitor["Complemento"]);
        _cpfcnpj = AlterarTipo<string>(leitor["Cpfcnpj"]);
        _embalador = AlterarTipo<string>(leitor["Embalador"]);
        _estado = AlterarTipo<string>(leitor["Estado"]);
        _horatentativa = AlterarTipo<string>(leitor["Horatentativa"]);
        _logradouro = AlterarTipo<string>(leitor["Logradouro"]);
        _matriculamotorista = AlterarTipo<decimal?>(leitor["Matriculamotorista"]);
        _nomecliente = AlterarTipo<string>(leitor["Nomecliente"]);
        _numcaixa = AlterarTipo<decimal>(leitor["Numcaixa"]);
        _numcaixas = AlterarTipo<string>(leitor["Numcaixas"]);
        _numcar = AlterarTipo<decimal?>(leitor["Numcar"]);
        _numero = AlterarTipo<string>(leitor["Numero"]);
        _numpedecf = AlterarTipo<decimal>(leitor["Numpedecf"]);
        _obs = AlterarTipo<string>(leitor["Obs"]);
        _qtcaixas = AlterarTipo<decimal?>(leitor["Qtcaixas"]);
        _qtvolcong = AlterarTipo<decimal?>(leitor["Qtvolcong"]);
        _qtvolresf = AlterarTipo<decimal?>(leitor["Qtvolresf"]);
        _referencia = AlterarTipo<string>(leitor["Referencia"]);
        _situacao = AlterarTipo<string>(leitor["Situacao"]);
        _telefone = AlterarTipo<string>(leitor["Telefone"]);
        _exportado = AlterarTipo<string>(leitor["Exportado"]);
        _periododiaentrega = AlterarTipo<string>(leitor["Periododiaentrega"]);
        _dataentrega = AlterarTipo<DateTime?>(leitor["Dataentrega"]);
        _codcidade = AlterarTipo<decimal?>(leitor["Codcidade"]);
        _email = AlterarTipo<string>(leitor["Email"]);
        _ie = AlterarTipo<string>(leitor["Ie"]);
    }

	
}