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
    public void OnPlay()
    {
      SceneManager.LoadScene("Main");
    }
    public void OnLevel()
    {
      SceneManager.LoadScene("Level");
    }
}
