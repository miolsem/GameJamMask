using UnityEngine;
using System.Collections;

public class SPlat1 : MonoBehaviour {
	public float maxHeight;
	public float maxSpeed;
	bool triggered;
	float currentHeight;
	// Use this for initialization
	void Start () {
		maxSpeed = 0.25F;
		triggered = false;
		currentHeight = 0;

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButton ("SteamPlatformTrigger")) {
						triggered = true;
			print("IT'S ON");
		}
			else{
				triggered = false;
				}
	if (triggered == true) {
						if (currentHeight < maxHeight) {
								transform.Translate (Vector3.up * maxSpeed);
								currentHeight += maxSpeed;
						}
				} else if (triggered == false) {
			if(currentHeight > 0)
			{
			transform.Translate(Vector3.down * maxSpeed);
			currentHeight -= maxSpeed;
			}
				}
	
	}
}
