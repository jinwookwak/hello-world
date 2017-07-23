using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aibullet : MonoBehaviour {
    public GameObject ai;
    public float attack;
    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        float cameraheight = Camera.main.orthographicSize;
        float camerawidth = cameraheight * Camera.main.aspect;
        if (transform.position.x < -camerawidth || transform.position.x > +camerawidth)
        {
            Destroy(gameObject);
        }
        if (transform.position.y < -cameraheight || transform.position.y > + cameraheight)
        {
            Destroy(gameObject);
        }
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag != "ai" && collision.gameObject.tag != "aibullet" && collision.gameObject.tag != "wall")
        {
            Destroy(gameObject);
            move movecomponent = collision.gameObject.GetComponent<move>();
            if (movecomponent == null)
            {
                Destroy(collision.gameObject);
            }
            else
            {
                movecomponent.damage(attack);
            }
        }
    }      
}
