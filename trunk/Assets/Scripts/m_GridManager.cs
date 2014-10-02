using UnityEngine;
using System.Collections;

public class m_GridManager : MonoBehaviour {

	[HideInInspector]
	public static m_GridManager instance;

	public GameObject[] HexList;

	// Use this for initialization
	void Awake () 
	{
		instance = this;
		HexList = GameObject.FindGameObjectsWithTag ("Hex");
	}
	/*
	// Update is called once per frame
	public GameObject HexStatus (string name) 
	{	
		foreach(GameObject Hex in HexList)
		{
			if(Hex.name == name)
			{

			}
		}
	}
	*/
}