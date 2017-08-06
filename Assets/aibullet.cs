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
