using System.Text;
using System.Xml;

//namespace nwErp.Utilidades;

public class Serializador
{
	public static string Serializar(object Objeto)
	{
		return Serializar(Objeto, Encoding.Default);
	}

	public static string Serializar(object Objeto, Encoding codificacao)
	{
		MemoryStream memoryStream = new MemoryStream();
		using (XmlTextWriter xmlTextWriter = new XmlTextWriter(memoryStream, codificacao))
		{
			new XmlSerializer(Objeto.GetType()).Serialize(xmlTextWriter, Objeto);
			xmlTextWriter.Close();
		}
		return codificacao.GetString(memoryStream.ToArray());
	}

    //public static T Deserializar<T>(string XML)
    //{
    //	T val = default(T);
    //	XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
    //	StringReader textReader = new StringReader(XML);
    //	return (T)xmlSerializer.Deserialize(textReader);
    //}

    public static T Deserializar<T>(string XML)
    {
        T val = default(T);
        XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
        using (StringReader textReader = new StringReader(XML))
        {
            return (T)xmlSerializer.Deserialize(textReader);
        }
    }


    public static T DeserializarDeArquivo<T>(string nomeDoArquivo)
	{
		using (TextReader textReader = new StreamReader(nomeDoArquivo))
		{
            return Deserializar<T>(textReader.ReadToEnd());
        }
    }

	public static void SerializarParaArquivo(object objeto, string nomeDoArquivo)
	{
		string value = Serializar(objeto);
		
		using (TextWriter textWriter = new StreamWriter(nomeDoArquivo)) 
		{
			textWriter.Write(value); 
		}
			
	}
}
