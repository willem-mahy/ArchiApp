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

    public string m_POIpath = null;


    // Use this for initialization
    void Start () {
        m_activePOIIndex = 0;

        var poisPath = "/World/Construction/Phases/Final/POI/AR";
        Init(poisPath);
    }

    void Init(string poisPath)
    {
        m_POIpath = poisPath;            
    }

    private List<GameObject> GetPOIs(string poisPath)
    {
        //TODO: Get from loaded model
        List<GameObject> pois = new List<GameObject>();

        var goPOIs = GameObject.Find(poisPath);

        if (goPOIs != null)
        {
            foreach (Transform poi in goPOIs.transform)
            {
                pois.Add(poi.gameObject);
            }
        }

        return pois;
    }
	
	// Update is called once per frame
	void Update () {

        var POIs = GetPOIs(m_POIpath);

        if (m_textPOI)
        {
            m_textPOI.text = (m_activePOIIndex == -1 ? "" : POIs.Count <= m_activePOIIndex ? "NA" : POIs[m_activePOIIndex].name);
        }

        m_buttonPrevious.interactable = (m_activePOIIndex > 0);

        m_buttonNext.interactable = (m_activePOIIndex < POIs.Count - 1);
    }

    public void Next_OnCLick()
    {
        m_activePOIIndex = Math.Min(++m_activePOIIndex, GetPOIs(m_POIpath).Count-1);
        //ActivatePOI(POIs[m_activePOIIndex]);
    }

    public void Previous_OnCLick()
    {
        m_activePOIIndex = Math.Max(--m_activePOIIndex, 0);
        //ActivatePOI(POIs[m_activePOIIndex]);
    }
}
