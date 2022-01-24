using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MainMenu : MonoBehaviour
{
	public TextMeshProUGUI HighScore;
	public TextMeshProUGUI Coins;

	public void Update() // shouldn't be update
	{
		int highScore = PlayerPrefs.GetInt("HighScore", 0);
		HighScore.text = "High Score: " + highScore.ToString();

		int coins = PlayerPrefs.GetInt("Coins", 0);
		Coins.text = "Coins: " + coins.ToString();
	}

	public void PlayGame()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}

	public void QuitGame()
	{
		Debug.Log("quit clicked");
		Application.Quit();
	}
}
