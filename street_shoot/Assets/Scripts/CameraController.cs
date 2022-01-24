using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
	GameObject ball;
	float x;
	float y;
	//// Start is called before the first frame update
	void Start()
	{
		ball = GameObject.FindGameObjectWithTag("Ball");

		x = this.transform.position.x;
		y = this.transform.position.y;
	}

	// Update is called once per frame
	void Update()
	{		
		this.transform.position = new Vector3(x, y, ball.transform.position.z -10);
	}
}
