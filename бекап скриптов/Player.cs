using UnityEngine;
using System.IO;
using System;
public class Player : MonoBehaviour
{
    public GameObject restart;
	public GameObject ToMenu;
    public static bool lose = false;
	public static bool NewRecord = false;
    public static int life ;
	public static int shield_Hp = 0;
	public static int shield ;
	public static int damage = 0;
	public static int HighScore;
	public static int[] matrix = new int[3];
    public Sprite[] sprites = new Sprite[2];
    private AudioSource AudioDeath;
    void Awake()
    {
		
		 string[] lines = File.ReadAllLines("in.txt");
		 for(int i =0;i<3;i++)
		 {
			 matrix[i]=Convert.ToInt32(lines[i]);
			 print("mass"+matrix[i]);
		 }
		damage = 0;
        lose = false;
		shield = matrix[0];
		//print("shield:" + shield.ToString());
        life = matrix[1];
		//print("life:" + life.ToString());
		HighScore=matrix[2];
        AudioDeath = GetComponent<AudioSource>();
    }
        void OnTriggerEnter2D (Collider2D Other)
    {
            if (Other.gameObject.tag == "Bomb")
            {
				damage++;
			}  
     }
	    void  FixedUpdate()
    {
				if(FallDown.score>HighScore)
		{
			NewRecord=true;
			Player.HighScore=FallDown.score;
			matrix[2]=HighScore;
			print("High Score"+Player.HighScore.ToString());
		}
		
			if(NewRecord==true&&lose==true)
		{
			string[] lines=new string[3];
			 for(int i =0;i<3;i++)
		 {
		lines[i] = Convert.ToString(matrix[i]);
			// print("mass"+matrix[i]);
		 }
		 		File.WriteAllLines("in.txt",lines);
		
		}
		
		
		if(damage == 1 && shield > 0 )
		{
			shield=shield-damage;
			damage=0;
		}
		if(shield == 0 && life >0 )
		{
		GetComponent<SpriteRenderer>().sprite = sprites[0];
		//print("SHIELD DISABLED");
		shield_Hp ++;
		
			if(shield_Hp==1000)
			{
				GetComponent<SpriteRenderer>().sprite = sprites[2];
				//print("SHIELD ENABLED");
				
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
                    restart.SetActive(true);
					ToMenu.SetActive(true);
                    AudioDeath.Play();
               //     print("DEATH");
                }
	}
	}