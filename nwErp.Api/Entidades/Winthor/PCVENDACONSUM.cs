

////// namespace nwErp.Entidades.Winthor;

// namespace nwErp.Api.Modelos;

[Serializable]
public class PCVENDACONSUM : GerenteDePropriedades, IEntidade
{
    private static readonly string RO_BAIRROENT = "Bairroent";

    private string _bairroent;

    private static readonly string RO_CEPENT = "Cepent";

    private string _cepent;

    private static readonly string RO_CGCENT = "Cgcent";

    private string _cgcent;

    private static readonly string RO_CLIENTE = "Cliente";

    private string _cliente;

    private static readonly string RO_CODCIDADE = "Codcidade";

    private decimal? _codcidade;

    private static readonly string RO_DTEXPORTACAOSERVINT = "Dtexportacaoservint";

    private DateTime? _dtexportacaoservint;

    private static readonly string RO_DTIMPORTACAOSERVPRINC = "Dtimportacaoservprinc";

    private DateTime? _dtimportacaoservprinc;

    private static readonly string RO_EMAIL = "Email";

    private string _email;

    private static readonly string RO_ENDERENT = "Enderent";

    private string _enderent;

    private static readonly string RO_ESTENT = "Estent";

    private string _estent;

    private static readonly string RO_EXPORTADOSERVINT = "Exportadoservint";

    private string _exportadoservint;

    private static readonly string RO_IEENT = "Ieent";

    private string _ieent;

    private static readonly string RO_IMPORTADOSERVPRINC = "Importadoservprinc";

    private string _importadoservprinc;

    private static readonly string RO_MUNICENT = "Municent";

    private string _municent;

    private static readonly string RO_NOMECONTATO = "Nomecontato";

    private string _nomecontato;

    private static readonly string RO_NUMEROENT = "Numeroent";

    private string _numeroent;

    private static readonly string RO_NUMPED = "Numped";

    private decimal _numped;

    private static readonly string RO_OBS = "Obs";

    private string _obs;

    private static readonly string RO_OBSCONTATO = "Obscontato";

    private string _obscontato;

    private static readonly string RO_TELEFONECONTATO = "Telefonecontato";

    private string _telefonecontato;

    private static readonly string RO_TELENT = "Telent";

    private string _telent;

    private static readonly string RO_RG = "Rg";

    private string _rg;

    private static readonly string RO_DTNASC = "Dtnasc";

    private DateTime? _dtnasc;

    private static readonly string RO_IDENTIFICACAO_ESTRANGEIRO = "Identificacao_estrangeiro";

    private string _identificacao_estrangeiro;

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCVENDACONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
    public string Bairroent
    {
        get
        {
            PropriedadeAcessada(RO_BAIRROENT);
            return _bairroent;
        }
        set
        {
            PropriedadeModificada(RO_BAIRROENT, value);
            _bairroent = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCVENDACONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 9, Precisao = 0)]
    public string Cepent
    {
        get
        {
            PropriedadeAcessada(RO_CEPENT);
            return _cepent;
        }
        set
        {
            PropriedadeModificada(RO_CEPENT, value);
            _cepent = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCVENDACONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 18, Precisao = 0)]
    public string Cgcent
    {
        get
        {
            PropriedadeAcessada(RO_CGCENT);
            return _cgcent;
        }
        set
        {
            PropriedadeModificada(RO_CGCENT, value);
            _cgcent = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCVENDACONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCVENDACONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCVENDACONSUM", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtexportacaoservint
    {
        get
        {
            PropriedadeAcessada(RO_DTEXPORTACAOSERVINT);
            return _dtexportacaoservint;
        }
        set
        {
            PropriedadeModificada(RO_DTEXPORTACAOSERVINT, value);
            _dtexportacaoservint = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCVENDACONSUM", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtimportacaoservprinc
    {
        get
        {
            PropriedadeAcessada(RO_DTIMPORTACAOSERVPRINC);
            return _dtimportacaoservprinc;
        }
        set
        {
            PropriedadeModificada(RO_DTIMPORTACAOSERVPRINC, value);
            _dtimportacaoservprinc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCVENDACONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 100, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCVENDACONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
    public string Enderent
    {
        get
        {
            PropriedadeAcessada(RO_ENDERENT);
            return _enderent;
        }
        set
        {
            PropriedadeModificada(RO_ENDERENT, value);
            _enderent = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCVENDACONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Estent
    {
        get
        {
            PropriedadeAcessada(RO_ESTENT);
            return _estent;
        }
        set
        {
            PropriedadeModificada(RO_ESTENT, value);
            _estent = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCVENDACONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Exportadoservint
    {
        get
        {
            PropriedadeAcessada(RO_EXPORTADOSERVINT);
            return _exportadoservint;
        }
        set
        {
            PropriedadeModificada(RO_EXPORTADOSERVINT, value);
            _exportadoservint = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCVENDACONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 15, Precisao = 0)]
    public string Ieent
    {
        get
        {
            PropriedadeAcessada(RO_IEENT);
            return _ieent;
        }
        set
        {
            PropriedadeModificada(RO_IEENT, value);
            _ieent = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCVENDACONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Importadoservprinc
    {
        get
        {
            PropriedadeAcessada(RO_IMPORTADOSERVPRINC);
            return _importadoservprinc;
        }
        set
        {
            PropriedadeModificada(RO_IMPORTADOSERVPRINC, value);
            _importadoservprinc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCVENDACONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 15, Precisao = 0)]
    public string Municent
    {
        get
        {
            PropriedadeAcessada(RO_MUNICENT);
            return _municent;
        }
        set
        {
            PropriedadeModificada(RO_MUNICENT, value);
            _municent = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCVENDACONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
    public string Nomecontato
    {
        get
        {
            PropriedadeAcessada(RO_NOMECONTATO);
            return _nomecontato;
        }
        set
        {
            PropriedadeModificada(RO_NOMECONTATO, value);
            _nomecontato = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCVENDACONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 6, Precisao = 0)]
    public string Numeroent
    {
        get
        {
            PropriedadeAcessada(RO_NUMEROENT);
            return _numeroent;
        }
        set
        {
            PropriedadeModificada(RO_NUMEROENT, value);
            _numeroent = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCVENDACONSUM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal Numped
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCVENDACONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 100, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCVENDACONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 75, Precisao = 0)]
    public string Obscontato
    {
        get
        {
            PropriedadeAcessada(RO_OBSCONTATO);
            return _obscontato;
        }
        set
        {
            PropriedadeModificada(RO_OBSCONTATO, value);
            _obscontato = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCVENDACONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 13, Precisao = 0)]
    public string Telefonecontato
    {
        get
        {
            PropriedadeAcessada(RO_TELEFONECONTATO);
            return _telefonecontato;
        }
        set
        {
            PropriedadeModificada(RO_TELEFONECONTATO, value);
            _telefonecontato = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCVENDACONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 13, Precisao = 0)]
    public string Telent
    {
        get
        {
            PropriedadeAcessada(RO_TELENT);
            return _telent;
        }
        set
        {
            PropriedadeModificada(RO_TELENT, value);
            _telent = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCVENDACONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
    public string Rg
    {
        get
        {
            PropriedadeAcessada(RO_RG);
            return _rg;
        }
        set
        {
            PropriedadeModificada(RO_RG, value);
            _rg = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCVENDACONSUM", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtnasc
    {
        get
        {
            PropriedadeAcessada(RO_DTNASC);
            return _dtnasc;
        }
        set
        {
            PropriedadeModificada(RO_DTNASC, value);
            _dtnasc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCVENDACONSUM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
    public string Identificacao_estrangeiro
    {
        get
        {
            PropriedadeAcessada(RO_IDENTIFICACAO_ESTRANGEIRO);
            return _identificacao_estrangeiro;
        }
        set
        {
            PropriedadeModificada(RO_IDENTIFICACAO_ESTRANGEIRO, value);
            _identificacao_estrangeiro = value;
        }
    }

    public void InicializarAtributos()
    {
    }

    public string ObterNomeTabela()
    {
        return "PCVENDACONSUM";
    }

    public IEntidade NovaInstancia()
    {
        return (IEntidade)GetType().GetConstructors()[0].Invoke(null);
    }

    public void CarregarPorDataReader(IDataReader leitor)
    {
        _bairroent = AlterarTipo<string>(leitor["Bairroent"]);
        _cepent = AlterarTipo<string>(leitor["Cepent"]);
        _cgcent = AlterarTipo<string>(leitor["Cgcent"]);
        _cliente = AlterarTipo<string>(leitor["Cliente"]);
        _codcidade = AlterarTipo<decimal?>(leitor["Codcidade"]);
        _dtexportacaoservint = AlterarTipo<DateTime?>(leitor["Dtexportacaoservint"]);
        _dtimportacaoservprinc = AlterarTipo<DateTime?>(leitor["Dtimportacaoservprinc"]);
        _email = AlterarTipo<string>(leitor["Email"]);
        _enderent = AlterarTipo<string>(leitor["Enderent"]);
        _estent = AlterarTipo<string>(leitor["Estent"]);
        _exportadoservint = AlterarTipo<string>(leitor["Exportadoservint"]);
        _ieent = AlterarTipo<string>(leitor["Ieent"]);
        _importadoservprinc = AlterarTipo<string>(leitor["Importadoservprinc"]);
        _municent = AlterarTipo<string>(leitor["Municent"]);
        _nomecontato = AlterarTipo<string>(leitor["Nomecontato"]);
        _numeroent = AlterarTipo<string>(leitor["Numeroent"]);
        _numped = AlterarTipo<decimal>(leitor["Numped"]);
        _obs = AlterarTipo<string>(leitor["Obs"]);
        _obscontato = AlterarTipo<string>(leitor["Obscontato"]);
        _telefonecontato = AlterarTipo<string>(leitor["Telefonecontato"]);
        _telent = AlterarTipo<string>(leitor["Telent"]);
        _rg = AlterarTipo<string>(leitor["Rg"]);
        _dtnasc = AlterarTipo<DateTime>(leitor["Dtnasc"]);
        _identificacao_estrangeiro = AlterarTipo<string>(leitor["Identificacao_estrangeiro"]);
    }

    //PosicaoEntidade IEntidade.get_PosicaoEntidade()
    //{
    //	return base.PosicaoEntidade;
    //}

    //void IEntidade.set_PosicaoEntidade(PosicaoEntidade value)
    //{
    //	base.PosicaoEntidade = value;
    //}

    //PropertyInfo[] IEntidade.get_PropriedadesModificadas()
    //{
    //	return base.PropriedadesModificadas;
    //}

    //string IEntidade.get_IdentificacaoDoRegistro()
    //{
    //	return base.IdentificacaoDoRegistro;
    //}

    //void IEntidade.set_IdentificacaoDoRegistro(string value)
    //{
    //	base.IdentificacaoDoRegistro = value;
    //}
}