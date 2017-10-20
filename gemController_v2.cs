/*
+-----------------------------------------------------------+
/ Source file name: gemController.ca						/
/ Author’s name: Mehrdad Rezaieshirzad						/
/ Last Modified by: Mehrdad Rezaieshirzad					/                     
/ Date last Modified: October 16, 2017						/                       
/ Program description: This class responsibble for making	/  
/gems randomly in all over the game's scence				/
/Revision History: N/A										/
+-----------------------------------------------------------+
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gemController : MonoBehaviour {
	[SerializeField]
	private float speed = 5f;
	[SerializeField]
	private float startX;
	[SerializeField]
	private float endX;
	[SerializeField]
	private float startY = 84f;
	[SerializeField]
	private float endY = -84f;

	private Transform _transform;
	private Vector2 _currentPosition;
	// Use this for initialization
	void Start () {
		_transform = gameObject.GetComponent<Transform> ();
		_currentPosition = _transform.position;

		Reset ();
	}
	
	// Update is called once per frame
	void Update () {
		_currentPosition = _transform.position;
		_currentPosition -= new Vector2 (speed,0);

		if (_currentPosition.x < endX) {
			Reset ();
		}
		_transform.position = _currentPosition;
	}

}
