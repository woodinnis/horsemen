/*using UnityEngine;
using System.Collections;

public class WeaponManager : MonoBehaviour
{
	// Singleton pattern
	[HideInInspector]
	public static WeaponManager instance;

	public GameObject[] wpnList;

	void Awake()
	{
		instance = this; // Make instance be myself
	}

	public GameObject RequestWpn(string name)
	{
		foreach (GameObject wpn in wpnList) // each object on the array, giving the name fx to the current one
		{
			if (wpn.name == name)
			{
				GameObject newWpn = Instantiate(wpn) as GameObject; // (GameObject)Instantiate(fx)
				return newWpn;
			}
		}
		
		Debug.Log ("Wpn: " + name + " not found.");
		return null;
	}
}*/