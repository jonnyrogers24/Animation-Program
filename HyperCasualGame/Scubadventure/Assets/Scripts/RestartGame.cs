using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour {

	public void restartGame()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 0);
	}

	public void exitGame()

	{
		PlayerPrefs.SetInt("MoneyAmount", GameManager.moneyAmount);
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
	
	}

	public void exitShop()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
	}
}
