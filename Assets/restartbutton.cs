﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restartbutton : MonoBehaviour {
    public void click()
    {
        SceneManager.LoadScene("readypage");
    }
}
