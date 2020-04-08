using UnityEngine;
using System.IO;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
public class Player : MonoBehaviour
{
    public static bool lose = false;
	public static bool NewRecord = false;
    public static int life ;
	public static int LVNomber;
	public static int shield_Hp = 0;
	public static int shield ;
	public static int damage = 0;
	public static int HighScore;
	public static int Gold;
	public GameObject[] Objects;
    public Sprite[] sprites = new Sprite[2];
    private AudioSource AudioDeath;
	public static int score = 0;
	public static int SCORE = 0;
	public static int[] matrix = new int[5];
	private Text Score;
	private Text Gold_txt;
    void Awake()
    {
		Gold_txt = GameObject.Find("Gold").GetComponent<Text>();
		Score = GameObject.Find("Score").GetComponent<Text>();
		string[] lines = File.ReadAllLines("in.txt");
		 for(int i =0;i<5;i++)
		 {
			 matrix[i]=Convert.ToInt32(lines[i]);
		 }
		damage = 0;
        lose = false;
		shield =matrix[0];
        life =matrix[1];
		HighScore=matrix[2];
		LVNomber=matrix[4];
        AudioDeath = GetComponent<AudioSource>();
		if(matrix[0]==0)
		{
		GetComponent<SpriteRenderer>().sprite = sprites[0];
		}
		else
		{
		GetComponent<SpriteRenderer>().sprite = sprites[2];
		}
		StartCoroutine(Plazma());
    }
        void OnTriggerEnter2D (Collider2D Other)
    {
	       if (Other.gameObject.tag == "Gold")
            {
				Gold++;
				matrix[3]=matrix[3]+Gold;
				Gold=0;
			}  
            if (Other.gameObject.tag == "Bomb")
            {
				damage++;
			}  
     }
	    void  FixedUpdate()
    {
		 //вывод сообщений
	 Gold_txt.text ="Gold :" +matrix[3].ToString();
	 Score.text ="Score :" + SCORE.ToString(); 
	  //сохранение в фаил 
	  		string[] lines=new string[5];
			 for(int i =0;i<5;i++)
		 {
		lines[i] = Convert.ToString(matrix[i]);
		 }
		 File.WriteAllLines("in.txt",lines);
		score++;
		SCORE=score/10;
				if(SCORE>HighScore)
		{
			NewRecord=true;
			HighScore=SCORE;
			matrix[2]=HighScore;
			//print("High Score"+Player.HighScore.ToString());
		}
		if(damage == 1 && shield > 0 )
		{
			shield=shield-damage;
			damage=0;
		}
		if(shield == 0 && life >0 && matrix[0]>0 )
		{
		GetComponent<SpriteRenderer>().sprite = sprites[0];
		shield_Hp ++;
		
			if(shield_Hp==1000)
			{
				GetComponent<SpriteRenderer>().sprite = sprites[2];
				shield_Hp=0;
				shield=1;
			}
		}
			if(damage ==1 && shield == 0)
			{
				life=life-damage;
				damage=0;
			}
			if (life == 0)
                {
                    GetComponent<SpriteRenderer>().sprite = sprites[1];
                    lose = true;
                    Objects[0].SetActive(true);
					Objects[1].SetActive(true);
                    AudioDeath.Play();
                }
	}
	    IEnumerator Plazma()
    {
        int Guns=1;
		if (Guns==1)
		{
        while (!Player.lose)
        {
			Instantiate(Objects[2],new Vector2(Objects[3].transform.position.x, -3.7f), Quaternion.identity);
            yield return new WaitForSeconds(0.8f);
        }
		}
    }
}