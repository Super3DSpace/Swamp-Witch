using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float HP = 1f;
    private PlayerStats playerstats;
    private GameManager gamemanager;
    // Start is called before the first frame update
    void Start()
    {
        playerstats = GameObject.FindObjectOfType<PlayerStats>();
        gamemanager = GameObject.FindObjectOfType<GameManager>();
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
            playerstats.HP--;
            if (playerstats.HP <=0)
            {
                gamemanager.GameOver();
            }
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
