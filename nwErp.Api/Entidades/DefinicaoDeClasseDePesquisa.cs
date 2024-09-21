////namespace nwErp.Entidades;

[AttributeUsage(AttributeTargets.Class)]
public class DefinicaoDeClasseDePesquisa : Attribute
{
	public string Descricao { get; set; }

	public DefinicaoDeClasseDePesquisa()
	{
	}

	public DefinicaoDeClasseDePesquisa(string descricao)
	{
		Descricao = descricao;
	}
}
