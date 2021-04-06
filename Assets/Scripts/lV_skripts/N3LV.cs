using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class N3LV : MonoBehaviour
{
	public GameObject[] Objects;
	public Transform Point1,Point2;
	public bool turels=false;
    void Start()
    {
		Player.LVNomber=3;
        StartCoroutine(Spawn1());
    }

				  void Update()
    { 
	Player.gametime+=1*Time.deltaTime;
		if(Player.gametime > 15f && turels==false)
		{
			turels=true;
			StartCoroutine(Spawn2());
		}
	if( Player.gametime > 50f && !Player.lose)
		{
		Player.BossFight=true;
		}
			if(Player.win==true)
		{
			Objects[3].SetActive(true);
			if (Player.campaign<=3)
			{
		PlayerPrefs.SetInt("campaign",4);
		}
		}
	}
	    IEnumerator Spawn1()//спаун метеоров
    {
        while (!Player.lose&& Player.BossFight==false&& Player.win==false)
        {
            Instantiate(Objects[0],new Vector2(Random.Range(Point1.position.x , Point2.position.x),Point1.position.y), Quaternion.identity);
            yield return new WaitForSeconds(0.8f);
        }
		if(Player.BossFight==true)
		{
		Objects[2].SetActive(true);
    }
    }
    IEnumerator Spawn2()//спаун турелей
    {
        while (!Player.lose&& Player.BossFight==false&& Player.win==false)
        {
			Instantiate(Objects[1],new Vector2(Random.Range(Point1.position.x , Point2.position.x),Point1.position.y), Quaternion.identity);
            yield return new WaitForSeconds(4f);
        }
    }
}