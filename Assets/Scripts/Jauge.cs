using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Jauge : EventJauge
{
    #region Public Members

    #endregion

    #region Public void

    #endregion

    #region System

    void Start ()
    {
        
    }

    void Update ()
    {
        	
    }

    #endregion

    #region Tools Debug and Utility

    #endregion
    public void RefreshJauge() {
        switch (m_kind) {

            case 1:
                m_jauge[0].image.fillAmount = m_jauge[0].image.fillAmount+1;
                break;






        }

    }
    #region Private and Protected Members
    private List<Button> m_jauge;
    #endregion
}
