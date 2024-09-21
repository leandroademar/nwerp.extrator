

////// // namespace nwErp.Entidades.Caixa;

// // namespace nwErp.Api.Modelos;

[Serializable]
public class PCDOCEMITIDOSECF : GerenteDePropriedades, IEntidade
{
    private static readonly string RO_ASSINATURA = "Assinatura";

    private string _assinatura;

    private static readonly string RO_CDC = "Cdc";

    private decimal? _cdc;

    private static readonly string RO_CODFILIAL = "Codfilial";

    private string _codfilial;

    private static readonly string RO_COO = "Coo";

    private decimal _coo;

    private static readonly string RO_DATA = "Data";

    private DateTime? _data;

    private static readonly string RO_DENOMINICAO = "Denominicao";

    private string _denominicao;

    private static readonly string RO_DTEXPORTACAO = "Dtexportacao";

    private DateTime? _dtexportacao;

    private static readonly string RO_EXPORTADO = "Exportado";

    private string _exportado;

    private static readonly string RO_GNF = "Gnf";

    private decimal? _gnf;

    private static readonly string RO_GRG = "Grg";

    private decimal? _grg;

    private static readonly string RO_HORA = "Hora";

    private string _hora;

    private static readonly string RO_NUMCAIXA = "Numcaixa";

    private decimal? _numcaixa;

    private static readonly string RO_NUMSERIEECF = "Numserieecf";

    private string _numserieecf;

    private static readonly string RO_VALOR = "Valor";

    private decimal? _valor;

    private static readonly string RO_TIPODOC = "Tipodoc";

    private string _tipodoc;

    private string _md5paf;

    private decimal? _numusuarioecf;

    private static readonly string RO_DATAHORAEMISSAO = "Datahoraemissao";

    private DateTime? _datahoraemissao;

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCDOCEMITIDOSECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 255, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCDOCEMITIDOSECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Cdc
    {
        get
        {
            PropriedadeAcessada(RO_CDC);
            return _cdc;
        }
        set
        {
            PropriedadeModificada(RO_CDC, value);
            _cdc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCDOCEMITIDOSECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCDOCEMITIDOSECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal Coo
    {
        get
        {
            PropriedadeAcessada(RO_COO);
            return _coo;
        }
        set
        {
            PropriedadeModificada(RO_COO, value);
            _coo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCDOCEMITIDOSECF", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Data
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCDOCEMITIDOSECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Denominicao
    {
        get
        {
            PropriedadeAcessada(RO_DENOMINICAO);
            return _denominicao;
        }
        set
        {
            PropriedadeModificada(RO_DENOMINICAO, value);
            _denominicao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCDOCEMITIDOSECF", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCDOCEMITIDOSECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCDOCEMITIDOSECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Gnf
    {
        get
        {
            PropriedadeAcessada(RO_GNF);
            return _gnf;
        }
        set
        {
            PropriedadeModificada(RO_GNF, value);
            _gnf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCDOCEMITIDOSECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Grg
    {
        get
        {
            PropriedadeAcessada(RO_GRG);
            return _grg;
        }
        set
        {
            PropriedadeModificada(RO_GRG, value);
            _grg = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCDOCEMITIDOSECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 8, Precisao = 0)]
    public string Hora
    {
        get
        {
            PropriedadeAcessada(RO_HORA);
            return _hora;
        }
        set
        {
            PropriedadeModificada(RO_HORA, value);
            _hora = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCDOCEMITIDOSECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 3, Precisao = 0)]
    public decimal? Numcaixa
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

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCDOCEMITIDOSECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
    public string Numserieecf
    {
        get
        {
            PropriedadeAcessada(RO_NUMSERIEECF);
            return _numserieecf;
        }
        set
        {
            PropriedadeModificada(RO_NUMSERIEECF, value);
            _numserieecf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCDOCEMITIDOSECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 2)]
    public decimal? Valor
    {
        get
        {
            PropriedadeAcessada(RO_VALOR);
            return _valor;
        }
        set
        {
            PropriedadeModificada(RO_VALOR, value);
            _valor = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCDOCEMITIDOSECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Tipodoc
    {
        get
        {
            PropriedadeAcessada(RO_TIPODOC);
            return _tipodoc;
        }
        set
        {
            PropriedadeModificada(RO_TIPODOC, value);
            _tipodoc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCDOCEMITIDOSECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 200, Precisao = 0)]
    public string Md5paf
    {
        get
        {
            PropriedadeAcessada("Md5paf");
            return _md5paf;
        }
        set
        {
            PropriedadeModificada("Md5paf", value);
            _md5paf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCDOCEMITIDOSECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Numusuarioecf
    {
        get
        {
            PropriedadeAcessada("Numusuarioecf");
            return _numusuarioecf;
        }
        set
        {
            PropriedadeModificada("Numusuarioecf", value);
            _numusuarioecf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCDOCEMITIDOSECF", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Datahoraemissao
    {
        get
        {
            PropriedadeAcessada(RO_DATAHORAEMISSAO);
            return _datahoraemissao;
        }
        set
        {
            PropriedadeModificada(RO_DATAHORAEMISSAO, value);
            _datahoraemissao = value;
        }
    }

    public void InicializarAtributos()
    {
    }

    public string ObterNomeTabela()
    {
        return "PCDOCEMITIDOSECF";
    }

    public IEntidade NovaInstancia()
    {
        return (IEntidade)GetType().GetConstructors()[0].Invoke(null);
    }

    public void CarregarPorDataReader(IDataReader leitor)
    {
        _assinatura = AlterarTipo<string>(leitor["Assinatura"]);
        _cdc = AlterarTipo<decimal?>(leitor["Cdc"]);
        _codfilial = AlterarTipo<string>(leitor["Codfilial"]);
        _coo = AlterarTipo<decimal>(leitor["Coo"]);
        _data = AlterarTipo<DateTime?>(leitor["Data"]);
        _denominicao = AlterarTipo<string>(leitor["Denominicao"]);
        _dtexportacao = AlterarTipo<DateTime?>(leitor["Dtexportacao"]);
        _exportado = AlterarTipo<string>(leitor["Exportado"]);
        _gnf = AlterarTipo<decimal?>(leitor["Gnf"]);
        _grg = AlterarTipo<decimal?>(leitor["Grg"]);
        _hora = AlterarTipo<string>(leitor["Hora"]);
        _numcaixa = AlterarTipo<decimal?>(leitor["Numcaixa"]);
        _numserieecf = AlterarTipo<string>(leitor["Numserieecf"]);
        _tipodoc = AlterarTipo<string>(leitor["Tipodoc"]);
        _md5paf = AlterarTipo<string>(leitor["Md5paf"]);
        _numusuarioecf = AlterarTipo<decimal?>(leitor["Numusuarioecf"]);
        _datahoraemissao = AlterarTipo<DateTime?>(leitor["Datahoraemissao"]);
        _valor = AlterarTipo<decimal?>(leitor["Valor"]);
    }

}