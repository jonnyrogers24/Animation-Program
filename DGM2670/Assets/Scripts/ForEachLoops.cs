using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class ForEachLoops : ScriptableObject
{
	public FloatData RandomSpeed;
	
	public List<FloatData> SpeedOptions;

	private void OnEnable()
	{
		var randomNum = Random.Range(0, SpeedOptions.Count - 1);

		for (int i = 0; i <SpeedOptions.Count - 1; i++)
		{
			if (i == randomNum)
			{
				RandomSpeed = SpeedOptions[i];
			}
		}
	}
	
}
