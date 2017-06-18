using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skill : MonoBehaviour
{
    public GameObject player;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            GameObject[] ai = GameObject.FindGameObjectsWithTag("ai");
            GameObject[] aibullet = GameObject.FindGameObjectsWithTag("aibullet");

            foreach (GameObject obj in ai)
            {
                if((obj.transform.position -transform.position).magnitude < 2.0f)
                {
                    Destroy(obj);
                }
            }

            foreach (GameObject obj in aibullet)
            {
                if ((obj.transform.position - transform.position).magnitude < 2.0f)
                {
                    Destroy(obj);
                }
            }

            Destroy(gameObject);
        }
    }


}