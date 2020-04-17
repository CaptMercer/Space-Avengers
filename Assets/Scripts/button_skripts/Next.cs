using UnityEngine;
using UnityEngine.SceneManagement;
public class Next : MonoBehaviour
{
    void OnMouseDown()
    {
	 switch ( Player.LVNomber)//кнопка next
      {
			case 0:
		Player.SCORE=0;
		Player.Gold=0;
		SceneManager.LoadScene("1");

              break;
			case 1:
		Player.SCORE=0;
		Player.Gold=0;
		SceneManager.LoadScene("2");
              break;
			case 2:
		Player.SCORE=0;
		Player.Gold=0;
		SceneManager.LoadScene("3");

              break;
			case 3:  
		Player.SCORE=0;
		Player.Gold=0;
		SceneManager.LoadScene("4");

		      break;
			case 4:  
		Player.SCORE=0;
		Player.Gold=0;
		SceneManager.LoadScene("5");
		      break;
			case 5:
		Player.SCORE=0;
		Player.Gold=0;
		SceneManager.LoadScene("6");
              break;
			case 6:
		Player.SCORE=0;
		Player.Gold=0;
		SceneManager.LoadScene("7");
              break;
			case 7:
		Player.SCORE=0;
		Player.Gold=0;
		SceneManager.LoadScene("8");
              break;
			case 8:  
		Player.SCORE=0;
		Player.Gold=0;
		SceneManager.LoadScene("9");
		      break;
			 case 9:  
		Player.SCORE=0;
		Player.Gold=0;
		SceneManager.LoadScene("10");
		      break;
      }
    }
}
