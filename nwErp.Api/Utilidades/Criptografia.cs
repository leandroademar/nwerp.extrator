using System.Security.Cryptography;
using System.Text;

//namespace nwErp.Utilidades;

public static class Criptografia
{
	private static byte[] bIV = new byte[16]
	{
		80, 8, 241, 221, 222, 60, 242, 24, 68, 116,
		25, 44, 83, 73, 171, 188
	};

	private const string cryptoKey = "Q3JpcHRvZ3JhZmlhcyBjb20gUmluamRhZWwgLyBBRVM=";

	public static string Encrypt(string text)
	{
		try
		{
			if (!string.IsNullOrEmpty(text))
			{
				byte[] rgbKey = Convert.FromBase64String("Q3JpcHRvZ3JhZmlhcyBjb20gUmluamRhZWwgLyBBRVM=");
				byte[] bytes = new UTF8Encoding().GetBytes(text);
				Rijndael rijndael = new RijndaelManaged();
				rijndael.KeySize = 256;
				MemoryStream memoryStream = new MemoryStream();
				CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndael.CreateEncryptor(rgbKey, bIV), CryptoStreamMode.Write);
				cryptoStream.Write(bytes, 0, bytes.Length);
				cryptoStream.FlushFinalBlock();
				return Convert.ToBase64String(memoryStream.ToArray());
			}
			return null;
		}
		catch (Exception innerException)
		{
			throw new ApplicationException("Erro ao criptografar", innerException);
		}
	}

	public static string Decrypt(string text)
	{
		try
		{
			if (!string.IsNullOrEmpty(text))
			{
				byte[] rgbKey = Convert.FromBase64String("Q3JpcHRvZ3JhZmlhcyBjb20gUmluamRhZWwgLyBBRVM=");
				byte[] array = Convert.FromBase64String(text);
				Rijndael rijndael = new RijndaelManaged();
				rijndael.KeySize = 256;
				MemoryStream memoryStream = new MemoryStream();
				CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndael.CreateDecryptor(rgbKey, bIV), CryptoStreamMode.Write);
				cryptoStream.Write(array, 0, array.Length);
				cryptoStream.FlushFinalBlock();
				return new UTF8Encoding().GetString(memoryStream.ToArray());
			}
			return null;
		}
		catch (Exception)
		{
			return "";
		}
	}
}
