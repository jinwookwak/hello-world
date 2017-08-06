using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class restart : MonoBehaviour {
    public GameObject ui;
	void Update () {
        GameObject[] ai = GameObject.FindGameObjectsWithTag("ai");
        GameObject[] player = GameObject.FindGameObjectsWithTag("player");
        if(ai.Length == 0 || player.Length == 0)
        {
            ui.SetActive(true);
        }

        if(ai.Length == 0)
        {
            PlayerPrefs.SetInt("money", PlayerPrefs.GetInt("money") + 1000);
        }
    }
}
