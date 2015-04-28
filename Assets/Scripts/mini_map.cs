using UnityEngine;
using System.Collections;

public class mini_map : flag_listener {

	bool show;

	public void SwitchState(){
		show = !show;
		this.GetComponent<Camera>().enabled = show;
		this.GetComponent<MouseHolder> ().enabled = show;
		if (show) {
			Vector3 v = GameObject.FindGameObjectWithTag ("Player").transform.position;
			this.transform.position = new Vector3 (v.x, v.y, this.transform.position.z);
		}
		flags.blockedByUI = show;
	}
	
}
