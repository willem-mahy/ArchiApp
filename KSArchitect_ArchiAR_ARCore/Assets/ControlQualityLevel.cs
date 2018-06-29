using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlQualityLevel : MonoBehaviour {

    public Button m_buttonNext = null;

    public Text m_textGraphicsQuality = null;

    public Button m_buttonPrevious = null;

    // Use this for initialization
    void Start() {
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (m_textGraphicsQuality)
        {
            m_textGraphicsQuality.text = QualitySettings.names[QualitySettings.GetQualityLevel()];
        }

        m_buttonPrevious.interactable = (QualitySettings.GetQualityLevel() > 0);

        m_buttonNext.interactable = (QualitySettings.GetQualityLevel() < QualitySettings.names.Length - 1);
    }
        
    public void NextQuality()
    {
        QualitySettings.IncreaseLevel();
    }

    public void PreviousQuality()
    {
        QualitySettings.DecreaseLevel();
    }

}
