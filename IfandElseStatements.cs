using UnityEngine;
using System.Collections;

public class IfandElseStatements : MonoBehaviour {
	private int time = 12;
	private float grade = 95;
	private bool applePie = false;
	private float clock = 9;
	private int toppings = 12;
	private double area = 6.35;
	private int score = 5;
	private bool globleWarming = true;

	// Use this for initialization
	void Start (){
		if (time < 12) {
			print ("Go morning!");
		} else if (time == 12) {
			print ("Lunch time!");
		} else {
			print ("Back to work slogother!");


		}
		if (grade > 90) {
			print ("A");
		} else if (grade > 80) {
			print ("B");


		/* "else if" statemanets let have two statements, one statement will be passed (wil be considered false) and immediatly jump 
		* to the other statement and use it as the output.
		* Another thing is by using "else if" statements allow you to change the outcome of the answer/line quite easily.
		* You can also use as many "else if" statements as you want.
		*/
		

		}
		if (clock >= 9) {
			print ("YOUR LATE!");
		} else if (clock < 9) {
			print ("You need to hurry!");

		}
		if (applePie == true) {
			print ("You got good taste on pie mate.");
		} else if (applePie == false) {
			print ("I thought you were different man.");

		}
		if (toppings > 6) {
			print ("Your exceeding your limit on toppings!");
		} else if (toppings > 4) {
			print ("You have an option to add 1 more topping if you want.");
		} else {
			print ("You have reached the limit.");

		}
		if (area == 5.25) {
			print ("Wrong!");
		} else if (area > 6.34) {
			print ("Close but not quite.");
		
		}
		if (score < 2) {
			print ("You Lose!");
		} else if (score > 3) {
			print ("Winner!!");
		
		}
		if (globleWarming == false) {
			print ("What is wrong with you!?");
		} else if (globleWarming == true) {
			print ("Love me some facts!");
		
		
			
		


			}
		}

	}