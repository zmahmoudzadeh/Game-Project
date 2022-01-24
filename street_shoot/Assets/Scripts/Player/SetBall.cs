using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetBall : MonoBehaviour
{
	public GameObject[] Balls;
	public GameObject InstantiatedBall;
    // Start is called before the first frame update
    void Start()
    {
		string ballName = PlayerPrefs.GetString("CurrentBall", "Defaultball");
		Debug.Log(ballName);
		foreach(var ball in Balls)
		{
			var config = ball.GetComponent<PlayerMove>().config;
			Debug.Log("inside loop" + config.ballName);
			if (config.ballName == ballName)
			{
				InstantiatedBall = (GameObject) GameObject.Instantiate(ball, new Vector3(0f, 0.75f, 0f), Quaternion.identity);
				break;
			}
		}
	}

	// Update is called once per frame
	//void Update()
 //   {
        
 //   }
}
