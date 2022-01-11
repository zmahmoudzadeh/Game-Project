using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPlatform : MonoBehaviour
{
	public GameObject camera;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		float camera_pos = camera.transform.position.z;
		if (transform.position.z < camera_pos - 10)
		{
			Destroy(gameObject);
		}
    }
}
