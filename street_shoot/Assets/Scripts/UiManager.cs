using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UiManager : MonoBehaviour
{
    //public Text counterText;
    public EventSystemCustom eventSystem;

    public Text coin ;
    public Text heart;
    public Text star;



    void Start()
    {
        //eventSystem.OnCloneStickyPlatformEnter.AddListener(UpdateScoreText);
        eventSystem.OnHeartIncrease.AddListener(UpdateHeartText);
        eventSystem.OnHeartDecrease.AddListener(UpdateDecreaseHeartText);
        eventSystem.OnCoinIncrease.AddListener(UpdateCoinText);
        eventSystem.OnCoinDecrease.AddListener(UpdateDecreaseCoinText);
        eventSystem.OnStarIncrease.AddListener(UpdateStarText);
        eventSystem.OnStarDecrease.AddListener(UpdateDecreaseStarText);
        //coin.text = "Coin: " + 0;
        //star.text = "Star: " + 0;
        //heart.text = "Heart: " + 0;

    }

    //public void UpdateScoreText()
    //{
    //    Debug.Log("UPDATE SCORE");
    //    int newTextValue = int.Parse(counterText.text) + 1;
    //    counterText.text = newTextValue.ToString();
    //}

    public void UpdateCoinText()
    {
        int coinValue = int.Parse(coin.text.Split(':')[1]) + 1;
        Debug.Log("UPDATE Coin");
        coin.text = "Coin: " + coinValue.ToString();
    }


    public void UpdateStarText()
    {
        int starValue = int.Parse(star.text.Split(':')[1]) + 1;
        Debug.Log("UPDATE Star");
		UpdateHighScore(starValue); // call it on game loose? or in the middle of the game. 
        star.text = "Star: " + starValue.ToString();
    }

    public void UpdateHeartText()
    {
        int heartValue = int.Parse(heart.text.Split(':')[1]) + 1;
        Debug.Log("UPDATE Heart");
        heart.text = "Heart: " + heartValue.ToString();
    }

    public void UpdateDecreaseCoinText()
    {
        int coinValue = int.Parse(coin.text.Split(':')[1]) - 1;
        Debug.Log("UPDATE Coin");
        coin.text = "Coin: " + coinValue.ToString();
    }


    public void UpdateDecreaseStarText()
    {
        int starValue = int.Parse(star.text.Split(':')[1]) - 1;
        Debug.Log("UPDATE Star");
        star.text = "Star: " + starValue.ToString();
    }

    public void UpdateDecreaseHeartText()
    {
        int heartValue = int.Parse(heart.text.Split(':')[1]) - 1;
        Debug.Log("UPDATE Heart");
        heart.text = "Heart: " + heartValue.ToString();
    }

	public void UpdateHighScore(int current)
	{
		if (current > PlayerPrefs.GetInt("HighScore", 0))
		{
			PlayerPrefs.SetInt("HighScore", current);
		}
	}

}
