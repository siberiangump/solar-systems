using UnityEngine;
using System.Collections;

public class GMOButton_bool : MonoBehaviour {

	public bool value;
	public bool switcher;
	public GameObject target;
	public string targetName;
	public string metod;

	// Use this for initialization
	void Start () {
		if (switcher)value = false;
	}


	void OnMouseUp() {
		if (switcher) 
			value = !value;		
		if (target == null)
			target = GameObject.Find (targetName) as GameObject;
		target.BroadcastMessage (metod, value);
	}
	// Update is called once per frame
	void Update () {
	
	}
}
