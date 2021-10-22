using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coltrolmovement : MonoBehaviour {
	 
	public CharacterController controller; 

	public float mvmtspeed = 12f;
	public float gravity = -10f;
	public float jumpheight = 3f;

	public Transform groundCheck;//this is used to get the position of the ground checking object
	public float groundDistance = 0.4f;
	public LayerMask groundMask;

	bool landed = false;
	bool playedlanded = false;

	Vector3 velocity;
	bool isgrounded;

	// Update is called once per frame
	void Update () 
	{

		isgrounded = Physics.CheckSphere (groundCheck.position, groundDistance, groundMask);

		if (isgrounded && velocity.y < 0) // checking the ground and velocity
		{
			velocity.y = -2f;
			landed = true;
		}

		float x = Input.GetAxis ("Horizontal");
		float z = Input.GetAxis ("Vertical");

		Vector3 move = transform.right * x + transform.forward * z; 

		controller.Move (move * mvmtspeed * Time.deltaTime);

		if (Input.GetButton ("Jump") && isgrounded) 
		{
			velocity.y = Mathf.Sqrt (jumpheight * -2f * gravity);
			FindObjectOfType<AudioManager> ().Play ("Jump");
			landed = false;
			playedlanded = false;
		}

		if (landed == true & playedlanded == false) 
		{
			playedlanded = true;
			FindObjectOfType<AudioManager> ().Play ("Land");
		}

		velocity.y += gravity * Time.deltaTime;

		controller.Move (velocity * Time.deltaTime);

		if (Input.GetKey (KeyCode.AltGr)) 
		{
			velocity.y += -gravity * Time.deltaTime;
		}

	}
}
