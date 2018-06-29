using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuDefault : MonoBehaviour {

    public GameObject m_menuMain = null;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnButtonMenuMain()
    {
        OpenMenu(m_menuMain);
    }

    private void OpenMenu(GameObject menu)
    {
        this.gameObject.SetActive(false);
        menu.SetActive(true);
    }
}
