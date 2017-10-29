using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class iteminfo
{
    public Sprite itemimage;
    public string itemname;
    public int price;
}



public class itemselectbutton : MonoBehaviour
{
    public List<iteminfo> itemlist;
    public int index;
    public GameObject preview;
    public GameObject buybutton;

    void Start()
    {
        click();
    }

    public void click()
    {
        preview.GetComponent<Image>().sprite = itemlist[index].itemimage;
        buybutton.GetComponent<itembuybutton>().selecteditem = itemlist[index].itemname;
        buybutton.GetComponent<itembuybutton>().price = itemlist[index].price;
    }

    public void prev()
    {
        index--;
        if (index < 0)
        {
            index += itemlist.Count;
        }
        click();
    }
    public void next()
    {
        index = (index + 1) % itemlist.Count;
        click();
    }
}
