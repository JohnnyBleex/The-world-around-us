using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;



public class Pause : MonoBehaviour {

    public FirstPersonController first;
    public GameObject HUD;
    public GameObject pause;

    void Start () {
        Time.timeScale = 1;
        Cursor.visible = false;
		
	}
	
	void Update () {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            first.enabled = !first.enabled;
            HUD.SetActive (!HUD.activeSelf);
            pause.SetActive (!pause.activeSelf);
            Cursor.visible = !Cursor.visible;
            if(Time.timeScale == 0.0f)
            {
                Time.timeScale = 1.0f;
            }
            else
            {
                Time.timeScale = 0.0f;

            }
        }
		
	}

    public void Continue()
    {
        first.enabled = true;
        HUD.SetActive (true);
        pause.SetActive (false);
        Time.timeScale = 1;
        Cursor.visible = false;
    }

    public void StartMenu()
    {
        Application.LoadLevel(0);
    }

    public void ExitGame()
    {
        Application.Quit();
    }

}
