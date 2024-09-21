

////// // namespace nwErp.Entidades.Caixa;

// // namespace nwErp.Api.Modelos;

[Serializable]
public class PCHISTORICOSMOTOROFERTA : GerenteDePropriedades, IEntidade
{
    private string _dadosmotoroferta;

    private DateTime _data;

    private string _exportado;

    private decimal _numcaixa;

    private decimal _numpedecf;

    private static readonly string RO_NUMTRANSVENDA = "Numtransvenda";

    private decimal? _numtransvenda;

    private string _dadosenvio;

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCHISTORICOSMOTOROFERTA", Tipo = TipoDoCampoNoBancoDeDados.Binario, Tamanho = 4000, Precisao = 0)]
    public string Dadosmotoroferta
    {
        get
        {
            PropriedadeAcessada("Dadosmotoroferta");
            return _dadosmotoroferta;
        }
        set
        {
            PropriedadeModificada("Dadosmotoroferta", value);
            _dadosmotoroferta = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCHISTORICOSMOTOROFERTA", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCHISTORICOSMOTOROFERTA", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCHISTORICOSMOTOROFERTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCHISTORICOSMOTOROFERTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCHISTORICOSMOTOROFERTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numtransvenda
    {
        get
        {
            PropriedadeAcessada(RO_NUMTRANSVENDA);
            return _numtransvenda;
        }
        set
        {
            PropriedadeModificada(RO_NUMTRANSVENDA, value);
            _numtransvenda = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCHISTORICOSMOTOROFERTA", Tipo = TipoDoCampoNoBancoDeDados.Binario, Tamanho = 4000, Precisao = 0)]
    public string Dadosenvio
    {
        get
        {
            PropriedadeAcessada("Dadosenvio");
            return _dadosenvio;
        }
        set
        {
            PropriedadeModificada("Dadosenvio", value);
            _dadosenvio = value;
        }
    }

    public void InicializarAtributos()
    {
    }

    public string ObterNomeTabela()
    {
        return "PCHISTORICOSMOTOROFERTA";
    }

    public IEntidade NovaInstancia()
    {
        return (IEntidade)GetType().GetConstructors()[0].Invoke(null);
    }

    public void CarregarPorDataReader(IDataReader leitor)
    {
        _dadosmotoroferta = AlterarTipo<string>(leitor["Dadosmotoroferta"]);
        _data = AlterarTipo<DateTime>(leitor["Data"]);
        _exportado = AlterarTipo<string>(leitor["Exportado"]);
        _numcaixa = AlterarTipo<decimal>(leitor["Numcaixa"]);
        _numpedecf = AlterarTipo<decimal>(leitor["Numpedecf"]);
        _numtransvenda = AlterarTipo<decimal?>(leitor["Numtransvenda"]);
        _dadosenvio = AlterarTipo<string>(leitor["Dadosenvio"]);
    }

}