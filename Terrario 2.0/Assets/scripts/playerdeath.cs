using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class playerdeath : MonoBehaviour
{

   
    public Animator death;
    public int maxHealth = 5;
    public int currentHealth;

    public HealthBar healthBar;


     void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }



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
            TakeDamage(1);
            
            if(currentHealth == 0) {
                Destroy(gameObject);
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
           
        }




    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;

        healthBar.SetHealth(currentHealth);
    }


}
