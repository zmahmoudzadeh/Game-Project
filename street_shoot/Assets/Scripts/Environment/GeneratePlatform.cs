using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratePlatform : MonoBehaviour
{
	//	public GameObject[] section;
	public float streetZ = 18;
	private bool creatingSection = false;
	public GameObject Street;
	public GameObject Star;
	//	public GameObject Coin;
	public GameObject[] HeartOrCoin;
	public GameObject[] Car;
	private float[] lineX = { -10.5f, -3.5f, 3.5f, 10.5f };
	private float objectX;
	private int randomCombo;
	private int randomX1;
	private int randomX2;
	private int randomX3;
	private int randomCar;
	private int randomCoin;
	//	private int lineCount;


	//	public GameObject Street;
	//	public GameObject Street;

	void Update()
	{
		if (creatingSection == false)
		{
			creatingSection = true;
			StartCoroutine(GenerateSection());
		}
	}

	IEnumerator GenerateSection()
	{
		
		
		randomX1 = Random.Range(0, 5);
		randomX2 = Random.Range(0, 5);
		randomX3 = Random.Range(0, 5);
		
		//	lineCount = Random.Range(1, 3);

		//if(lineCount == 1)
        //{

        //}
		//Instantiate(section[secNum], new Vector3(0, 0, zPos), Quaternion.identity);
		Instantiate(Street, new Vector3(0, 0, streetZ), Quaternion.identity);

		InstantiateRandomly(randomX1);

		if (randomX2 != randomX1)
		{
			InstantiateRandomly(randomX2);
		}

		if (randomX3 != randomX1 & randomX3 != randomX2)
		{
			InstantiateRandomly(randomX3);
		}

		streetZ += 18;
		yield return new WaitForSeconds(1f); //remember! adjust with ball speed
		creatingSection = false;
	}

	void InstantiateRandomly(int randomX)
    {
		randomCombo = Random.Range(0, 100);
		randomCar = Random.Range(0, 8);
		randomCoin = Random.Range(0, 2);
		// lineCount = Random.Range(1, 3);
		switch (randomX)
		{
			case 1:
				objectX = -10.5f;
				break;
			case 2:
				objectX = -3.5f;
				break;
			case 3:
				objectX = 3.5f;
				break;
			case 4:
				objectX = 10.5f;
				break;
		}
		if (randomCombo <= 40)
		{
			Instantiate(Star, new Vector3(objectX, 1.2f, streetZ), Quaternion.identity);
		}
		else
		{
			if (randomCombo <= 90)
			{
				Instantiate(Car[randomCar], new Vector3(objectX, 0, streetZ), Quaternion.identity);
			}
			else
			{
				Instantiate(HeartOrCoin[randomCoin], new Vector3(objectX, 1, streetZ), Quaternion.identity);
			}

		}
	}
}
