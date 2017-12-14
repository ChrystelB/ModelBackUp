using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transport : MonoBehaviour {

	public Transform player;
	public Transform SpawnPoint;

	void OnTriggerEnter (Collider other)
	{
		if (other.tag == "Player") {
			player.transform.position = SpawnPoint.transform.position;
		}
	}
}