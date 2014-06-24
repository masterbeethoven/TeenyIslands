﻿using UnityEngine;
using System.Collections;

public class PlayerBehavior: MonoBehaviour {

	public Vector2 speed = new Vector2(10,10);

	private Vector2 movement;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		float inputX = Input.GetAxis("Horizontal");
		float inputY = Input.GetAxis ("Vertical");

		movement = new Vector2(
			speed.x * inputX, 
			speed.y * inputY);
	
	}

	void FixedUpdate()
	{
		rigidbody2D.velocity = movement;

	}
}
