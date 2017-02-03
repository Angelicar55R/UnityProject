using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {

	// Update is called once per frame
	
void Update () {
		
if (Input.GetKey (KeyCode.LeftArrow)) {
			
	gameObject.transform.Translate (-.2f, 0, 0);

		//Int- you must have whole numbers, no fractions allowed or decimals. Bool- is used only for ture or false (saddly)		
}
		
if (Input.GetKey (KeyCode.RightArrow)) {
			
	gameObject.transform.Translate (.2f, 0, 0);

		//Float- you use numbers only and must have a decimal mark
}
		
if (Input.GetKey (KeyCode.UpArrow)) {
			
	gameObject.transform.Translate (0, .2f, 0);


		//Double- you must use numbers only and use decimal marks it exactly the same as a Float but this one is more accurtate in your equation.
}
		
if (Input.GetKey (KeyCode.DownArrow)) {
			
	gameObject.transform.Translate (0, -.2f, 0);


		//Sting- allows you to have either numerical or alphabetica characters in a group just like normal text. The only thing you must add is " quotation marks in the beginning and at the end of the text or number line.
		//Variable- gives Data types a more spesific meaning/name on what they control. Example: intAge = 20
		/* side note: unity project files didn't update on my gitKraken
		 * as expected will update as soon as possiable. 
		*/
}
		 
}

}