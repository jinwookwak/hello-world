using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shotting : MonoBehaviour
{
    public GameObject SomPrefab;
    public float BulletSpeed;
    public GameObject QPrefab;
    public GameObject startpoint;
    public float Qcooltime;
    public float Qnowofftime;
    public int maxbulletcount;
    int bulletcount;

	// Use this for initialization
	void Start () {
        bulletcount = maxbulletcount;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0) && bulletcount >0)
        {
            bulletcount -= 1;
            Vector3 gameWorldpos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            GameObject newPrefab = Instantiate(SomPrefab);
            newPrefab.transform.position = startpoint.transform.position;
            newPrefab.GetComponent<bullet>().player = gameObject;

            Vector2 direction = gameWorldpos - transform.position;
            direction.Normalize();
            newPrefab.GetComponent<Rigidbody2D>().AddForce(direction * BulletSpeed);
        }

        if (Input.GetKey(KeyCode.E))
        {
            bulletcount = maxbulletcount;
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