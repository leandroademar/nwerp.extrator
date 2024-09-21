////// namespace nwErp.Entidades.Caixa;

// namespace nwErp.Api.Modelos;

public static class PropagadorDeEntidade
{
    public static Type[] ObterEntidades()
    {
        return Propagador.ObterEntidades(Assembly.GetExecutingAssembly());
    }
}