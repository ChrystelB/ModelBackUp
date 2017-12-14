using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EatenByBear : MonoBehaviour {

	public Transform box;
	public bool tBox = false;

	void  OnTriggerEnter(Collider player) {
		if (!tBox)
		{
				tBox = true;
				box.transform.parent = player.transform;
		}
		else
		{
				Destroy(box.gameObject, 5);
		}
		}
	}	
