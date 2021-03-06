﻿using UnityEngine;
using System.Collections;

public class PlayerShipController : MonoBehaviour {

	public  ParticleEmitter thrustEmitter;

	public float palyerSpeed;

	public string playerHoriz = "Horizontal";
	public string playerVert = "Vertical";


	// Use this for initialization
	void Start () {
		thrustEmitter.emit = false;
	}
	
	// Update is called once per frame
	void Update () {
		MovePlayer();
	}

	// SCRIP API //

	void MovePlayer()
	{
		bool thrustButtonPress = false;

		transform.Translate(Vector3.right * (Input.GetAxis(playerHoriz) * Time.deltaTime * palyerSpeed));
		transform.Translate(Vector3.forward * (Input.GetAxis(playerVert) * Time.deltaTime * palyerSpeed));

		if(Input.GetAxis("Horizontal") != 0.0f ) 
		{
			thrustButtonPress = true;
		}

		if(Input.GetAxis("Vertical") != 0.0f ) 
		{
			thrustButtonPress = true;
		}


		if(thrustButtonPress) 
		{
			thrustEmitter.emit = true;
			GetComponent<AudioSource>().enabled = true;
		}
		else
		{
			thrustEmitter.emit = false;
			GetComponent<AudioSource>().enabled = false;
		}


	}
}
