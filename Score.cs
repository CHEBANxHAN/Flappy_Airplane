using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public int score;
    public Text scoreText;

    //void Start()
    //{
        //score = 0;
    //}

    void Update()
    {
        scoreText.text = score.ToString();
    }

    void Awake()
    {
        scoreText.text = PlayerPrefs.GetInt("scoretg").ToString();
    } 

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Score")
        {
            score = PlayerPrefs.GetInt("scoretg");
            PlayerPrefs.SetInt("scoretg", score + 1);
            scoreText.text = (score + 1).ToString();
            
        }
    }  
}
