using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour {

	Animator ani;

	// Use this for initialization
	void Start () {

		ani = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other){
	
		ani.SetTrigger ("OpenDoor");
	
	}

	void OnTriggerExit(Collider other){

		ani.enabled = true;

	}

	void pauseAnimation(){

		ani.enabled = false;
	}
}
