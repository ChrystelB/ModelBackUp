using UnityEngine;
using UnityEngine.SceneManagement;

public class BeginLevel : MonoBehaviour {

        public void LoadLevel(string level){

            SceneManager.LoadScene(level);
            print("BeginGame");

/*        }
        public staitc void (Array level){
            

*/
        }
	
}