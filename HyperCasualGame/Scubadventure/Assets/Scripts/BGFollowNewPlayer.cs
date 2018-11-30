using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGFollowNewPlayer : MonoBehaviour {

	public GameObject NewCraft; 
	public float smoothTime;
	Vector3 velocity = Vector2.zero;
	public int yOffset;



	void Update()
	{	
		FollowNewCraft();
	}

	void FollowNewCraft()
	{
		Vector2 targetPostition = GameObject.FindGameObjectWithTag("Player").transform.TransformPoint(new Vector2(0, yOffset));
		targetPostition = new Vector3(0, targetPostition.y);

		transform.position = Vector3.SmoothDamp(transform.position, targetPostition, ref velocity, smoothTime);
	}
}
