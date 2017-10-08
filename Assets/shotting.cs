﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shotting : MonoBehaviour
{
    public GameObject SomPrefab;
    public float BulletSpeed;
    public GameObject QPrefab;
    public GameObject startpoint;
    public GameObject player;
    public float Qcooltime;
    public float Qnowofftime;
    public int maxbulletcount;
    public float bulletdelay;
    float delay;
    int bulletcount;

	// Use this for initialization
	void Start ()
    {
        bulletcount = maxbulletcount;
	}
	
	// Update is called once per frame
	void Update ()
    {
        joystick stick = GetComponent<joystick>();
		if ((stick.GetHorizontalValue() != 0.0f ||
            stick.GetVerticalValue() != 0.0f) &&
            delay>= bulletdelay)
        {
            Vector3 gameWorldpos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            GameObject newPrefab = Instantiate(SomPrefab);
            newPrefab.transform.position = startpoint.transform.position;
            newPrefab.GetComponent<bullet>().player = player;

            Vector2 direction = new Vector2(stick.GetHorizontalValue(), stick.GetVerticalValue());
            direction.Normalize();
            newPrefab.GetComponent<Rigidbody2D>().AddForce(direction * BulletSpeed);
            delay = 0.0f;
        }
        delay += Time.deltaTime;
        if (Input.GetKey(KeyCode.Q) && Qnowofftime <= 0)
        {
            Qnowofftime = Qcooltime;

            Vector3 gameWorldpos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            GameObject newPrefab = Instantiate(QPrefab);
            newPrefab.transform.position = transform.position;
            newPrefab.GetComponent<skill>().player = gameObject;

            Vector2 direction = gameWorldpos - transform.position;
            direction.Normalize();
            newPrefab.GetComponent<Rigidbody2D>().AddForce(direction * BulletSpeed);
        }

        if (Qnowofftime > 0.0)
        {
            Qnowofftime -= Time.deltaTime;
        }
    }
}