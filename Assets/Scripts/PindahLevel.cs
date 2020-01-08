using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PindahLevel : MonoBehaviour
{
    public int nextSceneLoad;
    // Start is called before the first frame update
    void Start()
    {
     nextSceneLoad = SceneManager.GetActiveScene().buildIndex +1;   
    }

    // Update is called once per frame
    public void OnTriggerEnter2D(Collider2D coll){
        if(coll.gameObject.tag == "Player"){
            SceneManager.LoadScene(nextSceneLoad);
            if(nextSceneLoad >PlayerPrefs.GetInt("levelAt")){
                PlayerPrefs.SetInt("levelAt", nextSceneLoad);
            }
        }
    }
}
