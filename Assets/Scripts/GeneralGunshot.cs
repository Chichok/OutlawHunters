using UnityEngine;
using System.Collections;
using System;

public class GeneralGunshot : MonoBehaviour 
{
	public float bulletSpeed = 70f;
	public Rigidbody2D projectile;
	public int GunShotLevel;
	
	//movement declaration
	public string fire;
	
	// Use this for initialization
	void Start () 
	{

	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetButtonDown(fire))
		{
			//bullet creation
			Rigidbody2D instantiateProjectile1 = Instantiate ( projectile, transform.position, transform.rotation ) as Rigidbody2D;
			Rigidbody2D instantiateProjectile2 = Instantiate ( projectile, transform.position, transform.rotation ) as Rigidbody2D;
			Rigidbody2D instantiateProjectile3 = Instantiate ( projectile, transform.position, transform.rotation ) as Rigidbody2D;

			//bullet fire
			instantiateProjectile1.velocity = transform.TransformDirection (new Vector3 ( 0, bulletSpeed, 0 ) );                            				//straight up
			instantiateProjectile2.velocity = transform.TransformDirection (new Vector3 ( bulletSpeed/2f, (1.4422f*bulletSpeed)/2, 0 ) );   				//30 degrees left
			instantiateProjectile3.velocity = transform.TransformDirection (new Vector3 ( -bulletSpeed/2f, (1.4422f*bulletSpeed)/2, 0 ) );  				//30 degress right

			if( GunShotLevel == 3 )
			{
				//bullet creation level 3
				Rigidbody2D instantiateProjectile4 = Instantiate ( projectile, transform.position, transform.rotation ) as Rigidbody2D;
				Rigidbody2D instantiateProjectile5 = Instantiate ( projectile, transform.position, transform.rotation ) as Rigidbody2D;

				//bullet fire level 3
				instantiateProjectile4.velocity = transform.TransformDirection (new Vector3 ( -(bulletSpeed*0.7422f)/2f, (bulletSpeed*2.4422f)/2f,  0 ) );		//15 degrees left
				instantiateProjectile5.velocity = transform.TransformDirection (new Vector3 ( (bulletSpeed*0.7422f)/2f, (bulletSpeed*2.4422f)/2f,  0 ) );  	 	//15 degress right
			}
		}

	}
}
