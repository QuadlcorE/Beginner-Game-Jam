using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	public float restarttime = 2f;

	public GameObject gameovermenu;

	public GameObject player;

	public GameObject botrenderer;

	public GameObject Physicsbotrenderer;

	public CharacterController playercharacter;

	public Canvas cnvass;

	public GameObject Tutorial;


	//public GameObject levelcomplete;

	/*public void completelevel()
	{
		Debug.Log ("Level complete");
		levelcomplete.SetActive (true);
	}*/



	public void Gameover ()
	{
		Debug.Log ("GAME OVER");
		//Invoke("restart" , restarttime);
		Time.timeScale = 0.3f;
		gameovermenu.SetActive (true);
		Cursor.lockState = CursorLockMode.None;
		(player.GetComponent (typeof(Coltrolmovement)) as Coltrolmovement).enabled = false;
		playercharacter.enabled = false;
		botrenderer.SetActive (false);
		Physicsbotrenderer.SetActive (true);
		(cnvass.GetComponent (typeof(PauseMenu)) as PauseMenu).enabled = false;
		Tutorial.SetActive (false);
		FindObjectOfType<Timer> ().StopTimerL();
		//player.GetComponents<Coltrolmovement>(). = false;
	}

	void restart ()
	{
		Time.timeScale = 1f;
		SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
	}
}
