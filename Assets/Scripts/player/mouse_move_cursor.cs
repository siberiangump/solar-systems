using UnityEngine;
using System.Collections;

public class mouse_move_cursor : flag_listener {

	public GameObject target;
	GameObject player;
	GameObject camera;
	public Material line;

	void initPointer(){
		target = GameObject.CreatePrimitive (PrimitiveType.Cube) as GameObject;
		target.name = "pointer";
		target.GetComponent<Renderer>().enabled = false;
		target.AddComponent<pointer> ();
		target.AddComponent<LineRenderer> ();
		target.GetComponent<LineRenderer> ().material=line;
		target.AddComponent<DrawLineToTarget> ();
		target.GetComponent<DrawLineToTarget> ().destination = this.gameObject;
	}

	public override void OnUniverseUpdate () {

		GameObject gmo = GameObject.FindGameObjectWithTag ("flag_camp");
		if( gmo == null )gmo = GameObject.Instantiate(Resources.Load("prefabs/controller/flag_camp")) as GameObject;
		flags = gmo.GetComponent<flag_camp> ();

		if(camera==null)
		camera = GameObject.Find ( "universe_camera" )as GameObject;



		if (target == null) {
			initPointer();
		}

		if (Input.GetMouseButtonUp (0)&& !flags.blockedByUI) {
			target.GetComponent<LineRenderer> ().enabled = true;
			target.GetComponent<DrawLineToTarget> ().enabled = true;
			Vector2 mousePos = Input.mousePosition;
			Vector3 wantedPos = Camera.main.ScreenToWorldPoint (new Vector3 (mousePos.x, mousePos.y, 14.0f)); 
			target.transform.position = wantedPos;
			this.BroadcastMessage ("goTo", target.name);
		}

			
	}
}
