////namespace nwErp.Entidades;

[AttributeUsage(AttributeTargets.Class)]
public class NomeDaPackage : Attribute
{
	public string Nome { get; set; }

	public NomeDaPackage(string nome)
	{
		Nome = nome;
	}
}
