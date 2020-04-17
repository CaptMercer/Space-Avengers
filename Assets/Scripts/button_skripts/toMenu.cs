using UnityEngine;
using UnityEngine.SceneManagement;
public class toMenu : MonoBehaviour
{
    void OnMouseDown()
    {
		Player.SCORE=0;
		Player.Gold=0;
        SceneManager.LoadScene("menu");//выход в меню
    }
}

