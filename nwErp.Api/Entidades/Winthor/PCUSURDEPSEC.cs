
// namespace nwErp.Api.Modelos;

[Serializable]
public class PCUSURDEPSEC : GerenteDePropriedades, IEntidade
{
    private decimal _codusur;
    private decimal _codepto;
    private decimal _codsec;

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCUSURDEPSEC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal Codusur
    {
        get
        {
            PropriedadeAcessada("Codusur");
            return _codusur;
        }
        set
        {
            PropriedadeModificada("Codusur", value);
            _codusur = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCUSURDEPSEC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal Codepto
    {
        get
        {
            PropriedadeAcessada("Codepto");
            return _codepto;
        }
        set
        {
            PropriedadeModificada("Codepto", value);
            _codepto = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCUSURDEPSEC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal Codsec
    {
        get
        {
            PropriedadeAcessada("Codsec");
            return _codsec;
        }
        set
        {
            PropriedadeModificada("Codsec", value);
            _codsec = value;
        }
    }


    public void CarregarPorDataReader(IDataReader leitor)
    {
        _codusur = AlterarTipo<decimal>(leitor["Codusur"]);
        _codepto = AlterarTipo<decimal>(leitor["Codepto"]);
        _codsec = AlterarTipo<decimal>(leitor["Codsec"]);
    }

    public void InicializarAtributos()
    {
        
    }

    public IEntidade NovaInstancia()
    {
        return (IEntidade)GetType().GetConstructors()[0].Invoke(null);
    }

    public string ObterNomeTabela()
    {
        return "PCUSURDEPSEC";
    }
}