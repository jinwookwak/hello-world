using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0.0f, 5.0f * Time.deltaTime, 0.0f);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-5.0f * Time.deltaTime, 0.0f, 0.0f);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0.0f, -5.0f * Time.deltaTime, 0.0f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(5.0f * Time.deltaTime, 0.0f, 0.0f);
        }
	}

}
