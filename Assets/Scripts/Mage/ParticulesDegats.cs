﻿using UnityEngine;
using System.Collections;

public class ParticulesDegats : Photon.MonoBehaviour {

    public int degats;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnParticleCollision(GameObject other)
    {
        other.SendMessage("sendDamage", degats, SendMessageOptions.DontRequireReceiver);
        other.SendMessage("getLastDegats", other.name, SendMessageOptions.DontRequireReceiver);
    }

}