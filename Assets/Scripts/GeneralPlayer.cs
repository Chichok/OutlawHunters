using UnityEngine;
using System.Collections;

public class GeneralPlayer : MonoBehaviour 
{
	//movement declaration
	public string moveXgrabber;
	public string moveYgrabber;
	
	//maxSpeed declaration
	public float maxspeed;
	public float moveX; //grabbing X directional input
	public float moveY; //grabbing Y directional input
	
	void Update () 
	{
		//----------------------------------------------------------------------------------------------movement and directional input
		if (Input.GetAxis (moveXgrabber) > .9)
			moveX = 1;
		else if (Input.GetAxis (moveXgrabber) < -.9)
			moveX = -1;
		else
			moveX = 0;

		if (Input.GetAxis (moveYgrabber) > .9)
			moveY = 1;
		else if (Input.GetAxis (moveYgrabber) < -.9)
			moveY = -1;
		else
			moveY = 0;

		//up and down movement
		GetComponent<Rigidbody2D> ().velocity = new Vector2 (GetComponent<Rigidbody2D> ().velocity.x, moveY * maxspeed);
		
		//left and right movement
		GetComponent<Rigidbody2D> ().velocity = new Vector2 (maxspeed * moveX, GetComponent<Rigidbody2D> ().velocity.y);
		//------------------------------------------------------------------------------------------end movement and directional input
	}
}
