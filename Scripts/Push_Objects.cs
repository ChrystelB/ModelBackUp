﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Push_Objects : MonoBehaviour {

	public float pushForce = 2.0f;

	void OnControllerColliderHit(ControllerColliderHit hit) 
	{
		Rigidbody body = hit.collider.attachedRigidbody;

		if (body == null || body.isKinematic) {
			return;
		}
		if (hit.moveDirection.y < -0.3f) {
			return;
		}

		Vector3 pushDirection = new Vector3 (hit.moveDirection.x, 0, hit.moveDirection.z);

		body.velocity = pushDirection * pushForce;
	}





}