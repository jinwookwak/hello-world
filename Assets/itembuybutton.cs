﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class itembuybutton : MonoBehaviour
{
    public string selecteditem;
    public int price;

	// Update is called once per frame
	void Update ()
    {
		if (PlayerPrefs.GetInt(selecteditem) == 1)
        {
            GetComponent<Text>().text = "장착";
        }
        else
        {
            GetComponent<Text>().text = "구매 " + price.ToString();
        }
	}
}