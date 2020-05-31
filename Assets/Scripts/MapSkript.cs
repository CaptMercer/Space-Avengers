using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MapSkript : MonoBehaviour
{
	public string lvl;
    void OnMouseDown()
    {
   SceneManager.LoadScene(lvl);
    }
}
