using UnityEngine;
using System.Collections;
using UnityEngine;

public class Collide : MonoBehaviour {

	void OnTriggerEnter (Collider other)
	{
		print (other.gameObject);
		Destroy (other.gameObject);
		GameEnd ();
	}

	void GameEnd ()

	{
		print("Game Over");
	
	}
}
