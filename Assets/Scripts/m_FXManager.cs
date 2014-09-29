using UnityEngine;
using System.Collections;

public class m_FXManager : MonoBehaviour
{
	[HideInInspector]
	public static m_FXManager instance; // static allows access from anywhere

	public GameObject[] fxList;

	void Awake()
	{
		instance = this;
	}

	public GameObject SpawnFX(string name, Vector3 position, Quaternion rotation)
	{
		foreach (GameObject fx in fxList) // each object on the array, giving the name fx to the current one
		{
			if (fx.name == name)
			{
				GameObject newFX = Instantiate(fx, position, rotation) as GameObject; // (GameObject)Instantiate(fx)
				return newFX;
			}
		}

		Debug.Log ("fx: " + name + " not found.");
		return null;
	}
}
