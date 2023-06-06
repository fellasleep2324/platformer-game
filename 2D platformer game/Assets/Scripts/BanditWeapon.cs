using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BanditWeapon : MonoBehaviour
{ 

    public Transform attackPoint;
    public float attackRange = 0.5f;
    public LayerMask playerLayers;

    public int attackDamage = 1;
    public void BanditAttack()
    {
        Collider2D[] hitPlayer = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, playerLayers);

        foreach(Collider2D player in hitPlayer)
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

    void OnDrawGizmosSelected()
    {
        if (attackPoint == null)
         return;
        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }
}
