﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aibullet : MonoBehaviour {
    public GameObject ai;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject != ai)
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
    }
}