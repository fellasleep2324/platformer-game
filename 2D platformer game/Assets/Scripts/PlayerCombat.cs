using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{

    public Animator animator;
    public PlayerMovement playerMovement;
    

    public Transform attackpoint;
    public float attackRange = 0.5f;
    public LayerMask enemyLayers;
    
    public int attackDamage = 1;
    public float attackRate = 1f;
    float nextAttackTime = 0;
   
   

    void Update()
    {
        
        if (Time.time >= nextAttackTime)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Attack();
                nextAttackTime = Time.time + 1f / attackRate;
            }
        }
    }

        

     void Attack()
    {
        
       /* if(animator.IsJumping && !Attack2)
        {
            animator.SetTrigger("Attack2");
        }
    */

        animator.SetTrigger("Attack1");
        

        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackpoint.position, attackRange, enemyLayers);

        foreach (Collider2D enemy in hitEnemies)
        {
            enemy.GetComponent<LightBanditHealthBar>().TakeDamage(attackDamage);
        }
    }
    void OnDrawGizmosSelected()
    {
        if (attackpoint == null)
            return;

        Gizmos.DrawWireSphere(attackpoint.position, attackRange);
    }

    


    



}
