using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerdeath : MonoBehaviour
{

    public float playerhealth = 3;

    void Update()
    {
        if (gameObject.transform.position.y < -30)
        {
            Destroy(gameObject);
            levelmanage.instance.Respawn();
            playerhealth--;
        };

    }



    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("enemy"))
        {
            
            Destroy(gameObject);
            levelmanage.instance.Respawn();
            playerhealth--; 
          

        }




    }

    
}
