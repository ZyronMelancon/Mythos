using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreKeeper : MonoBehaviour {

    public int health = 100;
    public int score = 0;
    public Text healthText;
    public Text scoreText;
    public GameObject canvas;


	// Use this for initialization
	void Start ()
    {
        Time.timeScale = 1;
    }
	
	// Update is called once per frame
	void Update ()
    {

	}

    public void scoreUp(int points)
    {
        score += points;
        scoreText.text = score.ToString();
    }

    public void healthDown(int num)
    {
        health -= num;
        healthText.text = health.ToString();
        if (health <= 0)
        {
            canvas.active = true;
            Time.timeScale = 0;
        }
    }

    public void retry()
    {
        SceneManager.LoadScene("MainGame");
    }

    public void exit()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
