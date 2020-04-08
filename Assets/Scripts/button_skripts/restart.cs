using UnityEngine;
using UnityEngine.SceneManagement;

public class restart : MonoBehaviour
{
    void OnMouseDown()
    {
	 switch ( Player.LVNomber)//кнопка рестарт 
      {
			case 0:
		SceneManager.LoadScene("0");
		Player.SCORE=0;
		Player.Gold=0;
              break;
			case 1:
		SceneManager.LoadScene("1");
		Player.SCORE=0;
		Player.Gold=0;
              break;
			case 2:
		SceneManager.LoadScene("2");
		Player.SCORE=0;
		Player.Gold=0;
              break;
			case 3:  
		SceneManager.LoadScene("3");
		Player.SCORE=0;
		Player.Gold=0;
		      break;
			case 4:  
		SceneManager.LoadScene("4");
		Player.SCORE=0;
		Player.Gold=0;
		      break;
			case 5:
		SceneManager.LoadScene("5");
		Player.SCORE=0;
		Player.Gold=0;
              break;
			case 6:
		SceneManager.LoadScene("6");
		Player.SCORE=0;
		Player.Gold=0;
              break;
			case 7:
		SceneManager.LoadScene("7");
		Player.SCORE=0;
		Player.Gold=0;
              break;
			case 8:  
		SceneManager.LoadScene("8");
		Player.SCORE=0;
		Player.Gold=0;
		      break;
      }
    }
}
