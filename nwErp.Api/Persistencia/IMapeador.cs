namespace nwErp.Api.Persistencia
{
    public interface IMapeador
    {
        List<Parametro> Parametros { get; set; }

        string ObterSql();
    }

}
