using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startbutton : MonoBehaviour
{
    public List<string> mapname;
    public void click()
    {
        string map = mapname[Random.Range(0, mapname.Count)];
        SceneManager.LoadScene(map);
    }
}