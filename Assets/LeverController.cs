using UnityEngine;
using System.Collections;

public class LeverController : MonoBehaviour {
	public bool lv1;
	public bool lv2;
	public bool lv3;
	public bool lv1Lock;
	public bool lv2Lock;
	public bool lv3Lock;
	public bool MOT;
	bool unlock;
	CageFall cf;
//	Lever1 lev1;
//	Lever2 lev2;
//	Lever3 lev3;
	// Use this for initialization
	void Start () {
		lv1 = false;
		lv2 = false;
		lv3 = false;
		lv1Lock = false;
		lv2Lock = false;
		lv3Lock = false;
		MOT = true;
		unlock = false;
		cf = GameObject.Find ("cage").GetComponent<CageFall> ();
//		lev1 = GetComponent<Lever1>();
//		lev2 = GetComponent<Lever2>();
//		lev3 = GetComponent<Lever3>();
	}
	
	// Update is called once per frame
	void Update () {
	if (lv1 == true || lv1Lock == true) {
			lv1Lock = true;

			//print("First lock is away");
			if(lv2 == true || lv2Lock == true)
			{
				lv2Lock = true;

				//print("Second lock is away");
				if(lv3 == true || lv3Lock == true)
				{
					lv3Lock = true;
					//print("Third lock is away");
					//lv3 = false;
					unlock = true;
				}
				else if(lv2Lock == true && lv1 == true)
				{
					reset ();
				}
			}
			else if((lv2Lock == true && lv1 == true) || (lv1Lock == true && lv3 == true))
			{
				reset ();
			}
				}
		lv1 = false;
		lv2 = false;
		lv3 = false;
		if (unlock == true) {
			cf.trigger = true;
				}
//		lv1 = false;
//		lv2 = false;
//		lv3 = false;
	}
	void reset(){
		lv1 = false;
		lv2 = false;
		lv3 = false;
		lv1Lock = false;
		lv2Lock = false;
		lv3Lock = false;
		print ("RESET");
		}
}
