using UnityEngine;
using System.Collections;

public class FireMaskPickup : MonoBehaviour {
	Player play;
	// Use this for initialization
	void Start () {
		play = GameObject.Find ("First Person Controller").GetComponent<Player> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void OnMouseDown()
	{
		print ("firemask");
		
		play.fire = true;
	}
}
