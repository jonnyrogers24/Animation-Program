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
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
	}
}
