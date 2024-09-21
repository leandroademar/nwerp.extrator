using System.Collections;

namespace nwErp.Api.Definicoes
{
    public class DefinicaoComplemento
    {
        public List<PCPEDCCANCECF> PCPEDCCANCECF { get; set; }

        public List<PCPEDICANCECF> PCPEDICANCECF { get; set; }

        public List<PCAUTORIECF> PCAUTORIECF { get; set; }

        public List<PCCUPOMFISCALX> PCCUPOMFISCALX { get; set; }

        public List<PCCUPOMFISCALZ> PCCUPOMFISCALZ { get; set; }

        public List<PCORCAVENDAI> PCORCAVENDAI { get; set; }

        public List<PCORCAVENDAC> PCORCAVENDAC { get; set; }

        public List<PCVENDACONSUM> PCVENDACONSUM { get; set; }

        public List<PCVALECXECF> PCVALECXECF { get; set; }

        public List<PCDOCEMITIDOSECF> PCDOCEMITIDOSECF { get; set; }

        public List<PCFECHACXCEGO> PCFECHACXCEGO { get; set; }

        public List<PCLOGECF> PCLOGECF { get; set; }

        public List<PCLOGABERTURACX> PCLOGABERTURACX { get; set; }

        public List<PCLOGCAIXA> PCLOGCAIXA { get; set; }

        public List<PCANALISEPDV> PCANALISEPDV { get; set; }

        public List<PCCOMPLEMENTONFCE> PCCOMPLEMENTONFCE { get; set; }

        public List<CONTINGENCIANFCE> CONTINGENCIANFCE { get; set; }

        public List<PCFECHAMENTOMOVCX> PCFECHAMENTOMOVCX { get; set; }

        public List<PCPESQATENDIMENTOBAIRROPDV> PCPESQATENDIMENTOBAIRROPDV { get; set; }

        public List<PCINUTILIZACAONFCE> PCINUTILIZACAONFCE { get; set; }

        public List<PCLOGMESA> PCLOGMESA { get; set; }

        public List<PCORCAVENDAICANC> PCORCAVENDAICANC { get; set; }

        public List<PCORCAVENDAIDEVOL> PCORCAVENDAIDEVOL { get; set; }

        public List<PCORCAVENDAITRANSF> PCORCAVENDAITRANSF { get; set; }

        public List<PCORCAVENDAPREST> PCORCAVENDAPREST { get; set; }

        public List<PCDOCELETRONICOECF> PCDOCELETRONICOECF { get; set; }

        public List<PCARQUIVOSFISCO> PCARQUIVOSFISCO { get; set; }

        public List<PCREJEICAOSEFAZ> PCREJEICAOSEFAZ { get; set; }

        public List<PCMOVIMENTOPDV> PCMOVIMENTOPDV { get; set; }

        public List<PCESTPAF> PCESTPAF { get; set; }

        public List<PCSAQUETEF> PCSAQUETEF { get; set; }

        public List<PCPRESTPAF> PCPRESTPAF { get; set; }

        public List<PCTABELASMD5PAF> PCTABELASMD5PAF { get; set; }

        public List<PCVENDACONSUMECF> PCVENDACONSUMECF { get; set; }

        public List<PCLOGDADOSPESSOAS> PCLOGDADOSPESSOAS { get; set; }

        [XmlIgnore]
        public bool PossuiRegistros => ObterQuantidadeDeRegistro(PCPEDCCANCECF, PCPEDICANCECF, PCAUTORIECF, PCCUPOMFISCALX, PCCUPOMFISCALZ, PCORCAVENDAI, PCORCAVENDAC, PCVENDACONSUM, PCVALECXECF, PCDOCEMITIDOSECF, PCFECHACXCEGO, PCLOGECF, PCLOGABERTURACX, PCLOGCAIXA, PCANALISEPDV, PCCOMPLEMENTONFCE, CONTINGENCIANFCE, PCFECHAMENTOMOVCX, PCPESQATENDIMENTOBAIRROPDV, PCINUTILIZACAONFCE, PCLOGMESA, PCORCAVENDAICANC, PCORCAVENDAIDEVOL, PCORCAVENDAITRANSF, PCORCAVENDAPREST, PCDOCELETRONICOECF, PCARQUIVOSFISCO, PCESTPAF, PCSAQUETEF, PCREJEICAOSEFAZ, PCMOVIMENTOPDV, PCPRESTPAF, PCTABELASMD5PAF, PCVENDACONSUMECF) > 0;

        private int ObterQuantidadeDeRegistro(params IList[] listas)
        {
            int num = 0;
            for (int i = 0; i < listas.Length; i++)
            {
                num += listas[i]?.Count ?? 0;
            }
            return num;
        }
    }

}
