using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleScript : MonoBehaviour {
	private void OnTriggerEnter2D(Collider2D other)
	{
		GameManager.moneyAmount += 1;
	}
}
