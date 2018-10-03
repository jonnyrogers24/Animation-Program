using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor: MonoBehaviour
{
	public ColorData SpriteColor; 
	private SpriteRenderer sRenderer;

	private void Start()
	{
		sRenderer = GetComponent<SpriteRenderer>();
		sRenderer.color = SpriteColor.Value;
	}

	private void OnTriggerEnter(Collider obj)
	{
		obj.GetComponent<SpriteRenderer>().color =
			SpriteColor.Value; 
	}
}
