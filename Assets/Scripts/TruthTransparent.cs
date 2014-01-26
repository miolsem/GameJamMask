using UnityEngine;
using System.Collections;

public class TruthTransparent : MonoBehaviour {
	Player play;
	// Use this for initialization
	void Start () {
		play = GameObject.Find ("First Person Controller").GetComponent<Player> ();

	}
	
	// Update is called once per frame
	void Update () {
		//print (play.Masknum);
		if (play.Masknum == 1) {
						SetTargetInvisible (gameObject);
						
				} else {
			ReverseTargetInvisible(gameObject);
				}
	}

	void SetTargetInvisible(GameObject Target)
		
	{
		
		Component[] a = Target.GetComponentsInChildren(typeof(Renderer));
		
		foreach (Component b in a)
			
		{
			
			Renderer c = (Renderer)b;
			
			c.enabled = false;
			
		}
		
	}
	void ReverseTargetInvisible(GameObject Target)
		
	{
		
		Component[] a = Target.GetComponentsInChildren(typeof(Renderer));
		
		foreach (Component b in a)
			
		{
			
			Renderer c = (Renderer)b;
			
			c.enabled = true;
			
		}
		
	}
}
