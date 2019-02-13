using System.Collections;
using UnityEngine;


[System.Serializable]
public class TowerBP  {

    public GameObject prefab;
    public int Cost;

    public int HargaJual()
    {
        return Cost / 2 ;
    }
}
