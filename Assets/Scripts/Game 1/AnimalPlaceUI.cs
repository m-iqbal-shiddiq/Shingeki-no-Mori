using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalPlaceUI : MonoBehaviour {

    private AnimalPlace target;
    public GameObject canvas;

    public void selectTarget(AnimalPlace _target)
    {
        target = _target;

        transform.position = target.GetGorillaPosition();

        canvas.SetActive(true);
    }

    public void Hide()
    {
        canvas.SetActive(false);
    }

    public void Jual()
    {
        target.SellTower();
        BuildMaster.instance.DeselectAP();
    }
}
