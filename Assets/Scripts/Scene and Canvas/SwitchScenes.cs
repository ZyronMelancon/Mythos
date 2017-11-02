using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScenes : MonoBehaviour {

    public void ChangetoGame()
    {
        SceneManager.LoadScene("MainGame");
    }

    public void ChangetoMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
