using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour {

    public CharacterController2D controller;
    public float movementSpeed = 10f;
    public Rigidbody2D rb;
   

    public Animator anim;


    public float jumpForce = 20f;
    public Transform feet;
    public LayerMask groundLayers;
    public LayerMask climbLayers;
    public bool isFacingRight = true;

    float mx;
    public bool crouch = false;
    public bool jump = false;
    
    private void Update(){
        mx = Input.GetAxisRaw("Horizontal");

        if (Input.GetButtonDown("Jump") && IsGrounded())
        {
            Jump();
            jump = true;
        }
        else
        {
            jump = false;
        }
        if (Mathf.Abs(mx) > 0.05f){
            anim.SetBool("IsRunning", true);
        }
        else {
            anim.SetBool("IsRunning", false);
        }

        if (mx > 0f)
        {
            transform.localScale = new Vector3(1f, 1f, 1f);
            isFacingRight = true;
        }
        else if(mx < 0f)
        {
            transform.localScale = new Vector3(-1f, 1f, 1f);
            isFacingRight = false;
        }

        if (Input.GetButtonDown("Vertical"))
        {
            movementSpeed = 7;
            jumpForce = 9;
            crouch = true;
            
        }
        else if (Input.GetButtonUp("Vertical"))
        {
            movementSpeed = 10 ;
            jumpForce = 16;
            crouch = false;
        }
        
            
       
        anim.SetBool("isGrounded", IsGrounded());
       


    }
    private void FixedUpdate(){
        Vector2 movement = new Vector2(mx* movementSpeed, rb.velocity.y);
        rb.velocity = movement;

        controller.Move(mx * Time.fixedDeltaTime, crouch, jump);
    }
    
    void Jump(){
        Vector2 movement = new Vector2(rb.velocity.x, jumpForce);

        rb.velocity = movement;
    }

   public void onCrouching(bool isCrouching)
    {
        anim.SetBool("IsCrouching", isCrouching);
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




    
