using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Draggable : MonoBehaviour{

	private Vector3 OffsetPosition;
	private Vector3 newPosition;
	private Camera cam;
	public bool CanDrag;
	 
	private void Start () {
		cam = Camera.main;		
	}

	private IEnumerator OnMouseDown()
	{
		OffsetPosition = transform.position - cam.ScreenToWorldPoint(Input.mousePosition); 
		yield return new WaitForFixedUpdate();
		CanDrag = true;
		while (CanDrag)
		{
			yield return new WaitForFixedUpdate();
			newPosition = cam.ScreenToWorldPoint(Input.mousePosition) + OffsetPosition;
			transform.position = newPosition; 
		}
	}
	
	private void OnMouseUp()
	{
		CanDrag = false; 
	}
}
