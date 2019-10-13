using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBulletController : MonoBehaviour
{
    public GameObject bullet;
    public float interval = 1;
    // Start is called before the first frame update
    void Start()
    {
        //InvokeRepeating("shootBullet", interval, interval);
    }
    void shootBullet()
    {
        if (Input.GetButtonDown("Fire1") == true)
        {
            GameObject g = (GameObject)Instantiate(bullet, transform.position, Quaternion.identity);
        }
    }
    // Update is called once per frame
    void Update()
    {
        shootBullet();
    }
}
