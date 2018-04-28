using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cactus : MonoBehaviour {

	public float velocity;
	public float initialPosition, finalPosition;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		// Verify if reached the camera limit and reposition it for a new cicle.
		if (transform.position.x <= finalPosition)
		{
			Destroy (gameObject);
		}

		// Move background to the left side of screen.
		transform.Translate(Vector2.left * velocity * Time.deltaTime);
	}
}
