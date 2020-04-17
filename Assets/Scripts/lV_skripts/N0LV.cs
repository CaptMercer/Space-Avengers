using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class N0LV : MonoBehaviour
{
	public GameObject[] Objects;
	public Transform Point1,Point2;
    void Start()
    {
		Player.LVNomber=0;//присваевание переменной уровня
        StartCoroutine(Spawn1());
		StartCoroutine(Spawn2());
    }
		    void Update()
    { 
		Player.gametime+=1*Time.deltaTime;
	if(Player.gametime > 50f && !Player.lose)
		{
			 Player.win=true;
		PlayerPrefs.SetInt("campaign",1);
		Objects[2].SetActive(true);
		Objects[3].SetActive(true);
		}
	}
	    IEnumerator Spawn1()//спаун голды
    {
        while (!Player.lose&& Player.win==false)
        {
            Instantiate(Objects[0],new Vector2(Random.Range(Point1.position.x , Point2.position.x ),Point1.position.y), Quaternion.identity);
            yield return new WaitForSeconds(0.8f);
        }
    }
    IEnumerator Spawn2()//спаун метеоров
    {
        while (!Player.lose&& Player.win==false)
        {
			Instantiate(Objects[1],new Vector2(Random.Range(Point1.position.x , Point2.position.x), Point1.position.y), Quaternion.identity);
            yield return new WaitForSeconds(0.8f);
        }
    }
}
