using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class N5LV : MonoBehaviour
{
		public GameObject[] Objects;
		public static bool pirahs=false;
		public Transform Point1,Point2;
    void Start()
    {
		Player.LVNomber=5;
        StartCoroutine(Spawn1());
		StartCoroutine(Spawn2());;
    }
			    void Update()
				{
  Player.gametime+=1*Time.deltaTime;
		if(Player.gametime > 25f && pirahs==false)
		{
			pirahs=true;
			StartCoroutine(Spawn2());
		}
	if(Player.gametime > 50f && !Player.lose)
		{
			 Player.win=true;
			Objects[2].SetActive(true);
			Objects[3].SetActive(true);
			if(Player.campaign<=5)
			{
		PlayerPrefs.SetInt("campaign",6);
		}
		}
		}
			IEnumerator Spawn1()//спаун метеоров
    {
		        while (!!Player.lose&& Player.win==false)
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
            yield return new WaitForSeconds(3f);
        }
    }
}
