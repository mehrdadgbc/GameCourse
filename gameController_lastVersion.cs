﻿/*
+-----------------------------------------------------------+
/ Source file name: gameController.ca						/
/ Author’s name: Mehrdad Rezaieshirzad						/
/ Last Modified by: Mehrdad Rezaieshirzad					/                     
/ Date last Modified: October 16, 2017						/                       
/ Program description: This class responsibble for 			/  
/updating UI and keep trace of score and life				/
/Revision History: N/A										/
+-----------------------------------------------------------+
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//adding necessary usings
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class gameController : MonoBehaviour {
	[SerializeField]
	Text lifeLable;
	[SerializeField]
	Text scoreLable;
	[SerializeField]
	Text gameOverLable;
	[SerializeField]
	Text highScoreLable;
	[SerializeField]
	Button resetButton;

	private int _score = 0;
	private int _life = 2;

	public int Score {
		get{ return _score; }
		set { 
			_score = value;
			scoreLable.text = "Score: " + _score;
		}
	}
		public int Life{
			get{ return _life;}
			set{
				_life = value;

				if(_life <=0){
					//game over
				GameOver();
				}
				else{
					lifeLable.text = "Life: " + _life;
				}
			}

		}

	//making visibale and invisibaling the lables regarding thegame status
	private void initialize(){
		Score = 0;
		Life = 2;
		gameOverLable.gameObject.SetActive (false);
		highScoreLable.gameObject.SetActive (false);
		resetButton.gameObject.SetActive (false);
		lifeLable.gameObject.SetActive (true);
		scoreLable.gameObject.SetActive (true);
	}

	private void GameOver(){
		gameOverLable.gameObject.SetActive (true);
		highScoreLable.gameObject.SetActive (true);
		resetButton.gameObject.SetActive (true);
		lifeLable.gameObject.SetActive (false);
		scoreLable.gameObject.SetActive (false);


		//printing high score on the screen
		highScoreLable.text = "High Score: " + Score;
	}

	// Use this for initialization
	void Start () {
		initialize ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void ResetBtnClick(){
		SceneManager.LoadScene (SceneManager.GetActiveScene ().name);

	}
}
