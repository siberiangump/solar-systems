using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public abstract class active_quest : MonoBehaviour {

	Dictionary <string,int> reward;

	void Start () {
		reward = new Dictionary<string, int> ();
	}

	public abstract void init (GameObject target);
	public abstract void finish ();
	public abstract void fail ();


}
