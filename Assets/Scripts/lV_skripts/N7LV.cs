﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class N7LV : MonoBehaviour
{
	public GameObject[] Objects;
	public static bool win=false;
    void Start()
    {
		Player.LVNomber=7;
        StartCoroutine(Spawn1());
		StartCoroutine(Spawn2());
		StartCoroutine(Spawn3());
    }
			    void Update()
    { 
	if(Player.SCORE==50)
		{
		win=true;
		Player.matrix[4]=8;
		Objects[3].SetActive(true);
		}
	}
    IEnumerator Spawn1()//спаун голды
    {
        while (!Player.lose&&win==false)
        {
            Instantiate(Objects[0],new Vector2(Random.Range(-6.1f, 6f), 5.9f), Quaternion.identity);
            yield return new WaitForSeconds(0.8f);
        }
    }
			IEnumerator Spawn2()//спаун пираней
    {
		        while (!Player.lose&&win==false)
        {
	          Instantiate(Objects[1],new Vector2(6f, 3.28f), Quaternion.identity);
            yield return new WaitForSeconds(1.5f);
		}
	}
	IEnumerator Spawn3()//спаун черепах
    {
        while (!Player.lose)
        {
			Instantiate(Objects[2],new Vector2(6f, 3.28f), Quaternion.identity);
            yield return new WaitForSeconds(5f);
        }
    }
}
