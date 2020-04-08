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
		print("?="+ReadFile_SHOP.armor_up_aible);
		if(ReadFile_SHOP.armor_up_aible==true)//проверка возможности обновить
		{
	if (ReadFile_SHOP.armor_price<=ReadFile_SHOP.matrix[3])//проверка наличия золота
	{
		ReadFile_SHOP.matrix[3]=ReadFile_SHOP.matrix[3]-ReadFile_SHOP.armor_price;	
	 ReadFile_SHOP.matrix[1]=ReadFile_SHOP.matrix[1]+1;
		print("life="+ ReadFile_SHOP.matrix[1]);
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
