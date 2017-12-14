using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Place on weapon so that it understands to be picked up.
public class ControlWeapon : MonoBehaviour {

	public Weapon myWeapon;

 void OnTriggerEnter (Collider _obj)
 {
	 if (_obj.tag == "Player")
	 {
		 myWeapon.PickUpWeapon(_obj.transform);
	 }
	 else
	 {
		 print(_obj);
		 myWeapon.ReturnWeapon();
	 }
 }
}
