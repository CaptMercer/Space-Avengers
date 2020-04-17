using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;
using UnityEngine.UI;
public class ReadFile_SHOP : MonoBehaviour
{
	public static int[] matrix = new int[5];
	public static int armor_price;
	public static bool armor_up_aible=true;
	public static int shield_price;
	public static bool shield_up_aible=true;
	private Text Shield_Price_txt;
	private Text Gold_txt;
	private Text Armor_Price_txt;
	public static int HIGHSCORE,life,shield,campaign,gold;
	 void Awake()
    {
		//текстовые компоненты
		Gold_txt = GameObject.Find("Balance").GetComponent<Text>();
		Shield_Price_txt = GameObject.Find("Shield_Price").GetComponent<Text>();
		Armor_Price_txt = GameObject.Find("Armor_Price").GetComponent<Text>();
		shield=PlayerPrefs.GetInt("shield");
		life=PlayerPrefs.GetInt("life");
		gold=PlayerPrefs.GetInt("gold");
	}
	    void  Update()
    {
		//установление цен и лимитов 
		 switch (life)
      {
          case 1:
              armor_price=100;
              break;
          case 2:
              armor_price=500;
              break;
          case 3:
              armor_price=1000;
              break;
			case 4:  
		 armor_up_aible=false;
		      break;
      }
			  switch (shield)
      {    case 0:
              shield_price=500;
              break;
			case 1:
			  shield_up_aible=false;
              break;
	  }
	  //вывод цен и сообщений
	  Gold_txt.text ="Gold:" +gold.ToString();
	  if(armor_up_aible==true)
	  {
		 Armor_Price_txt.text ="price:" + armor_price.ToString(); 
	  }
	  else
	  {
		 Armor_Price_txt.text ="MAX";
	  }
	  if(shield_up_aible==true)
	  {
		Shield_Price_txt.text ="price:" + shield_price.ToString();
	  }
	  else
	  {
		 Shield_Price_txt.text = "MAX";
	  }
	}
}
