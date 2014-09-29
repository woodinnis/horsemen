/*using UnityEngine;
using System.Collections;

public class AIController : MonoBehaviour
{
	// Perfect for turn-based games
	private enum State // saves string as numbers
	{
		Idle, // 0
		Chase, // 1
	}

	public float moveSpeed;
	public float turnSpeed;
	public float alertDistance;
	public float myDamage;
	//public float attackDistance;

	private State currentState;
	private Transform myTransform;
	private Transform myTarget;

	private float distance;

	void Start()
	{
		myTransform = transform;
		currentState = State.Idle;
	}

	void Update()
	{
		UpdatePerception();
			UpdateFSM();
	}

	private void UpdatePerception()
	{
		GameObject player = GameObject.FindGameObjectWithTag("Player");
		distance = Vector3.Distance(myTransform.position, player.transform.position);

		if (distance < alertDistance)
		{
			myTarget = player.transform;
		}
		else
		{
			myTarget = null;
		}
	}

	private void UpdateFSM()
	{
		switch (currentState)
		{
		case State.Idle:
			UpdateIdle();
			break;
		case State.Chase:
			UpdateChase();
			break;
		}
	}

	private void UpdateIdle() // Does it thing + Check for condition
	{
		myTransform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);

		if (myTarget != null)
		{
			// put any sound here, example: battle cry
			currentState = State.Chase;
		}
	}

	private void UpdateChase()
	{
		if (myTarget == null)
		{
			currentState = State.Idle;
		}
		// else if myTarget in range, attack
		else
		{
			// rotation (look at target)
			Vector3 meToTarget = myTarget.position - myTransform.position;
			Vector3 dirToTarget = new Vector3(meToTarget.x, 0f, meToTarget.z);
			Quaternion startRot = myTransform.rotation;
			Quaternion finalRot = Quaternion.LookRotation(dirToTarget, Vector3.up);
			myTransform.rotation = Quaternion.RotateTowards(startRot, finalRot, turnSpeed * Time.deltaTime);

			// movement (move towards target)
			Vector3 startPos = myTransform.position;
			Vector3 finalPos = myTarget.position;
			myTransform.position = Vector3.MoveTowards(startPos, finalPos, moveSpeed * Time.deltaTime);

		}
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Player"))
		{
			Health health = other.transform.GetComponent<Health>();
			health.TakeDamage(myDamage);
		}
	}
}*/