using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object_Fall : MonoBehaviour {

public Rigidbody wall;


	void Start () {
		
	}
	
	public void OnTriggerEnter ()
	{
		wall.isKinematic = false;
	}
}
