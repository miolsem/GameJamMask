﻿using UnityEngine;
using System.Collections;

public class LevelEnd : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter(Collision other)
	{
		if (other.gameObject.tag == "Player") {
			Application.LoadLevel ("Scene2");
			print ("derp");
				}
	}


}
