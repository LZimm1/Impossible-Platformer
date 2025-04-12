using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField]
    private float moveForce=8;

    [SerializeField]
    private float jumpForce=12;

    [SerializeField]
    private Rigidbody2D mybody;

    private float movementX;

    private string Ground = "Ground";

    private string Obstacle = "Obstacle";

    private bool Jump;

    private bool onGround;

    private Vector3 tempPos;

    public static int coinCount = 0;

    private string Coin = "Coin";

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        playerMoveKeyBoard();
    }
    void Update(){
        PlayerJump();
        if(transform.position.x < -8.57){
            tempPos = transform.position;
            tempPos.x = -8.57f;
            transform.position = tempPos;

        }
        if(transform.position.x > 8.57){
            tempPos = transform.position;
            tempPos.x = 8.57f;
            transform.position = tempPos;
        }
    }
    void PlayerJump(){
        if(Input.GetButtonDown("Jump") && onGround){
            onGround = false;
            mybody.AddForce(new Vector2(0f,jumpForce), ForceMode2D.Impulse);
        }
    }
    void playerMoveKeyBoard(){
        movementX = Input.GetAxisRaw("Horizontal");

        transform.position += new Vector3(movementX, 0f, 0f) * Time.deltaTime * moveForce;
    }
    private void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.CompareTag(Ground)){
            onGround = true;
        }
        else if(collision.gameObject.CompareTag(Obstacle)){
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collider){
        if(collider.gameObject.CompareTag(Coin)){
            coinCount += 1;
        }
    }
}
