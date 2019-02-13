using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayScript : MonoBehaviour {

    public GameObject menuPanel;
    public GameObject playpanel;
    public GameObject modePanel;

    public void Chapter1()
    {
        playpanel.SetActive(false);
        modePanel.SetActive(true);
    }

    public void Chapter2(string nameScene)
    {
        Application.LoadLevel(nameScene);
    }

    public void Back()
    {
        playpanel.SetActive(false);
        menuPanel.SetActive(true);
    }
	
}
