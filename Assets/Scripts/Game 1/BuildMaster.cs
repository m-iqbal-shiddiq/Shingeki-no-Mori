using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildMaster : MonoBehaviour {

    public static BuildMaster instance;

    private void Awake()
    {
        instance = this;
    }

    public GameObject GorillaPrefab;

    private TowerBP TowerBuild;

    private AnimalPlace selectAP;
    public AnimalPlaceUI APUI;

    public bool bisaBangun { get { return TowerBuild != null; } }
    public bool hasFruit { get { return PlayerStat.fruit >= TowerBuild.Cost;  } }

    public void buildTowerOn(AnimalPlace AP)
    {
        if(PlayerStat.fruit < TowerBuild.Cost)
        {
            return;
        }

        PlayerStat.fruit -= TowerBuild.Cost;

        GameObject tower = (GameObject)Instantiate(TowerBuild.prefab, AP.GetGorillaPosition(), Quaternion.identity);
        AP.tower = tower;
        Debug.Log(PlayerStat.fruit);        
    }

    public void SelectAP(AnimalPlace AP)
    {
        if(selectAP == AP)
        {
            DeselectAP();
        }

        selectAP = AP;
        TowerBuild = null;

        APUI.selectTarget(AP);
    }

    public void DeselectAP()
    {
        selectAP = null;
        APUI.Hide();
    }

    public void seletTowerBuild(TowerBP tower)
    {
        TowerBuild = tower;

        DeselectAP();
    }
}
