using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	int Masknum;
	int dashCounter;
	int dashRecharge;
	CharacterMotor controller;
	// Use this for initialization
	void Start () {
		//this.gameObject.name = "player";
		Masknum = 4; //1= Mask of Truth
					//2= Strong Mask
					//3= Fire Mask
					//4= Dash mask
		dashCounter = 0;
		dashRecharge = 0;

	}
	
	// Update is called once per frame
	void Update () {
		Screen.lockCursor = true;
		if (Masknum == 4) {
			if(Input.GetButton("Dash"))
			{
				if(dashRecharge <= 0)
				{
				controller = GetComponent<CharacterMotor>();

				controller.SetVelocityDash(transform.forward);
				
				dashRecharge = 100;
					dashCounter = 22;
					//print("HIT");
				}


//				GameObject gameobj; 
//				gameobj.GetComponent<CharacterMotor>();
//				gameobj.
			}

				}
		dashRecharge --;
		dashCounter --;
//		if (dashCounter <= 0) {
//			controller.SetVelocityDashUndo(transform.forward );
				//}
	
	}
}
