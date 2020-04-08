using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPiraha : MonoBehaviour
{
   public GameObject[] Objects;
   		public float speed;
		public Transform Point1,Point2;
		public GameObject ShootPoint;
		private Vector3 nextpos;
		public int Rand;
		//public bool win=false;
		private float progress ;
		  void Awake()
    {
		transform.position=new Vector2(Random.Range(-6.1f, 6f), 3.28f);//спаун в рандомной точке
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
	StartCoroutine(Plazma());//спаун выстрелов при запуске 
	}
 void OnTriggerEnter2D (Collider2D Other)//смерть
    {
		if (Other.gameObject.tag == "SHOOT")
		{
			N3LV.win=true;
		  Destroy(gameObject);
		}
	}
	     void FixedUpdate()
    {
		if(transform.position==Point1.position)//выбор точки движение  2 и точки сауна потронов 2
		{
			nextpos=Point2.position;
			ShootPoint=Objects[0];
		}
		if(transform.position==Point2.position)//выбор точки движение  1 и точки сауна потронов 1
		{
			nextpos=Point1.position;
			ShootPoint=Objects[2];
		}
	  transform.position=Vector2.MoveTowards(transform.position,nextpos,speed * Time.deltaTime);//движение к выбраной точке
	}
	  IEnumerator Plazma()//спаун выстрелов 
    {       while (!Player.lose)
        {
			Instantiate(Objects[1],new Vector2(ShootPoint.transform.position.x,ShootPoint.transform.position.y), Quaternion.identity);
			yield return new WaitForSeconds(0.8f);
        }
	}
}
