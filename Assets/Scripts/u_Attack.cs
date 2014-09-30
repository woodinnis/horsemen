using UnityEngine;
using System.Collections;

public class u_Attack : MonoBehaviour
{
	void Start ()
	{
		if (Random.Range (1, 7) >= 3)
		{
			// other.TakeDamage(unit_dmg);
			//m_UnitManager.instance.iAttacked = true;
			Debug.Log("Damage taken");
		}
	}
}