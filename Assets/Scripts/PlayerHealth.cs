using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour {
	public float fullHealth;
	//public GameObject deathFX;
	float currentHealth;
	public AudioClip playerHurt;
	AudioSource playerAS;

	PlayerController playerControl;

	//Player Heart Bar
	public Slider heartBar;
	public Image damageScreen;
	bool damaged = false;
	Color damagedColour = new Color(5f,5f,0f,0.5f);
	float smoothColour = 5f;

	// Use this for initialization
	void Start () {
		currentHealth = fullHealth;
		playerControl = GetComponent<PlayerController>();

		//Heart Bar
		heartBar.maxValue=fullHealth;
		heartBar.value=fullHealth;

		playerAS =GetComponent<AudioSource>();

		damaged = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(damaged){
			damageScreen.color = damagedColour;
		}else{
			damageScreen.color = Color.Lerp(damageScreen.color, Color.clear,smoothColour*Time.deltaTime);
		}
		damaged = false;
		
	}

	public void addDamage(float damage){
		if(damage<=0) return;
		currentHealth = currentHealth - damage;
		//playerAS.clip =  playerHurt;
		//playerAS.Play(1);
		playerAS.PlayOneShot(playerHurt);
		heartBar.value = currentHealth;
		damaged = true;

		if(currentHealth<=0){
			makeDead();
		}
	}

	public void makeDead(){
		//Instantiate(deathFX, transform.position, transform.rotation);
	
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

	}
}
