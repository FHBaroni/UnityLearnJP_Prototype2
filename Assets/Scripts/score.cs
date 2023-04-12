using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    private GameManager _object;
    private Text _text;
    // Start is called before the first frame update
    void Start()
    {
        _object = GameObject.Find("GameManager").GetComponent<GameManager>();
        _text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        _text.text = "Game over! \n Score: " + _object.score.ToString();
    }
}




   

   

