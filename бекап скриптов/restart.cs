using UnityEngine;
using UnityEngine.SceneManagement;

public class restart : MonoBehaviour
{
    void OnMouseDown()
    {
        SceneManager.LoadScene("1");
		FallDown.score=0;
    }
}
