using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;
using System;
public class BLV0 : MonoBehaviour
{
public GameObject[] Objects;
public static int[] matrix = new int[5];
    void OnMouseDown()
    {
        SceneManager.LoadScene("0");
    }
	 void Awake()
    {
		// перевод из файла в масив
		 string[] lines = File.ReadAllLines("in.txt");
		 for(int i =0;i<5;i++)
		 {
			 matrix[i]=Convert.ToInt32(lines[i]);
		 }
		  switch ( matrix[4])
      {
			case 0:
			Objects[0].SetActive(true);
              break;
			case 1:
			Objects[0].SetActive(true);
			Objects[1].SetActive(true);
              break;
			case 2:
			Objects[0].SetActive(true);
			Objects[1].SetActive(true);
			Objects[2].SetActive(true);
              break;
			case 3:  
			Objects[0].SetActive(true);
			Objects[1].SetActive(true);
			Objects[2].SetActive(true);
			Objects[3].SetActive(true);
		      break;
			case 4:  
			Objects[0].SetActive(true);
			Objects[1].SetActive(true);
			Objects[2].SetActive(true);
			Objects[3].SetActive(true);
			Objects[4].SetActive(true);
		      break;
			case 5:
			Objects[0].SetActive(true);
			Objects[1].SetActive(true);
			Objects[2].SetActive(true);
			Objects[3].SetActive(true);
			Objects[4].SetActive(true);
			Objects[5].SetActive(true);
              break;
			case 6:
			Objects[0].SetActive(true);
			Objects[1].SetActive(true);
			Objects[2].SetActive(true);
			Objects[3].SetActive(true);
			Objects[4].SetActive(true);
			Objects[5].SetActive(true);
			Objects[6].SetActive(true);
              break;
			case 7:
			Objects[0].SetActive(true);
			Objects[1].SetActive(true);
			Objects[2].SetActive(true);
			Objects[3].SetActive(true);
			Objects[4].SetActive(true);
			Objects[5].SetActive(true);
			Objects[5].SetActive(true);
			Objects[6].SetActive(true);
			Objects[7].SetActive(true);
              break;
			case 8:  
			Objects[0].SetActive(true);
			Objects[1].SetActive(true);
			Objects[2].SetActive(true);
			Objects[3].SetActive(true);
			Objects[4].SetActive(true);
			Objects[5].SetActive(true);
			Objects[5].SetActive(true);
			Objects[6].SetActive(true);
			Objects[7].SetActive(true);
			Objects[8].SetActive(true);
		      break;
      }
	}
	
}