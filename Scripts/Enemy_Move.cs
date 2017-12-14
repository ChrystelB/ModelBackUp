using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class Enemy_Move : MonoBehaviour {


	public NavMeshAgent agent;
	public Transform gameObject;
	
	void Update () {
		agent.destination = gameObject.position;
	}
}
