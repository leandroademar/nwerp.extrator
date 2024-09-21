namespace ExportadorNFCe.XMLNFe
{
    public class NFeSerialization
    {
        public  T GetObjectFromFile<T>(string arquivo) where T : class
        {
            var serialize = new XmlSerializer(typeof(T));

            try
            {
                var xmlArquivo = System.Xml.XmlReader.Create(arquivo);
                using (FileStream stream = new FileStream(arquivo, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                {                    
                    return (T)serialize.Deserialize(stream);
                }


            }
            catch (Exception)
            {
                return null;
            }
        }
    }

}
