using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class achievement : MonoBehaviour {
    public string key;
    public List<int> require;
    public List<int> reward;
    public int nowlevel;
    public Text desc;
    public Text rewarddesc;
    public string descstr;
	// Use this for initialization
	void Start () {
        nowlevel = PlayerPrefs.GetInt(key + "level");
	}
    void Update()
    {
        if (nowlevel >= require.Count)
        {
            desc.text = "모든 보상을 다 받았습니다.";
            rewarddesc.text = "";
            return;
        }
        desc.text = descstr + require[nowlevel].ToString();
        rewarddesc.text = reward[nowlevel].ToString() + "\n받기";
    }
	
	public void click()
    {
        if(nowlevel >= require.Count)
        {
            return;
        }
        if(PlayerPrefs.GetInt(key)<require[nowlevel])
        {
            return;
        }
        nowlevel++;
        PlayerPrefs.SetInt("money", PlayerPrefs.GetInt("money") + reward[nowlevel]);
        PlayerPrefs.SetInt(key + "level", nowlevel);
    }
}
