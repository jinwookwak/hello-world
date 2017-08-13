using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class itemselectbutton : MonoBehaviour
{
    public Sprite itemimage;
    public string itemname;
    public int price;
    public GameObject preview;
    public GameObject buybutton;

    public void click()
    {
        preview.GetComponent<Image>().sprite = itemimage;
        buybutton.GetComponent<itembuybutton>().selecteditem = itemname;
        buybutton.GetComponent<itembuybutton>().price = price;
    }
}
