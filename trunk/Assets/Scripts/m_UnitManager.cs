using UnityEngine;
using System.Collections;

public class m_UnitManager : MonoBehaviour
{
	[HideInInspector]
	public static m_UnitManager instance; // static allows access from anywhere
	
	void Awake()
	{
		instance = this;
	}
	
	void Start ()
	{
	
	}

	void Update ()
	{
	
	}

	void EndTurn() // Check to see if turn should be ended or not
	{

	}
}