////namespace nwErp.Entidades;

[AttributeUsage(AttributeTargets.Class)]
public class NomeDaFuncao : Attribute
{
	public string nomeFuncao { get; set; }

	public NomeDaFuncao(string nomeDaFuncao)
	{
		nomeFuncao = nomeDaFuncao;
	}
}
