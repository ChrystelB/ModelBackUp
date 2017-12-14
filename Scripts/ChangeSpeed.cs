using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ChangeSpeed : MonoBehaviour {

	
	public float slowSpeed = 30;
	public float standardSpeed = 5;

	public static Action<float> Speed; 

	void OnTriggerEnter () {
		Speed(slowSpeed);
	}
	void OnTriggerExit (){
		Speed(standardSpeed);
	}
}
