using UnityEngine;
using System.Collections;

//using PhysicsObject;

public class ObjectSelector : MonoBehaviour {
	public Shader shader2;
	GameObject objectHeld;
	GameObject  objectSelected;
	// Use this for initialization
	void Start () {
		shader2= Shader.Find("Toon/Lighted Outline");
	}
	
	// Update is called once per frame
	void Update () {
		if (objectHeld == null) {
						//Pick up objects
						Ray ray = camera.ViewportPointToRay (new Vector3 (0.5F, 0.5F, 0));
						RaycastHit hit;
						if (Physics.Raycast (ray, out hit)) {
								if (hit.transform.name == "box") 
									if (hit.distance<2.5F){
										//print ("I'm lookin at a box, m8!");
										objectSelected = hit.transform.gameObject;
										objectSelected.renderer.material.shader = shader2;
										//print (objectSelected.name);
										if (Input.GetMouseButtonDown (0)) {
												objectHeld = objectSelected;
										}
										//if 
								} else {
										//print ("I'm looking at useless stuff!");
										objectSelected = null;
								}
						} 
				
				} else {
						//objectHeld.getHeld(this.gameObject.transform.rotation,this.gameObject.transform.position+new Vector3(0,1,.3F));
						objectHeld.transform.position = (this.gameObject.transform.position + new Vector3 (0F, 1.5F, 0F));
						objectHeld.transform.rotation = (this.gameObject.transform.rotation);

						if (Input.GetMouseButtonDown (0)) {
				objectHeld.transform.position = (this.gameObject.transform.position + 1.5F *this.gameObject.transform.forward +1.5F *this.gameObject.transform.up );
								objectHeld = null;
						}			
						if (Input.GetMouseButtonDown (1)) {
								objectHeld.rigidbody.AddForce (1100 * objectHeld.transform.forward);
								objectHeld = null;
						}
				}
		print (objectHeld);
	}
}
