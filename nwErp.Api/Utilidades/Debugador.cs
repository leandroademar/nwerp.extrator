using System.Diagnostics;

//namespace nwErp.Utilidades;

public class Debugador
{
	private static Debugador _debugador = new Debugador();

	public static Debugador UltimoDebugadorCriado => _debugador;

	private Debugador()
	{
	}

	[Conditional("DEBUG")]
	public static void IniciarDebug(string descricao)
	{
	}

	[Conditional("DEBUG")]
	public void RegistrarComTempoParcial(string descricao)
	{
	}

	[Conditional("DEBUG")]
	public static void Registrar(string descricao)
	{
	}

	[Conditional("DEBUG")]
	public void FinalizarDebug()
	{
	}
}
