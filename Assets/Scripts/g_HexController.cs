using UnityEngine;
using System.Collections;

public class g_HexController : MonoBehaviour
{
	public bool isEnemy; // My child is an enemy
	public bool isAlly; // My child is an ally
	public bool isEmpty; // I do not have a child

	public GameObject child; // If I do have a child, this is who it is

	void Start()
	{
		isEnemy = false;
		isAlly = false;
		isEmpty = true;
	}
}