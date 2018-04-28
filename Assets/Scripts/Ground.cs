using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour {

	public float velocity;
	public float initialPosition, finalPosition;

	public GameObject cactusPrefab;
	public Transform cactusGenerator;

	void Start() {
	}

	// Update is called once per frame
	void Update()
	{
		// Verify if reached the camera limit and reposition it for a new cicle.
		if (transform.position.x <= finalPosition)
		{
			transform.position = new Vector2(initialPosition, transform.position.y);

			Instantiate (cactusPrefab, cactusGenerator.position, cactusGenerator.rotation);
		}

		// Move background to the left side of screen.
		transform.Translate(Vector2.left * velocity * Time.deltaTime);
	}
}
