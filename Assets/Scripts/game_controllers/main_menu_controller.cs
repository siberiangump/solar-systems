using UnityEngine;
using System.Collections;

public class main_menu_controller : MonoBehaviour {
	
	flag_camp flags;

	// Use this for initialization
	void Start () {
	}


	public void goStartNewGame() {
		PlayerPrefs.SetFloat ("player_position_x", 0);
		PlayerPrefs.SetFloat ("player_position_y", 0);
		Application.LoadLevel ("universe");
		GameObject gmo = GameObject.Instantiate(Resources.Load ("god")) as GameObject;
	//	gmo.BroadcastMessage ("dayOne");
	}


	// Update is called once per frame
	void Update () {
	
	}
}
