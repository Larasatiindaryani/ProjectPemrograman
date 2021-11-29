using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coin : MonoBehaviour
{
    public Text menangText;
void OnCollisionEnter2D (Collision2D col){
    if ( col.gameObject.tag.Equals ("Player")){
        print ("coin diambil");
        Destroy (gameObject);
        CoinScore.hitungCoin += 50;
    }
    if (CoinScore.hitungCoin >= 50){
        Debug.Log("YOU WIN");
	    menangText.text = "YOU WIN";
    }
}
}
