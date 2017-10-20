/*
+-----------------------------------------------------------+
/ Source file name: Explosion.ca							/
/ Author’s name: Mehrdad Rezaieshirzad						/
/ Last Modified by: Mehrdad Rezaieshirzad					/                     
/ Date last Modified: October 16, 2017						/                       
/ Program description: This class responsibble for making	/  
/explosion while shark hits submarin.						/
/Revision History: N/A										/
+-----------------------------------------------------------+
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour {

	public void Destroyme(){
		Destroy(gameObject);
	}
}
