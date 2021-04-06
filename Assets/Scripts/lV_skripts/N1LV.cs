using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class N1LV : MonoBehaviour
{
	public GameObject[] Objects;
	public bool turels=false;
	public Transform Point1,Point2;
    void Start()
    {
		turels=false;
		Player.LVNomber=1;//присваевание переменной уровня
        StartCoroutine(Spawn1());
    }
	  void Update()
    { 
		Player.gametime+=1*Time.deltaTime;
		if(Player.gametime > 35f && turels==false)
		{
			turels=true;
			StartCoroutine(Spawn2());
		}
	if(Player.gametime > 50f && !Player.lose)
		{
			 Player.win=true;
			Objects[2].SetActive(true);
			if(Player.campaign<=1)
			{
		PlayerPrefs.SetInt("campaign",2);
		}
		}
	}
	
	  
    IEnumerator Spawn1()//спаун метеоров
    {
        while (!Player.lose&& Player.win==false)
        {
			Instantiate(Objects[0],new Vector2(Random.Range(Point1.position.x , Point2.position.x),Point1.position.y), Quaternion.identity);
            yield return new WaitForSeconds(1.5f);
        }
    }
	IEnumerator Spawn2()//спаун турелей
    {
        while (!Player.lose&& Player.win==false)
        {
			Instantiate(Objects[1],new Vector2(Random.Range(Point1.position.x , Point2.position.x),Point1.position.y), Quaternion.identity);
            yield return new WaitForSeconds(5f);
        }
    }
}
