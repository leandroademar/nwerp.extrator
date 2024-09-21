

////// namespace nwErp.Entidades.Winthor;

// namespace nwErp.Api.Modelos;

[Serializable]
public class PCVERBA : GerenteDePropriedades, IEntidade
{
    private static readonly string RO_CODBANCO = "Codbanco";

    private decimal? _codbanco;

    private static readonly string RO_CODCONTA = "Codconta";

    private decimal? _codconta;

    private static readonly string RO_CODEPTO = "Codepto";

    private decimal? _codepto;

    private static readonly string RO_CODFILIAL = "Codfilial";

    private string _codfilial;

    private static readonly string RO_CODFORNEC = "Codfornec";

    private decimal? _codfornec;

    private static readonly string RO_CODFUNCCANCEL = "Codfunccancel";

    private decimal? _codfunccancel;

    private static readonly string RO_CODFUNCQUITACAO = "Codfuncquitacao";

    private decimal? _codfuncquitacao;

    private static readonly string RO_CODSEC = "Codsec";

    private decimal? _codsec;

    private static readonly string RO_CODTIPOVERBA = "Codtipoverba";

    private decimal? _codtipoverba;

    private static readonly string RO_CPFREPFORNEC = "Cpfrepfornec";

    private string _cpfrepfornec;

    private static readonly string RO_DATAEDICAO = "Dataedicao";

    private DateTime? _dataedicao;

    private static readonly string RO_DINHEIRO = "Dinheiro";

    private decimal? _dinheiro;

    private static readonly string RO_DTAPURACAO = "Dtapuracao";

    private DateTime? _dtapuracao;

    private static readonly string RO_DTCADASTRO = "Dtcadastro";

    private DateTime? _dtcadastro;

    private static readonly string RO_DTCANCEL = "Dtcancel";

    private DateTime? _dtcancel;

    private static readonly string RO_DTEMISSAO = "Dtemissao";

    private DateTime? _dtemissao;

    private static readonly string RO_DTQUITACAO = "Dtquitacao";

    private DateTime? _dtquitacao;

    private static readonly string RO_DTULTPAGTO = "Dtultpagto";

    private DateTime? _dtultpagto;

    private static readonly string RO_DTVENC = "Dtvenc";

    private DateTime? _dtvenc;

    private static readonly string RO_FORMAPGTO = "Formapgto";

    private string _formapgto;

    private static readonly string RO_NUMNOTA = "Numnota";

    private decimal? _numnota;

    private static readonly string RO_NUMPED = "Numped";

    private decimal? _numped;

    private static readonly string RO_NUMTRANSENT = "Numtransent";

    private decimal? _numtransent;

    private static readonly string RO_NUMTRANSENTDEVFORNEC = "Numtransentdevfornec";

    private decimal? _numtransentdevfornec;

    private static readonly string RO_NUMVERBA = "Numverba";

    private decimal _numverba;

    private static readonly string RO_ORIGEM = "Origem";

    private string _origem;

    private static readonly string RO_OUTROS = "Outros";

    private string _outros;

    private static readonly string RO_PROGRAMAQUITACAO = "Programaquitacao";

    private decimal? _programaquitacao;

    private static readonly string RO_REFERENCIA = "Referencia";

    private string _referencia;

    private static readonly string RO_REFERENCIA1 = "Referencia1";

    private string _referencia1;

    private static readonly string RO_REPFORNEC = "Repfornec";

    private string _repfornec;

    private static readonly string RO_RGREPFORNEC = "Rgrepfornec";

    private string _rgrepfornec;

    private static readonly string RO_ROTINALANC = "Rotinalanc";

    private decimal? _rotinalanc;

    private static readonly string RO_SUPERVFORNEC = "Supervfornec";

    private string _supervfornec;

    private static readonly string RO_TIPO = "Tipo";

    private string _tipo;

    private static readonly string RO_TIPOQUITACAO = "Tipoquitacao";

    private string _tipoquitacao;

    private static readonly string RO_VALOR = "Valor";

    private decimal? _valor;

    private static readonly string RO_VPAGO = "Vpago";

    private decimal? _vpago;

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCVERBA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Codbanco
    {
        get
        {
            PropriedadeAcessada(RO_CODBANCO);
            return _codbanco;
        }
        set
        {
            PropriedadeModificada(RO_CODBANCO, value);
            _codbanco = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCVERBA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Codconta
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCVERBA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codepto
    {
        get
        {
            PropriedadeAcessada(RO_CODEPTO);
            return _codepto;
        }
        set
        {
            PropriedadeModificada(RO_CODEPTO, value);
            _codepto = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCVERBA", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCVERBA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codfornec
    {
        get
        {
            PropriedadeAcessada(RO_CODFORNEC);
            return _codfornec;
        }
        set
        {
            PropriedadeModificada(RO_CODFORNEC, value);
            _codfornec = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCVERBA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfunccancel
    {
        get
        {
            PropriedadeAcessada(RO_CODFUNCCANCEL);
            return _codfunccancel;
        }
        set
        {
            PropriedadeModificada(RO_CODFUNCCANCEL, value);
            _codfunccancel = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCVERBA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfuncquitacao
    {
        get
        {
            PropriedadeAcessada(RO_CODFUNCQUITACAO);
            return _codfuncquitacao;
        }
        set
        {
            PropriedadeModificada(RO_CODFUNCQUITACAO, value);
            _codfuncquitacao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCVERBA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codsec
    {
        get
        {
            PropriedadeAcessada(RO_CODSEC);
            return _codsec;
        }
        set
        {
            PropriedadeModificada(RO_CODSEC, value);
            _codsec = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCVERBA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Codtipoverba
    {
        get
        {
            PropriedadeAcessada(RO_CODTIPOVERBA);
            return _codtipoverba;
        }
        set
        {
            PropriedadeModificada(RO_CODTIPOVERBA, value);
            _codtipoverba = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCVERBA", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 30, Precisao = 0)]
    public string Cpfrepfornec
    {
        get
        {
            PropriedadeAcessada(RO_CPFREPFORNEC);
            return _cpfrepfornec;
        }
        set
        {
            PropriedadeModificada(RO_CPFREPFORNEC, value);
            _cpfrepfornec = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCVERBA", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dataedicao
    {
        get
        {
            PropriedadeAcessada(RO_DATAEDICAO);
            return _dataedicao;
        }
        set
        {
            PropriedadeModificada(RO_DATAEDICAO, value);
            _dataedicao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCVERBA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 2)]
    public decimal? Dinheiro
    {
        get
        {
            PropriedadeAcessada(RO_DINHEIRO);
            return _dinheiro;
        }
        set
        {
            PropriedadeModificada(RO_DINHEIRO, value);
            _dinheiro = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCVERBA", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtapuracao
    {
        get
        {
            PropriedadeAcessada(RO_DTAPURACAO);
            return _dtapuracao;
        }
        set
        {
            PropriedadeModificada(RO_DTAPURACAO, value);
            _dtapuracao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCVERBA", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCVERBA", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtcancel
    {
        get
        {
            PropriedadeAcessada(RO_DTCANCEL);
            return _dtcancel;
        }
        set
        {
            PropriedadeModificada(RO_DTCANCEL, value);
            _dtcancel = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCVERBA", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtemissao
    {
        get
        {
            PropriedadeAcessada(RO_DTEMISSAO);
            return _dtemissao;
        }
        set
        {
            PropriedadeModificada(RO_DTEMISSAO, value);
            _dtemissao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCVERBA", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtquitacao
    {
        get
        {
            PropriedadeAcessada(RO_DTQUITACAO);
            return _dtquitacao;
        }
        set
        {
            PropriedadeModificada(RO_DTQUITACAO, value);
            _dtquitacao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCVERBA", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtultpagto
    {
        get
        {
            PropriedadeAcessada(RO_DTULTPAGTO);
            return _dtultpagto;
        }
        set
        {
            PropriedadeModificada(RO_DTULTPAGTO, value);
            _dtultpagto = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCVERBA", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtvenc
    {
        get
        {
            PropriedadeAcessada(RO_DTVENC);
            return _dtvenc;
        }
        set
        {
            PropriedadeModificada(RO_DTVENC, value);
            _dtvenc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCVERBA", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Formapgto
    {
        get
        {
            PropriedadeAcessada(RO_FORMAPGTO);
            return _formapgto;
        }
        set
        {
            PropriedadeModificada(RO_FORMAPGTO, value);
            _formapgto = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCVERBA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numnota
    {
        get
        {
            PropriedadeAcessada(RO_NUMNOTA);
            return _numnota;
        }
        set
        {
            PropriedadeModificada(RO_NUMNOTA, value);
            _numnota = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCVERBA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCVERBA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numtransent
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCVERBA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numtransentdevfornec
    {
        get
        {
            PropriedadeAcessada(RO_NUMTRANSENTDEVFORNEC);
            return _numtransentdevfornec;
        }
        set
        {
            PropriedadeModificada(RO_NUMTRANSENTDEVFORNEC, value);
            _numtransentdevfornec = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCVERBA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal Numverba
    {
        get
        {
            PropriedadeAcessada(RO_NUMVERBA);
            return _numverba;
        }
        set
        {
            PropriedadeModificada(RO_NUMVERBA, value);
            _numverba = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCVERBA", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Origem
    {
        get
        {
            PropriedadeAcessada(RO_ORIGEM);
            return _origem;
        }
        set
        {
            PropriedadeModificada(RO_ORIGEM, value);
            _origem = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCVERBA", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 10, Precisao = 0)]
    public string Outros
    {
        get
        {
            PropriedadeAcessada(RO_OUTROS);
            return _outros;
        }
        set
        {
            PropriedadeModificada(RO_OUTROS, value);
            _outros = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCVERBA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 0)]
    public decimal? Programaquitacao
    {
        get
        {
            PropriedadeAcessada(RO_PROGRAMAQUITACAO);
            return _programaquitacao;
        }
        set
        {
            PropriedadeModificada(RO_PROGRAMAQUITACAO, value);
            _programaquitacao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCVERBA", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 80, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCVERBA", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 80, Precisao = 0)]
    public string Referencia1
    {
        get
        {
            PropriedadeAcessada(RO_REFERENCIA1);
            return _referencia1;
        }
        set
        {
            PropriedadeModificada(RO_REFERENCIA1, value);
            _referencia1 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCVERBA", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
    public string Repfornec
    {
        get
        {
            PropriedadeAcessada(RO_REPFORNEC);
            return _repfornec;
        }
        set
        {
            PropriedadeModificada(RO_REPFORNEC, value);
            _repfornec = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCVERBA", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 30, Precisao = 0)]
    public string Rgrepfornec
    {
        get
        {
            PropriedadeAcessada(RO_RGREPFORNEC);
            return _rgrepfornec;
        }
        set
        {
            PropriedadeModificada(RO_RGREPFORNEC, value);
            _rgrepfornec = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCVERBA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Rotinalanc
    {
        get
        {
            PropriedadeAcessada(RO_ROTINALANC);
            return _rotinalanc;
        }
        set
        {
            PropriedadeModificada(RO_ROTINALANC, value);
            _rotinalanc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCVERBA", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
    public string Supervfornec
    {
        get
        {
            PropriedadeAcessada(RO_SUPERVFORNEC);
            return _supervfornec;
        }
        set
        {
            PropriedadeModificada(RO_SUPERVFORNEC, value);
            _supervfornec = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCVERBA", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Tipo
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCVERBA", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 10, Precisao = 0)]
    public string Tipoquitacao
    {
        get
        {
            PropriedadeAcessada(RO_TIPOQUITACAO);
            return _tipoquitacao;
        }
        set
        {
            PropriedadeModificada(RO_TIPOQUITACAO, value);
            _tipoquitacao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCVERBA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 2)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCVERBA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 2)]
    public decimal? Vpago
    {
        get
        {
            PropriedadeAcessada(RO_VPAGO);
            return _vpago;
        }
        set
        {
            PropriedadeModificada(RO_VPAGO, value);
            _vpago = value;
        }
    }

    public void InicializarAtributos()
    {
    }

    public string ObterNomeTabela()
    {
        return "PCVERBA";
    }

    public IEntidade NovaInstancia()
    {
        return (IEntidade)GetType().GetConstructors()[0].Invoke(null);
    }

    public void CarregarPorDataReader(IDataReader leitor)
    {
        _codbanco = AlterarTipo<decimal?>(leitor["Codbanco"]);
        _codconta = AlterarTipo<decimal?>(leitor["Codconta"]);
        _codepto = AlterarTipo<decimal?>(leitor["Codepto"]);
        _codfilial = AlterarTipo<string>(leitor["Codfilial"]);
        _codfornec = AlterarTipo<decimal?>(leitor["Codfornec"]);
        _codfunccancel = AlterarTipo<decimal?>(leitor["Codfunccancel"]);
        _codfuncquitacao = AlterarTipo<decimal?>(leitor["Codfuncquitacao"]);
        _codsec = AlterarTipo<decimal?>(leitor["Codsec"]);
        _codtipoverba = AlterarTipo<decimal?>(leitor["Codtipoverba"]);
        _cpfrepfornec = AlterarTipo<string>(leitor["Cpfrepfornec"]);
        _dataedicao = AlterarTipo<DateTime?>(leitor["Dataedicao"]);
        _dinheiro = AlterarTipo<decimal?>(leitor["Dinheiro"]);
        _dtapuracao = AlterarTipo<DateTime?>(leitor["Dtapuracao"]);
        _dtcadastro = AlterarTipo<DateTime?>(leitor["Dtcadastro"]);
        _dtcancel = AlterarTipo<DateTime?>(leitor["Dtcancel"]);
        _dtemissao = AlterarTipo<DateTime?>(leitor["Dtemissao"]);
        _dtquitacao = AlterarTipo<DateTime?>(leitor["Dtquitacao"]);
        _dtultpagto = AlterarTipo<DateTime?>(leitor["Dtultpagto"]);
        _dtvenc = AlterarTipo<DateTime?>(leitor["Dtvenc"]);
        _formapgto = AlterarTipo<string>(leitor["Formapgto"]);
        _numnota = AlterarTipo<decimal?>(leitor["Numnota"]);
        _numped = AlterarTipo<decimal?>(leitor["Numped"]);
        _numtransent = AlterarTipo<decimal?>(leitor["Numtransent"]);
        _numtransentdevfornec = AlterarTipo<decimal?>(leitor["Numtransentdevfornec"]);
        _numverba = AlterarTipo<decimal>(leitor["Numverba"]);
        _origem = AlterarTipo<string>(leitor["Origem"]);
        _outros = AlterarTipo<string>(leitor["Outros"]);
        _programaquitacao = AlterarTipo<decimal?>(leitor["Programaquitacao"]);
        _referencia = AlterarTipo<string>(leitor["Referencia"]);
        _referencia1 = AlterarTipo<string>(leitor["Referencia1"]);
        _repfornec = AlterarTipo<string>(leitor["Repfornec"]);
        _rgrepfornec = AlterarTipo<string>(leitor["Rgrepfornec"]);
        _rotinalanc = AlterarTipo<decimal?>(leitor["Rotinalanc"]);
        _supervfornec = AlterarTipo<string>(leitor["Supervfornec"]);
        _tipo = AlterarTipo<string>(leitor["Tipo"]);
        _tipoquitacao = AlterarTipo<string>(leitor["Tipoquitacao"]);
        _valor = AlterarTipo<decimal?>(leitor["Valor"]);
        _vpago = AlterarTipo<decimal?>(leitor["Vpago"]);
    }

}