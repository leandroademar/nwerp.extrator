

////// namespace nwErp.Entidades.Caixa;

// namespace nwErp.Api.Modelos;

[Serializable]
public class PCVENDACONSUMECF : GerenteDePropriedades, IEntidade
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

    private static readonly string RO_CODFILIAL = "Codfilial";

    private string _codfilial;

    private static readonly string RO_CODFUNCCX = "Codfunccx";

    private decimal _codfunccx;

    private static readonly string RO_DATA = "Data";

    private DateTime _data;

    private static readonly string RO_DTEXPORTACAO = "Dtexportacao";

    private DateTime? _dtexportacao;

    private static readonly string RO_EMAIL = "Email";

    private string _email;

    private static readonly string RO_ENDERENT = "Enderent";

    private string _enderent;

    private static readonly string RO_ESTENT = "Estent";

    private string _estent;

    private static readonly string RO_EXPORTADO = "Exportado";

    private string _exportado;

    private static readonly string RO_IEENT = "Ieent";

    private string _ieent;

    private static readonly string RO_IMPORTADO = "Importado";

    private string _importado;

    private static readonly string RO_MUNICENT = "Municent";

    private string _municent;

    private static readonly string RO_NOMECONTATO = "Nomecontato";

    private string _nomecontato;

    private static readonly string RO_NUMCAIXA = "Numcaixa";

    private decimal _numcaixa;

    private static readonly string RO_NUMCUPOM = "Numcupom";

    private decimal? _numcupom;

    private static readonly string RO_NUMEROENT = "Numeroent";

    private string _numeroent;

    private static readonly string RO_NUMPED = "Numped";

    private decimal? _numped;

    private static readonly string RO_NUMPEDECF = "Numpedecf";

    private decimal _numpedecf;

    private static readonly string RO_NUMSERIEEQUIP = "Numserieequip";

    private string _numserieequip;

    private static readonly string RO_OBS = "Obs";

    private string _obs;

    private static readonly string RO_OBSCONTATO = "Obscontato";

    private string _obscontato;

    private static readonly string RO_SERIEECF = "Serieecf";

    private string _serieecf;

    private static readonly string RO_TELEFONECONTATO = "Telefonecontato";

    private string _telefonecontato;

    private static readonly string RO_TELENT = "Telent";

    private string _telent;

    private static readonly string RO_RG = "Rg";

    private string _rg;

    private static readonly string RO_DTNASC = "Dtnasc";

    private DateTime? _dtnasc;

    private static readonly string RO_ASSINATURA = "Assinatura";

    private string _assinatura;

    private static readonly string RO_IDENTIFICACAO_ESTRANGEIRO = "Identificacao_estrangeiro";

    private string _identificacao_estrangeiro;

    private static readonly string RO_CONTRIBUINTE = "Contribuinte";

    private string _contribuinte;

    private static readonly string RO_CONSUMIDORFINAL = "Consumidorfinal";

    private string _consumidorfinal;

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCVENDACONSUMECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCVENDACONSUMECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 9, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCVENDACONSUMECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 18, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCVENDACONSUMECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCVENDACONSUMECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCVENDACONSUMECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Codfilial
    {
        get
        {
            PropriedadeAcessada(RO_CODFILIAL);
            return _codfilial;
        }
        set
        {
            PropriedadeModificada(RO_CODFILIAL, value);
            _codfilial = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCVENDACONSUMECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCVENDACONSUMECF", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCVENDACONSUMECF", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtexportacao
    {
        get
        {
            PropriedadeAcessada(RO_DTEXPORTACAO);
            return _dtexportacao;
        }
        set
        {
            PropriedadeModificada(RO_DTEXPORTACAO, value);
            _dtexportacao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCVENDACONSUMECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 100, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCVENDACONSUMECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCVENDACONSUMECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCVENDACONSUMECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCVENDACONSUMECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 15, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCVENDACONSUMECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Importado
    {
        get
        {
            PropriedadeAcessada(RO_IMPORTADO);
            return _importado;
        }
        set
        {
            PropriedadeModificada(RO_IMPORTADO, value);
            _importado = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCVENDACONSUMECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 16, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCVENDACONSUMECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCVENDACONSUMECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCVENDACONSUMECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numcupom
    {
        get
        {
            PropriedadeAcessada(RO_NUMCUPOM);
            return _numcupom;
        }
        set
        {
            PropriedadeModificada(RO_NUMCUPOM, value);
            _numcupom = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCVENDACONSUMECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 6, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCVENDACONSUMECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numped
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

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCVENDACONSUMECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCVENDACONSUMECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 30, Precisao = 0)]
    public string Numserieequip
    {
        get
        {
            PropriedadeAcessada(RO_NUMSERIEEQUIP);
            return _numserieequip;
        }
        set
        {
            PropriedadeModificada(RO_NUMSERIEEQUIP, value);
            _numserieequip = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCVENDACONSUMECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 100, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCVENDACONSUMECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 75, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCVENDACONSUMECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Serieecf
    {
        get
        {
            PropriedadeAcessada(RO_SERIEECF);
            return _serieecf;
        }
        set
        {
            PropriedadeModificada(RO_SERIEECF, value);
            _serieecf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCVENDACONSUMECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 13, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCVENDACONSUMECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 13, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCVENDACONSUMECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCVENDACONSUMECF", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCVENDACONSUMECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 256, Precisao = 0)]
    public string Assinatura
    {
        get
        {
            PropriedadeAcessada(RO_ASSINATURA);
            return _assinatura;
        }
        set
        {
            PropriedadeModificada(RO_ASSINATURA, value);
            _assinatura = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCVENDACONSUMECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCVENDACONSUMECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Contribuinte
    {
        get
        {
            PropriedadeAcessada(RO_CONTRIBUINTE);
            return _contribuinte;
        }
        set
        {
            PropriedadeModificada(RO_CONTRIBUINTE, value);
            _contribuinte = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCVENDACONSUMECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Consumidorfinal
    {
        get
        {
            PropriedadeAcessada(RO_CONSUMIDORFINAL);
            return _consumidorfinal;
        }
        set
        {
            PropriedadeModificada(RO_CONSUMIDORFINAL, value);
            _consumidorfinal = value;
        }
    }

    public void InicializarAtributos()
    {
    }

    public string ObterNomeTabela()
    {
        return "PCVENDACONSUMECF";
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
        _codfilial = AlterarTipo<string>(leitor["Codfilial"]);
        _codfunccx = AlterarTipo<decimal>(leitor["Codfunccx"]);
        _data = AlterarTipo<DateTime>(leitor["Data"]);
        _dtexportacao = AlterarTipo<DateTime?>(leitor["Dtexportacao"]);
        _email = AlterarTipo<string>(leitor["Email"]);
        _enderent = AlterarTipo<string>(leitor["Enderent"]);
        _estent = AlterarTipo<string>(leitor["Estent"]);
        _exportado = AlterarTipo<string>(leitor["Exportado"]);
        _ieent = AlterarTipo<string>(leitor["Ieent"]);
        _importado = AlterarTipo<string>(leitor["Importado"]);
        _municent = AlterarTipo<string>(leitor["Municent"]);
        _nomecontato = AlterarTipo<string>(leitor["Nomecontato"]);
        _numcaixa = AlterarTipo<decimal>(leitor["Numcaixa"]);
        _numcupom = AlterarTipo<decimal?>(leitor["Numcupom"]);
        _numeroent = AlterarTipo<string>(leitor["Numeroent"]);
        _numped = AlterarTipo<decimal?>(leitor["Numped"]);
        _numpedecf = AlterarTipo<decimal>(leitor["Numpedecf"]);
        _numserieequip = AlterarTipo<string>(leitor["Numserieequip"]);
        _obs = AlterarTipo<string>(leitor["Obs"]);
        _obscontato = AlterarTipo<string>(leitor["Obscontato"]);
        _serieecf = AlterarTipo<string>(leitor["Serieecf"]);
        _telefonecontato = AlterarTipo<string>(leitor["Telefonecontato"]);
        _telent = AlterarTipo<string>(leitor["Telent"]);
        _rg = AlterarTipo<string>(leitor["Rg"]);
        _dtnasc = AlterarTipo<DateTime>(leitor["Dtnasc"]);
        _assinatura = AlterarTipo<string>(leitor["Assinatura"]);
        _identificacao_estrangeiro = AlterarTipo<string>(leitor["Identificacao_estrangeiro"]);
        _contribuinte = AlterarTipo<string>(leitor["Contribuinte"]);
        _consumidorfinal = AlterarTipo<string>(leitor["Consumidorfinal"]);
    }

}