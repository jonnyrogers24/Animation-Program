﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubmarinePlayer : MonoBehaviour
{
	public Transform player; 
	public GameObject deathEffectObj;
	public GameObject scoreEffectObj;
	public float scrollSpeed = -1.5f; 
	
	Rigidbody2D rb; 
	float angle = 0;
	
	public int xSpeed;
	public int ySpeed;

	private GameManager gameManager;

	bool dead = false;

	float hueValue; 

	void Awake()
	{
		rb = GetComponent<Rigidbody2D>();
		gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();

	}
	
	void Start ()
	{
		
	//	hueValue = Random.Range(0, 10) / 10.0f;
	//	SetBackgroundColor();
	}
	
	void Update ()
	{
		if (dead == true) return;
	
		MovePlayer();
		GetInput();
		
		if(player.position.x < -1.00f)
		{
			

			FlipPlayerRight();

		}
		else if(player.position.x > 1.00f)
		{
			

			FlipPlayerLeft();

		}
	}

	void FlipPlayerRight()
	{
		transform.localScale = new Vector3(-.3f,.3f,.3f);
	}
	
	void FlipPlayerLeft()
	{
		transform.localScale = new Vector3(.3f,.3f,.3f);
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
				rb.AddForce(new Vector2(0, -ySpeed/2f));
			}
			else
			{
				rb.velocity = new Vector2(rb.velocity.x, 0);
			}
		}
	}


	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "JellyFish")
		{
			Dead();
		}
		else if (other.gameObject.tag == "Bubble")
		{
			GetBubble(other);
		}
		
	}

	void GetBubble(Collider2D other)
	{
		//SetBackgroundColor();
		
		Destroy(Instantiate(scoreEffectObj, other.gameObject.transform.position, Quaternion.identity), 0.7f);
		Destroy(other.gameObject.transform.parent.gameObject);
		gameManager.AddScore();
		GameManager.moneyAmount += 1;
		PlayerPrefs.GetInt("MoneyAmount", GameManager.moneyAmount);
	}

	void Dead()
	{
		dead = true;
		StartCoroutine(Camera.main.gameObject.GetComponent<ShakeCamera>().Shake());
		
		Destroy(Instantiate(deathEffectObj, transform.position, Quaternion.identity), 0.5f);

		StopPlayer();
		
		gameManager.CallGameOver();
	}

	void StopPlayer()
	{
		rb.velocity = new Vector2(0,0);
		rb.isKinematic = true; 
	}

	//void SetBackgroundColor()
	//{
	//	Camera.main.backgroundColor = Color.HSVToRGB(hueValue, 0.6f, 0.8f);

	//	hueValue += 0.1f;
	//	if (hueValue >= 1)
	//	{
	//		hueValue = 0;
	//	}
	//}
	public class instance
	{
		public static float scrollSpeed;
	}
}
