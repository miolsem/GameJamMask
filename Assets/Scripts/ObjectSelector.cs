using UnityEngine;
using System.Collections;

//using Lever1;
//using Lever2; 
//using Lever3;

public class ObjectSelector : MonoBehaviour {
	public Shader shader1;
	public Shader shader2;
	Lever1 lv1;
	Lever2 lv2;
	Lever3 lv3;
	GameObject objectHeld;
	GameObject  objectSelected;
	// Use this for initialization
	void Start () {
		shader2= Shader.Find("Toon/Lighted Outline");
		shader1= Shader.Find("Diffuse");
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
								}
							if (hit.transform.tag == "Switches")
							{
								objectSelected = hit.transform.gameObject;
								objectSelected.renderer.material.shader = shader2;
								if (Input.GetMouseButtonDown (0)) {
//									if (objectSelected.name=="lv1"){
//										lv1= (Lever1)FindObjectOfType(typeof(Lever1));
//							lv1.Toggle();}
//									if (objectSelected.name=="lv2"){
//										lv2= (Lever2)FindObjectOfType(typeof(Lever2));
//							lv2.Toggle();}
//									if (objectSelected.name=="lv3"){
//										lv3= (Lever3)FindObjectOfType(typeof(Lever3));
//							lv3.Toggle();}
								}
							}

						else {
							if (objectSelected!=null){//print ("I'm looking at useless stuff!");
							objectSelected.renderer.material.shader=shader1;
							objectSelected = null;
							}
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
								objectHeld.rigidbody.AddForce (800 * objectHeld.transform.forward);
								objectHeld = null;
						}
				}
		//print (objectHeld);
	}
}
