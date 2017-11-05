using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moving : MonoBehaviour {
    public float Speed = 15;
	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody2D>().velocity = Random.insideUnitCircle * Speed;
        if(GetComponent<Rigidbody2D>().velocity.x > 0)
        {
            GetComponent<SpriteRenderer>().flipX = true;
        }
        if(GetComponent<Rigidbody2D>().velocity.x < 0)
        {
            GetComponent<SpriteRenderer>().flipX = false;
        }


    }
    }
