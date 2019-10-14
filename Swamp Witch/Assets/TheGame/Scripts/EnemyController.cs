using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float HP = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Barricade")
        {
            HP--;
            if (HP <= 0)
            {
                Destroy(this.gameObject);
            }

        }
        if (collision.gameObject.tag == "PlayerBullet")
        {
            
            HP--;
            if (HP <= 0)
            {
                Destroy(this.gameObject);
            }
        }
    }
}
