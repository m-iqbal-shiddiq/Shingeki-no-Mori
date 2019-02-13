using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStat : MonoBehaviour {

    public static int fruit;
    public int startFruit = 100;

    public static int Lives;    
    public int startLives = 3;

    private void Start()
    {
        fruit = startFruit;
        Lives = startLives;
    }
}
