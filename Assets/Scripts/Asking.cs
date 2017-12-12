using System.Xml.Serialization;


public class Asking 
{
    #region Public Members
    [XmlArrayItem("ask")]
    public string ask;
    [XmlArrayItem("type")]
    public string type;
    [XmlArrayItem("lang")]
    public string lang;
    [XmlArrayItem("pos")]
    public int pos;
    [XmlArrayItem("neg")]
    public int neg;
    [XmlArrayItem("result1")]
    public string result;
    #endregion

    #region Public void

    #endregion

    #region System

    #endregion

    #region Tools Debug and Utility

    #endregion

    #region Private and Protected Members

    #endregion


}
