namespace nwErp.Api.Persistencia
{

    [AttributeUsage(AttributeTargets.Class)]
    public class ObjetoMapeavel : Attribute
    {
        public string NomeDaTabela { get; set; }

        public ObjetoMapeavel(string nomeDaTabela)
        {
            NomeDaTabela = nomeDaTabela;
        }
    }
}
