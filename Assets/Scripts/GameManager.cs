using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int score = 0;
    public int lives = 3;
    public Text gameOver;
  
    // Start is called before the first frame update
    void Start()
    {
        gameOver.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void AddLives(int value)
    {
        lives += value;
        if (lives <= 0)
        {
            Debug.Log("Game Over!  | Score: " + score);
            gameOver.enabled = true;            
            gameObject.SetActive(false);
            Invoke("ReloadScene", 2); 
        }
        else
        {
            Debug.Log("Lives = " + lives);
        }
    }
    public void AddScore(int value)
    {
        score += value;
        Debug.Log("Score = " + score);
    }

    //StartCoroutine(PowerupCountdownRoutine());
    void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}
