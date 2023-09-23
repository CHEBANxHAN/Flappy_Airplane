using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buy : MonoBehaviour
{
    public string objectName;
    public int price, access;
    public GameObject block;
    public GameObject btbuy;
    public Text objectPrice;
    public GameObject Use;

    void Awake() 
    {
        AccessUpdate();
    }

    void AccessUpdate()
    {
        access = PlayerPrefs.GetInt(objectName + "Access");
        objectPrice.text = price.ToString();

        if(access == 1) 
        {
            block.SetActive(false);
            objectPrice.gameObject.SetActive(false);
            btbuy.SetActive(false);
            Use.SetActive(true);

        }
    }

     public void OnButtonDown()
     {
        int coins = PlayerPrefs.GetInt("scoretg");

        if(access == 0)
        {
            if(coins >= price)
            {
                PlayerPrefs.SetInt(objectName + "Access", 1);
                PlayerPrefs.SetInt("scoretg", coins - price);
                AccessUpdate();
            }
        }
     }
}