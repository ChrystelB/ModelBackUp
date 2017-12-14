using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class PlayButton : MonoBehaviour {

	//public static Action Play;

	public void Start () {
//		Play();
		Invoke("TurnOffButton", 0.5f);
		print("Play button was enabled");
	}

	void TurnOffButton () {
		GetComponent<Button>().interactable = false;
	}
	
}
