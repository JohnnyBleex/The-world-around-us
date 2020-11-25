using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Menu : MonoBehaviour {
	public GameObject settings;

	void Start()
	{
		Cursor.lockState = CursorLockMode.None; 
		Cursor.visible = true;
	}

	public void StartGame()
	{
		Application.LoadLevel (1);
	}

	public void Settings ()
	{
		settings.SetActive(!settings.activeSelf);
	}
	public void ExitGame()
	{
		Application.Quit ();
	}
}
