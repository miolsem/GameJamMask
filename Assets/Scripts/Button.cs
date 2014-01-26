using UnityEngine;
using System.Collections;

public class Button : MonoBehaviour {
	public bool press = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//if (press == true)
			//this.gameObject.transform.position -= new Vector3 (0, -2, 0);
	}
	
	void OnCollisionEnter(Collision collision)
	{
		print ("dnjfinilfa");
		if (collision.gameObject.tag == "Box")
			press = true;
	}
}
