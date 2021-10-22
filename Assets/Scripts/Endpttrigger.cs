/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Endpttrigger : MonoBehaviour {

	public GameManager gamemanager;

	void OnTriggerEnter()
	{
		gamemanager.Gameover ();
	}
}*/

using UnityEngine;

public class Endpttrigger : MonoBehaviour {

	public GameManager gameManager;

	public GameObject FPScamera;
	public GameObject thirdPcamera;

	void OnTriggerEnter ()
	{
		gameManager.Gameover ();
		FPScamera.SetActive (false);
		thirdPcamera.SetActive (true);
	}
}
