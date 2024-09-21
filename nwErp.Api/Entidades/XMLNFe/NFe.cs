namespace ExportadorNFCe.XMLNFe
{

    public class NFe
    {
        [XmlElement(ElementName = "infNFe")]
        public InfNFe InformacoesNFe { get; set; }

       

        public class InfNFe
        {

            public InfNFe()
            {
                det = new List<det>();
            }

            [XmlElement("ide")]
            public Identificacao Identificacao { get; set; }

            [XmlElement("emit")]
            public Emitente Emitente { get; set; }

            [XmlElement("dest")]
            public Destinatario Destinatario { get; set; }

            [XmlElement("det")]
            public List<det> det { get; set; }

            [XmlElement("total")]
            public Total Total { get; set; } 
        }
    }
}
