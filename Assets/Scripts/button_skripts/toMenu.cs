using UnityEngine;
using UnityEngine.SceneManagement;
public class toMenu : MonoBehaviour
{
    void OnMouseDown()
    {
        SceneManager.LoadScene("menu");//выход в меню
		Player.SCORE=0;
    }
}

