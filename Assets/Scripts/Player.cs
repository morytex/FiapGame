using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public float velocidade;
	public float impulso;

	public Transform chaoVerificador;
	bool onGround;

	Rigidbody2D rb;
	Animator animator;

	void Start () {
		// Component interfaces
		rb = GetComponent<Rigidbody2D> ();
		animator = GetComponent<Animator>();
	}

	void Update () {

		// Verify collision with the ground
		onGround = Physics2D.Linecast(transform.position, 
			chaoVerificador.position, 1 << LayerMask.NameToLayer("Ground"));

		// Jump
		if ((Input.GetButtonDown ("Jump") || Input.GetButtonDown ("Fire1")) && onGround) {
			rb.velocity = new Vector2 (0.0f, impulso); 
		}

		// Animations
		animator.SetBool("pJump", !onGround);
	}

	void OnCollisionEnter2D(Collision2D c) {
		if (c.gameObject.tag == "Obstacle") {
			GameController.instance.PlayerDied ();
		}
	}
}
