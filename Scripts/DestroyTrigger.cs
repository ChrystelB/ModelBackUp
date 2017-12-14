using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTrigger : MonoBehaviour {

	public GameObject Wall; 

	void OnTriggerEnter() {

		Destroy(Wall);
		print ("Destroy");
	}

	}
