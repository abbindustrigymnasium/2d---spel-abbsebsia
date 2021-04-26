using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour {
    public float movementSpeed;
    public Rigidbody2D rb;

    public Animator anim;


    public float jumpForce = 20f;
    public Transform feet;
    public LayerMask groundLayers;
    public LayerMask climbLayers;
    [HideInInspector] public bool isFacingRight = true;

    float mx;
    
    private void Update(){
        mx = Input.GetAxisRaw("Horizontal");

        if (Input.GetButtonDown("Jump") && IsGrounded()){
            Jump();
        }
        if (Mathf.Abs(mx) > 0.05f){
            anim.SetBool("IsRunning", true);
        }
        else {
            anim.SetBool("IsRunning", false);
        }

        if (mx > 0f)
        {
            transform.localScale = new Vector3(2f, 2f, 2f);
            isFacingRight = true;
        }
        else if(mx < 0f)
        {
            transform.localScale = new Vector3(-2f, 2f, 2f);
            isFacingRight = false;
        }

        if (Input.GetMouseButtonDown(0)) { 

            anim.SetBool("IsCrouching", true);
        } else { 
            anim.SetBool("IsCrouching", false); 
        }

        anim.SetBool("isGrounded", IsGrounded());


    }
    private void FixedUpdate(){
        Vector2 movement = new Vector2(mx* movementSpeed, rb.velocity.y);
        rb.velocity = movement;
    }

 

    void Jump(){
        Vector2 movement = new Vector2(rb.velocity.x, jumpForce);

        rb.velocity = movement;
    }

   
    
        
    

    public bool IsGrounded()
    {
        Collider2D groundCheck = Physics2D.OverlapCircle(feet.position, 0.5f, groundLayers);

        if (groundCheck != null)
        {
            return true;
        }
        return false;
    }

}




    
