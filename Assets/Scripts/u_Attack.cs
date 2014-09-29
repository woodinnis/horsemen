using UnityEngine;
using System.Collections;

public class u_Attack : MonoBehaviour
{
	public bool hit;

	void Start ()
	{
		if (Random.Range (1, 7) >= 3)
		{
			hit = true;
			// other.TakeDamage(weapon_dmg);
			hit = false;
			//m_UnitManager.instance.attacked = true;
		}
	}
}