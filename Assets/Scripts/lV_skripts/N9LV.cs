﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class N9LV : MonoBehaviour
{
	public GameObject[] Objects;
	public Transform Point1,Point2;
    void Start()
    {
		Player.LVNomber=9;
        StartCoroutine(Spawn1());
		StartCoroutine(Spawn2());
		StartCoroutine(Spawn3());
    }
					    void Update()
    { 
	Player.gametime+=1*Time.deltaTime;
	if(Player.gametime > 50f && !Player.lose)
		{
		Player.win=true;
		if(Player.campaign<=9)
			{
		PlayerPrefs.SetInt("campaign",10);
			}
		Objects[3].SetActive(true);
		Objects[4].SetActive(true);
		}
	}

			IEnumerator Spawn1()//спаун пираней
    {
		        while (!Player.lose&&Player.win==false)
        {
	          Instantiate(Objects[0],new Vector2(Point2.position.x,Point2.position.y), Quaternion.identity);
            yield return new WaitForSeconds(2f);
		}
	}
	IEnumerator Spawn2()//спаун черепах
    {
        while (!Player.lose&&Player.win==false)
        {
			Instantiate(Objects[1],new Vector2(Point2.position.x,Point2.position.y), Quaternion.identity);
            yield return new WaitForSeconds(5f);
        }
    }
		IEnumerator Spawn3()//спаун новых черепах
    {
        while (!Player.lose&&Player.win==false)
        {
			Instantiate(Objects[2],new Vector2(Point2.position.x,Point2.position.y), Quaternion.identity);
            yield return new WaitForSeconds(6f);
        }
    }
}
