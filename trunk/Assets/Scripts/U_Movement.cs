using UnityEngine;
using System.Collections;

public class U_Movement : MonoBehaviour {

	// Variables for checking valid hex locations
	bool boolIsEmpty = false;
	bool boolIsEnemy = false;
	bool boolIsAlly = false;

	// Variables for direction and movement
	int intMoveHexCount = 0;
	int intMoveHexDirection = 0;
	int intMoveHexRemaining = 0;
	string strCurrentHex;


	// Use this for initialization
	void Start () 
	{
		strCurrentHex = gameObject.GetComponent<"Hex_01">();
	}

	// Calculate unit movements
	void UnitMove()
	{}

	// Actions to perform on unit stop
	bool UnitStop()
	{}




}
