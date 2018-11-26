using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{


	public GameObject Player;
	public GameObject[] EnemiesArr;

	int enemyCount;

	int playerDistanceIndex = -1;
	int enemyIndex = 0;
	int distanceToNext = 30;
	
	
	void Start ()
	{
		enemyCount = EnemiesArr.Length; 
		InstantiateEnemy();
	}
	
	
	void Update ()
	{
		int PlayerDistance = (int)(Player.transform.position.y / (distanceToNext/2f));

		if (playerDistanceIndex != PlayerDistance)
		{
			InstantiateEnemy();
			playerDistanceIndex = PlayerDistance;
		}
	}

	public void InstantiateEnemy()
	{
		int randomInt = Random.Range(0, enemyCount);
		GameObject newEnemy = Instantiate(EnemiesArr[randomInt], new Vector3(0, enemyIndex * distanceToNext), Quaternion.identity);
		newEnemy.transform.SetParent(transform);
		enemyIndex++;
	}
}
