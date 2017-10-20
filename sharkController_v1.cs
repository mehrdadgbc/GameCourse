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
		
	}

	public void Reset(){
		//calculate new speed of shark because each time the rocket's speed must be changed RANDOMLY
		float xSpeed = Random.Range (minXSpeed, maxXSpeed);
		float ySpeed = Random.Range (minYspeed, maxYSpeed);

		//instantiate new speed for shark
		_currentSpeed = new Vector2 (xSpeed, ySpeed);

	}
	// Update is called once per frame
	void Update () {

	}
}
