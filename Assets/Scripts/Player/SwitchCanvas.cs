using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchCanvas : MonoBehaviour {

    public Canvas currentCanvas;
    public Canvas nextCanvas;

    public void Start()
    {

    }
    public void SwitchScenes()
    {
        currentCanvas.enabled = false;
        nextCanvas.enabled = true;
    }

    public void LoadScene()
    {
        SceneManager.LoadScene("MainGame");
        currentCanvas.enabled = false;
    }
}
