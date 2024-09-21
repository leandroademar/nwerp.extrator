

////// namespace nwErp.Entidades.Winthor;

// namespace nwErp.Api.Modelos;

[Serializable]
public class PCLISTAPRESENTEC : GerenteDePropriedades, IEntidade
{
    private static readonly string RO_BAIRROTITULAR = "Bairrotitular";

    private string _bairrotitular;

    private static readonly string RO_CELULARTITULAR = "Celulartitular";

    private string _celulartitular;

    private static readonly string RO_CEPTITULAR = "Ceptitular";

    private string _ceptitular;

    private static readonly string RO_CIDADEEVENTO = "Cidadeevento";

    private string _cidadeevento;

    private static readonly string RO_CIDADETITULAR = "Cidadetitular";

    private string _cidadetitular;

    private static readonly string RO_CODCLI = "Codcli";

    private decimal? _codcli;

    private static readonly string RO_CODCREDITO = "Codcredito";

    private decimal? _codcredito;

    private static readonly string RO_CODFUNCCADASTRO = "Codfunccadastro";

    private decimal? _codfunccadastro;

    private static readonly string RO_CODFUNCINATIVACAO = "Codfuncinativacao";

    private decimal? _codfuncinativacao;

    private static readonly string RO_COMPLETITULAR = "Completitular";

    private string _completitular;

    private static readonly string RO_CPFTITULAR = "Cpftitular";

    private string _cpftitular;

    private static readonly string RO_DATAEVENTO = "Dataevento";

    private DateTime? _dataevento;

    private static readonly string RO_DTCADASTRO = "Dtcadastro";

    private DateTime? _dtcadastro;

    private static readonly string RO_DTFECHAMENTO = "Dtfechamento";

    private DateTime? _dtfechamento;

    private static readonly string RO_DTINATIVACAO = "Dtinativacao";

    private DateTime? _dtinativacao;

    private static readonly string RO_DTVALIDADE = "Dtvalidade";

    private DateTime? _dtvalidade;

    private static readonly string RO_EMAILCOMPLE = "Emailcomple";

    private string _emailcomple;

    private static readonly string RO_EMAILTITULAR = "Emailtitular";

    private string _emailtitular;

    private static readonly string RO_ENDERECOTITULAR = "Enderecotitular";

    private string _enderecotitular;

    private static readonly string RO_MENSAGEM = "Mensagem";

    private string _mensagem;

    private static readonly string RO_MOTIVOINATIVACAO = "Motivoinativacao";

    private string _motivoinativacao;

    private static readonly string RO_NOMECOMPLE = "Nomecomple";

    private string _nomecomple;

    private static readonly string RO_NOMEMAECOMPLE = "Nomemaecomple";

    private string _nomemaecomple;

    private static readonly string RO_NOMEMAETITULAR = "Nomemaetitular";

    private string _nomemaetitular;

    private static readonly string RO_NOMEPAICOMPLE = "Nomepaicomple";

    private string _nomepaicomple;

    private static readonly string RO_NOMEPAITITULAR = "Nomepaititular";

    private string _nomepaititular;

    private static readonly string RO_NOMETITULAR = "Nometitular";

    private string _nometitular;

    private static readonly string RO_NUMEROTITULAR = "Numerotitular";

    private string _numerotitular;

    private static readonly string RO_NUMLISTA = "Numlista";

    private decimal _numlista;

    private static readonly string RO_SOBRENOMECOMPLE = "Sobrenomecomple";

    private string _sobrenomecomple;

    private static readonly string RO_SOBRENOMETITULAR = "Sobrenometitular";

    private string _sobrenometitular;

    private static readonly string RO_STATUS = "Status";

    private string _status;

    private static readonly string RO_TELEFONETITULAR = "Telefonetitular";

    private string _telefonetitular;

    private static readonly string RO_TIPOEVENTO = "Tipoevento";

    private string _tipoevento;

    private static readonly string RO_UFEVENTO = "Ufevento";

    private string _ufevento;

    private static readonly string RO_UFTITULAR = "Uftitular";

    private string _uftitular;

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLISTAPRESENTEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 50, Precisao = 0)]
    public string Bairrotitular
    {
        get
        {
            PropriedadeAcessada(RO_BAIRROTITULAR);
            return _bairrotitular;
        }
        set
        {
            PropriedadeModificada(RO_BAIRROTITULAR, value);
            _bairrotitular = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLISTAPRESENTEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
    public string Celulartitular
    {
        get
        {
            PropriedadeAcessada(RO_CELULARTITULAR);
            return _celulartitular;
        }
        set
        {
            PropriedadeModificada(RO_CELULARTITULAR, value);
            _celulartitular = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLISTAPRESENTEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 9, Precisao = 0)]
    public string Ceptitular
    {
        get
        {
            PropriedadeAcessada(RO_CEPTITULAR);
            return _ceptitular;
        }
        set
        {
            PropriedadeModificada(RO_CEPTITULAR, value);
            _ceptitular = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLISTAPRESENTEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 100, Precisao = 0)]
    public string Cidadeevento
    {
        get
        {
            PropriedadeAcessada(RO_CIDADEEVENTO);
            return _cidadeevento;
        }
        set
        {
            PropriedadeModificada(RO_CIDADEEVENTO, value);
            _cidadeevento = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLISTAPRESENTEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 100, Precisao = 0)]
    public string Cidadetitular
    {
        get
        {
            PropriedadeAcessada(RO_CIDADETITULAR);
            return _cidadetitular;
        }
        set
        {
            PropriedadeModificada(RO_CIDADETITULAR, value);
            _cidadetitular = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLISTAPRESENTEC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codcli
    {
        get
        {
            PropriedadeAcessada(RO_CODCLI);
            return _codcli;
        }
        set
        {
            PropriedadeModificada(RO_CODCLI, value);
            _codcli = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLISTAPRESENTEC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codcredito
    {
        get
        {
            PropriedadeAcessada(RO_CODCREDITO);
            return _codcredito;
        }
        set
        {
            PropriedadeModificada(RO_CODCREDITO, value);
            _codcredito = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLISTAPRESENTEC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codfunccadastro
    {
        get
        {
            PropriedadeAcessada(RO_CODFUNCCADASTRO);
            return _codfunccadastro;
        }
        set
        {
            PropriedadeModificada(RO_CODFUNCCADASTRO, value);
            _codfunccadastro = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLISTAPRESENTEC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codfuncinativacao
    {
        get
        {
            PropriedadeAcessada(RO_CODFUNCINATIVACAO);
            return _codfuncinativacao;
        }
        set
        {
            PropriedadeModificada(RO_CODFUNCINATIVACAO, value);
            _codfuncinativacao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLISTAPRESENTEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 50, Precisao = 0)]
    public string Completitular
    {
        get
        {
            PropriedadeAcessada(RO_COMPLETITULAR);
            return _completitular;
        }
        set
        {
            PropriedadeModificada(RO_COMPLETITULAR, value);
            _completitular = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLISTAPRESENTEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 11, Precisao = 0)]
    public string Cpftitular
    {
        get
        {
            PropriedadeAcessada(RO_CPFTITULAR);
            return _cpftitular;
        }
        set
        {
            PropriedadeModificada(RO_CPFTITULAR, value);
            _cpftitular = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLISTAPRESENTEC", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dataevento
    {
        get
        {
            PropriedadeAcessada(RO_DATAEVENTO);
            return _dataevento;
        }
        set
        {
            PropriedadeModificada(RO_DATAEVENTO, value);
            _dataevento = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLISTAPRESENTEC", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLISTAPRESENTEC", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtfechamento
    {
        get
        {
            PropriedadeAcessada(RO_DTFECHAMENTO);
            return _dtfechamento;
        }
        set
        {
            PropriedadeModificada(RO_DTFECHAMENTO, value);
            _dtfechamento = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLISTAPRESENTEC", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtinativacao
    {
        get
        {
            PropriedadeAcessada(RO_DTINATIVACAO);
            return _dtinativacao;
        }
        set
        {
            PropriedadeModificada(RO_DTINATIVACAO, value);
            _dtinativacao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLISTAPRESENTEC", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtvalidade
    {
        get
        {
            PropriedadeAcessada(RO_DTVALIDADE);
            return _dtvalidade;
        }
        set
        {
            PropriedadeModificada(RO_DTVALIDADE, value);
            _dtvalidade = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLISTAPRESENTEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 200, Precisao = 0)]
    public string Emailcomple
    {
        get
        {
            PropriedadeAcessada(RO_EMAILCOMPLE);
            return _emailcomple;
        }
        set
        {
            PropriedadeModificada(RO_EMAILCOMPLE, value);
            _emailcomple = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLISTAPRESENTEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 200, Precisao = 0)]
    public string Emailtitular
    {
        get
        {
            PropriedadeAcessada(RO_EMAILTITULAR);
            return _emailtitular;
        }
        set
        {
            PropriedadeModificada(RO_EMAILTITULAR, value);
            _emailtitular = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLISTAPRESENTEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 100, Precisao = 0)]
    public string Enderecotitular
    {
        get
        {
            PropriedadeAcessada(RO_ENDERECOTITULAR);
            return _enderecotitular;
        }
        set
        {
            PropriedadeModificada(RO_ENDERECOTITULAR, value);
            _enderecotitular = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLISTAPRESENTEC", Tipo = TipoDoCampoNoBancoDeDados.Binario, Tamanho = 4000, Precisao = 0)]
    public string Mensagem
    {
        get
        {
            PropriedadeAcessada(RO_MENSAGEM);
            return _mensagem;
        }
        set
        {
            PropriedadeModificada(RO_MENSAGEM, value);
            _mensagem = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLISTAPRESENTEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 4000, Precisao = 0)]
    public string Motivoinativacao
    {
        get
        {
            PropriedadeAcessada(RO_MOTIVOINATIVACAO);
            return _motivoinativacao;
        }
        set
        {
            PropriedadeModificada(RO_MOTIVOINATIVACAO, value);
            _motivoinativacao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLISTAPRESENTEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 30, Precisao = 0)]
    public string Nomecomple
    {
        get
        {
            PropriedadeAcessada(RO_NOMECOMPLE);
            return _nomecomple;
        }
        set
        {
            PropriedadeModificada(RO_NOMECOMPLE, value);
            _nomecomple = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLISTAPRESENTEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 100, Precisao = 0)]
    public string Nomemaecomple
    {
        get
        {
            PropriedadeAcessada(RO_NOMEMAECOMPLE);
            return _nomemaecomple;
        }
        set
        {
            PropriedadeModificada(RO_NOMEMAECOMPLE, value);
            _nomemaecomple = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLISTAPRESENTEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 100, Precisao = 0)]
    public string Nomemaetitular
    {
        get
        {
            PropriedadeAcessada(RO_NOMEMAETITULAR);
            return _nomemaetitular;
        }
        set
        {
            PropriedadeModificada(RO_NOMEMAETITULAR, value);
            _nomemaetitular = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLISTAPRESENTEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 100, Precisao = 0)]
    public string Nomepaicomple
    {
        get
        {
            PropriedadeAcessada(RO_NOMEPAICOMPLE);
            return _nomepaicomple;
        }
        set
        {
            PropriedadeModificada(RO_NOMEPAICOMPLE, value);
            _nomepaicomple = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLISTAPRESENTEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 100, Precisao = 0)]
    public string Nomepaititular
    {
        get
        {
            PropriedadeAcessada(RO_NOMEPAITITULAR);
            return _nomepaititular;
        }
        set
        {
            PropriedadeModificada(RO_NOMEPAITITULAR, value);
            _nomepaititular = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLISTAPRESENTEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 30, Precisao = 0)]
    public string Nometitular
    {
        get
        {
            PropriedadeAcessada(RO_NOMETITULAR);
            return _nometitular;
        }
        set
        {
            PropriedadeModificada(RO_NOMETITULAR, value);
            _nometitular = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLISTAPRESENTEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
    public string Numerotitular
    {
        get
        {
            PropriedadeAcessada(RO_NUMEROTITULAR);
            return _numerotitular;
        }
        set
        {
            PropriedadeModificada(RO_NUMEROTITULAR, value);
            _numerotitular = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCLISTAPRESENTEC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal Numlista
    {
        get
        {
            PropriedadeAcessada(RO_NUMLISTA);
            return _numlista;
        }
        set
        {
            PropriedadeModificada(RO_NUMLISTA, value);
            _numlista = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLISTAPRESENTEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 50, Precisao = 0)]
    public string Sobrenomecomple
    {
        get
        {
            PropriedadeAcessada(RO_SOBRENOMECOMPLE);
            return _sobrenomecomple;
        }
        set
        {
            PropriedadeModificada(RO_SOBRENOMECOMPLE, value);
            _sobrenomecomple = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLISTAPRESENTEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 50, Precisao = 0)]
    public string Sobrenometitular
    {
        get
        {
            PropriedadeAcessada(RO_SOBRENOMETITULAR);
            return _sobrenometitular;
        }
        set
        {
            PropriedadeModificada(RO_SOBRENOMETITULAR, value);
            _sobrenometitular = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLISTAPRESENTEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Status
    {
        get
        {
            PropriedadeAcessada(RO_STATUS);
            return _status;
        }
        set
        {
            PropriedadeModificada(RO_STATUS, value);
            _status = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLISTAPRESENTEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
    public string Telefonetitular
    {
        get
        {
            PropriedadeAcessada(RO_TELEFONETITULAR);
            return _telefonetitular;
        }
        set
        {
            PropriedadeModificada(RO_TELEFONETITULAR, value);
            _telefonetitular = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLISTAPRESENTEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Tipoevento
    {
        get
        {
            PropriedadeAcessada(RO_TIPOEVENTO);
            return _tipoevento;
        }
        set
        {
            PropriedadeModificada(RO_TIPOEVENTO, value);
            _tipoevento = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLISTAPRESENTEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Ufevento
    {
        get
        {
            PropriedadeAcessada(RO_UFEVENTO);
            return _ufevento;
        }
        set
        {
            PropriedadeModificada(RO_UFEVENTO, value);
            _ufevento = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLISTAPRESENTEC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Uftitular
    {
        get
        {
            PropriedadeAcessada(RO_UFTITULAR);
            return _uftitular;
        }
        set
        {
            PropriedadeModificada(RO_UFTITULAR, value);
            _uftitular = value;
        }
    }

    public void InicializarAtributos()
    {
    }

    public string ObterNomeTabela()
    {
        return "PCLISTAPRESENTEC";
    }

    public IEntidade NovaInstancia()
    {
        return (IEntidade)GetType().GetConstructors()[0].Invoke(null);
    }

    public void CarregarPorDataReader(IDataReader leitor)
    {
        _bairrotitular = AlterarTipo<string>(leitor["Bairrotitular"]);
        _celulartitular = AlterarTipo<string>(leitor["Celulartitular"]);
        _ceptitular = AlterarTipo<string>(leitor["Ceptitular"]);
        _cidadeevento = AlterarTipo<string>(leitor["Cidadeevento"]);
        _cidadetitular = AlterarTipo<string>(leitor["Cidadetitular"]);
        _codcli = AlterarTipo<decimal?>(leitor["Codcli"]);
        _codcredito = AlterarTipo<decimal?>(leitor["Codcredito"]);
        _codfunccadastro = AlterarTipo<decimal?>(leitor["Codfunccadastro"]);
        _codfuncinativacao = AlterarTipo<decimal?>(leitor["Codfuncinativacao"]);
        _completitular = AlterarTipo<string>(leitor["Completitular"]);
        _cpftitular = AlterarTipo<string>(leitor["Cpftitular"]);
        _dataevento = AlterarTipo<DateTime?>(leitor["Dataevento"]);
        _dtcadastro = AlterarTipo<DateTime?>(leitor["Dtcadastro"]);
        _dtfechamento = AlterarTipo<DateTime?>(leitor["Dtfechamento"]);
        _dtinativacao = AlterarTipo<DateTime?>(leitor["Dtinativacao"]);
        _dtvalidade = AlterarTipo<DateTime?>(leitor["Dtvalidade"]);
        _emailcomple = AlterarTipo<string>(leitor["Emailcomple"]);
        _emailtitular = AlterarTipo<string>(leitor["Emailtitular"]);
        _enderecotitular = AlterarTipo<string>(leitor["Enderecotitular"]);
        _mensagem = AlterarTipo<string>(leitor["Mensagem"]);
        _motivoinativacao = AlterarTipo<string>(leitor["Motivoinativacao"]);
        _nomecomple = AlterarTipo<string>(leitor["Nomecomple"]);
        _nomemaecomple = AlterarTipo<string>(leitor["Nomemaecomple"]);
        _nomemaetitular = AlterarTipo<string>(leitor["Nomemaetitular"]);
        _nomepaicomple = AlterarTipo<string>(leitor["Nomepaicomple"]);
        _nomepaititular = AlterarTipo<string>(leitor["Nomepaititular"]);
        _nometitular = AlterarTipo<string>(leitor["Nometitular"]);
        _numerotitular = AlterarTipo<string>(leitor["Numerotitular"]);
        _numlista = AlterarTipo<decimal>(leitor["Numlista"]);
        _sobrenomecomple = AlterarTipo<string>(leitor["Sobrenomecomple"]);
        _sobrenometitular = AlterarTipo<string>(leitor["Sobrenometitular"]);
        _status = AlterarTipo<string>(leitor["Status"]);
        _telefonetitular = AlterarTipo<string>(leitor["Telefonetitular"]);
        _tipoevento = AlterarTipo<string>(leitor["Tipoevento"]);
        _ufevento = AlterarTipo<string>(leitor["Ufevento"]);
        _uftitular = AlterarTipo<string>(leitor["Uftitular"]);
    }

}