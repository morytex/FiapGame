using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainControllerScript : MonoBehaviour {
	public bool gameStarted = false;

	// Use this for initialization
	void Start () {
		gameStarted = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (!gameStarted && Input.GetButtonDown ("Jump")) {
			gameStarted = true;
		}
	}
}
