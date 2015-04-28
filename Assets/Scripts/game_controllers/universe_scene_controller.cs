using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class universe_scene_controller : flag_listener {

	//remove this 
	public Image pauseButton; 
	public Sprite play;
	public Sprite pause;

	public void SwitchGameState(){
		flags.play = !flags.play;

		//remove this 
		if (flags.play)
			pauseButton.sprite = pause;
		else pauseButton.sprite = play;
	}

	public void GoToPlanet(){
		Application.LoadLevel ("planet");
		GameObject.FindGameObjectWithTag("universe").SetActive (false);
	}

}
