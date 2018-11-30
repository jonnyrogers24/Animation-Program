using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using UnityEngine;
using UnityEngine.UI; 
using UnityEngine.SceneManagement;
using TMPro; 

public class GameManager : MonoBehaviour
{

	public TextMeshProUGUI moneyText;
	public static int moneyAmount;
	private int isWaterCraftSold;
	public GameObject waterCraft;
	public GameObject player;
	public GameObject enemyManager;
	public GameObject enemyManager2;
	
	public GameObject GameOverPanel;
	public TextMeshProUGUI currentScoreText;
	public TextMeshProUGUI bestScoreText;
	
	int currentScore; 
	
	void Start ()
	{
		currentScore = 0;
		bestScoreText.text = PlayerPrefs.GetInt("BestScore", 0).ToString();
		SetScore();

		moneyAmount = PlayerPrefs.GetInt("MoneyAmount");
		isWaterCraftSold = PlayerPrefs.GetInt("IsWaterCraftSold");

		if (isWaterCraftSold == 1)
			waterCraft.SetActive(true);
		
		else
			waterCraft.SetActive(false);
		
		if (isWaterCraftSold == 1)
			player.SetActive(false);
		
		else
			player.SetActive(true);
		
		if (isWaterCraftSold == 1)
			enemyManager.SetActive(false);
		
		else
			enemyManager.SetActive(true);
		
		if (isWaterCraftSold == 1)
			enemyManager2.SetActive(true);
		
		else
			enemyManager2.SetActive(false);
			
	}	

	void Update ()
	{
		moneyText.text = "Bubbles: " + moneyAmount.ToString(); 
	}

	public void gotoShop()
	{
		PlayerPrefs.SetInt("MoneyAmount", moneyAmount);
		SceneManager.LoadScene("Shop");
	}

	public void CallGameOver()
	{
		StartCoroutine(GameOver());
	}

	IEnumerator GameOver()
	{
		yield return new WaitForSeconds(0.5f);
		GameOverPanel.SetActive(true);
		yield break; 
	}

	public void Restart()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}

	public void AddScore()
	{
		currentScore++;
		if (currentScore > PlayerPrefs.GetInt("BestScore", 0))
		{
			PlayerPrefs.GetInt("BestScore", currentScore);
			bestScoreText.text = currentScore.ToString(); 
		}
		SetScore();
	}

	void SetScore()
	{
		currentScoreText.text = currentScore.ToString();
	}
}
