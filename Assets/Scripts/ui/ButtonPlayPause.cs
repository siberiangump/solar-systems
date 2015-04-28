using UnityEngine;
using System.Collections;

public class ButtonPlayPause : ui_element {

	//flag_camp flags; 
	public GameObject targetView;
	public Sprite play;
	public Sprite pause;

	// Use this for initialization
	void Start () {
		flags = GameObject.FindGameObjectWithTag ("god").GetComponent<flag_camp> ();
	}

	void OnMouseUp() {
		if(flags==null)flags = GameObject.FindGameObjectWithTag ("god").GetComponent<flag_camp> ();

		flags.play = !flags.play;
		if (flags.play) {
			targetView.GetComponent<SpriteRenderer> ().sprite = pause;
		} else {
			targetView.GetComponent<SpriteRenderer> ().sprite = play;
		}
	}


}
