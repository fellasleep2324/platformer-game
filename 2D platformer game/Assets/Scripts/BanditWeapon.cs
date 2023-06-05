using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BanditWeapon : MonoBehaviour
{ 

    public Transform attackPoint;
    public LayerMask playerLayers;

    public float attackRange = 0.5f;
    public int attackDamage = 1;
    public void BanditAttack()
    {
        Collider2D[] hitPlayer = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, playerLayers);

        foreach(Collider2D player in hitPlayer)
        {
            Debug.Log("playerhasbeenhit");
            player.GetComponent<playerHealth1>().TakeDamage(attackDamage);
        }
    }

    void OnDrawGizmosSelected()
    {
        if (attackPoint == null)
            return;
        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }
}
