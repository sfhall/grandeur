using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BossHealth : MonoBehaviour
{

	public int health = 500;
	public int currentHealth;

	public GameObject deathEffect;

	public bool isInvulnerable = false;

	public Animator animator;

	public HealthBar healthBar;

	public GameObject key;

	float cntdnw = 60.0f;
	public Text disvar;

	void Start()
	{
		currentHealth = health;
		healthBar.SetMaxHealth(health);
		key.SetActive(false);
	}

	void Update()
	{

		if (cntdnw > 0)
		{
			cntdnw -= Time.deltaTime;
		}

		double b = System.Math.Round(cntdnw, 2);


		disvar.text = b.ToString();

		if (cntdnw < 0)

		{
			SceneManager.LoadScene("level0");
			Debug.Log("Completed");

		}

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

		key.SetActive(true);

		//SceneManager.LoadScene("level0");
	}

}
