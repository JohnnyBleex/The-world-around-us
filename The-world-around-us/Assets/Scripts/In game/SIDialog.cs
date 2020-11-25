using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class SIDialog : MonoBehaviour {

    public FirstPersonController first;
    public float distance;
    public GameObject startInfo;


    // Use this for initialization
    void Start () {
        startInfo.SetActive(false);
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.E))
        {
            DialogAktive();
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            startInfo.SetActive(false);
            first.enabled = true;
        }
		
	}

    void DialogAktive()
    {
        Ray ray = Camera.main.ScreenPointToRay(new Vector2(Screen.width / 2, Screen.height / 2));
        RaycastHit hit;
        if(Physics.Raycast(ray, out hit, distance))
        {
            if (hit.collider.GetComponent<StartInfoTable>())
            {
                startInfo.SetActive(true);
                first.enabled = false;
            }
        }
    }
}
