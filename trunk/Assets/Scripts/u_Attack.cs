using UnityEngine;
using System.Collections;

public class u_Attack : MonoBehaviour
{
	void Start ()
	{
		f_UnitController myStats = GetComponent<f_UnitController> ();

		if (Random.Range (1, 7) >= 3)
		{
			//other.TakeDamage(myStats.myDamage);
			myStats.haveAttacked = true;
			Debug.Log("Damage taken");
		}
	}
}