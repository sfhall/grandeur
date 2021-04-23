using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossHealth : MonoBehaviour
{

	public int health = 500;
	public int currentHealth;

	public GameObject deathEffect;

	public bool isInvulnerable = false;

	public Animator animator;

	public HealthBar healthBar;

	void Start()
	{
		currentHealth = health;
		healthBar.SetMaxHealth(health);
	}

	public void TakeDamage(int damage)
	{
		if (isInvulnerable)
			return;

		health -= damage;
		healthBar.Sethealth(health);

		if (health <= 200)
		{
			GetComponent<Animator>().SetBool("IsEnraged", true);
		}

		if (health <= 0)
		{
			Die();
		}
	}

	void Die()
	{
		//Instantiate(deathEffect, transform.position, Quaternion.identity);
		//Destroy(gameObject);
		animator.SetBool("IsDead", true);

		// Disable the enemy
		Destroy(this.gameObject, 1);
		this.enabled = false;
	}

}
