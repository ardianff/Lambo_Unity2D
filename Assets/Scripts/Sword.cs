using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : MonoBehaviour {

	public float scale_karak;
	public float damagesenjata;
	// Use this for initialization
	void Start () {
		scale_karak = GameObject.Find("player").transform.localScale.x;
	}

	// Update is called once per frame
	void Update () {
			if(scale_karak ==  1f){
				GetComponent<Rigidbody2D>().velocity = new Vector2(8f, GetComponent<Rigidbody2D>().velocity.y);
			}
			else{
				GetComponent<Rigidbody2D>().velocity = new Vector2(-8f, GetComponent<Rigidbody2D>().velocity.y);
			}


	}
		void OnTriggerEnter2D(Collider2D coll)
		{
			if(coll.gameObject.tag == "Batas"|| coll.gameObject.tag=="Ground")
			{
				Destroy(gameObject);
			}
				if(coll.gameObject.layer == LayerMask.NameToLayer("Enemy")){
					Destroy(gameObject);
					if(coll.gameObject.tag =="Enemy"){
						EnemyHealth hurtenemy = coll.gameObject.GetComponent<EnemyHealth>();
						hurtenemy.DiDor(damagesenjata);
					}
				}
			
		}
		void OnTriggerStay2D(Collider2D coll)
		{
			if(coll.gameObject.tag == "Batas"|| coll.gameObject.tag=="Ground")
			{
				Destroy(gameObject);
			}
				if(coll.gameObject.layer == LayerMask.NameToLayer("Enemy")){
					Destroy(gameObject);
					if(coll.gameObject.tag =="Enemy"){
						EnemyHealth hurtenemy = coll.gameObject.GetComponent<EnemyHealth>();
						hurtenemy.DiDor(damagesenjata);
					}
				}
			
		}
		// public void removeForce(){
		// 	GetComponent<Rigidbody2D>().velocity = new Vector2(0,0);
		// }
}
