using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cherrypickup : MonoBehaviour
{
    public int cherryamounts = 1;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Destroy(gameObject);
            levelmanage.instance.IncreaseCherry(cherryamounts);
        }
    }
}
