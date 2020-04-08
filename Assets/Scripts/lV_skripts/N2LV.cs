using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class N2LV : MonoBehaviour
{
	public bool win=false;
	public GameObject[] Objects;
    void Start()
    {
		Player.LVNomber=2;
        StartCoroutine(Spawn1());
        StartCoroutine(Spawn2());
        StartCoroutine(Spawn3());
		
    }
		  void Update()
    { 
	if(Player.SCORE==50)
		{
			win=true;
		Player.matrix[4]=3;
		Objects[3].SetActive(true);
		}
	}
	IEnumerator Spawn1()
    {
        while (!Player.lose&&win==false)//спаун голды
        {
            Instantiate(Objects[0],new Vector2(Random.Range(-6.1f, 6f), 5.9f), Quaternion.identity);
            yield return new WaitForSeconds(0.8f);
        }
    }
	    IEnumerator Spawn2()//спаун метеоров
    {
        while (!Player.lose&&win==false)
        {
            Instantiate(Objects[1],new Vector2(Random.Range(-6.1f, 6f), 5.9f), Quaternion.identity);
            yield return new WaitForSeconds(0.8f);
        }
    }
    IEnumerator Spawn3()//спаун турелей
    {
        while (!Player.lose&&win==false)
        {
			Instantiate(Objects[2],new Vector2(Random.Range(-6.1f, 6f), 3.28f), Quaternion.identity);
            yield return new WaitForSeconds(3f);
        }
    }
}
