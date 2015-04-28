using UnityEngine;
using System.Collections;

public class slot{
	public bool avalible;
	public bool locket;
	public slot_type type;
	public	GameObject ship;

	public ship_part part;
	
	public slot(slot_type t,bool avalible,bool locket,GameObject ship){
		type=t;
		this.avalible = avalible;
		this.locket = locket;
		this.ship = ship;
	}
	
	public void attachPatr(ship_part part){
		if (part.type == type) {
			if (avalible && !locket) {
				this.part = part;
			}
		}
	}
	
	public void attachPatr(ship_part part,bool needLock){
		if (avalible && !locket) {
			this.part = part;
			if( needLock )this.locket = needLock;
			part.init(ship); 
		}
	}
}

public enum slot_type { weapon, engin, shield, battery};
