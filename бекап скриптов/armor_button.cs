using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;

public class armor_button : MonoBehaviour
{
		//matrix[3];
    void OnMouseDown()
    {
		print("?="+ReadFile.armor_up_aible);
		if(ReadFile.armor_up_aible==true)
		{
	if (ReadFile.armor_price<=ReadFile.matrix[3])
	{
		ReadFile.matrix[3]=ReadFile.matrix[3]-ReadFile.armor_price;	
	 ReadFile.matrix[1]=ReadFile.matrix[1]+1;
		print("life="+ ReadFile.matrix[1]);
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
