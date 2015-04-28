using UnityEngine;
using System.Collections;

public class motor : flag_listener {

	
	public float speed = 10.0F;
	public float dex = 2;
	public GameObject childSprite;
	GameObject pointer;
	public GameObject goToTarget=null;
	// Use this for initialization
	void Start () {
		goToTarget = null;
	}

	public void init(float speed,float dex,int mass){
		speed = speed;
		dex = dex;
	} 

	public override void OnPlayUpdate() {

		if(goToTarget==null){
			moveViaController();
		}else{
			moveViaTarget();
		}

	}

	public void goTo(string gmoName){
		pointer = this.GetComponent<mouse_move_cursor> ().target;
		pointer.GetComponent<LineRenderer> ().enabled = true;
		pointer.GetComponent<DrawLineToTarget> ().enabled = true;
		goToTarget = GameObject.Find (gmoName);
		pointer.transform.position = goToTarget.transform.position;

	}

	private void moveViaController(){
		float y = Input.GetAxis ("Vertical") * speed;
		float x = Input.GetAxis ("Horizontal") * speed;
		
		if (x != 0 || y != 0) {
			float rot_z = Mathf.Atan2 (y, x) * Mathf.Rad2Deg;
			//childSprite.transform.rotation = Quaternion.Euler (0f, 0f, rot_z - 90);
			transform.Rotate(new Vector3(0,0,rot_z - 90) * Time.deltaTime);

			y *= Time.deltaTime;
			x *= Time.deltaTime;
			transform.Translate (x, y, transform.position.z);
		}
	}

	private void moveViaTarget(){
		pointer.transform.position = goToTarget.transform.position;
		float y1 = goToTarget.transform.position.y-this.transform.position.y;
		float x1 = goToTarget.transform.position.x-this.transform.position.x;
		
		transform.Translate (new Vector3(1,0,0).normalized  * Time.deltaTime * speed);
		
		float rot_z = Mathf.Atan2 (y1, x1) * Mathf.Rad2Deg;
		if (rot_z < 0) rot_z = 360 + rot_z;
		//childSprite.transform.rotation = Quaternion.Euler (0f, 0f, rot_z - 90);
		float this_z = this.transform.rotation.eulerAngles.z;
		//if(this_z< 90 && rot_z > 270)this_z+=360;
		//if(rot_z< 90 && this_z > 270)rot_z+=360;

		if (this_z - rot_z > 10 && this_z - rot_z < 180 || rot_z - this_z > 180 && rot_z - this_z < 350) {
						transform.Rotate (new Vector3 (0, 0, -90) * Time.deltaTime * dex, Space.World);
		} else if (rot_z - this_z > 10 && rot_z - this_z < 180 || this_z - rot_z > 180 && this_z - rot_z < 350) {
						transform.Rotate (new Vector3 (0, 0, 90) * Time.deltaTime * dex, Space.World);
		}
		if(Vector3.Distance(this.transform.position,goToTarget.transform.position)<goToTarget.transform.lossyScale.x){
			goToTarget.BroadcastMessage("OnPlayerTouch");
			goToTarget=null;
		}
		float y = Input.GetAxis ("Vertical") * speed;
		float x = Input.GetAxis ("Horizontal") * speed;
		if(x > 0 || y > 0){
			goToTarget=null;
		}
	}
}
