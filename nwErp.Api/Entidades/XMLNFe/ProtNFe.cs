namespace ExportadorNFCe.XMLNFe
{
    public class ProtNFe
    {
        [XmlElement(ElementName = "infProt")]
        public infProt ProtocoloNFe { get; set; }
    }

    public class infProt
    {
        public string tpAmb { get; set; }
        public string chNFe { get; set; }
        public string nProt { get; set; }
        public string cStat { get; set; }
        public string xMotivo { get; set; }
        public string dhRecbto { get; set; }
        public string verAplic { get; set; }
    }
}
