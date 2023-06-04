using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightBandit1Move : MonoBehaviour
{
    public Transform[] patrolPoints;
    public float moveSpeed;
    public int patrolDestination;
    public Animator animator;


    // Update is called once per frame
    void Update()
    {
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

   
