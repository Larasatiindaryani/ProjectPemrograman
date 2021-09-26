using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Brick : MonoBehaviour {
	public UIManager UI;

	// Use this for initialization
	void Start () {
		UI = GameObject.FindWithTag("UI").GetComponent<UIManager>();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter2D(Collision2D col){

		if (col.gameObject.tag == "Ball") {
			
		Destroy (gameObject);

			UI.intcrementScore ();



		}
}
}

