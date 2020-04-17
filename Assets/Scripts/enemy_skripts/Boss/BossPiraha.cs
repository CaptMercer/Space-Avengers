using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//скрипт боса пираньи 
public class BossPiraha : MonoBehaviour
{
		public GameObject[] Objects;
   		public float speed;
		public Transform Point1,Point2;
		public GameObject ShootPoint;
		private Vector3 nextpos;
		public int Rand;
		private float progress ;
		public int hp=6;
		public int damage=0;
		  void Awake()
    {
		transform.position=new Vector2(Random.Range(-6.1f, 6f), 3.28f);//спаун в рандомной точке
		Rand=Random.Range(1,3);
		print(Rand);
		switch(Rand)//выбор первичного направления и точки спауна потронов
		{
		case 1:
	nextpos=Point1.position;
	ShootPoint=Objects[1];
	break;
		case 2:
	nextpos=Point2.position;
	ShootPoint=Objects[2];
	break;
		}
	StartCoroutine(hello());//спаун выстрелов при запуске 
	}
 void OnTriggerEnter2D (Collider2D Other)//механика получение урона на тригер
    {
	if (Other.gameObject.tag == "SHOOT")
		{
			damage++;
		}
	}
	     void FixedUpdate()
    {
		if(damage==1)//механика отнимания хп
		{
			hp=hp-damage;
			damage=0;
		}
		if( hp==0)//проверка на хп=0
		{
			StartCoroutine(Death());
		}
		
		if(transform.position==Point1.position)//выбор точки движение  2 и точки сауна потронов 2
		{
			nextpos=Point2.position;
			ShootPoint=Objects[2];
		}
		if(transform.position==Point2.position)//выбор точки движение1 и точки сауна потронов 1
		{
			nextpos=Point1.position;
			ShootPoint=Objects[1];
		}
	  transform.position=Vector2.MoveTowards(transform.position,nextpos,speed * Time.deltaTime);//движение к выбраной точке
	}
	IEnumerator hello()//спаун
    {     
	//1 анимация - анимация Awake за тем переход в idle анимацию 
	yield return new WaitForSeconds(1f);
	StartCoroutine(Plazma());
	}
		 IEnumerator Death()//смерть
    {     
	Player.SCORE=Player.SCORE+250;
	Instantiate(Objects[3],new Vector2(Objects[0].transform.position.x, Objects[0].transform.position.y), Quaternion.identity);
	yield return new WaitForSeconds(0.2f);
	Destroy(gameObject);
	}
	  IEnumerator Plazma()//спаун выстрелов 
    {       while (!Player.lose)
        {
			Instantiate(Objects[0],new Vector2(ShootPoint.transform.position.x,ShootPoint.transform.position.y), Quaternion.identity);
			yield return new WaitForSeconds(0.6f);
        }
	}
}