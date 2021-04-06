using UnityEngine;
using UnityEngine.SceneManagement;

public class restart : MonoBehaviour
{
    public void RestartHandler()
    {
        Time.timeScale = 1f;
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
    }
    public void ExitHandler()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }
}
