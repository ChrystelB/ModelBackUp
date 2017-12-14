/* 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class Enemy_Patrol : MonoBehaviour {


	public NavMeshAgent agent;
	public Transform gameObject;
	public Transform gameObject2;
	
	void Update () {
		agent.destination = gameObject.position;
	}
}
*/