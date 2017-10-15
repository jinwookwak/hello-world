using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeWeapon : MonoBehaviour {
    public Sprite gunsprite;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (PlayerPrefs.GetInt("gun") == 1)
        {
            GetComponent<SpriteRenderer>().sprite = gunsprite;
        }
    }
}
