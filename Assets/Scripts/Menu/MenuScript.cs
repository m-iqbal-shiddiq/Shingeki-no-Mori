using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuScript : MonoBehaviour {

    public GameObject panelMenu;
    public GameObject panelPlay;
    public GameObject panelOption;

    public void Play()
    {
        panelMenu.SetActive(false);
        panelPlay.SetActive(true);
    }

    public void Option()
    {
        panelMenu.SetActive(false);
        panelOption.SetActive(true);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
