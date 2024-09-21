using System.Security.Cryptography;
using System.Text;

namespace nwErp.Api.Utilidades;

internal class StringCipher : IDisposable
  {
    private byte[] _chaveSecreta;
    private byte[] _vectorInicial;

    private AesManaged AesManaged
    {
      get
      {
        AesManaged aesManaged = new AesManaged();
        ((SymmetricAlgorithm) aesManaged).Key = this._chaveSecreta;
        ((SymmetricAlgorithm) aesManaged).IV = this._vectorInicial;
        ((SymmetricAlgorithm) aesManaged).Padding = (PaddingMode) 2;
        ((SymmetricAlgorithm) aesManaged).Mode = (CipherMode) 1;
        return aesManaged;
      }
    }

    private void DefinirChaveSecreta(string chaveSecreta)
    {
      this._chaveSecreta = !string.IsNullOrEmpty(chaveSecreta?.Trim()) ? Encoding.UTF8.GetBytes(chaveSecreta) : throw new ArgumentNullException(nameof (chaveSecreta), "O campo chave secreta deve possuir um valor");
      if (this._chaveSecreta.Length > 32)
        throw new ArgumentOutOfRangeException(nameof (chaveSecreta), (object) this._chaveSecreta.Length, "32 é o tamanho máximo do campo chave secreta.");
      if (this._chaveSecreta.Length == 0)
        throw new ArgumentNullException(nameof (chaveSecreta), "O campo chave secreta deve possuir um tamanho maior que zero");
    }

    private void DefinirChaveSecreta(byte[] chaveSecreta)
    {
      this._chaveSecreta = chaveSecreta ?? throw new ArgumentNullException(nameof (chaveSecreta), "O campo chave secreta deve possuir um valor");
      if (this._chaveSecreta.Length > 32)
        throw new ArgumentOutOfRangeException(nameof (chaveSecreta), (object) this._chaveSecreta.Length, "32 é o tamanho máximo do campo chave secreta.");
      if (this._chaveSecreta.Length == 0)
        throw new ArgumentNullException(nameof (chaveSecreta), "O campo chave secreta deve possuir um tamanho maior que zero");
    }

    private void DefinirVectorInicial(string vectorInicial)
    {
      this._vectorInicial = !string.IsNullOrEmpty(vectorInicial?.Trim()) ? Encoding.UTF8.GetBytes(vectorInicial) : throw new ArgumentNullException(nameof (vectorInicial), "O campo vector inicial deve possuir um valor");
      if (this._vectorInicial.Length > 16)
        throw new ArgumentOutOfRangeException(nameof (vectorInicial), (object) this._vectorInicial.Length, "16 é o tamanho máximo do campo vector inicial.");
      if (this._vectorInicial.Length == 0)
        throw new ArgumentNullException(nameof (vectorInicial), "O campo vector inicial deve possuir um tamanho maior que zero");
    }

    private void DefinirVectorInicial(byte[] vectorInicial)
    {
      this._vectorInicial = vectorInicial ?? throw new ArgumentNullException(nameof (vectorInicial), "O campo vector inicial deve possuir um valor");
      if (this._vectorInicial.Length > 16)
        throw new ArgumentOutOfRangeException(nameof (vectorInicial), (object) this._vectorInicial.Length, "16 é o tamanho máximo do campo vector inicial.");
      if (this._vectorInicial.Length == 0)
        throw new ArgumentNullException(nameof (vectorInicial), "O campo vector inicial deve possuir um tamanho maior que zero");
    }

    internal StringCipher(string chaveSecreta, string vectorInicial)
    {
      this.DefinirChaveSecreta(chaveSecreta);
      this.DefinirVectorInicial(vectorInicial);
    }

    internal StringCipher(byte[] chaveSecreta, byte[] vectorInicial)
    {
      this.DefinirChaveSecreta(chaveSecreta);
      this.DefinirVectorInicial(vectorInicial);
    }

    public string Descriptografar(string @string)
    {
      try
      {
        AesManaged aesManaged = this.AesManaged;
        using (MemoryStream memoryStream = new MemoryStream())
        {
          using (CryptoStream cryptoStream = new CryptoStream((Stream) memoryStream, ((SymmetricAlgorithm) aesManaged).CreateDecryptor(), (CryptoStreamMode) 1))
          {
            byte[] numArray = Convert.FromBase64String(@string);
            ((Stream) cryptoStream).Write(numArray, 0, numArray.Length);
            ((Stream) cryptoStream).Close();
            return Encoding.UTF8.GetString(memoryStream.ToArray());
          }
        }
      }
      catch (Exception ex)
      {
        throw new Exception(string.Format("Erro ao criptografar a string {0}", (object) @string), ex);
      }
    }

    public string Criptografar(string @string)
    {
      try
      {
        AesManaged aesManaged = this.AesManaged;
        using (MemoryStream memoryStream = new MemoryStream())
        {
          using (CryptoStream cryptoStream = new CryptoStream((Stream) memoryStream, ((SymmetricAlgorithm) aesManaged).CreateEncryptor(), (CryptoStreamMode) 1))
          {
            byte[] bytes = Encoding.UTF8.GetBytes(@string);
            ((Stream) cryptoStream).Write(bytes, 0, bytes.Length);
            ((Stream) cryptoStream).Close();
            return Convert.ToBase64String(memoryStream.ToArray());
          }
        }
      }
      catch (Exception ex)
      {
        throw new Exception(string.Format("Erro ao descriptografar a string {0}", (object) @string), ex);
      }
    }

    public void Dispose()
    {
    }
  }