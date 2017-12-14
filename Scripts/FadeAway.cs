using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeAway : MonoBehaviour {

	Image Logo;

	void Start ()
	{
		Logo = GetComponent<Image>();
		StartCoroutine(Fade());
	}
	IEnumerator Fade(){
		
		yield return new WaitForSeconds(3);
		Logo.CrossFadeAlpha(0,2,false);
		
	}
}
