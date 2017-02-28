using UnityEngine;
using System.Collections;

public class Arrays : MonoBehaviour {

	private string[] adj1 = { "Angery", "Hungry", "Worried", "Clumsy", "Gifted"};
	private string[] adj2 = {"Bitter", "Rotten", "Bitchy", "Embarrassed", "Eager"};
	private string[] verb = {"Alert", "Yell", "Damage", "Snap", "Eat"};
	private string[] noun = {"Demon", "Rowlet", "Raccon", "Cat", "Budgie"};
	private string[] Color = {"Red", "Mustered Yellow", "Blue", "Magenta", "Pink"};
	private string[] Proffession = { "Doctor", "Plumer", "Teacher", "Retail Worker", "Cashier"};
	private string[] personName = { "Mr.Tubster the thrid", "Carlos", "No eyed Joe", "Manny", "Banks"};
	private string[] Shape = {"Square", "Ovel", "Square", "Rectangle", "Circle"};
	private string[] Food = {"Chilly dogs", "Burgers", "Chicken", "Sandwitches", "Popcorn"};
	public int[] Numbers = {45, 30, 22 ,6, 8};
	
	// Use this for initialization
	void Start (){
		//Arrays allow us to make a full list of objects/numbers in a more condense line of code, then typing each element into its own small line.
		//There are some rules to haveing arrays, there is a lot of brackets you will need to place right.
		
		for (int i = 0; i < adj1.Length; i++){
		
		personName[Random.Range[(0, personName.Length)]
		print ("There was onece a wee lad name, " + personName + ".");
	
		adj1[Random.Range(0, adj1.Length)]
		print ("They tended to be a " + adj1 + " little chap, but they would try.");
		
		Shape[Random.Range(0, Shape.Length)]
		print ("One interesting fact was there eyes were shaped like " + Shape + " looking a bit like a cartoon character.");
		
		adj2[Random.Range(0, adj2.Length)]
		print ("And for this they felt " + adj2 + " to take on the world in their adventure.");
		
		noun[Random.Range(0, noun.Length)]
		print ("On this adventure they took their trusty partner, Pinecone the " + noun + " who had a bombing body, that Arnold Schwarzenegger would be envious.");
		
		verb[Random.Range(0, verb.Length)]
		print ("Both these buds wanted to " + verb + " , sense they have had a ruff day recently.");
		
		Proffession[Random.Range(0, Proffession.Length)]
		print ("The reason for this is, because our hero has a side job being, " + Proffession + " , although it can be shit sometimes, it pays the bills.");
		
		Food[Random.Range(0, Food.Length)]
		print ("The puls is they can feast on " + Food + " as much as they want.");
		
		Numbers[Random.Range(0, Numbers.Length)]
		print ("Maybe today they will get " + Numbers);
		
		Color[Random.Range(0, Color.Length)]
		print("After all that they get there " + Color + " blanket, and take a power nap on the couch.");
	

	
		}

	
	}
}
