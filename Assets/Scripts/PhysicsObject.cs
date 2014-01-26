using UnityEngine;
using System.Collections;



public class PhysicsObject : MonoBehaviour {
	public Shader shader1;
	bool grabbed;
	// Use this for initialization

	void Start () {
		name = "box";

	}
	
	// Update is called once per frame
	void Update () {
		if (grabbed==false)
		{
			shader1= Shader.Find("Diffuse");
			this.gameObject.renderer.material.shader = shader1;
			
		}
	}

//	void getHeld(Vector3 Rotation, Vector3 Position){
//		this.gameObject.transform.position = Rotation;
//		this.gameObject.transform.position = Position;
//	}

}
