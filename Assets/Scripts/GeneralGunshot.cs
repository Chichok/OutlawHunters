using UnityEngine;
using System.Collections;

public class GeneralGunshot : MonoBehaviour 
{
	public float bulletSpeed = 70f;
	public Rigidbody2D projectile;
	
	//movement declaration
	public string fire;
	//int timeOut = 500;
	
	// Use this for initialization
	void Start () 
	{

	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetButtonDown(fire))
		{
			Rigidbody2D instantiateProjectile = Instantiate ( projectile, transform.position, transform.rotation ) as Rigidbody2D;
			
			instantiateProjectile.velocity = transform.TransformDirection (new Vector3 ( 0, bulletSpeed, 0 ) );
		}

	}
}
