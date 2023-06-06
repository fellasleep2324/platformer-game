using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller;
    public Animator animator;
    public PlayerCombat combat;
    public float KBforce;
    public float KBcounter; 
    public float Totaltime; 
    public Rigidbody2D playerRb;
    public playerHealth1 health1;

    public bool KnockfromRight; 

    public void OnLanding ()
    {
        animator.SetBool("IsJumping",false);
        Debug.Log("TouchingEarth");
        animator.ResetTrigger("Attack1");
        animator.ResetTrigger("Attack2");
        
        
     }
    

    public float runSpeed = 40f;
    float horizontalMove = 0f;
    bool jump = false;
   
    void Update()
{
    
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
            animator.SetBool("IsJumping", true);
        }
    }
    
 }
    void FixedUpdate()

    {
        if(KBcounter <= 0)
        {  
            // Move your charracter
           controller.Move(horizontalMove * Time.fixedDeltaTime,jump);
        jump = false; 
        }
    
        else 
        {
            if(KnockfromRight)
            {
                playerRb.velocity = new Vector2(-KBforce, KBforce);
            }
            if(KnockfromRight == false)
            {
                playerRb.velocity = new Vector2 (KBforce, KBforce); 
            }
            KBcounter -=Time.deltaTime;
        }
      
        
    }
 

    
}