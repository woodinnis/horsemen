using UnityEngine;
using System.Collections;

public class f_Health : MonoBehaviour
{
	public float maxHealth;
	public string hitFX;

	private float currentHealth;

	void Start()
	{
		currentHealth = maxHealth;
	}

	public void TakeDamage(float amount)
	{
		currentHealth -= amount;
	}

	public bool IsAlive()
	{
		return (currentHealth > 0.0f);
	}

	public float displayHealth()
	{
		return currentHealth;
	}

	public string GetHitFX()
	{
		return hitFX;
	}
}