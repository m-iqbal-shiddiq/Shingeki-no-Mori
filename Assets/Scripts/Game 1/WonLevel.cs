using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WonLevel : MonoBehaviour {

	public void nextLevel(string sceneName)
    {
        Application.LoadLevel(sceneName);
    }

    public void Menu(string sceneName)
    {
        Application.LoadLevel(sceneName);
    }
}
