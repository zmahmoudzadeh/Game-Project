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

	//public void Update() // shouldn't be update
	//{
	//	int highScore = PlayerPrefs.GetInt("HighScore", 0);
	//	HighScore.text = "High Score: " + highScore.ToString();

	//	int coins = PlayerPrefs.GetInt("Coins", 0);
	//	Coins.text = "Coins: " + coins.ToString();
	//}
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
		// game scene index is 1
		SceneManager.LoadScene(0);
	}

	//public void QuitGame()
	//{
	//	Debug.Log("quit clicked");
	//	Application.Quit();
	//}
}
