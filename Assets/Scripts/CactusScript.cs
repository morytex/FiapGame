using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CactusScript : MonoBehaviour {

	public float velocity;
	public float initialPosition, finalPosition;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		// Verifica se atingiu o limite de camera e reposiciona para um novo ciclo.
		if (transform.position.x <= finalPosition)
		{
			Destroy (gameObject);
		}

		// Move o fundo para o lado esquerdo da tela.
		transform.Translate(Vector2.left * velocity * Time.deltaTime);
	}
}
