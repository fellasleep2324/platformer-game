using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{   public Animator animator;
    public int maxHealth = 5;
    public int currentHealth;
    

    public HealthBar healthBar;
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        animator.SetTrigger("Ouch");

        healthBar.SetHealth(currentHealth);
    
 
     if(currentHealth == 0)
     {
        animator.SetTrigger("Death");
     }
     
    }
}
   