using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Animator animator;

    public int maxHealth = 100;
    int currenthealth;


    // Start is called before the first frame update
    void Start()
    {
        currenthealth = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        currenthealth -= damage;

        // Play hurt animation
        animator.SetTrigger("Hurt");

        if(currenthealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        // Debug.Log("Enemy died!");

        // Die animation
        animator.SetBool("IsDead", true);

        // Disable the enemy
        Destroy(this.gameObject, 1);
        this.enabled = false;

    }

}
