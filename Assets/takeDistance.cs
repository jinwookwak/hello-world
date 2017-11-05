using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class takeDistance : MonoBehaviour {
    public GameObject ui;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        GetComponent<Text>().text = ui.GetComponent<Text>().text;
    }
}
