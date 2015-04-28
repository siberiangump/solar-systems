using UnityEngine;
using System.Collections;

public class engine : ship_part{

	public float speed;
	public float dex;
	public int energy_requestments;

	// Use this for initialization
	void Start () {
	
	}

	public override void init (GameObject parent){
		parent.GetComponent<motor> ().init (speed, dex, parent.GetComponent<ship_data> ().mass);
	}

	public override bool check_requestments (GameObject parent){
		bool value = true;
		if (parent.GetComponent<ship_data> ().mass + this.mass > parent.GetComponent<ship_data> ().max_mass) {
			value = false;
		}
		if (parent.GetComponent<ship_data> ().battery_used + this.energy_requestments > parent.GetComponent<ship_data> ().battery_charge) {
			value = false;		
		}
		return value;
	}
	// Update is called once per frame
	void Update () {
	
	}
}
