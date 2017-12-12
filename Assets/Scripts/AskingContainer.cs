using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

[XmlRoot("AskingCollection")]
public class AskingContainer 
{
    #region Public Members
    [XmlElement("Asking")]
    public List<Asking> m_asking_list = new List<Asking>();
    #endregion

    #region Public void

    #endregion

    #region Tools Debug and Utility

    public static List<Asking> XmlToList(string path)
    {

        var serializer = new XmlSerializer(typeof(AskingContainer));
        var stream = new FileStream(path, FileMode.Open);
        var container = serializer.Deserialize(stream) as AskingContainer;
        stream.Close();
        return container.m_asking_list;

    }
    public void JsonToList()
    {
        m_asking_list = new List<Asking>();
    }
    #endregion

    #region Private and Protected Members



    
    #endregion
}
