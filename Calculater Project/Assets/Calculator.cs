using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using System;

public class Calculator : MonoBehaviour {
	public InputField field1;
	public InputField field2;
	float firstNum;
	float secondNum;

	// Use this for initialization
	public void Math (string operation) {

		float Answer;
		firstNum = int.Parse(field1.text);
		secondNum = int.Parse (field2.text);

		if (operation == "*") {
			Answer = firstNum * secondNum;
				print (firstNum + " *" + secondNum + " = " + Answer);
		} 
			else if (operation == "/") {
			Answer = firstNum / secondNum;
			print (firstNum + " / " + secondNum + " = " + Answer);
		} 
			else if (operation == "+") {
			Answer = firstNum + secondNum;
				print (firstNum + " + " + secondNum + " = " + Answer);
		} 
			else if (operation == "-") {
			Answer = firstNum - secondNum;
				print (firstNum + " - " + secondNum + " = " + Answer);
		}
			else 
		{
				print ("Error");
		}
		//int i = int32.Parse (textBox1.Text)
			
	}

}