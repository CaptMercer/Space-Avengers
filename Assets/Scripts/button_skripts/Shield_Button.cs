using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;
//скрипт кнопки добавления щита в магазине 
public class Shield_Button : MonoBehaviour
{
    void OnMouseDown()
	{
		if(ReadFile_SHOP.shield_up_aible==true)	//проверка возможности обновить
    {
		if (ReadFile_SHOP.shield_price<=ReadFile_SHOP.gold)//проверка наличия золота
	{
	ReadFile_SHOP.gold=ReadFile_SHOP.gold-ReadFile_SHOP.shield_price;
	ReadFile_SHOP.shield=ReadFile_SHOP.shield+1;
		PlayerPrefs.SetInt("shield",ReadFile_SHOP.shield);
	}
		else
	{
		print(" need more gold");
	}
    }
		else
		{
			print("aisle of improvements");
		}
}
}
