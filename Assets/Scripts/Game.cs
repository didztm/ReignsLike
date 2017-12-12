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
        m_npc_zone.GetComponent<Image>().sprite = AssetDatabase.LoadAssetAtPath<Sprite>("Assets/Sprites/Npc/"+ m_npc_list[0].image);
        m_ask_zone.GetComponent<Text>().text = m_asking_list[0].ask;
    }
    public void ClickYes() {
        int rnd_npc= Random.Range(0, m_npc_list.Count);
        int rnd_ask= Random.Range(0, m_asking_list.Count);
        Debug.Log(rnd_npc+" = "+ "Assets/Sprites/Npc/" + m_npc_list[rnd_npc].image +" " + rnd_ask);
        m_npc_zone.GetComponent<Image>().sprite= AssetDatabase.LoadAssetAtPath<Sprite>("Assets/Sprites/Npc/" + m_npc_list[rnd_npc].image );
        m_ask_zone.GetComponent<Text>().text = m_asking_list[rnd_ask].ask;
    }
   public  void ClickNo()
    {
        int rnd_npc = Random.Range(0, m_npc_list.Count);
        int rnd_ask = Random.Range(0, m_asking_list.Count);
        Debug.Log(rnd_npc + " = " + "Assets/Sprites/Npc/" + m_npc_list[rnd_npc].image + " " + rnd_ask);
        m_npc_zone.GetComponent<Image>().sprite = AssetDatabase.LoadAssetAtPath<Sprite>("Assets/Sprites/Npc/" + m_npc_list[rnd_npc].image);
        m_ask_zone.GetComponent<Text>().text = m_asking_list[rnd_ask].ask;

    }
    #endregion

    #region Private and Protected Members
    [SerializeField]
    private RectTransform m_npc_zone;
    [SerializeField]
    private RectTransform m_ask_zone;
    [SerializeField]
    private Button m_yes;
    [SerializeField]
    private Button m_no;
    #endregion

}
