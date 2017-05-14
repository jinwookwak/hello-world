using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shotting : MonoBehaviour
{
    public GameObject SomPrefab;
    public float BulletSpeed;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0))
        {
            Vector3 gameWorldpos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            GameObject newPrefab = Instantiate(SomPrefab);
            newPrefab.transform.position = transform.position;

            Vector2 direction = gameWorldpos - transform.position;
            direction.Normalize();
            newPrefab.GetComponent<Rigidbody2D>().AddForce(direction * BulletSpeed);
        }
	}
}
