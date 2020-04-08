using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;

public class Shield_Button : MonoBehaviour
{
	//matrix[3];
    void OnMouseDown()
	{
		print("?="+ReadFile.shield_up_aible );
		if(ReadFile.shield_up_aible==true)	
    {
		if (ReadFile.shield_price<=ReadFile.matrix[3])
	{
	ReadFile.matrix[3]=ReadFile.matrix[3]-ReadFile.shield_price;
	ReadFile.matrix[0]=	ReadFile.matrix[0]+1;
	print("shield="+ ReadFile.matrix[0]);
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
