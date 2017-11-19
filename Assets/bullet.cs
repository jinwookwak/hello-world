using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour {
    public Sprite bulletr2Image;
    public Sprite bulletb1Image;
    public Sprite bulletg1Image;
    public Sprite bullety3Image;
    public Sprite bulletg3Image;
    public GameObject player;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (PlayerPrefs.GetString("equip") == "gun-r2")
        {
            GetComponent<SpriteRenderer>().sprite = bulletr2Image;
        }
        if (PlayerPrefs.GetString("equip") == "gun-b1")
        {
            GetComponent<SpriteRenderer>().sprite = bulletb1Image;
        }
        if (PlayerPrefs.GetString("equip") == "gun-g1")
        {
            GetComponent<SpriteRenderer>().sprite = bulletg1Image;
        }
        if (PlayerPrefs.GetString("equip") == "gun-y3")
        {
            GetComponent<SpriteRenderer>().sprite = bullety3Image;
        }
        if (PlayerPrefs.GetString("equip") == "gun-g3")
        {
            GetComponent<SpriteRenderer>().sprite = bulletg3Image;
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject != player && collision.gameObject.tag != "bullet" && collision.gameObject.tag != "wall")
        {
            if(collision.gameObject.tag=="ai")
            {
                PlayerPrefs.SetInt("money", PlayerPrefs.GetInt("money") + 100);
                player.GetComponent<move>().kill++;
            }
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
    }
}
