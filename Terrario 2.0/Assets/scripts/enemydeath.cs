using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemydeath : MonoBehaviour
{
    // Start is called before the first frame update
    public float enemyhealth = 2;
    
    
    
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("bullet"))
        {
            enemyhealth--;
            if (enemyhealth == 0)
            {
                Destroy(gameObject);
            }
        } 
    }

    
}
