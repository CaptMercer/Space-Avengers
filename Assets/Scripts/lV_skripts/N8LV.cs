using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class N8LV : MonoBehaviour
{
	public GameObject[] Objects;
	public static bool win=false;
    void Start()
    {
		Player.LVNomber=8;
        StartCoroutine(Spawn1());
		StartCoroutine(Spawn2());
		StartCoroutine(Spawn3());
		StartCoroutine(Spawn4());
    }
				    void Update()
    { 
	if(Player.SCORE==50)
		{
		win=true;
		Player.matrix[4]=9;
		Objects[4].SetActive(true);
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
            yield return new WaitForSeconds(3f);
		}
	}
	IEnumerator Spawn3()//спаун черепах
    {
        while (!Player.lose&&win==false)
        {
			Instantiate(Objects[2],new Vector2(6f, 3.28f), Quaternion.identity);
            yield return new WaitForSeconds(7f);
        }
    }
		IEnumerator Spawn4()//спаун новых черепах
    {
        while (!Player.lose&&win==false)
        {
			Instantiate(Objects[3],new Vector2(6f, 3.28f), Quaternion.identity);
            yield return new WaitForSeconds(8f);
        }
    }
}
