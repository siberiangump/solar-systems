using UnityEngine;
using System.Collections;

public class planet_scene : MonoBehaviour {

	flag_camp flags;
	
	// Use this for initialization
	void Start () {
		
		flags = GameObject.FindGameObjectWithTag ("god").GetComponent<flag_camp> ();


	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
