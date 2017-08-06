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

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject != player && collision.gameObject.tag != "bullet" && collision.gameObject.tag != "wall")
        {
            if(collision.gameObject.tag=="ai")
            {
                PlayerPrefs.SetInt("money", PlayerPrefs.GetInt("money") + 100);
            }
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
    }
}
