namespace ExportadorNFCe.XMLNFe
{
    public class imposto
    {
        private decimal? _vTotTrib;

        public decimal? vTotTrib
        {
            get { return _vTotTrib.Arredondar(2); }
            set { _vTotTrib = value.Arredondar(2); }
        }

        //[XmlElement("ICMS")]
        public ICMS ICMS { get; set; }

        public bool ShouldSerializevTotTrib()
        {
            return vTotTrib.HasValue;
        }
    }

}
