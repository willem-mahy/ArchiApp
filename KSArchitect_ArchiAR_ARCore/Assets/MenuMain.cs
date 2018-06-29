using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuMain : MonoBehaviour {

    public GameObject m_menuParent = null;
    public GameObject m_menuModel = null;
    public GameObject m_menuPOI = null;
    public GameObject m_menuGraphicsSettings = null;
    public GameObject m_menuDebug = null;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnButtonCloseClick()
    {
        OpenMenu(m_menuParent);
    }

    public void OnButtonMenuModelClick()
    {
        OpenMenu(m_menuModel);
    }

    public void OnButtonMenuPOIClick()
    {
        OpenMenu(m_menuPOI);
    }

    public void OnButtonMenuGraphicsSettingsClick()
    {
        OpenMenu(m_menuGraphicsSettings);
    }

    public void OnButtonMenuDebugClick()
    {
        OpenMenu(m_menuDebug);
    }

    public void OnButtonQuitClick()
    {
        // Quit the Application.
        Application.Quit();
    }

    //! Closes this menu and opens another.
    private void OpenMenu(GameObject menu)
    {
        this.gameObject.SetActive(false);
        menu.SetActive(true);
    }    
}
