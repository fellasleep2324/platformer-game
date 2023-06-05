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
public bool Collapse;

void Start() 
{
 Collapse = false;
 isChasing = false;    
}

    // Update is called once per frame
void Update()
    {
        if(Target.position.y > Begin.position.y)
        {
            Collapse = true;
            isChasing = true; 
        }

    if(isChasing)
    {
        Vector2.MoveTowards(transform.position, Target.position, moveSpeed*Time.deltaTime);

    }
        
    }
}
