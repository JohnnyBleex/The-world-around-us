using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    public GameObject Pers;
    public Texture2D dialog;

    // Use this for initialization
    void Start()
    {
        //questGiveBack.SetActive(false);
    }
    // Update is called once per frame
    void OnGUI()
    {
        GUIStyle myStyle = new GUIStyle();
        if (Vector3.Distance(transform.position, Pers.transform.position) <= 3)
        {
            GUI.DrawTexture(new Rect((Screen.width - 50) / 2, 15, 50, 40), dialog);
            GUIStyle stileTime = new GUIStyle();
            stileTime.fontSize = 20;
            stileTime.normal.textColor = Color.white;
            GUI.Label(new Rect((Screen.width - 50) / 2 - 20, 55, 80, 40), "Нажмите E", stileTime);
        }
    }
}
