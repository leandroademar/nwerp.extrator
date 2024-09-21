public class DTI_TERRAZZO_CONTROLENF : GerenteDePropriedades,IEntidade
{
    public int ID { get; set; }
    public int? ID_XML { get; set; }
    public string NUMNOTA { get; set; }
    public string SERIE { get; set; }
    public int? ID_CONTROLECAIXA { get; set; }
    public int? ID_CONTARECEBER { get; set; }
    public int? QTD_CONTARECEBER { get; set; }
    public int MODNFE { get; set; }
    public DateTime? DTSAIDA { get; set; }
    public string? PROTOCOLONFE { get; set; }
    public string? SITUACAONFE { get; set; }
    public DateTime? DTCANCEL { get; set; }
    public int? MATRICULA { get; set; }

    public string? MENSAGEMRETORNO { get; set; }
    public string? XMLNF { get; set; }
    public bool? ATIVA { get; set; }
    public bool? PENDENTE { get; set; }
    public bool? INUTILIZADA { get; set; }
    public bool? EXPORTADA { get; set; }

    public void CarregarPorDataReader(IDataReader leitor)
    {
        throw new NotImplementedException();
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
        return "DTI_TERRAZZO_CONTROLENF";
    }
}