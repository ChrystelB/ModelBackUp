using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateTrigger : MonoBehaviour {

	public Transform Spawnpoint1;
	public Transform Spawnpoint2;
	public Transform Spawnpoint3;
	public Transform Spawnpoint4;
	public GameObject Prefab;
	

	private void OnTriggerEnter(){
		
		/*GameObject clone = (GameObject)*/ Instantiate (Prefab, Spawnpoint1.position, Spawnpoint1.rotation);
		Instantiate (Prefab, Spawnpoint2.position, Spawnpoint2.rotation);
		Instantiate (Prefab, Spawnpoint3.position, Spawnpoint3.rotation);
		Instantiate (Prefab, Spawnpoint4.position, Spawnpoint4.rotation);
		print ("Spawn");
		
	}
}
