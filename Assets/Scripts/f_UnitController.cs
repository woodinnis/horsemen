using UnityEngine;
using System.Collections;

public class f_UnitController : MonoBehaviour
{	
	public bool isSelected;
	public bool haveAttacked;
	public bool haveMoved;

	public int myDamage;
	public int myDamageSplash;
	public int myAttackRange;
	public int myMovement;

	void Update ()
	{
		if (Input.GetMouseButtonDown(0)) // Checks if the mouse left buttom was pressed
		{
			//Check Hex on NavMesh
				//if unit is selected -> click on empty = CheckMove / -> click on enemy = CheckAttack
				//if unit not selected -> click on empty = nothing / -> click on enemy = Info / -> click on ally = selected=true
		}
	}

	void CheckAttack()
	{
		// if distance between unit and enemy <= myAttackRange -> Attack; haveAttacked = true;

		EndTurn ();
	}

	void CheckMove ()
	{
		// if distance between unit and empty hex <= myMovement -> Move; haveMoved = true;

		EndTurn ();
	}

	void EndTurn() // Check to see if turn should be ended or not
	{
		//if (haveAttacked && haveMoved) -> unit turn end
	}
}