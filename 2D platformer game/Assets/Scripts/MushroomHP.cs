using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MushroomHP : MonoBehaviour
{
    public Animator animator;
    public int maxHealth = 4;
    public int currentHealth;

    public HealthBar healthBar;
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        healthBar.SetHealth(currentHealth);

        animator.SetTrigger("Ouch");

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        animator.SetBool("IsDie", true);

        GetComponent<Collider2D>().enabled = false;
        this.enabled = false;
    }
}
