using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class N5LV : MonoBehaviour
{
		public GameObject[] Objects;
		public static bool win=false;
    void Start()
    {
		Player.LVNomber=5;
        StartCoroutine(Spawn1());
		StartCoroutine(Spawn2());
		StartCoroutine(Spawn3());
    }
			    void Update()
    { 
	if(Player.SCORE==50)
		{
		win=true;
		Player.matrix[4]=6;
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
			IEnumerator Spawn2()//спаун метеоров
    {
		        while (!!Player.lose&&win==false)
        {
	          Instantiate(Objects[1],new Vector2(6f, 3.28f), Quaternion.identity);
            yield return new WaitForSeconds(0.8f);
		}
	}
	IEnumerator Spawn3()//спаун пираней
    {
        while (!Player.lose&&win==false)
        {
			Instantiate(Objects[2],new Vector2(6f, 3.28f), Quaternion.identity);
            yield return new WaitForSeconds(3f);
        }
    }

}
