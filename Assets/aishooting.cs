using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aishooting : MonoBehaviour {
    public GameObject SomPrefab;
    public float BulletSpeed;
    public GameObject player;
    float time;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        time += Time.deltaTime;
        if (time > 1.0f)
        {
            time = 0.0f;
            Vector3 gameWorldpos = player.transform.position;

            GameObject newPrefab = Instantiate(SomPrefab);
            newPrefab.transform.position = transform.position;
            newPrefab.GetComponent<aibullet>().ai = gameObject;

            Vector2 direction = gameWorldpos - transform.position;
            direction.Normalize();
            newPrefab.GetComponent<Rigidbody2D>().AddForce(direction * BulletSpeed);
        }
	}
}
