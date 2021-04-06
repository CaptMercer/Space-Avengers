using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class N6LV : MonoBehaviour
{
		public GameObject[] Objects;
		public static bool pirahs=false;
		public Transform Point1,Point2;
    void Start()
    {
		Player.LVNomber=6;
    }
	    void Update()
    { 
	Player.gametime+=1*Time.deltaTime;
		if( Player.gametime > 3f && pirahs==false)
		{
			pirahs=true;
			StartCoroutine(Spawn1());
		}
	if( Player.gametime > 50f && !Player.lose)
		{
		Player.BossFight=true;
		}
			if(Player.win==true)
		{
			Player.win=true;
			Objects[3].SetActive(true);
			if (Player.campaign<=6)
			{
		PlayerPrefs.SetInt("campaign",7);
		}
		}
	}
	 IEnumerator Spawn1()//спаун пираней
    {
        while (!Player.lose&&Player.BossFight==false)
        {
		if(Player.BossFight==true)//босфайт
		{
		Objects[1].SetActive(true);
		}
           Instantiate(Objects[0],new Vector2(Point2.position.x,Point2.position.y), Quaternion.identity);
            yield return new WaitForSeconds(3f);
		}	
	}
}
