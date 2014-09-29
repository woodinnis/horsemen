/*using UnityEngine;
using System.Collections;

public class CamManager : MonoBehaviour
{
	[HideInInspector]
	public static CamManager instance; // static allows access from anywhere

	public float zoomFOV = 20.0f;
	private float defaultFOV;
	private bool zoomedIn;

	void Awake()
	{
		instance = this;
	}

	void Start()
	{
		defaultFOV = Camera.main.fieldOfView;
		zoomedIn = false;
	}

	public void ToggleZoom()
	{
		zoomedIn = !zoomedIn;

		if (zoomedIn)
		{
			Camera.main.fieldOfView = zoomFOV;
		}
		else
		{
			Camera.main.fieldOfView = defaultFOV;
		}
	}
}*/