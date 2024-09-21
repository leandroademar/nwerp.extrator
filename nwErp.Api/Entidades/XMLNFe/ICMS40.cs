namespace ExportadorNFCe.XMLNFe
{
    public class ICMS40 : ICMSBasico
    {
        private decimal? _vIcmsDeson;

        /// <summary>
        ///     N11 - Origem da Mercadoria
        /// </summary>
        [XmlElement(Order = 1)]
        public string orig { get; set; }

        /// <summary>
        ///     N12- Situação Tributária
        /// </summary>
        [XmlElement(Order = 2)]
        public string CST { get; set; }

        /// <summary>
        ///     N27a - Valor do ICMS desonerado
        /// </summary>
        [XmlElement(Order = 3)]
        public decimal? vICMSDeson
        {
            get { return _vIcmsDeson.Arredondar(2); }
            set { _vIcmsDeson = value.Arredondar(2); }
        }

        /// <summary>
        ///     N28 - Motivo da desoneração do ICMS
        /// </summary>
        [XmlElement(Order = 4)]
        public MotivoDesoneracaoIcms? motDesICMS { get; set; }

        public bool ShouldSerializevICMSDeson()
        {
            return vICMSDeson.HasValue;
        }

        public bool ShouldSerializemotDesICMS()
        {
            return motDesICMS.HasValue;
        }
    }
}
