using UnityEngine;
using System.Collections;

public class MouseHolder : MonoBehaviour {
	public Vector3 startMoveVector;
	public float swape;
	public Vector3 moveVector,p;
	public GameObject target; 
	public Vector2 mp;
	public Camera other;

	// Update is called once per frame
	void Update () {
		Vector3 mousePos;
		mousePos = Input.mousePosition;
		//if (target != null) {
		//	p = this.camera.ScreenToWorldPoint (new Vector3 (mousePos.x, mousePos.y, 10));
	//		target.transform.position = p;
	//		if (Input.GetMouseButtonUp (0)){
	//			target.BroadcastMessage("goToDefaultLayer",SendMessageOptions.DontRequireReceiver);
	//			target = null;
	//		}
	//			
	//	}else 
		if (Input.GetMouseButton (0)) {
			p = this.GetComponent<Camera>().ScreenToWorldPoint (new Vector3 (mousePos.x, mousePos.y,0));
			moveVector = new Vector3(startMoveVector.x-p.x,startMoveVector.y-p.y,0);
			this.transform.position+=moveVector;
			p = this.GetComponent<Camera>().ScreenToWorldPoint (new Vector3 (mousePos.x, mousePos.y,0));
			startMoveVector = p;
		}
		p = this.GetComponent<Camera>().ScreenToWorldPoint (new Vector3 (mousePos.x, mousePos.y,0));
		startMoveVector = p;
		//mousePos = Input.mousePosition;
		//p = camera.ScreenToWorldPoint (new Vector3 (mousePos.x, mousePos.y, 10));

	}
}
