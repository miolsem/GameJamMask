using UnityEngine;
using System.Collections;



public class ObjectSelector : MonoBehaviour {
	GameObject objectHeld;
	GameObject objectSelected;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (objectHeld == null) 
		{
			//Pick up objects
			Ray ray = camera.ViewportPointToRay (new Vector3 (0.5F, 0.5F, 0));
			RaycastHit hit;
			if (Physics.Raycast (ray, out hit)) {
				if (hit.transform.name == "box") {
						print ("I'm lookin at a box, m8!");
					objectSelected=hit.transform.gameObject;

					//if 
				}
			} 
			else {
					print ("I'm looking at useless stuff!");
			}
		}
		else
		{

		}
	}
}
