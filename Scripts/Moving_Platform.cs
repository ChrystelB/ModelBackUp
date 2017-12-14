using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving_Platform : MonoBehaviour {


		public Vector3 movement;
		public float rightLimit = 1;
		public float leftLimit = 1;
		public float speed = 2.0f;
		private int direction = 1;


		void Update () {
			if (transform.position.x > rightLimit) {
				direction = -1;
			}
			else if (transform.position.x < leftLimit) {
				direction = 1;
			}
			movement = Vector3.right * direction * speed * Time.deltaTime; 
			transform.Translate(movement); 
		}
}




	/*
	public Transform platformUsing;
	public float platformSpeed;
	void Update(){
		platformUsing.transform.position += new Vector3(platformSpeed*Time.deltaTime, 0, 0);
	}

	void OnTriggerEnter (Collider other) {
		if (other.tag == "Barrier"){
			platformSpeed = -platformSpeed;
			print("Switching Direction");
		}
	}

}
*/