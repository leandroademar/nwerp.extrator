namespace nwErp.Api.Entidades;

public abstract class BaseEntity<T>
{
    public int Id { get; set; }

    protected virtual bool EhValido() => true;
}