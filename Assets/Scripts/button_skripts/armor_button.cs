using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;
//скрипт кнопки добавления брони в магазине 
public class armor_button : MonoBehaviour
{
    void OnMouseDown()
    {
		if(ReadFile_SHOP.armor_up_aible==true)//проверка возможности обновить
		{
	if (ReadFile_SHOP.armor_price<=ReadFile_SHOP.gold)//проверка наличия золота
	{
		ReadFile_SHOP.gold=ReadFile_SHOP.gold-ReadFile_SHOP.armor_price;	
	 ReadFile_SHOP.life=ReadFile_SHOP.life+1;
	 PlayerPrefs.SetInt("life",ReadFile_SHOP.life);
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
