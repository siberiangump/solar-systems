using UnityEngine;
using System.Collections;

public class tumbler : ui_element {

	public GameObject target;
	public GameObject c_target;
	bool active;

	// Use this for initialization
	void Start () {
		active = false;
		if (target != null) {
						target.SetActive (active);
				}
		if (c_target != null) {
						c_target.GetComponent<fallower>().enabled= active;
				}
	}

	void OnMouseUp(){

		if (target != null) {
						active = !active;
						target.SetActive (active);
				}
		if (c_target != null) {
						active = !active;
						c_target.GetComponent<fallower>().enabled= active;
				}
		Debug.Log("aaaa");
	}

	// Update is called once per frame
	void Update () {
	
	}
}
