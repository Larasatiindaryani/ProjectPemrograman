using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour {
	int score = 0;
	public Text scoreText;
	public Ball bola;
	public bool isLevel1;
	public Text winText;
	// Use this for initialization
	void Start () {
		winText.text = "";
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyUp (KeyCode.Escape)) {
			SceneManager.LoadScene ("MainMenu");
		}
		
	}
	public void intcrementScore(){
		score+=5;
		scoreText.text = "Score: " + score;
		if(isLevel1 == true){
			if (score >= 20) {
				bola.Reset ();
				SceneManager.LoadScene ("Level2");
			}
		}
		else{
			if (score >= 20){
				bola.Reset();
				winText.text = "YOU WIN";
			}
		}
		}
}