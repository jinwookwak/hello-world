using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPbar : MonoBehaviour {
    public GameObject player;
    public float xscale;
	// Use this for initialization
	void Start () {
        xscale = transform.localScale.x;
	}
	
	// Update is called once per frame
	void Update () {
        float HP = player.GetComponent<move>().HP;
        float rate = HP / player.GetComponent<move>().maxHP;
        Vector3 scale = transform.localScale;
        scale.x = rate * xscale;
        transform.localScale = scale;
    }
}
