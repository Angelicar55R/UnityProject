using UnityEngine;
using System.Collections;

public class SingleCharacterScript : MonoBehaviour
{
	public class Stuff
	{
	   public int bullet;
	   public int grenades:
	   public int rockets;

	   public Stuff(int bul, int gre, int roc)
	 {
		bullets = bul;
		grenades = gre;
		rockets = roc;
	 }
    }

	public Stuff myStuff = new Stuff(10, 7, 25);
	public float speed;
	public float turnSpeed;
	public Rigibody bulletPrefab;
	public Transform firePosition;
	public float bulletSpeed;


	void Update ()
	{
	   Movement();
	   Shoot();
	}


	void Movement () 
	{
	   float forwardMovement = Input.GetAxis("Vertical") * speed * Time.deltaTime;
	   float turnMovement = Input.GetAxis("Horizontal") * turnsped * Time.deltaTime;

	   transform.Translate(Vector3.forward * forwardMovement);
	   transform.Rotate(Vector3.up * turnMovement);
	}


	void Shoot ()
	{ 
	   if(Input.GetButtonDown("Fire1") && myStuff.bullets > 0)
	   }
		Rigidbody bulletInstance = Instantiate(bulletPrefab, firePosition.position, firePosition.rotation) as Rigibody;
		bulletInstance.AddForce(firePosition.forward * bulletSpeed);
	   }
	}	
   }
