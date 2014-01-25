using UnityEngine;
using System.Collections;



public class PhysicsObject : MonoBehaviour {

	bool grabbed;
	// Use this for initialization

	void Start () {
		name = "box";
	}
	
	// Update is called once per frame
	void Update () {
		if (grabbed==true)
		{
			//transform.eulerAngles.x = 0;
			//transform.eulerAngles.y = 0;
			
		}
	}

}
