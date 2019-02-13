using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour {

    public TowerBP gorillaPrefab;

    BuildMaster BM;

    private void Start()
    {
        BM = BuildMaster.instance;
    }

    public void selectGorilla()
    {
        BM.seletTowerBuild(gorillaPrefab);
    }
}
