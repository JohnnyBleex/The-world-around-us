using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalMenu : MonoBehaviour {

    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
    public void StartGame () {
        Application.LoadLevel(0);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
