using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class LooseMenu : MonoBehaviour
{
	public TextMeshProUGUI HighScore;
	public TextMeshProUGUI Coins;
	public TextMeshProUGUI Stars;

	public void Start()
	{
		int highScore = PlayerPrefs.GetInt("HighScore", 0);
		HighScore.text = "High Score: " + highScore.ToString();

		int star = PlayerPrefs.GetInt("CurrentStars", 0);
		Stars.text = "Stars: " + star.ToString();

		int coin = PlayerPrefs.GetInt("CurrentCoins", 0);
		Coins.text = "Coins: " + coin.ToString();
	}

	public void RestartGame()
	{
		// game scene index is 1
		Debug.Log("clicked");
		SceneManager.LoadScene(1);
	}

	public void MainMenu()
	{
		Debug.Log("clicked");
		// main menu scene index is 0
		SceneManager.LoadScene(0);
	}

}
