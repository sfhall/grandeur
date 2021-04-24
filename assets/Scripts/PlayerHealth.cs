using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
	public int health = 150;
	public int currentHealth;

	public GameObject deathEffect;

	public HealthBar healthBar;

    void Start()
    {
		currentHealth = health;
		healthBar.SetMaxHealth(health);
    }

    public void TakeDamage(int damage)
	{
		health -= damage;
		healthBar.Sethealth(health);

		StartCoroutine(DamageAnimation());

		if (health <= 0)
		{
			Die();
		}
	}

	void Die()
	{
		//SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		SceneManager.LoadScene("level0_1");
	}

	IEnumerator DamageAnimation()
	{
		SpriteRenderer[] srs = GetComponentsInChildren<SpriteRenderer>();

		for (int i = 0; i < 3; i++)
		{
			foreach (SpriteRenderer sr in srs)
			{
				Color c = sr.color;
				c.a = 0;
				sr.color = c;
			}

			yield return new WaitForSeconds(.1f);

			foreach (SpriteRenderer sr in srs)
			{
				Color c = sr.color;
				c.a = 1;
				sr.color = c;
			}

			yield return new WaitForSeconds(.1f);
		}
	}
}