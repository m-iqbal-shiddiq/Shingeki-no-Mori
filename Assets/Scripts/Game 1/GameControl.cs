using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour {

    public static bool gameBerakhir;

    public GameObject gameOverUI;
    public GameObject WinLevelUI;

    private void Start()
    {
        gameBerakhir = false;
    }

    void Update () {
        if (gameBerakhir)
        {
            return;
        }

		if(PlayerStat.Lives <= 0)
        {
            EndGame();
        }
	}

    void EndGame()
    {
        gameBerakhir = true;

        gameOverUI.SetActive(true);
    }

    public void WinLevel()
    {

        WinLevelUI.SetActive(true);

        gameBerakhir = true;

    }
}
