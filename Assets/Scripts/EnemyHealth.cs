using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour {
	public float enemyhealth;
	float currhealth;

	// Use this for initialization
	void Start () {
		currhealth = enemyhealth;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void DiDor(float damage){
		currhealth = currhealth - damage;
		if(currhealth<=0){
			makeDead();
		}
	}
	public void makeDead(){
		Destroy(gameObject);
	}
}
