using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletParticleSystem : MonoBehaviour {

    public ParticleSystem Trail;

	// Update is called once per frame
	void Update ()
    {
        
	}

    //private void destroyParticle()
    //{
    //    Destroy(Trail, 1);
    //}

    private void OnDestroy()
    {
        Trail.transform.parent = null;
    }
}