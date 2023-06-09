using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{

    private GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            gameManager.AddLives(-1);
            Destroy(gameObject);
        }
        else if (other.CompareTag("Animal") && gameManager.lives > 0)
        {
            gameManager.AddScore(15);
            other.GetComponent<AnimalHunger>().FeedAnimal(1);
            //Destroy(gameObject);
            gameObject.SetActive(false);
        }

    }
}
