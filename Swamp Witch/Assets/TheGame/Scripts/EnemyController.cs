using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
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
            Destroy(this.gameObject);
        }
        if (collision.gameObject.tag == "PlayerBullet")
        {
            //hier kann später Enemy HP-- oder etwas in der Art eingebaut werden
            Destroy(this.gameObject);

        }
    }
}
