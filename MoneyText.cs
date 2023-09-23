using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyText : MonoBehaviour
{
    public int Coin;
    public Text text;
    void Start()
    {
        text = GetComponent<Text>();
        Coin = PlayerPrefs.GetInt("scoretg", Coin);
    }

    void Update()
    {
        text.text = Coin.ToString();
    }
}
