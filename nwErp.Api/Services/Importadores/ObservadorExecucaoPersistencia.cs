using System.Text;

namespace nwErp.Api.Importadores;

public class ObservadorExecucaoPersistencia : IOberservadorDeExecucao
{
	private StringBuilder _log;

	public ObservadorExecucaoPersistencia(StringBuilder log)
	{
		_log = log;
	}

	public void RegistrarComando(IDbCommand comando, IDataAdapter adaptador)
	{
		_log.AppendLine(comando.CommandText);
	}

	public void Registrar(StringBuilder registro)
	{
		_log.AppendLine(registro.ToString());
	}

	public void Registrar(string registro)
	{
		_log.AppendLine(registro);
	}
}

public interface IOberservadorDeExecucao
{
	void RegistrarComando(IDbCommand comando, IDataAdapter adaptador);

	void Registrar(StringBuilder registro);

	void Registrar(string registro);
}
