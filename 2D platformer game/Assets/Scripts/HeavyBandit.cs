using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeavyBandit : MonoBehaviour
{
    public float chaseSpeed;
    public float moveSpeed;
    public Animator animator;
    public Transform Target;
    public bool isChasing; 
    public float chaseDistance;
    public LightBanditHealthBar health;

void Start() 
{
    isChasing = false;
}
    void Update()
    {
        
        if(isChasing == false)
        {
            moveSpeed = 0;
        }

        animator.SetFloat("Speed",moveSpeed);

        /* if(health.currentHealth == 0)
        {
            isChasing = false;
            return;
        }
        */    
    
         if(Vector2.Distance(Target.position,transform.position) <chaseDistance)
        {
            isChasing = true;

        } 

        if(Vector2.Distance(Target.position,transform.position) > 3f)
        {
            animator.SetBool("Attack", false);

        } 
        
        if(Vector2.Distance(Target.position,transform.position) <3f)
        {
            animator.SetBool("Attack", true);

        }   
         if(isChasing)
        {
            moveSpeed = chaseSpeed;
            if(transform.position.x > Target.position.x)
            {
                transform.localScale = new Vector3(2f,1.6f,1);
                transform.position += Vector3.left * moveSpeed*Time.deltaTime;
            }
             if(transform.position.x < Target.position.x)
            {
                transform.localScale = new Vector3(-2f,1.6f,1);
                transform.position += Vector3.right*moveSpeed*Time.deltaTime;
            }
        }
        else
        if(Vector2.Distance(transform.position, Target.position) < chaseDistance)
         {
             isChasing = true;
        }
         
        
}
}

