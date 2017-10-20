/*
+-----------------------------------------------------------+
/ Source file name: subMarinCollisionController.ca			/
/ Author’s name: Mehrdad Rezaieshirzad						/
/ Last Modified by: Mehrdad Rezaieshirzad					/                     
/ Date last Modified: October 16, 2017						/                       
/ Program description: This class responsibble for collision/  
/shark with submarine and gathering gems by submarine		/
/Revision History: N/A										/
+-----------------------------------------------------------+
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class subMarinCollisionController : MonoBehaviour {
	[SerializeField]
	gameController myGameController;
	[SerializeField]
	GameObject explosion;

	private AudioSource _gemSound;
	private AudioSource _sharkExplosionSound;

	// Use this for initialization
	void Start () {
		_gemSound = gameObject.GetComponent<AudioSource> ();
		_sharkExplosionSound = gameObject.GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnTriggerEnter2D(Collider2D other){
		//detecting different collision "gem' or "shark"
		if (other.gameObject.tag.Equals ("gem")) {
			Debug.Log ("Hu Aa! We Grab A Gem\n");
			if (_gemSound != null) {
				_gemSound.Play ();
			}
			//dissapearig the gems
			other.gameObject.GetComponent<gemController>().Disappear();

			//adding point
			myGameController.Score += 1250;

		} else if (other.gameObject.tag.Equals ("enemy")) {
			Debug.Log ("Ohhhh shoot. Shark is here\n");
			//adding sound later on

			//instantiang explosion based on "GameObject explosion" 
			Instantiate (explosion)
				.GetComponent<Transform> ()
				.position = other.gameObject
					.GetComponent<Transform> ().position; 

			//explosion sound
			if (_sharkExplosionSound != null) {
				_sharkExplosionSound.Play ();
			}

			//for making enemy disapear after collision
			other.gameObject.GetComponent<sharkController>().Reset();

			//subtracting lives
			myGameController.Life -= 1;
		}
	
	}

}
