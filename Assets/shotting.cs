using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shotting : MonoBehaviour
{
    public GameObject SomPrefab;
    public float BulletSpeed;
    public GameObject QPrefab;
    public float Qcooltime;
    public float Qnowofftime;

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
            newPrefab.GetComponent<bullet>().player = gameObject;

            Vector2 direction = gameWorldpos - transform.position;
            direction.Normalize();
            newPrefab.GetComponent<Rigidbody2D>().AddForce(direction * BulletSpeed);
        }

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