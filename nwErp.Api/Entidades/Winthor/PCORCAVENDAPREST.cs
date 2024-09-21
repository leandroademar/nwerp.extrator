

////// namespace nwErp.Entidades.Winthor;

// namespace nwErp.Api.Modelos;

[Serializable]
public class PCORCAVENDAPREST : GerenteDePropriedades, IEntidade
{
    private string _captura;

    private string _cartao;

    private string _codaid;

    private string _codautorizacao;

    private string _codcob;

    private string _codprodutomatriz;

    private string _codprodutosecundario;

    private string _codresposta;

    private string _comprovantecliente;

    private string _comprovantevendedor;

    private DateTime _dtpagamento;

    private DateTime? _dtrequisicao;

    private DateTime? _dtservidor;

    private string _email;

    private string _estacquirer;

    private string _estvenda;

    private string _fluxo;

    private string _idaplicacao;

    private string _idtransacao;

    private string _nomebandeira;

    private string _nomeprodutomatriz;

    private string _nomeprodutosecundario;

    private string _nsu;

    private decimal _numorca;

    private decimal? _parcelas;

    private string _referencia;

    private string _retornoaplicacao;

    private string _tipotransacao;

    private decimal? _valor;

    private string _versaoappfinanceira;

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAPREST", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 10, Precisao = 0)]
    public string Captura
    {
        get
        {
            PropriedadeAcessada("Captura");
            return _captura;
        }
        set
        {
            PropriedadeModificada("Captura", value);
            _captura = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAPREST", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 30, Precisao = 0)]
    public string Cartao
    {
        get
        {
            PropriedadeAcessada("Cartao");
            return _cartao;
        }
        set
        {
            PropriedadeModificada("Cartao", value);
            _cartao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAPREST", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 30, Precisao = 0)]
    public string Codaid
    {
        get
        {
            PropriedadeAcessada("Codaid");
            return _codaid;
        }
        set
        {
            PropriedadeModificada("Codaid", value);
            _codaid = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAPREST", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
    public string Codautorizacao
    {
        get
        {
            PropriedadeAcessada("Codautorizacao");
            return _codautorizacao;
        }
        set
        {
            PropriedadeModificada("Codautorizacao", value);
            _codautorizacao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAPREST", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 4, Precisao = 0)]
    public string Codcob
    {
        get
        {
            PropriedadeAcessada("Codcob");
            return _codcob;
        }
        set
        {
            PropriedadeModificada("Codcob", value);
            _codcob = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAPREST", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 10, Precisao = 0)]
    public string Codprodutomatriz
    {
        get
        {
            PropriedadeAcessada("Codprodutomatriz");
            return _codprodutomatriz;
        }
        set
        {
            PropriedadeModificada("Codprodutomatriz", value);
            _codprodutomatriz = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAPREST", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 10, Precisao = 0)]
    public string Codprodutosecundario
    {
        get
        {
            PropriedadeAcessada("Codprodutosecundario");
            return _codprodutosecundario;
        }
        set
        {
            PropriedadeModificada("Codprodutosecundario", value);
            _codprodutosecundario = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAPREST", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 10, Precisao = 0)]
    public string Codresposta
    {
        get
        {
            PropriedadeAcessada("Codresposta");
            return _codresposta;
        }
        set
        {
            PropriedadeModificada("Codresposta", value);
            _codresposta = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAPREST", Tipo = TipoDoCampoNoBancoDeDados.Binario, Tamanho = 4000, Precisao = 0)]
    public string Comprovantecliente
    {
        get
        {
            PropriedadeAcessada("Comprovantecliente");
            return _comprovantecliente;
        }
        set
        {
            PropriedadeModificada("Comprovantecliente", value);
            _comprovantecliente = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAPREST", Tipo = TipoDoCampoNoBancoDeDados.Binario, Tamanho = 4000, Precisao = 0)]
    public string Comprovantevendedor
    {
        get
        {
            PropriedadeAcessada("Comprovantevendedor");
            return _comprovantevendedor;
        }
        set
        {
            PropriedadeModificada("Comprovantevendedor", value);
            _comprovantevendedor = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCORCAVENDAPREST", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime Dtpagamento
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAPREST", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtrequisicao
    {
        get
        {
            PropriedadeAcessada("Dtrequisicao");
            return _dtrequisicao;
        }
        set
        {
            PropriedadeModificada("Dtrequisicao", value);
            _dtrequisicao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAPREST", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtservidor
    {
        get
        {
            PropriedadeAcessada("Dtservidor");
            return _dtservidor;
        }
        set
        {
            PropriedadeModificada("Dtservidor", value);
            _dtservidor = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAPREST", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 100, Precisao = 0)]
    public string Email
    {
        get
        {
            PropriedadeAcessada("Email");
            return _email;
        }
        set
        {
            PropriedadeModificada("Email", value);
            _email = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAPREST", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 30, Precisao = 0)]
    public string Estacquirer
    {
        get
        {
            PropriedadeAcessada("Estacquirer");
            return _estacquirer;
        }
        set
        {
            PropriedadeModificada("Estacquirer", value);
            _estacquirer = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAPREST", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 30, Precisao = 0)]
    public string Estvenda
    {
        get
        {
            PropriedadeAcessada("Estvenda");
            return _estvenda;
        }
        set
        {
            PropriedadeModificada("Estvenda", value);
            _estvenda = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAPREST", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 10, Precisao = 0)]
    public string Fluxo
    {
        get
        {
            PropriedadeAcessada("Fluxo");
            return _fluxo;
        }
        set
        {
            PropriedadeModificada("Fluxo", value);
            _fluxo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAPREST", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 30, Precisao = 0)]
    public string Idaplicacao
    {
        get
        {
            PropriedadeAcessada("Idaplicacao");
            return _idaplicacao;
        }
        set
        {
            PropriedadeModificada("Idaplicacao", value);
            _idaplicacao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAPREST", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 10, Precisao = 0)]
    public string Idtransacao
    {
        get
        {
            PropriedadeAcessada("Idtransacao");
            return _idtransacao;
        }
        set
        {
            PropriedadeModificada("Idtransacao", value);
            _idtransacao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAPREST", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 30, Precisao = 0)]
    public string Nomebandeira
    {
        get
        {
            PropriedadeAcessada("Nomebandeira");
            return _nomebandeira;
        }
        set
        {
            PropriedadeModificada("Nomebandeira", value);
            _nomebandeira = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAPREST", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 30, Precisao = 0)]
    public string Nomeprodutomatriz
    {
        get
        {
            PropriedadeAcessada("Nomeprodutomatriz");
            return _nomeprodutomatriz;
        }
        set
        {
            PropriedadeModificada("Nomeprodutomatriz", value);
            _nomeprodutomatriz = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAPREST", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 30, Precisao = 0)]
    public string Nomeprodutosecundario
    {
        get
        {
            PropriedadeAcessada("Nomeprodutosecundario");
            return _nomeprodutosecundario;
        }
        set
        {
            PropriedadeModificada("Nomeprodutosecundario", value);
            _nomeprodutosecundario = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAPREST", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCORCAVENDAPREST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal Numorca
    {
        get
        {
            PropriedadeAcessada("Numorca");
            return _numorca;
        }
        set
        {
            PropriedadeModificada("Numorca", value);
            _numorca = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAPREST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Parcelas
    {
        get
        {
            PropriedadeAcessada("Parcelas");
            return _parcelas;
        }
        set
        {
            PropriedadeModificada("Parcelas", value);
            _parcelas = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAPREST", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 30, Precisao = 0)]
    public string Referencia
    {
        get
        {
            PropriedadeAcessada("Referencia");
            return _referencia;
        }
        set
        {
            PropriedadeModificada("Referencia", value);
            _referencia = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAPREST", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 30, Precisao = 0)]
    public string Retornoaplicacao
    {
        get
        {
            PropriedadeAcessada("Retornoaplicacao");
            return _retornoaplicacao;
        }
        set
        {
            PropriedadeModificada("Retornoaplicacao", value);
            _retornoaplicacao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAPREST", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Tipotransacao
    {
        get
        {
            PropriedadeAcessada("Tipotransacao");
            return _tipotransacao;
        }
        set
        {
            PropriedadeModificada("Tipotransacao", value);
            _tipotransacao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAPREST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 22, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAPREST", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 30, Precisao = 0)]
    public string Versaoappfinanceira
    {
        get
        {
            PropriedadeAcessada("Versaoappfinanceira");
            return _versaoappfinanceira;
        }
        set
        {
            PropriedadeModificada("Versaoappfinanceira", value);
            _versaoappfinanceira = value;
        }
    }

    public void InicializarAtributos()
    {
    }

    public string ObterNomeTabela()
    {
        return "PCORCAVENDAPREST";
    }

    public IEntidade NovaInstancia()
    {
        return (IEntidade)GetType().GetConstructors()[0].Invoke(null);
    }

    public void CarregarPorDataReader(IDataReader leitor)
    {
        _captura = AlterarTipo<string>(leitor["Captura"]);
        _cartao = AlterarTipo<string>(leitor["Cartao"]);
        _codaid = AlterarTipo<string>(leitor["Codaid"]);
        _codautorizacao = AlterarTipo<string>(leitor["Codautorizacao"]);
        _codcob = AlterarTipo<string>(leitor["Codcob"]);
        _codprodutomatriz = AlterarTipo<string>(leitor["Codprodutomatriz"]);
        _codprodutosecundario = AlterarTipo<string>(leitor["Codprodutosecundario"]);
        _codresposta = AlterarTipo<string>(leitor["Codresposta"]);
        _comprovantecliente = AlterarTipo<string>(leitor["Comprovantecliente"]);
        _comprovantevendedor = AlterarTipo<string>(leitor["Comprovantevendedor"]);
        _dtpagamento = AlterarTipo<DateTime>(leitor["Dtpagamento"]);
        _dtrequisicao = AlterarTipo<DateTime?>(leitor["Dtrequisicao"]);
        _dtservidor = AlterarTipo<DateTime?>(leitor["Dtservidor"]);
        _email = AlterarTipo<string>(leitor["Email"]);
        _estacquirer = AlterarTipo<string>(leitor["Estacquirer"]);
        _estvenda = AlterarTipo<string>(leitor["Estvenda"]);
        _fluxo = AlterarTipo<string>(leitor["Fluxo"]);
        _idaplicacao = AlterarTipo<string>(leitor["Idaplicacao"]);
        _idtransacao = AlterarTipo<string>(leitor["Idtransacao"]);
        _nomebandeira = AlterarTipo<string>(leitor["Nomebandeira"]);
        _nomeprodutomatriz = AlterarTipo<string>(leitor["Nomeprodutomatriz"]);
        _nomeprodutosecundario = AlterarTipo<string>(leitor["Nomeprodutosecundario"]);
        _nsu = AlterarTipo<string>(leitor["Nsu"]);
        _numorca = AlterarTipo<decimal>(leitor["Numorca"]);
        _parcelas = AlterarTipo<decimal?>(leitor["Parcelas"]);
        _referencia = AlterarTipo<string>(leitor["Referencia"]);
        _retornoaplicacao = AlterarTipo<string>(leitor["Retornoaplicacao"]);
        _tipotransacao = AlterarTipo<string>(leitor["Tipotransacao"]);
        _valor = AlterarTipo<decimal?>(leitor["Valor"]);
        _versaoappfinanceira = AlterarTipo<string>(leitor["Versaoappfinanceira"]);
    }

}