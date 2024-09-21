using System.Security.Cryptography;
using System.Text;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Security;

//namespace nwErp.Utilidades;

public class CriptoEAS
{
	public static string Encrypt_AESECB(string chave, string senha)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(chave);
		byte[] array = BuildKey(senha);
		IBufferedCipher cipher = CipherUtilities.GetCipher("AES/ECB/ISO7816-4Padding");
		cipher.Init(true, (ICipherParameters)(object)ParameterUtilities.CreateKeyParameter("AES", array));
		return Convert.ToBase64String(cipher.DoFinal(bytes));
	}

	public static string Decrypt_AESECB(string chaveCripto, string senha)
	{
		byte[] array = BuildKey(senha);
		IBufferedCipher cipher = CipherUtilities.GetCipher("AES/ECB/ISO7816-4Padding");
		cipher.Init(false, (ICipherParameters)(object)ParameterUtilities.CreateKeyParameter("AES", array));
		byte[] array2 = Convert.FromBase64String(chaveCripto);
		byte[] array3 = new byte[cipher.GetOutputSize(array2.Length)];
		int num = cipher.ProcessBytes(array2, array3, 0);
		cipher.DoFinal(array3, num);
		return Encoding.UTF8.GetString(array3);
	}

	private static byte[] BuildKey(string chave)
	{
		SHA1Managed sHA1Managed = new SHA1Managed();
		byte[] bytes = Encoding.UTF8.GetBytes(chave);
		byte[] array = sHA1Managed.ComputeHash(bytes);
		Array.Resize(ref array, 16);
		return array;
	}
}
