using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    private static GameManager instance;
    void Awake(){
        if(instance == null){
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else{
            Destroy(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Restart();
        nextLevel();
        if(SceneManager.GetActiveScene().name == "You Win"){
            Cursor.visible = true;
        }
        else{
            Cursor.visible = false;
        }
    }
    public void Restart(){
        if(Input.GetButtonDown("Restart")){
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            Player.coinCount = 0;
        }
        
    }
    private void nextLevel(){
        if(SceneManager.GetActiveScene().name ==  "Level 1" && Player.coinCount == 9){
            SceneManager.LoadScene("Level 2");
            Player.coinCount = 0;
        }
        else if(SceneManager.GetActiveScene().name == "Level 2" && Player.coinCount == 12){
            SceneManager.LoadScene("Level 3");
            Player.coinCount = 0;
        }
        else if(SceneManager.GetActiveScene().name == "Level 3" && Player.coinCount == 9){
            SceneManager.LoadScene("Level 4");
            Player.coinCount = 0;
        }
        else if(SceneManager.GetActiveScene().name == "Level 4" && Player.coinCount == 6){
            SceneManager.LoadScene("Level 5");
            Player.coinCount = 0;
        }
        else if(SceneManager.GetActiveScene().name == "Level 5" && Player.coinCount == 13){
            SceneManager.LoadScene("Level 6");
            Player.coinCount = 0;
        }
        else if (SceneManager.GetActiveScene().name == "Level 6" && Player.coinCount == 4){
            SceneManager.LoadScene("Level 7");
            Player.coinCount = 0;
        }
        else if(SceneManager.GetActiveScene().name == "Level 7" && Player.coinCount == 5){
            SceneManager.LoadScene("Level 8");
            Player.coinCount = 0;
        }
        else if(SceneManager.GetActiveScene().name == "Level 8" && Player.coinCount == 8){
            SceneManager.LoadScene("Level 9");
            Player.coinCount = 0;
        }
        else if(SceneManager.GetActiveScene().name == "Level 9" && Player.coinCount == 2){
            SceneManager.LoadScene("Level 10");
            Player.coinCount = 0;
        }
        else if(SceneManager.GetActiveScene().name == "Level 10" && Player.coinCount == 36){
            SceneManager.LoadScene("You Win");
            Player.coinCount = 0;
        }
    }
    public void playAgain(){
        SceneManager.LoadScene("Level 1");
        Player.coinCount = 0;
    }
}
