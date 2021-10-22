using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Actions : MonoBehaviour {

	public GameObject mainmenu;
	public GameObject Levels;
	public GameObject options;
	public GameObject Howtoplay;
	public GameObject About;

	public Animator animator;

	void Start()
	{
		mainmenu.SetActive (true);
		Levels.SetActive (false);
	}

	public void levels()
	{
		mainmenu.SetActive (false);
		Levels.SetActive (true);
		animator.SetBool ("isinlevels", true);
	}
	public void Testscene()
	{
		SceneManager.LoadScene ("Test scene");
	}
		
	public void Back()
	{
		mainmenu.SetActive (true);
		Levels.SetActive (false);
		options.SetActive (false);
		About.SetActive (false);
		Howtoplay.SetActive (false);
		animator.SetBool ("isinlevels", false);
		animator.SetBool ("isinoptions", false);
		animator.SetBool ("isin HTP ABT", false);
	}
	public void Options()
	{
		mainmenu.SetActive (false);
		options.SetActive (true);
		animator.SetBool ("isinoptions", true);
	}

	public void HTP()
	{
		mainmenu.SetActive (false);
		Howtoplay.SetActive (true);
		animator.SetBool ("isin HTP ABT", true);
	}

	public void ABT()
	{
		mainmenu.SetActive (false);
		About.SetActive (true);
		animator.SetBool ("isin HTP ABT", true);
	}
		
	public void Quitgame ()
	{
		Debug.Log ("Quit!");
		Application.Quit ();
	}
}
