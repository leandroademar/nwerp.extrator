namespace nwErp.Api.Persistencia
{
    public class Parametro
    {
        public string Identificador { get; set; }

        public object Valor { get; set; }

        public Parametro(string pIdentificador, object pValor)
        {
            Identificador = pIdentificador;
            Valor = pValor;
        }
    }
}
