namespace nwErp.Api.Definicoes
{
    public class DefinicaoPedidoECF
    {

        public List<PCPEDIECF> Itens { get; set; }

        public List<PCPRESTECF> Parcelas { get; set; }
        
        public PCPEDCECF Pedido { get; set; }

        public List<PCVENDACONSUMECF> ConsumidorFinal { get; set; }

        public List<PCPEDIECFCESTA> ItensCesta { get; set; }

        public List<PCORIGEMPRECOECF> OrigemDePreco { get; set; }

        public List<PCAUTORIECF> Autorizacao { get; set; }

        public List<PCENDERECODELIVERY> EnderecoEntrega { get; set; }

        public List<PCDOCELETRONICOECF> DocumentoEletronico { get; set; }

        public PCHISTORICOSMOTOROFERTA HistoricoMotorOferta { get; set; }

        public List<PCLOGDADOSPESSOAS> LogDadosPessoas { get; set; }

        public string XMLPacote { get; set; }
    }
}
