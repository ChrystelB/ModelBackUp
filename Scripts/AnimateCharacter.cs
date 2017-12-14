using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimateCharacter : MonoBehaviour {

public Animator animator;
public float speed;
public static bool Crouching;

void Start(){
	animator = GetComponent<Animator>();
	MoveInput.KeyAction += animate;
}

    private void animate(float obj)
    {
        animator.SetFloat("Speed", Mathf.Abs(obj));
        animator.SetBool("Crouching", Crouching);
    }
}
