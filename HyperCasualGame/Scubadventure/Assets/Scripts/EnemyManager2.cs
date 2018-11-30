using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager2 : MonoBehaviour {



	public GameObject NewCraft;
	public GameObject[] EnemiesArr;

	private int enemyCount;

	private int playerDistanceIndex = -1;
	private int enemyIndex = 0;
	public int distanceToNext = 30;
	
	
	void Start ()
	{
		enemyCount = EnemiesArr.Length; 
		InstantiateEnemy();
	}
	
	
	void Update ()
	{
		int playerDistance = (int)(NewCraft.transform.position.y / (distanceToNext/2f));

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
