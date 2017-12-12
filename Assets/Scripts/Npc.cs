using System.Xml.Serialization;

public class Npc

{
    #region Public Members
    [XmlArrayItem("image")]
    public string image;
    [XmlArrayItem("description")]
    public string description;
    [XmlArrayItem("type")]
    public string type;
    public AskingContainer m_asking_container;
    #endregion

    #region Public void

    #endregion

    #region Tools Debug and Utility   
    #endregion

    #region Private and Protected Members
    //Voir si plusieurs état d'image
    
    

    #endregion
}
