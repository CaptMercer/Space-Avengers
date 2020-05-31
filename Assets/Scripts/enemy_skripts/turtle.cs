using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//скрипт черепахи 
public class turtle : MonoBehaviour
{
   	public GameObject[] Objects;
		public int Rand;
   		public float speed;
   		public bool  death = false,boss,away=false;
		public Transform Point1,Point2;
		private Vector3 nextpos,P;
		private float progress,roat ;
		public int hp ;
		public int damage=0;
		public int shield=1;
		public int shield_Hp;
	  void Awake()
    {
		roat=0;
		death =false;
		transform.position=new Vector2(Random.Range(Point1.position.x , Point2.position.x),Point1.position.y);//спаун в рандомной точке
		Rand=Random.Range(1,3);
		switch(Rand)//радом направление 
		{
		case 1:
	nextpos=Point1.position;
	//ShootPoint=Objects[0];
	break;
		case 2:
	nextpos=Point2.position;
	//ShootPoint=Objects[2];
	break;
		}
	StartCoroutine(hello());
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
		if(Player.lose==true || Player.BossFight==true ||Player.win==true && boss==false && away==false)/////////////////////////
		{
			away=true;
			StartCoroutine(goaway());
		}
				if(damage == 1 && shield > 0 )//урон в щит 
		{
			shield=shield-damage;
			damage=0;
		}
		if(shield == 0 && hp >0)//проверкв на щит = 0
		{
	//	GetComponent<SpriteRenderer>().sprite = sprites[0];
		shield_Hp ++;
		
			if(shield_Hp==1000)//механика востановления щита
			{
		//		GetComponent<SpriteRenderer>().sprite = sprites[2];
				shield_Hp=0;
				shield=1;
			}
		}
			if(damage ==1 && shield == 0)//механика отнимания хп
			{
				hp=hp-damage;
				damage=0;
			}
		if( hp==0 && death ==false )//проверка на хп=0
		{
				death = true;
				StartCoroutine(Death());
		}

if(transform.position==Point1.position)//выбор точки движение  2
		{
			P= new Vector2(Point2.position.x,Point1.position.y-0.5f);
			Point2.position=P;
			nextpos=Point2.position;
		}
		if(transform.position==Point2.position)//выбор точки движение  1
		{
			P= new Vector2(Point1.position.x,Point2.position.y-0.5f);
			Point1.position=P;
			nextpos=Point1.position;
		}
		if(away==false)
		{
	  transform.position=Vector2.MoveTowards(transform.position,nextpos,speed * Time.deltaTime);//движение к выбраной точке
		}
	}
	IEnumerator hello()//появление
    {     
	//1 анимация - анимация Awake за тем переход в idle анимацию 
	yield return new WaitForSeconds(1f);
	StartCoroutine(Plazma());
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
		 IEnumerator Death()//смерть
    {     
	Player.SCORE=Player.SCORE+200;
	Instantiate(Objects[2],new Vector2(Objects[0].transform.position.x, Objects[0].transform.position.y), Quaternion.identity);
			if (boss==true)
		{
				 Player.win=true;
		}
	yield return new WaitForSeconds(0.2f);
	Destroy(gameObject);
	}
	  IEnumerator Plazma()//спаун выстрелов 
    {        while (!Player.lose)
        {
			Instantiate(Objects[1],new Vector2(Objects[0].transform.position.x, 3.28f), Quaternion.identity);
			yield return new WaitForSeconds(0.8f);
        }
	}
}
//возможно придется создать точки спауна выстрелов как у пираний