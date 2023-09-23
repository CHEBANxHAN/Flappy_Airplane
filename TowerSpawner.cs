using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerSpawner : MonoBehaviour
{
    public GameObject Towers;
    void Start()
    {
        StartCoroutine(Spawner());
    }

    
    IEnumerator Spawner()
    {
        while (true)
        {
            yield return new WaitForSeconds(7);
            float rand = Random.Range(-1f, 4f);
            GameObject newTowers = Instantiate(Towers, new Vector3(2, rand, 0), Quaternion.identity);
            Destroy(newTowers, 14);
        }
    }
}
