using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveToNextLvl1 : MonoBehaviour
{
  public int nextSceneLoad;
    // Start is called before the first frame update
    void Start()
    {
      nextSceneLoad = SceneManager.GetActiveScene().buildIndex + 1;
    }

    public void OnTriggerEnter2D(Collider2D coll)
    {
      if(coll.gameObject.tag == "Player")
      {

          //pindah level
          SceneManager.LoadScene(nextSceneLoad);

          if(nextSceneLoad > PlayerPrefs.GetInt("levelAt"))
          {
            PlayerPrefs.SetInt("levelAt", nextSceneLoad);
          }
      }
    }
}
