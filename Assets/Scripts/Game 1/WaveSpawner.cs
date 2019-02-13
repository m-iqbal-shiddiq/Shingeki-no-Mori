using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSpawner : MonoBehaviour {

    public Transform barbarPrefabs;

    public Transform spawnLoct;

    public float timeWaves = 5f;
    private float countDown = 2f;

    private int waveNum = 0;
    public int batasWave = 1;

    public GameObject winpanel;
    private float counter;

    public float timeAfter = 15f;

    private void Update()
    {
        Debug.Log(timeAfter);

            if (timeAfter <= 0)
            {
                winpanel.SetActive(true);
            }


        if(countDown <= 0f)
        {
            StartCoroutine(SpawnWave());
            SpawnWave();
            countDown = timeWaves;
        }
        timeAfter -= Time.deltaTime;
        countDown -= Time.deltaTime;
    }


    IEnumerator SpawnWave()
    {
        if(waveNum <= 6)
        {
            waveNum++;
        } else
        {
            waveNum = -5;
        }
       

        for (int i = 0; i < waveNum; i++)
        {
            SpawnEnemy();
            yield return new WaitForSeconds(0.5f);
        }

    }

    void SpawnEnemy()
    {
        Instantiate(barbarPrefabs, spawnLoct.position, spawnLoct.rotation);
    }
}
