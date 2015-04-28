using UnityEngine;
using System.Collections;

public class scroll : MonoBehaviour {

	public GameObject gui;

	// Use this for initialization
	void Start () {
	
	}
	
	public void changeSize(float mult){
		this.GetComponent<Camera>().orthographicSize *= mult;
		//gui.transform.localScale = new Vector3 (mult / 8, mult / 8, gui.transform.localScale.z);
		//float higth = 6.25f;
		//if( mult==16) {
		//higth=11.5f;
		//}
		//gui.transform.position=new Vector3(gui.transform.position.x,higth,gui.transform.position.z);

	}

	void OnMouseOver() {
	}

	// Update is called once per frame
	void Update () {
	
	}
}
