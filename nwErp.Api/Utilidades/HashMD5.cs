using System.Security.Cryptography;
using System.Text;

//namespace nwErp.Utilidades;

public static class HashMD5
{
	public static string ObterHashDoArquivo(string arquivo)
	{
		MD5 mD = MD5.Create();
		byte[] array = mD.ComputeHash(File.ReadAllBytes(arquivo));
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < array.Length; i++)
		{
			stringBuilder.Append(array[i].ToString("X2"));
		}
		return stringBuilder.ToString();
	}

	public static string ObterHashDoTexto(string texto)
	{
		MD5 mD = MD5.Create();
		byte[] array = mD.ComputeHash(Encoding.UTF8.GetBytes(texto));
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < array.Length; i++)
		{
			stringBuilder.Append(array[i].ToString("X2"));
		}
		return stringBuilder.ToString();
	}
}
