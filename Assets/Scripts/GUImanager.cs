using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;

public class GUImanager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnLvl1()
    {
      SceneManager.LoadScene("level1");
    }
    public void OnLvl2()
    {
      SceneManager.LoadScene("level2");
    }
    public void OnLvl3()
    {
      SceneManager.LoadScene("level3");
    }
    public void OnLvl4()
    {
      SceneManager.LoadScene("level4");
    }
    public void OnLvl5()
    {
      SceneManager.LoadScene("level5");
    }
    public void OnLvl6()
    {
      SceneManager.LoadScene("level6");
    }
    public void OnLevel()
    {
      SceneManager.LoadScene("Level");
    }
    public void OnMenu()
    {
      SceneManager.LoadScene("Menu");
    }
}
