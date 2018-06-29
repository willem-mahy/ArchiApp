using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlPOI : MonoBehaviour {

    public Button m_buttonNext = null;

    public Text m_textPOI = null;

    public Button m_buttonPrevious = null;

    int m_activePOIIndex = -1;

    // Use this for initialization
    void Start () {
        m_activePOIIndex = 0;
    }

    private string[] GetPOINames()
    {
        //TODO: Get from loaded model
        string[] poiNames = { "Front", "Back", "Center" };
;
        return poiNames;
    }
	
	// Update is called once per frame
	void Update () {
        var poiNames = GetPOINames();

        if (m_textPOI)
        {
            m_textPOI.text = (m_activePOIIndex == -1 ? "" :  poiNames[m_activePOIIndex]);
        }

        m_buttonPrevious.interactable = (m_activePOIIndex > 0);

        m_buttonNext.interactable = (m_activePOIIndex < poiNames.Length - 1);
    }

    public void Next_OnCLick()
    {
        m_activePOIIndex = Math.Min(++m_activePOIIndex, GetPOINames().Length-1);
    }

    public void Previous_OnCLick()
    {
        m_activePOIIndex = Math.Max(--m_activePOIIndex, 0);
    }
}
