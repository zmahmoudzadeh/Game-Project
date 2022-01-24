using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopMenu : MonoBehaviour
{
	public void Defaultball()
	{
		PlayerPrefs.SetString("CurrentBall", "Defaultball");
		Debug.Log("1");
	}

	public void Football()
	{
		PlayerPrefs.SetString("CurrentBall", "Football");
		Debug.Log("2");
	}

	public void Basketball()
	{
		PlayerPrefs.SetString("CurrentBall", "Basketball");
		Debug.Log("3");

	}

	public void Beachball()
	{
		PlayerPrefs.SetString("CurrentBall", "Beachball");
		Debug.Log("4");
	}
}
