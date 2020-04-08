using UnityEngine;
using UnityEngine.SceneManagement;
public class Upgrade : MonoBehaviour
{
    void OnMouseDown()
    {
        SceneManager.LoadScene("Upgrade");//кнопка перехода в магазин 
    }
}
