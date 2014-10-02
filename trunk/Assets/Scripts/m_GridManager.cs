using UnityEngine;
using System.Collections;

public class m_GridManager : MonoBehaviour {

	public GameObject[] Hex;

	// Use this for initialization
	void Start () {
	
		Hex = GameObject.FindGameObjectsWithTag ("Hex");

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}