using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour
{
    public float fireRate = 0.2f;
    public Transform firingPoint;
    public GameObject bulletPrefab;
    public float bulletcount = 5;

    float timeUntilFire;
    movement pm;

    private void Start()
    {
        pm = gameObject.GetComponent<movement>();
    }

    private void Update()
    {
        if(Input.GetMouseButtonDown(0) && timeUntilFire< Time.time && bulletcount>0)
        {
         
            shoot();
            timeUntilFire = Time.time + fireRate;
            bulletcount--;
        }
    }

    void shoot()
    {
        float angle = pm.isFacingRight ? 0f : 180f;
        Instantiate(bulletPrefab, firingPoint.position, Quaternion.Euler(new Vector3(0f, 0f, angle)));
    }

}
