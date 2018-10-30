using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{


	public GameObject Player;
	public GameObject[] EnemyArr;

	int enemyCount;

	int playerDistanceIndex = -1;
	int enemyIndex = 0;
	int distanceToNext = 50;
	
	
	void Start ()
	{
		enemyCount = EnemyArr.Length; 
		InstantiateEnemy();
	}
	
	
	void Update ()
	{
		int playerDistance = (int)(Player.transform.position.y / (distanceToNext/2f));

		if (playerDistanceIndex != playerDistance)
		{
			InstantiateEnemy();
			playerDistanceIndex = playerDistance;
		}
	}

	public void InstantiateEnemy()
	{
		GameObject newEnemy = Instantiate(EnemyArr[0], new Vector3(0, enemyIndex * distanceToNext), Quaternion.identity);
		newEnemy.transform.SetParent(transform);
		enemyIndex++;
	}
}
