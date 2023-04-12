using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    private GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider other)
    {
        if (gameManager.lives > 0)
        {
            gameManager.AddLives(-1);
            Destroy(other.gameObject);
        }
        else 
        {

            gameObject.SetActive(false);
            Destroy(other.gameObject);
        }

    }
}
