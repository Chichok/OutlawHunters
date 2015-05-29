using UnityEngine;
using System.Collections;

public class BulletScript : MonoBehaviour 
{

	int timeOut = 100;

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{

		if( timeOut == 1 )
		{
			Destroy (gameObject);
		}
		timeOut--;
	}
}
