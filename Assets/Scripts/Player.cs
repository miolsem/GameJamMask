using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	public int Masknum;
	int dashCounter;
	int dashRecharge;
	CharacterMotor controller;
	public bool strong;
	public bool fire;
	// Use this for initialization
	void Start () {
		//this.gameObject.name = "player";
		Masknum = 2; //1= Mask of Truth
					//2= Dash mask
					//3= Strong Mask
					//4= Fire Mask
					
		dashCounter = 0;
		dashRecharge = 0;
		strong = true;
		fire = true;
	}
	
	// Update is called once per frame
	void Update () {
		Screen.lockCursor = true;

		if (Input.GetButton ("MaskofTruth")) {
			Masknum = 1;
			print ("MaskoTruth on");
				}
		if (Input.GetButton ("SpeedMask")) {
			Masknum = 2;
			print ("sprint on");
		}
		if (Input.GetButton ("StrongMask")) {
			if(strong == true)
			{
				Masknum = 3;
				print ("strong on");
			}
		}
		if (Input.GetButton ("FireMask")) {
			if(fire == true)
			{
				Masknum = 4;
				print ("fire on");
			}
		}


		if (Masknum == 2) {
			if(Input.GetButton("Dash"))
			{
				if(dashRecharge <= 0)
				{
				controller = GetComponent<CharacterMotor>();

				controller.SetVelocityDash(transform.forward);
				
				dashRecharge = 100;
					dashCounter = 22;
					print("HIT");
				}


//				GameObject gameobj; 
//				gameobj.GetComponent<CharacterMotor>();
//				gameobj.
			}

				}
		if (Masknum == 4) {
			
		}
		dashRecharge --;
		dashCounter --;
//		if (dashCounter <= 0) {
//			controller.SetVelocityDashUndo(transform.forward );
				//}
	
	}
}
