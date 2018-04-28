using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundScript : MonoBehaviour {

	public float velocidade;
	public float posicaoInicial, posicaoFinal;

	void Start() {
	}

	// Update is called once per frame
	void Update()
	{
		// Verifica se atingiu o limite de camera e reposiciona para um novo ciclo.
		if (transform.position.x <= posicaoFinal)
		{
			transform.position = new Vector2(posicaoInicial, transform.position.y);
		}

		// Move o fundo para o lado esquerdo da tela.
		transform.Translate(Vector2.left * velocidade * Time.deltaTime);
	}
}
