using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour {

	private int time = 0;
	public Text timer;
	public string Stage;
	public string stagehighscore;
	public Text highscore;
	public bool istherehighscore = false;




	void Start () 
	{

		Stage = SceneManager.GetActiveScene ().name;


		if (PlayerPrefs.HasKey(Stage) == true) {
			stagehighscore = PlayerPrefs.GetInt(Stage, time).ToString();
		}
		else {
			stagehighscore = "No High Score";
		}

		highscore.text = "Stage Best: " + stagehighscore;
	}

	public void StartTimer () 
	{
		time = 0;
		InvokeRepeating("IncrimentTime", 1, 1); 
	}



	//starting the timer and stopping it
	public void StopTimerW()
	{
		CancelInvoke();
		if (PlayerPrefs.GetInt(Stage, time) > time)
		{
			SetHighscore();
			istherehighscore = true;
		}
		if (istherehighscore == false) 
		{
			SetHighscore();
		}
	}
	public void StopTimerL()
	{
		CancelInvoke();
	}





	public void SetHighscore () 
	{
		PlayerPrefs.SetInt(Stage, time);
		//PlayerPrefs.SetInt("Highscore" + Stage, time);
		stagehighscore = PlayerPrefs.GetInt(Stage, time).ToString();
		highscore.text = "Stage Best: " + stagehighscore;

	}

	public void ClearHighscores () 
	{
		PlayerPrefs.DeleteKey(Stage);
		highscore.text = "No High Score";
	}

	void IncrimentTime () 
	{
		time += 1;
		timer.text = "Time: " + time;
	}

	void Update ()
	{
		//highscore.text = "Stage Best: " + stagehighscore;
		Debug.Log (stagehighscore);
		Debug.Log (highscore);
		Debug.Log (Stage);
	}
}
