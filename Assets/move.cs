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
        Vector2 velocity = new Vector2(0.0f, 0.0f);
        if (Input.GetKey(KeyCode.W))
        {
            velocity.y = 5.0f;
        }
        if (Input.GetKey(KeyCode.A))
        {
            velocity.x = -5.0f;
        }
        if (Input.GetKey(KeyCode.S))
        {
            velocity.y = -5.0f;
        }
        if (Input.GetKey(KeyCode.D))
        {
            velocity.x = 5.0f;
        }

        GetComponent<Rigidbody2D>().velocity = velocity;
        Vector3 Cameraposition = transform.position;
        Cameraposition.z = -10;
        Camera.main.transform.position = Cameraposition;
    }

}
