using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuPOI : MonoBehaviour {

    public GameObject m_menuParent = null;

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

    private void OpenMenu(GameObject menu)
    {
        this.gameObject.SetActive(false);
        menu.SetActive(true);
    }
}
