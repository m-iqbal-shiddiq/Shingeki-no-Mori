using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    private Transform target;

    public float kecepatan = 50f;
    public int dmg = 25;
    public GameObject bulletEffect;

    public void Seek (Transform _target)
    {
        target = _target;
    }

	void Update () {
		if(target == null)
        {
            Destroy(gameObject);
            return;
        }

        Vector3 direction = target.position - transform.position;
        float distanceFrame = kecepatan * Time.deltaTime;

        if(direction.magnitude <= distanceFrame)
        {
            HitTarget();
            return;
        }

        transform.Translate(direction.normalized * distanceFrame, Space.World);
    }

    void HitTarget()
    {
     
        GameObject effectNya = (GameObject)Instantiate(bulletEffect, transform.position, transform.rotation);
        Destroy(effectNya, 2f);

        Damage(target);

        Destroy(gameObject);
    }

    void Damage (Transform enemy)
    {
        Enemy enm = enemy.GetComponent<Enemy>();

        if(enemy != null)
        {
            enm.terimaDamage(dmg);
        }

    }
}
