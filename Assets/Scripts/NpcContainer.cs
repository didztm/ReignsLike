using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
[XmlRoot("NpcCollection")]
public class NpcContainer 
{
    #region Public Members
    [XmlElement("Npc")]
    public List<Npc> m_npc_list = new List<Npc>();
    
    #endregion

    #region Public void

    #endregion
    #region Tools Debug and Utility
    public static List<Npc> XmlToList(string _path)
    {
        var serializer = new XmlSerializer(typeof(NpcContainer));
        var stream = new FileStream(_path, FileMode.Open);
        var container = serializer.Deserialize(stream) as NpcContainer;
        stream.Close();
        return container.m_npc_list;

    }
    #endregion

    #region Private and Protected Members

    #endregion

}
