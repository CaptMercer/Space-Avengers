using UnityEngine;
using UnityEngine.SceneManagement;
public class toMenu : MonoBehaviour
{
    void OnMouseDown()
    {
        SceneManager.LoadScene("menu");
		FallDown.score=0;
    }
}

