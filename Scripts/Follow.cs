using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Follow : MonoBehaviour {
		
	public Transform Player;
	int MoveSpeed = 4;
	int MaxDist = 5;
	int MinDist = 2;


void Update()
	{
		transform.LookAt(Player);

		if (Vector3.Distance (transform.position, Player.position) >= MinDist) {

			transform.position += transform.forward * MoveSpeed * Time.deltaTime;
		}



			if (Vector3.Distance(transform.position, Player.position) <= MaxDist)
			{
				
			}
}
}