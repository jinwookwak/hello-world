using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cooltimeui : MonoBehaviour {
    public GameObject player;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        int cooltime = (int)player.GetComponent<PlayerControllerScript>().distance;

        GetComponent<Text>().text = cooltime.ToString();
	}
}
