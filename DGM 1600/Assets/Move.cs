using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {

	// Update is called once per frame
	
void Update () {
		
if (Input.GetKey (KeyCode.LeftArrow)) {
			
	gameObject.transform.Translate (-.2f, 0, 0);

		// this lets the sphere move to the left at a speed of -.2		
}
		
if (Input.GetKey (KeyCode.RightArrow)) {
			
	gameObject.transform.Translate (.2f, 0, 0);

		// this lets the sphere move to the right at the speed of .2	
}
		
if (Input.GetKey (KeyCode.UpArrow)) {
			
	gameObject.transform.Translate (0, .2f, 0);


		// this lets the sphere move up at the speed of .2
}
		
if (Input.GetKey (KeyCode.DownArrow)) {
			
	gameObject.transform.Translate (0, -.2f, 0);


		/* this lets the shpere move down at the speed of -.2
		 * side note: unity project files didn't update on gitKraken
		 * as expected will update as soon as possiable
		*/
}
		 
}

}