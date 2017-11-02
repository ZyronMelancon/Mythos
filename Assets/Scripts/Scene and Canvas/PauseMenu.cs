using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour {

    public Canvas Pause;
    public bool paused = false;

    private void Start()
    {
        paused = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P) && paused == false)
        {
            paused = true;
            Pause.enabled = true;
            Time.timeScale = 0;
        }
        else if (Input.GetKeyDown(KeyCode.P) && paused == true)
        {
            paused = false;
            Pause.enabled = false;
            Time.timeScale = 1;
        }
    }
}
