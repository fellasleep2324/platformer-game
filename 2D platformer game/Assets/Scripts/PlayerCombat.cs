using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{

    public Animator animator;
    public PlayerMovement playerMovement;
    

    public Transform attackPoint;
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
        animator.SetTrigger("Attack1");
        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers);

        foreach (Collider2D enemy in hitEnemies)
        {
            Debug.Assert(enemy != null, enemy);
            LightBanditHealthBar lightbanditHealth = enemy.GetComponent<LightBanditHealthBar>();

            if (!lightbanditHealth)

            {
                Debug.LogError("Collider does not have EnemyHealth component. " + enemy.name, enemy);
            }
            else
            {
                lightbanditHealth.TakeDamage(attackDamage);
            }
        }
    }

    private void OnDrawGizmosSelected()
    {
        if (attackPoint == null)
            return;
        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }
}
