using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "FloatData")]
public class FloatData : ScriptableObject
{

	public float value;

	public float Value
	{
		get
		{
			return value; 
			
		}
	}
}
