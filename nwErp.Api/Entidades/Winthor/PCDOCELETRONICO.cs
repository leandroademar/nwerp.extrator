

////// // namespace nwErp.Entidades.Winthor;

// // namespace nwErp.Api.Modelos;

[Serializable]
public class PCDOCELETRONICO : GerenteDePropriedades, IEntidade
{
    private static readonly string RO_MOVIMENTO = "Movimento";

    private string _movimento;

    private static readonly string RO_NUMTRANSACAO = "Numtransacao";

    private decimal _numtransacao;

    private static readonly string RO_XMLCCE = "Xmlcce";

    private string _xmlcce;

    private static readonly string RO_XMLCTE = "Xmlcte";

    private string _xmlcte;

    private static readonly string RO_XMLMDFE = "Xmlmdfe";

    private string _xmlmdfe;

    private static readonly string RO_XMLNFE = "Xmlnfe";

    private string _xmlnfe;

    private string _xmlnfce;

    private string _xmlnfcecancelamento;

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCDOCELETRONICO", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Movimento
    {
        get
        {
            PropriedadeAcessada(RO_MOVIMENTO);
            return _movimento;
        }
        set
        {
            PropriedadeModificada(RO_MOVIMENTO, value);
            _movimento = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCDOCELETRONICO", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal Numtransacao
    {
        get
        {
            PropriedadeAcessada(RO_NUMTRANSACAO);
            return _numtransacao;
        }
        set
        {
            PropriedadeModificada(RO_NUMTRANSACAO, value);
            _numtransacao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCDOCELETRONICO", Tipo = TipoDoCampoNoBancoDeDados.Binario, Tamanho = 8000, Precisao = 0)]
    public string Xmlcce
    {
        get
        {
            PropriedadeAcessada(RO_XMLCCE);
            return _xmlcce;
        }
        set
        {
            PropriedadeModificada(RO_XMLCCE, value);
            _xmlcce = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCDOCELETRONICO", Tipo = TipoDoCampoNoBancoDeDados.Binario, Tamanho = 8000, Precisao = 0)]
    public string Xmlcte
    {
        get
        {
            PropriedadeAcessada(RO_XMLCTE);
            return _xmlcte;
        }
        set
        {
            PropriedadeModificada(RO_XMLCTE, value);
            _xmlcte = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCDOCELETRONICO", Tipo = TipoDoCampoNoBancoDeDados.Binario, Tamanho = 8000, Precisao = 0)]
    public string Xmlmdfe
    {
        get
        {
            PropriedadeAcessada(RO_XMLMDFE);
            return _xmlmdfe;
        }
        set
        {
            PropriedadeModificada(RO_XMLMDFE, value);
            _xmlmdfe = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCDOCELETRONICO", Tipo = TipoDoCampoNoBancoDeDados.Binario, Tamanho = 8000, Precisao = 0)]
    public string Xmlnfe
    {
        get
        {
            PropriedadeAcessada(RO_XMLNFE);
            return _xmlnfe;
        }
        set
        {
            PropriedadeModificada(RO_XMLNFE, value);
            _xmlnfe = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCDOCELETRONICO", Tipo = TipoDoCampoNoBancoDeDados.Binario, Tamanho = 8000, Precisao = 0)]
    public string Xmlnfce
    {
        get
        {
            PropriedadeAcessada("Xmlnfce");
            return _xmlnfce;
        }
        set
        {
            PropriedadeModificada("Xmlnfce", value);
            _xmlnfce = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCDOCELETRONICO", Tipo = TipoDoCampoNoBancoDeDados.Binario, Tamanho = 8000, Precisao = 0)]
    public string Xmlnfcecancelamento
    {
        get
        {
            PropriedadeAcessada("Xmlnfcecancelamento");
            return _xmlnfcecancelamento;
        }
        set
        {
            PropriedadeModificada("Xmlnfcecancelamento", value);
            _xmlnfcecancelamento = value;
        }
    }

    public void InicializarAtributos()
    {
    }

    public string ObterNomeTabela()
    {
        return "PCDOCELETRONICO";
    }

    public IEntidade NovaInstancia()
    {
        return (IEntidade)GetType().GetConstructors()[0].Invoke(null);
    }

    public void CarregarPorDataReader(IDataReader leitor)
    {
        _movimento = AlterarTipo<string>(leitor["Movimento"]);
        _numtransacao = AlterarTipo<decimal>(leitor["Numtransacao"]);
        _xmlcce = AlterarTipo<string>(leitor["Xmlcce"]);
        _xmlcte = AlterarTipo<string>(leitor["Xmlcte"]);
        _xmlmdfe = AlterarTipo<string>(leitor["Xmlmdfe"]);
        _xmlnfe = AlterarTipo<string>(leitor["Xmlnfe"]);
        _xmlnfce = AlterarTipo<string>(leitor["Xmlnfce"]);
        _xmlnfcecancelamento = AlterarTipo<string>(leitor["Xmlnfcecancelamento"]);
    }

}