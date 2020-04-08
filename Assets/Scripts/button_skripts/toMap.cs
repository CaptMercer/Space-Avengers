using UnityEngine;
using UnityEngine.SceneManagement;

public class toMap : MonoBehaviour
{
    void OnMouseDown()
    {
		Player.SCORE=0;
		Player.Gold=0;
		SceneManager.LoadScene("map");//кнопка переход в режим компании
	}
}
