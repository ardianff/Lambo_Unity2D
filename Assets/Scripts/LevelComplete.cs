using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour
{
    // Start is called before the first frame update
    public int nextSceneLoad;
    void Start()
    {
        nextSceneLoad = SceneManager.GetActiveScene().buildIndex +1;
    }

    // Update is called once per frame
    public void LoadNextLevel(){
        SceneManager.LoadScene(nextSceneLoad);
        if(nextSceneLoad >PlayerPrefs.GetInt("levelAt")){
            PlayerPrefs.SetInt("levelAt",nextSceneLoad);
        }
    }
}
