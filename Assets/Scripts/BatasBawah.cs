using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatasBawah : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D coll){
        if(coll.tag=="Player"){
            PlayerHealth theplayerHealth = coll.gameObject.GetComponent<PlayerHealth>();
            theplayerHealth.makeDead();
        }
    }
}
