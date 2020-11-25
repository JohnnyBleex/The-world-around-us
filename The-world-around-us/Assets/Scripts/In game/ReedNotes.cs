using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class ReedNotes : MonoBehaviour {

    public GameObject NotDestr;
    public FirstPersonController first;
    public float distance;
    public AudioClip saund;
    public AudioSource sorce;
    public bool namb;
    public int schet;
    public Slider schetSlider;

    [SerializeField]
    private GameObject note;
    [SerializeField]
    private GameObject textNote;
    [SerializeField]
    private GameObject pictures;

    // Use this for initialization
    void Start ()
    {
        
        note.SetActive(false);
        namb = false;
    }
	
	// Update is called once per frame
	void Update ()
    {
        schetSlider.value = schet;
        if (Input.GetKeyDown(KeyCode.E))
        {
            ReedNote();
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (namb == true)
            {
                schet++;
                first.enabled = true;
                note.SetActive(false);
                sorce.PlayOneShot(saund);
                namb = false;
                Destroy(NotDestr);
            }
        }
    }

    void ReedNote()
    {
        Ray ray = Camera.main.ScreenPointToRay(new Vector2(Screen.width / 2, Screen.height / 2));
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, distance))
        {
            if (hit.collider.GetComponent<Note>())
            {
                NotDestr = (hit.collider.gameObject);
                namb = true;
                sorce.PlayOneShot(saund);
                first.enabled = false;
                note.SetActive(true);
                textNote.GetComponent<Text>().text = hit.collider.GetComponent<Note>().textNote;
                pictures.GetComponent<Image>().sprite = hit.collider.GetComponent<Note>().pictures;
            }
        }
    }
}