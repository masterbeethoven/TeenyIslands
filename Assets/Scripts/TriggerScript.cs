﻿using UnityEngine;
using System.Collections;

public class TriggerScript : MonoBehaviour {



	// Use this for initialization
	void Start () {

		//sounds = GetComponents<AudioSource>();
		//sound1 = sounds [0];
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(){

		audio.Play ();
		collider2D.enabled = false;
		    
	}
}
