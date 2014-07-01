using UnityEngine;
using System.Collections;

public class TriggerScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
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
		}

		else audio.Stop ();


	}
}
