using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour {
	public GameObject subMenu;
	public Text tTitle;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
void Update () {
		
	}
	public void Play()
	{
		SceneManager.LoadScene (1);
	}
	public void SubMenu ()
	{
		if (subMenu.activeInHierarchy == false){
			
			subMenu.SetActive(true);
		}
		else{
			subMenu.SetActive(false);
		}
		}
	public void ExitGame()
	{
		Application.Quit ();
	}
}
