using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour {

    public GameObject Pers;
    public Texture2D kirka;
    public Texture2D zamok;
    [SerializeField]
    private NPCDialog questKomplite;
    void OnGUI()
    {
        if(Vector3.Distance(transform.position, Pers.transform.position) <= 6)
        {
            if(questKomplite.GetComponent<NPCDialog>().questKomplite == false )
            {
                GUI.DrawTexture(new Rect((Screen.width - 50) / 2, (Screen.height - 50) / 2, 80, 80), zamok);
            }
            if(questKomplite.GetComponent<NPCDialog>().questKomplite == true)
            {
                GUI.DrawTexture(new Rect((Screen.width - 50) / 2, (Screen.height - 50) / 2, 70, 70), kirka);
                GUIStyle stileTime = new GUIStyle();
                stileTime.fontSize = 20;
                stileTime.normal.textColor = Color.white;
                GUI.Label(new Rect((Screen.width - 50) / 2 - 20,(Screen.height - 50)/ 2 - 50, 80, 40), "Нажмите E", stileTime);
                if (Input.GetKeyDown(KeyCode.E))
                {
                    SceneManager.LoadScene(2);
                }
            }
        }
    }
}
