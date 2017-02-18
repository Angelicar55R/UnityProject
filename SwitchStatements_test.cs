using UnityEngine;
using System.Collections;


public class SwitchStatements : MonoBehaviour 
{
	
private int time = 10;

	
private string animal = "alligatior";
	
private string phrase;
	
private bool exists = true;
	
private string Human = "Grim";
	
private string qoute;
	
private bool died = false;
	
private int toppings = 5;
	
private string Sharks = "Whale Shark";
	
private string fact;

private string chapStick = "Burt's Bees";
private string chartSpot;
private bool bias = false;
private string Food = "Chinese";
private string comment;

// Use this for initialization
	void Start () {
		

switch (animal) {
		
case "giraffe":
			
phrase = "Wheezy neighbaaahhh";
			
break;
		

case "penguin":
			
phrase = "Morgan Freeman";
			
break;
		

case "lion":
			
phrase = "roar";
			
break;
		

case "fox":
			
phrase = "asihetha;llkndfanklj";
			
break;
		

case "alligatior":
			
phrase = "\"Would you like some tea with that, sir?\"";
			
break;
		

default:
			
exists = false;
			
break;

		
}

		

if (exists == true) {
			
print ("A " + animal + " says \"" + phrase + "\". ");
		
} 
else 
{
			
print (animal + "does not exist.");
		
}


		

//Create a switch statement for time of day 
		
switch (time) {
		
case 9:
			
print ("Good Morning!");
			
print ("It's pleasantly brisk outside.");
			
break;
		

case 12:
			
print ("Lunch time!");
			
break;

		
case 18:
			
print ("Time to go home.");
			
break;
		

default:
			
print ("Get back to work!");
			
break;
		
}

		

/*A switch stament allows you to make a list of options with different actions/text, which can be switch up at anytime. 
		
*the other thing is it allows you to make a "default" statement if none of the options add up to the Switch statement.
		
*For all these different options/actions we call them a "Case" and you can add as many as you want.
		
*The "break;" is allways added on to the end of the case statement, without it the system will proceede to use the next case as it's answer if it has a break.
		
*/
		
		

//Here I'll be makeing some weird phrases characters could say in a game.
		
		
switch (Human) {
		
case "Grim":
			
qoute = "AWW shucks!";
			
break;
		

case "Matt":
			
qoute = "I don't need you help, I can hadle it on my own.";
			
break;
		

case "Pagie":
			
qoute = "I think it would be best if we could all get along.";
			
break;
		

case "Melody":
			
qoute = "Honestly guys just SHUT UP!";
			
break;
		

default:
			
died = false;
			
break;
	
	
}

		
if (died == false) {
			
print (Human + " says " + qoute + " . " );
		
}
else 

{			
print (Human + " is no longer alive. lol");
		
}		

//
			
switch (toppings) {
			
case 4:
				
print ("You can add one more topping to your pizza fam.");
				
break;
			
case 2: 
				
print ("Ah, the good o'l classic pinapple and ham combo. Noice!");
				
break;
			
case 6:
				
print ("Any extra toppings will cost 1.50, is that ok?");
				
break;
			
default:
				
print ("Perfect amount of toppings mate.");
				
break;
			
}

			

switch (Sharks){
			
case "Great White":
				
fact = "Adult White sharks can feed on small whales.";
				
break;
			

case "Zebra Shark":
				
fact = "This shark stips resemble a zebras when young, but as they become adults they become spotted.";

	
break;

case "Hammerhead Shark":
fact = "This shark can grow up to 20 feet.";
break;

case "Goblin Shark":
fact = "The goblin shark lives in the bottom of the ocean (aka guantanomo bay) as far as 3,940 feet.";
break;

defult:
print ("The Megolodon is a prehistroic shark that had the lenght of 40 to 70 feet!!! WOW now thats impressive!");
break;

switch (chapStick) {

case "Bert's Bees":
chartSpot = "Number One!";
break;

case "EOS":
chartSpot = "Number Two, like it's good but not the best.(I got this bomb as pack from costco once 10/10)";
break;

case "Aquaphor":
chartSpot = "Number Ten, because I'm bias and I've also never tried this brand.";
break;

case "Carmex":
chartSpot = "Number Three because it's an OG when I was a young lad.";
break;

case "Blistex":
chartSpot -"Number Two point Five, I got one that was pineapple mango, it was absolute bliss. Papa bless.";
break;

default:
bias = false;
break;
}
if (bias == false) {
print (chapStick + " is the best Chapstick" + chartSpot + " . ");
}
else
{
print ("I honestly don't know what's the best stick for chaped lips."
}

switch (Food) {
case "Mexican food"
comment = "The Chimichanga and Torta are a good option, can get enough of them.";
break;

case "Japanese food":
comment = "Sushi is amazing but not for everyone.";
break;

case "American food":
comment = "Five Guys burgers are a must to try at least once with cajun fries.":
break;

case "Italian food"
comment = "The Sause is what makes the meal.";
break;

case "Chinese"
comment = "Hands down the best. (for me)";
break;

defualt:
print ("Any food is good if it's edable.");
break;


	
	




		







}
	
	
}
}