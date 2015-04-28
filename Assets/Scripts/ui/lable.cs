using UnityEngine;
using System.Collections;

public class lable : MonoBehaviour {

	public GameObject target;
	bool targetInitiated=false;

	// Use this for initialization
	void Start () {
	
	}

	public void initTarget(GameObject target){
		this.GetComponent<TextMesh> ().text = target.name;
		targetInitiated = true;
	}

	// Update is called once per frame
	void Update () {
		if (target != null) {
			if(targetInitiated){
			}else{
				initTarget(target);
			}	
		}
	}
}
