using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMonsterController : MonoBehaviour
{
    public GameObject Monster1;
    public float interval = 3;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnMonster", interval, interval);   
    }

    void SpawnMonster()
    {
        float v = Random.value;
        //mit 40%iger Wahrscheinlichkeit wird ein Monster generiert
        if (v < 0.4)
        {
            GameObject g= (GameObject)Instantiate(Monster1, transform.position, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
