using UnityEngine;
using System.Collections;

public class Doors : MonoBehaviour {
	float ticksToOpen;
	// Use this for initialization
	void Start () {
		//ticksToOpen = 3;
	}
	
	// Update is called once per frame
	void Update () {
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
