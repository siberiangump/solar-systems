using UnityEngine;
using System.Collections;

public class ui_element : flag_listener {

	void OnMouseEnter(){
		flags.blockedByUI = true;
	}
	
	
	void OnMouseExit(){
		flags.blockedByUI = false;
	}

}
