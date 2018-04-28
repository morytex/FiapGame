using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Blink : MonoBehaviour {

	public float intervalo;

	// Use this for initialization
	IEnumerator Start () {
		GetComponent<SpriteRenderer> ().enabled = 
			!GetComponent<SpriteRenderer> ().enabled;
		yield return new WaitForSeconds(intervalo);
		StartCoroutine (Start ());
	}

	void Update () {
		if (Input.GetButtonDown ("Fire1") || Input.GetKeyDown(KeyCode.Return)) {
			SceneManager.LoadScene ("Main");
		}
	}
}
