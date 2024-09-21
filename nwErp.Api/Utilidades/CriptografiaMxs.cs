using System.Text;

namespace nwErp.Api.Utilidades;

public static class Criptografia
{
    private static readonly byte[] Keyspec = Encoding.UTF8.GetBytes("10.766.206000261");
    private static readonly byte[] Ivspec = Encoding.UTF8.GetBytes("#m@x!m4515T3m@ss");

    public static string Criptografar(this string @string)
    {
        using (StringCipher stringCipher = new StringCipher(Criptografia.Keyspec, Criptografia.Ivspec))
            return stringCipher.Criptografar(@string);
    }

    public static string Descriptografar(this string @string)
    {
        using (StringCipher stringCipher = new StringCipher(Criptografia.Keyspec, Criptografia.Ivspec))
            return stringCipher.Descriptografar(@string);
    }
}
