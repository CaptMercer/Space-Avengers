using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class N6LV : MonoBehaviour
{
 public GameObject[] Objects;
	public bool BossFight=false;
		public static bool win=false;
    void Start()
    {
		Player.LVNomber=6;
        StartCoroutine(Spawn1());
        StartCoroutine(Spawn2());
    }
	    void Update()
    { 
	if(Player.SCORE>200)
		{
			BossFight=true;
		}
			if(win==true)
		{
		Player.matrix[4]=7;
		Objects[3].SetActive(true);
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
		Objects[2].SetActive(true);
		}
		
	}
	 IEnumerator Spawn2()//спаун пираней
    {
        while (!Player.lose&&BossFight==false)
        {
           Instantiate(Objects[1],new Vector2(6f, 3.28f), Quaternion.identity);	
            yield return new WaitForSeconds(3f);
		}	
	}
}
