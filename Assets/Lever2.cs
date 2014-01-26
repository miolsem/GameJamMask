﻿using UnityEngine;
using System.Collections;

public class Lever2 : MonoBehaviour {

	bool transparent;
	LeverController lvc;
	Texture2D invisible;
	Texture2D visible;
	Material visib;
	int reset;
	// Use this for initialization
	void Start () {
		name = "lv2";
		lvc = GameObject.Find ("LeverController").GetComponent<LeverController> ();
		invisible = (Texture2D)Resources.Load ("invisibleShader", typeof (Texture2D));
		visible = (Texture2D)Resources.Load ("visibleShader", typeof (Texture2D));
		//visib.mainTexture = Resources.Load ("visibleShader.png");
		//renderer.material.SetTexture("visibleShader.png", visible);
		//visible.LoadImage (visibleShader.png);
		//visible.LoadImage (visibleShader.png);
		reset = 0;
	}
	
	// Update is called once per frame
	void Update () {

//		if (Input.GetButton ("Lever2")) {
//			
//			if(reset <= 0){
//				lvc.lv2 = true;
//				reset = 12;
//
//			}
//		}
//		if (lvc.MOT == true && (lvc.lv2Lock == true || lvc.lv1Lock == false)) {
//			//renderer.material.mainTexture = "invisibleShader";
//			renderer.material.mainTexture = invisible;
//		}
//		else if( lvc.MOT == false || (lvc.MOT == true && lvc.lv2Lock == false && lvc.lv1Lock == true)){
//			renderer.material.mainTexture = visible;
//		}
//		reset --;
		if (lvc.MOT == true && (lvc.lv2Lock == true || lvc.lv1Lock == false)) {
			//renderer.material.mainTexture = "invisibleShader";
			renderer.material.mainTexture = invisible;
		}
		else if( lvc.MOT == false || (lvc.MOT == true && lvc.lv2Lock == false && lvc.lv1Lock == true)){
			renderer.material.mainTexture = visible;
		}
		reset --;
	}
	public void OnMouseDown(){
		print ("lever2!");	
			if(reset <= 0){
				lvc.lv2 = true;
				reset = 12;
				
			}


	}

}
