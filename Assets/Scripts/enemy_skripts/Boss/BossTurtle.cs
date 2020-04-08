using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossTurtle : MonoBehaviour
{
     	public GameObject[] Objects;
		public int Rand;
   		public float speed;
		public Transform Point1,Point2;
		private Vector3 nextpos;
		private float progress ;
		public int hp;
		public int step;
		public int damage=0;
		public int Criticaldamage=0;
		public int shield=1;
		public int shield_Hp;
	  void Awake()
    {
		step=0;
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
			if(step==0)
			{
					damage++;
	//		if(shield == 0 && hp >0 && damage!=0)//проверкв на щит = 0
	////	{
	//	}
		}
		}
	}
	     void FixedUpdate()
    {
				if(damage == 1 && shield > 0 )//урон в щит 
		{
			shield=shield-damage;
			damage=0;
		}
		if(shield == 0 && hp >0)//проверкв на щит = 0
		{
	//	GetComponent<SpriteRenderer>().sprite = sprites[0];//изменение спрайта при попадание в щит 
		shield_Hp ++;
		
			if(shield_Hp==1000)//механика востановления щита
			{
		//		GetComponent<SpriteRenderer>().sprite = sprites[2];
				shield_Hp=0;
				shield=1;
			}
		}
			if(damage ==1 && shield == 0 )//механика отнимания хп
			{
				hp=hp-damage;
				Criticaldamage++;
				damage=0;
			}
		if( hp==0)//проверка на хп=0
		{
		 Destroy(gameObject);
		}
		
			if(Criticaldamage!=3)//Движение в обычном режиме
		{
		if(transform.position==Point1.position)//выбор точки движение  2 
		{
			nextpos=Point2.position;
		}
				if(transform.position==Point2.position)//выбор точки движение1 
		{
			nextpos=Point1.position;
		}
	  transform.position=Vector2.MoveTowards(transform.position,nextpos,speed * Time.deltaTime);//движение к выбраной точке
	  
		}//запустить не по степу а по таймеру 
	  		if(Criticaldamage==3)//Движение с критическим уроном(нужно будет подрубить анимацию)
		{
				speed=3;
				if(transform.position==Point1.position)//выбор точки движение  2 
		{
		step=step+1;
			nextpos=Point2.position;
		}
				if(transform.position==Point2.position)//выбор точки движение1 
		{
		step=step+1;
			nextpos=Point1.position;
			
		}
	  transform.position=Vector2.MoveTowards(transform.position,nextpos,speed * Time.deltaTime);//движение к выбраной точке
		}
				if(step==2)
		{
			speed=1;
			Criticaldamage=0;
			step=0;
		}
	}
	  IEnumerator Plazma()//спаун выстрелов 
	  {
		   while (!Player.lose)
        {
	  if (Criticaldamage==3)
	  {
		  Instantiate(Objects[1],new Vector2(Objects[0].transform.position.x, 3.28f), Quaternion.identity);
			yield return new WaitForSeconds(0.4f);
	  }
	  else
	  {
		  Instantiate(Objects[1],new Vector2(Objects[0].transform.position.x, 3.28f), Quaternion.identity);
			yield return new WaitForSeconds(0.8f);
	  }
	  }
	  }
}
