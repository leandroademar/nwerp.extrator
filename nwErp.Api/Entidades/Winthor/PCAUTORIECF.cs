

////// namespace nwErp.Entidades.Caixa;

// namespace nwErp.Api.Modelos;

[Serializable]
public class PCAUTORIECF : GerenteDePropriedades, IEntidade
{
    private static readonly string RO_CODCLI = "Codcli";

    private decimal _codcli;

    private static readonly string RO_CODFILIAL = "Codfilial";

    private string _codfilial;

    private static readonly string RO_CODFUNCCX = "Codfunccx";

    private decimal _codfunccx;

    private static readonly string RO_CODFUNCUTILIZ = "Codfuncutiliz";

    private decimal? _codfuncutiliz;

    private static readonly string RO_CODPLPAG = "Codplpag";

    private decimal _codplpag;

    private static readonly string RO_CODPROD = "Codprod";

    private decimal _codprod;

    private static readonly string RO_CODUSUR = "Codusur";

    private decimal _codusur;

    private static readonly string RO_DATAAUTORIZACAO = "Dataautorizacao";

    private DateTime _dataautorizacao;

    private static readonly string RO_DATA_UTILIZACAO = "Data_utilizacao";

    private DateTime? _data_utilizacao;

    private static readonly string RO_DTEXPORTACAO = "Dtexportacao";

    private DateTime? _dtexportacao;

    private static readonly string RO_EXPORTADO = "Exportado";

    private string _exportado;

    private static readonly string RO_IMPORTADO = "Importado";

    private string _importado;

    private static readonly string RO_NRAUTORIZACAO = "Nrautorizacao";

    private decimal? _nrautorizacao;

    private static readonly string RO_NRAUTORIZACAOECF = "Nrautorizacaoecf";

    private decimal _nrautorizacaoecf;

    private static readonly string RO_NUMCAIXA = "Numcaixa";

    private decimal _numcaixa;

    private static readonly string RO_NUMCUPOM = "Numcupom";

    private decimal? _numcupom;

    private static readonly string RO_NUMPED = "Numped";

    private decimal? _numped;

    private static readonly string RO_NUMPEDECF = "Numpedecf";

    private decimal _numpedecf;

    private static readonly string RO_PERCDESCAUTOR = "Percdescautor";

    private decimal _percdescautor;

    private static readonly string RO_PVENDAATUAL = "Pvendaatual";

    private decimal? _pvendaatual;

    private static readonly string RO_PVENDIDO = "Pvendido";

    private decimal? _pvendido;

    private static readonly string RO_SERIEEQUIP = "Serieequip";

    private string _serieequip;

    private static readonly string RO_STATUSUTILIZ = "Statusutiliz";

    private string _statusutiliz;

    private static readonly string RO_CODFUNCCADASTRO = "Codfunccadastro";

    private decimal? _codfunccadastro;

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCAUTORIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal Codcli
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCAUTORIECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCAUTORIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCAUTORIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfuncutiliz
    {
        get
        {
            PropriedadeAcessada(RO_CODFUNCUTILIZ);
            return _codfuncutiliz;
        }
        set
        {
            PropriedadeModificada(RO_CODFUNCUTILIZ, value);
            _codfuncutiliz = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCAUTORIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal Codplpag
    {
        get
        {
            PropriedadeAcessada(RO_CODPLPAG);
            return _codplpag;
        }
        set
        {
            PropriedadeModificada(RO_CODPLPAG, value);
            _codplpag = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCAUTORIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal Codprod
    {
        get
        {
            PropriedadeAcessada(RO_CODPROD);
            return _codprod;
        }
        set
        {
            PropriedadeModificada(RO_CODPROD, value);
            _codprod = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCAUTORIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal Codusur
    {
        get
        {
            PropriedadeAcessada(RO_CODUSUR);
            return _codusur;
        }
        set
        {
            PropriedadeModificada(RO_CODUSUR, value);
            _codusur = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCAUTORIECF", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime Dataautorizacao
    {
        get
        {
            PropriedadeAcessada(RO_DATAAUTORIZACAO);
            return _dataautorizacao;
        }
        set
        {
            PropriedadeModificada(RO_DATAAUTORIZACAO, value);
            _dataautorizacao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCAUTORIECF", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Data_utilizacao
    {
        get
        {
            PropriedadeAcessada(RO_DATA_UTILIZACAO);
            return _data_utilizacao;
        }
        set
        {
            PropriedadeModificada(RO_DATA_UTILIZACAO, value);
            _data_utilizacao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCAUTORIECF", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCAUTORIECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCAUTORIECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCAUTORIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Nrautorizacao
    {
        get
        {
            PropriedadeAcessada(RO_NRAUTORIZACAO);
            return _nrautorizacao;
        }
        set
        {
            PropriedadeModificada(RO_NRAUTORIZACAO, value);
            _nrautorizacao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCAUTORIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal Nrautorizacaoecf
    {
        get
        {
            PropriedadeAcessada(RO_NRAUTORIZACAOECF);
            return _nrautorizacaoecf;
        }
        set
        {
            PropriedadeModificada(RO_NRAUTORIZACAOECF, value);
            _nrautorizacaoecf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCAUTORIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCAUTORIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCAUTORIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCAUTORIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCAUTORIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 2)]
    public decimal Percdescautor
    {
        get
        {
            PropriedadeAcessada(RO_PERCDESCAUTOR);
            return _percdescautor;
        }
        set
        {
            PropriedadeModificada(RO_PERCDESCAUTOR, value);
            _percdescautor = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCAUTORIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 2)]
    public decimal? Pvendaatual
    {
        get
        {
            PropriedadeAcessada(RO_PVENDAATUAL);
            return _pvendaatual;
        }
        set
        {
            PropriedadeModificada(RO_PVENDAATUAL, value);
            _pvendaatual = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCAUTORIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 3)]
    public decimal? Pvendido
    {
        get
        {
            PropriedadeAcessada(RO_PVENDIDO);
            return _pvendido;
        }
        set
        {
            PropriedadeModificada(RO_PVENDIDO, value);
            _pvendido = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCAUTORIECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 30, Precisao = 0)]
    public string Serieequip
    {
        get
        {
            PropriedadeAcessada(RO_SERIEEQUIP);
            return _serieequip;
        }
        set
        {
            PropriedadeModificada(RO_SERIEEQUIP, value);
            _serieequip = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCAUTORIECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Statusutiliz
    {
        get
        {
            PropriedadeAcessada(RO_STATUSUTILIZ);
            return _statusutiliz;
        }
        set
        {
            PropriedadeModificada(RO_STATUSUTILIZ, value);
            _statusutiliz = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCAUTORIECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
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

    public void InicializarAtributos()
    {
    }

    public string ObterNomeTabela()
    {
        return "PCAUTORIECF";
    }

    public IEntidade NovaInstancia()
    {
        return (IEntidade)GetType().GetConstructors()[0].Invoke(null);
    }

    public void CarregarPorDataReader(IDataReader leitor)
    {
        _codcli = AlterarTipo<decimal>(leitor["Codcli"]);
        _codfilial = AlterarTipo<string>(leitor["Codfilial"]);
        _codfunccx = AlterarTipo<decimal>(leitor["Codfunccx"]);
        _codfuncutiliz = AlterarTipo<decimal?>(leitor["Codfuncutiliz"]);
        _codplpag = AlterarTipo<decimal>(leitor["Codplpag"]);
        _codprod = AlterarTipo<decimal>(leitor["Codprod"]);
        _codusur = AlterarTipo<decimal>(leitor["Codusur"]);
        _dataautorizacao = AlterarTipo<DateTime>(leitor["Dataautorizacao"]);
        _data_utilizacao = AlterarTipo<DateTime?>(leitor["Data_utilizacao"]);
        _dtexportacao = AlterarTipo<DateTime?>(leitor["Dtexportacao"]);
        _exportado = AlterarTipo<string>(leitor["Exportado"]);
        _importado = AlterarTipo<string>(leitor["Importado"]);
        _nrautorizacao = AlterarTipo<decimal?>(leitor["Nrautorizacao"]);
        _nrautorizacaoecf = AlterarTipo<decimal>(leitor["Nrautorizacaoecf"]);
        _numcaixa = AlterarTipo<decimal>(leitor["Numcaixa"]);
        _numcupom = AlterarTipo<decimal?>(leitor["Numcupom"]);
        _numped = AlterarTipo<decimal?>(leitor["Numped"]);
        _numpedecf = AlterarTipo<decimal>(leitor["Numpedecf"]);
        _percdescautor = AlterarTipo<decimal>(leitor["Percdescautor"]);
        _pvendaatual = AlterarTipo<decimal?>(leitor["Pvendaatual"]);
        _pvendido = AlterarTipo<decimal?>(leitor["Pvendido"]);
        _serieequip = AlterarTipo<string>(leitor["Serieequip"]);
        _statusutiliz = AlterarTipo<string>(leitor["Statusutiliz"]);
        _codfunccadastro = AlterarTipo<decimal?>(leitor["Codfunccadastro"]);
    }

}