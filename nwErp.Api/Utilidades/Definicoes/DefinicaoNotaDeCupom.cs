namespace nwErp.Api.Definicoes
{
    public class DefinicaoNotaDeCupom
    {
        public PCVENDACONSUM ConsumidorFinal { get; set; }

        public PCPEDC Pedido { get; set; }

        public PCNFSAID Nota { get; set; }

        public List<PCNFBASE> Aliquotas { get; set; }

        public List<PCPEDI> Itens { get; set; }

        public List<PCMOV> Movimentacoes { get; set; }
    }

}
