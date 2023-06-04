using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightBandit1Move : MonoBehaviour
{
    public Transform[] patrolPoints;
    public float moveSpeed;
    public int patrolDestination;
    public Animator animator;

    public Transform Target;
    public bool isChasing; 
    public float chaseDistance;
    


    // Update is called once per frame
    void Update()
    {
        if(isChasing)
        {
            moveSpeed = 4f;
            if(transform.position.x > Target.position.x)
            {
                transform.localScale = new Vector3(1,1,1);
                transform.position += Vector3.left * moveSpeed *Time.deltaTime;
            }
             if(transform.position.x < Target.position.x)
            {
                transform.localScale = new Vector3(-1,1,1);
                transform.position += Vector3.right * moveSpeed * Time.deltaTime;
            }
        }

        else
        {
            if(Target.position.x > patrolPoints[0].position.x)
            {

                if(Vector2.Distance(transform.position, Target.position) < chaseDistance)
                {
                    isChasing = true;
                }
            }
        else
        {
            moveSpeed = 2f;
           if(patrolDestination == 0)
        {
            transform.position = Vector2.MoveTowards(transform.position, patrolPoints[0].position, moveSpeed * Time.deltaTime);
            animator.SetFloat("Speed", moveSpeed);
            if (Vector2.Distance(transform.position, patrolPoints[0].position) < 0.2f)
            {
                transform.localScale = new Vector3(-1, 1, 1);
                patrolDestination = 1;
            }
        }

        if(patrolDestination == 1)
        {
            transform.position = Vector2.MoveTowards(transform.position, patrolPoints[1].position, moveSpeed * Time.deltaTime);
            animator.SetFloat("Speed", moveSpeed);
            if (Vector2.Distance(transform.position, patrolPoints[1].position) < 0.2f)
            {
                transform.localScale = new Vector3(1, 1, 1);
                patrolDestination = 0;
            }
        } 
        }
        }
        
        
        
        
        
        
        
        
    }
}

   
