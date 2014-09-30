using UnityEngine;
using System.Collections;

public class f_UnitController : MonoBehaviour
{	
	public bool isSelected; // Am I selected right now?
	public bool haveAttacked; // Have I attacked this turn?
	public bool haveMoved; // Have I mode this turn?

	public int myDamage; // The damage this unit inflicts
	public int myDamageSplash; // Does the damage affect nearby tiles
	public int myAttackRange; // How many tiles far from its spot the unit can attack
	public int myMovement; // Tiles this unit can move

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
		//if (haveAttacked && haveMoved) -> unit turn end;
	}
}