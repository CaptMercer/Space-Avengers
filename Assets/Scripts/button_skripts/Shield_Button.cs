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
		print("?="+ReadFile_SHOP.shield_up_aible );
		if(ReadFile_SHOP.shield_up_aible==true)	//проверка возможности обновить
    {
		if (ReadFile_SHOP.shield_price<=ReadFile_SHOP.matrix[3])//проверка наличия золота
	{
	ReadFile_SHOP.matrix[3]=ReadFile_SHOP.matrix[3]-ReadFile_SHOP.shield_price;
	ReadFile_SHOP.matrix[0]=	ReadFile_SHOP.matrix[0]+1;
	print("shield="+ ReadFile_SHOP.matrix[0]);//вывод в консоль 
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
