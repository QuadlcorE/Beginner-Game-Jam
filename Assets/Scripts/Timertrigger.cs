using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timertrigger : MonoBehaviour {

	public GameObject Timers;

	void OnTriggerEnter ()
	{
		FindObjectOfType<Timer> ().StartTimer();
		Debug.Log ("triger");
	}
}
