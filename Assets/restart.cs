using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class restart : MonoBehaviour {
    public GameObject ui;
	void Update () {
        GameObject[] ai = GameObject.FindGameObjectsWithTag("ai");
        GameObject[] player = GameObject.FindGameObjectsWithTag("player");
        if(player.Length == 0)
        {
            ui.SetActive(true);
        }
    }
}
