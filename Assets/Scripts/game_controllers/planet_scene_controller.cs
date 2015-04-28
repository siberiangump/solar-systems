using UnityEngine;
using System.Collections;

public class planet_scene_controller : flag_listener {

	flag_camp flags;

	// Use this for initialization
	void Start () {
		GameObject gmo = GameObject.FindGameObjectWithTag ("flag_camp");
		if( gmo == null )gmo = GameObject.Instantiate(Resources.Load("prefabs/controller/flag_camp")) as GameObject;
		flags = gmo.GetComponent<flag_camp> ();
	}

	void goToGlobalMap() {
		Application.LoadLevel ("universe");
		
		//prepear
		PlayerPrefs.SetFloat ("player_position_x", flags.currentPlanet.transform.position.x);
		PlayerPrefs.SetFloat ("player_position_y", flags.currentPlanet.transform.position.y);

		GameObject.FindGameObjectWithTag("universe").SetActive (true);
	}


	// Update is called once per frame
	void Update () {
	
	}
}
