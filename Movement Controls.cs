using UintyEngine;
using System.Collections;

public class MovementControls : MonoBehavior
{
	public float speed;
	public float turnspeed;


	void Update ()	
	{
	   Movement();
	}


	void Movement ()
	{	
	   float forwardMovement = Input.GetAxis("Vertical") * speed * Time.deltaTime;
	   float turnMovement = Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime;

	   transform.Translate(Vector3.up * turnMovement);
	}
}