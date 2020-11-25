using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class GraphicSettings : MonoBehaviour {

    public Dropdown dropDown;

	// Use this for initialization
	void Start ()
    {
        //QualitySettings.names;
        dropDown.ClearOptions();
        dropDown.AddOptions(QualitySettings.names.ToList());
        QualitySettings.GetQualityLevel();
        dropDown.value = QualitySettings.GetQualityLevel();
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    public void SetQuality ()
    {
        QualitySettings.SetQualityLevel(dropDown.value); 
    }
}
