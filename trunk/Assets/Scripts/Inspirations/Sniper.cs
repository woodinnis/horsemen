/*using UnityEngine;
using System.Collections;

public class Sniper : Weapon
{
	public override void OnFire()
	{
		Transform cameraTransform = Camera.main.transform; // Access the camera currently being used (if only one is being used)
		Ray testRay = new Ray(cameraTransform.position, cameraTransform.forward); // Create a instant ray from the camera forward
		RaycastHit hitInfo = new RaycastHit(); // information of the ray cast
		if (Physics.Raycast(testRay, out hitInfo, range)) // if the ray cast hit something
		{
			Health health = hitInfo.transform.GetComponent<Health>(); // get the Health component
			if (health != null)
			{
				Vector3 pos = hitInfo.point;
				Quaternion rot = Quaternion.identity;
				FXManager.instance.SpawnFX(health.GetHitFX(), pos, rot); // spawn visual fx when hit
				
				// Apply damage
				DealDamage(health);
			}
		}
	}
	
	public override void Release() // Ignore
	{
	}
}*/