using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Hello : MonoBehaviour {
	public string phrase = "Hello My name is Angelica";
	int time =10;

	// Use this for initialization
	void Start () {
		welcomePhrase ();
	}

	void welcomePhrase() {
		string welcome = phrase + time;
		print (phrase + ", it is " + time + ":00 o'clock am.");
			

	}
}
