﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyColorBehaviour : MonoBehaviour {

    public int colorType;

    public GameObject Phys;
    public ParticleSystem trailParticle;
    public ParticleSystem explode;
    public GameObject pointLight;

    public float startSpeed;

	// Use this for initialization
	void Start ()
    {
        colorType = Random.RandomRange(0, 3);

        switch (colorType)
        {
            case 0:
                pointLight.GetComponent<Light>().color = new Color(1, 0.4f, 0.6f);
                explode.startColor = new Color(1, 0.4f, 0.6f);
                trailParticle.startColor = new Color(1, 0.4f, 0.6f);
                break;
            case 1:
                pointLight.GetComponent<Light>().color = new Color(0.3f, 1, 0.7f);
                explode.startColor = new Color(0.3f, 1, 0.7f);
                trailParticle.startColor = new Color(0.3f, 1, 0.7f);
                break;
            case 2:
                pointLight.GetComponent<Light>().color = new Color(0.3f, 0.6f, 1);
                explode.startColor = new Color(0.3f, 0.8f, 1);
                trailParticle.startColor = new Color(0.3f, 0.8f, 1);
                break;
        }

        GetComponent<Rigidbody2D>().velocity = new Vector2(0, -startSpeed);
    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    void death()
    {
        trailParticle.emissionRate = 0;
        Destroy(Phys);
        Destroy(gameObject, 1);
        explode.transform.parent = null;
        explode.Play();
        Destroy(explode.gameObject, 1);
        Destroy(pointLight);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, -startSpeed);
            if (collision.gameObject.GetComponent<BulletColorBehaviour>().colorType == colorType)
            {
                death();
                GameObject.Find("GameManager").GetComponent<ScoreKeeper>().scoreUp(100*collision.gameObject.GetComponent<BulletColorBehaviour>().mult);
            }
            else
                GetComponent<Rigidbody2D>().velocity = new Vector2(0, -startSpeed * 1.5f);
        }
        if (collision.gameObject.tag == "Back")
        {
            death();
            GameObject.Find("GameManager").GetComponent<ScoreKeeper>().healthDown(10);
        }
    }
}
