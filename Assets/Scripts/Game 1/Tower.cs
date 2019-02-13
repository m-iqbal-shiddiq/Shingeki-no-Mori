using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour {

    public Transform target;
    public float jarak = 15f;

    public string enemyTag = "Enemy";

    public Transform bagianRotate;
    public float turnSpeed = 10f;

    public float fireRate = 1f;
    private float fireCountdown = 0f;

    public GameObject bonePrefab;
    public Transform shootPoint;

    GameObject gorillaSound;


	void Start () {
        InvokeRepeating("UpdateTarget", 0f, 0.5f);
 
	}
	
	void Update () {
       
		if(target == null)
        {
            return;
        }
         // Mengunci target
        Vector3 direction = target.position - transform.position;
        Quaternion lookRotation = Quaternion.LookRotation(direction);
        Vector3 putaran = Quaternion.Lerp(bagianRotate.rotation, lookRotation, Time.deltaTime * turnSpeed).eulerAngles;
        bagianRotate.rotation = Quaternion.Euler(0f, putaran.y, 0f);

        if(fireCountdown <= 0f)
        {
            Shoot();
            fireCountdown = 1f / fireRate;
        }
    
   
        fireCountdown -= Time.deltaTime;
	}

    void Shoot()
    {
        GameObject bulletGO = (GameObject)Instantiate(bonePrefab, shootPoint.position, shootPoint.rotation);
        Bullet bullet = bulletGO.GetComponent<Bullet>();


        if(bullet != null)
        {
            bullet.Seek(target);
        }
    }

    

    void UpdateTarget()
    {
        
        GameObject[] enemies = GameObject.FindGameObjectsWithTag(enemyTag);

        float jarakTerpendek = Mathf.Infinity;
        GameObject enemyTerdekat = null;

        foreach(GameObject enemy in enemies)
        {
            float jarakEnemy = Vector3.Distance(transform.position, enemy.transform.position);
            if (jarakEnemy < jarakTerpendek)
            {
                jarakTerpendek = jarakEnemy;
                enemyTerdekat = enemy;
            }
        }

        if (enemyTerdekat != null && jarakTerpendek <= jarak)
        {
            target = enemyTerdekat.transform;
        } else
        {
            target = null;
        }

    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, jarak);
    }
}
