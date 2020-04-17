using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//скрипт турели
public class turell : MonoBehaviour
{
	public GameObject[] Objects;
	  void Awake()
    {
	StartCoroutine(hello());//начала спауна выстрелов 
	}
 void OnTriggerEnter2D (Collider2D Other)
    {
		if (Other.gameObject.tag == "SHOOT")
		{
		StartCoroutine(Death());
		}
	}
	IEnumerator hello()//спаун
    {     
	//1 анимация - анимация Awake за тем переход в idle анимацию 
	yield return new WaitForSeconds(1f);
	StartCoroutine(Plazma());
	}
	  IEnumerator Plazma()//спаун 3 выстрелов с перезарядкой в 3 секунды 
    {        while (!Player.lose)
        {
			//добавить анимацию idle shoot
			Instantiate(Objects[1],new Vector2(Objects[0].transform.position.x, Objects[0].transform.position.y), Quaternion.identity);
			yield return new WaitForSeconds(0.2f);
			Instantiate(Objects[1],new Vector2(Objects[0].transform.position.x, Objects[0].transform.position.y), Quaternion.identity);
			yield return new WaitForSeconds(0.2f);
			Instantiate(Objects[1],new Vector2(Objects[0].transform.position.x,Objects[0].transform.position.y), Quaternion.identity);
            yield return new WaitForSeconds(3f);
        }
	}
	 IEnumerator Death()//смерть
    {     
	Player.SCORE=Player.SCORE+50;
	Instantiate(Objects[2],new Vector2(Objects[0].transform.position.x, Objects[0].transform.position.y), Quaternion.identity);
	yield return new WaitForSeconds(0.2f);
	Destroy(gameObject);
	}
}
