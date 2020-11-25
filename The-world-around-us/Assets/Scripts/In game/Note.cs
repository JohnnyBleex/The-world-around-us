using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note : MonoBehaviour
{

    public GameObject Pers;
    public Texture2D give;

    public Sprite pictures;

    [TextArea(10, 40)]
    public string textNote;

    void OnGUI()
    {
        GUIStyle myStyle = new GUIStyle();
        if (Vector3.Distance(transform.position, Pers.transform.position) <= 2)
        {
            GUI.DrawTexture(new Rect((Screen.width - 50) / 2, 15, 50, 40), give);
            GUIStyle stileTime = new GUIStyle();
            stileTime.fontSize = 20;
            stileTime.normal.textColor = Color.white;
            GUI.Label(new Rect((Screen.width - 50) / 2 - 20, 55, 80, 40), "Нажмите E", stileTime);
        }

    }
}
