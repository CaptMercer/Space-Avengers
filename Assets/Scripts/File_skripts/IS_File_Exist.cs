using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;
using UnityEngine.UI;
//скрипт на проверку существует ли сейф
public class IS_File_Exist : MonoBehaviour
{
public static int[] matrix = new int[5];
public static Boolean FileExistIN=true;
	 void Awake()
    {
		if (File.Exists("in.txt")==false)
		{
			File.Create("in.txt");//создание пустого сейва 
			 matrix[0]=0;
			 matrix[1]=1;
			 matrix[2]=0;
			 matrix[3]=0;
			 matrix[4]=0;
			print("File Dont Exist !!! ");
			FileExistIN=false;
		}
	}
	   void  Update()
    {
		if(FileExistIN==false)//запись в фаил пустого сейва 
		{
			 string[] lines=new string[5];
			 for(int i =0;i<5;i++)
		 {
		lines[i] = Convert.ToString(matrix[i]);
		 }
		 File.WriteAllLines("in.txt",lines);
		}
		}
	}

