using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Place on weapon so that the weapon becomes parented, but also has a StartPoint that it can respawn at.
[System.Serializable]
public class Weapon : MonoBehaviour {

	public Transform startPoint;
	public Transform weapon;

	public Transform player;

	public void ReturnWeapon ()
	{
		weapon.parent = null;
		weapon.position = startPoint.position;
	}
	
	public void PickUpWeapon (Transform _parent)
	{
		weapon.parent = _parent;
	
	}
}
