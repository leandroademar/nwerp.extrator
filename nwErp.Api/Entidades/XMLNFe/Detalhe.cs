namespace ExportadorNFCe.XMLNFe
{
    public class det
    {
        [XmlAttribute("nItem")]
        public int nItem { get; set; }

        [XmlElement("prod")]
        public Produto Produto { get; set; }
        
       
        public imposto imposto { get; set; }

    }
}
