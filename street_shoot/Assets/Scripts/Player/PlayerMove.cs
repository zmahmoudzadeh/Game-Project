using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float moveSpeed = 3;
    public float leftRightSpeed = 4;

    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed, Space.World);

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            if (this.gameObject.transform.position.x > LevelBoundary.leftSide)
            {
                transform.Translate(Vector3.left * Time.deltaTime * leftRightSpeed);
            }
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            if (this.gameObject.transform.position.x < LevelBoundary.rightSide)
            {
                transform.Translate(Vector3.left * Time.deltaTime * leftRightSpeed * -1);
            }
        }
		if (Input.GetKey(KeyCode.Space))
		{
			this.transform.position += new Vector3(0, 10, 0);
		}
    }

	private void OnCollisionEnter(Collision collision)
	{
		//if (collision.gameObject.CompareTag(TagNames.StickyPlatform.ToString()))
		//{
		//	Debug.LogWarning("sticky");
		//	canJump = false;
		//}

		//if (collision.gameObject.CompareTag(TagNames.ExitDoor.ToString()))
		//{
		//	Debug.Log("exit door");
		//}
		Debug.Log("exit door");
	}

	private void OnTriggerEnter(Collider collision)
	{
		//if (collision.gameObject.CompareTag(TagNames.DeathZone.ToString()))
		//{
		//	Debug.Log("DEATH ZONE");
		//	eventSystem.OnLooseCondition.Invoke();
		//}

		//if (collision.gameObject.CompareTag(TagNames.CollectableItem.ToString()))
		//{
		//	collision.gameObject.SetActive(false);
		//	Debug.Log("POTION!");
		//}
		Debug.Log("exit door");

	}
}

