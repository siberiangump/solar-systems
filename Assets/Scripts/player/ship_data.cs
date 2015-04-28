using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ship_data : MonoBehaviour {

	public GameObject motor_part;
	public GameObject battery_part;
	public GameObject front_weapon_left_part;
	public GameObject front_weapon_right_part;
	public GameObject back_weapon_left_part;
	public GameObject back_weapon_right_part;
	public GameObject shield_part;


	public slot motor;
	public slot battery;
	public slot front_weapon_left;
	public slot front_weapon_right;
	public slot back_weapon_left;
	public slot back_weapon_right;
	public slot shield;

	public int mass;
	public int max_mass;
	public int battery_used;
	public int battery_charge;
	public int max_trunk_slots;
	public ArrayList trunk;


	// Use this for initialization
	void Start () {

	}

	public void Init(){
		this.motor = new slot (slot_type.engin, true, false,this.gameObject);
		if (motor_part != null) {
			this.motor.attachPatr(motor_part.GetComponent<ship_part>());
		}
	}

	// Update is called once per frame
	void Update () {
	
	}
}