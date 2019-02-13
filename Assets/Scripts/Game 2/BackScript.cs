using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackScript : MonoBehaviour {

	public void Back(string nameScene)
    {
        Application.LoadLevel(nameScene);
    }
}
