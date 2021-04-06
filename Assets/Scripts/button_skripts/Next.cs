using UnityEngine;
using UnityEngine.SceneManagement;
public class Next : MonoBehaviour
{
    public void NextLevel()
   {
        Time.timeScale = 1f;
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.buildIndex+1);
    }
}
