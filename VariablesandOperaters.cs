using UnityEngine;
using System.Collections;

public class VariablesandOperaters : MonoBehaviour {
	private float pi = 3.1415f;
	private float radius = 3.536235f;
	private float length = 2.45f;
	private float width = 5.5f;
	private float height = 6.95f;
	private float Base = 8.35f;

	// Use this for initialization
	void Start () {
	//Finding the diameter of a circle
		float diameter = 2 * radius;
		print ("The diameter of the circle with radius " + radius + " is " + diameter);
    //Finding the circumference of a circle
		float circumference = 2 * pi * radius;
		print ("The circumfence of the circle " + radius + " is " + circumference );
	//Finding the area of the circle
		float area = pi * radius * radius;
		print ("The area of the circle " + pi + " is " + area);
	//Finding the volume of a sphere
		double volume = 1.3333 * pi * radius * radius * radius;
		print ("The volume of the sphere " + radius + " is " + volume);
	//Finding the perimeter of a rectangle 
		float perimeter = 2 * (length + width);
		print ("The perimeter of the rectangle " + 2 + " is " + perimeter);
	//Finding the area of a rectangle
		float recArea = width * length; 
		print ("The area of the rectangle is " + recArea);
	//Finding the area of a triangle
		double triArea = 0.5 * (Base * height);
		print ("The area of the rectangle " + 0.5 + " is " + triArea);

	}
}