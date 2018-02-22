using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallScript : MonoBehaviour {

	Rigidbody2D rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
		MoveBall ();
	}

	// Update is called once per frame
	void Update () {
		if (GameObject.FindWithTag ("Brick") == null) {
			SceneManager.LoadScene ("Start");
		}
	}

	void MoveBall () {
		float rand = Random.Range (0, 2);
		if (rand > 0) {
			rb.AddForce (new Vector2 (20, 15), ForceMode2D.Force);
		} else {
			rb.AddForce (new Vector2 (-20, 15), ForceMode2D.Force);
		}
	}

	void OnCollisionEnter2D(Collision2D c) {
		if (c.gameObject.tag == "Brick") {
			Destroy (c.gameObject);
		}
	}

	void OnTriggerEnter2D (Collider2D c) {
		SceneManager.LoadScene ("Start");
	}
}
