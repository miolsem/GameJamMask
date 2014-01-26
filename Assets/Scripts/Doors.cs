using UnityEngine;
using System.Collections;

public class Doors : MonoBehaviour {
	float ticksToOpen;
	bool firstTime=true;
	Button butt;
	// Use this for initialization
	void Start () {
		butt = GameObject.Find ("PhysButton").GetComponent<Button> ();
		//ticksToOpen = 3;
	}
	
	// Update is called once per frame
	void Update () {
		print (butt.press);
		if (butt.press == true && firstTime == true) {
			ticksToOpen=3;
			firstTime=false;
				}
						
		if (ticksToOpen > 0) {
						if (this.gameObject.name == "Door1")
								this.gameObject.transform.position += -this.gameObject.transform.right * .2F;
						if (this.gameObject.name == "Door2")
								this.gameObject.transform.position += -this.gameObject.transform.right * .2F;
						ticksToOpen -= 0.2F;
				}
	}
	void startOpen()
	{
		ticksToOpen = 3;
	}
}
