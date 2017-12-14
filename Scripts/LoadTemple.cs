using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LoadTemple : MonoBehaviour {

	void OnTriggerEnter(Collider other){

		SceneManager.LoadScene("Temple");

	}
}
