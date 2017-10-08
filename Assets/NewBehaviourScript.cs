using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {
    public AudioClip clip;

    // Use this for initialization
    void Start () {
        GetComponent<AudioSource>().clip = clip;

    }
	
	// Update is called once per frame
	void Update () {
        joystick stick = GetComponent<joystick>();
        if (stick.GetHorizontalValue() != 0.0f ||
            stick.GetVerticalValue() != 0.0f)
        {
            GetComponent<AudioSource>().Play();
        }
        else
        {
            GetComponent<AudioSource>().Stop();
        }
		
	}
}
