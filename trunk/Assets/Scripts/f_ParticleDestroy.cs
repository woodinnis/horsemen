using UnityEngine;
using System.Collections;

public class f_ParticleSuicide : MonoBehaviour
{
	private ParticleSystem myParticleSystem;

	void Start()
	{
		myParticleSystem = particleSystem;
	}

	void LateUpdate () 
	{
		if (!myParticleSystem.IsAlive())
			Destroy(gameObject);	
	}
}