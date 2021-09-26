using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {
	public Rigidbody2D rb;
	public float kecepatan;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float x = Input.GetAxis ("Horizontal");
		if (x < 0) {
			MoveLeft ();
		}
		if (x > 0) {
			MoveRight ();
		}
		if( x == 0){
			Stop ();}
	}
	void MoveLeft(){
		rb.velocity = new Vector2 (-kecepatan,0);
	}
	void MoveRight(){
		rb.velocity = new Vector2 (kecepatan,0);
	}
		void Stop(){
		rb.velocity = Vector2.zero;
	}

}
