using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour {
	public float speed;

	
void Start () {
		
speed = Random.Range (.2f, 2.0f);

	// This allows the cubes in uinty rotate at random times, not in unison.
}
		
	
// Update is called once per frame
	
	void Update () {
		
transform.Rotate (new Vector3 (15, 30, 45) * Time.deltaTime * speed);
	}
}



