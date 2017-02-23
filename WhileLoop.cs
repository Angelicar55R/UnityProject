using UnityEngine;
using System.Collections;

public class WhileLoop : MonoBehaviour {
	public int bottles = 0;
	public int maxBottles = 10;

	private bool gameOn = true;

	private int randomNum;
	private int minVal = -10;
	private int maxVal = 10;
	private int counter = 0;

	public int Target = 42;
	public int Max = 100;
	public int Min = 0;

	// Use this for initialization
	void Start (){
		//So with "While Loops" you use them to creat making a random guessing system, allowingthe block to guess until finally gets the correct number you are looking for. 
		//However using while loops incorrectly you can also create an "infinate loop" which will crash unity and not work.
		//So for your While Loop you will want to add a max and minumum number so the block will only  be able to choose from.

		int Counter = 0;

		while (true) {
			int Guess = Random.Range (Min, Max);
			Counter++;

			if (Guess == Target) {
				print ("Attempt " + Counter + " : You guessed the correct number, " + Target + ".");
				break;
			} else if (Guess < Target) {
				print ("Attempt " + Counter + ": " + Guess + " is to low.");
				Min = Guess;
			} else {
				print ("Attempt " + Counter + ": " + Guess + " is to high.");
				Max = Guess;
			}
		}
		print ("You win!");


		/*
		while (true)
		{
			randomNum = Random.Range (minVal, maxVal);
			if (randomNum > 0) {
				maxVal = randomNum;
			} else if (randomNum < 0) {
				minVal = randomNum;
			}

			counter++;
			print ("Attempt " + counter + " : " + minVal + " - " + maxVal);

			if (maxVal == 1 && minVal == -1)
			{
			break;
			}

		}
		*/
		/*
		while (gameOn == true) {
			print (bottles + " bottles of root beer on the wall.");
			bottles++;
			if (bottles == maxBottles) {
				gameOn = false;
			}
		}
		*/

		/*
		while (bottles < maxBottles) 
		{	
			if (bottles % 2 == 0) {
				print (bottles + " bottles of root beer on the wall. ");
			}
				bottles++;
		}
		print ("All done!");
		*/

	}
	
}
