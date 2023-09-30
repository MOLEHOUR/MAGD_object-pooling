using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gunController : MonoBehaviour
{
    public static gunController instance;

    public GameObject bullet;
    public Transform firepoint;
    public float fireRate = .1f;
    private float fireCounter;
    public objectPooler bulletPool;
    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
           FireBullet();
        }
        if(Input.GetButtonDown("Fire1"))
        {
            fireCounter -= Time.deltaTime;
            if(fireCounter <= 0)
            {
                FireBullet();
            }
        }
    }
    public void FireBullet()
    {
        fireCounter = fireRate;
        bulletPool.SpawnObject(firepoint.position, firepoint.rotation);
    }
}
