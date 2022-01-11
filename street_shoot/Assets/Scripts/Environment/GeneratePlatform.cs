using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratePlatform : MonoBehaviour
{
	//public GameObject[] section;
	public float zPos = 40f;
	private bool creatingSection = false;
	public GameObject Street;


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
		//secNum = Random.Range(0, 10);
		//Instantiate(section[secNum], new Vector3(0, 0, zPos), Quaternion.identity);
		Instantiate(Street, new Vector3(0, 0, zPos), Quaternion.identity);


		zPos += 40;
		yield return new WaitForSeconds(3); //remember! adjust with ball speed
		creatingSection = false;
	}
}
