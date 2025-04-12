using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{

    [SerializeField]
    private float jumpForce=12f;
    
    [SerializeField]
    private Rigidbody2D mybody;

    private string obstacleFloor ="Obstacle Floor";
    private bool onFloor;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        obstacleMove();
    }
    void obstacleMove(){
        if(onFloor){
            mybody.AddForce(new Vector2(0f,jumpForce), ForceMode2D.Impulse);
            onFloor = false;
        }
    }
    
    private void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.CompareTag(obstacleFloor)){
            onFloor = true;
        }
    }
}
    
