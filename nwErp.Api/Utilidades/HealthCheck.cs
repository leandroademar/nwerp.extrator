namespace nwErp.Api.Utilidades;

public abstract class HealthCheck
{
    private static int _qtdeFalhas;

    public static int Get() => HealthCheck._qtdeFalhas;

    public static void Set(int qtdeFalhas) => HealthCheck._qtdeFalhas = qtdeFalhas;

    public static void Incrementar() => ++HealthCheck._qtdeFalhas;

}
