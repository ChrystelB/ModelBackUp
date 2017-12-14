using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LoadNew : MonoBehaviour {

    void OnTriggerEnter(Collider other){

        SceneManager.LoadScene("Swamp");
    
    }
  //  void ResetActions (){
        //Script.Action = null;
   //     MoveInput.KeyAction = null;
   // }
}






    /*    public void LoadLevel(string level){

            SceneManager.LoadScene(level);

void OnTriggerEnter(Collider other) {

     Application.LoadLevel("Level1");
}

        }
	*/
