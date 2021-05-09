using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class playerdeath : MonoBehaviour
{

   
    public Animator death;

    void Update()
    {
       
        if (gameObject.transform.position.y < -90)
        {
            Destroy(gameObject);
            levelmanage.instance.Respawn();
          


        };

    }

  



    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("enemy"))
        {
            Destroy(gameObject);
            levelmanage.instance.Respawn();
        }




    }

    


}
