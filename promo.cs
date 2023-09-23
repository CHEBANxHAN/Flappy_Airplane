using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class promo : MonoBehaviour
{
    public InputField promocode;
    public GameObject block;
    public GameObject Use;
    public GameObject Pr;
    private int access;

    void Awake()
    {
        AcUpdate();
    }
    
    void AcUpdate()
    {
        access = PlayerPrefs.GetInt("promo");
        
        if(access == 1)
        {
            Pr.SetActive(false);
            block.SetActive(false);
            Use.SetActive(true);
        }
    }
    
    public void Button_enter(string promocode)
    {
        if(access == 0)
            if(promocode == "Vadim_in_China")
            {
                PlayerPrefs.SetInt("promo", 1);
                AcUpdate();
            }
    }
}
