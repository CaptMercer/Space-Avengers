using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class N4LV : MonoBehaviour
{
	public GameObject[] Objects;
	public Transform Point1,Point2;
		public bool pirahs=false;
    void Start()
    {
		Player.LVNomber=4;
        StartCoroutine(Spawn1());
		
    }
		    void Update()
    { 
	Player.gametime+=1*Time.deltaTime;
		if(Player.gametime > 30f && pirahs==false)
		{
			pirahs=true;
			StartCoroutine(Spawn2());
		}
	if(Player.gametime > 50f && !Player.lose)
		{
			 Player.win=true;
			Objects[2].SetActive(true);
			Objects[3].SetActive(true);
			if(Player.campaign<=4)
			{
		PlayerPrefs.SetInt("campaign",5);
		}
		}
	}
			IEnumerator Spawn1()//спаун метеоров
    {
		        while (!Player.lose&& Player.win==false)
        {
	          Instantiate(Objects[0],new Vector2(Random.Range(Point1.position.x , Point2.position.x),Point1.position.y), Quaternion.identity);
            yield return new WaitForSeconds(0.8f);
		}
	}
    IEnumerator Spawn2()//спаун пираней
    {
        while (!Player.lose&& Player.win==false)
        {
			Instantiate(Objects[1],new Vector2(Point2.position.x,Point2.position.y), Quaternion.identity);
            yield return new WaitForSeconds(5f);
        }
    }
}