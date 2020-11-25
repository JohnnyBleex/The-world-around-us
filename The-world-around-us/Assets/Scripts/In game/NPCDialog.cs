using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class NPCDialog : MonoBehaviour {

    public FirstPersonController first;
    public float distance;
    public bool namb;
    public bool questKomplite;
    public GameObject notes;
    public GameObject questPanel;
    public GameObject questGiveBack;
    public GameObject questFinal;
    public GameObject pick;
    [SerializeField]
    public GameObject kirkaImage;

    [SerializeField]
    private ReedNotes schet;
    [SerializeField]
    private ReedNotes schetSlider;

    [SerializeField]
    private GameObject dialog;
    [SerializeField]
    private GameObject dialog2;
    //[SerializeField]
    //private GameObject questGiveBack;

    // Use this for initialization
    void Start () {
        questPanel.SetActive(false);
        questFinal.SetActive(false);
        notes.SetActive(false);
        dialog.SetActive(false);
        dialog2.SetActive(false);
        questKomplite = false;
        kirkaImage.SetActive(false);
        namb = false;

    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.E))
        {
            DialogAktive();
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (namb == true)
            {
                first.enabled = true;
                dialog.SetActive(false);
                dialog2.SetActive(false);
                namb = false;
            }
        }

    }

    void DialogAktive()
    {
        Ray ray = Camera.main.ScreenPointToRay(new Vector2(Screen.width / 2, Screen.height / 2));
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, distance))
        {
            if (hit.collider.GetComponent<NPC>())
            {
                if (schet.GetComponent<ReedNotes>().schet < 9)
                {
                    notes.SetActive(true);
                    namb = true;
                    first.enabled = false;
                    dialog.SetActive(true);
                    questPanel.SetActive(true);
                }
                if(schet.GetComponent<ReedNotes>().schet == 9)
                {
                    kirkaImage.SetActive(true);
                    questKomplite = true;
                    namb = true;
                    first.enabled = false;
                    dialog2.SetActive(true);
                    questPanel.SetActive(false);
                    questFinal.SetActive(true);
                    Destroy(pick);
                }
            }
        }
    }
}
