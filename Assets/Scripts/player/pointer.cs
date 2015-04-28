using UnityEngine;
using System.Collections;

public class pointer : MonoBehaviour {

	// Use this for initialization
	void Start () {
		OnPlayerTouch ();
	}

	public void OnPlayerTouch(){
		this.GetComponent<DrawLineToTarget> ().enabled = false;
		this.GetComponent<LineRenderer> ().enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
