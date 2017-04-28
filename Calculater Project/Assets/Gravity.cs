using UnityEngine;
using System.Collections;

public class Gravity : MonoBehaviour {
	public float fallSpeed = 50.0f;


	// Use this for initialization
	void Update () {
		transform.Translate (Vector3.down * fallSpeed * Time.deltaTime, Space.World);
	}
}
