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
        transform.Translate(Random.insideUnitCircle * Speed * Time.deltaTime);
        float cameraheight = Camera.main.orthographicSize;
        float camerawidth = cameraheight * Camera.main.aspect;
        float x = Mathf.Clamp(transform.position.x, -camerawidth, +camerawidth);
        float y = Mathf.Clamp(transform.position.y, -cameraheight, +cameraheight);
        transform.position = new Vector3(x, y, 0);
    }
    }
