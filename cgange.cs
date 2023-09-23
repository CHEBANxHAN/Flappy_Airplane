using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cgange : MonoBehaviour
{
    public List<GameObject> character;
    private int characterId;
    public Vector3 position;
    public GameObject D1;
    public GameObject D2;
    public GameObject D3;
    public GameObject D4;

    void Awake()
    {
        characterId = PlayerPrefs.GetInt("character");
        Instantiate(character[characterId], position, Quaternion.identity);
        Destroy(D1);
        Destroy(D2);
        Destroy(D3);
        Destroy(D4);
    }
}
