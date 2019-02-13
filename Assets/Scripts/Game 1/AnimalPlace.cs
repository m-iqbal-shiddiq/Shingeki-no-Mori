using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class AnimalPlace : MonoBehaviour {

    public Color newColor;
    private Color baseColor;
    public Color redColor;

    private Renderer render;

    public GameObject tower;
    public Vector3 positionGorilla;

    BuildMaster BM;
    public TowerBP TBP;

    private void Start()
    {
        render = GetComponent<Renderer>();
        baseColor = render.material.color;
        BM = BuildMaster.instance;
    }

    public Vector3 GetGorillaPosition()
    {
        return transform.position + positionGorilla;
    }

    public void SellTower()
    {
        PlayerStat.fruit += TBP.HargaJual();
        Destroy(tower);
        TBP = null; 
    }

    private void OnMouseEnter()
    {
        if (EventSystem.current.IsPointerOverGameObject())
        {
            return;
        }

        if (!BM.bisaBangun)
        {
            return;
        }

        if (BM.hasFruit)
        {
            render.material.color = newColor;
        } else
        {
            render.material.color = redColor;
        }
    }

    private void OnMouseDown()
    {
        if (EventSystem.current.IsPointerOverGameObject())
        {
            return;
        }

        if(tower != null)
        {
            BM.SelectAP(this);
            return;
        }

        if (!BM.bisaBangun)
        {
            return;
        }

        BM.buildTowerOn(this);
    }

    private void OnMouseExit()
    {
        render.material.color = baseColor;
    }
}
