using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseControl : MonoBehaviour {

	public float mousesensitivity = 100f;

	public Transform playerBody;
	public float clamp_x = -90;
	public float clamp_y = +30;
	//private float mouseX;
	//private float mouseY;

	float xrotation = 0f;

	// Use this for initialization
	void Start () 
	{
		Cursor.lockState = CursorLockMode.Locked;
	}

	// Update is called once per frame
	void Update () 
	{
		//this gets the position of the mouse and stores it
		float mouseX = Input.GetAxis ("Mouse X") * mousesensitivity * Time.deltaTime;
		float mouseY = Input.GetAxis ("Mouse Y") * mousesensitivity * Time.deltaTime;

		xrotation -= mouseY;
		xrotation = Mathf.Clamp (xrotation, -90, +90);//this is used to clamp down values

		transform.localRotation = Quaternion.Euler (xrotation, 0f, 0f);// this rotates the object according 

		playerBody.Rotate (Vector3.up * mouseX);//this is used to rotate the mouse left and right
	}




	/*
	// Update is called once per frame
	void Update ()
	{
		getmouseX_cordinates ();
	}

	private float getmouseX_cordinates()
	{
		//this gets the position of the mouse and stores it
		float mouseX = Input.GetAxis ("Mouse X") * mousesensitivity * Time.deltaTime;
		float mouseY = Input.GetAxis ("Mouse Y") * mousesensitivity * Time.deltaTime;
		LateUpdate(mouseX, mouseY);
		return mouseX ;
	}



	void LateUpdate (float mouseX, float mouseY) 
		{
		xrotation -= mouseY;
		xrotation = Mathf.Clamp (xrotation, clamp_x, clamp_y);//this is used to clamp down values

		transform.localRotation = Quaternion.Euler (xrotation, 0f, 0f);// this rotates the object according 

		playerBody.Rotate (Vector3.up * mouseX);//this is used to rotate the mouse left and right
		}
	*/


}
