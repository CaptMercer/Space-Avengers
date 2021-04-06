using UnityEngine;
using System.IO;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
public class Player : MonoBehaviour
{
    public static bool lose = false,NewRecord = false,BossFight = false,win=false;
	public  static int  HighScore,life,shield,LVNomber,Gold,S,campaign,shield_Hp = 0,damage = 0,SCORE = 0;
	public GameObject[] Objects;
    public Sprite[] sprites = new Sprite[2];
    private AudioSource AudioDeath;
	private Text Gold_txt,Score;
	 public static float  gametime;
    void Awake()
    {
		gametime=0;
		Gold_txt = GameObject.Find("Gold").GetComponent<Text>();
		Score = GameObject.Find("Score").GetComponent<Text>();
		damage = 0;
        lose = false;
		win=false;
		NewRecord = false;
		BossFight = false;
		Gold=PlayerPrefs.GetInt("gold");
		shield=PlayerPrefs.GetInt("shield");
		S=PlayerPrefs.GetInt("shield");
        life =PlayerPrefs.GetInt("life");
		print(life);
		HighScore=PlayerPrefs.GetInt("records");
		campaign=PlayerPrefs.GetInt("campaign");
        AudioDeath = GetComponent<AudioSource>();
		if(shield==0)
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
				Gold=PlayerPrefs.GetInt("gold")+1;
				PlayerPrefs.SetInt("gold",Gold);
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
	 Gold_txt.text ="Gold :" +PlayerPrefs.GetInt("gold").ToString();
	 Score.text ="Score :" + SCORE.ToString(); 
	  //сохранение в фаил 
				if(SCORE>HighScore)
		{
			NewRecord=true;
			HighScore=SCORE;
			PlayerPrefs.SetInt("records",HighScore);
		}
		if(damage == 1 && shield > 0 )
		{
			shield=shield-damage;
			damage=0;
		}
		if(shield == 0 && life >0 && S>0 )
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
					Time.timeScale = 0f;
					Objects[0].SetActive(true);
                    Objects[1].SetActive(false);
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
			Instantiate(Objects[2],new Vector2(Objects[3].transform.position.x,Objects[3].transform.position.y), Quaternion.identity);
            yield return new WaitForSeconds(0.8f);
        }
		}
    }
}