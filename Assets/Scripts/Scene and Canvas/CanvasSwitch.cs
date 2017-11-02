using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasSwitch : MonoBehaviour {

    public Canvas mainMenuCanvas;
    public Canvas controlsCanvas;

    public void MaintoControls()
    {
        mainMenuCanvas.enabled = false;
        controlsCanvas.enabled = true;
    }

    public void ControlstoMain()
    {
        mainMenuCanvas.enabled = true;
        controlsCanvas.enabled = false;
    }
}
