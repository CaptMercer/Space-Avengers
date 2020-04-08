using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBombs : MonoBehaviour
{
    public GameObject bomb;

    void Start()
    {
        StartCoroutine(Spawn());
    }
    IEnumerator Spawn()
    {
        while (!Player.lose)
        {
            Instantiate(bomb,new Vector2(Random.Range(-6.1f, 6f), 5.9f), Quaternion.identity);
            yield return new WaitForSeconds(0.8f);
        }
    }
}
