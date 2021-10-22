using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {

	public static bool IsPaused = false;

	public GameObject pausemenu;

	//public GameObject Tutorial;

	//public Scene mainmenu;

	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown(KeyCode.Escape)) 
		{
			if (IsPaused) {
				resume ();
				freezemouse ();
			} else 
			{
				pause ();
			}

		}
		
	}

	public void pause()
	{
		pausemenu.SetActive (true);
		Time.timeScale = 0f;
		IsPaused = true;
		Cursor.lockState = CursorLockMode.None;
		//Tutorial.SetActive (false);
	}

	public void resume()
	{
		pausemenu.SetActive (false);
		Time.timeScale = 1f;
		IsPaused = false;
		Cursor.lockState = CursorLockMode.Locked;
		//Tutorial.SetActive (true);
	}

	public void restart()
	{
		Time.timeScale = 1f;
		SceneManager.LoadScene (SceneManager.GetActiveScene().name);
		IsPaused = false;
	}

	public void Loadmenu()
	{
		Time.timeScale = 1f;
		SceneManager.LoadScene ("Menu");
		IsPaused = false;
	}

	public void Quitgame()
	{
		Debug.Log ("Quit");
		Quitgame ();
	}

	public void freezemouse()
	{
		Cursor.lockState = CursorLockMode.Locked;
	}
}
