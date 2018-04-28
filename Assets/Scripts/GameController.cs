using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

	public static GameController instance;
	public Text scoreText;
	public bool gameOver = false;

	private int score = 0;

	void Awake () {
		if (instance == null) {
			instance = this;
		}
		else if (instance != this) {
			Destroy (gameObject);
		}
	}
	
	// Update is called once per frame
	void Update () {
	}

	public void PlayerDied() {
		SceneManager.LoadScene ("GameOver");
	}

	public void PlayerScored() {
		score++;
		scoreText.text = "Score: " + score.ToString();
	}
}
