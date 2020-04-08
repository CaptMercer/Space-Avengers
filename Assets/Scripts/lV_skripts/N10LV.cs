using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class N10LV : MonoBehaviour
{
	public GameObject[] Objects;
	public static bool win=false;
		public bool BossFight=false;
    void Start()
    {
		Player.LVNomber=10;
        StartCoroutine(Spawn1());
		StartCoroutine(Spawn2());
		StartCoroutine(Spawn3());
		StartCoroutine(Spawn4());
    }
					    void Update()
						{
	if(Player.SCORE>200)
		{
			BossFight=true;
		}
			if(win==true)
		{
		Player.matrix[4]=11;
		Objects[5].SetActive(true);
		}
						}
    IEnumerator Spawn1()//спаун голды
    {
        while ( !Player.lose&&BossFight==false)
        {
            Instantiate(Objects[0],new Vector2(Random.Range(-6.1f, 6f), 5.9f), Quaternion.identity);
            yield return new WaitForSeconds(0.8f);
		}
			if(BossFight==true)//босфайт
		{
		Objects[4].SetActive(true);
		}
    }
			IEnumerator Spawn2()//спаун пираней
    {
		        while (!Player.lose&&BossFight==false)
        {
	          Instantiate(Objects[1],new Vector2(6f, 3.28f), Quaternion.identity);
            yield return new WaitForSeconds(2f);
		}
	}
	IEnumerator Spawn3()//спаун черепах
    {
        while (!Player.lose&&BossFight==false)
        {
			Instantiate(Objects[2],new Vector2(6f, 3.28f), Quaternion.identity);
            yield return new WaitForSeconds(5f);
        }
    }
		IEnumerator Spawn4()//спаун новых черепах
    {
        while (!Player.lose&&BossFight==false)
        {
			Instantiate(Objects[3],new Vector2(6f, 3.28f), Quaternion.identity);
            yield return new WaitForSeconds(6f);
        }
    }
}
