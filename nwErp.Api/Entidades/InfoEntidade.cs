////namespace nwErp.Entidades;

[AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
public class InfoEntidade : Attribute
{
	public bool NaoPersistir { get; set; }
}
