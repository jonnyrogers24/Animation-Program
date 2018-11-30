using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowNewPlayer : MonoBehaviour {


	public GameObject NewCraft;
	public float smoothTime;
	Vector3 velocity = Vector3.zero;
	public int yOffset;



	void Update()
	{
		FollowNewCraft();
	}

	void FollowNewCraft()
	{
		Vector3 targetPostition = GameObject.FindGameObjectWithTag("Player").transform.TransformPoint(new Vector3(0, yOffset, -10));
		targetPostition = new Vector3(0, targetPostition.y, targetPostition.z);

		transform.position = Vector3.SmoothDamp(transform.position, targetPostition, ref velocity, smoothTime);
	}
}
