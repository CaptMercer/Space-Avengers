using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class N0LV : MonoBehaviour
{
	public GameObject[] Objects;
	public bool win=false;
    void Start()
    {
		Player.LVNomber=0;//присваевание переменной уровня
        StartCoroutine(Spawn1());
		StartCoroutine(Spawn2());
    }
		    void Update()
    { 
	if(Player.SCORE==50)
		{
			win=true;
		Player.matrix[4]=1;
		Objects[2].SetActive(true);
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
        while (!Player.lose&&win==false)
        {
			Instantiate(Objects[1],new Vector2(Random.Range(-6.1f, 6f), 5.9f), Quaternion.identity);
            yield return new WaitForSeconds(0.8f);
        }
    }
}
