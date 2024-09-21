namespace ExportadorNFCe.XMLNFe
{

    public class Destinatario
    {
        public string CNPJ { get; set; }
        public string CPF { get; set; }
        public string xNome { get; set; }
        [XmlElement("enderDest")]
        public Endereco Endereco { get; set; }
        public string email { get; set; }
    }

    public class Total
    {
        [XmlElement("ICMSTot")]
        public ICMSTotal ICMSTotal { get; set; }
    }

    public class ICMSTotal
    {
        public string vBC { get; set; }
        public string vICMS { get; set; }
        public string vProd { get; set; }
        public string vOutro { get; set; }
        public string vNF { get; set; }
    }
}
