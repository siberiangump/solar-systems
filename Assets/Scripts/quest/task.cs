using UnityEngine;
using System.Collections;

public abstract class task : MonoBehaviour {

	public GameObject target;
	public int credits;
	public GameObject UI;
	public Sprite[] portret;
	public Sprite port;


	// Use this for initialization

	public abstract void init();

	public abstract void confirm (GameObject gmo);

	public abstract void cancel ();
	
	void checkUI(){
		if (UI == null)
			UI = GameObject.FindGameObjectWithTag ("dialog");
	}
	// Update is called once per frame
	void Update () {
	
	}
}
