using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;

public class GUImanager : MonoBehaviour
{


    public void Play()
    {
      SceneManager.LoadScene("Level");
    }
    public void Exit()
    {
      Application.Quit();
    }
    public void OnMenu()
    {
      SceneManager.LoadScene(0);
    }

    void keluar()
    {
      Application.Quit();
    }

    public void Setting()
    {
      SceneManager.LoadScene("Setting");
    }

    public void OnCredit()
    {
      SceneManager.LoadScene("Credit");
    }
}
