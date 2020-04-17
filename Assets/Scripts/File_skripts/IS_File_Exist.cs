using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;
using UnityEngine.UI;
//скрипт на проверку существует ли сейф
public class IS_File_Exist : MonoBehaviour
{
	public int HIGHSCORE,life,shield,campaign,gold;
	 void Awake()
    {
			//рекорд
			if(PlayerPrefs.HasKey("records"))
			{
			HIGHSCORE=PlayerPrefs.GetInt("records");
			}
					else
			{
				HIGHSCORE=0;
				PlayerPrefs.SetInt("records",HIGHSCORE);
			}
			// хп
					if(PlayerPrefs.HasKey("life"))
			{
			life=PlayerPrefs.GetInt("life");
			}
					else
			{
				life=1;
				PlayerPrefs.SetInt("life",life);
			}
			//щит
			if(PlayerPrefs.HasKey("shield"))
			{
			shield=PlayerPrefs.GetInt("shield");
			}
					else
			{
				shield=0;
				PlayerPrefs.SetInt("shield",shield);
			}
			//прохождение
						if(PlayerPrefs.HasKey("campaign"))
			{
			campaign=PlayerPrefs.GetInt("campaign");
			}
					else
			{
				campaign=0;
				PlayerPrefs.SetInt("campaign",campaign);
			}
			//голда
			if(PlayerPrefs.HasKey("gold"))
			{
			gold=PlayerPrefs.GetInt("gold");
			}
					else
			{
				gold=0;
				PlayerPrefs.SetInt("gold",gold);
			}
		
		}
	}

