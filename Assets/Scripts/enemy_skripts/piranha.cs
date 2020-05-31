using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//скрипт пираньи 
public class piranha : MonoBehaviour
{
   	public GameObject[] Objects;
   		public float speed;
		public Transform Point1,Point2;
		public bool  death = false,boss,away=false;
		public GameObject ShootPoint;
		private Vector3 nextpos ,P;
		public int Rand;
		private float progress,roat ;
		  void Awake()
    {
		transform.position=new Vector2(Random.Range(Point1.position.x , Point2.position.x),Point1.position.y);//спаун в рандомной точке
		Rand=Random.Range(1,3);
		switch(Rand)//выбор первичного направления и точки спауна потронов
		{
		case 1:
	nextpos=Point1.position;
	ShootPoint=Objects[0];
	break;
		case 2:
	nextpos=Point2.position;
	ShootPoint=Objects[2];
	break;
		}
	StartCoroutine(hello());//спаун выстрелов при запуске 
	}
 void OnTriggerEnter2D (Collider2D Other)//смерть
    {
		if (Other.gameObject.tag == "SHOOT")
		{
			StartCoroutine(Death());
		}
	}
	     void FixedUpdate()
    {
				if(Player.lose==true || Player.BossFight==true ||Player.win==true && boss==false && away==false)/////////////////////////
		{
			away=true;
			StartCoroutine(goaway());
		}
		if(transform.position==Point1.position)//выбор точки движение  2 и точки сауна потронов 2
		{
			P= new Vector2(Point2.position.x,Point1.position.y-0.5f);
			Point2.position=P;
			nextpos=Point2.position;
			ShootPoint=Objects[2];
		}
		if(transform.position==Point2.position)//выбор точки движение  1 и точки сауна потронов 1
		{
			P= new Vector2(Point1.position.x,Point2.position.y-0.5f);
			Point1.position=P;
			nextpos=Point1.position;
			ShootPoint=Objects[0];
		}
			if(away==false)
		{
	  transform.position=Vector2.MoveTowards(transform.position,nextpos,speed * Time.deltaTime);//движение к выбраной точке
		}
	}
	IEnumerator goaway()//уход
    {     
	  if (roat<180)
        {
		roat++;
		transform.rotation = Quaternion.Euler(0, 0, roat);
		}
		else
		{
			transform.position += new Vector3(0,2* Time.deltaTime, 0);
		}
	yield return new WaitForSeconds(1f);
	}
		IEnumerator hello()//спаун
    {     
	//1 анимация - анимация Awake за тем переход в idle анимацию 
	yield return new WaitForSeconds(1f);
	StartCoroutine(Plazma());
	}
		 IEnumerator Death()//смерть
    {     
	Player.SCORE=Player.SCORE+100;
	Instantiate(Objects[3],new Vector2(Objects[0].transform.position.x, Objects[0].transform.position.y), Quaternion.identity);
				if (boss==true)
		{
				 Player.win=true;
		}
	yield return new WaitForSeconds(0.2f);
	Destroy(gameObject);
	}
	  IEnumerator Plazma()//спаун выстрелов 
    {       while (!Player.lose)
        {
			Instantiate(Objects[1],new Vector2(ShootPoint.transform.position.x,ShootPoint.transform.position.y), Quaternion.identity);
			yield return new WaitForSeconds(0.8f);
        }
	}
}