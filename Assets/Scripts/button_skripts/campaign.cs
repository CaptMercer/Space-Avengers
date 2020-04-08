using UnityEngine;
using UnityEngine.SceneManagement;

public class campaign : MonoBehaviour
{
    void OnMouseDown()
    {
        SceneManager.LoadScene("map");//кнопка переход в режим компании 
    }
}
