using UnityEngine;
using System.Collections;

public class PhysButton : MonoBehaviour {
	bool press;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (press==true)
			animation.Play ("GitPressedSon");
	}

	void onCollisionEnter(Collision collision)
	{
		print ("dnjfinilfa");
		if (collision.gameObject.name == "box")
						press = true;
	}
}
