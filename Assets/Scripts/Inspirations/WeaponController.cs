/*using UnityEngine;
using System.Collections;

public class WeaponController : MonoBehaviour 
{
	public Transform handTransform;
	public string defaultWeapon;

	private Weapon currentWeapon;

	void Start () 
	{
		Screen.lockCursor = true;
		SwitchWeapon(defaultWeapon);
	}
	
	void Update () 
	{
		if (currentWeapon != null) // Check if there is a weapon
		{
			if (Input.GetButton("Fire1"))
			{
				currentWeapon.Fire(); // Fire weapon
			}

			if (Input.GetButtonUp("Fire1"))
			{
				currentWeapon.Release(); // Pistol only
			}

			if (Input.GetButtonDown("Fire2"))
			{
				if (currentWeapon.hasScope)
				{
					CamManager.instance.ToggleZoom();
				}
			}
		}
		if (Input.GetAxisRaw("Mouse ScrollWheel") > 0)
		{

		}
		else if (Input.GetAxisRaw("Mouse ScrollWheel") < 0)
		{

		}
	}

	void SwitchWeapon(string name)
	{
		if (currentWeapon != null) // release current weapon
		{
			currentWeapon.transform.parent = null;
			Destroy(currentWeapon.gameObject); // Destroy the component and the owner of it (the object)
		}

		GameObject weapon = WeaponManager.instance.RequestWpn (name); //Request for a new weapon
		if (weapon != null)
		{
			weapon.transform.parent = handTransform; // Hold it in hand 
			currentWeapon = weapon.GetComponent<Weapon>();
			weapon.transform.localPosition = Vector3.zero;
			weapon.transform.localRotation = Quaternion.identity;
		}
	}
}*/