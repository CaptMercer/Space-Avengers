using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;
using UnityEngine.SceneManagement;
public class toMenu_Safe : MonoBehaviour
{
    void OnMouseDown()
    {
        SceneManager.LoadScene("menu");
    }
}
