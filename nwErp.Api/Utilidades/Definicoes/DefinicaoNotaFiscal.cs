namespace nwErp.Api.Definicoes;

public class DefinicaoNotaFiscal
{
	private DefinicaoPedidoECF _definicaoECF = new DefinicaoPedidoECF();

	public DefinicaoPedidoECF DefinicaoPedidoECF
	{
		get
		{
			return _definicaoECF;
		}
		set
		{
			_definicaoECF = value;
		}
	}

	public PCCARREG Carregamento { get; set; }

	public PCNFSAID Nota { get; set; }

	public PCPEDC Pedido { get; set; }

	public PCVENDACONSUM ConsumidorFinal { get; set; }

	public List<PCPEDI> Itens { get; set; }

	public List<PCPREST> Parcelas { get; set; }

	public List<PCPEDICESTA> ItensCesta { get; set; }

	public List<PCNFBASE> Aliquotas { get; set; }

	public List<PCMOV> Movimentacao { get; set; }
}