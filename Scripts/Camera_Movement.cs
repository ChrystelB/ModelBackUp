using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Movement : MonoBehaviour {

    [SerializeField] private Camera camera;
    [SerializeField] private Transform target1;
    [SerializeField] private Transform target2;
   
    void OnTriggerEnter(Collider other) {
        camera.gameObject.transform.position = target1.position;
        camera.gameObject.transform.rotation = target1.rotation;
        print(other.gameObject.name + " has been triggered");
    }
 
    void OnTriggerExit(Collider other) {
        camera.gameObject.transform.position = target2.position;
        camera.gameObject.transform.rotation = target2.rotation;
        print("ObjectExit");
    }
}