using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
	public Rigidbody2D rb;
	public float ballForce;
	bool gameStarted = false;
	public Transform parent;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyUp (KeyCode.Space) && gameStarted == false) {
			
		

			transform.SetParent (null);


			rb.isKinematic = false;
			rb.AddForce (new Vector2(ballForce, ballForce));
			gameStarted = true;

			
		}
	}
	public void Reset()
	{
		gameStarted = false;
		rb.isKinematic = true;
		transform.SetParent (parent);
		transform.localPosition = new Vector2 (0, -11f);
		rb.velocity = new Vector2 (0, 0);
	}

	private void OnCollisionEnter2D (Collision2D coll)
	{


		if (coll.gameObject.name == "Bawah") {
			Reset ();
		}
}
}