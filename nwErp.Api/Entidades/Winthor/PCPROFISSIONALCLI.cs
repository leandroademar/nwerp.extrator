// namespace nwErp.Api.Modelos;

public class PCPROFISSIONALCLI : GerenteDePropriedades, IEntidade
{
    private decimal _codusur;
    private decimal _codcli;

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCPROFISSIONALCLI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCPROFISSIONALCLI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal Codcli
    {
        get
        {
            PropriedadeAcessada("Codcli");
            return _codcli;
        }
        set
        {
            PropriedadeModificada("Codcli", value);
            _codcli = value;
        }
    }


    public void CarregarPorDataReader(IDataReader leitor)
    {
        _codusur = AlterarTipo<decimal>(leitor["Codusur"]);
        _codcli = AlterarTipo<decimal>(leitor["Codcli"]);
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
        return "PCPROFISSIONALCLI";
    }
}