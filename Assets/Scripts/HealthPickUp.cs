using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickUp : MonoBehaviour {

	public float healthAmount;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter2D(Collider2D coll){
		if(coll.tag == "Player"){
			PlayerHealth theHealth  = coll.gameObject.GetComponent<PlayerHealth>();
			theHealth.addHealth(healthAmount);
			Destroy(gameObject);
		}
	}
}
