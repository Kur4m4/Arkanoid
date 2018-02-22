using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {

	public float velocidade;

	void FixedUpdate () {
		float move_x = Input.GetAxisRaw ("Horizontal");
		GetComponent<Rigidbody2D> ().velocity = new Vector2 (move_x, 0) * velocidade;
	}
}
