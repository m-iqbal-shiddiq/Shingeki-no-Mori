using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    public float kecepatan = 10f;

    public int darah = 100;

    public int dapatFruit = 50;

    private Transform target;
    private int waveIndex = 0;

    public GameObject panel;

    public static int c = 0;

    private void Start()
    {
        target = Way.points[0];

        Vector3 dir = target.position - transform.position;
        transform.Translate(dir.normalized * kecepatan * Time.deltaTime, Space.World);

        transform.rotation = Quaternion.LookRotation(dir);
        transform.position = new Vector3(transform.position.x, 0.4f, transform.position.z);
    }

    public void terimaDamage(int damage)
    {
        darah -= damage;

        if(darah <= 0)
        {
            Mati();
        }
    }

    void munculWoi()
    {
        panel.SetActive(true);
    }

    void Mati()
    {
        PlayerStat.fruit += dapatFruit;
        c++;
        Destroy(gameObject);
    }

    private void Update()
    {
        Vector3 dir = target.position - transform.position;
        transform.Translate(dir.normalized * kecepatan * Time.deltaTime, Space.World);
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(dir), 0.15f);

        if(Vector3.Distance(transform.position, target.position) <= 0.2f)
        {
            nextWay();
        }
    }

    void nextWay()
    {
        if(waveIndex >= Way.points.Length - 1)
        {
            endWay();
            return;
        }

        waveIndex++;
        target = Way.points[waveIndex];
    }

    void endWay()
    {
        PlayerStat.Lives--;
        Destroy(gameObject);
    }
}
