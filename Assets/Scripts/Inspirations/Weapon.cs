/*using UnityEngine;
using System.Collections;

public abstract class Weapon : MonoBehaviour
{
	public GameObject child;
	
	public float damageAmount;
	public float range;
	public float fireRate;
	public bool hasScope;


	protected float coolDown;

	public abstract void OnFire();

	public abstract void Release ();

	void Start()
	{
		coolDown = 0f;
	}

	void Update()
	{
		if (coolDown > 0.0f)
		{
			coolDown -= Time.deltaTime;
		}
	}

	public void Fire()
	{
		if (CanFire())
		{
			OnFire();
			FXManager.instance.SpawnFX("ShotFX", child.transform.position, child.transform.rotation); // spawn visual fx when hit
			coolDown = 1.0f / fireRate;
		}
	}

	protected void DealDamage (Health health)
	{
		health.TakeDamage(damageAmount); // Deal damage

		if (!health.IsAlive()) // Check deat
		{
			Destroy(health.gameObject); // destroy object whose HP <= 0
		}
	}

	private bool CanFire()
	{
		return coolDown <= 0f;
	}
}*/