using System.Net;
using System.Net.Sockets;

//namespace nwErp.Utilidades;

public static class validarPortaRabbit
{
	public static bool validarPortaUso()
	{
		IPAddress localaddr = Dns.GetHostEntry("127.0.0.1").AddressList[0];
		try
		{
			new TcpListener(localaddr, 5672).Start();
		}
		catch (SocketException)
		{
			return false;
		}
		return true;
	}
}
