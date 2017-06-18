using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour {

    public GameObject player;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float cameraheight = Camera.main.orthographicSize;
        float camerawidth = cameraheight * Camera.main.aspect;
        if (transform.position.x < -camerawidth || transform.position.x > +camerawidth)
        {
            Destroy(gameObject);
        }
        if (transform.position.y < -cameraheight || transform.position.y > +cameraheight)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject != player && collision.gameObject.tag != "bullet")
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
    }
}
