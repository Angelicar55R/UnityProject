using UnityEngine;
using System.Collections;


public class IfStatements : MonoBehaviour {
	

private int A = 10;
	
private int B = 3;
	
private string name = "Hope";
	
private bool awake = false;
	
private string eyeContact = "Hey dude!";
	
private bool bird = true;

private int L = 25;
private int H = 10;
private string Wave = "Good morning!"
private bool Money = false;	
/* 
	
 * ==
	
 * !=
	
 * <
	
 * >
	
 * <=
	
 * >=
	
 */


	
// Use this for initialization
	void Start () {
		
	if (awake != true) {
			
		print ("WAKE UP");
		
	}
		
	if (awake == true) {
			
		print ("Go to sleep!");
		
	}
		
	if (name != "Austin") {
			
		print(name);

	}		
	if (A == B) {
			
		print ("A is equal to B");
		
	}	
		
	if (A != B) {
			
		print ("A is not equal to B");
		
	}
		
	if (A < B) {
			
		print ("A is greater than B");
		
	}
		
	if (A > B) {
			
		print ("A is less than B");
		
	}
		
	if (A <= B) {
			
		print ("A is greater than/equal to B");
		
	}
		
	if (A >= B) {
			
		print ("A is less than/equal to B");


	//If statements are just set anwsers to the questions you make, like if I asked: is the earth flat? I could set up a statement for both the ture/false 
	responses and choose what I would like the anwser to look like. Say you choose true, the response I would give is "congratgulations!" and for false "Wrong".
	The other thing is it doesn't have to be only two responses, questions or equations. You can add as many as possible.	
	}

	if (A >= L) {
		print ("A is less than/equal to L");
	}
	if (H == A) {
		print ("H is equal to A");
	}
	if (Wave != "fist bumb") {
		print (Wave);
	}
	if (Wave == eyeContact) {
		print ("Hey dude! Good morning!")
	}

	//Wondering if I can combine two strings and make sentence.
	if (Wave == name) {
		print ("Good morning! Hope");
	}
	//In this statement, what I want to make happen is have two good chums exchange a greeting with no physical contact
, just a good "hey man" will do.		
	if (eyeContact != "Hand shake") {
		
		print (eyeContact);
	
	}
	//In this statement you if you respond true you will get approval from your friend.
	if (bird != false) {
		print ("I'm glad we share a common intrest mate, you really are a good friend.")
	}	
	//In this statement I am trying to make it clear that if you say false (or in this case no) that birds are not true (cool) then you get disapproveal from your friend. 
		
	if (bird == false) {
				
		print ("You just can't appreciate how cool birds are man.");

	}




	if (money == ture) {
		print("SCORE!");
	}
	if (money != true) { 
		print("No mate, I can't go out, Im piss poor.");
	}

						
		}
	
	}

}
