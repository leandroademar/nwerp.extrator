

////// namespace nwErp.Entidades.Caixa;

// namespace nwErp.Api.Modelos;

[Serializable]
public class PCRECFATURAECF : GerenteDePropriedades, IEntidade
{
    private string _banco;

    private string _codfilial;

    private decimal _codfunccx;

    private string _codigoautcb;

    private string _codigobarra;

    private DateTime _data;

    private decimal? _desconto;

    private DateTime? _dtexportacao;

    private DateTime? _dtmovimentocx;

    private DateTime? _dtpagamento;

    private string _exportado;

    private string _nsu;

    private string _nsucancelamento;

    private string _nsucbcancelamento;

    private string _nsusitef;

    private decimal _numcaixa;

    private decimal _numcupom;

    private string _numfatura;

    private decimal? _numfechamentomovcx;

    private decimal _numpedecf;

    private string _numserieequip;

    private decimal? _numtransvenda;

    private string _origemfatura;

    private string _status;

    private string _tipofatura;

    private decimal? _valor;

    private decimal? _valoracrescimo;

    private decimal? _valororginal;

    private DateTime? _vencimento;

    private static readonly string RO_CODOPERRECARGACEL = "Codoperrecargacel";

    private decimal? _codoperrecargacel;

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCRECFATURAECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Banco
    {
        get
        {
            PropriedadeAcessada("Banco");
            return _banco;
        }
        set
        {
            PropriedadeModificada("Banco", value);
            _banco = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCRECFATURAECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Codfilial
    {
        get
        {
            PropriedadeAcessada("Codfilial");
            return _codfilial;
        }
        set
        {
            PropriedadeModificada("Codfilial", value);
            _codfilial = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCRECFATURAECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal Codfunccx
    {
        get
        {
            PropriedadeAcessada("Codfunccx");
            return _codfunccx;
        }
        set
        {
            PropriedadeModificada("Codfunccx", value);
            _codfunccx = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCRECFATURAECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
    public string Codigoautcb
    {
        get
        {
            PropriedadeAcessada("Codigoautcb");
            return _codigoautcb;
        }
        set
        {
            PropriedadeModificada("Codigoautcb", value);
            _codigoautcb = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCRECFATURAECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 55, Precisao = 0)]
    public string Codigobarra
    {
        get
        {
            PropriedadeAcessada("Codigobarra");
            return _codigobarra;
        }
        set
        {
            PropriedadeModificada("Codigobarra", value);
            _codigobarra = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCRECFATURAECF", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime Data
    {
        get
        {
            PropriedadeAcessada("Data");
            return _data;
        }
        set
        {
            PropriedadeModificada("Data", value);
            _data = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCRECFATURAECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 2)]
    public decimal? Desconto
    {
        get
        {
            PropriedadeAcessada("Desconto");
            return _desconto;
        }
        set
        {
            PropriedadeModificada("Desconto", value);
            _desconto = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCRECFATURAECF", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtexportacao
    {
        get
        {
            PropriedadeAcessada("Dtexportacao");
            return _dtexportacao;
        }
        set
        {
            PropriedadeModificada("Dtexportacao", value);
            _dtexportacao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCRECFATURAECF", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtmovimentocx
    {
        get
        {
            PropriedadeAcessada("Dtmovimentocx");
            return _dtmovimentocx;
        }
        set
        {
            PropriedadeModificada("Dtmovimentocx", value);
            _dtmovimentocx = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCRECFATURAECF", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtpagamento
    {
        get
        {
            PropriedadeAcessada("Dtpagamento");
            return _dtpagamento;
        }
        set
        {
            PropriedadeModificada("Dtpagamento", value);
            _dtpagamento = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCRECFATURAECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Exportado
    {
        get
        {
            PropriedadeAcessada("Exportado");
            return _exportado;
        }
        set
        {
            PropriedadeModificada("Exportado", value);
            _exportado = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCRECFATURAECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
    public string Nsu
    {
        get
        {
            PropriedadeAcessada("Nsu");
            return _nsu;
        }
        set
        {
            PropriedadeModificada("Nsu", value);
            _nsu = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCRECFATURAECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
    public string Nsucancelamento
    {
        get
        {
            PropriedadeAcessada("Nsucancelamento");
            return _nsucancelamento;
        }
        set
        {
            PropriedadeModificada("Nsucancelamento", value);
            _nsucancelamento = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCRECFATURAECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
    public string Nsucbcancelamento
    {
        get
        {
            PropriedadeAcessada("Nsucbcancelamento");
            return _nsucbcancelamento;
        }
        set
        {
            PropriedadeModificada("Nsucbcancelamento", value);
            _nsucbcancelamento = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCRECFATURAECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
    public string Nsusitef
    {
        get
        {
            PropriedadeAcessada("Nsusitef");
            return _nsusitef;
        }
        set
        {
            PropriedadeModificada("Nsusitef", value);
            _nsusitef = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCRECFATURAECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal Numcaixa
    {
        get
        {
            PropriedadeAcessada("Numcaixa");
            return _numcaixa;
        }
        set
        {
            PropriedadeModificada("Numcaixa", value);
            _numcaixa = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCRECFATURAECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal Numcupom
    {
        get
        {
            PropriedadeAcessada("Numcupom");
            return _numcupom;
        }
        set
        {
            PropriedadeModificada("Numcupom", value);
            _numcupom = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCRECFATURAECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 10, Precisao = 0)]
    public string Numfatura
    {
        get
        {
            PropriedadeAcessada("Numfatura");
            return _numfatura;
        }
        set
        {
            PropriedadeModificada("Numfatura", value);
            _numfatura = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCRECFATURAECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numfechamentomovcx
    {
        get
        {
            PropriedadeAcessada("Numfechamentomovcx");
            return _numfechamentomovcx;
        }
        set
        {
            PropriedadeModificada("Numfechamentomovcx", value);
            _numfechamentomovcx = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCRECFATURAECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal Numpedecf
    {
        get
        {
            PropriedadeAcessada("Numpedecf");
            return _numpedecf;
        }
        set
        {
            PropriedadeModificada("Numpedecf", value);
            _numpedecf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCRECFATURAECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 30, Precisao = 0)]
    public string Numserieequip
    {
        get
        {
            PropriedadeAcessada("Numserieequip");
            return _numserieequip;
        }
        set
        {
            PropriedadeModificada("Numserieequip", value);
            _numserieequip = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCRECFATURAECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numtransvenda
    {
        get
        {
            PropriedadeAcessada("Numtransvenda");
            return _numtransvenda;
        }
        set
        {
            PropriedadeModificada("Numtransvenda", value);
            _numtransvenda = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCRECFATURAECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Origemfatura
    {
        get
        {
            PropriedadeAcessada("Origemfatura");
            return _origemfatura;
        }
        set
        {
            PropriedadeModificada("Origemfatura", value);
            _origemfatura = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCRECFATURAECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Status
    {
        get
        {
            PropriedadeAcessada("Status");
            return _status;
        }
        set
        {
            PropriedadeModificada("Status", value);
            _status = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCRECFATURAECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Tipofatura
    {
        get
        {
            PropriedadeAcessada("Tipofatura");
            return _tipofatura;
        }
        set
        {
            PropriedadeModificada("Tipofatura", value);
            _tipofatura = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCRECFATURAECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 2)]
    public decimal? Valor
    {
        get
        {
            PropriedadeAcessada("Valor");
            return _valor;
        }
        set
        {
            PropriedadeModificada("Valor", value);
            _valor = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCRECFATURAECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 2)]
    public decimal? Valoracrescimo
    {
        get
        {
            PropriedadeAcessada("Valoracrescimo");
            return _valoracrescimo;
        }
        set
        {
            PropriedadeModificada("Valoracrescimo", value);
            _valoracrescimo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCRECFATURAECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 2)]
    public decimal? Valororginal
    {
        get
        {
            PropriedadeAcessada("Valororginal");
            return _valororginal;
        }
        set
        {
            PropriedadeModificada("Valororginal", value);
            _valororginal = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCRECFATURAECF", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Vencimento
    {
        get
        {
            PropriedadeAcessada("Vencimento");
            return _vencimento;
        }
        set
        {
            PropriedadeModificada("Vencimento", value);
            _vencimento = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCRECFATURAECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 0)]
    public decimal? Codoperrecargacel
    {
        get
        {
            PropriedadeAcessada(RO_CODOPERRECARGACEL);
            return _codoperrecargacel;
        }
        set
        {
            PropriedadeModificada(RO_CODOPERRECARGACEL, value);
            _codoperrecargacel = value;
        }
    }

    public void InicializarAtributos()
    {
    }

    public string ObterNomeTabela()
    {
        return "PCRECFATURAECF";
    }

    public IEntidade NovaInstancia()
    {
        return (IEntidade)GetType().GetConstructors()[0].Invoke(null);
    }

    public void CarregarPorDataReader(IDataReader leitor)
    {
        _banco = AlterarTipo<string>(leitor["Banco"]);
        _codfilial = AlterarTipo<string>(leitor["Codfilial"]);
        _codfunccx = AlterarTipo<decimal>(leitor["Codfunccx"]);
        _codigoautcb = AlterarTipo<string>(leitor["Codigoautcb"]);
        _codigobarra = AlterarTipo<string>(leitor["Codigobarra"]);
        _data = AlterarTipo<DateTime>(leitor["Data"]);
        _desconto = AlterarTipo<decimal?>(leitor["Desconto"]);
        _dtexportacao = AlterarTipo<DateTime?>(leitor["Dtexportacao"]);
        _dtmovimentocx = AlterarTipo<DateTime?>(leitor["Dtmovimentocx"]);
        _dtpagamento = AlterarTipo<DateTime?>(leitor["Dtpagamento"]);
        _exportado = AlterarTipo<string>(leitor["Exportado"]);
        _nsu = AlterarTipo<string>(leitor["Nsu"]);
        _nsucancelamento = AlterarTipo<string>(leitor["Nsucancelamento"]);
        _nsucbcancelamento = AlterarTipo<string>(leitor["Nsucbcancelamento"]);
        _nsusitef = AlterarTipo<string>(leitor["Nsusitef"]);
        _numcaixa = AlterarTipo<decimal>(leitor["Numcaixa"]);
        _numcupom = AlterarTipo<decimal>(leitor["Numcupom"]);
        _numfatura = AlterarTipo<string>(leitor["Numfatura"]);
        _numfechamentomovcx = AlterarTipo<decimal?>(leitor["Numfechamentomovcx"]);
        _numpedecf = AlterarTipo<decimal>(leitor["Numpedecf"]);
        _numserieequip = AlterarTipo<string>(leitor["Numserieequip"]);
        _numtransvenda = AlterarTipo<decimal?>(leitor["Numtransvenda"]);
        _origemfatura = AlterarTipo<string>(leitor["Origemfatura"]);
        _status = AlterarTipo<string>(leitor["Status"]);
        _tipofatura = AlterarTipo<string>(leitor["Tipofatura"]);
        _valor = AlterarTipo<decimal?>(leitor["Valor"]);
        _valoracrescimo = AlterarTipo<decimal?>(leitor["Valoracrescimo"]);
        _valororginal = AlterarTipo<decimal?>(leitor["Valororginal"]);
        _vencimento = AlterarTipo<DateTime?>(leitor["Vencimento"]);
        _codoperrecargacel = AlterarTipo<decimal?>(leitor["Codoperrecargacel"]);
    }

}