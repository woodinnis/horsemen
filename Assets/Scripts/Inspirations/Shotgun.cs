/*using UnityEngine;
using System.Collections;

public class Shotgun : Weapon
{
	public int burstCount;
	public float spread;

	public override void OnFire()
	{
		Transform cameraTransform = Camera.main.transform; // Access the camera currently being used (if only one is being used)
		Vector3 rayOrigin = cameraTransform.position;

		for (int i = 0; i < burstCount; i ++)
		{
			Vector3 rayDirection = cameraTransform.forward;

			Quaternion horizontal = Quaternion.AngleAxis(
													Random.Range(-spread, spread),
													cameraTransform.up);

			Quaternion vertical = Quaternion.AngleAxis(
													Random.Range(-spread, spread),
													cameraTransform.right);

			rayDirection = horizontal * rayDirection;
			rayDirection = vertical * rayDirection;
			Ray testRay = new Ray(rayOrigin, rayDirection); // Create a instant ray from the camera forward
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
	}

	public override void Release() // Ignore
	{
		
	}
}*/