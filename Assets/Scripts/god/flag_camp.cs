using UnityEngine;
using System.Collections;

public class flag_camp : MonoBehaviour {

	public bool play = true;
	public GameObject currentPlanet;
	public bool blockedByUI = false;
	public bool blockedBySpaceObject = false;
	// Use this for initialization
	void Start () {
	
	}

	void OnLevelWasLoaded(int level) {
		play = true;
		blockedByUI = false;
		blockedBySpaceObject = false;
	}

	public void setPlay(bool value){
		play = value;
	}

	public void setBlockedByUI(bool value){
		blockedByUI = value;
	}

	// Update is called once per frame
	void Update () {
	
	}
}
