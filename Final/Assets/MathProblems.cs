using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;

public class MathProblems : MonoBehaviour {
	float num1 = 50.5f;
	float num2= 5.9f;
	float[] numbers = { 52f, 40f, 70f, 13f };

	// Use this for initialization
	void Start () {
		function(num1, num2);

		print(Average (numbers));


	}
	void function (float num1, float num2){
		float mutiply = num1 * num2;
		print ("The answer to 50.5 times 5.9 = " + mutiply);

		float addition = num1 + num2;
		print ("The answer to 50.5 plus 5.9 = " + addition);

		float subtract = num1 - num2;
		print ("The answer to 50.5 minus 5.9 = " + subtract);

		float divid = num1 / num2;
		print ("The anser to 50.5 divided by 5.9 = " + divid);
	}
		
		float Average (float[] numbers){
		float sum = 0;
		float mean;
		foreach (float thisnumbers in numbers) {
			sum += thisnumbers;
		}
		mean = sum / numbers.Length;
		return mean;


	
	}
} 