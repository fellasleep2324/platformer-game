using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller;
    public Animator animator;
    public PlayerCombat combat;

    public void OnLanding ()
    {
        animator.SetBool("IsJumping",false);
        animator.ResetTrigger("Attack1");
        animator.ResetTrigger("Attack2");
        
        
     }
    

    public float runSpeed = 40f;
    float horizontalMove = 0f;
    bool jump = false;
   
    // Start is called before the first frame update
    void Start()
    {
 
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
            animator.SetBool("IsJumping", true);
        }
      
    

    }
    void FixedUpdate()

    {
        // Move your charracter
        controller.Move(horizontalMove * Time.fixedDeltaTime,jump);
        jump = false;
    }

    
}