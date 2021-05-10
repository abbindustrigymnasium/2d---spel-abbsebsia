using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cherrypickup : MonoBehaviour
{
    public int cherryamount = 1;
    public HealthBar healthbars;
   

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Destroy(gameObject);
            healthbars.Increasehealth(cherryamount);
        }
    }


    
}
