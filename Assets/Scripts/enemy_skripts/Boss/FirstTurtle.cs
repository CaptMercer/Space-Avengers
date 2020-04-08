using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstTurtle : MonoBehaviour
{
   	public GameObject[] Objects;
		public int Rand;
   		public float speed;
		public Transform Point1,Point2;
		private Vector3 nextpos;
		private float progress ;
		public int hp=2;
		public int damage=0;
		public int shield=1;
		public int shield_Hp;
	  void Awake()
    {
		transform.position=new Vector2(Random.Range(-6.1f, 6f), 3.28f);//перемещение в произвольную точку 
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
	StartCoroutine(Plazma());
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
				if(damage == 1 && shield > 0 )//урон в щит 
		{
			shield=shield-damage;
			damage=0;
			print("damage on Shield");
		}
		if(shield == 0 && hp >0)//проверкв на щит = 0
		{
	//	GetComponent<SpriteRenderer>().sprite = sprites[0];
	print("shield fall");
		shield_Hp ++;
		
			if(shield_Hp==1000)//механика востановления щита
			{
		//		GetComponent<SpriteRenderer>().sprite = sprites[2];
				shield_Hp=0;
				shield=1;
				print("shield on");
			}
		}
			if(damage ==1 && shield == 0)//механика отнимания хп
			{
				hp=hp-damage;
				damage=0;
				print(hp);
			}
		if( hp==0)//проверка на хп=0
		{
		N6LV.win=true;
		 Destroy(gameObject);
		}
		if(transform.position==Point1.position)//выбор точки движение  2 
		{
			nextpos=Point2.position;
		}
				if(transform.position==Point2.position)//выбор точки движение1 
		{
			nextpos=Point1.position;
		}
	  transform.position=Vector2.MoveTowards(transform.position,nextpos,speed * Time.deltaTime);//движение к выбраной точке
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
