using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletController : MonoBehaviour
{
    public float moveSpeed = 10f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.right * moveSpeed * Time.deltaTime;

    }

    private void DestroyBullet()
    {
        gunController.instance.bulletPool.ReturnObject(gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        DestroyBullet();
    }
    private void OnBecameInvisible()
    {
        DestroyBullet();
    }
}
