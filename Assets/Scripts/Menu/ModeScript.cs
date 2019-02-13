using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModeScript : MonoBehaviour {

    public GameObject playPanel;
    public GameObject modePanel;

    public void tigaD(string nameScene)
    {
        Application.LoadLevel(nameScene);
    }

    public void AR(string nameScene)
    {
        Application.LoadLevel(nameScene);
    }

    public void Back()
    {
        modePanel.SetActive(false);
        playPanel.SetActive(true);
    }
}
