using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowPlayer : MonoBehaviour
{

	public GameObject ScubaObj;
	public float smoothTime;
	Vector3 velocity = Vector3.zero;
	public int yOffset;



	void Update()
	{
		FollowScubaObj();
	}

	void FollowScubaObj()
	{
		Vector3 targetPostition = ScubaObj.transform.TransformPoint(new Vector3(0, yOffset, -10));
		targetPostition = new Vector3(0, targetPostition.y, targetPostition.z);

		transform.position = Vector3.SmoothDamp(transform.position, targetPostition, ref velocity, smoothTime);
	}
	
}
