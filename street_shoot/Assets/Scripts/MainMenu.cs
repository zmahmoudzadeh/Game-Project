using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class MainMenu : MonoBehaviour
{
	public TextMeshProUGUI HighScore;

	public void Update()
	{
		int highScore = PlayerPrefs.GetInt("HighScore", 0);
		HighScore.text = "High Score: " + highScore.ToString();
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
