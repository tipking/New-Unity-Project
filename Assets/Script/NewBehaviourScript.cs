using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class NewBehaviourScript : MonoBehaviour
{
	private float speed = 3.0f;
	public GameObject character;

	

	void Update()
	{

		if (Input.GetKey(KeyCode.D))
		{
			transform.position += Vector3.right * speed * Time.deltaTime;
		}

		if (Input.GetKey(KeyCode.E))
		{
			transform.position += Vector3.left * speed * Time.deltaTime;
		}

		if (Input.GetKey(KeyCode.A))
		{
			transform.position += Vector3.forward * speed * Time.deltaTime;
		}

		if (Input.GetKey(KeyCode.W))
		{
			transform.position += Vector3.back * speed * Time.deltaTime;
		}

		if (Input.GetKey(KeyCode.RightArrow))
		{
			transform.position += Vector3.right * speed * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.LeftArrow))
		{
			transform.position += Vector3.left * speed * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.UpArrow))
		{
			transform.position += Vector3.forward * speed * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.DownArrow))
		{
			transform.position += Vector3.back * speed * Time.deltaTime;
		}
	}

}