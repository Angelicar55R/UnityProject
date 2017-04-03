using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class AFewFunctions : MonoBehaviour {
	public float num1 = 1.5f;
	public float num2 = 7.89f;
	public float num3 = 5.4f;
	public int maxValue = 20;
	public int minValue = 0;
	public float value1 = 5.61f;
	public float value2 = 8.34f;

	// Use this for initialization
	void Start () {
		randomNumberList ();
		ArraysNames ();
		
		//Function (num1, num2, num3);

		}
	
		
	void Function (float num1, float num2, float num3) {
			
		float Multiplication = num1 * num2 * num3;
		print ("The anwser to 1.5 * 7.89 * 5.4 = " + Multiplication);

	}

	void ArraysNames (){

		string[] Name = { "David", "Danny", "Shae", "Libby", "Ammy" };
		string[] Color = { "Purple", "Red", "Blue", "Green", "Yellow" };

		for (int i = 0; i < name.Length; i++) {
			print (Name [i] + "'s favorite color was " + Color [i] + " but now hes's to sad to care. ");
		}
	}

	public List<int> randomNumberList (){
			
		List<int> myList = new List <int> ();

		int randomNum = Random.Range (0, maxValue);

		for (int i = 0; i < maxValue; i++) {			
			myList.Add (randomNum);
		}
			return myList;
	}

	float Sums (float value1, float value2)
	{
		
		float sum;
		sum = value1 * value2;
		return sum;
	}
		
}