namespace nwErp.Api.Persistencia.Oracle
{
    internal class DefinicaoDeSQL
    {
        private List<DefinicaoDeParametro> _parametros = new List<DefinicaoDeParametro>();

        public string SQL { get; set; }

        public string Where { get; set; }

        public List<DefinicaoDeParametro> Parametros
        {
            get
            {
                return _parametros;
            }
            set
            {
                _parametros = value;
            }
        }
    }
}
