namespace nwErp.Api.Persistencia.Oracle
{
    [AttributeUsage(AttributeTargets.Property)]
    public class PropriedadeMapeavel : Attribute
    {
        public string Nome { get; set; }

        public bool Chave { get; set; }

        public PropriedadeMapeavel(string nome)
        {
            Nome = nome;
        }

        public PropriedadeMapeavel()
        {
        }
    }

}
