using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class N7LV : MonoBehaviour
{
	public GameObject[] Objects;
	public Transform Point1,Point2;
    void Start()
    {
		Player.LVNomber=7;
        StartCoroutine(Spawn1());
		StartCoroutine(Spawn2());
    }
			    void Update()
    { 
	Player.gametime+=1*Time.deltaTime;
	if( Player.gametime > 50f && !Player.lose)
		{
		Player.win=true;
		if(Player.campaign<=7)
			{
		PlayerPrefs.SetInt("campaign",8);
			}
		Objects[2].SetActive(true);
		Objects[3].SetActive(true);
		}
	}
			IEnumerator Spawn1()//спаун пираней
    {
		        while (!Player.lose&&Player.win==false)
        {
	          Instantiate(Objects[0],new Vector2(Point2.position.x,Point2.position.y), Quaternion.identity);
            yield return new WaitForSeconds(1.5f);
		}
	}
	IEnumerator Spawn2()//спаун черепах
    {
        while (!Player.lose)
        {
			Instantiate(Objects[1],new Vector2(Point2.position.x,Point2.position.y), Quaternion.identity);
            yield return new WaitForSeconds(5f);
        }
    }
}
