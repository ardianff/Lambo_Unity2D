using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TheWin : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter2D (Collider2D coll){
        if(coll.gameObject.tag== "Player"){
            SceneManager.LoadScene("winn");
        }
    }
    
}
