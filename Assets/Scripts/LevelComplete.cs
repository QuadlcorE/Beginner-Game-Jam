using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelComplete : MonoBehaviour {

	public GameObject levelcomplete;

	public GameObject player;

	public GameObject playerFPScam;

	public GameObject sceneCamera;

	public GameObject botrenderer;

	public GameObject Physicsbotrenderer;

	public CharacterController playercharacter;

	public Canvas cnvass;

	public GameObject endflames;

	public GameObject Tutorial;

	void OnTriggerEnter ()
	{
		levelcomplete.SetActive (true);
		//Time.timeScale = 0.3f;
		Cursor.lockState = CursorLockMode.None;
		(player.GetComponent (typeof(Coltrolmovement)) as Coltrolmovement).enabled = false;
		playercharacter.enabled = false;
		botrenderer.SetActive (false);
		Physicsbotrenderer.SetActive (true);
		(cnvass.GetComponent (typeof(PauseMenu)) as PauseMenu).enabled = false;
		playerFPScam.SetActive (false);
		sceneCamera.SetActive (true);
		endflames.SetActive (true);
		Tutorial.SetActive (false);
		FindObjectOfType<Timer> ().StopTimerW();
	}
}
