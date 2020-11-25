using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Smert : MonoBehaviour {

    public GameObject spawn;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            other.transform.position = spawn.transform.position;
        }
    }
}
