﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeWeapon : MonoBehaviour {
    public Sprite gunr2Image;
    public Sprite gunb1Image;
    public Sprite gung1Image;
    public Sprite guny3Image;
    public Sprite gung3Image;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (PlayerPrefs.GetString("equip") == "gun-r2")
        {
            GetComponent<SpriteRenderer>().sprite = gunr2Image;
        }
        if (PlayerPrefs.GetString("equip") == "gun-b1")
        {
            GetComponent<SpriteRenderer>().sprite = gunb1Image;
        }
        if (PlayerPrefs.GetString("equip") == "gun-g1")
        {
            GetComponent<SpriteRenderer>().sprite = gung1Image;
        }
        if (PlayerPrefs.GetString("equip") == "gun-y3")
        {
            GetComponent<SpriteRenderer>().sprite = guny3Image;
        }
        if (PlayerPrefs.GetString("equip") == "gun-g3")
        {
            GetComponent<SpriteRenderer>().sprite = gung3Image;
        }
    }
}
