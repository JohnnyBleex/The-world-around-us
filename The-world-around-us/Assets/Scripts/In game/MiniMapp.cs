using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniMapp : MonoBehaviour {

    public GameObject mePlayer;

    public float distance = 100;

	// Update is called once per frame
	void LateUpdate ()
    {
        transform.position = mePlayer.transform.position + Vector3.up * distance;
	}
}
