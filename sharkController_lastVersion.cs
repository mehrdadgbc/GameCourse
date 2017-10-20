/*
+-----------------------------------------------------------+
/ Source file name: sharkController.ca						/
/ Author’s name: Mehrdad Rezaieshirzad						/
/ Last Modified by: Mehrdad Rezaieshirzad					/                     
/ Date last Modified: October 16, 2017						/                       
/ Program description: This class responsibble for shark	/  
/action as the game's enemy									/
/Revision History: N/A										/
+-----------------------------------------------------------+
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sharkController : MonoBehaviour {
	[SerializeField]
	float minXSpeed = 3f;
	[SerializeField]
	float maxXSpeed = 6f;
	[SerializeField]
	float minYspeed = -2f;
	[SerializeField]
	float maxYSpeed = 2f;


	private Transform _transform;
	//because we will use the shark which has different speed
	private Vector2 _currentSpeed;
	private Vector2 _currentPosition;


	// Use this for initialization
	void Start () {
		_transform = gameObject.GetComponent<Transform> ();
		Reset ();
	}

	public void Reset(){
		//calculate new speed of shark because each time the rocket's speed must be changed RANDOMLY
		float xSpeed = Random.Range (minXSpeed, maxXSpeed);
		float ySpeed = Random.Range (minYspeed, maxYSpeed);

		//instantiate new speed for shark
		_currentSpeed = new Vector2 (xSpeed, ySpeed);

		//reset the shark position RANDOMLY 
		//calculating and instantiating new position for new shark
		float y = Random.Range (-150, 86);
		_transform.position = new Vector2(220 + Random.Range(0,100), y);
	}
	// Update is called once per frame
	void Update () {
		//first must updating current position
		_currentPosition = _transform.position;
		_currentPosition -= _currentSpeed;
		_transform.position = _currentPosition;

		if (_currentPosition.x <= -220) {
			Reset ();
		}
	}
}
