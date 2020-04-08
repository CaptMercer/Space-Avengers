using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//скрипт турели
public class turell : MonoBehaviour
{
	public GameObject[] Objects;
	  void Awake()
    {
	StartCoroutine(Plazma());//начала спауна выстрелов 
	}
 void OnTriggerEnter2D (Collider2D Other)
    {
		if (Other.gameObject.tag == "SHOOT")
		{
		  Destroy(gameObject);
		}
	}
	  IEnumerator Plazma()//спаун 3 выстрелов с перезарядкой в 3 секунды 
    {        while (!Player.lose)
        {
			Instantiate(Objects[1],new Vector2(Objects[0].transform.position.x, 3.28f), Quaternion.identity);
			yield return new WaitForSeconds(0.2f);
			Instantiate(Objects[1],new Vector2(Objects[0].transform.position.x, 3.28f), Quaternion.identity);
			yield return new WaitForSeconds(0.2f);
			Instantiate(Objects[1],new Vector2(Objects[0].transform.position.x, 3.28f), Quaternion.identity);
            yield return new WaitForSeconds(3f);
        }
	}
}
