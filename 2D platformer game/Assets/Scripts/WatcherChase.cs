using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WatcherChase : MonoBehaviour
{
public float moveSpeed;
public Animator animator; 
public Transform Target;
public bool isChasing;
public Transform Begin;
public float attackRange;
public Transform Slow;

void Start() 
{
 isChasing = false;    
}

    // Update is called once per frame
void Update()

    
    {
        if(Target.position.y > Begin.position.y)
        {
            isChasing = true; 
        }

    if(isChasing)
    {
        transform.position = Vector2.MoveTowards(transform.position, Target.position, moveSpeed*Time.deltaTime);
        if(Target.position.x < attackRange)
        {
            animator.SetTrigger("Attack");
            if(animator.GetCurrentAnimatorStateInfo(0).IsName("Attack"))
            {
                //cause lethal damage
            }
        }

    }
        if(Target.position.x > Slow.position.x)
        {
            isChasing = false;
        }
    }
}
