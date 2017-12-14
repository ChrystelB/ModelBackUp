using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset : MonoBehaviour {

	public Transform startPoint;
	
	//public GameObject art;

	void Start (){
		EndGame.End += ResetThis;
	}

	void ResetThis (){

		transform.position = startPoint.position;

	}

}
