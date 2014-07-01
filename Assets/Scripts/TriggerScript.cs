using UnityEngine;
using System.Collections;

public class TriggerScript : MonoBehaviour {

	//public AudioSource [] sounds; 
	//public AudioSource sound1;

	// Use this for initialization
	void Start () {

		//sounds = GetComponents<AudioSource>();
		//sound1 = sounds [0];
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D gameObject){

		if (gameObject.tag == "Island1"){

			//audio.Play("Theme1");
			audio.Play ();
			//audio.PlayOneShot("ShipsStem");
			Debug.Log ("It works!");

		if (gameObject.tag == "Fungi1");{

			audio.Play();
			Debug.Log ("Here's to hoping!");
		}
	}

		else audio.Stop ();


	}
}
