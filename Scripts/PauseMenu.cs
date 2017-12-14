
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour {

public GameObject PauseButton;
public GameObject NormalMenu;
		
	public void OnPause()
    {
        Time.timeScale = 0;
        PauseButton.SetActive(true);
        NormalMenu.SetActive(false);
    }

    public void OffPause()
    {
        Time.timeScale = 1;
        PauseButton.SetActive(false);
        NormalMenu.SetActive(true);
    }
}
