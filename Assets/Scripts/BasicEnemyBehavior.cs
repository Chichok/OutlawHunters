using UnityEngine;
using System.Collections;

public class BasicEnemyBehavior : MonoBehaviour 
{
	public int EnemyHealth = 50;

	// Use this for initialization
	void Start () 
	{

	}

	void Update () 
	{
		if( EnemyHealth < 1 )
		{
			Destroy (gameObject);
		}
		print (EnemyHealth);
	}

	void OnTriggerEnter2D( Collider2D other )
	{
		//standing values
		if ( other.gameObject.tag == "BulletLevel1" )
		{
			EnemyHealth = EnemyHealth - 1;
		}
	}
}
