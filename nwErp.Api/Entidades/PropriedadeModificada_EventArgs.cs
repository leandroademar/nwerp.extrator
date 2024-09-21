////namespace nwErp.Entidades;

public class PropriedadeModificada_EventArgs : EventArgs
{
	public string NomeDaPropriedade { get; set; }

	public PropriedadeModificada_EventArgs(string nomeDaPropriedade)
	{
		NomeDaPropriedade = nomeDaPropriedade;
	}
}
