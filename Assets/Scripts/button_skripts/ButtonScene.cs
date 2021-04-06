using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScene : MonoBehaviour
{
  public  void OpenScene(int sceneNumber)
    {
        SceneManager.LoadScene(sceneNumber);//запуск бесконечноо режима карту которого я пока не сдела по этому запускается карта 0 
    }
}
