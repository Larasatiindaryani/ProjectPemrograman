using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    Rigidbody2D rb;
    Animator anim;
    bool facingRight = true;
    float velX, speed = 2f;
public float jumpValue;
public Text PlayerKalah;
public Text winText;
public Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene("Main Menu");
        }
        if (Input.GetKey("r"))
        {
            SceneManager.LoadScene("Gameplay");
        }
        if (Input.GetKey (KeyCode.LeftShift))
        speed = 5f;
        else
        speed = 2f;
        if (Input.GetButtonDown("Jump") & rb.velocity.y == 0)
        rb.AddForce (Vector2.up * jumpValue);
        AnimationState();
        velX = Input.GetAxisRaw ("Horizontal") * speed;
    
    }
    void FixedUpdate(){
        rb.velocity = new Vector2 (velX, rb.velocity.y);
    }
    void LateUpdate(){
        CheckWhereToFace();
    }
    void CheckWhereToFace()
    {
        Vector3 localScale = transform.localScale;
        if (velX > 0)
        {
            facingRight = true;
        } else if (velX < 0){
            facingRight = false;
        }
        if (((facingRight) & (localScale.x < 0))||(!facingRight)&(localScale.x>0))
        {
            localScale.x *= -1;
        }
        transform.localScale = localScale;
    }
    void AnimationState()
    {
        if (velX == 0){
            anim.SetBool("isWalking", false);
            anim.SetBool("isRunning", false);
           
        }
        if (rb.velocity.y == 0){
            anim.SetBool ("isJumping",false);
            anim.SetBool ("isFalling",false);
        }
        if (Mathf.Abs(velX)==2 & rb.velocity.y == 0)
        anim.SetBool ("isWalking", true);
        if (Mathf.Abs(velX)==5 & rb.velocity.y ==0)
        anim.SetBool ("isRunning", true);
        else
        anim.SetBool ("isRunning", false);
        if (Input.GetKey(KeyCode.DownArrow)& Mathf.Abs(velX)==5)
        anim.SetBool ("isSliding", true);
        else
         anim.SetBool ("isSliding", false);
         if (rb.velocity.y > 0)
         anim.SetBool ("isJumping", false);
         anim.SetBool ("isFalling", false);
    }
    void OnCollisionEnter2D (Collision2D col){
        if(col.gameObject.CompareTag("BatasBawah")){
            Debug.Log (col);
            PlayerKalah.text = "Player Kalah";
        }
//void intcrementScore(){
    //scoreText.text = "Score: " + score;
    
//}
    }
}


