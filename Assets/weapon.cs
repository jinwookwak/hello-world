using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weapon : MonoBehaviour {
    public GameObject SomPrefab;
    public float BulletSpeed;
    public GameObject startpoint;
    public int maxbulletcount;
    public float bulletdelay;
    float delay;
    public GameObject player;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        joystick stick = GetComponent<joystick>();
        if ((stick.GetHorizontalValue() != 0.0f ||
            stick.GetVerticalValue() != 0.0f) &&
            delay >= bulletdelay)
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
    }
}
