using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {

	public float velocidade;
	public float impulso;

	public Transform chaoVerificador;
	bool estaoNoChao;

	Rigidbody2D rb;
	Animator animator;

	void Start () {
		// Interface para os componentes
		rb = GetComponent<Rigidbody2D> ();
		animator = GetComponent<Animator>();
	}

	void Update () {

		// Verificar colisao com o piso
		estaoNoChao = Physics2D.Linecast(transform.position, 
			chaoVerificador.position, 1 << LayerMask.NameToLayer("Ground"));

		// Pulo
		if (Input.GetButtonDown ("Jump") && estaoNoChao) {
			rb.velocity = new Vector2 (0.0f, impulso); 
		}

		// Animacoes
		animator.SetBool("pJump", !estaoNoChao);
	}
}
