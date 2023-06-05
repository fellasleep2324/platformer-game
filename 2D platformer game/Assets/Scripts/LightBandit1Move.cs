using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightBandit1Move : MonoBehaviour
{
    public Transform[] patrolPoints;
    public int patrolDestination;
    public float moveSpeed;
    public Animator animator;
    public Transform Target;
    public bool isChasing; 
    public float chaseDistance;
    public LightBanditHealthBar health;



    public Transform attackPoint;
    public float attackRange = 0.5f;
    public LayerMask playerLayers;
    public int attackDamage = 1;
    public float attackRate = 1f;
    float nextAttackTime = 0;

    // Update is called once per frame
    void OnDrawGizmosSelected() 
    { 
        if(attackPoint == null)
            return; 
        Gizmos.DrawWireSphere(attackPoint.position, attackRange); 
    }
    void Update()
    {
        if(health.currentHealth == 0)
        {
            return;
        }
        if(Time.time > nextAttackTime)
        {
            nextAttackTime = Time.time + 1f / attackRate;
        }
    
        if(Vector2.Distance(Target.position,transform.position) <3f)
        {
            animator.SetTrigger("Attack");

            Collider2D[] hitPlayer = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, playerLayers);

            foreach(Collider2D player in hitPlayer)
            { 
             Debug.Log("playerhasbeenhit"); 
             player.GetComponent<PlayerHealth>().TakeDamage(attackDamage); 
            }

        }
            if(Vector2.Distance(Target.position, transform.position) > chaseDistance)
            {
                isChasing = false;
            }
         if(isChasing)
        {
            moveSpeed = 3f;
            if(transform.position.x > Target.position.x)
            {
                transform.localScale = new Vector3(1.9f,1.3f,1);
                transform.position += Vector3.left * moveSpeed*Time.deltaTime;
            }
             if(transform.position.x < Target.position.x)
            {
                transform.localScale = new Vector3(-1.9f,1.3f,1);
                transform.position += Vector3.right*moveSpeed*Time.deltaTime;
            }
        }
        else
        if(Vector2.Distance(transform.position, Target.position) < chaseDistance)
         {
             isChasing = true;
        }
         
        else
        {
            moveSpeed = 2f;
        if(patrolDestination == 0)
        {
            transform.position = Vector2.MoveTowards(transform.position, patrolPoints[0].position, moveSpeed * Time.deltaTime);
            if (Vector2.Distance(transform.position, patrolPoints[0].position) < 0.2f)
            { 
                patrolDestination = 1;
                animator.SetFloat("Speed", moveSpeed);
                transform.localScale = new Vector3(-1.9f, 1.3f, 1);
                
            }
        }
         
        if(patrolDestination == 1)
        {
            transform.position = Vector2.MoveTowards(transform.position, patrolPoints[1].position, moveSpeed * Time.deltaTime);
            if (Vector2.Distance(transform.position, patrolPoints[1].position) < 0.2f)
            {   
                patrolDestination = 0;
                animator.SetFloat("Speed", moveSpeed);
                transform.localScale = new Vector3(1.9f, 1.3f, 1);
            }
        }
        }
    }
    
}


       
        
        
        
        
        

   
