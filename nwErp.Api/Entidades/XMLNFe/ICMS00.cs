namespace ExportadorNFCe.XMLNFe
{
    public class ICMS00 : ICMSBasico 
    {
        private decimal _vBc;
        private decimal _pIcms;
        private decimal _vIcms;
        private decimal? _pFcp;
        private decimal? _vFcp;


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
        ///     N13 - Modalidade de determinação da BC do ICMS
        /// </summary>
        [XmlElement(Order = 3)]
        public DeterminacaoBaseIcms modBC { get; set; }

        /// <summary>
        ///     N15 - Valor da BC do ICMS
        /// </summary>
        [XmlElement(Order = 4)]
        public decimal vBC
        {
            get { return _vBc; }
            set { _vBc = value; }
        }

        /// <summary>
        ///     N16 - Alíquota do imposto
        /// </summary>
        [XmlElement(Order = 5)]
        public decimal pICMS
        {
            get { return _pIcms; }
            set { _pIcms = value; }
        }

        /// <summary>
        ///     N17 - Valor do ICMS
        /// </summary>
        [XmlElement(Order = 6)]
        public decimal vICMS
        {
            get { return _vIcms; }
            set { _vIcms = value; }
        }

        /// <summary>
        /// N17b - Percentual do Fundo de Combate à Pobreza (FCP)
        /// Versão 4.00
        /// </summary>
        [XmlElement(Order = 7)]
        public decimal? pFCP
        {
            get { return _pFcp; }
            set { _pFcp = value; }
        }

        public bool pFCPSpecified
        {
            get { return pFCP.HasValue; }
        }

        /// <summary>
        /// N17c - Valor do Fundo de Combate à Pobreza (FCP)
        /// Versão 4.00
        /// </summary>
        [XmlElement(Order = 8)]
        public decimal? vFCP
        {
            get { return _vFcp; }
            set { _vFcp = value; }
        }

        public bool vFCPSpecified
        {
            get { return vFCP.HasValue; }
        }
    }
}
