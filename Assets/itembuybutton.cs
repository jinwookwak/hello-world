using System.Collections;
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
        if (PlayerPrefs.GetString("equip") == selecteditem)
        {
            GetComponent<Text>().text = "장착중";
        }
		else if (PlayerPrefs.GetInt(selecteditem) == 1)
        {
            GetComponent<Text>().text = "장착";
        }
        else
        {
            GetComponent<Text>().text = "구매 " + price.ToString();
        }
	}
    public void click()
    {

        if (PlayerPrefs.GetInt(selecteditem) == 1)
        {
            PlayerPrefs.SetString("equip", selecteditem);
            return;
        }

        if (PlayerPrefs.GetInt("money") < price)
            return;

        PlayerPrefs.SetInt("money", PlayerPrefs.GetInt("money") - price);

        PlayerPrefs.SetInt(selecteditem, 1);
    }
}
