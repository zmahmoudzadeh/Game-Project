using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(AudioSource))]
public class SimpleCollectibleScript : MonoBehaviour {

	public enum CollectibleTypes {Coin, Heart, Star, Type3, Type4, Type5}; // you can replace this with your own labels for the types of collectibles in your game!

	public CollectibleTypes CollectibleType; // this gameObject's type

	public bool rotate; // do you want it to rotate?

	public float rotationSpeed;

	public AudioClip collectSound;

	public GameObject collectEffect;

	public EventSystemCustom eventSystem;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (rotate)
			transform.Rotate (Vector3.up * rotationSpeed * Time.deltaTime, Space.World);

	}

	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Ball") {
			Collect ();
		}
	}

	public void Collect()
	{
		if(collectSound)
			AudioSource.PlayClipAtPoint(collectSound, transform.position);
        if (collectEffect)
            Instantiate(collectEffect, transform.position, Quaternion.identity);

        //Below is space to add in your code for what happens based on the collectible type

        if (CollectibleType == CollectibleTypes.Coin) {

            eventSystem.OnCoinIncrease.Invoke();

            Debug.Log ("Do Coin Command");
		}
		if (CollectibleType == CollectibleTypes.Heart) {

            eventSystem.OnHeartIncrease.Invoke();

            Debug.Log ("Do Coin Command");
		}
		if (CollectibleType == CollectibleTypes.Star) {

			//Add in code here;
			eventSystem.OnStarIncrease.Invoke();
			Debug.Log ("Do Coin Command");
		}
		if (CollectibleType == CollectibleTypes.Type3) {

			//Add in code here;

			Debug.Log ("Do Coin Command");
		}
		if (CollectibleType == CollectibleTypes.Type4) {

			//Add in code here;

			Debug.Log ("Do Coin Command");
		}
		if (CollectibleType == CollectibleTypes.Type5) {

			//Add in code here;

			Debug.Log ("Do Coin Command");
		}

		Destroy (gameObject);
	}
}
