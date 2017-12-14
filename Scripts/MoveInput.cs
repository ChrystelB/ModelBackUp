using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class MoveInput : MonoBehaviour {

	public float runTime = 0.01f;
	public bool canPlay = true;
	public static Action<float> KeyAction;
	public static Action JumpAction;
	public static Action CrouchAction;
	public static Action StandAction;


	private void Start()
	{
		StartCoroutine(RunInput());

	}

	IEnumerator RunInput( ){

		while (canPlay)
		{
			if(Input.GetKeyDown(KeyCode.Space))
			{
					JumpAction();
			}
			if (Input.GetKeyDown(KeyCode.DownArrow)) 
			{
					CrouchAction();
					AnimateCharacter.Crouching = true;
			}
			if (Input.GetKeyUp(KeyCode.DownArrow))
			{
				StandAction();
				AnimateCharacter.Crouching = false;
			}
			if (KeyAction != null)
		{
			KeyAction(Input.GetAxis("Horizontal"));
		} 
		yield return new WaitForSeconds(runTime);
		}
	}
	void Awake () {
         DontDestroyOnLoad (transform.gameObject);
     }
}
