using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	Vector3 iniPos;
	Vector3 newPos;

	// Use this for initialization
	void Start () {
	
		iniPos = gameObject.transform.position;
	}

	float xValue;
	float zValue;

	// Update is called once per frame
	void Update () {

		if (Input.GetKey (KeyCode.RightArrow)) {
		
			zValue += 0.08f;
			newPos = new Vector3 (xValue, 0, zValue) + iniPos;
			gameObject.transform.position = newPos;
			
		}

		if (Input.GetKey (KeyCode.LeftArrow)) {

			zValue -= 0.08f;
			newPos = new Vector3 (xValue, 0, zValue) + iniPos ;
			gameObject.transform.position = newPos;

		}

		if (Input.GetKey (KeyCode.UpArrow)) {

			xValue -= 0.08f;
			newPos = new Vector3 (xValue, 0, zValue) + iniPos;
			gameObject.transform.position = newPos;

		}
		if (Input.GetKey (KeyCode.DownArrow)) {

			xValue += 0.08f;
			newPos = new Vector3 (xValue, 0, zValue) + iniPos;
			gameObject.transform.position = newPos;

		}

	}
}
