using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Breakscr : MonoBehaviour {

	public Animator Fallingplatform;

	void OnTriggerEnter()
	{
		Fallingplatform.SetBool ("Fall", true);
	}
}
