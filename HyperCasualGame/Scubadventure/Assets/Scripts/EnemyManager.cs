using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{


	public GameObject Player;
	public GameObject[] EnemiesArr;

	public int enemyCount;

	public int playerDistanceIndex;
	public int enemyIndex;
	public int distanceToNext;
	
	
	void Start ()
	{
		enemyCount = EnemiesArr.Length; 
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
		int randomInt = Random.Range(0, enemyCount);
		GameObject newEnemy = Instantiate(EnemiesArr[randomInt], new Vector3(0, enemyIndex * distanceToNext), Quaternion.identity);
		newEnemy.transform.SetParent(transform);
		enemyIndex++;
	}
}
