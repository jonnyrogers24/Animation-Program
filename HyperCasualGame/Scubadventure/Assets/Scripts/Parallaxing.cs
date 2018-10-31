using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallaxing : MonoBehaviour
{

	public Transform[] backgrounds;
	private float[] parallaxScales;
	public float smoothing = 1f;

	private Transform cam;
	private Vector3 previousCamPos;

	void Awake()
	{
		cam = Camera.main.transform;
	} 
	
	void Start ()
	{
		previousCamPos = cam.position;

		parallaxScales = new float[backgrounds.Length];

		for (int i = 0; i < backgrounds.Length; i++)
		{
			parallaxScales[i] = backgrounds[i].position.z * -1; 
		}
	}
	
	
	void Update () 
	{
		for (int i = 0; i < backgrounds.Length; i++)
		{
			float parallax = (previousCamPos.y - cam.position.y) * parallaxScales[i];

			float backgroundTargetPosY = backgrounds[i].position.y + parallax;

			Vector3 backgroundTargetPos = new Vector3(backgrounds[i].position.x, backgroundTargetPosY, backgrounds[i].position.z);
			
			backgrounds[i].position = Vector3.Lerp(backgrounds[i].position, backgroundTargetPos, smoothing * Time.deltaTime);
		}

		previousCamPos = cam.position;
	}
}
