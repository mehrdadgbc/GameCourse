/*
+-----------------------------------------------------------+
/ Source file name: subMarineController.ca					/
/ Author’s name: Mehrdad Rezaieshirzad						/
/ Last Modified by: Mehrdad Rezaieshirzad					/                     
/ Date last Modified: October 16, 2017						/                       
/ Program description: This class responsibble for submarine/  
/functionality including up-down and right-left direction	/
/Revision History: N/A										/
+-----------------------------------------------------------+
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class subMarinController : MonoBehaviour {
	[SerializeField]
	private float speed = 7f;
	[SerializeField]
	private float upY;
	[SerializeField]
	private float downY;

	[SerializeField]
	private float leftX;
	[SerializeField]
	private float rightX;

	private Transform _transform;
	private Vector2 _currentPosition;

	// Use this for initialization
	void Start () {
		_transform = gameObject.GetComponent<Transform> ();
		_currentPosition = _transform.position;

	}
	
	// Update is called once per frame
	void Update () {
		_currentPosition = _transform.position;

		float userInputV = Input.GetAxis ("Vertical");
 
		if(userInputV<0)
		{
			//if left arrow is pressed move down
			_currentPosition -= new Vector2(0, speed);
		}
		if(userInputV>0)
		{
			//if roght arrow is pressed move up
			_currentPosition += new Vector2(0, speed);
		}

		CheckBoundry ();
		_transform.position = _currentPosition;



	}

	//method for moving up and down_ right and left
	private void CheckBoundry(){
		if (_currentPosition.y < downY) {

			_currentPosition.y = downY;
		}
		if (_currentPosition.y > upY) {
			
			_currentPosition.y = upY;
		}

		if (_currentPosition.x < leftX) {
			_currentPosition.x = leftX;
		}
		if (_currentPosition.x > rightX) {
			_currentPosition.x = rightX;
		}

	}

}
