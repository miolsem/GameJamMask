﻿using UnityEngine;
using System.Collections;

public class CageFall : MonoBehaviour {
	public int cageSpeed;
	bool trigger;
	// Use this for initialization
	void Start () {
		cageSpeed = 6;
		trigger = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButton ("CageTrigger")) {
			trigger = true;
				}
	if (trigger == true) {
			transform.Translate(Vector3.down * Time.deltaTime);
				}
	}
}
