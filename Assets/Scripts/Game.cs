using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class Game : MonoBehaviour
{
    #region Public Members
    public const string pathXmlAsking = "Assets/XML/asking.xml";
    public const string pathXmlNpc = "Assets/XML/npc.xml";
    public List<Asking> m_asking_list { get; private set; }
    public List<Npc> m_npc_list { get; private set; }
    #endregion

    #region Public void

    #endregion

    #region System

    void Start ()
    {
        StartGame();
    }

    void Update ()
    {
        	
    }

    #endregion

    #region Tools Debug and Utility
    void StartGame (){
        m_asking_list= AskingContainer.XmlToList(pathXmlAsking);
        m_npc_list = NpcContainer.XmlToList(pathXmlNpc);
        m_npc_zone.GetComponent<Image>().sprite = AssetDatabase.LoadAssetAtPath<Sprite>("Assets/Sprites/Npc/"+ m_npc_list[0].image+".png");
        m_ask_zone.GetComponent<Text>().text = m_asking_list[0].ask;
    }
    #endregion

    #region Private and Protected Members
    [SerializeField]
    private RectTransform m_npc_zone;
    [SerializeField]
    private RectTransform m_ask_zone;
    #endregion
}
