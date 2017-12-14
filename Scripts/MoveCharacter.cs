using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]

public class MoveCharacter : MonoBehaviour {

	CharacterController cc;
	Vector3 tempMove;
    public float speed = 5;
    public float gravity = 1;
    public float jumpHeight = 0.2f;
	int CurrentJump = 0;
	public int jumpamt = 2;


    void Start () {
		cc = GetComponent<CharacterController>();
//		PlayButton.Play += OnPlay;

		OnPlay();
	}

	void OnPlay () {
		MoveInput.JumpAction = DoubleJump;
		MoveInput.KeyAction += Move;
//		PlayButton.Play -= OnPlay;
		ChangeSpeed.Speed = SendSpeedHandler;
		MoveInput.CrouchAction += Crouch;
		MoveInput.StandAction += Stand;
	}

	void Crouch()
	{
		transform.localScale = new Vector3(1, .5f, 1);
		
	}

	void Stand()
	{
		transform.localScale = new Vector3(1, 2, 1);

	}

	private void SendSpeedHandler(float _speed)
	{
		speed = _speed;
	}
		
	private void DoubleJump ()
	{

		if (cc.isGrounded) 
		{
			CurrentJump = 0;
		}
		if (CurrentJump < jumpamt)
		{
			tempMove.y = jumpHeight;
			CurrentJump++;
		}
	}

	void Move (float _movement) {
		tempMove.y -= gravity*Time.deltaTime;
		tempMove.x = _movement*speed*Time.deltaTime;
		cc.Move(tempMove);
	}
	
}

