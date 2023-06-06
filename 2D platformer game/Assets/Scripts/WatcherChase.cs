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

public float attackRanger = 0.5f;
public Transform attackPoint;
public LayerMask playerLayers;
public int attackDamage = 10;

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
                    Collider2D[] hitPlayer = Physics2D.OverlapCircleAll(attackPoint.position, attackRanger, playerLayers);

                    foreach (Collider2D player in hitPlayer)
                    {
                        Debug.Assert(player != null, player);



                        playerHealth1 playerHealth = player.GetComponent<playerHealth1>();

                        if (!playerHealth)

                        {

                            Debug.LogError("Collider does not have EnemyHealth component. " + player.name, player);


                        }
                        else
                        {
                            playerHealth.TakeDamage(attackDamage);
                        }

                    }
                }
        }

    }
        if(Target.position.x > Slow.position.x)
        {
            isChasing = false;
        }
    }
    void OnDrawGizmosSelected()
    {
        if (attackPoint == null)
            return;
        Gizmos.DrawWireSphere(attackPoint.position, attackRanger);
    }
}
