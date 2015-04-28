using UnityEngine;
using System.Collections;

public class planet : flag_listener {

	public GameObject solar;
	public int direction=1;
	public Sprite back;

	float speed;
	bool solarHasInitiated=false;

	public void initSolar(GameObject solar){
		speed = 50/Vector3.Distance (solar.transform.position, this.transform.position);
		this.GetComponent<SpriteRenderer>().color = new Color(solar.GetComponent<solar>().aura.r
		                                                      ,solar.GetComponent<solar>().aura.g
		                                                      ,solar.GetComponent<solar>().aura.b
		                                                      ,1);
		solarHasInitiated = true;
	}

	public void OnPlayerTouch(){
		flags.currentPlanet = this.gameObject;
		GameObject.FindGameObjectWithTag("scene_controller").BroadcastMessage("GoToPlanet");
	}

	public override void OnPlayUpdate () {

		if (solar != null) {
			if( solarHasInitiated ){
				transform.RotateAround(solar.transform.position, new Vector3(0,0,direction), speed * Time.deltaTime);
				transform.RotateAround(this.transform.position, new Vector3(0,0,direction), speed * Time.deltaTime);
			}else{
				initSolar(solar);
			}
		}
	}
}
