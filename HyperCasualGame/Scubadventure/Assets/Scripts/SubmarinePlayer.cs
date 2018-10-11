using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubmarinePlayer : MonoBehaviour
{
	Rigidbody2D rb; 
	float angle = 0;
	
	public int xSpeed;
	public int ySpeed; 

	void Awake()
	{
		rb = GetComponent<Rigidbody2D>(); 
	}
	
	void Start () 
	{	
		
	}
	
	void Update ()
	{
		MovePlayer();
		GetInput();
	}

	void MovePlayer()
	{
		Vector2 pos = transform.position;
		pos.x = Mathf.Cos(angle)*xSpeed;
		//pos.y = 0;
		transform.position = pos;
		angle += Time.deltaTime * xSpeed; 
	}

	void GetInput()
	{
		if (Input.GetMouseButton(0))
		{
			
			rb.AddForce(new Vector2(0, ySpeed));
		}
		else
		{
			if (rb.velocity.y > 0)
			{
				rb.AddForce(new Vector2(0, -ySpeed));
			}
			else
			{
				rb.velocity = new Vector2(rb.velocity.x, 0);
			}
		}
	}
}
